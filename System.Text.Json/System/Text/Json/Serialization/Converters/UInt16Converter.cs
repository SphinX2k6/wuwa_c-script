using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x0200014E RID: 334
	internal sealed class UInt16Converter : JsonPrimitiveConverter<ushort>
	{
		// Token: 0x06000EBA RID: 3770 RVA: 0x000383D8 File Offset: 0x000365D8
		public UInt16Converter()
		{
			base.IsInternalConverterForNumberType = true;
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x000383E7 File Offset: 0x000365E7
		public override ushort Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetUInt16();
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x000383EF File Offset: 0x000365EF
		public override void Write(Utf8JsonWriter writer, ushort value, JsonSerializerOptions options)
		{
			writer.WriteNumberValue((long)((ulong)value));
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x000383F9 File Offset: 0x000365F9
		internal override ushort ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetUInt16WithQuotes();
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x00036D65 File Offset: 0x00034F65
		internal override void WriteAsPropertyNameCore(Utf8JsonWriter writer, ushort value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			writer.WritePropertyName((int)value);
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x00038401 File Offset: 0x00036601
		internal override ushort ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.String && (JsonNumberHandling.AllowReadingFromString & handling) != JsonNumberHandling.Strict)
			{
				return reader.GetUInt16WithQuotes();
			}
			return reader.GetUInt16();
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x0003841E File Offset: 0x0003661E
		internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, ushort value, JsonNumberHandling handling)
		{
			if ((JsonNumberHandling.WriteAsString & handling) != JsonNumberHandling.Strict)
			{
				writer.WriteNumberValueAsString((long)((ulong)value));
				return;
			}
			writer.WriteNumberValue((long)((ulong)value));
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x00038436 File Offset: 0x00036636
		internal override JsonSchema GetSchema(JsonNumberHandling numberHandling)
		{
			return JsonPrimitiveConverter<ushort>.GetSchemaForNumericType(JsonSchemaType.Integer, numberHandling, false);
		}
	}
}
