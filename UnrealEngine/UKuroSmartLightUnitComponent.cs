using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BC2 RID: 7106
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSmartLightUnitComponent")]
	[UnrealStructLayout(768, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 768)]
	public class UKuroSmartLightUnitComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601B42D RID: 111661 RVA: 0x00282CB2 File Offset: 0x00280EB2
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroSmartLightUnitComponent._ClassPtr;
		}

		// Token: 0x0601B42E RID: 111662 RVA: 0x00282CC0 File Offset: 0x00280EC0
		public UKuroSmartLightUnitComponent() : this(BuiltinUtils.AllocNativeUObject(UKuroSmartLightUnitComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601B42F RID: 111663 RVA: 0x00282CE8 File Offset: 0x00280EE8
		public UKuroSmartLightUnitComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroSmartLightUnitComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17006D83 RID: 28035
		// (get) Token: 0x0601B430 RID: 111664 RVA: 0x00282D1B File Offset: 0x00280F1B
		// (set) Token: 0x0601B431 RID: 111665 RVA: 0x00282D2B File Offset: 0x00280F2B
		public unsafe int LightIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSmartLightUnitComponent.__PropertyOffset_LightIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSmartLightUnitComponent.__PropertyOffset_LightIndex) = value;
			}
		}

		// Token: 0x17006D84 RID: 28036
		// (get) Token: 0x0601B432 RID: 111666 RVA: 0x00282D3C File Offset: 0x00280F3C
		// (set) Token: 0x0601B433 RID: 111667 RVA: 0x00282D4C File Offset: 0x00280F4C
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSmartLightUnitComponent.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSmartLightUnitComponent.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006D85 RID: 28037
		// (get) Token: 0x0601B434 RID: 111668 RVA: 0x00282D60 File Offset: 0x00280F60
		// (set) Token: 0x0601B435 RID: 111669 RVA: 0x00282D99 File Offset: 0x00280F99
		public TArray<ULightComponent> LightComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<ULightComponent> result;
				if ((result = this._LightComponents) == null)
				{
					result = (this._LightComponents = new TArray<ULightComponent>(base.NativePtr + (IntPtr)UKuroSmartLightUnitComponent.__PropertyOffset_LightComponents, this));
				}
				return result;
			}
			set
			{
				this.LightComponents.CopyAssign(value);
			}
		}

		// Token: 0x17006D86 RID: 28038
		// (get) Token: 0x0601B436 RID: 111670 RVA: 0x00282DA8 File Offset: 0x00280FA8
		// (set) Token: 0x0601B437 RID: 111671 RVA: 0x00282DE1 File Offset: 0x00280FE1
		public TArray<UStaticMeshComponent> MeshComponents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UStaticMeshComponent> result;
				if ((result = this._MeshComponents) == null)
				{
					result = (this._MeshComponents = new TArray<UStaticMeshComponent>(base.NativePtr + (IntPtr)UKuroSmartLightUnitComponent.__PropertyOffset_MeshComponents, this));
				}
				return result;
			}
			set
			{
				this.MeshComponents.CopyAssign(value);
			}
		}

		// Token: 0x17006D87 RID: 28039
		// (get) Token: 0x0601B438 RID: 111672 RVA: 0x00282DEF File Offset: 0x00280FEF
		// (set) Token: 0x0601B439 RID: 111673 RVA: 0x00282DFF File Offset: 0x00280FFF
		public unsafe float LightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSmartLightUnitComponent.__PropertyOffset_LightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSmartLightUnitComponent.__PropertyOffset_LightIntensity) = value;
			}
		}

		// Token: 0x17006D88 RID: 28040
		// (get) Token: 0x0601B43A RID: 111674 RVA: 0x00282E10 File Offset: 0x00281010
		// (set) Token: 0x0601B43B RID: 111675 RVA: 0x00282E49 File Offset: 0x00281049
		public TArray<FKuroSmartLightCustomParameterFloat> CustomParameterFloats
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroSmartLightCustomParameterFloat> result;
				if ((result = this._CustomParameterFloats) == null)
				{
					result = (this._CustomParameterFloats = new TArray<FKuroSmartLightCustomParameterFloat>(base.NativePtr + (IntPtr)UKuroSmartLightUnitComponent.__PropertyOffset_CustomParameterFloats, this));
				}
				return result;
			}
			set
			{
				this.CustomParameterFloats.CopyAssign(value);
			}
		}

		// Token: 0x17006D89 RID: 28041
		// (get) Token: 0x0601B43C RID: 111676 RVA: 0x00282E58 File Offset: 0x00281058
		// (set) Token: 0x0601B43D RID: 111677 RVA: 0x00282E91 File Offset: 0x00281091
		public TArray<FKuroSmartLightCustomParameterLinearColor> CustomParameterLinearColors
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroSmartLightCustomParameterLinearColor> result;
				if ((result = this._CustomParameterLinearColors) == null)
				{
					result = (this._CustomParameterLinearColors = new TArray<FKuroSmartLightCustomParameterLinearColor>(base.NativePtr + (IntPtr)UKuroSmartLightUnitComponent.__PropertyOffset_CustomParameterLinearColors, this));
				}
				return result;
			}
			set
			{
				this.CustomParameterLinearColors.CopyAssign(value);
			}
		}

		// Token: 0x17006D8A RID: 28042
		// (get) Token: 0x0601B43E RID: 111678 RVA: 0x00282E9F File Offset: 0x0028109F
		// (set) Token: 0x0601B43F RID: 111679 RVA: 0x00282EAF File Offset: 0x002810AF
		public unsafe float OverrideLightUpTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSmartLightUnitComponent.__PropertyOffset_OverrideLightUpTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSmartLightUnitComponent.__PropertyOffset_OverrideLightUpTime) = value;
			}
		}

		// Token: 0x17006D8B RID: 28043
		// (get) Token: 0x0601B440 RID: 111680 RVA: 0x00282EC0 File Offset: 0x002810C0
		// (set) Token: 0x0601B441 RID: 111681 RVA: 0x00282ED0 File Offset: 0x002810D0
		public unsafe float OverrideLightOffTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroSmartLightUnitComponent.__PropertyOffset_OverrideLightOffTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroSmartLightUnitComponent.__PropertyOffset_OverrideLightOffTime) = value;
			}
		}

		// Token: 0x17006D8C RID: 28044
		// (get) Token: 0x0601B442 RID: 111682 RVA: 0x00282EE4 File Offset: 0x002810E4
		// (set) Token: 0x0601B443 RID: 111683 RVA: 0x00282F1D File Offset: 0x0028111D
		public TMap<ULightComponent, float> OriginalLightIntensities
		{
			get
			{
				base.FastCheckIsValid();
				TMap<ULightComponent, float> result;
				if ((result = this._OriginalLightIntensities) == null)
				{
					result = (this._OriginalLightIntensities = new TMap<ULightComponent, float>(base.NativePtr + (IntPtr)UKuroSmartLightUnitComponent.__PropertyOffset_OriginalLightIntensities, this));
				}
				return result;
			}
			set
			{
				this.OriginalLightIntensities.CopyAssign(value);
			}
		}

		// Token: 0x17006D8D RID: 28045
		// (get) Token: 0x0601B444 RID: 111684 RVA: 0x00282F2C File Offset: 0x0028112C
		// (set) Token: 0x0601B445 RID: 111685 RVA: 0x00282F65 File Offset: 0x00281165
		public TArray<UMaterialInstanceDynamic> DynamicMaterials
		{
			get
			{
				base.FastCheckIsValid();
				TArray<UMaterialInstanceDynamic> result;
				if ((result = this._DynamicMaterials) == null)
				{
					result = (this._DynamicMaterials = new TArray<UMaterialInstanceDynamic>(base.NativePtr + (IntPtr)UKuroSmartLightUnitComponent.__PropertyOffset_DynamicMaterials, this));
				}
				return result;
			}
			set
			{
				this.DynamicMaterials.CopyAssign(value);
			}
		}

		// Token: 0x0601B446 RID: 111686 RVA: 0x00282F73 File Offset: 0x00281173
		public void TurnOn(float FadeInTime)
		{
			UKuroSmartLightUnitComponent.__TurnOn_Internal(base.NativePtr, FadeInTime);
		}

		// Token: 0x0601B447 RID: 111687 RVA: 0x00282F81 File Offset: 0x00281181
		public void TurnOff(float FadeOutTime)
		{
			UKuroSmartLightUnitComponent.__TurnOff_Internal(base.NativePtr, FadeOutTime);
		}

		// Token: 0x0601B448 RID: 111688 RVA: 0x00282F8F File Offset: 0x0028118F
		public void SetLightState(float IntensityScale, float DeltaTime)
		{
			UKuroSmartLightUnitComponent.__SetLightState_Internal(base.NativePtr, IntensityScale, DeltaTime);
		}

		// Token: 0x0601B449 RID: 111689 RVA: 0x00282F9E File Offset: 0x0028119E
		public void RefreshChildComponents()
		{
			UKuroSmartLightUnitComponent.__RefreshChildComponents_Internal(base.NativePtr);
		}

		// Token: 0x0601B44A RID: 111690 RVA: 0x00282FAB File Offset: 0x002811AB
		public bool IsTransitioning()
		{
			return UKuroSmartLightUnitComponent.__IsTransitioning_Internal(base.NativePtr);
		}

		// Token: 0x0601B44B RID: 111691 RVA: 0x00282FB8 File Offset: 0x002811B8
		public bool IsFullyOn()
		{
			return UKuroSmartLightUnitComponent.__IsFullyOn_Internal(base.NativePtr);
		}

		// Token: 0x0601B44C RID: 111692 RVA: 0x00282FC5 File Offset: 0x002811C5
		public bool IsFullyOff()
		{
			return UKuroSmartLightUnitComponent.__IsFullyOff_Internal(base.NativePtr);
		}

		// Token: 0x0601B44D RID: 111693 RVA: 0x00282FD2 File Offset: 0x002811D2
		public float GetTargetIntensityScale()
		{
			return UKuroSmartLightUnitComponent.__GetTargetIntensityScale_Internal(base.NativePtr);
		}

		// Token: 0x0601B44E RID: 111694 RVA: 0x00282FDF File Offset: 0x002811DF
		public string GetDebugInfo()
		{
			return FString.ToStringAndDeleteNativePtr(UKuroSmartLightUnitComponent.__GetDebugInfo_Internal(base.NativePtr));
		}

		// Token: 0x0601B44F RID: 111695 RVA: 0x00282FF1 File Offset: 0x002811F1
		public float GetCurrentIntensityScale()
		{
			return UKuroSmartLightUnitComponent.__GetCurrentIntensityScale_Internal(base.NativePtr);
		}

		// Token: 0x0601B450 RID: 111696 RVA: 0x00282FFE File Offset: 0x002811FE
		public void AddDefaultPointLight()
		{
			UKuroSmartLightUnitComponent.__AddDefaultPointLight_Internal(base.NativePtr);
		}

		// Token: 0x0601B451 RID: 111697 RVA: 0x0028300B File Offset: 0x0028120B
		public void AddDefaultMesh()
		{
			UKuroSmartLightUnitComponent.__AddDefaultMesh_Internal(base.NativePtr);
		}

		// Token: 0x0601B452 RID: 111698
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TurnOn_Internal(IntPtr @this, float FadeInTime);

		// Token: 0x0601B453 RID: 111699
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __TurnOff_Internal(IntPtr @this, float FadeOutTime);

		// Token: 0x0601B454 RID: 111700
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightState_Internal(IntPtr @this, float IntensityScale, float DeltaTime);

		// Token: 0x0601B455 RID: 111701
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RefreshChildComponents_Internal(IntPtr @this);

		// Token: 0x0601B456 RID: 111702
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsTransitioning_Internal(IntPtr @this);

		// Token: 0x0601B457 RID: 111703
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsFullyOn_Internal(IntPtr @this);

		// Token: 0x0601B458 RID: 111704
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsFullyOff_Internal(IntPtr @this);

		// Token: 0x0601B459 RID: 111705
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetTargetIntensityScale_Internal(IntPtr @this);

		// Token: 0x0601B45A RID: 111706
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetDebugInfo_Internal(IntPtr @this);

		// Token: 0x0601B45B RID: 111707
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCurrentIntensityScale_Internal(IntPtr @this);

		// Token: 0x0601B45C RID: 111708
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddDefaultPointLight_Internal(IntPtr @this);

		// Token: 0x0601B45D RID: 111709
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AddDefaultMesh_Internal(IntPtr @this);

		// Token: 0x0601B45E RID: 111710 RVA: 0x00283018 File Offset: 0x00281218
		static UKuroSmartLightUnitComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRenderingRuntimeBPPlugin.KuroSmartLightUnitComponent");
		}

		// Token: 0x0601B45F RID: 111711 RVA: 0x00283026 File Offset: 0x00281226
		protected UKuroSmartLightUnitComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400EAED RID: 60141
		public new const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSmartLightUnitComponent";

		// Token: 0x0400EAEE RID: 60142
		private static IntPtr _ClassPtr;

		// Token: 0x0400EAEF RID: 60143
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400EAF0 RID: 60144
		internal static int __PropertyOffset_LightIndex;

		// Token: 0x0400EAF1 RID: 60145
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x0400EAF2 RID: 60146
		internal static int __PropertyOffset_LightComponents;

		// Token: 0x0400EAF3 RID: 60147
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<ULightComponent> _LightComponents;

		// Token: 0x0400EAF4 RID: 60148
		internal static int __PropertyOffset_MeshComponents;

		// Token: 0x0400EAF5 RID: 60149
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UStaticMeshComponent> _MeshComponents;

		// Token: 0x0400EAF6 RID: 60150
		internal static int __PropertyOffset_LightIntensity;

		// Token: 0x0400EAF7 RID: 60151
		internal static int __PropertyOffset_CustomParameterFloats;

		// Token: 0x0400EAF8 RID: 60152
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroSmartLightCustomParameterFloat> _CustomParameterFloats;

		// Token: 0x0400EAF9 RID: 60153
		internal static int __PropertyOffset_CustomParameterLinearColors;

		// Token: 0x0400EAFA RID: 60154
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroSmartLightCustomParameterLinearColor> _CustomParameterLinearColors;

		// Token: 0x0400EAFB RID: 60155
		internal static int __PropertyOffset_OverrideLightUpTime;

		// Token: 0x0400EAFC RID: 60156
		internal static int __PropertyOffset_OverrideLightOffTime;

		// Token: 0x0400EAFD RID: 60157
		internal static int __PropertyOffset_OriginalLightIntensities;

		// Token: 0x0400EAFE RID: 60158
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<ULightComponent, float> _OriginalLightIntensities;

		// Token: 0x0400EAFF RID: 60159
		internal static int __PropertyOffset_DynamicMaterials;

		// Token: 0x0400EB00 RID: 60160
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<UMaterialInstanceDynamic> _DynamicMaterials;
	}
}
