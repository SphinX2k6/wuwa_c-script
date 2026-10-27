using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200002B RID: 43
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/CoreUObject.IntVector")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FIntVector : IEquatable<FIntVector>, IEqualityOperators<FIntVector, FIntVector, bool>, IUnrealScriptStruct
	{
		// Token: 0x060001E8 RID: 488 RVA: 0x00007AF2 File Offset: 0x00005CF2
		public FIntVector()
		{
			this.X = 0;
			this.Y = 0;
			this.Z = 0;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00007B09 File Offset: 0x00005D09
		public FIntVector(int x, int y, int z)
		{
			this.X = x;
			this.Y = y;
			this.Z = z;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00007B20 File Offset: 0x00005D20
		public FIntVector(int value)
		{
			this.X = value;
			this.Y = value;
			this.Z = value;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x00007B37 File Offset: 0x00005D37
		public FIntVector(in FVector v)
		{
			this.X = (int)v.X;
			this.Y = (int)v.Y;
			this.Z = (int)v.Z;
		}

		// Token: 0x17000005 RID: 5
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
				default:
					throw new IndexOutOfRangeException();
				}
			}
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00007BD6 File Offset: 0x00005DD6
		public static bool operator ==(FIntVector a, FIntVector b)
		{
			return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00007C04 File Offset: 0x00005E04
		public static bool operator !=(FIntVector a, FIntVector b)
		{
			return a.X != b.X || a.Y != b.Y || a.Z != b.Z;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00007C35 File Offset: 0x00005E35
		public readonly bool Equals(FIntVector other)
		{
			return this == other;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x00007C44 File Offset: 0x00005E44
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FIntVector)
			{
				FIntVector b = (FIntVector)obj;
				return this == b;
			}
			return false;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x00007C6E File Offset: 0x00005E6E
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<int, int, int>(this.X, this.Y, this.Z);
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00007C88 File Offset: 0x00005E88
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 3);
			defaultInterpolatedStringHandler.AppendLiteral("X=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.X);
			defaultInterpolatedStringHandler.AppendLiteral(" Y=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Y);
			defaultInterpolatedStringHandler.AppendLiteral(" Z=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Z);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00007CF0 File Offset: 0x00005EF0
		public static int Num()
		{
			return 3;
		}

		// Token: 0x060001F5 RID: 501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector Internal_Add(in FIntVector a, in FIntVector b);

		// Token: 0x060001F6 RID: 502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector Internal_Sub(in FIntVector a, in FIntVector b);

		// Token: 0x060001F7 RID: 503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector Internal_Mul(in FIntVector a, int b);

		// Token: 0x060001F8 RID: 504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector Internal_Div(in FIntVector a, int b);

		// Token: 0x060001F9 RID: 505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector Internal_LShift(in FIntVector a, int b);

		// Token: 0x060001FA RID: 506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector Internal_RShift(in FIntVector a, int b);

		// Token: 0x060001FB RID: 507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector Internal_And(in FIntVector a, int b);

		// Token: 0x060001FC RID: 508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector Internal_Or(in FIntVector a, int b);

		// Token: 0x060001FD RID: 509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector Internal_Xor(in FIntVector a, int b);

		// Token: 0x060001FE RID: 510
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsZero(in FIntVector a);

		// Token: 0x060001FF RID: 511
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetMax(in FIntVector a);

		// Token: 0x06000200 RID: 512
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetMin(in FIntVector a);

		// Token: 0x06000201 RID: 513
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_Size(in FIntVector a);

		// Token: 0x06000202 RID: 514
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector Internal_DivideAndRoundUp_Int(in FIntVector a, int b);

		// Token: 0x06000203 RID: 515
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntVector Internal_DivideAndRoundUp(in FIntVector a, in FIntVector b);

		// Token: 0x06000204 RID: 516 RVA: 0x00007CF4 File Offset: 0x00005EF4
		public unsafe static FIntVector operator +(in FIntVector a, in FIntVector b)
		{
			fixed (FIntVector* ptr = &a)
			{
				fixed (FIntVector* ptr2 = &b)
				{
					return FIntVector.Internal_Add(a, b);
				}
			}
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00007D10 File Offset: 0x00005F10
		public unsafe static FIntVector operator -(in FIntVector a, in FIntVector b)
		{
			fixed (FIntVector* ptr = &a)
			{
				fixed (FIntVector* ptr2 = &b)
				{
					return FIntVector.Internal_Sub(a, b);
				}
			}
		}

		// Token: 0x06000206 RID: 518 RVA: 0x00007D2C File Offset: 0x00005F2C
		public unsafe static FIntVector operator *(in FIntVector a, int b)
		{
			fixed (FIntVector* ptr = &a)
			{
				return FIntVector.Internal_Mul(a, b);
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x00007D44 File Offset: 0x00005F44
		public unsafe static FIntVector operator /(in FIntVector a, int b)
		{
			fixed (FIntVector* ptr = &a)
			{
				return FIntVector.Internal_Div(a, b);
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x00007D5C File Offset: 0x00005F5C
		public unsafe static FIntVector operator <<(in FIntVector a, int b)
		{
			fixed (FIntVector* ptr = &a)
			{
				return FIntVector.Internal_LShift(a, b);
			}
		}

		// Token: 0x06000209 RID: 521 RVA: 0x00007D74 File Offset: 0x00005F74
		public unsafe static FIntVector operator >>(in FIntVector a, int b)
		{
			fixed (FIntVector* ptr = &a)
			{
				return FIntVector.Internal_RShift(a, b);
			}
		}

		// Token: 0x0600020A RID: 522 RVA: 0x00007D8C File Offset: 0x00005F8C
		public unsafe static FIntVector operator &(in FIntVector a, int b)
		{
			fixed (FIntVector* ptr = &a)
			{
				return FIntVector.Internal_And(a, b);
			}
		}

		// Token: 0x0600020B RID: 523 RVA: 0x00007DA4 File Offset: 0x00005FA4
		public unsafe static FIntVector operator |(in FIntVector a, int b)
		{
			fixed (FIntVector* ptr = &a)
			{
				return FIntVector.Internal_Or(a, b);
			}
		}

		// Token: 0x0600020C RID: 524 RVA: 0x00007DBC File Offset: 0x00005FBC
		public unsafe static FIntVector operator ^(in FIntVector a, int b)
		{
			fixed (FIntVector* ptr = &a)
			{
				return FIntVector.Internal_Xor(a, b);
			}
		}

		// Token: 0x0600020D RID: 525 RVA: 0x00007DD4 File Offset: 0x00005FD4
		public unsafe readonly bool IsZero()
		{
			fixed (FIntVector* ptr = &this)
			{
				return FIntVector.Internal_IsZero(this);
			}
		}

		// Token: 0x0600020E RID: 526 RVA: 0x00007DEC File Offset: 0x00005FEC
		public unsafe readonly int GetMax()
		{
			fixed (FIntVector* ptr = &this)
			{
				return FIntVector.Internal_GetMax(this);
			}
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00007E04 File Offset: 0x00006004
		public unsafe readonly int GetMin()
		{
			fixed (FIntVector* ptr = &this)
			{
				return FIntVector.Internal_GetMin(this);
			}
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00007E1C File Offset: 0x0000601C
		public unsafe readonly int Size()
		{
			fixed (FIntVector* ptr = &this)
			{
				return FIntVector.Internal_Size(this);
			}
		}

		// Token: 0x06000211 RID: 529 RVA: 0x00007E34 File Offset: 0x00006034
		public unsafe static FIntVector DivideAndRoundUp(in FIntVector a, int b)
		{
			fixed (FIntVector* ptr = &a)
			{
				return FIntVector.Internal_DivideAndRoundUp_Int(a, b);
			}
		}

		// Token: 0x06000212 RID: 530 RVA: 0x00007E4C File Offset: 0x0000604C
		public unsafe static FIntVector DivideAndRoundUp(in FIntVector a, in FIntVector b)
		{
			fixed (FIntVector* ptr = &a)
			{
				fixed (FIntVector* ptr2 = &b)
				{
					return FIntVector.Internal_DivideAndRoundUp(a, b);
				}
			}
		}

		// Token: 0x06000213 RID: 531 RVA: 0x00007E68 File Offset: 0x00006068
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIntVector._ScriptStructPtr != 0) ? FIntVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.IntVector", ref FIntVector._ScriptStructPtr);
		}

		// Token: 0x040000A2 RID: 162
		public static readonly FIntVector ZeroValue = new FIntVector(0, 0, 0);

		// Token: 0x040000A3 RID: 163
		public static readonly FIntVector NoneValue = new FIntVector(-1, -1, -1);

		// Token: 0x040000A4 RID: 164
		[FieldOffset(0)]
		public int X;

		// Token: 0x040000A5 RID: 165
		[FieldOffset(4)]
		public int Y;

		// Token: 0x040000A6 RID: 166
		[FieldOffset(8)]
		public int Z;

		// Token: 0x040000A7 RID: 167
		public const string __ObjectPath = "/Script/CoreUObject.IntVector";

		// Token: 0x040000A8 RID: 168
		private static IntPtr _ScriptStructPtr;
	}
}
