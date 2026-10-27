using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200008E RID: 142
	[NullableContext(1)]
	[Nullable(0)]
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.EnumAsByte)]
	[UnrealStructLayout(1, 1, UnrealReflectionPropertyTypeCode.EnumAsByte, PropertiesSize = 1)]
	[StructLayout(LayoutKind.Sequential, Pack = 1)]
	public struct TEnumAsByte<[Nullable(0)] T> : IEqualityOperators<TEnumAsByte<T>, TEnumAsByte<T>, bool>, IEquatable<TEnumAsByte<T>> where T : Enum
	{
		// Token: 0x06000FC8 RID: 4040 RVA: 0x0001807C File Offset: 0x0001627C
		static TEnumAsByte()
		{
			if (!BitConverter.IsLittleEndian)
			{
				throw new NotSupportedException("TEnumAsByte<T> only supports little endian system");
			}
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00018090 File Offset: 0x00016290
		public unsafe TEnumAsByte(T value)
		{
			this._value = *(byte*)(&value);
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x0001809C File Offset: 0x0001629C
		public TEnumAsByte(byte value)
		{
			this._value = value;
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x000180A5 File Offset: 0x000162A5
		[return: Nullable(new byte[]
		{
			0,
			1
		})]
		public static implicit operator TEnumAsByte<T>(T value)
		{
			return new TEnumAsByte<T>(value);
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x000180B0 File Offset: 0x000162B0
		public unsafe static implicit operator T([Nullable(new byte[]
		{
			0,
			1
		})] TEnumAsByte<T> value)
		{
			long num = (long)((ulong)value);
			return *(T*)(&num);
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x000180CD File Offset: 0x000162CD
		public static implicit operator byte([Nullable(new byte[]
		{
			0,
			1
		})] TEnumAsByte<T> value)
		{
			return value._value;
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x000180D5 File Offset: 0x000162D5
		public bool Equals([Nullable(new byte[]
		{
			0,
			1
		})] TEnumAsByte<T> other)
		{
			return this._value == other._value;
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x000180E8 File Offset: 0x000162E8
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

		// Token: 0x06000FD0 RID: 4048 RVA: 0x0001810D File Offset: 0x0001630D
		public override readonly int GetHashCode()
		{
			return this._value.GetHashCode();
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x0001811A File Offset: 0x0001631A
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

		// Token: 0x06000FD2 RID: 4050 RVA: 0x0001812A File Offset: 0x0001632A
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

		// Token: 0x06000FD3 RID: 4051 RVA: 0x0001813D File Offset: 0x0001633D
		public override readonly string ToString()
		{
			return this._value.ToString();
		}

		// Token: 0x040001F6 RID: 502
		private byte _value;
	}
}
