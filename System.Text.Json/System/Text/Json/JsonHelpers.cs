using System;
using System.Buffers;
using System.Buffers.Text;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text.Encodings.Web;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;
using System.Text.RegularExpressions.Generated;

namespace System.Text.Json
{
	// Token: 0x02000012 RID: 18
	internal static class JsonHelpers
	{
		// Token: 0x060001D8 RID: 472 RVA: 0x0000535F File Offset: 0x0000355F
		internal static bool RequiresSpecialNumberHandlingOnWrite(JsonNumberHandling? handling)
		{
			return handling != null && (handling.Value & (JsonNumberHandling.WriteAsString | JsonNumberHandling.AllowNamedFloatingPointLiterals)) > JsonNumberHandling.Strict;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00005378 File Offset: 0x00003578
		internal unsafe static void StableSortByKey<T, [IsUnmanaged] TKey>(this List<T> items, Func<T, TKey> keySelector) where TKey : struct, ValueType, IComparable<TKey>
		{
			Span<T> items2 = CollectionsMarshal.AsSpan<T>(items);
			Span<ValueTuple<TKey, int>> span;
			if (items2.Length <= 32)
			{
				span = new Span<ValueTuple<TKey, int>>(stackalloc byte[checked(unchecked((UIntPtr)32) * (UIntPtr)sizeof(ValueTuple<TKey, int>))], 32).Slice(0, items2.Length);
			}
			else
			{
				span = new ValueTuple<TKey, int>[items2.Length];
			}
			Span<ValueTuple<TKey, int>> keys = span;
			for (int i = 0; i < keys.Length; i++)
			{
				*keys[i] = new ValueTuple<TKey, int>(keySelector(*items2[i]), i);
			}
			keys.Sort(items2);
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00005418 File Offset: 0x00003618
		public static T[] TraverseGraphWithTopologicalSort<T>(T entryNode, Func<T, ICollection<T>> getChildren, IEqualityComparer<T> comparer = null)
		{
			if (comparer == null)
			{
				comparer = EqualityComparer<T>.Default;
			}
			List<T> list = new List<T>
			{
				entryNode
			};
			Dictionary<T, int> dictionary = new Dictionary<T, int>(comparer);
			dictionary[entryNode] = 0;
			Dictionary<T, int> dictionary2 = dictionary;
			List<bool[]> list2 = new List<bool[]>();
			Queue<int> queue = new Queue<int>();
			for (int i = 0; i < list.Count; i++)
			{
				T arg = list[i];
				ICollection<T> collection = getChildren(arg);
				int count = collection.Count;
				if (count == 0)
				{
					list2.Add(null);
					queue.Enqueue(i);
				}
				else
				{
					bool[] array = new bool[Math.Max(list.Count, count)];
					foreach (T t in collection)
					{
						int count2;
						if (!dictionary2.TryGetValue(t, out count2))
						{
							count2 = list.Count;
							dictionary2.Add(t, count2);
							list.Add(t);
						}
						if (count2 >= array.Length)
						{
							Array.Resize<bool>(ref array, count2 + 1);
						}
						array[count2] = true;
					}
					list2.Add(array);
				}
			}
			T[] array2 = new T[list.Count];
			int num = array2.Length;
			do
			{
				int num2 = queue.Dequeue();
				array2[--num] = list[num2];
				for (int j = 0; j < list2.Count; j++)
				{
					bool[] array3 = list2[j];
					if (array3 != null && num2 < array3.Length && array3[num2])
					{
						array3[num2] = false;
						if (array3.AsSpan<bool>().IndexOf(true) == -1)
						{
							queue.Enqueue(j);
						}
					}
				}
			}
			while (queue.Count > 0);
			return array2;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000055D0 File Offset: 0x000037D0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static ReadOnlySpan<byte> GetUnescapedSpan([ScopedRef] this Utf8JsonReader reader)
		{
			ReadOnlySpan<byte> readOnlySpan;
			if (!reader.HasValueSequence)
			{
				readOnlySpan = reader.ValueSpan;
			}
			else
			{
				ReadOnlySequence<byte> valueSequence = reader.ValueSequence;
				readOnlySpan = valueSequence.ToArray<byte>();
			}
			ReadOnlySpan<byte> readOnlySpan2 = readOnlySpan;
			if (!reader.ValueIsEscaped)
			{
				return readOnlySpan2;
			}
			return JsonReaderHelper.GetUnescapedSpan(readOnlySpan2);
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00005611 File Offset: 0x00003811
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TryAdvanceWithOptionalReadAhead([ScopedRef] this Utf8JsonReader reader, bool requiresReadAhead)
		{
			if (!requiresReadAhead || reader.IsFinalBlock)
			{
				return reader.Read();
			}
			return JsonHelpers.TryAdvanceWithReadAhead(ref reader);
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00005634 File Offset: 0x00003834
		public static bool TryAdvanceToNextRootLevelValueWithOptionalReadAhead([ScopedRef] this Utf8JsonReader reader, bool requiresReadAhead, out bool isAtEndOfStream)
		{
			Utf8JsonReader utf8JsonReader = reader;
			if (!reader.Read())
			{
				isAtEndOfStream = reader.IsFinalBlock;
				reader = utf8JsonReader;
				return false;
			}
			isAtEndOfStream = false;
			if (requiresReadAhead && !reader.IsFinalBlock)
			{
				reader = utf8JsonReader;
				return JsonHelpers.TryAdvanceWithReadAhead(ref reader);
			}
			return true;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00005680 File Offset: 0x00003880
		private static bool TryAdvanceWithReadAhead([ScopedRef] ref Utf8JsonReader reader)
		{
			Utf8JsonReader utf8JsonReader = reader;
			if (!reader.Read())
			{
				return false;
			}
			JsonTokenType tokenType = reader.TokenType;
			bool flag = tokenType == JsonTokenType.StartObject || tokenType == JsonTokenType.StartArray;
			if (flag)
			{
				bool flag2 = ref reader.TrySkipPartial();
				reader = utf8JsonReader;
				if (!flag2)
				{
					return false;
				}
				ref reader.ReadWithVerify();
			}
			return true;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000056CE File Offset: 0x000038CE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsInRangeInclusive(uint value, uint lowerBound, uint upperBound)
		{
			return value - lowerBound <= upperBound - lowerBound;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x000056CE File Offset: 0x000038CE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsInRangeInclusive(int value, int lowerBound, int upperBound)
		{
			return value - lowerBound <= upperBound - lowerBound;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x000056CE File Offset: 0x000038CE
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsInRangeInclusive(long value, long lowerBound, long upperBound)
		{
			return value - lowerBound <= upperBound - lowerBound;
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x000056DB File Offset: 0x000038DB
		public static bool IsDigit(byte value)
		{
			return value - 48 <= 9;
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x000056E8 File Offset: 0x000038E8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ReadWithVerify(this Utf8JsonReader reader)
		{
			reader.Read();
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x000056F1 File Offset: 0x000038F1
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void SkipWithVerify(this Utf8JsonReader reader)
		{
			reader.TrySkipPartial(reader.CurrentDepth);
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00005700 File Offset: 0x00003900
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool TrySkipPartial(this Utf8JsonReader reader)
		{
			return reader.TrySkipPartial(reader.CurrentDepth);
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x0000570E File Offset: 0x0000390E
		public static string Utf8GetString(ReadOnlySpan<byte> bytes)
		{
			return Encoding.UTF8.GetString(bytes);
		}

		// Token: 0x060001E7 RID: 487 RVA: 0x0000571C File Offset: 0x0000391C
		public unsafe static bool TryLookupUtf8Key<TValue>(this Dictionary<string, TValue> dictionary, ReadOnlySpan<byte> utf8Key, [MaybeNullWhen(false)] out TValue result)
		{
			Dictionary<string, TValue>.AlternateLookup<ReadOnlySpan<char>> alternateLookup = dictionary.GetAlternateLookup<ReadOnlySpan<char>>();
			char[] array = null;
			Span<char> span;
			if (utf8Key.Length <= 128)
			{
				span = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			}
			else
			{
				span = (array = ArrayPool<char>.Shared.Rent(utf8Key.Length));
			}
			Span<char> chars = span;
			int chars2 = Encoding.UTF8.GetChars(utf8Key, chars);
			Span<char> span2 = chars.Slice(0, chars2);
			bool result2 = alternateLookup.TryGetValue(span2, out result);
			if (array != null)
			{
				span2.Clear();
				ArrayPool<char>.Shared.Return(array, false);
			}
			return result2;
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x000057B0 File Offset: 0x000039B0
		public static bool IsFinite(double value)
		{
			return double.IsFinite(value);
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x000057B8 File Offset: 0x000039B8
		public static bool IsFinite(float value)
		{
			return float.IsFinite(value);
		}

		// Token: 0x060001EA RID: 490 RVA: 0x000057C0 File Offset: 0x000039C0
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static void ValidateInt32MaxArrayLength(uint length)
		{
			if (length > 2146435071U)
			{
				ThrowHelper.ThrowOutOfMemoryException(length);
			}
		}

		// Token: 0x060001EB RID: 491 RVA: 0x000057D0 File Offset: 0x000039D0
		[GeneratedRegex("^\\s*(?:\\+|\\-)?[0-9]+\\s*$", RegexOptions.None, 200)]
		[GeneratedCode("System.Text.RegularExpressions.Generator", "42.42.42.42")]
		private static Regex CreateIntegerRegex()
		{
			return <RegexGenerator_g>FF0B86FD9EADE5565B35262EA8617C59095F75A9758F2D41850EA4896778EEDAE__CreateIntegerRegex_0.Instance;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x000057D8 File Offset: 0x000039D8
		public static bool AreEqualJsonNumbers(ReadOnlySpan<byte> left, ReadOnlySpan<byte> right)
		{
			bool flag;
			ReadOnlySpan<byte> readOnlySpan;
			ReadOnlySpan<byte> readOnlySpan2;
			int num;
			JsonHelpers.<AreEqualJsonNumbers>g__ParseNumber|25_0(left, out flag, out readOnlySpan, out readOnlySpan2, out num);
			bool flag2;
			ReadOnlySpan<byte> readOnlySpan3;
			ReadOnlySpan<byte> readOnlySpan4;
			int num2;
			JsonHelpers.<AreEqualJsonNumbers>g__ParseNumber|25_0(right, out flag2, out readOnlySpan3, out readOnlySpan4, out num2);
			if (flag != flag2 || num != num2 || readOnlySpan.Length + readOnlySpan2.Length != readOnlySpan3.Length + readOnlySpan4.Length)
			{
				return false;
			}
			int num3 = readOnlySpan.Length - readOnlySpan3.Length;
			ReadOnlySpan<byte> span;
			ReadOnlySpan<byte> span2;
			ReadOnlySpan<byte> span3;
			ReadOnlySpan<byte> other;
			ReadOnlySpan<byte> other2;
			ReadOnlySpan<byte> other3;
			if (num3 >= 0)
			{
				if (num3 != 0)
				{
					int num4 = readOnlySpan.Length - num3;
					span = readOnlySpan.Slice(0, num4);
					span2 = readOnlySpan.Slice(num4);
					span3 = readOnlySpan2;
					other = readOnlySpan3;
					other2 = readOnlySpan4.Slice(0, num3);
					other3 = readOnlySpan4.Slice(num3);
				}
				else
				{
					span = readOnlySpan;
					span2 = default(ReadOnlySpan<byte>);
					span3 = readOnlySpan2;
					other = readOnlySpan3;
					other2 = default(ReadOnlySpan<byte>);
					other3 = readOnlySpan4;
				}
			}
			else
			{
				span = readOnlySpan;
				span2 = readOnlySpan2.Slice(0, -num3);
				span3 = readOnlySpan2.Slice(-num3);
				int num5 = readOnlySpan3.Length + num3;
				other = readOnlySpan3.Slice(0, num5);
				other2 = readOnlySpan3.Slice(num5);
				other3 = readOnlySpan4;
			}
			return span.SequenceEqual(other) && span2.SequenceEqual(other2) && span3.SequenceEqual(other3);
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00005910 File Offset: 0x00003B10
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsValidDateTimeOffsetParseLength(int length)
		{
			return JsonHelpers.IsInRangeInclusive(length, 10, 252);
		}

		// Token: 0x060001EE RID: 494 RVA: 0x0000591F File Offset: 0x00003B1F
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static bool IsValidUnescapedDateTimeOffsetParseLength(int length)
		{
			return JsonHelpers.IsInRangeInclusive(length, 10, 42);
		}

		// Token: 0x060001EF RID: 495 RVA: 0x0000592C File Offset: 0x00003B2C
		public static bool TryParseAsISO(ReadOnlySpan<byte> source, out DateTime value)
		{
			JsonHelpers.DateTimeParseData dateTimeParseData;
			if (!JsonHelpers.TryParseDateTimeOffset(source, out dateTimeParseData))
			{
				value = default(DateTime);
				return false;
			}
			if (dateTimeParseData.OffsetToken == 90)
			{
				return JsonHelpers.TryCreateDateTime(dateTimeParseData, DateTimeKind.Utc, out value);
			}
			if (dateTimeParseData.OffsetToken != 43 && dateTimeParseData.OffsetToken != 45)
			{
				return JsonHelpers.TryCreateDateTime(dateTimeParseData, DateTimeKind.Unspecified, out value);
			}
			DateTimeOffset dateTimeOffset;
			if (!JsonHelpers.TryCreateDateTimeOffset(ref dateTimeParseData, out dateTimeOffset))
			{
				value = default(DateTime);
				return false;
			}
			value = dateTimeOffset.LocalDateTime;
			return true;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000059A0 File Offset: 0x00003BA0
		public static bool TryParseAsISO(ReadOnlySpan<byte> source, out DateTimeOffset value)
		{
			JsonHelpers.DateTimeParseData dateTimeParseData;
			if (!JsonHelpers.TryParseDateTimeOffset(source, out dateTimeParseData))
			{
				value = default(DateTimeOffset);
				return false;
			}
			if (dateTimeParseData.OffsetToken == 90 || dateTimeParseData.OffsetToken == 43 || dateTimeParseData.OffsetToken == 45)
			{
				return JsonHelpers.TryCreateDateTimeOffset(ref dateTimeParseData, out value);
			}
			return JsonHelpers.TryCreateDateTimeOffsetInterpretingDataAsLocalTime(dateTimeParseData, out value);
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x000059F0 File Offset: 0x00003BF0
		public static bool TryParseAsIso(ReadOnlySpan<byte> source, out DateOnly value)
		{
			JsonHelpers.DateTimeParseData dateTimeParseData;
			DateTime dateTime;
			if (JsonHelpers.TryParseDateTimeOffset(source, out dateTimeParseData) && dateTimeParseData.IsCalendarDateOnly && JsonHelpers.TryCreateDateTime(dateTimeParseData, DateTimeKind.Unspecified, out dateTime))
			{
				value = DateOnly.FromDateTime(dateTime);
				return true;
			}
			value = default(DateOnly);
			return false;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00005A30 File Offset: 0x00003C30
		private unsafe static bool TryParseDateTimeOffset(ReadOnlySpan<byte> source, out JsonHelpers.DateTimeParseData parseData)
		{
			parseData = default(JsonHelpers.DateTimeParseData);
			uint num = (uint)(*source[0] - 48);
			uint num2 = (uint)(*source[1] - 48);
			uint num3 = (uint)(*source[2] - 48);
			uint num4 = (uint)(*source[3] - 48);
			if (num > 9U || num2 > 9U || num3 > 9U || num4 > 9U)
			{
				return false;
			}
			parseData.Year = (int)(num * 1000U + num2 * 100U + num3 * 10U + num4);
			if (*source[4] != 45 || !JsonHelpers.TryGetNextTwoDigits(source.Slice(5, 2), ref parseData.Month) || *source[7] != 45 || !JsonHelpers.TryGetNextTwoDigits(source.Slice(8, 2), ref parseData.Day))
			{
				return false;
			}
			if (source.Length == 10)
			{
				parseData.IsCalendarDateOnly = true;
				return true;
			}
			if (source.Length < 16)
			{
				return false;
			}
			if (*source[10] != 84 || *source[13] != 58 || !JsonHelpers.TryGetNextTwoDigits(source.Slice(11, 2), ref parseData.Hour) || !JsonHelpers.TryGetNextTwoDigits(source.Slice(14, 2), ref parseData.Minute))
			{
				return false;
			}
			if (source.Length == 16)
			{
				return true;
			}
			byte b = *source[16];
			int num5 = 17;
			if (b <= 45)
			{
				if (b == 43 || b == 45)
				{
					parseData.OffsetToken = b;
					return JsonHelpers.<TryParseDateTimeOffset>g__ParseOffset|32_0(ref parseData, source.Slice(num5));
				}
			}
			else if (b != 58)
			{
				if (b == 90)
				{
					parseData.OffsetToken = 90;
					return num5 == source.Length;
				}
			}
			else
			{
				if (source.Length < 19 || !JsonHelpers.TryGetNextTwoDigits(source.Slice(17, 2), ref parseData.Second))
				{
					return false;
				}
				if (source.Length == 19)
				{
					return true;
				}
				b = *source[19];
				num5 = 20;
				switch (b)
				{
				case 43:
				case 45:
					parseData.OffsetToken = b;
					return JsonHelpers.<TryParseDateTimeOffset>g__ParseOffset|32_0(ref parseData, source.Slice(num5));
				case 44:
					break;
				case 46:
				{
					if (source.Length < 21)
					{
						return false;
					}
					int i = 0;
					int num6 = Math.Min(num5 + 16, source.Length);
					while (num5 < num6 && JsonHelpers.IsDigit(b = *source[num5]))
					{
						if (i < 7)
						{
							parseData.Fraction = parseData.Fraction * 10 + (int)(b - 48);
							i++;
						}
						num5++;
					}
					if (parseData.Fraction != 0)
					{
						while (i < 7)
						{
							parseData.Fraction *= 10;
							i++;
						}
					}
					if (num5 == source.Length)
					{
						return true;
					}
					b = *source[num5++];
					if (b == 43 || b == 45)
					{
						parseData.OffsetToken = b;
						return JsonHelpers.<TryParseDateTimeOffset>g__ParseOffset|32_0(ref parseData, source.Slice(num5));
					}
					if (b == 90)
					{
						parseData.OffsetToken = 90;
						return num5 == source.Length;
					}
					return false;
				}
				default:
					if (b == 90)
					{
						parseData.OffsetToken = 90;
						return num5 == source.Length;
					}
					break;
				}
				return false;
			}
			return false;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00005D20 File Offset: 0x00003F20
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private unsafe static bool TryGetNextTwoDigits(ReadOnlySpan<byte> source, ref int value)
		{
			uint num = (uint)(*source[0] - 48);
			uint num2 = (uint)(*source[1] - 48);
			if (num > 9U || num2 > 9U)
			{
				value = 0;
				return false;
			}
			value = (int)(num * 10U + num2);
			return true;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00005D60 File Offset: 0x00003F60
		private static bool TryCreateDateTimeOffset(DateTime dateTime, ref JsonHelpers.DateTimeParseData parseData, out DateTimeOffset value)
		{
			if (parseData.OffsetHours > 14)
			{
				value = default(DateTimeOffset);
				return false;
			}
			if (parseData.OffsetMinutes > 59)
			{
				value = default(DateTimeOffset);
				return false;
			}
			if (parseData.OffsetHours == 14 && parseData.OffsetMinutes != 0)
			{
				value = default(DateTimeOffset);
				return false;
			}
			long num = ((long)parseData.OffsetHours * 3600L + (long)parseData.OffsetMinutes * 60L) * 10000000L;
			if (parseData.OffsetNegative)
			{
				num = -num;
			}
			try
			{
				value = new DateTimeOffset(dateTime.Ticks, new TimeSpan(num));
			}
			catch (ArgumentOutOfRangeException)
			{
				value = default(DateTimeOffset);
				return false;
			}
			return true;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00005E18 File Offset: 0x00004018
		private static bool TryCreateDateTimeOffset(ref JsonHelpers.DateTimeParseData parseData, out DateTimeOffset value)
		{
			DateTime dateTime;
			if (!JsonHelpers.TryCreateDateTime(parseData, DateTimeKind.Unspecified, out dateTime))
			{
				value = default(DateTimeOffset);
				return false;
			}
			if (!JsonHelpers.TryCreateDateTimeOffset(dateTime, ref parseData, out value))
			{
				value = default(DateTimeOffset);
				return false;
			}
			return true;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x00005E54 File Offset: 0x00004054
		private static bool TryCreateDateTimeOffsetInterpretingDataAsLocalTime(JsonHelpers.DateTimeParseData parseData, out DateTimeOffset value)
		{
			DateTime dateTime;
			if (!JsonHelpers.TryCreateDateTime(parseData, DateTimeKind.Local, out dateTime))
			{
				value = default(DateTimeOffset);
				return false;
			}
			try
			{
				value = new DateTimeOffset(dateTime);
			}
			catch (ArgumentOutOfRangeException)
			{
				value = default(DateTimeOffset);
				return false;
			}
			return true;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x00005EA4 File Offset: 0x000040A4
		private unsafe static bool TryCreateDateTime(JsonHelpers.DateTimeParseData parseData, DateTimeKind kind, out DateTime value)
		{
			if (parseData.Year == 0)
			{
				value = default(DateTime);
				return false;
			}
			if (parseData.Month - 1 >= 12)
			{
				value = default(DateTime);
				return false;
			}
			uint num = (uint)(parseData.Day - 1);
			if (num >= 28U && (ulong)num >= (ulong)((long)DateTime.DaysInMonth(parseData.Year, parseData.Month)))
			{
				value = default(DateTime);
				return false;
			}
			if (parseData.Hour > 23)
			{
				value = default(DateTime);
				return false;
			}
			if (parseData.Minute > 59)
			{
				value = default(DateTime);
				return false;
			}
			if (parseData.Second > 59)
			{
				value = default(DateTime);
				return false;
			}
			ReadOnlySpan<int> readOnlySpan = DateTime.IsLeapYear(parseData.Year) ? JsonHelpers.DaysToMonth366 : JsonHelpers.DaysToMonth365;
			int num2 = parseData.Year - 1;
			long num3 = (long)(num2 * 365 + num2 / 4 - num2 / 100 + num2 / 400 + *readOnlySpan[parseData.Month - 1] + parseData.Day - 1) * 864000000000L;
			int num4 = parseData.Hour * 3600 + parseData.Minute * 60 + parseData.Second;
			num3 += (long)num4 * 10000000L;
			num3 += (long)parseData.Fraction;
			value = new DateTime(num3, kind);
			return true;
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x060001F8 RID: 504 RVA: 0x00005FE2 File Offset: 0x000041E2
		private static ReadOnlySpan<int> DaysToMonth365
		{
			get
			{
				return RuntimeHelpers.CreateSpan<int>(fieldof(<PrivateImplementationDetails>.5857EE4CE98BFABBD62B385C1098507DD0052FF3951043AAD6A1DABD495F18AA4).FieldHandle);
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x00005FEE File Offset: 0x000041EE
		private static ReadOnlySpan<int> DaysToMonth366
		{
			get
			{
				return RuntimeHelpers.CreateSpan<int>(fieldof(<PrivateImplementationDetails>.FADB218011E7702BB9575D0C32A685DA10B5C72EB809BD9A955DB1C76E4D83154).FieldHandle);
			}
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00005FFC File Offset: 0x000041FC
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static byte[] GetEscapedPropertyNameSection(ReadOnlySpan<byte> utf8Value, JavaScriptEncoder encoder)
		{
			int num = JsonWriterHelper.NeedsEscaping(utf8Value, encoder);
			if (num != -1)
			{
				return JsonHelpers.GetEscapedPropertyNameSection(utf8Value, num, encoder);
			}
			return JsonHelpers.GetPropertyNameSection(utf8Value);
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00006024 File Offset: 0x00004224
		public unsafe static byte[] EscapeValue(ReadOnlySpan<byte> utf8Value, int firstEscapeIndexVal, JavaScriptEncoder encoder)
		{
			byte[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(utf8Value.Length, firstEscapeIndexVal);
			Span<byte> span;
			if (maxEscapedLength <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(maxEscapedLength));
			}
			Span<byte> destination = span;
			int length;
			JsonWriterHelper.EscapeString(utf8Value, destination, firstEscapeIndexVal, encoder, out length);
			byte[] result = destination.Slice(0, length).ToArray();
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
			return result;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x000060A4 File Offset: 0x000042A4
		private unsafe static byte[] GetEscapedPropertyNameSection(ReadOnlySpan<byte> utf8Value, int firstEscapeIndexVal, JavaScriptEncoder encoder)
		{
			byte[] array = null;
			int maxEscapedLength = JsonWriterHelper.GetMaxEscapedLength(utf8Value.Length, firstEscapeIndexVal);
			Span<byte> span;
			if (maxEscapedLength <= 256)
			{
				span = new Span<byte>(stackalloc byte[(UIntPtr)256], 256);
			}
			else
			{
				span = (array = ArrayPool<byte>.Shared.Rent(maxEscapedLength));
			}
			Span<byte> destination = span;
			int length;
			JsonWriterHelper.EscapeString(utf8Value, destination, firstEscapeIndexVal, encoder, out length);
			byte[] propertyNameSection = JsonHelpers.GetPropertyNameSection(destination.Slice(0, length));
			if (array != null)
			{
				ArrayPool<byte>.Shared.Return(array, false);
			}
			return propertyNameSection;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00006124 File Offset: 0x00004324
		private static byte[] GetPropertyNameSection(ReadOnlySpan<byte> utf8Value)
		{
			int num = utf8Value.Length;
			byte[] array = new byte[num + 3];
			array[0] = 34;
			utf8Value.CopyTo(array.AsSpan(1, num));
			array[++num] = 34;
			array[num + 1] = 58;
			return array;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00006178 File Offset: 0x00004378
		[CompilerGenerated]
		internal unsafe static void <AreEqualJsonNumbers>g__ParseNumber|25_0(ReadOnlySpan<byte> span, out bool isNegative, out ReadOnlySpan<byte> integral, out ReadOnlySpan<byte> fractional, out int exponent)
		{
			bool flag;
			if (*span[0] == 45)
			{
				flag = true;
				span = span.Slice(1);
			}
			else
			{
				flag = false;
			}
			int num = span.IndexOfAny(46, 101, 69);
			ReadOnlySpan<byte> readOnlySpan;
			ReadOnlySpan<byte> readOnlySpan2;
			int num2;
			if (num < 0)
			{
				readOnlySpan = span;
				readOnlySpan2 = default(ReadOnlySpan<byte>);
				num2 = 0;
			}
			else
			{
				readOnlySpan = span.Slice(0, num);
				if (*span[num] == 46)
				{
					span = span.Slice(num + 1);
					num = span.IndexOfAny(101, 69);
					if (num < 0)
					{
						readOnlySpan2 = span;
						num2 = 0;
						goto IL_B1;
					}
					readOnlySpan2 = span.Slice(0, num);
				}
				else
				{
					readOnlySpan2 = default(ReadOnlySpan<byte>);
				}
				int num3;
				if (!Utf8Parser.TryParse(span.Slice(num + 1), out num2, out num3, '\0'))
				{
					ThrowHelper.ThrowArgumentOutOfRangeException_JsonNumberExponentTooLarge("exponent");
				}
			}
			IL_B1:
			int num4 = JsonHelpers.<AreEqualJsonNumbers>g__IndexOfFirstTrailingZero|25_2(readOnlySpan2);
			if (num4 >= 0)
			{
				readOnlySpan2 = readOnlySpan2.Slice(0, num4);
			}
			if (*readOnlySpan[0] == 48)
			{
				int num5 = JsonHelpers.<AreEqualJsonNumbers>g__IndexOfLastLeadingZero|25_1(readOnlySpan2);
				if (num5 >= 0)
				{
					readOnlySpan2 = readOnlySpan2.Slice(num5 + 1);
					num2 -= num5 + 1;
				}
				readOnlySpan = default(ReadOnlySpan<byte>);
			}
			if (readOnlySpan2.IsEmpty)
			{
				int num6 = JsonHelpers.<AreEqualJsonNumbers>g__IndexOfFirstTrailingZero|25_2(readOnlySpan);
				if (num6 >= 0)
				{
					num2 += readOnlySpan.Length - num6;
					readOnlySpan = readOnlySpan.Slice(0, num6);
				}
			}
			num2 -= readOnlySpan2.Length;
			if (readOnlySpan.IsEmpty && readOnlySpan2.IsEmpty)
			{
				flag = false;
				num2 = 0;
			}
			isNegative = flag;
			integral = readOnlySpan;
			fractional = readOnlySpan2;
			exponent = num2;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x000062E8 File Offset: 0x000044E8
		[CompilerGenerated]
		internal static int <AreEqualJsonNumbers>g__IndexOfLastLeadingZero|25_1(ReadOnlySpan<byte> span)
		{
			int num = span.IndexOfAnyExcept(48);
			if (num >= 0)
			{
				return num - 1;
			}
			return span.Length - 1;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x00006310 File Offset: 0x00004510
		[CompilerGenerated]
		internal static int <AreEqualJsonNumbers>g__IndexOfFirstTrailingZero|25_2(ReadOnlySpan<byte> span)
		{
			int num = span.LastIndexOfAnyExcept(48);
			if (num != span.Length - 1)
			{
				return num + 1;
			}
			return -1;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x00006338 File Offset: 0x00004538
		[CompilerGenerated]
		internal unsafe static bool <TryParseDateTimeOffset>g__ParseOffset|32_0(ref JsonHelpers.DateTimeParseData parseData, ReadOnlySpan<byte> offsetData)
		{
			return offsetData.Length >= 2 && JsonHelpers.TryGetNextTwoDigits(offsetData.Slice(0, 2), ref parseData.OffsetHours) && (offsetData.Length == 2 || (offsetData.Length == 5 && *offsetData[2] == 58 && JsonHelpers.TryGetNextTwoDigits(offsetData.Slice(3), ref parseData.OffsetMinutes)));
		}

		// Token: 0x0400001A RID: 26
		public static readonly Regex IntegerRegex = JsonHelpers.CreateIntegerRegex();

		// Token: 0x02000013 RID: 19
		[StructLayout(LayoutKind.Auto)]
		private struct DateTimeParseData
		{
			// Token: 0x170000E6 RID: 230
			// (get) Token: 0x06000203 RID: 515 RVA: 0x000063A2 File Offset: 0x000045A2
			public bool OffsetNegative
			{
				get
				{
					return this.OffsetToken == 45;
				}
			}

			// Token: 0x0400001B RID: 27
			public int Year;

			// Token: 0x0400001C RID: 28
			public int Month;

			// Token: 0x0400001D RID: 29
			public int Day;

			// Token: 0x0400001E RID: 30
			public bool IsCalendarDateOnly;

			// Token: 0x0400001F RID: 31
			public int Hour;

			// Token: 0x04000020 RID: 32
			public int Minute;

			// Token: 0x04000021 RID: 33
			public int Second;

			// Token: 0x04000022 RID: 34
			public int Fraction;

			// Token: 0x04000023 RID: 35
			public int OffsetHours;

			// Token: 0x04000024 RID: 36
			public int OffsetMinutes;

			// Token: 0x04000025 RID: 37
			public byte OffsetToken;
		}
	}
}
