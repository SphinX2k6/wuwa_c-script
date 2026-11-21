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
	// Token: 0x02000025 RID: 37
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/CoreUObject.Vector")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FVector : IEquatable<FVector>, IEqualityOperators<FVector, FVector, bool>, IVector, IVector2D, IUnrealScriptStruct
	{
		// Token: 0x06000559 RID: 1369 RVA: 0x00009BB9 File Offset: 0x00007DB9
		[Conditional("ENABLE_NAN_DIAGNOSTIC")]
		public void DiagnosticCheckNaN()
		{
			if (!SharpherealAssert.Ensure(!this.ContainsNaN(), "FVector contains NaN: {0}", new object[]
			{
				this
			}))
			{
				this = FVector.ZeroVector;
			}
		}

		// Token: 0x0600055A RID: 1370 RVA: 0x00009BEF File Offset: 0x00007DEF
		public FVector()
		{
			this.X = 0f;
			this.Y = 0f;
			this.Z = 0f;
		}

		// Token: 0x0600055B RID: 1371 RVA: 0x00009C12 File Offset: 0x00007E12
		public FVector(float inF)
		{
			this = new FVector(inF, inF, inF);
		}

		// Token: 0x0600055C RID: 1372 RVA: 0x00009C1D File Offset: 0x00007E1D
		public FVector(float inX, float inY)
		{
			this = new FVector(inX, inY, 0f);
		}

		// Token: 0x0600055D RID: 1373 RVA: 0x00009C2C File Offset: 0x00007E2C
		public FVector(in FVector2D v, float inZ = 0f)
		{
			this = new FVector(v.X, v.Y, inZ);
		}

		// Token: 0x0600055E RID: 1374 RVA: 0x00009C41 File Offset: 0x00007E41
		public FVector(in FVector4 v)
		{
			this = new FVector(v.X, v.Y, v.Z);
		}

		// Token: 0x0600055F RID: 1375 RVA: 0x00009C5B File Offset: 0x00007E5B
		public FVector(in FLinearColor v)
		{
			this = new FVector(v.R, v.G, v.B);
		}

		// Token: 0x06000560 RID: 1376 RVA: 0x00009C75 File Offset: 0x00007E75
		public FVector(in FIntVector v)
		{
			this = new FVector((float)v.X, (float)v.Y, (float)v.Z);
		}

		// Token: 0x06000561 RID: 1377 RVA: 0x00009C92 File Offset: 0x00007E92
		public FVector(in FIntPoint v)
		{
			this = new FVector((float)v.X, (float)v.Y, 0f);
		}

		// Token: 0x06000562 RID: 1378 RVA: 0x00009CAD File Offset: 0x00007EAD
		public Span<float> AsSpan()
		{
			return new Span<float>(Unsafe.AsPointer<FVector>(ref this), sizeof(FVector) / 4);
		}

		// Token: 0x06000563 RID: 1379 RVA: 0x00009CC2 File Offset: 0x00007EC2
		public static implicit operator FVector(in FVector4 a)
		{
			return new FVector(a.X, a.Y, a.Z);
		}

		// Token: 0x06000564 RID: 1380 RVA: 0x00009CDB File Offset: 0x00007EDB
		public static implicit operator FVector(in FVector2D a)
		{
			return new FVector(a.X, a.Y, 0f);
		}

		// Token: 0x06000565 RID: 1381 RVA: 0x00009CF3 File Offset: 0x00007EF3
		public static implicit operator FVector(in FPlane a)
		{
			return new FVector(a.X, a.Y, a.Z);
		}

		// Token: 0x06000566 RID: 1382 RVA: 0x00009D0C File Offset: 0x00007F0C
		public static FVector operator *(float scale, in FVector v)
		{
			return v * scale;
		}

		// Token: 0x06000567 RID: 1383 RVA: 0x00009D15 File Offset: 0x00007F15
		public static FVector operator -(in FVector v)
		{
			return new FVector(-v.X, -v.Y, -v.Z);
		}

		// Token: 0x06000568 RID: 1384 RVA: 0x00009D31 File Offset: 0x00007F31
		public static bool operator ==(FVector a, FVector b)
		{
			return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
		}

		// Token: 0x06000569 RID: 1385 RVA: 0x00009D5F File Offset: 0x00007F5F
		public static bool operator !=(FVector a, FVector b)
		{
			return a.X != b.X || a.Y != b.Y || a.Z != b.Z;
		}

		// Token: 0x0600056A RID: 1386 RVA: 0x00009D90 File Offset: 0x00007F90
		public readonly bool Equals(FVector other)
		{
			return this == other;
		}

		// Token: 0x0600056B RID: 1387 RVA: 0x00009DA0 File Offset: 0x00007FA0
		[NullableContext(2)]
		public override readonly bool Equals(object obj)
		{
			if (obj is FVector)
			{
				FVector b = (FVector)obj;
				return this == b;
			}
			return false;
		}

		// Token: 0x0600056C RID: 1388 RVA: 0x00009DCA File Offset: 0x00007FCA
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<float, float, float>(this.X, this.Y, this.Z);
		}

		// Token: 0x17000016 RID: 22
		public float this[int index]
		{
			readonly get
			{
				float result;
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

		// Token: 0x0600056F RID: 1391 RVA: 0x00009E5A File Offset: 0x0000805A
		public readonly float Component(int index)
		{
			return this[index];
		}

		// Token: 0x06000570 RID: 1392 RVA: 0x00009E64 File Offset: 0x00008064
		[NullableContext(1)]
		public override readonly string ToString()
		{
			DefaultInterpolatedStringHandler defaultInterpolatedStringHandler = new DefaultInterpolatedStringHandler(8, 3);
			defaultInterpolatedStringHandler.AppendLiteral("X=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.X);
			defaultInterpolatedStringHandler.AppendLiteral(" Y=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Y);
			defaultInterpolatedStringHandler.AppendLiteral(" Z=");
			defaultInterpolatedStringHandler.AppendFormatted<float>(this.Z);
			return defaultInterpolatedStringHandler.ToStringAndClear();
		}

		// Token: 0x06000571 RID: 1393 RVA: 0x00009ECC File Offset: 0x000080CC
		[NullableContext(1)]
		public readonly FText ToText()
		{
			return new FText(this.ToString());
		}

		// Token: 0x06000572 RID: 1394
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Ctor(float x, float y, float z);

		// Token: 0x06000573 RID: 1395
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Add(in FVector a, in FVector b);

		// Token: 0x06000574 RID: 1396
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_AddFloat(in FVector a, float bias);

		// Token: 0x06000575 RID: 1397
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Sub(in FVector a, in FVector b);

		// Token: 0x06000576 RID: 1398
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_SubFloat(in FVector a, float bias);

		// Token: 0x06000577 RID: 1399
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Mul(in FVector a, in FVector b);

		// Token: 0x06000578 RID: 1400
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_MulFloat(in FVector a, float scale);

		// Token: 0x06000579 RID: 1401
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Div(in FVector a, in FVector b);

		// Token: 0x0600057A RID: 1402
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_DivFloat(in FVector a, float scale);

		// Token: 0x0600057B RID: 1403
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Or(in FVector a, in FVector b);

		// Token: 0x0600057C RID: 1404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Xor(in FVector a, in FVector b);

		// Token: 0x0600057D RID: 1405
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Min(in FVector a, in FVector b);

		// Token: 0x0600057E RID: 1406
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Max(in FVector a, in FVector b);

		// Token: 0x0600057F RID: 1407
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Min3(in FVector a, in FVector b, in FVector c);

		// Token: 0x06000580 RID: 1408
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Max3(in FVector a, in FVector b, in FVector c);

		// Token: 0x06000581 RID: 1409
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_DotProduct(in FVector a, in FVector b);

		// Token: 0x06000582 RID: 1410
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_CrossProduct(in FVector a, in FVector b);

		// Token: 0x06000583 RID: 1411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateOrthonormalBasis(ref FVector a, ref FVector b, ref FVector c);

		// Token: 0x06000584 RID: 1412
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_PointsAreSame(in FVector a, in FVector b);

		// Token: 0x06000585 RID: 1413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_PointsAreNear(in FVector a, in FVector b, float dist);

		// Token: 0x06000586 RID: 1414
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_PointPlaneDist(in FVector point, in FVector planeBase, in FVector planeNormal);

		// Token: 0x06000587 RID: 1415
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_PointPlaneProject_Plane(in FVector point, in FPlane plane);

		// Token: 0x06000588 RID: 1416
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_PointPlaneProject_abc(in FVector point, in FVector a, in FVector b, in FVector c);

		// Token: 0x06000589 RID: 1417
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_PointPlaneProject_base_normal(in FVector point, in FVector planeBase, in FVector planeNormal);

		// Token: 0x0600058A RID: 1418
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_VectorPlaneProject(in FVector v, in FVector planeNormal);

		// Token: 0x0600058B RID: 1419
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Dist(in FVector a, in FVector b);

		// Token: 0x0600058C RID: 1420
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Distance(in FVector a, in FVector b);

		// Token: 0x0600058D RID: 1421
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_DistXY(in FVector a, in FVector b);

		// Token: 0x0600058E RID: 1422
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Dist2D(in FVector a, in FVector b);

		// Token: 0x0600058F RID: 1423
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_DistSquared(in FVector a, in FVector b);

		// Token: 0x06000590 RID: 1424
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_DistSquaredXY(in FVector a, in FVector b);

		// Token: 0x06000591 RID: 1425
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_DistSquared2D(in FVector a, in FVector b);

		// Token: 0x06000592 RID: 1426
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_BoxPushOut(in FVector normal, in FVector size);

		// Token: 0x06000593 RID: 1427
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Parallel(in FVector normal1, in FVector normal2, float parallelCosineThreshold = 0.999845f);

		// Token: 0x06000594 RID: 1428
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Coincident(in FVector normal1, in FVector normal2, float parallelCosineThreshold = 0.999845f);

		// Token: 0x06000595 RID: 1429
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Orthogonal(in FVector normal1, in FVector normal2, float parallelCosineThreshold = 0.999845f);

		// Token: 0x06000596 RID: 1430
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Coplanar(in FVector base1, in FVector normal1, in FVector base2, in FVector normal2, float parallelCosineThreshold = 0.999845f);

		// Token: 0x06000597 RID: 1431
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Triple(in FVector x, in FVector y, in FVector z);

		// Token: 0x06000598 RID: 1432
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern float Internal_EvaluateBezier(FVector* controlPoints, int controlPointsCount, IntPtr outPoints);

		// Token: 0x06000599 RID: 1433
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_RadiansToDegrees(in FVector radVector);

		// Token: 0x0600059A RID: 1434
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_DegreesToRadians(in FVector degVector);

		// Token: 0x0600059B RID: 1435
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_ComputeSquaredDistanceFromBoxToPoint(in FVector mins, in FVector maxs, in FVector point);

		// Token: 0x0600059C RID: 1436
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_ClampVector(in FVector v, in FVector min, in FVector max);

		// Token: 0x0600059D RID: 1437
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FVector a, in FVector b, float tolerance = 0.0001f);

		// Token: 0x0600059E RID: 1438
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_AllComponentsEqual(in FVector a, float tolerance = 0.0001f);

		// Token: 0x0600059F RID: 1439
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetComponentForAxis(in FVector a, EAxis axis);

		// Token: 0x060005A0 RID: 1440
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetComponentForAxis(ref FVector a, EAxis axis, float component);

		// Token: 0x060005A1 RID: 1441
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Set(ref FVector a, float x, float y, float z);

		// Token: 0x060005A2 RID: 1442
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetMax(in FVector a);

		// Token: 0x060005A3 RID: 1443
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetAbsMax(in FVector a);

		// Token: 0x060005A4 RID: 1444
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetMin(in FVector a);

		// Token: 0x060005A5 RID: 1445
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetAbsMin(in FVector a);

		// Token: 0x060005A6 RID: 1446
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_ComponentMin(in FVector a, in FVector b);

		// Token: 0x060005A7 RID: 1447
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_ComponentMax(in FVector a, in FVector b);

		// Token: 0x060005A8 RID: 1448
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetAbs(in FVector a);

		// Token: 0x060005A9 RID: 1449
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Size(in FVector a);

		// Token: 0x060005AA RID: 1450
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_SizeSquared(in FVector a);

		// Token: 0x060005AB RID: 1451
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Size2D(in FVector a);

		// Token: 0x060005AC RID: 1452
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_SizeSquared2D(in FVector a);

		// Token: 0x060005AD RID: 1453
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsNearlyZero(in FVector a, float tolerance = 0.0001f);

		// Token: 0x060005AE RID: 1454
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsZero(in FVector a);

		// Token: 0x060005AF RID: 1455
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsUnit(in FVector a);

		// Token: 0x060005B0 RID: 1456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsNormalized(in FVector a);

		// Token: 0x060005B1 RID: 1457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Normalize(ref FVector a, float tolerance = 1E-08f);

		// Token: 0x060005B2 RID: 1458
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetUnsafeNormal(in FVector a);

		// Token: 0x060005B3 RID: 1459
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetSafeNormal(in FVector a, float tolerance = 1E-08f);

		// Token: 0x060005B4 RID: 1460
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetSafeNormal2D(in FVector a, float tolerance = 1E-08f);

		// Token: 0x060005B5 RID: 1461
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ToDirectionAndLength(in FVector a, out FVector outDirection, out float outLength);

		// Token: 0x060005B6 RID: 1462
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetSignVector(in FVector a);

		// Token: 0x060005B7 RID: 1463
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Projection(in FVector a);

		// Token: 0x060005B8 RID: 1464
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetUnsafeNormal2D(in FVector a);

		// Token: 0x060005B9 RID: 1465
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GridSnap(in FVector a, float gridSz);

		// Token: 0x060005BA RID: 1466
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_BoundToCube(in FVector a, float radius);

		// Token: 0x060005BB RID: 1467
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_BoundToBox(in FVector a, in FVector min, in FVector max);

		// Token: 0x060005BC RID: 1468
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetClampedToSize(in FVector a, float min, float max);

		// Token: 0x060005BD RID: 1469
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetClampedToSize2D(in FVector a, float min, float max);

		// Token: 0x060005BE RID: 1470
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetClampedToMaxSize(in FVector a, float maxSize);

		// Token: 0x060005BF RID: 1471
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetClampedToMaxSize2D(in FVector a, float maxSize);

		// Token: 0x060005C0 RID: 1472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_AddBounded(ref FVector a, in FVector v, float radius = 32767f);

		// Token: 0x060005C1 RID: 1473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Reciprocal(in FVector a);

		// Token: 0x060005C2 RID: 1474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsUniform(in FVector a, float tolerance = 0.0001f);

		// Token: 0x060005C3 RID: 1475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_MirrorByVector(in FVector a, in FVector mirrorNormal);

		// Token: 0x060005C4 RID: 1476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_MirrorByPlane(in FVector a, in FPlane plane);

		// Token: 0x060005C5 RID: 1477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_RotateAngleAxis(in FVector a, float angleDeg, in FVector axis);

		// Token: 0x060005C6 RID: 1478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_CosineAngle2D(in FVector a, in FVector b);

		// Token: 0x060005C7 RID: 1479
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_ProjectOnTo(in FVector a, in FVector b);

		// Token: 0x060005C8 RID: 1480
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_ProjectOnToNormal(in FVector a, in FVector normal);

		// Token: 0x060005C9 RID: 1481
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_ToOrientationRotator(in FVector a);

		// Token: 0x060005CA RID: 1482
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_ToOrientationQuat(in FVector a);

		// Token: 0x060005CB RID: 1483
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_Rotation(in FVector a);

		// Token: 0x060005CC RID: 1484
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_FindBestAxisVectors(in FVector a, out FVector outAxis1, out FVector outAxis2);

		// Token: 0x060005CD RID: 1485
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_UnwindEuler(ref FVector a);

		// Token: 0x060005CE RID: 1486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FVector a);

		// Token: 0x060005CF RID: 1487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_UnitCartesianToSpherical(in FVector a);

		// Token: 0x060005D0 RID: 1488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_HeadingAngle(in FVector a);

		// Token: 0x060005D1 RID: 1489
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_InitFromString(ref FVector a, in FCSharpStringView str);

		// Token: 0x060005D2 RID: 1490 RVA: 0x00009EDF File Offset: 0x000080DF
		public FVector(float inX, float inY, float inZ)
		{
			this.X = inX;
			this.Y = inY;
			this.Z = inZ;
		}

		// Token: 0x060005D3 RID: 1491 RVA: 0x00009EF8 File Offset: 0x000080F8
		public unsafe static FVector operator +(in FVector a, in FVector b)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_Add(a, b);
				}
			}
		}

		// Token: 0x060005D4 RID: 1492 RVA: 0x00009F14 File Offset: 0x00008114
		public unsafe static FVector operator +(in FVector a, float bias)
		{
			fixed (FVector* ptr = &a)
			{
				return FVector.Internal_AddFloat(a, bias);
			}
		}

		// Token: 0x060005D5 RID: 1493 RVA: 0x00009F2C File Offset: 0x0000812C
		public unsafe static FVector operator -(in FVector a, in FVector b)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_Sub(a, b);
				}
			}
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x00009F48 File Offset: 0x00008148
		public unsafe static FVector operator -(in FVector a, float bias)
		{
			fixed (FVector* ptr = &a)
			{
				return FVector.Internal_SubFloat(a, bias);
			}
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x00009F60 File Offset: 0x00008160
		public unsafe static FVector operator *(in FVector a, in FVector b)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_Mul(a, b);
				}
			}
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x00009F7C File Offset: 0x0000817C
		public unsafe static FVector operator *(in FVector a, float scale)
		{
			fixed (FVector* ptr = &a)
			{
				return FVector.Internal_MulFloat(a, scale);
			}
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x00009F94 File Offset: 0x00008194
		public unsafe static FVector operator /(in FVector a, in FVector b)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_Div(a, b);
				}
			}
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x00009FB0 File Offset: 0x000081B0
		public unsafe static FVector operator /(in FVector a, float scale)
		{
			fixed (FVector* ptr = &a)
			{
				return FVector.Internal_DivFloat(a, scale);
			}
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x00009FC8 File Offset: 0x000081C8
		public unsafe static float operator |(in FVector a, in FVector b)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_Or(a, b);
				}
			}
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x00009FE4 File Offset: 0x000081E4
		public unsafe static FVector operator ^(in FVector a, in FVector b)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_Xor(a, b);
				}
			}
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0000A000 File Offset: 0x00008200
		public unsafe static FVector Min(in FVector a, in FVector b)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_Min(a, b);
				}
			}
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0000A01C File Offset: 0x0000821C
		public unsafe static FVector Max(in FVector a, in FVector b)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_Max(a, b);
				}
			}
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0000A038 File Offset: 0x00008238
		public unsafe static FVector Min3(in FVector a, in FVector b, in FVector c)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					fixed (FVector* ptr3 = &c)
					{
						return FVector.Internal_Min3(a, b, c);
					}
				}
			}
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0000A05C File Offset: 0x0000825C
		public unsafe static FVector Max3(in FVector a, in FVector b, in FVector c)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					fixed (FVector* ptr3 = &c)
					{
						return FVector.Internal_Max3(a, b, c);
					}
				}
			}
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0000A080 File Offset: 0x00008280
		public unsafe static float DotProduct(in FVector a, in FVector b)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_DotProduct(a, b);
				}
			}
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0000A09C File Offset: 0x0000829C
		public unsafe static FVector CrossProduct(in FVector a, in FVector b)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_CrossProduct(a, b);
				}
			}
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0000A0B8 File Offset: 0x000082B8
		public unsafe static void CreateOrthonormalBasis(ref FVector a, ref FVector b, ref FVector c)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					fixed (FVector* ptr3 = &c)
					{
						FVector.Internal_CreateOrthonormalBasis(ref a, ref b, ref c);
					}
				}
			}
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0000A0E4 File Offset: 0x000082E4
		public unsafe static bool PointsAreSame(in FVector a, in FVector b)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_PointsAreSame(a, b);
				}
			}
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x0000A100 File Offset: 0x00008300
		public unsafe static bool PointsAreNear(in FVector a, in FVector b, float dist)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_PointsAreNear(a, b, dist);
				}
			}
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0000A120 File Offset: 0x00008320
		public unsafe static float PointPlaneDist(in FVector point, in FVector planeBase, in FVector planeNormal)
		{
			fixed (FVector* ptr = &point)
			{
				fixed (FVector* ptr2 = &planeBase)
				{
					fixed (FVector* ptr3 = &planeNormal)
					{
						return FVector.Internal_PointPlaneDist(point, planeBase, planeNormal);
					}
				}
			}
		}

		// Token: 0x060005E7 RID: 1511 RVA: 0x0000A144 File Offset: 0x00008344
		public unsafe static FVector PointPlaneProject(in FVector point, in FPlane plane)
		{
			fixed (FVector* ptr = &point)
			{
				fixed (FPlane* ptr2 = &plane)
				{
					return FVector.Internal_PointPlaneProject_Plane(point, plane);
				}
			}
		}

		// Token: 0x060005E8 RID: 1512 RVA: 0x0000A160 File Offset: 0x00008360
		public unsafe static FVector PointPlaneProject(in FVector point, in FVector a, in FVector b, in FVector c)
		{
			fixed (FVector* ptr = &point)
			{
				fixed (FVector* ptr2 = &a)
				{
					fixed (FVector* ptr3 = &b)
					{
						fixed (FVector* ptr4 = &c)
						{
							return FVector.Internal_PointPlaneProject_abc(point, a, b, c);
						}
					}
				}
			}
		}

		// Token: 0x060005E9 RID: 1513 RVA: 0x0000A188 File Offset: 0x00008388
		public unsafe static FVector PointPlaneProject(in FVector point, in FVector planeBase, in FVector planeNormal)
		{
			fixed (FVector* ptr = &point)
			{
				fixed (FVector* ptr2 = &planeBase)
				{
					fixed (FVector* ptr3 = &planeNormal)
					{
						return FVector.Internal_PointPlaneProject_base_normal(point, planeBase, planeNormal);
					}
				}
			}
		}

		// Token: 0x060005EA RID: 1514 RVA: 0x0000A1AC File Offset: 0x000083AC
		public unsafe static FVector VectorPlaneProject(in FVector v, in FVector planeNormal)
		{
			fixed (FVector* ptr = &v)
			{
				fixed (FVector* ptr2 = &planeNormal)
				{
					return FVector.Internal_VectorPlaneProject(v, planeNormal);
				}
			}
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0000A1C8 File Offset: 0x000083C8
		public unsafe static float Dist(in FVector a, in FVector b)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_Dist(a, b);
				}
			}
		}

		// Token: 0x060005EC RID: 1516 RVA: 0x0000A1E4 File Offset: 0x000083E4
		public unsafe static float Distance(in FVector a, in FVector b)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_Distance(a, b);
				}
			}
		}

		// Token: 0x060005ED RID: 1517 RVA: 0x0000A200 File Offset: 0x00008400
		public unsafe static float DistXY(in FVector a, in FVector b)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_DistXY(a, b);
				}
			}
		}

		// Token: 0x060005EE RID: 1518 RVA: 0x0000A21C File Offset: 0x0000841C
		public unsafe static float Dist2D(in FVector a, in FVector b)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_Dist2D(a, b);
				}
			}
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x0000A238 File Offset: 0x00008438
		public unsafe static float DistSquared(in FVector a, in FVector b)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_DistSquared(a, b);
				}
			}
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x0000A254 File Offset: 0x00008454
		public unsafe static float DistSquaredXY(in FVector a, in FVector b)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_DistSquaredXY(a, b);
				}
			}
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x0000A270 File Offset: 0x00008470
		public unsafe static float DistSquared2D(in FVector a, in FVector b)
		{
			fixed (FVector* ptr = &a)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_DistSquared2D(a, b);
				}
			}
		}

		// Token: 0x060005F2 RID: 1522 RVA: 0x0000A28C File Offset: 0x0000848C
		public unsafe static float BoxPushOut(in FVector normal, in FVector size)
		{
			fixed (FVector* ptr = &normal)
			{
				fixed (FVector* ptr2 = &size)
				{
					return FVector.Internal_BoxPushOut(normal, size);
				}
			}
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x0000A2A8 File Offset: 0x000084A8
		public unsafe static bool Parallel(in FVector normal1, in FVector normal2, float parallelCosineThreshold = 0.999845f)
		{
			fixed (FVector* ptr = &normal1)
			{
				fixed (FVector* ptr2 = &normal2)
				{
					return FVector.Internal_Parallel(normal1, normal2, parallelCosineThreshold);
				}
			}
		}

		// Token: 0x060005F4 RID: 1524 RVA: 0x0000A2C8 File Offset: 0x000084C8
		public unsafe static bool Coincident(in FVector normal1, in FVector normal2, float parallelCosineThreshold = 0.999845f)
		{
			fixed (FVector* ptr = &normal1)
			{
				fixed (FVector* ptr2 = &normal2)
				{
					return FVector.Internal_Coincident(normal1, normal2, parallelCosineThreshold);
				}
			}
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x0000A2E8 File Offset: 0x000084E8
		public unsafe static bool Orthogonal(in FVector normal1, in FVector normal2, float parallelCosineThreshold = 0.999845f)
		{
			fixed (FVector* ptr = &normal1)
			{
				fixed (FVector* ptr2 = &normal2)
				{
					return FVector.Internal_Orthogonal(normal1, normal2, parallelCosineThreshold);
				}
			}
		}

		// Token: 0x060005F6 RID: 1526 RVA: 0x0000A308 File Offset: 0x00008508
		public unsafe static bool Coplanar(in FVector base1, in FVector normal1, in FVector base2, in FVector normal2, float parallelCosineThreshold = 0.999845f)
		{
			fixed (FVector* ptr = &base1)
			{
				fixed (FVector* ptr2 = &normal1)
				{
					fixed (FVector* ptr3 = &base2)
					{
						fixed (FVector* ptr4 = &normal2)
						{
							return FVector.Internal_Coplanar(base1, normal1, base2, normal2, parallelCosineThreshold);
						}
					}
				}
			}
		}

		// Token: 0x060005F7 RID: 1527 RVA: 0x0000A330 File Offset: 0x00008530
		public unsafe static float Triple(in FVector x, in FVector y, in FVector z)
		{
			fixed (FVector* ptr = &x)
			{
				fixed (FVector* ptr2 = &y)
				{
					fixed (FVector* ptr3 = &z)
					{
						return FVector.Internal_Triple(x, y, z);
					}
				}
			}
		}

		// Token: 0x060005F8 RID: 1528 RVA: 0x0000A354 File Offset: 0x00008554
		public unsafe static float EvaluateBezier(Span<FVector> controlPoints, [Nullable(1)] out TArray<FVector> outPoints)
		{
			SharpherealAssert.Assert(controlPoints.Length >= 2, "EvaluateBezier");
			outPoints = new TArray<FVector>();
			fixed (FVector* pinnableReference = controlPoints.GetPinnableReference())
			{
				return FVector.Internal_EvaluateBezier(pinnableReference, controlPoints.Length, outPoints._NativePtr);
			}
		}

		// Token: 0x060005F9 RID: 1529 RVA: 0x0000A39C File Offset: 0x0000859C
		public unsafe static FVector RadiansToDegrees(in FVector radVector)
		{
			fixed (FVector* ptr = &radVector)
			{
				return FVector.Internal_RadiansToDegrees(radVector);
			}
		}

		// Token: 0x060005FA RID: 1530 RVA: 0x0000A3B4 File Offset: 0x000085B4
		public unsafe static FVector DegreesToRadians(in FVector degVector)
		{
			fixed (FVector* ptr = &degVector)
			{
				return FVector.Internal_DegreesToRadians(degVector);
			}
		}

		// Token: 0x060005FB RID: 1531 RVA: 0x0000A3CC File Offset: 0x000085CC
		public unsafe static float ComputeSquaredDistanceFromBoxToPoint(in FVector mins, in FVector maxs, in FVector point)
		{
			fixed (FVector* ptr = &mins)
			{
				fixed (FVector* ptr2 = &maxs)
				{
					fixed (FVector* ptr3 = &point)
					{
						return FVector.Internal_ComputeSquaredDistanceFromBoxToPoint(mins, maxs, point);
					}
				}
			}
		}

		// Token: 0x060005FC RID: 1532 RVA: 0x0000A3F0 File Offset: 0x000085F0
		public unsafe static FVector ClampVector(in FVector v, in FVector min, in FVector max)
		{
			fixed (FVector* ptr = &v)
			{
				fixed (FVector* ptr2 = &min)
				{
					fixed (FVector* ptr3 = &max)
					{
						return FVector.Internal_ClampVector(v, min, max);
					}
				}
			}
		}

		// Token: 0x060005FD RID: 1533 RVA: 0x0000A414 File Offset: 0x00008614
		public unsafe readonly bool Equals(in FVector b, float tolerance = 0.0001f)
		{
			fixed (FVector* ptr = &this)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_Equals(this, b, tolerance);
				}
			}
		}

		// Token: 0x060005FE RID: 1534 RVA: 0x0000A434 File Offset: 0x00008634
		public unsafe readonly bool AllComponentsEqual(float tolerance = 0.0001f)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_AllComponentsEqual(this, tolerance);
			}
		}

		// Token: 0x060005FF RID: 1535 RVA: 0x0000A44C File Offset: 0x0000864C
		public unsafe readonly float GetComponentForAxis(EAxis axis)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetComponentForAxis(this, axis);
			}
		}

		// Token: 0x06000600 RID: 1536 RVA: 0x0000A464 File Offset: 0x00008664
		public unsafe void SetComponentForAxis(EAxis axis, float component)
		{
			fixed (FVector* ptr = &this)
			{
				FVector.Internal_SetComponentForAxis(ref this, axis, component);
			}
		}

		// Token: 0x06000601 RID: 1537 RVA: 0x0000A480 File Offset: 0x00008680
		public unsafe void Set(float x, float y, float z)
		{
			fixed (FVector* ptr = &this)
			{
				FVector.Internal_Set(ref this, x, y, z);
			}
		}

		// Token: 0x06000602 RID: 1538 RVA: 0x0000A4A0 File Offset: 0x000086A0
		public unsafe readonly float GetMax()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetMax(this);
			}
		}

		// Token: 0x06000603 RID: 1539 RVA: 0x0000A4B8 File Offset: 0x000086B8
		public unsafe readonly float GetAbsMax()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetAbsMax(this);
			}
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0000A4D0 File Offset: 0x000086D0
		public unsafe readonly float GetMin()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetMin(this);
			}
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0000A4E8 File Offset: 0x000086E8
		public unsafe readonly float GetAbsMin()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetAbsMin(this);
			}
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x0000A500 File Offset: 0x00008700
		public unsafe readonly FVector ComponentMin(in FVector b)
		{
			fixed (FVector* ptr = &this)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_ComponentMin(this, b);
				}
			}
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x0000A51C File Offset: 0x0000871C
		public unsafe readonly FVector ComponentMax(in FVector b)
		{
			fixed (FVector* ptr = &this)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_ComponentMax(this, b);
				}
			}
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0000A538 File Offset: 0x00008738
		public unsafe readonly FVector GetAbs()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetAbs(this);
			}
		}

		// Token: 0x06000609 RID: 1545 RVA: 0x0000A550 File Offset: 0x00008750
		public unsafe readonly float Size()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_Size(this);
			}
		}

		// Token: 0x0600060A RID: 1546 RVA: 0x0000A568 File Offset: 0x00008768
		public unsafe readonly float SizeSquared()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_SizeSquared(this);
			}
		}

		// Token: 0x0600060B RID: 1547 RVA: 0x0000A580 File Offset: 0x00008780
		public unsafe readonly float Size2D()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_Size2D(this);
			}
		}

		// Token: 0x0600060C RID: 1548 RVA: 0x0000A598 File Offset: 0x00008798
		public unsafe readonly float SizeSquared2D()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_SizeSquared2D(this);
			}
		}

		// Token: 0x0600060D RID: 1549 RVA: 0x0000A5B0 File Offset: 0x000087B0
		public unsafe readonly bool IsNearlyZero(float tolerance = 0.0001f)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_IsNearlyZero(this, tolerance);
			}
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x0000A5C8 File Offset: 0x000087C8
		public unsafe readonly bool IsZero()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_IsZero(this);
			}
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0000A5E0 File Offset: 0x000087E0
		public unsafe readonly bool IsUnit()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_IsUnit(this);
			}
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x0000A5F8 File Offset: 0x000087F8
		public unsafe readonly bool IsNormalized()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_IsNormalized(this);
			}
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0000A610 File Offset: 0x00008810
		public unsafe void Normalize(float tolerance = 1E-08f)
		{
			fixed (FVector* ptr = &this)
			{
				FVector.Internal_Normalize(ref this, tolerance);
			}
		}

		// Token: 0x06000612 RID: 1554 RVA: 0x0000A62C File Offset: 0x0000882C
		public unsafe readonly FVector GetUnsafeNormal()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetUnsafeNormal(this);
			}
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x0000A644 File Offset: 0x00008844
		public unsafe readonly FVector GetSafeNormal(float tolerance = 1E-08f)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetSafeNormal(this, tolerance);
			}
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x0000A65C File Offset: 0x0000885C
		public unsafe readonly FVector GetSafeNormal2D(float tolerance = 1E-08f)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetSafeNormal2D(this, tolerance);
			}
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x0000A674 File Offset: 0x00008874
		public unsafe readonly void ToDirectionAndLength(out FVector outDirection, out float outLength)
		{
			fixed (FVector* ptr = &this)
			{
				fixed (FVector* ptr2 = &outDirection)
				{
					fixed (float* ptr3 = &outLength)
					{
						FVector.Internal_ToDirectionAndLength(this, out outDirection, out outLength);
					}
				}
			}
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x0000A6A0 File Offset: 0x000088A0
		public unsafe readonly FVector GetSignVector()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetSignVector(this);
			}
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x0000A6B8 File Offset: 0x000088B8
		public unsafe readonly FVector Projection()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_Projection(this);
			}
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x0000A6D0 File Offset: 0x000088D0
		public unsafe readonly FVector GetUnsafeNormal2D()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetUnsafeNormal2D(this);
			}
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x0000A6E8 File Offset: 0x000088E8
		public unsafe readonly FVector GridSnap(float gridSz)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GridSnap(this, gridSz);
			}
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x0000A700 File Offset: 0x00008900
		public unsafe readonly FVector BoundToCube(float radius)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_BoundToCube(this, radius);
			}
		}

		// Token: 0x0600061B RID: 1563 RVA: 0x0000A718 File Offset: 0x00008918
		public unsafe readonly FVector BoundToBox(in FVector min, in FVector max)
		{
			fixed (FVector* ptr = &this)
			{
				fixed (FVector* ptr2 = &min)
				{
					fixed (FVector* ptr3 = &max)
					{
						return FVector.Internal_BoundToBox(this, min, max);
					}
				}
			}
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x0000A73C File Offset: 0x0000893C
		public unsafe readonly FVector GetClampedToSize(float min, float max)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetClampedToSize(this, min, max);
			}
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x0000A758 File Offset: 0x00008958
		public unsafe readonly FVector GetClampedToSize2D(float min, float max)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetClampedToSize2D(this, min, max);
			}
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x0000A774 File Offset: 0x00008974
		public unsafe readonly FVector GetClampedToMaxSize(float maxSize)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetClampedToMaxSize(this, maxSize);
			}
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x0000A78C File Offset: 0x0000898C
		public unsafe readonly FVector GetClampedToMaxSize2D(float maxSize)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetClampedToMaxSize2D(this, maxSize);
			}
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x0000A7A4 File Offset: 0x000089A4
		public unsafe void AddBounded(in FVector v, float radius = 32767f)
		{
			fixed (FVector* ptr = &this)
			{
				fixed (FVector* ptr2 = &v)
				{
					FVector.Internal_AddBounded(ref this, v, radius);
				}
			}
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x0000A7C8 File Offset: 0x000089C8
		public unsafe readonly FVector Reciprocal()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_Reciprocal(this);
			}
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x0000A7E0 File Offset: 0x000089E0
		public unsafe readonly bool IsUniform(float tolerance = 0.0001f)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_IsUniform(this, tolerance);
			}
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x0000A7F8 File Offset: 0x000089F8
		public unsafe readonly FVector MirrorByVector(in FVector mirrorNormal)
		{
			fixed (FVector* ptr = &this)
			{
				fixed (FVector* ptr2 = &mirrorNormal)
				{
					return FVector.Internal_MirrorByVector(this, mirrorNormal);
				}
			}
		}

		// Token: 0x06000624 RID: 1572 RVA: 0x0000A814 File Offset: 0x00008A14
		public unsafe readonly FVector MirrorByPlane(in FPlane plane)
		{
			fixed (FVector* ptr = &this)
			{
				fixed (FPlane* ptr2 = &plane)
				{
					return FVector.Internal_MirrorByPlane(this, plane);
				}
			}
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x0000A830 File Offset: 0x00008A30
		public unsafe readonly FVector RotateAngleAxis(float angleDeg, in FVector axis)
		{
			fixed (FVector* ptr = &this)
			{
				fixed (FVector* ptr2 = &axis)
				{
					return FVector.Internal_RotateAngleAxis(this, angleDeg, axis);
				}
			}
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x0000A850 File Offset: 0x00008A50
		public unsafe readonly float CosineAngle2D(in FVector b)
		{
			fixed (FVector* ptr = &this)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_CosineAngle2D(this, b);
				}
			}
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x0000A86C File Offset: 0x00008A6C
		public unsafe readonly FVector ProjectOnTo(in FVector b)
		{
			fixed (FVector* ptr = &this)
			{
				fixed (FVector* ptr2 = &b)
				{
					return FVector.Internal_ProjectOnTo(this, b);
				}
			}
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x0000A888 File Offset: 0x00008A88
		public unsafe readonly FVector ProjectOnToNormal(in FVector normal)
		{
			fixed (FVector* ptr = &this)
			{
				fixed (FVector* ptr2 = &normal)
				{
					return FVector.Internal_ProjectOnToNormal(this, normal);
				}
			}
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0000A8A4 File Offset: 0x00008AA4
		public unsafe readonly FRotator ToOrientationRotator()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_ToOrientationRotator(this);
			}
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x0000A8BC File Offset: 0x00008ABC
		public unsafe readonly FQuat ToOrientationQuat()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_ToOrientationQuat(this);
			}
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x0000A8D4 File Offset: 0x00008AD4
		public unsafe readonly FRotator Rotation()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_Rotation(this);
			}
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x0000A8EC File Offset: 0x00008AEC
		public unsafe readonly void FindBestAxisVectors(out FVector outAxis1, out FVector outAxis2)
		{
			fixed (FVector* ptr = &this)
			{
				fixed (FVector* ptr2 = &outAxis1)
				{
					fixed (FVector* ptr3 = &outAxis2)
					{
						FVector.Internal_FindBestAxisVectors(this, out outAxis1, out outAxis2);
					}
				}
			}
		}

		// Token: 0x0600062D RID: 1581 RVA: 0x0000A918 File Offset: 0x00008B18
		public unsafe void UnwindEuler()
		{
			fixed (FVector* ptr = &this)
			{
				FVector.Internal_UnwindEuler(ref this);
			}
		}

		// Token: 0x0600062E RID: 1582 RVA: 0x0000A934 File Offset: 0x00008B34
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x0600062F RID: 1583 RVA: 0x0000A94C File Offset: 0x00008B4C
		public unsafe readonly FVector2D UnitCartesianToSpherical()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_UnitCartesianToSpherical(this);
			}
		}

		// Token: 0x06000630 RID: 1584 RVA: 0x0000A964 File Offset: 0x00008B64
		public unsafe readonly float HeadingAngle()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_HeadingAngle(this);
			}
		}

		// Token: 0x06000631 RID: 1585 RVA: 0x0000A97C File Offset: 0x00008B7C
		[NullableContext(2)]
		public unsafe void InitFromString(string str)
		{
			if (str == null || str.Length == 0)
			{
				this.X = (this.Y = (this.Z = 0f));
				return;
			}
			fixed (FVector* ptr = &this)
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
				FVector.Internal_InitFromString(ref this, fcsharpStringView);
				char* ptr3 = null;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000632 RID: 1586 RVA: 0x0000A9E3 File Offset: 0x00008BE3
		// (set) Token: 0x06000633 RID: 1587 RVA: 0x0000A9EC File Offset: 0x00008BEC
		double IVector2D.X
		{
			get
			{
				return (double)this.X;
			}
			set
			{
				this.X = (float)value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000634 RID: 1588 RVA: 0x0000A9F6 File Offset: 0x00008BF6
		// (set) Token: 0x06000635 RID: 1589 RVA: 0x0000A9FF File Offset: 0x00008BFF
		double IVector2D.Y
		{
			get
			{
				return (double)this.Y;
			}
			set
			{
				this.Y = (float)value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000636 RID: 1590 RVA: 0x0000AA09 File Offset: 0x00008C09
		// (set) Token: 0x06000637 RID: 1591 RVA: 0x0000AA12 File Offset: 0x00008C12
		double IVector.Z
		{
			get
			{
				return (double)this.Z;
			}
			set
			{
				this.Z = (float)value;
			}
		}

		// Token: 0x06000638 RID: 1592 RVA: 0x0000AA1C File Offset: 0x00008C1C
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVector._ScriptStructPtr != 0) ? FVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Vector", ref FVector._ScriptStructPtr);
		}

		// Token: 0x040000C2 RID: 194
		public static readonly FVector ZeroVector = new FVector(0f, 0f, 0f);

		// Token: 0x040000C3 RID: 195
		public static readonly FVector OneVector = new FVector(1f, 1f, 1f);

		// Token: 0x040000C4 RID: 196
		public static readonly FVector UpVector = new FVector(0f, 0f, 1f);

		// Token: 0x040000C5 RID: 197
		public static readonly FVector DownVector = new FVector(0f, 0f, -1f);

		// Token: 0x040000C6 RID: 198
		public static readonly FVector ForwardVector = new FVector(1f, 0f, 0f);

		// Token: 0x040000C7 RID: 199
		public static readonly FVector BackwardVector = new FVector(-1f, 0f, 0f);

		// Token: 0x040000C8 RID: 200
		public static readonly FVector RightVector = new FVector(0f, 1f, 0f);

		// Token: 0x040000C9 RID: 201
		public static readonly FVector LeftVector = new FVector(0f, -1f, 0f);

		// Token: 0x040000CA RID: 202
		public static readonly FVector XAxisVector = new FVector(1f, 0f, 0f);

		// Token: 0x040000CB RID: 203
		public static readonly FVector YAxisVector = new FVector(0f, 1f, 0f);

		// Token: 0x040000CC RID: 204
		public static readonly FVector ZAxisVector = new FVector(0f, 0f, 1f);

		// Token: 0x040000CD RID: 205
		[FieldOffset(0)]
		public float X;

		// Token: 0x040000CE RID: 206
		[FieldOffset(4)]
		public float Y;

		// Token: 0x040000CF RID: 207
		[FieldOffset(8)]
		public float Z;

		// Token: 0x040000D0 RID: 208
		public const string __ObjectPath = "/Script/CoreUObject.Vector";

		// Token: 0x040000D1 RID: 209
		private static IntPtr _ScriptStructPtr;
	}
}
