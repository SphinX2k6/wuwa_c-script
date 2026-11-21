using System;

namespace C
{
	// Token: 0x02000004 RID: 4
	public static class math
	{
		// Token: 0x06000003 RID: 3 RVA: 0x000020A9 File Offset: 0x000002A9
		public unsafe static int SingleToInt32Bits(float value)
		{
			return *(int*)(&value);
		}

		// Token: 0x06000004 RID: 4 RVA: 0x000020AF File Offset: 0x000002AF
		public unsafe static float Int32BitsToSingle(int value)
		{
			return *(float*)(&value);
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000020B8 File Offset: 0x000002B8
		private static int _leadingZeroesCount(int x)
		{
			int num = 32;
			int num2 = x >> 16;
			if (num2 != 0)
			{
				num -= 16;
				x = num2;
			}
			num2 = x >> 8;
			if (num2 != 0)
			{
				num -= 8;
				x = num2;
			}
			num2 = x >> 4;
			if (num2 != 0)
			{
				num -= 4;
				x = num2;
			}
			num2 = x >> 2;
			if (num2 != 0)
			{
				num -= 2;
				x = num2;
			}
			num2 = x >> 1;
			if (num2 != 0)
			{
				return num - 2;
			}
			return num - x;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x00002110 File Offset: 0x00000310
		private static int _leadingZeroesCount(long x)
		{
			int num = 64;
			long num2 = x >> 32;
			if (num2 != 0L)
			{
				num -= 32;
				x = num2;
			}
			num2 = x >> 16;
			if (num2 != 0L)
			{
				num -= 16;
				x = num2;
			}
			num2 = x >> 8;
			if (num2 != 0L)
			{
				num -= 8;
				x = num2;
			}
			num2 = x >> 4;
			if (num2 != 0L)
			{
				num -= 4;
				x = num2;
			}
			num2 = x >> 2;
			if (num2 != 0L)
			{
				num -= 2;
				x = num2;
			}
			num2 = x >> 1;
			if (num2 != 0L)
			{
				return num - 2;
			}
			return num - (int)x;
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002179 File Offset: 0x00000379
		public static int signbit(double number)
		{
			if (double.IsNaN(number))
			{
				return ((BitConverter.DoubleToInt64Bits(number) & long.MinValue) == 0L) ? 1 : 0;
			}
			return ((BitConverter.DoubleToInt64Bits(number) & long.MinValue) != 0L) ? 1 : 0;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000021AC File Offset: 0x000003AC
		public static int signbit(float number)
		{
			if (double.IsNaN((double)number))
			{
				return ((math.SingleToInt32Bits(number) & int.MinValue) == 0) ? 1 : 0;
			}
			return ((math.SingleToInt32Bits(number) & int.MinValue) != 0) ? 1 : 0;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000021D8 File Offset: 0x000003D8
		public static double frexp(double number, ref int exponent)
		{
			long num = BitConverter.DoubleToInt64Bits(number);
			int num2 = (int)((num & 9218868437227405312L) >> 52);
			exponent = 0;
			if (num2 == 2047 || number == 0.0)
			{
				number += number;
			}
			else
			{
				exponent = num2 - 1022;
				if (num2 == 0)
				{
					number *= BitConverter.Int64BitsToDouble(4850376798678024192L);
					num = BitConverter.DoubleToInt64Bits(number);
					num2 = (int)((num & 9218868437227405312L) >> 52);
					exponent = num2 - 1022 - 54;
				}
				number = BitConverter.Int64BitsToDouble((num & -9218868437227405313L) | 4602678819172646912L);
			}
			return number;
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002278 File Offset: 0x00000478
		public static float frexp(float number, ref int exponent)
		{
			int num = math.SingleToInt32Bits(number);
			int num2 = (num & 2139095040) >> 23;
			exponent = 0;
			if (num2 == 255 || number == 0f)
			{
				number += number;
			}
			else
			{
				exponent = num2 - 126;
				if (num2 == 0)
				{
					number *= math.Int32BitsToSingle(1275068416);
					num = math.SingleToInt32Bits(number);
					num2 = (num & 2139095040) >> 23;
					exponent = num2 - 126 - 25;
				}
				number = math.Int32BitsToSingle((num & -2139095041) | 1056964608);
			}
			return number;
		}

		// Token: 0x0600000B RID: 11 RVA: 0x000022F8 File Offset: 0x000004F8
		public static double ldexp(double number, int exponent)
		{
			return math.scalbn(number, exponent);
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002301 File Offset: 0x00000501
		public static float ldexp(float number, int exponent)
		{
			return math.scalbn(number, exponent);
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000230A File Offset: 0x0000050A
		public static double scalbn(double number, int exponent)
		{
			return math.scalbln(number, (long)exponent);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002314 File Offset: 0x00000514
		public static float scalbn(float number, int exponent)
		{
			return math.scalbln(number, (long)exponent);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002320 File Offset: 0x00000520
		public static double scalbln(double number, long exponent)
		{
			long num = BitConverter.DoubleToInt64Bits(number);
			int num2 = (int)((num & 9218868437227405312L) >> 52);
			if (num2 == 2047)
			{
				return number;
			}
			if (num2 == 0)
			{
				if ((num & 4503599627370495L) == 0L)
				{
					return number;
				}
				number *= BitConverter.Int64BitsToDouble(4850376798678024192L);
				num = BitConverter.DoubleToInt64Bits(number);
				num2 = (int)((num & 9218868437227405312L) >> 52) - 54;
			}
			if (exponent < -50000L)
			{
				return math.copysign(0.0, number);
			}
			if (exponent > 50000L || (long)num2 + exponent > 2046L)
			{
				return math.copysign(double.PositiveInfinity, number);
			}
			num2 += (int)exponent;
			if (num2 > 0)
			{
				return BitConverter.Int64BitsToDouble((num & -9218868437227405313L) | (long)num2 << 52);
			}
			if (num2 <= -54)
			{
				return math.copysign(0.0, number);
			}
			num2 += 54;
			number = BitConverter.Int64BitsToDouble((num & -9218868437227405313L) | (long)num2 << 52);
			return number * BitConverter.Int64BitsToDouble(4363988038922010624L);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x0000242C File Offset: 0x0000062C
		public static float scalbln(float number, long exponent)
		{
			int num = math.SingleToInt32Bits(number);
			int num2 = (num & 2139095040) >> 23;
			if (num2 == 255)
			{
				return number;
			}
			if (num2 == 0)
			{
				if ((num & 8388607) == 0)
				{
					return number;
				}
				number *= math.Int32BitsToSingle(1275068416);
				num = math.SingleToInt32Bits(number);
				num2 = ((num & 2139095040) >> 23) - 25;
			}
			if (exponent < -50000L)
			{
				return math.copysign(0f, number);
			}
			if (exponent > 50000L || (long)num2 + exponent > 254L)
			{
				return math.copysign(float.PositiveInfinity, number);
			}
			num2 += (int)exponent;
			if (num2 > 0)
			{
				return math.Int32BitsToSingle((num & -2139095041) | num2 << 23);
			}
			if (num2 <= -25)
			{
				return math.copysign(0f, number);
			}
			num2 += 25;
			number = math.Int32BitsToSingle((num & -2139095041) | num2 << 23);
			return number * math.Int32BitsToSingle(855638016);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000250C File Offset: 0x0000070C
		public static double copysign(double number1, double number2)
		{
			long num = ((math.signbit(number2) == 1) ? long.MinValue : 0L) ^ (double.IsNaN(number1) ? long.MinValue : 0L);
			return BitConverter.Int64BitsToDouble((BitConverter.DoubleToInt64Bits(number1) & long.MaxValue) | num);
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002560 File Offset: 0x00000760
		public static float copysign(float number1, float number2)
		{
			int num = ((math.signbit(number2) == 1) ? int.MinValue : 0) ^ (double.IsNaN((double)number1) ? int.MinValue : 0);
			return math.Int32BitsToSingle((math.SingleToInt32Bits(number1) & int.MaxValue) | num);
		}

		// Token: 0x04000005 RID: 5
		public const long DBL_EXP_MASK = 9218868437227405312L;

		// Token: 0x04000006 RID: 6
		public const int DBL_MANT_BITS = 52;

		// Token: 0x04000007 RID: 7
		public const long DBL_EXP_CLR_MASK = -9218868437227405313L;

		// Token: 0x04000008 RID: 8
		public const long DBL_SGN_MASK = -9223372036854775808L;

		// Token: 0x04000009 RID: 9
		public const long DBL_MANT_MASK = 4503599627370495L;

		// Token: 0x0400000A RID: 10
		public const int FLT_EXP_MASK = 2139095040;

		// Token: 0x0400000B RID: 11
		public const int FLT_MANT_BITS = 23;

		// Token: 0x0400000C RID: 12
		public const int FLT_MANT_MASK = 8388607;

		// Token: 0x0400000D RID: 13
		public const int FLT_EXP_CLR_MASK = -2139095041;

		// Token: 0x0400000E RID: 14
		public const int FLT_SGN_MASK = -2147483648;

		// Token: 0x0400000F RID: 15
		public const long DBL_SGN_CLR_MASK = 9223372036854775807L;

		// Token: 0x04000010 RID: 16
		public const int FLT_SGN_CLR_MASK = 2147483647;
	}
}
