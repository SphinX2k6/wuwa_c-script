using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004BA RID: 1210
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetControllerComponent")]
	[UnrealStructLayout(472, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 472)]
	public class UKuroCharWetControllerComponent : UActorComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06006F5F RID: 28511 RVA: 0x000A4C99 File Offset: 0x000A2E99
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroCharWetControllerComponent._ClassPtr;
		}

		// Token: 0x06006F60 RID: 28512 RVA: 0x000A4CA8 File Offset: 0x000A2EA8
		public UKuroCharWetControllerComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroCharWetControllerComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06006F61 RID: 28513 RVA: 0x000A4CD0 File Offset: 0x000A2ED0
		[NullableContext(1)]
		public UKuroCharWetControllerComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroCharWetControllerComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170015B6 RID: 5558
		// (get) Token: 0x06006F62 RID: 28514 RVA: 0x000A4D03 File Offset: 0x000A2F03
		// (set) Token: 0x06006F63 RID: 28515 RVA: 0x000A4D13 File Offset: 0x000A2F13
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

		// Token: 0x170015B7 RID: 5559
		// (get) Token: 0x06006F64 RID: 28516 RVA: 0x000A4D24 File Offset: 0x000A2F24
		// (set) Token: 0x06006F65 RID: 28517 RVA: 0x000A4D38 File Offset: 0x000A2F38
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

		// Token: 0x170015B8 RID: 5560
		// (get) Token: 0x06006F66 RID: 28518 RVA: 0x000A4D4D File Offset: 0x000A2F4D
		// (set) Token: 0x06006F67 RID: 28519 RVA: 0x000A4D61 File Offset: 0x000A2F61
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

		// Token: 0x170015B9 RID: 5561
		// (get) Token: 0x06006F68 RID: 28520 RVA: 0x000A4D76 File Offset: 0x000A2F76
		// (set) Token: 0x06006F69 RID: 28521 RVA: 0x000A4D8A File Offset: 0x000A2F8A
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

		// Token: 0x170015BA RID: 5562
		// (get) Token: 0x06006F6A RID: 28522 RVA: 0x000A4D9F File Offset: 0x000A2F9F
		// (set) Token: 0x06006F6B RID: 28523 RVA: 0x000A4DB3 File Offset: 0x000A2FB3
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

		// Token: 0x170015BB RID: 5563
		// (get) Token: 0x06006F6C RID: 28524 RVA: 0x000A4DC8 File Offset: 0x000A2FC8
		// (set) Token: 0x06006F6D RID: 28525 RVA: 0x000A4DD8 File Offset: 0x000A2FD8
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

		// Token: 0x170015BC RID: 5564
		// (get) Token: 0x06006F6E RID: 28526 RVA: 0x000A4DE9 File Offset: 0x000A2FE9
		// (set) Token: 0x06006F6F RID: 28527 RVA: 0x000A4DF9 File Offset: 0x000A2FF9
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

		// Token: 0x170015BD RID: 5565
		// (get) Token: 0x06006F70 RID: 28528 RVA: 0x000A4E0A File Offset: 0x000A300A
		// (set) Token: 0x06006F71 RID: 28529 RVA: 0x000A4E1A File Offset: 0x000A301A
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

		// Token: 0x170015BE RID: 5566
		// (get) Token: 0x06006F72 RID: 28530 RVA: 0x000A4E2B File Offset: 0x000A302B
		// (set) Token: 0x06006F73 RID: 28531 RVA: 0x000A4E3F File Offset: 0x000A303F
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

		// Token: 0x170015BF RID: 5567
		// (get) Token: 0x06006F74 RID: 28532 RVA: 0x000A4E54 File Offset: 0x000A3054
		// (set) Token: 0x06006F75 RID: 28533 RVA: 0x000A4E68 File Offset: 0x000A3068
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

		// Token: 0x06006F76 RID: 28534 RVA: 0x000A4E7D File Offset: 0x000A307D
		public void UpdateWetMaterials(float MPCValue)
		{
			UKuroCharWetControllerComponent.__UpdateWetMaterials_Internal(base.NativePtr, MPCValue);
		}

		// Token: 0x06006F77 RID: 28535 RVA: 0x000A4E8B File Offset: 0x000A308B
		public void UpdateGlobalCharWetIntensity()
		{
			UKuroCharWetControllerComponent.__UpdateGlobalCharWetIntensity_Internal(base.NativePtr);
		}

		// Token: 0x06006F78 RID: 28536 RVA: 0x000A4E98 File Offset: 0x000A3098
		public void SetCharWetRenderBlackRain(bool bActive)
		{
			UKuroCharWetControllerComponent.__SetCharWetRenderBlackRain_Internal(base.NativePtr, bActive);
		}

		// Token: 0x06006F79 RID: 28537 RVA: 0x000A4EA6 File Offset: 0x000A30A6
		public void RemoveWetMaterials()
		{
			UKuroCharWetControllerComponent.__RemoveWetMaterials_Internal(base.NativePtr);
		}

		// Token: 0x06006F7A RID: 28538 RVA: 0x000A4EB3 File Offset: 0x000A30B3
		public void ManualTick(float DeltaSeconds)
		{
			UKuroCharWetControllerComponent.__ManualTick_Internal(base.NativePtr, DeltaSeconds);
		}

		// Token: 0x06006F7B RID: 28539 RVA: 0x000A4EC1 File Offset: 0x000A30C1
		public bool IsInWaterRange()
		{
			return UKuroCharWetControllerComponent.__IsInWaterRange_Internal(base.NativePtr);
		}

		// Token: 0x06006F7C RID: 28540 RVA: 0x000A4ECE File Offset: 0x000A30CE
		public bool IsInRainAtmosphere()
		{
			return UKuroCharWetControllerComponent.__IsInRainAtmosphere_Internal(base.NativePtr);
		}

		// Token: 0x06006F7D RID: 28541 RVA: 0x000A4EDB File Offset: 0x000A30DB
		public bool IsCharWetFootPrintActive()
		{
			return UKuroCharWetControllerComponent.__IsCharWetFootPrintActive_Internal(base.NativePtr);
		}

		// Token: 0x06006F7E RID: 28542 RVA: 0x000A4EE8 File Offset: 0x000A30E8
		public void InitWetConfig()
		{
			UKuroCharWetControllerComponent.__InitWetConfig_Internal(base.NativePtr);
		}

		// Token: 0x06006F7F RID: 28543 RVA: 0x000A4EF5 File Offset: 0x000A30F5
		public void InitFromOwner(AActor InActor)
		{
			UKuroCharWetControllerComponent.__InitFromOwner_Internal(base.NativePtr, (InActor != null) ? InActor.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06006F80 RID: 28544 RVA: 0x000A4F12 File Offset: 0x000A3112
		public float GetWaterDepth()
		{
			return UKuroCharWetControllerComponent.__GetWaterDepth_Internal(base.NativePtr);
		}

		// Token: 0x06006F81 RID: 28545 RVA: 0x000A4F1F File Offset: 0x000A311F
		public float GetPlayerCharacterLocationZ()
		{
			return UKuroCharWetControllerComponent.__GetPlayerCharacterLocationZ_Internal(base.NativePtr);
		}

		// Token: 0x06006F82 RID: 28546 RVA: 0x000A4F2C File Offset: 0x000A312C
		public void DebugWetValue()
		{
			UKuroCharWetControllerComponent.__DebugWetValue_Internal(base.NativePtr);
		}

		// Token: 0x06006F83 RID: 28547 RVA: 0x000A4F39 File Offset: 0x000A3139
		public bool CheckInit()
		{
			return UKuroCharWetControllerComponent.__CheckInit_Internal(base.NativePtr);
		}

		// Token: 0x06006F84 RID: 28548 RVA: 0x000A4F46 File Offset: 0x000A3146
		public void CaptureMatOriginals()
		{
			UKuroCharWetControllerComponent.__CaptureMatOriginals_Internal(base.NativePtr);
		}

		// Token: 0x06006F85 RID: 28549 RVA: 0x000A4F53 File Offset: 0x000A3153
		public void CancelWetTagState()
		{
			UKuroCharWetControllerComponent.__CancelWetTagState_Internal(base.NativePtr);
		}

		// Token: 0x06006F86 RID: 28550 RVA: 0x000A4F60 File Offset: 0x000A3160
		public void ApplyWetMorphTargets(float Value)
		{
			UKuroCharWetControllerComponent.__ApplyWetMorphTargets_Internal(base.NativePtr, Value);
		}

		// Token: 0x06006F87 RID: 28551 RVA: 0x000A4F6E File Offset: 0x000A316E
		public void AddWetTagState()
		{
			UKuroCharWetControllerComponent.__AddWetTagState_Internal(base.NativePtr);
		}

		// Token: 0x06006F88 RID: 28552
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateWetMaterials_Internal(IntPtr @this, float MPCValue);

		// Token: 0x06006F89 RID: 28553
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __UpdateGlobalCharWetIntensity_Internal(IntPtr @this);

		// Token: 0x06006F8A RID: 28554
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCharWetRenderBlackRain_Internal(IntPtr @this, bool bActive);

		// Token: 0x06006F8B RID: 28555
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RemoveWetMaterials_Internal(IntPtr @this);

		// Token: 0x06006F8C RID: 28556
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ManualTick_Internal(IntPtr @this, float DeltaSeconds);

		// Token: 0x06006F8D RID: 28557
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInWaterRange_Internal(IntPtr @this);

		// Token: 0x06006F8E RID: 28558
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInRainAtmosphere_Internal(IntPtr @this);

		// Token: 0x06006F8F RID: 28559
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsCharWetFootPrintActive_Internal(IntPtr @this);

		// Token: 0x06006F90 RID: 28560
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitWetConfig_Internal(IntPtr @this);

		// Token: 0x06006F91 RID: 28561
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __InitFromOwner_Internal(IntPtr @this, IntPtr InActor);

		// Token: 0x06006F92 RID: 28562
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetWaterDepth_Internal(IntPtr @this);

		// Token: 0x06006F93 RID: 28563
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPlayerCharacterLocationZ_Internal(IntPtr @this);

		// Token: 0x06006F94 RID: 28564
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __DebugWetValue_Internal(IntPtr @this);

		// Token: 0x06006F95 RID: 28565
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CheckInit_Internal(IntPtr @this);

		// Token: 0x06006F96 RID: 28566
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CaptureMatOriginals_Internal(IntPtr @this);

		// Token: 0x06006F97 RID: 28567
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CancelWetTagState_Internal(IntPtr @this);

		// Token: 0x06006F98 RID: 28568
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ApplyWetMorphTargets_Internal(IntPtr @this, float Value);

		// Token: 0x06006F99 RID: 28569
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddWetTagState_Internal(IntPtr @this);

		// Token: 0x06006F9A RID: 28570 RVA: 0x000A4F7B File Offset: 0x000A317B
		static UKuroCharWetControllerComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetControllerComponent");
		}

		// Token: 0x06006F9B RID: 28571 RVA: 0x000A4F89 File Offset: 0x000A3189
		protected UKuroCharWetControllerComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04003028 RID: 12328
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCharWetControllerComponent";

		// Token: 0x04003029 RID: 12329
		private static IntPtr _ClassPtr;

		// Token: 0x0400302A RID: 12330
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400302B RID: 12331
		internal static int __PropertyOffset_bWetStateTagActive;

		// Token: 0x0400302C RID: 12332
		internal static int __PropertyOffset_WetNiagaraSystem;

		// Token: 0x0400302D RID: 12333
		internal static int __PropertyOffset_NiagaraWaterDepthParamName;

		// Token: 0x0400302E RID: 12334
		internal static int __PropertyOffset_NiagaraWetIntensityParamName;

		// Token: 0x0400302F RID: 12335
		internal static int __PropertyOffset_CharacterHalfHeightParamName;

		// Token: 0x04003030 RID: 12336
		internal static int __PropertyOffset_bWetDebugMode;

		// Token: 0x04003031 RID: 12337
		internal static int __PropertyOffset_bWet26Scalar;

		// Token: 0x04003032 RID: 12338
		internal static int __PropertyOffset_bWet27Scalar;

		// Token: 0x04003033 RID: 12339
		internal static int __PropertyOffset_MaterialControllerComponent;

		// Token: 0x04003034 RID: 12340
		internal static int __PropertyOffset_CachedWetNiagaraComponent;
	}
}
