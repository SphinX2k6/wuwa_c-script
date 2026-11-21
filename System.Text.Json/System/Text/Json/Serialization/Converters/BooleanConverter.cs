using System;
using System.Buffers.Text;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000135 RID: 309
	internal sealed class BooleanConverter : JsonPrimitiveConverter<bool>
	{
		// Token: 0x06000E12 RID: 3602 RVA: 0x00036CA7 File Offset: 0x00034EA7
		public override bool Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetBoolean();
		}

		// Token: 0x06000E13 RID: 3603 RVA: 0x00036CAF File Offset: 0x00034EAF
		public override void Write(Utf8JsonWriter writer, bool value, JsonSerializerOptions options)
		{
			writer.WriteBooleanValue(value);
		}

		// Token: 0x06000E14 RID: 3604 RVA: 0x00036CB8 File Offset: 0x00034EB8
		internal override bool ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			ReadOnlySpan<byte> unescapedSpan = ref reader.GetUnescapedSpan();
			bool result;
			int num;
			if (!Utf8Parser.TryParse(unescapedSpan, out result, out num, '\0') || unescapedSpan.Length != num)
			{
				ThrowHelper.ThrowFormatException(DataType.Boolean);
			}
			return result;
		}

		// Token: 0x06000E15 RID: 3605 RVA: 0x00036CEA File Offset: 0x00034EEA
		internal override void WriteAsPropertyNameCore(Utf8JsonWriter writer, bool value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			writer.WritePropertyName(value);
		}

		// Token: 0x06000E16 RID: 3606 RVA: 0x00036CF3 File Offset: 0x00034EF3
		internal override JsonSchema GetSchema(JsonNumberHandling _)
		{
			return new JsonSchema
			{
				Type = JsonSchemaType.Boolean
			};
		}
	}
}
