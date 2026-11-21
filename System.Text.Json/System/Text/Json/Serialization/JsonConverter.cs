using System;
using System.Diagnostics.CodeAnalysis;
using System.IO.Pipelines;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json.Schema;
using System.Text.Json.Serialization.Converters;
using System.Text.Json.Serialization.Metadata;

namespace System.Text.Json.Serialization
{
	// Token: 0x020000A4 RID: 164
	[NullableContext(2)]
	[Nullable(0)]
	public abstract class JsonConverter
	{
		// Token: 0x06000953 RID: 2387 RVA: 0x00029466 File Offset: 0x00027666
		internal JsonConverter()
		{
			this.IsInternalConverter = (base.GetType().Assembly == typeof(JsonConverter).Assembly);
			this.ConverterStrategy = this.GetDefaultConverterStrategy();
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000954 RID: 2388
		public abstract Type Type { get; }

		// Token: 0x06000955 RID: 2389
		[NullableContext(1)]
		public abstract bool CanConvert(Type typeToConvert);

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000956 RID: 2390 RVA: 0x0002949F File Offset: 0x0002769F
		// (set) Token: 0x06000957 RID: 2391 RVA: 0x000294A7 File Offset: 0x000276A7
		internal ConverterStrategy ConverterStrategy
		{
			get
			{
				return this._converterStrategy;
			}
			set
			{
				this.CanUseDirectReadOrWrite = (value == ConverterStrategy.Value && this.IsInternalConverter);
				this.RequiresReadAhead = (value == ConverterStrategy.Value);
				this._converterStrategy = value;
			}
		}

		// Token: 0x06000958 RID: 2392
		private protected abstract ConverterStrategy GetDefaultConverterStrategy();

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000959 RID: 2393 RVA: 0x000249D0 File Offset: 0x00022BD0
		internal virtual bool SupportsCreateObjectDelegate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x0600095A RID: 2394 RVA: 0x000249D0 File Offset: 0x00022BD0
		internal virtual bool CanPopulate
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x0600095B RID: 2395 RVA: 0x000294CD File Offset: 0x000276CD
		// (set) Token: 0x0600095C RID: 2396 RVA: 0x000294D5 File Offset: 0x000276D5
		internal bool CanUseDirectReadOrWrite { get; set; }

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600095D RID: 2397 RVA: 0x000249D0 File Offset: 0x00022BD0
		internal virtual bool CanHaveMetadata
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600095E RID: 2398 RVA: 0x000294DE File Offset: 0x000276DE
		// (set) Token: 0x0600095F RID: 2399 RVA: 0x000294E6 File Offset: 0x000276E6
		internal bool CanBePolymorphic { get; set; }

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x06000960 RID: 2400 RVA: 0x000294EF File Offset: 0x000276EF
		// (set) Token: 0x06000961 RID: 2401 RVA: 0x000294F7 File Offset: 0x000276F7
		protected internal bool RequiresReadAhead { internal get; private protected set; }

		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000962 RID: 2402 RVA: 0x00029500 File Offset: 0x00027700
		// (set) Token: 0x06000963 RID: 2403 RVA: 0x00029508 File Offset: 0x00027708
		internal bool IsRootLevelMultiContentStreamingConverter { get; set; }

		// Token: 0x06000964 RID: 2404 RVA: 0x000235D5 File Offset: 0x000217D5
		internal virtual void ReadElementAndSetProperty(object obj, string propertyName, ref Utf8JsonReader reader, JsonSerializerOptions options, [ScopedRef] ref ReadStack state)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000965 RID: 2405 RVA: 0x000235D5 File Offset: 0x000217D5
		internal virtual JsonTypeInfo CreateJsonTypeInfo(JsonSerializerOptions options)
		{
			throw new InvalidOperationException();
		}

		// Token: 0x06000966 RID: 2406 RVA: 0x00029514 File Offset: 0x00027714
		internal JsonConverter<TTarget> CreateCastingConverter<TTarget>()
		{
			JsonConverter<TTarget> jsonConverter = this as JsonConverter<TTarget>;
			if (jsonConverter != null)
			{
				return jsonConverter;
			}
			JsonSerializerOptions.CheckConverterNullabilityIsSameAsPropertyType(this, typeof(TTarget));
			JsonConverter sourceConverterForCastingConverter = this.SourceConverterForCastingConverter;
			return ((sourceConverterForCastingConverter != null) ? sourceConverterForCastingConverter.CreateCastingConverter<TTarget>() : null) ?? new CastingConverter<TTarget>(this);
		}

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000967 RID: 2407 RVA: 0x00029559 File Offset: 0x00027759
		// (set) Token: 0x06000968 RID: 2408 RVA: 0x00029561 File Offset: 0x00027761
		protected internal bool UsesDefaultHandleNull { internal get; private protected set; }

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000969 RID: 2409 RVA: 0x0002956A File Offset: 0x0002776A
		// (set) Token: 0x0600096A RID: 2410 RVA: 0x00029572 File Offset: 0x00027772
		protected internal bool HandleNullOnRead { internal get; private protected set; }

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x0600096B RID: 2411 RVA: 0x0002957B File Offset: 0x0002777B
		// (set) Token: 0x0600096C RID: 2412 RVA: 0x00029583 File Offset: 0x00027783
		protected internal bool HandleNullOnWrite { internal get; private protected set; }

		// Token: 0x170001EF RID: 495
		// (get) Token: 0x0600096D RID: 2413 RVA: 0x00028060 File Offset: 0x00026260
		internal virtual JsonConverter SourceConverterForCastingConverter
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001F0 RID: 496
		// (get) Token: 0x0600096E RID: 2414 RVA: 0x00028060 File Offset: 0x00026260
		internal virtual Type ElementType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001F1 RID: 497
		// (get) Token: 0x0600096F RID: 2415 RVA: 0x00028060 File Offset: 0x00026260
		internal virtual Type KeyType
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001F2 RID: 498
		// (get) Token: 0x06000970 RID: 2416 RVA: 0x00028060 File Offset: 0x00026260
		internal virtual JsonConverter NullableElementConverter
		{
			get
			{
				return null;
			}
		}

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06000971 RID: 2417 RVA: 0x0002958C File Offset: 0x0002778C
		// (set) Token: 0x06000972 RID: 2418 RVA: 0x00029594 File Offset: 0x00027794
		internal bool IsValueType { get; set; }

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000973 RID: 2419 RVA: 0x0002959D File Offset: 0x0002779D
		// (set) Token: 0x06000974 RID: 2420 RVA: 0x000295A5 File Offset: 0x000277A5
		internal bool IsInternalConverter { get; set; }

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000975 RID: 2421 RVA: 0x000295AE File Offset: 0x000277AE
		// (set) Token: 0x06000976 RID: 2422 RVA: 0x000295B6 File Offset: 0x000277B6
		internal bool IsInternalConverterForNumberType { get; set; }

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000977 RID: 2423 RVA: 0x000249D0 File Offset: 0x00022BD0
		internal virtual bool IsConvertibleCollection
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x000295C0 File Offset: 0x000277C0
		internal static bool ShouldFlush(ref WriteStack state, Utf8JsonWriter writer)
		{
			PipeWriter pipeWriter = state.PipeWriter;
			return pipeWriter != null && state.FlushThreshold > 0 && pipeWriter.UnflushedBytes > (long)(state.FlushThreshold - writer.BytesPending);
		}

		// Token: 0x06000979 RID: 2425
		internal abstract object ReadAsObject(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options);

		// Token: 0x0600097A RID: 2426
		internal abstract bool OnTryReadAsObject(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, [ScopedRef] ref ReadStack state, out object value);

		// Token: 0x0600097B RID: 2427
		internal abstract bool TryReadAsObject(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options, [ScopedRef] ref ReadStack state, out object value);

		// Token: 0x0600097C RID: 2428
		internal abstract object ReadAsPropertyNameAsObject(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options);

		// Token: 0x0600097D RID: 2429
		internal abstract object ReadAsPropertyNameCoreAsObject(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options);

		// Token: 0x0600097E RID: 2430
		internal abstract object ReadNumberWithCustomHandlingAsObject(ref Utf8JsonReader reader, JsonNumberHandling handling, JsonSerializerOptions options);

		// Token: 0x0600097F RID: 2431
		internal abstract void WriteAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options);

