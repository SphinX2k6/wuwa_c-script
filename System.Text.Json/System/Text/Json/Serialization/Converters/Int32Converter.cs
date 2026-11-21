using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000144 RID: 324
	internal sealed class Int32Converter : JsonPrimitiveConverter<int>
	{
		// Token: 0x06000E73 RID: 3699 RVA: 0x00037D89 File Offset: 0x00035F89
		public Int32Converter()
		{
			base.IsInternalConverterForNumberType = true;
		}

		// Token: 0x06000E74 RID: 3700 RVA: 0x00037D98 File Offset: 0x00035F98
		public override int Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetInt32();
		}

		// Token: 0x06000E75 RID: 3701 RVA: 0x00037D38 File Offset: 0x00035F38
		public override void Write(Utf8JsonWriter writer, int value, JsonSerializerOptions options)
		{
			writer.WriteNumberValue((long)value);
		}

		// Token: 0x06000E76 RID: 3702 RVA: 0x00037DA0 File Offset: 0x00035FA0
		internal override int ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetInt32WithQuotes();
		}

		// Token: 0x06000E77 RID: 3703 RVA: 0x00036D65 File Offset: 0x00034F65
		internal override void WriteAsPropertyNameCore(Utf8JsonWriter writer, int value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			writer.WritePropertyName(value);
		}

		// Token: 0x06000E78 RID: 3704 RVA: 0x00037DA8 File Offset: 0x00035FA8
		internal override int ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.String && (JsonNumberHandling.AllowReadingFromString & handling) != JsonNumberHandling.Strict)
			{
				return reader.GetInt32WithQuotes();
			}
			return reader.GetInt32();
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00037D67 File Offset: 0x00035F67
		internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, int value, JsonNumberHandling handling)
		{
			if ((JsonNumberHandling.WriteAsString & handling) != JsonNumberHandling.Strict)
			{
				writer.WriteNumberValueAsString((long)value);
				return;
			}
			writer.WriteNumberValue((long)value);
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00037DC5 File Offset: 0x00035FC5
		internal override JsonSchema GetSchema(JsonNumberHandling numberHandling)
		{
			return JsonPrimitiveConverter<int>.GetSchemaForNumericType(JsonSchemaType.Integer, numberHandling, false);
		}
	}
}
