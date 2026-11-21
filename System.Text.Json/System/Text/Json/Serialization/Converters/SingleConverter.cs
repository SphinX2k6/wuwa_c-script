using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x0200014B RID: 331
	internal sealed class SingleConverter : JsonPrimitiveConverter<float>
	{
		// Token: 0x06000EA5 RID: 3749 RVA: 0x0003816C File Offset: 0x0003636C
		public SingleConverter()
		{
			base.IsInternalConverterForNumberType = true;
		}

		// Token: 0x06000EA6 RID: 3750 RVA: 0x0003817B File Offset: 0x0003637B
		public override float Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetSingle();
		}

		// Token: 0x06000EA7 RID: 3751 RVA: 0x00038183 File Offset: 0x00036383
		public override void Write(Utf8JsonWriter writer, float value, JsonSerializerOptions options)
		{
			writer.WriteNumberValue(value);
		}

		// Token: 0x06000EA8 RID: 3752 RVA: 0x0003818C File Offset: 0x0003638C
		internal override float ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetSingleWithQuotes();
		}

		// Token: 0x06000EA9 RID: 3753 RVA: 0x00038194 File Offset: 0x00036394
		internal override void WriteAsPropertyNameCore(Utf8JsonWriter writer, float value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			writer.WritePropertyName(value);
		}

		// Token: 0x06000EAA RID: 3754 RVA: 0x0003819D File Offset: 0x0003639D
		internal override float ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.String)
			{
				if ((JsonNumberHandling.AllowReadingFromString & handling) != JsonNumberHandling.Strict)
				{
					return reader.GetSingleWithQuotes();
				}
				if ((JsonNumberHandling.AllowNamedFloatingPointLiterals & handling) != JsonNumberHandling.Strict)
				{
					return reader.GetSingleFloatingPointConstant();
				}
			}
			return reader.GetSingle();
		}

		// Token: 0x06000EAB RID: 3755 RVA: 0x000381C6 File Offset: 0x000363C6
		internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, float value, JsonNumberHandling handling)
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

		// Token: 0x06000EAC RID: 3756 RVA: 0x000381E9 File Offset: 0x000363E9
		internal override JsonSchema GetSchema(JsonNumberHandling numberHandling)
		{
			return JsonPrimitiveConverter<float>.GetSchemaForNumericType(JsonSchemaType.Number, numberHandling, true);
		}
	}
}
