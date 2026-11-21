using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020007AA RID: 1962
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/Niagara.NiagaraSystem")]
	[UnrealStructLayout(2240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 2240)]
	public class UNiagaraSystem : UFXSystemAsset, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600AA7E RID: 43646 RVA: 0x000FB759 File Offset: 0x000F9959
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UNiagaraSystem._ClassPtr;
		}

		// Token: 0x0600AA7F RID: 43647 RVA: 0x000FB768 File Offset: 0x000F9968
		public UNiagaraSystem() : this(BuiltinUtils.AllocNativeUObject(UNiagaraSystem.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600AA80 RID: 43648 RVA: 0x000FB790 File Offset: 0x000F9990
		[NullableContext(1)]
		public UNiagaraSystem(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UNiagaraSystem.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001FBC RID: 8124
		// (get) Token: 0x0600AA81 RID: 43649 RVA: 0x000FB7C3 File Offset: 0x000F99C3
		// (set) Token: 0x0600AA82 RID: 43650 RVA: 0x000FB7D3 File Offset: 0x000F99D3
		public unsafe bool bDumpDebugSystemInfo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bDumpDebugSystemInfo) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bDumpDebugSystemInfo) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001FBD RID: 8125
		// (get) Token: 0x0600AA83 RID: 43651 RVA: 0x000FB7E4 File Offset: 0x000F99E4
		// (set) Token: 0x0600AA84 RID: 43652 RVA: 0x000FB7F4 File Offset: 0x000F99F4
		public unsafe bool bDumpDebugEmitterInfo
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bDumpDebugEmitterInfo) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bDumpDebugEmitterInfo) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001FBE RID: 8126
		// (get) Token: 0x0600AA85 RID: 43653 RVA: 0x000FB805 File Offset: 0x000F9A05
		// (set) Token: 0x0600AA86 RID: 43654 RVA: 0x000FB815 File Offset: 0x000F9A15
		public unsafe bool bRequireCurrentFrameData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bRequireCurrentFrameData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bRequireCurrentFrameData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001FBF RID: 8127
		// (get) Token: 0x0600AA87 RID: 43655 RVA: 0x000FB826 File Offset: 0x000F9A26
		// (set) Token: 0x0600AA88 RID: 43656 RVA: 0x000FB83F File Offset: 0x000F9A3F
		public unsafe bool bEvenTickWhenPaused
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bEvenTickWhenPaused) & UNiagaraSystem.__PropertyMask_bEvenTickWhenPaused) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bEvenTickWhenPaused) = ((*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bEvenTickWhenPaused) & ~UNiagaraSystem.__PropertyMask_bEvenTickWhenPaused) | (value ? UNiagaraSystem.__PropertyMask_bEvenTickWhenPaused : 0));
			}
		}

		// Token: 0x17001FC0 RID: 8128
		// (get) Token: 0x0600AA89 RID: 43657 RVA: 0x000FB86F File Offset: 0x000F9A6F
		// (set) Token: 0x0600AA8A RID: 43658 RVA: 0x000FB888 File Offset: 0x000F9A88
		public unsafe bool bFixedBounds
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bFixedBounds) & UNiagaraSystem.__PropertyMask_bFixedBounds) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bFixedBounds) = ((*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bFixedBounds) & ~UNiagaraSystem.__PropertyMask_bFixedBounds) | (value ? UNiagaraSystem.__PropertyMask_bFixedBounds : 0));
			}
		}

		// Token: 0x17001FC1 RID: 8129
		// (get) Token: 0x0600AA8B RID: 43659 RVA: 0x000FB8B8 File Offset: 0x000F9AB8
		// (set) Token: 0x0600AA8C RID: 43660 RVA: 0x000FB8D1 File Offset: 0x000F9AD1
		public unsafe bool bDisableExperimentalVM
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bDisableExperimentalVM) & UNiagaraSystem.__PropertyMask_bDisableExperimentalVM) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bDisableExperimentalVM) = ((*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bDisableExperimentalVM) & ~UNiagaraSystem.__PropertyMask_bDisableExperimentalVM) | (value ? UNiagaraSystem.__PropertyMask_bDisableExperimentalVM : 0));
			}
		}

		// Token: 0x17001FC2 RID: 8130
		// (get) Token: 0x0600AA8D RID: 43661 RVA: 0x000FB901 File Offset: 0x000F9B01
		// (set) Token: 0x0600AA8E RID: 43662 RVA: 0x000FB911 File Offset: 0x000F9B11
		public unsafe EKuroNiagaraEffectRegularType EffectRegularType
		{
			get
			{
				return (EKuroNiagaraEffectRegularType)(*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_EffectRegularType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_EffectRegularType) = (byte)value;
			}
		}

		// Token: 0x17001FC3 RID: 8131
		// (get) Token: 0x0600AA8F RID: 43663 RVA: 0x000FB922 File Offset: 0x000F9B22
		// (set) Token: 0x0600AA90 RID: 43664 RVA: 0x000FB936 File Offset: 0x000F9B36
		public unsafe UNiagaraEffectType EffectType
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraEffectType>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSystem.__PropertyOffset_EffectType);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSystem.__PropertyOffset_EffectType, value);
			}
		}

		// Token: 0x17001FC4 RID: 8132
		// (get) Token: 0x0600AA91 RID: 43665 RVA: 0x000FB94B File Offset: 0x000F9B4B
		// (set) Token: 0x0600AA92 RID: 43666 RVA: 0x000FB95F File Offset: 0x000F9B5F
		public unsafe UNiagaraEffectType EffectType_Override
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraEffectType>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSystem.__PropertyOffset_EffectType_Override);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSystem.__PropertyOffset_EffectType_Override, value);
			}
		}

		// Token: 0x17001FC5 RID: 8133
		// (get) Token: 0x0600AA93 RID: 43667 RVA: 0x000FB974 File Offset: 0x000F9B74
		// (set) Token: 0x0600AA94 RID: 43668 RVA: 0x000FB984 File Offset: 0x000F9B84
		public unsafe bool bOverrideScreenSizeCullRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bOverrideScreenSizeCullRatio) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bOverrideScreenSizeCullRatio) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001FC6 RID: 8134
		// (get) Token: 0x0600AA95 RID: 43669 RVA: 0x000FB995 File Offset: 0x000F9B95
		// (set) Token: 0x0600AA96 RID: 43670 RVA: 0x000FB9A5 File Offset: 0x000F9BA5
		public unsafe float ScreenSizeCullRatio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_ScreenSizeCullRatio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_ScreenSizeCullRatio) = value;
			}
		}

		// Token: 0x17001FC7 RID: 8135
		// (get) Token: 0x0600AA97 RID: 43671 RVA: 0x000FB9B6 File Offset: 0x000F9BB6
		// (set) Token: 0x0600AA98 RID: 43672 RVA: 0x000FB9C6 File Offset: 0x000F9BC6
		public unsafe bool bUseNDCBatch
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bUseNDCBatch) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bUseNDCBatch) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001FC8 RID: 8136
		// (get) Token: 0x0600AA99 RID: 43673 RVA: 0x000FB9D7 File Offset: 0x000F9BD7
		// (set) Token: 0x0600AA9A RID: 43674 RVA: 0x000FB9EB File Offset: 0x000F9BEB
		public unsafe UNiagaraDataChannelAsset DataChannel
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraDataChannelAsset>(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSystem.__PropertyOffset_DataChannel);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UNiagaraSystem.__PropertyOffset_DataChannel, value);
			}
		}

		// Token: 0x17001FC9 RID: 8137
		// (get) Token: 0x0600AA9B RID: 43675 RVA: 0x000FBA00 File Offset: 0x000F9C00
		// (set) Token: 0x0600AA9C RID: 43676 RVA: 0x000FBA10 File Offset: 0x000F9C10
		public unsafe int BatchLimitNum
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_BatchLimitNum);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_BatchLimitNum) = value;
			}
		}

		// Token: 0x17001FCA RID: 8138
		// (get) Token: 0x0600AA9D RID: 43677 RVA: 0x000FBA21 File Offset: 0x000F9C21
		// (set) Token: 0x0600AA9E RID: 43678 RVA: 0x000FBA31 File Offset: 0x000F9C31
		public unsafe bool bOverrideMaxVisibleCullDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bOverrideMaxVisibleCullDeltaTime) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bOverrideMaxVisibleCullDeltaTime) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001FCB RID: 8139
		// (get) Token: 0x0600AA9F RID: 43679 RVA: 0x000FBA42 File Offset: 0x000F9C42
		// (set) Token: 0x0600AAA0 RID: 43680 RVA: 0x000FBA52 File Offset: 0x000F9C52
		public unsafe float MaxVisibleCullDeltaTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_MaxVisibleCullDeltaTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_MaxVisibleCullDeltaTime) = value;
			}
		}

		// Token: 0x17001FCC RID: 8140
		// (get) Token: 0x0600AAA1 RID: 43681 RVA: 0x000FBA63 File Offset: 0x000F9C63
		// (set) Token: 0x0600AAA2 RID: 43682 RVA: 0x000FBA73 File Offset: 0x000F9C73
		public unsafe bool bOverrideScalabilitySettings
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bOverrideScalabilitySettings) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bOverrideScalabilitySettings) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001FCD RID: 8141
		// (get) Token: 0x0600AAA3 RID: 43683 RVA: 0x000FBA84 File Offset: 0x000F9C84
		// (set) Token: 0x0600AAA4 RID: 43684 RVA: 0x000FBA98 File Offset: 0x000F9C98
		public unsafe FBox FixedBounds
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_FixedBounds);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_FixedBounds) = value;
			}
		}

		// Token: 0x17001FCE RID: 8142
		// (get) Token: 0x0600AAA5 RID: 43685 RVA: 0x000FBAAD File Offset: 0x000F9CAD
		// (set) Token: 0x0600AAA6 RID: 43686 RVA: 0x000FBABD File Offset: 0x000F9CBD
		public unsafe bool bAutoDeactivate
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bAutoDeactivate) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bAutoDeactivate) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001FCF RID: 8143
		// (get) Token: 0x0600AAA7 RID: 43687 RVA: 0x000FBACE File Offset: 0x000F9CCE
		// (set) Token: 0x0600AAA8 RID: 43688 RVA: 0x000FBADE File Offset: 0x000F9CDE
		public unsafe bool bEnableWarmup
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bEnableWarmup) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bEnableWarmup) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001FD0 RID: 8144
		// (get) Token: 0x0600AAA9 RID: 43689 RVA: 0x000FBAEF File Offset: 0x000F9CEF
		// (set) Token: 0x0600AAAA RID: 43690 RVA: 0x000FBB03 File Offset: 0x000F9D03
		public unsafe FName WarmupTimeScaleParameter
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_WarmupTimeScaleParameter);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_WarmupTimeScaleParameter) = value;
			}
		}

		// Token: 0x17001FD1 RID: 8145
		// (get) Token: 0x0600AAAB RID: 43691 RVA: 0x000FBB18 File Offset: 0x000F9D18
		// (set) Token: 0x0600AAAC RID: 43692 RVA: 0x000FBB28 File Offset: 0x000F9D28
		public unsafe float WarmupTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_WarmupTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_WarmupTime) = value;
			}
		}

		// Token: 0x17001FD2 RID: 8146
		// (get) Token: 0x0600AAAD RID: 43693 RVA: 0x000FBB39 File Offset: 0x000F9D39
		// (set) Token: 0x0600AAAE RID: 43694 RVA: 0x000FBB49 File Offset: 0x000F9D49
		public unsafe int WarmupTickCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_WarmupTickCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_WarmupTickCount) = value;
			}
		}

		// Token: 0x17001FD3 RID: 8147
		// (get) Token: 0x0600AAAF RID: 43695 RVA: 0x000FBB5A File Offset: 0x000F9D5A
		// (set) Token: 0x0600AAB0 RID: 43696 RVA: 0x000FBB6A File Offset: 0x000F9D6A
		public unsafe float WarmupTickDelta
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_WarmupTickDelta);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_WarmupTickDelta) = value;
			}
		}

		// Token: 0x17001FD4 RID: 8148
		// (get) Token: 0x0600AAB1 RID: 43697 RVA: 0x000FBB7B File Offset: 0x000F9D7B
		// (set) Token: 0x0600AAB2 RID: 43698 RVA: 0x000FBB8B File Offset: 0x000F9D8B
		public unsafe bool bHasSystemScriptDIsWithPerInstanceData
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bHasSystemScriptDIsWithPerInstanceData) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_bHasSystemScriptDIsWithPerInstanceData) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001FD5 RID: 8149
		// (get) Token: 0x0600AAB3 RID: 43699 RVA: 0x000FBB9C File Offset: 0x000F9D9C
		// (set) Token: 0x0600AAB4 RID: 43700 RVA: 0x000FBBD5 File Offset: 0x000F9DD5
		[Nullable(1)]
		public TArray<FName> UserDINamesReadInSystemScripts
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				TArray<FName> result;
				if ((result = this._UserDINamesReadInSystemScripts) == null)
				{
					result = (this._UserDINamesReadInSystemScripts = new TArray<FName>(base.NativePtr + (IntPtr)UNiagaraSystem.__PropertyOffset_UserDINamesReadInSystemScripts, this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				this.UserDINamesReadInSystemScripts.CopyAssign(value);
			}
		}

		// Token: 0x0600AAB5 RID: 43701 RVA: 0x000FBBE3 File Offset: 0x000F9DE3
		static UNiagaraSystem()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/Niagara.NiagaraSystem");
		}

		// Token: 0x0600AAB6 RID: 43702 RVA: 0x000FBBF1 File Offset: 0x000F9DF1
		protected UNiagaraSystem(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040048FB RID: 18683
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Niagara.NiagaraSystem";

		// Token: 0x040048FC RID: 18684
		private static IntPtr _ClassPtr;

		// Token: 0x040048FD RID: 18685
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040048FE RID: 18686
		internal static int __PropertyOffset_bDumpDebugSystemInfo;

		// Token: 0x040048FF RID: 18687
		internal static int __PropertyOffset_bDumpDebugEmitterInfo;

		// Token: 0x04004900 RID: 18688
		internal static int __PropertyOffset_bRequireCurrentFrameData;

		// Token: 0x04004901 RID: 18689
		internal static int __PropertyOffset_bEvenTickWhenPaused;

		// Token: 0x04004902 RID: 18690
		internal static byte __PropertyMask_bEvenTickWhenPaused;

		// Token: 0x04004903 RID: 18691
		internal static int __PropertyOffset_bFixedBounds;

		// Token: 0x04004904 RID: 18692
		internal static byte __PropertyMask_bFixedBounds;

		// Token: 0x04004905 RID: 18693
		internal static int __PropertyOffset_bDisableExperimentalVM;

		// Token: 0x04004906 RID: 18694
		internal static byte __PropertyMask_bDisableExperimentalVM;

		// Token: 0x04004907 RID: 18695
		internal static int __PropertyOffset_EffectRegularType;

		// Token: 0x04004908 RID: 18696
		internal static int __PropertyOffset_EffectType;

		// Token: 0x04004909 RID: 18697
		internal static int __PropertyOffset_EffectType_Override;

		// Token: 0x0400490A RID: 18698
		internal static int __PropertyOffset_bOverrideScreenSizeCullRatio;

		// Token: 0x0400490B RID: 18699
		internal static int __PropertyOffset_ScreenSizeCullRatio;

		// Token: 0x0400490C RID: 18700
		internal static int __PropertyOffset_bUseNDCBatch;

		// Token: 0x0400490D RID: 18701
		internal static int __PropertyOffset_DataChannel;

		// Token: 0x0400490E RID: 18702
		internal static int __PropertyOffset_BatchLimitNum;

		// Token: 0x0400490F RID: 18703
		internal static int __PropertyOffset_bOverrideMaxVisibleCullDeltaTime;

		// Token: 0x04004910 RID: 18704
		internal static int __PropertyOffset_MaxVisibleCullDeltaTime;

		// Token: 0x04004911 RID: 18705
		internal static int __PropertyOffset_bOverrideScalabilitySettings;

		// Token: 0x04004912 RID: 18706
		internal static int __PropertyOffset_FixedBounds;

		// Token: 0x04004913 RID: 18707
		internal static int __PropertyOffset_bAutoDeactivate;

		// Token: 0x04004914 RID: 18708
		internal static int __PropertyOffset_bEnableWarmup;

		// Token: 0x04004915 RID: 18709
		internal static int __PropertyOffset_WarmupTimeScaleParameter;

		// Token: 0x04004916 RID: 18710
		internal static int __PropertyOffset_WarmupTime;

		// Token: 0x04004917 RID: 18711
		internal static int __PropertyOffset_WarmupTickCount;

		// Token: 0x04004918 RID: 18712
		internal static int __PropertyOffset_WarmupTickDelta;

		// Token: 0x04004919 RID: 18713
		internal static int __PropertyOffset_bHasSystemScriptDIsWithPerInstanceData;

		// Token: 0x0400491A RID: 18714
		internal static int __PropertyOffset_UserDINamesReadInSystemScripts;

		// Token: 0x0400491B RID: 18715
		private TArray<FName> _UserDINamesReadInSystemScripts;
	}
}
