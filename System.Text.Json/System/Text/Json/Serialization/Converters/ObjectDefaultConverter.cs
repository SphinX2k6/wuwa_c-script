using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000131 RID: 305
	internal class ObjectDefaultConverter<T> : JsonObjectConverter<T>
	{
		// Token: 0x17000324 RID: 804
		// (get) Token: 0x06000DF4 RID: 3572 RVA: 0x00003363 File Offset: 0x00001563
		internal override bool CanHaveMetadata
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000325 RID: 805
		// (get) Token: 0x06000DF5 RID: 3573 RVA: 0x00003363 File Offset: 0x00001563
		internal override bool SupportsCreateObjectDelegate
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000DF6 RID: 3574 RVA: 0x000355D4 File Offset: 0x000337D4
		internal override bool OnTryRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, [ScopedRef] ref ReadStack state, [MaybeNullWhen(false)] out T value)
		{
			JsonTypeInfo jsonTypeInfo = state.Current.JsonTypeInfo;
			object obj;
			if (!state.SupportContinuation && !state.Current.CanContainMetadata)
			{
				if (reader.TokenType != JsonTokenType.StartObject)
				{
					ThrowHelper.ThrowJsonException_DeserializeUnableToConvertValue(this.Type);
				}
				JsonPropertyInfo parentProperty = state.ParentProperty;
				if (parentProperty != null && parentProperty.TryGetPrePopulatedValue(ref state))
				{
					obj = state.Current.ReturnValue;
				}
				else
				{
					if (jsonTypeInfo.CreateObject == null)
					{
						ThrowHelper.ThrowNotSupportedException_DeserializeNoConstructor(jsonTypeInfo, ref reader, ref state);
					}
					obj = jsonTypeInfo.CreateObject();
				}
				ObjectDefaultConverter<T>.PopulatePropertiesFastPath(obj, jsonTypeInfo, options, ref reader, ref state);
				value = (T)((object)obj);
				return true;
			}
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
					value = default(T);
					return false;
				}
				if (state.Current.MetadataPropertyNames == MetadataPropertyName.Ref)
				{
					value = JsonSerializer.ResolveReferenceId<T>(ref state);
					return true;
				}
				state.Current.ObjectState = StackFrameObjectState.ReadMetadata;
			}
			if ((state.Current.MetadataPropertyNames & MetadataPropertyName.Type) != MetadataPropertyName.None && state.Current.PolymorphicSerializationState != PolymorphicSerializationState.PolymorphicReEntryStarted)
			{
				JsonConverter jsonConverter = base.ResolvePolymorphicConverter(jsonTypeInfo, ref state);
				if (jsonConverter != null)
				{
					object obj2;
					bool flag = jsonConverter.OnTryReadAsObject(ref reader, jsonConverter.Type, options, ref state, out obj2);
					value = (T)((object)obj2);
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
				if (state.Current.MetadataPropertyNames == MetadataPropertyName.Ref)
				{
					value = JsonSerializer.ResolveReferenceId<T>(ref state);
					return true;
				}
				JsonPropertyInfo parentProperty2 = state.ParentProperty;
				if (parentProperty2 != null && parentProperty2.TryGetPrePopulatedValue(ref state))
				{
					obj = state.Current.ReturnValue;
				}
				else
				{
					if (jsonTypeInfo.CreateObject == null)
					{
						ThrowHelper.ThrowNotSupportedException_DeserializeNoConstructor(jsonTypeInfo, ref reader, ref state);
					}
					obj = jsonTypeInfo.CreateObject();
				}
				if ((state.Current.MetadataPropertyNames & MetadataPropertyName.Id) != MetadataPropertyName.None)
				{
					state.ReferenceResolver.AddReference(state.ReferenceId, obj);
					state.ReferenceId = null;
				}
				Action<object> onDeserializing = jsonTypeInfo.OnDeserializing;
				if (onDeserializing != null)
				{
					onDeserializing(obj);
				}
				state.Current.ReturnValue = obj;
				state.Current.ObjectState = StackFrameObjectState.CreatedObject;
				state.Current.InitializeRequiredPropertiesValidationState(jsonTypeInfo);
			}
			else
			{
				obj = state.Current.ReturnValue;
			}
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
				JsonPropertyInfo jsonPropertyInfo;
				if (state.Current.PropertyState < StackFramePropertyState.Name)
				{
					if (reader.TokenType == JsonTokenType.EndObject)
					{
						goto IL_431;
					}
					jsonTypeInfo.ValidateCanBeUsedForPropertyMetadataSerialization();
					bool flag2;
					ReadOnlySpan<byte> propertyName = JsonSerializer.GetPropertyName(ref state, ref reader, options, out flag2);
					if (flag2)
					{
						ref reader.SkipWithVerify();
						state.Current.EndProperty();
						continue;
					}
					bool useExtensionProperty;
					jsonPropertyInfo = JsonSerializer.LookupProperty(obj, propertyName, ref state, options, out useExtensionProperty, true);
					state.Current.UseExtensionProperty = useExtensionProperty;
					state.Current.PropertyState = StackFramePropertyState.Name;
				}
				else
				{
					jsonPropertyInfo = state.Current.JsonPropertyInfo;
				}
				if (state.Current.PropertyState < StackFramePropertyState.ReadValue)
				{
					if (!jsonPropertyInfo.CanDeserializeOrPopulate)
					{
						if (!reader.TrySkipPartial(state.Current.OriginalDepth + 1))
						{
							goto Block_31;
						}
						state.Current.EndProperty();
						continue;
					}
					else
					{
						if (!ObjectDefaultConverter<T>.ReadAheadPropertyValue(ref state, ref reader, jsonPropertyInfo))
						{
							goto Block_32;
						}
						state.Current.PropertyState = StackFramePropertyState.ReadValue;
					}
				}
				if (state.Current.PropertyState < StackFramePropertyState.TryRead)
				{
					if (!state.Current.UseExtensionProperty)
					{
						if (!jsonPropertyInfo.ReadJsonAndSetMember(obj, ref state, ref reader))
						{
							goto Block_35;
						}
					}
					else if (!jsonPropertyInfo.ReadJsonAndAddExtensionProperty(obj, ref state, ref reader))
					{
						goto Block_36;
					}
					state.Current.EndProperty();
				}
			}
			state.Current.ReturnValue = obj;
			value = default(T);
			return false;
			Block_31:
			state.Current.ReturnValue = obj;
			value = default(T);
			return false;
			Block_32:
			state.Current.ReturnValue = obj;
			value = default(T);
			return false;
			Block_35:
			state.Current.ReturnValue = obj;
			value = default(T);
			return false;
			Block_36:
			state.Current.ReturnValue = obj;
			value = default(T);
			return false;
			IL_431:
			Action<object> onDeserialized = jsonTypeInfo.OnDeserialized;
			if (onDeserialized != null)
			{
				onDeserialized(obj);
			}
			state.Current.ValidateAllRequiredPropertiesAreRead(jsonTypeInfo);
			value = (T)((object)obj);
			if (state.Current.PropertyRefCacheBuilder != null)
			{
				jsonTypeInfo.UpdateUtf8PropertyCache(ref state.Current);
			}
			return true;
		}

		// Token: 0x06000DF7 RID: 3575 RVA: 0x00035A5C File Offset: 0x00033C5C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal static void PopulatePropertiesFastPath(object obj, JsonTypeInfo jsonTypeInfo, JsonSerializerOptions options, ref Utf8JsonReader reader, [ScopedRef] ref ReadStack state)
		{
			Action<object> onDeserializing = jsonTypeInfo.OnDeserializing;
			if (onDeserializing != null)
			{
				onDeserializing(obj);
			}
			state.Current.InitializeRequiredPropertiesValidationState(jsonTypeInfo);
			for (;;)
			{
				ref reader.ReadWithVerify();
				if (reader.TokenType == JsonTokenType.EndObject)
				{
					break;
				}
				bool flag;
				ReadOnlySpan<byte> propertyName = JsonSerializer.GetPropertyName(ref state, ref reader, options, out flag);
				jsonTypeInfo.ValidateCanBeUsedForPropertyMetadataSerialization();
				bool useExtensionProperty;
				JsonPropertyInfo jsonPropertyInfo = JsonSerializer.LookupProperty(obj, propertyName, ref state, options, out useExtensionProperty, true);
				ObjectDefaultConverter<T>.ReadPropertyValue(obj, ref state, ref reader, jsonPropertyInfo, useExtensionProperty);
			}
			Action<object> onDeserialized = jsonTypeInfo.OnDeserialized;
			if (onDeserialized != null)
			{
				onDeserialized(obj);
			}
			state.Current.ValidateAllRequiredPropertiesAreRead(jsonTypeInfo);
			if (state.Current.PropertyRefCacheBuilder != null)
			{
				jsonTypeInfo.UpdateUtf8PropertyCache(ref state.Current);
			}
		}

		// Token: 0x06000DF8 RID: 3576 RVA: 0x00035B00 File Offset: 0x00033D00
		internal unsafe sealed override bool OnTryWrite(Utf8JsonWriter writer, T value, JsonSerializerOptions options, ref WriteStack state)
		{
			JsonTypeInfo jsonTypeInfo = state.Current.JsonTypeInfo;
			jsonTypeInfo.ValidateCanBeUsedForPropertyMetadataSerialization();
			object obj = value;
			if (!state.SupportContinuation)
			{
				Action<object> onSerializing = jsonTypeInfo.OnSerializing;
				if (onSerializing != null)
				{
					onSerializing(obj);
				}
				writer.WriteStartObject();
				if (state.CurrentContainsMetadata && this.CanHaveMetadata)
				{
					JsonSerializer.WriteMetadataForObject(this, ref state, writer);
				}
				ReadOnlySpan<JsonPropertyInfo> propertyCache = jsonTypeInfo.PropertyCache;
				for (int i = 0; i < propertyCache.Length; i++)
				{
					JsonPropertyInfo jsonPropertyInfo = *propertyCache[i];
					if (jsonPropertyInfo.CanSerialize)
					{
						state.Current.JsonPropertyInfo = jsonPropertyInfo;
						state.Current.NumberHandling = jsonPropertyInfo.EffectiveNumberHandling;
						jsonPropertyInfo.GetMemberAndWriteJson(obj, ref state, writer);
						state.Current.EndProperty();
					}
				}
				JsonPropertyInfo extensionDataProperty = jsonTypeInfo.ExtensionDataProperty;
				if (extensionDataProperty != null && extensionDataProperty.CanSerialize)
				{
					state.Current.JsonPropertyInfo = extensionDataProperty;
					state.Current.NumberHandling = extensionDataProperty.EffectiveNumberHandling;
					extensionDataProperty.GetMemberAndWriteJsonExtensionData(obj, ref state, writer);
					state.Current.EndProperty();
				}
				writer.WriteEndObject();
			}
			else
			{
				if (!state.Current.ProcessedStartToken)
				{
					writer.WriteStartObject();
					if (state.CurrentContainsMetadata && this.CanHaveMetadata)
					{
						JsonSerializer.WriteMetadataForObject(this, ref state, writer);
					}
					Action<object> onSerializing2 = jsonTypeInfo.OnSerializing;
					if (onSerializing2 != null)
					{
						onSerializing2(obj);
					}
					state.Current.ProcessedStartToken = true;
				}
				ReadOnlySpan<JsonPropertyInfo> propertyCache2 = jsonTypeInfo.PropertyCache;
				while (state.Current.EnumeratorIndex < propertyCache2.Length)
				{
					JsonPropertyInfo jsonPropertyInfo2 = *propertyCache2[state.Current.EnumeratorIndex];
					if (jsonPropertyInfo2.CanSerialize)
					{
						state.Current.JsonPropertyInfo = jsonPropertyInfo2;
						state.Current.NumberHandling = jsonPropertyInfo2.EffectiveNumberHandling;
						if (!jsonPropertyInfo2.GetMemberAndWriteJson(obj, ref state, writer))
						{
							return false;
						}
						state.Current.EndProperty();
						state.Current.EnumeratorIndex = state.Current.EnumeratorIndex + 1;
						if (JsonConverter.ShouldFlush(ref state, writer))
						{
							return false;
						}
					}
					else
					{
						state.Current.EnumeratorIndex = state.Current.EnumeratorIndex + 1;
					}
				}
				if (state.Current.EnumeratorIndex == propertyCache2.Length)
				{
					JsonPropertyInfo extensionDataProperty2 = jsonTypeInfo.ExtensionDataProperty;
					if (extensionDataProperty2 != null && extensionDataProperty2.CanSerialize)
					{
						state.Current.JsonPropertyInfo = extensionDataProperty2;
						state.Current.NumberHandling = extensionDataProperty2.EffectiveNumberHandling;
						if (!extensionDataProperty2.GetMemberAndWriteJsonExtensionData(obj, ref state, writer))
						{
							return false;
						}
						state.Current.EndProperty();
						state.Current.EnumeratorIndex = state.Current.EnumeratorIndex + 1;
						if (JsonConverter.ShouldFlush(ref state, writer))
						{
							return false;
						}
					}
					else
					{
						state.Current.EnumeratorIndex = state.Current.EnumeratorIndex + 1;
					}
				}
				if (!state.Current.ProcessedEndToken)
				{
					state.Current.ProcessedEndToken = true;
					writer.WriteEndObject();
				}
			}
			Action<object> onSerialized = jsonTypeInfo.OnSerialized;
			if (onSerialized != null)
			{
				onSerialized(obj);
			}
			return true;
		}

		// Token: 0x06000DF9 RID: 3577 RVA: 0x00035DE8 File Offset: 0x00033FE8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		protected static void ReadPropertyValue(object obj, [ScopedRef] ref ReadStack state, ref Utf8JsonReader reader, JsonPropertyInfo jsonPropertyInfo, bool useExtensionProperty)
		{
			if (!jsonPropertyInfo.CanDeserializeOrPopulate)
			{
				reader.TrySkip();
			}
			else
			{
				ref reader.ReadWithVerify();
				if (!useExtensionProperty)
				{
					jsonPropertyInfo.ReadJsonAndSetMember(obj, ref state, ref reader);
				}
				else
				{
					jsonPropertyInfo.ReadJsonAndAddExtensionProperty(obj, ref state, ref reader);
				}
			}
			state.Current.EndProperty();
		}

		// Token: 0x06000DFA RID: 3578 RVA: 0x00035E28 File Offset: 0x00034028
		protected static bool ReadAheadPropertyValue([ScopedRef] ref ReadStack state, ref Utf8JsonReader reader, JsonPropertyInfo jsonPropertyInfo)
		{
			bool requiresReadAhead = jsonPropertyInfo.EffectiveConverter.RequiresReadAhead || state.Current.UseExtensionProperty;
			return ref reader.TryAdvanceWithOptionalReadAhead(requiresReadAhead);
		}
	}
}
