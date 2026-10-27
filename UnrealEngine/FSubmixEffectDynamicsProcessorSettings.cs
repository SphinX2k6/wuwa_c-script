using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200037F RID: 895
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings")]
	[UnrealStructLayout(80, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 80)]
	public class FSubmixEffectDynamicsProcessorSettings : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600311D RID: 12573 RVA: 0x0004BF6F File Offset: 0x0004A16F
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FSubmixEffectDynamicsProcessorSettings._ScriptStructPtr != 0) ? FSubmixEffectDynamicsProcessorSettings._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings", ref FSubmixEffectDynamicsProcessorSettings._ScriptStructPtr);
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x0600311E RID: 12574 RVA: 0x0004BF93 File Offset: 0x0004A193
		// (set) Token: 0x0600311F RID: 12575 RVA: 0x0004BFA3 File Offset: 0x0004A1A3
		public unsafe ESubmixEffectDynamicsProcessorType DynamicsProcessorType
		{
			get
			{
				return (ESubmixEffectDynamicsProcessorType)(*(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_DynamicsProcessorType));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_DynamicsProcessorType) = (byte)value;
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x06003120 RID: 12576 RVA: 0x0004BFB4 File Offset: 0x0004A1B4
		// (set) Token: 0x06003121 RID: 12577 RVA: 0x0004BFC4 File Offset: 0x0004A1C4
		public unsafe ESubmixEffectDynamicsPeakMode PeakMode
		{
			get
			{
				return (ESubmixEffectDynamicsPeakMode)(*(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_PeakMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_PeakMode) = (byte)value;
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x06003122 RID: 12578 RVA: 0x0004BFD5 File Offset: 0x0004A1D5
		// (set) Token: 0x06003123 RID: 12579 RVA: 0x0004BFE5 File Offset: 0x0004A1E5
		public unsafe ESubmixEffectDynamicsChannelLinkMode LinkMode
		{
			get
			{
				return (ESubmixEffectDynamicsChannelLinkMode)(*(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_LinkMode));
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_LinkMode) = (byte)value;
			}
		}

		// Token: 0x17000BF0 RID: 3056
		// (get) Token: 0x06003124 RID: 12580 RVA: 0x0004BFF6 File Offset: 0x0004A1F6
		// (set) Token: 0x06003125 RID: 12581 RVA: 0x0004C006 File Offset: 0x0004A206
		public unsafe float InputGainDb
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_InputGainDb);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_InputGainDb) = value;
			}
		}

		// Token: 0x17000BF1 RID: 3057
		// (get) Token: 0x06003126 RID: 12582 RVA: 0x0004C017 File Offset: 0x0004A217
		// (set) Token: 0x06003127 RID: 12583 RVA: 0x0004C027 File Offset: 0x0004A227
		public unsafe float ThresholdDb
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_ThresholdDb);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_ThresholdDb) = value;
			}
		}

		// Token: 0x17000BF2 RID: 3058
		// (get) Token: 0x06003128 RID: 12584 RVA: 0x0004C038 File Offset: 0x0004A238
		// (set) Token: 0x06003129 RID: 12585 RVA: 0x0004C048 File Offset: 0x0004A248
		public unsafe float Ratio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_Ratio);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_Ratio) = value;
			}
		}

		// Token: 0x17000BF3 RID: 3059
		// (get) Token: 0x0600312A RID: 12586 RVA: 0x0004C059 File Offset: 0x0004A259
		// (set) Token: 0x0600312B RID: 12587 RVA: 0x0004C069 File Offset: 0x0004A269
		public unsafe float KneeBandwidthDb
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_KneeBandwidthDb);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_KneeBandwidthDb) = value;
			}
		}

		// Token: 0x17000BF4 RID: 3060
		// (get) Token: 0x0600312C RID: 12588 RVA: 0x0004C07A File Offset: 0x0004A27A
		// (set) Token: 0x0600312D RID: 12589 RVA: 0x0004C08A File Offset: 0x0004A28A
		public unsafe float LookAheadMsec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_LookAheadMsec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_LookAheadMsec) = value;
			}
		}

		// Token: 0x17000BF5 RID: 3061
		// (get) Token: 0x0600312E RID: 12590 RVA: 0x0004C09B File Offset: 0x0004A29B
		// (set) Token: 0x0600312F RID: 12591 RVA: 0x0004C0AB File Offset: 0x0004A2AB
		public unsafe float AttackTimeMsec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_AttackTimeMsec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_AttackTimeMsec) = value;
			}
		}

		// Token: 0x17000BF6 RID: 3062
		// (get) Token: 0x06003130 RID: 12592 RVA: 0x0004C0BC File Offset: 0x0004A2BC
		// (set) Token: 0x06003131 RID: 12593 RVA: 0x0004C0CC File Offset: 0x0004A2CC
		public unsafe float ReleaseTimeMsec
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_ReleaseTimeMsec);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_ReleaseTimeMsec) = value;
			}
		}

		// Token: 0x17000BF7 RID: 3063
		// (get) Token: 0x06003132 RID: 12594 RVA: 0x0004C0DD File Offset: 0x0004A2DD
		// (set) Token: 0x06003133 RID: 12595 RVA: 0x0004C0F1 File Offset: 0x0004A2F1
		[Nullable(2)]
		public unsafe USoundSubmix ExternalSubmix
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundSubmix>(base.NativePtr / (IntPtr)sizeof(void*) + FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_ExternalSubmix);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_ExternalSubmix, value);
			}
		}

		// Token: 0x17000BF8 RID: 3064
		// (get) Token: 0x06003134 RID: 12596 RVA: 0x0004C106 File Offset: 0x0004A306
		// (set) Token: 0x06003135 RID: 12597 RVA: 0x0004C11F File Offset: 0x0004A31F
		public unsafe bool bChannelLinked_DEPRECATED
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_bChannelLinked_DEPRECATED) & FSubmixEffectDynamicsProcessorSettings.__PropertyMask_bChannelLinked_DEPRECATED) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_bChannelLinked_DEPRECATED) = ((*(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_bChannelLinked_DEPRECATED) & ~FSubmixEffectDynamicsProcessorSettings.__PropertyMask_bChannelLinked_DEPRECATED) | (value ? FSubmixEffectDynamicsProcessorSettings.__PropertyMask_bChannelLinked_DEPRECATED : 0));
			}
		}

		// Token: 0x17000BF9 RID: 3065
		// (get) Token: 0x06003136 RID: 12598 RVA: 0x0004C14F File Offset: 0x0004A34F
		// (set) Token: 0x06003137 RID: 12599 RVA: 0x0004C168 File Offset: 0x0004A368
		public unsafe bool bAnalogMode
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_bAnalogMode) & FSubmixEffectDynamicsProcessorSettings.__PropertyMask_bAnalogMode) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_bAnalogMode) = ((*(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_bAnalogMode) & ~FSubmixEffectDynamicsProcessorSettings.__PropertyMask_bAnalogMode) | (value ? FSubmixEffectDynamicsProcessorSettings.__PropertyMask_bAnalogMode : 0));
			}
		}

		// Token: 0x17000BFA RID: 3066
		// (get) Token: 0x06003138 RID: 12600 RVA: 0x0004C198 File Offset: 0x0004A398
		// (set) Token: 0x06003139 RID: 12601 RVA: 0x0004C1B1 File Offset: 0x0004A3B1
		public unsafe bool bKeyAudition
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_bKeyAudition) & FSubmixEffectDynamicsProcessorSettings.__PropertyMask_bKeyAudition) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_bKeyAudition) = ((*(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_bKeyAudition) & ~FSubmixEffectDynamicsProcessorSettings.__PropertyMask_bKeyAudition) | (value ? FSubmixEffectDynamicsProcessorSettings.__PropertyMask_bKeyAudition : 0));
			}
		}

		// Token: 0x17000BFB RID: 3067
		// (get) Token: 0x0600313A RID: 12602 RVA: 0x0004C1E1 File Offset: 0x0004A3E1
		// (set) Token: 0x0600313B RID: 12603 RVA: 0x0004C1F1 File Offset: 0x0004A3F1
		public unsafe float KeyGainDb
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_KeyGainDb);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_KeyGainDb) = value;
			}
		}

		// Token: 0x17000BFC RID: 3068
		// (get) Token: 0x0600313C RID: 12604 RVA: 0x0004C202 File Offset: 0x0004A402
		// (set) Token: 0x0600313D RID: 12605 RVA: 0x0004C212 File Offset: 0x0004A412
		public unsafe float OutputGainDb
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_OutputGainDb);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_OutputGainDb) = value;
			}
		}

		// Token: 0x17000BFD RID: 3069
		// (get) Token: 0x0600313E RID: 12606 RVA: 0x0004C224 File Offset: 0x0004A424
		// (set) Token: 0x0600313F RID: 12607 RVA: 0x0004C267 File Offset: 0x0004A467
		public FSubmixEffectDynamicProcessorFilterSettings KeyHighshelf
		{
			get
			{
				base.FastCheckIsValid();
				FSubmixEffectDynamicProcessorFilterSettings result;
				if ((result = this._KeyHighshelf) == null)
				{
					result = (this._KeyHighshelf = new FSubmixEffectDynamicProcessorFilterSettings(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_KeyHighshelf, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSubmixEffectDynamicProcessorFilterSettings.StaticStruct(), base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_KeyHighshelf, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x06003140 RID: 12608 RVA: 0x0004C288 File Offset: 0x0004A488
		// (set) Token: 0x06003141 RID: 12609 RVA: 0x0004C2CB File Offset: 0x0004A4CB
		public FSubmixEffectDynamicProcessorFilterSettings KeyLowshelf
		{
			get
			{
				base.FastCheckIsValid();
				FSubmixEffectDynamicProcessorFilterSettings result;
				if ((result = this._KeyLowshelf) == null)
				{
					result = (this._KeyLowshelf = new FSubmixEffectDynamicProcessorFilterSettings(base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_KeyLowshelf, base.MemoryOwner ?? this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FSubmixEffectDynamicProcessorFilterSettings.StaticStruct(), base.NativePtr + (IntPtr)FSubmixEffectDynamicsProcessorSettings.__PropertyOffset_KeyLowshelf, value.NativePtr, 1, false);
			}
		}

		// Token: 0x06003142 RID: 12610 RVA: 0x0004C2EC File Offset: 0x0004A4EC
		public FSubmixEffectDynamicsProcessorSettings()
		{
		}

		// Token: 0x06003143 RID: 12611 RVA: 0x0004C2F4 File Offset: 0x0004A4F4
		public FSubmixEffectDynamicsProcessorSettings(ESubmixEffectDynamicsProcessorType DynamicsProcessorType, ESubmixEffectDynamicsPeakMode PeakMode, ESubmixEffectDynamicsChannelLinkMode LinkMode, float InputGainDb, float ThresholdDb, float Ratio, float KneeBandwidthDb, float LookAheadMsec, float AttackTimeMsec, float ReleaseTimeMsec, USoundSubmix ExternalSubmix, bool bChannelLinked_DEPRECATED, bool bAnalogMode, bool bKeyAudition, float KeyGainDb, float OutputGainDb, FSubmixEffectDynamicProcessorFilterSettings KeyHighshelf, FSubmixEffectDynamicProcessorFilterSettings KeyLowshelf)
		{
			this.DynamicsProcessorType = DynamicsProcessorType;
			this.PeakMode = PeakMode;
			this.LinkMode = LinkMode;
			this.InputGainDb = InputGainDb;
			this.ThresholdDb = ThresholdDb;
			this.Ratio = Ratio;
			this.KneeBandwidthDb = KneeBandwidthDb;
			this.LookAheadMsec = LookAheadMsec;
			this.AttackTimeMsec = AttackTimeMsec;
			this.ReleaseTimeMsec = ReleaseTimeMsec;
			this.ExternalSubmix = ExternalSubmix;
			this.bChannelLinked_DEPRECATED = bChannelLinked_DEPRECATED;
			this.bAnalogMode = bAnalogMode;
			this.bKeyAudition = bKeyAudition;
			this.KeyGainDb = KeyGainDb;
			this.OutputGainDb = OutputGainDb;
			this.KeyHighshelf = KeyHighshelf;
			this.KeyLowshelf = KeyLowshelf;
		}

		// Token: 0x06003144 RID: 12612 RVA: 0x0004C394 File Offset: 0x0004A594
		protected override IntPtr GetUStructPtr()
		{
			return FSubmixEffectDynamicsProcessorSettings.StaticStruct();
		}

		// Token: 0x06003145 RID: 12613 RVA: 0x0004C3A0 File Offset: 0x0004A5A0
		[NullableContext(2)]
		public FSubmixEffectDynamicsProcessorSettings(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06003146 RID: 12614 RVA: 0x0004C3AA File Offset: 0x0004A5AA
		public FSubmixEffectDynamicsProcessorSettings(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06003147 RID: 12615 RVA: 0x0004C3B5 File Offset: 0x0004A5B5
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FSubmixEffectDynamicsProcessorSettings(Pointer, false, true);
		}

		// Token: 0x06003148 RID: 12616 RVA: 0x0004C3BF File Offset: 0x0004A5BF
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FSubmixEffectDynamicsProcessorSettings(Pointer, MemoryOwner);
		}

		// Token: 0x04001559 RID: 5465
		public const string __ObjectPath = "/Script/AudioMixer.SubmixEffectDynamicsProcessorSettings";

		// Token: 0x0400155A RID: 5466
		private static IntPtr _ScriptStructPtr;

		// Token: 0x0400155B RID: 5467
		internal static int __PropertyOffset_DynamicsProcessorType;

		// Token: 0x0400155C RID: 5468
		internal static int __PropertyOffset_PeakMode;

		// Token: 0x0400155D RID: 5469
		internal static int __PropertyOffset_LinkMode;

		// Token: 0x0400155E RID: 5470
		internal static int __PropertyOffset_InputGainDb;

		// Token: 0x0400155F RID: 5471
		internal static int __PropertyOffset_ThresholdDb;

		// Token: 0x04001560 RID: 5472
		internal static int __PropertyOffset_Ratio;

		// Token: 0x04001561 RID: 5473
		internal static int __PropertyOffset_KneeBandwidthDb;

		// Token: 0x04001562 RID: 5474
		internal static int __PropertyOffset_LookAheadMsec;

		// Token: 0x04001563 RID: 5475
		internal static int __PropertyOffset_AttackTimeMsec;

		// Token: 0x04001564 RID: 5476
		internal static int __PropertyOffset_ReleaseTimeMsec;

		// Token: 0x04001565 RID: 5477
		internal static int __PropertyOffset_ExternalSubmix;

		// Token: 0x04001566 RID: 5478
		internal static int __PropertyOffset_bChannelLinked_DEPRECATED;

		// Token: 0x04001567 RID: 5479
		internal static byte __PropertyMask_bChannelLinked_DEPRECATED;

		// Token: 0x04001568 RID: 5480
		internal static int __PropertyOffset_bAnalogMode;

		// Token: 0x04001569 RID: 5481
		internal static byte __PropertyMask_bAnalogMode;

		// Token: 0x0400156A RID: 5482
		internal static int __PropertyOffset_bKeyAudition;

		// Token: 0x0400156B RID: 5483
		internal static byte __PropertyMask_bKeyAudition;

		// Token: 0x0400156C RID: 5484
		internal static int __PropertyOffset_KeyGainDb;

		// Token: 0x0400156D RID: 5485
		internal static int __PropertyOffset_OutputGainDb;

		// Token: 0x0400156E RID: 5486
		internal static int __PropertyOffset_KeyHighshelf;

		// Token: 0x0400156F RID: 5487
		[Nullable(2)]
		private FSubmixEffectDynamicProcessorFilterSettings _KeyHighshelf;

		// Token: 0x04001570 RID: 5488
		internal static int __PropertyOffset_KeyLowshelf;

		// Token: 0x04001571 RID: 5489
		[Nullable(2)]
		private FSubmixEffectDynamicProcessorFilterSettings _KeyLowshelf;
	}
}
