using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001BBE RID: 7102
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroSkyVolumetricCloudSetting")]
	[UnrealStructLayout(328, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 328)]
	public class FKuroSkyVolumetricCloudSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601B384 RID: 111492 RVA: 0x00281C42 File Offset: 0x0027FE42
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroSkyVolumetricCloudSetting._ScriptStructPtr != 0) ? FKuroSkyVolumetricCloudSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroSkyVolumetricCloudSetting", ref FKuroSkyVolumetricCloudSetting._ScriptStructPtr);
		}

		// Token: 0x17006D44 RID: 27972
		// (get) Token: 0x0601B385 RID: 111493 RVA: 0x00281C66 File Offset: 0x0027FE66
		// (set) Token: 0x0601B386 RID: 111494 RVA: 0x00281C7F File Offset: 0x0027FE7F
		public unsafe bool bOverride_SkyVolumetricCloudMaterialPC
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudMaterialPC) & FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudMaterialPC) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudMaterialPC) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudMaterialPC) & ~FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudMaterialPC) | (value ? FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudMaterialPC : 0));
			}
		}

		// Token: 0x17006D45 RID: 27973
		// (get) Token: 0x0601B387 RID: 111495 RVA: 0x00281CAF File Offset: 0x0027FEAF
		// (set) Token: 0x0601B388 RID: 111496 RVA: 0x00281CC8 File Offset: 0x0027FEC8
		public unsafe bool bOverride_SkyVolumetricCloudMaterialMobile
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudMaterialMobile) & FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudMaterialMobile) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudMaterialMobile) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudMaterialMobile) & ~FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudMaterialMobile) | (value ? FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudMaterialMobile : 0));
			}
		}

		// Token: 0x17006D46 RID: 27974
		// (get) Token: 0x0601B389 RID: 111497 RVA: 0x00281CF8 File Offset: 0x0027FEF8
		// (set) Token: 0x0601B38A RID: 111498 RVA: 0x00281D11 File Offset: 0x0027FF11
		public unsafe bool bOverride_SkyVolumetricCloudLightingColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudLightingColor) & FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudLightingColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudLightingColor) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudLightingColor) & ~FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudLightingColor) | (value ? FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudLightingColor : 0));
			}
		}

		// Token: 0x17006D47 RID: 27975
		// (get) Token: 0x0601B38B RID: 111499 RVA: 0x00281D41 File Offset: 0x0027FF41
		// (set) Token: 0x0601B38C RID: 111500 RVA: 0x00281D5A File Offset: 0x0027FF5A
		public unsafe bool bOverride_SkyVolumetricCloudShadowColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudShadowColor) & FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudShadowColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudShadowColor) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudShadowColor) & ~FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudShadowColor) | (value ? FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudShadowColor : 0));
			}
		}

		// Token: 0x17006D48 RID: 27976
		// (get) Token: 0x0601B38D RID: 111501 RVA: 0x00281D8A File Offset: 0x0027FF8A
		// (set) Token: 0x0601B38E RID: 111502 RVA: 0x00281DA3 File Offset: 0x0027FFA3
		public unsafe bool bOverride_SkyVolumetricCloudCustomLightingIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudCustomLightingIntensity) & FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudCustomLightingIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudCustomLightingIntensity) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudCustomLightingIntensity) & ~FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudCustomLightingIntensity) | (value ? FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudCustomLightingIntensity : 0));
			}
		}

		// Token: 0x17006D49 RID: 27977
		// (get) Token: 0x0601B38F RID: 111503 RVA: 0x00281DD3 File Offset: 0x0027FFD3
		// (set) Token: 0x0601B390 RID: 111504 RVA: 0x00281DEC File Offset: 0x0027FFEC
		public unsafe bool bOverride_SkyVolumetricCloudLayerCoverage
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudLayerCoverage) & FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudLayerCoverage) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudLayerCoverage) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudLayerCoverage) & ~FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudLayerCoverage) | (value ? FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudLayerCoverage : 0));
			}
		}

		// Token: 0x17006D4A RID: 27978
		// (get) Token: 0x0601B391 RID: 111505 RVA: 0x00281E1C File Offset: 0x0028001C
		// (set) Token: 0x0601B392 RID: 111506 RVA: 0x00281E35 File Offset: 0x00280035
		public unsafe bool bOverride_SkyVolumetricCloudLayerHeight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudLayerHeight) & FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudLayerHeight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudLayerHeight) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudLayerHeight) & ~FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudLayerHeight) | (value ? FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudLayerHeight : 0));
			}
		}

		// Token: 0x17006D4B RID: 27979
		// (get) Token: 0x0601B393 RID: 111507 RVA: 0x00281E65 File Offset: 0x00280065
		// (set) Token: 0x0601B394 RID: 111508 RVA: 0x00281E7E File Offset: 0x0028007E
		public unsafe bool bOverride_SkyVolumetricCloudLayerThickness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudLayerThickness) & FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudLayerThickness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudLayerThickness) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudLayerThickness) & ~FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudLayerThickness) | (value ? FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudLayerThickness : 0));
			}
		}

		// Token: 0x17006D4C RID: 27980
		// (get) Token: 0x0601B395 RID: 111509 RVA: 0x00281EAE File Offset: 0x002800AE
		// (set) Token: 0x0601B396 RID: 111510 RVA: 0x00281EC7 File Offset: 0x002800C7
		public unsafe bool bOverride_SkyVolumetricCloudSpeed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudSpeed) & FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudSpeed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudSpeed) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudSpeed) & ~FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudSpeed) | (value ? FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudSpeed : 0));
			}
		}

		// Token: 0x17006D4D RID: 27981
		// (get) Token: 0x0601B397 RID: 111511 RVA: 0x00281EF7 File Offset: 0x002800F7
		// (set) Token: 0x0601B398 RID: 111512 RVA: 0x00281F10 File Offset: 0x00280110
		public unsafe bool bOverride_SkyVolumetricCloudMainLightIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudMainLightIntensity) & FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudMainLightIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudMainLightIntensity) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudMainLightIntensity) & ~FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudMainLightIntensity) | (value ? FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudMainLightIntensity : 0));
			}
		}

		// Token: 0x17006D4E RID: 27982
		// (get) Token: 0x0601B399 RID: 111513 RVA: 0x00281F40 File Offset: 0x00280140
		// (set) Token: 0x0601B39A RID: 111514 RVA: 0x00281F59 File Offset: 0x00280159
		public unsafe bool bOverride_SkyVolumetricCloudSkyLightIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudSkyLightIntensity) & FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudSkyLightIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudSkyLightIntensity) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudSkyLightIntensity) & ~FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudSkyLightIntensity) | (value ? FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudSkyLightIntensity : 0));
			}
		}

		// Token: 0x17006D4F RID: 27983
		// (get) Token: 0x0601B39B RID: 111515 RVA: 0x00281F89 File Offset: 0x00280189
		// (set) Token: 0x0601B39C RID: 111516 RVA: 0x00281FA2 File Offset: 0x002801A2
		public unsafe bool bOverride_SkyVolumetricCloudDistanceToSampleMaxCountScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudDistanceToSampleMaxCountScale) & FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudDistanceToSampleMaxCountScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudDistanceToSampleMaxCountScale) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_SkyVolumetricCloudDistanceToSampleMaxCountScale) & ~FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudDistanceToSampleMaxCountScale) | (value ? FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_SkyVolumetricCloudDistanceToSampleMaxCountScale : 0));
			}
		}

		// Token: 0x17006D50 RID: 27984
		// (get) Token: 0x0601B39D RID: 111517 RVA: 0x00281FD2 File Offset: 0x002801D2
		// (set) Token: 0x0601B39E RID: 111518 RVA: 0x00281FEB File Offset: 0x002801EB
		public unsafe bool bOverride_TimeLerpStrength
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_TimeLerpStrength) & FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_TimeLerpStrength) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_TimeLerpStrength) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_TimeLerpStrength) & ~FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_TimeLerpStrength) | (value ? FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_TimeLerpStrength : 0));
			}
		}

		// Token: 0x17006D51 RID: 27985
		// (get) Token: 0x0601B39F RID: 111519 RVA: 0x0028201B File Offset: 0x0028021B
		// (set) Token: 0x0601B3A0 RID: 111520 RVA: 0x00282034 File Offset: 0x00280234
		public unsafe bool bOverride_bEnableThunder
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_bEnableThunder) & FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_bEnableThunder) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_bEnableThunder) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_bEnableThunder) & ~FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_bEnableThunder) | (value ? FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_bEnableThunder : 0));
			}
		}

		// Token: 0x17006D52 RID: 27986
		// (get) Token: 0x0601B3A1 RID: 111521 RVA: 0x00282064 File Offset: 0x00280264
		// (set) Token: 0x0601B3A2 RID: 111522 RVA: 0x0028207D File Offset: 0x0028027D
		public unsafe bool bOverride_ThunderColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_ThunderColor) & FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_ThunderColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_ThunderColor) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_ThunderColor) & ~FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_ThunderColor) | (value ? FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_ThunderColor : 0));
			}
		}

		// Token: 0x17006D53 RID: 27987
		// (get) Token: 0x0601B3A3 RID: 111523 RVA: 0x002820AD File Offset: 0x002802AD
		// (set) Token: 0x0601B3A4 RID: 111524 RVA: 0x002820C6 File Offset: 0x002802C6
		public unsafe bool bOverride_ThunderTriggerIntervalMin
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_ThunderTriggerIntervalMin) & FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_ThunderTriggerIntervalMin) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_ThunderTriggerIntervalMin) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_ThunderTriggerIntervalMin) & ~FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_ThunderTriggerIntervalMin) | (value ? FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_ThunderTriggerIntervalMin : 0));
			}
		}

		// Token: 0x17006D54 RID: 27988
		// (get) Token: 0x0601B3A5 RID: 111525 RVA: 0x002820F6 File Offset: 0x002802F6
		// (set) Token: 0x0601B3A6 RID: 111526 RVA: 0x0028210F File Offset: 0x0028030F
		public unsafe bool bOverride_ThunderTriggerIntervalMax
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_ThunderTriggerIntervalMax) & FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_ThunderTriggerIntervalMax) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_ThunderTriggerIntervalMax) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_ThunderTriggerIntervalMax) & ~FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_ThunderTriggerIntervalMax) | (value ? FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_ThunderTriggerIntervalMax : 0));
			}
		}

		// Token: 0x17006D55 RID: 27989
		// (get) Token: 0x0601B3A7 RID: 111527 RVA: 0x0028213F File Offset: 0x0028033F
		// (set) Token: 0x0601B3A8 RID: 111528 RVA: 0x00282158 File Offset: 0x00280358
		public unsafe bool bOverride_ThunderAreaRange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_ThunderAreaRange) & FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_ThunderAreaRange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_ThunderAreaRange) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_ThunderAreaRange) & ~FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_ThunderAreaRange) | (value ? FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_ThunderAreaRange : 0));
			}
		}

		// Token: 0x17006D56 RID: 27990
		// (get) Token: 0x0601B3A9 RID: 111529 RVA: 0x00282188 File Offset: 0x00280388
		// (set) Token: 0x0601B3AA RID: 111530 RVA: 0x002821A1 File Offset: 0x002803A1
		public unsafe bool bOverride_ThunderAreaCenter
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_ThunderAreaCenter) & FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_ThunderAreaCenter) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_ThunderAreaCenter) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_ThunderAreaCenter) & ~FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_ThunderAreaCenter) | (value ? FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_ThunderAreaCenter : 0));
			}
		}

		// Token: 0x17006D57 RID: 27991
		// (get) Token: 0x0601B3AB RID: 111531 RVA: 0x002821D1 File Offset: 0x002803D1
		// (set) Token: 0x0601B3AC RID: 111532 RVA: 0x002821EA File Offset: 0x002803EA
		public unsafe bool bOverride_bUseCameraAsThunderAreaCenter
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_bUseCameraAsThunderAreaCenter) & FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_bUseCameraAsThunderAreaCenter) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_bUseCameraAsThunderAreaCenter) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_bUseCameraAsThunderAreaCenter) & ~FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_bUseCameraAsThunderAreaCenter) | (value ? FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_bUseCameraAsThunderAreaCenter : 0));
			}
		}

		// Token: 0x17006D58 RID: 27992
		// (get) Token: 0x0601B3AD RID: 111533 RVA: 0x0028221A File Offset: 0x0028041A
		// (set) Token: 0x0601B3AE RID: 111534 RVA: 0x00282233 File Offset: 0x00280433
		public unsafe bool bOverride_CameraAreaForwardOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_CameraAreaForwardOffset) & FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_CameraAreaForwardOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_CameraAreaForwardOffset) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bOverride_CameraAreaForwardOffset) & ~FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_CameraAreaForwardOffset) | (value ? FKuroSkyVolumetricCloudSetting.__PropertyMask_bOverride_CameraAreaForwardOffset : 0));
			}
		}

		// Token: 0x17006D59 RID: 27993
		// (get) Token: 0x0601B3AF RID: 111535 RVA: 0x00282263 File Offset: 0x00280463
		// (set) Token: 0x0601B3B0 RID: 111536 RVA: 0x00282277 File Offset: 0x00280477
		public unsafe UMaterialInterface SkyVolumetricCloudMaterialPC
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudMaterialPC);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudMaterialPC, value);
			}
		}

		// Token: 0x17006D5A RID: 27994
		// (get) Token: 0x0601B3B1 RID: 111537 RVA: 0x0028228C File Offset: 0x0028048C
		// (set) Token: 0x0601B3B2 RID: 111538 RVA: 0x002822A0 File Offset: 0x002804A0
		public unsafe UMaterialInterface SkyVolumetricCloudMaterialMobile
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMaterialInterface>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudMaterialMobile);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudMaterialMobile, value);
			}
		}

		// Token: 0x17006D5B RID: 27995
		// (get) Token: 0x0601B3B3 RID: 111539 RVA: 0x002822B5 File Offset: 0x002804B5
		// (set) Token: 0x0601B3B4 RID: 111540 RVA: 0x002822C9 File Offset: 0x002804C9
		public unsafe FLinearColor SkyVolumetricCloudLightingColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudLightingColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudLightingColor) = value;
			}
		}

		// Token: 0x17006D5C RID: 27996
		// (get) Token: 0x0601B3B5 RID: 111541 RVA: 0x002822DE File Offset: 0x002804DE
		// (set) Token: 0x0601B3B6 RID: 111542 RVA: 0x002822F2 File Offset: 0x002804F2
		public unsafe FLinearColor SkyVolumetricCloudShadowColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudShadowColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudShadowColor) = value;
			}
		}

		// Token: 0x17006D5D RID: 27997
		// (get) Token: 0x0601B3B7 RID: 111543 RVA: 0x00282307 File Offset: 0x00280507
		// (set) Token: 0x0601B3B8 RID: 111544 RVA: 0x00282317 File Offset: 0x00280517
		public unsafe float SkyVolumetricCloudCustomLightingIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudCustomLightingIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudCustomLightingIntensity) = value;
			}
		}

		// Token: 0x17006D5E RID: 27998
		// (get) Token: 0x0601B3B9 RID: 111545 RVA: 0x00282328 File Offset: 0x00280528
		// (set) Token: 0x0601B3BA RID: 111546 RVA: 0x00282338 File Offset: 0x00280538
		public unsafe float SkyVolumetricCloudLayerCoverage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudLayerCoverage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudLayerCoverage) = value;
			}
		}

		// Token: 0x17006D5F RID: 27999
		// (get) Token: 0x0601B3BB RID: 111547 RVA: 0x00282349 File Offset: 0x00280549
		// (set) Token: 0x0601B3BC RID: 111548 RVA: 0x00282359 File Offset: 0x00280559
		public unsafe float SkyVolumetricCloudLayerHeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudLayerHeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudLayerHeight) = value;
			}
		}

		// Token: 0x17006D60 RID: 28000
		// (get) Token: 0x0601B3BD RID: 111549 RVA: 0x0028236A File Offset: 0x0028056A
		// (set) Token: 0x0601B3BE RID: 111550 RVA: 0x0028237A File Offset: 0x0028057A
		public unsafe float SkyVolumetricCloudLayerThickness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudLayerThickness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudLayerThickness) = value;
			}
		}

		// Token: 0x17006D61 RID: 28001
		// (get) Token: 0x0601B3BF RID: 111551 RVA: 0x0028238B File Offset: 0x0028058B
		// (set) Token: 0x0601B3C0 RID: 111552 RVA: 0x0028239F File Offset: 0x0028059F
		public unsafe FVector2D SkyVolumetricCloudSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudSpeed) = value;
			}
		}

		// Token: 0x17006D62 RID: 28002
		// (get) Token: 0x0601B3C1 RID: 111553 RVA: 0x002823B4 File Offset: 0x002805B4
		// (set) Token: 0x0601B3C2 RID: 111554 RVA: 0x002823C4 File Offset: 0x002805C4
		public unsafe float SkyVolumetricCloudMainLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudMainLightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudMainLightIntensity) = value;
			}
		}

		// Token: 0x17006D63 RID: 28003
		// (get) Token: 0x0601B3C3 RID: 111555 RVA: 0x002823D5 File Offset: 0x002805D5
		// (set) Token: 0x0601B3C4 RID: 111556 RVA: 0x002823E5 File Offset: 0x002805E5
		public unsafe float SkyVolumetricCloudSkyLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudSkyLightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudSkyLightIntensity) = value;
			}
		}

		// Token: 0x17006D64 RID: 28004
		// (get) Token: 0x0601B3C5 RID: 111557 RVA: 0x002823F6 File Offset: 0x002805F6
		// (set) Token: 0x0601B3C6 RID: 111558 RVA: 0x00282406 File Offset: 0x00280606
		public unsafe float SkyVolumetricCloudDistanceToSampleMaxCountScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudDistanceToSampleMaxCountScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudDistanceToSampleMaxCountScale) = value;
			}
		}

		// Token: 0x17006D65 RID: 28005
		// (get) Token: 0x0601B3C7 RID: 111559 RVA: 0x00282417 File Offset: 0x00280617
		// (set) Token: 0x0601B3C8 RID: 111560 RVA: 0x00282427 File Offset: 0x00280627
		public unsafe float TimeLerpStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_TimeLerpStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_TimeLerpStrength) = value;
			}
		}

		// Token: 0x17006D66 RID: 28006
		// (get) Token: 0x0601B3C9 RID: 111561 RVA: 0x00282438 File Offset: 0x00280638
		// (set) Token: 0x0601B3CA RID: 111562 RVA: 0x0028247B File Offset: 0x0028067B
		[Nullable(1)]
		public FKuroSkyVolumetricCloudMPCParams SkyVolumetricCloudExtendedMPCEntry
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroSkyVolumetricCloudMPCParams result;
				if ((result = this._SkyVolumetricCloudExtendedMPCEntry) == null)
				{
					result = (this._SkyVolumetricCloudExtendedMPCEntry = new FKuroSkyVolumetricCloudMPCParams(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudExtendedMPCEntry, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroSkyVolumetricCloudMPCParams.StaticStruct(), base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_SkyVolumetricCloudExtendedMPCEntry, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17006D67 RID: 28007
		// (get) Token: 0x0601B3CB RID: 111563 RVA: 0x0028249C File Offset: 0x0028069C
		// (set) Token: 0x0601B3CC RID: 111564 RVA: 0x002824B5 File Offset: 0x002806B5
		public unsafe bool bEnableThunder
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bEnableThunder) & FKuroSkyVolumetricCloudSetting.__PropertyMask_bEnableThunder) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bEnableThunder) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bEnableThunder) & ~FKuroSkyVolumetricCloudSetting.__PropertyMask_bEnableThunder) | (value ? FKuroSkyVolumetricCloudSetting.__PropertyMask_bEnableThunder : 0));
			}
		}

		// Token: 0x17006D68 RID: 28008
		// (get) Token: 0x0601B3CD RID: 111565 RVA: 0x002824E5 File Offset: 0x002806E5
		// (set) Token: 0x0601B3CE RID: 111566 RVA: 0x002824F9 File Offset: 0x002806F9
		public unsafe FLinearColor ThunderColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_ThunderColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_ThunderColor) = value;
			}
		}

		// Token: 0x17006D69 RID: 28009
		// (get) Token: 0x0601B3CF RID: 111567 RVA: 0x0028250E File Offset: 0x0028070E
		// (set) Token: 0x0601B3D0 RID: 111568 RVA: 0x0028251E File Offset: 0x0028071E
		public unsafe float ThunderTriggerIntervalMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_ThunderTriggerIntervalMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_ThunderTriggerIntervalMin) = value;
			}
		}

		// Token: 0x17006D6A RID: 28010
		// (get) Token: 0x0601B3D1 RID: 111569 RVA: 0x0028252F File Offset: 0x0028072F
		// (set) Token: 0x0601B3D2 RID: 111570 RVA: 0x0028253F File Offset: 0x0028073F
		public unsafe float ThunderTriggerIntervalMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_ThunderTriggerIntervalMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_ThunderTriggerIntervalMax) = value;
			}
		}

		// Token: 0x17006D6B RID: 28011
		// (get) Token: 0x0601B3D3 RID: 111571 RVA: 0x00282550 File Offset: 0x00280750
		// (set) Token: 0x0601B3D4 RID: 111572 RVA: 0x00282564 File Offset: 0x00280764
		public unsafe FVector2D ThunderAreaRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_ThunderAreaRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_ThunderAreaRange) = value;
			}
		}

		// Token: 0x17006D6C RID: 28012
		// (get) Token: 0x0601B3D5 RID: 111573 RVA: 0x00282579 File Offset: 0x00280779
		// (set) Token: 0x0601B3D6 RID: 111574 RVA: 0x0028258D File Offset: 0x0028078D
		public unsafe FVector ThunderAreaCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_ThunderAreaCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_ThunderAreaCenter) = value;
			}
		}

		// Token: 0x17006D6D RID: 28013
		// (get) Token: 0x0601B3D7 RID: 111575 RVA: 0x002825A2 File Offset: 0x002807A2
		// (set) Token: 0x0601B3D8 RID: 111576 RVA: 0x002825BB File Offset: 0x002807BB
		public unsafe bool bUseCameraAsThunderAreaCenter
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bUseCameraAsThunderAreaCenter) & FKuroSkyVolumetricCloudSetting.__PropertyMask_bUseCameraAsThunderAreaCenter) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bUseCameraAsThunderAreaCenter) = ((*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_bUseCameraAsThunderAreaCenter) & ~FKuroSkyVolumetricCloudSetting.__PropertyMask_bUseCameraAsThunderAreaCenter) | (value ? FKuroSkyVolumetricCloudSetting.__PropertyMask_bUseCameraAsThunderAreaCenter : 0));
			}
		}

		// Token: 0x17006D6E RID: 28014
		// (get) Token: 0x0601B3D9 RID: 111577 RVA: 0x002825EB File Offset: 0x002807EB
		// (set) Token: 0x0601B3DA RID: 111578 RVA: 0x002825FB File Offset: 0x002807FB
		public unsafe float CameraAreaForwardOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_CameraAreaForwardOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroSkyVolumetricCloudSetting.__PropertyOffset_CameraAreaForwardOffset) = value;
			}
		}

		// Token: 0x0601B3DB RID: 111579 RVA: 0x0028260C File Offset: 0x0028080C
		public FKuroSkyVolumetricCloudSetting()
		{
		}

		// Token: 0x0601B3DC RID: 111580 RVA: 0x00282614 File Offset: 0x00280814
		[NullableContext(1)]
		public FKuroSkyVolumetricCloudSetting(bool bOverride_SkyVolumetricCloudMaterialPC, bool bOverride_SkyVolumetricCloudMaterialMobile, bool bOverride_SkyVolumetricCloudLightingColor, bool bOverride_SkyVolumetricCloudShadowColor, bool bOverride_SkyVolumetricCloudCustomLightingIntensity, bool bOverride_SkyVolumetricCloudLayerCoverage, bool bOverride_SkyVolumetricCloudLayerHeight, bool bOverride_SkyVolumetricCloudLayerThickness, bool bOverride_SkyVolumetricCloudSpeed, bool bOverride_SkyVolumetricCloudMainLightIntensity, bool bOverride_SkyVolumetricCloudSkyLightIntensity, bool bOverride_SkyVolumetricCloudDistanceToSampleMaxCountScale, bool bOverride_TimeLerpStrength, bool bOverride_bEnableThunder, bool bOverride_ThunderColor, bool bOverride_ThunderTriggerIntervalMin, bool bOverride_ThunderTriggerIntervalMax, bool bOverride_ThunderAreaRange, bool bOverride_ThunderAreaCenter, bool bOverride_bUseCameraAsThunderAreaCenter, bool bOverride_CameraAreaForwardOffset, UMaterialInterface SkyVolumetricCloudMaterialPC, UMaterialInterface SkyVolumetricCloudMaterialMobile, FLinearColor SkyVolumetricCloudLightingColor, FLinearColor SkyVolumetricCloudShadowColor, float SkyVolumetricCloudCustomLightingIntensity, float SkyVolumetricCloudLayerCoverage, float SkyVolumetricCloudLayerHeight, float SkyVolumetricCloudLayerThickness, FVector2D SkyVolumetricCloudSpeed, float SkyVolumetricCloudMainLightIntensity, float SkyVolumetricCloudSkyLightIntensity, float SkyVolumetricCloudDistanceToSampleMaxCountScale, float TimeLerpStrength, FKuroSkyVolumetricCloudMPCParams SkyVolumetricCloudExtendedMPCEntry, bool bEnableThunder, FLinearColor ThunderColor, float ThunderTriggerIntervalMin, float ThunderTriggerIntervalMax, FVector2D ThunderAreaRange, FVector ThunderAreaCenter, bool bUseCameraAsThunderAreaCenter, float CameraAreaForwardOffset)
		{
			this.bOverride_SkyVolumetricCloudMaterialPC = bOverride_SkyVolumetricCloudMaterialPC;
			this.bOverride_SkyVolumetricCloudMaterialMobile = bOverride_SkyVolumetricCloudMaterialMobile;
			this.bOverride_SkyVolumetricCloudLightingColor = bOverride_SkyVolumetricCloudLightingColor;
			this.bOverride_SkyVolumetricCloudShadowColor = bOverride_SkyVolumetricCloudShadowColor;
			this.bOverride_SkyVolumetricCloudCustomLightingIntensity = bOverride_SkyVolumetricCloudCustomLightingIntensity;
			this.bOverride_SkyVolumetricCloudLayerCoverage = bOverride_SkyVolumetricCloudLayerCoverage;
			this.bOverride_SkyVolumetricCloudLayerHeight = bOverride_SkyVolumetricCloudLayerHeight;
			this.bOverride_SkyVolumetricCloudLayerThickness = bOverride_SkyVolumetricCloudLayerThickness;
			this.bOverride_SkyVolumetricCloudSpeed = bOverride_SkyVolumetricCloudSpeed;
			this.bOverride_SkyVolumetricCloudMainLightIntensity = bOverride_SkyVolumetricCloudMainLightIntensity;
			this.bOverride_SkyVolumetricCloudSkyLightIntensity = bOverride_SkyVolumetricCloudSkyLightIntensity;
			this.bOverride_SkyVolumetricCloudDistanceToSampleMaxCountScale = bOverride_SkyVolumetricCloudDistanceToSampleMaxCountScale;
			this.bOverride_TimeLerpStrength = bOverride_TimeLerpStrength;
			this.bOverride_bEnableThunder = bOverride_bEnableThunder;
			this.bOverride_ThunderColor = bOverride_ThunderColor;
			this.bOverride_ThunderTriggerIntervalMin = bOverride_ThunderTriggerIntervalMin;
			this.bOverride_ThunderTriggerIntervalMax = bOverride_ThunderTriggerIntervalMax;
			this.bOverride_ThunderAreaRange = bOverride_ThunderAreaRange;
			this.bOverride_ThunderAreaCenter = bOverride_ThunderAreaCenter;
			this.bOverride_bUseCameraAsThunderAreaCenter = bOverride_bUseCameraAsThunderAreaCenter;
			this.bOverride_CameraAreaForwardOffset = bOverride_CameraAreaForwardOffset;
			this.SkyVolumetricCloudMaterialPC = SkyVolumetricCloudMaterialPC;
			this.SkyVolumetricCloudMaterialMobile = SkyVolumetricCloudMaterialMobile;
			this.SkyVolumetricCloudLightingColor = SkyVolumetricCloudLightingColor;
			this.SkyVolumetricCloudShadowColor = SkyVolumetricCloudShadowColor;
			this.SkyVolumetricCloudCustomLightingIntensity = SkyVolumetricCloudCustomLightingIntensity;
			this.SkyVolumetricCloudLayerCoverage = SkyVolumetricCloudLayerCoverage;
			this.SkyVolumetricCloudLayerHeight = SkyVolumetricCloudLayerHeight;
			this.SkyVolumetricCloudLayerThickness = SkyVolumetricCloudLayerThickness;
			this.SkyVolumetricCloudSpeed = SkyVolumetricCloudSpeed;
			this.SkyVolumetricCloudMainLightIntensity = SkyVolumetricCloudMainLightIntensity;
			this.SkyVolumetricCloudSkyLightIntensity = SkyVolumetricCloudSkyLightIntensity;
			this.SkyVolumetricCloudDistanceToSampleMaxCountScale = SkyVolumetricCloudDistanceToSampleMaxCountScale;
			this.TimeLerpStrength = TimeLerpStrength;
			this.SkyVolumetricCloudExtendedMPCEntry = SkyVolumetricCloudExtendedMPCEntry;
			this.bEnableThunder = bEnableThunder;
			this.ThunderColor = ThunderColor;
			this.ThunderTriggerIntervalMin = ThunderTriggerIntervalMin;
			this.ThunderTriggerIntervalMax = ThunderTriggerIntervalMax;
			this.ThunderAreaRange = ThunderAreaRange;
			this.ThunderAreaCenter = ThunderAreaCenter;
			this.bUseCameraAsThunderAreaCenter = bUseCameraAsThunderAreaCenter;
			this.CameraAreaForwardOffset = CameraAreaForwardOffset;
		}

		// Token: 0x0601B3DD RID: 111581 RVA: 0x0028277C File Offset: 0x0028097C
		protected override IntPtr GetUStructPtr()
		{
			return FKuroSkyVolumetricCloudSetting.StaticStruct();
		}

		// Token: 0x0601B3DE RID: 111582 RVA: 0x00282788 File Offset: 0x00280988
		public FKuroSkyVolumetricCloudSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601B3DF RID: 111583 RVA: 0x00282792 File Offset: 0x00280992
		public FKuroSkyVolumetricCloudSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601B3E0 RID: 111584 RVA: 0x0028279D File Offset: 0x0028099D
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroSkyVolumetricCloudSetting(Pointer, false, true);
		}

		// Token: 0x0601B3E1 RID: 111585 RVA: 0x002827A7 File Offset: 0x002809A7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroSkyVolumetricCloudSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400EA8B RID: 60043
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroSkyVolumetricCloudSetting";

		// Token: 0x0400EA8C RID: 60044
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400EA8D RID: 60045
		internal static int __PropertyOffset_bOverride_SkyVolumetricCloudMaterialPC;

		// Token: 0x0400EA8E RID: 60046
		internal static byte __PropertyMask_bOverride_SkyVolumetricCloudMaterialPC;

		// Token: 0x0400EA8F RID: 60047
		internal static int __PropertyOffset_bOverride_SkyVolumetricCloudMaterialMobile;

		// Token: 0x0400EA90 RID: 60048
		internal static byte __PropertyMask_bOverride_SkyVolumetricCloudMaterialMobile;

		// Token: 0x0400EA91 RID: 60049
		internal static int __PropertyOffset_bOverride_SkyVolumetricCloudLightingColor;

		// Token: 0x0400EA92 RID: 60050
		internal static byte __PropertyMask_bOverride_SkyVolumetricCloudLightingColor;

		// Token: 0x0400EA93 RID: 60051
		internal static int __PropertyOffset_bOverride_SkyVolumetricCloudShadowColor;

		// Token: 0x0400EA94 RID: 60052
		internal static byte __PropertyMask_bOverride_SkyVolumetricCloudShadowColor;

		// Token: 0x0400EA95 RID: 60053
		internal static int __PropertyOffset_bOverride_SkyVolumetricCloudCustomLightingIntensity;

		// Token: 0x0400EA96 RID: 60054
		internal static byte __PropertyMask_bOverride_SkyVolumetricCloudCustomLightingIntensity;

		// Token: 0x0400EA97 RID: 60055
		internal static int __PropertyOffset_bOverride_SkyVolumetricCloudLayerCoverage;

		// Token: 0x0400EA98 RID: 60056
		internal static byte __PropertyMask_bOverride_SkyVolumetricCloudLayerCoverage;

		// Token: 0x0400EA99 RID: 60057
		internal static int __PropertyOffset_bOverride_SkyVolumetricCloudLayerHeight;

		// Token: 0x0400EA9A RID: 60058
		internal static byte __PropertyMask_bOverride_SkyVolumetricCloudLayerHeight;

		// Token: 0x0400EA9B RID: 60059
		internal static int __PropertyOffset_bOverride_SkyVolumetricCloudLayerThickness;

		// Token: 0x0400EA9C RID: 60060
		internal static byte __PropertyMask_bOverride_SkyVolumetricCloudLayerThickness;

		// Token: 0x0400EA9D RID: 60061
		internal static int __PropertyOffset_bOverride_SkyVolumetricCloudSpeed;

		// Token: 0x0400EA9E RID: 60062
		internal static byte __PropertyMask_bOverride_SkyVolumetricCloudSpeed;

		// Token: 0x0400EA9F RID: 60063
		internal static int __PropertyOffset_bOverride_SkyVolumetricCloudMainLightIntensity;

		// Token: 0x0400EAA0 RID: 60064
		internal static byte __PropertyMask_bOverride_SkyVolumetricCloudMainLightIntensity;

		// Token: 0x0400EAA1 RID: 60065
		internal static int __PropertyOffset_bOverride_SkyVolumetricCloudSkyLightIntensity;

		// Token: 0x0400EAA2 RID: 60066
		internal static byte __PropertyMask_bOverride_SkyVolumetricCloudSkyLightIntensity;

		// Token: 0x0400EAA3 RID: 60067
		internal static int __PropertyOffset_bOverride_SkyVolumetricCloudDistanceToSampleMaxCountScale;

		// Token: 0x0400EAA4 RID: 60068
		internal static byte __PropertyMask_bOverride_SkyVolumetricCloudDistanceToSampleMaxCountScale;

		// Token: 0x0400EAA5 RID: 60069
		internal static int __PropertyOffset_bOverride_TimeLerpStrength;

		// Token: 0x0400EAA6 RID: 60070
		internal static byte __PropertyMask_bOverride_TimeLerpStrength;

		// Token: 0x0400EAA7 RID: 60071
		internal static int __PropertyOffset_bOverride_bEnableThunder;

		// Token: 0x0400EAA8 RID: 60072
		internal static byte __PropertyMask_bOverride_bEnableThunder;

		// Token: 0x0400EAA9 RID: 60073
		internal static int __PropertyOffset_bOverride_ThunderColor;

		// Token: 0x0400EAAA RID: 60074
		internal static byte __PropertyMask_bOverride_ThunderColor;

		// Token: 0x0400EAAB RID: 60075
		internal static int __PropertyOffset_bOverride_ThunderTriggerIntervalMin;

		// Token: 0x0400EAAC RID: 60076
		internal static byte __PropertyMask_bOverride_ThunderTriggerIntervalMin;

		// Token: 0x0400EAAD RID: 60077
		internal static int __PropertyOffset_bOverride_ThunderTriggerIntervalMax;

		// Token: 0x0400EAAE RID: 60078
		internal static byte __PropertyMask_bOverride_ThunderTriggerIntervalMax;

		// Token: 0x0400EAAF RID: 60079
		internal static int __PropertyOffset_bOverride_ThunderAreaRange;

		// Token: 0x0400EAB0 RID: 60080
		internal static byte __PropertyMask_bOverride_ThunderAreaRange;

		// Token: 0x0400EAB1 RID: 60081
		internal static int __PropertyOffset_bOverride_ThunderAreaCenter;

		// Token: 0x0400EAB2 RID: 60082
		internal static byte __PropertyMask_bOverride_ThunderAreaCenter;

		// Token: 0x0400EAB3 RID: 60083
		internal static int __PropertyOffset_bOverride_bUseCameraAsThunderAreaCenter;

		// Token: 0x0400EAB4 RID: 60084
		internal static byte __PropertyMask_bOverride_bUseCameraAsThunderAreaCenter;

		// Token: 0x0400EAB5 RID: 60085
		internal static int __PropertyOffset_bOverride_CameraAreaForwardOffset;

		// Token: 0x0400EAB6 RID: 60086
		internal static byte __PropertyMask_bOverride_CameraAreaForwardOffset;

		// Token: 0x0400EAB7 RID: 60087
		internal static int __PropertyOffset_SkyVolumetricCloudMaterialPC;

		// Token: 0x0400EAB8 RID: 60088
		internal static int __PropertyOffset_SkyVolumetricCloudMaterialMobile;

		// Token: 0x0400EAB9 RID: 60089
		internal static int __PropertyOffset_SkyVolumetricCloudLightingColor;

		// Token: 0x0400EABA RID: 60090
		internal static int __PropertyOffset_SkyVolumetricCloudShadowColor;

		// Token: 0x0400EABB RID: 60091
		internal static int __PropertyOffset_SkyVolumetricCloudCustomLightingIntensity;

		// Token: 0x0400EABC RID: 60092
		internal static int __PropertyOffset_SkyVolumetricCloudLayerCoverage;

		// Token: 0x0400EABD RID: 60093
		internal static int __PropertyOffset_SkyVolumetricCloudLayerHeight;

		// Token: 0x0400EABE RID: 60094
		internal static int __PropertyOffset_SkyVolumetricCloudLayerThickness;

		// Token: 0x0400EABF RID: 60095
		internal static int __PropertyOffset_SkyVolumetricCloudSpeed;

		// Token: 0x0400EAC0 RID: 60096
		internal static int __PropertyOffset_SkyVolumetricCloudMainLightIntensity;

		// Token: 0x0400EAC1 RID: 60097
		internal static int __PropertyOffset_SkyVolumetricCloudSkyLightIntensity;

		// Token: 0x0400EAC2 RID: 60098
		internal static int __PropertyOffset_SkyVolumetricCloudDistanceToSampleMaxCountScale;

		// Token: 0x0400EAC3 RID: 60099
		internal static int __PropertyOffset_TimeLerpStrength;

		// Token: 0x0400EAC4 RID: 60100
		internal static int __PropertyOffset_SkyVolumetricCloudExtendedMPCEntry;

		// Token: 0x0400EAC5 RID: 60101
		private FKuroSkyVolumetricCloudMPCParams _SkyVolumetricCloudExtendedMPCEntry;

		// Token: 0x0400EAC6 RID: 60102
		internal static int __PropertyOffset_bEnableThunder;

		// Token: 0x0400EAC7 RID: 60103
		internal static byte __PropertyMask_bEnableThunder;

		// Token: 0x0400EAC8 RID: 60104
		internal static int __PropertyOffset_ThunderColor;

		// Token: 0x0400EAC9 RID: 60105
		internal static int __PropertyOffset_ThunderTriggerIntervalMin;

		// Token: 0x0400EACA RID: 60106
		internal static int __PropertyOffset_ThunderTriggerIntervalMax;

		// Token: 0x0400EACB RID: 60107
		internal static int __PropertyOffset_ThunderAreaRange;

		// Token: 0x0400EACC RID: 60108
		internal static int __PropertyOffset_ThunderAreaCenter;

		// Token: 0x0400EACD RID: 60109
		internal static int __PropertyOffset_bUseCameraAsThunderAreaCenter;

		// Token: 0x0400EACE RID: 60110
		internal static byte __PropertyMask_bUseCameraAsThunderAreaCenter;

		// Token: 0x0400EACF RID: 60111
		internal static int __PropertyOffset_CameraAreaForwardOffset;
	}
}
