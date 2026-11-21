using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000073 RID: 115
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.EnumAsByte)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.EnumAsByte, PropertiesSize = 1)]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct TEnumAsByte<[Nullable(0)] T> : IEqualityOperators<TEnumAsByte<T>, TEnumAsByte<T>, bool>, IEquatable<TEnumAsByte<T>> where T : Enum
	{
		// Token: 0x06000B5B RID: 2907 RVA: 0x00012DA0 File Offset: 0x00010FA0
		static TEnumAsByte()
		{
			if (!BitConverter.IsLittleEndian)
			{
				throw new NotSupportedException("TEnumAsByte<T> only supports little endian system");
			}
		}

		// Token: 0x06000B5C RID: 2908 RVA: 0x00012DB4 File Offset: 0x00010FB4
		public unsafe TEnumAsByte(T value)
		{
			this._value = *(byte*)(&value);
		}

		// Token: 0x06000B5D RID: 2909 RVA: 0x00012DC0 File Offset: 0x00010FC0
		public TEnumAsByte(byte value)
		{
			this._value = value;
		}

		// Token: 0x06000B5E RID: 2910 RVA: 0x00012DC9 File Offset: 0x00010FC9
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator TEnumAsByte<T>(T value)
		{
			return new TEnumAsByte<T>(value);
		}

		// Token: 0x06000B5F RID: 2911 RVA: 0x00012DD4 File Offset: 0x00010FD4
		public unsafe static implicit operator T([Nullable(new byte[]
		{
			0,
			1
		})] TEnumAsByte<T> value)
		{
			long num = (long)((ulong)value);
			return *(T*)(&num);
		}

		// Token: 0x06000B60 RID: 2912 RVA: 0x00012DF1 File Offset: 0x00010FF1
		public static implicit operator byte([Nullable(new byte[]
		{
			0,
			1
		})] TEnumAsByte<T> value)
		{
			return value._value;
		}

		// Token: 0x06000B61 RID: 2913 RVA: 0x00012DF9 File Offset: 0x00010FF9
		public bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] TEnumAsByte<T> other)
		{
			return this._value == other._value;
		}

		// Token: 0x06000B62 RID: 2914 RVA: 0x00012E0C File Offset: 0x0001100C
		[NullableContext(2)]
		public override bool Equals(object obj)
		{
			if (obj is TEnumAsByte<T>)
			{
				TEnumAsByte<T> other = (TEnumAsByte<T>)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000B63 RID: 2915 RVA: 0x00012E31 File Offset: 0x00011031
		public override readonly int GetHashCode()
		{
			return this._value.GetHashCode();
		}

		// Token: 0x06000B64 RID: 2916 RVA: 0x00012E3E File Offset: 0x0001103E
		public static bool operator ==([Nullable(new byte[]
		{
			0,
			1
		})] TEnumAsByte<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] TEnumAsByte<T> right)
		{
			return left._value == right._value;
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x00012E4E File Offset: 0x0001104E
		public static bool operator !=([Nullable(new byte[]
		{
			0,
			1
		})] TEnumAsByte<T> left, [Nullable(new byte[]
		{
			0,
			1
		})] TEnumAsByte<T> right)
		{
			return left._value != right._value;
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x00012E61 File Offset: 0x00011061
		public override readonly string ToString()
		{
			return this._value.ToString();
		}

		// Token: 0x040001AF RID: 431
		private byte _value;
	}
}
