using System;
using System.Collections.Generic;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000105 RID: 261
	internal abstract class DictionaryDefaultConverter<TDictionary, TKey, TValue> : JsonDictionaryConverter<TDictionary, TKey, TValue> where TDictionary : IEnumerable<KeyValuePair<TKey, TValue>>
	{
		// Token: 0x170002FB RID: 763
		// (get) Token: 0x06000D1E RID: 3358 RVA: 0x00003363 File Offset: 0x00001563
		internal override bool CanHaveMetadata
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000D1F RID: 3359 RVA: 0x00032FB8 File Offset: 0x000311B8
		protected internal override bool OnWriteResume(Utf8JsonWriter writer, TDictionary value, JsonSerializerOptions options, ref WriteStack state)
		{
			IEnumerator<KeyValuePair<TKey, TValue>> enumerator;
			if (state.Current.CollectionEnumerator == null)
			{
				enumerator = value.GetEnumerator();
				state.Current.CollectionEnumerator = enumerator;
				if (!enumerator.MoveNext())
				{
					enumerator.Dispose();
					return true;
				}
			}
			else
			{
				enumerator = (IEnumerator<KeyValuePair<TKey, TValue>>)state.Current.CollectionEnumerator;
			}
			JsonTypeInfo jsonTypeInfo = state.Current.JsonTypeInfo;
			if (this._keyConverter == null)
			{
				this._keyConverter = JsonDictionaryConverter<TDictionary, TKey, TValue>.GetConverter<TKey>(jsonTypeInfo.KeyTypeInfo);
			}
			if (this._valueConverter == null)
			{
				this._valueConverter = JsonDictionaryConverter<TDictionary, TKey, TValue>.GetConverter<TValue>(jsonTypeInfo.ElementTypeInfo);
			}
			while (!JsonConverter.ShouldFlush(ref state, writer))
			{
				KeyValuePair<TKey, TValue> keyValuePair;
				if (state.Current.PropertyState < StackFramePropertyState.Name)
				{
					state.Current.PropertyState = StackFramePropertyState.Name;
					keyValuePair = enumerator.Current;
					TKey key = keyValuePair.Key;
					this._keyConverter.WriteAsPropertyNameCore(writer, key, options, state.Current.IsWritingExtensionDataProperty);
				}
				keyValuePair = enumerator.Current;
				TValue value2 = keyValuePair.Value;
				if (!this._valueConverter.TryWrite(writer, value2, options, ref state))
				{
					return false;
				}
				state.Current.EndDictionaryEntry();
				if (!enumerator.MoveNext())
				{
					enumerator.Dispose();
					return true;
				}
			}
			return false;
		}
	}
}
