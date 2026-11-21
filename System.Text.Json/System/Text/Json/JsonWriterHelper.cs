using System;
using System.Buffers;
using System.Buffers.Text;
using System.Runtime.CompilerServices;
using System.Text.Encodings.Web;
using System.Text.Unicode;

namespace System.Text.Json
{
	// Token: 0x02000059 RID: 89
	internal static class JsonWriterHelper
	{
		// Token: 0x06000563 RID: 1379 RVA: 0x00017868 File Offset: 0x00015A68
		public unsafe static void WriteIndentation(Span<byte> buffer, int indent, byte indentByte)
		{
			if (indent < 8)
			{
				int num = 0;
				while (num + 1 < indent)
				{
					*buffer[num++] = indentByte;
					*buffer[num++] = indentByte;
				}
				if (num < indent)
				{
					*buffer[num] = indentByte;
					return;
				}
			}
			else
			{
				buffer.Slice(0, indent).Fill(indentByte);
			}
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x000178C0 File Offset: 0x00015AC0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ValidateNewLine(string value)
		{
			if (value == null)
			{
				ThrowHelper.ThrowArgumentNullException("value");
			}
			if (!(value == "\n") && !(value == "\r\n"))
			{
				ThrowHelper.ThrowArgumentOutOfRangeException_NewLine("value");
			}
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x000178F3 File Offset: 0x00015AF3
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ValidateIndentCharacter(char value)
		{
			if (value != ' ' && value != '\t')
			{
				ThrowHelper.ThrowArgumentOutOfRangeException_IndentCharacter("value");
			}
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x0001790C File Offset: 0x00015B0C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ValidateIndentSize(int value)
		{
			bool flag = value < 0 || value > 127;
			if (flag)
			{
				ThrowHelper.ThrowArgumentOutOfRangeException_IndentSize("value", 0, 127);
			}
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00017938 File Offset: 0x00015B38
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ValidateProperty(ReadOnlySpan<byte> propertyName)
		{
			if (propertyName.Length > 166666666)
			{
				ThrowHelper.ThrowArgumentException_PropertyNameTooLarge(propertyName.Length);
			}
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00017954 File Offset: 0x00015B54
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ValidateValue(ReadOnlySpan<byte> value)
		{
			if (value.Length > 166666666)
			{
				ThrowHelper.ThrowArgumentException_ValueTooLarge((long)value.Length);
			}
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00017971 File Offset: 0x00015B71
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ValidateDouble(double value)
		{
			if (!JsonHelpers.IsFinite(value))
			{
				ThrowHelper.ThrowArgumentException_ValueNotSupported();
			}
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00017980 File Offset: 0x00015B80
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ValidateSingle(float value)
		{
			if (!JsonHelpers.IsFinite(value))
			{
				ThrowHelper.ThrowArgumentException_ValueNotSupported();
			}
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x0001798F File Offset: 0x00015B8F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ValidateProperty(ReadOnlySpan<char> propertyName)
		{
			if (propertyName.Length > 166666666)
			{
				ThrowHelper.ThrowArgumentException_PropertyNameTooLarge(propertyName.Length);
			}
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x000179AB File Offset: 0x00015BAB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ValidateValue(ReadOnlySpan<char> value)
		{
			if (value.Length > 166666666)
			{
				ThrowHelper.ThrowArgumentException_ValueTooLarge((long)value.Length);
			}
		}

		// Token: 0x0600056D RID: 1389 RVA: 0x000179C8 File Offset: 0x00015BC8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ValidatePropertyAndValue(ReadOnlySpan<char> propertyName, ReadOnlySpan<byte> value)
		{
			if (propertyName.Length > 166666666 || value.Length > 166666666)
			{
				ThrowHelper.ThrowArgumentException(propertyName, value);
			}
		}

		// Token: 0x0600056E RID: 1390 RVA: 0x000179ED File Offset: 0x00015BED
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ValidatePropertyAndValue(ReadOnlySpan<byte> propertyName, ReadOnlySpan<char> value)
		{
			if (propertyName.Length > 166666666 || value.Length > 166666666)
			{
				ThrowHelper.ThrowArgumentException(propertyName, value);
			}
		}

		// Token: 0x0600056F RID: 1391 RVA: 0x00017A12 File Offset: 0x00015C12
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ValidatePropertyAndValue(ReadOnlySpan<byte> propertyName, ReadOnlySpan<byte> value)
		{
			if (propertyName.Length > 166666666 || value.Length > 166666666)
			{
				ThrowHelper.ThrowArgumentException(propertyName, value);
			}
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00017A37 File Offset: 0x00015C37
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ValidatePropertyAndValue(ReadOnlySpan<char> propertyName, ReadOnlySpan<char> value)
		{
			if (propertyName.Length > 166666666 || value.Length > 166666666)
			{
				ThrowHelper.ThrowArgumentException(propertyName, value);
			}
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00017A5C File Offset: 0x00015C5C
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ValidatePropertyNameLength(ReadOnlySpan<char> propertyName)
		{
			if (propertyName.Length > 166666666)
			{
				ThrowHelper.ThrowPropertyNameTooLargeArgumentException(propertyName.Length);
			}
		}

		// Token: 0x06000572 RID: 1394 RVA: 0x00017A78 File Offset: 0x00015C78
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ValidatePropertyNameLength(ReadOnlySpan<byte> propertyName)
		{
			if (propertyName.Length > 166666666)
			{
				ThrowHelper.ThrowPropertyNameTooLargeArgumentException(propertyName.Length);
			}
		}

		// Token: 0x06000573 RID: 1395 RVA: 0x00017A94 File Offset: 0x00015C94
		internal unsafe static void ValidateNumber(ReadOnlySpan<byte> utf8FormattedNumber)
		{
			int num = 0;
			if (*utf8FormattedNumber[num] == 45)
			{
				num++;
				if (utf8FormattedNumber.Length <= num)
				{
					throw new ArgumentException(SR.RequiredDigitNotFoundEndOfData, "utf8FormattedNumber");
				}
			}
			if (*utf8FormattedNumber[num] == 48)
			{
				num++;
			}
			else
			{
				while (num < utf8FormattedNumber.Length && JsonHelpers.IsDigit(*utf8FormattedNumber[num]))
				{
					num++;
				}
			}
			if (num == utf8FormattedNumber.Length)
			{
				return;
			}
			byte b = *utf8FormattedNumber[num];
			if (b == 46)
			{
				num++;
				if (utf8FormattedNumber.Length <= num)
				{
					throw new ArgumentException(SR.RequiredDigitNotFoundEndOfData, "utf8FormattedNumber");
				}
				while (num < utf8FormattedNumber.Length && JsonHelpers.IsDigit(*utf8FormattedNumber[num]))
				{
					num++;
				}
				if (num == utf8FormattedNumber.Length)
				{
					return;
				}
				b = *utf8FormattedNumber[num];
			}
			if (b != 101 && b != 69)
			{
				throw new ArgumentException(SR.Format(SR.ExpectedEndOfDigitNotFound, ThrowHelper.GetPrintableString(b)), "utf8FormattedNumber");
			}
			num++;
			if (utf8FormattedNumber.Length <= num)
			{
				throw new ArgumentException(SR.RequiredDigitNotFoundEndOfData, "utf8FormattedNumber");
			}
			b = *utf8FormattedNumber[num];
			if (b == 43 || b == 45)
			{
				num++;
			}
			if (utf8FormattedNumber.Length <= num)
			{
				throw new ArgumentException(SR.RequiredDigitNotFoundEndOfData, "utf8FormattedNumber");
			}
			while (num < utf8FormattedNumber.Length && JsonHelpers.IsDigit(*utf8FormattedNumber[num]))
			{
				num++;
			}
			if (num != utf8FormattedNumber.Length)
			{
				throw new ArgumentException(SR.Format(SR.ExpectedEndOfDigitNotFound, ThrowHelper.GetPrintableString(*utf8FormattedNumber[num])), "utf8FormattedNumber");
			}
		}

		// Token: 0x06000574 RID: 1396 RVA: 0x00017C2C File Offset: 0x00015E2C
		public static bool IsValidUtf8String(ReadOnlySpan<byte> bytes)
		{
			return Utf8.IsValid(bytes);
		}

		// Token: 0x06000575 RID: 1397 RVA: 0x00017C34 File Offset: 0x00015E34
		internal static OperationStatus ToUtf8(ReadOnlySpan<char> source, Span<byte> destination, out int written)
		{
			int num;
			return Utf8.FromUtf16(source, destination, out num, out written, false, true);
		}

		// Token: 0x06000576 RID: 1398 RVA: 0x00017C50 File Offset: 0x00015E50
		public unsafe static void WriteDateTimeTrimmed(Span<byte> buffer, DateTime value, out int bytesWritten)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)33], 33);
			Utf8Formatter.TryFormat(value, destination, out bytesWritten, JsonWriterHelper.s_dateTimeStandardFormat);
			JsonWriterHelper.TrimDateTimeOffset(destination.Slice(0, bytesWritten), out bytesWritten);
			destination.Slice(0, bytesWritten).CopyTo(buffer);
		}

		// Token: 0x06000577 RID: 1399 RVA: 0x00017C9C File Offset: 0x00015E9C
		public unsafe static void WriteDateTimeOffsetTrimmed(Span<byte> buffer, DateTimeOffset value, out int bytesWritten)
		{
			Span<byte> destination = new Span<byte>(stackalloc byte[(UIntPtr)33], 33);
			Utf8Formatter.TryFormat(value, destination, out bytesWritten, JsonWriterHelper.s_dateTimeStandardFormat);
			JsonWriterHelper.TrimDateTimeOffset(destination.Slice(0, bytesWritten), out bytesWritten);
			destination.Slice(0, bytesWritten).CopyTo(buffer);
		}

		// Token: 0x06000578 RID: 1400 RVA: 0x00017CE8 File Offset: 0x00015EE8
		public unsafe static void TrimDateTimeOffset(Span<byte> buffer, out int bytesWritten)
		{
			if (*buffer[26] != 48)
			{
				bytesWritten = buffer.Length;
				return;
			}
			int num;
			if (*buffer[25] == 48)
			{
				if (*buffer[24] == 48)
				{
					if (*buffer[23] == 48)
					{
						if (*buffer[22] == 48)
						{
							if (*buffer[21] == 48)
							{
								if (*buffer[20] == 48)
								{
									num = 19;
								}
								else
								{
									num = 21;
								}
							}
							else
							{
								num = 22;
							}
						}
						else
						{
							num = 23;
						}
					}
					else
					{
						num = 24;
					}
				}
				else
				{
					num = 25;
				}
			}
			else
			{
				num = 26;
			}
			if (buffer.Length == 27)
			{
				bytesWritten = num;
				return;
			}
			if (buffer.Length == 33)
			{
				*buffer[num] = *buffer[27];
				*buffer[num + 1] = *buffer[28];
				*buffer[num + 2] = *buffer[29];
				*buffer[num + 3] = *buffer[30];
				*buffer[num + 4] = *buffer[31];
				*buffer[num + 5] = *buffer[32];
				bytesWritten = num + 6;
				return;
			}
			*buffer[num] = 90;
			bytesWritten = num + 1;
		}

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x06000579 RID: 1401 RVA: 0x00017E33 File Offset: 0x00016033
		private unsafe static ReadOnlySpan<byte> AllowList
		{
			get
			{
				return new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.EFE627BE173681E4F55F4133AB4C1782E26D1080CB80CDB6BFAAC81416A2714E), 256);
			}
		}

		// Token: 0x0600057A RID: 1402 RVA: 0x00017E44 File Offset: 0x00016044
		private unsafe static bool NeedsEscaping(byte value)
		{
			return *JsonWriterHelper.AllowList[(int)value] == 0;
		}

		// Token: 0x0600057B RID: 1403 RVA: 0x00017E64 File Offset: 0x00016064
		private unsafe static bool NeedsEscapingNoBoundsCheck(char value)
		{
			return *JsonWriterHelper.AllowList[(int)value] == 0;
		}

		// Token: 0x0600057C RID: 1404 RVA: 0x00017E83 File Offset: 0x00016083
		public static int NeedsEscaping(ReadOnlySpan<byte> value, JavaScriptEncoder encoder)
		{
			return (encoder ?? JavaScriptEncoder.Default).FindFirstCharacterToEncodeUtf8(value);
		}

		// Token: 0x0600057D RID: 1405 RVA: 0x00017E98 File Offset: 0x00016098
		public unsafe static int NeedsEscaping(ReadOnlySpan<char> value, JavaScriptEncoder encoder)
		{
			if (value.IsEmpty)
			{
				return -1;
			}
			fixed (char* pinnableReference = value.GetPinnableReference())
			{
				char* text = pinnableReference;
				return (encoder ?? JavaScriptEncoder.Default).FindFirstCharacterToEncode(text, value.Length);
			}
		}

		// Token: 0x0600057E RID: 1406 RVA: 0x00017ED2 File Offset: 0x000160D2
		public static int GetMaxEscapedLength(int textLength, int firstIndexToEscape)
		{
			return firstIndexToEscape + 6 * (textLength - firstIndexToEscape);
		}

		// Token: 0x0600057F RID: 1407 RVA: 0x00017EDC File Offset: 0x000160DC
		private static void EscapeString(ReadOnlySpan<byte> value, Span<byte> destination, JavaScriptEncoder encoder, ref int written)
		{
			int num;
			int num2;
			if (encoder.EncodeUtf8(value, destination, out num, out num2, true) != OperationStatus.Done)
			{
				ThrowHelper.ThrowArgumentException_InvalidUTF8(value.Slice(num2));
			}
			written += num2;
		}

		// Token: 0x06000580 RID: 1408 RVA: 0x00017F0C File Offset: 0x0001610C
		public unsafe static void EscapeString(ReadOnlySpan<byte> value, Span<byte> destination, int indexOfFirstByteToEscape, JavaScriptEncoder encoder, out int written)
		{
			value.Slice(0, indexOfFirstByteToEscape).CopyTo(destination);
			written = indexOfFirstByteToEscape;
			if (encoder != null)
			{
				destination = destination.Slice(indexOfFirstByteToEscape);
				value = value.Slice(indexOfFirstByteToEscape);
				JsonWriterHelper.EscapeString(value, destination, encoder, ref written);
				return;
			}
			while (indexOfFirstByteToEscape < value.Length)
			{
				byte b = *value[indexOfFirstByteToEscape];
				if (!JsonWriterHelper.IsAsciiValue(b))
				{
					destination = destination.Slice(written);
					value = value.Slice(indexOfFirstByteToEscape);
					JsonWriterHelper.EscapeString(value, destination, JavaScriptEncoder.Default, ref written);
					return;
				}
				if (JsonWriterHelper.NeedsEscaping(b))
				{
					JsonWriterHelper.EscapeNextBytes(b, destination, ref written);
					indexOfFirstByteToEscape++;
				}
				else
				{
					*destination[written] = b;
					written++;
					indexOfFirstByteToEscape++;
				}
			}
		}

		// Token: 0x06000581 RID: 1409 RVA: 0x00017FC8 File Offset: 0x000161C8
		private unsafe static void EscapeNextBytes(byte value, Span<byte> destination, ref int written)
		{
			int num = written;
			written = num + 1;
			*destination[num] = 92;
			switch (value)
			{
			case 8:
				num = written;
				written = num + 1;
				*destination[num] = 98;
				return;
			case 9:
				num = written;
				written = num + 1;
				*destination[num] = 116;
				return;
			case 10:
				num = written;
				written = num + 1;
				*destination[num] = 110;
				return;
			case 11:
				break;
			case 12:
				num = written;
				written = num + 1;
				*destination[num] = 102;
				return;
			case 13:
				num = written;
				written = num + 1;
				*destination[num] = 114;
				return;
			default:
				if (value == 34)
				{
					num = written;
					written = num + 1;
					*destination[num] = 117;
					num = written;
					written = num + 1;
					*destination[num] = 48;
					num = written;
					written = num + 1;
					*destination[num] = 48;
					num = written;
					written = num + 1;
					*destination[num] = 50;
					num = written;
					written = num + 1;
					*destination[num] = 50;
					return;
				}
				if (value == 92)
				{
					num = written;
					written = num + 1;
					*destination[num] = 92;
					return;
				}
				break;
			}
			num = written;
			written = num + 1;
			*destination[num] = 117;
			int num2;
			Utf8Formatter.TryFormat(value, destination.Slice(written), out num2, JsonWriterHelper.s_hexStandardFormat);
			written += num2;
		}

		// Token: 0x06000582 RID: 1410 RVA: 0x00018122 File Offset: 0x00016322
		private static bool IsAsciiValue(byte value)
		{
			return value <= 127;
		}

		// Token: 0x06000583 RID: 1411 RVA: 0x00018122 File Offset: 0x00016322
		private static bool IsAsciiValue(char value)
		{
			return value <= '\u007f';
		}

		// Token: 0x06000584 RID: 1412 RVA: 0x0001812C File Offset: 0x0001632C
		private unsafe static void EscapeString(ReadOnlySpan<char> value, Span<char> destination, JavaScriptEncoder encoder, ref int written)
		{
			int num;
			int num2;
			if (encoder.Encode(value, destination, out num, out num2, true) != OperationStatus.Done)
			{
				ThrowHelper.ThrowArgumentException_InvalidUTF16((int)(*value[num2]));
			}
			written += num2;
		}

		// Token: 0x06000585 RID: 1413 RVA: 0x0001815C File Offset: 0x0001635C
		public unsafe static void EscapeString(ReadOnlySpan<char> value, Span<char> destination, int indexOfFirstByteToEscape, JavaScriptEncoder encoder, out int written)
		{
			value.Slice(0, indexOfFirstByteToEscape).CopyTo(destination);
			written = indexOfFirstByteToEscape;
			if (encoder != null)
			{
				destination = destination.Slice(indexOfFirstByteToEscape);
				value = value.Slice(indexOfFirstByteToEscape);
				JsonWriterHelper.EscapeString(value, destination, encoder, ref written);
				return;
			}
			while (indexOfFirstByteToEscape < value.Length)
			{
				char c = (char)(*value[indexOfFirstByteToEscape]);
				if (!JsonWriterHelper.IsAsciiValue(c))
				{
					destination = destination.Slice(written);
					value = value.Slice(indexOfFirstByteToEscape);
					JsonWriterHelper.EscapeString(value, destination, JavaScriptEncoder.Default, ref written);
					return;
				}
				if (JsonWriterHelper.NeedsEscapingNoBoundsCheck(c))
				{
					JsonWriterHelper.EscapeNextChars(c, destination, ref written);
					indexOfFirstByteToEscape++;
				}
				else
				{
					*destination[written] = c;
					written++;
					indexOfFirstByteToEscape++;
				}
			}
		}

		// Token: 0x06000586 RID: 1414 RVA: 0x00018218 File Offset: 0x00016418
		private unsafe static void EscapeNextChars(char value, Span<char> destination, ref int written)
		{
			int num = written;
			written = num + 1;
			*destination[num] = '\\';
			byte b = (byte)value;
			switch (b)
			{
			case 8:
				num = written;
				written = num + 1;
				*destination[num] = 'b';
				return;
			case 9:
				num = written;
				written = num + 1;
				*destination[num] = 't';
				return;
			case 10:
				num = written;
				written = num + 1;
				*destination[num] = 'n';
				return;
			case 11:
				break;
			case 12:
				num = written;
				written = num + 1;
				*destination[num] = 'f';
				return;
			case 13:
				num = written;
				written = num + 1;
				*destination[num] = 'r';
				return;
			default:
				if (b == 34)
				{
					num = written;
					written = num + 1;
					*destination[num] = 'u';
					num = written;
					written = num + 1;
					*destination[num] = '0';
					num = written;
					written = num + 1;
					*destination[num] = '0';
					num = written;
					written = num + 1;
					*destination[num] = '2';
					num = written;
					written = num + 1;
					*destination[num] = '2';
					return;
				}
				if (b == 92)
				{
					num = written;
					written = num + 1;
					*destination[num] = '\\';
					return;
				}
				break;
			}
			num = written;
			written = num + 1;
			*destination[num] = 'u';
			int num2 = (int)value;
			int num3;
			num2.TryFormat(destination.Slice(written), out num3, "X4", null);
			written += num3;
		}

		// Token: 0x040001DC RID: 476
		private static readonly StandardFormat s_dateTimeStandardFormat = new StandardFormat('O', byte.MaxValue);

		// Token: 0x040001DD RID: 477
		private static readonly StandardFormat s_hexStandardFormat = new StandardFormat('X', 4);
	}
}
