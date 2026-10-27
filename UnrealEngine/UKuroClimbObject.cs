using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020019E0 RID: 6624
	[UnrealObjectPath("/Script/KuroMovement.KuroClimbObject")]
	[UnrealStructLayout(544, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 544)]
	public class UKuroClimbObject : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06018916 RID: 100630 RVA: 0x00242E67 File Offset: 0x00241067
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroClimbObject._ClassPtr;
		}

		// Token: 0x06018917 RID: 100631 RVA: 0x00242E74 File Offset: 0x00241074
		public UKuroClimbObject() : this(BuiltinUtils.AllocNativeUObject(UKuroClimbObject.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06018918 RID: 100632 RVA: 0x00242E9C File Offset: 0x0024109C
		[NullableContext(1)]
		public UKuroClimbObject(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroClimbObject.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06018919 RID: 100633 RVA: 0x00242ED0 File Offset: 0x002410D0
		public unsafe TEnumAsByte<EClimbingArriveType> TryUpArrives(FVector InputDirect, float DebugDrawDuration, ref FTransform OutTrans)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = OutTrans;
			TEnumAsByte<EClimbingArriveType> result = UKuroClimbObject.__TryUpArrives_Internal(base.NativePtr, InputDirect, DebugDrawDuration, ref ptr);
			OutTrans = ptr;
			return result;
		}

		// Token: 0x0601891A RID: 100634 RVA: 0x00242F14 File Offset: 0x00241114
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

		// Token: 0x0601891B RID: 100635 RVA: 0x00242F70 File Offset: 0x00241170
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

		// Token: 0x0601891C RID: 100636 RVA: 0x00242FB8 File Offset: 0x002411B8
		public unsafe TEnumAsByte<EClimbingArriveType> TryClimbingArrives(FVector InputDirect, float DebugDrawDuration, ref FTransform OutTrans, bool NeedTryBlockUp = false)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = OutTrans;
			TEnumAsByte<EClimbingArriveType> result = UKuroClimbObject.__TryClimbingArrives_Internal(base.NativePtr, InputDirect, DebugDrawDuration, ref ptr, NeedTryBlockUp);
			OutTrans = ptr;
			return result;
		}

		// Token: 0x0601891D RID: 100637 RVA: 0x00242FFD File Offset: 0x002411FD
		[NullableContext(2)]
		public void SyncFromOther(UKuroClimbObject Other)
		{
			UKuroClimbObject.__SyncFromOther_Internal(base.NativePtr, (Other != null) ? Other.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601891E RID: 100638 RVA: 0x0024301C File Offset: 0x0024121C
		public unsafe bool ProcessClimbing(FVector MoveSpeed, float DeltaTime, bool IsTryMove, float DebugDrawDuration, ref FTransform OutTrans)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = OutTrans;
			bool result = UKuroClimbObject.__ProcessClimbing_Internal(base.NativePtr, MoveSpeed, DeltaTime, IsTryMove, DebugDrawDuration, ref ptr);
			OutTrans = ptr;
			return result;
		}

		// Token: 0x0601891F RID: 100639 RVA: 0x00243064 File Offset: 0x00241264
		public bool NeedFollowHangOnStartingClimb()
		{
			return UKuroClimbObject.__NeedFollowHangOnStartingClimb_Internal(base.NativePtr);
		}

		// Token: 0x06018920 RID: 100640 RVA: 0x00243071 File Offset: 0x00241271
		[NullableContext(2)]
		public void InitUpArrives(TArray<FVector> InUpArriveMoveOffsets, TArray<float> InHeightMins, TArray<float> InHeightMaxs)
		{
			UKuroClimbObject.__InitUpArrives_Internal(base.NativePtr, (InUpArriveMoveOffsets ?? new TArray<FVector>()).NativePtr, (InHeightMins ?? new TArray<float>()).NativePtr, (InHeightMaxs ?? new TArray<float>()).NativePtr);
		}

		// Token: 0x06018921 RID: 100641 RVA: 0x002430AC File Offset: 0x002412AC
		public void InitSprintVault(float InForwardBlockHeight, float InForwardBlockRadius, float InForwardBlockDistanceMin, float InForwardBlockDistanceMax, FVector InSprintVaultMoveOffset, float InHeightMin, float InHeightMax, float InSprintVaultLongNeedDistance, float InSprintVaultLongHeight, ETraceTypeQuery InBlockChannel, float SprintVaultLongMin = 0f, float SprintVaultLongMax = 100f, float SprintVaultBlockMaxAngle = 45f)
		{
			UKuroClimbObject.__InitSprintVault_Internal(base.NativePtr, InForwardBlockHeight, InForwardBlockRadius, InForwardBlockDistanceMin, InForwardBlockDistanceMax, InSprintVaultMoveOffset, InHeightMin, InHeightMax, InSprintVaultLongNeedDistance, InSprintVaultLongHeight, InBlockChannel, SprintVaultLongMin, SprintVaultLongMax, SprintVaultBlockMaxAngle);
		}

		// Token: 0x06018922 RID: 100642 RVA: 0x002430E0 File Offset: 0x002412E0
		public void InitClimbSafety(float InRadius, float InHalfHeight, float InMaxOffset)
		{
			UKuroClimbObject.__InitClimbSafety_Internal(base.NativePtr, InRadius, InHalfHeight, InMaxOffset);
		}

		// Token: 0x06018923 RID: 100643 RVA: 0x002430F0 File Offset: 0x002412F0
		public void InitBlockUps(FVector InBlockUpOffset, float InBlockUpDetectRadius, float InBlockUpDetectDistance, float InBlockUpBackDistance, float InBlockUpBackMin = 50f, FVector? InBlockUpFinalMove = null, float BlockUpVerticalRangeMin = 0f, float BlockUpVerticalRangeMax = 200f)
		{
			UKuroClimbObject.__InitBlockUps_Internal(base.NativePtr, InBlockUpOffset, InBlockUpDetectRadius, InBlockUpDetectDistance, InBlockUpBackDistance, InBlockUpBackMin, InBlockUpFinalMove ?? new FVector(0f, 0f, 500f), BlockUpVerticalRangeMin, BlockUpVerticalRangeMax);
		}

		// Token: 0x06018924 RID: 100644 RVA: 0x0024313C File Offset: 0x0024133C
		[NullableContext(2)]
		public void InitBase(UShapeComponent InShapeComp, ECollisionChannel InClimbChannel, TArray<FVector> BaseLocations, float InSphereRadius, float InActorToWallDist, float InDetectLength = 150f, float InSafetyHalfHeight = 0f, float InSafetyRadius = 0f)
		{
			UKuroClimbObject.__InitBase_Internal(base.NativePtr, (InShapeComp != null) ? InShapeComp.NativePtr : IntPtr.Zero, InClimbChannel, (BaseLocations ?? new TArray<FVector>()).NativePtr, InSphereRadius, InActorToWallDist, InDetectLength, InSafetyHalfHeight, InSafetyRadius);
		}

		// Token: 0x06018925 RID: 100645 RVA: 0x00243183 File Offset: 0x00241383
		public FVector GetSecondMoveOffset()
		{
			return UKuroClimbObject.__GetSecondMoveOffset_Internal(base.NativePtr);
		}

		// Token: 0x06018926 RID: 100646 RVA: 0x00243190 File Offset: 0x00241390
		public FVector GetSafetyLocation()
		{
			return UKuroClimbObject.__GetSafetyLocation_Internal(base.NativePtr);
		}

		// Token: 0x06018927 RID: 100647 RVA: 0x0024319D File Offset: 0x0024139D
		public void ExitClimb()
		{
			UKuroClimbObject.__ExitClimb_Internal(base.NativePtr);
		}

		// Token: 0x06018928 RID: 100648 RVA: 0x002431AC File Offset: 0x002413AC
		public unsafe TEnumAsByte<EClimbingArriveType> D_TryUpArrives(FVectorDouble InputDirect, float DebugDrawDuration, ref FTransformDouble OutTrans)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = OutTrans;
			TEnumAsByte<EClimbingArriveType> result = UKuroClimbObject.__D_TryUpArrives_Internal(base.NativePtr, InputDirect, DebugDrawDuration, ref ptr);
			OutTrans = ptr;
			return result;
		}

		// Token: 0x06018929 RID: 100649 RVA: 0x002431F0 File Offset: 0x002413F0
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

		// Token: 0x0601892A RID: 100650 RVA: 0x0024324C File Offset: 0x0024144C
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

		// Token: 0x0601892B RID: 100651 RVA: 0x00243294 File Offset: 0x00241494
		public unsafe TEnumAsByte<EClimbingArriveType> D_TryClimbingArrives(FVectorDouble InputDirect, float DebugDrawDuration, ref FTransformDouble OutTrans, bool NeedTryBlockUp = false)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = OutTrans;
			TEnumAsByte<EClimbingArriveType> result = UKuroClimbObject.__D_TryClimbingArrives_Internal(base.NativePtr, InputDirect, DebugDrawDuration, ref ptr, NeedTryBlockUp);
			OutTrans = ptr;
			return result;
		}

		// Token: 0x0601892C RID: 100652 RVA: 0x002432DC File Offset: 0x002414DC
		public unsafe bool D_ProcessClimbing(FVectorDouble MoveSpeed, float DeltaTime, bool IsTryMove, float DebugDrawDuration, ref FTransformDouble OutTrans)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = OutTrans;
			bool result = UKuroClimbObject.__D_ProcessClimbing_Internal(base.NativePtr, MoveSpeed, DeltaTime, IsTryMove, DebugDrawDuration, ref ptr);
			OutTrans = ptr;
			return result;
		}

		// Token: 0x0601892D RID: 100653 RVA: 0x00243324 File Offset: 0x00241524
		public FVectorDouble D_GetSafetyLocation()
		{
			return UKuroClimbObject.__D_GetSafetyLocation_Internal(base.NativePtr);
		}

		// Token: 0x0601892E RID: 100654 RVA: 0x00243331 File Offset: 0x00241531
		public void ConfirmMove()
		{
			UKuroClimbObject.__ConfirmMove_Internal(base.NativePtr);
		}

		// Token: 0x0601892F RID: 100655 RVA: 0x0024333E File Offset: 0x0024153E
		public bool ClimbBlock()
		{
			return UKuroClimbObject.__ClimbBlock_Internal(base.NativePtr);
		}

		// Token: 0x06018930 RID: 100656
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EClimbingArriveType> __TryUpArrives_Internal(IntPtr @this, FVector InputDirect, float DebugDrawDuration, ref FTransform OutTrans);

		// Token: 0x06018931 RID: 100657
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __TryStartClimb_Internal(IntPtr @this, in FTransform Trans, float DebugDrawDuration, ref FTransform OutTrans);

		// Token: 0x06018932 RID: 100658
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ESprintVaultType> __TrySprintVault_Internal(IntPtr @this, float DebugDrawDuration, ref FTransform OutTrans, ref float OutLongOffset);

		// Token: 0x06018933 RID: 100659
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EClimbingArriveType> __TryClimbingArrives_Internal(IntPtr @this, FVector InputDirect, float DebugDrawDuration, ref FTransform OutTrans, bool NeedTryBlockUp);

		// Token: 0x06018934 RID: 100660
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SyncFromOther_Internal(IntPtr @this, IntPtr Other);

		// Token: 0x06018935 RID: 100661
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ProcessClimbing_Internal(IntPtr @this, FVector MoveSpeed, float DeltaTime, bool IsTryMove, float DebugDrawDuration, ref FTransform OutTrans);

		// Token: 0x06018936 RID: 100662
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __NeedFollowHangOnStartingClimb_Internal(IntPtr @this);

		// Token: 0x06018937 RID: 100663
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitUpArrives_Internal(IntPtr @this, IntPtr InUpArriveMoveOffsets, IntPtr InHeightMins, IntPtr InHeightMaxs);

		// Token: 0x06018938 RID: 100664
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitSprintVault_Internal(IntPtr @this, float InForwardBlockHeight, float InForwardBlockRadius, float InForwardBlockDistanceMin, float InForwardBlockDistanceMax, FVector InSprintVaultMoveOffset, float InHeightMin, float InHeightMax, float InSprintVaultLongNeedDistance, float InSprintVaultLongHeight, TEnumAsByte<ETraceTypeQuery> InBlockChannel, float SprintVaultLongMin, float SprintVaultLongMax, float SprintVaultBlockMaxAngle);

		// Token: 0x06018939 RID: 100665
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitClimbSafety_Internal(IntPtr @this, float InRadius, float InHalfHeight, float InMaxOffset);

		// Token: 0x0601893A RID: 100666
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitBlockUps_Internal(IntPtr @this, FVector InBlockUpOffset, float InBlockUpDetectRadius, float InBlockUpDetectDistance, float InBlockUpBackDistance, float InBlockUpBackMin, FVector InBlockUpFinalMove, float BlockUpVerticalRangeMin, float BlockUpVerticalRangeMax);

		// Token: 0x0601893B RID: 100667
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitBase_Internal(IntPtr @this, IntPtr InShapeComp, TEnumAsByte<ECollisionChannel> InClimbChannel, IntPtr BaseLocations, float InSphereRadius, float InActorToWallDist, float InDetectLength, float InSafetyHalfHeight, float InSafetyRadius);

		// Token: 0x0601893C RID: 100668
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetSecondMoveOffset_Internal(IntPtr @this);

		// Token: 0x0601893D RID: 100669
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __GetSafetyLocation_Internal(IntPtr @this);

		// Token: 0x0601893E RID: 100670
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ExitClimb_Internal(IntPtr @this);

		// Token: 0x0601893F RID: 100671
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EClimbingArriveType> __D_TryUpArrives_Internal(IntPtr @this, FVectorDouble InputDirect, float DebugDrawDuration, ref FTransformDouble OutTrans);

		// Token: 0x06018940 RID: 100672
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_TryStartClimb_Internal(IntPtr @this, in FTransformDouble Trans, float DebugDrawDuration, ref FTransformDouble OutTrans);

		// Token: 0x06018941 RID: 100673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ESprintVaultType> __D_TrySprintVault_Internal(IntPtr @this, float DebugDrawDuration, ref FTransformDouble OutTrans, ref float OutLongOffset);

		// Token: 0x06018942 RID: 100674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EClimbingArriveType> __D_TryClimbingArrives_Internal(IntPtr @this, FVectorDouble InputDirect, float DebugDrawDuration, ref FTransformDouble OutTrans, bool NeedTryBlockUp);

		// Token: 0x06018943 RID: 100675
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __D_ProcessClimbing_Internal(IntPtr @this, FVectorDouble MoveSpeed, float DeltaTime, bool IsTryMove, float DebugDrawDuration, ref FTransformDouble OutTrans);

		// Token: 0x06018944 RID: 100676
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVectorDouble __D_GetSafetyLocation_Internal(IntPtr @this);

		// Token: 0x06018945 RID: 100677
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ConfirmMove_Internal(IntPtr @this);

		// Token: 0x06018946 RID: 100678
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ClimbBlock_Internal(IntPtr @this);

		// Token: 0x06018947 RID: 100679 RVA: 0x0024334B File Offset: 0x0024154B
		static UKuroClimbObject()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroMovement.KuroClimbObject");
		}

		// Token: 0x06018948 RID: 100680 RVA: 0x00243359 File Offset: 0x00241559
		protected UKuroClimbObject(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400D496 RID: 54422
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroMovement.KuroClimbObject";

		// Token: 0x0400D497 RID: 54423
		private static IntPtr _ClassPtr;

		// Token: 0x0400D498 RID: 54424
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
