using System;
using System.Text.Json.Nodes;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000128 RID: 296
	internal sealed class JsonNodeConverter : JsonConverter<JsonNode>
	{
		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000DCB RID: 3531 RVA: 0x00035093 File Offset: 0x00033293
		public static JsonNodeConverter Instance
		{
			get
			{
				JsonNodeConverter result;
				if ((result = JsonNodeConverter.s_nodeConverter) == null)
				{
					result = (JsonNodeConverter.s_nodeConverter = new JsonNodeConverter());
				}
				return result;
			}
		}

		// Token: 0x17000321 RID: 801
		// (get) Token: 0x06000DCC RID: 3532 RVA: 0x000350A9 File Offset: 0x000332A9
		public static JsonArrayConverter ArrayConverter
		{
			get
			{
				JsonArrayConverter result;
				if ((result = JsonNodeConverter.s_arrayConverter) == null)
				{
					result = (JsonNodeConverter.s_arrayConverter = new JsonArrayConverter());
				}
				return result;
			}
		}

		// Token: 0x17000322 RID: 802
		// (get) Token: 0x06000DCD RID: 3533 RVA: 0x000350BF File Offset: 0x000332BF
		public static JsonObjectConverter ObjectConverter
		{
			get
			{
				JsonObjectConverter result;
				if ((result = JsonNodeConverter.s_objectConverter) == null)
				{
					result = (JsonNodeConverter.s_objectConverter = new JsonObjectConverter());
				}
				return result;
			}
		}

		// Token: 0x17000323 RID: 803
		// (get) Token: 0x06000DCE RID: 3534 RVA: 0x000350D5 File Offset: 0x000332D5
		public static JsonValueConverter ValueConverter
		{
			get
			{
				JsonValueConverter result;
				if ((result = JsonNodeConverter.s_valueConverter) == null)
				{
					result = (JsonNodeConverter.s_valueConverter = new JsonValueConverter());
				}
				return result;
			}
		}

		// Token: 0x06000DCF RID: 3535 RVA: 0x0003501C File Offset: 0x0003321C
		public override void Write(Utf8JsonWriter writer, JsonNode value, JsonSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNullValue();
				return;
			}
			value.WriteTo(writer, options);
		}

		// Token: 0x06000DD0 RID: 3536 RVA: 0x000350EC File Offset: 0x000332EC
		public override JsonNode Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			switch (reader.TokenType)
			{
			case JsonTokenType.StartObject:
				return JsonNodeConverter.ObjectConverter.Read(ref reader, typeToConvert, options);
			case JsonTokenType.StartArray:
				return JsonNodeConverter.ArrayConverter.Read(ref reader, typeToConvert, options);
			case JsonTokenType.String:
			case JsonTokenType.Number:
			case JsonTokenType.True:
			case JsonTokenType.False:
				return JsonNodeConverter.ValueConverter.Read(ref reader, typeToConvert, options);
			case JsonTokenType.Null:
				return null;
			}
			throw new JsonException();
		}

		// Token: 0x06000DD1 RID: 3537 RVA: 0x00035168 File Offset: 0x00033368
		public static JsonNode Create(JsonElement element, JsonNodeOptions? options)
		{
			JsonValueKind valueKind = element.ValueKind;
			JsonNode result;
			if (valueKind != JsonValueKind.Object)
			{
				if (valueKind != JsonValueKind.Array)
				{
					if (valueKind == JsonValueKind.Null)
					{
						result = null;
					}
					else
					{
						result = new JsonValueOfElement(element, options);
					}
				}
				else
				{
					result = new JsonArray(element, options);
				}
			}
			else
			{
				result = new JsonObject(element, options);
			}
			return result;
		}

		// Token: 0x06000DD2 RID: 3538 RVA: 0x000351AA File Offset: 0x000333AA
		internal override JsonSchema GetSchema(JsonNumberHandling _)
		{
			return JsonSchema.CreateTrueSchema();
		}

		// Token: 0x0400044A RID: 1098
		private static JsonNodeConverter s_nodeConverter;

		// Token: 0x0400044B RID: 1099
		private static JsonArrayConverter s_arrayConverter;

		// Token: 0x0400044C RID: 1100
		private static JsonObjectConverter s_objectConverter;

		// Token: 0x0400044D RID: 1101
		private static JsonValueConverter s_valueConverter;
	}
}
