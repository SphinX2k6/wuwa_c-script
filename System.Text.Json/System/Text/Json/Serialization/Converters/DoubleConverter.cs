using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x0200013C RID: 316
	internal sealed class DoubleConverter : JsonPrimitiveConverter<double>
	{
		// Token: 0x06000E3E RID: 3646 RVA: 0x00036F54 File Offset: 0x00035154
		public DoubleConverter()
		{
			base.IsInternalConverterForNumberType = true;
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x00036F63 File Offset: 0x00035163
		public override double Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetDouble();
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x00036F6B File Offset: 0x0003516B
		public override void Write(Utf8JsonWriter writer, double value, JsonSerializerOptions options)
		{
			writer.WriteNumberValue(value);
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x00036F74 File Offset: 0x00035174
		internal override double ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetDoubleWithQuotes();
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x00036F7C File Offset: 0x0003517C
		internal override void WriteAsPropertyNameCore(Utf8JsonWriter writer, double value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			writer.WritePropertyName(value);
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x00036F85 File Offset: 0x00035185
		internal override double ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.String)
			{
				if ((JsonNumberHandling.AllowReadingFromString & handling) != JsonNumberHandling.Strict)
				{
					return reader.GetDoubleWithQuotes();
				}
				if ((JsonNumberHandling.AllowNamedFloatingPointLiterals & handling) != JsonNumberHandling.Strict)
				{
					return reader.GetDoubleFloatingPointConstant();
				}
			}
			return reader.GetDouble();
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x00036FAE File Offset: 0x000351AE
		internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, double value, JsonNumberHandling handling)
		{
			if ((JsonNumberHandling.WriteAsString & handling) != JsonNumberHandling.Strict)
			{
				writer.WriteNumberValueAsString(value);
				return;
			}
			if ((JsonNumberHandling.AllowNamedFloatingPointLiterals & handling) != JsonNumberHandling.Strict)
			{
				writer.WriteFloatingPointConstant(value);
				return;
			}
			writer.WriteNumberValue(value);
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x00036FD1 File Offset: 0x000351D1
		internal override JsonSchema GetSchema(JsonNumberHandling numberHandling)
		{
			return JsonPrimitiveConverter<double>.GetSchemaForNumericType(JsonSchemaType.Number, numberHandling, true);
		}
	}
}
