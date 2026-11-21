using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text.Json.Reflection;
using System.Text.Json.Serialization.Converters;
using System.Threading;

namespace System.Text.Json.Serialization.Metadata
{
	// Token: 0x020000B3 RID: 179
	[NullableContext(1)]
	[Nullable(0)]
	public class DefaultJsonTypeInfoResolver : IJsonTypeInfoResolver, IBuiltInJsonTypeInfoResolver
	{
		// Token: 0x060009F2 RID: 2546 RVA: 0x0002AA34 File Offset: 0x00028C34
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		private static JsonConverterFactory[] GetDefaultFactoryConverters()
		{
			return new JsonConverterFactory[]
			{
				new UnsupportedTypeConverterFactory(),
				new NullableConverterFactory(),
				new EnumConverterFactory(),
				new JsonNodeConverterFactory(),
				new FSharpTypeConverterFactory(),
				new MemoryConverterFactory(),
				new IAsyncEnumerableConverterFactory(),
				new IEnumerableConverterFactory(),
				new ObjectConverterFactory(true)
			};
		}

		// Token: 0x060009F3 RID: 2547 RVA: 0x0002AA94 File Offset: 0x00028C94
		private static Dictionary<Type, JsonConverter> GetDefaultSimpleConverters()
		{
			DefaultJsonTypeInfoResolver.<>c__DisplayClass3_0 CS$<>8__locals1;
			CS$<>8__locals1.converters = new Dictionary<Type, JsonConverter>(31);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.BooleanConverter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.ByteConverter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.ByteArrayConverter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.CharConverter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.DateTimeConverter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.DateTimeOffsetConverter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.DateOnlyConverter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.TimeOnlyConverter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.HalfConverter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.DoubleConverter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.DecimalConverter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.GuidConverter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.Int16Converter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.Int32Converter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.Int64Converter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.JsonElementConverter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.JsonDocumentConverter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.MemoryByteConverter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.ReadOnlyMemoryByteConverter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.ObjectConverter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.SByteConverter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.SingleConverter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.StringConverter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.TimeSpanConverter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.UInt16Converter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.UInt32Converter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.UInt64Converter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.Int128Converter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.UInt128Converter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.UriConverter, ref CS$<>8__locals1);
			DefaultJsonTypeInfoResolver.<GetDefaultSimpleConverters>g__Add|3_0(JsonMetadataServices.VersionConverter, ref CS$<>8__locals1);
			return CS$<>8__locals1.converters;
		}

