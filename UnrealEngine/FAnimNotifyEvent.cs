using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000827 RID: 2087
	[UnrealObjectPath("/Script/Engine.AnimNotifyEvent")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 224)]
	public class FAnimNotifyEvent : FAnimLinkableElement, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x0600703C RID: 28732 RVA: 0x000A0FAC File Offset: 0x0009F1AC
		public new static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FAnimNotifyEvent._ScriptStructPtr != 0) ? FAnimNotifyEvent._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/Engine.AnimNotifyEvent", ref FAnimNotifyEvent._ScriptStructPtr);
		}

		// Token: 0x17001A63 RID: 6755
		// (get) Token: 0x0600703D RID: 28733 RVA: 0x000A0FD0 File Offset: 0x0009F1D0
		// (set) Token: 0x0600703E RID: 28734 RVA: 0x000A0FE0 File Offset: 0x0009F1E0
		public unsafe float DisplayTime_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_DisplayTime_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_DisplayTime_DEPRECATED) = value;
			}
		}

		// Token: 0x17001A64 RID: 6756
		// (get) Token: 0x0600703F RID: 28735 RVA: 0x000A0FF1 File Offset: 0x0009F1F1
		// (set) Token: 0x06007040 RID: 28736 RVA: 0x000A1001 File Offset: 0x0009F201
		public unsafe float TriggerTimeOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_TriggerTimeOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_TriggerTimeOffset) = value;
			}
		}

		// Token: 0x17001A65 RID: 6757
		// (get) Token: 0x06007041 RID: 28737 RVA: 0x000A1012 File Offset: 0x0009F212
		// (set) Token: 0x06007042 RID: 28738 RVA: 0x000A1022 File Offset: 0x0009F222
		public unsafe float EndTriggerTimeOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_EndTriggerTimeOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_EndTriggerTimeOffset) = value;
			}
		}

		// Token: 0x17001A66 RID: 6758
		// (get) Token: 0x06007043 RID: 28739 RVA: 0x000A1033 File Offset: 0x0009F233
		// (set) Token: 0x06007044 RID: 28740 RVA: 0x000A1043 File Offset: 0x0009F243
		public unsafe float TriggerWeightThreshold
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_TriggerWeightThreshold);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_TriggerWeightThreshold) = value;
			}
		}

		// Token: 0x17001A67 RID: 6759
		// (get) Token: 0x06007045 RID: 28741 RVA: 0x000A1054 File Offset: 0x0009F254
		// (set) Token: 0x06007046 RID: 28742 RVA: 0x000A1068 File Offset: 0x0009F268
		public unsafe FName NotifyName
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_NotifyName);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_NotifyName) = value;
			}
		}

		// Token: 0x17001A68 RID: 6760
		// (get) Token: 0x06007047 RID: 28743 RVA: 0x000A107D File Offset: 0x0009F27D
		// (set) Token: 0x06007048 RID: 28744 RVA: 0x000A1091 File Offset: 0x0009F291
		[Nullable(2)]
		public unsafe UAnimNotify Notify
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimNotify>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNotifyEvent.__PropertyOffset_Notify);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNotifyEvent.__PropertyOffset_Notify, value);
			}
		}

		// Token: 0x17001A69 RID: 6761
		// (get) Token: 0x06007049 RID: 28745 RVA: 0x000A10A6 File Offset: 0x0009F2A6
		// (set) Token: 0x0600704A RID: 28746 RVA: 0x000A10BA File Offset: 0x0009F2BA
		[Nullable(2)]
		public unsafe UAnimNotifyState NotifyStateClass
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAnimNotifyState>(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNotifyEvent.__PropertyOffset_NotifyStateClass);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FAnimNotifyEvent.__PropertyOffset_NotifyStateClass, value);
			}
		}

		// Token: 0x17001A6A RID: 6762
		// (get) Token: 0x0600704B RID: 28747 RVA: 0x000A10CF File Offset: 0x0009F2CF
		// (set) Token: 0x0600704C RID: 28748 RVA: 0x000A10DF File Offset: 0x0009F2DF
		public unsafe float Duration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_Duration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_Duration) = value;
			}
		}

		// Token: 0x17001A6B RID: 6763
		// (get) Token: 0x0600704D RID: 28749 RVA: 0x000A10F0 File Offset: 0x0009F2F0
		// (set) Token: 0x0600704E RID: 28750 RVA: 0x000A1133 File Offset: 0x0009F333
		[Nullable(1)]
		public FAnimLinkableElement EndLink
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FAnimLinkableElement result;
				if ((result = this._EndLink) == null)
				{
					result = (this._EndLink = new FAnimLinkableElement(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_EndLink, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FAnimLinkableElement.StaticStruct(), base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_EndLink, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001A6C RID: 6764
		// (get) Token: 0x0600704F RID: 28751 RVA: 0x000A1154 File Offset: 0x0009F354
		// (set) Token: 0x06007050 RID: 28752 RVA: 0x000A1164 File Offset: 0x0009F364
		public unsafe bool bConvertedFromBranchingPoint
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_bConvertedFromBranchingPoint) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_bConvertedFromBranchingPoint) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A6D RID: 6765
		// (get) Token: 0x06007051 RID: 28753 RVA: 0x000A1175 File Offset: 0x0009F375
		// (set) Token: 0x06007052 RID: 28754 RVA: 0x000A1189 File Offset: 0x0009F389
		public unsafe TEnumAsByte<EMontageNotifyTickType> MontageTickType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_MontageTickType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_MontageTickType) = value;
			}
		}

		// Token: 0x17001A6E RID: 6766
		// (get) Token: 0x06007053 RID: 28755 RVA: 0x000A119E File Offset: 0x0009F39E
		// (set) Token: 0x06007054 RID: 28756 RVA: 0x000A11AE File Offset: 0x0009F3AE
		public unsafe bool bEnabled
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_bEnabled) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_bEnabled) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A6F RID: 6767
		// (get) Token: 0x06007055 RID: 28757 RVA: 0x000A11BF File Offset: 0x0009F3BF
		// (set) Token: 0x06007056 RID: 28758 RVA: 0x000A11CF File Offset: 0x0009F3CF
		public unsafe float NotifyTriggerChance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_NotifyTriggerChance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_NotifyTriggerChance) = value;
			}
		}

		// Token: 0x17001A70 RID: 6768
		// (get) Token: 0x06007057 RID: 28759 RVA: 0x000A11E0 File Offset: 0x0009F3E0
		// (set) Token: 0x06007058 RID: 28760 RVA: 0x000A11F4 File Offset: 0x0009F3F4
		public unsafe TEnumAsByte<ENotifyFilterType> NotifyFilterType
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_NotifyFilterType);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_NotifyFilterType) = value;
			}
		}

		// Token: 0x17001A71 RID: 6769
		// (get) Token: 0x06007059 RID: 28761 RVA: 0x000A1209 File Offset: 0x0009F409
		// (set) Token: 0x0600705A RID: 28762 RVA: 0x000A1219 File Offset: 0x0009F419
		public unsafe int NotifyFilterLOD
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_NotifyFilterLOD);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_NotifyFilterLOD) = value;
			}
		}

		// Token: 0x17001A72 RID: 6770
		// (get) Token: 0x0600705B RID: 28763 RVA: 0x000A122A File Offset: 0x0009F42A
		// (set) Token: 0x0600705C RID: 28764 RVA: 0x000A123A File Offset: 0x0009F43A
		public unsafe bool bTriggerOnDedicatedServer
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_bTriggerOnDedicatedServer) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_bTriggerOnDedicatedServer) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A73 RID: 6771
		// (get) Token: 0x0600705D RID: 28765 RVA: 0x000A124B File Offset: 0x0009F44B
		// (set) Token: 0x0600705E RID: 28766 RVA: 0x000A125B File Offset: 0x0009F45B
		public unsafe bool bTriggerOnFollower
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_bTriggerOnFollower) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_bTriggerOnFollower) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A74 RID: 6772
		// (get) Token: 0x0600705F RID: 28767 RVA: 0x000A126C File Offset: 0x0009F46C
		// (set) Token: 0x06007060 RID: 28768 RVA: 0x000A127C File Offset: 0x0009F47C
		public unsafe bool bForceTriggerOnState
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_bForceTriggerOnState) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_bForceTriggerOnState) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001A75 RID: 6773
		// (get) Token: 0x06007061 RID: 28769 RVA: 0x000A128D File Offset: 0x0009F48D
		// (set) Token: 0x06007062 RID: 28770 RVA: 0x000A129D File Offset: 0x0009F49D
		public unsafe int TrackIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_TrackIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FAnimNotifyEvent.__PropertyOffset_TrackIndex) = value;
			}
		}

		// Token: 0x06007063 RID: 28771 RVA: 0x000A12AE File Offset: 0x0009F4AE
		public FAnimNotifyEvent()
		{
		}

		// Token: 0x06007064 RID: 28772 RVA: 0x000A12B8 File Offset: 0x0009F4B8
		[NullableContext(1)]
		public FAnimNotifyEvent(float DisplayTime_DEPRECATED, float TriggerTimeOffset, float EndTriggerTimeOffset, float TriggerWeightThreshold, FName NotifyName, UAnimNotify Notify, UAnimNotifyState NotifyStateClass, float Duration, FAnimLinkableElement EndLink, bool bConvertedFromBranchingPoint, [Nullable(0)] TEnumAsByte<EMontageNotifyTickType> MontageTickType, bool bEnabled, bool bCreateByChild, bool bCreateByMerge, bool bKuroKeepBeginInSection, bool bKuroKeepEndInSection, float NotifyTriggerChance, [Nullable(0)] TEnumAsByte<ENotifyFilterType> NotifyFilterType, int NotifyFilterLOD, bool bTriggerOnDedicatedServer, bool bTriggerOnFollower, bool bForceTriggerOnState, FColor NotifyColor, FGuid Guid, int TrackIndex, UAnimMontage LinkedMontage, int SlotIndex, int SegmentIndex, [Nullable(0)] TEnumAsByte<EAnimLinkMethod> LinkMethod, [Nullable(0)] TEnumAsByte<EAnimLinkMethod> CachedLinkMethod, float SegmentBeginTime, float SegmentLength, float LinkValue, UAnimSequenceBase LinkedSequence)
		{
			this.DisplayTime_DEPRECATED = DisplayTime_DEPRECATED;
			this.TriggerTimeOffset = TriggerTimeOffset;
			this.EndTriggerTimeOffset = EndTriggerTimeOffset;
			this.TriggerWeightThreshold = TriggerWeightThreshold;
			this.NotifyName = NotifyName;
			this.Notify = Notify;
			this.NotifyStateClass = NotifyStateClass;
			this.Duration = Duration;
			this.EndLink = EndLink;
			this.bConvertedFromBranchingPoint = bConvertedFromBranchingPoint;
			this.MontageTickType = MontageTickType;
			this.bEnabled = bEnabled;
			this.NotifyTriggerChance = NotifyTriggerChance;
			this.NotifyFilterType = NotifyFilterType;
			this.NotifyFilterLOD = NotifyFilterLOD;
			this.bTriggerOnDedicatedServer = bTriggerOnDedicatedServer;
			this.bTriggerOnFollower = bTriggerOnFollower;
			this.bForceTriggerOnState = bForceTriggerOnState;
			this.TrackIndex = TrackIndex;
			base.LinkedMontage = LinkedMontage;
			base.SlotIndex = SlotIndex;
			base.SegmentIndex = SegmentIndex;
			base.LinkMethod = LinkMethod;
			base.CachedLinkMethod = CachedLinkMethod;
			base.SegmentBeginTime = SegmentBeginTime;
			base.SegmentLength = SegmentLength;
			base.LinkValue = LinkValue;
			base.LinkedSequence = LinkedSequence;
		}

		// Token: 0x06007065 RID: 28773 RVA: 0x000A13A8 File Offset: 0x0009F5A8
		protected override IntPtr GetUStructPtr()
		{
			return FAnimNotifyEvent.StaticStruct();
		}

		// Token: 0x06007066 RID: 28774 RVA: 0x000A13B4 File Offset: 0x0009F5B4
		[NullableContext(2)]
		public FAnimNotifyEvent(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x06007067 RID: 28775 RVA: 0x000A13BE File Offset: 0x0009F5BE
		public FAnimNotifyEvent(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x06007068 RID: 28776 RVA: 0x000A13C9 File Offset: 0x0009F5C9
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FAnimNotifyEvent(Pointer, false, true);
		}

		// Token: 0x06007069 RID: 28777 RVA: 0x000A13D3 File Offset: 0x0009F5D3
		[NullableContext(1)]
		public new static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FAnimNotifyEvent(Pointer, MemoryOwner);
		}

		// Token: 0x040035E4 RID: 13796
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/Engine.AnimNotifyEvent";

		// Token: 0x040035E5 RID: 13797
		private static IntPtr _ScriptStructPtr;

		// Token: 0x040035E6 RID: 13798
		internal static int __PropertyOffset_DisplayTime_DEPRECATED;

		// Token: 0x040035E7 RID: 13799
		internal static int __PropertyOffset_TriggerTimeOffset;

		// Token: 0x040035E8 RID: 13800
		internal static int __PropertyOffset_EndTriggerTimeOffset;

		// Token: 0x040035E9 RID: 13801
		internal static int __PropertyOffset_TriggerWeightThreshold;

		// Token: 0x040035EA RID: 13802
		internal static int __PropertyOffset_NotifyName;

		// Token: 0x040035EB RID: 13803
		internal static int __PropertyOffset_Notify;

		// Token: 0x040035EC RID: 13804
		internal static int __PropertyOffset_NotifyStateClass;

		// Token: 0x040035ED RID: 13805
		internal static int __PropertyOffset_Duration;

		// Token: 0x040035EE RID: 13806
		internal static int __PropertyOffset_EndLink;

		// Token: 0x040035EF RID: 13807
		[Nullable(2)]
		private FAnimLinkableElement _EndLink;

		// Token: 0x040035F0 RID: 13808
		internal static int __PropertyOffset_bConvertedFromBranchingPoint;

		// Token: 0x040035F1 RID: 13809
		internal static int __PropertyOffset_MontageTickType;

		// Token: 0x040035F2 RID: 13810
		internal static int __PropertyOffset_bEnabled;

		// Token: 0x040035F3 RID: 13811
		internal static int __PropertyOffset_NotifyTriggerChance;

		// Token: 0x040035F4 RID: 13812
		internal static int __PropertyOffset_NotifyFilterType;

		// Token: 0x040035F5 RID: 13813
		internal static int __PropertyOffset_NotifyFilterLOD;

		// Token: 0x040035F6 RID: 13814
		internal static int __PropertyOffset_bTriggerOnDedicatedServer;

		// Token: 0x040035F7 RID: 13815
		internal static int __PropertyOffset_bTriggerOnFollower;

		// Token: 0x040035F8 RID: 13816
		internal static int __PropertyOffset_bForceTriggerOnState;

		// Token: 0x040035F9 RID: 13817
		internal static int __PropertyOffset_TrackIndex;
	}
}
