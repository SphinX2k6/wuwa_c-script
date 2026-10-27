using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02001ACD RID: 6861
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCloudCardSetting")]
	[UnrealStructLayout(148, 4, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 148)]
	public class FKuroCloudCardSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060197F5 RID: 104437 RVA: 0x0025AC52 File Offset: 0x00258E52
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCloudCardSetting._ScriptStructPtr != 0) ? FKuroCloudCardSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroCloudCardSetting", ref FKuroCloudCardSetting._ScriptStructPtr);
		}

		// Token: 0x170065A6 RID: 26022
		// (get) Token: 0x060197F6 RID: 104438 RVA: 0x0025AC76 File Offset: 0x00258E76
		// (set) Token: 0x060197F7 RID: 104439 RVA: 0x0025AC8F File Offset: 0x00258E8F
		public unsafe bool bOverride_AtmoLightScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_AtmoLightScale) & FKuroCloudCardSetting.__PropertyMask_bOverride_AtmoLightScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_AtmoLightScale) = ((*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_AtmoLightScale) & ~FKuroCloudCardSetting.__PropertyMask_bOverride_AtmoLightScale) | (value ? FKuroCloudCardSetting.__PropertyMask_bOverride_AtmoLightScale : 0));
			}
		}

		// Token: 0x170065A7 RID: 26023
		// (get) Token: 0x060197F8 RID: 104440 RVA: 0x0025ACBF File Offset: 0x00258EBF
		// (set) Token: 0x060197F9 RID: 104441 RVA: 0x0025ACD8 File Offset: 0x00258ED8
		public unsafe bool bOverride_Contrast
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_Contrast) & FKuroCloudCardSetting.__PropertyMask_bOverride_Contrast) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_Contrast) = ((*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_Contrast) & ~FKuroCloudCardSetting.__PropertyMask_bOverride_Contrast) | (value ? FKuroCloudCardSetting.__PropertyMask_bOverride_Contrast : 0));
			}
		}

		// Token: 0x170065A8 RID: 26024
		// (get) Token: 0x060197FA RID: 104442 RVA: 0x0025AD08 File Offset: 0x00258F08
		// (set) Token: 0x060197FB RID: 104443 RVA: 0x0025AD21 File Offset: 0x00258F21
		public unsafe bool bOverride_FogColorAmount
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_FogColorAmount) & FKuroCloudCardSetting.__PropertyMask_bOverride_FogColorAmount) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_FogColorAmount) = ((*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_FogColorAmount) & ~FKuroCloudCardSetting.__PropertyMask_bOverride_FogColorAmount) | (value ? FKuroCloudCardSetting.__PropertyMask_bOverride_FogColorAmount : 0));
			}
		}

		// Token: 0x170065A9 RID: 26025
		// (get) Token: 0x060197FC RID: 104444 RVA: 0x0025AD51 File Offset: 0x00258F51
		// (set) Token: 0x060197FD RID: 104445 RVA: 0x0025AD6A File Offset: 0x00258F6A
		public unsafe bool bOverride_DarkBrightness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_DarkBrightness) & FKuroCloudCardSetting.__PropertyMask_bOverride_DarkBrightness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_DarkBrightness) = ((*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_DarkBrightness) & ~FKuroCloudCardSetting.__PropertyMask_bOverride_DarkBrightness) | (value ? FKuroCloudCardSetting.__PropertyMask_bOverride_DarkBrightness : 0));
			}
		}

		// Token: 0x170065AA RID: 26026
		// (get) Token: 0x060197FE RID: 104446 RVA: 0x0025AD9A File Offset: 0x00258F9A
		// (set) Token: 0x060197FF RID: 104447 RVA: 0x0025ADB3 File Offset: 0x00258FB3
		public unsafe bool bOverride_Exp
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_Exp) & FKuroCloudCardSetting.__PropertyMask_bOverride_Exp) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_Exp) = ((*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_Exp) & ~FKuroCloudCardSetting.__PropertyMask_bOverride_Exp) | (value ? FKuroCloudCardSetting.__PropertyMask_bOverride_Exp : 0));
			}
		}

		// Token: 0x170065AB RID: 26027
		// (get) Token: 0x06019800 RID: 104448 RVA: 0x0025ADE3 File Offset: 0x00258FE3
		// (set) Token: 0x06019801 RID: 104449 RVA: 0x0025ADFC File Offset: 0x00258FFC
		public unsafe bool bOverride_HorizonFalloff
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_HorizonFalloff) & FKuroCloudCardSetting.__PropertyMask_bOverride_HorizonFalloff) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_HorizonFalloff) = ((*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_HorizonFalloff) & ~FKuroCloudCardSetting.__PropertyMask_bOverride_HorizonFalloff) | (value ? FKuroCloudCardSetting.__PropertyMask_bOverride_HorizonFalloff : 0));
			}
		}

		// Token: 0x170065AC RID: 26028
		// (get) Token: 0x06019802 RID: 104450 RVA: 0x0025AE2C File Offset: 0x0025902C
		// (set) Token: 0x06019803 RID: 104451 RVA: 0x0025AE45 File Offset: 0x00259045
		public unsafe bool bOverride_HorizonMax
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_HorizonMax) & FKuroCloudCardSetting.__PropertyMask_bOverride_HorizonMax) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_HorizonMax) = ((*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_HorizonMax) & ~FKuroCloudCardSetting.__PropertyMask_bOverride_HorizonMax) | (value ? FKuroCloudCardSetting.__PropertyMask_bOverride_HorizonMax : 0));
			}
		}

		// Token: 0x170065AD RID: 26029
		// (get) Token: 0x06019804 RID: 104452 RVA: 0x0025AE75 File Offset: 0x00259075
		// (set) Token: 0x06019805 RID: 104453 RVA: 0x0025AE8E File Offset: 0x0025908E
		public unsafe bool bOverride_HorizonMin
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_HorizonMin) & FKuroCloudCardSetting.__PropertyMask_bOverride_HorizonMin) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_HorizonMin) = ((*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_HorizonMin) & ~FKuroCloudCardSetting.__PropertyMask_bOverride_HorizonMin) | (value ? FKuroCloudCardSetting.__PropertyMask_bOverride_HorizonMin : 0));
			}
		}

		// Token: 0x170065AE RID: 26030
		// (get) Token: 0x06019806 RID: 104454 RVA: 0x0025AEBE File Offset: 0x002590BE
		// (set) Token: 0x06019807 RID: 104455 RVA: 0x0025AED7 File Offset: 0x002590D7
		public unsafe bool bOverride_HorizonOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_HorizonOffset) & FKuroCloudCardSetting.__PropertyMask_bOverride_HorizonOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_HorizonOffset) = ((*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_HorizonOffset) & ~FKuroCloudCardSetting.__PropertyMask_bOverride_HorizonOffset) | (value ? FKuroCloudCardSetting.__PropertyMask_bOverride_HorizonOffset : 0));
			}
		}

		// Token: 0x170065AF RID: 26031
		// (get) Token: 0x06019808 RID: 104456 RVA: 0x0025AF07 File Offset: 0x00259107
		// (set) Token: 0x06019809 RID: 104457 RVA: 0x0025AF20 File Offset: 0x00259120
		public unsafe bool bOverride_LightBrightness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_LightBrightness) & FKuroCloudCardSetting.__PropertyMask_bOverride_LightBrightness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_LightBrightness) = ((*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_LightBrightness) & ~FKuroCloudCardSetting.__PropertyMask_bOverride_LightBrightness) | (value ? FKuroCloudCardSetting.__PropertyMask_bOverride_LightBrightness : 0));
			}
		}

		// Token: 0x170065B0 RID: 26032
		// (get) Token: 0x0601980A RID: 104458 RVA: 0x0025AF50 File Offset: 0x00259150
		// (set) Token: 0x0601980B RID: 104459 RVA: 0x0025AF69 File Offset: 0x00259169
		public unsafe bool bOverride_LitOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_LitOffset) & FKuroCloudCardSetting.__PropertyMask_bOverride_LitOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_LitOffset) = ((*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_LitOffset) & ~FKuroCloudCardSetting.__PropertyMask_bOverride_LitOffset) | (value ? FKuroCloudCardSetting.__PropertyMask_bOverride_LitOffset : 0));
			}
		}

		// Token: 0x170065B1 RID: 26033
		// (get) Token: 0x0601980C RID: 104460 RVA: 0x0025AF99 File Offset: 0x00259199
		// (set) Token: 0x0601980D RID: 104461 RVA: 0x0025AFB2 File Offset: 0x002591B2
		public unsafe bool bOverride_Translucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_Translucency) & FKuroCloudCardSetting.__PropertyMask_bOverride_Translucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_Translucency) = ((*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_Translucency) & ~FKuroCloudCardSetting.__PropertyMask_bOverride_Translucency) | (value ? FKuroCloudCardSetting.__PropertyMask_bOverride_Translucency : 0));
			}
		}

		// Token: 0x170065B2 RID: 26034
		// (get) Token: 0x0601980E RID: 104462 RVA: 0x0025AFE2 File Offset: 0x002591E2
		// (set) Token: 0x0601980F RID: 104463 RVA: 0x0025AFFB File Offset: 0x002591FB
		public unsafe bool bOverride_BaseColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_BaseColor) & FKuroCloudCardSetting.__PropertyMask_bOverride_BaseColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_BaseColor) = ((*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_BaseColor) & ~FKuroCloudCardSetting.__PropertyMask_bOverride_BaseColor) | (value ? FKuroCloudCardSetting.__PropertyMask_bOverride_BaseColor : 0));
			}
		}

		// Token: 0x170065B3 RID: 26035
		// (get) Token: 0x06019810 RID: 104464 RVA: 0x0025B02B File Offset: 0x0025922B
		// (set) Token: 0x06019811 RID: 104465 RVA: 0x0025B044 File Offset: 0x00259244
		public unsafe bool bOverride_DarkColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_DarkColor) & FKuroCloudCardSetting.__PropertyMask_bOverride_DarkColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_DarkColor) = ((*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_DarkColor) & ~FKuroCloudCardSetting.__PropertyMask_bOverride_DarkColor) | (value ? FKuroCloudCardSetting.__PropertyMask_bOverride_DarkColor : 0));
			}
		}

		// Token: 0x170065B4 RID: 26036
		// (get) Token: 0x06019812 RID: 104466 RVA: 0x0025B074 File Offset: 0x00259274
		// (set) Token: 0x06019813 RID: 104467 RVA: 0x0025B08D File Offset: 0x0025928D
		public unsafe bool bOverride_Emissive
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_Emissive) & FKuroCloudCardSetting.__PropertyMask_bOverride_Emissive) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_Emissive) = ((*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_Emissive) & ~FKuroCloudCardSetting.__PropertyMask_bOverride_Emissive) | (value ? FKuroCloudCardSetting.__PropertyMask_bOverride_Emissive : 0));
			}
		}

		// Token: 0x170065B5 RID: 26037
		// (get) Token: 0x06019814 RID: 104468 RVA: 0x0025B0BD File Offset: 0x002592BD
		// (set) Token: 0x06019815 RID: 104469 RVA: 0x0025B0D6 File Offset: 0x002592D6
		public unsafe bool bOverride_LightColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_LightColor) & FKuroCloudCardSetting.__PropertyMask_bOverride_LightColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_LightColor) = ((*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_LightColor) & ~FKuroCloudCardSetting.__PropertyMask_bOverride_LightColor) | (value ? FKuroCloudCardSetting.__PropertyMask_bOverride_LightColor : 0));
			}
		}

		// Token: 0x170065B6 RID: 26038
		// (get) Token: 0x06019816 RID: 104470 RVA: 0x0025B106 File Offset: 0x00259306
		// (set) Token: 0x06019817 RID: 104471 RVA: 0x0025B11F File Offset: 0x0025931F
		public unsafe bool bOverride_Offset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_Offset) & FKuroCloudCardSetting.__PropertyMask_bOverride_Offset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_Offset) = ((*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_Offset) & ~FKuroCloudCardSetting.__PropertyMask_bOverride_Offset) | (value ? FKuroCloudCardSetting.__PropertyMask_bOverride_Offset : 0));
			}
		}

		// Token: 0x170065B7 RID: 26039
		// (get) Token: 0x06019818 RID: 104472 RVA: 0x0025B14F File Offset: 0x0025934F
		// (set) Token: 0x06019819 RID: 104473 RVA: 0x0025B168 File Offset: 0x00259368
		public unsafe bool bOverride_BillboardCloudsNearFogDensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_BillboardCloudsNearFogDensity) & FKuroCloudCardSetting.__PropertyMask_bOverride_BillboardCloudsNearFogDensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_BillboardCloudsNearFogDensity) = ((*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_BillboardCloudsNearFogDensity) & ~FKuroCloudCardSetting.__PropertyMask_bOverride_BillboardCloudsNearFogDensity) | (value ? FKuroCloudCardSetting.__PropertyMask_bOverride_BillboardCloudsNearFogDensity : 0));
			}
		}

		// Token: 0x170065B8 RID: 26040
		// (get) Token: 0x0601981A RID: 104474 RVA: 0x0025B198 File Offset: 0x00259398
		// (set) Token: 0x0601981B RID: 104475 RVA: 0x0025B1B1 File Offset: 0x002593B1
		public unsafe bool bOverride_BillboardCloudsFarFogDensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_BillboardCloudsFarFogDensity) & FKuroCloudCardSetting.__PropertyMask_bOverride_BillboardCloudsFarFogDensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_BillboardCloudsFarFogDensity) = ((*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_BillboardCloudsFarFogDensity) & ~FKuroCloudCardSetting.__PropertyMask_bOverride_BillboardCloudsFarFogDensity) | (value ? FKuroCloudCardSetting.__PropertyMask_bOverride_BillboardCloudsFarFogDensity : 0));
			}
		}

		// Token: 0x170065B9 RID: 26041
		// (get) Token: 0x0601981C RID: 104476 RVA: 0x0025B1E1 File Offset: 0x002593E1
		// (set) Token: 0x0601981D RID: 104477 RVA: 0x0025B1FA File Offset: 0x002593FA
		public unsafe bool bOverride_BillboardCloudsBeginDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_BillboardCloudsBeginDistance) & FKuroCloudCardSetting.__PropertyMask_bOverride_BillboardCloudsBeginDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_BillboardCloudsBeginDistance) = ((*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_BillboardCloudsBeginDistance) & ~FKuroCloudCardSetting.__PropertyMask_bOverride_BillboardCloudsBeginDistance) | (value ? FKuroCloudCardSetting.__PropertyMask_bOverride_BillboardCloudsBeginDistance : 0));
			}
		}

		// Token: 0x170065BA RID: 26042
		// (get) Token: 0x0601981E RID: 104478 RVA: 0x0025B22A File Offset: 0x0025942A
		// (set) Token: 0x0601981F RID: 104479 RVA: 0x0025B243 File Offset: 0x00259443
		public unsafe bool bOverride_BillboardCloudsFadeDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_BillboardCloudsFadeDistance) & FKuroCloudCardSetting.__PropertyMask_bOverride_BillboardCloudsFadeDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_BillboardCloudsFadeDistance) = ((*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_bOverride_BillboardCloudsFadeDistance) & ~FKuroCloudCardSetting.__PropertyMask_bOverride_BillboardCloudsFadeDistance) | (value ? FKuroCloudCardSetting.__PropertyMask_bOverride_BillboardCloudsFadeDistance : 0));
			}
		}

		// Token: 0x170065BB RID: 26043
		// (get) Token: 0x06019820 RID: 104480 RVA: 0x0025B273 File Offset: 0x00259473
		// (set) Token: 0x06019821 RID: 104481 RVA: 0x0025B283 File Offset: 0x00259483
		public unsafe float AtmoLightScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_AtmoLightScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_AtmoLightScale) = value;
			}
		}

		// Token: 0x170065BC RID: 26044
		// (get) Token: 0x06019822 RID: 104482 RVA: 0x0025B294 File Offset: 0x00259494
		// (set) Token: 0x06019823 RID: 104483 RVA: 0x0025B2A4 File Offset: 0x002594A4
		public unsafe float Contrast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_Contrast);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_Contrast) = value;
			}
		}

		// Token: 0x170065BD RID: 26045
		// (get) Token: 0x06019824 RID: 104484 RVA: 0x0025B2B5 File Offset: 0x002594B5
		// (set) Token: 0x06019825 RID: 104485 RVA: 0x0025B2C5 File Offset: 0x002594C5
		public unsafe float FogColorAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_FogColorAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_FogColorAmount) = value;
			}
		}

		// Token: 0x170065BE RID: 26046
		// (get) Token: 0x06019826 RID: 104486 RVA: 0x0025B2D6 File Offset: 0x002594D6
		// (set) Token: 0x06019827 RID: 104487 RVA: 0x0025B2E6 File Offset: 0x002594E6
		public unsafe float DarkBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_DarkBrightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_DarkBrightness) = value;
			}
		}

		// Token: 0x170065BF RID: 26047
		// (get) Token: 0x06019828 RID: 104488 RVA: 0x0025B2F7 File Offset: 0x002594F7
		// (set) Token: 0x06019829 RID: 104489 RVA: 0x0025B307 File Offset: 0x00259507
		public unsafe float Exp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_Exp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_Exp) = value;
			}
		}

		// Token: 0x170065C0 RID: 26048
		// (get) Token: 0x0601982A RID: 104490 RVA: 0x0025B318 File Offset: 0x00259518
		// (set) Token: 0x0601982B RID: 104491 RVA: 0x0025B328 File Offset: 0x00259528
		public unsafe float HorizonFalloff
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_HorizonFalloff);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_HorizonFalloff) = value;
			}
		}

		// Token: 0x170065C1 RID: 26049
		// (get) Token: 0x0601982C RID: 104492 RVA: 0x0025B339 File Offset: 0x00259539
		// (set) Token: 0x0601982D RID: 104493 RVA: 0x0025B349 File Offset: 0x00259549
		public unsafe float HorizonMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_HorizonMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_HorizonMax) = value;
			}
		}

		// Token: 0x170065C2 RID: 26050
		// (get) Token: 0x0601982E RID: 104494 RVA: 0x0025B35A File Offset: 0x0025955A
		// (set) Token: 0x0601982F RID: 104495 RVA: 0x0025B36A File Offset: 0x0025956A
		public unsafe float HorizonMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_HorizonMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_HorizonMin) = value;
			}
		}

		// Token: 0x170065C3 RID: 26051
		// (get) Token: 0x06019830 RID: 104496 RVA: 0x0025B37B File Offset: 0x0025957B
		// (set) Token: 0x06019831 RID: 104497 RVA: 0x0025B38B File Offset: 0x0025958B
		public unsafe float HorizonOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_HorizonOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_HorizonOffset) = value;
			}
		}

		// Token: 0x170065C4 RID: 26052
		// (get) Token: 0x06019832 RID: 104498 RVA: 0x0025B39C File Offset: 0x0025959C
		// (set) Token: 0x06019833 RID: 104499 RVA: 0x0025B3AC File Offset: 0x002595AC
		public unsafe float LightBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_LightBrightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_LightBrightness) = value;
			}
		}

		// Token: 0x170065C5 RID: 26053
		// (get) Token: 0x06019834 RID: 104500 RVA: 0x0025B3BD File Offset: 0x002595BD
		// (set) Token: 0x06019835 RID: 104501 RVA: 0x0025B3CD File Offset: 0x002595CD
		public unsafe float LitOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_LitOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_LitOffset) = value;
			}
		}

		// Token: 0x170065C6 RID: 26054
		// (get) Token: 0x06019836 RID: 104502 RVA: 0x0025B3DE File Offset: 0x002595DE
		// (set) Token: 0x06019837 RID: 104503 RVA: 0x0025B3EE File Offset: 0x002595EE
		public unsafe float Translucency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_Translucency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_Translucency) = value;
			}
		}

		// Token: 0x170065C7 RID: 26055
		// (get) Token: 0x06019838 RID: 104504 RVA: 0x0025B3FF File Offset: 0x002595FF
		// (set) Token: 0x06019839 RID: 104505 RVA: 0x0025B413 File Offset: 0x00259613
		public unsafe FLinearColor BaseColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_BaseColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_BaseColor) = value;
			}
		}

		// Token: 0x170065C8 RID: 26056
		// (get) Token: 0x0601983A RID: 104506 RVA: 0x0025B428 File Offset: 0x00259628
		// (set) Token: 0x0601983B RID: 104507 RVA: 0x0025B43C File Offset: 0x0025963C
		public unsafe FLinearColor DarkColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_DarkColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_DarkColor) = value;
			}
		}

		// Token: 0x170065C9 RID: 26057
		// (get) Token: 0x0601983C RID: 104508 RVA: 0x0025B451 File Offset: 0x00259651
		// (set) Token: 0x0601983D RID: 104509 RVA: 0x0025B465 File Offset: 0x00259665
		public unsafe FLinearColor Emissive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_Emissive);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_Emissive) = value;
			}
		}

		// Token: 0x170065CA RID: 26058
		// (get) Token: 0x0601983E RID: 104510 RVA: 0x0025B47A File Offset: 0x0025967A
		// (set) Token: 0x0601983F RID: 104511 RVA: 0x0025B48E File Offset: 0x0025968E
		public unsafe FLinearColor LightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_LightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_LightColor) = value;
			}
		}

		// Token: 0x170065CB RID: 26059
		// (get) Token: 0x06019840 RID: 104512 RVA: 0x0025B4A3 File Offset: 0x002596A3
		// (set) Token: 0x06019841 RID: 104513 RVA: 0x0025B4B7 File Offset: 0x002596B7
		public unsafe FLinearColor Offset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_Offset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_Offset) = value;
			}
		}

		// Token: 0x170065CC RID: 26060
		// (get) Token: 0x06019842 RID: 104514 RVA: 0x0025B4CC File Offset: 0x002596CC
		// (set) Token: 0x06019843 RID: 104515 RVA: 0x0025B4DC File Offset: 0x002596DC
		public unsafe float BillboardCloudsNearFogDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_BillboardCloudsNearFogDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_BillboardCloudsNearFogDensity) = value;
			}
		}

		// Token: 0x170065CD RID: 26061
		// (get) Token: 0x06019844 RID: 104516 RVA: 0x0025B4ED File Offset: 0x002596ED
		// (set) Token: 0x06019845 RID: 104517 RVA: 0x0025B4FD File Offset: 0x002596FD
		public unsafe float BillboardCloudsFarFogDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_BillboardCloudsFarFogDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_BillboardCloudsFarFogDensity) = value;
			}
		}

		// Token: 0x170065CE RID: 26062
		// (get) Token: 0x06019846 RID: 104518 RVA: 0x0025B50E File Offset: 0x0025970E
		// (set) Token: 0x06019847 RID: 104519 RVA: 0x0025B51E File Offset: 0x0025971E
		public unsafe float BillboardCloudsBeginDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_BillboardCloudsBeginDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_BillboardCloudsBeginDistance) = value;
			}
		}

		// Token: 0x170065CF RID: 26063
		// (get) Token: 0x06019848 RID: 104520 RVA: 0x0025B52F File Offset: 0x0025972F
		// (set) Token: 0x06019849 RID: 104521 RVA: 0x0025B53F File Offset: 0x0025973F
		public unsafe float BillboardCloudsFadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_BillboardCloudsFadeDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudCardSetting.__PropertyOffset_BillboardCloudsFadeDistance) = value;
			}
		}

		// Token: 0x0601984A RID: 104522 RVA: 0x0025B550 File Offset: 0x00259750
		public FKuroCloudCardSetting()
		{
		}

		// Token: 0x0601984B RID: 104523 RVA: 0x0025B558 File Offset: 0x00259758
		public FKuroCloudCardSetting(bool bOverride_AtmoLightScale, bool bOverride_Contrast, bool bOverride_FogColorAmount, bool bOverride_DarkBrightness, bool bOverride_Exp, bool bOverride_HorizonFalloff, bool bOverride_HorizonMax, bool bOverride_HorizonMin, bool bOverride_HorizonOffset, bool bOverride_LightBrightness, bool bOverride_LitOffset, bool bOverride_Translucency, bool bOverride_BaseColor, bool bOverride_DarkColor, bool bOverride_Emissive, bool bOverride_LightColor, bool bOverride_Offset, bool bOverride_BillboardCloudsNearFogDensity, bool bOverride_BillboardCloudsFarFogDensity, bool bOverride_BillboardCloudsBeginDistance, bool bOverride_BillboardCloudsFadeDistance, float AtmoLightScale, float Contrast, float FogColorAmount, float DarkBrightness, float Exp, float HorizonFalloff, float HorizonMax, float HorizonMin, float HorizonOffset, float LightBrightness, float LitOffset, float Translucency, FLinearColor BaseColor, FLinearColor DarkColor, FLinearColor Emissive, FLinearColor LightColor, FLinearColor Offset, float BillboardCloudsNearFogDensity, float BillboardCloudsFarFogDensity, float BillboardCloudsBeginDistance, float BillboardCloudsFadeDistance)
		{
			this.bOverride_AtmoLightScale = bOverride_AtmoLightScale;
			this.bOverride_Contrast = bOverride_Contrast;
			this.bOverride_FogColorAmount = bOverride_FogColorAmount;
			this.bOverride_DarkBrightness = bOverride_DarkBrightness;
			this.bOverride_Exp = bOverride_Exp;
			this.bOverride_HorizonFalloff = bOverride_HorizonFalloff;
			this.bOverride_HorizonMax = bOverride_HorizonMax;
			this.bOverride_HorizonMin = bOverride_HorizonMin;
			this.bOverride_HorizonOffset = bOverride_HorizonOffset;
			this.bOverride_LightBrightness = bOverride_LightBrightness;
			this.bOverride_LitOffset = bOverride_LitOffset;
			this.bOverride_Translucency = bOverride_Translucency;
			this.bOverride_BaseColor = bOverride_BaseColor;
			this.bOverride_DarkColor = bOverride_DarkColor;
			this.bOverride_Emissive = bOverride_Emissive;
			this.bOverride_LightColor = bOverride_LightColor;
			this.bOverride_Offset = bOverride_Offset;
			this.bOverride_BillboardCloudsNearFogDensity = bOverride_BillboardCloudsNearFogDensity;
			this.bOverride_BillboardCloudsFarFogDensity = bOverride_BillboardCloudsFarFogDensity;
			this.bOverride_BillboardCloudsBeginDistance = bOverride_BillboardCloudsBeginDistance;
			this.bOverride_BillboardCloudsFadeDistance = bOverride_BillboardCloudsFadeDistance;
			this.AtmoLightScale = AtmoLightScale;
			this.Contrast = Contrast;
			this.FogColorAmount = FogColorAmount;
			this.DarkBrightness = DarkBrightness;
			this.Exp = Exp;
			this.HorizonFalloff = HorizonFalloff;
			this.HorizonMax = HorizonMax;
			this.HorizonMin = HorizonMin;
			this.HorizonOffset = HorizonOffset;
			this.LightBrightness = LightBrightness;
			this.LitOffset = LitOffset;
			this.Translucency = Translucency;
			this.BaseColor = BaseColor;
			this.DarkColor = DarkColor;
			this.Emissive = Emissive;
			this.LightColor = LightColor;
			this.Offset = Offset;
			this.BillboardCloudsNearFogDensity = BillboardCloudsNearFogDensity;
			this.BillboardCloudsFarFogDensity = BillboardCloudsFarFogDensity;
			this.BillboardCloudsBeginDistance = BillboardCloudsBeginDistance;
			this.BillboardCloudsFadeDistance = BillboardCloudsFadeDistance;
		}

		// Token: 0x0601984C RID: 104524 RVA: 0x0025B6B8 File Offset: 0x002598B8
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCloudCardSetting.StaticStruct();
		}

		// Token: 0x0601984D RID: 104525 RVA: 0x0025B6C4 File Offset: 0x002598C4
		[NullableContext(2)]
		public FKuroCloudCardSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601984E RID: 104526 RVA: 0x0025B6CE File Offset: 0x002598CE
		public FKuroCloudCardSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601984F RID: 104527 RVA: 0x0025B6D9 File Offset: 0x002598D9
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCloudCardSetting(Pointer, false, true);
		}

		// Token: 0x06019850 RID: 104528 RVA: 0x0025B6E3 File Offset: 0x002598E3
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCloudCardSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400DE03 RID: 56835
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCloudCardSetting";

		// Token: 0x0400DE04 RID: 56836
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DE05 RID: 56837
		internal static int __PropertyOffset_bOverride_AtmoLightScale;

		// Token: 0x0400DE06 RID: 56838
		internal static byte __PropertyMask_bOverride_AtmoLightScale;

		// Token: 0x0400DE07 RID: 56839
		internal static int __PropertyOffset_bOverride_Contrast;

		// Token: 0x0400DE08 RID: 56840
		internal static byte __PropertyMask_bOverride_Contrast;

		// Token: 0x0400DE09 RID: 56841
		internal static int __PropertyOffset_bOverride_FogColorAmount;

		// Token: 0x0400DE0A RID: 56842
		internal static byte __PropertyMask_bOverride_FogColorAmount;

		// Token: 0x0400DE0B RID: 56843
		internal static int __PropertyOffset_bOverride_DarkBrightness;

		// Token: 0x0400DE0C RID: 56844
		internal static byte __PropertyMask_bOverride_DarkBrightness;

		// Token: 0x0400DE0D RID: 56845
		internal static int __PropertyOffset_bOverride_Exp;

		// Token: 0x0400DE0E RID: 56846
		internal static byte __PropertyMask_bOverride_Exp;

		// Token: 0x0400DE0F RID: 56847
		internal static int __PropertyOffset_bOverride_HorizonFalloff;

		// Token: 0x0400DE10 RID: 56848
		internal static byte __PropertyMask_bOverride_HorizonFalloff;

		// Token: 0x0400DE11 RID: 56849
		internal static int __PropertyOffset_bOverride_HorizonMax;

		// Token: 0x0400DE12 RID: 56850
		internal static byte __PropertyMask_bOverride_HorizonMax;

		// Token: 0x0400DE13 RID: 56851
		internal static int __PropertyOffset_bOverride_HorizonMin;

		// Token: 0x0400DE14 RID: 56852
		internal static byte __PropertyMask_bOverride_HorizonMin;

		// Token: 0x0400DE15 RID: 56853
		internal static int __PropertyOffset_bOverride_HorizonOffset;

		// Token: 0x0400DE16 RID: 56854
		internal static byte __PropertyMask_bOverride_HorizonOffset;

		// Token: 0x0400DE17 RID: 56855
		internal static int __PropertyOffset_bOverride_LightBrightness;

		// Token: 0x0400DE18 RID: 56856
		internal static byte __PropertyMask_bOverride_LightBrightness;

		// Token: 0x0400DE19 RID: 56857
		internal static int __PropertyOffset_bOverride_LitOffset;

		// Token: 0x0400DE1A RID: 56858
		internal static byte __PropertyMask_bOverride_LitOffset;

		// Token: 0x0400DE1B RID: 56859
		internal static int __PropertyOffset_bOverride_Translucency;

		// Token: 0x0400DE1C RID: 56860
		internal static byte __PropertyMask_bOverride_Translucency;

		// Token: 0x0400DE1D RID: 56861
		internal static int __PropertyOffset_bOverride_BaseColor;

		// Token: 0x0400DE1E RID: 56862
		internal static byte __PropertyMask_bOverride_BaseColor;

		// Token: 0x0400DE1F RID: 56863
		internal static int __PropertyOffset_bOverride_DarkColor;

		// Token: 0x0400DE20 RID: 56864
		internal static byte __PropertyMask_bOverride_DarkColor;

		// Token: 0x0400DE21 RID: 56865
		internal static int __PropertyOffset_bOverride_Emissive;

		// Token: 0x0400DE22 RID: 56866
		internal static byte __PropertyMask_bOverride_Emissive;

		// Token: 0x0400DE23 RID: 56867
		internal static int __PropertyOffset_bOverride_LightColor;

		// Token: 0x0400DE24 RID: 56868
		internal static byte __PropertyMask_bOverride_LightColor;

		// Token: 0x0400DE25 RID: 56869
		internal static int __PropertyOffset_bOverride_Offset;

		// Token: 0x0400DE26 RID: 56870
		internal static byte __PropertyMask_bOverride_Offset;

		// Token: 0x0400DE27 RID: 56871
		internal static int __PropertyOffset_bOverride_BillboardCloudsNearFogDensity;

		// Token: 0x0400DE28 RID: 56872
		internal static byte __PropertyMask_bOverride_BillboardCloudsNearFogDensity;

		// Token: 0x0400DE29 RID: 56873
		internal static int __PropertyOffset_bOverride_BillboardCloudsFarFogDensity;

		// Token: 0x0400DE2A RID: 56874
		internal static byte __PropertyMask_bOverride_BillboardCloudsFarFogDensity;

		// Token: 0x0400DE2B RID: 56875
		internal static int __PropertyOffset_bOverride_BillboardCloudsBeginDistance;

		// Token: 0x0400DE2C RID: 56876
		internal static byte __PropertyMask_bOverride_BillboardCloudsBeginDistance;

		// Token: 0x0400DE2D RID: 56877
		internal static int __PropertyOffset_bOverride_BillboardCloudsFadeDistance;

		// Token: 0x0400DE2E RID: 56878
		internal static byte __PropertyMask_bOverride_BillboardCloudsFadeDistance;

		// Token: 0x0400DE2F RID: 56879
		internal static int __PropertyOffset_AtmoLightScale;

		// Token: 0x0400DE30 RID: 56880
		internal static int __PropertyOffset_Contrast;

		// Token: 0x0400DE31 RID: 56881
		internal static int __PropertyOffset_FogColorAmount;

		// Token: 0x0400DE32 RID: 56882
		internal static int __PropertyOffset_DarkBrightness;

		// Token: 0x0400DE33 RID: 56883
		internal static int __PropertyOffset_Exp;

		// Token: 0x0400DE34 RID: 56884
		internal static int __PropertyOffset_HorizonFalloff;

		// Token: 0x0400DE35 RID: 56885
		internal static int __PropertyOffset_HorizonMax;

		// Token: 0x0400DE36 RID: 56886
		internal static int __PropertyOffset_HorizonMin;

		// Token: 0x0400DE37 RID: 56887
		internal static int __PropertyOffset_HorizonOffset;

		// Token: 0x0400DE38 RID: 56888
		internal static int __PropertyOffset_LightBrightness;

		// Token: 0x0400DE39 RID: 56889
		internal static int __PropertyOffset_LitOffset;

		// Token: 0x0400DE3A RID: 56890
		internal static int __PropertyOffset_Translucency;

		// Token: 0x0400DE3B RID: 56891
		internal static int __PropertyOffset_BaseColor;

		// Token: 0x0400DE3C RID: 56892
		internal static int __PropertyOffset_DarkColor;

		// Token: 0x0400DE3D RID: 56893
		internal static int __PropertyOffset_Emissive;

		// Token: 0x0400DE3E RID: 56894
		internal static int __PropertyOffset_LightColor;

		// Token: 0x0400DE3F RID: 56895
		internal static int __PropertyOffset_Offset;

		// Token: 0x0400DE40 RID: 56896
		internal static int __PropertyOffset_BillboardCloudsNearFogDensity;

		// Token: 0x0400DE41 RID: 56897
		internal static int __PropertyOffset_BillboardCloudsFarFogDensity;

		// Token: 0x0400DE42 RID: 56898
		internal static int __PropertyOffset_BillboardCloudsBeginDistance;

		// Token: 0x0400DE43 RID: 56899
		internal static int __PropertyOffset_BillboardCloudsFadeDistance;
	}
}
