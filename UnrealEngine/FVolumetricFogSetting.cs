using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C37 RID: 7223
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.VolumetricFogSetting")]
	[UnrealStructLayout(144, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 144)]
	public class FVolumetricFogSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BFF8 RID: 114680 RVA: 0x002932F8 File Offset: 0x002914F8
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FVolumetricFogSetting._ScriptStructPtr != 0) ? FVolumetricFogSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.VolumetricFogSetting", ref FVolumetricFogSetting._ScriptStructPtr);
		}

		// Token: 0x1700711D RID: 28957
		// (get) Token: 0x0601BFF9 RID: 114681 RVA: 0x0029331C File Offset: 0x0029151C
		// (set) Token: 0x0601BFFA RID: 114682 RVA: 0x00293335 File Offset: 0x00291535
		public unsafe bool bOverride_LocalLightScatteringMultiplier
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_LocalLightScatteringMultiplier) & FVolumetricFogSetting.__PropertyMask_bOverride_LocalLightScatteringMultiplier) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_LocalLightScatteringMultiplier) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_LocalLightScatteringMultiplier) & ~FVolumetricFogSetting.__PropertyMask_bOverride_LocalLightScatteringMultiplier) | (value ? FVolumetricFogSetting.__PropertyMask_bOverride_LocalLightScatteringMultiplier : 0));
			}
		}

		// Token: 0x1700711E RID: 28958
		// (get) Token: 0x0601BFFB RID: 114683 RVA: 0x00293365 File Offset: 0x00291565
		// (set) Token: 0x0601BFFC RID: 114684 RVA: 0x0029337E File Offset: 0x0029157E
		public unsafe bool bOverride_VolumetricScatteringIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricScatteringIntensity) & FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricScatteringIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricScatteringIntensity) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricScatteringIntensity) & ~FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricScatteringIntensity) | (value ? FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricScatteringIntensity : 0));
			}
		}

		// Token: 0x1700711F RID: 28959
		// (get) Token: 0x0601BFFD RID: 114685 RVA: 0x002933AE File Offset: 0x002915AE
		// (set) Token: 0x0601BFFE RID: 114686 RVA: 0x002933C7 File Offset: 0x002915C7
		public unsafe bool bOverride_ExtinctionScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_ExtinctionScale) & FVolumetricFogSetting.__PropertyMask_bOverride_ExtinctionScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_ExtinctionScale) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_ExtinctionScale) & ~FVolumetricFogSetting.__PropertyMask_bOverride_ExtinctionScale) | (value ? FVolumetricFogSetting.__PropertyMask_bOverride_ExtinctionScale : 0));
			}
		}

		// Token: 0x17007120 RID: 28960
		// (get) Token: 0x0601BFFF RID: 114687 RVA: 0x002933F7 File Offset: 0x002915F7
		// (set) Token: 0x0601C000 RID: 114688 RVA: 0x00293410 File Offset: 0x00291610
		public unsafe bool bOverride_ScatteringDistribution
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_ScatteringDistribution) & FVolumetricFogSetting.__PropertyMask_bOverride_ScatteringDistribution) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_ScatteringDistribution) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_ScatteringDistribution) & ~FVolumetricFogSetting.__PropertyMask_bOverride_ScatteringDistribution) | (value ? FVolumetricFogSetting.__PropertyMask_bOverride_ScatteringDistribution : 0));
			}
		}

		// Token: 0x17007121 RID: 28961
		// (get) Token: 0x0601C001 RID: 114689 RVA: 0x00293440 File Offset: 0x00291640
		// (set) Token: 0x0601C002 RID: 114690 RVA: 0x00293459 File Offset: 0x00291659
		public unsafe bool bOverride_VolumetricFogAlbedo
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricFogAlbedo) & FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricFogAlbedo) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricFogAlbedo) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricFogAlbedo) & ~FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricFogAlbedo) | (value ? FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricFogAlbedo : 0));
			}
		}

		// Token: 0x17007122 RID: 28962
		// (get) Token: 0x0601C003 RID: 114691 RVA: 0x00293489 File Offset: 0x00291689
		// (set) Token: 0x0601C004 RID: 114692 RVA: 0x002934A2 File Offset: 0x002916A2
		public unsafe bool bOverride_VolumetricFogEmssive
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricFogEmssive) & FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricFogEmssive) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricFogEmssive) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricFogEmssive) & ~FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricFogEmssive) | (value ? FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricFogEmssive : 0));
			}
		}

		// Token: 0x17007123 RID: 28963
		// (get) Token: 0x0601C005 RID: 114693 RVA: 0x002934D2 File Offset: 0x002916D2
		// (set) Token: 0x0601C006 RID: 114694 RVA: 0x002934EB File Offset: 0x002916EB
		public unsafe bool bOverride_ViewDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_ViewDistance) & FVolumetricFogSetting.__PropertyMask_bOverride_ViewDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_ViewDistance) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_ViewDistance) & ~FVolumetricFogSetting.__PropertyMask_bOverride_ViewDistance) | (value ? FVolumetricFogSetting.__PropertyMask_bOverride_ViewDistance : 0));
			}
		}

		// Token: 0x17007124 RID: 28964
		// (get) Token: 0x0601C007 RID: 114695 RVA: 0x0029351B File Offset: 0x0029171B
		// (set) Token: 0x0601C008 RID: 114696 RVA: 0x00293534 File Offset: 0x00291734
		public unsafe bool bOverride_VolumeMaterialSkyLightIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumeMaterialSkyLightIntensity) & FVolumetricFogSetting.__PropertyMask_bOverride_VolumeMaterialSkyLightIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumeMaterialSkyLightIntensity) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumeMaterialSkyLightIntensity) & ~FVolumetricFogSetting.__PropertyMask_bOverride_VolumeMaterialSkyLightIntensity) | (value ? FVolumetricFogSetting.__PropertyMask_bOverride_VolumeMaterialSkyLightIntensity : 0));
			}
		}

		// Token: 0x17007125 RID: 28965
		// (get) Token: 0x0601C009 RID: 114697 RVA: 0x00293564 File Offset: 0x00291764
		// (set) Token: 0x0601C00A RID: 114698 RVA: 0x0029357D File Offset: 0x0029177D
		public unsafe bool bOverride_VolumeMaterialDirectionalLightIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumeMaterialDirectionalLightIntensity) & FVolumetricFogSetting.__PropertyMask_bOverride_VolumeMaterialDirectionalLightIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumeMaterialDirectionalLightIntensity) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumeMaterialDirectionalLightIntensity) & ~FVolumetricFogSetting.__PropertyMask_bOverride_VolumeMaterialDirectionalLightIntensity) | (value ? FVolumetricFogSetting.__PropertyMask_bOverride_VolumeMaterialDirectionalLightIntensity : 0));
			}
		}

		// Token: 0x17007126 RID: 28966
		// (get) Token: 0x0601C00B RID: 114699 RVA: 0x002935AD File Offset: 0x002917AD
		// (set) Token: 0x0601C00C RID: 114700 RVA: 0x002935C6 File Offset: 0x002917C6
		public unsafe bool bOverride_VolumeMaterialOpacity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumeMaterialOpacity) & FVolumetricFogSetting.__PropertyMask_bOverride_VolumeMaterialOpacity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumeMaterialOpacity) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumeMaterialOpacity) & ~FVolumetricFogSetting.__PropertyMask_bOverride_VolumeMaterialOpacity) | (value ? FVolumetricFogSetting.__PropertyMask_bOverride_VolumeMaterialOpacity : 0));
			}
		}

		// Token: 0x17007127 RID: 28967
		// (get) Token: 0x0601C00D RID: 114701 RVA: 0x002935F6 File Offset: 0x002917F6
		// (set) Token: 0x0601C00E RID: 114702 RVA: 0x0029360F File Offset: 0x0029180F
		public unsafe bool bOverride_VolumetricLightFunctionTexture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricLightFunctionTexture) & FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricLightFunctionTexture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricLightFunctionTexture) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricLightFunctionTexture) & ~FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricLightFunctionTexture) | (value ? FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricLightFunctionTexture : 0));
			}
		}

		// Token: 0x17007128 RID: 28968
		// (get) Token: 0x0601C00F RID: 114703 RVA: 0x0029363F File Offset: 0x0029183F
		// (set) Token: 0x0601C010 RID: 114704 RVA: 0x00293658 File Offset: 0x00291858
		public unsafe bool bOverride_VolumetricLightFunctionIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricLightFunctionIntensity) & FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricLightFunctionIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricLightFunctionIntensity) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricLightFunctionIntensity) & ~FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricLightFunctionIntensity) | (value ? FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricLightFunctionIntensity : 0));
			}
		}

		// Token: 0x17007129 RID: 28969
		// (get) Token: 0x0601C011 RID: 114705 RVA: 0x00293688 File Offset: 0x00291888
		// (set) Token: 0x0601C012 RID: 114706 RVA: 0x002936A1 File Offset: 0x002918A1
		public unsafe bool bOverride_VolumetricLightFunctionUVScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricLightFunctionUVScale) & FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricLightFunctionUVScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricLightFunctionUVScale) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricLightFunctionUVScale) & ~FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricLightFunctionUVScale) | (value ? FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricLightFunctionUVScale : 0));
			}
		}

		// Token: 0x1700712A RID: 28970
		// (get) Token: 0x0601C013 RID: 114707 RVA: 0x002936D1 File Offset: 0x002918D1
		// (set) Token: 0x0601C014 RID: 114708 RVA: 0x002936EA File Offset: 0x002918EA
		public unsafe bool bOverride_VolumetricLightFunctionSpeed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricLightFunctionSpeed) & FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricLightFunctionSpeed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricLightFunctionSpeed) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricLightFunctionSpeed) & ~FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricLightFunctionSpeed) | (value ? FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricLightFunctionSpeed : 0));
			}
		}

		// Token: 0x1700712B RID: 28971
		// (get) Token: 0x0601C015 RID: 114709 RVA: 0x0029371A File Offset: 0x0029191A
		// (set) Token: 0x0601C016 RID: 114710 RVA: 0x00293733 File Offset: 0x00291933
		public unsafe bool bOverride_VolumetricFogTransmittance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricFogTransmittance) & FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricFogTransmittance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricFogTransmittance) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricFogTransmittance) & ~FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricFogTransmittance) | (value ? FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricFogTransmittance : 0));
			}
		}

		// Token: 0x1700712C RID: 28972
		// (get) Token: 0x0601C017 RID: 114711 RVA: 0x00293763 File Offset: 0x00291963
		// (set) Token: 0x0601C018 RID: 114712 RVA: 0x0029377C File Offset: 0x0029197C
		public unsafe bool bOverride_bEnableVolumetricSunExposure
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_bEnableVolumetricSunExposure) & FVolumetricFogSetting.__PropertyMask_bOverride_bEnableVolumetricSunExposure) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_bEnableVolumetricSunExposure) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_bEnableVolumetricSunExposure) & ~FVolumetricFogSetting.__PropertyMask_bOverride_bEnableVolumetricSunExposure) | (value ? FVolumetricFogSetting.__PropertyMask_bOverride_bEnableVolumetricSunExposure : 0));
			}
		}

		// Token: 0x1700712D RID: 28973
		// (get) Token: 0x0601C019 RID: 114713 RVA: 0x002937AC File Offset: 0x002919AC
		// (set) Token: 0x0601C01A RID: 114714 RVA: 0x002937C5 File Offset: 0x002919C5
		public unsafe bool bOverride_VolumetricDepthFadeDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricDepthFadeDistance) & FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricDepthFadeDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricDepthFadeDistance) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricDepthFadeDistance) & ~FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricDepthFadeDistance) | (value ? FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricDepthFadeDistance : 0));
			}
		}

		// Token: 0x1700712E RID: 28974
		// (get) Token: 0x0601C01B RID: 114715 RVA: 0x002937F5 File Offset: 0x002919F5
		// (set) Token: 0x0601C01C RID: 114716 RVA: 0x0029380E File Offset: 0x00291A0E
		public unsafe bool bOverride_VolumetricFogNearFadeInDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricFogNearFadeInDistance) & FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricFogNearFadeInDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricFogNearFadeInDistance) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricFogNearFadeInDistance) & ~FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricFogNearFadeInDistance) | (value ? FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricFogNearFadeInDistance : 0));
			}
		}

		// Token: 0x1700712F RID: 28975
		// (get) Token: 0x0601C01D RID: 114717 RVA: 0x0029383E File Offset: 0x00291A3E
		// (set) Token: 0x0601C01E RID: 114718 RVA: 0x00293857 File Offset: 0x00291A57
		public unsafe bool bOverride_bDisableVolumetricPhase
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_bDisableVolumetricPhase) & FVolumetricFogSetting.__PropertyMask_bOverride_bDisableVolumetricPhase) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_bDisableVolumetricPhase) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_bDisableVolumetricPhase) & ~FVolumetricFogSetting.__PropertyMask_bOverride_bDisableVolumetricPhase) | (value ? FVolumetricFogSetting.__PropertyMask_bOverride_bDisableVolumetricPhase : 0));
			}
		}

		// Token: 0x17007130 RID: 28976
		// (get) Token: 0x0601C01F RID: 114719 RVA: 0x00293887 File Offset: 0x00291A87
		// (set) Token: 0x0601C020 RID: 114720 RVA: 0x002938A0 File Offset: 0x00291AA0
		public unsafe bool bOverride_VolumetricFogNewPhaseFadeRange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricFogNewPhaseFadeRange) & FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricFogNewPhaseFadeRange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricFogNewPhaseFadeRange) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bOverride_VolumetricFogNewPhaseFadeRange) & ~FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricFogNewPhaseFadeRange) | (value ? FVolumetricFogSetting.__PropertyMask_bOverride_VolumetricFogNewPhaseFadeRange : 0));
			}
		}

		// Token: 0x17007131 RID: 28977
		// (get) Token: 0x0601C021 RID: 114721 RVA: 0x002938D0 File Offset: 0x00291AD0
		// (set) Token: 0x0601C022 RID: 114722 RVA: 0x002938E9 File Offset: 0x00291AE9
		public unsafe bool bEnableVolumetriFog
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bEnableVolumetriFog) & FVolumetricFogSetting.__PropertyMask_bEnableVolumetriFog) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bEnableVolumetriFog) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bEnableVolumetriFog) & ~FVolumetricFogSetting.__PropertyMask_bEnableVolumetriFog) | (value ? FVolumetricFogSetting.__PropertyMask_bEnableVolumetriFog : 0));
			}
		}

		// Token: 0x17007132 RID: 28978
		// (get) Token: 0x0601C023 RID: 114723 RVA: 0x00293919 File Offset: 0x00291B19
		// (set) Token: 0x0601C024 RID: 114724 RVA: 0x00293932 File Offset: 0x00291B32
		public unsafe bool bCastVolumetricShadow
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bCastVolumetricShadow) & FVolumetricFogSetting.__PropertyMask_bCastVolumetricShadow) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bCastVolumetricShadow) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bCastVolumetricShadow) & ~FVolumetricFogSetting.__PropertyMask_bCastVolumetricShadow) | (value ? FVolumetricFogSetting.__PropertyMask_bCastVolumetricShadow : 0));
			}
		}

		// Token: 0x17007133 RID: 28979
		// (get) Token: 0x0601C025 RID: 114725 RVA: 0x00293962 File Offset: 0x00291B62
		// (set) Token: 0x0601C026 RID: 114726 RVA: 0x0029397B File Offset: 0x00291B7B
		public unsafe bool bVolumetricLightFunction
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bVolumetricLightFunction) & FVolumetricFogSetting.__PropertyMask_bVolumetricLightFunction) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bVolumetricLightFunction) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bVolumetricLightFunction) & ~FVolumetricFogSetting.__PropertyMask_bVolumetricLightFunction) | (value ? FVolumetricFogSetting.__PropertyMask_bVolumetricLightFunction : 0));
			}
		}

		// Token: 0x17007134 RID: 28980
		// (get) Token: 0x0601C027 RID: 114727 RVA: 0x002939AB File Offset: 0x00291BAB
		// (set) Token: 0x0601C028 RID: 114728 RVA: 0x002939BB File Offset: 0x00291BBB
		public unsafe float VolumetricLightFunctionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumetricLightFunctionIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumetricLightFunctionIntensity) = value;
			}
		}

		// Token: 0x17007135 RID: 28981
		// (get) Token: 0x0601C029 RID: 114729 RVA: 0x002939CC File Offset: 0x00291BCC
		// (set) Token: 0x0601C02A RID: 114730 RVA: 0x002939E0 File Offset: 0x00291BE0
		public unsafe FVector4 VolumetricLightFunctionUVScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumetricLightFunctionUVScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumetricLightFunctionUVScale) = value;
			}
		}

		// Token: 0x17007136 RID: 28982
		// (get) Token: 0x0601C02B RID: 114731 RVA: 0x002939F5 File Offset: 0x00291BF5
		// (set) Token: 0x0601C02C RID: 114732 RVA: 0x00293A05 File Offset: 0x00291C05
		public unsafe float VolumetricLightFunctionSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumetricLightFunctionSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumetricLightFunctionSpeed) = value;
			}
		}

		// Token: 0x17007137 RID: 28983
		// (get) Token: 0x0601C02D RID: 114733 RVA: 0x00293A16 File Offset: 0x00291C16
		// (set) Token: 0x0601C02E RID: 114734 RVA: 0x00293A2A File Offset: 0x00291C2A
		[Nullable(2)]
		public unsafe UTexture2D VolumetricLightFunctionTexture
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FVolumetricFogSetting.__PropertyOffset_VolumetricLightFunctionTexture);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FVolumetricFogSetting.__PropertyOffset_VolumetricLightFunctionTexture, value);
			}
		}

		// Token: 0x17007138 RID: 28984
		// (get) Token: 0x0601C02F RID: 114735 RVA: 0x00293A3F File Offset: 0x00291C3F
		// (set) Token: 0x0601C030 RID: 114736 RVA: 0x00293A4F File Offset: 0x00291C4F
		public unsafe float VolumetricDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumetricDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumetricDensity) = value;
			}
		}

		// Token: 0x17007139 RID: 28985
		// (get) Token: 0x0601C031 RID: 114737 RVA: 0x00293A60 File Offset: 0x00291C60
		// (set) Token: 0x0601C032 RID: 114738 RVA: 0x00293A74 File Offset: 0x00291C74
		public unsafe FLinearColor VolumetricFogTransmittance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumetricFogTransmittance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumetricFogTransmittance) = value;
			}
		}

		// Token: 0x1700713A RID: 28986
		// (get) Token: 0x0601C033 RID: 114739 RVA: 0x00293A89 File Offset: 0x00291C89
		// (set) Token: 0x0601C034 RID: 114740 RVA: 0x00293AA2 File Offset: 0x00291CA2
		public unsafe bool bEnableVolumetricSunExposure
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bEnableVolumetricSunExposure) & FVolumetricFogSetting.__PropertyMask_bEnableVolumetricSunExposure) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bEnableVolumetricSunExposure) = ((*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bEnableVolumetricSunExposure) & ~FVolumetricFogSetting.__PropertyMask_bEnableVolumetricSunExposure) | (value ? FVolumetricFogSetting.__PropertyMask_bEnableVolumetricSunExposure : 0));
			}
		}

		// Token: 0x1700713B RID: 28987
		// (get) Token: 0x0601C035 RID: 114741 RVA: 0x00293AD2 File Offset: 0x00291CD2
		// (set) Token: 0x0601C036 RID: 114742 RVA: 0x00293AE2 File Offset: 0x00291CE2
		public unsafe float VolumetricDepthFadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumetricDepthFadeDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumetricDepthFadeDistance) = value;
			}
		}

		// Token: 0x1700713C RID: 28988
		// (get) Token: 0x0601C037 RID: 114743 RVA: 0x00293AF3 File Offset: 0x00291CF3
		// (set) Token: 0x0601C038 RID: 114744 RVA: 0x00293B03 File Offset: 0x00291D03
		public unsafe float VolumetricFogNearFadeInDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumetricFogNearFadeInDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumetricFogNearFadeInDistance) = value;
			}
		}

		// Token: 0x1700713D RID: 28989
		// (get) Token: 0x0601C039 RID: 114745 RVA: 0x00293B14 File Offset: 0x00291D14
		// (set) Token: 0x0601C03A RID: 114746 RVA: 0x00293B24 File Offset: 0x00291D24
		public unsafe float bDisableVolumetricPhase
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bDisableVolumetricPhase);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_bDisableVolumetricPhase) = value;
			}
		}

		// Token: 0x1700713E RID: 28990
		// (get) Token: 0x0601C03B RID: 114747 RVA: 0x00293B35 File Offset: 0x00291D35
		// (set) Token: 0x0601C03C RID: 114748 RVA: 0x00293B45 File Offset: 0x00291D45
		public unsafe float VolumetricFogNewPhaseFadeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumetricFogNewPhaseFadeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumetricFogNewPhaseFadeRange) = value;
			}
		}

		// Token: 0x1700713F RID: 28991
		// (get) Token: 0x0601C03D RID: 114749 RVA: 0x00293B56 File Offset: 0x00291D56
		// (set) Token: 0x0601C03E RID: 114750 RVA: 0x00293B66 File Offset: 0x00291D66
		public unsafe float VolumetricScatteringIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumetricScatteringIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumetricScatteringIntensity) = value;
			}
		}

		// Token: 0x17007140 RID: 28992
		// (get) Token: 0x0601C03F RID: 114751 RVA: 0x00293B77 File Offset: 0x00291D77
		// (set) Token: 0x0601C040 RID: 114752 RVA: 0x00293B8B File Offset: 0x00291D8B
		public unsafe FLinearColor VolumetricFogAlbedo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumetricFogAlbedo);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumetricFogAlbedo) = value;
			}
		}

		// Token: 0x17007141 RID: 28993
		// (get) Token: 0x0601C041 RID: 114753 RVA: 0x00293BA0 File Offset: 0x00291DA0
		// (set) Token: 0x0601C042 RID: 114754 RVA: 0x00293BB0 File Offset: 0x00291DB0
		public unsafe float LocalLightScatteringMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_LocalLightScatteringMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_LocalLightScatteringMultiplier) = value;
			}
		}

		// Token: 0x17007142 RID: 28994
		// (get) Token: 0x0601C043 RID: 114755 RVA: 0x00293BC1 File Offset: 0x00291DC1
		// (set) Token: 0x0601C044 RID: 114756 RVA: 0x00293BD1 File Offset: 0x00291DD1
		public unsafe float ExtinctionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_ExtinctionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_ExtinctionScale) = value;
			}
		}

		// Token: 0x17007143 RID: 28995
		// (get) Token: 0x0601C045 RID: 114757 RVA: 0x00293BE2 File Offset: 0x00291DE2
		// (set) Token: 0x0601C046 RID: 114758 RVA: 0x00293BF2 File Offset: 0x00291DF2
		public unsafe float ScatteringDistribution
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_ScatteringDistribution);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_ScatteringDistribution) = value;
			}
		}

		// Token: 0x17007144 RID: 28996
		// (get) Token: 0x0601C047 RID: 114759 RVA: 0x00293C03 File Offset: 0x00291E03
		// (set) Token: 0x0601C048 RID: 114760 RVA: 0x00293C13 File Offset: 0x00291E13
		public unsafe float ViewDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_ViewDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_ViewDistance) = value;
			}
		}

		// Token: 0x17007145 RID: 28997
		// (get) Token: 0x0601C049 RID: 114761 RVA: 0x00293C24 File Offset: 0x00291E24
		// (set) Token: 0x0601C04A RID: 114762 RVA: 0x00293C34 File Offset: 0x00291E34
		public unsafe float VolumeMaterialSkyLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumeMaterialSkyLightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumeMaterialSkyLightIntensity) = value;
			}
		}

		// Token: 0x17007146 RID: 28998
		// (get) Token: 0x0601C04B RID: 114763 RVA: 0x00293C45 File Offset: 0x00291E45
		// (set) Token: 0x0601C04C RID: 114764 RVA: 0x00293C55 File Offset: 0x00291E55
		public unsafe float VolumeMaterialDirectionalLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumeMaterialDirectionalLightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumeMaterialDirectionalLightIntensity) = value;
			}
		}

		// Token: 0x17007147 RID: 28999
		// (get) Token: 0x0601C04D RID: 114765 RVA: 0x00293C66 File Offset: 0x00291E66
		// (set) Token: 0x0601C04E RID: 114766 RVA: 0x00293C76 File Offset: 0x00291E76
		public unsafe float VolumeMaterialOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumeMaterialOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FVolumetricFogSetting.__PropertyOffset_VolumeMaterialOpacity) = value;
			}
		}

		// Token: 0x0601C04F RID: 114767 RVA: 0x00293C87 File Offset: 0x00291E87
		public FVolumetricFogSetting()
		{
		}

		// Token: 0x0601C050 RID: 114768 RVA: 0x00293C90 File Offset: 0x00291E90
		[NullableContext(1)]
		public FVolumetricFogSetting(bool bOverride_LocalLightScatteringMultiplier, bool bOverride_VolumetricScatteringIntensity, bool bOverride_ExtinctionScale, bool bOverride_ScatteringDistribution, bool bOverride_VolumetricFogAlbedo, bool bOverride_VolumetricFogEmssive, bool bOverride_ViewDistance, bool bOverride_VolumeMaterialSkyLightIntensity, bool bOverride_VolumeMaterialDirectionalLightIntensity, bool bOverride_VolumeMaterialOpacity, bool bOverride_VolumetricLightFunctionTexture, bool bOverride_VolumetricLightFunctionIntensity, bool bOverride_VolumetricLightFunctionUVScale, bool bOverride_VolumetricLightFunctionSpeed, bool bOverride_VolumetricFogTransmittance, bool bOverride_bEnableVolumetricSunExposure, bool bOverride_VolumetricDepthFadeDistance, bool bOverride_VolumetricFogNearFadeInDistance, bool bOverride_bDisableVolumetricPhase, bool bOverride_VolumetricFogNewPhaseFadeRange, bool bEnableVolumetriFog, bool bCastVolumetricShadow, bool bVolumetricLightFunction, float VolumetricLightFunctionIntensity, FVector4 VolumetricLightFunctionUVScale, float VolumetricLightFunctionSpeed, UTexture2D VolumetricLightFunctionTexture, float VolumetricDensity, FLinearColor VolumetricFogTransmittance, bool bEnableVolumetricSunExposure, float VolumetricDepthFadeDistance, float VolumetricFogNearFadeInDistance, float bDisableVolumetricPhase, float VolumetricFogNewPhaseFadeRange, float VolumetricScatteringIntensity, FLinearColor VolumetricFogAlbedo, float LocalLightScatteringMultiplier, float ExtinctionScale, float ScatteringDistribution, float ViewDistance, float VolumeMaterialSkyLightIntensity, float VolumeMaterialDirectionalLightIntensity, float VolumeMaterialOpacity)
		{
			this.bOverride_LocalLightScatteringMultiplier = bOverride_LocalLightScatteringMultiplier;
			this.bOverride_VolumetricScatteringIntensity = bOverride_VolumetricScatteringIntensity;
			this.bOverride_ExtinctionScale = bOverride_ExtinctionScale;
			this.bOverride_ScatteringDistribution = bOverride_ScatteringDistribution;
			this.bOverride_VolumetricFogAlbedo = bOverride_VolumetricFogAlbedo;
			this.bOverride_VolumetricFogEmssive = bOverride_VolumetricFogEmssive;
			this.bOverride_ViewDistance = bOverride_ViewDistance;
			this.bOverride_VolumeMaterialSkyLightIntensity = bOverride_VolumeMaterialSkyLightIntensity;
			this.bOverride_VolumeMaterialDirectionalLightIntensity = bOverride_VolumeMaterialDirectionalLightIntensity;
			this.bOverride_VolumeMaterialOpacity = bOverride_VolumeMaterialOpacity;
			this.bOverride_VolumetricLightFunctionTexture = bOverride_VolumetricLightFunctionTexture;
			this.bOverride_VolumetricLightFunctionIntensity = bOverride_VolumetricLightFunctionIntensity;
			this.bOverride_VolumetricLightFunctionUVScale = bOverride_VolumetricLightFunctionUVScale;
			this.bOverride_VolumetricLightFunctionSpeed = bOverride_VolumetricLightFunctionSpeed;
			this.bOverride_VolumetricFogTransmittance = bOverride_VolumetricFogTransmittance;
			this.bOverride_bEnableVolumetricSunExposure = bOverride_bEnableVolumetricSunExposure;
			this.bOverride_VolumetricDepthFadeDistance = bOverride_VolumetricDepthFadeDistance;
			this.bOverride_VolumetricFogNearFadeInDistance = bOverride_VolumetricFogNearFadeInDistance;
			this.bOverride_bDisableVolumetricPhase = bOverride_bDisableVolumetricPhase;
			this.bOverride_VolumetricFogNewPhaseFadeRange = bOverride_VolumetricFogNewPhaseFadeRange;
			this.bEnableVolumetriFog = bEnableVolumetriFog;
			this.bCastVolumetricShadow = bCastVolumetricShadow;
			this.bVolumetricLightFunction = bVolumetricLightFunction;
			this.VolumetricLightFunctionIntensity = VolumetricLightFunctionIntensity;
			this.VolumetricLightFunctionUVScale = VolumetricLightFunctionUVScale;
			this.VolumetricLightFunctionSpeed = VolumetricLightFunctionSpeed;
			this.VolumetricLightFunctionTexture = VolumetricLightFunctionTexture;
			this.VolumetricDensity = VolumetricDensity;
			this.VolumetricFogTransmittance = VolumetricFogTransmittance;
			this.bEnableVolumetricSunExposure = bEnableVolumetricSunExposure;
			this.VolumetricDepthFadeDistance = VolumetricDepthFadeDistance;
			this.VolumetricFogNearFadeInDistance = VolumetricFogNearFadeInDistance;
			this.bDisableVolumetricPhase = bDisableVolumetricPhase;
			this.VolumetricFogNewPhaseFadeRange = VolumetricFogNewPhaseFadeRange;
			this.VolumetricScatteringIntensity = VolumetricScatteringIntensity;
			this.VolumetricFogAlbedo = VolumetricFogAlbedo;
			this.LocalLightScatteringMultiplier = LocalLightScatteringMultiplier;
			this.ExtinctionScale = ExtinctionScale;
			this.ScatteringDistribution = ScatteringDistribution;
			this.ViewDistance = ViewDistance;
			this.VolumeMaterialSkyLightIntensity = VolumeMaterialSkyLightIntensity;
			this.VolumeMaterialDirectionalLightIntensity = VolumeMaterialDirectionalLightIntensity;
			this.VolumeMaterialOpacity = VolumeMaterialOpacity;
		}

		// Token: 0x0601C051 RID: 114769 RVA: 0x00293DF8 File Offset: 0x00291FF8
		protected override IntPtr GetUStructPtr()
		{
			return FVolumetricFogSetting.StaticStruct();
		}

		// Token: 0x0601C052 RID: 114770 RVA: 0x00293E04 File Offset: 0x00292004
		[NullableContext(2)]
		public FVolumetricFogSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601C053 RID: 114771 RVA: 0x00293E0E File Offset: 0x0029200E
		public FVolumetricFogSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601C054 RID: 114772 RVA: 0x00293E19 File Offset: 0x00292019
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FVolumetricFogSetting(Pointer, false, true);
		}

		// Token: 0x0601C055 RID: 114773 RVA: 0x00293E23 File Offset: 0x00292023
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FVolumetricFogSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400F08E RID: 61582
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.VolumetricFogSetting";

		// Token: 0x0400F08F RID: 61583
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400F090 RID: 61584
		internal static int __PropertyOffset_bOverride_LocalLightScatteringMultiplier;

		// Token: 0x0400F091 RID: 61585
		internal static byte __PropertyMask_bOverride_LocalLightScatteringMultiplier;

		// Token: 0x0400F092 RID: 61586
		internal static int __PropertyOffset_bOverride_VolumetricScatteringIntensity;

		// Token: 0x0400F093 RID: 61587
		internal static byte __PropertyMask_bOverride_VolumetricScatteringIntensity;

		// Token: 0x0400F094 RID: 61588
		internal static int __PropertyOffset_bOverride_ExtinctionScale;

		// Token: 0x0400F095 RID: 61589
		internal static byte __PropertyMask_bOverride_ExtinctionScale;

		// Token: 0x0400F096 RID: 61590
		internal static int __PropertyOffset_bOverride_ScatteringDistribution;

		// Token: 0x0400F097 RID: 61591
		internal static byte __PropertyMask_bOverride_ScatteringDistribution;

		// Token: 0x0400F098 RID: 61592
		internal static int __PropertyOffset_bOverride_VolumetricFogAlbedo;

		// Token: 0x0400F099 RID: 61593
		internal static byte __PropertyMask_bOverride_VolumetricFogAlbedo;

		// Token: 0x0400F09A RID: 61594
		internal static int __PropertyOffset_bOverride_VolumetricFogEmssive;

		// Token: 0x0400F09B RID: 61595
		internal static byte __PropertyMask_bOverride_VolumetricFogEmssive;

		// Token: 0x0400F09C RID: 61596
		internal static int __PropertyOffset_bOverride_ViewDistance;

		// Token: 0x0400F09D RID: 61597
		internal static byte __PropertyMask_bOverride_ViewDistance;

		// Token: 0x0400F09E RID: 61598
		internal static int __PropertyOffset_bOverride_VolumeMaterialSkyLightIntensity;

		// Token: 0x0400F09F RID: 61599
		internal static byte __PropertyMask_bOverride_VolumeMaterialSkyLightIntensity;

		// Token: 0x0400F0A0 RID: 61600
		internal static int __PropertyOffset_bOverride_VolumeMaterialDirectionalLightIntensity;

		// Token: 0x0400F0A1 RID: 61601
		internal static byte __PropertyMask_bOverride_VolumeMaterialDirectionalLightIntensity;

		// Token: 0x0400F0A2 RID: 61602
		internal static int __PropertyOffset_bOverride_VolumeMaterialOpacity;

		// Token: 0x0400F0A3 RID: 61603
		internal static byte __PropertyMask_bOverride_VolumeMaterialOpacity;

		// Token: 0x0400F0A4 RID: 61604
		internal static int __PropertyOffset_bOverride_VolumetricLightFunctionTexture;

		// Token: 0x0400F0A5 RID: 61605
		internal static byte __PropertyMask_bOverride_VolumetricLightFunctionTexture;

		// Token: 0x0400F0A6 RID: 61606
		internal static int __PropertyOffset_bOverride_VolumetricLightFunctionIntensity;

		// Token: 0x0400F0A7 RID: 61607
		internal static byte __PropertyMask_bOverride_VolumetricLightFunctionIntensity;

		// Token: 0x0400F0A8 RID: 61608
		internal static int __PropertyOffset_bOverride_VolumetricLightFunctionUVScale;

		// Token: 0x0400F0A9 RID: 61609
		internal static byte __PropertyMask_bOverride_VolumetricLightFunctionUVScale;

		// Token: 0x0400F0AA RID: 61610
		internal static int __PropertyOffset_bOverride_VolumetricLightFunctionSpeed;

		// Token: 0x0400F0AB RID: 61611
		internal static byte __PropertyMask_bOverride_VolumetricLightFunctionSpeed;

		// Token: 0x0400F0AC RID: 61612
		internal static int __PropertyOffset_bOverride_VolumetricFogTransmittance;

		// Token: 0x0400F0AD RID: 61613
		internal static byte __PropertyMask_bOverride_VolumetricFogTransmittance;

		// Token: 0x0400F0AE RID: 61614
		internal static int __PropertyOffset_bOverride_bEnableVolumetricSunExposure;

		// Token: 0x0400F0AF RID: 61615
		internal static byte __PropertyMask_bOverride_bEnableVolumetricSunExposure;

		// Token: 0x0400F0B0 RID: 61616
		internal static int __PropertyOffset_bOverride_VolumetricDepthFadeDistance;

		// Token: 0x0400F0B1 RID: 61617
		internal static byte __PropertyMask_bOverride_VolumetricDepthFadeDistance;

		// Token: 0x0400F0B2 RID: 61618
		internal static int __PropertyOffset_bOverride_VolumetricFogNearFadeInDistance;

		// Token: 0x0400F0B3 RID: 61619
		internal static byte __PropertyMask_bOverride_VolumetricFogNearFadeInDistance;

		// Token: 0x0400F0B4 RID: 61620
		internal static int __PropertyOffset_bOverride_bDisableVolumetricPhase;

		// Token: 0x0400F0B5 RID: 61621
		internal static byte __PropertyMask_bOverride_bDisableVolumetricPhase;

		// Token: 0x0400F0B6 RID: 61622
		internal static int __PropertyOffset_bOverride_VolumetricFogNewPhaseFadeRange;

		// Token: 0x0400F0B7 RID: 61623
		internal static byte __PropertyMask_bOverride_VolumetricFogNewPhaseFadeRange;

		// Token: 0x0400F0B8 RID: 61624
		internal static int __PropertyOffset_bEnableVolumetriFog;

		// Token: 0x0400F0B9 RID: 61625
		internal static byte __PropertyMask_bEnableVolumetriFog;

		// Token: 0x0400F0BA RID: 61626
		internal static int __PropertyOffset_bCastVolumetricShadow;

		// Token: 0x0400F0BB RID: 61627
		internal static byte __PropertyMask_bCastVolumetricShadow;

		// Token: 0x0400F0BC RID: 61628
		internal static int __PropertyOffset_bVolumetricLightFunction;

		// Token: 0x0400F0BD RID: 61629
		internal static byte __PropertyMask_bVolumetricLightFunction;

		// Token: 0x0400F0BE RID: 61630
		internal static int __PropertyOffset_VolumetricLightFunctionIntensity;

		// Token: 0x0400F0BF RID: 61631
		internal static int __PropertyOffset_VolumetricLightFunctionUVScale;

		// Token: 0x0400F0C0 RID: 61632
		internal static int __PropertyOffset_VolumetricLightFunctionSpeed;

		// Token: 0x0400F0C1 RID: 61633
		internal static int __PropertyOffset_VolumetricLightFunctionTexture;

		// Token: 0x0400F0C2 RID: 61634
		internal static int __PropertyOffset_VolumetricDensity;

		// Token: 0x0400F0C3 RID: 61635
		internal static int __PropertyOffset_VolumetricFogTransmittance;

		// Token: 0x0400F0C4 RID: 61636
		internal static int __PropertyOffset_bEnableVolumetricSunExposure;

		// Token: 0x0400F0C5 RID: 61637
		internal static byte __PropertyMask_bEnableVolumetricSunExposure;

		// Token: 0x0400F0C6 RID: 61638
		internal static int __PropertyOffset_VolumetricDepthFadeDistance;

		// Token: 0x0400F0C7 RID: 61639
		internal static int __PropertyOffset_VolumetricFogNearFadeInDistance;

		// Token: 0x0400F0C8 RID: 61640
		internal static int __PropertyOffset_bDisableVolumetricPhase;

		// Token: 0x0400F0C9 RID: 61641
		internal static int __PropertyOffset_VolumetricFogNewPhaseFadeRange;

		// Token: 0x0400F0CA RID: 61642
		internal static int __PropertyOffset_VolumetricScatteringIntensity;

		// Token: 0x0400F0CB RID: 61643
		internal static int __PropertyOffset_VolumetricFogAlbedo;

		// Token: 0x0400F0CC RID: 61644
		internal static int __PropertyOffset_LocalLightScatteringMultiplier;

		// Token: 0x0400F0CD RID: 61645
		internal static int __PropertyOffset_ExtinctionScale;

		// Token: 0x0400F0CE RID: 61646
		internal static int __PropertyOffset_ScatteringDistribution;

		// Token: 0x0400F0CF RID: 61647
		internal static int __PropertyOffset_ViewDistance;

		// Token: 0x0400F0D0 RID: 61648
		internal static int __PropertyOffset_VolumeMaterialSkyLightIntensity;

		// Token: 0x0400F0D1 RID: 61649
		internal static int __PropertyOffset_VolumeMaterialDirectionalLightIntensity;

		// Token: 0x0400F0D2 RID: 61650
		internal static int __PropertyOffset_VolumeMaterialOpacity;
	}
}
