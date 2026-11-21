using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x0200013A RID: 314
	internal sealed class DateTimeOffsetConverter : JsonPrimitiveConverter<DateTimeOffset>
	{
		// Token: 0x06000E30 RID: 3632 RVA: 0x00036EBC File Offset: 0x000350BC
		public override DateTimeOffset Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetDateTimeOffset();
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x00036EC4 File Offset: 0x000350C4
		public override void Write(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value);
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x00036ECD File Offset: 0x000350CD
		internal override DateTimeOffset ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetDateTimeOffsetNoValidation();
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x00036ED5 File Offset: 0x000350D5
		internal override void WriteAsPropertyNameCore(Utf8JsonWriter writer, DateTimeOffset value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			writer.WritePropertyName(value);
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x00036E9A File Offset: 0x0003509A
		internal override JsonSchema GetSchema(JsonNumberHandling _)
		{
			return new JsonSchema
			{
				Type = JsonSchemaType.String,
				Format = "date-time"
			};
		}
	}
}
