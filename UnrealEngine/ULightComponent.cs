using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000D45 RID: 3397
	[UnrealObjectPath("/Script/Engine.LightComponent")]
	[UnrealStructLayout(1088, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1088)]
	public abstract class ULightComponent : ULightComponentBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600B61A RID: 46618 RVA: 0x00103B35 File Offset: 0x00101D35
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULightComponent._ClassPtr;
		}

		// Token: 0x1700299C RID: 10652
		// (get) Token: 0x0600B61B RID: 46619 RVA: 0x00103B41 File Offset: 0x00101D41
		// (set) Token: 0x0600B61C RID: 46620 RVA: 0x00103B51 File Offset: 0x00101D51
		public unsafe float Temperature
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_Temperature);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_Temperature) = value;
			}
		}

		// Token: 0x1700299D RID: 10653
		// (get) Token: 0x0600B61D RID: 46621 RVA: 0x00103B62 File Offset: 0x00101D62
		// (set) Token: 0x0600B61E RID: 46622 RVA: 0x00103B76 File Offset: 0x00101D76
		public unsafe TEnumAsByte<ELightDistanceCullType> LightDistanceCullType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_LightDistanceCullType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_LightDistanceCullType) = value;
			}
		}

		// Token: 0x1700299E RID: 10654
		// (get) Token: 0x0600B61F RID: 46623 RVA: 0x00103B8B File Offset: 0x00101D8B
		// (set) Token: 0x0600B620 RID: 46624 RVA: 0x00103B9B File Offset: 0x00101D9B
		public unsafe float MinDrawDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_MinDrawDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_MinDrawDistance) = value;
			}
		}

		// Token: 0x1700299F RID: 10655
		// (get) Token: 0x0600B621 RID: 46625 RVA: 0x00103BAC File Offset: 0x00101DAC
		// (set) Token: 0x0600B622 RID: 46626 RVA: 0x00103BBC File Offset: 0x00101DBC
		public unsafe float MaxDrawDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_MaxDrawDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_MaxDrawDistance) = value;
			}
		}

		// Token: 0x170029A0 RID: 10656
		// (get) Token: 0x0600B623 RID: 46627 RVA: 0x00103BCD File Offset: 0x00101DCD
		// (set) Token: 0x0600B624 RID: 46628 RVA: 0x00103BDD File Offset: 0x00101DDD
		public unsafe float MinDistanceFadeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_MinDistanceFadeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_MinDistanceFadeRange) = value;
			}
		}

		// Token: 0x170029A1 RID: 10657
		// (get) Token: 0x0600B625 RID: 46629 RVA: 0x00103BEE File Offset: 0x00101DEE
		// (set) Token: 0x0600B626 RID: 46630 RVA: 0x00103BFE File Offset: 0x00101DFE
		public unsafe float MaxDistanceFadeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_MaxDistanceFadeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_MaxDistanceFadeRange) = value;
			}
		}

		// Token: 0x170029A2 RID: 10658
		// (get) Token: 0x0600B627 RID: 46631 RVA: 0x00103C0F File Offset: 0x00101E0F
		// (set) Token: 0x0600B628 RID: 46632 RVA: 0x00103C1F File Offset: 0x00101E1F
		public unsafe bool IgnoreLightVolumeDistanceCull
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_IgnoreLightVolumeDistanceCull) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_IgnoreLightVolumeDistanceCull) = (value ? 1 : 0);
			}
		}

		// Token: 0x170029A3 RID: 10659
		// (get) Token: 0x0600B629 RID: 46633 RVA: 0x00103C30 File Offset: 0x00101E30
		// (set) Token: 0x0600B62A RID: 46634 RVA: 0x00103C40 File Offset: 0x00101E40
		public unsafe bool bSyncToToonLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bSyncToToonLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bSyncToToonLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x170029A4 RID: 10660
		// (get) Token: 0x0600B62B RID: 46635 RVA: 0x00103C51 File Offset: 0x00101E51
		// (set) Token: 0x0600B62C RID: 46636 RVA: 0x00103C61 File Offset: 0x00101E61
		public unsafe int CustomCullFlag
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_CustomCullFlag);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_CustomCullFlag) = value;
			}
		}

		// Token: 0x170029A5 RID: 10661
		// (get) Token: 0x0600B62D RID: 46637 RVA: 0x00103C72 File Offset: 0x00101E72
		// (set) Token: 0x0600B62E RID: 46638 RVA: 0x00103C86 File Offset: 0x00101E86
		public unsafe TEnumAsByte<ELightQualityType> LightQualityType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_LightQualityType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_LightQualityType) = value;
			}
		}

		// Token: 0x170029A6 RID: 10662
		// (get) Token: 0x0600B62F RID: 46639 RVA: 0x00103C9B File Offset: 0x00101E9B
		// (set) Token: 0x0600B630 RID: 46640 RVA: 0x00103CAF File Offset: 0x00101EAF
		public unsafe TEnumAsByte<ELightQualityType> LightQualityType_PC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_LightQualityType_PC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_LightQualityType_PC) = value;
			}
		}

		// Token: 0x170029A7 RID: 10663
		// (get) Token: 0x0600B631 RID: 46641 RVA: 0x00103CC4 File Offset: 0x00101EC4
		// (set) Token: 0x0600B632 RID: 46642 RVA: 0x00103CD8 File Offset: 0x00101ED8
		public unsafe TEnumAsByte<ELightQualityType> LightShadowQualityType_PC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_LightShadowQualityType_PC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_LightShadowQualityType_PC) = value;
			}
		}

		// Token: 0x170029A8 RID: 10664
		// (get) Token: 0x0600B633 RID: 46643 RVA: 0x00103CED File Offset: 0x00101EED
		// (set) Token: 0x0600B634 RID: 46644 RVA: 0x00103D01 File Offset: 0x00101F01
		public unsafe TEnumAsByte<ERaytraceType> RaytraceType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_RaytraceType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_RaytraceType) = value;
			}
		}

		// Token: 0x170029A9 RID: 10665
		// (get) Token: 0x0600B635 RID: 46645 RVA: 0x00103D16 File Offset: 0x00101F16
		// (set) Token: 0x0600B636 RID: 46646 RVA: 0x00103D2A File Offset: 0x00101F2A
		public unsafe TEnumAsByte<ELightMegaLightsType> MegaLightsType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_MegaLightsType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_MegaLightsType) = value;
			}
		}

		// Token: 0x170029AA RID: 10666
		// (get) Token: 0x0600B637 RID: 46647 RVA: 0x00103D3F File Offset: 0x00101F3F
		// (set) Token: 0x0600B638 RID: 46648 RVA: 0x00103D58 File Offset: 0x00101F58
		public unsafe bool bUseTemperature
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bUseTemperature) & ULightComponent.__PropertyMask_bUseTemperature) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bUseTemperature) = ((*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bUseTemperature) & ~ULightComponent.__PropertyMask_bUseTemperature) | (value ? ULightComponent.__PropertyMask_bUseTemperature : 0));
			}
		}

		// Token: 0x170029AB RID: 10667
		// (get) Token: 0x0600B639 RID: 46649 RVA: 0x00103D88 File Offset: 0x00101F88
		// (set) Token: 0x0600B63A RID: 46650 RVA: 0x00103D98 File Offset: 0x00101F98
		public unsafe int ShadowMapChannel_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ShadowMapChannel_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ShadowMapChannel_DEPRECATED) = value;
			}
		}

		// Token: 0x170029AC RID: 10668
		// (get) Token: 0x0600B63B RID: 46651 RVA: 0x00103DA9 File Offset: 0x00101FA9
		// (set) Token: 0x0600B63C RID: 46652 RVA: 0x00103DB9 File Offset: 0x00101FB9
		public unsafe float MinRoughness_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_MinRoughness_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_MinRoughness_DEPRECATED) = value;
			}
		}

		// Token: 0x170029AD RID: 10669
		// (get) Token: 0x0600B63D RID: 46653 RVA: 0x00103DCA File Offset: 0x00101FCA
		// (set) Token: 0x0600B63E RID: 46654 RVA: 0x00103DDA File Offset: 0x00101FDA
		public unsafe float SpecularScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_SpecularScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_SpecularScale) = value;
			}
		}

		// Token: 0x170029AE RID: 10670
		// (get) Token: 0x0600B63F RID: 46655 RVA: 0x00103DEB File Offset: 0x00101FEB
		// (set) Token: 0x0600B640 RID: 46656 RVA: 0x00103DFB File Offset: 0x00101FFB
		public unsafe float ShadowResolutionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ShadowResolutionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ShadowResolutionScale) = value;
			}
		}

		// Token: 0x170029AF RID: 10671
		// (get) Token: 0x0600B641 RID: 46657 RVA: 0x00103E0C File Offset: 0x0010200C
		// (set) Token: 0x0600B642 RID: 46658 RVA: 0x00103E1C File Offset: 0x0010201C
		public unsafe float ShadowBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ShadowBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ShadowBias) = value;
			}
		}

		// Token: 0x170029B0 RID: 10672
		// (get) Token: 0x0600B643 RID: 46659 RVA: 0x00103E2D File Offset: 0x0010202D
		// (set) Token: 0x0600B644 RID: 46660 RVA: 0x00103E3D File Offset: 0x0010203D
		public unsafe float ShadowSlopeBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ShadowSlopeBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ShadowSlopeBias) = value;
			}
		}

		// Token: 0x170029B1 RID: 10673
		// (get) Token: 0x0600B645 RID: 46661 RVA: 0x00103E4E File Offset: 0x0010204E
		// (set) Token: 0x0600B646 RID: 46662 RVA: 0x00103E5E File Offset: 0x0010205E
		public unsafe float ShadowSharpen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ShadowSharpen);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ShadowSharpen) = value;
			}
		}

		// Token: 0x170029B2 RID: 10674
		// (get) Token: 0x0600B647 RID: 46663 RVA: 0x00103E6F File Offset: 0x0010206F
		// (set) Token: 0x0600B648 RID: 46664 RVA: 0x00103E7F File Offset: 0x0010207F
		public unsafe float ContactShadowLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ContactShadowLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ContactShadowLength) = value;
			}
		}

		// Token: 0x170029B3 RID: 10675
		// (get) Token: 0x0600B649 RID: 46665 RVA: 0x00103E90 File Offset: 0x00102090
		// (set) Token: 0x0600B64A RID: 46666 RVA: 0x00103EA0 File Offset: 0x001020A0
		public unsafe float ContactShadowNearLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ContactShadowNearLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ContactShadowNearLength) = value;
			}
		}

		// Token: 0x170029B4 RID: 10676
		// (get) Token: 0x0600B64B RID: 46667 RVA: 0x00103EB1 File Offset: 0x001020B1
		// (set) Token: 0x0600B64C RID: 46668 RVA: 0x00103ECA File Offset: 0x001020CA
		public unsafe bool ContactShadowLengthInWS
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ContactShadowLengthInWS) & ULightComponent.__PropertyMask_ContactShadowLengthInWS) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ContactShadowLengthInWS) = ((*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ContactShadowLengthInWS) & ~ULightComponent.__PropertyMask_ContactShadowLengthInWS) | (value ? ULightComponent.__PropertyMask_ContactShadowLengthInWS : 0));
			}
		}

		// Token: 0x170029B5 RID: 10677
		// (get) Token: 0x0600B64D RID: 46669 RVA: 0x00103EFA File Offset: 0x001020FA
		// (set) Token: 0x0600B64E RID: 46670 RVA: 0x00103F0A File Offset: 0x0010210A
		public unsafe float ContactShadowCastingIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ContactShadowCastingIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ContactShadowCastingIntensity) = value;
			}
		}

		// Token: 0x170029B6 RID: 10678
		// (get) Token: 0x0600B64F RID: 46671 RVA: 0x00103F1B File Offset: 0x0010211B
		// (set) Token: 0x0600B650 RID: 46672 RVA: 0x00103F2B File Offset: 0x0010212B
		public unsafe float ContactShadowFoliageCastingIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ContactShadowFoliageCastingIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ContactShadowFoliageCastingIntensity) = value;
			}
		}

		// Token: 0x170029B7 RID: 10679
		// (get) Token: 0x0600B651 RID: 46673 RVA: 0x00103F3C File Offset: 0x0010213C
		// (set) Token: 0x0600B652 RID: 46674 RVA: 0x00103F4C File Offset: 0x0010214C
		public unsafe float ContactShadowFadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ContactShadowFadeDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ContactShadowFadeDistance) = value;
			}
		}

		// Token: 0x170029B8 RID: 10680
		// (get) Token: 0x0600B653 RID: 46675 RVA: 0x00103F5D File Offset: 0x0010215D
		// (set) Token: 0x0600B654 RID: 46676 RVA: 0x00103F6D File Offset: 0x0010216D
		public unsafe float ContactShadowBeginFadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ContactShadowBeginFadeDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ContactShadowBeginFadeDistance) = value;
			}
		}

		// Token: 0x170029B9 RID: 10681
		// (get) Token: 0x0600B655 RID: 46677 RVA: 0x00103F7E File Offset: 0x0010217E
		// (set) Token: 0x0600B656 RID: 46678 RVA: 0x00103F97 File Offset: 0x00102197
		public unsafe bool InverseSquaredFalloff_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_InverseSquaredFalloff_DEPRECATED) & ULightComponent.__PropertyMask_InverseSquaredFalloff_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULightComponent.__PropertyOffset_InverseSquaredFalloff_DEPRECATED) = ((*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_InverseSquaredFalloff_DEPRECATED) & ~ULightComponent.__PropertyMask_InverseSquaredFalloff_DEPRECATED) | (value ? ULightComponent.__PropertyMask_InverseSquaredFalloff_DEPRECATED : 0));
			}
		}

		// Token: 0x170029BA RID: 10682
		// (get) Token: 0x0600B657 RID: 46679 RVA: 0x00103FC7 File Offset: 0x001021C7
		// (set) Token: 0x0600B658 RID: 46680 RVA: 0x00103FE0 File Offset: 0x001021E0
		public unsafe bool CastTranslucentShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_CastTranslucentShadows) & ULightComponent.__PropertyMask_CastTranslucentShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULightComponent.__PropertyOffset_CastTranslucentShadows) = ((*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_CastTranslucentShadows) & ~ULightComponent.__PropertyMask_CastTranslucentShadows) | (value ? ULightComponent.__PropertyMask_CastTranslucentShadows : 0));
			}
		}

		// Token: 0x170029BB RID: 10683
		// (get) Token: 0x0600B659 RID: 46681 RVA: 0x00104010 File Offset: 0x00102210
		// (set) Token: 0x0600B65A RID: 46682 RVA: 0x00104029 File Offset: 0x00102229
		public unsafe bool bCastShadowsFromCinematicObjectsOnly
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bCastShadowsFromCinematicObjectsOnly) & ULightComponent.__PropertyMask_bCastShadowsFromCinematicObjectsOnly) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bCastShadowsFromCinematicObjectsOnly) = ((*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bCastShadowsFromCinematicObjectsOnly) & ~ULightComponent.__PropertyMask_bCastShadowsFromCinematicObjectsOnly) | (value ? ULightComponent.__PropertyMask_bCastShadowsFromCinematicObjectsOnly : 0));
			}
		}

		// Token: 0x170029BC RID: 10684
		// (get) Token: 0x0600B65B RID: 46683 RVA: 0x00104059 File Offset: 0x00102259
		// (set) Token: 0x0600B65C RID: 46684 RVA: 0x00104072 File Offset: 0x00102272
		public unsafe bool bAffectDynamicIndirectLighting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bAffectDynamicIndirectLighting) & ULightComponent.__PropertyMask_bAffectDynamicIndirectLighting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bAffectDynamicIndirectLighting) = ((*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bAffectDynamicIndirectLighting) & ~ULightComponent.__PropertyMask_bAffectDynamicIndirectLighting) | (value ? ULightComponent.__PropertyMask_bAffectDynamicIndirectLighting : 0));
			}
		}

		// Token: 0x170029BD RID: 10685
		// (get) Token: 0x0600B65D RID: 46685 RVA: 0x001040A2 File Offset: 0x001022A2
		// (set) Token: 0x0600B65E RID: 46686 RVA: 0x001040BB File Offset: 0x001022BB
		public unsafe bool bForceCachedShadowsForMovablePrimitives
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bForceCachedShadowsForMovablePrimitives) & ULightComponent.__PropertyMask_bForceCachedShadowsForMovablePrimitives) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bForceCachedShadowsForMovablePrimitives) = ((*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bForceCachedShadowsForMovablePrimitives) & ~ULightComponent.__PropertyMask_bForceCachedShadowsForMovablePrimitives) | (value ? ULightComponent.__PropertyMask_bForceCachedShadowsForMovablePrimitives : 0));
			}
		}

		// Token: 0x170029BE RID: 10686
		// (get) Token: 0x0600B65F RID: 46687 RVA: 0x001040EB File Offset: 0x001022EB
		// (set) Token: 0x0600B660 RID: 46688 RVA: 0x00104104 File Offset: 0x00102304
		public unsafe bool bAllowMegaLights
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bAllowMegaLights) & ULightComponent.__PropertyMask_bAllowMegaLights) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bAllowMegaLights) = ((*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bAllowMegaLights) & ~ULightComponent.__PropertyMask_bAllowMegaLights) | (value ? ULightComponent.__PropertyMask_bAllowMegaLights : 0));
			}
		}

		// Token: 0x170029BF RID: 10687
		// (get) Token: 0x0600B661 RID: 46689 RVA: 0x00104134 File Offset: 0x00102334
		// (set) Token: 0x0600B662 RID: 46690 RVA: 0x00104148 File Offset: 0x00102348
		public unsafe TEnumAsByte<EMegaLightsShadowMethod> MegaLightsShadowMethod
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_MegaLightsShadowMethod);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_MegaLightsShadowMethod) = value;
			}
		}

		// Token: 0x170029C0 RID: 10688
		// (get) Token: 0x0600B663 RID: 46691 RVA: 0x00104160 File Offset: 0x00102360
		// (set) Token: 0x0600B664 RID: 46692 RVA: 0x00104199 File Offset: 0x00102399
		[Nullable(1)]
		public FLightingChannels LightingChannels
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLightingChannels result;
				if ((result = this._LightingChannels) == null)
				{
					result = (this._LightingChannels = new FLightingChannels(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_LightingChannels, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLightingChannels.StaticStruct(), base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_LightingChannels, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170029C1 RID: 10689
		// (get) Token: 0x0600B665 RID: 46693 RVA: 0x001041BA File Offset: 0x001023BA
		// (set) Token: 0x0600B666 RID: 46694 RVA: 0x001041CE File Offset: 0x001023CE
		[Nullable(2)]
		public unsafe UMaterialInterface LightFunctionMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + ULightComponent.__PropertyOffset_LightFunctionMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULightComponent.__PropertyOffset_LightFunctionMaterial, value);
			}
		}

		// Token: 0x170029C2 RID: 10690
		// (get) Token: 0x0600B667 RID: 46695 RVA: 0x001041E3 File Offset: 0x001023E3
		// (set) Token: 0x0600B668 RID: 46696 RVA: 0x001041F7 File Offset: 0x001023F7
		[Nullable(2)]
		public unsafe UMaterialInterface VolumetricLightFunctionMaterial
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + ULightComponent.__PropertyOffset_VolumetricLightFunctionMaterial);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULightComponent.__PropertyOffset_VolumetricLightFunctionMaterial, value);
			}
		}

		// Token: 0x170029C3 RID: 10691
		// (get) Token: 0x0600B669 RID: 46697 RVA: 0x0010420C File Offset: 0x0010240C
		// (set) Token: 0x0600B66A RID: 46698 RVA: 0x00104220 File Offset: 0x00102420
		public unsafe FVector LightFunctionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_LightFunctionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_LightFunctionScale) = value;
			}
		}

		// Token: 0x170029C4 RID: 10692
		// (get) Token: 0x0600B66B RID: 46699 RVA: 0x00104235 File Offset: 0x00102435
		// (set) Token: 0x0600B66C RID: 46700 RVA: 0x00104249 File Offset: 0x00102449
		[Nullable(2)]
		public unsafe UTextureLightProfile IESTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureLightProfile>(base.NativePtr / (IntPtr)sizeof(void*) + ULightComponent.__PropertyOffset_IESTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + ULightComponent.__PropertyOffset_IESTexture, value);
			}
		}

		// Token: 0x170029C5 RID: 10693
		// (get) Token: 0x0600B66D RID: 46701 RVA: 0x0010425E File Offset: 0x0010245E
		// (set) Token: 0x0600B66E RID: 46702 RVA: 0x00104277 File Offset: 0x00102477
		public unsafe bool bUseIESBrightness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bUseIESBrightness) & ULightComponent.__PropertyMask_bUseIESBrightness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bUseIESBrightness) = ((*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bUseIESBrightness) & ~ULightComponent.__PropertyMask_bUseIESBrightness) | (value ? ULightComponent.__PropertyMask_bUseIESBrightness : 0));
			}
		}

		// Token: 0x170029C6 RID: 10694
		// (get) Token: 0x0600B66F RID: 46703 RVA: 0x001042A7 File Offset: 0x001024A7
		// (set) Token: 0x0600B670 RID: 46704 RVA: 0x001042B7 File Offset: 0x001024B7
		public unsafe float IESBrightnessScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_IESBrightnessScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_IESBrightnessScale) = value;
			}
		}

		// Token: 0x170029C7 RID: 10695
		// (get) Token: 0x0600B671 RID: 46705 RVA: 0x001042C8 File Offset: 0x001024C8
		// (set) Token: 0x0600B672 RID: 46706 RVA: 0x001042D8 File Offset: 0x001024D8
		public unsafe float LightFunctionFadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_LightFunctionFadeDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_LightFunctionFadeDistance) = value;
			}
		}

		// Token: 0x170029C8 RID: 10696
		// (get) Token: 0x0600B673 RID: 46707 RVA: 0x001042E9 File Offset: 0x001024E9
		// (set) Token: 0x0600B674 RID: 46708 RVA: 0x001042F9 File Offset: 0x001024F9
		public unsafe float DisabledBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_DisabledBrightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_DisabledBrightness) = value;
			}
		}

		// Token: 0x170029C9 RID: 10697
		// (get) Token: 0x0600B675 RID: 46709 RVA: 0x0010430A File Offset: 0x0010250A
		// (set) Token: 0x0600B676 RID: 46710 RVA: 0x00104323 File Offset: 0x00102523
		public unsafe bool bEnableLightShaftBloom
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bEnableLightShaftBloom) & ULightComponent.__PropertyMask_bEnableLightShaftBloom) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bEnableLightShaftBloom) = ((*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bEnableLightShaftBloom) & ~ULightComponent.__PropertyMask_bEnableLightShaftBloom) | (value ? ULightComponent.__PropertyMask_bEnableLightShaftBloom : 0));
			}
		}

		// Token: 0x170029CA RID: 10698
		// (get) Token: 0x0600B677 RID: 46711 RVA: 0x00104353 File Offset: 0x00102553
		// (set) Token: 0x0600B678 RID: 46712 RVA: 0x00104363 File Offset: 0x00102563
		public unsafe float BloomScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_BloomScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_BloomScale) = value;
			}
		}

		// Token: 0x170029CB RID: 10699
		// (get) Token: 0x0600B679 RID: 46713 RVA: 0x00104374 File Offset: 0x00102574
		// (set) Token: 0x0600B67A RID: 46714 RVA: 0x00104384 File Offset: 0x00102584
		public unsafe float BloomThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_BloomThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_BloomThreshold) = value;
			}
		}

		// Token: 0x170029CC RID: 10700
		// (get) Token: 0x0600B67B RID: 46715 RVA: 0x00104395 File Offset: 0x00102595
		// (set) Token: 0x0600B67C RID: 46716 RVA: 0x001043A5 File Offset: 0x001025A5
		public unsafe float BloomMaxBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_BloomMaxBrightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_BloomMaxBrightness) = value;
			}
		}

		// Token: 0x170029CD RID: 10701
		// (get) Token: 0x0600B67D RID: 46717 RVA: 0x001043B6 File Offset: 0x001025B6
		// (set) Token: 0x0600B67E RID: 46718 RVA: 0x001043CA File Offset: 0x001025CA
		public unsafe FColor BloomTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_BloomTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_BloomTint) = value;
			}
		}

		// Token: 0x170029CE RID: 10702
		// (get) Token: 0x0600B67F RID: 46719 RVA: 0x001043DF File Offset: 0x001025DF
		// (set) Token: 0x0600B680 RID: 46720 RVA: 0x001043EF File Offset: 0x001025EF
		public unsafe bool bUseRayTracedDistanceFieldShadows
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bUseRayTracedDistanceFieldShadows) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bUseRayTracedDistanceFieldShadows) = (value ? 1 : 0);
			}
		}

		// Token: 0x170029CF RID: 10703
		// (get) Token: 0x0600B681 RID: 46721 RVA: 0x00104400 File Offset: 0x00102600
		// (set) Token: 0x0600B682 RID: 46722 RVA: 0x00104410 File Offset: 0x00102610
		public unsafe float RayStartOffsetDepthScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_RayStartOffsetDepthScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_RayStartOffsetDepthScale) = value;
			}
		}

		// Token: 0x170029D0 RID: 10704
		// (get) Token: 0x0600B683 RID: 46723 RVA: 0x00104421 File Offset: 0x00102621
		// (set) Token: 0x0600B684 RID: 46724 RVA: 0x0010443A File Offset: 0x0010263A
		public unsafe bool bEnableLightShaftOcclusion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bEnableLightShaftOcclusion) & ULightComponent.__PropertyMask_bEnableLightShaftOcclusion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bEnableLightShaftOcclusion) = ((*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bEnableLightShaftOcclusion) & ~ULightComponent.__PropertyMask_bEnableLightShaftOcclusion) | (value ? ULightComponent.__PropertyMask_bEnableLightShaftOcclusion : 0));
			}
		}

		// Token: 0x170029D1 RID: 10705
		// (get) Token: 0x0600B685 RID: 46725 RVA: 0x0010446A File Offset: 0x0010266A
		// (set) Token: 0x0600B686 RID: 46726 RVA: 0x0010447A File Offset: 0x0010267A
		public unsafe float OcclusionMaskDarkness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_OcclusionMaskDarkness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_OcclusionMaskDarkness) = value;
			}
		}

		// Token: 0x170029D2 RID: 10706
		// (get) Token: 0x0600B687 RID: 46727 RVA: 0x0010448B File Offset: 0x0010268B
		// (set) Token: 0x0600B688 RID: 46728 RVA: 0x0010449B File Offset: 0x0010269B
		public unsafe float OcclusionDepthRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_OcclusionDepthRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_OcclusionDepthRange) = value;
			}
		}

		// Token: 0x170029D3 RID: 10707
		// (get) Token: 0x0600B689 RID: 46729 RVA: 0x001044AC File Offset: 0x001026AC
		// (set) Token: 0x0600B68A RID: 46730 RVA: 0x001044BC File Offset: 0x001026BC
		public unsafe float CastDynamicShadowInCaveFadeIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_CastDynamicShadowInCaveFadeIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_CastDynamicShadowInCaveFadeIntensity) = value;
			}
		}

		// Token: 0x170029D4 RID: 10708
		// (get) Token: 0x0600B68B RID: 46731 RVA: 0x001044CD File Offset: 0x001026CD
		// (set) Token: 0x0600B68C RID: 46732 RVA: 0x001044DD File Offset: 0x001026DD
		public unsafe float ToonPointLightFallOff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonPointLightFallOff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonPointLightFallOff) = value;
			}
		}

		// Token: 0x170029D5 RID: 10709
		// (get) Token: 0x0600B68D RID: 46733 RVA: 0x001044EE File Offset: 0x001026EE
		// (set) Token: 0x0600B68E RID: 46734 RVA: 0x001044FE File Offset: 0x001026FE
		public unsafe bool bUsePointLightFallOffColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bUsePointLightFallOffColor) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_bUsePointLightFallOffColor) = (value ? 1 : 0);
			}
		}

		// Token: 0x170029D6 RID: 10710
		// (get) Token: 0x0600B68F RID: 46735 RVA: 0x0010450F File Offset: 0x0010270F
		// (set) Token: 0x0600B690 RID: 46736 RVA: 0x0010451F File Offset: 0x0010271F
		public unsafe float ToonDistanceBlendAtten
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonDistanceBlendAtten);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonDistanceBlendAtten) = value;
			}
		}

		// Token: 0x170029D7 RID: 10711
		// (get) Token: 0x0600B691 RID: 46737 RVA: 0x00104530 File Offset: 0x00102730
		// (set) Token: 0x0600B692 RID: 46738 RVA: 0x00104540 File Offset: 0x00102740
		public unsafe float ToonDistanceBlendIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonDistanceBlendIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonDistanceBlendIntensity) = value;
			}
		}

		// Token: 0x170029D8 RID: 10712
		// (get) Token: 0x0600B693 RID: 46739 RVA: 0x00104551 File Offset: 0x00102751
		// (set) Token: 0x0600B694 RID: 46740 RVA: 0x00104565 File Offset: 0x00102765
		public unsafe TEnumAsByte<EToonLightType> ToonLightType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonLightType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonLightType) = value;
			}
		}

		// Token: 0x170029D9 RID: 10713
		// (get) Token: 0x0600B695 RID: 46741 RVA: 0x0010457A File Offset: 0x0010277A
		// (set) Token: 0x0600B696 RID: 46742 RVA: 0x0010458A File Offset: 0x0010278A
		public unsafe int ToonLightingPriority
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonLightingPriority);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonLightingPriority) = value;
			}
		}

		// Token: 0x170029DA RID: 10714
		// (get) Token: 0x0600B697 RID: 46743 RVA: 0x0010459B File Offset: 0x0010279B
		// (set) Token: 0x0600B698 RID: 46744 RVA: 0x001045AB File Offset: 0x001027AB
		public unsafe float ToonIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonIntensity) = value;
			}
		}

		// Token: 0x170029DB RID: 10715
		// (get) Token: 0x0600B699 RID: 46745 RVA: 0x001045BC File Offset: 0x001027BC
		// (set) Token: 0x0600B69A RID: 46746 RVA: 0x001045D0 File Offset: 0x001027D0
		public unsafe FColor ToonColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonColor) = value;
			}
		}

		// Token: 0x170029DC RID: 10716
		// (get) Token: 0x0600B69B RID: 46747 RVA: 0x001045E5 File Offset: 0x001027E5
		// (set) Token: 0x0600B69C RID: 46748 RVA: 0x001045F5 File Offset: 0x001027F5
		public unsafe float ToonShadowColorIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonShadowColorIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonShadowColorIntensity) = value;
			}
		}

		// Token: 0x170029DD RID: 10717
		// (get) Token: 0x0600B69D RID: 46749 RVA: 0x00104606 File Offset: 0x00102806
		// (set) Token: 0x0600B69E RID: 46750 RVA: 0x00104616 File Offset: 0x00102816
		public unsafe float ToonBaseColorIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonBaseColorIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonBaseColorIntensity) = value;
			}
		}

		// Token: 0x170029DE RID: 10718
		// (get) Token: 0x0600B69F RID: 46751 RVA: 0x00104627 File Offset: 0x00102827
		// (set) Token: 0x0600B6A0 RID: 46752 RVA: 0x00104637 File Offset: 0x00102837
		public unsafe float ToonRealTimeShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonRealTimeShadowIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonRealTimeShadowIntensity) = value;
			}
		}

		// Token: 0x170029DF RID: 10719
		// (get) Token: 0x0600B6A1 RID: 46753 RVA: 0x00104648 File Offset: 0x00102848
		// (set) Token: 0x0600B6A2 RID: 46754 RVA: 0x00104681 File Offset: 0x00102881
		[Nullable(1)]
		public FLightingChannels ToonLightingChannels
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FLightingChannels result;
				if ((result = this._ToonLightingChannels) == null)
				{
					result = (this._ToonLightingChannels = new FLightingChannels(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonLightingChannels, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FLightingChannels.StaticStruct(), base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonLightingChannels, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170029E0 RID: 10720
		// (get) Token: 0x0600B6A3 RID: 46755 RVA: 0x001046A2 File Offset: 0x001028A2
		// (set) Token: 0x0600B6A4 RID: 46756 RVA: 0x001046B2 File Offset: 0x001028B2
		public unsafe float ToonHardShadowIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonHardShadowIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonHardShadowIntensity) = value;
			}
		}

		// Token: 0x170029E1 RID: 10721
		// (get) Token: 0x0600B6A5 RID: 46757 RVA: 0x001046C3 File Offset: 0x001028C3
		// (set) Token: 0x0600B6A6 RID: 46758 RVA: 0x001046D3 File Offset: 0x001028D3
		public unsafe float ToonHardShadowRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonHardShadowRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonHardShadowRange) = value;
			}
		}

		// Token: 0x170029E2 RID: 10722
		// (get) Token: 0x0600B6A7 RID: 46759 RVA: 0x001046E4 File Offset: 0x001028E4
		// (set) Token: 0x0600B6A8 RID: 46760 RVA: 0x001046F8 File Offset: 0x001028F8
		public unsafe FLinearColor ToonHardBaseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonHardBaseColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonHardBaseColor) = value;
			}
		}

		// Token: 0x170029E3 RID: 10723
		// (get) Token: 0x0600B6A9 RID: 46761 RVA: 0x0010470D File Offset: 0x0010290D
		// (set) Token: 0x0600B6AA RID: 46762 RVA: 0x00104721 File Offset: 0x00102921
		public unsafe FLinearColor ToonHardShadowColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonHardShadowColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonHardShadowColor) = value;
			}
		}

		// Token: 0x170029E4 RID: 10724
		// (get) Token: 0x0600B6AB RID: 46763 RVA: 0x00104736 File Offset: 0x00102936
		// (set) Token: 0x0600B6AC RID: 46764 RVA: 0x00104746 File Offset: 0x00102946
		public unsafe float ToonHardShadowBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonHardShadowBlend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_ToonHardShadowBlend) = value;
			}
		}

		// Token: 0x170029E5 RID: 10725
		// (get) Token: 0x0600B6AD RID: 46765 RVA: 0x00104757 File Offset: 0x00102957
		// (set) Token: 0x0600B6AE RID: 46766 RVA: 0x00104767 File Offset: 0x00102967
		public unsafe bool IsUIScenePrimitive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_IsUIScenePrimitive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)ULightComponent.__PropertyOffset_IsUIScenePrimitive) = (value ? 1 : 0);
			}
		}

		// Token: 0x0600B6AF RID: 46767 RVA: 0x00104778 File Offset: 0x00102978
		public void SyncToToonLight()
		{
			ULightComponent.__SyncToToonLight_Internal(base.NativePtr);
		}

		// Token: 0x0600B6B0 RID: 46768 RVA: 0x00104785 File Offset: 0x00102985
		public void SetVolumetricScatteringIntensity(float NewIntensity)
		{
			ULightComponent.__SetVolumetricScatteringIntensity_Internal(base.NativePtr, NewIntensity);
		}

		// Token: 0x0600B6B1 RID: 46769 RVA: 0x00104793 File Offset: 0x00102993
		[NullableContext(2)]
		public void SetVolumetricLightFunctionMaterial(UMaterialInterface NewLightFunctionMaterial)
		{
			ULightComponent.__SetVolumetricLightFunctionMaterial_Internal(base.NativePtr, (NewLightFunctionMaterial != null) ? NewLightFunctionMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600B6B2 RID: 46770 RVA: 0x001047B0 File Offset: 0x001029B0
		public void SetUsePointLightFallOffColor(bool InUsePointLightFallOffColor)
		{
			ULightComponent.__SetUsePointLightFallOffColor_Internal(base.NativePtr, InUsePointLightFallOffColor);
		}

		// Token: 0x0600B6B3 RID: 46771 RVA: 0x001047BE File Offset: 0x001029BE
		public void SetUseIESBrightness(bool bNewValue)
		{
			ULightComponent.__SetUseIESBrightness_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600B6B4 RID: 46772 RVA: 0x001047CC File Offset: 0x001029CC
		public void SetTransmission(bool bNewValue)
		{
			ULightComponent.__SetTransmission_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600B6B5 RID: 46773 RVA: 0x001047DA File Offset: 0x001029DA
		public void SetToonShadowColorIntensity(float InToonShadowColorIntensity)
		{
			ULightComponent.__SetToonShadowColorIntensity_Internal(base.NativePtr, InToonShadowColorIntensity);
		}

		// Token: 0x0600B6B6 RID: 46774 RVA: 0x001047E8 File Offset: 0x001029E8
		public void SetToonRealTimeShadowIntensity(float InToonRealTimeShadowIntensity)
		{
			ULightComponent.__SetToonRealTimeShadowIntensity_Internal(base.NativePtr, InToonRealTimeShadowIntensity);
		}

		// Token: 0x0600B6B7 RID: 46775 RVA: 0x001047F6 File Offset: 0x001029F6
		public void SetToonPointLightFallOff(float InToonPointLightFallOff)
		{
			ULightComponent.__SetToonPointLightFallOff_Internal(base.NativePtr, InToonPointLightFallOff);
		}

		// Token: 0x0600B6B8 RID: 46776 RVA: 0x00104804 File Offset: 0x00102A04
		public void SetToonLightType(EToonLightType InToonLightType)
		{
			ULightComponent.__SetToonLightType_Internal(base.NativePtr, InToonLightType);
		}

		// Token: 0x0600B6B9 RID: 46777 RVA: 0x00104817 File Offset: 0x00102A17
		public void SetToonLightingPriority(int InToonLightingPriority)
		{
			ULightComponent.__SetToonLightingPriority_Internal(base.NativePtr, InToonLightingPriority);
		}

		// Token: 0x0600B6BA RID: 46778 RVA: 0x00104825 File Offset: 0x00102A25
		public void SetToonIntensity(float InToonIntensity)
		{
			ULightComponent.__SetToonIntensity_Internal(base.NativePtr, InToonIntensity);
		}

		// Token: 0x0600B6BB RID: 46779 RVA: 0x00104833 File Offset: 0x00102A33
		public void SetToonHardShadowRange(float InToonHardShadowRange)
		{
			ULightComponent.__SetToonHardShadowRange_Internal(base.NativePtr, InToonHardShadowRange);
		}

		// Token: 0x0600B6BC RID: 46780 RVA: 0x00104841 File Offset: 0x00102A41
		public void SetToonHardShadowIntensity(float InToonHardShadowIntensity)
		{
			ULightComponent.__SetToonHardShadowIntensity_Internal(base.NativePtr, InToonHardShadowIntensity);
		}

		// Token: 0x0600B6BD RID: 46781 RVA: 0x0010484F File Offset: 0x00102A4F
		public void SetToonHardShadowColor(FLinearColor InToonHardShadowColor)
		{
			ULightComponent.__SetToonHardShadowColor_Internal(base.NativePtr, InToonHardShadowColor);
		}

		// Token: 0x0600B6BE RID: 46782 RVA: 0x0010485D File Offset: 0x00102A5D
		public void SetToonHardShadowBlend(float InToonHardShadowBlend)
		{
			ULightComponent.__SetToonHardShadowBlend_Internal(base.NativePtr, InToonHardShadowBlend);
		}

		// Token: 0x0600B6BF RID: 46783 RVA: 0x0010486B File Offset: 0x00102A6B
		public void SetToonHardBaseColor(FLinearColor InToonHardBaseColor)
		{
			ULightComponent.__SetToonHardBaseColor_Internal(base.NativePtr, InToonHardBaseColor);
		}

		// Token: 0x0600B6C0 RID: 46784 RVA: 0x00104879 File Offset: 0x00102A79
		public void SetToonDistanceBlendIntensity(float InToonDistanceBlendIntensity)
		{
			ULightComponent.__SetToonDistanceBlendIntensity_Internal(base.NativePtr, InToonDistanceBlendIntensity);
		}

		// Token: 0x0600B6C1 RID: 46785 RVA: 0x00104887 File Offset: 0x00102A87
		public void SetToonDistanceBlendAtten(float InToonDistanceBlendAtten)
		{
			ULightComponent.__SetToonDistanceBlendAtten_Internal(base.NativePtr, InToonDistanceBlendAtten);
		}

		// Token: 0x0600B6C2 RID: 46786 RVA: 0x00104895 File Offset: 0x00102A95
		public void SetToonBaseColorIntensity(float InToonBaseColorIntensity)
		{
			ULightComponent.__SetToonBaseColorIntensity_Internal(base.NativePtr, InToonBaseColorIntensity);
		}

		// Token: 0x0600B6C3 RID: 46787 RVA: 0x001048A3 File Offset: 0x00102AA3
		public void SetTemperature(float NewTemperature)
		{
			ULightComponent.__SetTemperature_Internal(base.NativePtr, NewTemperature);
		}

		// Token: 0x0600B6C4 RID: 46788 RVA: 0x001048B1 File Offset: 0x00102AB1
		public void SetSpecularScale(float NewValue)
		{
			ULightComponent.__SetSpecularScale_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600B6C5 RID: 46789 RVA: 0x001048BF File Offset: 0x00102ABF
		public void SetShadowSlopeBias(float NewValue)
		{
			ULightComponent.__SetShadowSlopeBias_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600B6C6 RID: 46790 RVA: 0x001048CD File Offset: 0x00102ACD
		public void SetShadowBias(float NewValue)
		{
			ULightComponent.__SetShadowBias_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600B6C7 RID: 46791 RVA: 0x001048DB File Offset: 0x00102ADB
		public void SetRaytraceType(ERaytraceType InRaytraceType)
		{
			ULightComponent.__SetRaytraceType_Internal(base.NativePtr, InRaytraceType);
		}

		// Token: 0x0600B6C8 RID: 46792 RVA: 0x001048EE File Offset: 0x00102AEE
		public void SetOcclusionMaskDarkness(float NewValue)
		{
			ULightComponent.__SetOcclusionMaskDarkness_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600B6C9 RID: 46793 RVA: 0x001048FC File Offset: 0x00102AFC
		public void SetOcclusionDepthRange(float NewValue)
		{
			ULightComponent.__SetOcclusionDepthRange_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600B6CA RID: 46794 RVA: 0x0010490A File Offset: 0x00102B0A
		public void SetMinDrawDistance(float InMinDrawDistance)
		{
			ULightComponent.__SetMinDrawDistance_Internal(base.NativePtr, InMinDrawDistance);
		}

		// Token: 0x0600B6CB RID: 46795 RVA: 0x00104918 File Offset: 0x00102B18
		public void SetMinDistanceFadeRange(float InMinDistanceFadeRange)
		{
			ULightComponent.__SetMinDistanceFadeRange_Internal(base.NativePtr, InMinDistanceFadeRange);
		}

		// Token: 0x0600B6CC RID: 46796 RVA: 0x00104926 File Offset: 0x00102B26
		public void SetMegaLightsType(ELightMegaLightsType InMegaLightsType)
		{
			ULightComponent.__SetMegaLightsType_Internal(base.NativePtr, InMegaLightsType);
		}

		// Token: 0x0600B6CD RID: 46797 RVA: 0x00104939 File Offset: 0x00102B39
		public void SetMaxDrawDistance(float InMaxDrawDistance)
		{
			ULightComponent.__SetMaxDrawDistance_Internal(base.NativePtr, InMaxDrawDistance);
		}

		// Token: 0x0600B6CE RID: 46798 RVA: 0x00104947 File Offset: 0x00102B47
		public void SetMaxDistanceFadeRange(float InMaxDistanceFadeRange)
		{
			ULightComponent.__SetMaxDistanceFadeRange_Internal(base.NativePtr, InMaxDistanceFadeRange);
		}

		// Token: 0x0600B6CF RID: 46799 RVA: 0x00104955 File Offset: 0x00102B55
		public void SetLightToonIntensity(float NewIntensity)
		{
			ULightComponent.__SetLightToonIntensity_Internal(base.NativePtr, NewIntensity);
		}

		// Token: 0x0600B6D0 RID: 46800 RVA: 0x00104963 File Offset: 0x00102B63
		public void SetLightToonColor(FLinearColor NewLightColor, bool bSRGB = true)
		{
			ULightComponent.__SetLightToonColor_Internal(base.NativePtr, NewLightColor, bSRGB);
		}

		// Token: 0x0600B6D1 RID: 46801 RVA: 0x00104972 File Offset: 0x00102B72
		public void SetLightShadowQualityType_PC(ELightQualityType InLightQualityType)
		{
			ULightComponent.__SetLightShadowQualityType_PC_Internal(base.NativePtr, InLightQualityType);
		}

		// Token: 0x0600B6D2 RID: 46802 RVA: 0x00104985 File Offset: 0x00102B85
		public void SetLightQualityType_PC(ELightQualityType InLightQualityType)
		{
			ULightComponent.__SetLightQualityType_PC_Internal(base.NativePtr, InLightQualityType);
		}

		// Token: 0x0600B6D3 RID: 46803 RVA: 0x00104998 File Offset: 0x00102B98
		public void SetLightQualityType(ELightQualityType InLightQualityType)
		{
			ULightComponent.__SetLightQualityType_Internal(base.NativePtr, InLightQualityType);
		}

		// Token: 0x0600B6D4 RID: 46804 RVA: 0x001049AB File Offset: 0x00102BAB
		public void SetLightingChannels(bool bChannel0, bool bChannel1, bool bChannel2)
		{
			ULightComponent.__SetLightingChannels_Internal(base.NativePtr, bChannel0, bChannel1, bChannel2);
		}

		// Token: 0x0600B6D5 RID: 46805 RVA: 0x001049BB File Offset: 0x00102BBB
		public void SetLightFunctionScale(FVector NewLightFunctionScale)
		{
			ULightComponent.__SetLightFunctionScale_Internal(base.NativePtr, NewLightFunctionScale);
		}

		// Token: 0x0600B6D6 RID: 46806 RVA: 0x001049C9 File Offset: 0x00102BC9
		[NullableContext(2)]
		public void SetLightFunctionMaterial(UMaterialInterface NewLightFunctionMaterial)
		{
			ULightComponent.__SetLightFunctionMaterial_Internal(base.NativePtr, (NewLightFunctionMaterial != null) ? NewLightFunctionMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600B6D7 RID: 46807 RVA: 0x001049E6 File Offset: 0x00102BE6
		public void SetLightFunctionFadeDistance(float NewLightFunctionFadeDistance)
		{
			ULightComponent.__SetLightFunctionFadeDistance_Internal(base.NativePtr, NewLightFunctionFadeDistance);
		}

		// Token: 0x0600B6D8 RID: 46808 RVA: 0x001049F4 File Offset: 0x00102BF4
		public void SetLightFunctionDisabledBrightness(float NewValue)
		{
			ULightComponent.__SetLightFunctionDisabledBrightness_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600B6D9 RID: 46809 RVA: 0x00104A02 File Offset: 0x00102C02
		public void SetLightDistanceCullType(ELightDistanceCullType InLightDistanceCullType)
		{
			ULightComponent.__SetLightDistanceCullType_Internal(base.NativePtr, InLightDistanceCullType);
		}

		// Token: 0x0600B6DA RID: 46810 RVA: 0x00104A15 File Offset: 0x00102C15
		public void SetLightColor(FLinearColor NewLightColor, bool bSRGB = true)
		{
			ULightComponent.__SetLightColor_Internal(base.NativePtr, NewLightColor, bSRGB);
		}

		// Token: 0x0600B6DB RID: 46811 RVA: 0x00104A24 File Offset: 0x00102C24
		public void SetIsUIScenePrimitive(bool bValue)
		{
			ULightComponent.__SetIsUIScenePrimitive_Internal(base.NativePtr, bValue);
		}

		// Token: 0x0600B6DC RID: 46812 RVA: 0x00104A32 File Offset: 0x00102C32
		public void SetIntensity(float NewIntensity)
		{
			ULightComponent.__SetIntensity_Internal(base.NativePtr, NewIntensity);
		}

		// Token: 0x0600B6DD RID: 46813 RVA: 0x00104A40 File Offset: 0x00102C40
		public void SetIndirectLightingIntensity(float NewIntensity)
		{
			ULightComponent.__SetIndirectLightingIntensity_Internal(base.NativePtr, NewIntensity);
		}

		// Token: 0x0600B6DE RID: 46814 RVA: 0x00104A4E File Offset: 0x00102C4E
		public void SetIgnoreLightVolumeDistanceCull(bool IsIgnoreVolumeDistanceCull)
		{
			ULightComponent.__SetIgnoreLightVolumeDistanceCull_Internal(base.NativePtr, IsIgnoreVolumeDistanceCull);
		}

		// Token: 0x0600B6DF RID: 46815 RVA: 0x00104A5C File Offset: 0x00102C5C
		[NullableContext(2)]
		public void SetIESTexture(UTextureLightProfile NewValue)
		{
			ULightComponent.__SetIESTexture_Internal(base.NativePtr, (NewValue != null) ? NewValue.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600B6E0 RID: 46816 RVA: 0x00104A79 File Offset: 0x00102C79
		public void SetIESBrightnessScale(float NewValue)
		{
			ULightComponent.__SetIESBrightnessScale_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600B6E1 RID: 46817 RVA: 0x00104A87 File Offset: 0x00102C87
		public void SetForceCachedShadowsForMovablePrimitives(bool bNewValue)
		{
			ULightComponent.__SetForceCachedShadowsForMovablePrimitives_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600B6E2 RID: 46818 RVA: 0x00104A95 File Offset: 0x00102C95
		public void SetEnableLightShaftOcclusion(bool bNewValue)
		{
			ULightComponent.__SetEnableLightShaftOcclusion_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600B6E3 RID: 46819 RVA: 0x00104AA3 File Offset: 0x00102CA3
		public void SetEnableLightShaftBloom(bool bNewValue)
		{
			ULightComponent.__SetEnableLightShaftBloom_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600B6E4 RID: 46820 RVA: 0x00104AB1 File Offset: 0x00102CB1
		public void SetCastDynamicShadowInCaveFadeIntensity(float InCastDynamicShadowInCaveFadeIntensity)
		{
			ULightComponent.__SetCastDynamicShadowInCaveFadeIntensity_Internal(base.NativePtr, InCastDynamicShadowInCaveFadeIntensity);
		}

		// Token: 0x0600B6E5 RID: 46821 RVA: 0x00104ABF File Offset: 0x00102CBF
		public void SetBloomTint(FColor NewValue)
		{
			ULightComponent.__SetBloomTint_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600B6E6 RID: 46822 RVA: 0x00104ACD File Offset: 0x00102CCD
		public void SetBloomThreshold(float NewValue)
		{
			ULightComponent.__SetBloomThreshold_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600B6E7 RID: 46823 RVA: 0x00104ADB File Offset: 0x00102CDB
		public void SetBloomScale(float NewValue)
		{
			ULightComponent.__SetBloomScale_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600B6E8 RID: 46824 RVA: 0x00104AE9 File Offset: 0x00102CE9
		public void SetBloomMaxBrightness(float NewValue)
		{
			ULightComponent.__SetBloomMaxBrightness_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x0600B6E9 RID: 46825 RVA: 0x00104AF7 File Offset: 0x00102CF7
		public void SetAffectTranslucentLighting(bool bNewValue)
		{
			ULightComponent.__SetAffectTranslucentLighting_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600B6EA RID: 46826 RVA: 0x00104B05 File Offset: 0x00102D05
		public void SetAffectDynamicIndirectLighting(bool bNewValue)
		{
			ULightComponent.__SetAffectDynamicIndirectLighting_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x0600B6EB RID: 46827 RVA: 0x00104B13 File Offset: 0x00102D13
		public bool GetUsePointLightFallOffColor()
		{
			return ULightComponent.__GetUsePointLightFallOffColor_Internal(base.NativePtr);
		}

		// Token: 0x0600B6EC RID: 46828 RVA: 0x00104B20 File Offset: 0x00102D20
		public float GetToonPointLightFallOff()
		{
			return ULightComponent.__GetToonPointLightFallOff_Internal(base.NativePtr);
		}

		// Token: 0x0600B6ED RID: 46829 RVA: 0x00104B2D File Offset: 0x00102D2D
		public TEnumAsByte<EToonLightType> GetToonLightType()
		{
			return ULightComponent.__GetToonLightType_Internal(base.NativePtr);
		}

		// Token: 0x0600B6EE RID: 46830 RVA: 0x00104B3A File Offset: 0x00102D3A
		public float GetToonIntensity()
		{
			return ULightComponent.__GetToonIntensity_Internal(base.NativePtr);
		}

		// Token: 0x0600B6EF RID: 46831 RVA: 0x00104B47 File Offset: 0x00102D47
		public TEnumAsByte<ERaytraceType> GetRaytraceType()
		{
			return ULightComponent.__GetRaytraceType_Internal(base.NativePtr);
		}

		// Token: 0x0600B6F0 RID: 46832 RVA: 0x00104B54 File Offset: 0x00102D54
		public TEnumAsByte<ELightMegaLightsType> GetMegaLightsType()
		{
			return ULightComponent.__GetMegaLightsType_Internal(base.NativePtr);
		}

		// Token: 0x0600B6F1 RID: 46833 RVA: 0x00104B61 File Offset: 0x00102D61
		public FLinearColor GetLightToonColor()
		{
			return ULightComponent.__GetLightToonColor_Internal(base.NativePtr);
		}

		// Token: 0x0600B6F2 RID: 46834 RVA: 0x00104B6E File Offset: 0x00102D6E
		public TEnumAsByte<ELightQualityType> GetLightShadowQualityType_PC()
		{
			return ULightComponent.__GetLightShadowQualityType_PC_Internal(base.NativePtr);
		}

		// Token: 0x0600B6F3 RID: 46835 RVA: 0x00104B7B File Offset: 0x00102D7B
		public TEnumAsByte<ELightQualityType> GetLightQualityType_PC()
		{
			return ULightComponent.__GetLightQualityType_PC_Internal(base.NativePtr);
		}

		// Token: 0x0600B6F4 RID: 46836 RVA: 0x00104B88 File Offset: 0x00102D88
		public TEnumAsByte<ELightQualityType> GetLightQualityType()
		{
			return ULightComponent.__GetLightQualityType_Internal(base.NativePtr);
		}

		// Token: 0x0600B6F5 RID: 46837 RVA: 0x00104B95 File Offset: 0x00102D95
		public TEnumAsByte<ELightDistanceCullType> GetLightDistanceCullType()
		{
			return ULightComponent.__GetLightDistanceCullType_Internal(base.NativePtr);
		}

		// Token: 0x0600B6F6 RID: 46838 RVA: 0x00104BA2 File Offset: 0x00102DA2
		public bool GetIgnoreLightVolumeDistanceCull()
		{
			return ULightComponent.__GetIgnoreLightVolumeDistanceCull_Internal(base.NativePtr);
		}

		// Token: 0x0600B6F7 RID: 46839 RVA: 0x00104BAF File Offset: 0x00102DAF
		public float GetCastDynamicShadowInCaveFadeIntensity()
		{
			return ULightComponent.__GetCastDynamicShadowInCaveFadeIntensity_Internal(base.NativePtr);
		}

		// Token: 0x0600B6F8 RID: 46840
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SyncToToonLight_Internal(IntPtr @this);

		// Token: 0x0600B6F9 RID: 46841
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumetricScatteringIntensity_Internal(IntPtr @this, float NewIntensity);

		// Token: 0x0600B6FA RID: 46842
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumetricLightFunctionMaterial_Internal(IntPtr @this, IntPtr NewLightFunctionMaterial);

		// Token: 0x0600B6FB RID: 46843
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUsePointLightFallOffColor_Internal(IntPtr @this, bool InUsePointLightFallOffColor);

		// Token: 0x0600B6FC RID: 46844
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseIESBrightness_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x0600B6FD RID: 46845
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTransmission_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x0600B6FE RID: 46846
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonShadowColorIntensity_Internal(IntPtr @this, float InToonShadowColorIntensity);

		// Token: 0x0600B6FF RID: 46847
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonRealTimeShadowIntensity_Internal(IntPtr @this, float InToonRealTimeShadowIntensity);

		// Token: 0x0600B700 RID: 46848
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonPointLightFallOff_Internal(IntPtr @this, float InToonPointLightFallOff);

		// Token: 0x0600B701 RID: 46849
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonLightType_Internal(IntPtr @this, TEnumAsByte<EToonLightType> InToonLightType);

		// Token: 0x0600B702 RID: 46850
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonLightingPriority_Internal(IntPtr @this, int InToonLightingPriority);

		// Token: 0x0600B703 RID: 46851
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonIntensity_Internal(IntPtr @this, float InToonIntensity);

		// Token: 0x0600B704 RID: 46852
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonHardShadowRange_Internal(IntPtr @this, float InToonHardShadowRange);

		// Token: 0x0600B705 RID: 46853
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonHardShadowIntensity_Internal(IntPtr @this, float InToonHardShadowIntensity);

		// Token: 0x0600B706 RID: 46854
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonHardShadowColor_Internal(IntPtr @this, FLinearColor InToonHardShadowColor);

		// Token: 0x0600B707 RID: 46855
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonHardShadowBlend_Internal(IntPtr @this, float InToonHardShadowBlend);

		// Token: 0x0600B708 RID: 46856
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonHardBaseColor_Internal(IntPtr @this, FLinearColor InToonHardBaseColor);

		// Token: 0x0600B709 RID: 46857
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonDistanceBlendIntensity_Internal(IntPtr @this, float InToonDistanceBlendIntensity);

		// Token: 0x0600B70A RID: 46858
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonDistanceBlendAtten_Internal(IntPtr @this, float InToonDistanceBlendAtten);

		// Token: 0x0600B70B RID: 46859
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonBaseColorIntensity_Internal(IntPtr @this, float InToonBaseColorIntensity);

		// Token: 0x0600B70C RID: 46860
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTemperature_Internal(IntPtr @this, float NewTemperature);

		// Token: 0x0600B70D RID: 46861
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpecularScale_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600B70E RID: 46862
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowSlopeBias_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600B70F RID: 46863
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowBias_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600B710 RID: 46864
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetRaytraceType_Internal(IntPtr @this, TEnumAsByte<ERaytraceType> InRaytraceType);

		// Token: 0x0600B711 RID: 46865
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOcclusionMaskDarkness_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600B712 RID: 46866
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOcclusionDepthRange_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600B713 RID: 46867
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinDrawDistance_Internal(IntPtr @this, float InMinDrawDistance);

		// Token: 0x0600B714 RID: 46868
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinDistanceFadeRange_Internal(IntPtr @this, float InMinDistanceFadeRange);

		// Token: 0x0600B715 RID: 46869
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMegaLightsType_Internal(IntPtr @this, TEnumAsByte<ELightMegaLightsType> InMegaLightsType);

		// Token: 0x0600B716 RID: 46870
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxDrawDistance_Internal(IntPtr @this, float InMaxDrawDistance);

		// Token: 0x0600B717 RID: 46871
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxDistanceFadeRange_Internal(IntPtr @this, float InMaxDistanceFadeRange);

		// Token: 0x0600B718 RID: 46872
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightToonIntensity_Internal(IntPtr @this, float NewIntensity);

		// Token: 0x0600B719 RID: 46873
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightToonColor_Internal(IntPtr @this, FLinearColor NewLightColor, bool bSRGB);

		// Token: 0x0600B71A RID: 46874
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightShadowQualityType_PC_Internal(IntPtr @this, TEnumAsByte<ELightQualityType> InLightQualityType);

		// Token: 0x0600B71B RID: 46875
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightQualityType_PC_Internal(IntPtr @this, TEnumAsByte<ELightQualityType> InLightQualityType);

		// Token: 0x0600B71C RID: 46876
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightQualityType_Internal(IntPtr @this, TEnumAsByte<ELightQualityType> InLightQualityType);

		// Token: 0x0600B71D RID: 46877
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightingChannels_Internal(IntPtr @this, bool bChannel0, bool bChannel1, bool bChannel2);

		// Token: 0x0600B71E RID: 46878
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightFunctionScale_Internal(IntPtr @this, FVector NewLightFunctionScale);

		// Token: 0x0600B71F RID: 46879
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightFunctionMaterial_Internal(IntPtr @this, IntPtr NewLightFunctionMaterial);

		// Token: 0x0600B720 RID: 46880
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightFunctionFadeDistance_Internal(IntPtr @this, float NewLightFunctionFadeDistance);

		// Token: 0x0600B721 RID: 46881
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightFunctionDisabledBrightness_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600B722 RID: 46882
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightDistanceCullType_Internal(IntPtr @this, TEnumAsByte<ELightDistanceCullType> InLightDistanceCullType);

		// Token: 0x0600B723 RID: 46883
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightColor_Internal(IntPtr @this, FLinearColor NewLightColor, bool bSRGB);

		// Token: 0x0600B724 RID: 46884
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsUIScenePrimitive_Internal(IntPtr @this, bool bValue);

		// Token: 0x0600B725 RID: 46885
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIntensity_Internal(IntPtr @this, float NewIntensity);

		// Token: 0x0600B726 RID: 46886
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIndirectLightingIntensity_Internal(IntPtr @this, float NewIntensity);

		// Token: 0x0600B727 RID: 46887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIgnoreLightVolumeDistanceCull_Internal(IntPtr @this, bool IsIgnoreVolumeDistanceCull);

		// Token: 0x0600B728 RID: 46888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIESTexture_Internal(IntPtr @this, IntPtr NewValue);

		// Token: 0x0600B729 RID: 46889
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIESBrightnessScale_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600B72A RID: 46890
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceCachedShadowsForMovablePrimitives_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x0600B72B RID: 46891
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableLightShaftOcclusion_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x0600B72C RID: 46892
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableLightShaftBloom_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x0600B72D RID: 46893
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastDynamicShadowInCaveFadeIntensity_Internal(IntPtr @this, float InCastDynamicShadowInCaveFadeIntensity);

		// Token: 0x0600B72E RID: 46894
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBloomTint_Internal(IntPtr @this, FColor NewValue);

		// Token: 0x0600B72F RID: 46895
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBloomThreshold_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600B730 RID: 46896
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBloomScale_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600B731 RID: 46897
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBloomMaxBrightness_Internal(IntPtr @this, float NewValue);

		// Token: 0x0600B732 RID: 46898
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAffectTranslucentLighting_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x0600B733 RID: 46899
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAffectDynamicIndirectLighting_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x0600B734 RID: 46900
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetUsePointLightFallOffColor_Internal(IntPtr @this);

		// Token: 0x0600B735 RID: 46901
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetToonPointLightFallOff_Internal(IntPtr @this);

		// Token: 0x0600B736 RID: 46902
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<EToonLightType> __GetToonLightType_Internal(IntPtr @this);

		// Token: 0x0600B737 RID: 46903
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetToonIntensity_Internal(IntPtr @this);

		// Token: 0x0600B738 RID: 46904
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ERaytraceType> __GetRaytraceType_Internal(IntPtr @this);

		// Token: 0x0600B739 RID: 46905
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ELightMegaLightsType> __GetMegaLightsType_Internal(IntPtr @this);

		// Token: 0x0600B73A RID: 46906
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetLightToonColor_Internal(IntPtr @this);

		// Token: 0x0600B73B RID: 46907
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ELightQualityType> __GetLightShadowQualityType_PC_Internal(IntPtr @this);

		// Token: 0x0600B73C RID: 46908
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ELightQualityType> __GetLightQualityType_PC_Internal(IntPtr @this);

		// Token: 0x0600B73D RID: 46909
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ELightQualityType> __GetLightQualityType_Internal(IntPtr @this);

		// Token: 0x0600B73E RID: 46910
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ELightDistanceCullType> __GetLightDistanceCullType_Internal(IntPtr @this);

		// Token: 0x0600B73F RID: 46911
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIgnoreLightVolumeDistanceCull_Internal(IntPtr @this);

		// Token: 0x0600B740 RID: 46912
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCastDynamicShadowInCaveFadeIntensity_Internal(IntPtr @this);

		// Token: 0x0600B741 RID: 46913 RVA: 0x00104BBC File Offset: 0x00102DBC
		static ULightComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LightComponent");
		}

		// Token: 0x0600B742 RID: 46914 RVA: 0x00104BCC File Offset: 0x00102DCC
		protected ULightComponent() : this(BuiltinUtils.AllocNativeUObject(ULightComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600B743 RID: 46915 RVA: 0x00104BF4 File Offset: 0x00102DF4
		protected ULightComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04005FA4 RID: 24484
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LightComponent";

		// Token: 0x04005FA5 RID: 24485
		private static IntPtr _ClassPtr;

		// Token: 0x04005FA6 RID: 24486
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04005FA7 RID: 24487
		internal static int __PropertyOffset_Temperature;

		// Token: 0x04005FA8 RID: 24488
		internal static int __PropertyOffset_LightDistanceCullType;

		// Token: 0x04005FA9 RID: 24489
		internal static int __PropertyOffset_MinDrawDistance;

		// Token: 0x04005FAA RID: 24490
		internal static int __PropertyOffset_MaxDrawDistance;

		// Token: 0x04005FAB RID: 24491
		internal static int __PropertyOffset_MinDistanceFadeRange;

		// Token: 0x04005FAC RID: 24492
		internal static int __PropertyOffset_MaxDistanceFadeRange;

		// Token: 0x04005FAD RID: 24493
		internal static int __PropertyOffset_IgnoreLightVolumeDistanceCull;

		// Token: 0x04005FAE RID: 24494
		internal static int __PropertyOffset_bSyncToToonLight;

		// Token: 0x04005FAF RID: 24495
		internal static int __PropertyOffset_CustomCullFlag;

		// Token: 0x04005FB0 RID: 24496
		internal static int __PropertyOffset_LightQualityType;

		// Token: 0x04005FB1 RID: 24497
		internal static int __PropertyOffset_LightQualityType_PC;

		// Token: 0x04005FB2 RID: 24498
		internal static int __PropertyOffset_LightShadowQualityType_PC;

		// Token: 0x04005FB3 RID: 24499
		internal static int __PropertyOffset_RaytraceType;

		// Token: 0x04005FB4 RID: 24500
		internal static int __PropertyOffset_MegaLightsType;

		// Token: 0x04005FB5 RID: 24501
		internal static int __PropertyOffset_bUseTemperature;

		// Token: 0x04005FB6 RID: 24502
		internal static byte __PropertyMask_bUseTemperature;

		// Token: 0x04005FB7 RID: 24503
		internal static int __PropertyOffset_ShadowMapChannel_DEPRECATED;

		// Token: 0x04005FB8 RID: 24504
		internal static int __PropertyOffset_MinRoughness_DEPRECATED;

		// Token: 0x04005FB9 RID: 24505
		internal static int __PropertyOffset_SpecularScale;

		// Token: 0x04005FBA RID: 24506
		internal static int __PropertyOffset_ShadowResolutionScale;

		// Token: 0x04005FBB RID: 24507
		internal static int __PropertyOffset_ShadowBias;

		// Token: 0x04005FBC RID: 24508
		internal static int __PropertyOffset_ShadowSlopeBias;

		// Token: 0x04005FBD RID: 24509
		internal static int __PropertyOffset_ShadowSharpen;

		// Token: 0x04005FBE RID: 24510
		internal static int __PropertyOffset_ContactShadowLength;

		// Token: 0x04005FBF RID: 24511
		internal static int __PropertyOffset_ContactShadowNearLength;

		// Token: 0x04005FC0 RID: 24512
		internal static int __PropertyOffset_ContactShadowLengthInWS;

		// Token: 0x04005FC1 RID: 24513
		internal static byte __PropertyMask_ContactShadowLengthInWS;

		// Token: 0x04005FC2 RID: 24514
		internal static int __PropertyOffset_ContactShadowCastingIntensity;

		// Token: 0x04005FC3 RID: 24515
		internal static int __PropertyOffset_ContactShadowFoliageCastingIntensity;

		// Token: 0x04005FC4 RID: 24516
		internal static int __PropertyOffset_ContactShadowFadeDistance;

		// Token: 0x04005FC5 RID: 24517
		internal static int __PropertyOffset_ContactShadowBeginFadeDistance;

		// Token: 0x04005FC6 RID: 24518
		internal static int __PropertyOffset_InverseSquaredFalloff_DEPRECATED;

		// Token: 0x04005FC7 RID: 24519
		internal static byte __PropertyMask_InverseSquaredFalloff_DEPRECATED;

		// Token: 0x04005FC8 RID: 24520
		internal static int __PropertyOffset_CastTranslucentShadows;

		// Token: 0x04005FC9 RID: 24521
		internal static byte __PropertyMask_CastTranslucentShadows;

		// Token: 0x04005FCA RID: 24522
		internal static int __PropertyOffset_bCastShadowsFromCinematicObjectsOnly;

		// Token: 0x04005FCB RID: 24523
		internal static byte __PropertyMask_bCastShadowsFromCinematicObjectsOnly;

		// Token: 0x04005FCC RID: 24524
		internal static int __PropertyOffset_bAffectDynamicIndirectLighting;

		// Token: 0x04005FCD RID: 24525
		internal static byte __PropertyMask_bAffectDynamicIndirectLighting;

		// Token: 0x04005FCE RID: 24526
		internal static int __PropertyOffset_bForceCachedShadowsForMovablePrimitives;

		// Token: 0x04005FCF RID: 24527
		internal static byte __PropertyMask_bForceCachedShadowsForMovablePrimitives;

		// Token: 0x04005FD0 RID: 24528
		internal static int __PropertyOffset_bAllowMegaLights;

		// Token: 0x04005FD1 RID: 24529
		internal static byte __PropertyMask_bAllowMegaLights;

		// Token: 0x04005FD2 RID: 24530
		internal static int __PropertyOffset_MegaLightsShadowMethod;

		// Token: 0x04005FD3 RID: 24531
		internal static int __PropertyOffset_LightingChannels;

		// Token: 0x04005FD4 RID: 24532
		[Nullable(2)]
		private FLightingChannels _LightingChannels;

		// Token: 0x04005FD5 RID: 24533
		internal static int __PropertyOffset_LightFunctionMaterial;

		// Token: 0x04005FD6 RID: 24534
		internal static int __PropertyOffset_VolumetricLightFunctionMaterial;

		// Token: 0x04005FD7 RID: 24535
		internal static int __PropertyOffset_LightFunctionScale;

		// Token: 0x04005FD8 RID: 24536
		internal static int __PropertyOffset_IESTexture;

		// Token: 0x04005FD9 RID: 24537
		internal static int __PropertyOffset_bUseIESBrightness;

		// Token: 0x04005FDA RID: 24538
		internal static byte __PropertyMask_bUseIESBrightness;

		// Token: 0x04005FDB RID: 24539
		internal static int __PropertyOffset_IESBrightnessScale;

		// Token: 0x04005FDC RID: 24540
		internal static int __PropertyOffset_LightFunctionFadeDistance;

		// Token: 0x04005FDD RID: 24541
		internal static int __PropertyOffset_DisabledBrightness;

		// Token: 0x04005FDE RID: 24542
		internal static int __PropertyOffset_bEnableLightShaftBloom;

		// Token: 0x04005FDF RID: 24543
		internal static byte __PropertyMask_bEnableLightShaftBloom;

		// Token: 0x04005FE0 RID: 24544
		internal static int __PropertyOffset_BloomScale;

		// Token: 0x04005FE1 RID: 24545
		internal static int __PropertyOffset_BloomThreshold;

		// Token: 0x04005FE2 RID: 24546
		internal static int __PropertyOffset_BloomMaxBrightness;

		// Token: 0x04005FE3 RID: 24547
		internal static int __PropertyOffset_BloomTint;

		// Token: 0x04005FE4 RID: 24548
		internal static int __PropertyOffset_bUseRayTracedDistanceFieldShadows;

		// Token: 0x04005FE5 RID: 24549
		internal static int __PropertyOffset_RayStartOffsetDepthScale;

		// Token: 0x04005FE6 RID: 24550
		internal static int __PropertyOffset_bEnableLightShaftOcclusion;

		// Token: 0x04005FE7 RID: 24551
		internal static byte __PropertyMask_bEnableLightShaftOcclusion;

		// Token: 0x04005FE8 RID: 24552
		internal static int __PropertyOffset_OcclusionMaskDarkness;

		// Token: 0x04005FE9 RID: 24553
		internal static int __PropertyOffset_OcclusionDepthRange;

		// Token: 0x04005FEA RID: 24554
		internal static int __PropertyOffset_CastDynamicShadowInCaveFadeIntensity;

		// Token: 0x04005FEB RID: 24555
		internal static int __PropertyOffset_ToonPointLightFallOff;

		// Token: 0x04005FEC RID: 24556
		internal static int __PropertyOffset_bUsePointLightFallOffColor;

		// Token: 0x04005FED RID: 24557
		internal static int __PropertyOffset_ToonDistanceBlendAtten;

		// Token: 0x04005FEE RID: 24558
		internal static int __PropertyOffset_ToonDistanceBlendIntensity;

		// Token: 0x04005FEF RID: 24559
		internal static int __PropertyOffset_ToonLightType;

		// Token: 0x04005FF0 RID: 24560
		internal static int __PropertyOffset_ToonLightingPriority;

		// Token: 0x04005FF1 RID: 24561
		internal static int __PropertyOffset_ToonIntensity;

		// Token: 0x04005FF2 RID: 24562
		internal static int __PropertyOffset_ToonColor;

		// Token: 0x04005FF3 RID: 24563
		internal static int __PropertyOffset_ToonShadowColorIntensity;

		// Token: 0x04005FF4 RID: 24564
		internal static int __PropertyOffset_ToonBaseColorIntensity;

		// Token: 0x04005FF5 RID: 24565
		internal static int __PropertyOffset_ToonRealTimeShadowIntensity;

		// Token: 0x04005FF6 RID: 24566
		internal static int __PropertyOffset_ToonLightingChannels;

		// Token: 0x04005FF7 RID: 24567
		[Nullable(2)]
		private FLightingChannels _ToonLightingChannels;

		// Token: 0x04005FF8 RID: 24568
		internal static int __PropertyOffset_ToonHardShadowIntensity;

		// Token: 0x04005FF9 RID: 24569
		internal static int __PropertyOffset_ToonHardShadowRange;

		// Token: 0x04005FFA RID: 24570
		internal static int __PropertyOffset_ToonHardBaseColor;

		// Token: 0x04005FFB RID: 24571
		internal static int __PropertyOffset_ToonHardShadowColor;

		// Token: 0x04005FFC RID: 24572
		internal static int __PropertyOffset_ToonHardShadowBlend;

		// Token: 0x04005FFD RID: 24573
		internal static int __PropertyOffset_IsUIScenePrimitive;
	}
}