		// Token: 0x06000980 RID: 2432
		internal abstract bool OnTryWriteAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, ref WriteStack state);

		// Token: 0x06000981 RID: 2433
		internal abstract bool TryWriteAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, ref WriteStack state);

		// Token: 0x06000982 RID: 2434
		internal abstract void WriteAsPropertyNameAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options);

		// Token: 0x06000983 RID: 2435
		internal abstract void WriteAsPropertyNameCoreAsObject(Utf8JsonWriter writer, object value, JsonSerializerOptions options, bool isWritingExtensionDataProperty);

		// Token: 0x06000984 RID: 2436
		internal abstract void WriteNumberWithCustomHandlingAsObject(Utf8JsonWriter writer, object value, JsonNumberHandling handling);

		// Token: 0x06000985 RID: 2437 RVA: 0x00028060 File Offset: 0x00026260
		internal virtual JsonSchema GetSchema(JsonNumberHandling numberHandling)
		{
			return null;
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000986 RID: 2438 RVA: 0x000295FA File Offset: 0x000277FA
		internal virtual bool ConstructorIsParameterized { get; }

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06000987 RID: 2439 RVA: 0x00029602 File Offset: 0x00027802
		// (set) Token: 0x06000988 RID: 2440 RVA: 0x0002960A File Offset: 0x0002780A
		internal ConstructorInfo ConstructorInfo { get; set; }

		// Token: 0x06000989 RID: 2441 RVA: 0x000148D8 File Offset: 0x00012AD8
		internal virtual void ConfigureJsonTypeInfo(JsonTypeInfo jsonTypeInfo, JsonSerializerOptions options)
		{
		}

		// Token: 0x0600098A RID: 2442 RVA: 0x000148D8 File Offset: 0x00012AD8
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		internal virtual void ConfigureJsonTypeInfoUsingReflection(JsonTypeInfo jsonTypeInfo, JsonSerializerOptions options)
		{
		}

		// Token: 0x0600098B RID: 2443 RVA: 0x00029614 File Offset: 0x00027814
		internal JsonConverter ResolvePolymorphicConverter(JsonTypeInfo jsonTypeInfo, ref ReadStack state)
		{
			JsonConverter jsonConverter = null;
			switch (state.Current.PolymorphicSerializationState)
			{
			case PolymorphicSerializationState.None:
			{
				JsonTypeInfo jsonTypeInfo2;
				if (jsonTypeInfo.PolymorphicTypeResolver.TryGetDerivedJsonTypeInfo(state.PolymorphicTypeDiscriminator, out jsonTypeInfo2))
				{
					jsonConverter = state.InitializePolymorphicReEntry(jsonTypeInfo2);
					if (!jsonConverter.CanHaveMetadata)
					{
						ThrowHelper.ThrowNotSupportedException_DerivedConverterDoesNotSupportMetadata(jsonTypeInfo2.Type);
					}
				}
				else
				{
					state.Current.PolymorphicSerializationState = PolymorphicSerializationState.PolymorphicReEntryNotFound;
				}
				state.PolymorphicTypeDiscriminator = null;
				break;
			}
			case PolymorphicSerializationState.PolymorphicReEntrySuspended:
				jsonConverter = state.ResumePolymorphicReEntry();
				break;
			}
			return jsonConverter;
		}

		// Token: 0x0600098C RID: 2444 RVA: 0x00029698 File Offset: 0x00027898
		internal JsonConverter ResolvePolymorphicConverter(object value, JsonTypeInfo jsonTypeInfo, JsonSerializerOptions options, ref WriteStack state)
		{
			JsonConverter jsonConverter = null;
			switch (state.Current.PolymorphicSerializationState)
			{
			case PolymorphicSerializationState.None:
			{
				Type type = value.GetType();
				if (this.CanBePolymorphic && type != this.Type)
				{
					jsonTypeInfo = state.Current.InitializePolymorphicReEntry(type, options);
					jsonConverter = jsonTypeInfo.Converter;
				}
				PolymorphicTypeResolver polymorphicTypeResolver = jsonTypeInfo.PolymorphicTypeResolver;
				JsonTypeInfo jsonTypeInfo2;
				object obj;
				if (polymorphicTypeResolver != null && polymorphicTypeResolver.TryGetDerivedJsonTypeInfo(type, out jsonTypeInfo2, out obj))
				{
					jsonConverter = state.Current.InitializePolymorphicReEntry(jsonTypeInfo2);
					if (obj != null)
					{
						if (!jsonConverter.CanHaveMetadata)
						{
							ThrowHelper.ThrowNotSupportedException_DerivedConverterDoesNotSupportMetadata(jsonTypeInfo2.Type);
						}
						state.PolymorphicTypeDiscriminator = obj;
						state.PolymorphicTypeResolver = polymorphicTypeResolver;
					}
				}
				if (jsonConverter == null)
				{
					state.Current.PolymorphicSerializationState = PolymorphicSerializationState.PolymorphicReEntryNotFound;
				}
				break;
			}
			case PolymorphicSerializationState.PolymorphicReEntrySuspended:
				jsonConverter = state.Current.ResumePolymorphicReEntry();
				break;
			}
			return jsonConverter;
		}

		// Token: 0x0600098D RID: 2445 RVA: 0x00029774 File Offset: 0x00027974
		internal bool TryHandleSerializedObjectReference(Utf8JsonWriter writer, object value, JsonSerializerOptions options, JsonConverter polymorphicConverter, ref WriteStack state)
		{
			ReferenceHandlingStrategy referenceHandlingStrategy = options.ReferenceHandlingStrategy;
			if (referenceHandlingStrategy != ReferenceHandlingStrategy.Preserve)
			{
				if (referenceHandlingStrategy == ReferenceHandlingStrategy.IgnoreCycles)
				{
					ReferenceResolver referenceResolver = state.ReferenceResolver;
					if (referenceResolver.ContainsReferenceForCycleDetection(value))
					{
						writer.WriteNullValue();
						return true;
					}
					referenceResolver.PushReferenceForCycleDetection(value);
					state.Current.IsPushedReferenceForCycleDetection = (state.CurrentDepth > 0);
				}
			}
			else if (((polymorphicConverter != null) ? polymorphicConverter.CanHaveMetadata : this.CanHaveMetadata) && JsonSerializer.TryGetReferenceForValue(value, ref state, writer))
			{
				return true;
			}
			return false;
		}

		// Token: 0x040002A1 RID: 673
		private ConverterStrategy _converterStrategy;
	}
}
