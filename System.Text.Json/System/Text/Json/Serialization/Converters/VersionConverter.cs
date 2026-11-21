using System;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000154 RID: 340
	internal sealed class VersionConverter : JsonPrimitiveConverter<Version>
	{
		// Token: 0x06000EE2 RID: 3810 RVA: 0x000386D1 File Offset: 0x000368D1
		public override Version Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.Null)
			{
				return null;
			}
			if (reader.TokenType != JsonTokenType.String)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedString(reader.TokenType);
			}
			return VersionConverter.ReadCore(ref reader);
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x000386FC File Offset: 0x000368FC
		private unsafe static Version ReadCore(ref Utf8JsonReader reader)
		{
			if (!JsonHelpers.IsInRangeInclusive(reader.ValueLength, 3, 258))
			{
				ThrowHelper.ThrowFormatException(DataType.Version);
			}
			Span<char> destination = new Span<char>(stackalloc byte[(UIntPtr)516], 258);
			int length = reader.CopyString(destination);
			ReadOnlySpan<char> input = destination.Slice(0, length);
			if (!char.IsDigit((char)(*input[0])) || !char.IsDigit((char)(*input[input.Length - 1])))
			{
				ThrowHelper.ThrowFormatException(DataType.Version);
			}
			Version result;
			if (Version.TryParse(input, out result))
			{
				return result;
			}
			ThrowHelper.ThrowJsonException(null);
			return null;
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x0003878C File Offset: 0x0003698C
		public unsafe override void Write(Utf8JsonWriter writer, Version value, JsonSerializerOptions options)
		{
			if (value == null)
			{
				writer.WriteNullValue();
				return;
			}
			Span<byte> utf8Destination = new Span<byte>(stackalloc byte[(UIntPtr)43], 43);
			int length;
			value.TryFormat(utf8Destination, out length);
			writer.WriteStringValue(utf8Destination.Slice(0, length));
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x000387CE File Offset: 0x000369CE
		internal override Version ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return VersionConverter.ReadCore(ref reader);
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x000387D8 File Offset: 0x000369D8
		internal unsafe override void WriteAsPropertyNameCore(Utf8JsonWriter writer, Version value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException("value");
			}
			Span<byte> utf8Destination = new Span<byte>(stackalloc byte[(UIntPtr)43], 43);
			int length;
			value.TryFormat(utf8Destination, out length);
			writer.WritePropertyName(utf8Destination.Slice(0, length));
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x0003881D File Offset: 0x00036A1D
		internal override JsonSchema GetSchema(JsonNumberHandling _)
		{
			return new JsonSchema
			{
				Type = JsonSchemaType.String,
				Comment = "Represents a version string.",
				Pattern = "^\\d+(\\.\\d+){1,3}$"
			};
		}
	}
}
