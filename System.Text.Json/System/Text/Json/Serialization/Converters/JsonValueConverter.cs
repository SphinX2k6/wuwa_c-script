using System;
using System.Text.Json.Nodes;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x0200012C RID: 300
	internal sealed class JsonValueConverter : JsonConverter<JsonValue>
	{
		// Token: 0x06000DE0 RID: 3552 RVA: 0x0003501C File Offset: 0x0003321C
		public override void Write(Utf8JsonWriter writer, JsonValue value, JsonSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNullValue();
				return;
			}
			value.WriteTo(writer, options);
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x0003530C File Offset: 0x0003350C
		public override JsonValue Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.Null)
			{
				return null;
			}
			JsonElement jsonElement = JsonElement.ParseValue(ref reader);
			return JsonValue.CreateFromElement(ref jsonElement, new JsonNodeOptions?(options.GetNodeOptions()));
		}

		// Token: 0x06000DE2 RID: 3554 RVA: 0x000351AA File Offset: 0x000333AA
		internal override JsonSchema GetSchema(JsonNumberHandling _)
		{
			return JsonSchema.CreateTrueSchema();
		}
	}
}
