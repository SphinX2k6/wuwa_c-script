using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000136 RID: 310
	internal sealed class ByteArrayConverter : JsonConverter<byte[]>
	{
		// Token: 0x06000E18 RID: 3608 RVA: 0x00036D09 File Offset: 0x00034F09
		public override byte[] Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.Null)
			{
				return null;
			}
			return reader.GetBytesFromBase64();
		}

		// Token: 0x06000E19 RID: 3609 RVA: 0x00036D1D File Offset: 0x00034F1D
		public override void Write(Utf8JsonWriter writer, byte[] value, JsonSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNullValue();
				return;
			}
			writer.WriteBase64StringValue(value);
		}

		// Token: 0x06000E1A RID: 3610 RVA: 0x00032CD1 File Offset: 0x00030ED1
		internal override JsonSchema GetSchema(JsonNumberHandling _)
		{
			return new JsonSchema
			{
				Type = JsonSchemaType.String
			};
		}
	}
}
