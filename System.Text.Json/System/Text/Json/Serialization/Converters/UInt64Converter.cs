using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000150 RID: 336
	internal sealed class UInt64Converter : JsonPrimitiveConverter<ulong>
	{
		// Token: 0x06000ECA RID: 3786 RVA: 0x000384B1 File Offset: 0x000366B1
		public UInt64Converter()
		{
			base.IsInternalConverterForNumberType = true;
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x000384C0 File Offset: 0x000366C0
		public override ulong Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetUInt64();
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x000384C8 File Offset: 0x000366C8
		public override void Write(Utf8JsonWriter writer, ulong value, JsonSerializerOptions options)
		{
			writer.WriteNumberValue(value);
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x000384D1 File Offset: 0x000366D1
		internal override ulong ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetUInt64WithQuotes();
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x000384D9 File Offset: 0x000366D9
		internal override void WriteAsPropertyNameCore(Utf8JsonWriter writer, ulong value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			writer.WritePropertyName(value);
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x000384E2 File Offset: 0x000366E2
		internal override ulong ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.String && (JsonNumberHandling.AllowReadingFromString & handling) != JsonNumberHandling.Strict)
			{
				return reader.GetUInt64WithQuotes();
			}
			return reader.GetUInt64();
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x000384FF File Offset: 0x000366FF
		internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, ulong value, JsonNumberHandling handling)
		{
			if ((JsonNumberHandling.WriteAsString & handling) != JsonNumberHandling.Strict)
			{
				writer.WriteNumberValueAsString(value);
				return;
			}
			writer.WriteNumberValue(value);
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x00038515 File Offset: 0x00036715
		internal override JsonSchema GetSchema(JsonNumberHandling numberHandling)
		{
			return JsonPrimitiveConverter<ulong>.GetSchemaForNumericType(JsonSchemaType.Integer, numberHandling, false);
		}
	}
}
