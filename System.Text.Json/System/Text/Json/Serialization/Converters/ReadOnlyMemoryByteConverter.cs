using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x020000FF RID: 255
	internal sealed class ReadOnlyMemoryByteConverter : JsonConverter<ReadOnlyMemory<byte>>
	{
		// Token: 0x170002F4 RID: 756
		// (get) Token: 0x06000D02 RID: 3330 RVA: 0x00003363 File Offset: 0x00001563
		public override bool HandleNull
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000D03 RID: 3331 RVA: 0x00032CA8 File Offset: 0x00030EA8
		public override ReadOnlyMemory<byte> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return (reader.TokenType == JsonTokenType.Null) ? null : reader.GetBytesFromBase64();
		}

		// Token: 0x06000D04 RID: 3332 RVA: 0x00032CC2 File Offset: 0x00030EC2
		public override void Write(Utf8JsonWriter writer, ReadOnlyMemory<byte> value, JsonSerializerOptions options)
		{
			writer.WriteBase64StringValue(value.Span);
		}

		// Token: 0x06000D05 RID: 3333 RVA: 0x00032CD1 File Offset: 0x00030ED1
		internal override JsonSchema GetSchema(JsonNumberHandling _)
		{
			return new JsonSchema
			{
				Type = JsonSchemaType.String
			};
		}
	}
}
