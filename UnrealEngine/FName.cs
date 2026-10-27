using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200007F RID: 127
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.Name)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.Name, PropertiesSize = 12)]
	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 12)]
	public struct FName : IEqualityOperators<FName, FName, bool>, IEquatable<FName>
	{
		// Token: 0x06000EAF RID: 3759 RVA: 0x000160A5 File Offset: 0x000142A5
		public FName()
		{
			this.ComparisonIndex = 0U;
			this.DisplayIndex = 0U;
			this.Number = 0U;
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x000160BC File Offset: 0x000142BC
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

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00016110 File Offset: 0x00014310
		public FName(uint ComparisonIndex, uint DisplayIndex, uint Number)
		{
			this.ComparisonIndex = ComparisonIndex;
			this.DisplayIndex = DisplayIndex;
			this.Number = Number;
		}

		// Token: 0x06000EB2 RID: 3762 RVA: 0x00016128 File Offset: 0x00014328
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

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00016178 File Offset: 0x00014378
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

		// Token: 0x06000EB4 RID: 3764
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern void FromString(FName* Name, char* Str, int Length);

		// Token: 0x06000EB5 RID: 3765
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern void FromAnsiString(FName* Name, byte* Str, int Length);

		// Token: 0x06000EB6 RID: 3766
		[MethodImpl(MethodImplOptions.InternalCall)]
		internal unsafe static extern void ToString(FName* Self, char* Buffer, int Size, out int OutSize);

		// Token: 0x06000EB7 RID: 3767 RVA: 0x000161C8 File Offset: 0x000143C8
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

		// Token: 0x06000EB8 RID: 3768 RVA: 0x00016205 File Offset: 0x00014405
		public readonly bool IsNone()
		{
			return this.ComparisonIndex == 0U && this.Number == 0U;
		}

		// Token: 0x06000EB9 RID: 3769 RVA: 0x0001621A File Offset: 0x0001441A
		public static bool operator ==(FName A, FName B)
		{
			return A.ComparisonIndex == B.ComparisonIndex && A.Number == B.Number;
		}

		// Token: 0x06000EBA RID: 3770 RVA: 0x0001623A File Offset: 0x0001443A
		public static bool operator !=(FName A, FName B)
		{
			return !(A == B);
		}

		// Token: 0x06000EBB RID: 3771 RVA: 0x00016246 File Offset: 0x00014446
		public readonly bool Equals(FName other)
		{
			return this.ComparisonIndex == other.ComparisonIndex && this.Number == other.Number;
		}

		// Token: 0x06000EBC RID: 3772 RVA: 0x00016268 File Offset: 0x00014468
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

		// Token: 0x06000EBD RID: 3773 RVA: 0x0001628D File Offset: 0x0001448D
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<uint, uint>(this.ComparisonIndex, this.Number);
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x000162A0 File Offset: 0x000144A0
		[NullableContext(2)]
		public static implicit operator FName(string Str)
		{
			return new FName(Str);
		}

		// Token: 0x040001C5 RID: 453
		public static readonly FName NAME_None;

		// Token: 0x040001C6 RID: 454
		public readonly uint ComparisonIndex;

		// Token: 0x040001C7 RID: 455
		public readonly uint DisplayIndex;

		// Token: 0x040001C8 RID: 456
		public readonly uint Number;

		// Token: 0x040001C9 RID: 457
		private const int StringBufferSize = 1035;
	}
}
