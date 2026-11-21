using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000145 RID: 325
	internal sealed class Int64Converter : JsonPrimitiveConverter<long>
	{
		// Token: 0x06000E7B RID: 3707 RVA: 0x00037DCF File Offset: 0x00035FCF
		public Int64Converter()
		{
			base.IsInternalConverterForNumberType = true;
		}

		// Token: 0x06000E7C RID: 3708 RVA: 0x00037DDE File Offset: 0x00035FDE
		public override long Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetInt64();
		}

		// Token: 0x06000E7D RID: 3709 RVA: 0x00037DE6 File Offset: 0x00035FE6
		public override void Write(Utf8JsonWriter writer, long value, JsonSerializerOptions options)
		{
			writer.WriteNumberValue(value);
		}

		// Token: 0x06000E7E RID: 3710 RVA: 0x00037DEF File Offset: 0x00035FEF
		internal override long ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetInt64WithQuotes();
		}

		// Token: 0x06000E7F RID: 3711 RVA: 0x00037DF7 File Offset: 0x00035FF7
		internal override void WriteAsPropertyNameCore(Utf8JsonWriter writer, long value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			writer.WritePropertyName(value);
		}

		// Token: 0x06000E80 RID: 3712 RVA: 0x00037E00 File Offset: 0x00036000
		internal override long ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.String && (JsonNumberHandling.AllowReadingFromString & handling) != JsonNumberHandling.Strict)
			{
				return reader.GetInt64WithQuotes();
			}
			return reader.GetInt64();
		}

		// Token: 0x06000E81 RID: 3713 RVA: 0x00037E1D File Offset: 0x0003601D
		internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, long value, JsonNumberHandling handling)
		{
			if ((JsonNumberHandling.WriteAsString & handling) != JsonNumberHandling.Strict)
			{
				writer.WriteNumberValueAsString(value);
				return;
			}
			writer.WriteNumberValue(value);
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00037E33 File Offset: 0x00036033
		internal override JsonSchema GetSchema(JsonNumberHandling numberHandling)
		{
			return JsonPrimitiveConverter<long>.GetSchemaForNumericType(JsonSchemaType.Integer, numberHandling, false);
		}
	}
}
