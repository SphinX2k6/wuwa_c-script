using System;
using System.Globalization;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000157 RID: 343
	internal sealed class DateOnlyConverter : JsonPrimitiveConverter<DateOnly>
	{
		// Token: 0x06000F01 RID: 3841 RVA: 0x00038C33 File Offset: 0x00036E33
		public override DateOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.String)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedString(reader.TokenType);
			}
			return DateOnlyConverter.ReadCore(ref reader);
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x00038C4F File Offset: 0x00036E4F
		internal override DateOnly ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return DateOnlyConverter.ReadCore(ref reader);
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x00038C58 File Offset: 0x00036E58
		private unsafe static DateOnly ReadCore(ref Utf8JsonReader reader)
		{
			if (!JsonHelpers.IsInRangeInclusive(reader.ValueLength, 10, 60))
			{
				ThrowHelper.ThrowFormatException(DataType.DateOnly);
			}
			ReadOnlySpan<byte> source;
			if (!reader.HasValueSequence && !reader.ValueIsEscaped)
			{
				source = reader.ValueSpan;
			}
			else
			{
				Span<byte> utf8Destination = new Span<byte>(stackalloc byte[(UIntPtr)60], 60);
				int length = reader.CopyString(utf8Destination);
				source = utf8Destination.Slice(0, length);
			}
			DateOnly result;
			if (!JsonHelpers.TryParseAsIso(source, out result))
			{
				ThrowHelper.ThrowFormatException(DataType.DateOnly);
			}
			return result;
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00038CCC File Offset: 0x00036ECC
		public unsafe override void Write(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options)
		{
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)10], 10);
			int num;
			value.TryFormat(span, out num, "O", CultureInfo.InvariantCulture);
			writer.WriteStringValue(span);
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00038D0C File Offset: 0x00036F0C
		internal unsafe override void WriteAsPropertyNameCore(Utf8JsonWriter writer, DateOnly value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)10], 10);
			int num;
			value.TryFormat(span, out num, "O", CultureInfo.InvariantCulture);
			writer.WritePropertyName(span);
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00038D4C File Offset: 0x00036F4C
		internal override JsonSchema GetSchema(JsonNumberHandling _)
		{
			return new JsonSchema
			{
				Type = JsonSchemaType.String,
				Format = "date"
			};
		}
	}
}
