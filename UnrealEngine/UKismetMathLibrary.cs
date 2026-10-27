using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000CD1 RID: 3281
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.KismetMathLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKismetMathLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A650 RID: 42576 RVA: 0x000ECE84 File Offset: 0x000EB084
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKismetMathLibrary._ClassPtr;
		}

		// Token: 0x0600A651 RID: 42577 RVA: 0x000ECE90 File Offset: 0x000EB090
		public UKismetMathLibrary() : this(BuiltinUtils.AllocNativeUObject(UKismetMathLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A652 RID: 42578 RVA: 0x000ECEB8 File Offset: 0x000EB0B8
		[NullableContext(1)]
		public UKismetMathLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKismetMathLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A653 RID: 42579
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Xor_IntInt(int A, int B);

		// Token: 0x0600A654 RID: 42580
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Xor_Int64Int64(long A, long B);

		// Token: 0x0600A655 RID: 42581
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Wrap(int Value, int Min, int Max);

		// Token: 0x0600A656 RID: 42582
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector WeightedMovingAverage_FVector(FVector CurrentSample, FVector PreviousSample, float Weight);

		// Token: 0x0600A657 RID: 42583
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator WeightedMovingAverage_FRotator(FRotator CurrentSample, FRotator PreviousSample, float Weight);

		// Token: 0x0600A658 RID: 42584
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float WeightedMovingAverage_Float(float CurrentSample, float PreviousSample, float Weight);

		// Token: 0x0600A659 RID: 42585 RVA: 0x000ECEEB File Offset: 0x000EB0EB
		public static FVector WD_WorldToLocal(UObject WorldContextObject, FVectorDouble InVec)
		{
			return UKismetMathLibrary.__WD_WorldToLocal_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, InVec);
		}

		// Token: 0x0600A65A RID: 42586 RVA: 0x000ECF04 File Offset: 0x000EB104
		public unsafe static FTransformDouble WD_TransformToTransformDouble(UObject WorldContextObject, FTransform InT)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = InT;
			return UKismetMathLibrary.__WD_TransformToTransformDouble_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ptr);
		}

		// Token: 0x0600A65B RID: 42587 RVA: 0x000ECF40 File Offset: 0x000EB140
		public unsafe static FTransform WD_TransformDoubleToTransform(UObject WorldContextObject, FTransformDouble InT)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = InT;
			return UKismetMathLibrary.__WD_TransformDoubleToTransform_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, ptr);
		}

		// Token: 0x0600A65C RID: 42588 RVA: 0x000ECF7A File Offset: 0x000EB17A
		public static FVectorDouble WD_LocalToWorld(UObject WorldContextObject, FVector InVec)
		{
			return UKismetMathLibrary.__WD_LocalToWorld_Internal((WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, InVec);
		}

		// Token: 0x0600A65D RID: 42589
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float VSizeXYSquared(FVector A);

		// Token: 0x0600A65E RID: 42590
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float VSizeXY(FVector A);

		// Token: 0x0600A65F RID: 42591
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float VSizeSquared(FVector A);

		// Token: 0x0600A660 RID: 42592
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float VSize2DSquared(FVector2D A);

		// Token: 0x0600A661 RID: 42593
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float VSize2D(FVector2D A);

		// Token: 0x0600A662 RID: 42594
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float VSize(FVector A);

		// Token: 0x0600A663 RID: 42595
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector VLerp(FVector A, FVector B, float Alpha);

		// Token: 0x0600A664 RID: 42596
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector VInterpTo_Constant(FVector Current, FVector Target, float DeltaTime, float InterpSpeed);

		// Token: 0x0600A665 RID: 42597
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector VInterpTo(FVector Current, FVector Target, float DeltaTime, float InterpSpeed);

		// Token: 0x0600A666 RID: 42598 RVA: 0x000ECF92 File Offset: 0x000EB192
		public static FVector VectorSpringInterp(FVector Current, FVector Target, ref FVectorSpringState SpringState, float Stiffness, float CriticalDampingFactor, float DeltaTime, float Mass = 1f)
		{
			return UKismetMathLibrary.__VectorSpringInterp_Internal(Current, Target, (SpringState ?? new FVectorSpringState()).NativePtr, Stiffness, CriticalDampingFactor, DeltaTime, Mass);
		}

		// Token: 0x0600A667 RID: 42599
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_Zero();

		// Token: 0x0600A668 RID: 42600
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_Up();

		// Token: 0x0600A669 RID: 42601
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Vector_UnwindEuler(ref FVector A);

		// Token: 0x0600A66A RID: 42602
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Vector_UnitCartesianToSpherical(FVector A);

		// Token: 0x0600A66B RID: 42603
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_ToRadians(FVector A);

		// Token: 0x0600A66C RID: 42604
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_ToDegrees(FVector A);

		// Token: 0x0600A66D RID: 42605
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_SnappedToGrid(FVector InVect, float InGridSize);

		// Token: 0x0600A66E RID: 42606
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Vector_Set(ref FVector A, float X, float Y, float Z);

		// Token: 0x0600A66F RID: 42607
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_Right();

		// Token: 0x0600A670 RID: 42608
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_Reciprocal(in FVector A);

		// Token: 0x0600A671 RID: 42609
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_ProjectOnToNormal(FVector V, FVector InNormal);

		// Token: 0x0600A672 RID: 42610
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_One();

		// Token: 0x0600A673 RID: 42611
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_NormalUnsafe(in FVector A);

		// Token: 0x0600A674 RID: 42612
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Vector_Normalize(ref FVector A, float Tolerance = 0f);

		// Token: 0x0600A675 RID: 42613
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_Normal2D(FVector A, float Tolerance = 0.0001f);

		// Token: 0x0600A676 RID: 42614 RVA: 0x000ECFB4 File Offset: 0x000EB1B4
		public unsafe static FVector Vector_MirrorByPlane(FVector A, in FPlane InPlane)
		{
			ref FPlane ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InPlane;
			return UKismetMathLibrary.__Vector_MirrorByPlane_Internal(A, ptr);
		}

		// Token: 0x0600A677 RID: 42615
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_Left();

		// Token: 0x0600A678 RID: 42616
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Vector_IsZero(in FVector A);

		// Token: 0x0600A679 RID: 42617
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Vector_IsUnit(in FVector A, float SquaredLenthTolerance = 0.0001f);

		// Token: 0x0600A67A RID: 42618
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Vector_IsUniform(in FVector A, float Tolerance = 0.0001f);

		// Token: 0x0600A67B RID: 42619
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Vector_IsNormal(in FVector A);

		// Token: 0x0600A67C RID: 42620
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Vector_IsNearlyZero(in FVector A, float Tolerance = 0.0001f);

		// Token: 0x0600A67D RID: 42621
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Vector_IsNAN(in FVector A);

		// Token: 0x0600A67E RID: 42622
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Vector_HeadingAngle(FVector A);

		// Token: 0x0600A67F RID: 42623
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_GetSignVector(FVector A);

		// Token: 0x0600A680 RID: 42624
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_GetProjection(FVector A);

		// Token: 0x0600A681 RID: 42625
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Vector_GetAbsMin(FVector A);

		// Token: 0x0600A682 RID: 42626
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Vector_GetAbsMax(FVector A);

		// Token: 0x0600A683 RID: 42627
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_GetAbs(FVector A);

		// Token: 0x0600A684 RID: 42628
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_Forward();

		// Token: 0x0600A685 RID: 42629
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_Down();

		// Token: 0x0600A686 RID: 42630
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Vector_DistanceSquared(FVector V1, FVector V2);

		// Token: 0x0600A687 RID: 42631
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Vector_Distance2DSquared(FVector V1, FVector V2);

		// Token: 0x0600A688 RID: 42632
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Vector_Distance2D(FVector V1, FVector V2);

		// Token: 0x0600A689 RID: 42633
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Vector_Distance(FVector V1, FVector V2);

		// Token: 0x0600A68A RID: 42634
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Vector_CosineAngle2D(FVector A, FVector B);

		// Token: 0x0600A68B RID: 42635
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_ComponentMin(FVector A, FVector B);

		// Token: 0x0600A68C RID: 42636
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_ComponentMax(FVector A, FVector B);

		// Token: 0x0600A68D RID: 42637
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_ClampSizeMax2D(FVector A, float Max);

		// Token: 0x0600A68E RID: 42638
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_ClampSizeMax(FVector A, float Max);

		// Token: 0x0600A68F RID: 42639
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_ClampSize2D(FVector A, float Min, float Max);

		// Token: 0x0600A690 RID: 42640
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_BoundedToCube(FVector InVect, float InRadius);

		// Token: 0x0600A691 RID: 42641
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_BoundedToBox(FVector InVect, FVector InBoxMin, FVector InBoxMax);

		// Token: 0x0600A692 RID: 42642
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Vector_Backward();

		// Token: 0x0600A693 RID: 42643
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Vector_Assign(ref FVector A, in FVector InVector);

		// Token: 0x0600A694 RID: 42644
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Vector_AddBounded(ref FVector A, FVector InAddVect, float InRadius);

		// Token: 0x0600A695 RID: 42645
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector4 Vector4_Zero();

		// Token: 0x0600A696 RID: 42646 RVA: 0x000ECFE4 File Offset: 0x000EB1E4
		public unsafe static float Vector4_SizeSquared3(in FVector4 A)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_SizeSquared3_Internal(uintPtr);
		}

		// Token: 0x0600A697 RID: 42647 RVA: 0x000ED014 File Offset: 0x000EB214
		public unsafe static float Vector4_SizeSquared(in FVector4 A)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_SizeSquared_Internal(uintPtr);
		}

		// Token: 0x0600A698 RID: 42648 RVA: 0x000ED044 File Offset: 0x000EB244
		public unsafe static float Vector4_Size3(in FVector4 A)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_Size3_Internal(uintPtr);
		}

		// Token: 0x0600A699 RID: 42649 RVA: 0x000ED074 File Offset: 0x000EB274
		public unsafe static float Vector4_Size(in FVector4 A)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_Size_Internal(uintPtr);
		}

		// Token: 0x0600A69A RID: 42650 RVA: 0x000ED0A4 File Offset: 0x000EB2A4
		public unsafe static void Vector4_Set(ref FVector4 A, float X, float Y, float Z, float W)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			UKismetMathLibrary.__Vector4_Set_Internal(ref ptr, X, Y, Z, W);
			A = ptr;
		}

		// Token: 0x0600A69B RID: 42651 RVA: 0x000ED0E4 File Offset: 0x000EB2E4
		public unsafe static FVector4 Vector4_NormalUnsafe3(in FVector4 A)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_NormalUnsafe3_Internal(uintPtr);
		}

		// Token: 0x0600A69C RID: 42652 RVA: 0x000ED114 File Offset: 0x000EB314
		public unsafe static void Vector4_Normalize3(ref FVector4 A, float Tolerance = 0f)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			UKismetMathLibrary.__Vector4_Normalize3_Internal(ref ptr, Tolerance);
			A = ptr;
		}

		// Token: 0x0600A69D RID: 42653 RVA: 0x000ED150 File Offset: 0x000EB350
		public unsafe static FVector4 Vector4_Normal3(in FVector4 A, float Tolerance = 0.0001f)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_Normal3_Internal(uintPtr, Tolerance);
		}

		// Token: 0x0600A69E RID: 42654 RVA: 0x000ED180 File Offset: 0x000EB380
		public unsafe static FVector4 Vector4_Negated(in FVector4 A)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_Negated_Internal(uintPtr);
		}

		// Token: 0x0600A69F RID: 42655 RVA: 0x000ED1B0 File Offset: 0x000EB3B0
		public unsafe static FVector4 Vector4_MirrorByVector3(in FVector4 Direction, in FVector4 SurfaceNormal)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = Direction;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = SurfaceNormal;
			return UKismetMathLibrary.__Vector4_MirrorByVector3_Internal(ptr, ptr2);
		}

		// Token: 0x0600A6A0 RID: 42656 RVA: 0x000ED1FC File Offset: 0x000EB3FC
		public unsafe static bool Vector4_IsZero(in FVector4 A)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_IsZero_Internal(uintPtr);
		}

		// Token: 0x0600A6A1 RID: 42657 RVA: 0x000ED22C File Offset: 0x000EB42C
		public unsafe static bool Vector4_IsUnit3(in FVector4 A, float SquaredLenthTolerance = 0.0001f)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_IsUnit3_Internal(uintPtr, SquaredLenthTolerance);
		}

		// Token: 0x0600A6A2 RID: 42658 RVA: 0x000ED25C File Offset: 0x000EB45C
		public unsafe static bool Vector4_IsNormal3(in FVector4 A)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_IsNormal3_Internal(uintPtr);
		}

		// Token: 0x0600A6A3 RID: 42659 RVA: 0x000ED28C File Offset: 0x000EB48C
		public unsafe static bool Vector4_IsNearlyZero3(in FVector4 A, float Tolerance = 0.0001f)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_IsNearlyZero3_Internal(uintPtr, Tolerance);
		}

		// Token: 0x0600A6A4 RID: 42660 RVA: 0x000ED2BC File Offset: 0x000EB4BC
		public unsafe static bool Vector4_IsNAN(in FVector4 A)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Vector4_IsNAN_Internal(uintPtr);
		}

		// Token: 0x0600A6A5 RID: 42661 RVA: 0x000ED2EC File Offset: 0x000EB4EC
		public unsafe static float Vector4_DotProduct3(in FVector4 A, in FVector4 B)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Vector4_DotProduct3_Internal(ptr, ptr2);
		}

		// Token: 0x0600A6A6 RID: 42662 RVA: 0x000ED338 File Offset: 0x000EB538
		public unsafe static float Vector4_DotProduct(in FVector4 A, in FVector4 B)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Vector4_DotProduct_Internal(ptr, ptr2);
		}

		// Token: 0x0600A6A7 RID: 42663 RVA: 0x000ED384 File Offset: 0x000EB584
		public unsafe static FVector4 Vector4_CrossProduct3(in FVector4 A, in FVector4 B)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Vector4_CrossProduct3_Internal(ptr, ptr2);
		}

		// Token: 0x0600A6A8 RID: 42664 RVA: 0x000ED3D0 File Offset: 0x000EB5D0
		public unsafe static void Vector4_Assign(ref FVector4 A, in FVector4 InVector)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = InVector;
			UKismetMathLibrary.__Vector4_Assign_Internal(ref ptr, ptr2);
			A = ptr;
		}

		// Token: 0x0600A6A9 RID: 42665
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Vector2DInterpTo_Constant(FVector2D Current, FVector2D Target, float DeltaTime, float InterpSpeed);

		// Token: 0x0600A6AA RID: 42666
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Vector2DInterpTo(FVector2D Current, FVector2D Target, float DeltaTime, float InterpSpeed);

		// Token: 0x0600A6AB RID: 42667
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Vector2D_Zero();

		// Token: 0x0600A6AC RID: 42668
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Vector2D_Unit45Deg();

		// Token: 0x0600A6AD RID: 42669
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Vector2D_One();

		// Token: 0x0600A6AE RID: 42670
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector VEase(FVector A, FVector B, float Alpha, EEasingFunc EasingFunc, float BlendExp = 2f, int Steps = 2);

		// Token: 0x0600A6AF RID: 42671 RVA: 0x000ED428 File Offset: 0x000EB628
		[NullableContext(1)]
		public static FDateTime UtcNow()
		{
			return new FDateTime(UKismetMathLibrary.__UtcNow_Internal(), null);
		}

		// Token: 0x0600A6B0 RID: 42672 RVA: 0x000ED438 File Offset: 0x000EB638
		public unsafe static FVector4 TransformVector4(in FMatrix Matrix, in FVector4 Vec4)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = Matrix;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = Vec4;
			return UKismetMathLibrary.__TransformVector4_Internal(ptr, ptr2);
		}

		// Token: 0x0600A6B1 RID: 42673 RVA: 0x000ED484 File Offset: 0x000EB684
		public unsafe static FRotator TransformRotation(in FTransform T, FRotator Rotation)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__TransformRotation_Internal(uintPtr, Rotation);
		}

		// Token: 0x0600A6B2 RID: 42674 RVA: 0x000ED4B4 File Offset: 0x000EB6B4
		public unsafe static FVector TransformLocation(in FTransform T, FVector Location)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__TransformLocation_Internal(uintPtr, Location);
		}

		// Token: 0x0600A6B3 RID: 42675 RVA: 0x000ED4E4 File Offset: 0x000EB6E4
		public unsafe static FVector TransformDirection(in FTransform T, FVector Direction)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__TransformDirection_Internal(uintPtr, Direction);
		}

		// Token: 0x0600A6B4 RID: 42676 RVA: 0x000ED514 File Offset: 0x000EB714
		public unsafe static float Transform_Determinant(in FTransform Transform)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = Transform;
			return UKismetMathLibrary.__Transform_Determinant_Internal(uintPtr);
		}

		// Token: 0x0600A6B5 RID: 42677
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D ToSign2D(FVector2D A);

		// Token: 0x0600A6B6 RID: 42678
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D ToRounded2D(FVector2D A);

		// Token: 0x0600A6B7 RID: 42679
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ToDirectionAndLength2D(FVector2D A, ref FVector2D OutDir, ref float OutLength);

		// Token: 0x0600A6B8 RID: 42680 RVA: 0x000ED541 File Offset: 0x000EB741
		[NullableContext(1)]
		public static FDateTime Today()
		{
			return new FDateTime(UKismetMathLibrary.__Today_Internal(), null);
		}

		// Token: 0x0600A6B9 RID: 42681 RVA: 0x000ED550 File Offset: 0x000EB750
		public unsafe static FTransform TLerp(in FTransform A, in FTransform B, float Alpha, ELerpInterpolationMode InterpMode = ELerpInterpolationMode.QuatInterp)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__TLerp_Internal(ptr, ptr2, Alpha, InterpMode);
		}

		// Token: 0x0600A6BA RID: 42682 RVA: 0x000ED5A4 File Offset: 0x000EB7A4
		public unsafe static FTransform TInterpTo(in FTransform Current, in FTransform Target, float DeltaTime, float InterpSpeed)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Current;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = Target;
			return UKismetMathLibrary.__TInterpTo_Internal(ptr, ptr2, DeltaTime, InterpSpeed);
		}

		// Token: 0x0600A6BB RID: 42683 RVA: 0x000ED5F2 File Offset: 0x000EB7F2
		[NullableContext(1)]
		public static FTimespan TimespanZeroValue()
		{
			return new FTimespan(UKismetMathLibrary.__TimespanZeroValue_Internal(), null);
		}

		// Token: 0x0600A6BC RID: 42684 RVA: 0x000ED5FF File Offset: 0x000EB7FF
		public static float TimespanRatio(FTimespan A, FTimespan B)
		{
			return UKismetMathLibrary.__TimespanRatio_Internal((A ?? new FTimespan()).NativePtr, (B ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600A6BD RID: 42685 RVA: 0x000ED624 File Offset: 0x000EB824
		[NullableContext(1)]
		public static FTimespan TimespanMinValue()
		{
			return new FTimespan(UKismetMathLibrary.__TimespanMinValue_Internal(), null);
		}

		// Token: 0x0600A6BE RID: 42686 RVA: 0x000ED631 File Offset: 0x000EB831
		[NullableContext(1)]
		public static FTimespan TimespanMaxValue()
		{
			return new FTimespan(UKismetMathLibrary.__TimespanMaxValue_Internal(), null);
		}

		// Token: 0x0600A6BF RID: 42687 RVA: 0x000ED640 File Offset: 0x000EB840
		[NullableContext(1)]
		public unsafe static bool TimespanFromString(string TimespanString, [Nullable(2)] ref FTimespan Result)
		{
			FString fstring = FString.AllocTemp(TimespanString);
			bool result = UKismetMathLibrary.__TimespanFromString_Internal(fstring, (Result ?? new FTimespan()).NativePtr);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600A6C0 RID: 42688 RVA: 0x000ED674 File Offset: 0x000EB874
		public unsafe static FTransform TEase(in FTransform A, in FTransform B, float Alpha, EEasingFunc EasingFunc, float BlendExp = 2f, int Steps = 2)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__TEase_Internal(ptr, ptr2, Alpha, EasingFunc, BlendExp, Steps);
		}

		// Token: 0x0600A6C1 RID: 42689
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Tan(float A);

		// Token: 0x0600A6C2 RID: 42690
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Subtract_VectorVector(FVector A, FVector B);

		// Token: 0x0600A6C3 RID: 42691
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Subtract_VectorInt(FVector A, int B);

		// Token: 0x0600A6C4 RID: 42692
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Subtract_VectorFloat(FVector A, float B);

		// Token: 0x0600A6C5 RID: 42693 RVA: 0x000ED6CC File Offset: 0x000EB8CC
		public unsafe static FVector4 Subtract_Vector4Vector4(in FVector4 A, in FVector4 B)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Subtract_Vector4Vector4_Internal(ptr, ptr2);
		}

		// Token: 0x0600A6C6 RID: 42694
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Subtract_Vector2DVector2D(FVector2D A, FVector2D B);

		// Token: 0x0600A6C7 RID: 42695
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Subtract_Vector2DFloat(FVector2D A, float B);

		// Token: 0x0600A6C8 RID: 42696 RVA: 0x000ED718 File Offset: 0x000EB918
		[return: Nullable(1)]
		public static FTimespan Subtract_TimespanTimespan(FTimespan A, FTimespan B)
		{
			return new FTimespan(UKismetMathLibrary.__Subtract_TimespanTimespan_Internal((A ?? new FTimespan()).NativePtr, (B ?? new FTimespan()).NativePtr), null);
		}

		// Token: 0x0600A6C9 RID: 42697 RVA: 0x000ED744 File Offset: 0x000EB944
		public unsafe static FQuat Subtract_QuatQuat(in FQuat A, in FQuat B)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FQuat ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Subtract_QuatQuat_Internal(ptr, ptr2);
		}

		// Token: 0x0600A6CA RID: 42698
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor Subtract_LinearColorLinearColor(FLinearColor A, FLinearColor B);

		// Token: 0x0600A6CB RID: 42699
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint Subtract_IntPointIntPoint(FIntPoint A, FIntPoint B);

		// Token: 0x0600A6CC RID: 42700
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint Subtract_IntPointInt(FIntPoint A, int B);

		// Token: 0x0600A6CD RID: 42701
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Subtract_IntInt(int A, int B = 1);

		// Token: 0x0600A6CE RID: 42702
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Subtract_Int64Int64(long A, long B = 1L);

		// Token: 0x0600A6CF RID: 42703
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Subtract_FloatFloat(float A, float B = 1f);

		// Token: 0x0600A6D0 RID: 42704 RVA: 0x000ED790 File Offset: 0x000EB990
		[return: Nullable(1)]
		public static FDateTime Subtract_DateTimeTimespan(FDateTime A, FTimespan B)
		{
			return new FDateTime(UKismetMathLibrary.__Subtract_DateTimeTimespan_Internal((A ?? new FDateTime()).NativePtr, (B ?? new FTimespan()).NativePtr), null);
		}

		// Token: 0x0600A6D1 RID: 42705 RVA: 0x000ED7BB File Offset: 0x000EB9BB
		[return: Nullable(1)]
		public static FTimespan Subtract_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			return new FTimespan(UKismetMathLibrary.__Subtract_DateTimeDateTime_Internal((A ?? new FDateTime()).NativePtr, (B ?? new FDateTime()).NativePtr), null);
		}

		// Token: 0x0600A6D2 RID: 42706
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte Subtract_ByteByte(byte A, byte B = 1);

		// Token: 0x0600A6D3 RID: 42707
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Square(float A);

		// Token: 0x0600A6D4 RID: 42708
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Sqrt(float A);

		// Token: 0x0600A6D5 RID: 42709
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Spherical2DToUnitCartesian(FVector2D A);

		// Token: 0x0600A6D6 RID: 42710
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Sin(float A);

		// Token: 0x0600A6D7 RID: 42711
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long SignOfInteger64(long A);

		// Token: 0x0600A6D8 RID: 42712
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int SignOfInteger(int A);

		// Token: 0x0600A6D9 RID: 42713
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float SignOfFloat(float A);

		// Token: 0x0600A6DA RID: 42714
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SetRandomStreamSeed(ref FRandomStream Stream, int NewSeed);

		// Token: 0x0600A6DB RID: 42715
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Set2D(ref FVector2D A, float X, float Y);

		// Token: 0x0600A6DC RID: 42716
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector SelectVector(FVector A, FVector B, bool bPickA);

		// Token: 0x0600A6DD RID: 42717 RVA: 0x000ED7E8 File Offset: 0x000EB9E8
		public unsafe static FTransform SelectTransform(in FTransform A, in FTransform B, bool bPickA)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__SelectTransform_Internal(ptr, ptr2, bPickA);
		}

		// Token: 0x0600A6DE RID: 42718 RVA: 0x000ED838 File Offset: 0x000EBA38
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

		// Token: 0x0600A6DF RID: 42719
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator SelectRotator(FRotator A, FRotator B, bool bPickA);

		// Token: 0x0600A6E0 RID: 42720 RVA: 0x000ED874 File Offset: 0x000EBA74
		public static UObject SelectObject(UObject A, UObject B, bool bSelectA)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UObject>(UKismetMathLibrary.__SelectObject_Internal((A != null) ? A.NativePtr : IntPtr.Zero, (B != null) ? B.NativePtr : IntPtr.Zero, bSelectA));
		}

		// Token: 0x0600A6E1 RID: 42721
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int SelectInt(int A, int B, bool bPickA);

		// Token: 0x0600A6E2 RID: 42722
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float SelectFloat(float A, float B, bool bPickA);

		// Token: 0x0600A6E3 RID: 42723
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor SelectColor(FLinearColor A, FLinearColor B, bool bPickA);

		// Token: 0x0600A6E4 RID: 42724
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern UClassStackOnlyPtr SelectClass(UClassStackOnlyPtr A, UClassStackOnlyPtr B, bool bSelectA);

		// Token: 0x0600A6E5 RID: 42725
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void SeedRandomStream(ref FRandomStream Stream);

		// Token: 0x0600A6E6 RID: 42726
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float SafeDivide(float A, float B);

		// Token: 0x0600A6E7 RID: 42727
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Round64(float A);

		// Token: 0x0600A6E8 RID: 42728
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Round(float A);

		// Token: 0x0600A6E9 RID: 42729
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator RotatorFromAxisAndAngle(FVector Axis, float Angle);

		// Token: 0x0600A6EA RID: 42730
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RotateAngleAxis(FVector InVect, float AngleDeg, FVector Axis);

		// Token: 0x0600A6EB RID: 42731
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator RLerp(FRotator A, FRotator B, float Alpha, bool bShortestPath);

		// Token: 0x0600A6EC RID: 42732
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator RInterpTo_Constant(FRotator Current, FRotator Target, float DeltaTime, float InterpSpeed);

		// Token: 0x0600A6ED RID: 42733
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator RInterpTo(FRotator Current, FRotator Target, float DeltaTime, float InterpSpeed);

		// Token: 0x0600A6EE RID: 42734
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RGBToHSV_Vector(FLinearColor RGB, ref FLinearColor HSV);

		// Token: 0x0600A6EF RID: 42735
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void RGBToHSV(FLinearColor InColor, ref float H, ref float S, ref float V, ref float A);

		// Token: 0x0600A6F0 RID: 42736
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor RGBLinearToHSV(FLinearColor RGB);

		// Token: 0x0600A6F1 RID: 42737 RVA: 0x000ED8A1 File Offset: 0x000EBAA1
		public static void ResetVectorSpringState(ref FVectorSpringState SpringState)
		{
			UKismetMathLibrary.__ResetVectorSpringState_Internal((SpringState ?? new FVectorSpringState()).NativePtr);
		}

		// Token: 0x0600A6F2 RID: 42738
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ResetRandomStream(in FRandomStream Stream);

		// Token: 0x0600A6F3 RID: 42739 RVA: 0x000ED8B8 File Offset: 0x000EBAB8
		public static void ResetFloatSpringState(ref FFloatSpringState SpringState)
		{
			UKismetMathLibrary.__ResetFloatSpringState_Internal((SpringState ?? new FFloatSpringState()).NativePtr);
		}

		// Token: 0x0600A6F4 RID: 42740
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator REase(FRotator A, FRotator B, float Alpha, bool bShortestPath, EEasingFunc EasingFunc, float BlendExp = 2f, int Steps = 2);

		// Token: 0x0600A6F5 RID: 42741
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RandomUnitVectorInEllipticalConeInRadiansFromStream(in FVector ConeDir, float MaxYawInRadians, float MaxPitchInRadians, in FRandomStream Stream);

		// Token: 0x0600A6F6 RID: 42742
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RandomUnitVectorInEllipticalConeInRadians(FVector ConeDir, float MaxYawInRadians, float MaxPitchInRadians);

		// Token: 0x0600A6F7 RID: 42743
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RandomUnitVectorInEllipticalConeInDegreesFromStream(in FVector ConeDir, float MaxYawInDegrees, float MaxPitchInDegrees, in FRandomStream Stream);

		// Token: 0x0600A6F8 RID: 42744
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RandomUnitVectorInEllipticalConeInDegrees(FVector ConeDir, float MaxYawInDegrees, float MaxPitchInDegrees);

		// Token: 0x0600A6F9 RID: 42745
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RandomUnitVectorInConeInRadiansFromStream(in FVector ConeDir, float ConeHalfAngleInRadians, in FRandomStream Stream);

		// Token: 0x0600A6FA RID: 42746
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RandomUnitVectorInConeInRadians(FVector ConeDir, float ConeHalfAngleInRadians);

		// Token: 0x0600A6FB RID: 42747
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RandomUnitVectorInConeInDegreesFromStream(in FVector ConeDir, float ConeHalfAngleInDegrees, in FRandomStream Stream);

		// Token: 0x0600A6FC RID: 42748
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RandomUnitVectorInConeInDegrees(FVector ConeDir, float ConeHalfAngleInDegrees);

		// Token: 0x0600A6FD RID: 42749
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RandomUnitVectorFromStream(in FRandomStream Stream);

		// Token: 0x0600A6FE RID: 42750
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RandomUnitVector();

		// Token: 0x0600A6FF RID: 42751
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator RandomRotatorFromStream(bool bRoll, in FRandomStream Stream);

		// Token: 0x0600A700 RID: 42752
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator RandomRotator(bool bRoll = false);

		// Token: 0x0600A701 RID: 42753
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector RandomPointInBoundingBox(FVector Origin, FVector BoxExtent);

		// Token: 0x0600A702 RID: 42754
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int RandomIntegerInRangeFromStream(int Min, int Max, in FRandomStream Stream);

		// Token: 0x0600A703 RID: 42755
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int RandomIntegerInRange(int Min, int Max);

		// Token: 0x0600A704 RID: 42756
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int RandomIntegerFromStream(int Max, in FRandomStream Stream);

		// Token: 0x0600A705 RID: 42757
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long RandomInteger64InRange(long Min, long Max);

		// Token: 0x0600A706 RID: 42758
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long RandomInteger64(long Max);

		// Token: 0x0600A707 RID: 42759
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int RandomInteger(int Max);

		// Token: 0x0600A708 RID: 42760
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float RandomFloatInRangeFromStream(float Min, float Max, in FRandomStream Stream);

		// Token: 0x0600A709 RID: 42761
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float RandomFloatInRange(float Min, float Max);

		// Token: 0x0600A70A RID: 42762
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float RandomFloatFromStream(in FRandomStream Stream);

		// Token: 0x0600A70B RID: 42763
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float RandomFloat();

		// Token: 0x0600A70C RID: 42764
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool RandomBoolWithWeightFromStream(float Weight, in FRandomStream RandomStream);

		// Token: 0x0600A70D RID: 42765
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool RandomBoolWithWeight(float Weight);

		// Token: 0x0600A70E RID: 42766
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool RandomBoolFromStream(in FRandomStream Stream);

		// Token: 0x0600A70F RID: 42767
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool RandomBool();

		// Token: 0x0600A710 RID: 42768
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float RadiansToDegrees(float A);

		// Token: 0x0600A711 RID: 42769 RVA: 0x000ED8D0 File Offset: 0x000EBAD0
		public unsafe static FVector Quat_VectorUp(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_VectorUp_Internal(uintPtr);
		}

		// Token: 0x0600A712 RID: 42770 RVA: 0x000ED900 File Offset: 0x000EBB00
		public unsafe static FVector Quat_VectorRight(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_VectorRight_Internal(uintPtr);
		}

		// Token: 0x0600A713 RID: 42771 RVA: 0x000ED930 File Offset: 0x000EBB30
		public unsafe static FVector Quat_VectorForward(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_VectorForward_Internal(uintPtr);
		}

		// Token: 0x0600A714 RID: 42772 RVA: 0x000ED960 File Offset: 0x000EBB60
		public unsafe static FVector Quat_UnrotateVector(in FQuat Q, in FVector V)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_UnrotateVector_Internal(uintPtr, V);
		}

		// Token: 0x0600A715 RID: 42773 RVA: 0x000ED990 File Offset: 0x000EBB90
		public unsafe static float Quat_SizeSquared(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_SizeSquared_Internal(uintPtr);
		}

		// Token: 0x0600A716 RID: 42774 RVA: 0x000ED9C0 File Offset: 0x000EBBC0
		public unsafe static float Quat_Size(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_Size_Internal(uintPtr);
		}

		// Token: 0x0600A717 RID: 42775 RVA: 0x000ED9F0 File Offset: 0x000EBBF0
		public unsafe static void Quat_SetFromEuler(ref FQuat Q, in FVector Euler)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = Q;
			UKismetMathLibrary.__Quat_SetFromEuler_Internal(ref ptr, Euler);
			Q = ptr;
		}

		// Token: 0x0600A718 RID: 42776 RVA: 0x000EDA2C File Offset: 0x000EBC2C
		public unsafe static void Quat_SetComponents(ref FQuat Q, float X, float Y, float Z, float W)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = Q;
			UKismetMathLibrary.__Quat_SetComponents_Internal(ref ptr, X, Y, Z, W);
			Q = ptr;
		}

		// Token: 0x0600A719 RID: 42777 RVA: 0x000EDA6C File Offset: 0x000EBC6C
		public unsafe static FRotator Quat_Rotator(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_Rotator_Internal(uintPtr);
		}

		// Token: 0x0600A71A RID: 42778 RVA: 0x000EDA9C File Offset: 0x000EBC9C
		public unsafe static FVector Quat_RotateVector(in FQuat Q, in FVector V)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_RotateVector_Internal(uintPtr, V);
		}

		// Token: 0x0600A71B RID: 42779 RVA: 0x000EDACC File Offset: 0x000EBCCC
		public unsafe static FQuat Quat_Normalized(in FQuat Q, float Tolerance = 0.0001f)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_Normalized_Internal(uintPtr, Tolerance);
		}

		// Token: 0x0600A71C RID: 42780 RVA: 0x000EDAFC File Offset: 0x000EBCFC
		public unsafe static void Quat_Normalize(ref FQuat Q, float Tolerance = 0.0001f)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = Q;
			UKismetMathLibrary.__Quat_Normalize_Internal(ref ptr, Tolerance);
			Q = ptr;
		}

		// Token: 0x0600A71D RID: 42781
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FQuat Quat_MakeFromEuler(in FVector Euler);

		// Token: 0x0600A71E RID: 42782 RVA: 0x000EDB38 File Offset: 0x000EBD38
		public unsafe static FQuat Quat_Log(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_Log_Internal(uintPtr);
		}

		// Token: 0x0600A71F RID: 42783 RVA: 0x000EDB68 File Offset: 0x000EBD68
		public unsafe static bool Quat_IsNormalized(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_IsNormalized_Internal(uintPtr);
		}

		// Token: 0x0600A720 RID: 42784 RVA: 0x000EDB98 File Offset: 0x000EBD98
		public unsafe static bool Quat_IsNonFinite(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_IsNonFinite_Internal(uintPtr);
		}

		// Token: 0x0600A721 RID: 42785 RVA: 0x000EDBC8 File Offset: 0x000EBDC8
		public unsafe static bool Quat_IsIdentity(in FQuat Q, float Tolerance = 0.0001f)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_IsIdentity_Internal(uintPtr, Tolerance);
		}

		// Token: 0x0600A722 RID: 42786 RVA: 0x000EDBF8 File Offset: 0x000EBDF8
		public unsafe static bool Quat_IsFinite(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_IsFinite_Internal(uintPtr);
		}

		// Token: 0x0600A723 RID: 42787 RVA: 0x000EDC28 File Offset: 0x000EBE28
		public unsafe static FQuat Quat_Inversed(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_Inversed_Internal(uintPtr);
		}

		// Token: 0x0600A724 RID: 42788
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FQuat Quat_Identity();

		// Token: 0x0600A725 RID: 42789 RVA: 0x000EDC58 File Offset: 0x000EBE58
		public unsafe static FVector Quat_GetRotationAxis(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_GetRotationAxis_Internal(uintPtr);
		}

		// Token: 0x0600A726 RID: 42790 RVA: 0x000EDC88 File Offset: 0x000EBE88
		public unsafe static FVector Quat_GetAxisZ(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_GetAxisZ_Internal(uintPtr);
		}

		// Token: 0x0600A727 RID: 42791 RVA: 0x000EDCB8 File Offset: 0x000EBEB8
		public unsafe static FVector Quat_GetAxisY(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_GetAxisY_Internal(uintPtr);
		}

		// Token: 0x0600A728 RID: 42792 RVA: 0x000EDCE8 File Offset: 0x000EBEE8
		public unsafe static FVector Quat_GetAxisX(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_GetAxisX_Internal(uintPtr);
		}

		// Token: 0x0600A729 RID: 42793 RVA: 0x000EDD18 File Offset: 0x000EBF18
		public unsafe static float Quat_GetAngle(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_GetAngle_Internal(uintPtr);
		}

		// Token: 0x0600A72A RID: 42794
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FQuat Quat_FindBetween(in FVector V1, in FVector V2);

		// Token: 0x0600A72B RID: 42795 RVA: 0x000EDD48 File Offset: 0x000EBF48
		public unsafe static FQuat Quat_Exp(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_Exp_Internal(uintPtr);
		}

		// Token: 0x0600A72C RID: 42796 RVA: 0x000EDD78 File Offset: 0x000EBF78
		public unsafe static FVector Quat_Euler(in FQuat Q)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = Q;
			return UKismetMathLibrary.__Quat_Euler_Internal(uintPtr);
		}

		// Token: 0x0600A72D RID: 42797 RVA: 0x000EDDA8 File Offset: 0x000EBFA8
		public unsafe static void Quat_EnforceShortestArcWith(ref FQuat A, in FQuat B)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FQuat ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			UKismetMathLibrary.__Quat_EnforceShortestArcWith_Internal(ref ptr, ptr2);
			A = ptr;
		}

		// Token: 0x0600A72E RID: 42798 RVA: 0x000EDE00 File Offset: 0x000EC000
		public unsafe static float Quat_AngularDistance(in FQuat A, in FQuat B)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FQuat ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Quat_AngularDistance_Internal(ptr, ptr2);
		}

		// Token: 0x0600A72F RID: 42799
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector ProjectVectorOnToVector(FVector V, FVector Target);

		// Token: 0x0600A730 RID: 42800
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector ProjectVectorOnToPlane(FVector V, FVector PlaneNormal);

		// Token: 0x0600A731 RID: 42801
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector ProjectPointOnToPlane(FVector Point, FVector PlaneBase, FVector PlaneNormal);

		// Token: 0x0600A732 RID: 42802 RVA: 0x000EDE4C File Offset: 0x000EC04C
		public static bool PointsAreCoplanar(in TArray<FVector> Points, float Tolerance = 0.1f)
		{
			return UKismetMathLibrary.__PointsAreCoplanar_Internal((Points ?? new TArray<FVector>()).NativePtr, Tolerance);
		}

		// Token: 0x0600A733 RID: 42803
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float PerlinNoise1D(float Value);

		// Token: 0x0600A734 RID: 42804
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Percent_IntInt(int A, int B = 1);

		// Token: 0x0600A735 RID: 42805 RVA: 0x000EDE64 File Offset: 0x000EC064
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static float Percent_FloatFloat(float A, float B = 1f)
		{
			UKismetMathLibrary.__Percent_FloatFloat_FunctionParams* ptr = stackalloc UKismetMathLibrary.__Percent_FloatFloat_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKismetMathLibrary.__Percent_FloatFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetMathLibrary.__Percent_FloatFloat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->A = A;
			ptr->B = B;
			UnrealReflectionUtils.CallUFunction(UKismetMathLibrary._ClassDefaultObjectPtr, UKismetMathLibrary.__Percent_FloatFloat_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0600A736 RID: 42806
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte Percent_ByteByte(byte A, byte B = 1);

		// Token: 0x0600A737 RID: 42807
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Or_IntInt(int A, int B);

		// Token: 0x0600A738 RID: 42808
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Or_Int64Int64(long A, long B);

		// Token: 0x0600A739 RID: 42809 RVA: 0x000EDEB7 File Offset: 0x000EC0B7
		[NullableContext(1)]
		public static FDateTime Now()
		{
			return new FDateTime(UKismetMathLibrary.__Now_Internal(), null);
		}

		// Token: 0x0600A73A RID: 42810
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqualExactly_VectorVector(FVector A, FVector B);

		// Token: 0x0600A73B RID: 42811 RVA: 0x000EDEC4 File Offset: 0x000EC0C4
		public unsafe static bool NotEqualExactly_Vector4Vector4(in FVector4 A, in FVector4 B)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__NotEqualExactly_Vector4Vector4_Internal(ptr, ptr2);
		}

		// Token: 0x0600A73C RID: 42812
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqualExactly_Vector2DVector2D(FVector2D A, FVector2D B);

		// Token: 0x0600A73D RID: 42813
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_VectorVector(FVector A, FVector B, float ErrorTolerance = 0.0001f);

		// Token: 0x0600A73E RID: 42814 RVA: 0x000EDF10 File Offset: 0x000EC110
		public unsafe static bool NotEqual_Vector4Vector4(in FVector4 A, in FVector4 B, float ErrorTolerance = 0.0001f)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__NotEqual_Vector4Vector4_Internal(ptr, ptr2, ErrorTolerance);
		}

		// Token: 0x0600A73F RID: 42815
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_Vector2DVector2D(FVector2D A, FVector2D B, float ErrorTolerance = 0.0001f);

		// Token: 0x0600A740 RID: 42816 RVA: 0x000EDF5D File Offset: 0x000EC15D
		public static bool NotEqual_TimespanTimespan(FTimespan A, FTimespan B)
		{
			return UKismetMathLibrary.__NotEqual_TimespanTimespan_Internal((A ?? new FTimespan()).NativePtr, (B ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600A741 RID: 42817
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_RotatorRotator(FRotator A, FRotator B, float ErrorTolerance = 0.0001f);

		// Token: 0x0600A742 RID: 42818 RVA: 0x000EDF84 File Offset: 0x000EC184
		public unsafe static bool NotEqual_QuatQuat(in FQuat A, in FQuat B, float ErrorTolerance = 0.0001f)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FQuat ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__NotEqual_QuatQuat_Internal(ptr, ptr2, ErrorTolerance);
		}

		// Token: 0x0600A743 RID: 42819 RVA: 0x000EDFD1 File Offset: 0x000EC1D1
		public static bool NotEqual_ObjectObject(UObject A, UObject B)
		{
			return UKismetMathLibrary.__NotEqual_ObjectObject_Internal((A != null) ? A.NativePtr : IntPtr.Zero, (B != null) ? B.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A744 RID: 42820
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_NameName(FName A, FName B);

		// Token: 0x0600A745 RID: 42821 RVA: 0x000EDFF8 File Offset: 0x000EC1F8
		public unsafe static bool NotEqual_MatrixMatrix(in FMatrix A, in FMatrix B, float Tolerance = 0.0001f)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FMatrix ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__NotEqual_MatrixMatrix_Internal(ptr, ptr2, Tolerance);
		}

		// Token: 0x0600A746 RID: 42822
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_LinearColorLinearColor(FLinearColor A, FLinearColor B);

		// Token: 0x0600A747 RID: 42823
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_IntPointIntPoint(FIntPoint A, FIntPoint B);

		// Token: 0x0600A748 RID: 42824
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_IntInt(int A, int B);

		// Token: 0x0600A749 RID: 42825
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_Int64Int64(long A, long B);

		// Token: 0x0600A74A RID: 42826
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_FloatFloat(float A, float B);

		// Token: 0x0600A74B RID: 42827 RVA: 0x000EE045 File Offset: 0x000EC245
		public static bool NotEqual_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			return UKismetMathLibrary.__NotEqual_DateTimeDateTime_Internal((A ?? new FDateTime()).NativePtr, (B ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600A74C RID: 42828
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_ClassClass(UClassStackOnlyPtr A, UClassStackOnlyPtr B);

		// Token: 0x0600A74D RID: 42829
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_ByteByte(byte A, byte B);

		// Token: 0x0600A74E RID: 42830
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NotEqual_BoolBool(bool A, bool B);

		// Token: 0x0600A74F RID: 42831
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Not_PreBool(bool A);

		// Token: 0x0600A750 RID: 42832
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Not_Int64(long A);

		// Token: 0x0600A751 RID: 42833
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Not_Int(int A);

		// Token: 0x0600A752 RID: 42834
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D NormalSafe2D(FVector2D A, float Tolerance = 0f);

		// Token: 0x0600A753 RID: 42835
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float NormalizeToRange(float Value, float RangeMin, float RangeMax);

		// Token: 0x0600A754 RID: 42836
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator NormalizedDeltaRotator(FRotator A, FRotator B);

		// Token: 0x0600A755 RID: 42837
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float NormalizeAxis(float Angle);

		// Token: 0x0600A756 RID: 42838
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void Normalize2D(ref FVector2D A, float Tolerance = 0f);

		// Token: 0x0600A757 RID: 42839
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Normal2D(FVector2D A);

		// Token: 0x0600A758 RID: 42840
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Normal(FVector A, float Tolerance = 0.0001f);

		// Token: 0x0600A759 RID: 42841
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector NegateVector(FVector A);

		// Token: 0x0600A75A RID: 42842
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator NegateRotator(FRotator A);

		// Token: 0x0600A75B RID: 42843
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Negated2D(in FVector2D A);

		// Token: 0x0600A75C RID: 42844 RVA: 0x000EE06C File Offset: 0x000EC26C
		public unsafe static bool NearlyEqual_TransformTransform(in FTransform A, in FTransform B, float LocationTolerance = 0.0001f, float RotationTolerance = 0.0001f, float Scale3DTolerance = 0.0001f)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__NearlyEqual_TransformTransform_Internal(ptr, ptr2, LocationTolerance, RotationTolerance, Scale3DTolerance);
		}

		// Token: 0x0600A75D RID: 42845
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NearlyEqual_FloatFloat(float A, float B, float ErrorTolerance = 1E-06f);

		// Token: 0x0600A75E RID: 42846
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float MultiplyMultiply_FloatFloat(float Base, float Exp);

		// Token: 0x0600A75F RID: 42847
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float MultiplyByPi(float Value);

		// Token: 0x0600A760 RID: 42848
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Multiply_VectorVector(FVector A, FVector B);

		// Token: 0x0600A761 RID: 42849
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Multiply_VectorInt(FVector A, int B);

		// Token: 0x0600A762 RID: 42850
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Multiply_VectorFloat(FVector A, float B);

		// Token: 0x0600A763 RID: 42851 RVA: 0x000EE0BC File Offset: 0x000EC2BC
		public unsafe static FVector4 Multiply_Vector4Vector4(in FVector4 A, in FVector4 B)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Multiply_Vector4Vector4_Internal(ptr, ptr2);
		}

		// Token: 0x0600A764 RID: 42852
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Multiply_Vector2DVector2D(FVector2D A, FVector2D B);

		// Token: 0x0600A765 RID: 42853
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Multiply_Vector2DFloat(FVector2D A, float B);

		// Token: 0x0600A766 RID: 42854 RVA: 0x000EE108 File Offset: 0x000EC308
		[NullableContext(1)]
		public static FTimespan Multiply_TimespanFloat([Nullable(2)] FTimespan A, float Scalar)
		{
			return new FTimespan(UKismetMathLibrary.__Multiply_TimespanFloat_Internal((A ?? new FTimespan()).NativePtr, Scalar), null);
		}

		// Token: 0x0600A767 RID: 42855
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator Multiply_RotatorInt(FRotator A, int B);

		// Token: 0x0600A768 RID: 42856
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator Multiply_RotatorFloat(FRotator A, float B);

		// Token: 0x0600A769 RID: 42857 RVA: 0x000EE128 File Offset: 0x000EC328
		public unsafe static FQuat Multiply_QuatQuat(in FQuat A, in FQuat B)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FQuat ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Multiply_QuatQuat_Internal(ptr, ptr2);
		}

		// Token: 0x0600A76A RID: 42858 RVA: 0x000EE174 File Offset: 0x000EC374
		public unsafe static FMatrix Multiply_MatrixMatrix(in FMatrix A, in FMatrix B)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FMatrix ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Multiply_MatrixMatrix_Internal(ptr, ptr2);
		}

		// Token: 0x0600A76B RID: 42859 RVA: 0x000EE1C0 File Offset: 0x000EC3C0
		public unsafe static FMatrix Multiply_MatrixFloat(in FMatrix A, float B)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = A;
			return UKismetMathLibrary.__Multiply_MatrixFloat_Internal(uintPtr, B);
		}

		// Token: 0x0600A76C RID: 42860
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor Multiply_LinearColorLinearColor(FLinearColor A, FLinearColor B);

		// Token: 0x0600A76D RID: 42861
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor Multiply_LinearColorFloat(FLinearColor A, float B);

		// Token: 0x0600A76E RID: 42862
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint Multiply_IntPointIntPoint(FIntPoint A, FIntPoint B);

		// Token: 0x0600A76F RID: 42863
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint Multiply_IntPointInt(FIntPoint A, int B);

		// Token: 0x0600A770 RID: 42864
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Multiply_IntInt(int A, int B);

		// Token: 0x0600A771 RID: 42865
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Multiply_IntFloat(int A, float B);

		// Token: 0x0600A772 RID: 42866
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Multiply_Int64Int64(long A, long B);

		// Token: 0x0600A773 RID: 42867
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Multiply_FloatFloat(float A, float B);

		// Token: 0x0600A774 RID: 42868
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte Multiply_ByteByte(byte A, byte B);

		// Token: 0x0600A775 RID: 42869
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector MirrorVectorByNormal(FVector InVect, FVector InNormal);

		// Token: 0x0600A776 RID: 42870 RVA: 0x000EE1F0 File Offset: 0x000EC3F0
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

		// Token: 0x0600A777 RID: 42871 RVA: 0x000EE224 File Offset: 0x000EC424
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

		// Token: 0x0600A778 RID: 42872 RVA: 0x000EE258 File Offset: 0x000EC458
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

		// Token: 0x0600A779 RID: 42873
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long MinInt64(long A, long B);

		// Token: 0x0600A77A RID: 42874 RVA: 0x000EE28C File Offset: 0x000EC48C
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

		// Token: 0x0600A77B RID: 42875
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Min(int A, int B);

		// Token: 0x0600A77C RID: 42876 RVA: 0x000EE2F8 File Offset: 0x000EC4F8
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

		// Token: 0x0600A77D RID: 42877 RVA: 0x000EE32C File Offset: 0x000EC52C
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

		// Token: 0x0600A77E RID: 42878 RVA: 0x000EE360 File Offset: 0x000EC560
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

		// Token: 0x0600A77F RID: 42879
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long MaxInt64(long A, long B);

		// Token: 0x0600A780 RID: 42880
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Max(int A, int B);

		// Token: 0x0600A781 RID: 42881 RVA: 0x000EE394 File Offset: 0x000EC594
		public unsafe static FVector4 Matrix_TransformVector4(in FMatrix M, FVector4 V)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = M;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = V;
			return UKismetMathLibrary.__Matrix_TransformVector4_Internal(ptr, ptr2);
		}

		// Token: 0x0600A782 RID: 42882 RVA: 0x000EE3DC File Offset: 0x000EC5DC
		public unsafe static FVector4 Matrix_TransformVector(in FMatrix M, FVector V)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_TransformVector_Internal(uintPtr, V);
		}

		// Token: 0x0600A783 RID: 42883 RVA: 0x000EE40C File Offset: 0x000EC60C
		public unsafe static FVector4 Matrix_TransformPosition(in FMatrix M, FVector V)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_TransformPosition_Internal(uintPtr, V);
		}

		// Token: 0x0600A784 RID: 42884 RVA: 0x000EE43C File Offset: 0x000EC63C
		public unsafe static FQuat Matrix_ToQuat(in FMatrix M)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_ToQuat_Internal(uintPtr);
		}

		// Token: 0x0600A785 RID: 42885 RVA: 0x000EE46C File Offset: 0x000EC66C
		public unsafe static void Matrix_SetOrigin(ref FMatrix M, FVector NewOrigin)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = M;
			UKismetMathLibrary.__Matrix_SetOrigin_Internal(ref ptr, NewOrigin);
			M = ptr;
		}

		// Token: 0x0600A786 RID: 42886 RVA: 0x000EE4A8 File Offset: 0x000EC6A8
		public unsafe static void Matrix_SetColumn(ref FMatrix M, EMatrixColumns Column, FVector Value)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = M;
			UKismetMathLibrary.__Matrix_SetColumn_Internal(ref ptr, Column, Value);
			M = ptr;
		}

		// Token: 0x0600A787 RID: 42887 RVA: 0x000EE4EC File Offset: 0x000EC6EC
		public unsafe static void Matrix_SetAxis(ref FMatrix M, EAxis Axis, FVector AxisVector)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = M;
			UKismetMathLibrary.__Matrix_SetAxis_Internal(ref ptr, Axis, AxisVector);
			M = ptr;
		}

		// Token: 0x0600A788 RID: 42888 RVA: 0x000EE530 File Offset: 0x000EC730
		public unsafe static FMatrix Matrix_ScaleTranslation(in FMatrix M, FVector Scale3D)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_ScaleTranslation_Internal(uintPtr, Scale3D);
		}

		// Token: 0x0600A789 RID: 42889 RVA: 0x000EE560 File Offset: 0x000EC760
		public unsafe static FMatrix Matrix_RemoveTranslation(in FMatrix M)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_RemoveTranslation_Internal(uintPtr);
		}

		// Token: 0x0600A78A RID: 42890 RVA: 0x000EE590 File Offset: 0x000EC790
		public unsafe static void Matrix_RemoveScaling(ref FMatrix M, float Tolerance = 0f)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = M;
			UKismetMathLibrary.__Matrix_RemoveScaling_Internal(ref ptr, Tolerance);
			M = ptr;
		}

		// Token: 0x0600A78B RID: 42891 RVA: 0x000EE5CC File Offset: 0x000EC7CC
		public unsafe static FMatrix Matrix_Mirror(in FMatrix M, EAxis MirrorAxis, EAxis FlipAxis)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_Mirror_Internal(uintPtr, MirrorAxis, FlipAxis);
		}

		// Token: 0x0600A78C RID: 42892 RVA: 0x000EE608 File Offset: 0x000EC808
		public unsafe static FVector Matrix_InverseTransformVector(in FMatrix M, FVector V)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_InverseTransformVector_Internal(uintPtr, V);
		}

		// Token: 0x0600A78D RID: 42893 RVA: 0x000EE638 File Offset: 0x000EC838
		public unsafe static FVector Matrix_InverseTransformPosition(in FMatrix M, FVector V)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_InverseTransformPosition_Internal(uintPtr, V);
		}

		// Token: 0x0600A78E RID: 42894
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FMatrix Matrix_Identity();

		// Token: 0x0600A78F RID: 42895 RVA: 0x000EE668 File Offset: 0x000EC868
		public unsafe static FVector Matrix_GetUnitAxis(in FMatrix M, EAxis Axis)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_GetUnitAxis_Internal(uintPtr, Axis);
		}

		// Token: 0x0600A790 RID: 42896 RVA: 0x000EE69C File Offset: 0x000EC89C
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

		// Token: 0x0600A791 RID: 42897 RVA: 0x000EE6EC File Offset: 0x000EC8EC
		public unsafe static FMatrix Matrix_GetTransposed(in FMatrix M)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_GetTransposed_Internal(uintPtr);
		}

		// Token: 0x0600A792 RID: 42898 RVA: 0x000EE71C File Offset: 0x000EC91C
		public unsafe static FMatrix Matrix_GetTransposeAdjoint(in FMatrix M)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_GetTransposeAdjoint_Internal(uintPtr);
		}

		// Token: 0x0600A793 RID: 42899 RVA: 0x000EE74C File Offset: 0x000EC94C
		public unsafe static FVector Matrix_GetScaleVector(in FMatrix M, float Tolerance = 0f)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_GetScaleVector_Internal(uintPtr, Tolerance);
		}

		// Token: 0x0600A794 RID: 42900 RVA: 0x000EE77C File Offset: 0x000EC97C
		public unsafe static FVector Matrix_GetScaledAxis(in FMatrix M, EAxis Axis)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_GetScaledAxis_Internal(uintPtr, Axis);
		}

		// Token: 0x0600A795 RID: 42901 RVA: 0x000EE7B0 File Offset: 0x000EC9B0
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

		// Token: 0x0600A796 RID: 42902 RVA: 0x000EE800 File Offset: 0x000ECA00
		public unsafe static float Matrix_GetRotDeterminant(in FMatrix M)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_GetRotDeterminant_Internal(uintPtr);
		}

		// Token: 0x0600A797 RID: 42903 RVA: 0x000EE830 File Offset: 0x000ECA30
		public unsafe static FRotator Matrix_GetRotator(in FMatrix M)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_GetRotator_Internal(uintPtr);
		}

		// Token: 0x0600A798 RID: 42904 RVA: 0x000EE860 File Offset: 0x000ECA60
		public unsafe static FVector Matrix_GetOrigin(in FMatrix InMatrix)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = InMatrix;
			return UKismetMathLibrary.__Matrix_GetOrigin_Internal(uintPtr);
		}

		// Token: 0x0600A799 RID: 42905 RVA: 0x000EE890 File Offset: 0x000ECA90
		public unsafe static float Matrix_GetMaximumAxisScale(in FMatrix M)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_GetMaximumAxisScale_Internal(uintPtr);
		}

		// Token: 0x0600A79A RID: 42906 RVA: 0x000EE8C0 File Offset: 0x000ECAC0
		public unsafe static FMatrix Matrix_GetMatrixWithoutScale(in FMatrix M, float Tolerance = 0f)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_GetMatrixWithoutScale_Internal(uintPtr, Tolerance);
		}

		// Token: 0x0600A79B RID: 42907 RVA: 0x000EE8F0 File Offset: 0x000ECAF0
		public unsafe static FMatrix Matrix_GetInverse(in FMatrix M)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_GetInverse_Internal(uintPtr);
		}

		// Token: 0x0600A79C RID: 42908 RVA: 0x000EE920 File Offset: 0x000ECB20
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

		// Token: 0x0600A79D RID: 42909 RVA: 0x000EE978 File Offset: 0x000ECB78
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

		// Token: 0x0600A79E RID: 42910 RVA: 0x000EE9D0 File Offset: 0x000ECBD0
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

		// Token: 0x0600A79F RID: 42911 RVA: 0x000EEA28 File Offset: 0x000ECC28
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

		// Token: 0x0600A7A0 RID: 42912 RVA: 0x000EEA80 File Offset: 0x000ECC80
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

		// Token: 0x0600A7A1 RID: 42913 RVA: 0x000EEAD8 File Offset: 0x000ECCD8
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

		// Token: 0x0600A7A2 RID: 42914 RVA: 0x000EEB30 File Offset: 0x000ECD30
		public unsafe static float Matrix_GetDeterminant(in FMatrix M)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_GetDeterminant_Internal(uintPtr);
		}

		// Token: 0x0600A7A3 RID: 42915 RVA: 0x000EEB60 File Offset: 0x000ECD60
		public unsafe static FVector Matrix_GetColumn(in FMatrix M, EMatrixColumns Column)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_GetColumn_Internal(uintPtr, Column);
		}

		// Token: 0x0600A7A4 RID: 42916 RVA: 0x000EEB94 File Offset: 0x000ECD94
		public unsafe static bool Matrix_ContainsNaN(in FMatrix M)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_ContainsNaN_Internal(uintPtr);
		}

		// Token: 0x0600A7A5 RID: 42917 RVA: 0x000EEBC4 File Offset: 0x000ECDC4
		public unsafe static FMatrix Matrix_ConcatenateTranslation(in FMatrix M, FVector Translation)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_ConcatenateTranslation_Internal(uintPtr, Translation);
		}

		// Token: 0x0600A7A6 RID: 42918 RVA: 0x000EEBF4 File Offset: 0x000ECDF4
		public unsafe static FMatrix Matrix_ApplyScale(in FMatrix M, float Scale)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = M;
			return UKismetMathLibrary.__Matrix_ApplyScale_Internal(uintPtr, Scale);
		}

		// Token: 0x0600A7A7 RID: 42919
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float MapRangeUnclamped(float Value, float InRangeA, float InRangeB, float OutRangeA, float OutRangeB);

		// Token: 0x0600A7A8 RID: 42920
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float MapRangeClamped(float Value, float InRangeA, float InRangeB, float OutRangeA, float OutRangeB);

		// Token: 0x0600A7A9 RID: 42921
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble MakeVectorDouble(double X, double Y, double Z);

		// Token: 0x0600A7AA RID: 42922
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector4 MakeVector4(float X, float Y, float Z, float W);

		// Token: 0x0600A7AB RID: 42923
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble MakeVector2DDouble(double X, double Y);

		// Token: 0x0600A7AC RID: 42924
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D MakeVector2D(float X, float Y);

		// Token: 0x0600A7AD RID: 42925
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector MakeVector(float X, float Y, float Z);

		// Token: 0x0600A7AE RID: 42926
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FTransformDouble MakeTransformDouble(FVectorDouble Location, FRotator Rotation, FVector Scale);

		// Token: 0x0600A7AF RID: 42927
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FTransform MakeTransform(FVector Location, FRotator Rotation, FVector Scale);

		// Token: 0x0600A7B0 RID: 42928 RVA: 0x000EEC22 File Offset: 0x000ECE22
		[NullableContext(1)]
		public static FTimespan MakeTimespan2(int Days, int Hours, int Minutes, int Seconds, int FractionNano)
		{
			return new FTimespan(UKismetMathLibrary.__MakeTimespan2_Internal(Days, Hours, Minutes, Seconds, FractionNano), null);
		}

		// Token: 0x0600A7B1 RID: 42929 RVA: 0x000EEC35 File Offset: 0x000ECE35
		[NullableContext(1)]
		public static FTimespan MakeTimespan(int Days, int Hours, int Minutes, int Seconds, int Milliseconds)
		{
			return new FTimespan(UKismetMathLibrary.__MakeTimespan_Internal(Days, Hours, Minutes, Seconds, Milliseconds), null);
		}

		// Token: 0x0600A7B2 RID: 42930
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator MakeRotFromZY(in FVector Z, in FVector Y);

		// Token: 0x0600A7B3 RID: 42931
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator MakeRotFromZX(in FVector Z, in FVector X);

		// Token: 0x0600A7B4 RID: 42932
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator MakeRotFromZ(in FVector Z);

		// Token: 0x0600A7B5 RID: 42933
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator MakeRotFromYZ(in FVector Y, in FVector Z);

		// Token: 0x0600A7B6 RID: 42934
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator MakeRotFromYX(in FVector Y, in FVector X);

		// Token: 0x0600A7B7 RID: 42935
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator MakeRotFromY(in FVector Y);

		// Token: 0x0600A7B8 RID: 42936
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator MakeRotFromXZ(in FVector X, in FVector Z);

		// Token: 0x0600A7B9 RID: 42937
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator MakeRotFromXY(in FVector X, in FVector Y);

		// Token: 0x0600A7BA RID: 42938
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator MakeRotFromX(in FVector X);

		// Token: 0x0600A7BB RID: 42939
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator MakeRotator(float Roll, float Pitch, float Yaw);

		// Token: 0x0600A7BC RID: 42940
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator MakeRotationFromAxes(FVector Forward, FVector Right, FVector Up);

		// Token: 0x0600A7BD RID: 42941 RVA: 0x000EEC48 File Offset: 0x000ECE48
		public unsafe static FTransform MakeRelativeTransform(in FTransform A, in FTransform RelativeTo)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = RelativeTo;
			return UKismetMathLibrary.__MakeRelativeTransform_Internal(ptr, ptr2);
		}

		// Token: 0x0600A7BE RID: 42942
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRandomStream MakeRandomStream(int InitialSeed);

		// Token: 0x0600A7BF RID: 42943 RVA: 0x000EEC94 File Offset: 0x000ECE94
		[NullableContext(1)]
		public static FQualifiedFrameTime MakeQualifiedFrameTime([Nullable(2)] FFrameNumber Frame, FFrameRate FrameRate, float SubFrame = 0f)
		{
			return new FQualifiedFrameTime(UKismetMathLibrary.__MakeQualifiedFrameTime_Internal((Frame ?? new FFrameNumber()).NativePtr, FrameRate, SubFrame), null);
		}

		// Token: 0x0600A7C0 RID: 42944
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float MakePulsatingValue(float InCurrentTime, float InPulsesPerSecond = 1f, float InPhase = 0f);

		// Token: 0x0600A7C1 RID: 42945
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FPlane MakePlaneFromPointAndNormal(FVector Point, FVector Normal);

		// Token: 0x0600A7C2 RID: 42946
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FFrameRate MakeFrameRate(int Numerator, int Denominator = 1);

		// Token: 0x0600A7C3 RID: 42947 RVA: 0x000EECB2 File Offset: 0x000ECEB2
		[NullableContext(1)]
		public static FDateTime MakeDateTime(int Year, int Month, int Day, int Hour = 0, int Minute = 0, int Second = 0, int Millisecond = 0)
		{
			return new FDateTime(UKismetMathLibrary.__MakeDateTime_Internal(Year, Month, Day, Hour, Minute, Second, Millisecond), null);
		}

		// Token: 0x0600A7C4 RID: 42948
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor MakeColor(float R, float G, float B, float A = 1f);

		// Token: 0x0600A7C5 RID: 42949
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FBox2D MakeBox2D(FVector2D Min, FVector2D Max);

		// Token: 0x0600A7C6 RID: 42950
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FBox MakeBox(FVector Min, FVector Max);

		// Token: 0x0600A7C7 RID: 42951
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Loge(float A);

		// Token: 0x0600A7C8 RID: 42952
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Log(float A, float Base = 1f);

		// Token: 0x0600A7C9 RID: 42953
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool LinePlaneIntersection_OriginNormal(in FVector LineStart, in FVector LineEnd, FVector PlaneOrigin, FVector PlaneNormal, ref float T, ref FVector Intersection);

		// Token: 0x0600A7CA RID: 42954 RVA: 0x000EECCC File Offset: 0x000ECECC
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

		// Token: 0x0600A7CB RID: 42955
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColorLerpUsingHSV(FLinearColor A, FLinearColor B, float Alpha);

		// Token: 0x0600A7CC RID: 42956
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColorLerp(FLinearColor A, FLinearColor B, float Alpha);

		// Token: 0x0600A7CD RID: 42957
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColor_Yellow();

		// Token: 0x0600A7CE RID: 42958
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColor_White();

		// Token: 0x0600A7CF RID: 42959
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColor_Transparent();

		// Token: 0x0600A7D0 RID: 42960
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FColor LinearColor_ToRGBE(FLinearColor InLinearColor);

		// Token: 0x0600A7D1 RID: 42961
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColor_ToNewOpacity(FLinearColor InColor, float InOpacity);

		// Token: 0x0600A7D2 RID: 42962
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LinearColor_SetTemperature(ref FLinearColor InOutColor, float InTemperature);

		// Token: 0x0600A7D3 RID: 42963
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LinearColor_SetRGBA(ref FLinearColor InOutColor, float R, float G, float B, float A = 1f);

		// Token: 0x0600A7D4 RID: 42964
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LinearColor_SetRandomHue(ref FLinearColor InOutColor);

		// Token: 0x0600A7D5 RID: 42965
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LinearColor_SetFromSRGB(ref FLinearColor InOutColor, in FColor InSRGB);

		// Token: 0x0600A7D6 RID: 42966
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LinearColor_SetFromPow22(ref FLinearColor InOutColor, in FColor InColor);

		// Token: 0x0600A7D7 RID: 42967
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LinearColor_SetFromHSV(ref FLinearColor InOutColor, float H, float S, float V, float A = 1f);

		// Token: 0x0600A7D8 RID: 42968
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void LinearColor_Set(ref FLinearColor InOutColor, FLinearColor InColor);

		// Token: 0x0600A7D9 RID: 42969
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColor_Red();

		// Token: 0x0600A7DA RID: 42970
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FColor LinearColor_QuantizeRound(FLinearColor InColor);

		// Token: 0x0600A7DB RID: 42971
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FColor LinearColor_Quantize(FLinearColor InColor);

		// Token: 0x0600A7DC RID: 42972
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool LinearColor_IsNearEqual(FLinearColor A, FLinearColor B, float Tolerance = 0.0001f);

		// Token: 0x0600A7DD RID: 42973
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColor_Green();

		// Token: 0x0600A7DE RID: 42974
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColor_Gray();

		// Token: 0x0600A7DF RID: 42975
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float LinearColor_GetMin(FLinearColor InColor);

		// Token: 0x0600A7E0 RID: 42976
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float LinearColor_GetMax(FLinearColor InColor);

		// Token: 0x0600A7E1 RID: 42977
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float LinearColor_GetLuminance(FLinearColor InColor);

		// Token: 0x0600A7E2 RID: 42978
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float LinearColor_Distance(FLinearColor C1, FLinearColor C2);

		// Token: 0x0600A7E3 RID: 42979
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColor_Desaturated(FLinearColor InColor, float InDesaturation);

		// Token: 0x0600A7E4 RID: 42980
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColor_Blue();

		// Token: 0x0600A7E5 RID: 42981
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor LinearColor_Black();

		// Token: 0x0600A7E6 RID: 42982
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector LessLess_VectorRotator(FVector A, FRotator B);

		// Token: 0x0600A7E7 RID: 42983 RVA: 0x000EED0D File Offset: 0x000ECF0D
		public static bool LessEqual_TimespanTimespan(FTimespan A, FTimespan B)
		{
			return UKismetMathLibrary.__LessEqual_TimespanTimespan_Internal((A ?? new FTimespan()).NativePtr, (B ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600A7E8 RID: 42984
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool LessEqual_IntInt(int A, int B);

		// Token: 0x0600A7E9 RID: 42985
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool LessEqual_Int64Int64(long A, long B);

		// Token: 0x0600A7EA RID: 42986
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool LessEqual_FloatFloat(float A, float B);

		// Token: 0x0600A7EB RID: 42987 RVA: 0x000EED32 File Offset: 0x000ECF32
		public static bool LessEqual_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			return UKismetMathLibrary.__LessEqual_DateTimeDateTime_Internal((A ?? new FDateTime()).NativePtr, (B ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600A7EC RID: 42988
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool LessEqual_ByteByte(byte A, byte B);

		// Token: 0x0600A7ED RID: 42989 RVA: 0x000EED57 File Offset: 0x000ECF57
		public static bool Less_TimespanTimespan(FTimespan A, FTimespan B)
		{
			return UKismetMathLibrary.__Less_TimespanTimespan_Internal((A ?? new FTimespan()).NativePtr, (B ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600A7EE RID: 42990
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Less_IntInt(int A, int B);

		// Token: 0x0600A7EF RID: 42991
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Less_Int64Int64(long A, long B);

		// Token: 0x0600A7F0 RID: 42992
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Less_FloatFloat(float A, float B);

		// Token: 0x0600A7F1 RID: 42993 RVA: 0x000EED7C File Offset: 0x000ECF7C
		public static bool Less_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			return UKismetMathLibrary.__Less_DateTimeDateTime_Internal((A ?? new FDateTime()).NativePtr, (B ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600A7F2 RID: 42994
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Less_ByteByte(byte A, byte B);

		// Token: 0x0600A7F3 RID: 42995
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Lerp(float A, float B, float Alpha);

		// Token: 0x0600A7F4 RID: 42996
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsZero2D(in FVector2D A);

		// Token: 0x0600A7F5 RID: 42997 RVA: 0x000EEDA4 File Offset: 0x000ECFA4
		public unsafe static bool IsPointInBoxWithTransform(FVector Point, in FTransform BoxWorldTransform, FVector BoxExtent)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = BoxWorldTransform;
			return UKismetMathLibrary.__IsPointInBoxWithTransform_Internal(Point, ptr, BoxExtent);
		}

		// Token: 0x0600A7F6 RID: 42998
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsPointInBox(FVector Point, FVector BoxOrigin, FVector BoxExtent);

		// Token: 0x0600A7F7 RID: 42999
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsNearlyZero2D(in FVector2D A, float Tolerance = 0.0001f);

		// Token: 0x0600A7F8 RID: 43000 RVA: 0x000EEDD5 File Offset: 0x000ECFD5
		public static bool IsMorning(FDateTime A)
		{
			return UKismetMathLibrary.__IsMorning_Internal((A ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600A7F9 RID: 43001
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsLeapYear(int Year);

		// Token: 0x0600A7FA RID: 43002 RVA: 0x000EEDEB File Offset: 0x000ECFEB
		public static bool IsAfternoon(FDateTime A)
		{
			return UKismetMathLibrary.__IsAfternoon_Internal((A ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600A7FB RID: 43003 RVA: 0x000EEE04 File Offset: 0x000ED004
		public unsafe static FTransform InvertTransform(in FTransform T)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__InvertTransform_Internal(uintPtr);
		}

		// Token: 0x0600A7FC RID: 43004 RVA: 0x000EEE34 File Offset: 0x000ED034
		public unsafe static FRotator InverseTransformRotation(in FTransform T, FRotator Rotation)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__InverseTransformRotation_Internal(uintPtr, Rotation);
		}

		// Token: 0x0600A7FD RID: 43005 RVA: 0x000EEE64 File Offset: 0x000ED064
		public unsafe static FVector InverseTransformLocation(in FTransform T, FVector Location)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__InverseTransformLocation_Internal(uintPtr, Location);
		}

		// Token: 0x0600A7FE RID: 43006 RVA: 0x000EEE94 File Offset: 0x000ED094
		public unsafe static FVector InverseTransformDirection(in FTransform T, FVector Direction)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__InverseTransformDirection_Internal(uintPtr, Direction);
		}

		// Token: 0x0600A7FF RID: 43007
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint IntPoint_Zero();

		// Token: 0x0600A800 RID: 43008
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint IntPoint_Up();

		// Token: 0x0600A801 RID: 43009
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint IntPoint_Right();

		// Token: 0x0600A802 RID: 43010
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint IntPoint_One();

		// Token: 0x0600A803 RID: 43011
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint IntPoint_Left();

		// Token: 0x0600A804 RID: 43012
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint IntPoint_Down();

		// Token: 0x0600A805 RID: 43013
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool InRange_IntInt(int Value, int Min, int Max, bool InclusiveMin = true, bool InclusiveMax = true);

		// Token: 0x0600A806 RID: 43014
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool InRange_Int64Int64(long Value, long Min, long Max, bool InclusiveMin = true, bool InclusiveMax = true);

		// Token: 0x0600A807 RID: 43015
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool InRange_FloatFloat(float Value, float Min, float Max, bool InclusiveMin = true, bool InclusiveMax = true);

		// Token: 0x0600A808 RID: 43016
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Hypotenuse(float Width, float Height);

		// Token: 0x0600A809 RID: 43017
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor HSVToRGBLinear(FLinearColor HSV);

		// Token: 0x0600A80A RID: 43018
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void HSVToRGB_Vector(FLinearColor HSV, ref FLinearColor RGB);

		// Token: 0x0600A80B RID: 43019
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor HSVToRGB(float H, float S, float V, float A = 1f);

		// Token: 0x0600A80C RID: 43020
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GridSnap_Float(float Location, float GridSize);

		// Token: 0x0600A80D RID: 43021
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector GreaterGreater_VectorRotator(FVector A, FRotator B);

		// Token: 0x0600A80E RID: 43022 RVA: 0x000EEEC2 File Offset: 0x000ED0C2
		public static bool GreaterEqual_TimespanTimespan(FTimespan A, FTimespan B)
		{
			return UKismetMathLibrary.__GreaterEqual_TimespanTimespan_Internal((A ?? new FTimespan()).NativePtr, (B ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600A80F RID: 43023
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GreaterEqual_IntInt(int A, int B);

		// Token: 0x0600A810 RID: 43024
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GreaterEqual_Int64Int64(long A, long B);

		// Token: 0x0600A811 RID: 43025
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GreaterEqual_FloatFloat(float A, float B);

		// Token: 0x0600A812 RID: 43026 RVA: 0x000EEEE7 File Offset: 0x000ED0E7
		public static bool GreaterEqual_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			return UKismetMathLibrary.__GreaterEqual_DateTimeDateTime_Internal((A ?? new FDateTime()).NativePtr, (B ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600A813 RID: 43027
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool GreaterEqual_ByteByte(byte A, byte B);

		// Token: 0x0600A814 RID: 43028 RVA: 0x000EEF0C File Offset: 0x000ED10C
		public static bool Greater_TimespanTimespan(FTimespan A, FTimespan B)
		{
			return UKismetMathLibrary.__Greater_TimespanTimespan_Internal((A ?? new FTimespan()).NativePtr, (B ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600A815 RID: 43029
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Greater_IntInt(int A, int B);

		// Token: 0x0600A816 RID: 43030
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Greater_Int64Int64(long A, long B);

		// Token: 0x0600A817 RID: 43031
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Greater_FloatFloat(float A, float B);

		// Token: 0x0600A818 RID: 43032 RVA: 0x000EEF31 File Offset: 0x000ED131
		public static bool Greater_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			return UKismetMathLibrary.__Greater_DateTimeDateTime_Internal((A ?? new FDateTime()).NativePtr, (B ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600A819 RID: 43033
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Greater_ByteByte(byte A, byte B);

		// Token: 0x0600A81A RID: 43034 RVA: 0x000EEF56 File Offset: 0x000ED156
		public static int GetYear(FDateTime A)
		{
			return UKismetMathLibrary.__GetYear_Internal((A ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600A81B RID: 43035
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetYawPitchFromVector(FVector InVec, ref float Yaw, ref float Pitch);

		// Token: 0x0600A81C RID: 43036 RVA: 0x000EEF6C File Offset: 0x000ED16C
		public static FVector GetVectorArrayAverage(in TArray<FVector> Vectors)
		{
			return UKismetMathLibrary.__GetVectorArrayAverage_Internal((Vectors ?? new TArray<FVector>()).NativePtr);
		}

		// Token: 0x0600A81D RID: 43037
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector GetUpVector(FRotator InRot);

		// Token: 0x0600A81E RID: 43038 RVA: 0x000EEF83 File Offset: 0x000ED183
		public static float GetTotalSeconds(FTimespan A)
		{
			return UKismetMathLibrary.__GetTotalSeconds_Internal((A ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600A81F RID: 43039 RVA: 0x000EEF99 File Offset: 0x000ED199
		public static float GetTotalMinutes(FTimespan A)
		{
			return UKismetMathLibrary.__GetTotalMinutes_Internal((A ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600A820 RID: 43040 RVA: 0x000EEFAF File Offset: 0x000ED1AF
		public static float GetTotalMilliseconds(FTimespan A)
		{
			return UKismetMathLibrary.__GetTotalMilliseconds_Internal((A ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600A821 RID: 43041 RVA: 0x000EEFC5 File Offset: 0x000ED1C5
		public static float GetTotalHours(FTimespan A)
		{
			return UKismetMathLibrary.__GetTotalHours_Internal((A ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600A822 RID: 43042 RVA: 0x000EEFDB File Offset: 0x000ED1DB
		public static float GetTotalDays(FTimespan A)
		{
			return UKismetMathLibrary.__GetTotalDays_Internal((A ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600A823 RID: 43043 RVA: 0x000EEFF1 File Offset: 0x000ED1F1
		[NullableContext(1)]
		public static FTimespan GetTimeOfDay([Nullable(2)] FDateTime A)
		{
			return new FTimespan(UKismetMathLibrary.__GetTimeOfDay_Internal((A ?? new FDateTime()).NativePtr), null);
		}

		// Token: 0x0600A824 RID: 43044
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetTAU();

		// Token: 0x0600A825 RID: 43045
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetSlopeDegreeAngles(in FVector MyRightYAxis, in FVector FloorNormal, in FVector UpVector, ref float OutSlopePitchDegreeAngle, ref float OutSlopeRollDegreeAngle);

		// Token: 0x0600A826 RID: 43046 RVA: 0x000EF00D File Offset: 0x000ED20D
		public static int GetSeconds(FTimespan A)
		{
			return UKismetMathLibrary.__GetSeconds_Internal((A ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600A827 RID: 43047 RVA: 0x000EF023 File Offset: 0x000ED223
		public static int GetSecond(FDateTime A)
		{
			return UKismetMathLibrary.__GetSecond_Internal((A ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600A828 RID: 43048
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetRotated2D(FVector2D A, float AngleDeg);

		// Token: 0x0600A829 RID: 43049
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector GetRightVector(FRotator InRot);

		// Token: 0x0600A82A RID: 43050
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector GetReflectionVector(FVector Direction, FVector SurfaceNormal);

		// Token: 0x0600A82B RID: 43051
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetPointDistanceToSegment(FVector Point, FVector SegmentStart, FVector SegmentEnd);

		// Token: 0x0600A82C RID: 43052
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetPointDistanceToLine(FVector Point, FVector LineOrigin, FVector LineDirection);

		// Token: 0x0600A82D RID: 43053
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetPI();

		// Token: 0x0600A82E RID: 43054 RVA: 0x000EF039 File Offset: 0x000ED239
		public static int GetMonth(FDateTime A)
		{
			return UKismetMathLibrary.__GetMonth_Internal((A ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600A82F RID: 43055 RVA: 0x000EF04F File Offset: 0x000ED24F
		public static int GetMinutes(FTimespan A)
		{
			return UKismetMathLibrary.__GetMinutes_Internal((A ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600A830 RID: 43056 RVA: 0x000EF065 File Offset: 0x000ED265
		public static int GetMinute(FDateTime A)
		{
			return UKismetMathLibrary.__GetMinute_Internal((A ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600A831 RID: 43057
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetMinElement(FVector A);

		// Token: 0x0600A832 RID: 43058
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetMin2D(FVector2D A);

		// Token: 0x0600A833 RID: 43059 RVA: 0x000EF07B File Offset: 0x000ED27B
		public static int GetMilliseconds(FTimespan A)
		{
			return UKismetMathLibrary.__GetMilliseconds_Internal((A ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600A834 RID: 43060 RVA: 0x000EF091 File Offset: 0x000ED291
		public static int GetMillisecond(FDateTime A)
		{
			return UKismetMathLibrary.__GetMillisecond_Internal((A ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600A835 RID: 43061
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetMaxElement(FVector A);

		// Token: 0x0600A836 RID: 43062
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetMax2D(FVector2D A);

		// Token: 0x0600A837 RID: 43063 RVA: 0x000EF0A7 File Offset: 0x000ED2A7
		public static int GetHours(FTimespan A)
		{
			return UKismetMathLibrary.__GetHours_Internal((A ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600A838 RID: 43064 RVA: 0x000EF0BD File Offset: 0x000ED2BD
		public static int GetHour12(FDateTime A)
		{
			return UKismetMathLibrary.__GetHour12_Internal((A ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600A839 RID: 43065 RVA: 0x000EF0D3 File Offset: 0x000ED2D3
		public static int GetHour(FDateTime A)
		{
			return UKismetMathLibrary.__GetHour_Internal((A ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600A83A RID: 43066
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector GetForwardVector(FRotator InRot);

		// Token: 0x0600A83B RID: 43067 RVA: 0x000EF0E9 File Offset: 0x000ED2E9
		[NullableContext(1)]
		public static FTimespan GetDuration([Nullable(2)] FTimespan A)
		{
			return new FTimespan(UKismetMathLibrary.__GetDuration_Internal((A ?? new FTimespan()).NativePtr), null);
		}

		// Token: 0x0600A83C RID: 43068
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector GetDirectionUnitVector(FVector From, FVector To);

		// Token: 0x0600A83D RID: 43069 RVA: 0x000EF105 File Offset: 0x000ED305
		public static int GetDays(FTimespan A)
		{
			return UKismetMathLibrary.__GetDays_Internal((A ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600A83E RID: 43070 RVA: 0x000EF11B File Offset: 0x000ED31B
		public static int GetDayOfYear(FDateTime A)
		{
			return UKismetMathLibrary.__GetDayOfYear_Internal((A ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600A83F RID: 43071 RVA: 0x000EF131 File Offset: 0x000ED331
		public static int GetDay(FDateTime A)
		{
			return UKismetMathLibrary.__GetDay_Internal((A ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600A840 RID: 43072 RVA: 0x000EF147 File Offset: 0x000ED347
		[NullableContext(1)]
		public static FDateTime GetDate([Nullable(2)] FDateTime A)
		{
			return new FDateTime(UKismetMathLibrary.__GetDate_Internal((A ?? new FDateTime()).NativePtr), null);
		}

		// Token: 0x0600A841 RID: 43073 RVA: 0x000EF164 File Offset: 0x000ED364
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

		// Token: 0x0600A842 RID: 43074
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void GetAxes(FRotator A, ref FVector X, ref FVector Y, ref FVector Z);

		// Token: 0x0600A843 RID: 43075
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetAbsMax2D(FVector2D A);

		// Token: 0x0600A844 RID: 43076
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D GetAbs2D(FVector2D A);

		// Token: 0x0600A845 RID: 43077
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float FWrap(float Value, float Min, float Max);

		// Token: 0x0600A846 RID: 43078
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntVector FTruncVector(in FVector InVector);

		// Token: 0x0600A847 RID: 43079
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long FTrunc64(float A);

		// Token: 0x0600A848 RID: 43080
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int FTrunc(float A);

		// Token: 0x0600A849 RID: 43081 RVA: 0x000EF1A9 File Offset: 0x000ED3A9
		[NullableContext(1)]
		public static FTimespan FromSeconds(float Seconds)
		{
			return new FTimespan(UKismetMathLibrary.__FromSeconds_Internal(Seconds), null);
		}

		// Token: 0x0600A84A RID: 43082 RVA: 0x000EF1B7 File Offset: 0x000ED3B7
		[NullableContext(1)]
		public static FTimespan FromMinutes(float Minutes)
		{
			return new FTimespan(UKismetMathLibrary.__FromMinutes_Internal(Minutes), null);
		}

		// Token: 0x0600A84B RID: 43083 RVA: 0x000EF1C5 File Offset: 0x000ED3C5
		[NullableContext(1)]
		public static FTimespan FromMilliseconds(float Milliseconds)
		{
			return new FTimespan(UKismetMathLibrary.__FromMilliseconds_Internal(Milliseconds), null);
		}

		// Token: 0x0600A84C RID: 43084 RVA: 0x000EF1D3 File Offset: 0x000ED3D3
		[NullableContext(1)]
		public static FTimespan FromHours(float Hours)
		{
			return new FTimespan(UKismetMathLibrary.__FromHours_Internal(Hours), null);
		}

		// Token: 0x0600A84D RID: 43085 RVA: 0x000EF1E1 File Offset: 0x000ED3E1
		[NullableContext(1)]
		public static FTimespan FromDays(float Days)
		{
			return new FTimespan(UKismetMathLibrary.__FromDays_Internal(Days), null);
		}

		// Token: 0x0600A84E RID: 43086
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Fraction(float A);

		// Token: 0x0600A84F RID: 43087
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int FMod(float Dividend, float Divisor, ref float Remainder);

		// Token: 0x0600A850 RID: 43088
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float FMin(float A, float B);

		// Token: 0x0600A851 RID: 43089
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float FMax(float A, float B);

		// Token: 0x0600A852 RID: 43090 RVA: 0x000EF1EF File Offset: 0x000ED3EF
		public static float FloatSpringInterp(float Current, float Target, ref FFloatSpringState SpringState, float Stiffness, float CriticalDampingFactor, float DeltaTime, float Mass = 1f)
		{
			return UKismetMathLibrary.__FloatSpringInterp_Internal(Current, Target, (SpringState ?? new FFloatSpringState()).NativePtr, Stiffness, CriticalDampingFactor, DeltaTime, Mass);
		}

		// Token: 0x0600A853 RID: 43091
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float FixedTurn(float InCurrent, float InDesired, float InDeltaRate);

		// Token: 0x0600A854 RID: 43092
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float FInterpTo_Constant(float Current, float Target, float DeltaTime, float InterpSpeed);

		// Token: 0x0600A855 RID: 43093
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float FInterpTo(float Current, float Target, float DeltaTime, float InterpSpeed);

		// Token: 0x0600A856 RID: 43094
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float FInterpEaseInOut(float A, float B, float Alpha, float Exponent);

		// Token: 0x0600A857 RID: 43095
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void FindNearestPointsOnLineSegments(FVector Segment1Start, FVector Segment1End, FVector Segment2Start, FVector Segment2End, ref FVector Segment1Point, ref FVector Segment2Point);

		// Token: 0x0600A858 RID: 43096
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator FindLookAtRotation(in FVector Start, in FVector Target);

		// Token: 0x0600A859 RID: 43097
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector FindClosestPointOnSegment(FVector Point, FVector SegmentStart, FVector SegmentEnd);

		// Token: 0x0600A85A RID: 43098
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector FindClosestPointOnLine(FVector Point, FVector LineOrigin, FVector LineDirection);

		// Token: 0x0600A85B RID: 43099
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long FFloor64(float A);

		// Token: 0x0600A85C RID: 43100
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int FFloor(float A);

		// Token: 0x0600A85D RID: 43101
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float FClamp(float Value, float Min, float Max);

		// Token: 0x0600A85E RID: 43102
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long FCeil64(float A);

		// Token: 0x0600A85F RID: 43103
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int FCeil(float A);

		// Token: 0x0600A860 RID: 43104
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Exp(float A);

		// Token: 0x0600A861 RID: 43105
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualExactly_VectorVector(FVector A, FVector B);

		// Token: 0x0600A862 RID: 43106 RVA: 0x000EF210 File Offset: 0x000ED410
		public unsafe static bool EqualExactly_Vector4Vector4(in FVector4 A, in FVector4 B)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__EqualExactly_Vector4Vector4_Internal(ptr, ptr2);
		}

		// Token: 0x0600A863 RID: 43107
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualExactly_Vector2DVector2D(FVector2D A, FVector2D B);

		// Token: 0x0600A864 RID: 43108
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_VectorVector(FVector A, FVector B, float ErrorTolerance = 0.0001f);

		// Token: 0x0600A865 RID: 43109 RVA: 0x000EF25C File Offset: 0x000ED45C
		public unsafe static bool EqualEqual_Vector4Vector4(in FVector4 A, in FVector4 B, float ErrorTolerance = 0.0001f)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__EqualEqual_Vector4Vector4_Internal(ptr, ptr2, ErrorTolerance);
		}

		// Token: 0x0600A866 RID: 43110
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_Vector2DVector2D(FVector2D A, FVector2D B, float ErrorTolerance = 0.0001f);

		// Token: 0x0600A867 RID: 43111 RVA: 0x000EF2AC File Offset: 0x000ED4AC
		public unsafe static bool EqualEqual_TransformTransform(in FTransform A, in FTransform B)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__EqualEqual_TransformTransform_Internal(ptr, ptr2);
		}

		// Token: 0x0600A868 RID: 43112 RVA: 0x000EF2F8 File Offset: 0x000ED4F8
		public static bool EqualEqual_TimespanTimespan(FTimespan A, FTimespan B)
		{
			return UKismetMathLibrary.__EqualEqual_TimespanTimespan_Internal((A ?? new FTimespan()).NativePtr, (B ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600A869 RID: 43113
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_RotatorRotator(FRotator A, FRotator B, float ErrorTolerance = 0.0001f);

		// Token: 0x0600A86A RID: 43114 RVA: 0x000EF320 File Offset: 0x000ED520
		public unsafe static bool EqualEqual_QuatQuat(in FQuat A, in FQuat B, float Tolerance = 0.0001f)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FQuat ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__EqualEqual_QuatQuat_Internal(ptr, ptr2, Tolerance);
		}

		// Token: 0x0600A86B RID: 43115 RVA: 0x000EF36D File Offset: 0x000ED56D
		public static bool EqualEqual_ObjectObject(UObject A, UObject B)
		{
			return UKismetMathLibrary.__EqualEqual_ObjectObject_Internal((A != null) ? A.NativePtr : IntPtr.Zero, (B != null) ? B.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A86C RID: 43116
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_NameName(FName A, FName B);

		// Token: 0x0600A86D RID: 43117 RVA: 0x000EF394 File Offset: 0x000ED594
		public unsafe static bool EqualEqual_MatrixMatrix(in FMatrix A, in FMatrix B, float Tolerance = 0.0001f)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FMatrix ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__EqualEqual_MatrixMatrix_Internal(ptr, ptr2, Tolerance);
		}

		// Token: 0x0600A86E RID: 43118
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_LinearColorLinearColor(FLinearColor A, FLinearColor B);

		// Token: 0x0600A86F RID: 43119
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_IntInt(int A, int B);

		// Token: 0x0600A870 RID: 43120
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_Int64Int64(long A, long B);

		// Token: 0x0600A871 RID: 43121
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_FloatFloat(float A, float B);

		// Token: 0x0600A872 RID: 43122 RVA: 0x000EF3E1 File Offset: 0x000ED5E1
		public static bool EqualEqual_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			return UKismetMathLibrary.__EqualEqual_DateTimeDateTime_Internal((A ?? new FDateTime()).NativePtr, (B ?? new FDateTime()).NativePtr);
		}

		// Token: 0x0600A873 RID: 43123
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_ClassClass(UClassStackOnlyPtr A, UClassStackOnlyPtr B);

		// Token: 0x0600A874 RID: 43124
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_ByteByte(byte A, byte B);

		// Token: 0x0600A875 RID: 43125
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool EqualEqual_BoolBool(bool A, bool B);

		// Token: 0x0600A876 RID: 43126
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Equal_IntPointIntPoint(FIntPoint A, FIntPoint B);

		// Token: 0x0600A877 RID: 43127
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Ease(float A, float B, float Alpha, EEasingFunc EasingFunc, float BlendExp = 2f, int Steps = 2);

		// Token: 0x0600A878 RID: 43128
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector DynamicWeightedMovingAverage_FVector(FVector CurrentSample, FVector PreviousSample, float MaxDistance, float MinWeight, float MaxWeight);

		// Token: 0x0600A879 RID: 43129
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator DynamicWeightedMovingAverage_FRotator(FRotator CurrentSample, FRotator PreviousSample, float MaxDistance, float MinWeight, float MaxWeight);

		// Token: 0x0600A87A RID: 43130
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float DynamicWeightedMovingAverage_Float(float CurrentSample, float PreviousSample, float MaxDistance, float MinWeight, float MaxWeight);

		// Token: 0x0600A87B RID: 43131
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float DotProduct2D(FVector2D A, FVector2D B);

		// Token: 0x0600A87C RID: 43132
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Dot_VectorVector(FVector A, FVector B);

		// Token: 0x0600A87D RID: 43133
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Divide_VectorVector(FVector A, FVector? B = null);

		// Token: 0x0600A87E RID: 43134
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Divide_VectorInt(FVector A, int B = 1);

		// Token: 0x0600A87F RID: 43135
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Divide_VectorFloat(FVector A, float B = 1f);

		// Token: 0x0600A880 RID: 43136 RVA: 0x000EF408 File Offset: 0x000ED608
		public unsafe static FVector4 Divide_Vector4Vector4(in FVector4 A, in FVector4 B)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Divide_Vector4Vector4_Internal(ptr, ptr2);
		}

		// Token: 0x0600A881 RID: 43137
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Divide_Vector2DVector2D(FVector2D A, FVector2D B);

		// Token: 0x0600A882 RID: 43138
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Divide_Vector2DFloat(FVector2D A, float B = 1f);

		// Token: 0x0600A883 RID: 43139 RVA: 0x000EF454 File Offset: 0x000ED654
		[NullableContext(1)]
		public static FTimespan Divide_TimespanFloat([Nullable(2)] FTimespan A, float Scalar)
		{
			return new FTimespan(UKismetMathLibrary.__Divide_TimespanFloat_Internal((A ?? new FTimespan()).NativePtr, Scalar), null);
		}

		// Token: 0x0600A884 RID: 43140
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor Divide_LinearColorLinearColor(FLinearColor A, FLinearColor B);

		// Token: 0x0600A885 RID: 43141
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint Divide_IntPointIntPoint(FIntPoint A, FIntPoint B);

		// Token: 0x0600A886 RID: 43142
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint Divide_IntPointInt(FIntPoint A, int B);

		// Token: 0x0600A887 RID: 43143
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Divide_IntInt(int A, int B = 1);

		// Token: 0x0600A888 RID: 43144
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Divide_Int64Int64(long A, long B = 1L);

		// Token: 0x0600A889 RID: 43145 RVA: 0x000EF474 File Offset: 0x000ED674
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static float Divide_FloatFloat(float A, float B = 1f)
		{
			UKismetMathLibrary.__Divide_FloatFloat_FunctionParams* ptr = stackalloc UKismetMathLibrary.__Divide_FloatFloat_FunctionParams[(UIntPtr)27] + 15L / (long)sizeof(UKismetMathLibrary.__Divide_FloatFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetMathLibrary.__Divide_FloatFloat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->A = A;
			ptr->B = B;
			UnrealReflectionUtils.CallUFunction(UKismetMathLibrary._ClassDefaultObjectPtr, UKismetMathLibrary.__Divide_FloatFloat_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0600A88A RID: 43146
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte Divide_ByteByte(byte A, byte B = 1);

		// Token: 0x0600A88B RID: 43147
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float DistanceSquared2D(FVector2D V1, FVector2D V2);

		// Token: 0x0600A88C RID: 43148
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Distance2D(FVector2D V1, FVector2D V2);

		// Token: 0x0600A88D RID: 43149
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float DegTan(float A);

		// Token: 0x0600A88E RID: 43150
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float DegSin(float A);

		// Token: 0x0600A88F RID: 43151
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float DegreesToRadians(float A);

		// Token: 0x0600A890 RID: 43152
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float DegCos(float A);

		// Token: 0x0600A891 RID: 43153
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float DegAtan2(float Y, float X);

		// Token: 0x0600A892 RID: 43154
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float DegAtan(float A);

		// Token: 0x0600A893 RID: 43155
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float DegAsin(float A);

		// Token: 0x0600A894 RID: 43156
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float DegAcos(float A);

		// Token: 0x0600A895 RID: 43157
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int DaysInYear(int Year);

		// Token: 0x0600A896 RID: 43158
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int DaysInMonth(int Year, int Month);

		// Token: 0x0600A897 RID: 43159 RVA: 0x000EF4C7 File Offset: 0x000ED6C7
		[NullableContext(1)]
		public static FDateTime DateTimeMinValue()
		{
			return new FDateTime(UKismetMathLibrary.__DateTimeMinValue_Internal(), null);
		}

		// Token: 0x0600A898 RID: 43160 RVA: 0x000EF4D4 File Offset: 0x000ED6D4
		[NullableContext(1)]
		public static FDateTime DateTimeMaxValue()
		{
			return new FDateTime(UKismetMathLibrary.__DateTimeMaxValue_Internal(), null);
		}

		// Token: 0x0600A899 RID: 43161 RVA: 0x000EF4E4 File Offset: 0x000ED6E4
		[NullableContext(1)]
		public unsafe static bool DateTimeFromString(string DateTimeString, [Nullable(2)] ref FDateTime Result)
		{
			FString fstring = FString.AllocTemp(DateTimeString);
			bool result = UKismetMathLibrary.__DateTimeFromString_Internal(fstring, (Result ?? new FDateTime()).NativePtr);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600A89A RID: 43162 RVA: 0x000EF518 File Offset: 0x000ED718
		[NullableContext(1)]
		public unsafe static bool DateTimeFromIsoString(string IsoString, [Nullable(2)] ref FDateTime Result)
		{
			FString fstring = FString.AllocTemp(IsoString);
			bool result = UKismetMathLibrary.__DateTimeFromIsoString_Internal(fstring, (Result ?? new FDateTime()).NativePtr);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600A89B RID: 43163
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_VSizeXYSquared(FVectorDouble A);

		// Token: 0x0600A89C RID: 43164
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_VSizeXY(FVectorDouble A);

		// Token: 0x0600A89D RID: 43165
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_VSizeSquared(FVectorDouble A);

		// Token: 0x0600A89E RID: 43166
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_VSize2DSquared(FVector2DDouble A);

		// Token: 0x0600A89F RID: 43167
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_VSize2D(FVector2DDouble A);

		// Token: 0x0600A8A0 RID: 43168
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_VSize(FVectorDouble A);

		// Token: 0x0600A8A1 RID: 43169
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_VLerp(FVectorDouble A, FVectorDouble B, double Alpha);

		// Token: 0x0600A8A2 RID: 43170
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_VInterpTo_Constant(FVectorDouble Current, FVectorDouble Target, float DeltaTime, float InterpSpeed);

		// Token: 0x0600A8A3 RID: 43171
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_VInterpTo(FVectorDouble Current, FVectorDouble Target, float DeltaTime, float InterpSpeed);

		// Token: 0x0600A8A4 RID: 43172
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_Zero();

		// Token: 0x0600A8A5 RID: 43173
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_Up();

		// Token: 0x0600A8A6 RID: 43174
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_Right();

		// Token: 0x0600A8A7 RID: 43175
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_One();

		// Token: 0x0600A8A8 RID: 43176
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_Normal2D(FVectorDouble A, double Tolerance = 0.0001);

		// Token: 0x0600A8A9 RID: 43177
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_Left();

		// Token: 0x0600A8AA RID: 43178
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_Vector_IsZero(in FVectorDouble A);

		// Token: 0x0600A8AB RID: 43179
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Vector_HeadingAngle(FVectorDouble A);

		// Token: 0x0600A8AC RID: 43180
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_GetSignVector(FVectorDouble A);

		// Token: 0x0600A8AD RID: 43181
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Vector_GetAbsMin(FVectorDouble A);

		// Token: 0x0600A8AE RID: 43182
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Vector_GetAbsMax(FVectorDouble A);

		// Token: 0x0600A8AF RID: 43183
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_GetAbs(FVectorDouble A);

		// Token: 0x0600A8B0 RID: 43184
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_Forward();

		// Token: 0x0600A8B1 RID: 43185
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_Down();

		// Token: 0x0600A8B2 RID: 43186
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Vector_DistanceSquared(FVectorDouble V1, FVectorDouble V2);

		// Token: 0x0600A8B3 RID: 43187
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Vector_Distance2D(FVectorDouble V1, FVectorDouble V2);

		// Token: 0x0600A8B4 RID: 43188
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Vector_Distance(FVectorDouble V1, FVectorDouble V2);

		// Token: 0x0600A8B5 RID: 43189
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Vector_CosineAngle2D(FVectorDouble A, FVectorDouble B);

		// Token: 0x0600A8B6 RID: 43190
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_ClampSizeMax(FVectorDouble A, double Max);

		// Token: 0x0600A8B7 RID: 43191
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Vector_Backward();

		// Token: 0x0600A8B8 RID: 43192
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Vector2DInterpTo_Constant(FVector2DDouble Current, FVector2DDouble Target, float DeltaTime, float InterpSpeed);

		// Token: 0x0600A8B9 RID: 43193
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Vector2DInterpTo(FVector2DDouble Current, FVector2DDouble Target, float DeltaTime, float InterpSpeed);

		// Token: 0x0600A8BA RID: 43194 RVA: 0x000EF54C File Offset: 0x000ED74C
		public unsafe static FRotator D_TransformRotation(in FTransformDouble T, FRotator Rotation)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__D_TransformRotation_Internal(uintPtr, Rotation);
		}

		// Token: 0x0600A8BB RID: 43195 RVA: 0x000EF57C File Offset: 0x000ED77C
		public unsafe static FVectorDouble D_TransformLocation(in FTransformDouble T, FVectorDouble Location)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__D_TransformLocation_Internal(uintPtr, Location);
		}

		// Token: 0x0600A8BC RID: 43196 RVA: 0x000EF5AC File Offset: 0x000ED7AC
		public unsafe static FVectorDouble D_TransformDirection(in FTransformDouble T, FVectorDouble Direction)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__D_TransformDirection_Internal(uintPtr, Direction);
		}

		// Token: 0x0600A8BD RID: 43197
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_ToSign2D(FVector2DDouble A);

		// Token: 0x0600A8BE RID: 43198
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_ToRounded2D(FVector2DDouble A);

		// Token: 0x0600A8BF RID: 43199
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void D_ToDirectionAndLength2D(FVector2DDouble A, ref FVector2DDouble OutDir, ref double OutLength);

		// Token: 0x0600A8C0 RID: 43200 RVA: 0x000EF5DC File Offset: 0x000ED7DC
		public unsafe static FTransformDouble D_TLerp(in FTransformDouble A, in FTransformDouble B, float Alpha, ELerpInterpolationMode InterpMode = ELerpInterpolationMode.QuatInterp)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FTransformDouble ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__D_TLerp_Internal(ptr, ptr2, Alpha, InterpMode);
		}

		// Token: 0x0600A8C1 RID: 43201 RVA: 0x000EF630 File Offset: 0x000ED830
		public unsafe static FTransformDouble D_TInterpTo(in FTransformDouble Current, in FTransformDouble Target, float DeltaTime, float InterpSpeed)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = Current;
			ref FTransformDouble ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr2 = Target;
			return UKismetMathLibrary.__D_TInterpTo_Internal(ptr, ptr2, DeltaTime, InterpSpeed);
		}

		// Token: 0x0600A8C2 RID: 43202
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Tan(double A);

		// Token: 0x0600A8C3 RID: 43203
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Subtract_VectorVector(FVectorDouble A, FVectorDouble B);

		// Token: 0x0600A8C4 RID: 43204
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Subtract_VectorFloat(FVectorDouble A, double B);

		// Token: 0x0600A8C5 RID: 43205
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Subtract_Vector2DVector2D(FVector2DDouble A, FVector2DDouble B);

		// Token: 0x0600A8C6 RID: 43206
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Subtract_Vector2DFloat(FVector2DDouble A, double B);

		// Token: 0x0600A8C7 RID: 43207
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Subtract_FloatFloat(double A, double B = 1.0);

		// Token: 0x0600A8C8 RID: 43208
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Square(double A);

		// Token: 0x0600A8C9 RID: 43209
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Sqrt(double A);

		// Token: 0x0600A8CA RID: 43210
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Spherical2DToUnitCartesian(FVector2DDouble A);

		// Token: 0x0600A8CB RID: 43211
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Sin(double A);

		// Token: 0x0600A8CC RID: 43212
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_SignOfFloat(double A);

		// Token: 0x0600A8CD RID: 43213
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void D_Set2D(ref FVector2DDouble A, double X, double Y);

		// Token: 0x0600A8CE RID: 43214
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_SelectVector(FVectorDouble A, FVectorDouble B, bool bPickA);

		// Token: 0x0600A8CF RID: 43215
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_SafeDivide(double A, double B);

		// Token: 0x0600A8D0 RID: 43216
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long D_Round64(double A);

		// Token: 0x0600A8D1 RID: 43217
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int D_Round(double A);

		// Token: 0x0600A8D2 RID: 43218
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_RotatorFromAxisAndAngle(FVectorDouble Axis, float Angle);

		// Token: 0x0600A8D3 RID: 43219
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_RotateAngleAxis(FVectorDouble InVect, float AngleDeg, FVectorDouble Axis);

		// Token: 0x0600A8D4 RID: 43220
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_RandomPointInBoundingBox(FVectorDouble Origin, FVectorDouble BoxExtent);

		// Token: 0x0600A8D5 RID: 43221
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_RandomFloatInRange(double Min, double Max);

		// Token: 0x0600A8D6 RID: 43222
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_RandomFloat();

		// Token: 0x0600A8D7 RID: 43223
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_RandomBoolWithWeight(double Weight);

		// Token: 0x0600A8D8 RID: 43224
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_RadiansToDegrees(double A);

		// Token: 0x0600A8D9 RID: 43225
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_ProjectVectorOnToVector(FVectorDouble V, FVectorDouble Target);

		// Token: 0x0600A8DA RID: 43226
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_ProjectVectorOnToPlane(FVectorDouble V, FVectorDouble PlaneNormal);

		// Token: 0x0600A8DB RID: 43227
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_ProjectPointOnToPlane(FVectorDouble Point, FVectorDouble PlaneBase, FVectorDouble PlaneNormal);

		// Token: 0x0600A8DC RID: 43228 RVA: 0x000EF680 File Offset: 0x000ED880
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static double D_Percent_FloatFloat(double A, double B = 1.0)
		{
			UKismetMathLibrary.__D_Percent_FloatFloat_FunctionParams* ptr = stackalloc UKismetMathLibrary.__D_Percent_FloatFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKismetMathLibrary.__D_Percent_FloatFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetMathLibrary.__D_Percent_FloatFloat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->A = A;
			ptr->B = B;
			UnrealReflectionUtils.CallUFunction(UKismetMathLibrary._ClassDefaultObjectPtr, UKismetMathLibrary.__D_Percent_FloatFloat_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0600A8DD RID: 43229
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_NotEqualExactly_VectorVector(FVectorDouble A, FVectorDouble B);

		// Token: 0x0600A8DE RID: 43230
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_NotEqualExactly_Vector2DVector2D(FVector2DDouble A, FVector2DDouble B);

		// Token: 0x0600A8DF RID: 43231
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_NotEqual_VectorVector(FVectorDouble A, FVectorDouble B, float ErrorTolerance = 0.0001f);

		// Token: 0x0600A8E0 RID: 43232
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_NotEqual_Vector2DVector2D(FVector2DDouble A, FVector2DDouble B, double ErrorTolerance = 0.0001);

		// Token: 0x0600A8E1 RID: 43233
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_NotEqual_FloatFloat(double A, double B);

		// Token: 0x0600A8E2 RID: 43234
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_NormalSafe2D(FVector2DDouble A, double Tolerance = 0.0);

		// Token: 0x0600A8E3 RID: 43235
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_NormalizeToRange(double Value, double RangeMin, double RangeMax);

		// Token: 0x0600A8E4 RID: 43236
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void D_Normalize2D(ref FVector2DDouble A, double Tolerance = 0.0);

		// Token: 0x0600A8E5 RID: 43237
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Normal2D(FVector2DDouble A);

		// Token: 0x0600A8E6 RID: 43238
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Normal(FVectorDouble A, double Tolerance = 0.0001);

		// Token: 0x0600A8E7 RID: 43239
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_NegateVector(FVectorDouble A);

		// Token: 0x0600A8E8 RID: 43240
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Negated2D(in FVector2DDouble A);

		// Token: 0x0600A8E9 RID: 43241
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_NearlyEqual_FloatFloat(double A, double B, double ErrorTolerance = 1E-06);

		// Token: 0x0600A8EA RID: 43242
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_MultiplyMultiply_FloatFloat(double Base, double Exp);

		// Token: 0x0600A8EB RID: 43243
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_MultiplyByPi(double Value);

		// Token: 0x0600A8EC RID: 43244
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Multiply_VectorVector(FVectorDouble A, FVectorDouble B);

		// Token: 0x0600A8ED RID: 43245
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Multiply_VectorInt(FVectorDouble A, int B);

		// Token: 0x0600A8EE RID: 43246
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Multiply_VectorFloat(FVectorDouble A, double B);

		// Token: 0x0600A8EF RID: 43247
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Multiply_Vector2DVector2D(FVector2DDouble A, FVector2DDouble B);

		// Token: 0x0600A8F0 RID: 43248
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Multiply_Vector2DFloat(FVector2DDouble A, double B);

		// Token: 0x0600A8F1 RID: 43249
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Multiply_IntFloat(int A, double B);

		// Token: 0x0600A8F2 RID: 43250
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Multiply_FloatFloat(double A, double B);

		// Token: 0x0600A8F3 RID: 43251 RVA: 0x000EF6D4 File Offset: 0x000ED8D4
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

		// Token: 0x0600A8F4 RID: 43252 RVA: 0x000EF708 File Offset: 0x000ED908
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

		// Token: 0x0600A8F5 RID: 43253
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_MapRangeUnclamped(double Value, double InRangeA, double InRangeB, double OutRangeA, double OutRangeB);

		// Token: 0x0600A8F6 RID: 43254
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_MapRangeClamped(double Value, double InRangeA, double InRangeB, double OutRangeA, double OutRangeB);

		// Token: 0x0600A8F7 RID: 43255
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_MakeRotFromZY(in FVectorDouble Z, in FVectorDouble Y);

		// Token: 0x0600A8F8 RID: 43256
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_MakeRotFromZX(in FVectorDouble Z, in FVectorDouble X);

		// Token: 0x0600A8F9 RID: 43257
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_MakeRotFromZ(in FVectorDouble Z);

		// Token: 0x0600A8FA RID: 43258
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_MakeRotFromYZ(in FVectorDouble Y, in FVectorDouble Z);

		// Token: 0x0600A8FB RID: 43259
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_MakeRotFromYX(in FVectorDouble Y, in FVectorDouble X);

		// Token: 0x0600A8FC RID: 43260
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_MakeRotFromY(in FVectorDouble Y);

		// Token: 0x0600A8FD RID: 43261
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_MakeRotFromXZ(in FVectorDouble X, in FVectorDouble Z);

		// Token: 0x0600A8FE RID: 43262
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_MakeRotFromXY(in FVectorDouble X, in FVectorDouble Y);

		// Token: 0x0600A8FF RID: 43263
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_MakeRotFromX(in FVectorDouble X);

		// Token: 0x0600A900 RID: 43264
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_MakeRotationFromAxes(FVectorDouble Forward, FVectorDouble Right, FVectorDouble Up);

		// Token: 0x0600A901 RID: 43265 RVA: 0x000EF73C File Offset: 0x000ED93C
		public unsafe static FTransformDouble D_MakeRelativeTransform(in FTransformDouble A, in FTransformDouble RelativeTo)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FTransformDouble ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr2 = RelativeTo;
			return UKismetMathLibrary.__D_MakeRelativeTransform_Internal(ptr, ptr2);
		}

		// Token: 0x0600A902 RID: 43266
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_MakePulsatingValue(double InCurrentTime, double InPulsesPerSecond = 1.0, double InPhase = 0.0);

		// Token: 0x0600A903 RID: 43267
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Loge(double A);

		// Token: 0x0600A904 RID: 43268
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Log(double A, double Base = 1.0);

		// Token: 0x0600A905 RID: 43269
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_LessEqual_FloatFloat(double A, double B);

		// Token: 0x0600A906 RID: 43270
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_Less_FloatFloat(double A, double B);

		// Token: 0x0600A907 RID: 43271
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Lerp(double A, double B, double Alpha);

		// Token: 0x0600A908 RID: 43272
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_IsZero2D(in FVector2DDouble A);

		// Token: 0x0600A909 RID: 43273
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_IsNearlyZero2D(in FVector2DDouble A, double Tolerance = 0.0001);

		// Token: 0x0600A90A RID: 43274 RVA: 0x000EF788 File Offset: 0x000ED988
		public unsafe static FTransformDouble D_InvertTransform(in FTransformDouble T)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__D_InvertTransform_Internal(uintPtr);
		}

		// Token: 0x0600A90B RID: 43275 RVA: 0x000EF7B8 File Offset: 0x000ED9B8
		public unsafe static FRotator D_InverseTransformRotation(in FTransformDouble T, FRotator Rotation)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__D_InverseTransformRotation_Internal(uintPtr, Rotation);
		}

		// Token: 0x0600A90C RID: 43276 RVA: 0x000EF7E8 File Offset: 0x000ED9E8
		public unsafe static FVectorDouble D_InverseTransformLocation(in FTransformDouble T, FVectorDouble Location)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__D_InverseTransformLocation_Internal(uintPtr, Location);
		}

		// Token: 0x0600A90D RID: 43277 RVA: 0x000EF818 File Offset: 0x000EDA18
		public unsafe static FVectorDouble D_InverseTransformDirection(in FTransformDouble T, FVectorDouble Direction)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = T;
			return UKismetMathLibrary.__D_InverseTransformDirection_Internal(uintPtr, Direction);
		}

		// Token: 0x0600A90E RID: 43278
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_InRange_FloatFloat(double Value, double Min, double Max, bool InclusiveMin = true, bool InclusiveMax = true);

		// Token: 0x0600A90F RID: 43279
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Hypotenuse(double Width, double Height);

		// Token: 0x0600A910 RID: 43280
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_GridSnap_Float(double Location, double GridSize);

		// Token: 0x0600A911 RID: 43281
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_GreaterGreater_VectorRotator(FVectorDouble A, FRotator B);

		// Token: 0x0600A912 RID: 43282
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_GreaterEqual_FloatFloat(double A, double B);

		// Token: 0x0600A913 RID: 43283
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_Greater_FloatFloat(double A, double B);

		// Token: 0x0600A914 RID: 43284 RVA: 0x000EF846 File Offset: 0x000EDA46
		public static FVectorDouble D_GetVectorArrayAverage(in TArray<FVectorDouble> Vectors)
		{
			return UKismetMathLibrary.__D_GetVectorArrayAverage_Internal((Vectors ?? new TArray<FVectorDouble>()).NativePtr);
		}

		// Token: 0x0600A915 RID: 43285
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_GetUpVector(FRotator InRot);

		// Token: 0x0600A916 RID: 43286
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_GetTAU();

		// Token: 0x0600A917 RID: 43287
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_GetRotated2D(FVector2DDouble A, double AngleDeg);

		// Token: 0x0600A918 RID: 43288
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_GetRightVector(FRotator InRot);

		// Token: 0x0600A919 RID: 43289
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_GetPI();

		// Token: 0x0600A91A RID: 43290
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_GetMinElement(FVectorDouble A);

		// Token: 0x0600A91B RID: 43291
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_GetMin2D(FVector2DDouble A);

		// Token: 0x0600A91C RID: 43292
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_GetMaxElement(FVectorDouble A);

		// Token: 0x0600A91D RID: 43293
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_GetMax2D(FVector2DDouble A);

		// Token: 0x0600A91E RID: 43294
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_GetForwardVector(FRotator InRot);

		// Token: 0x0600A91F RID: 43295
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_GetDirectionUnitVector(FVectorDouble From, FVectorDouble To);

		// Token: 0x0600A920 RID: 43296
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_GetAbsMax2D(FVector2DDouble A);

		// Token: 0x0600A921 RID: 43297
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_GetAbs2D(FVector2DDouble A);

		// Token: 0x0600A922 RID: 43298
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_FWrap(double Value, double Min, double Max);

		// Token: 0x0600A923 RID: 43299
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntVector D_FTruncVector(in FVectorDouble InVector);

		// Token: 0x0600A924 RID: 43300
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long D_FTrunc64(double A);

		// Token: 0x0600A925 RID: 43301
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int D_FTrunc(double A);

		// Token: 0x0600A926 RID: 43302
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Fraction(double A);

		// Token: 0x0600A927 RID: 43303
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int D_FMod(double Dividend, double Divisor, ref double Remainder);

		// Token: 0x0600A928 RID: 43304
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_FMin(double A, double B);

		// Token: 0x0600A929 RID: 43305
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_FMax(double A, double B);

		// Token: 0x0600A92A RID: 43306
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_FixedTurn(double InCurrent, double InDesired, double InDeltaRate);

		// Token: 0x0600A92B RID: 43307
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_FInterpTo_Constant(double Current, double Target, float DeltaTime, float InterpSpeed);

		// Token: 0x0600A92C RID: 43308
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_FInterpTo(double Current, double Target, float DeltaTime, float InterpSpeed);

		// Token: 0x0600A92D RID: 43309
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_FInterpEaseInOut(double A, double B, double Alpha, double Exponent);

		// Token: 0x0600A92E RID: 43310
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator D_FindLookAtRotation(in FVectorDouble Start, in FVectorDouble Target);

		// Token: 0x0600A92F RID: 43311
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_FindClosestPointOnSegment(FVectorDouble Point, FVectorDouble SegmentStart, FVectorDouble SegmentEnd);

		// Token: 0x0600A930 RID: 43312
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_FindClosestPointOnLine(FVectorDouble Point, FVectorDouble LineOrigin, FVectorDouble LineDirection);

		// Token: 0x0600A931 RID: 43313
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long D_FFloor64(double A);

		// Token: 0x0600A932 RID: 43314
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int D_FFloor(double A);

		// Token: 0x0600A933 RID: 43315
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_FClamp(double Value, double Min, double Max);

		// Token: 0x0600A934 RID: 43316
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long D_FCeil64(double A);

		// Token: 0x0600A935 RID: 43317
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int D_FCeil(double A);

		// Token: 0x0600A936 RID: 43318
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Exp(double A);

		// Token: 0x0600A937 RID: 43319
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_EqualExactly_VectorVector(FVectorDouble A, FVectorDouble B);

		// Token: 0x0600A938 RID: 43320
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_EqualExactly_Vector2DVector2D(FVector2DDouble A, FVector2DDouble B);

		// Token: 0x0600A939 RID: 43321
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_EqualEqual_VectorVector(FVectorDouble A, FVectorDouble B, double ErrorTolerance = 0.0001);

		// Token: 0x0600A93A RID: 43322
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_EqualEqual_Vector2DVector2D(FVector2DDouble A, FVector2DDouble B, double ErrorTolerance = 0.0001);

		// Token: 0x0600A93B RID: 43323
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool D_EqualEqual_FloatFloat(double A, double B);

		// Token: 0x0600A93C RID: 43324
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Ease(double A, double B, double Alpha, EEasingFunc EasingFunc, double BlendExp = 2.0, int Steps = 2);

		// Token: 0x0600A93D RID: 43325
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_DotProduct2D(FVector2DDouble A, FVector2DDouble B);

		// Token: 0x0600A93E RID: 43326
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Dot_VectorVector(FVectorDouble A, FVectorDouble B);

		// Token: 0x0600A93F RID: 43327
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Divide_VectorVector(FVectorDouble A, FVectorDouble? B = null);

		// Token: 0x0600A940 RID: 43328
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Divide_VectorFloat(FVectorDouble A, double B = 1.0);

		// Token: 0x0600A941 RID: 43329
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Divide_Vector2DVector2D(FVector2DDouble A, FVector2DDouble B);

		// Token: 0x0600A942 RID: 43330
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Divide_Vector2DFloat(FVector2DDouble A, double B = 1.0);

		// Token: 0x0600A943 RID: 43331 RVA: 0x000EF860 File Offset: 0x000EDA60
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe static double D_Divide_FloatFloat(double A, double B = 1.0)
		{
			UKismetMathLibrary.__D_Divide_FloatFloat_FunctionParams* ptr = stackalloc UKismetMathLibrary.__D_Divide_FloatFloat_FunctionParams[(UIntPtr)39] + 15L / (long)sizeof(UKismetMathLibrary.__D_Divide_FloatFloat_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKismetMathLibrary.__D_Divide_FloatFloat_NativeFunctionPtr, (void*)ptr, 1);
			ptr->A = A;
			ptr->B = B;
			UnrealReflectionUtils.CallUFunction(UKismetMathLibrary._ClassDefaultObjectPtr, UKismetMathLibrary.__D_Divide_FloatFloat_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0600A944 RID: 43332
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_DistanceSquared2D(FVector2DDouble V1, FVector2DDouble V2);

		// Token: 0x0600A945 RID: 43333
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Distance2D(FVector2DDouble V1, FVector2DDouble V2);

		// Token: 0x0600A946 RID: 43334
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_DegTan(double A);

		// Token: 0x0600A947 RID: 43335
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_DegSin(double A);

		// Token: 0x0600A948 RID: 43336
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_DegreesToRadians(double A);

		// Token: 0x0600A949 RID: 43337
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_DegCos(double A);

		// Token: 0x0600A94A RID: 43338
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_DegAtan2(double Y, double X);

		// Token: 0x0600A94B RID: 43339
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_DegAtan(double A);

		// Token: 0x0600A94C RID: 43340
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_DegAsin(double A);

		// Token: 0x0600A94D RID: 43341
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_DegAcos(double A);

		// Token: 0x0600A94E RID: 43342
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_CrossProduct2D(FVector2DDouble A, FVector2DDouble B);

		// Token: 0x0600A94F RID: 43343
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Cross_VectorVector(FVectorDouble A, FVectorDouble B);

		// Token: 0x0600A950 RID: 43344
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Cos(double A);

		// Token: 0x0600A951 RID: 43345
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Conv_VectorToVector2D(FVectorDouble InVector);

		// Token: 0x0600A952 RID: 43346
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FTransformDouble D_Conv_VectorToTransform(FVectorDouble InLocation);

		// Token: 0x0600A953 RID: 43347
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Conv_Vector2DToVector(FVector2DDouble InVector2D, double Z = 0.0);

		// Token: 0x0600A954 RID: 43348
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint D_Conv_Vector2DToIntPoint(FVector2DDouble InVector2D);

		// Token: 0x0600A955 RID: 43349
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Conv_IntToFloat(int InInt);

		// Token: 0x0600A956 RID: 43350
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Conv_FloatToVector(double InFloat);

		// Token: 0x0600A957 RID: 43351 RVA: 0x000EF8B4 File Offset: 0x000EDAB4
		public unsafe static FTransformDouble D_ComposeTransforms(in FTransformDouble A, in FTransformDouble B)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FTransformDouble ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__D_ComposeTransforms_Internal(ptr, ptr2);
		}

		// Token: 0x0600A958 RID: 43352
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_ClampVectorSize(FVectorDouble A, double Min, double Max);

		// Token: 0x0600A959 RID: 43353
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_ClampAxes2D(FVector2DDouble A, double MinAxisVal, double MaxAxisVal);

		// Token: 0x0600A95A RID: 43354
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_ClampAngle(double AngleDegrees, double MinAngleDegrees, double MaxAngleDegrees);

		// Token: 0x0600A95B RID: 43355
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Atan2(double Y, double X);

		// Token: 0x0600A95C RID: 43356
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Atan(double A);

		// Token: 0x0600A95D RID: 43357
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Asin(double A);

		// Token: 0x0600A95E RID: 43358
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Add_VectorVector(FVectorDouble A, FVectorDouble B);

		// Token: 0x0600A95F RID: 43359
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble D_Add_VectorFloat(FVectorDouble A, double B);

		// Token: 0x0600A960 RID: 43360
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Add_Vector2DVector2D(FVector2DDouble A, FVector2DDouble B);

		// Token: 0x0600A961 RID: 43361
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2DDouble D_Add_Vector2DFloat(FVector2DDouble A, double B);

		// Token: 0x0600A962 RID: 43362
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Add_FloatFloat(double A, double B = 1.0);

		// Token: 0x0600A963 RID: 43363
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Acos(double A);

		// Token: 0x0600A964 RID: 43364
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double D_Abs(double A);

		// Token: 0x0600A965 RID: 43365
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float CrossProduct2D(FVector2D A, FVector2D B);

		// Token: 0x0600A966 RID: 43366
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Cross_VectorVector(FVector A, FVector B);

		// Token: 0x0600A967 RID: 43367
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector CreateVectorFromYawPitch(float Yaw, float Pitch, float Length = 1f);

		// Token: 0x0600A968 RID: 43368
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Cos(float A);

		// Token: 0x0600A969 RID: 43369 RVA: 0x000EF900 File Offset: 0x000EDB00
		public unsafe static FTransform ConvertTransformToRelative(in FTransform Transform, in FTransform ParentTransform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = ParentTransform;
			return UKismetMathLibrary.__ConvertTransformToRelative_Internal(ptr, ptr2);
		}

		// Token: 0x0600A96A RID: 43370
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble Conv_VectorToVectorDouble(FVector InVec);

		// Token: 0x0600A96B RID: 43371
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Conv_VectorToVector2D(FVector InVector);

		// Token: 0x0600A96C RID: 43372
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FTransform Conv_VectorToTransform(FVector InLocation);

		// Token: 0x0600A96D RID: 43373
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator Conv_VectorToRotator(FVector InVec);

		// Token: 0x0600A96E RID: 43374
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FQuat Conv_VectorToQuaternion(FVector InVec);

		// Token: 0x0600A96F RID: 43375
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor Conv_VectorToLinearColor(FVector InVec);

		// Token: 0x0600A970 RID: 43376
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Conv_VectorDoubleToVector(FVectorDouble InVec);

		// Token: 0x0600A971 RID: 43377
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator Conv_VectorDoubleToRotator(FVectorDouble InVec);

		// Token: 0x0600A972 RID: 43378
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor Conv_VectorDoubleToLinearColor(FVectorDouble InVec);

		// Token: 0x0600A973 RID: 43379 RVA: 0x000EF94C File Offset: 0x000EDB4C
		public unsafe static FVector Conv_Vector4ToVector(in FVector4 InVector4)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = InVector4;
			return UKismetMathLibrary.__Conv_Vector4ToVector_Internal(uintPtr);
		}

		// Token: 0x0600A974 RID: 43380 RVA: 0x000EF97C File Offset: 0x000EDB7C
		public unsafe static FRotator Conv_Vector4ToRotator(in FVector4 InVec)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = InVec;
			return UKismetMathLibrary.__Conv_Vector4ToRotator_Internal(uintPtr);
		}

		// Token: 0x0600A975 RID: 43381 RVA: 0x000EF9AC File Offset: 0x000EDBAC
		public unsafe static FQuat Conv_Vector4ToQuaternion(in FVector4 InVec)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			*uintPtr = InVec;
			return UKismetMathLibrary.__Conv_Vector4ToQuaternion_Internal(uintPtr);
		}

		// Token: 0x0600A976 RID: 43382
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Conv_Vector2DToVector(FVector2D InVector2D, float Z = 0f);

		// Token: 0x0600A977 RID: 43383
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint Conv_Vector2DToIntPoint(FVector2D InVector2D);

		// Token: 0x0600A978 RID: 43384 RVA: 0x000EF9DC File Offset: 0x000EDBDC
		public unsafe static FTransformDouble Conv_TransformToTransformDouble(FTransform InT)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = InT;
			return UKismetMathLibrary.__Conv_TransformToTransformDouble_Internal(uintPtr);
		}

		// Token: 0x0600A979 RID: 43385 RVA: 0x000EFA04 File Offset: 0x000EDC04
		public unsafe static FMatrix Conv_TransformToMatrix(in FTransform Transform)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = Transform;
			return UKismetMathLibrary.__Conv_TransformToMatrix_Internal(uintPtr);
		}

		// Token: 0x0600A97A RID: 43386 RVA: 0x000EFA34 File Offset: 0x000EDC34
		public unsafe static FTransform Conv_TransformDoubleToTransform(FTransformDouble InT)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = InT;
			return UKismetMathLibrary.__Conv_TransformDoubleToTransform_Internal(uintPtr);
		}

		// Token: 0x0600A97B RID: 43387
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Conv_RotatorToVector(FRotator InRot);

		// Token: 0x0600A97C RID: 43388
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FTransform Conv_RotatorToTransform(in FRotator InRotator);

		// Token: 0x0600A97D RID: 43389 RVA: 0x000EFA5C File Offset: 0x000EDC5C
		public unsafe static FTransform Conv_MatrixToTransform(in FMatrix InMatrix)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = InMatrix;
			return UKismetMathLibrary.__Conv_MatrixToTransform_Internal(uintPtr);
		}

		// Token: 0x0600A97E RID: 43390 RVA: 0x000EFA8C File Offset: 0x000EDC8C
		public unsafe static FRotator Conv_MatrixToRotator(in FMatrix InMatrix)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			*uintPtr = InMatrix;
			return UKismetMathLibrary.__Conv_MatrixToRotator_Internal(uintPtr);
		}

		// Token: 0x0600A97F RID: 43391
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Conv_LinearColorToVector(FLinearColor InLinearColor);

		// Token: 0x0600A980 RID: 43392
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FColor Conv_LinearColorToColor(FLinearColor InLinearColor, bool InUseSRGB = true);

		// Token: 0x0600A981 RID: 43393
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Conv_IntVectorToVector(in FIntVector InIntVector);

		// Token: 0x0600A982 RID: 43394
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntVector Conv_IntToIntVector(int InInt);

		// Token: 0x0600A983 RID: 43395
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Conv_IntToInt64(int InInt);

		// Token: 0x0600A984 RID: 43396
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Conv_IntToFloat(int InInt);

		// Token: 0x0600A985 RID: 43397
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte Conv_IntToByte(int InInt);

		// Token: 0x0600A986 RID: 43398
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool Conv_IntToBool(int InInt);

		// Token: 0x0600A987 RID: 43399
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Conv_IntPointToVector2D(FIntPoint InIntPoint);

		// Token: 0x0600A988 RID: 43400
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Conv_Int64ToInt(long InInt);

		// Token: 0x0600A989 RID: 43401
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte Conv_Int64ToByte(long InInt);

		// Token: 0x0600A98A RID: 43402
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Conv_FloatToVector(float InFloat);

		// Token: 0x0600A98B RID: 43403
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor Conv_FloatToLinearColor(float InFloat);

		// Token: 0x0600A98C RID: 43404
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern double Conv_FloatToDouble(float A);

		// Token: 0x0600A98D RID: 43405
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Conv_DoubleToFloat(double A);

		// Token: 0x0600A98E RID: 43406
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor Conv_ColorToLinearColor(FColor InColor);

		// Token: 0x0600A98F RID: 43407
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Conv_ByteToInt(byte InByte);

		// Token: 0x0600A990 RID: 43408
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Conv_ByteToFloat(byte InByte);

		// Token: 0x0600A991 RID: 43409
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Conv_BoolToInt(bool InBool);

		// Token: 0x0600A992 RID: 43410
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Conv_BoolToFloat(bool InBool);

		// Token: 0x0600A993 RID: 43411
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte Conv_BoolToByte(bool InBool);

		// Token: 0x0600A994 RID: 43412 RVA: 0x000EFABC File Offset: 0x000EDCBC
		public unsafe static FTransform ComposeTransforms(in FTransform A, in FTransform B)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__ComposeTransforms_Internal(ptr, ptr2);
		}

		// Token: 0x0600A995 RID: 43413
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator ComposeRotators(FRotator A, FRotator B);

		// Token: 0x0600A996 RID: 43414
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool ClassIsChildOf(UClassStackOnlyPtr TestClass, UClassStackOnlyPtr ParentClass);

		// Token: 0x0600A997 RID: 43415
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector ClampVectorSize(FVector A, float Min, float Max);

		// Token: 0x0600A998 RID: 43416
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long ClampInt64(long Value, long Min, long Max);

		// Token: 0x0600A999 RID: 43417
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float ClampAxis(float Angle);

		// Token: 0x0600A99A RID: 43418
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D ClampAxes2D(FVector2D A, float MinAxisVal, float MaxAxisVal);

		// Token: 0x0600A99B RID: 43419
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float ClampAngle(float AngleDegrees, float MinAngleDegrees, float MaxAngleDegrees);

		// Token: 0x0600A99C RID: 43420
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Clamp(int Value, int Min, int Max);

		// Token: 0x0600A99D RID: 43421
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor CInterpTo(FLinearColor Current, FLinearColor Target, float DeltaTime, float InterpSpeed);

		// Token: 0x0600A99E RID: 43422
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BreakVectorDouble(FVectorDouble InVec, ref double X, ref double Y, ref double Z);

		// Token: 0x0600A99F RID: 43423 RVA: 0x000EFB08 File Offset: 0x000EDD08
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

		// Token: 0x0600A9A0 RID: 43424
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BreakVector2DDouble(FVector2DDouble InVec, ref double X, ref double Y);

		// Token: 0x0600A9A1 RID: 43425
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BreakVector2D(FVector2D InVec, ref float X, ref float Y);

		// Token: 0x0600A9A2 RID: 43426
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BreakVector(FVector InVec, ref float X, ref float Y, ref float Z);

		// Token: 0x0600A9A3 RID: 43427 RVA: 0x000EFB68 File Offset: 0x000EDD68
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

		// Token: 0x0600A9A4 RID: 43428 RVA: 0x000EFBB8 File Offset: 0x000EDDB8
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

		// Token: 0x0600A9A5 RID: 43429 RVA: 0x000EFC08 File Offset: 0x000EDE08
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

		// Token: 0x0600A9A6 RID: 43430 RVA: 0x000EFC6C File Offset: 0x000EDE6C
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

		// Token: 0x0600A9A7 RID: 43431
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BreakRotIntoAxes(in FRotator InRot, ref FVector X, ref FVector Y, ref FVector Z);

		// Token: 0x0600A9A8 RID: 43432
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BreakRotator(FRotator InRot, ref float Roll, ref float Pitch, ref float Yaw);

		// Token: 0x0600A9A9 RID: 43433
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BreakRandomStream(in FRandomStream InRandomStream, ref int InitialSeed);

		// Token: 0x0600A9AA RID: 43434 RVA: 0x000EFCD0 File Offset: 0x000EDED0
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

		// Token: 0x0600A9AB RID: 43435
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BreakFrameRate(in FFrameRate InFrameRate, ref int Numerator, ref int Denominator);

		// Token: 0x0600A9AC RID: 43436 RVA: 0x000EFD14 File Offset: 0x000EDF14
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

		// Token: 0x0600A9AD RID: 43437
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void BreakColor(FLinearColor InColor, ref float R, ref float G, ref float B, ref float A);

		// Token: 0x0600A9AE RID: 43438
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool BooleanXOR(bool A, bool B);

		// Token: 0x0600A9AF RID: 43439
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool BooleanOR(bool A, bool B);

		// Token: 0x0600A9B0 RID: 43440
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool BooleanNOR(bool A, bool B);

		// Token: 0x0600A9B1 RID: 43441
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool BooleanNAND(bool A, bool B);

		// Token: 0x0600A9B2 RID: 43442
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool BooleanAND(bool A, bool B);

		// Token: 0x0600A9B3 RID: 43443
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte BMin(byte A, byte B);

		// Token: 0x0600A9B4 RID: 43444
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte BMax(byte A, byte B);

		// Token: 0x0600A9B5 RID: 43445
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Atan2(float Y, float X);

		// Token: 0x0600A9B6 RID: 43446
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Atan(float A);

		// Token: 0x0600A9B7 RID: 43447
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Asin(float A);

		// Token: 0x0600A9B8 RID: 43448
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int And_IntInt(int A, int B);

		// Token: 0x0600A9B9 RID: 43449
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long And_Int64Int64(long A, long B);

		// Token: 0x0600A9BA RID: 43450
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Add_VectorVector(FVector A, FVector B);

		// Token: 0x0600A9BB RID: 43451
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Add_VectorInt(FVector A, int B);

		// Token: 0x0600A9BC RID: 43452
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector Add_VectorFloat(FVector A, float B);

		// Token: 0x0600A9BD RID: 43453 RVA: 0x000EFD94 File Offset: 0x000EDF94
		public unsafe static FVector4 Add_Vector4Vector4(in FVector4 A, in FVector4 B)
		{
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FVector4 ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Add_Vector4Vector4_Internal(ptr, ptr2);
		}

		// Token: 0x0600A9BE RID: 43454
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Add_Vector2DVector2D(FVector2D A, FVector2D B);

		// Token: 0x0600A9BF RID: 43455
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector2D Add_Vector2DFloat(FVector2D A, float B);

		// Token: 0x0600A9C0 RID: 43456 RVA: 0x000EFDE0 File Offset: 0x000EDFE0
		[return: Nullable(1)]
		public static FTimespan Add_TimespanTimespan(FTimespan A, FTimespan B)
		{
			return new FTimespan(UKismetMathLibrary.__Add_TimespanTimespan_Internal((A ?? new FTimespan()).NativePtr, (B ?? new FTimespan()).NativePtr), null);
		}

		// Token: 0x0600A9C1 RID: 43457 RVA: 0x000EFE0C File Offset: 0x000EE00C
		public unsafe static FQuat Add_QuatQuat(in FQuat A, in FQuat B)
		{
			ref FQuat ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FQuat ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Add_QuatQuat_Internal(ptr, ptr2);
		}

		// Token: 0x0600A9C2 RID: 43458 RVA: 0x000EFE58 File Offset: 0x000EE058
		public unsafe static FMatrix Add_MatrixMatrix(in FMatrix A, in FMatrix B)
		{
			ref FMatrix ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = A;
			ref FMatrix ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr2 = B;
			return UKismetMathLibrary.__Add_MatrixMatrix_Internal(ptr, ptr2);
		}

		// Token: 0x0600A9C3 RID: 43459
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FLinearColor Add_LinearColorLinearColor(FLinearColor A, FLinearColor B);

		// Token: 0x0600A9C4 RID: 43460
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint Add_IntPointIntPoint(FIntPoint A, FIntPoint B);

		// Token: 0x0600A9C5 RID: 43461
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FIntPoint Add_IntPointInt(FIntPoint A, int B);

		// Token: 0x0600A9C6 RID: 43462
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Add_IntInt(int A, int B = 1);

		// Token: 0x0600A9C7 RID: 43463
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Add_Int64Int64(long A, long B = 1L);

		// Token: 0x0600A9C8 RID: 43464
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Add_FloatFloat(float A, float B = 1f);

		// Token: 0x0600A9C9 RID: 43465 RVA: 0x000EFEA4 File Offset: 0x000EE0A4
		[return: Nullable(1)]
		public static FDateTime Add_DateTimeTimespan(FDateTime A, FTimespan B)
		{
			return new FDateTime(UKismetMathLibrary.__Add_DateTimeTimespan_Internal((A ?? new FDateTime()).NativePtr, (B ?? new FTimespan()).NativePtr), null);
		}

		// Token: 0x0600A9CA RID: 43466 RVA: 0x000EFECF File Offset: 0x000EE0CF
		[return: Nullable(1)]
		public static FDateTime Add_DateTimeDateTime(FDateTime A, FDateTime B)
		{
			return new FDateTime(UKismetMathLibrary.__Add_DateTimeDateTime_Internal((A ?? new FDateTime()).NativePtr, (B ?? new FDateTime()).NativePtr), null);
		}

		// Token: 0x0600A9CB RID: 43467
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern byte Add_ByteByte(byte A, byte B = 1);

		// Token: 0x0600A9CC RID: 43468
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Acos(float A);

		// Token: 0x0600A9CD RID: 43469
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern long Abs_Int64(long A);

		// Token: 0x0600A9CE RID: 43470
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int Abs_Int(int A);

		// Token: 0x0600A9CF RID: 43471
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float Abs(float A);

		// Token: 0x0600A9D0 RID: 43472
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __WD_WorldToLocal_Internal(IntPtr WorldContextObject, FVectorDouble InVec);

		// Token: 0x0600A9D1 RID: 43473
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __WD_TransformToTransformDouble_Internal(IntPtr WorldContextObject, in FTransform InT);

		// Token: 0x0600A9D2 RID: 43474
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __WD_TransformDoubleToTransform_Internal(IntPtr WorldContextObject, in FTransformDouble InT);

		// Token: 0x0600A9D3 RID: 43475
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __WD_LocalToWorld_Internal(IntPtr WorldContextObject, FVector InVec);

		// Token: 0x0600A9D4 RID: 43476
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __VectorSpringInterp_Internal(FVector Current, FVector Target, IntPtr SpringState, float Stiffness, float CriticalDampingFactor, float DeltaTime, float Mass);

		// Token: 0x0600A9D5 RID: 43477
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Vector_MirrorByPlane_Internal(FVector A, in FPlane InPlane);

		// Token: 0x0600A9D6 RID: 43478
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Vector4_SizeSquared3_Internal(in FVector4 A);

		// Token: 0x0600A9D7 RID: 43479
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Vector4_SizeSquared_Internal(in FVector4 A);

		// Token: 0x0600A9D8 RID: 43480
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Vector4_Size3_Internal(in FVector4 A);

		// Token: 0x0600A9D9 RID: 43481
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Vector4_Size_Internal(in FVector4 A);

		// Token: 0x0600A9DA RID: 43482
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Vector4_Set_Internal(ref FVector4 A, float X, float Y, float Z, float W);

		// Token: 0x0600A9DB RID: 43483
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Vector4_NormalUnsafe3_Internal(in FVector4 A);

		// Token: 0x0600A9DC RID: 43484
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Vector4_Normalize3_Internal(ref FVector4 A, float Tolerance);

		// Token: 0x0600A9DD RID: 43485
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Vector4_Normal3_Internal(in FVector4 A, float Tolerance);

		// Token: 0x0600A9DE RID: 43486
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Vector4_Negated_Internal(in FVector4 A);

		// Token: 0x0600A9DF RID: 43487
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Vector4_MirrorByVector3_Internal(in FVector4 Direction, in FVector4 SurfaceNormal);

		// Token: 0x0600A9E0 RID: 43488
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Vector4_IsZero_Internal(in FVector4 A);

		// Token: 0x0600A9E1 RID: 43489
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Vector4_IsUnit3_Internal(in FVector4 A, float SquaredLenthTolerance);

		// Token: 0x0600A9E2 RID: 43490
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Vector4_IsNormal3_Internal(in FVector4 A);

		// Token: 0x0600A9E3 RID: 43491
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Vector4_IsNearlyZero3_Internal(in FVector4 A, float Tolerance);

		// Token: 0x0600A9E4 RID: 43492
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Vector4_IsNAN_Internal(in FVector4 A);

		// Token: 0x0600A9E5 RID: 43493
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Vector4_DotProduct3_Internal(in FVector4 A, in FVector4 B);

		// Token: 0x0600A9E6 RID: 43494
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Vector4_DotProduct_Internal(in FVector4 A, in FVector4 B);

		// Token: 0x0600A9E7 RID: 43495
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Vector4_CrossProduct3_Internal(in FVector4 A, in FVector4 B);

		// Token: 0x0600A9E8 RID: 43496
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Vector4_Assign_Internal(ref FVector4 A, in FVector4 InVector);

		// Token: 0x0600A9E9 RID: 43497
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __UtcNow_Internal();

		// Token: 0x0600A9EA RID: 43498
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __TransformVector4_Internal(in FMatrix Matrix, in FVector4 Vec4);

		// Token: 0x0600A9EB RID: 43499
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __TransformRotation_Internal(in FTransform T, FRotator Rotation);

		// Token: 0x0600A9EC RID: 43500
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __TransformLocation_Internal(in FTransform T, FVector Location);

		// Token: 0x0600A9ED RID: 43501
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __TransformDirection_Internal(in FTransform T, FVector Direction);

		// Token: 0x0600A9EE RID: 43502
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Transform_Determinant_Internal(in FTransform Transform);

		// Token: 0x0600A9EF RID: 43503
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Today_Internal();

		// Token: 0x0600A9F0 RID: 43504
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __TLerp_Internal(in FTransform A, in FTransform B, float Alpha, TEnumAsByte<ELerpInterpolationMode> InterpMode);

		// Token: 0x0600A9F1 RID: 43505
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __TInterpTo_Internal(in FTransform Current, in FTransform Target, float DeltaTime, float InterpSpeed);

		// Token: 0x0600A9F2 RID: 43506
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __TimespanZeroValue_Internal();

		// Token: 0x0600A9F3 RID: 43507
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __TimespanRatio_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600A9F4 RID: 43508
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __TimespanMinValue_Internal();

		// Token: 0x0600A9F5 RID: 43509
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __TimespanMaxValue_Internal();

		// Token: 0x0600A9F6 RID: 43510
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TimespanFromString_Internal(in FString TimespanString, IntPtr Result);

		// Token: 0x0600A9F7 RID: 43511
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __TEase_Internal(in FTransform A, in FTransform B, float Alpha, TEnumAsByte<EEasingFunc> EasingFunc, float BlendExp, int Steps);

		// Token: 0x0600A9F8 RID: 43512
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Subtract_Vector4Vector4_Internal(in FVector4 A, in FVector4 B);

		// Token: 0x0600A9F9 RID: 43513
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Subtract_TimespanTimespan_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600A9FA RID: 43514
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __Subtract_QuatQuat_Internal(in FQuat A, in FQuat B);

		// Token: 0x0600A9FB RID: 43515
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Subtract_DateTimeTimespan_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600A9FC RID: 43516
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Subtract_DateTimeDateTime_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600A9FD RID: 43517
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __SelectTransform_Internal(in FTransform A, in FTransform B, bool bPickA);

		// Token: 0x0600A9FE RID: 43518
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __SelectString_Internal(in FString A, in FString B, bool bPickA);

		// Token: 0x0600A9FF RID: 43519
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __SelectObject_Internal(IntPtr A, IntPtr B, bool bSelectA);

		// Token: 0x0600AA00 RID: 43520
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetVectorSpringState_Internal(IntPtr SpringState);

		// Token: 0x0600AA01 RID: 43521
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ResetFloatSpringState_Internal(IntPtr SpringState);

		// Token: 0x0600AA02 RID: 43522
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Quat_VectorUp_Internal(in FQuat Q);

		// Token: 0x0600AA03 RID: 43523
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Quat_VectorRight_Internal(in FQuat Q);

		// Token: 0x0600AA04 RID: 43524
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Quat_VectorForward_Internal(in FQuat Q);

		// Token: 0x0600AA05 RID: 43525
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Quat_UnrotateVector_Internal(in FQuat Q, in FVector V);

		// Token: 0x0600AA06 RID: 43526
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Quat_SizeSquared_Internal(in FQuat Q);

		// Token: 0x0600AA07 RID: 43527
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Quat_Size_Internal(in FQuat Q);

		// Token: 0x0600AA08 RID: 43528
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Quat_SetFromEuler_Internal(ref FQuat Q, in FVector Euler);

		// Token: 0x0600AA09 RID: 43529
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Quat_SetComponents_Internal(ref FQuat Q, float X, float Y, float Z, float W);

		// Token: 0x0600AA0A RID: 43530
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __Quat_Rotator_Internal(in FQuat Q);

		// Token: 0x0600AA0B RID: 43531
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Quat_RotateVector_Internal(in FQuat Q, in FVector V);

		// Token: 0x0600AA0C RID: 43532
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __Quat_Normalized_Internal(in FQuat Q, float Tolerance);

		// Token: 0x0600AA0D RID: 43533
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Quat_Normalize_Internal(ref FQuat Q, float Tolerance);

		// Token: 0x0600AA0E RID: 43534
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __Quat_Log_Internal(in FQuat Q);

		// Token: 0x0600AA0F RID: 43535
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Quat_IsNormalized_Internal(in FQuat Q);

		// Token: 0x0600AA10 RID: 43536
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Quat_IsNonFinite_Internal(in FQuat Q);

		// Token: 0x0600AA11 RID: 43537
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Quat_IsIdentity_Internal(in FQuat Q, float Tolerance);

		// Token: 0x0600AA12 RID: 43538
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Quat_IsFinite_Internal(in FQuat Q);

		// Token: 0x0600AA13 RID: 43539
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __Quat_Inversed_Internal(in FQuat Q);

		// Token: 0x0600AA14 RID: 43540
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Quat_GetRotationAxis_Internal(in FQuat Q);

		// Token: 0x0600AA15 RID: 43541
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Quat_GetAxisZ_Internal(in FQuat Q);

		// Token: 0x0600AA16 RID: 43542
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Quat_GetAxisY_Internal(in FQuat Q);

		// Token: 0x0600AA17 RID: 43543
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Quat_GetAxisX_Internal(in FQuat Q);

		// Token: 0x0600AA18 RID: 43544
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Quat_GetAngle_Internal(in FQuat Q);

		// Token: 0x0600AA19 RID: 43545
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __Quat_Exp_Internal(in FQuat Q);

		// Token: 0x0600AA1A RID: 43546
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Quat_Euler_Internal(in FQuat Q);

		// Token: 0x0600AA1B RID: 43547
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Quat_EnforceShortestArcWith_Internal(ref FQuat A, in FQuat B);

		// Token: 0x0600AA1C RID: 43548
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Quat_AngularDistance_Internal(in FQuat A, in FQuat B);

		// Token: 0x0600AA1D RID: 43549
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PointsAreCoplanar_Internal(IntPtr Points, float Tolerance);

		// Token: 0x0600AA1E RID: 43550
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Now_Internal();

		// Token: 0x0600AA1F RID: 43551
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqualExactly_Vector4Vector4_Internal(in FVector4 A, in FVector4 B);

		// Token: 0x0600AA20 RID: 43552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_Vector4Vector4_Internal(in FVector4 A, in FVector4 B, float ErrorTolerance);

		// Token: 0x0600AA21 RID: 43553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_TimespanTimespan_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AA22 RID: 43554
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_QuatQuat_Internal(in FQuat A, in FQuat B, float ErrorTolerance);

		// Token: 0x0600AA23 RID: 43555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_ObjectObject_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AA24 RID: 43556
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_MatrixMatrix_Internal(in FMatrix A, in FMatrix B, float Tolerance);

		// Token: 0x0600AA25 RID: 43557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NotEqual_DateTimeDateTime_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AA26 RID: 43558
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NearlyEqual_TransformTransform_Internal(in FTransform A, in FTransform B, float LocationTolerance, float RotationTolerance, float Scale3DTolerance);

		// Token: 0x0600AA27 RID: 43559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Multiply_Vector4Vector4_Internal(in FVector4 A, in FVector4 B);

		// Token: 0x0600AA28 RID: 43560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Multiply_TimespanFloat_Internal(IntPtr A, float Scalar);

		// Token: 0x0600AA29 RID: 43561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __Multiply_QuatQuat_Internal(in FQuat A, in FQuat B);

		// Token: 0x0600AA2A RID: 43562
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Multiply_MatrixMatrix_Internal(in FMatrix A, in FMatrix B);

		// Token: 0x0600AA2B RID: 43563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Multiply_MatrixFloat_Internal(in FMatrix A, float B);

		// Token: 0x0600AA2C RID: 43564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MinOfIntArray_Internal(IntPtr IntArray, ref int IndexOfMinValue, ref int MinValue);

		// Token: 0x0600AA2D RID: 43565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MinOfFloatArray_Internal(IntPtr FloatArray, ref int IndexOfMinValue, ref float MinValue);

		// Token: 0x0600AA2E RID: 43566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MinOfByteArray_Internal(IntPtr ByteArray, ref int IndexOfMinValue, ref byte MinValue);

		// Token: 0x0600AA2F RID: 43567
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MinimumAreaRectangle_Internal(IntPtr WorldContextObject, IntPtr InVerts, in FVector SampleSurfaceNormal, ref FVector OutRectCenter, ref FRotator OutRectRotation, ref float OutSideLengthX, ref float OutSideLengthY, bool bDebugDraw);

		// Token: 0x0600AA30 RID: 43568
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MaxOfIntArray_Internal(IntPtr IntArray, ref int IndexOfMaxValue, ref int MaxValue);

		// Token: 0x0600AA31 RID: 43569
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MaxOfFloatArray_Internal(IntPtr FloatArray, ref int IndexOfMaxValue, ref float MaxValue);

		// Token: 0x0600AA32 RID: 43570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __MaxOfByteArray_Internal(IntPtr ByteArray, ref int IndexOfMaxValue, ref byte MaxValue);

		// Token: 0x0600AA33 RID: 43571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Matrix_TransformVector4_Internal(in FMatrix M, in FVector4 V);

		// Token: 0x0600AA34 RID: 43572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Matrix_TransformVector_Internal(in FMatrix M, FVector V);

		// Token: 0x0600AA35 RID: 43573
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Matrix_TransformPosition_Internal(in FMatrix M, FVector V);

		// Token: 0x0600AA36 RID: 43574
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __Matrix_ToQuat_Internal(in FMatrix M);

		// Token: 0x0600AA37 RID: 43575
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Matrix_SetOrigin_Internal(ref FMatrix M, FVector NewOrigin);

		// Token: 0x0600AA38 RID: 43576
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Matrix_SetColumn_Internal(ref FMatrix M, TEnumAsByte<EMatrixColumns> Column, FVector Value);

		// Token: 0x0600AA39 RID: 43577
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Matrix_SetAxis_Internal(ref FMatrix M, TEnumAsByte<EAxis> Axis, FVector AxisVector);

		// Token: 0x0600AA3A RID: 43578
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Matrix_ScaleTranslation_Internal(in FMatrix M, FVector Scale3D);

		// Token: 0x0600AA3B RID: 43579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Matrix_RemoveTranslation_Internal(in FMatrix M);

		// Token: 0x0600AA3C RID: 43580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Matrix_RemoveScaling_Internal(ref FMatrix M, float Tolerance);

		// Token: 0x0600AA3D RID: 43581
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Matrix_Mirror_Internal(in FMatrix M, TEnumAsByte<EAxis> MirrorAxis, TEnumAsByte<EAxis> FlipAxis);

		// Token: 0x0600AA3E RID: 43582
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Matrix_InverseTransformVector_Internal(in FMatrix M, FVector V);

		// Token: 0x0600AA3F RID: 43583
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Matrix_InverseTransformPosition_Internal(in FMatrix M, FVector V);

		// Token: 0x0600AA40 RID: 43584
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Matrix_GetUnitAxis_Internal(in FMatrix M, TEnumAsByte<EAxis> Axis);

		// Token: 0x0600AA41 RID: 43585
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Matrix_GetUnitAxes_Internal(in FMatrix M, ref FVector X, ref FVector Y, ref FVector Z);

		// Token: 0x0600AA42 RID: 43586
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Matrix_GetTransposed_Internal(in FMatrix M);

		// Token: 0x0600AA43 RID: 43587
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Matrix_GetTransposeAdjoint_Internal(in FMatrix M);

		// Token: 0x0600AA44 RID: 43588
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Matrix_GetScaleVector_Internal(in FMatrix M, float Tolerance);

		// Token: 0x0600AA45 RID: 43589
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Matrix_GetScaledAxis_Internal(in FMatrix M, TEnumAsByte<EAxis> Axis);

		// Token: 0x0600AA46 RID: 43590
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Matrix_GetScaledAxes_Internal(in FMatrix M, ref FVector X, ref FVector Y, ref FVector Z);

		// Token: 0x0600AA47 RID: 43591
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Matrix_GetRotDeterminant_Internal(in FMatrix M);

		// Token: 0x0600AA48 RID: 43592
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __Matrix_GetRotator_Internal(in FMatrix M);

		// Token: 0x0600AA49 RID: 43593
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Matrix_GetOrigin_Internal(in FMatrix InMatrix);

		// Token: 0x0600AA4A RID: 43594
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Matrix_GetMaximumAxisScale_Internal(in FMatrix M);

		// Token: 0x0600AA4B RID: 43595
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Matrix_GetMatrixWithoutScale_Internal(in FMatrix M, float Tolerance);

		// Token: 0x0600AA4C RID: 43596
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Matrix_GetInverse_Internal(in FMatrix M);

		// Token: 0x0600AA4D RID: 43597
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Matrix_GetFrustumTopPlane_Internal(in FMatrix M, ref FPlane OutPlane);

		// Token: 0x0600AA4E RID: 43598
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Matrix_GetFrustumRightPlane_Internal(in FMatrix M, ref FPlane OutPlane);

		// Token: 0x0600AA4F RID: 43599
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Matrix_GetFrustumNearPlane_Internal(in FMatrix M, ref FPlane OutPlane);

		// Token: 0x0600AA50 RID: 43600
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Matrix_GetFrustumLeftPlane_Internal(in FMatrix M, ref FPlane OutPlane);

		// Token: 0x0600AA51 RID: 43601
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Matrix_GetFrustumFarPlane_Internal(in FMatrix M, ref FPlane OutPlane);

		// Token: 0x0600AA52 RID: 43602
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Matrix_GetFrustumBottomPlane_Internal(in FMatrix M, ref FPlane OutPlane);

		// Token: 0x0600AA53 RID: 43603
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __Matrix_GetDeterminant_Internal(in FMatrix M);

		// Token: 0x0600AA54 RID: 43604
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Matrix_GetColumn_Internal(in FMatrix M, TEnumAsByte<EMatrixColumns> Column);

		// Token: 0x0600AA55 RID: 43605
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Matrix_ContainsNaN_Internal(in FMatrix M);

		// Token: 0x0600AA56 RID: 43606
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Matrix_ConcatenateTranslation_Internal(in FMatrix M, FVector Translation);

		// Token: 0x0600AA57 RID: 43607
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Matrix_ApplyScale_Internal(in FMatrix M, float Scale);

		// Token: 0x0600AA58 RID: 43608
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeTimespan2_Internal(int Days, int Hours, int Minutes, int Seconds, int FractionNano);

		// Token: 0x0600AA59 RID: 43609
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeTimespan_Internal(int Days, int Hours, int Minutes, int Seconds, int Milliseconds);

		// Token: 0x0600AA5A RID: 43610
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __MakeRelativeTransform_Internal(in FTransform A, in FTransform RelativeTo);

		// Token: 0x0600AA5B RID: 43611
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeQualifiedFrameTime_Internal(IntPtr Frame, FFrameRate FrameRate, float SubFrame);

		// Token: 0x0600AA5C RID: 43612
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __MakeDateTime_Internal(int Year, int Month, int Day, int Hour, int Minute, int Second, int Millisecond);

		// Token: 0x0600AA5D RID: 43613
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LinePlaneIntersection_Internal(in FVector LineStart, in FVector LineEnd, in FPlane APlane, ref float T, ref FVector Intersection);

		// Token: 0x0600AA5E RID: 43614
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LessEqual_TimespanTimespan_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AA5F RID: 43615
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __LessEqual_DateTimeDateTime_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AA60 RID: 43616
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Less_TimespanTimespan_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AA61 RID: 43617
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Less_DateTimeDateTime_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AA62 RID: 43618
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPointInBoxWithTransform_Internal(FVector Point, in FTransform BoxWorldTransform, FVector BoxExtent);

		// Token: 0x0600AA63 RID: 43619
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsMorning_Internal(IntPtr A);

		// Token: 0x0600AA64 RID: 43620
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsAfternoon_Internal(IntPtr A);

		// Token: 0x0600AA65 RID: 43621
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __InvertTransform_Internal(in FTransform T);

		// Token: 0x0600AA66 RID: 43622
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __InverseTransformRotation_Internal(in FTransform T, FRotator Rotation);

		// Token: 0x0600AA67 RID: 43623
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __InverseTransformLocation_Internal(in FTransform T, FVector Location);

		// Token: 0x0600AA68 RID: 43624
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __InverseTransformDirection_Internal(in FTransform T, FVector Direction);

		// Token: 0x0600AA69 RID: 43625
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GreaterEqual_TimespanTimespan_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AA6A RID: 43626
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GreaterEqual_DateTimeDateTime_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AA6B RID: 43627
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Greater_TimespanTimespan_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AA6C RID: 43628
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Greater_DateTimeDateTime_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AA6D RID: 43629
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetYear_Internal(IntPtr A);

		// Token: 0x0600AA6E RID: 43630
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetVectorArrayAverage_Internal(IntPtr Vectors);

		// Token: 0x0600AA6F RID: 43631
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTotalSeconds_Internal(IntPtr A);

		// Token: 0x0600AA70 RID: 43632
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTotalMinutes_Internal(IntPtr A);

		// Token: 0x0600AA71 RID: 43633
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTotalMilliseconds_Internal(IntPtr A);

		// Token: 0x0600AA72 RID: 43634
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTotalHours_Internal(IntPtr A);

		// Token: 0x0600AA73 RID: 43635
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTotalDays_Internal(IntPtr A);

		// Token: 0x0600AA74 RID: 43636
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTimeOfDay_Internal(IntPtr A);

		// Token: 0x0600AA75 RID: 43637
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetSeconds_Internal(IntPtr A);

		// Token: 0x0600AA76 RID: 43638
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetSecond_Internal(IntPtr A);

		// Token: 0x0600AA77 RID: 43639
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMonth_Internal(IntPtr A);

		// Token: 0x0600AA78 RID: 43640
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMinutes_Internal(IntPtr A);

		// Token: 0x0600AA79 RID: 43641
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMinute_Internal(IntPtr A);

		// Token: 0x0600AA7A RID: 43642
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMilliseconds_Internal(IntPtr A);

		// Token: 0x0600AA7B RID: 43643
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetMillisecond_Internal(IntPtr A);

		// Token: 0x0600AA7C RID: 43644
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetHours_Internal(IntPtr A);

		// Token: 0x0600AA7D RID: 43645
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetHour12_Internal(IntPtr A);

		// Token: 0x0600AA7E RID: 43646
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetHour_Internal(IntPtr A);

		// Token: 0x0600AA7F RID: 43647
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDuration_Internal(IntPtr A);

		// Token: 0x0600AA80 RID: 43648
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetDays_Internal(IntPtr A);

		// Token: 0x0600AA81 RID: 43649
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetDayOfYear_Internal(IntPtr A);

		// Token: 0x0600AA82 RID: 43650
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetDay_Internal(IntPtr A);

		// Token: 0x0600AA83 RID: 43651
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDate_Internal(IntPtr A);

		// Token: 0x0600AA84 RID: 43652
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetAzimuthAndElevation_Internal(FVector InDirection, in FTransform ReferenceFrame, ref float Azimuth, ref float Elevation);

		// Token: 0x0600AA85 RID: 43653
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FromSeconds_Internal(float Seconds);

		// Token: 0x0600AA86 RID: 43654
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FromMinutes_Internal(float Minutes);

		// Token: 0x0600AA87 RID: 43655
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FromMilliseconds_Internal(float Milliseconds);

		// Token: 0x0600AA88 RID: 43656
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FromHours_Internal(float Hours);

		// Token: 0x0600AA89 RID: 43657
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __FromDays_Internal(float Days);

		// Token: 0x0600AA8A RID: 43658
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __FloatSpringInterp_Internal(float Current, float Target, IntPtr SpringState, float Stiffness, float CriticalDampingFactor, float DeltaTime, float Mass);

		// Token: 0x0600AA8B RID: 43659
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualExactly_Vector4Vector4_Internal(in FVector4 A, in FVector4 B);

		// Token: 0x0600AA8C RID: 43660
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_Vector4Vector4_Internal(in FVector4 A, in FVector4 B, float ErrorTolerance);

		// Token: 0x0600AA8D RID: 43661
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_TransformTransform_Internal(in FTransform A, in FTransform B);

		// Token: 0x0600AA8E RID: 43662
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_TimespanTimespan_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AA8F RID: 43663
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_QuatQuat_Internal(in FQuat A, in FQuat B, float Tolerance);

		// Token: 0x0600AA90 RID: 43664
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_ObjectObject_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AA91 RID: 43665
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_MatrixMatrix_Internal(in FMatrix A, in FMatrix B, float Tolerance);

		// Token: 0x0600AA92 RID: 43666
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualEqual_DateTimeDateTime_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AA93 RID: 43667
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Divide_Vector4Vector4_Internal(in FVector4 A, in FVector4 B);

		// Token: 0x0600AA94 RID: 43668
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Divide_TimespanFloat_Internal(IntPtr A, float Scalar);

		// Token: 0x0600AA95 RID: 43669
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __DateTimeMinValue_Internal();

		// Token: 0x0600AA96 RID: 43670
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __DateTimeMaxValue_Internal();

		// Token: 0x0600AA97 RID: 43671
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DateTimeFromString_Internal(in FString DateTimeString, IntPtr Result);

		// Token: 0x0600AA98 RID: 43672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __DateTimeFromIsoString_Internal(in FString IsoString, IntPtr Result);

		// Token: 0x0600AA99 RID: 43673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __D_TransformRotation_Internal(in FTransformDouble T, FRotator Rotation);

		// Token: 0x0600AA9A RID: 43674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_TransformLocation_Internal(in FTransformDouble T, FVectorDouble Location);

		// Token: 0x0600AA9B RID: 43675
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_TransformDirection_Internal(in FTransformDouble T, FVectorDouble Direction);

		// Token: 0x0600AA9C RID: 43676
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_TLerp_Internal(in FTransformDouble A, in FTransformDouble B, float Alpha, TEnumAsByte<ELerpInterpolationMode> InterpMode);

		// Token: 0x0600AA9D RID: 43677
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_TInterpTo_Internal(in FTransformDouble Current, in FTransformDouble Target, float DeltaTime, float InterpSpeed);

		// Token: 0x0600AA9E RID: 43678
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_MinOfFloatArray_Internal(IntPtr FloatArray, ref int IndexOfMinValue, ref double MinValue);

		// Token: 0x0600AA9F RID: 43679
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __D_MaxOfFloatArray_Internal(IntPtr FloatArray, ref int IndexOfMaxValue, ref double MaxValue);

		// Token: 0x0600AAA0 RID: 43680
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_MakeRelativeTransform_Internal(in FTransformDouble A, in FTransformDouble RelativeTo);

		// Token: 0x0600AAA1 RID: 43681
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_InvertTransform_Internal(in FTransformDouble T);

		// Token: 0x0600AAA2 RID: 43682
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __D_InverseTransformRotation_Internal(in FTransformDouble T, FRotator Rotation);

		// Token: 0x0600AAA3 RID: 43683
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_InverseTransformLocation_Internal(in FTransformDouble T, FVectorDouble Location);

		// Token: 0x0600AAA4 RID: 43684
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_InverseTransformDirection_Internal(in FTransformDouble T, FVectorDouble Direction);

		// Token: 0x0600AAA5 RID: 43685
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetVectorArrayAverage_Internal(IntPtr Vectors);

		// Token: 0x0600AAA6 RID: 43686
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __D_ComposeTransforms_Internal(in FTransformDouble A, in FTransformDouble B);

		// Token: 0x0600AAA7 RID: 43687
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __ConvertTransformToRelative_Internal(in FTransform Transform, in FTransform ParentTransform);

		// Token: 0x0600AAA8 RID: 43688
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __Conv_Vector4ToVector_Internal(in FVector4 InVector4);

		// Token: 0x0600AAA9 RID: 43689
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __Conv_Vector4ToRotator_Internal(in FVector4 InVec);

		// Token: 0x0600AAAA RID: 43690
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __Conv_Vector4ToQuaternion_Internal(in FVector4 InVec);

		// Token: 0x0600AAAB RID: 43691
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransformDouble __Conv_TransformToTransformDouble_Internal(in FTransform InT);

		// Token: 0x0600AAAC RID: 43692
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Conv_TransformToMatrix_Internal(in FTransform Transform);

		// Token: 0x0600AAAD RID: 43693
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __Conv_TransformDoubleToTransform_Internal(in FTransformDouble InT);

		// Token: 0x0600AAAE RID: 43694
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __Conv_MatrixToTransform_Internal(in FMatrix InMatrix);

		// Token: 0x0600AAAF RID: 43695
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __Conv_MatrixToRotator_Internal(in FMatrix InMatrix);

		// Token: 0x0600AAB0 RID: 43696
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __ComposeTransforms_Internal(in FTransform A, in FTransform B);

		// Token: 0x0600AAB1 RID: 43697
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakVector4_Internal(in FVector4 InVec, ref float X, ref float Y, ref float Z, ref float W);

		// Token: 0x0600AAB2 RID: 43698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakTransformDouble_Internal(in FTransformDouble InTransform, ref FVectorDouble Location, ref FRotator Rotation, ref FVector Scale);

		// Token: 0x0600AAB3 RID: 43699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakTransform_Internal(in FTransform InTransform, ref FVector Location, ref FRotator Rotation, ref FVector Scale);

		// Token: 0x0600AAB4 RID: 43700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakTimespan2_Internal(IntPtr InTimespan, ref int Days, ref int Hours, ref int Minutes, ref int Seconds, ref int FractionNano);

		// Token: 0x0600AAB5 RID: 43701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakTimespan_Internal(IntPtr InTimespan, ref int Days, ref int Hours, ref int Minutes, ref int Seconds, ref int Milliseconds);

		// Token: 0x0600AAB6 RID: 43702
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakQualifiedFrameTime_Internal(IntPtr InFrameTime, IntPtr Frame, ref FFrameRate FrameRate, ref float SubFrame);

		// Token: 0x0600AAB7 RID: 43703
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __BreakDateTime_Internal(IntPtr InDateTime, ref int Year, ref int Month, ref int Day, ref int Hour, ref int Minute, ref int Second, ref int Millisecond);

		// Token: 0x0600AAB8 RID: 43704
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector4 __Add_Vector4Vector4_Internal(in FVector4 A, in FVector4 B);

		// Token: 0x0600AAB9 RID: 43705
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Add_TimespanTimespan_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AABA RID: 43706
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FQuat __Add_QuatQuat_Internal(in FQuat A, in FQuat B);

		// Token: 0x0600AABB RID: 43707
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FMatrix __Add_MatrixMatrix_Internal(in FMatrix A, in FMatrix B);

		// Token: 0x0600AABC RID: 43708
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Add_DateTimeTimespan_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AABD RID: 43709
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __Add_DateTimeDateTime_Internal(IntPtr A, IntPtr B);

		// Token: 0x0600AABE RID: 43710 RVA: 0x000EFEFA File Offset: 0x000EE0FA
		static UKismetMathLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.KismetMathLibrary");
		}

		// Token: 0x0600AABF RID: 43711 RVA: 0x000EFF08 File Offset: 0x000EE108
		protected UKismetMathLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005B36 RID: 23350
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.KismetMathLibrary";

		// Token: 0x04005B37 RID: 23351
		private static IntPtr _ClassPtr;

		// Token: 0x04005B38 RID: 23352
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005B39 RID: 23353
		private static IntPtr __Percent_FloatFloat_NativeFunctionPtr;

		// Token: 0x04005B3A RID: 23354
		private static IntPtr __Divide_FloatFloat_NativeFunctionPtr;

		// Token: 0x04005B3B RID: 23355
		private static IntPtr __D_Percent_FloatFloat_NativeFunctionPtr;

		// Token: 0x04005B3C RID: 23356
		private static IntPtr __D_Divide_FloatFloat_NativeFunctionPtr;

		// Token: 0x02002D30 RID: 11568
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Percent_FloatFloat_FunctionParams
		{
			// Token: 0x04016722 RID: 91938
			[FieldOffset(0)]
			public float A;

			// Token: 0x04016723 RID: 91939
			[FieldOffset(4)]
			public float B;

			// Token: 0x04016724 RID: 91940
			[FieldOffset(8)]
			public float __Result;
		}

		// Token: 0x02002D31 RID: 11569
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 12)]
		protected ref struct __Divide_FloatFloat_FunctionParams
		{
			// Token: 0x04016725 RID: 91941
			[FieldOffset(0)]
			public float A;

			// Token: 0x04016726 RID: 91942
			[FieldOffset(4)]
			public float B;

			// Token: 0x04016727 RID: 91943
			[FieldOffset(8)]
			public float __Result;
		}

		// Token: 0x02002D32 RID: 11570
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __D_Percent_FloatFloat_FunctionParams
		{
			// Token: 0x04016728 RID: 91944
			[FieldOffset(0)]
			public double A;

			// Token: 0x04016729 RID: 91945
			[FieldOffset(8)]
			public double B;

			// Token: 0x0401672A RID: 91946
			[FieldOffset(16)]
			public double __Result;
		}

		// Token: 0x02002D33 RID: 11571
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 24)]
		protected ref struct __D_Divide_FloatFloat_FunctionParams
		{
			// Token: 0x0401672B RID: 91947
			[FieldOffset(0)]
			public double A;

			// Token: 0x0401672C RID: 91948
			[FieldOffset(8)]
			public double B;

			// Token: 0x0401672D RID: 91949
			[FieldOffset(16)]
			public double __Result;
		}
	}
}
