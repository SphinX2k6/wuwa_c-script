using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000333 RID: 819
	[UnrealObjectPath("/Script/AnimGraphRuntime.KismetAnimationLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKismetAnimationLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002D8C RID: 11660 RVA: 0x00045CFB File Offset: 0x00043EFB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKismetAnimationLibrary._ClassPtr;
		}

		// Token: 0x06002D8D RID: 11661 RVA: 0x00045D08 File Offset: 0x00043F08
		public UKismetAnimationLibrary() : this(BuiltinUtils.AllocNativeUObject(UKismetAnimationLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002D8E RID: 11662 RVA: 0x00045D30 File Offset: 0x00043F30
		[NullableContext(1)]
		public UKismetAnimationLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKismetAnimationLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06002D8F RID: 11663
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void K2_TwoBoneIK(in FVector RootPos, in FVector JointPos, in FVector EndPos, in FVector JointTarget, in FVector Effector, ref FVector OutJointPos, ref FVector OutEndPos, bool bAllowStretching, float StartStretchRatio, float MaxStretchScale);

		// Token: 0x06002D90 RID: 11664
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void K2_StartProfilingTimer();

		// Token: 0x06002D91 RID: 11665
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVector K2_MakePerlinNoiseVectorAndRemap(float X, float Y, float Z, float RangeOutMinX, float RangeOutMaxX, float RangeOutMinY, float RangeOutMaxY, float RangeOutMinZ, float RangeOutMaxZ);

		// Token: 0x06002D92 RID: 11666
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float K2_MakePerlinNoiseAndRemap(float Value, float RangeOutMin, float RangeOutMax);

		// Token: 0x06002D93 RID: 11667 RVA: 0x00045D64 File Offset: 0x00043F64
		public unsafe static FTransform K2_LookAt(in FTransform CurrentTransform, in FVector TargetPosition, FVector LookAtVector, bool bUseUpVector, FVector UpVector, float ClampConeInDegree)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = CurrentTransform;
			return UKismetAnimationLibrary.__K2_LookAt_Internal(uintPtr, TargetPosition, LookAtVector, bUseUpVector, UpVector, ClampConeInDegree);
		}

		// Token: 0x06002D94 RID: 11668 RVA: 0x00045D98 File Offset: 0x00043F98
		[NullableContext(1)]
		public unsafe static float K2_EndProfilingTimer(bool bLog = true, string LogPrefix = "")
		{
			FString fstring = FString.AllocTemp(LogPrefix);
			float result = UKismetAnimationLibrary.__K2_EndProfilingTimer_Internal(bLog, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06002D95 RID: 11669 RVA: 0x00045DC0 File Offset: 0x00043FC0
		[NullableContext(2)]
		public static float K2_DistanceBetweenTwoSocketsAndMapRange(USkeletalMeshComponent Component, FName SocketOrBoneNameA, ERelativeTransformSpace SocketSpaceA, FName SocketOrBoneNameB, ERelativeTransformSpace SocketSpaceB, bool bRemapRange, float InRangeMin, float InRangeMax, float OutRangeMin, float OutRangeMax)
		{
			return UKismetAnimationLibrary.__K2_DistanceBetweenTwoSocketsAndMapRange_Internal((Component != null) ? Component.NativePtr : IntPtr.Zero, SocketOrBoneNameA, SocketSpaceA, SocketOrBoneNameB, SocketSpaceB, bRemapRange, InRangeMin, InRangeMax, OutRangeMin, OutRangeMax);
		}

		// Token: 0x06002D96 RID: 11670 RVA: 0x00045DFB File Offset: 0x00043FFB
		[NullableContext(2)]
		public static FVector K2_DirectionBetweenSockets(USkeletalMeshComponent Component, FName SocketOrBoneNameFrom, FName SocketOrBoneNameTo)
		{
			return UKismetAnimationLibrary.__K2_DirectionBetweenSockets_Internal((Component != null) ? Component.NativePtr : IntPtr.Zero, SocketOrBoneNameFrom, SocketOrBoneNameTo);
		}

		// Token: 0x06002D97 RID: 11671 RVA: 0x00045E14 File Offset: 0x00044014
		[NullableContext(2)]
		public static float K2_CalculateVelocityFromSockets(float DeltaSeconds, USkeletalMeshComponent Component, FName SocketOrBoneName, FName ReferenceSocketOrBone, ERelativeTransformSpace SocketSpace, FVector OffsetInBoneSpace, ref FPositionHistory History, int NumberOfSamples, float VelocityMin, float VelocityMax, EEasingFuncType EasingType, in FRuntimeFloatCurve CustomCurve)
		{
			return UKismetAnimationLibrary.__K2_CalculateVelocityFromSockets_Internal(DeltaSeconds, (Component != null) ? Component.NativePtr : IntPtr.Zero, SocketOrBoneName, ReferenceSocketOrBone, SocketSpace, OffsetInBoneSpace, (History ?? new FPositionHistory()).NativePtr, NumberOfSamples, VelocityMin, VelocityMax, EasingType, (CustomCurve ?? new FRuntimeFloatCurve()).NativePtr);
		}

		// Token: 0x06002D98 RID: 11672 RVA: 0x00045E6C File Offset: 0x0004406C
		[NullableContext(2)]
		public static float K2_CalculateVelocityFromPositionHistory(float DeltaSeconds, FVector Position, ref FPositionHistory History, int NumberOfSamples, float VelocityMin, float VelocityMax)
		{
			return UKismetAnimationLibrary.__K2_CalculateVelocityFromPositionHistory_Internal(DeltaSeconds, Position, (History ?? new FPositionHistory()).NativePtr, NumberOfSamples, VelocityMin, VelocityMax);
		}

		// Token: 0x06002D99 RID: 11673
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FTransform __K2_LookAt_Internal(in FTransform CurrentTransform, in FVector TargetPosition, FVector LookAtVector, bool bUseUpVector, FVector UpVector, float ClampConeInDegree);

		// Token: 0x06002D9A RID: 11674
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_EndProfilingTimer_Internal(bool bLog, in FString LogPrefix);

		// Token: 0x06002D9B RID: 11675
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_DistanceBetweenTwoSocketsAndMapRange_Internal(IntPtr Component, FName SocketOrBoneNameA, TEnumAsByte<ERelativeTransformSpace> SocketSpaceA, FName SocketOrBoneNameB, TEnumAsByte<ERelativeTransformSpace> SocketSpaceB, bool bRemapRange, float InRangeMin, float InRangeMax, float OutRangeMin, float OutRangeMax);

		// Token: 0x06002D9C RID: 11676
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector __K2_DirectionBetweenSockets_Internal(IntPtr Component, FName SocketOrBoneNameFrom, FName SocketOrBoneNameTo);

		// Token: 0x06002D9D RID: 11677
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_CalculateVelocityFromSockets_Internal(float DeltaSeconds, IntPtr Component, FName SocketOrBoneName, FName ReferenceSocketOrBone, TEnumAsByte<ERelativeTransformSpace> SocketSpace, FVector OffsetInBoneSpace, IntPtr History, int NumberOfSamples, float VelocityMin, float VelocityMax, EEasingFuncType EasingType, IntPtr CustomCurve);

		// Token: 0x06002D9E RID: 11678
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __K2_CalculateVelocityFromPositionHistory_Internal(float DeltaSeconds, FVector Position, IntPtr History, int NumberOfSamples, float VelocityMin, float VelocityMax);

		// Token: 0x06002D9F RID: 11679 RVA: 0x00045E8A File Offset: 0x0004408A
		static UKismetAnimationLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AnimGraphRuntime.KismetAnimationLibrary");
		}

		// Token: 0x06002DA0 RID: 11680 RVA: 0x00045E98 File Offset: 0x00044098
		protected UKismetAnimationLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04001381 RID: 4993
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AnimGraphRuntime.KismetAnimationLibrary";

		// Token: 0x04001382 RID: 4994
		private static IntPtr _ClassPtr;

		// Token: 0x04001383 RID: 4995
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
