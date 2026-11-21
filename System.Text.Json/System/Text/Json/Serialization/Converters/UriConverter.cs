using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000153 RID: 339
	internal sealed class UriConverter : JsonPrimitiveConverter<Uri>
	{
		// Token: 0x06000EDB RID: 3803 RVA: 0x0003863B File Offset: 0x0003683B
		public override Uri Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.Null)
			{
				return UriConverter.ReadCore(ref reader);
			}
			return null;
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x0003864F File Offset: 0x0003684F
		public override void Write(Utf8JsonWriter writer, Uri value, JsonSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNullValue();
				return;
			}
			writer.WriteStringValue(value.OriginalString);
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x00038667 File Offset: 0x00036867
		internal override Uri ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return UriConverter.ReadCore(ref reader);
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00038670 File Offset: 0x00036870
		private static Uri ReadCore(ref Utf8JsonReader reader)
		{
			Uri result;
			if (!Uri.TryCreate(reader.GetString(), UriKind.RelativeOrAbsolute, out result))
			{
				ThrowHelper.ThrowJsonException(null);
			}
			return result;
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x00038694 File Offset: 0x00036894
		internal override void WriteAsPropertyNameCore(Utf8JsonWriter writer, Uri value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException("value");
			}
			writer.WritePropertyName(value.OriginalString);
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x000386AF File Offset: 0x000368AF
		internal override JsonSchema GetSchema(JsonNumberHandling _)
		{
			return new JsonSchema
			{
				Type = JsonSchemaType.String,
				Format = "uri"
			};
		}
	}
}
