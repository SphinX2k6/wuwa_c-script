using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001ACF RID: 6863
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroCloudLayerSetting")]
	[UnrealStructLayout(208, 16, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 208)]
	public class FKuroCloudLayerSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06019875 RID: 104565 RVA: 0x0025B9AC File Offset: 0x00259BAC
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroCloudLayerSetting._ScriptStructPtr != 0) ? FKuroCloudLayerSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroCloudLayerSetting", ref FKuroCloudLayerSetting._ScriptStructPtr);
		}

		// Token: 0x170065DE RID: 26078
		// (get) Token: 0x06019876 RID: 104566 RVA: 0x0025B9D0 File Offset: 0x00259BD0
		// (set) Token: 0x06019877 RID: 104567 RVA: 0x0025B9E9 File Offset: 0x00259BE9
		public unsafe bool bOverride_CloudsDensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsDensity) & FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsDensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsDensity) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsDensity) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsDensity) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsDensity : 0));
			}
		}

		// Token: 0x170065DF RID: 26079
		// (get) Token: 0x06019878 RID: 104568 RVA: 0x0025BA19 File Offset: 0x00259C19
		// (set) Token: 0x06019879 RID: 104569 RVA: 0x0025BA32 File Offset: 0x00259C32
		public unsafe bool bOverride_CloudsBlend
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsBlend) & FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsBlend) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsBlend) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsBlend) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsBlend) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsBlend : 0));
			}
		}

		// Token: 0x170065E0 RID: 26080
		// (get) Token: 0x0601987A RID: 104570 RVA: 0x0025BA62 File Offset: 0x00259C62
		// (set) Token: 0x0601987B RID: 104571 RVA: 0x0025BA7B File Offset: 0x00259C7B
		public unsafe bool bOverride_CloudsBloom
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsBloom) & FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsBloom) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsBloom) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsBloom) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsBloom) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsBloom : 0));
			}
		}

		// Token: 0x170065E1 RID: 26081
		// (get) Token: 0x0601987C RID: 104572 RVA: 0x0025BAAB File Offset: 0x00259CAB
		// (set) Token: 0x0601987D RID: 104573 RVA: 0x0025BAC4 File Offset: 0x00259CC4
		public unsafe bool bOverride_UVScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_UVScale) & FKuroCloudLayerSetting.__PropertyMask_bOverride_UVScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_UVScale) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_UVScale) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_UVScale) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_UVScale : 0));
			}
		}

		// Token: 0x170065E2 RID: 26082
		// (get) Token: 0x0601987E RID: 104574 RVA: 0x0025BAF4 File Offset: 0x00259CF4
		// (set) Token: 0x0601987F RID: 104575 RVA: 0x0025BB0D File Offset: 0x00259D0D
		public unsafe bool bOverride_WindForceScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_WindForceScale) & FKuroCloudLayerSetting.__PropertyMask_bOverride_WindForceScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_WindForceScale) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_WindForceScale) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_WindForceScale) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_WindForceScale : 0));
			}
		}

		// Token: 0x170065E3 RID: 26083
		// (get) Token: 0x06019880 RID: 104576 RVA: 0x0025BB3D File Offset: 0x00259D3D
		// (set) Token: 0x06019881 RID: 104577 RVA: 0x0025BB56 File Offset: 0x00259D56
		public unsafe bool bOverride_BaseLayerSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_BaseLayerSize) & FKuroCloudLayerSetting.__PropertyMask_bOverride_BaseLayerSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_BaseLayerSize) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_BaseLayerSize) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_BaseLayerSize) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_BaseLayerSize : 0));
			}
		}

		// Token: 0x170065E4 RID: 26084
		// (get) Token: 0x06019882 RID: 104578 RVA: 0x0025BB86 File Offset: 0x00259D86
		// (set) Token: 0x06019883 RID: 104579 RVA: 0x0025BB9F File Offset: 0x00259D9F
		public unsafe bool bOverride_SecondLayerSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_SecondLayerSize) & FKuroCloudLayerSetting.__PropertyMask_bOverride_SecondLayerSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_SecondLayerSize) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_SecondLayerSize) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_SecondLayerSize) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_SecondLayerSize : 0));
			}
		}

		// Token: 0x170065E5 RID: 26085
		// (get) Token: 0x06019884 RID: 104580 RVA: 0x0025BBCF File Offset: 0x00259DCF
		// (set) Token: 0x06019885 RID: 104581 RVA: 0x0025BBE8 File Offset: 0x00259DE8
		public unsafe bool bOverride_CloudLayer1
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudLayer1) & FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudLayer1) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudLayer1) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudLayer1) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudLayer1) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudLayer1 : 0));
			}
		}

		// Token: 0x170065E6 RID: 26086
		// (get) Token: 0x06019886 RID: 104582 RVA: 0x0025BC18 File Offset: 0x00259E18
		// (set) Token: 0x06019887 RID: 104583 RVA: 0x0025BC31 File Offset: 0x00259E31
		public unsafe bool bOverride_CloudLayer2
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudLayer2) & FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudLayer2) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudLayer2) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudLayer2) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudLayer2) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudLayer2 : 0));
			}
		}

		// Token: 0x170065E7 RID: 26087
		// (get) Token: 0x06019888 RID: 104584 RVA: 0x0025BC61 File Offset: 0x00259E61
		// (set) Token: 0x06019889 RID: 104585 RVA: 0x0025BC7A File Offset: 0x00259E7A
		public unsafe bool bOverride_CloudsHardness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsHardness) & FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsHardness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsHardness) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsHardness) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsHardness) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsHardness : 0));
			}
		}

		// Token: 0x170065E8 RID: 26088
		// (get) Token: 0x0601988A RID: 104586 RVA: 0x0025BCAA File Offset: 0x00259EAA
		// (set) Token: 0x0601988B RID: 104587 RVA: 0x0025BCC3 File Offset: 0x00259EC3
		public unsafe bool bOverride_CloudsTranslucent
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsTranslucent) & FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsTranslucent) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsTranslucent) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsTranslucent) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsTranslucent) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsTranslucent : 0));
			}
		}

		// Token: 0x170065E9 RID: 26089
		// (get) Token: 0x0601988C RID: 104588 RVA: 0x0025BCF3 File Offset: 0x00259EF3
		// (set) Token: 0x0601988D RID: 104589 RVA: 0x0025BD0C File Offset: 0x00259F0C
		public unsafe bool bOverride_CloudsVertexDensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsVertexDensity) & FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsVertexDensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsVertexDensity) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsVertexDensity) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsVertexDensity) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsVertexDensity : 0));
			}
		}

		// Token: 0x170065EA RID: 26090
		// (get) Token: 0x0601988E RID: 104590 RVA: 0x0025BD3C File Offset: 0x00259F3C
		// (set) Token: 0x0601988F RID: 104591 RVA: 0x0025BD55 File Offset: 0x00259F55
		public unsafe bool bOverride_CloudsFluffy
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsFluffy) & FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsFluffy) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsFluffy) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsFluffy) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsFluffy) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsFluffy : 0));
			}
		}

		// Token: 0x170065EB RID: 26091
		// (get) Token: 0x06019890 RID: 104592 RVA: 0x0025BD85 File Offset: 0x00259F85
		// (set) Token: 0x06019891 RID: 104593 RVA: 0x0025BD9E File Offset: 0x00259F9E
		public unsafe bool bOverride_CloudsDistotion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsDistotion) & FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsDistotion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsDistotion) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsDistotion) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsDistotion) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsDistotion : 0));
			}
		}

		// Token: 0x170065EC RID: 26092
		// (get) Token: 0x06019892 RID: 104594 RVA: 0x0025BDCE File Offset: 0x00259FCE
		// (set) Token: 0x06019893 RID: 104595 RVA: 0x0025BDE7 File Offset: 0x00259FE7
		public unsafe bool bOverride_CloudsScattering
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsScattering) & FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsScattering) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsScattering) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsScattering) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsScattering) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsScattering : 0));
			}
		}

		// Token: 0x170065ED RID: 26093
		// (get) Token: 0x06019894 RID: 104596 RVA: 0x0025BE17 File Offset: 0x0025A017
		// (set) Token: 0x06019895 RID: 104597 RVA: 0x0025BE30 File Offset: 0x0025A030
		public unsafe bool bOverride_CloudsAmbient
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsAmbient) & FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsAmbient) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsAmbient) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsAmbient) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsAmbient) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsAmbient : 0));
			}
		}

		// Token: 0x170065EE RID: 26094
		// (get) Token: 0x06019896 RID: 104598 RVA: 0x0025BE60 File Offset: 0x0025A060
		// (set) Token: 0x06019897 RID: 104599 RVA: 0x0025BE79 File Offset: 0x0025A079
		public unsafe bool bOverride_CloudsShadowSize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsShadowSize) & FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsShadowSize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsShadowSize) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsShadowSize) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsShadowSize) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsShadowSize : 0));
			}
		}

		// Token: 0x170065EF RID: 26095
		// (get) Token: 0x06019898 RID: 104600 RVA: 0x0025BEA9 File Offset: 0x0025A0A9
		// (set) Token: 0x06019899 RID: 104601 RVA: 0x0025BEC2 File Offset: 0x0025A0C2
		public unsafe bool bOverride_CloudsShadowSoft
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsShadowSoft) & FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsShadowSoft) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsShadowSoft) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsShadowSoft) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsShadowSoft) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsShadowSoft : 0));
			}
		}

		// Token: 0x170065F0 RID: 26096
		// (get) Token: 0x0601989A RID: 104602 RVA: 0x0025BEF2 File Offset: 0x0025A0F2
		// (set) Token: 0x0601989B RID: 104603 RVA: 0x0025BF0B File Offset: 0x0025A10B
		public unsafe bool bOverride_CloudsUpperBrightness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsUpperBrightness) & FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsUpperBrightness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsUpperBrightness) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsUpperBrightness) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsUpperBrightness) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsUpperBrightness : 0));
			}
		}

		// Token: 0x170065F1 RID: 26097
		// (get) Token: 0x0601989C RID: 104604 RVA: 0x0025BF3B File Offset: 0x0025A13B
		// (set) Token: 0x0601989D RID: 104605 RVA: 0x0025BF54 File Offset: 0x0025A154
		public unsafe bool bOverride_CloudsLowerBrightness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsLowerBrightness) & FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsLowerBrightness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsLowerBrightness) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsLowerBrightness) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsLowerBrightness) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsLowerBrightness : 0));
			}
		}

		// Token: 0x170065F2 RID: 26098
		// (get) Token: 0x0601989E RID: 104606 RVA: 0x0025BF84 File Offset: 0x0025A184
		// (set) Token: 0x0601989F RID: 104607 RVA: 0x0025BF9D File Offset: 0x0025A19D
		public unsafe bool bOverride_CloudsUpperColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsUpperColor) & FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsUpperColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsUpperColor) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsUpperColor) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsUpperColor) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsUpperColor : 0));
			}
		}

		// Token: 0x170065F3 RID: 26099
		// (get) Token: 0x060198A0 RID: 104608 RVA: 0x0025BFCD File Offset: 0x0025A1CD
		// (set) Token: 0x060198A1 RID: 104609 RVA: 0x0025BFE6 File Offset: 0x0025A1E6
		public unsafe bool bOverride_CloudsLowerColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsLowerColor) & FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsLowerColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsLowerColor) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsLowerColor) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsLowerColor) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsLowerColor : 0));
			}
		}

		// Token: 0x170065F4 RID: 26100
		// (get) Token: 0x060198A2 RID: 104610 RVA: 0x0025C016 File Offset: 0x0025A216
		// (set) Token: 0x060198A3 RID: 104611 RVA: 0x0025C02F File Offset: 0x0025A22F
		public unsafe bool bOverride_CloudsBackgroundColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsBackgroundColor) & FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsBackgroundColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsBackgroundColor) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsBackgroundColor) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsBackgroundColor) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsBackgroundColor : 0));
			}
		}

		// Token: 0x170065F5 RID: 26101
		// (get) Token: 0x060198A4 RID: 104612 RVA: 0x0025C05F File Offset: 0x0025A25F
		// (set) Token: 0x060198A5 RID: 104613 RVA: 0x0025C078 File Offset: 0x0025A278
		public unsafe bool bOverride_CloudsBackground
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsBackground) & FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsBackground) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsBackground) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsBackground) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsBackground) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsBackground : 0));
			}
		}

		// Token: 0x170065F6 RID: 26102
		// (get) Token: 0x060198A6 RID: 104614 RVA: 0x0025C0A8 File Offset: 0x0025A2A8
		// (set) Token: 0x060198A7 RID: 104615 RVA: 0x0025C0C1 File Offset: 0x0025A2C1
		public unsafe bool bOverride_CloudsHorizonAlpha
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsHorizonAlpha) & FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsHorizonAlpha) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsHorizonAlpha) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_CloudsHorizonAlpha) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsHorizonAlpha) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_CloudsHorizonAlpha : 0));
			}
		}

		// Token: 0x170065F7 RID: 26103
		// (get) Token: 0x060198A8 RID: 104616 RVA: 0x0025C0F1 File Offset: 0x0025A2F1
		// (set) Token: 0x060198A9 RID: 104617 RVA: 0x0025C10A File Offset: 0x0025A30A
		public unsafe bool bOverride_WindDynamic
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_WindDynamic) & FKuroCloudLayerSetting.__PropertyMask_bOverride_WindDynamic) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_WindDynamic) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_WindDynamic) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_WindDynamic) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_WindDynamic : 0));
			}
		}

		// Token: 0x170065F8 RID: 26104
		// (get) Token: 0x060198AA RID: 104618 RVA: 0x0025C13A File Offset: 0x0025A33A
		// (set) Token: 0x060198AB RID: 104619 RVA: 0x0025C153 File Offset: 0x0025A353
		public unsafe bool bOverride_WindDispersing
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_WindDispersing) & FKuroCloudLayerSetting.__PropertyMask_bOverride_WindDispersing) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_WindDispersing) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_WindDispersing) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_WindDispersing) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_WindDispersing : 0));
			}
		}

		// Token: 0x170065F9 RID: 26105
		// (get) Token: 0x060198AC RID: 104620 RVA: 0x0025C183 File Offset: 0x0025A383
		// (set) Token: 0x060198AD RID: 104621 RVA: 0x0025C19C File Offset: 0x0025A39C
		public unsafe bool bOverride_SecondLayerAlpha
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_SecondLayerAlpha) & FKuroCloudLayerSetting.__PropertyMask_bOverride_SecondLayerAlpha) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_SecondLayerAlpha) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_SecondLayerAlpha) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_SecondLayerAlpha) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_SecondLayerAlpha : 0));
			}
		}

		// Token: 0x170065FA RID: 26106
		// (get) Token: 0x060198AE RID: 104622 RVA: 0x0025C1CC File Offset: 0x0025A3CC
		// (set) Token: 0x060198AF RID: 104623 RVA: 0x0025C1E5 File Offset: 0x0025A3E5
		public unsafe bool bOverride_SecondLayerColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_SecondLayerColor) & FKuroCloudLayerSetting.__PropertyMask_bOverride_SecondLayerColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_SecondLayerColor) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_SecondLayerColor) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_SecondLayerColor) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_SecondLayerColor : 0));
			}
		}

		// Token: 0x170065FB RID: 26107
		// (get) Token: 0x060198B0 RID: 104624 RVA: 0x0025C215 File Offset: 0x0025A415
		// (set) Token: 0x060198B1 RID: 104625 RVA: 0x0025C22E File Offset: 0x0025A42E
		public unsafe bool bOverride_SecondLayerScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_SecondLayerScale) & FKuroCloudLayerSetting.__PropertyMask_bOverride_SecondLayerScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_SecondLayerScale) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_SecondLayerScale) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_SecondLayerScale) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_SecondLayerScale : 0));
			}
		}

		// Token: 0x170065FC RID: 26108
		// (get) Token: 0x060198B2 RID: 104626 RVA: 0x0025C25E File Offset: 0x0025A45E
		// (set) Token: 0x060198B3 RID: 104627 RVA: 0x0025C277 File Offset: 0x0025A477
		public unsafe bool bOverride_SecondLayerHardness
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_SecondLayerHardness) & FKuroCloudLayerSetting.__PropertyMask_bOverride_SecondLayerHardness) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_SecondLayerHardness) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_SecondLayerHardness) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_SecondLayerHardness) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_SecondLayerHardness : 0));
			}
		}

		// Token: 0x170065FD RID: 26109
		// (get) Token: 0x060198B4 RID: 104628 RVA: 0x0025C2A7 File Offset: 0x0025A4A7
		// (set) Token: 0x060198B5 RID: 104629 RVA: 0x0025C2C0 File Offset: 0x0025A4C0
		public unsafe bool bOverride_SecondLayerWind
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_SecondLayerWind) & FKuroCloudLayerSetting.__PropertyMask_bOverride_SecondLayerWind) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_SecondLayerWind) = ((*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_bOverride_SecondLayerWind) & ~FKuroCloudLayerSetting.__PropertyMask_bOverride_SecondLayerWind) | (value ? FKuroCloudLayerSetting.__PropertyMask_bOverride_SecondLayerWind : 0));
			}
		}

		// Token: 0x170065FE RID: 26110
		// (get) Token: 0x060198B6 RID: 104630 RVA: 0x0025C2F0 File Offset: 0x0025A4F0
		// (set) Token: 0x060198B7 RID: 104631 RVA: 0x0025C300 File Offset: 0x0025A500
		public unsafe float CloudsDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsDensity) = value;
			}
		}

		// Token: 0x170065FF RID: 26111
		// (get) Token: 0x060198B8 RID: 104632 RVA: 0x0025C311 File Offset: 0x0025A511
		// (set) Token: 0x060198B9 RID: 104633 RVA: 0x0025C321 File Offset: 0x0025A521
		public unsafe float CloudsBlend
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsBlend);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsBlend) = value;
			}
		}

		// Token: 0x17006600 RID: 26112
		// (get) Token: 0x060198BA RID: 104634 RVA: 0x0025C332 File Offset: 0x0025A532
		// (set) Token: 0x060198BB RID: 104635 RVA: 0x0025C342 File Offset: 0x0025A542
		public unsafe float CloudsBloom
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsBloom);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsBloom) = value;
			}
		}

		// Token: 0x17006601 RID: 26113
		// (get) Token: 0x060198BC RID: 104636 RVA: 0x0025C353 File Offset: 0x0025A553
		// (set) Token: 0x060198BD RID: 104637 RVA: 0x0025C363 File Offset: 0x0025A563
		public unsafe float UVScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_UVScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_UVScale) = value;
			}
		}

		// Token: 0x17006602 RID: 26114
		// (get) Token: 0x060198BE RID: 104638 RVA: 0x0025C374 File Offset: 0x0025A574
		// (set) Token: 0x060198BF RID: 104639 RVA: 0x0025C384 File Offset: 0x0025A584
		public unsafe float WindForceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_WindForceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_WindForceScale) = value;
			}
		}

		// Token: 0x17006603 RID: 26115
		// (get) Token: 0x060198C0 RID: 104640 RVA: 0x0025C395 File Offset: 0x0025A595
		// (set) Token: 0x060198C1 RID: 104641 RVA: 0x0025C3A9 File Offset: 0x0025A5A9
		public unsafe FVector4 BaseLayerSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_BaseLayerSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_BaseLayerSize) = value;
			}
		}

		// Token: 0x17006604 RID: 26116
		// (get) Token: 0x060198C2 RID: 104642 RVA: 0x0025C3BE File Offset: 0x0025A5BE
		// (set) Token: 0x060198C3 RID: 104643 RVA: 0x0025C3D2 File Offset: 0x0025A5D2
		public unsafe FVector4 SecondLayerSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_SecondLayerSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_SecondLayerSize) = value;
			}
		}

		// Token: 0x17006605 RID: 26117
		// (get) Token: 0x060198C4 RID: 104644 RVA: 0x0025C3E7 File Offset: 0x0025A5E7
		// (set) Token: 0x060198C5 RID: 104645 RVA: 0x0025C3FB File Offset: 0x0025A5FB
		public unsafe UTexture2D CloudLayer1
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCloudLayerSetting.__PropertyOffset_CloudLayer1);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCloudLayerSetting.__PropertyOffset_CloudLayer1, value);
			}
		}

		// Token: 0x17006606 RID: 26118
		// (get) Token: 0x060198C6 RID: 104646 RVA: 0x0025C410 File Offset: 0x0025A610
		// (set) Token: 0x060198C7 RID: 104647 RVA: 0x0025C424 File Offset: 0x0025A624
		public unsafe UTexture2D CloudLayer2
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture2D>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCloudLayerSetting.__PropertyOffset_CloudLayer2);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroCloudLayerSetting.__PropertyOffset_CloudLayer2, value);
			}
		}

		// Token: 0x17006607 RID: 26119
		// (get) Token: 0x060198C8 RID: 104648 RVA: 0x0025C439 File Offset: 0x0025A639
		// (set) Token: 0x060198C9 RID: 104649 RVA: 0x0025C449 File Offset: 0x0025A649
		public unsafe float CloudsHardness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsHardness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsHardness) = value;
			}
		}

		// Token: 0x17006608 RID: 26120
		// (get) Token: 0x060198CA RID: 104650 RVA: 0x0025C45A File Offset: 0x0025A65A
		// (set) Token: 0x060198CB RID: 104651 RVA: 0x0025C46A File Offset: 0x0025A66A
		public unsafe float CloudsTranslucent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsTranslucent);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsTranslucent) = value;
			}
		}

		// Token: 0x17006609 RID: 26121
		// (get) Token: 0x060198CC RID: 104652 RVA: 0x0025C47B File Offset: 0x0025A67B
		// (set) Token: 0x060198CD RID: 104653 RVA: 0x0025C48B File Offset: 0x0025A68B
		public unsafe float CloudsVertexDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsVertexDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsVertexDensity) = value;
			}
		}

		// Token: 0x1700660A RID: 26122
		// (get) Token: 0x060198CE RID: 104654 RVA: 0x0025C49C File Offset: 0x0025A69C
		// (set) Token: 0x060198CF RID: 104655 RVA: 0x0025C4AC File Offset: 0x0025A6AC
		public unsafe float CloudsFluffy
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsFluffy);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsFluffy) = value;
			}
		}

		// Token: 0x1700660B RID: 26123
		// (get) Token: 0x060198D0 RID: 104656 RVA: 0x0025C4BD File Offset: 0x0025A6BD
		// (set) Token: 0x060198D1 RID: 104657 RVA: 0x0025C4CD File Offset: 0x0025A6CD
		public unsafe float CloudsDistotion
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsDistotion);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsDistotion) = value;
			}
		}

		// Token: 0x1700660C RID: 26124
		// (get) Token: 0x060198D2 RID: 104658 RVA: 0x0025C4DE File Offset: 0x0025A6DE
		// (set) Token: 0x060198D3 RID: 104659 RVA: 0x0025C4EE File Offset: 0x0025A6EE
		public unsafe float CloudsScattering
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsScattering);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsScattering) = value;
			}
		}

		// Token: 0x1700660D RID: 26125
		// (get) Token: 0x060198D4 RID: 104660 RVA: 0x0025C4FF File Offset: 0x0025A6FF
		// (set) Token: 0x060198D5 RID: 104661 RVA: 0x0025C50F File Offset: 0x0025A70F
		public unsafe float CloudsAmbient
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsAmbient);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsAmbient) = value;
			}
		}

		// Token: 0x1700660E RID: 26126
		// (get) Token: 0x060198D6 RID: 104662 RVA: 0x0025C520 File Offset: 0x0025A720
		// (set) Token: 0x060198D7 RID: 104663 RVA: 0x0025C530 File Offset: 0x0025A730
		public unsafe float CloudsShadowSize
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsShadowSize);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsShadowSize) = value;
			}
		}

		// Token: 0x1700660F RID: 26127
		// (get) Token: 0x060198D8 RID: 104664 RVA: 0x0025C541 File Offset: 0x0025A741
		// (set) Token: 0x060198D9 RID: 104665 RVA: 0x0025C551 File Offset: 0x0025A751
		public unsafe float CloudsShadowSoft
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsShadowSoft);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsShadowSoft) = value;
			}
		}

		// Token: 0x17006610 RID: 26128
		// (get) Token: 0x060198DA RID: 104666 RVA: 0x0025C562 File Offset: 0x0025A762
		// (set) Token: 0x060198DB RID: 104667 RVA: 0x0025C572 File Offset: 0x0025A772
		public unsafe float CloudsUpperBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsUpperBrightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsUpperBrightness) = value;
			}
		}

		// Token: 0x17006611 RID: 26129
		// (get) Token: 0x060198DC RID: 104668 RVA: 0x0025C583 File Offset: 0x0025A783
		// (set) Token: 0x060198DD RID: 104669 RVA: 0x0025C593 File Offset: 0x0025A793
		public unsafe float CloudsLowerBrightness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsLowerBrightness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsLowerBrightness) = value;
			}
		}

		// Token: 0x17006612 RID: 26130
		// (get) Token: 0x060198DE RID: 104670 RVA: 0x0025C5A4 File Offset: 0x0025A7A4
		// (set) Token: 0x060198DF RID: 104671 RVA: 0x0025C5B8 File Offset: 0x0025A7B8
		public unsafe FLinearColor CloudsUpperColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsUpperColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsUpperColor) = value;
			}
		}

		// Token: 0x17006613 RID: 26131
		// (get) Token: 0x060198E0 RID: 104672 RVA: 0x0025C5CD File Offset: 0x0025A7CD
		// (set) Token: 0x060198E1 RID: 104673 RVA: 0x0025C5E1 File Offset: 0x0025A7E1
		public unsafe FLinearColor CloudsLowerColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsLowerColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsLowerColor) = value;
			}
		}

		// Token: 0x17006614 RID: 26132
		// (get) Token: 0x060198E2 RID: 104674 RVA: 0x0025C5F6 File Offset: 0x0025A7F6
		// (set) Token: 0x060198E3 RID: 104675 RVA: 0x0025C60A File Offset: 0x0025A80A
		public unsafe FLinearColor CloudsBackgroundColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsBackgroundColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsBackgroundColor) = value;
			}
		}

		// Token: 0x17006615 RID: 26133
		// (get) Token: 0x060198E4 RID: 104676 RVA: 0x0025C61F File Offset: 0x0025A81F
		// (set) Token: 0x060198E5 RID: 104677 RVA: 0x0025C62F File Offset: 0x0025A82F
		public unsafe float CloudsBackground
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsBackground);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsBackground) = value;
			}
		}

		// Token: 0x17006616 RID: 26134
		// (get) Token: 0x060198E6 RID: 104678 RVA: 0x0025C640 File Offset: 0x0025A840
		// (set) Token: 0x060198E7 RID: 104679 RVA: 0x0025C650 File Offset: 0x0025A850
		public unsafe float CloudsHorizonAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsHorizonAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_CloudsHorizonAlpha) = value;
			}
		}

		// Token: 0x17006617 RID: 26135
		// (get) Token: 0x060198E8 RID: 104680 RVA: 0x0025C661 File Offset: 0x0025A861
		// (set) Token: 0x060198E9 RID: 104681 RVA: 0x0025C671 File Offset: 0x0025A871
		public unsafe float WindDynamic
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_WindDynamic);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_WindDynamic) = value;
			}
		}

		// Token: 0x17006618 RID: 26136
		// (get) Token: 0x060198EA RID: 104682 RVA: 0x0025C682 File Offset: 0x0025A882
		// (set) Token: 0x060198EB RID: 104683 RVA: 0x0025C692 File Offset: 0x0025A892
		public unsafe float WindDispersing
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_WindDispersing);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_WindDispersing) = value;
			}
		}

		// Token: 0x17006619 RID: 26137
		// (get) Token: 0x060198EC RID: 104684 RVA: 0x0025C6A3 File Offset: 0x0025A8A3
		// (set) Token: 0x060198ED RID: 104685 RVA: 0x0025C6B3 File Offset: 0x0025A8B3
		public unsafe float SecondLayerAlpha
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_SecondLayerAlpha);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_SecondLayerAlpha) = value;
			}
		}

		// Token: 0x1700661A RID: 26138
		// (get) Token: 0x060198EE RID: 104686 RVA: 0x0025C6C4 File Offset: 0x0025A8C4
		// (set) Token: 0x060198EF RID: 104687 RVA: 0x0025C6D4 File Offset: 0x0025A8D4
		public unsafe float SecondLayerColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_SecondLayerColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_SecondLayerColor) = value;
			}
		}

		// Token: 0x1700661B RID: 26139
		// (get) Token: 0x060198F0 RID: 104688 RVA: 0x0025C6E5 File Offset: 0x0025A8E5
		// (set) Token: 0x060198F1 RID: 104689 RVA: 0x0025C6F5 File Offset: 0x0025A8F5
		public unsafe float SecondLayerScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_SecondLayerScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_SecondLayerScale) = value;
			}
		}

		// Token: 0x1700661C RID: 26140
		// (get) Token: 0x060198F2 RID: 104690 RVA: 0x0025C706 File Offset: 0x0025A906
		// (set) Token: 0x060198F3 RID: 104691 RVA: 0x0025C716 File Offset: 0x0025A916
		public unsafe float SecondLayerHardness
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_SecondLayerHardness);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_SecondLayerHardness) = value;
			}
		}

		// Token: 0x1700661D RID: 26141
		// (get) Token: 0x060198F4 RID: 104692 RVA: 0x0025C727 File Offset: 0x0025A927
		// (set) Token: 0x060198F5 RID: 104693 RVA: 0x0025C737 File Offset: 0x0025A937
		public unsafe float SecondLayerWind
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_SecondLayerWind);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroCloudLayerSetting.__PropertyOffset_SecondLayerWind) = value;
			}
		}

		// Token: 0x060198F6 RID: 104694 RVA: 0x0025C748 File Offset: 0x0025A948
		public FKuroCloudLayerSetting()
		{
		}

		// Token: 0x060198F7 RID: 104695 RVA: 0x0025C750 File Offset: 0x0025A950
		[NullableContext(1)]
		public FKuroCloudLayerSetting(bool bOverride_CloudsDensity, bool bOverride_CloudsBlend, bool bOverride_CloudsBloom, bool bOverride_UVScale, bool bOverride_WindForceScale, bool bOverride_BaseLayerSize, bool bOverride_SecondLayerSize, bool bOverride_CloudLayer1, bool bOverride_CloudLayer2, bool bOverride_CloudsHardness, bool bOverride_CloudsTranslucent, bool bOverride_CloudsVertexDensity, bool bOverride_CloudsFluffy, bool bOverride_CloudsDistotion, bool bOverride_CloudsScattering, bool bOverride_CloudsAmbient, bool bOverride_CloudsShadowSize, bool bOverride_CloudsShadowSoft, bool bOverride_CloudsUpperBrightness, bool bOverride_CloudsLowerBrightness, bool bOverride_CloudsUpperColor, bool bOverride_CloudsLowerColor, bool bOverride_CloudsBackgroundColor, bool bOverride_CloudsBackground, bool bOverride_CloudsHorizonAlpha, bool bOverride_WindDynamic, bool bOverride_WindDispersing, bool bOverride_SecondLayerAlpha, bool bOverride_SecondLayerColor, bool bOverride_SecondLayerScale, bool bOverride_SecondLayerHardness, bool bOverride_SecondLayerWind, float CloudsDensity, float CloudsBlend, float CloudsBloom, float UVScale, float WindForceScale, FVector4 BaseLayerSize, FVector4 SecondLayerSize, UTexture2D CloudLayer1, UTexture2D CloudLayer2, float CloudsHardness, float CloudsTranslucent, float CloudsVertexDensity, float CloudsFluffy, float CloudsDistotion, float CloudsScattering, float CloudsAmbient, float CloudsShadowSize, float CloudsShadowSoft, float CloudsUpperBrightness, float CloudsLowerBrightness, FLinearColor CloudsUpperColor, FLinearColor CloudsLowerColor, FLinearColor CloudsBackgroundColor, float CloudsBackground, float CloudsHorizonAlpha, float WindDynamic, float WindDispersing, float SecondLayerAlpha, float SecondLayerColor, float SecondLayerScale, float SecondLayerHardness, float SecondLayerWind)
		{
			this.bOverride_CloudsDensity = bOverride_CloudsDensity;
			this.bOverride_CloudsBlend = bOverride_CloudsBlend;
			this.bOverride_CloudsBloom = bOverride_CloudsBloom;
			this.bOverride_UVScale = bOverride_UVScale;
			this.bOverride_WindForceScale = bOverride_WindForceScale;
			this.bOverride_BaseLayerSize = bOverride_BaseLayerSize;
			this.bOverride_SecondLayerSize = bOverride_SecondLayerSize;
			this.bOverride_CloudLayer1 = bOverride_CloudLayer1;
			this.bOverride_CloudLayer2 = bOverride_CloudLayer2;
			this.bOverride_CloudsHardness = bOverride_CloudsHardness;
			this.bOverride_CloudsTranslucent = bOverride_CloudsTranslucent;
			this.bOverride_CloudsVertexDensity = bOverride_CloudsVertexDensity;
			this.bOverride_CloudsFluffy = bOverride_CloudsFluffy;
			this.bOverride_CloudsDistotion = bOverride_CloudsDistotion;
			this.bOverride_CloudsScattering = bOverride_CloudsScattering;
			this.bOverride_CloudsAmbient = bOverride_CloudsAmbient;
			this.bOverride_CloudsShadowSize = bOverride_CloudsShadowSize;
			this.bOverride_CloudsShadowSoft = bOverride_CloudsShadowSoft;
			this.bOverride_CloudsUpperBrightness = bOverride_CloudsUpperBrightness;
			this.bOverride_CloudsLowerBrightness = bOverride_CloudsLowerBrightness;
			this.bOverride_CloudsUpperColor = bOverride_CloudsUpperColor;
			this.bOverride_CloudsLowerColor = bOverride_CloudsLowerColor;
			this.bOverride_CloudsBackgroundColor = bOverride_CloudsBackgroundColor;
			this.bOverride_CloudsBackground = bOverride_CloudsBackground;
			this.bOverride_CloudsHorizonAlpha = bOverride_CloudsHorizonAlpha;
			this.bOverride_WindDynamic = bOverride_WindDynamic;
			this.bOverride_WindDispersing = bOverride_WindDispersing;
			this.bOverride_SecondLayerAlpha = bOverride_SecondLayerAlpha;
			this.bOverride_SecondLayerColor = bOverride_SecondLayerColor;
			this.bOverride_SecondLayerScale = bOverride_SecondLayerScale;
			this.bOverride_SecondLayerHardness = bOverride_SecondLayerHardness;
			this.bOverride_SecondLayerWind = bOverride_SecondLayerWind;
			this.CloudsDensity = CloudsDensity;
			this.CloudsBlend = CloudsBlend;
			this.CloudsBloom = CloudsBloom;
			this.UVScale = UVScale;
			this.WindForceScale = WindForceScale;
			this.BaseLayerSize = BaseLayerSize;
			this.SecondLayerSize = SecondLayerSize;
			this.CloudLayer1 = CloudLayer1;
			this.CloudLayer2 = CloudLayer2;
			this.CloudsHardness = CloudsHardness;
			this.CloudsTranslucent = CloudsTranslucent;
			this.CloudsVertexDensity = CloudsVertexDensity;
			this.CloudsFluffy = CloudsFluffy;
			this.CloudsDistotion = CloudsDistotion;
			this.CloudsScattering = CloudsScattering;
			this.CloudsAmbient = CloudsAmbient;
			this.CloudsShadowSize = CloudsShadowSize;
			this.CloudsShadowSoft = CloudsShadowSoft;
			this.CloudsUpperBrightness = CloudsUpperBrightness;
			this.CloudsLowerBrightness = CloudsLowerBrightness;
			this.CloudsUpperColor = CloudsUpperColor;
			this.CloudsLowerColor = CloudsLowerColor;
			this.CloudsBackgroundColor = CloudsBackgroundColor;
			this.CloudsBackground = CloudsBackground;
			this.CloudsHorizonAlpha = CloudsHorizonAlpha;
			this.WindDynamic = WindDynamic;
			this.WindDispersing = WindDispersing;
			this.SecondLayerAlpha = SecondLayerAlpha;
			this.SecondLayerColor = SecondLayerColor;
			this.SecondLayerScale = SecondLayerScale;
			this.SecondLayerHardness = SecondLayerHardness;
			this.SecondLayerWind = SecondLayerWind;
		}

		// Token: 0x060198F8 RID: 104696 RVA: 0x0025C960 File Offset: 0x0025AB60
		protected override IntPtr GetUStructPtr()
		{
			return FKuroCloudLayerSetting.StaticStruct();
		}

		// Token: 0x060198F9 RID: 104697 RVA: 0x0025C96C File Offset: 0x0025AB6C
		public FKuroCloudLayerSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060198FA RID: 104698 RVA: 0x0025C976 File Offset: 0x0025AB76
		public FKuroCloudLayerSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060198FB RID: 104699 RVA: 0x0025C981 File Offset: 0x0025AB81
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroCloudLayerSetting(Pointer, false, true);
		}

		// Token: 0x060198FC RID: 104700 RVA: 0x0025C98B File Offset: 0x0025AB8B
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroCloudLayerSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400DE54 RID: 56916
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroCloudLayerSetting";

		// Token: 0x0400DE55 RID: 56917
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400DE56 RID: 56918
		internal static int __PropertyOffset_bOverride_CloudsDensity;

		// Token: 0x0400DE57 RID: 56919
		internal static byte __PropertyMask_bOverride_CloudsDensity;

		// Token: 0x0400DE58 RID: 56920
		internal static int __PropertyOffset_bOverride_CloudsBlend;

		// Token: 0x0400DE59 RID: 56921
		internal static byte __PropertyMask_bOverride_CloudsBlend;

		// Token: 0x0400DE5A RID: 56922
		internal static int __PropertyOffset_bOverride_CloudsBloom;

		// Token: 0x0400DE5B RID: 56923
		internal static byte __PropertyMask_bOverride_CloudsBloom;

		// Token: 0x0400DE5C RID: 56924
		internal static int __PropertyOffset_bOverride_UVScale;

		// Token: 0x0400DE5D RID: 56925
		internal static byte __PropertyMask_bOverride_UVScale;

		// Token: 0x0400DE5E RID: 56926
		internal static int __PropertyOffset_bOverride_WindForceScale;

		// Token: 0x0400DE5F RID: 56927
		internal static byte __PropertyMask_bOverride_WindForceScale;

		// Token: 0x0400DE60 RID: 56928
		internal static int __PropertyOffset_bOverride_BaseLayerSize;

		// Token: 0x0400DE61 RID: 56929
		internal static byte __PropertyMask_bOverride_BaseLayerSize;

		// Token: 0x0400DE62 RID: 56930
		internal static int __PropertyOffset_bOverride_SecondLayerSize;

		// Token: 0x0400DE63 RID: 56931
		internal static byte __PropertyMask_bOverride_SecondLayerSize;

		// Token: 0x0400DE64 RID: 56932
		internal static int __PropertyOffset_bOverride_CloudLayer1;

		// Token: 0x0400DE65 RID: 56933
		internal static byte __PropertyMask_bOverride_CloudLayer1;

		// Token: 0x0400DE66 RID: 56934
		internal static int __PropertyOffset_bOverride_CloudLayer2;

		// Token: 0x0400DE67 RID: 56935
		internal static byte __PropertyMask_bOverride_CloudLayer2;

		// Token: 0x0400DE68 RID: 56936
		internal static int __PropertyOffset_bOverride_CloudsHardness;

		// Token: 0x0400DE69 RID: 56937
		internal static byte __PropertyMask_bOverride_CloudsHardness;

		// Token: 0x0400DE6A RID: 56938
		internal static int __PropertyOffset_bOverride_CloudsTranslucent;

		// Token: 0x0400DE6B RID: 56939
		internal static byte __PropertyMask_bOverride_CloudsTranslucent;

		// Token: 0x0400DE6C RID: 56940
		internal static int __PropertyOffset_bOverride_CloudsVertexDensity;

		// Token: 0x0400DE6D RID: 56941
		internal static byte __PropertyMask_bOverride_CloudsVertexDensity;

		// Token: 0x0400DE6E RID: 56942
		internal static int __PropertyOffset_bOverride_CloudsFluffy;

		// Token: 0x0400DE6F RID: 56943
		internal static byte __PropertyMask_bOverride_CloudsFluffy;

		// Token: 0x0400DE70 RID: 56944
		internal static int __PropertyOffset_bOverride_CloudsDistotion;

		// Token: 0x0400DE71 RID: 56945
		internal static byte __PropertyMask_bOverride_CloudsDistotion;

		// Token: 0x0400DE72 RID: 56946
		internal static int __PropertyOffset_bOverride_CloudsScattering;

		// Token: 0x0400DE73 RID: 56947
		internal static byte __PropertyMask_bOverride_CloudsScattering;

		// Token: 0x0400DE74 RID: 56948
		internal static int __PropertyOffset_bOverride_CloudsAmbient;

		// Token: 0x0400DE75 RID: 56949
		internal static byte __PropertyMask_bOverride_CloudsAmbient;

		// Token: 0x0400DE76 RID: 56950
		internal static int __PropertyOffset_bOverride_CloudsShadowSize;

		// Token: 0x0400DE77 RID: 56951
		internal static byte __PropertyMask_bOverride_CloudsShadowSize;

		// Token: 0x0400DE78 RID: 56952
		internal static int __PropertyOffset_bOverride_CloudsShadowSoft;

		// Token: 0x0400DE79 RID: 56953
		internal static byte __PropertyMask_bOverride_CloudsShadowSoft;

		// Token: 0x0400DE7A RID: 56954
		internal static int __PropertyOffset_bOverride_CloudsUpperBrightness;

		// Token: 0x0400DE7B RID: 56955
		internal static byte __PropertyMask_bOverride_CloudsUpperBrightness;

		// Token: 0x0400DE7C RID: 56956
		internal static int __PropertyOffset_bOverride_CloudsLowerBrightness;

		// Token: 0x0400DE7D RID: 56957
		internal static byte __PropertyMask_bOverride_CloudsLowerBrightness;

		// Token: 0x0400DE7E RID: 56958
		internal static int __PropertyOffset_bOverride_CloudsUpperColor;

		// Token: 0x0400DE7F RID: 56959
		internal static byte __PropertyMask_bOverride_CloudsUpperColor;

		// Token: 0x0400DE80 RID: 56960
		internal static int __PropertyOffset_bOverride_CloudsLowerColor;

		// Token: 0x0400DE81 RID: 56961
		internal static byte __PropertyMask_bOverride_CloudsLowerColor;

		// Token: 0x0400DE82 RID: 56962
		internal static int __PropertyOffset_bOverride_CloudsBackgroundColor;

		// Token: 0x0400DE83 RID: 56963
		internal static byte __PropertyMask_bOverride_CloudsBackgroundColor;

		// Token: 0x0400DE84 RID: 56964
		internal static int __PropertyOffset_bOverride_CloudsBackground;

		// Token: 0x0400DE85 RID: 56965
		internal static byte __PropertyMask_bOverride_CloudsBackground;

		// Token: 0x0400DE86 RID: 56966
		internal static int __PropertyOffset_bOverride_CloudsHorizonAlpha;

		// Token: 0x0400DE87 RID: 56967
		internal static byte __PropertyMask_bOverride_CloudsHorizonAlpha;

		// Token: 0x0400DE88 RID: 56968
		internal static int __PropertyOffset_bOverride_WindDynamic;

		// Token: 0x0400DE89 RID: 56969
		internal static byte __PropertyMask_bOverride_WindDynamic;

		// Token: 0x0400DE8A RID: 56970
		internal static int __PropertyOffset_bOverride_WindDispersing;

		// Token: 0x0400DE8B RID: 56971
		internal static byte __PropertyMask_bOverride_WindDispersing;

		// Token: 0x0400DE8C RID: 56972
		internal static int __PropertyOffset_bOverride_SecondLayerAlpha;

		// Token: 0x0400DE8D RID: 56973
		internal static byte __PropertyMask_bOverride_SecondLayerAlpha;

		// Token: 0x0400DE8E RID: 56974
		internal static int __PropertyOffset_bOverride_SecondLayerColor;

		// Token: 0x0400DE8F RID: 56975
		internal static byte __PropertyMask_bOverride_SecondLayerColor;

		// Token: 0x0400DE90 RID: 56976
		internal static int __PropertyOffset_bOverride_SecondLayerScale;

		// Token: 0x0400DE91 RID: 56977
		internal static byte __PropertyMask_bOverride_SecondLayerScale;

		// Token: 0x0400DE92 RID: 56978
		internal static int __PropertyOffset_bOverride_SecondLayerHardness;

		// Token: 0x0400DE93 RID: 56979
		internal static byte __PropertyMask_bOverride_SecondLayerHardness;

		// Token: 0x0400DE94 RID: 56980
		internal static int __PropertyOffset_bOverride_SecondLayerWind;

		// Token: 0x0400DE95 RID: 56981
		internal static byte __PropertyMask_bOverride_SecondLayerWind;

		// Token: 0x0400DE96 RID: 56982
		internal static int __PropertyOffset_CloudsDensity;

		// Token: 0x0400DE97 RID: 56983
		internal static int __PropertyOffset_CloudsBlend;

		// Token: 0x0400DE98 RID: 56984
		internal static int __PropertyOffset_CloudsBloom;

		// Token: 0x0400DE99 RID: 56985
		internal static int __PropertyOffset_UVScale;

		// Token: 0x0400DE9A RID: 56986
		internal static int __PropertyOffset_WindForceScale;

		// Token: 0x0400DE9B RID: 56987
		internal static int __PropertyOffset_BaseLayerSize;

		// Token: 0x0400DE9C RID: 56988
		internal static int __PropertyOffset_SecondLayerSize;

		// Token: 0x0400DE9D RID: 56989
		internal static int __PropertyOffset_CloudLayer1;

		// Token: 0x0400DE9E RID: 56990
		internal static int __PropertyOffset_CloudLayer2;

		// Token: 0x0400DE9F RID: 56991
		internal static int __PropertyOffset_CloudsHardness;

		// Token: 0x0400DEA0 RID: 56992
		internal static int __PropertyOffset_CloudsTranslucent;

		// Token: 0x0400DEA1 RID: 56993
		internal static int __PropertyOffset_CloudsVertexDensity;

		// Token: 0x0400DEA2 RID: 56994
		internal static int __PropertyOffset_CloudsFluffy;

		// Token: 0x0400DEA3 RID: 56995
		internal static int __PropertyOffset_CloudsDistotion;

		// Token: 0x0400DEA4 RID: 56996
		internal static int __PropertyOffset_CloudsScattering;

		// Token: 0x0400DEA5 RID: 56997
		internal static int __PropertyOffset_CloudsAmbient;

		// Token: 0x0400DEA6 RID: 56998
		internal static int __PropertyOffset_CloudsShadowSize;

		// Token: 0x0400DEA7 RID: 56999
		internal static int __PropertyOffset_CloudsShadowSoft;

		// Token: 0x0400DEA8 RID: 57000
		internal static int __PropertyOffset_CloudsUpperBrightness;

		// Token: 0x0400DEA9 RID: 57001
		internal static int __PropertyOffset_CloudsLowerBrightness;

		// Token: 0x0400DEAA RID: 57002
		internal static int __PropertyOffset_CloudsUpperColor;

		// Token: 0x0400DEAB RID: 57003
		internal static int __PropertyOffset_CloudsLowerColor;

		// Token: 0x0400DEAC RID: 57004
		internal static int __PropertyOffset_CloudsBackgroundColor;

		// Token: 0x0400DEAD RID: 57005
		internal static int __PropertyOffset_CloudsBackground;

		// Token: 0x0400DEAE RID: 57006
		internal static int __PropertyOffset_CloudsHorizonAlpha;

		// Token: 0x0400DEAF RID: 57007
		internal static int __PropertyOffset_WindDynamic;

		// Token: 0x0400DEB0 RID: 57008
		internal static int __PropertyOffset_WindDispersing;

		// Token: 0x0400DEB1 RID: 57009
		internal static int __PropertyOffset_SecondLayerAlpha;

		// Token: 0x0400DEB2 RID: 57010
		internal static int __PropertyOffset_SecondLayerColor;

		// Token: 0x0400DEB3 RID: 57011
		internal static int __PropertyOffset_SecondLayerScale;

		// Token: 0x0400DEB4 RID: 57012
		internal static int __PropertyOffset_SecondLayerHardness;

		// Token: 0x0400DEB5 RID: 57013
		internal static int __PropertyOffset_SecondLayerWind;
	}
}
