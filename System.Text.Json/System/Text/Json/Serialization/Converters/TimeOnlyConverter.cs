using System;
using System.Buffers.Text;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000158 RID: 344
	internal sealed class TimeOnlyConverter : JsonPrimitiveConverter<TimeOnly>
	{
		// Token: 0x06000F08 RID: 3848 RVA: 0x00038D6E File Offset: 0x00036F6E
		public override TimeOnly Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.String)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedString(reader.TokenType);
			}
			return TimeOnlyConverter.ReadCore(ref reader);
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00038D8A File Offset: 0x00036F8A
		internal override TimeOnly ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return TimeOnlyConverter.ReadCore(ref reader);
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x00038D94 File Offset: 0x00036F94
		private unsafe static TimeOnly ReadCore(ref Utf8JsonReader reader)
		{
			if (!JsonHelpers.IsInRangeInclusive(reader.ValueLength, 3, 96))
			{
				ThrowHelper.ThrowFormatException(DataType.TimeOnly);
			}
			ReadOnlySpan<byte> readOnlySpan;
			if (!reader.HasValueSequence && !reader.ValueIsEscaped)
			{
				readOnlySpan = reader.ValueSpan;
			}
			else
			{
				Span<byte> utf8Destination = new Span<byte>(stackalloc byte[(UIntPtr)96], 96);
				int length = reader.CopyString(utf8Destination);
				readOnlySpan = utf8Destination.Slice(0, length);
			}
			byte value = *readOnlySpan[0];
			int num = readOnlySpan.IndexOfAny(46, 58);
			if (!JsonHelpers.IsDigit(value) || num < 0 || *readOnlySpan[num] == 46)
			{
				ThrowHelper.ThrowFormatException(DataType.TimeOnly);
			}
			TimeSpan timeSpan;
			int num2;
			if (!Utf8Parser.TryParse(readOnlySpan, out timeSpan, out num2, 'c') || readOnlySpan.Length != num2)
			{
				ThrowHelper.ThrowFormatException(DataType.TimeOnly);
			}
			return TimeOnly.FromTimeSpan(timeSpan);
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00038E50 File Offset: 0x00037050
		public unsafe override void Write(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)16], 16);
			int length;
			Utf8Formatter.TryFormat(value.ToTimeSpan(), destination, out length, 'c');
			writer.WriteStringValue(destination.Slice(0, length));
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00038E98 File Offset: 0x00037098
		internal unsafe override void WriteAsPropertyNameCore(Utf8JsonWriter writer, TimeOnly value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)16], 16);
			int length;
			Utf8Formatter.TryFormat(value.ToTimeSpan(), destination, out length, 'c');
			writer.WritePropertyName(destination.Slice(0, length));
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00038EDD File Offset: 0x000370DD
		internal override JsonSchema GetSchema(JsonNumberHandling _)
		{
			return new JsonSchema
			{
				Type = JsonSchemaType.String,
				Format = "time"
			};
		}
	}
}
