using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x0200014A RID: 330
	internal sealed class SByteConverter : JsonPrimitiveConverter<sbyte>
	{
		// Token: 0x06000E9D RID: 3741 RVA: 0x0003810F File Offset: 0x0003630F
		public SByteConverter()
		{
			base.IsInternalConverterForNumberType = true;
		}

		// Token: 0x06000E9E RID: 3742 RVA: 0x0003811E File Offset: 0x0003631E
		public override sbyte Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetSByte();
		}

		// Token: 0x06000E9F RID: 3743 RVA: 0x00036D54 File Offset: 0x00034F54
		public override void Write(Utf8JsonWriter writer, sbyte value, JsonSerializerOptions options)
		{
			writer.WriteNumberValue((int)value);
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00038126 File Offset: 0x00036326
		internal override sbyte ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetSByteWithQuotes();
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00036D65 File Offset: 0x00034F65
		internal override void WriteAsPropertyNameCore(Utf8JsonWriter writer, sbyte value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			writer.WritePropertyName((int)value);
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x0003812E File Offset: 0x0003632E
		internal override sbyte ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.String && (JsonNumberHandling.AllowReadingFromString & handling) != JsonNumberHandling.Strict)
			{
				return reader.GetSByteWithQuotes();
			}
			return reader.GetSByte();
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x0003814B File Offset: 0x0003634B
		internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, sbyte value, JsonNumberHandling handling)
		{
			if ((JsonNumberHandling.WriteAsString & handling) != JsonNumberHandling.Strict)
			{
				writer.WriteNumberValueAsString((long)value);
				return;
			}
			writer.WriteNumberValue((int)value);
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x00038162 File Offset: 0x00036362
		internal override JsonSchema GetSchema(JsonNumberHandling numberHandling)
		{
			return JsonPrimitiveConverter<sbyte>.GetSchemaForNumericType(JsonSchemaType.Integer, numberHandling, false);
		}
	}
}