		// Token: 0x060009F4 RID: 2548 RVA: 0x0002AC2C File Offset: 0x00028E2C
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		private static JsonConverter GetBuiltInConverter(Type typeToConvert)
		{
			if (DefaultJsonTypeInfoResolver.s_defaultSimpleConverters == null)
			{
				DefaultJsonTypeInfoResolver.s_defaultSimpleConverters = DefaultJsonTypeInfoResolver.GetDefaultSimpleConverters();
			}
			if (DefaultJsonTypeInfoResolver.s_defaultFactoryConverters == null)
			{
				DefaultJsonTypeInfoResolver.s_defaultFactoryConverters = DefaultJsonTypeInfoResolver.GetDefaultFactoryConverters();
			}
			JsonConverter result;
			if (DefaultJsonTypeInfoResolver.s_defaultSimpleConverters.TryGetValue(typeToConvert, out result))
			{
				return result;
			}
			foreach (JsonConverterFactory jsonConverterFactory in DefaultJsonTypeInfoResolver.s_defaultFactoryConverters)
			{
				if (jsonConverterFactory.CanConvert(typeToConvert))
				{
					result = jsonConverterFactory;
					break;
				}
			}
			return result;
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0002AC92 File Offset: 0x00028E92
		internal static bool TryGetDefaultSimpleConverter(Type typeToConvert, [NotNullWhen(true)] out JsonConverter converter)
		{
			if (DefaultJsonTypeInfoResolver.s_defaultSimpleConverters == null)
			{
				converter = null;
				return false;
			}
			return DefaultJsonTypeInfoResolver.s_defaultSimpleConverters.TryGetValue(typeToConvert, out converter);
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0002ACAC File Offset: 0x00028EAC
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		private static JsonConverter GetCustomConverterForMember(Type typeToConvert, MemberInfo memberInfo, JsonSerializerOptions options)
		{
			JsonConverterAttribute uniqueCustomAttribute = memberInfo.GetUniqueCustomAttribute(false);
			if (uniqueCustomAttribute != null)
			{
				return DefaultJsonTypeInfoResolver.GetConverterFromAttribute(uniqueCustomAttribute, typeToConvert, memberInfo, options);
			}
			return null;
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0002ACD0 File Offset: 0x00028ED0
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		internal static JsonConverter GetConverterForType(Type typeToConvert, JsonSerializerOptions options, bool resolveJsonConverterAttribute = true)
		{
			JsonConverter jsonConverter = options.GetConverterFromList(typeToConvert);
			if (resolveJsonConverterAttribute && jsonConverter == null)
			{
				JsonConverterAttribute uniqueCustomAttribute = typeToConvert.GetUniqueCustomAttribute(false);
				if (uniqueCustomAttribute != null)
				{
					jsonConverter = DefaultJsonTypeInfoResolver.GetConverterFromAttribute(uniqueCustomAttribute, typeToConvert, null, options);
				}
			}
			if (jsonConverter == null)
			{
				jsonConverter = DefaultJsonTypeInfoResolver.GetBuiltInConverter(typeToConvert);
			}
			jsonConverter = options.ExpandConverterFactory(jsonConverter, typeToConvert);
			if (!jsonConverter.Type.IsInSubtypeRelationshipWith(typeToConvert))
			{
				ThrowHelper.ThrowInvalidOperationException_SerializationConverterNotCompatible(jsonConverter.GetType(), typeToConvert);
			}
			JsonSerializerOptions.CheckConverterNullabilityIsSameAsPropertyType(jsonConverter, typeToConvert);
			return jsonConverter;
		}

		// Token: 0x060009F8 RID: 2552 RVA: 0x0002AD38 File Offset: 0x00028F38
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		private static JsonConverter GetConverterFromAttribute(JsonConverterAttribute converterAttribute, Type typeToConvert, MemberInfo memberInfo, JsonSerializerOptions options)
		{
			Type type = ((memberInfo != null) ? memberInfo.DeclaringType : null) ?? typeToConvert;
			Type converterType = converterAttribute.ConverterType;
			JsonConverter jsonConverter;
			if (converterType == null)
			{
				jsonConverter = converterAttribute.CreateConverter(typeToConvert);
				if (jsonConverter == null)
				{
					ThrowHelper.ThrowInvalidOperationException_SerializationConverterOnAttributeNotCompatible(type, memberInfo, typeToConvert);
				}
			}
			else
			{
				ConstructorInfo constructor = converterType.GetConstructor(Type.EmptyTypes);
				if (!typeof(JsonConverter).IsAssignableFrom(converterType) || constructor == null || !constructor.IsPublic)
				{
					ThrowHelper.ThrowInvalidOperationException_SerializationConverterOnAttributeInvalid(type, memberInfo);
				}
				jsonConverter = (JsonConverter)Activator.CreateInstance(converterType);
			}
			if (!jsonConverter.CanConvert(typeToConvert))
			{
				Type underlyingType = Nullable.GetUnderlyingType(typeToConvert);
				if (underlyingType != null && jsonConverter.CanConvert(underlyingType))
				{
					JsonConverterFactory jsonConverterFactory = jsonConverter as JsonConverterFactory;
					if (jsonConverterFactory != null)
					{
						jsonConverter = jsonConverterFactory.GetConverterInternal(underlyingType, options);
					}
					return NullableConverterFactory.CreateValueConverter(underlyingType, jsonConverter);
				}
				ThrowHelper.ThrowInvalidOperationException_SerializationConverterOnAttributeNotCompatible(type, memberInfo, typeToConvert);
			}
			return jsonConverter;
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x0002AE0C File Offset: 0x0002900C
		internal static MemberAccessor MemberAccessor
		{
			[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
			[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
			get
			{
				return DefaultJsonTypeInfoResolver.s_memberAccessor ?? DefaultJsonTypeInfoResolver.<get_MemberAccessor>g__Initialize|10_0();
			}
		}

		// Token: 0x060009FA RID: 2554 RVA: 0x0002AE1C File Offset: 0x0002901C
		internal static void ClearMemberAccessorCaches()
		{
			MemberAccessor memberAccessor = DefaultJsonTypeInfoResolver.s_memberAccessor;
			if (memberAccessor == null)
			{
				return;
			}
			memberAccessor.Clear();
		}

		// Token: 0x060009FB RID: 2555 RVA: 0x0002AE30 File Offset: 0x00029030
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		private static JsonTypeInfo CreateTypeInfoCore(Type type, JsonConverter converter, JsonSerializerOptions options)
		{
			JsonTypeInfo jsonTypeInfo = JsonTypeInfo.CreateJsonTypeInfo(type, converter, options);
			JsonNumberHandling? numberHandlingForType = DefaultJsonTypeInfoResolver.GetNumberHandlingForType(jsonTypeInfo.Type);
			if (numberHandlingForType != null)
			{
				JsonNumberHandling valueOrDefault = numberHandlingForType.GetValueOrDefault();
				jsonTypeInfo.NumberHandling = new JsonNumberHandling?(valueOrDefault);
			}
			JsonObjectCreationHandling? objectCreationHandlingForType = DefaultJsonTypeInfoResolver.GetObjectCreationHandlingForType(jsonTypeInfo.Type);
			if (objectCreationHandlingForType != null)
			{
				JsonObjectCreationHandling valueOrDefault2 = objectCreationHandlingForType.GetValueOrDefault();
				jsonTypeInfo.PreferredPropertyObjectCreationHandling = new JsonObjectCreationHandling?(valueOrDefault2);
			}
			JsonUnmappedMemberHandling? unmappedMemberHandling = DefaultJsonTypeInfoResolver.GetUnmappedMemberHandling(jsonTypeInfo.Type);
			if (unmappedMemberHandling != null)
			{
				JsonUnmappedMemberHandling valueOrDefault3 = unmappedMemberHandling.GetValueOrDefault();
				jsonTypeInfo.UnmappedMemberHandling = new JsonUnmappedMemberHandling?(valueOrDefault3);
			}
			jsonTypeInfo.PopulatePolymorphismMetadata();
			jsonTypeInfo.MapInterfaceTypesToCallbacks();
			Func<object> func = DefaultJsonTypeInfoResolver.DetermineCreateObjectDelegate(type, converter);
			jsonTypeInfo.SetCreateObjectIfCompatible(func);
			jsonTypeInfo.CreateObjectForExtensionDataProperty = func;
			if (jsonTypeInfo != null && jsonTypeInfo.Kind == JsonTypeInfoKind.Object && !jsonTypeInfo.IsNullable)
			{
				NullabilityInfoContext nullabilityCtx = new NullabilityInfoContext();
				if (converter.ConstructorIsParameterized)
				{
					DefaultJsonTypeInfoResolver.PopulateParameterInfoValues(jsonTypeInfo, nullabilityCtx);
				}
				DefaultJsonTypeInfoResolver.PopulateProperties(jsonTypeInfo, nullabilityCtx);
				jsonTypeInfo.ConstructorAttributeProvider = jsonTypeInfo.Converter.ConstructorInfo;
			}
			converter.ConfigureJsonTypeInfo(jsonTypeInfo, options);
			converter.ConfigureJsonTypeInfoUsingReflection(jsonTypeInfo, options);
			return jsonTypeInfo;
		}

		// Token: 0x060009FC RID: 2556 RVA: 0x0002AF40 File Offset: 0x00029140
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		private static void PopulateProperties(JsonTypeInfo typeInfo, NullabilityInfoContext nullabilityCtx)
		{
			ConstructorInfo constructorInfo = typeInfo.Converter.ConstructorInfo;
			bool constructorHasSetsRequiredMembersAttribute = constructorInfo != null && constructorInfo.HasSetsRequiredMembersAttribute();
			JsonTypeInfo.PropertyHierarchyResolutionState propertyHierarchyResolutionState = new JsonTypeInfo.PropertyHierarchyResolutionState(typeInfo.Options);
			foreach (Type type in typeInfo.Type.GetSortedTypeHierarchy())
			{
				if (type == JsonTypeInfo.ObjectType || type == typeof(ValueType))
				{
					break;
				}
				DefaultJsonTypeInfoResolver.AddMembersDeclaredBySuperType(typeInfo, type, nullabilityCtx, constructorHasSetsRequiredMembersAttribute, ref propertyHierarchyResolutionState);
			}
			if (propertyHierarchyResolutionState.IsPropertyOrderSpecified)
			{
				typeInfo.PropertyList.SortProperties();
			}
		}

		// Token: 0x060009FD RID: 2557 RVA: 0x0002AFD4 File Offset: 0x000291D4
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		private static void AddMembersDeclaredBySuperType(JsonTypeInfo typeInfo, Type currentType, NullabilityInfoContext nullabilityCtx, bool constructorHasSetsRequiredMembersAttribute, ref JsonTypeInfo.PropertyHierarchyResolutionState state)
		{
			bool shouldCheckForRequiredKeyword = !constructorHasSetsRequiredMembersAttribute && currentType.HasRequiredMemberAttribute();
			foreach (PropertyInfo propertyInfo in currentType.GetProperties(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
			{
				if (propertyInfo.GetIndexParameters().Length == 0 && !DefaultJsonTypeInfoResolver.PropertyIsOverriddenAndIgnored(propertyInfo, state.IgnoredProperties))
				{
					bool flag = propertyInfo.GetCustomAttribute(false) != null;
					MethodInfo getMethod = propertyInfo.GetMethod;
					bool flag2;
					if (getMethod == null || !getMethod.IsPublic)
					{
						MethodInfo setMethod = propertyInfo.SetMethod;
						flag2 = (setMethod != null && setMethod.IsPublic);
					}
					else
					{
						flag2 = true;
					}
					if (flag2 || flag)
					{
						DefaultJsonTypeInfoResolver.AddMember(typeInfo, propertyInfo.PropertyType, propertyInfo, nullabilityCtx, shouldCheckForRequiredKeyword, flag, ref state);
					}
				}
			}
			foreach (FieldInfo fieldInfo in currentType.GetFields(BindingFlags.DeclaredOnly | BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic))
			{
				bool flag3 = fieldInfo.GetCustomAttribute(false) != null;
				if (flag3 || (fieldInfo.IsPublic && typeInfo.Options.IncludeFields))
				{
					DefaultJsonTypeInfoResolver.AddMember(typeInfo, fieldInfo.FieldType, fieldInfo, nullabilityCtx, shouldCheckForRequiredKeyword, flag3, ref state);
				}
			}
		}

		// Token: 0x060009FE RID: 2558 RVA: 0x0002B0CC File Offset: 0x000292CC
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		private static void AddMember(JsonTypeInfo typeInfo, Type typeToConvert, MemberInfo memberInfo, NullabilityInfoContext nullabilityCtx, bool shouldCheckForRequiredKeyword, bool hasJsonIncludeAttribute, ref JsonTypeInfo.PropertyHierarchyResolutionState state)
		{
			JsonPropertyInfo jsonPropertyInfo = DefaultJsonTypeInfoResolver.CreatePropertyInfo(typeInfo, typeToConvert, memberInfo, nullabilityCtx, typeInfo.Options, shouldCheckForRequiredKeyword, hasJsonIncludeAttribute);
			if (jsonPropertyInfo == null)
			{
				return;
			}
			typeInfo.PropertyList.AddPropertyWithConflictResolution(jsonPropertyInfo, ref state);
		}

		// Token: 0x060009FF RID: 2559 RVA: 0x0002B100 File Offset: 0x00029300
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		private static JsonPropertyInfo CreatePropertyInfo(JsonTypeInfo typeInfo, Type typeToConvert, MemberInfo memberInfo, NullabilityInfoContext nullabilityCtx, JsonSerializerOptions options, bool shouldCheckForRequiredKeyword, bool hasJsonIncludeAttribute)
		{
			JsonIgnoreAttribute customAttribute = memberInfo.GetCustomAttribute(false);
			JsonIgnoreCondition? ignoreCondition = (customAttribute != null) ? new JsonIgnoreCondition?(customAttribute.Condition) : null;
			if (JsonTypeInfo.IsInvalidForSerialization(typeToConvert))
			{
				if (ignoreCondition.GetValueOrDefault() == JsonIgnoreCondition.Always)
				{
					return null;
				}
				ThrowHelper.ThrowInvalidOperationException_CannotSerializeInvalidType(typeToConvert, memberInfo.DeclaringType, memberInfo);
			}
			JsonConverter customConverterForMember;
			try
			{
				customConverterForMember = DefaultJsonTypeInfoResolver.GetCustomConverterForMember(typeToConvert, memberInfo, options);
			}
			catch (InvalidOperationException obj) when (ignoreCondition.GetValueOrDefault() == JsonIgnoreCondition.Always)
			{
				return null;
			}
			JsonPropertyInfo jsonPropertyInfo = typeInfo.CreatePropertyUsingReflection(typeToConvert, memberInfo.DeclaringType);
			DefaultJsonTypeInfoResolver.PopulatePropertyInfo(jsonPropertyInfo, memberInfo, customConverterForMember, ignoreCondition, nullabilityCtx, shouldCheckForRequiredKeyword, hasJsonIncludeAttribute);
			return jsonPropertyInfo;
		}

		// Token: 0x06000A00 RID: 2560 RVA: 0x0002B1AC File Offset: 0x000293AC
		private static JsonNumberHandling? GetNumberHandlingForType(Type type)
		{
			JsonNumberHandlingAttribute uniqueCustomAttribute = type.GetUniqueCustomAttribute(false);
			if (uniqueCustomAttribute == null)
			{
				return null;
			}
			return new JsonNumberHandling?(uniqueCustomAttribute.Handling);
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0002B1D8 File Offset: 0x000293D8
		private static JsonObjectCreationHandling? GetObjectCreationHandlingForType(Type type)
		{
			JsonObjectCreationHandlingAttribute uniqueCustomAttribute = type.GetUniqueCustomAttribute(false);
			if (uniqueCustomAttribute == null)
			{
				return null;
			}
			return new JsonObjectCreationHandling?(uniqueCustomAttribute.Handling);
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0002B204 File Offset: 0x00029404
		private static JsonUnmappedMemberHandling? GetUnmappedMemberHandling(Type type)
		{
			JsonUnmappedMemberHandlingAttribute uniqueCustomAttribute = type.GetUniqueCustomAttribute(false);
			if (uniqueCustomAttribute == null)
			{
				return null;
			}
			return new JsonUnmappedMemberHandling?(uniqueCustomAttribute.UnmappedMemberHandling);
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0002B230 File Offset: 0x00029430
		private static bool PropertyIsOverriddenAndIgnored(PropertyInfo propertyInfo, Dictionary<string, JsonPropertyInfo> ignoredMembers)
		{
			JsonPropertyInfo jsonPropertyInfo;
			return propertyInfo.IsVirtual() && ignoredMembers != null && ignoredMembers.TryGetValue(propertyInfo.Name, out jsonPropertyInfo) && jsonPropertyInfo.IsVirtual && propertyInfo.PropertyType == jsonPropertyInfo.PropertyType;
		}

		// Token: 0x06000A04 RID: 2564 RVA: 0x0002B274 File Offset: 0x00029474
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		private static void PopulateParameterInfoValues(JsonTypeInfo typeInfo, NullabilityInfoContext nullabilityCtx)
		{
			ParameterInfo[] parameters = typeInfo.Converter.ConstructorInfo.GetParameters();
			int num = parameters.Length;
			JsonParameterInfoValues[] array = new JsonParameterInfoValues[num];
			for (int i = 0; i < num; i++)
			{
				ParameterInfo parameterInfo = parameters[i];
				if (string.IsNullOrEmpty(parameterInfo.Name))
				{
					ThrowHelper.ThrowNotSupportedException_ConstructorContainsNullParameterNames(typeInfo.Converter.ConstructorInfo.DeclaringType);
				}
				JsonParameterInfoValues jsonParameterInfoValues = new JsonParameterInfoValues
				{
					Name = parameterInfo.Name,
					ParameterType = parameterInfo.ParameterType,
					Position = parameterInfo.Position,
					HasDefaultValue = parameterInfo.HasDefaultValue,
					DefaultValue = parameterInfo.GetDefaultValue(),
					IsNullable = (DefaultJsonTypeInfoResolver.DetermineParameterNullability(parameterInfo, nullabilityCtx) != NullabilityState.NotNull)
				};
				array[i] = jsonParameterInfoValues;
			}
			typeInfo.PopulateParameterInfoValues(array);
		}

		// Token: 0x06000A05 RID: 2565 RVA: 0x0002B340 File Offset: 0x00029540
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		private static void PopulatePropertyInfo(JsonPropertyInfo jsonPropertyInfo, MemberInfo memberInfo, JsonConverter customConverter, JsonIgnoreCondition? ignoreCondition, NullabilityInfoContext nullabilityCtx, bool shouldCheckForRequiredKeyword, bool hasJsonIncludeAttribute)
		{
			jsonPropertyInfo.AttributeProvider = memberInfo;
			PropertyInfo propertyInfo = memberInfo as PropertyInfo;
			if (propertyInfo == null)
			{
				FieldInfo fieldInfo = memberInfo as FieldInfo;
				if (fieldInfo != null)
				{
					jsonPropertyInfo.MemberName = fieldInfo.Name;
					jsonPropertyInfo.MemberType = MemberTypes.Field;
				}
			}
			else
			{
				jsonPropertyInfo.MemberName = propertyInfo.Name;
				jsonPropertyInfo.IsVirtual = propertyInfo.IsVirtual();
				jsonPropertyInfo.MemberType = MemberTypes.Property;
			}
			jsonPropertyInfo.CustomConverter = customConverter;
			DefaultJsonTypeInfoResolver.DeterminePropertyPolicies(jsonPropertyInfo, memberInfo);
			DefaultJsonTypeInfoResolver.DeterminePropertyName(jsonPropertyInfo, memberInfo);
			DefaultJsonTypeInfoResolver.DeterminePropertyIsRequired(jsonPropertyInfo, memberInfo, shouldCheckForRequiredKeyword);
			DefaultJsonTypeInfoResolver.DeterminePropertyNullability(jsonPropertyInfo, memberInfo, nullabilityCtx);
			if (ignoreCondition.GetValueOrDefault() != JsonIgnoreCondition.Always)
			{
				jsonPropertyInfo.DetermineReflectionPropertyAccessors(memberInfo, hasJsonIncludeAttribute);
			}
			jsonPropertyInfo.IgnoreCondition = ignoreCondition;
			jsonPropertyInfo.IsExtensionData = (memberInfo.GetCustomAttribute(false) != null);
		}

		// Token: 0x06000A06 RID: 2566 RVA: 0x0002B3F4 File Offset: 0x000295F4
		private static void DeterminePropertyPolicies(JsonPropertyInfo propertyInfo, MemberInfo memberInfo)
		{
			JsonPropertyOrderAttribute customAttribute = memberInfo.GetCustomAttribute(false);
			propertyInfo.Order = ((customAttribute != null) ? customAttribute.Order : 0);
			JsonNumberHandlingAttribute customAttribute2 = memberInfo.GetCustomAttribute(false);
			propertyInfo.NumberHandling = ((customAttribute2 != null) ? new JsonNumberHandling?(customAttribute2.Handling) : null);
			JsonObjectCreationHandlingAttribute customAttribute3 = memberInfo.GetCustomAttribute(false);
			propertyInfo.ObjectCreationHandling = ((customAttribute3 != null) ? new JsonObjectCreationHandling?(customAttribute3.Handling) : null);
		}

		// Token: 0x06000A07 RID: 2567 RVA: 0x0002B46C File Offset: 0x0002966C
		private static void DeterminePropertyName(JsonPropertyInfo propertyInfo, MemberInfo memberInfo)
		{
			JsonPropertyNameAttribute customAttribute = memberInfo.GetCustomAttribute(false);
			string text;
			if (customAttribute != null)
			{
				text = customAttribute.Name;
			}
			else if (propertyInfo.Options.PropertyNamingPolicy != null)
			{
				text = propertyInfo.Options.PropertyNamingPolicy.ConvertName(memberInfo.Name);
			}
			else
			{
				text = memberInfo.Name;
			}
			if (text == null)
			{
				ThrowHelper.ThrowInvalidOperationException_SerializerPropertyNameNull(propertyInfo);
			}
			propertyInfo.Name = text;
		}

		// Token: 0x06000A08 RID: 2568 RVA: 0x0002B4CA File Offset: 0x000296CA
		private static void DeterminePropertyIsRequired(JsonPropertyInfo propertyInfo, MemberInfo memberInfo, bool shouldCheckForRequiredKeyword)
		{
			propertyInfo.IsRequired = (memberInfo.GetCustomAttribute(false) != null || (shouldCheckForRequiredKeyword && memberInfo.HasRequiredMemberAttribute()));
		}

		// Token: 0x06000A09 RID: 2569 RVA: 0x0002B4EC File Offset: 0x000296EC
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		internal static void DeterminePropertyAccessors<T>(JsonPropertyInfo<T> jsonPropertyInfo, MemberInfo memberInfo, bool useNonPublicAccessors)
		{
			PropertyInfo propertyInfo = memberInfo as PropertyInfo;
			if (propertyInfo == null)
			{
				FieldInfo fieldInfo = memberInfo as FieldInfo;
				if (fieldInfo == null)
				{
					return;
				}
				jsonPropertyInfo.Get = DefaultJsonTypeInfoResolver.MemberAccessor.CreateFieldGetter<T>(fieldInfo);
				if (!fieldInfo.IsInitOnly)
				{
					jsonPropertyInfo.Set = DefaultJsonTypeInfoResolver.MemberAccessor.CreateFieldSetter<T>(fieldInfo);
				}
			}
			else
			{
				MethodInfo getMethod = propertyInfo.GetMethod;
				if (getMethod != null && (getMethod.IsPublic || useNonPublicAccessors))
				{
					jsonPropertyInfo.Get = DefaultJsonTypeInfoResolver.MemberAccessor.CreatePropertyGetter<T>(propertyInfo);
				}
				MethodInfo setMethod = propertyInfo.SetMethod;
				if (setMethod != null && (setMethod.IsPublic || useNonPublicAccessors))
				{
					jsonPropertyInfo.Set = DefaultJsonTypeInfoResolver.MemberAccessor.CreatePropertySetter<T>(propertyInfo);
					return;
				}
			}
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x0002B590 File Offset: 0x00029790
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		private static Func<object> DetermineCreateObjectDelegate(Type type, JsonConverter converter)
		{
			ConstructorInfo constructorInfo = null;
			if (converter.ConstructorInfo != null && !converter.ConstructorIsParameterized)
			{
				constructorInfo = converter.ConstructorInfo;
			}
			if (constructorInfo == null)
			{
				constructorInfo = type.GetConstructor(BindingFlags.Instance | BindingFlags.Public, null, Type.EmptyTypes, null);
			}
			return DefaultJsonTypeInfoResolver.MemberAccessor.CreateParameterlessConstructor(type, constructorInfo);
		}

		// Token: 0x06000A0B RID: 2571 RVA: 0x0002B5DC File Offset: 0x000297DC
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		private static void DeterminePropertyNullability(JsonPropertyInfo propertyInfo, MemberInfo memberInfo, NullabilityInfoContext nullabilityCtx)
		{
			if (!propertyInfo.PropertyTypeCanBeNull)
			{
				return;
			}
			NullabilityInfo nullabilityInfo;
			if (propertyInfo.MemberType == MemberTypes.Property)
			{
				nullabilityInfo = nullabilityCtx.Create((PropertyInfo)memberInfo);
			}
			else
			{
				nullabilityInfo = nullabilityCtx.Create((FieldInfo)memberInfo);
			}
			propertyInfo.IsGetNullable = (nullabilityInfo.ReadState != NullabilityState.NotNull);
			propertyInfo.IsSetNullable = (nullabilityInfo.WriteState != NullabilityState.NotNull);
		}

		// Token: 0x06000A0C RID: 2572 RVA: 0x0002B63C File Offset: 0x0002983C
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		private static NullabilityState DetermineParameterNullability(ParameterInfo parameterInfo, NullabilityInfoContext nullabilityCtx)
		{
			if (!parameterInfo.ParameterType.IsNullableType())
			{
				return NullabilityState.NotNull;
			}
			return nullabilityCtx.Create(parameterInfo).WriteState;
		}

		// Token: 0x06000A0D RID: 2573 RVA: 0x0002B659 File Offset: 0x00029859
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public DefaultJsonTypeInfoResolver() : this(true)
		{
		}

		// Token: 0x06000A0E RID: 2574 RVA: 0x0002B662 File Offset: 0x00029862
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		private DefaultJsonTypeInfoResolver(bool mutable)
		{
			this._mutable = mutable;
		}

		// Token: 0x06000A0F RID: 2575 RVA: 0x0002B674 File Offset: 0x00029874
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2026:RequiresUnreferencedCode", Justification = "The ctor is marked RequiresUnreferencedCode.")]
		[UnconditionalSuppressMessage("AotAnalysis", "IL3050:RequiresDynamicCode", Justification = "The ctor is marked RequiresDynamicCode.")]
		public virtual JsonTypeInfo GetTypeInfo(Type type, JsonSerializerOptions options)
		{
			if (type == null)
			{
				ThrowHelper.ThrowArgumentNullException("type");
			}
			if (options == null)
			{
				ThrowHelper.ThrowArgumentNullException("options");
			}
			this._mutable = false;
			JsonTypeInfo.ValidateType(type);
			JsonTypeInfo jsonTypeInfo = DefaultJsonTypeInfoResolver.CreateJsonTypeInfo(type, options);
			jsonTypeInfo.OriginatingResolver = this;
			jsonTypeInfo.IsCustomized = false;
			if (this._modifiers != null)
			{
				foreach (Action<JsonTypeInfo> action in this._modifiers)
				{
					action(jsonTypeInfo);
				}
			}
			return jsonTypeInfo;
		}

		// Token: 0x06000A10 RID: 2576 RVA: 0x0002B714 File Offset: 0x00029914
		[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		private static JsonTypeInfo CreateJsonTypeInfo(Type type, JsonSerializerOptions options)
		{
			JsonConverter converterForType = DefaultJsonTypeInfoResolver.GetConverterForType(type, options, true);
			return DefaultJsonTypeInfoResolver.CreateTypeInfoCore(type, converterForType, options);
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000A11 RID: 2577 RVA: 0x0002B734 File Offset: 0x00029934
		public IList<Action<JsonTypeInfo>> Modifiers
		{
			get
			{
				DefaultJsonTypeInfoResolver.ModifierCollection result;
				if ((result = this._modifiers) == null)
				{
					result = (this._modifiers = new DefaultJsonTypeInfoResolver.ModifierCollection(this));
				}
				return result;
			}
		}

		// Token: 0x06000A12 RID: 2578 RVA: 0x0002B75C File Offset: 0x0002995C
		bool IBuiltInJsonTypeInfoResolver.IsCompatibleWithOptions(JsonSerializerOptions _)
		{
			DefaultJsonTypeInfoResolver.ModifierCollection modifiers = this._modifiers;
			bool flag = modifiers == null || modifiers.Count == 0;
			return flag && base.GetType() == typeof(DefaultJsonTypeInfoResolver);
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000A13 RID: 2579 RVA: 0x0002B79C File Offset: 0x0002999C
		internal static DefaultJsonTypeInfoResolver DefaultInstance
		{
			[RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
			[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
			get
			{
				DefaultJsonTypeInfoResolver defaultJsonTypeInfoResolver = DefaultJsonTypeInfoResolver.s_defaultInstance;
				if (defaultJsonTypeInfoResolver != null)
				{
					return defaultJsonTypeInfoResolver;
				}
				DefaultJsonTypeInfoResolver defaultJsonTypeInfoResolver2 = new DefaultJsonTypeInfoResolver(false);
				return Interlocked.CompareExchange<DefaultJsonTypeInfoResolver>(ref DefaultJsonTypeInfoResolver.s_defaultInstance, defaultJsonTypeInfoResolver2, null) ?? defaultJsonTypeInfoResolver2;
			}
		}

		// Token: 0x06000A14 RID: 2580 RVA: 0x0002B7CC File Offset: 0x000299CC
		[CompilerGenerated]
		internal static void <GetDefaultSimpleConverters>g__Add|3_0(JsonConverter converter, ref DefaultJsonTypeInfoResolver.<>c__DisplayClass3_0 A_1)
		{
			A_1.converters.Add(converter.Type, converter);
		}

		// Token: 0x06000A15 RID: 2581 RVA: 0x0002B7E0 File Offset: 0x000299E0
		[CompilerGenerated]
		internal static MemberAccessor <get_MemberAccessor>g__Initialize|10_0()
		{
			MemberAccessor memberAccessor = RuntimeFeature.IsDynamicCodeSupported ? new ReflectionEmitCachingMemberAccessor() : new ReflectionMemberAccessor();
			return Interlocked.CompareExchange<MemberAccessor>(ref DefaultJsonTypeInfoResolver.s_memberAccessor, memberAccessor, null) ?? memberAccessor;
		}

		// Token: 0x040002CF RID: 719
		private static Dictionary<Type, JsonConverter> s_defaultSimpleConverters;

		// Token: 0x040002D0 RID: 720
		private static JsonConverterFactory[] s_defaultFactoryConverters;

		// Token: 0x040002D1 RID: 721
		private static MemberAccessor s_memberAccessor;

		// Token: 0x040002D2 RID: 722
		private bool _mutable;

		// Token: 0x040002D3 RID: 723
		private DefaultJsonTypeInfoResolver.ModifierCollection _modifiers;

		// Token: 0x040002D4 RID: 724
		private static DefaultJsonTypeInfoResolver s_defaultInstance;

		// Token: 0x020000B4 RID: 180
		private sealed class ModifierCollection : ConfigurationList<Action<JsonTypeInfo>>
		{
			// Token: 0x06000A16 RID: 2582 RVA: 0x0002B812 File Offset: 0x00029A12
			public ModifierCollection(DefaultJsonTypeInfoResolver resolver) : base(null)
			{
				this._resolver = resolver;
			}

			// Token: 0x17000205 RID: 517
			// (get) Token: 0x06000A17 RID: 2583 RVA: 0x0002B822 File Offset: 0x00029A22
			public override bool IsReadOnly
			{
				get
				{
					return !this._resolver._mutable;
				}
			}

			// Token: 0x06000A18 RID: 2584 RVA: 0x0002B832 File Offset: 0x00029A32
			protected override void OnCollectionModifying()
			{
				if (!this._resolver._mutable)
				{
					ThrowHelper.ThrowInvalidOperationException_DefaultTypeInfoResolverImmutable();
				}
			}

			// Token: 0x040002D5 RID: 725
			private readonly DefaultJsonTypeInfoResolver _resolver;
		}
	}
}
