using System;
using System.Buffers;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace UnrealEngine.Extension
{
	// Token: 0x02000890 RID: 2192
	[NullableContext(1)]
	[Nullable(0)]
	public static class PoolArrayExtensions
	{
		// Token: 0x0600BDAD RID: 48557 RVA: 0x0012E9B0 File Offset: 0x0012CBB0
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

		// Token: 0x0600BDAE RID: 48558 RVA: 0x0012EA2C File Offset: 0x0012CC2C
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
