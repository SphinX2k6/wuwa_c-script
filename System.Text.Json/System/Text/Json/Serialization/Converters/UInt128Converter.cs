using System;
using System.Buffers;
using System.Globalization;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000156 RID: 342
	internal sealed class UInt128Converter : JsonPrimitiveConverter<UInt128>
	{
		// Token: 0x06000EF5 RID: 3829 RVA: 0x00038A3F File Offset: 0x00036C3F
		public UInt128Converter()
		{
			base.IsInternalConverterForNumberType = true;
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00038A4E File Offset: 0x00036C4E
		public override UInt128 Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.Number)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedNumber(reader.TokenType);
			}
			return UInt128Converter.ReadCore(ref reader);
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x00038A6A File Offset: 0x00036C6A
		public override void Write(Utf8JsonWriter writer, UInt128 value, JsonSerializerOptions options)
		{
			UInt128Converter.WriteCore(writer, value);
		}

		// Token: 0x06000EF8 RID: 3832 RVA: 0x00038A74 File Offset: 0x00036C74
		private unsafe static UInt128 ReadCore(ref Utf8JsonReader reader)
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
			UInt128 result;
			if (!UInt128Converter.TryParse(utf8Destination.Slice(0, length), out result))
			{
				ThrowHelper.ThrowFormatException(NumericType.UInt128);
			}
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00038AF8 File Offset: 0x00036CF8
		private unsafe static void WriteCore(Utf8JsonWriter writer, UInt128 value)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)39], 39);
			int length;
			UInt128Converter.Format(destination, value, out length);
			writer.WriteRawValue(destination.Slice(0, length), false);
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00038B30 File Offset: 0x00036D30
		internal override UInt128 ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return UInt128Converter.ReadCore(ref reader);
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x00038B38 File Offset: 0x00036D38
		internal unsafe override void WriteAsPropertyNameCore(Utf8JsonWriter writer, UInt128 value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)39], 39);
			int num;
			UInt128Converter.Format(span, value, out num);
			writer.WritePropertyName(span);
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x00038B67 File Offset: 0x00036D67
		internal override UInt128 ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.String && (JsonNumberHandling.AllowReadingFromString & handling) != JsonNumberHandling.Strict)
			{
				return UInt128Converter.ReadCore(ref reader);
			}
			return this.Read(ref reader, this.Type, options);
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x00038B8C File Offset: 0x00036D8C
		internal unsafe override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, UInt128 value, JsonNumberHandling handling)
		{
			if ((JsonNumberHandling.WriteAsString & handling) != JsonNumberHandling.Strict)
			{
				Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)41], 41);
				*span[0] = 34;
				int num;
				UInt128Converter.Format(span.Slice(1), value, out num);
				int num2 = num + 2;
				*span[num2 - 1] = 34;
				writer.WriteRawValue(span.Slice(0, num2), false);
				return;
			}
			UInt128Converter.WriteCore(writer, value);
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x00038BF4 File Offset: 0x00036DF4
		internal override JsonSchema GetSchema(JsonNumberHandling numberHandling)
		{
			return JsonPrimitiveConverter<UInt128>.GetSchemaForNumericType(JsonSchemaType.Integer, numberHandling, false);
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00038BFE File Offset: 0x00036DFE
		private static bool TryParse(ReadOnlySpan<byte> buffer, out UInt128 result)
		{
			return UInt128.TryParse(buffer, CultureInfo.InvariantCulture, out result);
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00038C0C File Offset: 0x00036E0C
		private static void Format(Span<byte> destination, UInt128 value, out int written)
		{
			IFormatProvider invariantCulture = CultureInfo.InvariantCulture;
			value.TryFormat(destination, out written, default(ReadOnlySpan<char>), invariantCulture);
		}
	}
}
