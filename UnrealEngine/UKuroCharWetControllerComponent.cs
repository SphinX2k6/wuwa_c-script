using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001AC6 RID: 6854
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetControllerComponent")]
	[UnrealStructLayout(472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class UKuroCharWetControllerComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601975A RID: 104282 RVA: 0x0025A1EB File Offset: 0x002583EB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCharWetControllerComponent._ClassPtr;
		}

		// Token: 0x0601975B RID: 104283 RVA: 0x0025A1F8 File Offset: 0x002583F8
		public UKuroCharWetControllerComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroCharWetControllerComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601975C RID: 104284 RVA: 0x0025A220 File Offset: 0x00258420
		[NullableContext(1)]
		public UKuroCharWetControllerComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCharWetControllerComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006582 RID: 25986
		// (get) Token: 0x0601975D RID: 104285 RVA: 0x0025A253 File Offset: 0x00258453
		// (set) Token: 0x0601975E RID: 104286 RVA: 0x0025A267 File Offset: 0x00258467
		public unsafe UKuroCharWetControllerConfigDataAsset CharWetDataAsset
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroCharWetControllerConfigDataAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCharWetControllerComponent.__PropertyOffset_CharWetDataAsset);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCharWetControllerComponent.__PropertyOffset_CharWetDataAsset, value);
			}
		}

		// Token: 0x17006583 RID: 25987
		// (get) Token: 0x0601975F RID: 104287 RVA: 0x0025A27C File Offset: 0x0025847C
		// (set) Token: 0x06019760 RID: 104288 RVA: 0x0025A28C File Offset: 0x0025848C
		public unsafe bool bWetStateTagActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharWetControllerComponent.__PropertyOffset_bWetStateTagActive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharWetControllerComponent.__PropertyOffset_bWetStateTagActive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006584 RID: 25988
		// (get) Token: 0x06019761 RID: 104289 RVA: 0x0025A29D File Offset: 0x0025849D
		// (set) Token: 0x06019762 RID: 104290 RVA: 0x0025A2B1 File Offset: 0x002584B1
		public unsafe UNiagaraSystem WetNiagaraSystem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCharWetControllerComponent.__PropertyOffset_WetNiagaraSystem);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCharWetControllerComponent.__PropertyOffset_WetNiagaraSystem, value);
			}
		}

		// Token: 0x17006585 RID: 25989
		// (get) Token: 0x06019763 RID: 104291 RVA: 0x0025A2C6 File Offset: 0x002584C6
		// (set) Token: 0x06019764 RID: 104292 RVA: 0x0025A2DA File Offset: 0x002584DA
		public unsafe FName NiagaraWaterDepthParamName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharWetControllerComponent.__PropertyOffset_NiagaraWaterDepthParamName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharWetControllerComponent.__PropertyOffset_NiagaraWaterDepthParamName) = value;
			}
		}

		// Token: 0x17006586 RID: 25990
		// (get) Token: 0x06019765 RID: 104293 RVA: 0x0025A2EF File Offset: 0x002584EF
		// (set) Token: 0x06019766 RID: 104294 RVA: 0x0025A303 File Offset: 0x00258503
		public unsafe FName NiagaraWetIntensityParamName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharWetControllerComponent.__PropertyOffset_NiagaraWetIntensityParamName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharWetControllerComponent.__PropertyOffset_NiagaraWetIntensityParamName) = value;
			}
		}

		// Token: 0x17006587 RID: 25991
		// (get) Token: 0x06019767 RID: 104295 RVA: 0x0025A318 File Offset: 0x00258518
		// (set) Token: 0x06019768 RID: 104296 RVA: 0x0025A32C File Offset: 0x0025852C
		public unsafe FName CharacterHalfHeightParamName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharWetControllerComponent.__PropertyOffset_CharacterHalfHeightParamName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharWetControllerComponent.__PropertyOffset_CharacterHalfHeightParamName) = value;
			}
		}

		// Token: 0x17006588 RID: 25992
		// (get) Token: 0x06019769 RID: 104297 RVA: 0x0025A341 File Offset: 0x00258541
		// (set) Token: 0x0601976A RID: 104298 RVA: 0x0025A351 File Offset: 0x00258551
		public unsafe bool bWetDebugMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharWetControllerComponent.__PropertyOffset_bWetDebugMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharWetControllerComponent.__PropertyOffset_bWetDebugMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006589 RID: 25993
		// (get) Token: 0x0601976B RID: 104299 RVA: 0x0025A362 File Offset: 0x00258562
		// (set) Token: 0x0601976C RID: 104300 RVA: 0x0025A372 File Offset: 0x00258572
		public unsafe float bWet26Scalar
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharWetControllerComponent.__PropertyOffset_bWet26Scalar);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharWetControllerComponent.__PropertyOffset_bWet26Scalar) = value;
			}
		}

		// Token: 0x1700658A RID: 25994
		// (get) Token: 0x0601976D RID: 104301 RVA: 0x0025A383 File Offset: 0x00258583
		// (set) Token: 0x0601976E RID: 104302 RVA: 0x0025A393 File Offset: 0x00258593
		public unsafe float bWet27Scalar
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroCharWetControllerComponent.__PropertyOffset_bWet27Scalar);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroCharWetControllerComponent.__PropertyOffset_bWet27Scalar) = value;
			}
		}

		// Token: 0x1700658B RID: 25995
		// (get) Token: 0x0601976F RID: 104303 RVA: 0x0025A3A4 File Offset: 0x002585A4
		// (set) Token: 0x06019770 RID: 104304 RVA: 0x0025A3B8 File Offset: 0x002585B8
		public unsafe UKuroMaterialControllerComponent MaterialControllerComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroMaterialControllerComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCharWetControllerComponent.__PropertyOffset_MaterialControllerComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCharWetControllerComponent.__PropertyOffset_MaterialControllerComponent, value);
			}
		}

		// Token: 0x1700658C RID: 25996
		// (get) Token: 0x06019771 RID: 104305 RVA: 0x0025A3D0 File Offset: 0x002585D0
		// (set) Token: 0x06019772 RID: 104306 RVA: 0x0025A409 File Offset: 0x00258609
		[Nullable(1)]
		public TArray<FCharWetBodyRuntimeConfig> CharWetBodyRuntimeConfigs
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FCharWetBodyRuntimeConfig> result;
				if ((result = this._CharWetBodyRuntimeConfigs) == null)
				{
					result = (this._CharWetBodyRuntimeConfigs = new TArray<FCharWetBodyRuntimeConfig>(base.NativePtr + (IntPtr)UKuroCharWetControllerComponent.__PropertyOffset_CharWetBodyRuntimeConfigs, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.CharWetBodyRuntimeConfigs.CopyAssign(value);
			}
		}

		// Token: 0x1700658D RID: 25997
		// (get) Token: 0x06019773 RID: 104307 RVA: 0x0025A417 File Offset: 0x00258617
		// (set) Token: 0x06019774 RID: 104308 RVA: 0x0025A42B File Offset: 0x0025862B
		public unsafe UNiagaraComponent CachedWetNiagaraComponent
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCharWetControllerComponent.__PropertyOffset_CachedWetNiagaraComponent);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroCharWetControllerComponent.__PropertyOffset_CachedWetNiagaraComponent, value);
			}
		}

		// Token: 0x06019775 RID: 104309 RVA: 0x0025A440 File Offset: 0x00258640
		public void UpdateWetMaterials(float MPCValue)
		{
			UKuroCharWetControllerComponent.__UpdateWetMaterials_Internal(base.NativePtr, MPCValue);
		}

		// Token: 0x06019776 RID: 104310 RVA: 0x0025A44E File Offset: 0x0025864E
		public void UpdateGlobalCharWetIntensity()
		{
			UKuroCharWetControllerComponent.__UpdateGlobalCharWetIntensity_Internal(base.NativePtr);
		}

		// Token: 0x06019777 RID: 104311 RVA: 0x0025A45B File Offset: 0x0025865B
		public void SetCharWetRenderBlackRain(bool bActive)
		{
			UKuroCharWetControllerComponent.__SetCharWetRenderBlackRain_Internal(base.NativePtr, bActive);
		}

		// Token: 0x06019778 RID: 104312 RVA: 0x0025A469 File Offset: 0x00258669
		public void RemoveWetMaterials()
		{
			UKuroCharWetControllerComponent.__RemoveWetMaterials_Internal(base.NativePtr);
		}

		// Token: 0x06019779 RID: 104313 RVA: 0x0025A476 File Offset: 0x00258676
		public void ManualTick(float DeltaSeconds)
		{
			UKuroCharWetControllerComponent.__ManualTick_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x0601977A RID: 104314 RVA: 0x0025A484 File Offset: 0x00258684
		public bool IsInWaterRange()
		{
			return UKuroCharWetControllerComponent.__IsInWaterRange_Internal(base.NativePtr);
		}

		// Token: 0x0601977B RID: 104315 RVA: 0x0025A491 File Offset: 0x00258691
		public bool IsInRainAtmosphere()
		{
			return UKuroCharWetControllerComponent.__IsInRainAtmosphere_Internal(base.NativePtr);
		}

		// Token: 0x0601977C RID: 104316 RVA: 0x0025A49E File Offset: 0x0025869E
		public bool IsCharWetFootPrintActive()
		{
			return UKuroCharWetControllerComponent.__IsCharWetFootPrintActive_Internal(base.NativePtr);
		}

		// Token: 0x0601977D RID: 104317 RVA: 0x0025A4AB File Offset: 0x002586AB
		public void InitWetConfig()
		{
			UKuroCharWetControllerComponent.__InitWetConfig_Internal(base.NativePtr);
		}

		// Token: 0x0601977E RID: 104318 RVA: 0x0025A4B8 File Offset: 0x002586B8
		public void InitFromOwner(AActor InActor)
		{
			UKuroCharWetControllerComponent.__InitFromOwner_Internal(base.NativePtr, (InActor != null) ? InActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0601977F RID: 104319 RVA: 0x0025A4D5 File Offset: 0x002586D5
		public float GetWaterDepth()
		{
			return UKuroCharWetControllerComponent.__GetWaterDepth_Internal(base.NativePtr);
		}

		// Token: 0x06019780 RID: 104320 RVA: 0x0025A4E2 File Offset: 0x002586E2
		public float GetPlayerCharacterLocationZ()
		{
			return UKuroCharWetControllerComponent.__GetPlayerCharacterLocationZ_Internal(base.NativePtr);
		}

		// Token: 0x06019781 RID: 104321 RVA: 0x0025A4EF File Offset: 0x002586EF
		public void DebugWetValue()
		{
			UKuroCharWetControllerComponent.__DebugWetValue_Internal(base.NativePtr);
		}

		// Token: 0x06019782 RID: 104322 RVA: 0x0025A4FC File Offset: 0x002586FC
		public bool CheckInit()
		{
			return UKuroCharWetControllerComponent.__CheckInit_Internal(base.NativePtr);
		}

		// Token: 0x06019783 RID: 104323 RVA: 0x0025A509 File Offset: 0x00258709
		public void CaptureMatOriginals()
		{
			UKuroCharWetControllerComponent.__CaptureMatOriginals_Internal(base.NativePtr);
		}

		// Token: 0x06019784 RID: 104324 RVA: 0x0025A516 File Offset: 0x00258716
		public void CancelWetTagState()
		{
			UKuroCharWetControllerComponent.__CancelWetTagState_Internal(base.NativePtr);
		}

		// Token: 0x06019785 RID: 104325 RVA: 0x0025A523 File Offset: 0x00258723
		public void ApplyWetMorphTargets(float Value)
		{
			UKuroCharWetControllerComponent.__ApplyWetMorphTargets_Internal(base.NativePtr, Value);
		}

		// Token: 0x06019786 RID: 104326 RVA: 0x0025A531 File Offset: 0x00258731
		public void AddWetTagState()
		{
			UKuroCharWetControllerComponent.__AddWetTagState_Internal(base.NativePtr);
		}

		// Token: 0x06019787 RID: 104327
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateWetMaterials_Internal(IntPtr @this, float MPCValue);

		// Token: 0x06019788 RID: 104328
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateGlobalCharWetIntensity_Internal(IntPtr @this);

		// Token: 0x06019789 RID: 104329
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCharWetRenderBlackRain_Internal(IntPtr @this, bool bActive);

		// Token: 0x0601978A RID: 104330
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveWetMaterials_Internal(IntPtr @this);

		// Token: 0x0601978B RID: 104331
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ManualTick_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x0601978C RID: 104332
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInWaterRange_Internal(IntPtr @this);

		// Token: 0x0601978D RID: 104333
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInRainAtmosphere_Internal(IntPtr @this);

		// Token: 0x0601978E RID: 104334
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsCharWetFootPrintActive_Internal(IntPtr @this);

		// Token: 0x0601978F RID: 104335
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitWetConfig_Internal(IntPtr @this);

		// Token: 0x06019790 RID: 104336
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitFromOwner_Internal(IntPtr @this, IntPtr InActor);

		// Token: 0x06019791 RID: 104337
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetWaterDepth_Internal(IntPtr @this);

		// Token: 0x06019792 RID: 104338
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPlayerCharacterLocationZ_Internal(IntPtr @this);

		// Token: 0x06019793 RID: 104339
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugWetValue_Internal(IntPtr @this);

		// Token: 0x06019794 RID: 104340
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CheckInit_Internal(IntPtr @this);

		// Token: 0x06019795 RID: 104341
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CaptureMatOriginals_Internal(IntPtr @this);

		// Token: 0x06019796 RID: 104342
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CancelWetTagState_Internal(IntPtr @this);

		// Token: 0x06019797 RID: 104343
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyWetMorphTargets_Internal(IntPtr @this, float Value);

		// Token: 0x06019798 RID: 104344
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddWetTagState_Internal(IntPtr @this);

		// Token: 0x06019799 RID: 104345 RVA: 0x0025A53E File Offset: 0x0025873E
		static UKuroCharWetControllerComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetControllerComponent");
		}

		// Token: 0x0601979A RID: 104346 RVA: 0x0025A54C File Offset: 0x0025874C
		protected UKuroCharWetControllerComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400DDC8 RID: 56776
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetControllerComponent";

		// Token: 0x0400DDC9 RID: 56777
		private static IntPtr _ClassPtr;

		// Token: 0x0400DDCA RID: 56778
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400DDCB RID: 56779
		internal static int __PropertyOffset_CharWetDataAsset;

		// Token: 0x0400DDCC RID: 56780
		internal static int __PropertyOffset_bWetStateTagActive;

		// Token: 0x0400DDCD RID: 56781
		internal static int __PropertyOffset_WetNiagaraSystem;

		// Token: 0x0400DDCE RID: 56782
		internal static int __PropertyOffset_NiagaraWaterDepthParamName;

		// Token: 0x0400DDCF RID: 56783
		internal static int __PropertyOffset_NiagaraWetIntensityParamName;

		// Token: 0x0400DDD0 RID: 56784
		internal static int __PropertyOffset_CharacterHalfHeightParamName;

		// Token: 0x0400DDD1 RID: 56785
		internal static int __PropertyOffset_bWetDebugMode;

		// Token: 0x0400DDD2 RID: 56786
		internal static int __PropertyOffset_bWet26Scalar;

		// Token: 0x0400DDD3 RID: 56787
		internal static int __PropertyOffset_bWet27Scalar;

		// Token: 0x0400DDD4 RID: 56788
		internal static int __PropertyOffset_MaterialControllerComponent;

		// Token: 0x0400DDD5 RID: 56789
		internal static int __PropertyOffset_CharWetBodyRuntimeConfigs;

		// Token: 0x0400DDD6 RID: 56790
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FCharWetBodyRuntimeConfig> _CharWetBodyRuntimeConfigs;

		// Token: 0x0400DDD7 RID: 56791
		internal static int __PropertyOffset_CachedWetNiagaraComponent;
	}
}
