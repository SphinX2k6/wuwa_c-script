using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x0200014C RID: 332
	internal sealed class StringConverter : JsonPrimitiveConverter<string>
	{
		// Token: 0x06000EAD RID: 3757 RVA: 0x000381F3 File Offset: 0x000363F3
		public override string Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetString();
		}

		// Token: 0x06000EAE RID: 3758 RVA: 0x000381FB File Offset: 0x000363FB
		public override void Write(Utf8JsonWriter writer, string value, JsonSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNullValue();
				return;
			}
			writer.WriteStringValue(value.AsSpan());
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x000381F3 File Offset: 0x000363F3
		internal override string ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return reader.GetString();
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00038213 File Offset: 0x00036413
		internal override void WriteAsPropertyNameCore(Utf8JsonWriter writer, string value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException("value");
			}
			if (options.DictionaryKeyPolicy != null && !isWritingExtensionDataProperty)
			{
				value = options.DictionaryKeyPolicy.ConvertName(value);
				if (value == null)
				{
					ThrowHelper.ThrowInvalidOperationException_NamingPolicyReturnNull(options.DictionaryKeyPolicy);
				}
			}
			writer.WritePropertyName(value);
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00032CD1 File Offset: 0x00030ED1
		internal override JsonSchema GetSchema(JsonNumberHandling _)
		{
			return new JsonSchema
			{
				Type = JsonSchemaType.String
			};
		}
	}
}
