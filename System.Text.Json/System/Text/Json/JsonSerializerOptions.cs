using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Text.Encodings.Web;
using System.Text.Json.Nodes;
using System.Text.Json.Reflection;
using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Converters;
using System.Text.Json.Serialization.Metadata;
using System.Threading;

namespace System.Text.Json
{
	// Token: 0x02000043 RID: 67
	[NullableContext(1)]
	[Nullable(0)]
	[DebuggerDisplay("{DebuggerDisplay,nq}")]
	public sealed class JsonSerializerOptions
	{
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060004AA RID: 1194 RVA: 0x00014D01 File Offset: 0x00012F01
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal JsonSerializerOptions.CachingContext CacheContext
		{
			get
			{
				return this._cachingContext ?? this.<get_CacheContext>g__GetOrCreate|1_0();
			}
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x00014D13 File Offset: 0x00012F13
		public JsonTypeInfo GetTypeInfo(Type type)
		{
			if (type == null)
			{
				ThrowHelper.ThrowArgumentNullException("type");
			}
			if (JsonTypeInfo.IsInvalidForSerialization(type))
			{
				ThrowHelper.ThrowArgumentException_CannotSerializeInvalidType("type", type, null, null);
			}
			return this.GetTypeInfoInternal(type, true, new bool?(true), true, false);
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x00014D48 File Offset: 0x00012F48
		public bool TryGetTypeInfo(Type type, [Nullable(2)] [NotNullWhen(true)] out JsonTypeInfo typeInfo)
		{
			if (type == null)
			{
				ThrowHelper.ThrowArgumentNullException("type");
			}
			if (JsonTypeInfo.IsInvalidForSerialization(type))
			{
				ThrowHelper.ThrowArgumentException_CannotSerializeInvalidType("type", type, null, null);
			}
			typeInfo = this.GetTypeInfoInternal(type, true, null, true, false);
			return typeInfo != null;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x00014D94 File Offset: 0x00012F94
		[return: NotNullIfNotNull("ensureNotNull")]
		internal JsonTypeInfo GetTypeInfoInternal(Type type, bool ensureConfigured = true, bool? ensureNotNull = true, bool resolveIfMutable = false, bool fallBackToNearestAncestorType = false)
		{
			JsonTypeInfo jsonTypeInfo = null;
			if (this.IsReadOnly)
			{
				jsonTypeInfo = this.CacheContext.GetOrAddTypeInfo(type, fallBackToNearestAncestorType);
				if (ensureConfigured && jsonTypeInfo != null)
				{
					jsonTypeInfo.EnsureConfigured();
				}
			}
			else if (resolveIfMutable)
			{
				jsonTypeInfo = this.GetTypeInfoNoCaching(type);
			}
			if (jsonTypeInfo == null && ensureNotNull.GetValueOrDefault())
			{
				ThrowHelper.ThrowNotSupportedException_NoMetadataForType(type, this.TypeInfoResolver);
			}
			return jsonTypeInfo;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x00014DED File Offset: 0x00012FED
		internal bool TryGetTypeInfoCached(Type type, [NotNullWhen(true)] out JsonTypeInfo typeInfo)
		{
			if (this._cachingContext == null)
			{
				typeInfo = null;
				return false;
			}
			return this._cachingContext.TryGetTypeInfo(type, out typeInfo);
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x00014E0C File Offset: 0x0001300C
		internal JsonTypeInfo GetTypeInfoForRootType(Type type, bool fallBackToNearestAncestorType = false)
		{
			JsonTypeInfo jsonTypeInfo = this._lastTypeInfo;
			if (((jsonTypeInfo != null) ? jsonTypeInfo.Type : null) != type)
			{
				jsonTypeInfo = (this._lastTypeInfo = this.GetTypeInfoInternal(type, true, new bool?(true), false, fallBackToNearestAncestorType));
			}
			return jsonTypeInfo;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x00014E54 File Offset: 0x00013054
		internal bool TryGetPolymorphicTypeInfoForRootType(object rootValue, [NotNullWhen(true)] out JsonTypeInfo polymorphicTypeInfo)
		{
			Type type = rootValue.GetType();
			if (type != JsonTypeInfo.ObjectType)
			{
				polymorphicTypeInfo = this.GetTypeInfoForRootType(type, true);
				JsonTypeInfo ancestorPolymorphicType = polymorphicTypeInfo.AncestorPolymorphicType;
				if (ancestorPolymorphicType != null)
				{
					polymorphicTypeInfo = ancestorPolymorphicType;
				}
				return true;
			}
			polymorphicTypeInfo = null;
			return false;
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060004B1 RID: 1201 RVA: 0x00014E94 File Offset: 0x00013094
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal JsonTypeInfo ObjectTypeInfo
		{
			get
			{
				JsonTypeInfo result;
				if ((result = this._objectTypeInfo) == null)
				{
					result = (this._objectTypeInfo = this.GetTypeInfoInternal(JsonTypeInfo.ObjectType, true, new bool?(true), false, false));
				}
				return result;
			}
		}

		// Token: 0x060004B2 RID: 1202 RVA: 0x00014EC8 File Offset: 0x000130C8
		internal void ClearCaches()
		{
			JsonSerializerOptions.CachingContext cachingContext = this._cachingContext;
			if (cachingContext != null)
			{
				cachingContext.Clear();
			}
			this._lastTypeInfo = null;
			this._objectTypeInfo = null;
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060004B3 RID: 1203 RVA: 0x00014EEC File Offset: 0x000130EC
		public IList<JsonConverter> Converters
		{
			get
			{
				JsonSerializerOptions.ConverterList result;
				if ((result = this._converters) == null)
				{
					result = (this._converters = new JsonSerializerOptions.ConverterList(this, null));
				}
				return result;
			}
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x00014F13 File Offset: 0x00013113
		[RequiresUnreferencedCode("Getting a converter for a type may require reflection which depends on unreferenced code.")]
		[RequiresDynamicCode("Getting a converter for a type may require reflection which depends on runtime code generation.")]
		public JsonConverter GetConverter(Type typeToConvert)
		{
			if (typeToConvert == null)
			{
				ThrowHelper.ThrowArgumentNullException("typeToConvert");
			}
			if (JsonSerializer.IsReflectionEnabledByDefault && this._typeInfoResolver == null)
			{
				return DefaultJsonTypeInfoResolver.GetConverterForType(typeToConvert, this, true);
			}
			return this.GetConverterInternal(typeToConvert);
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x00014F41 File Offset: 0x00013141
		internal JsonConverter GetConverterInternal(Type typeToConvert)
		{
			return this.GetTypeInfoInternal(typeToConvert, false, new bool?(true), true, false).Converter;
		}

		// Token: 0x060004B6 RID: 1206 RVA: 0x00014F58 File Offset: 0x00013158
		internal JsonConverter GetConverterFromList(Type typeToConvert)
		{
			JsonSerializerOptions.ConverterList converters = this._converters;
			if (converters != null)
			{
				foreach (JsonConverter jsonConverter in converters)
				{
					if (jsonConverter.CanConvert(typeToConvert))
					{
						return jsonConverter;
					}
				}
			}
			return null;
		}

		// Token: 0x060004B7 RID: 1207 RVA: 0x00014FBC File Offset: 0x000131BC
		[return: NotNullIfNotNull("converter")]
		internal JsonConverter ExpandConverterFactory(JsonConverter converter, Type typeToConvert)
		{
			JsonConverterFactory jsonConverterFactory = converter as JsonConverterFactory;
			if (jsonConverterFactory != null)
			{
				converter = jsonConverterFactory.GetConverterInternal(typeToConvert, this);
			}
			return converter;
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x00014FDE File Offset: 0x000131DE
		internal static void CheckConverterNullabilityIsSameAsPropertyType(JsonConverter converter, Type propertyType)
		{
			if (propertyType.IsValueType && converter.IsValueType && (propertyType.IsNullableOfT() ^ converter.Type.IsNullableOfT()))
			{
				ThrowHelper.ThrowInvalidOperationException_ConverterCanConvertMultipleTypes(propertyType, converter);
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060004B9 RID: 1209 RVA: 0x0001500B File Offset: 0x0001320B
		public static JsonSerializerOptions Default
		{
			[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
			[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
			get
			{
				return JsonSerializerOptions.s_defaultOptions ?? JsonSerializerOptions.GetOrCreateSingleton(ref JsonSerializerOptions.s_defaultOptions, JsonSerializerDefaults.General);
			}
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x060004BA RID: 1210 RVA: 0x00015021 File Offset: 0x00013221
		public static JsonSerializerOptions Web
		{
			[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
			[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
			get
			{
				return JsonSerializerOptions.s_webOptions ?? JsonSerializerOptions.GetOrCreateSingleton(ref JsonSerializerOptions.s_webOptions, JsonSerializerDefaults.Web);
			}
		}

		// Token: 0x060004BB RID: 1211 RVA: 0x00015038 File Offset: 0x00013238
		public JsonSerializerOptions()
		{
			JsonSerializerOptions.TrackOptionsInstance(this);
		}

		// Token: 0x060004BC RID: 1212 RVA: 0x0001508C File Offset: 0x0001328C
		public JsonSerializerOptions(JsonSerializerOptions options)
		{
			if (options == null)
			{
				ThrowHelper.ThrowArgumentNullException("options");
			}
			this._dictionaryKeyPolicy = options._dictionaryKeyPolicy;
			this._jsonPropertyNamingPolicy = options._jsonPropertyNamingPolicy;
			this._readCommentHandling = options._readCommentHandling;
			this._referenceHandler = options._referenceHandler;
			JsonSerializerOptions.ConverterList converters = options._converters;
			this._converters = ((converters != null) ? new JsonSerializerOptions.ConverterList(this, converters) : null);
			this._encoder = options._encoder;
			this._defaultIgnoreCondition = options._defaultIgnoreCondition;
			this._numberHandling = options._numberHandling;
			this._preferredObjectCreationHandling = options._preferredObjectCreationHandling;
			this._unknownTypeHandling = options._unknownTypeHandling;
			this._unmappedMemberHandling = options._unmappedMemberHandling;
			this._defaultBufferSize = options._defaultBufferSize;
			this._maxDepth = options._maxDepth;
			this._allowOutOfOrderMetadataProperties = options._allowOutOfOrderMetadataProperties;
			this._allowTrailingCommas = options._allowTrailingCommas;
			this._respectNullableAnnotations = options._respectNullableAnnotations;
			this._respectRequiredConstructorParameters = options._respectRequiredConstructorParameters;
			this._ignoreNullValues = options._ignoreNullValues;
			this._ignoreReadOnlyProperties = options._ignoreReadOnlyProperties;
			this._ignoreReadonlyFields = options._ignoreReadonlyFields;
			this._includeFields = options._includeFields;
			this._newLine = options._newLine;
			this._propertyNameCaseInsensitive = options._propertyNameCaseInsensitive;
			this._writeIndented = options._writeIndented;
			this._indentCharacter = options._indentCharacter;
			this._indentSize = options._indentSize;
			this._typeInfoResolver = options._typeInfoResolver;
			this.EffectiveMaxDepth = options.EffectiveMaxDepth;
			this.ReferenceHandlingStrategy = options.ReferenceHandlingStrategy;
			JsonSerializerOptions.TrackOptionsInstance(this);
		}

		// Token: 0x060004BD RID: 1213 RVA: 0x00015254 File Offset: 0x00013454
		public JsonSerializerOptions(JsonSerializerDefaults defaults) : this()
		{
			if (defaults == JsonSerializerDefaults.Web)
			{
				this._propertyNameCaseInsensitive = true;
				this._jsonPropertyNamingPolicy = JsonNamingPolicy.CamelCase;
				this._numberHandling = JsonNumberHandling.AllowReadingFromString;
				return;
			}
			if (defaults != JsonSerializerDefaults.General)
			{
				throw new ArgumentOutOfRangeException("defaults");
			}
		}

		// Token: 0x060004BE RID: 1214 RVA: 0x00015288 File Offset: 0x00013488
		private static void TrackOptionsInstance(JsonSerializerOptions options)
		{
			JsonSerializerOptions.TrackedOptionsInstances.All.Add(options, null);
		}

		// Token: 0x060004BF RID: 1215 RVA: 0x00015296 File Offset: 0x00013496
		[NullableContext(0)]
		[Obsolete("JsonSerializerOptions.AddContext is obsolete. To register a JsonSerializerContext, use either the TypeInfoResolver or TypeInfoResolverChain properties.", DiagnosticId = "SYSLIB0049", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public void AddContext<TContext>() where TContext : JsonSerializerContext, new()
		{
			this.VerifyMutable();
			Activator.CreateInstance<TContext>().AssociateWithOptions(this);
		}

		// Token: 0x1700012E RID: 302
		// (get) Token: 0x060004C0 RID: 1216 RVA: 0x000152AE File Offset: 0x000134AE
		// (set) Token: 0x060004C1 RID: 1217 RVA: 0x000152B8 File Offset: 0x000134B8
		[Nullable(2)]
		public IJsonTypeInfoResolver TypeInfoResolver
		{
			[NullableContext(2)]
			get
			{
				return this._typeInfoResolver;
			}
			[NullableContext(2)]
			set
			{
				this.VerifyMutable();
				JsonSerializerOptions.OptionsBoundJsonTypeInfoResolverChain typeInfoResolverChain = this._typeInfoResolverChain;
				if (typeInfoResolverChain != null && typeInfoResolverChain != value)
				{
					typeInfoResolverChain.Clear();
					typeInfoResolverChain.AddFlattened(value);
				}
				this._typeInfoResolver = value;
			}
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060004C2 RID: 1218 RVA: 0x000152F0 File Offset: 0x000134F0
		public IList<IJsonTypeInfoResolver> TypeInfoResolverChain
		{
			get
			{
				JsonSerializerOptions.OptionsBoundJsonTypeInfoResolverChain result;
				if ((result = this._typeInfoResolverChain) == null)
				{
					result = (this._typeInfoResolverChain = new JsonSerializerOptions.OptionsBoundJsonTypeInfoResolverChain(this));
				}
				return result;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060004C3 RID: 1219 RVA: 0x00015316 File Offset: 0x00013516
		// (set) Token: 0x060004C4 RID: 1220 RVA: 0x0001531E File Offset: 0x0001351E
		public bool AllowOutOfOrderMetadataProperties
		{
			get
			{
				return this._allowOutOfOrderMetadataProperties;
			}
			set
			{
				this.VerifyMutable();
				this._allowOutOfOrderMetadataProperties = value;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060004C5 RID: 1221 RVA: 0x0001532D File Offset: 0x0001352D
		// (set) Token: 0x060004C6 RID: 1222 RVA: 0x00015335 File Offset: 0x00013535
		public bool AllowTrailingCommas
		{
			get
			{
				return this._allowTrailingCommas;
			}
			set
			{
				this.VerifyMutable();
				this._allowTrailingCommas = value;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060004C7 RID: 1223 RVA: 0x00015344 File Offset: 0x00013544
		// (set) Token: 0x060004C8 RID: 1224 RVA: 0x0001534C File Offset: 0x0001354C
		public int DefaultBufferSize
		{
			get
			{
				return this._defaultBufferSize;
			}
			set
			{
				this.VerifyMutable();
				if (value < 1)
				{
					throw new ArgumentException(SR.SerializationInvalidBufferSize);
				}
				this._defaultBufferSize = value;
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060004C9 RID: 1225 RVA: 0x0001536A File Offset: 0x0001356A
		// (set) Token: 0x060004CA RID: 1226 RVA: 0x00015372 File Offset: 0x00013572
		[Nullable(2)]
		public JavaScriptEncoder Encoder
		{
			[NullableContext(2)]
			get
			{
				return this._encoder;
			}
			[NullableContext(2)]
			set
			{
				this.VerifyMutable();
				this._encoder = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060004CB RID: 1227 RVA: 0x00015381 File Offset: 0x00013581
		// (set) Token: 0x060004CC RID: 1228 RVA: 0x00015389 File Offset: 0x00013589
		[Nullable(2)]
		public JsonNamingPolicy DictionaryKeyPolicy
		{
			[NullableContext(2)]
			get
			{
				return this._dictionaryKeyPolicy;
			}
			[NullableContext(2)]
			set
			{
				this.VerifyMutable();
				this._dictionaryKeyPolicy = value;
			}
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060004CD RID: 1229 RVA: 0x00015398 File Offset: 0x00013598
		// (set) Token: 0x060004CE RID: 1230 RVA: 0x000153A0 File Offset: 0x000135A0
		[Obsolete("JsonSerializerOptions.IgnoreNullValues is obsolete. To ignore null values when serializing, set DefaultIgnoreCondition to JsonIgnoreCondition.WhenWritingNull.", DiagnosticId = "SYSLIB0020", UrlFormat = "https://aka.ms/dotnet-warnings/{0}")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public bool IgnoreNullValues
		{
			get
			{
				return this._ignoreNullValues;
			}
			set
			{
				this.VerifyMutable();
				if (value && this._defaultIgnoreCondition != JsonIgnoreCondition.Never)
				{
					throw new InvalidOperationException(SR.DefaultIgnoreConditionAlreadySpecified);
				}
				this._ignoreNullValues = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060004CF RID: 1231 RVA: 0x000153C5 File Offset: 0x000135C5
		// (set) Token: 0x060004D0 RID: 1232 RVA: 0x000153CD File Offset: 0x000135CD
		public JsonIgnoreCondition DefaultIgnoreCondition
		{
			get
			{
				return this._defaultIgnoreCondition;
			}
			set
			{
				this.VerifyMutable();
				if (value == JsonIgnoreCondition.Always)
				{
					throw new ArgumentException(SR.DefaultIgnoreConditionInvalid);
				}
				if (value != JsonIgnoreCondition.Never && this._ignoreNullValues)
				{
					throw new InvalidOperationException(SR.DefaultIgnoreConditionAlreadySpecified);
				}
				this._defaultIgnoreCondition = value;
			}
		}

		// Token: 0x17000137 RID: 311
		// (get) Token: 0x060004D1 RID: 1233 RVA: 0x00015401 File Offset: 0x00013601
		// (set) Token: 0x060004D2 RID: 1234 RVA: 0x00015409 File Offset: 0x00013609
		public JsonNumberHandling NumberHandling
		{
			get
			{
				return this._numberHandling;
			}
			set
			{
				this.VerifyMutable();
				if (!JsonSerializer.IsValidNumberHandlingValue(value))
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._numberHandling = value;
			}
		}

		// Token: 0x17000138 RID: 312
		// (get) Token: 0x060004D3 RID: 1235 RVA: 0x0001542B File Offset: 0x0001362B
		// (set) Token: 0x060004D4 RID: 1236 RVA: 0x00015433 File Offset: 0x00013633
		public JsonObjectCreationHandling PreferredObjectCreationHandling
		{
			get
			{
				return this._preferredObjectCreationHandling;
			}
			set
			{
				this.VerifyMutable();
				if (!JsonSerializer.IsValidCreationHandlingValue(value))
				{
					throw new ArgumentOutOfRangeException("value");
				}
				this._preferredObjectCreationHandling = value;
			}
		}

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x060004D5 RID: 1237 RVA: 0x00015455 File Offset: 0x00013655
		// (set) Token: 0x060004D6 RID: 1238 RVA: 0x0001545D File Offset: 0x0001365D
		public bool IgnoreReadOnlyProperties
		{
			get
			{
				return this._ignoreReadOnlyProperties;
			}
			set
			{
				this.VerifyMutable();
				this._ignoreReadOnlyProperties = value;
			}
		}

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x060004D7 RID: 1239 RVA: 0x0001546C File Offset: 0x0001366C
		// (set) Token: 0x060004D8 RID: 1240 RVA: 0x00015474 File Offset: 0x00013674
		public bool IgnoreReadOnlyFields
		{
			get
			{
				return this._ignoreReadonlyFields;
			}
			set
			{
				this.VerifyMutable();
				this._ignoreReadonlyFields = value;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x060004D9 RID: 1241 RVA: 0x00015483 File Offset: 0x00013683
		// (set) Token: 0x060004DA RID: 1242 RVA: 0x0001548B File Offset: 0x0001368B
		public bool IncludeFields
		{
			get
			{
				return this._includeFields;
			}
			set
			{
				this.VerifyMutable();
				this._includeFields = value;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x060004DB RID: 1243 RVA: 0x0001549A File Offset: 0x0001369A
		// (set) Token: 0x060004DC RID: 1244 RVA: 0x000154A2 File Offset: 0x000136A2
		public int MaxDepth
		{
			get
			{
				return this._maxDepth;
			}
			set
			{
				this.VerifyMutable();
				if (value < 0)
				{
					ThrowHelper.ThrowArgumentOutOfRangeException_MaxDepthMustBePositive("value");
				}
				this._maxDepth = value;
				this.EffectiveMaxDepth = ((value == 0) ? 64 : value);
			}
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060004DD RID: 1245 RVA: 0x000154CD File Offset: 0x000136CD
		// (set) Token: 0x060004DE RID: 1246 RVA: 0x000154D5 File Offset: 0x000136D5
		internal int EffectiveMaxDepth { get; private set; } = 64;

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060004DF RID: 1247 RVA: 0x000154DE File Offset: 0x000136DE
		// (set) Token: 0x060004E0 RID: 1248 RVA: 0x000154E6 File Offset: 0x000136E6
		[Nullable(2)]
		public JsonNamingPolicy PropertyNamingPolicy
		{
			[NullableContext(2)]
			get
			{
				return this._jsonPropertyNamingPolicy;
			}
			[NullableContext(2)]
			set
			{
				this.VerifyMutable();
				this._jsonPropertyNamingPolicy = value;
			}
		}

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060004E1 RID: 1249 RVA: 0x000154F5 File Offset: 0x000136F5
		// (set) Token: 0x060004E2 RID: 1250 RVA: 0x000154FD File Offset: 0x000136FD
		public bool PropertyNameCaseInsensitive
		{
			get
			{
				return this._propertyNameCaseInsensitive;
			}
			set
			{
				this.VerifyMutable();
				this._propertyNameCaseInsensitive = value;
			}
		}

		// Token: 0x17000140 RID: 320
		// (get) Token: 0x060004E3 RID: 1251 RVA: 0x0001550C File Offset: 0x0001370C
		// (set) Token: 0x060004E4 RID: 1252 RVA: 0x00015514 File Offset: 0x00013714
		public JsonCommentHandling ReadCommentHandling
		{
			get
			{
				return this._readCommentHandling;
			}
			set
			{
				this.VerifyMutable();
				if (value > JsonCommentHandling.Skip)
				{
					throw new ArgumentOutOfRangeException("value", SR.JsonSerializerDoesNotSupportComments);
				}
				this._readCommentHandling = value;
			}
		}

		// Token: 0x17000141 RID: 321
		// (get) Token: 0x060004E5 RID: 1253 RVA: 0x00015537 File Offset: 0x00013737
		// (set) Token: 0x060004E6 RID: 1254 RVA: 0x0001553F File Offset: 0x0001373F
		public JsonUnknownTypeHandling UnknownTypeHandling
		{
			get
			{
				return this._unknownTypeHandling;
			}
			set
			{
				this.VerifyMutable();
				this._unknownTypeHandling = value;
			}
		}

		// Token: 0x17000142 RID: 322
		// (get) Token: 0x060004E7 RID: 1255 RVA: 0x0001554E File Offset: 0x0001374E
		// (set) Token: 0x060004E8 RID: 1256 RVA: 0x00015556 File Offset: 0x00013756
		public JsonUnmappedMemberHandling UnmappedMemberHandling
		{
			get
			{
				return this._unmappedMemberHandling;
			}
			set
			{
				this.VerifyMutable();
				this._unmappedMemberHandling = value;
			}
		}

		// Token: 0x17000143 RID: 323
		// (get) Token: 0x060004E9 RID: 1257 RVA: 0x00015565 File Offset: 0x00013765
		// (set) Token: 0x060004EA RID: 1258 RVA: 0x0001556D File Offset: 0x0001376D
		public bool WriteIndented
		{
			get
			{
				return this._writeIndented;
			}
			set
			{
				this.VerifyMutable();
				this._writeIndented = value;
			}
		}

		// Token: 0x17000144 RID: 324
		// (get) Token: 0x060004EB RID: 1259 RVA: 0x0001557C File Offset: 0x0001377C
		// (set) Token: 0x060004EC RID: 1260 RVA: 0x00015584 File Offset: 0x00013784
		public char IndentCharacter
		{
			get
			{
				return this._indentCharacter;
			}
			set
			{
				JsonWriterHelper.ValidateIndentCharacter(value);
				this.VerifyMutable();
				this._indentCharacter = value;
			}
		}

		// Token: 0x17000145 RID: 325
		// (get) Token: 0x060004ED RID: 1261 RVA: 0x00015599 File Offset: 0x00013799
		// (set) Token: 0x060004EE RID: 1262 RVA: 0x000155A1 File Offset: 0x000137A1
		public int IndentSize
		{
			get
			{
				return this._indentSize;
			}
			set
			{
				JsonWriterHelper.ValidateIndentSize(value);
				this.VerifyMutable();
				this._indentSize = value;
			}
		}

		// Token: 0x17000146 RID: 326
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x000155B6 File Offset: 0x000137B6
		// (set) Token: 0x060004F0 RID: 1264 RVA: 0x000155BE File Offset: 0x000137BE
		[Nullable(2)]
		public ReferenceHandler ReferenceHandler
		{
			[NullableContext(2)]
			get
			{
				return this._referenceHandler;
			}
			[NullableContext(2)]
			set
			{
				this.VerifyMutable();
				this._referenceHandler = value;
				this.ReferenceHandlingStrategy = ((value != null) ? value.HandlingStrategy : ReferenceHandlingStrategy.None);
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x000155E0 File Offset: 0x000137E0
		// (set) Token: 0x060004F2 RID: 1266 RVA: 0x00015605 File Offset: 0x00013805
		public string NewLine
		{
			get
			{
				string result;
				if ((result = this._newLine) == null)
				{
					result = (this._newLine = Environment.NewLine);
				}
				return result;
			}
			set
			{
				JsonWriterHelper.ValidateNewLine(value);
				this.VerifyMutable();
				this._newLine = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060004F3 RID: 1267 RVA: 0x0001561A File Offset: 0x0001381A
		// (set) Token: 0x060004F4 RID: 1268 RVA: 0x00015622 File Offset: 0x00013822
		public bool RespectNullableAnnotations
		{
			get
			{
				return this._respectNullableAnnotations;
			}
			set
			{
				this.VerifyMutable();
				this._respectNullableAnnotations = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060004F5 RID: 1269 RVA: 0x00015631 File Offset: 0x00013831
		// (set) Token: 0x060004F6 RID: 1270 RVA: 0x00015639 File Offset: 0x00013839
		public bool RespectRequiredConstructorParameters
		{
			get
			{
				return this._respectRequiredConstructorParameters;
			}
			set
			{
				this.VerifyMutable();
				this._respectRequiredConstructorParameters = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060004F7 RID: 1271 RVA: 0x00015648 File Offset: 0x00013848
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		internal bool CanUseFastPathSerializationLogic
		{
			get
			{
				bool flag = this._canUseFastPathSerializationLogic.GetValueOrDefault();
				if (this._canUseFastPathSerializationLogic == null)
				{
					flag = this.TypeInfoResolver.IsCompatibleWithOptions(this);
					this._canUseFastPathSerializationLogic = new bool?(flag);
					return flag;
				}
				return flag;
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060004F8 RID: 1272 RVA: 0x0001568A File Offset: 0x0001388A
		public bool IsReadOnly
		{
			get
			{
				return this._isReadOnly;
			}
		}

		// Token: 0x060004F9 RID: 1273 RVA: 0x00015694 File Offset: 0x00013894
		public void MakeReadOnly()
		{
			if (this._typeInfoResolver == null)
			{
				ThrowHelper.ThrowInvalidOperationException_JsonSerializerOptionsNoTypeInfoResolverSpecified();
			}
			this._isReadOnly = true;
		}

		// Token: 0x060004FA RID: 1274 RVA: 0x000156AC File Offset: 0x000138AC
		[RequiresUnreferencedCode("Populating unconfigured TypeInfoResolver properties with the reflection resolver requires unreferenced code.")]
		[RequiresDynamicCode("Populating unconfigured TypeInfoResolver properties with the reflection resolver requires runtime code generation.")]
		public void MakeReadOnly(bool populateMissingResolver)
		{
			if (populateMissingResolver)
			{
				if (!this._isConfiguredForJsonSerializer)
				{
					this.ConfigureForJsonSerializer();
					return;
				}
			}
			else
			{
				this.MakeReadOnly();
			}
		}

		// Token: 0x060004FB RID: 1275 RVA: 0x000156C8 File Offset: 0x000138C8
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		private unsafe void ConfigureForJsonSerializer()
		{
			if (JsonSerializer.IsReflectionEnabledByDefault)
			{
				DefaultJsonTypeInfoResolver defaultInstance = DefaultJsonTypeInfoResolver.DefaultInstance;
				IJsonTypeInfoResolver typeInfoResolver = this._typeInfoResolver;
				if (typeInfoResolver != null)
				{
					JsonSerializerContext jsonSerializerContext = typeInfoResolver as JsonSerializerContext;
					if (jsonSerializerContext != null)
					{
						if (AppContextSwitchHelper.IsSourceGenReflectionFallbackEnabled)
						{
							<>y__InlineArray2<IJsonTypeInfoResolver> <>y__InlineArray = default(<>y__InlineArray2<IJsonTypeInfoResolver>);
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<IJsonTypeInfoResolver>, IJsonTypeInfoResolver>(ref <>y__InlineArray, 0) = jsonSerializerContext;
							*<PrivateImplementationDetails>.InlineArrayElementRef<<>y__InlineArray2<IJsonTypeInfoResolver>, IJsonTypeInfoResolver>(ref <>y__InlineArray, 1) = defaultInstance;
							this._effectiveJsonTypeInfoResolver = JsonTypeInfoResolver.Combine(<PrivateImplementationDetails>.InlineArrayAsReadOnlySpan<<>y__InlineArray2<IJsonTypeInfoResolver>, IJsonTypeInfoResolver>(<>y__InlineArray, 2));
							JsonSerializerOptions.CachingContext cachingContext = this._cachingContext;
							if (cachingContext != null)
							{
								if (cachingContext.Options != this && !cachingContext.Options._isConfiguredForJsonSerializer)
								{
									cachingContext.Options.ConfigureForJsonSerializer();
								}
								else
								{
									cachingContext.Clear();
								}
							}
						}
					}
				}
				else
				{
					this._typeInfoResolver = defaultInstance;
				}
			}
			else
			{
				IJsonTypeInfoResolver typeInfoResolver = this._typeInfoResolver;
				bool flag = typeInfoResolver == null || typeInfoResolver is EmptyJsonTypeInfoResolver;
				if (flag)
				{
					ThrowHelper.ThrowInvalidOperationException_JsonSerializerIsReflectionDisabled();
				}
			}
			this._isReadOnly = true;
			this._isConfiguredForJsonSerializer = true;
		}

		// Token: 0x060004FC RID: 1276 RVA: 0x000157B8 File Offset: 0x000139B8
		private JsonTypeInfo GetTypeInfoNoCaching(Type type)
		{
			IJsonTypeInfoResolver jsonTypeInfoResolver = this._effectiveJsonTypeInfoResolver ?? this._typeInfoResolver;
			if (jsonTypeInfoResolver == null)
			{
				return null;
			}
			JsonTypeInfo jsonTypeInfo = jsonTypeInfoResolver.GetTypeInfo(type, this);
			if (jsonTypeInfo != null)
			{
				if (jsonTypeInfo.Type != type)
				{
					ThrowHelper.ThrowInvalidOperationException_ResolverTypeNotCompatible(type, jsonTypeInfo.Type);
				}
				if (jsonTypeInfo.Options != this)
				{
					ThrowHelper.ThrowInvalidOperationException_ResolverTypeInfoOptionsNotCompatible();
				}
			}
			else if (type == JsonTypeInfo.ObjectType)
			{
				jsonTypeInfo = new JsonTypeInfo<object>(new SlimObjectConverter(jsonTypeInfoResolver), this);
			}
			return jsonTypeInfo;
		}

		// Token: 0x060004FD RID: 1277 RVA: 0x0001582C File Offset: 0x00013A2C
		internal JsonDocumentOptions GetDocumentOptions()
		{
			return new JsonDocumentOptions
			{
				AllowTrailingCommas = this.AllowTrailingCommas,
				CommentHandling = this.ReadCommentHandling,
				MaxDepth = this.MaxDepth
			};
		}

		// Token: 0x060004FE RID: 1278 RVA: 0x0001586C File Offset: 0x00013A6C
		internal JsonNodeOptions GetNodeOptions()
		{
			return new JsonNodeOptions
			{
				PropertyNameCaseInsensitive = this.PropertyNameCaseInsensitive
			};
		}

		// Token: 0x060004FF RID: 1279 RVA: 0x00015890 File Offset: 0x00013A90
		internal JsonReaderOptions GetReaderOptions()
		{
			return new JsonReaderOptions
			{
				AllowTrailingCommas = this.AllowTrailingCommas,
				CommentHandling = this.ReadCommentHandling,
				MaxDepth = this.EffectiveMaxDepth
			};
		}

		// Token: 0x06000500 RID: 1280 RVA: 0x000158D0 File Offset: 0x00013AD0
		internal JsonWriterOptions GetWriterOptions()
		{
			return new JsonWriterOptions
			{
				Encoder = this.Encoder,
				Indented = this.WriteIndented,
				IndentCharacter = this.IndentCharacter,
				IndentSize = this.IndentSize,
				MaxDepth = this.EffectiveMaxDepth,
				NewLine = this.NewLine,
				SkipValidation = true
			};
		}

		// Token: 0x06000501 RID: 1281 RVA: 0x0001593C File Offset: 0x00013B3C
		internal void VerifyMutable()
		{
			if (this._isReadOnly)
			{
				ThrowHelper.ThrowInvalidOperationException_SerializerOptionsReadOnly(this._typeInfoResolver as JsonSerializerContext);
			}
		}

		// Token: 0x06000502 RID: 1282 RVA: 0x00015958 File Offset: 0x00013B58
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		private static JsonSerializerOptions GetOrCreateSingleton(ref JsonSerializerOptions location, JsonSerializerDefaults defaults)
		{
			JsonSerializerOptions jsonSerializerOptions = new JsonSerializerOptions(defaults);
			IJsonTypeInfoResolver typeInfoResolver;
			if (!JsonSerializer.IsReflectionEnabledByDefault)
			{
				typeInfoResolver = JsonTypeInfoResolver.Empty;
			}
			else
			{
				IJsonTypeInfoResolver defaultInstance = DefaultJsonTypeInfoResolver.DefaultInstance;
				typeInfoResolver = defaultInstance;
			}
			jsonSerializerOptions.TypeInfoResolver = typeInfoResolver;
			jsonSerializerOptions._isReadOnly = true;
			JsonSerializerOptions jsonSerializerOptions2 = jsonSerializerOptions;
			return Interlocked.CompareExchange<JsonSerializerOptions>(ref location, jsonSerializerOptions2, null) ?? jsonSerializerOptions2;
		}

		// Token: 0x1700014C RID: 332
		// (get) Token: 0x06000503 RID: 1283 RVA: 0x000159A0 File Offset: 0x00013BA0
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		private string DebuggerDisplay
		{
			get
			{
				DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(34, 2);
				defaultInterpolatedStringHandler.AppendLiteral("TypeInfoResolver = ");
				IJsonTypeInfoResolver typeInfoResolver = this.TypeInfoResolver;
				defaultInterpolatedStringHandler.AppendFormatted(((typeInfoResolver != null) ? typeInfoResolver.ToString() : null) ?? "<null>");
				defaultInterpolatedStringHandler.AppendLiteral(", IsReadOnly = ");
				defaultInterpolatedStringHandler.AppendFormatted<bool>(this.IsReadOnly);
				return defaultInterpolatedStringHandler.ToStringAndClear();
			}
		}

		// Token: 0x06000504 RID: 1284 RVA: 0x00015A08 File Offset: 0x00013C08
		[CompilerGenerated]
		private JsonSerializerOptions.CachingContext <get_CacheContext>g__GetOrCreate|1_0()
		{
			JsonSerializerOptions.CachingContext orCreate = JsonSerializerOptions.TrackedCachingContexts.GetOrCreate(this);
			return Interlocked.CompareExchange<JsonSerializerOptions.CachingContext>(ref this._cachingContext, orCreate, null) ?? orCreate;
		}

		// Token: 0x040000FB RID: 251
		private JsonSerializerOptions.CachingContext _cachingContext;

		// Token: 0x040000FC RID: 252
		private volatile JsonTypeInfo _lastTypeInfo;

		// Token: 0x040000FD RID: 253
		private JsonTypeInfo _objectTypeInfo;

		// Token: 0x040000FE RID: 254
		private static JsonSerializerOptions s_defaultOptions;

		// Token: 0x040000FF RID: 255
		private static JsonSerializerOptions s_webOptions;

		// Token: 0x04000100 RID: 256
		private IJsonTypeInfoResolver _typeInfoResolver;

		// Token: 0x04000101 RID: 257
		private JsonNamingPolicy _dictionaryKeyPolicy;

		// Token: 0x04000102 RID: 258
		private JsonNamingPolicy _jsonPropertyNamingPolicy;

		// Token: 0x04000103 RID: 259
		private JsonCommentHandling _readCommentHandling;

		// Token: 0x04000104 RID: 260
		private ReferenceHandler _referenceHandler;

		// Token: 0x04000105 RID: 261
		private JavaScriptEncoder _encoder;

		// Token: 0x04000106 RID: 262
		private JsonSerializerOptions.ConverterList _converters;

		// Token: 0x04000107 RID: 263
		private JsonIgnoreCondition _defaultIgnoreCondition;

		// Token: 0x04000108 RID: 264
		private JsonNumberHandling _numberHandling;

		// Token: 0x04000109 RID: 265
		private JsonObjectCreationHandling _preferredObjectCreationHandling;

		// Token: 0x0400010A RID: 266
		private JsonUnknownTypeHandling _unknownTypeHandling;

		// Token: 0x0400010B RID: 267
		private JsonUnmappedMemberHandling _unmappedMemberHandling;

		// Token: 0x0400010C RID: 268
		private int _defaultBufferSize = 16384;

		// Token: 0x0400010D RID: 269
		private int _maxDepth;

		// Token: 0x0400010E RID: 270
		private bool _allowOutOfOrderMetadataProperties;

		// Token: 0x0400010F RID: 271
		private bool _allowTrailingCommas;

		// Token: 0x04000110 RID: 272
		private bool _respectNullableAnnotations = AppContextSwitchHelper.RespectNullableAnnotationsDefault;

		// Token: 0x04000111 RID: 273
		private bool _respectRequiredConstructorParameters = AppContextSwitchHelper.RespectRequiredConstructorParametersDefault;

		// Token: 0x04000112 RID: 274
		private bool _ignoreNullValues;

		// Token: 0x04000113 RID: 275
		private bool _ignoreReadOnlyProperties;

		// Token: 0x04000114 RID: 276
		private bool _ignoreReadonlyFields;

		// Token: 0x04000115 RID: 277
		private bool _includeFields;

		// Token: 0x04000116 RID: 278
		private string _newLine;

		// Token: 0x04000117 RID: 279
		private bool _propertyNameCaseInsensitive;

		// Token: 0x04000118 RID: 280
		private bool _writeIndented;

		// Token: 0x04000119 RID: 281
		private char _indentCharacter = ' ';

		// Token: 0x0400011A RID: 282
		private int _indentSize = 2;

		// Token: 0x0400011B RID: 283
		private JsonSerializerOptions.OptionsBoundJsonTypeInfoResolverChain _typeInfoResolverChain;

		// Token: 0x0400011D RID: 285
		private bool? _canUseFastPathSerializationLogic;

		// Token: 0x0400011E RID: 286
		internal ReferenceHandlingStrategy ReferenceHandlingStrategy;

		// Token: 0x0400011F RID: 287
		private volatile bool _isReadOnly;

		// Token: 0x04000120 RID: 288
		private volatile bool _isConfiguredForJsonSerializer;

		// Token: 0x04000121 RID: 289
		private IJsonTypeInfoResolver _effectiveJsonTypeInfoResolver;

		// Token: 0x02000044 RID: 68
		internal sealed class CachingContext
		{
			// Token: 0x06000505 RID: 1285 RVA: 0x00015A2E File Offset: 0x00013C2E
			public CachingContext(JsonSerializerOptions options, int hashCode)
			{
				this.Options = options;
				this.HashCode = hashCode;
			}

			// Token: 0x1700014D RID: 333
			// (get) Token: 0x06000506 RID: 1286 RVA: 0x00015A4F File Offset: 0x00013C4F
			public JsonSerializerOptions Options { get; }

			// Token: 0x1700014E RID: 334
			// (get) Token: 0x06000507 RID: 1287 RVA: 0x00015A57 File Offset: 0x00013C57
			public int HashCode { get; }

			// Token: 0x1700014F RID: 335
			// (get) Token: 0x06000508 RID: 1288 RVA: 0x00015A5F File Offset: 0x00013C5F
			public int Count
			{
				get
				{
					return this._cache.Count;
				}
			}

			// Token: 0x06000509 RID: 1289 RVA: 0x00015A6C File Offset: 0x00013C6C
			public JsonTypeInfo GetOrAddTypeInfo(Type type, bool fallBackToNearestAncestorType = false)
			{
				JsonSerializerOptions.CachingContext.CacheEntry orAddCacheEntry = this.GetOrAddCacheEntry(type);
				if (!fallBackToNearestAncestorType || orAddCacheEntry.HasResult)
				{
					return orAddCacheEntry.GetResult();
				}
				return this.FallBackToNearestAncestor(type, orAddCacheEntry);
			}

			// Token: 0x0600050A RID: 1290 RVA: 0x00015A9C File Offset: 0x00013C9C
			public bool TryGetTypeInfo(Type type, [NotNullWhen(true)] out JsonTypeInfo typeInfo)
			{
				JsonSerializerOptions.CachingContext.CacheEntry cacheEntry;
				this._cache.TryGetValue(type, out cacheEntry);
				typeInfo = ((cacheEntry != null) ? cacheEntry.TypeInfo : null);
				return typeInfo != null;
			}

			// Token: 0x0600050B RID: 1291 RVA: 0x00015ACE File Offset: 0x00013CCE
			public void Clear()
			{
				this._cache.Clear();
			}

			// Token: 0x0600050C RID: 1292 RVA: 0x00015ADB File Offset: 0x00013CDB
			private JsonSerializerOptions.CachingContext.CacheEntry GetOrAddCacheEntry(Type type)
			{
				ConcurrentDictionary<Type, JsonSerializerOptions.CachingContext.CacheEntry> cache = this._cache;
				Func<Type, JsonSerializerOptions.CachingContext, JsonSerializerOptions.CachingContext.CacheEntry> valueFactory;
				if ((valueFactory = JsonSerializerOptions.CachingContext.<>O.<0>__CreateCacheEntry) == null)
				{
					valueFactory = (JsonSerializerOptions.CachingContext.<>O.<0>__CreateCacheEntry = new Func<Type, JsonSerializerOptions.CachingContext, JsonSerializerOptions.CachingContext.CacheEntry>(JsonSerializerOptions.CachingContext.CreateCacheEntry));
				}
				return cache.GetOrAdd<JsonSerializerOptions.CachingContext>(type, valueFactory, this);
			}

			// Token: 0x0600050D RID: 1293 RVA: 0x00015B08 File Offset: 0x00013D08
			private static JsonSerializerOptions.CachingContext.CacheEntry CreateCacheEntry(Type type, JsonSerializerOptions.CachingContext context)
			{
				JsonSerializerOptions.CachingContext.CacheEntry result;
				try
				{
					result = new JsonSerializerOptions.CachingContext.CacheEntry(context.Options.GetTypeInfoNoCaching(type));
				}
				catch (Exception source)
				{
					result = new JsonSerializerOptions.CachingContext.CacheEntry(ExceptionDispatchInfo.Capture(source));
				}
				return result;
			}

			// Token: 0x0600050E RID: 1294 RVA: 0x00015B48 File Offset: 0x00013D48
			private JsonTypeInfo FallBackToNearestAncestor(Type type, JsonSerializerOptions.CachingContext.CacheEntry entry)
			{
				JsonSerializerOptions.CachingContext.CacheEntry cacheEntry = entry.IsNearestAncestorResolved ? entry.NearestAncestor : this.DetermineNearestAncestor(type, entry);
				if (cacheEntry == null)
				{
					return null;
				}
				return cacheEntry.GetResult();
			}

			// Token: 0x0600050F RID: 1295 RVA: 0x00015B70 File Offset: 0x00013D70
			[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2070:UnrecognizedReflectionPattern", Justification = "We only need to examine the interface types that are supported by the underlying resolver.")]
			private JsonSerializerOptions.CachingContext.CacheEntry DetermineNearestAncestor(Type type, JsonSerializerOptions.CachingContext.CacheEntry entry)
			{
				JsonSerializerOptions.CachingContext.CacheEntry cacheEntry = null;
				Type type2 = null;
				Type baseType = type.BaseType;
				while (baseType != null && !(baseType == JsonTypeInfo.ObjectType))
				{
					cacheEntry = this.GetOrAddCacheEntry(baseType);
					if (cacheEntry.HasResult)
					{
						type2 = baseType;
						break;
					}
					baseType = baseType.BaseType;
				}
				foreach (Type type3 in type.GetInterfaces())
				{
					JsonSerializerOptions.CachingContext.CacheEntry orAddCacheEntry = this.GetOrAddCacheEntry(type3);
					if (orAddCacheEntry.HasResult)
					{
						if (type2 != null)
						{
							if (type3.IsAssignableFrom(type2))
							{
								goto IL_9C;
							}
							if (!type2.IsAssignableFrom(type3))
							{
								cacheEntry = new JsonSerializerOptions.CachingContext.CacheEntry(ExceptionDispatchInfo.Capture(ThrowHelper.GetNotSupportedException_AmbiguousMetadataForType(type, type2, type3)));
								break;
							}
						}
						cacheEntry = orAddCacheEntry;
						type2 = type3;
					}
					IL_9C:;
				}
				entry.NearestAncestor = cacheEntry;
				entry.IsNearestAncestorResolved = true;
				return cacheEntry;
			}

			// Token: 0x04000122 RID: 290
			private readonly ConcurrentDictionary<Type, JsonSerializerOptions.CachingContext.CacheEntry> _cache = new ConcurrentDictionary<Type, JsonSerializerOptions.CachingContext.CacheEntry>();

			// Token: 0x02000045 RID: 69
			private sealed class CacheEntry
			{
				// Token: 0x06000510 RID: 1296 RVA: 0x00015C37 File Offset: 0x00013E37
				public CacheEntry(JsonTypeInfo typeInfo)
				{
					this.TypeInfo = typeInfo;
					this.HasResult = (typeInfo != null);
				}

				// Token: 0x06000511 RID: 1297 RVA: 0x00015C50 File Offset: 0x00013E50
				public CacheEntry(ExceptionDispatchInfo exception)
				{
					this.ExceptionDispatchInfo = exception;
					this.HasResult = true;
				}

				// Token: 0x06000512 RID: 1298 RVA: 0x00015C66 File Offset: 0x00013E66
				public JsonTypeInfo GetResult()
				{
					ExceptionDispatchInfo exceptionDispatchInfo = this.ExceptionDispatchInfo;
					if (exceptionDispatchInfo != null)
					{
						exceptionDispatchInfo.Throw();
					}
					return this.TypeInfo;
				}

				// Token: 0x04000125 RID: 293
				public readonly bool HasResult;

				// Token: 0x04000126 RID: 294
				public readonly JsonTypeInfo TypeInfo;

				// Token: 0x04000127 RID: 295
				public readonly ExceptionDispatchInfo ExceptionDispatchInfo;

				// Token: 0x04000128 RID: 296
				public volatile bool IsNearestAncestorResolved;

				// Token: 0x04000129 RID: 297
				public JsonSerializerOptions.CachingContext.CacheEntry NearestAncestor;
			}

			// Token: 0x02000046 RID: 70
			[CompilerGenerated]
			private static class <>O
			{
				// Token: 0x0400012A RID: 298
				public static Func<Type, JsonSerializerOptions.CachingContext, JsonSerializerOptions.CachingContext.CacheEntry> <0>__CreateCacheEntry;
			}
		}

		// Token: 0x02000047 RID: 71
		internal static class TrackedCachingContexts
		{
			// Token: 0x06000513 RID: 1299 RVA: 0x00015C80 File Offset: 0x00013E80
			public static JsonSerializerOptions.CachingContext GetOrCreate(JsonSerializerOptions options)
			{
				int hashCode = JsonSerializerOptions.TrackedCachingContexts.s_optionsComparer.GetHashCode(options);
				int num;
				JsonSerializerOptions.CachingContext cachingContext;
				if (JsonSerializerOptions.TrackedCachingContexts.TryGetContext(options, hashCode, out num, out cachingContext))
				{
					return cachingContext;
				}
				if (num < 0)
				{
					return new JsonSerializerOptions.CachingContext(options, hashCode);
				}
				WeakReference<JsonSerializerOptions.CachingContext>[] obj = JsonSerializerOptions.TrackedCachingContexts.s_trackedContexts;
				JsonSerializerOptions.CachingContext result;
				lock (obj)
				{
					if (JsonSerializerOptions.TrackedCachingContexts.TryGetContext(options, hashCode, out num, out cachingContext))
					{
						result = cachingContext;
					}
					else
					{
						JsonSerializerOptions.CachingContext cachingContext2 = new JsonSerializerOptions.CachingContext(options, hashCode);
						if (num >= 0)
						{
							ref WeakReference<JsonSerializerOptions.CachingContext> ptr = ref JsonSerializerOptions.TrackedCachingContexts.s_trackedContexts[num];
							if (ptr == null)
							{
								ptr = new WeakReference<JsonSerializerOptions.CachingContext>(cachingContext2);
							}
							else
							{
								ptr.SetTarget(cachingContext2);
							}
						}
						result = cachingContext2;
					}
				}
				return result;
			}

			// Token: 0x06000514 RID: 1300 RVA: 0x00015D30 File Offset: 0x00013F30
			private static bool TryGetContext(JsonSerializerOptions options, int hashCode, out int firstUnpopulatedIndex, [NotNullWhen(true)] out JsonSerializerOptions.CachingContext result)
			{
				WeakReference<JsonSerializerOptions.CachingContext>[] array = JsonSerializerOptions.TrackedCachingContexts.s_trackedContexts;
				firstUnpopulatedIndex = -1;
				for (int i = 0; i < array.Length; i++)
				{
					WeakReference<JsonSerializerOptions.CachingContext> weakReference = array[i];
					JsonSerializerOptions.CachingContext cachingContext;
					if (weakReference == null || !weakReference.TryGetTarget(out cachingContext))
					{
						if (firstUnpopulatedIndex < 0)
						{
							firstUnpopulatedIndex = i;
						}
					}
					else if (hashCode == cachingContext.HashCode && JsonSerializerOptions.TrackedCachingContexts.s_optionsComparer.Equals(options, cachingContext.Options))
					{
						result = cachingContext;
						return true;
					}
				}
				result = null;
				return false;
			}

			// Token: 0x0400012B RID: 299
			private static readonly WeakReference<JsonSerializerOptions.CachingContext>[] s_trackedContexts = new WeakReference<JsonSerializerOptions.CachingContext>[64];

			// Token: 0x0400012C RID: 300
			private static readonly JsonSerializerOptions.EqualityComparer s_optionsComparer = new JsonSerializerOptions.EqualityComparer();
		}

		// Token: 0x02000048 RID: 72
		private sealed class EqualityComparer : IEqualityComparer<JsonSerializerOptions>
		{
			// Token: 0x06000516 RID: 1302 RVA: 0x00015DAC File Offset: 0x00013FAC
			public bool Equals(JsonSerializerOptions left, JsonSerializerOptions right)
			{
				return left._dictionaryKeyPolicy == right._dictionaryKeyPolicy && left._jsonPropertyNamingPolicy == right._jsonPropertyNamingPolicy && left._readCommentHandling == right._readCommentHandling && left._referenceHandler == right._referenceHandler && left._encoder == right._encoder && left._defaultIgnoreCondition == right._defaultIgnoreCondition && left._numberHandling == right._numberHandling && left._preferredObjectCreationHandling == right._preferredObjectCreationHandling && left._unknownTypeHandling == right._unknownTypeHandling && left._unmappedMemberHandling == right._unmappedMemberHandling && left._defaultBufferSize == right._defaultBufferSize && left._maxDepth == right._maxDepth && left.NewLine == right.NewLine && left._allowOutOfOrderMetadataProperties == right._allowOutOfOrderMetadataProperties && left._allowTrailingCommas == right._allowTrailingCommas && left._respectNullableAnnotations == right._respectNullableAnnotations && left._respectRequiredConstructorParameters == right._respectRequiredConstructorParameters && left._ignoreNullValues == right._ignoreNullValues && left._ignoreReadOnlyProperties == right._ignoreReadOnlyProperties && left._ignoreReadonlyFields == right._ignoreReadonlyFields && left._includeFields == right._includeFields && left._propertyNameCaseInsensitive == right._propertyNameCaseInsensitive && left._writeIndented == right._writeIndented && left._indentCharacter == right._indentCharacter && left._indentSize == right._indentSize && left._typeInfoResolver == right._typeInfoResolver && JsonSerializerOptions.EqualityComparer.<Equals>g__CompareLists|0_0<JsonConverter>(left._converters, right._converters);
			}

			// Token: 0x06000517 RID: 1303 RVA: 0x00015F74 File Offset: 0x00014174
			public int GetHashCode(JsonSerializerOptions options)
			{
				HashCode hashCode = default(HashCode);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<JsonNamingPolicy>(ref hashCode, options._dictionaryKeyPolicy);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<JsonNamingPolicy>(ref hashCode, options._jsonPropertyNamingPolicy);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<JsonCommentHandling>(ref hashCode, options._readCommentHandling);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<ReferenceHandler>(ref hashCode, options._referenceHandler);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<JavaScriptEncoder>(ref hashCode, options._encoder);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<JsonIgnoreCondition>(ref hashCode, options._defaultIgnoreCondition);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<JsonNumberHandling>(ref hashCode, options._numberHandling);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<JsonObjectCreationHandling>(ref hashCode, options._preferredObjectCreationHandling);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<JsonUnknownTypeHandling>(ref hashCode, options._unknownTypeHandling);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<JsonUnmappedMemberHandling>(ref hashCode, options._unmappedMemberHandling);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<int>(ref hashCode, options._defaultBufferSize);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<int>(ref hashCode, options._maxDepth);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<string>(ref hashCode, options.NewLine);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<bool>(ref hashCode, options._allowOutOfOrderMetadataProperties);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<bool>(ref hashCode, options._allowTrailingCommas);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<bool>(ref hashCode, options._respectNullableAnnotations);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<bool>(ref hashCode, options._respectRequiredConstructorParameters);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<bool>(ref hashCode, options._ignoreNullValues);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<bool>(ref hashCode, options._ignoreReadOnlyProperties);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<bool>(ref hashCode, options._ignoreReadonlyFields);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<bool>(ref hashCode, options._includeFields);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<bool>(ref hashCode, options._propertyNameCaseInsensitive);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<bool>(ref hashCode, options._writeIndented);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<char>(ref hashCode, options._indentCharacter);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<int>(ref hashCode, options._indentSize);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<IJsonTypeInfoResolver>(ref hashCode, options._typeInfoResolver);
				JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddListHashCode|1_0<JsonConverter>(ref hashCode, options._converters);
				return hashCode.ToHashCode();
			}

			// Token: 0x06000519 RID: 1305 RVA: 0x000160F0 File Offset: 0x000142F0
			[CompilerGenerated]
			internal static bool <Equals>g__CompareLists|0_0<TValue>(ConfigurationList<TValue> left, ConfigurationList<TValue> right) where TValue : class
			{
				if (left == null)
				{
					return right == null || right.Count == 0;
				}
				if (right == null)
				{
					return left.Count == 0;
				}
				int count;
				if ((count = left.Count) != right.Count)
				{
					return false;
				}
				for (int i = 0; i < count; i++)
				{
					if (left[i] != right[i])
					{
						return false;
					}
				}
				return true;
			}

			// Token: 0x0600051A RID: 1306 RVA: 0x00016158 File Offset: 0x00014358
			[CompilerGenerated]
			internal static void <GetHashCode>g__AddListHashCode|1_0<TValue>(ref HashCode hc, ConfigurationList<TValue> list)
			{
				if (list == null)
				{
					return;
				}
				int count = list.Count;
				for (int i = 0; i < count; i++)
				{
					JsonSerializerOptions.EqualityComparer.<GetHashCode>g__AddHashCode|1_1<TValue>(ref hc, list[i]);
				}
			}

			// Token: 0x0600051B RID: 1307 RVA: 0x00016189 File Offset: 0x00014389
			[CompilerGenerated]
			internal static void <GetHashCode>g__AddHashCode|1_1<TValue>(ref HashCode hc, TValue value)
			{
				if (typeof(TValue).IsSealed)
				{
					hc.Add<TValue>(value);
					return;
				}
				hc.Add<int>(RuntimeHelpers.GetHashCode(value));
			}
		}

		// Token: 0x02000049 RID: 73
		internal static class TrackedOptionsInstances
		{
			// Token: 0x17000150 RID: 336
			// (get) Token: 0x0600051C RID: 1308 RVA: 0x000161B5 File Offset: 0x000143B5
			public static ConditionalWeakTable<JsonSerializerOptions, object> All { get; } = new ConditionalWeakTable<JsonSerializerOptions, object>();
		}

		// Token: 0x0200004A RID: 74
		private sealed class ConverterList : ConfigurationList<JsonConverter>
		{
			// Token: 0x0600051E RID: 1310 RVA: 0x000161C8 File Offset: 0x000143C8
			public ConverterList(JsonSerializerOptions options, IList<JsonConverter> source = null) : base(source)
			{
				this._options = options;
			}

			// Token: 0x17000151 RID: 337
			// (get) Token: 0x0600051F RID: 1311 RVA: 0x000161D8 File Offset: 0x000143D8
			public override bool IsReadOnly
			{
				get
				{
					return this._options.IsReadOnly;
				}
			}

			// Token: 0x06000520 RID: 1312 RVA: 0x000161E5 File Offset: 0x000143E5
			protected override void OnCollectionModifying()
			{
				this._options.VerifyMutable();
			}

			// Token: 0x0400012E RID: 302
			private readonly JsonSerializerOptions _options;
		}

		// Token: 0x0200004B RID: 75
		private sealed class OptionsBoundJsonTypeInfoResolverChain : JsonTypeInfoResolverChain
		{
			// Token: 0x06000521 RID: 1313 RVA: 0x000161F2 File Offset: 0x000143F2
			public OptionsBoundJsonTypeInfoResolverChain(JsonSerializerOptions options)
			{
				this._options = options;
				base.AddFlattened(options._typeInfoResolver);
			}

			// Token: 0x17000152 RID: 338
			// (get) Token: 0x06000522 RID: 1314 RVA: 0x0001620D File Offset: 0x0001440D
			public override bool IsReadOnly
			{
				get
				{
					return this._options.IsReadOnly;
				}
			}

			// Token: 0x06000523 RID: 1315 RVA: 0x0001621A File Offset: 0x0001441A
			protected override void ValidateAddedValue(IJsonTypeInfoResolver item)
			{
				if (item == this || item == this._options._typeInfoResolver)
				{
					ThrowHelper.ThrowInvalidOperationException_InvalidChainedResolver();
				}
			}

			// Token: 0x06000524 RID: 1316 RVA: 0x00016233 File Offset: 0x00014433
			protected override void OnCollectionModifying()
			{
				this._options.VerifyMutable();
			}

			// Token: 0x06000525 RID: 1317 RVA: 0x00016240 File Offset: 0x00014440
			protected override void OnCollectionModified()
			{
				this._options._typeInfoResolver = this;
			}

			// Token: 0x0400012F RID: 303
			private readonly JsonSerializerOptions _options;
		}
	}
}
