using System;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Reflection;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000140 RID: 320
	internal sealed class EnumConverterFactory : JsonConverterFactory
	{
		// Token: 0x06000E5F RID: 3679 RVA: 0x000281D8 File Offset: 0x000263D8
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		public EnumConverterFactory()
		{
		}

		// Token: 0x06000E60 RID: 3680 RVA: 0x0002A444 File Offset: 0x00028644
		public override bool CanConvert(Type type)
		{
			return type.IsEnum;
		}

		// Token: 0x06000E61 RID: 3681 RVA: 0x00037C08 File Offset: 0x00035E08
		public static bool IsSupportedTypeCode(TypeCode typeCode)
		{
			return typeCode - TypeCode.SByte <= 7;
		}

		// Token: 0x06000E62 RID: 3682 RVA: 0x00037C22 File Offset: 0x00035E22
		[UnconditionalSuppressMessage("AOT", "IL3050:Calling members annotated with 'RequiresDynamicCodeAttribute' may break functionality when AOT compiling.", Justification = "The constructor has been annotated with RequiredDynamicCodeAttribute.")]
		public override JsonConverter CreateConverter(Type type, JsonSerializerOptions options)
		{
			return EnumConverterFactory.Create(type, EnumConverterOptions.AllowNumbers, null, options);
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x00037C2D File Offset: 0x00035E2D
		public static JsonConverter<T> Create<T>(EnumConverterOptions converterOptions, JsonSerializerOptions options, JsonNamingPolicy namingPolicy = null) where T : struct, Enum
		{
			if (!EnumConverterFactory.IsSupportedTypeCode(Type.GetTypeCode(typeof(T))))
			{
				return new UnsupportedTypeConverter<T>(null);
			}
			return new EnumConverter<T>(converterOptions, namingPolicy, options);
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00037C54 File Offset: 0x00035E54
		[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2071:UnrecognizedReflectionPattern", Justification = "'EnumConverter<T> where T : struct' implies 'T : new()', so the trimmer is warning calling MakeGenericType here because enumType's constructors are not annotated. But EnumConverter doesn't call new T(), so this is safe.")]
		public static JsonConverter Create(Type enumType, EnumConverterOptions converterOptions, JsonNamingPolicy namingPolicy, JsonSerializerOptions options)
		{
			if (!EnumConverterFactory.IsSupportedTypeCode(Type.GetTypeCode(enumType)))
			{
				return UnsupportedTypeConverterFactory.CreateUnsupportedConverterForType(enumType, null);
			}
			return (JsonConverter)typeof(EnumConverter<>).MakeGenericType(new Type[]
			{
				enumType
			}).CreateInstanceNoWrapExceptions(new Type[]
			{
				typeof(EnumConverterOptions),
				typeof(JsonNamingPolicy),
				typeof(JsonSerializerOptions)
			}, new object[]
			{
				converterOptions,
				namingPolicy,
				options
			});
		}
	}
}
