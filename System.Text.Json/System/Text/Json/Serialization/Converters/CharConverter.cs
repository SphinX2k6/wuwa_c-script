using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000138 RID: 312
	internal sealed class CharConverter : JsonPrimitiveConverter<char>
	{
		// Token: 0x06000E24 RID: 3620 RVA: 0x00036DAC File Offset: 0x00034FAC
		public unsafe override char Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			JsonTokenType tokenType = reader.TokenType;
			if (tokenType != JsonTokenType.PropertyName && tokenType != JsonTokenType.String)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedString(reader.TokenType);
			}
			if (!JsonHelpers.IsInRangeInclusive(reader.ValueLength, 1, 6))
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedChar(reader.TokenType);
			}
			Span<char> destination = new Span<char>(stackalloc byte[(UIntPtr)12], 6);
			if (reader.CopyString(destination) != 1)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedChar(reader.TokenType);
			}
			return *destination[0];
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00036E20 File Offset: 0x00035020
		public override void Write(Utf8JsonWriter writer, char value, JsonSerializerOptions options)
		{
			writer.WriteStringValue(new ReadOnlySpan<char>(ref value));
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x00036E2F File Offset: 0x0003502F
		internal override char ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return this.Read(ref reader, typeToConvert, options);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x00036E3A File Offset: 0x0003503A
		internal override void WriteAsPropertyNameCore(Utf8JsonWriter writer, char value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			writer.WritePropertyName(new ReadOnlySpan<char>(ref value));
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x00036E49 File Offset: 0x00035049
		internal override JsonSchema GetSchema(JsonNumberHandling _)
		{
			return new JsonSchema
			{
				Type = JsonSchemaType.String,
				MinLength = new int?(1),
				MaxLength = new int?(1)
			};
		}
	}
}
