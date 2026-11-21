using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000137 RID: 311
	internal sealed class ByteConverter : JsonPrimitiveConverter<byte>
	{
		// Token: 0x06000E1C RID: 3612 RVA: 0x00036D3D File Offset: 0x00034F3D
		public ByteConverter()
		{
			base.IsInternalConverterForNumberType = true;
		}

		// Token: 0x06000E1D RID: 3613 RVA: 0x00036D4C File Offset: 0x00034F4C
		public override byte Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetByte();
		}

		// Token: 0x06000E1E RID: 3614 RVA: 0x00036D54 File Offset: 0x00034F54
		public override void Write(Utf8JsonWriter writer, byte value, JsonSerializerOptions options)
		{
			writer.WriteNumberValue((int)value);
		}

		// Token: 0x06000E1F RID: 3615 RVA: 0x00036D5D File Offset: 0x00034F5D
		internal override byte ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetByteWithQuotes();
		}

		// Token: 0x06000E20 RID: 3616 RVA: 0x00036D65 File Offset: 0x00034F65
		internal override void WriteAsPropertyNameCore(Utf8JsonWriter writer, byte value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			writer.WritePropertyName((int)value);
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00036D6E File Offset: 0x00034F6E
		internal override byte ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.String && (JsonNumberHandling.AllowReadingFromString & handling) != JsonNumberHandling.Strict)
			{
				return reader.GetByteWithQuotes();
			}
			return reader.GetByte();
		}

		// Token: 0x06000E22 RID: 3618 RVA: 0x00036D8B File Offset: 0x00034F8B
		internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, byte value, JsonNumberHandling handling)
		{
			if ((JsonNumberHandling.WriteAsString & handling) != JsonNumberHandling.Strict)
			{
				writer.WriteNumberValueAsString((long)((ulong)value));
				return;
			}
			writer.WriteNumberValue((int)value);
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x00036DA2 File Offset: 0x00034FA2
		internal override JsonSchema GetSchema(JsonNumberHandling numberHandling)
		{
			return JsonPrimitiveConverter<byte>.GetSchemaForNumericType(JsonSchemaType.Integer, numberHandling, false);
		}
	}
}
