using System;
using System.Buffers;
using System.Globalization;
using System.Text.Json.Schema;

namespace System.Text.Json.Serialization.Converters
{
	// Token: 0x02000159 RID: 345
	internal sealed class HalfConverter : JsonPrimitiveConverter<Half>
	{
		// Token: 0x06000F0F RID: 3855 RVA: 0x00038EFF File Offset: 0x000370FF
		public HalfConverter()
		{
			base.IsInternalConverterForNumberType = true;
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00038F0E File Offset: 0x0003710E
		public override Half Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			if (reader.TokenType != JsonTokenType.Number)
			{
				ThrowHelper.ThrowInvalidOperationException_ExpectedNumber(reader.TokenType);
			}
			return HalfConverter.ReadCore(ref reader);
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x00038F2A File Offset: 0x0003712A
		public override void Write(Utf8JsonWriter writer, Half value, JsonSerializerOptions options)
		{
			HalfConverter.WriteCore(writer, value);
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x00038F34 File Offset: 0x00037134
		private unsafe static Half ReadCore(ref Utf8JsonReader reader)
		{
			byte[] array = null;
			int valueLength = reader.ValueLength;
			Span<byte> span;
			if (valueLength <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(valueLength));
			}
			Span<byte> span2 = span;
			int length = reader.CopyValue(span2);
			span2 = span2.Slice(0, length);
			Half result;
			bool flag = HalfConverter.TryParse(span2, out result);
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
			if (!flag)
			{
				ThrowHelper.ThrowFormatException(NumericType.Half);
			}
			return result;
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x00038FBC File Offset: 0x000371BC
		private unsafe static void WriteCore(Utf8JsonWriter writer, Half value)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)20], 20);
			int length;
			HalfConverter.Format(destination, value, out length);
			writer.WriteRawValue(destination.Slice(0, length), false);
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x00038FF4 File Offset: 0x000371F4
		internal override Half ReadAsPropertyNameCore(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
		{
			return HalfConverter.ReadCore(ref reader);
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x00038FFC File Offset: 0x000371FC
		internal unsafe override void WriteAsPropertyNameCore(Utf8JsonWriter writer, Half value, JsonSerializerOptions options, bool isWritingExtensionDataProperty)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)20], 20);
			int length;
			HalfConverter.Format(destination, value, out length);
			writer.WritePropertyName(destination.Slice(0, length));
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x00039034 File Offset: 0x00037234
		internal override Half ReadNumberWithCustomHandling(ref Utf8JsonReader reader, JsonNumberHandling handling, JsonSerializerOptions options)
		{
			if (reader.TokenType == JsonTokenType.String)
			{
				if ((JsonNumberHandling.AllowReadingFromString & handling) != JsonNumberHandling.Strict)
				{
					Half result;
					if (HalfConverter.TryGetFloatingPointConstant(ref reader, out result))
					{
						return result;
					}
					return HalfConverter.ReadCore(ref reader);
				}
				else if ((JsonNumberHandling.AllowNamedFloatingPointLiterals & handling) != JsonNumberHandling.Strict)
				{
					Half result2;
					if (!HalfConverter.TryGetFloatingPointConstant(ref reader, out result2))
					{
						ThrowHelper.ThrowFormatException(NumericType.Half);
					}
					return result2;
				}
			}
			return this.Read(ref reader, this.Type, options);
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x00039088 File Offset: 0x00037288
		internal unsafe override void WriteNumberWithCustomHandling(Utf8JsonWriter writer, Half value, JsonNumberHandling handling)
		{
			if ((JsonNumberHandling.WriteAsString & handling) != JsonNumberHandling.Strict)
			{
				Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)22], 22);
				*span[0] = 34;
				int num;
				HalfConverter.Format(span.Slice(1), value, out num);
				int num2 = num + 2;
				*span[num2 - 1] = 34;
				writer.WriteRawValue(span.Slice(0, num2), false);
				return;
			}
			if ((JsonNumberHandling.AllowNamedFloatingPointLiterals & handling) != JsonNumberHandling.Strict)
			{
				HalfConverter.WriteFloatingPointConstant(writer, value);
				return;
			}
			HalfConverter.WriteCore(writer, value);
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x000390FD File Offset: 0x000372FD
		internal override JsonSchema GetSchema(JsonNumberHandling numberHandling)
		{
			return JsonPrimitiveConverter<Half>.GetSchemaForNumericType(JsonSchemaType.Number, numberHandling, true);
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x00039108 File Offset: 0x00037308
		private unsafe static bool TryGetFloatingPointConstant(ref Utf8JsonReader reader, out Half value)
		{
			Span<byte> utf8Destination = new Span<byte>(stackalloc byte[(UIntPtr)20], 20);
			int length = reader.CopyValue(utf8Destination);
			return JsonReaderHelper.TryGetFloatingPointConstant(utf8Destination.Slice(0, length), out value);
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x00039140 File Offset: 0x00037340
		private static void WriteFloatingPointConstant(Utf8JsonWriter writer, Half value)
		{
			if (Half.IsNaN(value))
			{
				writer.WriteNumberValueAsStringUnescaped(JsonConstants.NaNValue);
				return;
			}
			if (Half.IsPositiveInfinity(value))
			{
				writer.WriteNumberValueAsStringUnescaped(JsonConstants.PositiveInfinityValue);
				return;
			}
			if (Half.IsNegativeInfinity(value))
			{
				writer.WriteNumberValueAsStringUnescaped(JsonConstants.NegativeInfinityValue);
				return;
			}
			HalfConverter.WriteCore(writer, value);
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x00039190 File Offset: 0x00037390
		private static bool TryParse(ReadOnlySpan<byte> buffer, out Half result)
		{
			return Half.TryParse(buffer, NumberStyles.AllowLeadingWhite | NumberStyles.AllowTrailingWhite | NumberStyles.AllowLeadingSign | NumberStyles.AllowDecimalPoint | NumberStyles.AllowThousands | NumberStyles.AllowExponent, CultureInfo.InvariantCulture, out result) && (!Half.IsNaN(result) || buffer.SequenceEqual(JsonConstants.NaNValue)) && (!Half.IsPositiveInfinity(result) || buffer.SequenceEqual(JsonConstants.PositiveInfinityValue)) && (!Half.IsNegativeInfinity(result) || buffer.SequenceEqual(JsonConstants.NegativeInfinityValue));
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x00039200 File Offset: 0x00037400
		private static void Format(Span<byte> destination, Half value, out int written)
		{
			IFormatProvider invariantCulture = CultureInfo.InvariantCulture;
			value.TryFormat(destination, out written, default(ReadOnlySpan<char>), invariantCulture);
		}
	}
}
