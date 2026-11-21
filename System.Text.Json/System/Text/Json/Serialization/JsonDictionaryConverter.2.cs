using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization
{
	// Token: 0x020000A1 RID: 161
	internal abstract class JsonDictionaryConverter<TDictionary, TKey, TValue> : JsonDictionaryConverter<TDictionary>
	{
		// Token: 0x06000944 RID: 2372
		protected abstract void Add(TKey key, in TValue value, JsonSerializerOptions options, ref ReadStack state);

		// Token: 0x06000945 RID: 2373 RVA: 0x000148D8 File Offset: 0x00012AD8
		protected virtual void ConvertCollection(ref ReadStack state, JsonSerializerOptions options)
		{
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x00028D68 File Offset: 0x00026F68
		protected virtual void CreateCollection(ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state)
		{
			JsonPropertyInfo parentProperty = state.ParentProperty;
			if (parentProperty != null && parentProperty.TryGetPrePopulatedValue(ref state))
			{
				return;
			}
			JsonTypeInfo jsonTypeInfo = state.Current.JsonTypeInfo;
			if (jsonTypeInfo.CreateObject == null)
			{
				ThrowHelper.ThrowNotSupportedException_DeserializeNoConstructor(jsonTypeInfo, ref reader, ref state);
			}
			state.Current.ReturnValue = jsonTypeInfo.CreateObject();
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x00028DBD File Offset: 0x00026FBD
		internal override Type ElementType
		{
			get
			{
				return typeof(TValue);
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x0002876A File Offset: 0x0002696A
		internal override Type KeyType
		{
			get
			{
				return typeof(TKey);
			}
		}

		// Token: 0x06000949 RID: 2377 RVA: 0x00028DC9 File Offset: 0x00026FC9
		protected static JsonConverter<T> GetConverter<T>(JsonTypeInfo typeInfo)
		{
			return ((JsonTypeInfo<T>)typeInfo).EffectiveConverter;
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x00028DD8 File Offset: 0x00026FD8
		internal sealed override bool OnTryRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, [ScopedRef] ref ReadStack state, [MaybeNullWhen(false)] out TDictionary value)
		{
			JsonTypeInfo jsonTypeInfo = state.Current.JsonTypeInfo;
			JsonTypeInfo keyTypeInfo = jsonTypeInfo.KeyTypeInfo;
			JsonTypeInfo elementTypeInfo = jsonTypeInfo.ElementTypeInfo;
			if (state.SupportContinuation || state.Current.CanContainMetadata)
			{
				if (state.Current.ObjectState == StackFrameObjectState.None)
				{
					if (reader.TokenType != JsonTokenType.StartObject)
					{
						ThrowHelper.ThrowJsonException_DeserializeUnableToConvertValue(this.Type);
					}
					state.Current.ObjectState = StackFrameObjectState.StartToken;
				}
				if (state.Current.CanContainMetadata && state.Current.ObjectState < StackFrameObjectState.ReadMetadata)
				{
					if (!JsonSerializer.TryReadMetadata(this, jsonTypeInfo, ref reader, ref state))
					{
						value = default(TDictionary);
						return false;
					}
					if (state.Current.MetadataPropertyNames == MetadataPropertyName.Ref)
					{
						value = JsonSerializer.ResolveReferenceId<TDictionary>(ref state);
						return true;
					}
					state.Current.ObjectState = StackFrameObjectState.ReadMetadata;
				}
				if ((state.Current.MetadataPropertyNames & MetadataPropertyName.Type) != MetadataPropertyName.None && state.Current.PolymorphicSerializationState != PolymorphicSerializationState.PolymorphicReEntryStarted)
				{
					JsonConverter jsonConverter = base.ResolvePolymorphicConverter(jsonTypeInfo, ref state);
					if (jsonConverter != null)
					{
						object obj;
						bool flag = jsonConverter.OnTryReadAsObject(ref reader, jsonConverter.Type, options, ref state, out obj);
						value = (TDictionary)((object)obj);
						state.ExitPolymorphicConverter(flag);
						return flag;
					}
				}
				if (state.Current.ObjectState < StackFrameObjectState.CreatedObject)
				{
					if (state.Current.CanContainMetadata)
					{
						JsonSerializer.ValidateMetadataForObjectConverter(ref state);
					}
					this.CreateCollection(ref reader, ref state);
					if ((state.Current.MetadataPropertyNames & MetadataPropertyName.Id) != MetadataPropertyName.None)
					{
						state.ReferenceResolver.AddReference(state.ReferenceId, state.Current.ReturnValue);
						state.ReferenceId = null;
					}
					Action<object> onDeserializing = jsonTypeInfo.OnDeserializing;
					if (onDeserializing != null)
					{
						onDeserializing(state.Current.ReturnValue);
					}
					state.Current.ObjectState = StackFrameObjectState.CreatedObject;
				}
				if (this._keyConverter == null)
				{
					this._keyConverter = JsonDictionaryConverter<TDictionary, TKey, TValue>.GetConverter<TKey>(keyTypeInfo);
				}
				if (this._valueConverter == null)
				{
					this._valueConverter = JsonDictionaryConverter<TDictionary, TKey, TValue>.GetConverter<TValue>(elementTypeInfo);
				}
				TKey tkey;
				for (;;)
				{
					if (state.Current.PropertyState == StackFramePropertyState.None)
					{
						if (!reader.Read())
						{
							break;
						}
						state.Current.PropertyState = StackFramePropertyState.ReadName;
					}
					if (state.Current.PropertyState < StackFramePropertyState.Name)
					{
						if (reader.TokenType == JsonTokenType.EndObject)
						{
							goto IL_4F9;
						}
						state.Current.PropertyState = StackFramePropertyState.Name;
						if (state.Current.CanContainMetadata)
						{
							ReadOnlySpan<byte> unescapedSpan = ref reader.GetUnescapedSpan();
							if (JsonSerializer.IsMetadataPropertyName(unescapedSpan, state.Current.BaseJsonTypeInfo.PolymorphicTypeResolver))
							{
								if (options.AllowOutOfOrderMetadataProperties)
								{
									ref reader.SkipWithVerify();
									state.Current.EndElement();
									continue;
								}
								ThrowHelper.ThrowUnexpectedMetadataException(unescapedSpan, ref reader, ref state);
							}
						}
						state.Current.JsonPropertyInfo = keyTypeInfo.PropertyInfoForTypeInfo;
						tkey = JsonDictionaryConverter<TDictionary, TKey, TValue>.<OnTryRead>g__ReadDictionaryKey|10_0(this._keyConverter, ref reader, ref state, options);
					}
					else
					{
						tkey = (TKey)((object)state.Current.DictionaryKey);
					}
					if (state.Current.PropertyState < StackFramePropertyState.ReadValue)
					{
						if (!ref reader.TryAdvanceWithOptionalReadAhead(this._valueConverter.RequiresReadAhead))
						{
							goto Block_33;
						}
						state.Current.PropertyState = StackFramePropertyState.ReadValue;
					}
					if (state.Current.PropertyState < StackFramePropertyState.TryRead)
					{
						state.Current.JsonPropertyInfo = elementTypeInfo.PropertyInfoForTypeInfo;
						TValue tvalue;
						bool flag2;
						if (!this._valueConverter.TryRead(ref reader, typeof(TValue), options, ref state, out tvalue, out flag2))
						{
							goto Block_35;
						}
						this.Add(tkey, tvalue, options, ref state);
						state.Current.EndElement();
					}
				}
				value = default(TDictionary);
				return false;
				Block_33:
				state.Current.DictionaryKey = tkey;
				value = default(TDictionary);
				return false;
				Block_35:
				state.Current.DictionaryKey = tkey;
				value = default(TDictionary);
				return false;
			}
			if (reader.TokenType != JsonTokenType.StartObject)
			{
				ThrowHelper.ThrowJsonException_DeserializeUnableToConvertValue(this.Type);
			}
			this.CreateCollection(ref reader, ref state);
			Action<object> onDeserializing2 = jsonTypeInfo.OnDeserializing;
			if (onDeserializing2 != null)
			{
				onDeserializing2(state.Current.ReturnValue);
			}
			if (this._keyConverter == null)
			{
				this._keyConverter = JsonDictionaryConverter<TDictionary, TKey, TValue>.GetConverter<TKey>(keyTypeInfo);
			}
			if (this._valueConverter == null)
			{
				this._valueConverter = JsonDictionaryConverter<TDictionary, TKey, TValue>.GetConverter<TValue>(elementTypeInfo);
			}
			if (this._valueConverter.CanUseDirectReadOrWrite && state.Current.NumberHandling == null)
			{
				for (;;)
				{
					ref reader.ReadWithVerify();
					if (reader.TokenType == JsonTokenType.EndObject)
					{
						break;
					}
					state.Current.JsonPropertyInfo = keyTypeInfo.PropertyInfoForTypeInfo;
					TKey key = JsonDictionaryConverter<TDictionary, TKey, TValue>.<OnTryRead>g__ReadDictionaryKey|10_0(this._keyConverter, ref reader, ref state, options);
					ref reader.ReadWithVerify();
					state.Current.JsonPropertyInfo = elementTypeInfo.PropertyInfoForTypeInfo;
					TValue tvalue2 = this._valueConverter.Read(ref reader, this.ElementType, options);
					this.Add(key, tvalue2, options, ref state);
				}
			}
			else
			{
				for (;;)
				{
					ref reader.ReadWithVerify();
					if (reader.TokenType == JsonTokenType.EndObject)
					{
						break;
					}
					state.Current.JsonPropertyInfo = keyTypeInfo.PropertyInfoForTypeInfo;
					TKey key2 = JsonDictionaryConverter<TDictionary, TKey, TValue>.<OnTryRead>g__ReadDictionaryKey|10_0(this._keyConverter, ref reader, ref state, options);
					ref reader.ReadWithVerify();
					state.Current.JsonPropertyInfo = elementTypeInfo.PropertyInfoForTypeInfo;
					bool flag2;
					TValue tvalue3;
					this._valueConverter.TryRead(ref reader, this.ElementType, options, ref state, out tvalue3, out flag2);
					this.Add(key2, tvalue3, options, ref state);
				}
			}
			IL_4F9:
			this.ConvertCollection(ref state, options);
			object returnValue = state.Current.ReturnValue;
			Action<object> onDeserialized = jsonTypeInfo.OnDeserialized;
			if (onDeserialized != null)
			{
				onDeserialized(returnValue);
			}
			value = (TDictionary)((object)returnValue);
			return true;
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x00029314 File Offset: 0x00027514
		internal sealed override bool OnTryWrite(Utf8JsonWriter writer, TDictionary dictionary, JsonSerializerOptions options, ref WriteStack state)
		{
			if (dictionary == null)
			{
				writer.WriteNullValue();
				return true;
			}
			JsonTypeInfo jsonTypeInfo = state.Current.JsonTypeInfo;
			if (!state.Current.ProcessedStartToken)
			{
				state.Current.ProcessedStartToken = true;
				Action<object> onSerializing = jsonTypeInfo.OnSerializing;
				if (onSerializing != null)
				{
					onSerializing(dictionary);
				}
				writer.WriteStartObject();
				if (state.CurrentContainsMetadata && this.CanHaveMetadata)
				{
					JsonSerializer.WriteMetadataForObject(this, ref state, writer);
				}
				state.Current.JsonPropertyInfo = jsonTypeInfo.ElementTypeInfo.PropertyInfoForTypeInfo;
			}
			bool flag = this.OnWriteResume(writer, dictionary, options, ref state);
			if (flag)
			{
				if (!state.Current.ProcessedEndToken)
				{
					state.Current.ProcessedEndToken = true;
					writer.WriteEndObject();
				}
				Action<object> onSerialized = jsonTypeInfo.OnSerialized;
				if (onSerialized == null)
				{
					return flag;
				}
				onSerialized(dictionary);
			}
			return flag;
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x000293F8 File Offset: 0x000275F8
		[CompilerGenerated]
		internal static TKey <OnTryRead>g__ReadDictionaryKey|10_0(JsonConverter<TKey> keyConverter, ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state, JsonSerializerOptions options)
		{
			string @string = reader.GetString();
			state.Current.JsonPropertyNameAsString = @string;
			TKey result;
			if (keyConverter.IsInternalConverter && keyConverter.Type == typeof(string))
			{
				result = (TKey)((object)@string);
			}
			else
			{
				result = keyConverter.ReadAsPropertyNameCore(ref reader, keyConverter.Type, options);
			}
			return result;
		}

		// Token: 0x0400029F RID: 671
		protected JsonConverter<TKey> _keyConverter;

		// Token: 0x040002A0 RID: 672
		protected JsonConverter<TValue> _valueConverter;
	}
}
