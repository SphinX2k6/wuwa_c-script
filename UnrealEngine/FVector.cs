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
	// Token: 0x02000040 RID: 64
	[HasGetTypeHash]
	[UnrealBlittableStruct(UnrealReflectionPropertyTypeCode.UnrealBlittableStruct)]
	[UnrealStructLayout(12, 4, UnrealReflectionPropertyTypeCode.UnrealBlittableStruct, PropertiesSize = 12)]
	[UnrealObjectPath("/Script/CoreUObject.Vector")]
	[StructLayout(LayoutKind.Explicit, Pack = 4, Size = 12)]
	public struct FVector : IEquatable<FVector>, IEqualityOperators<FVector, FVector, bool>, IVector, IVector2D, IUnrealScriptStruct
	{
		// Token: 0x060005D4 RID: 1492 RVA: 0x0000D34D File Offset: 0x0000B54D
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

		// Token: 0x060005D5 RID: 1493 RVA: 0x0000D383 File Offset: 0x0000B583
		public FVector()
		{
			this.X = 0f;
			this.Y = 0f;
			this.Z = 0f;
		}

		// Token: 0x060005D6 RID: 1494 RVA: 0x0000D3A6 File Offset: 0x0000B5A6
		public FVector(float inF)
		{
			this = new FVector(inF, inF, inF);
		}

		// Token: 0x060005D7 RID: 1495 RVA: 0x0000D3B1 File Offset: 0x0000B5B1
		public FVector(float inX, float inY)
		{
			this = new FVector(inX, inY, 0f);
		}

		// Token: 0x060005D8 RID: 1496 RVA: 0x0000D3C0 File Offset: 0x0000B5C0
		public FVector(in FVector2D v, float inZ = 0f)
		{
			this = new FVector(v.X, v.Y, inZ);
		}

		// Token: 0x060005D9 RID: 1497 RVA: 0x0000D3D5 File Offset: 0x0000B5D5
		public FVector(in FVector4 v)
		{
			this = new FVector(v.X, v.Y, v.Z);
		}

		// Token: 0x060005DA RID: 1498 RVA: 0x0000D3EF File Offset: 0x0000B5EF
		public FVector(in FLinearColor v)
		{
			this = new FVector(v.R, v.G, v.B);
		}

		// Token: 0x060005DB RID: 1499 RVA: 0x0000D409 File Offset: 0x0000B609
		public FVector(in FIntVector v)
		{
			this = new FVector((float)v.X, (float)v.Y, (float)v.Z);
		}

		// Token: 0x060005DC RID: 1500 RVA: 0x0000D426 File Offset: 0x0000B626
		public FVector(in FIntPoint v)
		{
			this = new FVector((float)v.X, (float)v.Y, 0f);
		}

		// Token: 0x060005DD RID: 1501 RVA: 0x0000D441 File Offset: 0x0000B641
		public Span<float> AsSpan()
		{
			return new Span<float>(Unsafe.AsPointer<FVector>(ref this), sizeof(FVector) / 4);
		}

		// Token: 0x060005DE RID: 1502 RVA: 0x0000D456 File Offset: 0x0000B656
		public static implicit operator FVector(in FVector4 a)
		{
			return new FVector(a.X, a.Y, a.Z);
		}

		// Token: 0x060005DF RID: 1503 RVA: 0x0000D46F File Offset: 0x0000B66F
		public static implicit operator FVector(in FVector2D a)
		{
			return new FVector(a.X, a.Y, 0f);
		}

		// Token: 0x060005E0 RID: 1504 RVA: 0x0000D487 File Offset: 0x0000B687
		public static implicit operator FVector(in FPlane a)
		{
			return new FVector(a.X, a.Y, a.Z);
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0000D4A0 File Offset: 0x0000B6A0
		public static FVector operator *(float scale, in FVector v)
		{
			return v * scale;
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x0000D4A9 File Offset: 0x0000B6A9
		public static FVector operator -(in FVector v)
		{
			return new FVector(-v.X, -v.Y, -v.Z);
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0000D4C5 File Offset: 0x0000B6C5
		public static bool operator ==(FVector a, FVector b)
		{
			return a.X == b.X && a.Y == b.Y && a.Z == b.Z;
		}

		// Token: 0x060005E4 RID: 1508 RVA: 0x0000D4F3 File Offset: 0x0000B6F3
		public static bool operator !=(FVector a, FVector b)
		{
			return a.X != b.X || a.Y != b.Y || a.Z != b.Z;
		}

		// Token: 0x060005E5 RID: 1509 RVA: 0x0000D524 File Offset: 0x0000B724
		public readonly bool Equals(FVector other)
		{
			return this == other;
		}

		// Token: 0x060005E6 RID: 1510 RVA: 0x0000D534 File Offset: 0x0000B734
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

		// Token: 0x060005E7 RID: 1511 RVA: 0x0000D55E File Offset: 0x0000B75E
		public override readonly int GetHashCode()
		{
			return HashCode.Combine<float, float, float>(this.X, this.Y, this.Z);
		}

		// Token: 0x17000017 RID: 23
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

		// Token: 0x060005EA RID: 1514 RVA: 0x0000D5EE File Offset: 0x0000B7EE
		public readonly float Component(int index)
		{
			return this[index];
		}

		// Token: 0x060005EB RID: 1515 RVA: 0x0000D5F8 File Offset: 0x0000B7F8
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

		// Token: 0x060005EC RID: 1516 RVA: 0x0000D660 File Offset: 0x0000B860
		[NullableContext(1)]
		public readonly FText ToText()
		{
			return new FText(this.ToString());
		}

		// Token: 0x060005ED RID: 1517
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Ctor(float x, float y, float z);

		// Token: 0x060005EE RID: 1518
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Add(in FVector a, in FVector b);

		// Token: 0x060005EF RID: 1519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_AddFloat(in FVector a, float bias);

		// Token: 0x060005F0 RID: 1520
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Sub(in FVector a, in FVector b);

		// Token: 0x060005F1 RID: 1521
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_SubFloat(in FVector a, float bias);

		// Token: 0x060005F2 RID: 1522
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Mul(in FVector a, in FVector b);

		// Token: 0x060005F3 RID: 1523
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_MulFloat(in FVector a, float scale);

		// Token: 0x060005F4 RID: 1524
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Div(in FVector a, in FVector b);

		// Token: 0x060005F5 RID: 1525
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_DivFloat(in FVector a, float scale);

		// Token: 0x060005F6 RID: 1526
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Or(in FVector a, in FVector b);

		// Token: 0x060005F7 RID: 1527
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Xor(in FVector a, in FVector b);

		// Token: 0x060005F8 RID: 1528
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Min(in FVector a, in FVector b);

		// Token: 0x060005F9 RID: 1529
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Max(in FVector a, in FVector b);

		// Token: 0x060005FA RID: 1530
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Min3(in FVector a, in FVector b, in FVector c);

		// Token: 0x060005FB RID: 1531
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Max3(in FVector a, in FVector b, in FVector c);

		// Token: 0x060005FC RID: 1532
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_DotProduct(in FVector a, in FVector b);

		// Token: 0x060005FD RID: 1533
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_CrossProduct(in FVector a, in FVector b);

		// Token: 0x060005FE RID: 1534
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_CreateOrthonormalBasis(ref FVector a, ref FVector b, ref FVector c);

		// Token: 0x060005FF RID: 1535
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_PointsAreSame(in FVector a, in FVector b);

		// Token: 0x06000600 RID: 1536
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_PointsAreNear(in FVector a, in FVector b, float dist);

		// Token: 0x06000601 RID: 1537
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_PointPlaneDist(in FVector point, in FVector planeBase, in FVector planeNormal);

		// Token: 0x06000602 RID: 1538
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_PointPlaneProject_Plane(in FVector point, in FPlane plane);

		// Token: 0x06000603 RID: 1539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_PointPlaneProject_abc(in FVector point, in FVector a, in FVector b, in FVector c);

		// Token: 0x06000604 RID: 1540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_PointPlaneProject_base_normal(in FVector point, in FVector planeBase, in FVector planeNormal);

		// Token: 0x06000605 RID: 1541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_VectorPlaneProject(in FVector v, in FVector planeNormal);

		// Token: 0x06000606 RID: 1542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Dist(in FVector a, in FVector b);

		// Token: 0x06000607 RID: 1543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Distance(in FVector a, in FVector b);

		// Token: 0x06000608 RID: 1544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_DistXY(in FVector a, in FVector b);

		// Token: 0x06000609 RID: 1545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Dist2D(in FVector a, in FVector b);

		// Token: 0x0600060A RID: 1546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_DistSquared(in FVector a, in FVector b);

		// Token: 0x0600060B RID: 1547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_DistSquaredXY(in FVector a, in FVector b);

		// Token: 0x0600060C RID: 1548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_DistSquared2D(in FVector a, in FVector b);

		// Token: 0x0600060D RID: 1549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_BoxPushOut(in FVector normal, in FVector size);

		// Token: 0x0600060E RID: 1550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Parallel(in FVector normal1, in FVector normal2, float parallelCosineThreshold = 0.999845f);

		// Token: 0x0600060F RID: 1551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Coincident(in FVector normal1, in FVector normal2, float parallelCosineThreshold = 0.999845f);

		// Token: 0x06000610 RID: 1552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Orthogonal(in FVector normal1, in FVector normal2, float parallelCosineThreshold = 0.999845f);

		// Token: 0x06000611 RID: 1553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Coplanar(in FVector base1, in FVector normal1, in FVector base2, in FVector normal2, float parallelCosineThreshold = 0.999845f);

		// Token: 0x06000612 RID: 1554
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Triple(in FVector x, in FVector y, in FVector z);

		// Token: 0x06000613 RID: 1555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern float Internal_EvaluateBezier(FVector* controlPoints, int controlPointsCount, IntPtr outPoints);

		// Token: 0x06000614 RID: 1556
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_RadiansToDegrees(in FVector radVector);

		// Token: 0x06000615 RID: 1557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_DegreesToRadians(in FVector degVector);

		// Token: 0x06000616 RID: 1558
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_ComputeSquaredDistanceFromBoxToPoint(in FVector mins, in FVector maxs, in FVector point);

		// Token: 0x06000617 RID: 1559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_ClampVector(in FVector v, in FVector min, in FVector max);

		// Token: 0x06000618 RID: 1560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_Equals(in FVector a, in FVector b, float tolerance = 0.0001f);

		// Token: 0x06000619 RID: 1561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_AllComponentsEqual(in FVector a, float tolerance = 0.0001f);

		// Token: 0x0600061A RID: 1562
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetComponentForAxis(in FVector a, EAxis axis);

		// Token: 0x0600061B RID: 1563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_SetComponentForAxis(ref FVector a, EAxis axis, float component);

		// Token: 0x0600061C RID: 1564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Set(ref FVector a, float x, float y, float z);

		// Token: 0x0600061D RID: 1565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetMax(in FVector a);

		// Token: 0x0600061E RID: 1566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetAbsMax(in FVector a);

		// Token: 0x0600061F RID: 1567
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetMin(in FVector a);

		// Token: 0x06000620 RID: 1568
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_GetAbsMin(in FVector a);

		// Token: 0x06000621 RID: 1569
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_ComponentMin(in FVector a, in FVector b);

		// Token: 0x06000622 RID: 1570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_ComponentMax(in FVector a, in FVector b);

		// Token: 0x06000623 RID: 1571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetAbs(in FVector a);

		// Token: 0x06000624 RID: 1572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Size(in FVector a);

		// Token: 0x06000625 RID: 1573
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_SizeSquared(in FVector a);

		// Token: 0x06000626 RID: 1574
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_Size2D(in FVector a);

		// Token: 0x06000627 RID: 1575
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_SizeSquared2D(in FVector a);

		// Token: 0x06000628 RID: 1576
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsNearlyZero(in FVector a, float tolerance = 0.0001f);

		// Token: 0x06000629 RID: 1577
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsZero(in FVector a);

		// Token: 0x0600062A RID: 1578
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsUnit(in FVector a);

		// Token: 0x0600062B RID: 1579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsNormalized(in FVector a);

		// Token: 0x0600062C RID: 1580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_Normalize(ref FVector a, float tolerance = 1E-08f);

		// Token: 0x0600062D RID: 1581
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetUnsafeNormal(in FVector a);

		// Token: 0x0600062E RID: 1582
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetSafeNormal(in FVector a, float tolerance = 1E-08f);

		// Token: 0x0600062F RID: 1583
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetSafeNormal2D(in FVector a, float tolerance = 1E-08f);

		// Token: 0x06000630 RID: 1584
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_ToDirectionAndLength(in FVector a, out FVector outDirection, out float outLength);

		// Token: 0x06000631 RID: 1585
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetSignVector(in FVector a);

		// Token: 0x06000632 RID: 1586
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Projection(in FVector a);

		// Token: 0x06000633 RID: 1587
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetUnsafeNormal2D(in FVector a);

		// Token: 0x06000634 RID: 1588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GridSnap(in FVector a, float gridSz);

		// Token: 0x06000635 RID: 1589
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_BoundToCube(in FVector a, float radius);

		// Token: 0x06000636 RID: 1590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_BoundToBox(in FVector a, in FVector min, in FVector max);

		// Token: 0x06000637 RID: 1591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetClampedToSize(in FVector a, float min, float max);

		// Token: 0x06000638 RID: 1592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetClampedToSize2D(in FVector a, float min, float max);

		// Token: 0x06000639 RID: 1593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetClampedToMaxSize(in FVector a, float maxSize);

		// Token: 0x0600063A RID: 1594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_GetClampedToMaxSize2D(in FVector a, float maxSize);

		// Token: 0x0600063B RID: 1595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_AddBounded(ref FVector a, in FVector v, float radius = 32767f);

		// Token: 0x0600063C RID: 1596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_Reciprocal(in FVector a);

		// Token: 0x0600063D RID: 1597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_IsUniform(in FVector a, float tolerance = 0.0001f);

		// Token: 0x0600063E RID: 1598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_MirrorByVector(in FVector a, in FVector mirrorNormal);

		// Token: 0x0600063F RID: 1599
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_MirrorByPlane(in FVector a, in FPlane plane);

		// Token: 0x06000640 RID: 1600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_RotateAngleAxis(in FVector a, float angleDeg, in FVector axis);

		// Token: 0x06000641 RID: 1601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_CosineAngle2D(in FVector a, in FVector b);

		// Token: 0x06000642 RID: 1602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_ProjectOnTo(in FVector a, in FVector b);

		// Token: 0x06000643 RID: 1603
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector Internal_ProjectOnToNormal(in FVector a, in FVector normal);

		// Token: 0x06000644 RID: 1604
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_ToOrientationRotator(in FVector a);

		// Token: 0x06000645 RID: 1605
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat Internal_ToOrientationQuat(in FVector a);

		// Token: 0x06000646 RID: 1606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator Internal_Rotation(in FVector a);

		// Token: 0x06000647 RID: 1607
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_FindBestAxisVectors(in FVector a, out FVector outAxis1, out FVector outAxis2);

		// Token: 0x06000648 RID: 1608
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_UnwindEuler(ref FVector a);

		// Token: 0x06000649 RID: 1609
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool Internal_ContainsNaN(in FVector a);

		// Token: 0x0600064A RID: 1610
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D Internal_UnitCartesianToSpherical(in FVector a);

		// Token: 0x0600064B RID: 1611
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float Internal_HeadingAngle(in FVector a);

		// Token: 0x0600064C RID: 1612
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void Internal_InitFromString(ref FVector a, in FCSharpStringView str);

		// Token: 0x0600064D RID: 1613 RVA: 0x0000D673 File Offset: 0x0000B873
		public FVector(float inX, float inY, float inZ)
		{
			this.X = inX;
			this.Y = inY;
			this.Z = inZ;
		}

		// Token: 0x0600064E RID: 1614 RVA: 0x0000D68C File Offset: 0x0000B88C
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

		// Token: 0x0600064F RID: 1615 RVA: 0x0000D6A8 File Offset: 0x0000B8A8
		public unsafe static FVector operator +(in FVector a, float bias)
		{
			fixed (FVector* ptr = &a)
			{
				return FVector.Internal_AddFloat(a, bias);
			}
		}

		// Token: 0x06000650 RID: 1616 RVA: 0x0000D6C0 File Offset: 0x0000B8C0
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

		// Token: 0x06000651 RID: 1617 RVA: 0x0000D6DC File Offset: 0x0000B8DC
		public unsafe static FVector operator -(in FVector a, float bias)
		{
			fixed (FVector* ptr = &a)
			{
				return FVector.Internal_SubFloat(a, bias);
			}
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x0000D6F4 File Offset: 0x0000B8F4
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

		// Token: 0x06000653 RID: 1619 RVA: 0x0000D710 File Offset: 0x0000B910
		public unsafe static FVector operator *(in FVector a, float scale)
		{
			fixed (FVector* ptr = &a)
			{
				return FVector.Internal_MulFloat(a, scale);
			}
		}

		// Token: 0x06000654 RID: 1620 RVA: 0x0000D728 File Offset: 0x0000B928
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

		// Token: 0x06000655 RID: 1621 RVA: 0x0000D744 File Offset: 0x0000B944
		public unsafe static FVector operator /(in FVector a, float scale)
		{
			fixed (FVector* ptr = &a)
			{
				return FVector.Internal_DivFloat(a, scale);
			}
		}

		// Token: 0x06000656 RID: 1622 RVA: 0x0000D75C File Offset: 0x0000B95C
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

		// Token: 0x06000657 RID: 1623 RVA: 0x0000D778 File Offset: 0x0000B978
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

		// Token: 0x06000658 RID: 1624 RVA: 0x0000D794 File Offset: 0x0000B994
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

		// Token: 0x06000659 RID: 1625 RVA: 0x0000D7B0 File Offset: 0x0000B9B0
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

		// Token: 0x0600065A RID: 1626 RVA: 0x0000D7CC File Offset: 0x0000B9CC
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

		// Token: 0x0600065B RID: 1627 RVA: 0x0000D7F0 File Offset: 0x0000B9F0
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

		// Token: 0x0600065C RID: 1628 RVA: 0x0000D814 File Offset: 0x0000BA14
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

		// Token: 0x0600065D RID: 1629 RVA: 0x0000D830 File Offset: 0x0000BA30
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

		// Token: 0x0600065E RID: 1630 RVA: 0x0000D84C File Offset: 0x0000BA4C
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

		// Token: 0x0600065F RID: 1631 RVA: 0x0000D878 File Offset: 0x0000BA78
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

		// Token: 0x06000660 RID: 1632 RVA: 0x0000D894 File Offset: 0x0000BA94
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

		// Token: 0x06000661 RID: 1633 RVA: 0x0000D8B4 File Offset: 0x0000BAB4
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

		// Token: 0x06000662 RID: 1634 RVA: 0x0000D8D8 File Offset: 0x0000BAD8
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

		// Token: 0x06000663 RID: 1635 RVA: 0x0000D8F4 File Offset: 0x0000BAF4
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

		// Token: 0x06000664 RID: 1636 RVA: 0x0000D91C File Offset: 0x0000BB1C
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

		// Token: 0x06000665 RID: 1637 RVA: 0x0000D940 File Offset: 0x0000BB40
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

		// Token: 0x06000666 RID: 1638 RVA: 0x0000D95C File Offset: 0x0000BB5C
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

		// Token: 0x06000667 RID: 1639 RVA: 0x0000D978 File Offset: 0x0000BB78
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

		// Token: 0x06000668 RID: 1640 RVA: 0x0000D994 File Offset: 0x0000BB94
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

		// Token: 0x06000669 RID: 1641 RVA: 0x0000D9B0 File Offset: 0x0000BBB0
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

		// Token: 0x0600066A RID: 1642 RVA: 0x0000D9CC File Offset: 0x0000BBCC
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

		// Token: 0x0600066B RID: 1643 RVA: 0x0000D9E8 File Offset: 0x0000BBE8
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

		// Token: 0x0600066C RID: 1644 RVA: 0x0000DA04 File Offset: 0x0000BC04
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

		// Token: 0x0600066D RID: 1645 RVA: 0x0000DA20 File Offset: 0x0000BC20
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

		// Token: 0x0600066E RID: 1646 RVA: 0x0000DA3C File Offset: 0x0000BC3C
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

		// Token: 0x0600066F RID: 1647 RVA: 0x0000DA5C File Offset: 0x0000BC5C
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

		// Token: 0x06000670 RID: 1648 RVA: 0x0000DA7C File Offset: 0x0000BC7C
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

		// Token: 0x06000671 RID: 1649 RVA: 0x0000DA9C File Offset: 0x0000BC9C
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

		// Token: 0x06000672 RID: 1650 RVA: 0x0000DAC4 File Offset: 0x0000BCC4
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

		// Token: 0x06000673 RID: 1651 RVA: 0x0000DAE8 File Offset: 0x0000BCE8
		public unsafe static float EvaluateBezier(Span<FVector> controlPoints, [Nullable(1)] out TArray<FVector> outPoints)
		{
			SharpherealAssert.Assert(controlPoints.Length >= 2, "EvaluateBezier");
			outPoints = new TArray<FVector>();
			fixed (FVector* pinnableReference = controlPoints.GetPinnableReference())
			{
				return FVector.Internal_EvaluateBezier(pinnableReference, controlPoints.Length, outPoints._NativePtr);
			}
		}

		// Token: 0x06000674 RID: 1652 RVA: 0x0000DB30 File Offset: 0x0000BD30
		public unsafe static FVector RadiansToDegrees(in FVector radVector)
		{
			fixed (FVector* ptr = &radVector)
			{
				return FVector.Internal_RadiansToDegrees(radVector);
			}
		}

		// Token: 0x06000675 RID: 1653 RVA: 0x0000DB48 File Offset: 0x0000BD48
		public unsafe static FVector DegreesToRadians(in FVector degVector)
		{
			fixed (FVector* ptr = &degVector)
			{
				return FVector.Internal_DegreesToRadians(degVector);
			}
		}

		// Token: 0x06000676 RID: 1654 RVA: 0x0000DB60 File Offset: 0x0000BD60
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

		// Token: 0x06000677 RID: 1655 RVA: 0x0000DB84 File Offset: 0x0000BD84
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

		// Token: 0x06000678 RID: 1656 RVA: 0x0000DBA8 File Offset: 0x0000BDA8
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

		// Token: 0x06000679 RID: 1657 RVA: 0x0000DBC8 File Offset: 0x0000BDC8
		public unsafe readonly bool AllComponentsEqual(float tolerance = 0.0001f)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_AllComponentsEqual(this, tolerance);
			}
		}

		// Token: 0x0600067A RID: 1658 RVA: 0x0000DBE0 File Offset: 0x0000BDE0
		public unsafe readonly float GetComponentForAxis(EAxis axis)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetComponentForAxis(this, axis);
			}
		}

		// Token: 0x0600067B RID: 1659 RVA: 0x0000DBF8 File Offset: 0x0000BDF8
		public unsafe void SetComponentForAxis(EAxis axis, float component)
		{
			fixed (FVector* ptr = &this)
			{
				FVector.Internal_SetComponentForAxis(ref this, axis, component);
			}
		}

		// Token: 0x0600067C RID: 1660 RVA: 0x0000DC14 File Offset: 0x0000BE14
		public unsafe void Set(float x, float y, float z)
		{
			fixed (FVector* ptr = &this)
			{
				FVector.Internal_Set(ref this, x, y, z);
			}
		}

		// Token: 0x0600067D RID: 1661 RVA: 0x0000DC34 File Offset: 0x0000BE34
		public unsafe readonly float GetMax()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetMax(this);
			}
		}

		// Token: 0x0600067E RID: 1662 RVA: 0x0000DC4C File Offset: 0x0000BE4C
		public unsafe readonly float GetAbsMax()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetAbsMax(this);
			}
		}

		// Token: 0x0600067F RID: 1663 RVA: 0x0000DC64 File Offset: 0x0000BE64
		public unsafe readonly float GetMin()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetMin(this);
			}
		}

		// Token: 0x06000680 RID: 1664 RVA: 0x0000DC7C File Offset: 0x0000BE7C
		public unsafe readonly float GetAbsMin()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetAbsMin(this);
			}
		}

		// Token: 0x06000681 RID: 1665 RVA: 0x0000DC94 File Offset: 0x0000BE94
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

		// Token: 0x06000682 RID: 1666 RVA: 0x0000DCB0 File Offset: 0x0000BEB0
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

		// Token: 0x06000683 RID: 1667 RVA: 0x0000DCCC File Offset: 0x0000BECC
		public unsafe readonly FVector GetAbs()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetAbs(this);
			}
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0000DCE4 File Offset: 0x0000BEE4
		public unsafe readonly float Size()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_Size(this);
			}
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0000DCFC File Offset: 0x0000BEFC
		public unsafe readonly float SizeSquared()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_SizeSquared(this);
			}
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0000DD14 File Offset: 0x0000BF14
		public unsafe readonly float Size2D()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_Size2D(this);
			}
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0000DD2C File Offset: 0x0000BF2C
		public unsafe readonly float SizeSquared2D()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_SizeSquared2D(this);
			}
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0000DD44 File Offset: 0x0000BF44
		public unsafe readonly bool IsNearlyZero(float tolerance = 0.0001f)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_IsNearlyZero(this, tolerance);
			}
		}

		// Token: 0x06000689 RID: 1673 RVA: 0x0000DD5C File Offset: 0x0000BF5C
		public unsafe readonly bool IsZero()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_IsZero(this);
			}
		}

		// Token: 0x0600068A RID: 1674 RVA: 0x0000DD74 File Offset: 0x0000BF74
		public unsafe readonly bool IsUnit()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_IsUnit(this);
			}
		}

		// Token: 0x0600068B RID: 1675 RVA: 0x0000DD8C File Offset: 0x0000BF8C
		public unsafe readonly bool IsNormalized()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_IsNormalized(this);
			}
		}

		// Token: 0x0600068C RID: 1676 RVA: 0x0000DDA4 File Offset: 0x0000BFA4
		public unsafe void Normalize(float tolerance = 1E-08f)
		{
			fixed (FVector* ptr = &this)
			{
				FVector.Internal_Normalize(ref this, tolerance);
			}
		}

		// Token: 0x0600068D RID: 1677 RVA: 0x0000DDC0 File Offset: 0x0000BFC0
		public unsafe readonly FVector GetUnsafeNormal()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetUnsafeNormal(this);
			}
		}

		// Token: 0x0600068E RID: 1678 RVA: 0x0000DDD8 File Offset: 0x0000BFD8
		public unsafe readonly FVector GetSafeNormal(float tolerance = 1E-08f)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetSafeNormal(this, tolerance);
			}
		}

		// Token: 0x0600068F RID: 1679 RVA: 0x0000DDF0 File Offset: 0x0000BFF0
		public unsafe readonly FVector GetSafeNormal2D(float tolerance = 1E-08f)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetSafeNormal2D(this, tolerance);
			}
		}

		// Token: 0x06000690 RID: 1680 RVA: 0x0000DE08 File Offset: 0x0000C008
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

		// Token: 0x06000691 RID: 1681 RVA: 0x0000DE34 File Offset: 0x0000C034
		public unsafe readonly FVector GetSignVector()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetSignVector(this);
			}
		}

		// Token: 0x06000692 RID: 1682 RVA: 0x0000DE4C File Offset: 0x0000C04C
		public unsafe readonly FVector Projection()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_Projection(this);
			}
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0000DE64 File Offset: 0x0000C064
		public unsafe readonly FVector GetUnsafeNormal2D()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetUnsafeNormal2D(this);
			}
		}

		// Token: 0x06000694 RID: 1684 RVA: 0x0000DE7C File Offset: 0x0000C07C
		public unsafe readonly FVector GridSnap(float gridSz)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GridSnap(this, gridSz);
			}
		}

		// Token: 0x06000695 RID: 1685 RVA: 0x0000DE94 File Offset: 0x0000C094
		public unsafe readonly FVector BoundToCube(float radius)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_BoundToCube(this, radius);
			}
		}

		// Token: 0x06000696 RID: 1686 RVA: 0x0000DEAC File Offset: 0x0000C0AC
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

		// Token: 0x06000697 RID: 1687 RVA: 0x0000DED0 File Offset: 0x0000C0D0
		public unsafe readonly FVector GetClampedToSize(float min, float max)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetClampedToSize(this, min, max);
			}
		}

		// Token: 0x06000698 RID: 1688 RVA: 0x0000DEEC File Offset: 0x0000C0EC
		public unsafe readonly FVector GetClampedToSize2D(float min, float max)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetClampedToSize2D(this, min, max);
			}
		}

		// Token: 0x06000699 RID: 1689 RVA: 0x0000DF08 File Offset: 0x0000C108
		public unsafe readonly FVector GetClampedToMaxSize(float maxSize)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetClampedToMaxSize(this, maxSize);
			}
		}

		// Token: 0x0600069A RID: 1690 RVA: 0x0000DF20 File Offset: 0x0000C120
		public unsafe readonly FVector GetClampedToMaxSize2D(float maxSize)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_GetClampedToMaxSize2D(this, maxSize);
			}
		}

		// Token: 0x0600069B RID: 1691 RVA: 0x0000DF38 File Offset: 0x0000C138
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

		// Token: 0x0600069C RID: 1692 RVA: 0x0000DF5C File Offset: 0x0000C15C
		public unsafe readonly FVector Reciprocal()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_Reciprocal(this);
			}
		}

		// Token: 0x0600069D RID: 1693 RVA: 0x0000DF74 File Offset: 0x0000C174
		public unsafe readonly bool IsUniform(float tolerance = 0.0001f)
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_IsUniform(this, tolerance);
			}
		}

		// Token: 0x0600069E RID: 1694 RVA: 0x0000DF8C File Offset: 0x0000C18C
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

		// Token: 0x0600069F RID: 1695 RVA: 0x0000DFA8 File Offset: 0x0000C1A8
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

		// Token: 0x060006A0 RID: 1696 RVA: 0x0000DFC4 File Offset: 0x0000C1C4
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

		// Token: 0x060006A1 RID: 1697 RVA: 0x0000DFE4 File Offset: 0x0000C1E4
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

		// Token: 0x060006A2 RID: 1698 RVA: 0x0000E000 File Offset: 0x0000C200
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

		// Token: 0x060006A3 RID: 1699 RVA: 0x0000E01C File Offset: 0x0000C21C
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

		// Token: 0x060006A4 RID: 1700 RVA: 0x0000E038 File Offset: 0x0000C238
		public unsafe readonly FRotator ToOrientationRotator()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_ToOrientationRotator(this);
			}
		}

		// Token: 0x060006A5 RID: 1701 RVA: 0x0000E050 File Offset: 0x0000C250
		public unsafe readonly FQuat ToOrientationQuat()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_ToOrientationQuat(this);
			}
		}

		// Token: 0x060006A6 RID: 1702 RVA: 0x0000E068 File Offset: 0x0000C268
		public unsafe readonly FRotator Rotation()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_Rotation(this);
			}
		}

		// Token: 0x060006A7 RID: 1703 RVA: 0x0000E080 File Offset: 0x0000C280
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

		// Token: 0x060006A8 RID: 1704 RVA: 0x0000E0AC File Offset: 0x0000C2AC
		public unsafe void UnwindEuler()
		{
			fixed (FVector* ptr = &this)
			{
				FVector.Internal_UnwindEuler(ref this);
			}
		}

		// Token: 0x060006A9 RID: 1705 RVA: 0x0000E0C8 File Offset: 0x0000C2C8
		public unsafe readonly bool ContainsNaN()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_ContainsNaN(this);
			}
		}

		// Token: 0x060006AA RID: 1706 RVA: 0x0000E0E0 File Offset: 0x0000C2E0
		public unsafe readonly FVector2D UnitCartesianToSpherical()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_UnitCartesianToSpherical(this);
			}
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0000E0F8 File Offset: 0x0000C2F8
		public unsafe readonly float HeadingAngle()
		{
			fixed (FVector* ptr = &this)
			{
				return FVector.Internal_HeadingAngle(this);
			}
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0000E110 File Offset: 0x0000C310
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

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060006AD RID: 1709 RVA: 0x0000E177 File Offset: 0x0000C377
		// (set) Token: 0x060006AE RID: 1710 RVA: 0x0000E180 File Offset: 0x0000C380
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

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060006AF RID: 1711 RVA: 0x0000E18A File Offset: 0x0000C38A
		// (set) Token: 0x060006B0 RID: 1712 RVA: 0x0000E193 File Offset: 0x0000C393
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

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060006B1 RID: 1713 RVA: 0x0000E19D File Offset: 0x0000C39D
		// (set) Token: 0x060006B2 RID: 1714 RVA: 0x0000E1A6 File Offset: 0x0000C3A6
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

		// Token: 0x060006B3 RID: 1715 RVA: 0x0000E1B0 File Offset: 0x0000C3B0
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVector._ScriptStructPtr != 0) ? FVector._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/CoreUObject.Vector", ref FVector._ScriptStructPtr);
		}

		// Token: 0x04000109 RID: 265
		public static readonly FVector ZeroVector = new FVector(0f, 0f, 0f);

		// Token: 0x0400010A RID: 266
		public static readonly FVector OneVector = new FVector(1f, 1f, 1f);

		// Token: 0x0400010B RID: 267
		public static readonly FVector UpVector = new FVector(0f, 0f, 1f);

		// Token: 0x0400010C RID: 268
		public static readonly FVector DownVector = new FVector(0f, 0f, -1f);

		// Token: 0x0400010D RID: 269
		public static readonly FVector ForwardVector = new FVector(1f, 0f, 0f);

		// Token: 0x0400010E RID: 270
		public static readonly FVector BackwardVector = new FVector(-1f, 0f, 0f);

		// Token: 0x0400010F RID: 271
		public static readonly FVector RightVector = new FVector(0f, 1f, 0f);

		// Token: 0x04000110 RID: 272
		public static readonly FVector LeftVector = new FVector(0f, -1f, 0f);

		// Token: 0x04000111 RID: 273
		public static readonly FVector XAxisVector = new FVector(1f, 0f, 0f);

		// Token: 0x04000112 RID: 274
		public static readonly FVector YAxisVector = new FVector(0f, 1f, 0f);

		// Token: 0x04000113 RID: 275
		public static readonly FVector ZAxisVector = new FVector(0f, 0f, 1f);

		// Token: 0x04000114 RID: 276
		[FieldOffset(0)]
		public float X;

		// Token: 0x04000115 RID: 277
		[FieldOffset(4)]
		public float Y;

		// Token: 0x04000116 RID: 278
		[FieldOffset(8)]
		public float Z;

		// Token: 0x04000117 RID: 279
		public const string __ObjectPath = "/Script/CoreUObject.Vector";

		// Token: 0x04000118 RID: 280
		private static IntPtr _ScriptStructPtr;
	}
}
