using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x0200011B RID: 283
	internal sealed class IReadOnlyDictionaryOfTKeyTValueConverter<TDictionary, TKey, TValue> : DictionaryDefaultConverter<TDictionary, TKey, TValue> where TDictionary : IReadOnlyDictionary<TKey, TValue>
	{
		// Token: 0x06000D87 RID: 3463 RVA: 0x00034585 File Offset: 0x00032785
		protected override void Add(TKey key, in TValue value, JsonSerializerOptions options, ref ReadStack state)
		{
			((Dictionary<TKey, TValue>)state.Current.ReturnValue)[key] = value;
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x06000D88 RID: 3464 RVA: 0x000249D0 File Offset: 0x00022BD0
		internal override bool SupportsCreateObjectDelegate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000D89 RID: 3465 RVA: 0x0003464D File Offset: 0x0003284D
		protected override void CreateCollection(ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state)
		{
			if (!this._isDeserializable)
			{
				ThrowHelper.ThrowNotSupportedException_CannotPopulateCollection(this.Type, ref reader, ref state);
			}
			state.Current.ReturnValue = new Dictionary<TKey, TValue>();
		}

		// Token: 0x0400043D RID: 1085
		private readonly bool _isDeserializable = typeof(TDictionary).IsAssignableFrom(typeof(Dictionary<TKey, TValue>));
	}
}
