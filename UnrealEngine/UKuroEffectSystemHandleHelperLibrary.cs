using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018D2 RID: 6354
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroEffectSystemHandleHelperLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroEffectSystemHandleHelperLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017893 RID: 96403 RVA: 0x002275B4 File Offset: 0x002257B4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroEffectSystemHandleHelperLibrary._ClassPtr;
		}

		// Token: 0x06017894 RID: 96404 RVA: 0x002275C0 File Offset: 0x002257C0
		public UKuroEffectSystemHandleHelperLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroEffectSystemHandleHelperLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017895 RID: 96405 RVA: 0x002275E8 File Offset: 0x002257E8
		[NullableContext(1)]
		public UKuroEffectSystemHandleHelperLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroEffectSystemHandleHelperLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017896 RID: 96406
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NiagaraComponentHandle_SetVectorParameter(int Id, in FName ParameterName, in FVector Param);

		// Token: 0x06017897 RID: 96407 RVA: 0x0022761C File Offset: 0x0022581C
		public unsafe static void NiagaraComponentHandle_SetVariableTypedObject(int Id, in FName InVariableName, UClassStackOnlyPtr TypeClass, UObject Object)
		{
			fixed (FName* ptr = &InVariableName)
			{
				void* ptr2 = (void*)ptr;
				UKuroEffectSystemHandleHelperLibrary.__NiagaraComponentHandle_SetVariableTypedObject_Internal(Id, InVariableName, TypeClass._NativePtr, (Object != null) ? Object.NativePtr : IntPtr.Zero);
			}
		}

		// Token: 0x06017898 RID: 96408 RVA: 0x00227650 File Offset: 0x00225850
		[NullableContext(1)]
		public unsafe static void NiagaraComponentHandle_SetNiagaraVariableVec3(int Id, string InVariableName, in FVector InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UKuroEffectSystemHandleHelperLibrary.__NiagaraComponentHandle_SetNiagaraVariableVec3_Internal(Id, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06017899 RID: 96409 RVA: 0x00227678 File Offset: 0x00225878
		[NullableContext(1)]
		public unsafe static void NiagaraComponentHandle_SetNiagaraVariableLinearColor(int Id, string InVariableName, in FLinearColor InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UKuroEffectSystemHandleHelperLibrary.__NiagaraComponentHandle_SetNiagaraVariableLinearColor_Internal(Id, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601789A RID: 96410 RVA: 0x002276A0 File Offset: 0x002258A0
		[NullableContext(1)]
		public unsafe static void NiagaraComponentHandle_SetNiagaraVariableFloat(int Id, string InVariableName, float InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UKuroEffectSystemHandleHelperLibrary.__NiagaraComponentHandle_SetNiagaraVariableFloat_Internal(Id, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0601789B RID: 96411 RVA: 0x002276C8 File Offset: 0x002258C8
		[NullableContext(1)]
		public unsafe static void NiagaraComponentHandle_SetKuroNiagaraEmitterVectorParam(int Id, string InEmitterName, string InVariableName, in FVector4 InValue)
		{
			FString fstring = FString.AllocTemp(InEmitterName);
			FString fstring2 = FString.AllocTemp(InVariableName);
			ref FVector4 ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)31] + 15UL & 18446744073709551600UL);
			ptr = InValue;
			UKuroEffectSystemHandleHelperLibrary.__NiagaraComponentHandle_SetKuroNiagaraEmitterVectorParam_Internal(Id, fstring, fstring2, ptr);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0601789C RID: 96412 RVA: 0x0022771C File Offset: 0x0022591C
		[NullableContext(1)]
		public unsafe static void NiagaraComponentHandle_SetKuroNiagaraEmitterFloatParam(int Id, string InEmitterName, string InVariableName, float InValue)
		{
			FString fstring = FString.AllocTemp(InEmitterName);
			FString fstring2 = FString.AllocTemp(InVariableName);
			UKuroEffectSystemHandleHelperLibrary.__NiagaraComponentHandle_SetKuroNiagaraEmitterFloatParam_Internal(Id, fstring, fstring2, InValue);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0601789D RID: 96413 RVA: 0x00227754 File Offset: 0x00225954
		[NullableContext(1)]
		public unsafe static void NiagaraComponentHandle_SetKuroNiagaraEmitterCustomTexture(int Id, string InEmitterName, string InVariableName, [Nullable(2)] UTexture InValue)
		{
			FString fstring = FString.AllocTemp(InEmitterName);
			FString fstring2 = FString.AllocTemp(InVariableName);
			UKuroEffectSystemHandleHelperLibrary.__NiagaraComponentHandle_SetKuroNiagaraEmitterCustomTexture_Internal(Id, fstring, fstring2, (InValue != null) ? InValue.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x0601789E RID: 96414
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NiagaraComponentHandle_SetIntParameter(int Id, in FName ParameterName, int Param);

		// Token: 0x0601789F RID: 96415
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NiagaraComponentHandle_SetForceSolo(int Id, bool bForceSolo);

		// Token: 0x060178A0 RID: 96416
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NiagaraComponentHandle_SetFloatParameter(int Id, in FName ParameterName, float Param);

		// Token: 0x060178A1 RID: 96417 RVA: 0x0022779B File Offset: 0x0022599B
		public static void NiagaraComponentHandle_SetEnviInteractionComp(int Id, UKuroEnviInteractionComponent EIComp)
		{
			UKuroEffectSystemHandleHelperLibrary.__NiagaraComponentHandle_SetEnviInteractionComp_Internal(Id, (EIComp != null) ? EIComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060178A2 RID: 96418
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NiagaraComponentHandle_SetColorParameter(int Id, in FName ParameterName, in FLinearColor Param);

		// Token: 0x060178A3 RID: 96419
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NiagaraComponentHandle_SetCastShadow(int Id, bool InCastShadow);

		// Token: 0x060178A4 RID: 96420
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NiagaraComponentHandle_IsValid(int Id);

		// Token: 0x060178A5 RID: 96421
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NiagaraComponentHandle_GetForceSolo(int Id);

		// Token: 0x060178A6 RID: 96422
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ActorHandle_SetActorHiddenInGame(int Id, bool InHiddenInGame);

		// Token: 0x060178A7 RID: 96423
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool ActorHandle_K2_SetActorRotation(int Id, in FRotator Rotation, bool bTeleportPhysics);

		// Token: 0x060178A8 RID: 96424 RVA: 0x002277B3 File Offset: 0x002259B3
		public static void ActorHandle_K2_SetActorRelativeRotation(int Id, in FRotator RelativeRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			UKuroEffectSystemHandleHelperLibrary.__ActorHandle_K2_SetActorRelativeRotation_Internal(Id, RelativeRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060178A9 RID: 96425
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator ActorHandle_K2_GetActorRotation(int Id);

		// Token: 0x060178AA RID: 96426 RVA: 0x002277D0 File Offset: 0x002259D0
		public unsafe static void ActorHandle_K2_AttachToComponent(int Id, USceneComponent SceneComponent, in FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies)
		{
			fixed (FName* ptr = &SocketName)
			{
				void* ptr2 = (void*)ptr;
				UKuroEffectSystemHandleHelperLibrary.__ActorHandle_K2_AttachToComponent_Internal(Id, (SceneComponent != null) ? SceneComponent.NativePtr : IntPtr.Zero, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies);
			}
		}

		// Token: 0x060178AB RID: 96427 RVA: 0x00227804 File Offset: 0x00225A04
		public unsafe static void ActorHandle_K2_AttachToActor(int Id, AActor Parent, in FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies)
		{
			fixed (FName* ptr = &SocketName)
			{
				void* ptr2 = (void*)ptr;
				UKuroEffectSystemHandleHelperLibrary.__ActorHandle_K2_AttachToActor_Internal(Id, (Parent != null) ? Parent.NativePtr : IntPtr.Zero, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies);
			}
		}

		// Token: 0x060178AC RID: 96428 RVA: 0x00227838 File Offset: 0x00225A38
		public unsafe static void ActorHandle_K2_AddActorLocalTransform(int Id, in FTransform Transform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			UKuroEffectSystemHandleHelperLibrary.__ActorHandle_K2_AddActorLocalTransform_Internal(Id, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060178AD RID: 96429
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool ActorHandle_IsValid(int Id);

		// Token: 0x060178AE RID: 96430
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble ActorHandle_GetActorLocation(int Id);

		// Token: 0x060178AF RID: 96431
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ActorHandle_D_SetActorScale3D(int Id, in FVectorDouble Scale);

		// Token: 0x060178B0 RID: 96432 RVA: 0x0022787C File Offset: 0x00225A7C
		public unsafe static bool ActorHandle_D_K2_SetActorTransform(int Id, in FTransformDouble InTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = InTransform;
			return UKuroEffectSystemHandleHelperLibrary.__ActorHandle_D_K2_SetActorTransform_Internal(Id, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060178B1 RID: 96433 RVA: 0x002278C0 File Offset: 0x00225AC0
		public unsafe static void ActorHandle_D_K2_SetActorRelativeTransform(int Id, in FTransformDouble RelativeTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = RelativeTransform;
			UKuroEffectSystemHandleHelperLibrary.__ActorHandle_D_K2_SetActorRelativeTransform_Internal(Id, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060178B2 RID: 96434 RVA: 0x00227903 File Offset: 0x00225B03
		public static void ActorHandle_D_K2_SetActorRelativeLocation(int Id, in FVectorDouble RelativeLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			UKuroEffectSystemHandleHelperLibrary.__ActorHandle_D_K2_SetActorRelativeLocation_Internal(Id, RelativeLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060178B3 RID: 96435 RVA: 0x0022791F File Offset: 0x00225B1F
		public static bool ActorHandle_D_K2_SetActorLocationAndRotation(int Id, in FVectorDouble Location, in FRotator Rotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			return UKuroEffectSystemHandleHelperLibrary.__ActorHandle_D_K2_SetActorLocationAndRotation_Internal(Id, Location, Rotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060178B4 RID: 96436 RVA: 0x0022793D File Offset: 0x00225B3D
		public static bool ActorHandle_D_K2_SetActorLocation(int Id, in FVectorDouble Location, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			return UKuroEffectSystemHandleHelperLibrary.__ActorHandle_D_K2_SetActorLocation_Internal(Id, Location, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060178B5 RID: 96437
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble ActorHandle_D_K2_GetActorLocation(int Id);

		// Token: 0x060178B6 RID: 96438 RVA: 0x00227959 File Offset: 0x00225B59
		public static void ActorHandle_D_K2_AddActorWorldOffset(int Id, in FVectorDouble DeltaLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			UKuroEffectSystemHandleHelperLibrary.__ActorHandle_D_K2_AddActorWorldOffset_Internal(Id, DeltaLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060178B7 RID: 96439
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble ActorHandle_D_GetActorScale3D(int Id);

		// Token: 0x060178B8 RID: 96440
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NiagaraComponentHandle_SetVariableTypedObject_Internal(int Id, in FName InVariableName, IntPtr TypeClass, IntPtr Object);

		// Token: 0x060178B9 RID: 96441
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NiagaraComponentHandle_SetNiagaraVariableVec3_Internal(int Id, in FString InVariableName, in FVector InValue);

		// Token: 0x060178BA RID: 96442
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NiagaraComponentHandle_SetNiagaraVariableLinearColor_Internal(int Id, in FString InVariableName, in FLinearColor InValue);

		// Token: 0x060178BB RID: 96443
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NiagaraComponentHandle_SetNiagaraVariableFloat_Internal(int Id, in FString InVariableName, float InValue);

		// Token: 0x060178BC RID: 96444
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NiagaraComponentHandle_SetKuroNiagaraEmitterVectorParam_Internal(int Id, in FString InEmitterName, in FString InVariableName, in FVector4 InValue);

		// Token: 0x060178BD RID: 96445
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NiagaraComponentHandle_SetKuroNiagaraEmitterFloatParam_Internal(int Id, in FString InEmitterName, in FString InVariableName, float InValue);

		// Token: 0x060178BE RID: 96446
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NiagaraComponentHandle_SetKuroNiagaraEmitterCustomTexture_Internal(int Id, in FString InEmitterName, in FString InVariableName, IntPtr InValue);

		// Token: 0x060178BF RID: 96447
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NiagaraComponentHandle_SetEnviInteractionComp_Internal(int Id, IntPtr EIComp);

		// Token: 0x060178C0 RID: 96448
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActorHandle_K2_SetActorRelativeRotation_Internal(int Id, in FRotator RelativeRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060178C1 RID: 96449
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActorHandle_K2_AttachToComponent_Internal(int Id, IntPtr SceneComponent, in FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies);

		// Token: 0x060178C2 RID: 96450
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActorHandle_K2_AttachToActor_Internal(int Id, IntPtr Parent, in FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies);

		// Token: 0x060178C3 RID: 96451
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActorHandle_K2_AddActorLocalTransform_Internal(int Id, in FTransform Transform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060178C4 RID: 96452
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ActorHandle_D_K2_SetActorTransform_Internal(int Id, in FTransformDouble InTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060178C5 RID: 96453
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActorHandle_D_K2_SetActorRelativeTransform_Internal(int Id, in FTransformDouble RelativeTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060178C6 RID: 96454
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActorHandle_D_K2_SetActorRelativeLocation_Internal(int Id, in FVectorDouble RelativeLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060178C7 RID: 96455
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ActorHandle_D_K2_SetActorLocationAndRotation_Internal(int Id, in FVectorDouble Location, in FRotator Rotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060178C8 RID: 96456
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ActorHandle_D_K2_SetActorLocation_Internal(int Id, in FVectorDouble Location, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060178C9 RID: 96457
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActorHandle_D_K2_AddActorWorldOffset_Internal(int Id, in FVectorDouble DeltaLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060178CA RID: 96458 RVA: 0x00227975 File Offset: 0x00225B75
		static UKuroEffectSystemHandleHelperLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroEffectSystemHandleHelperLibrary");
		}

		// Token: 0x060178CB RID: 96459 RVA: 0x00227983 File Offset: 0x00225B83
		protected UKuroEffectSystemHandleHelperLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CC8F RID: 52367
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroEffectSystemHandleHelperLibrary";

		// Token: 0x0400CC90 RID: 52368
		private static IntPtr _ClassPtr;

		// Token: 0x0400CC91 RID: 52369
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
