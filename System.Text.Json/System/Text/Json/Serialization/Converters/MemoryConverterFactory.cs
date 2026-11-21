using System;
using System.Diagnostics.CodeAnalysis;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x020000F9 RID: 249
	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	internal sealed class MemoryConverterFactory : JsonConverterFactory
	{
		// Token: 0x06000CE0 RID: 3296 RVA: 0x000328E4 File Offset: 0x00030AE4
		public override bool CanConvert(Type typeToConvert)
		{
			if (!typeToConvert.IsGenericType || !typeToConvert.IsValueType)
			{
				return false;
			}
			Type genericTypeDefinition = typeToConvert.GetGenericTypeDefinition();
			return genericTypeDefinition == typeof(Memory<>) || genericTypeDefinition == typeof(ReadOnlyMemory<>);
		}

		// Token: 0x06000CE1 RID: 3297 RVA: 0x00032930 File Offset: 0x00030B30
		public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
		{
			Type type = (typeToConvert.GetGenericTypeDefinition() == typeof(Memory<>)) ? typeof(MemoryConverter<>) : typeof(ReadOnlyMemoryConverter<>);
			Type type2 = typeToConvert.GetGenericArguments()[0];
			return (JsonConverter)Activator.CreateInstance(type.MakeGenericType(new Type[]
			{
				type2
			}));
		}
	}
}
