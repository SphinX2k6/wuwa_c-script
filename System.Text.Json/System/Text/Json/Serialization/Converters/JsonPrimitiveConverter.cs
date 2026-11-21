using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.InteropServices;
using System.Text.Json.Nodes;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000101 RID: 257
	internal abstract class JsonPrimitiveConverter<T> : JsonConverter<T>
	{
		// Token: 0x06000D0C RID: 3340 RVA: 0x00032D1E File Offset: 0x00030F1E
		public sealed override void WriteAsPropertyName(Utf8JsonWriter writer, [DisallowNull] T value, JsonSerializerOptions options)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException("value");
			}
			this.WriteAsPropertyNameCore(writer, value, options, false);
		}

		// Token: 0x06000D0D RID: 3341 RVA: 0x00032D3C File Offset: 0x00030F3C
		public sealed override T ReadAsPropertyName(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.PropertyName)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedPropertyName(reader.TokenType);
			}
			return this.ReadAsPropertyNameCore(ref reader, typeToConvert, options);
		}

		// Token: 0x06000D0E RID: 3342 RVA: 0x00032D5C File Offset: 0x00030F5C
		private protected unsafe static JsonSchema GetSchemaForNumericType(JsonSchemaType schemaType, JsonNumberHandling numberHandling, bool isIeeeFloatingPoint = false)
		{
			string pattern = null;
			if ((numberHandling & (JsonNumberHandling.AllowReadingFromString | JsonNumberHandling.WriteAsString)) != JsonNumberHandling.Strict)
			{
				pattern = ((schemaType == JsonSchemaType.Integer) ? "^-?(?:0|[1-9]\\d*)$" : (isIeeeFloatingPoint ? "^-?(?:0|[1-9]\\d*)(?:\\.\\d+)?(?:[eE][+-]?\\d+)?$" : "^-?(?:0|[1-9]\\d*)(?:\\.\\d+)?$"));
				schemaType |= JsonSchemaType.String;
			}
			if (isIeeeFloatingPoint && (numberHandling & JsonNumberHandling.AllowNamedFloatingPointLiterals) != JsonNumberHandling.Strict)
			{
				JsonSchema jsonSchema = new JsonSchema();
				int num = 2;
				List<JsonSchema> list = new List<JsonSchema>(num);
				CollectionsMarshal.SetCount<JsonSchema>(list, num);
				Span<JsonSchema> span = CollectionsMarshal.AsSpan<JsonSchema>(list);
				int num2 = 0;
				*span[num2] = new JsonSchema
				{
					Type = schemaType,
					Pattern = pattern
				};
				num2++;
				*span[num2] = new JsonSchema
				{
					Enum = new JsonArray(null)
					{
						"NaN",
						"Infinity",
						"-Infinity"
					}
				};
				num2++;
				jsonSchema.AnyOf = list;
				return jsonSchema;
			}
			return new JsonSchema
			{
				Type = schemaType,
				Pattern = pattern
			};
		}
	}
}
