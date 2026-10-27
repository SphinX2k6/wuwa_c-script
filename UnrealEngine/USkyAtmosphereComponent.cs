using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001114 RID: 4372
	[UnrealObjectPath("/Script/Engine.SkyAtmosphereComponent")]
	[UnrealStructLayout(784, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 784)]
	public class USkyAtmosphereComponent : USceneComponent, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600FE61 RID: 65121 RVA: 0x0017771B File Offset: 0x0017591B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return USkyAtmosphereComponent._ClassPtr;
		}

		// Token: 0x0600FE62 RID: 65122 RVA: 0x00177728 File Offset: 0x00175928
		public USkyAtmosphereComponent() : this(BuiltinUtils.AllocNativeUObject(USkyAtmosphereComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600FE63 RID: 65123 RVA: 0x00177750 File Offset: 0x00175950
		[NullableContext(1)]
		public USkyAtmosphereComponent(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(USkyAtmosphereComponent.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17003E08 RID: 15880
		// (get) Token: 0x0600FE64 RID: 65124 RVA: 0x00177783 File Offset: 0x00175983
		// (set) Token: 0x0600FE65 RID: 65125 RVA: 0x00177793 File Offset: 0x00175993
		public unsafe ESkyAtmosphereTransformMode TransformMode
		{
			get
			{
				return (ESkyAtmosphereTransformMode)(*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_TransformMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_TransformMode) = (byte)value;
			}
		}

		// Token: 0x17003E09 RID: 15881
		// (get) Token: 0x0600FE66 RID: 65126 RVA: 0x001777A4 File Offset: 0x001759A4
		// (set) Token: 0x0600FE67 RID: 65127 RVA: 0x001777B4 File Offset: 0x001759B4
		public unsafe float BottomRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_BottomRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_BottomRadius) = value;
			}
		}

		// Token: 0x17003E0A RID: 15882
		// (get) Token: 0x0600FE68 RID: 65128 RVA: 0x001777C5 File Offset: 0x001759C5
		// (set) Token: 0x0600FE69 RID: 65129 RVA: 0x001777D9 File Offset: 0x001759D9
		public unsafe FColor GroundAlbedo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_GroundAlbedo);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_GroundAlbedo) = value;
			}
		}

		// Token: 0x17003E0B RID: 15883
		// (get) Token: 0x0600FE6A RID: 65130 RVA: 0x001777EE File Offset: 0x001759EE
		// (set) Token: 0x0600FE6B RID: 65131 RVA: 0x001777FE File Offset: 0x001759FE
		public unsafe float AtmosphereHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_AtmosphereHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_AtmosphereHeight) = value;
			}
		}

		// Token: 0x17003E0C RID: 15884
		// (get) Token: 0x0600FE6C RID: 65132 RVA: 0x0017780F File Offset: 0x00175A0F
		// (set) Token: 0x0600FE6D RID: 65133 RVA: 0x0017781F File Offset: 0x00175A1F
		public unsafe float MultiScatteringFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_MultiScatteringFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_MultiScatteringFactor) = value;
			}
		}

		// Token: 0x17003E0D RID: 15885
		// (get) Token: 0x0600FE6E RID: 65134 RVA: 0x00177830 File Offset: 0x00175A30
		// (set) Token: 0x0600FE6F RID: 65135 RVA: 0x00177840 File Offset: 0x00175A40
		public unsafe float TraceSampleCountScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_TraceSampleCountScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_TraceSampleCountScale) = value;
			}
		}

		// Token: 0x17003E0E RID: 15886
		// (get) Token: 0x0600FE70 RID: 65136 RVA: 0x00177851 File Offset: 0x00175A51
		// (set) Token: 0x0600FE71 RID: 65137 RVA: 0x00177861 File Offset: 0x00175A61
		public unsafe float RayleighScatteringScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_RayleighScatteringScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_RayleighScatteringScale) = value;
			}
		}

		// Token: 0x17003E0F RID: 15887
		// (get) Token: 0x0600FE72 RID: 65138 RVA: 0x00177872 File Offset: 0x00175A72
		// (set) Token: 0x0600FE73 RID: 65139 RVA: 0x00177886 File Offset: 0x00175A86
		public unsafe FLinearColor RayleighScattering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_RayleighScattering);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_RayleighScattering) = value;
			}
		}

		// Token: 0x17003E10 RID: 15888
		// (get) Token: 0x0600FE74 RID: 65140 RVA: 0x0017789B File Offset: 0x00175A9B
		// (set) Token: 0x0600FE75 RID: 65141 RVA: 0x001778AB File Offset: 0x00175AAB
		public unsafe float RayleighExponentialDistribution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_RayleighExponentialDistribution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_RayleighExponentialDistribution) = value;
			}
		}

		// Token: 0x17003E11 RID: 15889
		// (get) Token: 0x0600FE76 RID: 65142 RVA: 0x001778BC File Offset: 0x00175ABC
		// (set) Token: 0x0600FE77 RID: 65143 RVA: 0x001778CC File Offset: 0x00175ACC
		public unsafe float MieScatteringScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_MieScatteringScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_MieScatteringScale) = value;
			}
		}

		// Token: 0x17003E12 RID: 15890
		// (get) Token: 0x0600FE78 RID: 65144 RVA: 0x001778DD File Offset: 0x00175ADD
		// (set) Token: 0x0600FE79 RID: 65145 RVA: 0x001778F1 File Offset: 0x00175AF1
		public unsafe FLinearColor MieScattering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_MieScattering);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_MieScattering) = value;
			}
		}

		// Token: 0x17003E13 RID: 15891
		// (get) Token: 0x0600FE7A RID: 65146 RVA: 0x00177906 File Offset: 0x00175B06
		// (set) Token: 0x0600FE7B RID: 65147 RVA: 0x00177916 File Offset: 0x00175B16
		public unsafe float MieAbsorptionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_MieAbsorptionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_MieAbsorptionScale) = value;
			}
		}

		// Token: 0x17003E14 RID: 15892
		// (get) Token: 0x0600FE7C RID: 65148 RVA: 0x00177927 File Offset: 0x00175B27
		// (set) Token: 0x0600FE7D RID: 65149 RVA: 0x0017793B File Offset: 0x00175B3B
		public unsafe FLinearColor MieAbsorption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_MieAbsorption);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_MieAbsorption) = value;
			}
		}

		// Token: 0x17003E15 RID: 15893
		// (get) Token: 0x0600FE7E RID: 65150 RVA: 0x00177950 File Offset: 0x00175B50
		// (set) Token: 0x0600FE7F RID: 65151 RVA: 0x00177960 File Offset: 0x00175B60
		public unsafe float MieAnisotropy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_MieAnisotropy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_MieAnisotropy) = value;
			}
		}

		// Token: 0x17003E16 RID: 15894
		// (get) Token: 0x0600FE80 RID: 65152 RVA: 0x00177971 File Offset: 0x00175B71
		// (set) Token: 0x0600FE81 RID: 65153 RVA: 0x00177981 File Offset: 0x00175B81
		public unsafe float MieExponentialDistribution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_MieExponentialDistribution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_MieExponentialDistribution) = value;
			}
		}

		// Token: 0x17003E17 RID: 15895
		// (get) Token: 0x0600FE82 RID: 65154 RVA: 0x00177992 File Offset: 0x00175B92
		// (set) Token: 0x0600FE83 RID: 65155 RVA: 0x001779A2 File Offset: 0x00175BA2
		public unsafe float OtherAbsorptionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_OtherAbsorptionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_OtherAbsorptionScale) = value;
			}
		}

		// Token: 0x17003E18 RID: 15896
		// (get) Token: 0x0600FE84 RID: 65156 RVA: 0x001779B3 File Offset: 0x00175BB3
		// (set) Token: 0x0600FE85 RID: 65157 RVA: 0x001779C7 File Offset: 0x00175BC7
		public unsafe FLinearColor OtherAbsorption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_OtherAbsorption);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_OtherAbsorption) = value;
			}
		}

		// Token: 0x17003E19 RID: 15897
		// (get) Token: 0x0600FE86 RID: 65158 RVA: 0x001779DC File Offset: 0x00175BDC
		// (set) Token: 0x0600FE87 RID: 65159 RVA: 0x001779F0 File Offset: 0x00175BF0
		public unsafe FTentDistribution OtherTentDistribution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_OtherTentDistribution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_OtherTentDistribution) = value;
			}
		}

		// Token: 0x17003E1A RID: 15898
		// (get) Token: 0x0600FE88 RID: 65160 RVA: 0x00177A05 File Offset: 0x00175C05
		// (set) Token: 0x0600FE89 RID: 65161 RVA: 0x00177A19 File Offset: 0x00175C19
		public unsafe FLinearColor SkyLuminanceFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_SkyLuminanceFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_SkyLuminanceFactor) = value;
			}
		}

		// Token: 0x17003E1B RID: 15899
		// (get) Token: 0x0600FE8A RID: 65162 RVA: 0x00177A2E File Offset: 0x00175C2E
		// (set) Token: 0x0600FE8B RID: 65163 RVA: 0x00177A3E File Offset: 0x00175C3E
		public unsafe float AerialPespectiveViewDistanceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_AerialPespectiveViewDistanceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_AerialPespectiveViewDistanceScale) = value;
			}
		}

		// Token: 0x17003E1C RID: 15900
		// (get) Token: 0x0600FE8C RID: 65164 RVA: 0x00177A4F File Offset: 0x00175C4F
		// (set) Token: 0x0600FE8D RID: 65165 RVA: 0x00177A5F File Offset: 0x00175C5F
		public unsafe float HeightFogContribution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_HeightFogContribution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_HeightFogContribution) = value;
			}
		}

		// Token: 0x17003E1D RID: 15901
		// (get) Token: 0x0600FE8E RID: 65166 RVA: 0x00177A70 File Offset: 0x00175C70
		// (set) Token: 0x0600FE8F RID: 65167 RVA: 0x00177A80 File Offset: 0x00175C80
		public unsafe float TransmittanceMinLightElevationAngle
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_TransmittanceMinLightElevationAngle);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_TransmittanceMinLightElevationAngle) = value;
			}
		}

		// Token: 0x17003E1E RID: 15902
		// (get) Token: 0x0600FE90 RID: 65168 RVA: 0x00177A91 File Offset: 0x00175C91
		// (set) Token: 0x0600FE91 RID: 65169 RVA: 0x00177AA1 File Offset: 0x00175CA1
		public unsafe float AerialPerspectiveStartDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_AerialPerspectiveStartDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_AerialPerspectiveStartDepth) = value;
			}
		}

		// Token: 0x17003E1F RID: 15903
		// (get) Token: 0x0600FE92 RID: 65170 RVA: 0x00177AB2 File Offset: 0x00175CB2
		// (set) Token: 0x0600FE93 RID: 65171 RVA: 0x00177AC6 File Offset: 0x00175CC6
		public unsafe FGuid bStaticLightingBuiltGUID
		{
			get
			{
				return *(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_bStaticLightingBuiltGUID);
			}
			set
			{
				*(base.NativePtr + (IntPtr)USkyAtmosphereComponent.__PropertyOffset_bStaticLightingBuiltGUID) = value;
			}
		}

		// Token: 0x0600FE94 RID: 65172 RVA: 0x00177ADB File Offset: 0x00175CDB
		public void SetSkyLuminanceFactor(FLinearColor NewValue)
		{
			USkyAtmosphereComponent.__SetSkyLuminanceFactor_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600FE95 RID: 65173 RVA: 0x00177AE9 File Offset: 0x00175CE9
		public void SetRayleighScatteringScale(float NewValue)
		{
			USkyAtmosphereComponent.__SetRayleighScatteringScale_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600FE96 RID: 65174 RVA: 0x00177AF7 File Offset: 0x00175CF7
		public void SetRayleighScattering(FLinearColor NewValue)
		{
			USkyAtmosphereComponent.__SetRayleighScattering_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600FE97 RID: 65175 RVA: 0x00177B05 File Offset: 0x00175D05
		public void SetRayleighExponentialDistribution(float NewValue)
		{
			USkyAtmosphereComponent.__SetRayleighExponentialDistribution_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600FE98 RID: 65176 RVA: 0x00177B13 File Offset: 0x00175D13
		public void SetOtherAbsorptionScale(float NewValue)
		{
			USkyAtmosphereComponent.__SetOtherAbsorptionScale_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600FE99 RID: 65177 RVA: 0x00177B21 File Offset: 0x00175D21
		public void SetOtherAbsorption(FLinearColor NewValue)
		{
			USkyAtmosphereComponent.__SetOtherAbsorption_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600FE9A RID: 65178 RVA: 0x00177B2F File Offset: 0x00175D2F
		public void SetMieScatteringScale(float NewValue)
		{
			USkyAtmosphereComponent.__SetMieScatteringScale_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600FE9B RID: 65179 RVA: 0x00177B3D File Offset: 0x00175D3D
		public void SetMieScattering(FLinearColor NewValue)
		{
			USkyAtmosphereComponent.__SetMieScattering_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600FE9C RID: 65180 RVA: 0x00177B4B File Offset: 0x00175D4B
		public void SetMieExponentialDistribution(float NewValue)
		{
			USkyAtmosphereComponent.__SetMieExponentialDistribution_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600FE9D RID: 65181 RVA: 0x00177B59 File Offset: 0x00175D59
		public void SetMieAnisotropy(float NewValue)
		{
			USkyAtmosphereComponent.__SetMieAnisotropy_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600FE9E RID: 65182 RVA: 0x00177B67 File Offset: 0x00175D67
		public void SetMieAbsorptionScale(float NewValue)
		{
			USkyAtmosphereComponent.__SetMieAbsorptionScale_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600FE9F RID: 65183 RVA: 0x00177B75 File Offset: 0x00175D75
		public void SetMieAbsorption(FLinearColor NewValue)
		{
			USkyAtmosphereComponent.__SetMieAbsorption_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600FEA0 RID: 65184 RVA: 0x00177B83 File Offset: 0x00175D83
		public void SetHeightFogContribution(float NewValue)
		{
			USkyAtmosphereComponent.__SetHeightFogContribution_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600FEA1 RID: 65185 RVA: 0x00177B91 File Offset: 0x00175D91
		public void SetGroundRadius(float NewValue)
		{
			USkyAtmosphereComponent.__SetGroundRadius_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600FEA2 RID: 65186 RVA: 0x00177B9F File Offset: 0x00175D9F
		public void SetGroundAlbedo(FLinearColor NewValue, bool SRGB)
		{
			USkyAtmosphereComponent.__SetGroundAlbedo_Internal(base.NativePtr, NewValue, SRGB);
		}

		// Token: 0x0600FEA3 RID: 65187 RVA: 0x00177BAE File Offset: 0x00175DAE
		public void SetAerialPespectiveViewDistanceScale(float NewValue)
		{
			USkyAtmosphereComponent.__SetAerialPespectiveViewDistanceScale_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600FEA4 RID: 65188 RVA: 0x00177BBC File Offset: 0x00175DBC
		public void OverrideAtmosphereLightDirection(int AtmosphereLightIndex, in FVector LightDirection)
		{
			USkyAtmosphereComponent.__OverrideAtmosphereLightDirection_Internal(base.NativePtr, AtmosphereLightIndex, LightDirection);
		}

		// Token: 0x0600FEA5 RID: 65189
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSkyLuminanceFactor_Internal(IntPtr @this, FLinearColor NewValue);

		// Token: 0x0600FEA6 RID: 65190
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRayleighScatteringScale_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600FEA7 RID: 65191
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRayleighScattering_Internal(IntPtr @this, FLinearColor NewValue);

		// Token: 0x0600FEA8 RID: 65192
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRayleighExponentialDistribution_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600FEA9 RID: 65193
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOtherAbsorptionScale_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600FEAA RID: 65194
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOtherAbsorption_Internal(IntPtr @this, FLinearColor NewValue);

		// Token: 0x0600FEAB RID: 65195
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMieScatteringScale_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600FEAC RID: 65196
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMieScattering_Internal(IntPtr @this, FLinearColor NewValue);

		// Token: 0x0600FEAD RID: 65197
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMieExponentialDistribution_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600FEAE RID: 65198
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMieAnisotropy_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600FEAF RID: 65199
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMieAbsorptionScale_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600FEB0 RID: 65200
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMieAbsorption_Internal(IntPtr @this, FLinearColor NewValue);

		// Token: 0x0600FEB1 RID: 65201
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetHeightFogContribution_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600FEB2 RID: 65202
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGroundRadius_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600FEB3 RID: 65203
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetGroundAlbedo_Internal(IntPtr @this, FLinearColor NewValue, bool SRGB);

		// Token: 0x0600FEB4 RID: 65204
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAerialPespectiveViewDistanceScale_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600FEB5 RID: 65205
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OverrideAtmosphereLightDirection_Internal(IntPtr @this, int AtmosphereLightIndex, in FVector LightDirection);

		// Token: 0x0600FEB6 RID: 65206 RVA: 0x00177BCB File Offset: 0x00175DCB
		static USkyAtmosphereComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.SkyAtmosphereComponent");
		}

		// Token: 0x0600FEB7 RID: 65207 RVA: 0x00177BD9 File Offset: 0x00175DD9
		protected USkyAtmosphereComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04008906 RID: 35078
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.SkyAtmosphereComponent";

		// Token: 0x04008907 RID: 35079
		private static IntPtr _ClassPtr;

		// Token: 0x04008908 RID: 35080
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04008909 RID: 35081
		internal static int __PropertyOffset_TransformMode;

		// Token: 0x0400890A RID: 35082
		internal static int __PropertyOffset_BottomRadius;

		// Token: 0x0400890B RID: 35083
		internal static int __PropertyOffset_GroundAlbedo;

		// Token: 0x0400890C RID: 35084
		internal static int __PropertyOffset_AtmosphereHeight;

		// Token: 0x0400890D RID: 35085
		internal static int __PropertyOffset_MultiScatteringFactor;

		// Token: 0x0400890E RID: 35086
		internal static int __PropertyOffset_TraceSampleCountScale;

		// Token: 0x0400890F RID: 35087
		internal static int __PropertyOffset_RayleighScatteringScale;

		// Token: 0x04008910 RID: 35088
		internal static int __PropertyOffset_RayleighScattering;

		// Token: 0x04008911 RID: 35089
		internal static int __PropertyOffset_RayleighExponentialDistribution;

		// Token: 0x04008912 RID: 35090
		internal static int __PropertyOffset_MieScatteringScale;

		// Token: 0x04008913 RID: 35091
		internal static int __PropertyOffset_MieScattering;

		// Token: 0x04008914 RID: 35092
		internal static int __PropertyOffset_MieAbsorptionScale;

		// Token: 0x04008915 RID: 35093
		internal static int __PropertyOffset_MieAbsorption;

		// Token: 0x04008916 RID: 35094
		internal static int __PropertyOffset_MieAnisotropy;

		// Token: 0x04008917 RID: 35095
		internal static int __PropertyOffset_MieExponentialDistribution;

		// Token: 0x04008918 RID: 35096
		internal static int __PropertyOffset_OtherAbsorptionScale;

		// Token: 0x04008919 RID: 35097
		internal static int __PropertyOffset_OtherAbsorption;

		// Token: 0x0400891A RID: 35098
		internal static int __PropertyOffset_OtherTentDistribution;

		// Token: 0x0400891B RID: 35099
		internal static int __PropertyOffset_SkyLuminanceFactor;

		// Token: 0x0400891C RID: 35100
		internal static int __PropertyOffset_AerialPespectiveViewDistanceScale;

		// Token: 0x0400891D RID: 35101
		internal static int __PropertyOffset_HeightFogContribution;

		// Token: 0x0400891E RID: 35102
		internal static int __PropertyOffset_TransmittanceMinLightElevationAngle;

		// Token: 0x0400891F RID: 35103
		internal static int __PropertyOffset_AerialPerspectiveStartDepth;

		// Token: 0x04008920 RID: 35104
		internal static int __PropertyOffset_bStaticLightingBuiltGUID;
	}
}
