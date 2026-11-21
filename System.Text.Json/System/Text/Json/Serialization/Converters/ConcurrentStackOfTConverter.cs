using System;
using System.Collections.Concurrent;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000104 RID: 260
	internal sealed class ConcurrentStackOfTConverter<TCollection, TElement> : IEnumerableDefaultConverter<TCollection, TElement> where TCollection : ConcurrentStack<TElement>
	{
		// Token: 0x170002FA RID: 762
		// (get) Token: 0x06000D1B RID: 3355 RVA: 0x00003363 File Offset: 0x00001563
		internal override bool CanPopulate
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x00032F94 File Offset: 0x00031194
		protected override void Add(in TElement value, ref ReadStack state)
		{
			((TCollection)((object)state.Current.ReturnValue)).Push(value);
		}
	}
}
