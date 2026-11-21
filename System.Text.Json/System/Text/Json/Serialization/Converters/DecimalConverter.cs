using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x0200013B RID: 315
	internal sealed class DecimalConverter : JsonPrimitiveConverter<decimal>
	{
		// Token: 0x06000E36 RID: 3638 RVA: 0x00036EE6 File Offset: 0x000350E6
		public DecimalConverter()
		{
			base.IsInternalConverterForNumberType = true;
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00036EF5 File Offset: 0x000350F5
		public override decimal Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetDecimal();
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x00036EFD File Offset: 0x000350FD
		public override void Write(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options)
		{
			writer.WriteNumberValue(value);
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00036F06 File Offset: 0x00035106
		internal override decimal ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetDecimalWithQuotes();
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00036F0E File Offset: 0x0003510E
		internal override void WriteAsPropertyNameCore(Utf8JsonWriter writer, decimal value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			writer.WritePropertyName(value);
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x00036F17 File Offset: 0x00035117
		internal override decimal ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.String && (JsonNumberHandling.AllowReadingFromString & handling) != JsonNumberHandling.Strict)
			{
				return reader.GetDecimalWithQuotes();
			}
			return reader.GetDecimal();
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x00036F34 File Offset: 0x00035134
		internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, decimal value, JsonNumberHandling handling)
		{
			if ((JsonNumberHandling.WriteAsString & handling) != JsonNumberHandling.Strict)
			{
				writer.WriteNumberValueAsString(value);
				return;
			}
			writer.WriteNumberValue(value);
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x00036F4A File Offset: 0x0003514A
		internal override JsonSchema GetSchema(JsonNumberHandling numberHandling)
		{
			return JsonPrimitiveConverter<decimal>.GetSchemaForNumericType(JsonSchemaType.Number, numberHandling, false);
		}
	}
}
