using System;
using System.Buffers;
using System.Buffers.Text;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text.Unicode;

namespace System.Text.Json
{
	// Token: 0x02000033 RID: 51
	internal static class JsonReaderHelper
	{
		// Token: 0x06000319 RID: 793 RVA: 0x0000A9AD File Offset: 0x00008BAD
		public static bool ContainsSpecialCharacters(this ReadOnlySpan<char> text)
		{
			return text.ContainsAny(JsonReaderHelper.s_specialCharacters);
		}

		// Token: 0x0600031A RID: 794 RVA: 0x0000A9BC File Offset: 0x00008BBC
		public static ValueTuple<int, int> CountNewLines(ReadOnlySpan<byte> data)
		{
			int num = data.LastIndexOf(10);
			int num2 = 0;
			if (num >= 0)
			{
				num2 = 1;
				data = data.Slice(0, num);
				num2 += data.Count(10);
			}
			return new ValueTuple<int, int>(num2, num);
		}

		// Token: 0x0600031B RID: 795 RVA: 0x0000A9F8 File Offset: 0x00008BF8
		internal static JsonValueKind ToValueKind(this JsonTokenType tokenType)
		{
			switch (tokenType)
			{
			case JsonTokenType.None:
				return JsonValueKind.Undefined;
			case JsonTokenType.StartObject:
				return JsonValueKind.Object;
			case JsonTokenType.StartArray:
				return JsonValueKind.Array;
			case JsonTokenType.String:
			case JsonTokenType.Number:
			case JsonTokenType.True:
			case JsonTokenType.False:
			case JsonTokenType.Null:
				return (JsonValueKind)(tokenType - JsonTokenType.EndArray);
			}
			return JsonValueKind.Undefined;
		}

		// Token: 0x0600031C RID: 796 RVA: 0x0000AA49 File Offset: 0x00008C49
		public static bool IsTokenTypePrimitive(JsonTokenType tokenType)
		{
			return tokenType - JsonTokenType.String <= 4;
		}

		// Token: 0x0600031D RID: 797 RVA: 0x0000AA55 File Offset: 0x00008C55
		public static bool IsHexDigit(byte nextByte)
		{
			return HexConverter.IsHexChar((int)nextByte);
		}

