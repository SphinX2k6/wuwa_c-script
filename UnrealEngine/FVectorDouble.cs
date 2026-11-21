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
	// Token: 0x02000029 RID: 41
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(24, 8, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 24)]
	[UnrealObjectPath("/Script/CoreUObject.VectorDouble")]
	[StructLayout(LayoutKind.Explicit, Pack = 8, Size = 24)]
	public struct FVectorDouble : IEquatable<FVectorDouble>, IEqualityOperators<FVectorDouble, FVectorDouble, bool>, IVector, IVector2D, IUnrealScriptStruct
	{
		// Token: 0x0600073B RID: 1851 RVA: 0x0000C00D File Offset: 0x0000A20D
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

		// Token: 0x0600073C RID: 1852 RVA: 0x0000C043 File Offset: 0x0000A243
		public FVectorDouble()
		{
			this.X = 0.0;
			this.Y = 0.0;
			this.Z = 0.0;
		}

		// Token: 0x0600073D RID: 1853 RVA: 0x0000C072 File Offset: 0x0000A272
		public FVectorDouble(double inF)
		{
			this = new FVectorDouble(inF, inF, inF);
		}

		// Token: 0x0600073E RID: 1854 RVA: 0x0000C07D File Offset: 0x0000A27D
		public FVectorDouble(in FVector2D v, double inZ)
		{
			this = new FVectorDouble((double)v.X, (double)v.Y, inZ);
		}

		// Token: 0x0600073F RID: 1855 RVA: 0x0000C094 File Offset: 0x0000A294
		public FVectorDouble(in FVector v)
		{
			this = new FVectorDouble((double)v.X, (double)v.Y, (double)v.Z);
		}

		// Token: 0x06000740 RID: 1856 RVA: 0x0000C0B1 File Offset: 0x0000A2B1
		public FVectorDouble(in FLinearColor c)
		{
			this = new FVectorDouble((double)c.R, (double)c.G, (double)c.B);
		}

		// Token: 0x06000741 RID: 1857 RVA: 0x0000C0CE File Offset: 0x0000A2CE
		public FVectorDouble(in FIntPoint a)
		{
			this = new FVectorDouble((double)a.X, (double)a.Y, 0.0);
		}

		// Token: 0x06000742 RID: 1858 RVA: 0x0000C0ED File Offset: 0x0000A2ED
		public FVectorDouble(in FIntVector a)
		{
			this = new FVectorDouble((double)a.X, (double)a.Y, 0.0);
		}

		// Token: 0x06000743 RID: 1859 RVA: 0x0000C10C File Offset: 0x0000A30C
		public FVectorDouble(in FVector v, FIntVector offset)
		{
			this = new FVectorDouble((double)(v.X + (float)offset.X), (double)(v.Y + (float)offset.Y), (double)(v.Z + (float)offset.Z));
		}

		// Token: 0x06000744 RID: 1860 RVA: 0x0000C141 File Offset: 0x0000A341
		public static implicit operator FVector(in FVectorDouble a)
		{
			return new FVector((float)a.X, (float)a.Y, (float)a.Z);
		}

		// Token: 0x06000745 RID: 1861 RVA: 0x0000C15D File Offset: 0x0000A35D
		public static implicit operator FVectorDouble(in FVector a)
		{
			return new FVectorDouble((double)a.X, (double)a.Y, (double)a.Z);
		}

		// Token: 0x06000746 RID: 1862 RVA: 0x0000C179 File Offset: 0x0000A379
		public static FVectorDouble operator -(in FVectorDouble v)
		{
			return new FVectorDouble(-v.X, -v.Y, -v.Z);
		}

		// Token: 0x06000747 RID: 1863 RVA: 0x0000C195 File Offset: 0x0000A395
		public static FVectorDouble operator *(double scale, in FVectorDouble v)
		{
			return v * scale;
		}

		// Token: 0x06000748 RID: 1864 RVA: 0x0000C19E File Offset: 0x0000A39E
		public static bool operator ==(FVectorDouble a, FVectorDouble b)
		{
			return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
		}

		// Token: 0x06000749 RID: 1865 RVA: 0x0000C1CC File Offset: 0x0000A3CC
		public static bool operator !=(FVectorDouble a, FVectorDouble b)
		{
			return a.X != b.X || a.Y != b.Y || a.Z != b.Z;
		}

		// Token: 0x0600074A RID: 1866 RVA: 0x0000C1FD File Offset: 0x0000A3FD
		public readonly bool Equals(FVectorDouble other)
		{
			return this == other;
		}

		// Token: 0x0600074B RID: 1867 RVA: 0x0000C20C File Offset: 0x0000A40C
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

		// Token: 0x0600074C RID: 1868 RVA: 0x0000C236 File Offset: 0x0000A436
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<double, double, double>(this.X, this.Y, this.Z);
		}

		// Token: 0x1700001F RID: 31
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

		// Token: 0x0600074F RID: 1871 RVA: 0x0000C2C6 File Offset: 0x0000A4C6
		public readonly double Component(int index)
		{
			return this[index];
		}

		// Token: 0x06000750 RID: 1872 RVA: 0x0000C2CF File Offset: 0x0000A4CF
		public readonly FVector ToVector()
		{
			return new FVector((float)this.X, (float)this.Y, (float)this.Z);
		}

		// Token: 0x06000751 RID: 1873 RVA: 0x0000C2EC File Offset: 0x0000A4EC
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

		// Token: 0x06000752 RID: 1874
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_Ctor(double x, double y, double z);

		// Token: 0x06000753 RID: 1875
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_Add(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x06000754 RID: 1876
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_AddFIntVector(in FVectorDouble a, in FIntVector b);

		// Token: 0x06000755 RID: 1877
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_AddDouble(in FVectorDouble a, double bias);

		// Token: 0x06000756 RID: 1878
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_Sub(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x06000757 RID: 1879
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_SubFIntVector(in FVectorDouble a, in FIntVector b);

		// Token: 0x06000758 RID: 1880
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_SubDouble(in FVectorDouble a, double bias);

		// Token: 0x06000759 RID: 1881
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_Mul(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x0600075A RID: 1882
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_MulDouble(in FVectorDouble a, double scale);

		// Token: 0x0600075B RID: 1883
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_Div(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x0600075C RID: 1884
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_DivDouble(in FVectorDouble a, double scale);

		// Token: 0x0600075D RID: 1885
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_Or(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x0600075E RID: 1886
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_Xor(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x0600075F RID: 1887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_DotProduct(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x06000760 RID: 1888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_CrossProduct(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x06000761 RID: 1889
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateOrthonormalBasis(ref FVectorDouble a, ref FVectorDouble b, ref FVectorDouble c);

		// Token: 0x06000762 RID: 1890
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_PointsAreSame(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x06000763 RID: 1891
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_PointsAreNear(in FVectorDouble a, in FVectorDouble b, double dist);

		// Token: 0x06000764 RID: 1892
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_PointPlaneDist(in FVectorDouble point, in FVectorDouble planeBase, in FVectorDouble planeNormal);

		// Token: 0x06000765 RID: 1893
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_PointPlaneProject_Plane(in FVectorDouble point, in FPlane plane);

		// Token: 0x06000766 RID: 1894
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_PointPlaneProject_abc(in FVectorDouble point, in FVectorDouble a, in FVectorDouble b, in FVectorDouble c);

		// Token: 0x06000767 RID: 1895
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_PointPlaneProject_base_normal(in FVectorDouble point, in FVectorDouble planeBase, in FVectorDouble planeNormal);

		// Token: 0x06000768 RID: 1896
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_VectorPlaneProject(in FVectorDouble v, in FVectorDouble planeNormal);

		// Token: 0x06000769 RID: 1897
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_Dist(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x0600076A RID: 1898
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_Distance(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x0600076B RID: 1899
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_DistXY(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x0600076C RID: 1900
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_Dist2D(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x0600076D RID: 1901
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_DistSquared(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x0600076E RID: 1902
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_DistSquaredXY(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x0600076F RID: 1903
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_DistSquared2D(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x06000770 RID: 1904
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_BoxPushOut(in FVectorDouble normal, in FVectorDouble size);

		// Token: 0x06000771 RID: 1905
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Parallel(in FVectorDouble normal1, in FVectorDouble normal2, double parallelCosineThreshold = 0.999845027923584);

		// Token: 0x06000772 RID: 1906
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Coincident(in FVectorDouble normal1, in FVectorDouble normal2, double parallelCosineThreshold = 0.999845027923584);

		// Token: 0x06000773 RID: 1907
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Orthogonal(in FVectorDouble normal1, in FVectorDouble normal2, double parallelCosineThreshold = 0.999845027923584);

		// Token: 0x06000774 RID: 1908
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Coplanar(in FVectorDouble base1, in FVectorDouble normal1, in FVectorDouble base2, in FVectorDouble normal2, double parallelCosineThreshold = 0.999845027923584);

		// Token: 0x06000775 RID: 1909
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_Triple(in FVectorDouble x, in FVectorDouble y, in FVectorDouble z);

		// Token: 0x06000776 RID: 1910
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_RadiansToDegrees(in FVectorDouble radVector);

		// Token: 0x06000777 RID: 1911
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_DegreesToRadians(in FVectorDouble degVector);

		// Token: 0x06000778 RID: 1912
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_ComputeSquaredDistanceFromBoxToPoint(in FVectorDouble mins, in FVectorDouble maxs, in FVectorDouble point);

		// Token: 0x06000779 RID: 1913
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_ClampVector(in FVectorDouble v, in FVectorDouble min, in FVectorDouble max);

		// Token: 0x0600077A RID: 1914
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FVectorDouble a, in FVectorDouble b, double tolerance = 9.999999747378752E-05);

		// Token: 0x0600077B RID: 1915
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_AllComponentsEqual(in FVectorDouble a, double tolerance = 9.999999747378752E-05);

		// Token: 0x0600077C RID: 1916
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_GetComponentForAxis(in FVectorDouble a, EAxis axis);

		// Token: 0x0600077D RID: 1917
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetComponentForAxis(ref FVectorDouble a, EAxis axis, double component);

		// Token: 0x0600077E RID: 1918
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Set(ref FVectorDouble a, double x, double y, double z);

		// Token: 0x0600077F RID: 1919
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_GetMax(in FVectorDouble a);

		// Token: 0x06000780 RID: 1920
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_GetAbsMax(in FVectorDouble a);

		// Token: 0x06000781 RID: 1921
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_GetMin(in FVectorDouble a);

		// Token: 0x06000782 RID: 1922
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_GetAbsMin(in FVectorDouble a);

		// Token: 0x06000783 RID: 1923
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_ComponentMin(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x06000784 RID: 1924
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_ComponentMax(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x06000785 RID: 1925
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetAbs(in FVectorDouble a);

		// Token: 0x06000786 RID: 1926
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_Size(in FVectorDouble a);

		// Token: 0x06000787 RID: 1927
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_SizeSquared(in FVectorDouble a);

		// Token: 0x06000788 RID: 1928
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_Size2D(in FVectorDouble a);

		// Token: 0x06000789 RID: 1929
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_SizeSquared2D(in FVectorDouble a);

		// Token: 0x0600078A RID: 1930
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsNearlyZero(in FVectorDouble a, double tolerance = 9.999999747378752E-05);

		// Token: 0x0600078B RID: 1931
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsZero(in FVectorDouble a);

		// Token: 0x0600078C RID: 1932
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsUnit(in FVectorDouble a);

		// Token: 0x0600078D RID: 1933
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsNormalized(in FVectorDouble a);

		// Token: 0x0600078E RID: 1934
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Normalize(ref FVectorDouble a, double tolerance = 9.99999993922529E-09);

		// Token: 0x0600078F RID: 1935
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetUnsafeNormal(in FVectorDouble a);

		// Token: 0x06000790 RID: 1936
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetSafeNormal(in FVectorDouble a, double tolerance = 9.99999993922529E-09);

		// Token: 0x06000791 RID: 1937
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetSafeNormal2D(in FVectorDouble a, double tolerance = 9.99999993922529E-09);

		// Token: 0x06000792 RID: 1938
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ToDirectionAndLength(in FVectorDouble a, out FVectorDouble outDirection, out double outLength);

		// Token: 0x06000793 RID: 1939
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetSignVector(in FVectorDouble a);

		// Token: 0x06000794 RID: 1940
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_Projection(in FVectorDouble a);

		// Token: 0x06000795 RID: 1941
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetUnsafeNormal2D(in FVectorDouble a);

		// Token: 0x06000796 RID: 1942
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GridSnap(in FVectorDouble a, double gridSz);

		// Token: 0x06000797 RID: 1943
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_BoundToCube(in FVectorDouble a, double radius);

		// Token: 0x06000798 RID: 1944
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_BoundToBox(in FVectorDouble a, in FVectorDouble min, in FVectorDouble max);

		// Token: 0x06000799 RID: 1945
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetClampedToSize(in FVectorDouble a, double min, double max);

		// Token: 0x0600079A RID: 1946
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetClampedToSize2D(in FVectorDouble a, double min, double max);

		// Token: 0x0600079B RID: 1947
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetClampedToMaxSize(in FVectorDouble a, double maxSize);

		// Token: 0x0600079C RID: 1948
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_GetClampedToMaxSize2D(in FVectorDouble a, double maxSize);

		// Token: 0x0600079D RID: 1949
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_AddBounded(ref FVectorDouble a, in FVectorDouble v, double radius = 32767.0);

		// Token: 0x0600079E RID: 1950
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_Reciprocal(in FVectorDouble a);

		// Token: 0x0600079F RID: 1951
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsUniform(in FVectorDouble a, double tolerance = 9.999999747378752E-05);

		// Token: 0x060007A0 RID: 1952
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_MirrorByVector(in FVectorDouble a, in FVectorDouble mirrorNormal);

		// Token: 0x060007A1 RID: 1953
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_MirrorByPlane(in FVectorDouble a, in FPlane plane);

		// Token: 0x060007A2 RID: 1954
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_RotateAngleAxis(in FVectorDouble a, double angleDeg, in FVectorDouble axis);

		// Token: 0x060007A3 RID: 1955
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_CosineAngle2D(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x060007A4 RID: 1956
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_ProjectOnTo(in FVectorDouble a, in FVectorDouble b);

		// Token: 0x060007A5 RID: 1957
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble Internal_ProjectOnToNormal(in FVectorDouble a, in FVectorDouble normal);

		// Token: 0x060007A6 RID: 1958
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_ToOrientationRotator(in FVectorDouble a);

		// Token: 0x060007A7 RID: 1959
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_ToOrientationQuat(in FVectorDouble a);

		// Token: 0x060007A8 RID: 1960
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_ToLocalVector(in FVectorDouble a, in FIntVector offset);

		// Token: 0x060007A9 RID: 1961
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_Rotation(in FVectorDouble a);

		// Token: 0x060007AA RID: 1962
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_FindBestAxisVectors(in FVectorDouble a, out FVectorDouble outAxis1, out FVectorDouble outAxis2);

		// Token: 0x060007AB RID: 1963
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_UnwindEuler(ref FVectorDouble a);

		// Token: 0x060007AC RID: 1964
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FVectorDouble a);

		// Token: 0x060007AD RID: 1965
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_UnitCartesianToSpherical(in FVectorDouble a);

		// Token: 0x060007AE RID: 1966
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern double Internal_HeadingAngle(in FVectorDouble a);

		// Token: 0x060007AF RID: 1967
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_InitFromString(ref FVectorDouble a, in FCSharpStringView str);

		// Token: 0x060007B0 RID: 1968 RVA: 0x0000C354 File Offset: 0x0000A554
		public FVectorDouble(double inX, double inY, double inZ)
		{
			this.X = inX;
			this.Y = inY;
			this.Z = inZ;
		}

		// Token: 0x060007B1 RID: 1969 RVA: 0x0000C36C File Offset: 0x0000A56C
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

		// Token: 0x060007B2 RID: 1970 RVA: 0x0000C388 File Offset: 0x0000A588
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

		// Token: 0x060007B3 RID: 1971 RVA: 0x0000C3A4 File Offset: 0x0000A5A4
		public unsafe static FVectorDouble operator +(in FVectorDouble a, double bias)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				return FVectorDouble.Internal_AddDouble(a, bias);
			}
		}

		// Token: 0x060007B4 RID: 1972 RVA: 0x0000C3BC File Offset: 0x0000A5BC
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

		// Token: 0x060007B5 RID: 1973 RVA: 0x0000C3D8 File Offset: 0x0000A5D8
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

		// Token: 0x060007B6 RID: 1974 RVA: 0x0000C3F4 File Offset: 0x0000A5F4
		public unsafe static FVectorDouble operator -(in FVectorDouble a, double bias)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				return FVectorDouble.Internal_SubDouble(a, bias);
			}
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x0000C40C File Offset: 0x0000A60C
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

		// Token: 0x060007B8 RID: 1976 RVA: 0x0000C428 File Offset: 0x0000A628
		public unsafe static FVectorDouble operator *(in FVectorDouble a, double scale)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				return FVectorDouble.Internal_MulDouble(a, scale);
			}
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x0000C440 File Offset: 0x0000A640
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

		// Token: 0x060007BA RID: 1978 RVA: 0x0000C45C File Offset: 0x0000A65C
		public unsafe static FVectorDouble operator /(in FVectorDouble a, double scale)
		{
			fixed (FVectorDouble* ptr = &a)
			{
				return FVectorDouble.Internal_DivDouble(a, scale);
			}
		}

		// Token: 0x060007BB RID: 1979 RVA: 0x0000C474 File Offset: 0x0000A674
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

		// Token: 0x060007BC RID: 1980 RVA: 0x0000C490 File Offset: 0x0000A690
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

		// Token: 0x060007BD RID: 1981 RVA: 0x0000C4AC File Offset: 0x0000A6AC
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

		// Token: 0x060007BE RID: 1982 RVA: 0x0000C4C8 File Offset: 0x0000A6C8
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

		// Token: 0x060007BF RID: 1983 RVA: 0x0000C4E4 File Offset: 0x0000A6E4
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

		// Token: 0x060007C0 RID: 1984 RVA: 0x0000C510 File Offset: 0x0000A710
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

		// Token: 0x060007C1 RID: 1985 RVA: 0x0000C52C File Offset: 0x0000A72C
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

		// Token: 0x060007C2 RID: 1986 RVA: 0x0000C54C File Offset: 0x0000A74C
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

		// Token: 0x060007C3 RID: 1987 RVA: 0x0000C570 File Offset: 0x0000A770
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

		// Token: 0x060007C4 RID: 1988 RVA: 0x0000C58C File Offset: 0x0000A78C
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

		// Token: 0x060007C5 RID: 1989 RVA: 0x0000C5B4 File Offset: 0x0000A7B4
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

		// Token: 0x060007C6 RID: 1990 RVA: 0x0000C5D8 File Offset: 0x0000A7D8
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

		// Token: 0x060007C7 RID: 1991 RVA: 0x0000C5F4 File Offset: 0x0000A7F4
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

		// Token: 0x060007C8 RID: 1992 RVA: 0x0000C610 File Offset: 0x0000A810
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

		// Token: 0x060007C9 RID: 1993 RVA: 0x0000C62C File Offset: 0x0000A82C
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

		// Token: 0x060007CA RID: 1994 RVA: 0x0000C648 File Offset: 0x0000A848
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

		// Token: 0x060007CB RID: 1995 RVA: 0x0000C664 File Offset: 0x0000A864
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

		// Token: 0x060007CC RID: 1996 RVA: 0x0000C680 File Offset: 0x0000A880
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

		// Token: 0x060007CD RID: 1997 RVA: 0x0000C69C File Offset: 0x0000A89C
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

		// Token: 0x060007CE RID: 1998 RVA: 0x0000C6B8 File Offset: 0x0000A8B8
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

		// Token: 0x060007CF RID: 1999 RVA: 0x0000C6D4 File Offset: 0x0000A8D4
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

		// Token: 0x060007D0 RID: 2000 RVA: 0x0000C6F4 File Offset: 0x0000A8F4
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

		// Token: 0x060007D1 RID: 2001 RVA: 0x0000C714 File Offset: 0x0000A914
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

		// Token: 0x060007D2 RID: 2002 RVA: 0x0000C734 File Offset: 0x0000A934
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

		// Token: 0x060007D3 RID: 2003 RVA: 0x0000C75C File Offset: 0x0000A95C
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

		// Token: 0x060007D4 RID: 2004 RVA: 0x0000C780 File Offset: 0x0000A980
		public unsafe static FVectorDouble RadiansToDegrees(in FVectorDouble radVector)
		{
			fixed (FVectorDouble* ptr = &radVector)
			{
				return FVectorDouble.Internal_RadiansToDegrees(radVector);
			}
		}

		// Token: 0x060007D5 RID: 2005 RVA: 0x0000C798 File Offset: 0x0000A998
		public unsafe static FVectorDouble DegreesToRadians(in FVectorDouble degVector)
		{
			fixed (FVectorDouble* ptr = &degVector)
			{
				return FVectorDouble.Internal_DegreesToRadians(degVector);
			}
		}

		// Token: 0x060007D6 RID: 2006 RVA: 0x0000C7B0 File Offset: 0x0000A9B0
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

		// Token: 0x060007D7 RID: 2007 RVA: 0x0000C7D4 File Offset: 0x0000A9D4
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

		// Token: 0x060007D8 RID: 2008 RVA: 0x0000C7F8 File Offset: 0x0000A9F8
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

		// Token: 0x060007D9 RID: 2009 RVA: 0x0000C818 File Offset: 0x0000AA18
		public unsafe readonly bool AllComponentsEqual(double tolerance = 9.999999747378752E-05)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_AllComponentsEqual(this, tolerance);
			}
		}

		// Token: 0x060007DA RID: 2010 RVA: 0x0000C830 File Offset: 0x0000AA30
		public unsafe readonly double GetComponentForAxis(EAxis axis)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetComponentForAxis(this, axis);
			}
		}

		// Token: 0x060007DB RID: 2011 RVA: 0x0000C848 File Offset: 0x0000AA48
		public unsafe void SetComponentForAxis(EAxis axis, double component)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				FVectorDouble.Internal_SetComponentForAxis(ref this, axis, component);
			}
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x0000C864 File Offset: 0x0000AA64
		public unsafe void Set(double x, double y, double z)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				FVectorDouble.Internal_Set(ref this, x, y, z);
			}
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x0000C884 File Offset: 0x0000AA84
		public unsafe readonly double GetMax()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetMax(this);
			}
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0000C89C File Offset: 0x0000AA9C
		public unsafe readonly double GetAbsMax()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetAbsMax(this);
			}
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0000C8B4 File Offset: 0x0000AAB4
		public unsafe readonly double GetMin()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetMin(this);
			}
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0000C8CC File Offset: 0x0000AACC
		public unsafe readonly double GetAbsMin()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetAbsMin(this);
			}
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0000C8E4 File Offset: 0x0000AAE4
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

		// Token: 0x060007E2 RID: 2018 RVA: 0x0000C900 File Offset: 0x0000AB00
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

		// Token: 0x060007E3 RID: 2019 RVA: 0x0000C91C File Offset: 0x0000AB1C
		public unsafe readonly FVectorDouble GetAbs()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetAbs(this);
			}
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0000C934 File Offset: 0x0000AB34
		public unsafe readonly double Size()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_Size(this);
			}
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0000C94C File Offset: 0x0000AB4C
		public unsafe readonly double SizeSquared()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_SizeSquared(this);
			}
		}

		// Token: 0x060007E6 RID: 2022 RVA: 0x0000C964 File Offset: 0x0000AB64
		public unsafe readonly double Size2D()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_Size2D(this);
			}
		}

		// Token: 0x060007E7 RID: 2023 RVA: 0x0000C97C File Offset: 0x0000AB7C
		public unsafe readonly double SizeSquared2D()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_SizeSquared2D(this);
			}
		}

		// Token: 0x060007E8 RID: 2024 RVA: 0x0000C994 File Offset: 0x0000AB94
		public unsafe readonly bool IsNearlyZero(double tolerance = 9.999999747378752E-05)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_IsNearlyZero(this, tolerance);
			}
		}

		// Token: 0x060007E9 RID: 2025 RVA: 0x0000C9AC File Offset: 0x0000ABAC
		public unsafe readonly bool IsZero()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_IsZero(this);
			}
		}

		// Token: 0x060007EA RID: 2026 RVA: 0x0000C9C4 File Offset: 0x0000ABC4
		public unsafe readonly bool IsUnit()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_IsUnit(this);
			}
		}

		// Token: 0x060007EB RID: 2027 RVA: 0x0000C9DC File Offset: 0x0000ABDC
		public unsafe readonly bool IsNormalized()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_IsNormalized(this);
			}
		}

		// Token: 0x060007EC RID: 2028 RVA: 0x0000C9F4 File Offset: 0x0000ABF4
		public unsafe void Normalize(double tolerance = 9.99999993922529E-09)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				FVectorDouble.Internal_Normalize(ref this, tolerance);
			}
		}

		// Token: 0x060007ED RID: 2029 RVA: 0x0000CA10 File Offset: 0x0000AC10
		public unsafe readonly FVectorDouble GetUnsafeNormal()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetUnsafeNormal(this);
			}
		}

		// Token: 0x060007EE RID: 2030 RVA: 0x0000CA28 File Offset: 0x0000AC28
		public unsafe readonly FVectorDouble GetSafeNormal(double tolerance = 9.99999993922529E-09)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetSafeNormal(this, tolerance);
			}
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x0000CA40 File Offset: 0x0000AC40
		public unsafe readonly FVectorDouble GetSafeNormal2D(double tolerance = 9.99999993922529E-09)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetSafeNormal2D(this, tolerance);
			}
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x0000CA58 File Offset: 0x0000AC58
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

		// Token: 0x060007F1 RID: 2033 RVA: 0x0000CA84 File Offset: 0x0000AC84
		public unsafe readonly FVectorDouble GetSignVector()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetSignVector(this);
			}
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x0000CA9C File Offset: 0x0000AC9C
		public unsafe readonly FVectorDouble Projection()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_Projection(this);
			}
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x0000CAB4 File Offset: 0x0000ACB4
		public unsafe readonly FVectorDouble GetUnsafeNormal2D()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetUnsafeNormal2D(this);
			}
		}

		// Token: 0x060007F4 RID: 2036 RVA: 0x0000CACC File Offset: 0x0000ACCC
		public unsafe readonly FVectorDouble GridSnap(double gridSz)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GridSnap(this, gridSz);
			}
		}

		// Token: 0x060007F5 RID: 2037 RVA: 0x0000CAE4 File Offset: 0x0000ACE4
		public unsafe readonly FVectorDouble BoundToCube(double radius)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_BoundToCube(this, radius);
			}
		}

		// Token: 0x060007F6 RID: 2038 RVA: 0x0000CAFC File Offset: 0x0000ACFC
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

		// Token: 0x060007F7 RID: 2039 RVA: 0x0000CB20 File Offset: 0x0000AD20
		public unsafe readonly FVectorDouble GetClampedToSize(double min, double max)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetClampedToSize(this, min, max);
			}
		}

		// Token: 0x060007F8 RID: 2040 RVA: 0x0000CB3C File Offset: 0x0000AD3C
		public unsafe readonly FVectorDouble GetClampedToSize2D(double min, double max)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetClampedToSize2D(this, min, max);
			}
		}

		// Token: 0x060007F9 RID: 2041 RVA: 0x0000CB58 File Offset: 0x0000AD58
		public unsafe readonly FVectorDouble GetClampedToMaxSize(double maxSize)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetClampedToMaxSize(this, maxSize);
			}
		}

		// Token: 0x060007FA RID: 2042 RVA: 0x0000CB70 File Offset: 0x0000AD70
		public unsafe readonly FVectorDouble GetClampedToMaxSize2D(double maxSize)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_GetClampedToMaxSize2D(this, maxSize);
			}
		}

		// Token: 0x060007FB RID: 2043 RVA: 0x0000CB88 File Offset: 0x0000AD88
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

		// Token: 0x060007FC RID: 2044 RVA: 0x0000CBAC File Offset: 0x0000ADAC
		public unsafe readonly FVectorDouble Reciprocal()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_Reciprocal(this);
			}
		}

		// Token: 0x060007FD RID: 2045 RVA: 0x0000CBC4 File Offset: 0x0000ADC4
		public unsafe readonly bool IsUniform(double tolerance = 9.999999747378752E-05)
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_IsUniform(this, tolerance);
			}
		}

		// Token: 0x060007FE RID: 2046 RVA: 0x0000CBDC File Offset: 0x0000ADDC
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

		// Token: 0x060007FF RID: 2047 RVA: 0x0000CBF8 File Offset: 0x0000ADF8
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

		// Token: 0x06000800 RID: 2048 RVA: 0x0000CC14 File Offset: 0x0000AE14
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

		// Token: 0x06000801 RID: 2049 RVA: 0x0000CC34 File Offset: 0x0000AE34
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

		// Token: 0x06000802 RID: 2050 RVA: 0x0000CC50 File Offset: 0x0000AE50
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

		// Token: 0x06000803 RID: 2051 RVA: 0x0000CC6C File Offset: 0x0000AE6C
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

		// Token: 0x06000804 RID: 2052 RVA: 0x0000CC88 File Offset: 0x0000AE88
		public unsafe readonly FRotator ToOrientationRotator()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_ToOrientationRotator(this);
			}
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x0000CCA0 File Offset: 0x0000AEA0
		public unsafe readonly FQuat ToOrientationQuat()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_ToOrientationQuat(this);
			}
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x0000CCB8 File Offset: 0x0000AEB8
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

		// Token: 0x06000807 RID: 2055 RVA: 0x0000CCD4 File Offset: 0x0000AED4
		public unsafe readonly FRotator Rotation()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_Rotation(this);
			}
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x0000CCEC File Offset: 0x0000AEEC
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

		// Token: 0x06000809 RID: 2057 RVA: 0x0000CD18 File Offset: 0x0000AF18
		public unsafe void UnwindEuler()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				FVectorDouble.Internal_UnwindEuler(ref this);
			}
		}

		// Token: 0x0600080A RID: 2058 RVA: 0x0000CD34 File Offset: 0x0000AF34
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x0600080B RID: 2059 RVA: 0x0000CD4C File Offset: 0x0000AF4C
		public unsafe readonly FVector2D UnitCartesianToSpherical()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_UnitCartesianToSpherical(this);
			}
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x0000CD64 File Offset: 0x0000AF64
		public unsafe readonly double HeadingAngle()
		{
			fixed (FVectorDouble* ptr = &this)
			{
				return FVectorDouble.Internal_HeadingAngle(this);
			}
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x0000CD7C File Offset: 0x0000AF7C
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

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600080E RID: 2062 RVA: 0x0000CDE7 File Offset: 0x0000AFE7
		// (set) Token: 0x0600080F RID: 2063 RVA: 0x0000CDEF File Offset: 0x0000AFEF
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

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000810 RID: 2064 RVA: 0x0000CDFA File Offset: 0x0000AFFA
		// (set) Token: 0x06000811 RID: 2065 RVA: 0x0000CE02 File Offset: 0x0000B002
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

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000812 RID: 2066 RVA: 0x0000CE0D File Offset: 0x0000B00D
		// (set) Token: 0x06000813 RID: 2067 RVA: 0x0000CE15 File Offset: 0x0000B015
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

		// Token: 0x06000814 RID: 2068 RVA: 0x0000CE20 File Offset: 0x0000B020
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVectorDouble._ScriptStructPtr != 0) ? FVectorDouble._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.VectorDouble", ref FVectorDouble._ScriptStructPtr);
		}

		// Token: 0x040000E9 RID: 233
		public static readonly FVectorDouble ZeroVector = new FVectorDouble(0.0, 0.0, 0.0);

		// Token: 0x040000EA RID: 234
		public static readonly FVectorDouble OneVector = new FVectorDouble(1.0, 1.0, 1.0);

		// Token: 0x040000EB RID: 235
		public static readonly FVectorDouble UpVector = new FVectorDouble(0.0, 0.0, 1.0);

		// Token: 0x040000EC RID: 236
		public static readonly FVectorDouble DownVector = new FVectorDouble(0.0, 0.0, -1.0);

		// Token: 0x040000ED RID: 237
		public static readonly FVectorDouble ForwardVector = new FVectorDouble(1.0, 0.0, 0.0);

		// Token: 0x040000EE RID: 238
		public static readonly FVectorDouble BackwardVector = new FVectorDouble(-1.0, 0.0, 0.0);

		// Token: 0x040000EF RID: 239
		public static readonly FVectorDouble RightVector = new FVectorDouble(0.0, 1.0, 0.0);

		// Token: 0x040000F0 RID: 240
		public static readonly FVectorDouble LeftVector = new FVectorDouble(0.0, -1.0, 0.0);

		// Token: 0x040000F1 RID: 241
		public static readonly FVectorDouble XAxisVector = new FVectorDouble(1.0, 0.0, 0.0);

		// Token: 0x040000F2 RID: 242
		public static readonly FVectorDouble YAxisVector = new FVectorDouble(0.0, 1.0, 0.0);

		// Token: 0x040000F3 RID: 243
		public static readonly FVectorDouble ZAxisVector = new FVectorDouble(0.0, 0.0, 1.0);

		// Token: 0x040000F4 RID: 244
		[FieldOffset(0)]
		public double X;

		// Token: 0x040000F5 RID: 245
		[FieldOffset(8)]
		public double Y;

		// Token: 0x040000F6 RID: 246
		[FieldOffset(16)]
		public double Z;

		// Token: 0x040000F7 RID: 247
		public const string __ObjectPath = "/Script/CoreUObject.VectorDouble";

		// Token: 0x040000F8 RID: 248
		private static IntPtr _ScriptStructPtr;
	}
}
