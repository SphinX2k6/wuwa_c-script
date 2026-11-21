using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x02000071 RID: 113
	[NullableContext(1)]
	[Nullable(0)]
	public static class FMath
	{
		// Token: 0x06000B20 RID: 2848 RVA: 0x00011F47 File Offset: 0x00010147
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GridSnap(float location, float grid)
		{
			if (grid != 0f)
			{
				return MathF.Floor((location + grid * 0.5f) / grid) * grid;
			}
			return location;
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x00011F65 File Offset: 0x00010165
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double GridSnap(double location, double grid)
		{
			if (grid != 0.0)
			{
				return Math.Floor((location + grid * 0.5) / grid) * grid;
			}
			return location;
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00011F8B File Offset: 0x0001018B
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static int RoundToInt(float F)
		{
			return (int)MathF.Floor(F + 0.5f);
		}

		// Token: 0x06000B23 RID: 2851 RVA: 0x00011F9A File Offset: 0x0001019A
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float RoundToFloat(float F)
		{
			return MathF.Floor(F + 0.5f);
		}

		// Token: 0x06000B24 RID: 2852 RVA: 0x00011FA8 File Offset: 0x000101A8
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float FloatSelect(float comparand, float valueGeZero, float valueLtZero)
		{
			if (comparand < 0f)
			{
				return valueLtZero;
			}
			return valueGeZero;
		}

		// Token: 0x06000B25 RID: 2853 RVA: 0x00011FB5 File Offset: 0x000101B5
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double FloatSelect(double comparand, double valueGeZero, double valueLtZero)
		{
			if (comparand < 0.0)
			{
				return valueLtZero;
			}
			return valueGeZero;
		}

		// Token: 0x06000B26 RID: 2854 RVA: 0x00011FC6 File Offset: 0x000101C6
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float DegreesToRadians(float degVal)
		{
			return degVal * 0.017453292f;
		}

		// Token: 0x06000B27 RID: 2855 RVA: 0x00011FCF File Offset: 0x000101CF
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double DegreesToRadians(double degVal)
		{
			return degVal * 0.017453293005625408;
		}

		// Token: 0x06000B28 RID: 2856 RVA: 0x00011FDC File Offset: 0x000101DC
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static T Lerp<[Nullable(0)] T>(T a, T b, float alpha) where T : IAdditionOperators<T, T, T>, ISubtractionOperators<T, T, T>, IMultiplyOperators<T, float, T>
		{
			return a + (b - a) * alpha;
		}

		// Token: 0x06000B29 RID: 2857 RVA: 0x00012003 File Offset: 0x00010203
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static T Lerp<[Nullable(0)] T>(T a, T b, double alpha) where T : IAdditionOperators<T, T, T>, ISubtractionOperators<T, T, T>, IMultiplyOperators<T, double, T>
		{
			return a + (b - a) * alpha;
		}

		// Token: 0x06000B2A RID: 2858 RVA: 0x0001202C File Offset: 0x0001022C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static FLinearColor Lerp(FLinearColor a, FLinearColor b, float alpha)
		{
			FLinearColor flinearColor = b - a;
			FLinearColor flinearColor2 = flinearColor * alpha;
			return a + flinearColor2;
		}

		// Token: 0x06000B2B RID: 2859 RVA: 0x00012058 File Offset: 0x00010258
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static FVector Lerp(FVector a, FVector b, float alpha)
		{
			FVector fvector = b - a;
			FVector fvector2 = fvector * alpha;
			return a + fvector2;
		}

		// Token: 0x06000B2C RID: 2860 RVA: 0x00012084 File Offset: 0x00010284
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static FVectorDouble Lerp(FVectorDouble a, FVectorDouble b, float alpha)
		{
			FVectorDouble fvectorDouble = b - a;
			FVectorDouble fvectorDouble2 = fvectorDouble * (double)alpha;
			return a + fvectorDouble2;
		}

		// Token: 0x06000B2D RID: 2861 RVA: 0x000120AE File Offset: 0x000102AE
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static T Square<[Nullable(0)] T>(T a) where T : IMultiplyOperators<T, T, T>
		{
			return a * a;
		}

		// Token: 0x06000B2E RID: 2862 RVA: 0x000120BD File Offset: 0x000102BD
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Max3(float a, float b, float c)
		{
			return Math.Max(Math.Max(a, b), c);
		}

		// Token: 0x06000B2F RID: 2863 RVA: 0x000120CC File Offset: 0x000102CC
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static double Max3(double a, double b, double c)
		{
			return Math.Max(Math.Max(a, b), c);
		}

		// Token: 0x06000B30 RID: 2864 RVA: 0x000120DC File Offset: 0x000102DC
		public static float ComputeSquaredDistanceFromBoxToPoint(FVector mins, FVector maxs, FVector point)
		{
			float num = 0f;
			if (point.X < mins.X)
			{
				num += (point.X - mins.X) * (point.X - mins.X);
			}
			else if (point.X > maxs.X)
			{
				num += (point.X - maxs.X) * (point.X - maxs.X);
			}
			if (point.Y < mins.Y)
			{
				num += (point.Y - mins.Y) * (point.Y - mins.Y);
			}
			else if (point.Y > maxs.Y)
			{
				num += (point.Y - maxs.Y) * (point.Y - maxs.Y);
			}
			if (point.Z < mins.Z)
			{
				num += (point.Z - mins.Z) * (point.Z - mins.Z);
			}
			else if (point.Z > maxs.Z)
			{
				num += (point.Z - maxs.Z) * (point.Z - maxs.Z);
			}
			return num;
		}

		// Token: 0x06000B31 RID: 2865 RVA: 0x000121FE File Offset: 0x000103FE
		public static float UnwindDegrees(float a)
		{
			while (a > 180f)
			{
				a -= 360f;
			}
			while (a < -180f)
			{
				a += 360f;
			}
			return a;
		}

		// Token: 0x06000B32 RID: 2866 RVA: 0x00012227 File Offset: 0x00010427
		public static float UnwindRadians(float a)
		{
			while (a > 3.1415927f)
			{
				a -= 6.2831855f;
			}
			while (a < -3.1415927f)
			{
				a += 6.2831855f;
			}
			return a;
		}

		// Token: 0x06000B33 RID: 2867 RVA: 0x00012250 File Offset: 0x00010450
		[NullableContext(0)]
		[return: TupleElementNames(new string[]
		{
			"scalarSin",
			"scalarCos"
		})]
		public static ValueTuple<float, float> SinCos(float value)
		{
			float num = 0.15915494f * value;
			if (value >= 0f)
			{
				num = (float)((int)(num + 0.5f));
			}
			else
			{
				num = (float)((int)(num - 0.5f));
			}
			float num2 = value - 6.2831855f * num;
			float num3;
			if (num2 > 1.5707964f)
			{
				num2 = 3.1415927f - num2;
				num3 = -1f;
			}
			else if (num2 < -1.5707964f)
			{
				num2 = -3.1415927f - num2;
				num3 = -1f;
			}
			else
			{
				num3 = 1f;
			}
			float num4 = num2 * num2;
			float item = (((((-2.3889859E-08f * num4 + 2.7525562E-06f) * num4 - 0.00019840874f) * num4 + 0.008333331f) * num4 - 0.16666667f) * num4 + 1f) * num2;
			float num5 = ((((-2.6051615E-07f * num4 + 2.4760495E-05f) * num4 - 0.0013888378f) * num4 + 0.041666638f) * num4 - 0.5f) * num4 + 1f;
			float item2 = num3 * num5;
			return new ValueTuple<float, float>(item, item2);
		}

		// Token: 0x06000B34 RID: 2868 RVA: 0x00012332 File Offset: 0x00010532
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static bool IsNearlyZero(float value, float errorTolerance = 1E-08f)
		{
			return Math.Abs(value) <= errorTolerance;
		}

		// Token: 0x06000B35 RID: 2869 RVA: 0x00012340 File Offset: 0x00010540
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static bool IsNearlyZero(double value, double errorTolerance = 9.99999993922529E-09)
		{
			return Math.Abs(value) <= errorTolerance;
		}

		// Token: 0x06000B36 RID: 2870 RVA: 0x0001234E File Offset: 0x0001054E
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static bool IsNearlyEqual(float a, float b, float errorTolerance = 1E-08f)
		{
			return Math.Abs(a - b) <= errorTolerance;
		}

		// Token: 0x06000B37 RID: 2871 RVA: 0x0001235E File Offset: 0x0001055E
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static bool IsNearlyEqual(double a, double b, double errorTolerance = 9.99999993922529E-09)
		{
			return Math.Abs(a - b) <= errorTolerance;
		}

		// Token: 0x06000B38 RID: 2872 RVA: 0x0001236E File Offset: 0x0001056E
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Sin(float value)
		{
			return MathF.Sin(value);
		}

		// Token: 0x06000B39 RID: 2873 RVA: 0x00012376 File Offset: 0x00010576
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Sinh(float value)
		{
			return MathF.Sinh(value);
		}

		// Token: 0x06000B3A RID: 2874 RVA: 0x0001237E File Offset: 0x0001057E
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Cos(float value)
		{
			return MathF.Cos(value);
		}

		// Token: 0x06000B3B RID: 2875 RVA: 0x00012386 File Offset: 0x00010586
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Cosh(float value)
		{
			return MathF.Cosh(value);
		}

		// Token: 0x06000B3C RID: 2876 RVA: 0x0001238E File Offset: 0x0001058E
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Tan(float value)
		{
			return MathF.Tan(value);
		}

		// Token: 0x06000B3D RID: 2877 RVA: 0x00012396 File Offset: 0x00010596
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Tanh(float value)
		{
			return MathF.Tanh(value);
		}

		// Token: 0x06000B3E RID: 2878 RVA: 0x0001239E File Offset: 0x0001059E
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Asin(float value)
		{
			return MathF.Asin(value);
		}

		// Token: 0x06000B3F RID: 2879 RVA: 0x000123A6 File Offset: 0x000105A6
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Asinh(float value)
		{
			return MathF.Asinh(value);
		}

		// Token: 0x06000B40 RID: 2880 RVA: 0x000123AE File Offset: 0x000105AE
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Acos(float value)
		{
			return MathF.Acos(value);
		}

		// Token: 0x06000B41 RID: 2881 RVA: 0x000123B6 File Offset: 0x000105B6
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Acosh(float value)
		{
			return MathF.Acosh(value);
		}

		// Token: 0x06000B42 RID: 2882 RVA: 0x000123BE File Offset: 0x000105BE
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Atan(float value)
		{
			return MathF.Atan(value);
		}

		// Token: 0x06000B43 RID: 2883 RVA: 0x000123C6 File Offset: 0x000105C6
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Atanh(float value)
		{
			return MathF.Atanh(value);
		}

		// Token: 0x06000B44 RID: 2884 RVA: 0x000123CE File Offset: 0x000105CE
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Atan2(float y, float x)
		{
			return MathF.Atan2(y, x);
		}

		// Token: 0x06000B45 RID: 2885 RVA: 0x000123D8 File Offset: 0x000105D8
		public static bool SphereAABBIntersection(in FSphere sphere, in FBox aabb)
		{
			float radiusSquared = FMath.Square<float>(sphere.W);
			return FMath.SphereAABBIntersection(sphere.Center, radiusSquared, aabb);
		}

		// Token: 0x06000B46 RID: 2886 RVA: 0x00012404 File Offset: 0x00010604
		public static FSphere ComputeBoundingSphereForCone(in FVector coneOrigin, in FVector coneDirection, float coneRadius, float cosConeAngle, float sinConeAngle)
		{
			FVector fvector;
			FVector fvector2;
			if (cosConeAngle < 0.70710677f)
			{
				fvector = coneDirection * coneRadius;
				fvector2 = fvector * cosConeAngle;
				FVector fvector3 = coneOrigin + fvector2;
				return new FSphere(ref fvector3, coneRadius * sinConeAngle);
			}
			float num = coneRadius / (2f * cosConeAngle);
			fvector = coneDirection * num;
			fvector2 = coneOrigin + fvector;
			return new FSphere(ref fvector2, num);
		}

		// Token: 0x06000B47 RID: 2887 RVA: 0x00012464 File Offset: 0x00010664
		public static bool PointBoxIntersection(in FVector point, in FBox box)
		{
			return point.X >= box.Min.X && point.X <= box.Max.X && point.Y >= box.Min.Y && point.Y <= box.Max.Y && point.Z >= box.Min.Z && point.Z <= box.Max.Z;
		}

		// Token: 0x06000B48 RID: 2888 RVA: 0x000124E8 File Offset: 0x000106E8
		public static bool LineBoxIntersection(in FBox box, in FVector start, in FVector end, in FVector startToEnd)
		{
			FVector fvector = startToEnd.Reciprocal();
			return FMath.LineBoxIntersection(box, start, end, startToEnd, fvector);
		}

		// Token: 0x06000B49 RID: 2889 RVA: 0x00012508 File Offset: 0x00010708
		public static bool LineBoxIntersection(in FBox box, in FVector start, in FVector end, in FVector startToEnd, in FVector oneOverStartToEnd)
		{
			bool flag = false;
			FVector fvector;
			if (start.X < box.Min.X)
			{
				flag = true;
				if (end.X < box.Min.X)
				{
					return false;
				}
				fvector.X = (box.Min.X - start.X) * oneOverStartToEnd.X;
			}
			else if (start.X > box.Max.X)
			{
				flag = true;
				if (end.X > box.Max.X)
				{
					return false;
				}
				fvector.X = (box.Max.X - start.X) * oneOverStartToEnd.X;
			}
			else
			{
				fvector.X = 0f;
			}
			if (start.Y < box.Min.Y)
			{
				flag = true;
				if (end.Y < box.Min.Y)
				{
					return false;
				}
				fvector.Y = (box.Min.Y - start.Y) * oneOverStartToEnd.Y;
			}
			else if (start.Y > box.Max.Y)
			{
				flag = true;
				if (end.Y > box.Max.Y)
				{
					return false;
				}
				fvector.Y = (box.Max.Y - start.Y) * oneOverStartToEnd.Y;
			}
			else
			{
				fvector.Y = 0f;
			}
			if (start.Z < box.Min.Z)
			{
				flag = true;
				if (end.Z < box.Min.Z)
				{
					return false;
				}
				fvector.Z = (box.Min.Z - start.Z) * oneOverStartToEnd.Z;
			}
			else if (start.Z > box.Max.Z)
			{
				flag = true;
				if (end.Z > box.Max.Z)
				{
					return false;
				}
				fvector.Z = (box.Max.Z - start.Z) * oneOverStartToEnd.Z;
			}
			else
			{
				fvector.Z = 0f;
			}
			if (flag)
			{
				float num = FMath.Max3(fvector.X, fvector.Y, fvector.Z);
				if (num >= 0f && num <= 1f)
				{
					FVector fvector2 = startToEnd * num;
					FVector fvector3 = start + fvector2;
					if (fvector3.X > box.Min.X - 0.1f && fvector3.X < box.Max.X + 0.1f && fvector3.Y > box.Min.Y - 0.1f && fvector3.Y < box.Max.Y + 0.1f && fvector3.Z > box.Min.Z - 0.1f && fvector3.Z < box.Max.Z + 0.1f)
					{
						return true;
					}
				}
				return false;
			}
			return true;
		}

		// Token: 0x06000B4A RID: 2890 RVA: 0x000127EC File Offset: 0x000109EC
		public static bool SphereAABBIntersection(FVector sphereCenter, float radiusSquared, FBox aabb)
		{
			float num = 0f;
			if (sphereCenter.X < aabb.Min.X)
			{
				num += FMath.Square<float>(sphereCenter.X - aabb.Min.X);
			}
			else if (sphereCenter.X > aabb.Max.X)
			{
				num += FMath.Square<float>(sphereCenter.X - aabb.Max.X);
			}
			if (sphereCenter.Y < aabb.Min.Y)
			{
				num += FMath.Square<float>(sphereCenter.Y - aabb.Min.Y);
			}
			else if (sphereCenter.Y > aabb.Max.Y)
			{
				num += FMath.Square<float>(sphereCenter.Y - aabb.Max.Y);
			}
			if (sphereCenter.Z < aabb.Min.Z)
			{
				num += FMath.Square<float>(sphereCenter.Z - aabb.Min.Z);
			}
			else if (sphereCenter.Z > aabb.Max.Z)
			{
				num += FMath.Square<float>(sphereCenter.Z - aabb.Max.Z);
			}
			return num <= radiusSquared;
		}

		// Token: 0x06000B4B RID: 2891 RVA: 0x0001291C File Offset: 0x00010B1C
		public static float GetRangePct(this FVector2D range, float value)
		{
			float num = range.Y - range.X;
			if (FMath.IsNearlyZero(num, 1E-08f))
			{
				return value >= range.Y;
			}
			return (value - range.X) / num;
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x0001295C File Offset: 0x00010B5C
		public static float GetRangeValue(this FVector2D range, float pct)
		{
			return FMath.Lerp<float>(range.X, range.Y, pct);
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00012970 File Offset: 0x00010B70
		public static double GetRangePct(this FVector2DDouble range, double value)
		{
			double num = range.Y - range.X;
			if (FMath.IsNearlyZero(num, 9.99999993922529E-09))
			{
				return value >= range.Y;
			}
			return (value - range.X) / num;
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x000129B4 File Offset: 0x00010BB4
		public static double GetRangeValue(this FVector2DDouble range, double pct)
		{
			return FMath.Lerp<double>(range.X, range.Y, pct);
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x000129C8 File Offset: 0x00010BC8
		public static FVector LinePlaneIntersection(in FVector point1, in FVector point2, in FVector planeOrigin, in FVector planeNormal)
		{
			FVector fvector = point2 - point1;
			FVector fvector2 = planeOrigin - point1;
			float num = fvector2 | planeNormal;
			FVector fvector3 = point2 - point1;
			FVector fvector4 = fvector * (num / (fvector3 | planeNormal));
			return point1 + fvector4;
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00012A10 File Offset: 0x00010C10
		public static bool LineSphereIntersection(in FVector start, in FVector dir, float length, in FVector origin, float radius)
		{
			FVector fvector = start - origin;
			FVector fvector2 = origin - start;
			float num = dir | fvector2;
			float num2 = radius * radius - ((fvector | fvector) - num * num);
			if (num2 >= 0f)
			{
				float num3 = (num - MathF.Sqrt(num2)) / length;
				return num3 >= 0f && num3 <= 1f;
			}
			return false;
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00012A78 File Offset: 0x00010C78
		public static FRotator Lerp(in FRotator a, in FRotator b, float alpha)
		{
			FRotator frotator = b - a;
			frotator = frotator.GetNormalized();
			FRotator frotator2 = frotator * alpha;
			return a + frotator2;
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00012AA8 File Offset: 0x00010CA8
		public static FRotator LerpRange(in FRotator a, in FRotator b, float alpha)
		{
			FRotator frotator = a * (1f - alpha);
			FRotator frotator2 = b * alpha;
			return (frotator + frotator2).GetNormalized();
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00012ADC File Offset: 0x00010CDC
		public static FQuat Lerp(in FQuat a, in FQuat b, float alpha)
		{
			return FQuat.Slerp(a, b, alpha);
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00012AE8 File Offset: 0x00010CE8
		public static FQuat BiLerp(in FQuat p00, in FQuat p10, in FQuat p01, in FQuat p11, float fracX, float fracY)
		{
			FQuat fquat = FQuat.Slerp_NotNormalized(p00, p10, fracX);
			FQuat fquat2 = FQuat.Slerp_NotNormalized(p01, p11, fracX);
			return FMath.Lerp(fquat, fquat2, fracY);
		}

		// Token: 0x06000B55 RID: 2901 RVA: 0x00012B14 File Offset: 0x00010D14
		public static FQuat CubicInterp(in FQuat p0, in FQuat t0, in FQuat p1, in FQuat t1, float a)
		{
			return FQuat.Squad(p0, t0, p1, t1, a);
		}

		// Token: 0x06000B56 RID: 2902 RVA: 0x00012B24 File Offset: 0x00010D24
		public static FVector RayPlaneIntersection(in FVector rayOrigin, in FVector rayDirection, in FPlane plane)
		{
			FVector v = plane.View.V;
			FVector fvector = v * plane.W;
			FVector fvector2 = fvector - rayOrigin;
			float scale = FVector.DotProduct(fvector2, v) / FVector.DotProduct(rayDirection, v);
			fvector2 = rayDirection * scale;
			return rayOrigin + fvector2;
		}

		// Token: 0x06000B57 RID: 2903 RVA: 0x00012B78 File Offset: 0x00010D78
		public static FVector LinePlaneIntersection(in FVector point1, in FVector point2, in FPlane plane)
		{
			FVector fvector = point2 - point1;
			float w = plane.W;
			FVector fvector2 = plane;
			float num = w - (point1 | fvector2);
			FVector fvector3 = point2 - point1;
			FVector fvector4 = plane;
			FVector fvector5 = fvector * (num / (fvector3 | fvector4));
			return point1 + fvector5;
		}

		// Token: 0x06000B58 RID: 2904 RVA: 0x00012BD0 File Offset: 0x00010DD0
		public static bool IntersectPlanes3(out FVector i, in FPlane p1, in FPlane p2, in FPlane p3)
		{
			ref FPlaneView view = ref p1.View;
			ref FPlaneView view2 = ref p2.View;
			ref FPlaneView view3 = ref p3.View;
			FVector fvector = view.V ^ view2.V;
			float num = fvector | view3.V;
			if (FMath.Square<float>(num) < FMath.Square<float>(0.001f))
			{
				i = FVector.ZeroVector;
				return false;
			}
			float w = p1.W;
			fvector = (view2.V ^ view3.V);
			FVector fvector2 = w * fvector;
			float w2 = p2.W;
			FVector fvector3 = view3.V ^ view.V;
			FVector fvector4 = w2 * fvector3;
			FVector fvector5 = fvector2 + fvector4;
			float w3 = p3.W;
			FVector fvector6 = view.V ^ view2.V;
			FVector fvector7 = w3 * fvector6;
			FVector fvector8 = fvector5 + fvector7;
			i = fvector8 / num;
			return true;
		}

		// Token: 0x06000B59 RID: 2905 RVA: 0x00012CC0 File Offset: 0x00010EC0
		public static bool IntersectPlanes2(out FVector i, out FVector d, in FPlane p1, in FPlane p2)
		{
			d = (p1.View.V ^ p2.View.V);
			float num = d.SizeSquared();
			FVector fvector;
			if (num < FMath.Square<float>(0.001f))
			{
				fvector = (i = FVector.ZeroVector);
				d = fvector;
				return false;
			}
			float w = p1.W;
			fvector = p2;
			FVector fvector2 = fvector ^ d;
			FVector fvector3 = w * fvector2;
			float w2 = p2.W;
			FVector fvector4 = p1;
			FVector fvector5 = d ^ fvector4;
			FVector fvector6 = w2 * fvector5;
			FVector fvector7 = fvector3 + fvector6;
			i = fvector7 / num;
			d.Normalize(1E-08f);
			return true;
		}
	}
}
