using System;
using System.Buffers;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace System.Text.Json
{
	// Token: 0x02000016 RID: 22
	internal abstract class JsonSeparatorNamingPolicy : JsonNamingPolicy
	{
		// Token: 0x06000206 RID: 518 RVA: 0x000063C4 File Offset: 0x000045C4
		internal JsonSeparatorNamingPolicy(bool lowercase, char separator)
		{
			this._lowercase = lowercase;
			this._separator = separator;
		}

		// Token: 0x06000207 RID: 519 RVA: 0x000063DA File Offset: 0x000045DA
		public sealed override string ConvertName(string name)
		{
			if (name == null)
			{
				ThrowHelper.ThrowArgumentNullException("name");
			}
			return JsonSeparatorNamingPolicy.ConvertNameCore(this._separator, this._lowercase, name.AsSpan());
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00006400 File Offset: 0x00004600
		private unsafe static string ConvertNameCore(char separator, bool lowercase, ReadOnlySpan<char> chars)
		{
			JsonSeparatorNamingPolicy.<>c__DisplayClass4_0 CS$<>8__locals1;
			CS$<>8__locals1.rentedBuffer = null;
			int num = (int)(1.2 * (double)chars.Length);
			Span<char> span;
			if (num <= 128)
			{
				span = new Span<char>(stackalloc byte[(UIntPtr)256], 128);
			}
			else
			{
				span = (CS$<>8__locals1.rentedBuffer = ArrayPool<char>.Shared.Rent(num));
			}
			Span<char> span2 = span;
			JsonSeparatorNamingPolicy.SeparatorState separatorState = JsonSeparatorNamingPolicy.SeparatorState.NotStarted;
			CS$<>8__locals1.charsWritten = 0;
			int i = 0;
			while (i < chars.Length)
			{
				char c = (char)(*chars[i]);
				UnicodeCategory unicodeCategory = char.GetUnicodeCategory(c);
				if (unicodeCategory <= UnicodeCategory.LowercaseLetter)
				{
					if (unicodeCategory != UnicodeCategory.UppercaseLetter)
					{
						if (unicodeCategory != UnicodeCategory.LowercaseLetter)
						{
							goto IL_149;
						}
						goto IL_114;
					}
					else
					{
						switch (separatorState)
						{
						case JsonSeparatorNamingPolicy.SeparatorState.UppercaseLetter:
							if (i + 1 < chars.Length && char.IsLower((char)(*chars[i + 1])))
							{
								JsonSeparatorNamingPolicy.<ConvertNameCore>g__WriteChar|4_0(separator, ref span2, ref CS$<>8__locals1);
							}
							break;
						case JsonSeparatorNamingPolicy.SeparatorState.LowercaseLetterOrDigit:
						case JsonSeparatorNamingPolicy.SeparatorState.SpaceSeparator:
							JsonSeparatorNamingPolicy.<ConvertNameCore>g__WriteChar|4_0(separator, ref span2, ref CS$<>8__locals1);
							break;
						}
						if (lowercase)
						{
							c = char.ToLowerInvariant(c);
						}
						JsonSeparatorNamingPolicy.<ConvertNameCore>g__WriteChar|4_0(c, ref span2, ref CS$<>8__locals1);
						separatorState = JsonSeparatorNamingPolicy.SeparatorState.UppercaseLetter;
					}
				}
				else
				{
					if (unicodeCategory == UnicodeCategory.DecimalDigitNumber)
					{
						goto IL_114;
					}
					if (unicodeCategory != UnicodeCategory.SpaceSeparator)
					{
						goto IL_149;
					}
					if (separatorState != JsonSeparatorNamingPolicy.SeparatorState.NotStarted)
					{
						separatorState = JsonSeparatorNamingPolicy.SeparatorState.SpaceSeparator;
					}
				}
				IL_156:
				i++;
				continue;
				IL_114:
				if (separatorState == JsonSeparatorNamingPolicy.SeparatorState.SpaceSeparator)
				{
					JsonSeparatorNamingPolicy.<ConvertNameCore>g__WriteChar|4_0(separator, ref span2, ref CS$<>8__locals1);
				}
				if (!lowercase && unicodeCategory == UnicodeCategory.LowercaseLetter)
				{
					c = char.ToUpperInvariant(c);
				}
				JsonSeparatorNamingPolicy.<ConvertNameCore>g__WriteChar|4_0(c, ref span2, ref CS$<>8__locals1);
				separatorState = JsonSeparatorNamingPolicy.SeparatorState.LowercaseLetterOrDigit;
				goto IL_156;
				IL_149:
				JsonSeparatorNamingPolicy.<ConvertNameCore>g__WriteChar|4_0(c, ref span2, ref CS$<>8__locals1);
				separatorState = JsonSeparatorNamingPolicy.SeparatorState.NotStarted;
				goto IL_156;
			}
			string result = span2.Slice(0, CS$<>8__locals1.charsWritten).ToString();
			if (CS$<>8__locals1.rentedBuffer != null)
			{
				span2.Slice(0, CS$<>8__locals1.charsWritten).Clear();
				ArrayPool<char>.Shared.Return(CS$<>8__locals1.rentedBuffer, false);
			}
			return result;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x000065C4 File Offset: 0x000047C4
		[CompilerGenerated]
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		internal unsafe static void <ConvertNameCore>g__WriteChar|4_0(char value, ref Span<char> destination, ref JsonSeparatorNamingPolicy.<>c__DisplayClass4_0 A_2)
		{
			if (A_2.charsWritten == destination.Length)
			{
				JsonSeparatorNamingPolicy.<ConvertNameCore>g__ExpandBuffer|4_1(ref destination, ref A_2);
			}
			int charsWritten = A_2.charsWritten;
			A_2.charsWritten = charsWritten + 1;
			*destination[charsWritten] = value;
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00006600 File Offset: 0x00004800
		[CompilerGenerated]
		internal static void <ConvertNameCore>g__ExpandBuffer|4_1(ref Span<char> destination, ref JsonSeparatorNamingPolicy.<>c__DisplayClass4_0 A_1)
		{
			int minimumLength = checked(destination.Length * 2);
			char[] array = ArrayPool<char>.Shared.Rent(minimumLength);
			destination.CopyTo(array);
			if (A_1.rentedBuffer != null)
			{
				destination.Slice(0, A_1.charsWritten).Clear();
				ArrayPool<char>.Shared.Return(A_1.rentedBuffer, false);
			}
			A_1.rentedBuffer = array;
			destination = A_1.rentedBuffer;
		}

		// Token: 0x04000026 RID: 38
		private readonly bool _lowercase;

		// Token: 0x04000027 RID: 39
		private readonly char _separator;

		// Token: 0x02000017 RID: 23
		private enum SeparatorState
		{
			// Token: 0x04000029 RID: 41
			NotStarted,
			// Token: 0x0400002A RID: 42
			UppercaseLetter,
			// Token: 0x0400002B RID: 43
			LowercaseLetterOrDigit,
			// Token: 0x0400002C RID: 44
			SpaceSeparator
		}
	}
}
