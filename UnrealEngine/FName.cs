using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000064 RID: 100
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.Name)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.Name, PropertiesSize = 12)]
	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 12)]
	public struct FName : IEqualityOperators<FName, FName, bool>, IEquatable<FName>
	{
		// Token: 0x06000A44 RID: 2628 RVA: 0x00010E1F File Offset: 0x0000F01F
		public FName()
		{
			this.ComparisonIndex = 0U;
			this.DisplayIndex = 0U;
			this.Number = 0U;
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x00010E38 File Offset: 0x0000F038
		[NullableContext(2)]
		public unsafe FName(string name)
		{
			this.ComparisonIndex = 0U;
			this.DisplayIndex = 0U;
			this.Number = 0U;
			if (name != null && name.Length != 0)
			{
				char* ptr;
				if (name == null)
				{
					ptr = null;
				}
				else
				{
					fixed (char* ptr2 = name.GetPinnableReference())
					{
						ptr = ptr2;
					}
				}
				char* str = ptr;
				fixed (FName* ptr3 = &this)
				{
					FName.FromString(ptr3, str, name.Length);
				}
				char* ptr2 = null;
			}
		}

		// Token: 0x06000A46 RID: 2630 RVA: 0x00010E8C File Offset: 0x0000F08C
		public FName(uint ComparisonIndex, uint DisplayIndex, uint Number)
		{
			this.ComparisonIndex = ComparisonIndex;
			this.DisplayIndex = DisplayIndex;
			this.Number = Number;
		}

		// Token: 0x06000A47 RID: 2631 RVA: 0x00010EA4 File Offset: 0x0000F0A4
		public unsafe FName(ReadOnlySpan<char> name)
		{
			this.ComparisonIndex = 0U;
			this.DisplayIndex = 0U;
			this.Number = 0U;
			if (name.Length != 0)
			{
				fixed (char* pinnableReference = name.GetPinnableReference())
				{
					char* str = pinnableReference;
					fixed (FName* ptr = &this)
					{
						FName.FromString(ptr, str, name.Length);
					}
				}
			}
		}

		// Token: 0x06000A48 RID: 2632 RVA: 0x00010EF4 File Offset: 0x0000F0F4
		public unsafe FName(ReadOnlySpan<byte> name)
		{
			this.ComparisonIndex = 0U;
			this.DisplayIndex = 0U;
			this.Number = 0U;
			if (name.Length != 0)
			{
				fixed (byte* pinnableReference = name.GetPinnableReference())
				{
					byte* str = pinnableReference;
					fixed (FName* ptr = &this)
					{
						FName.FromAnsiString(ptr, str, name.Length);
					}
				}
			}
		}

		// Token: 0x06000A49 RID: 2633
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern void FromString(FName* Name, char* Str, int Length);

		// Token: 0x06000A4A RID: 2634
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern void FromAnsiString(FName* Name, byte* Str, int Length);

		// Token: 0x06000A4B RID: 2635
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern void ToString(FName* Self, char* Buffer, int Size, out int OutSize);

		// Token: 0x06000A4C RID: 2636 RVA: 0x00010F44 File Offset: 0x0000F144
		[NullableContext(1)]
		public unsafe override readonly string ToString()
		{
			if (this.IsNone())
			{
				return string.Empty;
			}
			char* ptr = stackalloc char[(UIntPtr)2070];
			fixed (FName* ptr2 = &this)
			{
				int length;
				FName.ToString(ptr2, ptr, 1035, out length);
				return new string(ptr, 0, length);
			}
		}

		// Token: 0x06000A4D RID: 2637 RVA: 0x00010F81 File Offset: 0x0000F181
		public readonly bool IsNone()
		{
			return this.ComparisonIndex == 0U && this.Number == 0U;
		}

		// Token: 0x06000A4E RID: 2638 RVA: 0x00010F96 File Offset: 0x0000F196
		public static bool operator ==(FName A, FName B)
		{
			return A.ComparisonIndex == B.ComparisonIndex && A.Number == B.Number;
		}

		// Token: 0x06000A4F RID: 2639 RVA: 0x00010FB6 File Offset: 0x0000F1B6
		public static bool operator !=(FName A, FName B)
		{
			return !(A == B);
		}

		// Token: 0x06000A50 RID: 2640 RVA: 0x00010FC2 File Offset: 0x0000F1C2
		public readonly bool Equals(FName other)
		{
			return this.ComparisonIndex == other.ComparisonIndex && this.Number == other.Number;
		}

		// Token: 0x06000A51 RID: 2641 RVA: 0x00010FE4 File Offset: 0x0000F1E4
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FName)
			{
				FName other = (FName)obj;
				return this.Equals(other);
			}
			return false;
		}

		// Token: 0x06000A52 RID: 2642 RVA: 0x00011009 File Offset: 0x0000F209
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<uint, uint>(this.ComparisonIndex, this.Number);
		}

		// Token: 0x06000A53 RID: 2643 RVA: 0x0001101C File Offset: 0x0000F21C
		[NullableContext(2)]
		public static implicit operator FName(string Str)
		{
			return new FName(Str);
		}

		// Token: 0x0400017E RID: 382
		public static readonly FName NAME_None;

		// Token: 0x0400017F RID: 383
		public readonly uint ComparisonIndex;

		// Token: 0x04000180 RID: 384
		public readonly uint DisplayIndex;

		// Token: 0x04000181 RID: 385
		public readonly uint Number;

		// Token: 0x04000182 RID: 386
		private const int StringBufferSize = 1035;
	}
}
