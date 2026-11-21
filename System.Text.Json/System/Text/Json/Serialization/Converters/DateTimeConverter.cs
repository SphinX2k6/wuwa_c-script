using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000139 RID: 313
	internal sealed class DateTimeConverter : JsonPrimitiveConverter<DateTime>
	{
		// Token: 0x06000E2A RID: 3626 RVA: 0x00036E78 File Offset: 0x00035078
		public override DateTime Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetDateTime();
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x00036E80 File Offset: 0x00035080
		public override void Write(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value);
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00036E89 File Offset: 0x00035089
		internal override DateTime ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetDateTimeNoValidation();
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x00036E91 File Offset: 0x00035091
		internal override void WriteAsPropertyNameCore(Utf8JsonWriter writer, DateTime value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			writer.WritePropertyName(value);
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x00036E9A File Offset: 0x0003509A
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
