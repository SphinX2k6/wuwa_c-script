using System;
using System.Collections.Concurrent;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000103 RID: 259
	internal sealed class ConcurrentQueueOfTConverter<TCollection, TElement> : IEnumerableDefaultConverter<TCollection, TElement> where TCollection : ConcurrentQueue<TElement>
	{
		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x00003363 File Offset: 0x00001563
		internal override bool CanPopulate
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00032F6A File Offset: 0x0003116A
		protected override void Add(in TElement value, ref ReadStack state)
		{
			((TCollection)((object)state.Current.ReturnValue)).Enqueue(value);
		}
	}
}
