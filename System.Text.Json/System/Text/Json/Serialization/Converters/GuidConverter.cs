using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000142 RID: 322
	internal sealed class GuidConverter : JsonPrimitiveConverter<Guid>
	{
		// Token: 0x06000E65 RID: 3685 RVA: 0x00037CDD File Offset: 0x00035EDD
		public override Guid Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetGuid();
		}

		// Token: 0x06000E66 RID: 3686 RVA: 0x00037CE5 File Offset: 0x00035EE5
		public override void Write(Utf8JsonWriter writer, Guid value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(value);
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x00037CEE File Offset: 0x00035EEE
		internal override Guid ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetGuidNoValidation();
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00037CF6 File Offset: 0x00035EF6
		internal override void WriteAsPropertyNameCore(Utf8JsonWriter writer, Guid value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			writer.WritePropertyName(value);
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00037CFF File Offset: 0x00035EFF
		internal override JsonSchema GetSchema(JsonNumberHandling numberHandling)
		{
			return new JsonSchema
			{
				Type = JsonSchemaType.String,
				Format = "uuid"
			};
		}
	}
}
