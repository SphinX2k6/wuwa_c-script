using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001B91 RID: 7057
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.KuroPostProcessSetting")]
	[UnrealStructLayout(344, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 344)]
	public class FKuroPostProcessSetting : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0601AC76 RID: 109686 RVA: 0x002775E5 File Offset: 0x002757E5
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroPostProcessSetting._ScriptStructPtr != 0) ? FKuroPostProcessSetting._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRenderingRuntimeBPPlugin.KuroPostProcessSetting", ref FKuroPostProcessSetting._ScriptStructPtr);
		}

		// Token: 0x17006BAE RID: 27566
		// (get) Token: 0x0601AC77 RID: 109687 RVA: 0x00277609 File Offset: 0x00275809
		// (set) Token: 0x0601AC78 RID: 109688 RVA: 0x00277622 File Offset: 0x00275822
		public unsafe bool bOverride_KuroBloomIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomIntensity) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomIntensity) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomIntensity) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomIntensity) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomIntensity : 0));
			}
		}

		// Token: 0x17006BAF RID: 27567
		// (get) Token: 0x0601AC79 RID: 109689 RVA: 0x00277652 File Offset: 0x00275852
		// (set) Token: 0x0601AC7A RID: 109690 RVA: 0x0027766B File Offset: 0x0027586B
		public unsafe bool bOverride_LumenKuroBloomIntensityOffset
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LumenKuroBloomIntensityOffset) & FKuroPostProcessSetting.__PropertyMask_bOverride_LumenKuroBloomIntensityOffset) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LumenKuroBloomIntensityOffset) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LumenKuroBloomIntensityOffset) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_LumenKuroBloomIntensityOffset) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_LumenKuroBloomIntensityOffset : 0));
			}
		}

		// Token: 0x17006BB0 RID: 27568
		// (get) Token: 0x0601AC7B RID: 109691 RVA: 0x0027769B File Offset: 0x0027589B
		// (set) Token: 0x0601AC7C RID: 109692 RVA: 0x002776B4 File Offset: 0x002758B4
		public unsafe bool bOverride_KuroBloomThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomThreshold) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomThreshold) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomThreshold) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomThreshold) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomThreshold : 0));
			}
		}

		// Token: 0x17006BB1 RID: 27569
		// (get) Token: 0x0601AC7D RID: 109693 RVA: 0x002776E4 File Offset: 0x002758E4
		// (set) Token: 0x0601AC7E RID: 109694 RVA: 0x002776FD File Offset: 0x002758FD
		public unsafe bool bOverride_EnableSplitCharBloom
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_EnableSplitCharBloom) & FKuroPostProcessSetting.__PropertyMask_bOverride_EnableSplitCharBloom) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_EnableSplitCharBloom) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_EnableSplitCharBloom) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_EnableSplitCharBloom) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_EnableSplitCharBloom : 0));
			}
		}

		// Token: 0x17006BB2 RID: 27570
		// (get) Token: 0x0601AC7F RID: 109695 RVA: 0x0027772D File Offset: 0x0027592D
		// (set) Token: 0x0601AC80 RID: 109696 RVA: 0x00277746 File Offset: 0x00275946
		public unsafe bool bOverride_KuroCharacterBloomIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroCharacterBloomIntensity) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroCharacterBloomIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroCharacterBloomIntensity) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroCharacterBloomIntensity) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroCharacterBloomIntensity) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroCharacterBloomIntensity : 0));
			}
		}

		// Token: 0x17006BB3 RID: 27571
		// (get) Token: 0x0601AC81 RID: 109697 RVA: 0x00277776 File Offset: 0x00275976
		// (set) Token: 0x0601AC82 RID: 109698 RVA: 0x0027778F File Offset: 0x0027598F
		public unsafe bool bOverride_KuroCharacterBloomThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroCharacterBloomThreshold) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroCharacterBloomThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroCharacterBloomThreshold) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroCharacterBloomThreshold) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroCharacterBloomThreshold) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroCharacterBloomThreshold : 0));
			}
		}

		// Token: 0x17006BB4 RID: 27572
		// (get) Token: 0x0601AC83 RID: 109699 RVA: 0x002777BF File Offset: 0x002759BF
		// (set) Token: 0x0601AC84 RID: 109700 RVA: 0x002777D8 File Offset: 0x002759D8
		public unsafe bool bOverride_SunDirBloomIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_SunDirBloomIntensity) & FKuroPostProcessSetting.__PropertyMask_bOverride_SunDirBloomIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_SunDirBloomIntensity) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_SunDirBloomIntensity) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_SunDirBloomIntensity) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_SunDirBloomIntensity : 0));
			}
		}

		// Token: 0x17006BB5 RID: 27573
		// (get) Token: 0x0601AC85 RID: 109701 RVA: 0x00277808 File Offset: 0x00275A08
		// (set) Token: 0x0601AC86 RID: 109702 RVA: 0x00277821 File Offset: 0x00275A21
		public unsafe bool bOverride_KuroBloomStreakIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomStreakIntensity) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomStreakIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomStreakIntensity) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomStreakIntensity) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomStreakIntensity) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomStreakIntensity : 0));
			}
		}

		// Token: 0x17006BB6 RID: 27574
		// (get) Token: 0x0601AC87 RID: 109703 RVA: 0x00277851 File Offset: 0x00275A51
		// (set) Token: 0x0601AC88 RID: 109704 RVA: 0x0027786A File Offset: 0x00275A6A
		public unsafe bool bOverride_KuroBloomStreakThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomStreakThreshold) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomStreakThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomStreakThreshold) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomStreakThreshold) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomStreakThreshold) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomStreakThreshold : 0));
			}
		}

		// Token: 0x17006BB7 RID: 27575
		// (get) Token: 0x0601AC89 RID: 109705 RVA: 0x0027789A File Offset: 0x00275A9A
		// (set) Token: 0x0601AC8A RID: 109706 RVA: 0x002778B3 File Offset: 0x00275AB3
		public unsafe bool bOverride_TranslucentBloomStreakIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TranslucentBloomStreakIntensity) & FKuroPostProcessSetting.__PropertyMask_bOverride_TranslucentBloomStreakIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TranslucentBloomStreakIntensity) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TranslucentBloomStreakIntensity) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_TranslucentBloomStreakIntensity) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_TranslucentBloomStreakIntensity : 0));
			}
		}

		// Token: 0x17006BB8 RID: 27576
		// (get) Token: 0x0601AC8B RID: 109707 RVA: 0x002778E3 File Offset: 0x00275AE3
		// (set) Token: 0x0601AC8C RID: 109708 RVA: 0x002778FC File Offset: 0x00275AFC
		public unsafe bool bOverride_TranslucentBloomStreakThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TranslucentBloomStreakThreshold) & FKuroPostProcessSetting.__PropertyMask_bOverride_TranslucentBloomStreakThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TranslucentBloomStreakThreshold) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TranslucentBloomStreakThreshold) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_TranslucentBloomStreakThreshold) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_TranslucentBloomStreakThreshold : 0));
			}
		}

		// Token: 0x17006BB9 RID: 27577
		// (get) Token: 0x0601AC8D RID: 109709 RVA: 0x0027792C File Offset: 0x00275B2C
		// (set) Token: 0x0601AC8E RID: 109710 RVA: 0x00277945 File Offset: 0x00275B45
		public unsafe bool bOverride_KuroBloomStreakLength
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomStreakLength) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomStreakLength) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomStreakLength) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomStreakLength) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomStreakLength) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomStreakLength : 0));
			}
		}

		// Token: 0x17006BBA RID: 27578
		// (get) Token: 0x0601AC8F RID: 109711 RVA: 0x00277975 File Offset: 0x00275B75
		// (set) Token: 0x0601AC90 RID: 109712 RVA: 0x0027798E File Offset: 0x00275B8E
		public unsafe bool bOverride_KuroBloomStreakMipLevel
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomStreakMipLevel) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomStreakMipLevel) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomStreakMipLevel) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomStreakMipLevel) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomStreakMipLevel) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomStreakMipLevel : 0));
			}
		}

		// Token: 0x17006BBB RID: 27579
		// (get) Token: 0x0601AC91 RID: 109713 RVA: 0x002779BE File Offset: 0x00275BBE
		// (set) Token: 0x0601AC92 RID: 109714 RVA: 0x002779D7 File Offset: 0x00275BD7
		public unsafe bool bOverride_KuroBloomStreakRatio
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomStreakRatio) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomStreakRatio) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomStreakRatio) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomStreakRatio) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomStreakRatio) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomStreakRatio : 0));
			}
		}

		// Token: 0x17006BBC RID: 27580
		// (get) Token: 0x0601AC93 RID: 109715 RVA: 0x00277A07 File Offset: 0x00275C07
		// (set) Token: 0x0601AC94 RID: 109716 RVA: 0x00277A20 File Offset: 0x00275C20
		public unsafe bool bOverride_KuroBloomStreakOrientation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomStreakOrientation) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomStreakOrientation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomStreakOrientation) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroBloomStreakOrientation) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomStreakOrientation) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroBloomStreakOrientation : 0));
			}
		}

		// Token: 0x17006BBD RID: 27581
		// (get) Token: 0x0601AC95 RID: 109717 RVA: 0x00277A50 File Offset: 0x00275C50
		// (set) Token: 0x0601AC96 RID: 109718 RVA: 0x00277A69 File Offset: 0x00275C69
		public unsafe bool bOverride_SceneColorDesaturate
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_SceneColorDesaturate) & FKuroPostProcessSetting.__PropertyMask_bOverride_SceneColorDesaturate) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_SceneColorDesaturate) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_SceneColorDesaturate) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_SceneColorDesaturate) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_SceneColorDesaturate : 0));
			}
		}

		// Token: 0x17006BBE RID: 27582
		// (get) Token: 0x0601AC97 RID: 109719 RVA: 0x00277A99 File Offset: 0x00275C99
		// (set) Token: 0x0601AC98 RID: 109720 RVA: 0x00277AB2 File Offset: 0x00275CB2
		public unsafe bool bOverride_DecalSaturation
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_DecalSaturation) & FKuroPostProcessSetting.__PropertyMask_bOverride_DecalSaturation) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_DecalSaturation) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_DecalSaturation) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_DecalSaturation) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_DecalSaturation : 0));
			}
		}

		// Token: 0x17006BBF RID: 27583
		// (get) Token: 0x0601AC99 RID: 109721 RVA: 0x00277AE2 File Offset: 0x00275CE2
		// (set) Token: 0x0601AC9A RID: 109722 RVA: 0x00277AFB File Offset: 0x00275CFB
		public unsafe bool bOverride_DecalOpacity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_DecalOpacity) & FKuroPostProcessSetting.__PropertyMask_bOverride_DecalOpacity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_DecalOpacity) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_DecalOpacity) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_DecalOpacity) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_DecalOpacity : 0));
			}
		}

		// Token: 0x17006BC0 RID: 27584
		// (get) Token: 0x0601AC9B RID: 109723 RVA: 0x00277B2B File Offset: 0x00275D2B
		// (set) Token: 0x0601AC9C RID: 109724 RVA: 0x00277B44 File Offset: 0x00275D44
		public unsafe bool bOverride_ColorGradingIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_ColorGradingIntensity) & FKuroPostProcessSetting.__PropertyMask_bOverride_ColorGradingIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_ColorGradingIntensity) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_ColorGradingIntensity) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_ColorGradingIntensity) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_ColorGradingIntensity : 0));
			}
		}

		// Token: 0x17006BC1 RID: 27585
		// (get) Token: 0x0601AC9D RID: 109725 RVA: 0x00277B74 File Offset: 0x00275D74
		// (set) Token: 0x0601AC9E RID: 109726 RVA: 0x00277B8D File Offset: 0x00275D8D
		public unsafe bool bOverride_ColorGradingLUT
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_ColorGradingLUT) & FKuroPostProcessSetting.__PropertyMask_bOverride_ColorGradingLUT) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_ColorGradingLUT) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_ColorGradingLUT) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_ColorGradingLUT) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_ColorGradingLUT : 0));
			}
		}

		// Token: 0x17006BC2 RID: 27586
		// (get) Token: 0x0601AC9F RID: 109727 RVA: 0x00277BBD File Offset: 0x00275DBD
		// (set) Token: 0x0601ACA0 RID: 109728 RVA: 0x00277BD6 File Offset: 0x00275DD6
		public unsafe bool bOverride_AutoExposureDayBias
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_AutoExposureDayBias) & FKuroPostProcessSetting.__PropertyMask_bOverride_AutoExposureDayBias) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_AutoExposureDayBias) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_AutoExposureDayBias) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_AutoExposureDayBias) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_AutoExposureDayBias : 0));
			}
		}

		// Token: 0x17006BC3 RID: 27587
		// (get) Token: 0x0601ACA1 RID: 109729 RVA: 0x00277C06 File Offset: 0x00275E06
		// (set) Token: 0x0601ACA2 RID: 109730 RVA: 0x00277C1F File Offset: 0x00275E1F
		public unsafe bool bOverride_AutoExposureNightBias
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_AutoExposureNightBias) & FKuroPostProcessSetting.__PropertyMask_bOverride_AutoExposureNightBias) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_AutoExposureNightBias) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_AutoExposureNightBias) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_AutoExposureNightBias) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_AutoExposureNightBias : 0));
			}
		}

		// Token: 0x17006BC4 RID: 27588
		// (get) Token: 0x0601ACA3 RID: 109731 RVA: 0x00277C4F File Offset: 0x00275E4F
		// (set) Token: 0x0601ACA4 RID: 109732 RVA: 0x00277C68 File Offset: 0x00275E68
		public unsafe bool bOverride_LumenAutoExposureDayBias
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LumenAutoExposureDayBias) & FKuroPostProcessSetting.__PropertyMask_bOverride_LumenAutoExposureDayBias) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LumenAutoExposureDayBias) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LumenAutoExposureDayBias) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_LumenAutoExposureDayBias) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_LumenAutoExposureDayBias : 0));
			}
		}

		// Token: 0x17006BC5 RID: 27589
		// (get) Token: 0x0601ACA5 RID: 109733 RVA: 0x00277C98 File Offset: 0x00275E98
		// (set) Token: 0x0601ACA6 RID: 109734 RVA: 0x00277CB1 File Offset: 0x00275EB1
		public unsafe bool bOverride_LumenAutoExposureNightBias
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LumenAutoExposureNightBias) & FKuroPostProcessSetting.__PropertyMask_bOverride_LumenAutoExposureNightBias) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LumenAutoExposureNightBias) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LumenAutoExposureNightBias) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_LumenAutoExposureNightBias) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_LumenAutoExposureNightBias : 0));
			}
		}

		// Token: 0x17006BC6 RID: 27590
		// (get) Token: 0x0601ACA7 RID: 109735 RVA: 0x00277CE1 File Offset: 0x00275EE1
		// (set) Token: 0x0601ACA8 RID: 109736 RVA: 0x00277CFA File Offset: 0x00275EFA
		public unsafe bool bOverride_KuroCharacterLUTSplitEnable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroCharacterLUTSplitEnable) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroCharacterLUTSplitEnable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroCharacterLUTSplitEnable) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroCharacterLUTSplitEnable) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroCharacterLUTSplitEnable) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroCharacterLUTSplitEnable : 0));
			}
		}

		// Token: 0x17006BC7 RID: 27591
		// (get) Token: 0x0601ACA9 RID: 109737 RVA: 0x00277D2A File Offset: 0x00275F2A
		// (set) Token: 0x0601ACAA RID: 109738 RVA: 0x00277D43 File Offset: 0x00275F43
		public unsafe bool bOverride_KuroCharacterColorGradingLUT
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroCharacterColorGradingLUT) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroCharacterColorGradingLUT) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroCharacterColorGradingLUT) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroCharacterColorGradingLUT) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroCharacterColorGradingLUT) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroCharacterColorGradingLUT : 0));
			}
		}

		// Token: 0x17006BC8 RID: 27592
		// (get) Token: 0x0601ACAB RID: 109739 RVA: 0x00277D73 File Offset: 0x00275F73
		// (set) Token: 0x0601ACAC RID: 109740 RVA: 0x00277D8C File Offset: 0x00275F8C
		public unsafe bool bOverride_KuroCharacterColorGradingLUTLerpIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroCharacterColorGradingLUTLerpIntensity) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroCharacterColorGradingLUTLerpIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroCharacterColorGradingLUTLerpIntensity) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroCharacterColorGradingLUTLerpIntensity) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroCharacterColorGradingLUTLerpIntensity) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroCharacterColorGradingLUTLerpIntensity : 0));
			}
		}

		// Token: 0x17006BC9 RID: 27593
		// (get) Token: 0x0601ACAD RID: 109741 RVA: 0x00277DBC File Offset: 0x00275FBC
		// (set) Token: 0x0601ACAE RID: 109742 RVA: 0x00277DD5 File Offset: 0x00275FD5
		public unsafe bool bOverride_KuroColorGradingTextureLUTInterpolationEnable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroColorGradingTextureLUTInterpolationEnable) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroColorGradingTextureLUTInterpolationEnable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroColorGradingTextureLUTInterpolationEnable) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroColorGradingTextureLUTInterpolationEnable) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroColorGradingTextureLUTInterpolationEnable) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroColorGradingTextureLUTInterpolationEnable : 0));
			}
		}

		// Token: 0x17006BCA RID: 27594
		// (get) Token: 0x0601ACAF RID: 109743 RVA: 0x00277E05 File Offset: 0x00276005
		// (set) Token: 0x0601ACB0 RID: 109744 RVA: 0x00277E1E File Offset: 0x0027601E
		public unsafe bool bOverride_LightFadeScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LightFadeScale) & FKuroPostProcessSetting.__PropertyMask_bOverride_LightFadeScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LightFadeScale) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LightFadeScale) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_LightFadeScale) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_LightFadeScale : 0));
			}
		}

		// Token: 0x17006BCB RID: 27595
		// (get) Token: 0x0601ACB1 RID: 109745 RVA: 0x00277E4E File Offset: 0x0027604E
		// (set) Token: 0x0601ACB2 RID: 109746 RVA: 0x00277E67 File Offset: 0x00276067
		public unsafe bool bOverride_KuroVolumetricLightEnable
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroVolumetricLightEnable) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroVolumetricLightEnable) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroVolumetricLightEnable) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroVolumetricLightEnable) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroVolumetricLightEnable) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroVolumetricLightEnable : 0));
			}
		}

		// Token: 0x17006BCC RID: 27596
		// (get) Token: 0x0601ACB3 RID: 109747 RVA: 0x00277E97 File Offset: 0x00276097
		// (set) Token: 0x0601ACB4 RID: 109748 RVA: 0x00277EB0 File Offset: 0x002760B0
		public unsafe bool bOverride_KuroVolumetricLightIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroVolumetricLightIntensity) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroVolumetricLightIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroVolumetricLightIntensity) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroVolumetricLightIntensity) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroVolumetricLightIntensity) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroVolumetricLightIntensity : 0));
			}
		}

		// Token: 0x17006BCD RID: 27597
		// (get) Token: 0x0601ACB5 RID: 109749 RVA: 0x00277EE0 File Offset: 0x002760E0
		// (set) Token: 0x0601ACB6 RID: 109750 RVA: 0x00277EF9 File Offset: 0x002760F9
		public unsafe bool bOverride_KuroVolumetricLightColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroVolumetricLightColor) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroVolumetricLightColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroVolumetricLightColor) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroVolumetricLightColor) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroVolumetricLightColor) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroVolumetricLightColor : 0));
			}
		}

		// Token: 0x17006BCE RID: 27598
		// (get) Token: 0x0601ACB7 RID: 109751 RVA: 0x00277F29 File Offset: 0x00276129
		// (set) Token: 0x0601ACB8 RID: 109752 RVA: 0x00277F42 File Offset: 0x00276142
		public unsafe bool bOverride_KuroVolumetricLightPhaseG
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroVolumetricLightPhaseG) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroVolumetricLightPhaseG) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroVolumetricLightPhaseG) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroVolumetricLightPhaseG) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroVolumetricLightPhaseG) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroVolumetricLightPhaseG : 0));
			}
		}

		// Token: 0x17006BCF RID: 27599
		// (get) Token: 0x0601ACB9 RID: 109753 RVA: 0x00277F72 File Offset: 0x00276172
		// (set) Token: 0x0601ACBA RID: 109754 RVA: 0x00277F8B File Offset: 0x0027618B
		public unsafe bool bOverride_KuroVolumetricLightMaxDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroVolumetricLightMaxDistance) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroVolumetricLightMaxDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroVolumetricLightMaxDistance) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroVolumetricLightMaxDistance) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroVolumetricLightMaxDistance) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroVolumetricLightMaxDistance : 0));
			}
		}

		// Token: 0x17006BD0 RID: 27600
		// (get) Token: 0x0601ACBB RID: 109755 RVA: 0x00277FBB File Offset: 0x002761BB
		// (set) Token: 0x0601ACBC RID: 109756 RVA: 0x00277FD4 File Offset: 0x002761D4
		public unsafe bool bOverride_SSFSIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_SSFSIntensity) & FKuroPostProcessSetting.__PropertyMask_bOverride_SSFSIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_SSFSIntensity) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_SSFSIntensity) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_SSFSIntensity) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_SSFSIntensity : 0));
			}
		}

		// Token: 0x17006BD1 RID: 27601
		// (get) Token: 0x0601ACBD RID: 109757 RVA: 0x00278004 File Offset: 0x00276204
		// (set) Token: 0x0601ACBE RID: 109758 RVA: 0x0027801D File Offset: 0x0027621D
		public unsafe bool bOverride_SSFSRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_SSFSRadius) & FKuroPostProcessSetting.__PropertyMask_bOverride_SSFSRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_SSFSRadius) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_SSFSRadius) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_SSFSRadius) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_SSFSRadius : 0));
			}
		}

		// Token: 0x17006BD2 RID: 27602
		// (get) Token: 0x0601ACBF RID: 109759 RVA: 0x0027804D File Offset: 0x0027624D
		// (set) Token: 0x0601ACC0 RID: 109760 RVA: 0x00278066 File Offset: 0x00276266
		public unsafe bool bOverride_SSFSLuminanceWeighting
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_SSFSLuminanceWeighting) & FKuroPostProcessSetting.__PropertyMask_bOverride_SSFSLuminanceWeighting) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_SSFSLuminanceWeighting) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_SSFSLuminanceWeighting) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_SSFSLuminanceWeighting) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_SSFSLuminanceWeighting : 0));
			}
		}

		// Token: 0x17006BD3 RID: 27603
		// (get) Token: 0x0601ACC1 RID: 109761 RVA: 0x00278096 File Offset: 0x00276296
		// (set) Token: 0x0601ACC2 RID: 109762 RVA: 0x002780AF File Offset: 0x002762AF
		public unsafe bool bOverride_SSFSVolumetricFogILSIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_SSFSVolumetricFogILSIntensity) & FKuroPostProcessSetting.__PropertyMask_bOverride_SSFSVolumetricFogILSIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_SSFSVolumetricFogILSIntensity) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_SSFSVolumetricFogILSIntensity) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_SSFSVolumetricFogILSIntensity) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_SSFSVolumetricFogILSIntensity : 0));
			}
		}

		// Token: 0x17006BD4 RID: 27604
		// (get) Token: 0x0601ACC3 RID: 109763 RVA: 0x002780DF File Offset: 0x002762DF
		// (set) Token: 0x0601ACC4 RID: 109764 RVA: 0x002780F8 File Offset: 0x002762F8
		public unsafe bool bOverride_SSFSStartDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_SSFSStartDistance) & FKuroPostProcessSetting.__PropertyMask_bOverride_SSFSStartDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_SSFSStartDistance) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_SSFSStartDistance) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_SSFSStartDistance) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_SSFSStartDistance : 0));
			}
		}

		// Token: 0x17006BD5 RID: 27605
		// (get) Token: 0x0601ACC5 RID: 109765 RVA: 0x00278128 File Offset: 0x00276328
		// (set) Token: 0x0601ACC6 RID: 109766 RVA: 0x00278141 File Offset: 0x00276341
		public unsafe bool bOverride_EnableMobileSSFS
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_EnableMobileSSFS) & FKuroPostProcessSetting.__PropertyMask_bOverride_EnableMobileSSFS) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_EnableMobileSSFS) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_EnableMobileSSFS) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_EnableMobileSSFS) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_EnableMobileSSFS : 0));
			}
		}

		// Token: 0x17006BD6 RID: 27606
		// (get) Token: 0x0601ACC7 RID: 109767 RVA: 0x00278171 File Offset: 0x00276371
		// (set) Token: 0x0601ACC8 RID: 109768 RVA: 0x0027818A File Offset: 0x0027638A
		public unsafe bool bOverride_MobileSSFSFogDensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_MobileSSFSFogDensity) & FKuroPostProcessSetting.__PropertyMask_bOverride_MobileSSFSFogDensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_MobileSSFSFogDensity) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_MobileSSFSFogDensity) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_MobileSSFSFogDensity) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_MobileSSFSFogDensity : 0));
			}
		}

		// Token: 0x17006BD7 RID: 27607
		// (get) Token: 0x0601ACC9 RID: 109769 RVA: 0x002781BA File Offset: 0x002763BA
		// (set) Token: 0x0601ACCA RID: 109770 RVA: 0x002781D3 File Offset: 0x002763D3
		public unsafe bool bOverride_MobileSSFSIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_MobileSSFSIntensity) & FKuroPostProcessSetting.__PropertyMask_bOverride_MobileSSFSIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_MobileSSFSIntensity) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_MobileSSFSIntensity) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_MobileSSFSIntensity) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_MobileSSFSIntensity : 0));
			}
		}

		// Token: 0x17006BD8 RID: 27608
		// (get) Token: 0x0601ACCB RID: 109771 RVA: 0x00278203 File Offset: 0x00276403
		// (set) Token: 0x0601ACCC RID: 109772 RVA: 0x0027821C File Offset: 0x0027641C
		public unsafe bool bOverride_MobileSSFSRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_MobileSSFSRadius) & FKuroPostProcessSetting.__PropertyMask_bOverride_MobileSSFSRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_MobileSSFSRadius) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_MobileSSFSRadius) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_MobileSSFSRadius) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_MobileSSFSRadius : 0));
			}
		}

		// Token: 0x17006BD9 RID: 27609
		// (get) Token: 0x0601ACCD RID: 109773 RVA: 0x0027824C File Offset: 0x0027644C
		// (set) Token: 0x0601ACCE RID: 109774 RVA: 0x00278265 File Offset: 0x00276465
		public unsafe bool bOverride_MobileSSFSStartDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_MobileSSFSStartDistance) & FKuroPostProcessSetting.__PropertyMask_bOverride_MobileSSFSStartDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_MobileSSFSStartDistance) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_MobileSSFSStartDistance) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_MobileSSFSStartDistance) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_MobileSSFSStartDistance : 0));
			}
		}

		// Token: 0x17006BDA RID: 27610
		// (get) Token: 0x0601ACCF RID: 109775 RVA: 0x00278295 File Offset: 0x00276495
		// (set) Token: 0x0601ACD0 RID: 109776 RVA: 0x002782AE File Offset: 0x002764AE
		public unsafe bool bOverride_TyndallScaLightIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaLightIntensity) & FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaLightIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaLightIntensity) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaLightIntensity) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaLightIntensity) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaLightIntensity : 0));
			}
		}

		// Token: 0x17006BDB RID: 27611
		// (get) Token: 0x0601ACD1 RID: 109777 RVA: 0x002782DE File Offset: 0x002764DE
		// (set) Token: 0x0601ACD2 RID: 109778 RVA: 0x002782F7 File Offset: 0x002764F7
		public unsafe bool bOverride_TyndallDarkIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallDarkIntensity) & FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallDarkIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallDarkIntensity) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallDarkIntensity) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallDarkIntensity) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallDarkIntensity : 0));
			}
		}

		// Token: 0x17006BDC RID: 27612
		// (get) Token: 0x0601ACD3 RID: 109779 RVA: 0x00278327 File Offset: 0x00276527
		// (set) Token: 0x0601ACD4 RID: 109780 RVA: 0x00278340 File Offset: 0x00276540
		public unsafe bool bOverride_TyndallScaLightLength
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaLightLength) & FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaLightLength) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaLightLength) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaLightLength) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaLightLength) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaLightLength : 0));
			}
		}

		// Token: 0x17006BDD RID: 27613
		// (get) Token: 0x0601ACD5 RID: 109781 RVA: 0x00278370 File Offset: 0x00276570
		// (set) Token: 0x0601ACD6 RID: 109782 RVA: 0x00278389 File Offset: 0x00276589
		public unsafe bool bOverride_TyndallScaLightColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaLightColor) & FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaLightColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaLightColor) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaLightColor) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaLightColor) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaLightColor : 0));
			}
		}

		// Token: 0x17006BDE RID: 27614
		// (get) Token: 0x0601ACD7 RID: 109783 RVA: 0x002783B9 File Offset: 0x002765B9
		// (set) Token: 0x0601ACD8 RID: 109784 RVA: 0x002783D2 File Offset: 0x002765D2
		public unsafe bool bOverride_TyndallScaLightFade
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaLightFade) & FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaLightFade) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaLightFade) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaLightFade) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaLightFade) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaLightFade : 0));
			}
		}

		// Token: 0x17006BDF RID: 27615
		// (get) Token: 0x0601ACD9 RID: 109785 RVA: 0x00278402 File Offset: 0x00276602
		// (set) Token: 0x0601ACDA RID: 109786 RVA: 0x0027841B File Offset: 0x0027661B
		public unsafe bool bOverride_TyndallScaLightMode
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaLightMode) & FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaLightMode) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaLightMode) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaLightMode) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaLightMode) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaLightMode : 0));
			}
		}

		// Token: 0x17006BE0 RID: 27616
		// (get) Token: 0x0601ACDB RID: 109787 RVA: 0x0027844B File Offset: 0x0027664B
		// (set) Token: 0x0601ACDC RID: 109788 RVA: 0x00278464 File Offset: 0x00276664
		public unsafe bool bOverride_TyndallScaNearFade
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaNearFade) & FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaNearFade) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaNearFade) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaNearFade) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaNearFade) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaNearFade : 0));
			}
		}

		// Token: 0x17006BE1 RID: 27617
		// (get) Token: 0x0601ACDD RID: 109789 RVA: 0x00278494 File Offset: 0x00276694
		// (set) Token: 0x0601ACDE RID: 109790 RVA: 0x002784AD File Offset: 0x002766AD
		public unsafe bool bOverride_TyndallScaDarkFadeDepth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaDarkFadeDepth) & FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaDarkFadeDepth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaDarkFadeDepth) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaDarkFadeDepth) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaDarkFadeDepth) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaDarkFadeDepth : 0));
			}
		}

		// Token: 0x17006BE2 RID: 27618
		// (get) Token: 0x0601ACDF RID: 109791 RVA: 0x002784DD File Offset: 0x002766DD
		// (set) Token: 0x0601ACE0 RID: 109792 RVA: 0x002784F6 File Offset: 0x002766F6
		public unsafe bool bOverride_TyndallScaMaxDepth
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaMaxDepth) & FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaMaxDepth) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaMaxDepth) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_TyndallScaMaxDepth) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaMaxDepth) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_TyndallScaMaxDepth : 0));
			}
		}

		// Token: 0x17006BE3 RID: 27619
		// (get) Token: 0x0601ACE1 RID: 109793 RVA: 0x00278526 File Offset: 0x00276726
		// (set) Token: 0x0601ACE2 RID: 109794 RVA: 0x0027853F File Offset: 0x0027673F
		public unsafe bool bOverride_KuroSharpenRadius
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroSharpenRadius) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroSharpenRadius) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroSharpenRadius) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroSharpenRadius) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroSharpenRadius) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroSharpenRadius : 0));
			}
		}

		// Token: 0x17006BE4 RID: 27620
		// (get) Token: 0x0601ACE3 RID: 109795 RVA: 0x0027856F File Offset: 0x0027676F
		// (set) Token: 0x0601ACE4 RID: 109796 RVA: 0x00278588 File Offset: 0x00276788
		public unsafe bool bOverride_KuroSharpenAmount
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroSharpenAmount) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroSharpenAmount) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroSharpenAmount) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroSharpenAmount) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroSharpenAmount) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroSharpenAmount : 0));
			}
		}

		// Token: 0x17006BE5 RID: 27621
		// (get) Token: 0x0601ACE5 RID: 109797 RVA: 0x002785B8 File Offset: 0x002767B8
		// (set) Token: 0x0601ACE6 RID: 109798 RVA: 0x002785D1 File Offset: 0x002767D1
		public unsafe bool bOverride_KuroLaplacianAmount
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroLaplacianAmount) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroLaplacianAmount) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroLaplacianAmount) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroLaplacianAmount) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroLaplacianAmount) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroLaplacianAmount : 0));
			}
		}

		// Token: 0x17006BE6 RID: 27622
		// (get) Token: 0x0601ACE7 RID: 109799 RVA: 0x00278601 File Offset: 0x00276801
		// (set) Token: 0x0601ACE8 RID: 109800 RVA: 0x0027861A File Offset: 0x0027681A
		public unsafe bool bOverride_KuroSharpenIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroSharpenIntensity) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroSharpenIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroSharpenIntensity) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroSharpenIntensity) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroSharpenIntensity) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroSharpenIntensity : 0));
			}
		}

		// Token: 0x17006BE7 RID: 27623
		// (get) Token: 0x0601ACE9 RID: 109801 RVA: 0x0027864A File Offset: 0x0027684A
		// (set) Token: 0x0601ACEA RID: 109802 RVA: 0x00278663 File Offset: 0x00276863
		public unsafe bool bOverride_KuroToonSharpenIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroToonSharpenIntensity) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroToonSharpenIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroToonSharpenIntensity) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroToonSharpenIntensity) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroToonSharpenIntensity) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroToonSharpenIntensity : 0));
			}
		}

		// Token: 0x17006BE8 RID: 27624
		// (get) Token: 0x0601ACEB RID: 109803 RVA: 0x00278693 File Offset: 0x00276893
		// (set) Token: 0x0601ACEC RID: 109804 RVA: 0x002786AC File Offset: 0x002768AC
		public unsafe bool bOverride_KuroSharpenDistance
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroSharpenDistance) & FKuroPostProcessSetting.__PropertyMask_bOverride_KuroSharpenDistance) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroSharpenDistance) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_KuroSharpenDistance) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_KuroSharpenDistance) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_KuroSharpenDistance : 0));
			}
		}

		// Token: 0x17006BE9 RID: 27625
		// (get) Token: 0x0601ACED RID: 109805 RVA: 0x002786DC File Offset: 0x002768DC
		// (set) Token: 0x0601ACEE RID: 109806 RVA: 0x002786F5 File Offset: 0x002768F5
		public unsafe bool bOverride_LocalExposureHighlightContrastScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LocalExposureHighlightContrastScale) & FKuroPostProcessSetting.__PropertyMask_bOverride_LocalExposureHighlightContrastScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LocalExposureHighlightContrastScale) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LocalExposureHighlightContrastScale) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_LocalExposureHighlightContrastScale) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_LocalExposureHighlightContrastScale : 0));
			}
		}

		// Token: 0x17006BEA RID: 27626
		// (get) Token: 0x0601ACEF RID: 109807 RVA: 0x00278725 File Offset: 0x00276925
		// (set) Token: 0x0601ACF0 RID: 109808 RVA: 0x0027873E File Offset: 0x0027693E
		public unsafe bool bOverride_LocalExposureShadowContrastScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LocalExposureShadowContrastScale) & FKuroPostProcessSetting.__PropertyMask_bOverride_LocalExposureShadowContrastScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LocalExposureShadowContrastScale) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LocalExposureShadowContrastScale) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_LocalExposureShadowContrastScale) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_LocalExposureShadowContrastScale : 0));
			}
		}

		// Token: 0x17006BEB RID: 27627
		// (get) Token: 0x0601ACF1 RID: 109809 RVA: 0x0027876E File Offset: 0x0027696E
		// (set) Token: 0x0601ACF2 RID: 109810 RVA: 0x00278787 File Offset: 0x00276987
		public unsafe bool bOverride_LocalExposureHighlightThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LocalExposureHighlightThreshold) & FKuroPostProcessSetting.__PropertyMask_bOverride_LocalExposureHighlightThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LocalExposureHighlightThreshold) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LocalExposureHighlightThreshold) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_LocalExposureHighlightThreshold) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_LocalExposureHighlightThreshold : 0));
			}
		}

		// Token: 0x17006BEC RID: 27628
		// (get) Token: 0x0601ACF3 RID: 109811 RVA: 0x002787B7 File Offset: 0x002769B7
		// (set) Token: 0x0601ACF4 RID: 109812 RVA: 0x002787D0 File Offset: 0x002769D0
		public unsafe bool bOverride_LocalExposureShadowThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LocalExposureShadowThreshold) & FKuroPostProcessSetting.__PropertyMask_bOverride_LocalExposureShadowThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LocalExposureShadowThreshold) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LocalExposureShadowThreshold) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_LocalExposureShadowThreshold) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_LocalExposureShadowThreshold : 0));
			}
		}

		// Token: 0x17006BED RID: 27629
		// (get) Token: 0x0601ACF5 RID: 109813 RVA: 0x00278800 File Offset: 0x00276A00
		// (set) Token: 0x0601ACF6 RID: 109814 RVA: 0x00278819 File Offset: 0x00276A19
		public unsafe bool bOverride_LumenLocalExposureHighlightContrastScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LumenLocalExposureHighlightContrastScale) & FKuroPostProcessSetting.__PropertyMask_bOverride_LumenLocalExposureHighlightContrastScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LumenLocalExposureHighlightContrastScale) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LumenLocalExposureHighlightContrastScale) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_LumenLocalExposureHighlightContrastScale) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_LumenLocalExposureHighlightContrastScale : 0));
			}
		}

		// Token: 0x17006BEE RID: 27630
		// (get) Token: 0x0601ACF7 RID: 109815 RVA: 0x00278849 File Offset: 0x00276A49
		// (set) Token: 0x0601ACF8 RID: 109816 RVA: 0x00278862 File Offset: 0x00276A62
		public unsafe bool bOverride_LumenLocalExposureShadowContrastScale
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LumenLocalExposureShadowContrastScale) & FKuroPostProcessSetting.__PropertyMask_bOverride_LumenLocalExposureShadowContrastScale) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LumenLocalExposureShadowContrastScale) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LumenLocalExposureShadowContrastScale) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_LumenLocalExposureShadowContrastScale) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_LumenLocalExposureShadowContrastScale : 0));
			}
		}

		// Token: 0x17006BEF RID: 27631
		// (get) Token: 0x0601ACF9 RID: 109817 RVA: 0x00278892 File Offset: 0x00276A92
		// (set) Token: 0x0601ACFA RID: 109818 RVA: 0x002788AB File Offset: 0x00276AAB
		public unsafe bool bOverride_LumenLocalExposureHighlightThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LumenLocalExposureHighlightThreshold) & FKuroPostProcessSetting.__PropertyMask_bOverride_LumenLocalExposureHighlightThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LumenLocalExposureHighlightThreshold) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LumenLocalExposureHighlightThreshold) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_LumenLocalExposureHighlightThreshold) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_LumenLocalExposureHighlightThreshold : 0));
			}
		}

		// Token: 0x17006BF0 RID: 27632
		// (get) Token: 0x0601ACFB RID: 109819 RVA: 0x002788DB File Offset: 0x00276ADB
		// (set) Token: 0x0601ACFC RID: 109820 RVA: 0x002788F4 File Offset: 0x00276AF4
		public unsafe bool bOverride_LumenLocalExposureShadowThreshold
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LumenLocalExposureShadowThreshold) & FKuroPostProcessSetting.__PropertyMask_bOverride_LumenLocalExposureShadowThreshold) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LumenLocalExposureShadowThreshold) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_LumenLocalExposureShadowThreshold) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_LumenLocalExposureShadowThreshold) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_LumenLocalExposureShadowThreshold : 0));
			}
		}

		// Token: 0x17006BF1 RID: 27633
		// (get) Token: 0x0601ACFD RID: 109821 RVA: 0x00278924 File Offset: 0x00276B24
		// (set) Token: 0x0601ACFE RID: 109822 RVA: 0x0027893D File Offset: 0x00276B3D
		public unsafe bool bOverride_IndirectLightingIntensity
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_IndirectLightingIntensity) & FKuroPostProcessSetting.__PropertyMask_bOverride_IndirectLightingIntensity) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_IndirectLightingIntensity) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_IndirectLightingIntensity) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_IndirectLightingIntensity) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_IndirectLightingIntensity : 0));
			}
		}

		// Token: 0x17006BF2 RID: 27634
		// (get) Token: 0x0601ACFF RID: 109823 RVA: 0x0027896D File Offset: 0x00276B6D
		// (set) Token: 0x0601AD00 RID: 109824 RVA: 0x00278986 File Offset: 0x00276B86
		public unsafe bool bOverride_IndirectLightingColor
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_IndirectLightingColor) & FKuroPostProcessSetting.__PropertyMask_bOverride_IndirectLightingColor) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_IndirectLightingColor) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_bOverride_IndirectLightingColor) & ~FKuroPostProcessSetting.__PropertyMask_bOverride_IndirectLightingColor) | (value ? FKuroPostProcessSetting.__PropertyMask_bOverride_IndirectLightingColor : 0));
			}
		}

		// Token: 0x17006BF3 RID: 27635
		// (get) Token: 0x0601AD01 RID: 109825 RVA: 0x002789B6 File Offset: 0x00276BB6
		// (set) Token: 0x0601AD02 RID: 109826 RVA: 0x002789C6 File Offset: 0x00276BC6
		public unsafe float KuroBloomIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroBloomIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroBloomIntensity) = value;
			}
		}

		// Token: 0x17006BF4 RID: 27636
		// (get) Token: 0x0601AD03 RID: 109827 RVA: 0x002789D7 File Offset: 0x00276BD7
		// (set) Token: 0x0601AD04 RID: 109828 RVA: 0x002789E7 File Offset: 0x00276BE7
		public unsafe float LumenKuroBloomIntensityOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LumenKuroBloomIntensityOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LumenKuroBloomIntensityOffset) = value;
			}
		}

		// Token: 0x17006BF5 RID: 27637
		// (get) Token: 0x0601AD05 RID: 109829 RVA: 0x002789F8 File Offset: 0x00276BF8
		// (set) Token: 0x0601AD06 RID: 109830 RVA: 0x00278A08 File Offset: 0x00276C08
		public unsafe float KuroBloomThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroBloomThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroBloomThreshold) = value;
			}
		}

		// Token: 0x17006BF6 RID: 27638
		// (get) Token: 0x0601AD07 RID: 109831 RVA: 0x00278A19 File Offset: 0x00276C19
		// (set) Token: 0x0601AD08 RID: 109832 RVA: 0x00278A32 File Offset: 0x00276C32
		public unsafe bool EnableSplitCharBloom
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_EnableSplitCharBloom) & FKuroPostProcessSetting.__PropertyMask_EnableSplitCharBloom) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_EnableSplitCharBloom) = ((*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_EnableSplitCharBloom) & ~FKuroPostProcessSetting.__PropertyMask_EnableSplitCharBloom) | (value ? FKuroPostProcessSetting.__PropertyMask_EnableSplitCharBloom : 0));
			}
		}

		// Token: 0x17006BF7 RID: 27639
		// (get) Token: 0x0601AD09 RID: 109833 RVA: 0x00278A62 File Offset: 0x00276C62
		// (set) Token: 0x0601AD0A RID: 109834 RVA: 0x00278A72 File Offset: 0x00276C72
		public unsafe float KuroCharacterBloomIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroCharacterBloomIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroCharacterBloomIntensity) = value;
			}
		}

		// Token: 0x17006BF8 RID: 27640
		// (get) Token: 0x0601AD0B RID: 109835 RVA: 0x00278A83 File Offset: 0x00276C83
		// (set) Token: 0x0601AD0C RID: 109836 RVA: 0x00278A93 File Offset: 0x00276C93
		public unsafe float KuroCharacterBloomThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroCharacterBloomThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroCharacterBloomThreshold) = value;
			}
		}

		// Token: 0x17006BF9 RID: 27641
		// (get) Token: 0x0601AD0D RID: 109837 RVA: 0x00278AA4 File Offset: 0x00276CA4
		// (set) Token: 0x0601AD0E RID: 109838 RVA: 0x00278AB4 File Offset: 0x00276CB4
		public unsafe float SunDirBloomIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_SunDirBloomIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_SunDirBloomIntensity) = value;
			}
		}

		// Token: 0x17006BFA RID: 27642
		// (get) Token: 0x0601AD0F RID: 109839 RVA: 0x00278AC5 File Offset: 0x00276CC5
		// (set) Token: 0x0601AD10 RID: 109840 RVA: 0x00278AD5 File Offset: 0x00276CD5
		public unsafe float KuroBloomStreakIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroBloomStreakIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroBloomStreakIntensity) = value;
			}
		}

		// Token: 0x17006BFB RID: 27643
		// (get) Token: 0x0601AD11 RID: 109841 RVA: 0x00278AE6 File Offset: 0x00276CE6
		// (set) Token: 0x0601AD12 RID: 109842 RVA: 0x00278AF6 File Offset: 0x00276CF6
		public unsafe float KuroBloomStreakThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroBloomStreakThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroBloomStreakThreshold) = value;
			}
		}

		// Token: 0x17006BFC RID: 27644
		// (get) Token: 0x0601AD13 RID: 109843 RVA: 0x00278B07 File Offset: 0x00276D07
		// (set) Token: 0x0601AD14 RID: 109844 RVA: 0x00278B17 File Offset: 0x00276D17
		public unsafe float TranslucentBloomStreakIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_TranslucentBloomStreakIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_TranslucentBloomStreakIntensity) = value;
			}
		}

		// Token: 0x17006BFD RID: 27645
		// (get) Token: 0x0601AD15 RID: 109845 RVA: 0x00278B28 File Offset: 0x00276D28
		// (set) Token: 0x0601AD16 RID: 109846 RVA: 0x00278B38 File Offset: 0x00276D38
		public unsafe float TranslucentBloomStreakThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_TranslucentBloomStreakThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_TranslucentBloomStreakThreshold) = value;
			}
		}

		// Token: 0x17006BFE RID: 27646
		// (get) Token: 0x0601AD17 RID: 109847 RVA: 0x00278B49 File Offset: 0x00276D49
		// (set) Token: 0x0601AD18 RID: 109848 RVA: 0x00278B59 File Offset: 0x00276D59
		public unsafe float KuroBloomStreakLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroBloomStreakLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroBloomStreakLength) = value;
			}
		}

		// Token: 0x17006BFF RID: 27647
		// (get) Token: 0x0601AD19 RID: 109849 RVA: 0x00278B6A File Offset: 0x00276D6A
		// (set) Token: 0x0601AD1A RID: 109850 RVA: 0x00278B7A File Offset: 0x00276D7A
		public unsafe float KuroBloomStreakMipLevel
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroBloomStreakMipLevel);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroBloomStreakMipLevel) = value;
			}
		}

		// Token: 0x17006C00 RID: 27648
		// (get) Token: 0x0601AD1B RID: 109851 RVA: 0x00278B8B File Offset: 0x00276D8B
		// (set) Token: 0x0601AD1C RID: 109852 RVA: 0x00278B9B File Offset: 0x00276D9B
		public unsafe float KuroBloomStreakRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroBloomStreakRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroBloomStreakRatio) = value;
			}
		}

		// Token: 0x17006C01 RID: 27649
		// (get) Token: 0x0601AD1D RID: 109853 RVA: 0x00278BAC File Offset: 0x00276DAC
		// (set) Token: 0x0601AD1E RID: 109854 RVA: 0x00278BBC File Offset: 0x00276DBC
		public unsafe float KuroBloomStreakOrientation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroBloomStreakOrientation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroBloomStreakOrientation) = value;
			}
		}

		// Token: 0x17006C02 RID: 27650
		// (get) Token: 0x0601AD1F RID: 109855 RVA: 0x00278BCD File Offset: 0x00276DCD
		// (set) Token: 0x0601AD20 RID: 109856 RVA: 0x00278BDD File Offset: 0x00276DDD
		public unsafe float SceneColorDesaturate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_SceneColorDesaturate);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_SceneColorDesaturate) = value;
			}
		}

		// Token: 0x17006C03 RID: 27651
		// (get) Token: 0x0601AD21 RID: 109857 RVA: 0x00278BEE File Offset: 0x00276DEE
		// (set) Token: 0x0601AD22 RID: 109858 RVA: 0x00278BFE File Offset: 0x00276DFE
		public unsafe float DecalSaturation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_DecalSaturation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_DecalSaturation) = value;
			}
		}

		// Token: 0x17006C04 RID: 27652
		// (get) Token: 0x0601AD23 RID: 109859 RVA: 0x00278C0F File Offset: 0x00276E0F
		// (set) Token: 0x0601AD24 RID: 109860 RVA: 0x00278C1F File Offset: 0x00276E1F
		public unsafe float DecalOpacity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_DecalOpacity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_DecalOpacity) = value;
			}
		}

		// Token: 0x17006C05 RID: 27653
		// (get) Token: 0x0601AD25 RID: 109861 RVA: 0x00278C30 File Offset: 0x00276E30
		// (set) Token: 0x0601AD26 RID: 109862 RVA: 0x00278C40 File Offset: 0x00276E40
		public unsafe float ColorGradingIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_ColorGradingIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_ColorGradingIntensity) = value;
			}
		}

		// Token: 0x17006C06 RID: 27654
		// (get) Token: 0x0601AD27 RID: 109863 RVA: 0x00278C51 File Offset: 0x00276E51
		// (set) Token: 0x0601AD28 RID: 109864 RVA: 0x00278C65 File Offset: 0x00276E65
		public unsafe UTexture ColorGradingLUT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroPostProcessSetting.__PropertyOffset_ColorGradingLUT);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroPostProcessSetting.__PropertyOffset_ColorGradingLUT, value);
			}
		}

		// Token: 0x17006C07 RID: 27655
		// (get) Token: 0x0601AD29 RID: 109865 RVA: 0x00278C7A File Offset: 0x00276E7A
		// (set) Token: 0x0601AD2A RID: 109866 RVA: 0x00278C8A File Offset: 0x00276E8A
		public unsafe float AutoExposureDayBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_AutoExposureDayBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_AutoExposureDayBias) = value;
			}
		}

		// Token: 0x17006C08 RID: 27656
		// (get) Token: 0x0601AD2B RID: 109867 RVA: 0x00278C9B File Offset: 0x00276E9B
		// (set) Token: 0x0601AD2C RID: 109868 RVA: 0x00278CAB File Offset: 0x00276EAB
		public unsafe float AutoExposureNightBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_AutoExposureNightBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_AutoExposureNightBias) = value;
			}
		}

		// Token: 0x17006C09 RID: 27657
		// (get) Token: 0x0601AD2D RID: 109869 RVA: 0x00278CBC File Offset: 0x00276EBC
		// (set) Token: 0x0601AD2E RID: 109870 RVA: 0x00278CCC File Offset: 0x00276ECC
		public unsafe float LumenAutoExposureDayBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LumenAutoExposureDayBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LumenAutoExposureDayBias) = value;
			}
		}

		// Token: 0x17006C0A RID: 27658
		// (get) Token: 0x0601AD2F RID: 109871 RVA: 0x00278CDD File Offset: 0x00276EDD
		// (set) Token: 0x0601AD30 RID: 109872 RVA: 0x00278CED File Offset: 0x00276EED
		public unsafe float LumenAutoExposureNightBias
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LumenAutoExposureNightBias);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LumenAutoExposureNightBias) = value;
			}
		}

		// Token: 0x17006C0B RID: 27659
		// (get) Token: 0x0601AD31 RID: 109873 RVA: 0x00278CFE File Offset: 0x00276EFE
		// (set) Token: 0x0601AD32 RID: 109874 RVA: 0x00278D0E File Offset: 0x00276F0E
		public unsafe bool KuroCharacterLUTSplitEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroCharacterLUTSplitEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroCharacterLUTSplitEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C0C RID: 27660
		// (get) Token: 0x0601AD33 RID: 109875 RVA: 0x00278D1F File Offset: 0x00276F1F
		// (set) Token: 0x0601AD34 RID: 109876 RVA: 0x00278D33 File Offset: 0x00276F33
		public unsafe UTexture KuroCharacterColorGradingLUT
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UTexture>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroPostProcessSetting.__PropertyOffset_KuroCharacterColorGradingLUT);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroPostProcessSetting.__PropertyOffset_KuroCharacterColorGradingLUT, value);
			}
		}

		// Token: 0x17006C0D RID: 27661
		// (get) Token: 0x0601AD35 RID: 109877 RVA: 0x00278D48 File Offset: 0x00276F48
		// (set) Token: 0x0601AD36 RID: 109878 RVA: 0x00278D58 File Offset: 0x00276F58
		public unsafe float KuroCharacterColorGradingLUTLerpIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroCharacterColorGradingLUTLerpIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroCharacterColorGradingLUTLerpIntensity) = value;
			}
		}

		// Token: 0x17006C0E RID: 27662
		// (get) Token: 0x0601AD37 RID: 109879 RVA: 0x00278D69 File Offset: 0x00276F69
		// (set) Token: 0x0601AD38 RID: 109880 RVA: 0x00278D79 File Offset: 0x00276F79
		public unsafe bool KuroColorGradingTextureLUTInterpolationEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroColorGradingTextureLUTInterpolationEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroColorGradingTextureLUTInterpolationEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C0F RID: 27663
		// (get) Token: 0x0601AD39 RID: 109881 RVA: 0x00278D8A File Offset: 0x00276F8A
		// (set) Token: 0x0601AD3A RID: 109882 RVA: 0x00278D9A File Offset: 0x00276F9A
		public unsafe float LightFadeScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LightFadeScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LightFadeScale) = value;
			}
		}

		// Token: 0x17006C10 RID: 27664
		// (get) Token: 0x0601AD3B RID: 109883 RVA: 0x00278DAB File Offset: 0x00276FAB
		// (set) Token: 0x0601AD3C RID: 109884 RVA: 0x00278DBB File Offset: 0x00276FBB
		public unsafe bool KuroVolumetricLightEnable
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroVolumetricLightEnable) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroVolumetricLightEnable) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C11 RID: 27665
		// (get) Token: 0x0601AD3D RID: 109885 RVA: 0x00278DCC File Offset: 0x00276FCC
		// (set) Token: 0x0601AD3E RID: 109886 RVA: 0x00278DDC File Offset: 0x00276FDC
		public unsafe float KuroVolumetricLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroVolumetricLightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroVolumetricLightIntensity) = value;
			}
		}

		// Token: 0x17006C12 RID: 27666
		// (get) Token: 0x0601AD3F RID: 109887 RVA: 0x00278DED File Offset: 0x00276FED
		// (set) Token: 0x0601AD40 RID: 109888 RVA: 0x00278E01 File Offset: 0x00277001
		public unsafe FLinearColor KuroVolumetricLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroVolumetricLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroVolumetricLightColor) = value;
			}
		}

		// Token: 0x17006C13 RID: 27667
		// (get) Token: 0x0601AD41 RID: 109889 RVA: 0x00278E16 File Offset: 0x00277016
		// (set) Token: 0x0601AD42 RID: 109890 RVA: 0x00278E26 File Offset: 0x00277026
		public unsafe float KuroVolumetricLightPhaseG
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroVolumetricLightPhaseG);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroVolumetricLightPhaseG) = value;
			}
		}

		// Token: 0x17006C14 RID: 27668
		// (get) Token: 0x0601AD43 RID: 109891 RVA: 0x00278E37 File Offset: 0x00277037
		// (set) Token: 0x0601AD44 RID: 109892 RVA: 0x00278E47 File Offset: 0x00277047
		public unsafe float KuroVolumetricLightMaxDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroVolumetricLightMaxDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroVolumetricLightMaxDistance) = value;
			}
		}

		// Token: 0x17006C15 RID: 27669
		// (get) Token: 0x0601AD45 RID: 109893 RVA: 0x00278E58 File Offset: 0x00277058
		// (set) Token: 0x0601AD46 RID: 109894 RVA: 0x00278E68 File Offset: 0x00277068
		public unsafe float SSFSIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_SSFSIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_SSFSIntensity) = value;
			}
		}

		// Token: 0x17006C16 RID: 27670
		// (get) Token: 0x0601AD47 RID: 109895 RVA: 0x00278E79 File Offset: 0x00277079
		// (set) Token: 0x0601AD48 RID: 109896 RVA: 0x00278E89 File Offset: 0x00277089
		public unsafe float SSFSRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_SSFSRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_SSFSRadius) = value;
			}
		}

		// Token: 0x17006C17 RID: 27671
		// (get) Token: 0x0601AD49 RID: 109897 RVA: 0x00278E9A File Offset: 0x0027709A
		// (set) Token: 0x0601AD4A RID: 109898 RVA: 0x00278EAA File Offset: 0x002770AA
		public unsafe bool SSFSLuminanceWeighting
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_SSFSLuminanceWeighting) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_SSFSLuminanceWeighting) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C18 RID: 27672
		// (get) Token: 0x0601AD4B RID: 109899 RVA: 0x00278EBB File Offset: 0x002770BB
		// (set) Token: 0x0601AD4C RID: 109900 RVA: 0x00278ECB File Offset: 0x002770CB
		public unsafe float SSFSVolumetricFogILSIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_SSFSVolumetricFogILSIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_SSFSVolumetricFogILSIntensity) = value;
			}
		}

		// Token: 0x17006C19 RID: 27673
		// (get) Token: 0x0601AD4D RID: 109901 RVA: 0x00278EDC File Offset: 0x002770DC
		// (set) Token: 0x0601AD4E RID: 109902 RVA: 0x00278EEC File Offset: 0x002770EC
		public unsafe float SSFSStartDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_SSFSStartDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_SSFSStartDistance) = value;
			}
		}

		// Token: 0x17006C1A RID: 27674
		// (get) Token: 0x0601AD4F RID: 109903 RVA: 0x00278EFD File Offset: 0x002770FD
		// (set) Token: 0x0601AD50 RID: 109904 RVA: 0x00278F0D File Offset: 0x0027710D
		public unsafe bool EnableMobileSSFS
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_EnableMobileSSFS) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_EnableMobileSSFS) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C1B RID: 27675
		// (get) Token: 0x0601AD51 RID: 109905 RVA: 0x00278F1E File Offset: 0x0027711E
		// (set) Token: 0x0601AD52 RID: 109906 RVA: 0x00278F2E File Offset: 0x0027712E
		public unsafe float MobileSSFSFogDensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_MobileSSFSFogDensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_MobileSSFSFogDensity) = value;
			}
		}

		// Token: 0x17006C1C RID: 27676
		// (get) Token: 0x0601AD53 RID: 109907 RVA: 0x00278F3F File Offset: 0x0027713F
		// (set) Token: 0x0601AD54 RID: 109908 RVA: 0x00278F4F File Offset: 0x0027714F
		public unsafe float MobileSSFSIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_MobileSSFSIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_MobileSSFSIntensity) = value;
			}
		}

		// Token: 0x17006C1D RID: 27677
		// (get) Token: 0x0601AD55 RID: 109909 RVA: 0x00278F60 File Offset: 0x00277160
		// (set) Token: 0x0601AD56 RID: 109910 RVA: 0x00278F70 File Offset: 0x00277170
		public unsafe float MobileSSFSRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_MobileSSFSRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_MobileSSFSRadius) = value;
			}
		}

		// Token: 0x17006C1E RID: 27678
		// (get) Token: 0x0601AD57 RID: 109911 RVA: 0x00278F81 File Offset: 0x00277181
		// (set) Token: 0x0601AD58 RID: 109912 RVA: 0x00278F91 File Offset: 0x00277191
		public unsafe float MobileSSFSStartDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_MobileSSFSStartDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_MobileSSFSStartDistance) = value;
			}
		}

		// Token: 0x17006C1F RID: 27679
		// (get) Token: 0x0601AD59 RID: 109913 RVA: 0x00278FA2 File Offset: 0x002771A2
		// (set) Token: 0x0601AD5A RID: 109914 RVA: 0x00278FB2 File Offset: 0x002771B2
		public unsafe float TyndallScaLightIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_TyndallScaLightIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_TyndallScaLightIntensity) = value;
			}
		}

		// Token: 0x17006C20 RID: 27680
		// (get) Token: 0x0601AD5B RID: 109915 RVA: 0x00278FC3 File Offset: 0x002771C3
		// (set) Token: 0x0601AD5C RID: 109916 RVA: 0x00278FD3 File Offset: 0x002771D3
		public unsafe float TyndallDarkIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_TyndallDarkIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_TyndallDarkIntensity) = value;
			}
		}

		// Token: 0x17006C21 RID: 27681
		// (get) Token: 0x0601AD5D RID: 109917 RVA: 0x00278FE4 File Offset: 0x002771E4
		// (set) Token: 0x0601AD5E RID: 109918 RVA: 0x00278FF4 File Offset: 0x002771F4
		public unsafe float TyndallScaLightLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_TyndallScaLightLength);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_TyndallScaLightLength) = value;
			}
		}

		// Token: 0x17006C22 RID: 27682
		// (get) Token: 0x0601AD5F RID: 109919 RVA: 0x00279005 File Offset: 0x00277205
		// (set) Token: 0x0601AD60 RID: 109920 RVA: 0x00279019 File Offset: 0x00277219
		public unsafe FLinearColor TyndallScaLightColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_TyndallScaLightColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_TyndallScaLightColor) = value;
			}
		}

		// Token: 0x17006C23 RID: 27683
		// (get) Token: 0x0601AD61 RID: 109921 RVA: 0x0027902E File Offset: 0x0027722E
		// (set) Token: 0x0601AD62 RID: 109922 RVA: 0x0027903E File Offset: 0x0027723E
		public unsafe float TyndallScaLightFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_TyndallScaLightFade);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_TyndallScaLightFade) = value;
			}
		}

		// Token: 0x17006C24 RID: 27684
		// (get) Token: 0x0601AD63 RID: 109923 RVA: 0x0027904F File Offset: 0x0027724F
		// (set) Token: 0x0601AD64 RID: 109924 RVA: 0x0027905F File Offset: 0x0027725F
		public unsafe bool TyndallScaLightMode
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_TyndallScaLightMode) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_TyndallScaLightMode) = (value ? 1 : 0);
			}
		}

		// Token: 0x17006C25 RID: 27685
		// (get) Token: 0x0601AD65 RID: 109925 RVA: 0x00279070 File Offset: 0x00277270
		// (set) Token: 0x0601AD66 RID: 109926 RVA: 0x00279080 File Offset: 0x00277280
		public unsafe float TyndallScaNearFade
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_TyndallScaNearFade);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_TyndallScaNearFade) = value;
			}
		}

		// Token: 0x17006C26 RID: 27686
		// (get) Token: 0x0601AD67 RID: 109927 RVA: 0x00279091 File Offset: 0x00277291
		// (set) Token: 0x0601AD68 RID: 109928 RVA: 0x002790A1 File Offset: 0x002772A1
		public unsafe float TyndallScaDarkFadeDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_TyndallScaDarkFadeDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_TyndallScaDarkFadeDepth) = value;
			}
		}

		// Token: 0x17006C27 RID: 27687
		// (get) Token: 0x0601AD69 RID: 109929 RVA: 0x002790B2 File Offset: 0x002772B2
		// (set) Token: 0x0601AD6A RID: 109930 RVA: 0x002790C2 File Offset: 0x002772C2
		public unsafe float TyndallScaMaxDepth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_TyndallScaMaxDepth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_TyndallScaMaxDepth) = value;
			}
		}

		// Token: 0x17006C28 RID: 27688
		// (get) Token: 0x0601AD6B RID: 109931 RVA: 0x002790D3 File Offset: 0x002772D3
		// (set) Token: 0x0601AD6C RID: 109932 RVA: 0x002790E3 File Offset: 0x002772E3
		public unsafe float KuroSharpenRadius
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroSharpenRadius);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroSharpenRadius) = value;
			}
		}

		// Token: 0x17006C29 RID: 27689
		// (get) Token: 0x0601AD6D RID: 109933 RVA: 0x002790F4 File Offset: 0x002772F4
		// (set) Token: 0x0601AD6E RID: 109934 RVA: 0x00279104 File Offset: 0x00277304
		public unsafe float KuroSharpenAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroSharpenAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroSharpenAmount) = value;
			}
		}

		// Token: 0x17006C2A RID: 27690
		// (get) Token: 0x0601AD6F RID: 109935 RVA: 0x00279115 File Offset: 0x00277315
		// (set) Token: 0x0601AD70 RID: 109936 RVA: 0x00279125 File Offset: 0x00277325
		public unsafe float KuroLaplacianAmount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroLaplacianAmount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroLaplacianAmount) = value;
			}
		}

		// Token: 0x17006C2B RID: 27691
		// (get) Token: 0x0601AD71 RID: 109937 RVA: 0x00279136 File Offset: 0x00277336
		// (set) Token: 0x0601AD72 RID: 109938 RVA: 0x00279146 File Offset: 0x00277346
		public unsafe float KuroSharpenIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroSharpenIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroSharpenIntensity) = value;
			}
		}

		// Token: 0x17006C2C RID: 27692
		// (get) Token: 0x0601AD73 RID: 109939 RVA: 0x00279157 File Offset: 0x00277357
		// (set) Token: 0x0601AD74 RID: 109940 RVA: 0x00279167 File Offset: 0x00277367
		public unsafe float KuroToonSharpenIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroToonSharpenIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroToonSharpenIntensity) = value;
			}
		}

		// Token: 0x17006C2D RID: 27693
		// (get) Token: 0x0601AD75 RID: 109941 RVA: 0x00279178 File Offset: 0x00277378
		// (set) Token: 0x0601AD76 RID: 109942 RVA: 0x00279188 File Offset: 0x00277388
		public unsafe float KuroSharpenDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroSharpenDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_KuroSharpenDistance) = value;
			}
		}

		// Token: 0x17006C2E RID: 27694
		// (get) Token: 0x0601AD77 RID: 109943 RVA: 0x00279199 File Offset: 0x00277399
		// (set) Token: 0x0601AD78 RID: 109944 RVA: 0x002791A9 File Offset: 0x002773A9
		public unsafe float LocalExposureHighlightContrastScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LocalExposureHighlightContrastScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LocalExposureHighlightContrastScale) = value;
			}
		}

		// Token: 0x17006C2F RID: 27695
		// (get) Token: 0x0601AD79 RID: 109945 RVA: 0x002791BA File Offset: 0x002773BA
		// (set) Token: 0x0601AD7A RID: 109946 RVA: 0x002791CA File Offset: 0x002773CA
		public unsafe float LocalExposureShadowContrastScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LocalExposureShadowContrastScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LocalExposureShadowContrastScale) = value;
			}
		}

		// Token: 0x17006C30 RID: 27696
		// (get) Token: 0x0601AD7B RID: 109947 RVA: 0x002791DB File Offset: 0x002773DB
		// (set) Token: 0x0601AD7C RID: 109948 RVA: 0x002791EB File Offset: 0x002773EB
		public unsafe float LocalExposureHighlightThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LocalExposureHighlightThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LocalExposureHighlightThreshold) = value;
			}
		}

		// Token: 0x17006C31 RID: 27697
		// (get) Token: 0x0601AD7D RID: 109949 RVA: 0x002791FC File Offset: 0x002773FC
		// (set) Token: 0x0601AD7E RID: 109950 RVA: 0x0027920C File Offset: 0x0027740C
		public unsafe float LocalExposureShadowThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LocalExposureShadowThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LocalExposureShadowThreshold) = value;
			}
		}

		// Token: 0x17006C32 RID: 27698
		// (get) Token: 0x0601AD7F RID: 109951 RVA: 0x0027921D File Offset: 0x0027741D
		// (set) Token: 0x0601AD80 RID: 109952 RVA: 0x0027922D File Offset: 0x0027742D
		public unsafe float LumenLocalExposureHighlightContrastScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LumenLocalExposureHighlightContrastScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LumenLocalExposureHighlightContrastScale) = value;
			}
		}

		// Token: 0x17006C33 RID: 27699
		// (get) Token: 0x0601AD81 RID: 109953 RVA: 0x0027923E File Offset: 0x0027743E
		// (set) Token: 0x0601AD82 RID: 109954 RVA: 0x0027924E File Offset: 0x0027744E
		public unsafe float LumenLocalExposureShadowContrastScale
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LumenLocalExposureShadowContrastScale);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LumenLocalExposureShadowContrastScale) = value;
			}
		}

		// Token: 0x17006C34 RID: 27700
		// (get) Token: 0x0601AD83 RID: 109955 RVA: 0x0027925F File Offset: 0x0027745F
		// (set) Token: 0x0601AD84 RID: 109956 RVA: 0x0027926F File Offset: 0x0027746F
		public unsafe float LumenLocalExposureHighlightThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LumenLocalExposureHighlightThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LumenLocalExposureHighlightThreshold) = value;
			}
		}

		// Token: 0x17006C35 RID: 27701
		// (get) Token: 0x0601AD85 RID: 109957 RVA: 0x00279280 File Offset: 0x00277480
		// (set) Token: 0x0601AD86 RID: 109958 RVA: 0x00279290 File Offset: 0x00277490
		public unsafe float LumenLocalExposureShadowThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LumenLocalExposureShadowThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_LumenLocalExposureShadowThreshold) = value;
			}
		}

		// Token: 0x17006C36 RID: 27702
		// (get) Token: 0x0601AD87 RID: 109959 RVA: 0x002792A1 File Offset: 0x002774A1
		// (set) Token: 0x0601AD88 RID: 109960 RVA: 0x002792B5 File Offset: 0x002774B5
		public unsafe FLinearColor IndirectLightingColor
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_IndirectLightingColor);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_IndirectLightingColor) = value;
			}
		}

		// Token: 0x17006C37 RID: 27703
		// (get) Token: 0x0601AD89 RID: 109961 RVA: 0x002792CA File Offset: 0x002774CA
		// (set) Token: 0x0601AD8A RID: 109962 RVA: 0x002792DA File Offset: 0x002774DA
		public unsafe float IndirectLightingIntensity
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_IndirectLightingIntensity);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroPostProcessSetting.__PropertyOffset_IndirectLightingIntensity) = value;
			}
		}

		// Token: 0x0601AD8B RID: 109963 RVA: 0x002792EB File Offset: 0x002774EB
		public FKuroPostProcessSetting()
		{
		}

		// Token: 0x0601AD8C RID: 109964 RVA: 0x002792F4 File Offset: 0x002774F4
		[NullableContext(1)]
		public FKuroPostProcessSetting(bool bOverride_KuroBloomIntensity, bool bOverride_LumenKuroBloomIntensityOffset, bool bOverride_KuroBloomThreshold, bool bOverride_EnableSplitCharBloom, bool bOverride_KuroCharacterBloomIntensity, bool bOverride_KuroCharacterBloomThreshold, bool bOverride_SunDirBloomIntensity, bool bOverride_KuroBloomStreakIntensity, bool bOverride_KuroBloomStreakThreshold, bool bOverride_TranslucentBloomStreakIntensity, bool bOverride_TranslucentBloomStreakThreshold, bool bOverride_KuroBloomStreakLength, bool bOverride_KuroBloomStreakMipLevel, bool bOverride_KuroBloomStreakRatio, bool bOverride_KuroBloomStreakOrientation, bool bOverride_SceneColorDesaturate, bool bOverride_DecalSaturation, bool bOverride_DecalOpacity, bool bOverride_ColorGradingIntensity, bool bOverride_ColorGradingLUT, bool bOverride_AutoExposureDayBias, bool bOverride_AutoExposureNightBias, bool bOverride_LumenAutoExposureDayBias, bool bOverride_LumenAutoExposureNightBias, bool bOverride_KuroCharacterLUTSplitEnable, bool bOverride_KuroCharacterColorGradingLUT, bool bOverride_KuroCharacterColorGradingLUTLerpIntensity, bool bOverride_KuroColorGradingTextureLUTInterpolationEnable, bool bOverride_LightFadeScale, bool bOverride_KuroVolumetricLightEnable, bool bOverride_KuroVolumetricLightIntensity, bool bOverride_KuroVolumetricLightColor, bool bOverride_KuroVolumetricLightPhaseG, bool bOverride_KuroVolumetricLightMaxDistance, bool bOverride_SSFSIntensity, bool bOverride_SSFSRadius, bool bOverride_SSFSLuminanceWeighting, bool bOverride_SSFSVolumetricFogILSIntensity, bool bOverride_SSFSStartDistance, bool bOverride_EnableMobileSSFS, bool bOverride_MobileSSFSFogDensity, bool bOverride_MobileSSFSIntensity, bool bOverride_MobileSSFSRadius, bool bOverride_MobileSSFSStartDistance, bool bOverride_TyndallScaLightIntensity, bool bOverride_TyndallDarkIntensity, bool bOverride_TyndallScaLightLength, bool bOverride_TyndallScaLightColor, bool bOverride_TyndallScaLightFade, bool bOverride_TyndallScaLightMode, bool bOverride_TyndallScaNearFade, bool bOverride_TyndallScaDarkFadeDepth, bool bOverride_TyndallScaMaxDepth, bool bOverride_KuroSharpenRadius, bool bOverride_KuroSharpenAmount, bool bOverride_KuroLaplacianAmount, bool bOverride_KuroSharpenIntensity, bool bOverride_KuroToonSharpenIntensity, bool bOverride_KuroSharpenDistance, bool bOverride_LocalExposureHighlightContrastScale, bool bOverride_LocalExposureShadowContrastScale, bool bOverride_LocalExposureHighlightThreshold, bool bOverride_LocalExposureShadowThreshold, bool bOverride_LumenLocalExposureHighlightContrastScale, bool bOverride_LumenLocalExposureShadowContrastScale, bool bOverride_LumenLocalExposureHighlightThreshold, bool bOverride_LumenLocalExposureShadowThreshold, bool bOverride_IndirectLightingIntensity, bool bOverride_IndirectLightingColor, float KuroBloomIntensity, float LumenKuroBloomIntensityOffset, float KuroBloomThreshold, bool EnableSplitCharBloom, float KuroCharacterBloomIntensity, float KuroCharacterBloomThreshold, float SunDirBloomIntensity, float KuroBloomStreakIntensity, float KuroBloomStreakThreshold, float TranslucentBloomStreakIntensity, float TranslucentBloomStreakThreshold, float KuroBloomStreakLength, float KuroBloomStreakMipLevel, float KuroBloomStreakRatio, float KuroBloomStreakOrientation, float SceneColorDesaturate, float DecalSaturation, float DecalOpacity, float ColorGradingIntensity, UTexture ColorGradingLUT, float AutoExposureDayBias, float AutoExposureNightBias, float LumenAutoExposureDayBias, float LumenAutoExposureNightBias, bool KuroCharacterLUTSplitEnable, UTexture KuroCharacterColorGradingLUT, float KuroCharacterColorGradingLUTLerpIntensity, bool KuroColorGradingTextureLUTInterpolationEnable, float LightFadeScale, bool KuroVolumetricLightEnable, float KuroVolumetricLightIntensity, FLinearColor KuroVolumetricLightColor, float KuroVolumetricLightPhaseG, float KuroVolumetricLightMaxDistance, float SSFSIntensity, float SSFSRadius, bool SSFSLuminanceWeighting, float SSFSVolumetricFogILSIntensity, float SSFSStartDistance, bool EnableMobileSSFS, float MobileSSFSFogDensity, float MobileSSFSIntensity, float MobileSSFSRadius, float MobileSSFSStartDistance, float TyndallScaLightIntensity, float TyndallDarkIntensity, float TyndallScaLightLength, FLinearColor TyndallScaLightColor, float TyndallScaLightFade, bool TyndallScaLightMode, float TyndallScaNearFade, float TyndallScaDarkFadeDepth, float TyndallScaMaxDepth, float KuroSharpenRadius, float KuroSharpenAmount, float KuroLaplacianAmount, float KuroSharpenIntensity, float KuroToonSharpenIntensity, float KuroSharpenDistance, float LocalExposureHighlightContrastScale, float LocalExposureShadowContrastScale, float LocalExposureHighlightThreshold, float LocalExposureShadowThreshold, float LumenLocalExposureHighlightContrastScale, float LumenLocalExposureShadowContrastScale, float LumenLocalExposureHighlightThreshold, float LumenLocalExposureShadowThreshold, FLinearColor IndirectLightingColor, float IndirectLightingIntensity)
		{
			this.bOverride_KuroBloomIntensity = bOverride_KuroBloomIntensity;
			this.bOverride_LumenKuroBloomIntensityOffset = bOverride_LumenKuroBloomIntensityOffset;
			this.bOverride_KuroBloomThreshold = bOverride_KuroBloomThreshold;
			this.bOverride_EnableSplitCharBloom = bOverride_EnableSplitCharBloom;
			this.bOverride_KuroCharacterBloomIntensity = bOverride_KuroCharacterBloomIntensity;
			this.bOverride_KuroCharacterBloomThreshold = bOverride_KuroCharacterBloomThreshold;
			this.bOverride_SunDirBloomIntensity = bOverride_SunDirBloomIntensity;
			this.bOverride_KuroBloomStreakIntensity = bOverride_KuroBloomStreakIntensity;
			this.bOverride_KuroBloomStreakThreshold = bOverride_KuroBloomStreakThreshold;
			this.bOverride_TranslucentBloomStreakIntensity = bOverride_TranslucentBloomStreakIntensity;
			this.bOverride_TranslucentBloomStreakThreshold = bOverride_TranslucentBloomStreakThreshold;
			this.bOverride_KuroBloomStreakLength = bOverride_KuroBloomStreakLength;
			this.bOverride_KuroBloomStreakMipLevel = bOverride_KuroBloomStreakMipLevel;
			this.bOverride_KuroBloomStreakRatio = bOverride_KuroBloomStreakRatio;
			this.bOverride_KuroBloomStreakOrientation = bOverride_KuroBloomStreakOrientation;
			this.bOverride_SceneColorDesaturate = bOverride_SceneColorDesaturate;
			this.bOverride_DecalSaturation = bOverride_DecalSaturation;
			this.bOverride_DecalOpacity = bOverride_DecalOpacity;
			this.bOverride_ColorGradingIntensity = bOverride_ColorGradingIntensity;
			this.bOverride_ColorGradingLUT = bOverride_ColorGradingLUT;
			this.bOverride_AutoExposureDayBias = bOverride_AutoExposureDayBias;
			this.bOverride_AutoExposureNightBias = bOverride_AutoExposureNightBias;
			this.bOverride_LumenAutoExposureDayBias = bOverride_LumenAutoExposureDayBias;
			this.bOverride_LumenAutoExposureNightBias = bOverride_LumenAutoExposureNightBias;
			this.bOverride_KuroCharacterLUTSplitEnable = bOverride_KuroCharacterLUTSplitEnable;
			this.bOverride_KuroCharacterColorGradingLUT = bOverride_KuroCharacterColorGradingLUT;
			this.bOverride_KuroCharacterColorGradingLUTLerpIntensity = bOverride_KuroCharacterColorGradingLUTLerpIntensity;
			this.bOverride_KuroColorGradingTextureLUTInterpolationEnable = bOverride_KuroColorGradingTextureLUTInterpolationEnable;
			this.bOverride_LightFadeScale = bOverride_LightFadeScale;
			this.bOverride_KuroVolumetricLightEnable = bOverride_KuroVolumetricLightEnable;
			this.bOverride_KuroVolumetricLightIntensity = bOverride_KuroVolumetricLightIntensity;
			this.bOverride_KuroVolumetricLightColor = bOverride_KuroVolumetricLightColor;
			this.bOverride_KuroVolumetricLightPhaseG = bOverride_KuroVolumetricLightPhaseG;
			this.bOverride_KuroVolumetricLightMaxDistance = bOverride_KuroVolumetricLightMaxDistance;
			this.bOverride_SSFSIntensity = bOverride_SSFSIntensity;
			this.bOverride_SSFSRadius = bOverride_SSFSRadius;
			this.bOverride_SSFSLuminanceWeighting = bOverride_SSFSLuminanceWeighting;
			this.bOverride_SSFSVolumetricFogILSIntensity = bOverride_SSFSVolumetricFogILSIntensity;
			this.bOverride_SSFSStartDistance = bOverride_SSFSStartDistance;
			this.bOverride_EnableMobileSSFS = bOverride_EnableMobileSSFS;
			this.bOverride_MobileSSFSFogDensity = bOverride_MobileSSFSFogDensity;
			this.bOverride_MobileSSFSIntensity = bOverride_MobileSSFSIntensity;
			this.bOverride_MobileSSFSRadius = bOverride_MobileSSFSRadius;
			this.bOverride_MobileSSFSStartDistance = bOverride_MobileSSFSStartDistance;
			this.bOverride_TyndallScaLightIntensity = bOverride_TyndallScaLightIntensity;
			this.bOverride_TyndallDarkIntensity = bOverride_TyndallDarkIntensity;
			this.bOverride_TyndallScaLightLength = bOverride_TyndallScaLightLength;
			this.bOverride_TyndallScaLightColor = bOverride_TyndallScaLightColor;
			this.bOverride_TyndallScaLightFade = bOverride_TyndallScaLightFade;
			this.bOverride_TyndallScaLightMode = bOverride_TyndallScaLightMode;
			this.bOverride_TyndallScaNearFade = bOverride_TyndallScaNearFade;
			this.bOverride_TyndallScaDarkFadeDepth = bOverride_TyndallScaDarkFadeDepth;
			this.bOverride_TyndallScaMaxDepth = bOverride_TyndallScaMaxDepth;
			this.bOverride_KuroSharpenRadius = bOverride_KuroSharpenRadius;
			this.bOverride_KuroSharpenAmount = bOverride_KuroSharpenAmount;
			this.bOverride_KuroLaplacianAmount = bOverride_KuroLaplacianAmount;
			this.bOverride_KuroSharpenIntensity = bOverride_KuroSharpenIntensity;
			this.bOverride_KuroToonSharpenIntensity = bOverride_KuroToonSharpenIntensity;
			this.bOverride_KuroSharpenDistance = bOverride_KuroSharpenDistance;
			this.bOverride_LocalExposureHighlightContrastScale = bOverride_LocalExposureHighlightContrastScale;
			this.bOverride_LocalExposureShadowContrastScale = bOverride_LocalExposureShadowContrastScale;
			this.bOverride_LocalExposureHighlightThreshold = bOverride_LocalExposureHighlightThreshold;
			this.bOverride_LocalExposureShadowThreshold = bOverride_LocalExposureShadowThreshold;
			this.bOverride_LumenLocalExposureHighlightContrastScale = bOverride_LumenLocalExposureHighlightContrastScale;
			this.bOverride_LumenLocalExposureShadowContrastScale = bOverride_LumenLocalExposureShadowContrastScale;
			this.bOverride_LumenLocalExposureHighlightThreshold = bOverride_LumenLocalExposureHighlightThreshold;
			this.bOverride_LumenLocalExposureShadowThreshold = bOverride_LumenLocalExposureShadowThreshold;
			this.bOverride_IndirectLightingIntensity = bOverride_IndirectLightingIntensity;
			this.bOverride_IndirectLightingColor = bOverride_IndirectLightingColor;
			this.KuroBloomIntensity = KuroBloomIntensity;
			this.LumenKuroBloomIntensityOffset = LumenKuroBloomIntensityOffset;
			this.KuroBloomThreshold = KuroBloomThreshold;
			this.EnableSplitCharBloom = EnableSplitCharBloom;
			this.KuroCharacterBloomIntensity = KuroCharacterBloomIntensity;
			this.KuroCharacterBloomThreshold = KuroCharacterBloomThreshold;
			this.SunDirBloomIntensity = SunDirBloomIntensity;
			this.KuroBloomStreakIntensity = KuroBloomStreakIntensity;
			this.KuroBloomStreakThreshold = KuroBloomStreakThreshold;
			this.TranslucentBloomStreakIntensity = TranslucentBloomStreakIntensity;
			this.TranslucentBloomStreakThreshold = TranslucentBloomStreakThreshold;
			this.KuroBloomStreakLength = KuroBloomStreakLength;
			this.KuroBloomStreakMipLevel = KuroBloomStreakMipLevel;
			this.KuroBloomStreakRatio = KuroBloomStreakRatio;
			this.KuroBloomStreakOrientation = KuroBloomStreakOrientation;
			this.SceneColorDesaturate = SceneColorDesaturate;
			this.DecalSaturation = DecalSaturation;
			this.DecalOpacity = DecalOpacity;
			this.ColorGradingIntensity = ColorGradingIntensity;
			this.ColorGradingLUT = ColorGradingLUT;
			this.AutoExposureDayBias = AutoExposureDayBias;
			this.AutoExposureNightBias = AutoExposureNightBias;
			this.LumenAutoExposureDayBias = LumenAutoExposureDayBias;
			this.LumenAutoExposureNightBias = LumenAutoExposureNightBias;
			this.KuroCharacterLUTSplitEnable = KuroCharacterLUTSplitEnable;
			this.KuroCharacterColorGradingLUT = KuroCharacterColorGradingLUT;
			this.KuroCharacterColorGradingLUTLerpIntensity = KuroCharacterColorGradingLUTLerpIntensity;
			this.KuroColorGradingTextureLUTInterpolationEnable = KuroColorGradingTextureLUTInterpolationEnable;
			this.LightFadeScale = LightFadeScale;
			this.KuroVolumetricLightEnable = KuroVolumetricLightEnable;
			this.KuroVolumetricLightIntensity = KuroVolumetricLightIntensity;
			this.KuroVolumetricLightColor = KuroVolumetricLightColor;
			this.KuroVolumetricLightPhaseG = KuroVolumetricLightPhaseG;
			this.KuroVolumetricLightMaxDistance = KuroVolumetricLightMaxDistance;
			this.SSFSIntensity = SSFSIntensity;
			this.SSFSRadius = SSFSRadius;
			this.SSFSLuminanceWeighting = SSFSLuminanceWeighting;
			this.SSFSVolumetricFogILSIntensity = SSFSVolumetricFogILSIntensity;
			this.SSFSStartDistance = SSFSStartDistance;
			this.EnableMobileSSFS = EnableMobileSSFS;
			this.MobileSSFSFogDensity = MobileSSFSFogDensity;
			this.MobileSSFSIntensity = MobileSSFSIntensity;
			this.MobileSSFSRadius = MobileSSFSRadius;
			this.MobileSSFSStartDistance = MobileSSFSStartDistance;
			this.TyndallScaLightIntensity = TyndallScaLightIntensity;
			this.TyndallDarkIntensity = TyndallDarkIntensity;
			this.TyndallScaLightLength = TyndallScaLightLength;
			this.TyndallScaLightColor = TyndallScaLightColor;
			this.TyndallScaLightFade = TyndallScaLightFade;
			this.TyndallScaLightMode = TyndallScaLightMode;
			this.TyndallScaNearFade = TyndallScaNearFade;
			this.TyndallScaDarkFadeDepth = TyndallScaDarkFadeDepth;
			this.TyndallScaMaxDepth = TyndallScaMaxDepth;
			this.KuroSharpenRadius = KuroSharpenRadius;
			this.KuroSharpenAmount = KuroSharpenAmount;
			this.KuroLaplacianAmount = KuroLaplacianAmount;
			this.KuroSharpenIntensity = KuroSharpenIntensity;
			this.KuroToonSharpenIntensity = KuroToonSharpenIntensity;
			this.KuroSharpenDistance = KuroSharpenDistance;
			this.LocalExposureHighlightContrastScale = LocalExposureHighlightContrastScale;
			this.LocalExposureShadowContrastScale = LocalExposureShadowContrastScale;
			this.LocalExposureHighlightThreshold = LocalExposureHighlightThreshold;
			this.LocalExposureShadowThreshold = LocalExposureShadowThreshold;
			this.LumenLocalExposureHighlightContrastScale = LumenLocalExposureHighlightContrastScale;
			this.LumenLocalExposureShadowContrastScale = LumenLocalExposureShadowContrastScale;
			this.LumenLocalExposureHighlightThreshold = LumenLocalExposureHighlightThreshold;
			this.LumenLocalExposureShadowThreshold = LumenLocalExposureShadowThreshold;
			this.IndirectLightingColor = IndirectLightingColor;
			this.IndirectLightingIntensity = IndirectLightingIntensity;
		}

		// Token: 0x0601AD8D RID: 109965 RVA: 0x00279754 File Offset: 0x00277954
		protected override IntPtr GetUStructPtr()
		{
			return FKuroPostProcessSetting.StaticStruct();
		}

		// Token: 0x0601AD8E RID: 109966 RVA: 0x00279760 File Offset: 0x00277960
		public FKuroPostProcessSetting(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x0601AD8F RID: 109967 RVA: 0x0027976A File Offset: 0x0027796A
		public FKuroPostProcessSetting(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x0601AD90 RID: 109968 RVA: 0x00279775 File Offset: 0x00277975
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroPostProcessSetting(Pointer, false, true);
		}

		// Token: 0x0601AD91 RID: 109969 RVA: 0x0027977F File Offset: 0x0027797F
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroPostProcessSetting(Pointer, MemoryOwner);
		}

		// Token: 0x0400E7BD RID: 59325
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRenderingRuntimeBPPlugin.KuroPostProcessSetting";

		// Token: 0x0400E7BE RID: 59326
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400E7BF RID: 59327
		internal static int __PropertyOffset_bOverride_KuroBloomIntensity;

		// Token: 0x0400E7C0 RID: 59328
		internal static byte __PropertyMask_bOverride_KuroBloomIntensity;

		// Token: 0x0400E7C1 RID: 59329
		internal static int __PropertyOffset_bOverride_LumenKuroBloomIntensityOffset;

		// Token: 0x0400E7C2 RID: 59330
		internal static byte __PropertyMask_bOverride_LumenKuroBloomIntensityOffset;

		// Token: 0x0400E7C3 RID: 59331
		internal static int __PropertyOffset_bOverride_KuroBloomThreshold;

		// Token: 0x0400E7C4 RID: 59332
		internal static byte __PropertyMask_bOverride_KuroBloomThreshold;

		// Token: 0x0400E7C5 RID: 59333
		internal static int __PropertyOffset_bOverride_EnableSplitCharBloom;

		// Token: 0x0400E7C6 RID: 59334
		internal static byte __PropertyMask_bOverride_EnableSplitCharBloom;

		// Token: 0x0400E7C7 RID: 59335
		internal static int __PropertyOffset_bOverride_KuroCharacterBloomIntensity;

		// Token: 0x0400E7C8 RID: 59336
		internal static byte __PropertyMask_bOverride_KuroCharacterBloomIntensity;

		// Token: 0x0400E7C9 RID: 59337
		internal static int __PropertyOffset_bOverride_KuroCharacterBloomThreshold;

		// Token: 0x0400E7CA RID: 59338
		internal static byte __PropertyMask_bOverride_KuroCharacterBloomThreshold;

		// Token: 0x0400E7CB RID: 59339
		internal static int __PropertyOffset_bOverride_SunDirBloomIntensity;

		// Token: 0x0400E7CC RID: 59340
		internal static byte __PropertyMask_bOverride_SunDirBloomIntensity;

		// Token: 0x0400E7CD RID: 59341
		internal static int __PropertyOffset_bOverride_KuroBloomStreakIntensity;

		// Token: 0x0400E7CE RID: 59342
		internal static byte __PropertyMask_bOverride_KuroBloomStreakIntensity;

		// Token: 0x0400E7CF RID: 59343
		internal static int __PropertyOffset_bOverride_KuroBloomStreakThreshold;

		// Token: 0x0400E7D0 RID: 59344
		internal static byte __PropertyMask_bOverride_KuroBloomStreakThreshold;

		// Token: 0x0400E7D1 RID: 59345
		internal static int __PropertyOffset_bOverride_TranslucentBloomStreakIntensity;

		// Token: 0x0400E7D2 RID: 59346
		internal static byte __PropertyMask_bOverride_TranslucentBloomStreakIntensity;

		// Token: 0x0400E7D3 RID: 59347
		internal static int __PropertyOffset_bOverride_TranslucentBloomStreakThreshold;

		// Token: 0x0400E7D4 RID: 59348
		internal static byte __PropertyMask_bOverride_TranslucentBloomStreakThreshold;

		// Token: 0x0400E7D5 RID: 59349
		internal static int __PropertyOffset_bOverride_KuroBloomStreakLength;

		// Token: 0x0400E7D6 RID: 59350
		internal static byte __PropertyMask_bOverride_KuroBloomStreakLength;

		// Token: 0x0400E7D7 RID: 59351
		internal static int __PropertyOffset_bOverride_KuroBloomStreakMipLevel;

		// Token: 0x0400E7D8 RID: 59352
		internal static byte __PropertyMask_bOverride_KuroBloomStreakMipLevel;

		// Token: 0x0400E7D9 RID: 59353
		internal static int __PropertyOffset_bOverride_KuroBloomStreakRatio;

		// Token: 0x0400E7DA RID: 59354
		internal static byte __PropertyMask_bOverride_KuroBloomStreakRatio;

		// Token: 0x0400E7DB RID: 59355
		internal static int __PropertyOffset_bOverride_KuroBloomStreakOrientation;

		// Token: 0x0400E7DC RID: 59356
		internal static byte __PropertyMask_bOverride_KuroBloomStreakOrientation;

		// Token: 0x0400E7DD RID: 59357
		internal static int __PropertyOffset_bOverride_SceneColorDesaturate;

		// Token: 0x0400E7DE RID: 59358
		internal static byte __PropertyMask_bOverride_SceneColorDesaturate;

		// Token: 0x0400E7DF RID: 59359
		internal static int __PropertyOffset_bOverride_DecalSaturation;

		// Token: 0x0400E7E0 RID: 59360
		internal static byte __PropertyMask_bOverride_DecalSaturation;

		// Token: 0x0400E7E1 RID: 59361
		internal static int __PropertyOffset_bOverride_DecalOpacity;

		// Token: 0x0400E7E2 RID: 59362
		internal static byte __PropertyMask_bOverride_DecalOpacity;

		// Token: 0x0400E7E3 RID: 59363
		internal static int __PropertyOffset_bOverride_ColorGradingIntensity;

		// Token: 0x0400E7E4 RID: 59364
		internal static byte __PropertyMask_bOverride_ColorGradingIntensity;

		// Token: 0x0400E7E5 RID: 59365
		internal static int __PropertyOffset_bOverride_ColorGradingLUT;

		// Token: 0x0400E7E6 RID: 59366
		internal static byte __PropertyMask_bOverride_ColorGradingLUT;

		// Token: 0x0400E7E7 RID: 59367
		internal static int __PropertyOffset_bOverride_AutoExposureDayBias;

		// Token: 0x0400E7E8 RID: 59368
		internal static byte __PropertyMask_bOverride_AutoExposureDayBias;

		// Token: 0x0400E7E9 RID: 59369
		internal static int __PropertyOffset_bOverride_AutoExposureNightBias;

		// Token: 0x0400E7EA RID: 59370
		internal static byte __PropertyMask_bOverride_AutoExposureNightBias;

		// Token: 0x0400E7EB RID: 59371
		internal static int __PropertyOffset_bOverride_LumenAutoExposureDayBias;

		// Token: 0x0400E7EC RID: 59372
		internal static byte __PropertyMask_bOverride_LumenAutoExposureDayBias;

		// Token: 0x0400E7ED RID: 59373
		internal static int __PropertyOffset_bOverride_LumenAutoExposureNightBias;

		// Token: 0x0400E7EE RID: 59374
		internal static byte __PropertyMask_bOverride_LumenAutoExposureNightBias;

		// Token: 0x0400E7EF RID: 59375
		internal static int __PropertyOffset_bOverride_KuroCharacterLUTSplitEnable;

		// Token: 0x0400E7F0 RID: 59376
		internal static byte __PropertyMask_bOverride_KuroCharacterLUTSplitEnable;

		// Token: 0x0400E7F1 RID: 59377
		internal static int __PropertyOffset_bOverride_KuroCharacterColorGradingLUT;

		// Token: 0x0400E7F2 RID: 59378
		internal static byte __PropertyMask_bOverride_KuroCharacterColorGradingLUT;

		// Token: 0x0400E7F3 RID: 59379
		internal static int __PropertyOffset_bOverride_KuroCharacterColorGradingLUTLerpIntensity;

		// Token: 0x0400E7F4 RID: 59380
		internal static byte __PropertyMask_bOverride_KuroCharacterColorGradingLUTLerpIntensity;

		// Token: 0x0400E7F5 RID: 59381
		internal static int __PropertyOffset_bOverride_KuroColorGradingTextureLUTInterpolationEnable;

		// Token: 0x0400E7F6 RID: 59382
		internal static byte __PropertyMask_bOverride_KuroColorGradingTextureLUTInterpolationEnable;

		// Token: 0x0400E7F7 RID: 59383
		internal static int __PropertyOffset_bOverride_LightFadeScale;

		// Token: 0x0400E7F8 RID: 59384
		internal static byte __PropertyMask_bOverride_LightFadeScale;

		// Token: 0x0400E7F9 RID: 59385
		internal static int __PropertyOffset_bOverride_KuroVolumetricLightEnable;

		// Token: 0x0400E7FA RID: 59386
		internal static byte __PropertyMask_bOverride_KuroVolumetricLightEnable;

		// Token: 0x0400E7FB RID: 59387
		internal static int __PropertyOffset_bOverride_KuroVolumetricLightIntensity;

		// Token: 0x0400E7FC RID: 59388
		internal static byte __PropertyMask_bOverride_KuroVolumetricLightIntensity;

		// Token: 0x0400E7FD RID: 59389
		internal static int __PropertyOffset_bOverride_KuroVolumetricLightColor;

		// Token: 0x0400E7FE RID: 59390
		internal static byte __PropertyMask_bOverride_KuroVolumetricLightColor;

		// Token: 0x0400E7FF RID: 59391
		internal static int __PropertyOffset_bOverride_KuroVolumetricLightPhaseG;

		// Token: 0x0400E800 RID: 59392
		internal static byte __PropertyMask_bOverride_KuroVolumetricLightPhaseG;

		// Token: 0x0400E801 RID: 59393
		internal static int __PropertyOffset_bOverride_KuroVolumetricLightMaxDistance;

		// Token: 0x0400E802 RID: 59394
		internal static byte __PropertyMask_bOverride_KuroVolumetricLightMaxDistance;

		// Token: 0x0400E803 RID: 59395
		internal static int __PropertyOffset_bOverride_SSFSIntensity;

		// Token: 0x0400E804 RID: 59396
		internal static byte __PropertyMask_bOverride_SSFSIntensity;

		// Token: 0x0400E805 RID: 59397
		internal static int __PropertyOffset_bOverride_SSFSRadius;

		// Token: 0x0400E806 RID: 59398
		internal static byte __PropertyMask_bOverride_SSFSRadius;

		// Token: 0x0400E807 RID: 59399
		internal static int __PropertyOffset_bOverride_SSFSLuminanceWeighting;

		// Token: 0x0400E808 RID: 59400
		internal static byte __PropertyMask_bOverride_SSFSLuminanceWeighting;

		// Token: 0x0400E809 RID: 59401
		internal static int __PropertyOffset_bOverride_SSFSVolumetricFogILSIntensity;

		// Token: 0x0400E80A RID: 59402
		internal static byte __PropertyMask_bOverride_SSFSVolumetricFogILSIntensity;

		// Token: 0x0400E80B RID: 59403
		internal static int __PropertyOffset_bOverride_SSFSStartDistance;

		// Token: 0x0400E80C RID: 59404
		internal static byte __PropertyMask_bOverride_SSFSStartDistance;

		// Token: 0x0400E80D RID: 59405
		internal static int __PropertyOffset_bOverride_EnableMobileSSFS;

		// Token: 0x0400E80E RID: 59406
		internal static byte __PropertyMask_bOverride_EnableMobileSSFS;

		// Token: 0x0400E80F RID: 59407
		internal static int __PropertyOffset_bOverride_MobileSSFSFogDensity;

		// Token: 0x0400E810 RID: 59408
		internal static byte __PropertyMask_bOverride_MobileSSFSFogDensity;

		// Token: 0x0400E811 RID: 59409
		internal static int __PropertyOffset_bOverride_MobileSSFSIntensity;

		// Token: 0x0400E812 RID: 59410
		internal static byte __PropertyMask_bOverride_MobileSSFSIntensity;

		// Token: 0x0400E813 RID: 59411
		internal static int __PropertyOffset_bOverride_MobileSSFSRadius;

		// Token: 0x0400E814 RID: 59412
		internal static byte __PropertyMask_bOverride_MobileSSFSRadius;

		// Token: 0x0400E815 RID: 59413
		internal static int __PropertyOffset_bOverride_MobileSSFSStartDistance;

		// Token: 0x0400E816 RID: 59414
		internal static byte __PropertyMask_bOverride_MobileSSFSStartDistance;

		// Token: 0x0400E817 RID: 59415
		internal static int __PropertyOffset_bOverride_TyndallScaLightIntensity;

		// Token: 0x0400E818 RID: 59416
		internal static byte __PropertyMask_bOverride_TyndallScaLightIntensity;

		// Token: 0x0400E819 RID: 59417
		internal static int __PropertyOffset_bOverride_TyndallDarkIntensity;

		// Token: 0x0400E81A RID: 59418
		internal static byte __PropertyMask_bOverride_TyndallDarkIntensity;

		// Token: 0x0400E81B RID: 59419
		internal static int __PropertyOffset_bOverride_TyndallScaLightLength;

		// Token: 0x0400E81C RID: 59420
		internal static byte __PropertyMask_bOverride_TyndallScaLightLength;

		// Token: 0x0400E81D RID: 59421
		internal static int __PropertyOffset_bOverride_TyndallScaLightColor;

		// Token: 0x0400E81E RID: 59422
		internal static byte __PropertyMask_bOverride_TyndallScaLightColor;

		// Token: 0x0400E81F RID: 59423
		internal static int __PropertyOffset_bOverride_TyndallScaLightFade;

		// Token: 0x0400E820 RID: 59424
		internal static byte __PropertyMask_bOverride_TyndallScaLightFade;

		// Token: 0x0400E821 RID: 59425
		internal static int __PropertyOffset_bOverride_TyndallScaLightMode;

		// Token: 0x0400E822 RID: 59426
		internal static byte __PropertyMask_bOverride_TyndallScaLightMode;

		// Token: 0x0400E823 RID: 59427
		internal static int __PropertyOffset_bOverride_TyndallScaNearFade;

		// Token: 0x0400E824 RID: 59428
		internal static byte __PropertyMask_bOverride_TyndallScaNearFade;

		// Token: 0x0400E825 RID: 59429
		internal static int __PropertyOffset_bOverride_TyndallScaDarkFadeDepth;

		// Token: 0x0400E826 RID: 59430
		internal static byte __PropertyMask_bOverride_TyndallScaDarkFadeDepth;

		// Token: 0x0400E827 RID: 59431
		internal static int __PropertyOffset_bOverride_TyndallScaMaxDepth;

		// Token: 0x0400E828 RID: 59432
		internal static byte __PropertyMask_bOverride_TyndallScaMaxDepth;

		// Token: 0x0400E829 RID: 59433
		internal static int __PropertyOffset_bOverride_KuroSharpenRadius;

		// Token: 0x0400E82A RID: 59434
		internal static byte __PropertyMask_bOverride_KuroSharpenRadius;

		// Token: 0x0400E82B RID: 59435
		internal static int __PropertyOffset_bOverride_KuroSharpenAmount;

		// Token: 0x0400E82C RID: 59436
		internal static byte __PropertyMask_bOverride_KuroSharpenAmount;

		// Token: 0x0400E82D RID: 59437
		internal static int __PropertyOffset_bOverride_KuroLaplacianAmount;

		// Token: 0x0400E82E RID: 59438
		internal static byte __PropertyMask_bOverride_KuroLaplacianAmount;

		// Token: 0x0400E82F RID: 59439
		internal static int __PropertyOffset_bOverride_KuroSharpenIntensity;

		// Token: 0x0400E830 RID: 59440
		internal static byte __PropertyMask_bOverride_KuroSharpenIntensity;

		// Token: 0x0400E831 RID: 59441
		internal static int __PropertyOffset_bOverride_KuroToonSharpenIntensity;

		// Token: 0x0400E832 RID: 59442
		internal static byte __PropertyMask_bOverride_KuroToonSharpenIntensity;

		// Token: 0x0400E833 RID: 59443
		internal static int __PropertyOffset_bOverride_KuroSharpenDistance;

		// Token: 0x0400E834 RID: 59444
		internal static byte __PropertyMask_bOverride_KuroSharpenDistance;

		// Token: 0x0400E835 RID: 59445
		internal static int __PropertyOffset_bOverride_LocalExposureHighlightContrastScale;

		// Token: 0x0400E836 RID: 59446
		internal static byte __PropertyMask_bOverride_LocalExposureHighlightContrastScale;

		// Token: 0x0400E837 RID: 59447
		internal static int __PropertyOffset_bOverride_LocalExposureShadowContrastScale;

		// Token: 0x0400E838 RID: 59448
		internal static byte __PropertyMask_bOverride_LocalExposureShadowContrastScale;

		// Token: 0x0400E839 RID: 59449
		internal static int __PropertyOffset_bOverride_LocalExposureHighlightThreshold;

		// Token: 0x0400E83A RID: 59450
		internal static byte __PropertyMask_bOverride_LocalExposureHighlightThreshold;

		// Token: 0x0400E83B RID: 59451
		internal static int __PropertyOffset_bOverride_LocalExposureShadowThreshold;

		// Token: 0x0400E83C RID: 59452
		internal static byte __PropertyMask_bOverride_LocalExposureShadowThreshold;

		// Token: 0x0400E83D RID: 59453
		internal static int __PropertyOffset_bOverride_LumenLocalExposureHighlightContrastScale;

		// Token: 0x0400E83E RID: 59454
		internal static byte __PropertyMask_bOverride_LumenLocalExposureHighlightContrastScale;

		// Token: 0x0400E83F RID: 59455
		internal static int __PropertyOffset_bOverride_LumenLocalExposureShadowContrastScale;

		// Token: 0x0400E840 RID: 59456
		internal static byte __PropertyMask_bOverride_LumenLocalExposureShadowContrastScale;

		// Token: 0x0400E841 RID: 59457
		internal static int __PropertyOffset_bOverride_LumenLocalExposureHighlightThreshold;

		// Token: 0x0400E842 RID: 59458
		internal static byte __PropertyMask_bOverride_LumenLocalExposureHighlightThreshold;

		// Token: 0x0400E843 RID: 59459
		internal static int __PropertyOffset_bOverride_LumenLocalExposureShadowThreshold;

		// Token: 0x0400E844 RID: 59460
		internal static byte __PropertyMask_bOverride_LumenLocalExposureShadowThreshold;

		// Token: 0x0400E845 RID: 59461
		internal static int __PropertyOffset_bOverride_IndirectLightingIntensity;

		// Token: 0x0400E846 RID: 59462
		internal static byte __PropertyMask_bOverride_IndirectLightingIntensity;

		// Token: 0x0400E847 RID: 59463
		internal static int __PropertyOffset_bOverride_IndirectLightingColor;

		// Token: 0x0400E848 RID: 59464
		internal static byte __PropertyMask_bOverride_IndirectLightingColor;

		// Token: 0x0400E849 RID: 59465
		internal static int __PropertyOffset_KuroBloomIntensity;

		// Token: 0x0400E84A RID: 59466
		internal static int __PropertyOffset_LumenKuroBloomIntensityOffset;

		// Token: 0x0400E84B RID: 59467
		internal static int __PropertyOffset_KuroBloomThreshold;

		// Token: 0x0400E84C RID: 59468
		internal static int __PropertyOffset_EnableSplitCharBloom;

		// Token: 0x0400E84D RID: 59469
		internal static byte __PropertyMask_EnableSplitCharBloom;

		// Token: 0x0400E84E RID: 59470
		internal static int __PropertyOffset_KuroCharacterBloomIntensity;

		// Token: 0x0400E84F RID: 59471
		internal static int __PropertyOffset_KuroCharacterBloomThreshold;

		// Token: 0x0400E850 RID: 59472
		internal static int __PropertyOffset_SunDirBloomIntensity;

		// Token: 0x0400E851 RID: 59473
		internal static int __PropertyOffset_KuroBloomStreakIntensity;

		// Token: 0x0400E852 RID: 59474
		internal static int __PropertyOffset_KuroBloomStreakThreshold;

		// Token: 0x0400E853 RID: 59475
		internal static int __PropertyOffset_TranslucentBloomStreakIntensity;

		// Token: 0x0400E854 RID: 59476
		internal static int __PropertyOffset_TranslucentBloomStreakThreshold;

		// Token: 0x0400E855 RID: 59477
		internal static int __PropertyOffset_KuroBloomStreakLength;

		// Token: 0x0400E856 RID: 59478
		internal static int __PropertyOffset_KuroBloomStreakMipLevel;

		// Token: 0x0400E857 RID: 59479
		internal static int __PropertyOffset_KuroBloomStreakRatio;

		// Token: 0x0400E858 RID: 59480
		internal static int __PropertyOffset_KuroBloomStreakOrientation;

		// Token: 0x0400E859 RID: 59481
		internal static int __PropertyOffset_SceneColorDesaturate;

		// Token: 0x0400E85A RID: 59482
		internal static int __PropertyOffset_DecalSaturation;

		// Token: 0x0400E85B RID: 59483
		internal static int __PropertyOffset_DecalOpacity;

		// Token: 0x0400E85C RID: 59484
		internal static int __PropertyOffset_ColorGradingIntensity;

		// Token: 0x0400E85D RID: 59485
		internal static int __PropertyOffset_ColorGradingLUT;

		// Token: 0x0400E85E RID: 59486
		internal static int __PropertyOffset_AutoExposureDayBias;

		// Token: 0x0400E85F RID: 59487
		internal static int __PropertyOffset_AutoExposureNightBias;

		// Token: 0x0400E860 RID: 59488
		internal static int __PropertyOffset_LumenAutoExposureDayBias;

		// Token: 0x0400E861 RID: 59489
		internal static int __PropertyOffset_LumenAutoExposureNightBias;

		// Token: 0x0400E862 RID: 59490
		internal static int __PropertyOffset_KuroCharacterLUTSplitEnable;

		// Token: 0x0400E863 RID: 59491
		internal static int __PropertyOffset_KuroCharacterColorGradingLUT;

		// Token: 0x0400E864 RID: 59492
		internal static int __PropertyOffset_KuroCharacterColorGradingLUTLerpIntensity;

		// Token: 0x0400E865 RID: 59493
		internal static int __PropertyOffset_KuroColorGradingTextureLUTInterpolationEnable;

		// Token: 0x0400E866 RID: 59494
		internal static int __PropertyOffset_LightFadeScale;

		// Token: 0x0400E867 RID: 59495
		internal static int __PropertyOffset_KuroVolumetricLightEnable;

		// Token: 0x0400E868 RID: 59496
		internal static int __PropertyOffset_KuroVolumetricLightIntensity;

		// Token: 0x0400E869 RID: 59497
		internal static int __PropertyOffset_KuroVolumetricLightColor;

		// Token: 0x0400E86A RID: 59498
		internal static int __PropertyOffset_KuroVolumetricLightPhaseG;

		// Token: 0x0400E86B RID: 59499
		internal static int __PropertyOffset_KuroVolumetricLightMaxDistance;

		// Token: 0x0400E86C RID: 59500
		internal static int __PropertyOffset_SSFSIntensity;

		// Token: 0x0400E86D RID: 59501
		internal static int __PropertyOffset_SSFSRadius;

		// Token: 0x0400E86E RID: 59502
		internal static int __PropertyOffset_SSFSLuminanceWeighting;

		// Token: 0x0400E86F RID: 59503
		internal static int __PropertyOffset_SSFSVolumetricFogILSIntensity;

		// Token: 0x0400E870 RID: 59504
		internal static int __PropertyOffset_SSFSStartDistance;

		// Token: 0x0400E871 RID: 59505
		internal static int __PropertyOffset_EnableMobileSSFS;

		// Token: 0x0400E872 RID: 59506
		internal static int __PropertyOffset_MobileSSFSFogDensity;

		// Token: 0x0400E873 RID: 59507
		internal static int __PropertyOffset_MobileSSFSIntensity;

		// Token: 0x0400E874 RID: 59508
		internal static int __PropertyOffset_MobileSSFSRadius;

		// Token: 0x0400E875 RID: 59509
		internal static int __PropertyOffset_MobileSSFSStartDistance;

		// Token: 0x0400E876 RID: 59510
		internal static int __PropertyOffset_TyndallScaLightIntensity;

		// Token: 0x0400E877 RID: 59511
		internal static int __PropertyOffset_TyndallDarkIntensity;

		// Token: 0x0400E878 RID: 59512
		internal static int __PropertyOffset_TyndallScaLightLength;

		// Token: 0x0400E879 RID: 59513
		internal static int __PropertyOffset_TyndallScaLightColor;

		// Token: 0x0400E87A RID: 59514
		internal static int __PropertyOffset_TyndallScaLightFade;

		// Token: 0x0400E87B RID: 59515
		internal static int __PropertyOffset_TyndallScaLightMode;

		// Token: 0x0400E87C RID: 59516
		internal static int __PropertyOffset_TyndallScaNearFade;

		// Token: 0x0400E87D RID: 59517
		internal static int __PropertyOffset_TyndallScaDarkFadeDepth;

		// Token: 0x0400E87E RID: 59518
		internal static int __PropertyOffset_TyndallScaMaxDepth;

		// Token: 0x0400E87F RID: 59519
		internal static int __PropertyOffset_KuroSharpenRadius;

		// Token: 0x0400E880 RID: 59520
		internal static int __PropertyOffset_KuroSharpenAmount;

		// Token: 0x0400E881 RID: 59521
		internal static int __PropertyOffset_KuroLaplacianAmount;

		// Token: 0x0400E882 RID: 59522
		internal static int __PropertyOffset_KuroSharpenIntensity;

		// Token: 0x0400E883 RID: 59523
		internal static int __PropertyOffset_KuroToonSharpenIntensity;

		// Token: 0x0400E884 RID: 59524
		internal static int __PropertyOffset_KuroSharpenDistance;

		// Token: 0x0400E885 RID: 59525
		internal static int __PropertyOffset_LocalExposureHighlightContrastScale;

		// Token: 0x0400E886 RID: 59526
		internal static int __PropertyOffset_LocalExposureShadowContrastScale;

		// Token: 0x0400E887 RID: 59527
		internal static int __PropertyOffset_LocalExposureHighlightThreshold;

		// Token: 0x0400E888 RID: 59528
		internal static int __PropertyOffset_LocalExposureShadowThreshold;

		// Token: 0x0400E889 RID: 59529
		internal static int __PropertyOffset_LumenLocalExposureHighlightContrastScale;

		// Token: 0x0400E88A RID: 59530
		internal static int __PropertyOffset_LumenLocalExposureShadowContrastScale;

		// Token: 0x0400E88B RID: 59531
		internal static int __PropertyOffset_LumenLocalExposureHighlightThreshold;

		// Token: 0x0400E88C RID: 59532
		internal static int __PropertyOffset_LumenLocalExposureShadowThreshold;

		// Token: 0x0400E88D RID: 59533
		internal static int __PropertyOffset_IndirectLightingColor;

		// Token: 0x0400E88E RID: 59534
		internal static int __PropertyOffset_IndirectLightingIntensity;
	}
}
