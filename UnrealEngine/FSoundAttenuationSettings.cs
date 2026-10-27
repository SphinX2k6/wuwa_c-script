using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001124 RID: 4388
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Engine.SoundAttenuationSettings")]
	[UnrealStructLayout(968, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 968)]
	public class FSoundAttenuationSettings : FBaseAttenuationSettings, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06010051 RID: 65617 RVA: 0x00179662 File Offset: 0x00177862
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSoundAttenuationSettings._ScriptStructPtr != 0) ? FSoundAttenuationSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.SoundAttenuationSettings", ref FSoundAttenuationSettings._ScriptStructPtr);
		}

		// Token: 0x17003E85 RID: 16005
		// (get) Token: 0x06010052 RID: 65618 RVA: 0x00179686 File Offset: 0x00177886
		// (set) Token: 0x06010053 RID: 65619 RVA: 0x0017969F File Offset: 0x0017789F
		public unsafe bool bAttenuate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bAttenuate) & FSoundAttenuationSettings.__PropertyMask_bAttenuate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bAttenuate) = ((*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bAttenuate) & ~FSoundAttenuationSettings.__PropertyMask_bAttenuate) | (value ? FSoundAttenuationSettings.__PropertyMask_bAttenuate : 0));
			}
		}

		// Token: 0x17003E86 RID: 16006
		// (get) Token: 0x06010054 RID: 65620 RVA: 0x001796CF File Offset: 0x001778CF
		// (set) Token: 0x06010055 RID: 65621 RVA: 0x001796E8 File Offset: 0x001778E8
		public unsafe bool bSpatialize
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bSpatialize) & FSoundAttenuationSettings.__PropertyMask_bSpatialize) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bSpatialize) = ((*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bSpatialize) & ~FSoundAttenuationSettings.__PropertyMask_bSpatialize) | (value ? FSoundAttenuationSettings.__PropertyMask_bSpatialize : 0));
			}
		}

		// Token: 0x17003E87 RID: 16007
		// (get) Token: 0x06010056 RID: 65622 RVA: 0x00179718 File Offset: 0x00177918
		// (set) Token: 0x06010057 RID: 65623 RVA: 0x00179731 File Offset: 0x00177931
		public unsafe bool bAttenuateWithLPF
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bAttenuateWithLPF) & FSoundAttenuationSettings.__PropertyMask_bAttenuateWithLPF) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bAttenuateWithLPF) = ((*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bAttenuateWithLPF) & ~FSoundAttenuationSettings.__PropertyMask_bAttenuateWithLPF) | (value ? FSoundAttenuationSettings.__PropertyMask_bAttenuateWithLPF : 0));
			}
		}

		// Token: 0x17003E88 RID: 16008
		// (get) Token: 0x06010058 RID: 65624 RVA: 0x00179761 File Offset: 0x00177961
		// (set) Token: 0x06010059 RID: 65625 RVA: 0x0017977A File Offset: 0x0017797A
		public unsafe bool bEnableListenerFocus
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bEnableListenerFocus) & FSoundAttenuationSettings.__PropertyMask_bEnableListenerFocus) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bEnableListenerFocus) = ((*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bEnableListenerFocus) & ~FSoundAttenuationSettings.__PropertyMask_bEnableListenerFocus) | (value ? FSoundAttenuationSettings.__PropertyMask_bEnableListenerFocus : 0));
			}
		}

		// Token: 0x17003E89 RID: 16009
		// (get) Token: 0x0601005A RID: 65626 RVA: 0x001797AA File Offset: 0x001779AA
		// (set) Token: 0x0601005B RID: 65627 RVA: 0x001797C3 File Offset: 0x001779C3
		public unsafe bool bEnableFocusInterpolation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bEnableFocusInterpolation) & FSoundAttenuationSettings.__PropertyMask_bEnableFocusInterpolation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bEnableFocusInterpolation) = ((*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bEnableFocusInterpolation) & ~FSoundAttenuationSettings.__PropertyMask_bEnableFocusInterpolation) | (value ? FSoundAttenuationSettings.__PropertyMask_bEnableFocusInterpolation : 0));
			}
		}

		// Token: 0x17003E8A RID: 16010
		// (get) Token: 0x0601005C RID: 65628 RVA: 0x001797F3 File Offset: 0x001779F3
		// (set) Token: 0x0601005D RID: 65629 RVA: 0x0017980C File Offset: 0x00177A0C
		public unsafe bool bEnableOcclusion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bEnableOcclusion) & FSoundAttenuationSettings.__PropertyMask_bEnableOcclusion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bEnableOcclusion) = ((*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bEnableOcclusion) & ~FSoundAttenuationSettings.__PropertyMask_bEnableOcclusion) | (value ? FSoundAttenuationSettings.__PropertyMask_bEnableOcclusion : 0));
			}
		}

		// Token: 0x17003E8B RID: 16011
		// (get) Token: 0x0601005E RID: 65630 RVA: 0x0017983C File Offset: 0x00177A3C
		// (set) Token: 0x0601005F RID: 65631 RVA: 0x00179855 File Offset: 0x00177A55
		public unsafe bool bUseComplexCollisionForOcclusion
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bUseComplexCollisionForOcclusion) & FSoundAttenuationSettings.__PropertyMask_bUseComplexCollisionForOcclusion) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bUseComplexCollisionForOcclusion) = ((*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bUseComplexCollisionForOcclusion) & ~FSoundAttenuationSettings.__PropertyMask_bUseComplexCollisionForOcclusion) | (value ? FSoundAttenuationSettings.__PropertyMask_bUseComplexCollisionForOcclusion : 0));
			}
		}

		// Token: 0x17003E8C RID: 16012
		// (get) Token: 0x06010060 RID: 65632 RVA: 0x00179885 File Offset: 0x00177A85
		// (set) Token: 0x06010061 RID: 65633 RVA: 0x0017989E File Offset: 0x00177A9E
		public unsafe bool bEnableReverbSend
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bEnableReverbSend) & FSoundAttenuationSettings.__PropertyMask_bEnableReverbSend) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bEnableReverbSend) = ((*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bEnableReverbSend) & ~FSoundAttenuationSettings.__PropertyMask_bEnableReverbSend) | (value ? FSoundAttenuationSettings.__PropertyMask_bEnableReverbSend : 0));
			}
		}

		// Token: 0x17003E8D RID: 16013
		// (get) Token: 0x06010062 RID: 65634 RVA: 0x001798CE File Offset: 0x00177ACE
		// (set) Token: 0x06010063 RID: 65635 RVA: 0x001798E7 File Offset: 0x00177AE7
		public unsafe bool bEnablePriorityAttenuation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bEnablePriorityAttenuation) & FSoundAttenuationSettings.__PropertyMask_bEnablePriorityAttenuation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bEnablePriorityAttenuation) = ((*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bEnablePriorityAttenuation) & ~FSoundAttenuationSettings.__PropertyMask_bEnablePriorityAttenuation) | (value ? FSoundAttenuationSettings.__PropertyMask_bEnablePriorityAttenuation : 0));
			}
		}

		// Token: 0x17003E8E RID: 16014
		// (get) Token: 0x06010064 RID: 65636 RVA: 0x00179917 File Offset: 0x00177B17
		// (set) Token: 0x06010065 RID: 65637 RVA: 0x00179930 File Offset: 0x00177B30
		public unsafe bool bApplyNormalizationToStereoSounds
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bApplyNormalizationToStereoSounds) & FSoundAttenuationSettings.__PropertyMask_bApplyNormalizationToStereoSounds) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bApplyNormalizationToStereoSounds) = ((*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bApplyNormalizationToStereoSounds) & ~FSoundAttenuationSettings.__PropertyMask_bApplyNormalizationToStereoSounds) | (value ? FSoundAttenuationSettings.__PropertyMask_bApplyNormalizationToStereoSounds : 0));
			}
		}

		// Token: 0x17003E8F RID: 16015
		// (get) Token: 0x06010066 RID: 65638 RVA: 0x00179960 File Offset: 0x00177B60
		// (set) Token: 0x06010067 RID: 65639 RVA: 0x00179979 File Offset: 0x00177B79
		public unsafe bool bEnableLogFrequencyScaling
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bEnableLogFrequencyScaling) & FSoundAttenuationSettings.__PropertyMask_bEnableLogFrequencyScaling) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bEnableLogFrequencyScaling) = ((*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bEnableLogFrequencyScaling) & ~FSoundAttenuationSettings.__PropertyMask_bEnableLogFrequencyScaling) | (value ? FSoundAttenuationSettings.__PropertyMask_bEnableLogFrequencyScaling : 0));
			}
		}

		// Token: 0x17003E90 RID: 16016
		// (get) Token: 0x06010068 RID: 65640 RVA: 0x001799A9 File Offset: 0x00177BA9
		// (set) Token: 0x06010069 RID: 65641 RVA: 0x001799C2 File Offset: 0x00177BC2
		public unsafe bool bEnableSubmixSends
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bEnableSubmixSends) & FSoundAttenuationSettings.__PropertyMask_bEnableSubmixSends) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bEnableSubmixSends) = ((*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_bEnableSubmixSends) & ~FSoundAttenuationSettings.__PropertyMask_bEnableSubmixSends) | (value ? FSoundAttenuationSettings.__PropertyMask_bEnableSubmixSends : 0));
			}
		}

		// Token: 0x17003E91 RID: 16017
		// (get) Token: 0x0601006A RID: 65642 RVA: 0x001799F2 File Offset: 0x00177BF2
		// (set) Token: 0x0601006B RID: 65643 RVA: 0x00179A06 File Offset: 0x00177C06
		[Nullable(0)]
		public unsafe TEnumAsByte<ESoundSpatializationAlgorithm> SpatializationAlgorithm
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_SpatializationAlgorithm);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_SpatializationAlgorithm) = value;
			}
		}

		// Token: 0x17003E92 RID: 16018
		// (get) Token: 0x0601006C RID: 65644 RVA: 0x00179A1B File Offset: 0x00177C1B
		// (set) Token: 0x0601006D RID: 65645 RVA: 0x00179A2B File Offset: 0x00177C2B
		public unsafe float BinauralRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_BinauralRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_BinauralRadius) = value;
			}
		}

		// Token: 0x17003E93 RID: 16019
		// (get) Token: 0x0601006E RID: 65646 RVA: 0x00179A3C File Offset: 0x00177C3C
		// (set) Token: 0x0601006F RID: 65647 RVA: 0x00179A4C File Offset: 0x00177C4C
		public unsafe EAirAbsorptionMethod AbsorptionMethod
		{
			get
			{
				return (EAirAbsorptionMethod)(*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_AbsorptionMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_AbsorptionMethod) = (byte)value;
			}
		}

		// Token: 0x17003E94 RID: 16020
		// (get) Token: 0x06010070 RID: 65648 RVA: 0x00179A5D File Offset: 0x00177C5D
		// (set) Token: 0x06010071 RID: 65649 RVA: 0x00179A71 File Offset: 0x00177C71
		[Nullable(0)]
		public unsafe TEnumAsByte<ECollisionChannel> OcclusionTraceChannel
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_OcclusionTraceChannel);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_OcclusionTraceChannel) = value;
			}
		}

		// Token: 0x17003E95 RID: 16021
		// (get) Token: 0x06010072 RID: 65650 RVA: 0x00179A86 File Offset: 0x00177C86
		// (set) Token: 0x06010073 RID: 65651 RVA: 0x00179A96 File Offset: 0x00177C96
		public unsafe EReverbSendMethod ReverbSendMethod
		{
			get
			{
				return (EReverbSendMethod)(*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_ReverbSendMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_ReverbSendMethod) = (byte)value;
			}
		}

		// Token: 0x17003E96 RID: 16022
		// (get) Token: 0x06010074 RID: 65652 RVA: 0x00179AA7 File Offset: 0x00177CA7
		// (set) Token: 0x06010075 RID: 65653 RVA: 0x00179AB7 File Offset: 0x00177CB7
		public unsafe EPriorityAttenuationMethod PriorityAttenuationMethod
		{
			get
			{
				return (EPriorityAttenuationMethod)(*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_PriorityAttenuationMethod));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_PriorityAttenuationMethod) = (byte)value;
			}
		}

		// Token: 0x17003E97 RID: 16023
		// (get) Token: 0x06010076 RID: 65654 RVA: 0x00179AC8 File Offset: 0x00177CC8
		// (set) Token: 0x06010077 RID: 65655 RVA: 0x00179AD8 File Offset: 0x00177CD8
		public unsafe float OmniRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_OmniRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_OmniRadius) = value;
			}
		}

		// Token: 0x17003E98 RID: 16024
		// (get) Token: 0x06010078 RID: 65656 RVA: 0x00179AE9 File Offset: 0x00177CE9
		// (set) Token: 0x06010079 RID: 65657 RVA: 0x00179AF9 File Offset: 0x00177CF9
		public unsafe float StereoSpread
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_StereoSpread);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_StereoSpread) = value;
			}
		}

		// Token: 0x17003E99 RID: 16025
		// (get) Token: 0x0601007A RID: 65658 RVA: 0x00179B0A File Offset: 0x00177D0A
		// (set) Token: 0x0601007B RID: 65659 RVA: 0x00179B1A File Offset: 0x00177D1A
		public unsafe float LPFRadiusMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_LPFRadiusMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_LPFRadiusMin) = value;
			}
		}

		// Token: 0x17003E9A RID: 16026
		// (get) Token: 0x0601007C RID: 65660 RVA: 0x00179B2B File Offset: 0x00177D2B
		// (set) Token: 0x0601007D RID: 65661 RVA: 0x00179B3B File Offset: 0x00177D3B
		public unsafe float LPFRadiusMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_LPFRadiusMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_LPFRadiusMax) = value;
			}
		}

		// Token: 0x17003E9B RID: 16027
		// (get) Token: 0x0601007E RID: 65662 RVA: 0x00179B4C File Offset: 0x00177D4C
		// (set) Token: 0x0601007F RID: 65663 RVA: 0x00179B8F File Offset: 0x00177D8F
		public FRuntimeFloatCurve CustomLowpassAirAbsorptionCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._CustomLowpassAirAbsorptionCurve) == null)
				{
					result = (this._CustomLowpassAirAbsorptionCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_CustomLowpassAirAbsorptionCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_CustomLowpassAirAbsorptionCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003E9C RID: 16028
		// (get) Token: 0x06010080 RID: 65664 RVA: 0x00179BB0 File Offset: 0x00177DB0
		// (set) Token: 0x06010081 RID: 65665 RVA: 0x00179BF3 File Offset: 0x00177DF3
		public FRuntimeFloatCurve CustomHighpassAirAbsorptionCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._CustomHighpassAirAbsorptionCurve) == null)
				{
					result = (this._CustomHighpassAirAbsorptionCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_CustomHighpassAirAbsorptionCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_CustomHighpassAirAbsorptionCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003E9D RID: 16029
		// (get) Token: 0x06010082 RID: 65666 RVA: 0x00179C14 File Offset: 0x00177E14
		// (set) Token: 0x06010083 RID: 65667 RVA: 0x00179C24 File Offset: 0x00177E24
		public unsafe float LPFFrequencyAtMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_LPFFrequencyAtMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_LPFFrequencyAtMin) = value;
			}
		}

		// Token: 0x17003E9E RID: 16030
		// (get) Token: 0x06010084 RID: 65668 RVA: 0x00179C35 File Offset: 0x00177E35
		// (set) Token: 0x06010085 RID: 65669 RVA: 0x00179C45 File Offset: 0x00177E45
		public unsafe float LPFFrequencyAtMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_LPFFrequencyAtMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_LPFFrequencyAtMax) = value;
			}
		}

		// Token: 0x17003E9F RID: 16031
		// (get) Token: 0x06010086 RID: 65670 RVA: 0x00179C56 File Offset: 0x00177E56
		// (set) Token: 0x06010087 RID: 65671 RVA: 0x00179C66 File Offset: 0x00177E66
		public unsafe float HPFFrequencyAtMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_HPFFrequencyAtMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_HPFFrequencyAtMin) = value;
			}
		}

		// Token: 0x17003EA0 RID: 16032
		// (get) Token: 0x06010088 RID: 65672 RVA: 0x00179C77 File Offset: 0x00177E77
		// (set) Token: 0x06010089 RID: 65673 RVA: 0x00179C87 File Offset: 0x00177E87
		public unsafe float HPFFrequencyAtMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_HPFFrequencyAtMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_HPFFrequencyAtMax) = value;
			}
		}

		// Token: 0x17003EA1 RID: 16033
		// (get) Token: 0x0601008A RID: 65674 RVA: 0x00179C98 File Offset: 0x00177E98
		// (set) Token: 0x0601008B RID: 65675 RVA: 0x00179CA8 File Offset: 0x00177EA8
		public unsafe float FocusAzimuth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_FocusAzimuth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_FocusAzimuth) = value;
			}
		}

		// Token: 0x17003EA2 RID: 16034
		// (get) Token: 0x0601008C RID: 65676 RVA: 0x00179CB9 File Offset: 0x00177EB9
		// (set) Token: 0x0601008D RID: 65677 RVA: 0x00179CC9 File Offset: 0x00177EC9
		public unsafe float NonFocusAzimuth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_NonFocusAzimuth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_NonFocusAzimuth) = value;
			}
		}

		// Token: 0x17003EA3 RID: 16035
		// (get) Token: 0x0601008E RID: 65678 RVA: 0x00179CDA File Offset: 0x00177EDA
		// (set) Token: 0x0601008F RID: 65679 RVA: 0x00179CEA File Offset: 0x00177EEA
		public unsafe float FocusDistanceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_FocusDistanceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_FocusDistanceScale) = value;
			}
		}

		// Token: 0x17003EA4 RID: 16036
		// (get) Token: 0x06010090 RID: 65680 RVA: 0x00179CFB File Offset: 0x00177EFB
		// (set) Token: 0x06010091 RID: 65681 RVA: 0x00179D0B File Offset: 0x00177F0B
		public unsafe float NonFocusDistanceScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_NonFocusDistanceScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_NonFocusDistanceScale) = value;
			}
		}

		// Token: 0x17003EA5 RID: 16037
		// (get) Token: 0x06010092 RID: 65682 RVA: 0x00179D1C File Offset: 0x00177F1C
		// (set) Token: 0x06010093 RID: 65683 RVA: 0x00179D2C File Offset: 0x00177F2C
		public unsafe float FocusPriorityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_FocusPriorityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_FocusPriorityScale) = value;
			}
		}

		// Token: 0x17003EA6 RID: 16038
		// (get) Token: 0x06010094 RID: 65684 RVA: 0x00179D3D File Offset: 0x00177F3D
		// (set) Token: 0x06010095 RID: 65685 RVA: 0x00179D4D File Offset: 0x00177F4D
		public unsafe float NonFocusPriorityScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_NonFocusPriorityScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_NonFocusPriorityScale) = value;
			}
		}

		// Token: 0x17003EA7 RID: 16039
		// (get) Token: 0x06010096 RID: 65686 RVA: 0x00179D5E File Offset: 0x00177F5E
		// (set) Token: 0x06010097 RID: 65687 RVA: 0x00179D6E File Offset: 0x00177F6E
		public unsafe float FocusVolumeAttenuation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_FocusVolumeAttenuation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_FocusVolumeAttenuation) = value;
			}
		}

		// Token: 0x17003EA8 RID: 16040
		// (get) Token: 0x06010098 RID: 65688 RVA: 0x00179D7F File Offset: 0x00177F7F
		// (set) Token: 0x06010099 RID: 65689 RVA: 0x00179D8F File Offset: 0x00177F8F
		public unsafe float NonFocusVolumeAttenuation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_NonFocusVolumeAttenuation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_NonFocusVolumeAttenuation) = value;
			}
		}

		// Token: 0x17003EA9 RID: 16041
		// (get) Token: 0x0601009A RID: 65690 RVA: 0x00179DA0 File Offset: 0x00177FA0
		// (set) Token: 0x0601009B RID: 65691 RVA: 0x00179DB0 File Offset: 0x00177FB0
		public unsafe float FocusAttackInterpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_FocusAttackInterpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_FocusAttackInterpSpeed) = value;
			}
		}

		// Token: 0x17003EAA RID: 16042
		// (get) Token: 0x0601009C RID: 65692 RVA: 0x00179DC1 File Offset: 0x00177FC1
		// (set) Token: 0x0601009D RID: 65693 RVA: 0x00179DD1 File Offset: 0x00177FD1
		public unsafe float FocusReleaseInterpSpeed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_FocusReleaseInterpSpeed);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_FocusReleaseInterpSpeed) = value;
			}
		}

		// Token: 0x17003EAB RID: 16043
		// (get) Token: 0x0601009E RID: 65694 RVA: 0x00179DE2 File Offset: 0x00177FE2
		// (set) Token: 0x0601009F RID: 65695 RVA: 0x00179DF2 File Offset: 0x00177FF2
		public unsafe float OcclusionLowPassFilterFrequency
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_OcclusionLowPassFilterFrequency);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_OcclusionLowPassFilterFrequency) = value;
			}
		}

		// Token: 0x17003EAC RID: 16044
		// (get) Token: 0x060100A0 RID: 65696 RVA: 0x00179E03 File Offset: 0x00178003
		// (set) Token: 0x060100A1 RID: 65697 RVA: 0x00179E13 File Offset: 0x00178013
		public unsafe float OcclusionVolumeAttenuation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_OcclusionVolumeAttenuation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_OcclusionVolumeAttenuation) = value;
			}
		}

		// Token: 0x17003EAD RID: 16045
		// (get) Token: 0x060100A2 RID: 65698 RVA: 0x00179E24 File Offset: 0x00178024
		// (set) Token: 0x060100A3 RID: 65699 RVA: 0x00179E34 File Offset: 0x00178034
		public unsafe float OcclusionInterpolationTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_OcclusionInterpolationTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_OcclusionInterpolationTime) = value;
			}
		}

		// Token: 0x17003EAE RID: 16046
		// (get) Token: 0x060100A4 RID: 65700 RVA: 0x00179E45 File Offset: 0x00178045
		// (set) Token: 0x060100A5 RID: 65701 RVA: 0x00179E55 File Offset: 0x00178055
		public unsafe float ReverbWetLevelMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_ReverbWetLevelMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_ReverbWetLevelMin) = value;
			}
		}

		// Token: 0x17003EAF RID: 16047
		// (get) Token: 0x060100A6 RID: 65702 RVA: 0x00179E66 File Offset: 0x00178066
		// (set) Token: 0x060100A7 RID: 65703 RVA: 0x00179E76 File Offset: 0x00178076
		public unsafe float ReverbWetLevelMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_ReverbWetLevelMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_ReverbWetLevelMax) = value;
			}
		}

		// Token: 0x17003EB0 RID: 16048
		// (get) Token: 0x060100A8 RID: 65704 RVA: 0x00179E87 File Offset: 0x00178087
		// (set) Token: 0x060100A9 RID: 65705 RVA: 0x00179E97 File Offset: 0x00178097
		public unsafe float ReverbDistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_ReverbDistanceMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_ReverbDistanceMin) = value;
			}
		}

		// Token: 0x17003EB1 RID: 16049
		// (get) Token: 0x060100AA RID: 65706 RVA: 0x00179EA8 File Offset: 0x001780A8
		// (set) Token: 0x060100AB RID: 65707 RVA: 0x00179EB8 File Offset: 0x001780B8
		public unsafe float ReverbDistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_ReverbDistanceMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_ReverbDistanceMax) = value;
			}
		}

		// Token: 0x17003EB2 RID: 16050
		// (get) Token: 0x060100AC RID: 65708 RVA: 0x00179EC9 File Offset: 0x001780C9
		// (set) Token: 0x060100AD RID: 65709 RVA: 0x00179ED9 File Offset: 0x001780D9
		public unsafe float ManualReverbSendLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_ManualReverbSendLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_ManualReverbSendLevel) = value;
			}
		}

		// Token: 0x17003EB3 RID: 16051
		// (get) Token: 0x060100AE RID: 65710 RVA: 0x00179EEC File Offset: 0x001780EC
		// (set) Token: 0x060100AF RID: 65711 RVA: 0x00179F2F File Offset: 0x0017812F
		public FRuntimeFloatCurve CustomReverbSendCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._CustomReverbSendCurve) == null)
				{
					result = (this._CustomReverbSendCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_CustomReverbSendCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_CustomReverbSendCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003EB4 RID: 16052
		// (get) Token: 0x060100B0 RID: 65712 RVA: 0x00179F50 File Offset: 0x00178150
		// (set) Token: 0x060100B1 RID: 65713 RVA: 0x00179F93 File Offset: 0x00178193
		public TArray<FAttenuationSubmixSendSettings> SubmixSendSettings
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FAttenuationSubmixSendSettings> result;
				if ((result = this._SubmixSendSettings) == null)
				{
					result = (this._SubmixSendSettings = new TArray<FAttenuationSubmixSendSettings>(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_SubmixSendSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				this.SubmixSendSettings.CopyAssign(value);
			}
		}

		// Token: 0x17003EB5 RID: 16053
		// (get) Token: 0x060100B2 RID: 65714 RVA: 0x00179FA1 File Offset: 0x001781A1
		// (set) Token: 0x060100B3 RID: 65715 RVA: 0x00179FB1 File Offset: 0x001781B1
		public unsafe float PriorityAttenuationMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_PriorityAttenuationMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_PriorityAttenuationMin) = value;
			}
		}

		// Token: 0x17003EB6 RID: 16054
		// (get) Token: 0x060100B4 RID: 65716 RVA: 0x00179FC2 File Offset: 0x001781C2
		// (set) Token: 0x060100B5 RID: 65717 RVA: 0x00179FD2 File Offset: 0x001781D2
		public unsafe float PriorityAttenuationMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_PriorityAttenuationMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_PriorityAttenuationMax) = value;
			}
		}

		// Token: 0x17003EB7 RID: 16055
		// (get) Token: 0x060100B6 RID: 65718 RVA: 0x00179FE3 File Offset: 0x001781E3
		// (set) Token: 0x060100B7 RID: 65719 RVA: 0x00179FF3 File Offset: 0x001781F3
		public unsafe float PriorityAttenuationDistanceMin
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_PriorityAttenuationDistanceMin);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_PriorityAttenuationDistanceMin) = value;
			}
		}

		// Token: 0x17003EB8 RID: 16056
		// (get) Token: 0x060100B8 RID: 65720 RVA: 0x0017A004 File Offset: 0x00178204
		// (set) Token: 0x060100B9 RID: 65721 RVA: 0x0017A014 File Offset: 0x00178214
		public unsafe float PriorityAttenuationDistanceMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_PriorityAttenuationDistanceMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_PriorityAttenuationDistanceMax) = value;
			}
		}

		// Token: 0x17003EB9 RID: 16057
		// (get) Token: 0x060100BA RID: 65722 RVA: 0x0017A025 File Offset: 0x00178225
		// (set) Token: 0x060100BB RID: 65723 RVA: 0x0017A035 File Offset: 0x00178235
		public unsafe float ManualPriorityAttenuation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_ManualPriorityAttenuation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_ManualPriorityAttenuation) = value;
			}
		}

		// Token: 0x17003EBA RID: 16058
		// (get) Token: 0x060100BC RID: 65724 RVA: 0x0017A048 File Offset: 0x00178248
		// (set) Token: 0x060100BD RID: 65725 RVA: 0x0017A08B File Offset: 0x0017828B
		public FRuntimeFloatCurve CustomPriorityAttenuationCurve
		{
			get
			{
				base.FastCheckIsValid();
				FRuntimeFloatCurve result;
				if ((result = this._CustomPriorityAttenuationCurve) == null)
				{
					result = (this._CustomPriorityAttenuationCurve = new FRuntimeFloatCurve(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_CustomPriorityAttenuationCurve, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FRuntimeFloatCurve.StaticStruct(), base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_CustomPriorityAttenuationCurve, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17003EBB RID: 16059
		// (get) Token: 0x060100BE RID: 65726 RVA: 0x0017A0AC File Offset: 0x001782AC
		// (set) Token: 0x060100BF RID: 65727 RVA: 0x0017A0EF File Offset: 0x001782EF
		public FSoundAttenuationPluginSettings PluginSettings
		{
			get
			{
				base.FastCheckIsValid();
				FSoundAttenuationPluginSettings result;
				if ((result = this._PluginSettings) == null)
				{
					result = (this._PluginSettings = new FSoundAttenuationPluginSettings(base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_PluginSettings, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSoundAttenuationPluginSettings.StaticStruct(), base.NativePtr + (IntPtr)FSoundAttenuationSettings.__PropertyOffset_PluginSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x060100C0 RID: 65728 RVA: 0x0017A110 File Offset: 0x00178310
		public FSoundAttenuationSettings()
		{
		}

		// Token: 0x060100C1 RID: 65729 RVA: 0x0017A118 File Offset: 0x00178318
		public FSoundAttenuationSettings(bool bAttenuate, bool bSpatialize, bool bAttenuateWithLPF, bool bEnableListenerFocus, bool bEnableFocusInterpolation, bool bEnableOcclusion, bool bUseComplexCollisionForOcclusion, bool bEnableReverbSend, bool bEnablePriorityAttenuation, bool bApplyNormalizationToStereoSounds, bool bEnableLogFrequencyScaling, bool bEnableSubmixSends, [Nullable(0)] TEnumAsByte<ESoundSpatializationAlgorithm> SpatializationAlgorithm, float BinauralRadius, EAirAbsorptionMethod AbsorptionMethod, [Nullable(0)] TEnumAsByte<ECollisionChannel> OcclusionTraceChannel, EReverbSendMethod ReverbSendMethod, EPriorityAttenuationMethod PriorityAttenuationMethod, [Nullable(0)] TEnumAsByte<ESoundDistanceCalc> DistanceType_DEPRECATED, float OmniRadius, float StereoSpread, USpatializationPluginSourceSettingsBase SpatializationPluginSettings_DEPRECATED, float RadiusMin_DEPRECATED, float RadiusMax_DEPRECATED, float LPFRadiusMin, float LPFRadiusMax, FRuntimeFloatCurve CustomLowpassAirAbsorptionCurve, FRuntimeFloatCurve CustomHighpassAirAbsorptionCurve, float LPFFrequencyAtMin, float LPFFrequencyAtMax, float HPFFrequencyAtMin, float HPFFrequencyAtMax, float FocusAzimuth, float NonFocusAzimuth, float FocusDistanceScale, float NonFocusDistanceScale, float FocusPriorityScale, float NonFocusPriorityScale, float FocusVolumeAttenuation, float NonFocusVolumeAttenuation, float FocusAttackInterpSpeed, float FocusReleaseInterpSpeed, float OcclusionLowPassFilterFrequency, float OcclusionVolumeAttenuation, float OcclusionInterpolationTime, UOcclusionPluginSourceSettingsBase OcclusionPluginSettings_DEPRECATED, UReverbPluginSourceSettingsBase ReverbPluginSettings_DEPRECATED, float ReverbWetLevelMin, float ReverbWetLevelMax, float ReverbDistanceMin, float ReverbDistanceMax, float ManualReverbSendLevel, FRuntimeFloatCurve CustomReverbSendCurve, TArray<FAttenuationSubmixSendSettings> SubmixSendSettings, float PriorityAttenuationMin, float PriorityAttenuationMax, float PriorityAttenuationDistanceMin, float PriorityAttenuationDistanceMax, float ManualPriorityAttenuation, FRuntimeFloatCurve CustomPriorityAttenuationCurve, FSoundAttenuationPluginSettings PluginSettings, EAttenuationDistanceModel DistanceAlgorithm, [Nullable(0)] TEnumAsByte<EAttenuationShape> AttenuationShape, float dBAttenuationAtMax, ENaturalSoundFalloffMode FalloffMode, FVector AttenuationShapeExtents, float ConeOffset, float FalloffDistance, FRuntimeFloatCurve CustomAttenuationCurve)
		{
			this.bAttenuate = bAttenuate;
			this.bSpatialize = bSpatialize;
			this.bAttenuateWithLPF = bAttenuateWithLPF;
			this.bEnableListenerFocus = bEnableListenerFocus;
			this.bEnableFocusInterpolation = bEnableFocusInterpolation;
			this.bEnableOcclusion = bEnableOcclusion;
			this.bUseComplexCollisionForOcclusion = bUseComplexCollisionForOcclusion;
			this.bEnableReverbSend = bEnableReverbSend;
			this.bEnablePriorityAttenuation = bEnablePriorityAttenuation;
			this.bApplyNormalizationToStereoSounds = bApplyNormalizationToStereoSounds;
			this.bEnableLogFrequencyScaling = bEnableLogFrequencyScaling;
			this.bEnableSubmixSends = bEnableSubmixSends;
			this.SpatializationAlgorithm = SpatializationAlgorithm;
			this.BinauralRadius = BinauralRadius;
			this.AbsorptionMethod = AbsorptionMethod;
			this.OcclusionTraceChannel = OcclusionTraceChannel;
			this.ReverbSendMethod = ReverbSendMethod;
			this.PriorityAttenuationMethod = PriorityAttenuationMethod;
			this.OmniRadius = OmniRadius;
			this.StereoSpread = StereoSpread;
			this.LPFRadiusMin = LPFRadiusMin;
			this.LPFRadiusMax = LPFRadiusMax;
			this.CustomLowpassAirAbsorptionCurve = CustomLowpassAirAbsorptionCurve;
			this.CustomHighpassAirAbsorptionCurve = CustomHighpassAirAbsorptionCurve;
			this.LPFFrequencyAtMin = LPFFrequencyAtMin;
			this.LPFFrequencyAtMax = LPFFrequencyAtMax;
			this.HPFFrequencyAtMin = HPFFrequencyAtMin;
			this.HPFFrequencyAtMax = HPFFrequencyAtMax;
			this.FocusAzimuth = FocusAzimuth;
			this.NonFocusAzimuth = NonFocusAzimuth;
			this.FocusDistanceScale = FocusDistanceScale;
			this.NonFocusDistanceScale = NonFocusDistanceScale;
			this.FocusPriorityScale = FocusPriorityScale;
			this.NonFocusPriorityScale = NonFocusPriorityScale;
			this.FocusVolumeAttenuation = FocusVolumeAttenuation;
			this.NonFocusVolumeAttenuation = NonFocusVolumeAttenuation;
			this.FocusAttackInterpSpeed = FocusAttackInterpSpeed;
			this.FocusReleaseInterpSpeed = FocusReleaseInterpSpeed;
			this.OcclusionLowPassFilterFrequency = OcclusionLowPassFilterFrequency;
			this.OcclusionVolumeAttenuation = OcclusionVolumeAttenuation;
			this.OcclusionInterpolationTime = OcclusionInterpolationTime;
			this.ReverbWetLevelMin = ReverbWetLevelMin;
			this.ReverbWetLevelMax = ReverbWetLevelMax;
			this.ReverbDistanceMin = ReverbDistanceMin;
			this.ReverbDistanceMax = ReverbDistanceMax;
			this.ManualReverbSendLevel = ManualReverbSendLevel;
			this.CustomReverbSendCurve = CustomReverbSendCurve;
			this.SubmixSendSettings = SubmixSendSettings;
			this.PriorityAttenuationMin = PriorityAttenuationMin;
			this.PriorityAttenuationMax = PriorityAttenuationMax;
			this.PriorityAttenuationDistanceMin = PriorityAttenuationDistanceMin;
			this.PriorityAttenuationDistanceMax = PriorityAttenuationDistanceMax;
			this.ManualPriorityAttenuation = ManualPriorityAttenuation;
			this.CustomPriorityAttenuationCurve = CustomPriorityAttenuationCurve;
			this.PluginSettings = PluginSettings;
			base.DistanceAlgorithm = DistanceAlgorithm;
			base.AttenuationShape = AttenuationShape;
			base.dBAttenuationAtMax = dBAttenuationAtMax;
			base.FalloffMode = FalloffMode;
			base.AttenuationShapeExtents = AttenuationShapeExtents;
			base.ConeOffset = ConeOffset;
			base.FalloffDistance = FalloffDistance;
			base.CustomAttenuationCurve = CustomAttenuationCurve;
		}

		// Token: 0x060100C2 RID: 65730 RVA: 0x0017A320 File Offset: 0x00178520
		protected override IntPtr GetUStructPtr()
		{
			return FSoundAttenuationSettings.StaticStruct();
		}

		// Token: 0x060100C3 RID: 65731 RVA: 0x0017A32C File Offset: 0x0017852C
		[NullableContext(2)]
		public FSoundAttenuationSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060100C4 RID: 65732 RVA: 0x0017A336 File Offset: 0x00178536
		public FSoundAttenuationSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060100C5 RID: 65733 RVA: 0x0017A341 File Offset: 0x00178541
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSoundAttenuationSettings(Pointer, false, true);
		}

		// Token: 0x060100C6 RID: 65734 RVA: 0x0017A34B File Offset: 0x0017854B
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSoundAttenuationSettings(Pointer, MemoryOwner);
		}

		// Token: 0x040089B1 RID: 35249
		public new const string __ObjectPath = "/Script/Engine.SoundAttenuationSettings";

		// Token: 0x040089B2 RID: 35250
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040089B3 RID: 35251
		internal static int __PropertyOffset_bAttenuate;

		// Token: 0x040089B4 RID: 35252
		internal static byte __PropertyMask_bAttenuate;

		// Token: 0x040089B5 RID: 35253
		internal static int __PropertyOffset_bSpatialize;

		// Token: 0x040089B6 RID: 35254
		internal static byte __PropertyMask_bSpatialize;

		// Token: 0x040089B7 RID: 35255
		internal static int __PropertyOffset_bAttenuateWithLPF;

		// Token: 0x040089B8 RID: 35256
		internal static byte __PropertyMask_bAttenuateWithLPF;

		// Token: 0x040089B9 RID: 35257
		internal static int __PropertyOffset_bEnableListenerFocus;

		// Token: 0x040089BA RID: 35258
		internal static byte __PropertyMask_bEnableListenerFocus;

		// Token: 0x040089BB RID: 35259
		internal static int __PropertyOffset_bEnableFocusInterpolation;

		// Token: 0x040089BC RID: 35260
		internal static byte __PropertyMask_bEnableFocusInterpolation;

		// Token: 0x040089BD RID: 35261
		internal static int __PropertyOffset_bEnableOcclusion;

		// Token: 0x040089BE RID: 35262
		internal static byte __PropertyMask_bEnableOcclusion;

		// Token: 0x040089BF RID: 35263
		internal static int __PropertyOffset_bUseComplexCollisionForOcclusion;

		// Token: 0x040089C0 RID: 35264
		internal static byte __PropertyMask_bUseComplexCollisionForOcclusion;

		// Token: 0x040089C1 RID: 35265
		internal static int __PropertyOffset_bEnableReverbSend;

		// Token: 0x040089C2 RID: 35266
		internal static byte __PropertyMask_bEnableReverbSend;

		// Token: 0x040089C3 RID: 35267
		internal static int __PropertyOffset_bEnablePriorityAttenuation;

		// Token: 0x040089C4 RID: 35268
		internal static byte __PropertyMask_bEnablePriorityAttenuation;

		// Token: 0x040089C5 RID: 35269
		internal static int __PropertyOffset_bApplyNormalizationToStereoSounds;

		// Token: 0x040089C6 RID: 35270
		internal static byte __PropertyMask_bApplyNormalizationToStereoSounds;

		// Token: 0x040089C7 RID: 35271
		internal static int __PropertyOffset_bEnableLogFrequencyScaling;

		// Token: 0x040089C8 RID: 35272
		internal static byte __PropertyMask_bEnableLogFrequencyScaling;

		// Token: 0x040089C9 RID: 35273
		internal static int __PropertyOffset_bEnableSubmixSends;

		// Token: 0x040089CA RID: 35274
		internal static byte __PropertyMask_bEnableSubmixSends;

		// Token: 0x040089CB RID: 35275
		internal static int __PropertyOffset_SpatializationAlgorithm;

		// Token: 0x040089CC RID: 35276
		internal static int __PropertyOffset_BinauralRadius;

		// Token: 0x040089CD RID: 35277
		internal static int __PropertyOffset_AbsorptionMethod;

		// Token: 0x040089CE RID: 35278
		internal static int __PropertyOffset_OcclusionTraceChannel;

		// Token: 0x040089CF RID: 35279
		internal static int __PropertyOffset_ReverbSendMethod;

		// Token: 0x040089D0 RID: 35280
		internal static int __PropertyOffset_PriorityAttenuationMethod;

		// Token: 0x040089D1 RID: 35281
		internal static int __PropertyOffset_OmniRadius;

		// Token: 0x040089D2 RID: 35282
		internal static int __PropertyOffset_StereoSpread;

		// Token: 0x040089D3 RID: 35283
		internal static int __PropertyOffset_LPFRadiusMin;

		// Token: 0x040089D4 RID: 35284
		internal static int __PropertyOffset_LPFRadiusMax;

		// Token: 0x040089D5 RID: 35285
		internal static int __PropertyOffset_CustomLowpassAirAbsorptionCurve;

		// Token: 0x040089D6 RID: 35286
		[Nullable(2)]
		private FRuntimeFloatCurve _CustomLowpassAirAbsorptionCurve;

		// Token: 0x040089D7 RID: 35287
		internal static int __PropertyOffset_CustomHighpassAirAbsorptionCurve;

		// Token: 0x040089D8 RID: 35288
		[Nullable(2)]
		private FRuntimeFloatCurve _CustomHighpassAirAbsorptionCurve;

		// Token: 0x040089D9 RID: 35289
		internal static int __PropertyOffset_LPFFrequencyAtMin;

		// Token: 0x040089DA RID: 35290
		internal static int __PropertyOffset_LPFFrequencyAtMax;

		// Token: 0x040089DB RID: 35291
		internal static int __PropertyOffset_HPFFrequencyAtMin;

		// Token: 0x040089DC RID: 35292
		internal static int __PropertyOffset_HPFFrequencyAtMax;

		// Token: 0x040089DD RID: 35293
		internal static int __PropertyOffset_FocusAzimuth;

		// Token: 0x040089DE RID: 35294
		internal static int __PropertyOffset_NonFocusAzimuth;

		// Token: 0x040089DF RID: 35295
		internal static int __PropertyOffset_FocusDistanceScale;

		// Token: 0x040089E0 RID: 35296
		internal static int __PropertyOffset_NonFocusDistanceScale;

		// Token: 0x040089E1 RID: 35297
		internal static int __PropertyOffset_FocusPriorityScale;

		// Token: 0x040089E2 RID: 35298
		internal static int __PropertyOffset_NonFocusPriorityScale;

		// Token: 0x040089E3 RID: 35299
		internal static int __PropertyOffset_FocusVolumeAttenuation;

		// Token: 0x040089E4 RID: 35300
		internal static int __PropertyOffset_NonFocusVolumeAttenuation;

		// Token: 0x040089E5 RID: 35301
		internal static int __PropertyOffset_FocusAttackInterpSpeed;

		// Token: 0x040089E6 RID: 35302
		internal static int __PropertyOffset_FocusReleaseInterpSpeed;

		// Token: 0x040089E7 RID: 35303
		internal static int __PropertyOffset_OcclusionLowPassFilterFrequency;

		// Token: 0x040089E8 RID: 35304
		internal static int __PropertyOffset_OcclusionVolumeAttenuation;

		// Token: 0x040089E9 RID: 35305
		internal static int __PropertyOffset_OcclusionInterpolationTime;

		// Token: 0x040089EA RID: 35306
		internal static int __PropertyOffset_ReverbWetLevelMin;

		// Token: 0x040089EB RID: 35307
		internal static int __PropertyOffset_ReverbWetLevelMax;

		// Token: 0x040089EC RID: 35308
		internal static int __PropertyOffset_ReverbDistanceMin;

		// Token: 0x040089ED RID: 35309
		internal static int __PropertyOffset_ReverbDistanceMax;

		// Token: 0x040089EE RID: 35310
		internal static int __PropertyOffset_ManualReverbSendLevel;

		// Token: 0x040089EF RID: 35311
		internal static int __PropertyOffset_CustomReverbSendCurve;

		// Token: 0x040089F0 RID: 35312
		[Nullable(2)]
		private FRuntimeFloatCurve _CustomReverbSendCurve;

		// Token: 0x040089F1 RID: 35313
		internal static int __PropertyOffset_SubmixSendSettings;

		// Token: 0x040089F2 RID: 35314
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FAttenuationSubmixSendSettings> _SubmixSendSettings;

		// Token: 0x040089F3 RID: 35315
		internal static int __PropertyOffset_PriorityAttenuationMin;

		// Token: 0x040089F4 RID: 35316
		internal static int __PropertyOffset_PriorityAttenuationMax;

		// Token: 0x040089F5 RID: 35317
		internal static int __PropertyOffset_PriorityAttenuationDistanceMin;

		// Token: 0x040089F6 RID: 35318
		internal static int __PropertyOffset_PriorityAttenuationDistanceMax;

		// Token: 0x040089F7 RID: 35319
		internal static int __PropertyOffset_ManualPriorityAttenuation;

		// Token: 0x040089F8 RID: 35320
		internal static int __PropertyOffset_CustomPriorityAttenuationCurve;

		// Token: 0x040089F9 RID: 35321
		[Nullable(2)]
		private FRuntimeFloatCurve _CustomPriorityAttenuationCurve;

		// Token: 0x040089FA RID: 35322
		internal static int __PropertyOffset_PluginSettings;

		// Token: 0x040089FB RID: 35323
		[Nullable(2)]
		private FSoundAttenuationPluginSettings _PluginSettings;
	}
}
