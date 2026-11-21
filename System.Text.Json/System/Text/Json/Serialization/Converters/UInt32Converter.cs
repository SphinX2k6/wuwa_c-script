using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x0200014F RID: 335
	internal sealed class UInt32Converter : JsonPrimitiveConverter<uint>
	{
		// Token: 0x06000EC2 RID: 3778 RVA: 0x00038440 File Offset: 0x00036640
		public UInt32Converter()
		{
			base.IsInternalConverterForNumberType = true;
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x0003844F File Offset: 0x0003664F
		public override uint Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetUInt32();
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x00038457 File Offset: 0x00036657
		public override void Write(Utf8JsonWriter writer, uint value, JsonSerializerOptions options)
		{
			writer.WriteNumberValue((ulong)value);
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00038461 File Offset: 0x00036661
		internal override uint ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetUInt32WithQuotes();
		}

		// Token: 0x06000EC6 RID: 3782 RVA: 0x00038469 File Offset: 0x00036669
		internal override void WriteAsPropertyNameCore(Utf8JsonWriter writer, uint value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			writer.WritePropertyName(value);
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x00038472 File Offset: 0x00036672
		internal override uint ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.String && (JsonNumberHandling.AllowReadingFromString & handling) != JsonNumberHandling.Strict)
			{
				return reader.GetUInt32WithQuotes();
			}
			return reader.GetUInt32();
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x0003848F File Offset: 0x0003668F
		internal override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, uint value, JsonNumberHandling handling)
		{
			if ((JsonNumberHandling.WriteAsString & handling) != JsonNumberHandling.Strict)
			{
				writer.WriteNumberValueAsString((long)((ulong)value));
				return;
			}
			writer.WriteNumberValue((ulong)value);
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x000384A7 File Offset: 0x000366A7
		internal override JsonSchema GetSchema(JsonNumberHandling numberHandling)
		{
			return JsonPrimitiveConverter<uint>.GetSchemaForNumericType(JsonSchemaType.Integer, numberHandling, false);
		}
	}
}
