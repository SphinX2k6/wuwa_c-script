using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001C1D RID: 7197
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.OriginSkyAtmosphereSetting")]
	[UnrealStructLayout(156, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 156)]
	public class FOriginSkyAtmosphereSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BC0D RID: 113677 RVA: 0x0028D8FA File Offset: 0x0028BAFA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FOriginSkyAtmosphereSetting._ScriptStructPtr != 0) ? FOriginSkyAtmosphereSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.OriginSkyAtmosphereSetting", ref FOriginSkyAtmosphereSetting._ScriptStructPtr);
		}

		// Token: 0x17006FCE RID: 28622
		// (get) Token: 0x0601BC0E RID: 113678 RVA: 0x0028D91E File Offset: 0x0028BB1E
		// (set) Token: 0x0601BC0F RID: 113679 RVA: 0x0028D937 File Offset: 0x0028BB37
		public unsafe bool bOverride_SkyAtmosLerp
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_SkyAtmosLerp) & FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_SkyAtmosLerp) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_SkyAtmosLerp) = ((*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_SkyAtmosLerp) & ~FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_SkyAtmosLerp) | (value ? FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_SkyAtmosLerp : 0));
			}
		}

		// Token: 0x17006FCF RID: 28623
		// (get) Token: 0x0601BC10 RID: 113680 RVA: 0x0028D967 File Offset: 0x0028BB67
		// (set) Token: 0x0601BC11 RID: 113681 RVA: 0x0028D980 File Offset: 0x0028BB80
		public unsafe bool bOverride_SkyAtmosAffectSkyBox
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_SkyAtmosAffectSkyBox) & FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_SkyAtmosAffectSkyBox) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_SkyAtmosAffectSkyBox) = ((*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_SkyAtmosAffectSkyBox) & ~FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_SkyAtmosAffectSkyBox) | (value ? FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_SkyAtmosAffectSkyBox : 0));
			}
		}

		// Token: 0x17006FD0 RID: 28624
		// (get) Token: 0x0601BC12 RID: 113682 RVA: 0x0028D9B0 File Offset: 0x0028BBB0
		// (set) Token: 0x0601BC13 RID: 113683 RVA: 0x0028D9C9 File Offset: 0x0028BBC9
		public unsafe bool bOverride_SkyAtmosAffectHeightFog
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_SkyAtmosAffectHeightFog) & FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_SkyAtmosAffectHeightFog) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_SkyAtmosAffectHeightFog) = ((*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_SkyAtmosAffectHeightFog) & ~FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_SkyAtmosAffectHeightFog) | (value ? FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_SkyAtmosAffectHeightFog : 0));
			}
		}

		// Token: 0x17006FD1 RID: 28625
		// (get) Token: 0x0601BC14 RID: 113684 RVA: 0x0028D9F9 File Offset: 0x0028BBF9
		// (set) Token: 0x0601BC15 RID: 113685 RVA: 0x0028DA12 File Offset: 0x0028BC12
		public unsafe bool bOverride_MieScatteringScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_MieScatteringScale) & FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_MieScatteringScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_MieScatteringScale) = ((*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_MieScatteringScale) & ~FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_MieScatteringScale) | (value ? FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_MieScatteringScale : 0));
			}
		}

		// Token: 0x17006FD2 RID: 28626
		// (get) Token: 0x0601BC16 RID: 113686 RVA: 0x0028DA42 File Offset: 0x0028BC42
		// (set) Token: 0x0601BC17 RID: 113687 RVA: 0x0028DA5B File Offset: 0x0028BC5B
		public unsafe bool bOverride_MieAbsorptionScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_MieAbsorptionScale) & FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_MieAbsorptionScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_MieAbsorptionScale) = ((*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_MieAbsorptionScale) & ~FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_MieAbsorptionScale) | (value ? FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_MieAbsorptionScale : 0));
			}
		}

		// Token: 0x17006FD3 RID: 28627
		// (get) Token: 0x0601BC18 RID: 113688 RVA: 0x0028DA8B File Offset: 0x0028BC8B
		// (set) Token: 0x0601BC19 RID: 113689 RVA: 0x0028DAA4 File Offset: 0x0028BCA4
		public unsafe bool bOverride_MieAnisotropy
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_MieAnisotropy) & FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_MieAnisotropy) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_MieAnisotropy) = ((*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_MieAnisotropy) & ~FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_MieAnisotropy) | (value ? FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_MieAnisotropy : 0));
			}
		}

		// Token: 0x17006FD4 RID: 28628
		// (get) Token: 0x0601BC1A RID: 113690 RVA: 0x0028DAD4 File Offset: 0x0028BCD4
		// (set) Token: 0x0601BC1B RID: 113691 RVA: 0x0028DAED File Offset: 0x0028BCED
		public unsafe bool bOverride_RayLeighScatteringScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_RayLeighScatteringScale) & FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_RayLeighScatteringScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_RayLeighScatteringScale) = ((*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_RayLeighScatteringScale) & ~FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_RayLeighScatteringScale) | (value ? FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_RayLeighScatteringScale : 0));
			}
		}

		// Token: 0x17006FD5 RID: 28629
		// (get) Token: 0x0601BC1C RID: 113692 RVA: 0x0028DB1D File Offset: 0x0028BD1D
		// (set) Token: 0x0601BC1D RID: 113693 RVA: 0x0028DB36 File Offset: 0x0028BD36
		public unsafe bool bOverride_RayleighScattering
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_RayleighScattering) & FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_RayleighScattering) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_RayleighScattering) = ((*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_RayleighScattering) & ~FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_RayleighScattering) | (value ? FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_RayleighScattering : 0));
			}
		}

		// Token: 0x17006FD6 RID: 28630
		// (get) Token: 0x0601BC1E RID: 113694 RVA: 0x0028DB66 File Offset: 0x0028BD66
		// (set) Token: 0x0601BC1F RID: 113695 RVA: 0x0028DB7F File Offset: 0x0028BD7F
		public unsafe bool bOverride_SkyLuminanceFactor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_SkyLuminanceFactor) & FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_SkyLuminanceFactor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_SkyLuminanceFactor) = ((*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_SkyLuminanceFactor) & ~FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_SkyLuminanceFactor) | (value ? FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_SkyLuminanceFactor : 0));
			}
		}

		// Token: 0x17006FD7 RID: 28631
		// (get) Token: 0x0601BC20 RID: 113696 RVA: 0x0028DBAF File Offset: 0x0028BDAF
		// (set) Token: 0x0601BC21 RID: 113697 RVA: 0x0028DBC8 File Offset: 0x0028BDC8
		public unsafe bool bOverride_AbsorptionScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_AbsorptionScale) & FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_AbsorptionScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_AbsorptionScale) = ((*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_AbsorptionScale) & ~FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_AbsorptionScale) | (value ? FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_AbsorptionScale : 0));
			}
		}

		// Token: 0x17006FD8 RID: 28632
		// (get) Token: 0x0601BC22 RID: 113698 RVA: 0x0028DBF8 File Offset: 0x0028BDF8
		// (set) Token: 0x0601BC23 RID: 113699 RVA: 0x0028DC11 File Offset: 0x0028BE11
		public unsafe bool bOverride_Absorption
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_Absorption) & FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_Absorption) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_Absorption) = ((*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_Absorption) & ~FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_Absorption) | (value ? FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_Absorption : 0));
			}
		}

		// Token: 0x17006FD9 RID: 28633
		// (get) Token: 0x0601BC24 RID: 113700 RVA: 0x0028DC41 File Offset: 0x0028BE41
		// (set) Token: 0x0601BC25 RID: 113701 RVA: 0x0028DC5A File Offset: 0x0028BE5A
		public unsafe bool bOverride_HeightFogInscatteringColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_HeightFogInscatteringColor) & FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_HeightFogInscatteringColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_HeightFogInscatteringColor) = ((*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_HeightFogInscatteringColor) & ~FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_HeightFogInscatteringColor) | (value ? FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_HeightFogInscatteringColor : 0));
			}
		}

		// Token: 0x17006FDA RID: 28634
		// (get) Token: 0x0601BC26 RID: 113702 RVA: 0x0028DC8A File Offset: 0x0028BE8A
		// (set) Token: 0x0601BC27 RID: 113703 RVA: 0x0028DCA3 File Offset: 0x0028BEA3
		public unsafe bool bOverride_HeightFogDirectionalInscatteringExponent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_HeightFogDirectionalInscatteringExponent) & FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_HeightFogDirectionalInscatteringExponent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_HeightFogDirectionalInscatteringExponent) = ((*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_HeightFogDirectionalInscatteringExponent) & ~FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_HeightFogDirectionalInscatteringExponent) | (value ? FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_HeightFogDirectionalInscatteringExponent : 0));
			}
		}

		// Token: 0x17006FDB RID: 28635
		// (get) Token: 0x0601BC28 RID: 113704 RVA: 0x0028DCD3 File Offset: 0x0028BED3
		// (set) Token: 0x0601BC29 RID: 113705 RVA: 0x0028DCEC File Offset: 0x0028BEEC
		public unsafe bool bOverride_HeightFogDirectionalInscatteringColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_HeightFogDirectionalInscatteringColor) & FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_HeightFogDirectionalInscatteringColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_HeightFogDirectionalInscatteringColor) = ((*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_HeightFogDirectionalInscatteringColor) & ~FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_HeightFogDirectionalInscatteringColor) | (value ? FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_HeightFogDirectionalInscatteringColor : 0));
			}
		}

		// Token: 0x17006FDC RID: 28636
		// (get) Token: 0x0601BC2A RID: 113706 RVA: 0x0028DD1C File Offset: 0x0028BF1C
		// (set) Token: 0x0601BC2B RID: 113707 RVA: 0x0028DD35 File Offset: 0x0028BF35
		public unsafe bool bOverride_BottomRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_BottomRadius) & FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_BottomRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_BottomRadius) = ((*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_BottomRadius) & ~FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_BottomRadius) | (value ? FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_BottomRadius : 0));
			}
		}

		// Token: 0x17006FDD RID: 28637
		// (get) Token: 0x0601BC2C RID: 113708 RVA: 0x0028DD65 File Offset: 0x0028BF65
		// (set) Token: 0x0601BC2D RID: 113709 RVA: 0x0028DD7E File Offset: 0x0028BF7E
		public unsafe bool bOverride_AtmosphereHeight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_AtmosphereHeight) & FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_AtmosphereHeight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_AtmosphereHeight) = ((*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_AtmosphereHeight) & ~FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_AtmosphereHeight) | (value ? FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_AtmosphereHeight : 0));
			}
		}

		// Token: 0x17006FDE RID: 28638
		// (get) Token: 0x0601BC2E RID: 113710 RVA: 0x0028DDAE File Offset: 0x0028BFAE
		// (set) Token: 0x0601BC2F RID: 113711 RVA: 0x0028DDC7 File Offset: 0x0028BFC7
		public unsafe bool bOverride_AtmosLightLuminance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_AtmosLightLuminance) & FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_AtmosLightLuminance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_AtmosLightLuminance) = ((*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_AtmosLightLuminance) & ~FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_AtmosLightLuminance) | (value ? FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_AtmosLightLuminance : 0));
			}
		}

		// Token: 0x17006FDF RID: 28639
		// (get) Token: 0x0601BC30 RID: 113712 RVA: 0x0028DDF7 File Offset: 0x0028BFF7
		// (set) Token: 0x0601BC31 RID: 113713 RVA: 0x0028DE10 File Offset: 0x0028C010
		public unsafe bool bOverride_AtmosLightColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_AtmosLightColor) & FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_AtmosLightColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_AtmosLightColor) = ((*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_AtmosLightColor) & ~FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_AtmosLightColor) | (value ? FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_AtmosLightColor : 0));
			}
		}

		// Token: 0x17006FE0 RID: 28640
		// (get) Token: 0x0601BC32 RID: 113714 RVA: 0x0028DE40 File Offset: 0x0028C040
		// (set) Token: 0x0601BC33 RID: 113715 RVA: 0x0028DE59 File Offset: 0x0028C059
		public unsafe bool bOverride_SkyAtmosSaturation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_SkyAtmosSaturation) & FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_SkyAtmosSaturation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_SkyAtmosSaturation) = ((*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_SkyAtmosSaturation) & ~FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_SkyAtmosSaturation) | (value ? FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_SkyAtmosSaturation : 0));
			}
		}

		// Token: 0x17006FE1 RID: 28641
		// (get) Token: 0x0601BC34 RID: 113716 RVA: 0x0028DE89 File Offset: 0x0028C089
		// (set) Token: 0x0601BC35 RID: 113717 RVA: 0x0028DEA2 File Offset: 0x0028C0A2
		public unsafe bool bOverride_SkyAtmosContrast
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_SkyAtmosContrast) & FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_SkyAtmosContrast) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_SkyAtmosContrast) = ((*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_bOverride_SkyAtmosContrast) & ~FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_SkyAtmosContrast) | (value ? FOriginSkyAtmosphereSetting.__PropertyMask_bOverride_SkyAtmosContrast : 0));
			}
		}

		// Token: 0x17006FE2 RID: 28642
		// (get) Token: 0x0601BC36 RID: 113718 RVA: 0x0028DED2 File Offset: 0x0028C0D2
		// (set) Token: 0x0601BC37 RID: 113719 RVA: 0x0028DEE2 File Offset: 0x0028C0E2
		public unsafe float SkyAtmosLerp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_SkyAtmosLerp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_SkyAtmosLerp) = value;
			}
		}

		// Token: 0x17006FE3 RID: 28643
		// (get) Token: 0x0601BC38 RID: 113720 RVA: 0x0028DEF3 File Offset: 0x0028C0F3
		// (set) Token: 0x0601BC39 RID: 113721 RVA: 0x0028DF03 File Offset: 0x0028C103
		public unsafe float SkyAtmosAffectSkyBox
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_SkyAtmosAffectSkyBox);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_SkyAtmosAffectSkyBox) = value;
			}
		}

		// Token: 0x17006FE4 RID: 28644
		// (get) Token: 0x0601BC3A RID: 113722 RVA: 0x0028DF14 File Offset: 0x0028C114
		// (set) Token: 0x0601BC3B RID: 113723 RVA: 0x0028DF24 File Offset: 0x0028C124
		public unsafe float SkyAtmosAffectHeightFog
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_SkyAtmosAffectHeightFog);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_SkyAtmosAffectHeightFog) = value;
			}
		}

		// Token: 0x17006FE5 RID: 28645
		// (get) Token: 0x0601BC3C RID: 113724 RVA: 0x0028DF35 File Offset: 0x0028C135
		// (set) Token: 0x0601BC3D RID: 113725 RVA: 0x0028DF49 File Offset: 0x0028C149
		public unsafe FLinearColor SkyLuminanceFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_SkyLuminanceFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_SkyLuminanceFactor) = value;
			}
		}

		// Token: 0x17006FE6 RID: 28646
		// (get) Token: 0x0601BC3E RID: 113726 RVA: 0x0028DF5E File Offset: 0x0028C15E
		// (set) Token: 0x0601BC3F RID: 113727 RVA: 0x0028DF6E File Offset: 0x0028C16E
		public unsafe float AtmosLightLuminance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_AtmosLightLuminance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_AtmosLightLuminance) = value;
			}
		}

		// Token: 0x17006FE7 RID: 28647
		// (get) Token: 0x0601BC40 RID: 113728 RVA: 0x0028DF7F File Offset: 0x0028C17F
		// (set) Token: 0x0601BC41 RID: 113729 RVA: 0x0028DF93 File Offset: 0x0028C193
		public unsafe FLinearColor AtmosLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_AtmosLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_AtmosLightColor) = value;
			}
		}

		// Token: 0x17006FE8 RID: 28648
		// (get) Token: 0x0601BC42 RID: 113730 RVA: 0x0028DFA8 File Offset: 0x0028C1A8
		// (set) Token: 0x0601BC43 RID: 113731 RVA: 0x0028DFB8 File Offset: 0x0028C1B8
		public unsafe float MieScatteringScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_MieScatteringScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_MieScatteringScale) = value;
			}
		}

		// Token: 0x17006FE9 RID: 28649
		// (get) Token: 0x0601BC44 RID: 113732 RVA: 0x0028DFC9 File Offset: 0x0028C1C9
		// (set) Token: 0x0601BC45 RID: 113733 RVA: 0x0028DFD9 File Offset: 0x0028C1D9
		public unsafe float MieAbsorptionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_MieAbsorptionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_MieAbsorptionScale) = value;
			}
		}

		// Token: 0x17006FEA RID: 28650
		// (get) Token: 0x0601BC46 RID: 113734 RVA: 0x0028DFEA File Offset: 0x0028C1EA
		// (set) Token: 0x0601BC47 RID: 113735 RVA: 0x0028DFFA File Offset: 0x0028C1FA
		public unsafe float MieAnisotropy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_MieAnisotropy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_MieAnisotropy) = value;
			}
		}

		// Token: 0x17006FEB RID: 28651
		// (get) Token: 0x0601BC48 RID: 113736 RVA: 0x0028E00B File Offset: 0x0028C20B
		// (set) Token: 0x0601BC49 RID: 113737 RVA: 0x0028E01B File Offset: 0x0028C21B
		public unsafe float RayLeighScatteringScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_RayLeighScatteringScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_RayLeighScatteringScale) = value;
			}
		}

		// Token: 0x17006FEC RID: 28652
		// (get) Token: 0x0601BC4A RID: 113738 RVA: 0x0028E02C File Offset: 0x0028C22C
		// (set) Token: 0x0601BC4B RID: 113739 RVA: 0x0028E040 File Offset: 0x0028C240
		public unsafe FLinearColor RayleighScattering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_RayleighScattering);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_RayleighScattering) = value;
			}
		}

		// Token: 0x17006FED RID: 28653
		// (get) Token: 0x0601BC4C RID: 113740 RVA: 0x0028E055 File Offset: 0x0028C255
		// (set) Token: 0x0601BC4D RID: 113741 RVA: 0x0028E069 File Offset: 0x0028C269
		public unsafe FLinearColor HeightFogInscatteringColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_HeightFogInscatteringColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_HeightFogInscatteringColor) = value;
			}
		}

		// Token: 0x17006FEE RID: 28654
		// (get) Token: 0x0601BC4E RID: 113742 RVA: 0x0028E07E File Offset: 0x0028C27E
		// (set) Token: 0x0601BC4F RID: 113743 RVA: 0x0028E08E File Offset: 0x0028C28E
		public unsafe float HeightFogDirectionalInscatteringExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_HeightFogDirectionalInscatteringExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_HeightFogDirectionalInscatteringExponent) = value;
			}
		}

		// Token: 0x17006FEF RID: 28655
		// (get) Token: 0x0601BC50 RID: 113744 RVA: 0x0028E09F File Offset: 0x0028C29F
		// (set) Token: 0x0601BC51 RID: 113745 RVA: 0x0028E0B3 File Offset: 0x0028C2B3
		public unsafe FLinearColor HeightFogDirectionalInscatteringColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_HeightFogDirectionalInscatteringColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_HeightFogDirectionalInscatteringColor) = value;
			}
		}

		// Token: 0x17006FF0 RID: 28656
		// (get) Token: 0x0601BC52 RID: 113746 RVA: 0x0028E0C8 File Offset: 0x0028C2C8
		// (set) Token: 0x0601BC53 RID: 113747 RVA: 0x0028E0D8 File Offset: 0x0028C2D8
		public unsafe float AbsorptionScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_AbsorptionScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_AbsorptionScale) = value;
			}
		}

		// Token: 0x17006FF1 RID: 28657
		// (get) Token: 0x0601BC54 RID: 113748 RVA: 0x0028E0E9 File Offset: 0x0028C2E9
		// (set) Token: 0x0601BC55 RID: 113749 RVA: 0x0028E0FD File Offset: 0x0028C2FD
		public unsafe FLinearColor Absorption
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_Absorption);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_Absorption) = value;
			}
		}

		// Token: 0x17006FF2 RID: 28658
		// (get) Token: 0x0601BC56 RID: 113750 RVA: 0x0028E112 File Offset: 0x0028C312
		// (set) Token: 0x0601BC57 RID: 113751 RVA: 0x0028E122 File Offset: 0x0028C322
		public unsafe float SkyAtmosSaturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_SkyAtmosSaturation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_SkyAtmosSaturation) = value;
			}
		}

		// Token: 0x17006FF3 RID: 28659
		// (get) Token: 0x0601BC58 RID: 113752 RVA: 0x0028E133 File Offset: 0x0028C333
		// (set) Token: 0x0601BC59 RID: 113753 RVA: 0x0028E143 File Offset: 0x0028C343
		public unsafe float SkyAtmosContrast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_SkyAtmosContrast);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_SkyAtmosContrast) = value;
			}
		}

		// Token: 0x17006FF4 RID: 28660
		// (get) Token: 0x0601BC5A RID: 113754 RVA: 0x0028E154 File Offset: 0x0028C354
		// (set) Token: 0x0601BC5B RID: 113755 RVA: 0x0028E164 File Offset: 0x0028C364
		public unsafe float BottomRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_BottomRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_BottomRadius) = value;
			}
		}

		// Token: 0x17006FF5 RID: 28661
		// (get) Token: 0x0601BC5C RID: 113756 RVA: 0x0028E175 File Offset: 0x0028C375
		// (set) Token: 0x0601BC5D RID: 113757 RVA: 0x0028E185 File Offset: 0x0028C385
		public unsafe float AtmosphereHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_AtmosphereHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FOriginSkyAtmosphereSetting.__PropertyOffset_AtmosphereHeight) = value;
			}
		}

		// Token: 0x0601BC5E RID: 113758 RVA: 0x0028E196 File Offset: 0x0028C396
		public FOriginSkyAtmosphereSetting()
		{
		}

		// Token: 0x0601BC5F RID: 113759 RVA: 0x0028E1A0 File Offset: 0x0028C3A0
		public FOriginSkyAtmosphereSetting(bool bOverride_SkyAtmosLerp, bool bOverride_SkyAtmosAffectSkyBox, bool bOverride_SkyAtmosAffectHeightFog, bool bOverride_MieScatteringScale, bool bOverride_MieAbsorptionScale, bool bOverride_MieAnisotropy, bool bOverride_RayLeighScatteringScale, bool bOverride_RayleighScattering, bool bOverride_SkyLuminanceFactor, bool bOverride_AbsorptionScale, bool bOverride_Absorption, bool bOverride_HeightFogInscatteringColor, bool bOverride_HeightFogDirectionalInscatteringExponent, bool bOverride_HeightFogDirectionalInscatteringColor, bool bOverride_BottomRadius, bool bOverride_AtmosphereHeight, bool bOverride_AtmosLightLuminance, bool bOverride_AtmosLightColor, bool bOverride_SkyAtmosSaturation, bool bOverride_SkyAtmosContrast, float SkyAtmosLerp, float SkyAtmosAffectSkyBox, float SkyAtmosAffectHeightFog, FLinearColor SkyLuminanceFactor, float AtmosLightLuminance, FLinearColor AtmosLightColor, float MieScatteringScale, float MieAbsorptionScale, float MieAnisotropy, float RayLeighScatteringScale, FLinearColor RayleighScattering, FLinearColor HeightFogInscatteringColor, float HeightFogDirectionalInscatteringExponent, FLinearColor HeightFogDirectionalInscatteringColor, float AbsorptionScale, FLinearColor Absorption, float SkyAtmosSaturation, float SkyAtmosContrast, float BottomRadius, float AtmosphereHeight)
		{
			this.bOverride_SkyAtmosLerp = bOverride_SkyAtmosLerp;
			this.bOverride_SkyAtmosAffectSkyBox = bOverride_SkyAtmosAffectSkyBox;
			this.bOverride_SkyAtmosAffectHeightFog = bOverride_SkyAtmosAffectHeightFog;
			this.bOverride_MieScatteringScale = bOverride_MieScatteringScale;
			this.bOverride_MieAbsorptionScale = bOverride_MieAbsorptionScale;
			this.bOverride_MieAnisotropy = bOverride_MieAnisotropy;
			this.bOverride_RayLeighScatteringScale = bOverride_RayLeighScatteringScale;
			this.bOverride_RayleighScattering = bOverride_RayleighScattering;
			this.bOverride_SkyLuminanceFactor = bOverride_SkyLuminanceFactor;
			this.bOverride_AbsorptionScale = bOverride_AbsorptionScale;
			this.bOverride_Absorption = bOverride_Absorption;
			this.bOverride_HeightFogInscatteringColor = bOverride_HeightFogInscatteringColor;
			this.bOverride_HeightFogDirectionalInscatteringExponent = bOverride_HeightFogDirectionalInscatteringExponent;
			this.bOverride_HeightFogDirectionalInscatteringColor = bOverride_HeightFogDirectionalInscatteringColor;
			this.bOverride_BottomRadius = bOverride_BottomRadius;
			this.bOverride_AtmosphereHeight = bOverride_AtmosphereHeight;
			this.bOverride_AtmosLightLuminance = bOverride_AtmosLightLuminance;
			this.bOverride_AtmosLightColor = bOverride_AtmosLightColor;
			this.bOverride_SkyAtmosSaturation = bOverride_SkyAtmosSaturation;
			this.bOverride_SkyAtmosContrast = bOverride_SkyAtmosContrast;
			this.SkyAtmosLerp = SkyAtmosLerp;
			this.SkyAtmosAffectSkyBox = SkyAtmosAffectSkyBox;
			this.SkyAtmosAffectHeightFog = SkyAtmosAffectHeightFog;
			this.SkyLuminanceFactor = SkyLuminanceFactor;
			this.AtmosLightLuminance = AtmosLightLuminance;
			this.AtmosLightColor = AtmosLightColor;
			this.MieScatteringScale = MieScatteringScale;
			this.MieAbsorptionScale = MieAbsorptionScale;
			this.MieAnisotropy = MieAnisotropy;
			this.RayLeighScatteringScale = RayLeighScatteringScale;
			this.RayleighScattering = RayleighScattering;
			this.HeightFogInscatteringColor = HeightFogInscatteringColor;
			this.HeightFogDirectionalInscatteringExponent = HeightFogDirectionalInscatteringExponent;
			this.HeightFogDirectionalInscatteringColor = HeightFogDirectionalInscatteringColor;
			this.AbsorptionScale = AbsorptionScale;
			this.Absorption = Absorption;
			this.SkyAtmosSaturation = SkyAtmosSaturation;
			this.SkyAtmosContrast = SkyAtmosContrast;
			this.BottomRadius = BottomRadius;
			this.AtmosphereHeight = AtmosphereHeight;
		}

		// Token: 0x0601BC60 RID: 113760 RVA: 0x0028E2F0 File Offset: 0x0028C4F0
		protected override IntPtr GetUStructPtr()
		{
			return FOriginSkyAtmosphereSetting.StaticStruct();
		}

		// Token: 0x0601BC61 RID: 113761 RVA: 0x0028E2FC File Offset: 0x0028C4FC
		[NullableContext(2)]
		public FOriginSkyAtmosphereSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BC62 RID: 113762 RVA: 0x0028E306 File Offset: 0x0028C506
		public FOriginSkyAtmosphereSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BC63 RID: 113763 RVA: 0x0028E311 File Offset: 0x0028C511
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FOriginSkyAtmosphereSetting(Pointer, false, true);
		}

		// Token: 0x0601BC64 RID: 113764 RVA: 0x0028E31B File Offset: 0x0028C51B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FOriginSkyAtmosphereSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400EEA6 RID: 61094
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.OriginSkyAtmosphereSetting";

		// Token: 0x0400EEA7 RID: 61095
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EEA8 RID: 61096
		internal static int __PropertyOffset_bOverride_SkyAtmosLerp;

		// Token: 0x0400EEA9 RID: 61097
		internal static byte __PropertyMask_bOverride_SkyAtmosLerp;

		// Token: 0x0400EEAA RID: 61098
		internal static int __PropertyOffset_bOverride_SkyAtmosAffectSkyBox;

		// Token: 0x0400EEAB RID: 61099
		internal static byte __PropertyMask_bOverride_SkyAtmosAffectSkyBox;

		// Token: 0x0400EEAC RID: 61100
		internal static int __PropertyOffset_bOverride_SkyAtmosAffectHeightFog;

		// Token: 0x0400EEAD RID: 61101
		internal static byte __PropertyMask_bOverride_SkyAtmosAffectHeightFog;

		// Token: 0x0400EEAE RID: 61102
		internal static int __PropertyOffset_bOverride_MieScatteringScale;

		// Token: 0x0400EEAF RID: 61103
		internal static byte __PropertyMask_bOverride_MieScatteringScale;

		// Token: 0x0400EEB0 RID: 61104
		internal static int __PropertyOffset_bOverride_MieAbsorptionScale;

		// Token: 0x0400EEB1 RID: 61105
		internal static byte __PropertyMask_bOverride_MieAbsorptionScale;

		// Token: 0x0400EEB2 RID: 61106
		internal static int __PropertyOffset_bOverride_MieAnisotropy;

		// Token: 0x0400EEB3 RID: 61107
		internal static byte __PropertyMask_bOverride_MieAnisotropy;

		// Token: 0x0400EEB4 RID: 61108
		internal static int __PropertyOffset_bOverride_RayLeighScatteringScale;

		// Token: 0x0400EEB5 RID: 61109
		internal static byte __PropertyMask_bOverride_RayLeighScatteringScale;

		// Token: 0x0400EEB6 RID: 61110
		internal static int __PropertyOffset_bOverride_RayleighScattering;

		// Token: 0x0400EEB7 RID: 61111
		internal static byte __PropertyMask_bOverride_RayleighScattering;

		// Token: 0x0400EEB8 RID: 61112
		internal static int __PropertyOffset_bOverride_SkyLuminanceFactor;

		// Token: 0x0400EEB9 RID: 61113
		internal static byte __PropertyMask_bOverride_SkyLuminanceFactor;

		// Token: 0x0400EEBA RID: 61114
		internal static int __PropertyOffset_bOverride_AbsorptionScale;

		// Token: 0x0400EEBB RID: 61115
		internal static byte __PropertyMask_bOverride_AbsorptionScale;

		// Token: 0x0400EEBC RID: 61116
		internal static int __PropertyOffset_bOverride_Absorption;

		// Token: 0x0400EEBD RID: 61117
		internal static byte __PropertyMask_bOverride_Absorption;

		// Token: 0x0400EEBE RID: 61118
		internal static int __PropertyOffset_bOverride_HeightFogInscatteringColor;

		// Token: 0x0400EEBF RID: 61119
		internal static byte __PropertyMask_bOverride_HeightFogInscatteringColor;

		// Token: 0x0400EEC0 RID: 61120
		internal static int __PropertyOffset_bOverride_HeightFogDirectionalInscatteringExponent;

		// Token: 0x0400EEC1 RID: 61121
		internal static byte __PropertyMask_bOverride_HeightFogDirectionalInscatteringExponent;

		// Token: 0x0400EEC2 RID: 61122
		internal static int __PropertyOffset_bOverride_HeightFogDirectionalInscatteringColor;

		// Token: 0x0400EEC3 RID: 61123
		internal static byte __PropertyMask_bOverride_HeightFogDirectionalInscatteringColor;

		// Token: 0x0400EEC4 RID: 61124
		internal static int __PropertyOffset_bOverride_BottomRadius;

		// Token: 0x0400EEC5 RID: 61125
		internal static byte __PropertyMask_bOverride_BottomRadius;

		// Token: 0x0400EEC6 RID: 61126
		internal static int __PropertyOffset_bOverride_AtmosphereHeight;

		// Token: 0x0400EEC7 RID: 61127
		internal static byte __PropertyMask_bOverride_AtmosphereHeight;

		// Token: 0x0400EEC8 RID: 61128
		internal static int __PropertyOffset_bOverride_AtmosLightLuminance;

		// Token: 0x0400EEC9 RID: 61129
		internal static byte __PropertyMask_bOverride_AtmosLightLuminance;

		// Token: 0x0400EECA RID: 61130
		internal static int __PropertyOffset_bOverride_AtmosLightColor;

		// Token: 0x0400EECB RID: 61131
		internal static byte __PropertyMask_bOverride_AtmosLightColor;

		// Token: 0x0400EECC RID: 61132
		internal static int __PropertyOffset_bOverride_SkyAtmosSaturation;

		// Token: 0x0400EECD RID: 61133
		internal static byte __PropertyMask_bOverride_SkyAtmosSaturation;

		// Token: 0x0400EECE RID: 61134
		internal static int __PropertyOffset_bOverride_SkyAtmosContrast;

		// Token: 0x0400EECF RID: 61135
		internal static byte __PropertyMask_bOverride_SkyAtmosContrast;

		// Token: 0x0400EED0 RID: 61136
		internal static int __PropertyOffset_SkyAtmosLerp;

		// Token: 0x0400EED1 RID: 61137
		internal static int __PropertyOffset_SkyAtmosAffectSkyBox;

		// Token: 0x0400EED2 RID: 61138
		internal static int __PropertyOffset_SkyAtmosAffectHeightFog;

		// Token: 0x0400EED3 RID: 61139
		internal static int __PropertyOffset_SkyLuminanceFactor;

		// Token: 0x0400EED4 RID: 61140
		internal static int __PropertyOffset_AtmosLightLuminance;

		// Token: 0x0400EED5 RID: 61141
		internal static int __PropertyOffset_AtmosLightColor;

		// Token: 0x0400EED6 RID: 61142
		internal static int __PropertyOffset_MieScatteringScale;

		// Token: 0x0400EED7 RID: 61143
		internal static int __PropertyOffset_MieAbsorptionScale;

		// Token: 0x0400EED8 RID: 61144
		internal static int __PropertyOffset_MieAnisotropy;

		// Token: 0x0400EED9 RID: 61145
		internal static int __PropertyOffset_RayLeighScatteringScale;

		// Token: 0x0400EEDA RID: 61146
		internal static int __PropertyOffset_RayleighScattering;

		// Token: 0x0400EEDB RID: 61147
		internal static int __PropertyOffset_HeightFogInscatteringColor;

		// Token: 0x0400EEDC RID: 61148
		internal static int __PropertyOffset_HeightFogDirectionalInscatteringExponent;

		// Token: 0x0400EEDD RID: 61149
		internal static int __PropertyOffset_HeightFogDirectionalInscatteringColor;

		// Token: 0x0400EEDE RID: 61150
		internal static int __PropertyOffset_AbsorptionScale;

		// Token: 0x0400EEDF RID: 61151
		internal static int __PropertyOffset_Absorption;

		// Token: 0x0400EEE0 RID: 61152
		internal static int __PropertyOffset_SkyAtmosSaturation;

		// Token: 0x0400EEE1 RID: 61153
		internal static int __PropertyOffset_SkyAtmosContrast;

		// Token: 0x0400EEE2 RID: 61154
		internal static int __PropertyOffset_BottomRadius;

		// Token: 0x0400EEE3 RID: 61155
		internal static int __PropertyOffset_AtmosphereHeight;
	}
}
