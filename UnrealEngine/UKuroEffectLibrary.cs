using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020003E5 RID: 997
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroEffectLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroEffectLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600619E RID: 24990 RVA: 0x0008BA10 File Offset: 0x00089C10
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroEffectLibrary._ClassPtr;
		}

		// Token: 0x0600619F RID: 24991 RVA: 0x0008BA1C File Offset: 0x00089C1C
		public UKuroEffectLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroEffectLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060061A0 RID: 24992 RVA: 0x0008BA44 File Offset: 0x00089C44
		[NullableContext(1)]
		public UKuroEffectLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroEffectLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x060061A1 RID: 24993 RVA: 0x0008BA78 File Offset: 0x00089C78
		public static FVector2D UpdateEffectModelPostProcessSpec(UEffectModelPostProcess EffectModelPostProcess, UKuroPostProcessComponent PostProcessComponent, bool bForceUpdate, float Time, APlayerController Controller, ACharacter Character, AActor EffectActor, FVector2D LastScreenUV)
		{
			return UKuroEffectLibrary.__UpdateEffectModelPostProcessSpec_Internal((EffectModelPostProcess != null) ? EffectModelPostProcess.NativePtr : IntPtr.Zero, (PostProcessComponent != null) ? PostProcessComponent.NativePtr : IntPtr.Zero, bForceUpdate, Time, (Controller != null) ? Controller.NativePtr : IntPtr.Zero, (Character != null) ? Character.NativePtr : IntPtr.Zero, (EffectActor != null) ? EffectActor.NativePtr : IntPtr.Zero, LastScreenUV);
		}

		// Token: 0x060061A2 RID: 24994 RVA: 0x0008BAE4 File Offset: 0x00089CE4
		public static void UpdateEffectModelPostProcessMaterial(UEffectModelPostProcess EffectModelPostProcess, UMaterialInstanceDynamic DynMaterial, bool bForceUpdate, float Time)
		{
			UKuroEffectLibrary.__UpdateEffectModelPostProcessMaterial_Internal((EffectModelPostProcess != null) ? EffectModelPostProcess.NativePtr : IntPtr.Zero, (DynMaterial != null) ? DynMaterial.NativePtr : IntPtr.Zero, bForceUpdate, Time);
		}

		// Token: 0x060061A3 RID: 24995 RVA: 0x0008BB0D File Offset: 0x00089D0D
		public static void UpdateEffectModelNiagaraSpec(UEffectModelNiagara EffectModelNiagara, UNiagaraComponent NiagaraComponent, bool bForceUpdate, float Time, int ExtraState = -1)
		{
			UKuroEffectLibrary.__UpdateEffectModelNiagaraSpec_Internal((EffectModelNiagara != null) ? EffectModelNiagara.NativePtr : IntPtr.Zero, (NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero, bForceUpdate, Time, ExtraState);
		}

		// Token: 0x060061A4 RID: 24996 RVA: 0x0008BB38 File Offset: 0x00089D38
		public static void UpdateEffectModelLightSpec(UEffectModelLight EffectModelLight, UPointLightComponent LightComponent, bool bForceUpdate, float Time, float DefaultMaxLightRadius)
		{
			UKuroEffectLibrary.__UpdateEffectModelLightSpec_Internal((EffectModelLight != null) ? EffectModelLight.NativePtr : IntPtr.Zero, (LightComponent != null) ? LightComponent.NativePtr : IntPtr.Zero, bForceUpdate, Time, DefaultMaxLightRadius);
		}

		// Token: 0x060061A5 RID: 24997 RVA: 0x0008BB63 File Offset: 0x00089D63
		public static void SetOnSystemPausedDelegate(in FOnSystemPausedDelegate Delegate)
		{
			FOnSystemPausedDelegate fonSystemPausedDelegate = Delegate;
			UKuroEffectLibrary.__SetOnSystemPausedDelegate_Internal((fonSystemPausedDelegate != null) ? fonSystemPausedDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060061A6 RID: 24998 RVA: 0x0008BB79 File Offset: 0x00089D79
		public static void SetOnSystemFinishedDelegate(in FOnSystemFinishedDelegate Delegate)
		{
			FOnSystemFinishedDelegate fonSystemFinishedDelegate = Delegate;
			UKuroEffectLibrary.__SetOnSystemFinishedDelegate_Internal((fonSystemFinishedDelegate != null) ? fonSystemFinishedDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x060061A7 RID: 24999 RVA: 0x0008BB8F File Offset: 0x00089D8F
		public static void SetNiagaraSimulationMinDeltaTime(UNiagaraComponent NiagaraComponent, float MinDeltaTime)
		{
			UKuroEffectLibrary.__SetNiagaraSimulationMinDeltaTime_Internal((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero, MinDeltaTime);
		}

		// Token: 0x060061A8 RID: 25000 RVA: 0x0008BBA7 File Offset: 0x00089DA7
		public static bool SetNiagaraFrameDeltaTime(UNiagaraComponent NiagaraComponent, float DeltaTime)
		{
			return UKuroEffectLibrary.__SetNiagaraFrameDeltaTime_Internal((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero, DeltaTime);
		}

		// Token: 0x060061A9 RID: 25001 RVA: 0x0008BBBF File Offset: 0x00089DBF
		public static void SetEffectActorSpawnInUIScene(AActor Actor, bool Value, bool Immediately)
		{
			UKuroEffectLibrary.__SetEffectActorSpawnInUIScene_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, Value, Immediately);
		}

		// Token: 0x060061AA RID: 25002 RVA: 0x0008BBD8 File Offset: 0x00089DD8
		public static void RegisterOnSystemPaused(UNiagaraComponent NiagaraComponent)
		{
			UKuroEffectLibrary.__RegisterOnSystemPaused_Internal((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060061AB RID: 25003 RVA: 0x0008BBEF File Offset: 0x00089DEF
		public static void RegisterOnSystemFinished(UNiagaraComponent NiagaraComponent)
		{
			UKuroEffectLibrary.__RegisterOnSystemFinished_Internal((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060061AC RID: 25004 RVA: 0x0008BC06 File Offset: 0x00089E06
		public static bool IsNiagaraComponentHasBound(UNiagaraComponent NiagaraComponent, float Threshold = 0f)
		{
			return UKuroEffectLibrary.__IsNiagaraComponentHasBound_Internal((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero, Threshold);
		}

		// Token: 0x060061AD RID: 25005
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsEffectSystemInEditorNoPIE();

		// Token: 0x060061AE RID: 25006 RVA: 0x0008BC1E File Offset: 0x00089E1E
		public static void InitModelNiagaraSpec(UNiagaraComponent NiagaraComponent, bool bUIScene, bool bReceivesDecals, int TranslucencySortPriority)
		{
			UKuroEffectLibrary.__InitModelNiagaraSpec_Internal((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero, bUIScene, bReceivesDecals, TranslucencySortPriority);
		}

		// Token: 0x060061AF RID: 25007
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetNpcDisappearDistance();

		// Token: 0x060061B0 RID: 25008 RVA: 0x0008BC38 File Offset: 0x00089E38
		public static EKuroNiagaraEffectRegularType GetNiagaraSystemEffectRegularType(UNiagaraSystem NiagaraSystem)
		{
			return UKuroEffectLibrary.__GetNiagaraSystemEffectRegularType_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060061B1 RID: 25009
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetNiagaraQualityLevel();

		// Token: 0x060061B2 RID: 25010
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetNiagaraEffectRegularTypeScalabilitySettingsMaxDistance(EKuroNiagaraEffectRegularType EffectRegularType);

		// Token: 0x060061B3 RID: 25011 RVA: 0x0008BC4F File Offset: 0x00089E4F
		public static USceneComponent GetActorDefaultAttachComponent(AActor Actor)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(UKuroEffectLibrary.__GetActorDefaultAttachComponent_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero));
		}

		// Token: 0x060061B4 RID: 25012 RVA: 0x0008BC6B File Offset: 0x00089E6B
		public static bool EqualWorld(UWorld World, UWorld Other)
		{
			return UKuroEffectLibrary.__EqualWorld_Internal((World != null) ? World.NativePtr : IntPtr.Zero, (Other != null) ? Other.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060061B5 RID: 25013 RVA: 0x0008BC92 File Offset: 0x00089E92
		public static void DeactivateImmediateNiagaraComponent(UNiagaraComponent NiagaraComponent)
		{
			UKuroEffectLibrary.__DeactivateImmediateNiagaraComponent_Internal((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060061B6 RID: 25014 RVA: 0x0008BCAC File Offset: 0x00089EAC
		[NullableContext(1)]
		public unsafe static FBox CalcEffectModelBounds(in FTransform LocalToWorld, string EffectModelAssetPath)
		{
			UIntPtr uintPtr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			*uintPtr = LocalToWorld;
			FString fstring = FString.AllocTemp(EffectModelAssetPath);
			FBox result = UKuroEffectLibrary.__CalcEffectModelBounds_Internal(uintPtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x060061B7 RID: 25015 RVA: 0x0008BCEC File Offset: 0x00089EEC
		public unsafe static USceneComponent AddSceneComponentWithTransform(AActor Actor, UClassStackOnlyPtr Class, USceneComponent Parent, bool bDeferredFinish, FTransform Transform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(UKuroEffectLibrary.__AddSceneComponentWithTransform_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, Class._NativePtr, (Parent != null) ? Parent.NativePtr : IntPtr.Zero, bDeferredFinish, ptr));
		}

		// Token: 0x060061B8 RID: 25016 RVA: 0x0008BD43 File Offset: 0x00089F43
		public static USceneComponent AddSceneComponent(AActor Actor, UClassStackOnlyPtr Class, USceneComponent Parent, bool bDeferredFinish)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(UKuroEffectLibrary.__AddSceneComponent_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, Class._NativePtr, (Parent != null) ? Parent.NativePtr : IntPtr.Zero, bDeferredFinish));
		}

		// Token: 0x060061B9 RID: 25017
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __UpdateEffectModelPostProcessSpec_Internal(IntPtr EffectModelPostProcess, IntPtr PostProcessComponent, bool bForceUpdate, float Time, IntPtr Controller, IntPtr Character, IntPtr EffectActor, FVector2D LastScreenUV);

		// Token: 0x060061BA RID: 25018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateEffectModelPostProcessMaterial_Internal(IntPtr EffectModelPostProcess, IntPtr DynMaterial, bool bForceUpdate, float Time);

		// Token: 0x060061BB RID: 25019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateEffectModelNiagaraSpec_Internal(IntPtr EffectModelNiagara, IntPtr NiagaraComponent, bool bForceUpdate, float Time, int ExtraState);

		// Token: 0x060061BC RID: 25020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateEffectModelLightSpec_Internal(IntPtr EffectModelLight, IntPtr LightComponent, bool bForceUpdate, float Time, float DefaultMaxLightRadius);

		// Token: 0x060061BD RID: 25021
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOnSystemPausedDelegate_Internal(IntPtr Delegate);

		// Token: 0x060061BE RID: 25022
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOnSystemFinishedDelegate_Internal(IntPtr Delegate);

		// Token: 0x060061BF RID: 25023
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraSimulationMinDeltaTime_Internal(IntPtr NiagaraComponent, float MinDeltaTime);

		// Token: 0x060061C0 RID: 25024
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetNiagaraFrameDeltaTime_Internal(IntPtr NiagaraComponent, float DeltaTime);

		// Token: 0x060061C1 RID: 25025
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEffectActorSpawnInUIScene_Internal(IntPtr Actor, bool Value, bool Immediately);

		// Token: 0x060061C2 RID: 25026
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterOnSystemPaused_Internal(IntPtr NiagaraComponent);

		// Token: 0x060061C3 RID: 25027
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterOnSystemFinished_Internal(IntPtr NiagaraComponent);

		// Token: 0x060061C4 RID: 25028
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsNiagaraComponentHasBound_Internal(IntPtr NiagaraComponent, float Threshold);

		// Token: 0x060061C5 RID: 25029
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitModelNiagaraSpec_Internal(IntPtr NiagaraComponent, bool bUIScene, bool bReceivesDecals, int TranslucencySortPriority);

		// Token: 0x060061C6 RID: 25030
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EKuroNiagaraEffectRegularType __GetNiagaraSystemEffectRegularType_Internal(IntPtr NiagaraSystem);

		// Token: 0x060061C7 RID: 25031
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActorDefaultAttachComponent_Internal(IntPtr Actor);

		// Token: 0x060061C8 RID: 25032
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualWorld_Internal(IntPtr World, IntPtr Other);

		// Token: 0x060061C9 RID: 25033
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeactivateImmediateNiagaraComponent_Internal(IntPtr NiagaraComponent);

		// Token: 0x060061CA RID: 25034
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox __CalcEffectModelBounds_Internal(in FTransform LocalToWorld, in FString EffectModelAssetPath);

		// Token: 0x060061CB RID: 25035
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddSceneComponentWithTransform_Internal(IntPtr Actor, IntPtr Class, IntPtr Parent, bool bDeferredFinish, in FTransform Transform);

		// Token: 0x060061CC RID: 25036
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddSceneComponent_Internal(IntPtr Actor, IntPtr Class, IntPtr Parent, bool bDeferredFinish);

		// Token: 0x060061CD RID: 25037 RVA: 0x0008BD76 File Offset: 0x00089F76
		static UKuroEffectLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroEffectLibrary");
		}

		// Token: 0x060061CE RID: 25038 RVA: 0x0008BD84 File Offset: 0x00089F84
		protected UKuroEffectLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400299F RID: 10655
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroEffectLibrary";

		// Token: 0x040029A0 RID: 10656
		private static IntPtr _ClassPtr;

		// Token: 0x040029A1 RID: 10657
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
