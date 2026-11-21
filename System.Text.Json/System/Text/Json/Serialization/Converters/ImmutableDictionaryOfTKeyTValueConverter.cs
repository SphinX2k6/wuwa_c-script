using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000119 RID: 281
	internal class ImmutableDictionaryOfTKeyTValueConverter<TDictionary, TKey, TValue> : DictionaryDefaultConverter<TDictionary, TKey, TValue> where TDictionary : IReadOnlyDictionary<TKey, TValue>
	{
		// Token: 0x06000D79 RID: 3449 RVA: 0x00034585 File Offset: 0x00032785
		protected sealed override void Add(TKey key, in TValue value, JsonSerializerOptions options, ref ReadStack state)
		{
			((Dictionary<TKey, TValue>)state.Current.ReturnValue)[key] = value;
		}

		// Token: 0x17000308 RID: 776
		// (get) Token: 0x06000D7A RID: 3450 RVA: 0x000249D0 File Offset: 0x00022BD0
		internal sealed override bool CanHaveMetadata
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000309 RID: 777
		// (get) Token: 0x06000D7B RID: 3451 RVA: 0x000249D0 File Offset: 0x00022BD0
		internal override bool SupportsCreateObjectDelegate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x000345A4 File Offset: 0x000327A4
		protected sealed override void CreateCollection(ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state)
		{
			state.Current.ReturnValue = new Dictionary<TKey, TValue>();
		}

		// Token: 0x1700030A RID: 778
		// (get) Token: 0x06000D7D RID: 3453 RVA: 0x00003363 File Offset: 0x00001563
		internal sealed override bool IsConvertibleCollection
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x000345B8 File Offset: 0x000327B8
		protected sealed override void ConvertCollection(ref ReadStack state, JsonSerializerOptions options)
		{
			Func<IEnumerable<KeyValuePair<TKey, TValue>>, TDictionary> func = (Func<IEnumerable<KeyValuePair<TKey, TValue>>, TDictionary>)state.Current.JsonTypeInfo.CreateObjectWithArgs;
			state.Current.ReturnValue = func((Dictionary<TKey, TValue>)state.Current.ReturnValue);
		}
	}
}
