using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Json.Serialization.Converters;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization
{
	// Token: 0x020000A6 RID: 166
	[NullableContext(1)]
	[Nullable(0)]
	public abstract class JsonConverter<[Nullable(2)] T> : JsonConverter
	{
		// Token: 0x0600099F RID: 2463 RVA: 0x00029830 File Offset: 0x00027A30
		internal bool ReadCore(ref Utf8JsonReader reader, out T value, JsonSerializerOptions options, ref ReadStack state)
		{
			bool result;
			try
			{
				if (!state.IsContinuation && !base.IsRootLevelMultiContentStreamingConverter && !ref reader.TryAdvanceWithOptionalReadAhead(base.RequiresReadAhead))
				{
					if (state.SupportContinuation)
					{
						object returnValue = state.Current.ReturnValue;
						if (returnValue != null)
						{
							value = (T)((object)returnValue);
							goto IL_4D;
						}
					}
					value = default(T);
					IL_4D:
					result = reader.IsFinalBlock;
				}
				else
				{
					bool flag2;
					bool flag = this.TryRead(ref reader, state.Current.JsonTypeInfo.Type, options, ref state, out value, out flag2);
					if (flag && !reader.AllowMultipleValues && !reader.Read() && !reader.IsFinalBlock)
					{
						state.Current.ReturnValue = value;
						flag = false;
					}
					result = flag;
				}
			}
			catch (Exception ex)
			{
				Exception ex2 = ex;
				JsonReaderException ex3 = ex2 as JsonReaderException;
				if (ex3 == null)
				{
					if (!(ex2 is FormatException))
					{
						if (!(ex2 is InvalidOperationException))
						{
							JsonException ex4 = ex2 as JsonException;
							if (ex4 == null)
							{
								if (ex2 is NotSupportedException)
								{
									if (!ex.Message.Contains(" Path: "))
									{
										ThrowHelper.ThrowNotSupportedException(ref state, reader, ex);
									}
								}
							}
							else if (ex4.Path == null)
							{
								ThrowHelper.AddJsonExceptionInformation(ref state, reader, ex4);
							}
						}
						else if (ex.Source == "System.Text.Json.Rethrowable")
						{
							ThrowHelper.ReThrowWithPath(ref state, reader, ex);
						}
					}
					else if (ex.Source == "System.Text.Json.Rethrowable")
					{
						ThrowHelper.ReThrowWithPath(ref state, reader, ex);
					}
				}
				else
				{
					ThrowHelper.ReThrowWithPath(ref state, ex3);
				}
				throw;
			}
			return result;
		}

		// Token: 0x060009A0 RID: 2464 RVA: 0x000299BC File Offset: 0x00027BBC
		internal bool WriteCore(Utf8JsonWriter writer, in T value, JsonSerializerOptions options, ref WriteStack state)
		{
			bool result;
			try
			{
				result = this.TryWrite(writer, value, options, ref state);
			}
			catch (Exception ex)
			{
				if (!state.SupportAsync)
				{
					state.DisposePendingDisposablesOnException();
				}
				Exception ex2 = ex;
				if (!(ex2 is InvalidOperationException))
				{
					JsonException ex3 = ex2 as JsonException;
					if (ex3 != null)
					{
						if (ex3.Path == null)
						{
							ThrowHelper.AddJsonExceptionInformation(ref state, ex3);
						}
					}
					else if (ex2 is NotSupportedException)
					{
						if (!ex.Message.Contains(" Path: "))
						{
							ThrowHelper.ThrowNotSupportedException(ref state, ex);
						}
					}
				}
				else if (ex.Source == "System.Text.Json.Rethrowable")
				{
					ThrowHelper.ReThrowWithPath(ref state, ex);
				}
				throw;
			}
			return result;
		}

		// Token: 0x060009A1 RID: 2465 RVA: 0x00029A64 File Offset: 0x00027C64
		protected internal JsonConverter()
		{
			base.IsValueType = typeof(T).IsValueType;
			if (this.HandleNull)
			{
				base.HandleNullOnRead = true;
				base.HandleNullOnWrite = true;
				return;
			}
			if (base.UsesDefaultHandleNull)
			{
				base.HandleNullOnRead = (default(T) != null);
				base.HandleNullOnWrite = false;
			}
		}

		// Token: 0x060009A2 RID: 2466 RVA: 0x000281E0 File Offset: 0x000263E0
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert == typeof(T);
		}

		// Token: 0x060009A3 RID: 2467 RVA: 0x0002444B File Offset: 0x0002264B
		private protected override ConverterStrategy GetDefaultConverterStrategy()
		{
			return ConverterStrategy.Value;
		}

		// Token: 0x060009A4 RID: 2468 RVA: 0x00029ADC File Offset: 0x00027CDC
		internal sealed override JsonTypeInfo CreateJsonTypeInfo(JsonSerializerOptions options)
		{
			return new JsonTypeInfo<T>(this, options);
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x060009A5 RID: 2469 RVA: 0x00029AE5 File Offset: 0x00027CE5
		public virtual bool HandleNull
		{
			get
			{
				base.UsesDefaultHandleNull = true;
				return false;
			}
		}

		// Token: 0x060009A6 RID: 2470 RVA: 0x00029AF0 File Offset: 0x00027CF0
		internal sealed override void WriteAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
		{
			T value2 = JsonSerializer.UnboxOnWrite<T>(value);
			this.Write(writer, value2, options);
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x00029B10 File Offset: 0x00027D10
		internal sealed override bool OnTryWriteAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, ref WriteStack state)
		{
			T value2 = JsonSerializer.UnboxOnWrite<T>(value);
			return this.OnTryWrite(writer, value2, options, ref state);
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x00029B30 File Offset: 0x00027D30
		internal sealed override void WriteAsPropertyNameAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options)
		{
			T value2 = JsonSerializer.UnboxOnWrite<T>(value);
			this.WriteAsPropertyName(writer, value2, options);
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x00029B50 File Offset: 0x00027D50
		internal sealed override void WriteAsPropertyNameCoreAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			T value2 = JsonSerializer.UnboxOnWrite<T>(value);
			this.WriteAsPropertyNameCore(writer, value2, options, isWritingExtensionDataProperty);
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x00029B70 File Offset: 0x00027D70
		internal sealed override void WriteNumberWithCustomHandlingAsObject(Utf8JsonWriter writer, object value, JsonNumberHandling handling)
		{
			T value2 = JsonSerializer.UnboxOnWrite<T>(value);
			this.WriteNumberWithCustomHandling(writer, value2, handling);
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00029B90 File Offset: 0x00027D90
		internal sealed override bool TryWriteAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, ref WriteStack state)
		{
			T t = JsonSerializer.UnboxOnWrite<T>(value);
			return this.TryWrite(writer, t, options, ref state);
		}

		// Token: 0x060009AC RID: 2476 RVA: 0x00029BB0 File Offset: 0x00027DB0
		internal virtual bool OnTryWrite(Utf8JsonWriter writer, T value, JsonSerializerOptions options, ref WriteStack state)
		{
			this.Write(writer, value, options);
			return true;
		}

		// Token: 0x060009AD RID: 2477 RVA: 0x00029BBC File Offset: 0x00027DBC
		internal virtual bool OnTryRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, [ScopedRef] ref ReadStack state, out T value)
		{
			value = this.Read(ref reader, typeToConvert, options);
			return true;
		}

		// Token: 0x060009AE RID: 2478
		[return: Nullable(2)]
		public abstract T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options);

		// Token: 0x060009AF RID: 2479 RVA: 0x00029BD0 File Offset: 0x00027DD0
		internal bool TryRead(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, [ScopedRef] ref ReadStack state, out T value, out bool isPopulatedValue)
		{
			if (reader.TokenType == JsonTokenType.Null && !base.HandleNullOnRead && !state.IsContinuation)
			{
				if (default(T) != null)
				{
					ThrowHelper.ThrowJsonException_DeserializeUnableToConvertValue(this.Type);
				}
				value = default(T);
				isPopulatedValue = false;
				return true;
			}
			if (base.ConverterStrategy == ConverterStrategy.Value)
			{
				if (base.IsInternalConverter)
				{
					if (state.Current.NumberHandling != null && base.IsInternalConverterForNumberType)
					{
						value = this.ReadNumberWithCustomHandling(ref reader, state.Current.NumberHandling.Value, options);
					}
					else
					{
						value = this.Read(ref reader, typeToConvert, options);
					}
				}
				else
				{
					JsonTokenType tokenType = reader.TokenType;
					int currentDepth = reader.CurrentDepth;
					long bytesConsumed = reader.BytesConsumed;
					if (state.Current.NumberHandling != null && base.IsInternalConverterForNumberType)
					{
						value = this.ReadNumberWithCustomHandling(ref reader, state.Current.NumberHandling.Value, options);
					}
					else
					{
						value = this.Read(ref reader, typeToConvert, options);
					}
					this.VerifyRead(tokenType, currentDepth, bytesConsumed, true, ref reader);
				}
				isPopulatedValue = false;
				return true;
			}
			bool isContinuation = state.IsContinuation;
			bool flag;
			if (!typeof(T).IsValueType && base.CanBePolymorphic)
			{
				flag = this.OnTryRead(ref reader, typeToConvert, options, ref state, out value);
				isPopulatedValue = false;
				return true;
			}
			JsonPropertyInfo jsonPropertyInfo = state.Current.JsonPropertyInfo;
			bool returnValue = state.Current.ReturnValue != null;
			state.Push();
			if (!isContinuation)
			{
				state.Current.OriginalDepth = reader.CurrentDepth;
			}
			if (returnValue && jsonPropertyInfo != null && !jsonPropertyInfo.IsForTypeInfo)
			{
				state.Current.HasParentObject = true;
			}
			flag = this.OnTryRead(ref reader, typeToConvert, options, ref state, out value);
			isPopulatedValue = state.Current.IsPopulating;
			state.Pop(flag);
			return flag;
		}

		// Token: 0x060009B0 RID: 2480 RVA: 0x00029DAC File Offset: 0x00027FAC
		internal sealed override bool OnTryReadAsObject(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, [ScopedRef] ref ReadStack state, out object value)
		{
			T t;
			bool result = this.OnTryRead(ref reader, typeToConvert, options, ref state, out t);
			value = t;
			return result;
		}

		// Token: 0x060009B1 RID: 2481 RVA: 0x00029DD0 File Offset: 0x00027FD0
		internal sealed override bool TryReadAsObject(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, [ScopedRef] ref ReadStack state, out object value)
		{
			T t;
			bool flag;
			bool result = this.TryRead(ref reader, typeToConvert, options, ref state, out t, out flag);
			value = t;
			return result;
		}

		// Token: 0x060009B2 RID: 2482 RVA: 0x00029DF5 File Offset: 0x00027FF5
		internal sealed override object ReadAsObject(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return this.Read(ref reader, typeToConvert, options);
		}

		// Token: 0x060009B3 RID: 2483 RVA: 0x00029E05 File Offset: 0x00028005
		internal sealed override object ReadAsPropertyNameAsObject(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return this.ReadAsPropertyName(ref reader, typeToConvert, options);
		}

		// Token: 0x060009B4 RID: 2484 RVA: 0x00029E15 File Offset: 0x00028015
		internal sealed override object ReadAsPropertyNameCoreAsObject(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return this.ReadAsPropertyNameCore(ref reader, typeToConvert, options);
		}

		// Token: 0x060009B5 RID: 2485 RVA: 0x00029E25 File Offset: 0x00028025
		internal sealed override object ReadNumberWithCustomHandlingAsObject(ref Utf8JsonReader reader, JsonNumberHandling handling, JsonSerializerOptions options)
		{
			return this.ReadNumberWithCustomHandling(ref reader, handling, options);
		}

		// Token: 0x060009B6 RID: 2486 RVA: 0x00029E35 File Offset: 0x00028035
		private static bool IsNull(T value)
		{
			return value == null;
		}

		// Token: 0x060009B7 RID: 2487 RVA: 0x00029E40 File Offset: 0x00028040
		internal bool TryWrite(Utf8JsonWriter writer, in T value, JsonSerializerOptions options, ref WriteStack state)
		{
			if (writer.CurrentDepth >= options.EffectiveMaxDepth)
			{
				ThrowHelper.ThrowJsonException_SerializerCycleDetected(options.EffectiveMaxDepth);
			}
			if (default(T) == null && !base.HandleNullOnWrite && JsonConverter<T>.IsNull(value))
			{
				writer.WriteNullValue();
				return true;
			}
			if (base.ConverterStrategy == ConverterStrategy.Value)
			{
				int currentDepth = writer.CurrentDepth;
				if (state.Current.NumberHandling != null && base.IsInternalConverterForNumberType)
				{
					this.WriteNumberWithCustomHandling(writer, value, state.Current.NumberHandling.Value);
				}
				else
				{
					this.Write(writer, value, options);
				}
				this.VerifyWrite(currentDepth, writer);
				return true;
			}
			bool isContinuation = state.IsContinuation;
			bool flag;
			if (!typeof(T).IsValueType && value != null && state.Current.PolymorphicSerializationState != PolymorphicSerializationState.PolymorphicReEntryStarted)
			{
				JsonTypeInfo jsonTypeInfo = state.PeekNestedJsonTypeInfo();
				JsonConverter jsonConverter = (base.CanBePolymorphic || jsonTypeInfo.PolymorphicTypeResolver != null) ? base.ResolvePolymorphicConverter(value, jsonTypeInfo, options, ref state) : null;
				if (!isContinuation && options.ReferenceHandlingStrategy != ReferenceHandlingStrategy.None && base.TryHandleSerializedObjectReference(writer, value, options, jsonConverter, ref state))
				{
					return true;
				}
				if (jsonConverter != null)
				{
					flag = jsonConverter.TryWriteAsObject(writer, value, options, ref state);
					state.Current.ExitPolymorphicConverter(flag);
					if (flag && state.Current.IsPushedReferenceForCycleDetection)
					{
						state.ReferenceResolver.PopReferenceForCycleDetection();
						state.Current.IsPushedReferenceForCycleDetection = false;
					}
					return flag;
				}
			}
			state.Push();
			flag = this.OnTryWrite(writer, value, options, ref state);
			state.Pop(flag);
			if (flag && state.Current.IsPushedReferenceForCycleDetection)
			{
				state.ReferenceResolver.PopReferenceForCycleDetection();
				state.Current.IsPushedReferenceForCycleDetection = false;
			}
			return flag;
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x0002A038 File Offset: 0x00028238
		internal bool TryWriteDataExtensionProperty(Utf8JsonWriter writer, T value, JsonSerializerOptions options, ref WriteStack state)
		{
			if (!base.IsInternalConverter)
			{
				return this.TryWrite(writer, value, options, ref state);
			}
			JsonDictionaryConverter<T> jsonDictionaryConverter;
			if ((jsonDictionaryConverter = (this as JsonDictionaryConverter<T>)) == null)
			{
				JsonMetadataServicesConverter<T> jsonMetadataServicesConverter = this as JsonMetadataServicesConverter<T>;
				jsonDictionaryConverter = (((jsonMetadataServicesConverter != null) ? jsonMetadataServicesConverter.Converter : null) as JsonDictionaryConverter<T>);
			}
			JsonDictionaryConverter<T> jsonDictionaryConverter2 = jsonDictionaryConverter;
			if (jsonDictionaryConverter2 == null)
			{
				return this.TryWrite(writer, value, options, ref state);
			}
			if (writer.CurrentDepth >= options.EffectiveMaxDepth)
			{
				ThrowHelper.ThrowJsonException_SerializerCycleDetected(options.EffectiveMaxDepth);
			}
			bool isContinuation = state.IsContinuation;
			state.Push();
			if (!isContinuation)
			{
				state.Current.OriginalDepth = writer.CurrentDepth;
			}
			state.Current.IsWritingExtensionDataProperty = true;
			state.Current.JsonPropertyInfo = state.Current.JsonTypeInfo.ElementTypeInfo.PropertyInfoForTypeInfo;
			bool flag = jsonDictionaryConverter2.OnWriteResume(writer, value, options, ref state);
			if (flag)
			{
				this.VerifyWrite(state.Current.OriginalDepth, writer);
			}
			state.Pop(flag);
			return flag;
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x060009B9 RID: 2489 RVA: 0x0002A121 File Offset: 0x00028321
		public sealed override Type Type { get; } = typeof(T);

		// Token: 0x060009BA RID: 2490 RVA: 0x0002A12C File Offset: 0x0002832C
		internal void VerifyRead(JsonTokenType tokenType, int depth, long bytesConsumed, bool isValueConverter, ref Utf8JsonReader reader)
		{
			switch (tokenType)
			{
			case JsonTokenType.None:
				return;
			case JsonTokenType.StartObject:
				if (reader.TokenType != JsonTokenType.EndObject)
				{
					ThrowHelper.ThrowJsonException_SerializationConverterRead(this);
					return;
				}
				if (depth != reader.CurrentDepth)
				{
					ThrowHelper.ThrowJsonException_SerializationConverterRead(this);
					return;
				}
				return;
			case JsonTokenType.StartArray:
				if (reader.TokenType != JsonTokenType.EndArray)
				{
					ThrowHelper.ThrowJsonException_SerializationConverterRead(this);
					return;
				}
				if (depth != reader.CurrentDepth)
				{
					ThrowHelper.ThrowJsonException_SerializationConverterRead(this);
					return;
				}
				return;
			}
			if (isValueConverter)
			{
				if (reader.BytesConsumed != bytesConsumed)
				{
					ThrowHelper.ThrowJsonException_SerializationConverterRead(this);
					return;
				}
			}
			else if (!base.CanBePolymorphic && (!base.HandleNullOnRead || tokenType != JsonTokenType.Null))
			{
				ThrowHelper.ThrowJsonException_SerializationConverterRead(this);
			}
		}

		// Token: 0x060009BB RID: 2491 RVA: 0x0002A1C5 File Offset: 0x000283C5
		internal void VerifyWrite(int originalDepth, Utf8JsonWriter writer)
		{
			if (originalDepth != writer.CurrentDepth)
			{
				ThrowHelper.ThrowJsonException_SerializationConverterWrite(this);
			}
		}

		// Token: 0x060009BC RID: 2492
		public abstract void Write(Utf8JsonWriter writer, [Nullable(0)] T value, JsonSerializerOptions options);

		// Token: 0x060009BD RID: 2493 RVA: 0x0002A1D6 File Offset: 0x000283D6
		public virtual T ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			JsonConverter<T> fallbackConverterForPropertyNameSerialization = this.GetFallbackConverterForPropertyNameSerialization(options);
			if (fallbackConverterForPropertyNameSerialization == null)
			{
				ThrowHelper.ThrowNotSupportedException_DictionaryKeyTypeNotSupported(this.Type, this);
			}
			return fallbackConverterForPropertyNameSerialization.ReadAsPropertyNameCore(ref reader, typeToConvert, options);
		}

		// Token: 0x060009BE RID: 2494 RVA: 0x0002A1F8 File Offset: 0x000283F8
		internal virtual T ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			long bytesConsumed = reader.BytesConsumed;
			T result = this.ReadAsPropertyName(ref reader, typeToConvert, options);
			if (reader.BytesConsumed != bytesConsumed)
			{
				ThrowHelper.ThrowJsonException_SerializationConverterRead(this);
			}
			return result;
		}

		// Token: 0x060009BF RID: 2495 RVA: 0x0002A224 File Offset: 0x00028424
		public virtual void WriteAsPropertyName(Utf8JsonWriter writer, [DisallowNull] T value, JsonSerializerOptions options)
		{
			JsonConverter<T> fallbackConverterForPropertyNameSerialization = this.GetFallbackConverterForPropertyNameSerialization(options);
			if (fallbackConverterForPropertyNameSerialization == null)
			{
				ThrowHelper.ThrowNotSupportedException_DictionaryKeyTypeNotSupported(this.Type, this);
			}
			fallbackConverterForPropertyNameSerialization.WriteAsPropertyNameCore(writer, value, options, false);
		}

		// Token: 0x060009C0 RID: 2496 RVA: 0x0002A248 File Offset: 0x00028448
		internal virtual void WriteAsPropertyNameCore(Utf8JsonWriter writer, [DisallowNull] T value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException("value");
			}
			if (isWritingExtensionDataProperty)
			{
				writer.WritePropertyName((string)((object)value));
				return;
			}
			int currentDepth = writer.CurrentDepth;
			this.WriteAsPropertyName(writer, value, options);
			if (currentDepth != writer.CurrentDepth || writer.TokenType != JsonTokenType.PropertyName)
			{
				ThrowHelper.ThrowJsonException_SerializationConverterWrite(this);
			}
		}

		// Token: 0x060009C1 RID: 2497 RVA: 0x0002A2A4 File Offset: 0x000284A4
		private JsonConverter<T> GetFallbackConverterForPropertyNameSerialization(JsonSerializerOptions options)
		{
			JsonConverter<T> jsonConverter = null;
			if (!base.IsInternalConverter && !(options.TypeInfoResolver is JsonSerializerContext))
			{
				jsonConverter = this._fallbackConverterForPropertyNameSerialization;
				JsonConverter jsonConverter2;
				if (jsonConverter == null && DefaultJsonTypeInfoResolver.TryGetDefaultSimpleConverter(this.Type, out jsonConverter2))
				{
					jsonConverter = (this._fallbackConverterForPropertyNameSerialization = (JsonConverter<T>)jsonConverter2);
				}
			}
			return jsonConverter;
		}

		// Token: 0x060009C2 RID: 2498 RVA: 0x0002A2F0 File Offset: 0x000284F0
		internal virtual T ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling, JsonSerializerOptions options)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x060009C3 RID: 2499 RVA: 0x000235D5 File Offset: 0x000217D5
		internal virtual void WriteNumberWithCustomHandling(Utf8JsonWriter writer, T value, JsonNumberHandling handling)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x040002AF RID: 687
		private JsonConverter<T> _fallbackConverterForPropertyNameSerialization;
	}
}
