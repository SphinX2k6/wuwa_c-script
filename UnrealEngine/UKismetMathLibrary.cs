using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000224 RID: 548
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KismetMathLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKismetMathLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002584 RID: 9604 RVA: 0x00035E27 File Offset: 0x00034027
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKismetMathLibrary._ClassPtr;
		}

		// Token: 0x06002585 RID: 9605 RVA: 0x00035E34 File Offset: 0x00034034
		public UKismetMathLibrary() : this(BuiltinUtils.AllocNativeUObject(UKismetMathLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002586 RID: 9606 RVA: 0x00035E5C File Offset: 0x0003405C
		[NullableContext(1)]
		public UKismetMathLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKismetMathLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06002587 RID: 9607
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Xor_IntInt(int A, int B);

		// Token: 0x06002588 RID: 9608
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Xor_Int64Int64(long A, long B);

		// Token: 0x06002589 RID: 9609
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Wrap(int Value, int Min, int Max);

		// Token: 0x0600258A RID: 9610
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector WeightedMovingAverage_FVector(FVector CurrentSample, FVector PreviousSample, float Weight);

		// Token: 0x0600258B RID: 9611
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator WeightedMovingAverage_FRotator(FRotator CurrentSample, FRotator PreviousSample, float Weight);

		// Token: 0x0600258C RID: 9612
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float WeightedMovingAverage_Float(float CurrentSample, float PreviousSample, float Weight);

		// Token: 0x0600258D RID: 9613 RVA: 0x00035E8F File Offset: 0x0003408F
		public static FVector WD_WorldToLocal(UObject WorldContextObject, FVectorDouble InVec)
		{
			return UKismetMathLibrary.__WD_WorldToLocal_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, InVec);
		}

		// Token: 0x0600258E RID: 9614 RVA: 0x00035EA8 File Offset: 0x000340A8
		public unsafe static FTransformDouble WD_TransformToTransformDouble(UObject WorldContextObject, FTransform InT)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InT;
			return UKismetMathLibrary.__WD_TransformToTransformDouble_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ptr);
		}

		// Token: 0x0600258F RID: 9615 RVA: 0x00035EE4 File Offset: 0x000340E4
		public unsafe static FTransform WD_TransformDoubleToTransform(UObject WorldContextObject, FTransformDouble InT)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = InT;
			return UKismetMathLibrary.__WD_TransformDoubleToTransform_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ptr);
		}

		// Token: 0x06002590 RID: 9616 RVA: 0x00035F1E File Offset: 0x0003411E
		public static FVectorDouble WD_LocalToWorld(UObject WorldContextObject, FVector InVec)
		{
			return UKismetMathLibrary.__WD_LocalToWorld_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, InVec);
		}

		// Token: 0x06002591 RID: 9617
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float VSizeXYSquared(FVector A);

		// Token: 0x06002592 RID: 9618
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float VSizeXY(FVector A);

		// Token: 0x06002593 RID: 9619
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float VSizeSquared(FVector A);

		// Token: 0x06002594 RID: 9620
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float VSize2DSquared(FVector2D A);

		// Token: 0x06002595 RID: 9621
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float VSize2D(FVector2D A);

		// Token: 0x06002596 RID: 9622
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float VSize(FVector A);

		// Token: 0x06002597 RID: 9623
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector VLerp(FVector A, FVector B, float Alpha);

		// Token: 0x06002598 RID: 9624
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector VInterpTo_Constant(FVector Current, FVector Target, float DeltaTime, float InterpSpeed);

		// Token: 0x06002599 RID: 9625
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector VInterpTo(FVector Current, FVector Target, float DeltaTime, float InterpSpeed);

		// Token: 0x0600259A RID: 9626
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_Zero();

		// Token: 0x0600259B RID: 9627
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_Up();

		// Token: 0x0600259C RID: 9628
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Vector_UnwindEuler(ref FVector A);

		// Token: 0x0600259D RID: 9629
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Vector_UnitCartesianToSpherical(FVector A);

		// Token: 0x0600259E RID: 9630
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_ToRadians(FVector A);

		// Token: 0x0600259F RID: 9631
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_ToDegrees(FVector A);

		// Token: 0x060025A0 RID: 9632
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_SnappedToGrid(FVector InVect, float InGridSize);

		// Token: 0x060025A1 RID: 9633
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Vector_Set(ref FVector A, float X, float Y, float Z);

		// Token: 0x060025A2 RID: 9634
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_Right();

		// Token: 0x060025A3 RID: 9635
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_Reciprocal(in FVector A);

		// Token: 0x060025A4 RID: 9636
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_ProjectOnToNormal(FVector V, FVector InNormal);

		// Token: 0x060025A5 RID: 9637
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_One();

		// Token: 0x060025A6 RID: 9638
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_NormalUnsafe(in FVector A);

		// Token: 0x060025A7 RID: 9639
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Vector_Normalize(ref FVector A, float Tolerance = 0f);

		// Token: 0x060025A8 RID: 9640
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_Normal2D(FVector A, float Tolerance = 0.0001f);

		// Token: 0x060025A9 RID: 9641 RVA: 0x00035F38 File Offset: 0x00034138
		public unsafe static FVector Vector_MirrorByPlane(FVector A, in FPlane InPlane)
		{
			ref FPlane ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InPlane;
			return UKismetMathLibrary.__Vector_MirrorByPlane_Internal(A, ptr);
		}

		// Token: 0x060025AA RID: 9642
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_Left();

		// Token: 0x060025AB RID: 9643
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Vector_IsZero(in FVector A);

		// Token: 0x060025AC RID: 9644
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Vector_IsUnit(in FVector A, float SquaredLenthTolerance = 0.0001f);

		// Token: 0x060025AD RID: 9645
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Vector_IsUniform(in FVector A, float Tolerance = 0.0001f);

		// Token: 0x060025AE RID: 9646
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Vector_IsNormal(in FVector A);

		// Token: 0x060025AF RID: 9647
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Vector_IsNearlyZero(in FVector A, float Tolerance = 0.0001f);

		// Token: 0x060025B0 RID: 9648
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Vector_IsNAN(in FVector A);

		// Token: 0x060025B1 RID: 9649
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Vector_HeadingAngle(FVector A);

		// Token: 0x060025B2 RID: 9650
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_GetSignVector(FVector A);

		// Token: 0x060025B3 RID: 9651
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_GetProjection(FVector A);

		// Token: 0x060025B4 RID: 9652
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Vector_GetAbsMin(FVector A);

		// Token: 0x060025B5 RID: 9653
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Vector_GetAbsMax(FVector A);

		// Token: 0x060025B6 RID: 9654
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_GetAbs(FVector A);

		// Token: 0x060025B7 RID: 9655
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_Forward();

		// Token: 0x060025B8 RID: 9656
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_Down();

		// Token: 0x060025B9 RID: 9657
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Vector_DistanceSquared(FVector V1, FVector V2);

		// Token: 0x060025BA RID: 9658
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Vector_Distance2DSquared(FVector V1, FVector V2);

		// Token: 0x060025BB RID: 9659
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Vector_Distance2D(FVector V1, FVector V2);

		// Token: 0x060025BC RID: 9660
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Vector_Distance(FVector V1, FVector V2);

		// Token: 0x060025BD RID: 9661
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Vector_CosineAngle2D(FVector A, FVector B);

		// Token: 0x060025BE RID: 9662
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_ComponentMin(FVector A, FVector B);

		// Token: 0x060025BF RID: 9663
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_ComponentMax(FVector A, FVector B);

		// Token: 0x060025C0 RID: 9664
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_ClampSizeMax2D(FVector A, float Max);

		// Token: 0x060025C1 RID: 9665
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_ClampSizeMax(FVector A, float Max);

		// Token: 0x060025C2 RID: 9666
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_ClampSize2D(FVector A, float Min, float Max);

		// Token: 0x060025C3 RID: 9667
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_BoundedToCube(FVector InVect, float InRadius);

		// Token: 0x060025C4 RID: 9668
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_BoundedToBox(FVector InVect, FVector InBoxMin, FVector InBoxMax);

		// Token: 0x060025C5 RID: 9669
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_Backward();

		// Token: 0x060025C6 RID: 9670
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Vector_Assign(ref FVector A, in FVector InVector);

		// Token: 0x060025C7 RID: 9671
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Vector_AddBounded(ref FVector A, FVector InAddVect, float InRadius);

		// Token: 0x060025C8 RID: 9672
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector4 Vector4_Zero();

		// Token: 0x060025C9 RID: 9673 RVA: 0x00035F68 File Offset: 0x00034168
		public unsafe static float Vector4_SizeSquared3(in FVector4 A)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_SizeSquared3_Internal(uintPtr);
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x00035F98 File Offset: 0x00034198
		public unsafe static float Vector4_SizeSquared(in FVector4 A)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_SizeSquared_Internal(uintPtr);
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x00035FC8 File Offset: 0x000341C8
		public unsafe static float Vector4_Size3(in FVector4 A)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_Size3_Internal(uintPtr);
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x00035FF8 File Offset: 0x000341F8
		public unsafe static float Vector4_Size(in FVector4 A)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_Size_Internal(uintPtr);
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x00036028 File Offset: 0x00034228
		public unsafe static void Vector4_Set(ref FVector4 A, float X, float Y, float Z, float W)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			UKismetMathLibrary.__Vector4_Set_Internal(ref ptr, X, Y, Z, W);
			A = ptr;
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x00036068 File Offset: 0x00034268
		public unsafe static FVector4 Vector4_NormalUnsafe3(in FVector4 A)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_NormalUnsafe3_Internal(uintPtr);
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x00036098 File Offset: 0x00034298
		public unsafe static void Vector4_Normalize3(ref FVector4 A, float Tolerance = 0f)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			UKismetMathLibrary.__Vector4_Normalize3_Internal(ref ptr, Tolerance);
			A = ptr;
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x000360D4 File Offset: 0x000342D4
		public unsafe static FVector4 Vector4_Normal3(in FVector4 A, float Tolerance = 0.0001f)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_Normal3_Internal(uintPtr, Tolerance);
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x00036104 File Offset: 0x00034304
		public unsafe static FVector4 Vector4_Negated(in FVector4 A)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_Negated_Internal(uintPtr);
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x00036134 File Offset: 0x00034334
		public unsafe static FVector4 Vector4_MirrorByVector3(in FVector4 Direction, in FVector4 SurfaceNormal)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = Direction;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = SurfaceNormal;
			return UKismetMathLibrary.__Vector4_MirrorByVector3_Internal(ptr, ptr2);
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x00036180 File Offset: 0x00034380
		public unsafe static bool Vector4_IsZero(in FVector4 A)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_IsZero_Internal(uintPtr);
		}

		// Token: 0x060025D4 RID: 9684 RVA: 0x000361B0 File Offset: 0x000343B0
		public unsafe static bool Vector4_IsUnit3(in FVector4 A, float SquaredLenthTolerance = 0.0001f)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_IsUnit3_Internal(uintPtr, SquaredLenthTolerance);
		}

		// Token: 0x060025D5 RID: 9685 RVA: 0x000361E0 File Offset: 0x000343E0
		public unsafe static bool Vector4_IsNormal3(in FVector4 A)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_IsNormal3_Internal(uintPtr);
		}

		// Token: 0x060025D6 RID: 9686 RVA: 0x00036210 File Offset: 0x00034410
		public unsafe static bool Vector4_IsNearlyZero3(in FVector4 A, float Tolerance = 0.0001f)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_IsNearlyZero3_Internal(uintPtr, Tolerance);
		}

		// Token: 0x060025D7 RID: 9687 RVA: 0x00036240 File Offset: 0x00034440
		public unsafe static bool Vector4_IsNAN(in FVector4 A)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_IsNAN_Internal(uintPtr);
		}

		// Token: 0x060025D8 RID: 9688 RVA: 0x00036270 File Offset: 0x00034470
		public unsafe static float Vector4_DotProduct3(in FVector4 A, in FVector4 B)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Vector4_DotProduct3_Internal(ptr, ptr2);
		}

		// Token: 0x060025D9 RID: 9689 RVA: 0x000362BC File Offset: 0x000344BC
		public unsafe static float Vector4_DotProduct(in FVector4 A, in FVector4 B)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Vector4_DotProduct_Internal(ptr, ptr2);
		}

		// Token: 0x060025DA RID: 9690 RVA: 0x00036308 File Offset: 0x00034508
		public unsafe static FVector4 Vector4_CrossProduct3(in FVector4 A, in FVector4 B)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Vector4_CrossProduct3_Internal(ptr, ptr2);
		}

		// Token: 0x060025DB RID: 9691 RVA: 0x00036354 File Offset: 0x00034554
		public unsafe static void Vector4_Assign(ref FVector4 A, in FVector4 InVector)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = InVector;
			UKismetMathLibrary.__Vector4_Assign_Internal(ref ptr, ptr2);
			A = ptr;
		}

		// Token: 0x060025DC RID: 9692
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Vector2DInterpTo_Constant(FVector2D Current, FVector2D Target, float DeltaTime, float InterpSpeed);

		// Token: 0x060025DD RID: 9693
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Vector2DInterpTo(FVector2D Current, FVector2D Target, float DeltaTime, float InterpSpeed);

		// Token: 0x060025DE RID: 9694
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Vector2D_Zero();

		// Token: 0x060025DF RID: 9695
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Vector2D_Unit45Deg();

		// Token: 0x060025E0 RID: 9696
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Vector2D_One();

		// Token: 0x060025E1 RID: 9697
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector VEase(FVector A, FVector B, float Alpha, EEasingFunc EasingFunc, float BlendExp = 2f, int Steps = 2);

		// Token: 0x060025E2 RID: 9698 RVA: 0x000363AC File Offset: 0x000345AC
		[NullableContext(1)]
		public static FDateTime UtcNow()
		{
			return new FDateTime(UKismetMathLibrary.__UtcNow_Internal(), null);
		}

		// Token: 0x060025E3 RID: 9699 RVA: 0x000363BC File Offset: 0x000345BC
		public unsafe static FVector4 TransformVector4(in FMatrix Matrix, in FVector4 Vec4)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = Matrix;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = Vec4;
			return UKismetMathLibrary.__TransformVector4_Internal(ptr, ptr2);
		}

		// Token: 0x060025E4 RID: 9700 RVA: 0x00036408 File Offset: 0x00034608
		public unsafe static FRotator TransformRotation(in FTransform T, FRotator Rotation)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__TransformRotation_Internal(uintPtr, Rotation);
		}

		// Token: 0x060025E5 RID: 9701 RVA: 0x00036438 File Offset: 0x00034638
		public unsafe static FVector TransformLocation(in FTransform T, FVector Location)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__TransformLocation_Internal(uintPtr, Location);
		}

		// Token: 0x060025E6 RID: 9702 RVA: 0x00036468 File Offset: 0x00034668
		public unsafe static FVector TransformDirection(in FTransform T, FVector Direction)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__TransformDirection_Internal(uintPtr, Direction);
		}

		// Token: 0x060025E7 RID: 9703 RVA: 0x00036498 File Offset: 0x00034698
		public unsafe static float Transform_Determinant(in FTransform Transform)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = Transform;
			return UKismetMathLibrary.__Transform_Determinant_Internal(uintPtr);
		}

		// Token: 0x060025E8 RID: 9704
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D ToSign2D(FVector2D A);

		// Token: 0x060025E9 RID: 9705
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D ToRounded2D(FVector2D A);

		// Token: 0x060025EA RID: 9706
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ToDirectionAndLength2D(FVector2D A, ref FVector2D OutDir, ref float OutLength);

		// Token: 0x060025EB RID: 9707 RVA: 0x000364C5 File Offset: 0x000346C5
		[NullableContext(1)]
		public static FDateTime Today()
		{
			return new FDateTime(UKismetMathLibrary.__Today_Internal(), null);
		}

		// Token: 0x060025EC RID: 9708 RVA: 0x000364D4 File Offset: 0x000346D4
		public unsafe static FTransform TLerp(in FTransform A, in FTransform B, float Alpha, ELerpInterpolationMode InterpMode = ELerpInterpolationMode.QuatInterp)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__TLerp_Internal(ptr, ptr2, Alpha, InterpMode);
		}

		// Token: 0x060025ED RID: 9709 RVA: 0x00036528 File Offset: 0x00034728
		public unsafe static FTransform TInterpTo(in FTransform Current, in FTransform Target, float DeltaTime, float InterpSpeed)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Current;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = Target;
			return UKismetMathLibrary.__TInterpTo_Internal(ptr, ptr2, DeltaTime, InterpSpeed);
		}

		// Token: 0x060025EE RID: 9710 RVA: 0x00036576 File Offset: 0x00034776
		[NullableContext(1)]
		public static FTimespan TimespanZeroValue()
		{
			return new FTimespan(UKismetMathLibrary.__TimespanZeroValue_Internal(), null);
		}

		// Token: 0x060025EF RID: 9711 RVA: 0x00036583 File Offset: 0x00034783
		public static float TimespanRatio(FTimespan A, FTimespan B)
		{
			return UKismetMathLibrary.__TimespanRatio_Internal((A ?? new FTimespan()).NativePtr, (B ?? new FTimespan()).NativePtr);
		}

		// Token: 0x060025F0 RID: 9712 RVA: 0x000365A8 File Offset: 0x000347A8
		[NullableContext(1)]
		public static FTimespan TimespanMinValue()
		{
			return new FTimespan(UKismetMathLibrary.__TimespanMinValue_Internal(), null);
		}

		// Token: 0x060025F1 RID: 9713 RVA: 0x000365B5 File Offset: 0x000347B5
		[NullableContext(1)]
		public static FTimespan TimespanMaxValue()
		{
			return new FTimespan(UKismetMathLibrary.__TimespanMaxValue_Internal(), null);
		}

		// Token: 0x060025F2 RID: 9714 RVA: 0x000365C4 File Offset: 0x000347C4
		[NullableContext(1)]
		public unsafe static bool TimespanFromString(string TimespanString, [Nullable(2)] ref FTimespan Result)
		{
			FString fstring = FString.AllocTemp(TimespanString);
			bool result = UKismetMathLibrary.__TimespanFromString_Internal(fstring, (Result ?? new FTimespan()).NativePtr);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060025F3 RID: 9715 RVA: 0x000365F8 File Offset: 0x000347F8
		public unsafe static FTransform TEase(in FTransform A, in FTransform B, float Alpha, EEasingFunc EasingFunc, float BlendExp = 2f, int Steps = 2)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__TEase_Internal(ptr, ptr2, Alpha, EasingFunc, BlendExp, Steps);
		}

		// Token: 0x060025F4 RID: 9716
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Tan(float A);

		// Token: 0x060025F5 RID: 9717
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Subtract_VectorVector(FVector A, FVector B);

		// Token: 0x060025F6 RID: 9718
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Subtract_VectorInt(FVector A, int B);

		// Token: 0x060025F7 RID: 9719
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Subtract_VectorFloat(FVector A, float B);

		// Token: 0x060025F8 RID: 9720 RVA: 0x00036650 File Offset: 0x00034850
		public unsafe static FVector4 Subtract_Vector4Vector4(in FVector4 A, in FVector4 B)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Subtract_Vector4Vector4_Internal(ptr, ptr2);
		}

		// Token: 0x060025F9 RID: 9721
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Subtract_Vector2DVector2D(FVector2D A, FVector2D B);

		// Token: 0x060025FA RID: 9722
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Subtract_Vector2DFloat(FVector2D A, float B);

		// Token: 0x060025FB RID: 9723 RVA: 0x0003669C File Offset: 0x0003489C
		[return: Nullable(1)]
		public static FTimespan Subtract_TimespanTimespan(FTimespan A, FTimespan B)
		{
			return new FTimespan(UKismetMathLibrary.__Subtract_TimespanTimespan_Internal((A ?? new FTimespan()).NativePtr, (B ?? new FTimespan()).NativePtr), null);
		}

		// Token: 0x060025FC RID: 9724 RVA: 0x000366C8 File Offset: 0x000348C8
		public unsafe static FQuat Subtract_QuatQuat(in FQuat A, in FQuat B)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FQuat ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Subtract_QuatQuat_Internal(ptr, ptr2);
		}

		// Token: 0x060025FD RID: 9725
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor Subtract_LinearColorLinearColor(FLinearColor A, FLinearColor B);

		// Token: 0x060025FE RID: 9726
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint Subtract_IntPointIntPoint(FIntPoint A, FIntPoint B);

		// Token: 0x060025FF RID: 9727
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint Subtract_IntPointInt(FIntPoint A, int B);

		// Token: 0x06002600 RID: 9728
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Subtract_IntInt(int A, int B = 1);

		// Token: 0x06002601 RID: 9729
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Subtract_Int64Int64(long A, long B = 1L);

		// Token: 0x06002602 RID: 9730
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Subtract_FloatFloat(float A, float B = 1f);

		// Token: 0x06002603 RID: 9731 RVA: 0x00036714 File Offset: 0x00034914
		[return: Nullable(1)]
		public static FDateTime Subtract_DateTimeTimespan(FDateTime A, FTimespan B)
		{
			return new FDateTime(UKismetMathLibrary.__Subtract_DateTimeTimespan_Internal((A ?? new FDateTime()).NativePtr, (B ?? new FTimespan()).NativePtr), null);
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x0003673F File Offset: 0x0003493F
		[return: Nullable(1)]
		public static FTimespan Subtract_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			return new FTimespan(UKismetMathLibrary.__Subtract_DateTimeDateTime_Internal((A ?? new FDateTime()).NativePtr, (B ?? new FDateTime()).NativePtr), null);
		}

		// Token: 0x06002605 RID: 9733
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte Subtract_ByteByte(byte A, byte B = 1);

		// Token: 0x06002606 RID: 9734
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Square(float A);

		// Token: 0x06002607 RID: 9735
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Sqrt(float A);

		// Token: 0x06002608 RID: 9736
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Spherical2DToUnitCartesian(FVector2D A);

		// Token: 0x06002609 RID: 9737
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Sin(float A);

		// Token: 0x0600260A RID: 9738
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long SignOfInteger64(long A);

		// Token: 0x0600260B RID: 9739
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int SignOfInteger(int A);

		// Token: 0x0600260C RID: 9740
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float SignOfFloat(float A);

		// Token: 0x0600260D RID: 9741
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetRandomStreamSeed(ref FRandomStream Stream, int NewSeed);

		// Token: 0x0600260E RID: 9742
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Set2D(ref FVector2D A, float X, float Y);

		// Token: 0x0600260F RID: 9743
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector SelectVector(FVector A, FVector B, bool bPickA);

		// Token: 0x06002610 RID: 9744 RVA: 0x0003676C File Offset: 0x0003496C
		public unsafe static FTransform SelectTransform(in FTransform A, in FTransform B, bool bPickA)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__SelectTransform_Internal(ptr, ptr2, bPickA);
		}

		// Token: 0x06002611 RID: 9745 RVA: 0x000367BC File Offset: 0x000349BC
		[NullableContext(1)]
		public unsafe static string SelectString(string A, string B, bool bPickA)
		{
			FString fstring = FString.AllocTemp(A);
			FString fstring2 = FString.AllocTemp(B);
			string result = FString.ToStringAndDeleteNativePtr(UKismetMathLibrary.__SelectString_Internal(fstring, fstring2, bPickA));
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
			return result;
		}

		// Token: 0x06002612 RID: 9746
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator SelectRotator(FRotator A, FRotator B, bool bPickA);

		// Token: 0x06002613 RID: 9747 RVA: 0x000367F8 File Offset: 0x000349F8
		public static UObject SelectObject(UObject A, UObject B, bool bSelectA)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKismetMathLibrary.__SelectObject_Internal((A != null) ? A.NativePtr : IntPtr.Zero, (B != null) ? B.NativePtr : IntPtr.Zero, bSelectA));
		}

		// Token: 0x06002614 RID: 9748
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int SelectInt(int A, int B, bool bPickA);

		// Token: 0x06002615 RID: 9749
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float SelectFloat(float A, float B, bool bPickA);

		// Token: 0x06002616 RID: 9750
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor SelectColor(FLinearColor A, FLinearColor B, bool bPickA);

		// Token: 0x06002617 RID: 9751
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern UClassStackOnlyPtr SelectClass(UClassStackOnlyPtr A, UClassStackOnlyPtr B, bool bSelectA);

		// Token: 0x06002618 RID: 9752
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SeedRandomStream(ref FRandomStream Stream);

		// Token: 0x06002619 RID: 9753
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float SafeDivide(float A, float B);

		// Token: 0x0600261A RID: 9754
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Round64(float A);

		// Token: 0x0600261B RID: 9755
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Round(float A);

		// Token: 0x0600261C RID: 9756
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator RotatorFromAxisAndAngle(FVector Axis, float Angle);

		// Token: 0x0600261D RID: 9757
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RotateAngleAxis(FVector InVect, float AngleDeg, FVector Axis);

		// Token: 0x0600261E RID: 9758
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator RLerp(FRotator A, FRotator B, float Alpha, bool bShortestPath);

		// Token: 0x0600261F RID: 9759
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator RInterpTo_Constant(FRotator Current, FRotator Target, float DeltaTime, float InterpSpeed);

		// Token: 0x06002620 RID: 9760
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator RInterpTo(FRotator Current, FRotator Target, float DeltaTime, float InterpSpeed);

		// Token: 0x06002621 RID: 9761
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RGBToHSV_Vector(FLinearColor RGB, ref FLinearColor HSV);

		// Token: 0x06002622 RID: 9762
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RGBToHSV(FLinearColor InColor, ref float H, ref float S, ref float V, ref float A);

		// Token: 0x06002623 RID: 9763
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor RGBLinearToHSV(FLinearColor RGB);

		// Token: 0x06002624 RID: 9764
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetRandomStream(in FRandomStream Stream);

		// Token: 0x06002625 RID: 9765
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator REase(FRotator A, FRotator B, float Alpha, bool bShortestPath, EEasingFunc EasingFunc, float BlendExp = 2f, int Steps = 2);

		// Token: 0x06002626 RID: 9766
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RandomUnitVectorInEllipticalConeInRadiansFromStream(in FVector ConeDir, float MaxYawInRadians, float MaxPitchInRadians, in FRandomStream Stream);

		// Token: 0x06002627 RID: 9767
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RandomUnitVectorInEllipticalConeInRadians(FVector ConeDir, float MaxYawInRadians, float MaxPitchInRadians);

		// Token: 0x06002628 RID: 9768
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RandomUnitVectorInEllipticalConeInDegreesFromStream(in FVector ConeDir, float MaxYawInDegrees, float MaxPitchInDegrees, in FRandomStream Stream);

		// Token: 0x06002629 RID: 9769
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RandomUnitVectorInEllipticalConeInDegrees(FVector ConeDir, float MaxYawInDegrees, float MaxPitchInDegrees);

		// Token: 0x0600262A RID: 9770
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RandomUnitVectorInConeInRadiansFromStream(in FVector ConeDir, float ConeHalfAngleInRadians, in FRandomStream Stream);

		// Token: 0x0600262B RID: 9771
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RandomUnitVectorInConeInRadians(FVector ConeDir, float ConeHalfAngleInRadians);

		// Token: 0x0600262C RID: 9772
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RandomUnitVectorInConeInDegreesFromStream(in FVector ConeDir, float ConeHalfAngleInDegrees, in FRandomStream Stream);

		// Token: 0x0600262D RID: 9773
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RandomUnitVectorInConeInDegrees(FVector ConeDir, float ConeHalfAngleInDegrees);

		// Token: 0x0600262E RID: 9774
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RandomUnitVectorFromStream(in FRandomStream Stream);

		// Token: 0x0600262F RID: 9775
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RandomUnitVector();

		// Token: 0x06002630 RID: 9776
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator RandomRotatorFromStream(bool bRoll, in FRandomStream Stream);

		// Token: 0x06002631 RID: 9777
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator RandomRotator(bool bRoll = false);

		// Token: 0x06002632 RID: 9778
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RandomPointInBoundingBox(FVector Origin, FVector BoxExtent);

		// Token: 0x06002633 RID: 9779
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int RandomIntegerInRangeFromStream(int Min, int Max, in FRandomStream Stream);

		// Token: 0x06002634 RID: 9780
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int RandomIntegerInRange(int Min, int Max);

		// Token: 0x06002635 RID: 9781
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int RandomIntegerFromStream(int Max, in FRandomStream Stream);

		// Token: 0x06002636 RID: 9782
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long RandomInteger64InRange(long Min, long Max);

		// Token: 0x06002637 RID: 9783
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long RandomInteger64(long Max);

		// Token: 0x06002638 RID: 9784
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int RandomInteger(int Max);

		// Token: 0x06002639 RID: 9785
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float RandomFloatInRangeFromStream(float Min, float Max, in FRandomStream Stream);

		// Token: 0x0600263A RID: 9786
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float RandomFloatInRange(float Min, float Max);

		// Token: 0x0600263B RID: 9787
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float RandomFloatFromStream(in FRandomStream Stream);

		// Token: 0x0600263C RID: 9788
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float RandomFloat();

		// Token: 0x0600263D RID: 9789
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool RandomBoolWithWeightFromStream(float Weight, in FRandomStream RandomStream);

		// Token: 0x0600263E RID: 9790
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool RandomBoolWithWeight(float Weight);

		// Token: 0x0600263F RID: 9791
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool RandomBoolFromStream(in FRandomStream Stream);

		// Token: 0x06002640 RID: 9792
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool RandomBool();

		// Token: 0x06002641 RID: 9793
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float RadiansToDegrees(float A);

		// Token: 0x06002642 RID: 9794 RVA: 0x00036828 File Offset: 0x00034A28
		public unsafe static FVector Quat_VectorUp(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_VectorUp_Internal(uintPtr);
		}

		// Token: 0x06002643 RID: 9795 RVA: 0x00036858 File Offset: 0x00034A58
		public unsafe static FVector Quat_VectorRight(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_VectorRight_Internal(uintPtr);
		}

		// Token: 0x06002644 RID: 9796 RVA: 0x00036888 File Offset: 0x00034A88
		public unsafe static FVector Quat_VectorForward(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_VectorForward_Internal(uintPtr);
		}

		// Token: 0x06002645 RID: 9797 RVA: 0x000368B8 File Offset: 0x00034AB8
		public unsafe static FVector Quat_UnrotateVector(in FQuat Q, in FVector V)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_UnrotateVector_Internal(uintPtr, V);
		}

		// Token: 0x06002646 RID: 9798 RVA: 0x000368E8 File Offset: 0x00034AE8
		public unsafe static float Quat_SizeSquared(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_SizeSquared_Internal(uintPtr);
		}

		// Token: 0x06002647 RID: 9799 RVA: 0x00036918 File Offset: 0x00034B18
		public unsafe static float Quat_Size(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_Size_Internal(uintPtr);
		}

		// Token: 0x06002648 RID: 9800 RVA: 0x00036948 File Offset: 0x00034B48
		public unsafe static void Quat_SetFromEuler(ref FQuat Q, in FVector Euler)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = Q;
			UKismetMathLibrary.__Quat_SetFromEuler_Internal(ref ptr, Euler);
			Q = ptr;
		}

		// Token: 0x06002649 RID: 9801 RVA: 0x00036984 File Offset: 0x00034B84
		public unsafe static void Quat_SetComponents(ref FQuat Q, float X, float Y, float Z, float W)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = Q;
			UKismetMathLibrary.__Quat_SetComponents_Internal(ref ptr, X, Y, Z, W);
			Q = ptr;
		}

		// Token: 0x0600264A RID: 9802 RVA: 0x000369C4 File Offset: 0x00034BC4
		public unsafe static FRotator Quat_Rotator(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_Rotator_Internal(uintPtr);
		}

		// Token: 0x0600264B RID: 9803 RVA: 0x000369F4 File Offset: 0x00034BF4
		public unsafe static FVector Quat_RotateVector(in FQuat Q, in FVector V)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_RotateVector_Internal(uintPtr, V);
		}

		// Token: 0x0600264C RID: 9804 RVA: 0x00036A24 File Offset: 0x00034C24
		public unsafe static FQuat Quat_Normalized(in FQuat Q, float Tolerance = 0.0001f)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_Normalized_Internal(uintPtr, Tolerance);
		}

		// Token: 0x0600264D RID: 9805 RVA: 0x00036A54 File Offset: 0x00034C54
		public unsafe static void Quat_Normalize(ref FQuat Q, float Tolerance = 0.0001f)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = Q;
			UKismetMathLibrary.__Quat_Normalize_Internal(ref ptr, Tolerance);
			Q = ptr;
		}

		// Token: 0x0600264E RID: 9806
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FQuat Quat_MakeFromEuler(in FVector Euler);

		// Token: 0x0600264F RID: 9807 RVA: 0x00036A90 File Offset: 0x00034C90
		public unsafe static FQuat Quat_Log(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_Log_Internal(uintPtr);
		}

		// Token: 0x06002650 RID: 9808 RVA: 0x00036AC0 File Offset: 0x00034CC0
		public unsafe static bool Quat_IsNormalized(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_IsNormalized_Internal(uintPtr);
		}

		// Token: 0x06002651 RID: 9809 RVA: 0x00036AF0 File Offset: 0x00034CF0
		public unsafe static bool Quat_IsNonFinite(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_IsNonFinite_Internal(uintPtr);
		}

		// Token: 0x06002652 RID: 9810 RVA: 0x00036B20 File Offset: 0x00034D20
		public unsafe static bool Quat_IsIdentity(in FQuat Q, float Tolerance = 0.0001f)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_IsIdentity_Internal(uintPtr, Tolerance);
		}

		// Token: 0x06002653 RID: 9811 RVA: 0x00036B50 File Offset: 0x00034D50
		public unsafe static bool Quat_IsFinite(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_IsFinite_Internal(uintPtr);
		}

		// Token: 0x06002654 RID: 9812 RVA: 0x00036B80 File Offset: 0x00034D80
		public unsafe static FQuat Quat_Inversed(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_Inversed_Internal(uintPtr);
		}

		// Token: 0x06002655 RID: 9813
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FQuat Quat_Identity();

		// Token: 0x06002656 RID: 9814 RVA: 0x00036BB0 File Offset: 0x00034DB0
		public unsafe static FVector Quat_GetRotationAxis(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_GetRotationAxis_Internal(uintPtr);
		}

		// Token: 0x06002657 RID: 9815 RVA: 0x00036BE0 File Offset: 0x00034DE0
		public unsafe static FVector Quat_GetAxisZ(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_GetAxisZ_Internal(uintPtr);
		}

		// Token: 0x06002658 RID: 9816 RVA: 0x00036C10 File Offset: 0x00034E10
		public unsafe static FVector Quat_GetAxisY(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_GetAxisY_Internal(uintPtr);
		}

		// Token: 0x06002659 RID: 9817 RVA: 0x00036C40 File Offset: 0x00034E40
		public unsafe static FVector Quat_GetAxisX(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_GetAxisX_Internal(uintPtr);
		}

		// Token: 0x0600265A RID: 9818 RVA: 0x00036C70 File Offset: 0x00034E70
		public unsafe static float Quat_GetAngle(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_GetAngle_Internal(uintPtr);
		}

		// Token: 0x0600265B RID: 9819
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FQuat Quat_FindBetween(in FVector V1, in FVector V2);

		// Token: 0x0600265C RID: 9820 RVA: 0x00036CA0 File Offset: 0x00034EA0
		public unsafe static FQuat Quat_Exp(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_Exp_Internal(uintPtr);
		}

		// Token: 0x0600265D RID: 9821 RVA: 0x00036CD0 File Offset: 0x00034ED0
		public unsafe static FVector Quat_Euler(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_Euler_Internal(uintPtr);
		}

		// Token: 0x0600265E RID: 9822 RVA: 0x00036D00 File Offset: 0x00034F00
		public unsafe static void Quat_EnforceShortestArcWith(ref FQuat A, in FQuat B)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FQuat ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			UKismetMathLibrary.__Quat_EnforceShortestArcWith_Internal(ref ptr, ptr2);
			A = ptr;
		}

		// Token: 0x0600265F RID: 9823 RVA: 0x00036D58 File Offset: 0x00034F58
		public unsafe static float Quat_AngularDistance(in FQuat A, in FQuat B)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FQuat ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Quat_AngularDistance_Internal(ptr, ptr2);
		}

		// Token: 0x06002660 RID: 9824
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector ProjectVectorOnToVector(FVector V, FVector Target);

		// Token: 0x06002661 RID: 9825
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector ProjectVectorOnToPlane(FVector V, FVector PlaneNormal);

		// Token: 0x06002662 RID: 9826
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector ProjectPointOnToPlane(FVector Point, FVector PlaneBase, FVector PlaneNormal);

		// Token: 0x06002663 RID: 9827 RVA: 0x00036DA4 File Offset: 0x00034FA4
		public static bool PointsAreCoplanar(in TArray<FVector> Points, float Tolerance = 0.1f)
		{
			return UKismetMathLibrary.__PointsAreCoplanar_Internal((Points ?? new TArray<FVector>()).NativePtr, Tolerance);
		}

		// Token: 0x06002664 RID: 9828
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float PerlinNoise1D(float Value);

		// Token: 0x06002665 RID: 9829
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Percent_IntInt(int A, int B = 1);

		// Token: 0x06002666 RID: 9830 RVA: 0x00036DBC File Offset: 0x00034FBC
		[SkipLocalsInit]
		public unsafe static float Percent_FloatFloat(float A, float B = 1f)
		{
			UKismetMathLibrary.__Percent_FloatFloat_FunctionParams* ptr = stackalloc UKismetMathLibrary.__Percent_FloatFloat_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKismetMathLibrary.__Percent_FloatFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetMathLibrary.__Percent_FloatFloat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->A = A;
			ptr->B = B;
			UnrealReflectionUtils.CallUFunction(UKismetMathLibrary._ClassDefaultObjectPtr, UKismetMathLibrary.__Percent_FloatFloat_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06002667 RID: 9831
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte Percent_ByteByte(byte A, byte B = 1);

		// Token: 0x06002668 RID: 9832
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Or_IntInt(int A, int B);

		// Token: 0x06002669 RID: 9833
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Or_Int64Int64(long A, long B);

		// Token: 0x0600266A RID: 9834 RVA: 0x00036E0E File Offset: 0x0003500E
		[NullableContext(1)]
		public static FDateTime Now()
		{
			return new FDateTime(UKismetMathLibrary.__Now_Internal(), null);
		}

		// Token: 0x0600266B RID: 9835
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqualExactly_VectorVector(FVector A, FVector B);

		// Token: 0x0600266C RID: 9836 RVA: 0x00036E1C File Offset: 0x0003501C
		public unsafe static bool NotEqualExactly_Vector4Vector4(in FVector4 A, in FVector4 B)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__NotEqualExactly_Vector4Vector4_Internal(ptr, ptr2);
		}

		// Token: 0x0600266D RID: 9837
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqualExactly_Vector2DVector2D(FVector2D A, FVector2D B);

		// Token: 0x0600266E RID: 9838
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_VectorVector(FVector A, FVector B, float ErrorTolerance = 0.0001f);

		// Token: 0x0600266F RID: 9839 RVA: 0x00036E68 File Offset: 0x00035068
		public unsafe static bool NotEqual_Vector4Vector4(in FVector4 A, in FVector4 B, float ErrorTolerance = 0.0001f)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__NotEqual_Vector4Vector4_Internal(ptr, ptr2, ErrorTolerance);
		}

		// Token: 0x06002670 RID: 9840
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_Vector2DVector2D(FVector2D A, FVector2D B, float ErrorTolerance = 0.0001f);

		// Token: 0x06002671 RID: 9841 RVA: 0x00036EB5 File Offset: 0x000350B5
		public static bool NotEqual_TimespanTimespan(FTimespan A, FTimespan B)
		{
			return UKismetMathLibrary.__NotEqual_TimespanTimespan_Internal((A ?? new FTimespan()).NativePtr, (B ?? new FTimespan()).NativePtr);
		}

		// Token: 0x06002672 RID: 9842
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_RotatorRotator(FRotator A, FRotator B, float ErrorTolerance = 0.0001f);

		// Token: 0x06002673 RID: 9843 RVA: 0x00036EDC File Offset: 0x000350DC
		public unsafe static bool NotEqual_QuatQuat(in FQuat A, in FQuat B, float ErrorTolerance = 0.0001f)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FQuat ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__NotEqual_QuatQuat_Internal(ptr, ptr2, ErrorTolerance);
		}

		// Token: 0x06002674 RID: 9844 RVA: 0x00036F29 File Offset: 0x00035129
		public static bool NotEqual_ObjectObject(UObject A, UObject B)
		{
			return UKismetMathLibrary.__NotEqual_ObjectObject_Internal((A != null) ? A.NativePtr : IntPtr.Zero, (B != null) ? B.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002675 RID: 9845
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_NameName(FName A, FName B);

		// Token: 0x06002676 RID: 9846 RVA: 0x00036F50 File Offset: 0x00035150
		public unsafe static bool NotEqual_MatrixMatrix(in FMatrix A, in FMatrix B, float Tolerance = 0.0001f)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FMatrix ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__NotEqual_MatrixMatrix_Internal(ptr, ptr2, Tolerance);
		}

		// Token: 0x06002677 RID: 9847
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_LinearColorLinearColor(FLinearColor A, FLinearColor B);

		// Token: 0x06002678 RID: 9848
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_IntPointIntPoint(FIntPoint A, FIntPoint B);

		// Token: 0x06002679 RID: 9849
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_IntInt(int A, int B);

		// Token: 0x0600267A RID: 9850
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_Int64Int64(long A, long B);

		// Token: 0x0600267B RID: 9851
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_FloatFloat(float A, float B);

		// Token: 0x0600267C RID: 9852 RVA: 0x00036F9D File Offset: 0x0003519D
		public static bool NotEqual_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			return UKismetMathLibrary.__NotEqual_DateTimeDateTime_Internal((A ?? new FDateTime()).NativePtr, (B ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600267D RID: 9853
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_ClassClass(UClassStackOnlyPtr A, UClassStackOnlyPtr B);

		// Token: 0x0600267E RID: 9854
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_ByteByte(byte A, byte B);

		// Token: 0x0600267F RID: 9855
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_BoolBool(bool A, bool B);

		// Token: 0x06002680 RID: 9856
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Not_PreBool(bool A);

		// Token: 0x06002681 RID: 9857
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Not_Int64(long A);

		// Token: 0x06002682 RID: 9858
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Not_Int(int A);

		// Token: 0x06002683 RID: 9859
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D NormalSafe2D(FVector2D A, float Tolerance = 0f);

		// Token: 0x06002684 RID: 9860
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float NormalizeToRange(float Value, float RangeMin, float RangeMax);

		// Token: 0x06002685 RID: 9861
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator NormalizedDeltaRotator(FRotator A, FRotator B);

		// Token: 0x06002686 RID: 9862
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float NormalizeAxis(float Angle);

		// Token: 0x06002687 RID: 9863
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Normalize2D(ref FVector2D A, float Tolerance = 0f);

		// Token: 0x06002688 RID: 9864
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Normal2D(FVector2D A);

		// Token: 0x06002689 RID: 9865
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Normal(FVector A, float Tolerance = 0.0001f);

		// Token: 0x0600268A RID: 9866
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector NegateVector(FVector A);

		// Token: 0x0600268B RID: 9867
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator NegateRotator(FRotator A);

		// Token: 0x0600268C RID: 9868
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Negated2D(in FVector2D A);

		// Token: 0x0600268D RID: 9869 RVA: 0x00036FC4 File Offset: 0x000351C4
		public unsafe static bool NearlyEqual_TransformTransform(in FTransform A, in FTransform B, float LocationTolerance = 0.0001f, float RotationTolerance = 0.0001f, float Scale3DTolerance = 0.0001f)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__NearlyEqual_TransformTransform_Internal(ptr, ptr2, LocationTolerance, RotationTolerance, Scale3DTolerance);
		}

		// Token: 0x0600268E RID: 9870
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NearlyEqual_FloatFloat(float A, float B, float ErrorTolerance = 1E-06f);

		// Token: 0x0600268F RID: 9871
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float MultiplyMultiply_FloatFloat(float Base, float Exp);

		// Token: 0x06002690 RID: 9872
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float MultiplyByPi(float Value);

		// Token: 0x06002691 RID: 9873
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Multiply_VectorVector(FVector A, FVector B);

		// Token: 0x06002692 RID: 9874
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Multiply_VectorInt(FVector A, int B);

		// Token: 0x06002693 RID: 9875
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Multiply_VectorFloat(FVector A, float B);

		// Token: 0x06002694 RID: 9876 RVA: 0x00037014 File Offset: 0x00035214
		public unsafe static FVector4 Multiply_Vector4Vector4(in FVector4 A, in FVector4 B)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Multiply_Vector4Vector4_Internal(ptr, ptr2);
		}

		// Token: 0x06002695 RID: 9877
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Multiply_Vector2DVector2D(FVector2D A, FVector2D B);

		// Token: 0x06002696 RID: 9878
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Multiply_Vector2DFloat(FVector2D A, float B);

		// Token: 0x06002697 RID: 9879 RVA: 0x00037060 File Offset: 0x00035260
		[NullableContext(1)]
		public static FTimespan Multiply_TimespanFloat([Nullable(2)] FTimespan A, float Scalar)
		{
			return new FTimespan(UKismetMathLibrary.__Multiply_TimespanFloat_Internal((A ?? new FTimespan()).NativePtr, Scalar), null);
		}

		// Token: 0x06002698 RID: 9880
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator Multiply_RotatorInt(FRotator A, int B);

		// Token: 0x06002699 RID: 9881
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator Multiply_RotatorFloat(FRotator A, float B);

		// Token: 0x0600269A RID: 9882 RVA: 0x00037080 File Offset: 0x00035280
		public unsafe static FQuat Multiply_QuatQuat(in FQuat A, in FQuat B)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FQuat ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Multiply_QuatQuat_Internal(ptr, ptr2);
		}

		// Token: 0x0600269B RID: 9883 RVA: 0x000370CC File Offset: 0x000352CC
		public unsafe static FMatrix Multiply_MatrixMatrix(in FMatrix A, in FMatrix B)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FMatrix ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Multiply_MatrixMatrix_Internal(ptr, ptr2);
		}

		// Token: 0x0600269C RID: 9884 RVA: 0x00037118 File Offset: 0x00035318
		public unsafe static FMatrix Multiply_MatrixFloat(in FMatrix A, float B)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Multiply_MatrixFloat_Internal(uintPtr, B);
		}

		// Token: 0x0600269D RID: 9885
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor Multiply_LinearColorLinearColor(FLinearColor A, FLinearColor B);

		// Token: 0x0600269E RID: 9886
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor Multiply_LinearColorFloat(FLinearColor A, float B);

		// Token: 0x0600269F RID: 9887
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint Multiply_IntPointIntPoint(FIntPoint A, FIntPoint B);

		// Token: 0x060026A0 RID: 9888
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint Multiply_IntPointInt(FIntPoint A, int B);

		// Token: 0x060026A1 RID: 9889
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Multiply_IntInt(int A, int B);

		// Token: 0x060026A2 RID: 9890
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Multiply_IntFloat(int A, float B);

		// Token: 0x060026A3 RID: 9891
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Multiply_Int64Int64(long A, long B);

		// Token: 0x060026A4 RID: 9892
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Multiply_FloatFloat(float A, float B);

		// Token: 0x060026A5 RID: 9893
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte Multiply_ByteByte(byte A, byte B);

		// Token: 0x060026A6 RID: 9894
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector MirrorVectorByNormal(FVector InVect, FVector InNormal);

		// Token: 0x060026A7 RID: 9895 RVA: 0x00037148 File Offset: 0x00035348
		public unsafe static void MinOfIntArray(in TArray<int> IntArray, ref int IndexOfMinValue, ref int MinValue)
		{
			fixed (int* ptr = &IndexOfMinValue)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &MinValue)
				{
					void* ptr4 = (void*)ptr3;
					UKismetMathLibrary.__MinOfIntArray_Internal((IntArray ?? new TArray<int>()).NativePtr, ref IndexOfMinValue, ref MinValue);
					ptr = null;
				}
			}
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x0003717C File Offset: 0x0003537C
		public unsafe static void MinOfFloatArray(in TArray<float> FloatArray, ref int IndexOfMinValue, ref float MinValue)
		{
			fixed (int* ptr = &IndexOfMinValue)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &MinValue)
				{
					void* ptr4 = (void*)ptr3;
					UKismetMathLibrary.__MinOfFloatArray_Internal((FloatArray ?? new TArray<float>()).NativePtr, ref IndexOfMinValue, ref MinValue);
					ptr = null;
				}
			}
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x000371B0 File Offset: 0x000353B0
		public unsafe static void MinOfByteArray(in TArray<byte> ByteArray, ref int IndexOfMinValue, ref byte MinValue)
		{
			fixed (int* ptr = &IndexOfMinValue)
			{
				void* ptr2 = (void*)ptr;
				fixed (byte* ptr3 = &MinValue)
				{
					void* ptr4 = (void*)ptr3;
					UKismetMathLibrary.__MinOfByteArray_Internal((ByteArray ?? new TArray<byte>()).NativePtr, ref IndexOfMinValue, ref MinValue);
					ptr = null;
				}
			}
		}

		// Token: 0x060026AA RID: 9898
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long MinInt64(long A, long B);

		// Token: 0x060026AB RID: 9899 RVA: 0x000371E4 File Offset: 0x000353E4
		public unsafe static void MinimumAreaRectangle(UObject WorldContextObject, in TArray<FVector> InVerts, in FVector SampleSurfaceNormal, ref FVector OutRectCenter, ref FRotator OutRectRotation, ref float OutSideLengthX, ref float OutSideLengthY, bool bDebugDraw = false)
		{
			fixed (FVector* ptr = &OutRectCenter)
			{
				void* ptr2 = (void*)ptr;
				fixed (FRotator* ptr3 = &OutRectRotation)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &OutSideLengthX)
					{
						void* ptr6 = (void*)ptr5;
						fixed (float* ptr7 = &OutSideLengthY)
						{
							void* ptr8 = (void*)ptr7;
							UKismetMathLibrary.__MinimumAreaRectangle_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (InVerts ?? new TArray<FVector>()).NativePtr, SampleSurfaceNormal, ref OutRectCenter, ref OutRectRotation, ref OutSideLengthX, ref OutSideLengthY, bDebugDraw);
							ptr = null;
							ptr3 = null;
							ptr5 = null;
						}
					}
				}
			}
		}

		// Token: 0x060026AC RID: 9900
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Min(int A, int B);

		// Token: 0x060026AD RID: 9901 RVA: 0x00037250 File Offset: 0x00035450
		public unsafe static void MaxOfIntArray(in TArray<int> IntArray, ref int IndexOfMaxValue, ref int MaxValue)
		{
			fixed (int* ptr = &IndexOfMaxValue)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &MaxValue)
				{
					void* ptr4 = (void*)ptr3;
					UKismetMathLibrary.__MaxOfIntArray_Internal((IntArray ?? new TArray<int>()).NativePtr, ref IndexOfMaxValue, ref MaxValue);
					ptr = null;
				}
			}
		}

		// Token: 0x060026AE RID: 9902 RVA: 0x00037284 File Offset: 0x00035484
		public unsafe static void MaxOfFloatArray(in TArray<float> FloatArray, ref int IndexOfMaxValue, ref float MaxValue)
		{
			fixed (int* ptr = &IndexOfMaxValue)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &MaxValue)
				{
					void* ptr4 = (void*)ptr3;
					UKismetMathLibrary.__MaxOfFloatArray_Internal((FloatArray ?? new TArray<float>()).NativePtr, ref IndexOfMaxValue, ref MaxValue);
					ptr = null;
				}
			}
		}

		// Token: 0x060026AF RID: 9903 RVA: 0x000372B8 File Offset: 0x000354B8
		public unsafe static void MaxOfByteArray(in TArray<byte> ByteArray, ref int IndexOfMaxValue, ref byte MaxValue)
		{
			fixed (int* ptr = &IndexOfMaxValue)
			{
				void* ptr2 = (void*)ptr;
				fixed (byte* ptr3 = &MaxValue)
				{
					void* ptr4 = (void*)ptr3;
					UKismetMathLibrary.__MaxOfByteArray_Internal((ByteArray ?? new TArray<byte>()).NativePtr, ref IndexOfMaxValue, ref MaxValue);
					ptr = null;
				}
			}
		}

		// Token: 0x060026B0 RID: 9904
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long MaxInt64(long A, long B);

		// Token: 0x060026B1 RID: 9905
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Max(int A, int B);

		// Token: 0x060026B2 RID: 9906 RVA: 0x000372EC File Offset: 0x000354EC
		public unsafe static FVector4 Matrix_TransformVector4(in FMatrix M, FVector4 V)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = M;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = V;
			return UKismetMathLibrary.__Matrix_TransformVector4_Internal(ptr, ptr2);
		}

		// Token: 0x060026B3 RID: 9907 RVA: 0x00037334 File Offset: 0x00035534
		public unsafe static FVector4 Matrix_TransformVector(in FMatrix M, FVector V)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_TransformVector_Internal(uintPtr, V);
		}

		// Token: 0x060026B4 RID: 9908 RVA: 0x00037364 File Offset: 0x00035564
		public unsafe static FVector4 Matrix_TransformPosition(in FMatrix M, FVector V)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_TransformPosition_Internal(uintPtr, V);
		}

		// Token: 0x060026B5 RID: 9909 RVA: 0x00037394 File Offset: 0x00035594
		public unsafe static FQuat Matrix_ToQuat(in FMatrix M)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_ToQuat_Internal(uintPtr);
		}

		// Token: 0x060026B6 RID: 9910 RVA: 0x000373C4 File Offset: 0x000355C4
		public unsafe static void Matrix_SetOrigin(ref FMatrix M, FVector NewOrigin)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = M;
			UKismetMathLibrary.__Matrix_SetOrigin_Internal(ref ptr, NewOrigin);
			M = ptr;
		}

		// Token: 0x060026B7 RID: 9911 RVA: 0x00037400 File Offset: 0x00035600
		public unsafe static void Matrix_SetAxis(ref FMatrix M, EAxis Axis, FVector AxisVector)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = M;
			UKismetMathLibrary.__Matrix_SetAxis_Internal(ref ptr, Axis, AxisVector);
			M = ptr;
		}

		// Token: 0x060026B8 RID: 9912 RVA: 0x00037444 File Offset: 0x00035644
		public unsafe static FMatrix Matrix_ScaleTranslation(in FMatrix M, FVector Scale3D)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_ScaleTranslation_Internal(uintPtr, Scale3D);
		}

		// Token: 0x060026B9 RID: 9913 RVA: 0x00037474 File Offset: 0x00035674
		public unsafe static FMatrix Matrix_RemoveTranslation(in FMatrix M)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_RemoveTranslation_Internal(uintPtr);
		}

		// Token: 0x060026BA RID: 9914 RVA: 0x000374A4 File Offset: 0x000356A4
		public unsafe static void Matrix_RemoveScaling(ref FMatrix M, float Tolerance = 0f)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = M;
			UKismetMathLibrary.__Matrix_RemoveScaling_Internal(ref ptr, Tolerance);
			M = ptr;
		}

		// Token: 0x060026BB RID: 9915 RVA: 0x000374E0 File Offset: 0x000356E0
		public unsafe static FMatrix Matrix_Mirror(in FMatrix M, EAxis MirrorAxis, EAxis FlipAxis)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_Mirror_Internal(uintPtr, MirrorAxis, FlipAxis);
		}

		// Token: 0x060026BC RID: 9916 RVA: 0x0003751C File Offset: 0x0003571C
		public unsafe static FVector Matrix_InverseTransformVector(in FMatrix M, FVector V)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_InverseTransformVector_Internal(uintPtr, V);
		}

		// Token: 0x060026BD RID: 9917 RVA: 0x0003754C File Offset: 0x0003574C
		public unsafe static FVector Matrix_InverseTransformPosition(in FMatrix M, FVector V)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_InverseTransformPosition_Internal(uintPtr, V);
		}

		// Token: 0x060026BE RID: 9918
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FMatrix Matrix_Identity();

		// Token: 0x060026BF RID: 9919 RVA: 0x0003757C File Offset: 0x0003577C
		public unsafe static FVector Matrix_GetUnitAxis(in FMatrix M, EAxis Axis)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_GetUnitAxis_Internal(uintPtr, Axis);
		}

		// Token: 0x060026C0 RID: 9920 RVA: 0x000375B0 File Offset: 0x000357B0
		public unsafe static void Matrix_GetUnitAxes(in FMatrix M, ref FVector X, ref FVector Y, ref FVector Z)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			fixed (FVector* ptr = &X)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &Y)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FVector* ptr5 = &Z)
					{
						void* ptr6 = (void*)ptr5;
						UKismetMathLibrary.__Matrix_GetUnitAxes_Internal(uintPtr, ref X, ref Y, ref Z);
						ptr = null;
						ptr3 = null;
					}
				}
			}
		}

		// Token: 0x060026C1 RID: 9921 RVA: 0x00037600 File Offset: 0x00035800
		public unsafe static FMatrix Matrix_GetTransposed(in FMatrix M)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_GetTransposed_Internal(uintPtr);
		}

		// Token: 0x060026C2 RID: 9922 RVA: 0x00037630 File Offset: 0x00035830
		public unsafe static FMatrix Matrix_GetTransposeAdjoint(in FMatrix M)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_GetTransposeAdjoint_Internal(uintPtr);
		}

		// Token: 0x060026C3 RID: 9923 RVA: 0x00037660 File Offset: 0x00035860
		public unsafe static FVector Matrix_GetScaleVector(in FMatrix M, float Tolerance = 0f)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_GetScaleVector_Internal(uintPtr, Tolerance);
		}

		// Token: 0x060026C4 RID: 9924 RVA: 0x00037690 File Offset: 0x00035890
		public unsafe static FVector Matrix_GetScaledAxis(in FMatrix M, EAxis Axis)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_GetScaledAxis_Internal(uintPtr, Axis);
		}

		// Token: 0x060026C5 RID: 9925 RVA: 0x000376C4 File Offset: 0x000358C4
		public unsafe static void Matrix_GetScaledAxes(in FMatrix M, ref FVector X, ref FVector Y, ref FVector Z)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			fixed (FVector* ptr = &X)
			{
				void* ptr2 = (void*)ptr;
				fixed (FVector* ptr3 = &Y)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FVector* ptr5 = &Z)
					{
						void* ptr6 = (void*)ptr5;
						UKismetMathLibrary.__Matrix_GetScaledAxes_Internal(uintPtr, ref X, ref Y, ref Z);
						ptr = null;
						ptr3 = null;
					}
				}
			}
		}

		// Token: 0x060026C6 RID: 9926 RVA: 0x00037714 File Offset: 0x00035914
		public unsafe static float Matrix_GetRotDeterminant(in FMatrix M)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_GetRotDeterminant_Internal(uintPtr);
		}

		// Token: 0x060026C7 RID: 9927 RVA: 0x00037744 File Offset: 0x00035944
		public unsafe static FRotator Matrix_GetRotator(in FMatrix M)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_GetRotator_Internal(uintPtr);
		}

		// Token: 0x060026C8 RID: 9928 RVA: 0x00037774 File Offset: 0x00035974
		public unsafe static FVector Matrix_GetOrigin(in FMatrix InMatrix)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = InMatrix;
			return UKismetMathLibrary.__Matrix_GetOrigin_Internal(uintPtr);
		}

		// Token: 0x060026C9 RID: 9929 RVA: 0x000377A4 File Offset: 0x000359A4
		public unsafe static float Matrix_GetMaximumAxisScale(in FMatrix M)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_GetMaximumAxisScale_Internal(uintPtr);
		}

		// Token: 0x060026CA RID: 9930 RVA: 0x000377D4 File Offset: 0x000359D4
		public unsafe static FMatrix Matrix_GetMatrixWithoutScale(in FMatrix M, float Tolerance = 0f)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_GetMatrixWithoutScale_Internal(uintPtr, Tolerance);
		}

		// Token: 0x060026CB RID: 9931 RVA: 0x00037804 File Offset: 0x00035A04
		public unsafe static FMatrix Matrix_GetInverse(in FMatrix M)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_GetInverse_Internal(uintPtr);
		}

		// Token: 0x060026CC RID: 9932 RVA: 0x00037834 File Offset: 0x00035A34
		public unsafe static bool Matrix_GetFrustumTopPlane(in FMatrix M, ref FPlane OutPlane)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = M;
			ref FPlane ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = OutPlane;
			bool result = UKismetMathLibrary.__Matrix_GetFrustumTopPlane_Internal(ptr, ref ptr2);
			OutPlane = ptr2;
			return result;
		}

		// Token: 0x060026CD RID: 9933 RVA: 0x0003788C File Offset: 0x00035A8C
		public unsafe static bool Matrix_GetFrustumRightPlane(in FMatrix M, ref FPlane OutPlane)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = M;
			ref FPlane ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = OutPlane;
			bool result = UKismetMathLibrary.__Matrix_GetFrustumRightPlane_Internal(ptr, ref ptr2);
			OutPlane = ptr2;
			return result;
		}

		// Token: 0x060026CE RID: 9934 RVA: 0x000378E4 File Offset: 0x00035AE4
		public unsafe static bool Matrix_GetFrustumNearPlane(in FMatrix M, ref FPlane OutPlane)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = M;
			ref FPlane ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = OutPlane;
			bool result = UKismetMathLibrary.__Matrix_GetFrustumNearPlane_Internal(ptr, ref ptr2);
			OutPlane = ptr2;
			return result;
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x0003793C File Offset: 0x00035B3C
		public unsafe static bool Matrix_GetFrustumLeftPlane(in FMatrix M, ref FPlane OutPlane)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = M;
			ref FPlane ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = OutPlane;
			bool result = UKismetMathLibrary.__Matrix_GetFrustumLeftPlane_Internal(ptr, ref ptr2);
			OutPlane = ptr2;
			return result;
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x00037994 File Offset: 0x00035B94
		public unsafe static bool Matrix_GetFrustumFarPlane(in FMatrix M, ref FPlane OutPlane)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = M;
			ref FPlane ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = OutPlane;
			bool result = UKismetMathLibrary.__Matrix_GetFrustumFarPlane_Internal(ptr, ref ptr2);
			OutPlane = ptr2;
			return result;
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x000379EC File Offset: 0x00035BEC
		public unsafe static bool Matrix_GetFrustumBottomPlane(in FMatrix M, ref FPlane OutPlane)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = M;
			ref FPlane ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = OutPlane;
			bool result = UKismetMathLibrary.__Matrix_GetFrustumBottomPlane_Internal(ptr, ref ptr2);
			OutPlane = ptr2;
			return result;
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x00037A44 File Offset: 0x00035C44
		public unsafe static float Matrix_GetDeterminant(in FMatrix M)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_GetDeterminant_Internal(uintPtr);
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x00037A74 File Offset: 0x00035C74
		public unsafe static bool Matrix_ContainsNaN(in FMatrix M)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_ContainsNaN_Internal(uintPtr);
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x00037AA4 File Offset: 0x00035CA4
		public unsafe static FMatrix Matrix_ConcatenateTranslation(in FMatrix M, FVector Translation)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_ConcatenateTranslation_Internal(uintPtr, Translation);
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x00037AD4 File Offset: 0x00035CD4
		public unsafe static FMatrix Matrix_ApplyScale(in FMatrix M, float Scale)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_ApplyScale_Internal(uintPtr, Scale);
		}

		// Token: 0x060026D6 RID: 9942
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float MapRangeUnclamped(float Value, float InRangeA, float InRangeB, float OutRangeA, float OutRangeB);

		// Token: 0x060026D7 RID: 9943
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float MapRangeClamped(float Value, float InRangeA, float InRangeB, float OutRangeA, float OutRangeB);

		// Token: 0x060026D8 RID: 9944
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble MakeVectorDouble(double X, double Y, double Z);

		// Token: 0x060026D9 RID: 9945
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector4 MakeVector4(float X, float Y, float Z, float W);

		// Token: 0x060026DA RID: 9946
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble MakeVector2DDouble(double X, double Y);

		// Token: 0x060026DB RID: 9947
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D MakeVector2D(float X, float Y);

		// Token: 0x060026DC RID: 9948
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector MakeVector(float X, float Y, float Z);

		// Token: 0x060026DD RID: 9949
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FTransformDouble MakeTransformDouble(FVectorDouble Location, FRotator Rotation, FVector Scale);

		// Token: 0x060026DE RID: 9950
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FTransform MakeTransform(FVector Location, FRotator Rotation, FVector Scale);

		// Token: 0x060026DF RID: 9951 RVA: 0x00037B02 File Offset: 0x00035D02
		[NullableContext(1)]
		public static FTimespan MakeTimespan2(int Days, int Hours, int Minutes, int Seconds, int FractionNano)
		{
			return new FTimespan(UKismetMathLibrary.__MakeTimespan2_Internal(Days, Hours, Minutes, Seconds, FractionNano), null);
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x00037B15 File Offset: 0x00035D15
		[NullableContext(1)]
		public static FTimespan MakeTimespan(int Days, int Hours, int Minutes, int Seconds, int Milliseconds)
		{
			return new FTimespan(UKismetMathLibrary.__MakeTimespan_Internal(Days, Hours, Minutes, Seconds, Milliseconds), null);
		}

		// Token: 0x060026E1 RID: 9953
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator MakeRotFromZY(in FVector Z, in FVector Y);

		// Token: 0x060026E2 RID: 9954
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator MakeRotFromZX(in FVector Z, in FVector X);

		// Token: 0x060026E3 RID: 9955
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator MakeRotFromZ(in FVector Z);

		// Token: 0x060026E4 RID: 9956
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator MakeRotFromYZ(in FVector Y, in FVector Z);

		// Token: 0x060026E5 RID: 9957
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator MakeRotFromYX(in FVector Y, in FVector X);

		// Token: 0x060026E6 RID: 9958
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator MakeRotFromY(in FVector Y);

		// Token: 0x060026E7 RID: 9959
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator MakeRotFromXZ(in FVector X, in FVector Z);

		// Token: 0x060026E8 RID: 9960
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator MakeRotFromXY(in FVector X, in FVector Y);

		// Token: 0x060026E9 RID: 9961
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator MakeRotFromX(in FVector X);

		// Token: 0x060026EA RID: 9962
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator MakeRotator(float Roll, float Pitch, float Yaw);

		// Token: 0x060026EB RID: 9963
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator MakeRotationFromAxes(FVector Forward, FVector Right, FVector Up);

		// Token: 0x060026EC RID: 9964 RVA: 0x00037B28 File Offset: 0x00035D28
		public unsafe static FTransform MakeRelativeTransform(in FTransform A, in FTransform RelativeTo)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = RelativeTo;
			return UKismetMathLibrary.__MakeRelativeTransform_Internal(ptr, ptr2);
		}

		// Token: 0x060026ED RID: 9965
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRandomStream MakeRandomStream(int InitialSeed);

		// Token: 0x060026EE RID: 9966 RVA: 0x00037B74 File Offset: 0x00035D74
		[NullableContext(1)]
		public static FQualifiedFrameTime MakeQualifiedFrameTime([Nullable(2)] FFrameNumber Frame, FFrameRate FrameRate, float SubFrame = 0f)
		{
			return new FQualifiedFrameTime(UKismetMathLibrary.__MakeQualifiedFrameTime_Internal((Frame ?? new FFrameNumber()).NativePtr, FrameRate, SubFrame), null);
		}

		// Token: 0x060026EF RID: 9967
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float MakePulsatingValue(float InCurrentTime, float InPulsesPerSecond = 1f, float InPhase = 0f);

		// Token: 0x060026F0 RID: 9968
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FPlane MakePlaneFromPointAndNormal(FVector Point, FVector Normal);

		// Token: 0x060026F1 RID: 9969
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FFrameRate MakeFrameRate(int Numerator, int Denominator = 1);

		// Token: 0x060026F2 RID: 9970 RVA: 0x00037B92 File Offset: 0x00035D92
		[NullableContext(1)]
		public static FDateTime MakeDateTime(int Year, int Month, int Day, int Hour = 0, int Minute = 0, int Second = 0, int Millisecond = 0)
		{
			return new FDateTime(UKismetMathLibrary.__MakeDateTime_Internal(Year, Month, Day, Hour, Minute, Second, Millisecond), null);
		}

		// Token: 0x060026F3 RID: 9971
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor MakeColor(float R, float G, float B, float A = 1f);

		// Token: 0x060026F4 RID: 9972
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FBox2D MakeBox2D(FVector2D Min, FVector2D Max);

		// Token: 0x060026F5 RID: 9973
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FBox MakeBox(FVector Min, FVector Max);

		// Token: 0x060026F6 RID: 9974
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Loge(float A);

		// Token: 0x060026F7 RID: 9975
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Log(float A, float Base = 1f);

		// Token: 0x060026F8 RID: 9976
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool LinePlaneIntersection_OriginNormal(in FVector LineStart, in FVector LineEnd, FVector PlaneOrigin, FVector PlaneNormal, ref float T, ref FVector Intersection);

		// Token: 0x060026F9 RID: 9977 RVA: 0x00037BAC File Offset: 0x00035DAC
		public unsafe static bool LinePlaneIntersection(in FVector LineStart, in FVector LineEnd, in FPlane APlane, ref float T, ref FVector Intersection)
		{
			ref FPlane ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = APlane;
			fixed (float* ptr2 = &T)
			{
				void* ptr3 = (void*)ptr2;
				fixed (FVector* ptr4 = &Intersection)
				{
					void* ptr5 = (void*)ptr4;
					return UKismetMathLibrary.__LinePlaneIntersection_Internal(LineStart, LineEnd, ptr, ref T, ref Intersection);
				}
			}
		}

		// Token: 0x060026FA RID: 9978
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColorLerpUsingHSV(FLinearColor A, FLinearColor B, float Alpha);

		// Token: 0x060026FB RID: 9979
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColorLerp(FLinearColor A, FLinearColor B, float Alpha);

		// Token: 0x060026FC RID: 9980
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColor_Yellow();

		// Token: 0x060026FD RID: 9981
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColor_White();

		// Token: 0x060026FE RID: 9982
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColor_Transparent();

		// Token: 0x060026FF RID: 9983
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FColor LinearColor_ToRGBE(FLinearColor InLinearColor);

		// Token: 0x06002700 RID: 9984
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColor_ToNewOpacity(FLinearColor InColor, float InOpacity);

		// Token: 0x06002701 RID: 9985
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LinearColor_SetTemperature(ref FLinearColor InOutColor, float InTemperature);

		// Token: 0x06002702 RID: 9986
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LinearColor_SetRGBA(ref FLinearColor InOutColor, float R, float G, float B, float A = 1f);

		// Token: 0x06002703 RID: 9987
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LinearColor_SetRandomHue(ref FLinearColor InOutColor);

		// Token: 0x06002704 RID: 9988
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LinearColor_SetFromSRGB(ref FLinearColor InOutColor, in FColor InSRGB);

		// Token: 0x06002705 RID: 9989
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LinearColor_SetFromPow22(ref FLinearColor InOutColor, in FColor InColor);

		// Token: 0x06002706 RID: 9990
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LinearColor_SetFromHSV(ref FLinearColor InOutColor, float H, float S, float V, float A = 1f);

		// Token: 0x06002707 RID: 9991
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LinearColor_Set(ref FLinearColor InOutColor, FLinearColor InColor);

		// Token: 0x06002708 RID: 9992
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColor_Red();

		// Token: 0x06002709 RID: 9993
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FColor LinearColor_QuantizeRound(FLinearColor InColor);

		// Token: 0x0600270A RID: 9994
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FColor LinearColor_Quantize(FLinearColor InColor);

		// Token: 0x0600270B RID: 9995
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool LinearColor_IsNearEqual(FLinearColor A, FLinearColor B, float Tolerance = 0.0001f);

		// Token: 0x0600270C RID: 9996
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColor_Green();

		// Token: 0x0600270D RID: 9997
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColor_Gray();

		// Token: 0x0600270E RID: 9998
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float LinearColor_GetMin(FLinearColor InColor);

		// Token: 0x0600270F RID: 9999
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float LinearColor_GetMax(FLinearColor InColor);

		// Token: 0x06002710 RID: 10000
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float LinearColor_GetLuminance(FLinearColor InColor);

		// Token: 0x06002711 RID: 10001
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float LinearColor_Distance(FLinearColor C1, FLinearColor C2);

		// Token: 0x06002712 RID: 10002
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColor_Desaturated(FLinearColor InColor, float InDesaturation);

		// Token: 0x06002713 RID: 10003
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColor_Blue();

		// Token: 0x06002714 RID: 10004
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColor_Black();

		// Token: 0x06002715 RID: 10005
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector LessLess_VectorRotator(FVector A, FRotator B);

		// Token: 0x06002716 RID: 10006 RVA: 0x00037BED File Offset: 0x00035DED
		public static bool LessEqual_TimespanTimespan(FTimespan A, FTimespan B)
		{
			return UKismetMathLibrary.__LessEqual_TimespanTimespan_Internal((A ?? new FTimespan()).NativePtr, (B ?? new FTimespan()).NativePtr);
		}

		// Token: 0x06002717 RID: 10007
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool LessEqual_IntInt(int A, int B);

		// Token: 0x06002718 RID: 10008
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool LessEqual_Int64Int64(long A, long B);

		// Token: 0x06002719 RID: 10009
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool LessEqual_FloatFloat(float A, float B);

		// Token: 0x0600271A RID: 10010 RVA: 0x00037C12 File Offset: 0x00035E12
		public static bool LessEqual_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			return UKismetMathLibrary.__LessEqual_DateTimeDateTime_Internal((A ?? new FDateTime()).NativePtr, (B ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600271B RID: 10011
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool LessEqual_ByteByte(byte A, byte B);

		// Token: 0x0600271C RID: 10012 RVA: 0x00037C37 File Offset: 0x00035E37
		public static bool Less_TimespanTimespan(FTimespan A, FTimespan B)
		{
			return UKismetMathLibrary.__Less_TimespanTimespan_Internal((A ?? new FTimespan()).NativePtr, (B ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600271D RID: 10013
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Less_IntInt(int A, int B);

		// Token: 0x0600271E RID: 10014
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Less_Int64Int64(long A, long B);

		// Token: 0x0600271F RID: 10015
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Less_FloatFloat(float A, float B);

		// Token: 0x06002720 RID: 10016 RVA: 0x00037C5C File Offset: 0x00035E5C
		public static bool Less_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			return UKismetMathLibrary.__Less_DateTimeDateTime_Internal((A ?? new FDateTime()).NativePtr, (B ?? new FDateTime()).NativePtr);
		}

		// Token: 0x06002721 RID: 10017
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Less_ByteByte(byte A, byte B);

		// Token: 0x06002722 RID: 10018
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Lerp(float A, float B, float Alpha);

		// Token: 0x06002723 RID: 10019
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsZero2D(in FVector2D A);

		// Token: 0x06002724 RID: 10020 RVA: 0x00037C84 File Offset: 0x00035E84
		public unsafe static bool IsPointInBoxWithTransform(FVector Point, in FTransform BoxWorldTransform, FVector BoxExtent)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = BoxWorldTransform;
			return UKismetMathLibrary.__IsPointInBoxWithTransform_Internal(Point, ptr, BoxExtent);
		}

		// Token: 0x06002725 RID: 10021
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsPointInBox(FVector Point, FVector BoxOrigin, FVector BoxExtent);

		// Token: 0x06002726 RID: 10022
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsNearlyZero2D(in FVector2D A, float Tolerance = 0.0001f);

		// Token: 0x06002727 RID: 10023 RVA: 0x00037CB5 File Offset: 0x00035EB5
		public static bool IsMorning(FDateTime A)
		{
			return UKismetMathLibrary.__IsMorning_Internal((A ?? new FDateTime()).NativePtr);
		}

		// Token: 0x06002728 RID: 10024
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsLeapYear(int Year);

		// Token: 0x06002729 RID: 10025 RVA: 0x00037CCB File Offset: 0x00035ECB
		public static bool IsAfternoon(FDateTime A)
		{
			return UKismetMathLibrary.__IsAfternoon_Internal((A ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x00037CE4 File Offset: 0x00035EE4
		public unsafe static FTransform InvertTransform(in FTransform T)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__InvertTransform_Internal(uintPtr);
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x00037D14 File Offset: 0x00035F14
		public unsafe static FRotator InverseTransformRotation(in FTransform T, FRotator Rotation)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__InverseTransformRotation_Internal(uintPtr, Rotation);
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x00037D44 File Offset: 0x00035F44
		public unsafe static FVector InverseTransformLocation(in FTransform T, FVector Location)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__InverseTransformLocation_Internal(uintPtr, Location);
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x00037D74 File Offset: 0x00035F74
		public unsafe static FVector InverseTransformDirection(in FTransform T, FVector Direction)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__InverseTransformDirection_Internal(uintPtr, Direction);
		}

		// Token: 0x0600272E RID: 10030
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint IntPoint_Zero();

		// Token: 0x0600272F RID: 10031
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint IntPoint_Up();

		// Token: 0x06002730 RID: 10032
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint IntPoint_Right();

		// Token: 0x06002731 RID: 10033
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint IntPoint_One();

		// Token: 0x06002732 RID: 10034
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint IntPoint_Left();

		// Token: 0x06002733 RID: 10035
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint IntPoint_Down();

		// Token: 0x06002734 RID: 10036
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool InRange_IntInt(int Value, int Min, int Max, bool InclusiveMin = true, bool InclusiveMax = true);

		// Token: 0x06002735 RID: 10037
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool InRange_Int64Int64(long Value, long Min, long Max, bool InclusiveMin = true, bool InclusiveMax = true);

		// Token: 0x06002736 RID: 10038
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool InRange_FloatFloat(float Value, float Min, float Max, bool InclusiveMin = true, bool InclusiveMax = true);

		// Token: 0x06002737 RID: 10039
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Hypotenuse(float Width, float Height);

		// Token: 0x06002738 RID: 10040
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor HSVToRGBLinear(FLinearColor HSV);

		// Token: 0x06002739 RID: 10041
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void HSVToRGB_Vector(FLinearColor HSV, ref FLinearColor RGB);

		// Token: 0x0600273A RID: 10042
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor HSVToRGB(float H, float S, float V, float A = 1f);

		// Token: 0x0600273B RID: 10043
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GridSnap_Float(float Location, float GridSize);

		// Token: 0x0600273C RID: 10044
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector GreaterGreater_VectorRotator(FVector A, FRotator B);

		// Token: 0x0600273D RID: 10045 RVA: 0x00037DA2 File Offset: 0x00035FA2
		public static bool GreaterEqual_TimespanTimespan(FTimespan A, FTimespan B)
		{
			return UKismetMathLibrary.__GreaterEqual_TimespanTimespan_Internal((A ?? new FTimespan()).NativePtr, (B ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600273E RID: 10046
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GreaterEqual_IntInt(int A, int B);

		// Token: 0x0600273F RID: 10047
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GreaterEqual_Int64Int64(long A, long B);

		// Token: 0x06002740 RID: 10048
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GreaterEqual_FloatFloat(float A, float B);

		// Token: 0x06002741 RID: 10049 RVA: 0x00037DC7 File Offset: 0x00035FC7
		public static bool GreaterEqual_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			return UKismetMathLibrary.__GreaterEqual_DateTimeDateTime_Internal((A ?? new FDateTime()).NativePtr, (B ?? new FDateTime()).NativePtr);
		}

		// Token: 0x06002742 RID: 10050
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GreaterEqual_ByteByte(byte A, byte B);

		// Token: 0x06002743 RID: 10051 RVA: 0x00037DEC File Offset: 0x00035FEC
		public static bool Greater_TimespanTimespan(FTimespan A, FTimespan B)
		{
			return UKismetMathLibrary.__Greater_TimespanTimespan_Internal((A ?? new FTimespan()).NativePtr, (B ?? new FTimespan()).NativePtr);
		}

		// Token: 0x06002744 RID: 10052
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Greater_IntInt(int A, int B);

		// Token: 0x06002745 RID: 10053
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Greater_Int64Int64(long A, long B);

		// Token: 0x06002746 RID: 10054
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Greater_FloatFloat(float A, float B);

		// Token: 0x06002747 RID: 10055 RVA: 0x00037E11 File Offset: 0x00036011
		public static bool Greater_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			return UKismetMathLibrary.__Greater_DateTimeDateTime_Internal((A ?? new FDateTime()).NativePtr, (B ?? new FDateTime()).NativePtr);
		}

		// Token: 0x06002748 RID: 10056
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Greater_ByteByte(byte A, byte B);

		// Token: 0x06002749 RID: 10057 RVA: 0x00037E36 File Offset: 0x00036036
		public static int GetYear(FDateTime A)
		{
			return UKismetMathLibrary.__GetYear_Internal((A ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600274A RID: 10058
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetYawPitchFromVector(FVector InVec, ref float Yaw, ref float Pitch);

		// Token: 0x0600274B RID: 10059 RVA: 0x00037E4C File Offset: 0x0003604C
		public static FVector GetVectorArrayAverage(in TArray<FVector> Vectors)
		{
			return UKismetMathLibrary.__GetVectorArrayAverage_Internal((Vectors ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x0600274C RID: 10060
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector GetUpVector(FRotator InRot);

		// Token: 0x0600274D RID: 10061 RVA: 0x00037E63 File Offset: 0x00036063
		public static float GetTotalSeconds(FTimespan A)
		{
			return UKismetMathLibrary.__GetTotalSeconds_Internal((A ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x00037E79 File Offset: 0x00036079
		public static float GetTotalMinutes(FTimespan A)
		{
			return UKismetMathLibrary.__GetTotalMinutes_Internal((A ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x00037E8F File Offset: 0x0003608F
		public static float GetTotalMilliseconds(FTimespan A)
		{
			return UKismetMathLibrary.__GetTotalMilliseconds_Internal((A ?? new FTimespan()).NativePtr);
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x00037EA5 File Offset: 0x000360A5
		public static float GetTotalHours(FTimespan A)
		{
			return UKismetMathLibrary.__GetTotalHours_Internal((A ?? new FTimespan()).NativePtr);
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x00037EBB File Offset: 0x000360BB
		public static float GetTotalDays(FTimespan A)
		{
			return UKismetMathLibrary.__GetTotalDays_Internal((A ?? new FTimespan()).NativePtr);
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x00037ED1 File Offset: 0x000360D1
		[NullableContext(1)]
		public static FTimespan GetTimeOfDay([Nullable(2)] FDateTime A)
		{
			return new FTimespan(UKismetMathLibrary.__GetTimeOfDay_Internal((A ?? new FDateTime()).NativePtr), null);
		}

		// Token: 0x06002753 RID: 10067
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetTAU();

		// Token: 0x06002754 RID: 10068
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetSlopeDegreeAngles(in FVector MyRightYAxis, in FVector FloorNormal, in FVector UpVector, ref float OutSlopePitchDegreeAngle, ref float OutSlopeRollDegreeAngle);

		// Token: 0x06002755 RID: 10069 RVA: 0x00037EED File Offset: 0x000360ED
		public static int GetSeconds(FTimespan A)
		{
			return UKismetMathLibrary.__GetSeconds_Internal((A ?? new FTimespan()).NativePtr);
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x00037F03 File Offset: 0x00036103
		public static int GetSecond(FDateTime A)
		{
			return UKismetMathLibrary.__GetSecond_Internal((A ?? new FDateTime()).NativePtr);
		}

		// Token: 0x06002757 RID: 10071
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetRotated2D(FVector2D A, float AngleDeg);

		// Token: 0x06002758 RID: 10072
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector GetRightVector(FRotator InRot);

		// Token: 0x06002759 RID: 10073
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector GetReflectionVector(FVector Direction, FVector SurfaceNormal);

		// Token: 0x0600275A RID: 10074
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetPointDistanceToSegment(FVector Point, FVector SegmentStart, FVector SegmentEnd);

		// Token: 0x0600275B RID: 10075
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetPointDistanceToLine(FVector Point, FVector LineOrigin, FVector LineDirection);

		// Token: 0x0600275C RID: 10076
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetPI();

		// Token: 0x0600275D RID: 10077 RVA: 0x00037F19 File Offset: 0x00036119
		public static int GetMonth(FDateTime A)
		{
			return UKismetMathLibrary.__GetMonth_Internal((A ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x00037F2F File Offset: 0x0003612F
		public static int GetMinutes(FTimespan A)
		{
			return UKismetMathLibrary.__GetMinutes_Internal((A ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x00037F45 File Offset: 0x00036145
		public static int GetMinute(FDateTime A)
		{
			return UKismetMathLibrary.__GetMinute_Internal((A ?? new FDateTime()).NativePtr);
		}

		// Token: 0x06002760 RID: 10080
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetMinElement(FVector A);

		// Token: 0x06002761 RID: 10081
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetMin2D(FVector2D A);

		// Token: 0x06002762 RID: 10082 RVA: 0x00037F5B File Offset: 0x0003615B
		public static int GetMilliseconds(FTimespan A)
		{
			return UKismetMathLibrary.__GetMilliseconds_Internal((A ?? new FTimespan()).NativePtr);
		}

		// Token: 0x06002763 RID: 10083 RVA: 0x00037F71 File Offset: 0x00036171
		public static int GetMillisecond(FDateTime A)
		{
			return UKismetMathLibrary.__GetMillisecond_Internal((A ?? new FDateTime()).NativePtr);
		}

		// Token: 0x06002764 RID: 10084
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetMaxElement(FVector A);

		// Token: 0x06002765 RID: 10085
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetMax2D(FVector2D A);

		// Token: 0x06002766 RID: 10086 RVA: 0x00037F87 File Offset: 0x00036187
		public static int GetHours(FTimespan A)
		{
			return UKismetMathLibrary.__GetHours_Internal((A ?? new FTimespan()).NativePtr);
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x00037F9D File Offset: 0x0003619D
		public static int GetHour12(FDateTime A)
		{
			return UKismetMathLibrary.__GetHour12_Internal((A ?? new FDateTime()).NativePtr);
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x00037FB3 File Offset: 0x000361B3
		public static int GetHour(FDateTime A)
		{
			return UKismetMathLibrary.__GetHour_Internal((A ?? new FDateTime()).NativePtr);
		}

		// Token: 0x06002769 RID: 10089
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector GetForwardVector(FRotator InRot);

		// Token: 0x0600276A RID: 10090 RVA: 0x00037FC9 File Offset: 0x000361C9
		[NullableContext(1)]
		public static FTimespan GetDuration([Nullable(2)] FTimespan A)
		{
			return new FTimespan(UKismetMathLibrary.__GetDuration_Internal((A ?? new FTimespan()).NativePtr), null);
		}

		// Token: 0x0600276B RID: 10091
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector GetDirectionUnitVector(FVector From, FVector To);

		// Token: 0x0600276C RID: 10092 RVA: 0x00037FE5 File Offset: 0x000361E5
		public static int GetDays(FTimespan A)
		{
			return UKismetMathLibrary.__GetDays_Internal((A ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600276D RID: 10093 RVA: 0x00037FFB File Offset: 0x000361FB
		public static int GetDayOfYear(FDateTime A)
		{
			return UKismetMathLibrary.__GetDayOfYear_Internal((A ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600276E RID: 10094 RVA: 0x00038011 File Offset: 0x00036211
		public static int GetDay(FDateTime A)
		{
			return UKismetMathLibrary.__GetDay_Internal((A ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600276F RID: 10095 RVA: 0x00038027 File Offset: 0x00036227
		[NullableContext(1)]
		public static FDateTime GetDate([Nullable(2)] FDateTime A)
		{
			return new FDateTime(UKismetMathLibrary.__GetDate_Internal((A ?? new FDateTime()).NativePtr), null);
		}

		// Token: 0x06002770 RID: 10096 RVA: 0x00038044 File Offset: 0x00036244
		public unsafe static void GetAzimuthAndElevation(FVector InDirection, in FTransform ReferenceFrame, ref float Azimuth, ref float Elevation)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = ReferenceFrame;
			fixed (float* ptr2 = &Azimuth)
			{
				void* ptr3 = (void*)ptr2;
				fixed (float* ptr4 = &Elevation)
				{
					void* ptr5 = (void*)ptr4;
					UKismetMathLibrary.__GetAzimuthAndElevation_Internal(InDirection, ptr, ref Azimuth, ref Elevation);
					ptr2 = null;
				}
			}
		}

		// Token: 0x06002771 RID: 10097
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetAxes(FRotator A, ref FVector X, ref FVector Y, ref FVector Z);

		// Token: 0x06002772 RID: 10098
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetAbsMax2D(FVector2D A);

		// Token: 0x06002773 RID: 10099
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetAbs2D(FVector2D A);

		// Token: 0x06002774 RID: 10100
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float FWrap(float Value, float Min, float Max);

		// Token: 0x06002775 RID: 10101
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntVector FTruncVector(in FVector InVector);

		// Token: 0x06002776 RID: 10102
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long FTrunc64(float A);

		// Token: 0x06002777 RID: 10103
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int FTrunc(float A);

		// Token: 0x06002778 RID: 10104 RVA: 0x00038089 File Offset: 0x00036289
		[NullableContext(1)]
		public static FTimespan FromSeconds(float Seconds)
		{
			return new FTimespan(UKismetMathLibrary.__FromSeconds_Internal(Seconds), null);
		}

		// Token: 0x06002779 RID: 10105 RVA: 0x00038097 File Offset: 0x00036297
		[NullableContext(1)]
		public static FTimespan FromMinutes(float Minutes)
		{
			return new FTimespan(UKismetMathLibrary.__FromMinutes_Internal(Minutes), null);
		}

		// Token: 0x0600277A RID: 10106 RVA: 0x000380A5 File Offset: 0x000362A5
		[NullableContext(1)]
		public static FTimespan FromMilliseconds(float Milliseconds)
		{
			return new FTimespan(UKismetMathLibrary.__FromMilliseconds_Internal(Milliseconds), null);
		}

		// Token: 0x0600277B RID: 10107 RVA: 0x000380B3 File Offset: 0x000362B3
		[NullableContext(1)]
		public static FTimespan FromHours(float Hours)
		{
			return new FTimespan(UKismetMathLibrary.__FromHours_Internal(Hours), null);
		}

		// Token: 0x0600277C RID: 10108 RVA: 0x000380C1 File Offset: 0x000362C1
		[NullableContext(1)]
		public static FTimespan FromDays(float Days)
		{
			return new FTimespan(UKismetMathLibrary.__FromDays_Internal(Days), null);
		}

		// Token: 0x0600277D RID: 10109
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Fraction(float A);

		// Token: 0x0600277E RID: 10110
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int FMod(float Dividend, float Divisor, ref float Remainder);

		// Token: 0x0600277F RID: 10111
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float FMin(float A, float B);

		// Token: 0x06002780 RID: 10112
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float FMax(float A, float B);

		// Token: 0x06002781 RID: 10113
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float FixedTurn(float InCurrent, float InDesired, float InDeltaRate);

		// Token: 0x06002782 RID: 10114
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float FInterpTo_Constant(float Current, float Target, float DeltaTime, float InterpSpeed);

		// Token: 0x06002783 RID: 10115
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float FInterpTo(float Current, float Target, float DeltaTime, float InterpSpeed);

		// Token: 0x06002784 RID: 10116
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float FInterpEaseInOut(float A, float B, float Alpha, float Exponent);

		// Token: 0x06002785 RID: 10117
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FindNearestPointsOnLineSegments(FVector Segment1Start, FVector Segment1End, FVector Segment2Start, FVector Segment2End, ref FVector Segment1Point, ref FVector Segment2Point);

		// Token: 0x06002786 RID: 10118
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator FindLookAtRotation(in FVector Start, in FVector Target);

		// Token: 0x06002787 RID: 10119
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector FindClosestPointOnSegment(FVector Point, FVector SegmentStart, FVector SegmentEnd);

		// Token: 0x06002788 RID: 10120
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector FindClosestPointOnLine(FVector Point, FVector LineOrigin, FVector LineDirection);

		// Token: 0x06002789 RID: 10121
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long FFloor64(float A);

		// Token: 0x0600278A RID: 10122
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int FFloor(float A);

		// Token: 0x0600278B RID: 10123
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float FClamp(float Value, float Min, float Max);

		// Token: 0x0600278C RID: 10124
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long FCeil64(float A);

		// Token: 0x0600278D RID: 10125
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int FCeil(float A);

		// Token: 0x0600278E RID: 10126
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Exp(float A);

		// Token: 0x0600278F RID: 10127
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualExactly_VectorVector(FVector A, FVector B);

		// Token: 0x06002790 RID: 10128 RVA: 0x000380D0 File Offset: 0x000362D0
		public unsafe static bool EqualExactly_Vector4Vector4(in FVector4 A, in FVector4 B)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__EqualExactly_Vector4Vector4_Internal(ptr, ptr2);
		}

		// Token: 0x06002791 RID: 10129
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualExactly_Vector2DVector2D(FVector2D A, FVector2D B);

		// Token: 0x06002792 RID: 10130
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_VectorVector(FVector A, FVector B, float ErrorTolerance = 0.0001f);

		// Token: 0x06002793 RID: 10131 RVA: 0x0003811C File Offset: 0x0003631C
		public unsafe static bool EqualEqual_Vector4Vector4(in FVector4 A, in FVector4 B, float ErrorTolerance = 0.0001f)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__EqualEqual_Vector4Vector4_Internal(ptr, ptr2, ErrorTolerance);
		}

		// Token: 0x06002794 RID: 10132
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_Vector2DVector2D(FVector2D A, FVector2D B, float ErrorTolerance = 0.0001f);

		// Token: 0x06002795 RID: 10133 RVA: 0x0003816C File Offset: 0x0003636C
		public unsafe static bool EqualEqual_TransformTransform(in FTransform A, in FTransform B)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__EqualEqual_TransformTransform_Internal(ptr, ptr2);
		}

		// Token: 0x06002796 RID: 10134 RVA: 0x000381B8 File Offset: 0x000363B8
		public static bool EqualEqual_TimespanTimespan(FTimespan A, FTimespan B)
		{
			return UKismetMathLibrary.__EqualEqual_TimespanTimespan_Internal((A ?? new FTimespan()).NativePtr, (B ?? new FTimespan()).NativePtr);
		}

		// Token: 0x06002797 RID: 10135
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_RotatorRotator(FRotator A, FRotator B, float ErrorTolerance = 0.0001f);

		// Token: 0x06002798 RID: 10136 RVA: 0x000381E0 File Offset: 0x000363E0
		public unsafe static bool EqualEqual_QuatQuat(in FQuat A, in FQuat B, float Tolerance = 0.0001f)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FQuat ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__EqualEqual_QuatQuat_Internal(ptr, ptr2, Tolerance);
		}

		// Token: 0x06002799 RID: 10137 RVA: 0x0003822D File Offset: 0x0003642D
		public static bool EqualEqual_ObjectObject(UObject A, UObject B)
		{
			return UKismetMathLibrary.__EqualEqual_ObjectObject_Internal((A != null) ? A.NativePtr : IntPtr.Zero, (B != null) ? B.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600279A RID: 10138
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_NameName(FName A, FName B);

		// Token: 0x0600279B RID: 10139 RVA: 0x00038254 File Offset: 0x00036454
		public unsafe static bool EqualEqual_MatrixMatrix(in FMatrix A, in FMatrix B, float Tolerance = 0.0001f)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FMatrix ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__EqualEqual_MatrixMatrix_Internal(ptr, ptr2, Tolerance);
		}

		// Token: 0x0600279C RID: 10140
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_LinearColorLinearColor(FLinearColor A, FLinearColor B);

		// Token: 0x0600279D RID: 10141
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_IntInt(int A, int B);

		// Token: 0x0600279E RID: 10142
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_Int64Int64(long A, long B);

		// Token: 0x0600279F RID: 10143
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_FloatFloat(float A, float B);

		// Token: 0x060027A0 RID: 10144 RVA: 0x000382A1 File Offset: 0x000364A1
		public static bool EqualEqual_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			return UKismetMathLibrary.__EqualEqual_DateTimeDateTime_Internal((A ?? new FDateTime()).NativePtr, (B ?? new FDateTime()).NativePtr);
		}

		// Token: 0x060027A1 RID: 10145
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_ClassClass(UClassStackOnlyPtr A, UClassStackOnlyPtr B);

		// Token: 0x060027A2 RID: 10146
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_ByteByte(byte A, byte B);

		// Token: 0x060027A3 RID: 10147
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_BoolBool(bool A, bool B);

		// Token: 0x060027A4 RID: 10148
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Equal_IntPointIntPoint(FIntPoint A, FIntPoint B);

		// Token: 0x060027A5 RID: 10149
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Ease(float A, float B, float Alpha, EEasingFunc EasingFunc, float BlendExp = 2f, int Steps = 2);

		// Token: 0x060027A6 RID: 10150
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector DynamicWeightedMovingAverage_FVector(FVector CurrentSample, FVector PreviousSample, float MaxDistance, float MinWeight, float MaxWeight);

		// Token: 0x060027A7 RID: 10151
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator DynamicWeightedMovingAverage_FRotator(FRotator CurrentSample, FRotator PreviousSample, float MaxDistance, float MinWeight, float MaxWeight);

		// Token: 0x060027A8 RID: 10152
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float DynamicWeightedMovingAverage_Float(float CurrentSample, float PreviousSample, float MaxDistance, float MinWeight, float MaxWeight);

		// Token: 0x060027A9 RID: 10153
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float DotProduct2D(FVector2D A, FVector2D B);

		// Token: 0x060027AA RID: 10154
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Dot_VectorVector(FVector A, FVector B);

		// Token: 0x060027AB RID: 10155
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Divide_VectorVector(FVector A, FVector? B = null);

		// Token: 0x060027AC RID: 10156
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Divide_VectorInt(FVector A, int B = 1);

		// Token: 0x060027AD RID: 10157
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Divide_VectorFloat(FVector A, float B = 1f);

		// Token: 0x060027AE RID: 10158 RVA: 0x000382C8 File Offset: 0x000364C8
		public unsafe static FVector4 Divide_Vector4Vector4(in FVector4 A, in FVector4 B)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Divide_Vector4Vector4_Internal(ptr, ptr2);
		}

		// Token: 0x060027AF RID: 10159
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Divide_Vector2DVector2D(FVector2D A, FVector2D B);

		// Token: 0x060027B0 RID: 10160
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Divide_Vector2DFloat(FVector2D A, float B = 1f);

		// Token: 0x060027B1 RID: 10161 RVA: 0x00038314 File Offset: 0x00036514
		[NullableContext(1)]
		public static FTimespan Divide_TimespanFloat([Nullable(2)] FTimespan A, float Scalar)
		{
			return new FTimespan(UKismetMathLibrary.__Divide_TimespanFloat_Internal((A ?? new FTimespan()).NativePtr, Scalar), null);
		}

		// Token: 0x060027B2 RID: 10162
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor Divide_LinearColorLinearColor(FLinearColor A, FLinearColor B);

		// Token: 0x060027B3 RID: 10163
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint Divide_IntPointIntPoint(FIntPoint A, FIntPoint B);

		// Token: 0x060027B4 RID: 10164
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint Divide_IntPointInt(FIntPoint A, int B);

		// Token: 0x060027B5 RID: 10165
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Divide_IntInt(int A, int B = 1);

		// Token: 0x060027B6 RID: 10166
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Divide_Int64Int64(long A, long B = 1L);

		// Token: 0x060027B7 RID: 10167 RVA: 0x00038334 File Offset: 0x00036534
		[SkipLocalsInit]
		public unsafe static float Divide_FloatFloat(float A, float B = 1f)
		{
			UKismetMathLibrary.__Divide_FloatFloat_FunctionParams* ptr = stackalloc UKismetMathLibrary.__Divide_FloatFloat_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKismetMathLibrary.__Divide_FloatFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetMathLibrary.__Divide_FloatFloat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->A = A;
			ptr->B = B;
			UnrealReflectionUtils.CallUFunction(UKismetMathLibrary._ClassDefaultObjectPtr, UKismetMathLibrary.__Divide_FloatFloat_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x060027B8 RID: 10168
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte Divide_ByteByte(byte A, byte B = 1);

		// Token: 0x060027B9 RID: 10169
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float DistanceSquared2D(FVector2D V1, FVector2D V2);

		// Token: 0x060027BA RID: 10170
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Distance2D(FVector2D V1, FVector2D V2);

		// Token: 0x060027BB RID: 10171
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float DegTan(float A);

		// Token: 0x060027BC RID: 10172
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float DegSin(float A);

		// Token: 0x060027BD RID: 10173
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float DegreesToRadians(float A);

		// Token: 0x060027BE RID: 10174
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float DegCos(float A);

		// Token: 0x060027BF RID: 10175
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float DegAtan2(float Y, float X);

		// Token: 0x060027C0 RID: 10176
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float DegAtan(float A);

		// Token: 0x060027C1 RID: 10177
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float DegAsin(float A);

		// Token: 0x060027C2 RID: 10178
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float DegAcos(float A);

		// Token: 0x060027C3 RID: 10179
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int DaysInYear(int Year);

		// Token: 0x060027C4 RID: 10180
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int DaysInMonth(int Year, int Month);

		// Token: 0x060027C5 RID: 10181 RVA: 0x00038386 File Offset: 0x00036586
		[NullableContext(1)]
		public static FDateTime DateTimeMinValue()
		{
			return new FDateTime(UKismetMathLibrary.__DateTimeMinValue_Internal(), null);
		}

		// Token: 0x060027C6 RID: 10182 RVA: 0x00038393 File Offset: 0x00036593
		[NullableContext(1)]
		public static FDateTime DateTimeMaxValue()
		{
			return new FDateTime(UKismetMathLibrary.__DateTimeMaxValue_Internal(), null);
		}

		// Token: 0x060027C7 RID: 10183 RVA: 0x000383A0 File Offset: 0x000365A0
		[NullableContext(1)]
		public unsafe static bool DateTimeFromString(string DateTimeString, [Nullable(2)] ref FDateTime Result)
		{
			FString fstring = FString.AllocTemp(DateTimeString);
			bool result = UKismetMathLibrary.__DateTimeFromString_Internal(fstring, (Result ?? new FDateTime()).NativePtr);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060027C8 RID: 10184 RVA: 0x000383D4 File Offset: 0x000365D4
		[NullableContext(1)]
		public unsafe static bool DateTimeFromIsoString(string IsoString, [Nullable(2)] ref FDateTime Result)
		{
			FString fstring = FString.AllocTemp(IsoString);
			bool result = UKismetMathLibrary.__DateTimeFromIsoString_Internal(fstring, (Result ?? new FDateTime()).NativePtr);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060027C9 RID: 10185
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_VSizeXYSquared(FVectorDouble A);

		// Token: 0x060027CA RID: 10186
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_VSizeXY(FVectorDouble A);

		// Token: 0x060027CB RID: 10187
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_VSizeSquared(FVectorDouble A);

		// Token: 0x060027CC RID: 10188
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_VSize2DSquared(FVector2DDouble A);

		// Token: 0x060027CD RID: 10189
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_VSize2D(FVector2DDouble A);

		// Token: 0x060027CE RID: 10190
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_VSize(FVectorDouble A);

		// Token: 0x060027CF RID: 10191
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_VLerp(FVectorDouble A, FVectorDouble B, double Alpha);

		// Token: 0x060027D0 RID: 10192
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_VInterpTo_Constant(FVectorDouble Current, FVectorDouble Target, float DeltaTime, float InterpSpeed);

		// Token: 0x060027D1 RID: 10193
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_VInterpTo(FVectorDouble Current, FVectorDouble Target, float DeltaTime, float InterpSpeed);

		// Token: 0x060027D2 RID: 10194
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_Zero();

		// Token: 0x060027D3 RID: 10195
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_Up();

		// Token: 0x060027D4 RID: 10196
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_Right();

		// Token: 0x060027D5 RID: 10197
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_One();

		// Token: 0x060027D6 RID: 10198
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_Normal2D(FVectorDouble A, double Tolerance = 0.0001);

		// Token: 0x060027D7 RID: 10199
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_Left();

		// Token: 0x060027D8 RID: 10200
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_Vector_IsZero(in FVectorDouble A);

		// Token: 0x060027D9 RID: 10201
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Vector_HeadingAngle(FVectorDouble A);

		// Token: 0x060027DA RID: 10202
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_GetSignVector(FVectorDouble A);

		// Token: 0x060027DB RID: 10203
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Vector_GetAbsMin(FVectorDouble A);

		// Token: 0x060027DC RID: 10204
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Vector_GetAbsMax(FVectorDouble A);

		// Token: 0x060027DD RID: 10205
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_GetAbs(FVectorDouble A);

		// Token: 0x060027DE RID: 10206
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_Forward();

		// Token: 0x060027DF RID: 10207
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_Down();

		// Token: 0x060027E0 RID: 10208
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Vector_DistanceSquared(FVectorDouble V1, FVectorDouble V2);

		// Token: 0x060027E1 RID: 10209
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Vector_Distance2D(FVectorDouble V1, FVectorDouble V2);

		// Token: 0x060027E2 RID: 10210
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Vector_Distance(FVectorDouble V1, FVectorDouble V2);

		// Token: 0x060027E3 RID: 10211
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Vector_CosineAngle2D(FVectorDouble A, FVectorDouble B);

		// Token: 0x060027E4 RID: 10212
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_ClampSizeMax(FVectorDouble A, double Max);

		// Token: 0x060027E5 RID: 10213
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_Backward();

		// Token: 0x060027E6 RID: 10214
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Vector2DInterpTo_Constant(FVector2DDouble Current, FVector2DDouble Target, float DeltaTime, float InterpSpeed);

		// Token: 0x060027E7 RID: 10215
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Vector2DInterpTo(FVector2DDouble Current, FVector2DDouble Target, float DeltaTime, float InterpSpeed);

		// Token: 0x060027E8 RID: 10216 RVA: 0x00038408 File Offset: 0x00036608
		public unsafe static FRotator D_TransformRotation(in FTransformDouble T, FRotator Rotation)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__D_TransformRotation_Internal(uintPtr, Rotation);
		}

		// Token: 0x060027E9 RID: 10217 RVA: 0x00038438 File Offset: 0x00036638
		public unsafe static FVectorDouble D_TransformLocation(in FTransformDouble T, FVectorDouble Location)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__D_TransformLocation_Internal(uintPtr, Location);
		}

		// Token: 0x060027EA RID: 10218 RVA: 0x00038468 File Offset: 0x00036668
		public unsafe static FVectorDouble D_TransformDirection(in FTransformDouble T, FVectorDouble Direction)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__D_TransformDirection_Internal(uintPtr, Direction);
		}

		// Token: 0x060027EB RID: 10219
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_ToSign2D(FVector2DDouble A);

		// Token: 0x060027EC RID: 10220
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_ToRounded2D(FVector2DDouble A);

		// Token: 0x060027ED RID: 10221
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void D_ToDirectionAndLength2D(FVector2DDouble A, ref FVector2DDouble OutDir, ref double OutLength);

		// Token: 0x060027EE RID: 10222 RVA: 0x00038498 File Offset: 0x00036698
		public unsafe static FTransformDouble D_TLerp(in FTransformDouble A, in FTransformDouble B, float Alpha, ELerpInterpolationMode InterpMode = ELerpInterpolationMode.QuatInterp)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FTransformDouble ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__D_TLerp_Internal(ptr, ptr2, Alpha, InterpMode);
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x000384EC File Offset: 0x000366EC
		public unsafe static FTransformDouble D_TInterpTo(in FTransformDouble Current, in FTransformDouble Target, float DeltaTime, float InterpSpeed)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = Current;
			ref FTransformDouble ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr2 = Target;
			return UKismetMathLibrary.__D_TInterpTo_Internal(ptr, ptr2, DeltaTime, InterpSpeed);
		}

		// Token: 0x060027F0 RID: 10224
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Tan(double A);

		// Token: 0x060027F1 RID: 10225
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Subtract_VectorVector(FVectorDouble A, FVectorDouble B);

		// Token: 0x060027F2 RID: 10226
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Subtract_VectorFloat(FVectorDouble A, double B);

		// Token: 0x060027F3 RID: 10227
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Subtract_Vector2DVector2D(FVector2DDouble A, FVector2DDouble B);

		// Token: 0x060027F4 RID: 10228
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Subtract_Vector2DFloat(FVector2DDouble A, double B);

		// Token: 0x060027F5 RID: 10229
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Subtract_FloatFloat(double A, double B = 1.0);

		// Token: 0x060027F6 RID: 10230
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Square(double A);

		// Token: 0x060027F7 RID: 10231
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Sqrt(double A);

		// Token: 0x060027F8 RID: 10232
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Spherical2DToUnitCartesian(FVector2DDouble A);

		// Token: 0x060027F9 RID: 10233
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Sin(double A);

		// Token: 0x060027FA RID: 10234
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_SignOfFloat(double A);

		// Token: 0x060027FB RID: 10235
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void D_Set2D(ref FVector2DDouble A, double X, double Y);

		// Token: 0x060027FC RID: 10236
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_SelectVector(FVectorDouble A, FVectorDouble B, bool bPickA);

		// Token: 0x060027FD RID: 10237
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_SafeDivide(double A, double B);

		// Token: 0x060027FE RID: 10238
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long D_Round64(double A);

		// Token: 0x060027FF RID: 10239
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int D_Round(double A);

		// Token: 0x06002800 RID: 10240
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_RotatorFromAxisAndAngle(FVectorDouble Axis, float Angle);

		// Token: 0x06002801 RID: 10241
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_RotateAngleAxis(FVectorDouble InVect, float AngleDeg, FVectorDouble Axis);

		// Token: 0x06002802 RID: 10242
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_RandomPointInBoundingBox(FVectorDouble Origin, FVectorDouble BoxExtent);

		// Token: 0x06002803 RID: 10243
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_RandomFloatInRange(double Min, double Max);

		// Token: 0x06002804 RID: 10244
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_RandomFloat();

		// Token: 0x06002805 RID: 10245
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_RandomBoolWithWeight(double Weight);

		// Token: 0x06002806 RID: 10246
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_RadiansToDegrees(double A);

		// Token: 0x06002807 RID: 10247
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_ProjectVectorOnToVector(FVectorDouble V, FVectorDouble Target);

		// Token: 0x06002808 RID: 10248
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_ProjectVectorOnToPlane(FVectorDouble V, FVectorDouble PlaneNormal);

		// Token: 0x06002809 RID: 10249
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_ProjectPointOnToPlane(FVectorDouble Point, FVectorDouble PlaneBase, FVectorDouble PlaneNormal);

		// Token: 0x0600280A RID: 10250 RVA: 0x0003853C File Offset: 0x0003673C
		[SkipLocalsInit]
		public unsafe static double D_Percent_FloatFloat(double A, double B = 1.0)
		{
			UKismetMathLibrary.__D_Percent_FloatFloat_FunctionParams* ptr = stackalloc UKismetMathLibrary.__D_Percent_FloatFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKismetMathLibrary.__D_Percent_FloatFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetMathLibrary.__D_Percent_FloatFloat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->A = A;
			ptr->B = B;
			UnrealReflectionUtils.CallUFunction(UKismetMathLibrary._ClassDefaultObjectPtr, UKismetMathLibrary.__D_Percent_FloatFloat_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600280B RID: 10251
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_NotEqualExactly_VectorVector(FVectorDouble A, FVectorDouble B);

		// Token: 0x0600280C RID: 10252
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_NotEqualExactly_Vector2DVector2D(FVector2DDouble A, FVector2DDouble B);

		// Token: 0x0600280D RID: 10253
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_NotEqual_VectorVector(FVectorDouble A, FVectorDouble B, float ErrorTolerance = 0.0001f);

		// Token: 0x0600280E RID: 10254
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_NotEqual_Vector2DVector2D(FVector2DDouble A, FVector2DDouble B, double ErrorTolerance = 0.0001);

		// Token: 0x0600280F RID: 10255
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_NotEqual_FloatFloat(double A, double B);

		// Token: 0x06002810 RID: 10256
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_NormalSafe2D(FVector2DDouble A, double Tolerance = 0.0);

		// Token: 0x06002811 RID: 10257
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_NormalizeToRange(double Value, double RangeMin, double RangeMax);

		// Token: 0x06002812 RID: 10258
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void D_Normalize2D(ref FVector2DDouble A, double Tolerance = 0.0);

		// Token: 0x06002813 RID: 10259
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Normal2D(FVector2DDouble A);

		// Token: 0x06002814 RID: 10260
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Normal(FVectorDouble A, double Tolerance = 0.0001);

		// Token: 0x06002815 RID: 10261
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_NegateVector(FVectorDouble A);

		// Token: 0x06002816 RID: 10262
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Negated2D(in FVector2DDouble A);

		// Token: 0x06002817 RID: 10263
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_NearlyEqual_FloatFloat(double A, double B, double ErrorTolerance = 1E-06);

		// Token: 0x06002818 RID: 10264
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_MultiplyMultiply_FloatFloat(double Base, double Exp);

		// Token: 0x06002819 RID: 10265
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_MultiplyByPi(double Value);

		// Token: 0x0600281A RID: 10266
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Multiply_VectorVector(FVectorDouble A, FVectorDouble B);

		// Token: 0x0600281B RID: 10267
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Multiply_VectorInt(FVectorDouble A, int B);

		// Token: 0x0600281C RID: 10268
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Multiply_VectorFloat(FVectorDouble A, double B);

		// Token: 0x0600281D RID: 10269
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Multiply_Vector2DVector2D(FVector2DDouble A, FVector2DDouble B);

		// Token: 0x0600281E RID: 10270
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Multiply_Vector2DFloat(FVector2DDouble A, double B);

		// Token: 0x0600281F RID: 10271
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Multiply_IntFloat(int A, double B);

		// Token: 0x06002820 RID: 10272
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Multiply_FloatFloat(double A, double B);

		// Token: 0x06002821 RID: 10273 RVA: 0x00038590 File Offset: 0x00036790
		public unsafe static void D_MinOfFloatArray(in TArray<double> FloatArray, ref int IndexOfMinValue, ref double MinValue)
		{
			fixed (int* ptr = &IndexOfMinValue)
			{
				void* ptr2 = (void*)ptr;
				fixed (double* ptr3 = &MinValue)
				{
					void* ptr4 = (void*)ptr3;
					UKismetMathLibrary.__D_MinOfFloatArray_Internal((FloatArray ?? new TArray<double>()).NativePtr, ref IndexOfMinValue, ref MinValue);
					ptr = null;
				}
			}
		}

		// Token: 0x06002822 RID: 10274 RVA: 0x000385C4 File Offset: 0x000367C4
		public unsafe static void D_MaxOfFloatArray(in TArray<double> FloatArray, ref int IndexOfMaxValue, ref double MaxValue)
		{
			fixed (int* ptr = &IndexOfMaxValue)
			{
				void* ptr2 = (void*)ptr;
				fixed (double* ptr3 = &MaxValue)
				{
					void* ptr4 = (void*)ptr3;
					UKismetMathLibrary.__D_MaxOfFloatArray_Internal((FloatArray ?? new TArray<double>()).NativePtr, ref IndexOfMaxValue, ref MaxValue);
					ptr = null;
				}
			}
		}

		// Token: 0x06002823 RID: 10275
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_MapRangeUnclamped(double Value, double InRangeA, double InRangeB, double OutRangeA, double OutRangeB);

		// Token: 0x06002824 RID: 10276
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_MapRangeClamped(double Value, double InRangeA, double InRangeB, double OutRangeA, double OutRangeB);

		// Token: 0x06002825 RID: 10277
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_MakeRotFromZY(in FVectorDouble Z, in FVectorDouble Y);

		// Token: 0x06002826 RID: 10278
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_MakeRotFromZX(in FVectorDouble Z, in FVectorDouble X);

		// Token: 0x06002827 RID: 10279
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_MakeRotFromZ(in FVectorDouble Z);

		// Token: 0x06002828 RID: 10280
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_MakeRotFromYZ(in FVectorDouble Y, in FVectorDouble Z);

		// Token: 0x06002829 RID: 10281
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_MakeRotFromYX(in FVectorDouble Y, in FVectorDouble X);

		// Token: 0x0600282A RID: 10282
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_MakeRotFromY(in FVectorDouble Y);

		// Token: 0x0600282B RID: 10283
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_MakeRotFromXZ(in FVectorDouble X, in FVectorDouble Z);

		// Token: 0x0600282C RID: 10284
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_MakeRotFromXY(in FVectorDouble X, in FVectorDouble Y);

		// Token: 0x0600282D RID: 10285
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_MakeRotFromX(in FVectorDouble X);

		// Token: 0x0600282E RID: 10286
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_MakeRotationFromAxes(FVectorDouble Forward, FVectorDouble Right, FVectorDouble Up);

		// Token: 0x0600282F RID: 10287 RVA: 0x000385F8 File Offset: 0x000367F8
		public unsafe static FTransformDouble D_MakeRelativeTransform(in FTransformDouble A, in FTransformDouble RelativeTo)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FTransformDouble ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr2 = RelativeTo;
			return UKismetMathLibrary.__D_MakeRelativeTransform_Internal(ptr, ptr2);
		}

		// Token: 0x06002830 RID: 10288
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_MakePulsatingValue(double InCurrentTime, double InPulsesPerSecond = 1.0, double InPhase = 0.0);

		// Token: 0x06002831 RID: 10289
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Loge(double A);

		// Token: 0x06002832 RID: 10290
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Log(double A, double Base = 1.0);

		// Token: 0x06002833 RID: 10291
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_LessEqual_FloatFloat(double A, double B);

		// Token: 0x06002834 RID: 10292
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_Less_FloatFloat(double A, double B);

		// Token: 0x06002835 RID: 10293
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Lerp(double A, double B, double Alpha);

		// Token: 0x06002836 RID: 10294
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_IsZero2D(in FVector2DDouble A);

		// Token: 0x06002837 RID: 10295
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_IsNearlyZero2D(in FVector2DDouble A, double Tolerance = 0.0001);

		// Token: 0x06002838 RID: 10296 RVA: 0x00038644 File Offset: 0x00036844
		public unsafe static FTransformDouble D_InvertTransform(in FTransformDouble T)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__D_InvertTransform_Internal(uintPtr);
		}

		// Token: 0x06002839 RID: 10297 RVA: 0x00038674 File Offset: 0x00036874
		public unsafe static FRotator D_InverseTransformRotation(in FTransformDouble T, FRotator Rotation)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__D_InverseTransformRotation_Internal(uintPtr, Rotation);
		}

		// Token: 0x0600283A RID: 10298 RVA: 0x000386A4 File Offset: 0x000368A4
		public unsafe static FVectorDouble D_InverseTransformLocation(in FTransformDouble T, FVectorDouble Location)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__D_InverseTransformLocation_Internal(uintPtr, Location);
		}

		// Token: 0x0600283B RID: 10299 RVA: 0x000386D4 File Offset: 0x000368D4
		public unsafe static FVectorDouble D_InverseTransformDirection(in FTransformDouble T, FVectorDouble Direction)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__D_InverseTransformDirection_Internal(uintPtr, Direction);
		}

		// Token: 0x0600283C RID: 10300
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_InRange_FloatFloat(double Value, double Min, double Max, bool InclusiveMin = true, bool InclusiveMax = true);

		// Token: 0x0600283D RID: 10301
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Hypotenuse(double Width, double Height);

		// Token: 0x0600283E RID: 10302
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_GridSnap_Float(double Location, double GridSize);

		// Token: 0x0600283F RID: 10303
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_GreaterGreater_VectorRotator(FVectorDouble A, FRotator B);

		// Token: 0x06002840 RID: 10304
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_GreaterEqual_FloatFloat(double A, double B);

		// Token: 0x06002841 RID: 10305
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_Greater_FloatFloat(double A, double B);

		// Token: 0x06002842 RID: 10306 RVA: 0x00038702 File Offset: 0x00036902
		public static FVectorDouble D_GetVectorArrayAverage(in TArray<FVectorDouble> Vectors)
		{
			return UKismetMathLibrary.__D_GetVectorArrayAverage_Internal((Vectors ?? new TArray<FVectorDouble>()).NativePtr);
		}

		// Token: 0x06002843 RID: 10307
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_GetUpVector(FRotator InRot);

		// Token: 0x06002844 RID: 10308
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_GetTAU();

		// Token: 0x06002845 RID: 10309
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_GetRotated2D(FVector2DDouble A, double AngleDeg);

		// Token: 0x06002846 RID: 10310
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_GetRightVector(FRotator InRot);

		// Token: 0x06002847 RID: 10311
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_GetPI();

		// Token: 0x06002848 RID: 10312
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_GetMinElement(FVectorDouble A);

		// Token: 0x06002849 RID: 10313
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_GetMin2D(FVector2DDouble A);

		// Token: 0x0600284A RID: 10314
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_GetMaxElement(FVectorDouble A);

		// Token: 0x0600284B RID: 10315
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_GetMax2D(FVector2DDouble A);

		// Token: 0x0600284C RID: 10316
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_GetForwardVector(FRotator InRot);

		// Token: 0x0600284D RID: 10317
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_GetDirectionUnitVector(FVectorDouble From, FVectorDouble To);

		// Token: 0x0600284E RID: 10318
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_GetAbsMax2D(FVector2DDouble A);

		// Token: 0x0600284F RID: 10319
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_GetAbs2D(FVector2DDouble A);

		// Token: 0x06002850 RID: 10320
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_FWrap(double Value, double Min, double Max);

		// Token: 0x06002851 RID: 10321
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntVector D_FTruncVector(in FVectorDouble InVector);

		// Token: 0x06002852 RID: 10322
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long D_FTrunc64(double A);

		// Token: 0x06002853 RID: 10323
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int D_FTrunc(double A);

		// Token: 0x06002854 RID: 10324
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Fraction(double A);

		// Token: 0x06002855 RID: 10325
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int D_FMod(double Dividend, double Divisor, ref double Remainder);

		// Token: 0x06002856 RID: 10326
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_FMin(double A, double B);

		// Token: 0x06002857 RID: 10327
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_FMax(double A, double B);

		// Token: 0x06002858 RID: 10328
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_FixedTurn(double InCurrent, double InDesired, double InDeltaRate);

		// Token: 0x06002859 RID: 10329
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_FInterpTo_Constant(double Current, double Target, float DeltaTime, float InterpSpeed);

		// Token: 0x0600285A RID: 10330
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_FInterpTo(double Current, double Target, float DeltaTime, float InterpSpeed);

		// Token: 0x0600285B RID: 10331
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_FInterpEaseInOut(double A, double B, double Alpha, double Exponent);

		// Token: 0x0600285C RID: 10332
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_FindLookAtRotation(in FVectorDouble Start, in FVectorDouble Target);

		// Token: 0x0600285D RID: 10333
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_FindClosestPointOnSegment(FVectorDouble Point, FVectorDouble SegmentStart, FVectorDouble SegmentEnd);

		// Token: 0x0600285E RID: 10334
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_FindClosestPointOnLine(FVectorDouble Point, FVectorDouble LineOrigin, FVectorDouble LineDirection);

		// Token: 0x0600285F RID: 10335
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long D_FFloor64(double A);

		// Token: 0x06002860 RID: 10336
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int D_FFloor(double A);

		// Token: 0x06002861 RID: 10337
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_FClamp(double Value, double Min, double Max);

		// Token: 0x06002862 RID: 10338
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long D_FCeil64(double A);

		// Token: 0x06002863 RID: 10339
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int D_FCeil(double A);

		// Token: 0x06002864 RID: 10340
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Exp(double A);

		// Token: 0x06002865 RID: 10341
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_EqualExactly_VectorVector(FVectorDouble A, FVectorDouble B);

		// Token: 0x06002866 RID: 10342
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_EqualExactly_Vector2DVector2D(FVector2DDouble A, FVector2DDouble B);

		// Token: 0x06002867 RID: 10343
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_EqualEqual_VectorVector(FVectorDouble A, FVectorDouble B, double ErrorTolerance = 0.0001);

		// Token: 0x06002868 RID: 10344
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_EqualEqual_Vector2DVector2D(FVector2DDouble A, FVector2DDouble B, double ErrorTolerance = 0.0001);

		// Token: 0x06002869 RID: 10345
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_EqualEqual_FloatFloat(double A, double B);

		// Token: 0x0600286A RID: 10346
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Ease(double A, double B, double Alpha, EEasingFunc EasingFunc, double BlendExp = 2.0, int Steps = 2);

		// Token: 0x0600286B RID: 10347
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_DotProduct2D(FVector2DDouble A, FVector2DDouble B);

		// Token: 0x0600286C RID: 10348
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Dot_VectorVector(FVectorDouble A, FVectorDouble B);

		// Token: 0x0600286D RID: 10349
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Divide_VectorVector(FVectorDouble A, FVectorDouble? B = null);

		// Token: 0x0600286E RID: 10350
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Divide_VectorFloat(FVectorDouble A, double B = 1.0);

		// Token: 0x0600286F RID: 10351
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Divide_Vector2DVector2D(FVector2DDouble A, FVector2DDouble B);

		// Token: 0x06002870 RID: 10352
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Divide_Vector2DFloat(FVector2DDouble A, double B = 1.0);

		// Token: 0x06002871 RID: 10353 RVA: 0x0003871C File Offset: 0x0003691C
		[SkipLocalsInit]
		public unsafe static double D_Divide_FloatFloat(double A, double B = 1.0)
		{
			UKismetMathLibrary.__D_Divide_FloatFloat_FunctionParams* ptr = stackalloc UKismetMathLibrary.__D_Divide_FloatFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKismetMathLibrary.__D_Divide_FloatFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetMathLibrary.__D_Divide_FloatFloat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->A = A;
			ptr->B = B;
			UnrealReflectionUtils.CallUFunction(UKismetMathLibrary._ClassDefaultObjectPtr, UKismetMathLibrary.__D_Divide_FloatFloat_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06002872 RID: 10354
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_DistanceSquared2D(FVector2DDouble V1, FVector2DDouble V2);

		// Token: 0x06002873 RID: 10355
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Distance2D(FVector2DDouble V1, FVector2DDouble V2);

		// Token: 0x06002874 RID: 10356
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_DegTan(double A);

		// Token: 0x06002875 RID: 10357
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_DegSin(double A);

		// Token: 0x06002876 RID: 10358
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_DegreesToRadians(double A);

		// Token: 0x06002877 RID: 10359
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_DegCos(double A);

		// Token: 0x06002878 RID: 10360
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_DegAtan2(double Y, double X);

		// Token: 0x06002879 RID: 10361
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_DegAtan(double A);

		// Token: 0x0600287A RID: 10362
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_DegAsin(double A);

		// Token: 0x0600287B RID: 10363
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_DegAcos(double A);

		// Token: 0x0600287C RID: 10364
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_CrossProduct2D(FVector2DDouble A, FVector2DDouble B);

		// Token: 0x0600287D RID: 10365
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Cross_VectorVector(FVectorDouble A, FVectorDouble B);

		// Token: 0x0600287E RID: 10366
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Cos(double A);

		// Token: 0x0600287F RID: 10367
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Conv_VectorToVector2D(FVectorDouble InVector);

		// Token: 0x06002880 RID: 10368
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FTransformDouble D_Conv_VectorToTransform(FVectorDouble InLocation);

		// Token: 0x06002881 RID: 10369
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Conv_Vector2DToVector(FVector2DDouble InVector2D, double Z = 0.0);

		// Token: 0x06002882 RID: 10370
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint D_Conv_Vector2DToIntPoint(FVector2DDouble InVector2D);

		// Token: 0x06002883 RID: 10371
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Conv_IntToFloat(int InInt);

		// Token: 0x06002884 RID: 10372
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Conv_FloatToVector(double InFloat);

		// Token: 0x06002885 RID: 10373 RVA: 0x00038770 File Offset: 0x00036970
		public unsafe static FTransformDouble D_ComposeTransforms(in FTransformDouble A, in FTransformDouble B)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FTransformDouble ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__D_ComposeTransforms_Internal(ptr, ptr2);
		}

		// Token: 0x06002886 RID: 10374
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_ClampVectorSize(FVectorDouble A, double Min, double Max);

		// Token: 0x06002887 RID: 10375
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_ClampAxes2D(FVector2DDouble A, double MinAxisVal, double MaxAxisVal);

		// Token: 0x06002888 RID: 10376
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_ClampAngle(double AngleDegrees, double MinAngleDegrees, double MaxAngleDegrees);

		// Token: 0x06002889 RID: 10377
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Atan2(double Y, double X);

		// Token: 0x0600288A RID: 10378
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Atan(double A);

		// Token: 0x0600288B RID: 10379
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Asin(double A);

		// Token: 0x0600288C RID: 10380
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Add_VectorVector(FVectorDouble A, FVectorDouble B);

		// Token: 0x0600288D RID: 10381
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Add_VectorFloat(FVectorDouble A, double B);

		// Token: 0x0600288E RID: 10382
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Add_Vector2DVector2D(FVector2DDouble A, FVector2DDouble B);

		// Token: 0x0600288F RID: 10383
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Add_Vector2DFloat(FVector2DDouble A, double B);

		// Token: 0x06002890 RID: 10384
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Add_FloatFloat(double A, double B = 1.0);

		// Token: 0x06002891 RID: 10385
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Acos(double A);

		// Token: 0x06002892 RID: 10386
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Abs(double A);

		// Token: 0x06002893 RID: 10387
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float CrossProduct2D(FVector2D A, FVector2D B);

		// Token: 0x06002894 RID: 10388
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Cross_VectorVector(FVector A, FVector B);

		// Token: 0x06002895 RID: 10389
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector CreateVectorFromYawPitch(float Yaw, float Pitch, float Length = 1f);

		// Token: 0x06002896 RID: 10390
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Cos(float A);

		// Token: 0x06002897 RID: 10391 RVA: 0x000387BC File Offset: 0x000369BC
		public unsafe static FTransform ConvertTransformToRelative(in FTransform Transform, in FTransform ParentTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = ParentTransform;
			return UKismetMathLibrary.__ConvertTransformToRelative_Internal(ptr, ptr2);
		}

		// Token: 0x06002898 RID: 10392
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble Conv_VectorToVectorDouble(FVector InVec);

		// Token: 0x06002899 RID: 10393
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Conv_VectorToVector2D(FVector InVector);

		// Token: 0x0600289A RID: 10394
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FTransform Conv_VectorToTransform(FVector InLocation);

		// Token: 0x0600289B RID: 10395
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator Conv_VectorToRotator(FVector InVec);

		// Token: 0x0600289C RID: 10396
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FQuat Conv_VectorToQuaternion(FVector InVec);

		// Token: 0x0600289D RID: 10397
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor Conv_VectorToLinearColor(FVector InVec);

		// Token: 0x0600289E RID: 10398
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Conv_VectorDoubleToVector(FVectorDouble InVec);

		// Token: 0x0600289F RID: 10399
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator Conv_VectorDoubleToRotator(FVectorDouble InVec);

		// Token: 0x060028A0 RID: 10400
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor Conv_VectorDoubleToLinearColor(FVectorDouble InVec);

		// Token: 0x060028A1 RID: 10401 RVA: 0x00038808 File Offset: 0x00036A08
		public unsafe static FVector Conv_Vector4ToVector(in FVector4 InVector4)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = InVector4;
			return UKismetMathLibrary.__Conv_Vector4ToVector_Internal(uintPtr);
		}

		// Token: 0x060028A2 RID: 10402 RVA: 0x00038838 File Offset: 0x00036A38
		public unsafe static FRotator Conv_Vector4ToRotator(in FVector4 InVec)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = InVec;
			return UKismetMathLibrary.__Conv_Vector4ToRotator_Internal(uintPtr);
		}

		// Token: 0x060028A3 RID: 10403 RVA: 0x00038868 File Offset: 0x00036A68
		public unsafe static FQuat Conv_Vector4ToQuaternion(in FVector4 InVec)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = InVec;
			return UKismetMathLibrary.__Conv_Vector4ToQuaternion_Internal(uintPtr);
		}

		// Token: 0x060028A4 RID: 10404
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Conv_Vector2DToVector(FVector2D InVector2D, float Z = 0f);

		// Token: 0x060028A5 RID: 10405
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint Conv_Vector2DToIntPoint(FVector2D InVector2D);

		// Token: 0x060028A6 RID: 10406 RVA: 0x00038898 File Offset: 0x00036A98
		public unsafe static FTransformDouble Conv_TransformToTransformDouble(FTransform InT)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = InT;
			return UKismetMathLibrary.__Conv_TransformToTransformDouble_Internal(uintPtr);
		}

		// Token: 0x060028A7 RID: 10407 RVA: 0x000388C0 File Offset: 0x00036AC0
		public unsafe static FMatrix Conv_TransformToMatrix(in FTransform Transform)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = Transform;
			return UKismetMathLibrary.__Conv_TransformToMatrix_Internal(uintPtr);
		}

		// Token: 0x060028A8 RID: 10408 RVA: 0x000388F0 File Offset: 0x00036AF0
		public unsafe static FTransform Conv_TransformDoubleToTransform(FTransformDouble InT)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = InT;
			return UKismetMathLibrary.__Conv_TransformDoubleToTransform_Internal(uintPtr);
		}

		// Token: 0x060028A9 RID: 10409
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Conv_RotatorToVector(FRotator InRot);

		// Token: 0x060028AA RID: 10410
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FTransform Conv_RotatorToTransform(in FRotator InRotator);

		// Token: 0x060028AB RID: 10411 RVA: 0x00038918 File Offset: 0x00036B18
		public unsafe static FTransform Conv_MatrixToTransform(in FMatrix InMatrix)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = InMatrix;
			return UKismetMathLibrary.__Conv_MatrixToTransform_Internal(uintPtr);
		}

		// Token: 0x060028AC RID: 10412 RVA: 0x00038948 File Offset: 0x00036B48
		public unsafe static FRotator Conv_MatrixToRotator(in FMatrix InMatrix)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = InMatrix;
			return UKismetMathLibrary.__Conv_MatrixToRotator_Internal(uintPtr);
		}

		// Token: 0x060028AD RID: 10413
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Conv_LinearColorToVector(FLinearColor InLinearColor);

		// Token: 0x060028AE RID: 10414
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FColor Conv_LinearColorToColor(FLinearColor InLinearColor, bool InUseSRGB = true);

		// Token: 0x060028AF RID: 10415
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Conv_IntVectorToVector(in FIntVector InIntVector);

		// Token: 0x060028B0 RID: 10416
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntVector Conv_IntToIntVector(int InInt);

		// Token: 0x060028B1 RID: 10417
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Conv_IntToInt64(int InInt);

		// Token: 0x060028B2 RID: 10418
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Conv_IntToFloat(int InInt);

		// Token: 0x060028B3 RID: 10419
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte Conv_IntToByte(int InInt);

		// Token: 0x060028B4 RID: 10420
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Conv_IntToBool(int InInt);

		// Token: 0x060028B5 RID: 10421
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Conv_IntPointToVector2D(FIntPoint InIntPoint);

		// Token: 0x060028B6 RID: 10422
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Conv_Int64ToInt(long InInt);

		// Token: 0x060028B7 RID: 10423
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte Conv_Int64ToByte(long InInt);

		// Token: 0x060028B8 RID: 10424
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Conv_FloatToVector(float InFloat);

		// Token: 0x060028B9 RID: 10425
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor Conv_FloatToLinearColor(float InFloat);

		// Token: 0x060028BA RID: 10426
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Conv_FloatToDouble(float A);

		// Token: 0x060028BB RID: 10427
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Conv_DoubleToFloat(double A);

		// Token: 0x060028BC RID: 10428
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor Conv_ColorToLinearColor(FColor InColor);

		// Token: 0x060028BD RID: 10429
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Conv_ByteToInt(byte InByte);

		// Token: 0x060028BE RID: 10430
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Conv_ByteToFloat(byte InByte);

		// Token: 0x060028BF RID: 10431
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Conv_BoolToInt(bool InBool);

		// Token: 0x060028C0 RID: 10432
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Conv_BoolToFloat(bool InBool);

		// Token: 0x060028C1 RID: 10433
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte Conv_BoolToByte(bool InBool);

		// Token: 0x060028C2 RID: 10434 RVA: 0x00038978 File Offset: 0x00036B78
		public unsafe static FTransform ComposeTransforms(in FTransform A, in FTransform B)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__ComposeTransforms_Internal(ptr, ptr2);
		}

		// Token: 0x060028C3 RID: 10435
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator ComposeRotators(FRotator A, FRotator B);

		// Token: 0x060028C4 RID: 10436
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool ClassIsChildOf(UClassStackOnlyPtr TestClass, UClassStackOnlyPtr ParentClass);

		// Token: 0x060028C5 RID: 10437
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector ClampVectorSize(FVector A, float Min, float Max);

		// Token: 0x060028C6 RID: 10438
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long ClampInt64(long Value, long Min, long Max);

		// Token: 0x060028C7 RID: 10439
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float ClampAxis(float Angle);

		// Token: 0x060028C8 RID: 10440
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D ClampAxes2D(FVector2D A, float MinAxisVal, float MaxAxisVal);

		// Token: 0x060028C9 RID: 10441
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float ClampAngle(float AngleDegrees, float MinAngleDegrees, float MaxAngleDegrees);

		// Token: 0x060028CA RID: 10442
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Clamp(int Value, int Min, int Max);

		// Token: 0x060028CB RID: 10443
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor CInterpTo(FLinearColor Current, FLinearColor Target, float DeltaTime, float InterpSpeed);

		// Token: 0x060028CC RID: 10444
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BreakVectorDouble(FVectorDouble InVec, ref double X, ref double Y, ref double Z);

		// Token: 0x060028CD RID: 10445 RVA: 0x000389C4 File Offset: 0x00036BC4
		public unsafe static void BreakVector4(in FVector4 InVec, ref float X, ref float Y, ref float Z, ref float W)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = InVec;
			fixed (float* ptr = &X)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &Y)
				{
					void* ptr4 = (void*)ptr3;
					fixed (float* ptr5 = &Z)
					{
						void* ptr6 = (void*)ptr5;
						fixed (float* ptr7 = &W)
						{
							void* ptr8 = (void*)ptr7;
							UKismetMathLibrary.__BreakVector4_Internal(uintPtr, ref X, ref Y, ref Z, ref W);
							ptr = null;
							ptr3 = null;
							ptr5 = null;
						}
					}
				}
			}
		}

		// Token: 0x060028CE RID: 10446
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BreakVector2DDouble(FVector2DDouble InVec, ref double X, ref double Y);

		// Token: 0x060028CF RID: 10447
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BreakVector2D(FVector2D InVec, ref float X, ref float Y);

		// Token: 0x060028D0 RID: 10448
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BreakVector(FVector InVec, ref float X, ref float Y, ref float Z);

		// Token: 0x060028D1 RID: 10449 RVA: 0x00038A24 File Offset: 0x00036C24
		public unsafe static void BreakTransformDouble(in FTransformDouble InTransform, ref FVectorDouble Location, ref FRotator Rotation, ref FVector Scale)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = InTransform;
			fixed (FVectorDouble* ptr = &Location)
			{
				void* ptr2 = (void*)ptr;
				fixed (FRotator* ptr3 = &Rotation)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FVector* ptr5 = &Scale)
					{
						void* ptr6 = (void*)ptr5;
						UKismetMathLibrary.__BreakTransformDouble_Internal(uintPtr, ref Location, ref Rotation, ref Scale);
						ptr = null;
						ptr3 = null;
					}
				}
			}
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x00038A74 File Offset: 0x00036C74
		public unsafe static void BreakTransform(in FTransform InTransform, ref FVector Location, ref FRotator Rotation, ref FVector Scale)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = InTransform;
			fixed (FVector* ptr = &Location)
			{
				void* ptr2 = (void*)ptr;
				fixed (FRotator* ptr3 = &Rotation)
				{
					void* ptr4 = (void*)ptr3;
					fixed (FVector* ptr5 = &Scale)
					{
						void* ptr6 = (void*)ptr5;
						UKismetMathLibrary.__BreakTransform_Internal(uintPtr, ref Location, ref Rotation, ref Scale);
						ptr = null;
						ptr3 = null;
					}
				}
			}
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x00038AC4 File Offset: 0x00036CC4
		public unsafe static void BreakTimespan2(FTimespan InTimespan, ref int Days, ref int Hours, ref int Minutes, ref int Seconds, ref int FractionNano)
		{
			fixed (int* ptr = &Days)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &Hours)
				{
					void* ptr4 = (void*)ptr3;
					fixed (int* ptr5 = &Minutes)
					{
						void* ptr6 = (void*)ptr5;
						fixed (int* ptr7 = &Seconds)
						{
							void* ptr8 = (void*)ptr7;
							fixed (int* ptr9 = &FractionNano)
							{
								void* ptr10 = (void*)ptr9;
								UKismetMathLibrary.__BreakTimespan2_Internal((InTimespan ?? new FTimespan()).NativePtr, ref Days, ref Hours, ref Minutes, ref Seconds, ref FractionNano);
								ptr = null;
								ptr3 = null;
								ptr5 = null;
								ptr7 = null;
							}
						}
					}
				}
			}
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x00038B28 File Offset: 0x00036D28
		public unsafe static void BreakTimespan(FTimespan InTimespan, ref int Days, ref int Hours, ref int Minutes, ref int Seconds, ref int Milliseconds)
		{
			fixed (int* ptr = &Days)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &Hours)
				{
					void* ptr4 = (void*)ptr3;
					fixed (int* ptr5 = &Minutes)
					{
						void* ptr6 = (void*)ptr5;
						fixed (int* ptr7 = &Seconds)
						{
							void* ptr8 = (void*)ptr7;
							fixed (int* ptr9 = &Milliseconds)
							{
								void* ptr10 = (void*)ptr9;
								UKismetMathLibrary.__BreakTimespan_Internal((InTimespan ?? new FTimespan()).NativePtr, ref Days, ref Hours, ref Minutes, ref Seconds, ref Milliseconds);
								ptr = null;
								ptr3 = null;
								ptr5 = null;
								ptr7 = null;
							}
						}
					}
				}
			}
		}

		// Token: 0x060028D5 RID: 10453
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BreakRotIntoAxes(in FRotator InRot, ref FVector X, ref FVector Y, ref FVector Z);

		// Token: 0x060028D6 RID: 10454
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BreakRotator(FRotator InRot, ref float Roll, ref float Pitch, ref float Yaw);

		// Token: 0x060028D7 RID: 10455
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BreakRandomStream(in FRandomStream InRandomStream, ref int InitialSeed);

		// Token: 0x060028D8 RID: 10456 RVA: 0x00038B8C File Offset: 0x00036D8C
		public unsafe static void BreakQualifiedFrameTime(in FQualifiedFrameTime InFrameTime, ref FFrameNumber Frame, ref FFrameRate FrameRate, ref float SubFrame)
		{
			fixed (FFrameRate* ptr = &FrameRate)
			{
				void* ptr2 = (void*)ptr;
				fixed (float* ptr3 = &SubFrame)
				{
					void* ptr4 = (void*)ptr3;
					UKismetMathLibrary.__BreakQualifiedFrameTime_Internal((InFrameTime ?? new FQualifiedFrameTime()).NativePtr, (Frame ?? new FFrameNumber()).NativePtr, ref FrameRate, ref SubFrame);
					ptr = null;
				}
			}
		}

		// Token: 0x060028D9 RID: 10457
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BreakFrameRate(in FFrameRate InFrameRate, ref int Numerator, ref int Denominator);

		// Token: 0x060028DA RID: 10458 RVA: 0x00038BD0 File Offset: 0x00036DD0
		public unsafe static void BreakDateTime(FDateTime InDateTime, ref int Year, ref int Month, ref int Day, ref int Hour, ref int Minute, ref int Second, ref int Millisecond)
		{
			fixed (int* ptr = &Year)
			{
				void* ptr2 = (void*)ptr;
				fixed (int* ptr3 = &Month)
				{
					void* ptr4 = (void*)ptr3;
					fixed (int* ptr5 = &Day)
					{
						void* ptr6 = (void*)ptr5;
						fixed (int* ptr7 = &Hour)
						{
							void* ptr8 = (void*)ptr7;
							fixed (int* ptr9 = &Minute)
							{
								void* ptr10 = (void*)ptr9;
								fixed (int* ptr11 = &Second)
								{
									void* ptr12 = (void*)ptr11;
									fixed (int* ptr13 = &Millisecond)
									{
										void* ptr14 = (void*)ptr13;
										UKismetMathLibrary.__BreakDateTime_Internal((InDateTime ?? new FDateTime()).NativePtr, ref Year, ref Month, ref Day, ref Hour, ref Minute, ref Second, ref Millisecond);
										ptr = null;
										ptr3 = null;
										ptr5 = null;
										ptr7 = null;
										ptr9 = null;
										ptr11 = null;
									}
								}
							}
						}
					}
				}
			}
		}

		// Token: 0x060028DB RID: 10459
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BreakColor(FLinearColor InColor, ref float R, ref float G, ref float B, ref float A);

		// Token: 0x060028DC RID: 10460
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool BooleanXOR(bool A, bool B);

		// Token: 0x060028DD RID: 10461
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool BooleanOR(bool A, bool B);

		// Token: 0x060028DE RID: 10462
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool BooleanNOR(bool A, bool B);

		// Token: 0x060028DF RID: 10463
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool BooleanNAND(bool A, bool B);

		// Token: 0x060028E0 RID: 10464
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool BooleanAND(bool A, bool B);

		// Token: 0x060028E1 RID: 10465
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte BMin(byte A, byte B);

		// Token: 0x060028E2 RID: 10466
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte BMax(byte A, byte B);

		// Token: 0x060028E3 RID: 10467
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Atan2(float Y, float X);

		// Token: 0x060028E4 RID: 10468
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Atan(float A);

		// Token: 0x060028E5 RID: 10469
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Asin(float A);

		// Token: 0x060028E6 RID: 10470
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int And_IntInt(int A, int B);

		// Token: 0x060028E7 RID: 10471
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long And_Int64Int64(long A, long B);

		// Token: 0x060028E8 RID: 10472
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Add_VectorVector(FVector A, FVector B);

		// Token: 0x060028E9 RID: 10473
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Add_VectorInt(FVector A, int B);

		// Token: 0x060028EA RID: 10474
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Add_VectorFloat(FVector A, float B);

		// Token: 0x060028EB RID: 10475 RVA: 0x00038C50 File Offset: 0x00036E50
		public unsafe static FVector4 Add_Vector4Vector4(in FVector4 A, in FVector4 B)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Add_Vector4Vector4_Internal(ptr, ptr2);
		}

		// Token: 0x060028EC RID: 10476
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Add_Vector2DVector2D(FVector2D A, FVector2D B);

		// Token: 0x060028ED RID: 10477
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Add_Vector2DFloat(FVector2D A, float B);

		// Token: 0x060028EE RID: 10478 RVA: 0x00038C9C File Offset: 0x00036E9C
		[return: Nullable(1)]
		public static FTimespan Add_TimespanTimespan(FTimespan A, FTimespan B)
		{
			return new FTimespan(UKismetMathLibrary.__Add_TimespanTimespan_Internal((A ?? new FTimespan()).NativePtr, (B ?? new FTimespan()).NativePtr), null);
		}

		// Token: 0x060028EF RID: 10479 RVA: 0x00038CC8 File Offset: 0x00036EC8
		public unsafe static FQuat Add_QuatQuat(in FQuat A, in FQuat B)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FQuat ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Add_QuatQuat_Internal(ptr, ptr2);
		}

		// Token: 0x060028F0 RID: 10480 RVA: 0x00038D14 File Offset: 0x00036F14
		public unsafe static FMatrix Add_MatrixMatrix(in FMatrix A, in FMatrix B)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FMatrix ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Add_MatrixMatrix_Internal(ptr, ptr2);
		}

		// Token: 0x060028F1 RID: 10481
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor Add_LinearColorLinearColor(FLinearColor A, FLinearColor B);

		// Token: 0x060028F2 RID: 10482
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint Add_IntPointIntPoint(FIntPoint A, FIntPoint B);

		// Token: 0x060028F3 RID: 10483
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint Add_IntPointInt(FIntPoint A, int B);

		// Token: 0x060028F4 RID: 10484
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Add_IntInt(int A, int B = 1);

		// Token: 0x060028F5 RID: 10485
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Add_Int64Int64(long A, long B = 1L);

		// Token: 0x060028F6 RID: 10486
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Add_FloatFloat(float A, float B = 1f);

		// Token: 0x060028F7 RID: 10487 RVA: 0x00038D60 File Offset: 0x00036F60
		[return: Nullable(1)]
		public static FDateTime Add_DateTimeTimespan(FDateTime A, FTimespan B)
		{
			return new FDateTime(UKismetMathLibrary.__Add_DateTimeTimespan_Internal((A ?? new FDateTime()).NativePtr, (B ?? new FTimespan()).NativePtr), null);
		}

		// Token: 0x060028F8 RID: 10488 RVA: 0x00038D8B File Offset: 0x00036F8B
		[return: Nullable(1)]
		public static FDateTime Add_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			return new FDateTime(UKismetMathLibrary.__Add_DateTimeDateTime_Internal((A ?? new FDateTime()).NativePtr, (B ?? new FDateTime()).NativePtr), null);
		}

		// Token: 0x060028F9 RID: 10489
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte Add_ByteByte(byte A, byte B = 1);

		// Token: 0x060028FA RID: 10490
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Acos(float A);

		// Token: 0x060028FB RID: 10491
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Abs_Int64(long A);

		// Token: 0x060028FC RID: 10492
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Abs_Int(int A);

		// Token: 0x060028FD RID: 10493
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Abs(float A);

		// Token: 0x060028FE RID: 10494
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __WD_WorldToLocal_Internal(IntPtr WorldContextObject, FVectorDouble InVec);

		// Token: 0x060028FF RID: 10495
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __WD_TransformToTransformDouble_Internal(IntPtr WorldContextObject, in FTransform InT);

		// Token: 0x06002900 RID: 10496
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __WD_TransformDoubleToTransform_Internal(IntPtr WorldContextObject, in FTransformDouble InT);

		// Token: 0x06002901 RID: 10497
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __WD_LocalToWorld_Internal(IntPtr WorldContextObject, FVector InVec);

		// Token: 0x06002902 RID: 10498
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Vector_MirrorByPlane_Internal(FVector A, in FPlane InPlane);

		// Token: 0x06002903 RID: 10499
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Vector4_SizeSquared3_Internal(in FVector4 A);

		// Token: 0x06002904 RID: 10500
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Vector4_SizeSquared_Internal(in FVector4 A);

		// Token: 0x06002905 RID: 10501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Vector4_Size3_Internal(in FVector4 A);

		// Token: 0x06002906 RID: 10502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Vector4_Size_Internal(in FVector4 A);

		// Token: 0x06002907 RID: 10503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Vector4_Set_Internal(ref FVector4 A, float X, float Y, float Z, float W);

		// Token: 0x06002908 RID: 10504
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Vector4_NormalUnsafe3_Internal(in FVector4 A);

		// Token: 0x06002909 RID: 10505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Vector4_Normalize3_Internal(ref FVector4 A, float Tolerance);

		// Token: 0x0600290A RID: 10506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Vector4_Normal3_Internal(in FVector4 A, float Tolerance);

		// Token: 0x0600290B RID: 10507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Vector4_Negated_Internal(in FVector4 A);

		// Token: 0x0600290C RID: 10508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Vector4_MirrorByVector3_Internal(in FVector4 Direction, in FVector4 SurfaceNormal);

		// Token: 0x0600290D RID: 10509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Vector4_IsZero_Internal(in FVector4 A);

		// Token: 0x0600290E RID: 10510
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Vector4_IsUnit3_Internal(in FVector4 A, float SquaredLenthTolerance);

		// Token: 0x0600290F RID: 10511
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Vector4_IsNormal3_Internal(in FVector4 A);

		// Token: 0x06002910 RID: 10512
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Vector4_IsNearlyZero3_Internal(in FVector4 A, float Tolerance);

		// Token: 0x06002911 RID: 10513
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Vector4_IsNAN_Internal(in FVector4 A);

		// Token: 0x06002912 RID: 10514
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Vector4_DotProduct3_Internal(in FVector4 A, in FVector4 B);

		// Token: 0x06002913 RID: 10515
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Vector4_DotProduct_Internal(in FVector4 A, in FVector4 B);

		// Token: 0x06002914 RID: 10516
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Vector4_CrossProduct3_Internal(in FVector4 A, in FVector4 B);

		// Token: 0x06002915 RID: 10517
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Vector4_Assign_Internal(ref FVector4 A, in FVector4 InVector);

		// Token: 0x06002916 RID: 10518
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __UtcNow_Internal();

		// Token: 0x06002917 RID: 10519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __TransformVector4_Internal(in FMatrix Matrix, in FVector4 Vec4);

		// Token: 0x06002918 RID: 10520
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __TransformRotation_Internal(in FTransform T, FRotator Rotation);

		// Token: 0x06002919 RID: 10521
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __TransformLocation_Internal(in FTransform T, FVector Location);

		// Token: 0x0600291A RID: 10522
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __TransformDirection_Internal(in FTransform T, FVector Direction);

		// Token: 0x0600291B RID: 10523
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Transform_Determinant_Internal(in FTransform Transform);

		// Token: 0x0600291C RID: 10524
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Today_Internal();

		// Token: 0x0600291D RID: 10525
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __TLerp_Internal(in FTransform A, in FTransform B, float Alpha, TEnumAsByte<ELerpInterpolationMode> InterpMode);

		// Token: 0x0600291E RID: 10526
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __TInterpTo_Internal(in FTransform Current, in FTransform Target, float DeltaTime, float InterpSpeed);

		// Token: 0x0600291F RID: 10527
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __TimespanZeroValue_Internal();

		// Token: 0x06002920 RID: 10528
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __TimespanRatio_Internal(IntPtr A, IntPtr B);

		// Token: 0x06002921 RID: 10529
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __TimespanMinValue_Internal();

		// Token: 0x06002922 RID: 10530
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __TimespanMaxValue_Internal();

		// Token: 0x06002923 RID: 10531
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TimespanFromString_Internal(in FString TimespanString, IntPtr Result);

		// Token: 0x06002924 RID: 10532
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __TEase_Internal(in FTransform A, in FTransform B, float Alpha, TEnumAsByte<EEasingFunc> EasingFunc, float BlendExp, int Steps);

		// Token: 0x06002925 RID: 10533
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Subtract_Vector4Vector4_Internal(in FVector4 A, in FVector4 B);

		// Token: 0x06002926 RID: 10534
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Subtract_TimespanTimespan_Internal(IntPtr A, IntPtr B);

		// Token: 0x06002927 RID: 10535
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __Subtract_QuatQuat_Internal(in FQuat A, in FQuat B);

		// Token: 0x06002928 RID: 10536
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Subtract_DateTimeTimespan_Internal(IntPtr A, IntPtr B);

		// Token: 0x06002929 RID: 10537
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Subtract_DateTimeDateTime_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600292A RID: 10538
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __SelectTransform_Internal(in FTransform A, in FTransform B, bool bPickA);

		// Token: 0x0600292B RID: 10539
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __SelectString_Internal(in FString A, in FString B, bool bPickA);

		// Token: 0x0600292C RID: 10540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SelectObject_Internal(IntPtr A, IntPtr B, bool bSelectA);

		// Token: 0x0600292D RID: 10541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Quat_VectorUp_Internal(in FQuat Q);

		// Token: 0x0600292E RID: 10542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Quat_VectorRight_Internal(in FQuat Q);

		// Token: 0x0600292F RID: 10543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Quat_VectorForward_Internal(in FQuat Q);

		// Token: 0x06002930 RID: 10544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Quat_UnrotateVector_Internal(in FQuat Q, in FVector V);

		// Token: 0x06002931 RID: 10545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Quat_SizeSquared_Internal(in FQuat Q);

		// Token: 0x06002932 RID: 10546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Quat_Size_Internal(in FQuat Q);

		// Token: 0x06002933 RID: 10547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Quat_SetFromEuler_Internal(ref FQuat Q, in FVector Euler);

		// Token: 0x06002934 RID: 10548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Quat_SetComponents_Internal(ref FQuat Q, float X, float Y, float Z, float W);

		// Token: 0x06002935 RID: 10549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __Quat_Rotator_Internal(in FQuat Q);

		// Token: 0x06002936 RID: 10550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Quat_RotateVector_Internal(in FQuat Q, in FVector V);

		// Token: 0x06002937 RID: 10551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __Quat_Normalized_Internal(in FQuat Q, float Tolerance);

		// Token: 0x06002938 RID: 10552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Quat_Normalize_Internal(ref FQuat Q, float Tolerance);

		// Token: 0x06002939 RID: 10553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __Quat_Log_Internal(in FQuat Q);

		// Token: 0x0600293A RID: 10554
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Quat_IsNormalized_Internal(in FQuat Q);

		// Token: 0x0600293B RID: 10555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Quat_IsNonFinite_Internal(in FQuat Q);

		// Token: 0x0600293C RID: 10556
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Quat_IsIdentity_Internal(in FQuat Q, float Tolerance);

		// Token: 0x0600293D RID: 10557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Quat_IsFinite_Internal(in FQuat Q);

		// Token: 0x0600293E RID: 10558
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __Quat_Inversed_Internal(in FQuat Q);

		// Token: 0x0600293F RID: 10559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Quat_GetRotationAxis_Internal(in FQuat Q);

		// Token: 0x06002940 RID: 10560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Quat_GetAxisZ_Internal(in FQuat Q);

		// Token: 0x06002941 RID: 10561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Quat_GetAxisY_Internal(in FQuat Q);

		// Token: 0x06002942 RID: 10562
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Quat_GetAxisX_Internal(in FQuat Q);

		// Token: 0x06002943 RID: 10563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Quat_GetAngle_Internal(in FQuat Q);

		// Token: 0x06002944 RID: 10564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __Quat_Exp_Internal(in FQuat Q);

		// Token: 0x06002945 RID: 10565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Quat_Euler_Internal(in FQuat Q);

		// Token: 0x06002946 RID: 10566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Quat_EnforceShortestArcWith_Internal(ref FQuat A, in FQuat B);

		// Token: 0x06002947 RID: 10567
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Quat_AngularDistance_Internal(in FQuat A, in FQuat B);

		// Token: 0x06002948 RID: 10568
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PointsAreCoplanar_Internal(IntPtr Points, float Tolerance);

		// Token: 0x06002949 RID: 10569
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Now_Internal();

		// Token: 0x0600294A RID: 10570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqualExactly_Vector4Vector4_Internal(in FVector4 A, in FVector4 B);

		// Token: 0x0600294B RID: 10571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_Vector4Vector4_Internal(in FVector4 A, in FVector4 B, float ErrorTolerance);

		// Token: 0x0600294C RID: 10572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_TimespanTimespan_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600294D RID: 10573
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_QuatQuat_Internal(in FQuat A, in FQuat B, float ErrorTolerance);

		// Token: 0x0600294E RID: 10574
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_ObjectObject_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600294F RID: 10575
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_MatrixMatrix_Internal(in FMatrix A, in FMatrix B, float Tolerance);

		// Token: 0x06002950 RID: 10576
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_DateTimeDateTime_Internal(IntPtr A, IntPtr B);

		// Token: 0x06002951 RID: 10577
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NearlyEqual_TransformTransform_Internal(in FTransform A, in FTransform B, float LocationTolerance, float RotationTolerance, float Scale3DTolerance);

		// Token: 0x06002952 RID: 10578
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Multiply_Vector4Vector4_Internal(in FVector4 A, in FVector4 B);

		// Token: 0x06002953 RID: 10579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Multiply_TimespanFloat_Internal(IntPtr A, float Scalar);

		// Token: 0x06002954 RID: 10580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __Multiply_QuatQuat_Internal(in FQuat A, in FQuat B);

		// Token: 0x06002955 RID: 10581
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Multiply_MatrixMatrix_Internal(in FMatrix A, in FMatrix B);

		// Token: 0x06002956 RID: 10582
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Multiply_MatrixFloat_Internal(in FMatrix A, float B);

		// Token: 0x06002957 RID: 10583
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MinOfIntArray_Internal(IntPtr IntArray, ref int IndexOfMinValue, ref int MinValue);

		// Token: 0x06002958 RID: 10584
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MinOfFloatArray_Internal(IntPtr FloatArray, ref int IndexOfMinValue, ref float MinValue);

		// Token: 0x06002959 RID: 10585
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MinOfByteArray_Internal(IntPtr ByteArray, ref int IndexOfMinValue, ref byte MinValue);

		// Token: 0x0600295A RID: 10586
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MinimumAreaRectangle_Internal(IntPtr WorldContextObject, IntPtr InVerts, in FVector SampleSurfaceNormal, ref FVector OutRectCenter, ref FRotator OutRectRotation, ref float OutSideLengthX, ref float OutSideLengthY, bool bDebugDraw);

		// Token: 0x0600295B RID: 10587
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MaxOfIntArray_Internal(IntPtr IntArray, ref int IndexOfMaxValue, ref int MaxValue);

		// Token: 0x0600295C RID: 10588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MaxOfFloatArray_Internal(IntPtr FloatArray, ref int IndexOfMaxValue, ref float MaxValue);

		// Token: 0x0600295D RID: 10589
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MaxOfByteArray_Internal(IntPtr ByteArray, ref int IndexOfMaxValue, ref byte MaxValue);

		// Token: 0x0600295E RID: 10590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Matrix_TransformVector4_Internal(in FMatrix M, in FVector4 V);

		// Token: 0x0600295F RID: 10591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Matrix_TransformVector_Internal(in FMatrix M, FVector V);

		// Token: 0x06002960 RID: 10592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Matrix_TransformPosition_Internal(in FMatrix M, FVector V);

		// Token: 0x06002961 RID: 10593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __Matrix_ToQuat_Internal(in FMatrix M);

		// Token: 0x06002962 RID: 10594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Matrix_SetOrigin_Internal(ref FMatrix M, FVector NewOrigin);

		// Token: 0x06002963 RID: 10595
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Matrix_SetAxis_Internal(ref FMatrix M, TEnumAsByte<EAxis> Axis, FVector AxisVector);

		// Token: 0x06002964 RID: 10596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Matrix_ScaleTranslation_Internal(in FMatrix M, FVector Scale3D);

		// Token: 0x06002965 RID: 10597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Matrix_RemoveTranslation_Internal(in FMatrix M);

		// Token: 0x06002966 RID: 10598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Matrix_RemoveScaling_Internal(ref FMatrix M, float Tolerance);

		// Token: 0x06002967 RID: 10599
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Matrix_Mirror_Internal(in FMatrix M, TEnumAsByte<EAxis> MirrorAxis, TEnumAsByte<EAxis> FlipAxis);

		// Token: 0x06002968 RID: 10600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Matrix_InverseTransformVector_Internal(in FMatrix M, FVector V);

		// Token: 0x06002969 RID: 10601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Matrix_InverseTransformPosition_Internal(in FMatrix M, FVector V);

		// Token: 0x0600296A RID: 10602
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Matrix_GetUnitAxis_Internal(in FMatrix M, TEnumAsByte<EAxis> Axis);

		// Token: 0x0600296B RID: 10603
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Matrix_GetUnitAxes_Internal(in FMatrix M, ref FVector X, ref FVector Y, ref FVector Z);

		// Token: 0x0600296C RID: 10604
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Matrix_GetTransposed_Internal(in FMatrix M);

		// Token: 0x0600296D RID: 10605
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Matrix_GetTransposeAdjoint_Internal(in FMatrix M);

		// Token: 0x0600296E RID: 10606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Matrix_GetScaleVector_Internal(in FMatrix M, float Tolerance);

		// Token: 0x0600296F RID: 10607
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Matrix_GetScaledAxis_Internal(in FMatrix M, TEnumAsByte<EAxis> Axis);

		// Token: 0x06002970 RID: 10608
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Matrix_GetScaledAxes_Internal(in FMatrix M, ref FVector X, ref FVector Y, ref FVector Z);

		// Token: 0x06002971 RID: 10609
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Matrix_GetRotDeterminant_Internal(in FMatrix M);

		// Token: 0x06002972 RID: 10610
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __Matrix_GetRotator_Internal(in FMatrix M);

		// Token: 0x06002973 RID: 10611
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Matrix_GetOrigin_Internal(in FMatrix InMatrix);

		// Token: 0x06002974 RID: 10612
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Matrix_GetMaximumAxisScale_Internal(in FMatrix M);

		// Token: 0x06002975 RID: 10613
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Matrix_GetMatrixWithoutScale_Internal(in FMatrix M, float Tolerance);

		// Token: 0x06002976 RID: 10614
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Matrix_GetInverse_Internal(in FMatrix M);

		// Token: 0x06002977 RID: 10615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Matrix_GetFrustumTopPlane_Internal(in FMatrix M, ref FPlane OutPlane);

		// Token: 0x06002978 RID: 10616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Matrix_GetFrustumRightPlane_Internal(in FMatrix M, ref FPlane OutPlane);

		// Token: 0x06002979 RID: 10617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Matrix_GetFrustumNearPlane_Internal(in FMatrix M, ref FPlane OutPlane);

		// Token: 0x0600297A RID: 10618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Matrix_GetFrustumLeftPlane_Internal(in FMatrix M, ref FPlane OutPlane);

		// Token: 0x0600297B RID: 10619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Matrix_GetFrustumFarPlane_Internal(in FMatrix M, ref FPlane OutPlane);

		// Token: 0x0600297C RID: 10620
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Matrix_GetFrustumBottomPlane_Internal(in FMatrix M, ref FPlane OutPlane);

		// Token: 0x0600297D RID: 10621
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Matrix_GetDeterminant_Internal(in FMatrix M);

		// Token: 0x0600297E RID: 10622
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Matrix_ContainsNaN_Internal(in FMatrix M);

		// Token: 0x0600297F RID: 10623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Matrix_ConcatenateTranslation_Internal(in FMatrix M, FVector Translation);

		// Token: 0x06002980 RID: 10624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Matrix_ApplyScale_Internal(in FMatrix M, float Scale);

		// Token: 0x06002981 RID: 10625
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeTimespan2_Internal(int Days, int Hours, int Minutes, int Seconds, int FractionNano);

		// Token: 0x06002982 RID: 10626
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeTimespan_Internal(int Days, int Hours, int Minutes, int Seconds, int Milliseconds);

		// Token: 0x06002983 RID: 10627
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __MakeRelativeTransform_Internal(in FTransform A, in FTransform RelativeTo);

		// Token: 0x06002984 RID: 10628
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeQualifiedFrameTime_Internal(IntPtr Frame, FFrameRate FrameRate, float SubFrame);

		// Token: 0x06002985 RID: 10629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeDateTime_Internal(int Year, int Month, int Day, int Hour, int Minute, int Second, int Millisecond);

		// Token: 0x06002986 RID: 10630
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LinePlaneIntersection_Internal(in FVector LineStart, in FVector LineEnd, in FPlane APlane, ref float T, ref FVector Intersection);

		// Token: 0x06002987 RID: 10631
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LessEqual_TimespanTimespan_Internal(IntPtr A, IntPtr B);

		// Token: 0x06002988 RID: 10632
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LessEqual_DateTimeDateTime_Internal(IntPtr A, IntPtr B);

		// Token: 0x06002989 RID: 10633
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Less_TimespanTimespan_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600298A RID: 10634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Less_DateTimeDateTime_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600298B RID: 10635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPointInBoxWithTransform_Internal(FVector Point, in FTransform BoxWorldTransform, FVector BoxExtent);

		// Token: 0x0600298C RID: 10636
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsMorning_Internal(IntPtr A);

		// Token: 0x0600298D RID: 10637
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAfternoon_Internal(IntPtr A);

		// Token: 0x0600298E RID: 10638
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __InvertTransform_Internal(in FTransform T);

		// Token: 0x0600298F RID: 10639
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __InverseTransformRotation_Internal(in FTransform T, FRotator Rotation);

		// Token: 0x06002990 RID: 10640
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __InverseTransformLocation_Internal(in FTransform T, FVector Location);

		// Token: 0x06002991 RID: 10641
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __InverseTransformDirection_Internal(in FTransform T, FVector Direction);

		// Token: 0x06002992 RID: 10642
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GreaterEqual_TimespanTimespan_Internal(IntPtr A, IntPtr B);

		// Token: 0x06002993 RID: 10643
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GreaterEqual_DateTimeDateTime_Internal(IntPtr A, IntPtr B);

		// Token: 0x06002994 RID: 10644
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Greater_TimespanTimespan_Internal(IntPtr A, IntPtr B);

		// Token: 0x06002995 RID: 10645
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Greater_DateTimeDateTime_Internal(IntPtr A, IntPtr B);

		// Token: 0x06002996 RID: 10646
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetYear_Internal(IntPtr A);

		// Token: 0x06002997 RID: 10647
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetVectorArrayAverage_Internal(IntPtr Vectors);

		// Token: 0x06002998 RID: 10648
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTotalSeconds_Internal(IntPtr A);

		// Token: 0x06002999 RID: 10649
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTotalMinutes_Internal(IntPtr A);

		// Token: 0x0600299A RID: 10650
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTotalMilliseconds_Internal(IntPtr A);

		// Token: 0x0600299B RID: 10651
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTotalHours_Internal(IntPtr A);

		// Token: 0x0600299C RID: 10652
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTotalDays_Internal(IntPtr A);

		// Token: 0x0600299D RID: 10653
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTimeOfDay_Internal(IntPtr A);

		// Token: 0x0600299E RID: 10654
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetSeconds_Internal(IntPtr A);

		// Token: 0x0600299F RID: 10655
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetSecond_Internal(IntPtr A);

		// Token: 0x060029A0 RID: 10656
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMonth_Internal(IntPtr A);

		// Token: 0x060029A1 RID: 10657
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMinutes_Internal(IntPtr A);

		// Token: 0x060029A2 RID: 10658
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMinute_Internal(IntPtr A);

		// Token: 0x060029A3 RID: 10659
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMilliseconds_Internal(IntPtr A);

		// Token: 0x060029A4 RID: 10660
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMillisecond_Internal(IntPtr A);

		// Token: 0x060029A5 RID: 10661
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetHours_Internal(IntPtr A);

		// Token: 0x060029A6 RID: 10662
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetHour12_Internal(IntPtr A);

		// Token: 0x060029A7 RID: 10663
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetHour_Internal(IntPtr A);

		// Token: 0x060029A8 RID: 10664
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDuration_Internal(IntPtr A);

		// Token: 0x060029A9 RID: 10665
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetDays_Internal(IntPtr A);

		// Token: 0x060029AA RID: 10666
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetDayOfYear_Internal(IntPtr A);

		// Token: 0x060029AB RID: 10667
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetDay_Internal(IntPtr A);

		// Token: 0x060029AC RID: 10668
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDate_Internal(IntPtr A);

		// Token: 0x060029AD RID: 10669
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAzimuthAndElevation_Internal(FVector InDirection, in FTransform ReferenceFrame, ref float Azimuth, ref float Elevation);

		// Token: 0x060029AE RID: 10670
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FromSeconds_Internal(float Seconds);

		// Token: 0x060029AF RID: 10671
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FromMinutes_Internal(float Minutes);

		// Token: 0x060029B0 RID: 10672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FromMilliseconds_Internal(float Milliseconds);

		// Token: 0x060029B1 RID: 10673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FromHours_Internal(float Hours);

		// Token: 0x060029B2 RID: 10674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FromDays_Internal(float Days);

		// Token: 0x060029B3 RID: 10675
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualExactly_Vector4Vector4_Internal(in FVector4 A, in FVector4 B);

		// Token: 0x060029B4 RID: 10676
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_Vector4Vector4_Internal(in FVector4 A, in FVector4 B, float ErrorTolerance);

		// Token: 0x060029B5 RID: 10677
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_TransformTransform_Internal(in FTransform A, in FTransform B);

		// Token: 0x060029B6 RID: 10678
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_TimespanTimespan_Internal(IntPtr A, IntPtr B);

		// Token: 0x060029B7 RID: 10679
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_QuatQuat_Internal(in FQuat A, in FQuat B, float Tolerance);

		// Token: 0x060029B8 RID: 10680
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_ObjectObject_Internal(IntPtr A, IntPtr B);

		// Token: 0x060029B9 RID: 10681
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_MatrixMatrix_Internal(in FMatrix A, in FMatrix B, float Tolerance);

		// Token: 0x060029BA RID: 10682
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_DateTimeDateTime_Internal(IntPtr A, IntPtr B);

		// Token: 0x060029BB RID: 10683
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Divide_Vector4Vector4_Internal(in FVector4 A, in FVector4 B);

		// Token: 0x060029BC RID: 10684
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Divide_TimespanFloat_Internal(IntPtr A, float Scalar);

		// Token: 0x060029BD RID: 10685
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __DateTimeMinValue_Internal();

		// Token: 0x060029BE RID: 10686
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __DateTimeMaxValue_Internal();

		// Token: 0x060029BF RID: 10687
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DateTimeFromString_Internal(in FString DateTimeString, IntPtr Result);

		// Token: 0x060029C0 RID: 10688
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DateTimeFromIsoString_Internal(in FString IsoString, IntPtr Result);

		// Token: 0x060029C1 RID: 10689
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __D_TransformRotation_Internal(in FTransformDouble T, FRotator Rotation);

		// Token: 0x060029C2 RID: 10690
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_TransformLocation_Internal(in FTransformDouble T, FVectorDouble Location);

		// Token: 0x060029C3 RID: 10691
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_TransformDirection_Internal(in FTransformDouble T, FVectorDouble Direction);

		// Token: 0x060029C4 RID: 10692
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_TLerp_Internal(in FTransformDouble A, in FTransformDouble B, float Alpha, TEnumAsByte<ELerpInterpolationMode> InterpMode);

		// Token: 0x060029C5 RID: 10693
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_TInterpTo_Internal(in FTransformDouble Current, in FTransformDouble Target, float DeltaTime, float InterpSpeed);

		// Token: 0x060029C6 RID: 10694
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_MinOfFloatArray_Internal(IntPtr FloatArray, ref int IndexOfMinValue, ref double MinValue);

		// Token: 0x060029C7 RID: 10695
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_MaxOfFloatArray_Internal(IntPtr FloatArray, ref int IndexOfMaxValue, ref double MaxValue);

		// Token: 0x060029C8 RID: 10696
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_MakeRelativeTransform_Internal(in FTransformDouble A, in FTransformDouble RelativeTo);

		// Token: 0x060029C9 RID: 10697
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_InvertTransform_Internal(in FTransformDouble T);

		// Token: 0x060029CA RID: 10698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __D_InverseTransformRotation_Internal(in FTransformDouble T, FRotator Rotation);

		// Token: 0x060029CB RID: 10699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_InverseTransformLocation_Internal(in FTransformDouble T, FVectorDouble Location);

		// Token: 0x060029CC RID: 10700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_InverseTransformDirection_Internal(in FTransformDouble T, FVectorDouble Direction);

		// Token: 0x060029CD RID: 10701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetVectorArrayAverage_Internal(IntPtr Vectors);

		// Token: 0x060029CE RID: 10702
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_ComposeTransforms_Internal(in FTransformDouble A, in FTransformDouble B);

		// Token: 0x060029CF RID: 10703
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __ConvertTransformToRelative_Internal(in FTransform Transform, in FTransform ParentTransform);

		// Token: 0x060029D0 RID: 10704
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Conv_Vector4ToVector_Internal(in FVector4 InVector4);

		// Token: 0x060029D1 RID: 10705
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __Conv_Vector4ToRotator_Internal(in FVector4 InVec);

		// Token: 0x060029D2 RID: 10706
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __Conv_Vector4ToQuaternion_Internal(in FVector4 InVec);

		// Token: 0x060029D3 RID: 10707
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __Conv_TransformToTransformDouble_Internal(in FTransform InT);

		// Token: 0x060029D4 RID: 10708
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Conv_TransformToMatrix_Internal(in FTransform Transform);

		// Token: 0x060029D5 RID: 10709
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __Conv_TransformDoubleToTransform_Internal(in FTransformDouble InT);

		// Token: 0x060029D6 RID: 10710
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __Conv_MatrixToTransform_Internal(in FMatrix InMatrix);

		// Token: 0x060029D7 RID: 10711
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __Conv_MatrixToRotator_Internal(in FMatrix InMatrix);

		// Token: 0x060029D8 RID: 10712
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __ComposeTransforms_Internal(in FTransform A, in FTransform B);

		// Token: 0x060029D9 RID: 10713
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakVector4_Internal(in FVector4 InVec, ref float X, ref float Y, ref float Z, ref float W);

		// Token: 0x060029DA RID: 10714
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakTransformDouble_Internal(in FTransformDouble InTransform, ref FVectorDouble Location, ref FRotator Rotation, ref FVector Scale);

		// Token: 0x060029DB RID: 10715
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakTransform_Internal(in FTransform InTransform, ref FVector Location, ref FRotator Rotation, ref FVector Scale);

		// Token: 0x060029DC RID: 10716
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakTimespan2_Internal(IntPtr InTimespan, ref int Days, ref int Hours, ref int Minutes, ref int Seconds, ref int FractionNano);

		// Token: 0x060029DD RID: 10717
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakTimespan_Internal(IntPtr InTimespan, ref int Days, ref int Hours, ref int Minutes, ref int Seconds, ref int Milliseconds);

		// Token: 0x060029DE RID: 10718
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakQualifiedFrameTime_Internal(IntPtr InFrameTime, IntPtr Frame, ref FFrameRate FrameRate, ref float SubFrame);

		// Token: 0x060029DF RID: 10719
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakDateTime_Internal(IntPtr InDateTime, ref int Year, ref int Month, ref int Day, ref int Hour, ref int Minute, ref int Second, ref int Millisecond);

		// Token: 0x060029E0 RID: 10720
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Add_Vector4Vector4_Internal(in FVector4 A, in FVector4 B);

		// Token: 0x060029E1 RID: 10721
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Add_TimespanTimespan_Internal(IntPtr A, IntPtr B);

		// Token: 0x060029E2 RID: 10722
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __Add_QuatQuat_Internal(in FQuat A, in FQuat B);

		// Token: 0x060029E3 RID: 10723
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Add_MatrixMatrix_Internal(in FMatrix A, in FMatrix B);

		// Token: 0x060029E4 RID: 10724
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Add_DateTimeTimespan_Internal(IntPtr A, IntPtr B);

		// Token: 0x060029E5 RID: 10725
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Add_DateTimeDateTime_Internal(IntPtr A, IntPtr B);

		// Token: 0x060029E6 RID: 10726 RVA: 0x00038DB6 File Offset: 0x00036FB6
		static UKismetMathLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KismetMathLibrary");
		}

		// Token: 0x060029E7 RID: 10727 RVA: 0x00038DC4 File Offset: 0x00036FC4
		protected UKismetMathLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000E10 RID: 3600
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KismetMathLibrary";

		// Token: 0x04000E11 RID: 3601
		private static IntPtr _ClassPtr;

		// Token: 0x04000E12 RID: 3602
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000E13 RID: 3603
		private static IntPtr __Percent_FloatFloat_NativeFunctionPtr;

		// Token: 0x04000E14 RID: 3604
		private static IntPtr __Divide_FloatFloat_NativeFunctionPtr;

		// Token: 0x04000E15 RID: 3605
		private static IntPtr __D_Percent_FloatFloat_NativeFunctionPtr;

		// Token: 0x04000E16 RID: 3606
		private static IntPtr __D_Divide_FloatFloat_NativeFunctionPtr;

		// Token: 0x020009B0 RID: 2480
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Percent_FloatFloat_FunctionParams
		{
			// Token: 0x04005929 RID: 22825
			[FieldOffset(0)]
			public float A;

			// Token: 0x0400592A RID: 22826
			[FieldOffset(4)]
			public float B;

			// Token: 0x0400592B RID: 22827
			[FieldOffset(8)]
			public float __Result;
		}

		// Token: 0x020009B1 RID: 2481
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Divide_FloatFloat_FunctionParams
		{
			// Token: 0x0400592C RID: 22828
			[FieldOffset(0)]
			public float A;

			// Token: 0x0400592D RID: 22829
			[FieldOffset(4)]
			public float B;

			// Token: 0x0400592E RID: 22830
			[FieldOffset(8)]
			public float __Result;
		}

		// Token: 0x020009B2 RID: 2482
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __D_Percent_FloatFloat_FunctionParams
		{
			// Token: 0x0400592F RID: 22831
			[FieldOffset(0)]
			public double A;

			// Token: 0x04005930 RID: 22832
			[FieldOffset(8)]
			public double B;

			// Token: 0x04005931 RID: 22833
			[FieldOffset(16)]
			public double __Result;
		}

		// Token: 0x020009B3 RID: 2483
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __D_Divide_FloatFloat_FunctionParams
		{
			// Token: 0x04005932 RID: 22834
			[FieldOffset(0)]
			public double A;

			// Token: 0x04005933 RID: 22835
			[FieldOffset(8)]
			public double B;

			// Token: 0x04005934 RID: 22836
			[FieldOffset(16)]
			public double __Result;
		}
	}
}
