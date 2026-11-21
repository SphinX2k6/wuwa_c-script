using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text.Json.Reflection;
using System.Text.Json.Serialization.Converters;

namespace System.Text.Json.Serialization
{
	// Token: 0x0200009D RID: 157
	[RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
	internal sealed class IAsyncEnumerableConverterFactory : JsonConverterFactory
	{
		// Token: 0x0600092B RID: 2347 RVA: 0x00028571 File Offset: 0x00026771
		public override bool CanConvert(Type typeToConvert)
		{
			return IAsyncEnumerableConverterFactory.GetAsyncEnumerableInterface(typeToConvert) != null;
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00028580 File Offset: 0x00026780
		public override JsonConverter CreateConverter(Type typeToConvert, JsonSerializerOptions options)
		{
			Type type = IAsyncEnumerableConverterFactory.GetAsyncEnumerableInterface(typeToConvert).GetGenericArguments()[0];
			return (JsonConverter)Activator.CreateInstance(typeof(IAsyncEnumerableOfTConverter<, >).MakeGenericType(new Type[]
			{
				typeToConvert,
				type
			}));
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x000285C2 File Offset: 0x000267C2
		private static Type GetAsyncEnumerableInterface(Type type)
		{
			return type.GetCompatibleGenericInterface(typeof(IAsyncEnumerable<>));
		}
	}
}
