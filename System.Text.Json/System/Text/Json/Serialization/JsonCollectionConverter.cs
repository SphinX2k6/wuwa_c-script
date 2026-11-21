using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization
{
	// Token: 0x0200009F RID: 159
	internal abstract class JsonCollectionConverter<TCollection, TElement> : JsonResumableConverter<TCollection>
	{
		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000934 RID: 2356 RVA: 0x00003363 File Offset: 0x00001563
		internal override bool SupportsCreateObjectDelegate
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00028767 File Offset: 0x00026967
		private protected sealed override ConverterStrategy GetDefaultConverterStrategy()
		{
			return ConverterStrategy.Enumerable;
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x06000936 RID: 2358 RVA: 0x0002876A File Offset: 0x0002696A
		internal override Type ElementType
		{
			get
			{
				return typeof(TElement);
			}
		}

		// Token: 0x06000937 RID: 2359
		protected abstract void Add(in TElement value, ref ReadStack state);

		// Token: 0x06000938 RID: 2360 RVA: 0x00028778 File Offset: 0x00026978
		protected virtual void CreateCollection(ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state, JsonSerializerOptions options)
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

		// Token: 0x06000939 RID: 2361 RVA: 0x000148D8 File Offset: 0x00012AD8
		protected virtual void ConvertCollection(ref ReadStack state, JsonSerializerOptions options)
		{
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x000287CD File Offset: 0x000269CD
		protected static JsonConverter<TElement> GetElementConverter(JsonTypeInfo elementTypeInfo)
		{
			return ((JsonTypeInfo<TElement>)elementTypeInfo).EffectiveConverter;
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x000287DA File Offset: 0x000269DA
		protected static JsonConverter<TElement> GetElementConverter(ref WriteStack state)
		{
			return (JsonConverter<TElement>)state.Current.JsonPropertyInfo.EffectiveConverter;
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x000287F4 File Offset: 0x000269F4
		internal override bool OnTryRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, [ScopedRef] ref ReadStack state, [MaybeNullWhen(false)] out TCollection value)
		{
			JsonTypeInfo jsonTypeInfo = state.Current.JsonTypeInfo;
			JsonTypeInfo elementTypeInfo = jsonTypeInfo.ElementTypeInfo;
			if (!state.SupportContinuation && !state.Current.CanContainMetadata)
			{
				if (reader.TokenType != JsonTokenType.StartArray)
				{
					ThrowHelper.ThrowJsonException_DeserializeUnableToConvertValue(this.Type);
				}
				this.CreateCollection(ref reader, ref state, options);
				Action<object> onDeserializing = jsonTypeInfo.OnDeserializing;
				if (onDeserializing != null)
				{
					onDeserializing(state.Current.ReturnValue);
				}
				state.Current.JsonPropertyInfo = elementTypeInfo.PropertyInfoForTypeInfo;
				JsonConverter<TElement> elementConverter = JsonCollectionConverter<TCollection, TElement>.GetElementConverter(elementTypeInfo);
				if (elementConverter.CanUseDirectReadOrWrite && state.Current.NumberHandling == null)
				{
					for (;;)
					{
						ref reader.ReadWithVerify();
						if (reader.TokenType == JsonTokenType.EndArray)
						{
							break;
						}
						TElement telement = elementConverter.Read(ref reader, elementConverter.Type, options);
						this.Add(telement, ref state);
					}
				}
				else
				{
					for (;;)
					{
						ref reader.ReadWithVerify();
						if (reader.TokenType == JsonTokenType.EndArray)
						{
							break;
						}
						TElement telement2;
						bool flag;
						elementConverter.TryRead(ref reader, typeof(TElement), options, ref state, out telement2, out flag);
						this.Add(telement2, ref state);
					}
				}
			}
			else
			{
				if (state.Current.ObjectState == StackFrameObjectState.None)
				{
					if (reader.TokenType == JsonTokenType.StartArray)
					{
						state.Current.ObjectState = StackFrameObjectState.ReadMetadata;
					}
					else if (state.Current.CanContainMetadata)
					{
						if (reader.TokenType != JsonTokenType.StartObject)
						{
							ThrowHelper.ThrowJsonException_DeserializeUnableToConvertValue(this.Type);
						}
						state.Current.ObjectState = StackFrameObjectState.StartToken;
					}
					else
					{
						ThrowHelper.ThrowJsonException_DeserializeUnableToConvertValue(this.Type);
					}
				}
				if (state.Current.CanContainMetadata && state.Current.ObjectState < StackFrameObjectState.ReadMetadata)
				{
					if (!JsonSerializer.TryReadMetadata(this, jsonTypeInfo, ref reader, ref state))
					{
						value = default(TCollection);
						return false;
					}
					if (state.Current.MetadataPropertyNames == MetadataPropertyName.Ref)
					{
						value = JsonSerializer.ResolveReferenceId<TCollection>(ref state);
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
						bool flag2 = jsonConverter.OnTryReadAsObject(ref reader, jsonConverter.Type, options, ref state, out obj);
						value = (TCollection)((object)obj);
						state.ExitPolymorphicConverter(flag2);
						return flag2;
					}
				}
				if (state.Current.ObjectState < StackFrameObjectState.CreatedObject)
				{
					if (state.Current.CanContainMetadata)
					{
						JsonSerializer.ValidateMetadataForArrayConverter(this, ref reader, ref state);
					}
					this.CreateCollection(ref reader, ref state, options);
					if ((state.Current.MetadataPropertyNames & MetadataPropertyName.Id) != MetadataPropertyName.None)
					{
						state.ReferenceResolver.AddReference(state.ReferenceId, state.Current.ReturnValue);
						state.ReferenceId = null;
					}
					Action<object> onDeserializing2 = jsonTypeInfo.OnDeserializing;
					if (onDeserializing2 != null)
					{
						onDeserializing2(state.Current.ReturnValue);
					}
					state.Current.ObjectState = StackFrameObjectState.CreatedObject;
				}
				if (state.Current.ObjectState < StackFrameObjectState.ReadElements)
				{
					JsonConverter<TElement> elementConverter2 = JsonCollectionConverter<TCollection, TElement>.GetElementConverter(elementTypeInfo);
					state.Current.JsonPropertyInfo = elementTypeInfo.PropertyInfoForTypeInfo;
					for (;;)
					{
						if (state.Current.PropertyState < StackFramePropertyState.ReadValue)
						{
							if (!ref reader.TryAdvanceWithOptionalReadAhead(elementConverter2.RequiresReadAhead))
							{
								break;
							}
							state.Current.PropertyState = StackFramePropertyState.ReadValue;
						}
						if (state.Current.PropertyState < StackFramePropertyState.ReadValueIsEnd)
						{
							if (reader.TokenType == JsonTokenType.EndArray)
							{
								goto IL_38D;
							}
							state.Current.PropertyState = StackFramePropertyState.ReadValueIsEnd;
						}
						if (state.Current.PropertyState < StackFramePropertyState.TryRead)
						{
							bool flag;
							TElement telement3;
							if (!elementConverter2.TryRead(ref reader, typeof(TElement), options, ref state, out telement3, out flag))
							{
								goto Block_29;
							}
							this.Add(telement3, ref state);
							state.Current.EndElement();
						}
					}
					value = default(TCollection);
					return false;
					Block_29:
					value = default(TCollection);
					return false;
					IL_38D:
					state.Current.ObjectState = StackFrameObjectState.ReadElements;
				}
				if (state.Current.ObjectState < StackFrameObjectState.EndToken)
				{
					if ((state.Current.MetadataPropertyNames & MetadataPropertyName.Values) != MetadataPropertyName.None && !reader.Read())
					{
						value = default(TCollection);
						return false;
					}
					state.Current.ObjectState = StackFrameObjectState.EndToken;
				}
				if (state.Current.ObjectState < StackFrameObjectState.EndTokenValidation && (state.Current.MetadataPropertyNames & MetadataPropertyName.Values) != MetadataPropertyName.None && reader.TokenType != JsonTokenType.EndObject)
				{
					if (options.AllowOutOfOrderMetadataProperties)
					{
						reader.TrySkipPartial(reader.CurrentDepth - 1);
					}
					else
					{
						ThrowHelper.ThrowJsonException_MetadataInvalidPropertyInArrayMetadata(ref state, typeToConvert, reader);
					}
				}
			}
			this.ConvertCollection(ref state, options);
			object returnValue = state.Current.ReturnValue;
			Action<object> onDeserialized = jsonTypeInfo.OnDeserialized;
			if (onDeserialized != null)
			{
				onDeserialized(returnValue);
			}
			value = (TCollection)((object)returnValue);
			return true;
		}

		// Token: 0x0600093D RID: 2365 RVA: 0x00028C5C File Offset: 0x00026E5C
		internal override bool OnTryWrite(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state)
		{
			bool flag;
			if (value == null)
			{
				writer.WriteNullValue();
				flag = true;
			}
			else
			{
				JsonTypeInfo jsonTypeInfo = state.Current.JsonTypeInfo;
				if (!state.Current.ProcessedStartToken)
				{
					state.Current.ProcessedStartToken = true;
					Action<object> onSerializing = jsonTypeInfo.OnSerializing;
					if (onSerializing != null)
					{
						onSerializing(value);
					}
					if (state.CurrentContainsMetadata && this.CanHaveMetadata)
					{
						state.Current.MetadataPropertyName = JsonSerializer.WriteMetadataForCollection(this, ref state, writer);
					}
					writer.WriteStartArray();
					state.Current.JsonPropertyInfo = jsonTypeInfo.ElementTypeInfo.PropertyInfoForTypeInfo;
				}
				flag = this.OnWriteResume(writer, value, options, ref state);
				if (flag)
				{
					if (!state.Current.ProcessedEndToken)
					{
						state.Current.ProcessedEndToken = true;
						writer.WriteEndArray();
						if (state.Current.MetadataPropertyName != MetadataPropertyName.None)
						{
							writer.WriteEndObject();
						}
					}
					Action<object> onSerialized = jsonTypeInfo.OnSerialized;
					if (onSerialized != null)
					{
						onSerialized(value);
					}
				}
			}
			return flag;
		}

		// Token: 0x0600093E RID: 2366
		protected abstract bool OnWriteResume(Utf8JsonWriter writer, TCollection value, JsonSerializerOptions options, ref WriteStack state);
	}
}
