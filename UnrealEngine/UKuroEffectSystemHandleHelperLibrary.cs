using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003EC RID: 1004
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroEffectSystemHandleHelperLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroEffectSystemHandleHelperLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600629B RID: 25243 RVA: 0x0008D018 File Offset: 0x0008B218
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroEffectSystemHandleHelperLibrary._ClassPtr;
		}

		// Token: 0x0600629C RID: 25244 RVA: 0x0008D024 File Offset: 0x0008B224
		public UKuroEffectSystemHandleHelperLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroEffectSystemHandleHelperLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600629D RID: 25245 RVA: 0x0008D04C File Offset: 0x0008B24C
		[NullableContext(1)]
		public UKuroEffectSystemHandleHelperLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroEffectSystemHandleHelperLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600629E RID: 25246
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NiagaraComponentHandle_SetVectorParameter(int Id, in FName ParameterName, in FVector Param);

		// Token: 0x0600629F RID: 25247 RVA: 0x0008D080 File Offset: 0x0008B280
		public unsafe static void NiagaraComponentHandle_SetVariableTypedObject(int Id, in FName InVariableName, UClassStackOnlyPtr TypeClass, UObject Object)
		{
			fixed (FName* ptr = &InVariableName)
			{
				void* ptr2 = (void*)ptr;
				UKuroEffectSystemHandleHelperLibrary.__NiagaraComponentHandle_SetVariableTypedObject_Internal(Id, InVariableName, TypeClass._NativePtr, (Object != null) ? Object.NativePtr : IntPtr.Zero);
			}
		}

		// Token: 0x060062A0 RID: 25248 RVA: 0x0008D0B4 File Offset: 0x0008B2B4
		[NullableContext(1)]
		public unsafe static void NiagaraComponentHandle_SetNiagaraVariableVec3(int Id, string InVariableName, in FVector InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UKuroEffectSystemHandleHelperLibrary.__NiagaraComponentHandle_SetNiagaraVariableVec3_Internal(Id, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060062A1 RID: 25249 RVA: 0x0008D0DC File Offset: 0x0008B2DC
		[NullableContext(1)]
		public unsafe static void NiagaraComponentHandle_SetNiagaraVariableLinearColor(int Id, string InVariableName, in FLinearColor InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UKuroEffectSystemHandleHelperLibrary.__NiagaraComponentHandle_SetNiagaraVariableLinearColor_Internal(Id, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060062A2 RID: 25250 RVA: 0x0008D104 File Offset: 0x0008B304
		[NullableContext(1)]
		public unsafe static void NiagaraComponentHandle_SetNiagaraVariableFloat(int Id, string InVariableName, float InValue)
		{
			FString fstring = FString.AllocTemp(InVariableName);
			UKuroEffectSystemHandleHelperLibrary.__NiagaraComponentHandle_SetNiagaraVariableFloat_Internal(Id, fstring, InValue);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x060062A3 RID: 25251 RVA: 0x0008D12C File Offset: 0x0008B32C
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

		// Token: 0x060062A4 RID: 25252 RVA: 0x0008D180 File Offset: 0x0008B380
		[NullableContext(1)]
		public unsafe static void NiagaraComponentHandle_SetKuroNiagaraEmitterFloatParam(int Id, string InEmitterName, string InVariableName, float InValue)
		{
			FString fstring = FString.AllocTemp(InEmitterName);
			FString fstring2 = FString.AllocTemp(InVariableName);
			UKuroEffectSystemHandleHelperLibrary.__NiagaraComponentHandle_SetKuroNiagaraEmitterFloatParam_Internal(Id, fstring, fstring2, InValue);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x060062A5 RID: 25253 RVA: 0x0008D1B8 File Offset: 0x0008B3B8
		[NullableContext(1)]
		public unsafe static void NiagaraComponentHandle_SetKuroNiagaraEmitterCustomTexture(int Id, string InEmitterName, string InVariableName, [Nullable(2)] UTexture InValue)
		{
			FString fstring = FString.AllocTemp(InEmitterName);
			FString fstring2 = FString.AllocTemp(InVariableName);
			UKuroEffectSystemHandleHelperLibrary.__NiagaraComponentHandle_SetKuroNiagaraEmitterCustomTexture_Internal(Id, fstring, fstring2, (InValue != null) ? InValue.NativePtr : IntPtr.Zero);
			FString.NativeDestruct(&fstring, 1);
			FString.NativeDestruct(&fstring2, 1);
		}

		// Token: 0x060062A6 RID: 25254
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NiagaraComponentHandle_SetIntParameter(int Id, in FName ParameterName, int Param);

		// Token: 0x060062A7 RID: 25255
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NiagaraComponentHandle_SetForceSolo(int Id, bool bForceSolo);

		// Token: 0x060062A8 RID: 25256
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NiagaraComponentHandle_SetFloatParameter(int Id, in FName ParameterName, float Param);

		// Token: 0x060062A9 RID: 25257 RVA: 0x0008D1FF File Offset: 0x0008B3FF
		public static void NiagaraComponentHandle_SetEnviInteractionComp(int Id, UKuroEnviInteractionComponent EIComp)
		{
			UKuroEffectSystemHandleHelperLibrary.__NiagaraComponentHandle_SetEnviInteractionComp_Internal(Id, (EIComp != null) ? EIComp.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060062AA RID: 25258
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NiagaraComponentHandle_SetColorParameter(int Id, in FName ParameterName, in FLinearColor Param);

		// Token: 0x060062AB RID: 25259
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void NiagaraComponentHandle_SetCastShadow(int Id, bool InCastShadow);

		// Token: 0x060062AC RID: 25260
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NiagaraComponentHandle_IsValid(int Id);

		// Token: 0x060062AD RID: 25261
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool NiagaraComponentHandle_GetForceSolo(int Id);

		// Token: 0x060062AE RID: 25262
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ActorHandle_SetActorHiddenInGame(int Id, bool InHiddenInGame);

		// Token: 0x060062AF RID: 25263
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool ActorHandle_K2_SetActorRotation(int Id, in FRotator Rotation, bool bTeleportPhysics);

		// Token: 0x060062B0 RID: 25264 RVA: 0x0008D217 File Offset: 0x0008B417
		public static void ActorHandle_K2_SetActorRelativeRotation(int Id, in FRotator RelativeRotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			UKuroEffectSystemHandleHelperLibrary.__ActorHandle_K2_SetActorRelativeRotation_Internal(Id, RelativeRotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060062B1 RID: 25265
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FRotator ActorHandle_K2_GetActorRotation(int Id);

		// Token: 0x060062B2 RID: 25266 RVA: 0x0008D234 File Offset: 0x0008B434
		public unsafe static void ActorHandle_K2_AttachToComponent(int Id, USceneComponent SceneComponent, in FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies)
		{
			fixed (FName* ptr = &SocketName)
			{
				void* ptr2 = (void*)ptr;
				UKuroEffectSystemHandleHelperLibrary.__ActorHandle_K2_AttachToComponent_Internal(Id, (SceneComponent != null) ? SceneComponent.NativePtr : IntPtr.Zero, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies);
			}
		}

		// Token: 0x060062B3 RID: 25267 RVA: 0x0008D268 File Offset: 0x0008B468
		public unsafe static void ActorHandle_K2_AttachToActor(int Id, AActor Parent, in FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies)
		{
			fixed (FName* ptr = &SocketName)
			{
				void* ptr2 = (void*)ptr;
				UKuroEffectSystemHandleHelperLibrary.__ActorHandle_K2_AttachToActor_Internal(Id, (Parent != null) ? Parent.NativePtr : IntPtr.Zero, SocketName, LocationRule, RotationRule, ScaleRule, bWeldSimulatedBodies);
			}
		}

		// Token: 0x060062B4 RID: 25268 RVA: 0x0008D29C File Offset: 0x0008B49C
		public unsafe static void ActorHandle_K2_AddActorLocalTransform(int Id, in FTransform Transform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			UKuroEffectSystemHandleHelperLibrary.__ActorHandle_K2_AddActorLocalTransform_Internal(Id, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060062B5 RID: 25269
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool ActorHandle_IsValid(int Id);

		// Token: 0x060062B6 RID: 25270
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble ActorHandle_GetActorLocation(int Id);

		// Token: 0x060062B7 RID: 25271
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern void ActorHandle_D_SetActorScale3D(int Id, in FVectorDouble Scale);

		// Token: 0x060062B8 RID: 25272 RVA: 0x0008D2E0 File Offset: 0x0008B4E0
		public unsafe static bool ActorHandle_D_K2_SetActorTransform(int Id, in FTransformDouble InTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = InTransform;
			return UKuroEffectSystemHandleHelperLibrary.__ActorHandle_D_K2_SetActorTransform_Internal(Id, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060062B9 RID: 25273 RVA: 0x0008D324 File Offset: 0x0008B524
		public unsafe static void ActorHandle_D_K2_SetActorRelativeTransform(int Id, in FTransformDouble RelativeTransform, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			ref FTransformDouble ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)79] + 15UL & 18446744073709551600UL);
			ptr = RelativeTransform;
			UKuroEffectSystemHandleHelperLibrary.__ActorHandle_D_K2_SetActorRelativeTransform_Internal(Id, ptr, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060062BA RID: 25274 RVA: 0x0008D367 File Offset: 0x0008B567
		public static void ActorHandle_D_K2_SetActorRelativeLocation(int Id, in FVectorDouble RelativeLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			UKuroEffectSystemHandleHelperLibrary.__ActorHandle_D_K2_SetActorRelativeLocation_Internal(Id, RelativeLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060062BB RID: 25275 RVA: 0x0008D383 File Offset: 0x0008B583
		public static bool ActorHandle_D_K2_SetActorLocationAndRotation(int Id, in FVectorDouble Location, in FRotator Rotation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			return UKuroEffectSystemHandleHelperLibrary.__ActorHandle_D_K2_SetActorLocationAndRotation_Internal(Id, Location, Rotation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060062BC RID: 25276 RVA: 0x0008D3A1 File Offset: 0x0008B5A1
		public static bool ActorHandle_D_K2_SetActorLocation(int Id, in FVectorDouble Location, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			return UKuroEffectSystemHandleHelperLibrary.__ActorHandle_D_K2_SetActorLocation_Internal(Id, Location, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060062BD RID: 25277
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble ActorHandle_D_K2_GetActorLocation(int Id);

		// Token: 0x060062BE RID: 25278 RVA: 0x0008D3BD File Offset: 0x0008B5BD
		public static void ActorHandle_D_K2_AddActorWorldOffset(int Id, in FVectorDouble DeltaLocation, bool bSweep, ref FHitResult SweepHitResult, bool bTeleport)
		{
			UKuroEffectSystemHandleHelperLibrary.__ActorHandle_D_K2_AddActorWorldOffset_Internal(Id, DeltaLocation, bSweep, (SweepHitResult ?? new FHitResult()).NativePtr, bTeleport);
		}

		// Token: 0x060062BF RID: 25279
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern FVectorDouble ActorHandle_D_GetActorScale3D(int Id);

		// Token: 0x060062C0 RID: 25280
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NiagaraComponentHandle_SetVariableTypedObject_Internal(int Id, in FName InVariableName, IntPtr TypeClass, IntPtr Object);

		// Token: 0x060062C1 RID: 25281
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NiagaraComponentHandle_SetNiagaraVariableVec3_Internal(int Id, in FString InVariableName, in FVector InValue);

		// Token: 0x060062C2 RID: 25282
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NiagaraComponentHandle_SetNiagaraVariableLinearColor_Internal(int Id, in FString InVariableName, in FLinearColor InValue);

		// Token: 0x060062C3 RID: 25283
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NiagaraComponentHandle_SetNiagaraVariableFloat_Internal(int Id, in FString InVariableName, float InValue);

		// Token: 0x060062C4 RID: 25284
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NiagaraComponentHandle_SetKuroNiagaraEmitterVectorParam_Internal(int Id, in FString InEmitterName, in FString InVariableName, in FVector4 InValue);

		// Token: 0x060062C5 RID: 25285
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NiagaraComponentHandle_SetKuroNiagaraEmitterFloatParam_Internal(int Id, in FString InEmitterName, in FString InVariableName, float InValue);

		// Token: 0x060062C6 RID: 25286
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NiagaraComponentHandle_SetKuroNiagaraEmitterCustomTexture_Internal(int Id, in FString InEmitterName, in FString InVariableName, IntPtr InValue);

		// Token: 0x060062C7 RID: 25287
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __NiagaraComponentHandle_SetEnviInteractionComp_Internal(int Id, IntPtr EIComp);

		// Token: 0x060062C8 RID: 25288
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActorHandle_K2_SetActorRelativeRotation_Internal(int Id, in FRotator RelativeRotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060062C9 RID: 25289
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActorHandle_K2_AttachToComponent_Internal(int Id, IntPtr SceneComponent, in FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies);

		// Token: 0x060062CA RID: 25290
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActorHandle_K2_AttachToActor_Internal(int Id, IntPtr Parent, in FName SocketName, EAttachmentRule LocationRule, EAttachmentRule RotationRule, EAttachmentRule ScaleRule, bool bWeldSimulatedBodies);

		// Token: 0x060062CB RID: 25291
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActorHandle_K2_AddActorLocalTransform_Internal(int Id, in FTransform Transform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060062CC RID: 25292
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ActorHandle_D_K2_SetActorTransform_Internal(int Id, in FTransformDouble InTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060062CD RID: 25293
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActorHandle_D_K2_SetActorRelativeTransform_Internal(int Id, in FTransformDouble RelativeTransform, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060062CE RID: 25294
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActorHandle_D_K2_SetActorRelativeLocation_Internal(int Id, in FVectorDouble RelativeLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060062CF RID: 25295
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ActorHandle_D_K2_SetActorLocationAndRotation_Internal(int Id, in FVectorDouble Location, in FRotator Rotation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060062D0 RID: 25296
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ActorHandle_D_K2_SetActorLocation_Internal(int Id, in FVectorDouble Location, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060062D1 RID: 25297
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ActorHandle_D_K2_AddActorWorldOffset_Internal(int Id, in FVectorDouble DeltaLocation, bool bSweep, IntPtr SweepHitResult, bool bTeleport);

		// Token: 0x060062D2 RID: 25298 RVA: 0x0008D3D9 File Offset: 0x0008B5D9
		static UKuroEffectSystemHandleHelperLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroEffectSystemHandleHelperLibrary");
		}

		// Token: 0x060062D3 RID: 25299 RVA: 0x0008D3E7 File Offset: 0x0008B5E7
		protected UKuroEffectSystemHandleHelperLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040029C8 RID: 10696
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroEffectSystemHandleHelperLibrary";

		// Token: 0x040029C9 RID: 10697
		private static IntPtr _ClassPtr;

		// Token: 0x040029CA RID: 10698
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
