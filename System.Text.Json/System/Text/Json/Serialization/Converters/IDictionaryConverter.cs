using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x0200010C RID: 268
	internal sealed class IDictionaryConverter<TDictionary> : JsonDictionaryConverter<TDictionary, string, object> where TDictionary : IDictionary
	{
		// Token: 0x17000300 RID: 768
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x00003363 File Offset: 0x00001563
		internal override bool CanPopulate
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x00033838 File Offset: 0x00031A38
		protected override void Add(string key, in object value, JsonSerializerOptions options, ref ReadStack state)
		{
			TDictionary tdictionary = (TDictionary)((object)state.Current.ReturnValue);
			tdictionary[key] = value;
			if (base.IsValueType)
			{
				state.Current.ReturnValue = tdictionary;
			}
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x00033884 File Offset: 0x00031A84
		protected override void CreateCollection(ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state)
		{
			base.CreateCollection(ref reader, ref state);
			TDictionary tdictionary = (TDictionary)((object)state.Current.ReturnValue);
			if (tdictionary.IsReadOnly)
			{
				state.Current.ReturnValue = null;
				ThrowHelper.ThrowNotSupportedException_CannotPopulateCollection(this.Type, ref reader, ref state);
			}
		}

		// Token: 0x06000D45 RID: 3397 RVA: 0x000338D4 File Offset: 0x00031AD4
		protected internal override bool OnWriteResume(Utf8JsonWriter writer, TDictionary value, JsonSerializerOptions options, ref WriteStack state)
		{
			IDictionaryEnumerator dictionaryEnumerator;
			if (state.Current.CollectionEnumerator == null)
			{
				dictionaryEnumerator = value.GetEnumerator();
				state.Current.CollectionEnumerator = dictionaryEnumerator;
				if (!dictionaryEnumerator.MoveNext())
				{
					return true;
				}
			}
			else
			{
				dictionaryEnumerator = (IDictionaryEnumerator)state.Current.CollectionEnumerator;
			}
			JsonTypeInfo jsonTypeInfo = state.Current.JsonTypeInfo;
			if (this._valueConverter == null)
			{
				this._valueConverter = JsonDictionaryConverter<TDictionary, string, object>.GetConverter<object>(jsonTypeInfo.ElementTypeInfo);
			}
			while (!JsonConverter.ShouldFlush(ref state, writer))
			{
				if (state.Current.PropertyState < StackFramePropertyState.Name)
				{
					state.Current.PropertyState = StackFramePropertyState.Name;
					object key = dictionaryEnumerator.Key;
					string text = key as string;
					if (text != null)
					{
						if (this._keyConverter == null)
						{
							this._keyConverter = JsonDictionaryConverter<TDictionary, string, object>.GetConverter<string>(jsonTypeInfo.KeyTypeInfo);
						}
						this._keyConverter.WriteAsPropertyNameCore(writer, text, options, state.Current.IsWritingExtensionDataProperty);
					}
					else
					{
						this._valueConverter.WriteAsPropertyNameCore(writer, key, options, state.Current.IsWritingExtensionDataProperty);
					}
				}
				object value2 = dictionaryEnumerator.Value;
				if (!this._valueConverter.TryWrite(writer, value2, options, ref state))
				{
					return false;
				}
				state.Current.EndDictionaryEntry();
				if (!dictionaryEnumerator.MoveNext())
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x06000D46 RID: 3398 RVA: 0x00033A0C File Offset: 0x00031C0C
		internal override void ConfigureJsonTypeInfo(JsonTypeInfo jsonTypeInfo, JsonSerializerOptions options)
		{
			if (jsonTypeInfo.CreateObject == null && this.Type.IsAssignableFrom(typeof(Dictionary<string, object>)))
			{
				jsonTypeInfo.CreateObject = (() => new Dictionary<string, object>());
			}
		}
	}
}
