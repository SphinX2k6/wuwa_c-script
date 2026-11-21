using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000269 RID: 617
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PostProcessSettings")]
	[UnrealStructLayout(2640, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2640)]
	public class FPostProcessSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x060036D6 RID: 14038 RVA: 0x0004D4B3 File Offset: 0x0004B6B3
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPostProcessSettings._ScriptStructPtr != 0) ? FPostProcessSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PostProcessSettings", ref FPostProcessSettings._ScriptStructPtr);
		}

		// Token: 0x170007D7 RID: 2007
		// (get) Token: 0x060036D7 RID: 14039 RVA: 0x0004D4D7 File Offset: 0x0004B6D7
		// (set) Token: 0x060036D8 RID: 14040 RVA: 0x0004D4F0 File Offset: 0x0004B6F0
		public unsafe bool bOverride_WhiteTemp
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_WhiteTemp) & FPostProcessSettings.__PropertyMask_bOverride_WhiteTemp) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_WhiteTemp) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_WhiteTemp) & ~FPostProcessSettings.__PropertyMask_bOverride_WhiteTemp) | (value ? FPostProcessSettings.__PropertyMask_bOverride_WhiteTemp : 0));
			}
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x060036D9 RID: 14041 RVA: 0x0004D520 File Offset: 0x0004B720
		// (set) Token: 0x060036DA RID: 14042 RVA: 0x0004D539 File Offset: 0x0004B739
		public unsafe bool bOverride_WhiteTint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_WhiteTint) & FPostProcessSettings.__PropertyMask_bOverride_WhiteTint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_WhiteTint) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_WhiteTint) & ~FPostProcessSettings.__PropertyMask_bOverride_WhiteTint) | (value ? FPostProcessSettings.__PropertyMask_bOverride_WhiteTint : 0));
			}
		}

		// Token: 0x170007D9 RID: 2009
		// (get) Token: 0x060036DB RID: 14043 RVA: 0x0004D569 File Offset: 0x0004B769
		// (set) Token: 0x060036DC RID: 14044 RVA: 0x0004D582 File Offset: 0x0004B782
		public unsafe bool bOverride_ColorSaturation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorSaturation) & FPostProcessSettings.__PropertyMask_bOverride_ColorSaturation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorSaturation) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorSaturation) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorSaturation) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorSaturation : 0));
			}
		}

		// Token: 0x170007DA RID: 2010
		// (get) Token: 0x060036DD RID: 14045 RVA: 0x0004D5B2 File Offset: 0x0004B7B2
		// (set) Token: 0x060036DE RID: 14046 RVA: 0x0004D5CB File Offset: 0x0004B7CB
		public unsafe bool bOverride_ColorContrast
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorContrast) & FPostProcessSettings.__PropertyMask_bOverride_ColorContrast) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorContrast) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorContrast) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorContrast) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorContrast : 0));
			}
		}

		// Token: 0x170007DB RID: 2011
		// (get) Token: 0x060036DF RID: 14047 RVA: 0x0004D5FB File Offset: 0x0004B7FB
		// (set) Token: 0x060036E0 RID: 14048 RVA: 0x0004D614 File Offset: 0x0004B814
		public unsafe bool bOverride_ColorGamma
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGamma) & FPostProcessSettings.__PropertyMask_bOverride_ColorGamma) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGamma) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGamma) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorGamma) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorGamma : 0));
			}
		}

		// Token: 0x170007DC RID: 2012
		// (get) Token: 0x060036E1 RID: 14049 RVA: 0x0004D644 File Offset: 0x0004B844
		// (set) Token: 0x060036E2 RID: 14050 RVA: 0x0004D65D File Offset: 0x0004B85D
		public unsafe bool bOverride_ColorGain
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGain) & FPostProcessSettings.__PropertyMask_bOverride_ColorGain) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGain) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGain) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorGain) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorGain : 0));
			}
		}

		// Token: 0x170007DD RID: 2013
		// (get) Token: 0x060036E3 RID: 14051 RVA: 0x0004D68D File Offset: 0x0004B88D
		// (set) Token: 0x060036E4 RID: 14052 RVA: 0x0004D6A6 File Offset: 0x0004B8A6
		public unsafe bool bOverride_ColorOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorOffset) & FPostProcessSettings.__PropertyMask_bOverride_ColorOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorOffset) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorOffset) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorOffset) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorOffset : 0));
			}
		}

		// Token: 0x170007DE RID: 2014
		// (get) Token: 0x060036E5 RID: 14053 RVA: 0x0004D6D6 File Offset: 0x0004B8D6
		// (set) Token: 0x060036E6 RID: 14054 RVA: 0x0004D6EF File Offset: 0x0004B8EF
		public unsafe bool bOverride_ColorSaturationShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorSaturationShadows) & FPostProcessSettings.__PropertyMask_bOverride_ColorSaturationShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorSaturationShadows) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorSaturationShadows) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorSaturationShadows) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorSaturationShadows : 0));
			}
		}

		// Token: 0x170007DF RID: 2015
		// (get) Token: 0x060036E7 RID: 14055 RVA: 0x0004D71F File Offset: 0x0004B91F
		// (set) Token: 0x060036E8 RID: 14056 RVA: 0x0004D738 File Offset: 0x0004B938
		public unsafe bool bOverride_ColorContrastShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorContrastShadows) & FPostProcessSettings.__PropertyMask_bOverride_ColorContrastShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorContrastShadows) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorContrastShadows) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorContrastShadows) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorContrastShadows : 0));
			}
		}

		// Token: 0x170007E0 RID: 2016
		// (get) Token: 0x060036E9 RID: 14057 RVA: 0x0004D768 File Offset: 0x0004B968
		// (set) Token: 0x060036EA RID: 14058 RVA: 0x0004D781 File Offset: 0x0004B981
		public unsafe bool bOverride_ColorGammaShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGammaShadows) & FPostProcessSettings.__PropertyMask_bOverride_ColorGammaShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGammaShadows) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGammaShadows) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorGammaShadows) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorGammaShadows : 0));
			}
		}

		// Token: 0x170007E1 RID: 2017
		// (get) Token: 0x060036EB RID: 14059 RVA: 0x0004D7B1 File Offset: 0x0004B9B1
		// (set) Token: 0x060036EC RID: 14060 RVA: 0x0004D7CA File Offset: 0x0004B9CA
		public unsafe bool bOverride_ColorGainShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGainShadows) & FPostProcessSettings.__PropertyMask_bOverride_ColorGainShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGainShadows) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGainShadows) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorGainShadows) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorGainShadows : 0));
			}
		}

		// Token: 0x170007E2 RID: 2018
		// (get) Token: 0x060036ED RID: 14061 RVA: 0x0004D7FA File Offset: 0x0004B9FA
		// (set) Token: 0x060036EE RID: 14062 RVA: 0x0004D813 File Offset: 0x0004BA13
		public unsafe bool bOverride_ColorOffsetShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorOffsetShadows) & FPostProcessSettings.__PropertyMask_bOverride_ColorOffsetShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorOffsetShadows) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorOffsetShadows) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorOffsetShadows) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorOffsetShadows : 0));
			}
		}

		// Token: 0x170007E3 RID: 2019
		// (get) Token: 0x060036EF RID: 14063 RVA: 0x0004D843 File Offset: 0x0004BA43
		// (set) Token: 0x060036F0 RID: 14064 RVA: 0x0004D85C File Offset: 0x0004BA5C
		public unsafe bool bOverride_ColorSaturationMidtones
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorSaturationMidtones) & FPostProcessSettings.__PropertyMask_bOverride_ColorSaturationMidtones) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorSaturationMidtones) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorSaturationMidtones) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorSaturationMidtones) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorSaturationMidtones : 0));
			}
		}

		// Token: 0x170007E4 RID: 2020
		// (get) Token: 0x060036F1 RID: 14065 RVA: 0x0004D88C File Offset: 0x0004BA8C
		// (set) Token: 0x060036F2 RID: 14066 RVA: 0x0004D8A5 File Offset: 0x0004BAA5
		public unsafe bool bOverride_ColorContrastMidtones
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorContrastMidtones) & FPostProcessSettings.__PropertyMask_bOverride_ColorContrastMidtones) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorContrastMidtones) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorContrastMidtones) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorContrastMidtones) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorContrastMidtones : 0));
			}
		}

		// Token: 0x170007E5 RID: 2021
		// (get) Token: 0x060036F3 RID: 14067 RVA: 0x0004D8D5 File Offset: 0x0004BAD5
		// (set) Token: 0x060036F4 RID: 14068 RVA: 0x0004D8EE File Offset: 0x0004BAEE
		public unsafe bool bOverride_ColorGammaMidtones
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGammaMidtones) & FPostProcessSettings.__PropertyMask_bOverride_ColorGammaMidtones) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGammaMidtones) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGammaMidtones) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorGammaMidtones) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorGammaMidtones : 0));
			}
		}

		// Token: 0x170007E6 RID: 2022
		// (get) Token: 0x060036F5 RID: 14069 RVA: 0x0004D91E File Offset: 0x0004BB1E
		// (set) Token: 0x060036F6 RID: 14070 RVA: 0x0004D937 File Offset: 0x0004BB37
		public unsafe bool bOverride_ColorGainMidtones
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGainMidtones) & FPostProcessSettings.__PropertyMask_bOverride_ColorGainMidtones) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGainMidtones) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGainMidtones) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorGainMidtones) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorGainMidtones : 0));
			}
		}

		// Token: 0x170007E7 RID: 2023
		// (get) Token: 0x060036F7 RID: 14071 RVA: 0x0004D967 File Offset: 0x0004BB67
		// (set) Token: 0x060036F8 RID: 14072 RVA: 0x0004D980 File Offset: 0x0004BB80
		public unsafe bool bOverride_ColorOffsetMidtones
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorOffsetMidtones) & FPostProcessSettings.__PropertyMask_bOverride_ColorOffsetMidtones) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorOffsetMidtones) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorOffsetMidtones) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorOffsetMidtones) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorOffsetMidtones : 0));
			}
		}

		// Token: 0x170007E8 RID: 2024
		// (get) Token: 0x060036F9 RID: 14073 RVA: 0x0004D9B0 File Offset: 0x0004BBB0
		// (set) Token: 0x060036FA RID: 14074 RVA: 0x0004D9C9 File Offset: 0x0004BBC9
		public unsafe bool bOverride_ColorSaturationHighlights
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorSaturationHighlights) & FPostProcessSettings.__PropertyMask_bOverride_ColorSaturationHighlights) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorSaturationHighlights) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorSaturationHighlights) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorSaturationHighlights) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorSaturationHighlights : 0));
			}
		}

		// Token: 0x170007E9 RID: 2025
		// (get) Token: 0x060036FB RID: 14075 RVA: 0x0004D9F9 File Offset: 0x0004BBF9
		// (set) Token: 0x060036FC RID: 14076 RVA: 0x0004DA12 File Offset: 0x0004BC12
		public unsafe bool bOverride_ColorContrastHighlights
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorContrastHighlights) & FPostProcessSettings.__PropertyMask_bOverride_ColorContrastHighlights) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorContrastHighlights) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorContrastHighlights) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorContrastHighlights) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorContrastHighlights : 0));
			}
		}

		// Token: 0x170007EA RID: 2026
		// (get) Token: 0x060036FD RID: 14077 RVA: 0x0004DA42 File Offset: 0x0004BC42
		// (set) Token: 0x060036FE RID: 14078 RVA: 0x0004DA5B File Offset: 0x0004BC5B
		public unsafe bool bOverride_ColorGammaHighlights
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGammaHighlights) & FPostProcessSettings.__PropertyMask_bOverride_ColorGammaHighlights) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGammaHighlights) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGammaHighlights) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorGammaHighlights) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorGammaHighlights : 0));
			}
		}

		// Token: 0x170007EB RID: 2027
		// (get) Token: 0x060036FF RID: 14079 RVA: 0x0004DA8B File Offset: 0x0004BC8B
		// (set) Token: 0x06003700 RID: 14080 RVA: 0x0004DAA4 File Offset: 0x0004BCA4
		public unsafe bool bOverride_ColorGainHighlights
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGainHighlights) & FPostProcessSettings.__PropertyMask_bOverride_ColorGainHighlights) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGainHighlights) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGainHighlights) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorGainHighlights) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorGainHighlights : 0));
			}
		}

		// Token: 0x170007EC RID: 2028
		// (get) Token: 0x06003701 RID: 14081 RVA: 0x0004DAD4 File Offset: 0x0004BCD4
		// (set) Token: 0x06003702 RID: 14082 RVA: 0x0004DAED File Offset: 0x0004BCED
		public unsafe bool bOverride_ColorOffsetHighlights
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorOffsetHighlights) & FPostProcessSettings.__PropertyMask_bOverride_ColorOffsetHighlights) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorOffsetHighlights) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorOffsetHighlights) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorOffsetHighlights) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorOffsetHighlights : 0));
			}
		}

		// Token: 0x170007ED RID: 2029
		// (get) Token: 0x06003703 RID: 14083 RVA: 0x0004DB1D File Offset: 0x0004BD1D
		// (set) Token: 0x06003704 RID: 14084 RVA: 0x0004DB36 File Offset: 0x0004BD36
		public unsafe bool bOverride_ColorCorrectionShadowsMax
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorCorrectionShadowsMax) & FPostProcessSettings.__PropertyMask_bOverride_ColorCorrectionShadowsMax) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorCorrectionShadowsMax) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorCorrectionShadowsMax) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorCorrectionShadowsMax) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorCorrectionShadowsMax : 0));
			}
		}

		// Token: 0x170007EE RID: 2030
		// (get) Token: 0x06003705 RID: 14085 RVA: 0x0004DB66 File Offset: 0x0004BD66
		// (set) Token: 0x06003706 RID: 14086 RVA: 0x0004DB7F File Offset: 0x0004BD7F
		public unsafe bool bOverride_ColorCorrectionHighlightsMin
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorCorrectionHighlightsMin) & FPostProcessSettings.__PropertyMask_bOverride_ColorCorrectionHighlightsMin) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorCorrectionHighlightsMin) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorCorrectionHighlightsMin) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorCorrectionHighlightsMin) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorCorrectionHighlightsMin : 0));
			}
		}

		// Token: 0x170007EF RID: 2031
		// (get) Token: 0x06003707 RID: 14087 RVA: 0x0004DBAF File Offset: 0x0004BDAF
		// (set) Token: 0x06003708 RID: 14088 RVA: 0x0004DBC8 File Offset: 0x0004BDC8
		public unsafe bool bOverride_BlueCorrection
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BlueCorrection) & FPostProcessSettings.__PropertyMask_bOverride_BlueCorrection) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BlueCorrection) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BlueCorrection) & ~FPostProcessSettings.__PropertyMask_bOverride_BlueCorrection) | (value ? FPostProcessSettings.__PropertyMask_bOverride_BlueCorrection : 0));
			}
		}

		// Token: 0x170007F0 RID: 2032
		// (get) Token: 0x06003709 RID: 14089 RVA: 0x0004DBF8 File Offset: 0x0004BDF8
		// (set) Token: 0x0600370A RID: 14090 RVA: 0x0004DC11 File Offset: 0x0004BE11
		public unsafe bool bOverride_ExpandGamut
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ExpandGamut) & FPostProcessSettings.__PropertyMask_bOverride_ExpandGamut) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ExpandGamut) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ExpandGamut) & ~FPostProcessSettings.__PropertyMask_bOverride_ExpandGamut) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ExpandGamut : 0));
			}
		}

		// Token: 0x170007F1 RID: 2033
		// (get) Token: 0x0600370B RID: 14091 RVA: 0x0004DC41 File Offset: 0x0004BE41
		// (set) Token: 0x0600370C RID: 14092 RVA: 0x0004DC5A File Offset: 0x0004BE5A
		public unsafe bool bOverride_ToneCurveAmount
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToneCurveAmount) & FPostProcessSettings.__PropertyMask_bOverride_ToneCurveAmount) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToneCurveAmount) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToneCurveAmount) & ~FPostProcessSettings.__PropertyMask_bOverride_ToneCurveAmount) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ToneCurveAmount : 0));
			}
		}

		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x0600370D RID: 14093 RVA: 0x0004DC8A File Offset: 0x0004BE8A
		// (set) Token: 0x0600370E RID: 14094 RVA: 0x0004DCA3 File Offset: 0x0004BEA3
		public unsafe bool bOverride_FilmWhitePoint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmWhitePoint) & FPostProcessSettings.__PropertyMask_bOverride_FilmWhitePoint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmWhitePoint) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmWhitePoint) & ~FPostProcessSettings.__PropertyMask_bOverride_FilmWhitePoint) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FilmWhitePoint : 0));
			}
		}

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x0600370F RID: 14095 RVA: 0x0004DCD3 File Offset: 0x0004BED3
		// (set) Token: 0x06003710 RID: 14096 RVA: 0x0004DCEC File Offset: 0x0004BEEC
		public unsafe bool bOverride_FilmSaturation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmSaturation) & FPostProcessSettings.__PropertyMask_bOverride_FilmSaturation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmSaturation) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmSaturation) & ~FPostProcessSettings.__PropertyMask_bOverride_FilmSaturation) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FilmSaturation : 0));
			}
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06003711 RID: 14097 RVA: 0x0004DD1C File Offset: 0x0004BF1C
		// (set) Token: 0x06003712 RID: 14098 RVA: 0x0004DD35 File Offset: 0x0004BF35
		public unsafe bool bOverride_FilmChannelMixerRed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmChannelMixerRed) & FPostProcessSettings.__PropertyMask_bOverride_FilmChannelMixerRed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmChannelMixerRed) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmChannelMixerRed) & ~FPostProcessSettings.__PropertyMask_bOverride_FilmChannelMixerRed) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FilmChannelMixerRed : 0));
			}
		}

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06003713 RID: 14099 RVA: 0x0004DD65 File Offset: 0x0004BF65
		// (set) Token: 0x06003714 RID: 14100 RVA: 0x0004DD7E File Offset: 0x0004BF7E
		public unsafe bool bOverride_FilmChannelMixerGreen
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmChannelMixerGreen) & FPostProcessSettings.__PropertyMask_bOverride_FilmChannelMixerGreen) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmChannelMixerGreen) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmChannelMixerGreen) & ~FPostProcessSettings.__PropertyMask_bOverride_FilmChannelMixerGreen) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FilmChannelMixerGreen : 0));
			}
		}

		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x06003715 RID: 14101 RVA: 0x0004DDAE File Offset: 0x0004BFAE
		// (set) Token: 0x06003716 RID: 14102 RVA: 0x0004DDC7 File Offset: 0x0004BFC7
		public unsafe bool bOverride_FilmChannelMixerBlue
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmChannelMixerBlue) & FPostProcessSettings.__PropertyMask_bOverride_FilmChannelMixerBlue) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmChannelMixerBlue) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmChannelMixerBlue) & ~FPostProcessSettings.__PropertyMask_bOverride_FilmChannelMixerBlue) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FilmChannelMixerBlue : 0));
			}
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06003717 RID: 14103 RVA: 0x0004DDF7 File Offset: 0x0004BFF7
		// (set) Token: 0x06003718 RID: 14104 RVA: 0x0004DE10 File Offset: 0x0004C010
		public unsafe bool bOverride_FilmContrast
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmContrast) & FPostProcessSettings.__PropertyMask_bOverride_FilmContrast) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmContrast) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmContrast) & ~FPostProcessSettings.__PropertyMask_bOverride_FilmContrast) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FilmContrast : 0));
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06003719 RID: 14105 RVA: 0x0004DE40 File Offset: 0x0004C040
		// (set) Token: 0x0600371A RID: 14106 RVA: 0x0004DE59 File Offset: 0x0004C059
		public unsafe bool bOverride_FilmDynamicRange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmDynamicRange) & FPostProcessSettings.__PropertyMask_bOverride_FilmDynamicRange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmDynamicRange) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmDynamicRange) & ~FPostProcessSettings.__PropertyMask_bOverride_FilmDynamicRange) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FilmDynamicRange : 0));
			}
		}

		// Token: 0x170007F9 RID: 2041
		// (get) Token: 0x0600371B RID: 14107 RVA: 0x0004DE89 File Offset: 0x0004C089
		// (set) Token: 0x0600371C RID: 14108 RVA: 0x0004DEA2 File Offset: 0x0004C0A2
		public unsafe bool bOverride_FilmHealAmount
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmHealAmount) & FPostProcessSettings.__PropertyMask_bOverride_FilmHealAmount) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmHealAmount) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmHealAmount) & ~FPostProcessSettings.__PropertyMask_bOverride_FilmHealAmount) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FilmHealAmount : 0));
			}
		}

		// Token: 0x170007FA RID: 2042
		// (get) Token: 0x0600371D RID: 14109 RVA: 0x0004DED2 File Offset: 0x0004C0D2
		// (set) Token: 0x0600371E RID: 14110 RVA: 0x0004DEEB File Offset: 0x0004C0EB
		public unsafe bool bOverride_FilmToeAmount
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmToeAmount) & FPostProcessSettings.__PropertyMask_bOverride_FilmToeAmount) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmToeAmount) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmToeAmount) & ~FPostProcessSettings.__PropertyMask_bOverride_FilmToeAmount) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FilmToeAmount : 0));
			}
		}

		// Token: 0x170007FB RID: 2043
		// (get) Token: 0x0600371F RID: 14111 RVA: 0x0004DF1B File Offset: 0x0004C11B
		// (set) Token: 0x06003720 RID: 14112 RVA: 0x0004DF34 File Offset: 0x0004C134
		public unsafe bool bOverride_FilmShadowTint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmShadowTint) & FPostProcessSettings.__PropertyMask_bOverride_FilmShadowTint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmShadowTint) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmShadowTint) & ~FPostProcessSettings.__PropertyMask_bOverride_FilmShadowTint) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FilmShadowTint : 0));
			}
		}

		// Token: 0x170007FC RID: 2044
		// (get) Token: 0x06003721 RID: 14113 RVA: 0x0004DF64 File Offset: 0x0004C164
		// (set) Token: 0x06003722 RID: 14114 RVA: 0x0004DF7D File Offset: 0x0004C17D
		public unsafe bool bOverride_FilmShadowTintBlend
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmShadowTintBlend) & FPostProcessSettings.__PropertyMask_bOverride_FilmShadowTintBlend) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmShadowTintBlend) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmShadowTintBlend) & ~FPostProcessSettings.__PropertyMask_bOverride_FilmShadowTintBlend) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FilmShadowTintBlend : 0));
			}
		}

		// Token: 0x170007FD RID: 2045
		// (get) Token: 0x06003723 RID: 14115 RVA: 0x0004DFAD File Offset: 0x0004C1AD
		// (set) Token: 0x06003724 RID: 14116 RVA: 0x0004DFC6 File Offset: 0x0004C1C6
		public unsafe bool bOverride_FilmShadowTintAmount
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmShadowTintAmount) & FPostProcessSettings.__PropertyMask_bOverride_FilmShadowTintAmount) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmShadowTintAmount) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmShadowTintAmount) & ~FPostProcessSettings.__PropertyMask_bOverride_FilmShadowTintAmount) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FilmShadowTintAmount : 0));
			}
		}

		// Token: 0x170007FE RID: 2046
		// (get) Token: 0x06003725 RID: 14117 RVA: 0x0004DFF6 File Offset: 0x0004C1F6
		// (set) Token: 0x06003726 RID: 14118 RVA: 0x0004E00F File Offset: 0x0004C20F
		public unsafe bool bOverride_FilmSlope
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmSlope) & FPostProcessSettings.__PropertyMask_bOverride_FilmSlope) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmSlope) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmSlope) & ~FPostProcessSettings.__PropertyMask_bOverride_FilmSlope) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FilmSlope : 0));
			}
		}

		// Token: 0x170007FF RID: 2047
		// (get) Token: 0x06003727 RID: 14119 RVA: 0x0004E03F File Offset: 0x0004C23F
		// (set) Token: 0x06003728 RID: 14120 RVA: 0x0004E058 File Offset: 0x0004C258
		public unsafe bool bOverride_FilmToe
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmToe) & FPostProcessSettings.__PropertyMask_bOverride_FilmToe) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmToe) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmToe) & ~FPostProcessSettings.__PropertyMask_bOverride_FilmToe) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FilmToe : 0));
			}
		}

		// Token: 0x17000800 RID: 2048
		// (get) Token: 0x06003729 RID: 14121 RVA: 0x0004E088 File Offset: 0x0004C288
		// (set) Token: 0x0600372A RID: 14122 RVA: 0x0004E0A1 File Offset: 0x0004C2A1
		public unsafe bool bOverride_FilmShoulder
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmShoulder) & FPostProcessSettings.__PropertyMask_bOverride_FilmShoulder) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmShoulder) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmShoulder) & ~FPostProcessSettings.__PropertyMask_bOverride_FilmShoulder) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FilmShoulder : 0));
			}
		}

		// Token: 0x17000801 RID: 2049
		// (get) Token: 0x0600372B RID: 14123 RVA: 0x0004E0D1 File Offset: 0x0004C2D1
		// (set) Token: 0x0600372C RID: 14124 RVA: 0x0004E0EA File Offset: 0x0004C2EA
		public unsafe bool bOverride_FilmBlackClip
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmBlackClip) & FPostProcessSettings.__PropertyMask_bOverride_FilmBlackClip) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmBlackClip) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmBlackClip) & ~FPostProcessSettings.__PropertyMask_bOverride_FilmBlackClip) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FilmBlackClip : 0));
			}
		}

		// Token: 0x17000802 RID: 2050
		// (get) Token: 0x0600372D RID: 14125 RVA: 0x0004E11A File Offset: 0x0004C31A
		// (set) Token: 0x0600372E RID: 14126 RVA: 0x0004E133 File Offset: 0x0004C333
		public unsafe bool bOverride_FilmWhiteClip
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmWhiteClip) & FPostProcessSettings.__PropertyMask_bOverride_FilmWhiteClip) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmWhiteClip) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FilmWhiteClip) & ~FPostProcessSettings.__PropertyMask_bOverride_FilmWhiteClip) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FilmWhiteClip : 0));
			}
		}

		// Token: 0x17000803 RID: 2051
		// (get) Token: 0x0600372F RID: 14127 RVA: 0x0004E163 File Offset: 0x0004C363
		// (set) Token: 0x06003730 RID: 14128 RVA: 0x0004E17C File Offset: 0x0004C37C
		public unsafe bool bOverride_SceneColorTint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneColorTint) & FPostProcessSettings.__PropertyMask_bOverride_SceneColorTint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneColorTint) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneColorTint) & ~FPostProcessSettings.__PropertyMask_bOverride_SceneColorTint) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SceneColorTint : 0));
			}
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06003731 RID: 14129 RVA: 0x0004E1AC File Offset: 0x0004C3AC
		// (set) Token: 0x06003732 RID: 14130 RVA: 0x0004E1C5 File Offset: 0x0004C3C5
		public unsafe bool bOverride_DecalSaturation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DecalSaturation) & FPostProcessSettings.__PropertyMask_bOverride_DecalSaturation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DecalSaturation) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DecalSaturation) & ~FPostProcessSettings.__PropertyMask_bOverride_DecalSaturation) | (value ? FPostProcessSettings.__PropertyMask_bOverride_DecalSaturation : 0));
			}
		}

		// Token: 0x17000805 RID: 2053
		// (get) Token: 0x06003733 RID: 14131 RVA: 0x0004E1F5 File Offset: 0x0004C3F5
		// (set) Token: 0x06003734 RID: 14132 RVA: 0x0004E20E File Offset: 0x0004C40E
		public unsafe bool bOverride_DecalOpacity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DecalOpacity) & FPostProcessSettings.__PropertyMask_bOverride_DecalOpacity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DecalOpacity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DecalOpacity) & ~FPostProcessSettings.__PropertyMask_bOverride_DecalOpacity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_DecalOpacity : 0));
			}
		}

		// Token: 0x17000806 RID: 2054
		// (get) Token: 0x06003735 RID: 14133 RVA: 0x0004E23E File Offset: 0x0004C43E
		// (set) Token: 0x06003736 RID: 14134 RVA: 0x0004E257 File Offset: 0x0004C457
		public unsafe bool bOverride_TranslucentColorTint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TranslucentColorTint) & FPostProcessSettings.__PropertyMask_bOverride_TranslucentColorTint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TranslucentColorTint) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TranslucentColorTint) & ~FPostProcessSettings.__PropertyMask_bOverride_TranslucentColorTint) | (value ? FPostProcessSettings.__PropertyMask_bOverride_TranslucentColorTint : 0));
			}
		}

		// Token: 0x17000807 RID: 2055
		// (get) Token: 0x06003737 RID: 14135 RVA: 0x0004E287 File Offset: 0x0004C487
		// (set) Token: 0x06003738 RID: 14136 RVA: 0x0004E2A0 File Offset: 0x0004C4A0
		public unsafe bool bOverride_SceneColorDesaturate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneColorDesaturate) & FPostProcessSettings.__PropertyMask_bOverride_SceneColorDesaturate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneColorDesaturate) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneColorDesaturate) & ~FPostProcessSettings.__PropertyMask_bOverride_SceneColorDesaturate) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SceneColorDesaturate : 0));
			}
		}

		// Token: 0x17000808 RID: 2056
		// (get) Token: 0x06003739 RID: 14137 RVA: 0x0004E2D0 File Offset: 0x0004C4D0
		// (set) Token: 0x0600373A RID: 14138 RVA: 0x0004E2E9 File Offset: 0x0004C4E9
		public unsafe bool bOverride_SceneObjectSaturation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneObjectSaturation) & FPostProcessSettings.__PropertyMask_bOverride_SceneObjectSaturation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneObjectSaturation) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneObjectSaturation) & ~FPostProcessSettings.__PropertyMask_bOverride_SceneObjectSaturation) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SceneObjectSaturation : 0));
			}
		}

		// Token: 0x17000809 RID: 2057
		// (get) Token: 0x0600373B RID: 14139 RVA: 0x0004E319 File Offset: 0x0004C519
		// (set) Token: 0x0600373C RID: 14140 RVA: 0x0004E332 File Offset: 0x0004C532
		public unsafe bool bOverride_SceneColorClear
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneColorClear) & FPostProcessSettings.__PropertyMask_bOverride_SceneColorClear) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneColorClear) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneColorClear) & ~FPostProcessSettings.__PropertyMask_bOverride_SceneColorClear) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SceneColorClear : 0));
			}
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x0600373D RID: 14141 RVA: 0x0004E362 File Offset: 0x0004C562
		// (set) Token: 0x0600373E RID: 14142 RVA: 0x0004E37B File Offset: 0x0004C57B
		public unsafe bool bOverride_SceneColorClearColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneColorClearColor) & FPostProcessSettings.__PropertyMask_bOverride_SceneColorClearColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneColorClearColor) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneColorClearColor) & ~FPostProcessSettings.__PropertyMask_bOverride_SceneColorClearColor) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SceneColorClearColor : 0));
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x0600373F RID: 14143 RVA: 0x0004E3AB File Offset: 0x0004C5AB
		// (set) Token: 0x06003740 RID: 14144 RVA: 0x0004E3C4 File Offset: 0x0004C5C4
		public unsafe bool bOverride_SceneColorClearCenter
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneColorClearCenter) & FPostProcessSettings.__PropertyMask_bOverride_SceneColorClearCenter) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneColorClearCenter) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneColorClearCenter) & ~FPostProcessSettings.__PropertyMask_bOverride_SceneColorClearCenter) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SceneColorClearCenter : 0));
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06003741 RID: 14145 RVA: 0x0004E3F4 File Offset: 0x0004C5F4
		// (set) Token: 0x06003742 RID: 14146 RVA: 0x0004E40D File Offset: 0x0004C60D
		public unsafe bool bOverride_SceneColorClearRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneColorClearRadius) & FPostProcessSettings.__PropertyMask_bOverride_SceneColorClearRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneColorClearRadius) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneColorClearRadius) & ~FPostProcessSettings.__PropertyMask_bOverride_SceneColorClearRadius) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SceneColorClearRadius : 0));
			}
		}

		// Token: 0x1700080D RID: 2061
		// (get) Token: 0x06003743 RID: 14147 RVA: 0x0004E43D File Offset: 0x0004C63D
		// (set) Token: 0x06003744 RID: 14148 RVA: 0x0004E456 File Offset: 0x0004C656
		public unsafe bool bOverride_SceneColorClearFadeDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneColorClearFadeDistance) & FPostProcessSettings.__PropertyMask_bOverride_SceneColorClearFadeDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneColorClearFadeDistance) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneColorClearFadeDistance) & ~FPostProcessSettings.__PropertyMask_bOverride_SceneColorClearFadeDistance) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SceneColorClearFadeDistance : 0));
			}
		}

		// Token: 0x1700080E RID: 2062
		// (get) Token: 0x06003745 RID: 14149 RVA: 0x0004E486 File Offset: 0x0004C686
		// (set) Token: 0x06003746 RID: 14150 RVA: 0x0004E49F File Offset: 0x0004C69F
		public unsafe bool bOverride_TranslucentColorDesaturate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TranslucentColorDesaturate) & FPostProcessSettings.__PropertyMask_bOverride_TranslucentColorDesaturate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TranslucentColorDesaturate) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TranslucentColorDesaturate) & ~FPostProcessSettings.__PropertyMask_bOverride_TranslucentColorDesaturate) | (value ? FPostProcessSettings.__PropertyMask_bOverride_TranslucentColorDesaturate : 0));
			}
		}

		// Token: 0x1700080F RID: 2063
		// (get) Token: 0x06003747 RID: 14151 RVA: 0x0004E4CF File Offset: 0x0004C6CF
		// (set) Token: 0x06003748 RID: 14152 RVA: 0x0004E4E8 File Offset: 0x0004C6E8
		public unsafe bool bOverride_FightTranslucentNoDesaturate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FightTranslucentNoDesaturate) & FPostProcessSettings.__PropertyMask_bOverride_FightTranslucentNoDesaturate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FightTranslucentNoDesaturate) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FightTranslucentNoDesaturate) & ~FPostProcessSettings.__PropertyMask_bOverride_FightTranslucentNoDesaturate) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FightTranslucentNoDesaturate : 0));
			}
		}

		// Token: 0x17000810 RID: 2064
		// (get) Token: 0x06003749 RID: 14153 RVA: 0x0004E518 File Offset: 0x0004C718
		// (set) Token: 0x0600374A RID: 14154 RVA: 0x0004E531 File Offset: 0x0004C731
		public unsafe bool bOverride_SceneTranslucentColorTint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneTranslucentColorTint) & FPostProcessSettings.__PropertyMask_bOverride_SceneTranslucentColorTint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneTranslucentColorTint) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneTranslucentColorTint) & ~FPostProcessSettings.__PropertyMask_bOverride_SceneTranslucentColorTint) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SceneTranslucentColorTint : 0));
			}
		}

		// Token: 0x17000811 RID: 2065
		// (get) Token: 0x0600374B RID: 14155 RVA: 0x0004E561 File Offset: 0x0004C761
		// (set) Token: 0x0600374C RID: 14156 RVA: 0x0004E57A File Offset: 0x0004C77A
		public unsafe bool bOverride_SceneEmissiveTint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneEmissiveTint) & FPostProcessSettings.__PropertyMask_bOverride_SceneEmissiveTint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneEmissiveTint) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneEmissiveTint) & ~FPostProcessSettings.__PropertyMask_bOverride_SceneEmissiveTint) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SceneEmissiveTint : 0));
			}
		}

		// Token: 0x17000812 RID: 2066
		// (get) Token: 0x0600374D RID: 14157 RVA: 0x0004E5AA File Offset: 0x0004C7AA
		// (set) Token: 0x0600374E RID: 14158 RVA: 0x0004E5C3 File Offset: 0x0004C7C3
		public unsafe bool bOverride_SceneTranslucentColorDesaturate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneTranslucentColorDesaturate) & FPostProcessSettings.__PropertyMask_bOverride_SceneTranslucentColorDesaturate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneTranslucentColorDesaturate) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneTranslucentColorDesaturate) & ~FPostProcessSettings.__PropertyMask_bOverride_SceneTranslucentColorDesaturate) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SceneTranslucentColorDesaturate : 0));
			}
		}

		// Token: 0x17000813 RID: 2067
		// (get) Token: 0x0600374F RID: 14159 RVA: 0x0004E5F3 File Offset: 0x0004C7F3
		// (set) Token: 0x06003750 RID: 14160 RVA: 0x0004E60C File Offset: 0x0004C80C
		public unsafe bool bOverride_EnableSPD
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EnableSPD) & FPostProcessSettings.__PropertyMask_bOverride_EnableSPD) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EnableSPD) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EnableSPD) & ~FPostProcessSettings.__PropertyMask_bOverride_EnableSPD) | (value ? FPostProcessSettings.__PropertyMask_bOverride_EnableSPD : 0));
			}
		}

		// Token: 0x17000814 RID: 2068
		// (get) Token: 0x06003751 RID: 14161 RVA: 0x0004E63C File Offset: 0x0004C83C
		// (set) Token: 0x06003752 RID: 14162 RVA: 0x0004E655 File Offset: 0x0004C855
		public unsafe bool bOverride_SceneFringeIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneFringeIntensity) & FPostProcessSettings.__PropertyMask_bOverride_SceneFringeIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneFringeIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SceneFringeIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_SceneFringeIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SceneFringeIntensity : 0));
			}
		}

		// Token: 0x17000815 RID: 2069
		// (get) Token: 0x06003753 RID: 14163 RVA: 0x0004E685 File Offset: 0x0004C885
		// (set) Token: 0x06003754 RID: 14164 RVA: 0x0004E69E File Offset: 0x0004C89E
		public unsafe bool bOverride_ChromaticAberrationStartOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ChromaticAberrationStartOffset) & FPostProcessSettings.__PropertyMask_bOverride_ChromaticAberrationStartOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ChromaticAberrationStartOffset) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ChromaticAberrationStartOffset) & ~FPostProcessSettings.__PropertyMask_bOverride_ChromaticAberrationStartOffset) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ChromaticAberrationStartOffset : 0));
			}
		}

		// Token: 0x17000816 RID: 2070
		// (get) Token: 0x06003755 RID: 14165 RVA: 0x0004E6CE File Offset: 0x0004C8CE
		// (set) Token: 0x06003756 RID: 14166 RVA: 0x0004E6E7 File Offset: 0x0004C8E7
		public unsafe bool bOverride_BaoChromaticAberrationIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BaoChromaticAberrationIntensity) & FPostProcessSettings.__PropertyMask_bOverride_BaoChromaticAberrationIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BaoChromaticAberrationIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BaoChromaticAberrationIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_BaoChromaticAberrationIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_BaoChromaticAberrationIntensity : 0));
			}
		}

		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x06003757 RID: 14167 RVA: 0x0004E717 File Offset: 0x0004C917
		// (set) Token: 0x06003758 RID: 14168 RVA: 0x0004E730 File Offset: 0x0004C930
		public unsafe bool bOverride_BaoChromaticAberrationMaskCenter
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BaoChromaticAberrationMaskCenter) & FPostProcessSettings.__PropertyMask_bOverride_BaoChromaticAberrationMaskCenter) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BaoChromaticAberrationMaskCenter) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BaoChromaticAberrationMaskCenter) & ~FPostProcessSettings.__PropertyMask_bOverride_BaoChromaticAberrationMaskCenter) | (value ? FPostProcessSettings.__PropertyMask_bOverride_BaoChromaticAberrationMaskCenter : 0));
			}
		}

		// Token: 0x17000818 RID: 2072
		// (get) Token: 0x06003759 RID: 14169 RVA: 0x0004E760 File Offset: 0x0004C960
		// (set) Token: 0x0600375A RID: 14170 RVA: 0x0004E779 File Offset: 0x0004C979
		public unsafe bool bOverride_BaoChromaticAberrationYScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BaoChromaticAberrationYScale) & FPostProcessSettings.__PropertyMask_bOverride_BaoChromaticAberrationYScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BaoChromaticAberrationYScale) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BaoChromaticAberrationYScale) & ~FPostProcessSettings.__PropertyMask_bOverride_BaoChromaticAberrationYScale) | (value ? FPostProcessSettings.__PropertyMask_bOverride_BaoChromaticAberrationYScale : 0));
			}
		}

		// Token: 0x17000819 RID: 2073
		// (get) Token: 0x0600375B RID: 14171 RVA: 0x0004E7A9 File Offset: 0x0004C9A9
		// (set) Token: 0x0600375C RID: 14172 RVA: 0x0004E7C2 File Offset: 0x0004C9C2
		public unsafe bool bOverride_BaoChromaticAberrationYPan
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BaoChromaticAberrationYPan) & FPostProcessSettings.__PropertyMask_bOverride_BaoChromaticAberrationYPan) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BaoChromaticAberrationYPan) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BaoChromaticAberrationYPan) & ~FPostProcessSettings.__PropertyMask_bOverride_BaoChromaticAberrationYPan) | (value ? FPostProcessSettings.__PropertyMask_bOverride_BaoChromaticAberrationYPan : 0));
			}
		}

		// Token: 0x1700081A RID: 2074
		// (get) Token: 0x0600375D RID: 14173 RVA: 0x0004E7F2 File Offset: 0x0004C9F2
		// (set) Token: 0x0600375E RID: 14174 RVA: 0x0004E80B File Offset: 0x0004CA0B
		public unsafe bool bOverride_bMegaLights
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_bMegaLights) & FPostProcessSettings.__PropertyMask_bOverride_bMegaLights) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_bMegaLights) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_bMegaLights) & ~FPostProcessSettings.__PropertyMask_bOverride_bMegaLights) | (value ? FPostProcessSettings.__PropertyMask_bOverride_bMegaLights : 0));
			}
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x0600375F RID: 14175 RVA: 0x0004E83B File Offset: 0x0004CA3B
		// (set) Token: 0x06003760 RID: 14176 RVA: 0x0004E854 File Offset: 0x0004CA54
		public unsafe bool bOverride_AmbientCubemapTint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientCubemapTint) & FPostProcessSettings.__PropertyMask_bOverride_AmbientCubemapTint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientCubemapTint) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientCubemapTint) & ~FPostProcessSettings.__PropertyMask_bOverride_AmbientCubemapTint) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AmbientCubemapTint : 0));
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06003761 RID: 14177 RVA: 0x0004E884 File Offset: 0x0004CA84
		// (set) Token: 0x06003762 RID: 14178 RVA: 0x0004E89D File Offset: 0x0004CA9D
		public unsafe bool bOverride_AmbientCubemapIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientCubemapIntensity) & FPostProcessSettings.__PropertyMask_bOverride_AmbientCubemapIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientCubemapIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientCubemapIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_AmbientCubemapIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AmbientCubemapIntensity : 0));
			}
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06003763 RID: 14179 RVA: 0x0004E8CD File Offset: 0x0004CACD
		// (set) Token: 0x06003764 RID: 14180 RVA: 0x0004E8E6 File Offset: 0x0004CAE6
		public unsafe bool bOverride_BloomMethod
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomMethod) & FPostProcessSettings.__PropertyMask_bOverride_BloomMethod) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomMethod) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomMethod) & ~FPostProcessSettings.__PropertyMask_bOverride_BloomMethod) | (value ? FPostProcessSettings.__PropertyMask_bOverride_BloomMethod : 0));
			}
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06003765 RID: 14181 RVA: 0x0004E916 File Offset: 0x0004CB16
		// (set) Token: 0x06003766 RID: 14182 RVA: 0x0004E92F File Offset: 0x0004CB2F
		public unsafe bool bOverride_BloomIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomIntensity) & FPostProcessSettings.__PropertyMask_bOverride_BloomIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_BloomIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_BloomIntensity : 0));
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06003767 RID: 14183 RVA: 0x0004E95F File Offset: 0x0004CB5F
		// (set) Token: 0x06003768 RID: 14184 RVA: 0x0004E978 File Offset: 0x0004CB78
		public unsafe bool bOverride_KuroFoliageMaterialAO
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroFoliageMaterialAO) & FPostProcessSettings.__PropertyMask_bOverride_KuroFoliageMaterialAO) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroFoliageMaterialAO) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroFoliageMaterialAO) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroFoliageMaterialAO) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroFoliageMaterialAO : 0));
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06003769 RID: 14185 RVA: 0x0004E9A8 File Offset: 0x0004CBA8
		// (set) Token: 0x0600376A RID: 14186 RVA: 0x0004E9C1 File Offset: 0x0004CBC1
		public unsafe bool bOverride_KuroFoliageScreenSpaceAO
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroFoliageScreenSpaceAO) & FPostProcessSettings.__PropertyMask_bOverride_KuroFoliageScreenSpaceAO) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroFoliageScreenSpaceAO) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroFoliageScreenSpaceAO) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroFoliageScreenSpaceAO) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroFoliageScreenSpaceAO : 0));
			}
		}

		// Token: 0x17000821 RID: 2081
		// (get) Token: 0x0600376B RID: 14187 RVA: 0x0004E9F1 File Offset: 0x0004CBF1
		// (set) Token: 0x0600376C RID: 14188 RVA: 0x0004EA0A File Offset: 0x0004CC0A
		public unsafe bool bOverride_UseFixCharacterRim
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_UseFixCharacterRim) & FPostProcessSettings.__PropertyMask_bOverride_UseFixCharacterRim) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_UseFixCharacterRim) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_UseFixCharacterRim) & ~FPostProcessSettings.__PropertyMask_bOverride_UseFixCharacterRim) | (value ? FPostProcessSettings.__PropertyMask_bOverride_UseFixCharacterRim : 0));
			}
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x0600376D RID: 14189 RVA: 0x0004EA3A File Offset: 0x0004CC3A
		// (set) Token: 0x0600376E RID: 14190 RVA: 0x0004EA53 File Offset: 0x0004CC53
		public unsafe bool bOverride_FixCharacterRimAngleV
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleV) & FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleV) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleV) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleV) & ~FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleV) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleV : 0));
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x0600376F RID: 14191 RVA: 0x0004EA83 File Offset: 0x0004CC83
		// (set) Token: 0x06003770 RID: 14192 RVA: 0x0004EA9C File Offset: 0x0004CC9C
		public unsafe bool bOverride_FixCharacterRimAngleH
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleH) & FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleH) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleH) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleH) & ~FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleH) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleH : 0));
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06003771 RID: 14193 RVA: 0x0004EACC File Offset: 0x0004CCCC
		// (set) Token: 0x06003772 RID: 14194 RVA: 0x0004EAE5 File Offset: 0x0004CCE5
		public unsafe bool bOverride_UseCustomRim
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_UseCustomRim) & FPostProcessSettings.__PropertyMask_bOverride_UseCustomRim) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_UseCustomRim) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_UseCustomRim) & ~FPostProcessSettings.__PropertyMask_bOverride_UseCustomRim) | (value ? FPostProcessSettings.__PropertyMask_bOverride_UseCustomRim : 0));
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06003773 RID: 14195 RVA: 0x0004EB15 File Offset: 0x0004CD15
		// (set) Token: 0x06003774 RID: 14196 RVA: 0x0004EB2E File Offset: 0x0004CD2E
		public unsafe bool bOverride_CustomRimColor_Stencil1
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_CustomRimColor_Stencil1) & FPostProcessSettings.__PropertyMask_bOverride_CustomRimColor_Stencil1) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_CustomRimColor_Stencil1) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_CustomRimColor_Stencil1) & ~FPostProcessSettings.__PropertyMask_bOverride_CustomRimColor_Stencil1) | (value ? FPostProcessSettings.__PropertyMask_bOverride_CustomRimColor_Stencil1 : 0));
			}
		}

		// Token: 0x17000826 RID: 2086
		// (get) Token: 0x06003775 RID: 14197 RVA: 0x0004EB5E File Offset: 0x0004CD5E
		// (set) Token: 0x06003776 RID: 14198 RVA: 0x0004EB77 File Offset: 0x0004CD77
		public unsafe bool bOverride_FixCharacterRimAngleV_Stencil1
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleV_Stencil1) & FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleV_Stencil1) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleV_Stencil1) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleV_Stencil1) & ~FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleV_Stencil1) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleV_Stencil1 : 0));
			}
		}

		// Token: 0x17000827 RID: 2087
		// (get) Token: 0x06003777 RID: 14199 RVA: 0x0004EBA7 File Offset: 0x0004CDA7
		// (set) Token: 0x06003778 RID: 14200 RVA: 0x0004EBC0 File Offset: 0x0004CDC0
		public unsafe bool bOverride_FixCharacterRimAngleH_Stencil1
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleH_Stencil1) & FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleH_Stencil1) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleH_Stencil1) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleH_Stencil1) & ~FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleH_Stencil1) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleH_Stencil1 : 0));
			}
		}

		// Token: 0x17000828 RID: 2088
		// (get) Token: 0x06003779 RID: 14201 RVA: 0x0004EBF0 File Offset: 0x0004CDF0
		// (set) Token: 0x0600377A RID: 14202 RVA: 0x0004EC09 File Offset: 0x0004CE09
		public unsafe bool bOverride_CustomRimColor_Stencil2
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_CustomRimColor_Stencil2) & FPostProcessSettings.__PropertyMask_bOverride_CustomRimColor_Stencil2) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_CustomRimColor_Stencil2) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_CustomRimColor_Stencil2) & ~FPostProcessSettings.__PropertyMask_bOverride_CustomRimColor_Stencil2) | (value ? FPostProcessSettings.__PropertyMask_bOverride_CustomRimColor_Stencil2 : 0));
			}
		}

		// Token: 0x17000829 RID: 2089
		// (get) Token: 0x0600377B RID: 14203 RVA: 0x0004EC39 File Offset: 0x0004CE39
		// (set) Token: 0x0600377C RID: 14204 RVA: 0x0004EC52 File Offset: 0x0004CE52
		public unsafe bool bOverride_FixCharacterRimAngleV_Stencil2
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleV_Stencil2) & FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleV_Stencil2) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleV_Stencil2) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleV_Stencil2) & ~FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleV_Stencil2) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleV_Stencil2 : 0));
			}
		}

		// Token: 0x1700082A RID: 2090
		// (get) Token: 0x0600377D RID: 14205 RVA: 0x0004EC82 File Offset: 0x0004CE82
		// (set) Token: 0x0600377E RID: 14206 RVA: 0x0004EC9B File Offset: 0x0004CE9B
		public unsafe bool bOverride_FixCharacterRimAngleH_Stencil2
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleH_Stencil2) & FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleH_Stencil2) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleH_Stencil2) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleH_Stencil2) & ~FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleH_Stencil2) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleH_Stencil2 : 0));
			}
		}

		// Token: 0x1700082B RID: 2091
		// (get) Token: 0x0600377F RID: 14207 RVA: 0x0004ECCB File Offset: 0x0004CECB
		// (set) Token: 0x06003780 RID: 14208 RVA: 0x0004ECE4 File Offset: 0x0004CEE4
		public unsafe bool bOverride_CustomRimColor_Stencil3
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_CustomRimColor_Stencil3) & FPostProcessSettings.__PropertyMask_bOverride_CustomRimColor_Stencil3) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_CustomRimColor_Stencil3) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_CustomRimColor_Stencil3) & ~FPostProcessSettings.__PropertyMask_bOverride_CustomRimColor_Stencil3) | (value ? FPostProcessSettings.__PropertyMask_bOverride_CustomRimColor_Stencil3 : 0));
			}
		}

		// Token: 0x1700082C RID: 2092
		// (get) Token: 0x06003781 RID: 14209 RVA: 0x0004ED14 File Offset: 0x0004CF14
		// (set) Token: 0x06003782 RID: 14210 RVA: 0x0004ED2D File Offset: 0x0004CF2D
		public unsafe bool bOverride_FixCharacterRimAngleV_Stencil3
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleV_Stencil3) & FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleV_Stencil3) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleV_Stencil3) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleV_Stencil3) & ~FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleV_Stencil3) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleV_Stencil3 : 0));
			}
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06003783 RID: 14211 RVA: 0x0004ED5D File Offset: 0x0004CF5D
		// (set) Token: 0x06003784 RID: 14212 RVA: 0x0004ED76 File Offset: 0x0004CF76
		public unsafe bool bOverride_FixCharacterRimAngleH_Stencil3
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleH_Stencil3) & FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleH_Stencil3) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleH_Stencil3) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FixCharacterRimAngleH_Stencil3) & ~FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleH_Stencil3) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FixCharacterRimAngleH_Stencil3 : 0));
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06003785 RID: 14213 RVA: 0x0004EDA6 File Offset: 0x0004CFA6
		// (set) Token: 0x06003786 RID: 14214 RVA: 0x0004EDBF File Offset: 0x0004CFBF
		public unsafe bool bOverride_KuroBloomIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomIntensity) & FPostProcessSettings.__PropertyMask_bOverride_KuroBloomIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroBloomIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroBloomIntensity : 0));
			}
		}

		// Token: 0x1700082F RID: 2095
		// (get) Token: 0x06003787 RID: 14215 RVA: 0x0004EDEF File Offset: 0x0004CFEF
		// (set) Token: 0x06003788 RID: 14216 RVA: 0x0004EE08 File Offset: 0x0004D008
		public unsafe bool bOverride_KuroBloomThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomThreshold) & FPostProcessSettings.__PropertyMask_bOverride_KuroBloomThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomThreshold) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomThreshold) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroBloomThreshold) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroBloomThreshold : 0));
			}
		}

		// Token: 0x17000830 RID: 2096
		// (get) Token: 0x06003789 RID: 14217 RVA: 0x0004EE38 File Offset: 0x0004D038
		// (set) Token: 0x0600378A RID: 14218 RVA: 0x0004EE51 File Offset: 0x0004D051
		public unsafe bool bOverride_EnableSplitCharBloom
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EnableSplitCharBloom) & FPostProcessSettings.__PropertyMask_bOverride_EnableSplitCharBloom) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EnableSplitCharBloom) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EnableSplitCharBloom) & ~FPostProcessSettings.__PropertyMask_bOverride_EnableSplitCharBloom) | (value ? FPostProcessSettings.__PropertyMask_bOverride_EnableSplitCharBloom : 0));
			}
		}

		// Token: 0x17000831 RID: 2097
		// (get) Token: 0x0600378B RID: 14219 RVA: 0x0004EE81 File Offset: 0x0004D081
		// (set) Token: 0x0600378C RID: 14220 RVA: 0x0004EE9A File Offset: 0x0004D09A
		public unsafe bool bOverride_EnableExtraCharBloomOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EnableExtraCharBloomOffset) & FPostProcessSettings.__PropertyMask_bOverride_EnableExtraCharBloomOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EnableExtraCharBloomOffset) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EnableExtraCharBloomOffset) & ~FPostProcessSettings.__PropertyMask_bOverride_EnableExtraCharBloomOffset) | (value ? FPostProcessSettings.__PropertyMask_bOverride_EnableExtraCharBloomOffset : 0));
			}
		}

		// Token: 0x17000832 RID: 2098
		// (get) Token: 0x0600378D RID: 14221 RVA: 0x0004EECA File Offset: 0x0004D0CA
		// (set) Token: 0x0600378E RID: 14222 RVA: 0x0004EEE3 File Offset: 0x0004D0E3
		public unsafe bool bOverride_KuroCharacterBloomIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroCharacterBloomIntensity) & FPostProcessSettings.__PropertyMask_bOverride_KuroCharacterBloomIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroCharacterBloomIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroCharacterBloomIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroCharacterBloomIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroCharacterBloomIntensity : 0));
			}
		}

		// Token: 0x17000833 RID: 2099
		// (get) Token: 0x0600378F RID: 14223 RVA: 0x0004EF13 File Offset: 0x0004D113
		// (set) Token: 0x06003790 RID: 14224 RVA: 0x0004EF2C File Offset: 0x0004D12C
		public unsafe bool bOverride_KuroCharacterBloomThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroCharacterBloomThreshold) & FPostProcessSettings.__PropertyMask_bOverride_KuroCharacterBloomThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroCharacterBloomThreshold) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroCharacterBloomThreshold) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroCharacterBloomThreshold) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroCharacterBloomThreshold : 0));
			}
		}

		// Token: 0x17000834 RID: 2100
		// (get) Token: 0x06003791 RID: 14225 RVA: 0x0004EF5C File Offset: 0x0004D15C
		// (set) Token: 0x06003792 RID: 14226 RVA: 0x0004EF75 File Offset: 0x0004D175
		public unsafe bool bOverride_KuroExtraCharacterBloomIntensityOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroExtraCharacterBloomIntensityOffset) & FPostProcessSettings.__PropertyMask_bOverride_KuroExtraCharacterBloomIntensityOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroExtraCharacterBloomIntensityOffset) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroExtraCharacterBloomIntensityOffset) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroExtraCharacterBloomIntensityOffset) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroExtraCharacterBloomIntensityOffset : 0));
			}
		}

		// Token: 0x17000835 RID: 2101
		// (get) Token: 0x06003793 RID: 14227 RVA: 0x0004EFA5 File Offset: 0x0004D1A5
		// (set) Token: 0x06003794 RID: 14228 RVA: 0x0004EFBE File Offset: 0x0004D1BE
		public unsafe bool bOverride_KuroExtraCharacterBloomThresholdOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroExtraCharacterBloomThresholdOffset) & FPostProcessSettings.__PropertyMask_bOverride_KuroExtraCharacterBloomThresholdOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroExtraCharacterBloomThresholdOffset) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroExtraCharacterBloomThresholdOffset) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroExtraCharacterBloomThresholdOffset) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroExtraCharacterBloomThresholdOffset : 0));
			}
		}

		// Token: 0x17000836 RID: 2102
		// (get) Token: 0x06003795 RID: 14229 RVA: 0x0004EFEE File Offset: 0x0004D1EE
		// (set) Token: 0x06003796 RID: 14230 RVA: 0x0004F007 File Offset: 0x0004D207
		public unsafe bool bOverride_SunDirBloomIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SunDirBloomIntensity) & FPostProcessSettings.__PropertyMask_bOverride_SunDirBloomIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SunDirBloomIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SunDirBloomIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_SunDirBloomIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SunDirBloomIntensity : 0));
			}
		}

		// Token: 0x17000837 RID: 2103
		// (get) Token: 0x06003797 RID: 14231 RVA: 0x0004F037 File Offset: 0x0004D237
		// (set) Token: 0x06003798 RID: 14232 RVA: 0x0004F050 File Offset: 0x0004D250
		public unsafe bool bOverride_KuroBloomCombineParameter
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomCombineParameter) & FPostProcessSettings.__PropertyMask_bOverride_KuroBloomCombineParameter) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomCombineParameter) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomCombineParameter) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroBloomCombineParameter) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroBloomCombineParameter : 0));
			}
		}

		// Token: 0x17000838 RID: 2104
		// (get) Token: 0x06003799 RID: 14233 RVA: 0x0004F080 File Offset: 0x0004D280
		// (set) Token: 0x0600379A RID: 14234 RVA: 0x0004F099 File Offset: 0x0004D299
		public unsafe bool bOverride_KuroBloomStreakIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomStreakIntensity) & FPostProcessSettings.__PropertyMask_bOverride_KuroBloomStreakIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomStreakIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomStreakIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroBloomStreakIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroBloomStreakIntensity : 0));
			}
		}

		// Token: 0x17000839 RID: 2105
		// (get) Token: 0x0600379B RID: 14235 RVA: 0x0004F0C9 File Offset: 0x0004D2C9
		// (set) Token: 0x0600379C RID: 14236 RVA: 0x0004F0E2 File Offset: 0x0004D2E2
		public unsafe bool bOverride_KuroBloomStreakThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomStreakThreshold) & FPostProcessSettings.__PropertyMask_bOverride_KuroBloomStreakThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomStreakThreshold) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomStreakThreshold) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroBloomStreakThreshold) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroBloomStreakThreshold : 0));
			}
		}

		// Token: 0x1700083A RID: 2106
		// (get) Token: 0x0600379D RID: 14237 RVA: 0x0004F112 File Offset: 0x0004D312
		// (set) Token: 0x0600379E RID: 14238 RVA: 0x0004F12B File Offset: 0x0004D32B
		public unsafe bool bOverride_TranslucentBloomStreakIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TranslucentBloomStreakIntensity) & FPostProcessSettings.__PropertyMask_bOverride_TranslucentBloomStreakIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TranslucentBloomStreakIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TranslucentBloomStreakIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_TranslucentBloomStreakIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_TranslucentBloomStreakIntensity : 0));
			}
		}

		// Token: 0x1700083B RID: 2107
		// (get) Token: 0x0600379F RID: 14239 RVA: 0x0004F15B File Offset: 0x0004D35B
		// (set) Token: 0x060037A0 RID: 14240 RVA: 0x0004F174 File Offset: 0x0004D374
		public unsafe bool bOverride_TranslucentBloomStreakThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TranslucentBloomStreakThreshold) & FPostProcessSettings.__PropertyMask_bOverride_TranslucentBloomStreakThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TranslucentBloomStreakThreshold) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TranslucentBloomStreakThreshold) & ~FPostProcessSettings.__PropertyMask_bOverride_TranslucentBloomStreakThreshold) | (value ? FPostProcessSettings.__PropertyMask_bOverride_TranslucentBloomStreakThreshold : 0));
			}
		}

		// Token: 0x1700083C RID: 2108
		// (get) Token: 0x060037A1 RID: 14241 RVA: 0x0004F1A4 File Offset: 0x0004D3A4
		// (set) Token: 0x060037A2 RID: 14242 RVA: 0x0004F1BD File Offset: 0x0004D3BD
		public unsafe bool bOverride_KuroBloomStreakLength
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomStreakLength) & FPostProcessSettings.__PropertyMask_bOverride_KuroBloomStreakLength) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomStreakLength) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomStreakLength) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroBloomStreakLength) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroBloomStreakLength : 0));
			}
		}

		// Token: 0x1700083D RID: 2109
		// (get) Token: 0x060037A3 RID: 14243 RVA: 0x0004F1ED File Offset: 0x0004D3ED
		// (set) Token: 0x060037A4 RID: 14244 RVA: 0x0004F206 File Offset: 0x0004D406
		public unsafe bool bOverride_KuroBloomStreakMipLevel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomStreakMipLevel) & FPostProcessSettings.__PropertyMask_bOverride_KuroBloomStreakMipLevel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomStreakMipLevel) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomStreakMipLevel) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroBloomStreakMipLevel) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroBloomStreakMipLevel : 0));
			}
		}

		// Token: 0x1700083E RID: 2110
		// (get) Token: 0x060037A5 RID: 14245 RVA: 0x0004F236 File Offset: 0x0004D436
		// (set) Token: 0x060037A6 RID: 14246 RVA: 0x0004F24F File Offset: 0x0004D44F
		public unsafe bool bOverride_KuroBloomStreakRatio
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomStreakRatio) & FPostProcessSettings.__PropertyMask_bOverride_KuroBloomStreakRatio) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomStreakRatio) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomStreakRatio) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroBloomStreakRatio) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroBloomStreakRatio : 0));
			}
		}

		// Token: 0x1700083F RID: 2111
		// (get) Token: 0x060037A7 RID: 14247 RVA: 0x0004F27F File Offset: 0x0004D47F
		// (set) Token: 0x060037A8 RID: 14248 RVA: 0x0004F298 File Offset: 0x0004D498
		public unsafe bool bOverride_KuroBloomStreakOrientation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomStreakOrientation) & FPostProcessSettings.__PropertyMask_bOverride_KuroBloomStreakOrientation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomStreakOrientation) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroBloomStreakOrientation) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroBloomStreakOrientation) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroBloomStreakOrientation : 0));
			}
		}

		// Token: 0x17000840 RID: 2112
		// (get) Token: 0x060037A9 RID: 14249 RVA: 0x0004F2C8 File Offset: 0x0004D4C8
		// (set) Token: 0x060037AA RID: 14250 RVA: 0x0004F2E1 File Offset: 0x0004D4E1
		public unsafe bool bOverride_BlackWhiteFlashIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BlackWhiteFlashIntensity) & FPostProcessSettings.__PropertyMask_bOverride_BlackWhiteFlashIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BlackWhiteFlashIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BlackWhiteFlashIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_BlackWhiteFlashIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_BlackWhiteFlashIntensity : 0));
			}
		}

		// Token: 0x17000841 RID: 2113
		// (get) Token: 0x060037AB RID: 14251 RVA: 0x0004F311 File Offset: 0x0004D511
		// (set) Token: 0x060037AC RID: 14252 RVA: 0x0004F32A File Offset: 0x0004D52A
		public unsafe bool bOverride_BlackWhiteFlashFactor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BlackWhiteFlashFactor) & FPostProcessSettings.__PropertyMask_bOverride_BlackWhiteFlashFactor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BlackWhiteFlashFactor) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BlackWhiteFlashFactor) & ~FPostProcessSettings.__PropertyMask_bOverride_BlackWhiteFlashFactor) | (value ? FPostProcessSettings.__PropertyMask_bOverride_BlackWhiteFlashFactor : 0));
			}
		}

		// Token: 0x17000842 RID: 2114
		// (get) Token: 0x060037AD RID: 14253 RVA: 0x0004F35A File Offset: 0x0004D55A
		// (set) Token: 0x060037AE RID: 14254 RVA: 0x0004F373 File Offset: 0x0004D573
		public unsafe bool bOverride_BlackWhiteFlashThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BlackWhiteFlashThreshold) & FPostProcessSettings.__PropertyMask_bOverride_BlackWhiteFlashThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BlackWhiteFlashThreshold) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BlackWhiteFlashThreshold) & ~FPostProcessSettings.__PropertyMask_bOverride_BlackWhiteFlashThreshold) | (value ? FPostProcessSettings.__PropertyMask_bOverride_BlackWhiteFlashThreshold : 0));
			}
		}

		// Token: 0x17000843 RID: 2115
		// (get) Token: 0x060037AF RID: 14255 RVA: 0x0004F3A3 File Offset: 0x0004D5A3
		// (set) Token: 0x060037B0 RID: 14256 RVA: 0x0004F3BC File Offset: 0x0004D5BC
		public unsafe bool bOverride_BlackWhiteFlashBlackAreaColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BlackWhiteFlashBlackAreaColor) & FPostProcessSettings.__PropertyMask_bOverride_BlackWhiteFlashBlackAreaColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BlackWhiteFlashBlackAreaColor) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BlackWhiteFlashBlackAreaColor) & ~FPostProcessSettings.__PropertyMask_bOverride_BlackWhiteFlashBlackAreaColor) | (value ? FPostProcessSettings.__PropertyMask_bOverride_BlackWhiteFlashBlackAreaColor : 0));
			}
		}

		// Token: 0x17000844 RID: 2116
		// (get) Token: 0x060037B1 RID: 14257 RVA: 0x0004F3EC File Offset: 0x0004D5EC
		// (set) Token: 0x060037B2 RID: 14258 RVA: 0x0004F405 File Offset: 0x0004D605
		public unsafe bool bOverride_BlackWhiteFlashWhiteAreaColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BlackWhiteFlashWhiteAreaColor) & FPostProcessSettings.__PropertyMask_bOverride_BlackWhiteFlashWhiteAreaColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BlackWhiteFlashWhiteAreaColor) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BlackWhiteFlashWhiteAreaColor) & ~FPostProcessSettings.__PropertyMask_bOverride_BlackWhiteFlashWhiteAreaColor) | (value ? FPostProcessSettings.__PropertyMask_bOverride_BlackWhiteFlashWhiteAreaColor : 0));
			}
		}

		// Token: 0x17000845 RID: 2117
		// (get) Token: 0x060037B3 RID: 14259 RVA: 0x0004F435 File Offset: 0x0004D635
		// (set) Token: 0x060037B4 RID: 14260 RVA: 0x0004F44E File Offset: 0x0004D64E
		public unsafe bool bOverride_KuroRadialBlurIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurIntensity) & FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurIntensity : 0));
			}
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x060037B5 RID: 14261 RVA: 0x0004F47E File Offset: 0x0004D67E
		// (set) Token: 0x060037B6 RID: 14262 RVA: 0x0004F497 File Offset: 0x0004D697
		public unsafe bool bOverride_KuroRadialBlurRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurRadius) & FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurRadius) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurRadius) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurRadius) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurRadius : 0));
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x060037B7 RID: 14263 RVA: 0x0004F4C7 File Offset: 0x0004D6C7
		// (set) Token: 0x060037B8 RID: 14264 RVA: 0x0004F4E0 File Offset: 0x0004D6E0
		public unsafe bool bOverride_KuroRadialBlurHardness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurHardness) & FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurHardness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurHardness) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurHardness) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurHardness) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurHardness : 0));
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x060037B9 RID: 14265 RVA: 0x0004F510 File Offset: 0x0004D710
		// (set) Token: 0x060037BA RID: 14266 RVA: 0x0004F529 File Offset: 0x0004D729
		public unsafe bool bOverride_KuroRadialBlurCenter
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurCenter) & FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurCenter) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurCenter) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurCenter) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurCenter) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurCenter : 0));
			}
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x060037BB RID: 14267 RVA: 0x0004F559 File Offset: 0x0004D759
		// (set) Token: 0x060037BC RID: 14268 RVA: 0x0004F572 File Offset: 0x0004D772
		public unsafe bool bOverride_UseClampRadialBlurCenter
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_UseClampRadialBlurCenter) & FPostProcessSettings.__PropertyMask_bOverride_UseClampRadialBlurCenter) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_UseClampRadialBlurCenter) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_UseClampRadialBlurCenter) & ~FPostProcessSettings.__PropertyMask_bOverride_UseClampRadialBlurCenter) | (value ? FPostProcessSettings.__PropertyMask_bOverride_UseClampRadialBlurCenter : 0));
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x060037BD RID: 14269 RVA: 0x0004F5A2 File Offset: 0x0004D7A2
		// (set) Token: 0x060037BE RID: 14270 RVA: 0x0004F5BB File Offset: 0x0004D7BB
		public unsafe bool bOverride_KuroRadialBlurPassNumber
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurPassNumber) & FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurPassNumber) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurPassNumber) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurPassNumber) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurPassNumber) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurPassNumber : 0));
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x060037BF RID: 14271 RVA: 0x0004F5EB File Offset: 0x0004D7EB
		// (set) Token: 0x060037C0 RID: 14272 RVA: 0x0004F604 File Offset: 0x0004D804
		public unsafe bool bOverride_KuroRadialBlurSampleNumber
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurSampleNumber) & FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurSampleNumber) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurSampleNumber) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurSampleNumber) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurSampleNumber) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurSampleNumber : 0));
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x060037C1 RID: 14273 RVA: 0x0004F634 File Offset: 0x0004D834
		// (set) Token: 0x060037C2 RID: 14274 RVA: 0x0004F64D File Offset: 0x0004D84D
		public unsafe bool bOverride_KuroRadialBlurMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurMask) & FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurMask) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurMask) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurMask) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurMask : 0));
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x060037C3 RID: 14275 RVA: 0x0004F67D File Offset: 0x0004D87D
		// (set) Token: 0x060037C4 RID: 14276 RVA: 0x0004F696 File Offset: 0x0004D896
		public unsafe bool bOverride_KuroRadialBlurMaskScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurMaskScale) & FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurMaskScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurMaskScale) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurMaskScale) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurMaskScale) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurMaskScale : 0));
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x060037C5 RID: 14277 RVA: 0x0004F6C6 File Offset: 0x0004D8C6
		// (set) Token: 0x060037C6 RID: 14278 RVA: 0x0004F6DF File Offset: 0x0004D8DF
		public unsafe bool bOverride_KuroRadialBlurMaskOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurMaskOffset) & FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurMaskOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurMaskOffset) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroRadialBlurMaskOffset) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurMaskOffset) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroRadialBlurMaskOffset : 0));
			}
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x060037C7 RID: 14279 RVA: 0x0004F70F File Offset: 0x0004D90F
		// (set) Token: 0x060037C8 RID: 14280 RVA: 0x0004F728 File Offset: 0x0004D928
		public unsafe bool bOverride_ScreenSoftIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftIntensity) & FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftIntensity : 0));
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x060037C9 RID: 14281 RVA: 0x0004F758 File Offset: 0x0004D958
		// (set) Token: 0x060037CA RID: 14282 RVA: 0x0004F771 File Offset: 0x0004D971
		public unsafe bool bOverride_ScreenSoftThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftThreshold) & FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftThreshold) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftThreshold) & ~FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftThreshold) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftThreshold : 0));
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x060037CB RID: 14283 RVA: 0x0004F7A1 File Offset: 0x0004D9A1
		// (set) Token: 0x060037CC RID: 14284 RVA: 0x0004F7BA File Offset: 0x0004D9BA
		public unsafe bool bOverride_ScreenSoftDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftDistance) & FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftDistance) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftDistance) & ~FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftDistance) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftDistance : 0));
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x060037CD RID: 14285 RVA: 0x0004F7EA File Offset: 0x0004D9EA
		// (set) Token: 0x060037CE RID: 14286 RVA: 0x0004F803 File Offset: 0x0004DA03
		public unsafe bool bOverride_ScreenSoftSkyBloomCompensation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftSkyBloomCompensation) & FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftSkyBloomCompensation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftSkyBloomCompensation) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftSkyBloomCompensation) & ~FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftSkyBloomCompensation) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftSkyBloomCompensation : 0));
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x060037CF RID: 14287 RVA: 0x0004F833 File Offset: 0x0004DA33
		// (set) Token: 0x060037D0 RID: 14288 RVA: 0x0004F84C File Offset: 0x0004DA4C
		public unsafe bool bOverride_ScreenSoftRange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftRange) & FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftRange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftRange) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftRange) & ~FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftRange) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftRange : 0));
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x060037D1 RID: 14289 RVA: 0x0004F87C File Offset: 0x0004DA7C
		// (set) Token: 0x060037D2 RID: 14290 RVA: 0x0004F895 File Offset: 0x0004DA95
		public unsafe bool bOverride_ScreenSoftOverflowDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftOverflowDistance) & FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftOverflowDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftOverflowDistance) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftOverflowDistance) & ~FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftOverflowDistance) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftOverflowDistance : 0));
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x060037D3 RID: 14291 RVA: 0x0004F8C5 File Offset: 0x0004DAC5
		// (set) Token: 0x060037D4 RID: 14292 RVA: 0x0004F8DE File Offset: 0x0004DADE
		public unsafe bool bOverride_ScreenSoftSunExposure
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftSunExposure) & FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftSunExposure) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftSunExposure) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftSunExposure) & ~FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftSunExposure) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftSunExposure : 0));
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x060037D5 RID: 14293 RVA: 0x0004F90E File Offset: 0x0004DB0E
		// (set) Token: 0x060037D6 RID: 14294 RVA: 0x0004F927 File Offset: 0x0004DB27
		public unsafe bool bOverride_ScreenSoftHighQuality
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftHighQuality) & FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftHighQuality) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftHighQuality) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSoftHighQuality) & ~FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftHighQuality) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ScreenSoftHighQuality : 0));
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x060037D7 RID: 14295 RVA: 0x0004F957 File Offset: 0x0004DB57
		// (set) Token: 0x060037D8 RID: 14296 RVA: 0x0004F970 File Offset: 0x0004DB70
		public unsafe bool bOverride_MobileScreenSoftIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileScreenSoftIntensity) & FPostProcessSettings.__PropertyMask_bOverride_MobileScreenSoftIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileScreenSoftIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileScreenSoftIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_MobileScreenSoftIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_MobileScreenSoftIntensity : 0));
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x060037D9 RID: 14297 RVA: 0x0004F9A0 File Offset: 0x0004DBA0
		// (set) Token: 0x060037DA RID: 14298 RVA: 0x0004F9B9 File Offset: 0x0004DBB9
		public unsafe bool bOverride_MobileScreenSoftThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileScreenSoftThreshold) & FPostProcessSettings.__PropertyMask_bOverride_MobileScreenSoftThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileScreenSoftThreshold) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileScreenSoftThreshold) & ~FPostProcessSettings.__PropertyMask_bOverride_MobileScreenSoftThreshold) | (value ? FPostProcessSettings.__PropertyMask_bOverride_MobileScreenSoftThreshold : 0));
			}
		}

		// Token: 0x17000859 RID: 2137
		// (get) Token: 0x060037DB RID: 14299 RVA: 0x0004F9E9 File Offset: 0x0004DBE9
		// (set) Token: 0x060037DC RID: 14300 RVA: 0x0004FA02 File Offset: 0x0004DC02
		public unsafe bool bOverride_MobileScreenSoftDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileScreenSoftDistance) & FPostProcessSettings.__PropertyMask_bOverride_MobileScreenSoftDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileScreenSoftDistance) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileScreenSoftDistance) & ~FPostProcessSettings.__PropertyMask_bOverride_MobileScreenSoftDistance) | (value ? FPostProcessSettings.__PropertyMask_bOverride_MobileScreenSoftDistance : 0));
			}
		}

		// Token: 0x1700085A RID: 2138
		// (get) Token: 0x060037DD RID: 14301 RVA: 0x0004FA32 File Offset: 0x0004DC32
		// (set) Token: 0x060037DE RID: 14302 RVA: 0x0004FA4B File Offset: 0x0004DC4B
		public unsafe bool bOverride_ScreenLeakTexture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenLeakTexture) & FPostProcessSettings.__PropertyMask_bOverride_ScreenLeakTexture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenLeakTexture) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenLeakTexture) & ~FPostProcessSettings.__PropertyMask_bOverride_ScreenLeakTexture) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ScreenLeakTexture : 0));
			}
		}

		// Token: 0x1700085B RID: 2139
		// (get) Token: 0x060037DF RID: 14303 RVA: 0x0004FA7B File Offset: 0x0004DC7B
		// (set) Token: 0x060037E0 RID: 14304 RVA: 0x0004FA94 File Offset: 0x0004DC94
		public unsafe bool bOverride_ScreenLeakTextureIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenLeakTextureIntensity) & FPostProcessSettings.__PropertyMask_bOverride_ScreenLeakTextureIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenLeakTextureIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenLeakTextureIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_ScreenLeakTextureIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ScreenLeakTextureIntensity : 0));
			}
		}

		// Token: 0x1700085C RID: 2140
		// (get) Token: 0x060037E1 RID: 14305 RVA: 0x0004FAC4 File Offset: 0x0004DCC4
		// (set) Token: 0x060037E2 RID: 14306 RVA: 0x0004FADD File Offset: 0x0004DCDD
		public unsafe bool bOverride_FFTIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTIntensity) & FPostProcessSettings.__PropertyMask_bOverride_FFTIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_FFTIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FFTIntensity : 0));
			}
		}

		// Token: 0x1700085D RID: 2141
		// (get) Token: 0x060037E3 RID: 14307 RVA: 0x0004FB0D File Offset: 0x0004DD0D
		// (set) Token: 0x060037E4 RID: 14308 RVA: 0x0004FB26 File Offset: 0x0004DD26
		public unsafe bool bOverride_FFTThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTThreshold) & FPostProcessSettings.__PropertyMask_bOverride_FFTThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTThreshold) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTThreshold) & ~FPostProcessSettings.__PropertyMask_bOverride_FFTThreshold) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FFTThreshold : 0));
			}
		}

		// Token: 0x1700085E RID: 2142
		// (get) Token: 0x060037E5 RID: 14309 RVA: 0x0004FB56 File Offset: 0x0004DD56
		// (set) Token: 0x060037E6 RID: 14310 RVA: 0x0004FB6F File Offset: 0x0004DD6F
		public unsafe bool bOverride_FFTTexture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTTexture) & FPostProcessSettings.__PropertyMask_bOverride_FFTTexture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTTexture) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTTexture) & ~FPostProcessSettings.__PropertyMask_bOverride_FFTTexture) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FFTTexture : 0));
			}
		}

		// Token: 0x1700085F RID: 2143
		// (get) Token: 0x060037E7 RID: 14311 RVA: 0x0004FB9F File Offset: 0x0004DD9F
		// (set) Token: 0x060037E8 RID: 14312 RVA: 0x0004FBB8 File Offset: 0x0004DDB8
		public unsafe bool bOverride_FFTScatterDispersion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTScatterDispersion) & FPostProcessSettings.__PropertyMask_bOverride_FFTScatterDispersion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTScatterDispersion) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTScatterDispersion) & ~FPostProcessSettings.__PropertyMask_bOverride_FFTScatterDispersion) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FFTScatterDispersion : 0));
			}
		}

		// Token: 0x17000860 RID: 2144
		// (get) Token: 0x060037E9 RID: 14313 RVA: 0x0004FBE8 File Offset: 0x0004DDE8
		// (set) Token: 0x060037EA RID: 14314 RVA: 0x0004FC01 File Offset: 0x0004DE01
		public unsafe bool bOverride_FFTSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTSize) & FPostProcessSettings.__PropertyMask_bOverride_FFTSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTSize) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTSize) & ~FPostProcessSettings.__PropertyMask_bOverride_FFTSize) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FFTSize : 0));
			}
		}

		// Token: 0x17000861 RID: 2145
		// (get) Token: 0x060037EB RID: 14315 RVA: 0x0004FC31 File Offset: 0x0004DE31
		// (set) Token: 0x060037EC RID: 14316 RVA: 0x0004FC4A File Offset: 0x0004DE4A
		public unsafe bool bOverride_FFTPreFilterMin
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTPreFilterMin) & FPostProcessSettings.__PropertyMask_bOverride_FFTPreFilterMin) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTPreFilterMin) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTPreFilterMin) & ~FPostProcessSettings.__PropertyMask_bOverride_FFTPreFilterMin) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FFTPreFilterMin : 0));
			}
		}

		// Token: 0x17000862 RID: 2146
		// (get) Token: 0x060037ED RID: 14317 RVA: 0x0004FC7A File Offset: 0x0004DE7A
		// (set) Token: 0x060037EE RID: 14318 RVA: 0x0004FC93 File Offset: 0x0004DE93
		public unsafe bool bOverride_FFTPreFilterMax
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTPreFilterMax) & FPostProcessSettings.__PropertyMask_bOverride_FFTPreFilterMax) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTPreFilterMax) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTPreFilterMax) & ~FPostProcessSettings.__PropertyMask_bOverride_FFTPreFilterMax) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FFTPreFilterMax : 0));
			}
		}

		// Token: 0x17000863 RID: 2147
		// (get) Token: 0x060037EF RID: 14319 RVA: 0x0004FCC3 File Offset: 0x0004DEC3
		// (set) Token: 0x060037F0 RID: 14320 RVA: 0x0004FCDC File Offset: 0x0004DEDC
		public unsafe bool bOverride_FFTPreFilterMult
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTPreFilterMult) & FPostProcessSettings.__PropertyMask_bOverride_FFTPreFilterMult) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTPreFilterMult) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTPreFilterMult) & ~FPostProcessSettings.__PropertyMask_bOverride_FFTPreFilterMult) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FFTPreFilterMult : 0));
			}
		}

		// Token: 0x17000864 RID: 2148
		// (get) Token: 0x060037F1 RID: 14321 RVA: 0x0004FD0C File Offset: 0x0004DF0C
		// (set) Token: 0x060037F2 RID: 14322 RVA: 0x0004FD25 File Offset: 0x0004DF25
		public unsafe bool bOverride_FFTBufferScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTBufferScale) & FPostProcessSettings.__PropertyMask_bOverride_FFTBufferScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTBufferScale) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTBufferScale) & ~FPostProcessSettings.__PropertyMask_bOverride_FFTBufferScale) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FFTBufferScale : 0));
			}
		}

		// Token: 0x17000865 RID: 2149
		// (get) Token: 0x060037F3 RID: 14323 RVA: 0x0004FD55 File Offset: 0x0004DF55
		// (set) Token: 0x060037F4 RID: 14324 RVA: 0x0004FD6E File Offset: 0x0004DF6E
		public unsafe bool bOverride_FFTDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTDistance) & FPostProcessSettings.__PropertyMask_bOverride_FFTDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTDistance) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTDistance) & ~FPostProcessSettings.__PropertyMask_bOverride_FFTDistance) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FFTDistance : 0));
			}
		}

		// Token: 0x17000866 RID: 2150
		// (get) Token: 0x060037F5 RID: 14325 RVA: 0x0004FD9E File Offset: 0x0004DF9E
		// (set) Token: 0x060037F6 RID: 14326 RVA: 0x0004FDB7 File Offset: 0x0004DFB7
		public unsafe bool bOverride_FFTHidenSky
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTHidenSky) & FPostProcessSettings.__PropertyMask_bOverride_FFTHidenSky) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTHidenSky) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTHidenSky) & ~FPostProcessSettings.__PropertyMask_bOverride_FFTHidenSky) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FFTHidenSky : 0));
			}
		}

		// Token: 0x17000867 RID: 2151
		// (get) Token: 0x060037F7 RID: 14327 RVA: 0x0004FDE7 File Offset: 0x0004DFE7
		// (set) Token: 0x060037F8 RID: 14328 RVA: 0x0004FE00 File Offset: 0x0004E000
		public unsafe bool bOverride_FFTHidenTranslucent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTHidenTranslucent) & FPostProcessSettings.__PropertyMask_bOverride_FFTHidenTranslucent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTHidenTranslucent) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTHidenTranslucent) & ~FPostProcessSettings.__PropertyMask_bOverride_FFTHidenTranslucent) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FFTHidenTranslucent : 0));
			}
		}

		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x060037F9 RID: 14329 RVA: 0x0004FE30 File Offset: 0x0004E030
		// (set) Token: 0x060037FA RID: 14330 RVA: 0x0004FE49 File Offset: 0x0004E049
		public unsafe bool bOverride_FFTBeforeTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTBeforeTranslucency) & FPostProcessSettings.__PropertyMask_bOverride_FFTBeforeTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTBeforeTranslucency) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_FFTBeforeTranslucency) & ~FPostProcessSettings.__PropertyMask_bOverride_FFTBeforeTranslucency) | (value ? FPostProcessSettings.__PropertyMask_bOverride_FFTBeforeTranslucency : 0));
			}
		}

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x060037FB RID: 14331 RVA: 0x0004FE79 File Offset: 0x0004E079
		// (set) Token: 0x060037FC RID: 14332 RVA: 0x0004FE92 File Offset: 0x0004E092
		public unsafe bool bOverride_ToonFFTIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonFFTIntensity) & FPostProcessSettings.__PropertyMask_bOverride_ToonFFTIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonFFTIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonFFTIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_ToonFFTIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ToonFFTIntensity : 0));
			}
		}

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x060037FD RID: 14333 RVA: 0x0004FEC2 File Offset: 0x0004E0C2
		// (set) Token: 0x060037FE RID: 14334 RVA: 0x0004FEDB File Offset: 0x0004E0DB
		public unsafe bool bOverride_ToonFFTThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonFFTThreshold) & FPostProcessSettings.__PropertyMask_bOverride_ToonFFTThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonFFTThreshold) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonFFTThreshold) & ~FPostProcessSettings.__PropertyMask_bOverride_ToonFFTThreshold) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ToonFFTThreshold : 0));
			}
		}

		// Token: 0x1700086B RID: 2155
		// (get) Token: 0x060037FF RID: 14335 RVA: 0x0004FF0B File Offset: 0x0004E10B
		// (set) Token: 0x06003800 RID: 14336 RVA: 0x0004FF24 File Offset: 0x0004E124
		public unsafe bool bOverride_ToonFFTTexture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonFFTTexture) & FPostProcessSettings.__PropertyMask_bOverride_ToonFFTTexture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonFFTTexture) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonFFTTexture) & ~FPostProcessSettings.__PropertyMask_bOverride_ToonFFTTexture) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ToonFFTTexture : 0));
			}
		}

		// Token: 0x1700086C RID: 2156
		// (get) Token: 0x06003801 RID: 14337 RVA: 0x0004FF54 File Offset: 0x0004E154
		// (set) Token: 0x06003802 RID: 14338 RVA: 0x0004FF6D File Offset: 0x0004E16D
		public unsafe bool bOverride_ToonFFTScatterDispersion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonFFTScatterDispersion) & FPostProcessSettings.__PropertyMask_bOverride_ToonFFTScatterDispersion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonFFTScatterDispersion) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonFFTScatterDispersion) & ~FPostProcessSettings.__PropertyMask_bOverride_ToonFFTScatterDispersion) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ToonFFTScatterDispersion : 0));
			}
		}

		// Token: 0x1700086D RID: 2157
		// (get) Token: 0x06003803 RID: 14339 RVA: 0x0004FF9D File Offset: 0x0004E19D
		// (set) Token: 0x06003804 RID: 14340 RVA: 0x0004FFB6 File Offset: 0x0004E1B6
		public unsafe bool bOverride_ToonFFTSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonFFTSize) & FPostProcessSettings.__PropertyMask_bOverride_ToonFFTSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonFFTSize) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonFFTSize) & ~FPostProcessSettings.__PropertyMask_bOverride_ToonFFTSize) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ToonFFTSize : 0));
			}
		}

		// Token: 0x1700086E RID: 2158
		// (get) Token: 0x06003805 RID: 14341 RVA: 0x0004FFE6 File Offset: 0x0004E1E6
		// (set) Token: 0x06003806 RID: 14342 RVA: 0x0004FFFF File Offset: 0x0004E1FF
		public unsafe bool bOverride_SeparateTranslucencyBlurSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SeparateTranslucencyBlurSize) & FPostProcessSettings.__PropertyMask_bOverride_SeparateTranslucencyBlurSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SeparateTranslucencyBlurSize) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SeparateTranslucencyBlurSize) & ~FPostProcessSettings.__PropertyMask_bOverride_SeparateTranslucencyBlurSize) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SeparateTranslucencyBlurSize : 0));
			}
		}

		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x06003807 RID: 14343 RVA: 0x0005002F File Offset: 0x0004E22F
		// (set) Token: 0x06003808 RID: 14344 RVA: 0x00050048 File Offset: 0x0004E248
		public unsafe bool bOverride_LightFadeScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LightFadeScale) & FPostProcessSettings.__PropertyMask_bOverride_LightFadeScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LightFadeScale) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LightFadeScale) & ~FPostProcessSettings.__PropertyMask_bOverride_LightFadeScale) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LightFadeScale : 0));
			}
		}

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x06003809 RID: 14345 RVA: 0x00050078 File Offset: 0x0004E278
		// (set) Token: 0x0600380A RID: 14346 RVA: 0x00050091 File Offset: 0x0004E291
		public unsafe bool bOverride_KuroDataDistortionNoiseIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionNoiseIntensity) & FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionNoiseIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionNoiseIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionNoiseIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionNoiseIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionNoiseIntensity : 0));
			}
		}

		// Token: 0x17000871 RID: 2161
		// (get) Token: 0x0600380B RID: 14347 RVA: 0x000500C1 File Offset: 0x0004E2C1
		// (set) Token: 0x0600380C RID: 14348 RVA: 0x000500DA File Offset: 0x0004E2DA
		public unsafe bool bOverride_KuroDataDistortionNoiseTexture
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionNoiseTexture) & FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionNoiseTexture) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionNoiseTexture) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionNoiseTexture) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionNoiseTexture) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionNoiseTexture : 0));
			}
		}

		// Token: 0x17000872 RID: 2162
		// (get) Token: 0x0600380D RID: 14349 RVA: 0x0005010A File Offset: 0x0004E30A
		// (set) Token: 0x0600380E RID: 14350 RVA: 0x00050123 File Offset: 0x0004E323
		public unsafe bool bOverride_KuroDataDistortionNoiseTextureUVScaleBias
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionNoiseTextureUVScaleBias) & FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionNoiseTextureUVScaleBias) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionNoiseTextureUVScaleBias) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionNoiseTextureUVScaleBias) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionNoiseTextureUVScaleBias) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionNoiseTextureUVScaleBias : 0));
			}
		}

		// Token: 0x17000873 RID: 2163
		// (get) Token: 0x0600380F RID: 14351 RVA: 0x00050153 File Offset: 0x0004E353
		// (set) Token: 0x06003810 RID: 14352 RVA: 0x0005016C File Offset: 0x0004E36C
		public unsafe bool bOverride_KuroDataDistortionNoiseSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionNoiseSize) & FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionNoiseSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionNoiseSize) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionNoiseSize) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionNoiseSize) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionNoiseSize : 0));
			}
		}

		// Token: 0x17000874 RID: 2164
		// (get) Token: 0x06003811 RID: 14353 RVA: 0x0005019C File Offset: 0x0004E39C
		// (set) Token: 0x06003812 RID: 14354 RVA: 0x000501B5 File Offset: 0x0004E3B5
		public unsafe bool bOverride_KuroDataDistortionNoiseBias
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionNoiseBias) & FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionNoiseBias) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionNoiseBias) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionNoiseBias) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionNoiseBias) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionNoiseBias : 0));
			}
		}

		// Token: 0x17000875 RID: 2165
		// (get) Token: 0x06003813 RID: 14355 RVA: 0x000501E5 File Offset: 0x0004E3E5
		// (set) Token: 0x06003814 RID: 14356 RVA: 0x000501FE File Offset: 0x0004E3FE
		public unsafe bool bOverride_KuroDataDistortionSignalIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionSignalIntensity) & FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionSignalIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionSignalIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionSignalIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionSignalIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionSignalIntensity : 0));
			}
		}

		// Token: 0x17000876 RID: 2166
		// (get) Token: 0x06003815 RID: 14357 RVA: 0x0005022E File Offset: 0x0004E42E
		// (set) Token: 0x06003816 RID: 14358 RVA: 0x00050247 File Offset: 0x0004E447
		public unsafe bool bOverride_KuroDataDistortionRandomColorSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionRandomColorSize) & FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionRandomColorSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionRandomColorSize) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionRandomColorSize) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionRandomColorSize) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionRandomColorSize : 0));
			}
		}

		// Token: 0x17000877 RID: 2167
		// (get) Token: 0x06003817 RID: 14359 RVA: 0x00050277 File Offset: 0x0004E477
		// (set) Token: 0x06003818 RID: 14360 RVA: 0x00050290 File Offset: 0x0004E490
		public unsafe bool bOverride_KuroDataDistortionSinWaveParameters
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionSinWaveParameters) & FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionSinWaveParameters) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionSinWaveParameters) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionSinWaveParameters) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionSinWaveParameters) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionSinWaveParameters : 0));
			}
		}

		// Token: 0x17000878 RID: 2168
		// (get) Token: 0x06003819 RID: 14361 RVA: 0x000502C0 File Offset: 0x0004E4C0
		// (set) Token: 0x0600381A RID: 14362 RVA: 0x000502D9 File Offset: 0x0004E4D9
		public unsafe bool bOverride_KuroDataDistortionColorTint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionColorTint) & FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionColorTint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionColorTint) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDataDistortionColorTint) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionColorTint) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroDataDistortionColorTint : 0));
			}
		}

		// Token: 0x17000879 RID: 2169
		// (get) Token: 0x0600381B RID: 14363 RVA: 0x00050309 File Offset: 0x0004E509
		// (set) Token: 0x0600381C RID: 14364 RVA: 0x00050322 File Offset: 0x0004E522
		public unsafe bool bOverride_BloomThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomThreshold) & FPostProcessSettings.__PropertyMask_bOverride_BloomThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomThreshold) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomThreshold) & ~FPostProcessSettings.__PropertyMask_bOverride_BloomThreshold) | (value ? FPostProcessSettings.__PropertyMask_bOverride_BloomThreshold : 0));
			}
		}

		// Token: 0x1700087A RID: 2170
		// (get) Token: 0x0600381D RID: 14365 RVA: 0x00050352 File Offset: 0x0004E552
		// (set) Token: 0x0600381E RID: 14366 RVA: 0x0005036B File Offset: 0x0004E56B
		public unsafe bool bOverride_Bloom1Tint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom1Tint) & FPostProcessSettings.__PropertyMask_bOverride_Bloom1Tint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom1Tint) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom1Tint) & ~FPostProcessSettings.__PropertyMask_bOverride_Bloom1Tint) | (value ? FPostProcessSettings.__PropertyMask_bOverride_Bloom1Tint : 0));
			}
		}

		// Token: 0x1700087B RID: 2171
		// (get) Token: 0x0600381F RID: 14367 RVA: 0x0005039B File Offset: 0x0004E59B
		// (set) Token: 0x06003820 RID: 14368 RVA: 0x000503B4 File Offset: 0x0004E5B4
		public unsafe bool bOverride_Bloom1Size
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom1Size) & FPostProcessSettings.__PropertyMask_bOverride_Bloom1Size) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom1Size) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom1Size) & ~FPostProcessSettings.__PropertyMask_bOverride_Bloom1Size) | (value ? FPostProcessSettings.__PropertyMask_bOverride_Bloom1Size : 0));
			}
		}

		// Token: 0x1700087C RID: 2172
		// (get) Token: 0x06003821 RID: 14369 RVA: 0x000503E4 File Offset: 0x0004E5E4
		// (set) Token: 0x06003822 RID: 14370 RVA: 0x000503FD File Offset: 0x0004E5FD
		public unsafe bool bOverride_Bloom2Size
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom2Size) & FPostProcessSettings.__PropertyMask_bOverride_Bloom2Size) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom2Size) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom2Size) & ~FPostProcessSettings.__PropertyMask_bOverride_Bloom2Size) | (value ? FPostProcessSettings.__PropertyMask_bOverride_Bloom2Size : 0));
			}
		}

		// Token: 0x1700087D RID: 2173
		// (get) Token: 0x06003823 RID: 14371 RVA: 0x0005042D File Offset: 0x0004E62D
		// (set) Token: 0x06003824 RID: 14372 RVA: 0x00050446 File Offset: 0x0004E646
		public unsafe bool bOverride_Bloom2Tint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom2Tint) & FPostProcessSettings.__PropertyMask_bOverride_Bloom2Tint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom2Tint) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom2Tint) & ~FPostProcessSettings.__PropertyMask_bOverride_Bloom2Tint) | (value ? FPostProcessSettings.__PropertyMask_bOverride_Bloom2Tint : 0));
			}
		}

		// Token: 0x1700087E RID: 2174
		// (get) Token: 0x06003825 RID: 14373 RVA: 0x00050476 File Offset: 0x0004E676
		// (set) Token: 0x06003826 RID: 14374 RVA: 0x0005048F File Offset: 0x0004E68F
		public unsafe bool bOverride_Bloom3Tint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom3Tint) & FPostProcessSettings.__PropertyMask_bOverride_Bloom3Tint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom3Tint) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom3Tint) & ~FPostProcessSettings.__PropertyMask_bOverride_Bloom3Tint) | (value ? FPostProcessSettings.__PropertyMask_bOverride_Bloom3Tint : 0));
			}
		}

		// Token: 0x1700087F RID: 2175
		// (get) Token: 0x06003827 RID: 14375 RVA: 0x000504BF File Offset: 0x0004E6BF
		// (set) Token: 0x06003828 RID: 14376 RVA: 0x000504D8 File Offset: 0x0004E6D8
		public unsafe bool bOverride_Bloom3Size
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom3Size) & FPostProcessSettings.__PropertyMask_bOverride_Bloom3Size) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom3Size) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom3Size) & ~FPostProcessSettings.__PropertyMask_bOverride_Bloom3Size) | (value ? FPostProcessSettings.__PropertyMask_bOverride_Bloom3Size : 0));
			}
		}

		// Token: 0x17000880 RID: 2176
		// (get) Token: 0x06003829 RID: 14377 RVA: 0x00050508 File Offset: 0x0004E708
		// (set) Token: 0x0600382A RID: 14378 RVA: 0x00050521 File Offset: 0x0004E721
		public unsafe bool bOverride_Bloom4Tint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom4Tint) & FPostProcessSettings.__PropertyMask_bOverride_Bloom4Tint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom4Tint) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom4Tint) & ~FPostProcessSettings.__PropertyMask_bOverride_Bloom4Tint) | (value ? FPostProcessSettings.__PropertyMask_bOverride_Bloom4Tint : 0));
			}
		}

		// Token: 0x17000881 RID: 2177
		// (get) Token: 0x0600382B RID: 14379 RVA: 0x00050551 File Offset: 0x0004E751
		// (set) Token: 0x0600382C RID: 14380 RVA: 0x0005056A File Offset: 0x0004E76A
		public unsafe bool bOverride_Bloom4Size
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom4Size) & FPostProcessSettings.__PropertyMask_bOverride_Bloom4Size) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom4Size) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom4Size) & ~FPostProcessSettings.__PropertyMask_bOverride_Bloom4Size) | (value ? FPostProcessSettings.__PropertyMask_bOverride_Bloom4Size : 0));
			}
		}

		// Token: 0x17000882 RID: 2178
		// (get) Token: 0x0600382D RID: 14381 RVA: 0x0005059A File Offset: 0x0004E79A
		// (set) Token: 0x0600382E RID: 14382 RVA: 0x000505B3 File Offset: 0x0004E7B3
		public unsafe bool bOverride_Bloom5Tint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom5Tint) & FPostProcessSettings.__PropertyMask_bOverride_Bloom5Tint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom5Tint) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom5Tint) & ~FPostProcessSettings.__PropertyMask_bOverride_Bloom5Tint) | (value ? FPostProcessSettings.__PropertyMask_bOverride_Bloom5Tint : 0));
			}
		}

		// Token: 0x17000883 RID: 2179
		// (get) Token: 0x0600382F RID: 14383 RVA: 0x000505E3 File Offset: 0x0004E7E3
		// (set) Token: 0x06003830 RID: 14384 RVA: 0x000505FC File Offset: 0x0004E7FC
		public unsafe bool bOverride_Bloom5Size
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom5Size) & FPostProcessSettings.__PropertyMask_bOverride_Bloom5Size) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom5Size) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom5Size) & ~FPostProcessSettings.__PropertyMask_bOverride_Bloom5Size) | (value ? FPostProcessSettings.__PropertyMask_bOverride_Bloom5Size : 0));
			}
		}

		// Token: 0x17000884 RID: 2180
		// (get) Token: 0x06003831 RID: 14385 RVA: 0x0005062C File Offset: 0x0004E82C
		// (set) Token: 0x06003832 RID: 14386 RVA: 0x00050645 File Offset: 0x0004E845
		public unsafe bool bOverride_Bloom6Tint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom6Tint) & FPostProcessSettings.__PropertyMask_bOverride_Bloom6Tint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom6Tint) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom6Tint) & ~FPostProcessSettings.__PropertyMask_bOverride_Bloom6Tint) | (value ? FPostProcessSettings.__PropertyMask_bOverride_Bloom6Tint : 0));
			}
		}

		// Token: 0x17000885 RID: 2181
		// (get) Token: 0x06003833 RID: 14387 RVA: 0x00050675 File Offset: 0x0004E875
		// (set) Token: 0x06003834 RID: 14388 RVA: 0x0005068E File Offset: 0x0004E88E
		public unsafe bool bOverride_Bloom6Size
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom6Size) & FPostProcessSettings.__PropertyMask_bOverride_Bloom6Size) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom6Size) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_Bloom6Size) & ~FPostProcessSettings.__PropertyMask_bOverride_Bloom6Size) | (value ? FPostProcessSettings.__PropertyMask_bOverride_Bloom6Size : 0));
			}
		}

		// Token: 0x17000886 RID: 2182
		// (get) Token: 0x06003835 RID: 14389 RVA: 0x000506BE File Offset: 0x0004E8BE
		// (set) Token: 0x06003836 RID: 14390 RVA: 0x000506D7 File Offset: 0x0004E8D7
		public unsafe bool bOverride_BloomSizeScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomSizeScale) & FPostProcessSettings.__PropertyMask_bOverride_BloomSizeScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomSizeScale) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomSizeScale) & ~FPostProcessSettings.__PropertyMask_bOverride_BloomSizeScale) | (value ? FPostProcessSettings.__PropertyMask_bOverride_BloomSizeScale : 0));
			}
		}

		// Token: 0x17000887 RID: 2183
		// (get) Token: 0x06003837 RID: 14391 RVA: 0x00050707 File Offset: 0x0004E907
		// (set) Token: 0x06003838 RID: 14392 RVA: 0x00050720 File Offset: 0x0004E920
		public unsafe bool bOverride_BloomConvolutionPreFilter_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomConvolutionPreFilter_DEPRECATED) & FPostProcessSettings.__PropertyMask_bOverride_BloomConvolutionPreFilter_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomConvolutionPreFilter_DEPRECATED) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomConvolutionPreFilter_DEPRECATED) & ~FPostProcessSettings.__PropertyMask_bOverride_BloomConvolutionPreFilter_DEPRECATED) | (value ? FPostProcessSettings.__PropertyMask_bOverride_BloomConvolutionPreFilter_DEPRECATED : 0));
			}
		}

		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x06003839 RID: 14393 RVA: 0x00050750 File Offset: 0x0004E950
		// (set) Token: 0x0600383A RID: 14394 RVA: 0x00050769 File Offset: 0x0004E969
		public unsafe bool bOverride_BloomDirtMaskIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomDirtMaskIntensity) & FPostProcessSettings.__PropertyMask_bOverride_BloomDirtMaskIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomDirtMaskIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomDirtMaskIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_BloomDirtMaskIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_BloomDirtMaskIntensity : 0));
			}
		}

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x0600383B RID: 14395 RVA: 0x00050799 File Offset: 0x0004E999
		// (set) Token: 0x0600383C RID: 14396 RVA: 0x000507B2 File Offset: 0x0004E9B2
		public unsafe bool bOverride_BloomDirtMaskTint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomDirtMaskTint) & FPostProcessSettings.__PropertyMask_bOverride_BloomDirtMaskTint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomDirtMaskTint) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomDirtMaskTint) & ~FPostProcessSettings.__PropertyMask_bOverride_BloomDirtMaskTint) | (value ? FPostProcessSettings.__PropertyMask_bOverride_BloomDirtMaskTint : 0));
			}
		}

		// Token: 0x1700088A RID: 2186
		// (get) Token: 0x0600383D RID: 14397 RVA: 0x000507E2 File Offset: 0x0004E9E2
		// (set) Token: 0x0600383E RID: 14398 RVA: 0x000507FB File Offset: 0x0004E9FB
		public unsafe bool bOverride_BloomDirtMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomDirtMask) & FPostProcessSettings.__PropertyMask_bOverride_BloomDirtMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomDirtMask) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_BloomDirtMask) & ~FPostProcessSettings.__PropertyMask_bOverride_BloomDirtMask) | (value ? FPostProcessSettings.__PropertyMask_bOverride_BloomDirtMask : 0));
			}
		}

		// Token: 0x1700088B RID: 2187
		// (get) Token: 0x0600383F RID: 14399 RVA: 0x0005082B File Offset: 0x0004EA2B
		// (set) Token: 0x06003840 RID: 14400 RVA: 0x00050844 File Offset: 0x0004EA44
		public unsafe bool bOverride_CameraShutterSpeed
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_CameraShutterSpeed) & FPostProcessSettings.__PropertyMask_bOverride_CameraShutterSpeed) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_CameraShutterSpeed) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_CameraShutterSpeed) & ~FPostProcessSettings.__PropertyMask_bOverride_CameraShutterSpeed) | (value ? FPostProcessSettings.__PropertyMask_bOverride_CameraShutterSpeed : 0));
			}
		}

		// Token: 0x1700088C RID: 2188
		// (get) Token: 0x06003841 RID: 14401 RVA: 0x00050874 File Offset: 0x0004EA74
		// (set) Token: 0x06003842 RID: 14402 RVA: 0x0005088D File Offset: 0x0004EA8D
		public unsafe bool bOverride_CameraISO
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_CameraISO) & FPostProcessSettings.__PropertyMask_bOverride_CameraISO) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_CameraISO) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_CameraISO) & ~FPostProcessSettings.__PropertyMask_bOverride_CameraISO) | (value ? FPostProcessSettings.__PropertyMask_bOverride_CameraISO : 0));
			}
		}

		// Token: 0x1700088D RID: 2189
		// (get) Token: 0x06003843 RID: 14403 RVA: 0x000508BD File Offset: 0x0004EABD
		// (set) Token: 0x06003844 RID: 14404 RVA: 0x000508D6 File Offset: 0x0004EAD6
		public unsafe bool bOverride_AutoExposureMethod
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureMethod) & FPostProcessSettings.__PropertyMask_bOverride_AutoExposureMethod) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureMethod) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureMethod) & ~FPostProcessSettings.__PropertyMask_bOverride_AutoExposureMethod) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AutoExposureMethod : 0));
			}
		}

		// Token: 0x1700088E RID: 2190
		// (get) Token: 0x06003845 RID: 14405 RVA: 0x00050906 File Offset: 0x0004EB06
		// (set) Token: 0x06003846 RID: 14406 RVA: 0x0005091F File Offset: 0x0004EB1F
		public unsafe bool bOverride_AutoExposureLowPercent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureLowPercent) & FPostProcessSettings.__PropertyMask_bOverride_AutoExposureLowPercent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureLowPercent) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureLowPercent) & ~FPostProcessSettings.__PropertyMask_bOverride_AutoExposureLowPercent) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AutoExposureLowPercent : 0));
			}
		}

		// Token: 0x1700088F RID: 2191
		// (get) Token: 0x06003847 RID: 14407 RVA: 0x0005094F File Offset: 0x0004EB4F
		// (set) Token: 0x06003848 RID: 14408 RVA: 0x00050968 File Offset: 0x0004EB68
		public unsafe bool bOverride_AutoExposureHighPercent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureHighPercent) & FPostProcessSettings.__PropertyMask_bOverride_AutoExposureHighPercent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureHighPercent) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureHighPercent) & ~FPostProcessSettings.__PropertyMask_bOverride_AutoExposureHighPercent) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AutoExposureHighPercent : 0));
			}
		}

		// Token: 0x17000890 RID: 2192
		// (get) Token: 0x06003849 RID: 14409 RVA: 0x00050998 File Offset: 0x0004EB98
		// (set) Token: 0x0600384A RID: 14410 RVA: 0x000509B1 File Offset: 0x0004EBB1
		public unsafe bool bOverride_AutoExposureMinBrightness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureMinBrightness) & FPostProcessSettings.__PropertyMask_bOverride_AutoExposureMinBrightness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureMinBrightness) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureMinBrightness) & ~FPostProcessSettings.__PropertyMask_bOverride_AutoExposureMinBrightness) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AutoExposureMinBrightness : 0));
			}
		}

		// Token: 0x17000891 RID: 2193
		// (get) Token: 0x0600384B RID: 14411 RVA: 0x000509E1 File Offset: 0x0004EBE1
		// (set) Token: 0x0600384C RID: 14412 RVA: 0x000509FA File Offset: 0x0004EBFA
		public unsafe bool bOverride_AutoExposureMaxBrightness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureMaxBrightness) & FPostProcessSettings.__PropertyMask_bOverride_AutoExposureMaxBrightness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureMaxBrightness) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureMaxBrightness) & ~FPostProcessSettings.__PropertyMask_bOverride_AutoExposureMaxBrightness) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AutoExposureMaxBrightness : 0));
			}
		}

		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x0600384D RID: 14413 RVA: 0x00050A2A File Offset: 0x0004EC2A
		// (set) Token: 0x0600384E RID: 14414 RVA: 0x00050A43 File Offset: 0x0004EC43
		public unsafe bool bOverride_AutoExposureCalibrationConstant_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureCalibrationConstant_DEPRECATED) & FPostProcessSettings.__PropertyMask_bOverride_AutoExposureCalibrationConstant_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureCalibrationConstant_DEPRECATED) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureCalibrationConstant_DEPRECATED) & ~FPostProcessSettings.__PropertyMask_bOverride_AutoExposureCalibrationConstant_DEPRECATED) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AutoExposureCalibrationConstant_DEPRECATED : 0));
			}
		}

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x0600384F RID: 14415 RVA: 0x00050A73 File Offset: 0x0004EC73
		// (set) Token: 0x06003850 RID: 14416 RVA: 0x00050A8C File Offset: 0x0004EC8C
		public unsafe bool bOverride_AutoExposureSpeedUp
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureSpeedUp) & FPostProcessSettings.__PropertyMask_bOverride_AutoExposureSpeedUp) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureSpeedUp) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureSpeedUp) & ~FPostProcessSettings.__PropertyMask_bOverride_AutoExposureSpeedUp) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AutoExposureSpeedUp : 0));
			}
		}

		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x06003851 RID: 14417 RVA: 0x00050ABC File Offset: 0x0004ECBC
		// (set) Token: 0x06003852 RID: 14418 RVA: 0x00050AD5 File Offset: 0x0004ECD5
		public unsafe bool bOverride_AutoExposureSpeedDown
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureSpeedDown) & FPostProcessSettings.__PropertyMask_bOverride_AutoExposureSpeedDown) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureSpeedDown) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureSpeedDown) & ~FPostProcessSettings.__PropertyMask_bOverride_AutoExposureSpeedDown) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AutoExposureSpeedDown : 0));
			}
		}

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06003853 RID: 14419 RVA: 0x00050B05 File Offset: 0x0004ED05
		// (set) Token: 0x06003854 RID: 14420 RVA: 0x00050B1E File Offset: 0x0004ED1E
		public unsafe bool bOverride_AutoExposureBias
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureBias) & FPostProcessSettings.__PropertyMask_bOverride_AutoExposureBias) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureBias) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureBias) & ~FPostProcessSettings.__PropertyMask_bOverride_AutoExposureBias) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AutoExposureBias : 0));
			}
		}

		// Token: 0x17000896 RID: 2198
		// (get) Token: 0x06003855 RID: 14421 RVA: 0x00050B4E File Offset: 0x0004ED4E
		// (set) Token: 0x06003856 RID: 14422 RVA: 0x00050B67 File Offset: 0x0004ED67
		public unsafe bool bOverride_AutoExposureBiasCurve
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureBiasCurve) & FPostProcessSettings.__PropertyMask_bOverride_AutoExposureBiasCurve) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureBiasCurve) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureBiasCurve) & ~FPostProcessSettings.__PropertyMask_bOverride_AutoExposureBiasCurve) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AutoExposureBiasCurve : 0));
			}
		}

		// Token: 0x17000897 RID: 2199
		// (get) Token: 0x06003857 RID: 14423 RVA: 0x00050B97 File Offset: 0x0004ED97
		// (set) Token: 0x06003858 RID: 14424 RVA: 0x00050BB0 File Offset: 0x0004EDB0
		public unsafe bool bOverride_AutoExposureMeterMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureMeterMask) & FPostProcessSettings.__PropertyMask_bOverride_AutoExposureMeterMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureMeterMask) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureMeterMask) & ~FPostProcessSettings.__PropertyMask_bOverride_AutoExposureMeterMask) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AutoExposureMeterMask : 0));
			}
		}

		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06003859 RID: 14425 RVA: 0x00050BE0 File Offset: 0x0004EDE0
		// (set) Token: 0x0600385A RID: 14426 RVA: 0x00050BF9 File Offset: 0x0004EDF9
		public unsafe bool bOverride_AutoExposureApplyPhysicalCameraExposure
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureApplyPhysicalCameraExposure) & FPostProcessSettings.__PropertyMask_bOverride_AutoExposureApplyPhysicalCameraExposure) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureApplyPhysicalCameraExposure) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureApplyPhysicalCameraExposure) & ~FPostProcessSettings.__PropertyMask_bOverride_AutoExposureApplyPhysicalCameraExposure) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AutoExposureApplyPhysicalCameraExposure : 0));
			}
		}

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x0600385B RID: 14427 RVA: 0x00050C29 File Offset: 0x0004EE29
		// (set) Token: 0x0600385C RID: 14428 RVA: 0x00050C42 File Offset: 0x0004EE42
		public unsafe bool bOverride_HistogramLogMin
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_HistogramLogMin) & FPostProcessSettings.__PropertyMask_bOverride_HistogramLogMin) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_HistogramLogMin) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_HistogramLogMin) & ~FPostProcessSettings.__PropertyMask_bOverride_HistogramLogMin) | (value ? FPostProcessSettings.__PropertyMask_bOverride_HistogramLogMin : 0));
			}
		}

		// Token: 0x1700089A RID: 2202
		// (get) Token: 0x0600385D RID: 14429 RVA: 0x00050C72 File Offset: 0x0004EE72
		// (set) Token: 0x0600385E RID: 14430 RVA: 0x00050C8B File Offset: 0x0004EE8B
		public unsafe bool bOverride_HistogramLogMax
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_HistogramLogMax) & FPostProcessSettings.__PropertyMask_bOverride_HistogramLogMax) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_HistogramLogMax) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_HistogramLogMax) & ~FPostProcessSettings.__PropertyMask_bOverride_HistogramLogMax) | (value ? FPostProcessSettings.__PropertyMask_bOverride_HistogramLogMax : 0));
			}
		}

		// Token: 0x1700089B RID: 2203
		// (get) Token: 0x0600385F RID: 14431 RVA: 0x00050CBB File Offset: 0x0004EEBB
		// (set) Token: 0x06003860 RID: 14432 RVA: 0x00050CD4 File Offset: 0x0004EED4
		public unsafe bool bOverride_LocalExposureMethod
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureMethod) & FPostProcessSettings.__PropertyMask_bOverride_LocalExposureMethod) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureMethod) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureMethod) & ~FPostProcessSettings.__PropertyMask_bOverride_LocalExposureMethod) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LocalExposureMethod : 0));
			}
		}

		// Token: 0x1700089C RID: 2204
		// (get) Token: 0x06003861 RID: 14433 RVA: 0x00050D04 File Offset: 0x0004EF04
		// (set) Token: 0x06003862 RID: 14434 RVA: 0x00050D1D File Offset: 0x0004EF1D
		public unsafe bool bOverride_LocalExposureContrastScale_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureContrastScale_DEPRECATED) & FPostProcessSettings.__PropertyMask_bOverride_LocalExposureContrastScale_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureContrastScale_DEPRECATED) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureContrastScale_DEPRECATED) & ~FPostProcessSettings.__PropertyMask_bOverride_LocalExposureContrastScale_DEPRECATED) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LocalExposureContrastScale_DEPRECATED : 0));
			}
		}

		// Token: 0x1700089D RID: 2205
		// (get) Token: 0x06003863 RID: 14435 RVA: 0x00050D4D File Offset: 0x0004EF4D
		// (set) Token: 0x06003864 RID: 14436 RVA: 0x00050D66 File Offset: 0x0004EF66
		public unsafe bool bOverride_LocalExposureHighlightContrastScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureHighlightContrastScale) & FPostProcessSettings.__PropertyMask_bOverride_LocalExposureHighlightContrastScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureHighlightContrastScale) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureHighlightContrastScale) & ~FPostProcessSettings.__PropertyMask_bOverride_LocalExposureHighlightContrastScale) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LocalExposureHighlightContrastScale : 0));
			}
		}

		// Token: 0x1700089E RID: 2206
		// (get) Token: 0x06003865 RID: 14437 RVA: 0x00050D96 File Offset: 0x0004EF96
		// (set) Token: 0x06003866 RID: 14438 RVA: 0x00050DAF File Offset: 0x0004EFAF
		public unsafe bool bOverride_LocalExposureShadowContrastScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureShadowContrastScale) & FPostProcessSettings.__PropertyMask_bOverride_LocalExposureShadowContrastScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureShadowContrastScale) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureShadowContrastScale) & ~FPostProcessSettings.__PropertyMask_bOverride_LocalExposureShadowContrastScale) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LocalExposureShadowContrastScale : 0));
			}
		}

		// Token: 0x1700089F RID: 2207
		// (get) Token: 0x06003867 RID: 14439 RVA: 0x00050DDF File Offset: 0x0004EFDF
		// (set) Token: 0x06003868 RID: 14440 RVA: 0x00050DF8 File Offset: 0x0004EFF8
		public unsafe bool bOverride_LocalExposureHighlightContrastCurve
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureHighlightContrastCurve) & FPostProcessSettings.__PropertyMask_bOverride_LocalExposureHighlightContrastCurve) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureHighlightContrastCurve) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureHighlightContrastCurve) & ~FPostProcessSettings.__PropertyMask_bOverride_LocalExposureHighlightContrastCurve) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LocalExposureHighlightContrastCurve : 0));
			}
		}

		// Token: 0x170008A0 RID: 2208
		// (get) Token: 0x06003869 RID: 14441 RVA: 0x00050E28 File Offset: 0x0004F028
		// (set) Token: 0x0600386A RID: 14442 RVA: 0x00050E41 File Offset: 0x0004F041
		public unsafe bool bOverride_LocalExposureShadowContrastCurve
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureShadowContrastCurve) & FPostProcessSettings.__PropertyMask_bOverride_LocalExposureShadowContrastCurve) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureShadowContrastCurve) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureShadowContrastCurve) & ~FPostProcessSettings.__PropertyMask_bOverride_LocalExposureShadowContrastCurve) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LocalExposureShadowContrastCurve : 0));
			}
		}

		// Token: 0x170008A1 RID: 2209
		// (get) Token: 0x0600386B RID: 14443 RVA: 0x00050E71 File Offset: 0x0004F071
		// (set) Token: 0x0600386C RID: 14444 RVA: 0x00050E8A File Offset: 0x0004F08A
		public unsafe bool bOverride_LocalExposureHighlightThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureHighlightThreshold) & FPostProcessSettings.__PropertyMask_bOverride_LocalExposureHighlightThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureHighlightThreshold) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureHighlightThreshold) & ~FPostProcessSettings.__PropertyMask_bOverride_LocalExposureHighlightThreshold) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LocalExposureHighlightThreshold : 0));
			}
		}

		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x0600386D RID: 14445 RVA: 0x00050EBA File Offset: 0x0004F0BA
		// (set) Token: 0x0600386E RID: 14446 RVA: 0x00050ED3 File Offset: 0x0004F0D3
		public unsafe bool bOverride_LocalExposureShadowThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureShadowThreshold) & FPostProcessSettings.__PropertyMask_bOverride_LocalExposureShadowThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureShadowThreshold) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureShadowThreshold) & ~FPostProcessSettings.__PropertyMask_bOverride_LocalExposureShadowThreshold) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LocalExposureShadowThreshold : 0));
			}
		}

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x0600386F RID: 14447 RVA: 0x00050F03 File Offset: 0x0004F103
		// (set) Token: 0x06003870 RID: 14448 RVA: 0x00050F1C File Offset: 0x0004F11C
		public unsafe bool bOverride_LocalExposureDetailStrength
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureDetailStrength) & FPostProcessSettings.__PropertyMask_bOverride_LocalExposureDetailStrength) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureDetailStrength) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureDetailStrength) & ~FPostProcessSettings.__PropertyMask_bOverride_LocalExposureDetailStrength) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LocalExposureDetailStrength : 0));
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06003871 RID: 14449 RVA: 0x00050F4C File Offset: 0x0004F14C
		// (set) Token: 0x06003872 RID: 14450 RVA: 0x00050F65 File Offset: 0x0004F165
		public unsafe bool bOverride_LocalExposureBlurredLuminanceBlend
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureBlurredLuminanceBlend) & FPostProcessSettings.__PropertyMask_bOverride_LocalExposureBlurredLuminanceBlend) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureBlurredLuminanceBlend) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureBlurredLuminanceBlend) & ~FPostProcessSettings.__PropertyMask_bOverride_LocalExposureBlurredLuminanceBlend) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LocalExposureBlurredLuminanceBlend : 0));
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06003873 RID: 14451 RVA: 0x00050F95 File Offset: 0x0004F195
		// (set) Token: 0x06003874 RID: 14452 RVA: 0x00050FAE File Offset: 0x0004F1AE
		public unsafe bool bOverride_LocalExposureBlurredLuminanceKernelSizePercent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureBlurredLuminanceKernelSizePercent) & FPostProcessSettings.__PropertyMask_bOverride_LocalExposureBlurredLuminanceKernelSizePercent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureBlurredLuminanceKernelSizePercent) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureBlurredLuminanceKernelSizePercent) & ~FPostProcessSettings.__PropertyMask_bOverride_LocalExposureBlurredLuminanceKernelSizePercent) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LocalExposureBlurredLuminanceKernelSizePercent : 0));
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06003875 RID: 14453 RVA: 0x00050FDE File Offset: 0x0004F1DE
		// (set) Token: 0x06003876 RID: 14454 RVA: 0x00050FF7 File Offset: 0x0004F1F7
		public unsafe bool bOverride_LocalExposureMiddleGreyBias
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureMiddleGreyBias) & FPostProcessSettings.__PropertyMask_bOverride_LocalExposureMiddleGreyBias) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureMiddleGreyBias) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LocalExposureMiddleGreyBias) & ~FPostProcessSettings.__PropertyMask_bOverride_LocalExposureMiddleGreyBias) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LocalExposureMiddleGreyBias : 0));
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06003877 RID: 14455 RVA: 0x00051027 File Offset: 0x0004F227
		// (set) Token: 0x06003878 RID: 14456 RVA: 0x00051040 File Offset: 0x0004F240
		public unsafe bool bOverride_LensFlareIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareIntensity) & FPostProcessSettings.__PropertyMask_bOverride_LensFlareIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_LensFlareIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LensFlareIntensity : 0));
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06003879 RID: 14457 RVA: 0x00051070 File Offset: 0x0004F270
		// (set) Token: 0x0600387A RID: 14458 RVA: 0x00051089 File Offset: 0x0004F289
		public unsafe bool bOverride_LensFlareTint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareTint) & FPostProcessSettings.__PropertyMask_bOverride_LensFlareTint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareTint) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareTint) & ~FPostProcessSettings.__PropertyMask_bOverride_LensFlareTint) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LensFlareTint : 0));
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x0600387B RID: 14459 RVA: 0x000510B9 File Offset: 0x0004F2B9
		// (set) Token: 0x0600387C RID: 14460 RVA: 0x000510D2 File Offset: 0x0004F2D2
		public unsafe bool bOverride_LensFlareTints
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareTints) & FPostProcessSettings.__PropertyMask_bOverride_LensFlareTints) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareTints) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareTints) & ~FPostProcessSettings.__PropertyMask_bOverride_LensFlareTints) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LensFlareTints : 0));
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x0600387D RID: 14461 RVA: 0x00051102 File Offset: 0x0004F302
		// (set) Token: 0x0600387E RID: 14462 RVA: 0x0005111B File Offset: 0x0004F31B
		public unsafe bool bOverride_LensFlareBokehSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareBokehSize) & FPostProcessSettings.__PropertyMask_bOverride_LensFlareBokehSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareBokehSize) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareBokehSize) & ~FPostProcessSettings.__PropertyMask_bOverride_LensFlareBokehSize) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LensFlareBokehSize : 0));
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x0600387F RID: 14463 RVA: 0x0005114B File Offset: 0x0004F34B
		// (set) Token: 0x06003880 RID: 14464 RVA: 0x00051164 File Offset: 0x0004F364
		public unsafe bool bOverride_LensFlareBokehShape
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareBokehShape) & FPostProcessSettings.__PropertyMask_bOverride_LensFlareBokehShape) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareBokehShape) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareBokehShape) & ~FPostProcessSettings.__PropertyMask_bOverride_LensFlareBokehShape) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LensFlareBokehShape : 0));
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06003881 RID: 14465 RVA: 0x00051194 File Offset: 0x0004F394
		// (set) Token: 0x06003882 RID: 14466 RVA: 0x000511AD File Offset: 0x0004F3AD
		public unsafe bool bOverride_LensFlareThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareThreshold) & FPostProcessSettings.__PropertyMask_bOverride_LensFlareThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareThreshold) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareThreshold) & ~FPostProcessSettings.__PropertyMask_bOverride_LensFlareThreshold) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LensFlareThreshold : 0));
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06003883 RID: 14467 RVA: 0x000511DD File Offset: 0x0004F3DD
		// (set) Token: 0x06003884 RID: 14468 RVA: 0x000511F6 File Offset: 0x0004F3F6
		public unsafe bool bOverride_LensFlareOnlySun
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareOnlySun) & FPostProcessSettings.__PropertyMask_bOverride_LensFlareOnlySun) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareOnlySun) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareOnlySun) & ~FPostProcessSettings.__PropertyMask_bOverride_LensFlareOnlySun) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LensFlareOnlySun : 0));
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06003885 RID: 14469 RVA: 0x00051226 File Offset: 0x0004F426
		// (set) Token: 0x06003886 RID: 14470 RVA: 0x0005123F File Offset: 0x0004F43F
		public unsafe bool bOverride_LensFlareSunRange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareSunRange) & FPostProcessSettings.__PropertyMask_bOverride_LensFlareSunRange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareSunRange) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareSunRange) & ~FPostProcessSettings.__PropertyMask_bOverride_LensFlareSunRange) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LensFlareSunRange : 0));
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06003887 RID: 14471 RVA: 0x0005126F File Offset: 0x0004F46F
		// (set) Token: 0x06003888 RID: 14472 RVA: 0x00051288 File Offset: 0x0004F488
		public unsafe bool bOverride_LensFlareSunPosition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareSunPosition) & FPostProcessSettings.__PropertyMask_bOverride_LensFlareSunPosition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareSunPosition) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LensFlareSunPosition) & ~FPostProcessSettings.__PropertyMask_bOverride_LensFlareSunPosition) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LensFlareSunPosition : 0));
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06003889 RID: 14473 RVA: 0x000512B8 File Offset: 0x0004F4B8
		// (set) Token: 0x0600388A RID: 14474 RVA: 0x000512D1 File Offset: 0x0004F4D1
		public unsafe bool bOverride_VignetteIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteIntensity) & FPostProcessSettings.__PropertyMask_bOverride_VignetteIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_VignetteIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VignetteIntensity : 0));
			}
		}

		// Token: 0x170008B1 RID: 2225
		// (get) Token: 0x0600388B RID: 14475 RVA: 0x00051301 File Offset: 0x0004F501
		// (set) Token: 0x0600388C RID: 14476 RVA: 0x0005131A File Offset: 0x0004F51A
		public unsafe bool bOverride_VignetteHardness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteHardness) & FPostProcessSettings.__PropertyMask_bOverride_VignetteHardness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteHardness) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteHardness) & ~FPostProcessSettings.__PropertyMask_bOverride_VignetteHardness) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VignetteHardness : 0));
			}
		}

		// Token: 0x170008B2 RID: 2226
		// (get) Token: 0x0600388D RID: 14477 RVA: 0x0005134A File Offset: 0x0004F54A
		// (set) Token: 0x0600388E RID: 14478 RVA: 0x00051363 File Offset: 0x0004F563
		public unsafe bool bOverride_VignetteXScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteXScale) & FPostProcessSettings.__PropertyMask_bOverride_VignetteXScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteXScale) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteXScale) & ~FPostProcessSettings.__PropertyMask_bOverride_VignetteXScale) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VignetteXScale : 0));
			}
		}

		// Token: 0x170008B3 RID: 2227
		// (get) Token: 0x0600388F RID: 14479 RVA: 0x00051393 File Offset: 0x0004F593
		// (set) Token: 0x06003890 RID: 14480 RVA: 0x000513AC File Offset: 0x0004F5AC
		public unsafe bool bOverride_VignetteYScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteYScale) & FPostProcessSettings.__PropertyMask_bOverride_VignetteYScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteYScale) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteYScale) & ~FPostProcessSettings.__PropertyMask_bOverride_VignetteYScale) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VignetteYScale : 0));
			}
		}

		// Token: 0x170008B4 RID: 2228
		// (get) Token: 0x06003891 RID: 14481 RVA: 0x000513DC File Offset: 0x0004F5DC
		// (set) Token: 0x06003892 RID: 14482 RVA: 0x000513F5 File Offset: 0x0004F5F5
		public unsafe bool bOverride_VignetteXPos
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteXPos) & FPostProcessSettings.__PropertyMask_bOverride_VignetteXPos) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteXPos) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteXPos) & ~FPostProcessSettings.__PropertyMask_bOverride_VignetteXPos) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VignetteXPos : 0));
			}
		}

		// Token: 0x170008B5 RID: 2229
		// (get) Token: 0x06003893 RID: 14483 RVA: 0x00051425 File Offset: 0x0004F625
		// (set) Token: 0x06003894 RID: 14484 RVA: 0x0005143E File Offset: 0x0004F63E
		public unsafe bool bOverride_VignetteYPos
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteYPos) & FPostProcessSettings.__PropertyMask_bOverride_VignetteYPos) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteYPos) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteYPos) & ~FPostProcessSettings.__PropertyMask_bOverride_VignetteYPos) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VignetteYPos : 0));
			}
		}

		// Token: 0x170008B6 RID: 2230
		// (get) Token: 0x06003895 RID: 14485 RVA: 0x0005146E File Offset: 0x0004F66E
		// (set) Token: 0x06003896 RID: 14486 RVA: 0x00051487 File Offset: 0x0004F687
		public unsafe bool bOverride_VignetteColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteColor) & FPostProcessSettings.__PropertyMask_bOverride_VignetteColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteColor) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteColor) & ~FPostProcessSettings.__PropertyMask_bOverride_VignetteColor) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VignetteColor : 0));
			}
		}

		// Token: 0x170008B7 RID: 2231
		// (get) Token: 0x06003897 RID: 14487 RVA: 0x000514B7 File Offset: 0x0004F6B7
		// (set) Token: 0x06003898 RID: 14488 RVA: 0x000514D0 File Offset: 0x0004F6D0
		public unsafe bool bOverride_VignetteGain
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteGain) & FPostProcessSettings.__PropertyMask_bOverride_VignetteGain) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteGain) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VignetteGain) & ~FPostProcessSettings.__PropertyMask_bOverride_VignetteGain) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VignetteGain : 0));
			}
		}

		// Token: 0x170008B8 RID: 2232
		// (get) Token: 0x06003899 RID: 14489 RVA: 0x00051500 File Offset: 0x0004F700
		// (set) Token: 0x0600389A RID: 14490 RVA: 0x00051519 File Offset: 0x0004F719
		public unsafe bool bOverride_EffectVignetteIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteIntensity) & FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteIntensity : 0));
			}
		}

		// Token: 0x170008B9 RID: 2233
		// (get) Token: 0x0600389B RID: 14491 RVA: 0x00051549 File Offset: 0x0004F749
		// (set) Token: 0x0600389C RID: 14492 RVA: 0x00051562 File Offset: 0x0004F762
		public unsafe bool bOverride_EffectVignetteHardness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteHardness) & FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteHardness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteHardness) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteHardness) & ~FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteHardness) | (value ? FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteHardness : 0));
			}
		}

		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x0600389D RID: 14493 RVA: 0x00051592 File Offset: 0x0004F792
		// (set) Token: 0x0600389E RID: 14494 RVA: 0x000515AB File Offset: 0x0004F7AB
		public unsafe bool bOverride_EffectVignetteXScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteXScale) & FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteXScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteXScale) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteXScale) & ~FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteXScale) | (value ? FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteXScale : 0));
			}
		}

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x0600389F RID: 14495 RVA: 0x000515DB File Offset: 0x0004F7DB
		// (set) Token: 0x060038A0 RID: 14496 RVA: 0x000515F4 File Offset: 0x0004F7F4
		public unsafe bool bOverride_EffectVignetteYScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteYScale) & FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteYScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteYScale) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteYScale) & ~FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteYScale) | (value ? FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteYScale : 0));
			}
		}

		// Token: 0x170008BC RID: 2236
		// (get) Token: 0x060038A1 RID: 14497 RVA: 0x00051624 File Offset: 0x0004F824
		// (set) Token: 0x060038A2 RID: 14498 RVA: 0x0005163D File Offset: 0x0004F83D
		public unsafe bool bOverride_EffectVignetteXPos
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteXPos) & FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteXPos) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteXPos) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteXPos) & ~FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteXPos) | (value ? FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteXPos : 0));
			}
		}

		// Token: 0x170008BD RID: 2237
		// (get) Token: 0x060038A3 RID: 14499 RVA: 0x0005166D File Offset: 0x0004F86D
		// (set) Token: 0x060038A4 RID: 14500 RVA: 0x00051686 File Offset: 0x0004F886
		public unsafe bool bOverride_EffectVignetteYPos
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteYPos) & FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteYPos) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteYPos) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteYPos) & ~FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteYPos) | (value ? FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteYPos : 0));
			}
		}

		// Token: 0x170008BE RID: 2238
		// (get) Token: 0x060038A5 RID: 14501 RVA: 0x000516B6 File Offset: 0x0004F8B6
		// (set) Token: 0x060038A6 RID: 14502 RVA: 0x000516CF File Offset: 0x0004F8CF
		public unsafe bool bOverride_EffectVignetteColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteColor) & FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteColor) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteColor) & ~FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteColor) | (value ? FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteColor : 0));
			}
		}

		// Token: 0x170008BF RID: 2239
		// (get) Token: 0x060038A7 RID: 14503 RVA: 0x000516FF File Offset: 0x0004F8FF
		// (set) Token: 0x060038A8 RID: 14504 RVA: 0x00051718 File Offset: 0x0004F918
		public unsafe bool bOverride_EffectVignetteGain
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteGain) & FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteGain) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteGain) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EffectVignetteGain) & ~FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteGain) | (value ? FPostProcessSettings.__PropertyMask_bOverride_EffectVignetteGain : 0));
			}
		}

		// Token: 0x170008C0 RID: 2240
		// (get) Token: 0x060038A9 RID: 14505 RVA: 0x00051748 File Offset: 0x0004F948
		// (set) Token: 0x060038AA RID: 14506 RVA: 0x00051761 File Offset: 0x0004F961
		public unsafe bool bOverride_GrainIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrainIntensity) & FPostProcessSettings.__PropertyMask_bOverride_GrainIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrainIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrainIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_GrainIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_GrainIntensity : 0));
			}
		}

		// Token: 0x170008C1 RID: 2241
		// (get) Token: 0x060038AB RID: 14507 RVA: 0x00051791 File Offset: 0x0004F991
		// (set) Token: 0x060038AC RID: 14508 RVA: 0x000517AA File Offset: 0x0004F9AA
		public unsafe bool bOverride_GrainJitter
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrainJitter) & FPostProcessSettings.__PropertyMask_bOverride_GrainJitter) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrainJitter) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrainJitter) & ~FPostProcessSettings.__PropertyMask_bOverride_GrainJitter) | (value ? FPostProcessSettings.__PropertyMask_bOverride_GrainJitter : 0));
			}
		}

		// Token: 0x170008C2 RID: 2242
		// (get) Token: 0x060038AD RID: 14509 RVA: 0x000517DA File Offset: 0x0004F9DA
		// (set) Token: 0x060038AE RID: 14510 RVA: 0x000517F3 File Offset: 0x0004F9F3
		public unsafe bool bOverride_GrainColorful
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrainColorful) & FPostProcessSettings.__PropertyMask_bOverride_GrainColorful) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrainColorful) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrainColorful) & ~FPostProcessSettings.__PropertyMask_bOverride_GrainColorful) | (value ? FPostProcessSettings.__PropertyMask_bOverride_GrainColorful : 0));
			}
		}

		// Token: 0x170008C3 RID: 2243
		// (get) Token: 0x060038AF RID: 14511 RVA: 0x00051823 File Offset: 0x0004FA23
		// (set) Token: 0x060038B0 RID: 14512 RVA: 0x0005183C File Offset: 0x0004FA3C
		public unsafe bool bOverride_MainCenterMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MainCenterMask) & FPostProcessSettings.__PropertyMask_bOverride_MainCenterMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MainCenterMask) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MainCenterMask) & ~FPostProcessSettings.__PropertyMask_bOverride_MainCenterMask) | (value ? FPostProcessSettings.__PropertyMask_bOverride_MainCenterMask : 0));
			}
		}

		// Token: 0x170008C4 RID: 2244
		// (get) Token: 0x060038B1 RID: 14513 RVA: 0x0005186C File Offset: 0x0004FA6C
		// (set) Token: 0x060038B2 RID: 14514 RVA: 0x00051885 File Offset: 0x0004FA85
		public unsafe bool bOverride_MainCenterMaskRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MainCenterMaskRadius) & FPostProcessSettings.__PropertyMask_bOverride_MainCenterMaskRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MainCenterMaskRadius) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MainCenterMaskRadius) & ~FPostProcessSettings.__PropertyMask_bOverride_MainCenterMaskRadius) | (value ? FPostProcessSettings.__PropertyMask_bOverride_MainCenterMaskRadius : 0));
			}
		}

		// Token: 0x170008C5 RID: 2245
		// (get) Token: 0x060038B3 RID: 14515 RVA: 0x000518B5 File Offset: 0x0004FAB5
		// (set) Token: 0x060038B4 RID: 14516 RVA: 0x000518CE File Offset: 0x0004FACE
		public unsafe bool bOverride_MainCenterMaskHardness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MainCenterMaskHardness) & FPostProcessSettings.__PropertyMask_bOverride_MainCenterMaskHardness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MainCenterMaskHardness) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MainCenterMaskHardness) & ~FPostProcessSettings.__PropertyMask_bOverride_MainCenterMaskHardness) | (value ? FPostProcessSettings.__PropertyMask_bOverride_MainCenterMaskHardness : 0));
			}
		}

		// Token: 0x170008C6 RID: 2246
		// (get) Token: 0x060038B5 RID: 14517 RVA: 0x000518FE File Offset: 0x0004FAFE
		// (set) Token: 0x060038B6 RID: 14518 RVA: 0x00051917 File Offset: 0x0004FB17
		public unsafe bool bOverride_MainStartDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MainStartDistance) & FPostProcessSettings.__PropertyMask_bOverride_MainStartDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MainStartDistance) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MainStartDistance) & ~FPostProcessSettings.__PropertyMask_bOverride_MainStartDistance) | (value ? FPostProcessSettings.__PropertyMask_bOverride_MainStartDistance : 0));
			}
		}

		// Token: 0x170008C7 RID: 2247
		// (get) Token: 0x060038B7 RID: 14519 RVA: 0x00051947 File Offset: 0x0004FB47
		// (set) Token: 0x060038B8 RID: 14520 RVA: 0x00051960 File Offset: 0x0004FB60
		public unsafe bool bOverride_MainCharacterIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MainCharacterIntensity) & FPostProcessSettings.__PropertyMask_bOverride_MainCharacterIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MainCharacterIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MainCharacterIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_MainCharacterIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_MainCharacterIntensity : 0));
			}
		}

		// Token: 0x170008C8 RID: 2248
		// (get) Token: 0x060038B9 RID: 14521 RVA: 0x00051990 File Offset: 0x0004FB90
		// (set) Token: 0x060038BA RID: 14522 RVA: 0x000519A9 File Offset: 0x0004FBA9
		public unsafe bool bOverride_VintageColorIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VintageColorIntensity) & FPostProcessSettings.__PropertyMask_bOverride_VintageColorIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VintageColorIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VintageColorIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_VintageColorIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VintageColorIntensity : 0));
			}
		}

		// Token: 0x170008C9 RID: 2249
		// (get) Token: 0x060038BB RID: 14523 RVA: 0x000519D9 File Offset: 0x0004FBD9
		// (set) Token: 0x060038BC RID: 14524 RVA: 0x000519F2 File Offset: 0x0004FBF2
		public unsafe bool bOverride_VintageColorBlackPoint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VintageColorBlackPoint) & FPostProcessSettings.__PropertyMask_bOverride_VintageColorBlackPoint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VintageColorBlackPoint) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VintageColorBlackPoint) & ~FPostProcessSettings.__PropertyMask_bOverride_VintageColorBlackPoint) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VintageColorBlackPoint : 0));
			}
		}

		// Token: 0x170008CA RID: 2250
		// (get) Token: 0x060038BD RID: 14525 RVA: 0x00051A22 File Offset: 0x0004FC22
		// (set) Token: 0x060038BE RID: 14526 RVA: 0x00051A3B File Offset: 0x0004FC3B
		public unsafe bool bOverride_VintageColorWhitePoint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VintageColorWhitePoint) & FPostProcessSettings.__PropertyMask_bOverride_VintageColorWhitePoint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VintageColorWhitePoint) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VintageColorWhitePoint) & ~FPostProcessSettings.__PropertyMask_bOverride_VintageColorWhitePoint) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VintageColorWhitePoint : 0));
			}
		}

		// Token: 0x170008CB RID: 2251
		// (get) Token: 0x060038BF RID: 14527 RVA: 0x00051A6B File Offset: 0x0004FC6B
		// (set) Token: 0x060038C0 RID: 14528 RVA: 0x00051A84 File Offset: 0x0004FC84
		public unsafe bool bOverride_VHSLinesColorIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSLinesColorIntensity) & FPostProcessSettings.__PropertyMask_bOverride_VHSLinesColorIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSLinesColorIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSLinesColorIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_VHSLinesColorIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VHSLinesColorIntensity : 0));
			}
		}

		// Token: 0x170008CC RID: 2252
		// (get) Token: 0x060038C1 RID: 14529 RVA: 0x00051AB4 File Offset: 0x0004FCB4
		// (set) Token: 0x060038C2 RID: 14530 RVA: 0x00051ACD File Offset: 0x0004FCCD
		public unsafe bool bOverride_VHSLinesDistortIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSLinesDistortIntensity) & FPostProcessSettings.__PropertyMask_bOverride_VHSLinesDistortIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSLinesDistortIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSLinesDistortIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_VHSLinesDistortIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VHSLinesDistortIntensity : 0));
			}
		}

		// Token: 0x170008CD RID: 2253
		// (get) Token: 0x060038C3 RID: 14531 RVA: 0x00051AFD File Offset: 0x0004FCFD
		// (set) Token: 0x060038C4 RID: 14532 RVA: 0x00051B16 File Offset: 0x0004FD16
		public unsafe bool bOverride_VHSEffectIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSEffectIntensity) & FPostProcessSettings.__PropertyMask_bOverride_VHSEffectIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSEffectIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSEffectIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_VHSEffectIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VHSEffectIntensity : 0));
			}
		}

		// Token: 0x170008CE RID: 2254
		// (get) Token: 0x060038C5 RID: 14533 RVA: 0x00051B46 File Offset: 0x0004FD46
		// (set) Token: 0x060038C6 RID: 14534 RVA: 0x00051B5F File Offset: 0x0004FD5F
		public unsafe bool bOverride_VHSSpecklesIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSSpecklesIntensity) & FPostProcessSettings.__PropertyMask_bOverride_VHSSpecklesIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSSpecklesIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSSpecklesIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_VHSSpecklesIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VHSSpecklesIntensity : 0));
			}
		}

		// Token: 0x170008CF RID: 2255
		// (get) Token: 0x060038C7 RID: 14535 RVA: 0x00051B8F File Offset: 0x0004FD8F
		// (set) Token: 0x060038C8 RID: 14536 RVA: 0x00051BA8 File Offset: 0x0004FDA8
		public unsafe bool bOverride_VHSSpecklesAmount
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSSpecklesAmount) & FPostProcessSettings.__PropertyMask_bOverride_VHSSpecklesAmount) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSSpecklesAmount) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSSpecklesAmount) & ~FPostProcessSettings.__PropertyMask_bOverride_VHSSpecklesAmount) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VHSSpecklesAmount : 0));
			}
		}

		// Token: 0x170008D0 RID: 2256
		// (get) Token: 0x060038C9 RID: 14537 RVA: 0x00051BD8 File Offset: 0x0004FDD8
		// (set) Token: 0x060038CA RID: 14538 RVA: 0x00051BF1 File Offset: 0x0004FDF1
		public unsafe bool bOverride_VHSSpecklesSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSSpecklesSize) & FPostProcessSettings.__PropertyMask_bOverride_VHSSpecklesSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSSpecklesSize) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSSpecklesSize) & ~FPostProcessSettings.__PropertyMask_bOverride_VHSSpecklesSize) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VHSSpecklesSize : 0));
			}
		}

		// Token: 0x170008D1 RID: 2257
		// (get) Token: 0x060038CB RID: 14539 RVA: 0x00051C21 File Offset: 0x0004FE21
		// (set) Token: 0x060038CC RID: 14540 RVA: 0x00051C3A File Offset: 0x0004FE3A
		public unsafe bool bOverride_CRTDistortion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_CRTDistortion) & FPostProcessSettings.__PropertyMask_bOverride_CRTDistortion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_CRTDistortion) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_CRTDistortion) & ~FPostProcessSettings.__PropertyMask_bOverride_CRTDistortion) | (value ? FPostProcessSettings.__PropertyMask_bOverride_CRTDistortion : 0));
			}
		}

		// Token: 0x170008D2 RID: 2258
		// (get) Token: 0x060038CD RID: 14541 RVA: 0x00051C6A File Offset: 0x0004FE6A
		// (set) Token: 0x060038CE RID: 14542 RVA: 0x00051C83 File Offset: 0x0004FE83
		public unsafe bool bOverride_VintageColorCenterMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VintageColorCenterMask) & FPostProcessSettings.__PropertyMask_bOverride_VintageColorCenterMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VintageColorCenterMask) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VintageColorCenterMask) & ~FPostProcessSettings.__PropertyMask_bOverride_VintageColorCenterMask) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VintageColorCenterMask : 0));
			}
		}

		// Token: 0x170008D3 RID: 2259
		// (get) Token: 0x060038CF RID: 14543 RVA: 0x00051CB3 File Offset: 0x0004FEB3
		// (set) Token: 0x060038D0 RID: 14544 RVA: 0x00051CCC File Offset: 0x0004FECC
		public unsafe bool bOverride_VintageColorStartDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VintageColorStartDistance) & FPostProcessSettings.__PropertyMask_bOverride_VintageColorStartDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VintageColorStartDistance) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VintageColorStartDistance) & ~FPostProcessSettings.__PropertyMask_bOverride_VintageColorStartDistance) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VintageColorStartDistance : 0));
			}
		}

		// Token: 0x170008D4 RID: 2260
		// (get) Token: 0x060038D1 RID: 14545 RVA: 0x00051CFC File Offset: 0x0004FEFC
		// (set) Token: 0x060038D2 RID: 14546 RVA: 0x00051D15 File Offset: 0x0004FF15
		public unsafe bool bOverride_VintageColorCharacterIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VintageColorCharacterIntensity) & FPostProcessSettings.__PropertyMask_bOverride_VintageColorCharacterIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VintageColorCharacterIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VintageColorCharacterIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_VintageColorCharacterIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VintageColorCharacterIntensity : 0));
			}
		}

		// Token: 0x170008D5 RID: 2261
		// (get) Token: 0x060038D3 RID: 14547 RVA: 0x00051D45 File Offset: 0x0004FF45
		// (set) Token: 0x060038D4 RID: 14548 RVA: 0x00051D5E File Offset: 0x0004FF5E
		public unsafe bool bOverride_VHSLinesCenterMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSLinesCenterMask) & FPostProcessSettings.__PropertyMask_bOverride_VHSLinesCenterMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSLinesCenterMask) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSLinesCenterMask) & ~FPostProcessSettings.__PropertyMask_bOverride_VHSLinesCenterMask) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VHSLinesCenterMask : 0));
			}
		}

		// Token: 0x170008D6 RID: 2262
		// (get) Token: 0x060038D5 RID: 14549 RVA: 0x00051D8E File Offset: 0x0004FF8E
		// (set) Token: 0x060038D6 RID: 14550 RVA: 0x00051DA7 File Offset: 0x0004FFA7
		public unsafe bool bOverride_VHSLinesStartDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSLinesStartDistance) & FPostProcessSettings.__PropertyMask_bOverride_VHSLinesStartDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSLinesStartDistance) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSLinesStartDistance) & ~FPostProcessSettings.__PropertyMask_bOverride_VHSLinesStartDistance) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VHSLinesStartDistance : 0));
			}
		}

		// Token: 0x170008D7 RID: 2263
		// (get) Token: 0x060038D7 RID: 14551 RVA: 0x00051DD7 File Offset: 0x0004FFD7
		// (set) Token: 0x060038D8 RID: 14552 RVA: 0x00051DF0 File Offset: 0x0004FFF0
		public unsafe bool bOverride_VHSLinesCharacterIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSLinesCharacterIntensity) & FPostProcessSettings.__PropertyMask_bOverride_VHSLinesCharacterIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSLinesCharacterIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSLinesCharacterIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_VHSLinesCharacterIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VHSLinesCharacterIntensity : 0));
			}
		}

		// Token: 0x170008D8 RID: 2264
		// (get) Token: 0x060038D9 RID: 14553 RVA: 0x00051E20 File Offset: 0x00050020
		// (set) Token: 0x060038DA RID: 14554 RVA: 0x00051E39 File Offset: 0x00050039
		public unsafe bool bOverride_VHSEffectCenterMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSEffectCenterMask) & FPostProcessSettings.__PropertyMask_bOverride_VHSEffectCenterMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSEffectCenterMask) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSEffectCenterMask) & ~FPostProcessSettings.__PropertyMask_bOverride_VHSEffectCenterMask) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VHSEffectCenterMask : 0));
			}
		}

		// Token: 0x170008D9 RID: 2265
		// (get) Token: 0x060038DB RID: 14555 RVA: 0x00051E69 File Offset: 0x00050069
		// (set) Token: 0x060038DC RID: 14556 RVA: 0x00051E82 File Offset: 0x00050082
		public unsafe bool bOverride_VHSEffectStartDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSEffectStartDistance) & FPostProcessSettings.__PropertyMask_bOverride_VHSEffectStartDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSEffectStartDistance) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSEffectStartDistance) & ~FPostProcessSettings.__PropertyMask_bOverride_VHSEffectStartDistance) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VHSEffectStartDistance : 0));
			}
		}

		// Token: 0x170008DA RID: 2266
		// (get) Token: 0x060038DD RID: 14557 RVA: 0x00051EB2 File Offset: 0x000500B2
		// (set) Token: 0x060038DE RID: 14558 RVA: 0x00051ECB File Offset: 0x000500CB
		public unsafe bool bOverride_VHSEffectCharacterIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSEffectCharacterIntensity) & FPostProcessSettings.__PropertyMask_bOverride_VHSEffectCharacterIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSEffectCharacterIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSEffectCharacterIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_VHSEffectCharacterIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VHSEffectCharacterIntensity : 0));
			}
		}

		// Token: 0x170008DB RID: 2267
		// (get) Token: 0x060038DF RID: 14559 RVA: 0x00051EFB File Offset: 0x000500FB
		// (set) Token: 0x060038E0 RID: 14560 RVA: 0x00051F14 File Offset: 0x00050114
		public unsafe bool bOverride_VHSSpecklesCenterMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSSpecklesCenterMask) & FPostProcessSettings.__PropertyMask_bOverride_VHSSpecklesCenterMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSSpecklesCenterMask) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSSpecklesCenterMask) & ~FPostProcessSettings.__PropertyMask_bOverride_VHSSpecklesCenterMask) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VHSSpecklesCenterMask : 0));
			}
		}

		// Token: 0x170008DC RID: 2268
		// (get) Token: 0x060038E1 RID: 14561 RVA: 0x00051F44 File Offset: 0x00050144
		// (set) Token: 0x060038E2 RID: 14562 RVA: 0x00051F5D File Offset: 0x0005015D
		public unsafe bool bOverride_VHSSpecklesStartDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSSpecklesStartDistance) & FPostProcessSettings.__PropertyMask_bOverride_VHSSpecklesStartDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSSpecklesStartDistance) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSSpecklesStartDistance) & ~FPostProcessSettings.__PropertyMask_bOverride_VHSSpecklesStartDistance) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VHSSpecklesStartDistance : 0));
			}
		}

		// Token: 0x170008DD RID: 2269
		// (get) Token: 0x060038E3 RID: 14563 RVA: 0x00051F8D File Offset: 0x0005018D
		// (set) Token: 0x060038E4 RID: 14564 RVA: 0x00051FA6 File Offset: 0x000501A6
		public unsafe bool bOverride_VHSSpecklesCharacterIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSSpecklesCharacterIntensity) & FPostProcessSettings.__PropertyMask_bOverride_VHSSpecklesCharacterIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSSpecklesCharacterIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_VHSSpecklesCharacterIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_VHSSpecklesCharacterIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_VHSSpecklesCharacterIntensity : 0));
			}
		}

		// Token: 0x170008DE RID: 2270
		// (get) Token: 0x060038E5 RID: 14565 RVA: 0x00051FD6 File Offset: 0x000501D6
		// (set) Token: 0x060038E6 RID: 14566 RVA: 0x00051FEF File Offset: 0x000501EF
		public unsafe bool bOverride_AmbientOcclusionIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionIntensity) & FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionIntensity : 0));
			}
		}

		// Token: 0x170008DF RID: 2271
		// (get) Token: 0x060038E7 RID: 14567 RVA: 0x0005201F File Offset: 0x0005021F
		// (set) Token: 0x060038E8 RID: 14568 RVA: 0x00052038 File Offset: 0x00050238
		public unsafe bool bOverride_ToonAmbientOcclusionEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonAmbientOcclusionEnabled) & FPostProcessSettings.__PropertyMask_bOverride_ToonAmbientOcclusionEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonAmbientOcclusionEnabled) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonAmbientOcclusionEnabled) & ~FPostProcessSettings.__PropertyMask_bOverride_ToonAmbientOcclusionEnabled) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ToonAmbientOcclusionEnabled : 0));
			}
		}

		// Token: 0x170008E0 RID: 2272
		// (get) Token: 0x060038E9 RID: 14569 RVA: 0x00052068 File Offset: 0x00050268
		// (set) Token: 0x060038EA RID: 14570 RVA: 0x00052081 File Offset: 0x00050281
		public unsafe bool bOverride_ToonAmbientOcclusionRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonAmbientOcclusionRadius) & FPostProcessSettings.__PropertyMask_bOverride_ToonAmbientOcclusionRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonAmbientOcclusionRadius) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonAmbientOcclusionRadius) & ~FPostProcessSettings.__PropertyMask_bOverride_ToonAmbientOcclusionRadius) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ToonAmbientOcclusionRadius : 0));
			}
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x060038EB RID: 14571 RVA: 0x000520B1 File Offset: 0x000502B1
		// (set) Token: 0x060038EC RID: 14572 RVA: 0x000520CA File Offset: 0x000502CA
		public unsafe bool bOverride_ToonAmbientOcclusionIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonAmbientOcclusionIntensity) & FPostProcessSettings.__PropertyMask_bOverride_ToonAmbientOcclusionIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonAmbientOcclusionIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonAmbientOcclusionIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_ToonAmbientOcclusionIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ToonAmbientOcclusionIntensity : 0));
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x060038ED RID: 14573 RVA: 0x000520FA File Offset: 0x000502FA
		// (set) Token: 0x060038EE RID: 14574 RVA: 0x00052113 File Offset: 0x00050313
		public unsafe bool bOverride_ToonAmbientOcclusionPower
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonAmbientOcclusionPower) & FPostProcessSettings.__PropertyMask_bOverride_ToonAmbientOcclusionPower) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonAmbientOcclusionPower) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonAmbientOcclusionPower) & ~FPostProcessSettings.__PropertyMask_bOverride_ToonAmbientOcclusionPower) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ToonAmbientOcclusionPower : 0));
			}
		}

		// Token: 0x170008E3 RID: 2275
		// (get) Token: 0x060038EF RID: 14575 RVA: 0x00052143 File Offset: 0x00050343
		// (set) Token: 0x060038F0 RID: 14576 RVA: 0x0005215C File Offset: 0x0005035C
		public unsafe bool bOverride_ToonAmbientOcclusionColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonAmbientOcclusionColor) & FPostProcessSettings.__PropertyMask_bOverride_ToonAmbientOcclusionColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonAmbientOcclusionColor) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ToonAmbientOcclusionColor) & ~FPostProcessSettings.__PropertyMask_bOverride_ToonAmbientOcclusionColor) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ToonAmbientOcclusionColor : 0));
			}
		}

		// Token: 0x170008E4 RID: 2276
		// (get) Token: 0x060038F1 RID: 14577 RVA: 0x0005218C File Offset: 0x0005038C
		// (set) Token: 0x060038F2 RID: 14578 RVA: 0x000521A5 File Offset: 0x000503A5
		public unsafe bool bOverride_AmbientOcclusionStaticFraction
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionStaticFraction) & FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionStaticFraction) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionStaticFraction) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionStaticFraction) & ~FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionStaticFraction) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionStaticFraction : 0));
			}
		}

		// Token: 0x170008E5 RID: 2277
		// (get) Token: 0x060038F3 RID: 14579 RVA: 0x000521D5 File Offset: 0x000503D5
		// (set) Token: 0x060038F4 RID: 14580 RVA: 0x000521EE File Offset: 0x000503EE
		public unsafe bool bOverride_AmbientOcclusionRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionRadius) & FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionRadius) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionRadius) & ~FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionRadius) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionRadius : 0));
			}
		}

		// Token: 0x170008E6 RID: 2278
		// (get) Token: 0x060038F5 RID: 14581 RVA: 0x0005221E File Offset: 0x0005041E
		// (set) Token: 0x060038F6 RID: 14582 RVA: 0x00052237 File Offset: 0x00050437
		public unsafe bool bOverride_AmbientOcclusionFadeDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionFadeDistance) & FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionFadeDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionFadeDistance) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionFadeDistance) & ~FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionFadeDistance) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionFadeDistance : 0));
			}
		}

		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x060038F7 RID: 14583 RVA: 0x00052267 File Offset: 0x00050467
		// (set) Token: 0x060038F8 RID: 14584 RVA: 0x00052280 File Offset: 0x00050480
		public unsafe bool bOverride_AmbientOcclusionFadeRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionFadeRadius) & FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionFadeRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionFadeRadius) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionFadeRadius) & ~FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionFadeRadius) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionFadeRadius : 0));
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x060038F9 RID: 14585 RVA: 0x000522B0 File Offset: 0x000504B0
		// (set) Token: 0x060038FA RID: 14586 RVA: 0x000522C9 File Offset: 0x000504C9
		public unsafe bool bOverride_AmbientOcclusionDistance_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionDistance_DEPRECATED) & FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionDistance_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionDistance_DEPRECATED) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionDistance_DEPRECATED) & ~FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionDistance_DEPRECATED) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionDistance_DEPRECATED : 0));
			}
		}

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x060038FB RID: 14587 RVA: 0x000522F9 File Offset: 0x000504F9
		// (set) Token: 0x060038FC RID: 14588 RVA: 0x00052312 File Offset: 0x00050512
		public unsafe bool bOverride_AmbientOcclusionRadiusInWS
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionRadiusInWS) & FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionRadiusInWS) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionRadiusInWS) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionRadiusInWS) & ~FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionRadiusInWS) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionRadiusInWS : 0));
			}
		}

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x060038FD RID: 14589 RVA: 0x00052342 File Offset: 0x00050542
		// (set) Token: 0x060038FE RID: 14590 RVA: 0x0005235B File Offset: 0x0005055B
		public unsafe bool bOverride_AmbientOcclusionPower
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionPower) & FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionPower) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionPower) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionPower) & ~FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionPower) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionPower : 0));
			}
		}

		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x060038FF RID: 14591 RVA: 0x0005238B File Offset: 0x0005058B
		// (set) Token: 0x06003900 RID: 14592 RVA: 0x000523A4 File Offset: 0x000505A4
		public unsafe bool bOverride_AmbientOcclusionBias
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionBias) & FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionBias) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionBias) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionBias) & ~FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionBias) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionBias : 0));
			}
		}

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06003901 RID: 14593 RVA: 0x000523D4 File Offset: 0x000505D4
		// (set) Token: 0x06003902 RID: 14594 RVA: 0x000523ED File Offset: 0x000505ED
		public unsafe bool bOverride_AmbientOcclusionQuality
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionQuality) & FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionQuality) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionQuality) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionQuality) & ~FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionQuality) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionQuality : 0));
			}
		}

		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06003903 RID: 14595 RVA: 0x0005241D File Offset: 0x0005061D
		// (set) Token: 0x06003904 RID: 14596 RVA: 0x00052436 File Offset: 0x00050636
		public unsafe bool bOverride_AmbientOcclusionMipBlend
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionMipBlend) & FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionMipBlend) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionMipBlend) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionMipBlend) & ~FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionMipBlend) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionMipBlend : 0));
			}
		}

		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06003905 RID: 14597 RVA: 0x00052466 File Offset: 0x00050666
		// (set) Token: 0x06003906 RID: 14598 RVA: 0x0005247F File Offset: 0x0005067F
		public unsafe bool bOverride_AmbientOcclusionMipScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionMipScale) & FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionMipScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionMipScale) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionMipScale) & ~FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionMipScale) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionMipScale : 0));
			}
		}

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x06003907 RID: 14599 RVA: 0x000524AF File Offset: 0x000506AF
		// (set) Token: 0x06003908 RID: 14600 RVA: 0x000524C8 File Offset: 0x000506C8
		public unsafe bool bOverride_AmbientOcclusionMipThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionMipThreshold) & FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionMipThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionMipThreshold) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionMipThreshold) & ~FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionMipThreshold) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionMipThreshold : 0));
			}
		}

		// Token: 0x170008F0 RID: 2288
		// (get) Token: 0x06003909 RID: 14601 RVA: 0x000524F8 File Offset: 0x000506F8
		// (set) Token: 0x0600390A RID: 14602 RVA: 0x00052511 File Offset: 0x00050711
		public unsafe bool bOverride_AmbientOcclusionTemporalBlendWeight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionTemporalBlendWeight) & FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionTemporalBlendWeight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionTemporalBlendWeight) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AmbientOcclusionTemporalBlendWeight) & ~FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionTemporalBlendWeight) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AmbientOcclusionTemporalBlendWeight : 0));
			}
		}

		// Token: 0x170008F1 RID: 2289
		// (get) Token: 0x0600390B RID: 14603 RVA: 0x00052541 File Offset: 0x00050741
		// (set) Token: 0x0600390C RID: 14604 RVA: 0x0005255A File Offset: 0x0005075A
		public unsafe bool bOverride_RayTracingAO
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingAO) & FPostProcessSettings.__PropertyMask_bOverride_RayTracingAO) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingAO) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingAO) & ~FPostProcessSettings.__PropertyMask_bOverride_RayTracingAO) | (value ? FPostProcessSettings.__PropertyMask_bOverride_RayTracingAO : 0));
			}
		}

		// Token: 0x170008F2 RID: 2290
		// (get) Token: 0x0600390D RID: 14605 RVA: 0x0005258A File Offset: 0x0005078A
		// (set) Token: 0x0600390E RID: 14606 RVA: 0x000525A3 File Offset: 0x000507A3
		public unsafe bool bOverride_RayTracingAOSamplesPerPixel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingAOSamplesPerPixel) & FPostProcessSettings.__PropertyMask_bOverride_RayTracingAOSamplesPerPixel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingAOSamplesPerPixel) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingAOSamplesPerPixel) & ~FPostProcessSettings.__PropertyMask_bOverride_RayTracingAOSamplesPerPixel) | (value ? FPostProcessSettings.__PropertyMask_bOverride_RayTracingAOSamplesPerPixel : 0));
			}
		}

		// Token: 0x170008F3 RID: 2291
		// (get) Token: 0x0600390F RID: 14607 RVA: 0x000525D3 File Offset: 0x000507D3
		// (set) Token: 0x06003910 RID: 14608 RVA: 0x000525EC File Offset: 0x000507EC
		public unsafe bool bOverride_RayTracingAOIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingAOIntensity) & FPostProcessSettings.__PropertyMask_bOverride_RayTracingAOIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingAOIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingAOIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_RayTracingAOIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_RayTracingAOIntensity : 0));
			}
		}

		// Token: 0x170008F4 RID: 2292
		// (get) Token: 0x06003911 RID: 14609 RVA: 0x0005261C File Offset: 0x0005081C
		// (set) Token: 0x06003912 RID: 14610 RVA: 0x00052635 File Offset: 0x00050835
		public unsafe bool bOverride_RayTracingAORadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingAORadius) & FPostProcessSettings.__PropertyMask_bOverride_RayTracingAORadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingAORadius) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingAORadius) & ~FPostProcessSettings.__PropertyMask_bOverride_RayTracingAORadius) | (value ? FPostProcessSettings.__PropertyMask_bOverride_RayTracingAORadius : 0));
			}
		}

		// Token: 0x170008F5 RID: 2293
		// (get) Token: 0x06003913 RID: 14611 RVA: 0x00052665 File Offset: 0x00050865
		// (set) Token: 0x06003914 RID: 14612 RVA: 0x0005267E File Offset: 0x0005087E
		public unsafe bool bOverride_LPVIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVIntensity) & FPostProcessSettings.__PropertyMask_bOverride_LPVIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_LPVIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LPVIntensity : 0));
			}
		}

		// Token: 0x170008F6 RID: 2294
		// (get) Token: 0x06003915 RID: 14613 RVA: 0x000526AE File Offset: 0x000508AE
		// (set) Token: 0x06003916 RID: 14614 RVA: 0x000526C7 File Offset: 0x000508C7
		public unsafe bool bOverride_LPVDirectionalOcclusionIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVDirectionalOcclusionIntensity) & FPostProcessSettings.__PropertyMask_bOverride_LPVDirectionalOcclusionIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVDirectionalOcclusionIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVDirectionalOcclusionIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_LPVDirectionalOcclusionIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LPVDirectionalOcclusionIntensity : 0));
			}
		}

		// Token: 0x170008F7 RID: 2295
		// (get) Token: 0x06003917 RID: 14615 RVA: 0x000526F7 File Offset: 0x000508F7
		// (set) Token: 0x06003918 RID: 14616 RVA: 0x00052710 File Offset: 0x00050910
		public unsafe bool bOverride_LPVDirectionalOcclusionRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVDirectionalOcclusionRadius) & FPostProcessSettings.__PropertyMask_bOverride_LPVDirectionalOcclusionRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVDirectionalOcclusionRadius) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVDirectionalOcclusionRadius) & ~FPostProcessSettings.__PropertyMask_bOverride_LPVDirectionalOcclusionRadius) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LPVDirectionalOcclusionRadius : 0));
			}
		}

		// Token: 0x170008F8 RID: 2296
		// (get) Token: 0x06003919 RID: 14617 RVA: 0x00052740 File Offset: 0x00050940
		// (set) Token: 0x0600391A RID: 14618 RVA: 0x00052759 File Offset: 0x00050959
		public unsafe bool bOverride_LPVDiffuseOcclusionExponent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVDiffuseOcclusionExponent) & FPostProcessSettings.__PropertyMask_bOverride_LPVDiffuseOcclusionExponent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVDiffuseOcclusionExponent) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVDiffuseOcclusionExponent) & ~FPostProcessSettings.__PropertyMask_bOverride_LPVDiffuseOcclusionExponent) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LPVDiffuseOcclusionExponent : 0));
			}
		}

		// Token: 0x170008F9 RID: 2297
		// (get) Token: 0x0600391B RID: 14619 RVA: 0x00052789 File Offset: 0x00050989
		// (set) Token: 0x0600391C RID: 14620 RVA: 0x000527A2 File Offset: 0x000509A2
		public unsafe bool bOverride_LPVSpecularOcclusionExponent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVSpecularOcclusionExponent) & FPostProcessSettings.__PropertyMask_bOverride_LPVSpecularOcclusionExponent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVSpecularOcclusionExponent) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVSpecularOcclusionExponent) & ~FPostProcessSettings.__PropertyMask_bOverride_LPVSpecularOcclusionExponent) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LPVSpecularOcclusionExponent : 0));
			}
		}

		// Token: 0x170008FA RID: 2298
		// (get) Token: 0x0600391D RID: 14621 RVA: 0x000527D2 File Offset: 0x000509D2
		// (set) Token: 0x0600391E RID: 14622 RVA: 0x000527EB File Offset: 0x000509EB
		public unsafe bool bOverride_LPVDiffuseOcclusionIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVDiffuseOcclusionIntensity) & FPostProcessSettings.__PropertyMask_bOverride_LPVDiffuseOcclusionIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVDiffuseOcclusionIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVDiffuseOcclusionIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_LPVDiffuseOcclusionIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LPVDiffuseOcclusionIntensity : 0));
			}
		}

		// Token: 0x170008FB RID: 2299
		// (get) Token: 0x0600391F RID: 14623 RVA: 0x0005281B File Offset: 0x00050A1B
		// (set) Token: 0x06003920 RID: 14624 RVA: 0x00052834 File Offset: 0x00050A34
		public unsafe bool bOverride_LPVSpecularOcclusionIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVSpecularOcclusionIntensity) & FPostProcessSettings.__PropertyMask_bOverride_LPVSpecularOcclusionIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVSpecularOcclusionIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVSpecularOcclusionIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_LPVSpecularOcclusionIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LPVSpecularOcclusionIntensity : 0));
			}
		}

		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x06003921 RID: 14625 RVA: 0x00052864 File Offset: 0x00050A64
		// (set) Token: 0x06003922 RID: 14626 RVA: 0x0005287D File Offset: 0x00050A7D
		public unsafe bool bOverride_LPVSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVSize) & FPostProcessSettings.__PropertyMask_bOverride_LPVSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVSize) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVSize) & ~FPostProcessSettings.__PropertyMask_bOverride_LPVSize) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LPVSize : 0));
			}
		}

		// Token: 0x170008FD RID: 2301
		// (get) Token: 0x06003923 RID: 14627 RVA: 0x000528AD File Offset: 0x00050AAD
		// (set) Token: 0x06003924 RID: 14628 RVA: 0x000528C6 File Offset: 0x00050AC6
		public unsafe bool bOverride_LPVSecondaryOcclusionIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVSecondaryOcclusionIntensity) & FPostProcessSettings.__PropertyMask_bOverride_LPVSecondaryOcclusionIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVSecondaryOcclusionIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVSecondaryOcclusionIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_LPVSecondaryOcclusionIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LPVSecondaryOcclusionIntensity : 0));
			}
		}

		// Token: 0x170008FE RID: 2302
		// (get) Token: 0x06003925 RID: 14629 RVA: 0x000528F6 File Offset: 0x00050AF6
		// (set) Token: 0x06003926 RID: 14630 RVA: 0x0005290F File Offset: 0x00050B0F
		public unsafe bool bOverride_LPVSecondaryBounceIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVSecondaryBounceIntensity) & FPostProcessSettings.__PropertyMask_bOverride_LPVSecondaryBounceIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVSecondaryBounceIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVSecondaryBounceIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_LPVSecondaryBounceIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LPVSecondaryBounceIntensity : 0));
			}
		}

		// Token: 0x170008FF RID: 2303
		// (get) Token: 0x06003927 RID: 14631 RVA: 0x0005293F File Offset: 0x00050B3F
		// (set) Token: 0x06003928 RID: 14632 RVA: 0x00052958 File Offset: 0x00050B58
		public unsafe bool bOverride_LPVGeometryVolumeBias
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVGeometryVolumeBias) & FPostProcessSettings.__PropertyMask_bOverride_LPVGeometryVolumeBias) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVGeometryVolumeBias) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVGeometryVolumeBias) & ~FPostProcessSettings.__PropertyMask_bOverride_LPVGeometryVolumeBias) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LPVGeometryVolumeBias : 0));
			}
		}

		// Token: 0x17000900 RID: 2304
		// (get) Token: 0x06003929 RID: 14633 RVA: 0x00052988 File Offset: 0x00050B88
		// (set) Token: 0x0600392A RID: 14634 RVA: 0x000529A1 File Offset: 0x00050BA1
		public unsafe bool bOverride_LPVVplInjectionBias
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVVplInjectionBias) & FPostProcessSettings.__PropertyMask_bOverride_LPVVplInjectionBias) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVVplInjectionBias) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVVplInjectionBias) & ~FPostProcessSettings.__PropertyMask_bOverride_LPVVplInjectionBias) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LPVVplInjectionBias : 0));
			}
		}

		// Token: 0x17000901 RID: 2305
		// (get) Token: 0x0600392B RID: 14635 RVA: 0x000529D1 File Offset: 0x00050BD1
		// (set) Token: 0x0600392C RID: 14636 RVA: 0x000529EA File Offset: 0x00050BEA
		public unsafe bool bOverride_LPVEmissiveInjectionIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVEmissiveInjectionIntensity) & FPostProcessSettings.__PropertyMask_bOverride_LPVEmissiveInjectionIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVEmissiveInjectionIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVEmissiveInjectionIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_LPVEmissiveInjectionIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LPVEmissiveInjectionIntensity : 0));
			}
		}

		// Token: 0x17000902 RID: 2306
		// (get) Token: 0x0600392D RID: 14637 RVA: 0x00052A1A File Offset: 0x00050C1A
		// (set) Token: 0x0600392E RID: 14638 RVA: 0x00052A33 File Offset: 0x00050C33
		public unsafe bool bOverride_LPVFadeRange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVFadeRange) & FPostProcessSettings.__PropertyMask_bOverride_LPVFadeRange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVFadeRange) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVFadeRange) & ~FPostProcessSettings.__PropertyMask_bOverride_LPVFadeRange) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LPVFadeRange : 0));
			}
		}

		// Token: 0x17000903 RID: 2307
		// (get) Token: 0x0600392F RID: 14639 RVA: 0x00052A63 File Offset: 0x00050C63
		// (set) Token: 0x06003930 RID: 14640 RVA: 0x00052A7C File Offset: 0x00050C7C
		public unsafe bool bOverride_LPVDirectionalOcclusionFadeRange
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVDirectionalOcclusionFadeRange) & FPostProcessSettings.__PropertyMask_bOverride_LPVDirectionalOcclusionFadeRange) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVDirectionalOcclusionFadeRange) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LPVDirectionalOcclusionFadeRange) & ~FPostProcessSettings.__PropertyMask_bOverride_LPVDirectionalOcclusionFadeRange) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LPVDirectionalOcclusionFadeRange : 0));
			}
		}

		// Token: 0x17000904 RID: 2308
		// (get) Token: 0x06003931 RID: 14641 RVA: 0x00052AAC File Offset: 0x00050CAC
		// (set) Token: 0x06003932 RID: 14642 RVA: 0x00052AC5 File Offset: 0x00050CC5
		public unsafe bool bOverride_LumenSkylightLeaking
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LumenSkylightLeaking) & FPostProcessSettings.__PropertyMask_bOverride_LumenSkylightLeaking) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LumenSkylightLeaking) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_LumenSkylightLeaking) & ~FPostProcessSettings.__PropertyMask_bOverride_LumenSkylightLeaking) | (value ? FPostProcessSettings.__PropertyMask_bOverride_LumenSkylightLeaking : 0));
			}
		}

		// Token: 0x17000905 RID: 2309
		// (get) Token: 0x06003933 RID: 14643 RVA: 0x00052AF5 File Offset: 0x00050CF5
		// (set) Token: 0x06003934 RID: 14644 RVA: 0x00052B0E File Offset: 0x00050D0E
		public unsafe bool bOverride_IndirectLightingColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_IndirectLightingColor) & FPostProcessSettings.__PropertyMask_bOverride_IndirectLightingColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_IndirectLightingColor) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_IndirectLightingColor) & ~FPostProcessSettings.__PropertyMask_bOverride_IndirectLightingColor) | (value ? FPostProcessSettings.__PropertyMask_bOverride_IndirectLightingColor : 0));
			}
		}

		// Token: 0x17000906 RID: 2310
		// (get) Token: 0x06003935 RID: 14645 RVA: 0x00052B3E File Offset: 0x00050D3E
		// (set) Token: 0x06003936 RID: 14646 RVA: 0x00052B57 File Offset: 0x00050D57
		public unsafe bool bOverride_IndirectLightingIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_IndirectLightingIntensity) & FPostProcessSettings.__PropertyMask_bOverride_IndirectLightingIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_IndirectLightingIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_IndirectLightingIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_IndirectLightingIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_IndirectLightingIntensity : 0));
			}
		}

		// Token: 0x17000907 RID: 2311
		// (get) Token: 0x06003937 RID: 14647 RVA: 0x00052B87 File Offset: 0x00050D87
		// (set) Token: 0x06003938 RID: 14648 RVA: 0x00052BA0 File Offset: 0x00050DA0
		public unsafe bool bOverride_ColorGradingIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGradingIntensity) & FPostProcessSettings.__PropertyMask_bOverride_ColorGradingIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGradingIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGradingIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorGradingIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorGradingIntensity : 0));
			}
		}

		// Token: 0x17000908 RID: 2312
		// (get) Token: 0x06003939 RID: 14649 RVA: 0x00052BD0 File Offset: 0x00050DD0
		// (set) Token: 0x0600393A RID: 14650 RVA: 0x00052BE9 File Offset: 0x00050DE9
		public unsafe bool bOverride_ColorGradingLUT
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGradingLUT) & FPostProcessSettings.__PropertyMask_bOverride_ColorGradingLUT) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGradingLUT) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ColorGradingLUT) & ~FPostProcessSettings.__PropertyMask_bOverride_ColorGradingLUT) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ColorGradingLUT : 0));
			}
		}

		// Token: 0x17000909 RID: 2313
		// (get) Token: 0x0600393B RID: 14651 RVA: 0x00052C19 File Offset: 0x00050E19
		// (set) Token: 0x0600393C RID: 14652 RVA: 0x00052C32 File Offset: 0x00050E32
		public unsafe bool bOverride_DepthOfFieldFocalDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldFocalDistance) & FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldFocalDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldFocalDistance) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldFocalDistance) & ~FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldFocalDistance) | (value ? FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldFocalDistance : 0));
			}
		}

		// Token: 0x1700090A RID: 2314
		// (get) Token: 0x0600393D RID: 14653 RVA: 0x00052C62 File Offset: 0x00050E62
		// (set) Token: 0x0600393E RID: 14654 RVA: 0x00052C7B File Offset: 0x00050E7B
		public unsafe bool bOverride_DepthOfFieldFstop
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldFstop) & FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldFstop) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldFstop) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldFstop) & ~FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldFstop) | (value ? FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldFstop : 0));
			}
		}

		// Token: 0x1700090B RID: 2315
		// (get) Token: 0x0600393F RID: 14655 RVA: 0x00052CAB File Offset: 0x00050EAB
		// (set) Token: 0x06003940 RID: 14656 RVA: 0x00052CC4 File Offset: 0x00050EC4
		public unsafe bool bOverride_DepthOfFieldMinFstop
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldMinFstop) & FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldMinFstop) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldMinFstop) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldMinFstop) & ~FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldMinFstop) | (value ? FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldMinFstop : 0));
			}
		}

		// Token: 0x1700090C RID: 2316
		// (get) Token: 0x06003941 RID: 14657 RVA: 0x00052CF4 File Offset: 0x00050EF4
		// (set) Token: 0x06003942 RID: 14658 RVA: 0x00052D0D File Offset: 0x00050F0D
		public unsafe bool bOverride_DepthOfFieldBladeCount
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldBladeCount) & FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldBladeCount) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldBladeCount) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldBladeCount) & ~FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldBladeCount) | (value ? FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldBladeCount : 0));
			}
		}

		// Token: 0x1700090D RID: 2317
		// (get) Token: 0x06003943 RID: 14659 RVA: 0x00052D3D File Offset: 0x00050F3D
		// (set) Token: 0x06003944 RID: 14660 RVA: 0x00052D56 File Offset: 0x00050F56
		public unsafe bool bOverride_DepthOfFieldForegroundBlur
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldForegroundBlur) & FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldForegroundBlur) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldForegroundBlur) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldForegroundBlur) & ~FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldForegroundBlur) | (value ? FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldForegroundBlur : 0));
			}
		}

		// Token: 0x1700090E RID: 2318
		// (get) Token: 0x06003945 RID: 14661 RVA: 0x00052D86 File Offset: 0x00050F86
		// (set) Token: 0x06003946 RID: 14662 RVA: 0x00052D9F File Offset: 0x00050F9F
		public unsafe bool bOverride_DepthOfFieldSensorWidth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldSensorWidth) & FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldSensorWidth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldSensorWidth) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldSensorWidth) & ~FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldSensorWidth) | (value ? FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldSensorWidth : 0));
			}
		}

		// Token: 0x1700090F RID: 2319
		// (get) Token: 0x06003947 RID: 14663 RVA: 0x00052DCF File Offset: 0x00050FCF
		// (set) Token: 0x06003948 RID: 14664 RVA: 0x00052DE8 File Offset: 0x00050FE8
		public unsafe bool bOverride_DepthOfFieldDepthBlurRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldDepthBlurRadius) & FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldDepthBlurRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldDepthBlurRadius) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldDepthBlurRadius) & ~FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldDepthBlurRadius) | (value ? FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldDepthBlurRadius : 0));
			}
		}

		// Token: 0x17000910 RID: 2320
		// (get) Token: 0x06003949 RID: 14665 RVA: 0x00052E18 File Offset: 0x00051018
		// (set) Token: 0x0600394A RID: 14666 RVA: 0x00052E31 File Offset: 0x00051031
		public unsafe bool bOverride_DepthOfFieldDepthBlurAmount
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldDepthBlurAmount) & FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldDepthBlurAmount) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldDepthBlurAmount) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldDepthBlurAmount) & ~FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldDepthBlurAmount) | (value ? FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldDepthBlurAmount : 0));
			}
		}

		// Token: 0x17000911 RID: 2321
		// (get) Token: 0x0600394B RID: 14667 RVA: 0x00052E61 File Offset: 0x00051061
		// (set) Token: 0x0600394C RID: 14668 RVA: 0x00052E7A File Offset: 0x0005107A
		public unsafe bool bOverride_DepthOfFieldFocalRegion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldFocalRegion) & FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldFocalRegion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldFocalRegion) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldFocalRegion) & ~FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldFocalRegion) | (value ? FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldFocalRegion : 0));
			}
		}

		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x0600394D RID: 14669 RVA: 0x00052EAA File Offset: 0x000510AA
		// (set) Token: 0x0600394E RID: 14670 RVA: 0x00052EC3 File Offset: 0x000510C3
		public unsafe bool bOverride_DepthOfFieldNearTransitionRegion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldNearTransitionRegion) & FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldNearTransitionRegion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldNearTransitionRegion) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldNearTransitionRegion) & ~FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldNearTransitionRegion) | (value ? FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldNearTransitionRegion : 0));
			}
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x0600394F RID: 14671 RVA: 0x00052EF3 File Offset: 0x000510F3
		// (set) Token: 0x06003950 RID: 14672 RVA: 0x00052F0C File Offset: 0x0005110C
		public unsafe bool bOverride_DepthOfFieldFarTransitionRegion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldFarTransitionRegion) & FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldFarTransitionRegion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldFarTransitionRegion) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldFarTransitionRegion) & ~FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldFarTransitionRegion) | (value ? FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldFarTransitionRegion : 0));
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06003951 RID: 14673 RVA: 0x00052F3C File Offset: 0x0005113C
		// (set) Token: 0x06003952 RID: 14674 RVA: 0x00052F55 File Offset: 0x00051155
		public unsafe bool bOverride_DepthOfFieldScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldScale) & FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldScale) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldScale) & ~FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldScale) | (value ? FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldScale : 0));
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x06003953 RID: 14675 RVA: 0x00052F85 File Offset: 0x00051185
		// (set) Token: 0x06003954 RID: 14676 RVA: 0x00052F9E File Offset: 0x0005119E
		public unsafe bool bOverride_DepthOfFieldNearBlurSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldNearBlurSize) & FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldNearBlurSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldNearBlurSize) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldNearBlurSize) & ~FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldNearBlurSize) | (value ? FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldNearBlurSize : 0));
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x06003955 RID: 14677 RVA: 0x00052FCE File Offset: 0x000511CE
		// (set) Token: 0x06003956 RID: 14678 RVA: 0x00052FE7 File Offset: 0x000511E7
		public unsafe bool bOverride_DepthOfFieldFarBlurSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldFarBlurSize) & FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldFarBlurSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldFarBlurSize) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldFarBlurSize) & ~FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldFarBlurSize) | (value ? FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldFarBlurSize : 0));
			}
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06003957 RID: 14679 RVA: 0x00053017 File Offset: 0x00051217
		// (set) Token: 0x06003958 RID: 14680 RVA: 0x00053030 File Offset: 0x00051230
		public unsafe bool bOverride_MobileHQGaussian
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileHQGaussian) & FPostProcessSettings.__PropertyMask_bOverride_MobileHQGaussian) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileHQGaussian) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileHQGaussian) & ~FPostProcessSettings.__PropertyMask_bOverride_MobileHQGaussian) | (value ? FPostProcessSettings.__PropertyMask_bOverride_MobileHQGaussian : 0));
			}
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06003959 RID: 14681 RVA: 0x00053060 File Offset: 0x00051260
		// (set) Token: 0x0600395A RID: 14682 RVA: 0x00053079 File Offset: 0x00051279
		public unsafe bool bOverride_KuroDangerToggle
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDangerToggle) & FPostProcessSettings.__PropertyMask_bOverride_KuroDangerToggle) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDangerToggle) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroDangerToggle) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroDangerToggle) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroDangerToggle : 0));
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x0600395B RID: 14683 RVA: 0x000530A9 File Offset: 0x000512A9
		// (set) Token: 0x0600395C RID: 14684 RVA: 0x000530C2 File Offset: 0x000512C2
		public unsafe bool bOverride_DepthOfFieldOcclusion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldOcclusion) & FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldOcclusion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldOcclusion) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldOcclusion) & ~FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldOcclusion) | (value ? FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldOcclusion : 0));
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x0600395D RID: 14685 RVA: 0x000530F2 File Offset: 0x000512F2
		// (set) Token: 0x0600395E RID: 14686 RVA: 0x0005310B File Offset: 0x0005130B
		public unsafe bool bOverride_DepthOfFieldSkyFocusDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldSkyFocusDistance) & FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldSkyFocusDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldSkyFocusDistance) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldSkyFocusDistance) & ~FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldSkyFocusDistance) | (value ? FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldSkyFocusDistance : 0));
			}
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x0600395F RID: 14687 RVA: 0x0005313B File Offset: 0x0005133B
		// (set) Token: 0x06003960 RID: 14688 RVA: 0x00053154 File Offset: 0x00051354
		public unsafe bool bOverride_DepthOfFieldVignetteSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldVignetteSize) & FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldVignetteSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldVignetteSize) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_DepthOfFieldVignetteSize) & ~FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldVignetteSize) | (value ? FPostProcessSettings.__PropertyMask_bOverride_DepthOfFieldVignetteSize : 0));
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06003961 RID: 14689 RVA: 0x00053184 File Offset: 0x00051384
		// (set) Token: 0x06003962 RID: 14690 RVA: 0x0005319D File Offset: 0x0005139D
		public unsafe bool bOverride_MotionBlurAmount
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MotionBlurAmount) & FPostProcessSettings.__PropertyMask_bOverride_MotionBlurAmount) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MotionBlurAmount) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MotionBlurAmount) & ~FPostProcessSettings.__PropertyMask_bOverride_MotionBlurAmount) | (value ? FPostProcessSettings.__PropertyMask_bOverride_MotionBlurAmount : 0));
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x06003963 RID: 14691 RVA: 0x000531CD File Offset: 0x000513CD
		// (set) Token: 0x06003964 RID: 14692 RVA: 0x000531E6 File Offset: 0x000513E6
		public unsafe bool bOverride_MotionBlurMax
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MotionBlurMax) & FPostProcessSettings.__PropertyMask_bOverride_MotionBlurMax) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MotionBlurMax) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MotionBlurMax) & ~FPostProcessSettings.__PropertyMask_bOverride_MotionBlurMax) | (value ? FPostProcessSettings.__PropertyMask_bOverride_MotionBlurMax : 0));
			}
		}

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06003965 RID: 14693 RVA: 0x00053216 File Offset: 0x00051416
		// (set) Token: 0x06003966 RID: 14694 RVA: 0x0005322F File Offset: 0x0005142F
		public unsafe bool bOverride_MotionBlurTargetFPS
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MotionBlurTargetFPS) & FPostProcessSettings.__PropertyMask_bOverride_MotionBlurTargetFPS) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MotionBlurTargetFPS) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MotionBlurTargetFPS) & ~FPostProcessSettings.__PropertyMask_bOverride_MotionBlurTargetFPS) | (value ? FPostProcessSettings.__PropertyMask_bOverride_MotionBlurTargetFPS : 0));
			}
		}

		// Token: 0x1700091F RID: 2335
		// (get) Token: 0x06003967 RID: 14695 RVA: 0x0005325F File Offset: 0x0005145F
		// (set) Token: 0x06003968 RID: 14696 RVA: 0x00053278 File Offset: 0x00051478
		public unsafe bool bOverride_MotionBlurPerObjectSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MotionBlurPerObjectSize) & FPostProcessSettings.__PropertyMask_bOverride_MotionBlurPerObjectSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MotionBlurPerObjectSize) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MotionBlurPerObjectSize) & ~FPostProcessSettings.__PropertyMask_bOverride_MotionBlurPerObjectSize) | (value ? FPostProcessSettings.__PropertyMask_bOverride_MotionBlurPerObjectSize : 0));
			}
		}

		// Token: 0x17000920 RID: 2336
		// (get) Token: 0x06003969 RID: 14697 RVA: 0x000532A8 File Offset: 0x000514A8
		// (set) Token: 0x0600396A RID: 14698 RVA: 0x000532C1 File Offset: 0x000514C1
		public unsafe bool bOverride_ScreenPercentage
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenPercentage) & FPostProcessSettings.__PropertyMask_bOverride_ScreenPercentage) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenPercentage) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenPercentage) & ~FPostProcessSettings.__PropertyMask_bOverride_ScreenPercentage) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ScreenPercentage : 0));
			}
		}

		// Token: 0x17000921 RID: 2337
		// (get) Token: 0x0600396B RID: 14699 RVA: 0x000532F1 File Offset: 0x000514F1
		// (set) Token: 0x0600396C RID: 14700 RVA: 0x0005330A File Offset: 0x0005150A
		public unsafe bool bOverride_MotionBlurCharacterMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MotionBlurCharacterMask) & FPostProcessSettings.__PropertyMask_bOverride_MotionBlurCharacterMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MotionBlurCharacterMask) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MotionBlurCharacterMask) & ~FPostProcessSettings.__PropertyMask_bOverride_MotionBlurCharacterMask) | (value ? FPostProcessSettings.__PropertyMask_bOverride_MotionBlurCharacterMask : 0));
			}
		}

		// Token: 0x17000922 RID: 2338
		// (get) Token: 0x0600396D RID: 14701 RVA: 0x0005333A File Offset: 0x0005153A
		// (set) Token: 0x0600396E RID: 14702 RVA: 0x00053353 File Offset: 0x00051553
		public unsafe bool bOverride_WithOutTranslucent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_WithOutTranslucent) & FPostProcessSettings.__PropertyMask_bOverride_WithOutTranslucent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_WithOutTranslucent) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_WithOutTranslucent) & ~FPostProcessSettings.__PropertyMask_bOverride_WithOutTranslucent) | (value ? FPostProcessSettings.__PropertyMask_bOverride_WithOutTranslucent : 0));
			}
		}

		// Token: 0x17000923 RID: 2339
		// (get) Token: 0x0600396F RID: 14703 RVA: 0x00053383 File Offset: 0x00051583
		// (set) Token: 0x06003970 RID: 14704 RVA: 0x0005339C File Offset: 0x0005159C
		public unsafe bool bOverride_StartPosSwitch
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_StartPosSwitch) & FPostProcessSettings.__PropertyMask_bOverride_StartPosSwitch) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_StartPosSwitch) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_StartPosSwitch) & ~FPostProcessSettings.__PropertyMask_bOverride_StartPosSwitch) | (value ? FPostProcessSettings.__PropertyMask_bOverride_StartPosSwitch : 0));
			}
		}

		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x06003971 RID: 14705 RVA: 0x000533CC File Offset: 0x000515CC
		// (set) Token: 0x06003972 RID: 14706 RVA: 0x000533E5 File Offset: 0x000515E5
		public unsafe bool bOverride_GrayGradationStartPos
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrayGradationStartPos) & FPostProcessSettings.__PropertyMask_bOverride_GrayGradationStartPos) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrayGradationStartPos) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrayGradationStartPos) & ~FPostProcessSettings.__PropertyMask_bOverride_GrayGradationStartPos) | (value ? FPostProcessSettings.__PropertyMask_bOverride_GrayGradationStartPos : 0));
			}
		}

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06003973 RID: 14707 RVA: 0x00053415 File Offset: 0x00051615
		// (set) Token: 0x06003974 RID: 14708 RVA: 0x0005342E File Offset: 0x0005162E
		public unsafe bool bOverride_GrayGradationDegree
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrayGradationDegree) & FPostProcessSettings.__PropertyMask_bOverride_GrayGradationDegree) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrayGradationDegree) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrayGradationDegree) & ~FPostProcessSettings.__PropertyMask_bOverride_GrayGradationDegree) | (value ? FPostProcessSettings.__PropertyMask_bOverride_GrayGradationDegree : 0));
			}
		}

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06003975 RID: 14709 RVA: 0x0005345E File Offset: 0x0005165E
		// (set) Token: 0x06003976 RID: 14710 RVA: 0x00053477 File Offset: 0x00051677
		public unsafe bool bOverride_GrayLerpWidth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrayLerpWidth) & FPostProcessSettings.__PropertyMask_bOverride_GrayLerpWidth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrayLerpWidth) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrayLerpWidth) & ~FPostProcessSettings.__PropertyMask_bOverride_GrayLerpWidth) | (value ? FPostProcessSettings.__PropertyMask_bOverride_GrayLerpWidth : 0));
			}
		}

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06003977 RID: 14711 RVA: 0x000534A7 File Offset: 0x000516A7
		// (set) Token: 0x06003978 RID: 14712 RVA: 0x000534C0 File Offset: 0x000516C0
		public unsafe bool bOverride_GrayRampColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrayRampColor) & FPostProcessSettings.__PropertyMask_bOverride_GrayRampColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrayRampColor) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrayRampColor) & ~FPostProcessSettings.__PropertyMask_bOverride_GrayRampColor) | (value ? FPostProcessSettings.__PropertyMask_bOverride_GrayRampColor : 0));
			}
		}

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06003979 RID: 14713 RVA: 0x000534F0 File Offset: 0x000516F0
		// (set) Token: 0x0600397A RID: 14714 RVA: 0x00053509 File Offset: 0x00051709
		public unsafe bool bOverride_GrayRampTint
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrayRampTint) & FPostProcessSettings.__PropertyMask_bOverride_GrayRampTint) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrayRampTint) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrayRampTint) & ~FPostProcessSettings.__PropertyMask_bOverride_GrayRampTint) | (value ? FPostProcessSettings.__PropertyMask_bOverride_GrayRampTint : 0));
			}
		}

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x0600397B RID: 14715 RVA: 0x00053539 File Offset: 0x00051739
		// (set) Token: 0x0600397C RID: 14716 RVA: 0x00053552 File Offset: 0x00051752
		public unsafe bool bOverride_GrayRampBlendWeight
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrayRampBlendWeight) & FPostProcessSettings.__PropertyMask_bOverride_GrayRampBlendWeight) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrayRampBlendWeight) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_GrayRampBlendWeight) & ~FPostProcessSettings.__PropertyMask_bOverride_GrayRampBlendWeight) | (value ? FPostProcessSettings.__PropertyMask_bOverride_GrayRampBlendWeight : 0));
			}
		}

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x0600397D RID: 14717 RVA: 0x00053582 File Offset: 0x00051782
		// (set) Token: 0x0600397E RID: 14718 RVA: 0x0005359B File Offset: 0x0005179B
		public unsafe bool bOverride_SNNIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNIntensity) & FPostProcessSettings.__PropertyMask_bOverride_SNNIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_SNNIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SNNIntensity : 0));
			}
		}

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x0600397F RID: 14719 RVA: 0x000535CB File Offset: 0x000517CB
		// (set) Token: 0x06003980 RID: 14720 RVA: 0x000535E4 File Offset: 0x000517E4
		public unsafe bool bOverride_SNNRoughnessContrast
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNRoughnessContrast) & FPostProcessSettings.__PropertyMask_bOverride_SNNRoughnessContrast) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNRoughnessContrast) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNRoughnessContrast) & ~FPostProcessSettings.__PropertyMask_bOverride_SNNRoughnessContrast) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SNNRoughnessContrast : 0));
			}
		}

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x06003981 RID: 14721 RVA: 0x00053614 File Offset: 0x00051814
		// (set) Token: 0x06003982 RID: 14722 RVA: 0x0005362D File Offset: 0x0005182D
		public unsafe bool bOverride_SNNMetallicThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNMetallicThreshold) & FPostProcessSettings.__PropertyMask_bOverride_SNNMetallicThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNMetallicThreshold) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNMetallicThreshold) & ~FPostProcessSettings.__PropertyMask_bOverride_SNNMetallicThreshold) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SNNMetallicThreshold : 0));
			}
		}

		// Token: 0x1700092D RID: 2349
		// (get) Token: 0x06003983 RID: 14723 RVA: 0x0005365D File Offset: 0x0005185D
		// (set) Token: 0x06003984 RID: 14724 RVA: 0x00053676 File Offset: 0x00051876
		public unsafe bool bOverride_SNNDepthFade
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNDepthFade) & FPostProcessSettings.__PropertyMask_bOverride_SNNDepthFade) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNDepthFade) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNDepthFade) & ~FPostProcessSettings.__PropertyMask_bOverride_SNNDepthFade) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SNNDepthFade : 0));
			}
		}

		// Token: 0x1700092E RID: 2350
		// (get) Token: 0x06003985 RID: 14725 RVA: 0x000536A6 File Offset: 0x000518A6
		// (set) Token: 0x06003986 RID: 14726 RVA: 0x000536BF File Offset: 0x000518BF
		public unsafe bool bOverride_SNNFoliageIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNFoliageIntensity) & FPostProcessSettings.__PropertyMask_bOverride_SNNFoliageIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNFoliageIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNFoliageIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_SNNFoliageIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SNNFoliageIntensity : 0));
			}
		}

		// Token: 0x1700092F RID: 2351
		// (get) Token: 0x06003987 RID: 14727 RVA: 0x000536EF File Offset: 0x000518EF
		// (set) Token: 0x06003988 RID: 14728 RVA: 0x00053708 File Offset: 0x00051908
		public unsafe bool bOverride_SNNStructureIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNStructureIntensity) & FPostProcessSettings.__PropertyMask_bOverride_SNNStructureIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNStructureIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNStructureIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_SNNStructureIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SNNStructureIntensity : 0));
			}
		}

		// Token: 0x17000930 RID: 2352
		// (get) Token: 0x06003989 RID: 14729 RVA: 0x00053738 File Offset: 0x00051938
		// (set) Token: 0x0600398A RID: 14730 RVA: 0x00053751 File Offset: 0x00051951
		public unsafe bool bOverride_SNNNoiseIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNNoiseIntensity) & FPostProcessSettings.__PropertyMask_bOverride_SNNNoiseIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNNoiseIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNNoiseIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_SNNNoiseIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SNNNoiseIntensity : 0));
			}
		}

		// Token: 0x17000931 RID: 2353
		// (get) Token: 0x0600398B RID: 14731 RVA: 0x00053781 File Offset: 0x00051981
		// (set) Token: 0x0600398C RID: 14732 RVA: 0x0005379A File Offset: 0x0005199A
		public unsafe bool bOverride_SNNEnableSharpen
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNEnableSharpen) & FPostProcessSettings.__PropertyMask_bOverride_SNNEnableSharpen) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNEnableSharpen) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNEnableSharpen) & ~FPostProcessSettings.__PropertyMask_bOverride_SNNEnableSharpen) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SNNEnableSharpen : 0));
			}
		}

		// Token: 0x17000932 RID: 2354
		// (get) Token: 0x0600398D RID: 14733 RVA: 0x000537CA File Offset: 0x000519CA
		// (set) Token: 0x0600398E RID: 14734 RVA: 0x000537E3 File Offset: 0x000519E3
		public unsafe bool bOverride_SNNSharpeness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNSharpeness) & FPostProcessSettings.__PropertyMask_bOverride_SNNSharpeness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNSharpeness) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNSharpeness) & ~FPostProcessSettings.__PropertyMask_bOverride_SNNSharpeness) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SNNSharpeness : 0));
			}
		}

		// Token: 0x17000933 RID: 2355
		// (get) Token: 0x0600398F RID: 14735 RVA: 0x00053813 File Offset: 0x00051A13
		// (set) Token: 0x06003990 RID: 14736 RVA: 0x0005382C File Offset: 0x00051A2C
		public unsafe bool bOverride_SNNSharpenDepthFade
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNSharpenDepthFade) & FPostProcessSettings.__PropertyMask_bOverride_SNNSharpenDepthFade) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNSharpenDepthFade) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SNNSharpenDepthFade) & ~FPostProcessSettings.__PropertyMask_bOverride_SNNSharpenDepthFade) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SNNSharpenDepthFade : 0));
			}
		}

		// Token: 0x17000934 RID: 2356
		// (get) Token: 0x06003991 RID: 14737 RVA: 0x0005385C File Offset: 0x00051A5C
		// (set) Token: 0x06003992 RID: 14738 RVA: 0x00053875 File Offset: 0x00051A75
		public unsafe bool bOverride_SSFSIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSIntensity) & FPostProcessSettings.__PropertyMask_bOverride_SSFSIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_SSFSIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SSFSIntensity : 0));
			}
		}

		// Token: 0x17000935 RID: 2357
		// (get) Token: 0x06003993 RID: 14739 RVA: 0x000538A5 File Offset: 0x00051AA5
		// (set) Token: 0x06003994 RID: 14740 RVA: 0x000538BE File Offset: 0x00051ABE
		public unsafe bool bOverride_SSFSRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSRadius) & FPostProcessSettings.__PropertyMask_bOverride_SSFSRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSRadius) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSRadius) & ~FPostProcessSettings.__PropertyMask_bOverride_SSFSRadius) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SSFSRadius : 0));
			}
		}

		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x06003995 RID: 14741 RVA: 0x000538EE File Offset: 0x00051AEE
		// (set) Token: 0x06003996 RID: 14742 RVA: 0x00053907 File Offset: 0x00051B07
		public unsafe bool bOverride_SSFSLuminanceWeighting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSLuminanceWeighting) & FPostProcessSettings.__PropertyMask_bOverride_SSFSLuminanceWeighting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSLuminanceWeighting) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSLuminanceWeighting) & ~FPostProcessSettings.__PropertyMask_bOverride_SSFSLuminanceWeighting) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SSFSLuminanceWeighting : 0));
			}
		}

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x06003997 RID: 14743 RVA: 0x00053937 File Offset: 0x00051B37
		// (set) Token: 0x06003998 RID: 14744 RVA: 0x00053950 File Offset: 0x00051B50
		public unsafe bool bOverride_SSFSSkyAtmosphereIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSSkyAtmosphereIntensity) & FPostProcessSettings.__PropertyMask_bOverride_SSFSSkyAtmosphereIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSSkyAtmosphereIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSSkyAtmosphereIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_SSFSSkyAtmosphereIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SSFSSkyAtmosphereIntensity : 0));
			}
		}

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x06003999 RID: 14745 RVA: 0x00053980 File Offset: 0x00051B80
		// (set) Token: 0x0600399A RID: 14746 RVA: 0x00053999 File Offset: 0x00051B99
		public unsafe bool bOverride_SSFSVolumetricFogILSIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSVolumetricFogILSIntensity) & FPostProcessSettings.__PropertyMask_bOverride_SSFSVolumetricFogILSIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSVolumetricFogILSIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSVolumetricFogILSIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_SSFSVolumetricFogILSIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SSFSVolumetricFogILSIntensity : 0));
			}
		}

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x0600399B RID: 14747 RVA: 0x000539C9 File Offset: 0x00051BC9
		// (set) Token: 0x0600399C RID: 14748 RVA: 0x000539E2 File Offset: 0x00051BE2
		public unsafe bool bOverride_SSFSKuroVolumetricLightILSIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSKuroVolumetricLightILSIntensity) & FPostProcessSettings.__PropertyMask_bOverride_SSFSKuroVolumetricLightILSIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSKuroVolumetricLightILSIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSKuroVolumetricLightILSIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_SSFSKuroVolumetricLightILSIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SSFSKuroVolumetricLightILSIntensity : 0));
			}
		}

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x0600399D RID: 14749 RVA: 0x00053A12 File Offset: 0x00051C12
		// (set) Token: 0x0600399E RID: 14750 RVA: 0x00053A2B File Offset: 0x00051C2B
		public unsafe bool bOverride_SSFSStartDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSStartDistance) & FPostProcessSettings.__PropertyMask_bOverride_SSFSStartDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSStartDistance) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSStartDistance) & ~FPostProcessSettings.__PropertyMask_bOverride_SSFSStartDistance) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SSFSStartDistance : 0));
			}
		}

		// Token: 0x1700093B RID: 2363
		// (get) Token: 0x0600399F RID: 14751 RVA: 0x00053A5B File Offset: 0x00051C5B
		// (set) Token: 0x060039A0 RID: 14752 RVA: 0x00053A74 File Offset: 0x00051C74
		public unsafe bool bOverride_SSFSMaxDepth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSMaxDepth) & FPostProcessSettings.__PropertyMask_bOverride_SSFSMaxDepth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSMaxDepth) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_SSFSMaxDepth) & ~FPostProcessSettings.__PropertyMask_bOverride_SSFSMaxDepth) | (value ? FPostProcessSettings.__PropertyMask_bOverride_SSFSMaxDepth : 0));
			}
		}

		// Token: 0x1700093C RID: 2364
		// (get) Token: 0x060039A1 RID: 14753 RVA: 0x00053AA4 File Offset: 0x00051CA4
		// (set) Token: 0x060039A2 RID: 14754 RVA: 0x00053ABD File Offset: 0x00051CBD
		public unsafe bool bOverride_EnableMobileSSFS
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EnableMobileSSFS) & FPostProcessSettings.__PropertyMask_bOverride_EnableMobileSSFS) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EnableMobileSSFS) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EnableMobileSSFS) & ~FPostProcessSettings.__PropertyMask_bOverride_EnableMobileSSFS) | (value ? FPostProcessSettings.__PropertyMask_bOverride_EnableMobileSSFS : 0));
			}
		}

		// Token: 0x1700093D RID: 2365
		// (get) Token: 0x060039A3 RID: 14755 RVA: 0x00053AED File Offset: 0x00051CED
		// (set) Token: 0x060039A4 RID: 14756 RVA: 0x00053B06 File Offset: 0x00051D06
		public unsafe bool bOverride_MobileSSFSFogDensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileSSFSFogDensity) & FPostProcessSettings.__PropertyMask_bOverride_MobileSSFSFogDensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileSSFSFogDensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileSSFSFogDensity) & ~FPostProcessSettings.__PropertyMask_bOverride_MobileSSFSFogDensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_MobileSSFSFogDensity : 0));
			}
		}

		// Token: 0x1700093E RID: 2366
		// (get) Token: 0x060039A5 RID: 14757 RVA: 0x00053B36 File Offset: 0x00051D36
		// (set) Token: 0x060039A6 RID: 14758 RVA: 0x00053B4F File Offset: 0x00051D4F
		public unsafe bool bOverride_MobileSSFSIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileSSFSIntensity) & FPostProcessSettings.__PropertyMask_bOverride_MobileSSFSIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileSSFSIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileSSFSIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_MobileSSFSIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_MobileSSFSIntensity : 0));
			}
		}

		// Token: 0x1700093F RID: 2367
		// (get) Token: 0x060039A7 RID: 14759 RVA: 0x00053B7F File Offset: 0x00051D7F
		// (set) Token: 0x060039A8 RID: 14760 RVA: 0x00053B98 File Offset: 0x00051D98
		public unsafe bool bOverride_MobileSSFSRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileSSFSRadius) & FPostProcessSettings.__PropertyMask_bOverride_MobileSSFSRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileSSFSRadius) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileSSFSRadius) & ~FPostProcessSettings.__PropertyMask_bOverride_MobileSSFSRadius) | (value ? FPostProcessSettings.__PropertyMask_bOverride_MobileSSFSRadius : 0));
			}
		}

		// Token: 0x17000940 RID: 2368
		// (get) Token: 0x060039A9 RID: 14761 RVA: 0x00053BC8 File Offset: 0x00051DC8
		// (set) Token: 0x060039AA RID: 14762 RVA: 0x00053BE1 File Offset: 0x00051DE1
		public unsafe bool bOverride_MobileSSFSStartDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileSSFSStartDistance) & FPostProcessSettings.__PropertyMask_bOverride_MobileSSFSStartDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileSSFSStartDistance) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_MobileSSFSStartDistance) & ~FPostProcessSettings.__PropertyMask_bOverride_MobileSSFSStartDistance) | (value ? FPostProcessSettings.__PropertyMask_bOverride_MobileSSFSStartDistance : 0));
			}
		}

		// Token: 0x17000941 RID: 2369
		// (get) Token: 0x060039AB RID: 14763 RVA: 0x00053C11 File Offset: 0x00051E11
		// (set) Token: 0x060039AC RID: 14764 RVA: 0x00053C2A File Offset: 0x00051E2A
		public unsafe bool bOverride_KuroSharpenRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroSharpenRadius) & FPostProcessSettings.__PropertyMask_bOverride_KuroSharpenRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroSharpenRadius) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroSharpenRadius) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroSharpenRadius) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroSharpenRadius : 0));
			}
		}

		// Token: 0x17000942 RID: 2370
		// (get) Token: 0x060039AD RID: 14765 RVA: 0x00053C5A File Offset: 0x00051E5A
		// (set) Token: 0x060039AE RID: 14766 RVA: 0x00053C73 File Offset: 0x00051E73
		public unsafe bool bOverride_KuroSharpenAmount
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroSharpenAmount) & FPostProcessSettings.__PropertyMask_bOverride_KuroSharpenAmount) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroSharpenAmount) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroSharpenAmount) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroSharpenAmount) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroSharpenAmount : 0));
			}
		}

		// Token: 0x17000943 RID: 2371
		// (get) Token: 0x060039AF RID: 14767 RVA: 0x00053CA3 File Offset: 0x00051EA3
		// (set) Token: 0x060039B0 RID: 14768 RVA: 0x00053CBC File Offset: 0x00051EBC
		public unsafe bool bOverride_KuroLaplacianAmount
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroLaplacianAmount) & FPostProcessSettings.__PropertyMask_bOverride_KuroLaplacianAmount) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroLaplacianAmount) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroLaplacianAmount) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroLaplacianAmount) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroLaplacianAmount : 0));
			}
		}

		// Token: 0x17000944 RID: 2372
		// (get) Token: 0x060039B1 RID: 14769 RVA: 0x00053CEC File Offset: 0x00051EEC
		// (set) Token: 0x060039B2 RID: 14770 RVA: 0x00053D05 File Offset: 0x00051F05
		public unsafe bool bOverride_KuroSharpenIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroSharpenIntensity) & FPostProcessSettings.__PropertyMask_bOverride_KuroSharpenIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroSharpenIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroSharpenIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroSharpenIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroSharpenIntensity : 0));
			}
		}

		// Token: 0x17000945 RID: 2373
		// (get) Token: 0x060039B3 RID: 14771 RVA: 0x00053D35 File Offset: 0x00051F35
		// (set) Token: 0x060039B4 RID: 14772 RVA: 0x00053D4E File Offset: 0x00051F4E
		public unsafe bool bOverride_KuroToonSharpenIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroToonSharpenIntensity) & FPostProcessSettings.__PropertyMask_bOverride_KuroToonSharpenIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroToonSharpenIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroToonSharpenIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroToonSharpenIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroToonSharpenIntensity : 0));
			}
		}

		// Token: 0x17000946 RID: 2374
		// (get) Token: 0x060039B5 RID: 14773 RVA: 0x00053D7E File Offset: 0x00051F7E
		// (set) Token: 0x060039B6 RID: 14774 RVA: 0x00053D97 File Offset: 0x00051F97
		public unsafe bool bOverride_KuroSharpenDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroSharpenDistance) & FPostProcessSettings.__PropertyMask_bOverride_KuroSharpenDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroSharpenDistance) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroSharpenDistance) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroSharpenDistance) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroSharpenDistance : 0));
			}
		}

		// Token: 0x17000947 RID: 2375
		// (get) Token: 0x060039B7 RID: 14775 RVA: 0x00053DC7 File Offset: 0x00051FC7
		// (set) Token: 0x060039B8 RID: 14776 RVA: 0x00053DE0 File Offset: 0x00051FE0
		public unsafe bool bOverride_TyndallScaLightIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaLightIntensity) & FPostProcessSettings.__PropertyMask_bOverride_TyndallScaLightIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaLightIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaLightIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_TyndallScaLightIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_TyndallScaLightIntensity : 0));
			}
		}

		// Token: 0x17000948 RID: 2376
		// (get) Token: 0x060039B9 RID: 14777 RVA: 0x00053E10 File Offset: 0x00052010
		// (set) Token: 0x060039BA RID: 14778 RVA: 0x00053E29 File Offset: 0x00052029
		public unsafe bool bOverride_TyndallDarkIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallDarkIntensity) & FPostProcessSettings.__PropertyMask_bOverride_TyndallDarkIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallDarkIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallDarkIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_TyndallDarkIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_TyndallDarkIntensity : 0));
			}
		}

		// Token: 0x17000949 RID: 2377
		// (get) Token: 0x060039BB RID: 14779 RVA: 0x00053E59 File Offset: 0x00052059
		// (set) Token: 0x060039BC RID: 14780 RVA: 0x00053E72 File Offset: 0x00052072
		public unsafe bool bOverride_TyndallScaLightLength
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaLightLength) & FPostProcessSettings.__PropertyMask_bOverride_TyndallScaLightLength) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaLightLength) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaLightLength) & ~FPostProcessSettings.__PropertyMask_bOverride_TyndallScaLightLength) | (value ? FPostProcessSettings.__PropertyMask_bOverride_TyndallScaLightLength : 0));
			}
		}

		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x060039BD RID: 14781 RVA: 0x00053EA2 File Offset: 0x000520A2
		// (set) Token: 0x060039BE RID: 14782 RVA: 0x00053EBB File Offset: 0x000520BB
		public unsafe bool bOverride_TyndallScaLightColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaLightColor) & FPostProcessSettings.__PropertyMask_bOverride_TyndallScaLightColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaLightColor) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaLightColor) & ~FPostProcessSettings.__PropertyMask_bOverride_TyndallScaLightColor) | (value ? FPostProcessSettings.__PropertyMask_bOverride_TyndallScaLightColor : 0));
			}
		}

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x060039BF RID: 14783 RVA: 0x00053EEB File Offset: 0x000520EB
		// (set) Token: 0x060039C0 RID: 14784 RVA: 0x00053F04 File Offset: 0x00052104
		public unsafe bool bOverride_TyndallScaLightFade
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaLightFade) & FPostProcessSettings.__PropertyMask_bOverride_TyndallScaLightFade) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaLightFade) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaLightFade) & ~FPostProcessSettings.__PropertyMask_bOverride_TyndallScaLightFade) | (value ? FPostProcessSettings.__PropertyMask_bOverride_TyndallScaLightFade : 0));
			}
		}

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x060039C1 RID: 14785 RVA: 0x00053F34 File Offset: 0x00052134
		// (set) Token: 0x060039C2 RID: 14786 RVA: 0x00053F4D File Offset: 0x0005214D
		public unsafe bool bOverride_TyndallScaLightMode
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaLightMode) & FPostProcessSettings.__PropertyMask_bOverride_TyndallScaLightMode) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaLightMode) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaLightMode) & ~FPostProcessSettings.__PropertyMask_bOverride_TyndallScaLightMode) | (value ? FPostProcessSettings.__PropertyMask_bOverride_TyndallScaLightMode : 0));
			}
		}

		// Token: 0x1700094D RID: 2381
		// (get) Token: 0x060039C3 RID: 14787 RVA: 0x00053F7D File Offset: 0x0005217D
		// (set) Token: 0x060039C4 RID: 14788 RVA: 0x00053F96 File Offset: 0x00052196
		public unsafe bool bOverride_TyndallScaNearFade
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaNearFade) & FPostProcessSettings.__PropertyMask_bOverride_TyndallScaNearFade) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaNearFade) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaNearFade) & ~FPostProcessSettings.__PropertyMask_bOverride_TyndallScaNearFade) | (value ? FPostProcessSettings.__PropertyMask_bOverride_TyndallScaNearFade : 0));
			}
		}

		// Token: 0x1700094E RID: 2382
		// (get) Token: 0x060039C5 RID: 14789 RVA: 0x00053FC6 File Offset: 0x000521C6
		// (set) Token: 0x060039C6 RID: 14790 RVA: 0x00053FDF File Offset: 0x000521DF
		public unsafe bool bOverride_TyndallScaDarkFadeDepth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaDarkFadeDepth) & FPostProcessSettings.__PropertyMask_bOverride_TyndallScaDarkFadeDepth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaDarkFadeDepth) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaDarkFadeDepth) & ~FPostProcessSettings.__PropertyMask_bOverride_TyndallScaDarkFadeDepth) | (value ? FPostProcessSettings.__PropertyMask_bOverride_TyndallScaDarkFadeDepth : 0));
			}
		}

		// Token: 0x1700094F RID: 2383
		// (get) Token: 0x060039C7 RID: 14791 RVA: 0x0005400F File Offset: 0x0005220F
		// (set) Token: 0x060039C8 RID: 14792 RVA: 0x00054028 File Offset: 0x00052228
		public unsafe bool bOverride_TyndallScaMaxDepth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaMaxDepth) & FPostProcessSettings.__PropertyMask_bOverride_TyndallScaMaxDepth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaMaxDepth) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallScaMaxDepth) & ~FPostProcessSettings.__PropertyMask_bOverride_TyndallScaMaxDepth) | (value ? FPostProcessSettings.__PropertyMask_bOverride_TyndallScaMaxDepth : 0));
			}
		}

		// Token: 0x17000950 RID: 2384
		// (get) Token: 0x060039C9 RID: 14793 RVA: 0x00054058 File Offset: 0x00052258
		// (set) Token: 0x060039CA RID: 14794 RVA: 0x00054071 File Offset: 0x00052271
		public unsafe bool bOverride_EnableCustomPosition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EnableCustomPosition) & FPostProcessSettings.__PropertyMask_bOverride_EnableCustomPosition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EnableCustomPosition) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_EnableCustomPosition) & ~FPostProcessSettings.__PropertyMask_bOverride_EnableCustomPosition) | (value ? FPostProcessSettings.__PropertyMask_bOverride_EnableCustomPosition : 0));
			}
		}

		// Token: 0x17000951 RID: 2385
		// (get) Token: 0x060039CB RID: 14795 RVA: 0x000540A1 File Offset: 0x000522A1
		// (set) Token: 0x060039CC RID: 14796 RVA: 0x000540BA File Offset: 0x000522BA
		public unsafe bool bOverride_TyndallCustomPosition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallCustomPosition) & FPostProcessSettings.__PropertyMask_bOverride_TyndallCustomPosition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallCustomPosition) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TyndallCustomPosition) & ~FPostProcessSettings.__PropertyMask_bOverride_TyndallCustomPosition) | (value ? FPostProcessSettings.__PropertyMask_bOverride_TyndallCustomPosition : 0));
			}
		}

		// Token: 0x17000952 RID: 2386
		// (get) Token: 0x060039CD RID: 14797 RVA: 0x000540EA File Offset: 0x000522EA
		// (set) Token: 0x060039CE RID: 14798 RVA: 0x00054103 File Offset: 0x00052303
		public unsafe bool bOverride_KuroVolumetricLightEnable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightEnable) & FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightEnable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightEnable) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightEnable) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightEnable) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightEnable : 0));
			}
		}

		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x060039CF RID: 14799 RVA: 0x00054133 File Offset: 0x00052333
		// (set) Token: 0x060039D0 RID: 14800 RVA: 0x0005414C File Offset: 0x0005234C
		public unsafe bool bOverride_KuroVolumetricLightIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightIntensity) & FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightIntensity : 0));
			}
		}

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x060039D1 RID: 14801 RVA: 0x0005417C File Offset: 0x0005237C
		// (set) Token: 0x060039D2 RID: 14802 RVA: 0x00054195 File Offset: 0x00052395
		public unsafe bool bOverride_KuroVolumetricLightColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightColor) & FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightColor) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightColor) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightColor) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightColor : 0));
			}
		}

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x060039D3 RID: 14803 RVA: 0x000541C5 File Offset: 0x000523C5
		// (set) Token: 0x060039D4 RID: 14804 RVA: 0x000541DE File Offset: 0x000523DE
		public unsafe bool bOverride_KuroVolumetricLightPhaseG
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightPhaseG) & FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightPhaseG) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightPhaseG) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightPhaseG) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightPhaseG) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightPhaseG : 0));
			}
		}

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x060039D5 RID: 14805 RVA: 0x0005420E File Offset: 0x0005240E
		// (set) Token: 0x060039D6 RID: 14806 RVA: 0x00054227 File Offset: 0x00052427
		public unsafe bool bOverride_KuroVolumetricLightMaxDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightMaxDistance) & FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightMaxDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightMaxDistance) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightMaxDistance) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightMaxDistance) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightMaxDistance : 0));
			}
		}

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x060039D7 RID: 14807 RVA: 0x00054257 File Offset: 0x00052457
		// (set) Token: 0x060039D8 RID: 14808 RVA: 0x00054270 File Offset: 0x00052470
		public unsafe bool bOverride_KuroVolumetricLightBlurRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightBlurRadius) & FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightBlurRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightBlurRadius) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightBlurRadius) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightBlurRadius) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightBlurRadius : 0));
			}
		}

		// Token: 0x17000958 RID: 2392
		// (get) Token: 0x060039D9 RID: 14809 RVA: 0x000542A0 File Offset: 0x000524A0
		// (set) Token: 0x060039DA RID: 14810 RVA: 0x000542B9 File Offset: 0x000524B9
		public unsafe bool bOverride_KuroVolumetricLightUseColorMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightUseColorMask) & FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightUseColorMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightUseColorMask) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightUseColorMask) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightUseColorMask) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightUseColorMask : 0));
			}
		}

		// Token: 0x17000959 RID: 2393
		// (get) Token: 0x060039DB RID: 14811 RVA: 0x000542E9 File Offset: 0x000524E9
		// (set) Token: 0x060039DC RID: 14812 RVA: 0x00054302 File Offset: 0x00052502
		public unsafe bool bOverride_KuroVolumetricLightColorMaskIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightColorMaskIntensity) & FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightColorMaskIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightColorMaskIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroVolumetricLightColorMaskIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightColorMaskIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroVolumetricLightColorMaskIntensity : 0));
			}
		}

		// Token: 0x1700095A RID: 2394
		// (get) Token: 0x060039DD RID: 14813 RVA: 0x00054332 File Offset: 0x00052532
		// (set) Token: 0x060039DE RID: 14814 RVA: 0x0005434B File Offset: 0x0005254B
		public unsafe bool bOverride_ScreenSpaceReflectionIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSpaceReflectionIntensity) & FPostProcessSettings.__PropertyMask_bOverride_ScreenSpaceReflectionIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSpaceReflectionIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSpaceReflectionIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_ScreenSpaceReflectionIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ScreenSpaceReflectionIntensity : 0));
			}
		}

		// Token: 0x1700095B RID: 2395
		// (get) Token: 0x060039DF RID: 14815 RVA: 0x0005437B File Offset: 0x0005257B
		// (set) Token: 0x060039E0 RID: 14816 RVA: 0x00054394 File Offset: 0x00052594
		public unsafe bool bOverride_ScreenSpaceReflectionQuality
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSpaceReflectionQuality) & FPostProcessSettings.__PropertyMask_bOverride_ScreenSpaceReflectionQuality) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSpaceReflectionQuality) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSpaceReflectionQuality) & ~FPostProcessSettings.__PropertyMask_bOverride_ScreenSpaceReflectionQuality) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ScreenSpaceReflectionQuality : 0));
			}
		}

		// Token: 0x1700095C RID: 2396
		// (get) Token: 0x060039E1 RID: 14817 RVA: 0x000543C4 File Offset: 0x000525C4
		// (set) Token: 0x060039E2 RID: 14818 RVA: 0x000543DD File Offset: 0x000525DD
		public unsafe bool bOverride_ScreenSpaceReflectionMaxRoughness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSpaceReflectionMaxRoughness) & FPostProcessSettings.__PropertyMask_bOverride_ScreenSpaceReflectionMaxRoughness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSpaceReflectionMaxRoughness) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSpaceReflectionMaxRoughness) & ~FPostProcessSettings.__PropertyMask_bOverride_ScreenSpaceReflectionMaxRoughness) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ScreenSpaceReflectionMaxRoughness : 0));
			}
		}

		// Token: 0x1700095D RID: 2397
		// (get) Token: 0x060039E3 RID: 14819 RVA: 0x0005440D File Offset: 0x0005260D
		// (set) Token: 0x060039E4 RID: 14820 RVA: 0x00054426 File Offset: 0x00052626
		public unsafe bool bOverride_KuroTonemapA
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroTonemapA) & FPostProcessSettings.__PropertyMask_bOverride_KuroTonemapA) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroTonemapA) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroTonemapA) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroTonemapA) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroTonemapA : 0));
			}
		}

		// Token: 0x1700095E RID: 2398
		// (get) Token: 0x060039E5 RID: 14821 RVA: 0x00054456 File Offset: 0x00052656
		// (set) Token: 0x060039E6 RID: 14822 RVA: 0x0005446F File Offset: 0x0005266F
		public unsafe bool bOverride_KuroTonemapB
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroTonemapB) & FPostProcessSettings.__PropertyMask_bOverride_KuroTonemapB) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroTonemapB) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroTonemapB) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroTonemapB) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroTonemapB : 0));
			}
		}

		// Token: 0x1700095F RID: 2399
		// (get) Token: 0x060039E7 RID: 14823 RVA: 0x0005449F File Offset: 0x0005269F
		// (set) Token: 0x060039E8 RID: 14824 RVA: 0x000544B8 File Offset: 0x000526B8
		public unsafe bool bOverride_KuroTonemapC
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroTonemapC) & FPostProcessSettings.__PropertyMask_bOverride_KuroTonemapC) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroTonemapC) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroTonemapC) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroTonemapC) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroTonemapC : 0));
			}
		}

		// Token: 0x17000960 RID: 2400
		// (get) Token: 0x060039E9 RID: 14825 RVA: 0x000544E8 File Offset: 0x000526E8
		// (set) Token: 0x060039EA RID: 14826 RVA: 0x00054501 File Offset: 0x00052701
		public unsafe bool bOverride_KuroTonemapD
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroTonemapD) & FPostProcessSettings.__PropertyMask_bOverride_KuroTonemapD) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroTonemapD) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroTonemapD) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroTonemapD) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroTonemapD : 0));
			}
		}

		// Token: 0x17000961 RID: 2401
		// (get) Token: 0x060039EB RID: 14827 RVA: 0x00054531 File Offset: 0x00052731
		// (set) Token: 0x060039EC RID: 14828 RVA: 0x0005454A File Offset: 0x0005274A
		public unsafe bool bOverride_KuroTonemapE
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroTonemapE) & FPostProcessSettings.__PropertyMask_bOverride_KuroTonemapE) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroTonemapE) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroTonemapE) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroTonemapE) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroTonemapE : 0));
			}
		}

		// Token: 0x17000962 RID: 2402
		// (get) Token: 0x060039ED RID: 14829 RVA: 0x0005457A File Offset: 0x0005277A
		// (set) Token: 0x060039EE RID: 14830 RVA: 0x00054593 File Offset: 0x00052793
		public unsafe bool bOverride_KuroTonemapF
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroTonemapF) & FPostProcessSettings.__PropertyMask_bOverride_KuroTonemapF) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroTonemapF) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroTonemapF) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroTonemapF) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroTonemapF : 0));
			}
		}

		// Token: 0x17000963 RID: 2403
		// (get) Token: 0x060039EF RID: 14831 RVA: 0x000545C3 File Offset: 0x000527C3
		// (set) Token: 0x060039F0 RID: 14832 RVA: 0x000545DC File Offset: 0x000527DC
		public unsafe bool bOverride_UseCharacterMask
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_UseCharacterMask) & FPostProcessSettings.__PropertyMask_bOverride_UseCharacterMask) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_UseCharacterMask) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_UseCharacterMask) & ~FPostProcessSettings.__PropertyMask_bOverride_UseCharacterMask) | (value ? FPostProcessSettings.__PropertyMask_bOverride_UseCharacterMask : 0));
			}
		}

		// Token: 0x17000964 RID: 2404
		// (get) Token: 0x060039F1 RID: 14833 RVA: 0x0005460C File Offset: 0x0005280C
		// (set) Token: 0x060039F2 RID: 14834 RVA: 0x00054625 File Offset: 0x00052825
		public unsafe bool bOverride_ScreenSpaceReflectionRoughnessScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSpaceReflectionRoughnessScale) & FPostProcessSettings.__PropertyMask_bOverride_ScreenSpaceReflectionRoughnessScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSpaceReflectionRoughnessScale) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ScreenSpaceReflectionRoughnessScale) & ~FPostProcessSettings.__PropertyMask_bOverride_ScreenSpaceReflectionRoughnessScale) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ScreenSpaceReflectionRoughnessScale : 0));
			}
		}

		// Token: 0x17000965 RID: 2405
		// (get) Token: 0x060039F3 RID: 14835 RVA: 0x00054655 File Offset: 0x00052855
		// (set) Token: 0x060039F4 RID: 14836 RVA: 0x0005466E File Offset: 0x0005286E
		public unsafe bool bOverride_ReflectionsType
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ReflectionsType) & FPostProcessSettings.__PropertyMask_bOverride_ReflectionsType) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ReflectionsType) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_ReflectionsType) & ~FPostProcessSettings.__PropertyMask_bOverride_ReflectionsType) | (value ? FPostProcessSettings.__PropertyMask_bOverride_ReflectionsType : 0));
			}
		}

		// Token: 0x17000966 RID: 2406
		// (get) Token: 0x060039F5 RID: 14837 RVA: 0x0005469E File Offset: 0x0005289E
		// (set) Token: 0x060039F6 RID: 14838 RVA: 0x000546B7 File Offset: 0x000528B7
		public unsafe bool bOverride_RayTracingReflectionsMaxRoughness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingReflectionsMaxRoughness) & FPostProcessSettings.__PropertyMask_bOverride_RayTracingReflectionsMaxRoughness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingReflectionsMaxRoughness) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingReflectionsMaxRoughness) & ~FPostProcessSettings.__PropertyMask_bOverride_RayTracingReflectionsMaxRoughness) | (value ? FPostProcessSettings.__PropertyMask_bOverride_RayTracingReflectionsMaxRoughness : 0));
			}
		}

		// Token: 0x17000967 RID: 2407
		// (get) Token: 0x060039F7 RID: 14839 RVA: 0x000546E7 File Offset: 0x000528E7
		// (set) Token: 0x060039F8 RID: 14840 RVA: 0x00054700 File Offset: 0x00052900
		public unsafe bool bOverride_RayTracingReflectionsMaxBounces
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingReflectionsMaxBounces) & FPostProcessSettings.__PropertyMask_bOverride_RayTracingReflectionsMaxBounces) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingReflectionsMaxBounces) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingReflectionsMaxBounces) & ~FPostProcessSettings.__PropertyMask_bOverride_RayTracingReflectionsMaxBounces) | (value ? FPostProcessSettings.__PropertyMask_bOverride_RayTracingReflectionsMaxBounces : 0));
			}
		}

		// Token: 0x17000968 RID: 2408
		// (get) Token: 0x060039F9 RID: 14841 RVA: 0x00054730 File Offset: 0x00052930
		// (set) Token: 0x060039FA RID: 14842 RVA: 0x00054749 File Offset: 0x00052949
		public unsafe bool bOverride_RayTracingReflectionsSamplesPerPixel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingReflectionsSamplesPerPixel) & FPostProcessSettings.__PropertyMask_bOverride_RayTracingReflectionsSamplesPerPixel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingReflectionsSamplesPerPixel) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingReflectionsSamplesPerPixel) & ~FPostProcessSettings.__PropertyMask_bOverride_RayTracingReflectionsSamplesPerPixel) | (value ? FPostProcessSettings.__PropertyMask_bOverride_RayTracingReflectionsSamplesPerPixel : 0));
			}
		}

		// Token: 0x17000969 RID: 2409
		// (get) Token: 0x060039FB RID: 14843 RVA: 0x00054779 File Offset: 0x00052979
		// (set) Token: 0x060039FC RID: 14844 RVA: 0x00054792 File Offset: 0x00052992
		public unsafe bool bOverride_RayTracingReflectionsShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingReflectionsShadows) & FPostProcessSettings.__PropertyMask_bOverride_RayTracingReflectionsShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingReflectionsShadows) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingReflectionsShadows) & ~FPostProcessSettings.__PropertyMask_bOverride_RayTracingReflectionsShadows) | (value ? FPostProcessSettings.__PropertyMask_bOverride_RayTracingReflectionsShadows : 0));
			}
		}

		// Token: 0x1700096A RID: 2410
		// (get) Token: 0x060039FD RID: 14845 RVA: 0x000547C2 File Offset: 0x000529C2
		// (set) Token: 0x060039FE RID: 14846 RVA: 0x000547DB File Offset: 0x000529DB
		public unsafe bool bOverride_RayTracingReflectionsTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingReflectionsTranslucency) & FPostProcessSettings.__PropertyMask_bOverride_RayTracingReflectionsTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingReflectionsTranslucency) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingReflectionsTranslucency) & ~FPostProcessSettings.__PropertyMask_bOverride_RayTracingReflectionsTranslucency) | (value ? FPostProcessSettings.__PropertyMask_bOverride_RayTracingReflectionsTranslucency : 0));
			}
		}

		// Token: 0x1700096B RID: 2411
		// (get) Token: 0x060039FF RID: 14847 RVA: 0x0005480B File Offset: 0x00052A0B
		// (set) Token: 0x06003A00 RID: 14848 RVA: 0x00054824 File Offset: 0x00052A24
		public unsafe bool bOverride_TranslucencyType
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TranslucencyType) & FPostProcessSettings.__PropertyMask_bOverride_TranslucencyType) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TranslucencyType) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_TranslucencyType) & ~FPostProcessSettings.__PropertyMask_bOverride_TranslucencyType) | (value ? FPostProcessSettings.__PropertyMask_bOverride_TranslucencyType : 0));
			}
		}

		// Token: 0x1700096C RID: 2412
		// (get) Token: 0x06003A01 RID: 14849 RVA: 0x00054854 File Offset: 0x00052A54
		// (set) Token: 0x06003A02 RID: 14850 RVA: 0x0005486D File Offset: 0x00052A6D
		public unsafe bool bOverride_RayTracingTranslucencyMaxRoughness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingTranslucencyMaxRoughness) & FPostProcessSettings.__PropertyMask_bOverride_RayTracingTranslucencyMaxRoughness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingTranslucencyMaxRoughness) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingTranslucencyMaxRoughness) & ~FPostProcessSettings.__PropertyMask_bOverride_RayTracingTranslucencyMaxRoughness) | (value ? FPostProcessSettings.__PropertyMask_bOverride_RayTracingTranslucencyMaxRoughness : 0));
			}
		}

		// Token: 0x1700096D RID: 2413
		// (get) Token: 0x06003A03 RID: 14851 RVA: 0x0005489D File Offset: 0x00052A9D
		// (set) Token: 0x06003A04 RID: 14852 RVA: 0x000548B6 File Offset: 0x00052AB6
		public unsafe bool bOverride_RayTracingTranslucencyRefractionRays
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingTranslucencyRefractionRays) & FPostProcessSettings.__PropertyMask_bOverride_RayTracingTranslucencyRefractionRays) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingTranslucencyRefractionRays) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingTranslucencyRefractionRays) & ~FPostProcessSettings.__PropertyMask_bOverride_RayTracingTranslucencyRefractionRays) | (value ? FPostProcessSettings.__PropertyMask_bOverride_RayTracingTranslucencyRefractionRays : 0));
			}
		}

		// Token: 0x1700096E RID: 2414
		// (get) Token: 0x06003A05 RID: 14853 RVA: 0x000548E6 File Offset: 0x00052AE6
		// (set) Token: 0x06003A06 RID: 14854 RVA: 0x000548FF File Offset: 0x00052AFF
		public unsafe bool bOverride_RayTracingTranslucencySamplesPerPixel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingTranslucencySamplesPerPixel) & FPostProcessSettings.__PropertyMask_bOverride_RayTracingTranslucencySamplesPerPixel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingTranslucencySamplesPerPixel) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingTranslucencySamplesPerPixel) & ~FPostProcessSettings.__PropertyMask_bOverride_RayTracingTranslucencySamplesPerPixel) | (value ? FPostProcessSettings.__PropertyMask_bOverride_RayTracingTranslucencySamplesPerPixel : 0));
			}
		}

		// Token: 0x1700096F RID: 2415
		// (get) Token: 0x06003A07 RID: 14855 RVA: 0x0005492F File Offset: 0x00052B2F
		// (set) Token: 0x06003A08 RID: 14856 RVA: 0x00054948 File Offset: 0x00052B48
		public unsafe bool bOverride_RayTracingTranslucencyShadows
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingTranslucencyShadows) & FPostProcessSettings.__PropertyMask_bOverride_RayTracingTranslucencyShadows) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingTranslucencyShadows) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingTranslucencyShadows) & ~FPostProcessSettings.__PropertyMask_bOverride_RayTracingTranslucencyShadows) | (value ? FPostProcessSettings.__PropertyMask_bOverride_RayTracingTranslucencyShadows : 0));
			}
		}

		// Token: 0x17000970 RID: 2416
		// (get) Token: 0x06003A09 RID: 14857 RVA: 0x00054978 File Offset: 0x00052B78
		// (set) Token: 0x06003A0A RID: 14858 RVA: 0x00054991 File Offset: 0x00052B91
		public unsafe bool bOverride_RayTracingTranslucencyRefraction
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingTranslucencyRefraction) & FPostProcessSettings.__PropertyMask_bOverride_RayTracingTranslucencyRefraction) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingTranslucencyRefraction) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingTranslucencyRefraction) & ~FPostProcessSettings.__PropertyMask_bOverride_RayTracingTranslucencyRefraction) | (value ? FPostProcessSettings.__PropertyMask_bOverride_RayTracingTranslucencyRefraction : 0));
			}
		}

		// Token: 0x17000971 RID: 2417
		// (get) Token: 0x06003A0B RID: 14859 RVA: 0x000549C1 File Offset: 0x00052BC1
		// (set) Token: 0x06003A0C RID: 14860 RVA: 0x000549DA File Offset: 0x00052BDA
		public unsafe bool bOverride_RayTracingGI
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingGI) & FPostProcessSettings.__PropertyMask_bOverride_RayTracingGI) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingGI) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingGI) & ~FPostProcessSettings.__PropertyMask_bOverride_RayTracingGI) | (value ? FPostProcessSettings.__PropertyMask_bOverride_RayTracingGI : 0));
			}
		}

		// Token: 0x17000972 RID: 2418
		// (get) Token: 0x06003A0D RID: 14861 RVA: 0x00054A0A File Offset: 0x00052C0A
		// (set) Token: 0x06003A0E RID: 14862 RVA: 0x00054A23 File Offset: 0x00052C23
		public unsafe bool bOverride_RayTracingGIMaxBounces
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingGIMaxBounces) & FPostProcessSettings.__PropertyMask_bOverride_RayTracingGIMaxBounces) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingGIMaxBounces) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingGIMaxBounces) & ~FPostProcessSettings.__PropertyMask_bOverride_RayTracingGIMaxBounces) | (value ? FPostProcessSettings.__PropertyMask_bOverride_RayTracingGIMaxBounces : 0));
			}
		}

		// Token: 0x17000973 RID: 2419
		// (get) Token: 0x06003A0F RID: 14863 RVA: 0x00054A53 File Offset: 0x00052C53
		// (set) Token: 0x06003A10 RID: 14864 RVA: 0x00054A6C File Offset: 0x00052C6C
		public unsafe bool bOverride_RayTracingGISamplesPerPixel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingGISamplesPerPixel) & FPostProcessSettings.__PropertyMask_bOverride_RayTracingGISamplesPerPixel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingGISamplesPerPixel) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_RayTracingGISamplesPerPixel) & ~FPostProcessSettings.__PropertyMask_bOverride_RayTracingGISamplesPerPixel) | (value ? FPostProcessSettings.__PropertyMask_bOverride_RayTracingGISamplesPerPixel : 0));
			}
		}

		// Token: 0x17000974 RID: 2420
		// (get) Token: 0x06003A11 RID: 14865 RVA: 0x00054A9C File Offset: 0x00052C9C
		// (set) Token: 0x06003A12 RID: 14866 RVA: 0x00054AB5 File Offset: 0x00052CB5
		public unsafe bool bOverride_PathTracingMaxBounces
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_PathTracingMaxBounces) & FPostProcessSettings.__PropertyMask_bOverride_PathTracingMaxBounces) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_PathTracingMaxBounces) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_PathTracingMaxBounces) & ~FPostProcessSettings.__PropertyMask_bOverride_PathTracingMaxBounces) | (value ? FPostProcessSettings.__PropertyMask_bOverride_PathTracingMaxBounces : 0));
			}
		}

		// Token: 0x17000975 RID: 2421
		// (get) Token: 0x06003A13 RID: 14867 RVA: 0x00054AE5 File Offset: 0x00052CE5
		// (set) Token: 0x06003A14 RID: 14868 RVA: 0x00054AFE File Offset: 0x00052CFE
		public unsafe bool bOverride_PathTracingSamplesPerPixel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_PathTracingSamplesPerPixel) & FPostProcessSettings.__PropertyMask_bOverride_PathTracingSamplesPerPixel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_PathTracingSamplesPerPixel) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_PathTracingSamplesPerPixel) & ~FPostProcessSettings.__PropertyMask_bOverride_PathTracingSamplesPerPixel) | (value ? FPostProcessSettings.__PropertyMask_bOverride_PathTracingSamplesPerPixel : 0));
			}
		}

		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06003A15 RID: 14869 RVA: 0x00054B2E File Offset: 0x00052D2E
		// (set) Token: 0x06003A16 RID: 14870 RVA: 0x00054B47 File Offset: 0x00052D47
		public unsafe bool bKuroDangerToggle
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bKuroDangerToggle) & FPostProcessSettings.__PropertyMask_bKuroDangerToggle) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bKuroDangerToggle) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bKuroDangerToggle) & ~FPostProcessSettings.__PropertyMask_bKuroDangerToggle) | (value ? FPostProcessSettings.__PropertyMask_bKuroDangerToggle : 0));
			}
		}

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06003A17 RID: 14871 RVA: 0x00054B77 File Offset: 0x00052D77
		// (set) Token: 0x06003A18 RID: 14872 RVA: 0x00054B90 File Offset: 0x00052D90
		public unsafe bool bMobileHQGaussian
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bMobileHQGaussian) & FPostProcessSettings.__PropertyMask_bMobileHQGaussian) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bMobileHQGaussian) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bMobileHQGaussian) & ~FPostProcessSettings.__PropertyMask_bMobileHQGaussian) | (value ? FPostProcessSettings.__PropertyMask_bMobileHQGaussian : 0));
			}
		}

		// Token: 0x17000978 RID: 2424
		// (get) Token: 0x06003A19 RID: 14873 RVA: 0x00054BC0 File Offset: 0x00052DC0
		// (set) Token: 0x06003A1A RID: 14874 RVA: 0x00054BD9 File Offset: 0x00052DD9
		public unsafe bool bOverride_KuroCharacterLUTSplitEnable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroCharacterLUTSplitEnable) & FPostProcessSettings.__PropertyMask_bOverride_KuroCharacterLUTSplitEnable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroCharacterLUTSplitEnable) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroCharacterLUTSplitEnable) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroCharacterLUTSplitEnable) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroCharacterLUTSplitEnable : 0));
			}
		}

		// Token: 0x17000979 RID: 2425
		// (get) Token: 0x06003A1B RID: 14875 RVA: 0x00054C09 File Offset: 0x00052E09
		// (set) Token: 0x06003A1C RID: 14876 RVA: 0x00054C22 File Offset: 0x00052E22
		public unsafe bool bOverride_KuroCharacterColorGradingLUT
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroCharacterColorGradingLUT) & FPostProcessSettings.__PropertyMask_bOverride_KuroCharacterColorGradingLUT) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroCharacterColorGradingLUT) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroCharacterColorGradingLUT) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroCharacterColorGradingLUT) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroCharacterColorGradingLUT : 0));
			}
		}

		// Token: 0x1700097A RID: 2426
		// (get) Token: 0x06003A1D RID: 14877 RVA: 0x00054C52 File Offset: 0x00052E52
		// (set) Token: 0x06003A1E RID: 14878 RVA: 0x00054C6B File Offset: 0x00052E6B
		public unsafe bool bOverride_KuroCharacterColorGradingLUTLerpIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroCharacterColorGradingLUTLerpIntensity) & FPostProcessSettings.__PropertyMask_bOverride_KuroCharacterColorGradingLUTLerpIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroCharacterColorGradingLUTLerpIntensity) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroCharacterColorGradingLUTLerpIntensity) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroCharacterColorGradingLUTLerpIntensity) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroCharacterColorGradingLUTLerpIntensity : 0));
			}
		}

		// Token: 0x1700097B RID: 2427
		// (get) Token: 0x06003A1F RID: 14879 RVA: 0x00054C9B File Offset: 0x00052E9B
		// (set) Token: 0x06003A20 RID: 14880 RVA: 0x00054CB4 File Offset: 0x00052EB4
		public unsafe bool bOverride_KuroColorGradingTextureLUTInterpolationEnable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroColorGradingTextureLUTInterpolationEnable) & FPostProcessSettings.__PropertyMask_bOverride_KuroColorGradingTextureLUTInterpolationEnable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroColorGradingTextureLUTInterpolationEnable) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_KuroColorGradingTextureLUTInterpolationEnable) & ~FPostProcessSettings.__PropertyMask_bOverride_KuroColorGradingTextureLUTInterpolationEnable) | (value ? FPostProcessSettings.__PropertyMask_bOverride_KuroColorGradingTextureLUTInterpolationEnable : 0));
			}
		}

		// Token: 0x1700097C RID: 2428
		// (get) Token: 0x06003A21 RID: 14881 RVA: 0x00054CE4 File Offset: 0x00052EE4
		// (set) Token: 0x06003A22 RID: 14882 RVA: 0x00054CF4 File Offset: 0x00052EF4
		public unsafe float KuroTonemapA
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroTonemapA);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroTonemapA) = value;
			}
		}

		// Token: 0x1700097D RID: 2429
		// (get) Token: 0x06003A23 RID: 14883 RVA: 0x00054D05 File Offset: 0x00052F05
		// (set) Token: 0x06003A24 RID: 14884 RVA: 0x00054D15 File Offset: 0x00052F15
		public unsafe float KuroTonemapB
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroTonemapB);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroTonemapB) = value;
			}
		}

		// Token: 0x1700097E RID: 2430
		// (get) Token: 0x06003A25 RID: 14885 RVA: 0x00054D26 File Offset: 0x00052F26
		// (set) Token: 0x06003A26 RID: 14886 RVA: 0x00054D36 File Offset: 0x00052F36
		public unsafe float KuroTonemapC
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroTonemapC);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroTonemapC) = value;
			}
		}

		// Token: 0x1700097F RID: 2431
		// (get) Token: 0x06003A27 RID: 14887 RVA: 0x00054D47 File Offset: 0x00052F47
		// (set) Token: 0x06003A28 RID: 14888 RVA: 0x00054D57 File Offset: 0x00052F57
		public unsafe float KuroTonemapD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroTonemapD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroTonemapD) = value;
			}
		}

		// Token: 0x17000980 RID: 2432
		// (get) Token: 0x06003A29 RID: 14889 RVA: 0x00054D68 File Offset: 0x00052F68
		// (set) Token: 0x06003A2A RID: 14890 RVA: 0x00054D78 File Offset: 0x00052F78
		public unsafe float KuroTonemapE
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroTonemapE);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroTonemapE) = value;
			}
		}

		// Token: 0x17000981 RID: 2433
		// (get) Token: 0x06003A2B RID: 14891 RVA: 0x00054D89 File Offset: 0x00052F89
		// (set) Token: 0x06003A2C RID: 14892 RVA: 0x00054D99 File Offset: 0x00052F99
		public unsafe float KuroTonemapF
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroTonemapF);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroTonemapF) = value;
			}
		}

		// Token: 0x17000982 RID: 2434
		// (get) Token: 0x06003A2D RID: 14893 RVA: 0x00054DAA File Offset: 0x00052FAA
		// (set) Token: 0x06003A2E RID: 14894 RVA: 0x00054DBA File Offset: 0x00052FBA
		public unsafe bool UseCharacterMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_UseCharacterMask) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_UseCharacterMask) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000983 RID: 2435
		// (get) Token: 0x06003A2F RID: 14895 RVA: 0x00054DCB File Offset: 0x00052FCB
		// (set) Token: 0x06003A30 RID: 14896 RVA: 0x00054DDB File Offset: 0x00052FDB
		public unsafe float WhiteTemp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_WhiteTemp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_WhiteTemp) = value;
			}
		}

		// Token: 0x17000984 RID: 2436
		// (get) Token: 0x06003A31 RID: 14897 RVA: 0x00054DEC File Offset: 0x00052FEC
		// (set) Token: 0x06003A32 RID: 14898 RVA: 0x00054DFC File Offset: 0x00052FFC
		public unsafe float WhiteTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_WhiteTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_WhiteTint) = value;
			}
		}

		// Token: 0x17000985 RID: 2437
		// (get) Token: 0x06003A33 RID: 14899 RVA: 0x00054E0D File Offset: 0x0005300D
		// (set) Token: 0x06003A34 RID: 14900 RVA: 0x00054E21 File Offset: 0x00053021
		public unsafe FVector4 ColorSaturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorSaturation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorSaturation) = value;
			}
		}

		// Token: 0x17000986 RID: 2438
		// (get) Token: 0x06003A35 RID: 14901 RVA: 0x00054E36 File Offset: 0x00053036
		// (set) Token: 0x06003A36 RID: 14902 RVA: 0x00054E4A File Offset: 0x0005304A
		public unsafe FVector4 ColorContrast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorContrast);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorContrast) = value;
			}
		}

		// Token: 0x17000987 RID: 2439
		// (get) Token: 0x06003A37 RID: 14903 RVA: 0x00054E5F File Offset: 0x0005305F
		// (set) Token: 0x06003A38 RID: 14904 RVA: 0x00054E73 File Offset: 0x00053073
		public unsafe FVector4 ColorGamma
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorGamma);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorGamma) = value;
			}
		}

		// Token: 0x17000988 RID: 2440
		// (get) Token: 0x06003A39 RID: 14905 RVA: 0x00054E88 File Offset: 0x00053088
		// (set) Token: 0x06003A3A RID: 14906 RVA: 0x00054E9C File Offset: 0x0005309C
		public unsafe FVector4 ColorGain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorGain);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorGain) = value;
			}
		}

		// Token: 0x17000989 RID: 2441
		// (get) Token: 0x06003A3B RID: 14907 RVA: 0x00054EB1 File Offset: 0x000530B1
		// (set) Token: 0x06003A3C RID: 14908 RVA: 0x00054EC5 File Offset: 0x000530C5
		public unsafe FVector4 ColorOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorOffset) = value;
			}
		}

		// Token: 0x1700098A RID: 2442
		// (get) Token: 0x06003A3D RID: 14909 RVA: 0x00054EDA File Offset: 0x000530DA
		// (set) Token: 0x06003A3E RID: 14910 RVA: 0x00054EEE File Offset: 0x000530EE
		public unsafe FVector4 ColorSaturationClient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorSaturationClient);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorSaturationClient) = value;
			}
		}

		// Token: 0x1700098B RID: 2443
		// (get) Token: 0x06003A3F RID: 14911 RVA: 0x00054F03 File Offset: 0x00053103
		// (set) Token: 0x06003A40 RID: 14912 RVA: 0x00054F17 File Offset: 0x00053117
		public unsafe FVector4 ColorContrastClient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorContrastClient);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorContrastClient) = value;
			}
		}

		// Token: 0x1700098C RID: 2444
		// (get) Token: 0x06003A41 RID: 14913 RVA: 0x00054F2C File Offset: 0x0005312C
		// (set) Token: 0x06003A42 RID: 14914 RVA: 0x00054F40 File Offset: 0x00053140
		public unsafe FVector4 ColorSaturationShadows
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorSaturationShadows);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorSaturationShadows) = value;
			}
		}

		// Token: 0x1700098D RID: 2445
		// (get) Token: 0x06003A43 RID: 14915 RVA: 0x00054F55 File Offset: 0x00053155
		// (set) Token: 0x06003A44 RID: 14916 RVA: 0x00054F69 File Offset: 0x00053169
		public unsafe FVector4 ColorContrastShadows
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorContrastShadows);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorContrastShadows) = value;
			}
		}

		// Token: 0x1700098E RID: 2446
		// (get) Token: 0x06003A45 RID: 14917 RVA: 0x00054F7E File Offset: 0x0005317E
		// (set) Token: 0x06003A46 RID: 14918 RVA: 0x00054F92 File Offset: 0x00053192
		public unsafe FVector4 ColorGammaShadows
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorGammaShadows);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorGammaShadows) = value;
			}
		}

		// Token: 0x1700098F RID: 2447
		// (get) Token: 0x06003A47 RID: 14919 RVA: 0x00054FA7 File Offset: 0x000531A7
		// (set) Token: 0x06003A48 RID: 14920 RVA: 0x00054FBB File Offset: 0x000531BB
		public unsafe FVector4 ColorGainShadows
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorGainShadows);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorGainShadows) = value;
			}
		}

		// Token: 0x17000990 RID: 2448
		// (get) Token: 0x06003A49 RID: 14921 RVA: 0x00054FD0 File Offset: 0x000531D0
		// (set) Token: 0x06003A4A RID: 14922 RVA: 0x00054FE4 File Offset: 0x000531E4
		public unsafe FVector4 ColorOffsetShadows
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorOffsetShadows);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorOffsetShadows) = value;
			}
		}

		// Token: 0x17000991 RID: 2449
		// (get) Token: 0x06003A4B RID: 14923 RVA: 0x00054FF9 File Offset: 0x000531F9
		// (set) Token: 0x06003A4C RID: 14924 RVA: 0x0005500D File Offset: 0x0005320D
		public unsafe FVector4 ColorSaturationMidtones
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorSaturationMidtones);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorSaturationMidtones) = value;
			}
		}

		// Token: 0x17000992 RID: 2450
		// (get) Token: 0x06003A4D RID: 14925 RVA: 0x00055022 File Offset: 0x00053222
		// (set) Token: 0x06003A4E RID: 14926 RVA: 0x00055036 File Offset: 0x00053236
		public unsafe FVector4 ColorContrastMidtones
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorContrastMidtones);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorContrastMidtones) = value;
			}
		}

		// Token: 0x17000993 RID: 2451
		// (get) Token: 0x06003A4F RID: 14927 RVA: 0x0005504B File Offset: 0x0005324B
		// (set) Token: 0x06003A50 RID: 14928 RVA: 0x0005505F File Offset: 0x0005325F
		public unsafe FVector4 ColorGammaMidtones
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorGammaMidtones);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorGammaMidtones) = value;
			}
		}

		// Token: 0x17000994 RID: 2452
		// (get) Token: 0x06003A51 RID: 14929 RVA: 0x00055074 File Offset: 0x00053274
		// (set) Token: 0x06003A52 RID: 14930 RVA: 0x00055088 File Offset: 0x00053288
		public unsafe FVector4 ColorGainMidtones
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorGainMidtones);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorGainMidtones) = value;
			}
		}

		// Token: 0x17000995 RID: 2453
		// (get) Token: 0x06003A53 RID: 14931 RVA: 0x0005509D File Offset: 0x0005329D
		// (set) Token: 0x06003A54 RID: 14932 RVA: 0x000550B1 File Offset: 0x000532B1
		public unsafe FVector4 ColorOffsetMidtones
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorOffsetMidtones);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorOffsetMidtones) = value;
			}
		}

		// Token: 0x17000996 RID: 2454
		// (get) Token: 0x06003A55 RID: 14933 RVA: 0x000550C6 File Offset: 0x000532C6
		// (set) Token: 0x06003A56 RID: 14934 RVA: 0x000550DA File Offset: 0x000532DA
		public unsafe FVector4 ColorSaturationHighlights
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorSaturationHighlights);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorSaturationHighlights) = value;
			}
		}

		// Token: 0x17000997 RID: 2455
		// (get) Token: 0x06003A57 RID: 14935 RVA: 0x000550EF File Offset: 0x000532EF
		// (set) Token: 0x06003A58 RID: 14936 RVA: 0x00055103 File Offset: 0x00053303
		public unsafe FVector4 ColorContrastHighlights
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorContrastHighlights);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorContrastHighlights) = value;
			}
		}

		// Token: 0x17000998 RID: 2456
		// (get) Token: 0x06003A59 RID: 14937 RVA: 0x00055118 File Offset: 0x00053318
		// (set) Token: 0x06003A5A RID: 14938 RVA: 0x0005512C File Offset: 0x0005332C
		public unsafe FVector4 ColorGammaHighlights
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorGammaHighlights);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorGammaHighlights) = value;
			}
		}

		// Token: 0x17000999 RID: 2457
		// (get) Token: 0x06003A5B RID: 14939 RVA: 0x00055141 File Offset: 0x00053341
		// (set) Token: 0x06003A5C RID: 14940 RVA: 0x00055155 File Offset: 0x00053355
		public unsafe FVector4 ColorGainHighlights
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorGainHighlights);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorGainHighlights) = value;
			}
		}

		// Token: 0x1700099A RID: 2458
		// (get) Token: 0x06003A5D RID: 14941 RVA: 0x0005516A File Offset: 0x0005336A
		// (set) Token: 0x06003A5E RID: 14942 RVA: 0x0005517E File Offset: 0x0005337E
		public unsafe FVector4 ColorOffsetHighlights
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorOffsetHighlights);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorOffsetHighlights) = value;
			}
		}

		// Token: 0x1700099B RID: 2459
		// (get) Token: 0x06003A5F RID: 14943 RVA: 0x00055193 File Offset: 0x00053393
		// (set) Token: 0x06003A60 RID: 14944 RVA: 0x000551A3 File Offset: 0x000533A3
		public unsafe float ColorCorrectionHighlightsMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorCorrectionHighlightsMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorCorrectionHighlightsMin) = value;
			}
		}

		// Token: 0x1700099C RID: 2460
		// (get) Token: 0x06003A61 RID: 14945 RVA: 0x000551B4 File Offset: 0x000533B4
		// (set) Token: 0x06003A62 RID: 14946 RVA: 0x000551C4 File Offset: 0x000533C4
		public unsafe float ColorCorrectionShadowsMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorCorrectionShadowsMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorCorrectionShadowsMax) = value;
			}
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06003A63 RID: 14947 RVA: 0x000551D5 File Offset: 0x000533D5
		// (set) Token: 0x06003A64 RID: 14948 RVA: 0x000551E5 File Offset: 0x000533E5
		public unsafe float BlueCorrection
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BlueCorrection);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BlueCorrection) = value;
			}
		}

		// Token: 0x1700099E RID: 2462
		// (get) Token: 0x06003A65 RID: 14949 RVA: 0x000551F6 File Offset: 0x000533F6
		// (set) Token: 0x06003A66 RID: 14950 RVA: 0x00055206 File Offset: 0x00053406
		public unsafe float ExpandGamut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ExpandGamut);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ExpandGamut) = value;
			}
		}

		// Token: 0x1700099F RID: 2463
		// (get) Token: 0x06003A67 RID: 14951 RVA: 0x00055217 File Offset: 0x00053417
		// (set) Token: 0x06003A68 RID: 14952 RVA: 0x00055227 File Offset: 0x00053427
		public unsafe float ToneCurveAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ToneCurveAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ToneCurveAmount) = value;
			}
		}

		// Token: 0x170009A0 RID: 2464
		// (get) Token: 0x06003A69 RID: 14953 RVA: 0x00055238 File Offset: 0x00053438
		// (set) Token: 0x06003A6A RID: 14954 RVA: 0x00055248 File Offset: 0x00053448
		public unsafe float FilmSlope
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmSlope);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmSlope) = value;
			}
		}

		// Token: 0x170009A1 RID: 2465
		// (get) Token: 0x06003A6B RID: 14955 RVA: 0x00055259 File Offset: 0x00053459
		// (set) Token: 0x06003A6C RID: 14956 RVA: 0x00055269 File Offset: 0x00053469
		public unsafe float FilmToe
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmToe);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmToe) = value;
			}
		}

		// Token: 0x170009A2 RID: 2466
		// (get) Token: 0x06003A6D RID: 14957 RVA: 0x0005527A File Offset: 0x0005347A
		// (set) Token: 0x06003A6E RID: 14958 RVA: 0x0005528A File Offset: 0x0005348A
		public unsafe float FilmShoulder
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmShoulder);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmShoulder) = value;
			}
		}

		// Token: 0x170009A3 RID: 2467
		// (get) Token: 0x06003A6F RID: 14959 RVA: 0x0005529B File Offset: 0x0005349B
		// (set) Token: 0x06003A70 RID: 14960 RVA: 0x000552AB File Offset: 0x000534AB
		public unsafe float FilmBlackClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmBlackClip);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmBlackClip) = value;
			}
		}

		// Token: 0x170009A4 RID: 2468
		// (get) Token: 0x06003A71 RID: 14961 RVA: 0x000552BC File Offset: 0x000534BC
		// (set) Token: 0x06003A72 RID: 14962 RVA: 0x000552CC File Offset: 0x000534CC
		public unsafe float FilmWhiteClip
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmWhiteClip);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmWhiteClip) = value;
			}
		}

		// Token: 0x170009A5 RID: 2469
		// (get) Token: 0x06003A73 RID: 14963 RVA: 0x000552DD File Offset: 0x000534DD
		// (set) Token: 0x06003A74 RID: 14964 RVA: 0x000552F1 File Offset: 0x000534F1
		public unsafe FLinearColor FilmWhitePoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmWhitePoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmWhitePoint) = value;
			}
		}

		// Token: 0x170009A6 RID: 2470
		// (get) Token: 0x06003A75 RID: 14965 RVA: 0x00055306 File Offset: 0x00053506
		// (set) Token: 0x06003A76 RID: 14966 RVA: 0x0005531A File Offset: 0x0005351A
		public unsafe FLinearColor FilmShadowTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmShadowTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmShadowTint) = value;
			}
		}

		// Token: 0x170009A7 RID: 2471
		// (get) Token: 0x06003A77 RID: 14967 RVA: 0x0005532F File Offset: 0x0005352F
		// (set) Token: 0x06003A78 RID: 14968 RVA: 0x0005533F File Offset: 0x0005353F
		public unsafe float FilmShadowTintBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmShadowTintBlend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmShadowTintBlend) = value;
			}
		}

		// Token: 0x170009A8 RID: 2472
		// (get) Token: 0x06003A79 RID: 14969 RVA: 0x00055350 File Offset: 0x00053550
		// (set) Token: 0x06003A7A RID: 14970 RVA: 0x00055360 File Offset: 0x00053560
		public unsafe float FilmShadowTintAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmShadowTintAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmShadowTintAmount) = value;
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06003A7B RID: 14971 RVA: 0x00055371 File Offset: 0x00053571
		// (set) Token: 0x06003A7C RID: 14972 RVA: 0x00055381 File Offset: 0x00053581
		public unsafe float FilmSaturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmSaturation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmSaturation) = value;
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06003A7D RID: 14973 RVA: 0x00055392 File Offset: 0x00053592
		// (set) Token: 0x06003A7E RID: 14974 RVA: 0x000553A6 File Offset: 0x000535A6
		public unsafe FLinearColor FilmChannelMixerRed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmChannelMixerRed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmChannelMixerRed) = value;
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06003A7F RID: 14975 RVA: 0x000553BB File Offset: 0x000535BB
		// (set) Token: 0x06003A80 RID: 14976 RVA: 0x000553CF File Offset: 0x000535CF
		public unsafe FLinearColor FilmChannelMixerGreen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmChannelMixerGreen);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmChannelMixerGreen) = value;
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06003A81 RID: 14977 RVA: 0x000553E4 File Offset: 0x000535E4
		// (set) Token: 0x06003A82 RID: 14978 RVA: 0x000553F8 File Offset: 0x000535F8
		public unsafe FLinearColor FilmChannelMixerBlue
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmChannelMixerBlue);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmChannelMixerBlue) = value;
			}
		}

		// Token: 0x170009AD RID: 2477
		// (get) Token: 0x06003A83 RID: 14979 RVA: 0x0005540D File Offset: 0x0005360D
		// (set) Token: 0x06003A84 RID: 14980 RVA: 0x0005541D File Offset: 0x0005361D
		public unsafe float FilmContrast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmContrast);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmContrast) = value;
			}
		}

		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x06003A85 RID: 14981 RVA: 0x0005542E File Offset: 0x0005362E
		// (set) Token: 0x06003A86 RID: 14982 RVA: 0x0005543E File Offset: 0x0005363E
		public unsafe float FilmToeAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmToeAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmToeAmount) = value;
			}
		}

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x06003A87 RID: 14983 RVA: 0x0005544F File Offset: 0x0005364F
		// (set) Token: 0x06003A88 RID: 14984 RVA: 0x0005545F File Offset: 0x0005365F
		public unsafe float FilmHealAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmHealAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmHealAmount) = value;
			}
		}

		// Token: 0x170009B0 RID: 2480
		// (get) Token: 0x06003A89 RID: 14985 RVA: 0x00055470 File Offset: 0x00053670
		// (set) Token: 0x06003A8A RID: 14986 RVA: 0x00055480 File Offset: 0x00053680
		public unsafe float FilmDynamicRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmDynamicRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FilmDynamicRange) = value;
			}
		}

		// Token: 0x170009B1 RID: 2481
		// (get) Token: 0x06003A8B RID: 14987 RVA: 0x00055491 File Offset: 0x00053691
		// (set) Token: 0x06003A8C RID: 14988 RVA: 0x000554A5 File Offset: 0x000536A5
		public unsafe FLinearColor SceneColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneColorTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneColorTint) = value;
			}
		}

		// Token: 0x170009B2 RID: 2482
		// (get) Token: 0x06003A8D RID: 14989 RVA: 0x000554BA File Offset: 0x000536BA
		// (set) Token: 0x06003A8E RID: 14990 RVA: 0x000554CA File Offset: 0x000536CA
		public unsafe float DecalSaturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DecalSaturation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DecalSaturation) = value;
			}
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06003A8F RID: 14991 RVA: 0x000554DB File Offset: 0x000536DB
		// (set) Token: 0x06003A90 RID: 14992 RVA: 0x000554EB File Offset: 0x000536EB
		public unsafe float DecalOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DecalOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DecalOpacity) = value;
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06003A91 RID: 14993 RVA: 0x000554FC File Offset: 0x000536FC
		// (set) Token: 0x06003A92 RID: 14994 RVA: 0x00055510 File Offset: 0x00053710
		public unsafe FLinearColor TranslucentColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TranslucentColorTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TranslucentColorTint) = value;
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06003A93 RID: 14995 RVA: 0x00055525 File Offset: 0x00053725
		// (set) Token: 0x06003A94 RID: 14996 RVA: 0x00055535 File Offset: 0x00053735
		public unsafe float SceneColorDesaturate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneColorDesaturate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneColorDesaturate) = value;
			}
		}

		// Token: 0x170009B6 RID: 2486
		// (get) Token: 0x06003A95 RID: 14997 RVA: 0x00055546 File Offset: 0x00053746
		// (set) Token: 0x06003A96 RID: 14998 RVA: 0x00055556 File Offset: 0x00053756
		public unsafe float SceneObjectSaturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneObjectSaturation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneObjectSaturation) = value;
			}
		}

		// Token: 0x170009B7 RID: 2487
		// (get) Token: 0x06003A97 RID: 14999 RVA: 0x00055567 File Offset: 0x00053767
		// (set) Token: 0x06003A98 RID: 15000 RVA: 0x00055577 File Offset: 0x00053777
		public unsafe float SceneColorClear
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneColorClear);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneColorClear) = value;
			}
		}

		// Token: 0x170009B8 RID: 2488
		// (get) Token: 0x06003A99 RID: 15001 RVA: 0x00055588 File Offset: 0x00053788
		// (set) Token: 0x06003A9A RID: 15002 RVA: 0x0005559C File Offset: 0x0005379C
		public unsafe FLinearColor SceneColorClearColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneColorClearColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneColorClearColor) = value;
			}
		}

		// Token: 0x170009B9 RID: 2489
		// (get) Token: 0x06003A9B RID: 15003 RVA: 0x000555B1 File Offset: 0x000537B1
		// (set) Token: 0x06003A9C RID: 15004 RVA: 0x000555C5 File Offset: 0x000537C5
		public unsafe FVector SceneColorClearCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneColorClearCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneColorClearCenter) = value;
			}
		}

		// Token: 0x170009BA RID: 2490
		// (get) Token: 0x06003A9D RID: 15005 RVA: 0x000555DA File Offset: 0x000537DA
		// (set) Token: 0x06003A9E RID: 15006 RVA: 0x000555EA File Offset: 0x000537EA
		public unsafe float SceneColorClearRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneColorClearRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneColorClearRadius) = value;
			}
		}

		// Token: 0x170009BB RID: 2491
		// (get) Token: 0x06003A9F RID: 15007 RVA: 0x000555FB File Offset: 0x000537FB
		// (set) Token: 0x06003AA0 RID: 15008 RVA: 0x0005560B File Offset: 0x0005380B
		public unsafe float SceneColorClearFadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneColorClearFadeDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneColorClearFadeDistance) = value;
			}
		}

		// Token: 0x170009BC RID: 2492
		// (get) Token: 0x06003AA1 RID: 15009 RVA: 0x0005561C File Offset: 0x0005381C
		// (set) Token: 0x06003AA2 RID: 15010 RVA: 0x0005562C File Offset: 0x0005382C
		public unsafe float TranslucentColorDesaturate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TranslucentColorDesaturate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TranslucentColorDesaturate) = value;
			}
		}

		// Token: 0x170009BD RID: 2493
		// (get) Token: 0x06003AA3 RID: 15011 RVA: 0x0005563D File Offset: 0x0005383D
		// (set) Token: 0x06003AA4 RID: 15012 RVA: 0x0005564D File Offset: 0x0005384D
		public unsafe bool FightTranslucentNoDesaturate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FightTranslucentNoDesaturate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FightTranslucentNoDesaturate) = (value ? 1 : 0);
			}
		}

		// Token: 0x170009BE RID: 2494
		// (get) Token: 0x06003AA5 RID: 15013 RVA: 0x0005565E File Offset: 0x0005385E
		// (set) Token: 0x06003AA6 RID: 15014 RVA: 0x00055672 File Offset: 0x00053872
		public unsafe FLinearColor SceneTranslucentColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneTranslucentColorTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneTranslucentColorTint) = value;
			}
		}

		// Token: 0x170009BF RID: 2495
		// (get) Token: 0x06003AA7 RID: 15015 RVA: 0x00055687 File Offset: 0x00053887
		// (set) Token: 0x06003AA8 RID: 15016 RVA: 0x0005569B File Offset: 0x0005389B
		public unsafe FLinearColor SceneEmissiveTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneEmissiveTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneEmissiveTint) = value;
			}
		}

		// Token: 0x170009C0 RID: 2496
		// (get) Token: 0x06003AA9 RID: 15017 RVA: 0x000556B0 File Offset: 0x000538B0
		// (set) Token: 0x06003AAA RID: 15018 RVA: 0x000556C0 File Offset: 0x000538C0
		public unsafe float SceneTranslucentColorDesaturate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneTranslucentColorDesaturate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneTranslucentColorDesaturate) = value;
			}
		}

		// Token: 0x170009C1 RID: 2497
		// (get) Token: 0x06003AAB RID: 15019 RVA: 0x000556D1 File Offset: 0x000538D1
		// (set) Token: 0x06003AAC RID: 15020 RVA: 0x000556E1 File Offset: 0x000538E1
		public unsafe float SeparateTranslucencyBlurSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SeparateTranslucencyBlurSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SeparateTranslucencyBlurSize) = value;
			}
		}

		// Token: 0x170009C2 RID: 2498
		// (get) Token: 0x06003AAD RID: 15021 RVA: 0x000556F2 File Offset: 0x000538F2
		// (set) Token: 0x06003AAE RID: 15022 RVA: 0x0005570B File Offset: 0x0005390B
		public unsafe bool EnableSPD
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EnableSPD) & FPostProcessSettings.__PropertyMask_EnableSPD) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EnableSPD) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EnableSPD) & ~FPostProcessSettings.__PropertyMask_EnableSPD) | (value ? FPostProcessSettings.__PropertyMask_EnableSPD : 0));
			}
		}

		// Token: 0x170009C3 RID: 2499
		// (get) Token: 0x06003AAF RID: 15023 RVA: 0x0005573B File Offset: 0x0005393B
		// (set) Token: 0x06003AB0 RID: 15024 RVA: 0x0005574B File Offset: 0x0005394B
		public unsafe float SceneFringeIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneFringeIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SceneFringeIntensity) = value;
			}
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06003AB1 RID: 15025 RVA: 0x0005575C File Offset: 0x0005395C
		// (set) Token: 0x06003AB2 RID: 15026 RVA: 0x0005576C File Offset: 0x0005396C
		public unsafe float ChromaticAberrationStartOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ChromaticAberrationStartOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ChromaticAberrationStartOffset) = value;
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06003AB3 RID: 15027 RVA: 0x0005577D File Offset: 0x0005397D
		// (set) Token: 0x06003AB4 RID: 15028 RVA: 0x0005578D File Offset: 0x0005398D
		public unsafe float BaoChromaticAberrationIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BaoChromaticAberrationIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BaoChromaticAberrationIntensity) = value;
			}
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06003AB5 RID: 15029 RVA: 0x0005579E File Offset: 0x0005399E
		// (set) Token: 0x06003AB6 RID: 15030 RVA: 0x000557AE File Offset: 0x000539AE
		public unsafe float BaoChromaticAberrationMaskCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BaoChromaticAberrationMaskCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BaoChromaticAberrationMaskCenter) = value;
			}
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x06003AB7 RID: 15031 RVA: 0x000557BF File Offset: 0x000539BF
		// (set) Token: 0x06003AB8 RID: 15032 RVA: 0x000557CF File Offset: 0x000539CF
		public unsafe float BaoChromaticAberrationYScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BaoChromaticAberrationYScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BaoChromaticAberrationYScale) = value;
			}
		}

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x06003AB9 RID: 15033 RVA: 0x000557E0 File Offset: 0x000539E0
		// (set) Token: 0x06003ABA RID: 15034 RVA: 0x000557F0 File Offset: 0x000539F0
		public unsafe float BaoChromaticAberrationYPan
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BaoChromaticAberrationYPan);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BaoChromaticAberrationYPan) = value;
			}
		}

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06003ABB RID: 15035 RVA: 0x00055801 File Offset: 0x00053A01
		// (set) Token: 0x06003ABC RID: 15036 RVA: 0x00055811 File Offset: 0x00053A11
		public unsafe float KuroFoliageMaterialAO
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroFoliageMaterialAO);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroFoliageMaterialAO) = value;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06003ABD RID: 15037 RVA: 0x00055822 File Offset: 0x00053A22
		// (set) Token: 0x06003ABE RID: 15038 RVA: 0x00055832 File Offset: 0x00053A32
		public unsafe float KuroFoliageScreenSpaceAO
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroFoliageScreenSpaceAO);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroFoliageScreenSpaceAO) = value;
			}
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06003ABF RID: 15039 RVA: 0x00055843 File Offset: 0x00053A43
		// (set) Token: 0x06003AC0 RID: 15040 RVA: 0x0005585C File Offset: 0x00053A5C
		public unsafe bool UseFixCharacterRim
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_UseFixCharacterRim) & FPostProcessSettings.__PropertyMask_UseFixCharacterRim) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_UseFixCharacterRim) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_UseFixCharacterRim) & ~FPostProcessSettings.__PropertyMask_UseFixCharacterRim) | (value ? FPostProcessSettings.__PropertyMask_UseFixCharacterRim : 0));
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06003AC1 RID: 15041 RVA: 0x0005588C File Offset: 0x00053A8C
		// (set) Token: 0x06003AC2 RID: 15042 RVA: 0x0005589C File Offset: 0x00053A9C
		public unsafe float FixCharacterRimAngleV
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FixCharacterRimAngleV);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FixCharacterRimAngleV) = value;
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06003AC3 RID: 15043 RVA: 0x000558AD File Offset: 0x00053AAD
		// (set) Token: 0x06003AC4 RID: 15044 RVA: 0x000558BD File Offset: 0x00053ABD
		public unsafe float FixCharacterRimAngleH
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FixCharacterRimAngleH);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FixCharacterRimAngleH) = value;
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06003AC5 RID: 15045 RVA: 0x000558CE File Offset: 0x00053ACE
		// (set) Token: 0x06003AC6 RID: 15046 RVA: 0x000558E7 File Offset: 0x00053AE7
		public unsafe bool UseCustomRim
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_UseCustomRim) & FPostProcessSettings.__PropertyMask_UseCustomRim) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_UseCustomRim) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_UseCustomRim) & ~FPostProcessSettings.__PropertyMask_UseCustomRim) | (value ? FPostProcessSettings.__PropertyMask_UseCustomRim : 0));
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x06003AC7 RID: 15047 RVA: 0x00055917 File Offset: 0x00053B17
		// (set) Token: 0x06003AC8 RID: 15048 RVA: 0x0005592B File Offset: 0x00053B2B
		public unsafe FLinearColor CustomRimColor_Stencil1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_CustomRimColor_Stencil1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_CustomRimColor_Stencil1) = value;
			}
		}

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x06003AC9 RID: 15049 RVA: 0x00055940 File Offset: 0x00053B40
		// (set) Token: 0x06003ACA RID: 15050 RVA: 0x00055950 File Offset: 0x00053B50
		public unsafe float FixCharacterRimAngleV_Stencil1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FixCharacterRimAngleV_Stencil1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FixCharacterRimAngleV_Stencil1) = value;
			}
		}

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x06003ACB RID: 15051 RVA: 0x00055961 File Offset: 0x00053B61
		// (set) Token: 0x06003ACC RID: 15052 RVA: 0x00055971 File Offset: 0x00053B71
		public unsafe float FixCharacterRimAngleH_Stencil1
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FixCharacterRimAngleH_Stencil1);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FixCharacterRimAngleH_Stencil1) = value;
			}
		}

		// Token: 0x170009D2 RID: 2514
		// (get) Token: 0x06003ACD RID: 15053 RVA: 0x00055982 File Offset: 0x00053B82
		// (set) Token: 0x06003ACE RID: 15054 RVA: 0x00055996 File Offset: 0x00053B96
		public unsafe FLinearColor CustomRimColor_Stencil2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_CustomRimColor_Stencil2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_CustomRimColor_Stencil2) = value;
			}
		}

		// Token: 0x170009D3 RID: 2515
		// (get) Token: 0x06003ACF RID: 15055 RVA: 0x000559AB File Offset: 0x00053BAB
		// (set) Token: 0x06003AD0 RID: 15056 RVA: 0x000559BB File Offset: 0x00053BBB
		public unsafe float FixCharacterRimAngleV_Stencil2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FixCharacterRimAngleV_Stencil2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FixCharacterRimAngleV_Stencil2) = value;
			}
		}

		// Token: 0x170009D4 RID: 2516
		// (get) Token: 0x06003AD1 RID: 15057 RVA: 0x000559CC File Offset: 0x00053BCC
		// (set) Token: 0x06003AD2 RID: 15058 RVA: 0x000559DC File Offset: 0x00053BDC
		public unsafe float FixCharacterRimAngleH_Stencil2
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FixCharacterRimAngleH_Stencil2);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FixCharacterRimAngleH_Stencil2) = value;
			}
		}

		// Token: 0x170009D5 RID: 2517
		// (get) Token: 0x06003AD3 RID: 15059 RVA: 0x000559ED File Offset: 0x00053BED
		// (set) Token: 0x06003AD4 RID: 15060 RVA: 0x00055A01 File Offset: 0x00053C01
		public unsafe FLinearColor CustomRimColor_Stencil3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_CustomRimColor_Stencil3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_CustomRimColor_Stencil3) = value;
			}
		}

		// Token: 0x170009D6 RID: 2518
		// (get) Token: 0x06003AD5 RID: 15061 RVA: 0x00055A16 File Offset: 0x00053C16
		// (set) Token: 0x06003AD6 RID: 15062 RVA: 0x00055A26 File Offset: 0x00053C26
		public unsafe float FixCharacterRimAngleV_Stencil3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FixCharacterRimAngleV_Stencil3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FixCharacterRimAngleV_Stencil3) = value;
			}
		}

		// Token: 0x170009D7 RID: 2519
		// (get) Token: 0x06003AD7 RID: 15063 RVA: 0x00055A37 File Offset: 0x00053C37
		// (set) Token: 0x06003AD8 RID: 15064 RVA: 0x00055A47 File Offset: 0x00053C47
		public unsafe float FixCharacterRimAngleH_Stencil3
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FixCharacterRimAngleH_Stencil3);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FixCharacterRimAngleH_Stencil3) = value;
			}
		}

		// Token: 0x170009D8 RID: 2520
		// (get) Token: 0x06003AD9 RID: 15065 RVA: 0x00055A58 File Offset: 0x00053C58
		// (set) Token: 0x06003ADA RID: 15066 RVA: 0x00055A68 File Offset: 0x00053C68
		public unsafe float KuroBloomIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroBloomIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroBloomIntensity) = value;
			}
		}

		// Token: 0x170009D9 RID: 2521
		// (get) Token: 0x06003ADB RID: 15067 RVA: 0x00055A79 File Offset: 0x00053C79
		// (set) Token: 0x06003ADC RID: 15068 RVA: 0x00055A89 File Offset: 0x00053C89
		public unsafe float KuroBloomThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroBloomThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroBloomThreshold) = value;
			}
		}

		// Token: 0x170009DA RID: 2522
		// (get) Token: 0x06003ADD RID: 15069 RVA: 0x00055A9A File Offset: 0x00053C9A
		// (set) Token: 0x06003ADE RID: 15070 RVA: 0x00055AB3 File Offset: 0x00053CB3
		public unsafe bool EnableSplitCharBloom
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EnableSplitCharBloom) & FPostProcessSettings.__PropertyMask_EnableSplitCharBloom) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EnableSplitCharBloom) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EnableSplitCharBloom) & ~FPostProcessSettings.__PropertyMask_EnableSplitCharBloom) | (value ? FPostProcessSettings.__PropertyMask_EnableSplitCharBloom : 0));
			}
		}

		// Token: 0x170009DB RID: 2523
		// (get) Token: 0x06003ADF RID: 15071 RVA: 0x00055AE3 File Offset: 0x00053CE3
		// (set) Token: 0x06003AE0 RID: 15072 RVA: 0x00055AF3 File Offset: 0x00053CF3
		public unsafe float KuroCharacterBloomIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroCharacterBloomIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroCharacterBloomIntensity) = value;
			}
		}

		// Token: 0x170009DC RID: 2524
		// (get) Token: 0x06003AE1 RID: 15073 RVA: 0x00055B04 File Offset: 0x00053D04
		// (set) Token: 0x06003AE2 RID: 15074 RVA: 0x00055B14 File Offset: 0x00053D14
		public unsafe float KuroCharacterBloomThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroCharacterBloomThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroCharacterBloomThreshold) = value;
			}
		}

		// Token: 0x170009DD RID: 2525
		// (get) Token: 0x06003AE3 RID: 15075 RVA: 0x00055B25 File Offset: 0x00053D25
		// (set) Token: 0x06003AE4 RID: 15076 RVA: 0x00055B3E File Offset: 0x00053D3E
		public unsafe bool EnableExtraCharBloomOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EnableExtraCharBloomOffset) & FPostProcessSettings.__PropertyMask_EnableExtraCharBloomOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EnableExtraCharBloomOffset) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EnableExtraCharBloomOffset) & ~FPostProcessSettings.__PropertyMask_EnableExtraCharBloomOffset) | (value ? FPostProcessSettings.__PropertyMask_EnableExtraCharBloomOffset : 0));
			}
		}

		// Token: 0x170009DE RID: 2526
		// (get) Token: 0x06003AE5 RID: 15077 RVA: 0x00055B6E File Offset: 0x00053D6E
		// (set) Token: 0x06003AE6 RID: 15078 RVA: 0x00055B7E File Offset: 0x00053D7E
		public unsafe float KuroExtraCharacterBloomIntensityOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroExtraCharacterBloomIntensityOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroExtraCharacterBloomIntensityOffset) = value;
			}
		}

		// Token: 0x170009DF RID: 2527
		// (get) Token: 0x06003AE7 RID: 15079 RVA: 0x00055B8F File Offset: 0x00053D8F
		// (set) Token: 0x06003AE8 RID: 15080 RVA: 0x00055B9F File Offset: 0x00053D9F
		public unsafe float KuroExtraCharacterBloomThresholdOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroExtraCharacterBloomThresholdOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroExtraCharacterBloomThresholdOffset) = value;
			}
		}

		// Token: 0x170009E0 RID: 2528
		// (get) Token: 0x06003AE9 RID: 15081 RVA: 0x00055BB0 File Offset: 0x00053DB0
		// (set) Token: 0x06003AEA RID: 15082 RVA: 0x00055BC0 File Offset: 0x00053DC0
		public unsafe float SunDirBloomIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SunDirBloomIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SunDirBloomIntensity) = value;
			}
		}

		// Token: 0x170009E1 RID: 2529
		// (get) Token: 0x06003AEB RID: 15083 RVA: 0x00055BD1 File Offset: 0x00053DD1
		// (set) Token: 0x06003AEC RID: 15084 RVA: 0x00055BE5 File Offset: 0x00053DE5
		public unsafe FVector4 KuroBloomCombineParameter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroBloomCombineParameter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroBloomCombineParameter) = value;
			}
		}

		// Token: 0x170009E2 RID: 2530
		// (get) Token: 0x06003AED RID: 15085 RVA: 0x00055BFA File Offset: 0x00053DFA
		// (set) Token: 0x06003AEE RID: 15086 RVA: 0x00055C0A File Offset: 0x00053E0A
		public unsafe float KuroBloomStreakIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroBloomStreakIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroBloomStreakIntensity) = value;
			}
		}

		// Token: 0x170009E3 RID: 2531
		// (get) Token: 0x06003AEF RID: 15087 RVA: 0x00055C1B File Offset: 0x00053E1B
		// (set) Token: 0x06003AF0 RID: 15088 RVA: 0x00055C2B File Offset: 0x00053E2B
		public unsafe float KuroBloomStreakThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroBloomStreakThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroBloomStreakThreshold) = value;
			}
		}

		// Token: 0x170009E4 RID: 2532
		// (get) Token: 0x06003AF1 RID: 15089 RVA: 0x00055C3C File Offset: 0x00053E3C
		// (set) Token: 0x06003AF2 RID: 15090 RVA: 0x00055C4C File Offset: 0x00053E4C
		public unsafe float TranslucentBloomStreakIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TranslucentBloomStreakIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TranslucentBloomStreakIntensity) = value;
			}
		}

		// Token: 0x170009E5 RID: 2533
		// (get) Token: 0x06003AF3 RID: 15091 RVA: 0x00055C5D File Offset: 0x00053E5D
		// (set) Token: 0x06003AF4 RID: 15092 RVA: 0x00055C6D File Offset: 0x00053E6D
		public unsafe float TranslucentBloomStreakThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TranslucentBloomStreakThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TranslucentBloomStreakThreshold) = value;
			}
		}

		// Token: 0x170009E6 RID: 2534
		// (get) Token: 0x06003AF5 RID: 15093 RVA: 0x00055C7E File Offset: 0x00053E7E
		// (set) Token: 0x06003AF6 RID: 15094 RVA: 0x00055C8E File Offset: 0x00053E8E
		public unsafe float KuroBloomStreakLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroBloomStreakLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroBloomStreakLength) = value;
			}
		}

		// Token: 0x170009E7 RID: 2535
		// (get) Token: 0x06003AF7 RID: 15095 RVA: 0x00055C9F File Offset: 0x00053E9F
		// (set) Token: 0x06003AF8 RID: 15096 RVA: 0x00055CAF File Offset: 0x00053EAF
		public unsafe float KuroBloomStreakMipLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroBloomStreakMipLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroBloomStreakMipLevel) = value;
			}
		}

		// Token: 0x170009E8 RID: 2536
		// (get) Token: 0x06003AF9 RID: 15097 RVA: 0x00055CC0 File Offset: 0x00053EC0
		// (set) Token: 0x06003AFA RID: 15098 RVA: 0x00055CD0 File Offset: 0x00053ED0
		public unsafe float KuroBloomStreakRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroBloomStreakRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroBloomStreakRatio) = value;
			}
		}

		// Token: 0x170009E9 RID: 2537
		// (get) Token: 0x06003AFB RID: 15099 RVA: 0x00055CE1 File Offset: 0x00053EE1
		// (set) Token: 0x06003AFC RID: 15100 RVA: 0x00055CF1 File Offset: 0x00053EF1
		public unsafe float KuroBloomStreakOrientation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroBloomStreakOrientation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroBloomStreakOrientation) = value;
			}
		}

		// Token: 0x170009EA RID: 2538
		// (get) Token: 0x06003AFD RID: 15101 RVA: 0x00055D02 File Offset: 0x00053F02
		// (set) Token: 0x06003AFE RID: 15102 RVA: 0x00055D12 File Offset: 0x00053F12
		public unsafe float BlackWhiteFlashIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BlackWhiteFlashIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BlackWhiteFlashIntensity) = value;
			}
		}

		// Token: 0x170009EB RID: 2539
		// (get) Token: 0x06003AFF RID: 15103 RVA: 0x00055D23 File Offset: 0x00053F23
		// (set) Token: 0x06003B00 RID: 15104 RVA: 0x00055D33 File Offset: 0x00053F33
		public unsafe float BlackWhiteFlashFactor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BlackWhiteFlashFactor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BlackWhiteFlashFactor) = value;
			}
		}

		// Token: 0x170009EC RID: 2540
		// (get) Token: 0x06003B01 RID: 15105 RVA: 0x00055D44 File Offset: 0x00053F44
		// (set) Token: 0x06003B02 RID: 15106 RVA: 0x00055D54 File Offset: 0x00053F54
		public unsafe float BlackWhiteFlashThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BlackWhiteFlashThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BlackWhiteFlashThreshold) = value;
			}
		}

		// Token: 0x170009ED RID: 2541
		// (get) Token: 0x06003B03 RID: 15107 RVA: 0x00055D65 File Offset: 0x00053F65
		// (set) Token: 0x06003B04 RID: 15108 RVA: 0x00055D79 File Offset: 0x00053F79
		public unsafe FLinearColor BlackWhiteFlashBlackAreaColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BlackWhiteFlashBlackAreaColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BlackWhiteFlashBlackAreaColor) = value;
			}
		}

		// Token: 0x170009EE RID: 2542
		// (get) Token: 0x06003B05 RID: 15109 RVA: 0x00055D8E File Offset: 0x00053F8E
		// (set) Token: 0x06003B06 RID: 15110 RVA: 0x00055DA2 File Offset: 0x00053FA2
		public unsafe FLinearColor BlackWhiteFlashWhiteAreaColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BlackWhiteFlashWhiteAreaColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BlackWhiteFlashWhiteAreaColor) = value;
			}
		}

		// Token: 0x170009EF RID: 2543
		// (get) Token: 0x06003B07 RID: 15111 RVA: 0x00055DB7 File Offset: 0x00053FB7
		// (set) Token: 0x06003B08 RID: 15112 RVA: 0x00055DC7 File Offset: 0x00053FC7
		public unsafe float KuroRadialBlurIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroRadialBlurIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroRadialBlurIntensity) = value;
			}
		}

		// Token: 0x170009F0 RID: 2544
		// (get) Token: 0x06003B09 RID: 15113 RVA: 0x00055DD8 File Offset: 0x00053FD8
		// (set) Token: 0x06003B0A RID: 15114 RVA: 0x00055DEC File Offset: 0x00053FEC
		public unsafe FVector2D KuroRadialBlurCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroRadialBlurCenter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroRadialBlurCenter) = value;
			}
		}

		// Token: 0x170009F1 RID: 2545
		// (get) Token: 0x06003B0B RID: 15115 RVA: 0x00055E01 File Offset: 0x00054001
		// (set) Token: 0x06003B0C RID: 15116 RVA: 0x00055E11 File Offset: 0x00054011
		public unsafe bool UseClampRadialBlurCenter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_UseClampRadialBlurCenter) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_UseClampRadialBlurCenter) = (value ? 1 : 0);
			}
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x06003B0D RID: 15117 RVA: 0x00055E22 File Offset: 0x00054022
		// (set) Token: 0x06003B0E RID: 15118 RVA: 0x00055E32 File Offset: 0x00054032
		public unsafe float KuroRadialBlurRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroRadialBlurRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroRadialBlurRadius) = value;
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x06003B0F RID: 15119 RVA: 0x00055E43 File Offset: 0x00054043
		// (set) Token: 0x06003B10 RID: 15120 RVA: 0x00055E53 File Offset: 0x00054053
		public unsafe float KuroRadialBlurHardness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroRadialBlurHardness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroRadialBlurHardness) = value;
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x06003B11 RID: 15121 RVA: 0x00055E64 File Offset: 0x00054064
		// (set) Token: 0x06003B12 RID: 15122 RVA: 0x00055E74 File Offset: 0x00054074
		public unsafe int KuroRadialBlurPassNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroRadialBlurPassNumber);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroRadialBlurPassNumber) = value;
			}
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x06003B13 RID: 15123 RVA: 0x00055E85 File Offset: 0x00054085
		// (set) Token: 0x06003B14 RID: 15124 RVA: 0x00055E95 File Offset: 0x00054095
		public unsafe int KuroRadialBlurSampleNumber
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroRadialBlurSampleNumber);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroRadialBlurSampleNumber) = value;
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x06003B15 RID: 15125 RVA: 0x00055EA6 File Offset: 0x000540A6
		// (set) Token: 0x06003B16 RID: 15126 RVA: 0x00055EBA File Offset: 0x000540BA
		public unsafe UTexture KuroRadialBlurMask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_KuroRadialBlurMask);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_KuroRadialBlurMask, value);
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x06003B17 RID: 15127 RVA: 0x00055ECF File Offset: 0x000540CF
		// (set) Token: 0x06003B18 RID: 15128 RVA: 0x00055EE3 File Offset: 0x000540E3
		public unsafe FVector2D KuroRadialBlurMaskScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroRadialBlurMaskScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroRadialBlurMaskScale) = value;
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x06003B19 RID: 15129 RVA: 0x00055EF8 File Offset: 0x000540F8
		// (set) Token: 0x06003B1A RID: 15130 RVA: 0x00055F0C File Offset: 0x0005410C
		public unsafe FVector2D KuroRadialBlurMaskOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroRadialBlurMaskOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroRadialBlurMaskOffset) = value;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x06003B1B RID: 15131 RVA: 0x00055F21 File Offset: 0x00054121
		// (set) Token: 0x06003B1C RID: 15132 RVA: 0x00055F31 File Offset: 0x00054131
		public unsafe float ScreenSoftIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenSoftIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenSoftIntensity) = value;
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x06003B1D RID: 15133 RVA: 0x00055F42 File Offset: 0x00054142
		// (set) Token: 0x06003B1E RID: 15134 RVA: 0x00055F52 File Offset: 0x00054152
		public unsafe float ScreenSoftThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenSoftThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenSoftThreshold) = value;
			}
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x06003B1F RID: 15135 RVA: 0x00055F63 File Offset: 0x00054163
		// (set) Token: 0x06003B20 RID: 15136 RVA: 0x00055F73 File Offset: 0x00054173
		public unsafe float ScreenSoftDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenSoftDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenSoftDistance) = value;
			}
		}

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x06003B21 RID: 15137 RVA: 0x00055F84 File Offset: 0x00054184
		// (set) Token: 0x06003B22 RID: 15138 RVA: 0x00055F94 File Offset: 0x00054194
		public unsafe float ScreenSoftSkyBloomCompensation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenSoftSkyBloomCompensation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenSoftSkyBloomCompensation) = value;
			}
		}

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x06003B23 RID: 15139 RVA: 0x00055FA5 File Offset: 0x000541A5
		// (set) Token: 0x06003B24 RID: 15140 RVA: 0x00055FB5 File Offset: 0x000541B5
		public unsafe float ScreenSoftRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenSoftRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenSoftRange) = value;
			}
		}

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x06003B25 RID: 15141 RVA: 0x00055FC6 File Offset: 0x000541C6
		// (set) Token: 0x06003B26 RID: 15142 RVA: 0x00055FD6 File Offset: 0x000541D6
		public unsafe float ScreenSoftOverflowDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenSoftOverflowDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenSoftOverflowDistance) = value;
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x06003B27 RID: 15143 RVA: 0x00055FE7 File Offset: 0x000541E7
		// (set) Token: 0x06003B28 RID: 15144 RVA: 0x00055FF7 File Offset: 0x000541F7
		public unsafe float ScreenSoftSunExposure
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenSoftSunExposure);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenSoftSunExposure) = value;
			}
		}

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x06003B29 RID: 15145 RVA: 0x00056008 File Offset: 0x00054208
		// (set) Token: 0x06003B2A RID: 15146 RVA: 0x00056018 File Offset: 0x00054218
		public unsafe int ScreenSoftHighQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenSoftHighQuality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenSoftHighQuality) = value;
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x06003B2B RID: 15147 RVA: 0x00056029 File Offset: 0x00054229
		// (set) Token: 0x06003B2C RID: 15148 RVA: 0x00056039 File Offset: 0x00054239
		public unsafe float MobileScreenSoftIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MobileScreenSoftIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MobileScreenSoftIntensity) = value;
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x06003B2D RID: 15149 RVA: 0x0005604A File Offset: 0x0005424A
		// (set) Token: 0x06003B2E RID: 15150 RVA: 0x0005605A File Offset: 0x0005425A
		public unsafe float MobileScreenSoftThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MobileScreenSoftThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MobileScreenSoftThreshold) = value;
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x06003B2F RID: 15151 RVA: 0x0005606B File Offset: 0x0005426B
		// (set) Token: 0x06003B30 RID: 15152 RVA: 0x0005607B File Offset: 0x0005427B
		public unsafe float MobileScreenSoftDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MobileScreenSoftDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MobileScreenSoftDistance) = value;
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x06003B31 RID: 15153 RVA: 0x0005608C File Offset: 0x0005428C
		// (set) Token: 0x06003B32 RID: 15154 RVA: 0x000560A0 File Offset: 0x000542A0
		public unsafe UTexture ScreenLeakTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_ScreenLeakTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_ScreenLeakTexture, value);
			}
		}

		// Token: 0x17000A05 RID: 2565
		// (get) Token: 0x06003B33 RID: 15155 RVA: 0x000560B5 File Offset: 0x000542B5
		// (set) Token: 0x06003B34 RID: 15156 RVA: 0x000560C5 File Offset: 0x000542C5
		public unsafe float ScreenLeakTextureIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenLeakTextureIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenLeakTextureIntensity) = value;
			}
		}

		// Token: 0x17000A06 RID: 2566
		// (get) Token: 0x06003B35 RID: 15157 RVA: 0x000560D6 File Offset: 0x000542D6
		// (set) Token: 0x06003B36 RID: 15158 RVA: 0x000560E6 File Offset: 0x000542E6
		public unsafe float FFTIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTIntensity) = value;
			}
		}

		// Token: 0x17000A07 RID: 2567
		// (get) Token: 0x06003B37 RID: 15159 RVA: 0x000560F7 File Offset: 0x000542F7
		// (set) Token: 0x06003B38 RID: 15160 RVA: 0x00056107 File Offset: 0x00054307
		public unsafe float FFTThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTThreshold) = value;
			}
		}

		// Token: 0x17000A08 RID: 2568
		// (get) Token: 0x06003B39 RID: 15161 RVA: 0x00056118 File Offset: 0x00054318
		// (set) Token: 0x06003B3A RID: 15162 RVA: 0x0005612C File Offset: 0x0005432C
		public unsafe UTexture2D FFTTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_FFTTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_FFTTexture, value);
			}
		}

		// Token: 0x17000A09 RID: 2569
		// (get) Token: 0x06003B3B RID: 15163 RVA: 0x00056141 File Offset: 0x00054341
		// (set) Token: 0x06003B3C RID: 15164 RVA: 0x00056151 File Offset: 0x00054351
		public unsafe float FFTScatterDispersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTScatterDispersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTScatterDispersion) = value;
			}
		}

		// Token: 0x17000A0A RID: 2570
		// (get) Token: 0x06003B3D RID: 15165 RVA: 0x00056162 File Offset: 0x00054362
		// (set) Token: 0x06003B3E RID: 15166 RVA: 0x00056172 File Offset: 0x00054372
		public unsafe float FFTSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTSize) = value;
			}
		}

		// Token: 0x17000A0B RID: 2571
		// (get) Token: 0x06003B3F RID: 15167 RVA: 0x00056183 File Offset: 0x00054383
		// (set) Token: 0x06003B40 RID: 15168 RVA: 0x00056193 File Offset: 0x00054393
		public unsafe float FFTPreFilterMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTPreFilterMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTPreFilterMin) = value;
			}
		}

		// Token: 0x17000A0C RID: 2572
		// (get) Token: 0x06003B41 RID: 15169 RVA: 0x000561A4 File Offset: 0x000543A4
		// (set) Token: 0x06003B42 RID: 15170 RVA: 0x000561B4 File Offset: 0x000543B4
		public unsafe float FFTPreFilterMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTPreFilterMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTPreFilterMax) = value;
			}
		}

		// Token: 0x17000A0D RID: 2573
		// (get) Token: 0x06003B43 RID: 15171 RVA: 0x000561C5 File Offset: 0x000543C5
		// (set) Token: 0x06003B44 RID: 15172 RVA: 0x000561D5 File Offset: 0x000543D5
		public unsafe float FFTPreFilterMult
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTPreFilterMult);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTPreFilterMult) = value;
			}
		}

		// Token: 0x17000A0E RID: 2574
		// (get) Token: 0x06003B45 RID: 15173 RVA: 0x000561E6 File Offset: 0x000543E6
		// (set) Token: 0x06003B46 RID: 15174 RVA: 0x000561F6 File Offset: 0x000543F6
		public unsafe float FFTBufferScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTBufferScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTBufferScale) = value;
			}
		}

		// Token: 0x17000A0F RID: 2575
		// (get) Token: 0x06003B47 RID: 15175 RVA: 0x00056207 File Offset: 0x00054407
		// (set) Token: 0x06003B48 RID: 15176 RVA: 0x00056217 File Offset: 0x00054417
		public unsafe float FFTDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTDistance) = value;
			}
		}

		// Token: 0x17000A10 RID: 2576
		// (get) Token: 0x06003B49 RID: 15177 RVA: 0x00056228 File Offset: 0x00054428
		// (set) Token: 0x06003B4A RID: 15178 RVA: 0x00056241 File Offset: 0x00054441
		public unsafe bool FFTHidenSky
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTHidenSky) & FPostProcessSettings.__PropertyMask_FFTHidenSky) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTHidenSky) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTHidenSky) & ~FPostProcessSettings.__PropertyMask_FFTHidenSky) | (value ? FPostProcessSettings.__PropertyMask_FFTHidenSky : 0));
			}
		}

		// Token: 0x17000A11 RID: 2577
		// (get) Token: 0x06003B4B RID: 15179 RVA: 0x00056271 File Offset: 0x00054471
		// (set) Token: 0x06003B4C RID: 15180 RVA: 0x0005628A File Offset: 0x0005448A
		public unsafe bool FFTHidenTranslucent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTHidenTranslucent) & FPostProcessSettings.__PropertyMask_FFTHidenTranslucent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTHidenTranslucent) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTHidenTranslucent) & ~FPostProcessSettings.__PropertyMask_FFTHidenTranslucent) | (value ? FPostProcessSettings.__PropertyMask_FFTHidenTranslucent : 0));
			}
		}

		// Token: 0x17000A12 RID: 2578
		// (get) Token: 0x06003B4D RID: 15181 RVA: 0x000562BA File Offset: 0x000544BA
		// (set) Token: 0x06003B4E RID: 15182 RVA: 0x000562D3 File Offset: 0x000544D3
		public unsafe bool FFTBeforeTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTBeforeTranslucency) & FPostProcessSettings.__PropertyMask_FFTBeforeTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTBeforeTranslucency) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_FFTBeforeTranslucency) & ~FPostProcessSettings.__PropertyMask_FFTBeforeTranslucency) | (value ? FPostProcessSettings.__PropertyMask_FFTBeforeTranslucency : 0));
			}
		}

		// Token: 0x17000A13 RID: 2579
		// (get) Token: 0x06003B4F RID: 15183 RVA: 0x00056303 File Offset: 0x00054503
		// (set) Token: 0x06003B50 RID: 15184 RVA: 0x00056313 File Offset: 0x00054513
		public unsafe float ToonFFTIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ToonFFTIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ToonFFTIntensity) = value;
			}
		}

		// Token: 0x17000A14 RID: 2580
		// (get) Token: 0x06003B51 RID: 15185 RVA: 0x00056324 File Offset: 0x00054524
		// (set) Token: 0x06003B52 RID: 15186 RVA: 0x00056334 File Offset: 0x00054534
		public unsafe float ToonFFTThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ToonFFTThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ToonFFTThreshold) = value;
			}
		}

		// Token: 0x17000A15 RID: 2581
		// (get) Token: 0x06003B53 RID: 15187 RVA: 0x00056345 File Offset: 0x00054545
		// (set) Token: 0x06003B54 RID: 15188 RVA: 0x00056359 File Offset: 0x00054559
		public unsafe UTexture2D ToonFFTTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_ToonFFTTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_ToonFFTTexture, value);
			}
		}

		// Token: 0x17000A16 RID: 2582
		// (get) Token: 0x06003B55 RID: 15189 RVA: 0x0005636E File Offset: 0x0005456E
		// (set) Token: 0x06003B56 RID: 15190 RVA: 0x0005637E File Offset: 0x0005457E
		public unsafe float ToonFFTScatterDispersion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ToonFFTScatterDispersion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ToonFFTScatterDispersion) = value;
			}
		}

		// Token: 0x17000A17 RID: 2583
		// (get) Token: 0x06003B57 RID: 15191 RVA: 0x0005638F File Offset: 0x0005458F
		// (set) Token: 0x06003B58 RID: 15192 RVA: 0x0005639F File Offset: 0x0005459F
		public unsafe float ToonFFTSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ToonFFTSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ToonFFTSize) = value;
			}
		}

		// Token: 0x17000A18 RID: 2584
		// (get) Token: 0x06003B59 RID: 15193 RVA: 0x000563B0 File Offset: 0x000545B0
		// (set) Token: 0x06003B5A RID: 15194 RVA: 0x000563C0 File Offset: 0x000545C0
		public unsafe float LightFadeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LightFadeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LightFadeScale) = value;
			}
		}

		// Token: 0x17000A19 RID: 2585
		// (get) Token: 0x06003B5B RID: 15195 RVA: 0x000563D1 File Offset: 0x000545D1
		// (set) Token: 0x06003B5C RID: 15196 RVA: 0x000563E1 File Offset: 0x000545E1
		public unsafe float KuroDataDistortionNoiseIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroDataDistortionNoiseIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroDataDistortionNoiseIntensity) = value;
			}
		}

		// Token: 0x17000A1A RID: 2586
		// (get) Token: 0x06003B5D RID: 15197 RVA: 0x000563F2 File Offset: 0x000545F2
		// (set) Token: 0x06003B5E RID: 15198 RVA: 0x00056406 File Offset: 0x00054606
		public unsafe UTexture KuroDataDistortionNoiseTexture
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_KuroDataDistortionNoiseTexture);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_KuroDataDistortionNoiseTexture, value);
			}
		}

		// Token: 0x17000A1B RID: 2587
		// (get) Token: 0x06003B5F RID: 15199 RVA: 0x0005641B File Offset: 0x0005461B
		// (set) Token: 0x06003B60 RID: 15200 RVA: 0x0005642F File Offset: 0x0005462F
		public unsafe FVector4 KuroDataDistortionNoiseTextureUVScaleBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroDataDistortionNoiseTextureUVScaleBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroDataDistortionNoiseTextureUVScaleBias) = value;
			}
		}

		// Token: 0x17000A1C RID: 2588
		// (get) Token: 0x06003B61 RID: 15201 RVA: 0x00056444 File Offset: 0x00054644
		// (set) Token: 0x06003B62 RID: 15202 RVA: 0x00056454 File Offset: 0x00054654
		public unsafe float KuroDataDistortionNoiseSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroDataDistortionNoiseSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroDataDistortionNoiseSize) = value;
			}
		}

		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x06003B63 RID: 15203 RVA: 0x00056465 File Offset: 0x00054665
		// (set) Token: 0x06003B64 RID: 15204 RVA: 0x00056479 File Offset: 0x00054679
		public unsafe FVector2D KuroDataDistortionNoiseBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroDataDistortionNoiseBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroDataDistortionNoiseBias) = value;
			}
		}

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x06003B65 RID: 15205 RVA: 0x0005648E File Offset: 0x0005468E
		// (set) Token: 0x06003B66 RID: 15206 RVA: 0x0005649E File Offset: 0x0005469E
		public unsafe float KuroDataDistortionSignalIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroDataDistortionSignalIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroDataDistortionSignalIntensity) = value;
			}
		}

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x06003B67 RID: 15207 RVA: 0x000564AF File Offset: 0x000546AF
		// (set) Token: 0x06003B68 RID: 15208 RVA: 0x000564BF File Offset: 0x000546BF
		public unsafe float KuroDataDistortionRandomColorSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroDataDistortionRandomColorSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroDataDistortionRandomColorSize) = value;
			}
		}

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x06003B69 RID: 15209 RVA: 0x000564D0 File Offset: 0x000546D0
		// (set) Token: 0x06003B6A RID: 15210 RVA: 0x000564E4 File Offset: 0x000546E4
		public unsafe FVector4 KuroDataDistortionSinWaveParameters
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroDataDistortionSinWaveParameters);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroDataDistortionSinWaveParameters) = value;
			}
		}

		// Token: 0x17000A21 RID: 2593
		// (get) Token: 0x06003B6B RID: 15211 RVA: 0x000564F9 File Offset: 0x000546F9
		// (set) Token: 0x06003B6C RID: 15212 RVA: 0x0005650D File Offset: 0x0005470D
		public unsafe FLinearColor KuroDataDistortionColorTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroDataDistortionColorTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroDataDistortionColorTint) = value;
			}
		}

		// Token: 0x17000A22 RID: 2594
		// (get) Token: 0x06003B6D RID: 15213 RVA: 0x00056522 File Offset: 0x00054722
		// (set) Token: 0x06003B6E RID: 15214 RVA: 0x00056532 File Offset: 0x00054732
		public unsafe float BloomIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BloomIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BloomIntensity) = value;
			}
		}

		// Token: 0x17000A23 RID: 2595
		// (get) Token: 0x06003B6F RID: 15215 RVA: 0x00056543 File Offset: 0x00054743
		// (set) Token: 0x06003B70 RID: 15216 RVA: 0x00056553 File Offset: 0x00054753
		public unsafe float BloomThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BloomThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BloomThreshold) = value;
			}
		}

		// Token: 0x17000A24 RID: 2596
		// (get) Token: 0x06003B71 RID: 15217 RVA: 0x00056564 File Offset: 0x00054764
		// (set) Token: 0x06003B72 RID: 15218 RVA: 0x00056574 File Offset: 0x00054774
		public unsafe float BloomSizeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BloomSizeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BloomSizeScale) = value;
			}
		}

		// Token: 0x17000A25 RID: 2597
		// (get) Token: 0x06003B73 RID: 15219 RVA: 0x00056585 File Offset: 0x00054785
		// (set) Token: 0x06003B74 RID: 15220 RVA: 0x00056595 File Offset: 0x00054795
		public unsafe float Bloom1Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom1Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom1Size) = value;
			}
		}

		// Token: 0x17000A26 RID: 2598
		// (get) Token: 0x06003B75 RID: 15221 RVA: 0x000565A6 File Offset: 0x000547A6
		// (set) Token: 0x06003B76 RID: 15222 RVA: 0x000565B6 File Offset: 0x000547B6
		public unsafe float Bloom2Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom2Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom2Size) = value;
			}
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x06003B77 RID: 15223 RVA: 0x000565C7 File Offset: 0x000547C7
		// (set) Token: 0x06003B78 RID: 15224 RVA: 0x000565D7 File Offset: 0x000547D7
		public unsafe float Bloom3Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom3Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom3Size) = value;
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x06003B79 RID: 15225 RVA: 0x000565E8 File Offset: 0x000547E8
		// (set) Token: 0x06003B7A RID: 15226 RVA: 0x000565F8 File Offset: 0x000547F8
		public unsafe float Bloom4Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom4Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom4Size) = value;
			}
		}

		// Token: 0x17000A29 RID: 2601
		// (get) Token: 0x06003B7B RID: 15227 RVA: 0x00056609 File Offset: 0x00054809
		// (set) Token: 0x06003B7C RID: 15228 RVA: 0x00056619 File Offset: 0x00054819
		public unsafe float Bloom5Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom5Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom5Size) = value;
			}
		}

		// Token: 0x17000A2A RID: 2602
		// (get) Token: 0x06003B7D RID: 15229 RVA: 0x0005662A File Offset: 0x0005482A
		// (set) Token: 0x06003B7E RID: 15230 RVA: 0x0005663A File Offset: 0x0005483A
		public unsafe float Bloom6Size
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom6Size);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom6Size) = value;
			}
		}

		// Token: 0x17000A2B RID: 2603
		// (get) Token: 0x06003B7F RID: 15231 RVA: 0x0005664B File Offset: 0x0005484B
		// (set) Token: 0x06003B80 RID: 15232 RVA: 0x0005665F File Offset: 0x0005485F
		public unsafe FLinearColor Bloom1Tint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom1Tint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom1Tint) = value;
			}
		}

		// Token: 0x17000A2C RID: 2604
		// (get) Token: 0x06003B81 RID: 15233 RVA: 0x00056674 File Offset: 0x00054874
		// (set) Token: 0x06003B82 RID: 15234 RVA: 0x00056688 File Offset: 0x00054888
		public unsafe FLinearColor Bloom2Tint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom2Tint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom2Tint) = value;
			}
		}

		// Token: 0x17000A2D RID: 2605
		// (get) Token: 0x06003B83 RID: 15235 RVA: 0x0005669D File Offset: 0x0005489D
		// (set) Token: 0x06003B84 RID: 15236 RVA: 0x000566B1 File Offset: 0x000548B1
		public unsafe FLinearColor Bloom3Tint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom3Tint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom3Tint) = value;
			}
		}

		// Token: 0x17000A2E RID: 2606
		// (get) Token: 0x06003B85 RID: 15237 RVA: 0x000566C6 File Offset: 0x000548C6
		// (set) Token: 0x06003B86 RID: 15238 RVA: 0x000566DA File Offset: 0x000548DA
		public unsafe FLinearColor Bloom4Tint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom4Tint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom4Tint) = value;
			}
		}

		// Token: 0x17000A2F RID: 2607
		// (get) Token: 0x06003B87 RID: 15239 RVA: 0x000566EF File Offset: 0x000548EF
		// (set) Token: 0x06003B88 RID: 15240 RVA: 0x00056703 File Offset: 0x00054903
		public unsafe FLinearColor Bloom5Tint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom5Tint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom5Tint) = value;
			}
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06003B89 RID: 15241 RVA: 0x00056718 File Offset: 0x00054918
		// (set) Token: 0x06003B8A RID: 15242 RVA: 0x0005672C File Offset: 0x0005492C
		public unsafe FLinearColor Bloom6Tint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom6Tint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_Bloom6Tint) = value;
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06003B8B RID: 15243 RVA: 0x00056741 File Offset: 0x00054941
		// (set) Token: 0x06003B8C RID: 15244 RVA: 0x00056755 File Offset: 0x00054955
		public unsafe UTexture BloomDirtMask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_BloomDirtMask);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_BloomDirtMask, value);
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06003B8D RID: 15245 RVA: 0x0005676A File Offset: 0x0005496A
		// (set) Token: 0x06003B8E RID: 15246 RVA: 0x0005677A File Offset: 0x0005497A
		public unsafe float BloomDirtMaskIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BloomDirtMaskIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BloomDirtMaskIntensity) = value;
			}
		}

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06003B8F RID: 15247 RVA: 0x0005678B File Offset: 0x0005498B
		// (set) Token: 0x06003B90 RID: 15248 RVA: 0x0005679F File Offset: 0x0005499F
		public unsafe FLinearColor BloomDirtMaskTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BloomDirtMaskTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BloomDirtMaskTint) = value;
			}
		}

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06003B91 RID: 15249 RVA: 0x000567B4 File Offset: 0x000549B4
		// (set) Token: 0x06003B92 RID: 15250 RVA: 0x000567CD File Offset: 0x000549CD
		public unsafe bool bMegaLights
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bMegaLights) & FPostProcessSettings.__PropertyMask_bMegaLights) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bMegaLights) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bMegaLights) & ~FPostProcessSettings.__PropertyMask_bMegaLights) | (value ? FPostProcessSettings.__PropertyMask_bMegaLights : 0));
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06003B93 RID: 15251 RVA: 0x000567FD File Offset: 0x000549FD
		// (set) Token: 0x06003B94 RID: 15252 RVA: 0x00056811 File Offset: 0x00054A11
		public unsafe FLinearColor AmbientCubemapTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientCubemapTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientCubemapTint) = value;
			}
		}

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06003B95 RID: 15253 RVA: 0x00056826 File Offset: 0x00054A26
		// (set) Token: 0x06003B96 RID: 15254 RVA: 0x00056836 File Offset: 0x00054A36
		public unsafe float AmbientCubemapIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientCubemapIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientCubemapIntensity) = value;
			}
		}

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06003B97 RID: 15255 RVA: 0x00056847 File Offset: 0x00054A47
		// (set) Token: 0x06003B98 RID: 15256 RVA: 0x0005685B File Offset: 0x00054A5B
		public unsafe UTextureCube AmbientCubemap
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTextureCube>(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_AmbientCubemap);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_AmbientCubemap, value);
			}
		}

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06003B99 RID: 15257 RVA: 0x00056870 File Offset: 0x00054A70
		// (set) Token: 0x06003B9A RID: 15258 RVA: 0x00056880 File Offset: 0x00054A80
		public unsafe float CameraShutterSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_CameraShutterSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_CameraShutterSpeed) = value;
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06003B9B RID: 15259 RVA: 0x00056891 File Offset: 0x00054A91
		// (set) Token: 0x06003B9C RID: 15260 RVA: 0x000568A1 File Offset: 0x00054AA1
		public unsafe float CameraISO
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_CameraISO);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_CameraISO) = value;
			}
		}

		// Token: 0x17000A3A RID: 2618
		// (get) Token: 0x06003B9D RID: 15261 RVA: 0x000568B2 File Offset: 0x00054AB2
		// (set) Token: 0x06003B9E RID: 15262 RVA: 0x000568C2 File Offset: 0x00054AC2
		public unsafe float DepthOfFieldFstop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldFstop);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldFstop) = value;
			}
		}

		// Token: 0x17000A3B RID: 2619
		// (get) Token: 0x06003B9F RID: 15263 RVA: 0x000568D3 File Offset: 0x00054AD3
		// (set) Token: 0x06003BA0 RID: 15264 RVA: 0x000568E3 File Offset: 0x00054AE3
		public unsafe float DepthOfFieldMinFstop
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldMinFstop);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldMinFstop) = value;
			}
		}

		// Token: 0x17000A3C RID: 2620
		// (get) Token: 0x06003BA1 RID: 15265 RVA: 0x000568F4 File Offset: 0x00054AF4
		// (set) Token: 0x06003BA2 RID: 15266 RVA: 0x00056904 File Offset: 0x00054B04
		public unsafe int DepthOfFieldBladeCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldBladeCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldBladeCount) = value;
			}
		}

		// Token: 0x17000A3D RID: 2621
		// (get) Token: 0x06003BA3 RID: 15267 RVA: 0x00056915 File Offset: 0x00054B15
		// (set) Token: 0x06003BA4 RID: 15268 RVA: 0x0005692E File Offset: 0x00054B2E
		public unsafe bool bUseForegroundBlur
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bUseForegroundBlur) & FPostProcessSettings.__PropertyMask_bUseForegroundBlur) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bUseForegroundBlur) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bUseForegroundBlur) & ~FPostProcessSettings.__PropertyMask_bUseForegroundBlur) | (value ? FPostProcessSettings.__PropertyMask_bUseForegroundBlur : 0));
			}
		}

		// Token: 0x17000A3E RID: 2622
		// (get) Token: 0x06003BA5 RID: 15269 RVA: 0x0005695E File Offset: 0x00054B5E
		// (set) Token: 0x06003BA6 RID: 15270 RVA: 0x0005696E File Offset: 0x00054B6E
		public unsafe float AutoExposureBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AutoExposureBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AutoExposureBias) = value;
			}
		}

		// Token: 0x17000A3F RID: 2623
		// (get) Token: 0x06003BA7 RID: 15271 RVA: 0x0005697F File Offset: 0x00054B7F
		// (set) Token: 0x06003BA8 RID: 15272 RVA: 0x0005698F File Offset: 0x00054B8F
		public unsafe float AutoExposureBiasBackup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AutoExposureBiasBackup);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AutoExposureBiasBackup) = value;
			}
		}

		// Token: 0x17000A40 RID: 2624
		// (get) Token: 0x06003BA9 RID: 15273 RVA: 0x000569A0 File Offset: 0x00054BA0
		// (set) Token: 0x06003BAA RID: 15274 RVA: 0x000569B9 File Offset: 0x00054BB9
		public unsafe bool bOverride_AutoExposureBiasBackup
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureBiasBackup) & FPostProcessSettings.__PropertyMask_bOverride_AutoExposureBiasBackup) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureBiasBackup) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bOverride_AutoExposureBiasBackup) & ~FPostProcessSettings.__PropertyMask_bOverride_AutoExposureBiasBackup) | (value ? FPostProcessSettings.__PropertyMask_bOverride_AutoExposureBiasBackup : 0));
			}
		}

		// Token: 0x17000A41 RID: 2625
		// (get) Token: 0x06003BAB RID: 15275 RVA: 0x000569E9 File Offset: 0x00054BE9
		// (set) Token: 0x06003BAC RID: 15276 RVA: 0x00056A02 File Offset: 0x00054C02
		public unsafe bool AutoExposureApplyPhysicalCameraExposure
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AutoExposureApplyPhysicalCameraExposure) & FPostProcessSettings.__PropertyMask_AutoExposureApplyPhysicalCameraExposure) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AutoExposureApplyPhysicalCameraExposure) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AutoExposureApplyPhysicalCameraExposure) & ~FPostProcessSettings.__PropertyMask_AutoExposureApplyPhysicalCameraExposure) | (value ? FPostProcessSettings.__PropertyMask_AutoExposureApplyPhysicalCameraExposure : 0));
			}
		}

		// Token: 0x17000A42 RID: 2626
		// (get) Token: 0x06003BAD RID: 15277 RVA: 0x00056A32 File Offset: 0x00054C32
		// (set) Token: 0x06003BAE RID: 15278 RVA: 0x00056A46 File Offset: 0x00054C46
		public unsafe UCurveFloat AutoExposureBiasCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_AutoExposureBiasCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_AutoExposureBiasCurve, value);
			}
		}

		// Token: 0x17000A43 RID: 2627
		// (get) Token: 0x06003BAF RID: 15279 RVA: 0x00056A5B File Offset: 0x00054C5B
		// (set) Token: 0x06003BB0 RID: 15280 RVA: 0x00056A6F File Offset: 0x00054C6F
		public unsafe UTexture AutoExposureMeterMask
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_AutoExposureMeterMask);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_AutoExposureMeterMask, value);
			}
		}

		// Token: 0x17000A44 RID: 2628
		// (get) Token: 0x06003BB1 RID: 15281 RVA: 0x00056A84 File Offset: 0x00054C84
		// (set) Token: 0x06003BB2 RID: 15282 RVA: 0x00056A94 File Offset: 0x00054C94
		public unsafe float AutoExposureLowPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AutoExposureLowPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AutoExposureLowPercent) = value;
			}
		}

		// Token: 0x17000A45 RID: 2629
		// (get) Token: 0x06003BB3 RID: 15283 RVA: 0x00056AA5 File Offset: 0x00054CA5
		// (set) Token: 0x06003BB4 RID: 15284 RVA: 0x00056AB5 File Offset: 0x00054CB5
		public unsafe float AutoExposureHighPercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AutoExposureHighPercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AutoExposureHighPercent) = value;
			}
		}

		// Token: 0x17000A46 RID: 2630
		// (get) Token: 0x06003BB5 RID: 15285 RVA: 0x00056AC6 File Offset: 0x00054CC6
		// (set) Token: 0x06003BB6 RID: 15286 RVA: 0x00056AD6 File Offset: 0x00054CD6
		public unsafe float AutoExposureMinBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AutoExposureMinBrightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AutoExposureMinBrightness) = value;
			}
		}

		// Token: 0x17000A47 RID: 2631
		// (get) Token: 0x06003BB7 RID: 15287 RVA: 0x00056AE7 File Offset: 0x00054CE7
		// (set) Token: 0x06003BB8 RID: 15288 RVA: 0x00056AF7 File Offset: 0x00054CF7
		public unsafe float AutoExposureMaxBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AutoExposureMaxBrightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AutoExposureMaxBrightness) = value;
			}
		}

		// Token: 0x17000A48 RID: 2632
		// (get) Token: 0x06003BB9 RID: 15289 RVA: 0x00056B08 File Offset: 0x00054D08
		// (set) Token: 0x06003BBA RID: 15290 RVA: 0x00056B18 File Offset: 0x00054D18
		public unsafe float AutoExposureSpeedUp
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AutoExposureSpeedUp);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AutoExposureSpeedUp) = value;
			}
		}

		// Token: 0x17000A49 RID: 2633
		// (get) Token: 0x06003BBB RID: 15291 RVA: 0x00056B29 File Offset: 0x00054D29
		// (set) Token: 0x06003BBC RID: 15292 RVA: 0x00056B39 File Offset: 0x00054D39
		public unsafe float AutoExposureSpeedDown
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AutoExposureSpeedDown);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AutoExposureSpeedDown) = value;
			}
		}

		// Token: 0x17000A4A RID: 2634
		// (get) Token: 0x06003BBD RID: 15293 RVA: 0x00056B4A File Offset: 0x00054D4A
		// (set) Token: 0x06003BBE RID: 15294 RVA: 0x00056B5A File Offset: 0x00054D5A
		public unsafe float HistogramLogMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_HistogramLogMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_HistogramLogMin) = value;
			}
		}

		// Token: 0x17000A4B RID: 2635
		// (get) Token: 0x06003BBF RID: 15295 RVA: 0x00056B6B File Offset: 0x00054D6B
		// (set) Token: 0x06003BC0 RID: 15296 RVA: 0x00056B7B File Offset: 0x00054D7B
		public unsafe float HistogramLogMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_HistogramLogMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_HistogramLogMax) = value;
			}
		}

		// Token: 0x17000A4C RID: 2636
		// (get) Token: 0x06003BC1 RID: 15297 RVA: 0x00056B8C File Offset: 0x00054D8C
		// (set) Token: 0x06003BC2 RID: 15298 RVA: 0x00056B9C File Offset: 0x00054D9C
		public unsafe float LocalExposureContrastScale_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LocalExposureContrastScale_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LocalExposureContrastScale_DEPRECATED) = value;
			}
		}

		// Token: 0x17000A4D RID: 2637
		// (get) Token: 0x06003BC3 RID: 15299 RVA: 0x00056BAD File Offset: 0x00054DAD
		// (set) Token: 0x06003BC4 RID: 15300 RVA: 0x00056BBD File Offset: 0x00054DBD
		public unsafe float LocalExposureHighlightContrastScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LocalExposureHighlightContrastScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LocalExposureHighlightContrastScale) = value;
			}
		}

		// Token: 0x17000A4E RID: 2638
		// (get) Token: 0x06003BC5 RID: 15301 RVA: 0x00056BCE File Offset: 0x00054DCE
		// (set) Token: 0x06003BC6 RID: 15302 RVA: 0x00056BDE File Offset: 0x00054DDE
		public unsafe float LocalExposureShadowContrastScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LocalExposureShadowContrastScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LocalExposureShadowContrastScale) = value;
			}
		}

		// Token: 0x17000A4F RID: 2639
		// (get) Token: 0x06003BC7 RID: 15303 RVA: 0x00056BEF File Offset: 0x00054DEF
		// (set) Token: 0x06003BC8 RID: 15304 RVA: 0x00056C03 File Offset: 0x00054E03
		public unsafe UCurveFloat LocalExposureHighlightContrastCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_LocalExposureHighlightContrastCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_LocalExposureHighlightContrastCurve, value);
			}
		}

		// Token: 0x17000A50 RID: 2640
		// (get) Token: 0x06003BC9 RID: 15305 RVA: 0x00056C18 File Offset: 0x00054E18
		// (set) Token: 0x06003BCA RID: 15306 RVA: 0x00056C2C File Offset: 0x00054E2C
		public unsafe UCurveFloat LocalExposureShadowContrastCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_LocalExposureShadowContrastCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_LocalExposureShadowContrastCurve, value);
			}
		}

		// Token: 0x17000A51 RID: 2641
		// (get) Token: 0x06003BCB RID: 15307 RVA: 0x00056C41 File Offset: 0x00054E41
		// (set) Token: 0x06003BCC RID: 15308 RVA: 0x00056C51 File Offset: 0x00054E51
		public unsafe float LocalExposureHighlightThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LocalExposureHighlightThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LocalExposureHighlightThreshold) = value;
			}
		}

		// Token: 0x17000A52 RID: 2642
		// (get) Token: 0x06003BCD RID: 15309 RVA: 0x00056C62 File Offset: 0x00054E62
		// (set) Token: 0x06003BCE RID: 15310 RVA: 0x00056C72 File Offset: 0x00054E72
		public unsafe float LocalExposureShadowThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LocalExposureShadowThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LocalExposureShadowThreshold) = value;
			}
		}

		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06003BCF RID: 15311 RVA: 0x00056C83 File Offset: 0x00054E83
		// (set) Token: 0x06003BD0 RID: 15312 RVA: 0x00056C93 File Offset: 0x00054E93
		public unsafe float LocalExposureDetailStrength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LocalExposureDetailStrength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LocalExposureDetailStrength) = value;
			}
		}

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06003BD1 RID: 15313 RVA: 0x00056CA4 File Offset: 0x00054EA4
		// (set) Token: 0x06003BD2 RID: 15314 RVA: 0x00056CB4 File Offset: 0x00054EB4
		public unsafe float LocalExposureBlurredLuminanceBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LocalExposureBlurredLuminanceBlend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LocalExposureBlurredLuminanceBlend) = value;
			}
		}

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06003BD3 RID: 15315 RVA: 0x00056CC5 File Offset: 0x00054EC5
		// (set) Token: 0x06003BD4 RID: 15316 RVA: 0x00056CD5 File Offset: 0x00054ED5
		public unsafe float LocalExposureBlurredLuminanceKernelSizePercent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LocalExposureBlurredLuminanceKernelSizePercent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LocalExposureBlurredLuminanceKernelSizePercent) = value;
			}
		}

		// Token: 0x17000A56 RID: 2646
		// (get) Token: 0x06003BD5 RID: 15317 RVA: 0x00056CE6 File Offset: 0x00054EE6
		// (set) Token: 0x06003BD6 RID: 15318 RVA: 0x00056CF6 File Offset: 0x00054EF6
		public unsafe float LocalExposureMiddleGreyBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LocalExposureMiddleGreyBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LocalExposureMiddleGreyBias) = value;
			}
		}

		// Token: 0x17000A57 RID: 2647
		// (get) Token: 0x06003BD7 RID: 15319 RVA: 0x00056D07 File Offset: 0x00054F07
		// (set) Token: 0x06003BD8 RID: 15320 RVA: 0x00056D17 File Offset: 0x00054F17
		public unsafe float AutoExposureCalibrationConstant_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AutoExposureCalibrationConstant_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AutoExposureCalibrationConstant_DEPRECATED) = value;
			}
		}

		// Token: 0x17000A58 RID: 2648
		// (get) Token: 0x06003BD9 RID: 15321 RVA: 0x00056D28 File Offset: 0x00054F28
		// (set) Token: 0x06003BDA RID: 15322 RVA: 0x00056D38 File Offset: 0x00054F38
		public unsafe float LensFlareIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LensFlareIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LensFlareIntensity) = value;
			}
		}

		// Token: 0x17000A59 RID: 2649
		// (get) Token: 0x06003BDB RID: 15323 RVA: 0x00056D49 File Offset: 0x00054F49
		// (set) Token: 0x06003BDC RID: 15324 RVA: 0x00056D5D File Offset: 0x00054F5D
		public unsafe FLinearColor LensFlareTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LensFlareTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LensFlareTint) = value;
			}
		}

		// Token: 0x17000A5A RID: 2650
		// (get) Token: 0x06003BDD RID: 15325 RVA: 0x00056D72 File Offset: 0x00054F72
		// (set) Token: 0x06003BDE RID: 15326 RVA: 0x00056D82 File Offset: 0x00054F82
		public unsafe float LensFlareBokehSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LensFlareBokehSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LensFlareBokehSize) = value;
			}
		}

		// Token: 0x17000A5B RID: 2651
		// (get) Token: 0x06003BDF RID: 15327 RVA: 0x00056D93 File Offset: 0x00054F93
		// (set) Token: 0x06003BE0 RID: 15328 RVA: 0x00056DA3 File Offset: 0x00054FA3
		public unsafe float LensFlareThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LensFlareThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LensFlareThreshold) = value;
			}
		}

		// Token: 0x17000A5C RID: 2652
		// (get) Token: 0x06003BE1 RID: 15329 RVA: 0x00056DB4 File Offset: 0x00054FB4
		// (set) Token: 0x06003BE2 RID: 15330 RVA: 0x00056DC8 File Offset: 0x00054FC8
		public unsafe UTexture LensFlareBokehShape
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_LensFlareBokehShape);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_LensFlareBokehShape, value);
			}
		}

		// Token: 0x17000A5D RID: 2653
		// (get) Token: 0x06003BE3 RID: 15331 RVA: 0x00056DE0 File Offset: 0x00054FE0
		// (set) Token: 0x06003BE4 RID: 15332 RVA: 0x00056E23 File Offset: 0x00055023
		[Nullable(1)]
		public TArray<FLinearColor> LensFlareTints
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FLinearColor> result;
				if ((result = this._LensFlareTints) == null)
				{
					result = (this._LensFlareTints = new TArray<FLinearColor>(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LensFlareTints, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.LensFlareTints.CopyAssign(value);
			}
		}

		// Token: 0x17000A5E RID: 2654
		// (get) Token: 0x06003BE5 RID: 15333 RVA: 0x00056E31 File Offset: 0x00055031
		// (set) Token: 0x06003BE6 RID: 15334 RVA: 0x00056E4A File Offset: 0x0005504A
		public unsafe bool LensFlareOnlySun
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LensFlareOnlySun) & FPostProcessSettings.__PropertyMask_LensFlareOnlySun) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LensFlareOnlySun) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LensFlareOnlySun) & ~FPostProcessSettings.__PropertyMask_LensFlareOnlySun) | (value ? FPostProcessSettings.__PropertyMask_LensFlareOnlySun : 0));
			}
		}

		// Token: 0x17000A5F RID: 2655
		// (get) Token: 0x06003BE7 RID: 15335 RVA: 0x00056E7A File Offset: 0x0005507A
		// (set) Token: 0x06003BE8 RID: 15336 RVA: 0x00056E8A File Offset: 0x0005508A
		public unsafe float LensFlareSunRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LensFlareSunRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LensFlareSunRange) = value;
			}
		}

		// Token: 0x17000A60 RID: 2656
		// (get) Token: 0x06003BE9 RID: 15337 RVA: 0x00056E9B File Offset: 0x0005509B
		// (set) Token: 0x06003BEA RID: 15338 RVA: 0x00056EAF File Offset: 0x000550AF
		public unsafe FVector4 LensFlareSunPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LensFlareSunPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LensFlareSunPosition) = value;
			}
		}

		// Token: 0x17000A61 RID: 2657
		// (get) Token: 0x06003BEB RID: 15339 RVA: 0x00056EC4 File Offset: 0x000550C4
		// (set) Token: 0x06003BEC RID: 15340 RVA: 0x00056ED4 File Offset: 0x000550D4
		public unsafe float VignetteIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VignetteIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VignetteIntensity) = value;
			}
		}

		// Token: 0x17000A62 RID: 2658
		// (get) Token: 0x06003BED RID: 15341 RVA: 0x00056EE5 File Offset: 0x000550E5
		// (set) Token: 0x06003BEE RID: 15342 RVA: 0x00056EF5 File Offset: 0x000550F5
		public unsafe float VignetteHardness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VignetteHardness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VignetteHardness) = value;
			}
		}

		// Token: 0x17000A63 RID: 2659
		// (get) Token: 0x06003BEF RID: 15343 RVA: 0x00056F06 File Offset: 0x00055106
		// (set) Token: 0x06003BF0 RID: 15344 RVA: 0x00056F16 File Offset: 0x00055116
		public unsafe float VignetteXScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VignetteXScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VignetteXScale) = value;
			}
		}

		// Token: 0x17000A64 RID: 2660
		// (get) Token: 0x06003BF1 RID: 15345 RVA: 0x00056F27 File Offset: 0x00055127
		// (set) Token: 0x06003BF2 RID: 15346 RVA: 0x00056F37 File Offset: 0x00055137
		public unsafe float VignetteYScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VignetteYScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VignetteYScale) = value;
			}
		}

		// Token: 0x17000A65 RID: 2661
		// (get) Token: 0x06003BF3 RID: 15347 RVA: 0x00056F48 File Offset: 0x00055148
		// (set) Token: 0x06003BF4 RID: 15348 RVA: 0x00056F58 File Offset: 0x00055158
		public unsafe float VignetteXPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VignetteXPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VignetteXPos) = value;
			}
		}

		// Token: 0x17000A66 RID: 2662
		// (get) Token: 0x06003BF5 RID: 15349 RVA: 0x00056F69 File Offset: 0x00055169
		// (set) Token: 0x06003BF6 RID: 15350 RVA: 0x00056F79 File Offset: 0x00055179
		public unsafe float VignetteYPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VignetteYPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VignetteYPos) = value;
			}
		}

		// Token: 0x17000A67 RID: 2663
		// (get) Token: 0x06003BF7 RID: 15351 RVA: 0x00056F8A File Offset: 0x0005518A
		// (set) Token: 0x06003BF8 RID: 15352 RVA: 0x00056F9E File Offset: 0x0005519E
		public unsafe FLinearColor VignetteColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VignetteColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VignetteColor) = value;
			}
		}

		// Token: 0x17000A68 RID: 2664
		// (get) Token: 0x06003BF9 RID: 15353 RVA: 0x00056FB3 File Offset: 0x000551B3
		// (set) Token: 0x06003BFA RID: 15354 RVA: 0x00056FC3 File Offset: 0x000551C3
		public unsafe float VignetteGain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VignetteGain);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VignetteGain) = value;
			}
		}

		// Token: 0x17000A69 RID: 2665
		// (get) Token: 0x06003BFB RID: 15355 RVA: 0x00056FD4 File Offset: 0x000551D4
		// (set) Token: 0x06003BFC RID: 15356 RVA: 0x00056FE4 File Offset: 0x000551E4
		public unsafe float EffectVignetteIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EffectVignetteIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EffectVignetteIntensity) = value;
			}
		}

		// Token: 0x17000A6A RID: 2666
		// (get) Token: 0x06003BFD RID: 15357 RVA: 0x00056FF5 File Offset: 0x000551F5
		// (set) Token: 0x06003BFE RID: 15358 RVA: 0x00057005 File Offset: 0x00055205
		public unsafe float EffectVignetteHardness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EffectVignetteHardness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EffectVignetteHardness) = value;
			}
		}

		// Token: 0x17000A6B RID: 2667
		// (get) Token: 0x06003BFF RID: 15359 RVA: 0x00057016 File Offset: 0x00055216
		// (set) Token: 0x06003C00 RID: 15360 RVA: 0x00057026 File Offset: 0x00055226
		public unsafe float EffectVignetteXScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EffectVignetteXScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EffectVignetteXScale) = value;
			}
		}

		// Token: 0x17000A6C RID: 2668
		// (get) Token: 0x06003C01 RID: 15361 RVA: 0x00057037 File Offset: 0x00055237
		// (set) Token: 0x06003C02 RID: 15362 RVA: 0x00057047 File Offset: 0x00055247
		public unsafe float EffectVignetteYScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EffectVignetteYScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EffectVignetteYScale) = value;
			}
		}

		// Token: 0x17000A6D RID: 2669
		// (get) Token: 0x06003C03 RID: 15363 RVA: 0x00057058 File Offset: 0x00055258
		// (set) Token: 0x06003C04 RID: 15364 RVA: 0x00057068 File Offset: 0x00055268
		public unsafe float EffectVignetteXPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EffectVignetteXPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EffectVignetteXPos) = value;
			}
		}

		// Token: 0x17000A6E RID: 2670
		// (get) Token: 0x06003C05 RID: 15365 RVA: 0x00057079 File Offset: 0x00055279
		// (set) Token: 0x06003C06 RID: 15366 RVA: 0x00057089 File Offset: 0x00055289
		public unsafe float EffectVignetteYPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EffectVignetteYPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EffectVignetteYPos) = value;
			}
		}

		// Token: 0x17000A6F RID: 2671
		// (get) Token: 0x06003C07 RID: 15367 RVA: 0x0005709A File Offset: 0x0005529A
		// (set) Token: 0x06003C08 RID: 15368 RVA: 0x000570AE File Offset: 0x000552AE
		public unsafe FLinearColor EffectVignetteColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EffectVignetteColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EffectVignetteColor) = value;
			}
		}

		// Token: 0x17000A70 RID: 2672
		// (get) Token: 0x06003C09 RID: 15369 RVA: 0x000570C3 File Offset: 0x000552C3
		// (set) Token: 0x06003C0A RID: 15370 RVA: 0x000570D3 File Offset: 0x000552D3
		public unsafe float EffectVignetteGain
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EffectVignetteGain);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EffectVignetteGain) = value;
			}
		}

		// Token: 0x17000A71 RID: 2673
		// (get) Token: 0x06003C0B RID: 15371 RVA: 0x000570E4 File Offset: 0x000552E4
		// (set) Token: 0x06003C0C RID: 15372 RVA: 0x000570F4 File Offset: 0x000552F4
		public unsafe float GrainJitter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_GrainJitter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_GrainJitter) = value;
			}
		}

		// Token: 0x17000A72 RID: 2674
		// (get) Token: 0x06003C0D RID: 15373 RVA: 0x00057105 File Offset: 0x00055305
		// (set) Token: 0x06003C0E RID: 15374 RVA: 0x00057115 File Offset: 0x00055315
		public unsafe float GrainIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_GrainIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_GrainIntensity) = value;
			}
		}

		// Token: 0x17000A73 RID: 2675
		// (get) Token: 0x06003C0F RID: 15375 RVA: 0x00057126 File Offset: 0x00055326
		// (set) Token: 0x06003C10 RID: 15376 RVA: 0x00057136 File Offset: 0x00055336
		public unsafe float GrainColorful
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_GrainColorful);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_GrainColorful) = value;
			}
		}

		// Token: 0x17000A74 RID: 2676
		// (get) Token: 0x06003C11 RID: 15377 RVA: 0x00057147 File Offset: 0x00055347
		// (set) Token: 0x06003C12 RID: 15378 RVA: 0x00057157 File Offset: 0x00055357
		public unsafe float MainCenterMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MainCenterMask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MainCenterMask) = value;
			}
		}

		// Token: 0x17000A75 RID: 2677
		// (get) Token: 0x06003C13 RID: 15379 RVA: 0x00057168 File Offset: 0x00055368
		// (set) Token: 0x06003C14 RID: 15380 RVA: 0x00057178 File Offset: 0x00055378
		public unsafe float MainCenterMaskRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MainCenterMaskRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MainCenterMaskRadius) = value;
			}
		}

		// Token: 0x17000A76 RID: 2678
		// (get) Token: 0x06003C15 RID: 15381 RVA: 0x00057189 File Offset: 0x00055389
		// (set) Token: 0x06003C16 RID: 15382 RVA: 0x00057199 File Offset: 0x00055399
		public unsafe float MainCenterMaskHardness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MainCenterMaskHardness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MainCenterMaskHardness) = value;
			}
		}

		// Token: 0x17000A77 RID: 2679
		// (get) Token: 0x06003C17 RID: 15383 RVA: 0x000571AA File Offset: 0x000553AA
		// (set) Token: 0x06003C18 RID: 15384 RVA: 0x000571BA File Offset: 0x000553BA
		public unsafe float MainStartDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MainStartDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MainStartDistance) = value;
			}
		}

		// Token: 0x17000A78 RID: 2680
		// (get) Token: 0x06003C19 RID: 15385 RVA: 0x000571CB File Offset: 0x000553CB
		// (set) Token: 0x06003C1A RID: 15386 RVA: 0x000571DB File Offset: 0x000553DB
		public unsafe float MainCharacterIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MainCharacterIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MainCharacterIntensity) = value;
			}
		}

		// Token: 0x17000A79 RID: 2681
		// (get) Token: 0x06003C1B RID: 15387 RVA: 0x000571EC File Offset: 0x000553EC
		// (set) Token: 0x06003C1C RID: 15388 RVA: 0x000571FC File Offset: 0x000553FC
		public unsafe float VintageColorIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VintageColorIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VintageColorIntensity) = value;
			}
		}

		// Token: 0x17000A7A RID: 2682
		// (get) Token: 0x06003C1D RID: 15389 RVA: 0x0005720D File Offset: 0x0005540D
		// (set) Token: 0x06003C1E RID: 15390 RVA: 0x0005721D File Offset: 0x0005541D
		public unsafe float VintageColorBlackPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VintageColorBlackPoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VintageColorBlackPoint) = value;
			}
		}

		// Token: 0x17000A7B RID: 2683
		// (get) Token: 0x06003C1F RID: 15391 RVA: 0x0005722E File Offset: 0x0005542E
		// (set) Token: 0x06003C20 RID: 15392 RVA: 0x0005723E File Offset: 0x0005543E
		public unsafe float VintageColorWhitePoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VintageColorWhitePoint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VintageColorWhitePoint) = value;
			}
		}

		// Token: 0x17000A7C RID: 2684
		// (get) Token: 0x06003C21 RID: 15393 RVA: 0x0005724F File Offset: 0x0005544F
		// (set) Token: 0x06003C22 RID: 15394 RVA: 0x0005725F File Offset: 0x0005545F
		public unsafe float VHSLinesColorIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSLinesColorIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSLinesColorIntensity) = value;
			}
		}

		// Token: 0x17000A7D RID: 2685
		// (get) Token: 0x06003C23 RID: 15395 RVA: 0x00057270 File Offset: 0x00055470
		// (set) Token: 0x06003C24 RID: 15396 RVA: 0x00057280 File Offset: 0x00055480
		public unsafe float VHSLinesDistortIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSLinesDistortIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSLinesDistortIntensity) = value;
			}
		}

		// Token: 0x17000A7E RID: 2686
		// (get) Token: 0x06003C25 RID: 15397 RVA: 0x00057291 File Offset: 0x00055491
		// (set) Token: 0x06003C26 RID: 15398 RVA: 0x000572A1 File Offset: 0x000554A1
		public unsafe float VHSEffectIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSEffectIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSEffectIntensity) = value;
			}
		}

		// Token: 0x17000A7F RID: 2687
		// (get) Token: 0x06003C27 RID: 15399 RVA: 0x000572B2 File Offset: 0x000554B2
		// (set) Token: 0x06003C28 RID: 15400 RVA: 0x000572C2 File Offset: 0x000554C2
		public unsafe float VHSSpecklesIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSSpecklesIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSSpecklesIntensity) = value;
			}
		}

		// Token: 0x17000A80 RID: 2688
		// (get) Token: 0x06003C29 RID: 15401 RVA: 0x000572D3 File Offset: 0x000554D3
		// (set) Token: 0x06003C2A RID: 15402 RVA: 0x000572E3 File Offset: 0x000554E3
		public unsafe float VHSSpecklesAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSSpecklesAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSSpecklesAmount) = value;
			}
		}

		// Token: 0x17000A81 RID: 2689
		// (get) Token: 0x06003C2B RID: 15403 RVA: 0x000572F4 File Offset: 0x000554F4
		// (set) Token: 0x06003C2C RID: 15404 RVA: 0x00057304 File Offset: 0x00055504
		public unsafe float VHSSpecklesSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSSpecklesSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSSpecklesSize) = value;
			}
		}

		// Token: 0x17000A82 RID: 2690
		// (get) Token: 0x06003C2D RID: 15405 RVA: 0x00057315 File Offset: 0x00055515
		// (set) Token: 0x06003C2E RID: 15406 RVA: 0x00057325 File Offset: 0x00055525
		public unsafe float CRTDistortion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_CRTDistortion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_CRTDistortion) = value;
			}
		}

		// Token: 0x17000A83 RID: 2691
		// (get) Token: 0x06003C2F RID: 15407 RVA: 0x00057336 File Offset: 0x00055536
		// (set) Token: 0x06003C30 RID: 15408 RVA: 0x00057346 File Offset: 0x00055546
		public unsafe float VintageColorCenterMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VintageColorCenterMask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VintageColorCenterMask) = value;
			}
		}

		// Token: 0x17000A84 RID: 2692
		// (get) Token: 0x06003C31 RID: 15409 RVA: 0x00057357 File Offset: 0x00055557
		// (set) Token: 0x06003C32 RID: 15410 RVA: 0x00057367 File Offset: 0x00055567
		public unsafe float VintageColorStartDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VintageColorStartDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VintageColorStartDistance) = value;
			}
		}

		// Token: 0x17000A85 RID: 2693
		// (get) Token: 0x06003C33 RID: 15411 RVA: 0x00057378 File Offset: 0x00055578
		// (set) Token: 0x06003C34 RID: 15412 RVA: 0x00057388 File Offset: 0x00055588
		public unsafe float VintageColorCharacterIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VintageColorCharacterIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VintageColorCharacterIntensity) = value;
			}
		}

		// Token: 0x17000A86 RID: 2694
		// (get) Token: 0x06003C35 RID: 15413 RVA: 0x00057399 File Offset: 0x00055599
		// (set) Token: 0x06003C36 RID: 15414 RVA: 0x000573A9 File Offset: 0x000555A9
		public unsafe float VHSLinesCenterMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSLinesCenterMask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSLinesCenterMask) = value;
			}
		}

		// Token: 0x17000A87 RID: 2695
		// (get) Token: 0x06003C37 RID: 15415 RVA: 0x000573BA File Offset: 0x000555BA
		// (set) Token: 0x06003C38 RID: 15416 RVA: 0x000573CA File Offset: 0x000555CA
		public unsafe float VHSLinesStartDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSLinesStartDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSLinesStartDistance) = value;
			}
		}

		// Token: 0x17000A88 RID: 2696
		// (get) Token: 0x06003C39 RID: 15417 RVA: 0x000573DB File Offset: 0x000555DB
		// (set) Token: 0x06003C3A RID: 15418 RVA: 0x000573EB File Offset: 0x000555EB
		public unsafe float VHSLinesCharacterIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSLinesCharacterIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSLinesCharacterIntensity) = value;
			}
		}

		// Token: 0x17000A89 RID: 2697
		// (get) Token: 0x06003C3B RID: 15419 RVA: 0x000573FC File Offset: 0x000555FC
		// (set) Token: 0x06003C3C RID: 15420 RVA: 0x0005740C File Offset: 0x0005560C
		public unsafe float VHSEffectCenterMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSEffectCenterMask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSEffectCenterMask) = value;
			}
		}

		// Token: 0x17000A8A RID: 2698
		// (get) Token: 0x06003C3D RID: 15421 RVA: 0x0005741D File Offset: 0x0005561D
		// (set) Token: 0x06003C3E RID: 15422 RVA: 0x0005742D File Offset: 0x0005562D
		public unsafe float VHSEffectStartDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSEffectStartDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSEffectStartDistance) = value;
			}
		}

		// Token: 0x17000A8B RID: 2699
		// (get) Token: 0x06003C3F RID: 15423 RVA: 0x0005743E File Offset: 0x0005563E
		// (set) Token: 0x06003C40 RID: 15424 RVA: 0x0005744E File Offset: 0x0005564E
		public unsafe float VHSEffectCharacterIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSEffectCharacterIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSEffectCharacterIntensity) = value;
			}
		}

		// Token: 0x17000A8C RID: 2700
		// (get) Token: 0x06003C41 RID: 15425 RVA: 0x0005745F File Offset: 0x0005565F
		// (set) Token: 0x06003C42 RID: 15426 RVA: 0x0005746F File Offset: 0x0005566F
		public unsafe float VHSSpecklesCenterMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSSpecklesCenterMask);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSSpecklesCenterMask) = value;
			}
		}

		// Token: 0x17000A8D RID: 2701
		// (get) Token: 0x06003C43 RID: 15427 RVA: 0x00057480 File Offset: 0x00055680
		// (set) Token: 0x06003C44 RID: 15428 RVA: 0x00057490 File Offset: 0x00055690
		public unsafe float VHSSpecklesStartDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSSpecklesStartDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSSpecklesStartDistance) = value;
			}
		}

		// Token: 0x17000A8E RID: 2702
		// (get) Token: 0x06003C45 RID: 15429 RVA: 0x000574A1 File Offset: 0x000556A1
		// (set) Token: 0x06003C46 RID: 15430 RVA: 0x000574B1 File Offset: 0x000556B1
		public unsafe float VHSSpecklesCharacterIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSSpecklesCharacterIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_VHSSpecklesCharacterIntensity) = value;
			}
		}

		// Token: 0x17000A8F RID: 2703
		// (get) Token: 0x06003C47 RID: 15431 RVA: 0x000574C2 File Offset: 0x000556C2
		// (set) Token: 0x06003C48 RID: 15432 RVA: 0x000574D2 File Offset: 0x000556D2
		public unsafe float AmbientOcclusionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionIntensity) = value;
			}
		}

		// Token: 0x17000A90 RID: 2704
		// (get) Token: 0x06003C49 RID: 15433 RVA: 0x000574E3 File Offset: 0x000556E3
		// (set) Token: 0x06003C4A RID: 15434 RVA: 0x000574FC File Offset: 0x000556FC
		public unsafe bool ToonAmbientOcclusionEnabled
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ToonAmbientOcclusionEnabled) & FPostProcessSettings.__PropertyMask_ToonAmbientOcclusionEnabled) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ToonAmbientOcclusionEnabled) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ToonAmbientOcclusionEnabled) & ~FPostProcessSettings.__PropertyMask_ToonAmbientOcclusionEnabled) | (value ? FPostProcessSettings.__PropertyMask_ToonAmbientOcclusionEnabled : 0));
			}
		}

		// Token: 0x17000A91 RID: 2705
		// (get) Token: 0x06003C4B RID: 15435 RVA: 0x0005752C File Offset: 0x0005572C
		// (set) Token: 0x06003C4C RID: 15436 RVA: 0x0005753C File Offset: 0x0005573C
		public unsafe float ToonAmbientOcclusionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ToonAmbientOcclusionRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ToonAmbientOcclusionRadius) = value;
			}
		}

		// Token: 0x17000A92 RID: 2706
		// (get) Token: 0x06003C4D RID: 15437 RVA: 0x0005754D File Offset: 0x0005574D
		// (set) Token: 0x06003C4E RID: 15438 RVA: 0x0005755D File Offset: 0x0005575D
		public unsafe float ToonAmbientOcclusionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ToonAmbientOcclusionIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ToonAmbientOcclusionIntensity) = value;
			}
		}

		// Token: 0x17000A93 RID: 2707
		// (get) Token: 0x06003C4F RID: 15439 RVA: 0x0005756E File Offset: 0x0005576E
		// (set) Token: 0x06003C50 RID: 15440 RVA: 0x0005757E File Offset: 0x0005577E
		public unsafe float ToonAmbientOcclusionPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ToonAmbientOcclusionPower);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ToonAmbientOcclusionPower) = value;
			}
		}

		// Token: 0x17000A94 RID: 2708
		// (get) Token: 0x06003C51 RID: 15441 RVA: 0x0005758F File Offset: 0x0005578F
		// (set) Token: 0x06003C52 RID: 15442 RVA: 0x000575A3 File Offset: 0x000557A3
		public unsafe FLinearColor ToonAmbientOcclusionColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ToonAmbientOcclusionColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ToonAmbientOcclusionColor) = value;
			}
		}

		// Token: 0x17000A95 RID: 2709
		// (get) Token: 0x06003C53 RID: 15443 RVA: 0x000575B8 File Offset: 0x000557B8
		// (set) Token: 0x06003C54 RID: 15444 RVA: 0x000575C8 File Offset: 0x000557C8
		public unsafe float AmbientOcclusionStaticFraction
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionStaticFraction);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionStaticFraction) = value;
			}
		}

		// Token: 0x17000A96 RID: 2710
		// (get) Token: 0x06003C55 RID: 15445 RVA: 0x000575D9 File Offset: 0x000557D9
		// (set) Token: 0x06003C56 RID: 15446 RVA: 0x000575E9 File Offset: 0x000557E9
		public unsafe float AmbientOcclusionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionRadius) = value;
			}
		}

		// Token: 0x17000A97 RID: 2711
		// (get) Token: 0x06003C57 RID: 15447 RVA: 0x000575FA File Offset: 0x000557FA
		// (set) Token: 0x06003C58 RID: 15448 RVA: 0x00057613 File Offset: 0x00055813
		public unsafe bool AmbientOcclusionRadiusInWS
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionRadiusInWS) & FPostProcessSettings.__PropertyMask_AmbientOcclusionRadiusInWS) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionRadiusInWS) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionRadiusInWS) & ~FPostProcessSettings.__PropertyMask_AmbientOcclusionRadiusInWS) | (value ? FPostProcessSettings.__PropertyMask_AmbientOcclusionRadiusInWS : 0));
			}
		}

		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06003C59 RID: 15449 RVA: 0x00057643 File Offset: 0x00055843
		// (set) Token: 0x06003C5A RID: 15450 RVA: 0x00057653 File Offset: 0x00055853
		public unsafe float AmbientOcclusionFadeDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionFadeDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionFadeDistance) = value;
			}
		}

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06003C5B RID: 15451 RVA: 0x00057664 File Offset: 0x00055864
		// (set) Token: 0x06003C5C RID: 15452 RVA: 0x00057674 File Offset: 0x00055874
		public unsafe float AmbientOcclusionFadeRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionFadeRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionFadeRadius) = value;
			}
		}

		// Token: 0x17000A9A RID: 2714
		// (get) Token: 0x06003C5D RID: 15453 RVA: 0x00057685 File Offset: 0x00055885
		// (set) Token: 0x06003C5E RID: 15454 RVA: 0x00057695 File Offset: 0x00055895
		public unsafe float AmbientOcclusionDistance_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionDistance_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionDistance_DEPRECATED) = value;
			}
		}

		// Token: 0x17000A9B RID: 2715
		// (get) Token: 0x06003C5F RID: 15455 RVA: 0x000576A6 File Offset: 0x000558A6
		// (set) Token: 0x06003C60 RID: 15456 RVA: 0x000576B6 File Offset: 0x000558B6
		public unsafe float AmbientOcclusionPower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionPower);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionPower) = value;
			}
		}

		// Token: 0x17000A9C RID: 2716
		// (get) Token: 0x06003C61 RID: 15457 RVA: 0x000576C7 File Offset: 0x000558C7
		// (set) Token: 0x06003C62 RID: 15458 RVA: 0x000576D7 File Offset: 0x000558D7
		public unsafe float AmbientOcclusionBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionBias) = value;
			}
		}

		// Token: 0x17000A9D RID: 2717
		// (get) Token: 0x06003C63 RID: 15459 RVA: 0x000576E8 File Offset: 0x000558E8
		// (set) Token: 0x06003C64 RID: 15460 RVA: 0x000576F8 File Offset: 0x000558F8
		public unsafe float AmbientOcclusionQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionQuality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionQuality) = value;
			}
		}

		// Token: 0x17000A9E RID: 2718
		// (get) Token: 0x06003C65 RID: 15461 RVA: 0x00057709 File Offset: 0x00055909
		// (set) Token: 0x06003C66 RID: 15462 RVA: 0x00057719 File Offset: 0x00055919
		public unsafe float AmbientOcclusionMipBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionMipBlend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionMipBlend) = value;
			}
		}

		// Token: 0x17000A9F RID: 2719
		// (get) Token: 0x06003C67 RID: 15463 RVA: 0x0005772A File Offset: 0x0005592A
		// (set) Token: 0x06003C68 RID: 15464 RVA: 0x0005773A File Offset: 0x0005593A
		public unsafe float AmbientOcclusionMipScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionMipScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionMipScale) = value;
			}
		}

		// Token: 0x17000AA0 RID: 2720
		// (get) Token: 0x06003C69 RID: 15465 RVA: 0x0005774B File Offset: 0x0005594B
		// (set) Token: 0x06003C6A RID: 15466 RVA: 0x0005775B File Offset: 0x0005595B
		public unsafe float AmbientOcclusionMipThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionMipThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionMipThreshold) = value;
			}
		}

		// Token: 0x17000AA1 RID: 2721
		// (get) Token: 0x06003C6B RID: 15467 RVA: 0x0005776C File Offset: 0x0005596C
		// (set) Token: 0x06003C6C RID: 15468 RVA: 0x0005777C File Offset: 0x0005597C
		public unsafe float AmbientOcclusionTemporalBlendWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionTemporalBlendWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AmbientOcclusionTemporalBlendWeight) = value;
			}
		}

		// Token: 0x17000AA2 RID: 2722
		// (get) Token: 0x06003C6D RID: 15469 RVA: 0x0005778D File Offset: 0x0005598D
		// (set) Token: 0x06003C6E RID: 15470 RVA: 0x000577A6 File Offset: 0x000559A6
		public unsafe bool RayTracingAO
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingAO) & FPostProcessSettings.__PropertyMask_RayTracingAO) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingAO) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingAO) & ~FPostProcessSettings.__PropertyMask_RayTracingAO) | (value ? FPostProcessSettings.__PropertyMask_RayTracingAO : 0));
			}
		}

		// Token: 0x17000AA3 RID: 2723
		// (get) Token: 0x06003C6F RID: 15471 RVA: 0x000577D6 File Offset: 0x000559D6
		// (set) Token: 0x06003C70 RID: 15472 RVA: 0x000577E6 File Offset: 0x000559E6
		public unsafe int RayTracingAOSamplesPerPixel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingAOSamplesPerPixel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingAOSamplesPerPixel) = value;
			}
		}

		// Token: 0x17000AA4 RID: 2724
		// (get) Token: 0x06003C71 RID: 15473 RVA: 0x000577F7 File Offset: 0x000559F7
		// (set) Token: 0x06003C72 RID: 15474 RVA: 0x00057807 File Offset: 0x00055A07
		public unsafe float RayTracingAOIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingAOIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingAOIntensity) = value;
			}
		}

		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06003C73 RID: 15475 RVA: 0x00057818 File Offset: 0x00055A18
		// (set) Token: 0x06003C74 RID: 15476 RVA: 0x00057828 File Offset: 0x00055A28
		public unsafe float RayTracingAORadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingAORadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingAORadius) = value;
			}
		}

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06003C75 RID: 15477 RVA: 0x00057839 File Offset: 0x00055A39
		// (set) Token: 0x06003C76 RID: 15478 RVA: 0x00057849 File Offset: 0x00055A49
		public unsafe float LumenSkylightLeaking
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LumenSkylightLeaking);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LumenSkylightLeaking) = value;
			}
		}

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06003C77 RID: 15479 RVA: 0x0005785A File Offset: 0x00055A5A
		// (set) Token: 0x06003C78 RID: 15480 RVA: 0x0005786E File Offset: 0x00055A6E
		public unsafe FLinearColor IndirectLightingColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_IndirectLightingColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_IndirectLightingColor) = value;
			}
		}

		// Token: 0x17000AA8 RID: 2728
		// (get) Token: 0x06003C79 RID: 15481 RVA: 0x00057883 File Offset: 0x00055A83
		// (set) Token: 0x06003C7A RID: 15482 RVA: 0x00057893 File Offset: 0x00055A93
		public unsafe float IndirectLightingIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_IndirectLightingIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_IndirectLightingIntensity) = value;
			}
		}

		// Token: 0x17000AA9 RID: 2729
		// (get) Token: 0x06003C7B RID: 15483 RVA: 0x000578A4 File Offset: 0x00055AA4
		// (set) Token: 0x06003C7C RID: 15484 RVA: 0x000578B4 File Offset: 0x00055AB4
		public unsafe int RayTracingGIMaxBounces
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingGIMaxBounces);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingGIMaxBounces) = value;
			}
		}

		// Token: 0x17000AAA RID: 2730
		// (get) Token: 0x06003C7D RID: 15485 RVA: 0x000578C5 File Offset: 0x00055AC5
		// (set) Token: 0x06003C7E RID: 15486 RVA: 0x000578D5 File Offset: 0x00055AD5
		public unsafe int RayTracingGISamplesPerPixel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingGISamplesPerPixel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingGISamplesPerPixel) = value;
			}
		}

		// Token: 0x17000AAB RID: 2731
		// (get) Token: 0x06003C7F RID: 15487 RVA: 0x000578E6 File Offset: 0x00055AE6
		// (set) Token: 0x06003C80 RID: 15488 RVA: 0x000578F6 File Offset: 0x00055AF6
		public unsafe float ColorGradingIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorGradingIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ColorGradingIntensity) = value;
			}
		}

		// Token: 0x17000AAC RID: 2732
		// (get) Token: 0x06003C81 RID: 15489 RVA: 0x00057907 File Offset: 0x00055B07
		// (set) Token: 0x06003C82 RID: 15490 RVA: 0x0005791B File Offset: 0x00055B1B
		public unsafe UTexture ColorGradingLUT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_ColorGradingLUT);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_ColorGradingLUT, value);
			}
		}

		// Token: 0x17000AAD RID: 2733
		// (get) Token: 0x06003C83 RID: 15491 RVA: 0x00057930 File Offset: 0x00055B30
		// (set) Token: 0x06003C84 RID: 15492 RVA: 0x00057940 File Offset: 0x00055B40
		public unsafe float DepthOfFieldSensorWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldSensorWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldSensorWidth) = value;
			}
		}

		// Token: 0x17000AAE RID: 2734
		// (get) Token: 0x06003C85 RID: 15493 RVA: 0x00057951 File Offset: 0x00055B51
		// (set) Token: 0x06003C86 RID: 15494 RVA: 0x00057961 File Offset: 0x00055B61
		public unsafe float DepthOfFieldFocalDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldFocalDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldFocalDistance) = value;
			}
		}

		// Token: 0x17000AAF RID: 2735
		// (get) Token: 0x06003C87 RID: 15495 RVA: 0x00057972 File Offset: 0x00055B72
		// (set) Token: 0x06003C88 RID: 15496 RVA: 0x00057982 File Offset: 0x00055B82
		public unsafe float DepthOfFieldDepthBlurAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldDepthBlurAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldDepthBlurAmount) = value;
			}
		}

		// Token: 0x17000AB0 RID: 2736
		// (get) Token: 0x06003C89 RID: 15497 RVA: 0x00057993 File Offset: 0x00055B93
		// (set) Token: 0x06003C8A RID: 15498 RVA: 0x000579A3 File Offset: 0x00055BA3
		public unsafe float DepthOfFieldDepthBlurRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldDepthBlurRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldDepthBlurRadius) = value;
			}
		}

		// Token: 0x17000AB1 RID: 2737
		// (get) Token: 0x06003C8B RID: 15499 RVA: 0x000579B4 File Offset: 0x00055BB4
		// (set) Token: 0x06003C8C RID: 15500 RVA: 0x000579C4 File Offset: 0x00055BC4
		public unsafe float DepthOfFieldFocalRegion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldFocalRegion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldFocalRegion) = value;
			}
		}

		// Token: 0x17000AB2 RID: 2738
		// (get) Token: 0x06003C8D RID: 15501 RVA: 0x000579D5 File Offset: 0x00055BD5
		// (set) Token: 0x06003C8E RID: 15502 RVA: 0x000579E5 File Offset: 0x00055BE5
		public unsafe float DepthOfFieldNearTransitionRegion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldNearTransitionRegion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldNearTransitionRegion) = value;
			}
		}

		// Token: 0x17000AB3 RID: 2739
		// (get) Token: 0x06003C8F RID: 15503 RVA: 0x000579F6 File Offset: 0x00055BF6
		// (set) Token: 0x06003C90 RID: 15504 RVA: 0x00057A06 File Offset: 0x00055C06
		public unsafe float DepthOfFieldFarTransitionRegion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldFarTransitionRegion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldFarTransitionRegion) = value;
			}
		}

		// Token: 0x17000AB4 RID: 2740
		// (get) Token: 0x06003C91 RID: 15505 RVA: 0x00057A17 File Offset: 0x00055C17
		// (set) Token: 0x06003C92 RID: 15506 RVA: 0x00057A27 File Offset: 0x00055C27
		public unsafe float DepthOfFieldScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldScale) = value;
			}
		}

		// Token: 0x17000AB5 RID: 2741
		// (get) Token: 0x06003C93 RID: 15507 RVA: 0x00057A38 File Offset: 0x00055C38
		// (set) Token: 0x06003C94 RID: 15508 RVA: 0x00057A48 File Offset: 0x00055C48
		public unsafe float DepthOfFieldNearBlurSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldNearBlurSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldNearBlurSize) = value;
			}
		}

		// Token: 0x17000AB6 RID: 2742
		// (get) Token: 0x06003C95 RID: 15509 RVA: 0x00057A59 File Offset: 0x00055C59
		// (set) Token: 0x06003C96 RID: 15510 RVA: 0x00057A69 File Offset: 0x00055C69
		public unsafe float DepthOfFieldFarBlurSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldFarBlurSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldFarBlurSize) = value;
			}
		}

		// Token: 0x17000AB7 RID: 2743
		// (get) Token: 0x06003C97 RID: 15511 RVA: 0x00057A7A File Offset: 0x00055C7A
		// (set) Token: 0x06003C98 RID: 15512 RVA: 0x00057A8A File Offset: 0x00055C8A
		public unsafe float DepthOfFieldOcclusion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldOcclusion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldOcclusion) = value;
			}
		}

		// Token: 0x17000AB8 RID: 2744
		// (get) Token: 0x06003C99 RID: 15513 RVA: 0x00057A9B File Offset: 0x00055C9B
		// (set) Token: 0x06003C9A RID: 15514 RVA: 0x00057AAB File Offset: 0x00055CAB
		public unsafe float DepthOfFieldSkyFocusDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldSkyFocusDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldSkyFocusDistance) = value;
			}
		}

		// Token: 0x17000AB9 RID: 2745
		// (get) Token: 0x06003C9B RID: 15515 RVA: 0x00057ABC File Offset: 0x00055CBC
		// (set) Token: 0x06003C9C RID: 15516 RVA: 0x00057ACC File Offset: 0x00055CCC
		public unsafe float DepthOfFieldVignetteSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldVignetteSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_DepthOfFieldVignetteSize) = value;
			}
		}

		// Token: 0x17000ABA RID: 2746
		// (get) Token: 0x06003C9D RID: 15517 RVA: 0x00057ADD File Offset: 0x00055CDD
		// (set) Token: 0x06003C9E RID: 15518 RVA: 0x00057AED File Offset: 0x00055CED
		public unsafe float MotionBlurAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MotionBlurAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MotionBlurAmount) = value;
			}
		}

		// Token: 0x17000ABB RID: 2747
		// (get) Token: 0x06003C9F RID: 15519 RVA: 0x00057AFE File Offset: 0x00055CFE
		// (set) Token: 0x06003CA0 RID: 15520 RVA: 0x00057B0E File Offset: 0x00055D0E
		public unsafe float MotionBlurMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MotionBlurMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MotionBlurMax) = value;
			}
		}

		// Token: 0x17000ABC RID: 2748
		// (get) Token: 0x06003CA1 RID: 15521 RVA: 0x00057B1F File Offset: 0x00055D1F
		// (set) Token: 0x06003CA2 RID: 15522 RVA: 0x00057B2F File Offset: 0x00055D2F
		public unsafe int MotionBlurTargetFPS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MotionBlurTargetFPS);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MotionBlurTargetFPS) = value;
			}
		}

		// Token: 0x17000ABD RID: 2749
		// (get) Token: 0x06003CA3 RID: 15523 RVA: 0x00057B40 File Offset: 0x00055D40
		// (set) Token: 0x06003CA4 RID: 15524 RVA: 0x00057B50 File Offset: 0x00055D50
		public unsafe float MotionBlurPerObjectSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MotionBlurPerObjectSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MotionBlurPerObjectSize) = value;
			}
		}

		// Token: 0x17000ABE RID: 2750
		// (get) Token: 0x06003CA5 RID: 15525 RVA: 0x00057B61 File Offset: 0x00055D61
		// (set) Token: 0x06003CA6 RID: 15526 RVA: 0x00057B71 File Offset: 0x00055D71
		public unsafe bool bMotionBlurCharacterMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bMotionBlurCharacterMask) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_bMotionBlurCharacterMask) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000ABF RID: 2751
		// (get) Token: 0x06003CA7 RID: 15527 RVA: 0x00057B82 File Offset: 0x00055D82
		// (set) Token: 0x06003CA8 RID: 15528 RVA: 0x00057B92 File Offset: 0x00055D92
		public unsafe float LPVIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVIntensity) = value;
			}
		}

		// Token: 0x17000AC0 RID: 2752
		// (get) Token: 0x06003CA9 RID: 15529 RVA: 0x00057BA3 File Offset: 0x00055DA3
		// (set) Token: 0x06003CAA RID: 15530 RVA: 0x00057BB3 File Offset: 0x00055DB3
		public unsafe float LPVVplInjectionBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVVplInjectionBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVVplInjectionBias) = value;
			}
		}

		// Token: 0x17000AC1 RID: 2753
		// (get) Token: 0x06003CAB RID: 15531 RVA: 0x00057BC4 File Offset: 0x00055DC4
		// (set) Token: 0x06003CAC RID: 15532 RVA: 0x00057BD4 File Offset: 0x00055DD4
		public unsafe float LPVSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVSize) = value;
			}
		}

		// Token: 0x17000AC2 RID: 2754
		// (get) Token: 0x06003CAD RID: 15533 RVA: 0x00057BE5 File Offset: 0x00055DE5
		// (set) Token: 0x06003CAE RID: 15534 RVA: 0x00057BF5 File Offset: 0x00055DF5
		public unsafe float LPVSecondaryOcclusionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVSecondaryOcclusionIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVSecondaryOcclusionIntensity) = value;
			}
		}

		// Token: 0x17000AC3 RID: 2755
		// (get) Token: 0x06003CAF RID: 15535 RVA: 0x00057C06 File Offset: 0x00055E06
		// (set) Token: 0x06003CB0 RID: 15536 RVA: 0x00057C16 File Offset: 0x00055E16
		public unsafe float LPVSecondaryBounceIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVSecondaryBounceIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVSecondaryBounceIntensity) = value;
			}
		}

		// Token: 0x17000AC4 RID: 2756
		// (get) Token: 0x06003CB1 RID: 15537 RVA: 0x00057C27 File Offset: 0x00055E27
		// (set) Token: 0x06003CB2 RID: 15538 RVA: 0x00057C37 File Offset: 0x00055E37
		public unsafe float LPVGeometryVolumeBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVGeometryVolumeBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVGeometryVolumeBias) = value;
			}
		}

		// Token: 0x17000AC5 RID: 2757
		// (get) Token: 0x06003CB3 RID: 15539 RVA: 0x00057C48 File Offset: 0x00055E48
		// (set) Token: 0x06003CB4 RID: 15540 RVA: 0x00057C58 File Offset: 0x00055E58
		public unsafe float LPVEmissiveInjectionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVEmissiveInjectionIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVEmissiveInjectionIntensity) = value;
			}
		}

		// Token: 0x17000AC6 RID: 2758
		// (get) Token: 0x06003CB5 RID: 15541 RVA: 0x00057C69 File Offset: 0x00055E69
		// (set) Token: 0x06003CB6 RID: 15542 RVA: 0x00057C79 File Offset: 0x00055E79
		public unsafe float LPVDirectionalOcclusionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVDirectionalOcclusionIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVDirectionalOcclusionIntensity) = value;
			}
		}

		// Token: 0x17000AC7 RID: 2759
		// (get) Token: 0x06003CB7 RID: 15543 RVA: 0x00057C8A File Offset: 0x00055E8A
		// (set) Token: 0x06003CB8 RID: 15544 RVA: 0x00057C9A File Offset: 0x00055E9A
		public unsafe float LPVDirectionalOcclusionRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVDirectionalOcclusionRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVDirectionalOcclusionRadius) = value;
			}
		}

		// Token: 0x17000AC8 RID: 2760
		// (get) Token: 0x06003CB9 RID: 15545 RVA: 0x00057CAB File Offset: 0x00055EAB
		// (set) Token: 0x06003CBA RID: 15546 RVA: 0x00057CBB File Offset: 0x00055EBB
		public unsafe float LPVDiffuseOcclusionExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVDiffuseOcclusionExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVDiffuseOcclusionExponent) = value;
			}
		}

		// Token: 0x17000AC9 RID: 2761
		// (get) Token: 0x06003CBB RID: 15547 RVA: 0x00057CCC File Offset: 0x00055ECC
		// (set) Token: 0x06003CBC RID: 15548 RVA: 0x00057CDC File Offset: 0x00055EDC
		public unsafe float LPVSpecularOcclusionExponent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVSpecularOcclusionExponent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVSpecularOcclusionExponent) = value;
			}
		}

		// Token: 0x17000ACA RID: 2762
		// (get) Token: 0x06003CBD RID: 15549 RVA: 0x00057CED File Offset: 0x00055EED
		// (set) Token: 0x06003CBE RID: 15550 RVA: 0x00057CFD File Offset: 0x00055EFD
		public unsafe float LPVDiffuseOcclusionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVDiffuseOcclusionIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVDiffuseOcclusionIntensity) = value;
			}
		}

		// Token: 0x17000ACB RID: 2763
		// (get) Token: 0x06003CBF RID: 15551 RVA: 0x00057D0E File Offset: 0x00055F0E
		// (set) Token: 0x06003CC0 RID: 15552 RVA: 0x00057D1E File Offset: 0x00055F1E
		public unsafe float LPVSpecularOcclusionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVSpecularOcclusionIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVSpecularOcclusionIntensity) = value;
			}
		}

		// Token: 0x17000ACC RID: 2764
		// (get) Token: 0x06003CC1 RID: 15553 RVA: 0x00057D2F File Offset: 0x00055F2F
		// (set) Token: 0x06003CC2 RID: 15554 RVA: 0x00057D3F File Offset: 0x00055F3F
		public unsafe float ScreenSpaceReflectionIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenSpaceReflectionIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenSpaceReflectionIntensity) = value;
			}
		}

		// Token: 0x17000ACD RID: 2765
		// (get) Token: 0x06003CC3 RID: 15555 RVA: 0x00057D50 File Offset: 0x00055F50
		// (set) Token: 0x06003CC4 RID: 15556 RVA: 0x00057D60 File Offset: 0x00055F60
		public unsafe float ScreenSpaceReflectionQuality
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenSpaceReflectionQuality);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenSpaceReflectionQuality) = value;
			}
		}

		// Token: 0x17000ACE RID: 2766
		// (get) Token: 0x06003CC5 RID: 15557 RVA: 0x00057D71 File Offset: 0x00055F71
		// (set) Token: 0x06003CC6 RID: 15558 RVA: 0x00057D81 File Offset: 0x00055F81
		public unsafe float ScreenSpaceReflectionMaxRoughness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenSpaceReflectionMaxRoughness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenSpaceReflectionMaxRoughness) = value;
			}
		}

		// Token: 0x17000ACF RID: 2767
		// (get) Token: 0x06003CC7 RID: 15559 RVA: 0x00057D92 File Offset: 0x00055F92
		// (set) Token: 0x06003CC8 RID: 15560 RVA: 0x00057DA2 File Offset: 0x00055FA2
		public unsafe float RayTracingReflectionsMaxRoughness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingReflectionsMaxRoughness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingReflectionsMaxRoughness) = value;
			}
		}

		// Token: 0x17000AD0 RID: 2768
		// (get) Token: 0x06003CC9 RID: 15561 RVA: 0x00057DB3 File Offset: 0x00055FB3
		// (set) Token: 0x06003CCA RID: 15562 RVA: 0x00057DC3 File Offset: 0x00055FC3
		public unsafe int RayTracingReflectionsMaxBounces
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingReflectionsMaxBounces);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingReflectionsMaxBounces) = value;
			}
		}

		// Token: 0x17000AD1 RID: 2769
		// (get) Token: 0x06003CCB RID: 15563 RVA: 0x00057DD4 File Offset: 0x00055FD4
		// (set) Token: 0x06003CCC RID: 15564 RVA: 0x00057DE4 File Offset: 0x00055FE4
		public unsafe int RayTracingReflectionsSamplesPerPixel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingReflectionsSamplesPerPixel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingReflectionsSamplesPerPixel) = value;
			}
		}

		// Token: 0x17000AD2 RID: 2770
		// (get) Token: 0x06003CCD RID: 15565 RVA: 0x00057DF5 File Offset: 0x00055FF5
		// (set) Token: 0x06003CCE RID: 15566 RVA: 0x00057E0E File Offset: 0x0005600E
		public unsafe bool RayTracingReflectionsTranslucency
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingReflectionsTranslucency) & FPostProcessSettings.__PropertyMask_RayTracingReflectionsTranslucency) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingReflectionsTranslucency) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingReflectionsTranslucency) & ~FPostProcessSettings.__PropertyMask_RayTracingReflectionsTranslucency) | (value ? FPostProcessSettings.__PropertyMask_RayTracingReflectionsTranslucency : 0));
			}
		}

		// Token: 0x17000AD3 RID: 2771
		// (get) Token: 0x06003CCF RID: 15567 RVA: 0x00057E3E File Offset: 0x0005603E
		// (set) Token: 0x06003CD0 RID: 15568 RVA: 0x00057E4E File Offset: 0x0005604E
		public unsafe float RayTracingTranslucencyMaxRoughness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingTranslucencyMaxRoughness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingTranslucencyMaxRoughness) = value;
			}
		}

		// Token: 0x17000AD4 RID: 2772
		// (get) Token: 0x06003CD1 RID: 15569 RVA: 0x00057E5F File Offset: 0x0005605F
		// (set) Token: 0x06003CD2 RID: 15570 RVA: 0x00057E6F File Offset: 0x0005606F
		public unsafe int RayTracingTranslucencyRefractionRays
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingTranslucencyRefractionRays);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingTranslucencyRefractionRays) = value;
			}
		}

		// Token: 0x17000AD5 RID: 2773
		// (get) Token: 0x06003CD3 RID: 15571 RVA: 0x00057E80 File Offset: 0x00056080
		// (set) Token: 0x06003CD4 RID: 15572 RVA: 0x00057E90 File Offset: 0x00056090
		public unsafe int RayTracingTranslucencySamplesPerPixel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingTranslucencySamplesPerPixel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingTranslucencySamplesPerPixel) = value;
			}
		}

		// Token: 0x17000AD6 RID: 2774
		// (get) Token: 0x06003CD5 RID: 15573 RVA: 0x00057EA1 File Offset: 0x000560A1
		// (set) Token: 0x06003CD6 RID: 15574 RVA: 0x00057EBA File Offset: 0x000560BA
		public unsafe bool RayTracingTranslucencyRefraction
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingTranslucencyRefraction) & FPostProcessSettings.__PropertyMask_RayTracingTranslucencyRefraction) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingTranslucencyRefraction) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingTranslucencyRefraction) & ~FPostProcessSettings.__PropertyMask_RayTracingTranslucencyRefraction) | (value ? FPostProcessSettings.__PropertyMask_RayTracingTranslucencyRefraction : 0));
			}
		}

		// Token: 0x17000AD7 RID: 2775
		// (get) Token: 0x06003CD7 RID: 15575 RVA: 0x00057EEA File Offset: 0x000560EA
		// (set) Token: 0x06003CD8 RID: 15576 RVA: 0x00057EFA File Offset: 0x000560FA
		public unsafe int PathTracingMaxBounces
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_PathTracingMaxBounces);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_PathTracingMaxBounces) = value;
			}
		}

		// Token: 0x17000AD8 RID: 2776
		// (get) Token: 0x06003CD9 RID: 15577 RVA: 0x00057F0B File Offset: 0x0005610B
		// (set) Token: 0x06003CDA RID: 15578 RVA: 0x00057F1B File Offset: 0x0005611B
		public unsafe int PathTracingSamplesPerPixel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_PathTracingSamplesPerPixel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_PathTracingSamplesPerPixel) = value;
			}
		}

		// Token: 0x17000AD9 RID: 2777
		// (get) Token: 0x06003CDB RID: 15579 RVA: 0x00057F2C File Offset: 0x0005612C
		// (set) Token: 0x06003CDC RID: 15580 RVA: 0x00057F3C File Offset: 0x0005613C
		public unsafe float LPVFadeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVFadeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVFadeRange) = value;
			}
		}

		// Token: 0x17000ADA RID: 2778
		// (get) Token: 0x06003CDD RID: 15581 RVA: 0x00057F4D File Offset: 0x0005614D
		// (set) Token: 0x06003CDE RID: 15582 RVA: 0x00057F5D File Offset: 0x0005615D
		public unsafe float LPVDirectionalOcclusionFadeRange
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVDirectionalOcclusionFadeRange);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LPVDirectionalOcclusionFadeRange) = value;
			}
		}

		// Token: 0x17000ADB RID: 2779
		// (get) Token: 0x06003CDF RID: 15583 RVA: 0x00057F6E File Offset: 0x0005616E
		// (set) Token: 0x06003CE0 RID: 15584 RVA: 0x00057F7E File Offset: 0x0005617E
		public unsafe float ScreenPercentage
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenPercentage);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ScreenPercentage) = value;
			}
		}

		// Token: 0x17000ADC RID: 2780
		// (get) Token: 0x06003CE1 RID: 15585 RVA: 0x00057F8F File Offset: 0x0005618F
		// (set) Token: 0x06003CE2 RID: 15586 RVA: 0x00057F9F File Offset: 0x0005619F
		public unsafe bool WithOutTranslucent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_WithOutTranslucent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_WithOutTranslucent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000ADD RID: 2781
		// (get) Token: 0x06003CE3 RID: 15587 RVA: 0x00057FB0 File Offset: 0x000561B0
		// (set) Token: 0x06003CE4 RID: 15588 RVA: 0x00057FC0 File Offset: 0x000561C0
		public unsafe bool StartPosSwitch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_StartPosSwitch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_StartPosSwitch) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000ADE RID: 2782
		// (get) Token: 0x06003CE5 RID: 15589 RVA: 0x00057FD1 File Offset: 0x000561D1
		// (set) Token: 0x06003CE6 RID: 15590 RVA: 0x00057FE5 File Offset: 0x000561E5
		public unsafe FVector4 GrayGradationStartPos
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_GrayGradationStartPos);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_GrayGradationStartPos) = value;
			}
		}

		// Token: 0x17000ADF RID: 2783
		// (get) Token: 0x06003CE7 RID: 15591 RVA: 0x00057FFA File Offset: 0x000561FA
		// (set) Token: 0x06003CE8 RID: 15592 RVA: 0x0005800A File Offset: 0x0005620A
		public unsafe float GrayGradationDegree
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_GrayGradationDegree);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_GrayGradationDegree) = value;
			}
		}

		// Token: 0x17000AE0 RID: 2784
		// (get) Token: 0x06003CE9 RID: 15593 RVA: 0x0005801B File Offset: 0x0005621B
		// (set) Token: 0x06003CEA RID: 15594 RVA: 0x0005802B File Offset: 0x0005622B
		public unsafe float GrayLerpWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_GrayLerpWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_GrayLerpWidth) = value;
			}
		}

		// Token: 0x17000AE1 RID: 2785
		// (get) Token: 0x06003CEB RID: 15595 RVA: 0x0005803C File Offset: 0x0005623C
		// (set) Token: 0x06003CEC RID: 15596 RVA: 0x00058050 File Offset: 0x00056250
		public unsafe UTexture2D GrayRampColor
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_GrayRampColor);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_GrayRampColor, value);
			}
		}

		// Token: 0x17000AE2 RID: 2786
		// (get) Token: 0x06003CED RID: 15597 RVA: 0x00058065 File Offset: 0x00056265
		// (set) Token: 0x06003CEE RID: 15598 RVA: 0x00058079 File Offset: 0x00056279
		public unsafe FLinearColor GrayRampTint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_GrayRampTint);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_GrayRampTint) = value;
			}
		}

		// Token: 0x17000AE3 RID: 2787
		// (get) Token: 0x06003CEF RID: 15599 RVA: 0x0005808E File Offset: 0x0005628E
		// (set) Token: 0x06003CF0 RID: 15600 RVA: 0x0005809E File Offset: 0x0005629E
		public unsafe float GrayRampBlendWeight
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_GrayRampBlendWeight);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_GrayRampBlendWeight) = value;
			}
		}

		// Token: 0x17000AE4 RID: 2788
		// (get) Token: 0x06003CF1 RID: 15601 RVA: 0x000580AF File Offset: 0x000562AF
		// (set) Token: 0x06003CF2 RID: 15602 RVA: 0x000580BF File Offset: 0x000562BF
		public unsafe int SNNIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SNNIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SNNIntensity) = value;
			}
		}

		// Token: 0x17000AE5 RID: 2789
		// (get) Token: 0x06003CF3 RID: 15603 RVA: 0x000580D0 File Offset: 0x000562D0
		// (set) Token: 0x06003CF4 RID: 15604 RVA: 0x000580E0 File Offset: 0x000562E0
		public unsafe float SNNRoughnessContrast
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SNNRoughnessContrast);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SNNRoughnessContrast) = value;
			}
		}

		// Token: 0x17000AE6 RID: 2790
		// (get) Token: 0x06003CF5 RID: 15605 RVA: 0x000580F1 File Offset: 0x000562F1
		// (set) Token: 0x06003CF6 RID: 15606 RVA: 0x00058101 File Offset: 0x00056301
		public unsafe float SNNMetallicThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SNNMetallicThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SNNMetallicThreshold) = value;
			}
		}

		// Token: 0x17000AE7 RID: 2791
		// (get) Token: 0x06003CF7 RID: 15607 RVA: 0x00058112 File Offset: 0x00056312
		// (set) Token: 0x06003CF8 RID: 15608 RVA: 0x00058122 File Offset: 0x00056322
		public unsafe float SNNDepthFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SNNDepthFade);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SNNDepthFade) = value;
			}
		}

		// Token: 0x17000AE8 RID: 2792
		// (get) Token: 0x06003CF9 RID: 15609 RVA: 0x00058133 File Offset: 0x00056333
		// (set) Token: 0x06003CFA RID: 15610 RVA: 0x00058143 File Offset: 0x00056343
		public unsafe float SNNFoliageIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SNNFoliageIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SNNFoliageIntensity) = value;
			}
		}

		// Token: 0x17000AE9 RID: 2793
		// (get) Token: 0x06003CFB RID: 15611 RVA: 0x00058154 File Offset: 0x00056354
		// (set) Token: 0x06003CFC RID: 15612 RVA: 0x00058164 File Offset: 0x00056364
		public unsafe float SNNStructureIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SNNStructureIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SNNStructureIntensity) = value;
			}
		}

		// Token: 0x17000AEA RID: 2794
		// (get) Token: 0x06003CFD RID: 15613 RVA: 0x00058175 File Offset: 0x00056375
		// (set) Token: 0x06003CFE RID: 15614 RVA: 0x00058185 File Offset: 0x00056385
		public unsafe float SNNNoiseIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SNNNoiseIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SNNNoiseIntensity) = value;
			}
		}

		// Token: 0x17000AEB RID: 2795
		// (get) Token: 0x06003CFF RID: 15615 RVA: 0x00058196 File Offset: 0x00056396
		// (set) Token: 0x06003D00 RID: 15616 RVA: 0x000581A6 File Offset: 0x000563A6
		public unsafe bool SNNEnableSharpen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SNNEnableSharpen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SNNEnableSharpen) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000AEC RID: 2796
		// (get) Token: 0x06003D01 RID: 15617 RVA: 0x000581B7 File Offset: 0x000563B7
		// (set) Token: 0x06003D02 RID: 15618 RVA: 0x000581C7 File Offset: 0x000563C7
		public unsafe float SNNSharpeness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SNNSharpeness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SNNSharpeness) = value;
			}
		}

		// Token: 0x17000AED RID: 2797
		// (get) Token: 0x06003D03 RID: 15619 RVA: 0x000581D8 File Offset: 0x000563D8
		// (set) Token: 0x06003D04 RID: 15620 RVA: 0x000581E8 File Offset: 0x000563E8
		public unsafe float SNNSharpenDepthFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SNNSharpenDepthFade);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SNNSharpenDepthFade) = value;
			}
		}

		// Token: 0x17000AEE RID: 2798
		// (get) Token: 0x06003D05 RID: 15621 RVA: 0x000581F9 File Offset: 0x000563F9
		// (set) Token: 0x06003D06 RID: 15622 RVA: 0x00058209 File Offset: 0x00056409
		public unsafe float SSFSIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SSFSIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SSFSIntensity) = value;
			}
		}

		// Token: 0x17000AEF RID: 2799
		// (get) Token: 0x06003D07 RID: 15623 RVA: 0x0005821A File Offset: 0x0005641A
		// (set) Token: 0x06003D08 RID: 15624 RVA: 0x0005822A File Offset: 0x0005642A
		public unsafe float SSFSRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SSFSRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SSFSRadius) = value;
			}
		}

		// Token: 0x17000AF0 RID: 2800
		// (get) Token: 0x06003D09 RID: 15625 RVA: 0x0005823B File Offset: 0x0005643B
		// (set) Token: 0x06003D0A RID: 15626 RVA: 0x0005824B File Offset: 0x0005644B
		public unsafe bool SSFSLuminanceWeighting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SSFSLuminanceWeighting) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SSFSLuminanceWeighting) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000AF1 RID: 2801
		// (get) Token: 0x06003D0B RID: 15627 RVA: 0x0005825C File Offset: 0x0005645C
		// (set) Token: 0x06003D0C RID: 15628 RVA: 0x0005826C File Offset: 0x0005646C
		public unsafe float SSFSSkyAtmosphereIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SSFSSkyAtmosphereIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SSFSSkyAtmosphereIntensity) = value;
			}
		}

		// Token: 0x17000AF2 RID: 2802
		// (get) Token: 0x06003D0D RID: 15629 RVA: 0x0005827D File Offset: 0x0005647D
		// (set) Token: 0x06003D0E RID: 15630 RVA: 0x0005828D File Offset: 0x0005648D
		public unsafe float SSFSVolumetricFogILSIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SSFSVolumetricFogILSIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SSFSVolumetricFogILSIntensity) = value;
			}
		}

		// Token: 0x17000AF3 RID: 2803
		// (get) Token: 0x06003D0F RID: 15631 RVA: 0x0005829E File Offset: 0x0005649E
		// (set) Token: 0x06003D10 RID: 15632 RVA: 0x000582AE File Offset: 0x000564AE
		public unsafe float SSFSKuroVolumetricLightILSIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SSFSKuroVolumetricLightILSIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SSFSKuroVolumetricLightILSIntensity) = value;
			}
		}

		// Token: 0x17000AF4 RID: 2804
		// (get) Token: 0x06003D11 RID: 15633 RVA: 0x000582BF File Offset: 0x000564BF
		// (set) Token: 0x06003D12 RID: 15634 RVA: 0x000582CF File Offset: 0x000564CF
		public unsafe float SSFSStartDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SSFSStartDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SSFSStartDistance) = value;
			}
		}

		// Token: 0x17000AF5 RID: 2805
		// (get) Token: 0x06003D13 RID: 15635 RVA: 0x000582E0 File Offset: 0x000564E0
		// (set) Token: 0x06003D14 RID: 15636 RVA: 0x000582F0 File Offset: 0x000564F0
		public unsafe float SSFSMaxDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SSFSMaxDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_SSFSMaxDepth) = value;
			}
		}

		// Token: 0x17000AF6 RID: 2806
		// (get) Token: 0x06003D15 RID: 15637 RVA: 0x00058301 File Offset: 0x00056501
		// (set) Token: 0x06003D16 RID: 15638 RVA: 0x0005831A File Offset: 0x0005651A
		public unsafe bool EnableMobileSSFS
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EnableMobileSSFS) & FPostProcessSettings.__PropertyMask_EnableMobileSSFS) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EnableMobileSSFS) = ((*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EnableMobileSSFS) & ~FPostProcessSettings.__PropertyMask_EnableMobileSSFS) | (value ? FPostProcessSettings.__PropertyMask_EnableMobileSSFS : 0));
			}
		}

		// Token: 0x17000AF7 RID: 2807
		// (get) Token: 0x06003D17 RID: 15639 RVA: 0x0005834A File Offset: 0x0005654A
		// (set) Token: 0x06003D18 RID: 15640 RVA: 0x0005835A File Offset: 0x0005655A
		public unsafe float MobileSSFSFogDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MobileSSFSFogDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MobileSSFSFogDensity) = value;
			}
		}

		// Token: 0x17000AF8 RID: 2808
		// (get) Token: 0x06003D19 RID: 15641 RVA: 0x0005836B File Offset: 0x0005656B
		// (set) Token: 0x06003D1A RID: 15642 RVA: 0x0005837B File Offset: 0x0005657B
		public unsafe float MobileSSFSIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MobileSSFSIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MobileSSFSIntensity) = value;
			}
		}

		// Token: 0x17000AF9 RID: 2809
		// (get) Token: 0x06003D1B RID: 15643 RVA: 0x0005838C File Offset: 0x0005658C
		// (set) Token: 0x06003D1C RID: 15644 RVA: 0x0005839C File Offset: 0x0005659C
		public unsafe float MobileSSFSRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MobileSSFSRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MobileSSFSRadius) = value;
			}
		}

		// Token: 0x17000AFA RID: 2810
		// (get) Token: 0x06003D1D RID: 15645 RVA: 0x000583AD File Offset: 0x000565AD
		// (set) Token: 0x06003D1E RID: 15646 RVA: 0x000583BD File Offset: 0x000565BD
		public unsafe float MobileSSFSStartDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MobileSSFSStartDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_MobileSSFSStartDistance) = value;
			}
		}

		// Token: 0x17000AFB RID: 2811
		// (get) Token: 0x06003D1F RID: 15647 RVA: 0x000583CE File Offset: 0x000565CE
		// (set) Token: 0x06003D20 RID: 15648 RVA: 0x000583DE File Offset: 0x000565DE
		public unsafe float KuroSharpenRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroSharpenRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroSharpenRadius) = value;
			}
		}

		// Token: 0x17000AFC RID: 2812
		// (get) Token: 0x06003D21 RID: 15649 RVA: 0x000583EF File Offset: 0x000565EF
		// (set) Token: 0x06003D22 RID: 15650 RVA: 0x000583FF File Offset: 0x000565FF
		public unsafe float KuroSharpenAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroSharpenAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroSharpenAmount) = value;
			}
		}

		// Token: 0x17000AFD RID: 2813
		// (get) Token: 0x06003D23 RID: 15651 RVA: 0x00058410 File Offset: 0x00056610
		// (set) Token: 0x06003D24 RID: 15652 RVA: 0x00058420 File Offset: 0x00056620
		public unsafe float KuroLaplacianAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroLaplacianAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroLaplacianAmount) = value;
			}
		}

		// Token: 0x17000AFE RID: 2814
		// (get) Token: 0x06003D25 RID: 15653 RVA: 0x00058431 File Offset: 0x00056631
		// (set) Token: 0x06003D26 RID: 15654 RVA: 0x00058441 File Offset: 0x00056641
		public unsafe float KuroSharpenIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroSharpenIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroSharpenIntensity) = value;
			}
		}

		// Token: 0x17000AFF RID: 2815
		// (get) Token: 0x06003D27 RID: 15655 RVA: 0x00058452 File Offset: 0x00056652
		// (set) Token: 0x06003D28 RID: 15656 RVA: 0x00058462 File Offset: 0x00056662
		public unsafe float KuroToonSharpenIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroToonSharpenIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroToonSharpenIntensity) = value;
			}
		}

		// Token: 0x17000B00 RID: 2816
		// (get) Token: 0x06003D29 RID: 15657 RVA: 0x00058473 File Offset: 0x00056673
		// (set) Token: 0x06003D2A RID: 15658 RVA: 0x00058483 File Offset: 0x00056683
		public unsafe float KuroSharpenDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroSharpenDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroSharpenDistance) = value;
			}
		}

		// Token: 0x17000B01 RID: 2817
		// (get) Token: 0x06003D2B RID: 15659 RVA: 0x00058494 File Offset: 0x00056694
		// (set) Token: 0x06003D2C RID: 15660 RVA: 0x000584A4 File Offset: 0x000566A4
		public unsafe float TyndallScaLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TyndallScaLightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TyndallScaLightIntensity) = value;
			}
		}

		// Token: 0x17000B02 RID: 2818
		// (get) Token: 0x06003D2D RID: 15661 RVA: 0x000584B5 File Offset: 0x000566B5
		// (set) Token: 0x06003D2E RID: 15662 RVA: 0x000584C5 File Offset: 0x000566C5
		public unsafe float TyndallDarkIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TyndallDarkIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TyndallDarkIntensity) = value;
			}
		}

		// Token: 0x17000B03 RID: 2819
		// (get) Token: 0x06003D2F RID: 15663 RVA: 0x000584D6 File Offset: 0x000566D6
		// (set) Token: 0x06003D30 RID: 15664 RVA: 0x000584E6 File Offset: 0x000566E6
		public unsafe float TyndallScaLightLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TyndallScaLightLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TyndallScaLightLength) = value;
			}
		}

		// Token: 0x17000B04 RID: 2820
		// (get) Token: 0x06003D31 RID: 15665 RVA: 0x000584F7 File Offset: 0x000566F7
		// (set) Token: 0x06003D32 RID: 15666 RVA: 0x0005850B File Offset: 0x0005670B
		public unsafe FLinearColor TyndallScaLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TyndallScaLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TyndallScaLightColor) = value;
			}
		}

		// Token: 0x17000B05 RID: 2821
		// (get) Token: 0x06003D33 RID: 15667 RVA: 0x00058520 File Offset: 0x00056720
		// (set) Token: 0x06003D34 RID: 15668 RVA: 0x00058530 File Offset: 0x00056730
		public unsafe float TyndallScaLightFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TyndallScaLightFade);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TyndallScaLightFade) = value;
			}
		}

		// Token: 0x17000B06 RID: 2822
		// (get) Token: 0x06003D35 RID: 15669 RVA: 0x00058541 File Offset: 0x00056741
		// (set) Token: 0x06003D36 RID: 15670 RVA: 0x00058551 File Offset: 0x00056751
		public unsafe bool TyndallScaLightMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TyndallScaLightMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TyndallScaLightMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000B07 RID: 2823
		// (get) Token: 0x06003D37 RID: 15671 RVA: 0x00058562 File Offset: 0x00056762
		// (set) Token: 0x06003D38 RID: 15672 RVA: 0x00058572 File Offset: 0x00056772
		public unsafe float TyndallScaNearFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TyndallScaNearFade);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TyndallScaNearFade) = value;
			}
		}

		// Token: 0x17000B08 RID: 2824
		// (get) Token: 0x06003D39 RID: 15673 RVA: 0x00058583 File Offset: 0x00056783
		// (set) Token: 0x06003D3A RID: 15674 RVA: 0x00058593 File Offset: 0x00056793
		public unsafe float TyndallScaDarkFadeDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TyndallScaDarkFadeDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TyndallScaDarkFadeDepth) = value;
			}
		}

		// Token: 0x17000B09 RID: 2825
		// (get) Token: 0x06003D3B RID: 15675 RVA: 0x000585A4 File Offset: 0x000567A4
		// (set) Token: 0x06003D3C RID: 15676 RVA: 0x000585B4 File Offset: 0x000567B4
		public unsafe float TyndallScaMaxDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TyndallScaMaxDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TyndallScaMaxDepth) = value;
			}
		}

		// Token: 0x17000B0A RID: 2826
		// (get) Token: 0x06003D3D RID: 15677 RVA: 0x000585C5 File Offset: 0x000567C5
		// (set) Token: 0x06003D3E RID: 15678 RVA: 0x000585D5 File Offset: 0x000567D5
		public unsafe bool EnableCustomPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EnableCustomPosition) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_EnableCustomPosition) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000B0B RID: 2827
		// (get) Token: 0x06003D3F RID: 15679 RVA: 0x000585E6 File Offset: 0x000567E6
		// (set) Token: 0x06003D40 RID: 15680 RVA: 0x000585FA File Offset: 0x000567FA
		public unsafe FVector TyndallCustomPosition
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TyndallCustomPosition);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TyndallCustomPosition) = value;
			}
		}

		// Token: 0x17000B0C RID: 2828
		// (get) Token: 0x06003D41 RID: 15681 RVA: 0x0005860F File Offset: 0x0005680F
		// (set) Token: 0x06003D42 RID: 15682 RVA: 0x0005861F File Offset: 0x0005681F
		public unsafe bool KuroVolumetricLightEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroVolumetricLightEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroVolumetricLightEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000B0D RID: 2829
		// (get) Token: 0x06003D43 RID: 15683 RVA: 0x00058630 File Offset: 0x00056830
		// (set) Token: 0x06003D44 RID: 15684 RVA: 0x00058640 File Offset: 0x00056840
		public unsafe float KuroVolumetricLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroVolumetricLightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroVolumetricLightIntensity) = value;
			}
		}

		// Token: 0x17000B0E RID: 2830
		// (get) Token: 0x06003D45 RID: 15685 RVA: 0x00058651 File Offset: 0x00056851
		// (set) Token: 0x06003D46 RID: 15686 RVA: 0x00058665 File Offset: 0x00056865
		public unsafe FLinearColor KuroVolumetricLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroVolumetricLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroVolumetricLightColor) = value;
			}
		}

		// Token: 0x17000B0F RID: 2831
		// (get) Token: 0x06003D47 RID: 15687 RVA: 0x0005867A File Offset: 0x0005687A
		// (set) Token: 0x06003D48 RID: 15688 RVA: 0x0005868A File Offset: 0x0005688A
		public unsafe float KuroVolumetricLightPhaseG
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroVolumetricLightPhaseG);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroVolumetricLightPhaseG) = value;
			}
		}

		// Token: 0x17000B10 RID: 2832
		// (get) Token: 0x06003D49 RID: 15689 RVA: 0x0005869B File Offset: 0x0005689B
		// (set) Token: 0x06003D4A RID: 15690 RVA: 0x000586AB File Offset: 0x000568AB
		public unsafe float KuroVolumetricLightMaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroVolumetricLightMaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroVolumetricLightMaxDistance) = value;
			}
		}

		// Token: 0x17000B11 RID: 2833
		// (get) Token: 0x06003D4B RID: 15691 RVA: 0x000586BC File Offset: 0x000568BC
		// (set) Token: 0x06003D4C RID: 15692 RVA: 0x000586CC File Offset: 0x000568CC
		public unsafe int KuroVolumetricLightBlurRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroVolumetricLightBlurRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroVolumetricLightBlurRadius) = value;
			}
		}

		// Token: 0x17000B12 RID: 2834
		// (get) Token: 0x06003D4D RID: 15693 RVA: 0x000586DD File Offset: 0x000568DD
		// (set) Token: 0x06003D4E RID: 15694 RVA: 0x000586ED File Offset: 0x000568ED
		public unsafe bool KuroVolumetricLightUseColorMask
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroVolumetricLightUseColorMask) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroVolumetricLightUseColorMask) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000B13 RID: 2835
		// (get) Token: 0x06003D4F RID: 15695 RVA: 0x000586FE File Offset: 0x000568FE
		// (set) Token: 0x06003D50 RID: 15696 RVA: 0x0005870E File Offset: 0x0005690E
		public unsafe float KuroVolumetricLightColorMaskIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroVolumetricLightColorMaskIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroVolumetricLightColorMaskIntensity) = value;
			}
		}

		// Token: 0x17000B14 RID: 2836
		// (get) Token: 0x06003D51 RID: 15697 RVA: 0x0005871F File Offset: 0x0005691F
		// (set) Token: 0x06003D52 RID: 15698 RVA: 0x0005872F File Offset: 0x0005692F
		public unsafe bool KuroCharacterLUTSplitEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroCharacterLUTSplitEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroCharacterLUTSplitEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000B15 RID: 2837
		// (get) Token: 0x06003D53 RID: 15699 RVA: 0x00058740 File Offset: 0x00056940
		// (set) Token: 0x06003D54 RID: 15700 RVA: 0x00058754 File Offset: 0x00056954
		public unsafe UTexture KuroCharacterColorGradingLUT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_KuroCharacterColorGradingLUT);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FPostProcessSettings.__PropertyOffset_KuroCharacterColorGradingLUT, value);
			}
		}

		// Token: 0x17000B16 RID: 2838
		// (get) Token: 0x06003D55 RID: 15701 RVA: 0x00058769 File Offset: 0x00056969
		// (set) Token: 0x06003D56 RID: 15702 RVA: 0x00058779 File Offset: 0x00056979
		public unsafe float KuroCharacterColorGradingLUTLerpIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroCharacterColorGradingLUTLerpIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroCharacterColorGradingLUTLerpIntensity) = value;
			}
		}

		// Token: 0x17000B17 RID: 2839
		// (get) Token: 0x06003D57 RID: 15703 RVA: 0x0005878A File Offset: 0x0005698A
		// (set) Token: 0x06003D58 RID: 15704 RVA: 0x0005879A File Offset: 0x0005699A
		public unsafe bool KuroColorGradingTextureLUTInterpolationEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroColorGradingTextureLUTInterpolationEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_KuroColorGradingTextureLUTInterpolationEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x06003D59 RID: 15705 RVA: 0x000587AB File Offset: 0x000569AB
		public FPostProcessSettings()
		{
		}

		// Token: 0x06003D5A RID: 15706 RVA: 0x000587B3 File Offset: 0x000569B3
		protected override IntPtr GetUStructPtr()
		{
			return FPostProcessSettings.StaticStruct();
		}

		// Token: 0x06003D5B RID: 15707 RVA: 0x000587BF File Offset: 0x000569BF
		public FPostProcessSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003D5C RID: 15708 RVA: 0x000587C9 File Offset: 0x000569C9
		public FPostProcessSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003D5D RID: 15709 RVA: 0x000587D4 File Offset: 0x000569D4
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPostProcessSettings(Pointer, false, true);
		}

		// Token: 0x06003D5E RID: 15710 RVA: 0x000587DE File Offset: 0x000569DE
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPostProcessSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040012ED RID: 4845
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PostProcessSettings";

		// Token: 0x040012EE RID: 4846
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040012EF RID: 4847
		internal static int __PropertyOffset_bOverride_WhiteTemp;

		// Token: 0x040012F0 RID: 4848
		internal static byte __PropertyMask_bOverride_WhiteTemp;

		// Token: 0x040012F1 RID: 4849
		internal static int __PropertyOffset_bOverride_WhiteTint;

		// Token: 0x040012F2 RID: 4850
		internal static byte __PropertyMask_bOverride_WhiteTint;

		// Token: 0x040012F3 RID: 4851
		internal static int __PropertyOffset_bOverride_ColorSaturation;

		// Token: 0x040012F4 RID: 4852
		internal static byte __PropertyMask_bOverride_ColorSaturation;

		// Token: 0x040012F5 RID: 4853
		internal static int __PropertyOffset_bOverride_ColorContrast;

		// Token: 0x040012F6 RID: 4854
		internal static byte __PropertyMask_bOverride_ColorContrast;

		// Token: 0x040012F7 RID: 4855
		internal static int __PropertyOffset_bOverride_ColorGamma;

		// Token: 0x040012F8 RID: 4856
		internal static byte __PropertyMask_bOverride_ColorGamma;

		// Token: 0x040012F9 RID: 4857
		internal static int __PropertyOffset_bOverride_ColorGain;

		// Token: 0x040012FA RID: 4858
		internal static byte __PropertyMask_bOverride_ColorGain;

		// Token: 0x040012FB RID: 4859
		internal static int __PropertyOffset_bOverride_ColorOffset;

		// Token: 0x040012FC RID: 4860
		internal static byte __PropertyMask_bOverride_ColorOffset;

		// Token: 0x040012FD RID: 4861
		internal static int __PropertyOffset_bOverride_ColorSaturationShadows;

		// Token: 0x040012FE RID: 4862
		internal static byte __PropertyMask_bOverride_ColorSaturationShadows;

		// Token: 0x040012FF RID: 4863
		internal static int __PropertyOffset_bOverride_ColorContrastShadows;

		// Token: 0x04001300 RID: 4864
		internal static byte __PropertyMask_bOverride_ColorContrastShadows;

		// Token: 0x04001301 RID: 4865
		internal static int __PropertyOffset_bOverride_ColorGammaShadows;

		// Token: 0x04001302 RID: 4866
		internal static byte __PropertyMask_bOverride_ColorGammaShadows;

		// Token: 0x04001303 RID: 4867
		internal static int __PropertyOffset_bOverride_ColorGainShadows;

		// Token: 0x04001304 RID: 4868
		internal static byte __PropertyMask_bOverride_ColorGainShadows;

		// Token: 0x04001305 RID: 4869
		internal static int __PropertyOffset_bOverride_ColorOffsetShadows;

		// Token: 0x04001306 RID: 4870
		internal static byte __PropertyMask_bOverride_ColorOffsetShadows;

		// Token: 0x04001307 RID: 4871
		internal static int __PropertyOffset_bOverride_ColorSaturationMidtones;

		// Token: 0x04001308 RID: 4872
		internal static byte __PropertyMask_bOverride_ColorSaturationMidtones;

		// Token: 0x04001309 RID: 4873
		internal static int __PropertyOffset_bOverride_ColorContrastMidtones;

		// Token: 0x0400130A RID: 4874
		internal static byte __PropertyMask_bOverride_ColorContrastMidtones;

		// Token: 0x0400130B RID: 4875
		internal static int __PropertyOffset_bOverride_ColorGammaMidtones;

		// Token: 0x0400130C RID: 4876
		internal static byte __PropertyMask_bOverride_ColorGammaMidtones;

		// Token: 0x0400130D RID: 4877
		internal static int __PropertyOffset_bOverride_ColorGainMidtones;

		// Token: 0x0400130E RID: 4878
		internal static byte __PropertyMask_bOverride_ColorGainMidtones;

		// Token: 0x0400130F RID: 4879
		internal static int __PropertyOffset_bOverride_ColorOffsetMidtones;

		// Token: 0x04001310 RID: 4880
		internal static byte __PropertyMask_bOverride_ColorOffsetMidtones;

		// Token: 0x04001311 RID: 4881
		internal static int __PropertyOffset_bOverride_ColorSaturationHighlights;

		// Token: 0x04001312 RID: 4882
		internal static byte __PropertyMask_bOverride_ColorSaturationHighlights;

		// Token: 0x04001313 RID: 4883
		internal static int __PropertyOffset_bOverride_ColorContrastHighlights;

		// Token: 0x04001314 RID: 4884
		internal static byte __PropertyMask_bOverride_ColorContrastHighlights;

		// Token: 0x04001315 RID: 4885
		internal static int __PropertyOffset_bOverride_ColorGammaHighlights;

		// Token: 0x04001316 RID: 4886
		internal static byte __PropertyMask_bOverride_ColorGammaHighlights;

		// Token: 0x04001317 RID: 4887
		internal static int __PropertyOffset_bOverride_ColorGainHighlights;

		// Token: 0x04001318 RID: 4888
		internal static byte __PropertyMask_bOverride_ColorGainHighlights;

		// Token: 0x04001319 RID: 4889
		internal static int __PropertyOffset_bOverride_ColorOffsetHighlights;

		// Token: 0x0400131A RID: 4890
		internal static byte __PropertyMask_bOverride_ColorOffsetHighlights;

		// Token: 0x0400131B RID: 4891
		internal static int __PropertyOffset_bOverride_ColorCorrectionShadowsMax;

		// Token: 0x0400131C RID: 4892
		internal static byte __PropertyMask_bOverride_ColorCorrectionShadowsMax;

		// Token: 0x0400131D RID: 4893
		internal static int __PropertyOffset_bOverride_ColorCorrectionHighlightsMin;

		// Token: 0x0400131E RID: 4894
		internal static byte __PropertyMask_bOverride_ColorCorrectionHighlightsMin;

		// Token: 0x0400131F RID: 4895
		internal static int __PropertyOffset_bOverride_BlueCorrection;

		// Token: 0x04001320 RID: 4896
		internal static byte __PropertyMask_bOverride_BlueCorrection;

		// Token: 0x04001321 RID: 4897
		internal static int __PropertyOffset_bOverride_ExpandGamut;

		// Token: 0x04001322 RID: 4898
		internal static byte __PropertyMask_bOverride_ExpandGamut;

		// Token: 0x04001323 RID: 4899
		internal static int __PropertyOffset_bOverride_ToneCurveAmount;

		// Token: 0x04001324 RID: 4900
		internal static byte __PropertyMask_bOverride_ToneCurveAmount;

		// Token: 0x04001325 RID: 4901
		internal static int __PropertyOffset_bOverride_FilmWhitePoint;

		// Token: 0x04001326 RID: 4902
		internal static byte __PropertyMask_bOverride_FilmWhitePoint;

		// Token: 0x04001327 RID: 4903
		internal static int __PropertyOffset_bOverride_FilmSaturation;

		// Token: 0x04001328 RID: 4904
		internal static byte __PropertyMask_bOverride_FilmSaturation;

		// Token: 0x04001329 RID: 4905
		internal static int __PropertyOffset_bOverride_FilmChannelMixerRed;

		// Token: 0x0400132A RID: 4906
		internal static byte __PropertyMask_bOverride_FilmChannelMixerRed;

		// Token: 0x0400132B RID: 4907
		internal static int __PropertyOffset_bOverride_FilmChannelMixerGreen;

		// Token: 0x0400132C RID: 4908
		internal static byte __PropertyMask_bOverride_FilmChannelMixerGreen;

		// Token: 0x0400132D RID: 4909
		internal static int __PropertyOffset_bOverride_FilmChannelMixerBlue;

		// Token: 0x0400132E RID: 4910
		internal static byte __PropertyMask_bOverride_FilmChannelMixerBlue;

		// Token: 0x0400132F RID: 4911
		internal static int __PropertyOffset_bOverride_FilmContrast;

		// Token: 0x04001330 RID: 4912
		internal static byte __PropertyMask_bOverride_FilmContrast;

		// Token: 0x04001331 RID: 4913
		internal static int __PropertyOffset_bOverride_FilmDynamicRange;

		// Token: 0x04001332 RID: 4914
		internal static byte __PropertyMask_bOverride_FilmDynamicRange;

		// Token: 0x04001333 RID: 4915
		internal static int __PropertyOffset_bOverride_FilmHealAmount;

		// Token: 0x04001334 RID: 4916
		internal static byte __PropertyMask_bOverride_FilmHealAmount;

		// Token: 0x04001335 RID: 4917
		internal static int __PropertyOffset_bOverride_FilmToeAmount;

		// Token: 0x04001336 RID: 4918
		internal static byte __PropertyMask_bOverride_FilmToeAmount;

		// Token: 0x04001337 RID: 4919
		internal static int __PropertyOffset_bOverride_FilmShadowTint;

		// Token: 0x04001338 RID: 4920
		internal static byte __PropertyMask_bOverride_FilmShadowTint;

		// Token: 0x04001339 RID: 4921
		internal static int __PropertyOffset_bOverride_FilmShadowTintBlend;

		// Token: 0x0400133A RID: 4922
		internal static byte __PropertyMask_bOverride_FilmShadowTintBlend;

		// Token: 0x0400133B RID: 4923
		internal static int __PropertyOffset_bOverride_FilmShadowTintAmount;

		// Token: 0x0400133C RID: 4924
		internal static byte __PropertyMask_bOverride_FilmShadowTintAmount;

		// Token: 0x0400133D RID: 4925
		internal static int __PropertyOffset_bOverride_FilmSlope;

		// Token: 0x0400133E RID: 4926
		internal static byte __PropertyMask_bOverride_FilmSlope;

		// Token: 0x0400133F RID: 4927
		internal static int __PropertyOffset_bOverride_FilmToe;

		// Token: 0x04001340 RID: 4928
		internal static byte __PropertyMask_bOverride_FilmToe;

		// Token: 0x04001341 RID: 4929
		internal static int __PropertyOffset_bOverride_FilmShoulder;

		// Token: 0x04001342 RID: 4930
		internal static byte __PropertyMask_bOverride_FilmShoulder;

		// Token: 0x04001343 RID: 4931
		internal static int __PropertyOffset_bOverride_FilmBlackClip;

		// Token: 0x04001344 RID: 4932
		internal static byte __PropertyMask_bOverride_FilmBlackClip;

		// Token: 0x04001345 RID: 4933
		internal static int __PropertyOffset_bOverride_FilmWhiteClip;

		// Token: 0x04001346 RID: 4934
		internal static byte __PropertyMask_bOverride_FilmWhiteClip;

		// Token: 0x04001347 RID: 4935
		internal static int __PropertyOffset_bOverride_SceneColorTint;

		// Token: 0x04001348 RID: 4936
		internal static byte __PropertyMask_bOverride_SceneColorTint;

		// Token: 0x04001349 RID: 4937
		internal static int __PropertyOffset_bOverride_DecalSaturation;

		// Token: 0x0400134A RID: 4938
		internal static byte __PropertyMask_bOverride_DecalSaturation;

		// Token: 0x0400134B RID: 4939
		internal static int __PropertyOffset_bOverride_DecalOpacity;

		// Token: 0x0400134C RID: 4940
		internal static byte __PropertyMask_bOverride_DecalOpacity;

		// Token: 0x0400134D RID: 4941
		internal static int __PropertyOffset_bOverride_TranslucentColorTint;

		// Token: 0x0400134E RID: 4942
		internal static byte __PropertyMask_bOverride_TranslucentColorTint;

		// Token: 0x0400134F RID: 4943
		internal static int __PropertyOffset_bOverride_SceneColorDesaturate;

		// Token: 0x04001350 RID: 4944
		internal static byte __PropertyMask_bOverride_SceneColorDesaturate;

		// Token: 0x04001351 RID: 4945
		internal static int __PropertyOffset_bOverride_SceneObjectSaturation;

		// Token: 0x04001352 RID: 4946
		internal static byte __PropertyMask_bOverride_SceneObjectSaturation;

		// Token: 0x04001353 RID: 4947
		internal static int __PropertyOffset_bOverride_SceneColorClear;

		// Token: 0x04001354 RID: 4948
		internal static byte __PropertyMask_bOverride_SceneColorClear;

		// Token: 0x04001355 RID: 4949
		internal static int __PropertyOffset_bOverride_SceneColorClearColor;

		// Token: 0x04001356 RID: 4950
		internal static byte __PropertyMask_bOverride_SceneColorClearColor;

		// Token: 0x04001357 RID: 4951
		internal static int __PropertyOffset_bOverride_SceneColorClearCenter;

		// Token: 0x04001358 RID: 4952
		internal static byte __PropertyMask_bOverride_SceneColorClearCenter;

		// Token: 0x04001359 RID: 4953
		internal static int __PropertyOffset_bOverride_SceneColorClearRadius;

		// Token: 0x0400135A RID: 4954
		internal static byte __PropertyMask_bOverride_SceneColorClearRadius;

		// Token: 0x0400135B RID: 4955
		internal static int __PropertyOffset_bOverride_SceneColorClearFadeDistance;

		// Token: 0x0400135C RID: 4956
		internal static byte __PropertyMask_bOverride_SceneColorClearFadeDistance;

		// Token: 0x0400135D RID: 4957
		internal static int __PropertyOffset_bOverride_TranslucentColorDesaturate;

		// Token: 0x0400135E RID: 4958
		internal static byte __PropertyMask_bOverride_TranslucentColorDesaturate;

		// Token: 0x0400135F RID: 4959
		internal static int __PropertyOffset_bOverride_FightTranslucentNoDesaturate;

		// Token: 0x04001360 RID: 4960
		internal static byte __PropertyMask_bOverride_FightTranslucentNoDesaturate;

		// Token: 0x04001361 RID: 4961
		internal static int __PropertyOffset_bOverride_SceneTranslucentColorTint;

		// Token: 0x04001362 RID: 4962
		internal static byte __PropertyMask_bOverride_SceneTranslucentColorTint;

		// Token: 0x04001363 RID: 4963
		internal static int __PropertyOffset_bOverride_SceneEmissiveTint;

		// Token: 0x04001364 RID: 4964
		internal static byte __PropertyMask_bOverride_SceneEmissiveTint;

		// Token: 0x04001365 RID: 4965
		internal static int __PropertyOffset_bOverride_SceneTranslucentColorDesaturate;

		// Token: 0x04001366 RID: 4966
		internal static byte __PropertyMask_bOverride_SceneTranslucentColorDesaturate;

		// Token: 0x04001367 RID: 4967
		internal static int __PropertyOffset_bOverride_EnableSPD;

		// Token: 0x04001368 RID: 4968
		internal static byte __PropertyMask_bOverride_EnableSPD;

		// Token: 0x04001369 RID: 4969
		internal static int __PropertyOffset_bOverride_SceneFringeIntensity;

		// Token: 0x0400136A RID: 4970
		internal static byte __PropertyMask_bOverride_SceneFringeIntensity;

		// Token: 0x0400136B RID: 4971
		internal static int __PropertyOffset_bOverride_ChromaticAberrationStartOffset;

		// Token: 0x0400136C RID: 4972
		internal static byte __PropertyMask_bOverride_ChromaticAberrationStartOffset;

		// Token: 0x0400136D RID: 4973
		internal static int __PropertyOffset_bOverride_BaoChromaticAberrationIntensity;

		// Token: 0x0400136E RID: 4974
		internal static byte __PropertyMask_bOverride_BaoChromaticAberrationIntensity;

		// Token: 0x0400136F RID: 4975
		internal static int __PropertyOffset_bOverride_BaoChromaticAberrationMaskCenter;

		// Token: 0x04001370 RID: 4976
		internal static byte __PropertyMask_bOverride_BaoChromaticAberrationMaskCenter;

		// Token: 0x04001371 RID: 4977
		internal static int __PropertyOffset_bOverride_BaoChromaticAberrationYScale;

		// Token: 0x04001372 RID: 4978
		internal static byte __PropertyMask_bOverride_BaoChromaticAberrationYScale;

		// Token: 0x04001373 RID: 4979
		internal static int __PropertyOffset_bOverride_BaoChromaticAberrationYPan;

		// Token: 0x04001374 RID: 4980
		internal static byte __PropertyMask_bOverride_BaoChromaticAberrationYPan;

		// Token: 0x04001375 RID: 4981
		internal static int __PropertyOffset_bOverride_bMegaLights;

		// Token: 0x04001376 RID: 4982
		internal static byte __PropertyMask_bOverride_bMegaLights;

		// Token: 0x04001377 RID: 4983
		internal static int __PropertyOffset_bOverride_AmbientCubemapTint;

		// Token: 0x04001378 RID: 4984
		internal static byte __PropertyMask_bOverride_AmbientCubemapTint;

		// Token: 0x04001379 RID: 4985
		internal static int __PropertyOffset_bOverride_AmbientCubemapIntensity;

		// Token: 0x0400137A RID: 4986
		internal static byte __PropertyMask_bOverride_AmbientCubemapIntensity;

		// Token: 0x0400137B RID: 4987
		internal static int __PropertyOffset_bOverride_BloomMethod;

		// Token: 0x0400137C RID: 4988
		internal static byte __PropertyMask_bOverride_BloomMethod;

		// Token: 0x0400137D RID: 4989
		internal static int __PropertyOffset_bOverride_BloomIntensity;

		// Token: 0x0400137E RID: 4990
		internal static byte __PropertyMask_bOverride_BloomIntensity;

		// Token: 0x0400137F RID: 4991
		internal static int __PropertyOffset_bOverride_KuroFoliageMaterialAO;

		// Token: 0x04001380 RID: 4992
		internal static byte __PropertyMask_bOverride_KuroFoliageMaterialAO;

		// Token: 0x04001381 RID: 4993
		internal static int __PropertyOffset_bOverride_KuroFoliageScreenSpaceAO;

		// Token: 0x04001382 RID: 4994
		internal static byte __PropertyMask_bOverride_KuroFoliageScreenSpaceAO;

		// Token: 0x04001383 RID: 4995
		internal static int __PropertyOffset_bOverride_UseFixCharacterRim;

		// Token: 0x04001384 RID: 4996
		internal static byte __PropertyMask_bOverride_UseFixCharacterRim;

		// Token: 0x04001385 RID: 4997
		internal static int __PropertyOffset_bOverride_FixCharacterRimAngleV;

		// Token: 0x04001386 RID: 4998
		internal static byte __PropertyMask_bOverride_FixCharacterRimAngleV;

		// Token: 0x04001387 RID: 4999
		internal static int __PropertyOffset_bOverride_FixCharacterRimAngleH;

		// Token: 0x04001388 RID: 5000
		internal static byte __PropertyMask_bOverride_FixCharacterRimAngleH;

		// Token: 0x04001389 RID: 5001
		internal static int __PropertyOffset_bOverride_UseCustomRim;

		// Token: 0x0400138A RID: 5002
		internal static byte __PropertyMask_bOverride_UseCustomRim;

		// Token: 0x0400138B RID: 5003
		internal static int __PropertyOffset_bOverride_CustomRimColor_Stencil1;

		// Token: 0x0400138C RID: 5004
		internal static byte __PropertyMask_bOverride_CustomRimColor_Stencil1;

		// Token: 0x0400138D RID: 5005
		internal static int __PropertyOffset_bOverride_FixCharacterRimAngleV_Stencil1;

		// Token: 0x0400138E RID: 5006
		internal static byte __PropertyMask_bOverride_FixCharacterRimAngleV_Stencil1;

		// Token: 0x0400138F RID: 5007
		internal static int __PropertyOffset_bOverride_FixCharacterRimAngleH_Stencil1;

		// Token: 0x04001390 RID: 5008
		internal static byte __PropertyMask_bOverride_FixCharacterRimAngleH_Stencil1;

		// Token: 0x04001391 RID: 5009
		internal static int __PropertyOffset_bOverride_CustomRimColor_Stencil2;

		// Token: 0x04001392 RID: 5010
		internal static byte __PropertyMask_bOverride_CustomRimColor_Stencil2;

		// Token: 0x04001393 RID: 5011
		internal static int __PropertyOffset_bOverride_FixCharacterRimAngleV_Stencil2;

		// Token: 0x04001394 RID: 5012
		internal static byte __PropertyMask_bOverride_FixCharacterRimAngleV_Stencil2;

		// Token: 0x04001395 RID: 5013
		internal static int __PropertyOffset_bOverride_FixCharacterRimAngleH_Stencil2;

		// Token: 0x04001396 RID: 5014
		internal static byte __PropertyMask_bOverride_FixCharacterRimAngleH_Stencil2;

		// Token: 0x04001397 RID: 5015
		internal static int __PropertyOffset_bOverride_CustomRimColor_Stencil3;

		// Token: 0x04001398 RID: 5016
		internal static byte __PropertyMask_bOverride_CustomRimColor_Stencil3;

		// Token: 0x04001399 RID: 5017
		internal static int __PropertyOffset_bOverride_FixCharacterRimAngleV_Stencil3;

		// Token: 0x0400139A RID: 5018
		internal static byte __PropertyMask_bOverride_FixCharacterRimAngleV_Stencil3;

		// Token: 0x0400139B RID: 5019
		internal static int __PropertyOffset_bOverride_FixCharacterRimAngleH_Stencil3;

		// Token: 0x0400139C RID: 5020
		internal static byte __PropertyMask_bOverride_FixCharacterRimAngleH_Stencil3;

		// Token: 0x0400139D RID: 5021
		internal static int __PropertyOffset_bOverride_KuroBloomIntensity;

		// Token: 0x0400139E RID: 5022
		internal static byte __PropertyMask_bOverride_KuroBloomIntensity;

		// Token: 0x0400139F RID: 5023
		internal static int __PropertyOffset_bOverride_KuroBloomThreshold;

		// Token: 0x040013A0 RID: 5024
		internal static byte __PropertyMask_bOverride_KuroBloomThreshold;

		// Token: 0x040013A1 RID: 5025
		internal static int __PropertyOffset_bOverride_EnableSplitCharBloom;

		// Token: 0x040013A2 RID: 5026
		internal static byte __PropertyMask_bOverride_EnableSplitCharBloom;

		// Token: 0x040013A3 RID: 5027
		internal static int __PropertyOffset_bOverride_EnableExtraCharBloomOffset;

		// Token: 0x040013A4 RID: 5028
		internal static byte __PropertyMask_bOverride_EnableExtraCharBloomOffset;

		// Token: 0x040013A5 RID: 5029
		internal static int __PropertyOffset_bOverride_KuroCharacterBloomIntensity;

		// Token: 0x040013A6 RID: 5030
		internal static byte __PropertyMask_bOverride_KuroCharacterBloomIntensity;

		// Token: 0x040013A7 RID: 5031
		internal static int __PropertyOffset_bOverride_KuroCharacterBloomThreshold;

		// Token: 0x040013A8 RID: 5032
		internal static byte __PropertyMask_bOverride_KuroCharacterBloomThreshold;

		// Token: 0x040013A9 RID: 5033
		internal static int __PropertyOffset_bOverride_KuroExtraCharacterBloomIntensityOffset;

		// Token: 0x040013AA RID: 5034
		internal static byte __PropertyMask_bOverride_KuroExtraCharacterBloomIntensityOffset;

		// Token: 0x040013AB RID: 5035
		internal static int __PropertyOffset_bOverride_KuroExtraCharacterBloomThresholdOffset;

		// Token: 0x040013AC RID: 5036
		internal static byte __PropertyMask_bOverride_KuroExtraCharacterBloomThresholdOffset;

		// Token: 0x040013AD RID: 5037
		internal static int __PropertyOffset_bOverride_SunDirBloomIntensity;

		// Token: 0x040013AE RID: 5038
		internal static byte __PropertyMask_bOverride_SunDirBloomIntensity;

		// Token: 0x040013AF RID: 5039
		internal static int __PropertyOffset_bOverride_KuroBloomCombineParameter;

		// Token: 0x040013B0 RID: 5040
		internal static byte __PropertyMask_bOverride_KuroBloomCombineParameter;

		// Token: 0x040013B1 RID: 5041
		internal static int __PropertyOffset_bOverride_KuroBloomStreakIntensity;

		// Token: 0x040013B2 RID: 5042
		internal static byte __PropertyMask_bOverride_KuroBloomStreakIntensity;

		// Token: 0x040013B3 RID: 5043
		internal static int __PropertyOffset_bOverride_KuroBloomStreakThreshold;

		// Token: 0x040013B4 RID: 5044
		internal static byte __PropertyMask_bOverride_KuroBloomStreakThreshold;

		// Token: 0x040013B5 RID: 5045
		internal static int __PropertyOffset_bOverride_TranslucentBloomStreakIntensity;

		// Token: 0x040013B6 RID: 5046
		internal static byte __PropertyMask_bOverride_TranslucentBloomStreakIntensity;

		// Token: 0x040013B7 RID: 5047
		internal static int __PropertyOffset_bOverride_TranslucentBloomStreakThreshold;

		// Token: 0x040013B8 RID: 5048
		internal static byte __PropertyMask_bOverride_TranslucentBloomStreakThreshold;

		// Token: 0x040013B9 RID: 5049
		internal static int __PropertyOffset_bOverride_KuroBloomStreakLength;

		// Token: 0x040013BA RID: 5050
		internal static byte __PropertyMask_bOverride_KuroBloomStreakLength;

		// Token: 0x040013BB RID: 5051
		internal static int __PropertyOffset_bOverride_KuroBloomStreakMipLevel;

		// Token: 0x040013BC RID: 5052
		internal static byte __PropertyMask_bOverride_KuroBloomStreakMipLevel;

		// Token: 0x040013BD RID: 5053
		internal static int __PropertyOffset_bOverride_KuroBloomStreakRatio;

		// Token: 0x040013BE RID: 5054
		internal static byte __PropertyMask_bOverride_KuroBloomStreakRatio;

		// Token: 0x040013BF RID: 5055
		internal static int __PropertyOffset_bOverride_KuroBloomStreakOrientation;

		// Token: 0x040013C0 RID: 5056
		internal static byte __PropertyMask_bOverride_KuroBloomStreakOrientation;

		// Token: 0x040013C1 RID: 5057
		internal static int __PropertyOffset_bOverride_BlackWhiteFlashIntensity;

		// Token: 0x040013C2 RID: 5058
		internal static byte __PropertyMask_bOverride_BlackWhiteFlashIntensity;

		// Token: 0x040013C3 RID: 5059
		internal static int __PropertyOffset_bOverride_BlackWhiteFlashFactor;

		// Token: 0x040013C4 RID: 5060
		internal static byte __PropertyMask_bOverride_BlackWhiteFlashFactor;

		// Token: 0x040013C5 RID: 5061
		internal static int __PropertyOffset_bOverride_BlackWhiteFlashThreshold;

		// Token: 0x040013C6 RID: 5062
		internal static byte __PropertyMask_bOverride_BlackWhiteFlashThreshold;

		// Token: 0x040013C7 RID: 5063
		internal static int __PropertyOffset_bOverride_BlackWhiteFlashBlackAreaColor;

		// Token: 0x040013C8 RID: 5064
		internal static byte __PropertyMask_bOverride_BlackWhiteFlashBlackAreaColor;

		// Token: 0x040013C9 RID: 5065
		internal static int __PropertyOffset_bOverride_BlackWhiteFlashWhiteAreaColor;

		// Token: 0x040013CA RID: 5066
		internal static byte __PropertyMask_bOverride_BlackWhiteFlashWhiteAreaColor;

		// Token: 0x040013CB RID: 5067
		internal static int __PropertyOffset_bOverride_KuroRadialBlurIntensity;

		// Token: 0x040013CC RID: 5068
		internal static byte __PropertyMask_bOverride_KuroRadialBlurIntensity;

		// Token: 0x040013CD RID: 5069
		internal static int __PropertyOffset_bOverride_KuroRadialBlurRadius;

		// Token: 0x040013CE RID: 5070
		internal static byte __PropertyMask_bOverride_KuroRadialBlurRadius;

		// Token: 0x040013CF RID: 5071
		internal static int __PropertyOffset_bOverride_KuroRadialBlurHardness;

		// Token: 0x040013D0 RID: 5072
		internal static byte __PropertyMask_bOverride_KuroRadialBlurHardness;

		// Token: 0x040013D1 RID: 5073
		internal static int __PropertyOffset_bOverride_KuroRadialBlurCenter;

		// Token: 0x040013D2 RID: 5074
		internal static byte __PropertyMask_bOverride_KuroRadialBlurCenter;

		// Token: 0x040013D3 RID: 5075
		internal static int __PropertyOffset_bOverride_UseClampRadialBlurCenter;

		// Token: 0x040013D4 RID: 5076
		internal static byte __PropertyMask_bOverride_UseClampRadialBlurCenter;

		// Token: 0x040013D5 RID: 5077
		internal static int __PropertyOffset_bOverride_KuroRadialBlurPassNumber;

		// Token: 0x040013D6 RID: 5078
		internal static byte __PropertyMask_bOverride_KuroRadialBlurPassNumber;

		// Token: 0x040013D7 RID: 5079
		internal static int __PropertyOffset_bOverride_KuroRadialBlurSampleNumber;

		// Token: 0x040013D8 RID: 5080
		internal static byte __PropertyMask_bOverride_KuroRadialBlurSampleNumber;

		// Token: 0x040013D9 RID: 5081
		internal static int __PropertyOffset_bOverride_KuroRadialBlurMask;

		// Token: 0x040013DA RID: 5082
		internal static byte __PropertyMask_bOverride_KuroRadialBlurMask;

		// Token: 0x040013DB RID: 5083
		internal static int __PropertyOffset_bOverride_KuroRadialBlurMaskScale;

		// Token: 0x040013DC RID: 5084
		internal static byte __PropertyMask_bOverride_KuroRadialBlurMaskScale;

		// Token: 0x040013DD RID: 5085
		internal static int __PropertyOffset_bOverride_KuroRadialBlurMaskOffset;

		// Token: 0x040013DE RID: 5086
		internal static byte __PropertyMask_bOverride_KuroRadialBlurMaskOffset;

		// Token: 0x040013DF RID: 5087
		internal static int __PropertyOffset_bOverride_ScreenSoftIntensity;

		// Token: 0x040013E0 RID: 5088
		internal static byte __PropertyMask_bOverride_ScreenSoftIntensity;

		// Token: 0x040013E1 RID: 5089
		internal static int __PropertyOffset_bOverride_ScreenSoftThreshold;

		// Token: 0x040013E2 RID: 5090
		internal static byte __PropertyMask_bOverride_ScreenSoftThreshold;

		// Token: 0x040013E3 RID: 5091
		internal static int __PropertyOffset_bOverride_ScreenSoftDistance;

		// Token: 0x040013E4 RID: 5092
		internal static byte __PropertyMask_bOverride_ScreenSoftDistance;

		// Token: 0x040013E5 RID: 5093
		internal static int __PropertyOffset_bOverride_ScreenSoftSkyBloomCompensation;

		// Token: 0x040013E6 RID: 5094
		internal static byte __PropertyMask_bOverride_ScreenSoftSkyBloomCompensation;

		// Token: 0x040013E7 RID: 5095
		internal static int __PropertyOffset_bOverride_ScreenSoftRange;

		// Token: 0x040013E8 RID: 5096
		internal static byte __PropertyMask_bOverride_ScreenSoftRange;

		// Token: 0x040013E9 RID: 5097
		internal static int __PropertyOffset_bOverride_ScreenSoftOverflowDistance;

		// Token: 0x040013EA RID: 5098
		internal static byte __PropertyMask_bOverride_ScreenSoftOverflowDistance;

		// Token: 0x040013EB RID: 5099
		internal static int __PropertyOffset_bOverride_ScreenSoftSunExposure;

		// Token: 0x040013EC RID: 5100
		internal static byte __PropertyMask_bOverride_ScreenSoftSunExposure;

		// Token: 0x040013ED RID: 5101
		internal static int __PropertyOffset_bOverride_ScreenSoftHighQuality;

		// Token: 0x040013EE RID: 5102
		internal static byte __PropertyMask_bOverride_ScreenSoftHighQuality;

		// Token: 0x040013EF RID: 5103
		internal static int __PropertyOffset_bOverride_MobileScreenSoftIntensity;

		// Token: 0x040013F0 RID: 5104
		internal static byte __PropertyMask_bOverride_MobileScreenSoftIntensity;

		// Token: 0x040013F1 RID: 5105
		internal static int __PropertyOffset_bOverride_MobileScreenSoftThreshold;

		// Token: 0x040013F2 RID: 5106
		internal static byte __PropertyMask_bOverride_MobileScreenSoftThreshold;

		// Token: 0x040013F3 RID: 5107
		internal static int __PropertyOffset_bOverride_MobileScreenSoftDistance;

		// Token: 0x040013F4 RID: 5108
		internal static byte __PropertyMask_bOverride_MobileScreenSoftDistance;

		// Token: 0x040013F5 RID: 5109
		internal static int __PropertyOffset_bOverride_ScreenLeakTexture;

		// Token: 0x040013F6 RID: 5110
		internal static byte __PropertyMask_bOverride_ScreenLeakTexture;

		// Token: 0x040013F7 RID: 5111
		internal static int __PropertyOffset_bOverride_ScreenLeakTextureIntensity;

		// Token: 0x040013F8 RID: 5112
		internal static byte __PropertyMask_bOverride_ScreenLeakTextureIntensity;

		// Token: 0x040013F9 RID: 5113
		internal static int __PropertyOffset_bOverride_FFTIntensity;

		// Token: 0x040013FA RID: 5114
		internal static byte __PropertyMask_bOverride_FFTIntensity;

		// Token: 0x040013FB RID: 5115
		internal static int __PropertyOffset_bOverride_FFTThreshold;

		// Token: 0x040013FC RID: 5116
		internal static byte __PropertyMask_bOverride_FFTThreshold;

		// Token: 0x040013FD RID: 5117
		internal static int __PropertyOffset_bOverride_FFTTexture;

		// Token: 0x040013FE RID: 5118
		internal static byte __PropertyMask_bOverride_FFTTexture;

		// Token: 0x040013FF RID: 5119
		internal static int __PropertyOffset_bOverride_FFTScatterDispersion;

		// Token: 0x04001400 RID: 5120
		internal static byte __PropertyMask_bOverride_FFTScatterDispersion;

		// Token: 0x04001401 RID: 5121
		internal static int __PropertyOffset_bOverride_FFTSize;

		// Token: 0x04001402 RID: 5122
		internal static byte __PropertyMask_bOverride_FFTSize;

		// Token: 0x04001403 RID: 5123
		internal static int __PropertyOffset_bOverride_FFTPreFilterMin;

		// Token: 0x04001404 RID: 5124
		internal static byte __PropertyMask_bOverride_FFTPreFilterMin;

		// Token: 0x04001405 RID: 5125
		internal static int __PropertyOffset_bOverride_FFTPreFilterMax;

		// Token: 0x04001406 RID: 5126
		internal static byte __PropertyMask_bOverride_FFTPreFilterMax;

		// Token: 0x04001407 RID: 5127
		internal static int __PropertyOffset_bOverride_FFTPreFilterMult;

		// Token: 0x04001408 RID: 5128
		internal static byte __PropertyMask_bOverride_FFTPreFilterMult;

		// Token: 0x04001409 RID: 5129
		internal static int __PropertyOffset_bOverride_FFTBufferScale;

		// Token: 0x0400140A RID: 5130
		internal static byte __PropertyMask_bOverride_FFTBufferScale;

		// Token: 0x0400140B RID: 5131
		internal static int __PropertyOffset_bOverride_FFTDistance;

		// Token: 0x0400140C RID: 5132
		internal static byte __PropertyMask_bOverride_FFTDistance;

		// Token: 0x0400140D RID: 5133
		internal static int __PropertyOffset_bOverride_FFTHidenSky;

		// Token: 0x0400140E RID: 5134
		internal static byte __PropertyMask_bOverride_FFTHidenSky;

		// Token: 0x0400140F RID: 5135
		internal static int __PropertyOffset_bOverride_FFTHidenTranslucent;

		// Token: 0x04001410 RID: 5136
		internal static byte __PropertyMask_bOverride_FFTHidenTranslucent;

		// Token: 0x04001411 RID: 5137
		internal static int __PropertyOffset_bOverride_FFTBeforeTranslucency;

		// Token: 0x04001412 RID: 5138
		internal static byte __PropertyMask_bOverride_FFTBeforeTranslucency;

		// Token: 0x04001413 RID: 5139
		internal static int __PropertyOffset_bOverride_ToonFFTIntensity;

		// Token: 0x04001414 RID: 5140
		internal static byte __PropertyMask_bOverride_ToonFFTIntensity;

		// Token: 0x04001415 RID: 5141
		internal static int __PropertyOffset_bOverride_ToonFFTThreshold;

		// Token: 0x04001416 RID: 5142
		internal static byte __PropertyMask_bOverride_ToonFFTThreshold;

		// Token: 0x04001417 RID: 5143
		internal static int __PropertyOffset_bOverride_ToonFFTTexture;

		// Token: 0x04001418 RID: 5144
		internal static byte __PropertyMask_bOverride_ToonFFTTexture;

		// Token: 0x04001419 RID: 5145
		internal static int __PropertyOffset_bOverride_ToonFFTScatterDispersion;

		// Token: 0x0400141A RID: 5146
		internal static byte __PropertyMask_bOverride_ToonFFTScatterDispersion;

		// Token: 0x0400141B RID: 5147
		internal static int __PropertyOffset_bOverride_ToonFFTSize;

		// Token: 0x0400141C RID: 5148
		internal static byte __PropertyMask_bOverride_ToonFFTSize;

		// Token: 0x0400141D RID: 5149
		internal static int __PropertyOffset_bOverride_SeparateTranslucencyBlurSize;

		// Token: 0x0400141E RID: 5150
		internal static byte __PropertyMask_bOverride_SeparateTranslucencyBlurSize;

		// Token: 0x0400141F RID: 5151
		internal static int __PropertyOffset_bOverride_LightFadeScale;

		// Token: 0x04001420 RID: 5152
		internal static byte __PropertyMask_bOverride_LightFadeScale;

		// Token: 0x04001421 RID: 5153
		internal static int __PropertyOffset_bOverride_KuroDataDistortionNoiseIntensity;

		// Token: 0x04001422 RID: 5154
		internal static byte __PropertyMask_bOverride_KuroDataDistortionNoiseIntensity;

		// Token: 0x04001423 RID: 5155
		internal static int __PropertyOffset_bOverride_KuroDataDistortionNoiseTexture;

		// Token: 0x04001424 RID: 5156
		internal static byte __PropertyMask_bOverride_KuroDataDistortionNoiseTexture;

		// Token: 0x04001425 RID: 5157
		internal static int __PropertyOffset_bOverride_KuroDataDistortionNoiseTextureUVScaleBias;

		// Token: 0x04001426 RID: 5158
		internal static byte __PropertyMask_bOverride_KuroDataDistortionNoiseTextureUVScaleBias;

		// Token: 0x04001427 RID: 5159
		internal static int __PropertyOffset_bOverride_KuroDataDistortionNoiseSize;

		// Token: 0x04001428 RID: 5160
		internal static byte __PropertyMask_bOverride_KuroDataDistortionNoiseSize;

		// Token: 0x04001429 RID: 5161
		internal static int __PropertyOffset_bOverride_KuroDataDistortionNoiseBias;

		// Token: 0x0400142A RID: 5162
		internal static byte __PropertyMask_bOverride_KuroDataDistortionNoiseBias;

		// Token: 0x0400142B RID: 5163
		internal static int __PropertyOffset_bOverride_KuroDataDistortionSignalIntensity;

		// Token: 0x0400142C RID: 5164
		internal static byte __PropertyMask_bOverride_KuroDataDistortionSignalIntensity;

		// Token: 0x0400142D RID: 5165
		internal static int __PropertyOffset_bOverride_KuroDataDistortionRandomColorSize;

		// Token: 0x0400142E RID: 5166
		internal static byte __PropertyMask_bOverride_KuroDataDistortionRandomColorSize;

		// Token: 0x0400142F RID: 5167
		internal static int __PropertyOffset_bOverride_KuroDataDistortionSinWaveParameters;

		// Token: 0x04001430 RID: 5168
		internal static byte __PropertyMask_bOverride_KuroDataDistortionSinWaveParameters;

		// Token: 0x04001431 RID: 5169
		internal static int __PropertyOffset_bOverride_KuroDataDistortionColorTint;

		// Token: 0x04001432 RID: 5170
		internal static byte __PropertyMask_bOverride_KuroDataDistortionColorTint;

		// Token: 0x04001433 RID: 5171
		internal static int __PropertyOffset_bOverride_BloomThreshold;

		// Token: 0x04001434 RID: 5172
		internal static byte __PropertyMask_bOverride_BloomThreshold;

		// Token: 0x04001435 RID: 5173
		internal static int __PropertyOffset_bOverride_Bloom1Tint;

		// Token: 0x04001436 RID: 5174
		internal static byte __PropertyMask_bOverride_Bloom1Tint;

		// Token: 0x04001437 RID: 5175
		internal static int __PropertyOffset_bOverride_Bloom1Size;

		// Token: 0x04001438 RID: 5176
		internal static byte __PropertyMask_bOverride_Bloom1Size;

		// Token: 0x04001439 RID: 5177
		internal static int __PropertyOffset_bOverride_Bloom2Size;

		// Token: 0x0400143A RID: 5178
		internal static byte __PropertyMask_bOverride_Bloom2Size;

		// Token: 0x0400143B RID: 5179
		internal static int __PropertyOffset_bOverride_Bloom2Tint;

		// Token: 0x0400143C RID: 5180
		internal static byte __PropertyMask_bOverride_Bloom2Tint;

		// Token: 0x0400143D RID: 5181
		internal static int __PropertyOffset_bOverride_Bloom3Tint;

		// Token: 0x0400143E RID: 5182
		internal static byte __PropertyMask_bOverride_Bloom3Tint;

		// Token: 0x0400143F RID: 5183
		internal static int __PropertyOffset_bOverride_Bloom3Size;

		// Token: 0x04001440 RID: 5184
		internal static byte __PropertyMask_bOverride_Bloom3Size;

		// Token: 0x04001441 RID: 5185
		internal static int __PropertyOffset_bOverride_Bloom4Tint;

		// Token: 0x04001442 RID: 5186
		internal static byte __PropertyMask_bOverride_Bloom4Tint;

		// Token: 0x04001443 RID: 5187
		internal static int __PropertyOffset_bOverride_Bloom4Size;

		// Token: 0x04001444 RID: 5188
		internal static byte __PropertyMask_bOverride_Bloom4Size;

		// Token: 0x04001445 RID: 5189
		internal static int __PropertyOffset_bOverride_Bloom5Tint;

		// Token: 0x04001446 RID: 5190
		internal static byte __PropertyMask_bOverride_Bloom5Tint;

		// Token: 0x04001447 RID: 5191
		internal static int __PropertyOffset_bOverride_Bloom5Size;

		// Token: 0x04001448 RID: 5192
		internal static byte __PropertyMask_bOverride_Bloom5Size;

		// Token: 0x04001449 RID: 5193
		internal static int __PropertyOffset_bOverride_Bloom6Tint;

		// Token: 0x0400144A RID: 5194
		internal static byte __PropertyMask_bOverride_Bloom6Tint;

		// Token: 0x0400144B RID: 5195
		internal static int __PropertyOffset_bOverride_Bloom6Size;

		// Token: 0x0400144C RID: 5196
		internal static byte __PropertyMask_bOverride_Bloom6Size;

		// Token: 0x0400144D RID: 5197
		internal static int __PropertyOffset_bOverride_BloomSizeScale;

		// Token: 0x0400144E RID: 5198
		internal static byte __PropertyMask_bOverride_BloomSizeScale;

		// Token: 0x0400144F RID: 5199
		internal static int __PropertyOffset_bOverride_BloomConvolutionPreFilter_DEPRECATED;

		// Token: 0x04001450 RID: 5200
		internal static byte __PropertyMask_bOverride_BloomConvolutionPreFilter_DEPRECATED;

		// Token: 0x04001451 RID: 5201
		internal static int __PropertyOffset_bOverride_BloomDirtMaskIntensity;

		// Token: 0x04001452 RID: 5202
		internal static byte __PropertyMask_bOverride_BloomDirtMaskIntensity;

		// Token: 0x04001453 RID: 5203
		internal static int __PropertyOffset_bOverride_BloomDirtMaskTint;

		// Token: 0x04001454 RID: 5204
		internal static byte __PropertyMask_bOverride_BloomDirtMaskTint;

		// Token: 0x04001455 RID: 5205
		internal static int __PropertyOffset_bOverride_BloomDirtMask;

		// Token: 0x04001456 RID: 5206
		internal static byte __PropertyMask_bOverride_BloomDirtMask;

		// Token: 0x04001457 RID: 5207
		internal static int __PropertyOffset_bOverride_CameraShutterSpeed;

		// Token: 0x04001458 RID: 5208
		internal static byte __PropertyMask_bOverride_CameraShutterSpeed;

		// Token: 0x04001459 RID: 5209
		internal static int __PropertyOffset_bOverride_CameraISO;

		// Token: 0x0400145A RID: 5210
		internal static byte __PropertyMask_bOverride_CameraISO;

		// Token: 0x0400145B RID: 5211
		internal static int __PropertyOffset_bOverride_AutoExposureMethod;

		// Token: 0x0400145C RID: 5212
		internal static byte __PropertyMask_bOverride_AutoExposureMethod;

		// Token: 0x0400145D RID: 5213
		internal static int __PropertyOffset_bOverride_AutoExposureLowPercent;

		// Token: 0x0400145E RID: 5214
		internal static byte __PropertyMask_bOverride_AutoExposureLowPercent;

		// Token: 0x0400145F RID: 5215
		internal static int __PropertyOffset_bOverride_AutoExposureHighPercent;

		// Token: 0x04001460 RID: 5216
		internal static byte __PropertyMask_bOverride_AutoExposureHighPercent;

		// Token: 0x04001461 RID: 5217
		internal static int __PropertyOffset_bOverride_AutoExposureMinBrightness;

		// Token: 0x04001462 RID: 5218
		internal static byte __PropertyMask_bOverride_AutoExposureMinBrightness;

		// Token: 0x04001463 RID: 5219
		internal static int __PropertyOffset_bOverride_AutoExposureMaxBrightness;

		// Token: 0x04001464 RID: 5220
		internal static byte __PropertyMask_bOverride_AutoExposureMaxBrightness;

		// Token: 0x04001465 RID: 5221
		internal static int __PropertyOffset_bOverride_AutoExposureCalibrationConstant_DEPRECATED;

		// Token: 0x04001466 RID: 5222
		internal static byte __PropertyMask_bOverride_AutoExposureCalibrationConstant_DEPRECATED;

		// Token: 0x04001467 RID: 5223
		internal static int __PropertyOffset_bOverride_AutoExposureSpeedUp;

		// Token: 0x04001468 RID: 5224
		internal static byte __PropertyMask_bOverride_AutoExposureSpeedUp;

		// Token: 0x04001469 RID: 5225
		internal static int __PropertyOffset_bOverride_AutoExposureSpeedDown;

		// Token: 0x0400146A RID: 5226
		internal static byte __PropertyMask_bOverride_AutoExposureSpeedDown;

		// Token: 0x0400146B RID: 5227
		internal static int __PropertyOffset_bOverride_AutoExposureBias;

		// Token: 0x0400146C RID: 5228
		internal static byte __PropertyMask_bOverride_AutoExposureBias;

		// Token: 0x0400146D RID: 5229
		internal static int __PropertyOffset_bOverride_AutoExposureBiasCurve;

		// Token: 0x0400146E RID: 5230
		internal static byte __PropertyMask_bOverride_AutoExposureBiasCurve;

		// Token: 0x0400146F RID: 5231
		internal static int __PropertyOffset_bOverride_AutoExposureMeterMask;

		// Token: 0x04001470 RID: 5232
		internal static byte __PropertyMask_bOverride_AutoExposureMeterMask;

		// Token: 0x04001471 RID: 5233
		internal static int __PropertyOffset_bOverride_AutoExposureApplyPhysicalCameraExposure;

		// Token: 0x04001472 RID: 5234
		internal static byte __PropertyMask_bOverride_AutoExposureApplyPhysicalCameraExposure;

		// Token: 0x04001473 RID: 5235
		internal static int __PropertyOffset_bOverride_HistogramLogMin;

		// Token: 0x04001474 RID: 5236
		internal static byte __PropertyMask_bOverride_HistogramLogMin;

		// Token: 0x04001475 RID: 5237
		internal static int __PropertyOffset_bOverride_HistogramLogMax;

		// Token: 0x04001476 RID: 5238
		internal static byte __PropertyMask_bOverride_HistogramLogMax;

		// Token: 0x04001477 RID: 5239
		internal static int __PropertyOffset_bOverride_LocalExposureMethod;

		// Token: 0x04001478 RID: 5240
		internal static byte __PropertyMask_bOverride_LocalExposureMethod;

		// Token: 0x04001479 RID: 5241
		internal static int __PropertyOffset_bOverride_LocalExposureContrastScale_DEPRECATED;

		// Token: 0x0400147A RID: 5242
		internal static byte __PropertyMask_bOverride_LocalExposureContrastScale_DEPRECATED;

		// Token: 0x0400147B RID: 5243
		internal static int __PropertyOffset_bOverride_LocalExposureHighlightContrastScale;

		// Token: 0x0400147C RID: 5244
		internal static byte __PropertyMask_bOverride_LocalExposureHighlightContrastScale;

		// Token: 0x0400147D RID: 5245
		internal static int __PropertyOffset_bOverride_LocalExposureShadowContrastScale;

		// Token: 0x0400147E RID: 5246
		internal static byte __PropertyMask_bOverride_LocalExposureShadowContrastScale;

		// Token: 0x0400147F RID: 5247
		internal static int __PropertyOffset_bOverride_LocalExposureHighlightContrastCurve;

		// Token: 0x04001480 RID: 5248
		internal static byte __PropertyMask_bOverride_LocalExposureHighlightContrastCurve;

		// Token: 0x04001481 RID: 5249
		internal static int __PropertyOffset_bOverride_LocalExposureShadowContrastCurve;

		// Token: 0x04001482 RID: 5250
		internal static byte __PropertyMask_bOverride_LocalExposureShadowContrastCurve;

		// Token: 0x04001483 RID: 5251
		internal static int __PropertyOffset_bOverride_LocalExposureHighlightThreshold;

		// Token: 0x04001484 RID: 5252
		internal static byte __PropertyMask_bOverride_LocalExposureHighlightThreshold;

		// Token: 0x04001485 RID: 5253
		internal static int __PropertyOffset_bOverride_LocalExposureShadowThreshold;

		// Token: 0x04001486 RID: 5254
		internal static byte __PropertyMask_bOverride_LocalExposureShadowThreshold;

		// Token: 0x04001487 RID: 5255
		internal static int __PropertyOffset_bOverride_LocalExposureDetailStrength;

		// Token: 0x04001488 RID: 5256
		internal static byte __PropertyMask_bOverride_LocalExposureDetailStrength;

		// Token: 0x04001489 RID: 5257
		internal static int __PropertyOffset_bOverride_LocalExposureBlurredLuminanceBlend;

		// Token: 0x0400148A RID: 5258
		internal static byte __PropertyMask_bOverride_LocalExposureBlurredLuminanceBlend;

		// Token: 0x0400148B RID: 5259
		internal static int __PropertyOffset_bOverride_LocalExposureBlurredLuminanceKernelSizePercent;

		// Token: 0x0400148C RID: 5260
		internal static byte __PropertyMask_bOverride_LocalExposureBlurredLuminanceKernelSizePercent;

		// Token: 0x0400148D RID: 5261
		internal static int __PropertyOffset_bOverride_LocalExposureMiddleGreyBias;

		// Token: 0x0400148E RID: 5262
		internal static byte __PropertyMask_bOverride_LocalExposureMiddleGreyBias;

		// Token: 0x0400148F RID: 5263
		internal static int __PropertyOffset_bOverride_LensFlareIntensity;

		// Token: 0x04001490 RID: 5264
		internal static byte __PropertyMask_bOverride_LensFlareIntensity;

		// Token: 0x04001491 RID: 5265
		internal static int __PropertyOffset_bOverride_LensFlareTint;

		// Token: 0x04001492 RID: 5266
		internal static byte __PropertyMask_bOverride_LensFlareTint;

		// Token: 0x04001493 RID: 5267
		internal static int __PropertyOffset_bOverride_LensFlareTints;

		// Token: 0x04001494 RID: 5268
		internal static byte __PropertyMask_bOverride_LensFlareTints;

		// Token: 0x04001495 RID: 5269
		internal static int __PropertyOffset_bOverride_LensFlareBokehSize;

		// Token: 0x04001496 RID: 5270
		internal static byte __PropertyMask_bOverride_LensFlareBokehSize;

		// Token: 0x04001497 RID: 5271
		internal static int __PropertyOffset_bOverride_LensFlareBokehShape;

		// Token: 0x04001498 RID: 5272
		internal static byte __PropertyMask_bOverride_LensFlareBokehShape;

		// Token: 0x04001499 RID: 5273
		internal static int __PropertyOffset_bOverride_LensFlareThreshold;

		// Token: 0x0400149A RID: 5274
		internal static byte __PropertyMask_bOverride_LensFlareThreshold;

		// Token: 0x0400149B RID: 5275
		internal static int __PropertyOffset_bOverride_LensFlareOnlySun;

		// Token: 0x0400149C RID: 5276
		internal static byte __PropertyMask_bOverride_LensFlareOnlySun;

		// Token: 0x0400149D RID: 5277
		internal static int __PropertyOffset_bOverride_LensFlareSunRange;

		// Token: 0x0400149E RID: 5278
		internal static byte __PropertyMask_bOverride_LensFlareSunRange;

		// Token: 0x0400149F RID: 5279
		internal static int __PropertyOffset_bOverride_LensFlareSunPosition;

		// Token: 0x040014A0 RID: 5280
		internal static byte __PropertyMask_bOverride_LensFlareSunPosition;

		// Token: 0x040014A1 RID: 5281
		internal static int __PropertyOffset_bOverride_VignetteIntensity;

		// Token: 0x040014A2 RID: 5282
		internal static byte __PropertyMask_bOverride_VignetteIntensity;

		// Token: 0x040014A3 RID: 5283
		internal static int __PropertyOffset_bOverride_VignetteHardness;

		// Token: 0x040014A4 RID: 5284
		internal static byte __PropertyMask_bOverride_VignetteHardness;

		// Token: 0x040014A5 RID: 5285
		internal static int __PropertyOffset_bOverride_VignetteXScale;

		// Token: 0x040014A6 RID: 5286
		internal static byte __PropertyMask_bOverride_VignetteXScale;

		// Token: 0x040014A7 RID: 5287
		internal static int __PropertyOffset_bOverride_VignetteYScale;

		// Token: 0x040014A8 RID: 5288
		internal static byte __PropertyMask_bOverride_VignetteYScale;

		// Token: 0x040014A9 RID: 5289
		internal static int __PropertyOffset_bOverride_VignetteXPos;

		// Token: 0x040014AA RID: 5290
		internal static byte __PropertyMask_bOverride_VignetteXPos;

		// Token: 0x040014AB RID: 5291
		internal static int __PropertyOffset_bOverride_VignetteYPos;

		// Token: 0x040014AC RID: 5292
		internal static byte __PropertyMask_bOverride_VignetteYPos;

		// Token: 0x040014AD RID: 5293
		internal static int __PropertyOffset_bOverride_VignetteColor;

		// Token: 0x040014AE RID: 5294
		internal static byte __PropertyMask_bOverride_VignetteColor;

		// Token: 0x040014AF RID: 5295
		internal static int __PropertyOffset_bOverride_VignetteGain;

		// Token: 0x040014B0 RID: 5296
		internal static byte __PropertyMask_bOverride_VignetteGain;

		// Token: 0x040014B1 RID: 5297
		internal static int __PropertyOffset_bOverride_EffectVignetteIntensity;

		// Token: 0x040014B2 RID: 5298
		internal static byte __PropertyMask_bOverride_EffectVignetteIntensity;

		// Token: 0x040014B3 RID: 5299
		internal static int __PropertyOffset_bOverride_EffectVignetteHardness;

		// Token: 0x040014B4 RID: 5300
		internal static byte __PropertyMask_bOverride_EffectVignetteHardness;

		// Token: 0x040014B5 RID: 5301
		internal static int __PropertyOffset_bOverride_EffectVignetteXScale;

		// Token: 0x040014B6 RID: 5302
		internal static byte __PropertyMask_bOverride_EffectVignetteXScale;

		// Token: 0x040014B7 RID: 5303
		internal static int __PropertyOffset_bOverride_EffectVignetteYScale;

		// Token: 0x040014B8 RID: 5304
		internal static byte __PropertyMask_bOverride_EffectVignetteYScale;

		// Token: 0x040014B9 RID: 5305
		internal static int __PropertyOffset_bOverride_EffectVignetteXPos;

		// Token: 0x040014BA RID: 5306
		internal static byte __PropertyMask_bOverride_EffectVignetteXPos;

		// Token: 0x040014BB RID: 5307
		internal static int __PropertyOffset_bOverride_EffectVignetteYPos;

		// Token: 0x040014BC RID: 5308
		internal static byte __PropertyMask_bOverride_EffectVignetteYPos;

		// Token: 0x040014BD RID: 5309
		internal static int __PropertyOffset_bOverride_EffectVignetteColor;

		// Token: 0x040014BE RID: 5310
		internal static byte __PropertyMask_bOverride_EffectVignetteColor;

		// Token: 0x040014BF RID: 5311
		internal static int __PropertyOffset_bOverride_EffectVignetteGain;

		// Token: 0x040014C0 RID: 5312
		internal static byte __PropertyMask_bOverride_EffectVignetteGain;

		// Token: 0x040014C1 RID: 5313
		internal static int __PropertyOffset_bOverride_GrainIntensity;

		// Token: 0x040014C2 RID: 5314
		internal static byte __PropertyMask_bOverride_GrainIntensity;

		// Token: 0x040014C3 RID: 5315
		internal static int __PropertyOffset_bOverride_GrainJitter;

		// Token: 0x040014C4 RID: 5316
		internal static byte __PropertyMask_bOverride_GrainJitter;

		// Token: 0x040014C5 RID: 5317
		internal static int __PropertyOffset_bOverride_GrainColorful;

		// Token: 0x040014C6 RID: 5318
		internal static byte __PropertyMask_bOverride_GrainColorful;

		// Token: 0x040014C7 RID: 5319
		internal static int __PropertyOffset_bOverride_MainCenterMask;

		// Token: 0x040014C8 RID: 5320
		internal static byte __PropertyMask_bOverride_MainCenterMask;

		// Token: 0x040014C9 RID: 5321
		internal static int __PropertyOffset_bOverride_MainCenterMaskRadius;

		// Token: 0x040014CA RID: 5322
		internal static byte __PropertyMask_bOverride_MainCenterMaskRadius;

		// Token: 0x040014CB RID: 5323
		internal static int __PropertyOffset_bOverride_MainCenterMaskHardness;

		// Token: 0x040014CC RID: 5324
		internal static byte __PropertyMask_bOverride_MainCenterMaskHardness;

		// Token: 0x040014CD RID: 5325
		internal static int __PropertyOffset_bOverride_MainStartDistance;

		// Token: 0x040014CE RID: 5326
		internal static byte __PropertyMask_bOverride_MainStartDistance;

		// Token: 0x040014CF RID: 5327
		internal static int __PropertyOffset_bOverride_MainCharacterIntensity;

		// Token: 0x040014D0 RID: 5328
		internal static byte __PropertyMask_bOverride_MainCharacterIntensity;

		// Token: 0x040014D1 RID: 5329
		internal static int __PropertyOffset_bOverride_VintageColorIntensity;

		// Token: 0x040014D2 RID: 5330
		internal static byte __PropertyMask_bOverride_VintageColorIntensity;

		// Token: 0x040014D3 RID: 5331
		internal static int __PropertyOffset_bOverride_VintageColorBlackPoint;

		// Token: 0x040014D4 RID: 5332
		internal static byte __PropertyMask_bOverride_VintageColorBlackPoint;

		// Token: 0x040014D5 RID: 5333
		internal static int __PropertyOffset_bOverride_VintageColorWhitePoint;

		// Token: 0x040014D6 RID: 5334
		internal static byte __PropertyMask_bOverride_VintageColorWhitePoint;

		// Token: 0x040014D7 RID: 5335
		internal static int __PropertyOffset_bOverride_VHSLinesColorIntensity;

		// Token: 0x040014D8 RID: 5336
		internal static byte __PropertyMask_bOverride_VHSLinesColorIntensity;

		// Token: 0x040014D9 RID: 5337
		internal static int __PropertyOffset_bOverride_VHSLinesDistortIntensity;

		// Token: 0x040014DA RID: 5338
		internal static byte __PropertyMask_bOverride_VHSLinesDistortIntensity;

		// Token: 0x040014DB RID: 5339
		internal static int __PropertyOffset_bOverride_VHSEffectIntensity;

		// Token: 0x040014DC RID: 5340
		internal static byte __PropertyMask_bOverride_VHSEffectIntensity;

		// Token: 0x040014DD RID: 5341
		internal static int __PropertyOffset_bOverride_VHSSpecklesIntensity;

		// Token: 0x040014DE RID: 5342
		internal static byte __PropertyMask_bOverride_VHSSpecklesIntensity;

		// Token: 0x040014DF RID: 5343
		internal static int __PropertyOffset_bOverride_VHSSpecklesAmount;

		// Token: 0x040014E0 RID: 5344
		internal static byte __PropertyMask_bOverride_VHSSpecklesAmount;

		// Token: 0x040014E1 RID: 5345
		internal static int __PropertyOffset_bOverride_VHSSpecklesSize;

		// Token: 0x040014E2 RID: 5346
		internal static byte __PropertyMask_bOverride_VHSSpecklesSize;

		// Token: 0x040014E3 RID: 5347
		internal static int __PropertyOffset_bOverride_CRTDistortion;

		// Token: 0x040014E4 RID: 5348
		internal static byte __PropertyMask_bOverride_CRTDistortion;

		// Token: 0x040014E5 RID: 5349
		internal static int __PropertyOffset_bOverride_VintageColorCenterMask;

		// Token: 0x040014E6 RID: 5350
		internal static byte __PropertyMask_bOverride_VintageColorCenterMask;

		// Token: 0x040014E7 RID: 5351
		internal static int __PropertyOffset_bOverride_VintageColorStartDistance;

		// Token: 0x040014E8 RID: 5352
		internal static byte __PropertyMask_bOverride_VintageColorStartDistance;

		// Token: 0x040014E9 RID: 5353
		internal static int __PropertyOffset_bOverride_VintageColorCharacterIntensity;

		// Token: 0x040014EA RID: 5354
		internal static byte __PropertyMask_bOverride_VintageColorCharacterIntensity;

		// Token: 0x040014EB RID: 5355
		internal static int __PropertyOffset_bOverride_VHSLinesCenterMask;

		// Token: 0x040014EC RID: 5356
		internal static byte __PropertyMask_bOverride_VHSLinesCenterMask;

		// Token: 0x040014ED RID: 5357
		internal static int __PropertyOffset_bOverride_VHSLinesStartDistance;

		// Token: 0x040014EE RID: 5358
		internal static byte __PropertyMask_bOverride_VHSLinesStartDistance;

		// Token: 0x040014EF RID: 5359
		internal static int __PropertyOffset_bOverride_VHSLinesCharacterIntensity;

		// Token: 0x040014F0 RID: 5360
		internal static byte __PropertyMask_bOverride_VHSLinesCharacterIntensity;

		// Token: 0x040014F1 RID: 5361
		internal static int __PropertyOffset_bOverride_VHSEffectCenterMask;

		// Token: 0x040014F2 RID: 5362
		internal static byte __PropertyMask_bOverride_VHSEffectCenterMask;

		// Token: 0x040014F3 RID: 5363
		internal static int __PropertyOffset_bOverride_VHSEffectStartDistance;

		// Token: 0x040014F4 RID: 5364
		internal static byte __PropertyMask_bOverride_VHSEffectStartDistance;

		// Token: 0x040014F5 RID: 5365
		internal static int __PropertyOffset_bOverride_VHSEffectCharacterIntensity;

		// Token: 0x040014F6 RID: 5366
		internal static byte __PropertyMask_bOverride_VHSEffectCharacterIntensity;

		// Token: 0x040014F7 RID: 5367
		internal static int __PropertyOffset_bOverride_VHSSpecklesCenterMask;

		// Token: 0x040014F8 RID: 5368
		internal static byte __PropertyMask_bOverride_VHSSpecklesCenterMask;

		// Token: 0x040014F9 RID: 5369
		internal static int __PropertyOffset_bOverride_VHSSpecklesStartDistance;

		// Token: 0x040014FA RID: 5370
		internal static byte __PropertyMask_bOverride_VHSSpecklesStartDistance;

		// Token: 0x040014FB RID: 5371
		internal static int __PropertyOffset_bOverride_VHSSpecklesCharacterIntensity;

		// Token: 0x040014FC RID: 5372
		internal static byte __PropertyMask_bOverride_VHSSpecklesCharacterIntensity;

		// Token: 0x040014FD RID: 5373
		internal static int __PropertyOffset_bOverride_AmbientOcclusionIntensity;

		// Token: 0x040014FE RID: 5374
		internal static byte __PropertyMask_bOverride_AmbientOcclusionIntensity;

		// Token: 0x040014FF RID: 5375
		internal static int __PropertyOffset_bOverride_ToonAmbientOcclusionEnabled;

		// Token: 0x04001500 RID: 5376
		internal static byte __PropertyMask_bOverride_ToonAmbientOcclusionEnabled;

		// Token: 0x04001501 RID: 5377
		internal static int __PropertyOffset_bOverride_ToonAmbientOcclusionRadius;

		// Token: 0x04001502 RID: 5378
		internal static byte __PropertyMask_bOverride_ToonAmbientOcclusionRadius;

		// Token: 0x04001503 RID: 5379
		internal static int __PropertyOffset_bOverride_ToonAmbientOcclusionIntensity;

		// Token: 0x04001504 RID: 5380
		internal static byte __PropertyMask_bOverride_ToonAmbientOcclusionIntensity;

		// Token: 0x04001505 RID: 5381
		internal static int __PropertyOffset_bOverride_ToonAmbientOcclusionPower;

		// Token: 0x04001506 RID: 5382
		internal static byte __PropertyMask_bOverride_ToonAmbientOcclusionPower;

		// Token: 0x04001507 RID: 5383
		internal static int __PropertyOffset_bOverride_ToonAmbientOcclusionColor;

		// Token: 0x04001508 RID: 5384
		internal static byte __PropertyMask_bOverride_ToonAmbientOcclusionColor;

		// Token: 0x04001509 RID: 5385
		internal static int __PropertyOffset_bOverride_AmbientOcclusionStaticFraction;

		// Token: 0x0400150A RID: 5386
		internal static byte __PropertyMask_bOverride_AmbientOcclusionStaticFraction;

		// Token: 0x0400150B RID: 5387
		internal static int __PropertyOffset_bOverride_AmbientOcclusionRadius;

		// Token: 0x0400150C RID: 5388
		internal static byte __PropertyMask_bOverride_AmbientOcclusionRadius;

		// Token: 0x0400150D RID: 5389
		internal static int __PropertyOffset_bOverride_AmbientOcclusionFadeDistance;

		// Token: 0x0400150E RID: 5390
		internal static byte __PropertyMask_bOverride_AmbientOcclusionFadeDistance;

		// Token: 0x0400150F RID: 5391
		internal static int __PropertyOffset_bOverride_AmbientOcclusionFadeRadius;

		// Token: 0x04001510 RID: 5392
		internal static byte __PropertyMask_bOverride_AmbientOcclusionFadeRadius;

		// Token: 0x04001511 RID: 5393
		internal static int __PropertyOffset_bOverride_AmbientOcclusionDistance_DEPRECATED;

		// Token: 0x04001512 RID: 5394
		internal static byte __PropertyMask_bOverride_AmbientOcclusionDistance_DEPRECATED;

		// Token: 0x04001513 RID: 5395
		internal static int __PropertyOffset_bOverride_AmbientOcclusionRadiusInWS;

		// Token: 0x04001514 RID: 5396
		internal static byte __PropertyMask_bOverride_AmbientOcclusionRadiusInWS;

		// Token: 0x04001515 RID: 5397
		internal static int __PropertyOffset_bOverride_AmbientOcclusionPower;

		// Token: 0x04001516 RID: 5398
		internal static byte __PropertyMask_bOverride_AmbientOcclusionPower;

		// Token: 0x04001517 RID: 5399
		internal static int __PropertyOffset_bOverride_AmbientOcclusionBias;

		// Token: 0x04001518 RID: 5400
		internal static byte __PropertyMask_bOverride_AmbientOcclusionBias;

		// Token: 0x04001519 RID: 5401
		internal static int __PropertyOffset_bOverride_AmbientOcclusionQuality;

		// Token: 0x0400151A RID: 5402
		internal static byte __PropertyMask_bOverride_AmbientOcclusionQuality;

		// Token: 0x0400151B RID: 5403
		internal static int __PropertyOffset_bOverride_AmbientOcclusionMipBlend;

		// Token: 0x0400151C RID: 5404
		internal static byte __PropertyMask_bOverride_AmbientOcclusionMipBlend;

		// Token: 0x0400151D RID: 5405
		internal static int __PropertyOffset_bOverride_AmbientOcclusionMipScale;

		// Token: 0x0400151E RID: 5406
		internal static byte __PropertyMask_bOverride_AmbientOcclusionMipScale;

		// Token: 0x0400151F RID: 5407
		internal static int __PropertyOffset_bOverride_AmbientOcclusionMipThreshold;

		// Token: 0x04001520 RID: 5408
		internal static byte __PropertyMask_bOverride_AmbientOcclusionMipThreshold;

		// Token: 0x04001521 RID: 5409
		internal static int __PropertyOffset_bOverride_AmbientOcclusionTemporalBlendWeight;

		// Token: 0x04001522 RID: 5410
		internal static byte __PropertyMask_bOverride_AmbientOcclusionTemporalBlendWeight;

		// Token: 0x04001523 RID: 5411
		internal static int __PropertyOffset_bOverride_RayTracingAO;

		// Token: 0x04001524 RID: 5412
		internal static byte __PropertyMask_bOverride_RayTracingAO;

		// Token: 0x04001525 RID: 5413
		internal static int __PropertyOffset_bOverride_RayTracingAOSamplesPerPixel;

		// Token: 0x04001526 RID: 5414
		internal static byte __PropertyMask_bOverride_RayTracingAOSamplesPerPixel;

		// Token: 0x04001527 RID: 5415
		internal static int __PropertyOffset_bOverride_RayTracingAOIntensity;

		// Token: 0x04001528 RID: 5416
		internal static byte __PropertyMask_bOverride_RayTracingAOIntensity;

		// Token: 0x04001529 RID: 5417
		internal static int __PropertyOffset_bOverride_RayTracingAORadius;

		// Token: 0x0400152A RID: 5418
		internal static byte __PropertyMask_bOverride_RayTracingAORadius;

		// Token: 0x0400152B RID: 5419
		internal static int __PropertyOffset_bOverride_LPVIntensity;

		// Token: 0x0400152C RID: 5420
		internal static byte __PropertyMask_bOverride_LPVIntensity;

		// Token: 0x0400152D RID: 5421
		internal static int __PropertyOffset_bOverride_LPVDirectionalOcclusionIntensity;

		// Token: 0x0400152E RID: 5422
		internal static byte __PropertyMask_bOverride_LPVDirectionalOcclusionIntensity;

		// Token: 0x0400152F RID: 5423
		internal static int __PropertyOffset_bOverride_LPVDirectionalOcclusionRadius;

		// Token: 0x04001530 RID: 5424
		internal static byte __PropertyMask_bOverride_LPVDirectionalOcclusionRadius;

		// Token: 0x04001531 RID: 5425
		internal static int __PropertyOffset_bOverride_LPVDiffuseOcclusionExponent;

		// Token: 0x04001532 RID: 5426
		internal static byte __PropertyMask_bOverride_LPVDiffuseOcclusionExponent;

		// Token: 0x04001533 RID: 5427
		internal static int __PropertyOffset_bOverride_LPVSpecularOcclusionExponent;

		// Token: 0x04001534 RID: 5428
		internal static byte __PropertyMask_bOverride_LPVSpecularOcclusionExponent;

		// Token: 0x04001535 RID: 5429
		internal static int __PropertyOffset_bOverride_LPVDiffuseOcclusionIntensity;

		// Token: 0x04001536 RID: 5430
		internal static byte __PropertyMask_bOverride_LPVDiffuseOcclusionIntensity;

		// Token: 0x04001537 RID: 5431
		internal static int __PropertyOffset_bOverride_LPVSpecularOcclusionIntensity;

		// Token: 0x04001538 RID: 5432
		internal static byte __PropertyMask_bOverride_LPVSpecularOcclusionIntensity;

		// Token: 0x04001539 RID: 5433
		internal static int __PropertyOffset_bOverride_LPVSize;

		// Token: 0x0400153A RID: 5434
		internal static byte __PropertyMask_bOverride_LPVSize;

		// Token: 0x0400153B RID: 5435
		internal static int __PropertyOffset_bOverride_LPVSecondaryOcclusionIntensity;

		// Token: 0x0400153C RID: 5436
		internal static byte __PropertyMask_bOverride_LPVSecondaryOcclusionIntensity;

		// Token: 0x0400153D RID: 5437
		internal static int __PropertyOffset_bOverride_LPVSecondaryBounceIntensity;

		// Token: 0x0400153E RID: 5438
		internal static byte __PropertyMask_bOverride_LPVSecondaryBounceIntensity;

		// Token: 0x0400153F RID: 5439
		internal static int __PropertyOffset_bOverride_LPVGeometryVolumeBias;

		// Token: 0x04001540 RID: 5440
		internal static byte __PropertyMask_bOverride_LPVGeometryVolumeBias;

		// Token: 0x04001541 RID: 5441
		internal static int __PropertyOffset_bOverride_LPVVplInjectionBias;

		// Token: 0x04001542 RID: 5442
		internal static byte __PropertyMask_bOverride_LPVVplInjectionBias;

		// Token: 0x04001543 RID: 5443
		internal static int __PropertyOffset_bOverride_LPVEmissiveInjectionIntensity;

		// Token: 0x04001544 RID: 5444
		internal static byte __PropertyMask_bOverride_LPVEmissiveInjectionIntensity;

		// Token: 0x04001545 RID: 5445
		internal static int __PropertyOffset_bOverride_LPVFadeRange;

		// Token: 0x04001546 RID: 5446
		internal static byte __PropertyMask_bOverride_LPVFadeRange;

		// Token: 0x04001547 RID: 5447
		internal static int __PropertyOffset_bOverride_LPVDirectionalOcclusionFadeRange;

		// Token: 0x04001548 RID: 5448
		internal static byte __PropertyMask_bOverride_LPVDirectionalOcclusionFadeRange;

		// Token: 0x04001549 RID: 5449
		internal static int __PropertyOffset_bOverride_LumenSkylightLeaking;

		// Token: 0x0400154A RID: 5450
		internal static byte __PropertyMask_bOverride_LumenSkylightLeaking;

		// Token: 0x0400154B RID: 5451
		internal static int __PropertyOffset_bOverride_IndirectLightingColor;

		// Token: 0x0400154C RID: 5452
		internal static byte __PropertyMask_bOverride_IndirectLightingColor;

		// Token: 0x0400154D RID: 5453
		internal static int __PropertyOffset_bOverride_IndirectLightingIntensity;

		// Token: 0x0400154E RID: 5454
		internal static byte __PropertyMask_bOverride_IndirectLightingIntensity;

		// Token: 0x0400154F RID: 5455
		internal static int __PropertyOffset_bOverride_ColorGradingIntensity;

		// Token: 0x04001550 RID: 5456
		internal static byte __PropertyMask_bOverride_ColorGradingIntensity;

		// Token: 0x04001551 RID: 5457
		internal static int __PropertyOffset_bOverride_ColorGradingLUT;

		// Token: 0x04001552 RID: 5458
		internal static byte __PropertyMask_bOverride_ColorGradingLUT;

		// Token: 0x04001553 RID: 5459
		internal static int __PropertyOffset_bOverride_DepthOfFieldFocalDistance;

		// Token: 0x04001554 RID: 5460
		internal static byte __PropertyMask_bOverride_DepthOfFieldFocalDistance;

		// Token: 0x04001555 RID: 5461
		internal static int __PropertyOffset_bOverride_DepthOfFieldFstop;

		// Token: 0x04001556 RID: 5462
		internal static byte __PropertyMask_bOverride_DepthOfFieldFstop;

		// Token: 0x04001557 RID: 5463
		internal static int __PropertyOffset_bOverride_DepthOfFieldMinFstop;

		// Token: 0x04001558 RID: 5464
		internal static byte __PropertyMask_bOverride_DepthOfFieldMinFstop;

		// Token: 0x04001559 RID: 5465
		internal static int __PropertyOffset_bOverride_DepthOfFieldBladeCount;

		// Token: 0x0400155A RID: 5466
		internal static byte __PropertyMask_bOverride_DepthOfFieldBladeCount;

		// Token: 0x0400155B RID: 5467
		internal static int __PropertyOffset_bOverride_DepthOfFieldForegroundBlur;

		// Token: 0x0400155C RID: 5468
		internal static byte __PropertyMask_bOverride_DepthOfFieldForegroundBlur;

		// Token: 0x0400155D RID: 5469
		internal static int __PropertyOffset_bOverride_DepthOfFieldSensorWidth;

		// Token: 0x0400155E RID: 5470
		internal static byte __PropertyMask_bOverride_DepthOfFieldSensorWidth;

		// Token: 0x0400155F RID: 5471
		internal static int __PropertyOffset_bOverride_DepthOfFieldDepthBlurRadius;

		// Token: 0x04001560 RID: 5472
		internal static byte __PropertyMask_bOverride_DepthOfFieldDepthBlurRadius;

		// Token: 0x04001561 RID: 5473
		internal static int __PropertyOffset_bOverride_DepthOfFieldDepthBlurAmount;

		// Token: 0x04001562 RID: 5474
		internal static byte __PropertyMask_bOverride_DepthOfFieldDepthBlurAmount;

		// Token: 0x04001563 RID: 5475
		internal static int __PropertyOffset_bOverride_DepthOfFieldFocalRegion;

		// Token: 0x04001564 RID: 5476
		internal static byte __PropertyMask_bOverride_DepthOfFieldFocalRegion;

		// Token: 0x04001565 RID: 5477
		internal static int __PropertyOffset_bOverride_DepthOfFieldNearTransitionRegion;

		// Token: 0x04001566 RID: 5478
		internal static byte __PropertyMask_bOverride_DepthOfFieldNearTransitionRegion;

		// Token: 0x04001567 RID: 5479
		internal static int __PropertyOffset_bOverride_DepthOfFieldFarTransitionRegion;

		// Token: 0x04001568 RID: 5480
		internal static byte __PropertyMask_bOverride_DepthOfFieldFarTransitionRegion;

		// Token: 0x04001569 RID: 5481
		internal static int __PropertyOffset_bOverride_DepthOfFieldScale;

		// Token: 0x0400156A RID: 5482
		internal static byte __PropertyMask_bOverride_DepthOfFieldScale;

		// Token: 0x0400156B RID: 5483
		internal static int __PropertyOffset_bOverride_DepthOfFieldNearBlurSize;

		// Token: 0x0400156C RID: 5484
		internal static byte __PropertyMask_bOverride_DepthOfFieldNearBlurSize;

		// Token: 0x0400156D RID: 5485
		internal static int __PropertyOffset_bOverride_DepthOfFieldFarBlurSize;

		// Token: 0x0400156E RID: 5486
		internal static byte __PropertyMask_bOverride_DepthOfFieldFarBlurSize;

		// Token: 0x0400156F RID: 5487
		internal static int __PropertyOffset_bOverride_MobileHQGaussian;

		// Token: 0x04001570 RID: 5488
		internal static byte __PropertyMask_bOverride_MobileHQGaussian;

		// Token: 0x04001571 RID: 5489
		internal static int __PropertyOffset_bOverride_KuroDangerToggle;

		// Token: 0x04001572 RID: 5490
		internal static byte __PropertyMask_bOverride_KuroDangerToggle;

		// Token: 0x04001573 RID: 5491
		internal static int __PropertyOffset_bOverride_DepthOfFieldOcclusion;

		// Token: 0x04001574 RID: 5492
		internal static byte __PropertyMask_bOverride_DepthOfFieldOcclusion;

		// Token: 0x04001575 RID: 5493
		internal static int __PropertyOffset_bOverride_DepthOfFieldSkyFocusDistance;

		// Token: 0x04001576 RID: 5494
		internal static byte __PropertyMask_bOverride_DepthOfFieldSkyFocusDistance;

		// Token: 0x04001577 RID: 5495
		internal static int __PropertyOffset_bOverride_DepthOfFieldVignetteSize;

		// Token: 0x04001578 RID: 5496
		internal static byte __PropertyMask_bOverride_DepthOfFieldVignetteSize;

		// Token: 0x04001579 RID: 5497
		internal static int __PropertyOffset_bOverride_MotionBlurAmount;

		// Token: 0x0400157A RID: 5498
		internal static byte __PropertyMask_bOverride_MotionBlurAmount;

		// Token: 0x0400157B RID: 5499
		internal static int __PropertyOffset_bOverride_MotionBlurMax;

		// Token: 0x0400157C RID: 5500
		internal static byte __PropertyMask_bOverride_MotionBlurMax;

		// Token: 0x0400157D RID: 5501
		internal static int __PropertyOffset_bOverride_MotionBlurTargetFPS;

		// Token: 0x0400157E RID: 5502
		internal static byte __PropertyMask_bOverride_MotionBlurTargetFPS;

		// Token: 0x0400157F RID: 5503
		internal static int __PropertyOffset_bOverride_MotionBlurPerObjectSize;

		// Token: 0x04001580 RID: 5504
		internal static byte __PropertyMask_bOverride_MotionBlurPerObjectSize;

		// Token: 0x04001581 RID: 5505
		internal static int __PropertyOffset_bOverride_ScreenPercentage;

		// Token: 0x04001582 RID: 5506
		internal static byte __PropertyMask_bOverride_ScreenPercentage;

		// Token: 0x04001583 RID: 5507
		internal static int __PropertyOffset_bOverride_MotionBlurCharacterMask;

		// Token: 0x04001584 RID: 5508
		internal static byte __PropertyMask_bOverride_MotionBlurCharacterMask;

		// Token: 0x04001585 RID: 5509
		internal static int __PropertyOffset_bOverride_WithOutTranslucent;

		// Token: 0x04001586 RID: 5510
		internal static byte __PropertyMask_bOverride_WithOutTranslucent;

		// Token: 0x04001587 RID: 5511
		internal static int __PropertyOffset_bOverride_StartPosSwitch;

		// Token: 0x04001588 RID: 5512
		internal static byte __PropertyMask_bOverride_StartPosSwitch;

		// Token: 0x04001589 RID: 5513
		internal static int __PropertyOffset_bOverride_GrayGradationStartPos;

		// Token: 0x0400158A RID: 5514
		internal static byte __PropertyMask_bOverride_GrayGradationStartPos;

		// Token: 0x0400158B RID: 5515
		internal static int __PropertyOffset_bOverride_GrayGradationDegree;

		// Token: 0x0400158C RID: 5516
		internal static byte __PropertyMask_bOverride_GrayGradationDegree;

		// Token: 0x0400158D RID: 5517
		internal static int __PropertyOffset_bOverride_GrayLerpWidth;

		// Token: 0x0400158E RID: 5518
		internal static byte __PropertyMask_bOverride_GrayLerpWidth;

		// Token: 0x0400158F RID: 5519
		internal static int __PropertyOffset_bOverride_GrayRampColor;

		// Token: 0x04001590 RID: 5520
		internal static byte __PropertyMask_bOverride_GrayRampColor;

		// Token: 0x04001591 RID: 5521
		internal static int __PropertyOffset_bOverride_GrayRampTint;

		// Token: 0x04001592 RID: 5522
		internal static byte __PropertyMask_bOverride_GrayRampTint;

		// Token: 0x04001593 RID: 5523
		internal static int __PropertyOffset_bOverride_GrayRampBlendWeight;

		// Token: 0x04001594 RID: 5524
		internal static byte __PropertyMask_bOverride_GrayRampBlendWeight;

		// Token: 0x04001595 RID: 5525
		internal static int __PropertyOffset_bOverride_SNNIntensity;

		// Token: 0x04001596 RID: 5526
		internal static byte __PropertyMask_bOverride_SNNIntensity;

		// Token: 0x04001597 RID: 5527
		internal static int __PropertyOffset_bOverride_SNNRoughnessContrast;

		// Token: 0x04001598 RID: 5528
		internal static byte __PropertyMask_bOverride_SNNRoughnessContrast;

		// Token: 0x04001599 RID: 5529
		internal static int __PropertyOffset_bOverride_SNNMetallicThreshold;

		// Token: 0x0400159A RID: 5530
		internal static byte __PropertyMask_bOverride_SNNMetallicThreshold;

		// Token: 0x0400159B RID: 5531
		internal static int __PropertyOffset_bOverride_SNNDepthFade;

		// Token: 0x0400159C RID: 5532
		internal static byte __PropertyMask_bOverride_SNNDepthFade;

		// Token: 0x0400159D RID: 5533
		internal static int __PropertyOffset_bOverride_SNNFoliageIntensity;

		// Token: 0x0400159E RID: 5534
		internal static byte __PropertyMask_bOverride_SNNFoliageIntensity;

		// Token: 0x0400159F RID: 5535
		internal static int __PropertyOffset_bOverride_SNNStructureIntensity;

		// Token: 0x040015A0 RID: 5536
		internal static byte __PropertyMask_bOverride_SNNStructureIntensity;

		// Token: 0x040015A1 RID: 5537
		internal static int __PropertyOffset_bOverride_SNNNoiseIntensity;

		// Token: 0x040015A2 RID: 5538
		internal static byte __PropertyMask_bOverride_SNNNoiseIntensity;

		// Token: 0x040015A3 RID: 5539
		internal static int __PropertyOffset_bOverride_SNNEnableSharpen;

		// Token: 0x040015A4 RID: 5540
		internal static byte __PropertyMask_bOverride_SNNEnableSharpen;

		// Token: 0x040015A5 RID: 5541
		internal static int __PropertyOffset_bOverride_SNNSharpeness;

		// Token: 0x040015A6 RID: 5542
		internal static byte __PropertyMask_bOverride_SNNSharpeness;

		// Token: 0x040015A7 RID: 5543
		internal static int __PropertyOffset_bOverride_SNNSharpenDepthFade;

		// Token: 0x040015A8 RID: 5544
		internal static byte __PropertyMask_bOverride_SNNSharpenDepthFade;

		// Token: 0x040015A9 RID: 5545
		internal static int __PropertyOffset_bOverride_SSFSIntensity;

		// Token: 0x040015AA RID: 5546
		internal static byte __PropertyMask_bOverride_SSFSIntensity;

		// Token: 0x040015AB RID: 5547
		internal static int __PropertyOffset_bOverride_SSFSRadius;

		// Token: 0x040015AC RID: 5548
		internal static byte __PropertyMask_bOverride_SSFSRadius;

		// Token: 0x040015AD RID: 5549
		internal static int __PropertyOffset_bOverride_SSFSLuminanceWeighting;

		// Token: 0x040015AE RID: 5550
		internal static byte __PropertyMask_bOverride_SSFSLuminanceWeighting;

		// Token: 0x040015AF RID: 5551
		internal static int __PropertyOffset_bOverride_SSFSSkyAtmosphereIntensity;

		// Token: 0x040015B0 RID: 5552
		internal static byte __PropertyMask_bOverride_SSFSSkyAtmosphereIntensity;

		// Token: 0x040015B1 RID: 5553
		internal static int __PropertyOffset_bOverride_SSFSVolumetricFogILSIntensity;

		// Token: 0x040015B2 RID: 5554
		internal static byte __PropertyMask_bOverride_SSFSVolumetricFogILSIntensity;

		// Token: 0x040015B3 RID: 5555
		internal static int __PropertyOffset_bOverride_SSFSKuroVolumetricLightILSIntensity;

		// Token: 0x040015B4 RID: 5556
		internal static byte __PropertyMask_bOverride_SSFSKuroVolumetricLightILSIntensity;

		// Token: 0x040015B5 RID: 5557
		internal static int __PropertyOffset_bOverride_SSFSStartDistance;

		// Token: 0x040015B6 RID: 5558
		internal static byte __PropertyMask_bOverride_SSFSStartDistance;

		// Token: 0x040015B7 RID: 5559
		internal static int __PropertyOffset_bOverride_SSFSMaxDepth;

		// Token: 0x040015B8 RID: 5560
		internal static byte __PropertyMask_bOverride_SSFSMaxDepth;

		// Token: 0x040015B9 RID: 5561
		internal static int __PropertyOffset_bOverride_EnableMobileSSFS;

		// Token: 0x040015BA RID: 5562
		internal static byte __PropertyMask_bOverride_EnableMobileSSFS;

		// Token: 0x040015BB RID: 5563
		internal static int __PropertyOffset_bOverride_MobileSSFSFogDensity;

		// Token: 0x040015BC RID: 5564
		internal static byte __PropertyMask_bOverride_MobileSSFSFogDensity;

		// Token: 0x040015BD RID: 5565
		internal static int __PropertyOffset_bOverride_MobileSSFSIntensity;

		// Token: 0x040015BE RID: 5566
		internal static byte __PropertyMask_bOverride_MobileSSFSIntensity;

		// Token: 0x040015BF RID: 5567
		internal static int __PropertyOffset_bOverride_MobileSSFSRadius;

		// Token: 0x040015C0 RID: 5568
		internal static byte __PropertyMask_bOverride_MobileSSFSRadius;

		// Token: 0x040015C1 RID: 5569
		internal static int __PropertyOffset_bOverride_MobileSSFSStartDistance;

		// Token: 0x040015C2 RID: 5570
		internal static byte __PropertyMask_bOverride_MobileSSFSStartDistance;

		// Token: 0x040015C3 RID: 5571
		internal static int __PropertyOffset_bOverride_KuroSharpenRadius;

		// Token: 0x040015C4 RID: 5572
		internal static byte __PropertyMask_bOverride_KuroSharpenRadius;

		// Token: 0x040015C5 RID: 5573
		internal static int __PropertyOffset_bOverride_KuroSharpenAmount;

		// Token: 0x040015C6 RID: 5574
		internal static byte __PropertyMask_bOverride_KuroSharpenAmount;

		// Token: 0x040015C7 RID: 5575
		internal static int __PropertyOffset_bOverride_KuroLaplacianAmount;

		// Token: 0x040015C8 RID: 5576
		internal static byte __PropertyMask_bOverride_KuroLaplacianAmount;

		// Token: 0x040015C9 RID: 5577
		internal static int __PropertyOffset_bOverride_KuroSharpenIntensity;

		// Token: 0x040015CA RID: 5578
		internal static byte __PropertyMask_bOverride_KuroSharpenIntensity;

		// Token: 0x040015CB RID: 5579
		internal static int __PropertyOffset_bOverride_KuroToonSharpenIntensity;

		// Token: 0x040015CC RID: 5580
		internal static byte __PropertyMask_bOverride_KuroToonSharpenIntensity;

		// Token: 0x040015CD RID: 5581
		internal static int __PropertyOffset_bOverride_KuroSharpenDistance;

		// Token: 0x040015CE RID: 5582
		internal static byte __PropertyMask_bOverride_KuroSharpenDistance;

		// Token: 0x040015CF RID: 5583
		internal static int __PropertyOffset_bOverride_TyndallScaLightIntensity;

		// Token: 0x040015D0 RID: 5584
		internal static byte __PropertyMask_bOverride_TyndallScaLightIntensity;

		// Token: 0x040015D1 RID: 5585
		internal static int __PropertyOffset_bOverride_TyndallDarkIntensity;

		// Token: 0x040015D2 RID: 5586
		internal static byte __PropertyMask_bOverride_TyndallDarkIntensity;

		// Token: 0x040015D3 RID: 5587
		internal static int __PropertyOffset_bOverride_TyndallScaLightLength;

		// Token: 0x040015D4 RID: 5588
		internal static byte __PropertyMask_bOverride_TyndallScaLightLength;

		// Token: 0x040015D5 RID: 5589
		internal static int __PropertyOffset_bOverride_TyndallScaLightColor;

		// Token: 0x040015D6 RID: 5590
		internal static byte __PropertyMask_bOverride_TyndallScaLightColor;

		// Token: 0x040015D7 RID: 5591
		internal static int __PropertyOffset_bOverride_TyndallScaLightFade;

		// Token: 0x040015D8 RID: 5592
		internal static byte __PropertyMask_bOverride_TyndallScaLightFade;

		// Token: 0x040015D9 RID: 5593
		internal static int __PropertyOffset_bOverride_TyndallScaLightMode;

		// Token: 0x040015DA RID: 5594
		internal static byte __PropertyMask_bOverride_TyndallScaLightMode;

		// Token: 0x040015DB RID: 5595
		internal static int __PropertyOffset_bOverride_TyndallScaNearFade;

		// Token: 0x040015DC RID: 5596
		internal static byte __PropertyMask_bOverride_TyndallScaNearFade;

		// Token: 0x040015DD RID: 5597
		internal static int __PropertyOffset_bOverride_TyndallScaDarkFadeDepth;

		// Token: 0x040015DE RID: 5598
		internal static byte __PropertyMask_bOverride_TyndallScaDarkFadeDepth;

		// Token: 0x040015DF RID: 5599
		internal static int __PropertyOffset_bOverride_TyndallScaMaxDepth;

		// Token: 0x040015E0 RID: 5600
		internal static byte __PropertyMask_bOverride_TyndallScaMaxDepth;

		// Token: 0x040015E1 RID: 5601
		internal static int __PropertyOffset_bOverride_EnableCustomPosition;

		// Token: 0x040015E2 RID: 5602
		internal static byte __PropertyMask_bOverride_EnableCustomPosition;

		// Token: 0x040015E3 RID: 5603
		internal static int __PropertyOffset_bOverride_TyndallCustomPosition;

		// Token: 0x040015E4 RID: 5604
		internal static byte __PropertyMask_bOverride_TyndallCustomPosition;

		// Token: 0x040015E5 RID: 5605
		internal static int __PropertyOffset_bOverride_KuroVolumetricLightEnable;

		// Token: 0x040015E6 RID: 5606
		internal static byte __PropertyMask_bOverride_KuroVolumetricLightEnable;

		// Token: 0x040015E7 RID: 5607
		internal static int __PropertyOffset_bOverride_KuroVolumetricLightIntensity;

		// Token: 0x040015E8 RID: 5608
		internal static byte __PropertyMask_bOverride_KuroVolumetricLightIntensity;

		// Token: 0x040015E9 RID: 5609
		internal static int __PropertyOffset_bOverride_KuroVolumetricLightColor;

		// Token: 0x040015EA RID: 5610
		internal static byte __PropertyMask_bOverride_KuroVolumetricLightColor;

		// Token: 0x040015EB RID: 5611
		internal static int __PropertyOffset_bOverride_KuroVolumetricLightPhaseG;

		// Token: 0x040015EC RID: 5612
		internal static byte __PropertyMask_bOverride_KuroVolumetricLightPhaseG;

		// Token: 0x040015ED RID: 5613
		internal static int __PropertyOffset_bOverride_KuroVolumetricLightMaxDistance;

		// Token: 0x040015EE RID: 5614
		internal static byte __PropertyMask_bOverride_KuroVolumetricLightMaxDistance;

		// Token: 0x040015EF RID: 5615
		internal static int __PropertyOffset_bOverride_KuroVolumetricLightBlurRadius;

		// Token: 0x040015F0 RID: 5616
		internal static byte __PropertyMask_bOverride_KuroVolumetricLightBlurRadius;

		// Token: 0x040015F1 RID: 5617
		internal static int __PropertyOffset_bOverride_KuroVolumetricLightUseColorMask;

		// Token: 0x040015F2 RID: 5618
		internal static byte __PropertyMask_bOverride_KuroVolumetricLightUseColorMask;

		// Token: 0x040015F3 RID: 5619
		internal static int __PropertyOffset_bOverride_KuroVolumetricLightColorMaskIntensity;

		// Token: 0x040015F4 RID: 5620
		internal static byte __PropertyMask_bOverride_KuroVolumetricLightColorMaskIntensity;

		// Token: 0x040015F5 RID: 5621
		internal static int __PropertyOffset_bOverride_ScreenSpaceReflectionIntensity;

		// Token: 0x040015F6 RID: 5622
		internal static byte __PropertyMask_bOverride_ScreenSpaceReflectionIntensity;

		// Token: 0x040015F7 RID: 5623
		internal static int __PropertyOffset_bOverride_ScreenSpaceReflectionQuality;

		// Token: 0x040015F8 RID: 5624
		internal static byte __PropertyMask_bOverride_ScreenSpaceReflectionQuality;

		// Token: 0x040015F9 RID: 5625
		internal static int __PropertyOffset_bOverride_ScreenSpaceReflectionMaxRoughness;

		// Token: 0x040015FA RID: 5626
		internal static byte __PropertyMask_bOverride_ScreenSpaceReflectionMaxRoughness;

		// Token: 0x040015FB RID: 5627
		internal static int __PropertyOffset_bOverride_KuroTonemapA;

		// Token: 0x040015FC RID: 5628
		internal static byte __PropertyMask_bOverride_KuroTonemapA;

		// Token: 0x040015FD RID: 5629
		internal static int __PropertyOffset_bOverride_KuroTonemapB;

		// Token: 0x040015FE RID: 5630
		internal static byte __PropertyMask_bOverride_KuroTonemapB;

		// Token: 0x040015FF RID: 5631
		internal static int __PropertyOffset_bOverride_KuroTonemapC;

		// Token: 0x04001600 RID: 5632
		internal static byte __PropertyMask_bOverride_KuroTonemapC;

		// Token: 0x04001601 RID: 5633
		internal static int __PropertyOffset_bOverride_KuroTonemapD;

		// Token: 0x04001602 RID: 5634
		internal static byte __PropertyMask_bOverride_KuroTonemapD;

		// Token: 0x04001603 RID: 5635
		internal static int __PropertyOffset_bOverride_KuroTonemapE;

		// Token: 0x04001604 RID: 5636
		internal static byte __PropertyMask_bOverride_KuroTonemapE;

		// Token: 0x04001605 RID: 5637
		internal static int __PropertyOffset_bOverride_KuroTonemapF;

		// Token: 0x04001606 RID: 5638
		internal static byte __PropertyMask_bOverride_KuroTonemapF;

		// Token: 0x04001607 RID: 5639
		internal static int __PropertyOffset_bOverride_UseCharacterMask;

		// Token: 0x04001608 RID: 5640
		internal static byte __PropertyMask_bOverride_UseCharacterMask;

		// Token: 0x04001609 RID: 5641
		internal static int __PropertyOffset_bOverride_ScreenSpaceReflectionRoughnessScale;

		// Token: 0x0400160A RID: 5642
		internal static byte __PropertyMask_bOverride_ScreenSpaceReflectionRoughnessScale;

		// Token: 0x0400160B RID: 5643
		internal static int __PropertyOffset_bOverride_ReflectionsType;

		// Token: 0x0400160C RID: 5644
		internal static byte __PropertyMask_bOverride_ReflectionsType;

		// Token: 0x0400160D RID: 5645
		internal static int __PropertyOffset_bOverride_RayTracingReflectionsMaxRoughness;

		// Token: 0x0400160E RID: 5646
		internal static byte __PropertyMask_bOverride_RayTracingReflectionsMaxRoughness;

		// Token: 0x0400160F RID: 5647
		internal static int __PropertyOffset_bOverride_RayTracingReflectionsMaxBounces;

		// Token: 0x04001610 RID: 5648
		internal static byte __PropertyMask_bOverride_RayTracingReflectionsMaxBounces;

		// Token: 0x04001611 RID: 5649
		internal static int __PropertyOffset_bOverride_RayTracingReflectionsSamplesPerPixel;

		// Token: 0x04001612 RID: 5650
		internal static byte __PropertyMask_bOverride_RayTracingReflectionsSamplesPerPixel;

		// Token: 0x04001613 RID: 5651
		internal static int __PropertyOffset_bOverride_RayTracingReflectionsShadows;

		// Token: 0x04001614 RID: 5652
		internal static byte __PropertyMask_bOverride_RayTracingReflectionsShadows;

		// Token: 0x04001615 RID: 5653
		internal static int __PropertyOffset_bOverride_RayTracingReflectionsTranslucency;

		// Token: 0x04001616 RID: 5654
		internal static byte __PropertyMask_bOverride_RayTracingReflectionsTranslucency;

		// Token: 0x04001617 RID: 5655
		internal static int __PropertyOffset_bOverride_TranslucencyType;

		// Token: 0x04001618 RID: 5656
		internal static byte __PropertyMask_bOverride_TranslucencyType;

		// Token: 0x04001619 RID: 5657
		internal static int __PropertyOffset_bOverride_RayTracingTranslucencyMaxRoughness;

		// Token: 0x0400161A RID: 5658
		internal static byte __PropertyMask_bOverride_RayTracingTranslucencyMaxRoughness;

		// Token: 0x0400161B RID: 5659
		internal static int __PropertyOffset_bOverride_RayTracingTranslucencyRefractionRays;

		// Token: 0x0400161C RID: 5660
		internal static byte __PropertyMask_bOverride_RayTracingTranslucencyRefractionRays;

		// Token: 0x0400161D RID: 5661
		internal static int __PropertyOffset_bOverride_RayTracingTranslucencySamplesPerPixel;

		// Token: 0x0400161E RID: 5662
		internal static byte __PropertyMask_bOverride_RayTracingTranslucencySamplesPerPixel;

		// Token: 0x0400161F RID: 5663
		internal static int __PropertyOffset_bOverride_RayTracingTranslucencyShadows;

		// Token: 0x04001620 RID: 5664
		internal static byte __PropertyMask_bOverride_RayTracingTranslucencyShadows;

		// Token: 0x04001621 RID: 5665
		internal static int __PropertyOffset_bOverride_RayTracingTranslucencyRefraction;

		// Token: 0x04001622 RID: 5666
		internal static byte __PropertyMask_bOverride_RayTracingTranslucencyRefraction;

		// Token: 0x04001623 RID: 5667
		internal static int __PropertyOffset_bOverride_RayTracingGI;

		// Token: 0x04001624 RID: 5668
		internal static byte __PropertyMask_bOverride_RayTracingGI;

		// Token: 0x04001625 RID: 5669
		internal static int __PropertyOffset_bOverride_RayTracingGIMaxBounces;

		// Token: 0x04001626 RID: 5670
		internal static byte __PropertyMask_bOverride_RayTracingGIMaxBounces;

		// Token: 0x04001627 RID: 5671
		internal static int __PropertyOffset_bOverride_RayTracingGISamplesPerPixel;

		// Token: 0x04001628 RID: 5672
		internal static byte __PropertyMask_bOverride_RayTracingGISamplesPerPixel;

		// Token: 0x04001629 RID: 5673
		internal static int __PropertyOffset_bOverride_PathTracingMaxBounces;

		// Token: 0x0400162A RID: 5674
		internal static byte __PropertyMask_bOverride_PathTracingMaxBounces;

		// Token: 0x0400162B RID: 5675
		internal static int __PropertyOffset_bOverride_PathTracingSamplesPerPixel;

		// Token: 0x0400162C RID: 5676
		internal static byte __PropertyMask_bOverride_PathTracingSamplesPerPixel;

		// Token: 0x0400162D RID: 5677
		internal static int __PropertyOffset_bKuroDangerToggle;

		// Token: 0x0400162E RID: 5678
		internal static byte __PropertyMask_bKuroDangerToggle;

		// Token: 0x0400162F RID: 5679
		internal static int __PropertyOffset_bMobileHQGaussian;

		// Token: 0x04001630 RID: 5680
		internal static byte __PropertyMask_bMobileHQGaussian;

		// Token: 0x04001631 RID: 5681
		internal static int __PropertyOffset_bOverride_KuroCharacterLUTSplitEnable;

		// Token: 0x04001632 RID: 5682
		internal static byte __PropertyMask_bOverride_KuroCharacterLUTSplitEnable;

		// Token: 0x04001633 RID: 5683
		internal static int __PropertyOffset_bOverride_KuroCharacterColorGradingLUT;

		// Token: 0x04001634 RID: 5684
		internal static byte __PropertyMask_bOverride_KuroCharacterColorGradingLUT;

		// Token: 0x04001635 RID: 5685
		internal static int __PropertyOffset_bOverride_KuroCharacterColorGradingLUTLerpIntensity;

		// Token: 0x04001636 RID: 5686
		internal static byte __PropertyMask_bOverride_KuroCharacterColorGradingLUTLerpIntensity;

		// Token: 0x04001637 RID: 5687
		internal static int __PropertyOffset_bOverride_KuroColorGradingTextureLUTInterpolationEnable;

		// Token: 0x04001638 RID: 5688
		internal static byte __PropertyMask_bOverride_KuroColorGradingTextureLUTInterpolationEnable;

		// Token: 0x04001639 RID: 5689
		internal static int __PropertyOffset_KuroTonemapA;

		// Token: 0x0400163A RID: 5690
		internal static int __PropertyOffset_KuroTonemapB;

		// Token: 0x0400163B RID: 5691
		internal static int __PropertyOffset_KuroTonemapC;

		// Token: 0x0400163C RID: 5692
		internal static int __PropertyOffset_KuroTonemapD;

		// Token: 0x0400163D RID: 5693
		internal static int __PropertyOffset_KuroTonemapE;

		// Token: 0x0400163E RID: 5694
		internal static int __PropertyOffset_KuroTonemapF;

		// Token: 0x0400163F RID: 5695
		internal static int __PropertyOffset_UseCharacterMask;

		// Token: 0x04001640 RID: 5696
		internal static int __PropertyOffset_WhiteTemp;

		// Token: 0x04001641 RID: 5697
		internal static int __PropertyOffset_WhiteTint;

		// Token: 0x04001642 RID: 5698
		internal static int __PropertyOffset_ColorSaturation;

		// Token: 0x04001643 RID: 5699
		internal static int __PropertyOffset_ColorContrast;

		// Token: 0x04001644 RID: 5700
		internal static int __PropertyOffset_ColorGamma;

		// Token: 0x04001645 RID: 5701
		internal static int __PropertyOffset_ColorGain;

		// Token: 0x04001646 RID: 5702
		internal static int __PropertyOffset_ColorOffset;

		// Token: 0x04001647 RID: 5703
		internal static int __PropertyOffset_ColorSaturationClient;

		// Token: 0x04001648 RID: 5704
		internal static int __PropertyOffset_ColorContrastClient;

		// Token: 0x04001649 RID: 5705
		internal static int __PropertyOffset_ColorSaturationShadows;

		// Token: 0x0400164A RID: 5706
		internal static int __PropertyOffset_ColorContrastShadows;

		// Token: 0x0400164B RID: 5707
		internal static int __PropertyOffset_ColorGammaShadows;

		// Token: 0x0400164C RID: 5708
		internal static int __PropertyOffset_ColorGainShadows;

		// Token: 0x0400164D RID: 5709
		internal static int __PropertyOffset_ColorOffsetShadows;

		// Token: 0x0400164E RID: 5710
		internal static int __PropertyOffset_ColorSaturationMidtones;

		// Token: 0x0400164F RID: 5711
		internal static int __PropertyOffset_ColorContrastMidtones;

		// Token: 0x04001650 RID: 5712
		internal static int __PropertyOffset_ColorGammaMidtones;

		// Token: 0x04001651 RID: 5713
		internal static int __PropertyOffset_ColorGainMidtones;

		// Token: 0x04001652 RID: 5714
		internal static int __PropertyOffset_ColorOffsetMidtones;

		// Token: 0x04001653 RID: 5715
		internal static int __PropertyOffset_ColorSaturationHighlights;

		// Token: 0x04001654 RID: 5716
		internal static int __PropertyOffset_ColorContrastHighlights;

		// Token: 0x04001655 RID: 5717
		internal static int __PropertyOffset_ColorGammaHighlights;

		// Token: 0x04001656 RID: 5718
		internal static int __PropertyOffset_ColorGainHighlights;

		// Token: 0x04001657 RID: 5719
		internal static int __PropertyOffset_ColorOffsetHighlights;

		// Token: 0x04001658 RID: 5720
		internal static int __PropertyOffset_ColorCorrectionHighlightsMin;

		// Token: 0x04001659 RID: 5721
		internal static int __PropertyOffset_ColorCorrectionShadowsMax;

		// Token: 0x0400165A RID: 5722
		internal static int __PropertyOffset_BlueCorrection;

		// Token: 0x0400165B RID: 5723
		internal static int __PropertyOffset_ExpandGamut;

		// Token: 0x0400165C RID: 5724
		internal static int __PropertyOffset_ToneCurveAmount;

		// Token: 0x0400165D RID: 5725
		internal static int __PropertyOffset_FilmSlope;

		// Token: 0x0400165E RID: 5726
		internal static int __PropertyOffset_FilmToe;

		// Token: 0x0400165F RID: 5727
		internal static int __PropertyOffset_FilmShoulder;

		// Token: 0x04001660 RID: 5728
		internal static int __PropertyOffset_FilmBlackClip;

		// Token: 0x04001661 RID: 5729
		internal static int __PropertyOffset_FilmWhiteClip;

		// Token: 0x04001662 RID: 5730
		internal static int __PropertyOffset_FilmWhitePoint;

		// Token: 0x04001663 RID: 5731
		internal static int __PropertyOffset_FilmShadowTint;

		// Token: 0x04001664 RID: 5732
		internal static int __PropertyOffset_FilmShadowTintBlend;

		// Token: 0x04001665 RID: 5733
		internal static int __PropertyOffset_FilmShadowTintAmount;

		// Token: 0x04001666 RID: 5734
		internal static int __PropertyOffset_FilmSaturation;

		// Token: 0x04001667 RID: 5735
		internal static int __PropertyOffset_FilmChannelMixerRed;

		// Token: 0x04001668 RID: 5736
		internal static int __PropertyOffset_FilmChannelMixerGreen;

		// Token: 0x04001669 RID: 5737
		internal static int __PropertyOffset_FilmChannelMixerBlue;

		// Token: 0x0400166A RID: 5738
		internal static int __PropertyOffset_FilmContrast;

		// Token: 0x0400166B RID: 5739
		internal static int __PropertyOffset_FilmToeAmount;

		// Token: 0x0400166C RID: 5740
		internal static int __PropertyOffset_FilmHealAmount;

		// Token: 0x0400166D RID: 5741
		internal static int __PropertyOffset_FilmDynamicRange;

		// Token: 0x0400166E RID: 5742
		internal static int __PropertyOffset_SceneColorTint;

		// Token: 0x0400166F RID: 5743
		internal static int __PropertyOffset_DecalSaturation;

		// Token: 0x04001670 RID: 5744
		internal static int __PropertyOffset_DecalOpacity;

		// Token: 0x04001671 RID: 5745
		internal static int __PropertyOffset_TranslucentColorTint;

		// Token: 0x04001672 RID: 5746
		internal static int __PropertyOffset_SceneColorDesaturate;

		// Token: 0x04001673 RID: 5747
		internal static int __PropertyOffset_SceneObjectSaturation;

		// Token: 0x04001674 RID: 5748
		internal static int __PropertyOffset_SceneColorClear;

		// Token: 0x04001675 RID: 5749
		internal static int __PropertyOffset_SceneColorClearColor;

		// Token: 0x04001676 RID: 5750
		internal static int __PropertyOffset_SceneColorClearCenter;

		// Token: 0x04001677 RID: 5751
		internal static int __PropertyOffset_SceneColorClearRadius;

		// Token: 0x04001678 RID: 5752
		internal static int __PropertyOffset_SceneColorClearFadeDistance;

		// Token: 0x04001679 RID: 5753
		internal static int __PropertyOffset_TranslucentColorDesaturate;

		// Token: 0x0400167A RID: 5754
		internal static int __PropertyOffset_FightTranslucentNoDesaturate;

		// Token: 0x0400167B RID: 5755
		internal static int __PropertyOffset_SceneTranslucentColorTint;

		// Token: 0x0400167C RID: 5756
		internal static int __PropertyOffset_SceneEmissiveTint;

		// Token: 0x0400167D RID: 5757
		internal static int __PropertyOffset_SceneTranslucentColorDesaturate;

		// Token: 0x0400167E RID: 5758
		internal static int __PropertyOffset_SeparateTranslucencyBlurSize;

		// Token: 0x0400167F RID: 5759
		internal static int __PropertyOffset_EnableSPD;

		// Token: 0x04001680 RID: 5760
		internal static byte __PropertyMask_EnableSPD;

		// Token: 0x04001681 RID: 5761
		internal static int __PropertyOffset_SceneFringeIntensity;

		// Token: 0x04001682 RID: 5762
		internal static int __PropertyOffset_ChromaticAberrationStartOffset;

		// Token: 0x04001683 RID: 5763
		internal static int __PropertyOffset_BaoChromaticAberrationIntensity;

		// Token: 0x04001684 RID: 5764
		internal static int __PropertyOffset_BaoChromaticAberrationMaskCenter;

		// Token: 0x04001685 RID: 5765
		internal static int __PropertyOffset_BaoChromaticAberrationYScale;

		// Token: 0x04001686 RID: 5766
		internal static int __PropertyOffset_BaoChromaticAberrationYPan;

		// Token: 0x04001687 RID: 5767
		internal static int __PropertyOffset_KuroFoliageMaterialAO;

		// Token: 0x04001688 RID: 5768
		internal static int __PropertyOffset_KuroFoliageScreenSpaceAO;

		// Token: 0x04001689 RID: 5769
		internal static int __PropertyOffset_UseFixCharacterRim;

		// Token: 0x0400168A RID: 5770
		internal static byte __PropertyMask_UseFixCharacterRim;

		// Token: 0x0400168B RID: 5771
		internal static int __PropertyOffset_FixCharacterRimAngleV;

		// Token: 0x0400168C RID: 5772
		internal static int __PropertyOffset_FixCharacterRimAngleH;

		// Token: 0x0400168D RID: 5773
		internal static int __PropertyOffset_UseCustomRim;

		// Token: 0x0400168E RID: 5774
		internal static byte __PropertyMask_UseCustomRim;

		// Token: 0x0400168F RID: 5775
		internal static int __PropertyOffset_CustomRimColor_Stencil1;

		// Token: 0x04001690 RID: 5776
		internal static int __PropertyOffset_FixCharacterRimAngleV_Stencil1;

		// Token: 0x04001691 RID: 5777
		internal static int __PropertyOffset_FixCharacterRimAngleH_Stencil1;

		// Token: 0x04001692 RID: 5778
		internal static int __PropertyOffset_CustomRimColor_Stencil2;

		// Token: 0x04001693 RID: 5779
		internal static int __PropertyOffset_FixCharacterRimAngleV_Stencil2;

		// Token: 0x04001694 RID: 5780
		internal static int __PropertyOffset_FixCharacterRimAngleH_Stencil2;

		// Token: 0x04001695 RID: 5781
		internal static int __PropertyOffset_CustomRimColor_Stencil3;

		// Token: 0x04001696 RID: 5782
		internal static int __PropertyOffset_FixCharacterRimAngleV_Stencil3;

		// Token: 0x04001697 RID: 5783
		internal static int __PropertyOffset_FixCharacterRimAngleH_Stencil3;

		// Token: 0x04001698 RID: 5784
		internal static int __PropertyOffset_KuroBloomIntensity;

		// Token: 0x04001699 RID: 5785
		internal static int __PropertyOffset_KuroBloomThreshold;

		// Token: 0x0400169A RID: 5786
		internal static int __PropertyOffset_EnableSplitCharBloom;

		// Token: 0x0400169B RID: 5787
		internal static byte __PropertyMask_EnableSplitCharBloom;

		// Token: 0x0400169C RID: 5788
		internal static int __PropertyOffset_KuroCharacterBloomIntensity;

		// Token: 0x0400169D RID: 5789
		internal static int __PropertyOffset_KuroCharacterBloomThreshold;

		// Token: 0x0400169E RID: 5790
		internal static int __PropertyOffset_EnableExtraCharBloomOffset;

		// Token: 0x0400169F RID: 5791
		internal static byte __PropertyMask_EnableExtraCharBloomOffset;

		// Token: 0x040016A0 RID: 5792
		internal static int __PropertyOffset_KuroExtraCharacterBloomIntensityOffset;

		// Token: 0x040016A1 RID: 5793
		internal static int __PropertyOffset_KuroExtraCharacterBloomThresholdOffset;

		// Token: 0x040016A2 RID: 5794
		internal static int __PropertyOffset_SunDirBloomIntensity;

		// Token: 0x040016A3 RID: 5795
		internal static int __PropertyOffset_KuroBloomCombineParameter;

		// Token: 0x040016A4 RID: 5796
		internal static int __PropertyOffset_KuroBloomStreakIntensity;

		// Token: 0x040016A5 RID: 5797
		internal static int __PropertyOffset_KuroBloomStreakThreshold;

		// Token: 0x040016A6 RID: 5798
		internal static int __PropertyOffset_TranslucentBloomStreakIntensity;

		// Token: 0x040016A7 RID: 5799
		internal static int __PropertyOffset_TranslucentBloomStreakThreshold;

		// Token: 0x040016A8 RID: 5800
		internal static int __PropertyOffset_KuroBloomStreakLength;

		// Token: 0x040016A9 RID: 5801
		internal static int __PropertyOffset_KuroBloomStreakMipLevel;

		// Token: 0x040016AA RID: 5802
		internal static int __PropertyOffset_KuroBloomStreakRatio;

		// Token: 0x040016AB RID: 5803
		internal static int __PropertyOffset_KuroBloomStreakOrientation;

		// Token: 0x040016AC RID: 5804
		internal static int __PropertyOffset_BlackWhiteFlashIntensity;

		// Token: 0x040016AD RID: 5805
		internal static int __PropertyOffset_BlackWhiteFlashFactor;

		// Token: 0x040016AE RID: 5806
		internal static int __PropertyOffset_BlackWhiteFlashThreshold;

		// Token: 0x040016AF RID: 5807
		internal static int __PropertyOffset_BlackWhiteFlashBlackAreaColor;

		// Token: 0x040016B0 RID: 5808
		internal static int __PropertyOffset_BlackWhiteFlashWhiteAreaColor;

		// Token: 0x040016B1 RID: 5809
		internal static int __PropertyOffset_KuroRadialBlurIntensity;

		// Token: 0x040016B2 RID: 5810
		internal static int __PropertyOffset_KuroRadialBlurCenter;

		// Token: 0x040016B3 RID: 5811
		internal static int __PropertyOffset_UseClampRadialBlurCenter;

		// Token: 0x040016B4 RID: 5812
		internal static int __PropertyOffset_KuroRadialBlurRadius;

		// Token: 0x040016B5 RID: 5813
		internal static int __PropertyOffset_KuroRadialBlurHardness;

		// Token: 0x040016B6 RID: 5814
		internal static int __PropertyOffset_KuroRadialBlurPassNumber;

		// Token: 0x040016B7 RID: 5815
		internal static int __PropertyOffset_KuroRadialBlurSampleNumber;

		// Token: 0x040016B8 RID: 5816
		internal static int __PropertyOffset_KuroRadialBlurMask;

		// Token: 0x040016B9 RID: 5817
		internal static int __PropertyOffset_KuroRadialBlurMaskScale;

		// Token: 0x040016BA RID: 5818
		internal static int __PropertyOffset_KuroRadialBlurMaskOffset;

		// Token: 0x040016BB RID: 5819
		internal static int __PropertyOffset_ScreenSoftIntensity;

		// Token: 0x040016BC RID: 5820
		internal static int __PropertyOffset_ScreenSoftThreshold;

		// Token: 0x040016BD RID: 5821
		internal static int __PropertyOffset_ScreenSoftDistance;

		// Token: 0x040016BE RID: 5822
		internal static int __PropertyOffset_ScreenSoftSkyBloomCompensation;

		// Token: 0x040016BF RID: 5823
		internal static int __PropertyOffset_ScreenSoftRange;

		// Token: 0x040016C0 RID: 5824
		internal static int __PropertyOffset_ScreenSoftOverflowDistance;

		// Token: 0x040016C1 RID: 5825
		internal static int __PropertyOffset_ScreenSoftSunExposure;

		// Token: 0x040016C2 RID: 5826
		internal static int __PropertyOffset_ScreenSoftHighQuality;

		// Token: 0x040016C3 RID: 5827
		internal static int __PropertyOffset_MobileScreenSoftIntensity;

		// Token: 0x040016C4 RID: 5828
		internal static int __PropertyOffset_MobileScreenSoftThreshold;

		// Token: 0x040016C5 RID: 5829
		internal static int __PropertyOffset_MobileScreenSoftDistance;

		// Token: 0x040016C6 RID: 5830
		internal static int __PropertyOffset_ScreenLeakTexture;

		// Token: 0x040016C7 RID: 5831
		internal static int __PropertyOffset_ScreenLeakTextureIntensity;

		// Token: 0x040016C8 RID: 5832
		internal static int __PropertyOffset_FFTIntensity;

		// Token: 0x040016C9 RID: 5833
		internal static int __PropertyOffset_FFTThreshold;

		// Token: 0x040016CA RID: 5834
		internal static int __PropertyOffset_FFTTexture;

		// Token: 0x040016CB RID: 5835
		internal static int __PropertyOffset_FFTScatterDispersion;

		// Token: 0x040016CC RID: 5836
		internal static int __PropertyOffset_FFTSize;

		// Token: 0x040016CD RID: 5837
		internal static int __PropertyOffset_FFTPreFilterMin;

		// Token: 0x040016CE RID: 5838
		internal static int __PropertyOffset_FFTPreFilterMax;

		// Token: 0x040016CF RID: 5839
		internal static int __PropertyOffset_FFTPreFilterMult;

		// Token: 0x040016D0 RID: 5840
		internal static int __PropertyOffset_FFTBufferScale;

		// Token: 0x040016D1 RID: 5841
		internal static int __PropertyOffset_FFTDistance;

		// Token: 0x040016D2 RID: 5842
		internal static int __PropertyOffset_FFTHidenSky;

		// Token: 0x040016D3 RID: 5843
		internal static byte __PropertyMask_FFTHidenSky;

		// Token: 0x040016D4 RID: 5844
		internal static int __PropertyOffset_FFTHidenTranslucent;

		// Token: 0x040016D5 RID: 5845
		internal static byte __PropertyMask_FFTHidenTranslucent;

		// Token: 0x040016D6 RID: 5846
		internal static int __PropertyOffset_FFTBeforeTranslucency;

		// Token: 0x040016D7 RID: 5847
		internal static byte __PropertyMask_FFTBeforeTranslucency;

		// Token: 0x040016D8 RID: 5848
		internal static int __PropertyOffset_ToonFFTIntensity;

		// Token: 0x040016D9 RID: 5849
		internal static int __PropertyOffset_ToonFFTThreshold;

		// Token: 0x040016DA RID: 5850
		internal static int __PropertyOffset_ToonFFTTexture;

		// Token: 0x040016DB RID: 5851
		internal static int __PropertyOffset_ToonFFTScatterDispersion;

		// Token: 0x040016DC RID: 5852
		internal static int __PropertyOffset_ToonFFTSize;

		// Token: 0x040016DD RID: 5853
		internal static int __PropertyOffset_LightFadeScale;

		// Token: 0x040016DE RID: 5854
		internal static int __PropertyOffset_KuroDataDistortionNoiseIntensity;

		// Token: 0x040016DF RID: 5855
		internal static int __PropertyOffset_KuroDataDistortionNoiseTexture;

		// Token: 0x040016E0 RID: 5856
		internal static int __PropertyOffset_KuroDataDistortionNoiseTextureUVScaleBias;

		// Token: 0x040016E1 RID: 5857
		internal static int __PropertyOffset_KuroDataDistortionNoiseSize;

		// Token: 0x040016E2 RID: 5858
		internal static int __PropertyOffset_KuroDataDistortionNoiseBias;

		// Token: 0x040016E3 RID: 5859
		internal static int __PropertyOffset_KuroDataDistortionSignalIntensity;

		// Token: 0x040016E4 RID: 5860
		internal static int __PropertyOffset_KuroDataDistortionRandomColorSize;

		// Token: 0x040016E5 RID: 5861
		internal static int __PropertyOffset_KuroDataDistortionSinWaveParameters;

		// Token: 0x040016E6 RID: 5862
		internal static int __PropertyOffset_KuroDataDistortionColorTint;

		// Token: 0x040016E7 RID: 5863
		internal static int __PropertyOffset_BloomIntensity;

		// Token: 0x040016E8 RID: 5864
		internal static int __PropertyOffset_BloomThreshold;

		// Token: 0x040016E9 RID: 5865
		internal static int __PropertyOffset_BloomSizeScale;

		// Token: 0x040016EA RID: 5866
		internal static int __PropertyOffset_Bloom1Size;

		// Token: 0x040016EB RID: 5867
		internal static int __PropertyOffset_Bloom2Size;

		// Token: 0x040016EC RID: 5868
		internal static int __PropertyOffset_Bloom3Size;

		// Token: 0x040016ED RID: 5869
		internal static int __PropertyOffset_Bloom4Size;

		// Token: 0x040016EE RID: 5870
		internal static int __PropertyOffset_Bloom5Size;

		// Token: 0x040016EF RID: 5871
		internal static int __PropertyOffset_Bloom6Size;

		// Token: 0x040016F0 RID: 5872
		internal static int __PropertyOffset_Bloom1Tint;

		// Token: 0x040016F1 RID: 5873
		internal static int __PropertyOffset_Bloom2Tint;

		// Token: 0x040016F2 RID: 5874
		internal static int __PropertyOffset_Bloom3Tint;

		// Token: 0x040016F3 RID: 5875
		internal static int __PropertyOffset_Bloom4Tint;

		// Token: 0x040016F4 RID: 5876
		internal static int __PropertyOffset_Bloom5Tint;

		// Token: 0x040016F5 RID: 5877
		internal static int __PropertyOffset_Bloom6Tint;

		// Token: 0x040016F6 RID: 5878
		internal static int __PropertyOffset_BloomDirtMask;

		// Token: 0x040016F7 RID: 5879
		internal static int __PropertyOffset_BloomDirtMaskIntensity;

		// Token: 0x040016F8 RID: 5880
		internal static int __PropertyOffset_BloomDirtMaskTint;

		// Token: 0x040016F9 RID: 5881
		internal static int __PropertyOffset_bMegaLights;

		// Token: 0x040016FA RID: 5882
		internal static byte __PropertyMask_bMegaLights;

		// Token: 0x040016FB RID: 5883
		internal static int __PropertyOffset_AmbientCubemapTint;

		// Token: 0x040016FC RID: 5884
		internal static int __PropertyOffset_AmbientCubemapIntensity;

		// Token: 0x040016FD RID: 5885
		internal static int __PropertyOffset_AmbientCubemap;

		// Token: 0x040016FE RID: 5886
		internal static int __PropertyOffset_CameraShutterSpeed;

		// Token: 0x040016FF RID: 5887
		internal static int __PropertyOffset_CameraISO;

		// Token: 0x04001700 RID: 5888
		internal static int __PropertyOffset_DepthOfFieldFstop;

		// Token: 0x04001701 RID: 5889
		internal static int __PropertyOffset_DepthOfFieldMinFstop;

		// Token: 0x04001702 RID: 5890
		internal static int __PropertyOffset_DepthOfFieldBladeCount;

		// Token: 0x04001703 RID: 5891
		internal static int __PropertyOffset_bUseForegroundBlur;

		// Token: 0x04001704 RID: 5892
		internal static byte __PropertyMask_bUseForegroundBlur;

		// Token: 0x04001705 RID: 5893
		internal static int __PropertyOffset_AutoExposureBias;

		// Token: 0x04001706 RID: 5894
		internal static int __PropertyOffset_AutoExposureBiasBackup;

		// Token: 0x04001707 RID: 5895
		internal static int __PropertyOffset_bOverride_AutoExposureBiasBackup;

		// Token: 0x04001708 RID: 5896
		internal static byte __PropertyMask_bOverride_AutoExposureBiasBackup;

		// Token: 0x04001709 RID: 5897
		internal static int __PropertyOffset_AutoExposureApplyPhysicalCameraExposure;

		// Token: 0x0400170A RID: 5898
		internal static byte __PropertyMask_AutoExposureApplyPhysicalCameraExposure;

		// Token: 0x0400170B RID: 5899
		internal static int __PropertyOffset_AutoExposureBiasCurve;

		// Token: 0x0400170C RID: 5900
		internal static int __PropertyOffset_AutoExposureMeterMask;

		// Token: 0x0400170D RID: 5901
		internal static int __PropertyOffset_AutoExposureLowPercent;

		// Token: 0x0400170E RID: 5902
		internal static int __PropertyOffset_AutoExposureHighPercent;

		// Token: 0x0400170F RID: 5903
		internal static int __PropertyOffset_AutoExposureMinBrightness;

		// Token: 0x04001710 RID: 5904
		internal static int __PropertyOffset_AutoExposureMaxBrightness;

		// Token: 0x04001711 RID: 5905
		internal static int __PropertyOffset_AutoExposureSpeedUp;

		// Token: 0x04001712 RID: 5906
		internal static int __PropertyOffset_AutoExposureSpeedDown;

		// Token: 0x04001713 RID: 5907
		internal static int __PropertyOffset_HistogramLogMin;

		// Token: 0x04001714 RID: 5908
		internal static int __PropertyOffset_HistogramLogMax;

		// Token: 0x04001715 RID: 5909
		internal static int __PropertyOffset_LocalExposureContrastScale_DEPRECATED;

		// Token: 0x04001716 RID: 5910
		internal static int __PropertyOffset_LocalExposureHighlightContrastScale;

		// Token: 0x04001717 RID: 5911
		internal static int __PropertyOffset_LocalExposureShadowContrastScale;

		// Token: 0x04001718 RID: 5912
		internal static int __PropertyOffset_LocalExposureHighlightContrastCurve;

		// Token: 0x04001719 RID: 5913
		internal static int __PropertyOffset_LocalExposureShadowContrastCurve;

		// Token: 0x0400171A RID: 5914
		internal static int __PropertyOffset_LocalExposureHighlightThreshold;

		// Token: 0x0400171B RID: 5915
		internal static int __PropertyOffset_LocalExposureShadowThreshold;

		// Token: 0x0400171C RID: 5916
		internal static int __PropertyOffset_LocalExposureDetailStrength;

		// Token: 0x0400171D RID: 5917
		internal static int __PropertyOffset_LocalExposureBlurredLuminanceBlend;

		// Token: 0x0400171E RID: 5918
		internal static int __PropertyOffset_LocalExposureBlurredLuminanceKernelSizePercent;

		// Token: 0x0400171F RID: 5919
		internal static int __PropertyOffset_LocalExposureMiddleGreyBias;

		// Token: 0x04001720 RID: 5920
		internal static int __PropertyOffset_AutoExposureCalibrationConstant_DEPRECATED;

		// Token: 0x04001721 RID: 5921
		internal static int __PropertyOffset_LensFlareIntensity;

		// Token: 0x04001722 RID: 5922
		internal static int __PropertyOffset_LensFlareTint;

		// Token: 0x04001723 RID: 5923
		internal static int __PropertyOffset_LensFlareBokehSize;

		// Token: 0x04001724 RID: 5924
		internal static int __PropertyOffset_LensFlareThreshold;

		// Token: 0x04001725 RID: 5925
		internal static int __PropertyOffset_LensFlareBokehShape;

		// Token: 0x04001726 RID: 5926
		internal static int __PropertyOffset_LensFlareTints;

		// Token: 0x04001727 RID: 5927
		private TArray<FLinearColor> _LensFlareTints;

		// Token: 0x04001728 RID: 5928
		internal static int __PropertyOffset_LensFlareOnlySun;

		// Token: 0x04001729 RID: 5929
		internal static byte __PropertyMask_LensFlareOnlySun;

		// Token: 0x0400172A RID: 5930
		internal static int __PropertyOffset_LensFlareSunRange;

		// Token: 0x0400172B RID: 5931
		internal static int __PropertyOffset_LensFlareSunPosition;

		// Token: 0x0400172C RID: 5932
		internal static int __PropertyOffset_VignetteIntensity;

		// Token: 0x0400172D RID: 5933
		internal static int __PropertyOffset_VignetteHardness;

		// Token: 0x0400172E RID: 5934
		internal static int __PropertyOffset_VignetteXScale;

		// Token: 0x0400172F RID: 5935
		internal static int __PropertyOffset_VignetteYScale;

		// Token: 0x04001730 RID: 5936
		internal static int __PropertyOffset_VignetteXPos;

		// Token: 0x04001731 RID: 5937
		internal static int __PropertyOffset_VignetteYPos;

		// Token: 0x04001732 RID: 5938
		internal static int __PropertyOffset_VignetteColor;

		// Token: 0x04001733 RID: 5939
		internal static int __PropertyOffset_VignetteGain;

		// Token: 0x04001734 RID: 5940
		internal static int __PropertyOffset_EffectVignetteIntensity;

		// Token: 0x04001735 RID: 5941
		internal static int __PropertyOffset_EffectVignetteHardness;

		// Token: 0x04001736 RID: 5942
		internal static int __PropertyOffset_EffectVignetteXScale;

		// Token: 0x04001737 RID: 5943
		internal static int __PropertyOffset_EffectVignetteYScale;

		// Token: 0x04001738 RID: 5944
		internal static int __PropertyOffset_EffectVignetteXPos;

		// Token: 0x04001739 RID: 5945
		internal static int __PropertyOffset_EffectVignetteYPos;

		// Token: 0x0400173A RID: 5946
		internal static int __PropertyOffset_EffectVignetteColor;

		// Token: 0x0400173B RID: 5947
		internal static int __PropertyOffset_EffectVignetteGain;

		// Token: 0x0400173C RID: 5948
		internal static int __PropertyOffset_GrainJitter;

		// Token: 0x0400173D RID: 5949
		internal static int __PropertyOffset_GrainIntensity;

		// Token: 0x0400173E RID: 5950
		internal static int __PropertyOffset_GrainColorful;

		// Token: 0x0400173F RID: 5951
		internal static int __PropertyOffset_MainCenterMask;

		// Token: 0x04001740 RID: 5952
		internal static int __PropertyOffset_MainCenterMaskRadius;

		// Token: 0x04001741 RID: 5953
		internal static int __PropertyOffset_MainCenterMaskHardness;

		// Token: 0x04001742 RID: 5954
		internal static int __PropertyOffset_MainStartDistance;

		// Token: 0x04001743 RID: 5955
		internal static int __PropertyOffset_MainCharacterIntensity;

		// Token: 0x04001744 RID: 5956
		internal static int __PropertyOffset_VintageColorIntensity;

		// Token: 0x04001745 RID: 5957
		internal static int __PropertyOffset_VintageColorBlackPoint;

		// Token: 0x04001746 RID: 5958
		internal static int __PropertyOffset_VintageColorWhitePoint;

		// Token: 0x04001747 RID: 5959
		internal static int __PropertyOffset_VHSLinesColorIntensity;

		// Token: 0x04001748 RID: 5960
		internal static int __PropertyOffset_VHSLinesDistortIntensity;

		// Token: 0x04001749 RID: 5961
		internal static int __PropertyOffset_VHSEffectIntensity;

		// Token: 0x0400174A RID: 5962
		internal static int __PropertyOffset_VHSSpecklesIntensity;

		// Token: 0x0400174B RID: 5963
		internal static int __PropertyOffset_VHSSpecklesAmount;

		// Token: 0x0400174C RID: 5964
		internal static int __PropertyOffset_VHSSpecklesSize;

		// Token: 0x0400174D RID: 5965
		internal static int __PropertyOffset_CRTDistortion;

		// Token: 0x0400174E RID: 5966
		internal static int __PropertyOffset_VintageColorCenterMask;

		// Token: 0x0400174F RID: 5967
		internal static int __PropertyOffset_VintageColorStartDistance;

		// Token: 0x04001750 RID: 5968
		internal static int __PropertyOffset_VintageColorCharacterIntensity;

		// Token: 0x04001751 RID: 5969
		internal static int __PropertyOffset_VHSLinesCenterMask;

		// Token: 0x04001752 RID: 5970
		internal static int __PropertyOffset_VHSLinesStartDistance;

		// Token: 0x04001753 RID: 5971
		internal static int __PropertyOffset_VHSLinesCharacterIntensity;

		// Token: 0x04001754 RID: 5972
		internal static int __PropertyOffset_VHSEffectCenterMask;

		// Token: 0x04001755 RID: 5973
		internal static int __PropertyOffset_VHSEffectStartDistance;

		// Token: 0x04001756 RID: 5974
		internal static int __PropertyOffset_VHSEffectCharacterIntensity;

		// Token: 0x04001757 RID: 5975
		internal static int __PropertyOffset_VHSSpecklesCenterMask;

		// Token: 0x04001758 RID: 5976
		internal static int __PropertyOffset_VHSSpecklesStartDistance;

		// Token: 0x04001759 RID: 5977
		internal static int __PropertyOffset_VHSSpecklesCharacterIntensity;

		// Token: 0x0400175A RID: 5978
		internal static int __PropertyOffset_AmbientOcclusionIntensity;

		// Token: 0x0400175B RID: 5979
		internal static int __PropertyOffset_ToonAmbientOcclusionEnabled;

		// Token: 0x0400175C RID: 5980
		internal static byte __PropertyMask_ToonAmbientOcclusionEnabled;

		// Token: 0x0400175D RID: 5981
		internal static int __PropertyOffset_ToonAmbientOcclusionRadius;

		// Token: 0x0400175E RID: 5982
		internal static int __PropertyOffset_ToonAmbientOcclusionIntensity;

		// Token: 0x0400175F RID: 5983
		internal static int __PropertyOffset_ToonAmbientOcclusionPower;

		// Token: 0x04001760 RID: 5984
		internal static int __PropertyOffset_ToonAmbientOcclusionColor;

		// Token: 0x04001761 RID: 5985
		internal static int __PropertyOffset_AmbientOcclusionStaticFraction;

		// Token: 0x04001762 RID: 5986
		internal static int __PropertyOffset_AmbientOcclusionRadius;

		// Token: 0x04001763 RID: 5987
		internal static int __PropertyOffset_AmbientOcclusionRadiusInWS;

		// Token: 0x04001764 RID: 5988
		internal static byte __PropertyMask_AmbientOcclusionRadiusInWS;

		// Token: 0x04001765 RID: 5989
		internal static int __PropertyOffset_AmbientOcclusionFadeDistance;

		// Token: 0x04001766 RID: 5990
		internal static int __PropertyOffset_AmbientOcclusionFadeRadius;

		// Token: 0x04001767 RID: 5991
		internal static int __PropertyOffset_AmbientOcclusionDistance_DEPRECATED;

		// Token: 0x04001768 RID: 5992
		internal static int __PropertyOffset_AmbientOcclusionPower;

		// Token: 0x04001769 RID: 5993
		internal static int __PropertyOffset_AmbientOcclusionBias;

		// Token: 0x0400176A RID: 5994
		internal static int __PropertyOffset_AmbientOcclusionQuality;

		// Token: 0x0400176B RID: 5995
		internal static int __PropertyOffset_AmbientOcclusionMipBlend;

		// Token: 0x0400176C RID: 5996
		internal static int __PropertyOffset_AmbientOcclusionMipScale;

		// Token: 0x0400176D RID: 5997
		internal static int __PropertyOffset_AmbientOcclusionMipThreshold;

		// Token: 0x0400176E RID: 5998
		internal static int __PropertyOffset_AmbientOcclusionTemporalBlendWeight;

		// Token: 0x0400176F RID: 5999
		internal static int __PropertyOffset_RayTracingAO;

		// Token: 0x04001770 RID: 6000
		internal static byte __PropertyMask_RayTracingAO;

		// Token: 0x04001771 RID: 6001
		internal static int __PropertyOffset_RayTracingAOSamplesPerPixel;

		// Token: 0x04001772 RID: 6002
		internal static int __PropertyOffset_RayTracingAOIntensity;

		// Token: 0x04001773 RID: 6003
		internal static int __PropertyOffset_RayTracingAORadius;

		// Token: 0x04001774 RID: 6004
		internal static int __PropertyOffset_LumenSkylightLeaking;

		// Token: 0x04001775 RID: 6005
		internal static int __PropertyOffset_IndirectLightingColor;

		// Token: 0x04001776 RID: 6006
		internal static int __PropertyOffset_IndirectLightingIntensity;

		// Token: 0x04001777 RID: 6007
		internal static int __PropertyOffset_RayTracingGIMaxBounces;

		// Token: 0x04001778 RID: 6008
		internal static int __PropertyOffset_RayTracingGISamplesPerPixel;

		// Token: 0x04001779 RID: 6009
		internal static int __PropertyOffset_ColorGradingIntensity;

		// Token: 0x0400177A RID: 6010
		internal static int __PropertyOffset_ColorGradingLUT;

		// Token: 0x0400177B RID: 6011
		internal static int __PropertyOffset_DepthOfFieldSensorWidth;

		// Token: 0x0400177C RID: 6012
		internal static int __PropertyOffset_DepthOfFieldFocalDistance;

		// Token: 0x0400177D RID: 6013
		internal static int __PropertyOffset_DepthOfFieldDepthBlurAmount;

		// Token: 0x0400177E RID: 6014
		internal static int __PropertyOffset_DepthOfFieldDepthBlurRadius;

		// Token: 0x0400177F RID: 6015
		internal static int __PropertyOffset_DepthOfFieldFocalRegion;

		// Token: 0x04001780 RID: 6016
		internal static int __PropertyOffset_DepthOfFieldNearTransitionRegion;

		// Token: 0x04001781 RID: 6017
		internal static int __PropertyOffset_DepthOfFieldFarTransitionRegion;

		// Token: 0x04001782 RID: 6018
		internal static int __PropertyOffset_DepthOfFieldScale;

		// Token: 0x04001783 RID: 6019
		internal static int __PropertyOffset_DepthOfFieldNearBlurSize;

		// Token: 0x04001784 RID: 6020
		internal static int __PropertyOffset_DepthOfFieldFarBlurSize;

		// Token: 0x04001785 RID: 6021
		internal static int __PropertyOffset_DepthOfFieldOcclusion;

		// Token: 0x04001786 RID: 6022
		internal static int __PropertyOffset_DepthOfFieldSkyFocusDistance;

		// Token: 0x04001787 RID: 6023
		internal static int __PropertyOffset_DepthOfFieldVignetteSize;

		// Token: 0x04001788 RID: 6024
		internal static int __PropertyOffset_MotionBlurAmount;

		// Token: 0x04001789 RID: 6025
		internal static int __PropertyOffset_MotionBlurMax;

		// Token: 0x0400178A RID: 6026
		internal static int __PropertyOffset_MotionBlurTargetFPS;

		// Token: 0x0400178B RID: 6027
		internal static int __PropertyOffset_MotionBlurPerObjectSize;

		// Token: 0x0400178C RID: 6028
		internal static int __PropertyOffset_bMotionBlurCharacterMask;

		// Token: 0x0400178D RID: 6029
		internal static int __PropertyOffset_LPVIntensity;

		// Token: 0x0400178E RID: 6030
		internal static int __PropertyOffset_LPVVplInjectionBias;

		// Token: 0x0400178F RID: 6031
		internal static int __PropertyOffset_LPVSize;

		// Token: 0x04001790 RID: 6032
		internal static int __PropertyOffset_LPVSecondaryOcclusionIntensity;

		// Token: 0x04001791 RID: 6033
		internal static int __PropertyOffset_LPVSecondaryBounceIntensity;

		// Token: 0x04001792 RID: 6034
		internal static int __PropertyOffset_LPVGeometryVolumeBias;

		// Token: 0x04001793 RID: 6035
		internal static int __PropertyOffset_LPVEmissiveInjectionIntensity;

		// Token: 0x04001794 RID: 6036
		internal static int __PropertyOffset_LPVDirectionalOcclusionIntensity;

		// Token: 0x04001795 RID: 6037
		internal static int __PropertyOffset_LPVDirectionalOcclusionRadius;

		// Token: 0x04001796 RID: 6038
		internal static int __PropertyOffset_LPVDiffuseOcclusionExponent;

		// Token: 0x04001797 RID: 6039
		internal static int __PropertyOffset_LPVSpecularOcclusionExponent;

		// Token: 0x04001798 RID: 6040
		internal static int __PropertyOffset_LPVDiffuseOcclusionIntensity;

		// Token: 0x04001799 RID: 6041
		internal static int __PropertyOffset_LPVSpecularOcclusionIntensity;

		// Token: 0x0400179A RID: 6042
		internal static int __PropertyOffset_ScreenSpaceReflectionIntensity;

		// Token: 0x0400179B RID: 6043
		internal static int __PropertyOffset_ScreenSpaceReflectionQuality;

		// Token: 0x0400179C RID: 6044
		internal static int __PropertyOffset_ScreenSpaceReflectionMaxRoughness;

		// Token: 0x0400179D RID: 6045
		internal static int __PropertyOffset_RayTracingReflectionsMaxRoughness;

		// Token: 0x0400179E RID: 6046
		internal static int __PropertyOffset_RayTracingReflectionsMaxBounces;

		// Token: 0x0400179F RID: 6047
		internal static int __PropertyOffset_RayTracingReflectionsSamplesPerPixel;

		// Token: 0x040017A0 RID: 6048
		internal static int __PropertyOffset_RayTracingReflectionsTranslucency;

		// Token: 0x040017A1 RID: 6049
		internal static byte __PropertyMask_RayTracingReflectionsTranslucency;

		// Token: 0x040017A2 RID: 6050
		internal static int __PropertyOffset_RayTracingTranslucencyMaxRoughness;

		// Token: 0x040017A3 RID: 6051
		internal static int __PropertyOffset_RayTracingTranslucencyRefractionRays;

		// Token: 0x040017A4 RID: 6052
		internal static int __PropertyOffset_RayTracingTranslucencySamplesPerPixel;

		// Token: 0x040017A5 RID: 6053
		internal static int __PropertyOffset_RayTracingTranslucencyRefraction;

		// Token: 0x040017A6 RID: 6054
		internal static byte __PropertyMask_RayTracingTranslucencyRefraction;

		// Token: 0x040017A7 RID: 6055
		internal static int __PropertyOffset_PathTracingMaxBounces;

		// Token: 0x040017A8 RID: 6056
		internal static int __PropertyOffset_PathTracingSamplesPerPixel;

		// Token: 0x040017A9 RID: 6057
		internal static int __PropertyOffset_LPVFadeRange;

		// Token: 0x040017AA RID: 6058
		internal static int __PropertyOffset_LPVDirectionalOcclusionFadeRange;

		// Token: 0x040017AB RID: 6059
		internal static int __PropertyOffset_ScreenPercentage;

		// Token: 0x040017AC RID: 6060
		internal static int __PropertyOffset_WithOutTranslucent;

		// Token: 0x040017AD RID: 6061
		internal static int __PropertyOffset_StartPosSwitch;

		// Token: 0x040017AE RID: 6062
		internal static int __PropertyOffset_GrayGradationStartPos;

		// Token: 0x040017AF RID: 6063
		internal static int __PropertyOffset_GrayGradationDegree;

		// Token: 0x040017B0 RID: 6064
		internal static int __PropertyOffset_GrayLerpWidth;

		// Token: 0x040017B1 RID: 6065
		internal static int __PropertyOffset_GrayRampColor;

		// Token: 0x040017B2 RID: 6066
		internal static int __PropertyOffset_GrayRampTint;

		// Token: 0x040017B3 RID: 6067
		internal static int __PropertyOffset_GrayRampBlendWeight;

		// Token: 0x040017B4 RID: 6068
		internal static int __PropertyOffset_SNNIntensity;

		// Token: 0x040017B5 RID: 6069
		internal static int __PropertyOffset_SNNRoughnessContrast;

		// Token: 0x040017B6 RID: 6070
		internal static int __PropertyOffset_SNNMetallicThreshold;

		// Token: 0x040017B7 RID: 6071
		internal static int __PropertyOffset_SNNDepthFade;

		// Token: 0x040017B8 RID: 6072
		internal static int __PropertyOffset_SNNFoliageIntensity;

		// Token: 0x040017B9 RID: 6073
		internal static int __PropertyOffset_SNNStructureIntensity;

		// Token: 0x040017BA RID: 6074
		internal static int __PropertyOffset_SNNNoiseIntensity;

		// Token: 0x040017BB RID: 6075
		internal static int __PropertyOffset_SNNEnableSharpen;

		// Token: 0x040017BC RID: 6076
		internal static int __PropertyOffset_SNNSharpeness;

		// Token: 0x040017BD RID: 6077
		internal static int __PropertyOffset_SNNSharpenDepthFade;

		// Token: 0x040017BE RID: 6078
		internal static int __PropertyOffset_SSFSIntensity;

		// Token: 0x040017BF RID: 6079
		internal static int __PropertyOffset_SSFSRadius;

		// Token: 0x040017C0 RID: 6080
		internal static int __PropertyOffset_SSFSLuminanceWeighting;

		// Token: 0x040017C1 RID: 6081
		internal static int __PropertyOffset_SSFSSkyAtmosphereIntensity;

		// Token: 0x040017C2 RID: 6082
		internal static int __PropertyOffset_SSFSVolumetricFogILSIntensity;

		// Token: 0x040017C3 RID: 6083
		internal static int __PropertyOffset_SSFSKuroVolumetricLightILSIntensity;

		// Token: 0x040017C4 RID: 6084
		internal static int __PropertyOffset_SSFSStartDistance;

		// Token: 0x040017C5 RID: 6085
		internal static int __PropertyOffset_SSFSMaxDepth;

		// Token: 0x040017C6 RID: 6086
		internal static int __PropertyOffset_EnableMobileSSFS;

		// Token: 0x040017C7 RID: 6087
		internal static byte __PropertyMask_EnableMobileSSFS;

		// Token: 0x040017C8 RID: 6088
		internal static int __PropertyOffset_MobileSSFSFogDensity;

		// Token: 0x040017C9 RID: 6089
		internal static int __PropertyOffset_MobileSSFSIntensity;

		// Token: 0x040017CA RID: 6090
		internal static int __PropertyOffset_MobileSSFSRadius;

		// Token: 0x040017CB RID: 6091
		internal static int __PropertyOffset_MobileSSFSStartDistance;

		// Token: 0x040017CC RID: 6092
		internal static int __PropertyOffset_KuroSharpenRadius;

		// Token: 0x040017CD RID: 6093
		internal static int __PropertyOffset_KuroSharpenAmount;

		// Token: 0x040017CE RID: 6094
		internal static int __PropertyOffset_KuroLaplacianAmount;

		// Token: 0x040017CF RID: 6095
		internal static int __PropertyOffset_KuroSharpenIntensity;

		// Token: 0x040017D0 RID: 6096
		internal static int __PropertyOffset_KuroToonSharpenIntensity;

		// Token: 0x040017D1 RID: 6097
		internal static int __PropertyOffset_KuroSharpenDistance;

		// Token: 0x040017D2 RID: 6098
		internal static int __PropertyOffset_TyndallScaLightIntensity;

		// Token: 0x040017D3 RID: 6099
		internal static int __PropertyOffset_TyndallDarkIntensity;

		// Token: 0x040017D4 RID: 6100
		internal static int __PropertyOffset_TyndallScaLightLength;

		// Token: 0x040017D5 RID: 6101
		internal static int __PropertyOffset_TyndallScaLightColor;

		// Token: 0x040017D6 RID: 6102
		internal static int __PropertyOffset_TyndallScaLightFade;

		// Token: 0x040017D7 RID: 6103
		internal static int __PropertyOffset_TyndallScaLightMode;

		// Token: 0x040017D8 RID: 6104
		internal static int __PropertyOffset_TyndallScaNearFade;

		// Token: 0x040017D9 RID: 6105
		internal static int __PropertyOffset_TyndallScaDarkFadeDepth;

		// Token: 0x040017DA RID: 6106
		internal static int __PropertyOffset_TyndallScaMaxDepth;

		// Token: 0x040017DB RID: 6107
		internal static int __PropertyOffset_EnableCustomPosition;

		// Token: 0x040017DC RID: 6108
		internal static int __PropertyOffset_TyndallCustomPosition;

		// Token: 0x040017DD RID: 6109
		internal static int __PropertyOffset_KuroVolumetricLightEnable;

		// Token: 0x040017DE RID: 6110
		internal static int __PropertyOffset_KuroVolumetricLightIntensity;

		// Token: 0x040017DF RID: 6111
		internal static int __PropertyOffset_KuroVolumetricLightColor;

		// Token: 0x040017E0 RID: 6112
		internal static int __PropertyOffset_KuroVolumetricLightPhaseG;

		// Token: 0x040017E1 RID: 6113
		internal static int __PropertyOffset_KuroVolumetricLightMaxDistance;

		// Token: 0x040017E2 RID: 6114
		internal static int __PropertyOffset_KuroVolumetricLightBlurRadius;

		// Token: 0x040017E3 RID: 6115
		internal static int __PropertyOffset_KuroVolumetricLightUseColorMask;

		// Token: 0x040017E4 RID: 6116
		internal static int __PropertyOffset_KuroVolumetricLightColorMaskIntensity;

		// Token: 0x040017E5 RID: 6117
		internal static int __PropertyOffset_KuroCharacterLUTSplitEnable;

		// Token: 0x040017E6 RID: 6118
		internal static int __PropertyOffset_KuroCharacterColorGradingLUT;

		// Token: 0x040017E7 RID: 6119
		internal static int __PropertyOffset_KuroCharacterColorGradingLUTLerpIntensity;

		// Token: 0x040017E8 RID: 6120
		internal static int __PropertyOffset_KuroColorGradingTextureLUTInterpolationEnable;
	}
}
