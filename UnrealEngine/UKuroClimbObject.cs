using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200046D RID: 1133
	[UnrealObjectPath("/Script/KuroMovement.KuroClimbObject")]
	[UnrealStructLayout(544, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 544)]
	public class UKuroClimbObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006B92 RID: 27538 RVA: 0x0009CA8D File Offset: 0x0009AC8D
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroClimbObject._ClassPtr;
		}

		// Token: 0x06006B93 RID: 27539 RVA: 0x0009CA9C File Offset: 0x0009AC9C
		public UKuroClimbObject() : this(BuiltinUtils.AllocNativeUObject(UKuroClimbObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006B94 RID: 27540 RVA: 0x0009CAC4 File Offset: 0x0009ACC4
		[NullableContext(1)]
		public UKuroClimbObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroClimbObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06006B95 RID: 27541 RVA: 0x0009CAF8 File Offset: 0x0009ACF8
		public unsafe TEnumAsByte<EClimbingArriveType> TryUpArrives(FVector InputDirect, float DebugDrawDuration, ref FTransform OutTrans)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = OutTrans;
			TEnumAsByte<EClimbingArriveType> result = UKuroClimbObject.__TryUpArrives_Internal(base.NativePtr, InputDirect, DebugDrawDuration, ref ptr);
			OutTrans = ptr;
			return result;
		}

		// Token: 0x06006B96 RID: 27542 RVA: 0x0009CB3C File Offset: 0x0009AD3C
		public unsafe bool TryStartClimb(FTransform Trans, float DebugDrawDuration, ref FTransform OutTrans)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Trans;
			ref FTransform ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr2 = OutTrans;
			bool result = UKuroClimbObject.__TryStartClimb_Internal(base.NativePtr, ptr, DebugDrawDuration, ref ptr2);
			OutTrans = ptr2;
			return result;
		}

		// Token: 0x06006B97 RID: 27543 RVA: 0x0009CB98 File Offset: 0x0009AD98
		public unsafe TEnumAsByte<ESprintVaultType> TrySprintVault(float DebugDrawDuration, ref FTransform OutTrans, ref float OutLongOffset)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = OutTrans;
			fixed (float* ptr2 = &OutLongOffset)
			{
				void* ptr3 = (void*)ptr2;
				TEnumAsByte<ESprintVaultType> result = UKuroClimbObject.__TrySprintVault_Internal(base.NativePtr, DebugDrawDuration, ref ptr, ref OutLongOffset);
				OutTrans = ptr;
				return result;
			}
		}

		// Token: 0x06006B98 RID: 27544 RVA: 0x0009CBE0 File Offset: 0x0009ADE0
		public unsafe TEnumAsByte<EClimbingArriveType> TryClimbingArrives(FVector InputDirect, float DebugDrawDuration, ref FTransform OutTrans, bool NeedTryBlockUp = false)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = OutTrans;
			TEnumAsByte<EClimbingArriveType> result = UKuroClimbObject.__TryClimbingArrives_Internal(base.NativePtr, InputDirect, DebugDrawDuration, ref ptr, NeedTryBlockUp);
			OutTrans = ptr;
			return result;
		}

		// Token: 0x06006B99 RID: 27545 RVA: 0x0009CC25 File Offset: 0x0009AE25
		[NullableContext(2)]
		public void SyncFromOther(UKuroClimbObject Other)
		{
			UKuroClimbObject.__SyncFromOther_Internal(base.NativePtr, (Other != null) ? Other.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006B9A RID: 27546 RVA: 0x0009CC44 File Offset: 0x0009AE44
		public unsafe bool ProcessClimbing(FVector MoveSpeed, float DeltaTime, bool IsTryMove, float DebugDrawDuration, ref FTransform OutTrans)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = OutTrans;
			bool result = UKuroClimbObject.__ProcessClimbing_Internal(base.NativePtr, MoveSpeed, DeltaTime, IsTryMove, DebugDrawDuration, ref ptr);
			OutTrans = ptr;
			return result;
		}

		// Token: 0x06006B9B RID: 27547 RVA: 0x0009CC8C File Offset: 0x0009AE8C
		public bool NeedFollowHangOnStartingClimb()
		{
			return UKuroClimbObject.__NeedFollowHangOnStartingClimb_Internal(base.NativePtr);
		}

		// Token: 0x06006B9C RID: 27548 RVA: 0x0009CC99 File Offset: 0x0009AE99
		[NullableContext(2)]
		public void InitUpArrives(TArray<FVector> InUpArriveMoveOffsets, TArray<float> InHeightMins, TArray<float> InHeightMaxs)
		{
			UKuroClimbObject.__InitUpArrives_Internal(base.NativePtr, (InUpArriveMoveOffsets ?? new TArray<FVector>()).NativePtr, (InHeightMins ?? new TArray<float>()).NativePtr, (InHeightMaxs ?? new TArray<float>()).NativePtr);
		}

		// Token: 0x06006B9D RID: 27549 RVA: 0x0009CCD4 File Offset: 0x0009AED4
		public void InitSprintVault(float InForwardBlockHeight, float InForwardBlockRadius, float InForwardBlockDistanceMin, float InForwardBlockDistanceMax, FVector InSprintVaultMoveOffset, float InHeightMin, float InHeightMax, float InSprintVaultLongNeedDistance, float InSprintVaultLongHeight, ETraceTypeQuery InBlockChannel, float SprintVaultLongMin = 0f, float SprintVaultLongMax = 100f, float SprintVaultBlockMaxAngle = 45f)
		{
			UKuroClimbObject.__InitSprintVault_Internal(base.NativePtr, InForwardBlockHeight, InForwardBlockRadius, InForwardBlockDistanceMin, InForwardBlockDistanceMax, InSprintVaultMoveOffset, InHeightMin, InHeightMax, InSprintVaultLongNeedDistance, InSprintVaultLongHeight, InBlockChannel, SprintVaultLongMin, SprintVaultLongMax, SprintVaultBlockMaxAngle);
		}

		// Token: 0x06006B9E RID: 27550 RVA: 0x0009CD08 File Offset: 0x0009AF08
		public void InitClimbSafety(float InRadius, float InHalfHeight, float InMaxOffset)
		{
			UKuroClimbObject.__InitClimbSafety_Internal(base.NativePtr, InRadius, InHalfHeight, InMaxOffset);
		}

		// Token: 0x06006B9F RID: 27551 RVA: 0x0009CD18 File Offset: 0x0009AF18
		public void InitBlockUps(FVector InBlockUpOffset, float InBlockUpDetectRadius, float InBlockUpDetectDistance, float InBlockUpBackDistance, float InBlockUpBackMin = 50f, FVector? InBlockUpFinalMove = null, float BlockUpVerticalRangeMin = 0f, float BlockUpVerticalRangeMax = 200f)
		{
			UKuroClimbObject.__InitBlockUps_Internal(base.NativePtr, InBlockUpOffset, InBlockUpDetectRadius, InBlockUpDetectDistance, InBlockUpBackDistance, InBlockUpBackMin, InBlockUpFinalMove ?? new FVector(0f, 0f, 500f), BlockUpVerticalRangeMin, BlockUpVerticalRangeMax);
		}

		// Token: 0x06006BA0 RID: 27552 RVA: 0x0009CD64 File Offset: 0x0009AF64
		[NullableContext(2)]
		public void InitBase(UShapeComponent InShapeComp, ECollisionChannel InClimbChannel, TArray<FVector> BaseLocations, float InSphereRadius, float InActorToWallDist, float InDetectLength = 150f, float InSafetyHalfHeight = 0f, float InSafetyRadius = 0f)
		{
			UKuroClimbObject.__InitBase_Internal(base.NativePtr, (InShapeComp != null) ? InShapeComp.NativePtr : IntPtr.Zero, InClimbChannel, (BaseLocations ?? new TArray<FVector>()).NativePtr, InSphereRadius, InActorToWallDist, InDetectLength, InSafetyHalfHeight, InSafetyRadius);
		}

		// Token: 0x06006BA1 RID: 27553 RVA: 0x0009CDAB File Offset: 0x0009AFAB
		public FVector GetSecondMoveOffset()
		{
			return UKuroClimbObject.__GetSecondMoveOffset_Internal(base.NativePtr);
		}

		// Token: 0x06006BA2 RID: 27554 RVA: 0x0009CDB8 File Offset: 0x0009AFB8
		public FVector GetSafetyLocation()
		{
			return UKuroClimbObject.__GetSafetyLocation_Internal(base.NativePtr);
		}

		// Token: 0x06006BA3 RID: 27555 RVA: 0x0009CDC5 File Offset: 0x0009AFC5
		public void ExitClimb()
		{
			UKuroClimbObject.__ExitClimb_Internal(base.NativePtr);
		}

		// Token: 0x06006BA4 RID: 27556 RVA: 0x0009CDD4 File Offset: 0x0009AFD4
		public unsafe TEnumAsByte<EClimbingArriveType> D_TryUpArrives(FVectorDouble InputDirect, float DebugDrawDuration, ref FTransformDouble OutTrans)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = OutTrans;
			TEnumAsByte<EClimbingArriveType> result = UKuroClimbObject.__D_TryUpArrives_Internal(base.NativePtr, InputDirect, DebugDrawDuration, ref ptr);
			OutTrans = ptr;
			return result;
		}

		// Token: 0x06006BA5 RID: 27557 RVA: 0x0009CE18 File Offset: 0x0009B018
		public unsafe bool D_TryStartClimb(FTransformDouble Trans, float DebugDrawDuration, ref FTransformDouble OutTrans)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = Trans;
			ref FTransformDouble ptr2 = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr2 = OutTrans;
			bool result = UKuroClimbObject.__D_TryStartClimb_Internal(base.NativePtr, ptr, DebugDrawDuration, ref ptr2);
			OutTrans = ptr2;
			return result;
		}

		// Token: 0x06006BA6 RID: 27558 RVA: 0x0009CE74 File Offset: 0x0009B074
		public unsafe TEnumAsByte<ESprintVaultType> D_TrySprintVault(float DebugDrawDuration, ref FTransformDouble OutTrans, ref float OutLongOffset)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = OutTrans;
			fixed (float* ptr2 = &OutLongOffset)
			{
				void* ptr3 = (void*)ptr2;
				TEnumAsByte<ESprintVaultType> result = UKuroClimbObject.__D_TrySprintVault_Internal(base.NativePtr, DebugDrawDuration, ref ptr, ref OutLongOffset);
				OutTrans = ptr;
				return result;
			}
		}

		// Token: 0x06006BA7 RID: 27559 RVA: 0x0009CEBC File Offset: 0x0009B0BC
		public unsafe TEnumAsByte<EClimbingArriveType> D_TryClimbingArrives(FVectorDouble InputDirect, float DebugDrawDuration, ref FTransformDouble OutTrans, bool NeedTryBlockUp = false)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = OutTrans;
			TEnumAsByte<EClimbingArriveType> result = UKuroClimbObject.__D_TryClimbingArrives_Internal(base.NativePtr, InputDirect, DebugDrawDuration, ref ptr, NeedTryBlockUp);
			OutTrans = ptr;
			return result;
		}

		// Token: 0x06006BA8 RID: 27560 RVA: 0x0009CF04 File Offset: 0x0009B104
		public unsafe bool D_ProcessClimbing(FVectorDouble MoveSpeed, float DeltaTime, bool IsTryMove, float DebugDrawDuration, ref FTransformDouble OutTrans)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = OutTrans;
			bool result = UKuroClimbObject.__D_ProcessClimbing_Internal(base.NativePtr, MoveSpeed, DeltaTime, IsTryMove, DebugDrawDuration, ref ptr);
			OutTrans = ptr;
			return result;
		}

		// Token: 0x06006BA9 RID: 27561 RVA: 0x0009CF4C File Offset: 0x0009B14C
		public FVectorDouble D_GetSafetyLocation()
		{
			return UKuroClimbObject.__D_GetSafetyLocation_Internal(base.NativePtr);
		}

		// Token: 0x06006BAA RID: 27562 RVA: 0x0009CF59 File Offset: 0x0009B159
		public void ConfirmMove()
		{
			UKuroClimbObject.__ConfirmMove_Internal(base.NativePtr);
		}

		// Token: 0x06006BAB RID: 27563 RVA: 0x0009CF66 File Offset: 0x0009B166
		public bool ClimbBlock()
		{
			return UKuroClimbObject.__ClimbBlock_Internal(base.NativePtr);
		}

		// Token: 0x06006BAC RID: 27564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EClimbingArriveType> __TryUpArrives_Internal(IntPtr @this, FVector InputDirect, float DebugDrawDuration, ref FTransform OutTrans);

		// Token: 0x06006BAD RID: 27565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TryStartClimb_Internal(IntPtr @this, in FTransform Trans, float DebugDrawDuration, ref FTransform OutTrans);

		// Token: 0x06006BAE RID: 27566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ESprintVaultType> __TrySprintVault_Internal(IntPtr @this, float DebugDrawDuration, ref FTransform OutTrans, ref float OutLongOffset);

		// Token: 0x06006BAF RID: 27567
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EClimbingArriveType> __TryClimbingArrives_Internal(IntPtr @this, FVector InputDirect, float DebugDrawDuration, ref FTransform OutTrans, bool NeedTryBlockUp);

		// Token: 0x06006BB0 RID: 27568
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SyncFromOther_Internal(IntPtr @this, IntPtr Other);

		// Token: 0x06006BB1 RID: 27569
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ProcessClimbing_Internal(IntPtr @this, FVector MoveSpeed, float DeltaTime, bool IsTryMove, float DebugDrawDuration, ref FTransform OutTrans);

		// Token: 0x06006BB2 RID: 27570
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NeedFollowHangOnStartingClimb_Internal(IntPtr @this);

		// Token: 0x06006BB3 RID: 27571
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitUpArrives_Internal(IntPtr @this, IntPtr InUpArriveMoveOffsets, IntPtr InHeightMins, IntPtr InHeightMaxs);

		// Token: 0x06006BB4 RID: 27572
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitSprintVault_Internal(IntPtr @this, float InForwardBlockHeight, float InForwardBlockRadius, float InForwardBlockDistanceMin, float InForwardBlockDistanceMax, FVector InSprintVaultMoveOffset, float InHeightMin, float InHeightMax, float InSprintVaultLongNeedDistance, float InSprintVaultLongHeight, TEnumAsByte<ETraceTypeQuery> InBlockChannel, float SprintVaultLongMin, float SprintVaultLongMax, float SprintVaultBlockMaxAngle);

		// Token: 0x06006BB5 RID: 27573
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitClimbSafety_Internal(IntPtr @this, float InRadius, float InHalfHeight, float InMaxOffset);

		// Token: 0x06006BB6 RID: 27574
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitBlockUps_Internal(IntPtr @this, FVector InBlockUpOffset, float InBlockUpDetectRadius, float InBlockUpDetectDistance, float InBlockUpBackDistance, float InBlockUpBackMin, FVector InBlockUpFinalMove, float BlockUpVerticalRangeMin, float BlockUpVerticalRangeMax);

		// Token: 0x06006BB7 RID: 27575
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitBase_Internal(IntPtr @this, IntPtr InShapeComp, TEnumAsByte<ECollisionChannel> InClimbChannel, IntPtr BaseLocations, float InSphereRadius, float InActorToWallDist, float InDetectLength, float InSafetyHalfHeight, float InSafetyRadius);

		// Token: 0x06006BB8 RID: 27576
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetSecondMoveOffset_Internal(IntPtr @this);

		// Token: 0x06006BB9 RID: 27577
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetSafetyLocation_Internal(IntPtr @this);

		// Token: 0x06006BBA RID: 27578
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExitClimb_Internal(IntPtr @this);

		// Token: 0x06006BBB RID: 27579
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EClimbingArriveType> __D_TryUpArrives_Internal(IntPtr @this, FVectorDouble InputDirect, float DebugDrawDuration, ref FTransformDouble OutTrans);

		// Token: 0x06006BBC RID: 27580
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_TryStartClimb_Internal(IntPtr @this, in FTransformDouble Trans, float DebugDrawDuration, ref FTransformDouble OutTrans);

		// Token: 0x06006BBD RID: 27581
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ESprintVaultType> __D_TrySprintVault_Internal(IntPtr @this, float DebugDrawDuration, ref FTransformDouble OutTrans, ref float OutLongOffset);

		// Token: 0x06006BBE RID: 27582
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EClimbingArriveType> __D_TryClimbingArrives_Internal(IntPtr @this, FVectorDouble InputDirect, float DebugDrawDuration, ref FTransformDouble OutTrans, bool NeedTryBlockUp);

		// Token: 0x06006BBF RID: 27583
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_ProcessClimbing_Internal(IntPtr @this, FVectorDouble MoveSpeed, float DeltaTime, bool IsTryMove, float DebugDrawDuration, ref FTransformDouble OutTrans);

		// Token: 0x06006BC0 RID: 27584
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetSafetyLocation_Internal(IntPtr @this);

		// Token: 0x06006BC1 RID: 27585
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ConfirmMove_Internal(IntPtr @this);

		// Token: 0x06006BC2 RID: 27586
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ClimbBlock_Internal(IntPtr @this);

		// Token: 0x06006BC3 RID: 27587 RVA: 0x0009CF73 File Offset: 0x0009B173
		static UKuroClimbObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMovement.KuroClimbObject");
		}

		// Token: 0x06006BC4 RID: 27588 RVA: 0x0009CF81 File Offset: 0x0009B181
		protected UKuroClimbObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04002E07 RID: 11783
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroMovement.KuroClimbObject";

		// Token: 0x04002E08 RID: 11784
		private static IntPtr _ClassPtr;

		// Token: 0x04002E09 RID: 11785
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
