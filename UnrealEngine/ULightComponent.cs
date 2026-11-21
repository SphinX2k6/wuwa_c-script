using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000236 RID: 566
	[UnrealObjectPath("/Script/Engine.LightComponent")]
	[UnrealStructLayout(1088, 16, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1088)]
	public abstract class ULightComponent : ULightComponentBase, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06002DEC RID: 11756 RVA: 0x00040DE1 File Offset: 0x0003EFE1
		public new static UClassStackOnlyPtr StaticClass()
		{
			return ULightComponent._ClassPtr;
		}

		// Token: 0x1700057C RID: 1404
		// (get) Token: 0x06002DED RID: 11757 RVA: 0x00040DED File Offset: 0x0003EFED
		// (set) Token: 0x06002DEE RID: 11758 RVA: 0x00040DFD File Offset: 0x0003EFFD
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

		// Token: 0x1700057D RID: 1405
		// (get) Token: 0x06002DEF RID: 11759 RVA: 0x00040E0E File Offset: 0x0003F00E
		// (set) Token: 0x06002DF0 RID: 11760 RVA: 0x00040E1E File Offset: 0x0003F01E
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

		// Token: 0x1700057E RID: 1406
		// (get) Token: 0x06002DF1 RID: 11761 RVA: 0x00040E2F File Offset: 0x0003F02F
		// (set) Token: 0x06002DF2 RID: 11762 RVA: 0x00040E3F File Offset: 0x0003F03F
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

		// Token: 0x1700057F RID: 1407
		// (get) Token: 0x06002DF3 RID: 11763 RVA: 0x00040E50 File Offset: 0x0003F050
		// (set) Token: 0x06002DF4 RID: 11764 RVA: 0x00040E60 File Offset: 0x0003F060
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

		// Token: 0x17000580 RID: 1408
		// (get) Token: 0x06002DF5 RID: 11765 RVA: 0x00040E71 File Offset: 0x0003F071
		// (set) Token: 0x06002DF6 RID: 11766 RVA: 0x00040E81 File Offset: 0x0003F081
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

		// Token: 0x17000581 RID: 1409
		// (get) Token: 0x06002DF7 RID: 11767 RVA: 0x00040E92 File Offset: 0x0003F092
		// (set) Token: 0x06002DF8 RID: 11768 RVA: 0x00040EA2 File Offset: 0x0003F0A2
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

		// Token: 0x17000582 RID: 1410
		// (get) Token: 0x06002DF9 RID: 11769 RVA: 0x00040EB3 File Offset: 0x0003F0B3
		// (set) Token: 0x06002DFA RID: 11770 RVA: 0x00040EC3 File Offset: 0x0003F0C3
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

		// Token: 0x17000583 RID: 1411
		// (get) Token: 0x06002DFB RID: 11771 RVA: 0x00040ED4 File Offset: 0x0003F0D4
		// (set) Token: 0x06002DFC RID: 11772 RVA: 0x00040EE4 File Offset: 0x0003F0E4
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

		// Token: 0x17000584 RID: 1412
		// (get) Token: 0x06002DFD RID: 11773 RVA: 0x00040EF5 File Offset: 0x0003F0F5
		// (set) Token: 0x06002DFE RID: 11774 RVA: 0x00040F09 File Offset: 0x0003F109
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

		// Token: 0x17000585 RID: 1413
		// (get) Token: 0x06002DFF RID: 11775 RVA: 0x00040F1E File Offset: 0x0003F11E
		// (set) Token: 0x06002E00 RID: 11776 RVA: 0x00040F32 File Offset: 0x0003F132
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

		// Token: 0x17000586 RID: 1414
		// (get) Token: 0x06002E01 RID: 11777 RVA: 0x00040F47 File Offset: 0x0003F147
		// (set) Token: 0x06002E02 RID: 11778 RVA: 0x00040F5B File Offset: 0x0003F15B
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

		// Token: 0x17000587 RID: 1415
		// (get) Token: 0x06002E03 RID: 11779 RVA: 0x00040F70 File Offset: 0x0003F170
		// (set) Token: 0x06002E04 RID: 11780 RVA: 0x00040F89 File Offset: 0x0003F189
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

		// Token: 0x17000588 RID: 1416
		// (get) Token: 0x06002E05 RID: 11781 RVA: 0x00040FB9 File Offset: 0x0003F1B9
		// (set) Token: 0x06002E06 RID: 11782 RVA: 0x00040FC9 File Offset: 0x0003F1C9
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

		// Token: 0x17000589 RID: 1417
		// (get) Token: 0x06002E07 RID: 11783 RVA: 0x00040FDA File Offset: 0x0003F1DA
		// (set) Token: 0x06002E08 RID: 11784 RVA: 0x00040FEA File Offset: 0x0003F1EA
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

		// Token: 0x1700058A RID: 1418
		// (get) Token: 0x06002E09 RID: 11785 RVA: 0x00040FFB File Offset: 0x0003F1FB
		// (set) Token: 0x06002E0A RID: 11786 RVA: 0x0004100B File Offset: 0x0003F20B
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

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x06002E0B RID: 11787 RVA: 0x0004101C File Offset: 0x0003F21C
		// (set) Token: 0x06002E0C RID: 11788 RVA: 0x0004102C File Offset: 0x0003F22C
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

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x06002E0D RID: 11789 RVA: 0x0004103D File Offset: 0x0003F23D
		// (set) Token: 0x06002E0E RID: 11790 RVA: 0x0004104D File Offset: 0x0003F24D
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

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x06002E0F RID: 11791 RVA: 0x0004105E File Offset: 0x0003F25E
		// (set) Token: 0x06002E10 RID: 11792 RVA: 0x0004106E File Offset: 0x0003F26E
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

		// Token: 0x1700058E RID: 1422
		// (get) Token: 0x06002E11 RID: 11793 RVA: 0x0004107F File Offset: 0x0003F27F
		// (set) Token: 0x06002E12 RID: 11794 RVA: 0x0004108F File Offset: 0x0003F28F
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

		// Token: 0x1700058F RID: 1423
		// (get) Token: 0x06002E13 RID: 11795 RVA: 0x000410A0 File Offset: 0x0003F2A0
		// (set) Token: 0x06002E14 RID: 11796 RVA: 0x000410B0 File Offset: 0x0003F2B0
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

		// Token: 0x17000590 RID: 1424
		// (get) Token: 0x06002E15 RID: 11797 RVA: 0x000410C1 File Offset: 0x0003F2C1
		// (set) Token: 0x06002E16 RID: 11798 RVA: 0x000410D1 File Offset: 0x0003F2D1
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

		// Token: 0x17000591 RID: 1425
		// (get) Token: 0x06002E17 RID: 11799 RVA: 0x000410E2 File Offset: 0x0003F2E2
		// (set) Token: 0x06002E18 RID: 11800 RVA: 0x000410FB File Offset: 0x0003F2FB
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

		// Token: 0x17000592 RID: 1426
		// (get) Token: 0x06002E19 RID: 11801 RVA: 0x0004112B File Offset: 0x0003F32B
		// (set) Token: 0x06002E1A RID: 11802 RVA: 0x0004113B File Offset: 0x0003F33B
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

		// Token: 0x17000593 RID: 1427
		// (get) Token: 0x06002E1B RID: 11803 RVA: 0x0004114C File Offset: 0x0003F34C
		// (set) Token: 0x06002E1C RID: 11804 RVA: 0x0004115C File Offset: 0x0003F35C
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

		// Token: 0x17000594 RID: 1428
		// (get) Token: 0x06002E1D RID: 11805 RVA: 0x0004116D File Offset: 0x0003F36D
		// (set) Token: 0x06002E1E RID: 11806 RVA: 0x0004117D File Offset: 0x0003F37D
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

		// Token: 0x17000595 RID: 1429
		// (get) Token: 0x06002E1F RID: 11807 RVA: 0x0004118E File Offset: 0x0003F38E
		// (set) Token: 0x06002E20 RID: 11808 RVA: 0x0004119E File Offset: 0x0003F39E
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

		// Token: 0x17000596 RID: 1430
		// (get) Token: 0x06002E21 RID: 11809 RVA: 0x000411AF File Offset: 0x0003F3AF
		// (set) Token: 0x06002E22 RID: 11810 RVA: 0x000411C8 File Offset: 0x0003F3C8
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

		// Token: 0x17000597 RID: 1431
		// (get) Token: 0x06002E23 RID: 11811 RVA: 0x000411F8 File Offset: 0x0003F3F8
		// (set) Token: 0x06002E24 RID: 11812 RVA: 0x00041211 File Offset: 0x0003F411
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

		// Token: 0x17000598 RID: 1432
		// (get) Token: 0x06002E25 RID: 11813 RVA: 0x00041241 File Offset: 0x0003F441
		// (set) Token: 0x06002E26 RID: 11814 RVA: 0x0004125A File Offset: 0x0003F45A
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

		// Token: 0x17000599 RID: 1433
		// (get) Token: 0x06002E27 RID: 11815 RVA: 0x0004128A File Offset: 0x0003F48A
		// (set) Token: 0x06002E28 RID: 11816 RVA: 0x000412A3 File Offset: 0x0003F4A3
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

		// Token: 0x1700059A RID: 1434
		// (get) Token: 0x06002E29 RID: 11817 RVA: 0x000412D3 File Offset: 0x0003F4D3
		// (set) Token: 0x06002E2A RID: 11818 RVA: 0x000412EC File Offset: 0x0003F4EC
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

		// Token: 0x1700059B RID: 1435
		// (get) Token: 0x06002E2B RID: 11819 RVA: 0x0004131C File Offset: 0x0003F51C
		// (set) Token: 0x06002E2C RID: 11820 RVA: 0x00041335 File Offset: 0x0003F535
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

		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06002E2D RID: 11821 RVA: 0x00041365 File Offset: 0x0003F565
		// (set) Token: 0x06002E2E RID: 11822 RVA: 0x00041379 File Offset: 0x0003F579
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

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06002E2F RID: 11823 RVA: 0x0004138E File Offset: 0x0003F58E
		// (set) Token: 0x06002E30 RID: 11824 RVA: 0x000413A2 File Offset: 0x0003F5A2
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

		// Token: 0x1700059E RID: 1438
		// (get) Token: 0x06002E31 RID: 11825 RVA: 0x000413B7 File Offset: 0x0003F5B7
		// (set) Token: 0x06002E32 RID: 11826 RVA: 0x000413CB File Offset: 0x0003F5CB
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

		// Token: 0x1700059F RID: 1439
		// (get) Token: 0x06002E33 RID: 11827 RVA: 0x000413E0 File Offset: 0x0003F5E0
		// (set) Token: 0x06002E34 RID: 11828 RVA: 0x000413F4 File Offset: 0x0003F5F4
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

		// Token: 0x170005A0 RID: 1440
		// (get) Token: 0x06002E35 RID: 11829 RVA: 0x00041409 File Offset: 0x0003F609
		// (set) Token: 0x06002E36 RID: 11830 RVA: 0x00041422 File Offset: 0x0003F622
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

		// Token: 0x170005A1 RID: 1441
		// (get) Token: 0x06002E37 RID: 11831 RVA: 0x00041452 File Offset: 0x0003F652
		// (set) Token: 0x06002E38 RID: 11832 RVA: 0x00041462 File Offset: 0x0003F662
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

		// Token: 0x170005A2 RID: 1442
		// (get) Token: 0x06002E39 RID: 11833 RVA: 0x00041473 File Offset: 0x0003F673
		// (set) Token: 0x06002E3A RID: 11834 RVA: 0x00041483 File Offset: 0x0003F683
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

		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06002E3B RID: 11835 RVA: 0x00041494 File Offset: 0x0003F694
		// (set) Token: 0x06002E3C RID: 11836 RVA: 0x000414A4 File Offset: 0x0003F6A4
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

		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06002E3D RID: 11837 RVA: 0x000414B5 File Offset: 0x0003F6B5
		// (set) Token: 0x06002E3E RID: 11838 RVA: 0x000414CE File Offset: 0x0003F6CE
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

		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x06002E3F RID: 11839 RVA: 0x000414FE File Offset: 0x0003F6FE
		// (set) Token: 0x06002E40 RID: 11840 RVA: 0x0004150E File Offset: 0x0003F70E
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

		// Token: 0x170005A6 RID: 1446
		// (get) Token: 0x06002E41 RID: 11841 RVA: 0x0004151F File Offset: 0x0003F71F
		// (set) Token: 0x06002E42 RID: 11842 RVA: 0x0004152F File Offset: 0x0003F72F
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

		// Token: 0x170005A7 RID: 1447
		// (get) Token: 0x06002E43 RID: 11843 RVA: 0x00041540 File Offset: 0x0003F740
		// (set) Token: 0x06002E44 RID: 11844 RVA: 0x00041550 File Offset: 0x0003F750
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

		// Token: 0x170005A8 RID: 1448
		// (get) Token: 0x06002E45 RID: 11845 RVA: 0x00041561 File Offset: 0x0003F761
		// (set) Token: 0x06002E46 RID: 11846 RVA: 0x00041575 File Offset: 0x0003F775
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

		// Token: 0x170005A9 RID: 1449
		// (get) Token: 0x06002E47 RID: 11847 RVA: 0x0004158A File Offset: 0x0003F78A
		// (set) Token: 0x06002E48 RID: 11848 RVA: 0x0004159A File Offset: 0x0003F79A
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

		// Token: 0x170005AA RID: 1450
		// (get) Token: 0x06002E49 RID: 11849 RVA: 0x000415AB File Offset: 0x0003F7AB
		// (set) Token: 0x06002E4A RID: 11850 RVA: 0x000415BB File Offset: 0x0003F7BB
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

		// Token: 0x170005AB RID: 1451
		// (get) Token: 0x06002E4B RID: 11851 RVA: 0x000415CC File Offset: 0x0003F7CC
		// (set) Token: 0x06002E4C RID: 11852 RVA: 0x000415E5 File Offset: 0x0003F7E5
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

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06002E4D RID: 11853 RVA: 0x00041615 File Offset: 0x0003F815
		// (set) Token: 0x06002E4E RID: 11854 RVA: 0x00041625 File Offset: 0x0003F825
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

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x06002E4F RID: 11855 RVA: 0x00041636 File Offset: 0x0003F836
		// (set) Token: 0x06002E50 RID: 11856 RVA: 0x00041646 File Offset: 0x0003F846
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

		// Token: 0x170005AE RID: 1454
		// (get) Token: 0x06002E51 RID: 11857 RVA: 0x00041657 File Offset: 0x0003F857
		// (set) Token: 0x06002E52 RID: 11858 RVA: 0x00041667 File Offset: 0x0003F867
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

		// Token: 0x170005AF RID: 1455
		// (get) Token: 0x06002E53 RID: 11859 RVA: 0x00041678 File Offset: 0x0003F878
		// (set) Token: 0x06002E54 RID: 11860 RVA: 0x00041688 File Offset: 0x0003F888
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

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x06002E55 RID: 11861 RVA: 0x00041699 File Offset: 0x0003F899
		// (set) Token: 0x06002E56 RID: 11862 RVA: 0x000416A9 File Offset: 0x0003F8A9
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

		// Token: 0x170005B1 RID: 1457
		// (get) Token: 0x06002E57 RID: 11863 RVA: 0x000416BA File Offset: 0x0003F8BA
		// (set) Token: 0x06002E58 RID: 11864 RVA: 0x000416CA File Offset: 0x0003F8CA
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

		// Token: 0x170005B2 RID: 1458
		// (get) Token: 0x06002E59 RID: 11865 RVA: 0x000416DB File Offset: 0x0003F8DB
		// (set) Token: 0x06002E5A RID: 11866 RVA: 0x000416EB File Offset: 0x0003F8EB
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

		// Token: 0x170005B3 RID: 1459
		// (get) Token: 0x06002E5B RID: 11867 RVA: 0x000416FC File Offset: 0x0003F8FC
		// (set) Token: 0x06002E5C RID: 11868 RVA: 0x0004170C File Offset: 0x0003F90C
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

		// Token: 0x170005B4 RID: 1460
		// (get) Token: 0x06002E5D RID: 11869 RVA: 0x0004171D File Offset: 0x0003F91D
		// (set) Token: 0x06002E5E RID: 11870 RVA: 0x0004172D File Offset: 0x0003F92D
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

		// Token: 0x170005B5 RID: 1461
		// (get) Token: 0x06002E5F RID: 11871 RVA: 0x0004173E File Offset: 0x0003F93E
		// (set) Token: 0x06002E60 RID: 11872 RVA: 0x00041752 File Offset: 0x0003F952
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

		// Token: 0x170005B6 RID: 1462
		// (get) Token: 0x06002E61 RID: 11873 RVA: 0x00041767 File Offset: 0x0003F967
		// (set) Token: 0x06002E62 RID: 11874 RVA: 0x00041777 File Offset: 0x0003F977
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

		// Token: 0x170005B7 RID: 1463
		// (get) Token: 0x06002E63 RID: 11875 RVA: 0x00041788 File Offset: 0x0003F988
		// (set) Token: 0x06002E64 RID: 11876 RVA: 0x00041798 File Offset: 0x0003F998
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

		// Token: 0x170005B8 RID: 1464
		// (get) Token: 0x06002E65 RID: 11877 RVA: 0x000417A9 File Offset: 0x0003F9A9
		// (set) Token: 0x06002E66 RID: 11878 RVA: 0x000417B9 File Offset: 0x0003F9B9
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

		// Token: 0x170005B9 RID: 1465
		// (get) Token: 0x06002E67 RID: 11879 RVA: 0x000417CA File Offset: 0x0003F9CA
		// (set) Token: 0x06002E68 RID: 11880 RVA: 0x000417DA File Offset: 0x0003F9DA
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

		// Token: 0x170005BA RID: 1466
		// (get) Token: 0x06002E69 RID: 11881 RVA: 0x000417EB File Offset: 0x0003F9EB
		// (set) Token: 0x06002E6A RID: 11882 RVA: 0x000417FB File Offset: 0x0003F9FB
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

		// Token: 0x170005BB RID: 1467
		// (get) Token: 0x06002E6B RID: 11883 RVA: 0x0004180C File Offset: 0x0003FA0C
		// (set) Token: 0x06002E6C RID: 11884 RVA: 0x00041820 File Offset: 0x0003FA20
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

		// Token: 0x170005BC RID: 1468
		// (get) Token: 0x06002E6D RID: 11885 RVA: 0x00041835 File Offset: 0x0003FA35
		// (set) Token: 0x06002E6E RID: 11886 RVA: 0x00041849 File Offset: 0x0003FA49
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

		// Token: 0x170005BD RID: 1469
		// (get) Token: 0x06002E6F RID: 11887 RVA: 0x0004185E File Offset: 0x0003FA5E
		// (set) Token: 0x06002E70 RID: 11888 RVA: 0x0004186E File Offset: 0x0003FA6E
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

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06002E71 RID: 11889 RVA: 0x0004187F File Offset: 0x0003FA7F
		// (set) Token: 0x06002E72 RID: 11890 RVA: 0x0004188F File Offset: 0x0003FA8F
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

		// Token: 0x06002E73 RID: 11891 RVA: 0x000418A0 File Offset: 0x0003FAA0
		public void SyncToToonLight()
		{
			ULightComponent.__SyncToToonLight_Internal(base.NativePtr);
		}

		// Token: 0x06002E74 RID: 11892 RVA: 0x000418AD File Offset: 0x0003FAAD
		public void SetVolumetricScatteringIntensity(float NewIntensity)
		{
			ULightComponent.__SetVolumetricScatteringIntensity_Internal(base.NativePtr, NewIntensity);
		}

		// Token: 0x06002E75 RID: 11893 RVA: 0x000418BB File Offset: 0x0003FABB
		[NullableContext(2)]
		public void SetVolumetricLightFunctionMaterial(UMaterialInterface NewLightFunctionMaterial)
		{
			ULightComponent.__SetVolumetricLightFunctionMaterial_Internal(base.NativePtr, (NewLightFunctionMaterial != null) ? NewLightFunctionMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002E76 RID: 11894 RVA: 0x000418D8 File Offset: 0x0003FAD8
		public void SetUsePointLightFallOffColor(bool InUsePointLightFallOffColor)
		{
			ULightComponent.__SetUsePointLightFallOffColor_Internal(base.NativePtr, InUsePointLightFallOffColor);
		}

		// Token: 0x06002E77 RID: 11895 RVA: 0x000418E6 File Offset: 0x0003FAE6
		public void SetUseIESBrightness(bool bNewValue)
		{
			ULightComponent.__SetUseIESBrightness_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x06002E78 RID: 11896 RVA: 0x000418F4 File Offset: 0x0003FAF4
		public void SetTransmission(bool bNewValue)
		{
			ULightComponent.__SetTransmission_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x06002E79 RID: 11897 RVA: 0x00041902 File Offset: 0x0003FB02
		public void SetToonShadowColorIntensity(float InToonShadowColorIntensity)
		{
			ULightComponent.__SetToonShadowColorIntensity_Internal(base.NativePtr, InToonShadowColorIntensity);
		}

		// Token: 0x06002E7A RID: 11898 RVA: 0x00041910 File Offset: 0x0003FB10
		public void SetToonRealTimeShadowIntensity(float InToonRealTimeShadowIntensity)
		{
			ULightComponent.__SetToonRealTimeShadowIntensity_Internal(base.NativePtr, InToonRealTimeShadowIntensity);
		}

		// Token: 0x06002E7B RID: 11899 RVA: 0x0004191E File Offset: 0x0003FB1E
		public void SetToonPointLightFallOff(float InToonPointLightFallOff)
		{
			ULightComponent.__SetToonPointLightFallOff_Internal(base.NativePtr, InToonPointLightFallOff);
		}

		// Token: 0x06002E7C RID: 11900 RVA: 0x0004192C File Offset: 0x0003FB2C
		public void SetToonLightingPriority(int InToonLightingPriority)
		{
			ULightComponent.__SetToonLightingPriority_Internal(base.NativePtr, InToonLightingPriority);
		}

		// Token: 0x06002E7D RID: 11901 RVA: 0x0004193A File Offset: 0x0003FB3A
		public void SetToonIntensity(float InToonIntensity)
		{
			ULightComponent.__SetToonIntensity_Internal(base.NativePtr, InToonIntensity);
		}

		// Token: 0x06002E7E RID: 11902 RVA: 0x00041948 File Offset: 0x0003FB48
		public void SetToonHardShadowRange(float InToonHardShadowRange)
		{
			ULightComponent.__SetToonHardShadowRange_Internal(base.NativePtr, InToonHardShadowRange);
		}

		// Token: 0x06002E7F RID: 11903 RVA: 0x00041956 File Offset: 0x0003FB56
		public void SetToonHardShadowIntensity(float InToonHardShadowIntensity)
		{
			ULightComponent.__SetToonHardShadowIntensity_Internal(base.NativePtr, InToonHardShadowIntensity);
		}

		// Token: 0x06002E80 RID: 11904 RVA: 0x00041964 File Offset: 0x0003FB64
		public void SetToonHardShadowColor(FLinearColor InToonHardShadowColor)
		{
			ULightComponent.__SetToonHardShadowColor_Internal(base.NativePtr, InToonHardShadowColor);
		}

		// Token: 0x06002E81 RID: 11905 RVA: 0x00041972 File Offset: 0x0003FB72
		public void SetToonHardShadowBlend(float InToonHardShadowBlend)
		{
			ULightComponent.__SetToonHardShadowBlend_Internal(base.NativePtr, InToonHardShadowBlend);
		}

		// Token: 0x06002E82 RID: 11906 RVA: 0x00041980 File Offset: 0x0003FB80
		public void SetToonHardBaseColor(FLinearColor InToonHardBaseColor)
		{
			ULightComponent.__SetToonHardBaseColor_Internal(base.NativePtr, InToonHardBaseColor);
		}

		// Token: 0x06002E83 RID: 11907 RVA: 0x0004198E File Offset: 0x0003FB8E
		public void SetToonDistanceBlendIntensity(float InToonDistanceBlendIntensity)
		{
			ULightComponent.__SetToonDistanceBlendIntensity_Internal(base.NativePtr, InToonDistanceBlendIntensity);
		}

		// Token: 0x06002E84 RID: 11908 RVA: 0x0004199C File Offset: 0x0003FB9C
		public void SetToonDistanceBlendAtten(float InToonDistanceBlendAtten)
		{
			ULightComponent.__SetToonDistanceBlendAtten_Internal(base.NativePtr, InToonDistanceBlendAtten);
		}

		// Token: 0x06002E85 RID: 11909 RVA: 0x000419AA File Offset: 0x0003FBAA
		public void SetToonBaseColorIntensity(float InToonBaseColorIntensity)
		{
			ULightComponent.__SetToonBaseColorIntensity_Internal(base.NativePtr, InToonBaseColorIntensity);
		}

		// Token: 0x06002E86 RID: 11910 RVA: 0x000419B8 File Offset: 0x0003FBB8
		public void SetTemperature(float NewTemperature)
		{
			ULightComponent.__SetTemperature_Internal(base.NativePtr, NewTemperature);
		}

		// Token: 0x06002E87 RID: 11911 RVA: 0x000419C6 File Offset: 0x0003FBC6
		public void SetSpecularScale(float NewValue)
		{
			ULightComponent.__SetSpecularScale_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06002E88 RID: 11912 RVA: 0x000419D4 File Offset: 0x0003FBD4
		public void SetShadowSlopeBias(float NewValue)
		{
			ULightComponent.__SetShadowSlopeBias_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06002E89 RID: 11913 RVA: 0x000419E2 File Offset: 0x0003FBE2
		public void SetShadowBias(float NewValue)
		{
			ULightComponent.__SetShadowBias_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06002E8A RID: 11914 RVA: 0x000419F0 File Offset: 0x0003FBF0
		public void SetOcclusionMaskDarkness(float NewValue)
		{
			ULightComponent.__SetOcclusionMaskDarkness_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06002E8B RID: 11915 RVA: 0x000419FE File Offset: 0x0003FBFE
		public void SetOcclusionDepthRange(float NewValue)
		{
			ULightComponent.__SetOcclusionDepthRange_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06002E8C RID: 11916 RVA: 0x00041A0C File Offset: 0x0003FC0C
		public void SetMinDrawDistance(float InMinDrawDistance)
		{
			ULightComponent.__SetMinDrawDistance_Internal(base.NativePtr, InMinDrawDistance);
		}

		// Token: 0x06002E8D RID: 11917 RVA: 0x00041A1A File Offset: 0x0003FC1A
		public void SetMinDistanceFadeRange(float InMinDistanceFadeRange)
		{
			ULightComponent.__SetMinDistanceFadeRange_Internal(base.NativePtr, InMinDistanceFadeRange);
		}

		// Token: 0x06002E8E RID: 11918 RVA: 0x00041A28 File Offset: 0x0003FC28
		public void SetMaxDrawDistance(float InMaxDrawDistance)
		{
			ULightComponent.__SetMaxDrawDistance_Internal(base.NativePtr, InMaxDrawDistance);
		}

		// Token: 0x06002E8F RID: 11919 RVA: 0x00041A36 File Offset: 0x0003FC36
		public void SetMaxDistanceFadeRange(float InMaxDistanceFadeRange)
		{
			ULightComponent.__SetMaxDistanceFadeRange_Internal(base.NativePtr, InMaxDistanceFadeRange);
		}

		// Token: 0x06002E90 RID: 11920 RVA: 0x00041A44 File Offset: 0x0003FC44
		public void SetLightToonIntensity(float NewIntensity)
		{
			ULightComponent.__SetLightToonIntensity_Internal(base.NativePtr, NewIntensity);
		}

		// Token: 0x06002E91 RID: 11921 RVA: 0x00041A52 File Offset: 0x0003FC52
		public void SetLightToonColor(FLinearColor NewLightColor, bool bSRGB = true)
		{
			ULightComponent.__SetLightToonColor_Internal(base.NativePtr, NewLightColor, bSRGB);
		}

		// Token: 0x06002E92 RID: 11922 RVA: 0x00041A61 File Offset: 0x0003FC61
		public void SetLightShadowQualityType_PC(ELightQualityType InLightQualityType)
		{
			ULightComponent.__SetLightShadowQualityType_PC_Internal(base.NativePtr, InLightQualityType);
		}

		// Token: 0x06002E93 RID: 11923 RVA: 0x00041A74 File Offset: 0x0003FC74
		public void SetLightQualityType_PC(ELightQualityType InLightQualityType)
		{
			ULightComponent.__SetLightQualityType_PC_Internal(base.NativePtr, InLightQualityType);
		}

		// Token: 0x06002E94 RID: 11924 RVA: 0x00041A87 File Offset: 0x0003FC87
		public void SetLightQualityType(ELightQualityType InLightQualityType)
		{
			ULightComponent.__SetLightQualityType_Internal(base.NativePtr, InLightQualityType);
		}

		// Token: 0x06002E95 RID: 11925 RVA: 0x00041A9A File Offset: 0x0003FC9A
		public void SetLightingChannels(bool bChannel0, bool bChannel1, bool bChannel2)
		{
			ULightComponent.__SetLightingChannels_Internal(base.NativePtr, bChannel0, bChannel1, bChannel2);
		}

		// Token: 0x06002E96 RID: 11926 RVA: 0x00041AAA File Offset: 0x0003FCAA
		public void SetLightFunctionScale(FVector NewLightFunctionScale)
		{
			ULightComponent.__SetLightFunctionScale_Internal(base.NativePtr, NewLightFunctionScale);
		}

		// Token: 0x06002E97 RID: 11927 RVA: 0x00041AB8 File Offset: 0x0003FCB8
		[NullableContext(2)]
		public void SetLightFunctionMaterial(UMaterialInterface NewLightFunctionMaterial)
		{
			ULightComponent.__SetLightFunctionMaterial_Internal(base.NativePtr, (NewLightFunctionMaterial != null) ? NewLightFunctionMaterial.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002E98 RID: 11928 RVA: 0x00041AD5 File Offset: 0x0003FCD5
		public void SetLightFunctionFadeDistance(float NewLightFunctionFadeDistance)
		{
			ULightComponent.__SetLightFunctionFadeDistance_Internal(base.NativePtr, NewLightFunctionFadeDistance);
		}

		// Token: 0x06002E99 RID: 11929 RVA: 0x00041AE3 File Offset: 0x0003FCE3
		public void SetLightFunctionDisabledBrightness(float NewValue)
		{
			ULightComponent.__SetLightFunctionDisabledBrightness_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06002E9A RID: 11930 RVA: 0x00041AF1 File Offset: 0x0003FCF1
		public void SetLightColor(FLinearColor NewLightColor, bool bSRGB = true)
		{
			ULightComponent.__SetLightColor_Internal(base.NativePtr, NewLightColor, bSRGB);
		}

		// Token: 0x06002E9B RID: 11931 RVA: 0x00041B00 File Offset: 0x0003FD00
		public void SetIsUIScenePrimitive(bool bValue)
		{
			ULightComponent.__SetIsUIScenePrimitive_Internal(base.NativePtr, bValue);
		}

		// Token: 0x06002E9C RID: 11932 RVA: 0x00041B0E File Offset: 0x0003FD0E
		public void SetIntensity(float NewIntensity)
		{
			ULightComponent.__SetIntensity_Internal(base.NativePtr, NewIntensity);
		}

		// Token: 0x06002E9D RID: 11933 RVA: 0x00041B1C File Offset: 0x0003FD1C
		public void SetIndirectLightingIntensity(float NewIntensity)
		{
			ULightComponent.__SetIndirectLightingIntensity_Internal(base.NativePtr, NewIntensity);
		}

		// Token: 0x06002E9E RID: 11934 RVA: 0x00041B2A File Offset: 0x0003FD2A
		public void SetIgnoreLightVolumeDistanceCull(bool IsIgnoreVolumeDistanceCull)
		{
			ULightComponent.__SetIgnoreLightVolumeDistanceCull_Internal(base.NativePtr, IsIgnoreVolumeDistanceCull);
		}

		// Token: 0x06002E9F RID: 11935 RVA: 0x00041B38 File Offset: 0x0003FD38
		[NullableContext(2)]
		public void SetIESTexture(UTextureLightProfile NewValue)
		{
			ULightComponent.__SetIESTexture_Internal(base.NativePtr, (NewValue != null) ? NewValue.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06002EA0 RID: 11936 RVA: 0x00041B55 File Offset: 0x0003FD55
		public void SetIESBrightnessScale(float NewValue)
		{
			ULightComponent.__SetIESBrightnessScale_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06002EA1 RID: 11937 RVA: 0x00041B63 File Offset: 0x0003FD63
		public void SetForceCachedShadowsForMovablePrimitives(bool bNewValue)
		{
			ULightComponent.__SetForceCachedShadowsForMovablePrimitives_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x06002EA2 RID: 11938 RVA: 0x00041B71 File Offset: 0x0003FD71
		public void SetEnableLightShaftOcclusion(bool bNewValue)
		{
			ULightComponent.__SetEnableLightShaftOcclusion_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x06002EA3 RID: 11939 RVA: 0x00041B7F File Offset: 0x0003FD7F
		public void SetEnableLightShaftBloom(bool bNewValue)
		{
			ULightComponent.__SetEnableLightShaftBloom_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x06002EA4 RID: 11940 RVA: 0x00041B8D File Offset: 0x0003FD8D
		public void SetCastDynamicShadowInCaveFadeIntensity(float InCastDynamicShadowInCaveFadeIntensity)
		{
			ULightComponent.__SetCastDynamicShadowInCaveFadeIntensity_Internal(base.NativePtr, InCastDynamicShadowInCaveFadeIntensity);
		}

		// Token: 0x06002EA5 RID: 11941 RVA: 0x00041B9B File Offset: 0x0003FD9B
		public void SetBloomTint(FColor NewValue)
		{
			ULightComponent.__SetBloomTint_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06002EA6 RID: 11942 RVA: 0x00041BA9 File Offset: 0x0003FDA9
		public void SetBloomThreshold(float NewValue)
		{
			ULightComponent.__SetBloomThreshold_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06002EA7 RID: 11943 RVA: 0x00041BB7 File Offset: 0x0003FDB7
		public void SetBloomScale(float NewValue)
		{
			ULightComponent.__SetBloomScale_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06002EA8 RID: 11944 RVA: 0x00041BC5 File Offset: 0x0003FDC5
		public void SetBloomMaxBrightness(float NewValue)
		{
			ULightComponent.__SetBloomMaxBrightness_Internal(base.NativePtr, NewValue);
		}

		// Token: 0x06002EA9 RID: 11945 RVA: 0x00041BD3 File Offset: 0x0003FDD3
		public void SetAffectTranslucentLighting(bool bNewValue)
		{
			ULightComponent.__SetAffectTranslucentLighting_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x06002EAA RID: 11946 RVA: 0x00041BE1 File Offset: 0x0003FDE1
		public void SetAffectDynamicIndirectLighting(bool bNewValue)
		{
			ULightComponent.__SetAffectDynamicIndirectLighting_Internal(base.NativePtr, bNewValue);
		}

		// Token: 0x06002EAB RID: 11947 RVA: 0x00041BEF File Offset: 0x0003FDEF
		public bool GetUsePointLightFallOffColor()
		{
			return ULightComponent.__GetUsePointLightFallOffColor_Internal(base.NativePtr);
		}

		// Token: 0x06002EAC RID: 11948 RVA: 0x00041BFC File Offset: 0x0003FDFC
		public float GetToonPointLightFallOff()
		{
			return ULightComponent.__GetToonPointLightFallOff_Internal(base.NativePtr);
		}

		// Token: 0x06002EAD RID: 11949 RVA: 0x00041C09 File Offset: 0x0003FE09
		public float GetToonIntensity()
		{
			return ULightComponent.__GetToonIntensity_Internal(base.NativePtr);
		}

		// Token: 0x06002EAE RID: 11950 RVA: 0x00041C16 File Offset: 0x0003FE16
		public FLinearColor GetLightToonColor()
		{
			return ULightComponent.__GetLightToonColor_Internal(base.NativePtr);
		}

		// Token: 0x06002EAF RID: 11951 RVA: 0x00041C23 File Offset: 0x0003FE23
		public TEnumAsByte<ELightQualityType> GetLightShadowQualityType_PC()
		{
			return ULightComponent.__GetLightShadowQualityType_PC_Internal(base.NativePtr);
		}

		// Token: 0x06002EB0 RID: 11952 RVA: 0x00041C30 File Offset: 0x0003FE30
		public TEnumAsByte<ELightQualityType> GetLightQualityType_PC()
		{
			return ULightComponent.__GetLightQualityType_PC_Internal(base.NativePtr);
		}

		// Token: 0x06002EB1 RID: 11953 RVA: 0x00041C3D File Offset: 0x0003FE3D
		public TEnumAsByte<ELightQualityType> GetLightQualityType()
		{
			return ULightComponent.__GetLightQualityType_Internal(base.NativePtr);
		}

		// Token: 0x06002EB2 RID: 11954 RVA: 0x00041C4A File Offset: 0x0003FE4A
		public bool GetIgnoreLightVolumeDistanceCull()
		{
			return ULightComponent.__GetIgnoreLightVolumeDistanceCull_Internal(base.NativePtr);
		}

		// Token: 0x06002EB3 RID: 11955 RVA: 0x00041C57 File Offset: 0x0003FE57
		public float GetCastDynamicShadowInCaveFadeIntensity()
		{
			return ULightComponent.__GetCastDynamicShadowInCaveFadeIntensity_Internal(base.NativePtr);
		}

		// Token: 0x06002EB4 RID: 11956
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SyncToToonLight_Internal(IntPtr @this);

		// Token: 0x06002EB5 RID: 11957
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumetricScatteringIntensity_Internal(IntPtr @this, float NewIntensity);

		// Token: 0x06002EB6 RID: 11958
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetVolumetricLightFunctionMaterial_Internal(IntPtr @this, IntPtr NewLightFunctionMaterial);

		// Token: 0x06002EB7 RID: 11959
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUsePointLightFallOffColor_Internal(IntPtr @this, bool InUsePointLightFallOffColor);

		// Token: 0x06002EB8 RID: 11960
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetUseIESBrightness_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x06002EB9 RID: 11961
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTransmission_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x06002EBA RID: 11962
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonShadowColorIntensity_Internal(IntPtr @this, float InToonShadowColorIntensity);

		// Token: 0x06002EBB RID: 11963
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonRealTimeShadowIntensity_Internal(IntPtr @this, float InToonRealTimeShadowIntensity);

		// Token: 0x06002EBC RID: 11964
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonPointLightFallOff_Internal(IntPtr @this, float InToonPointLightFallOff);

		// Token: 0x06002EBD RID: 11965
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonLightingPriority_Internal(IntPtr @this, int InToonLightingPriority);

		// Token: 0x06002EBE RID: 11966
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonIntensity_Internal(IntPtr @this, float InToonIntensity);

		// Token: 0x06002EBF RID: 11967
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonHardShadowRange_Internal(IntPtr @this, float InToonHardShadowRange);

		// Token: 0x06002EC0 RID: 11968
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonHardShadowIntensity_Internal(IntPtr @this, float InToonHardShadowIntensity);

		// Token: 0x06002EC1 RID: 11969
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonHardShadowColor_Internal(IntPtr @this, FLinearColor InToonHardShadowColor);

		// Token: 0x06002EC2 RID: 11970
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonHardShadowBlend_Internal(IntPtr @this, float InToonHardShadowBlend);

		// Token: 0x06002EC3 RID: 11971
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonHardBaseColor_Internal(IntPtr @this, FLinearColor InToonHardBaseColor);

		// Token: 0x06002EC4 RID: 11972
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonDistanceBlendIntensity_Internal(IntPtr @this, float InToonDistanceBlendIntensity);

		// Token: 0x06002EC5 RID: 11973
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonDistanceBlendAtten_Internal(IntPtr @this, float InToonDistanceBlendAtten);

		// Token: 0x06002EC6 RID: 11974
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetToonBaseColorIntensity_Internal(IntPtr @this, float InToonBaseColorIntensity);

		// Token: 0x06002EC7 RID: 11975
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTemperature_Internal(IntPtr @this, float NewTemperature);

		// Token: 0x06002EC8 RID: 11976
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSpecularScale_Internal(IntPtr @this, float NewValue);

		// Token: 0x06002EC9 RID: 11977
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowSlopeBias_Internal(IntPtr @this, float NewValue);

		// Token: 0x06002ECA RID: 11978
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetShadowBias_Internal(IntPtr @this, float NewValue);

		// Token: 0x06002ECB RID: 11979
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOcclusionMaskDarkness_Internal(IntPtr @this, float NewValue);

		// Token: 0x06002ECC RID: 11980
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetOcclusionDepthRange_Internal(IntPtr @this, float NewValue);

		// Token: 0x06002ECD RID: 11981
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinDrawDistance_Internal(IntPtr @this, float InMinDrawDistance);

		// Token: 0x06002ECE RID: 11982
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMinDistanceFadeRange_Internal(IntPtr @this, float InMinDistanceFadeRange);

		// Token: 0x06002ECF RID: 11983
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxDrawDistance_Internal(IntPtr @this, float InMaxDrawDistance);

		// Token: 0x06002ED0 RID: 11984
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMaxDistanceFadeRange_Internal(IntPtr @this, float InMaxDistanceFadeRange);

		// Token: 0x06002ED1 RID: 11985
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightToonIntensity_Internal(IntPtr @this, float NewIntensity);

		// Token: 0x06002ED2 RID: 11986
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightToonColor_Internal(IntPtr @this, FLinearColor NewLightColor, bool bSRGB);

		// Token: 0x06002ED3 RID: 11987
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightShadowQualityType_PC_Internal(IntPtr @this, TEnumAsByte<ELightQualityType> InLightQualityType);

		// Token: 0x06002ED4 RID: 11988
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightQualityType_PC_Internal(IntPtr @this, TEnumAsByte<ELightQualityType> InLightQualityType);

		// Token: 0x06002ED5 RID: 11989
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightQualityType_Internal(IntPtr @this, TEnumAsByte<ELightQualityType> InLightQualityType);

		// Token: 0x06002ED6 RID: 11990
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightingChannels_Internal(IntPtr @this, bool bChannel0, bool bChannel1, bool bChannel2);

		// Token: 0x06002ED7 RID: 11991
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightFunctionScale_Internal(IntPtr @this, FVector NewLightFunctionScale);

		// Token: 0x06002ED8 RID: 11992
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightFunctionMaterial_Internal(IntPtr @this, IntPtr NewLightFunctionMaterial);

		// Token: 0x06002ED9 RID: 11993
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightFunctionFadeDistance_Internal(IntPtr @this, float NewLightFunctionFadeDistance);

		// Token: 0x06002EDA RID: 11994
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightFunctionDisabledBrightness_Internal(IntPtr @this, float NewValue);

		// Token: 0x06002EDB RID: 11995
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetLightColor_Internal(IntPtr @this, FLinearColor NewLightColor, bool bSRGB);

		// Token: 0x06002EDC RID: 11996
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIsUIScenePrimitive_Internal(IntPtr @this, bool bValue);

		// Token: 0x06002EDD RID: 11997
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIntensity_Internal(IntPtr @this, float NewIntensity);

		// Token: 0x06002EDE RID: 11998
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIndirectLightingIntensity_Internal(IntPtr @this, float NewIntensity);

		// Token: 0x06002EDF RID: 11999
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIgnoreLightVolumeDistanceCull_Internal(IntPtr @this, bool IsIgnoreVolumeDistanceCull);

		// Token: 0x06002EE0 RID: 12000
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIESTexture_Internal(IntPtr @this, IntPtr NewValue);

		// Token: 0x06002EE1 RID: 12001
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetIESBrightnessScale_Internal(IntPtr @this, float NewValue);

		// Token: 0x06002EE2 RID: 12002
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetForceCachedShadowsForMovablePrimitives_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x06002EE3 RID: 12003
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableLightShaftOcclusion_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x06002EE4 RID: 12004
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetEnableLightShaftBloom_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x06002EE5 RID: 12005
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetCastDynamicShadowInCaveFadeIntensity_Internal(IntPtr @this, float InCastDynamicShadowInCaveFadeIntensity);

		// Token: 0x06002EE6 RID: 12006
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBloomTint_Internal(IntPtr @this, FColor NewValue);

		// Token: 0x06002EE7 RID: 12007
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBloomThreshold_Internal(IntPtr @this, float NewValue);

		// Token: 0x06002EE8 RID: 12008
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBloomScale_Internal(IntPtr @this, float NewValue);

		// Token: 0x06002EE9 RID: 12009
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBloomMaxBrightness_Internal(IntPtr @this, float NewValue);

		// Token: 0x06002EEA RID: 12010
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAffectTranslucentLighting_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x06002EEB RID: 12011
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetAffectDynamicIndirectLighting_Internal(IntPtr @this, bool bNewValue);

		// Token: 0x06002EEC RID: 12012
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetUsePointLightFallOffColor_Internal(IntPtr @this);

		// Token: 0x06002EED RID: 12013
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetToonPointLightFallOff_Internal(IntPtr @this);

		// Token: 0x06002EEE RID: 12014
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetToonIntensity_Internal(IntPtr @this);

		// Token: 0x06002EEF RID: 12015
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FLinearColor __GetLightToonColor_Internal(IntPtr @this);

		// Token: 0x06002EF0 RID: 12016
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ELightQualityType> __GetLightShadowQualityType_PC_Internal(IntPtr @this);

		// Token: 0x06002EF1 RID: 12017
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ELightQualityType> __GetLightQualityType_PC_Internal(IntPtr @this);

		// Token: 0x06002EF2 RID: 12018
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern TEnumAsByte<ELightQualityType> __GetLightQualityType_Internal(IntPtr @this);

		// Token: 0x06002EF3 RID: 12019
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetIgnoreLightVolumeDistanceCull_Internal(IntPtr @this);

		// Token: 0x06002EF4 RID: 12020
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetCastDynamicShadowInCaveFadeIntensity_Internal(IntPtr @this);

		// Token: 0x06002EF5 RID: 12021 RVA: 0x00041C64 File Offset: 0x0003FE64
		static ULightComponent()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Engine.LightComponent");
		}

		// Token: 0x06002EF6 RID: 12022 RVA: 0x00041C74 File Offset: 0x0003FE74
		protected ULightComponent() : this(BuiltinUtils.AllocNativeUObject(ULightComponent.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x00041C9C File Offset: 0x0003FE9C
		protected ULightComponent(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000EB1 RID: 3761
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.LightComponent";

		// Token: 0x04000EB2 RID: 3762
		private static IntPtr _ClassPtr;

		// Token: 0x04000EB3 RID: 3763
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000EB4 RID: 3764
		internal static int __PropertyOffset_Temperature;

		// Token: 0x04000EB5 RID: 3765
		internal static int __PropertyOffset_MinDrawDistance;

		// Token: 0x04000EB6 RID: 3766
		internal static int __PropertyOffset_MaxDrawDistance;

		// Token: 0x04000EB7 RID: 3767
		internal static int __PropertyOffset_MinDistanceFadeRange;

		// Token: 0x04000EB8 RID: 3768
		internal static int __PropertyOffset_MaxDistanceFadeRange;

		// Token: 0x04000EB9 RID: 3769
		internal static int __PropertyOffset_IgnoreLightVolumeDistanceCull;

		// Token: 0x04000EBA RID: 3770
		internal static int __PropertyOffset_bSyncToToonLight;

		// Token: 0x04000EBB RID: 3771
		internal static int __PropertyOffset_CustomCullFlag;

		// Token: 0x04000EBC RID: 3772
		internal static int __PropertyOffset_LightQualityType;

		// Token: 0x04000EBD RID: 3773
		internal static int __PropertyOffset_LightQualityType_PC;

		// Token: 0x04000EBE RID: 3774
		internal static int __PropertyOffset_LightShadowQualityType_PC;

		// Token: 0x04000EBF RID: 3775
		internal static int __PropertyOffset_bUseTemperature;

		// Token: 0x04000EC0 RID: 3776
		internal static byte __PropertyMask_bUseTemperature;

		// Token: 0x04000EC1 RID: 3777
		internal static int __PropertyOffset_ShadowMapChannel_DEPRECATED;

		// Token: 0x04000EC2 RID: 3778
		internal static int __PropertyOffset_MinRoughness_DEPRECATED;

		// Token: 0x04000EC3 RID: 3779
		internal static int __PropertyOffset_SpecularScale;

		// Token: 0x04000EC4 RID: 3780
		internal static int __PropertyOffset_ShadowResolutionScale;

		// Token: 0x04000EC5 RID: 3781
		internal static int __PropertyOffset_ShadowBias;

		// Token: 0x04000EC6 RID: 3782
		internal static int __PropertyOffset_ShadowSlopeBias;

		// Token: 0x04000EC7 RID: 3783
		internal static int __PropertyOffset_ShadowSharpen;

		// Token: 0x04000EC8 RID: 3784
		internal static int __PropertyOffset_ContactShadowLength;

		// Token: 0x04000EC9 RID: 3785
		internal static int __PropertyOffset_ContactShadowNearLength;

		// Token: 0x04000ECA RID: 3786
		internal static int __PropertyOffset_ContactShadowLengthInWS;

		// Token: 0x04000ECB RID: 3787
		internal static byte __PropertyMask_ContactShadowLengthInWS;

		// Token: 0x04000ECC RID: 3788
		internal static int __PropertyOffset_ContactShadowCastingIntensity;

		// Token: 0x04000ECD RID: 3789
		internal static int __PropertyOffset_ContactShadowFoliageCastingIntensity;

		// Token: 0x04000ECE RID: 3790
		internal static int __PropertyOffset_ContactShadowFadeDistance;

		// Token: 0x04000ECF RID: 3791
		internal static int __PropertyOffset_ContactShadowBeginFadeDistance;

		// Token: 0x04000ED0 RID: 3792
		internal static int __PropertyOffset_InverseSquaredFalloff_DEPRECATED;

		// Token: 0x04000ED1 RID: 3793
		internal static byte __PropertyMask_InverseSquaredFalloff_DEPRECATED;

		// Token: 0x04000ED2 RID: 3794
		internal static int __PropertyOffset_CastTranslucentShadows;

		// Token: 0x04000ED3 RID: 3795
		internal static byte __PropertyMask_CastTranslucentShadows;

		// Token: 0x04000ED4 RID: 3796
		internal static int __PropertyOffset_bCastShadowsFromCinematicObjectsOnly;

		// Token: 0x04000ED5 RID: 3797
		internal static byte __PropertyMask_bCastShadowsFromCinematicObjectsOnly;

		// Token: 0x04000ED6 RID: 3798
		internal static int __PropertyOffset_bAffectDynamicIndirectLighting;

		// Token: 0x04000ED7 RID: 3799
		internal static byte __PropertyMask_bAffectDynamicIndirectLighting;

		// Token: 0x04000ED8 RID: 3800
		internal static int __PropertyOffset_bForceCachedShadowsForMovablePrimitives;

		// Token: 0x04000ED9 RID: 3801
		internal static byte __PropertyMask_bForceCachedShadowsForMovablePrimitives;

		// Token: 0x04000EDA RID: 3802
		internal static int __PropertyOffset_bAllowMegaLights;

		// Token: 0x04000EDB RID: 3803
		internal static byte __PropertyMask_bAllowMegaLights;

		// Token: 0x04000EDC RID: 3804
		internal static int __PropertyOffset_LightFunctionMaterial;

		// Token: 0x04000EDD RID: 3805
		internal static int __PropertyOffset_VolumetricLightFunctionMaterial;

		// Token: 0x04000EDE RID: 3806
		internal static int __PropertyOffset_LightFunctionScale;

		// Token: 0x04000EDF RID: 3807
		internal static int __PropertyOffset_IESTexture;

		// Token: 0x04000EE0 RID: 3808
		internal static int __PropertyOffset_bUseIESBrightness;

		// Token: 0x04000EE1 RID: 3809
		internal static byte __PropertyMask_bUseIESBrightness;

		// Token: 0x04000EE2 RID: 3810
		internal static int __PropertyOffset_IESBrightnessScale;

		// Token: 0x04000EE3 RID: 3811
		internal static int __PropertyOffset_LightFunctionFadeDistance;

		// Token: 0x04000EE4 RID: 3812
		internal static int __PropertyOffset_DisabledBrightness;

		// Token: 0x04000EE5 RID: 3813
		internal static int __PropertyOffset_bEnableLightShaftBloom;

		// Token: 0x04000EE6 RID: 3814
		internal static byte __PropertyMask_bEnableLightShaftBloom;

		// Token: 0x04000EE7 RID: 3815
		internal static int __PropertyOffset_BloomScale;

		// Token: 0x04000EE8 RID: 3816
		internal static int __PropertyOffset_BloomThreshold;

		// Token: 0x04000EE9 RID: 3817
		internal static int __PropertyOffset_BloomMaxBrightness;

		// Token: 0x04000EEA RID: 3818
		internal static int __PropertyOffset_BloomTint;

		// Token: 0x04000EEB RID: 3819
		internal static int __PropertyOffset_bUseRayTracedDistanceFieldShadows;

		// Token: 0x04000EEC RID: 3820
		internal static int __PropertyOffset_RayStartOffsetDepthScale;

		// Token: 0x04000EED RID: 3821
		internal static int __PropertyOffset_bEnableLightShaftOcclusion;

		// Token: 0x04000EEE RID: 3822
		internal static byte __PropertyMask_bEnableLightShaftOcclusion;

		// Token: 0x04000EEF RID: 3823
		internal static int __PropertyOffset_OcclusionMaskDarkness;

		// Token: 0x04000EF0 RID: 3824
		internal static int __PropertyOffset_OcclusionDepthRange;

		// Token: 0x04000EF1 RID: 3825
		internal static int __PropertyOffset_CastDynamicShadowInCaveFadeIntensity;

		// Token: 0x04000EF2 RID: 3826
		internal static int __PropertyOffset_ToonPointLightFallOff;

		// Token: 0x04000EF3 RID: 3827
		internal static int __PropertyOffset_bUsePointLightFallOffColor;

		// Token: 0x04000EF4 RID: 3828
		internal static int __PropertyOffset_ToonDistanceBlendAtten;

		// Token: 0x04000EF5 RID: 3829
		internal static int __PropertyOffset_ToonDistanceBlendIntensity;

		// Token: 0x04000EF6 RID: 3830
		internal static int __PropertyOffset_ToonLightingPriority;

		// Token: 0x04000EF7 RID: 3831
		internal static int __PropertyOffset_ToonIntensity;

		// Token: 0x04000EF8 RID: 3832
		internal static int __PropertyOffset_ToonColor;

		// Token: 0x04000EF9 RID: 3833
		internal static int __PropertyOffset_ToonShadowColorIntensity;

		// Token: 0x04000EFA RID: 3834
		internal static int __PropertyOffset_ToonBaseColorIntensity;

		// Token: 0x04000EFB RID: 3835
		internal static int __PropertyOffset_ToonRealTimeShadowIntensity;

		// Token: 0x04000EFC RID: 3836
		internal static int __PropertyOffset_ToonHardShadowIntensity;

		// Token: 0x04000EFD RID: 3837
		internal static int __PropertyOffset_ToonHardShadowRange;

		// Token: 0x04000EFE RID: 3838
		internal static int __PropertyOffset_ToonHardBaseColor;

		// Token: 0x04000EFF RID: 3839
		internal static int __PropertyOffset_ToonHardShadowColor;

		// Token: 0x04000F00 RID: 3840
		internal static int __PropertyOffset_ToonHardShadowBlend;

		// Token: 0x04000F01 RID: 3841
		internal static int __PropertyOffset_IsUIScenePrimitive;
	}
}
