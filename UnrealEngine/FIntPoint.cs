using System;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200002A RID: 42
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(8, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 8)]
	[UnrealObjectPath("/Script/CoreUObject.IntPoint")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 8)]
	public struct FIntPoint : IEquatable<FIntPoint>, IEqualityOperators<FIntPoint, FIntPoint, bool>, IUnrealScriptStruct
	{
		// Token: 0x060001BC RID: 444 RVA: 0x000077CC File Offset: 0x000059CC
		public FIntPoint()
		{
			this.X = 0;
			this.Y = 0;
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000077DC File Offset: 0x000059DC
		public FIntPoint(int inX, int inY)
		{
			this.X = inX;
			this.Y = inY;
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000077EC File Offset: 0x000059EC
		public FIntPoint(int inXy)
		{
			this.X = inXy;
			this.Y = inXy;
		}

		// Token: 0x17000004 RID: 4
		public int this[int index]
		{
			readonly get
			{
				int result;
				if (index != 0)
				{
					if (index != 1)
					{
						throw new IndexOutOfRangeException();
					}
					result = this.Y;
				}
				else
				{
					result = this.X;
				}
				return result;
			}
			set
			{
				if (index == 0)
				{
					this.X = value;
					return;
				}
				if (index != 1)
				{
					throw new IndexOutOfRangeException();
				}
				this.Y = value;
			}
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x0000784C File Offset: 0x00005A4C
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2);
			defaultInterpolatedStringHandler.AppendLiteral("X=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.X);
			defaultInterpolatedStringHandler.AppendLiteral(" Y=");
			defaultInterpolatedStringHandler.AppendFormatted<int>(this.Y);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x0000789C File Offset: 0x00005A9C
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FIntPoint)
			{
				FIntPoint b = (FIntPoint)obj;
				return this == b;
			}
			return false;
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000078C6 File Offset: 0x00005AC6
		public readonly bool Equals(FIntPoint other)
		{
			return this == other;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000078D4 File Offset: 0x00005AD4
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<int, int>(this.X, this.Y);
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000078E7 File Offset: 0x00005AE7
		public static bool operator ==(FIntPoint a, FIntPoint b)
		{
			return a.X == b.X && a.Y == b.Y;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00007907 File Offset: 0x00005B07
		public static bool operator !=(FIntPoint a, FIntPoint b)
		{
			return a.X != b.X || a.Y != b.Y;
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x0000792A File Offset: 0x00005B2A
		public static int Num()
		{
			return 2;
		}

		// Token: 0x060001C8 RID: 456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_Add(in FIntPoint a, in FIntPoint b);

		// Token: 0x060001C9 RID: 457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_Sub(in FIntPoint a, in FIntPoint b);

		// Token: 0x060001CA RID: 458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_Mul(in FIntPoint a, in FIntPoint b);

		// Token: 0x060001CB RID: 459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_MulInt(in FIntPoint a, int I);

		// Token: 0x060001CC RID: 460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_Div(in FIntPoint a, in FIntPoint b);

		// Token: 0x060001CD RID: 461
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_DivInt(in FIntPoint a, int I);

		// Token: 0x060001CE RID: 462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_ComponentMin(in FIntPoint a, in FIntPoint b);

		// Token: 0x060001CF RID: 463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_ComponentMax(in FIntPoint a, in FIntPoint b);

		// Token: 0x060001D0 RID: 464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetMax(in FIntPoint a);

		// Token: 0x060001D1 RID: 465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_GetMin(in FIntPoint a);

		// Token: 0x060001D2 RID: 466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_Size(in FIntPoint a);

		// Token: 0x060001D3 RID: 467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int Internal_SizeSquared(in FIntPoint a);

		// Token: 0x060001D4 RID: 468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_DivideAndRoundUp_Int(in FIntPoint a, int I);

		// Token: 0x060001D5 RID: 469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_DivideAndRoundUp(in FIntPoint a, in FIntPoint b);

		// Token: 0x060001D6 RID: 470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_DivideAndRoundDown(in FIntPoint a, int I);

		// Token: 0x060001D7 RID: 471 RVA: 0x00007930 File Offset: 0x00005B30
		public unsafe static FIntPoint operator +(in FIntPoint a, in FIntPoint b)
		{
			fixed (FIntPoint* ptr = &a)
			{
				fixed (FIntPoint* ptr2 = &b)
				{
					return FIntPoint.Internal_Add(a, b);
				}
			}
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x0000794C File Offset: 0x00005B4C
		public unsafe static FIntPoint operator -(in FIntPoint a, in FIntPoint b)
		{
			fixed (FIntPoint* ptr = &a)
			{
				fixed (FIntPoint* ptr2 = &b)
				{
					return FIntPoint.Internal_Sub(a, b);
				}
			}
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x00007968 File Offset: 0x00005B68
		public unsafe static FIntPoint operator *(in FIntPoint a, in FIntPoint b)
		{
			fixed (FIntPoint* ptr = &a)
			{
				fixed (FIntPoint* ptr2 = &b)
				{
					return FIntPoint.Internal_Mul(a, b);
				}
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x00007984 File Offset: 0x00005B84
		public unsafe static FIntPoint operator *(in FIntPoint a, int scale)
		{
			fixed (FIntPoint* ptr = &a)
			{
				return FIntPoint.Internal_MulInt(a, scale);
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000799C File Offset: 0x00005B9C
		public unsafe static FIntPoint operator /(in FIntPoint a, in FIntPoint b)
		{
			fixed (FIntPoint* ptr = &a)
			{
				fixed (FIntPoint* ptr2 = &b)
				{
					return FIntPoint.Internal_Div(a, b);
				}
			}
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000079B8 File Offset: 0x00005BB8
		public unsafe static FIntPoint operator /(in FIntPoint a, int divisor)
		{
			fixed (FIntPoint* ptr = &a)
			{
				return FIntPoint.Internal_DivInt(a, divisor);
			}
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000079D0 File Offset: 0x00005BD0
		public unsafe readonly FIntPoint ComponentMin(in FIntPoint other)
		{
			fixed (FIntPoint* ptr = &this)
			{
				fixed (FIntPoint* ptr2 = &other)
				{
					return FIntPoint.Internal_ComponentMin(this, other);
				}
			}
		}

		// Token: 0x060001DE RID: 478 RVA: 0x000079EC File Offset: 0x00005BEC
		public unsafe readonly FIntPoint ComponentMax(in FIntPoint other)
		{
			fixed (FIntPoint* ptr = &this)
			{
				fixed (FIntPoint* ptr2 = &other)
				{
					return FIntPoint.Internal_ComponentMax(this, other);
				}
			}
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00007A08 File Offset: 0x00005C08
		public unsafe readonly int GetMax()
		{
			fixed (FIntPoint* ptr = &this)
			{
				return FIntPoint.Internal_GetMax(this);
			}
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00007A20 File Offset: 0x00005C20
		public unsafe readonly int GetMin()
		{
			fixed (FIntPoint* ptr = &this)
			{
				return FIntPoint.Internal_GetMin(this);
			}
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x00007A38 File Offset: 0x00005C38
		public unsafe readonly int Size()
		{
			fixed (FIntPoint* ptr = &this)
			{
				return FIntPoint.Internal_Size(this);
			}
		}

		// Token: 0x060001E2 RID: 482 RVA: 0x00007A50 File Offset: 0x00005C50
		public unsafe readonly int SizeSquared()
		{
			fixed (FIntPoint* ptr = &this)
			{
				return FIntPoint.Internal_SizeSquared(this);
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00007A68 File Offset: 0x00005C68
		public unsafe static FIntPoint DivideAndRoundUp(in FIntPoint a, int divisor)
		{
			fixed (FIntPoint* ptr = &a)
			{
				return FIntPoint.Internal_DivideAndRoundUp_Int(a, divisor);
			}
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00007A80 File Offset: 0x00005C80
		public unsafe static FIntPoint DivideAndRoundUp(in FIntPoint a, in FIntPoint divisor)
		{
			fixed (FIntPoint* ptr = &a)
			{
				fixed (FIntPoint* ptr2 = &divisor)
				{
					return FIntPoint.Internal_DivideAndRoundUp(a, divisor);
				}
			}
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00007A9C File Offset: 0x00005C9C
		public unsafe static FIntPoint DivideAndRoundDown(in FIntPoint a, int divisor)
		{
			fixed (FIntPoint* ptr = &a)
			{
				return FIntPoint.Internal_DivideAndRoundDown(a, divisor);
			}
		}

		// Token: 0x060001E6 RID: 486 RVA: 0x00007AB4 File Offset: 0x00005CB4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FIntPoint._ScriptStructPtr != 0) ? FIntPoint._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.IntPoint", ref FIntPoint._ScriptStructPtr);
		}

		// Token: 0x0400009C RID: 156
		public static readonly FIntPoint ZeroValue = new FIntPoint(0, 0);

		// Token: 0x0400009D RID: 157
		public static readonly FIntPoint NoneValue = new FIntPoint(-1, -1);

		// Token: 0x0400009E RID: 158
		[FieldOffset(0)]
		public int X;

		// Token: 0x0400009F RID: 159
		[FieldOffset(4)]
		public int Y;

		// Token: 0x040000A0 RID: 160
		public const string __ObjectPath = "/Script/CoreUObject.IntPoint";

		// Token: 0x040000A1 RID: 161
		private static IntPtr _ScriptStructPtr;
	}
}
