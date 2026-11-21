using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000100 RID: 256
	internal sealed class MemoryByteConverter : JsonConverter<Memory<byte>>
	{
		// Token: 0x170002F5 RID: 757
		// (get) Token: 0x06000D07 RID: 3335 RVA: 0x00003363 File Offset: 0x00001563
		public override bool HandleNull
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000D08 RID: 3336 RVA: 0x00032CE8 File Offset: 0x00030EE8
		public override Memory<byte> Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return (reader.TokenType == JsonTokenType.Null) ? null : reader.GetBytesFromBase64();
		}

		// Token: 0x06000D09 RID: 3337 RVA: 0x00032D02 File Offset: 0x00030F02
		public override void Write(Utf8JsonWriter writer, Memory<byte> value, JsonSerializerOptions options)
		{
			writer.WriteBase64StringValue(value.Span);
		}

		// Token: 0x06000D0A RID: 3338 RVA: 0x00032CD1 File Offset: 0x00030ED1
		internal override JsonSchema GetSchema(JsonNumberHandling _)
		{
			return new JsonSchema
			{
				Type = JsonSchemaType.String
			};
		}
	}
}
