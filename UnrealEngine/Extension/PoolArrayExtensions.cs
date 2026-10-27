using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Extension
{
	// Token: 0x02002AE1 RID: 10977
	[NullableContext(1)]
	[Nullable(0)]
	public static class PoolArrayExtensions
	{
		// Token: 0x060283F8 RID: 164856 RVA: 0x003D36A0 File Offset: 0x003D18A0
		private static void ToSharedArray<[Nullable(2)] TSource>(IEnumerable<TSource> source, out TSource[] array, out int length)
		{
			ICollection<TSource> collection = source as ICollection<TSource>;
			if (collection == null)
			{
				SegmentedArrayBuilder<TSource>.ScratchBuffer scratchBuffer = default(SegmentedArrayBuilder<TSource>.ScratchBuffer);
				SegmentedArrayBuilder<TSource> segmentedArrayBuilder = new SegmentedArrayBuilder<TSource>(<PrivateImplementationDetails>.InlineArrayAsSpan<SegmentedArrayBuilder<TSource>.ScratchBuffer, TSource>(ref scratchBuffer, 8));
				segmentedArrayBuilder.AddNonICollectionRangeInlined(source);
				length = segmentedArrayBuilder.Count;
				array = segmentedArrayBuilder.ToSharedArray();
				segmentedArrayBuilder.Dispose();
				return;
			}
			int count = collection.Count;
			length = count;
			if (count == 0)
			{
				array = Array.Empty<TSource>();
				return;
			}
			array = ArrayPool<TSource>.Shared.Rent(count);
			collection.CopyTo(array, 0);
		}

		// Token: 0x060283F9 RID: 164857 RVA: 0x003D371C File Offset: 0x003D191C
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static PoolArray<TSource> ToPoolArray<[Nullable(2)] TSource>(this IEnumerable<TSource> source)
		{
			if (source == null)
			{
				throw new ArgumentNullException();
			}
			TSource[] inSharedArray;
			int inLength;
			PoolArrayExtensions.ToSharedArray<TSource>(source, out inSharedArray, out inLength);
			return new PoolArray<TSource>(inSharedArray, inLength);
		}
	}
}
