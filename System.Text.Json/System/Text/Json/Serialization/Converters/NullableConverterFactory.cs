using System;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Text.Json.Reflection;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000149 RID: 329
	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	internal sealed class NullableConverterFactory : JsonConverterFactory
	{
		// Token: 0x06000E98 RID: 3736 RVA: 0x0003808E File Offset: 0x0003628E
		public override bool CanConvert(Type typeToConvert)
		{
			return typeToConvert.IsNullableOfT();
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x00038098 File Offset: 0x00036298
		public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
		{
			Type type = typeToConvert.GetGenericArguments()[0];
			JsonConverter converterInternal = options.GetConverterInternal(type);
			if (!converterInternal.Type.IsValueType && type.IsValueType)
			{
				return converterInternal;
			}
			return NullableConverterFactory.CreateValueConverter(type, converterInternal);
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x000380D4 File Offset: 0x000362D4
		public static JsonConverter CreateValueConverter(Type valueTypeToConvert, JsonConverter valueConverter)
		{
			return (JsonConverter)Activator.CreateInstance(NullableConverterFactory.GetNullableConverterType(valueTypeToConvert), BindingFlags.Instance | BindingFlags.Public, null, new object[]
			{
				valueConverter
			}, null);
		}

		// Token: 0x06000E9B RID: 3739 RVA: 0x000380F4 File Offset: 0x000362F4
		[UnconditionalSuppressMessage("ReflectionAnalysis", "IL2071:UnrecognizedReflectionPattern", Justification = "'NullableConverter<T> where T : struct' implies 'T : new()', so the trimmer is warning calling MakeGenericType here because valueTypeToConvert's constructors are not annotated. But NullableConverter doesn't call new T(), so this is safe.")]
		[return: DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicConstructors)]
		private static Type GetNullableConverterType(Type valueTypeToConvert)
		{
			return typeof(NullableConverter<>).MakeGenericType(new Type[]
			{
				valueTypeToConvert
			});
		}
	}
}
