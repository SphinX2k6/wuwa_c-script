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
	// Token: 0x02000044 RID: 68
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 24)]
	[UnrealObjectPath("/Script/CoreUObject.VectorDouble")]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 24)]
	public struct FVectorDouble : IEquatable<FVectorDouble>, IEqualityOperators<FVectorDouble, FVectorDouble, bool>, IVector, IVector2D, IUnrealScriptStruct
	{
		// Token: 0x060007B6 RID: 1974 RVA: 0x0000F7A1 File Offset: 0x0000D9A1
		[Conditional("ENABLE_NAN_DIAGNOSTIC")]
		public void DiagnosticCheckNaN()
		{
			if (!SharpherealAssert.Ensure(!this.ContainsNaN(), "FVectorDouble contains NaN: {0}", new object[]
			{
				this
			}))
			{
				this = FVectorDouble.ZeroVector;
			}
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0000F7D7 File Offset: 0x0000D9D7
		public FVectorDouble()
		{
			this.X = 0.0;
			this.Y = 0.0;
			this.Z = 0.0;
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x0000F806 File Offset: 0x0000DA06
		public FVectorDouble(double inF)
		{
			this = new FVectorDouble(inF, inF, inF);
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x0000F811 File Offset: 0x0000DA11
		public FVectorDouble(in FVector2D v, double inZ)
		{
			this = new FVectorDouble((double)v.X, (double)v.Y, inZ);
		}

		// Token: 0x060007BA RID: 1978 RVA: 0x0000F828 File Offset: 0x0000DA28
		public FVectorDouble(in FVector v)
		{
			this = new FVectorDouble((double)v.X, (double)v.Y, (double)v.Z);
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0000F845 File Offset: 0x0000DA45
		public FVectorDouble(in FLinearColor c)
		{
			this = new FVectorDouble((double)c.R, (double)c.G, (double)c.B);
		}

		// Token: 0x060007BC RID: 1980 RVA: 0x0000F862 File Offset: 0x0000DA62
		public FVectorDouble(in FIntPoint a)
		{
			this = new FVectorDouble((double)a.X, (double)a.Y, 0.0);
		}

		// Token: 0x060007BD RID: 1981 RVA: 0x0000F881 File Offset: 0x0000DA81
		public FVectorDouble(in FIntVector a)
		{
			this = new FVectorDouble((double)a.X, (double)a.Y, 0.0);
		}

		// Token: 0x060007BE RID: 1982 RVA: 0x0000F8A0 File Offset: 0x0000DAA0
		public FVectorDouble(in FVector v, FIntVector offset)
		{
			this = new FVectorDouble((double)(v.X + (float)offset.X), (double)(v.Y + (float)offset.Y), (double)(v.Z + (float)offset.Z));
		}

		// Token: 0x060007BF RID: 1983 RVA: 0x0000F8D5 File Offset: 0x0000DAD5
		public static implicit operator FVector(in FVectorDouble a)
		{
			return new FVector((float)a.X, (float)a.Y, (float)a.Z);
		}

		// Token: 0x060007C0 RID: 1984 RVA: 0x0000F8F1 File Offset: 0x0000DAF1
		public static implicit operator FVectorDouble(in FVector a)
		{
			return new FVectorDouble((double)a.X, (double)a.Y, (double)a.Z);
		}

		// Token: 0x060007C1 RID: 1985 RVA: 0x0000F90D File Offset: 0x0000DB0D
		public static FVectorDouble operator -(in FVectorDouble v)
		{
			return new FVectorDouble(-v.X, -v.Y, -v.Z);
		}

		// Token: 0x060007C2 RID: 1986 RVA: 0x0000F929 File Offset: 0x0000DB29
		public static FVectorDouble operator *(double scale, in FVectorDouble v)
		{
			return v * scale;
		}

		// Token: 0x060007C3 RID: 1987 RVA: 0x0000F932 File Offset: 0x0000DB32
		public static bool operator ==(FVectorDouble a, FVectorDouble b)
		{
			return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
		}

		// Token: 0x060007C4 RID: 1988 RVA: 0x0000F960 File Offset: 0x0000DB60
		public static bool operator !=(FVectorDouble a, FVectorDouble b)
		{
			return a.X != b.X || a.Y != b.Y || a.Z != b.Z;
		}

		// Token: 0x060007C5 RID: 1989 RVA: 0x0000F991 File Offset: 0x0000DB91
		public readonly bool Equals(FVectorDouble other)
		{
			return this == other;
		}

		// Token: 0x060007C6 RID: 1990 RVA: 0x0000F9A0 File Offset: 0x0000DBA0
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FVectorDouble)
			{
				FVectorDouble b = (FVectorDouble)obj;
				return this == b;
			}
			return false;
		}

		// Token: 0x060007C7 RID: 1991 RVA: 0x0000F9CA File Offset: 0x0000DBCA
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<double, double, double>(this.X, this.Y, this.Z);
		}

		// Token: 0x17000020 RID: 32
		public double this[int index]
		{
			readonly get
			{
				double result;
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

		// Token: 0x060007CA RID: 1994 RVA: 0x0000FA5A File Offset: 0x0000DC5A
		public readonly double Component(int index)
		{
			return this[index];
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0000FA63 File Offset: 0x0000DC63
		public readonly FVector ToVector()
		{
			return new FVector((float)this.X, (float)this.Y, (float)this.Z);
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x0000FA80 File Offset: 0x0000DC80
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 3);
			defaultInterpolatedStringHandler.AppendLiteral("X=");
			defaultInterpolatedStringHandler.AppendFormatted<double>(this.X);
			defaultInterpolatedStringHandler.AppendLiteral(" Y=");
			defaultInterpolatedStringHandler.AppendFormatted<double>(this.Y);
			defaultInterpolatedStringHandler.AppendLiteral(" Z=");
			defaultInterpolatedStringHandler.AppendFormatted<double>(this.Z);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x060007CD RID: 1997
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_Ctor(double x, double y, double z);

		// Token: 0x060007CE RID: 1998
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_Add(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x060007CF RID: 1999
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_AddFIntVector(in FVectorDouble a, in FIntVector b);

		// Token: 0x060007D0 RID: 2000
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_AddDouble(in FVectorDouble a, double bias);

		// Token: 0x060007D1 RID: 2001
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_Sub(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x060007D2 RID: 2002
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_SubFIntVector(in FVectorDouble a, in FIntVector b);

		// Token: 0x060007D3 RID: 2003
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_SubDouble(in FVectorDouble a, double bias);

		// Token: 0x060007D4 RID: 2004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_Mul(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x060007D5 RID: 2005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_MulDouble(in FVectorDouble a, double scale);

		// Token: 0x060007D6 RID: 2006
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_Div(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x060007D7 RID: 2007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_DivDouble(in FVectorDouble a, double scale);

		// Token: 0x060007D8 RID: 2008
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_Or(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x060007D9 RID: 2009
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_Xor(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x060007DA RID: 2010
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_DotProduct(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x060007DB RID: 2011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_CrossProduct(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x060007DC RID: 2012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateOrthonormalBasis(ref FVectorDouble a, ref FVectorDouble b, ref FVectorDouble c);

		// Token: 0x060007DD RID: 2013
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_PointsAreSame(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x060007DE RID: 2014
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_PointsAreNear(in FVectorDouble a, in FVectorDouble b, double dist);

		// Token: 0x060007DF RID: 2015
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_PointPlaneDist(in FVectorDouble point, in FVectorDouble planeBase, in FVectorDouble planeNormal);

		// Token: 0x060007E0 RID: 2016
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_PointPlaneProject_Plane(in FVectorDouble point, in FPlane plane);

		// Token: 0x060007E1 RID: 2017
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_PointPlaneProject_abc(in FVectorDouble point, in FVectorDouble a, in FVectorDouble b, in FVectorDouble c);

		// Token: 0x060007E2 RID: 2018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_PointPlaneProject_base_normal(in FVectorDouble point, in FVectorDouble planeBase, in FVectorDouble planeNormal);

		// Token: 0x060007E3 RID: 2019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_VectorPlaneProject(in FVectorDouble v, in FVectorDouble planeNormal);

		// Token: 0x060007E4 RID: 2020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_Dist(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x060007E5 RID: 2021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_Distance(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x060007E6 RID: 2022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_DistXY(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x060007E7 RID: 2023
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_Dist2D(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x060007E8 RID: 2024
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_DistSquared(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x060007E9 RID: 2025
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_DistSquaredXY(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x060007EA RID: 2026
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_DistSquared2D(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x060007EB RID: 2027
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_BoxPushOut(in FVectorDouble normal, in FVectorDouble size);

		// Token: 0x060007EC RID: 2028
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Parallel(in FVectorDouble normal1, in FVectorDouble normal2, double parallelCosineThreshold = 0.999845027923584);

		// Token: 0x060007ED RID: 2029
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Coincident(in FVectorDouble normal1, in FVectorDouble normal2, double parallelCosineThreshold = 0.999845027923584);

		// Token: 0x060007EE RID: 2030
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Orthogonal(in FVectorDouble normal1, in FVectorDouble normal2, double parallelCosineThreshold = 0.999845027923584);

		// Token: 0x060007EF RID: 2031
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Coplanar(in FVectorDouble base1, in FVectorDouble normal1, in FVectorDouble base2, in FVectorDouble normal2, double parallelCosineThreshold = 0.999845027923584);

		// Token: 0x060007F0 RID: 2032
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_Triple(in FVectorDouble x, in FVectorDouble y, in FVectorDouble z);

		// Token: 0x060007F1 RID: 2033
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_RadiansToDegrees(in FVectorDouble radVector);

		// Token: 0x060007F2 RID: 2034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_DegreesToRadians(in FVectorDouble degVector);

		// Token: 0x060007F3 RID: 2035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_ComputeSquaredDistanceFromBoxToPoint(in FVectorDouble mins, in FVectorDouble maxs, in FVectorDouble point);

		// Token: 0x060007F4 RID: 2036
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_ClampVector(in FVectorDouble v, in FVectorDouble min, in FVectorDouble max);

		// Token: 0x060007F5 RID: 2037
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FVectorDouble a, in FVectorDouble b, double tolerance = 9.999999747378752E-05);

		// Token: 0x060007F6 RID: 2038
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_AllComponentsEqual(in FVectorDouble a, double tolerance = 9.999999747378752E-05);

		// Token: 0x060007F7 RID: 2039
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_GetComponentForAxis(in FVectorDouble a, EAxis axis);

		// Token: 0x060007F8 RID: 2040
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetComponentForAxis(ref FVectorDouble a, EAxis axis, double component);

		// Token: 0x060007F9 RID: 2041
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Set(ref FVectorDouble a, double x, double y, double z);

		// Token: 0x060007FA RID: 2042
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_GetMax(in FVectorDouble a);

		// Token: 0x060007FB RID: 2043
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_GetAbsMax(in FVectorDouble a);

		// Token: 0x060007FC RID: 2044
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_GetMin(in FVectorDouble a);

		// Token: 0x060007FD RID: 2045
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_GetAbsMin(in FVectorDouble a);

		// Token: 0x060007FE RID: 2046
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_ComponentMin(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x060007FF RID: 2047
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_ComponentMax(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x06000800 RID: 2048
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetAbs(in FVectorDouble a);

		// Token: 0x06000801 RID: 2049
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_Size(in FVectorDouble a);

		// Token: 0x06000802 RID: 2050
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_SizeSquared(in FVectorDouble a);

		// Token: 0x06000803 RID: 2051
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_Size2D(in FVectorDouble a);

		// Token: 0x06000804 RID: 2052
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_SizeSquared2D(in FVectorDouble a);

		// Token: 0x06000805 RID: 2053
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsNearlyZero(in FVectorDouble a, double tolerance = 9.999999747378752E-05);

		// Token: 0x06000806 RID: 2054
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsZero(in FVectorDouble a);

		// Token: 0x06000807 RID: 2055
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsUnit(in FVectorDouble a);

		// Token: 0x06000808 RID: 2056
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsNormalized(in FVectorDouble a);

		// Token: 0x06000809 RID: 2057
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Normalize(ref FVectorDouble a, double tolerance = 9.99999993922529E-09);

		// Token: 0x0600080A RID: 2058
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetUnsafeNormal(in FVectorDouble a);

		// Token: 0x0600080B RID: 2059
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetSafeNormal(in FVectorDouble a, double tolerance = 9.99999993922529E-09);

		// Token: 0x0600080C RID: 2060
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetSafeNormal2D(in FVectorDouble a, double tolerance = 9.99999993922529E-09);

		// Token: 0x0600080D RID: 2061
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ToDirectionAndLength(in FVectorDouble a, out FVectorDouble outDirection, out double outLength);

		// Token: 0x0600080E RID: 2062
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetSignVector(in FVectorDouble a);

		// Token: 0x0600080F RID: 2063
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_Projection(in FVectorDouble a);

		// Token: 0x06000810 RID: 2064
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetUnsafeNormal2D(in FVectorDouble a);

		// Token: 0x06000811 RID: 2065
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GridSnap(in FVectorDouble a, double gridSz);

		// Token: 0x06000812 RID: 2066
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_BoundToCube(in FVectorDouble a, double radius);

		// Token: 0x06000813 RID: 2067
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_BoundToBox(in FVectorDouble a, in FVectorDouble min, in FVectorDouble max);

		// Token: 0x06000814 RID: 2068
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetClampedToSize(in FVectorDouble a, double min, double max);

		// Token: 0x06000815 RID: 2069
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetClampedToSize2D(in FVectorDouble a, double min, double max);

		// Token: 0x06000816 RID: 2070
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetClampedToMaxSize(in FVectorDouble a, double maxSize);

		// Token: 0x06000817 RID: 2071
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetClampedToMaxSize2D(in FVectorDouble a, double maxSize);

		// Token: 0x06000818 RID: 2072
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_AddBounded(ref FVectorDouble a, in FVectorDouble v, double radius = 32767.0);

		// Token: 0x06000819 RID: 2073
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_Reciprocal(in FVectorDouble a);

		// Token: 0x0600081A RID: 2074
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsUniform(in FVectorDouble a, double tolerance = 9.999999747378752E-05);

		// Token: 0x0600081B RID: 2075
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_MirrorByVector(in FVectorDouble a, in FVectorDouble mirrorNormal);

		// Token: 0x0600081C RID: 2076
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_MirrorByPlane(in FVectorDouble a, in FPlane plane);

		// Token: 0x0600081D RID: 2077
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_RotateAngleAxis(in FVectorDouble a, double angleDeg, in FVectorDouble axis);

		// Token: 0x0600081E RID: 2078
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_CosineAngle2D(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x0600081F RID: 2079
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_ProjectOnTo(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x06000820 RID: 2080
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_ProjectOnToNormal(in FVectorDouble a, in FVectorDouble normal);

		// Token: 0x06000821 RID: 2081
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_ToOrientationRotator(in FVectorDouble a);

		// Token: 0x06000822 RID: 2082
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_ToOrientationQuat(in FVectorDouble a);

		// Token: 0x06000823 RID: 2083
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_ToLocalVector(in FVectorDouble a, in FIntVector offset);

		// Token: 0x06000824 RID: 2084
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_Rotation(in FVectorDouble a);

		// Token: 0x06000825 RID: 2085
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_FindBestAxisVectors(in FVectorDouble a, out FVectorDouble outAxis1, out FVectorDouble outAxis2);

		// Token: 0x06000826 RID: 2086
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_UnwindEuler(ref FVectorDouble a);

		// Token: 0x06000827 RID: 2087
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FVectorDouble a);

		// Token: 0x06000828 RID: 2088
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_UnitCartesianToSpherical(in FVectorDouble a);

		// Token: 0x06000829 RID: 2089
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_HeadingAngle(in FVectorDouble a);

		// Token: 0x0600082A RID: 2090
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_InitFromString(ref FVectorDouble a, in FCSharpStringView str);

		// Token: 0x0600082B RID: 2091 RVA: 0x0000FAE8 File Offset: 0x0000DCE8
		public FVectorDouble(double inX, double inY, double inZ)
		{
			this.X = inX;
			this.Y = inY;
			this.Z = inZ;
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0000FB00 File Offset: 0x0000DD00
		public unsafe static FVectorDouble operator +(in FVectorDouble a, in FVectorDouble b)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				fixed (FVectorDouble* ptr2 = &b)
				{
					return FVectorDouble.Internal_Add(a, b);
				}
			}
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x0000FB1C File Offset: 0x0000DD1C
		public unsafe static FVectorDouble operator +(in FVectorDouble a, in FIntVector b)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				fixed (FIntVector* ptr2 = &b)
				{
					return FVectorDouble.Internal_AddFIntVector(a, b);
				}
			}
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x0000FB38 File Offset: 0x0000DD38
		public unsafe static FVectorDouble operator +(in FVectorDouble a, double bias)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				return FVectorDouble.Internal_AddDouble(a, bias);
			}
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x0000FB50 File Offset: 0x0000DD50
		public unsafe static FVectorDouble operator -(in FVectorDouble a, in FVectorDouble b)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				fixed (FVectorDouble* ptr2 = &b)
				{
					return FVectorDouble.Internal_Sub(a, b);
				}
			}
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x0000FB6C File Offset: 0x0000DD6C
		public unsafe static FVectorDouble operator -(in FVectorDouble a, in FIntVector b)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				fixed (FIntVector* ptr2 = &b)
				{
					return FVectorDouble.Internal_SubFIntVector(a, b);
				}
			}
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x0000FB88 File Offset: 0x0000DD88
		public unsafe static FVectorDouble operator -(in FVectorDouble a, double bias)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				return FVectorDouble.Internal_SubDouble(a, bias);
			}
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x0000FBA0 File Offset: 0x0000DDA0
		public unsafe static FVectorDouble operator *(in FVectorDouble a, in FVectorDouble b)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				fixed (FVectorDouble* ptr2 = &b)
				{
					return FVectorDouble.Internal_Mul(a, b);
				}
			}
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x0000FBBC File Offset: 0x0000DDBC
		public unsafe static FVectorDouble operator *(in FVectorDouble a, double scale)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				return FVectorDouble.Internal_MulDouble(a, scale);
			}
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x0000FBD4 File Offset: 0x0000DDD4
		public unsafe static FVectorDouble operator /(in FVectorDouble a, in FVectorDouble b)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				fixed (FVectorDouble* ptr2 = &b)
				{
					return FVectorDouble.Internal_Div(a, b);
				}
			}
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x0000FBF0 File Offset: 0x0000DDF0
		public unsafe static FVectorDouble operator /(in FVectorDouble a, double scale)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				return FVectorDouble.Internal_DivDouble(a, scale);
			}
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x0000FC08 File Offset: 0x0000DE08
		public unsafe static double operator |(in FVectorDouble a, in FVectorDouble b)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				fixed (FVectorDouble* ptr2 = &b)
				{
					return FVectorDouble.Internal_Or(a, b);
				}
			}
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x0000FC24 File Offset: 0x0000DE24
		public unsafe static FVectorDouble operator ^(in FVectorDouble a, in FVectorDouble b)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				fixed (FVectorDouble* ptr2 = &b)
				{
					return FVectorDouble.Internal_Xor(a, b);
				}
			}
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x0000FC40 File Offset: 0x0000DE40
		public unsafe static double DotProduct(in FVectorDouble a, in FVectorDouble b)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				fixed (FVectorDouble* ptr2 = &b)
				{
					return FVectorDouble.Internal_DotProduct(a, b);
				}
			}
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x0000FC5C File Offset: 0x0000DE5C
		public unsafe static FVectorDouble CrossProduct(in FVectorDouble a, in FVectorDouble b)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				fixed (FVectorDouble* ptr2 = &b)
				{
					return FVectorDouble.Internal_CrossProduct(a, b);
				}
			}
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x0000FC78 File Offset: 0x0000DE78
		public unsafe static void CreateOrthonormalBasis(ref FVectorDouble a, ref FVectorDouble b, ref FVectorDouble c)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				fixed (FVectorDouble* ptr2 = &b)
				{
					fixed (FVectorDouble* ptr3 = &c)
					{
						FVectorDouble.Internal_CreateOrthonormalBasis(ref a, ref b, ref c);
					}
				}
			}
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x0000FCA4 File Offset: 0x0000DEA4
		public unsafe static bool PointsAreSame(in FVectorDouble a, in FVectorDouble b)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				fixed (FVectorDouble* ptr2 = &b)
				{
					return FVectorDouble.Internal_PointsAreSame(a, b);
				}
			}
		}

		// Token: 0x0600083C RID: 2108 RVA: 0x0000FCC0 File Offset: 0x0000DEC0
		public unsafe static bool PointsAreNear(in FVectorDouble a, in FVectorDouble b, double dist)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				fixed (FVectorDouble* ptr2 = &b)
				{
					return FVectorDouble.Internal_PointsAreNear(a, b, dist);
				}
			}
		}

		// Token: 0x0600083D RID: 2109 RVA: 0x0000FCE0 File Offset: 0x0000DEE0
		public unsafe static double PointPlaneDist(in FVectorDouble point, in FVectorDouble planeBase, in FVectorDouble planeNormal)
		{
			fixed (FVectorDouble* ptr = &point)
			{
				fixed (FVectorDouble* ptr2 = &planeBase)
				{
					fixed (FVectorDouble* ptr3 = &planeNormal)
					{
						return FVectorDouble.Internal_PointPlaneDist(point, planeBase, planeNormal);
					}
				}
			}
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x0000FD04 File Offset: 0x0000DF04
		public unsafe static FVectorDouble PointPlaneProject(in FVectorDouble point, in FPlane plane)
		{
			fixed (FVectorDouble* ptr = &point)
			{
				fixed (FPlane* ptr2 = &plane)
				{
					return FVectorDouble.Internal_PointPlaneProject_Plane(point, plane);
				}
			}
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x0000FD20 File Offset: 0x0000DF20
		public unsafe static FVectorDouble PointPlaneProject(in FVectorDouble point, in FVectorDouble a, in FVectorDouble b, in FVectorDouble c)
		{
			fixed (FVectorDouble* ptr = &point)
			{
				fixed (FVectorDouble* ptr2 = &a)
				{
					fixed (FVectorDouble* ptr3 = &b)
					{
						fixed (FVectorDouble* ptr4 = &c)
						{
							return FVectorDouble.Internal_PointPlaneProject_abc(point, a, b, c);
						}
					}
				}
			}
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x0000FD48 File Offset: 0x0000DF48
		public unsafe static FVectorDouble PointPlaneProject(in FVectorDouble point, in FVectorDouble planeBase, in FVectorDouble planeNormal)
		{
			fixed (FVectorDouble* ptr = &point)
			{
				fixed (FVectorDouble* ptr2 = &planeBase)
				{
					fixed (FVectorDouble* ptr3 = &planeNormal)
					{
						return FVectorDouble.Internal_PointPlaneProject_base_normal(point, planeBase, planeNormal);
					}
				}
			}
		}

		// Token: 0x06000841 RID: 2113 RVA: 0x0000FD6C File Offset: 0x0000DF6C
		public unsafe static FVectorDouble VectorPlaneProject(in FVectorDouble v, in FVectorDouble planeNormal)
		{
			fixed (FVectorDouble* ptr = &v)
			{
				fixed (FVectorDouble* ptr2 = &planeNormal)
				{
					return FVectorDouble.Internal_VectorPlaneProject(v, planeNormal);
				}
			}
		}

		// Token: 0x06000842 RID: 2114 RVA: 0x0000FD88 File Offset: 0x0000DF88
		public unsafe static double Dist(in FVectorDouble a, in FVectorDouble b)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				fixed (FVectorDouble* ptr2 = &b)
				{
					return FVectorDouble.Internal_Dist(a, b);
				}
			}
		}

		// Token: 0x06000843 RID: 2115 RVA: 0x0000FDA4 File Offset: 0x0000DFA4
		public unsafe static double Distance(in FVectorDouble a, in FVectorDouble b)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				fixed (FVectorDouble* ptr2 = &b)
				{
					return FVectorDouble.Internal_Distance(a, b);
				}
			}
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x0000FDC0 File Offset: 0x0000DFC0
		public unsafe static double DistXY(in FVectorDouble a, in FVectorDouble b)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				fixed (FVectorDouble* ptr2 = &b)
				{
					return FVectorDouble.Internal_DistXY(a, b);
				}
			}
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x0000FDDC File Offset: 0x0000DFDC
		public unsafe static double Dist2D(in FVectorDouble a, in FVectorDouble b)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				fixed (FVectorDouble* ptr2 = &b)
				{
					return FVectorDouble.Internal_Dist2D(a, b);
				}
			}
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x0000FDF8 File Offset: 0x0000DFF8
		public unsafe static double DistSquared(in FVectorDouble a, in FVectorDouble b)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				fixed (FVectorDouble* ptr2 = &b)
				{
					return FVectorDouble.Internal_DistSquared(a, b);
				}
			}
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x0000FE14 File Offset: 0x0000E014
		public unsafe static double DistSquaredXY(in FVectorDouble a, in FVectorDouble b)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				fixed (FVectorDouble* ptr2 = &b)
				{
					return FVectorDouble.Internal_DistSquaredXY(a, b);
				}
			}
		}

		// Token: 0x06000848 RID: 2120 RVA: 0x0000FE30 File Offset: 0x0000E030
		public unsafe static double DistSquared2D(in FVectorDouble a, in FVectorDouble b)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				fixed (FVectorDouble* ptr2 = &b)
				{
					return FVectorDouble.Internal_DistSquared2D(a, b);
				}
			}
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x0000FE4C File Offset: 0x0000E04C
		public unsafe static double BoxPushOut(in FVectorDouble normal, in FVectorDouble size)
		{
			fixed (FVectorDouble* ptr = &normal)
			{
				fixed (FVectorDouble* ptr2 = &size)
				{
					return FVectorDouble.Internal_BoxPushOut(normal, size);
				}
			}
		}

		// Token: 0x0600084A RID: 2122 RVA: 0x0000FE68 File Offset: 0x0000E068
		public unsafe static bool Parallel(in FVectorDouble normal1, in FVectorDouble normal2, double parallelCosineThreshold = 0.999845027923584)
		{
			fixed (FVectorDouble* ptr = &normal1)
			{
				fixed (FVectorDouble* ptr2 = &normal2)
				{
					return FVectorDouble.Internal_Parallel(normal1, normal2, parallelCosineThreshold);
				}
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x0000FE88 File Offset: 0x0000E088
		public unsafe static bool Coincident(in FVectorDouble normal1, in FVectorDouble normal2, double parallelCosineThreshold = 0.999845027923584)
		{
			fixed (FVectorDouble* ptr = &normal1)
			{
				fixed (FVectorDouble* ptr2 = &normal2)
				{
					return FVectorDouble.Internal_Coincident(normal1, normal2, parallelCosineThreshold);
				}
			}
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x0000FEA8 File Offset: 0x0000E0A8
		public unsafe static bool Orthogonal(in FVectorDouble normal1, in FVectorDouble normal2, double parallelCosineThreshold = 0.999845027923584)
		{
			fixed (FVectorDouble* ptr = &normal1)
			{
				fixed (FVectorDouble* ptr2 = &normal2)
				{
					return FVectorDouble.Internal_Orthogonal(normal1, normal2, parallelCosineThreshold);
				}
			}
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x0000FEC8 File Offset: 0x0000E0C8
		public unsafe static bool Coplanar(in FVectorDouble base1, in FVectorDouble normal1, in FVectorDouble base2, in FVectorDouble normal2, double parallelCosineThreshold = 0.999845027923584)
		{
			fixed (FVectorDouble* ptr = &base1)
			{
				fixed (FVectorDouble* ptr2 = &normal1)
				{
					fixed (FVectorDouble* ptr3 = &base2)
					{
						fixed (FVectorDouble* ptr4 = &normal2)
						{
							return FVectorDouble.Internal_Coplanar(base1, normal1, base2, normal2, parallelCosineThreshold);
						}
					}
				}
			}
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x0000FEF0 File Offset: 0x0000E0F0
		public unsafe static double Triple(in FVectorDouble x, in FVectorDouble y, in FVectorDouble z)
		{
			fixed (FVectorDouble* ptr = &x)
			{
				fixed (FVectorDouble* ptr2 = &y)
				{
					fixed (FVectorDouble* ptr3 = &z)
					{
						return FVectorDouble.Internal_Triple(x, y, z);
					}
				}
			}
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x0000FF14 File Offset: 0x0000E114
		public unsafe static FVectorDouble RadiansToDegrees(in FVectorDouble radVector)
		{
			fixed (FVectorDouble* ptr = &radVector)
			{
				return FVectorDouble.Internal_RadiansToDegrees(radVector);
			}
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x0000FF2C File Offset: 0x0000E12C
		public unsafe static FVectorDouble DegreesToRadians(in FVectorDouble degVector)
		{
			fixed (FVectorDouble* ptr = &degVector)
			{
				return FVectorDouble.Internal_DegreesToRadians(degVector);
			}
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x0000FF44 File Offset: 0x0000E144
		public unsafe static double ComputeSquaredDistanceFromBoxToPoint(in FVectorDouble mins, in FVectorDouble maxs, in FVectorDouble point)
		{
			fixed (FVectorDouble* ptr = &mins)
			{
				fixed (FVectorDouble* ptr2 = &maxs)
				{
					fixed (FVectorDouble* ptr3 = &point)
					{
						return FVectorDouble.Internal_ComputeSquaredDistanceFromBoxToPoint(mins, maxs, point);
					}
				}
			}
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x0000FF68 File Offset: 0x0000E168
		public unsafe static FVectorDouble ClampVector(in FVectorDouble v, in FVectorDouble min, in FVectorDouble max)
		{
			fixed (FVectorDouble* ptr = &v)
			{
				fixed (FVectorDouble* ptr2 = &min)
				{
					fixed (FVectorDouble* ptr3 = &max)
					{
						return FVectorDouble.Internal_ClampVector(v, min, max);
					}
				}
			}
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x0000FF8C File Offset: 0x0000E18C
		public unsafe readonly bool Equals(in FVectorDouble b, double tolerance = 9.999999747378752E-05)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				fixed (FVectorDouble* ptr2 = &b)
				{
					return FVectorDouble.Internal_Equals(this, b, tolerance);
				}
			}
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x0000FFAC File Offset: 0x0000E1AC
		public unsafe readonly bool AllComponentsEqual(double tolerance = 9.999999747378752E-05)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_AllComponentsEqual(this, tolerance);
			}
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x0000FFC4 File Offset: 0x0000E1C4
		public unsafe readonly double GetComponentForAxis(EAxis axis)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetComponentForAxis(this, axis);
			}
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x0000FFDC File Offset: 0x0000E1DC
		public unsafe void SetComponentForAxis(EAxis axis, double component)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				FVectorDouble.Internal_SetComponentForAxis(ref this, axis, component);
			}
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0000FFF8 File Offset: 0x0000E1F8
		public unsafe void Set(double x, double y, double z)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				FVectorDouble.Internal_Set(ref this, x, y, z);
			}
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00010018 File Offset: 0x0000E218
		public unsafe readonly double GetMax()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetMax(this);
			}
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00010030 File Offset: 0x0000E230
		public unsafe readonly double GetAbsMax()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetAbsMax(this);
			}
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00010048 File Offset: 0x0000E248
		public unsafe readonly double GetMin()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetMin(this);
			}
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00010060 File Offset: 0x0000E260
		public unsafe readonly double GetAbsMin()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetAbsMin(this);
			}
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00010078 File Offset: 0x0000E278
		public unsafe readonly FVectorDouble ComponentMin(in FVectorDouble b)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				fixed (FVectorDouble* ptr2 = &b)
				{
					return FVectorDouble.Internal_ComponentMin(this, b);
				}
			}
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00010094 File Offset: 0x0000E294
		public unsafe readonly FVectorDouble ComponentMax(in FVectorDouble b)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				fixed (FVectorDouble* ptr2 = &b)
				{
					return FVectorDouble.Internal_ComponentMax(this, b);
				}
			}
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x000100B0 File Offset: 0x0000E2B0
		public unsafe readonly FVectorDouble GetAbs()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetAbs(this);
			}
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x000100C8 File Offset: 0x0000E2C8
		public unsafe readonly double Size()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_Size(this);
			}
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x000100E0 File Offset: 0x0000E2E0
		public unsafe readonly double SizeSquared()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_SizeSquared(this);
			}
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x000100F8 File Offset: 0x0000E2F8
		public unsafe readonly double Size2D()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_Size2D(this);
			}
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x00010110 File Offset: 0x0000E310
		public unsafe readonly double SizeSquared2D()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_SizeSquared2D(this);
			}
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00010128 File Offset: 0x0000E328
		public unsafe readonly bool IsNearlyZero(double tolerance = 9.999999747378752E-05)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_IsNearlyZero(this, tolerance);
			}
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00010140 File Offset: 0x0000E340
		public unsafe readonly bool IsZero()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_IsZero(this);
			}
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x00010158 File Offset: 0x0000E358
		public unsafe readonly bool IsUnit()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_IsUnit(this);
			}
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x00010170 File Offset: 0x0000E370
		public unsafe readonly bool IsNormalized()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_IsNormalized(this);
			}
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00010188 File Offset: 0x0000E388
		public unsafe void Normalize(double tolerance = 9.99999993922529E-09)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				FVectorDouble.Internal_Normalize(ref this, tolerance);
			}
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x000101A4 File Offset: 0x0000E3A4
		public unsafe readonly FVectorDouble GetUnsafeNormal()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetUnsafeNormal(this);
			}
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x000101BC File Offset: 0x0000E3BC
		public unsafe readonly FVectorDouble GetSafeNormal(double tolerance = 9.99999993922529E-09)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetSafeNormal(this, tolerance);
			}
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x000101D4 File Offset: 0x0000E3D4
		public unsafe readonly FVectorDouble GetSafeNormal2D(double tolerance = 9.99999993922529E-09)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetSafeNormal2D(this, tolerance);
			}
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x000101EC File Offset: 0x0000E3EC
		public unsafe readonly void ToDirectionAndLength(out FVectorDouble outDirection, out double outLength)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				fixed (FVectorDouble* ptr2 = &outDirection)
				{
					fixed (double* ptr3 = &outLength)
					{
						FVectorDouble.Internal_ToDirectionAndLength(this, out outDirection, out outLength);
					}
				}
			}
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00010218 File Offset: 0x0000E418
		public unsafe readonly FVectorDouble GetSignVector()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetSignVector(this);
			}
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00010230 File Offset: 0x0000E430
		public unsafe readonly FVectorDouble Projection()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_Projection(this);
			}
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x00010248 File Offset: 0x0000E448
		public unsafe readonly FVectorDouble GetUnsafeNormal2D()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetUnsafeNormal2D(this);
			}
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00010260 File Offset: 0x0000E460
		public unsafe readonly FVectorDouble GridSnap(double gridSz)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GridSnap(this, gridSz);
			}
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00010278 File Offset: 0x0000E478
		public unsafe readonly FVectorDouble BoundToCube(double radius)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_BoundToCube(this, radius);
			}
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00010290 File Offset: 0x0000E490
		public unsafe readonly FVectorDouble BoundToBox(in FVectorDouble min, in FVectorDouble max)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				fixed (FVectorDouble* ptr2 = &min)
				{
					fixed (FVectorDouble* ptr3 = &max)
					{
						return FVectorDouble.Internal_BoundToBox(this, min, max);
					}
				}
			}
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x000102B4 File Offset: 0x0000E4B4
		public unsafe readonly FVectorDouble GetClampedToSize(double min, double max)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetClampedToSize(this, min, max);
			}
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x000102D0 File Offset: 0x0000E4D0
		public unsafe readonly FVectorDouble GetClampedToSize2D(double min, double max)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetClampedToSize2D(this, min, max);
			}
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x000102EC File Offset: 0x0000E4EC
		public unsafe readonly FVectorDouble GetClampedToMaxSize(double maxSize)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetClampedToMaxSize(this, maxSize);
			}
		}

		// Token: 0x06000875 RID: 2165 RVA: 0x00010304 File Offset: 0x0000E504
		public unsafe readonly FVectorDouble GetClampedToMaxSize2D(double maxSize)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetClampedToMaxSize2D(this, maxSize);
			}
		}

		// Token: 0x06000876 RID: 2166 RVA: 0x0001031C File Offset: 0x0000E51C
		public unsafe void AddBounded(in FVectorDouble v, double radius = 32767.0)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				fixed (FVectorDouble* ptr2 = &v)
				{
					FVectorDouble.Internal_AddBounded(ref this, v, radius);
				}
			}
		}

		// Token: 0x06000877 RID: 2167 RVA: 0x00010340 File Offset: 0x0000E540
		public unsafe readonly FVectorDouble Reciprocal()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_Reciprocal(this);
			}
		}

		// Token: 0x06000878 RID: 2168 RVA: 0x00010358 File Offset: 0x0000E558
		public unsafe readonly bool IsUniform(double tolerance = 9.999999747378752E-05)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_IsUniform(this, tolerance);
			}
		}

		// Token: 0x06000879 RID: 2169 RVA: 0x00010370 File Offset: 0x0000E570
		public unsafe readonly FVectorDouble MirrorByVector(in FVectorDouble mirrorNormal)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				fixed (FVectorDouble* ptr2 = &mirrorNormal)
				{
					return FVectorDouble.Internal_MirrorByVector(this, mirrorNormal);
				}
			}
		}

		// Token: 0x0600087A RID: 2170 RVA: 0x0001038C File Offset: 0x0000E58C
		public unsafe readonly FVectorDouble MirrorByPlane(in FPlane plane)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				fixed (FPlane* ptr2 = &plane)
				{
					return FVectorDouble.Internal_MirrorByPlane(this, plane);
				}
			}
		}

		// Token: 0x0600087B RID: 2171 RVA: 0x000103A8 File Offset: 0x0000E5A8
		public unsafe readonly FVectorDouble RotateAngleAxis(double angleDeg, in FVectorDouble axis)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				fixed (FVectorDouble* ptr2 = &axis)
				{
					return FVectorDouble.Internal_RotateAngleAxis(this, angleDeg, axis);
				}
			}
		}

		// Token: 0x0600087C RID: 2172 RVA: 0x000103C8 File Offset: 0x0000E5C8
		public unsafe readonly double CosineAngle2D(in FVectorDouble b)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				fixed (FVectorDouble* ptr2 = &b)
				{
					return FVectorDouble.Internal_CosineAngle2D(this, b);
				}
			}
		}

		// Token: 0x0600087D RID: 2173 RVA: 0x000103E4 File Offset: 0x0000E5E4
		public unsafe readonly FVectorDouble ProjectOnTo(in FVectorDouble b)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				fixed (FVectorDouble* ptr2 = &b)
				{
					return FVectorDouble.Internal_ProjectOnTo(this, b);
				}
			}
		}

		// Token: 0x0600087E RID: 2174 RVA: 0x00010400 File Offset: 0x0000E600
		public unsafe readonly FVectorDouble ProjectOnToNormal(in FVectorDouble normal)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				fixed (FVectorDouble* ptr2 = &normal)
				{
					return FVectorDouble.Internal_ProjectOnToNormal(this, normal);
				}
			}
		}

		// Token: 0x0600087F RID: 2175 RVA: 0x0001041C File Offset: 0x0000E61C
		public unsafe readonly FRotator ToOrientationRotator()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_ToOrientationRotator(this);
			}
		}

		// Token: 0x06000880 RID: 2176 RVA: 0x00010434 File Offset: 0x0000E634
		public unsafe readonly FQuat ToOrientationQuat()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_ToOrientationQuat(this);
			}
		}

		// Token: 0x06000881 RID: 2177 RVA: 0x0001044C File Offset: 0x0000E64C
		public unsafe readonly FVector ToLocalVector(in FIntVector offset)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				fixed (FIntVector* ptr2 = &offset)
				{
					return FVectorDouble.Internal_ToLocalVector(this, offset);
				}
			}
		}

		// Token: 0x06000882 RID: 2178 RVA: 0x00010468 File Offset: 0x0000E668
		public unsafe readonly FRotator Rotation()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_Rotation(this);
			}
		}

		// Token: 0x06000883 RID: 2179 RVA: 0x00010480 File Offset: 0x0000E680
		public unsafe readonly void FindBestAxisVectors(out FVectorDouble outAxis1, out FVectorDouble outAxis2)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				fixed (FVectorDouble* ptr2 = &outAxis1)
				{
					fixed (FVectorDouble* ptr3 = &outAxis2)
					{
						FVectorDouble.Internal_FindBestAxisVectors(this, out outAxis1, out outAxis2);
					}
				}
			}
		}

		// Token: 0x06000884 RID: 2180 RVA: 0x000104AC File Offset: 0x0000E6AC
		public unsafe void UnwindEuler()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				FVectorDouble.Internal_UnwindEuler(ref this);
			}
		}

		// Token: 0x06000885 RID: 2181 RVA: 0x000104C8 File Offset: 0x0000E6C8
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x06000886 RID: 2182 RVA: 0x000104E0 File Offset: 0x0000E6E0
		public unsafe readonly FVector2D UnitCartesianToSpherical()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_UnitCartesianToSpherical(this);
			}
		}

		// Token: 0x06000887 RID: 2183 RVA: 0x000104F8 File Offset: 0x0000E6F8
		public unsafe readonly double HeadingAngle()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_HeadingAngle(this);
			}
		}

		// Token: 0x06000888 RID: 2184 RVA: 0x00010510 File Offset: 0x0000E710
		[NullableContext(2)]
		public unsafe void InitFromString(string str)
		{
			if (str == null || str.Length == 0)
			{
				this.X = (this.Y = (this.Z = 0.0));
				return;
			}
			fixed (FVectorDouble* ptr = &this)
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
				FVectorDouble.Internal_InitFromString(ref this, fcsharpStringView);
				char* ptr3 = null;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000889 RID: 2185 RVA: 0x0001057B File Offset: 0x0000E77B
		// (set) Token: 0x0600088A RID: 2186 RVA: 0x00010583 File Offset: 0x0000E783
		double IVector2D.X
		{
			get
			{
				return this.X;
			}
			set
			{
				this.X = (double)((float)value);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600088B RID: 2187 RVA: 0x0001058E File Offset: 0x0000E78E
		// (set) Token: 0x0600088C RID: 2188 RVA: 0x00010596 File Offset: 0x0000E796
		double IVector2D.Y
		{
			get
			{
				return this.Y;
			}
			set
			{
				this.Y = (double)((float)value);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x0600088D RID: 2189 RVA: 0x000105A1 File Offset: 0x0000E7A1
		// (set) Token: 0x0600088E RID: 2190 RVA: 0x000105A9 File Offset: 0x0000E7A9
		double IVector.Z
		{
			get
			{
				return this.Z;
			}
			set
			{
				this.Z = (double)((float)value);
			}
		}

		// Token: 0x0600088F RID: 2191 RVA: 0x000105B4 File Offset: 0x0000E7B4
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVectorDouble._ScriptStructPtr != 0) ? FVectorDouble._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.VectorDouble", ref FVectorDouble._ScriptStructPtr);
		}

		// Token: 0x04000130 RID: 304
		public static readonly FVectorDouble ZeroVector = new FVectorDouble(0.0, 0.0, 0.0);

		// Token: 0x04000131 RID: 305
		public static readonly FVectorDouble OneVector = new FVectorDouble(1.0, 1.0, 1.0);

		// Token: 0x04000132 RID: 306
		public static readonly FVectorDouble UpVector = new FVectorDouble(0.0, 0.0, 1.0);

		// Token: 0x04000133 RID: 307
		public static readonly FVectorDouble DownVector = new FVectorDouble(0.0, 0.0, -1.0);

		// Token: 0x04000134 RID: 308
		public static readonly FVectorDouble ForwardVector = new FVectorDouble(1.0, 0.0, 0.0);

		// Token: 0x04000135 RID: 309
		public static readonly FVectorDouble BackwardVector = new FVectorDouble(-1.0, 0.0, 0.0);

		// Token: 0x04000136 RID: 310
		public static readonly FVectorDouble RightVector = new FVectorDouble(0.0, 1.0, 0.0);

		// Token: 0x04000137 RID: 311
		public static readonly FVectorDouble LeftVector = new FVectorDouble(0.0, -1.0, 0.0);

		// Token: 0x04000138 RID: 312
		public static readonly FVectorDouble XAxisVector = new FVectorDouble(1.0, 0.0, 0.0);

		// Token: 0x04000139 RID: 313
		public static readonly FVectorDouble YAxisVector = new FVectorDouble(0.0, 1.0, 0.0);

		// Token: 0x0400013A RID: 314
		public static readonly FVectorDouble ZAxisVector = new FVectorDouble(0.0, 0.0, 1.0);

		// Token: 0x0400013B RID: 315
		[FieldOffset(0)]
		public double X;

		// Token: 0x0400013C RID: 316
		[FieldOffset(8)]
		public double Y;

		// Token: 0x0400013D RID: 317
		[FieldOffset(16)]
		public double Z;

		// Token: 0x0400013E RID: 318
		public const string __ObjectPath = "/Script/CoreUObject.VectorDouble";

		// Token: 0x0400013F RID: 319
		private static IntPtr _ScriptStructPtr;
	}
}
