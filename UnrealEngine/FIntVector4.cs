using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02000012 RID: 18
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FIntVector4 : IEquatable<FIntVector4>, IEqualityOperators<FIntVector4, FIntVector4, bool>
	{
		// Token: 0x060001A4 RID: 420 RVA: 0x00004821 File Offset: 0x00002A21
		public FIntVector4()
		{
			this.X = 0;
			this.Y = 0;
			this.Z = 0;
			this.W = 0;
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x0000483F File Offset: 0x00002A3F
		public FIntVector4(int x, int y, int z, int w)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x0000485E File Offset: 0x00002A5E
		public FIntVector4(int value)
		{
			this.X = value;
			this.Y = value;
			this.Z = value;
			this.W = value;
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x0000487C File Offset: 0x00002A7C
		public FIntVector4(FVector4 value)
		{
			this.X = (int)value.X;
			this.Y = (int)value.Y;
			this.Z = (int)value.Z;
			this.W = (int)value.W;
		}

		// Token: 0x17000006 RID: 6
		public int this[int index]
		{
			readonly get
			{
				int result;
				switch (index)
				{
				case 0:
					result = this.X;
					break;
				case 1:
					result = this.Y;
					break;
				case 2:
					result = this.Z;
					break;
				case 3:
					result = this.W;
					break;
				default:
					throw new IndexOutOfRangeException();
				}
				return result;
			}
			set
			{
				switch (index)
				{
				case 0:
					this.X = value;
					return;
				case 1:
					this.Y = value;
					return;
				case 2:
					this.Z = value;
					return;
				case 3:
					this.W = value;
					return;
				default:
					throw new IndexOutOfRangeException();
				}
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00004943 File Offset: 0x00002B43
		public static bool operator ==(FIntVector4 a, FIntVector4 b)
		{
			return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
		}

		// Token: 0x060001AB RID: 427 RVA: 0x0000497F File Offset: 0x00002B7F
		public static bool operator !=(FIntVector4 a, FIntVector4 b)
		{
			return a.X != b.X || a.Y != b.Y || a.Z != b.Z || a.W != b.W;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000049BE File Offset: 0x00002BBE
		public readonly bool Equals(FIntVector4 other)
		{
			return this == other;
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000049CC File Offset: 0x00002BCC
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FIntVector4)
			{
				FIntVector4 b = (FIntVector4)obj;
				return this == b;
			}
			return false;
		}

		// Token: 0x060001AE RID: 430 RVA: 0x000049F6 File Offset: 0x00002BF6
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<int, int, int, int>(this.X, this.Y, this.Z, this.W);
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00004A18 File Offset: 0x00002C18
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 4);
			defaultInterpolatedStringHandler.AppendLiteral("(");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.X);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Y);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Z);
			defaultInterpolatedStringHandler.AppendLiteral(", ");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.W);
			defaultInterpolatedStringHandler.AppendLiteral(")");
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060001B0 RID: 432
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector4 Internal_Add(in FIntVector4 a, in FIntVector4 b);

		// Token: 0x060001B1 RID: 433
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector4 Internal_Sub(in FIntVector4 a, in FIntVector4 b);

		// Token: 0x060001B2 RID: 434
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector4 Internal_Mul(in FIntVector4 a, int b);

		// Token: 0x060001B3 RID: 435
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector4 Internal_Div(in FIntVector4 a, int b);

		// Token: 0x060001B4 RID: 436
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector4 Internal_LShift(in FIntVector4 a, int b);

		// Token: 0x060001B5 RID: 437
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector4 Internal_RShift(in FIntVector4 a, int b);

		// Token: 0x060001B6 RID: 438
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector4 Internal_And(in FIntVector4 a, int b);

		// Token: 0x060001B7 RID: 439
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector4 Internal_Or(in FIntVector4 a, int b);

		// Token: 0x060001B8 RID: 440
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector4 Internal_Xor(in FIntVector4 a, int b);

		// Token: 0x060001B9 RID: 441 RVA: 0x00004AA8 File Offset: 0x00002CA8
		public unsafe static FIntVector4 operator +(in FIntVector4 a, in FIntVector4 b)
		{
			fixed (FIntVector4* ptr = &a)
			{
				fixed (FIntVector4* ptr2 = &b)
				{
					return FIntVector4.Internal_Add(a, b);
				}
			}
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00004AC4 File Offset: 0x00002CC4
		public unsafe static FIntVector4 operator -(in FIntVector4 a, in FIntVector4 b)
		{
			fixed (FIntVector4* ptr = &a)
			{
				fixed (FIntVector4* ptr2 = &b)
				{
					return FIntVector4.Internal_Sub(a, b);
				}
			}
		}

		// Token: 0x060001BB RID: 443 RVA: 0x00004AE0 File Offset: 0x00002CE0
		public unsafe static FIntVector4 operator *(in FIntVector4 a, int b)
		{
			fixed (FIntVector4* ptr = &a)
			{
				return FIntVector4.Internal_Mul(a, b);
			}
		}

		// Token: 0x060001BC RID: 444 RVA: 0x00004AF8 File Offset: 0x00002CF8
		public unsafe static FIntVector4 operator /(in FIntVector4 a, int b)
		{
			fixed (FIntVector4* ptr = &a)
			{
				return FIntVector4.Internal_Div(a, b);
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00004B10 File Offset: 0x00002D10
		public unsafe static FIntVector4 operator <<(in FIntVector4 a, int b)
		{
			fixed (FIntVector4* ptr = &a)
			{
				return FIntVector4.Internal_LShift(a, b);
			}
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00004B28 File Offset: 0x00002D28
		public unsafe static FIntVector4 operator >>(in FIntVector4 a, int b)
		{
			fixed (FIntVector4* ptr = &a)
			{
				return FIntVector4.Internal_RShift(a, b);
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x00004B40 File Offset: 0x00002D40
		public unsafe static FIntVector4 operator &(in FIntVector4 a, int b)
		{
			fixed (FIntVector4* ptr = &a)
			{
				return FIntVector4.Internal_And(a, b);
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00004B58 File Offset: 0x00002D58
		public unsafe static FIntVector4 operator |(in FIntVector4 a, int b)
		{
			fixed (FIntVector4* ptr = &a)
			{
				return FIntVector4.Internal_Or(a, b);
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00004B70 File Offset: 0x00002D70
		public unsafe static FIntVector4 operator ^(in FIntVector4 a, int b)
		{
			fixed (FIntVector4* ptr = &a)
			{
				return FIntVector4.Internal_Xor(a, b);
			}
		}

		// Token: 0x04000064 RID: 100
		[FieldOffset(0)]
		public int X;

		// Token: 0x04000065 RID: 101
		[FieldOffset(4)]
		public int Y;

		// Token: 0x04000066 RID: 102
		[FieldOffset(8)]
		public int Z;

		// Token: 0x04000067 RID: 103
		[FieldOffset(12)]
		public int W;
	}
}
