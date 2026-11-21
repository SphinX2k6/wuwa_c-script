using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Extension
{
	// Token: 0x02000891 RID: 2193
	[CompilerFeatureRequired("RefStructs")]
	internal ref struct SegmentedArrayBuilder<[Nullable(2)] T>
	{
		// Token: 0x0600BDAF RID: 48559 RVA: 0x0012EA54 File Offset: 0x0012CC54
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

		// Token: 0x0600BDB0 RID: 48560 RVA: 0x0012EA94 File Offset: 0x0012CC94
		public void Dispose()
		{
			int segmentsCount = this._segmentsCount;
			if (segmentsCount != 0)
			{
				this.ReturnArrays(segmentsCount);
			}
		}

		// Token: 0x0600BDB1 RID: 48561 RVA: 0x0012EAB4 File Offset: 0x0012CCB4
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

		// Token: 0x17002326 RID: 8998
		// (get) Token: 0x0600BDB2 RID: 48562 RVA: 0x0012EB6D File Offset: 0x0012CD6D
		public readonly int Count
		{
			get
			{
				return checked(this._countInFinishedSegments + this._countInCurrentSegment);
			}
		}

		// Token: 0x0600BDB3 RID: 48563 RVA: 0x0012EB7C File Offset: 0x0012CD7C
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

		// Token: 0x0600BDB4 RID: 48564 RVA: 0x0012EC10 File Offset: 0x0012CE10
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

		// Token: 0x0600BDB5 RID: 48565 RVA: 0x0012EC48 File Offset: 0x0012CE48
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

		// Token: 0x0600BDB6 RID: 48566 RVA: 0x0012ECFC File Offset: 0x0012CEFC
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

		// Token: 0x0400569F RID: 22175
		private const int ScratchBufferSize = 8;

		// Token: 0x040056A0 RID: 22176
		private const int MinimumRentSize = 16;

		// Token: 0x040056A1 RID: 22177
		private SegmentedArrayBuilder<T>.Arrays _segments;

		// Token: 0x040056A2 RID: 22178
		[Nullable(new byte[]
		{
			0,
			1
		})]
		private Span<T> _firstSegment;

		// Token: 0x040056A3 RID: 22179
		[Nullable(new byte[]
		{
			0,
			1
		})]
		private Span<T> _currentSegment;

		// Token: 0x040056A4 RID: 22180
		private int _segmentsCount;

		// Token: 0x040056A5 RID: 22181
		private int _countInFinishedSegments;

		// Token: 0x040056A6 RID: 22182
		private int _countInCurrentSegment;

		// Token: 0x02001415 RID: 5141
		[InlineArray(27)]
		private struct Arrays
		{
			// Token: 0x040068C5 RID: 26821
			[Nullable(1)]
			private T[] _values;
		}

		// Token: 0x02001416 RID: 5142
		[InlineArray(8)]
		public struct ScratchBuffer
		{
			// Token: 0x040068C6 RID: 26822
			[Nullable(1)]
			private T _item;
		}
	}
}
