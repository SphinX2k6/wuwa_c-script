using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020018CA RID: 6346
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroGameplay.KuroEffectLibrary")]
	[UnrealStructLayout(48, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 48)]
	public class UKuroEffectLibrary : UBlueprintFunctionLibrary, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06017725 RID: 96037 RVA: 0x00224B30 File Offset: 0x00222D30
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroEffectLibrary._ClassPtr;
		}

		// Token: 0x06017726 RID: 96038 RVA: 0x00224B3C File Offset: 0x00222D3C
		public UKuroEffectLibrary() : this(BuiltinUtils.AllocNativeUObject(UKuroEffectLibrary.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06017727 RID: 96039 RVA: 0x00224B64 File Offset: 0x00222D64
		[NullableContext(1)]
		public UKuroEffectLibrary(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroEffectLibrary.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06017728 RID: 96040 RVA: 0x00224B98 File Offset: 0x00222D98
		public static FVector2D UpdateEffectModelPostProcessSpec(UEffectModelPostProcess EffectModelPostProcess, UKuroPostProcessComponent PostProcessComponent, bool bForceUpdate, float Time, APlayerController Controller, ACharacter Character, AActor EffectActor, FVector2D LastScreenUV)
		{
			return UKuroEffectLibrary.__UpdateEffectModelPostProcessSpec_Internal((EffectModelPostProcess != null) ? EffectModelPostProcess.NativePtr : IntPtr.Zero, (PostProcessComponent != null) ? PostProcessComponent.NativePtr : IntPtr.Zero, bForceUpdate, Time, (Controller != null) ? Controller.NativePtr : IntPtr.Zero, (Character != null) ? Character.NativePtr : IntPtr.Zero, (EffectActor != null) ? EffectActor.NativePtr : IntPtr.Zero, LastScreenUV);
		}

		// Token: 0x06017729 RID: 96041 RVA: 0x00224C04 File Offset: 0x00222E04
		public static void UpdateEffectModelPostProcessMaterial(UEffectModelPostProcess EffectModelPostProcess, UMaterialInstanceDynamic DynMaterial, bool bForceUpdate, float Time)
		{
			UKuroEffectLibrary.__UpdateEffectModelPostProcessMaterial_Internal((EffectModelPostProcess != null) ? EffectModelPostProcess.NativePtr : IntPtr.Zero, (DynMaterial != null) ? DynMaterial.NativePtr : IntPtr.Zero, bForceUpdate, Time);
		}

		// Token: 0x0601772A RID: 96042 RVA: 0x00224C2D File Offset: 0x00222E2D
		public static void UpdateEffectModelNiagaraSpec(UEffectModelNiagara EffectModelNiagara, UNiagaraComponent NiagaraComponent, bool bForceUpdate, float Time, int ExtraState = -1)
		{
			UKuroEffectLibrary.__UpdateEffectModelNiagaraSpec_Internal((EffectModelNiagara != null) ? EffectModelNiagara.NativePtr : IntPtr.Zero, (NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero, bForceUpdate, Time, ExtraState);
		}

		// Token: 0x0601772B RID: 96043 RVA: 0x00224C58 File Offset: 0x00222E58
		public static void UpdateEffectModelLightSpec(UEffectModelLight EffectModelLight, UPointLightComponent LightComponent, bool bForceUpdate, float Time, float DefaultMaxLightRadius)
		{
			UKuroEffectLibrary.__UpdateEffectModelLightSpec_Internal((EffectModelLight != null) ? EffectModelLight.NativePtr : IntPtr.Zero, (LightComponent != null) ? LightComponent.NativePtr : IntPtr.Zero, bForceUpdate, Time, DefaultMaxLightRadius);
		}

		// Token: 0x0601772C RID: 96044 RVA: 0x00224C83 File Offset: 0x00222E83
		public static void SetOnSystemPausedDelegate(in FOnSystemPausedDelegate Delegate)
		{
			FOnSystemPausedDelegate fonSystemPausedDelegate = Delegate;
			UKuroEffectLibrary.__SetOnSystemPausedDelegate_Internal((fonSystemPausedDelegate != null) ? fonSystemPausedDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601772D RID: 96045 RVA: 0x00224C99 File Offset: 0x00222E99
		public static void SetOnSystemFinishedDelegate(in FOnSystemFinishedDelegate Delegate)
		{
			FOnSystemFinishedDelegate fonSystemFinishedDelegate = Delegate;
			UKuroEffectLibrary.__SetOnSystemFinishedDelegate_Internal((fonSystemFinishedDelegate != null) ? fonSystemFinishedDelegate.NativePtr : ((IntPtr)0));
		}

		// Token: 0x0601772E RID: 96046 RVA: 0x00224CAF File Offset: 0x00222EAF
		public static void SetNiagaraSimulationMinDeltaTime(UNiagaraComponent NiagaraComponent, float MinDeltaTime)
		{
			UKuroEffectLibrary.__SetNiagaraSimulationMinDeltaTime_Internal((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero, MinDeltaTime);
		}

		// Token: 0x0601772F RID: 96047 RVA: 0x00224CC7 File Offset: 0x00222EC7
		public static bool SetNiagaraFrameDeltaTime(UNiagaraComponent NiagaraComponent, float DeltaTime)
		{
			return UKuroEffectLibrary.__SetNiagaraFrameDeltaTime_Internal((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero, DeltaTime);
		}

		// Token: 0x06017730 RID: 96048 RVA: 0x00224CDF File Offset: 0x00222EDF
		public static void SetEffectActorSpawnInUIScene(AActor Actor, bool Value, bool Immediately)
		{
			UKuroEffectLibrary.__SetEffectActorSpawnInUIScene_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, Value, Immediately);
		}

		// Token: 0x06017731 RID: 96049 RVA: 0x00224CF8 File Offset: 0x00222EF8
		public static void RegisterOnSystemPaused(UNiagaraComponent NiagaraComponent)
		{
			UKuroEffectLibrary.__RegisterOnSystemPaused_Internal((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017732 RID: 96050 RVA: 0x00224D0F File Offset: 0x00222F0F
		public static void RegisterOnSystemFinished(UNiagaraComponent NiagaraComponent)
		{
			UKuroEffectLibrary.__RegisterOnSystemFinished_Internal((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017733 RID: 96051 RVA: 0x00224D26 File Offset: 0x00222F26
		public static bool IsNiagaraComponentHasBound(UNiagaraComponent NiagaraComponent, float Threshold = 0f)
		{
			return UKuroEffectLibrary.__IsNiagaraComponentHasBound_Internal((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero, Threshold);
		}

		// Token: 0x06017734 RID: 96052
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern bool IsEffectSystemInEditorNoPIE();

		// Token: 0x06017735 RID: 96053 RVA: 0x00224D3E File Offset: 0x00222F3E
		public static void InitModelNiagaraSpec(UNiagaraComponent NiagaraComponent, bool bUIScene, bool bReceivesDecals, int TranslucencySortPriority)
		{
			UKuroEffectLibrary.__InitModelNiagaraSpec_Internal((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero, bUIScene, bReceivesDecals, TranslucencySortPriority);
		}

		// Token: 0x06017736 RID: 96054
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetNpcDisappearDistance();

		// Token: 0x06017737 RID: 96055 RVA: 0x00224D58 File Offset: 0x00222F58
		public static EKuroNiagaraEffectRegularType GetNiagaraSystemEffectRegularType(UNiagaraSystem NiagaraSystem)
		{
			return UKuroEffectLibrary.__GetNiagaraSystemEffectRegularType_Internal((NiagaraSystem != null) ? NiagaraSystem.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06017738 RID: 96056
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern int GetNiagaraQualityLevel();

		// Token: 0x06017739 RID: 96057
		[MethodImpl(MethodImplOptions.InternalCall)]
		public static extern float GetNiagaraEffectRegularTypeScalabilitySettingsMaxDistance(EKuroNiagaraEffectRegularType EffectRegularType);

		// Token: 0x0601773A RID: 96058 RVA: 0x00224D6F File Offset: 0x00222F6F
		public static USceneComponent GetActorDefaultAttachComponent(AActor Actor)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(UKuroEffectLibrary.__GetActorDefaultAttachComponent_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero));
		}

		// Token: 0x0601773B RID: 96059 RVA: 0x00224D8B File Offset: 0x00222F8B
		public static bool EqualWorld(UWorld World, UWorld Other)
		{
			return UKuroEffectLibrary.__EqualWorld_Internal((World != null) ? World.NativePtr : IntPtr.Zero, (Other != null) ? Other.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601773C RID: 96060 RVA: 0x00224DB2 File Offset: 0x00222FB2
		public static void DeactivateImmediateNiagaraComponent(UNiagaraComponent NiagaraComponent)
		{
			UKuroEffectLibrary.__DeactivateImmediateNiagaraComponent_Internal((NiagaraComponent != null) ? NiagaraComponent.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601773D RID: 96061 RVA: 0x00224DCC File Offset: 0x00222FCC
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

		// Token: 0x0601773E RID: 96062 RVA: 0x00224E0C File Offset: 0x0022300C
		public unsafe static USceneComponent AddSceneComponentWithTransform(AActor Actor, UClassStackOnlyPtr Class, USceneComponent Parent, bool bDeferredFinish, FTransform Transform)
		{
			ref FTransform ptr = (UIntPtr)((ulong)stackalloc byte[(UIntPtr)63] + 15UL & 18446744073709551600UL);
			ptr = Transform;
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(UKuroEffectLibrary.__AddSceneComponentWithTransform_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, Class._NativePtr, (Parent != null) ? Parent.NativePtr : IntPtr.Zero, bDeferredFinish, ptr));
		}

		// Token: 0x0601773F RID: 96063 RVA: 0x00224E63 File Offset: 0x00223063
		public static USceneComponent AddSceneComponent(AActor Actor, UClassStackOnlyPtr Class, USceneComponent Parent, bool bDeferredFinish)
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USceneComponent>(UKuroEffectLibrary.__AddSceneComponent_Internal((Actor != null) ? Actor.NativePtr : IntPtr.Zero, Class._NativePtr, (Parent != null) ? Parent.NativePtr : IntPtr.Zero, bDeferredFinish));
		}

		// Token: 0x06017740 RID: 96064
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FVector2D __UpdateEffectModelPostProcessSpec_Internal(IntPtr EffectModelPostProcess, IntPtr PostProcessComponent, bool bForceUpdate, float Time, IntPtr Controller, IntPtr Character, IntPtr EffectActor, FVector2D LastScreenUV);

		// Token: 0x06017741 RID: 96065
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateEffectModelPostProcessMaterial_Internal(IntPtr EffectModelPostProcess, IntPtr DynMaterial, bool bForceUpdate, float Time);

		// Token: 0x06017742 RID: 96066
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateEffectModelNiagaraSpec_Internal(IntPtr EffectModelNiagara, IntPtr NiagaraComponent, bool bForceUpdate, float Time, int ExtraState);

		// Token: 0x06017743 RID: 96067
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateEffectModelLightSpec_Internal(IntPtr EffectModelLight, IntPtr LightComponent, bool bForceUpdate, float Time, float DefaultMaxLightRadius);

		// Token: 0x06017744 RID: 96068
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOnSystemPausedDelegate_Internal(IntPtr Delegate);

		// Token: 0x06017745 RID: 96069
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOnSystemFinishedDelegate_Internal(IntPtr Delegate);

		// Token: 0x06017746 RID: 96070
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetNiagaraSimulationMinDeltaTime_Internal(IntPtr NiagaraComponent, float MinDeltaTime);

		// Token: 0x06017747 RID: 96071
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetNiagaraFrameDeltaTime_Internal(IntPtr NiagaraComponent, float DeltaTime);

		// Token: 0x06017748 RID: 96072
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEffectActorSpawnInUIScene_Internal(IntPtr Actor, bool Value, bool Immediately);

		// Token: 0x06017749 RID: 96073
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterOnSystemPaused_Internal(IntPtr NiagaraComponent);

		// Token: 0x0601774A RID: 96074
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RegisterOnSystemFinished_Internal(IntPtr NiagaraComponent);

		// Token: 0x0601774B RID: 96075
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsNiagaraComponentHasBound_Internal(IntPtr NiagaraComponent, float Threshold);

		// Token: 0x0601774C RID: 96076
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitModelNiagaraSpec_Internal(IntPtr NiagaraComponent, bool bUIScene, bool bReceivesDecals, int TranslucencySortPriority);

		// Token: 0x0601774D RID: 96077
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern EKuroNiagaraEffectRegularType __GetNiagaraSystemEffectRegularType_Internal(IntPtr NiagaraSystem);

		// Token: 0x0601774E RID: 96078
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetActorDefaultAttachComponent_Internal(IntPtr Actor);

		// Token: 0x0601774F RID: 96079
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __EqualWorld_Internal(IntPtr World, IntPtr Other);

		// Token: 0x06017750 RID: 96080
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DeactivateImmediateNiagaraComponent_Internal(IntPtr NiagaraComponent);

		// Token: 0x06017751 RID: 96081
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FBox __CalcEffectModelBounds_Internal(in FTransform LocalToWorld, in FString EffectModelAssetPath);

		// Token: 0x06017752 RID: 96082
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddSceneComponentWithTransform_Internal(IntPtr Actor, IntPtr Class, IntPtr Parent, bool bDeferredFinish, in FTransform Transform);

		// Token: 0x06017753 RID: 96083
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __AddSceneComponent_Internal(IntPtr Actor, IntPtr Class, IntPtr Parent, bool bDeferredFinish);

		// Token: 0x06017754 RID: 96084 RVA: 0x00224E96 File Offset: 0x00223096
		static UKuroEffectLibrary()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroGameplay.KuroEffectLibrary");
		}

		// Token: 0x06017755 RID: 96085 RVA: 0x00224EA4 File Offset: 0x002230A4
		protected UKuroEffectLibrary(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400CBFD RID: 52221
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroGameplay.KuroEffectLibrary";

		// Token: 0x0400CBFE RID: 52222
		private static IntPtr _ClassPtr;

		// Token: 0x0400CBFF RID: 52223
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