		// Token: 0x0600031E RID: 798 RVA: 0x0000AA60 File Offset: 0x00008C60
		public unsafe static bool TryGetEscapedDateTime(ReadOnlySpan<byte> source, out DateTime value)
		{
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)252], 252);
			int length;
			JsonReaderHelper.Unescape(source, span, out length);
			span = span.Slice(0, length);
			DateTime dateTime;
			if (JsonHelpers.IsValidUnescapedDateTimeOffsetParseLength(span.Length) && JsonHelpers.TryParseAsISO(span, out dateTime))
			{
				value = dateTime;
				return true;
			}
			value = default(DateTime);
			return false;
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000AAC4 File Offset: 0x00008CC4
		public unsafe static bool TryGetEscapedDateTimeOffset(ReadOnlySpan<byte> source, out DateTimeOffset value)
		{
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)252], 252);
			int length;
			JsonReaderHelper.Unescape(source, span, out length);
			span = span.Slice(0, length);
			DateTimeOffset dateTimeOffset;
			if (JsonHelpers.IsValidUnescapedDateTimeOffsetParseLength(span.Length) && JsonHelpers.TryParseAsISO(span, out dateTimeOffset))
			{
				value = dateTimeOffset;
				return true;
			}
			value = default(DateTimeOffset);
			return false;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000AB28 File Offset: 0x00008D28
		public unsafe static bool TryGetEscapedGuid(ReadOnlySpan<byte> source, out Guid value)
		{
			Span<byte> span = new Span<byte>(stackalloc byte[(UIntPtr)216], 216);
			int length;
			JsonReaderHelper.Unescape(source, span, out length);
			span = span.Slice(0, length);
			Guid guid;
			int num;
			if (span.Length == 36 && Utf8Parser.TryParse(span, out guid, out num, 'D'))
			{
				value = guid;
				return true;
			}
			value = default(Guid);
			return false;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000AB8C File Offset: 0x00008D8C
		public static bool TryGetFloatingPointConstant(ReadOnlySpan<byte> span, out Half value)
		{
			if (span.Length == 3)
			{
				if (span.SequenceEqual(JsonConstants.NaNValue))
				{
					value = Half.NaN;
					return true;
				}
			}
			else if (span.Length == 8)
			{
				if (span.SequenceEqual(JsonConstants.PositiveInfinityValue))
				{
					value = Half.PositiveInfinity;
					return true;
				}
			}
			else if (span.Length == 9 && span.SequenceEqual(JsonConstants.NegativeInfinityValue))
			{
				value = Half.NegativeInfinity;
				return true;
			}
			value = default(Half);
			return false;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000AC10 File Offset: 0x00008E10
		public static bool TryGetFloatingPointConstant(ReadOnlySpan<byte> span, out float value)
		{
			if (span.Length == 3)
			{
				if (span.SequenceEqual(JsonConstants.NaNValue))
				{
					value = float.NaN;
					return true;
				}
			}
			else if (span.Length == 8)
			{
				if (span.SequenceEqual(JsonConstants.PositiveInfinityValue))
				{
					value = float.PositiveInfinity;
					return true;
				}
			}
			else if (span.Length == 9 && span.SequenceEqual(JsonConstants.NegativeInfinityValue))
			{
				value = float.NegativeInfinity;
				return true;
			}
			value = 0f;
			return false;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000AC88 File Offset: 0x00008E88
		public static bool TryGetFloatingPointConstant(ReadOnlySpan<byte> span, out double value)
		{
			if (span.Length == 3)
			{
				if (span.SequenceEqual(JsonConstants.NaNValue))
				{
					value = double.NaN;
					return true;
				}
			}
			else if (span.Length == 8)
			{
				if (span.SequenceEqual(JsonConstants.PositiveInfinityValue))
				{
					value = double.PositiveInfinity;
					return true;
				}
			}
			else if (span.Length == 9 && span.SequenceEqual(JsonConstants.NegativeInfinityValue))
			{
				value = double.NegativeInfinity;
				return true;
			}
			value = 0.0;
			return false;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000AD10 File Offset: 0x00008F10
		public unsafe static bool TryGetUnescapedBase64Bytes(ReadOnlySpan<byte> utf8Source, [NotNullWhen(true)] out byte[] bytes)
		{
			byte[] array = null;
			Span<byte> span;
			if (utf8Source.Length <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(utf8Source.Length));
			}
			Span<byte> span2 = span;
			int length;
			JsonReaderHelper.Unescape(utf8Source, span2, out length);
			span2 = span2.Slice(0, length);
			bool result = JsonReaderHelper.TryDecodeBase64InPlace(span2, out bytes);
			if (array != null)
			{
				span2.Clear();
				ArrayPool<byte>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x06000325 RID: 805 RVA: 0x0000AD90 File Offset: 0x00008F90
		public unsafe static string GetUnescapedString(ReadOnlySpan<byte> utf8Source)
		{
			int length = utf8Source.Length;
			byte[] array = null;
			Span<byte> span;
			if (length <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(length));
			}
			Span<byte> span2 = span;
			int length2;
			JsonReaderHelper.Unescape(utf8Source, span2, out length2);
			span2 = span2.Slice(0, length2);
			string result = JsonReaderHelper.TranscodeHelper(span2);
			if (array != null)
			{
				span2.Clear();
				ArrayPool<byte>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x06000326 RID: 806 RVA: 0x0000AE10 File Offset: 0x00009010
		public unsafe static ReadOnlySpan<byte> GetUnescapedSpan(ReadOnlySpan<byte> utf8Source)
		{
			int length = utf8Source.Length;
			byte[] array = null;
			Span<byte> span;
			if (length <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(length));
			}
			Span<byte> destination = span;
			int length2;
			JsonReaderHelper.Unescape(utf8Source, destination, out length2);
			ReadOnlySpan<byte> result = destination.Slice(0, length2).ToArray();
			if (array != null)
			{
				new Span<byte>(array, 0, length2).Clear();
				ArrayPool<byte>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x06000327 RID: 807 RVA: 0x0000AE9C File Offset: 0x0000909C
		public unsafe static bool UnescapeAndCompare(ReadOnlySpan<byte> utf8Source, ReadOnlySpan<byte> other)
		{
			byte[] array = null;
			Span<byte> span;
			if (utf8Source.Length <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(utf8Source.Length));
			}
			Span<byte> span2 = span;
			int length;
			JsonReaderHelper.Unescape(utf8Source, span2, 0, out length);
			span2 = span2.Slice(0, length);
			bool result = other.SequenceEqual(span2);
			if (array != null)
			{
				span2.Clear();
				ArrayPool<byte>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x06000328 RID: 808 RVA: 0x0000AF20 File Offset: 0x00009120
		public unsafe static bool UnescapeAndCompare(ReadOnlySequence<byte> utf8Source, ReadOnlySpan<byte> other)
		{
			byte[] array = null;
			byte[] array2 = null;
			int num = checked((int)utf8Source.Length);
			Span<byte> span;
			if (num <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array2 = ArrayPool<byte>.Shared.Rent(num));
			}
			Span<byte> span2 = span;
			if (num <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(num));
			}
			Span<byte> span3 = span;
			utf8Source.CopyTo(span3);
			span3 = span3.Slice(0, num);
			int length;
			JsonReaderHelper.Unescape(span3, span2, 0, out length);
			span2 = span2.Slice(0, length);
			bool result = other.SequenceEqual(span2);
			if (array2 != null)
			{
				span2.Clear();
				ArrayPool<byte>.Shared.Return(array2, false);
				span3.Clear();
				ArrayPool<byte>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x06000329 RID: 809 RVA: 0x0000B00C File Offset: 0x0000920C
		public unsafe static bool UnescapeAndCompareBothInputs(ReadOnlySpan<byte> utf8Source1, ReadOnlySpan<byte> utf8Source2)
		{
			int idx = utf8Source1.IndexOf(92);
			int idx2 = utf8Source2.IndexOf(92);
			byte[] array = null;
			byte[] array2 = null;
			Span<byte> span;
			if (utf8Source1.Length <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(utf8Source1.Length));
			}
			Span<byte> span2 = span;
			if (utf8Source2.Length <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array2 = ArrayPool<byte>.Shared.Rent(utf8Source2.Length));
			}
			Span<byte> span3 = span;
			int length;
			JsonReaderHelper.Unescape(utf8Source1, span2, idx, out length);
			span2 = span2.Slice(0, length);
			JsonReaderHelper.Unescape(utf8Source2, span3, idx2, out length);
			span3 = span3.Slice(0, length);
			bool result = span2.SequenceEqual(span3);
			if (array != null)
			{
				span2.Clear();
				ArrayPool<byte>.Shared.Return(array, false);
			}
			if (array2 != null)
			{
				span3.Clear();
				ArrayPool<byte>.Shared.Return(array2, false);
			}
			return result;
		}

		// Token: 0x0600032A RID: 810 RVA: 0x0000B11C File Offset: 0x0000931C
		public static bool TryDecodeBase64InPlace(Span<byte> utf8Unescaped, [NotNullWhen(true)] out byte[] bytes)
		{
			int length;
			if (Base64.DecodeFromUtf8InPlace(utf8Unescaped, out length) != OperationStatus.Done)
			{
				bytes = null;
				return false;
			}
			bytes = utf8Unescaped.Slice(0, length).ToArray();
			return true;
		}

		// Token: 0x0600032B RID: 811 RVA: 0x0000B14C File Offset: 0x0000934C
		public unsafe static bool TryDecodeBase64(ReadOnlySpan<byte> utf8Unescaped, [NotNullWhen(true)] out byte[] bytes)
		{
			byte[] array = null;
			Span<byte> span;
			if (utf8Unescaped.Length <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(utf8Unescaped.Length));
			}
			Span<byte> bytes2 = span;
			int num;
			int length;
			if (Base64.DecodeFromUtf8(utf8Unescaped, bytes2, out num, out length, true) != OperationStatus.Done)
			{
				bytes = null;
				if (array != null)
				{
					bytes2.Clear();
					ArrayPool<byte>.Shared.Return(array, false);
				}
				return false;
			}
			bytes = bytes2.Slice(0, length).ToArray();
			if (array != null)
			{
				bytes2.Clear();
				ArrayPool<byte>.Shared.Return(array, false);
			}
			return true;
		}

		// Token: 0x0600032C RID: 812 RVA: 0x0000B1F0 File Offset: 0x000093F0
		public static string TranscodeHelper(ReadOnlySpan<byte> utf8Unescaped)
		{
			string @string;
			try
			{
				@string = JsonReaderHelper.s_utf8Encoding.GetString(utf8Unescaped);
			}
			catch (DecoderFallbackException innerException)
			{
				throw ThrowHelper.GetInvalidOperationException_ReadInvalidUTF8(innerException);
			}
			return @string;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x0000B224 File Offset: 0x00009424
		public static int TranscodeHelper(ReadOnlySpan<byte> utf8Unescaped, Span<char> destination)
		{
			int chars;
			try
			{
				chars = JsonReaderHelper.s_utf8Encoding.GetChars(utf8Unescaped, destination);
			}
			catch (DecoderFallbackException innerException)
			{
				throw ThrowHelper.GetInvalidOperationException_ReadInvalidUTF8(innerException);
			}
			catch (ArgumentException)
			{
				destination.Clear();
				throw;
			}
			return chars;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x0000B270 File Offset: 0x00009470
		public static void ValidateUtf8(ReadOnlySpan<byte> utf8Buffer)
		{
			if (!Utf8.IsValid(utf8Buffer))
			{
				throw ThrowHelper.GetInvalidOperationException_ReadInvalidUTF8(null);
			}
		}

		// Token: 0x0600032F RID: 815 RVA: 0x0000B284 File Offset: 0x00009484
		internal static int GetUtf8ByteCount(ReadOnlySpan<char> text)
		{
			int byteCount;
			try
			{
				byteCount = JsonReaderHelper.s_utf8Encoding.GetByteCount(text);
			}
			catch (EncoderFallbackException innerException)
			{
				throw ThrowHelper.GetArgumentException_ReadInvalidUTF16(innerException);
			}
			return byteCount;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000B2B8 File Offset: 0x000094B8
		internal static int GetUtf8FromText(ReadOnlySpan<char> text, Span<byte> dest)
		{
			int bytes;
			try
			{
				bytes = JsonReaderHelper.s_utf8Encoding.GetBytes(text, dest);
			}
			catch (EncoderFallbackException innerException)
			{
				throw ThrowHelper.GetArgumentException_ReadInvalidUTF16(innerException);
			}
			return bytes;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000B2EC File Offset: 0x000094EC
		internal static string GetTextFromUtf8(ReadOnlySpan<byte> utf8Text)
		{
			return JsonReaderHelper.s_utf8Encoding.GetString(utf8Text);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000B2FC File Offset: 0x000094FC
		internal static void Unescape(ReadOnlySpan<byte> source, Span<byte> destination, out int written)
		{
			int idx = source.IndexOf(92);
			JsonReaderHelper.TryUnescape(source, destination, idx, out written);
		}

		// Token: 0x06000333 RID: 819 RVA: 0x0000B31C File Offset: 0x0000951C
		internal static void Unescape(ReadOnlySpan<byte> source, Span<byte> destination, int idx, out int written)
		{
			JsonReaderHelper.TryUnescape(source, destination, idx, out written);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000B328 File Offset: 0x00009528
		internal static bool TryUnescape(ReadOnlySpan<byte> source, Span<byte> destination, out int written)
		{
			int idx = source.IndexOf(92);
			return JsonReaderHelper.TryUnescape(source, destination, idx, out written);
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000B348 File Offset: 0x00009548
		private unsafe static bool TryUnescape(ReadOnlySpan<byte> source, Span<byte> destination, int idx, out int written)
		{
			if (!source.Slice(0, idx).TryCopyTo(destination))
			{
				written = 0;
			}
			else
			{
				written = idx;
				while (written != destination.Length)
				{
					byte b = *source[++idx];
					if (b <= 98)
					{
						if (b <= 47)
						{
							if (b != 34)
							{
								if (b != 47)
								{
									goto IL_179;
								}
								int num = written;
								written = num + 1;
								*destination[num] = 47;
							}
							else
							{
								int num = written;
								written = num + 1;
								*destination[num] = 34;
							}
						}
						else if (b != 92)
						{
							if (b != 98)
							{
								goto IL_179;
							}
							int num = written;
							written = num + 1;
							*destination[num] = 8;
						}
						else
						{
							int num = written;
							written = num + 1;
							*destination[num] = 92;
						}
					}
					else if (b <= 110)
					{
						if (b != 102)
						{
							if (b != 110)
							{
								goto IL_179;
							}
							int num = written;
							written = num + 1;
							*destination[num] = 10;
						}
						else
						{
							int num = written;
							written = num + 1;
							*destination[num] = 12;
						}
					}
					else if (b != 114)
					{
						if (b != 116)
						{
							goto IL_179;
						}
						int num = written;
						written = num + 1;
						*destination[num] = 9;
					}
					else
					{
						int num = written;
						written = num + 1;
						*destination[num] = 13;
					}
					IL_260:
					if (++idx != source.Length)
					{
						if (*source[idx] == 92)
						{
							continue;
						}
						ReadOnlySpan<byte> span = source.Slice(idx);
						int num2 = span.IndexOf(92);
						if (num2 < 0)
						{
							num2 = span.Length;
						}
						if (written + num2 >= destination.Length)
						{
							break;
						}
						switch (num2)
						{
						case 1:
						{
							int num = written;
							written = num + 1;
							*destination[num] = *source[idx++];
							break;
						}
						case 2:
						{
							int num = written;
							written = num + 1;
							*destination[num] = *source[idx++];
							num = written;
							written = num + 1;
							*destination[num] = *source[idx++];
							break;
						}
						case 3:
						{
							int num = written;
							written = num + 1;
							*destination[num] = *source[idx++];
							num = written;
							written = num + 1;
							*destination[num] = *source[idx++];
							num = written;
							written = num + 1;
							*destination[num] = *source[idx++];
							break;
						}
						default:
							span.Slice(0, num2).CopyTo(destination.Slice(written));
							written += num2;
							idx += num2;
							break;
						}
						if (idx != source.Length)
						{
							continue;
						}
					}
					return true;
					IL_179:
					int num3;
					int num4;
					Utf8Parser.TryParse(source.Slice(idx + 1, 4), out num3, out num4, 'x');
					idx += 4;
					if (JsonHelpers.IsInRangeInclusive((uint)num3, 55296U, 57343U))
					{
						if (num3 >= 56320)
						{
							ThrowHelper.ThrowInvalidOperationException_ReadInvalidUTF16(num3);
						}
						if (source.Length < idx + 7 || *source[idx + 1] != 92 || *source[idx + 2] != 117)
						{
							ThrowHelper.ThrowInvalidOperationException_ReadIncompleteUTF16();
						}
						int num5;
						Utf8Parser.TryParse(source.Slice(idx + 3, 4), out num5, out num4, 'x');
						idx += 6;
						if (!JsonHelpers.IsInRangeInclusive((uint)num5, 56320U, 57343U))
						{
							ThrowHelper.ThrowInvalidOperationException_ReadInvalidUTF16(num5);
						}
						num3 = 1024 * (num3 - 55296) + (num5 - 56320) + 65536;
					}
					Rune rune = new Rune(num3);
					int num6;
					if (rune.TryEncodeToUtf8(destination.Slice(written), out num6))
					{
						written += num6;
						goto IL_260;
					}
					break;
				}
			}
			return false;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000B735 File Offset: 0x00009935
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static int IndexOfQuoteOrAnyControlOrBackSlash(this ReadOnlySpan<byte> span)
		{
			return span.IndexOfAny(JsonReaderHelper.s_controlQuoteBackslash);
		}

		// Token: 0x04000092 RID: 146
		private static readonly SearchValues<char> s_specialCharacters = SearchValues.Create(". '/\"[]()\t\n\r\f\b\\\u0085\u2028\u2029");

		// Token: 0x04000093 RID: 147
		public static readonly UTF8Encoding s_utf8Encoding = new UTF8Encoding(false, true);

		// Token: 0x04000094 RID: 148
		private static readonly SearchValues<byte> s_controlQuoteBackslash = SearchValues.Create(new ReadOnlySpan<byte>((void*)(&<PrivateImplementationDetails>.AF588FFF8363545AB79B72C6BC89DA690C48DC7F5ED52015A88E121C552F86E1), 34));
	}
}
