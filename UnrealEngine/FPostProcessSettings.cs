using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001025 RID: 4133
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.PostProcessSettings")]
	[UnrealStructLayout(2592, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 2592)]
	public class FPostProcessSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600E224 RID: 57892 RVA: 0x0014C5AA File Offset: 0x0014A7AA
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FPostProcessSettings._ScriptStructPtr != 0) ? FPostProcessSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.PostProcessSettings", ref FPostProcessSettings._ScriptStructPtr);
		}

		// Token: 0x17003519 RID: 13593
		// (get) Token: 0x0600E225 RID: 57893 RVA: 0x0014C5CE File Offset: 0x0014A7CE
		// (set) Token: 0x0600E226 RID: 57894 RVA: 0x0014C5E7 File Offset: 0x0014A7E7
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

		// Token: 0x1700351A RID: 13594
		// (get) Token: 0x0600E227 RID: 57895 RVA: 0x0014C617 File Offset: 0x0014A817
		// (set) Token: 0x0600E228 RID: 57896 RVA: 0x0014C630 File Offset: 0x0014A830
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

		// Token: 0x1700351B RID: 13595
		// (get) Token: 0x0600E229 RID: 57897 RVA: 0x0014C660 File Offset: 0x0014A860
		// (set) Token: 0x0600E22A RID: 57898 RVA: 0x0014C679 File Offset: 0x0014A879
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

		// Token: 0x1700351C RID: 13596
		// (get) Token: 0x0600E22B RID: 57899 RVA: 0x0014C6A9 File Offset: 0x0014A8A9
		// (set) Token: 0x0600E22C RID: 57900 RVA: 0x0014C6C2 File Offset: 0x0014A8C2
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

		// Token: 0x1700351D RID: 13597
		// (get) Token: 0x0600E22D RID: 57901 RVA: 0x0014C6F2 File Offset: 0x0014A8F2
		// (set) Token: 0x0600E22E RID: 57902 RVA: 0x0014C70B File Offset: 0x0014A90B
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

		// Token: 0x1700351E RID: 13598
		// (get) Token: 0x0600E22F RID: 57903 RVA: 0x0014C73B File Offset: 0x0014A93B
		// (set) Token: 0x0600E230 RID: 57904 RVA: 0x0014C754 File Offset: 0x0014A954
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

		// Token: 0x1700351F RID: 13599
		// (get) Token: 0x0600E231 RID: 57905 RVA: 0x0014C784 File Offset: 0x0014A984
		// (set) Token: 0x0600E232 RID: 57906 RVA: 0x0014C79D File Offset: 0x0014A99D
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

		// Token: 0x17003520 RID: 13600
		// (get) Token: 0x0600E233 RID: 57907 RVA: 0x0014C7CD File Offset: 0x0014A9CD
		// (set) Token: 0x0600E234 RID: 57908 RVA: 0x0014C7E6 File Offset: 0x0014A9E6
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

		// Token: 0x17003521 RID: 13601
		// (get) Token: 0x0600E235 RID: 57909 RVA: 0x0014C816 File Offset: 0x0014AA16
		// (set) Token: 0x0600E236 RID: 57910 RVA: 0x0014C82F File Offset: 0x0014AA2F
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

		// Token: 0x17003522 RID: 13602
		// (get) Token: 0x0600E237 RID: 57911 RVA: 0x0014C85F File Offset: 0x0014AA5F
		// (set) Token: 0x0600E238 RID: 57912 RVA: 0x0014C878 File Offset: 0x0014AA78
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

		// Token: 0x17003523 RID: 13603
		// (get) Token: 0x0600E239 RID: 57913 RVA: 0x0014C8A8 File Offset: 0x0014AAA8
		// (set) Token: 0x0600E23A RID: 57914 RVA: 0x0014C8C1 File Offset: 0x0014AAC1
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

		// Token: 0x17003524 RID: 13604
		// (get) Token: 0x0600E23B RID: 57915 RVA: 0x0014C8F1 File Offset: 0x0014AAF1
		// (set) Token: 0x0600E23C RID: 57916 RVA: 0x0014C90A File Offset: 0x0014AB0A
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

		// Token: 0x17003525 RID: 13605
		// (get) Token: 0x0600E23D RID: 57917 RVA: 0x0014C93A File Offset: 0x0014AB3A
		// (set) Token: 0x0600E23E RID: 57918 RVA: 0x0014C953 File Offset: 0x0014AB53
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

		// Token: 0x17003526 RID: 13606
		// (get) Token: 0x0600E23F RID: 57919 RVA: 0x0014C983 File Offset: 0x0014AB83
		// (set) Token: 0x0600E240 RID: 57920 RVA: 0x0014C99C File Offset: 0x0014AB9C
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

		// Token: 0x17003527 RID: 13607
		// (get) Token: 0x0600E241 RID: 57921 RVA: 0x0014C9CC File Offset: 0x0014ABCC
		// (set) Token: 0x0600E242 RID: 57922 RVA: 0x0014C9E5 File Offset: 0x0014ABE5
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

		// Token: 0x17003528 RID: 13608
		// (get) Token: 0x0600E243 RID: 57923 RVA: 0x0014CA15 File Offset: 0x0014AC15
		// (set) Token: 0x0600E244 RID: 57924 RVA: 0x0014CA2E File Offset: 0x0014AC2E
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

		// Token: 0x17003529 RID: 13609
		// (get) Token: 0x0600E245 RID: 57925 RVA: 0x0014CA5E File Offset: 0x0014AC5E
		// (set) Token: 0x0600E246 RID: 57926 RVA: 0x0014CA77 File Offset: 0x0014AC77
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

		// Token: 0x1700352A RID: 13610
		// (get) Token: 0x0600E247 RID: 57927 RVA: 0x0014CAA7 File Offset: 0x0014ACA7
		// (set) Token: 0x0600E248 RID: 57928 RVA: 0x0014CAC0 File Offset: 0x0014ACC0
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

		// Token: 0x1700352B RID: 13611
		// (get) Token: 0x0600E249 RID: 57929 RVA: 0x0014CAF0 File Offset: 0x0014ACF0
		// (set) Token: 0x0600E24A RID: 57930 RVA: 0x0014CB09 File Offset: 0x0014AD09
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

		// Token: 0x1700352C RID: 13612
		// (get) Token: 0x0600E24B RID: 57931 RVA: 0x0014CB39 File Offset: 0x0014AD39
		// (set) Token: 0x0600E24C RID: 57932 RVA: 0x0014CB52 File Offset: 0x0014AD52
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

		// Token: 0x1700352D RID: 13613
		// (get) Token: 0x0600E24D RID: 57933 RVA: 0x0014CB82 File Offset: 0x0014AD82
		// (set) Token: 0x0600E24E RID: 57934 RVA: 0x0014CB9B File Offset: 0x0014AD9B
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

		// Token: 0x1700352E RID: 13614
		// (get) Token: 0x0600E24F RID: 57935 RVA: 0x0014CBCB File Offset: 0x0014ADCB
		// (set) Token: 0x0600E250 RID: 57936 RVA: 0x0014CBE4 File Offset: 0x0014ADE4
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

		// Token: 0x1700352F RID: 13615
		// (get) Token: 0x0600E251 RID: 57937 RVA: 0x0014CC14 File Offset: 0x0014AE14
		// (set) Token: 0x0600E252 RID: 57938 RVA: 0x0014CC2D File Offset: 0x0014AE2D
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

		// Token: 0x17003530 RID: 13616
		// (get) Token: 0x0600E253 RID: 57939 RVA: 0x0014CC5D File Offset: 0x0014AE5D
		// (set) Token: 0x0600E254 RID: 57940 RVA: 0x0014CC76 File Offset: 0x0014AE76
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

		// Token: 0x17003531 RID: 13617
		// (get) Token: 0x0600E255 RID: 57941 RVA: 0x0014CCA6 File Offset: 0x0014AEA6
		// (set) Token: 0x0600E256 RID: 57942 RVA: 0x0014CCBF File Offset: 0x0014AEBF
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

		// Token: 0x17003532 RID: 13618
		// (get) Token: 0x0600E257 RID: 57943 RVA: 0x0014CCEF File Offset: 0x0014AEEF
		// (set) Token: 0x0600E258 RID: 57944 RVA: 0x0014CD08 File Offset: 0x0014AF08
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

		// Token: 0x17003533 RID: 13619
		// (get) Token: 0x0600E259 RID: 57945 RVA: 0x0014CD38 File Offset: 0x0014AF38
		// (set) Token: 0x0600E25A RID: 57946 RVA: 0x0014CD51 File Offset: 0x0014AF51
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

		// Token: 0x17003534 RID: 13620
		// (get) Token: 0x0600E25B RID: 57947 RVA: 0x0014CD81 File Offset: 0x0014AF81
		// (set) Token: 0x0600E25C RID: 57948 RVA: 0x0014CD9A File Offset: 0x0014AF9A
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

		// Token: 0x17003535 RID: 13621
		// (get) Token: 0x0600E25D RID: 57949 RVA: 0x0014CDCA File Offset: 0x0014AFCA
		// (set) Token: 0x0600E25E RID: 57950 RVA: 0x0014CDE3 File Offset: 0x0014AFE3
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

		// Token: 0x17003536 RID: 13622
		// (get) Token: 0x0600E25F RID: 57951 RVA: 0x0014CE13 File Offset: 0x0014B013
		// (set) Token: 0x0600E260 RID: 57952 RVA: 0x0014CE2C File Offset: 0x0014B02C
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

		// Token: 0x17003537 RID: 13623
		// (get) Token: 0x0600E261 RID: 57953 RVA: 0x0014CE5C File Offset: 0x0014B05C
		// (set) Token: 0x0600E262 RID: 57954 RVA: 0x0014CE75 File Offset: 0x0014B075
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

		// Token: 0x17003538 RID: 13624
		// (get) Token: 0x0600E263 RID: 57955 RVA: 0x0014CEA5 File Offset: 0x0014B0A5
		// (set) Token: 0x0600E264 RID: 57956 RVA: 0x0014CEBE File Offset: 0x0014B0BE
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

		// Token: 0x17003539 RID: 13625
		// (get) Token: 0x0600E265 RID: 57957 RVA: 0x0014CEEE File Offset: 0x0014B0EE
		// (set) Token: 0x0600E266 RID: 57958 RVA: 0x0014CF07 File Offset: 0x0014B107
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

		// Token: 0x1700353A RID: 13626
		// (get) Token: 0x0600E267 RID: 57959 RVA: 0x0014CF37 File Offset: 0x0014B137
		// (set) Token: 0x0600E268 RID: 57960 RVA: 0x0014CF50 File Offset: 0x0014B150
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

		// Token: 0x1700353B RID: 13627
		// (get) Token: 0x0600E269 RID: 57961 RVA: 0x0014CF80 File Offset: 0x0014B180
		// (set) Token: 0x0600E26A RID: 57962 RVA: 0x0014CF99 File Offset: 0x0014B199
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

		// Token: 0x1700353C RID: 13628
		// (get) Token: 0x0600E26B RID: 57963 RVA: 0x0014CFC9 File Offset: 0x0014B1C9
		// (set) Token: 0x0600E26C RID: 57964 RVA: 0x0014CFE2 File Offset: 0x0014B1E2
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

		// Token: 0x1700353D RID: 13629
		// (get) Token: 0x0600E26D RID: 57965 RVA: 0x0014D012 File Offset: 0x0014B212
		// (set) Token: 0x0600E26E RID: 57966 RVA: 0x0014D02B File Offset: 0x0014B22B
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

		// Token: 0x1700353E RID: 13630
		// (get) Token: 0x0600E26F RID: 57967 RVA: 0x0014D05B File Offset: 0x0014B25B
		// (set) Token: 0x0600E270 RID: 57968 RVA: 0x0014D074 File Offset: 0x0014B274
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

		// Token: 0x1700353F RID: 13631
		// (get) Token: 0x0600E271 RID: 57969 RVA: 0x0014D0A4 File Offset: 0x0014B2A4
		// (set) Token: 0x0600E272 RID: 57970 RVA: 0x0014D0BD File Offset: 0x0014B2BD
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

		// Token: 0x17003540 RID: 13632
		// (get) Token: 0x0600E273 RID: 57971 RVA: 0x0014D0ED File Offset: 0x0014B2ED
		// (set) Token: 0x0600E274 RID: 57972 RVA: 0x0014D106 File Offset: 0x0014B306
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

		// Token: 0x17003541 RID: 13633
		// (get) Token: 0x0600E275 RID: 57973 RVA: 0x0014D136 File Offset: 0x0014B336
		// (set) Token: 0x0600E276 RID: 57974 RVA: 0x0014D14F File Offset: 0x0014B34F
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

		// Token: 0x17003542 RID: 13634
		// (get) Token: 0x0600E277 RID: 57975 RVA: 0x0014D17F File Offset: 0x0014B37F
		// (set) Token: 0x0600E278 RID: 57976 RVA: 0x0014D198 File Offset: 0x0014B398
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

		// Token: 0x17003543 RID: 13635
		// (get) Token: 0x0600E279 RID: 57977 RVA: 0x0014D1C8 File Offset: 0x0014B3C8
		// (set) Token: 0x0600E27A RID: 57978 RVA: 0x0014D1E1 File Offset: 0x0014B3E1
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

		// Token: 0x17003544 RID: 13636
		// (get) Token: 0x0600E27B RID: 57979 RVA: 0x0014D211 File Offset: 0x0014B411
		// (set) Token: 0x0600E27C RID: 57980 RVA: 0x0014D22A File Offset: 0x0014B42A
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

		// Token: 0x17003545 RID: 13637
		// (get) Token: 0x0600E27D RID: 57981 RVA: 0x0014D25A File Offset: 0x0014B45A
		// (set) Token: 0x0600E27E RID: 57982 RVA: 0x0014D273 File Offset: 0x0014B473
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

		// Token: 0x17003546 RID: 13638
		// (get) Token: 0x0600E27F RID: 57983 RVA: 0x0014D2A3 File Offset: 0x0014B4A3
		// (set) Token: 0x0600E280 RID: 57984 RVA: 0x0014D2BC File Offset: 0x0014B4BC
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

		// Token: 0x17003547 RID: 13639
		// (get) Token: 0x0600E281 RID: 57985 RVA: 0x0014D2EC File Offset: 0x0014B4EC
		// (set) Token: 0x0600E282 RID: 57986 RVA: 0x0014D305 File Offset: 0x0014B505
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

		// Token: 0x17003548 RID: 13640
		// (get) Token: 0x0600E283 RID: 57987 RVA: 0x0014D335 File Offset: 0x0014B535
		// (set) Token: 0x0600E284 RID: 57988 RVA: 0x0014D34E File Offset: 0x0014B54E
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

		// Token: 0x17003549 RID: 13641
		// (get) Token: 0x0600E285 RID: 57989 RVA: 0x0014D37E File Offset: 0x0014B57E
		// (set) Token: 0x0600E286 RID: 57990 RVA: 0x0014D397 File Offset: 0x0014B597
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

		// Token: 0x1700354A RID: 13642
		// (get) Token: 0x0600E287 RID: 57991 RVA: 0x0014D3C7 File Offset: 0x0014B5C7
		// (set) Token: 0x0600E288 RID: 57992 RVA: 0x0014D3E0 File Offset: 0x0014B5E0
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

		// Token: 0x1700354B RID: 13643
		// (get) Token: 0x0600E289 RID: 57993 RVA: 0x0014D410 File Offset: 0x0014B610
		// (set) Token: 0x0600E28A RID: 57994 RVA: 0x0014D429 File Offset: 0x0014B629
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

		// Token: 0x1700354C RID: 13644
		// (get) Token: 0x0600E28B RID: 57995 RVA: 0x0014D459 File Offset: 0x0014B659
		// (set) Token: 0x0600E28C RID: 57996 RVA: 0x0014D472 File Offset: 0x0014B672
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

		// Token: 0x1700354D RID: 13645
		// (get) Token: 0x0600E28D RID: 57997 RVA: 0x0014D4A2 File Offset: 0x0014B6A2
		// (set) Token: 0x0600E28E RID: 57998 RVA: 0x0014D4BB File Offset: 0x0014B6BB
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

		// Token: 0x1700354E RID: 13646
		// (get) Token: 0x0600E28F RID: 57999 RVA: 0x0014D4EB File Offset: 0x0014B6EB
		// (set) Token: 0x0600E290 RID: 58000 RVA: 0x0014D504 File Offset: 0x0014B704
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

		// Token: 0x1700354F RID: 13647
		// (get) Token: 0x0600E291 RID: 58001 RVA: 0x0014D534 File Offset: 0x0014B734
		// (set) Token: 0x0600E292 RID: 58002 RVA: 0x0014D54D File Offset: 0x0014B74D
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

		// Token: 0x17003550 RID: 13648
		// (get) Token: 0x0600E293 RID: 58003 RVA: 0x0014D57D File Offset: 0x0014B77D
		// (set) Token: 0x0600E294 RID: 58004 RVA: 0x0014D596 File Offset: 0x0014B796
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

		// Token: 0x17003551 RID: 13649
		// (get) Token: 0x0600E295 RID: 58005 RVA: 0x0014D5C6 File Offset: 0x0014B7C6
		// (set) Token: 0x0600E296 RID: 58006 RVA: 0x0014D5DF File Offset: 0x0014B7DF
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

		// Token: 0x17003552 RID: 13650
		// (get) Token: 0x0600E297 RID: 58007 RVA: 0x0014D60F File Offset: 0x0014B80F
		// (set) Token: 0x0600E298 RID: 58008 RVA: 0x0014D628 File Offset: 0x0014B828
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

		// Token: 0x17003553 RID: 13651
		// (get) Token: 0x0600E299 RID: 58009 RVA: 0x0014D658 File Offset: 0x0014B858
		// (set) Token: 0x0600E29A RID: 58010 RVA: 0x0014D671 File Offset: 0x0014B871
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

		// Token: 0x17003554 RID: 13652
		// (get) Token: 0x0600E29B RID: 58011 RVA: 0x0014D6A1 File Offset: 0x0014B8A1
		// (set) Token: 0x0600E29C RID: 58012 RVA: 0x0014D6BA File Offset: 0x0014B8BA
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

		// Token: 0x17003555 RID: 13653
		// (get) Token: 0x0600E29D RID: 58013 RVA: 0x0014D6EA File Offset: 0x0014B8EA
		// (set) Token: 0x0600E29E RID: 58014 RVA: 0x0014D703 File Offset: 0x0014B903
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

		// Token: 0x17003556 RID: 13654
		// (get) Token: 0x0600E29F RID: 58015 RVA: 0x0014D733 File Offset: 0x0014B933
		// (set) Token: 0x0600E2A0 RID: 58016 RVA: 0x0014D74C File Offset: 0x0014B94C
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

		// Token: 0x17003557 RID: 13655
		// (get) Token: 0x0600E2A1 RID: 58017 RVA: 0x0014D77C File Offset: 0x0014B97C
		// (set) Token: 0x0600E2A2 RID: 58018 RVA: 0x0014D795 File Offset: 0x0014B995
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

		// Token: 0x17003558 RID: 13656
		// (get) Token: 0x0600E2A3 RID: 58019 RVA: 0x0014D7C5 File Offset: 0x0014B9C5
		// (set) Token: 0x0600E2A4 RID: 58020 RVA: 0x0014D7DE File Offset: 0x0014B9DE
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

		// Token: 0x17003559 RID: 13657
		// (get) Token: 0x0600E2A5 RID: 58021 RVA: 0x0014D80E File Offset: 0x0014BA0E
		// (set) Token: 0x0600E2A6 RID: 58022 RVA: 0x0014D827 File Offset: 0x0014BA27
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

		// Token: 0x1700355A RID: 13658
		// (get) Token: 0x0600E2A7 RID: 58023 RVA: 0x0014D857 File Offset: 0x0014BA57
		// (set) Token: 0x0600E2A8 RID: 58024 RVA: 0x0014D870 File Offset: 0x0014BA70
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

		// Token: 0x1700355B RID: 13659
		// (get) Token: 0x0600E2A9 RID: 58025 RVA: 0x0014D8A0 File Offset: 0x0014BAA0
		// (set) Token: 0x0600E2AA RID: 58026 RVA: 0x0014D8B9 File Offset: 0x0014BAB9
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

		// Token: 0x1700355C RID: 13660
		// (get) Token: 0x0600E2AB RID: 58027 RVA: 0x0014D8E9 File Offset: 0x0014BAE9
		// (set) Token: 0x0600E2AC RID: 58028 RVA: 0x0014D902 File Offset: 0x0014BB02
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

		// Token: 0x1700355D RID: 13661
		// (get) Token: 0x0600E2AD RID: 58029 RVA: 0x0014D932 File Offset: 0x0014BB32
		// (set) Token: 0x0600E2AE RID: 58030 RVA: 0x0014D94B File Offset: 0x0014BB4B
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

		// Token: 0x1700355E RID: 13662
		// (get) Token: 0x0600E2AF RID: 58031 RVA: 0x0014D97B File Offset: 0x0014BB7B
		// (set) Token: 0x0600E2B0 RID: 58032 RVA: 0x0014D994 File Offset: 0x0014BB94
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

		// Token: 0x1700355F RID: 13663
		// (get) Token: 0x0600E2B1 RID: 58033 RVA: 0x0014D9C4 File Offset: 0x0014BBC4
		// (set) Token: 0x0600E2B2 RID: 58034 RVA: 0x0014D9DD File Offset: 0x0014BBDD
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

		// Token: 0x17003560 RID: 13664
		// (get) Token: 0x0600E2B3 RID: 58035 RVA: 0x0014DA0D File Offset: 0x0014BC0D
		// (set) Token: 0x0600E2B4 RID: 58036 RVA: 0x0014DA26 File Offset: 0x0014BC26
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

		// Token: 0x17003561 RID: 13665
		// (get) Token: 0x0600E2B5 RID: 58037 RVA: 0x0014DA56 File Offset: 0x0014BC56
		// (set) Token: 0x0600E2B6 RID: 58038 RVA: 0x0014DA6F File Offset: 0x0014BC6F
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

		// Token: 0x17003562 RID: 13666
		// (get) Token: 0x0600E2B7 RID: 58039 RVA: 0x0014DA9F File Offset: 0x0014BC9F
		// (set) Token: 0x0600E2B8 RID: 58040 RVA: 0x0014DAB8 File Offset: 0x0014BCB8
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

		// Token: 0x17003563 RID: 13667
		// (get) Token: 0x0600E2B9 RID: 58041 RVA: 0x0014DAE8 File Offset: 0x0014BCE8
		// (set) Token: 0x0600E2BA RID: 58042 RVA: 0x0014DB01 File Offset: 0x0014BD01
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

		// Token: 0x17003564 RID: 13668
		// (get) Token: 0x0600E2BB RID: 58043 RVA: 0x0014DB31 File Offset: 0x0014BD31
		// (set) Token: 0x0600E2BC RID: 58044 RVA: 0x0014DB4A File Offset: 0x0014BD4A
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

		// Token: 0x17003565 RID: 13669
		// (get) Token: 0x0600E2BD RID: 58045 RVA: 0x0014DB7A File Offset: 0x0014BD7A
		// (set) Token: 0x0600E2BE RID: 58046 RVA: 0x0014DB93 File Offset: 0x0014BD93
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

		// Token: 0x17003566 RID: 13670
		// (get) Token: 0x0600E2BF RID: 58047 RVA: 0x0014DBC3 File Offset: 0x0014BDC3
		// (set) Token: 0x0600E2C0 RID: 58048 RVA: 0x0014DBDC File Offset: 0x0014BDDC
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

		// Token: 0x17003567 RID: 13671
		// (get) Token: 0x0600E2C1 RID: 58049 RVA: 0x0014DC0C File Offset: 0x0014BE0C
		// (set) Token: 0x0600E2C2 RID: 58050 RVA: 0x0014DC25 File Offset: 0x0014BE25
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

		// Token: 0x17003568 RID: 13672
		// (get) Token: 0x0600E2C3 RID: 58051 RVA: 0x0014DC55 File Offset: 0x0014BE55
		// (set) Token: 0x0600E2C4 RID: 58052 RVA: 0x0014DC6E File Offset: 0x0014BE6E
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

		// Token: 0x17003569 RID: 13673
		// (get) Token: 0x0600E2C5 RID: 58053 RVA: 0x0014DC9E File Offset: 0x0014BE9E
		// (set) Token: 0x0600E2C6 RID: 58054 RVA: 0x0014DCB7 File Offset: 0x0014BEB7
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

		// Token: 0x1700356A RID: 13674
		// (get) Token: 0x0600E2C7 RID: 58055 RVA: 0x0014DCE7 File Offset: 0x0014BEE7
		// (set) Token: 0x0600E2C8 RID: 58056 RVA: 0x0014DD00 File Offset: 0x0014BF00
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

		// Token: 0x1700356B RID: 13675
		// (get) Token: 0x0600E2C9 RID: 58057 RVA: 0x0014DD30 File Offset: 0x0014BF30
		// (set) Token: 0x0600E2CA RID: 58058 RVA: 0x0014DD49 File Offset: 0x0014BF49
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

		// Token: 0x1700356C RID: 13676
		// (get) Token: 0x0600E2CB RID: 58059 RVA: 0x0014DD79 File Offset: 0x0014BF79
		// (set) Token: 0x0600E2CC RID: 58060 RVA: 0x0014DD92 File Offset: 0x0014BF92
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

		// Token: 0x1700356D RID: 13677
		// (get) Token: 0x0600E2CD RID: 58061 RVA: 0x0014DDC2 File Offset: 0x0014BFC2
		// (set) Token: 0x0600E2CE RID: 58062 RVA: 0x0014DDDB File Offset: 0x0014BFDB
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

		// Token: 0x1700356E RID: 13678
		// (get) Token: 0x0600E2CF RID: 58063 RVA: 0x0014DE0B File Offset: 0x0014C00B
		// (set) Token: 0x0600E2D0 RID: 58064 RVA: 0x0014DE24 File Offset: 0x0014C024
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

		// Token: 0x1700356F RID: 13679
		// (get) Token: 0x0600E2D1 RID: 58065 RVA: 0x0014DE54 File Offset: 0x0014C054
		// (set) Token: 0x0600E2D2 RID: 58066 RVA: 0x0014DE6D File Offset: 0x0014C06D
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

		// Token: 0x17003570 RID: 13680
		// (get) Token: 0x0600E2D3 RID: 58067 RVA: 0x0014DE9D File Offset: 0x0014C09D
		// (set) Token: 0x0600E2D4 RID: 58068 RVA: 0x0014DEB6 File Offset: 0x0014C0B6
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

		// Token: 0x17003571 RID: 13681
		// (get) Token: 0x0600E2D5 RID: 58069 RVA: 0x0014DEE6 File Offset: 0x0014C0E6
		// (set) Token: 0x0600E2D6 RID: 58070 RVA: 0x0014DEFF File Offset: 0x0014C0FF
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

		// Token: 0x17003572 RID: 13682
		// (get) Token: 0x0600E2D7 RID: 58071 RVA: 0x0014DF2F File Offset: 0x0014C12F
		// (set) Token: 0x0600E2D8 RID: 58072 RVA: 0x0014DF48 File Offset: 0x0014C148
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

		// Token: 0x17003573 RID: 13683
		// (get) Token: 0x0600E2D9 RID: 58073 RVA: 0x0014DF78 File Offset: 0x0014C178
		// (set) Token: 0x0600E2DA RID: 58074 RVA: 0x0014DF91 File Offset: 0x0014C191
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

		// Token: 0x17003574 RID: 13684
		// (get) Token: 0x0600E2DB RID: 58075 RVA: 0x0014DFC1 File Offset: 0x0014C1C1
		// (set) Token: 0x0600E2DC RID: 58076 RVA: 0x0014DFDA File Offset: 0x0014C1DA
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

		// Token: 0x17003575 RID: 13685
		// (get) Token: 0x0600E2DD RID: 58077 RVA: 0x0014E00A File Offset: 0x0014C20A
		// (set) Token: 0x0600E2DE RID: 58078 RVA: 0x0014E023 File Offset: 0x0014C223
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

		// Token: 0x17003576 RID: 13686
		// (get) Token: 0x0600E2DF RID: 58079 RVA: 0x0014E053 File Offset: 0x0014C253
		// (set) Token: 0x0600E2E0 RID: 58080 RVA: 0x0014E06C File Offset: 0x0014C26C
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

		// Token: 0x17003577 RID: 13687
		// (get) Token: 0x0600E2E1 RID: 58081 RVA: 0x0014E09C File Offset: 0x0014C29C
		// (set) Token: 0x0600E2E2 RID: 58082 RVA: 0x0014E0B5 File Offset: 0x0014C2B5
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

		// Token: 0x17003578 RID: 13688
		// (get) Token: 0x0600E2E3 RID: 58083 RVA: 0x0014E0E5 File Offset: 0x0014C2E5
		// (set) Token: 0x0600E2E4 RID: 58084 RVA: 0x0014E0FE File Offset: 0x0014C2FE
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

		// Token: 0x17003579 RID: 13689
		// (get) Token: 0x0600E2E5 RID: 58085 RVA: 0x0014E12E File Offset: 0x0014C32E
		// (set) Token: 0x0600E2E6 RID: 58086 RVA: 0x0014E147 File Offset: 0x0014C347
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

		// Token: 0x1700357A RID: 13690
		// (get) Token: 0x0600E2E7 RID: 58087 RVA: 0x0014E177 File Offset: 0x0014C377
		// (set) Token: 0x0600E2E8 RID: 58088 RVA: 0x0014E190 File Offset: 0x0014C390
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

		// Token: 0x1700357B RID: 13691
		// (get) Token: 0x0600E2E9 RID: 58089 RVA: 0x0014E1C0 File Offset: 0x0014C3C0
		// (set) Token: 0x0600E2EA RID: 58090 RVA: 0x0014E1D9 File Offset: 0x0014C3D9
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

		// Token: 0x1700357C RID: 13692
		// (get) Token: 0x0600E2EB RID: 58091 RVA: 0x0014E209 File Offset: 0x0014C409
		// (set) Token: 0x0600E2EC RID: 58092 RVA: 0x0014E222 File Offset: 0x0014C422
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

		// Token: 0x1700357D RID: 13693
		// (get) Token: 0x0600E2ED RID: 58093 RVA: 0x0014E252 File Offset: 0x0014C452
		// (set) Token: 0x0600E2EE RID: 58094 RVA: 0x0014E26B File Offset: 0x0014C46B
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

		// Token: 0x1700357E RID: 13694
		// (get) Token: 0x0600E2EF RID: 58095 RVA: 0x0014E29B File Offset: 0x0014C49B
		// (set) Token: 0x0600E2F0 RID: 58096 RVA: 0x0014E2B4 File Offset: 0x0014C4B4
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

		// Token: 0x1700357F RID: 13695
		// (get) Token: 0x0600E2F1 RID: 58097 RVA: 0x0014E2E4 File Offset: 0x0014C4E4
		// (set) Token: 0x0600E2F2 RID: 58098 RVA: 0x0014E2FD File Offset: 0x0014C4FD
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

		// Token: 0x17003580 RID: 13696
		// (get) Token: 0x0600E2F3 RID: 58099 RVA: 0x0014E32D File Offset: 0x0014C52D
		// (set) Token: 0x0600E2F4 RID: 58100 RVA: 0x0014E346 File Offset: 0x0014C546
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

		// Token: 0x17003581 RID: 13697
		// (get) Token: 0x0600E2F5 RID: 58101 RVA: 0x0014E376 File Offset: 0x0014C576
		// (set) Token: 0x0600E2F6 RID: 58102 RVA: 0x0014E38F File Offset: 0x0014C58F
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

		// Token: 0x17003582 RID: 13698
		// (get) Token: 0x0600E2F7 RID: 58103 RVA: 0x0014E3BF File Offset: 0x0014C5BF
		// (set) Token: 0x0600E2F8 RID: 58104 RVA: 0x0014E3D8 File Offset: 0x0014C5D8
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

		// Token: 0x17003583 RID: 13699
		// (get) Token: 0x0600E2F9 RID: 58105 RVA: 0x0014E408 File Offset: 0x0014C608
		// (set) Token: 0x0600E2FA RID: 58106 RVA: 0x0014E421 File Offset: 0x0014C621
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

		// Token: 0x17003584 RID: 13700
		// (get) Token: 0x0600E2FB RID: 58107 RVA: 0x0014E451 File Offset: 0x0014C651
		// (set) Token: 0x0600E2FC RID: 58108 RVA: 0x0014E46A File Offset: 0x0014C66A
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

		// Token: 0x17003585 RID: 13701
		// (get) Token: 0x0600E2FD RID: 58109 RVA: 0x0014E49A File Offset: 0x0014C69A
		// (set) Token: 0x0600E2FE RID: 58110 RVA: 0x0014E4B3 File Offset: 0x0014C6B3
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

		// Token: 0x17003586 RID: 13702
		// (get) Token: 0x0600E2FF RID: 58111 RVA: 0x0014E4E3 File Offset: 0x0014C6E3
		// (set) Token: 0x0600E300 RID: 58112 RVA: 0x0014E4FC File Offset: 0x0014C6FC
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

		// Token: 0x17003587 RID: 13703
		// (get) Token: 0x0600E301 RID: 58113 RVA: 0x0014E52C File Offset: 0x0014C72C
		// (set) Token: 0x0600E302 RID: 58114 RVA: 0x0014E545 File Offset: 0x0014C745
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

		// Token: 0x17003588 RID: 13704
		// (get) Token: 0x0600E303 RID: 58115 RVA: 0x0014E575 File Offset: 0x0014C775
		// (set) Token: 0x0600E304 RID: 58116 RVA: 0x0014E58E File Offset: 0x0014C78E
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

		// Token: 0x17003589 RID: 13705
		// (get) Token: 0x0600E305 RID: 58117 RVA: 0x0014E5BE File Offset: 0x0014C7BE
		// (set) Token: 0x0600E306 RID: 58118 RVA: 0x0014E5D7 File Offset: 0x0014C7D7
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

		// Token: 0x1700358A RID: 13706
		// (get) Token: 0x0600E307 RID: 58119 RVA: 0x0014E607 File Offset: 0x0014C807
		// (set) Token: 0x0600E308 RID: 58120 RVA: 0x0014E620 File Offset: 0x0014C820
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

		// Token: 0x1700358B RID: 13707
		// (get) Token: 0x0600E309 RID: 58121 RVA: 0x0014E650 File Offset: 0x0014C850
		// (set) Token: 0x0600E30A RID: 58122 RVA: 0x0014E669 File Offset: 0x0014C869
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

		// Token: 0x1700358C RID: 13708
		// (get) Token: 0x0600E30B RID: 58123 RVA: 0x0014E699 File Offset: 0x0014C899
		// (set) Token: 0x0600E30C RID: 58124 RVA: 0x0014E6B2 File Offset: 0x0014C8B2
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

		// Token: 0x1700358D RID: 13709
		// (get) Token: 0x0600E30D RID: 58125 RVA: 0x0014E6E2 File Offset: 0x0014C8E2
		// (set) Token: 0x0600E30E RID: 58126 RVA: 0x0014E6FB File Offset: 0x0014C8FB
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

		// Token: 0x1700358E RID: 13710
		// (get) Token: 0x0600E30F RID: 58127 RVA: 0x0014E72B File Offset: 0x0014C92B
		// (set) Token: 0x0600E310 RID: 58128 RVA: 0x0014E744 File Offset: 0x0014C944
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

		// Token: 0x1700358F RID: 13711
		// (get) Token: 0x0600E311 RID: 58129 RVA: 0x0014E774 File Offset: 0x0014C974
		// (set) Token: 0x0600E312 RID: 58130 RVA: 0x0014E78D File Offset: 0x0014C98D
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

		// Token: 0x17003590 RID: 13712
		// (get) Token: 0x0600E313 RID: 58131 RVA: 0x0014E7BD File Offset: 0x0014C9BD
		// (set) Token: 0x0600E314 RID: 58132 RVA: 0x0014E7D6 File Offset: 0x0014C9D6
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

		// Token: 0x17003591 RID: 13713
		// (get) Token: 0x0600E315 RID: 58133 RVA: 0x0014E806 File Offset: 0x0014CA06
		// (set) Token: 0x0600E316 RID: 58134 RVA: 0x0014E81F File Offset: 0x0014CA1F
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

		// Token: 0x17003592 RID: 13714
		// (get) Token: 0x0600E317 RID: 58135 RVA: 0x0014E84F File Offset: 0x0014CA4F
		// (set) Token: 0x0600E318 RID: 58136 RVA: 0x0014E868 File Offset: 0x0014CA68
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

		// Token: 0x17003593 RID: 13715
		// (get) Token: 0x0600E319 RID: 58137 RVA: 0x0014E898 File Offset: 0x0014CA98
		// (set) Token: 0x0600E31A RID: 58138 RVA: 0x0014E8B1 File Offset: 0x0014CAB1
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

		// Token: 0x17003594 RID: 13716
		// (get) Token: 0x0600E31B RID: 58139 RVA: 0x0014E8E1 File Offset: 0x0014CAE1
		// (set) Token: 0x0600E31C RID: 58140 RVA: 0x0014E8FA File Offset: 0x0014CAFA
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

		// Token: 0x17003595 RID: 13717
		// (get) Token: 0x0600E31D RID: 58141 RVA: 0x0014E92A File Offset: 0x0014CB2A
		// (set) Token: 0x0600E31E RID: 58142 RVA: 0x0014E943 File Offset: 0x0014CB43
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

		// Token: 0x17003596 RID: 13718
		// (get) Token: 0x0600E31F RID: 58143 RVA: 0x0014E973 File Offset: 0x0014CB73
		// (set) Token: 0x0600E320 RID: 58144 RVA: 0x0014E98C File Offset: 0x0014CB8C
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

		// Token: 0x17003597 RID: 13719
		// (get) Token: 0x0600E321 RID: 58145 RVA: 0x0014E9BC File Offset: 0x0014CBBC
		// (set) Token: 0x0600E322 RID: 58146 RVA: 0x0014E9D5 File Offset: 0x0014CBD5
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

		// Token: 0x17003598 RID: 13720
		// (get) Token: 0x0600E323 RID: 58147 RVA: 0x0014EA05 File Offset: 0x0014CC05
		// (set) Token: 0x0600E324 RID: 58148 RVA: 0x0014EA1E File Offset: 0x0014CC1E
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

		// Token: 0x17003599 RID: 13721
		// (get) Token: 0x0600E325 RID: 58149 RVA: 0x0014EA4E File Offset: 0x0014CC4E
		// (set) Token: 0x0600E326 RID: 58150 RVA: 0x0014EA67 File Offset: 0x0014CC67
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

		// Token: 0x1700359A RID: 13722
		// (get) Token: 0x0600E327 RID: 58151 RVA: 0x0014EA97 File Offset: 0x0014CC97
		// (set) Token: 0x0600E328 RID: 58152 RVA: 0x0014EAB0 File Offset: 0x0014CCB0
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

		// Token: 0x1700359B RID: 13723
		// (get) Token: 0x0600E329 RID: 58153 RVA: 0x0014EAE0 File Offset: 0x0014CCE0
		// (set) Token: 0x0600E32A RID: 58154 RVA: 0x0014EAF9 File Offset: 0x0014CCF9
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

		// Token: 0x1700359C RID: 13724
		// (get) Token: 0x0600E32B RID: 58155 RVA: 0x0014EB29 File Offset: 0x0014CD29
		// (set) Token: 0x0600E32C RID: 58156 RVA: 0x0014EB42 File Offset: 0x0014CD42
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

		// Token: 0x1700359D RID: 13725
		// (get) Token: 0x0600E32D RID: 58157 RVA: 0x0014EB72 File Offset: 0x0014CD72
		// (set) Token: 0x0600E32E RID: 58158 RVA: 0x0014EB8B File Offset: 0x0014CD8B
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

		// Token: 0x1700359E RID: 13726
		// (get) Token: 0x0600E32F RID: 58159 RVA: 0x0014EBBB File Offset: 0x0014CDBB
		// (set) Token: 0x0600E330 RID: 58160 RVA: 0x0014EBD4 File Offset: 0x0014CDD4
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

		// Token: 0x1700359F RID: 13727
		// (get) Token: 0x0600E331 RID: 58161 RVA: 0x0014EC04 File Offset: 0x0014CE04
		// (set) Token: 0x0600E332 RID: 58162 RVA: 0x0014EC1D File Offset: 0x0014CE1D
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

		// Token: 0x170035A0 RID: 13728
		// (get) Token: 0x0600E333 RID: 58163 RVA: 0x0014EC4D File Offset: 0x0014CE4D
		// (set) Token: 0x0600E334 RID: 58164 RVA: 0x0014EC66 File Offset: 0x0014CE66
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

		// Token: 0x170035A1 RID: 13729
		// (get) Token: 0x0600E335 RID: 58165 RVA: 0x0014EC96 File Offset: 0x0014CE96
		// (set) Token: 0x0600E336 RID: 58166 RVA: 0x0014ECAF File Offset: 0x0014CEAF
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

		// Token: 0x170035A2 RID: 13730
		// (get) Token: 0x0600E337 RID: 58167 RVA: 0x0014ECDF File Offset: 0x0014CEDF
		// (set) Token: 0x0600E338 RID: 58168 RVA: 0x0014ECF8 File Offset: 0x0014CEF8
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

		// Token: 0x170035A3 RID: 13731
		// (get) Token: 0x0600E339 RID: 58169 RVA: 0x0014ED28 File Offset: 0x0014CF28
		// (set) Token: 0x0600E33A RID: 58170 RVA: 0x0014ED41 File Offset: 0x0014CF41
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

		// Token: 0x170035A4 RID: 13732
		// (get) Token: 0x0600E33B RID: 58171 RVA: 0x0014ED71 File Offset: 0x0014CF71
		// (set) Token: 0x0600E33C RID: 58172 RVA: 0x0014ED8A File Offset: 0x0014CF8A
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

		// Token: 0x170035A5 RID: 13733
		// (get) Token: 0x0600E33D RID: 58173 RVA: 0x0014EDBA File Offset: 0x0014CFBA
		// (set) Token: 0x0600E33E RID: 58174 RVA: 0x0014EDD3 File Offset: 0x0014CFD3
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

		// Token: 0x170035A6 RID: 13734
		// (get) Token: 0x0600E33F RID: 58175 RVA: 0x0014EE03 File Offset: 0x0014D003
		// (set) Token: 0x0600E340 RID: 58176 RVA: 0x0014EE1C File Offset: 0x0014D01C
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

		// Token: 0x170035A7 RID: 13735
		// (get) Token: 0x0600E341 RID: 58177 RVA: 0x0014EE4C File Offset: 0x0014D04C
		// (set) Token: 0x0600E342 RID: 58178 RVA: 0x0014EE65 File Offset: 0x0014D065
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

		// Token: 0x170035A8 RID: 13736
		// (get) Token: 0x0600E343 RID: 58179 RVA: 0x0014EE95 File Offset: 0x0014D095
		// (set) Token: 0x0600E344 RID: 58180 RVA: 0x0014EEAE File Offset: 0x0014D0AE
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

		// Token: 0x170035A9 RID: 13737
		// (get) Token: 0x0600E345 RID: 58181 RVA: 0x0014EEDE File Offset: 0x0014D0DE
		// (set) Token: 0x0600E346 RID: 58182 RVA: 0x0014EEF7 File Offset: 0x0014D0F7
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

		// Token: 0x170035AA RID: 13738
		// (get) Token: 0x0600E347 RID: 58183 RVA: 0x0014EF27 File Offset: 0x0014D127
		// (set) Token: 0x0600E348 RID: 58184 RVA: 0x0014EF40 File Offset: 0x0014D140
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

		// Token: 0x170035AB RID: 13739
		// (get) Token: 0x0600E349 RID: 58185 RVA: 0x0014EF70 File Offset: 0x0014D170
		// (set) Token: 0x0600E34A RID: 58186 RVA: 0x0014EF89 File Offset: 0x0014D189
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

		// Token: 0x170035AC RID: 13740
		// (get) Token: 0x0600E34B RID: 58187 RVA: 0x0014EFB9 File Offset: 0x0014D1B9
		// (set) Token: 0x0600E34C RID: 58188 RVA: 0x0014EFD2 File Offset: 0x0014D1D2
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

		// Token: 0x170035AD RID: 13741
		// (get) Token: 0x0600E34D RID: 58189 RVA: 0x0014F002 File Offset: 0x0014D202
		// (set) Token: 0x0600E34E RID: 58190 RVA: 0x0014F01B File Offset: 0x0014D21B
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

		// Token: 0x170035AE RID: 13742
		// (get) Token: 0x0600E34F RID: 58191 RVA: 0x0014F04B File Offset: 0x0014D24B
		// (set) Token: 0x0600E350 RID: 58192 RVA: 0x0014F064 File Offset: 0x0014D264
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

		// Token: 0x170035AF RID: 13743
		// (get) Token: 0x0600E351 RID: 58193 RVA: 0x0014F094 File Offset: 0x0014D294
		// (set) Token: 0x0600E352 RID: 58194 RVA: 0x0014F0AD File Offset: 0x0014D2AD
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

		// Token: 0x170035B0 RID: 13744
		// (get) Token: 0x0600E353 RID: 58195 RVA: 0x0014F0DD File Offset: 0x0014D2DD
		// (set) Token: 0x0600E354 RID: 58196 RVA: 0x0014F0F6 File Offset: 0x0014D2F6
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

		// Token: 0x170035B1 RID: 13745
		// (get) Token: 0x0600E355 RID: 58197 RVA: 0x0014F126 File Offset: 0x0014D326
		// (set) Token: 0x0600E356 RID: 58198 RVA: 0x0014F13F File Offset: 0x0014D33F
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

		// Token: 0x170035B2 RID: 13746
		// (get) Token: 0x0600E357 RID: 58199 RVA: 0x0014F16F File Offset: 0x0014D36F
		// (set) Token: 0x0600E358 RID: 58200 RVA: 0x0014F188 File Offset: 0x0014D388
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

		// Token: 0x170035B3 RID: 13747
		// (get) Token: 0x0600E359 RID: 58201 RVA: 0x0014F1B8 File Offset: 0x0014D3B8
		// (set) Token: 0x0600E35A RID: 58202 RVA: 0x0014F1D1 File Offset: 0x0014D3D1
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

		// Token: 0x170035B4 RID: 13748
		// (get) Token: 0x0600E35B RID: 58203 RVA: 0x0014F201 File Offset: 0x0014D401
		// (set) Token: 0x0600E35C RID: 58204 RVA: 0x0014F21A File Offset: 0x0014D41A
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

		// Token: 0x170035B5 RID: 13749
		// (get) Token: 0x0600E35D RID: 58205 RVA: 0x0014F24A File Offset: 0x0014D44A
		// (set) Token: 0x0600E35E RID: 58206 RVA: 0x0014F263 File Offset: 0x0014D463
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

		// Token: 0x170035B6 RID: 13750
		// (get) Token: 0x0600E35F RID: 58207 RVA: 0x0014F293 File Offset: 0x0014D493
		// (set) Token: 0x0600E360 RID: 58208 RVA: 0x0014F2AC File Offset: 0x0014D4AC
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

		// Token: 0x170035B7 RID: 13751
		// (get) Token: 0x0600E361 RID: 58209 RVA: 0x0014F2DC File Offset: 0x0014D4DC
		// (set) Token: 0x0600E362 RID: 58210 RVA: 0x0014F2F5 File Offset: 0x0014D4F5
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

		// Token: 0x170035B8 RID: 13752
		// (get) Token: 0x0600E363 RID: 58211 RVA: 0x0014F325 File Offset: 0x0014D525
		// (set) Token: 0x0600E364 RID: 58212 RVA: 0x0014F33E File Offset: 0x0014D53E
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

		// Token: 0x170035B9 RID: 13753
		// (get) Token: 0x0600E365 RID: 58213 RVA: 0x0014F36E File Offset: 0x0014D56E
		// (set) Token: 0x0600E366 RID: 58214 RVA: 0x0014F387 File Offset: 0x0014D587
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

		// Token: 0x170035BA RID: 13754
		// (get) Token: 0x0600E367 RID: 58215 RVA: 0x0014F3B7 File Offset: 0x0014D5B7
		// (set) Token: 0x0600E368 RID: 58216 RVA: 0x0014F3D0 File Offset: 0x0014D5D0
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

		// Token: 0x170035BB RID: 13755
		// (get) Token: 0x0600E369 RID: 58217 RVA: 0x0014F400 File Offset: 0x0014D600
		// (set) Token: 0x0600E36A RID: 58218 RVA: 0x0014F419 File Offset: 0x0014D619
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

		// Token: 0x170035BC RID: 13756
		// (get) Token: 0x0600E36B RID: 58219 RVA: 0x0014F449 File Offset: 0x0014D649
		// (set) Token: 0x0600E36C RID: 58220 RVA: 0x0014F462 File Offset: 0x0014D662
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

		// Token: 0x170035BD RID: 13757
		// (get) Token: 0x0600E36D RID: 58221 RVA: 0x0014F492 File Offset: 0x0014D692
		// (set) Token: 0x0600E36E RID: 58222 RVA: 0x0014F4AB File Offset: 0x0014D6AB
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

		// Token: 0x170035BE RID: 13758
		// (get) Token: 0x0600E36F RID: 58223 RVA: 0x0014F4DB File Offset: 0x0014D6DB
		// (set) Token: 0x0600E370 RID: 58224 RVA: 0x0014F4F4 File Offset: 0x0014D6F4
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

		// Token: 0x170035BF RID: 13759
		// (get) Token: 0x0600E371 RID: 58225 RVA: 0x0014F524 File Offset: 0x0014D724
		// (set) Token: 0x0600E372 RID: 58226 RVA: 0x0014F53D File Offset: 0x0014D73D
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

		// Token: 0x170035C0 RID: 13760
		// (get) Token: 0x0600E373 RID: 58227 RVA: 0x0014F56D File Offset: 0x0014D76D
		// (set) Token: 0x0600E374 RID: 58228 RVA: 0x0014F586 File Offset: 0x0014D786
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

		// Token: 0x170035C1 RID: 13761
		// (get) Token: 0x0600E375 RID: 58229 RVA: 0x0014F5B6 File Offset: 0x0014D7B6
		// (set) Token: 0x0600E376 RID: 58230 RVA: 0x0014F5CF File Offset: 0x0014D7CF
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

		// Token: 0x170035C2 RID: 13762
		// (get) Token: 0x0600E377 RID: 58231 RVA: 0x0014F5FF File Offset: 0x0014D7FF
		// (set) Token: 0x0600E378 RID: 58232 RVA: 0x0014F618 File Offset: 0x0014D818
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

		// Token: 0x170035C3 RID: 13763
		// (get) Token: 0x0600E379 RID: 58233 RVA: 0x0014F648 File Offset: 0x0014D848
		// (set) Token: 0x0600E37A RID: 58234 RVA: 0x0014F661 File Offset: 0x0014D861
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

		// Token: 0x170035C4 RID: 13764
		// (get) Token: 0x0600E37B RID: 58235 RVA: 0x0014F691 File Offset: 0x0014D891
		// (set) Token: 0x0600E37C RID: 58236 RVA: 0x0014F6AA File Offset: 0x0014D8AA
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

		// Token: 0x170035C5 RID: 13765
		// (get) Token: 0x0600E37D RID: 58237 RVA: 0x0014F6DA File Offset: 0x0014D8DA
		// (set) Token: 0x0600E37E RID: 58238 RVA: 0x0014F6F3 File Offset: 0x0014D8F3
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

		// Token: 0x170035C6 RID: 13766
		// (get) Token: 0x0600E37F RID: 58239 RVA: 0x0014F723 File Offset: 0x0014D923
		// (set) Token: 0x0600E380 RID: 58240 RVA: 0x0014F73C File Offset: 0x0014D93C
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

		// Token: 0x170035C7 RID: 13767
		// (get) Token: 0x0600E381 RID: 58241 RVA: 0x0014F76C File Offset: 0x0014D96C
		// (set) Token: 0x0600E382 RID: 58242 RVA: 0x0014F785 File Offset: 0x0014D985
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

		// Token: 0x170035C8 RID: 13768
		// (get) Token: 0x0600E383 RID: 58243 RVA: 0x0014F7B5 File Offset: 0x0014D9B5
		// (set) Token: 0x0600E384 RID: 58244 RVA: 0x0014F7CE File Offset: 0x0014D9CE
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

		// Token: 0x170035C9 RID: 13769
		// (get) Token: 0x0600E385 RID: 58245 RVA: 0x0014F7FE File Offset: 0x0014D9FE
		// (set) Token: 0x0600E386 RID: 58246 RVA: 0x0014F817 File Offset: 0x0014DA17
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

		// Token: 0x170035CA RID: 13770
		// (get) Token: 0x0600E387 RID: 58247 RVA: 0x0014F847 File Offset: 0x0014DA47
		// (set) Token: 0x0600E388 RID: 58248 RVA: 0x0014F860 File Offset: 0x0014DA60
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

		// Token: 0x170035CB RID: 13771
		// (get) Token: 0x0600E389 RID: 58249 RVA: 0x0014F890 File Offset: 0x0014DA90
		// (set) Token: 0x0600E38A RID: 58250 RVA: 0x0014F8A9 File Offset: 0x0014DAA9
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

		// Token: 0x170035CC RID: 13772
		// (get) Token: 0x0600E38B RID: 58251 RVA: 0x0014F8D9 File Offset: 0x0014DAD9
		// (set) Token: 0x0600E38C RID: 58252 RVA: 0x0014F8F2 File Offset: 0x0014DAF2
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

		// Token: 0x170035CD RID: 13773
		// (get) Token: 0x0600E38D RID: 58253 RVA: 0x0014F922 File Offset: 0x0014DB22
		// (set) Token: 0x0600E38E RID: 58254 RVA: 0x0014F93B File Offset: 0x0014DB3B
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

		// Token: 0x170035CE RID: 13774
		// (get) Token: 0x0600E38F RID: 58255 RVA: 0x0014F96B File Offset: 0x0014DB6B
		// (set) Token: 0x0600E390 RID: 58256 RVA: 0x0014F984 File Offset: 0x0014DB84
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

		// Token: 0x170035CF RID: 13775
		// (get) Token: 0x0600E391 RID: 58257 RVA: 0x0014F9B4 File Offset: 0x0014DBB4
		// (set) Token: 0x0600E392 RID: 58258 RVA: 0x0014F9CD File Offset: 0x0014DBCD
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

		// Token: 0x170035D0 RID: 13776
		// (get) Token: 0x0600E393 RID: 58259 RVA: 0x0014F9FD File Offset: 0x0014DBFD
		// (set) Token: 0x0600E394 RID: 58260 RVA: 0x0014FA16 File Offset: 0x0014DC16
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

		// Token: 0x170035D1 RID: 13777
		// (get) Token: 0x0600E395 RID: 58261 RVA: 0x0014FA46 File Offset: 0x0014DC46
		// (set) Token: 0x0600E396 RID: 58262 RVA: 0x0014FA5F File Offset: 0x0014DC5F
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

		// Token: 0x170035D2 RID: 13778
		// (get) Token: 0x0600E397 RID: 58263 RVA: 0x0014FA8F File Offset: 0x0014DC8F
		// (set) Token: 0x0600E398 RID: 58264 RVA: 0x0014FAA8 File Offset: 0x0014DCA8
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

		// Token: 0x170035D3 RID: 13779
		// (get) Token: 0x0600E399 RID: 58265 RVA: 0x0014FAD8 File Offset: 0x0014DCD8
		// (set) Token: 0x0600E39A RID: 58266 RVA: 0x0014FAF1 File Offset: 0x0014DCF1
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

		// Token: 0x170035D4 RID: 13780
		// (get) Token: 0x0600E39B RID: 58267 RVA: 0x0014FB21 File Offset: 0x0014DD21
		// (set) Token: 0x0600E39C RID: 58268 RVA: 0x0014FB3A File Offset: 0x0014DD3A
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

		// Token: 0x170035D5 RID: 13781
		// (get) Token: 0x0600E39D RID: 58269 RVA: 0x0014FB6A File Offset: 0x0014DD6A
		// (set) Token: 0x0600E39E RID: 58270 RVA: 0x0014FB83 File Offset: 0x0014DD83
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

		// Token: 0x170035D6 RID: 13782
		// (get) Token: 0x0600E39F RID: 58271 RVA: 0x0014FBB3 File Offset: 0x0014DDB3
		// (set) Token: 0x0600E3A0 RID: 58272 RVA: 0x0014FBCC File Offset: 0x0014DDCC
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

		// Token: 0x170035D7 RID: 13783
		// (get) Token: 0x0600E3A1 RID: 58273 RVA: 0x0014FBFC File Offset: 0x0014DDFC
		// (set) Token: 0x0600E3A2 RID: 58274 RVA: 0x0014FC15 File Offset: 0x0014DE15
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

		// Token: 0x170035D8 RID: 13784
		// (get) Token: 0x0600E3A3 RID: 58275 RVA: 0x0014FC45 File Offset: 0x0014DE45
		// (set) Token: 0x0600E3A4 RID: 58276 RVA: 0x0014FC5E File Offset: 0x0014DE5E
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

		// Token: 0x170035D9 RID: 13785
		// (get) Token: 0x0600E3A5 RID: 58277 RVA: 0x0014FC8E File Offset: 0x0014DE8E
		// (set) Token: 0x0600E3A6 RID: 58278 RVA: 0x0014FCA7 File Offset: 0x0014DEA7
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

		// Token: 0x170035DA RID: 13786
		// (get) Token: 0x0600E3A7 RID: 58279 RVA: 0x0014FCD7 File Offset: 0x0014DED7
		// (set) Token: 0x0600E3A8 RID: 58280 RVA: 0x0014FCF0 File Offset: 0x0014DEF0
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

		// Token: 0x170035DB RID: 13787
		// (get) Token: 0x0600E3A9 RID: 58281 RVA: 0x0014FD20 File Offset: 0x0014DF20
		// (set) Token: 0x0600E3AA RID: 58282 RVA: 0x0014FD39 File Offset: 0x0014DF39
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

		// Token: 0x170035DC RID: 13788
		// (get) Token: 0x0600E3AB RID: 58283 RVA: 0x0014FD69 File Offset: 0x0014DF69
		// (set) Token: 0x0600E3AC RID: 58284 RVA: 0x0014FD82 File Offset: 0x0014DF82
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

		// Token: 0x170035DD RID: 13789
		// (get) Token: 0x0600E3AD RID: 58285 RVA: 0x0014FDB2 File Offset: 0x0014DFB2
		// (set) Token: 0x0600E3AE RID: 58286 RVA: 0x0014FDCB File Offset: 0x0014DFCB
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

		// Token: 0x170035DE RID: 13790
		// (get) Token: 0x0600E3AF RID: 58287 RVA: 0x0014FDFB File Offset: 0x0014DFFB
		// (set) Token: 0x0600E3B0 RID: 58288 RVA: 0x0014FE14 File Offset: 0x0014E014
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

		// Token: 0x170035DF RID: 13791
		// (get) Token: 0x0600E3B1 RID: 58289 RVA: 0x0014FE44 File Offset: 0x0014E044
		// (set) Token: 0x0600E3B2 RID: 58290 RVA: 0x0014FE5D File Offset: 0x0014E05D
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

		// Token: 0x170035E0 RID: 13792
		// (get) Token: 0x0600E3B3 RID: 58291 RVA: 0x0014FE8D File Offset: 0x0014E08D
		// (set) Token: 0x0600E3B4 RID: 58292 RVA: 0x0014FEA6 File Offset: 0x0014E0A6
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

		// Token: 0x170035E1 RID: 13793
		// (get) Token: 0x0600E3B5 RID: 58293 RVA: 0x0014FED6 File Offset: 0x0014E0D6
		// (set) Token: 0x0600E3B6 RID: 58294 RVA: 0x0014FEEF File Offset: 0x0014E0EF
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

		// Token: 0x170035E2 RID: 13794
		// (get) Token: 0x0600E3B7 RID: 58295 RVA: 0x0014FF1F File Offset: 0x0014E11F
		// (set) Token: 0x0600E3B8 RID: 58296 RVA: 0x0014FF38 File Offset: 0x0014E138
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

		// Token: 0x170035E3 RID: 13795
		// (get) Token: 0x0600E3B9 RID: 58297 RVA: 0x0014FF68 File Offset: 0x0014E168
		// (set) Token: 0x0600E3BA RID: 58298 RVA: 0x0014FF81 File Offset: 0x0014E181
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

		// Token: 0x170035E4 RID: 13796
		// (get) Token: 0x0600E3BB RID: 58299 RVA: 0x0014FFB1 File Offset: 0x0014E1B1
		// (set) Token: 0x0600E3BC RID: 58300 RVA: 0x0014FFCA File Offset: 0x0014E1CA
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

		// Token: 0x170035E5 RID: 13797
		// (get) Token: 0x0600E3BD RID: 58301 RVA: 0x0014FFFA File Offset: 0x0014E1FA
		// (set) Token: 0x0600E3BE RID: 58302 RVA: 0x00150013 File Offset: 0x0014E213
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

		// Token: 0x170035E6 RID: 13798
		// (get) Token: 0x0600E3BF RID: 58303 RVA: 0x00150043 File Offset: 0x0014E243
		// (set) Token: 0x0600E3C0 RID: 58304 RVA: 0x0015005C File Offset: 0x0014E25C
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

		// Token: 0x170035E7 RID: 13799
		// (get) Token: 0x0600E3C1 RID: 58305 RVA: 0x0015008C File Offset: 0x0014E28C
		// (set) Token: 0x0600E3C2 RID: 58306 RVA: 0x001500A5 File Offset: 0x0014E2A5
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

		// Token: 0x170035E8 RID: 13800
		// (get) Token: 0x0600E3C3 RID: 58307 RVA: 0x001500D5 File Offset: 0x0014E2D5
		// (set) Token: 0x0600E3C4 RID: 58308 RVA: 0x001500EE File Offset: 0x0014E2EE
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

		// Token: 0x170035E9 RID: 13801
		// (get) Token: 0x0600E3C5 RID: 58309 RVA: 0x0015011E File Offset: 0x0014E31E
		// (set) Token: 0x0600E3C6 RID: 58310 RVA: 0x00150137 File Offset: 0x0014E337
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

		// Token: 0x170035EA RID: 13802
		// (get) Token: 0x0600E3C7 RID: 58311 RVA: 0x00150167 File Offset: 0x0014E367
		// (set) Token: 0x0600E3C8 RID: 58312 RVA: 0x00150180 File Offset: 0x0014E380
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

		// Token: 0x170035EB RID: 13803
		// (get) Token: 0x0600E3C9 RID: 58313 RVA: 0x001501B0 File Offset: 0x0014E3B0
		// (set) Token: 0x0600E3CA RID: 58314 RVA: 0x001501C9 File Offset: 0x0014E3C9
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

		// Token: 0x170035EC RID: 13804
		// (get) Token: 0x0600E3CB RID: 58315 RVA: 0x001501F9 File Offset: 0x0014E3F9
		// (set) Token: 0x0600E3CC RID: 58316 RVA: 0x00150212 File Offset: 0x0014E412
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

		// Token: 0x170035ED RID: 13805
		// (get) Token: 0x0600E3CD RID: 58317 RVA: 0x00150242 File Offset: 0x0014E442
		// (set) Token: 0x0600E3CE RID: 58318 RVA: 0x0015025B File Offset: 0x0014E45B
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

		// Token: 0x170035EE RID: 13806
		// (get) Token: 0x0600E3CF RID: 58319 RVA: 0x0015028B File Offset: 0x0014E48B
		// (set) Token: 0x0600E3D0 RID: 58320 RVA: 0x001502A4 File Offset: 0x0014E4A4
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

		// Token: 0x170035EF RID: 13807
		// (get) Token: 0x0600E3D1 RID: 58321 RVA: 0x001502D4 File Offset: 0x0014E4D4
		// (set) Token: 0x0600E3D2 RID: 58322 RVA: 0x001502ED File Offset: 0x0014E4ED
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

		// Token: 0x170035F0 RID: 13808
		// (get) Token: 0x0600E3D3 RID: 58323 RVA: 0x0015031D File Offset: 0x0014E51D
		// (set) Token: 0x0600E3D4 RID: 58324 RVA: 0x00150336 File Offset: 0x0014E536
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

		// Token: 0x170035F1 RID: 13809
		// (get) Token: 0x0600E3D5 RID: 58325 RVA: 0x00150366 File Offset: 0x0014E566
		// (set) Token: 0x0600E3D6 RID: 58326 RVA: 0x0015037F File Offset: 0x0014E57F
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

		// Token: 0x170035F2 RID: 13810
		// (get) Token: 0x0600E3D7 RID: 58327 RVA: 0x001503AF File Offset: 0x0014E5AF
		// (set) Token: 0x0600E3D8 RID: 58328 RVA: 0x001503C8 File Offset: 0x0014E5C8
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

		// Token: 0x170035F3 RID: 13811
		// (get) Token: 0x0600E3D9 RID: 58329 RVA: 0x001503F8 File Offset: 0x0014E5F8
		// (set) Token: 0x0600E3DA RID: 58330 RVA: 0x00150411 File Offset: 0x0014E611
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

		// Token: 0x170035F4 RID: 13812
		// (get) Token: 0x0600E3DB RID: 58331 RVA: 0x00150441 File Offset: 0x0014E641
		// (set) Token: 0x0600E3DC RID: 58332 RVA: 0x0015045A File Offset: 0x0014E65A
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

		// Token: 0x170035F5 RID: 13813
		// (get) Token: 0x0600E3DD RID: 58333 RVA: 0x0015048A File Offset: 0x0014E68A
		// (set) Token: 0x0600E3DE RID: 58334 RVA: 0x001504A3 File Offset: 0x0014E6A3
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

		// Token: 0x170035F6 RID: 13814
		// (get) Token: 0x0600E3DF RID: 58335 RVA: 0x001504D3 File Offset: 0x0014E6D3
		// (set) Token: 0x0600E3E0 RID: 58336 RVA: 0x001504EC File Offset: 0x0014E6EC
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

		// Token: 0x170035F7 RID: 13815
		// (get) Token: 0x0600E3E1 RID: 58337 RVA: 0x0015051C File Offset: 0x0014E71C
		// (set) Token: 0x0600E3E2 RID: 58338 RVA: 0x00150535 File Offset: 0x0014E735
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

		// Token: 0x170035F8 RID: 13816
		// (get) Token: 0x0600E3E3 RID: 58339 RVA: 0x00150565 File Offset: 0x0014E765
		// (set) Token: 0x0600E3E4 RID: 58340 RVA: 0x0015057E File Offset: 0x0014E77E
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

		// Token: 0x170035F9 RID: 13817
		// (get) Token: 0x0600E3E5 RID: 58341 RVA: 0x001505AE File Offset: 0x0014E7AE
		// (set) Token: 0x0600E3E6 RID: 58342 RVA: 0x001505C7 File Offset: 0x0014E7C7
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

		// Token: 0x170035FA RID: 13818
		// (get) Token: 0x0600E3E7 RID: 58343 RVA: 0x001505F7 File Offset: 0x0014E7F7
		// (set) Token: 0x0600E3E8 RID: 58344 RVA: 0x00150610 File Offset: 0x0014E810
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

		// Token: 0x170035FB RID: 13819
		// (get) Token: 0x0600E3E9 RID: 58345 RVA: 0x00150640 File Offset: 0x0014E840
		// (set) Token: 0x0600E3EA RID: 58346 RVA: 0x00150659 File Offset: 0x0014E859
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

		// Token: 0x170035FC RID: 13820
		// (get) Token: 0x0600E3EB RID: 58347 RVA: 0x00150689 File Offset: 0x0014E889
		// (set) Token: 0x0600E3EC RID: 58348 RVA: 0x001506A2 File Offset: 0x0014E8A2
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

		// Token: 0x170035FD RID: 13821
		// (get) Token: 0x0600E3ED RID: 58349 RVA: 0x001506D2 File Offset: 0x0014E8D2
		// (set) Token: 0x0600E3EE RID: 58350 RVA: 0x001506EB File Offset: 0x0014E8EB
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

		// Token: 0x170035FE RID: 13822
		// (get) Token: 0x0600E3EF RID: 58351 RVA: 0x0015071B File Offset: 0x0014E91B
		// (set) Token: 0x0600E3F0 RID: 58352 RVA: 0x00150734 File Offset: 0x0014E934
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

		// Token: 0x170035FF RID: 13823
		// (get) Token: 0x0600E3F1 RID: 58353 RVA: 0x00150764 File Offset: 0x0014E964
		// (set) Token: 0x0600E3F2 RID: 58354 RVA: 0x0015077D File Offset: 0x0014E97D
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

		// Token: 0x17003600 RID: 13824
		// (get) Token: 0x0600E3F3 RID: 58355 RVA: 0x001507AD File Offset: 0x0014E9AD
		// (set) Token: 0x0600E3F4 RID: 58356 RVA: 0x001507C6 File Offset: 0x0014E9C6
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

		// Token: 0x17003601 RID: 13825
		// (get) Token: 0x0600E3F5 RID: 58357 RVA: 0x001507F6 File Offset: 0x0014E9F6
		// (set) Token: 0x0600E3F6 RID: 58358 RVA: 0x0015080F File Offset: 0x0014EA0F
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

		// Token: 0x17003602 RID: 13826
		// (get) Token: 0x0600E3F7 RID: 58359 RVA: 0x0015083F File Offset: 0x0014EA3F
		// (set) Token: 0x0600E3F8 RID: 58360 RVA: 0x00150858 File Offset: 0x0014EA58
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

		// Token: 0x17003603 RID: 13827
		// (get) Token: 0x0600E3F9 RID: 58361 RVA: 0x00150888 File Offset: 0x0014EA88
		// (set) Token: 0x0600E3FA RID: 58362 RVA: 0x001508A1 File Offset: 0x0014EAA1
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

		// Token: 0x17003604 RID: 13828
		// (get) Token: 0x0600E3FB RID: 58363 RVA: 0x001508D1 File Offset: 0x0014EAD1
		// (set) Token: 0x0600E3FC RID: 58364 RVA: 0x001508EA File Offset: 0x0014EAEA
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

		// Token: 0x17003605 RID: 13829
		// (get) Token: 0x0600E3FD RID: 58365 RVA: 0x0015091A File Offset: 0x0014EB1A
		// (set) Token: 0x0600E3FE RID: 58366 RVA: 0x00150933 File Offset: 0x0014EB33
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

		// Token: 0x17003606 RID: 13830
		// (get) Token: 0x0600E3FF RID: 58367 RVA: 0x00150963 File Offset: 0x0014EB63
		// (set) Token: 0x0600E400 RID: 58368 RVA: 0x0015097C File Offset: 0x0014EB7C
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

		// Token: 0x17003607 RID: 13831
		// (get) Token: 0x0600E401 RID: 58369 RVA: 0x001509AC File Offset: 0x0014EBAC
		// (set) Token: 0x0600E402 RID: 58370 RVA: 0x001509C5 File Offset: 0x0014EBC5
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

		// Token: 0x17003608 RID: 13832
		// (get) Token: 0x0600E403 RID: 58371 RVA: 0x001509F5 File Offset: 0x0014EBF5
		// (set) Token: 0x0600E404 RID: 58372 RVA: 0x00150A0E File Offset: 0x0014EC0E
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

		// Token: 0x17003609 RID: 13833
		// (get) Token: 0x0600E405 RID: 58373 RVA: 0x00150A3E File Offset: 0x0014EC3E
		// (set) Token: 0x0600E406 RID: 58374 RVA: 0x00150A57 File Offset: 0x0014EC57
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

		// Token: 0x1700360A RID: 13834
		// (get) Token: 0x0600E407 RID: 58375 RVA: 0x00150A87 File Offset: 0x0014EC87
		// (set) Token: 0x0600E408 RID: 58376 RVA: 0x00150AA0 File Offset: 0x0014ECA0
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

		// Token: 0x1700360B RID: 13835
		// (get) Token: 0x0600E409 RID: 58377 RVA: 0x00150AD0 File Offset: 0x0014ECD0
		// (set) Token: 0x0600E40A RID: 58378 RVA: 0x00150AE9 File Offset: 0x0014ECE9
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

		// Token: 0x1700360C RID: 13836
		// (get) Token: 0x0600E40B RID: 58379 RVA: 0x00150B19 File Offset: 0x0014ED19
		// (set) Token: 0x0600E40C RID: 58380 RVA: 0x00150B32 File Offset: 0x0014ED32
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

		// Token: 0x1700360D RID: 13837
		// (get) Token: 0x0600E40D RID: 58381 RVA: 0x00150B62 File Offset: 0x0014ED62
		// (set) Token: 0x0600E40E RID: 58382 RVA: 0x00150B7B File Offset: 0x0014ED7B
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

		// Token: 0x1700360E RID: 13838
		// (get) Token: 0x0600E40F RID: 58383 RVA: 0x00150BAB File Offset: 0x0014EDAB
		// (set) Token: 0x0600E410 RID: 58384 RVA: 0x00150BC4 File Offset: 0x0014EDC4
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

		// Token: 0x1700360F RID: 13839
		// (get) Token: 0x0600E411 RID: 58385 RVA: 0x00150BF4 File Offset: 0x0014EDF4
		// (set) Token: 0x0600E412 RID: 58386 RVA: 0x00150C0D File Offset: 0x0014EE0D
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

		// Token: 0x17003610 RID: 13840
		// (get) Token: 0x0600E413 RID: 58387 RVA: 0x00150C3D File Offset: 0x0014EE3D
		// (set) Token: 0x0600E414 RID: 58388 RVA: 0x00150C56 File Offset: 0x0014EE56
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

		// Token: 0x17003611 RID: 13841
		// (get) Token: 0x0600E415 RID: 58389 RVA: 0x00150C86 File Offset: 0x0014EE86
		// (set) Token: 0x0600E416 RID: 58390 RVA: 0x00150C9F File Offset: 0x0014EE9F
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

		// Token: 0x17003612 RID: 13842
		// (get) Token: 0x0600E417 RID: 58391 RVA: 0x00150CCF File Offset: 0x0014EECF
		// (set) Token: 0x0600E418 RID: 58392 RVA: 0x00150CE8 File Offset: 0x0014EEE8
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

		// Token: 0x17003613 RID: 13843
		// (get) Token: 0x0600E419 RID: 58393 RVA: 0x00150D18 File Offset: 0x0014EF18
		// (set) Token: 0x0600E41A RID: 58394 RVA: 0x00150D31 File Offset: 0x0014EF31
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

		// Token: 0x17003614 RID: 13844
		// (get) Token: 0x0600E41B RID: 58395 RVA: 0x00150D61 File Offset: 0x0014EF61
		// (set) Token: 0x0600E41C RID: 58396 RVA: 0x00150D7A File Offset: 0x0014EF7A
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

		// Token: 0x17003615 RID: 13845
		// (get) Token: 0x0600E41D RID: 58397 RVA: 0x00150DAA File Offset: 0x0014EFAA
		// (set) Token: 0x0600E41E RID: 58398 RVA: 0x00150DC3 File Offset: 0x0014EFC3
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

		// Token: 0x17003616 RID: 13846
		// (get) Token: 0x0600E41F RID: 58399 RVA: 0x00150DF3 File Offset: 0x0014EFF3
		// (set) Token: 0x0600E420 RID: 58400 RVA: 0x00150E0C File Offset: 0x0014F00C
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

		// Token: 0x17003617 RID: 13847
		// (get) Token: 0x0600E421 RID: 58401 RVA: 0x00150E3C File Offset: 0x0014F03C
		// (set) Token: 0x0600E422 RID: 58402 RVA: 0x00150E55 File Offset: 0x0014F055
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

		// Token: 0x17003618 RID: 13848
		// (get) Token: 0x0600E423 RID: 58403 RVA: 0x00150E85 File Offset: 0x0014F085
		// (set) Token: 0x0600E424 RID: 58404 RVA: 0x00150E9E File Offset: 0x0014F09E
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

		// Token: 0x17003619 RID: 13849
		// (get) Token: 0x0600E425 RID: 58405 RVA: 0x00150ECE File Offset: 0x0014F0CE
		// (set) Token: 0x0600E426 RID: 58406 RVA: 0x00150EE7 File Offset: 0x0014F0E7
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

		// Token: 0x1700361A RID: 13850
		// (get) Token: 0x0600E427 RID: 58407 RVA: 0x00150F17 File Offset: 0x0014F117
		// (set) Token: 0x0600E428 RID: 58408 RVA: 0x00150F30 File Offset: 0x0014F130
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

		// Token: 0x1700361B RID: 13851
		// (get) Token: 0x0600E429 RID: 58409 RVA: 0x00150F60 File Offset: 0x0014F160
		// (set) Token: 0x0600E42A RID: 58410 RVA: 0x00150F79 File Offset: 0x0014F179
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

		// Token: 0x1700361C RID: 13852
		// (get) Token: 0x0600E42B RID: 58411 RVA: 0x00150FA9 File Offset: 0x0014F1A9
		// (set) Token: 0x0600E42C RID: 58412 RVA: 0x00150FC2 File Offset: 0x0014F1C2
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

		// Token: 0x1700361D RID: 13853
		// (get) Token: 0x0600E42D RID: 58413 RVA: 0x00150FF2 File Offset: 0x0014F1F2
		// (set) Token: 0x0600E42E RID: 58414 RVA: 0x0015100B File Offset: 0x0014F20B
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

		// Token: 0x1700361E RID: 13854
		// (get) Token: 0x0600E42F RID: 58415 RVA: 0x0015103B File Offset: 0x0014F23B
		// (set) Token: 0x0600E430 RID: 58416 RVA: 0x00151054 File Offset: 0x0014F254
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

		// Token: 0x1700361F RID: 13855
		// (get) Token: 0x0600E431 RID: 58417 RVA: 0x00151084 File Offset: 0x0014F284
		// (set) Token: 0x0600E432 RID: 58418 RVA: 0x0015109D File Offset: 0x0014F29D
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

		// Token: 0x17003620 RID: 13856
		// (get) Token: 0x0600E433 RID: 58419 RVA: 0x001510CD File Offset: 0x0014F2CD
		// (set) Token: 0x0600E434 RID: 58420 RVA: 0x001510E6 File Offset: 0x0014F2E6
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

		// Token: 0x17003621 RID: 13857
		// (get) Token: 0x0600E435 RID: 58421 RVA: 0x00151116 File Offset: 0x0014F316
		// (set) Token: 0x0600E436 RID: 58422 RVA: 0x0015112F File Offset: 0x0014F32F
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

		// Token: 0x17003622 RID: 13858
		// (get) Token: 0x0600E437 RID: 58423 RVA: 0x0015115F File Offset: 0x0014F35F
		// (set) Token: 0x0600E438 RID: 58424 RVA: 0x00151178 File Offset: 0x0014F378
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

		// Token: 0x17003623 RID: 13859
		// (get) Token: 0x0600E439 RID: 58425 RVA: 0x001511A8 File Offset: 0x0014F3A8
		// (set) Token: 0x0600E43A RID: 58426 RVA: 0x001511C1 File Offset: 0x0014F3C1
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

		// Token: 0x17003624 RID: 13860
		// (get) Token: 0x0600E43B RID: 58427 RVA: 0x001511F1 File Offset: 0x0014F3F1
		// (set) Token: 0x0600E43C RID: 58428 RVA: 0x0015120A File Offset: 0x0014F40A
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

		// Token: 0x17003625 RID: 13861
		// (get) Token: 0x0600E43D RID: 58429 RVA: 0x0015123A File Offset: 0x0014F43A
		// (set) Token: 0x0600E43E RID: 58430 RVA: 0x00151253 File Offset: 0x0014F453
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

		// Token: 0x17003626 RID: 13862
		// (get) Token: 0x0600E43F RID: 58431 RVA: 0x00151283 File Offset: 0x0014F483
		// (set) Token: 0x0600E440 RID: 58432 RVA: 0x0015129C File Offset: 0x0014F49C
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

		// Token: 0x17003627 RID: 13863
		// (get) Token: 0x0600E441 RID: 58433 RVA: 0x001512CC File Offset: 0x0014F4CC
		// (set) Token: 0x0600E442 RID: 58434 RVA: 0x001512E5 File Offset: 0x0014F4E5
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

		// Token: 0x17003628 RID: 13864
		// (get) Token: 0x0600E443 RID: 58435 RVA: 0x00151315 File Offset: 0x0014F515
		// (set) Token: 0x0600E444 RID: 58436 RVA: 0x0015132E File Offset: 0x0014F52E
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

		// Token: 0x17003629 RID: 13865
		// (get) Token: 0x0600E445 RID: 58437 RVA: 0x0015135E File Offset: 0x0014F55E
		// (set) Token: 0x0600E446 RID: 58438 RVA: 0x00151377 File Offset: 0x0014F577
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

		// Token: 0x1700362A RID: 13866
		// (get) Token: 0x0600E447 RID: 58439 RVA: 0x001513A7 File Offset: 0x0014F5A7
		// (set) Token: 0x0600E448 RID: 58440 RVA: 0x001513C0 File Offset: 0x0014F5C0
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

		// Token: 0x1700362B RID: 13867
		// (get) Token: 0x0600E449 RID: 58441 RVA: 0x001513F0 File Offset: 0x0014F5F0
		// (set) Token: 0x0600E44A RID: 58442 RVA: 0x00151409 File Offset: 0x0014F609
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

		// Token: 0x1700362C RID: 13868
		// (get) Token: 0x0600E44B RID: 58443 RVA: 0x00151439 File Offset: 0x0014F639
		// (set) Token: 0x0600E44C RID: 58444 RVA: 0x00151452 File Offset: 0x0014F652
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

		// Token: 0x1700362D RID: 13869
		// (get) Token: 0x0600E44D RID: 58445 RVA: 0x00151482 File Offset: 0x0014F682
		// (set) Token: 0x0600E44E RID: 58446 RVA: 0x0015149B File Offset: 0x0014F69B
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

		// Token: 0x1700362E RID: 13870
		// (get) Token: 0x0600E44F RID: 58447 RVA: 0x001514CB File Offset: 0x0014F6CB
		// (set) Token: 0x0600E450 RID: 58448 RVA: 0x001514E4 File Offset: 0x0014F6E4
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

		// Token: 0x1700362F RID: 13871
		// (get) Token: 0x0600E451 RID: 58449 RVA: 0x00151514 File Offset: 0x0014F714
		// (set) Token: 0x0600E452 RID: 58450 RVA: 0x0015152D File Offset: 0x0014F72D
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

		// Token: 0x17003630 RID: 13872
		// (get) Token: 0x0600E453 RID: 58451 RVA: 0x0015155D File Offset: 0x0014F75D
		// (set) Token: 0x0600E454 RID: 58452 RVA: 0x00151576 File Offset: 0x0014F776
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

		// Token: 0x17003631 RID: 13873
		// (get) Token: 0x0600E455 RID: 58453 RVA: 0x001515A6 File Offset: 0x0014F7A6
		// (set) Token: 0x0600E456 RID: 58454 RVA: 0x001515BF File Offset: 0x0014F7BF
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

		// Token: 0x17003632 RID: 13874
		// (get) Token: 0x0600E457 RID: 58455 RVA: 0x001515EF File Offset: 0x0014F7EF
		// (set) Token: 0x0600E458 RID: 58456 RVA: 0x00151608 File Offset: 0x0014F808
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

		// Token: 0x17003633 RID: 13875
		// (get) Token: 0x0600E459 RID: 58457 RVA: 0x00151638 File Offset: 0x0014F838
		// (set) Token: 0x0600E45A RID: 58458 RVA: 0x00151651 File Offset: 0x0014F851
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

		// Token: 0x17003634 RID: 13876
		// (get) Token: 0x0600E45B RID: 58459 RVA: 0x00151681 File Offset: 0x0014F881
		// (set) Token: 0x0600E45C RID: 58460 RVA: 0x0015169A File Offset: 0x0014F89A
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

		// Token: 0x17003635 RID: 13877
		// (get) Token: 0x0600E45D RID: 58461 RVA: 0x001516CA File Offset: 0x0014F8CA
		// (set) Token: 0x0600E45E RID: 58462 RVA: 0x001516E3 File Offset: 0x0014F8E3
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

		// Token: 0x17003636 RID: 13878
		// (get) Token: 0x0600E45F RID: 58463 RVA: 0x00151713 File Offset: 0x0014F913
		// (set) Token: 0x0600E460 RID: 58464 RVA: 0x0015172C File Offset: 0x0014F92C
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

		// Token: 0x17003637 RID: 13879
		// (get) Token: 0x0600E461 RID: 58465 RVA: 0x0015175C File Offset: 0x0014F95C
		// (set) Token: 0x0600E462 RID: 58466 RVA: 0x00151775 File Offset: 0x0014F975
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

		// Token: 0x17003638 RID: 13880
		// (get) Token: 0x0600E463 RID: 58467 RVA: 0x001517A5 File Offset: 0x0014F9A5
		// (set) Token: 0x0600E464 RID: 58468 RVA: 0x001517BE File Offset: 0x0014F9BE
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

		// Token: 0x17003639 RID: 13881
		// (get) Token: 0x0600E465 RID: 58469 RVA: 0x001517EE File Offset: 0x0014F9EE
		// (set) Token: 0x0600E466 RID: 58470 RVA: 0x00151807 File Offset: 0x0014FA07
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

		// Token: 0x1700363A RID: 13882
		// (get) Token: 0x0600E467 RID: 58471 RVA: 0x00151837 File Offset: 0x0014FA37
		// (set) Token: 0x0600E468 RID: 58472 RVA: 0x00151850 File Offset: 0x0014FA50
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

		// Token: 0x1700363B RID: 13883
		// (get) Token: 0x0600E469 RID: 58473 RVA: 0x00151880 File Offset: 0x0014FA80
		// (set) Token: 0x0600E46A RID: 58474 RVA: 0x00151899 File Offset: 0x0014FA99
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

		// Token: 0x1700363C RID: 13884
		// (get) Token: 0x0600E46B RID: 58475 RVA: 0x001518C9 File Offset: 0x0014FAC9
		// (set) Token: 0x0600E46C RID: 58476 RVA: 0x001518E2 File Offset: 0x0014FAE2
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

		// Token: 0x1700363D RID: 13885
		// (get) Token: 0x0600E46D RID: 58477 RVA: 0x00151912 File Offset: 0x0014FB12
		// (set) Token: 0x0600E46E RID: 58478 RVA: 0x0015192B File Offset: 0x0014FB2B
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

		// Token: 0x1700363E RID: 13886
		// (get) Token: 0x0600E46F RID: 58479 RVA: 0x0015195B File Offset: 0x0014FB5B
		// (set) Token: 0x0600E470 RID: 58480 RVA: 0x00151974 File Offset: 0x0014FB74
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

		// Token: 0x1700363F RID: 13887
		// (get) Token: 0x0600E471 RID: 58481 RVA: 0x001519A4 File Offset: 0x0014FBA4
		// (set) Token: 0x0600E472 RID: 58482 RVA: 0x001519BD File Offset: 0x0014FBBD
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

		// Token: 0x17003640 RID: 13888
		// (get) Token: 0x0600E473 RID: 58483 RVA: 0x001519ED File Offset: 0x0014FBED
		// (set) Token: 0x0600E474 RID: 58484 RVA: 0x00151A06 File Offset: 0x0014FC06
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

		// Token: 0x17003641 RID: 13889
		// (get) Token: 0x0600E475 RID: 58485 RVA: 0x00151A36 File Offset: 0x0014FC36
		// (set) Token: 0x0600E476 RID: 58486 RVA: 0x00151A4F File Offset: 0x0014FC4F
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

		// Token: 0x17003642 RID: 13890
		// (get) Token: 0x0600E477 RID: 58487 RVA: 0x00151A7F File Offset: 0x0014FC7F
		// (set) Token: 0x0600E478 RID: 58488 RVA: 0x00151A98 File Offset: 0x0014FC98
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

		// Token: 0x17003643 RID: 13891
		// (get) Token: 0x0600E479 RID: 58489 RVA: 0x00151AC8 File Offset: 0x0014FCC8
		// (set) Token: 0x0600E47A RID: 58490 RVA: 0x00151AE1 File Offset: 0x0014FCE1
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

		// Token: 0x17003644 RID: 13892
		// (get) Token: 0x0600E47B RID: 58491 RVA: 0x00151B11 File Offset: 0x0014FD11
		// (set) Token: 0x0600E47C RID: 58492 RVA: 0x00151B2A File Offset: 0x0014FD2A
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

		// Token: 0x17003645 RID: 13893
		// (get) Token: 0x0600E47D RID: 58493 RVA: 0x00151B5A File Offset: 0x0014FD5A
		// (set) Token: 0x0600E47E RID: 58494 RVA: 0x00151B73 File Offset: 0x0014FD73
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

		// Token: 0x17003646 RID: 13894
		// (get) Token: 0x0600E47F RID: 58495 RVA: 0x00151BA3 File Offset: 0x0014FDA3
		// (set) Token: 0x0600E480 RID: 58496 RVA: 0x00151BBC File Offset: 0x0014FDBC
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

		// Token: 0x17003647 RID: 13895
		// (get) Token: 0x0600E481 RID: 58497 RVA: 0x00151BEC File Offset: 0x0014FDEC
		// (set) Token: 0x0600E482 RID: 58498 RVA: 0x00151C05 File Offset: 0x0014FE05
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

		// Token: 0x17003648 RID: 13896
		// (get) Token: 0x0600E483 RID: 58499 RVA: 0x00151C35 File Offset: 0x0014FE35
		// (set) Token: 0x0600E484 RID: 58500 RVA: 0x00151C4E File Offset: 0x0014FE4E
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

		// Token: 0x17003649 RID: 13897
		// (get) Token: 0x0600E485 RID: 58501 RVA: 0x00151C7E File Offset: 0x0014FE7E
		// (set) Token: 0x0600E486 RID: 58502 RVA: 0x00151C97 File Offset: 0x0014FE97
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

		// Token: 0x1700364A RID: 13898
		// (get) Token: 0x0600E487 RID: 58503 RVA: 0x00151CC7 File Offset: 0x0014FEC7
		// (set) Token: 0x0600E488 RID: 58504 RVA: 0x00151CE0 File Offset: 0x0014FEE0
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

		// Token: 0x1700364B RID: 13899
		// (get) Token: 0x0600E489 RID: 58505 RVA: 0x00151D10 File Offset: 0x0014FF10
		// (set) Token: 0x0600E48A RID: 58506 RVA: 0x00151D29 File Offset: 0x0014FF29
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

		// Token: 0x1700364C RID: 13900
		// (get) Token: 0x0600E48B RID: 58507 RVA: 0x00151D59 File Offset: 0x0014FF59
		// (set) Token: 0x0600E48C RID: 58508 RVA: 0x00151D72 File Offset: 0x0014FF72
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

		// Token: 0x1700364D RID: 13901
		// (get) Token: 0x0600E48D RID: 58509 RVA: 0x00151DA2 File Offset: 0x0014FFA2
		// (set) Token: 0x0600E48E RID: 58510 RVA: 0x00151DBB File Offset: 0x0014FFBB
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

		// Token: 0x1700364E RID: 13902
		// (get) Token: 0x0600E48F RID: 58511 RVA: 0x00151DEB File Offset: 0x0014FFEB
		// (set) Token: 0x0600E490 RID: 58512 RVA: 0x00151E04 File Offset: 0x00150004
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

		// Token: 0x1700364F RID: 13903
		// (get) Token: 0x0600E491 RID: 58513 RVA: 0x00151E34 File Offset: 0x00150034
		// (set) Token: 0x0600E492 RID: 58514 RVA: 0x00151E4D File Offset: 0x0015004D
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

		// Token: 0x17003650 RID: 13904
		// (get) Token: 0x0600E493 RID: 58515 RVA: 0x00151E7D File Offset: 0x0015007D
		// (set) Token: 0x0600E494 RID: 58516 RVA: 0x00151E96 File Offset: 0x00150096
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

		// Token: 0x17003651 RID: 13905
		// (get) Token: 0x0600E495 RID: 58517 RVA: 0x00151EC6 File Offset: 0x001500C6
		// (set) Token: 0x0600E496 RID: 58518 RVA: 0x00151EDF File Offset: 0x001500DF
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

		// Token: 0x17003652 RID: 13906
		// (get) Token: 0x0600E497 RID: 58519 RVA: 0x00151F0F File Offset: 0x0015010F
		// (set) Token: 0x0600E498 RID: 58520 RVA: 0x00151F28 File Offset: 0x00150128
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

		// Token: 0x17003653 RID: 13907
		// (get) Token: 0x0600E499 RID: 58521 RVA: 0x00151F58 File Offset: 0x00150158
		// (set) Token: 0x0600E49A RID: 58522 RVA: 0x00151F71 File Offset: 0x00150171
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

		// Token: 0x17003654 RID: 13908
		// (get) Token: 0x0600E49B RID: 58523 RVA: 0x00151FA1 File Offset: 0x001501A1
		// (set) Token: 0x0600E49C RID: 58524 RVA: 0x00151FBA File Offset: 0x001501BA
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

		// Token: 0x17003655 RID: 13909
		// (get) Token: 0x0600E49D RID: 58525 RVA: 0x00151FEA File Offset: 0x001501EA
		// (set) Token: 0x0600E49E RID: 58526 RVA: 0x00152003 File Offset: 0x00150203
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

		// Token: 0x17003656 RID: 13910
		// (get) Token: 0x0600E49F RID: 58527 RVA: 0x00152033 File Offset: 0x00150233
		// (set) Token: 0x0600E4A0 RID: 58528 RVA: 0x0015204C File Offset: 0x0015024C
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

		// Token: 0x17003657 RID: 13911
		// (get) Token: 0x0600E4A1 RID: 58529 RVA: 0x0015207C File Offset: 0x0015027C
		// (set) Token: 0x0600E4A2 RID: 58530 RVA: 0x00152095 File Offset: 0x00150295
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

		// Token: 0x17003658 RID: 13912
		// (get) Token: 0x0600E4A3 RID: 58531 RVA: 0x001520C5 File Offset: 0x001502C5
		// (set) Token: 0x0600E4A4 RID: 58532 RVA: 0x001520DE File Offset: 0x001502DE
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

		// Token: 0x17003659 RID: 13913
		// (get) Token: 0x0600E4A5 RID: 58533 RVA: 0x0015210E File Offset: 0x0015030E
		// (set) Token: 0x0600E4A6 RID: 58534 RVA: 0x00152127 File Offset: 0x00150327
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

		// Token: 0x1700365A RID: 13914
		// (get) Token: 0x0600E4A7 RID: 58535 RVA: 0x00152157 File Offset: 0x00150357
		// (set) Token: 0x0600E4A8 RID: 58536 RVA: 0x00152170 File Offset: 0x00150370
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

		// Token: 0x1700365B RID: 13915
		// (get) Token: 0x0600E4A9 RID: 58537 RVA: 0x001521A0 File Offset: 0x001503A0
		// (set) Token: 0x0600E4AA RID: 58538 RVA: 0x001521B9 File Offset: 0x001503B9
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

		// Token: 0x1700365C RID: 13916
		// (get) Token: 0x0600E4AB RID: 58539 RVA: 0x001521E9 File Offset: 0x001503E9
		// (set) Token: 0x0600E4AC RID: 58540 RVA: 0x00152202 File Offset: 0x00150402
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

		// Token: 0x1700365D RID: 13917
		// (get) Token: 0x0600E4AD RID: 58541 RVA: 0x00152232 File Offset: 0x00150432
		// (set) Token: 0x0600E4AE RID: 58542 RVA: 0x0015224B File Offset: 0x0015044B
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

		// Token: 0x1700365E RID: 13918
		// (get) Token: 0x0600E4AF RID: 58543 RVA: 0x0015227B File Offset: 0x0015047B
		// (set) Token: 0x0600E4B0 RID: 58544 RVA: 0x00152294 File Offset: 0x00150494
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

		// Token: 0x1700365F RID: 13919
		// (get) Token: 0x0600E4B1 RID: 58545 RVA: 0x001522C4 File Offset: 0x001504C4
		// (set) Token: 0x0600E4B2 RID: 58546 RVA: 0x001522DD File Offset: 0x001504DD
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

		// Token: 0x17003660 RID: 13920
		// (get) Token: 0x0600E4B3 RID: 58547 RVA: 0x0015230D File Offset: 0x0015050D
		// (set) Token: 0x0600E4B4 RID: 58548 RVA: 0x00152326 File Offset: 0x00150526
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

		// Token: 0x17003661 RID: 13921
		// (get) Token: 0x0600E4B5 RID: 58549 RVA: 0x00152356 File Offset: 0x00150556
		// (set) Token: 0x0600E4B6 RID: 58550 RVA: 0x0015236F File Offset: 0x0015056F
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

		// Token: 0x17003662 RID: 13922
		// (get) Token: 0x0600E4B7 RID: 58551 RVA: 0x0015239F File Offset: 0x0015059F
		// (set) Token: 0x0600E4B8 RID: 58552 RVA: 0x001523B8 File Offset: 0x001505B8
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

		// Token: 0x17003663 RID: 13923
		// (get) Token: 0x0600E4B9 RID: 58553 RVA: 0x001523E8 File Offset: 0x001505E8
		// (set) Token: 0x0600E4BA RID: 58554 RVA: 0x00152401 File Offset: 0x00150601
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

		// Token: 0x17003664 RID: 13924
		// (get) Token: 0x0600E4BB RID: 58555 RVA: 0x00152431 File Offset: 0x00150631
		// (set) Token: 0x0600E4BC RID: 58556 RVA: 0x0015244A File Offset: 0x0015064A
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

		// Token: 0x17003665 RID: 13925
		// (get) Token: 0x0600E4BD RID: 58557 RVA: 0x0015247A File Offset: 0x0015067A
		// (set) Token: 0x0600E4BE RID: 58558 RVA: 0x00152493 File Offset: 0x00150693
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

		// Token: 0x17003666 RID: 13926
		// (get) Token: 0x0600E4BF RID: 58559 RVA: 0x001524C3 File Offset: 0x001506C3
		// (set) Token: 0x0600E4C0 RID: 58560 RVA: 0x001524DC File Offset: 0x001506DC
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

		// Token: 0x17003667 RID: 13927
		// (get) Token: 0x0600E4C1 RID: 58561 RVA: 0x0015250C File Offset: 0x0015070C
		// (set) Token: 0x0600E4C2 RID: 58562 RVA: 0x00152525 File Offset: 0x00150725
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

		// Token: 0x17003668 RID: 13928
		// (get) Token: 0x0600E4C3 RID: 58563 RVA: 0x00152555 File Offset: 0x00150755
		// (set) Token: 0x0600E4C4 RID: 58564 RVA: 0x0015256E File Offset: 0x0015076E
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

		// Token: 0x17003669 RID: 13929
		// (get) Token: 0x0600E4C5 RID: 58565 RVA: 0x0015259E File Offset: 0x0015079E
		// (set) Token: 0x0600E4C6 RID: 58566 RVA: 0x001525B7 File Offset: 0x001507B7
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

		// Token: 0x1700366A RID: 13930
		// (get) Token: 0x0600E4C7 RID: 58567 RVA: 0x001525E7 File Offset: 0x001507E7
		// (set) Token: 0x0600E4C8 RID: 58568 RVA: 0x00152600 File Offset: 0x00150800
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

		// Token: 0x1700366B RID: 13931
		// (get) Token: 0x0600E4C9 RID: 58569 RVA: 0x00152630 File Offset: 0x00150830
		// (set) Token: 0x0600E4CA RID: 58570 RVA: 0x00152649 File Offset: 0x00150849
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

		// Token: 0x1700366C RID: 13932
		// (get) Token: 0x0600E4CB RID: 58571 RVA: 0x00152679 File Offset: 0x00150879
		// (set) Token: 0x0600E4CC RID: 58572 RVA: 0x00152692 File Offset: 0x00150892
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

		// Token: 0x1700366D RID: 13933
		// (get) Token: 0x0600E4CD RID: 58573 RVA: 0x001526C2 File Offset: 0x001508C2
		// (set) Token: 0x0600E4CE RID: 58574 RVA: 0x001526DB File Offset: 0x001508DB
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

		// Token: 0x1700366E RID: 13934
		// (get) Token: 0x0600E4CF RID: 58575 RVA: 0x0015270B File Offset: 0x0015090B
		// (set) Token: 0x0600E4D0 RID: 58576 RVA: 0x00152724 File Offset: 0x00150924
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

		// Token: 0x1700366F RID: 13935
		// (get) Token: 0x0600E4D1 RID: 58577 RVA: 0x00152754 File Offset: 0x00150954
		// (set) Token: 0x0600E4D2 RID: 58578 RVA: 0x0015276D File Offset: 0x0015096D
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

		// Token: 0x17003670 RID: 13936
		// (get) Token: 0x0600E4D3 RID: 58579 RVA: 0x0015279D File Offset: 0x0015099D
		// (set) Token: 0x0600E4D4 RID: 58580 RVA: 0x001527B6 File Offset: 0x001509B6
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

		// Token: 0x17003671 RID: 13937
		// (get) Token: 0x0600E4D5 RID: 58581 RVA: 0x001527E6 File Offset: 0x001509E6
		// (set) Token: 0x0600E4D6 RID: 58582 RVA: 0x001527FF File Offset: 0x001509FF
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

		// Token: 0x17003672 RID: 13938
		// (get) Token: 0x0600E4D7 RID: 58583 RVA: 0x0015282F File Offset: 0x00150A2F
		// (set) Token: 0x0600E4D8 RID: 58584 RVA: 0x00152848 File Offset: 0x00150A48
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

		// Token: 0x17003673 RID: 13939
		// (get) Token: 0x0600E4D9 RID: 58585 RVA: 0x00152878 File Offset: 0x00150A78
		// (set) Token: 0x0600E4DA RID: 58586 RVA: 0x00152891 File Offset: 0x00150A91
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

		// Token: 0x17003674 RID: 13940
		// (get) Token: 0x0600E4DB RID: 58587 RVA: 0x001528C1 File Offset: 0x00150AC1
		// (set) Token: 0x0600E4DC RID: 58588 RVA: 0x001528DA File Offset: 0x00150ADA
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

		// Token: 0x17003675 RID: 13941
		// (get) Token: 0x0600E4DD RID: 58589 RVA: 0x0015290A File Offset: 0x00150B0A
		// (set) Token: 0x0600E4DE RID: 58590 RVA: 0x00152923 File Offset: 0x00150B23
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

		// Token: 0x17003676 RID: 13942
		// (get) Token: 0x0600E4DF RID: 58591 RVA: 0x00152953 File Offset: 0x00150B53
		// (set) Token: 0x0600E4E0 RID: 58592 RVA: 0x0015296C File Offset: 0x00150B6C
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

		// Token: 0x17003677 RID: 13943
		// (get) Token: 0x0600E4E1 RID: 58593 RVA: 0x0015299C File Offset: 0x00150B9C
		// (set) Token: 0x0600E4E2 RID: 58594 RVA: 0x001529B5 File Offset: 0x00150BB5
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

		// Token: 0x17003678 RID: 13944
		// (get) Token: 0x0600E4E3 RID: 58595 RVA: 0x001529E5 File Offset: 0x00150BE5
		// (set) Token: 0x0600E4E4 RID: 58596 RVA: 0x001529FE File Offset: 0x00150BFE
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

		// Token: 0x17003679 RID: 13945
		// (get) Token: 0x0600E4E5 RID: 58597 RVA: 0x00152A2E File Offset: 0x00150C2E
		// (set) Token: 0x0600E4E6 RID: 58598 RVA: 0x00152A47 File Offset: 0x00150C47
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

		// Token: 0x1700367A RID: 13946
		// (get) Token: 0x0600E4E7 RID: 58599 RVA: 0x00152A77 File Offset: 0x00150C77
		// (set) Token: 0x0600E4E8 RID: 58600 RVA: 0x00152A90 File Offset: 0x00150C90
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

		// Token: 0x1700367B RID: 13947
		// (get) Token: 0x0600E4E9 RID: 58601 RVA: 0x00152AC0 File Offset: 0x00150CC0
		// (set) Token: 0x0600E4EA RID: 58602 RVA: 0x00152AD9 File Offset: 0x00150CD9
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

		// Token: 0x1700367C RID: 13948
		// (get) Token: 0x0600E4EB RID: 58603 RVA: 0x00152B09 File Offset: 0x00150D09
		// (set) Token: 0x0600E4EC RID: 58604 RVA: 0x00152B22 File Offset: 0x00150D22
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

		// Token: 0x1700367D RID: 13949
		// (get) Token: 0x0600E4ED RID: 58605 RVA: 0x00152B52 File Offset: 0x00150D52
		// (set) Token: 0x0600E4EE RID: 58606 RVA: 0x00152B6B File Offset: 0x00150D6B
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

		// Token: 0x1700367E RID: 13950
		// (get) Token: 0x0600E4EF RID: 58607 RVA: 0x00152B9B File Offset: 0x00150D9B
		// (set) Token: 0x0600E4F0 RID: 58608 RVA: 0x00152BB4 File Offset: 0x00150DB4
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

		// Token: 0x1700367F RID: 13951
		// (get) Token: 0x0600E4F1 RID: 58609 RVA: 0x00152BE4 File Offset: 0x00150DE4
		// (set) Token: 0x0600E4F2 RID: 58610 RVA: 0x00152BFD File Offset: 0x00150DFD
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

		// Token: 0x17003680 RID: 13952
		// (get) Token: 0x0600E4F3 RID: 58611 RVA: 0x00152C2D File Offset: 0x00150E2D
		// (set) Token: 0x0600E4F4 RID: 58612 RVA: 0x00152C46 File Offset: 0x00150E46
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

		// Token: 0x17003681 RID: 13953
		// (get) Token: 0x0600E4F5 RID: 58613 RVA: 0x00152C76 File Offset: 0x00150E76
		// (set) Token: 0x0600E4F6 RID: 58614 RVA: 0x00152C8F File Offset: 0x00150E8F
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

		// Token: 0x17003682 RID: 13954
		// (get) Token: 0x0600E4F7 RID: 58615 RVA: 0x00152CBF File Offset: 0x00150EBF
		// (set) Token: 0x0600E4F8 RID: 58616 RVA: 0x00152CD8 File Offset: 0x00150ED8
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

		// Token: 0x17003683 RID: 13955
		// (get) Token: 0x0600E4F9 RID: 58617 RVA: 0x00152D08 File Offset: 0x00150F08
		// (set) Token: 0x0600E4FA RID: 58618 RVA: 0x00152D21 File Offset: 0x00150F21
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

		// Token: 0x17003684 RID: 13956
		// (get) Token: 0x0600E4FB RID: 58619 RVA: 0x00152D51 File Offset: 0x00150F51
		// (set) Token: 0x0600E4FC RID: 58620 RVA: 0x00152D6A File Offset: 0x00150F6A
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

		// Token: 0x17003685 RID: 13957
		// (get) Token: 0x0600E4FD RID: 58621 RVA: 0x00152D9A File Offset: 0x00150F9A
		// (set) Token: 0x0600E4FE RID: 58622 RVA: 0x00152DB3 File Offset: 0x00150FB3
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

		// Token: 0x17003686 RID: 13958
		// (get) Token: 0x0600E4FF RID: 58623 RVA: 0x00152DE3 File Offset: 0x00150FE3
		// (set) Token: 0x0600E500 RID: 58624 RVA: 0x00152DFC File Offset: 0x00150FFC
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

		// Token: 0x17003687 RID: 13959
		// (get) Token: 0x0600E501 RID: 58625 RVA: 0x00152E2C File Offset: 0x0015102C
		// (set) Token: 0x0600E502 RID: 58626 RVA: 0x00152E45 File Offset: 0x00151045
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

		// Token: 0x17003688 RID: 13960
		// (get) Token: 0x0600E503 RID: 58627 RVA: 0x00152E75 File Offset: 0x00151075
		// (set) Token: 0x0600E504 RID: 58628 RVA: 0x00152E8E File Offset: 0x0015108E
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

		// Token: 0x17003689 RID: 13961
		// (get) Token: 0x0600E505 RID: 58629 RVA: 0x00152EBE File Offset: 0x001510BE
		// (set) Token: 0x0600E506 RID: 58630 RVA: 0x00152ED7 File Offset: 0x001510D7
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

		// Token: 0x1700368A RID: 13962
		// (get) Token: 0x0600E507 RID: 58631 RVA: 0x00152F07 File Offset: 0x00151107
		// (set) Token: 0x0600E508 RID: 58632 RVA: 0x00152F20 File Offset: 0x00151120
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

		// Token: 0x1700368B RID: 13963
		// (get) Token: 0x0600E509 RID: 58633 RVA: 0x00152F50 File Offset: 0x00151150
		// (set) Token: 0x0600E50A RID: 58634 RVA: 0x00152F69 File Offset: 0x00151169
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

		// Token: 0x1700368C RID: 13964
		// (get) Token: 0x0600E50B RID: 58635 RVA: 0x00152F99 File Offset: 0x00151199
		// (set) Token: 0x0600E50C RID: 58636 RVA: 0x00152FB2 File Offset: 0x001511B2
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

		// Token: 0x1700368D RID: 13965
		// (get) Token: 0x0600E50D RID: 58637 RVA: 0x00152FE2 File Offset: 0x001511E2
		// (set) Token: 0x0600E50E RID: 58638 RVA: 0x00152FFB File Offset: 0x001511FB
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

		// Token: 0x1700368E RID: 13966
		// (get) Token: 0x0600E50F RID: 58639 RVA: 0x0015302B File Offset: 0x0015122B
		// (set) Token: 0x0600E510 RID: 58640 RVA: 0x00153044 File Offset: 0x00151244
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

		// Token: 0x1700368F RID: 13967
		// (get) Token: 0x0600E511 RID: 58641 RVA: 0x00153074 File Offset: 0x00151274
		// (set) Token: 0x0600E512 RID: 58642 RVA: 0x0015308D File Offset: 0x0015128D
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

		// Token: 0x17003690 RID: 13968
		// (get) Token: 0x0600E513 RID: 58643 RVA: 0x001530BD File Offset: 0x001512BD
		// (set) Token: 0x0600E514 RID: 58644 RVA: 0x001530D6 File Offset: 0x001512D6
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

		// Token: 0x17003691 RID: 13969
		// (get) Token: 0x0600E515 RID: 58645 RVA: 0x00153106 File Offset: 0x00151306
		// (set) Token: 0x0600E516 RID: 58646 RVA: 0x0015311F File Offset: 0x0015131F
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

		// Token: 0x17003692 RID: 13970
		// (get) Token: 0x0600E517 RID: 58647 RVA: 0x0015314F File Offset: 0x0015134F
		// (set) Token: 0x0600E518 RID: 58648 RVA: 0x00153168 File Offset: 0x00151368
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

		// Token: 0x17003693 RID: 13971
		// (get) Token: 0x0600E519 RID: 58649 RVA: 0x00153198 File Offset: 0x00151398
		// (set) Token: 0x0600E51A RID: 58650 RVA: 0x001531B1 File Offset: 0x001513B1
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

		// Token: 0x17003694 RID: 13972
		// (get) Token: 0x0600E51B RID: 58651 RVA: 0x001531E1 File Offset: 0x001513E1
		// (set) Token: 0x0600E51C RID: 58652 RVA: 0x001531FA File Offset: 0x001513FA
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

		// Token: 0x17003695 RID: 13973
		// (get) Token: 0x0600E51D RID: 58653 RVA: 0x0015322A File Offset: 0x0015142A
		// (set) Token: 0x0600E51E RID: 58654 RVA: 0x00153243 File Offset: 0x00151443
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

		// Token: 0x17003696 RID: 13974
		// (get) Token: 0x0600E51F RID: 58655 RVA: 0x00153273 File Offset: 0x00151473
		// (set) Token: 0x0600E520 RID: 58656 RVA: 0x0015328C File Offset: 0x0015148C
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

		// Token: 0x17003697 RID: 13975
		// (get) Token: 0x0600E521 RID: 58657 RVA: 0x001532BC File Offset: 0x001514BC
		// (set) Token: 0x0600E522 RID: 58658 RVA: 0x001532D5 File Offset: 0x001514D5
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

		// Token: 0x17003698 RID: 13976
		// (get) Token: 0x0600E523 RID: 58659 RVA: 0x00153305 File Offset: 0x00151505
		// (set) Token: 0x0600E524 RID: 58660 RVA: 0x0015331E File Offset: 0x0015151E
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

		// Token: 0x17003699 RID: 13977
		// (get) Token: 0x0600E525 RID: 58661 RVA: 0x0015334E File Offset: 0x0015154E
		// (set) Token: 0x0600E526 RID: 58662 RVA: 0x00153367 File Offset: 0x00151567
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

		// Token: 0x1700369A RID: 13978
		// (get) Token: 0x0600E527 RID: 58663 RVA: 0x00153397 File Offset: 0x00151597
		// (set) Token: 0x0600E528 RID: 58664 RVA: 0x001533B0 File Offset: 0x001515B0
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

		// Token: 0x1700369B RID: 13979
		// (get) Token: 0x0600E529 RID: 58665 RVA: 0x001533E0 File Offset: 0x001515E0
		// (set) Token: 0x0600E52A RID: 58666 RVA: 0x001533F9 File Offset: 0x001515F9
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

		// Token: 0x1700369C RID: 13980
		// (get) Token: 0x0600E52B RID: 58667 RVA: 0x00153429 File Offset: 0x00151629
		// (set) Token: 0x0600E52C RID: 58668 RVA: 0x00153442 File Offset: 0x00151642
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

		// Token: 0x1700369D RID: 13981
		// (get) Token: 0x0600E52D RID: 58669 RVA: 0x00153472 File Offset: 0x00151672
		// (set) Token: 0x0600E52E RID: 58670 RVA: 0x0015348B File Offset: 0x0015168B
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

		// Token: 0x1700369E RID: 13982
		// (get) Token: 0x0600E52F RID: 58671 RVA: 0x001534BB File Offset: 0x001516BB
		// (set) Token: 0x0600E530 RID: 58672 RVA: 0x001534D4 File Offset: 0x001516D4
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

		// Token: 0x1700369F RID: 13983
		// (get) Token: 0x0600E531 RID: 58673 RVA: 0x00153504 File Offset: 0x00151704
		// (set) Token: 0x0600E532 RID: 58674 RVA: 0x0015351D File Offset: 0x0015171D
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

		// Token: 0x170036A0 RID: 13984
		// (get) Token: 0x0600E533 RID: 58675 RVA: 0x0015354D File Offset: 0x0015174D
		// (set) Token: 0x0600E534 RID: 58676 RVA: 0x00153566 File Offset: 0x00151766
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

		// Token: 0x170036A1 RID: 13985
		// (get) Token: 0x0600E535 RID: 58677 RVA: 0x00153596 File Offset: 0x00151796
		// (set) Token: 0x0600E536 RID: 58678 RVA: 0x001535AF File Offset: 0x001517AF
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

		// Token: 0x170036A2 RID: 13986
		// (get) Token: 0x0600E537 RID: 58679 RVA: 0x001535DF File Offset: 0x001517DF
		// (set) Token: 0x0600E538 RID: 58680 RVA: 0x001535F8 File Offset: 0x001517F8
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

		// Token: 0x170036A3 RID: 13987
		// (get) Token: 0x0600E539 RID: 58681 RVA: 0x00153628 File Offset: 0x00151828
		// (set) Token: 0x0600E53A RID: 58682 RVA: 0x00153641 File Offset: 0x00151841
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

		// Token: 0x170036A4 RID: 13988
		// (get) Token: 0x0600E53B RID: 58683 RVA: 0x00153671 File Offset: 0x00151871
		// (set) Token: 0x0600E53C RID: 58684 RVA: 0x0015368A File Offset: 0x0015188A
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

		// Token: 0x170036A5 RID: 13989
		// (get) Token: 0x0600E53D RID: 58685 RVA: 0x001536BA File Offset: 0x001518BA
		// (set) Token: 0x0600E53E RID: 58686 RVA: 0x001536D3 File Offset: 0x001518D3
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

		// Token: 0x170036A6 RID: 13990
		// (get) Token: 0x0600E53F RID: 58687 RVA: 0x00153703 File Offset: 0x00151903
		// (set) Token: 0x0600E540 RID: 58688 RVA: 0x0015371C File Offset: 0x0015191C
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

		// Token: 0x170036A7 RID: 13991
		// (get) Token: 0x0600E541 RID: 58689 RVA: 0x0015374C File Offset: 0x0015194C
		// (set) Token: 0x0600E542 RID: 58690 RVA: 0x00153765 File Offset: 0x00151965
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

		// Token: 0x170036A8 RID: 13992
		// (get) Token: 0x0600E543 RID: 58691 RVA: 0x00153795 File Offset: 0x00151995
		// (set) Token: 0x0600E544 RID: 58692 RVA: 0x001537AE File Offset: 0x001519AE
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

		// Token: 0x170036A9 RID: 13993
		// (get) Token: 0x0600E545 RID: 58693 RVA: 0x001537DE File Offset: 0x001519DE
		// (set) Token: 0x0600E546 RID: 58694 RVA: 0x001537F7 File Offset: 0x001519F7
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

		// Token: 0x170036AA RID: 13994
		// (get) Token: 0x0600E547 RID: 58695 RVA: 0x00153827 File Offset: 0x00151A27
		// (set) Token: 0x0600E548 RID: 58696 RVA: 0x00153840 File Offset: 0x00151A40
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

		// Token: 0x170036AB RID: 13995
		// (get) Token: 0x0600E549 RID: 58697 RVA: 0x00153870 File Offset: 0x00151A70
		// (set) Token: 0x0600E54A RID: 58698 RVA: 0x00153889 File Offset: 0x00151A89
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

		// Token: 0x170036AC RID: 13996
		// (get) Token: 0x0600E54B RID: 58699 RVA: 0x001538B9 File Offset: 0x00151AB9
		// (set) Token: 0x0600E54C RID: 58700 RVA: 0x001538D2 File Offset: 0x00151AD2
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

		// Token: 0x170036AD RID: 13997
		// (get) Token: 0x0600E54D RID: 58701 RVA: 0x00153902 File Offset: 0x00151B02
		// (set) Token: 0x0600E54E RID: 58702 RVA: 0x0015391B File Offset: 0x00151B1B
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

		// Token: 0x170036AE RID: 13998
		// (get) Token: 0x0600E54F RID: 58703 RVA: 0x0015394B File Offset: 0x00151B4B
		// (set) Token: 0x0600E550 RID: 58704 RVA: 0x00153964 File Offset: 0x00151B64
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

		// Token: 0x170036AF RID: 13999
		// (get) Token: 0x0600E551 RID: 58705 RVA: 0x00153994 File Offset: 0x00151B94
		// (set) Token: 0x0600E552 RID: 58706 RVA: 0x001539AD File Offset: 0x00151BAD
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

		// Token: 0x170036B0 RID: 14000
		// (get) Token: 0x0600E553 RID: 58707 RVA: 0x001539DD File Offset: 0x00151BDD
		// (set) Token: 0x0600E554 RID: 58708 RVA: 0x001539F6 File Offset: 0x00151BF6
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

		// Token: 0x170036B1 RID: 14001
		// (get) Token: 0x0600E555 RID: 58709 RVA: 0x00153A26 File Offset: 0x00151C26
		// (set) Token: 0x0600E556 RID: 58710 RVA: 0x00153A3F File Offset: 0x00151C3F
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

		// Token: 0x170036B2 RID: 14002
		// (get) Token: 0x0600E557 RID: 58711 RVA: 0x00153A6F File Offset: 0x00151C6F
		// (set) Token: 0x0600E558 RID: 58712 RVA: 0x00153A88 File Offset: 0x00151C88
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

		// Token: 0x170036B3 RID: 14003
		// (get) Token: 0x0600E559 RID: 58713 RVA: 0x00153AB8 File Offset: 0x00151CB8
		// (set) Token: 0x0600E55A RID: 58714 RVA: 0x00153AD1 File Offset: 0x00151CD1
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

		// Token: 0x170036B4 RID: 14004
		// (get) Token: 0x0600E55B RID: 58715 RVA: 0x00153B01 File Offset: 0x00151D01
		// (set) Token: 0x0600E55C RID: 58716 RVA: 0x00153B1A File Offset: 0x00151D1A
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

		// Token: 0x170036B5 RID: 14005
		// (get) Token: 0x0600E55D RID: 58717 RVA: 0x00153B4A File Offset: 0x00151D4A
		// (set) Token: 0x0600E55E RID: 58718 RVA: 0x00153B5A File Offset: 0x00151D5A
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

		// Token: 0x170036B6 RID: 14006
		// (get) Token: 0x0600E55F RID: 58719 RVA: 0x00153B6B File Offset: 0x00151D6B
		// (set) Token: 0x0600E560 RID: 58720 RVA: 0x00153B7B File Offset: 0x00151D7B
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

		// Token: 0x170036B7 RID: 14007
		// (get) Token: 0x0600E561 RID: 58721 RVA: 0x00153B8C File Offset: 0x00151D8C
		// (set) Token: 0x0600E562 RID: 58722 RVA: 0x00153B9C File Offset: 0x00151D9C
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

		// Token: 0x170036B8 RID: 14008
		// (get) Token: 0x0600E563 RID: 58723 RVA: 0x00153BAD File Offset: 0x00151DAD
		// (set) Token: 0x0600E564 RID: 58724 RVA: 0x00153BBD File Offset: 0x00151DBD
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

		// Token: 0x170036B9 RID: 14009
		// (get) Token: 0x0600E565 RID: 58725 RVA: 0x00153BCE File Offset: 0x00151DCE
		// (set) Token: 0x0600E566 RID: 58726 RVA: 0x00153BDE File Offset: 0x00151DDE
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

		// Token: 0x170036BA RID: 14010
		// (get) Token: 0x0600E567 RID: 58727 RVA: 0x00153BEF File Offset: 0x00151DEF
		// (set) Token: 0x0600E568 RID: 58728 RVA: 0x00153BFF File Offset: 0x00151DFF
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

		// Token: 0x170036BB RID: 14011
		// (get) Token: 0x0600E569 RID: 58729 RVA: 0x00153C10 File Offset: 0x00151E10
		// (set) Token: 0x0600E56A RID: 58730 RVA: 0x00153C20 File Offset: 0x00151E20
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

		// Token: 0x170036BC RID: 14012
		// (get) Token: 0x0600E56B RID: 58731 RVA: 0x00153C31 File Offset: 0x00151E31
		// (set) Token: 0x0600E56C RID: 58732 RVA: 0x00153C45 File Offset: 0x00151E45
		[Nullable(0)]
		public unsafe TEnumAsByte<EBloomMethod> BloomMethod
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BloomMethod);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_BloomMethod) = value;
			}
		}

		// Token: 0x170036BD RID: 14013
		// (get) Token: 0x0600E56D RID: 58733 RVA: 0x00153C5A File Offset: 0x00151E5A
		// (set) Token: 0x0600E56E RID: 58734 RVA: 0x00153C6E File Offset: 0x00151E6E
		[Nullable(0)]
		public unsafe TEnumAsByte<EAutoExposureMethod> AutoExposureMethod
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AutoExposureMethod);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_AutoExposureMethod) = value;
			}
		}

		// Token: 0x170036BE RID: 14014
		// (get) Token: 0x0600E56F RID: 58735 RVA: 0x00153C83 File Offset: 0x00151E83
		// (set) Token: 0x0600E570 RID: 58736 RVA: 0x00153C93 File Offset: 0x00151E93
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

		// Token: 0x170036BF RID: 14015
		// (get) Token: 0x0600E571 RID: 58737 RVA: 0x00153CA4 File Offset: 0x00151EA4
		// (set) Token: 0x0600E572 RID: 58738 RVA: 0x00153CB4 File Offset: 0x00151EB4
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

		// Token: 0x170036C0 RID: 14016
		// (get) Token: 0x0600E573 RID: 58739 RVA: 0x00153CC5 File Offset: 0x00151EC5
		// (set) Token: 0x0600E574 RID: 58740 RVA: 0x00153CD9 File Offset: 0x00151ED9
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

		// Token: 0x170036C1 RID: 14017
		// (get) Token: 0x0600E575 RID: 58741 RVA: 0x00153CEE File Offset: 0x00151EEE
		// (set) Token: 0x0600E576 RID: 58742 RVA: 0x00153D02 File Offset: 0x00151F02
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

		// Token: 0x170036C2 RID: 14018
		// (get) Token: 0x0600E577 RID: 58743 RVA: 0x00153D17 File Offset: 0x00151F17
		// (set) Token: 0x0600E578 RID: 58744 RVA: 0x00153D2B File Offset: 0x00151F2B
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

		// Token: 0x170036C3 RID: 14019
		// (get) Token: 0x0600E579 RID: 58745 RVA: 0x00153D40 File Offset: 0x00151F40
		// (set) Token: 0x0600E57A RID: 58746 RVA: 0x00153D54 File Offset: 0x00151F54
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

		// Token: 0x170036C4 RID: 14020
		// (get) Token: 0x0600E57B RID: 58747 RVA: 0x00153D69 File Offset: 0x00151F69
		// (set) Token: 0x0600E57C RID: 58748 RVA: 0x00153D7D File Offset: 0x00151F7D
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

		// Token: 0x170036C5 RID: 14021
		// (get) Token: 0x0600E57D RID: 58749 RVA: 0x00153D92 File Offset: 0x00151F92
		// (set) Token: 0x0600E57E RID: 58750 RVA: 0x00153DA6 File Offset: 0x00151FA6
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

		// Token: 0x170036C6 RID: 14022
		// (get) Token: 0x0600E57F RID: 58751 RVA: 0x00153DBB File Offset: 0x00151FBB
		// (set) Token: 0x0600E580 RID: 58752 RVA: 0x00153DCF File Offset: 0x00151FCF
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

		// Token: 0x170036C7 RID: 14023
		// (get) Token: 0x0600E581 RID: 58753 RVA: 0x00153DE4 File Offset: 0x00151FE4
		// (set) Token: 0x0600E582 RID: 58754 RVA: 0x00153DF8 File Offset: 0x00151FF8
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

		// Token: 0x170036C8 RID: 14024
		// (get) Token: 0x0600E583 RID: 58755 RVA: 0x00153E0D File Offset: 0x0015200D
		// (set) Token: 0x0600E584 RID: 58756 RVA: 0x00153E21 File Offset: 0x00152021
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

		// Token: 0x170036C9 RID: 14025
		// (get) Token: 0x0600E585 RID: 58757 RVA: 0x00153E36 File Offset: 0x00152036
		// (set) Token: 0x0600E586 RID: 58758 RVA: 0x00153E4A File Offset: 0x0015204A
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

		// Token: 0x170036CA RID: 14026
		// (get) Token: 0x0600E587 RID: 58759 RVA: 0x00153E5F File Offset: 0x0015205F
		// (set) Token: 0x0600E588 RID: 58760 RVA: 0x00153E73 File Offset: 0x00152073
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

		// Token: 0x170036CB RID: 14027
		// (get) Token: 0x0600E589 RID: 58761 RVA: 0x00153E88 File Offset: 0x00152088
		// (set) Token: 0x0600E58A RID: 58762 RVA: 0x00153E9C File Offset: 0x0015209C
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

		// Token: 0x170036CC RID: 14028
		// (get) Token: 0x0600E58B RID: 58763 RVA: 0x00153EB1 File Offset: 0x001520B1
		// (set) Token: 0x0600E58C RID: 58764 RVA: 0x00153EC5 File Offset: 0x001520C5
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

		// Token: 0x170036CD RID: 14029
		// (get) Token: 0x0600E58D RID: 58765 RVA: 0x00153EDA File Offset: 0x001520DA
		// (set) Token: 0x0600E58E RID: 58766 RVA: 0x00153EEE File Offset: 0x001520EE
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

		// Token: 0x170036CE RID: 14030
		// (get) Token: 0x0600E58F RID: 58767 RVA: 0x00153F03 File Offset: 0x00152103
		// (set) Token: 0x0600E590 RID: 58768 RVA: 0x00153F17 File Offset: 0x00152117
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

		// Token: 0x170036CF RID: 14031
		// (get) Token: 0x0600E591 RID: 58769 RVA: 0x00153F2C File Offset: 0x0015212C
		// (set) Token: 0x0600E592 RID: 58770 RVA: 0x00153F40 File Offset: 0x00152140
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

		// Token: 0x170036D0 RID: 14032
		// (get) Token: 0x0600E593 RID: 58771 RVA: 0x00153F55 File Offset: 0x00152155
		// (set) Token: 0x0600E594 RID: 58772 RVA: 0x00153F69 File Offset: 0x00152169
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

		// Token: 0x170036D1 RID: 14033
		// (get) Token: 0x0600E595 RID: 58773 RVA: 0x00153F7E File Offset: 0x0015217E
		// (set) Token: 0x0600E596 RID: 58774 RVA: 0x00153F92 File Offset: 0x00152192
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

		// Token: 0x170036D2 RID: 14034
		// (get) Token: 0x0600E597 RID: 58775 RVA: 0x00153FA7 File Offset: 0x001521A7
		// (set) Token: 0x0600E598 RID: 58776 RVA: 0x00153FBB File Offset: 0x001521BB
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

		// Token: 0x170036D3 RID: 14035
		// (get) Token: 0x0600E599 RID: 58777 RVA: 0x00153FD0 File Offset: 0x001521D0
		// (set) Token: 0x0600E59A RID: 58778 RVA: 0x00153FE4 File Offset: 0x001521E4
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

		// Token: 0x170036D4 RID: 14036
		// (get) Token: 0x0600E59B RID: 58779 RVA: 0x00153FF9 File Offset: 0x001521F9
		// (set) Token: 0x0600E59C RID: 58780 RVA: 0x0015400D File Offset: 0x0015220D
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

		// Token: 0x170036D5 RID: 14037
		// (get) Token: 0x0600E59D RID: 58781 RVA: 0x00154022 File Offset: 0x00152222
		// (set) Token: 0x0600E59E RID: 58782 RVA: 0x00154036 File Offset: 0x00152236
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

		// Token: 0x170036D6 RID: 14038
		// (get) Token: 0x0600E59F RID: 58783 RVA: 0x0015404B File Offset: 0x0015224B
		// (set) Token: 0x0600E5A0 RID: 58784 RVA: 0x0015405B File Offset: 0x0015225B
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

		// Token: 0x170036D7 RID: 14039
		// (get) Token: 0x0600E5A1 RID: 58785 RVA: 0x0015406C File Offset: 0x0015226C
		// (set) Token: 0x0600E5A2 RID: 58786 RVA: 0x0015407C File Offset: 0x0015227C
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

		// Token: 0x170036D8 RID: 14040
		// (get) Token: 0x0600E5A3 RID: 58787 RVA: 0x0015408D File Offset: 0x0015228D
		// (set) Token: 0x0600E5A4 RID: 58788 RVA: 0x0015409D File Offset: 0x0015229D
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

		// Token: 0x170036D9 RID: 14041
		// (get) Token: 0x0600E5A5 RID: 58789 RVA: 0x001540AE File Offset: 0x001522AE
		// (set) Token: 0x0600E5A6 RID: 58790 RVA: 0x001540BE File Offset: 0x001522BE
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

		// Token: 0x170036DA RID: 14042
		// (get) Token: 0x0600E5A7 RID: 58791 RVA: 0x001540CF File Offset: 0x001522CF
		// (set) Token: 0x0600E5A8 RID: 58792 RVA: 0x001540DF File Offset: 0x001522DF
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

		// Token: 0x170036DB RID: 14043
		// (get) Token: 0x0600E5A9 RID: 58793 RVA: 0x001540F0 File Offset: 0x001522F0
		// (set) Token: 0x0600E5AA RID: 58794 RVA: 0x00154100 File Offset: 0x00152300
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

		// Token: 0x170036DC RID: 14044
		// (get) Token: 0x0600E5AB RID: 58795 RVA: 0x00154111 File Offset: 0x00152311
		// (set) Token: 0x0600E5AC RID: 58796 RVA: 0x00154121 File Offset: 0x00152321
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

		// Token: 0x170036DD RID: 14045
		// (get) Token: 0x0600E5AD RID: 58797 RVA: 0x00154132 File Offset: 0x00152332
		// (set) Token: 0x0600E5AE RID: 58798 RVA: 0x00154142 File Offset: 0x00152342
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

		// Token: 0x170036DE RID: 14046
		// (get) Token: 0x0600E5AF RID: 58799 RVA: 0x00154153 File Offset: 0x00152353
		// (set) Token: 0x0600E5B0 RID: 58800 RVA: 0x00154163 File Offset: 0x00152363
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

		// Token: 0x170036DF RID: 14047
		// (get) Token: 0x0600E5B1 RID: 58801 RVA: 0x00154174 File Offset: 0x00152374
		// (set) Token: 0x0600E5B2 RID: 58802 RVA: 0x00154184 File Offset: 0x00152384
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

		// Token: 0x170036E0 RID: 14048
		// (get) Token: 0x0600E5B3 RID: 58803 RVA: 0x00154195 File Offset: 0x00152395
		// (set) Token: 0x0600E5B4 RID: 58804 RVA: 0x001541A9 File Offset: 0x001523A9
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

		// Token: 0x170036E1 RID: 14049
		// (get) Token: 0x0600E5B5 RID: 58805 RVA: 0x001541BE File Offset: 0x001523BE
		// (set) Token: 0x0600E5B6 RID: 58806 RVA: 0x001541D2 File Offset: 0x001523D2
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

		// Token: 0x170036E2 RID: 14050
		// (get) Token: 0x0600E5B7 RID: 58807 RVA: 0x001541E7 File Offset: 0x001523E7
		// (set) Token: 0x0600E5B8 RID: 58808 RVA: 0x001541F7 File Offset: 0x001523F7
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

		// Token: 0x170036E3 RID: 14051
		// (get) Token: 0x0600E5B9 RID: 58809 RVA: 0x00154208 File Offset: 0x00152408
		// (set) Token: 0x0600E5BA RID: 58810 RVA: 0x00154218 File Offset: 0x00152418
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

		// Token: 0x170036E4 RID: 14052
		// (get) Token: 0x0600E5BB RID: 58811 RVA: 0x00154229 File Offset: 0x00152429
		// (set) Token: 0x0600E5BC RID: 58812 RVA: 0x00154239 File Offset: 0x00152439
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

		// Token: 0x170036E5 RID: 14053
		// (get) Token: 0x0600E5BD RID: 58813 RVA: 0x0015424A File Offset: 0x0015244A
		// (set) Token: 0x0600E5BE RID: 58814 RVA: 0x0015425E File Offset: 0x0015245E
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

		// Token: 0x170036E6 RID: 14054
		// (get) Token: 0x0600E5BF RID: 58815 RVA: 0x00154273 File Offset: 0x00152473
		// (set) Token: 0x0600E5C0 RID: 58816 RVA: 0x00154287 File Offset: 0x00152487
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

		// Token: 0x170036E7 RID: 14055
		// (get) Token: 0x0600E5C1 RID: 58817 RVA: 0x0015429C File Offset: 0x0015249C
		// (set) Token: 0x0600E5C2 RID: 58818 RVA: 0x001542B0 File Offset: 0x001524B0
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

		// Token: 0x170036E8 RID: 14056
		// (get) Token: 0x0600E5C3 RID: 58819 RVA: 0x001542C5 File Offset: 0x001524C5
		// (set) Token: 0x0600E5C4 RID: 58820 RVA: 0x001542D5 File Offset: 0x001524D5
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

		// Token: 0x170036E9 RID: 14057
		// (get) Token: 0x0600E5C5 RID: 58821 RVA: 0x001542E6 File Offset: 0x001524E6
		// (set) Token: 0x0600E5C6 RID: 58822 RVA: 0x001542F6 File Offset: 0x001524F6
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

		// Token: 0x170036EA RID: 14058
		// (get) Token: 0x0600E5C7 RID: 58823 RVA: 0x00154307 File Offset: 0x00152507
		// (set) Token: 0x0600E5C8 RID: 58824 RVA: 0x00154317 File Offset: 0x00152517
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

		// Token: 0x170036EB RID: 14059
		// (get) Token: 0x0600E5C9 RID: 58825 RVA: 0x00154328 File Offset: 0x00152528
		// (set) Token: 0x0600E5CA RID: 58826 RVA: 0x00154338 File Offset: 0x00152538
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

		// Token: 0x170036EC RID: 14060
		// (get) Token: 0x0600E5CB RID: 58827 RVA: 0x00154349 File Offset: 0x00152549
		// (set) Token: 0x0600E5CC RID: 58828 RVA: 0x0015435D File Offset: 0x0015255D
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

		// Token: 0x170036ED RID: 14061
		// (get) Token: 0x0600E5CD RID: 58829 RVA: 0x00154372 File Offset: 0x00152572
		// (set) Token: 0x0600E5CE RID: 58830 RVA: 0x00154382 File Offset: 0x00152582
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

		// Token: 0x170036EE RID: 14062
		// (get) Token: 0x0600E5CF RID: 58831 RVA: 0x00154393 File Offset: 0x00152593
		// (set) Token: 0x0600E5D0 RID: 58832 RVA: 0x001543A3 File Offset: 0x001525A3
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

		// Token: 0x170036EF RID: 14063
		// (get) Token: 0x0600E5D1 RID: 58833 RVA: 0x001543B4 File Offset: 0x001525B4
		// (set) Token: 0x0600E5D2 RID: 58834 RVA: 0x001543C8 File Offset: 0x001525C8
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

		// Token: 0x170036F0 RID: 14064
		// (get) Token: 0x0600E5D3 RID: 58835 RVA: 0x001543DD File Offset: 0x001525DD
		// (set) Token: 0x0600E5D4 RID: 58836 RVA: 0x001543ED File Offset: 0x001525ED
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

		// Token: 0x170036F1 RID: 14065
		// (get) Token: 0x0600E5D5 RID: 58837 RVA: 0x001543FE File Offset: 0x001525FE
		// (set) Token: 0x0600E5D6 RID: 58838 RVA: 0x0015440E File Offset: 0x0015260E
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

		// Token: 0x170036F2 RID: 14066
		// (get) Token: 0x0600E5D7 RID: 58839 RVA: 0x0015441F File Offset: 0x0015261F
		// (set) Token: 0x0600E5D8 RID: 58840 RVA: 0x00154433 File Offset: 0x00152633
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

		// Token: 0x170036F3 RID: 14067
		// (get) Token: 0x0600E5D9 RID: 58841 RVA: 0x00154448 File Offset: 0x00152648
		// (set) Token: 0x0600E5DA RID: 58842 RVA: 0x0015445C File Offset: 0x0015265C
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

		// Token: 0x170036F4 RID: 14068
		// (get) Token: 0x0600E5DB RID: 58843 RVA: 0x00154471 File Offset: 0x00152671
		// (set) Token: 0x0600E5DC RID: 58844 RVA: 0x00154481 File Offset: 0x00152681
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

		// Token: 0x170036F5 RID: 14069
		// (get) Token: 0x0600E5DD RID: 58845 RVA: 0x00154492 File Offset: 0x00152692
		// (set) Token: 0x0600E5DE RID: 58846 RVA: 0x001544A2 File Offset: 0x001526A2
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

		// Token: 0x170036F6 RID: 14070
		// (get) Token: 0x0600E5DF RID: 58847 RVA: 0x001544B3 File Offset: 0x001526B3
		// (set) Token: 0x0600E5E0 RID: 58848 RVA: 0x001544C3 File Offset: 0x001526C3
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

		// Token: 0x170036F7 RID: 14071
		// (get) Token: 0x0600E5E1 RID: 58849 RVA: 0x001544D4 File Offset: 0x001526D4
		// (set) Token: 0x0600E5E2 RID: 58850 RVA: 0x001544E4 File Offset: 0x001526E4
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

		// Token: 0x170036F8 RID: 14072
		// (get) Token: 0x0600E5E3 RID: 58851 RVA: 0x001544F5 File Offset: 0x001526F5
		// (set) Token: 0x0600E5E4 RID: 58852 RVA: 0x00154509 File Offset: 0x00152709
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

		// Token: 0x170036F9 RID: 14073
		// (get) Token: 0x0600E5E5 RID: 58853 RVA: 0x0015451E File Offset: 0x0015271E
		// (set) Token: 0x0600E5E6 RID: 58854 RVA: 0x00154532 File Offset: 0x00152732
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

		// Token: 0x170036FA RID: 14074
		// (get) Token: 0x0600E5E7 RID: 58855 RVA: 0x00154547 File Offset: 0x00152747
		// (set) Token: 0x0600E5E8 RID: 58856 RVA: 0x00154557 File Offset: 0x00152757
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

		// Token: 0x170036FB RID: 14075
		// (get) Token: 0x0600E5E9 RID: 58857 RVA: 0x00154568 File Offset: 0x00152768
		// (set) Token: 0x0600E5EA RID: 58858 RVA: 0x00154578 File Offset: 0x00152778
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

		// Token: 0x170036FC RID: 14076
		// (get) Token: 0x0600E5EB RID: 58859 RVA: 0x00154589 File Offset: 0x00152789
		// (set) Token: 0x0600E5EC RID: 58860 RVA: 0x001545A2 File Offset: 0x001527A2
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

		// Token: 0x170036FD RID: 14077
		// (get) Token: 0x0600E5ED RID: 58861 RVA: 0x001545D2 File Offset: 0x001527D2
		// (set) Token: 0x0600E5EE RID: 58862 RVA: 0x001545E2 File Offset: 0x001527E2
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

		// Token: 0x170036FE RID: 14078
		// (get) Token: 0x0600E5EF RID: 58863 RVA: 0x001545F3 File Offset: 0x001527F3
		// (set) Token: 0x0600E5F0 RID: 58864 RVA: 0x00154603 File Offset: 0x00152803
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

		// Token: 0x170036FF RID: 14079
		// (get) Token: 0x0600E5F1 RID: 58865 RVA: 0x00154614 File Offset: 0x00152814
		// (set) Token: 0x0600E5F2 RID: 58866 RVA: 0x00154624 File Offset: 0x00152824
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

		// Token: 0x17003700 RID: 14080
		// (get) Token: 0x0600E5F3 RID: 58867 RVA: 0x00154635 File Offset: 0x00152835
		// (set) Token: 0x0600E5F4 RID: 58868 RVA: 0x00154645 File Offset: 0x00152845
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

		// Token: 0x17003701 RID: 14081
		// (get) Token: 0x0600E5F5 RID: 58869 RVA: 0x00154656 File Offset: 0x00152856
		// (set) Token: 0x0600E5F6 RID: 58870 RVA: 0x00154666 File Offset: 0x00152866
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

		// Token: 0x17003702 RID: 14082
		// (get) Token: 0x0600E5F7 RID: 58871 RVA: 0x00154677 File Offset: 0x00152877
		// (set) Token: 0x0600E5F8 RID: 58872 RVA: 0x00154687 File Offset: 0x00152887
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

		// Token: 0x17003703 RID: 14083
		// (get) Token: 0x0600E5F9 RID: 58873 RVA: 0x00154698 File Offset: 0x00152898
		// (set) Token: 0x0600E5FA RID: 58874 RVA: 0x001546A8 File Offset: 0x001528A8
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

		// Token: 0x17003704 RID: 14084
		// (get) Token: 0x0600E5FB RID: 58875 RVA: 0x001546B9 File Offset: 0x001528B9
		// (set) Token: 0x0600E5FC RID: 58876 RVA: 0x001546C9 File Offset: 0x001528C9
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

		// Token: 0x17003705 RID: 14085
		// (get) Token: 0x0600E5FD RID: 58877 RVA: 0x001546DA File Offset: 0x001528DA
		// (set) Token: 0x0600E5FE RID: 58878 RVA: 0x001546F3 File Offset: 0x001528F3
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

		// Token: 0x17003706 RID: 14086
		// (get) Token: 0x0600E5FF RID: 58879 RVA: 0x00154723 File Offset: 0x00152923
		// (set) Token: 0x0600E600 RID: 58880 RVA: 0x00154733 File Offset: 0x00152933
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

		// Token: 0x17003707 RID: 14087
		// (get) Token: 0x0600E601 RID: 58881 RVA: 0x00154744 File Offset: 0x00152944
		// (set) Token: 0x0600E602 RID: 58882 RVA: 0x00154754 File Offset: 0x00152954
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

		// Token: 0x17003708 RID: 14088
		// (get) Token: 0x0600E603 RID: 58883 RVA: 0x00154765 File Offset: 0x00152965
		// (set) Token: 0x0600E604 RID: 58884 RVA: 0x0015477E File Offset: 0x0015297E
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

		// Token: 0x17003709 RID: 14089
		// (get) Token: 0x0600E605 RID: 58885 RVA: 0x001547AE File Offset: 0x001529AE
		// (set) Token: 0x0600E606 RID: 58886 RVA: 0x001547C2 File Offset: 0x001529C2
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

		// Token: 0x1700370A RID: 14090
		// (get) Token: 0x0600E607 RID: 58887 RVA: 0x001547D7 File Offset: 0x001529D7
		// (set) Token: 0x0600E608 RID: 58888 RVA: 0x001547E7 File Offset: 0x001529E7
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

		// Token: 0x1700370B RID: 14091
		// (get) Token: 0x0600E609 RID: 58889 RVA: 0x001547F8 File Offset: 0x001529F8
		// (set) Token: 0x0600E60A RID: 58890 RVA: 0x00154808 File Offset: 0x00152A08
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

		// Token: 0x1700370C RID: 14092
		// (get) Token: 0x0600E60B RID: 58891 RVA: 0x00154819 File Offset: 0x00152A19
		// (set) Token: 0x0600E60C RID: 58892 RVA: 0x0015482D File Offset: 0x00152A2D
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

		// Token: 0x1700370D RID: 14093
		// (get) Token: 0x0600E60D RID: 58893 RVA: 0x00154842 File Offset: 0x00152A42
		// (set) Token: 0x0600E60E RID: 58894 RVA: 0x00154852 File Offset: 0x00152A52
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

		// Token: 0x1700370E RID: 14094
		// (get) Token: 0x0600E60F RID: 58895 RVA: 0x00154863 File Offset: 0x00152A63
		// (set) Token: 0x0600E610 RID: 58896 RVA: 0x00154873 File Offset: 0x00152A73
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

		// Token: 0x1700370F RID: 14095
		// (get) Token: 0x0600E611 RID: 58897 RVA: 0x00154884 File Offset: 0x00152A84
		// (set) Token: 0x0600E612 RID: 58898 RVA: 0x00154898 File Offset: 0x00152A98
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

		// Token: 0x17003710 RID: 14096
		// (get) Token: 0x0600E613 RID: 58899 RVA: 0x001548AD File Offset: 0x00152AAD
		// (set) Token: 0x0600E614 RID: 58900 RVA: 0x001548BD File Offset: 0x00152ABD
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

		// Token: 0x17003711 RID: 14097
		// (get) Token: 0x0600E615 RID: 58901 RVA: 0x001548CE File Offset: 0x00152ACE
		// (set) Token: 0x0600E616 RID: 58902 RVA: 0x001548DE File Offset: 0x00152ADE
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

		// Token: 0x17003712 RID: 14098
		// (get) Token: 0x0600E617 RID: 58903 RVA: 0x001548EF File Offset: 0x00152AEF
		// (set) Token: 0x0600E618 RID: 58904 RVA: 0x001548FF File Offset: 0x00152AFF
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

		// Token: 0x17003713 RID: 14099
		// (get) Token: 0x0600E619 RID: 58905 RVA: 0x00154910 File Offset: 0x00152B10
		// (set) Token: 0x0600E61A RID: 58906 RVA: 0x00154920 File Offset: 0x00152B20
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

		// Token: 0x17003714 RID: 14100
		// (get) Token: 0x0600E61B RID: 58907 RVA: 0x00154931 File Offset: 0x00152B31
		// (set) Token: 0x0600E61C RID: 58908 RVA: 0x0015494A File Offset: 0x00152B4A
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

		// Token: 0x17003715 RID: 14101
		// (get) Token: 0x0600E61D RID: 58909 RVA: 0x0015497A File Offset: 0x00152B7A
		// (set) Token: 0x0600E61E RID: 58910 RVA: 0x0015498A File Offset: 0x00152B8A
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

		// Token: 0x17003716 RID: 14102
		// (get) Token: 0x0600E61F RID: 58911 RVA: 0x0015499B File Offset: 0x00152B9B
		// (set) Token: 0x0600E620 RID: 58912 RVA: 0x001549AB File Offset: 0x00152BAB
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

		// Token: 0x17003717 RID: 14103
		// (get) Token: 0x0600E621 RID: 58913 RVA: 0x001549BC File Offset: 0x00152BBC
		// (set) Token: 0x0600E622 RID: 58914 RVA: 0x001549CC File Offset: 0x00152BCC
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

		// Token: 0x17003718 RID: 14104
		// (get) Token: 0x0600E623 RID: 58915 RVA: 0x001549DD File Offset: 0x00152BDD
		// (set) Token: 0x0600E624 RID: 58916 RVA: 0x001549F1 File Offset: 0x00152BF1
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

		// Token: 0x17003719 RID: 14105
		// (get) Token: 0x0600E625 RID: 58917 RVA: 0x00154A06 File Offset: 0x00152C06
		// (set) Token: 0x0600E626 RID: 58918 RVA: 0x00154A16 File Offset: 0x00152C16
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

		// Token: 0x1700371A RID: 14106
		// (get) Token: 0x0600E627 RID: 58919 RVA: 0x00154A27 File Offset: 0x00152C27
		// (set) Token: 0x0600E628 RID: 58920 RVA: 0x00154A37 File Offset: 0x00152C37
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

		// Token: 0x1700371B RID: 14107
		// (get) Token: 0x0600E629 RID: 58921 RVA: 0x00154A48 File Offset: 0x00152C48
		// (set) Token: 0x0600E62A RID: 58922 RVA: 0x00154A58 File Offset: 0x00152C58
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

		// Token: 0x1700371C RID: 14108
		// (get) Token: 0x0600E62B RID: 58923 RVA: 0x00154A69 File Offset: 0x00152C69
		// (set) Token: 0x0600E62C RID: 58924 RVA: 0x00154A79 File Offset: 0x00152C79
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

		// Token: 0x1700371D RID: 14109
		// (get) Token: 0x0600E62D RID: 58925 RVA: 0x00154A8A File Offset: 0x00152C8A
		// (set) Token: 0x0600E62E RID: 58926 RVA: 0x00154A9A File Offset: 0x00152C9A
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

		// Token: 0x1700371E RID: 14110
		// (get) Token: 0x0600E62F RID: 58927 RVA: 0x00154AAB File Offset: 0x00152CAB
		// (set) Token: 0x0600E630 RID: 58928 RVA: 0x00154ABB File Offset: 0x00152CBB
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

		// Token: 0x1700371F RID: 14111
		// (get) Token: 0x0600E631 RID: 58929 RVA: 0x00154ACC File Offset: 0x00152CCC
		// (set) Token: 0x0600E632 RID: 58930 RVA: 0x00154ADC File Offset: 0x00152CDC
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

		// Token: 0x17003720 RID: 14112
		// (get) Token: 0x0600E633 RID: 58931 RVA: 0x00154AED File Offset: 0x00152CED
		// (set) Token: 0x0600E634 RID: 58932 RVA: 0x00154AFD File Offset: 0x00152CFD
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

		// Token: 0x17003721 RID: 14113
		// (get) Token: 0x0600E635 RID: 58933 RVA: 0x00154B0E File Offset: 0x00152D0E
		// (set) Token: 0x0600E636 RID: 58934 RVA: 0x00154B1E File Offset: 0x00152D1E
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

		// Token: 0x17003722 RID: 14114
		// (get) Token: 0x0600E637 RID: 58935 RVA: 0x00154B2F File Offset: 0x00152D2F
		// (set) Token: 0x0600E638 RID: 58936 RVA: 0x00154B3F File Offset: 0x00152D3F
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

		// Token: 0x17003723 RID: 14115
		// (get) Token: 0x0600E639 RID: 58937 RVA: 0x00154B50 File Offset: 0x00152D50
		// (set) Token: 0x0600E63A RID: 58938 RVA: 0x00154B60 File Offset: 0x00152D60
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

		// Token: 0x17003724 RID: 14116
		// (get) Token: 0x0600E63B RID: 58939 RVA: 0x00154B71 File Offset: 0x00152D71
		// (set) Token: 0x0600E63C RID: 58940 RVA: 0x00154B85 File Offset: 0x00152D85
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

		// Token: 0x17003725 RID: 14117
		// (get) Token: 0x0600E63D RID: 58941 RVA: 0x00154B9A File Offset: 0x00152D9A
		// (set) Token: 0x0600E63E RID: 58942 RVA: 0x00154BAE File Offset: 0x00152DAE
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

		// Token: 0x17003726 RID: 14118
		// (get) Token: 0x0600E63F RID: 58943 RVA: 0x00154BC3 File Offset: 0x00152DC3
		// (set) Token: 0x0600E640 RID: 58944 RVA: 0x00154BD3 File Offset: 0x00152DD3
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

		// Token: 0x17003727 RID: 14119
		// (get) Token: 0x0600E641 RID: 58945 RVA: 0x00154BE4 File Offset: 0x00152DE4
		// (set) Token: 0x0600E642 RID: 58946 RVA: 0x00154BF8 File Offset: 0x00152DF8
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

		// Token: 0x17003728 RID: 14120
		// (get) Token: 0x0600E643 RID: 58947 RVA: 0x00154C0D File Offset: 0x00152E0D
		// (set) Token: 0x0600E644 RID: 58948 RVA: 0x00154C1D File Offset: 0x00152E1D
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

		// Token: 0x17003729 RID: 14121
		// (get) Token: 0x0600E645 RID: 58949 RVA: 0x00154C2E File Offset: 0x00152E2E
		// (set) Token: 0x0600E646 RID: 58950 RVA: 0x00154C3E File Offset: 0x00152E3E
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

		// Token: 0x1700372A RID: 14122
		// (get) Token: 0x0600E647 RID: 58951 RVA: 0x00154C4F File Offset: 0x00152E4F
		// (set) Token: 0x0600E648 RID: 58952 RVA: 0x00154C5F File Offset: 0x00152E5F
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

		// Token: 0x1700372B RID: 14123
		// (get) Token: 0x0600E649 RID: 58953 RVA: 0x00154C70 File Offset: 0x00152E70
		// (set) Token: 0x0600E64A RID: 58954 RVA: 0x00154C80 File Offset: 0x00152E80
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

		// Token: 0x1700372C RID: 14124
		// (get) Token: 0x0600E64B RID: 58955 RVA: 0x00154C91 File Offset: 0x00152E91
		// (set) Token: 0x0600E64C RID: 58956 RVA: 0x00154CA1 File Offset: 0x00152EA1
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

		// Token: 0x1700372D RID: 14125
		// (get) Token: 0x0600E64D RID: 58957 RVA: 0x00154CB2 File Offset: 0x00152EB2
		// (set) Token: 0x0600E64E RID: 58958 RVA: 0x00154CC6 File Offset: 0x00152EC6
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

		// Token: 0x1700372E RID: 14126
		// (get) Token: 0x0600E64F RID: 58959 RVA: 0x00154CDB File Offset: 0x00152EDB
		// (set) Token: 0x0600E650 RID: 58960 RVA: 0x00154CEF File Offset: 0x00152EEF
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

		// Token: 0x1700372F RID: 14127
		// (get) Token: 0x0600E651 RID: 58961 RVA: 0x00154D04 File Offset: 0x00152F04
		// (set) Token: 0x0600E652 RID: 58962 RVA: 0x00154D18 File Offset: 0x00152F18
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

		// Token: 0x17003730 RID: 14128
		// (get) Token: 0x0600E653 RID: 58963 RVA: 0x00154D2D File Offset: 0x00152F2D
		// (set) Token: 0x0600E654 RID: 58964 RVA: 0x00154D3D File Offset: 0x00152F3D
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

		// Token: 0x17003731 RID: 14129
		// (get) Token: 0x0600E655 RID: 58965 RVA: 0x00154D4E File Offset: 0x00152F4E
		// (set) Token: 0x0600E656 RID: 58966 RVA: 0x00154D5E File Offset: 0x00152F5E
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

		// Token: 0x17003732 RID: 14130
		// (get) Token: 0x0600E657 RID: 58967 RVA: 0x00154D6F File Offset: 0x00152F6F
		// (set) Token: 0x0600E658 RID: 58968 RVA: 0x00154D7F File Offset: 0x00152F7F
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

		// Token: 0x17003733 RID: 14131
		// (get) Token: 0x0600E659 RID: 58969 RVA: 0x00154D90 File Offset: 0x00152F90
		// (set) Token: 0x0600E65A RID: 58970 RVA: 0x00154DA0 File Offset: 0x00152FA0
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

		// Token: 0x17003734 RID: 14132
		// (get) Token: 0x0600E65B RID: 58971 RVA: 0x00154DB1 File Offset: 0x00152FB1
		// (set) Token: 0x0600E65C RID: 58972 RVA: 0x00154DC1 File Offset: 0x00152FC1
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

		// Token: 0x17003735 RID: 14133
		// (get) Token: 0x0600E65D RID: 58973 RVA: 0x00154DD2 File Offset: 0x00152FD2
		// (set) Token: 0x0600E65E RID: 58974 RVA: 0x00154DE2 File Offset: 0x00152FE2
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

		// Token: 0x17003736 RID: 14134
		// (get) Token: 0x0600E65F RID: 58975 RVA: 0x00154DF3 File Offset: 0x00152FF3
		// (set) Token: 0x0600E660 RID: 58976 RVA: 0x00154E03 File Offset: 0x00153003
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

		// Token: 0x17003737 RID: 14135
		// (get) Token: 0x0600E661 RID: 58977 RVA: 0x00154E14 File Offset: 0x00153014
		// (set) Token: 0x0600E662 RID: 58978 RVA: 0x00154E24 File Offset: 0x00153024
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

		// Token: 0x17003738 RID: 14136
		// (get) Token: 0x0600E663 RID: 58979 RVA: 0x00154E35 File Offset: 0x00153035
		// (set) Token: 0x0600E664 RID: 58980 RVA: 0x00154E45 File Offset: 0x00153045
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

		// Token: 0x17003739 RID: 14137
		// (get) Token: 0x0600E665 RID: 58981 RVA: 0x00154E56 File Offset: 0x00153056
		// (set) Token: 0x0600E666 RID: 58982 RVA: 0x00154E66 File Offset: 0x00153066
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

		// Token: 0x1700373A RID: 14138
		// (get) Token: 0x0600E667 RID: 58983 RVA: 0x00154E77 File Offset: 0x00153077
		// (set) Token: 0x0600E668 RID: 58984 RVA: 0x00154E87 File Offset: 0x00153087
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

		// Token: 0x1700373B RID: 14139
		// (get) Token: 0x0600E669 RID: 58985 RVA: 0x00154E98 File Offset: 0x00153098
		// (set) Token: 0x0600E66A RID: 58986 RVA: 0x00154EAC File Offset: 0x001530AC
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

		// Token: 0x1700373C RID: 14140
		// (get) Token: 0x0600E66B RID: 58987 RVA: 0x00154EC1 File Offset: 0x001530C1
		// (set) Token: 0x0600E66C RID: 58988 RVA: 0x00154ED1 File Offset: 0x001530D1
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

		// Token: 0x1700373D RID: 14141
		// (get) Token: 0x0600E66D RID: 58989 RVA: 0x00154EE2 File Offset: 0x001530E2
		// (set) Token: 0x0600E66E RID: 58990 RVA: 0x00154EF2 File Offset: 0x001530F2
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

		// Token: 0x1700373E RID: 14142
		// (get) Token: 0x0600E66F RID: 58991 RVA: 0x00154F03 File Offset: 0x00153103
		// (set) Token: 0x0600E670 RID: 58992 RVA: 0x00154F13 File Offset: 0x00153113
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

		// Token: 0x1700373F RID: 14143
		// (get) Token: 0x0600E671 RID: 58993 RVA: 0x00154F24 File Offset: 0x00153124
		// (set) Token: 0x0600E672 RID: 58994 RVA: 0x00154F38 File Offset: 0x00153138
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

		// Token: 0x17003740 RID: 14144
		// (get) Token: 0x0600E673 RID: 58995 RVA: 0x00154F4D File Offset: 0x0015314D
		// (set) Token: 0x0600E674 RID: 58996 RVA: 0x00154F5D File Offset: 0x0015315D
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

		// Token: 0x17003741 RID: 14145
		// (get) Token: 0x0600E675 RID: 58997 RVA: 0x00154F6E File Offset: 0x0015316E
		// (set) Token: 0x0600E676 RID: 58998 RVA: 0x00154F7E File Offset: 0x0015317E
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

		// Token: 0x17003742 RID: 14146
		// (get) Token: 0x0600E677 RID: 58999 RVA: 0x00154F8F File Offset: 0x0015318F
		// (set) Token: 0x0600E678 RID: 59000 RVA: 0x00154F9F File Offset: 0x0015319F
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

		// Token: 0x17003743 RID: 14147
		// (get) Token: 0x0600E679 RID: 59001 RVA: 0x00154FB0 File Offset: 0x001531B0
		// (set) Token: 0x0600E67A RID: 59002 RVA: 0x00154FC0 File Offset: 0x001531C0
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

		// Token: 0x17003744 RID: 14148
		// (get) Token: 0x0600E67B RID: 59003 RVA: 0x00154FD1 File Offset: 0x001531D1
		// (set) Token: 0x0600E67C RID: 59004 RVA: 0x00154FE1 File Offset: 0x001531E1
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

		// Token: 0x17003745 RID: 14149
		// (get) Token: 0x0600E67D RID: 59005 RVA: 0x00154FF2 File Offset: 0x001531F2
		// (set) Token: 0x0600E67E RID: 59006 RVA: 0x00155002 File Offset: 0x00153202
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

		// Token: 0x17003746 RID: 14150
		// (get) Token: 0x0600E67F RID: 59007 RVA: 0x00155013 File Offset: 0x00153213
		// (set) Token: 0x0600E680 RID: 59008 RVA: 0x00155023 File Offset: 0x00153223
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

		// Token: 0x17003747 RID: 14151
		// (get) Token: 0x0600E681 RID: 59009 RVA: 0x00155034 File Offset: 0x00153234
		// (set) Token: 0x0600E682 RID: 59010 RVA: 0x0015504D File Offset: 0x0015324D
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

		// Token: 0x17003748 RID: 14152
		// (get) Token: 0x0600E683 RID: 59011 RVA: 0x0015507D File Offset: 0x0015327D
		// (set) Token: 0x0600E684 RID: 59012 RVA: 0x00155096 File Offset: 0x00153296
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

		// Token: 0x17003749 RID: 14153
		// (get) Token: 0x0600E685 RID: 59013 RVA: 0x001550C6 File Offset: 0x001532C6
		// (set) Token: 0x0600E686 RID: 59014 RVA: 0x001550DF File Offset: 0x001532DF
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

		// Token: 0x1700374A RID: 14154
		// (get) Token: 0x0600E687 RID: 59015 RVA: 0x0015510F File Offset: 0x0015330F
		// (set) Token: 0x0600E688 RID: 59016 RVA: 0x0015511F File Offset: 0x0015331F
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

		// Token: 0x1700374B RID: 14155
		// (get) Token: 0x0600E689 RID: 59017 RVA: 0x00155130 File Offset: 0x00153330
		// (set) Token: 0x0600E68A RID: 59018 RVA: 0x00155140 File Offset: 0x00153340
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

		// Token: 0x1700374C RID: 14156
		// (get) Token: 0x0600E68B RID: 59019 RVA: 0x00155151 File Offset: 0x00153351
		// (set) Token: 0x0600E68C RID: 59020 RVA: 0x00155165 File Offset: 0x00153365
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

		// Token: 0x1700374D RID: 14157
		// (get) Token: 0x0600E68D RID: 59021 RVA: 0x0015517A File Offset: 0x0015337A
		// (set) Token: 0x0600E68E RID: 59022 RVA: 0x0015518A File Offset: 0x0015338A
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

		// Token: 0x1700374E RID: 14158
		// (get) Token: 0x0600E68F RID: 59023 RVA: 0x0015519B File Offset: 0x0015339B
		// (set) Token: 0x0600E690 RID: 59024 RVA: 0x001551AB File Offset: 0x001533AB
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

		// Token: 0x1700374F RID: 14159
		// (get) Token: 0x0600E691 RID: 59025 RVA: 0x001551BC File Offset: 0x001533BC
		// (set) Token: 0x0600E692 RID: 59026 RVA: 0x001551CC File Offset: 0x001533CC
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

		// Token: 0x17003750 RID: 14160
		// (get) Token: 0x0600E693 RID: 59027 RVA: 0x001551DD File Offset: 0x001533DD
		// (set) Token: 0x0600E694 RID: 59028 RVA: 0x001551ED File Offset: 0x001533ED
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

		// Token: 0x17003751 RID: 14161
		// (get) Token: 0x0600E695 RID: 59029 RVA: 0x001551FE File Offset: 0x001533FE
		// (set) Token: 0x0600E696 RID: 59030 RVA: 0x00155212 File Offset: 0x00153412
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

		// Token: 0x17003752 RID: 14162
		// (get) Token: 0x0600E697 RID: 59031 RVA: 0x00155227 File Offset: 0x00153427
		// (set) Token: 0x0600E698 RID: 59032 RVA: 0x0015523B File Offset: 0x0015343B
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

		// Token: 0x17003753 RID: 14163
		// (get) Token: 0x0600E699 RID: 59033 RVA: 0x00155250 File Offset: 0x00153450
		// (set) Token: 0x0600E69A RID: 59034 RVA: 0x00155260 File Offset: 0x00153460
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

		// Token: 0x17003754 RID: 14164
		// (get) Token: 0x0600E69B RID: 59035 RVA: 0x00155271 File Offset: 0x00153471
		// (set) Token: 0x0600E69C RID: 59036 RVA: 0x00155285 File Offset: 0x00153485
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

		// Token: 0x17003755 RID: 14165
		// (get) Token: 0x0600E69D RID: 59037 RVA: 0x0015529A File Offset: 0x0015349A
		// (set) Token: 0x0600E69E RID: 59038 RVA: 0x001552AA File Offset: 0x001534AA
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

		// Token: 0x17003756 RID: 14166
		// (get) Token: 0x0600E69F RID: 59039 RVA: 0x001552BB File Offset: 0x001534BB
		// (set) Token: 0x0600E6A0 RID: 59040 RVA: 0x001552CB File Offset: 0x001534CB
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

		// Token: 0x17003757 RID: 14167
		// (get) Token: 0x0600E6A1 RID: 59041 RVA: 0x001552DC File Offset: 0x001534DC
		// (set) Token: 0x0600E6A2 RID: 59042 RVA: 0x001552F0 File Offset: 0x001534F0
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

		// Token: 0x17003758 RID: 14168
		// (get) Token: 0x0600E6A3 RID: 59043 RVA: 0x00155305 File Offset: 0x00153505
		// (set) Token: 0x0600E6A4 RID: 59044 RVA: 0x00155319 File Offset: 0x00153519
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

		// Token: 0x17003759 RID: 14169
		// (get) Token: 0x0600E6A5 RID: 59045 RVA: 0x0015532E File Offset: 0x0015352E
		// (set) Token: 0x0600E6A6 RID: 59046 RVA: 0x0015533E File Offset: 0x0015353E
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

		// Token: 0x1700375A RID: 14170
		// (get) Token: 0x0600E6A7 RID: 59047 RVA: 0x0015534F File Offset: 0x0015354F
		// (set) Token: 0x0600E6A8 RID: 59048 RVA: 0x0015535F File Offset: 0x0015355F
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

		// Token: 0x1700375B RID: 14171
		// (get) Token: 0x0600E6A9 RID: 59049 RVA: 0x00155370 File Offset: 0x00153570
		// (set) Token: 0x0600E6AA RID: 59050 RVA: 0x00155380 File Offset: 0x00153580
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

		// Token: 0x1700375C RID: 14172
		// (get) Token: 0x0600E6AB RID: 59051 RVA: 0x00155391 File Offset: 0x00153591
		// (set) Token: 0x0600E6AC RID: 59052 RVA: 0x001553A1 File Offset: 0x001535A1
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

		// Token: 0x1700375D RID: 14173
		// (get) Token: 0x0600E6AD RID: 59053 RVA: 0x001553B2 File Offset: 0x001535B2
		// (set) Token: 0x0600E6AE RID: 59054 RVA: 0x001553C2 File Offset: 0x001535C2
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

		// Token: 0x1700375E RID: 14174
		// (get) Token: 0x0600E6AF RID: 59055 RVA: 0x001553D3 File Offset: 0x001535D3
		// (set) Token: 0x0600E6B0 RID: 59056 RVA: 0x001553E3 File Offset: 0x001535E3
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

		// Token: 0x1700375F RID: 14175
		// (get) Token: 0x0600E6B1 RID: 59057 RVA: 0x001553F4 File Offset: 0x001535F4
		// (set) Token: 0x0600E6B2 RID: 59058 RVA: 0x00155404 File Offset: 0x00153604
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

		// Token: 0x17003760 RID: 14176
		// (get) Token: 0x0600E6B3 RID: 59059 RVA: 0x00155415 File Offset: 0x00153615
		// (set) Token: 0x0600E6B4 RID: 59060 RVA: 0x00155425 File Offset: 0x00153625
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

		// Token: 0x17003761 RID: 14177
		// (get) Token: 0x0600E6B5 RID: 59061 RVA: 0x00155436 File Offset: 0x00153636
		// (set) Token: 0x0600E6B6 RID: 59062 RVA: 0x00155446 File Offset: 0x00153646
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

		// Token: 0x17003762 RID: 14178
		// (get) Token: 0x0600E6B7 RID: 59063 RVA: 0x00155457 File Offset: 0x00153657
		// (set) Token: 0x0600E6B8 RID: 59064 RVA: 0x0015546B File Offset: 0x0015366B
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

		// Token: 0x17003763 RID: 14179
		// (get) Token: 0x0600E6B9 RID: 59065 RVA: 0x00155480 File Offset: 0x00153680
		// (set) Token: 0x0600E6BA RID: 59066 RVA: 0x00155494 File Offset: 0x00153694
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

		// Token: 0x17003764 RID: 14180
		// (get) Token: 0x0600E6BB RID: 59067 RVA: 0x001554A9 File Offset: 0x001536A9
		// (set) Token: 0x0600E6BC RID: 59068 RVA: 0x001554BD File Offset: 0x001536BD
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

		// Token: 0x17003765 RID: 14181
		// (get) Token: 0x0600E6BD RID: 59069 RVA: 0x001554D2 File Offset: 0x001536D2
		// (set) Token: 0x0600E6BE RID: 59070 RVA: 0x001554E6 File Offset: 0x001536E6
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

		// Token: 0x17003766 RID: 14182
		// (get) Token: 0x0600E6BF RID: 59071 RVA: 0x001554FB File Offset: 0x001536FB
		// (set) Token: 0x0600E6C0 RID: 59072 RVA: 0x0015550F File Offset: 0x0015370F
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

		// Token: 0x17003767 RID: 14183
		// (get) Token: 0x0600E6C1 RID: 59073 RVA: 0x00155524 File Offset: 0x00153724
		// (set) Token: 0x0600E6C2 RID: 59074 RVA: 0x00155538 File Offset: 0x00153738
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

		// Token: 0x17003768 RID: 14184
		// (get) Token: 0x0600E6C3 RID: 59075 RVA: 0x0015554D File Offset: 0x0015374D
		// (set) Token: 0x0600E6C4 RID: 59076 RVA: 0x00155561 File Offset: 0x00153761
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

		// Token: 0x17003769 RID: 14185
		// (get) Token: 0x0600E6C5 RID: 59077 RVA: 0x00155576 File Offset: 0x00153776
		// (set) Token: 0x0600E6C6 RID: 59078 RVA: 0x00155586 File Offset: 0x00153786
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

		// Token: 0x1700376A RID: 14186
		// (get) Token: 0x0600E6C7 RID: 59079 RVA: 0x00155597 File Offset: 0x00153797
		// (set) Token: 0x0600E6C8 RID: 59080 RVA: 0x001555AB File Offset: 0x001537AB
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

		// Token: 0x1700376B RID: 14187
		// (get) Token: 0x0600E6C9 RID: 59081 RVA: 0x001555C0 File Offset: 0x001537C0
		// (set) Token: 0x0600E6CA RID: 59082 RVA: 0x001555D9 File Offset: 0x001537D9
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

		// Token: 0x1700376C RID: 14188
		// (get) Token: 0x0600E6CB RID: 59083 RVA: 0x00155609 File Offset: 0x00153809
		// (set) Token: 0x0600E6CC RID: 59084 RVA: 0x0015561D File Offset: 0x0015381D
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

		// Token: 0x1700376D RID: 14189
		// (get) Token: 0x0600E6CD RID: 59085 RVA: 0x00155632 File Offset: 0x00153832
		// (set) Token: 0x0600E6CE RID: 59086 RVA: 0x00155642 File Offset: 0x00153842
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

		// Token: 0x1700376E RID: 14190
		// (get) Token: 0x0600E6CF RID: 59087 RVA: 0x00155653 File Offset: 0x00153853
		// (set) Token: 0x0600E6D0 RID: 59088 RVA: 0x00155667 File Offset: 0x00153867
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

		// Token: 0x1700376F RID: 14191
		// (get) Token: 0x0600E6D1 RID: 59089 RVA: 0x0015567C File Offset: 0x0015387C
		// (set) Token: 0x0600E6D2 RID: 59090 RVA: 0x0015568C File Offset: 0x0015388C
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

		// Token: 0x17003770 RID: 14192
		// (get) Token: 0x0600E6D3 RID: 59091 RVA: 0x0015569D File Offset: 0x0015389D
		// (set) Token: 0x0600E6D4 RID: 59092 RVA: 0x001556AD File Offset: 0x001538AD
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

		// Token: 0x17003771 RID: 14193
		// (get) Token: 0x0600E6D5 RID: 59093 RVA: 0x001556BE File Offset: 0x001538BE
		// (set) Token: 0x0600E6D6 RID: 59094 RVA: 0x001556CE File Offset: 0x001538CE
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

		// Token: 0x17003772 RID: 14194
		// (get) Token: 0x0600E6D7 RID: 59095 RVA: 0x001556DF File Offset: 0x001538DF
		// (set) Token: 0x0600E6D8 RID: 59096 RVA: 0x001556EF File Offset: 0x001538EF
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

		// Token: 0x17003773 RID: 14195
		// (get) Token: 0x0600E6D9 RID: 59097 RVA: 0x00155700 File Offset: 0x00153900
		// (set) Token: 0x0600E6DA RID: 59098 RVA: 0x00155710 File Offset: 0x00153910
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

		// Token: 0x17003774 RID: 14196
		// (get) Token: 0x0600E6DB RID: 59099 RVA: 0x00155721 File Offset: 0x00153921
		// (set) Token: 0x0600E6DC RID: 59100 RVA: 0x0015573A File Offset: 0x0015393A
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

		// Token: 0x17003775 RID: 14197
		// (get) Token: 0x0600E6DD RID: 59101 RVA: 0x0015576A File Offset: 0x0015396A
		// (set) Token: 0x0600E6DE RID: 59102 RVA: 0x0015577A File Offset: 0x0015397A
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

		// Token: 0x17003776 RID: 14198
		// (get) Token: 0x0600E6DF RID: 59103 RVA: 0x0015578B File Offset: 0x0015398B
		// (set) Token: 0x0600E6E0 RID: 59104 RVA: 0x0015579B File Offset: 0x0015399B
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

		// Token: 0x17003777 RID: 14199
		// (get) Token: 0x0600E6E1 RID: 59105 RVA: 0x001557AC File Offset: 0x001539AC
		// (set) Token: 0x0600E6E2 RID: 59106 RVA: 0x001557C5 File Offset: 0x001539C5
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

		// Token: 0x17003778 RID: 14200
		// (get) Token: 0x0600E6E3 RID: 59107 RVA: 0x001557F5 File Offset: 0x001539F5
		// (set) Token: 0x0600E6E4 RID: 59108 RVA: 0x0015580E File Offset: 0x00153A0E
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

		// Token: 0x17003779 RID: 14201
		// (get) Token: 0x0600E6E5 RID: 59109 RVA: 0x0015583E File Offset: 0x00153A3E
		// (set) Token: 0x0600E6E6 RID: 59110 RVA: 0x00155852 File Offset: 0x00153A52
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

		// Token: 0x1700377A RID: 14202
		// (get) Token: 0x0600E6E7 RID: 59111 RVA: 0x00155867 File Offset: 0x00153A67
		// (set) Token: 0x0600E6E8 RID: 59112 RVA: 0x0015587B File Offset: 0x00153A7B
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

		// Token: 0x1700377B RID: 14203
		// (get) Token: 0x0600E6E9 RID: 59113 RVA: 0x00155890 File Offset: 0x00153A90
		// (set) Token: 0x0600E6EA RID: 59114 RVA: 0x001558A0 File Offset: 0x00153AA0
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

		// Token: 0x1700377C RID: 14204
		// (get) Token: 0x0600E6EB RID: 59115 RVA: 0x001558B1 File Offset: 0x00153AB1
		// (set) Token: 0x0600E6EC RID: 59116 RVA: 0x001558C1 File Offset: 0x00153AC1
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

		// Token: 0x1700377D RID: 14205
		// (get) Token: 0x0600E6ED RID: 59117 RVA: 0x001558D2 File Offset: 0x00153AD2
		// (set) Token: 0x0600E6EE RID: 59118 RVA: 0x001558E2 File Offset: 0x00153AE2
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

		// Token: 0x1700377E RID: 14206
		// (get) Token: 0x0600E6EF RID: 59119 RVA: 0x001558F3 File Offset: 0x00153AF3
		// (set) Token: 0x0600E6F0 RID: 59120 RVA: 0x00155903 File Offset: 0x00153B03
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

		// Token: 0x1700377F RID: 14207
		// (get) Token: 0x0600E6F1 RID: 59121 RVA: 0x00155914 File Offset: 0x00153B14
		// (set) Token: 0x0600E6F2 RID: 59122 RVA: 0x00155924 File Offset: 0x00153B24
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

		// Token: 0x17003780 RID: 14208
		// (get) Token: 0x0600E6F3 RID: 59123 RVA: 0x00155935 File Offset: 0x00153B35
		// (set) Token: 0x0600E6F4 RID: 59124 RVA: 0x00155945 File Offset: 0x00153B45
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

		// Token: 0x17003781 RID: 14209
		// (get) Token: 0x0600E6F5 RID: 59125 RVA: 0x00155956 File Offset: 0x00153B56
		// (set) Token: 0x0600E6F6 RID: 59126 RVA: 0x00155966 File Offset: 0x00153B66
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

		// Token: 0x17003782 RID: 14210
		// (get) Token: 0x0600E6F7 RID: 59127 RVA: 0x00155977 File Offset: 0x00153B77
		// (set) Token: 0x0600E6F8 RID: 59128 RVA: 0x00155987 File Offset: 0x00153B87
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

		// Token: 0x17003783 RID: 14211
		// (get) Token: 0x0600E6F9 RID: 59129 RVA: 0x00155998 File Offset: 0x00153B98
		// (set) Token: 0x0600E6FA RID: 59130 RVA: 0x001559A8 File Offset: 0x00153BA8
		public unsafe ELocalExposureMethod LocalExposureMethod
		{
			get
			{
				return (ELocalExposureMethod)(*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LocalExposureMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_LocalExposureMethod) = (byte)value;
			}
		}

		// Token: 0x17003784 RID: 14212
		// (get) Token: 0x0600E6FB RID: 59131 RVA: 0x001559B9 File Offset: 0x00153BB9
		// (set) Token: 0x0600E6FC RID: 59132 RVA: 0x001559C9 File Offset: 0x00153BC9
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

		// Token: 0x17003785 RID: 14213
		// (get) Token: 0x0600E6FD RID: 59133 RVA: 0x001559DA File Offset: 0x00153BDA
		// (set) Token: 0x0600E6FE RID: 59134 RVA: 0x001559EA File Offset: 0x00153BEA
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

		// Token: 0x17003786 RID: 14214
		// (get) Token: 0x0600E6FF RID: 59135 RVA: 0x001559FB File Offset: 0x00153BFB
		// (set) Token: 0x0600E700 RID: 59136 RVA: 0x00155A0B File Offset: 0x00153C0B
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

		// Token: 0x17003787 RID: 14215
		// (get) Token: 0x0600E701 RID: 59137 RVA: 0x00155A1C File Offset: 0x00153C1C
		// (set) Token: 0x0600E702 RID: 59138 RVA: 0x00155A30 File Offset: 0x00153C30
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

		// Token: 0x17003788 RID: 14216
		// (get) Token: 0x0600E703 RID: 59139 RVA: 0x00155A45 File Offset: 0x00153C45
		// (set) Token: 0x0600E704 RID: 59140 RVA: 0x00155A59 File Offset: 0x00153C59
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

		// Token: 0x17003789 RID: 14217
		// (get) Token: 0x0600E705 RID: 59141 RVA: 0x00155A6E File Offset: 0x00153C6E
		// (set) Token: 0x0600E706 RID: 59142 RVA: 0x00155A7E File Offset: 0x00153C7E
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

		// Token: 0x1700378A RID: 14218
		// (get) Token: 0x0600E707 RID: 59143 RVA: 0x00155A8F File Offset: 0x00153C8F
		// (set) Token: 0x0600E708 RID: 59144 RVA: 0x00155A9F File Offset: 0x00153C9F
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

		// Token: 0x1700378B RID: 14219
		// (get) Token: 0x0600E709 RID: 59145 RVA: 0x00155AB0 File Offset: 0x00153CB0
		// (set) Token: 0x0600E70A RID: 59146 RVA: 0x00155AC0 File Offset: 0x00153CC0
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

		// Token: 0x1700378C RID: 14220
		// (get) Token: 0x0600E70B RID: 59147 RVA: 0x00155AD1 File Offset: 0x00153CD1
		// (set) Token: 0x0600E70C RID: 59148 RVA: 0x00155AE1 File Offset: 0x00153CE1
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

		// Token: 0x1700378D RID: 14221
		// (get) Token: 0x0600E70D RID: 59149 RVA: 0x00155AF2 File Offset: 0x00153CF2
		// (set) Token: 0x0600E70E RID: 59150 RVA: 0x00155B02 File Offset: 0x00153D02
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

		// Token: 0x1700378E RID: 14222
		// (get) Token: 0x0600E70F RID: 59151 RVA: 0x00155B13 File Offset: 0x00153D13
		// (set) Token: 0x0600E710 RID: 59152 RVA: 0x00155B23 File Offset: 0x00153D23
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

		// Token: 0x1700378F RID: 14223
		// (get) Token: 0x0600E711 RID: 59153 RVA: 0x00155B34 File Offset: 0x00153D34
		// (set) Token: 0x0600E712 RID: 59154 RVA: 0x00155B44 File Offset: 0x00153D44
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

		// Token: 0x17003790 RID: 14224
		// (get) Token: 0x0600E713 RID: 59155 RVA: 0x00155B55 File Offset: 0x00153D55
		// (set) Token: 0x0600E714 RID: 59156 RVA: 0x00155B65 File Offset: 0x00153D65
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

		// Token: 0x17003791 RID: 14225
		// (get) Token: 0x0600E715 RID: 59157 RVA: 0x00155B76 File Offset: 0x00153D76
		// (set) Token: 0x0600E716 RID: 59158 RVA: 0x00155B8A File Offset: 0x00153D8A
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

		// Token: 0x17003792 RID: 14226
		// (get) Token: 0x0600E717 RID: 59159 RVA: 0x00155B9F File Offset: 0x00153D9F
		// (set) Token: 0x0600E718 RID: 59160 RVA: 0x00155BAF File Offset: 0x00153DAF
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

		// Token: 0x17003793 RID: 14227
		// (get) Token: 0x0600E719 RID: 59161 RVA: 0x00155BC0 File Offset: 0x00153DC0
		// (set) Token: 0x0600E71A RID: 59162 RVA: 0x00155BD0 File Offset: 0x00153DD0
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

		// Token: 0x17003794 RID: 14228
		// (get) Token: 0x0600E71B RID: 59163 RVA: 0x00155BE1 File Offset: 0x00153DE1
		// (set) Token: 0x0600E71C RID: 59164 RVA: 0x00155BF5 File Offset: 0x00153DF5
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

		// Token: 0x17003795 RID: 14229
		// (get) Token: 0x0600E71D RID: 59165 RVA: 0x00155C0C File Offset: 0x00153E0C
		// (set) Token: 0x0600E71E RID: 59166 RVA: 0x00155C4F File Offset: 0x00153E4F
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

		// Token: 0x17003796 RID: 14230
		// (get) Token: 0x0600E71F RID: 59167 RVA: 0x00155C5D File Offset: 0x00153E5D
		// (set) Token: 0x0600E720 RID: 59168 RVA: 0x00155C76 File Offset: 0x00153E76
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

		// Token: 0x17003797 RID: 14231
		// (get) Token: 0x0600E721 RID: 59169 RVA: 0x00155CA6 File Offset: 0x00153EA6
		// (set) Token: 0x0600E722 RID: 59170 RVA: 0x00155CB6 File Offset: 0x00153EB6
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

		// Token: 0x17003798 RID: 14232
		// (get) Token: 0x0600E723 RID: 59171 RVA: 0x00155CC7 File Offset: 0x00153EC7
		// (set) Token: 0x0600E724 RID: 59172 RVA: 0x00155CDB File Offset: 0x00153EDB
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

		// Token: 0x17003799 RID: 14233
		// (get) Token: 0x0600E725 RID: 59173 RVA: 0x00155CF0 File Offset: 0x00153EF0
		// (set) Token: 0x0600E726 RID: 59174 RVA: 0x00155D00 File Offset: 0x00153F00
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

		// Token: 0x1700379A RID: 14234
		// (get) Token: 0x0600E727 RID: 59175 RVA: 0x00155D11 File Offset: 0x00153F11
		// (set) Token: 0x0600E728 RID: 59176 RVA: 0x00155D21 File Offset: 0x00153F21
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

		// Token: 0x1700379B RID: 14235
		// (get) Token: 0x0600E729 RID: 59177 RVA: 0x00155D32 File Offset: 0x00153F32
		// (set) Token: 0x0600E72A RID: 59178 RVA: 0x00155D42 File Offset: 0x00153F42
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

		// Token: 0x1700379C RID: 14236
		// (get) Token: 0x0600E72B RID: 59179 RVA: 0x00155D53 File Offset: 0x00153F53
		// (set) Token: 0x0600E72C RID: 59180 RVA: 0x00155D63 File Offset: 0x00153F63
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

		// Token: 0x1700379D RID: 14237
		// (get) Token: 0x0600E72D RID: 59181 RVA: 0x00155D74 File Offset: 0x00153F74
		// (set) Token: 0x0600E72E RID: 59182 RVA: 0x00155D84 File Offset: 0x00153F84
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

		// Token: 0x1700379E RID: 14238
		// (get) Token: 0x0600E72F RID: 59183 RVA: 0x00155D95 File Offset: 0x00153F95
		// (set) Token: 0x0600E730 RID: 59184 RVA: 0x00155DA5 File Offset: 0x00153FA5
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

		// Token: 0x1700379F RID: 14239
		// (get) Token: 0x0600E731 RID: 59185 RVA: 0x00155DB6 File Offset: 0x00153FB6
		// (set) Token: 0x0600E732 RID: 59186 RVA: 0x00155DCA File Offset: 0x00153FCA
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

		// Token: 0x170037A0 RID: 14240
		// (get) Token: 0x0600E733 RID: 59187 RVA: 0x00155DDF File Offset: 0x00153FDF
		// (set) Token: 0x0600E734 RID: 59188 RVA: 0x00155DEF File Offset: 0x00153FEF
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

		// Token: 0x170037A1 RID: 14241
		// (get) Token: 0x0600E735 RID: 59189 RVA: 0x00155E00 File Offset: 0x00154000
		// (set) Token: 0x0600E736 RID: 59190 RVA: 0x00155E10 File Offset: 0x00154010
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

		// Token: 0x170037A2 RID: 14242
		// (get) Token: 0x0600E737 RID: 59191 RVA: 0x00155E21 File Offset: 0x00154021
		// (set) Token: 0x0600E738 RID: 59192 RVA: 0x00155E31 File Offset: 0x00154031
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

		// Token: 0x170037A3 RID: 14243
		// (get) Token: 0x0600E739 RID: 59193 RVA: 0x00155E42 File Offset: 0x00154042
		// (set) Token: 0x0600E73A RID: 59194 RVA: 0x00155E52 File Offset: 0x00154052
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

		// Token: 0x170037A4 RID: 14244
		// (get) Token: 0x0600E73B RID: 59195 RVA: 0x00155E63 File Offset: 0x00154063
		// (set) Token: 0x0600E73C RID: 59196 RVA: 0x00155E73 File Offset: 0x00154073
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

		// Token: 0x170037A5 RID: 14245
		// (get) Token: 0x0600E73D RID: 59197 RVA: 0x00155E84 File Offset: 0x00154084
		// (set) Token: 0x0600E73E RID: 59198 RVA: 0x00155E94 File Offset: 0x00154094
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

		// Token: 0x170037A6 RID: 14246
		// (get) Token: 0x0600E73F RID: 59199 RVA: 0x00155EA5 File Offset: 0x001540A5
		// (set) Token: 0x0600E740 RID: 59200 RVA: 0x00155EB5 File Offset: 0x001540B5
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

		// Token: 0x170037A7 RID: 14247
		// (get) Token: 0x0600E741 RID: 59201 RVA: 0x00155EC6 File Offset: 0x001540C6
		// (set) Token: 0x0600E742 RID: 59202 RVA: 0x00155EDA File Offset: 0x001540DA
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

		// Token: 0x170037A8 RID: 14248
		// (get) Token: 0x0600E743 RID: 59203 RVA: 0x00155EEF File Offset: 0x001540EF
		// (set) Token: 0x0600E744 RID: 59204 RVA: 0x00155EFF File Offset: 0x001540FF
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

		// Token: 0x170037A9 RID: 14249
		// (get) Token: 0x0600E745 RID: 59205 RVA: 0x00155F10 File Offset: 0x00154110
		// (set) Token: 0x0600E746 RID: 59206 RVA: 0x00155F20 File Offset: 0x00154120
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

		// Token: 0x170037AA RID: 14250
		// (get) Token: 0x0600E747 RID: 59207 RVA: 0x00155F31 File Offset: 0x00154131
		// (set) Token: 0x0600E748 RID: 59208 RVA: 0x00155F41 File Offset: 0x00154141
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

		// Token: 0x170037AB RID: 14251
		// (get) Token: 0x0600E749 RID: 59209 RVA: 0x00155F52 File Offset: 0x00154152
		// (set) Token: 0x0600E74A RID: 59210 RVA: 0x00155F62 File Offset: 0x00154162
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

		// Token: 0x170037AC RID: 14252
		// (get) Token: 0x0600E74B RID: 59211 RVA: 0x00155F73 File Offset: 0x00154173
		// (set) Token: 0x0600E74C RID: 59212 RVA: 0x00155F83 File Offset: 0x00154183
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

		// Token: 0x170037AD RID: 14253
		// (get) Token: 0x0600E74D RID: 59213 RVA: 0x00155F94 File Offset: 0x00154194
		// (set) Token: 0x0600E74E RID: 59214 RVA: 0x00155FA4 File Offset: 0x001541A4
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

		// Token: 0x170037AE RID: 14254
		// (get) Token: 0x0600E74F RID: 59215 RVA: 0x00155FB5 File Offset: 0x001541B5
		// (set) Token: 0x0600E750 RID: 59216 RVA: 0x00155FC5 File Offset: 0x001541C5
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

		// Token: 0x170037AF RID: 14255
		// (get) Token: 0x0600E751 RID: 59217 RVA: 0x00155FD6 File Offset: 0x001541D6
		// (set) Token: 0x0600E752 RID: 59218 RVA: 0x00155FE6 File Offset: 0x001541E6
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

		// Token: 0x170037B0 RID: 14256
		// (get) Token: 0x0600E753 RID: 59219 RVA: 0x00155FF7 File Offset: 0x001541F7
		// (set) Token: 0x0600E754 RID: 59220 RVA: 0x00156007 File Offset: 0x00154207
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

		// Token: 0x170037B1 RID: 14257
		// (get) Token: 0x0600E755 RID: 59221 RVA: 0x00156018 File Offset: 0x00154218
		// (set) Token: 0x0600E756 RID: 59222 RVA: 0x00156028 File Offset: 0x00154228
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

		// Token: 0x170037B2 RID: 14258
		// (get) Token: 0x0600E757 RID: 59223 RVA: 0x00156039 File Offset: 0x00154239
		// (set) Token: 0x0600E758 RID: 59224 RVA: 0x00156049 File Offset: 0x00154249
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

		// Token: 0x170037B3 RID: 14259
		// (get) Token: 0x0600E759 RID: 59225 RVA: 0x0015605A File Offset: 0x0015425A
		// (set) Token: 0x0600E75A RID: 59226 RVA: 0x0015606A File Offset: 0x0015426A
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

		// Token: 0x170037B4 RID: 14260
		// (get) Token: 0x0600E75B RID: 59227 RVA: 0x0015607B File Offset: 0x0015427B
		// (set) Token: 0x0600E75C RID: 59228 RVA: 0x0015608B File Offset: 0x0015428B
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

		// Token: 0x170037B5 RID: 14261
		// (get) Token: 0x0600E75D RID: 59229 RVA: 0x0015609C File Offset: 0x0015429C
		// (set) Token: 0x0600E75E RID: 59230 RVA: 0x001560AC File Offset: 0x001542AC
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

		// Token: 0x170037B6 RID: 14262
		// (get) Token: 0x0600E75F RID: 59231 RVA: 0x001560BD File Offset: 0x001542BD
		// (set) Token: 0x0600E760 RID: 59232 RVA: 0x001560CD File Offset: 0x001542CD
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

		// Token: 0x170037B7 RID: 14263
		// (get) Token: 0x0600E761 RID: 59233 RVA: 0x001560DE File Offset: 0x001542DE
		// (set) Token: 0x0600E762 RID: 59234 RVA: 0x001560EE File Offset: 0x001542EE
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

		// Token: 0x170037B8 RID: 14264
		// (get) Token: 0x0600E763 RID: 59235 RVA: 0x001560FF File Offset: 0x001542FF
		// (set) Token: 0x0600E764 RID: 59236 RVA: 0x0015610F File Offset: 0x0015430F
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

		// Token: 0x170037B9 RID: 14265
		// (get) Token: 0x0600E765 RID: 59237 RVA: 0x00156120 File Offset: 0x00154320
		// (set) Token: 0x0600E766 RID: 59238 RVA: 0x00156130 File Offset: 0x00154330
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

		// Token: 0x170037BA RID: 14266
		// (get) Token: 0x0600E767 RID: 59239 RVA: 0x00156141 File Offset: 0x00154341
		// (set) Token: 0x0600E768 RID: 59240 RVA: 0x00156151 File Offset: 0x00154351
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

		// Token: 0x170037BB RID: 14267
		// (get) Token: 0x0600E769 RID: 59241 RVA: 0x00156162 File Offset: 0x00154362
		// (set) Token: 0x0600E76A RID: 59242 RVA: 0x00156172 File Offset: 0x00154372
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

		// Token: 0x170037BC RID: 14268
		// (get) Token: 0x0600E76B RID: 59243 RVA: 0x00156183 File Offset: 0x00154383
		// (set) Token: 0x0600E76C RID: 59244 RVA: 0x00156193 File Offset: 0x00154393
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

		// Token: 0x170037BD RID: 14269
		// (get) Token: 0x0600E76D RID: 59245 RVA: 0x001561A4 File Offset: 0x001543A4
		// (set) Token: 0x0600E76E RID: 59246 RVA: 0x001561B4 File Offset: 0x001543B4
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

		// Token: 0x170037BE RID: 14270
		// (get) Token: 0x0600E76F RID: 59247 RVA: 0x001561C5 File Offset: 0x001543C5
		// (set) Token: 0x0600E770 RID: 59248 RVA: 0x001561D5 File Offset: 0x001543D5
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

		// Token: 0x170037BF RID: 14271
		// (get) Token: 0x0600E771 RID: 59249 RVA: 0x001561E6 File Offset: 0x001543E6
		// (set) Token: 0x0600E772 RID: 59250 RVA: 0x001561F6 File Offset: 0x001543F6
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

		// Token: 0x170037C0 RID: 14272
		// (get) Token: 0x0600E773 RID: 59251 RVA: 0x00156207 File Offset: 0x00154407
		// (set) Token: 0x0600E774 RID: 59252 RVA: 0x00156217 File Offset: 0x00154417
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

		// Token: 0x170037C1 RID: 14273
		// (get) Token: 0x0600E775 RID: 59253 RVA: 0x00156228 File Offset: 0x00154428
		// (set) Token: 0x0600E776 RID: 59254 RVA: 0x00156238 File Offset: 0x00154438
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

		// Token: 0x170037C2 RID: 14274
		// (get) Token: 0x0600E777 RID: 59255 RVA: 0x00156249 File Offset: 0x00154449
		// (set) Token: 0x0600E778 RID: 59256 RVA: 0x00156259 File Offset: 0x00154459
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

		// Token: 0x170037C3 RID: 14275
		// (get) Token: 0x0600E779 RID: 59257 RVA: 0x0015626A File Offset: 0x0015446A
		// (set) Token: 0x0600E77A RID: 59258 RVA: 0x0015627A File Offset: 0x0015447A
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

		// Token: 0x170037C4 RID: 14276
		// (get) Token: 0x0600E77B RID: 59259 RVA: 0x0015628B File Offset: 0x0015448B
		// (set) Token: 0x0600E77C RID: 59260 RVA: 0x0015629B File Offset: 0x0015449B
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

		// Token: 0x170037C5 RID: 14277
		// (get) Token: 0x0600E77D RID: 59261 RVA: 0x001562AC File Offset: 0x001544AC
		// (set) Token: 0x0600E77E RID: 59262 RVA: 0x001562BC File Offset: 0x001544BC
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

		// Token: 0x170037C6 RID: 14278
		// (get) Token: 0x0600E77F RID: 59263 RVA: 0x001562CD File Offset: 0x001544CD
		// (set) Token: 0x0600E780 RID: 59264 RVA: 0x001562DD File Offset: 0x001544DD
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

		// Token: 0x170037C7 RID: 14279
		// (get) Token: 0x0600E781 RID: 59265 RVA: 0x001562EE File Offset: 0x001544EE
		// (set) Token: 0x0600E782 RID: 59266 RVA: 0x001562FE File Offset: 0x001544FE
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

		// Token: 0x170037C8 RID: 14280
		// (get) Token: 0x0600E783 RID: 59267 RVA: 0x0015630F File Offset: 0x0015450F
		// (set) Token: 0x0600E784 RID: 59268 RVA: 0x0015631F File Offset: 0x0015451F
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

		// Token: 0x170037C9 RID: 14281
		// (get) Token: 0x0600E785 RID: 59269 RVA: 0x00156330 File Offset: 0x00154530
		// (set) Token: 0x0600E786 RID: 59270 RVA: 0x00156340 File Offset: 0x00154540
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

		// Token: 0x170037CA RID: 14282
		// (get) Token: 0x0600E787 RID: 59271 RVA: 0x00156351 File Offset: 0x00154551
		// (set) Token: 0x0600E788 RID: 59272 RVA: 0x0015636A File Offset: 0x0015456A
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

		// Token: 0x170037CB RID: 14283
		// (get) Token: 0x0600E789 RID: 59273 RVA: 0x0015639A File Offset: 0x0015459A
		// (set) Token: 0x0600E78A RID: 59274 RVA: 0x001563AA File Offset: 0x001545AA
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

		// Token: 0x170037CC RID: 14284
		// (get) Token: 0x0600E78B RID: 59275 RVA: 0x001563BB File Offset: 0x001545BB
		// (set) Token: 0x0600E78C RID: 59276 RVA: 0x001563CB File Offset: 0x001545CB
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

		// Token: 0x170037CD RID: 14285
		// (get) Token: 0x0600E78D RID: 59277 RVA: 0x001563DC File Offset: 0x001545DC
		// (set) Token: 0x0600E78E RID: 59278 RVA: 0x001563EC File Offset: 0x001545EC
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

		// Token: 0x170037CE RID: 14286
		// (get) Token: 0x0600E78F RID: 59279 RVA: 0x001563FD File Offset: 0x001545FD
		// (set) Token: 0x0600E790 RID: 59280 RVA: 0x0015640D File Offset: 0x0015460D
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

		// Token: 0x170037CF RID: 14287
		// (get) Token: 0x0600E791 RID: 59281 RVA: 0x0015641E File Offset: 0x0015461E
		// (set) Token: 0x0600E792 RID: 59282 RVA: 0x0015642E File Offset: 0x0015462E
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

		// Token: 0x170037D0 RID: 14288
		// (get) Token: 0x0600E793 RID: 59283 RVA: 0x0015643F File Offset: 0x0015463F
		// (set) Token: 0x0600E794 RID: 59284 RVA: 0x0015644F File Offset: 0x0015464F
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

		// Token: 0x170037D1 RID: 14289
		// (get) Token: 0x0600E795 RID: 59285 RVA: 0x00156460 File Offset: 0x00154660
		// (set) Token: 0x0600E796 RID: 59286 RVA: 0x00156470 File Offset: 0x00154670
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

		// Token: 0x170037D2 RID: 14290
		// (get) Token: 0x0600E797 RID: 59287 RVA: 0x00156481 File Offset: 0x00154681
		// (set) Token: 0x0600E798 RID: 59288 RVA: 0x00156491 File Offset: 0x00154691
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

		// Token: 0x170037D3 RID: 14291
		// (get) Token: 0x0600E799 RID: 59289 RVA: 0x001564A2 File Offset: 0x001546A2
		// (set) Token: 0x0600E79A RID: 59290 RVA: 0x001564B2 File Offset: 0x001546B2
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

		// Token: 0x170037D4 RID: 14292
		// (get) Token: 0x0600E79B RID: 59291 RVA: 0x001564C3 File Offset: 0x001546C3
		// (set) Token: 0x0600E79C RID: 59292 RVA: 0x001564D3 File Offset: 0x001546D3
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

		// Token: 0x170037D5 RID: 14293
		// (get) Token: 0x0600E79D RID: 59293 RVA: 0x001564E4 File Offset: 0x001546E4
		// (set) Token: 0x0600E79E RID: 59294 RVA: 0x001564FD File Offset: 0x001546FD
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

		// Token: 0x170037D6 RID: 14294
		// (get) Token: 0x0600E79F RID: 59295 RVA: 0x0015652D File Offset: 0x0015472D
		// (set) Token: 0x0600E7A0 RID: 59296 RVA: 0x0015653D File Offset: 0x0015473D
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

		// Token: 0x170037D7 RID: 14295
		// (get) Token: 0x0600E7A1 RID: 59297 RVA: 0x0015654E File Offset: 0x0015474E
		// (set) Token: 0x0600E7A2 RID: 59298 RVA: 0x0015655E File Offset: 0x0015475E
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

		// Token: 0x170037D8 RID: 14296
		// (get) Token: 0x0600E7A3 RID: 59299 RVA: 0x0015656F File Offset: 0x0015476F
		// (set) Token: 0x0600E7A4 RID: 59300 RVA: 0x0015657F File Offset: 0x0015477F
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

		// Token: 0x170037D9 RID: 14297
		// (get) Token: 0x0600E7A5 RID: 59301 RVA: 0x00156590 File Offset: 0x00154790
		// (set) Token: 0x0600E7A6 RID: 59302 RVA: 0x001565A0 File Offset: 0x001547A0
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

		// Token: 0x170037DA RID: 14298
		// (get) Token: 0x0600E7A7 RID: 59303 RVA: 0x001565B1 File Offset: 0x001547B1
		// (set) Token: 0x0600E7A8 RID: 59304 RVA: 0x001565C5 File Offset: 0x001547C5
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

		// Token: 0x170037DB RID: 14299
		// (get) Token: 0x0600E7A9 RID: 59305 RVA: 0x001565DA File Offset: 0x001547DA
		// (set) Token: 0x0600E7AA RID: 59306 RVA: 0x001565EA File Offset: 0x001547EA
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

		// Token: 0x170037DC RID: 14300
		// (get) Token: 0x0600E7AB RID: 59307 RVA: 0x001565FB File Offset: 0x001547FB
		// (set) Token: 0x0600E7AC RID: 59308 RVA: 0x0015660B File Offset: 0x0015480B
		public unsafe ERayTracingGlobalIlluminationType RayTracingGIType
		{
			get
			{
				return (ERayTracingGlobalIlluminationType)(*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingGIType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingGIType) = (byte)value;
			}
		}

		// Token: 0x170037DD RID: 14301
		// (get) Token: 0x0600E7AD RID: 59309 RVA: 0x0015661C File Offset: 0x0015481C
		// (set) Token: 0x0600E7AE RID: 59310 RVA: 0x0015662C File Offset: 0x0015482C
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

		// Token: 0x170037DE RID: 14302
		// (get) Token: 0x0600E7AF RID: 59311 RVA: 0x0015663D File Offset: 0x0015483D
		// (set) Token: 0x0600E7B0 RID: 59312 RVA: 0x0015664D File Offset: 0x0015484D
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

		// Token: 0x170037DF RID: 14303
		// (get) Token: 0x0600E7B1 RID: 59313 RVA: 0x0015665E File Offset: 0x0015485E
		// (set) Token: 0x0600E7B2 RID: 59314 RVA: 0x0015666E File Offset: 0x0015486E
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

		// Token: 0x170037E0 RID: 14304
		// (get) Token: 0x0600E7B3 RID: 59315 RVA: 0x0015667F File Offset: 0x0015487F
		// (set) Token: 0x0600E7B4 RID: 59316 RVA: 0x00156693 File Offset: 0x00154893
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

		// Token: 0x170037E1 RID: 14305
		// (get) Token: 0x0600E7B5 RID: 59317 RVA: 0x001566A8 File Offset: 0x001548A8
		// (set) Token: 0x0600E7B6 RID: 59318 RVA: 0x001566B8 File Offset: 0x001548B8
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

		// Token: 0x170037E2 RID: 14306
		// (get) Token: 0x0600E7B7 RID: 59319 RVA: 0x001566C9 File Offset: 0x001548C9
		// (set) Token: 0x0600E7B8 RID: 59320 RVA: 0x001566D9 File Offset: 0x001548D9
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

		// Token: 0x170037E3 RID: 14307
		// (get) Token: 0x0600E7B9 RID: 59321 RVA: 0x001566EA File Offset: 0x001548EA
		// (set) Token: 0x0600E7BA RID: 59322 RVA: 0x001566FA File Offset: 0x001548FA
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

		// Token: 0x170037E4 RID: 14308
		// (get) Token: 0x0600E7BB RID: 59323 RVA: 0x0015670B File Offset: 0x0015490B
		// (set) Token: 0x0600E7BC RID: 59324 RVA: 0x0015671B File Offset: 0x0015491B
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

		// Token: 0x170037E5 RID: 14309
		// (get) Token: 0x0600E7BD RID: 59325 RVA: 0x0015672C File Offset: 0x0015492C
		// (set) Token: 0x0600E7BE RID: 59326 RVA: 0x0015673C File Offset: 0x0015493C
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

		// Token: 0x170037E6 RID: 14310
		// (get) Token: 0x0600E7BF RID: 59327 RVA: 0x0015674D File Offset: 0x0015494D
		// (set) Token: 0x0600E7C0 RID: 59328 RVA: 0x0015675D File Offset: 0x0015495D
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

		// Token: 0x170037E7 RID: 14311
		// (get) Token: 0x0600E7C1 RID: 59329 RVA: 0x0015676E File Offset: 0x0015496E
		// (set) Token: 0x0600E7C2 RID: 59330 RVA: 0x0015677E File Offset: 0x0015497E
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

		// Token: 0x170037E8 RID: 14312
		// (get) Token: 0x0600E7C3 RID: 59331 RVA: 0x0015678F File Offset: 0x0015498F
		// (set) Token: 0x0600E7C4 RID: 59332 RVA: 0x0015679F File Offset: 0x0015499F
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

		// Token: 0x170037E9 RID: 14313
		// (get) Token: 0x0600E7C5 RID: 59333 RVA: 0x001567B0 File Offset: 0x001549B0
		// (set) Token: 0x0600E7C6 RID: 59334 RVA: 0x001567C0 File Offset: 0x001549C0
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

		// Token: 0x170037EA RID: 14314
		// (get) Token: 0x0600E7C7 RID: 59335 RVA: 0x001567D1 File Offset: 0x001549D1
		// (set) Token: 0x0600E7C8 RID: 59336 RVA: 0x001567E1 File Offset: 0x001549E1
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

		// Token: 0x170037EB RID: 14315
		// (get) Token: 0x0600E7C9 RID: 59337 RVA: 0x001567F2 File Offset: 0x001549F2
		// (set) Token: 0x0600E7CA RID: 59338 RVA: 0x00156802 File Offset: 0x00154A02
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

		// Token: 0x170037EC RID: 14316
		// (get) Token: 0x0600E7CB RID: 59339 RVA: 0x00156813 File Offset: 0x00154A13
		// (set) Token: 0x0600E7CC RID: 59340 RVA: 0x00156823 File Offset: 0x00154A23
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

		// Token: 0x170037ED RID: 14317
		// (get) Token: 0x0600E7CD RID: 59341 RVA: 0x00156834 File Offset: 0x00154A34
		// (set) Token: 0x0600E7CE RID: 59342 RVA: 0x00156844 File Offset: 0x00154A44
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

		// Token: 0x170037EE RID: 14318
		// (get) Token: 0x0600E7CF RID: 59343 RVA: 0x00156855 File Offset: 0x00154A55
		// (set) Token: 0x0600E7D0 RID: 59344 RVA: 0x00156865 File Offset: 0x00154A65
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

		// Token: 0x170037EF RID: 14319
		// (get) Token: 0x0600E7D1 RID: 59345 RVA: 0x00156876 File Offset: 0x00154A76
		// (set) Token: 0x0600E7D2 RID: 59346 RVA: 0x00156886 File Offset: 0x00154A86
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

		// Token: 0x170037F0 RID: 14320
		// (get) Token: 0x0600E7D3 RID: 59347 RVA: 0x00156897 File Offset: 0x00154A97
		// (set) Token: 0x0600E7D4 RID: 59348 RVA: 0x001568A7 File Offset: 0x00154AA7
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

		// Token: 0x170037F1 RID: 14321
		// (get) Token: 0x0600E7D5 RID: 59349 RVA: 0x001568B8 File Offset: 0x00154AB8
		// (set) Token: 0x0600E7D6 RID: 59350 RVA: 0x001568C8 File Offset: 0x00154AC8
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

		// Token: 0x170037F2 RID: 14322
		// (get) Token: 0x0600E7D7 RID: 59351 RVA: 0x001568D9 File Offset: 0x00154AD9
		// (set) Token: 0x0600E7D8 RID: 59352 RVA: 0x001568E9 File Offset: 0x00154AE9
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

		// Token: 0x170037F3 RID: 14323
		// (get) Token: 0x0600E7D9 RID: 59353 RVA: 0x001568FA File Offset: 0x00154AFA
		// (set) Token: 0x0600E7DA RID: 59354 RVA: 0x0015690A File Offset: 0x00154B0A
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

		// Token: 0x170037F4 RID: 14324
		// (get) Token: 0x0600E7DB RID: 59355 RVA: 0x0015691B File Offset: 0x00154B1B
		// (set) Token: 0x0600E7DC RID: 59356 RVA: 0x0015692B File Offset: 0x00154B2B
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

		// Token: 0x170037F5 RID: 14325
		// (get) Token: 0x0600E7DD RID: 59357 RVA: 0x0015693C File Offset: 0x00154B3C
		// (set) Token: 0x0600E7DE RID: 59358 RVA: 0x0015694C File Offset: 0x00154B4C
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

		// Token: 0x170037F6 RID: 14326
		// (get) Token: 0x0600E7DF RID: 59359 RVA: 0x0015695D File Offset: 0x00154B5D
		// (set) Token: 0x0600E7E0 RID: 59360 RVA: 0x0015696D File Offset: 0x00154B6D
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

		// Token: 0x170037F7 RID: 14327
		// (get) Token: 0x0600E7E1 RID: 59361 RVA: 0x0015697E File Offset: 0x00154B7E
		// (set) Token: 0x0600E7E2 RID: 59362 RVA: 0x0015698E File Offset: 0x00154B8E
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

		// Token: 0x170037F8 RID: 14328
		// (get) Token: 0x0600E7E3 RID: 59363 RVA: 0x0015699F File Offset: 0x00154B9F
		// (set) Token: 0x0600E7E4 RID: 59364 RVA: 0x001569AF File Offset: 0x00154BAF
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

		// Token: 0x170037F9 RID: 14329
		// (get) Token: 0x0600E7E5 RID: 59365 RVA: 0x001569C0 File Offset: 0x00154BC0
		// (set) Token: 0x0600E7E6 RID: 59366 RVA: 0x001569D0 File Offset: 0x00154BD0
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

		// Token: 0x170037FA RID: 14330
		// (get) Token: 0x0600E7E7 RID: 59367 RVA: 0x001569E1 File Offset: 0x00154BE1
		// (set) Token: 0x0600E7E8 RID: 59368 RVA: 0x001569F1 File Offset: 0x00154BF1
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

		// Token: 0x170037FB RID: 14331
		// (get) Token: 0x0600E7E9 RID: 59369 RVA: 0x00156A02 File Offset: 0x00154C02
		// (set) Token: 0x0600E7EA RID: 59370 RVA: 0x00156A12 File Offset: 0x00154C12
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

		// Token: 0x170037FC RID: 14332
		// (get) Token: 0x0600E7EB RID: 59371 RVA: 0x00156A23 File Offset: 0x00154C23
		// (set) Token: 0x0600E7EC RID: 59372 RVA: 0x00156A33 File Offset: 0x00154C33
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

		// Token: 0x170037FD RID: 14333
		// (get) Token: 0x0600E7ED RID: 59373 RVA: 0x00156A44 File Offset: 0x00154C44
		// (set) Token: 0x0600E7EE RID: 59374 RVA: 0x00156A54 File Offset: 0x00154C54
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

		// Token: 0x170037FE RID: 14334
		// (get) Token: 0x0600E7EF RID: 59375 RVA: 0x00156A65 File Offset: 0x00154C65
		// (set) Token: 0x0600E7F0 RID: 59376 RVA: 0x00156A75 File Offset: 0x00154C75
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

		// Token: 0x170037FF RID: 14335
		// (get) Token: 0x0600E7F1 RID: 59377 RVA: 0x00156A86 File Offset: 0x00154C86
		// (set) Token: 0x0600E7F2 RID: 59378 RVA: 0x00156A96 File Offset: 0x00154C96
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

		// Token: 0x17003800 RID: 14336
		// (get) Token: 0x0600E7F3 RID: 59379 RVA: 0x00156AA7 File Offset: 0x00154CA7
		// (set) Token: 0x0600E7F4 RID: 59380 RVA: 0x00156AB7 File Offset: 0x00154CB7
		public unsafe EReflectionsType ReflectionsType
		{
			get
			{
				return (EReflectionsType)(*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ReflectionsType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_ReflectionsType) = (byte)value;
			}
		}

		// Token: 0x17003801 RID: 14337
		// (get) Token: 0x0600E7F5 RID: 59381 RVA: 0x00156AC8 File Offset: 0x00154CC8
		// (set) Token: 0x0600E7F6 RID: 59382 RVA: 0x00156AD8 File Offset: 0x00154CD8
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

		// Token: 0x17003802 RID: 14338
		// (get) Token: 0x0600E7F7 RID: 59383 RVA: 0x00156AE9 File Offset: 0x00154CE9
		// (set) Token: 0x0600E7F8 RID: 59384 RVA: 0x00156AF9 File Offset: 0x00154CF9
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

		// Token: 0x17003803 RID: 14339
		// (get) Token: 0x0600E7F9 RID: 59385 RVA: 0x00156B0A File Offset: 0x00154D0A
		// (set) Token: 0x0600E7FA RID: 59386 RVA: 0x00156B1A File Offset: 0x00154D1A
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

		// Token: 0x17003804 RID: 14340
		// (get) Token: 0x0600E7FB RID: 59387 RVA: 0x00156B2B File Offset: 0x00154D2B
		// (set) Token: 0x0600E7FC RID: 59388 RVA: 0x00156B3B File Offset: 0x00154D3B
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

		// Token: 0x17003805 RID: 14341
		// (get) Token: 0x0600E7FD RID: 59389 RVA: 0x00156B4C File Offset: 0x00154D4C
		// (set) Token: 0x0600E7FE RID: 59390 RVA: 0x00156B5C File Offset: 0x00154D5C
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

		// Token: 0x17003806 RID: 14342
		// (get) Token: 0x0600E7FF RID: 59391 RVA: 0x00156B6D File Offset: 0x00154D6D
		// (set) Token: 0x0600E800 RID: 59392 RVA: 0x00156B7D File Offset: 0x00154D7D
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

		// Token: 0x17003807 RID: 14343
		// (get) Token: 0x0600E801 RID: 59393 RVA: 0x00156B8E File Offset: 0x00154D8E
		// (set) Token: 0x0600E802 RID: 59394 RVA: 0x00156B9E File Offset: 0x00154D9E
		public unsafe EReflectedAndRefractedRayTracedShadows RayTracingReflectionsShadows
		{
			get
			{
				return (EReflectedAndRefractedRayTracedShadows)(*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingReflectionsShadows));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingReflectionsShadows) = (byte)value;
			}
		}

		// Token: 0x17003808 RID: 14344
		// (get) Token: 0x0600E803 RID: 59395 RVA: 0x00156BAF File Offset: 0x00154DAF
		// (set) Token: 0x0600E804 RID: 59396 RVA: 0x00156BC8 File Offset: 0x00154DC8
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

		// Token: 0x17003809 RID: 14345
		// (get) Token: 0x0600E805 RID: 59397 RVA: 0x00156BF8 File Offset: 0x00154DF8
		// (set) Token: 0x0600E806 RID: 59398 RVA: 0x00156C08 File Offset: 0x00154E08
		public unsafe ETranslucencyType TranslucencyType
		{
			get
			{
				return (ETranslucencyType)(*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TranslucencyType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_TranslucencyType) = (byte)value;
			}
		}

		// Token: 0x1700380A RID: 14346
		// (get) Token: 0x0600E807 RID: 59399 RVA: 0x00156C19 File Offset: 0x00154E19
		// (set) Token: 0x0600E808 RID: 59400 RVA: 0x00156C29 File Offset: 0x00154E29
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

		// Token: 0x1700380B RID: 14347
		// (get) Token: 0x0600E809 RID: 59401 RVA: 0x00156C3A File Offset: 0x00154E3A
		// (set) Token: 0x0600E80A RID: 59402 RVA: 0x00156C4A File Offset: 0x00154E4A
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

		// Token: 0x1700380C RID: 14348
		// (get) Token: 0x0600E80B RID: 59403 RVA: 0x00156C5B File Offset: 0x00154E5B
		// (set) Token: 0x0600E80C RID: 59404 RVA: 0x00156C6B File Offset: 0x00154E6B
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

		// Token: 0x1700380D RID: 14349
		// (get) Token: 0x0600E80D RID: 59405 RVA: 0x00156C7C File Offset: 0x00154E7C
		// (set) Token: 0x0600E80E RID: 59406 RVA: 0x00156C8C File Offset: 0x00154E8C
		public unsafe EReflectedAndRefractedRayTracedShadows RayTracingTranslucencyShadows
		{
			get
			{
				return (EReflectedAndRefractedRayTracedShadows)(*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingTranslucencyShadows));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_RayTracingTranslucencyShadows) = (byte)value;
			}
		}

		// Token: 0x1700380E RID: 14350
		// (get) Token: 0x0600E80F RID: 59407 RVA: 0x00156C9D File Offset: 0x00154E9D
		// (set) Token: 0x0600E810 RID: 59408 RVA: 0x00156CB6 File Offset: 0x00154EB6
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

		// Token: 0x1700380F RID: 14351
		// (get) Token: 0x0600E811 RID: 59409 RVA: 0x00156CE6 File Offset: 0x00154EE6
		// (set) Token: 0x0600E812 RID: 59410 RVA: 0x00156CF6 File Offset: 0x00154EF6
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

		// Token: 0x17003810 RID: 14352
		// (get) Token: 0x0600E813 RID: 59411 RVA: 0x00156D07 File Offset: 0x00154F07
		// (set) Token: 0x0600E814 RID: 59412 RVA: 0x00156D17 File Offset: 0x00154F17
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

		// Token: 0x17003811 RID: 14353
		// (get) Token: 0x0600E815 RID: 59413 RVA: 0x00156D28 File Offset: 0x00154F28
		// (set) Token: 0x0600E816 RID: 59414 RVA: 0x00156D38 File Offset: 0x00154F38
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

		// Token: 0x17003812 RID: 14354
		// (get) Token: 0x0600E817 RID: 59415 RVA: 0x00156D49 File Offset: 0x00154F49
		// (set) Token: 0x0600E818 RID: 59416 RVA: 0x00156D59 File Offset: 0x00154F59
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

		// Token: 0x17003813 RID: 14355
		// (get) Token: 0x0600E819 RID: 59417 RVA: 0x00156D6A File Offset: 0x00154F6A
		// (set) Token: 0x0600E81A RID: 59418 RVA: 0x00156D7A File Offset: 0x00154F7A
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

		// Token: 0x17003814 RID: 14356
		// (get) Token: 0x0600E81B RID: 59419 RVA: 0x00156D8B File Offset: 0x00154F8B
		// (set) Token: 0x0600E81C RID: 59420 RVA: 0x00156D9B File Offset: 0x00154F9B
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

		// Token: 0x17003815 RID: 14357
		// (get) Token: 0x0600E81D RID: 59421 RVA: 0x00156DAC File Offset: 0x00154FAC
		// (set) Token: 0x0600E81E RID: 59422 RVA: 0x00156DBC File Offset: 0x00154FBC
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

		// Token: 0x17003816 RID: 14358
		// (get) Token: 0x0600E81F RID: 59423 RVA: 0x00156DCD File Offset: 0x00154FCD
		// (set) Token: 0x0600E820 RID: 59424 RVA: 0x00156DE1 File Offset: 0x00154FE1
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

		// Token: 0x17003817 RID: 14359
		// (get) Token: 0x0600E821 RID: 59425 RVA: 0x00156DF6 File Offset: 0x00154FF6
		// (set) Token: 0x0600E822 RID: 59426 RVA: 0x00156E06 File Offset: 0x00155006
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

		// Token: 0x17003818 RID: 14360
		// (get) Token: 0x0600E823 RID: 59427 RVA: 0x00156E17 File Offset: 0x00155017
		// (set) Token: 0x0600E824 RID: 59428 RVA: 0x00156E27 File Offset: 0x00155027
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

		// Token: 0x17003819 RID: 14361
		// (get) Token: 0x0600E825 RID: 59429 RVA: 0x00156E38 File Offset: 0x00155038
		// (set) Token: 0x0600E826 RID: 59430 RVA: 0x00156E4C File Offset: 0x0015504C
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

		// Token: 0x1700381A RID: 14362
		// (get) Token: 0x0600E827 RID: 59431 RVA: 0x00156E61 File Offset: 0x00155061
		// (set) Token: 0x0600E828 RID: 59432 RVA: 0x00156E75 File Offset: 0x00155075
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

		// Token: 0x1700381B RID: 14363
		// (get) Token: 0x0600E829 RID: 59433 RVA: 0x00156E8A File Offset: 0x0015508A
		// (set) Token: 0x0600E82A RID: 59434 RVA: 0x00156E9A File Offset: 0x0015509A
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

		// Token: 0x1700381C RID: 14364
		// (get) Token: 0x0600E82B RID: 59435 RVA: 0x00156EAB File Offset: 0x001550AB
		// (set) Token: 0x0600E82C RID: 59436 RVA: 0x00156EBB File Offset: 0x001550BB
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

		// Token: 0x1700381D RID: 14365
		// (get) Token: 0x0600E82D RID: 59437 RVA: 0x00156ECC File Offset: 0x001550CC
		// (set) Token: 0x0600E82E RID: 59438 RVA: 0x00156EDC File Offset: 0x001550DC
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

		// Token: 0x1700381E RID: 14366
		// (get) Token: 0x0600E82F RID: 59439 RVA: 0x00156EED File Offset: 0x001550ED
		// (set) Token: 0x0600E830 RID: 59440 RVA: 0x00156EFD File Offset: 0x001550FD
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

		// Token: 0x1700381F RID: 14367
		// (get) Token: 0x0600E831 RID: 59441 RVA: 0x00156F0E File Offset: 0x0015510E
		// (set) Token: 0x0600E832 RID: 59442 RVA: 0x00156F1E File Offset: 0x0015511E
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

		// Token: 0x17003820 RID: 14368
		// (get) Token: 0x0600E833 RID: 59443 RVA: 0x00156F2F File Offset: 0x0015512F
		// (set) Token: 0x0600E834 RID: 59444 RVA: 0x00156F3F File Offset: 0x0015513F
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

		// Token: 0x17003821 RID: 14369
		// (get) Token: 0x0600E835 RID: 59445 RVA: 0x00156F50 File Offset: 0x00155150
		// (set) Token: 0x0600E836 RID: 59446 RVA: 0x00156F60 File Offset: 0x00155160
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

		// Token: 0x17003822 RID: 14370
		// (get) Token: 0x0600E837 RID: 59447 RVA: 0x00156F71 File Offset: 0x00155171
		// (set) Token: 0x0600E838 RID: 59448 RVA: 0x00156F81 File Offset: 0x00155181
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

		// Token: 0x17003823 RID: 14371
		// (get) Token: 0x0600E839 RID: 59449 RVA: 0x00156F92 File Offset: 0x00155192
		// (set) Token: 0x0600E83A RID: 59450 RVA: 0x00156FA2 File Offset: 0x001551A2
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

		// Token: 0x17003824 RID: 14372
		// (get) Token: 0x0600E83B RID: 59451 RVA: 0x00156FB3 File Offset: 0x001551B3
		// (set) Token: 0x0600E83C RID: 59452 RVA: 0x00156FC3 File Offset: 0x001551C3
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

		// Token: 0x17003825 RID: 14373
		// (get) Token: 0x0600E83D RID: 59453 RVA: 0x00156FD4 File Offset: 0x001551D4
		// (set) Token: 0x0600E83E RID: 59454 RVA: 0x00156FE4 File Offset: 0x001551E4
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

		// Token: 0x17003826 RID: 14374
		// (get) Token: 0x0600E83F RID: 59455 RVA: 0x00156FF5 File Offset: 0x001551F5
		// (set) Token: 0x0600E840 RID: 59456 RVA: 0x00157005 File Offset: 0x00155205
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

		// Token: 0x17003827 RID: 14375
		// (get) Token: 0x0600E841 RID: 59457 RVA: 0x00157016 File Offset: 0x00155216
		// (set) Token: 0x0600E842 RID: 59458 RVA: 0x00157026 File Offset: 0x00155226
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

		// Token: 0x17003828 RID: 14376
		// (get) Token: 0x0600E843 RID: 59459 RVA: 0x00157037 File Offset: 0x00155237
		// (set) Token: 0x0600E844 RID: 59460 RVA: 0x00157047 File Offset: 0x00155247
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

		// Token: 0x17003829 RID: 14377
		// (get) Token: 0x0600E845 RID: 59461 RVA: 0x00157058 File Offset: 0x00155258
		// (set) Token: 0x0600E846 RID: 59462 RVA: 0x00157068 File Offset: 0x00155268
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

		// Token: 0x1700382A RID: 14378
		// (get) Token: 0x0600E847 RID: 59463 RVA: 0x00157079 File Offset: 0x00155279
		// (set) Token: 0x0600E848 RID: 59464 RVA: 0x00157089 File Offset: 0x00155289
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

		// Token: 0x1700382B RID: 14379
		// (get) Token: 0x0600E849 RID: 59465 RVA: 0x0015709A File Offset: 0x0015529A
		// (set) Token: 0x0600E84A RID: 59466 RVA: 0x001570AA File Offset: 0x001552AA
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

		// Token: 0x1700382C RID: 14380
		// (get) Token: 0x0600E84B RID: 59467 RVA: 0x001570BB File Offset: 0x001552BB
		// (set) Token: 0x0600E84C RID: 59468 RVA: 0x001570CB File Offset: 0x001552CB
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

		// Token: 0x1700382D RID: 14381
		// (get) Token: 0x0600E84D RID: 59469 RVA: 0x001570DC File Offset: 0x001552DC
		// (set) Token: 0x0600E84E RID: 59470 RVA: 0x001570EC File Offset: 0x001552EC
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

		// Token: 0x1700382E RID: 14382
		// (get) Token: 0x0600E84F RID: 59471 RVA: 0x001570FD File Offset: 0x001552FD
		// (set) Token: 0x0600E850 RID: 59472 RVA: 0x00157116 File Offset: 0x00155316
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

		// Token: 0x1700382F RID: 14383
		// (get) Token: 0x0600E851 RID: 59473 RVA: 0x00157146 File Offset: 0x00155346
		// (set) Token: 0x0600E852 RID: 59474 RVA: 0x00157156 File Offset: 0x00155356
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

		// Token: 0x17003830 RID: 14384
		// (get) Token: 0x0600E853 RID: 59475 RVA: 0x00157167 File Offset: 0x00155367
		// (set) Token: 0x0600E854 RID: 59476 RVA: 0x00157177 File Offset: 0x00155377
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

		// Token: 0x17003831 RID: 14385
		// (get) Token: 0x0600E855 RID: 59477 RVA: 0x00157188 File Offset: 0x00155388
		// (set) Token: 0x0600E856 RID: 59478 RVA: 0x00157198 File Offset: 0x00155398
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

		// Token: 0x17003832 RID: 14386
		// (get) Token: 0x0600E857 RID: 59479 RVA: 0x001571A9 File Offset: 0x001553A9
		// (set) Token: 0x0600E858 RID: 59480 RVA: 0x001571B9 File Offset: 0x001553B9
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

		// Token: 0x17003833 RID: 14387
		// (get) Token: 0x0600E859 RID: 59481 RVA: 0x001571CA File Offset: 0x001553CA
		// (set) Token: 0x0600E85A RID: 59482 RVA: 0x001571DA File Offset: 0x001553DA
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

		// Token: 0x17003834 RID: 14388
		// (get) Token: 0x0600E85B RID: 59483 RVA: 0x001571EB File Offset: 0x001553EB
		// (set) Token: 0x0600E85C RID: 59484 RVA: 0x001571FB File Offset: 0x001553FB
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

		// Token: 0x17003835 RID: 14389
		// (get) Token: 0x0600E85D RID: 59485 RVA: 0x0015720C File Offset: 0x0015540C
		// (set) Token: 0x0600E85E RID: 59486 RVA: 0x0015721C File Offset: 0x0015541C
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

		// Token: 0x17003836 RID: 14390
		// (get) Token: 0x0600E85F RID: 59487 RVA: 0x0015722D File Offset: 0x0015542D
		// (set) Token: 0x0600E860 RID: 59488 RVA: 0x0015723D File Offset: 0x0015543D
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

		// Token: 0x17003837 RID: 14391
		// (get) Token: 0x0600E861 RID: 59489 RVA: 0x0015724E File Offset: 0x0015544E
		// (set) Token: 0x0600E862 RID: 59490 RVA: 0x0015725E File Offset: 0x0015545E
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

		// Token: 0x17003838 RID: 14392
		// (get) Token: 0x0600E863 RID: 59491 RVA: 0x0015726F File Offset: 0x0015546F
		// (set) Token: 0x0600E864 RID: 59492 RVA: 0x0015727F File Offset: 0x0015547F
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

		// Token: 0x17003839 RID: 14393
		// (get) Token: 0x0600E865 RID: 59493 RVA: 0x00157290 File Offset: 0x00155490
		// (set) Token: 0x0600E866 RID: 59494 RVA: 0x001572A0 File Offset: 0x001554A0
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

		// Token: 0x1700383A RID: 14394
		// (get) Token: 0x0600E867 RID: 59495 RVA: 0x001572B1 File Offset: 0x001554B1
		// (set) Token: 0x0600E868 RID: 59496 RVA: 0x001572C1 File Offset: 0x001554C1
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

		// Token: 0x1700383B RID: 14395
		// (get) Token: 0x0600E869 RID: 59497 RVA: 0x001572D2 File Offset: 0x001554D2
		// (set) Token: 0x0600E86A RID: 59498 RVA: 0x001572E2 File Offset: 0x001554E2
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

		// Token: 0x1700383C RID: 14396
		// (get) Token: 0x0600E86B RID: 59499 RVA: 0x001572F3 File Offset: 0x001554F3
		// (set) Token: 0x0600E86C RID: 59500 RVA: 0x00157307 File Offset: 0x00155507
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

		// Token: 0x1700383D RID: 14397
		// (get) Token: 0x0600E86D RID: 59501 RVA: 0x0015731C File Offset: 0x0015551C
		// (set) Token: 0x0600E86E RID: 59502 RVA: 0x0015732C File Offset: 0x0015552C
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

		// Token: 0x1700383E RID: 14398
		// (get) Token: 0x0600E86F RID: 59503 RVA: 0x0015733D File Offset: 0x0015553D
		// (set) Token: 0x0600E870 RID: 59504 RVA: 0x0015734D File Offset: 0x0015554D
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

		// Token: 0x1700383F RID: 14399
		// (get) Token: 0x0600E871 RID: 59505 RVA: 0x0015735E File Offset: 0x0015555E
		// (set) Token: 0x0600E872 RID: 59506 RVA: 0x0015736E File Offset: 0x0015556E
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

		// Token: 0x17003840 RID: 14400
		// (get) Token: 0x0600E873 RID: 59507 RVA: 0x0015737F File Offset: 0x0015557F
		// (set) Token: 0x0600E874 RID: 59508 RVA: 0x0015738F File Offset: 0x0015558F
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

		// Token: 0x17003841 RID: 14401
		// (get) Token: 0x0600E875 RID: 59509 RVA: 0x001573A0 File Offset: 0x001555A0
		// (set) Token: 0x0600E876 RID: 59510 RVA: 0x001573B0 File Offset: 0x001555B0
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

		// Token: 0x17003842 RID: 14402
		// (get) Token: 0x0600E877 RID: 59511 RVA: 0x001573C1 File Offset: 0x001555C1
		// (set) Token: 0x0600E878 RID: 59512 RVA: 0x001573D1 File Offset: 0x001555D1
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

		// Token: 0x17003843 RID: 14403
		// (get) Token: 0x0600E879 RID: 59513 RVA: 0x001573E2 File Offset: 0x001555E2
		// (set) Token: 0x0600E87A RID: 59514 RVA: 0x001573F6 File Offset: 0x001555F6
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

		// Token: 0x17003844 RID: 14404
		// (get) Token: 0x0600E87B RID: 59515 RVA: 0x0015740B File Offset: 0x0015560B
		// (set) Token: 0x0600E87C RID: 59516 RVA: 0x0015741B File Offset: 0x0015561B
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

		// Token: 0x17003845 RID: 14405
		// (get) Token: 0x0600E87D RID: 59517 RVA: 0x0015742C File Offset: 0x0015562C
		// (set) Token: 0x0600E87E RID: 59518 RVA: 0x0015743C File Offset: 0x0015563C
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

		// Token: 0x17003846 RID: 14406
		// (get) Token: 0x0600E87F RID: 59519 RVA: 0x0015744D File Offset: 0x0015564D
		// (set) Token: 0x0600E880 RID: 59520 RVA: 0x00157461 File Offset: 0x00155661
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

		// Token: 0x17003847 RID: 14407
		// (get) Token: 0x0600E881 RID: 59521 RVA: 0x00157476 File Offset: 0x00155676
		// (set) Token: 0x0600E882 RID: 59522 RVA: 0x00157486 File Offset: 0x00155686
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

		// Token: 0x17003848 RID: 14408
		// (get) Token: 0x0600E883 RID: 59523 RVA: 0x00157497 File Offset: 0x00155697
		// (set) Token: 0x0600E884 RID: 59524 RVA: 0x001574A7 File Offset: 0x001556A7
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

		// Token: 0x17003849 RID: 14409
		// (get) Token: 0x0600E885 RID: 59525 RVA: 0x001574B8 File Offset: 0x001556B8
		// (set) Token: 0x0600E886 RID: 59526 RVA: 0x001574C8 File Offset: 0x001556C8
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

		// Token: 0x1700384A RID: 14410
		// (get) Token: 0x0600E887 RID: 59527 RVA: 0x001574D9 File Offset: 0x001556D9
		// (set) Token: 0x0600E888 RID: 59528 RVA: 0x001574E9 File Offset: 0x001556E9
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

		// Token: 0x1700384B RID: 14411
		// (get) Token: 0x0600E889 RID: 59529 RVA: 0x001574FA File Offset: 0x001556FA
		// (set) Token: 0x0600E88A RID: 59530 RVA: 0x0015750A File Offset: 0x0015570A
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

		// Token: 0x1700384C RID: 14412
		// (get) Token: 0x0600E88B RID: 59531 RVA: 0x0015751B File Offset: 0x0015571B
		// (set) Token: 0x0600E88C RID: 59532 RVA: 0x0015752B File Offset: 0x0015572B
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

		// Token: 0x1700384D RID: 14413
		// (get) Token: 0x0600E88D RID: 59533 RVA: 0x0015753C File Offset: 0x0015573C
		// (set) Token: 0x0600E88E RID: 59534 RVA: 0x00157550 File Offset: 0x00155750
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

		// Token: 0x1700384E RID: 14414
		// (get) Token: 0x0600E88F RID: 59535 RVA: 0x00157565 File Offset: 0x00155765
		// (set) Token: 0x0600E890 RID: 59536 RVA: 0x00157575 File Offset: 0x00155775
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

		// Token: 0x1700384F RID: 14415
		// (get) Token: 0x0600E891 RID: 59537 RVA: 0x00157586 File Offset: 0x00155786
		// (set) Token: 0x0600E892 RID: 59538 RVA: 0x00157596 File Offset: 0x00155796
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

		// Token: 0x17003850 RID: 14416
		// (get) Token: 0x0600E893 RID: 59539 RVA: 0x001575A8 File Offset: 0x001557A8
		// (set) Token: 0x0600E894 RID: 59540 RVA: 0x001575EB File Offset: 0x001557EB
		[Nullable(1)]
		public FWeightedBlendables WeightedBlendables
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FWeightedBlendables result;
				if ((result = this._WeightedBlendables) == null)
				{
					result = (this._WeightedBlendables = new FWeightedBlendables(base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_WeightedBlendables, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FWeightedBlendables.StaticStruct(), base.NativePtr + (IntPtr)FPostProcessSettings.__PropertyOffset_WeightedBlendables, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600E895 RID: 59541 RVA: 0x0015760C File Offset: 0x0015580C
		public FPostProcessSettings()
		{
		}

		// Token: 0x0600E896 RID: 59542 RVA: 0x00157614 File Offset: 0x00155814
		[NullableContext(1)]
		public FPostProcessSettings(bool bOverride_WhiteTemp, bool bOverride_WhiteTint, bool bOverride_ColorSaturation, bool bOverride_ColorContrast, bool bOverride_ColorGamma, bool bOverride_ColorGain, bool bOverride_ColorOffset, bool bOverride_ColorSaturationShadows, bool bOverride_ColorContrastShadows, bool bOverride_ColorGammaShadows, bool bOverride_ColorGainShadows, bool bOverride_ColorOffsetShadows, bool bOverride_ColorSaturationMidtones, bool bOverride_ColorContrastMidtones, bool bOverride_ColorGammaMidtones, bool bOverride_ColorGainMidtones, bool bOverride_ColorOffsetMidtones, bool bOverride_ColorSaturationHighlights, bool bOverride_ColorContrastHighlights, bool bOverride_ColorGammaHighlights, bool bOverride_ColorGainHighlights, bool bOverride_ColorOffsetHighlights, bool bOverride_ColorCorrectionShadowsMax, bool bOverride_ColorCorrectionHighlightsMin, bool bOverride_BlueCorrection, bool bOverride_ExpandGamut, bool bOverride_ToneCurveAmount, bool bOverride_FilmWhitePoint, bool bOverride_FilmSaturation, bool bOverride_FilmChannelMixerRed, bool bOverride_FilmChannelMixerGreen, bool bOverride_FilmChannelMixerBlue, bool bOverride_FilmContrast, bool bOverride_FilmDynamicRange, bool bOverride_FilmHealAmount, bool bOverride_FilmToeAmount, bool bOverride_FilmShadowTint, bool bOverride_FilmShadowTintBlend, bool bOverride_FilmShadowTintAmount, bool bOverride_FilmSlope, bool bOverride_FilmToe, bool bOverride_FilmShoulder, bool bOverride_FilmBlackClip, bool bOverride_FilmWhiteClip, bool bOverride_SceneColorTint, bool bOverride_DecalSaturation, bool bOverride_DecalOpacity, bool bOverride_TranslucentColorTint, bool bOverride_SceneColorDesaturate, bool bOverride_SceneColorClear, bool bOverride_SceneColorClearColor, bool bOverride_SceneColorClearCenter, bool bOverride_SceneColorClearRadius, bool bOverride_SceneColorClearFadeDistance, bool bOverride_TranslucentColorDesaturate, bool bOverride_FightTranslucentNoDesaturate, bool bOverride_SceneTranslucentColorTint, bool bOverride_SceneEmissiveTint, bool bOverride_SceneTranslucentColorDesaturate, bool bOverride_EnableSPD, bool bOverride_SceneFringeIntensity, bool bOverride_ChromaticAberrationStartOffset, bool bOverride_BaoChromaticAberrationIntensity, bool bOverride_BaoChromaticAberrationMaskCenter, bool bOverride_BaoChromaticAberrationYScale, bool bOverride_BaoChromaticAberrationYPan, bool bOverride_bMegaLights, bool bOverride_AmbientCubemapTint, bool bOverride_AmbientCubemapIntensity, bool bOverride_BloomMethod, bool bOverride_BloomIntensity, bool bOverride_KuroFoliageMaterialAO, bool bOverride_KuroFoliageScreenSpaceAO, bool bOverride_UseFixCharacterRim, bool bOverride_FixCharacterRimAngleV, bool bOverride_FixCharacterRimAngleH, bool bOverride_UseCustomRim, bool bOverride_CustomRimColor_Stencil1, bool bOverride_FixCharacterRimAngleV_Stencil1, bool bOverride_FixCharacterRimAngleH_Stencil1, bool bOverride_CustomRimColor_Stencil2, bool bOverride_FixCharacterRimAngleV_Stencil2, bool bOverride_FixCharacterRimAngleH_Stencil2, bool bOverride_CustomRimColor_Stencil3, bool bOverride_FixCharacterRimAngleV_Stencil3, bool bOverride_FixCharacterRimAngleH_Stencil3, bool bOverride_KuroBloomIntensity, bool bOverride_KuroBloomThreshold, bool bOverride_EnableSplitCharBloom, bool bOverride_KuroCharacterBloomIntensity, bool bOverride_KuroCharacterBloomThreshold, bool bOverride_SunDirBloomIntensity, bool bOverride_KuroBloomCombineParameter, bool bOverride_KuroBloomStreakIntensity, bool bOverride_KuroBloomStreakThreshold, bool bOverride_TranslucentBloomStreakIntensity, bool bOverride_TranslucentBloomStreakThreshold, bool bOverride_KuroBloomStreakLength, bool bOverride_KuroBloomStreakMipLevel, bool bOverride_KuroBloomStreakRatio, bool bOverride_KuroBloomStreakOrientation, bool bOverride_BlackWhiteFlashIntensity, bool bOverride_BlackWhiteFlashFactor, bool bOverride_BlackWhiteFlashThreshold, bool bOverride_BlackWhiteFlashBlackAreaColor, bool bOverride_BlackWhiteFlashWhiteAreaColor, bool bOverride_KuroRadialBlurIntensity, bool bOverride_KuroRadialBlurRadius, bool bOverride_KuroRadialBlurHardness, bool bOverride_KuroRadialBlurCenter, bool bOverride_UseClampRadialBlurCenter, bool bOverride_KuroRadialBlurPassNumber, bool bOverride_KuroRadialBlurSampleNumber, bool bOverride_KuroRadialBlurMask, bool bOverride_KuroRadialBlurMaskScale, bool bOverride_KuroRadialBlurMaskOffset, bool bOverride_ScreenSoftIntensity, bool bOverride_ScreenSoftThreshold, bool bOverride_ScreenSoftDistance, bool bOverride_ScreenSoftSkyBloomCompensation, bool bOverride_ScreenSoftRange, bool bOverride_ScreenSoftOverflowDistance, bool bOverride_ScreenSoftSunExposure, bool bOverride_ScreenSoftHighQuality, bool bOverride_MobileScreenSoftIntensity, bool bOverride_MobileScreenSoftThreshold, bool bOverride_MobileScreenSoftDistance, bool bOverride_ScreenLeakTexture, bool bOverride_ScreenLeakTextureIntensity, bool bOverride_FFTIntensity, bool bOverride_FFTThreshold, bool bOverride_FFTTexture, bool bOverride_FFTScatterDispersion, bool bOverride_FFTSize, bool bOverride_FFTPreFilterMin, bool bOverride_FFTPreFilterMax, bool bOverride_FFTPreFilterMult, bool bOverride_FFTBufferScale, bool bOverride_FFTDistance, bool bOverride_FFTHidenSky, bool bOverride_FFTHidenTranslucent, bool bOverride_FFTBeforeTranslucency, bool bOverride_ToonFFTIntensity, bool bOverride_ToonFFTThreshold, bool bOverride_ToonFFTTexture, bool bOverride_ToonFFTScatterDispersion, bool bOverride_ToonFFTSize, bool bOverride_SeparateTranslucencyBlurSize, bool bOverride_LightFadeScale, bool bOverride_KuroDataDistortionNoiseIntensity, bool bOverride_KuroDataDistortionNoiseTexture, bool bOverride_KuroDataDistortionNoiseTextureUVScaleBias, bool bOverride_KuroDataDistortionNoiseSize, bool bOverride_KuroDataDistortionNoiseBias, bool bOverride_KuroDataDistortionSignalIntensity, bool bOverride_KuroDataDistortionRandomColorSize, bool bOverride_KuroDataDistortionSinWaveParameters, bool bOverride_KuroDataDistortionColorTint, bool bOverride_BloomThreshold, bool bOverride_Bloom1Tint, bool bOverride_Bloom1Size, bool bOverride_Bloom2Size, bool bOverride_Bloom2Tint, bool bOverride_Bloom3Tint, bool bOverride_Bloom3Size, bool bOverride_Bloom4Tint, bool bOverride_Bloom4Size, bool bOverride_Bloom5Tint, bool bOverride_Bloom5Size, bool bOverride_Bloom6Tint, bool bOverride_Bloom6Size, bool bOverride_BloomSizeScale, bool bOverride_BloomConvolutionPreFilter_DEPRECATED, bool bOverride_BloomDirtMaskIntensity, bool bOverride_BloomDirtMaskTint, bool bOverride_BloomDirtMask, bool bOverride_CameraShutterSpeed, bool bOverride_CameraISO, bool bOverride_AutoExposureMethod, bool bOverride_AutoExposureLowPercent, bool bOverride_AutoExposureHighPercent, bool bOverride_AutoExposureMinBrightness, bool bOverride_AutoExposureMaxBrightness, bool bOverride_AutoExposureCalibrationConstant_DEPRECATED, bool bOverride_AutoExposureSpeedUp, bool bOverride_AutoExposureSpeedDown, bool bOverride_AutoExposureBias, bool bOverride_AutoExposureBiasCurve, bool bOverride_AutoExposureMeterMask, bool bOverride_AutoExposureApplyPhysicalCameraExposure, bool bOverride_HistogramLogMin, bool bOverride_HistogramLogMax, bool bOverride_LocalExposureMethod, bool bOverride_LocalExposureContrastScale_DEPRECATED, bool bOverride_LocalExposureHighlightContrastScale, bool bOverride_LocalExposureShadowContrastScale, bool bOverride_LocalExposureHighlightContrastCurve, bool bOverride_LocalExposureShadowContrastCurve, bool bOverride_LocalExposureHighlightThreshold, bool bOverride_LocalExposureShadowThreshold, bool bOverride_LocalExposureDetailStrength, bool bOverride_LocalExposureBlurredLuminanceBlend, bool bOverride_LocalExposureBlurredLuminanceKernelSizePercent, bool bOverride_LocalExposureMiddleGreyBias, bool bOverride_LensFlareIntensity, bool bOverride_LensFlareTint, bool bOverride_LensFlareTints, bool bOverride_LensFlareBokehSize, bool bOverride_LensFlareBokehShape, bool bOverride_LensFlareThreshold, bool bOverride_LensFlareOnlySun, bool bOverride_LensFlareSunRange, bool bOverride_LensFlareSunPosition, bool bOverride_VignetteIntensity, bool bOverride_VignetteHardness, bool bOverride_VignetteXScale, bool bOverride_VignetteYScale, bool bOverride_VignetteXPos, bool bOverride_VignetteYPos, bool bOverride_VignetteColor, bool bOverride_VignetteGain, bool bOverride_EffectVignetteIntensity, bool bOverride_EffectVignetteHardness, bool bOverride_EffectVignetteXScale, bool bOverride_EffectVignetteYScale, bool bOverride_EffectVignetteXPos, bool bOverride_EffectVignetteYPos, bool bOverride_EffectVignetteColor, bool bOverride_EffectVignetteGain, bool bOverride_GrainIntensity, bool bOverride_GrainJitter, bool bOverride_GrainColorful, bool bOverride_MainCenterMask, bool bOverride_MainCenterMaskRadius, bool bOverride_MainCenterMaskHardness, bool bOverride_MainStartDistance, bool bOverride_MainCharacterIntensity, bool bOverride_VintageColorIntensity, bool bOverride_VintageColorBlackPoint, bool bOverride_VintageColorWhitePoint, bool bOverride_VHSLinesColorIntensity, bool bOverride_VHSLinesDistortIntensity, bool bOverride_VHSEffectIntensity, bool bOverride_VHSSpecklesIntensity, bool bOverride_VHSSpecklesAmount, bool bOverride_VHSSpecklesSize, bool bOverride_CRTDistortion, bool bOverride_VintageColorCenterMask, bool bOverride_VintageColorStartDistance, bool bOverride_VintageColorCharacterIntensity, bool bOverride_VHSLinesCenterMask, bool bOverride_VHSLinesStartDistance, bool bOverride_VHSLinesCharacterIntensity, bool bOverride_VHSEffectCenterMask, bool bOverride_VHSEffectStartDistance, bool bOverride_VHSEffectCharacterIntensity, bool bOverride_VHSSpecklesCenterMask, bool bOverride_VHSSpecklesStartDistance, bool bOverride_VHSSpecklesCharacterIntensity, bool bOverride_AmbientOcclusionIntensity, bool bOverride_AmbientOcclusionStaticFraction, bool bOverride_AmbientOcclusionRadius, bool bOverride_AmbientOcclusionFadeDistance, bool bOverride_AmbientOcclusionFadeRadius, bool bOverride_AmbientOcclusionDistance_DEPRECATED, bool bOverride_AmbientOcclusionRadiusInWS, bool bOverride_AmbientOcclusionPower, bool bOverride_AmbientOcclusionBias, bool bOverride_AmbientOcclusionQuality, bool bOverride_AmbientOcclusionMipBlend, bool bOverride_AmbientOcclusionMipScale, bool bOverride_AmbientOcclusionMipThreshold, bool bOverride_AmbientOcclusionTemporalBlendWeight, bool bOverride_RayTracingAO, bool bOverride_RayTracingAOSamplesPerPixel, bool bOverride_RayTracingAOIntensity, bool bOverride_RayTracingAORadius, bool bOverride_LPVIntensity, bool bOverride_LPVDirectionalOcclusionIntensity, bool bOverride_LPVDirectionalOcclusionRadius, bool bOverride_LPVDiffuseOcclusionExponent, bool bOverride_LPVSpecularOcclusionExponent, bool bOverride_LPVDiffuseOcclusionIntensity, bool bOverride_LPVSpecularOcclusionIntensity, bool bOverride_LPVSize, bool bOverride_LPVSecondaryOcclusionIntensity, bool bOverride_LPVSecondaryBounceIntensity, bool bOverride_LPVGeometryVolumeBias, bool bOverride_LPVVplInjectionBias, bool bOverride_LPVEmissiveInjectionIntensity, bool bOverride_LPVFadeRange, bool bOverride_LPVDirectionalOcclusionFadeRange, bool bOverride_LumenSkylightLeaking, bool bOverride_IndirectLightingColor, bool bOverride_IndirectLightingIntensity, bool bOverride_ColorGradingIntensity, bool bOverride_ColorGradingLUT, bool bOverride_DepthOfFieldFocalDistance, bool bOverride_DepthOfFieldFstop, bool bOverride_DepthOfFieldMinFstop, bool bOverride_DepthOfFieldBladeCount, bool bOverride_DepthOfFieldForegroundBlur, bool bOverride_DepthOfFieldSensorWidth, bool bOverride_DepthOfFieldDepthBlurRadius, bool bOverride_DepthOfFieldDepthBlurAmount, bool bOverride_DepthOfFieldFocalRegion, bool bOverride_DepthOfFieldNearTransitionRegion, bool bOverride_DepthOfFieldFarTransitionRegion, bool bOverride_DepthOfFieldScale, bool bOverride_DepthOfFieldNearBlurSize, bool bOverride_DepthOfFieldFarBlurSize, bool bOverride_MobileHQGaussian, bool bOverride_KuroDangerToggle, bool bOverride_DepthOfFieldOcclusion, bool bOverride_DepthOfFieldSkyFocusDistance, bool bOverride_DepthOfFieldVignetteSize, bool bOverride_MotionBlurAmount, bool bOverride_MotionBlurMax, bool bOverride_MotionBlurTargetFPS, bool bOverride_MotionBlurPerObjectSize, bool bOverride_ScreenPercentage, bool bOverride_MotionBlurCharacterMask, bool bOverride_WithOutTranslucent, bool bOverride_StartPosSwitch, bool bOverride_GrayGradationStartPos, bool bOverride_GrayGradationDegree, bool bOverride_GrayLerpWidth, bool bOverride_GrayRampColor, bool bOverride_GrayRampTint, bool bOverride_GrayRampBlendWeight, bool bOverride_SNNIntensity, bool bOverride_SNNRoughnessContrast, bool bOverride_SNNMetallicThreshold, bool bOverride_SNNDepthFade, bool bOverride_SNNFoliageIntensity, bool bOverride_SNNStructureIntensity, bool bOverride_SNNNoiseIntensity, bool bOverride_SNNEnableSharpen, bool bOverride_SNNSharpeness, bool bOverride_SNNSharpenDepthFade, bool bOverride_SSFSIntensity, bool bOverride_SSFSRadius, bool bOverride_SSFSLuminanceWeighting, bool bOverride_SSFSSkyAtmosphereIntensity, bool bOverride_SSFSVolumetricFogILSIntensity, bool bOverride_SSFSKuroVolumetricLightILSIntensity, bool bOverride_SSFSStartDistance, bool bOverride_SSFSMaxDepth, bool bOverride_EnableMobileSSFS, bool bOverride_MobileSSFSFogDensity, bool bOverride_MobileSSFSIntensity, bool bOverride_MobileSSFSRadius, bool bOverride_MobileSSFSStartDistance, bool bOverride_KuroSharpenRadius, bool bOverride_KuroSharpenAmount, bool bOverride_KuroLaplacianAmount, bool bOverride_KuroSharpenIntensity, bool bOverride_KuroToonSharpenIntensity, bool bOverride_KuroSharpenDistance, bool bOverride_TyndallScaLightIntensity, bool bOverride_TyndallDarkIntensity, bool bOverride_TyndallScaLightLength, bool bOverride_TyndallScaLightColor, bool bOverride_TyndallScaLightFade, bool bOverride_TyndallScaLightMode, bool bOverride_TyndallScaNearFade, bool bOverride_TyndallScaDarkFadeDepth, bool bOverride_TyndallScaMaxDepth, bool bOverride_EnableCustomPosition, bool bOverride_TyndallCustomPosition, bool bOverride_KuroVolumetricLightEnable, bool bOverride_KuroVolumetricLightIntensity, bool bOverride_KuroVolumetricLightColor, bool bOverride_KuroVolumetricLightPhaseG, bool bOverride_KuroVolumetricLightMaxDistance, bool bOverride_KuroVolumetricLightBlurRadius, bool bOverride_KuroVolumetricLightUseColorMask, bool bOverride_KuroVolumetricLightColorMaskIntensity, bool bOverride_ScreenSpaceReflectionIntensity, bool bOverride_ScreenSpaceReflectionQuality, bool bOverride_ScreenSpaceReflectionMaxRoughness, bool bOverride_KuroTonemapA, bool bOverride_KuroTonemapB, bool bOverride_KuroTonemapC, bool bOverride_KuroTonemapD, bool bOverride_KuroTonemapE, bool bOverride_KuroTonemapF, bool bOverride_UseCharacterMask, bool bOverride_ScreenSpaceReflectionRoughnessScale, bool bOverride_ReflectionsType, bool bOverride_RayTracingReflectionsMaxRoughness, bool bOverride_RayTracingReflectionsMaxBounces, bool bOverride_RayTracingReflectionsSamplesPerPixel, bool bOverride_RayTracingReflectionsShadows, bool bOverride_RayTracingReflectionsTranslucency, bool bOverride_TranslucencyType, bool bOverride_RayTracingTranslucencyMaxRoughness, bool bOverride_RayTracingTranslucencyRefractionRays, bool bOverride_RayTracingTranslucencySamplesPerPixel, bool bOverride_RayTracingTranslucencyShadows, bool bOverride_RayTracingTranslucencyRefraction, bool bOverride_RayTracingGI, bool bOverride_RayTracingGIMaxBounces, bool bOverride_RayTracingGISamplesPerPixel, bool bOverride_PathTracingMaxBounces, bool bOverride_PathTracingSamplesPerPixel, bool bKuroDangerToggle, bool bMobileHQGaussian, bool bOverride_KuroCharacterLUTSplitEnable, bool bOverride_KuroCharacterColorGradingLUT, bool bOverride_KuroCharacterColorGradingLUTLerpIntensity, bool bOverride_KuroColorGradingTextureLUTInterpolationEnable, float KuroTonemapA, float KuroTonemapB, float KuroTonemapC, float KuroTonemapD, float KuroTonemapE, float KuroTonemapF, bool UseCharacterMask, [Nullable(0)] TEnumAsByte<EBloomMethod> BloomMethod, [Nullable(0)] TEnumAsByte<EAutoExposureMethod> AutoExposureMethod, [Nullable(0)] TEnumAsByte<EDepthOfFieldMethod> DepthOfFieldMethod_DEPRECATED, float WhiteTemp, float WhiteTint, FVector4 ColorSaturation, FVector4 ColorContrast, FVector4 ColorGamma, FVector4 ColorGain, FVector4 ColorOffset, FVector4 ColorSaturationClient, FVector4 ColorContrastClient, FVector4 ColorSaturationShadows, FVector4 ColorContrastShadows, FVector4 ColorGammaShadows, FVector4 ColorGainShadows, FVector4 ColorOffsetShadows, FVector4 ColorSaturationMidtones, FVector4 ColorContrastMidtones, FVector4 ColorGammaMidtones, FVector4 ColorGainMidtones, FVector4 ColorOffsetMidtones, FVector4 ColorSaturationHighlights, FVector4 ColorContrastHighlights, FVector4 ColorGammaHighlights, FVector4 ColorGainHighlights, FVector4 ColorOffsetHighlights, float ColorCorrectionHighlightsMin, float ColorCorrectionShadowsMax, float BlueCorrection, float ExpandGamut, float ToneCurveAmount, float FilmSlope, float FilmToe, float FilmShoulder, float FilmBlackClip, float FilmWhiteClip, FLinearColor FilmWhitePoint, FLinearColor FilmShadowTint, float FilmShadowTintBlend, float FilmShadowTintAmount, float FilmSaturation, FLinearColor FilmChannelMixerRed, FLinearColor FilmChannelMixerGreen, FLinearColor FilmChannelMixerBlue, float FilmContrast, float FilmToeAmount, float FilmHealAmount, float FilmDynamicRange, FLinearColor SceneColorTint, float DecalSaturation, float DecalOpacity, FLinearColor TranslucentColorTint, float SceneColorDesaturate, float SceneColorClear, FLinearColor SceneColorClearColor, FVector SceneColorClearCenter, float SceneColorClearRadius, float SceneColorClearFadeDistance, float TranslucentColorDesaturate, bool FightTranslucentNoDesaturate, FLinearColor SceneTranslucentColorTint, FLinearColor SceneEmissiveTint, float SceneTranslucentColorDesaturate, float SeparateTranslucencyBlurSize, bool EnableSPD, float SceneFringeIntensity, float ChromaticAberrationStartOffset, float BaoChromaticAberrationIntensity, float BaoChromaticAberrationMaskCenter, float BaoChromaticAberrationYScale, float BaoChromaticAberrationYPan, float KuroFoliageMaterialAO, float KuroFoliageScreenSpaceAO, bool UseFixCharacterRim, float FixCharacterRimAngleV, float FixCharacterRimAngleH, bool UseCustomRim, FLinearColor CustomRimColor_Stencil1, float FixCharacterRimAngleV_Stencil1, float FixCharacterRimAngleH_Stencil1, FLinearColor CustomRimColor_Stencil2, float FixCharacterRimAngleV_Stencil2, float FixCharacterRimAngleH_Stencil2, FLinearColor CustomRimColor_Stencil3, float FixCharacterRimAngleV_Stencil3, float FixCharacterRimAngleH_Stencil3, float KuroBloomIntensity, float KuroBloomThreshold, bool EnableSplitCharBloom, float KuroCharacterBloomIntensity, float KuroCharacterBloomThreshold, float SunDirBloomIntensity, FVector4 KuroBloomCombineParameter, float KuroBloomStreakIntensity, float KuroBloomStreakThreshold, float TranslucentBloomStreakIntensity, float TranslucentBloomStreakThreshold, float KuroBloomStreakLength, float KuroBloomStreakMipLevel, float KuroBloomStreakRatio, float KuroBloomStreakOrientation, float BlackWhiteFlashIntensity, float BlackWhiteFlashFactor, float BlackWhiteFlashThreshold, FLinearColor BlackWhiteFlashBlackAreaColor, FLinearColor BlackWhiteFlashWhiteAreaColor, float KuroRadialBlurIntensity, FVector2D KuroRadialBlurCenter, bool UseClampRadialBlurCenter, float KuroRadialBlurRadius, float KuroRadialBlurHardness, int KuroRadialBlurPassNumber, int KuroRadialBlurSampleNumber, UTexture KuroRadialBlurMask, FVector2D KuroRadialBlurMaskScale, FVector2D KuroRadialBlurMaskOffset, float ScreenSoftIntensity, float ScreenSoftThreshold, float ScreenSoftDistance, float ScreenSoftSkyBloomCompensation, float ScreenSoftRange, float ScreenSoftOverflowDistance, float ScreenSoftSunExposure, int ScreenSoftHighQuality, float MobileScreenSoftIntensity, float MobileScreenSoftThreshold, float MobileScreenSoftDistance, UTexture ScreenLeakTexture, float ScreenLeakTextureIntensity, float FFTIntensity, float FFTThreshold, UTexture2D FFTTexture, float FFTScatterDispersion, float FFTSize, float FFTPreFilterMin, float FFTPreFilterMax, float FFTPreFilterMult, float FFTBufferScale, float FFTDistance, bool FFTHidenSky, bool FFTHidenTranslucent, bool FFTBeforeTranslucency, float ToonFFTIntensity, float ToonFFTThreshold, UTexture2D ToonFFTTexture, float ToonFFTScatterDispersion, float ToonFFTSize, float LightFadeScale, float KuroDataDistortionNoiseIntensity, UTexture KuroDataDistortionNoiseTexture, FVector4 KuroDataDistortionNoiseTextureUVScaleBias, float KuroDataDistortionNoiseSize, FVector2D KuroDataDistortionNoiseBias, float KuroDataDistortionSignalIntensity, float KuroDataDistortionRandomColorSize, FVector4 KuroDataDistortionSinWaveParameters, FLinearColor KuroDataDistortionColorTint, float BloomIntensity, float BloomThreshold, float BloomSizeScale, float Bloom1Size, float Bloom2Size, float Bloom3Size, float Bloom4Size, float Bloom5Size, float Bloom6Size, FLinearColor Bloom1Tint, FLinearColor Bloom2Tint, FLinearColor Bloom3Tint, FLinearColor Bloom4Tint, FLinearColor Bloom5Tint, FLinearColor Bloom6Tint, FVector BloomConvolutionPreFilter_DEPRECATED, UTexture BloomDirtMask, float BloomDirtMaskIntensity, FLinearColor BloomDirtMaskTint, bool bMegaLights, FLinearColor AmbientCubemapTint, float AmbientCubemapIntensity, UTextureCube AmbientCubemap, float CameraShutterSpeed, float CameraISO, float DepthOfFieldFstop, float DepthOfFieldMinFstop, int DepthOfFieldBladeCount, bool bUseForegroundBlur, float AutoExposureBias, float AutoExposureBiasBackup, bool bOverride_AutoExposureBiasBackup, bool AutoExposureApplyPhysicalCameraExposure, UCurveFloat AutoExposureBiasCurve, UTexture AutoExposureMeterMask, float AutoExposureLowPercent, float AutoExposureHighPercent, float AutoExposureMinBrightness, float AutoExposureMaxBrightness, float AutoExposureSpeedUp, float AutoExposureSpeedDown, float HistogramLogMin, float HistogramLogMax, ELocalExposureMethod LocalExposureMethod, float LocalExposureContrastScale_DEPRECATED, float LocalExposureHighlightContrastScale, float LocalExposureShadowContrastScale, UCurveFloat LocalExposureHighlightContrastCurve, UCurveFloat LocalExposureShadowContrastCurve, float LocalExposureHighlightThreshold, float LocalExposureShadowThreshold, float LocalExposureDetailStrength, float LocalExposureBlurredLuminanceBlend, float LocalExposureBlurredLuminanceKernelSizePercent, float LocalExposureMiddleGreyBias, float AutoExposureCalibrationConstant_DEPRECATED, float LensFlareIntensity, FLinearColor LensFlareTint, float LensFlareBokehSize, float LensFlareThreshold, UTexture LensFlareBokehShape, TArray<FLinearColor> LensFlareTints, bool LensFlareOnlySun, float LensFlareSunRange, FVector4 LensFlareSunPosition, float VignetteIntensity, float VignetteHardness, float VignetteXScale, float VignetteYScale, float VignetteXPos, float VignetteYPos, FLinearColor VignetteColor, float VignetteGain, float EffectVignetteIntensity, float EffectVignetteHardness, float EffectVignetteXScale, float EffectVignetteYScale, float EffectVignetteXPos, float EffectVignetteYPos, FLinearColor EffectVignetteColor, float EffectVignetteGain, float GrainJitter, float GrainIntensity, float GrainColorful, float MainCenterMask, float MainCenterMaskRadius, float MainCenterMaskHardness, float MainStartDistance, float MainCharacterIntensity, float VintageColorIntensity, float VintageColorBlackPoint, float VintageColorWhitePoint, float VHSLinesColorIntensity, float VHSLinesDistortIntensity, float VHSEffectIntensity, float VHSSpecklesIntensity, float VHSSpecklesAmount, float VHSSpecklesSize, float CRTDistortion, float VintageColorCenterMask, float VintageColorStartDistance, float VintageColorCharacterIntensity, float VHSLinesCenterMask, float VHSLinesStartDistance, float VHSLinesCharacterIntensity, float VHSEffectCenterMask, float VHSEffectStartDistance, float VHSEffectCharacterIntensity, float VHSSpecklesCenterMask, float VHSSpecklesStartDistance, float VHSSpecklesCharacterIntensity, float AmbientOcclusionIntensity, float AmbientOcclusionStaticFraction, float AmbientOcclusionRadius, bool AmbientOcclusionRadiusInWS, float AmbientOcclusionFadeDistance, float AmbientOcclusionFadeRadius, float AmbientOcclusionDistance_DEPRECATED, float AmbientOcclusionPower, float AmbientOcclusionBias, float AmbientOcclusionQuality, float AmbientOcclusionMipBlend, float AmbientOcclusionMipScale, float AmbientOcclusionMipThreshold, float AmbientOcclusionTemporalBlendWeight, bool RayTracingAO, int RayTracingAOSamplesPerPixel, float RayTracingAOIntensity, float RayTracingAORadius, float LumenSkylightLeaking, FLinearColor IndirectLightingColor, float IndirectLightingIntensity, bool RayTracingGI_DEPRECATED, ERayTracingGlobalIlluminationType RayTracingGIType, int RayTracingGIMaxBounces, int RayTracingGISamplesPerPixel, float ColorGradingIntensity, UTexture ColorGradingLUT, float DepthOfFieldSensorWidth, float DepthOfFieldFocalDistance, float DepthOfFieldDepthBlurAmount, float DepthOfFieldDepthBlurRadius, float DepthOfFieldFocalRegion, float DepthOfFieldNearTransitionRegion, float DepthOfFieldFarTransitionRegion, float DepthOfFieldScale, float DepthOfFieldNearBlurSize, float DepthOfFieldFarBlurSize, float DepthOfFieldOcclusion, float DepthOfFieldSkyFocusDistance, float DepthOfFieldVignetteSize, float MotionBlurAmount, float MotionBlurMax, int MotionBlurTargetFPS, float MotionBlurPerObjectSize, bool bMotionBlurCharacterMask, float LPVIntensity, float LPVVplInjectionBias, float LPVSize, float LPVSecondaryOcclusionIntensity, float LPVSecondaryBounceIntensity, float LPVGeometryVolumeBias, float LPVEmissiveInjectionIntensity, float LPVDirectionalOcclusionIntensity, float LPVDirectionalOcclusionRadius, float LPVDiffuseOcclusionExponent, float LPVSpecularOcclusionExponent, float LPVDiffuseOcclusionIntensity, float LPVSpecularOcclusionIntensity, EReflectionsType ReflectionsType, float ScreenSpaceReflectionIntensity, float ScreenSpaceReflectionQuality, float ScreenSpaceReflectionMaxRoughness, float RayTracingReflectionsMaxRoughness, int RayTracingReflectionsMaxBounces, int RayTracingReflectionsSamplesPerPixel, EReflectedAndRefractedRayTracedShadows RayTracingReflectionsShadows, bool RayTracingReflectionsTranslucency, ETranslucencyType TranslucencyType, float RayTracingTranslucencyMaxRoughness, int RayTracingTranslucencyRefractionRays, int RayTracingTranslucencySamplesPerPixel, EReflectedAndRefractedRayTracedShadows RayTracingTranslucencyShadows, bool RayTracingTranslucencyRefraction, int PathTracingMaxBounces, int PathTracingSamplesPerPixel, float LPVFadeRange, float LPVDirectionalOcclusionFadeRange, float ScreenPercentage, bool WithOutTranslucent, bool StartPosSwitch, FVector4 GrayGradationStartPos, float GrayGradationDegree, float GrayLerpWidth, UTexture2D GrayRampColor, FLinearColor GrayRampTint, float GrayRampBlendWeight, int SNNIntensity, float SNNRoughnessContrast, float SNNMetallicThreshold, float SNNDepthFade, float SNNFoliageIntensity, float SNNStructureIntensity, float SNNNoiseIntensity, bool SNNEnableSharpen, float SNNSharpeness, float SNNSharpenDepthFade, float SSFSIntensity, float SSFSRadius, bool SSFSLuminanceWeighting, float SSFSSkyAtmosphereIntensity, float SSFSVolumetricFogILSIntensity, float SSFSKuroVolumetricLightILSIntensity, float SSFSStartDistance, float SSFSMaxDepth, bool EnableMobileSSFS, float MobileSSFSFogDensity, float MobileSSFSIntensity, float MobileSSFSRadius, float MobileSSFSStartDistance, float KuroSharpenRadius, float KuroSharpenAmount, float KuroLaplacianAmount, float KuroSharpenIntensity, float KuroToonSharpenIntensity, float KuroSharpenDistance, float TyndallScaLightIntensity, float TyndallDarkIntensity, float TyndallScaLightLength, FLinearColor TyndallScaLightColor, float TyndallScaLightFade, bool TyndallScaLightMode, float TyndallScaNearFade, float TyndallScaDarkFadeDepth, float TyndallScaMaxDepth, bool EnableCustomPosition, FVector TyndallCustomPosition, bool KuroVolumetricLightEnable, float KuroVolumetricLightIntensity, FLinearColor KuroVolumetricLightColor, float KuroVolumetricLightPhaseG, float KuroVolumetricLightMaxDistance, int KuroVolumetricLightBlurRadius, bool KuroVolumetricLightUseColorMask, float KuroVolumetricLightColorMaskIntensity, bool KuroCharacterLUTSplitEnable, UTexture KuroCharacterColorGradingLUT, float KuroCharacterColorGradingLUTLerpIntensity, bool KuroColorGradingTextureLUTInterpolationEnable, FWeightedBlendables WeightedBlendables, TArray<UObject> Blendables_DEPRECATED)
		{
			this.bOverride_WhiteTemp = bOverride_WhiteTemp;
			this.bOverride_WhiteTint = bOverride_WhiteTint;
			this.bOverride_ColorSaturation = bOverride_ColorSaturation;
			this.bOverride_ColorContrast = bOverride_ColorContrast;
			this.bOverride_ColorGamma = bOverride_ColorGamma;
			this.bOverride_ColorGain = bOverride_ColorGain;
			this.bOverride_ColorOffset = bOverride_ColorOffset;
			this.bOverride_ColorSaturationShadows = bOverride_ColorSaturationShadows;
			this.bOverride_ColorContrastShadows = bOverride_ColorContrastShadows;
			this.bOverride_ColorGammaShadows = bOverride_ColorGammaShadows;
			this.bOverride_ColorGainShadows = bOverride_ColorGainShadows;
			this.bOverride_ColorOffsetShadows = bOverride_ColorOffsetShadows;
			this.bOverride_ColorSaturationMidtones = bOverride_ColorSaturationMidtones;
			this.bOverride_ColorContrastMidtones = bOverride_ColorContrastMidtones;
			this.bOverride_ColorGammaMidtones = bOverride_ColorGammaMidtones;
			this.bOverride_ColorGainMidtones = bOverride_ColorGainMidtones;
			this.bOverride_ColorOffsetMidtones = bOverride_ColorOffsetMidtones;
			this.bOverride_ColorSaturationHighlights = bOverride_ColorSaturationHighlights;
			this.bOverride_ColorContrastHighlights = bOverride_ColorContrastHighlights;
			this.bOverride_ColorGammaHighlights = bOverride_ColorGammaHighlights;
			this.bOverride_ColorGainHighlights = bOverride_ColorGainHighlights;
			this.bOverride_ColorOffsetHighlights = bOverride_ColorOffsetHighlights;
			this.bOverride_ColorCorrectionShadowsMax = bOverride_ColorCorrectionShadowsMax;
			this.bOverride_ColorCorrectionHighlightsMin = bOverride_ColorCorrectionHighlightsMin;
			this.bOverride_BlueCorrection = bOverride_BlueCorrection;
			this.bOverride_ExpandGamut = bOverride_ExpandGamut;
			this.bOverride_ToneCurveAmount = bOverride_ToneCurveAmount;
			this.bOverride_FilmWhitePoint = bOverride_FilmWhitePoint;
			this.bOverride_FilmSaturation = bOverride_FilmSaturation;
			this.bOverride_FilmChannelMixerRed = bOverride_FilmChannelMixerRed;
			this.bOverride_FilmChannelMixerGreen = bOverride_FilmChannelMixerGreen;
			this.bOverride_FilmChannelMixerBlue = bOverride_FilmChannelMixerBlue;
			this.bOverride_FilmContrast = bOverride_FilmContrast;
			this.bOverride_FilmDynamicRange = bOverride_FilmDynamicRange;
			this.bOverride_FilmHealAmount = bOverride_FilmHealAmount;
			this.bOverride_FilmToeAmount = bOverride_FilmToeAmount;
			this.bOverride_FilmShadowTint = bOverride_FilmShadowTint;
			this.bOverride_FilmShadowTintBlend = bOverride_FilmShadowTintBlend;
			this.bOverride_FilmShadowTintAmount = bOverride_FilmShadowTintAmount;
			this.bOverride_FilmSlope = bOverride_FilmSlope;
			this.bOverride_FilmToe = bOverride_FilmToe;
			this.bOverride_FilmShoulder = bOverride_FilmShoulder;
			this.bOverride_FilmBlackClip = bOverride_FilmBlackClip;
			this.bOverride_FilmWhiteClip = bOverride_FilmWhiteClip;
			this.bOverride_SceneColorTint = bOverride_SceneColorTint;
			this.bOverride_DecalSaturation = bOverride_DecalSaturation;
			this.bOverride_DecalOpacity = bOverride_DecalOpacity;
			this.bOverride_TranslucentColorTint = bOverride_TranslucentColorTint;
			this.bOverride_SceneColorDesaturate = bOverride_SceneColorDesaturate;
			this.bOverride_SceneColorClear = bOverride_SceneColorClear;
			this.bOverride_SceneColorClearColor = bOverride_SceneColorClearColor;
			this.bOverride_SceneColorClearCenter = bOverride_SceneColorClearCenter;
			this.bOverride_SceneColorClearRadius = bOverride_SceneColorClearRadius;
			this.bOverride_SceneColorClearFadeDistance = bOverride_SceneColorClearFadeDistance;
			this.bOverride_TranslucentColorDesaturate = bOverride_TranslucentColorDesaturate;
			this.bOverride_FightTranslucentNoDesaturate = bOverride_FightTranslucentNoDesaturate;
			this.bOverride_SceneTranslucentColorTint = bOverride_SceneTranslucentColorTint;
			this.bOverride_SceneEmissiveTint = bOverride_SceneEmissiveTint;
			this.bOverride_SceneTranslucentColorDesaturate = bOverride_SceneTranslucentColorDesaturate;
			this.bOverride_EnableSPD = bOverride_EnableSPD;
			this.bOverride_SceneFringeIntensity = bOverride_SceneFringeIntensity;
			this.bOverride_ChromaticAberrationStartOffset = bOverride_ChromaticAberrationStartOffset;
			this.bOverride_BaoChromaticAberrationIntensity = bOverride_BaoChromaticAberrationIntensity;
			this.bOverride_BaoChromaticAberrationMaskCenter = bOverride_BaoChromaticAberrationMaskCenter;
			this.bOverride_BaoChromaticAberrationYScale = bOverride_BaoChromaticAberrationYScale;
			this.bOverride_BaoChromaticAberrationYPan = bOverride_BaoChromaticAberrationYPan;
			this.bOverride_bMegaLights = bOverride_bMegaLights;
			this.bOverride_AmbientCubemapTint = bOverride_AmbientCubemapTint;
			this.bOverride_AmbientCubemapIntensity = bOverride_AmbientCubemapIntensity;
			this.bOverride_BloomMethod = bOverride_BloomMethod;
			this.bOverride_BloomIntensity = bOverride_BloomIntensity;
			this.bOverride_KuroFoliageMaterialAO = bOverride_KuroFoliageMaterialAO;
			this.bOverride_KuroFoliageScreenSpaceAO = bOverride_KuroFoliageScreenSpaceAO;
			this.bOverride_UseFixCharacterRim = bOverride_UseFixCharacterRim;
			this.bOverride_FixCharacterRimAngleV = bOverride_FixCharacterRimAngleV;
			this.bOverride_FixCharacterRimAngleH = bOverride_FixCharacterRimAngleH;
			this.bOverride_UseCustomRim = bOverride_UseCustomRim;
			this.bOverride_CustomRimColor_Stencil1 = bOverride_CustomRimColor_Stencil1;
			this.bOverride_FixCharacterRimAngleV_Stencil1 = bOverride_FixCharacterRimAngleV_Stencil1;
			this.bOverride_FixCharacterRimAngleH_Stencil1 = bOverride_FixCharacterRimAngleH_Stencil1;
			this.bOverride_CustomRimColor_Stencil2 = bOverride_CustomRimColor_Stencil2;
			this.bOverride_FixCharacterRimAngleV_Stencil2 = bOverride_FixCharacterRimAngleV_Stencil2;
			this.bOverride_FixCharacterRimAngleH_Stencil2 = bOverride_FixCharacterRimAngleH_Stencil2;
			this.bOverride_CustomRimColor_Stencil3 = bOverride_CustomRimColor_Stencil3;
			this.bOverride_FixCharacterRimAngleV_Stencil3 = bOverride_FixCharacterRimAngleV_Stencil3;
			this.bOverride_FixCharacterRimAngleH_Stencil3 = bOverride_FixCharacterRimAngleH_Stencil3;
			this.bOverride_KuroBloomIntensity = bOverride_KuroBloomIntensity;
			this.bOverride_KuroBloomThreshold = bOverride_KuroBloomThreshold;
			this.bOverride_EnableSplitCharBloom = bOverride_EnableSplitCharBloom;
			this.bOverride_KuroCharacterBloomIntensity = bOverride_KuroCharacterBloomIntensity;
			this.bOverride_KuroCharacterBloomThreshold = bOverride_KuroCharacterBloomThreshold;
			this.bOverride_SunDirBloomIntensity = bOverride_SunDirBloomIntensity;
			this.bOverride_KuroBloomCombineParameter = bOverride_KuroBloomCombineParameter;
			this.bOverride_KuroBloomStreakIntensity = bOverride_KuroBloomStreakIntensity;
			this.bOverride_KuroBloomStreakThreshold = bOverride_KuroBloomStreakThreshold;
			this.bOverride_TranslucentBloomStreakIntensity = bOverride_TranslucentBloomStreakIntensity;
			this.bOverride_TranslucentBloomStreakThreshold = bOverride_TranslucentBloomStreakThreshold;
			this.bOverride_KuroBloomStreakLength = bOverride_KuroBloomStreakLength;
			this.bOverride_KuroBloomStreakMipLevel = bOverride_KuroBloomStreakMipLevel;
			this.bOverride_KuroBloomStreakRatio = bOverride_KuroBloomStreakRatio;
			this.bOverride_KuroBloomStreakOrientation = bOverride_KuroBloomStreakOrientation;
			this.bOverride_BlackWhiteFlashIntensity = bOverride_BlackWhiteFlashIntensity;
			this.bOverride_BlackWhiteFlashFactor = bOverride_BlackWhiteFlashFactor;
			this.bOverride_BlackWhiteFlashThreshold = bOverride_BlackWhiteFlashThreshold;
			this.bOverride_BlackWhiteFlashBlackAreaColor = bOverride_BlackWhiteFlashBlackAreaColor;
			this.bOverride_BlackWhiteFlashWhiteAreaColor = bOverride_BlackWhiteFlashWhiteAreaColor;
			this.bOverride_KuroRadialBlurIntensity = bOverride_KuroRadialBlurIntensity;
			this.bOverride_KuroRadialBlurRadius = bOverride_KuroRadialBlurRadius;
			this.bOverride_KuroRadialBlurHardness = bOverride_KuroRadialBlurHardness;
			this.bOverride_KuroRadialBlurCenter = bOverride_KuroRadialBlurCenter;
			this.bOverride_UseClampRadialBlurCenter = bOverride_UseClampRadialBlurCenter;
			this.bOverride_KuroRadialBlurPassNumber = bOverride_KuroRadialBlurPassNumber;
			this.bOverride_KuroRadialBlurSampleNumber = bOverride_KuroRadialBlurSampleNumber;
			this.bOverride_KuroRadialBlurMask = bOverride_KuroRadialBlurMask;
			this.bOverride_KuroRadialBlurMaskScale = bOverride_KuroRadialBlurMaskScale;
			this.bOverride_KuroRadialBlurMaskOffset = bOverride_KuroRadialBlurMaskOffset;
			this.bOverride_ScreenSoftIntensity = bOverride_ScreenSoftIntensity;
			this.bOverride_ScreenSoftThreshold = bOverride_ScreenSoftThreshold;
			this.bOverride_ScreenSoftDistance = bOverride_ScreenSoftDistance;
			this.bOverride_ScreenSoftSkyBloomCompensation = bOverride_ScreenSoftSkyBloomCompensation;
			this.bOverride_ScreenSoftRange = bOverride_ScreenSoftRange;
			this.bOverride_ScreenSoftOverflowDistance = bOverride_ScreenSoftOverflowDistance;
			this.bOverride_ScreenSoftSunExposure = bOverride_ScreenSoftSunExposure;
			this.bOverride_ScreenSoftHighQuality = bOverride_ScreenSoftHighQuality;
			this.bOverride_MobileScreenSoftIntensity = bOverride_MobileScreenSoftIntensity;
			this.bOverride_MobileScreenSoftThreshold = bOverride_MobileScreenSoftThreshold;
			this.bOverride_MobileScreenSoftDistance = bOverride_MobileScreenSoftDistance;
			this.bOverride_ScreenLeakTexture = bOverride_ScreenLeakTexture;
			this.bOverride_ScreenLeakTextureIntensity = bOverride_ScreenLeakTextureIntensity;
			this.bOverride_FFTIntensity = bOverride_FFTIntensity;
			this.bOverride_FFTThreshold = bOverride_FFTThreshold;
			this.bOverride_FFTTexture = bOverride_FFTTexture;
			this.bOverride_FFTScatterDispersion = bOverride_FFTScatterDispersion;
			this.bOverride_FFTSize = bOverride_FFTSize;
			this.bOverride_FFTPreFilterMin = bOverride_FFTPreFilterMin;
			this.bOverride_FFTPreFilterMax = bOverride_FFTPreFilterMax;
			this.bOverride_FFTPreFilterMult = bOverride_FFTPreFilterMult;
			this.bOverride_FFTBufferScale = bOverride_FFTBufferScale;
			this.bOverride_FFTDistance = bOverride_FFTDistance;
			this.bOverride_FFTHidenSky = bOverride_FFTHidenSky;
			this.bOverride_FFTHidenTranslucent = bOverride_FFTHidenTranslucent;
			this.bOverride_FFTBeforeTranslucency = bOverride_FFTBeforeTranslucency;
			this.bOverride_ToonFFTIntensity = bOverride_ToonFFTIntensity;
			this.bOverride_ToonFFTThreshold = bOverride_ToonFFTThreshold;
			this.bOverride_ToonFFTTexture = bOverride_ToonFFTTexture;
			this.bOverride_ToonFFTScatterDispersion = bOverride_ToonFFTScatterDispersion;
			this.bOverride_ToonFFTSize = bOverride_ToonFFTSize;
			this.bOverride_SeparateTranslucencyBlurSize = bOverride_SeparateTranslucencyBlurSize;
			this.bOverride_LightFadeScale = bOverride_LightFadeScale;
			this.bOverride_KuroDataDistortionNoiseIntensity = bOverride_KuroDataDistortionNoiseIntensity;
			this.bOverride_KuroDataDistortionNoiseTexture = bOverride_KuroDataDistortionNoiseTexture;
			this.bOverride_KuroDataDistortionNoiseTextureUVScaleBias = bOverride_KuroDataDistortionNoiseTextureUVScaleBias;
			this.bOverride_KuroDataDistortionNoiseSize = bOverride_KuroDataDistortionNoiseSize;
			this.bOverride_KuroDataDistortionNoiseBias = bOverride_KuroDataDistortionNoiseBias;
			this.bOverride_KuroDataDistortionSignalIntensity = bOverride_KuroDataDistortionSignalIntensity;
			this.bOverride_KuroDataDistortionRandomColorSize = bOverride_KuroDataDistortionRandomColorSize;
			this.bOverride_KuroDataDistortionSinWaveParameters = bOverride_KuroDataDistortionSinWaveParameters;
			this.bOverride_KuroDataDistortionColorTint = bOverride_KuroDataDistortionColorTint;
			this.bOverride_BloomThreshold = bOverride_BloomThreshold;
			this.bOverride_Bloom1Tint = bOverride_Bloom1Tint;
			this.bOverride_Bloom1Size = bOverride_Bloom1Size;
			this.bOverride_Bloom2Size = bOverride_Bloom2Size;
			this.bOverride_Bloom2Tint = bOverride_Bloom2Tint;
			this.bOverride_Bloom3Tint = bOverride_Bloom3Tint;
			this.bOverride_Bloom3Size = bOverride_Bloom3Size;
			this.bOverride_Bloom4Tint = bOverride_Bloom4Tint;
			this.bOverride_Bloom4Size = bOverride_Bloom4Size;
			this.bOverride_Bloom5Tint = bOverride_Bloom5Tint;
			this.bOverride_Bloom5Size = bOverride_Bloom5Size;
			this.bOverride_Bloom6Tint = bOverride_Bloom6Tint;
			this.bOverride_Bloom6Size = bOverride_Bloom6Size;
			this.bOverride_BloomSizeScale = bOverride_BloomSizeScale;
			this.bOverride_BloomConvolutionPreFilter_DEPRECATED = bOverride_BloomConvolutionPreFilter_DEPRECATED;
			this.bOverride_BloomDirtMaskIntensity = bOverride_BloomDirtMaskIntensity;
			this.bOverride_BloomDirtMaskTint = bOverride_BloomDirtMaskTint;
			this.bOverride_BloomDirtMask = bOverride_BloomDirtMask;
			this.bOverride_CameraShutterSpeed = bOverride_CameraShutterSpeed;
			this.bOverride_CameraISO = bOverride_CameraISO;
			this.bOverride_AutoExposureMethod = bOverride_AutoExposureMethod;
			this.bOverride_AutoExposureLowPercent = bOverride_AutoExposureLowPercent;
			this.bOverride_AutoExposureHighPercent = bOverride_AutoExposureHighPercent;
			this.bOverride_AutoExposureMinBrightness = bOverride_AutoExposureMinBrightness;
			this.bOverride_AutoExposureMaxBrightness = bOverride_AutoExposureMaxBrightness;
			this.bOverride_AutoExposureCalibrationConstant_DEPRECATED = bOverride_AutoExposureCalibrationConstant_DEPRECATED;
			this.bOverride_AutoExposureSpeedUp = bOverride_AutoExposureSpeedUp;
			this.bOverride_AutoExposureSpeedDown = bOverride_AutoExposureSpeedDown;
			this.bOverride_AutoExposureBias = bOverride_AutoExposureBias;
			this.bOverride_AutoExposureBiasCurve = bOverride_AutoExposureBiasCurve;
			this.bOverride_AutoExposureMeterMask = bOverride_AutoExposureMeterMask;
			this.bOverride_AutoExposureApplyPhysicalCameraExposure = bOverride_AutoExposureApplyPhysicalCameraExposure;
			this.bOverride_HistogramLogMin = bOverride_HistogramLogMin;
			this.bOverride_HistogramLogMax = bOverride_HistogramLogMax;
			this.bOverride_LocalExposureMethod = bOverride_LocalExposureMethod;
			this.bOverride_LocalExposureContrastScale_DEPRECATED = bOverride_LocalExposureContrastScale_DEPRECATED;
			this.bOverride_LocalExposureHighlightContrastScale = bOverride_LocalExposureHighlightContrastScale;
			this.bOverride_LocalExposureShadowContrastScale = bOverride_LocalExposureShadowContrastScale;
			this.bOverride_LocalExposureHighlightContrastCurve = bOverride_LocalExposureHighlightContrastCurve;
			this.bOverride_LocalExposureShadowContrastCurve = bOverride_LocalExposureShadowContrastCurve;
			this.bOverride_LocalExposureHighlightThreshold = bOverride_LocalExposureHighlightThreshold;
			this.bOverride_LocalExposureShadowThreshold = bOverride_LocalExposureShadowThreshold;
			this.bOverride_LocalExposureDetailStrength = bOverride_LocalExposureDetailStrength;
			this.bOverride_LocalExposureBlurredLuminanceBlend = bOverride_LocalExposureBlurredLuminanceBlend;
			this.bOverride_LocalExposureBlurredLuminanceKernelSizePercent = bOverride_LocalExposureBlurredLuminanceKernelSizePercent;
			this.bOverride_LocalExposureMiddleGreyBias = bOverride_LocalExposureMiddleGreyBias;
			this.bOverride_LensFlareIntensity = bOverride_LensFlareIntensity;
			this.bOverride_LensFlareTint = bOverride_LensFlareTint;
			this.bOverride_LensFlareTints = bOverride_LensFlareTints;
			this.bOverride_LensFlareBokehSize = bOverride_LensFlareBokehSize;
			this.bOverride_LensFlareBokehShape = bOverride_LensFlareBokehShape;
			this.bOverride_LensFlareThreshold = bOverride_LensFlareThreshold;
			this.bOverride_LensFlareOnlySun = bOverride_LensFlareOnlySun;
			this.bOverride_LensFlareSunRange = bOverride_LensFlareSunRange;
			this.bOverride_LensFlareSunPosition = bOverride_LensFlareSunPosition;
			this.bOverride_VignetteIntensity = bOverride_VignetteIntensity;
			this.bOverride_VignetteHardness = bOverride_VignetteHardness;
			this.bOverride_VignetteXScale = bOverride_VignetteXScale;
			this.bOverride_VignetteYScale = bOverride_VignetteYScale;
			this.bOverride_VignetteXPos = bOverride_VignetteXPos;
			this.bOverride_VignetteYPos = bOverride_VignetteYPos;
			this.bOverride_VignetteColor = bOverride_VignetteColor;
			this.bOverride_VignetteGain = bOverride_VignetteGain;
			this.bOverride_EffectVignetteIntensity = bOverride_EffectVignetteIntensity;
			this.bOverride_EffectVignetteHardness = bOverride_EffectVignetteHardness;
			this.bOverride_EffectVignetteXScale = bOverride_EffectVignetteXScale;
			this.bOverride_EffectVignetteYScale = bOverride_EffectVignetteYScale;
			this.bOverride_EffectVignetteXPos = bOverride_EffectVignetteXPos;
			this.bOverride_EffectVignetteYPos = bOverride_EffectVignetteYPos;
			this.bOverride_EffectVignetteColor = bOverride_EffectVignetteColor;
			this.bOverride_EffectVignetteGain = bOverride_EffectVignetteGain;
			this.bOverride_GrainIntensity = bOverride_GrainIntensity;
			this.bOverride_GrainJitter = bOverride_GrainJitter;
			this.bOverride_GrainColorful = bOverride_GrainColorful;
			this.bOverride_MainCenterMask = bOverride_MainCenterMask;
			this.bOverride_MainCenterMaskRadius = bOverride_MainCenterMaskRadius;
			this.bOverride_MainCenterMaskHardness = bOverride_MainCenterMaskHardness;
			this.bOverride_MainStartDistance = bOverride_MainStartDistance;
			this.bOverride_MainCharacterIntensity = bOverride_MainCharacterIntensity;
			this.bOverride_VintageColorIntensity = bOverride_VintageColorIntensity;
			this.bOverride_VintageColorBlackPoint = bOverride_VintageColorBlackPoint;
			this.bOverride_VintageColorWhitePoint = bOverride_VintageColorWhitePoint;
			this.bOverride_VHSLinesColorIntensity = bOverride_VHSLinesColorIntensity;
			this.bOverride_VHSLinesDistortIntensity = bOverride_VHSLinesDistortIntensity;
			this.bOverride_VHSEffectIntensity = bOverride_VHSEffectIntensity;
			this.bOverride_VHSSpecklesIntensity = bOverride_VHSSpecklesIntensity;
			this.bOverride_VHSSpecklesAmount = bOverride_VHSSpecklesAmount;
			this.bOverride_VHSSpecklesSize = bOverride_VHSSpecklesSize;
			this.bOverride_CRTDistortion = bOverride_CRTDistortion;
			this.bOverride_VintageColorCenterMask = bOverride_VintageColorCenterMask;
			this.bOverride_VintageColorStartDistance = bOverride_VintageColorStartDistance;
			this.bOverride_VintageColorCharacterIntensity = bOverride_VintageColorCharacterIntensity;
			this.bOverride_VHSLinesCenterMask = bOverride_VHSLinesCenterMask;
			this.bOverride_VHSLinesStartDistance = bOverride_VHSLinesStartDistance;
			this.bOverride_VHSLinesCharacterIntensity = bOverride_VHSLinesCharacterIntensity;
			this.bOverride_VHSEffectCenterMask = bOverride_VHSEffectCenterMask;
			this.bOverride_VHSEffectStartDistance = bOverride_VHSEffectStartDistance;
			this.bOverride_VHSEffectCharacterIntensity = bOverride_VHSEffectCharacterIntensity;
			this.bOverride_VHSSpecklesCenterMask = bOverride_VHSSpecklesCenterMask;
			this.bOverride_VHSSpecklesStartDistance = bOverride_VHSSpecklesStartDistance;
			this.bOverride_VHSSpecklesCharacterIntensity = bOverride_VHSSpecklesCharacterIntensity;
			this.bOverride_AmbientOcclusionIntensity = bOverride_AmbientOcclusionIntensity;
			this.bOverride_AmbientOcclusionStaticFraction = bOverride_AmbientOcclusionStaticFraction;
			this.bOverride_AmbientOcclusionRadius = bOverride_AmbientOcclusionRadius;
			this.bOverride_AmbientOcclusionFadeDistance = bOverride_AmbientOcclusionFadeDistance;
			this.bOverride_AmbientOcclusionFadeRadius = bOverride_AmbientOcclusionFadeRadius;
			this.bOverride_AmbientOcclusionDistance_DEPRECATED = bOverride_AmbientOcclusionDistance_DEPRECATED;
			this.bOverride_AmbientOcclusionRadiusInWS = bOverride_AmbientOcclusionRadiusInWS;
			this.bOverride_AmbientOcclusionPower = bOverride_AmbientOcclusionPower;
			this.bOverride_AmbientOcclusionBias = bOverride_AmbientOcclusionBias;
			this.bOverride_AmbientOcclusionQuality = bOverride_AmbientOcclusionQuality;
			this.bOverride_AmbientOcclusionMipBlend = bOverride_AmbientOcclusionMipBlend;
			this.bOverride_AmbientOcclusionMipScale = bOverride_AmbientOcclusionMipScale;
			this.bOverride_AmbientOcclusionMipThreshold = bOverride_AmbientOcclusionMipThreshold;
			this.bOverride_AmbientOcclusionTemporalBlendWeight = bOverride_AmbientOcclusionTemporalBlendWeight;
			this.bOverride_RayTracingAO = bOverride_RayTracingAO;
			this.bOverride_RayTracingAOSamplesPerPixel = bOverride_RayTracingAOSamplesPerPixel;
			this.bOverride_RayTracingAOIntensity = bOverride_RayTracingAOIntensity;
			this.bOverride_RayTracingAORadius = bOverride_RayTracingAORadius;
			this.bOverride_LPVIntensity = bOverride_LPVIntensity;
			this.bOverride_LPVDirectionalOcclusionIntensity = bOverride_LPVDirectionalOcclusionIntensity;
			this.bOverride_LPVDirectionalOcclusionRadius = bOverride_LPVDirectionalOcclusionRadius;
			this.bOverride_LPVDiffuseOcclusionExponent = bOverride_LPVDiffuseOcclusionExponent;
			this.bOverride_LPVSpecularOcclusionExponent = bOverride_LPVSpecularOcclusionExponent;
			this.bOverride_LPVDiffuseOcclusionIntensity = bOverride_LPVDiffuseOcclusionIntensity;
			this.bOverride_LPVSpecularOcclusionIntensity = bOverride_LPVSpecularOcclusionIntensity;
			this.bOverride_LPVSize = bOverride_LPVSize;
			this.bOverride_LPVSecondaryOcclusionIntensity = bOverride_LPVSecondaryOcclusionIntensity;
			this.bOverride_LPVSecondaryBounceIntensity = bOverride_LPVSecondaryBounceIntensity;
			this.bOverride_LPVGeometryVolumeBias = bOverride_LPVGeometryVolumeBias;
			this.bOverride_LPVVplInjectionBias = bOverride_LPVVplInjectionBias;
			this.bOverride_LPVEmissiveInjectionIntensity = bOverride_LPVEmissiveInjectionIntensity;
			this.bOverride_LPVFadeRange = bOverride_LPVFadeRange;
			this.bOverride_LPVDirectionalOcclusionFadeRange = bOverride_LPVDirectionalOcclusionFadeRange;
			this.bOverride_LumenSkylightLeaking = bOverride_LumenSkylightLeaking;
			this.bOverride_IndirectLightingColor = bOverride_IndirectLightingColor;
			this.bOverride_IndirectLightingIntensity = bOverride_IndirectLightingIntensity;
			this.bOverride_ColorGradingIntensity = bOverride_ColorGradingIntensity;
			this.bOverride_ColorGradingLUT = bOverride_ColorGradingLUT;
			this.bOverride_DepthOfFieldFocalDistance = bOverride_DepthOfFieldFocalDistance;
			this.bOverride_DepthOfFieldFstop = bOverride_DepthOfFieldFstop;
			this.bOverride_DepthOfFieldMinFstop = bOverride_DepthOfFieldMinFstop;
			this.bOverride_DepthOfFieldBladeCount = bOverride_DepthOfFieldBladeCount;
			this.bOverride_DepthOfFieldForegroundBlur = bOverride_DepthOfFieldForegroundBlur;
			this.bOverride_DepthOfFieldSensorWidth = bOverride_DepthOfFieldSensorWidth;
			this.bOverride_DepthOfFieldDepthBlurRadius = bOverride_DepthOfFieldDepthBlurRadius;
			this.bOverride_DepthOfFieldDepthBlurAmount = bOverride_DepthOfFieldDepthBlurAmount;
			this.bOverride_DepthOfFieldFocalRegion = bOverride_DepthOfFieldFocalRegion;
			this.bOverride_DepthOfFieldNearTransitionRegion = bOverride_DepthOfFieldNearTransitionRegion;
			this.bOverride_DepthOfFieldFarTransitionRegion = bOverride_DepthOfFieldFarTransitionRegion;
			this.bOverride_DepthOfFieldScale = bOverride_DepthOfFieldScale;
			this.bOverride_DepthOfFieldNearBlurSize = bOverride_DepthOfFieldNearBlurSize;
			this.bOverride_DepthOfFieldFarBlurSize = bOverride_DepthOfFieldFarBlurSize;
			this.bOverride_MobileHQGaussian = bOverride_MobileHQGaussian;
			this.bOverride_KuroDangerToggle = bOverride_KuroDangerToggle;
			this.bOverride_DepthOfFieldOcclusion = bOverride_DepthOfFieldOcclusion;
			this.bOverride_DepthOfFieldSkyFocusDistance = bOverride_DepthOfFieldSkyFocusDistance;
			this.bOverride_DepthOfFieldVignetteSize = bOverride_DepthOfFieldVignetteSize;
			this.bOverride_MotionBlurAmount = bOverride_MotionBlurAmount;
			this.bOverride_MotionBlurMax = bOverride_MotionBlurMax;
			this.bOverride_MotionBlurTargetFPS = bOverride_MotionBlurTargetFPS;
			this.bOverride_MotionBlurPerObjectSize = bOverride_MotionBlurPerObjectSize;
			this.bOverride_ScreenPercentage = bOverride_ScreenPercentage;
			this.bOverride_MotionBlurCharacterMask = bOverride_MotionBlurCharacterMask;
			this.bOverride_WithOutTranslucent = bOverride_WithOutTranslucent;
			this.bOverride_StartPosSwitch = bOverride_StartPosSwitch;
			this.bOverride_GrayGradationStartPos = bOverride_GrayGradationStartPos;
			this.bOverride_GrayGradationDegree = bOverride_GrayGradationDegree;
			this.bOverride_GrayLerpWidth = bOverride_GrayLerpWidth;
			this.bOverride_GrayRampColor = bOverride_GrayRampColor;
			this.bOverride_GrayRampTint = bOverride_GrayRampTint;
			this.bOverride_GrayRampBlendWeight = bOverride_GrayRampBlendWeight;
			this.bOverride_SNNIntensity = bOverride_SNNIntensity;
			this.bOverride_SNNRoughnessContrast = bOverride_SNNRoughnessContrast;
			this.bOverride_SNNMetallicThreshold = bOverride_SNNMetallicThreshold;
			this.bOverride_SNNDepthFade = bOverride_SNNDepthFade;
			this.bOverride_SNNFoliageIntensity = bOverride_SNNFoliageIntensity;
			this.bOverride_SNNStructureIntensity = bOverride_SNNStructureIntensity;
			this.bOverride_SNNNoiseIntensity = bOverride_SNNNoiseIntensity;
			this.bOverride_SNNEnableSharpen = bOverride_SNNEnableSharpen;
			this.bOverride_SNNSharpeness = bOverride_SNNSharpeness;
			this.bOverride_SNNSharpenDepthFade = bOverride_SNNSharpenDepthFade;
			this.bOverride_SSFSIntensity = bOverride_SSFSIntensity;
			this.bOverride_SSFSRadius = bOverride_SSFSRadius;
			this.bOverride_SSFSLuminanceWeighting = bOverride_SSFSLuminanceWeighting;
			this.bOverride_SSFSSkyAtmosphereIntensity = bOverride_SSFSSkyAtmosphereIntensity;
			this.bOverride_SSFSVolumetricFogILSIntensity = bOverride_SSFSVolumetricFogILSIntensity;
			this.bOverride_SSFSKuroVolumetricLightILSIntensity = bOverride_SSFSKuroVolumetricLightILSIntensity;
			this.bOverride_SSFSStartDistance = bOverride_SSFSStartDistance;
			this.bOverride_SSFSMaxDepth = bOverride_SSFSMaxDepth;
			this.bOverride_EnableMobileSSFS = bOverride_EnableMobileSSFS;
			this.bOverride_MobileSSFSFogDensity = bOverride_MobileSSFSFogDensity;
			this.bOverride_MobileSSFSIntensity = bOverride_MobileSSFSIntensity;
			this.bOverride_MobileSSFSRadius = bOverride_MobileSSFSRadius;
			this.bOverride_MobileSSFSStartDistance = bOverride_MobileSSFSStartDistance;
			this.bOverride_KuroSharpenRadius = bOverride_KuroSharpenRadius;
			this.bOverride_KuroSharpenAmount = bOverride_KuroSharpenAmount;
			this.bOverride_KuroLaplacianAmount = bOverride_KuroLaplacianAmount;
			this.bOverride_KuroSharpenIntensity = bOverride_KuroSharpenIntensity;
			this.bOverride_KuroToonSharpenIntensity = bOverride_KuroToonSharpenIntensity;
			this.bOverride_KuroSharpenDistance = bOverride_KuroSharpenDistance;
			this.bOverride_TyndallScaLightIntensity = bOverride_TyndallScaLightIntensity;
			this.bOverride_TyndallDarkIntensity = bOverride_TyndallDarkIntensity;
			this.bOverride_TyndallScaLightLength = bOverride_TyndallScaLightLength;
			this.bOverride_TyndallScaLightColor = bOverride_TyndallScaLightColor;
			this.bOverride_TyndallScaLightFade = bOverride_TyndallScaLightFade;
			this.bOverride_TyndallScaLightMode = bOverride_TyndallScaLightMode;
			this.bOverride_TyndallScaNearFade = bOverride_TyndallScaNearFade;
			this.bOverride_TyndallScaDarkFadeDepth = bOverride_TyndallScaDarkFadeDepth;
			this.bOverride_TyndallScaMaxDepth = bOverride_TyndallScaMaxDepth;
			this.bOverride_EnableCustomPosition = bOverride_EnableCustomPosition;
			this.bOverride_TyndallCustomPosition = bOverride_TyndallCustomPosition;
			this.bOverride_KuroVolumetricLightEnable = bOverride_KuroVolumetricLightEnable;
			this.bOverride_KuroVolumetricLightIntensity = bOverride_KuroVolumetricLightIntensity;
			this.bOverride_KuroVolumetricLightColor = bOverride_KuroVolumetricLightColor;
			this.bOverride_KuroVolumetricLightPhaseG = bOverride_KuroVolumetricLightPhaseG;
			this.bOverride_KuroVolumetricLightMaxDistance = bOverride_KuroVolumetricLightMaxDistance;
			this.bOverride_KuroVolumetricLightBlurRadius = bOverride_KuroVolumetricLightBlurRadius;
			this.bOverride_KuroVolumetricLightUseColorMask = bOverride_KuroVolumetricLightUseColorMask;
			this.bOverride_KuroVolumetricLightColorMaskIntensity = bOverride_KuroVolumetricLightColorMaskIntensity;
			this.bOverride_ScreenSpaceReflectionIntensity = bOverride_ScreenSpaceReflectionIntensity;
			this.bOverride_ScreenSpaceReflectionQuality = bOverride_ScreenSpaceReflectionQuality;
			this.bOverride_ScreenSpaceReflectionMaxRoughness = bOverride_ScreenSpaceReflectionMaxRoughness;
			this.bOverride_KuroTonemapA = bOverride_KuroTonemapA;
			this.bOverride_KuroTonemapB = bOverride_KuroTonemapB;
			this.bOverride_KuroTonemapC = bOverride_KuroTonemapC;
			this.bOverride_KuroTonemapD = bOverride_KuroTonemapD;
			this.bOverride_KuroTonemapE = bOverride_KuroTonemapE;
			this.bOverride_KuroTonemapF = bOverride_KuroTonemapF;
			this.bOverride_UseCharacterMask = bOverride_UseCharacterMask;
			this.bOverride_ScreenSpaceReflectionRoughnessScale = bOverride_ScreenSpaceReflectionRoughnessScale;
			this.bOverride_ReflectionsType = bOverride_ReflectionsType;
			this.bOverride_RayTracingReflectionsMaxRoughness = bOverride_RayTracingReflectionsMaxRoughness;
			this.bOverride_RayTracingReflectionsMaxBounces = bOverride_RayTracingReflectionsMaxBounces;
			this.bOverride_RayTracingReflectionsSamplesPerPixel = bOverride_RayTracingReflectionsSamplesPerPixel;
			this.bOverride_RayTracingReflectionsShadows = bOverride_RayTracingReflectionsShadows;
			this.bOverride_RayTracingReflectionsTranslucency = bOverride_RayTracingReflectionsTranslucency;
			this.bOverride_TranslucencyType = bOverride_TranslucencyType;
			this.bOverride_RayTracingTranslucencyMaxRoughness = bOverride_RayTracingTranslucencyMaxRoughness;
			this.bOverride_RayTracingTranslucencyRefractionRays = bOverride_RayTracingTranslucencyRefractionRays;
			this.bOverride_RayTracingTranslucencySamplesPerPixel = bOverride_RayTracingTranslucencySamplesPerPixel;
			this.bOverride_RayTracingTranslucencyShadows = bOverride_RayTracingTranslucencyShadows;
			this.bOverride_RayTracingTranslucencyRefraction = bOverride_RayTracingTranslucencyRefraction;
			this.bOverride_RayTracingGI = bOverride_RayTracingGI;
			this.bOverride_RayTracingGIMaxBounces = bOverride_RayTracingGIMaxBounces;
			this.bOverride_RayTracingGISamplesPerPixel = bOverride_RayTracingGISamplesPerPixel;
			this.bOverride_PathTracingMaxBounces = bOverride_PathTracingMaxBounces;
			this.bOverride_PathTracingSamplesPerPixel = bOverride_PathTracingSamplesPerPixel;
			this.bKuroDangerToggle = bKuroDangerToggle;
			this.bMobileHQGaussian = bMobileHQGaussian;
			this.bOverride_KuroCharacterLUTSplitEnable = bOverride_KuroCharacterLUTSplitEnable;
			this.bOverride_KuroCharacterColorGradingLUT = bOverride_KuroCharacterColorGradingLUT;
			this.bOverride_KuroCharacterColorGradingLUTLerpIntensity = bOverride_KuroCharacterColorGradingLUTLerpIntensity;
			this.bOverride_KuroColorGradingTextureLUTInterpolationEnable = bOverride_KuroColorGradingTextureLUTInterpolationEnable;
			this.KuroTonemapA = KuroTonemapA;
			this.KuroTonemapB = KuroTonemapB;
			this.KuroTonemapC = KuroTonemapC;
			this.KuroTonemapD = KuroTonemapD;
			this.KuroTonemapE = KuroTonemapE;
			this.KuroTonemapF = KuroTonemapF;
			this.UseCharacterMask = UseCharacterMask;
			this.BloomMethod = BloomMethod;
			this.AutoExposureMethod = AutoExposureMethod;
			this.WhiteTemp = WhiteTemp;
			this.WhiteTint = WhiteTint;
			this.ColorSaturation = ColorSaturation;
			this.ColorContrast = ColorContrast;
			this.ColorGamma = ColorGamma;
			this.ColorGain = ColorGain;
			this.ColorOffset = ColorOffset;
			this.ColorSaturationClient = ColorSaturationClient;
			this.ColorContrastClient = ColorContrastClient;
			this.ColorSaturationShadows = ColorSaturationShadows;
			this.ColorContrastShadows = ColorContrastShadows;
			this.ColorGammaShadows = ColorGammaShadows;
			this.ColorGainShadows = ColorGainShadows;
			this.ColorOffsetShadows = ColorOffsetShadows;
			this.ColorSaturationMidtones = ColorSaturationMidtones;
			this.ColorContrastMidtones = ColorContrastMidtones;
			this.ColorGammaMidtones = ColorGammaMidtones;
			this.ColorGainMidtones = ColorGainMidtones;
			this.ColorOffsetMidtones = ColorOffsetMidtones;
			this.ColorSaturationHighlights = ColorSaturationHighlights;
			this.ColorContrastHighlights = ColorContrastHighlights;
			this.ColorGammaHighlights = ColorGammaHighlights;
			this.ColorGainHighlights = ColorGainHighlights;
			this.ColorOffsetHighlights = ColorOffsetHighlights;
			this.ColorCorrectionHighlightsMin = ColorCorrectionHighlightsMin;
			this.ColorCorrectionShadowsMax = ColorCorrectionShadowsMax;
			this.BlueCorrection = BlueCorrection;
			this.ExpandGamut = ExpandGamut;
			this.ToneCurveAmount = ToneCurveAmount;
			this.FilmSlope = FilmSlope;
			this.FilmToe = FilmToe;
			this.FilmShoulder = FilmShoulder;
			this.FilmBlackClip = FilmBlackClip;
			this.FilmWhiteClip = FilmWhiteClip;
			this.FilmWhitePoint = FilmWhitePoint;
			this.FilmShadowTint = FilmShadowTint;
			this.FilmShadowTintBlend = FilmShadowTintBlend;
			this.FilmShadowTintAmount = FilmShadowTintAmount;
			this.FilmSaturation = FilmSaturation;
			this.FilmChannelMixerRed = FilmChannelMixerRed;
			this.FilmChannelMixerGreen = FilmChannelMixerGreen;
			this.FilmChannelMixerBlue = FilmChannelMixerBlue;
			this.FilmContrast = FilmContrast;
			this.FilmToeAmount = FilmToeAmount;
			this.FilmHealAmount = FilmHealAmount;
			this.FilmDynamicRange = FilmDynamicRange;
			this.SceneColorTint = SceneColorTint;
			this.DecalSaturation = DecalSaturation;
			this.DecalOpacity = DecalOpacity;
			this.TranslucentColorTint = TranslucentColorTint;
			this.SceneColorDesaturate = SceneColorDesaturate;
			this.SceneColorClear = SceneColorClear;
			this.SceneColorClearColor = SceneColorClearColor;
			this.SceneColorClearCenter = SceneColorClearCenter;
			this.SceneColorClearRadius = SceneColorClearRadius;
			this.SceneColorClearFadeDistance = SceneColorClearFadeDistance;
			this.TranslucentColorDesaturate = TranslucentColorDesaturate;
			this.FightTranslucentNoDesaturate = FightTranslucentNoDesaturate;
			this.SceneTranslucentColorTint = SceneTranslucentColorTint;
			this.SceneEmissiveTint = SceneEmissiveTint;
			this.SceneTranslucentColorDesaturate = SceneTranslucentColorDesaturate;
			this.SeparateTranslucencyBlurSize = SeparateTranslucencyBlurSize;
			this.EnableSPD = EnableSPD;
			this.SceneFringeIntensity = SceneFringeIntensity;
			this.ChromaticAberrationStartOffset = ChromaticAberrationStartOffset;
			this.BaoChromaticAberrationIntensity = BaoChromaticAberrationIntensity;
			this.BaoChromaticAberrationMaskCenter = BaoChromaticAberrationMaskCenter;
			this.BaoChromaticAberrationYScale = BaoChromaticAberrationYScale;
			this.BaoChromaticAberrationYPan = BaoChromaticAberrationYPan;
			this.KuroFoliageMaterialAO = KuroFoliageMaterialAO;
			this.KuroFoliageScreenSpaceAO = KuroFoliageScreenSpaceAO;
			this.UseFixCharacterRim = UseFixCharacterRim;
			this.FixCharacterRimAngleV = FixCharacterRimAngleV;
			this.FixCharacterRimAngleH = FixCharacterRimAngleH;
			this.UseCustomRim = UseCustomRim;
			this.CustomRimColor_Stencil1 = CustomRimColor_Stencil1;
			this.FixCharacterRimAngleV_Stencil1 = FixCharacterRimAngleV_Stencil1;
			this.FixCharacterRimAngleH_Stencil1 = FixCharacterRimAngleH_Stencil1;
			this.CustomRimColor_Stencil2 = CustomRimColor_Stencil2;
			this.FixCharacterRimAngleV_Stencil2 = FixCharacterRimAngleV_Stencil2;
			this.FixCharacterRimAngleH_Stencil2 = FixCharacterRimAngleH_Stencil2;
			this.CustomRimColor_Stencil3 = CustomRimColor_Stencil3;
			this.FixCharacterRimAngleV_Stencil3 = FixCharacterRimAngleV_Stencil3;
			this.FixCharacterRimAngleH_Stencil3 = FixCharacterRimAngleH_Stencil3;
			this.KuroBloomIntensity = KuroBloomIntensity;
			this.KuroBloomThreshold = KuroBloomThreshold;
			this.EnableSplitCharBloom = EnableSplitCharBloom;
			this.KuroCharacterBloomIntensity = KuroCharacterBloomIntensity;
			this.KuroCharacterBloomThreshold = KuroCharacterBloomThreshold;
			this.SunDirBloomIntensity = SunDirBloomIntensity;
			this.KuroBloomCombineParameter = KuroBloomCombineParameter;
			this.KuroBloomStreakIntensity = KuroBloomStreakIntensity;
			this.KuroBloomStreakThreshold = KuroBloomStreakThreshold;
			this.TranslucentBloomStreakIntensity = TranslucentBloomStreakIntensity;
			this.TranslucentBloomStreakThreshold = TranslucentBloomStreakThreshold;
			this.KuroBloomStreakLength = KuroBloomStreakLength;
			this.KuroBloomStreakMipLevel = KuroBloomStreakMipLevel;
			this.KuroBloomStreakRatio = KuroBloomStreakRatio;
			this.KuroBloomStreakOrientation = KuroBloomStreakOrientation;
			this.BlackWhiteFlashIntensity = BlackWhiteFlashIntensity;
			this.BlackWhiteFlashFactor = BlackWhiteFlashFactor;
			this.BlackWhiteFlashThreshold = BlackWhiteFlashThreshold;
			this.BlackWhiteFlashBlackAreaColor = BlackWhiteFlashBlackAreaColor;
			this.BlackWhiteFlashWhiteAreaColor = BlackWhiteFlashWhiteAreaColor;
			this.KuroRadialBlurIntensity = KuroRadialBlurIntensity;
			this.KuroRadialBlurCenter = KuroRadialBlurCenter;
			this.UseClampRadialBlurCenter = UseClampRadialBlurCenter;
			this.KuroRadialBlurRadius = KuroRadialBlurRadius;
			this.KuroRadialBlurHardness = KuroRadialBlurHardness;
			this.KuroRadialBlurPassNumber = KuroRadialBlurPassNumber;
			this.KuroRadialBlurSampleNumber = KuroRadialBlurSampleNumber;
			this.KuroRadialBlurMask = KuroRadialBlurMask;
			this.KuroRadialBlurMaskScale = KuroRadialBlurMaskScale;
			this.KuroRadialBlurMaskOffset = KuroRadialBlurMaskOffset;
			this.ScreenSoftIntensity = ScreenSoftIntensity;
			this.ScreenSoftThreshold = ScreenSoftThreshold;
			this.ScreenSoftDistance = ScreenSoftDistance;
			this.ScreenSoftSkyBloomCompensation = ScreenSoftSkyBloomCompensation;
			this.ScreenSoftRange = ScreenSoftRange;
			this.ScreenSoftOverflowDistance = ScreenSoftOverflowDistance;
			this.ScreenSoftSunExposure = ScreenSoftSunExposure;
			this.ScreenSoftHighQuality = ScreenSoftHighQuality;
			this.MobileScreenSoftIntensity = MobileScreenSoftIntensity;
			this.MobileScreenSoftThreshold = MobileScreenSoftThreshold;
			this.MobileScreenSoftDistance = MobileScreenSoftDistance;
			this.ScreenLeakTexture = ScreenLeakTexture;
			this.ScreenLeakTextureIntensity = ScreenLeakTextureIntensity;
			this.FFTIntensity = FFTIntensity;
			this.FFTThreshold = FFTThreshold;
			this.FFTTexture = FFTTexture;
			this.FFTScatterDispersion = FFTScatterDispersion;
			this.FFTSize = FFTSize;
			this.FFTPreFilterMin = FFTPreFilterMin;
			this.FFTPreFilterMax = FFTPreFilterMax;
			this.FFTPreFilterMult = FFTPreFilterMult;
			this.FFTBufferScale = FFTBufferScale;
			this.FFTDistance = FFTDistance;
			this.FFTHidenSky = FFTHidenSky;
			this.FFTHidenTranslucent = FFTHidenTranslucent;
			this.FFTBeforeTranslucency = FFTBeforeTranslucency;
			this.ToonFFTIntensity = ToonFFTIntensity;
			this.ToonFFTThreshold = ToonFFTThreshold;
			this.ToonFFTTexture = ToonFFTTexture;
			this.ToonFFTScatterDispersion = ToonFFTScatterDispersion;
			this.ToonFFTSize = ToonFFTSize;
			this.LightFadeScale = LightFadeScale;
			this.KuroDataDistortionNoiseIntensity = KuroDataDistortionNoiseIntensity;
			this.KuroDataDistortionNoiseTexture = KuroDataDistortionNoiseTexture;
			this.KuroDataDistortionNoiseTextureUVScaleBias = KuroDataDistortionNoiseTextureUVScaleBias;
			this.KuroDataDistortionNoiseSize = KuroDataDistortionNoiseSize;
			this.KuroDataDistortionNoiseBias = KuroDataDistortionNoiseBias;
			this.KuroDataDistortionSignalIntensity = KuroDataDistortionSignalIntensity;
			this.KuroDataDistortionRandomColorSize = KuroDataDistortionRandomColorSize;
			this.KuroDataDistortionSinWaveParameters = KuroDataDistortionSinWaveParameters;
			this.KuroDataDistortionColorTint = KuroDataDistortionColorTint;
			this.BloomIntensity = BloomIntensity;
			this.BloomThreshold = BloomThreshold;
			this.BloomSizeScale = BloomSizeScale;
			this.Bloom1Size = Bloom1Size;
			this.Bloom2Size = Bloom2Size;
			this.Bloom3Size = Bloom3Size;
			this.Bloom4Size = Bloom4Size;
			this.Bloom5Size = Bloom5Size;
			this.Bloom6Size = Bloom6Size;
			this.Bloom1Tint = Bloom1Tint;
			this.Bloom2Tint = Bloom2Tint;
			this.Bloom3Tint = Bloom3Tint;
			this.Bloom4Tint = Bloom4Tint;
			this.Bloom5Tint = Bloom5Tint;
			this.Bloom6Tint = Bloom6Tint;
			this.BloomDirtMask = BloomDirtMask;
			this.BloomDirtMaskIntensity = BloomDirtMaskIntensity;
			this.BloomDirtMaskTint = BloomDirtMaskTint;
			this.bMegaLights = bMegaLights;
			this.AmbientCubemapTint = AmbientCubemapTint;
			this.AmbientCubemapIntensity = AmbientCubemapIntensity;
			this.AmbientCubemap = AmbientCubemap;
			this.CameraShutterSpeed = CameraShutterSpeed;
			this.CameraISO = CameraISO;
			this.DepthOfFieldFstop = DepthOfFieldFstop;
			this.DepthOfFieldMinFstop = DepthOfFieldMinFstop;
			this.DepthOfFieldBladeCount = DepthOfFieldBladeCount;
			this.bUseForegroundBlur = bUseForegroundBlur;
			this.AutoExposureBias = AutoExposureBias;
			this.AutoExposureBiasBackup = AutoExposureBiasBackup;
			this.bOverride_AutoExposureBiasBackup = bOverride_AutoExposureBiasBackup;
			this.AutoExposureApplyPhysicalCameraExposure = AutoExposureApplyPhysicalCameraExposure;
			this.AutoExposureBiasCurve = AutoExposureBiasCurve;
			this.AutoExposureMeterMask = AutoExposureMeterMask;
			this.AutoExposureLowPercent = AutoExposureLowPercent;
			this.AutoExposureHighPercent = AutoExposureHighPercent;
			this.AutoExposureMinBrightness = AutoExposureMinBrightness;
			this.AutoExposureMaxBrightness = AutoExposureMaxBrightness;
			this.AutoExposureSpeedUp = AutoExposureSpeedUp;
			this.AutoExposureSpeedDown = AutoExposureSpeedDown;
			this.HistogramLogMin = HistogramLogMin;
			this.HistogramLogMax = HistogramLogMax;
			this.LocalExposureMethod = LocalExposureMethod;
			this.LocalExposureContrastScale_DEPRECATED = LocalExposureContrastScale_DEPRECATED;
			this.LocalExposureHighlightContrastScale = LocalExposureHighlightContrastScale;
			this.LocalExposureShadowContrastScale = LocalExposureShadowContrastScale;
			this.LocalExposureHighlightContrastCurve = LocalExposureHighlightContrastCurve;
			this.LocalExposureShadowContrastCurve = LocalExposureShadowContrastCurve;
			this.LocalExposureHighlightThreshold = LocalExposureHighlightThreshold;
			this.LocalExposureShadowThreshold = LocalExposureShadowThreshold;
			this.LocalExposureDetailStrength = LocalExposureDetailStrength;
			this.LocalExposureBlurredLuminanceBlend = LocalExposureBlurredLuminanceBlend;
			this.LocalExposureBlurredLuminanceKernelSizePercent = LocalExposureBlurredLuminanceKernelSizePercent;
			this.LocalExposureMiddleGreyBias = LocalExposureMiddleGreyBias;
			this.AutoExposureCalibrationConstant_DEPRECATED = AutoExposureCalibrationConstant_DEPRECATED;
			this.LensFlareIntensity = LensFlareIntensity;
			this.LensFlareTint = LensFlareTint;
			this.LensFlareBokehSize = LensFlareBokehSize;
			this.LensFlareThreshold = LensFlareThreshold;
			this.LensFlareBokehShape = LensFlareBokehShape;
			this.LensFlareTints = LensFlareTints;
			this.LensFlareOnlySun = LensFlareOnlySun;
			this.LensFlareSunRange = LensFlareSunRange;
			this.LensFlareSunPosition = LensFlareSunPosition;
			this.VignetteIntensity = VignetteIntensity;
			this.VignetteHardness = VignetteHardness;
			this.VignetteXScale = VignetteXScale;
			this.VignetteYScale = VignetteYScale;
			this.VignetteXPos = VignetteXPos;
			this.VignetteYPos = VignetteYPos;
			this.VignetteColor = VignetteColor;
			this.VignetteGain = VignetteGain;
			this.EffectVignetteIntensity = EffectVignetteIntensity;
			this.EffectVignetteHardness = EffectVignetteHardness;
			this.EffectVignetteXScale = EffectVignetteXScale;
			this.EffectVignetteYScale = EffectVignetteYScale;
			this.EffectVignetteXPos = EffectVignetteXPos;
			this.EffectVignetteYPos = EffectVignetteYPos;
			this.EffectVignetteColor = EffectVignetteColor;
			this.EffectVignetteGain = EffectVignetteGain;
			this.GrainJitter = GrainJitter;
			this.GrainIntensity = GrainIntensity;
			this.GrainColorful = GrainColorful;
			this.MainCenterMask = MainCenterMask;
			this.MainCenterMaskRadius = MainCenterMaskRadius;
			this.MainCenterMaskHardness = MainCenterMaskHardness;
			this.MainStartDistance = MainStartDistance;
			this.MainCharacterIntensity = MainCharacterIntensity;
			this.VintageColorIntensity = VintageColorIntensity;
			this.VintageColorBlackPoint = VintageColorBlackPoint;
			this.VintageColorWhitePoint = VintageColorWhitePoint;
			this.VHSLinesColorIntensity = VHSLinesColorIntensity;
			this.VHSLinesDistortIntensity = VHSLinesDistortIntensity;
			this.VHSEffectIntensity = VHSEffectIntensity;
			this.VHSSpecklesIntensity = VHSSpecklesIntensity;
			this.VHSSpecklesAmount = VHSSpecklesAmount;
			this.VHSSpecklesSize = VHSSpecklesSize;
			this.CRTDistortion = CRTDistortion;
			this.VintageColorCenterMask = VintageColorCenterMask;
			this.VintageColorStartDistance = VintageColorStartDistance;
			this.VintageColorCharacterIntensity = VintageColorCharacterIntensity;
			this.VHSLinesCenterMask = VHSLinesCenterMask;
			this.VHSLinesStartDistance = VHSLinesStartDistance;
			this.VHSLinesCharacterIntensity = VHSLinesCharacterIntensity;
			this.VHSEffectCenterMask = VHSEffectCenterMask;
			this.VHSEffectStartDistance = VHSEffectStartDistance;
			this.VHSEffectCharacterIntensity = VHSEffectCharacterIntensity;
			this.VHSSpecklesCenterMask = VHSSpecklesCenterMask;
			this.VHSSpecklesStartDistance = VHSSpecklesStartDistance;
			this.VHSSpecklesCharacterIntensity = VHSSpecklesCharacterIntensity;
			this.AmbientOcclusionIntensity = AmbientOcclusionIntensity;
			this.AmbientOcclusionStaticFraction = AmbientOcclusionStaticFraction;
			this.AmbientOcclusionRadius = AmbientOcclusionRadius;
			this.AmbientOcclusionRadiusInWS = AmbientOcclusionRadiusInWS;
			this.AmbientOcclusionFadeDistance = AmbientOcclusionFadeDistance;
			this.AmbientOcclusionFadeRadius = AmbientOcclusionFadeRadius;
			this.AmbientOcclusionDistance_DEPRECATED = AmbientOcclusionDistance_DEPRECATED;
			this.AmbientOcclusionPower = AmbientOcclusionPower;
			this.AmbientOcclusionBias = AmbientOcclusionBias;
			this.AmbientOcclusionQuality = AmbientOcclusionQuality;
			this.AmbientOcclusionMipBlend = AmbientOcclusionMipBlend;
			this.AmbientOcclusionMipScale = AmbientOcclusionMipScale;
			this.AmbientOcclusionMipThreshold = AmbientOcclusionMipThreshold;
			this.AmbientOcclusionTemporalBlendWeight = AmbientOcclusionTemporalBlendWeight;
			this.RayTracingAO = RayTracingAO;
			this.RayTracingAOSamplesPerPixel = RayTracingAOSamplesPerPixel;
			this.RayTracingAOIntensity = RayTracingAOIntensity;
			this.RayTracingAORadius = RayTracingAORadius;
			this.LumenSkylightLeaking = LumenSkylightLeaking;
			this.IndirectLightingColor = IndirectLightingColor;
			this.IndirectLightingIntensity = IndirectLightingIntensity;
			this.RayTracingGIType = RayTracingGIType;
			this.RayTracingGIMaxBounces = RayTracingGIMaxBounces;
			this.RayTracingGISamplesPerPixel = RayTracingGISamplesPerPixel;
			this.ColorGradingIntensity = ColorGradingIntensity;
			this.ColorGradingLUT = ColorGradingLUT;
			this.DepthOfFieldSensorWidth = DepthOfFieldSensorWidth;
			this.DepthOfFieldFocalDistance = DepthOfFieldFocalDistance;
			this.DepthOfFieldDepthBlurAmount = DepthOfFieldDepthBlurAmount;
			this.DepthOfFieldDepthBlurRadius = DepthOfFieldDepthBlurRadius;
			this.DepthOfFieldFocalRegion = DepthOfFieldFocalRegion;
			this.DepthOfFieldNearTransitionRegion = DepthOfFieldNearTransitionRegion;
			this.DepthOfFieldFarTransitionRegion = DepthOfFieldFarTransitionRegion;
			this.DepthOfFieldScale = DepthOfFieldScale;
			this.DepthOfFieldNearBlurSize = DepthOfFieldNearBlurSize;
			this.DepthOfFieldFarBlurSize = DepthOfFieldFarBlurSize;
			this.DepthOfFieldOcclusion = DepthOfFieldOcclusion;
			this.DepthOfFieldSkyFocusDistance = DepthOfFieldSkyFocusDistance;
			this.DepthOfFieldVignetteSize = DepthOfFieldVignetteSize;
			this.MotionBlurAmount = MotionBlurAmount;
			this.MotionBlurMax = MotionBlurMax;
			this.MotionBlurTargetFPS = MotionBlurTargetFPS;
			this.MotionBlurPerObjectSize = MotionBlurPerObjectSize;
			this.bMotionBlurCharacterMask = bMotionBlurCharacterMask;
			this.LPVIntensity = LPVIntensity;
			this.LPVVplInjectionBias = LPVVplInjectionBias;
			this.LPVSize = LPVSize;
			this.LPVSecondaryOcclusionIntensity = LPVSecondaryOcclusionIntensity;
			this.LPVSecondaryBounceIntensity = LPVSecondaryBounceIntensity;
			this.LPVGeometryVolumeBias = LPVGeometryVolumeBias;
			this.LPVEmissiveInjectionIntensity = LPVEmissiveInjectionIntensity;
			this.LPVDirectionalOcclusionIntensity = LPVDirectionalOcclusionIntensity;
			this.LPVDirectionalOcclusionRadius = LPVDirectionalOcclusionRadius;
			this.LPVDiffuseOcclusionExponent = LPVDiffuseOcclusionExponent;
			this.LPVSpecularOcclusionExponent = LPVSpecularOcclusionExponent;
			this.LPVDiffuseOcclusionIntensity = LPVDiffuseOcclusionIntensity;
			this.LPVSpecularOcclusionIntensity = LPVSpecularOcclusionIntensity;
			this.ReflectionsType = ReflectionsType;
			this.ScreenSpaceReflectionIntensity = ScreenSpaceReflectionIntensity;
			this.ScreenSpaceReflectionQuality = ScreenSpaceReflectionQuality;
			this.ScreenSpaceReflectionMaxRoughness = ScreenSpaceReflectionMaxRoughness;
			this.RayTracingReflectionsMaxRoughness = RayTracingReflectionsMaxRoughness;
			this.RayTracingReflectionsMaxBounces = RayTracingReflectionsMaxBounces;
			this.RayTracingReflectionsSamplesPerPixel = RayTracingReflectionsSamplesPerPixel;
			this.RayTracingReflectionsShadows = RayTracingReflectionsShadows;
			this.RayTracingReflectionsTranslucency = RayTracingReflectionsTranslucency;
			this.TranslucencyType = TranslucencyType;
			this.RayTracingTranslucencyMaxRoughness = RayTracingTranslucencyMaxRoughness;
			this.RayTracingTranslucencyRefractionRays = RayTracingTranslucencyRefractionRays;
			this.RayTracingTranslucencySamplesPerPixel = RayTracingTranslucencySamplesPerPixel;
			this.RayTracingTranslucencyShadows = RayTracingTranslucencyShadows;
			this.RayTracingTranslucencyRefraction = RayTracingTranslucencyRefraction;
			this.PathTracingMaxBounces = PathTracingMaxBounces;
			this.PathTracingSamplesPerPixel = PathTracingSamplesPerPixel;
			this.LPVFadeRange = LPVFadeRange;
			this.LPVDirectionalOcclusionFadeRange = LPVDirectionalOcclusionFadeRange;
			this.ScreenPercentage = ScreenPercentage;
			this.WithOutTranslucent = WithOutTranslucent;
			this.StartPosSwitch = StartPosSwitch;
			this.GrayGradationStartPos = GrayGradationStartPos;
			this.GrayGradationDegree = GrayGradationDegree;
			this.GrayLerpWidth = GrayLerpWidth;
			this.GrayRampColor = GrayRampColor;
			this.GrayRampTint = GrayRampTint;
			this.GrayRampBlendWeight = GrayRampBlendWeight;
			this.SNNIntensity = SNNIntensity;
			this.SNNRoughnessContrast = SNNRoughnessContrast;
			this.SNNMetallicThreshold = SNNMetallicThreshold;
			this.SNNDepthFade = SNNDepthFade;
			this.SNNFoliageIntensity = SNNFoliageIntensity;
			this.SNNStructureIntensity = SNNStructureIntensity;
			this.SNNNoiseIntensity = SNNNoiseIntensity;
			this.SNNEnableSharpen = SNNEnableSharpen;
			this.SNNSharpeness = SNNSharpeness;
			this.SNNSharpenDepthFade = SNNSharpenDepthFade;
			this.SSFSIntensity = SSFSIntensity;
			this.SSFSRadius = SSFSRadius;
			this.SSFSLuminanceWeighting = SSFSLuminanceWeighting;
			this.SSFSSkyAtmosphereIntensity = SSFSSkyAtmosphereIntensity;
			this.SSFSVolumetricFogILSIntensity = SSFSVolumetricFogILSIntensity;
			this.SSFSKuroVolumetricLightILSIntensity = SSFSKuroVolumetricLightILSIntensity;
			this.SSFSStartDistance = SSFSStartDistance;
			this.SSFSMaxDepth = SSFSMaxDepth;
			this.EnableMobileSSFS = EnableMobileSSFS;
			this.MobileSSFSFogDensity = MobileSSFSFogDensity;
			this.MobileSSFSIntensity = MobileSSFSIntensity;
			this.MobileSSFSRadius = MobileSSFSRadius;
			this.MobileSSFSStartDistance = MobileSSFSStartDistance;
			this.KuroSharpenRadius = KuroSharpenRadius;
			this.KuroSharpenAmount = KuroSharpenAmount;
			this.KuroLaplacianAmount = KuroLaplacianAmount;
			this.KuroSharpenIntensity = KuroSharpenIntensity;
			this.KuroToonSharpenIntensity = KuroToonSharpenIntensity;
			this.KuroSharpenDistance = KuroSharpenDistance;
			this.TyndallScaLightIntensity = TyndallScaLightIntensity;
			this.TyndallDarkIntensity = TyndallDarkIntensity;
			this.TyndallScaLightLength = TyndallScaLightLength;
			this.TyndallScaLightColor = TyndallScaLightColor;
			this.TyndallScaLightFade = TyndallScaLightFade;
			this.TyndallScaLightMode = TyndallScaLightMode;
			this.TyndallScaNearFade = TyndallScaNearFade;
			this.TyndallScaDarkFadeDepth = TyndallScaDarkFadeDepth;
			this.TyndallScaMaxDepth = TyndallScaMaxDepth;
			this.EnableCustomPosition = EnableCustomPosition;
			this.TyndallCustomPosition = TyndallCustomPosition;
			this.KuroVolumetricLightEnable = KuroVolumetricLightEnable;
			this.KuroVolumetricLightIntensity = KuroVolumetricLightIntensity;
			this.KuroVolumetricLightColor = KuroVolumetricLightColor;
			this.KuroVolumetricLightPhaseG = KuroVolumetricLightPhaseG;
			this.KuroVolumetricLightMaxDistance = KuroVolumetricLightMaxDistance;
			this.KuroVolumetricLightBlurRadius = KuroVolumetricLightBlurRadius;
			this.KuroVolumetricLightUseColorMask = KuroVolumetricLightUseColorMask;
			this.KuroVolumetricLightColorMaskIntensity = KuroVolumetricLightColorMaskIntensity;
			this.KuroCharacterLUTSplitEnable = KuroCharacterLUTSplitEnable;
			this.KuroCharacterColorGradingLUT = KuroCharacterColorGradingLUT;
			this.KuroCharacterColorGradingLUTLerpIntensity = KuroCharacterColorGradingLUTLerpIntensity;
			this.KuroColorGradingTextureLUTInterpolationEnable = KuroColorGradingTextureLUTInterpolationEnable;
			this.WeightedBlendables = WeightedBlendables;
		}

		// Token: 0x0600E897 RID: 59543 RVA: 0x001598CC File Offset: 0x00157ACC
		protected override IntPtr GetUStructPtr()
		{
			return FPostProcessSettings.StaticStruct();
		}

		// Token: 0x0600E898 RID: 59544 RVA: 0x001598D8 File Offset: 0x00157AD8
		public FPostProcessSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0600E899 RID: 59545 RVA: 0x001598E2 File Offset: 0x00157AE2
		public FPostProcessSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0600E89A RID: 59546 RVA: 0x001598ED File Offset: 0x00157AED
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FPostProcessSettings(Pointer, false, true);
		}

		// Token: 0x0600E89B RID: 59547 RVA: 0x001598F7 File Offset: 0x00157AF7
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FPostProcessSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04007961 RID: 31073
		[Nullable(1)]
		public const string __ObjectPath = "/Script/Engine.PostProcessSettings";

		// Token: 0x04007962 RID: 31074
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04007963 RID: 31075
		internal static int __PropertyOffset_bOverride_WhiteTemp;

		// Token: 0x04007964 RID: 31076
		internal static byte __PropertyMask_bOverride_WhiteTemp;

		// Token: 0x04007965 RID: 31077
		internal static int __PropertyOffset_bOverride_WhiteTint;

		// Token: 0x04007966 RID: 31078
		internal static byte __PropertyMask_bOverride_WhiteTint;

		// Token: 0x04007967 RID: 31079
		internal static int __PropertyOffset_bOverride_ColorSaturation;

		// Token: 0x04007968 RID: 31080
		internal static byte __PropertyMask_bOverride_ColorSaturation;

		// Token: 0x04007969 RID: 31081
		internal static int __PropertyOffset_bOverride_ColorContrast;

		// Token: 0x0400796A RID: 31082
		internal static byte __PropertyMask_bOverride_ColorContrast;

		// Token: 0x0400796B RID: 31083
		internal static int __PropertyOffset_bOverride_ColorGamma;

		// Token: 0x0400796C RID: 31084
		internal static byte __PropertyMask_bOverride_ColorGamma;

		// Token: 0x0400796D RID: 31085
		internal static int __PropertyOffset_bOverride_ColorGain;

		// Token: 0x0400796E RID: 31086
		internal static byte __PropertyMask_bOverride_ColorGain;

		// Token: 0x0400796F RID: 31087
		internal static int __PropertyOffset_bOverride_ColorOffset;

		// Token: 0x04007970 RID: 31088
		internal static byte __PropertyMask_bOverride_ColorOffset;

		// Token: 0x04007971 RID: 31089
		internal static int __PropertyOffset_bOverride_ColorSaturationShadows;

		// Token: 0x04007972 RID: 31090
		internal static byte __PropertyMask_bOverride_ColorSaturationShadows;

		// Token: 0x04007973 RID: 31091
		internal static int __PropertyOffset_bOverride_ColorContrastShadows;

		// Token: 0x04007974 RID: 31092
		internal static byte __PropertyMask_bOverride_ColorContrastShadows;

		// Token: 0x04007975 RID: 31093
		internal static int __PropertyOffset_bOverride_ColorGammaShadows;

		// Token: 0x04007976 RID: 31094
		internal static byte __PropertyMask_bOverride_ColorGammaShadows;

		// Token: 0x04007977 RID: 31095
		internal static int __PropertyOffset_bOverride_ColorGainShadows;

		// Token: 0x04007978 RID: 31096
		internal static byte __PropertyMask_bOverride_ColorGainShadows;

		// Token: 0x04007979 RID: 31097
		internal static int __PropertyOffset_bOverride_ColorOffsetShadows;

		// Token: 0x0400797A RID: 31098
		internal static byte __PropertyMask_bOverride_ColorOffsetShadows;

		// Token: 0x0400797B RID: 31099
		internal static int __PropertyOffset_bOverride_ColorSaturationMidtones;

		// Token: 0x0400797C RID: 31100
		internal static byte __PropertyMask_bOverride_ColorSaturationMidtones;

		// Token: 0x0400797D RID: 31101
		internal static int __PropertyOffset_bOverride_ColorContrastMidtones;

		// Token: 0x0400797E RID: 31102
		internal static byte __PropertyMask_bOverride_ColorContrastMidtones;

		// Token: 0x0400797F RID: 31103
		internal static int __PropertyOffset_bOverride_ColorGammaMidtones;

		// Token: 0x04007980 RID: 31104
		internal static byte __PropertyMask_bOverride_ColorGammaMidtones;

		// Token: 0x04007981 RID: 31105
		internal static int __PropertyOffset_bOverride_ColorGainMidtones;

		// Token: 0x04007982 RID: 31106
		internal static byte __PropertyMask_bOverride_ColorGainMidtones;

		// Token: 0x04007983 RID: 31107
		internal static int __PropertyOffset_bOverride_ColorOffsetMidtones;

		// Token: 0x04007984 RID: 31108
		internal static byte __PropertyMask_bOverride_ColorOffsetMidtones;

		// Token: 0x04007985 RID: 31109
		internal static int __PropertyOffset_bOverride_ColorSaturationHighlights;

		// Token: 0x04007986 RID: 31110
		internal static byte __PropertyMask_bOverride_ColorSaturationHighlights;

		// Token: 0x04007987 RID: 31111
		internal static int __PropertyOffset_bOverride_ColorContrastHighlights;

		// Token: 0x04007988 RID: 31112
		internal static byte __PropertyMask_bOverride_ColorContrastHighlights;

		// Token: 0x04007989 RID: 31113
		internal static int __PropertyOffset_bOverride_ColorGammaHighlights;

		// Token: 0x0400798A RID: 31114
		internal static byte __PropertyMask_bOverride_ColorGammaHighlights;

		// Token: 0x0400798B RID: 31115
		internal static int __PropertyOffset_bOverride_ColorGainHighlights;

		// Token: 0x0400798C RID: 31116
		internal static byte __PropertyMask_bOverride_ColorGainHighlights;

		// Token: 0x0400798D RID: 31117
		internal static int __PropertyOffset_bOverride_ColorOffsetHighlights;

		// Token: 0x0400798E RID: 31118
		internal static byte __PropertyMask_bOverride_ColorOffsetHighlights;

		// Token: 0x0400798F RID: 31119
		internal static int __PropertyOffset_bOverride_ColorCorrectionShadowsMax;

		// Token: 0x04007990 RID: 31120
		internal static byte __PropertyMask_bOverride_ColorCorrectionShadowsMax;

		// Token: 0x04007991 RID: 31121
		internal static int __PropertyOffset_bOverride_ColorCorrectionHighlightsMin;

		// Token: 0x04007992 RID: 31122
		internal static byte __PropertyMask_bOverride_ColorCorrectionHighlightsMin;

		// Token: 0x04007993 RID: 31123
		internal static int __PropertyOffset_bOverride_BlueCorrection;

		// Token: 0x04007994 RID: 31124
		internal static byte __PropertyMask_bOverride_BlueCorrection;

		// Token: 0x04007995 RID: 31125
		internal static int __PropertyOffset_bOverride_ExpandGamut;

		// Token: 0x04007996 RID: 31126
		internal static byte __PropertyMask_bOverride_ExpandGamut;

		// Token: 0x04007997 RID: 31127
		internal static int __PropertyOffset_bOverride_ToneCurveAmount;

		// Token: 0x04007998 RID: 31128
		internal static byte __PropertyMask_bOverride_ToneCurveAmount;

		// Token: 0x04007999 RID: 31129
		internal static int __PropertyOffset_bOverride_FilmWhitePoint;

		// Token: 0x0400799A RID: 31130
		internal static byte __PropertyMask_bOverride_FilmWhitePoint;

		// Token: 0x0400799B RID: 31131
		internal static int __PropertyOffset_bOverride_FilmSaturation;

		// Token: 0x0400799C RID: 31132
		internal static byte __PropertyMask_bOverride_FilmSaturation;

		// Token: 0x0400799D RID: 31133
		internal static int __PropertyOffset_bOverride_FilmChannelMixerRed;

		// Token: 0x0400799E RID: 31134
		internal static byte __PropertyMask_bOverride_FilmChannelMixerRed;

		// Token: 0x0400799F RID: 31135
		internal static int __PropertyOffset_bOverride_FilmChannelMixerGreen;

		// Token: 0x040079A0 RID: 31136
		internal static byte __PropertyMask_bOverride_FilmChannelMixerGreen;

		// Token: 0x040079A1 RID: 31137
		internal static int __PropertyOffset_bOverride_FilmChannelMixerBlue;

		// Token: 0x040079A2 RID: 31138
		internal static byte __PropertyMask_bOverride_FilmChannelMixerBlue;

		// Token: 0x040079A3 RID: 31139
		internal static int __PropertyOffset_bOverride_FilmContrast;

		// Token: 0x040079A4 RID: 31140
		internal static byte __PropertyMask_bOverride_FilmContrast;

		// Token: 0x040079A5 RID: 31141
		internal static int __PropertyOffset_bOverride_FilmDynamicRange;

		// Token: 0x040079A6 RID: 31142
		internal static byte __PropertyMask_bOverride_FilmDynamicRange;

		// Token: 0x040079A7 RID: 31143
		internal static int __PropertyOffset_bOverride_FilmHealAmount;

		// Token: 0x040079A8 RID: 31144
		internal static byte __PropertyMask_bOverride_FilmHealAmount;

		// Token: 0x040079A9 RID: 31145
		internal static int __PropertyOffset_bOverride_FilmToeAmount;

		// Token: 0x040079AA RID: 31146
		internal static byte __PropertyMask_bOverride_FilmToeAmount;

		// Token: 0x040079AB RID: 31147
		internal static int __PropertyOffset_bOverride_FilmShadowTint;

		// Token: 0x040079AC RID: 31148
		internal static byte __PropertyMask_bOverride_FilmShadowTint;

		// Token: 0x040079AD RID: 31149
		internal static int __PropertyOffset_bOverride_FilmShadowTintBlend;

		// Token: 0x040079AE RID: 31150
		internal static byte __PropertyMask_bOverride_FilmShadowTintBlend;

		// Token: 0x040079AF RID: 31151
		internal static int __PropertyOffset_bOverride_FilmShadowTintAmount;

		// Token: 0x040079B0 RID: 31152
		internal static byte __PropertyMask_bOverride_FilmShadowTintAmount;

		// Token: 0x040079B1 RID: 31153
		internal static int __PropertyOffset_bOverride_FilmSlope;

		// Token: 0x040079B2 RID: 31154
		internal static byte __PropertyMask_bOverride_FilmSlope;

		// Token: 0x040079B3 RID: 31155
		internal static int __PropertyOffset_bOverride_FilmToe;

		// Token: 0x040079B4 RID: 31156
		internal static byte __PropertyMask_bOverride_FilmToe;

		// Token: 0x040079B5 RID: 31157
		internal static int __PropertyOffset_bOverride_FilmShoulder;

		// Token: 0x040079B6 RID: 31158
		internal static byte __PropertyMask_bOverride_FilmShoulder;

		// Token: 0x040079B7 RID: 31159
		internal static int __PropertyOffset_bOverride_FilmBlackClip;

		// Token: 0x040079B8 RID: 31160
		internal static byte __PropertyMask_bOverride_FilmBlackClip;

		// Token: 0x040079B9 RID: 31161
		internal static int __PropertyOffset_bOverride_FilmWhiteClip;

		// Token: 0x040079BA RID: 31162
		internal static byte __PropertyMask_bOverride_FilmWhiteClip;

		// Token: 0x040079BB RID: 31163
		internal static int __PropertyOffset_bOverride_SceneColorTint;

		// Token: 0x040079BC RID: 31164
		internal static byte __PropertyMask_bOverride_SceneColorTint;

		// Token: 0x040079BD RID: 31165
		internal static int __PropertyOffset_bOverride_DecalSaturation;

		// Token: 0x040079BE RID: 31166
		internal static byte __PropertyMask_bOverride_DecalSaturation;

		// Token: 0x040079BF RID: 31167
		internal static int __PropertyOffset_bOverride_DecalOpacity;

		// Token: 0x040079C0 RID: 31168
		internal static byte __PropertyMask_bOverride_DecalOpacity;

		// Token: 0x040079C1 RID: 31169
		internal static int __PropertyOffset_bOverride_TranslucentColorTint;

		// Token: 0x040079C2 RID: 31170
		internal static byte __PropertyMask_bOverride_TranslucentColorTint;

		// Token: 0x040079C3 RID: 31171
		internal static int __PropertyOffset_bOverride_SceneColorDesaturate;

		// Token: 0x040079C4 RID: 31172
		internal static byte __PropertyMask_bOverride_SceneColorDesaturate;

		// Token: 0x040079C5 RID: 31173
		internal static int __PropertyOffset_bOverride_SceneColorClear;

		// Token: 0x040079C6 RID: 31174
		internal static byte __PropertyMask_bOverride_SceneColorClear;

		// Token: 0x040079C7 RID: 31175
		internal static int __PropertyOffset_bOverride_SceneColorClearColor;

		// Token: 0x040079C8 RID: 31176
		internal static byte __PropertyMask_bOverride_SceneColorClearColor;

		// Token: 0x040079C9 RID: 31177
		internal static int __PropertyOffset_bOverride_SceneColorClearCenter;

		// Token: 0x040079CA RID: 31178
		internal static byte __PropertyMask_bOverride_SceneColorClearCenter;

		// Token: 0x040079CB RID: 31179
		internal static int __PropertyOffset_bOverride_SceneColorClearRadius;

		// Token: 0x040079CC RID: 31180
		internal static byte __PropertyMask_bOverride_SceneColorClearRadius;

		// Token: 0x040079CD RID: 31181
		internal static int __PropertyOffset_bOverride_SceneColorClearFadeDistance;

		// Token: 0x040079CE RID: 31182
		internal static byte __PropertyMask_bOverride_SceneColorClearFadeDistance;

		// Token: 0x040079CF RID: 31183
		internal static int __PropertyOffset_bOverride_TranslucentColorDesaturate;

		// Token: 0x040079D0 RID: 31184
		internal static byte __PropertyMask_bOverride_TranslucentColorDesaturate;

		// Token: 0x040079D1 RID: 31185
		internal static int __PropertyOffset_bOverride_FightTranslucentNoDesaturate;

		// Token: 0x040079D2 RID: 31186
		internal static byte __PropertyMask_bOverride_FightTranslucentNoDesaturate;

		// Token: 0x040079D3 RID: 31187
		internal static int __PropertyOffset_bOverride_SceneTranslucentColorTint;

		// Token: 0x040079D4 RID: 31188
		internal static byte __PropertyMask_bOverride_SceneTranslucentColorTint;

		// Token: 0x040079D5 RID: 31189
		internal static int __PropertyOffset_bOverride_SceneEmissiveTint;

		// Token: 0x040079D6 RID: 31190
		internal static byte __PropertyMask_bOverride_SceneEmissiveTint;

		// Token: 0x040079D7 RID: 31191
		internal static int __PropertyOffset_bOverride_SceneTranslucentColorDesaturate;

		// Token: 0x040079D8 RID: 31192
		internal static byte __PropertyMask_bOverride_SceneTranslucentColorDesaturate;

		// Token: 0x040079D9 RID: 31193
		internal static int __PropertyOffset_bOverride_EnableSPD;

		// Token: 0x040079DA RID: 31194
		internal static byte __PropertyMask_bOverride_EnableSPD;

		// Token: 0x040079DB RID: 31195
		internal static int __PropertyOffset_bOverride_SceneFringeIntensity;

		// Token: 0x040079DC RID: 31196
		internal static byte __PropertyMask_bOverride_SceneFringeIntensity;

		// Token: 0x040079DD RID: 31197
		internal static int __PropertyOffset_bOverride_ChromaticAberrationStartOffset;

		// Token: 0x040079DE RID: 31198
		internal static byte __PropertyMask_bOverride_ChromaticAberrationStartOffset;

		// Token: 0x040079DF RID: 31199
		internal static int __PropertyOffset_bOverride_BaoChromaticAberrationIntensity;

		// Token: 0x040079E0 RID: 31200
		internal static byte __PropertyMask_bOverride_BaoChromaticAberrationIntensity;

		// Token: 0x040079E1 RID: 31201
		internal static int __PropertyOffset_bOverride_BaoChromaticAberrationMaskCenter;

		// Token: 0x040079E2 RID: 31202
		internal static byte __PropertyMask_bOverride_BaoChromaticAberrationMaskCenter;

		// Token: 0x040079E3 RID: 31203
		internal static int __PropertyOffset_bOverride_BaoChromaticAberrationYScale;

		// Token: 0x040079E4 RID: 31204
		internal static byte __PropertyMask_bOverride_BaoChromaticAberrationYScale;

		// Token: 0x040079E5 RID: 31205
		internal static int __PropertyOffset_bOverride_BaoChromaticAberrationYPan;

		// Token: 0x040079E6 RID: 31206
		internal static byte __PropertyMask_bOverride_BaoChromaticAberrationYPan;

		// Token: 0x040079E7 RID: 31207
		internal static int __PropertyOffset_bOverride_bMegaLights;

		// Token: 0x040079E8 RID: 31208
		internal static byte __PropertyMask_bOverride_bMegaLights;

		// Token: 0x040079E9 RID: 31209
		internal static int __PropertyOffset_bOverride_AmbientCubemapTint;

		// Token: 0x040079EA RID: 31210
		internal static byte __PropertyMask_bOverride_AmbientCubemapTint;

		// Token: 0x040079EB RID: 31211
		internal static int __PropertyOffset_bOverride_AmbientCubemapIntensity;

		// Token: 0x040079EC RID: 31212
		internal static byte __PropertyMask_bOverride_AmbientCubemapIntensity;

		// Token: 0x040079ED RID: 31213
		internal static int __PropertyOffset_bOverride_BloomMethod;

		// Token: 0x040079EE RID: 31214
		internal static byte __PropertyMask_bOverride_BloomMethod;

		// Token: 0x040079EF RID: 31215
		internal static int __PropertyOffset_bOverride_BloomIntensity;

		// Token: 0x040079F0 RID: 31216
		internal static byte __PropertyMask_bOverride_BloomIntensity;

		// Token: 0x040079F1 RID: 31217
		internal static int __PropertyOffset_bOverride_KuroFoliageMaterialAO;

		// Token: 0x040079F2 RID: 31218
		internal static byte __PropertyMask_bOverride_KuroFoliageMaterialAO;

		// Token: 0x040079F3 RID: 31219
		internal static int __PropertyOffset_bOverride_KuroFoliageScreenSpaceAO;

		// Token: 0x040079F4 RID: 31220
		internal static byte __PropertyMask_bOverride_KuroFoliageScreenSpaceAO;

		// Token: 0x040079F5 RID: 31221
		internal static int __PropertyOffset_bOverride_UseFixCharacterRim;

		// Token: 0x040079F6 RID: 31222
		internal static byte __PropertyMask_bOverride_UseFixCharacterRim;

		// Token: 0x040079F7 RID: 31223
		internal static int __PropertyOffset_bOverride_FixCharacterRimAngleV;

		// Token: 0x040079F8 RID: 31224
		internal static byte __PropertyMask_bOverride_FixCharacterRimAngleV;

		// Token: 0x040079F9 RID: 31225
		internal static int __PropertyOffset_bOverride_FixCharacterRimAngleH;

		// Token: 0x040079FA RID: 31226
		internal static byte __PropertyMask_bOverride_FixCharacterRimAngleH;

		// Token: 0x040079FB RID: 31227
		internal static int __PropertyOffset_bOverride_UseCustomRim;

		// Token: 0x040079FC RID: 31228
		internal static byte __PropertyMask_bOverride_UseCustomRim;

		// Token: 0x040079FD RID: 31229
		internal static int __PropertyOffset_bOverride_CustomRimColor_Stencil1;

		// Token: 0x040079FE RID: 31230
		internal static byte __PropertyMask_bOverride_CustomRimColor_Stencil1;

		// Token: 0x040079FF RID: 31231
		internal static int __PropertyOffset_bOverride_FixCharacterRimAngleV_Stencil1;

		// Token: 0x04007A00 RID: 31232
		internal static byte __PropertyMask_bOverride_FixCharacterRimAngleV_Stencil1;

		// Token: 0x04007A01 RID: 31233
		internal static int __PropertyOffset_bOverride_FixCharacterRimAngleH_Stencil1;

		// Token: 0x04007A02 RID: 31234
		internal static byte __PropertyMask_bOverride_FixCharacterRimAngleH_Stencil1;

		// Token: 0x04007A03 RID: 31235
		internal static int __PropertyOffset_bOverride_CustomRimColor_Stencil2;

		// Token: 0x04007A04 RID: 31236
		internal static byte __PropertyMask_bOverride_CustomRimColor_Stencil2;

		// Token: 0x04007A05 RID: 31237
		internal static int __PropertyOffset_bOverride_FixCharacterRimAngleV_Stencil2;

		// Token: 0x04007A06 RID: 31238
		internal static byte __PropertyMask_bOverride_FixCharacterRimAngleV_Stencil2;

		// Token: 0x04007A07 RID: 31239
		internal static int __PropertyOffset_bOverride_FixCharacterRimAngleH_Stencil2;

		// Token: 0x04007A08 RID: 31240
		internal static byte __PropertyMask_bOverride_FixCharacterRimAngleH_Stencil2;

		// Token: 0x04007A09 RID: 31241
		internal static int __PropertyOffset_bOverride_CustomRimColor_Stencil3;

		// Token: 0x04007A0A RID: 31242
		internal static byte __PropertyMask_bOverride_CustomRimColor_Stencil3;

		// Token: 0x04007A0B RID: 31243
		internal static int __PropertyOffset_bOverride_FixCharacterRimAngleV_Stencil3;

		// Token: 0x04007A0C RID: 31244
		internal static byte __PropertyMask_bOverride_FixCharacterRimAngleV_Stencil3;

		// Token: 0x04007A0D RID: 31245
		internal static int __PropertyOffset_bOverride_FixCharacterRimAngleH_Stencil3;

		// Token: 0x04007A0E RID: 31246
		internal static byte __PropertyMask_bOverride_FixCharacterRimAngleH_Stencil3;

		// Token: 0x04007A0F RID: 31247
		internal static int __PropertyOffset_bOverride_KuroBloomIntensity;

		// Token: 0x04007A10 RID: 31248
		internal static byte __PropertyMask_bOverride_KuroBloomIntensity;

		// Token: 0x04007A11 RID: 31249
		internal static int __PropertyOffset_bOverride_KuroBloomThreshold;

		// Token: 0x04007A12 RID: 31250
		internal static byte __PropertyMask_bOverride_KuroBloomThreshold;

		// Token: 0x04007A13 RID: 31251
		internal static int __PropertyOffset_bOverride_EnableSplitCharBloom;

		// Token: 0x04007A14 RID: 31252
		internal static byte __PropertyMask_bOverride_EnableSplitCharBloom;

		// Token: 0x04007A15 RID: 31253
		internal static int __PropertyOffset_bOverride_KuroCharacterBloomIntensity;

		// Token: 0x04007A16 RID: 31254
		internal static byte __PropertyMask_bOverride_KuroCharacterBloomIntensity;

		// Token: 0x04007A17 RID: 31255
		internal static int __PropertyOffset_bOverride_KuroCharacterBloomThreshold;

		// Token: 0x04007A18 RID: 31256
		internal static byte __PropertyMask_bOverride_KuroCharacterBloomThreshold;

		// Token: 0x04007A19 RID: 31257
		internal static int __PropertyOffset_bOverride_SunDirBloomIntensity;

		// Token: 0x04007A1A RID: 31258
		internal static byte __PropertyMask_bOverride_SunDirBloomIntensity;

		// Token: 0x04007A1B RID: 31259
		internal static int __PropertyOffset_bOverride_KuroBloomCombineParameter;

		// Token: 0x04007A1C RID: 31260
		internal static byte __PropertyMask_bOverride_KuroBloomCombineParameter;

		// Token: 0x04007A1D RID: 31261
		internal static int __PropertyOffset_bOverride_KuroBloomStreakIntensity;

		// Token: 0x04007A1E RID: 31262
		internal static byte __PropertyMask_bOverride_KuroBloomStreakIntensity;

		// Token: 0x04007A1F RID: 31263
		internal static int __PropertyOffset_bOverride_KuroBloomStreakThreshold;

		// Token: 0x04007A20 RID: 31264
		internal static byte __PropertyMask_bOverride_KuroBloomStreakThreshold;

		// Token: 0x04007A21 RID: 31265
		internal static int __PropertyOffset_bOverride_TranslucentBloomStreakIntensity;

		// Token: 0x04007A22 RID: 31266
		internal static byte __PropertyMask_bOverride_TranslucentBloomStreakIntensity;

		// Token: 0x04007A23 RID: 31267
		internal static int __PropertyOffset_bOverride_TranslucentBloomStreakThreshold;

		// Token: 0x04007A24 RID: 31268
		internal static byte __PropertyMask_bOverride_TranslucentBloomStreakThreshold;

		// Token: 0x04007A25 RID: 31269
		internal static int __PropertyOffset_bOverride_KuroBloomStreakLength;

		// Token: 0x04007A26 RID: 31270
		internal static byte __PropertyMask_bOverride_KuroBloomStreakLength;

		// Token: 0x04007A27 RID: 31271
		internal static int __PropertyOffset_bOverride_KuroBloomStreakMipLevel;

		// Token: 0x04007A28 RID: 31272
		internal static byte __PropertyMask_bOverride_KuroBloomStreakMipLevel;

		// Token: 0x04007A29 RID: 31273
		internal static int __PropertyOffset_bOverride_KuroBloomStreakRatio;

		// Token: 0x04007A2A RID: 31274
		internal static byte __PropertyMask_bOverride_KuroBloomStreakRatio;

		// Token: 0x04007A2B RID: 31275
		internal static int __PropertyOffset_bOverride_KuroBloomStreakOrientation;

		// Token: 0x04007A2C RID: 31276
		internal static byte __PropertyMask_bOverride_KuroBloomStreakOrientation;

		// Token: 0x04007A2D RID: 31277
		internal static int __PropertyOffset_bOverride_BlackWhiteFlashIntensity;

		// Token: 0x04007A2E RID: 31278
		internal static byte __PropertyMask_bOverride_BlackWhiteFlashIntensity;

		// Token: 0x04007A2F RID: 31279
		internal static int __PropertyOffset_bOverride_BlackWhiteFlashFactor;

		// Token: 0x04007A30 RID: 31280
		internal static byte __PropertyMask_bOverride_BlackWhiteFlashFactor;

		// Token: 0x04007A31 RID: 31281
		internal static int __PropertyOffset_bOverride_BlackWhiteFlashThreshold;

		// Token: 0x04007A32 RID: 31282
		internal static byte __PropertyMask_bOverride_BlackWhiteFlashThreshold;

		// Token: 0x04007A33 RID: 31283
		internal static int __PropertyOffset_bOverride_BlackWhiteFlashBlackAreaColor;

		// Token: 0x04007A34 RID: 31284
		internal static byte __PropertyMask_bOverride_BlackWhiteFlashBlackAreaColor;

		// Token: 0x04007A35 RID: 31285
		internal static int __PropertyOffset_bOverride_BlackWhiteFlashWhiteAreaColor;

		// Token: 0x04007A36 RID: 31286
		internal static byte __PropertyMask_bOverride_BlackWhiteFlashWhiteAreaColor;

		// Token: 0x04007A37 RID: 31287
		internal static int __PropertyOffset_bOverride_KuroRadialBlurIntensity;

		// Token: 0x04007A38 RID: 31288
		internal static byte __PropertyMask_bOverride_KuroRadialBlurIntensity;

		// Token: 0x04007A39 RID: 31289
		internal static int __PropertyOffset_bOverride_KuroRadialBlurRadius;

		// Token: 0x04007A3A RID: 31290
		internal static byte __PropertyMask_bOverride_KuroRadialBlurRadius;

		// Token: 0x04007A3B RID: 31291
		internal static int __PropertyOffset_bOverride_KuroRadialBlurHardness;

		// Token: 0x04007A3C RID: 31292
		internal static byte __PropertyMask_bOverride_KuroRadialBlurHardness;

		// Token: 0x04007A3D RID: 31293
		internal static int __PropertyOffset_bOverride_KuroRadialBlurCenter;

		// Token: 0x04007A3E RID: 31294
		internal static byte __PropertyMask_bOverride_KuroRadialBlurCenter;

		// Token: 0x04007A3F RID: 31295
		internal static int __PropertyOffset_bOverride_UseClampRadialBlurCenter;

		// Token: 0x04007A40 RID: 31296
		internal static byte __PropertyMask_bOverride_UseClampRadialBlurCenter;

		// Token: 0x04007A41 RID: 31297
		internal static int __PropertyOffset_bOverride_KuroRadialBlurPassNumber;

		// Token: 0x04007A42 RID: 31298
		internal static byte __PropertyMask_bOverride_KuroRadialBlurPassNumber;

		// Token: 0x04007A43 RID: 31299
		internal static int __PropertyOffset_bOverride_KuroRadialBlurSampleNumber;

		// Token: 0x04007A44 RID: 31300
		internal static byte __PropertyMask_bOverride_KuroRadialBlurSampleNumber;

		// Token: 0x04007A45 RID: 31301
		internal static int __PropertyOffset_bOverride_KuroRadialBlurMask;

		// Token: 0x04007A46 RID: 31302
		internal static byte __PropertyMask_bOverride_KuroRadialBlurMask;

		// Token: 0x04007A47 RID: 31303
		internal static int __PropertyOffset_bOverride_KuroRadialBlurMaskScale;

		// Token: 0x04007A48 RID: 31304
		internal static byte __PropertyMask_bOverride_KuroRadialBlurMaskScale;

		// Token: 0x04007A49 RID: 31305
		internal static int __PropertyOffset_bOverride_KuroRadialBlurMaskOffset;

		// Token: 0x04007A4A RID: 31306
		internal static byte __PropertyMask_bOverride_KuroRadialBlurMaskOffset;

		// Token: 0x04007A4B RID: 31307
		internal static int __PropertyOffset_bOverride_ScreenSoftIntensity;

		// Token: 0x04007A4C RID: 31308
		internal static byte __PropertyMask_bOverride_ScreenSoftIntensity;

		// Token: 0x04007A4D RID: 31309
		internal static int __PropertyOffset_bOverride_ScreenSoftThreshold;

		// Token: 0x04007A4E RID: 31310
		internal static byte __PropertyMask_bOverride_ScreenSoftThreshold;

		// Token: 0x04007A4F RID: 31311
		internal static int __PropertyOffset_bOverride_ScreenSoftDistance;

		// Token: 0x04007A50 RID: 31312
		internal static byte __PropertyMask_bOverride_ScreenSoftDistance;

		// Token: 0x04007A51 RID: 31313
		internal static int __PropertyOffset_bOverride_ScreenSoftSkyBloomCompensation;

		// Token: 0x04007A52 RID: 31314
		internal static byte __PropertyMask_bOverride_ScreenSoftSkyBloomCompensation;

		// Token: 0x04007A53 RID: 31315
		internal static int __PropertyOffset_bOverride_ScreenSoftRange;

		// Token: 0x04007A54 RID: 31316
		internal static byte __PropertyMask_bOverride_ScreenSoftRange;

		// Token: 0x04007A55 RID: 31317
		internal static int __PropertyOffset_bOverride_ScreenSoftOverflowDistance;

		// Token: 0x04007A56 RID: 31318
		internal static byte __PropertyMask_bOverride_ScreenSoftOverflowDistance;

		// Token: 0x04007A57 RID: 31319
		internal static int __PropertyOffset_bOverride_ScreenSoftSunExposure;

		// Token: 0x04007A58 RID: 31320
		internal static byte __PropertyMask_bOverride_ScreenSoftSunExposure;

		// Token: 0x04007A59 RID: 31321
		internal static int __PropertyOffset_bOverride_ScreenSoftHighQuality;

		// Token: 0x04007A5A RID: 31322
		internal static byte __PropertyMask_bOverride_ScreenSoftHighQuality;

		// Token: 0x04007A5B RID: 31323
		internal static int __PropertyOffset_bOverride_MobileScreenSoftIntensity;

		// Token: 0x04007A5C RID: 31324
		internal static byte __PropertyMask_bOverride_MobileScreenSoftIntensity;

		// Token: 0x04007A5D RID: 31325
		internal static int __PropertyOffset_bOverride_MobileScreenSoftThreshold;

		// Token: 0x04007A5E RID: 31326
		internal static byte __PropertyMask_bOverride_MobileScreenSoftThreshold;

		// Token: 0x04007A5F RID: 31327
		internal static int __PropertyOffset_bOverride_MobileScreenSoftDistance;

		// Token: 0x04007A60 RID: 31328
		internal static byte __PropertyMask_bOverride_MobileScreenSoftDistance;

		// Token: 0x04007A61 RID: 31329
		internal static int __PropertyOffset_bOverride_ScreenLeakTexture;

		// Token: 0x04007A62 RID: 31330
		internal static byte __PropertyMask_bOverride_ScreenLeakTexture;

		// Token: 0x04007A63 RID: 31331
		internal static int __PropertyOffset_bOverride_ScreenLeakTextureIntensity;

		// Token: 0x04007A64 RID: 31332
		internal static byte __PropertyMask_bOverride_ScreenLeakTextureIntensity;

		// Token: 0x04007A65 RID: 31333
		internal static int __PropertyOffset_bOverride_FFTIntensity;

		// Token: 0x04007A66 RID: 31334
		internal static byte __PropertyMask_bOverride_FFTIntensity;

		// Token: 0x04007A67 RID: 31335
		internal static int __PropertyOffset_bOverride_FFTThreshold;

		// Token: 0x04007A68 RID: 31336
		internal static byte __PropertyMask_bOverride_FFTThreshold;

		// Token: 0x04007A69 RID: 31337
		internal static int __PropertyOffset_bOverride_FFTTexture;

		// Token: 0x04007A6A RID: 31338
		internal static byte __PropertyMask_bOverride_FFTTexture;

		// Token: 0x04007A6B RID: 31339
		internal static int __PropertyOffset_bOverride_FFTScatterDispersion;

		// Token: 0x04007A6C RID: 31340
		internal static byte __PropertyMask_bOverride_FFTScatterDispersion;

		// Token: 0x04007A6D RID: 31341
		internal static int __PropertyOffset_bOverride_FFTSize;

		// Token: 0x04007A6E RID: 31342
		internal static byte __PropertyMask_bOverride_FFTSize;

		// Token: 0x04007A6F RID: 31343
		internal static int __PropertyOffset_bOverride_FFTPreFilterMin;

		// Token: 0x04007A70 RID: 31344
		internal static byte __PropertyMask_bOverride_FFTPreFilterMin;

		// Token: 0x04007A71 RID: 31345
		internal static int __PropertyOffset_bOverride_FFTPreFilterMax;

		// Token: 0x04007A72 RID: 31346
		internal static byte __PropertyMask_bOverride_FFTPreFilterMax;

		// Token: 0x04007A73 RID: 31347
		internal static int __PropertyOffset_bOverride_FFTPreFilterMult;

		// Token: 0x04007A74 RID: 31348
		internal static byte __PropertyMask_bOverride_FFTPreFilterMult;

		// Token: 0x04007A75 RID: 31349
		internal static int __PropertyOffset_bOverride_FFTBufferScale;

		// Token: 0x04007A76 RID: 31350
		internal static byte __PropertyMask_bOverride_FFTBufferScale;

		// Token: 0x04007A77 RID: 31351
		internal static int __PropertyOffset_bOverride_FFTDistance;

		// Token: 0x04007A78 RID: 31352
		internal static byte __PropertyMask_bOverride_FFTDistance;

		// Token: 0x04007A79 RID: 31353
		internal static int __PropertyOffset_bOverride_FFTHidenSky;

		// Token: 0x04007A7A RID: 31354
		internal static byte __PropertyMask_bOverride_FFTHidenSky;

		// Token: 0x04007A7B RID: 31355
		internal static int __PropertyOffset_bOverride_FFTHidenTranslucent;

		// Token: 0x04007A7C RID: 31356
		internal static byte __PropertyMask_bOverride_FFTHidenTranslucent;

		// Token: 0x04007A7D RID: 31357
		internal static int __PropertyOffset_bOverride_FFTBeforeTranslucency;

		// Token: 0x04007A7E RID: 31358
		internal static byte __PropertyMask_bOverride_FFTBeforeTranslucency;

		// Token: 0x04007A7F RID: 31359
		internal static int __PropertyOffset_bOverride_ToonFFTIntensity;

		// Token: 0x04007A80 RID: 31360
		internal static byte __PropertyMask_bOverride_ToonFFTIntensity;

		// Token: 0x04007A81 RID: 31361
		internal static int __PropertyOffset_bOverride_ToonFFTThreshold;

		// Token: 0x04007A82 RID: 31362
		internal static byte __PropertyMask_bOverride_ToonFFTThreshold;

		// Token: 0x04007A83 RID: 31363
		internal static int __PropertyOffset_bOverride_ToonFFTTexture;

		// Token: 0x04007A84 RID: 31364
		internal static byte __PropertyMask_bOverride_ToonFFTTexture;

		// Token: 0x04007A85 RID: 31365
		internal static int __PropertyOffset_bOverride_ToonFFTScatterDispersion;

		// Token: 0x04007A86 RID: 31366
		internal static byte __PropertyMask_bOverride_ToonFFTScatterDispersion;

		// Token: 0x04007A87 RID: 31367
		internal static int __PropertyOffset_bOverride_ToonFFTSize;

		// Token: 0x04007A88 RID: 31368
		internal static byte __PropertyMask_bOverride_ToonFFTSize;

		// Token: 0x04007A89 RID: 31369
		internal static int __PropertyOffset_bOverride_SeparateTranslucencyBlurSize;

		// Token: 0x04007A8A RID: 31370
		internal static byte __PropertyMask_bOverride_SeparateTranslucencyBlurSize;

		// Token: 0x04007A8B RID: 31371
		internal static int __PropertyOffset_bOverride_LightFadeScale;

		// Token: 0x04007A8C RID: 31372
		internal static byte __PropertyMask_bOverride_LightFadeScale;

		// Token: 0x04007A8D RID: 31373
		internal static int __PropertyOffset_bOverride_KuroDataDistortionNoiseIntensity;

		// Token: 0x04007A8E RID: 31374
		internal static byte __PropertyMask_bOverride_KuroDataDistortionNoiseIntensity;

		// Token: 0x04007A8F RID: 31375
		internal static int __PropertyOffset_bOverride_KuroDataDistortionNoiseTexture;

		// Token: 0x04007A90 RID: 31376
		internal static byte __PropertyMask_bOverride_KuroDataDistortionNoiseTexture;

		// Token: 0x04007A91 RID: 31377
		internal static int __PropertyOffset_bOverride_KuroDataDistortionNoiseTextureUVScaleBias;

		// Token: 0x04007A92 RID: 31378
		internal static byte __PropertyMask_bOverride_KuroDataDistortionNoiseTextureUVScaleBias;

		// Token: 0x04007A93 RID: 31379
		internal static int __PropertyOffset_bOverride_KuroDataDistortionNoiseSize;

		// Token: 0x04007A94 RID: 31380
		internal static byte __PropertyMask_bOverride_KuroDataDistortionNoiseSize;

		// Token: 0x04007A95 RID: 31381
		internal static int __PropertyOffset_bOverride_KuroDataDistortionNoiseBias;

		// Token: 0x04007A96 RID: 31382
		internal static byte __PropertyMask_bOverride_KuroDataDistortionNoiseBias;

		// Token: 0x04007A97 RID: 31383
		internal static int __PropertyOffset_bOverride_KuroDataDistortionSignalIntensity;

		// Token: 0x04007A98 RID: 31384
		internal static byte __PropertyMask_bOverride_KuroDataDistortionSignalIntensity;

		// Token: 0x04007A99 RID: 31385
		internal static int __PropertyOffset_bOverride_KuroDataDistortionRandomColorSize;

		// Token: 0x04007A9A RID: 31386
		internal static byte __PropertyMask_bOverride_KuroDataDistortionRandomColorSize;

		// Token: 0x04007A9B RID: 31387
		internal static int __PropertyOffset_bOverride_KuroDataDistortionSinWaveParameters;

		// Token: 0x04007A9C RID: 31388
		internal static byte __PropertyMask_bOverride_KuroDataDistortionSinWaveParameters;

		// Token: 0x04007A9D RID: 31389
		internal static int __PropertyOffset_bOverride_KuroDataDistortionColorTint;

		// Token: 0x04007A9E RID: 31390
		internal static byte __PropertyMask_bOverride_KuroDataDistortionColorTint;

		// Token: 0x04007A9F RID: 31391
		internal static int __PropertyOffset_bOverride_BloomThreshold;

		// Token: 0x04007AA0 RID: 31392
		internal static byte __PropertyMask_bOverride_BloomThreshold;

		// Token: 0x04007AA1 RID: 31393
		internal static int __PropertyOffset_bOverride_Bloom1Tint;

		// Token: 0x04007AA2 RID: 31394
		internal static byte __PropertyMask_bOverride_Bloom1Tint;

		// Token: 0x04007AA3 RID: 31395
		internal static int __PropertyOffset_bOverride_Bloom1Size;

		// Token: 0x04007AA4 RID: 31396
		internal static byte __PropertyMask_bOverride_Bloom1Size;

		// Token: 0x04007AA5 RID: 31397
		internal static int __PropertyOffset_bOverride_Bloom2Size;

		// Token: 0x04007AA6 RID: 31398
		internal static byte __PropertyMask_bOverride_Bloom2Size;

		// Token: 0x04007AA7 RID: 31399
		internal static int __PropertyOffset_bOverride_Bloom2Tint;

		// Token: 0x04007AA8 RID: 31400
		internal static byte __PropertyMask_bOverride_Bloom2Tint;

		// Token: 0x04007AA9 RID: 31401
		internal static int __PropertyOffset_bOverride_Bloom3Tint;

		// Token: 0x04007AAA RID: 31402
		internal static byte __PropertyMask_bOverride_Bloom3Tint;

		// Token: 0x04007AAB RID: 31403
		internal static int __PropertyOffset_bOverride_Bloom3Size;

		// Token: 0x04007AAC RID: 31404
		internal static byte __PropertyMask_bOverride_Bloom3Size;

		// Token: 0x04007AAD RID: 31405
		internal static int __PropertyOffset_bOverride_Bloom4Tint;

		// Token: 0x04007AAE RID: 31406
		internal static byte __PropertyMask_bOverride_Bloom4Tint;

		// Token: 0x04007AAF RID: 31407
		internal static int __PropertyOffset_bOverride_Bloom4Size;

		// Token: 0x04007AB0 RID: 31408
		internal static byte __PropertyMask_bOverride_Bloom4Size;

		// Token: 0x04007AB1 RID: 31409
		internal static int __PropertyOffset_bOverride_Bloom5Tint;

		// Token: 0x04007AB2 RID: 31410
		internal static byte __PropertyMask_bOverride_Bloom5Tint;

		// Token: 0x04007AB3 RID: 31411
		internal static int __PropertyOffset_bOverride_Bloom5Size;

		// Token: 0x04007AB4 RID: 31412
		internal static byte __PropertyMask_bOverride_Bloom5Size;

		// Token: 0x04007AB5 RID: 31413
		internal static int __PropertyOffset_bOverride_Bloom6Tint;

		// Token: 0x04007AB6 RID: 31414
		internal static byte __PropertyMask_bOverride_Bloom6Tint;

		// Token: 0x04007AB7 RID: 31415
		internal static int __PropertyOffset_bOverride_Bloom6Size;

		// Token: 0x04007AB8 RID: 31416
		internal static byte __PropertyMask_bOverride_Bloom6Size;

		// Token: 0x04007AB9 RID: 31417
		internal static int __PropertyOffset_bOverride_BloomSizeScale;

		// Token: 0x04007ABA RID: 31418
		internal static byte __PropertyMask_bOverride_BloomSizeScale;

		// Token: 0x04007ABB RID: 31419
		internal static int __PropertyOffset_bOverride_BloomConvolutionPreFilter_DEPRECATED;

		// Token: 0x04007ABC RID: 31420
		internal static byte __PropertyMask_bOverride_BloomConvolutionPreFilter_DEPRECATED;

		// Token: 0x04007ABD RID: 31421
		internal static int __PropertyOffset_bOverride_BloomDirtMaskIntensity;

		// Token: 0x04007ABE RID: 31422
		internal static byte __PropertyMask_bOverride_BloomDirtMaskIntensity;

		// Token: 0x04007ABF RID: 31423
		internal static int __PropertyOffset_bOverride_BloomDirtMaskTint;

		// Token: 0x04007AC0 RID: 31424
		internal static byte __PropertyMask_bOverride_BloomDirtMaskTint;

		// Token: 0x04007AC1 RID: 31425
		internal static int __PropertyOffset_bOverride_BloomDirtMask;

		// Token: 0x04007AC2 RID: 31426
		internal static byte __PropertyMask_bOverride_BloomDirtMask;

		// Token: 0x04007AC3 RID: 31427
		internal static int __PropertyOffset_bOverride_CameraShutterSpeed;

		// Token: 0x04007AC4 RID: 31428
		internal static byte __PropertyMask_bOverride_CameraShutterSpeed;

		// Token: 0x04007AC5 RID: 31429
		internal static int __PropertyOffset_bOverride_CameraISO;

		// Token: 0x04007AC6 RID: 31430
		internal static byte __PropertyMask_bOverride_CameraISO;

		// Token: 0x04007AC7 RID: 31431
		internal static int __PropertyOffset_bOverride_AutoExposureMethod;

		// Token: 0x04007AC8 RID: 31432
		internal static byte __PropertyMask_bOverride_AutoExposureMethod;

		// Token: 0x04007AC9 RID: 31433
		internal static int __PropertyOffset_bOverride_AutoExposureLowPercent;

		// Token: 0x04007ACA RID: 31434
		internal static byte __PropertyMask_bOverride_AutoExposureLowPercent;

		// Token: 0x04007ACB RID: 31435
		internal static int __PropertyOffset_bOverride_AutoExposureHighPercent;

		// Token: 0x04007ACC RID: 31436
		internal static byte __PropertyMask_bOverride_AutoExposureHighPercent;

		// Token: 0x04007ACD RID: 31437
		internal static int __PropertyOffset_bOverride_AutoExposureMinBrightness;

		// Token: 0x04007ACE RID: 31438
		internal static byte __PropertyMask_bOverride_AutoExposureMinBrightness;

		// Token: 0x04007ACF RID: 31439
		internal static int __PropertyOffset_bOverride_AutoExposureMaxBrightness;

		// Token: 0x04007AD0 RID: 31440
		internal static byte __PropertyMask_bOverride_AutoExposureMaxBrightness;

		// Token: 0x04007AD1 RID: 31441
		internal static int __PropertyOffset_bOverride_AutoExposureCalibrationConstant_DEPRECATED;

		// Token: 0x04007AD2 RID: 31442
		internal static byte __PropertyMask_bOverride_AutoExposureCalibrationConstant_DEPRECATED;

		// Token: 0x04007AD3 RID: 31443
		internal static int __PropertyOffset_bOverride_AutoExposureSpeedUp;

		// Token: 0x04007AD4 RID: 31444
		internal static byte __PropertyMask_bOverride_AutoExposureSpeedUp;

		// Token: 0x04007AD5 RID: 31445
		internal static int __PropertyOffset_bOverride_AutoExposureSpeedDown;

		// Token: 0x04007AD6 RID: 31446
		internal static byte __PropertyMask_bOverride_AutoExposureSpeedDown;

		// Token: 0x04007AD7 RID: 31447
		internal static int __PropertyOffset_bOverride_AutoExposureBias;

		// Token: 0x04007AD8 RID: 31448
		internal static byte __PropertyMask_bOverride_AutoExposureBias;

		// Token: 0x04007AD9 RID: 31449
		internal static int __PropertyOffset_bOverride_AutoExposureBiasCurve;

		// Token: 0x04007ADA RID: 31450
		internal static byte __PropertyMask_bOverride_AutoExposureBiasCurve;

		// Token: 0x04007ADB RID: 31451
		internal static int __PropertyOffset_bOverride_AutoExposureMeterMask;

		// Token: 0x04007ADC RID: 31452
		internal static byte __PropertyMask_bOverride_AutoExposureMeterMask;

		// Token: 0x04007ADD RID: 31453
		internal static int __PropertyOffset_bOverride_AutoExposureApplyPhysicalCameraExposure;

		// Token: 0x04007ADE RID: 31454
		internal static byte __PropertyMask_bOverride_AutoExposureApplyPhysicalCameraExposure;

		// Token: 0x04007ADF RID: 31455
		internal static int __PropertyOffset_bOverride_HistogramLogMin;

		// Token: 0x04007AE0 RID: 31456
		internal static byte __PropertyMask_bOverride_HistogramLogMin;

		// Token: 0x04007AE1 RID: 31457
		internal static int __PropertyOffset_bOverride_HistogramLogMax;

		// Token: 0x04007AE2 RID: 31458
		internal static byte __PropertyMask_bOverride_HistogramLogMax;

		// Token: 0x04007AE3 RID: 31459
		internal static int __PropertyOffset_bOverride_LocalExposureMethod;

		// Token: 0x04007AE4 RID: 31460
		internal static byte __PropertyMask_bOverride_LocalExposureMethod;

		// Token: 0x04007AE5 RID: 31461
		internal static int __PropertyOffset_bOverride_LocalExposureContrastScale_DEPRECATED;

		// Token: 0x04007AE6 RID: 31462
		internal static byte __PropertyMask_bOverride_LocalExposureContrastScale_DEPRECATED;

		// Token: 0x04007AE7 RID: 31463
		internal static int __PropertyOffset_bOverride_LocalExposureHighlightContrastScale;

		// Token: 0x04007AE8 RID: 31464
		internal static byte __PropertyMask_bOverride_LocalExposureHighlightContrastScale;

		// Token: 0x04007AE9 RID: 31465
		internal static int __PropertyOffset_bOverride_LocalExposureShadowContrastScale;

		// Token: 0x04007AEA RID: 31466
		internal static byte __PropertyMask_bOverride_LocalExposureShadowContrastScale;

		// Token: 0x04007AEB RID: 31467
		internal static int __PropertyOffset_bOverride_LocalExposureHighlightContrastCurve;

		// Token: 0x04007AEC RID: 31468
		internal static byte __PropertyMask_bOverride_LocalExposureHighlightContrastCurve;

		// Token: 0x04007AED RID: 31469
		internal static int __PropertyOffset_bOverride_LocalExposureShadowContrastCurve;

		// Token: 0x04007AEE RID: 31470
		internal static byte __PropertyMask_bOverride_LocalExposureShadowContrastCurve;

		// Token: 0x04007AEF RID: 31471
		internal static int __PropertyOffset_bOverride_LocalExposureHighlightThreshold;

		// Token: 0x04007AF0 RID: 31472
		internal static byte __PropertyMask_bOverride_LocalExposureHighlightThreshold;

		// Token: 0x04007AF1 RID: 31473
		internal static int __PropertyOffset_bOverride_LocalExposureShadowThreshold;

		// Token: 0x04007AF2 RID: 31474
		internal static byte __PropertyMask_bOverride_LocalExposureShadowThreshold;

		// Token: 0x04007AF3 RID: 31475
		internal static int __PropertyOffset_bOverride_LocalExposureDetailStrength;

		// Token: 0x04007AF4 RID: 31476
		internal static byte __PropertyMask_bOverride_LocalExposureDetailStrength;

		// Token: 0x04007AF5 RID: 31477
		internal static int __PropertyOffset_bOverride_LocalExposureBlurredLuminanceBlend;

		// Token: 0x04007AF6 RID: 31478
		internal static byte __PropertyMask_bOverride_LocalExposureBlurredLuminanceBlend;

		// Token: 0x04007AF7 RID: 31479
		internal static int __PropertyOffset_bOverride_LocalExposureBlurredLuminanceKernelSizePercent;

		// Token: 0x04007AF8 RID: 31480
		internal static byte __PropertyMask_bOverride_LocalExposureBlurredLuminanceKernelSizePercent;

		// Token: 0x04007AF9 RID: 31481
		internal static int __PropertyOffset_bOverride_LocalExposureMiddleGreyBias;

		// Token: 0x04007AFA RID: 31482
		internal static byte __PropertyMask_bOverride_LocalExposureMiddleGreyBias;

		// Token: 0x04007AFB RID: 31483
		internal static int __PropertyOffset_bOverride_LensFlareIntensity;

		// Token: 0x04007AFC RID: 31484
		internal static byte __PropertyMask_bOverride_LensFlareIntensity;

		// Token: 0x04007AFD RID: 31485
		internal static int __PropertyOffset_bOverride_LensFlareTint;

		// Token: 0x04007AFE RID: 31486
		internal static byte __PropertyMask_bOverride_LensFlareTint;

		// Token: 0x04007AFF RID: 31487
		internal static int __PropertyOffset_bOverride_LensFlareTints;

		// Token: 0x04007B00 RID: 31488
		internal static byte __PropertyMask_bOverride_LensFlareTints;

		// Token: 0x04007B01 RID: 31489
		internal static int __PropertyOffset_bOverride_LensFlareBokehSize;

		// Token: 0x04007B02 RID: 31490
		internal static byte __PropertyMask_bOverride_LensFlareBokehSize;

		// Token: 0x04007B03 RID: 31491
		internal static int __PropertyOffset_bOverride_LensFlareBokehShape;

		// Token: 0x04007B04 RID: 31492
		internal static byte __PropertyMask_bOverride_LensFlareBokehShape;

		// Token: 0x04007B05 RID: 31493
		internal static int __PropertyOffset_bOverride_LensFlareThreshold;

		// Token: 0x04007B06 RID: 31494
		internal static byte __PropertyMask_bOverride_LensFlareThreshold;

		// Token: 0x04007B07 RID: 31495
		internal static int __PropertyOffset_bOverride_LensFlareOnlySun;

		// Token: 0x04007B08 RID: 31496
		internal static byte __PropertyMask_bOverride_LensFlareOnlySun;

		// Token: 0x04007B09 RID: 31497
		internal static int __PropertyOffset_bOverride_LensFlareSunRange;

		// Token: 0x04007B0A RID: 31498
		internal static byte __PropertyMask_bOverride_LensFlareSunRange;

		// Token: 0x04007B0B RID: 31499
		internal static int __PropertyOffset_bOverride_LensFlareSunPosition;

		// Token: 0x04007B0C RID: 31500
		internal static byte __PropertyMask_bOverride_LensFlareSunPosition;

		// Token: 0x04007B0D RID: 31501
		internal static int __PropertyOffset_bOverride_VignetteIntensity;

		// Token: 0x04007B0E RID: 31502
		internal static byte __PropertyMask_bOverride_VignetteIntensity;

		// Token: 0x04007B0F RID: 31503
		internal static int __PropertyOffset_bOverride_VignetteHardness;

		// Token: 0x04007B10 RID: 31504
		internal static byte __PropertyMask_bOverride_VignetteHardness;

		// Token: 0x04007B11 RID: 31505
		internal static int __PropertyOffset_bOverride_VignetteXScale;

		// Token: 0x04007B12 RID: 31506
		internal static byte __PropertyMask_bOverride_VignetteXScale;

		// Token: 0x04007B13 RID: 31507
		internal static int __PropertyOffset_bOverride_VignetteYScale;

		// Token: 0x04007B14 RID: 31508
		internal static byte __PropertyMask_bOverride_VignetteYScale;

		// Token: 0x04007B15 RID: 31509
		internal static int __PropertyOffset_bOverride_VignetteXPos;

		// Token: 0x04007B16 RID: 31510
		internal static byte __PropertyMask_bOverride_VignetteXPos;

		// Token: 0x04007B17 RID: 31511
		internal static int __PropertyOffset_bOverride_VignetteYPos;

		// Token: 0x04007B18 RID: 31512
		internal static byte __PropertyMask_bOverride_VignetteYPos;

		// Token: 0x04007B19 RID: 31513
		internal static int __PropertyOffset_bOverride_VignetteColor;

		// Token: 0x04007B1A RID: 31514
		internal static byte __PropertyMask_bOverride_VignetteColor;

		// Token: 0x04007B1B RID: 31515
		internal static int __PropertyOffset_bOverride_VignetteGain;

		// Token: 0x04007B1C RID: 31516
		internal static byte __PropertyMask_bOverride_VignetteGain;

		// Token: 0x04007B1D RID: 31517
		internal static int __PropertyOffset_bOverride_EffectVignetteIntensity;

		// Token: 0x04007B1E RID: 31518
		internal static byte __PropertyMask_bOverride_EffectVignetteIntensity;

		// Token: 0x04007B1F RID: 31519
		internal static int __PropertyOffset_bOverride_EffectVignetteHardness;

		// Token: 0x04007B20 RID: 31520
		internal static byte __PropertyMask_bOverride_EffectVignetteHardness;

		// Token: 0x04007B21 RID: 31521
		internal static int __PropertyOffset_bOverride_EffectVignetteXScale;

		// Token: 0x04007B22 RID: 31522
		internal static byte __PropertyMask_bOverride_EffectVignetteXScale;

		// Token: 0x04007B23 RID: 31523
		internal static int __PropertyOffset_bOverride_EffectVignetteYScale;

		// Token: 0x04007B24 RID: 31524
		internal static byte __PropertyMask_bOverride_EffectVignetteYScale;

		// Token: 0x04007B25 RID: 31525
		internal static int __PropertyOffset_bOverride_EffectVignetteXPos;

		// Token: 0x04007B26 RID: 31526
		internal static byte __PropertyMask_bOverride_EffectVignetteXPos;

		// Token: 0x04007B27 RID: 31527
		internal static int __PropertyOffset_bOverride_EffectVignetteYPos;

		// Token: 0x04007B28 RID: 31528
		internal static byte __PropertyMask_bOverride_EffectVignetteYPos;

		// Token: 0x04007B29 RID: 31529
		internal static int __PropertyOffset_bOverride_EffectVignetteColor;

		// Token: 0x04007B2A RID: 31530
		internal static byte __PropertyMask_bOverride_EffectVignetteColor;

		// Token: 0x04007B2B RID: 31531
		internal static int __PropertyOffset_bOverride_EffectVignetteGain;

		// Token: 0x04007B2C RID: 31532
		internal static byte __PropertyMask_bOverride_EffectVignetteGain;

		// Token: 0x04007B2D RID: 31533
		internal static int __PropertyOffset_bOverride_GrainIntensity;

		// Token: 0x04007B2E RID: 31534
		internal static byte __PropertyMask_bOverride_GrainIntensity;

		// Token: 0x04007B2F RID: 31535
		internal static int __PropertyOffset_bOverride_GrainJitter;

		// Token: 0x04007B30 RID: 31536
		internal static byte __PropertyMask_bOverride_GrainJitter;

		// Token: 0x04007B31 RID: 31537
		internal static int __PropertyOffset_bOverride_GrainColorful;

		// Token: 0x04007B32 RID: 31538
		internal static byte __PropertyMask_bOverride_GrainColorful;

		// Token: 0x04007B33 RID: 31539
		internal static int __PropertyOffset_bOverride_MainCenterMask;

		// Token: 0x04007B34 RID: 31540
		internal static byte __PropertyMask_bOverride_MainCenterMask;

		// Token: 0x04007B35 RID: 31541
		internal static int __PropertyOffset_bOverride_MainCenterMaskRadius;

		// Token: 0x04007B36 RID: 31542
		internal static byte __PropertyMask_bOverride_MainCenterMaskRadius;

		// Token: 0x04007B37 RID: 31543
		internal static int __PropertyOffset_bOverride_MainCenterMaskHardness;

		// Token: 0x04007B38 RID: 31544
		internal static byte __PropertyMask_bOverride_MainCenterMaskHardness;

		// Token: 0x04007B39 RID: 31545
		internal static int __PropertyOffset_bOverride_MainStartDistance;

		// Token: 0x04007B3A RID: 31546
		internal static byte __PropertyMask_bOverride_MainStartDistance;

		// Token: 0x04007B3B RID: 31547
		internal static int __PropertyOffset_bOverride_MainCharacterIntensity;

		// Token: 0x04007B3C RID: 31548
		internal static byte __PropertyMask_bOverride_MainCharacterIntensity;

		// Token: 0x04007B3D RID: 31549
		internal static int __PropertyOffset_bOverride_VintageColorIntensity;

		// Token: 0x04007B3E RID: 31550
		internal static byte __PropertyMask_bOverride_VintageColorIntensity;

		// Token: 0x04007B3F RID: 31551
		internal static int __PropertyOffset_bOverride_VintageColorBlackPoint;

		// Token: 0x04007B40 RID: 31552
		internal static byte __PropertyMask_bOverride_VintageColorBlackPoint;

		// Token: 0x04007B41 RID: 31553
		internal static int __PropertyOffset_bOverride_VintageColorWhitePoint;

		// Token: 0x04007B42 RID: 31554
		internal static byte __PropertyMask_bOverride_VintageColorWhitePoint;

		// Token: 0x04007B43 RID: 31555
		internal static int __PropertyOffset_bOverride_VHSLinesColorIntensity;

		// Token: 0x04007B44 RID: 31556
		internal static byte __PropertyMask_bOverride_VHSLinesColorIntensity;

		// Token: 0x04007B45 RID: 31557
		internal static int __PropertyOffset_bOverride_VHSLinesDistortIntensity;

		// Token: 0x04007B46 RID: 31558
		internal static byte __PropertyMask_bOverride_VHSLinesDistortIntensity;

		// Token: 0x04007B47 RID: 31559
		internal static int __PropertyOffset_bOverride_VHSEffectIntensity;

		// Token: 0x04007B48 RID: 31560
		internal static byte __PropertyMask_bOverride_VHSEffectIntensity;

		// Token: 0x04007B49 RID: 31561
		internal static int __PropertyOffset_bOverride_VHSSpecklesIntensity;

		// Token: 0x04007B4A RID: 31562
		internal static byte __PropertyMask_bOverride_VHSSpecklesIntensity;

		// Token: 0x04007B4B RID: 31563
		internal static int __PropertyOffset_bOverride_VHSSpecklesAmount;

		// Token: 0x04007B4C RID: 31564
		internal static byte __PropertyMask_bOverride_VHSSpecklesAmount;

		// Token: 0x04007B4D RID: 31565
		internal static int __PropertyOffset_bOverride_VHSSpecklesSize;

		// Token: 0x04007B4E RID: 31566
		internal static byte __PropertyMask_bOverride_VHSSpecklesSize;

		// Token: 0x04007B4F RID: 31567
		internal static int __PropertyOffset_bOverride_CRTDistortion;

		// Token: 0x04007B50 RID: 31568
		internal static byte __PropertyMask_bOverride_CRTDistortion;

		// Token: 0x04007B51 RID: 31569
		internal static int __PropertyOffset_bOverride_VintageColorCenterMask;

		// Token: 0x04007B52 RID: 31570
		internal static byte __PropertyMask_bOverride_VintageColorCenterMask;

		// Token: 0x04007B53 RID: 31571
		internal static int __PropertyOffset_bOverride_VintageColorStartDistance;

		// Token: 0x04007B54 RID: 31572
		internal static byte __PropertyMask_bOverride_VintageColorStartDistance;

		// Token: 0x04007B55 RID: 31573
		internal static int __PropertyOffset_bOverride_VintageColorCharacterIntensity;

		// Token: 0x04007B56 RID: 31574
		internal static byte __PropertyMask_bOverride_VintageColorCharacterIntensity;

		// Token: 0x04007B57 RID: 31575
		internal static int __PropertyOffset_bOverride_VHSLinesCenterMask;

		// Token: 0x04007B58 RID: 31576
		internal static byte __PropertyMask_bOverride_VHSLinesCenterMask;

		// Token: 0x04007B59 RID: 31577
		internal static int __PropertyOffset_bOverride_VHSLinesStartDistance;

		// Token: 0x04007B5A RID: 31578
		internal static byte __PropertyMask_bOverride_VHSLinesStartDistance;

		// Token: 0x04007B5B RID: 31579
		internal static int __PropertyOffset_bOverride_VHSLinesCharacterIntensity;

		// Token: 0x04007B5C RID: 31580
		internal static byte __PropertyMask_bOverride_VHSLinesCharacterIntensity;

		// Token: 0x04007B5D RID: 31581
		internal static int __PropertyOffset_bOverride_VHSEffectCenterMask;

		// Token: 0x04007B5E RID: 31582
		internal static byte __PropertyMask_bOverride_VHSEffectCenterMask;

		// Token: 0x04007B5F RID: 31583
		internal static int __PropertyOffset_bOverride_VHSEffectStartDistance;

		// Token: 0x04007B60 RID: 31584
		internal static byte __PropertyMask_bOverride_VHSEffectStartDistance;

		// Token: 0x04007B61 RID: 31585
		internal static int __PropertyOffset_bOverride_VHSEffectCharacterIntensity;

		// Token: 0x04007B62 RID: 31586
		internal static byte __PropertyMask_bOverride_VHSEffectCharacterIntensity;

		// Token: 0x04007B63 RID: 31587
		internal static int __PropertyOffset_bOverride_VHSSpecklesCenterMask;

		// Token: 0x04007B64 RID: 31588
		internal static byte __PropertyMask_bOverride_VHSSpecklesCenterMask;

		// Token: 0x04007B65 RID: 31589
		internal static int __PropertyOffset_bOverride_VHSSpecklesStartDistance;

		// Token: 0x04007B66 RID: 31590
		internal static byte __PropertyMask_bOverride_VHSSpecklesStartDistance;

		// Token: 0x04007B67 RID: 31591
		internal static int __PropertyOffset_bOverride_VHSSpecklesCharacterIntensity;

		// Token: 0x04007B68 RID: 31592
		internal static byte __PropertyMask_bOverride_VHSSpecklesCharacterIntensity;

		// Token: 0x04007B69 RID: 31593
		internal static int __PropertyOffset_bOverride_AmbientOcclusionIntensity;

		// Token: 0x04007B6A RID: 31594
		internal static byte __PropertyMask_bOverride_AmbientOcclusionIntensity;

		// Token: 0x04007B6B RID: 31595
		internal static int __PropertyOffset_bOverride_AmbientOcclusionStaticFraction;

		// Token: 0x04007B6C RID: 31596
		internal static byte __PropertyMask_bOverride_AmbientOcclusionStaticFraction;

		// Token: 0x04007B6D RID: 31597
		internal static int __PropertyOffset_bOverride_AmbientOcclusionRadius;

		// Token: 0x04007B6E RID: 31598
		internal static byte __PropertyMask_bOverride_AmbientOcclusionRadius;

		// Token: 0x04007B6F RID: 31599
		internal static int __PropertyOffset_bOverride_AmbientOcclusionFadeDistance;

		// Token: 0x04007B70 RID: 31600
		internal static byte __PropertyMask_bOverride_AmbientOcclusionFadeDistance;

		// Token: 0x04007B71 RID: 31601
		internal static int __PropertyOffset_bOverride_AmbientOcclusionFadeRadius;

		// Token: 0x04007B72 RID: 31602
		internal static byte __PropertyMask_bOverride_AmbientOcclusionFadeRadius;

		// Token: 0x04007B73 RID: 31603
		internal static int __PropertyOffset_bOverride_AmbientOcclusionDistance_DEPRECATED;

		// Token: 0x04007B74 RID: 31604
		internal static byte __PropertyMask_bOverride_AmbientOcclusionDistance_DEPRECATED;

		// Token: 0x04007B75 RID: 31605
		internal static int __PropertyOffset_bOverride_AmbientOcclusionRadiusInWS;

		// Token: 0x04007B76 RID: 31606
		internal static byte __PropertyMask_bOverride_AmbientOcclusionRadiusInWS;

		// Token: 0x04007B77 RID: 31607
		internal static int __PropertyOffset_bOverride_AmbientOcclusionPower;

		// Token: 0x04007B78 RID: 31608
		internal static byte __PropertyMask_bOverride_AmbientOcclusionPower;

		// Token: 0x04007B79 RID: 31609
		internal static int __PropertyOffset_bOverride_AmbientOcclusionBias;

		// Token: 0x04007B7A RID: 31610
		internal static byte __PropertyMask_bOverride_AmbientOcclusionBias;

		// Token: 0x04007B7B RID: 31611
		internal static int __PropertyOffset_bOverride_AmbientOcclusionQuality;

		// Token: 0x04007B7C RID: 31612
		internal static byte __PropertyMask_bOverride_AmbientOcclusionQuality;

		// Token: 0x04007B7D RID: 31613
		internal static int __PropertyOffset_bOverride_AmbientOcclusionMipBlend;

		// Token: 0x04007B7E RID: 31614
		internal static byte __PropertyMask_bOverride_AmbientOcclusionMipBlend;

		// Token: 0x04007B7F RID: 31615
		internal static int __PropertyOffset_bOverride_AmbientOcclusionMipScale;

		// Token: 0x04007B80 RID: 31616
		internal static byte __PropertyMask_bOverride_AmbientOcclusionMipScale;

		// Token: 0x04007B81 RID: 31617
		internal static int __PropertyOffset_bOverride_AmbientOcclusionMipThreshold;

		// Token: 0x04007B82 RID: 31618
		internal static byte __PropertyMask_bOverride_AmbientOcclusionMipThreshold;

		// Token: 0x04007B83 RID: 31619
		internal static int __PropertyOffset_bOverride_AmbientOcclusionTemporalBlendWeight;

		// Token: 0x04007B84 RID: 31620
		internal static byte __PropertyMask_bOverride_AmbientOcclusionTemporalBlendWeight;

		// Token: 0x04007B85 RID: 31621
		internal static int __PropertyOffset_bOverride_RayTracingAO;

		// Token: 0x04007B86 RID: 31622
		internal static byte __PropertyMask_bOverride_RayTracingAO;

		// Token: 0x04007B87 RID: 31623
		internal static int __PropertyOffset_bOverride_RayTracingAOSamplesPerPixel;

		// Token: 0x04007B88 RID: 31624
		internal static byte __PropertyMask_bOverride_RayTracingAOSamplesPerPixel;

		// Token: 0x04007B89 RID: 31625
		internal static int __PropertyOffset_bOverride_RayTracingAOIntensity;

		// Token: 0x04007B8A RID: 31626
		internal static byte __PropertyMask_bOverride_RayTracingAOIntensity;

		// Token: 0x04007B8B RID: 31627
		internal static int __PropertyOffset_bOverride_RayTracingAORadius;

		// Token: 0x04007B8C RID: 31628
		internal static byte __PropertyMask_bOverride_RayTracingAORadius;

		// Token: 0x04007B8D RID: 31629
		internal static int __PropertyOffset_bOverride_LPVIntensity;

		// Token: 0x04007B8E RID: 31630
		internal static byte __PropertyMask_bOverride_LPVIntensity;

		// Token: 0x04007B8F RID: 31631
		internal static int __PropertyOffset_bOverride_LPVDirectionalOcclusionIntensity;

		// Token: 0x04007B90 RID: 31632
		internal static byte __PropertyMask_bOverride_LPVDirectionalOcclusionIntensity;

		// Token: 0x04007B91 RID: 31633
		internal static int __PropertyOffset_bOverride_LPVDirectionalOcclusionRadius;

		// Token: 0x04007B92 RID: 31634
		internal static byte __PropertyMask_bOverride_LPVDirectionalOcclusionRadius;

		// Token: 0x04007B93 RID: 31635
		internal static int __PropertyOffset_bOverride_LPVDiffuseOcclusionExponent;

		// Token: 0x04007B94 RID: 31636
		internal static byte __PropertyMask_bOverride_LPVDiffuseOcclusionExponent;

		// Token: 0x04007B95 RID: 31637
		internal static int __PropertyOffset_bOverride_LPVSpecularOcclusionExponent;

		// Token: 0x04007B96 RID: 31638
		internal static byte __PropertyMask_bOverride_LPVSpecularOcclusionExponent;

		// Token: 0x04007B97 RID: 31639
		internal static int __PropertyOffset_bOverride_LPVDiffuseOcclusionIntensity;

		// Token: 0x04007B98 RID: 31640
		internal static byte __PropertyMask_bOverride_LPVDiffuseOcclusionIntensity;

		// Token: 0x04007B99 RID: 31641
		internal static int __PropertyOffset_bOverride_LPVSpecularOcclusionIntensity;

		// Token: 0x04007B9A RID: 31642
		internal static byte __PropertyMask_bOverride_LPVSpecularOcclusionIntensity;

		// Token: 0x04007B9B RID: 31643
		internal static int __PropertyOffset_bOverride_LPVSize;

		// Token: 0x04007B9C RID: 31644
		internal static byte __PropertyMask_bOverride_LPVSize;

		// Token: 0x04007B9D RID: 31645
		internal static int __PropertyOffset_bOverride_LPVSecondaryOcclusionIntensity;

		// Token: 0x04007B9E RID: 31646
		internal static byte __PropertyMask_bOverride_LPVSecondaryOcclusionIntensity;

		// Token: 0x04007B9F RID: 31647
		internal static int __PropertyOffset_bOverride_LPVSecondaryBounceIntensity;

		// Token: 0x04007BA0 RID: 31648
		internal static byte __PropertyMask_bOverride_LPVSecondaryBounceIntensity;

		// Token: 0x04007BA1 RID: 31649
		internal static int __PropertyOffset_bOverride_LPVGeometryVolumeBias;

		// Token: 0x04007BA2 RID: 31650
		internal static byte __PropertyMask_bOverride_LPVGeometryVolumeBias;

		// Token: 0x04007BA3 RID: 31651
		internal static int __PropertyOffset_bOverride_LPVVplInjectionBias;

		// Token: 0x04007BA4 RID: 31652
		internal static byte __PropertyMask_bOverride_LPVVplInjectionBias;

		// Token: 0x04007BA5 RID: 31653
		internal static int __PropertyOffset_bOverride_LPVEmissiveInjectionIntensity;

		// Token: 0x04007BA6 RID: 31654
		internal static byte __PropertyMask_bOverride_LPVEmissiveInjectionIntensity;

		// Token: 0x04007BA7 RID: 31655
		internal static int __PropertyOffset_bOverride_LPVFadeRange;

		// Token: 0x04007BA8 RID: 31656
		internal static byte __PropertyMask_bOverride_LPVFadeRange;

		// Token: 0x04007BA9 RID: 31657
		internal static int __PropertyOffset_bOverride_LPVDirectionalOcclusionFadeRange;

		// Token: 0x04007BAA RID: 31658
		internal static byte __PropertyMask_bOverride_LPVDirectionalOcclusionFadeRange;

		// Token: 0x04007BAB RID: 31659
		internal static int __PropertyOffset_bOverride_LumenSkylightLeaking;

		// Token: 0x04007BAC RID: 31660
		internal static byte __PropertyMask_bOverride_LumenSkylightLeaking;

		// Token: 0x04007BAD RID: 31661
		internal static int __PropertyOffset_bOverride_IndirectLightingColor;

		// Token: 0x04007BAE RID: 31662
		internal static byte __PropertyMask_bOverride_IndirectLightingColor;

		// Token: 0x04007BAF RID: 31663
		internal static int __PropertyOffset_bOverride_IndirectLightingIntensity;

		// Token: 0x04007BB0 RID: 31664
		internal static byte __PropertyMask_bOverride_IndirectLightingIntensity;

		// Token: 0x04007BB1 RID: 31665
		internal static int __PropertyOffset_bOverride_ColorGradingIntensity;

		// Token: 0x04007BB2 RID: 31666
		internal static byte __PropertyMask_bOverride_ColorGradingIntensity;

		// Token: 0x04007BB3 RID: 31667
		internal static int __PropertyOffset_bOverride_ColorGradingLUT;

		// Token: 0x04007BB4 RID: 31668
		internal static byte __PropertyMask_bOverride_ColorGradingLUT;

		// Token: 0x04007BB5 RID: 31669
		internal static int __PropertyOffset_bOverride_DepthOfFieldFocalDistance;

		// Token: 0x04007BB6 RID: 31670
		internal static byte __PropertyMask_bOverride_DepthOfFieldFocalDistance;

		// Token: 0x04007BB7 RID: 31671
		internal static int __PropertyOffset_bOverride_DepthOfFieldFstop;

		// Token: 0x04007BB8 RID: 31672
		internal static byte __PropertyMask_bOverride_DepthOfFieldFstop;

		// Token: 0x04007BB9 RID: 31673
		internal static int __PropertyOffset_bOverride_DepthOfFieldMinFstop;

		// Token: 0x04007BBA RID: 31674
		internal static byte __PropertyMask_bOverride_DepthOfFieldMinFstop;

		// Token: 0x04007BBB RID: 31675
		internal static int __PropertyOffset_bOverride_DepthOfFieldBladeCount;

		// Token: 0x04007BBC RID: 31676
		internal static byte __PropertyMask_bOverride_DepthOfFieldBladeCount;

		// Token: 0x04007BBD RID: 31677
		internal static int __PropertyOffset_bOverride_DepthOfFieldForegroundBlur;

		// Token: 0x04007BBE RID: 31678
		internal static byte __PropertyMask_bOverride_DepthOfFieldForegroundBlur;

		// Token: 0x04007BBF RID: 31679
		internal static int __PropertyOffset_bOverride_DepthOfFieldSensorWidth;

		// Token: 0x04007BC0 RID: 31680
		internal static byte __PropertyMask_bOverride_DepthOfFieldSensorWidth;

		// Token: 0x04007BC1 RID: 31681
		internal static int __PropertyOffset_bOverride_DepthOfFieldDepthBlurRadius;

		// Token: 0x04007BC2 RID: 31682
		internal static byte __PropertyMask_bOverride_DepthOfFieldDepthBlurRadius;

		// Token: 0x04007BC3 RID: 31683
		internal static int __PropertyOffset_bOverride_DepthOfFieldDepthBlurAmount;

		// Token: 0x04007BC4 RID: 31684
		internal static byte __PropertyMask_bOverride_DepthOfFieldDepthBlurAmount;

		// Token: 0x04007BC5 RID: 31685
		internal static int __PropertyOffset_bOverride_DepthOfFieldFocalRegion;

		// Token: 0x04007BC6 RID: 31686
		internal static byte __PropertyMask_bOverride_DepthOfFieldFocalRegion;

		// Token: 0x04007BC7 RID: 31687
		internal static int __PropertyOffset_bOverride_DepthOfFieldNearTransitionRegion;

		// Token: 0x04007BC8 RID: 31688
		internal static byte __PropertyMask_bOverride_DepthOfFieldNearTransitionRegion;

		// Token: 0x04007BC9 RID: 31689
		internal static int __PropertyOffset_bOverride_DepthOfFieldFarTransitionRegion;

		// Token: 0x04007BCA RID: 31690
		internal static byte __PropertyMask_bOverride_DepthOfFieldFarTransitionRegion;

		// Token: 0x04007BCB RID: 31691
		internal static int __PropertyOffset_bOverride_DepthOfFieldScale;

		// Token: 0x04007BCC RID: 31692
		internal static byte __PropertyMask_bOverride_DepthOfFieldScale;

		// Token: 0x04007BCD RID: 31693
		internal static int __PropertyOffset_bOverride_DepthOfFieldNearBlurSize;

		// Token: 0x04007BCE RID: 31694
		internal static byte __PropertyMask_bOverride_DepthOfFieldNearBlurSize;

		// Token: 0x04007BCF RID: 31695
		internal static int __PropertyOffset_bOverride_DepthOfFieldFarBlurSize;

		// Token: 0x04007BD0 RID: 31696
		internal static byte __PropertyMask_bOverride_DepthOfFieldFarBlurSize;

		// Token: 0x04007BD1 RID: 31697
		internal static int __PropertyOffset_bOverride_MobileHQGaussian;

		// Token: 0x04007BD2 RID: 31698
		internal static byte __PropertyMask_bOverride_MobileHQGaussian;

		// Token: 0x04007BD3 RID: 31699
		internal static int __PropertyOffset_bOverride_KuroDangerToggle;

		// Token: 0x04007BD4 RID: 31700
		internal static byte __PropertyMask_bOverride_KuroDangerToggle;

		// Token: 0x04007BD5 RID: 31701
		internal static int __PropertyOffset_bOverride_DepthOfFieldOcclusion;

		// Token: 0x04007BD6 RID: 31702
		internal static byte __PropertyMask_bOverride_DepthOfFieldOcclusion;

		// Token: 0x04007BD7 RID: 31703
		internal static int __PropertyOffset_bOverride_DepthOfFieldSkyFocusDistance;

		// Token: 0x04007BD8 RID: 31704
		internal static byte __PropertyMask_bOverride_DepthOfFieldSkyFocusDistance;

		// Token: 0x04007BD9 RID: 31705
		internal static int __PropertyOffset_bOverride_DepthOfFieldVignetteSize;

		// Token: 0x04007BDA RID: 31706
		internal static byte __PropertyMask_bOverride_DepthOfFieldVignetteSize;

		// Token: 0x04007BDB RID: 31707
		internal static int __PropertyOffset_bOverride_MotionBlurAmount;

		// Token: 0x04007BDC RID: 31708
		internal static byte __PropertyMask_bOverride_MotionBlurAmount;

		// Token: 0x04007BDD RID: 31709
		internal static int __PropertyOffset_bOverride_MotionBlurMax;

		// Token: 0x04007BDE RID: 31710
		internal static byte __PropertyMask_bOverride_MotionBlurMax;

		// Token: 0x04007BDF RID: 31711
		internal static int __PropertyOffset_bOverride_MotionBlurTargetFPS;

		// Token: 0x04007BE0 RID: 31712
		internal static byte __PropertyMask_bOverride_MotionBlurTargetFPS;

		// Token: 0x04007BE1 RID: 31713
		internal static int __PropertyOffset_bOverride_MotionBlurPerObjectSize;

		// Token: 0x04007BE2 RID: 31714
		internal static byte __PropertyMask_bOverride_MotionBlurPerObjectSize;

		// Token: 0x04007BE3 RID: 31715
		internal static int __PropertyOffset_bOverride_ScreenPercentage;

		// Token: 0x04007BE4 RID: 31716
		internal static byte __PropertyMask_bOverride_ScreenPercentage;

		// Token: 0x04007BE5 RID: 31717
		internal static int __PropertyOffset_bOverride_MotionBlurCharacterMask;

		// Token: 0x04007BE6 RID: 31718
		internal static byte __PropertyMask_bOverride_MotionBlurCharacterMask;

		// Token: 0x04007BE7 RID: 31719
		internal static int __PropertyOffset_bOverride_WithOutTranslucent;

		// Token: 0x04007BE8 RID: 31720
		internal static byte __PropertyMask_bOverride_WithOutTranslucent;

		// Token: 0x04007BE9 RID: 31721
		internal static int __PropertyOffset_bOverride_StartPosSwitch;

		// Token: 0x04007BEA RID: 31722
		internal static byte __PropertyMask_bOverride_StartPosSwitch;

		// Token: 0x04007BEB RID: 31723
		internal static int __PropertyOffset_bOverride_GrayGradationStartPos;

		// Token: 0x04007BEC RID: 31724
		internal static byte __PropertyMask_bOverride_GrayGradationStartPos;

		// Token: 0x04007BED RID: 31725
		internal static int __PropertyOffset_bOverride_GrayGradationDegree;

		// Token: 0x04007BEE RID: 31726
		internal static byte __PropertyMask_bOverride_GrayGradationDegree;

		// Token: 0x04007BEF RID: 31727
		internal static int __PropertyOffset_bOverride_GrayLerpWidth;

		// Token: 0x04007BF0 RID: 31728
		internal static byte __PropertyMask_bOverride_GrayLerpWidth;

		// Token: 0x04007BF1 RID: 31729
		internal static int __PropertyOffset_bOverride_GrayRampColor;

		// Token: 0x04007BF2 RID: 31730
		internal static byte __PropertyMask_bOverride_GrayRampColor;

		// Token: 0x04007BF3 RID: 31731
		internal static int __PropertyOffset_bOverride_GrayRampTint;

		// Token: 0x04007BF4 RID: 31732
		internal static byte __PropertyMask_bOverride_GrayRampTint;

		// Token: 0x04007BF5 RID: 31733
		internal static int __PropertyOffset_bOverride_GrayRampBlendWeight;

		// Token: 0x04007BF6 RID: 31734
		internal static byte __PropertyMask_bOverride_GrayRampBlendWeight;

		// Token: 0x04007BF7 RID: 31735
		internal static int __PropertyOffset_bOverride_SNNIntensity;

		// Token: 0x04007BF8 RID: 31736
		internal static byte __PropertyMask_bOverride_SNNIntensity;

		// Token: 0x04007BF9 RID: 31737
		internal static int __PropertyOffset_bOverride_SNNRoughnessContrast;

		// Token: 0x04007BFA RID: 31738
		internal static byte __PropertyMask_bOverride_SNNRoughnessContrast;

		// Token: 0x04007BFB RID: 31739
		internal static int __PropertyOffset_bOverride_SNNMetallicThreshold;

		// Token: 0x04007BFC RID: 31740
		internal static byte __PropertyMask_bOverride_SNNMetallicThreshold;

		// Token: 0x04007BFD RID: 31741
		internal static int __PropertyOffset_bOverride_SNNDepthFade;

		// Token: 0x04007BFE RID: 31742
		internal static byte __PropertyMask_bOverride_SNNDepthFade;

		// Token: 0x04007BFF RID: 31743
		internal static int __PropertyOffset_bOverride_SNNFoliageIntensity;

		// Token: 0x04007C00 RID: 31744
		internal static byte __PropertyMask_bOverride_SNNFoliageIntensity;

		// Token: 0x04007C01 RID: 31745
		internal static int __PropertyOffset_bOverride_SNNStructureIntensity;

		// Token: 0x04007C02 RID: 31746
		internal static byte __PropertyMask_bOverride_SNNStructureIntensity;

		// Token: 0x04007C03 RID: 31747
		internal static int __PropertyOffset_bOverride_SNNNoiseIntensity;

		// Token: 0x04007C04 RID: 31748
		internal static byte __PropertyMask_bOverride_SNNNoiseIntensity;

		// Token: 0x04007C05 RID: 31749
		internal static int __PropertyOffset_bOverride_SNNEnableSharpen;

		// Token: 0x04007C06 RID: 31750
		internal static byte __PropertyMask_bOverride_SNNEnableSharpen;

		// Token: 0x04007C07 RID: 31751
		internal static int __PropertyOffset_bOverride_SNNSharpeness;

		// Token: 0x04007C08 RID: 31752
		internal static byte __PropertyMask_bOverride_SNNSharpeness;

		// Token: 0x04007C09 RID: 31753
		internal static int __PropertyOffset_bOverride_SNNSharpenDepthFade;

		// Token: 0x04007C0A RID: 31754
		internal static byte __PropertyMask_bOverride_SNNSharpenDepthFade;

		// Token: 0x04007C0B RID: 31755
		internal static int __PropertyOffset_bOverride_SSFSIntensity;

		// Token: 0x04007C0C RID: 31756
		internal static byte __PropertyMask_bOverride_SSFSIntensity;

		// Token: 0x04007C0D RID: 31757
		internal static int __PropertyOffset_bOverride_SSFSRadius;

		// Token: 0x04007C0E RID: 31758
		internal static byte __PropertyMask_bOverride_SSFSRadius;

		// Token: 0x04007C0F RID: 31759
		internal static int __PropertyOffset_bOverride_SSFSLuminanceWeighting;

		// Token: 0x04007C10 RID: 31760
		internal static byte __PropertyMask_bOverride_SSFSLuminanceWeighting;

		// Token: 0x04007C11 RID: 31761
		internal static int __PropertyOffset_bOverride_SSFSSkyAtmosphereIntensity;

		// Token: 0x04007C12 RID: 31762
		internal static byte __PropertyMask_bOverride_SSFSSkyAtmosphereIntensity;

		// Token: 0x04007C13 RID: 31763
		internal static int __PropertyOffset_bOverride_SSFSVolumetricFogILSIntensity;

		// Token: 0x04007C14 RID: 31764
		internal static byte __PropertyMask_bOverride_SSFSVolumetricFogILSIntensity;

		// Token: 0x04007C15 RID: 31765
		internal static int __PropertyOffset_bOverride_SSFSKuroVolumetricLightILSIntensity;

		// Token: 0x04007C16 RID: 31766
		internal static byte __PropertyMask_bOverride_SSFSKuroVolumetricLightILSIntensity;

		// Token: 0x04007C17 RID: 31767
		internal static int __PropertyOffset_bOverride_SSFSStartDistance;

		// Token: 0x04007C18 RID: 31768
		internal static byte __PropertyMask_bOverride_SSFSStartDistance;

		// Token: 0x04007C19 RID: 31769
		internal static int __PropertyOffset_bOverride_SSFSMaxDepth;

		// Token: 0x04007C1A RID: 31770
		internal static byte __PropertyMask_bOverride_SSFSMaxDepth;

		// Token: 0x04007C1B RID: 31771
		internal static int __PropertyOffset_bOverride_EnableMobileSSFS;

		// Token: 0x04007C1C RID: 31772
		internal static byte __PropertyMask_bOverride_EnableMobileSSFS;

		// Token: 0x04007C1D RID: 31773
		internal static int __PropertyOffset_bOverride_MobileSSFSFogDensity;

		// Token: 0x04007C1E RID: 31774
		internal static byte __PropertyMask_bOverride_MobileSSFSFogDensity;

		// Token: 0x04007C1F RID: 31775
		internal static int __PropertyOffset_bOverride_MobileSSFSIntensity;

		// Token: 0x04007C20 RID: 31776
		internal static byte __PropertyMask_bOverride_MobileSSFSIntensity;

		// Token: 0x04007C21 RID: 31777
		internal static int __PropertyOffset_bOverride_MobileSSFSRadius;

		// Token: 0x04007C22 RID: 31778
		internal static byte __PropertyMask_bOverride_MobileSSFSRadius;

		// Token: 0x04007C23 RID: 31779
		internal static int __PropertyOffset_bOverride_MobileSSFSStartDistance;

		// Token: 0x04007C24 RID: 31780
		internal static byte __PropertyMask_bOverride_MobileSSFSStartDistance;

		// Token: 0x04007C25 RID: 31781
		internal static int __PropertyOffset_bOverride_KuroSharpenRadius;

		// Token: 0x04007C26 RID: 31782
		internal static byte __PropertyMask_bOverride_KuroSharpenRadius;

		// Token: 0x04007C27 RID: 31783
		internal static int __PropertyOffset_bOverride_KuroSharpenAmount;

		// Token: 0x04007C28 RID: 31784
		internal static byte __PropertyMask_bOverride_KuroSharpenAmount;

		// Token: 0x04007C29 RID: 31785
		internal static int __PropertyOffset_bOverride_KuroLaplacianAmount;

		// Token: 0x04007C2A RID: 31786
		internal static byte __PropertyMask_bOverride_KuroLaplacianAmount;

		// Token: 0x04007C2B RID: 31787
		internal static int __PropertyOffset_bOverride_KuroSharpenIntensity;

		// Token: 0x04007C2C RID: 31788
		internal static byte __PropertyMask_bOverride_KuroSharpenIntensity;

		// Token: 0x04007C2D RID: 31789
		internal static int __PropertyOffset_bOverride_KuroToonSharpenIntensity;

		// Token: 0x04007C2E RID: 31790
		internal static byte __PropertyMask_bOverride_KuroToonSharpenIntensity;

		// Token: 0x04007C2F RID: 31791
		internal static int __PropertyOffset_bOverride_KuroSharpenDistance;

		// Token: 0x04007C30 RID: 31792
		internal static byte __PropertyMask_bOverride_KuroSharpenDistance;

		// Token: 0x04007C31 RID: 31793
		internal static int __PropertyOffset_bOverride_TyndallScaLightIntensity;

		// Token: 0x04007C32 RID: 31794
		internal static byte __PropertyMask_bOverride_TyndallScaLightIntensity;

		// Token: 0x04007C33 RID: 31795
		internal static int __PropertyOffset_bOverride_TyndallDarkIntensity;

		// Token: 0x04007C34 RID: 31796
		internal static byte __PropertyMask_bOverride_TyndallDarkIntensity;

		// Token: 0x04007C35 RID: 31797
		internal static int __PropertyOffset_bOverride_TyndallScaLightLength;

		// Token: 0x04007C36 RID: 31798
		internal static byte __PropertyMask_bOverride_TyndallScaLightLength;

		// Token: 0x04007C37 RID: 31799
		internal static int __PropertyOffset_bOverride_TyndallScaLightColor;

		// Token: 0x04007C38 RID: 31800
		internal static byte __PropertyMask_bOverride_TyndallScaLightColor;

		// Token: 0x04007C39 RID: 31801
		internal static int __PropertyOffset_bOverride_TyndallScaLightFade;

		// Token: 0x04007C3A RID: 31802
		internal static byte __PropertyMask_bOverride_TyndallScaLightFade;

		// Token: 0x04007C3B RID: 31803
		internal static int __PropertyOffset_bOverride_TyndallScaLightMode;

		// Token: 0x04007C3C RID: 31804
		internal static byte __PropertyMask_bOverride_TyndallScaLightMode;

		// Token: 0x04007C3D RID: 31805
		internal static int __PropertyOffset_bOverride_TyndallScaNearFade;

		// Token: 0x04007C3E RID: 31806
		internal static byte __PropertyMask_bOverride_TyndallScaNearFade;

		// Token: 0x04007C3F RID: 31807
		internal static int __PropertyOffset_bOverride_TyndallScaDarkFadeDepth;

		// Token: 0x04007C40 RID: 31808
		internal static byte __PropertyMask_bOverride_TyndallScaDarkFadeDepth;

		// Token: 0x04007C41 RID: 31809
		internal static int __PropertyOffset_bOverride_TyndallScaMaxDepth;

		// Token: 0x04007C42 RID: 31810
		internal static byte __PropertyMask_bOverride_TyndallScaMaxDepth;

		// Token: 0x04007C43 RID: 31811
		internal static int __PropertyOffset_bOverride_EnableCustomPosition;

		// Token: 0x04007C44 RID: 31812
		internal static byte __PropertyMask_bOverride_EnableCustomPosition;

		// Token: 0x04007C45 RID: 31813
		internal static int __PropertyOffset_bOverride_TyndallCustomPosition;

		// Token: 0x04007C46 RID: 31814
		internal static byte __PropertyMask_bOverride_TyndallCustomPosition;

		// Token: 0x04007C47 RID: 31815
		internal static int __PropertyOffset_bOverride_KuroVolumetricLightEnable;

		// Token: 0x04007C48 RID: 31816
		internal static byte __PropertyMask_bOverride_KuroVolumetricLightEnable;

		// Token: 0x04007C49 RID: 31817
		internal static int __PropertyOffset_bOverride_KuroVolumetricLightIntensity;

		// Token: 0x04007C4A RID: 31818
		internal static byte __PropertyMask_bOverride_KuroVolumetricLightIntensity;

		// Token: 0x04007C4B RID: 31819
		internal static int __PropertyOffset_bOverride_KuroVolumetricLightColor;

		// Token: 0x04007C4C RID: 31820
		internal static byte __PropertyMask_bOverride_KuroVolumetricLightColor;

		// Token: 0x04007C4D RID: 31821
		internal static int __PropertyOffset_bOverride_KuroVolumetricLightPhaseG;

		// Token: 0x04007C4E RID: 31822
		internal static byte __PropertyMask_bOverride_KuroVolumetricLightPhaseG;

		// Token: 0x04007C4F RID: 31823
		internal static int __PropertyOffset_bOverride_KuroVolumetricLightMaxDistance;

		// Token: 0x04007C50 RID: 31824
		internal static byte __PropertyMask_bOverride_KuroVolumetricLightMaxDistance;

		// Token: 0x04007C51 RID: 31825
		internal static int __PropertyOffset_bOverride_KuroVolumetricLightBlurRadius;

		// Token: 0x04007C52 RID: 31826
		internal static byte __PropertyMask_bOverride_KuroVolumetricLightBlurRadius;

		// Token: 0x04007C53 RID: 31827
		internal static int __PropertyOffset_bOverride_KuroVolumetricLightUseColorMask;

		// Token: 0x04007C54 RID: 31828
		internal static byte __PropertyMask_bOverride_KuroVolumetricLightUseColorMask;

		// Token: 0x04007C55 RID: 31829
		internal static int __PropertyOffset_bOverride_KuroVolumetricLightColorMaskIntensity;

		// Token: 0x04007C56 RID: 31830
		internal static byte __PropertyMask_bOverride_KuroVolumetricLightColorMaskIntensity;

		// Token: 0x04007C57 RID: 31831
		internal static int __PropertyOffset_bOverride_ScreenSpaceReflectionIntensity;

		// Token: 0x04007C58 RID: 31832
		internal static byte __PropertyMask_bOverride_ScreenSpaceReflectionIntensity;

		// Token: 0x04007C59 RID: 31833
		internal static int __PropertyOffset_bOverride_ScreenSpaceReflectionQuality;

		// Token: 0x04007C5A RID: 31834
		internal static byte __PropertyMask_bOverride_ScreenSpaceReflectionQuality;

		// Token: 0x04007C5B RID: 31835
		internal static int __PropertyOffset_bOverride_ScreenSpaceReflectionMaxRoughness;

		// Token: 0x04007C5C RID: 31836
		internal static byte __PropertyMask_bOverride_ScreenSpaceReflectionMaxRoughness;

		// Token: 0x04007C5D RID: 31837
		internal static int __PropertyOffset_bOverride_KuroTonemapA;

		// Token: 0x04007C5E RID: 31838
		internal static byte __PropertyMask_bOverride_KuroTonemapA;

		// Token: 0x04007C5F RID: 31839
		internal static int __PropertyOffset_bOverride_KuroTonemapB;

		// Token: 0x04007C60 RID: 31840
		internal static byte __PropertyMask_bOverride_KuroTonemapB;

		// Token: 0x04007C61 RID: 31841
		internal static int __PropertyOffset_bOverride_KuroTonemapC;

		// Token: 0x04007C62 RID: 31842
		internal static byte __PropertyMask_bOverride_KuroTonemapC;

		// Token: 0x04007C63 RID: 31843
		internal static int __PropertyOffset_bOverride_KuroTonemapD;

		// Token: 0x04007C64 RID: 31844
		internal static byte __PropertyMask_bOverride_KuroTonemapD;

		// Token: 0x04007C65 RID: 31845
		internal static int __PropertyOffset_bOverride_KuroTonemapE;

		// Token: 0x04007C66 RID: 31846
		internal static byte __PropertyMask_bOverride_KuroTonemapE;

		// Token: 0x04007C67 RID: 31847
		internal static int __PropertyOffset_bOverride_KuroTonemapF;

		// Token: 0x04007C68 RID: 31848
		internal static byte __PropertyMask_bOverride_KuroTonemapF;

		// Token: 0x04007C69 RID: 31849
		internal static int __PropertyOffset_bOverride_UseCharacterMask;

		// Token: 0x04007C6A RID: 31850
		internal static byte __PropertyMask_bOverride_UseCharacterMask;

		// Token: 0x04007C6B RID: 31851
		internal static int __PropertyOffset_bOverride_ScreenSpaceReflectionRoughnessScale;

		// Token: 0x04007C6C RID: 31852
		internal static byte __PropertyMask_bOverride_ScreenSpaceReflectionRoughnessScale;

		// Token: 0x04007C6D RID: 31853
		internal static int __PropertyOffset_bOverride_ReflectionsType;

		// Token: 0x04007C6E RID: 31854
		internal static byte __PropertyMask_bOverride_ReflectionsType;

		// Token: 0x04007C6F RID: 31855
		internal static int __PropertyOffset_bOverride_RayTracingReflectionsMaxRoughness;

		// Token: 0x04007C70 RID: 31856
		internal static byte __PropertyMask_bOverride_RayTracingReflectionsMaxRoughness;

		// Token: 0x04007C71 RID: 31857
		internal static int __PropertyOffset_bOverride_RayTracingReflectionsMaxBounces;

		// Token: 0x04007C72 RID: 31858
		internal static byte __PropertyMask_bOverride_RayTracingReflectionsMaxBounces;

		// Token: 0x04007C73 RID: 31859
		internal static int __PropertyOffset_bOverride_RayTracingReflectionsSamplesPerPixel;

		// Token: 0x04007C74 RID: 31860
		internal static byte __PropertyMask_bOverride_RayTracingReflectionsSamplesPerPixel;

		// Token: 0x04007C75 RID: 31861
		internal static int __PropertyOffset_bOverride_RayTracingReflectionsShadows;

		// Token: 0x04007C76 RID: 31862
		internal static byte __PropertyMask_bOverride_RayTracingReflectionsShadows;

		// Token: 0x04007C77 RID: 31863
		internal static int __PropertyOffset_bOverride_RayTracingReflectionsTranslucency;

		// Token: 0x04007C78 RID: 31864
		internal static byte __PropertyMask_bOverride_RayTracingReflectionsTranslucency;

		// Token: 0x04007C79 RID: 31865
		internal static int __PropertyOffset_bOverride_TranslucencyType;

		// Token: 0x04007C7A RID: 31866
		internal static byte __PropertyMask_bOverride_TranslucencyType;

		// Token: 0x04007C7B RID: 31867
		internal static int __PropertyOffset_bOverride_RayTracingTranslucencyMaxRoughness;

		// Token: 0x04007C7C RID: 31868
		internal static byte __PropertyMask_bOverride_RayTracingTranslucencyMaxRoughness;

		// Token: 0x04007C7D RID: 31869
		internal static int __PropertyOffset_bOverride_RayTracingTranslucencyRefractionRays;

		// Token: 0x04007C7E RID: 31870
		internal static byte __PropertyMask_bOverride_RayTracingTranslucencyRefractionRays;

		// Token: 0x04007C7F RID: 31871
		internal static int __PropertyOffset_bOverride_RayTracingTranslucencySamplesPerPixel;

		// Token: 0x04007C80 RID: 31872
		internal static byte __PropertyMask_bOverride_RayTracingTranslucencySamplesPerPixel;

		// Token: 0x04007C81 RID: 31873
		internal static int __PropertyOffset_bOverride_RayTracingTranslucencyShadows;

		// Token: 0x04007C82 RID: 31874
		internal static byte __PropertyMask_bOverride_RayTracingTranslucencyShadows;

		// Token: 0x04007C83 RID: 31875
		internal static int __PropertyOffset_bOverride_RayTracingTranslucencyRefraction;

		// Token: 0x04007C84 RID: 31876
		internal static byte __PropertyMask_bOverride_RayTracingTranslucencyRefraction;

		// Token: 0x04007C85 RID: 31877
		internal static int __PropertyOffset_bOverride_RayTracingGI;

		// Token: 0x04007C86 RID: 31878
		internal static byte __PropertyMask_bOverride_RayTracingGI;

		// Token: 0x04007C87 RID: 31879
		internal static int __PropertyOffset_bOverride_RayTracingGIMaxBounces;

		// Token: 0x04007C88 RID: 31880
		internal static byte __PropertyMask_bOverride_RayTracingGIMaxBounces;

		// Token: 0x04007C89 RID: 31881
		internal static int __PropertyOffset_bOverride_RayTracingGISamplesPerPixel;

		// Token: 0x04007C8A RID: 31882
		internal static byte __PropertyMask_bOverride_RayTracingGISamplesPerPixel;

		// Token: 0x04007C8B RID: 31883
		internal static int __PropertyOffset_bOverride_PathTracingMaxBounces;

		// Token: 0x04007C8C RID: 31884
		internal static byte __PropertyMask_bOverride_PathTracingMaxBounces;

		// Token: 0x04007C8D RID: 31885
		internal static int __PropertyOffset_bOverride_PathTracingSamplesPerPixel;

		// Token: 0x04007C8E RID: 31886
		internal static byte __PropertyMask_bOverride_PathTracingSamplesPerPixel;

		// Token: 0x04007C8F RID: 31887
		internal static int __PropertyOffset_bKuroDangerToggle;

		// Token: 0x04007C90 RID: 31888
		internal static byte __PropertyMask_bKuroDangerToggle;

		// Token: 0x04007C91 RID: 31889
		internal static int __PropertyOffset_bMobileHQGaussian;

		// Token: 0x04007C92 RID: 31890
		internal static byte __PropertyMask_bMobileHQGaussian;

		// Token: 0x04007C93 RID: 31891
		internal static int __PropertyOffset_bOverride_KuroCharacterLUTSplitEnable;

		// Token: 0x04007C94 RID: 31892
		internal static byte __PropertyMask_bOverride_KuroCharacterLUTSplitEnable;

		// Token: 0x04007C95 RID: 31893
		internal static int __PropertyOffset_bOverride_KuroCharacterColorGradingLUT;

		// Token: 0x04007C96 RID: 31894
		internal static byte __PropertyMask_bOverride_KuroCharacterColorGradingLUT;

		// Token: 0x04007C97 RID: 31895
		internal static int __PropertyOffset_bOverride_KuroCharacterColorGradingLUTLerpIntensity;

		// Token: 0x04007C98 RID: 31896
		internal static byte __PropertyMask_bOverride_KuroCharacterColorGradingLUTLerpIntensity;

		// Token: 0x04007C99 RID: 31897
		internal static int __PropertyOffset_bOverride_KuroColorGradingTextureLUTInterpolationEnable;

		// Token: 0x04007C9A RID: 31898
		internal static byte __PropertyMask_bOverride_KuroColorGradingTextureLUTInterpolationEnable;

		// Token: 0x04007C9B RID: 31899
		internal static int __PropertyOffset_KuroTonemapA;

		// Token: 0x04007C9C RID: 31900
		internal static int __PropertyOffset_KuroTonemapB;

		// Token: 0x04007C9D RID: 31901
		internal static int __PropertyOffset_KuroTonemapC;

		// Token: 0x04007C9E RID: 31902
		internal static int __PropertyOffset_KuroTonemapD;

		// Token: 0x04007C9F RID: 31903
		internal static int __PropertyOffset_KuroTonemapE;

		// Token: 0x04007CA0 RID: 31904
		internal static int __PropertyOffset_KuroTonemapF;

		// Token: 0x04007CA1 RID: 31905
		internal static int __PropertyOffset_UseCharacterMask;

		// Token: 0x04007CA2 RID: 31906
		internal static int __PropertyOffset_BloomMethod;

		// Token: 0x04007CA3 RID: 31907
		internal static int __PropertyOffset_AutoExposureMethod;

		// Token: 0x04007CA4 RID: 31908
		internal static int __PropertyOffset_WhiteTemp;

		// Token: 0x04007CA5 RID: 31909
		internal static int __PropertyOffset_WhiteTint;

		// Token: 0x04007CA6 RID: 31910
		internal static int __PropertyOffset_ColorSaturation;

		// Token: 0x04007CA7 RID: 31911
		internal static int __PropertyOffset_ColorContrast;

		// Token: 0x04007CA8 RID: 31912
		internal static int __PropertyOffset_ColorGamma;

		// Token: 0x04007CA9 RID: 31913
		internal static int __PropertyOffset_ColorGain;

		// Token: 0x04007CAA RID: 31914
		internal static int __PropertyOffset_ColorOffset;

		// Token: 0x04007CAB RID: 31915
		internal static int __PropertyOffset_ColorSaturationClient;

		// Token: 0x04007CAC RID: 31916
		internal static int __PropertyOffset_ColorContrastClient;

		// Token: 0x04007CAD RID: 31917
		internal static int __PropertyOffset_ColorSaturationShadows;

		// Token: 0x04007CAE RID: 31918
		internal static int __PropertyOffset_ColorContrastShadows;

		// Token: 0x04007CAF RID: 31919
		internal static int __PropertyOffset_ColorGammaShadows;

		// Token: 0x04007CB0 RID: 31920
		internal static int __PropertyOffset_ColorGainShadows;

		// Token: 0x04007CB1 RID: 31921
		internal static int __PropertyOffset_ColorOffsetShadows;

		// Token: 0x04007CB2 RID: 31922
		internal static int __PropertyOffset_ColorSaturationMidtones;

		// Token: 0x04007CB3 RID: 31923
		internal static int __PropertyOffset_ColorContrastMidtones;

		// Token: 0x04007CB4 RID: 31924
		internal static int __PropertyOffset_ColorGammaMidtones;

		// Token: 0x04007CB5 RID: 31925
		internal static int __PropertyOffset_ColorGainMidtones;

		// Token: 0x04007CB6 RID: 31926
		internal static int __PropertyOffset_ColorOffsetMidtones;

		// Token: 0x04007CB7 RID: 31927
		internal static int __PropertyOffset_ColorSaturationHighlights;

		// Token: 0x04007CB8 RID: 31928
		internal static int __PropertyOffset_ColorContrastHighlights;

		// Token: 0x04007CB9 RID: 31929
		internal static int __PropertyOffset_ColorGammaHighlights;

		// Token: 0x04007CBA RID: 31930
		internal static int __PropertyOffset_ColorGainHighlights;

		// Token: 0x04007CBB RID: 31931
		internal static int __PropertyOffset_ColorOffsetHighlights;

		// Token: 0x04007CBC RID: 31932
		internal static int __PropertyOffset_ColorCorrectionHighlightsMin;

		// Token: 0x04007CBD RID: 31933
		internal static int __PropertyOffset_ColorCorrectionShadowsMax;

		// Token: 0x04007CBE RID: 31934
		internal static int __PropertyOffset_BlueCorrection;

		// Token: 0x04007CBF RID: 31935
		internal static int __PropertyOffset_ExpandGamut;

		// Token: 0x04007CC0 RID: 31936
		internal static int __PropertyOffset_ToneCurveAmount;

		// Token: 0x04007CC1 RID: 31937
		internal static int __PropertyOffset_FilmSlope;

		// Token: 0x04007CC2 RID: 31938
		internal static int __PropertyOffset_FilmToe;

		// Token: 0x04007CC3 RID: 31939
		internal static int __PropertyOffset_FilmShoulder;

		// Token: 0x04007CC4 RID: 31940
		internal static int __PropertyOffset_FilmBlackClip;

		// Token: 0x04007CC5 RID: 31941
		internal static int __PropertyOffset_FilmWhiteClip;

		// Token: 0x04007CC6 RID: 31942
		internal static int __PropertyOffset_FilmWhitePoint;

		// Token: 0x04007CC7 RID: 31943
		internal static int __PropertyOffset_FilmShadowTint;

		// Token: 0x04007CC8 RID: 31944
		internal static int __PropertyOffset_FilmShadowTintBlend;

		// Token: 0x04007CC9 RID: 31945
		internal static int __PropertyOffset_FilmShadowTintAmount;

		// Token: 0x04007CCA RID: 31946
		internal static int __PropertyOffset_FilmSaturation;

		// Token: 0x04007CCB RID: 31947
		internal static int __PropertyOffset_FilmChannelMixerRed;

		// Token: 0x04007CCC RID: 31948
		internal static int __PropertyOffset_FilmChannelMixerGreen;

		// Token: 0x04007CCD RID: 31949
		internal static int __PropertyOffset_FilmChannelMixerBlue;

		// Token: 0x04007CCE RID: 31950
		internal static int __PropertyOffset_FilmContrast;

		// Token: 0x04007CCF RID: 31951
		internal static int __PropertyOffset_FilmToeAmount;

		// Token: 0x04007CD0 RID: 31952
		internal static int __PropertyOffset_FilmHealAmount;

		// Token: 0x04007CD1 RID: 31953
		internal static int __PropertyOffset_FilmDynamicRange;

		// Token: 0x04007CD2 RID: 31954
		internal static int __PropertyOffset_SceneColorTint;

		// Token: 0x04007CD3 RID: 31955
		internal static int __PropertyOffset_DecalSaturation;

		// Token: 0x04007CD4 RID: 31956
		internal static int __PropertyOffset_DecalOpacity;

		// Token: 0x04007CD5 RID: 31957
		internal static int __PropertyOffset_TranslucentColorTint;

		// Token: 0x04007CD6 RID: 31958
		internal static int __PropertyOffset_SceneColorDesaturate;

		// Token: 0x04007CD7 RID: 31959
		internal static int __PropertyOffset_SceneColorClear;

		// Token: 0x04007CD8 RID: 31960
		internal static int __PropertyOffset_SceneColorClearColor;

		// Token: 0x04007CD9 RID: 31961
		internal static int __PropertyOffset_SceneColorClearCenter;

		// Token: 0x04007CDA RID: 31962
		internal static int __PropertyOffset_SceneColorClearRadius;

		// Token: 0x04007CDB RID: 31963
		internal static int __PropertyOffset_SceneColorClearFadeDistance;

		// Token: 0x04007CDC RID: 31964
		internal static int __PropertyOffset_TranslucentColorDesaturate;

		// Token: 0x04007CDD RID: 31965
		internal static int __PropertyOffset_FightTranslucentNoDesaturate;

		// Token: 0x04007CDE RID: 31966
		internal static int __PropertyOffset_SceneTranslucentColorTint;

		// Token: 0x04007CDF RID: 31967
		internal static int __PropertyOffset_SceneEmissiveTint;

		// Token: 0x04007CE0 RID: 31968
		internal static int __PropertyOffset_SceneTranslucentColorDesaturate;

		// Token: 0x04007CE1 RID: 31969
		internal static int __PropertyOffset_SeparateTranslucencyBlurSize;

		// Token: 0x04007CE2 RID: 31970
		internal static int __PropertyOffset_EnableSPD;

		// Token: 0x04007CE3 RID: 31971
		internal static byte __PropertyMask_EnableSPD;

		// Token: 0x04007CE4 RID: 31972
		internal static int __PropertyOffset_SceneFringeIntensity;

		// Token: 0x04007CE5 RID: 31973
		internal static int __PropertyOffset_ChromaticAberrationStartOffset;

		// Token: 0x04007CE6 RID: 31974
		internal static int __PropertyOffset_BaoChromaticAberrationIntensity;

		// Token: 0x04007CE7 RID: 31975
		internal static int __PropertyOffset_BaoChromaticAberrationMaskCenter;

		// Token: 0x04007CE8 RID: 31976
		internal static int __PropertyOffset_BaoChromaticAberrationYScale;

		// Token: 0x04007CE9 RID: 31977
		internal static int __PropertyOffset_BaoChromaticAberrationYPan;

		// Token: 0x04007CEA RID: 31978
		internal static int __PropertyOffset_KuroFoliageMaterialAO;

		// Token: 0x04007CEB RID: 31979
		internal static int __PropertyOffset_KuroFoliageScreenSpaceAO;

		// Token: 0x04007CEC RID: 31980
		internal static int __PropertyOffset_UseFixCharacterRim;

		// Token: 0x04007CED RID: 31981
		internal static byte __PropertyMask_UseFixCharacterRim;

		// Token: 0x04007CEE RID: 31982
		internal static int __PropertyOffset_FixCharacterRimAngleV;

		// Token: 0x04007CEF RID: 31983
		internal static int __PropertyOffset_FixCharacterRimAngleH;

		// Token: 0x04007CF0 RID: 31984
		internal static int __PropertyOffset_UseCustomRim;

		// Token: 0x04007CF1 RID: 31985
		internal static byte __PropertyMask_UseCustomRim;

		// Token: 0x04007CF2 RID: 31986
		internal static int __PropertyOffset_CustomRimColor_Stencil1;

		// Token: 0x04007CF3 RID: 31987
		internal static int __PropertyOffset_FixCharacterRimAngleV_Stencil1;

		// Token: 0x04007CF4 RID: 31988
		internal static int __PropertyOffset_FixCharacterRimAngleH_Stencil1;

		// Token: 0x04007CF5 RID: 31989
		internal static int __PropertyOffset_CustomRimColor_Stencil2;

		// Token: 0x04007CF6 RID: 31990
		internal static int __PropertyOffset_FixCharacterRimAngleV_Stencil2;

		// Token: 0x04007CF7 RID: 31991
		internal static int __PropertyOffset_FixCharacterRimAngleH_Stencil2;

		// Token: 0x04007CF8 RID: 31992
		internal static int __PropertyOffset_CustomRimColor_Stencil3;

		// Token: 0x04007CF9 RID: 31993
		internal static int __PropertyOffset_FixCharacterRimAngleV_Stencil3;

		// Token: 0x04007CFA RID: 31994
		internal static int __PropertyOffset_FixCharacterRimAngleH_Stencil3;

		// Token: 0x04007CFB RID: 31995
		internal static int __PropertyOffset_KuroBloomIntensity;

		// Token: 0x04007CFC RID: 31996
		internal static int __PropertyOffset_KuroBloomThreshold;

		// Token: 0x04007CFD RID: 31997
		internal static int __PropertyOffset_EnableSplitCharBloom;

		// Token: 0x04007CFE RID: 31998
		internal static byte __PropertyMask_EnableSplitCharBloom;

		// Token: 0x04007CFF RID: 31999
		internal static int __PropertyOffset_KuroCharacterBloomIntensity;

		// Token: 0x04007D00 RID: 32000
		internal static int __PropertyOffset_KuroCharacterBloomThreshold;

		// Token: 0x04007D01 RID: 32001
		internal static int __PropertyOffset_SunDirBloomIntensity;

		// Token: 0x04007D02 RID: 32002
		internal static int __PropertyOffset_KuroBloomCombineParameter;

		// Token: 0x04007D03 RID: 32003
		internal static int __PropertyOffset_KuroBloomStreakIntensity;

		// Token: 0x04007D04 RID: 32004
		internal static int __PropertyOffset_KuroBloomStreakThreshold;

		// Token: 0x04007D05 RID: 32005
		internal static int __PropertyOffset_TranslucentBloomStreakIntensity;

		// Token: 0x04007D06 RID: 32006
		internal static int __PropertyOffset_TranslucentBloomStreakThreshold;

		// Token: 0x04007D07 RID: 32007
		internal static int __PropertyOffset_KuroBloomStreakLength;

		// Token: 0x04007D08 RID: 32008
		internal static int __PropertyOffset_KuroBloomStreakMipLevel;

		// Token: 0x04007D09 RID: 32009
		internal static int __PropertyOffset_KuroBloomStreakRatio;

		// Token: 0x04007D0A RID: 32010
		internal static int __PropertyOffset_KuroBloomStreakOrientation;

		// Token: 0x04007D0B RID: 32011
		internal static int __PropertyOffset_BlackWhiteFlashIntensity;

		// Token: 0x04007D0C RID: 32012
		internal static int __PropertyOffset_BlackWhiteFlashFactor;

		// Token: 0x04007D0D RID: 32013
		internal static int __PropertyOffset_BlackWhiteFlashThreshold;

		// Token: 0x04007D0E RID: 32014
		internal static int __PropertyOffset_BlackWhiteFlashBlackAreaColor;

		// Token: 0x04007D0F RID: 32015
		internal static int __PropertyOffset_BlackWhiteFlashWhiteAreaColor;

		// Token: 0x04007D10 RID: 32016
		internal static int __PropertyOffset_KuroRadialBlurIntensity;

		// Token: 0x04007D11 RID: 32017
		internal static int __PropertyOffset_KuroRadialBlurCenter;

		// Token: 0x04007D12 RID: 32018
		internal static int __PropertyOffset_UseClampRadialBlurCenter;

		// Token: 0x04007D13 RID: 32019
		internal static int __PropertyOffset_KuroRadialBlurRadius;

		// Token: 0x04007D14 RID: 32020
		internal static int __PropertyOffset_KuroRadialBlurHardness;

		// Token: 0x04007D15 RID: 32021
		internal static int __PropertyOffset_KuroRadialBlurPassNumber;

		// Token: 0x04007D16 RID: 32022
		internal static int __PropertyOffset_KuroRadialBlurSampleNumber;

		// Token: 0x04007D17 RID: 32023
		internal static int __PropertyOffset_KuroRadialBlurMask;

		// Token: 0x04007D18 RID: 32024
		internal static int __PropertyOffset_KuroRadialBlurMaskScale;

		// Token: 0x04007D19 RID: 32025
		internal static int __PropertyOffset_KuroRadialBlurMaskOffset;

		// Token: 0x04007D1A RID: 32026
		internal static int __PropertyOffset_ScreenSoftIntensity;

		// Token: 0x04007D1B RID: 32027
		internal static int __PropertyOffset_ScreenSoftThreshold;

		// Token: 0x04007D1C RID: 32028
		internal static int __PropertyOffset_ScreenSoftDistance;

		// Token: 0x04007D1D RID: 32029
		internal static int __PropertyOffset_ScreenSoftSkyBloomCompensation;

		// Token: 0x04007D1E RID: 32030
		internal static int __PropertyOffset_ScreenSoftRange;

		// Token: 0x04007D1F RID: 32031
		internal static int __PropertyOffset_ScreenSoftOverflowDistance;

		// Token: 0x04007D20 RID: 32032
		internal static int __PropertyOffset_ScreenSoftSunExposure;

		// Token: 0x04007D21 RID: 32033
		internal static int __PropertyOffset_ScreenSoftHighQuality;

		// Token: 0x04007D22 RID: 32034
		internal static int __PropertyOffset_MobileScreenSoftIntensity;

		// Token: 0x04007D23 RID: 32035
		internal static int __PropertyOffset_MobileScreenSoftThreshold;

		// Token: 0x04007D24 RID: 32036
		internal static int __PropertyOffset_MobileScreenSoftDistance;

		// Token: 0x04007D25 RID: 32037
		internal static int __PropertyOffset_ScreenLeakTexture;

		// Token: 0x04007D26 RID: 32038
		internal static int __PropertyOffset_ScreenLeakTextureIntensity;

		// Token: 0x04007D27 RID: 32039
		internal static int __PropertyOffset_FFTIntensity;

		// Token: 0x04007D28 RID: 32040
		internal static int __PropertyOffset_FFTThreshold;

		// Token: 0x04007D29 RID: 32041
		internal static int __PropertyOffset_FFTTexture;

		// Token: 0x04007D2A RID: 32042
		internal static int __PropertyOffset_FFTScatterDispersion;

		// Token: 0x04007D2B RID: 32043
		internal static int __PropertyOffset_FFTSize;

		// Token: 0x04007D2C RID: 32044
		internal static int __PropertyOffset_FFTPreFilterMin;

		// Token: 0x04007D2D RID: 32045
		internal static int __PropertyOffset_FFTPreFilterMax;

		// Token: 0x04007D2E RID: 32046
		internal static int __PropertyOffset_FFTPreFilterMult;

		// Token: 0x04007D2F RID: 32047
		internal static int __PropertyOffset_FFTBufferScale;

		// Token: 0x04007D30 RID: 32048
		internal static int __PropertyOffset_FFTDistance;

		// Token: 0x04007D31 RID: 32049
		internal static int __PropertyOffset_FFTHidenSky;

		// Token: 0x04007D32 RID: 32050
		internal static byte __PropertyMask_FFTHidenSky;

		// Token: 0x04007D33 RID: 32051
		internal static int __PropertyOffset_FFTHidenTranslucent;

		// Token: 0x04007D34 RID: 32052
		internal static byte __PropertyMask_FFTHidenTranslucent;

		// Token: 0x04007D35 RID: 32053
		internal static int __PropertyOffset_FFTBeforeTranslucency;

		// Token: 0x04007D36 RID: 32054
		internal static byte __PropertyMask_FFTBeforeTranslucency;

		// Token: 0x04007D37 RID: 32055
		internal static int __PropertyOffset_ToonFFTIntensity;

		// Token: 0x04007D38 RID: 32056
		internal static int __PropertyOffset_ToonFFTThreshold;

		// Token: 0x04007D39 RID: 32057
		internal static int __PropertyOffset_ToonFFTTexture;

		// Token: 0x04007D3A RID: 32058
		internal static int __PropertyOffset_ToonFFTScatterDispersion;

		// Token: 0x04007D3B RID: 32059
		internal static int __PropertyOffset_ToonFFTSize;

		// Token: 0x04007D3C RID: 32060
		internal static int __PropertyOffset_LightFadeScale;

		// Token: 0x04007D3D RID: 32061
		internal static int __PropertyOffset_KuroDataDistortionNoiseIntensity;

		// Token: 0x04007D3E RID: 32062
		internal static int __PropertyOffset_KuroDataDistortionNoiseTexture;

		// Token: 0x04007D3F RID: 32063
		internal static int __PropertyOffset_KuroDataDistortionNoiseTextureUVScaleBias;

		// Token: 0x04007D40 RID: 32064
		internal static int __PropertyOffset_KuroDataDistortionNoiseSize;

		// Token: 0x04007D41 RID: 32065
		internal static int __PropertyOffset_KuroDataDistortionNoiseBias;

		// Token: 0x04007D42 RID: 32066
		internal static int __PropertyOffset_KuroDataDistortionSignalIntensity;

		// Token: 0x04007D43 RID: 32067
		internal static int __PropertyOffset_KuroDataDistortionRandomColorSize;

		// Token: 0x04007D44 RID: 32068
		internal static int __PropertyOffset_KuroDataDistortionSinWaveParameters;

		// Token: 0x04007D45 RID: 32069
		internal static int __PropertyOffset_KuroDataDistortionColorTint;

		// Token: 0x04007D46 RID: 32070
		internal static int __PropertyOffset_BloomIntensity;

		// Token: 0x04007D47 RID: 32071
		internal static int __PropertyOffset_BloomThreshold;

		// Token: 0x04007D48 RID: 32072
		internal static int __PropertyOffset_BloomSizeScale;

		// Token: 0x04007D49 RID: 32073
		internal static int __PropertyOffset_Bloom1Size;

		// Token: 0x04007D4A RID: 32074
		internal static int __PropertyOffset_Bloom2Size;

		// Token: 0x04007D4B RID: 32075
		internal static int __PropertyOffset_Bloom3Size;

		// Token: 0x04007D4C RID: 32076
		internal static int __PropertyOffset_Bloom4Size;

		// Token: 0x04007D4D RID: 32077
		internal static int __PropertyOffset_Bloom5Size;

		// Token: 0x04007D4E RID: 32078
		internal static int __PropertyOffset_Bloom6Size;

		// Token: 0x04007D4F RID: 32079
		internal static int __PropertyOffset_Bloom1Tint;

		// Token: 0x04007D50 RID: 32080
		internal static int __PropertyOffset_Bloom2Tint;

		// Token: 0x04007D51 RID: 32081
		internal static int __PropertyOffset_Bloom3Tint;

		// Token: 0x04007D52 RID: 32082
		internal static int __PropertyOffset_Bloom4Tint;

		// Token: 0x04007D53 RID: 32083
		internal static int __PropertyOffset_Bloom5Tint;

		// Token: 0x04007D54 RID: 32084
		internal static int __PropertyOffset_Bloom6Tint;

		// Token: 0x04007D55 RID: 32085
		internal static int __PropertyOffset_BloomDirtMask;

		// Token: 0x04007D56 RID: 32086
		internal static int __PropertyOffset_BloomDirtMaskIntensity;

		// Token: 0x04007D57 RID: 32087
		internal static int __PropertyOffset_BloomDirtMaskTint;

		// Token: 0x04007D58 RID: 32088
		internal static int __PropertyOffset_bMegaLights;

		// Token: 0x04007D59 RID: 32089
		internal static byte __PropertyMask_bMegaLights;

		// Token: 0x04007D5A RID: 32090
		internal static int __PropertyOffset_AmbientCubemapTint;

		// Token: 0x04007D5B RID: 32091
		internal static int __PropertyOffset_AmbientCubemapIntensity;

		// Token: 0x04007D5C RID: 32092
		internal static int __PropertyOffset_AmbientCubemap;

		// Token: 0x04007D5D RID: 32093
		internal static int __PropertyOffset_CameraShutterSpeed;

		// Token: 0x04007D5E RID: 32094
		internal static int __PropertyOffset_CameraISO;

		// Token: 0x04007D5F RID: 32095
		internal static int __PropertyOffset_DepthOfFieldFstop;

		// Token: 0x04007D60 RID: 32096
		internal static int __PropertyOffset_DepthOfFieldMinFstop;

		// Token: 0x04007D61 RID: 32097
		internal static int __PropertyOffset_DepthOfFieldBladeCount;

		// Token: 0x04007D62 RID: 32098
		internal static int __PropertyOffset_bUseForegroundBlur;

		// Token: 0x04007D63 RID: 32099
		internal static byte __PropertyMask_bUseForegroundBlur;

		// Token: 0x04007D64 RID: 32100
		internal static int __PropertyOffset_AutoExposureBias;

		// Token: 0x04007D65 RID: 32101
		internal static int __PropertyOffset_AutoExposureBiasBackup;

		// Token: 0x04007D66 RID: 32102
		internal static int __PropertyOffset_bOverride_AutoExposureBiasBackup;

		// Token: 0x04007D67 RID: 32103
		internal static byte __PropertyMask_bOverride_AutoExposureBiasBackup;

		// Token: 0x04007D68 RID: 32104
		internal static int __PropertyOffset_AutoExposureApplyPhysicalCameraExposure;

		// Token: 0x04007D69 RID: 32105
		internal static byte __PropertyMask_AutoExposureApplyPhysicalCameraExposure;

		// Token: 0x04007D6A RID: 32106
		internal static int __PropertyOffset_AutoExposureBiasCurve;

		// Token: 0x04007D6B RID: 32107
		internal static int __PropertyOffset_AutoExposureMeterMask;

		// Token: 0x04007D6C RID: 32108
		internal static int __PropertyOffset_AutoExposureLowPercent;

		// Token: 0x04007D6D RID: 32109
		internal static int __PropertyOffset_AutoExposureHighPercent;

		// Token: 0x04007D6E RID: 32110
		internal static int __PropertyOffset_AutoExposureMinBrightness;

		// Token: 0x04007D6F RID: 32111
		internal static int __PropertyOffset_AutoExposureMaxBrightness;

		// Token: 0x04007D70 RID: 32112
		internal static int __PropertyOffset_AutoExposureSpeedUp;

		// Token: 0x04007D71 RID: 32113
		internal static int __PropertyOffset_AutoExposureSpeedDown;

		// Token: 0x04007D72 RID: 32114
		internal static int __PropertyOffset_HistogramLogMin;

		// Token: 0x04007D73 RID: 32115
		internal static int __PropertyOffset_HistogramLogMax;

		// Token: 0x04007D74 RID: 32116
		internal static int __PropertyOffset_LocalExposureMethod;

		// Token: 0x04007D75 RID: 32117
		internal static int __PropertyOffset_LocalExposureContrastScale_DEPRECATED;

		// Token: 0x04007D76 RID: 32118
		internal static int __PropertyOffset_LocalExposureHighlightContrastScale;

		// Token: 0x04007D77 RID: 32119
		internal static int __PropertyOffset_LocalExposureShadowContrastScale;

		// Token: 0x04007D78 RID: 32120
		internal static int __PropertyOffset_LocalExposureHighlightContrastCurve;

		// Token: 0x04007D79 RID: 32121
		internal static int __PropertyOffset_LocalExposureShadowContrastCurve;

		// Token: 0x04007D7A RID: 32122
		internal static int __PropertyOffset_LocalExposureHighlightThreshold;

		// Token: 0x04007D7B RID: 32123
		internal static int __PropertyOffset_LocalExposureShadowThreshold;

		// Token: 0x04007D7C RID: 32124
		internal static int __PropertyOffset_LocalExposureDetailStrength;

		// Token: 0x04007D7D RID: 32125
		internal static int __PropertyOffset_LocalExposureBlurredLuminanceBlend;

		// Token: 0x04007D7E RID: 32126
		internal static int __PropertyOffset_LocalExposureBlurredLuminanceKernelSizePercent;

		// Token: 0x04007D7F RID: 32127
		internal static int __PropertyOffset_LocalExposureMiddleGreyBias;

		// Token: 0x04007D80 RID: 32128
		internal static int __PropertyOffset_AutoExposureCalibrationConstant_DEPRECATED;

		// Token: 0x04007D81 RID: 32129
		internal static int __PropertyOffset_LensFlareIntensity;

		// Token: 0x04007D82 RID: 32130
		internal static int __PropertyOffset_LensFlareTint;

		// Token: 0x04007D83 RID: 32131
		internal static int __PropertyOffset_LensFlareBokehSize;

		// Token: 0x04007D84 RID: 32132
		internal static int __PropertyOffset_LensFlareThreshold;

		// Token: 0x04007D85 RID: 32133
		internal static int __PropertyOffset_LensFlareBokehShape;

		// Token: 0x04007D86 RID: 32134
		internal static int __PropertyOffset_LensFlareTints;

		// Token: 0x04007D87 RID: 32135
		private TArray<FLinearColor> _LensFlareTints;

		// Token: 0x04007D88 RID: 32136
		internal static int __PropertyOffset_LensFlareOnlySun;

		// Token: 0x04007D89 RID: 32137
		internal static byte __PropertyMask_LensFlareOnlySun;

		// Token: 0x04007D8A RID: 32138
		internal static int __PropertyOffset_LensFlareSunRange;

		// Token: 0x04007D8B RID: 32139
		internal static int __PropertyOffset_LensFlareSunPosition;

		// Token: 0x04007D8C RID: 32140
		internal static int __PropertyOffset_VignetteIntensity;

		// Token: 0x04007D8D RID: 32141
		internal static int __PropertyOffset_VignetteHardness;

		// Token: 0x04007D8E RID: 32142
		internal static int __PropertyOffset_VignetteXScale;

		// Token: 0x04007D8F RID: 32143
		internal static int __PropertyOffset_VignetteYScale;

		// Token: 0x04007D90 RID: 32144
		internal static int __PropertyOffset_VignetteXPos;

		// Token: 0x04007D91 RID: 32145
		internal static int __PropertyOffset_VignetteYPos;

		// Token: 0x04007D92 RID: 32146
		internal static int __PropertyOffset_VignetteColor;

		// Token: 0x04007D93 RID: 32147
		internal static int __PropertyOffset_VignetteGain;

		// Token: 0x04007D94 RID: 32148
		internal static int __PropertyOffset_EffectVignetteIntensity;

		// Token: 0x04007D95 RID: 32149
		internal static int __PropertyOffset_EffectVignetteHardness;

		// Token: 0x04007D96 RID: 32150
		internal static int __PropertyOffset_EffectVignetteXScale;

		// Token: 0x04007D97 RID: 32151
		internal static int __PropertyOffset_EffectVignetteYScale;

		// Token: 0x04007D98 RID: 32152
		internal static int __PropertyOffset_EffectVignetteXPos;

		// Token: 0x04007D99 RID: 32153
		internal static int __PropertyOffset_EffectVignetteYPos;

		// Token: 0x04007D9A RID: 32154
		internal static int __PropertyOffset_EffectVignetteColor;

		// Token: 0x04007D9B RID: 32155
		internal static int __PropertyOffset_EffectVignetteGain;

		// Token: 0x04007D9C RID: 32156
		internal static int __PropertyOffset_GrainJitter;

		// Token: 0x04007D9D RID: 32157
		internal static int __PropertyOffset_GrainIntensity;

		// Token: 0x04007D9E RID: 32158
		internal static int __PropertyOffset_GrainColorful;

		// Token: 0x04007D9F RID: 32159
		internal static int __PropertyOffset_MainCenterMask;

		// Token: 0x04007DA0 RID: 32160
		internal static int __PropertyOffset_MainCenterMaskRadius;

		// Token: 0x04007DA1 RID: 32161
		internal static int __PropertyOffset_MainCenterMaskHardness;

		// Token: 0x04007DA2 RID: 32162
		internal static int __PropertyOffset_MainStartDistance;

		// Token: 0x04007DA3 RID: 32163
		internal static int __PropertyOffset_MainCharacterIntensity;

		// Token: 0x04007DA4 RID: 32164
		internal static int __PropertyOffset_VintageColorIntensity;

		// Token: 0x04007DA5 RID: 32165
		internal static int __PropertyOffset_VintageColorBlackPoint;

		// Token: 0x04007DA6 RID: 32166
		internal static int __PropertyOffset_VintageColorWhitePoint;

		// Token: 0x04007DA7 RID: 32167
		internal static int __PropertyOffset_VHSLinesColorIntensity;

		// Token: 0x04007DA8 RID: 32168
		internal static int __PropertyOffset_VHSLinesDistortIntensity;

		// Token: 0x04007DA9 RID: 32169
		internal static int __PropertyOffset_VHSEffectIntensity;

		// Token: 0x04007DAA RID: 32170
		internal static int __PropertyOffset_VHSSpecklesIntensity;

		// Token: 0x04007DAB RID: 32171
		internal static int __PropertyOffset_VHSSpecklesAmount;

		// Token: 0x04007DAC RID: 32172
		internal static int __PropertyOffset_VHSSpecklesSize;

		// Token: 0x04007DAD RID: 32173
		internal static int __PropertyOffset_CRTDistortion;

		// Token: 0x04007DAE RID: 32174
		internal static int __PropertyOffset_VintageColorCenterMask;

		// Token: 0x04007DAF RID: 32175
		internal static int __PropertyOffset_VintageColorStartDistance;

		// Token: 0x04007DB0 RID: 32176
		internal static int __PropertyOffset_VintageColorCharacterIntensity;

		// Token: 0x04007DB1 RID: 32177
		internal static int __PropertyOffset_VHSLinesCenterMask;

		// Token: 0x04007DB2 RID: 32178
		internal static int __PropertyOffset_VHSLinesStartDistance;

		// Token: 0x04007DB3 RID: 32179
		internal static int __PropertyOffset_VHSLinesCharacterIntensity;

		// Token: 0x04007DB4 RID: 32180
		internal static int __PropertyOffset_VHSEffectCenterMask;

		// Token: 0x04007DB5 RID: 32181
		internal static int __PropertyOffset_VHSEffectStartDistance;

		// Token: 0x04007DB6 RID: 32182
		internal static int __PropertyOffset_VHSEffectCharacterIntensity;

		// Token: 0x04007DB7 RID: 32183
		internal static int __PropertyOffset_VHSSpecklesCenterMask;

		// Token: 0x04007DB8 RID: 32184
		internal static int __PropertyOffset_VHSSpecklesStartDistance;

		// Token: 0x04007DB9 RID: 32185
		internal static int __PropertyOffset_VHSSpecklesCharacterIntensity;

		// Token: 0x04007DBA RID: 32186
		internal static int __PropertyOffset_AmbientOcclusionIntensity;

		// Token: 0x04007DBB RID: 32187
		internal static int __PropertyOffset_AmbientOcclusionStaticFraction;

		// Token: 0x04007DBC RID: 32188
		internal static int __PropertyOffset_AmbientOcclusionRadius;

		// Token: 0x04007DBD RID: 32189
		internal static int __PropertyOffset_AmbientOcclusionRadiusInWS;

		// Token: 0x04007DBE RID: 32190
		internal static byte __PropertyMask_AmbientOcclusionRadiusInWS;

		// Token: 0x04007DBF RID: 32191
		internal static int __PropertyOffset_AmbientOcclusionFadeDistance;

		// Token: 0x04007DC0 RID: 32192
		internal static int __PropertyOffset_AmbientOcclusionFadeRadius;

		// Token: 0x04007DC1 RID: 32193
		internal static int __PropertyOffset_AmbientOcclusionDistance_DEPRECATED;

		// Token: 0x04007DC2 RID: 32194
		internal static int __PropertyOffset_AmbientOcclusionPower;

		// Token: 0x04007DC3 RID: 32195
		internal static int __PropertyOffset_AmbientOcclusionBias;

		// Token: 0x04007DC4 RID: 32196
		internal static int __PropertyOffset_AmbientOcclusionQuality;

		// Token: 0x04007DC5 RID: 32197
		internal static int __PropertyOffset_AmbientOcclusionMipBlend;

		// Token: 0x04007DC6 RID: 32198
		internal static int __PropertyOffset_AmbientOcclusionMipScale;

		// Token: 0x04007DC7 RID: 32199
		internal static int __PropertyOffset_AmbientOcclusionMipThreshold;

		// Token: 0x04007DC8 RID: 32200
		internal static int __PropertyOffset_AmbientOcclusionTemporalBlendWeight;

		// Token: 0x04007DC9 RID: 32201
		internal static int __PropertyOffset_RayTracingAO;

		// Token: 0x04007DCA RID: 32202
		internal static byte __PropertyMask_RayTracingAO;

		// Token: 0x04007DCB RID: 32203
		internal static int __PropertyOffset_RayTracingAOSamplesPerPixel;

		// Token: 0x04007DCC RID: 32204
		internal static int __PropertyOffset_RayTracingAOIntensity;

		// Token: 0x04007DCD RID: 32205
		internal static int __PropertyOffset_RayTracingAORadius;

		// Token: 0x04007DCE RID: 32206
		internal static int __PropertyOffset_LumenSkylightLeaking;

		// Token: 0x04007DCF RID: 32207
		internal static int __PropertyOffset_IndirectLightingColor;

		// Token: 0x04007DD0 RID: 32208
		internal static int __PropertyOffset_IndirectLightingIntensity;

		// Token: 0x04007DD1 RID: 32209
		internal static int __PropertyOffset_RayTracingGIType;

		// Token: 0x04007DD2 RID: 32210
		internal static int __PropertyOffset_RayTracingGIMaxBounces;

		// Token: 0x04007DD3 RID: 32211
		internal static int __PropertyOffset_RayTracingGISamplesPerPixel;

		// Token: 0x04007DD4 RID: 32212
		internal static int __PropertyOffset_ColorGradingIntensity;

		// Token: 0x04007DD5 RID: 32213
		internal static int __PropertyOffset_ColorGradingLUT;

		// Token: 0x04007DD6 RID: 32214
		internal static int __PropertyOffset_DepthOfFieldSensorWidth;

		// Token: 0x04007DD7 RID: 32215
		internal static int __PropertyOffset_DepthOfFieldFocalDistance;

		// Token: 0x04007DD8 RID: 32216
		internal static int __PropertyOffset_DepthOfFieldDepthBlurAmount;

		// Token: 0x04007DD9 RID: 32217
		internal static int __PropertyOffset_DepthOfFieldDepthBlurRadius;

		// Token: 0x04007DDA RID: 32218
		internal static int __PropertyOffset_DepthOfFieldFocalRegion;

		// Token: 0x04007DDB RID: 32219
		internal static int __PropertyOffset_DepthOfFieldNearTransitionRegion;

		// Token: 0x04007DDC RID: 32220
		internal static int __PropertyOffset_DepthOfFieldFarTransitionRegion;

		// Token: 0x04007DDD RID: 32221
		internal static int __PropertyOffset_DepthOfFieldScale;

		// Token: 0x04007DDE RID: 32222
		internal static int __PropertyOffset_DepthOfFieldNearBlurSize;

		// Token: 0x04007DDF RID: 32223
		internal static int __PropertyOffset_DepthOfFieldFarBlurSize;

		// Token: 0x04007DE0 RID: 32224
		internal static int __PropertyOffset_DepthOfFieldOcclusion;

		// Token: 0x04007DE1 RID: 32225
		internal static int __PropertyOffset_DepthOfFieldSkyFocusDistance;

		// Token: 0x04007DE2 RID: 32226
		internal static int __PropertyOffset_DepthOfFieldVignetteSize;

		// Token: 0x04007DE3 RID: 32227
		internal static int __PropertyOffset_MotionBlurAmount;

		// Token: 0x04007DE4 RID: 32228
		internal static int __PropertyOffset_MotionBlurMax;

		// Token: 0x04007DE5 RID: 32229
		internal static int __PropertyOffset_MotionBlurTargetFPS;

		// Token: 0x04007DE6 RID: 32230
		internal static int __PropertyOffset_MotionBlurPerObjectSize;

		// Token: 0x04007DE7 RID: 32231
		internal static int __PropertyOffset_bMotionBlurCharacterMask;

		// Token: 0x04007DE8 RID: 32232
		internal static int __PropertyOffset_LPVIntensity;

		// Token: 0x04007DE9 RID: 32233
		internal static int __PropertyOffset_LPVVplInjectionBias;

		// Token: 0x04007DEA RID: 32234
		internal static int __PropertyOffset_LPVSize;

		// Token: 0x04007DEB RID: 32235
		internal static int __PropertyOffset_LPVSecondaryOcclusionIntensity;

		// Token: 0x04007DEC RID: 32236
		internal static int __PropertyOffset_LPVSecondaryBounceIntensity;

		// Token: 0x04007DED RID: 32237
		internal static int __PropertyOffset_LPVGeometryVolumeBias;

		// Token: 0x04007DEE RID: 32238
		internal static int __PropertyOffset_LPVEmissiveInjectionIntensity;

		// Token: 0x04007DEF RID: 32239
		internal static int __PropertyOffset_LPVDirectionalOcclusionIntensity;

		// Token: 0x04007DF0 RID: 32240
		internal static int __PropertyOffset_LPVDirectionalOcclusionRadius;

		// Token: 0x04007DF1 RID: 32241
		internal static int __PropertyOffset_LPVDiffuseOcclusionExponent;

		// Token: 0x04007DF2 RID: 32242
		internal static int __PropertyOffset_LPVSpecularOcclusionExponent;

		// Token: 0x04007DF3 RID: 32243
		internal static int __PropertyOffset_LPVDiffuseOcclusionIntensity;

		// Token: 0x04007DF4 RID: 32244
		internal static int __PropertyOffset_LPVSpecularOcclusionIntensity;

		// Token: 0x04007DF5 RID: 32245
		internal static int __PropertyOffset_ReflectionsType;

		// Token: 0x04007DF6 RID: 32246
		internal static int __PropertyOffset_ScreenSpaceReflectionIntensity;

		// Token: 0x04007DF7 RID: 32247
		internal static int __PropertyOffset_ScreenSpaceReflectionQuality;

		// Token: 0x04007DF8 RID: 32248
		internal static int __PropertyOffset_ScreenSpaceReflectionMaxRoughness;

		// Token: 0x04007DF9 RID: 32249
		internal static int __PropertyOffset_RayTracingReflectionsMaxRoughness;

		// Token: 0x04007DFA RID: 32250
		internal static int __PropertyOffset_RayTracingReflectionsMaxBounces;

		// Token: 0x04007DFB RID: 32251
		internal static int __PropertyOffset_RayTracingReflectionsSamplesPerPixel;

		// Token: 0x04007DFC RID: 32252
		internal static int __PropertyOffset_RayTracingReflectionsShadows;

		// Token: 0x04007DFD RID: 32253
		internal static int __PropertyOffset_RayTracingReflectionsTranslucency;

		// Token: 0x04007DFE RID: 32254
		internal static byte __PropertyMask_RayTracingReflectionsTranslucency;

		// Token: 0x04007DFF RID: 32255
		internal static int __PropertyOffset_TranslucencyType;

		// Token: 0x04007E00 RID: 32256
		internal static int __PropertyOffset_RayTracingTranslucencyMaxRoughness;

		// Token: 0x04007E01 RID: 32257
		internal static int __PropertyOffset_RayTracingTranslucencyRefractionRays;

		// Token: 0x04007E02 RID: 32258
		internal static int __PropertyOffset_RayTracingTranslucencySamplesPerPixel;

		// Token: 0x04007E03 RID: 32259
		internal static int __PropertyOffset_RayTracingTranslucencyShadows;

		// Token: 0x04007E04 RID: 32260
		internal static int __PropertyOffset_RayTracingTranslucencyRefraction;

		// Token: 0x04007E05 RID: 32261
		internal static byte __PropertyMask_RayTracingTranslucencyRefraction;

		// Token: 0x04007E06 RID: 32262
		internal static int __PropertyOffset_PathTracingMaxBounces;

		// Token: 0x04007E07 RID: 32263
		internal static int __PropertyOffset_PathTracingSamplesPerPixel;

		// Token: 0x04007E08 RID: 32264
		internal static int __PropertyOffset_LPVFadeRange;

		// Token: 0x04007E09 RID: 32265
		internal static int __PropertyOffset_LPVDirectionalOcclusionFadeRange;

		// Token: 0x04007E0A RID: 32266
		internal static int __PropertyOffset_ScreenPercentage;

		// Token: 0x04007E0B RID: 32267
		internal static int __PropertyOffset_WithOutTranslucent;

		// Token: 0x04007E0C RID: 32268
		internal static int __PropertyOffset_StartPosSwitch;

		// Token: 0x04007E0D RID: 32269
		internal static int __PropertyOffset_GrayGradationStartPos;

		// Token: 0x04007E0E RID: 32270
		internal static int __PropertyOffset_GrayGradationDegree;

		// Token: 0x04007E0F RID: 32271
		internal static int __PropertyOffset_GrayLerpWidth;

		// Token: 0x04007E10 RID: 32272
		internal static int __PropertyOffset_GrayRampColor;

		// Token: 0x04007E11 RID: 32273
		internal static int __PropertyOffset_GrayRampTint;

		// Token: 0x04007E12 RID: 32274
		internal static int __PropertyOffset_GrayRampBlendWeight;

		// Token: 0x04007E13 RID: 32275
		internal static int __PropertyOffset_SNNIntensity;

		// Token: 0x04007E14 RID: 32276
		internal static int __PropertyOffset_SNNRoughnessContrast;

		// Token: 0x04007E15 RID: 32277
		internal static int __PropertyOffset_SNNMetallicThreshold;

		// Token: 0x04007E16 RID: 32278
		internal static int __PropertyOffset_SNNDepthFade;

		// Token: 0x04007E17 RID: 32279
		internal static int __PropertyOffset_SNNFoliageIntensity;

		// Token: 0x04007E18 RID: 32280
		internal static int __PropertyOffset_SNNStructureIntensity;

		// Token: 0x04007E19 RID: 32281
		internal static int __PropertyOffset_SNNNoiseIntensity;

		// Token: 0x04007E1A RID: 32282
		internal static int __PropertyOffset_SNNEnableSharpen;

		// Token: 0x04007E1B RID: 32283
		internal static int __PropertyOffset_SNNSharpeness;

		// Token: 0x04007E1C RID: 32284
		internal static int __PropertyOffset_SNNSharpenDepthFade;

		// Token: 0x04007E1D RID: 32285
		internal static int __PropertyOffset_SSFSIntensity;

		// Token: 0x04007E1E RID: 32286
		internal static int __PropertyOffset_SSFSRadius;

		// Token: 0x04007E1F RID: 32287
		internal static int __PropertyOffset_SSFSLuminanceWeighting;

		// Token: 0x04007E20 RID: 32288
		internal static int __PropertyOffset_SSFSSkyAtmosphereIntensity;

		// Token: 0x04007E21 RID: 32289
		internal static int __PropertyOffset_SSFSVolumetricFogILSIntensity;

		// Token: 0x04007E22 RID: 32290
		internal static int __PropertyOffset_SSFSKuroVolumetricLightILSIntensity;

		// Token: 0x04007E23 RID: 32291
		internal static int __PropertyOffset_SSFSStartDistance;

		// Token: 0x04007E24 RID: 32292
		internal static int __PropertyOffset_SSFSMaxDepth;

		// Token: 0x04007E25 RID: 32293
		internal static int __PropertyOffset_EnableMobileSSFS;

		// Token: 0x04007E26 RID: 32294
		internal static byte __PropertyMask_EnableMobileSSFS;

		// Token: 0x04007E27 RID: 32295
		internal static int __PropertyOffset_MobileSSFSFogDensity;

		// Token: 0x04007E28 RID: 32296
		internal static int __PropertyOffset_MobileSSFSIntensity;

		// Token: 0x04007E29 RID: 32297
		internal static int __PropertyOffset_MobileSSFSRadius;

		// Token: 0x04007E2A RID: 32298
		internal static int __PropertyOffset_MobileSSFSStartDistance;

		// Token: 0x04007E2B RID: 32299
		internal static int __PropertyOffset_KuroSharpenRadius;

		// Token: 0x04007E2C RID: 32300
		internal static int __PropertyOffset_KuroSharpenAmount;

		// Token: 0x04007E2D RID: 32301
		internal static int __PropertyOffset_KuroLaplacianAmount;

		// Token: 0x04007E2E RID: 32302
		internal static int __PropertyOffset_KuroSharpenIntensity;

		// Token: 0x04007E2F RID: 32303
		internal static int __PropertyOffset_KuroToonSharpenIntensity;

		// Token: 0x04007E30 RID: 32304
		internal static int __PropertyOffset_KuroSharpenDistance;

		// Token: 0x04007E31 RID: 32305
		internal static int __PropertyOffset_TyndallScaLightIntensity;

		// Token: 0x04007E32 RID: 32306
		internal static int __PropertyOffset_TyndallDarkIntensity;

		// Token: 0x04007E33 RID: 32307
		internal static int __PropertyOffset_TyndallScaLightLength;

		// Token: 0x04007E34 RID: 32308
		internal static int __PropertyOffset_TyndallScaLightColor;

		// Token: 0x04007E35 RID: 32309
		internal static int __PropertyOffset_TyndallScaLightFade;

		// Token: 0x04007E36 RID: 32310
		internal static int __PropertyOffset_TyndallScaLightMode;

		// Token: 0x04007E37 RID: 32311
		internal static int __PropertyOffset_TyndallScaNearFade;

		// Token: 0x04007E38 RID: 32312
		internal static int __PropertyOffset_TyndallScaDarkFadeDepth;

		// Token: 0x04007E39 RID: 32313
		internal static int __PropertyOffset_TyndallScaMaxDepth;

		// Token: 0x04007E3A RID: 32314
		internal static int __PropertyOffset_EnableCustomPosition;

		// Token: 0x04007E3B RID: 32315
		internal static int __PropertyOffset_TyndallCustomPosition;

		// Token: 0x04007E3C RID: 32316
		internal static int __PropertyOffset_KuroVolumetricLightEnable;

		// Token: 0x04007E3D RID: 32317
		internal static int __PropertyOffset_KuroVolumetricLightIntensity;

		// Token: 0x04007E3E RID: 32318
		internal static int __PropertyOffset_KuroVolumetricLightColor;

		// Token: 0x04007E3F RID: 32319
		internal static int __PropertyOffset_KuroVolumetricLightPhaseG;

		// Token: 0x04007E40 RID: 32320
		internal static int __PropertyOffset_KuroVolumetricLightMaxDistance;

		// Token: 0x04007E41 RID: 32321
		internal static int __PropertyOffset_KuroVolumetricLightBlurRadius;

		// Token: 0x04007E42 RID: 32322
		internal static int __PropertyOffset_KuroVolumetricLightUseColorMask;

		// Token: 0x04007E43 RID: 32323
		internal static int __PropertyOffset_KuroVolumetricLightColorMaskIntensity;

		// Token: 0x04007E44 RID: 32324
		internal static int __PropertyOffset_KuroCharacterLUTSplitEnable;

		// Token: 0x04007E45 RID: 32325
		internal static int __PropertyOffset_KuroCharacterColorGradingLUT;

		// Token: 0x04007E46 RID: 32326
		internal static int __PropertyOffset_KuroCharacterColorGradingLUTLerpIntensity;

		// Token: 0x04007E47 RID: 32327
		internal static int __PropertyOffset_KuroColorGradingTextureLUTInterpolationEnable;

		// Token: 0x04007E48 RID: 32328
		internal static int __PropertyOffset_WeightedBlendables;

		// Token: 0x04007E49 RID: 32329
		private FWeightedBlendables _WeightedBlendables;
	}
}
