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
	// Token: 0x02000042 RID: 66
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(16, 8, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 16)]
	[UnrealObjectPath("/Script/CoreUObject.Vector2DDouble")]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 16)]
	public struct FVector2DDouble : IEquatable<FVector2DDouble>, IEqualityOperators<FVector2DDouble, FVector2DDouble, bool>, IUnrealScriptStruct
	{
		// Token: 0x0600070B RID: 1803 RVA: 0x0000EA1A File Offset: 0x0000CC1A
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

		// Token: 0x0600070C RID: 1804 RVA: 0x0000EA50 File Offset: 0x0000CC50
		public FVector2DDouble()
		{
			this.X = 0.0;
			this.Y = 0.0;
		}

		// Token: 0x0600070D RID: 1805 RVA: 0x0000EA70 File Offset: 0x0000CC70
		public FVector2DDouble(double inX, double inY)
		{
			this.X = inX;
			this.Y = inY;
		}

		// Token: 0x0600070E RID: 1806 RVA: 0x0000EA80 File Offset: 0x0000CC80
		public FVector2DDouble(double inF)
		{
			this = new FVector2DDouble(inF, inF);
		}

		// Token: 0x0600070F RID: 1807 RVA: 0x0000EA8A File Offset: 0x0000CC8A
		public FVector2DDouble(in FIntPoint inPos)
		{
			this = new FVector2DDouble((double)inPos.X, (double)inPos.Y);
		}

		// Token: 0x06000710 RID: 1808 RVA: 0x0000EAA0 File Offset: 0x0000CCA0
		public static FVector2DDouble operator *(double scale, in FVector2DDouble v)
		{
			return v * scale;
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x0000EAA9 File Offset: 0x0000CCA9
		public static FVector2DDouble operator -(in FVector2DDouble v)
		{
			return new FVector2DDouble(-v.X, -v.Y);
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x0000EABE File Offset: 0x0000CCBE
		public static bool operator <(in FVector2DDouble a, in FVector2DDouble b)
		{
			return a.X < b.X && a.Y < b.Y;
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x0000EADE File Offset: 0x0000CCDE
		public static bool operator >(in FVector2DDouble a, in FVector2DDouble b)
		{
			return a.X > b.X && a.Y > b.Y;
		}

		// Token: 0x06000714 RID: 1812 RVA: 0x0000EAFE File Offset: 0x0000CCFE
		public static bool operator <=(in FVector2DDouble a, in FVector2DDouble b)
		{
			return a.X <= b.X && a.Y <= b.Y;
		}

		// Token: 0x06000715 RID: 1813 RVA: 0x0000EB21 File Offset: 0x0000CD21
		public static bool operator >=(in FVector2DDouble a, in FVector2DDouble b)
		{
			return a.X >= b.X && a.Y >= b.Y;
		}

		// Token: 0x06000716 RID: 1814 RVA: 0x0000EB44 File Offset: 0x0000CD44
		public readonly bool Equals(FVector2DDouble other)
		{
			return this == other;
		}

		// Token: 0x06000717 RID: 1815 RVA: 0x0000EB54 File Offset: 0x0000CD54
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

		// Token: 0x06000718 RID: 1816 RVA: 0x0000EB7E File Offset: 0x0000CD7E
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<double, double>(this.X, this.Y);
		}

		// Token: 0x06000719 RID: 1817 RVA: 0x0000EB94 File Offset: 0x0000CD94
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

		// Token: 0x1700001E RID: 30
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

		// Token: 0x0600071C RID: 1820 RVA: 0x0000EC33 File Offset: 0x0000CE33
		public readonly double Component(int index)
		{
			return this[index];
		}

		// Token: 0x0600071D RID: 1821
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Eq(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x0600071E RID: 1822
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_NotEq(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x0600071F RID: 1823
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_Add(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x06000720 RID: 1824
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_AddDouble(in FVector2DDouble a, double bias);

		// Token: 0x06000721 RID: 1825
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_Sub(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x06000722 RID: 1826
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_SubDouble(in FVector2DDouble a, double bias);

		// Token: 0x06000723 RID: 1827
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_Mul(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x06000724 RID: 1828
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_MulDouble(in FVector2DDouble a, double scale);

		// Token: 0x06000725 RID: 1829
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_Div(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x06000726 RID: 1830
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_DivDouble(in FVector2DDouble a, double scale);

		// Token: 0x06000727 RID: 1831
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_Or(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x06000728 RID: 1832
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_Xor(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x06000729 RID: 1833
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_Min(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x0600072A RID: 1834
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_Max(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x0600072B RID: 1835
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_DotProduct(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x0600072C RID: 1836
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_CrossProduct(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x0600072D RID: 1837
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_Distance(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x0600072E RID: 1838
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_DistSquared(in FVector2DDouble a, in FVector2DDouble b);

		// Token: 0x0600072F RID: 1839
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FVector2DDouble a, in FVector2DDouble b, double tolerance = 9.999999747378752E-05);

		// Token: 0x06000730 RID: 1840
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Set(ref FVector2DDouble a, double x, double y);

		// Token: 0x06000731 RID: 1841
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_GetMax(in FVector2DDouble a);

		// Token: 0x06000732 RID: 1842
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_GetAbsMax(in FVector2DDouble a);

		// Token: 0x06000733 RID: 1843
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_GetMin(in FVector2DDouble a);

		// Token: 0x06000734 RID: 1844
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_GetAbs(in FVector2DDouble a);

		// Token: 0x06000735 RID: 1845
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_Size(in FVector2DDouble a);

		// Token: 0x06000736 RID: 1846
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_SizeSquared(in FVector2DDouble a);

		// Token: 0x06000737 RID: 1847
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_GetRotated(in FVector2DDouble a, double angleDeg);

		// Token: 0x06000738 RID: 1848
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsNearlyZero(in FVector2DDouble a, double tolerance = 9.999999747378752E-05);

		// Token: 0x06000739 RID: 1849
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsZero(in FVector2DDouble a);

		// Token: 0x0600073A RID: 1850
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Normalize(ref FVector2DDouble a, double tolerance = 9.99999993922529E-09);

		// Token: 0x0600073B RID: 1851
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_GetSafeNormal(in FVector2DDouble a, double tolerance = 9.99999993922529E-09);

		// Token: 0x0600073C RID: 1852
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ToDirectionAndLength(in FVector2DDouble a, out FVector2DDouble outDirection, out double outLength);

		// Token: 0x0600073D RID: 1853
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint Internal_IntPoint(in FVector2DDouble a);

		// Token: 0x0600073E RID: 1854
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_RoundToVector(in FVector2DDouble a);

		// Token: 0x0600073F RID: 1855
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_ClampAxes(in FVector2DDouble a, double minAxisVal, double maxAxisVal);

		// Token: 0x06000740 RID: 1856
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2DDouble Internal_GetSignVector(in FVector2DDouble a);

		// Token: 0x06000741 RID: 1857
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FVector2DDouble a);

		// Token: 0x06000742 RID: 1858
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_SphericalToUnitCartesian(in FVector2DDouble a);

		// Token: 0x06000743 RID: 1859
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_InitFromString(ref FVector2DDouble a, in FCSharpStringView str);

		// Token: 0x06000744 RID: 1860 RVA: 0x0000EC3C File Offset: 0x0000CE3C
		public static bool operator ==(FVector2DDouble a, FVector2DDouble b)
		{
			return FVector2DDouble.Internal_Eq(a, b);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0000EC47 File Offset: 0x0000CE47
		public static bool operator !=(FVector2DDouble a, FVector2DDouble b)
		{
			return FVector2DDouble.Internal_NotEq(a, b);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x0000EC54 File Offset: 0x0000CE54
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

		// Token: 0x06000747 RID: 1863 RVA: 0x0000EC70 File Offset: 0x0000CE70
		public unsafe static FVector2DDouble operator +(in FVector2DDouble a, double bias)
		{
			fixed (FVector2DDouble* ptr = &a)
			{
				return FVector2DDouble.Internal_AddDouble(a, bias);
			}
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0000EC88 File Offset: 0x0000CE88
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

		// Token: 0x06000749 RID: 1865 RVA: 0x0000ECA4 File Offset: 0x0000CEA4
		public unsafe static FVector2DDouble operator -(in FVector2DDouble a, double bias)
		{
			fixed (FVector2DDouble* ptr = &a)
			{
				return FVector2DDouble.Internal_SubDouble(a, bias);
			}
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0000ECBC File Offset: 0x0000CEBC
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

		// Token: 0x0600074B RID: 1867 RVA: 0x0000ECD8 File Offset: 0x0000CED8
		public unsafe static FVector2DDouble operator *(in FVector2DDouble a, double scale)
		{
			fixed (FVector2DDouble* ptr = &a)
			{
				return FVector2DDouble.Internal_MulDouble(a, scale);
			}
		}

		// Token: 0x0600074C RID: 1868 RVA: 0x0000ECF0 File Offset: 0x0000CEF0
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

		// Token: 0x0600074D RID: 1869 RVA: 0x0000ED0C File Offset: 0x0000CF0C
		public unsafe static FVector2DDouble operator /(in FVector2DDouble a, double scale)
		{
			fixed (FVector2DDouble* ptr = &a)
			{
				return FVector2DDouble.Internal_DivDouble(a, scale);
			}
		}

		// Token: 0x0600074E RID: 1870 RVA: 0x0000ED24 File Offset: 0x0000CF24
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

		// Token: 0x0600074F RID: 1871 RVA: 0x0000ED40 File Offset: 0x0000CF40
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

		// Token: 0x06000750 RID: 1872 RVA: 0x0000ED5C File Offset: 0x0000CF5C
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

		// Token: 0x06000751 RID: 1873 RVA: 0x0000ED78 File Offset: 0x0000CF78
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

		// Token: 0x06000752 RID: 1874 RVA: 0x0000ED94 File Offset: 0x0000CF94
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

		// Token: 0x06000753 RID: 1875 RVA: 0x0000EDB0 File Offset: 0x0000CFB0
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

		// Token: 0x06000754 RID: 1876 RVA: 0x0000EDCC File Offset: 0x0000CFCC
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

		// Token: 0x06000755 RID: 1877 RVA: 0x0000EDE8 File Offset: 0x0000CFE8
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

		// Token: 0x06000756 RID: 1878 RVA: 0x0000EE04 File Offset: 0x0000D004
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

		// Token: 0x06000757 RID: 1879 RVA: 0x0000EE24 File Offset: 0x0000D024
		public unsafe void Set(double x, double y)
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				FVector2DDouble.Internal_Set(ref this, x, y);
			}
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0000EE40 File Offset: 0x0000D040
		public unsafe readonly double GetMax()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_GetMax(this);
			}
		}

		// Token: 0x06000759 RID: 1881 RVA: 0x0000EE58 File Offset: 0x0000D058
		public unsafe readonly double GetAbsMax()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_GetAbsMax(this);
			}
		}

		// Token: 0x0600075A RID: 1882 RVA: 0x0000EE70 File Offset: 0x0000D070
		public unsafe readonly double GetMin()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_GetMin(this);
			}
		}

		// Token: 0x0600075B RID: 1883 RVA: 0x0000EE88 File Offset: 0x0000D088
		public unsafe readonly FVector2DDouble GetAbs()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_GetAbs(this);
			}
		}

		// Token: 0x0600075C RID: 1884 RVA: 0x0000EEA0 File Offset: 0x0000D0A0
		public unsafe readonly double Size()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_Size(this);
			}
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0000EEB8 File Offset: 0x0000D0B8
		public unsafe readonly double SizeSquared()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_SizeSquared(this);
			}
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0000EED0 File Offset: 0x0000D0D0
		public unsafe readonly FVector2DDouble GetRotated(double angleDeg)
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_GetRotated(this, angleDeg);
			}
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0000EEE8 File Offset: 0x0000D0E8
		public unsafe readonly bool IsNearlyZero(double tolerance = 9.999999747378752E-05)
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_IsNearlyZero(this, tolerance);
			}
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0000EF00 File Offset: 0x0000D100
		public unsafe readonly bool IsZero()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_IsZero(this);
			}
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0000EF18 File Offset: 0x0000D118
		public unsafe void Normalize(double tolerance = 9.99999993922529E-09)
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				FVector2DDouble.Internal_Normalize(ref this, tolerance);
			}
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x0000EF34 File Offset: 0x0000D134
		public unsafe readonly FVector2DDouble GetSafeNormal(double tolerance = 9.99999993922529E-09)
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_GetSafeNormal(this, tolerance);
			}
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0000EF4C File Offset: 0x0000D14C
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

		// Token: 0x06000764 RID: 1892 RVA: 0x0000EF78 File Offset: 0x0000D178
		public unsafe readonly FIntPoint IntPoint()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_IntPoint(this);
			}
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0000EF90 File Offset: 0x0000D190
		public unsafe readonly FVector2DDouble RoundToVector()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_RoundToVector(this);
			}
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0000EFA8 File Offset: 0x0000D1A8
		public unsafe readonly FVector2DDouble ClampAxes(double minAxisVal, double maxAxisVal)
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_ClampAxes(this, minAxisVal, maxAxisVal);
			}
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x0000EFC4 File Offset: 0x0000D1C4
		public unsafe readonly FVector2DDouble GetSignVector()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_GetSignVector(this);
			}
		}

		// Token: 0x06000768 RID: 1896 RVA: 0x0000EFDC File Offset: 0x0000D1DC
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x06000769 RID: 1897 RVA: 0x0000EFF4 File Offset: 0x0000D1F4
		public unsafe readonly FVectorDouble SphericalToUnitCartesian()
		{
			fixed (FVector2DDouble* ptr = &this)
			{
				return FVector2DDouble.Internal_SphericalToUnitCartesian(this);
			}
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0000F00C File Offset: 0x0000D20C
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

		// Token: 0x0600076B RID: 1899 RVA: 0x0000F06E File Offset: 0x0000D26E
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVector2DDouble._ScriptStructPtr != 0) ? FVector2DDouble._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Vector2DDouble", ref FVector2DDouble._ScriptStructPtr);
		}

		// Token: 0x04000120 RID: 288
		public static readonly FVector2DDouble ZeroVector = new FVector2DDouble(0.0, 0.0);

		// Token: 0x04000121 RID: 289
		public static readonly FVector2DDouble UnitVector = new FVector2DDouble(1.0, 1.0);

		// Token: 0x04000122 RID: 290
		public static readonly FVector2DDouble Unit45Deg = new FVector2DDouble(0.7071067690849304, 0.7071067690849304);

		// Token: 0x04000123 RID: 291
		[FieldOffset(0)]
		public double X;

		// Token: 0x04000124 RID: 292
		[FieldOffset(8)]
		public double Y;

		// Token: 0x04000125 RID: 293
		public const string __ObjectPath = "/Script/CoreUObject.Vector2DDouble";

		// Token: 0x04000126 RID: 294
		private static IntPtr _ScriptStructPtr;
	}
}
