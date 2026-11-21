using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000027 RID: 39
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/CoreUObject.Vector2DDouble")]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 16)]
	public struct FVector2DDouble : IEquatable<FVector2DDouble>, IEqualityOperators<FVector2DDouble, FVector2DDouble, bool>, IUnrealScriptStruct
	{
		// Token: 0x06000690 RID: 1680 RVA: 0x0000B286 File Offset: 0x00009486
		[Conditional("ENABLE_NAN_DIAGNOSTIC")]
		public void DiagnosticCheckNaN()
		{
			if (!SharpherealAssert.Ensure(!this.ContainsNaN(), "FVector2DDouble contains NaN: {0}", new object[]
			{
				this
			}))
			{
				this = FVector2DDouble.ZeroVector;
			}
		}

		// Token: 0x06000691 RID: 1681 RVA: 0x0000B2BC File Offset: 0x000094BC
		public FVector2DDouble()
		{
			this.X = 0.0;
			this.Y = 0.0;
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0000B2DC File Offset: 0x000094DC
		public FVector2DDouble(double inX, double inY)
		{
			this.X = inX;
			this.Y = inY;
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0000B2EC File Offset: 0x000094EC
		public FVector2DDouble(double inF)
		{
			this = new FVector2DDouble(inF, inF);
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0000B2F6 File Offset: 0x000094F6
		public FVector2DDouble(in FIntPoint inPos)
		{
			this = new FVector2DDouble((double)inPos.X, (double)inPos.Y);
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0000B30C File Offset: 0x0000950C
		public static FVector2DDouble operator *(double scale, in FVector2DDouble v)
		{
			return v * scale;
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0000B315 File Offset: 0x00009515
		public static FVector2DDouble operator -(in FVector2DDouble v)
		{
			return new FVector2DDouble(-v.X, -v.Y);
		}

		// Token: 0x06000697 RID: 1687 RVA: 0x0000B32A File Offset: 0x0000952A
		public static bool operator <(in FVector2DDouble a, in FVector2DDouble b)
		{
			return a.X < b.X && a.Y < b.Y;
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0000B34A File Offset: 0x0000954A
		public static bool operator >(in FVector2DDouble a, in FVector2DDouble b)
		{
			return a.X > b.X && a.Y > b.Y;
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0000B36A File Offset: 0x0000956A
		public static bool operator <=(in FVector2DDouble a, in FVector2DDouble b)
		{
			return a.X <= b.X && a.Y <= b.Y;
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0000B38D File Offset: 0x0000958D
		public static bool operator >=(in FVector2DDouble a, in FVector2DDouble b)
		{
			return a.X >= b.X && a.Y >= b.Y;
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0000B3B0 File Offset: 0x000095B0
		public readonly bool Equals(FVector2DDouble other)
		{
			return this == other;
		}

		// Token: 0x0600069C RID: 1692 RVA: 0x0000B3C0 File Offset: 0x000095C0
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FVector2DDouble)
			{
				FVector2DDouble b = (FVector2DDouble)obj;
				return this == b;
			}
			return false;
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0000B3EA File Offset: 0x000095EA
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<double, double>(this.X, this.Y);
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0000B400 File Offset: 0x00009600
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(5, 2);
			defaultInterpolatedStringHandler.AppendLiteral("X=");
			defaultInterpolatedStringHandler.AppendFormatted<double>(this.X);
			defaultInterpolatedStringHandler.AppendLiteral(" Y=");
			defaultInterpolatedStringHandler.AppendFormatted<double>(this.Y);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x1700001D RID: 29
		public double this[int index]
		{
			readonly get
			{
				double result;
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

		// Token: 0x060006A1 RID: 1697 RVA: 0x0000B49F File Offset: 0x0000969F
		public readonly double Component(int index)
		{
			return this[index];
		}

		// Token: 0x060006A2 RID: 1698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Eq(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x060006A3 RID: 1699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_NotEq(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x060006A4 RID: 1700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_Add(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x060006A5 RID: 1701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_AddDouble(in FVector2DDouble a, double bias);

		// Token: 0x060006A6 RID: 1702
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_Sub(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x060006A7 RID: 1703
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_SubDouble(in FVector2DDouble a, double bias);

		// Token: 0x060006A8 RID: 1704
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_Mul(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x060006A9 RID: 1705
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_MulDouble(in FVector2DDouble a, double scale);

		// Token: 0x060006AA RID: 1706
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_Div(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x060006AB RID: 1707
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_DivDouble(in FVector2DDouble a, double scale);

		// Token: 0x060006AC RID: 1708
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_Or(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x060006AD RID: 1709
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_Xor(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x060006AE RID: 1710
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_Min(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x060006AF RID: 1711
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_Max(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x060006B0 RID: 1712
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_DotProduct(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x060006B1 RID: 1713
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_CrossProduct(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x060006B2 RID: 1714
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_Distance(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x060006B3 RID: 1715
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_DistSquared(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x060006B4 RID: 1716
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FVector2DDouble a, in FVector2DDouble b, double tolerance = 9.999999747378752E-05);

		// Token: 0x060006B5 RID: 1717
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Set(ref FVector2DDouble a, double x, double y);

		// Token: 0x060006B6 RID: 1718
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_GetMax(in FVector2DDouble a);

		// Token: 0x060006B7 RID: 1719
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_GetAbsMax(in FVector2DDouble a);

		// Token: 0x060006B8 RID: 1720
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_GetMin(in FVector2DDouble a);

		// Token: 0x060006B9 RID: 1721
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_GetAbs(in FVector2DDouble a);

		// Token: 0x060006BA RID: 1722
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_Size(in FVector2DDouble a);

		// Token: 0x060006BB RID: 1723
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_SizeSquared(in FVector2DDouble a);

		// Token: 0x060006BC RID: 1724
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_GetRotated(in FVector2DDouble a, double angleDeg);

		// Token: 0x060006BD RID: 1725
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsNearlyZero(in FVector2DDouble a, double tolerance = 9.999999747378752E-05);

		// Token: 0x060006BE RID: 1726
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsZero(in FVector2DDouble a);

		// Token: 0x060006BF RID: 1727
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Normalize(ref FVector2DDouble a, double tolerance = 9.99999993922529E-09);

		// Token: 0x060006C0 RID: 1728
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_GetSafeNormal(in FVector2DDouble a, double tolerance = 9.99999993922529E-09);

		// Token: 0x060006C1 RID: 1729
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ToDirectionAndLength(in FVector2DDouble a, out FVector2DDouble outDirection, out double outLength);

		// Token: 0x060006C2 RID: 1730
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_IntPoint(in FVector2DDouble a);

		// Token: 0x060006C3 RID: 1731
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_RoundToVector(in FVector2DDouble a);

		// Token: 0x060006C4 RID: 1732
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_ClampAxes(in FVector2DDouble a, double minAxisVal, double maxAxisVal);

		// Token: 0x060006C5 RID: 1733
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_GetSignVector(in FVector2DDouble a);

		// Token: 0x060006C6 RID: 1734
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FVector2DDouble a);

		// Token: 0x060006C7 RID: 1735
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_SphericalToUnitCartesian(in FVector2DDouble a);

		// Token: 0x060006C8 RID: 1736
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_InitFromString(ref FVector2DDouble a, in FCSharpStringView str);

		// Token: 0x060006C9 RID: 1737 RVA: 0x0000B4A8 File Offset: 0x000096A8
		public static bool operator ==(FVector2DDouble a, FVector2DDouble b)
		{
			return FVector2DDouble.Internal_Eq(a, b);
		}

		// Token: 0x060006CA RID: 1738 RVA: 0x0000B4B3 File Offset: 0x000096B3
		public static bool operator !=(FVector2DDouble a, FVector2DDouble b)
		{
			return FVector2DDouble.Internal_NotEq(a, b);
		}

		// Token: 0x060006CB RID: 1739 RVA: 0x0000B4C0 File Offset: 0x000096C0
		public unsafe static FVector2DDouble operator +(in FVector2DDouble a, in FVector2DDouble b)
		{
			fixed (FVector2DDouble* ptr = &a)
			{
				fixed (FVector2DDouble* ptr2 = &b)
				{
					return FVector2DDouble.Internal_Add(a, b);
				}
			}
		}

		// Token: 0x060006CC RID: 1740 RVA: 0x0000B4DC File Offset: 0x000096DC
		public unsafe static FVector2DDouble operator +(in FVector2DDouble a, double bias)
		{
			fixed (FVector2DDouble* ptr = &a)
			{
				return FVector2DDouble.Internal_AddDouble(a, bias);
			}
		}

		// Token: 0x060006CD RID: 1741 RVA: 0x0000B4F4 File Offset: 0x000096F4
		public unsafe static FVector2DDouble operator -(in FVector2DDouble a, in FVector2DDouble b)
		{
			fixed (FVector2DDouble* ptr = &a)
			{
				fixed (FVector2DDouble* ptr2 = &b)
				{
					return FVector2DDouble.Internal_Sub(a, b);
				}
			}
		}

		// Token: 0x060006CE RID: 1742 RVA: 0x0000B510 File Offset: 0x00009710
		public unsafe static FVector2DDouble operator -(in FVector2DDouble a, double bias)
		{
			fixed (FVector2DDouble* ptr = &a)
			{
				return FVector2DDouble.Internal_SubDouble(a, bias);
			}
		}

		// Token: 0x060006CF RID: 1743 RVA: 0x0000B528 File Offset: 0x00009728
		public unsafe static FVector2DDouble operator *(in FVector2DDouble a, in FVector2DDouble b)
		{
			fixed (FVector2DDouble* ptr = &a)
			{
				fixed (FVector2DDouble* ptr2 = &b)
				{
					return FVector2DDouble.Internal_Mul(a, b);
				}
			}
		}

		// Token: 0x060006D0 RID: 1744 RVA: 0x0000B544 File Offset: 0x00009744
		public unsafe static FVector2DDouble operator *(in FVector2DDouble a, double scale)
		{
			fixed (FVector2DDouble* ptr = &a)
			{
				return FVector2DDouble.Internal_MulDouble(a, scale);
			}
		}

		// Token: 0x060006D1 RID: 1745 RVA: 0x0000B55C File Offset: 0x0000975C
		public unsafe static FVector2DDouble operator /(in FVector2DDouble a, in FVector2DDouble b)
		{
			fixed (FVector2DDouble* ptr = &a)
			{
				fixed (FVector2DDouble* ptr2 = &b)
				{
					return FVector2DDouble.Internal_Div(a, b);
				}
			}
		}

		// Token: 0x060006D2 RID: 1746 RVA: 0x0000B578 File Offset: 0x00009778
		public unsafe static FVector2DDouble operator /(in FVector2DDouble a, double scale)
		{
			fixed (FVector2DDouble* ptr = &a)
			{
				return FVector2DDouble.Internal_DivDouble(a, scale);
			}
		}

		// Token: 0x060006D3 RID: 1747 RVA: 0x0000B590 File Offset: 0x00009790
		public unsafe static double operator |(in FVector2DDouble a, in FVector2DDouble b)
		{
			fixed (FVector2DDouble* ptr = &a)
			{
				fixed (FVector2DDouble* ptr2 = &b)
				{
					return FVector2DDouble.Internal_Or(a, b);
				}
			}
		}

		// Token: 0x060006D4 RID: 1748 RVA: 0x0000B5AC File Offset: 0x000097AC
		public unsafe static double operator ^(in FVector2DDouble a, in FVector2DDouble b)
		{
			fixed (FVector2DDouble* ptr = &a)
			{
				fixed (FVector2DDouble* ptr2 = &b)
				{
					return FVector2DDouble.Internal_Xor(a, b);
				}
			}
		}

		// Token: 0x060006D5 RID: 1749 RVA: 0x0000B5C8 File Offset: 0x000097C8
		public unsafe static FVector2DDouble Min(in FVector2DDouble a, in FVector2DDouble b)
		{
			fixed (FVector2DDouble* ptr = &a)
			{
				fixed (FVector2DDouble* ptr2 = &b)
				{
					return FVector2DDouble.Internal_Min(a, b);
				}
			}
		}

		// Token: 0x060006D6 RID: 1750 RVA: 0x0000B5E4 File Offset: 0x000097E4
		public unsafe static FVector2DDouble Max(in FVector2DDouble a, in FVector2DDouble b)
		{
			fixed (FVector2DDouble* ptr = &a)
			{
				fixed (FVector2DDouble* ptr2 = &b)
				{
					return FVector2DDouble.Internal_Max(a, b);
				}
			}
		}

		// Token: 0x060006D7 RID: 1751 RVA: 0x0000B600 File Offset: 0x00009800
		public unsafe static double DotProduct(in FVector2DDouble a, in FVector2DDouble b)
		{
			fixed (FVector2DDouble* ptr = &a)
			{
				fixed (FVector2DDouble* ptr2 = &b)
				{
					return FVector2DDouble.Internal_DotProduct(a, b);
				}
			}
		}

		// Token: 0x060006D8 RID: 1752 RVA: 0x0000B61C File Offset: 0x0000981C
		public unsafe static double CrossProduct(in FVector2DDouble a, in FVector2DDouble b)
		{
			fixed (FVector2DDouble* ptr = &a)
			{
				fixed (FVector2DDouble* ptr2 = &b)
				{
					return FVector2DDouble.Internal_CrossProduct(a, b);
				}
			}
		}

		// Token: 0x060006D9 RID: 1753 RVA: 0x0000B638 File Offset: 0x00009838
		public unsafe static double Distance(in FVector2DDouble a, in FVector2DDouble b)
		{
			fixed (FVector2DDouble* ptr = &a)
			{
				fixed (FVector2DDouble* ptr2 = &b)
				{
					return FVector2DDouble.Internal_Distance(a, b);
				}
			}
		}

		// Token: 0x060006DA RID: 1754 RVA: 0x0000B654 File Offset: 0x00009854
		public unsafe static double DistSquared(in FVector2DDouble a, in FVector2DDouble b)
		{
			fixed (FVector2DDouble* ptr = &a)
			{
				fixed (FVector2DDouble* ptr2 = &b)
				{
					return FVector2DDouble.Internal_DistSquared(a, b);
				}
			}
		}

		// Token: 0x060006DB RID: 1755 RVA: 0x0000B670 File Offset: 0x00009870
		public unsafe readonly bool Equals(in FVector2DDouble b, double tolerance = 9.999999747378752E-05)
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				fixed (FVector2DDouble* ptr2 = &b)
				{
					return FVector2DDouble.Internal_Equals(this, b, tolerance);
				}
			}
		}

		// Token: 0x060006DC RID: 1756 RVA: 0x0000B690 File Offset: 0x00009890
		public unsafe void Set(double x, double y)
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				FVector2DDouble.Internal_Set(ref this, x, y);
			}
		}

		// Token: 0x060006DD RID: 1757 RVA: 0x0000B6AC File Offset: 0x000098AC
		public unsafe readonly double GetMax()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_GetMax(this);
			}
		}

		// Token: 0x060006DE RID: 1758 RVA: 0x0000B6C4 File Offset: 0x000098C4
		public unsafe readonly double GetAbsMax()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_GetAbsMax(this);
			}
		}

		// Token: 0x060006DF RID: 1759 RVA: 0x0000B6DC File Offset: 0x000098DC
		public unsafe readonly double GetMin()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_GetMin(this);
			}
		}

		// Token: 0x060006E0 RID: 1760 RVA: 0x0000B6F4 File Offset: 0x000098F4
		public unsafe readonly FVector2DDouble GetAbs()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_GetAbs(this);
			}
		}

		// Token: 0x060006E1 RID: 1761 RVA: 0x0000B70C File Offset: 0x0000990C
		public unsafe readonly double Size()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_Size(this);
			}
		}

		// Token: 0x060006E2 RID: 1762 RVA: 0x0000B724 File Offset: 0x00009924
		public unsafe readonly double SizeSquared()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_SizeSquared(this);
			}
		}

		// Token: 0x060006E3 RID: 1763 RVA: 0x0000B73C File Offset: 0x0000993C
		public unsafe readonly FVector2DDouble GetRotated(double angleDeg)
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_GetRotated(this, angleDeg);
			}
		}

		// Token: 0x060006E4 RID: 1764 RVA: 0x0000B754 File Offset: 0x00009954
		public unsafe readonly bool IsNearlyZero(double tolerance = 9.999999747378752E-05)
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_IsNearlyZero(this, tolerance);
			}
		}

		// Token: 0x060006E5 RID: 1765 RVA: 0x0000B76C File Offset: 0x0000996C
		public unsafe readonly bool IsZero()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_IsZero(this);
			}
		}

		// Token: 0x060006E6 RID: 1766 RVA: 0x0000B784 File Offset: 0x00009984
		public unsafe void Normalize(double tolerance = 9.99999993922529E-09)
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				FVector2DDouble.Internal_Normalize(ref this, tolerance);
			}
		}

		// Token: 0x060006E7 RID: 1767 RVA: 0x0000B7A0 File Offset: 0x000099A0
		public unsafe readonly FVector2DDouble GetSafeNormal(double tolerance = 9.99999993922529E-09)
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_GetSafeNormal(this, tolerance);
			}
		}

		// Token: 0x060006E8 RID: 1768 RVA: 0x0000B7B8 File Offset: 0x000099B8
		public unsafe readonly void ToDirectionAndLength(out FVector2DDouble outDirection, out double outLength)
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				fixed (FVector2DDouble* ptr2 = &outDirection)
				{
					fixed (double* ptr3 = &outLength)
					{
						FVector2DDouble.Internal_ToDirectionAndLength(this, out outDirection, out outLength);
					}
				}
			}
		}

		// Token: 0x060006E9 RID: 1769 RVA: 0x0000B7E4 File Offset: 0x000099E4
		public unsafe readonly FIntPoint IntPoint()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_IntPoint(this);
			}
		}

		// Token: 0x060006EA RID: 1770 RVA: 0x0000B7FC File Offset: 0x000099FC
		public unsafe readonly FVector2DDouble RoundToVector()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_RoundToVector(this);
			}
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0000B814 File Offset: 0x00009A14
		public unsafe readonly FVector2DDouble ClampAxes(double minAxisVal, double maxAxisVal)
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_ClampAxes(this, minAxisVal, maxAxisVal);
			}
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x0000B830 File Offset: 0x00009A30
		public unsafe readonly FVector2DDouble GetSignVector()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_GetSignVector(this);
			}
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x0000B848 File Offset: 0x00009A48
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x060006EE RID: 1774 RVA: 0x0000B860 File Offset: 0x00009A60
		public unsafe readonly FVectorDouble SphericalToUnitCartesian()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_SphericalToUnitCartesian(this);
			}
		}

		// Token: 0x060006EF RID: 1775 RVA: 0x0000B878 File Offset: 0x00009A78
		[NullableContext(2)]
		public unsafe void InitFromString(string str)
		{
			if (str == null || str.Length == 0)
			{
				this.X = (this.Y = 0.0);
				return;
			}
			fixed (FVector2DDouble* ptr = &this)
			{
				char* ptr2;
				if (str == null)
				{
					ptr2 = null;
				}
				else
				{
					fixed (char* ptr3 = str.GetPinnableReference())
					{
						ptr2 = ptr3;
					}
				}
				char* ptr4 = ptr2;
				FCSharpStringView fcsharpStringView = new FCSharpStringView(ptr4, str.Length);
				FVector2DDouble.Internal_InitFromString(ref this, fcsharpStringView);
				char* ptr3 = null;
			}
		}

		// Token: 0x060006F0 RID: 1776 RVA: 0x0000B8DA File Offset: 0x00009ADA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVector2DDouble._ScriptStructPtr != 0) ? FVector2DDouble._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Vector2DDouble", ref FVector2DDouble._ScriptStructPtr);
		}

		// Token: 0x040000D9 RID: 217
		public static readonly FVector2DDouble ZeroVector = new FVector2DDouble(0.0, 0.0);

		// Token: 0x040000DA RID: 218
		public static readonly FVector2DDouble UnitVector = new FVector2DDouble(1.0, 1.0);

		// Token: 0x040000DB RID: 219
		public static readonly FVector2DDouble Unit45Deg = new FVector2DDouble(0.7071067690849304, 0.7071067690849304);

		// Token: 0x040000DC RID: 220
		[FieldOffset(0)]
		public double X;

		// Token: 0x040000DD RID: 221
		[FieldOffset(8)]
		public double Y;

		// Token: 0x040000DE RID: 222
		public const string __ObjectPath = "/Script/CoreUObject.Vector2DDouble";

		// Token: 0x040000DF RID: 223
		private static IntPtr _ScriptStructPtr;
	}
}
