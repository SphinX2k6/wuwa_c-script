using System;
using System.Buffers;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000132 RID: 306
	internal abstract class ObjectWithParameterizedConstructorConverter<T> : ObjectDefaultConverter<T>
	{
		// Token: 0x17000326 RID: 806
		// (get) Token: 0x06000DFC RID: 3580 RVA: 0x00003363 File Offset: 0x00001563
		internal sealed override bool ConstructorIsParameterized
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000DFD RID: 3581 RVA: 0x00035E60 File Offset: 0x00034060
		internal sealed override bool OnTryRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, [ScopedRef] ref ReadStack state, [MaybeNullWhen(false)] out T value)
		{
			JsonTypeInfo jsonTypeInfo = state.Current.JsonTypeInfo;
			if (!jsonTypeInfo.UsesParameterizedConstructor || state.Current.IsPopulating)
			{
				return base.OnTryRead(ref reader, typeToConvert, options, ref state, out value);
			}
			ArgumentState ctorArgumentState = state.Current.CtorArgumentState;
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
					object returnValue = state.Current.ReturnValue;
					ObjectDefaultConverter<T>.PopulatePropertiesFastPath(returnValue, jsonTypeInfo, options, ref reader, ref state);
					value = (T)((object)returnValue);
					return true;
				}
				ReadOnlySpan<byte> originalSpan = reader.OriginalSpan;
				ReadOnlySequence<byte> originalSequence = reader.OriginalSequence;
				this.ReadConstructorArguments(ref state, ref reader, options);
				state.Current.ValidateAllRequiredPropertiesAreRead(jsonTypeInfo);
				obj = (T)((object)this.CreateObject(ref state.Current));
				Action<object> onDeserializing = jsonTypeInfo.OnDeserializing;
				if (onDeserializing != null)
				{
					onDeserializing(obj);
				}
				if (ctorArgumentState.FoundPropertyCount > 0)
				{
					ValueTuple<JsonPropertyInfo, JsonReaderState, long, byte[], string>[] foundProperties = ctorArgumentState.FoundProperties;
					for (int i = 0; i < ctorArgumentState.FoundPropertyCount; i++)
					{
						JsonPropertyInfo item = foundProperties[i].Item1;
						long item2 = foundProperties[i].Item3;
						byte[] item3 = foundProperties[i].Item4;
						string item4 = foundProperties[i].Item5;
						Utf8JsonReader utf8JsonReader = originalSequence.IsEmpty ? new Utf8JsonReader(originalSpan.Slice(checked((int)item2)), true, foundProperties[i].Item2) : new Utf8JsonReader(originalSequence.Slice(item2), true, foundProperties[i].Item2);
						state.Current.JsonPropertyName = item3;
						state.Current.JsonPropertyInfo = item;
						state.Current.NumberHandling = item.EffectiveNumberHandling;
						bool flag = item4 != null;
						if (flag)
						{
							state.Current.JsonPropertyNameAsString = item4;
							JsonSerializer.CreateExtensionDataProperty(obj, item, options);
						}
						ObjectDefaultConverter<T>.ReadPropertyValue(obj, ref state, ref utf8JsonReader, item, flag);
					}
					ValueTuple<JsonPropertyInfo, JsonReaderState, long, byte[], string>[] foundProperties2 = ctorArgumentState.FoundProperties;
					ctorArgumentState.FoundProperties = null;
					ArrayPool<ValueTuple<JsonPropertyInfo, JsonReaderState, long, byte[], string>>.Shared.Return(foundProperties2, true);
				}
			}
			else
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
						bool flag2 = jsonConverter.OnTryReadAsObject(ref reader, jsonConverter.Type, options, ref state, out obj2);
						value = (T)((object)obj2);
						state.ExitPolymorphicConverter(flag2);
						return flag2;
					}
				}
				JsonPropertyInfo parentProperty2 = state.ParentProperty;
				if (parentProperty2 != null && parentProperty2.TryGetPrePopulatedValue(ref state))
				{
					object returnValue2 = state.Current.ReturnValue;
					Action<object> onDeserializing2 = jsonTypeInfo.OnDeserializing;
					if (onDeserializing2 != null)
					{
						onDeserializing2(returnValue2);
					}
					state.Current.ObjectState = StackFrameObjectState.CreatedObject;
					state.Current.InitializeRequiredPropertiesValidationState(jsonTypeInfo);
					return base.OnTryRead(ref reader, typeToConvert, options, ref state, out value);
				}
				if (state.Current.ObjectState < StackFrameObjectState.ConstructorArguments)
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
					this.BeginRead(ref state, options);
					state.Current.ObjectState = StackFrameObjectState.ConstructorArguments;
				}
				if (!this.ReadConstructorArgumentsWithContinuation(ref state, ref reader, options))
				{
					value = default(T);
					return false;
				}
				state.Current.ValidateAllRequiredPropertiesAreRead(jsonTypeInfo);
				obj = (T)((object)this.CreateObject(ref state.Current));
				if ((state.Current.MetadataPropertyNames & MetadataPropertyName.Id) != MetadataPropertyName.None)
				{
					state.ReferenceResolver.AddReference(state.ReferenceId, obj);
					state.ReferenceId = null;
				}
				Action<object> onDeserializing3 = jsonTypeInfo.OnDeserializing;
				if (onDeserializing3 != null)
				{
					onDeserializing3(obj);
				}
				if (ctorArgumentState.FoundPropertyCount > 0)
				{
					for (int j = 0; j < ctorArgumentState.FoundPropertyCount; j++)
					{
						JsonPropertyInfo item5 = ctorArgumentState.FoundPropertiesAsync[j].Item1;
						object item6 = ctorArgumentState.FoundPropertiesAsync[j].Item2;
						string item7 = ctorArgumentState.FoundPropertiesAsync[j].Item3;
						if (item7 == null)
						{
							if (item6 != null || !item5.IgnoreNullTokensOnRead || default(T) != null)
							{
								item5.Set(obj, item6);
							}
						}
						else
						{
							JsonSerializer.CreateExtensionDataProperty(obj, item5, options);
							object valueAsObject = item5.GetValueAsObject(obj);
							IDictionary<string, JsonElement> dictionary = valueAsObject as IDictionary<string, JsonElement>;
							if (dictionary != null)
							{
								dictionary[item7] = (JsonElement)item6;
							}
							else
							{
								((IDictionary<string, object>)valueAsObject)[item7] = item6;
							}
						}
					}
					ValueTuple<JsonPropertyInfo, object, string>[] foundPropertiesAsync = ctorArgumentState.FoundPropertiesAsync;
					ctorArgumentState.FoundPropertiesAsync = null;
					ArrayPool<ValueTuple<JsonPropertyInfo, object, string>>.Shared.Return(foundPropertiesAsync, true);
				}
			}
			Action<object> onDeserialized = jsonTypeInfo.OnDeserialized;
			if (onDeserialized != null)
			{
				onDeserialized(obj);
			}
			value = (T)((object)obj);
			if (state.Current.PropertyRefCacheBuilder != null)
			{
				jsonTypeInfo.UpdateUtf8PropertyCache(ref state.Current);
			}
			return true;
		}

		// Token: 0x06000DFE RID: 3582
		protected abstract void InitializeConstructorArgumentCaches(ref ReadStack state, JsonSerializerOptions options);

		// Token: 0x06000DFF RID: 3583
		protected abstract bool ReadAndCacheConstructorArgument([ScopedRef] ref ReadStack state, ref Utf8JsonReader reader, JsonParameterInfo jsonParameterInfo);

		// Token: 0x06000E00 RID: 3584
		protected abstract object CreateObject(ref ReadStackFrame frame);

		// Token: 0x06000E01 RID: 3585 RVA: 0x000363F4 File Offset: 0x000345F4
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void ReadConstructorArguments([ScopedRef] ref ReadStack state, ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
			this.BeginRead(ref state, options);
			for (;;)
			{
				ref reader.ReadWithVerify();
				if (reader.TokenType == JsonTokenType.EndObject)
				{
					break;
				}
				bool flag;
				ReadOnlySpan<byte> propertyName = JsonSerializer.GetPropertyName(ref state, ref reader, options, out flag);
				JsonPropertyInfo jsonPropertyInfo;
				JsonParameterInfo jsonParameterInfo;
				if (flag)
				{
					ref reader.SkipWithVerify();
					state.Current.EndProperty();
				}
				else if (ObjectWithParameterizedConstructorConverter<T>.TryLookupConstructorParameter(propertyName, ref state, options, out jsonPropertyInfo, out jsonParameterInfo))
				{
					ref reader.ReadWithVerify();
					if (!jsonParameterInfo.ShouldDeserialize)
					{
						reader.TrySkip();
						state.Current.EndConstructorParameter();
					}
					else
					{
						this.ReadAndCacheConstructorArgument(ref state, ref reader, jsonParameterInfo);
						state.Current.EndConstructorParameter();
					}
				}
				else
				{
					if (jsonPropertyInfo.CanDeserialize)
					{
						ArgumentState ctorArgumentState = state.Current.CtorArgumentState;
						if (ctorArgumentState.FoundProperties == null)
						{
							ctorArgumentState.FoundProperties = ArrayPool<ValueTuple<JsonPropertyInfo, JsonReaderState, long, byte[], string>>.Shared.Rent(Math.Max(1, state.Current.JsonTypeInfo.PropertyCache.Length));
						}
						else if (ctorArgumentState.FoundPropertyCount == ctorArgumentState.FoundProperties.Length)
						{
							ValueTuple<JsonPropertyInfo, JsonReaderState, long, byte[], string>[] array = ArrayPool<ValueTuple<JsonPropertyInfo, JsonReaderState, long, byte[], string>>.Shared.Rent(ctorArgumentState.FoundProperties.Length * 2);
							ctorArgumentState.FoundProperties.CopyTo(array, 0);
							ValueTuple<JsonPropertyInfo, JsonReaderState, long, byte[], string>[] foundProperties = ctorArgumentState.FoundProperties;
							ctorArgumentState.FoundProperties = array;
							ArrayPool<ValueTuple<JsonPropertyInfo, JsonReaderState, long, byte[], string>>.Shared.Return(foundProperties, true);
						}
						ValueTuple<JsonPropertyInfo, JsonReaderState, long, byte[], string>[] foundProperties2 = ctorArgumentState.FoundProperties;
						ArgumentState argumentState = ctorArgumentState;
						int foundPropertyCount = argumentState.FoundPropertyCount;
						argumentState.FoundPropertyCount = foundPropertyCount + 1;
						foundProperties2[foundPropertyCount] = new ValueTuple<JsonPropertyInfo, JsonReaderState, long, byte[], string>(jsonPropertyInfo, reader.CurrentState, reader.BytesConsumed, state.Current.JsonPropertyName, state.Current.JsonPropertyNameAsString);
					}
					ref reader.SkipWithVerify();
					state.Current.EndProperty();
				}
			}
		}

		// Token: 0x06000E02 RID: 3586 RVA: 0x0003658C File Offset: 0x0003478C
		private bool ReadConstructorArgumentsWithContinuation([ScopedRef] ref ReadStack state, ref Utf8JsonReader reader, JsonSerializerOptions options)
		{
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
				JsonParameterInfo jsonParameterInfo;
				if (state.Current.PropertyState < StackFramePropertyState.Name)
				{
					if (reader.TokenType == JsonTokenType.EndObject)
					{
						return true;
					}
					bool flag;
					ReadOnlySpan<byte> propertyName = JsonSerializer.GetPropertyName(ref state, ref reader, options, out flag);
					if (flag)
					{
						ref reader.SkipWithVerify();
						state.Current.EndProperty();
						continue;
					}
					if (ObjectWithParameterizedConstructorConverter<T>.TryLookupConstructorParameter(propertyName, ref state, options, out jsonPropertyInfo, out jsonParameterInfo))
					{
						jsonPropertyInfo = null;
					}
					state.Current.PropertyState = StackFramePropertyState.Name;
				}
				else
				{
					jsonParameterInfo = state.Current.CtorArgumentState.JsonParameterInfo;
					jsonPropertyInfo = state.Current.JsonPropertyInfo;
				}
				if (jsonParameterInfo != null)
				{
					if (!this.HandleConstructorArgumentWithContinuation(ref state, ref reader, jsonParameterInfo))
					{
						return false;
					}
				}
				else if (!ObjectWithParameterizedConstructorConverter<T>.HandlePropertyWithContinuation(ref state, ref reader, jsonPropertyInfo))
				{
					return false;
				}
			}
			return false;
		}

		// Token: 0x06000E03 RID: 3587 RVA: 0x00036654 File Offset: 0x00034854
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private bool HandleConstructorArgumentWithContinuation([ScopedRef] ref ReadStack state, ref Utf8JsonReader reader, JsonParameterInfo jsonParameterInfo)
		{
			if (state.Current.PropertyState < StackFramePropertyState.ReadValue)
			{
				if (!jsonParameterInfo.ShouldDeserialize)
				{
					if (!reader.TrySkipPartial(state.Current.OriginalDepth + 1))
					{
						return false;
					}
					state.Current.EndConstructorParameter();
					return true;
				}
				else
				{
					if (!ref reader.TryAdvanceWithOptionalReadAhead(jsonParameterInfo.EffectiveConverter.RequiresReadAhead))
					{
						return false;
					}
					state.Current.PropertyState = StackFramePropertyState.ReadValue;
				}
			}
			if (!this.ReadAndCacheConstructorArgument(ref state, ref reader, jsonParameterInfo))
			{
				return false;
			}
			state.Current.EndConstructorParameter();
			return true;
		}

		// Token: 0x06000E04 RID: 3588 RVA: 0x000366D8 File Offset: 0x000348D8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool HandlePropertyWithContinuation([ScopedRef] ref ReadStack state, ref Utf8JsonReader reader, JsonPropertyInfo jsonPropertyInfo)
		{
			if (state.Current.PropertyState < StackFramePropertyState.ReadValue)
			{
				if (!jsonPropertyInfo.CanDeserialize)
				{
					if (!reader.TrySkipPartial(state.Current.OriginalDepth + 1))
					{
						return false;
					}
					state.Current.EndProperty();
					return true;
				}
				else
				{
					if (!ObjectDefaultConverter<T>.ReadAheadPropertyValue(ref state, ref reader, jsonPropertyInfo))
					{
						return false;
					}
					state.Current.PropertyState = StackFramePropertyState.ReadValue;
				}
			}
			object item;
			if (state.Current.UseExtensionProperty)
			{
				if (!jsonPropertyInfo.ReadJsonExtensionDataValue(ref state, ref reader, out item))
				{
					return false;
				}
			}
			else if (!jsonPropertyInfo.ReadJsonAsObject(ref state, ref reader, out item))
			{
				return false;
			}
			ArgumentState ctorArgumentState = state.Current.CtorArgumentState;
			if (ctorArgumentState.FoundPropertiesAsync == null)
			{
				ctorArgumentState.FoundPropertiesAsync = ArrayPool<ValueTuple<JsonPropertyInfo, object, string>>.Shared.Rent(Math.Max(1, state.Current.JsonTypeInfo.PropertyCache.Length));
			}
			else if (ctorArgumentState.FoundPropertyCount == ctorArgumentState.FoundPropertiesAsync.Length)
			{
				ValueTuple<JsonPropertyInfo, object, string>[] array = ArrayPool<ValueTuple<JsonPropertyInfo, object, string>>.Shared.Rent(ctorArgumentState.FoundPropertiesAsync.Length * 2);
				ctorArgumentState.FoundPropertiesAsync.CopyTo(array, 0);
				ValueTuple<JsonPropertyInfo, object, string>[] foundPropertiesAsync = ctorArgumentState.FoundPropertiesAsync;
				ctorArgumentState.FoundPropertiesAsync = array;
				ArrayPool<ValueTuple<JsonPropertyInfo, object, string>>.Shared.Return(foundPropertiesAsync, true);
			}
			ValueTuple<JsonPropertyInfo, object, string>[] foundPropertiesAsync2 = ctorArgumentState.FoundPropertiesAsync;
			ArgumentState argumentState = ctorArgumentState;
			int foundPropertyCount = argumentState.FoundPropertyCount;
			argumentState.FoundPropertyCount = foundPropertyCount + 1;
			foundPropertiesAsync2[foundPropertyCount] = new ValueTuple<JsonPropertyInfo, object, string>(jsonPropertyInfo, item, state.Current.JsonPropertyNameAsString);
			state.Current.EndProperty();
			return true;
		}

		// Token: 0x06000E05 RID: 3589 RVA: 0x00036830 File Offset: 0x00034A30
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private void BeginRead([ScopedRef] ref ReadStack state, JsonSerializerOptions options)
		{
			JsonTypeInfo jsonTypeInfo = state.Current.JsonTypeInfo;
			jsonTypeInfo.ValidateCanBeUsedForPropertyMetadataSerialization();
			if (jsonTypeInfo.ParameterCount != jsonTypeInfo.ParameterCache.Length)
			{
				ThrowHelper.ThrowInvalidOperationException_ConstructorParameterIncompleteBinding(this.Type);
			}
			state.Current.InitializeRequiredPropertiesValidationState(jsonTypeInfo);
			state.Current.JsonPropertyInfo = null;
			this.InitializeConstructorArgumentCaches(ref state, options);
		}

		// Token: 0x06000E06 RID: 3590 RVA: 0x00036890 File Offset: 0x00034A90
		protected static bool TryLookupConstructorParameter([ScopedRef] ReadOnlySpan<byte> unescapedPropertyName, [ScopedRef] ref ReadStack state, JsonSerializerOptions options, out JsonPropertyInfo jsonPropertyInfo, [NotNullWhen(true)] out JsonParameterInfo jsonParameterInfo)
		{
			bool useExtensionProperty;
			jsonPropertyInfo = JsonSerializer.LookupProperty(null, unescapedPropertyName, ref state, options, out useExtensionProperty, false);
			state.Current.MarkRequiredPropertyAsRead(jsonPropertyInfo);
			jsonParameterInfo = jsonPropertyInfo.AssociatedParameter;
			if (jsonParameterInfo != null)
			{
				state.Current.JsonPropertyInfo = null;
				state.Current.CtorArgumentState.JsonParameterInfo = jsonParameterInfo;
				state.Current.NumberHandling = jsonParameterInfo.NumberHandling;
				return true;
			}
			state.Current.UseExtensionProperty = useExtensionProperty;
			return false;
		}
	}
}
