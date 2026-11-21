using System;
using System.Buffers;
using System.Globalization;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000155 RID: 341
	internal sealed class Int128Converter : JsonPrimitiveConverter<Int128>
	{
		// Token: 0x06000EE9 RID: 3817 RVA: 0x0003884A File Offset: 0x00036A4A
		public Int128Converter()
		{
			base.IsInternalConverterForNumberType = true;
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x00038859 File Offset: 0x00036A59
		public override Int128 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.Number)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedNumber(reader.TokenType);
			}
			return Int128Converter.ReadCore(ref reader);
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x00038875 File Offset: 0x00036A75
		public override void Write(Utf8JsonWriter writer, Int128 value, JsonSerializerOptions options)
		{
			Int128Converter.WriteCore(writer, value);
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x00038880 File Offset: 0x00036A80
		private unsafe static Int128 ReadCore(ref Utf8JsonReader reader)
		{
			int valueLength = reader.ValueLength;
			byte[] array = null;
			Span<byte> span;
			if (valueLength <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(valueLength));
			}
			Span<byte> utf8Destination = span;
			int length = reader.CopyValue(utf8Destination);
			Int128 result;
			if (!Int128Converter.TryParse(utf8Destination.Slice(0, length), out result))
			{
				ThrowHelper.ThrowFormatException(NumericType.Int128);
			}
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x00038904 File Offset: 0x00036B04
		private unsafe static void WriteCore(Utf8JsonWriter writer, Int128 value)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)40], 40);
			int length;
			Int128Converter.Format(destination, value, out length);
			writer.WriteRawValue(destination.Slice(0, length), false);
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x0003893C File Offset: 0x00036B3C
		internal override Int128 ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return Int128Converter.ReadCore(ref reader);
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x00038944 File Offset: 0x00036B44
		internal unsafe override void WriteAsPropertyNameCore(Utf8JsonWriter writer, Int128 value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)40], 40);
			int num;
			Int128Converter.Format(span, value, out num);
			writer.WritePropertyName(span);
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x00038973 File Offset: 0x00036B73
		internal override Int128 ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.String && (JsonNumberHandling.AllowReadingFromString & handling) != JsonNumberHandling.Strict)
			{
				return Int128Converter.ReadCore(ref reader);
			}
			return this.Read(ref reader, this.Type, options);
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00038998 File Offset: 0x00036B98
		internal unsafe override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, Int128 value, JsonNumberHandling handling)
		{
			if ((JsonNumberHandling.WriteAsString & handling) != JsonNumberHandling.Strict)
			{
				Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)42], 42);
				*span[0] = 34;
				int num;
				Int128Converter.Format(span.Slice(1), value, out num);
				int num2 = num + 2;
				*span[num2 - 1] = 34;
				writer.WriteRawValue(span.Slice(0, num2), false);
				return;
			}
			Int128Converter.WriteCore(writer, value);
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x00038A00 File Offset: 0x00036C00
		internal override JsonSchema GetSchema(JsonNumberHandling numberHandling)
		{
			return JsonPrimitiveConverter<Int128>.GetSchemaForNumericType(JsonSchemaType.Integer, numberHandling, false);
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x00038A0A File Offset: 0x00036C0A
		private static bool TryParse(ReadOnlySpan<byte> buffer, out Int128 result)
		{
			return Int128.TryParse(buffer, CultureInfo.InvariantCulture, out result);
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x00038A18 File Offset: 0x00036C18
		private static void Format(Span<byte> destination, Int128 value, out int written)
		{
			IFormatProvider invariantCulture = CultureInfo.InvariantCulture;
			value.TryFormat(destination, out written, default(ReadOnlySpan<char>), invariantCulture);
		}
	}
}
