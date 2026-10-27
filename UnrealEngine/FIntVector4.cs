using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200002D RID: 45
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 16)]
	public struct FIntVector4 : IEquatable<FIntVector4>, IEqualityOperators<FIntVector4, FIntVector4, bool>
	{
		// Token: 0x0600021F RID: 543 RVA: 0x00007FB5 File Offset: 0x000061B5
		public FIntVector4()
		{
			this.X = 0;
			this.Y = 0;
			this.Z = 0;
			this.W = 0;
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00007FD3 File Offset: 0x000061D3
		public FIntVector4(int x, int y, int z, int w)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
			this.W = w;
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00007FF2 File Offset: 0x000061F2
		public FIntVector4(int value)
		{
			this.X = value;
			this.Y = value;
			this.Z = value;
			this.W = value;
		}

		// Token: 0x06000222 RID: 546 RVA: 0x00008010 File Offset: 0x00006210
		public FIntVector4(FVector4 value)
		{
			this.X = (int)value.X;
			this.Y = (int)value.Y;
			this.Z = (int)value.Z;
			this.W = (int)value.W;
		}

		// Token: 0x17000007 RID: 7
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

		// Token: 0x06000225 RID: 549 RVA: 0x000080D7 File Offset: 0x000062D7
		public static bool operator ==(FIntVector4 a, FIntVector4 b)
		{
			return a.X == b.X && a.Y == b.Y && a.Z == b.Z && a.W == b.W;
		}

		// Token: 0x06000226 RID: 550 RVA: 0x00008113 File Offset: 0x00006313
		public static bool operator !=(FIntVector4 a, FIntVector4 b)
		{
			return a.X != b.X || a.Y != b.Y || a.Z != b.Z || a.W != b.W;
		}

		// Token: 0x06000227 RID: 551 RVA: 0x00008152 File Offset: 0x00006352
		public readonly bool Equals(FIntVector4 other)
		{
			return this == other;
		}

		// Token: 0x06000228 RID: 552 RVA: 0x00008160 File Offset: 0x00006360
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

		// Token: 0x06000229 RID: 553 RVA: 0x0000818A File Offset: 0x0000638A
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<int, int, int, int>(this.X, this.Y, this.Z, this.W);
		}

		// Token: 0x0600022A RID: 554 RVA: 0x000081AC File Offset: 0x000063AC
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

		// Token: 0x0600022B RID: 555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector4 Internal_Add(in FIntVector4 a, in FIntVector4 b);

		// Token: 0x0600022C RID: 556
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector4 Internal_Sub(in FIntVector4 a, in FIntVector4 b);

		// Token: 0x0600022D RID: 557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector4 Internal_Mul(in FIntVector4 a, int b);

		// Token: 0x0600022E RID: 558
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector4 Internal_Div(in FIntVector4 a, int b);

		// Token: 0x0600022F RID: 559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector4 Internal_LShift(in FIntVector4 a, int b);

		// Token: 0x06000230 RID: 560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector4 Internal_RShift(in FIntVector4 a, int b);

		// Token: 0x06000231 RID: 561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector4 Internal_And(in FIntVector4 a, int b);

		// Token: 0x06000232 RID: 562
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector4 Internal_Or(in FIntVector4 a, int b);

		// Token: 0x06000233 RID: 563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector4 Internal_Xor(in FIntVector4 a, int b);

		// Token: 0x06000234 RID: 564 RVA: 0x0000823C File Offset: 0x0000643C
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

		// Token: 0x06000235 RID: 565 RVA: 0x00008258 File Offset: 0x00006458
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

		// Token: 0x06000236 RID: 566 RVA: 0x00008274 File Offset: 0x00006474
		public unsafe static FIntVector4 operator *(in FIntVector4 a, int b)
		{
			fixed (FIntVector4* ptr = &a)
			{
				return FIntVector4.Internal_Mul(a, b);
			}
		}

		// Token: 0x06000237 RID: 567 RVA: 0x0000828C File Offset: 0x0000648C
		public unsafe static FIntVector4 operator /(in FIntVector4 a, int b)
		{
			fixed (FIntVector4* ptr = &a)
			{
				return FIntVector4.Internal_Div(a, b);
			}
		}

		// Token: 0x06000238 RID: 568 RVA: 0x000082A4 File Offset: 0x000064A4
		public unsafe static FIntVector4 operator <<(in FIntVector4 a, int b)
		{
			fixed (FIntVector4* ptr = &a)
			{
				return FIntVector4.Internal_LShift(a, b);
			}
		}

		// Token: 0x06000239 RID: 569 RVA: 0x000082BC File Offset: 0x000064BC
		public unsafe static FIntVector4 operator >>(in FIntVector4 a, int b)
		{
			fixed (FIntVector4* ptr = &a)
			{
				return FIntVector4.Internal_RShift(a, b);
			}
		}

		// Token: 0x0600023A RID: 570 RVA: 0x000082D4 File Offset: 0x000064D4
		public unsafe static FIntVector4 operator &(in FIntVector4 a, int b)
		{
			fixed (FIntVector4* ptr = &a)
			{
				return FIntVector4.Internal_And(a, b);
			}
		}

		// Token: 0x0600023B RID: 571 RVA: 0x000082EC File Offset: 0x000064EC
		public unsafe static FIntVector4 operator |(in FIntVector4 a, int b)
		{
			fixed (FIntVector4* ptr = &a)
			{
				return FIntVector4.Internal_Or(a, b);
			}
		}

		// Token: 0x0600023C RID: 572 RVA: 0x00008304 File Offset: 0x00006504
		public unsafe static FIntVector4 operator ^(in FIntVector4 a, int b)
		{
			fixed (FIntVector4* ptr = &a)
			{
				return FIntVector4.Internal_Xor(a, b);
			}
		}

		// Token: 0x040000AB RID: 171
		[FieldOffset(0)]
		public int X;

		// Token: 0x040000AC RID: 172
		[FieldOffset(4)]
		public int Y;

		// Token: 0x040000AD RID: 173
		[FieldOffset(8)]
		public int Z;

		// Token: 0x040000AE RID: 174
		[FieldOffset(12)]
		public int W;
	}
}
