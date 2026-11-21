using System;
using System.Text.Json.Nodes;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000127 RID: 295
	internal sealed class JsonArrayConverter : JsonConverter<JsonArray>
	{
		// Token: 0x06000DC6 RID: 3526 RVA: 0x0003501C File Offset: 0x0003321C
		public override void Write(Utf8JsonWriter writer, JsonArray value, JsonSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNullValue();
				return;
			}
			value.WriteTo(writer, options);
		}

		// Token: 0x06000DC7 RID: 3527 RVA: 0x00035030 File Offset: 0x00033230
		public override JsonArray Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			JsonTokenType tokenType = reader.TokenType;
			if (tokenType == JsonTokenType.StartArray)
			{
				return JsonArrayConverter.ReadList(ref reader, new JsonNodeOptions?(options.GetNodeOptions()));
			}
			if (tokenType != JsonTokenType.Null)
			{
				throw ThrowHelper.GetInvalidOperationException_ExpectedArray(reader.TokenType);
			}
			return null;
		}

		// Token: 0x06000DC8 RID: 3528 RVA: 0x0003506E File Offset: 0x0003326E
		public static JsonArray ReadList(ref Utf8JsonReader reader, JsonNodeOptions? options = null)
		{
			return new JsonArray(JsonElement.ParseValue(ref reader), options);
		}

		// Token: 0x06000DC9 RID: 3529 RVA: 0x0003507C File Offset: 0x0003327C
		internal override JsonSchema GetSchema(JsonNumberHandling _)
		{
			return new JsonSchema
			{
				Type = JsonSchemaType.Array
			};
		}
	}
}
