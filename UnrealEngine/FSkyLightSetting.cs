using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C2B RID: 7211
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.SkyLightSetting")]
	[UnrealStructLayout(352, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 352)]
	public class FSkyLightSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601BE50 RID: 114256 RVA: 0x002909CB File Offset: 0x0028EBCB
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSkyLightSetting._ScriptStructPtr != 0) ? FSkyLightSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.SkyLightSetting", ref FSkyLightSetting._ScriptStructPtr);
		}

		// Token: 0x17007081 RID: 28801
		// (get) Token: 0x0601BE51 RID: 114257 RVA: 0x002909EF File Offset: 0x0028EBEF
		// (set) Token: 0x0601BE52 RID: 114258 RVA: 0x00290A08 File Offset: 0x0028EC08
		public unsafe bool bOverride_SkyLightColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_SkyLightColor) & FSkyLightSetting.__PropertyMask_bOverride_SkyLightColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_SkyLightColor) = ((*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_SkyLightColor) & ~FSkyLightSetting.__PropertyMask_bOverride_SkyLightColor) | (value ? FSkyLightSetting.__PropertyMask_bOverride_SkyLightColor : 0));
			}
		}

		// Token: 0x17007082 RID: 28802
		// (get) Token: 0x0601BE53 RID: 114259 RVA: 0x00290A38 File Offset: 0x0028EC38
		// (set) Token: 0x0601BE54 RID: 114260 RVA: 0x00290A51 File Offset: 0x0028EC51
		public unsafe bool bOverride_MobileSkyLightColorSaturation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_MobileSkyLightColorSaturation) & FSkyLightSetting.__PropertyMask_bOverride_MobileSkyLightColorSaturation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_MobileSkyLightColorSaturation) = ((*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_MobileSkyLightColorSaturation) & ~FSkyLightSetting.__PropertyMask_bOverride_MobileSkyLightColorSaturation) | (value ? FSkyLightSetting.__PropertyMask_bOverride_MobileSkyLightColorSaturation : 0));
			}
		}

		// Token: 0x17007083 RID: 28803
		// (get) Token: 0x0601BE55 RID: 114261 RVA: 0x00290A81 File Offset: 0x0028EC81
		// (set) Token: 0x0601BE56 RID: 114262 RVA: 0x00290A9A File Offset: 0x0028EC9A
		public unsafe bool bOverride_MobileSkyLightValueMut
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_MobileSkyLightValueMut) & FSkyLightSetting.__PropertyMask_bOverride_MobileSkyLightValueMut) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_MobileSkyLightValueMut) = ((*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_MobileSkyLightValueMut) & ~FSkyLightSetting.__PropertyMask_bOverride_MobileSkyLightValueMut) | (value ? FSkyLightSetting.__PropertyMask_bOverride_MobileSkyLightValueMut : 0));
			}
		}

		// Token: 0x17007084 RID: 28804
		// (get) Token: 0x0601BE57 RID: 114263 RVA: 0x00290ACA File Offset: 0x0028ECCA
		// (set) Token: 0x0601BE58 RID: 114264 RVA: 0x00290AE3 File Offset: 0x0028ECE3
		public unsafe bool bOverride_SkyLightIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_SkyLightIntensity) & FSkyLightSetting.__PropertyMask_bOverride_SkyLightIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_SkyLightIntensity) = ((*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_SkyLightIntensity) & ~FSkyLightSetting.__PropertyMask_bOverride_SkyLightIntensity) | (value ? FSkyLightSetting.__PropertyMask_bOverride_SkyLightIntensity : 0));
			}
		}

		// Token: 0x17007085 RID: 28805
		// (get) Token: 0x0601BE59 RID: 114265 RVA: 0x00290B13 File Offset: 0x0028ED13
		// (set) Token: 0x0601BE5A RID: 114266 RVA: 0x00290B2C File Offset: 0x0028ED2C
		public unsafe bool bOverride_SkyLightSpecularIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_SkyLightSpecularIntensity) & FSkyLightSetting.__PropertyMask_bOverride_SkyLightSpecularIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_SkyLightSpecularIntensity) = ((*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_SkyLightSpecularIntensity) & ~FSkyLightSetting.__PropertyMask_bOverride_SkyLightSpecularIntensity) | (value ? FSkyLightSetting.__PropertyMask_bOverride_SkyLightSpecularIntensity : 0));
			}
		}

		// Token: 0x17007086 RID: 28806
		// (get) Token: 0x0601BE5B RID: 114267 RVA: 0x00290B5C File Offset: 0x0028ED5C
		// (set) Token: 0x0601BE5C RID: 114268 RVA: 0x00290B75 File Offset: 0x0028ED75
		public unsafe bool bOverride_MobileSkyLightSpecularIntensityValueMut
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_MobileSkyLightSpecularIntensityValueMut) & FSkyLightSetting.__PropertyMask_bOverride_MobileSkyLightSpecularIntensityValueMut) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_MobileSkyLightSpecularIntensityValueMut) = ((*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_MobileSkyLightSpecularIntensityValueMut) & ~FSkyLightSetting.__PropertyMask_bOverride_MobileSkyLightSpecularIntensityValueMut) | (value ? FSkyLightSetting.__PropertyMask_bOverride_MobileSkyLightSpecularIntensityValueMut : 0));
			}
		}

		// Token: 0x17007087 RID: 28807
		// (get) Token: 0x0601BE5D RID: 114269 RVA: 0x00290BA5 File Offset: 0x0028EDA5
		// (set) Token: 0x0601BE5E RID: 114270 RVA: 0x00290BBE File Offset: 0x0028EDBE
		public unsafe bool bOverride_KuroSkyLightCubemap
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroSkyLightCubemap) & FSkyLightSetting.__PropertyMask_bOverride_KuroSkyLightCubemap) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroSkyLightCubemap) = ((*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroSkyLightCubemap) & ~FSkyLightSetting.__PropertyMask_bOverride_KuroSkyLightCubemap) | (value ? FSkyLightSetting.__PropertyMask_bOverride_KuroSkyLightCubemap : 0));
			}
		}

		// Token: 0x17007088 RID: 28808
		// (get) Token: 0x0601BE5F RID: 114271 RVA: 0x00290BEE File Offset: 0x0028EDEE
		// (set) Token: 0x0601BE60 RID: 114272 RVA: 0x00290C07 File Offset: 0x0028EE07
		public unsafe bool bOverride_KuroSkyLightTranslucent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroSkyLightTranslucent) & FSkyLightSetting.__PropertyMask_bOverride_KuroSkyLightTranslucent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroSkyLightTranslucent) = ((*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroSkyLightTranslucent) & ~FSkyLightSetting.__PropertyMask_bOverride_KuroSkyLightTranslucent) | (value ? FSkyLightSetting.__PropertyMask_bOverride_KuroSkyLightTranslucent : 0));
			}
		}

		// Token: 0x17007089 RID: 28809
		// (get) Token: 0x0601BE61 RID: 114273 RVA: 0x00290C37 File Offset: 0x0028EE37
		// (set) Token: 0x0601BE62 RID: 114274 RVA: 0x00290C50 File Offset: 0x0028EE50
		public unsafe bool bOverride_KuroInteriorSkyLightIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroInteriorSkyLightIntensity) & FSkyLightSetting.__PropertyMask_bOverride_KuroInteriorSkyLightIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroInteriorSkyLightIntensity) = ((*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroInteriorSkyLightIntensity) & ~FSkyLightSetting.__PropertyMask_bOverride_KuroInteriorSkyLightIntensity) | (value ? FSkyLightSetting.__PropertyMask_bOverride_KuroInteriorSkyLightIntensity : 0));
			}
		}

		// Token: 0x1700708A RID: 28810
		// (get) Token: 0x0601BE63 RID: 114275 RVA: 0x00290C80 File Offset: 0x0028EE80
		// (set) Token: 0x0601BE64 RID: 114276 RVA: 0x00290C99 File Offset: 0x0028EE99
		public unsafe bool bOverride_KuroInteriorSkyLightColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroInteriorSkyLightColor) & FSkyLightSetting.__PropertyMask_bOverride_KuroInteriorSkyLightColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroInteriorSkyLightColor) = ((*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroInteriorSkyLightColor) & ~FSkyLightSetting.__PropertyMask_bOverride_KuroInteriorSkyLightColor) | (value ? FSkyLightSetting.__PropertyMask_bOverride_KuroInteriorSkyLightColor : 0));
			}
		}

		// Token: 0x1700708B RID: 28811
		// (get) Token: 0x0601BE65 RID: 114277 RVA: 0x00290CC9 File Offset: 0x0028EEC9
		// (set) Token: 0x0601BE66 RID: 114278 RVA: 0x00290CE2 File Offset: 0x0028EEE2
		public unsafe bool bOverride_KuroNearSkyLightColorPC
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroNearSkyLightColorPC) & FSkyLightSetting.__PropertyMask_bOverride_KuroNearSkyLightColorPC) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroNearSkyLightColorPC) = ((*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroNearSkyLightColorPC) & ~FSkyLightSetting.__PropertyMask_bOverride_KuroNearSkyLightColorPC) | (value ? FSkyLightSetting.__PropertyMask_bOverride_KuroNearSkyLightColorPC : 0));
			}
		}

		// Token: 0x1700708C RID: 28812
		// (get) Token: 0x0601BE67 RID: 114279 RVA: 0x00290D12 File Offset: 0x0028EF12
		// (set) Token: 0x0601BE68 RID: 114280 RVA: 0x00290D2B File Offset: 0x0028EF2B
		public unsafe bool bOverride_KuroNearSkyLightDistancePC
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroNearSkyLightDistancePC) & FSkyLightSetting.__PropertyMask_bOverride_KuroNearSkyLightDistancePC) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroNearSkyLightDistancePC) = ((*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroNearSkyLightDistancePC) & ~FSkyLightSetting.__PropertyMask_bOverride_KuroNearSkyLightDistancePC) | (value ? FSkyLightSetting.__PropertyMask_bOverride_KuroNearSkyLightDistancePC : 0));
			}
		}

		// Token: 0x1700708D RID: 28813
		// (get) Token: 0x0601BE69 RID: 114281 RVA: 0x00290D5B File Offset: 0x0028EF5B
		// (set) Token: 0x0601BE6A RID: 114282 RVA: 0x00290D74 File Offset: 0x0028EF74
		public unsafe bool bOverride_KuroUseSeperateMobileNearSkyLight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroUseSeperateMobileNearSkyLight) & FSkyLightSetting.__PropertyMask_bOverride_KuroUseSeperateMobileNearSkyLight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroUseSeperateMobileNearSkyLight) = ((*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroUseSeperateMobileNearSkyLight) & ~FSkyLightSetting.__PropertyMask_bOverride_KuroUseSeperateMobileNearSkyLight) | (value ? FSkyLightSetting.__PropertyMask_bOverride_KuroUseSeperateMobileNearSkyLight : 0));
			}
		}

		// Token: 0x1700708E RID: 28814
		// (get) Token: 0x0601BE6B RID: 114283 RVA: 0x00290DA4 File Offset: 0x0028EFA4
		// (set) Token: 0x0601BE6C RID: 114284 RVA: 0x00290DBD File Offset: 0x0028EFBD
		public unsafe bool bOverride_KuroNearSkyLightColorMobile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroNearSkyLightColorMobile) & FSkyLightSetting.__PropertyMask_bOverride_KuroNearSkyLightColorMobile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroNearSkyLightColorMobile) = ((*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroNearSkyLightColorMobile) & ~FSkyLightSetting.__PropertyMask_bOverride_KuroNearSkyLightColorMobile) | (value ? FSkyLightSetting.__PropertyMask_bOverride_KuroNearSkyLightColorMobile : 0));
			}
		}

		// Token: 0x1700708F RID: 28815
		// (get) Token: 0x0601BE6D RID: 114285 RVA: 0x00290DED File Offset: 0x0028EFED
		// (set) Token: 0x0601BE6E RID: 114286 RVA: 0x00290E06 File Offset: 0x0028F006
		public unsafe bool bOverride_KuroNearSkyLightDistanceMobile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroNearSkyLightDistanceMobile) & FSkyLightSetting.__PropertyMask_bOverride_KuroNearSkyLightDistanceMobile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroNearSkyLightDistanceMobile) = ((*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroNearSkyLightDistanceMobile) & ~FSkyLightSetting.__PropertyMask_bOverride_KuroNearSkyLightDistanceMobile) | (value ? FSkyLightSetting.__PropertyMask_bOverride_KuroNearSkyLightDistanceMobile : 0));
			}
		}

		// Token: 0x17007090 RID: 28816
		// (get) Token: 0x0601BE6F RID: 114287 RVA: 0x00290E36 File Offset: 0x0028F036
		// (set) Token: 0x0601BE70 RID: 114288 RVA: 0x00290E4F File Offset: 0x0028F04F
		public unsafe bool bOverride_KuroMetalCubeMapBoost_MetallicStart
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroMetalCubeMapBoost_MetallicStart) & FSkyLightSetting.__PropertyMask_bOverride_KuroMetalCubeMapBoost_MetallicStart) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroMetalCubeMapBoost_MetallicStart) = ((*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroMetalCubeMapBoost_MetallicStart) & ~FSkyLightSetting.__PropertyMask_bOverride_KuroMetalCubeMapBoost_MetallicStart) | (value ? FSkyLightSetting.__PropertyMask_bOverride_KuroMetalCubeMapBoost_MetallicStart : 0));
			}
		}

		// Token: 0x17007091 RID: 28817
		// (get) Token: 0x0601BE71 RID: 114289 RVA: 0x00290E7F File Offset: 0x0028F07F
		// (set) Token: 0x0601BE72 RID: 114290 RVA: 0x00290E98 File Offset: 0x0028F098
		public unsafe bool bOverride_KuroMetalCubeMapBoost_RoughnessMul
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroMetalCubeMapBoost_RoughnessMul) & FSkyLightSetting.__PropertyMask_bOverride_KuroMetalCubeMapBoost_RoughnessMul) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroMetalCubeMapBoost_RoughnessMul) = ((*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_KuroMetalCubeMapBoost_RoughnessMul) & ~FSkyLightSetting.__PropertyMask_bOverride_KuroMetalCubeMapBoost_RoughnessMul) | (value ? FSkyLightSetting.__PropertyMask_bOverride_KuroMetalCubeMapBoost_RoughnessMul : 0));
			}
		}

		// Token: 0x17007092 RID: 28818
		// (get) Token: 0x0601BE73 RID: 114291 RVA: 0x00290EC8 File Offset: 0x0028F0C8
		// (set) Token: 0x0601BE74 RID: 114292 RVA: 0x00290EE1 File Offset: 0x0028F0E1
		public unsafe bool bOverride_AOColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_AOColor) & FSkyLightSetting.__PropertyMask_bOverride_AOColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_AOColor) = ((*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_AOColor) & ~FSkyLightSetting.__PropertyMask_bOverride_AOColor) | (value ? FSkyLightSetting.__PropertyMask_bOverride_AOColor : 0));
			}
		}

		// Token: 0x17007093 RID: 28819
		// (get) Token: 0x0601BE75 RID: 114293 RVA: 0x00290F11 File Offset: 0x0028F111
		// (set) Token: 0x0601BE76 RID: 114294 RVA: 0x00290F2A File Offset: 0x0028F12A
		public unsafe bool bOverride_SkyLightShadowIntSupplement
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_SkyLightShadowIntSupplement) & FSkyLightSetting.__PropertyMask_bOverride_SkyLightShadowIntSupplement) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_SkyLightShadowIntSupplement) = ((*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_SkyLightShadowIntSupplement) & ~FSkyLightSetting.__PropertyMask_bOverride_SkyLightShadowIntSupplement) | (value ? FSkyLightSetting.__PropertyMask_bOverride_SkyLightShadowIntSupplement : 0));
			}
		}

		// Token: 0x17007094 RID: 28820
		// (get) Token: 0x0601BE77 RID: 114295 RVA: 0x00290F5A File Offset: 0x0028F15A
		// (set) Token: 0x0601BE78 RID: 114296 RVA: 0x00290F73 File Offset: 0x0028F173
		public unsafe bool bOverride_SkyLightShadowIntSupplementDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_SkyLightShadowIntSupplementDistance) & FSkyLightSetting.__PropertyMask_bOverride_SkyLightShadowIntSupplementDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_SkyLightShadowIntSupplementDistance) = ((*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bOverride_SkyLightShadowIntSupplementDistance) & ~FSkyLightSetting.__PropertyMask_bOverride_SkyLightShadowIntSupplementDistance) | (value ? FSkyLightSetting.__PropertyMask_bOverride_SkyLightShadowIntSupplementDistance : 0));
			}
		}

		// Token: 0x17007095 RID: 28821
		// (get) Token: 0x0601BE79 RID: 114297 RVA: 0x00290FA3 File Offset: 0x0028F1A3
		// (set) Token: 0x0601BE7A RID: 114298 RVA: 0x00290FB7 File Offset: 0x0028F1B7
		public unsafe FLinearColor SkyLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_SkyLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_SkyLightColor) = value;
			}
		}

		// Token: 0x17007096 RID: 28822
		// (get) Token: 0x0601BE7B RID: 114299 RVA: 0x00290FCC File Offset: 0x0028F1CC
		// (set) Token: 0x0601BE7C RID: 114300 RVA: 0x00290FDC File Offset: 0x0028F1DC
		public unsafe float MobileSkyLightColorSaturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_MobileSkyLightColorSaturation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_MobileSkyLightColorSaturation) = value;
			}
		}

		// Token: 0x17007097 RID: 28823
		// (get) Token: 0x0601BE7D RID: 114301 RVA: 0x00290FED File Offset: 0x0028F1ED
		// (set) Token: 0x0601BE7E RID: 114302 RVA: 0x00290FFD File Offset: 0x0028F1FD
		public unsafe float MobileSkyLightValueMut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_MobileSkyLightValueMut);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_MobileSkyLightValueMut) = value;
			}
		}

		// Token: 0x17007098 RID: 28824
		// (get) Token: 0x0601BE7F RID: 114303 RVA: 0x0029100E File Offset: 0x0028F20E
		// (set) Token: 0x0601BE80 RID: 114304 RVA: 0x0029101E File Offset: 0x0028F21E
		public unsafe float SkyLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_SkyLightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_SkyLightIntensity) = value;
			}
		}

		// Token: 0x17007099 RID: 28825
		// (get) Token: 0x0601BE81 RID: 114305 RVA: 0x0029102F File Offset: 0x0028F22F
		// (set) Token: 0x0601BE82 RID: 114306 RVA: 0x0029103F File Offset: 0x0028F23F
		public unsafe float SkyLightSpecularIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_SkyLightSpecularIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_SkyLightSpecularIntensity) = value;
			}
		}

		// Token: 0x1700709A RID: 28826
		// (get) Token: 0x0601BE83 RID: 114307 RVA: 0x00291050 File Offset: 0x0028F250
		// (set) Token: 0x0601BE84 RID: 114308 RVA: 0x00291060 File Offset: 0x0028F260
		public unsafe float MobileSkyLightSpecularIntensityValueMut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_MobileSkyLightSpecularIntensityValueMut);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_MobileSkyLightSpecularIntensityValueMut) = value;
			}
		}

		// Token: 0x1700709B RID: 28827
		// (get) Token: 0x0601BE85 RID: 114309 RVA: 0x00291071 File Offset: 0x0028F271
		// (set) Token: 0x0601BE86 RID: 114310 RVA: 0x00291081 File Offset: 0x0028F281
		public unsafe float KuroSkyLightTranslucent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroSkyLightTranslucent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroSkyLightTranslucent) = value;
			}
		}

		// Token: 0x1700709C RID: 28828
		// (get) Token: 0x0601BE87 RID: 114311 RVA: 0x00291092 File Offset: 0x0028F292
		// (set) Token: 0x0601BE88 RID: 114312 RVA: 0x002910A2 File Offset: 0x0028F2A2
		public unsafe float KuroInteriorSkyLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroInteriorSkyLightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroInteriorSkyLightIntensity) = value;
			}
		}

		// Token: 0x1700709D RID: 28829
		// (get) Token: 0x0601BE89 RID: 114313 RVA: 0x002910B3 File Offset: 0x0028F2B3
		// (set) Token: 0x0601BE8A RID: 114314 RVA: 0x002910C7 File Offset: 0x0028F2C7
		public unsafe FLinearColor KuroInteriorSkyLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroInteriorSkyLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroInteriorSkyLightColor) = value;
			}
		}

		// Token: 0x1700709E RID: 28830
		// (get) Token: 0x0601BE8B RID: 114315 RVA: 0x002910DC File Offset: 0x0028F2DC
		// (set) Token: 0x0601BE8C RID: 114316 RVA: 0x002910F0 File Offset: 0x0028F2F0
		public unsafe FLinearColor KuroNearSkyLightColorPC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroNearSkyLightColorPC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroNearSkyLightColorPC) = value;
			}
		}

		// Token: 0x1700709F RID: 28831
		// (get) Token: 0x0601BE8D RID: 114317 RVA: 0x00291105 File Offset: 0x0028F305
		// (set) Token: 0x0601BE8E RID: 114318 RVA: 0x00291115 File Offset: 0x0028F315
		public unsafe float KuroNearSkyLightDistancePC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroNearSkyLightDistancePC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroNearSkyLightDistancePC) = value;
			}
		}

		// Token: 0x170070A0 RID: 28832
		// (get) Token: 0x0601BE8F RID: 114319 RVA: 0x00291126 File Offset: 0x0028F326
		// (set) Token: 0x0601BE90 RID: 114320 RVA: 0x00291136 File Offset: 0x0028F336
		public unsafe bool KuroUseSeperateMobileNearSkyLight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroUseSeperateMobileNearSkyLight) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroUseSeperateMobileNearSkyLight) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070A1 RID: 28833
		// (get) Token: 0x0601BE91 RID: 114321 RVA: 0x00291147 File Offset: 0x0028F347
		// (set) Token: 0x0601BE92 RID: 114322 RVA: 0x0029115B File Offset: 0x0028F35B
		public unsafe FLinearColor KuroNearSkyLightColorMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroNearSkyLightColorMobile);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroNearSkyLightColorMobile) = value;
			}
		}

		// Token: 0x170070A2 RID: 28834
		// (get) Token: 0x0601BE93 RID: 114323 RVA: 0x00291170 File Offset: 0x0028F370
		// (set) Token: 0x0601BE94 RID: 114324 RVA: 0x00291180 File Offset: 0x0028F380
		public unsafe float KuroNearSkyLightDistanceMobile
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroNearSkyLightDistanceMobile);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroNearSkyLightDistanceMobile) = value;
			}
		}

		// Token: 0x170070A3 RID: 28835
		// (get) Token: 0x0601BE95 RID: 114325 RVA: 0x00291191 File Offset: 0x0028F391
		// (set) Token: 0x0601BE96 RID: 114326 RVA: 0x002911A1 File Offset: 0x0028F3A1
		public unsafe float KuroMetalCubeMapBoost_MetallicStart
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroMetalCubeMapBoost_MetallicStart);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroMetalCubeMapBoost_MetallicStart) = value;
			}
		}

		// Token: 0x170070A4 RID: 28836
		// (get) Token: 0x0601BE97 RID: 114327 RVA: 0x002911B2 File Offset: 0x0028F3B2
		// (set) Token: 0x0601BE98 RID: 114328 RVA: 0x002911C2 File Offset: 0x0028F3C2
		public unsafe float KuroMetalCubeMapBoost_RoughnessMul
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroMetalCubeMapBoost_RoughnessMul);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroMetalCubeMapBoost_RoughnessMul) = value;
			}
		}

		// Token: 0x170070A5 RID: 28837
		// (get) Token: 0x0601BE99 RID: 114329 RVA: 0x002911D3 File Offset: 0x0028F3D3
		// (set) Token: 0x0601BE9A RID: 114330 RVA: 0x002911E7 File Offset: 0x0028F3E7
		public unsafe FLinearColor AOColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_AOColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_AOColor) = value;
			}
		}

		// Token: 0x170070A6 RID: 28838
		// (get) Token: 0x0601BE9B RID: 114331 RVA: 0x002911FC File Offset: 0x0028F3FC
		// (set) Token: 0x0601BE9C RID: 114332 RVA: 0x00291210 File Offset: 0x0028F410
		[Nullable(2)]
		public unsafe UTextureCube KuroSkyLightCubemap
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureCube>(base.NativePtr / (IntPtr)sizeof(void*) + FSkyLightSetting.__PropertyOffset_KuroSkyLightCubemap);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSkyLightSetting.__PropertyOffset_KuroSkyLightCubemap, value);
			}
		}

		// Token: 0x170070A7 RID: 28839
		// (get) Token: 0x0601BE9D RID: 114333 RVA: 0x00291225 File Offset: 0x0028F425
		// (set) Token: 0x0601BE9E RID: 114334 RVA: 0x00291239 File Offset: 0x0028F439
		public unsafe FVector KuroSkyLightSH1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroSkyLightSH1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroSkyLightSH1) = value;
			}
		}

		// Token: 0x170070A8 RID: 28840
		// (get) Token: 0x0601BE9F RID: 114335 RVA: 0x0029124E File Offset: 0x0028F44E
		// (set) Token: 0x0601BEA0 RID: 114336 RVA: 0x00291262 File Offset: 0x0028F462
		public unsafe FVector KuroSkyLightSH2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroSkyLightSH2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroSkyLightSH2) = value;
			}
		}

		// Token: 0x170070A9 RID: 28841
		// (get) Token: 0x0601BEA1 RID: 114337 RVA: 0x00291277 File Offset: 0x0028F477
		// (set) Token: 0x0601BEA2 RID: 114338 RVA: 0x0029128B File Offset: 0x0028F48B
		public unsafe FVector KuroSkyLightSH3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroSkyLightSH3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroSkyLightSH3) = value;
			}
		}

		// Token: 0x170070AA RID: 28842
		// (get) Token: 0x0601BEA3 RID: 114339 RVA: 0x002912A0 File Offset: 0x0028F4A0
		// (set) Token: 0x0601BEA4 RID: 114340 RVA: 0x002912B4 File Offset: 0x0028F4B4
		public unsafe FVector KuroSkyLightSH4
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroSkyLightSH4);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroSkyLightSH4) = value;
			}
		}

		// Token: 0x170070AB RID: 28843
		// (get) Token: 0x0601BEA5 RID: 114341 RVA: 0x002912C9 File Offset: 0x0028F4C9
		// (set) Token: 0x0601BEA6 RID: 114342 RVA: 0x002912DD File Offset: 0x0028F4DD
		public unsafe FVector KuroSkyLightSH5
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroSkyLightSH5);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroSkyLightSH5) = value;
			}
		}

		// Token: 0x170070AC RID: 28844
		// (get) Token: 0x0601BEA7 RID: 114343 RVA: 0x002912F2 File Offset: 0x0028F4F2
		// (set) Token: 0x0601BEA8 RID: 114344 RVA: 0x00291306 File Offset: 0x0028F506
		public unsafe FVector KuroSkyLightSH6
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroSkyLightSH6);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_KuroSkyLightSH6) = value;
			}
		}

		// Token: 0x170070AD RID: 28845
		// (get) Token: 0x0601BEA9 RID: 114345 RVA: 0x0029131B File Offset: 0x0028F51B
		// (set) Token: 0x0601BEAA RID: 114346 RVA: 0x0029132B File Offset: 0x0028F52B
		public unsafe bool bUseGradientColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bUseGradientColorTint) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_bUseGradientColorTint) = (value ? 1 : 0);
			}
		}

		// Token: 0x170070AE RID: 28846
		// (get) Token: 0x0601BEAB RID: 114347 RVA: 0x0029133C File Offset: 0x0028F53C
		// (set) Token: 0x0601BEAC RID: 114348 RVA: 0x00291350 File Offset: 0x0028F550
		public unsafe FLinearColor SkyColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_SkyColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_SkyColor) = value;
			}
		}

		// Token: 0x170070AF RID: 28847
		// (get) Token: 0x0601BEAD RID: 114349 RVA: 0x00291365 File Offset: 0x0028F565
		// (set) Token: 0x0601BEAE RID: 114350 RVA: 0x00291379 File Offset: 0x0028F579
		public unsafe FLinearColor GroudColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_GroudColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_GroudColor) = value;
			}
		}

		// Token: 0x170070B0 RID: 28848
		// (get) Token: 0x0601BEAF RID: 114351 RVA: 0x0029138E File Offset: 0x0028F58E
		// (set) Token: 0x0601BEB0 RID: 114352 RVA: 0x0029139E File Offset: 0x0028F59E
		public unsafe float SkyLightShadowIntSupplement
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_SkyLightShadowIntSupplement);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_SkyLightShadowIntSupplement) = value;
			}
		}

		// Token: 0x170070B1 RID: 28849
		// (get) Token: 0x0601BEB1 RID: 114353 RVA: 0x002913AF File Offset: 0x0028F5AF
		// (set) Token: 0x0601BEB2 RID: 114354 RVA: 0x002913BF File Offset: 0x0028F5BF
		public unsafe float SkyLightShadowIntSupplementDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_SkyLightShadowIntSupplementDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSkyLightSetting.__PropertyOffset_SkyLightShadowIntSupplementDistance) = value;
			}
		}

		// Token: 0x0601BEB3 RID: 114355 RVA: 0x002913D0 File Offset: 0x0028F5D0
		public FSkyLightSetting()
		{
		}

		// Token: 0x0601BEB4 RID: 114356 RVA: 0x002913D8 File Offset: 0x0028F5D8
		[NullableContext(1)]
		public FSkyLightSetting(bool bOverride_SkyLightColor, bool bOverride_MobileSkyLightColorSaturation, bool bOverride_MobileSkyLightValueMut, bool bOverride_SkyLightIntensity, bool bOverride_SkyLightSpecularIntensity, bool bOverride_MobileSkyLightSpecularIntensityValueMut, bool bOverride_KuroSkyLightCubemap, bool bOverride_KuroSkyLightTranslucent, bool bOverride_KuroInteriorSkyLightIntensity, bool bOverride_KuroInteriorSkyLightColor, bool bOverride_KuroNearSkyLightColorPC, bool bOverride_KuroNearSkyLightDistancePC, bool bOverride_KuroUseSeperateMobileNearSkyLight, bool bOverride_KuroNearSkyLightColorMobile, bool bOverride_KuroNearSkyLightDistanceMobile, bool bOverride_KuroMetalCubeMapBoost_MetallicStart, bool bOverride_KuroMetalCubeMapBoost_RoughnessMul, bool bOverride_AOColor, bool bOverride_SkyLightShadowIntSupplement, bool bOverride_SkyLightShadowIntSupplementDistance, FLinearColor SkyLightColor, float MobileSkyLightColorSaturation, float MobileSkyLightValueMut, float SkyLightIntensity, float SkyLightSpecularIntensity, float MobileSkyLightSpecularIntensityValueMut, float KuroSkyLightTranslucent, float KuroInteriorSkyLightIntensity, FLinearColor KuroInteriorSkyLightColor, FLinearColor KuroNearSkyLightColorPC, float KuroNearSkyLightDistancePC, bool KuroUseSeperateMobileNearSkyLight, FLinearColor KuroNearSkyLightColorMobile, float KuroNearSkyLightDistanceMobile, float KuroMetalCubeMapBoost_MetallicStart, float KuroMetalCubeMapBoost_RoughnessMul, FLinearColor AOColor, UTextureCube KuroSkyLightCubemap, FVector KuroSkyLightSH1, FVector KuroSkyLightSH2, FVector KuroSkyLightSH3, FVector KuroSkyLightSH4, FVector KuroSkyLightSH5, FVector KuroSkyLightSH6, bool bUseGradientColorTint, FLinearColor SkyColor, FLinearColor GroudColor, float SkyLightShadowIntSupplement, float SkyLightShadowIntSupplementDistance)
		{
			this.bOverride_SkyLightColor = bOverride_SkyLightColor;
			this.bOverride_MobileSkyLightColorSaturation = bOverride_MobileSkyLightColorSaturation;
			this.bOverride_MobileSkyLightValueMut = bOverride_MobileSkyLightValueMut;
			this.bOverride_SkyLightIntensity = bOverride_SkyLightIntensity;
			this.bOverride_SkyLightSpecularIntensity = bOverride_SkyLightSpecularIntensity;
			this.bOverride_MobileSkyLightSpecularIntensityValueMut = bOverride_MobileSkyLightSpecularIntensityValueMut;
			this.bOverride_KuroSkyLightCubemap = bOverride_KuroSkyLightCubemap;
			this.bOverride_KuroSkyLightTranslucent = bOverride_KuroSkyLightTranslucent;
			this.bOverride_KuroInteriorSkyLightIntensity = bOverride_KuroInteriorSkyLightIntensity;
			this.bOverride_KuroInteriorSkyLightColor = bOverride_KuroInteriorSkyLightColor;
			this.bOverride_KuroNearSkyLightColorPC = bOverride_KuroNearSkyLightColorPC;
			this.bOverride_KuroNearSkyLightDistancePC = bOverride_KuroNearSkyLightDistancePC;
			this.bOverride_KuroUseSeperateMobileNearSkyLight = bOverride_KuroUseSeperateMobileNearSkyLight;
			this.bOverride_KuroNearSkyLightColorMobile = bOverride_KuroNearSkyLightColorMobile;
			this.bOverride_KuroNearSkyLightDistanceMobile = bOverride_KuroNearSkyLightDistanceMobile;
			this.bOverride_KuroMetalCubeMapBoost_MetallicStart = bOverride_KuroMetalCubeMapBoost_MetallicStart;
			this.bOverride_KuroMetalCubeMapBoost_RoughnessMul = bOverride_KuroMetalCubeMapBoost_RoughnessMul;
			this.bOverride_AOColor = bOverride_AOColor;
			this.bOverride_SkyLightShadowIntSupplement = bOverride_SkyLightShadowIntSupplement;
			this.bOverride_SkyLightShadowIntSupplementDistance = bOverride_SkyLightShadowIntSupplementDistance;
			this.SkyLightColor = SkyLightColor;
			this.MobileSkyLightColorSaturation = MobileSkyLightColorSaturation;
			this.MobileSkyLightValueMut = MobileSkyLightValueMut;
			this.SkyLightIntensity = SkyLightIntensity;
			this.SkyLightSpecularIntensity = SkyLightSpecularIntensity;
			this.MobileSkyLightSpecularIntensityValueMut = MobileSkyLightSpecularIntensityValueMut;
			this.KuroSkyLightTranslucent = KuroSkyLightTranslucent;
			this.KuroInteriorSkyLightIntensity = KuroInteriorSkyLightIntensity;
			this.KuroInteriorSkyLightColor = KuroInteriorSkyLightColor;
			this.KuroNearSkyLightColorPC = KuroNearSkyLightColorPC;
			this.KuroNearSkyLightDistancePC = KuroNearSkyLightDistancePC;
			this.KuroUseSeperateMobileNearSkyLight = KuroUseSeperateMobileNearSkyLight;
			this.KuroNearSkyLightColorMobile = KuroNearSkyLightColorMobile;
			this.KuroNearSkyLightDistanceMobile = KuroNearSkyLightDistanceMobile;
			this.KuroMetalCubeMapBoost_MetallicStart = KuroMetalCubeMapBoost_MetallicStart;
			this.KuroMetalCubeMapBoost_RoughnessMul = KuroMetalCubeMapBoost_RoughnessMul;
			this.AOColor = AOColor;
			this.KuroSkyLightCubemap = KuroSkyLightCubemap;
			this.KuroSkyLightSH1 = KuroSkyLightSH1;
			this.KuroSkyLightSH2 = KuroSkyLightSH2;
			this.KuroSkyLightSH3 = KuroSkyLightSH3;
			this.KuroSkyLightSH4 = KuroSkyLightSH4;
			this.KuroSkyLightSH5 = KuroSkyLightSH5;
			this.KuroSkyLightSH6 = KuroSkyLightSH6;
			this.bUseGradientColorTint = bUseGradientColorTint;
			this.SkyColor = SkyColor;
			this.GroudColor = GroudColor;
			this.SkyLightShadowIntSupplement = SkyLightShadowIntSupplement;
			this.SkyLightShadowIntSupplementDistance = SkyLightShadowIntSupplementDistance;
		}

		// Token: 0x0601BEB5 RID: 114357 RVA: 0x00291570 File Offset: 0x0028F770
		protected override IntPtr GetUStructPtr()
		{
			return FSkyLightSetting.StaticStruct();
		}

		// Token: 0x0601BEB6 RID: 114358 RVA: 0x0029157C File Offset: 0x0028F77C
		[NullableContext(2)]
		public FSkyLightSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601BEB7 RID: 114359 RVA: 0x00291586 File Offset: 0x0028F786
		public FSkyLightSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601BEB8 RID: 114360 RVA: 0x00291591 File Offset: 0x0028F791
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSkyLightSetting(Pointer, false, true);
		}

		// Token: 0x0601BEB9 RID: 114361 RVA: 0x0029159B File Offset: 0x0028F79B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSkyLightSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400EFA0 RID: 61344
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.SkyLightSetting";

		// Token: 0x0400EFA1 RID: 61345
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EFA2 RID: 61346
		internal static int __PropertyOffset_bOverride_SkyLightColor;

		// Token: 0x0400EFA3 RID: 61347
		internal static byte __PropertyMask_bOverride_SkyLightColor;

		// Token: 0x0400EFA4 RID: 61348
		internal static int __PropertyOffset_bOverride_MobileSkyLightColorSaturation;

		// Token: 0x0400EFA5 RID: 61349
		internal static byte __PropertyMask_bOverride_MobileSkyLightColorSaturation;

		// Token: 0x0400EFA6 RID: 61350
		internal static int __PropertyOffset_bOverride_MobileSkyLightValueMut;

		// Token: 0x0400EFA7 RID: 61351
		internal static byte __PropertyMask_bOverride_MobileSkyLightValueMut;

		// Token: 0x0400EFA8 RID: 61352
		internal static int __PropertyOffset_bOverride_SkyLightIntensity;

		// Token: 0x0400EFA9 RID: 61353
		internal static byte __PropertyMask_bOverride_SkyLightIntensity;

		// Token: 0x0400EFAA RID: 61354
		internal static int __PropertyOffset_bOverride_SkyLightSpecularIntensity;

		// Token: 0x0400EFAB RID: 61355
		internal static byte __PropertyMask_bOverride_SkyLightSpecularIntensity;

		// Token: 0x0400EFAC RID: 61356
		internal static int __PropertyOffset_bOverride_MobileSkyLightSpecularIntensityValueMut;

		// Token: 0x0400EFAD RID: 61357
		internal static byte __PropertyMask_bOverride_MobileSkyLightSpecularIntensityValueMut;

		// Token: 0x0400EFAE RID: 61358
		internal static int __PropertyOffset_bOverride_KuroSkyLightCubemap;

		// Token: 0x0400EFAF RID: 61359
		internal static byte __PropertyMask_bOverride_KuroSkyLightCubemap;

		// Token: 0x0400EFB0 RID: 61360
		internal static int __PropertyOffset_bOverride_KuroSkyLightTranslucent;

		// Token: 0x0400EFB1 RID: 61361
		internal static byte __PropertyMask_bOverride_KuroSkyLightTranslucent;

		// Token: 0x0400EFB2 RID: 61362
		internal static int __PropertyOffset_bOverride_KuroInteriorSkyLightIntensity;

		// Token: 0x0400EFB3 RID: 61363
		internal static byte __PropertyMask_bOverride_KuroInteriorSkyLightIntensity;

		// Token: 0x0400EFB4 RID: 61364
		internal static int __PropertyOffset_bOverride_KuroInteriorSkyLightColor;

		// Token: 0x0400EFB5 RID: 61365
		internal static byte __PropertyMask_bOverride_KuroInteriorSkyLightColor;

		// Token: 0x0400EFB6 RID: 61366
		internal static int __PropertyOffset_bOverride_KuroNearSkyLightColorPC;

		// Token: 0x0400EFB7 RID: 61367
		internal static byte __PropertyMask_bOverride_KuroNearSkyLightColorPC;

		// Token: 0x0400EFB8 RID: 61368
		internal static int __PropertyOffset_bOverride_KuroNearSkyLightDistancePC;

		// Token: 0x0400EFB9 RID: 61369
		internal static byte __PropertyMask_bOverride_KuroNearSkyLightDistancePC;

		// Token: 0x0400EFBA RID: 61370
		internal static int __PropertyOffset_bOverride_KuroUseSeperateMobileNearSkyLight;

		// Token: 0x0400EFBB RID: 61371
		internal static byte __PropertyMask_bOverride_KuroUseSeperateMobileNearSkyLight;

		// Token: 0x0400EFBC RID: 61372
		internal static int __PropertyOffset_bOverride_KuroNearSkyLightColorMobile;

		// Token: 0x0400EFBD RID: 61373
		internal static byte __PropertyMask_bOverride_KuroNearSkyLightColorMobile;

		// Token: 0x0400EFBE RID: 61374
		internal static int __PropertyOffset_bOverride_KuroNearSkyLightDistanceMobile;

		// Token: 0x0400EFBF RID: 61375
		internal static byte __PropertyMask_bOverride_KuroNearSkyLightDistanceMobile;

		// Token: 0x0400EFC0 RID: 61376
		internal static int __PropertyOffset_bOverride_KuroMetalCubeMapBoost_MetallicStart;

		// Token: 0x0400EFC1 RID: 61377
		internal static byte __PropertyMask_bOverride_KuroMetalCubeMapBoost_MetallicStart;

		// Token: 0x0400EFC2 RID: 61378
		internal static int __PropertyOffset_bOverride_KuroMetalCubeMapBoost_RoughnessMul;

		// Token: 0x0400EFC3 RID: 61379
		internal static byte __PropertyMask_bOverride_KuroMetalCubeMapBoost_RoughnessMul;

		// Token: 0x0400EFC4 RID: 61380
		internal static int __PropertyOffset_bOverride_AOColor;

		// Token: 0x0400EFC5 RID: 61381
		internal static byte __PropertyMask_bOverride_AOColor;

		// Token: 0x0400EFC6 RID: 61382
		internal static int __PropertyOffset_bOverride_SkyLightShadowIntSupplement;

		// Token: 0x0400EFC7 RID: 61383
		internal static byte __PropertyMask_bOverride_SkyLightShadowIntSupplement;

		// Token: 0x0400EFC8 RID: 61384
		internal static int __PropertyOffset_bOverride_SkyLightShadowIntSupplementDistance;

		// Token: 0x0400EFC9 RID: 61385
		internal static byte __PropertyMask_bOverride_SkyLightShadowIntSupplementDistance;

		// Token: 0x0400EFCA RID: 61386
		internal static int __PropertyOffset_SkyLightColor;

		// Token: 0x0400EFCB RID: 61387
		internal static int __PropertyOffset_MobileSkyLightColorSaturation;

		// Token: 0x0400EFCC RID: 61388
		internal static int __PropertyOffset_MobileSkyLightValueMut;

		// Token: 0x0400EFCD RID: 61389
		internal static int __PropertyOffset_SkyLightIntensity;

		// Token: 0x0400EFCE RID: 61390
		internal static int __PropertyOffset_SkyLightSpecularIntensity;

		// Token: 0x0400EFCF RID: 61391
		internal static int __PropertyOffset_MobileSkyLightSpecularIntensityValueMut;

		// Token: 0x0400EFD0 RID: 61392
		internal static int __PropertyOffset_KuroSkyLightTranslucent;

		// Token: 0x0400EFD1 RID: 61393
		internal static int __PropertyOffset_KuroInteriorSkyLightIntensity;

		// Token: 0x0400EFD2 RID: 61394
		internal static int __PropertyOffset_KuroInteriorSkyLightColor;

		// Token: 0x0400EFD3 RID: 61395
		internal static int __PropertyOffset_KuroNearSkyLightColorPC;

		// Token: 0x0400EFD4 RID: 61396
		internal static int __PropertyOffset_KuroNearSkyLightDistancePC;

		// Token: 0x0400EFD5 RID: 61397
		internal static int __PropertyOffset_KuroUseSeperateMobileNearSkyLight;

		// Token: 0x0400EFD6 RID: 61398
		internal static int __PropertyOffset_KuroNearSkyLightColorMobile;

		// Token: 0x0400EFD7 RID: 61399
		internal static int __PropertyOffset_KuroNearSkyLightDistanceMobile;

		// Token: 0x0400EFD8 RID: 61400
		internal static int __PropertyOffset_KuroMetalCubeMapBoost_MetallicStart;

		// Token: 0x0400EFD9 RID: 61401
		internal static int __PropertyOffset_KuroMetalCubeMapBoost_RoughnessMul;

		// Token: 0x0400EFDA RID: 61402
		internal static int __PropertyOffset_AOColor;

		// Token: 0x0400EFDB RID: 61403
		internal static int __PropertyOffset_KuroSkyLightCubemap;

		// Token: 0x0400EFDC RID: 61404
		internal static int __PropertyOffset_KuroSkyLightSH1;

		// Token: 0x0400EFDD RID: 61405
		internal static int __PropertyOffset_KuroSkyLightSH2;

		// Token: 0x0400EFDE RID: 61406
		internal static int __PropertyOffset_KuroSkyLightSH3;

		// Token: 0x0400EFDF RID: 61407
		internal static int __PropertyOffset_KuroSkyLightSH4;

		// Token: 0x0400EFE0 RID: 61408
		internal static int __PropertyOffset_KuroSkyLightSH5;

		// Token: 0x0400EFE1 RID: 61409
		internal static int __PropertyOffset_KuroSkyLightSH6;

		// Token: 0x0400EFE2 RID: 61410
		internal static int __PropertyOffset_bUseGradientColorTint;

		// Token: 0x0400EFE3 RID: 61411
		internal static int __PropertyOffset_SkyColor;

		// Token: 0x0400EFE4 RID: 61412
		internal static int __PropertyOffset_GroudColor;

		// Token: 0x0400EFE5 RID: 61413
		internal static int __PropertyOffset_SkyLightShadowIntSupplement;

		// Token: 0x0400EFE6 RID: 61414
		internal static int __PropertyOffset_SkyLightShadowIntSupplementDistance;
	}
}
