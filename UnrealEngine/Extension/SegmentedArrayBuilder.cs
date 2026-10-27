using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Extension
{
	// Token: 0x02002AE2 RID: 10978
	[CompilerFeatureRequired("RefStructs")]
	internal ref struct SegmentedArrayBuilder<[Nullable(2)] T>
	{
		// Token: 0x060283FA RID: 164858 RVA: 0x003D3744 File Offset: 0x003D1944
		public SegmentedArrayBuilder([Nullable(new byte[]
		{
			0,
			1
		})] Span<T> scratchBuffer)
		{
			this._segments = default(SegmentedArrayBuilder<T>.Arrays);
			this._segmentsCount = 0;
			this._countInFinishedSegments = 0;
			this._countInCurrentSegment = 0;
			this._firstSegment = scratchBuffer;
			this._currentSegment = scratchBuffer;
		}

		// Token: 0x060283FB RID: 164859 RVA: 0x003D3784 File Offset: 0x003D1984
		public void Dispose()
		{
			int segmentsCount = this._segmentsCount;
			if (segmentsCount != 0)
			{
				this.ReturnArrays(segmentsCount);
			}
		}

		// Token: 0x060283FC RID: 164860 RVA: 0x003D37A4 File Offset: 0x003D19A4
		private unsafe void ReturnArrays(int segmentsCount)
		{
			ReadOnlySpan<T[]> readOnlySpan = <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<SegmentedArrayBuilder<T>.Arrays, T[]>(this._segments, 27);
			if (RuntimeHelpers.IsReferenceOrContainsReferences<T>())
			{
				segmentsCount--;
				ReadOnlySpan<T[]> readOnlySpan2 = readOnlySpan.Slice(0, segmentsCount);
				for (int i = 0; i < readOnlySpan2.Length; i++)
				{
					T[] array = *readOnlySpan2[i];
					Array.Clear(array);
					ArrayPool<T>.Shared.Return(array, false);
				}
				T[] array2 = *readOnlySpan[segmentsCount];
				Array.Clear(array2, 0, this._countInCurrentSegment);
				ArrayPool<T>.Shared.Return(array2, false);
				return;
			}
			for (int j = 0; j < readOnlySpan.Length; j++)
			{
				T[] array3 = *readOnlySpan[j];
				if (array3 == null)
				{
					break;
				}
				ArrayPool<T>.Shared.Return(array3, false);
			}
		}

		// Token: 0x1700999D RID: 39325
		// (get) Token: 0x060283FD RID: 164861 RVA: 0x003D385D File Offset: 0x003D1A5D
		public readonly int Count
		{
			get
			{
				return checked(this._countInFinishedSegments + this._countInCurrentSegment);
			}
		}

		// Token: 0x060283FE RID: 164862 RVA: 0x003D386C File Offset: 0x003D1A6C
		[NullableContext(1)]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe void AddNonICollectionRangeInlined(IEnumerable<T> source)
		{
			Span<T> currentSegment = this._currentSegment;
			int num = this._countInCurrentSegment;
			foreach (T t in source)
			{
				if (num < currentSegment.Length)
				{
					*currentSegment[num] = t;
					num++;
				}
				else
				{
					this.Expand(16);
					currentSegment = this._currentSegment;
					*currentSegment[0] = t;
					num = 1;
				}
			}
			this._countInCurrentSegment = num;
		}

		// Token: 0x060283FF RID: 164863 RVA: 0x003D3900 File Offset: 0x003D1B00
		[NullableContext(1)]
		internal readonly T[] ToSharedArray()
		{
			int count = this.Count;
			T[] array;
			if (count != 0)
			{
				array = ArrayPool<T>.Shared.Rent(count);
				this.ToSpanInlined(array);
			}
			else
			{
				array = Array.Empty<T>();
			}
			return array;
		}

		// Token: 0x06028400 RID: 164864 RVA: 0x003D3938 File Offset: 0x003D1B38
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe readonly void ToSpanInlined([Nullable(new byte[]
		{
			0,
			1
		})] Span<T> destination)
		{
			int num = this._segmentsCount;
			if (num != 0)
			{
				ReadOnlySpan<T> readOnlySpan = this._firstSegment;
				readOnlySpan.CopyTo(destination);
				destination = destination.Slice(readOnlySpan.Length);
				num--;
				if (num != 0)
				{
					ReadOnlySpan<T[]> readOnlySpan2 = <PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<SegmentedArrayBuilder<T>.Arrays, T[]>(this._segments, 27).Slice(0, num);
					for (int i = 0; i < readOnlySpan2.Length; i++)
					{
						ReadOnlySpan<T> readOnlySpan3 = *readOnlySpan2[i];
						readOnlySpan3.CopyTo(destination);
						destination = destination.Slice(readOnlySpan3.Length);
					}
				}
			}
			this._currentSegment.Slice(0, this._countInCurrentSegment).CopyTo(destination);
		}

		// Token: 0x06028401 RID: 164865 RVA: 0x003D39EC File Offset: 0x003D1BEC
		private unsafe void Expand(int minimumRequired = 16)
		{
			if (minimumRequired < 16)
			{
				minimumRequired = 16;
			}
			int length = this._currentSegment.Length;
			checked
			{
				this._countInFinishedSegments += length;
				if (this._countInFinishedSegments > Array.MaxLength)
				{
					throw new OutOfMemoryException();
				}
			}
			int minimumLength = (int)Math.Min(Math.Max((long)minimumRequired, (long)length * 2L), (long)Array.MaxLength);
			T[] array;
			*<PrivateImplementationDetails>.InlineArrayAsSpan<SegmentedArrayBuilder<T>.Arrays, T[]>(ref this._segments, 27)[this._segmentsCount] = (array = ArrayPool<T>.Shared.Rent(minimumLength));
			this._currentSegment = array;
			this._segmentsCount++;
		}

		// Token: 0x04016288 RID: 90760
		private const int ScratchBufferSize = 8;

		// Token: 0x04016289 RID: 90761
		private const int MinimumRentSize = 16;

		// Token: 0x0401628A RID: 90762
		private SegmentedArrayBuilder<T>.Arrays _segments;

		// Token: 0x0401628B RID: 90763
		[Nullable(new byte[]
		{
			0,
			1
		})]
		private Span<T> _firstSegment;

		// Token: 0x0401628C RID: 90764
		[Nullable(new byte[]
		{
			0,
			1
		})]
		private Span<T> _currentSegment;

		// Token: 0x0401628D RID: 90765
		private int _segmentsCount;

		// Token: 0x0401628E RID: 90766
		private int _countInFinishedSegments;

		// Token: 0x0401628F RID: 90767
		private int _countInCurrentSegment;

		// Token: 0x02003C0C RID: 15372
		[InlineArray(27)]
		private struct Arrays
		{
			// Token: 0x04017E44 RID: 97860
			[Nullable(1)]
			private T[] _values;
		}

		// Token: 0x02003C0D RID: 15373
		[InlineArray(8)]
		public struct ScratchBuffer
		{
			// Token: 0x04017E45 RID: 97861
			[Nullable(1)]
			private T _item;
		}
	}
}
