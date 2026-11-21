using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000143 RID: 323
	internal sealed class Int16Converter : JsonPrimitiveConverter<short>
	{
		// Token: 0x06000E6B RID: 3691 RVA: 0x00037D21 File Offset: 0x00035F21
		public Int16Converter()
		{
			base.IsInternalConverterForNumberType = true;
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00037D30 File Offset: 0x00035F30
		public override short Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetInt16();
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00037D38 File Offset: 0x00035F38
		public override void Write(Utf8JsonWriter writer, short value, JsonSerializerOptions options)
		{
			writer.WriteNumberValue((long)value);
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00037D42 File Offset: 0x00035F42
		internal override short ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetInt16WithQuotes();
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00036D65 File Offset: 0x00034F65
		internal override void WriteAsPropertyNameCore(Utf8JsonWriter writer, short value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			writer.WritePropertyName((int)value);
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x00037D4A File Offset: 0x00035F4A
		internal override short ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.String && (JsonNumberHandling.AllowReadingFromString & handling) != JsonNumberHandling.Strict)
			{
				return reader.GetInt16WithQuotes();
			}
			return reader.GetInt16();
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00037D67 File Offset: 0x00035F67
		internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, short value, JsonNumberHandling handling)
		{
			if ((JsonNumberHandling.WriteAsString & handling) != JsonNumberHandling.Strict)
			{
				writer.WriteNumberValueAsString((long)value);
				return;
			}
			writer.WriteNumberValue((long)value);
		}

		// Token: 0x06000E72 RID: 3698 RVA: 0x00037D7F File Offset: 0x00035F7F
		internal override JsonSchema GetSchema(JsonNumberHandling numberHandling)
		{
			return JsonPrimitiveConverter<short>.GetSchemaForNumericType(JsonSchemaType.Integer, numberHandling, false);
		}
	}
}
