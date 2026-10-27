using System;

namespace C
{
	// Token: 0x0200001F RID: 31
	public static class math
	{
		// Token: 0x0600007E RID: 126 RVA: 0x0000583D File Offset: 0x00003A3D
		public unsafe static int SingleToInt32Bits(float value)
		{
			return *(int*)(&value);
		}

		// Token: 0x0600007F RID: 127 RVA: 0x00005843 File Offset: 0x00003A43
		public unsafe static float Int32BitsToSingle(int value)
		{
			return *(float*)(&value);
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000584C File Offset: 0x00003A4C
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

		// Token: 0x06000081 RID: 129 RVA: 0x000058A4 File Offset: 0x00003AA4
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

		// Token: 0x06000082 RID: 130 RVA: 0x0000590D File Offset: 0x00003B0D
		public static int signbit(double number)
		{
			if (double.IsNaN(number))
			{
				return ((BitConverter.DoubleToInt64Bits(number) & long.MinValue) == 0L) ? 1 : 0;
			}
			return ((BitConverter.DoubleToInt64Bits(number) & long.MinValue) != 0L) ? 1 : 0;
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00005940 File Offset: 0x00003B40
		public static int signbit(float number)
		{
			if (double.IsNaN((double)number))
			{
				return ((math.SingleToInt32Bits(number) & int.MinValue) == 0) ? 1 : 0;
			}
			return ((math.SingleToInt32Bits(number) & int.MinValue) != 0) ? 1 : 0;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000596C File Offset: 0x00003B6C
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

		// Token: 0x06000085 RID: 133 RVA: 0x00005A0C File Offset: 0x00003C0C
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

		// Token: 0x06000086 RID: 134 RVA: 0x00005A8C File Offset: 0x00003C8C
		public static double ldexp(double number, int exponent)
		{
			return math.scalbn(number, exponent);
		}

		// Token: 0x06000087 RID: 135 RVA: 0x00005A95 File Offset: 0x00003C95
		public static float ldexp(float number, int exponent)
		{
			return math.scalbn(number, exponent);
		}

		// Token: 0x06000088 RID: 136 RVA: 0x00005A9E File Offset: 0x00003C9E
		public static double scalbn(double number, int exponent)
		{
			return math.scalbln(number, (long)exponent);
		}

		// Token: 0x06000089 RID: 137 RVA: 0x00005AA8 File Offset: 0x00003CA8
		public static float scalbn(float number, int exponent)
		{
			return math.scalbln(number, (long)exponent);
		}

		// Token: 0x0600008A RID: 138 RVA: 0x00005AB4 File Offset: 0x00003CB4
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

		// Token: 0x0600008B RID: 139 RVA: 0x00005BC0 File Offset: 0x00003DC0
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

		// Token: 0x0600008C RID: 140 RVA: 0x00005CA0 File Offset: 0x00003EA0
		public static double copysign(double number1, double number2)
		{
			long num = ((math.signbit(number2) == 1) ? long.MinValue : 0L) ^ (double.IsNaN(number1) ? long.MinValue : 0L);
			return BitConverter.Int64BitsToDouble((BitConverter.DoubleToInt64Bits(number1) & long.MaxValue) | num);
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00005CF4 File Offset: 0x00003EF4
		public static float copysign(float number1, float number2)
		{
			int num = ((math.signbit(number2) == 1) ? int.MinValue : 0) ^ (double.IsNaN((double)number1) ? int.MinValue : 0);
			return math.Int32BitsToSingle((math.SingleToInt32Bits(number1) & int.MaxValue) | num);
		}

		// Token: 0x0400004C RID: 76
		public const long DBL_EXP_MASK = 9218868437227405312L;

		// Token: 0x0400004D RID: 77
		public const int DBL_MANT_BITS = 52;

		// Token: 0x0400004E RID: 78
		public const long DBL_EXP_CLR_MASK = -9218868437227405313L;

		// Token: 0x0400004F RID: 79
		public const long DBL_SGN_MASK = -9223372036854775808L;

		// Token: 0x04000050 RID: 80
		public const long DBL_MANT_MASK = 4503599627370495L;

		// Token: 0x04000051 RID: 81
		public const int FLT_EXP_MASK = 2139095040;

		// Token: 0x04000052 RID: 82
		public const int FLT_MANT_BITS = 23;

		// Token: 0x04000053 RID: 83
		public const int FLT_MANT_MASK = 8388607;

		// Token: 0x04000054 RID: 84
		public const int FLT_EXP_CLR_MASK = -2139095041;

		// Token: 0x04000055 RID: 85
		public const int FLT_SGN_MASK = -2147483648;

		// Token: 0x04000056 RID: 86
		public const long DBL_SGN_CLR_MASK = 9223372036854775807L;

		// Token: 0x04000057 RID: 87
		public const int FLT_SGN_CLR_MASK = 2147483647;
	}
}
