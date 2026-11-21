using System;
using System.Buffers.Text;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x0200014D RID: 333
	internal sealed class TimeSpanConverter : JsonPrimitiveConverter<TimeSpan>
	{
		// Token: 0x06000EB3 RID: 3763 RVA: 0x00038259 File Offset: 0x00036459
		public override TimeSpan Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.String)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedString(reader.TokenType);
			}
			return TimeSpanConverter.ReadCore(ref reader);
		}

		// Token: 0x06000EB4 RID: 3764 RVA: 0x00038275 File Offset: 0x00036475
		internal override TimeSpan ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return TimeSpanConverter.ReadCore(ref reader);
		}

		// Token: 0x06000EB5 RID: 3765 RVA: 0x00038280 File Offset: 0x00036480
		private unsafe static TimeSpan ReadCore(ref Utf8JsonReader reader)
		{
			if (!JsonHelpers.IsInRangeInclusive(reader.ValueLength, 1, 156))
			{
				ThrowHelper.ThrowFormatException(DataType.TimeSpan);
			}
			ReadOnlySpan<byte> source;
			if (!reader.HasValueSequence && !reader.ValueIsEscaped)
			{
				source = reader.ValueSpan;
			}
			else
			{
				Span<byte> utf8Destination = new Span<byte>(stackalloc byte[(UIntPtr)156], 156);
				int length = reader.CopyString(utf8Destination);
				source = utf8Destination.Slice(0, length);
			}
			byte b = *source[0];
			if (!JsonHelpers.IsDigit(b) && b != 45)
			{
				ThrowHelper.ThrowFormatException(DataType.TimeSpan);
			}
			TimeSpan result;
			int num;
			if (!Utf8Parser.TryParse(source, out result, out num, 'c') || source.Length != num)
			{
				ThrowHelper.ThrowFormatException(DataType.TimeSpan);
			}
			return result;
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x0003832C File Offset: 0x0003652C
		public unsafe override void Write(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions options)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)26], 26);
			int length;
			Utf8Formatter.TryFormat(value, destination, out length, 'c');
			writer.WriteStringValue(destination.Slice(0, length));
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0003836C File Offset: 0x0003656C
		internal unsafe override void WriteAsPropertyNameCore(Utf8JsonWriter writer, TimeSpan value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)26], 26);
			int length;
			Utf8Formatter.TryFormat(value, destination, out length, 'c');
			writer.WritePropertyName(destination.Slice(0, length));
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x000383AB File Offset: 0x000365AB
		internal override JsonSchema GetSchema(JsonNumberHandling _)
		{
			return new JsonSchema
			{
				Type = JsonSchemaType.String,
				Comment = "Represents a System.TimeSpan value.",
				Pattern = "^-?(\\d+\\.)?\\d{2}:\\d{2}:\\d{2}(\\.\\d{1,7})?$"
			};
		}
	}
}
