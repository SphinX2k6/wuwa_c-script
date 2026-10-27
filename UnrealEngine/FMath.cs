using System;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace UnrealEngine
{
	// Token: 0x0200008C RID: 140
	[NullableContext(1)]
	[Nullable(0)]
	public static class FMath
	{
		// Token: 0x06000F8D RID: 3981 RVA: 0x00017223 File Offset: 0x00015423
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float GridSnap(float location, float grid)
		{
			if (grid != 0f)
			{
				return MathF.Floor((location + grid * 0.5f) / grid) * grid;
			}
			return location;
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x00017241 File Offset: 0x00015441
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double GridSnap(double location, double grid)
		{
			if (grid != 0.0)
			{
				return Math.Floor((location + grid * 0.5) / grid) * grid;
			}
			return location;
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x00017267 File Offset: 0x00015467
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static int RoundToInt(float F)
		{
			return (int)MathF.Floor(F + 0.5f);
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00017276 File Offset: 0x00015476
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float RoundToFloat(float F)
		{
			return MathF.Floor(F + 0.5f);
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00017284 File Offset: 0x00015484
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float FloatSelect(float comparand, float valueGeZero, float valueLtZero)
		{
			if (comparand < 0f)
			{
				return valueLtZero;
			}
			return valueGeZero;
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x00017291 File Offset: 0x00015491
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double FloatSelect(double comparand, double valueGeZero, double valueLtZero)
		{
			if (comparand < 0.0)
			{
				return valueLtZero;
			}
			return valueGeZero;
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x000172A2 File Offset: 0x000154A2
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static float DegreesToRadians(float degVal)
		{
			return degVal * 0.017453292f;
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x000172AB File Offset: 0x000154AB
		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		public static double DegreesToRadians(double degVal)
		{
			return degVal * 0.017453293005625408;
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x000172B8 File Offset: 0x000154B8
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static T Lerp<[Nullable(0)] T>(T a, T b, float alpha) where T : IAdditionOperators<T, T, T>, ISubtractionOperators<T, T, T>, IMultiplyOperators<T, float, T>
		{
			return a + (b - a) * alpha;
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x000172DF File Offset: 0x000154DF
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static T Lerp<[Nullable(0)] T>(T a, T b, double alpha) where T : IAdditionOperators<T, T, T>, ISubtractionOperators<T, T, T>, IMultiplyOperators<T, double, T>
		{
			return a + (b - a) * alpha;
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00017308 File Offset: 0x00015508
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static FLinearColor Lerp(FLinearColor a, FLinearColor b, float alpha)
		{
			FLinearColor flinearColor = b - a;
			FLinearColor flinearColor2 = flinearColor * alpha;
			return a + flinearColor2;
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00017334 File Offset: 0x00015534
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static FVector Lerp(FVector a, FVector b, float alpha)
		{
			FVector fvector = b - a;
			FVector fvector2 = fvector * alpha;
			return a + fvector2;
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x00017360 File Offset: 0x00015560
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static FVectorDouble Lerp(FVectorDouble a, FVectorDouble b, float alpha)
		{
			FVectorDouble fvectorDouble = b - a;
			FVectorDouble fvectorDouble2 = fvectorDouble * (double)alpha;
			return a + fvectorDouble2;
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x0001738A File Offset: 0x0001558A
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static T Square<[Nullable(0)] T>(T a) where T : IMultiplyOperators<T, T, T>
		{
			return a * a;
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00017399 File Offset: 0x00015599
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Max3(float a, float b, float c)
		{
			return Math.Max(Math.Max(a, b), c);
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x000173A8 File Offset: 0x000155A8
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static double Max3(double a, double b, double c)
		{
			return Math.Max(Math.Max(a, b), c);
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x000173B8 File Offset: 0x000155B8
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

		// Token: 0x06000F9E RID: 3998 RVA: 0x000174DA File Offset: 0x000156DA
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

		// Token: 0x06000F9F RID: 3999 RVA: 0x00017503 File Offset: 0x00015703
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

		// Token: 0x06000FA0 RID: 4000 RVA: 0x0001752C File Offset: 0x0001572C
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

		// Token: 0x06000FA1 RID: 4001 RVA: 0x0001760E File Offset: 0x0001580E
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static bool IsNearlyZero(float value, float errorTolerance = 1E-08f)
		{
			return Math.Abs(value) <= errorTolerance;
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x0001761C File Offset: 0x0001581C
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static bool IsNearlyZero(double value, double errorTolerance = 9.99999993922529E-09)
		{
			return Math.Abs(value) <= errorTolerance;
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x0001762A File Offset: 0x0001582A
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static bool IsNearlyEqual(float a, float b, float errorTolerance = 1E-08f)
		{
			return Math.Abs(a - b) <= errorTolerance;
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x0001763A File Offset: 0x0001583A
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static bool IsNearlyEqual(double a, double b, double errorTolerance = 9.99999993922529E-09)
		{
			return Math.Abs(a - b) <= errorTolerance;
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x0001764A File Offset: 0x0001584A
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Sin(float value)
		{
			return MathF.Sin(value);
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00017652 File Offset: 0x00015852
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Sinh(float value)
		{
			return MathF.Sinh(value);
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x0001765A File Offset: 0x0001585A
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Cos(float value)
		{
			return MathF.Cos(value);
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x00017662 File Offset: 0x00015862
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Cosh(float value)
		{
			return MathF.Cosh(value);
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x0001766A File Offset: 0x0001586A
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Tan(float value)
		{
			return MathF.Tan(value);
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00017672 File Offset: 0x00015872
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Tanh(float value)
		{
			return MathF.Tanh(value);
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x0001767A File Offset: 0x0001587A
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Asin(float value)
		{
			return MathF.Asin(value);
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x00017682 File Offset: 0x00015882
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Asinh(float value)
		{
			return MathF.Asinh(value);
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x0001768A File Offset: 0x0001588A
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Acos(float value)
		{
			return MathF.Acos(value);
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x00017692 File Offset: 0x00015892
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Acosh(float value)
		{
			return MathF.Acosh(value);
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x0001769A File Offset: 0x0001589A
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Atan(float value)
		{
			return MathF.Atan(value);
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x000176A2 File Offset: 0x000158A2
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Atanh(float value)
		{
			return MathF.Atanh(value);
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x000176AA File Offset: 0x000158AA
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public static float Atan2(float y, float x)
		{
			return MathF.Atan2(y, x);
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x000176B4 File Offset: 0x000158B4
		public static bool SphereAABBIntersection(in FSphere sphere, in FBox aabb)
		{
			float radiusSquared = FMath.Square<float>(sphere.W);
			return FMath.SphereAABBIntersection(sphere.Center, radiusSquared, aabb);
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x000176E0 File Offset: 0x000158E0
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

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00017740 File Offset: 0x00015940
		public static bool PointBoxIntersection(in FVector point, in FBox box)
		{
			return point.X >= box.Min.X && point.X <= box.Max.X && point.Y >= box.Min.Y && point.Y <= box.Max.Y && point.Z >= box.Min.Z && point.Z <= box.Max.Z;
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x000177C4 File Offset: 0x000159C4
		public static bool LineBoxIntersection(in FBox box, in FVector start, in FVector end, in FVector startToEnd)
		{
			FVector fvector = startToEnd.Reciprocal();
			return FMath.LineBoxIntersection(box, start, end, startToEnd, fvector);
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x000177E4 File Offset: 0x000159E4
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

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00017AC8 File Offset: 0x00015CC8
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

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00017BF8 File Offset: 0x00015DF8
		public static float GetRangePct(this FVector2D range, float value)
		{
			float num = range.Y - range.X;
			if (FMath.IsNearlyZero(num, 1E-08f))
			{
				return value >= range.Y;
			}
			return (value - range.X) / num;
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00017C38 File Offset: 0x00015E38
		public static float GetRangeValue(this FVector2D range, float pct)
		{
			return FMath.Lerp<float>(range.X, range.Y, pct);
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x00017C4C File Offset: 0x00015E4C
		public static double GetRangePct(this FVector2DDouble range, double value)
		{
			double num = range.Y - range.X;
			if (FMath.IsNearlyZero(num, 9.99999993922529E-09))
			{
				return value >= range.Y;
			}
			return (value - range.X) / num;
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x00017C90 File Offset: 0x00015E90
		public static double GetRangeValue(this FVector2DDouble range, double pct)
		{
			return FMath.Lerp<double>(range.X, range.Y, pct);
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x00017CA4 File Offset: 0x00015EA4
		public static FVector LinePlaneIntersection(in FVector point1, in FVector point2, in FVector planeOrigin, in FVector planeNormal)
		{
			FVector fvector = point2 - point1;
			FVector fvector2 = planeOrigin - point1;
			float num = fvector2 | planeNormal;
			FVector fvector3 = point2 - point1;
			FVector fvector4 = fvector * (num / (fvector3 | planeNormal));
			return point1 + fvector4;
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00017CEC File Offset: 0x00015EEC
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

		// Token: 0x06000FBE RID: 4030 RVA: 0x00017D54 File Offset: 0x00015F54
		public static FRotator Lerp(in FRotator a, in FRotator b, float alpha)
		{
			FRotator frotator = b - a;
			frotator = frotator.GetNormalized();
			FRotator frotator2 = frotator * alpha;
			return a + frotator2;
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00017D84 File Offset: 0x00015F84
		public static FRotator LerpRange(in FRotator a, in FRotator b, float alpha)
		{
			FRotator frotator = a * (1f - alpha);
			FRotator frotator2 = b * alpha;
			return (frotator + frotator2).GetNormalized();
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x00017DB8 File Offset: 0x00015FB8
		public static FQuat Lerp(in FQuat a, in FQuat b, float alpha)
		{
			return FQuat.Slerp(a, b, alpha);
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x00017DC4 File Offset: 0x00015FC4
		public static FQuat BiLerp(in FQuat p00, in FQuat p10, in FQuat p01, in FQuat p11, float fracX, float fracY)
		{
			FQuat fquat = FQuat.Slerp_NotNormalized(p00, p10, fracX);
			FQuat fquat2 = FQuat.Slerp_NotNormalized(p01, p11, fracX);
			return FMath.Lerp(fquat, fquat2, fracY);
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00017DF0 File Offset: 0x00015FF0
		public static FQuat CubicInterp(in FQuat p0, in FQuat t0, in FQuat p1, in FQuat t1, float a)
		{
			return FQuat.Squad(p0, t0, p1, t1, a);
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x00017E00 File Offset: 0x00016000
		public static FVector RayPlaneIntersection(in FVector rayOrigin, in FVector rayDirection, in FPlane plane)
		{
			FVector v = plane.View.V;
			FVector fvector = v * plane.W;
			FVector fvector2 = fvector - rayOrigin;
			float scale = FVector.DotProduct(fvector2, v) / FVector.DotProduct(rayDirection, v);
			fvector2 = rayDirection * scale;
			return rayOrigin + fvector2;
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00017E54 File Offset: 0x00016054
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

		// Token: 0x06000FC5 RID: 4037 RVA: 0x00017EAC File Offset: 0x000160AC
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

		// Token: 0x06000FC6 RID: 4038 RVA: 0x00017F9C File Offset: 0x0001619C
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
