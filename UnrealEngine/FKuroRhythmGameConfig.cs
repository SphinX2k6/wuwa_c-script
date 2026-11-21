using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020004FE RID: 1278
	[NullableContext(2)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmGameConfig")]
	[UnrealStructLayout(272, 8, UnrealReflectionPropertyTypeCode.UnrealScriptStructProxy, PropertiesSize = 272)]
	public class FKuroRhythmGameConfig : UnrealScriptStructProxy, IUnrealScriptStructProxy, IUnrealScriptStruct, IUnrealObject
	{
		// Token: 0x06007787 RID: 30599 RVA: 0x000AEA75 File Offset: 0x000ACC75
		public static UScriptStructStackOnlyPtr StaticStruct()
		{
			return (FKuroRhythmGameConfig._ScriptStructPtr != 0) ? FKuroRhythmGameConfig._ScriptStructPtr : UObjectGlobals.StaticLoadScriptStruct("/Script/KuroRhythmGame.KuroRhythmGameConfig", ref FKuroRhythmGameConfig._ScriptStructPtr);
		}

		// Token: 0x17001709 RID: 5897
		// (get) Token: 0x06007788 RID: 30600 RVA: 0x000AEA99 File Offset: 0x000ACC99
		// (set) Token: 0x06007789 RID: 30601 RVA: 0x000AEAA9 File Offset: 0x000ACCA9
		public unsafe float GlobalTimeOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_GlobalTimeOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_GlobalTimeOffset) = value;
			}
		}

		// Token: 0x1700170A RID: 5898
		// (get) Token: 0x0600778A RID: 30602 RVA: 0x000AEABA File Offset: 0x000ACCBA
		// (set) Token: 0x0600778B RID: 30603 RVA: 0x000AEACA File Offset: 0x000ACCCA
		public unsafe int ScorePerfect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ScorePerfect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ScorePerfect) = value;
			}
		}

		// Token: 0x1700170B RID: 5899
		// (get) Token: 0x0600778C RID: 30604 RVA: 0x000AEADB File Offset: 0x000ACCDB
		// (set) Token: 0x0600778D RID: 30605 RVA: 0x000AEAEB File Offset: 0x000ACCEB
		public unsafe int ScoreGreat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ScoreGreat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ScoreGreat) = value;
			}
		}

		// Token: 0x1700170C RID: 5900
		// (get) Token: 0x0600778E RID: 30606 RVA: 0x000AEAFC File Offset: 0x000ACCFC
		// (set) Token: 0x0600778F RID: 30607 RVA: 0x000AEB0C File Offset: 0x000ACD0C
		public unsafe int ScoreGood
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ScoreGood);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ScoreGood) = value;
			}
		}

		// Token: 0x1700170D RID: 5901
		// (get) Token: 0x06007790 RID: 30608 RVA: 0x000AEB1D File Offset: 0x000ACD1D
		// (set) Token: 0x06007791 RID: 30609 RVA: 0x000AEB2D File Offset: 0x000ACD2D
		public unsafe int ScoreBad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ScoreBad);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ScoreBad) = value;
			}
		}

		// Token: 0x1700170E RID: 5902
		// (get) Token: 0x06007792 RID: 30610 RVA: 0x000AEB3E File Offset: 0x000ACD3E
		// (set) Token: 0x06007793 RID: 30611 RVA: 0x000AEB4E File Offset: 0x000ACD4E
		public unsafe int ScoreMiss
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ScoreMiss);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ScoreMiss) = value;
			}
		}

		// Token: 0x1700170F RID: 5903
		// (get) Token: 0x06007794 RID: 30612 RVA: 0x000AEB5F File Offset: 0x000ACD5F
		// (set) Token: 0x06007795 RID: 30613 RVA: 0x000AEB6F File Offset: 0x000ACD6F
		public unsafe int LineHoldScorePerHalfBeatPerfect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LineHoldScorePerHalfBeatPerfect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LineHoldScorePerHalfBeatPerfect) = value;
			}
		}

		// Token: 0x17001710 RID: 5904
		// (get) Token: 0x06007796 RID: 30614 RVA: 0x000AEB80 File Offset: 0x000ACD80
		// (set) Token: 0x06007797 RID: 30615 RVA: 0x000AEB90 File Offset: 0x000ACD90
		public unsafe int LineHoldScorePerHalfBeatGreat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LineHoldScorePerHalfBeatGreat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LineHoldScorePerHalfBeatGreat) = value;
			}
		}

		// Token: 0x17001711 RID: 5905
		// (get) Token: 0x06007798 RID: 30616 RVA: 0x000AEBA1 File Offset: 0x000ACDA1
		// (set) Token: 0x06007799 RID: 30617 RVA: 0x000AEBB1 File Offset: 0x000ACDB1
		public unsafe int LineHoldScorePerHalfBeatGood
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LineHoldScorePerHalfBeatGood);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LineHoldScorePerHalfBeatGood) = value;
			}
		}

		// Token: 0x17001712 RID: 5906
		// (get) Token: 0x0600779A RID: 30618 RVA: 0x000AEBC2 File Offset: 0x000ACDC2
		// (set) Token: 0x0600779B RID: 30619 RVA: 0x000AEBD2 File Offset: 0x000ACDD2
		public unsafe int LineHoldScorePerHalfBeatBad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LineHoldScorePerHalfBeatBad);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LineHoldScorePerHalfBeatBad) = value;
			}
		}

		// Token: 0x17001713 RID: 5907
		// (get) Token: 0x0600779C RID: 30620 RVA: 0x000AEBE3 File Offset: 0x000ACDE3
		// (set) Token: 0x0600779D RID: 30621 RVA: 0x000AEBF3 File Offset: 0x000ACDF3
		public unsafe float EarlyMiss
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_EarlyMiss);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_EarlyMiss) = value;
			}
		}

		// Token: 0x17001714 RID: 5908
		// (get) Token: 0x0600779E RID: 30622 RVA: 0x000AEC04 File Offset: 0x000ACE04
		// (set) Token: 0x0600779F RID: 30623 RVA: 0x000AEC14 File Offset: 0x000ACE14
		public unsafe float EarlyBad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_EarlyBad);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_EarlyBad) = value;
			}
		}

		// Token: 0x17001715 RID: 5909
		// (get) Token: 0x060077A0 RID: 30624 RVA: 0x000AEC25 File Offset: 0x000ACE25
		// (set) Token: 0x060077A1 RID: 30625 RVA: 0x000AEC35 File Offset: 0x000ACE35
		public unsafe float EarlyGood
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_EarlyGood);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_EarlyGood) = value;
			}
		}

		// Token: 0x17001716 RID: 5910
		// (get) Token: 0x060077A2 RID: 30626 RVA: 0x000AEC46 File Offset: 0x000ACE46
		// (set) Token: 0x060077A3 RID: 30627 RVA: 0x000AEC56 File Offset: 0x000ACE56
		public unsafe float EarlyGreat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_EarlyGreat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_EarlyGreat) = value;
			}
		}

		// Token: 0x17001717 RID: 5911
		// (get) Token: 0x060077A4 RID: 30628 RVA: 0x000AEC67 File Offset: 0x000ACE67
		// (set) Token: 0x060077A5 RID: 30629 RVA: 0x000AEC77 File Offset: 0x000ACE77
		public unsafe float Perfect
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_Perfect);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_Perfect) = value;
			}
		}

		// Token: 0x17001718 RID: 5912
		// (get) Token: 0x060077A6 RID: 30630 RVA: 0x000AEC88 File Offset: 0x000ACE88
		// (set) Token: 0x060077A7 RID: 30631 RVA: 0x000AEC98 File Offset: 0x000ACE98
		public unsafe float LateGreat
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LateGreat);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LateGreat) = value;
			}
		}

		// Token: 0x17001719 RID: 5913
		// (get) Token: 0x060077A8 RID: 30632 RVA: 0x000AECA9 File Offset: 0x000ACEA9
		// (set) Token: 0x060077A9 RID: 30633 RVA: 0x000AECB9 File Offset: 0x000ACEB9
		public unsafe float LateGood
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LateGood);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LateGood) = value;
			}
		}

		// Token: 0x1700171A RID: 5914
		// (get) Token: 0x060077AA RID: 30634 RVA: 0x000AECCA File Offset: 0x000ACECA
		// (set) Token: 0x060077AB RID: 30635 RVA: 0x000AECDA File Offset: 0x000ACEDA
		public unsafe float LateBad
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LateBad);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_LateBad) = value;
			}
		}

		// Token: 0x1700171B RID: 5915
		// (get) Token: 0x060077AC RID: 30636 RVA: 0x000AECEB File Offset: 0x000ACEEB
		// (set) Token: 0x060077AD RID: 30637 RVA: 0x000AECFB File Offset: 0x000ACEFB
		public unsafe float Miss
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_Miss);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_Miss) = value;
			}
		}

		// Token: 0x1700171C RID: 5916
		// (get) Token: 0x060077AE RID: 30638 RVA: 0x000AED0C File Offset: 0x000ACF0C
		// (set) Token: 0x060077AF RID: 30639 RVA: 0x000AED4F File Offset: 0x000ACF4F
		[Nullable(1)]
		public FKuroRhythmGameHiddenScore HiddenScore
		{
			[NullableContext(1)]
			get
			{
				base.FastCheckIsValid();
				FKuroRhythmGameHiddenScore result;
				if ((result = this._HiddenScore) == null)
				{
					result = (this._HiddenScore = new FKuroRhythmGameHiddenScore(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_HiddenScore, base.MemoryOwner ?? this));
				}
				return result;
			}
			[NullableContext(1)]
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmGameHiddenScore.StaticStruct(), base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_HiddenScore, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700171D RID: 5917
		// (get) Token: 0x060077B0 RID: 30640 RVA: 0x000AED70 File Offset: 0x000ACF70
		// (set) Token: 0x060077B1 RID: 30641 RVA: 0x000AED80 File Offset: 0x000ACF80
		public unsafe int FeverScoreMax
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_FeverScoreMax);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_FeverScoreMax) = value;
			}
		}

		// Token: 0x1700171E RID: 5918
		// (get) Token: 0x060077B2 RID: 30642 RVA: 0x000AED91 File Offset: 0x000ACF91
		// (set) Token: 0x060077B3 RID: 30643 RVA: 0x000AEDA1 File Offset: 0x000ACFA1
		public unsafe int FeverConsumptionPerSecond
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_FeverConsumptionPerSecond);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_FeverConsumptionPerSecond) = value;
			}
		}

		// Token: 0x1700171F RID: 5919
		// (get) Token: 0x060077B4 RID: 30644 RVA: 0x000AEDB2 File Offset: 0x000ACFB2
		// (set) Token: 0x060077B5 RID: 30645 RVA: 0x000AEDC2 File Offset: 0x000ACFC2
		public unsafe float CurvatureDeltaDistance
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_CurvatureDeltaDistance);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_CurvatureDeltaDistance) = value;
			}
		}

		// Token: 0x17001720 RID: 5920
		// (get) Token: 0x060077B6 RID: 30646 RVA: 0x000AEDD3 File Offset: 0x000ACFD3
		// (set) Token: 0x060077B7 RID: 30647 RVA: 0x000AEDE3 File Offset: 0x000ACFE3
		public unsafe float CurvatureMultiplier
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_CurvatureMultiplier);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_CurvatureMultiplier) = value;
			}
		}

		// Token: 0x17001721 RID: 5921
		// (get) Token: 0x060077B8 RID: 30648 RVA: 0x000AEDF4 File Offset: 0x000ACFF4
		// (set) Token: 0x060077B9 RID: 30649 RVA: 0x000AEE04 File Offset: 0x000AD004
		public unsafe float TrackWidth
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_TrackWidth);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_TrackWidth) = value;
			}
		}

		// Token: 0x17001722 RID: 5922
		// (get) Token: 0x060077BA RID: 30650 RVA: 0x000AEE15 File Offset: 0x000AD015
		// (set) Token: 0x060077BB RID: 30651 RVA: 0x000AEE25 File Offset: 0x000AD025
		public unsafe int TrackCount
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_TrackCount);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_TrackCount) = value;
			}
		}

		// Token: 0x17001723 RID: 5923
		// (get) Token: 0x060077BC RID: 30652 RVA: 0x000AEE36 File Offset: 0x000AD036
		// (set) Token: 0x060077BD RID: 30653 RVA: 0x000AEE46 File Offset: 0x000AD046
		public unsafe float TrackSwitchDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_TrackSwitchDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_TrackSwitchDuration) = value;
			}
		}

		// Token: 0x17001724 RID: 5924
		// (get) Token: 0x060077BE RID: 30654 RVA: 0x000AEE57 File Offset: 0x000AD057
		// (set) Token: 0x060077BF RID: 30655 RVA: 0x000AEE67 File Offset: 0x000AD067
		public unsafe float Acceleration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_Acceleration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_Acceleration) = value;
			}
		}

		// Token: 0x17001725 RID: 5925
		// (get) Token: 0x060077C0 RID: 30656 RVA: 0x000AEE78 File Offset: 0x000AD078
		// (set) Token: 0x060077C1 RID: 30657 RVA: 0x000AEE88 File Offset: 0x000AD088
		public unsafe float ShipZAxisOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ShipZAxisOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)FKuroRhythmGameConfig.__PropertyOffset_ShipZAxisOffset) = value;
			}
		}

		// Token: 0x17001726 RID: 5926
		// (get) Token: 0x060077C2 RID: 30658 RVA: 0x000AEE99 File Offset: 0x000AD099
		// (set) Token: 0x060077C3 RID: 30659 RVA: 0x000AEEAD File Offset: 0x000AD0AD
		public unsafe UNiagaraSystem EffectSystem
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UNiagaraSystem>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroRhythmGameConfig.__PropertyOffset_EffectSystem);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroRhythmGameConfig.__PropertyOffset_EffectSystem, value);
			}
		}

		// Token: 0x17001727 RID: 5927
		// (get) Token: 0x060077C4 RID: 30660 RVA: 0x000AEEC2 File Offset: 0x000AD0C2
		// (set) Token: 0x060077C5 RID: 30661 RVA: 0x000AEED6 File Offset: 0x000AD0D6
		public unsafe UCurveFloat JumpHeightCurve
		{
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UCurveFloat>(base.NativePtr / (IntPtr)sizeof(void*) + FKuroRhythmGameConfig.__PropertyOffset_JumpHeightCurve);
			}
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + FKuroRhythmGameConfig.__PropertyOffset_JumpHeightCurve, value);
			}
		}

		// Token: 0x060077C6 RID: 30662 RVA: 0x000AEEEB File Offset: 0x000AD0EB
		public FKuroRhythmGameConfig()
		{
		}

		// Token: 0x060077C7 RID: 30663 RVA: 0x000AEEF3 File Offset: 0x000AD0F3
		protected override IntPtr GetUStructPtr()
		{
			return FKuroRhythmGameConfig.StaticStruct();
		}

		// Token: 0x060077C8 RID: 30664 RVA: 0x000AEEFF File Offset: 0x000AD0FF
		public FKuroRhythmGameConfig(IntPtr NativePtr, UnrealObject MemoryOwner) : base(NativePtr, MemoryOwner)
		{
		}

		// Token: 0x060077C9 RID: 30665 RVA: 0x000AEF09 File Offset: 0x000AD109
		public FKuroRhythmGameConfig(IntPtr NativePtr, bool bWithMoveAssign, bool bWithCopyAssignIfCannotMove) : base(NativePtr, bWithMoveAssign, bWithCopyAssignIfCannotMove)
		{
		}

		// Token: 0x060077CA RID: 30666 RVA: 0x000AEF14 File Offset: 0x000AD114
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateFromPointer(IntPtr Pointer)
		{
			return new FKuroRhythmGameConfig(Pointer, false, true);
		}

		// Token: 0x060077CB RID: 30667 RVA: 0x000AEF1E File Offset: 0x000AD11E
		[NullableContext(1)]
		public static IUnrealScriptStructProxy CreateReferenceFromPointer(IntPtr Pointer, UnrealObject MemoryOwner)
		{
			return new FKuroRhythmGameConfig(Pointer, MemoryOwner);
		}

		// Token: 0x04003291 RID: 12945
		[Nullable(1)]
		public const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmGameConfig";

		// Token: 0x04003292 RID: 12946
		private static IntPtr _ScriptStructPtr;

		// Token: 0x04003293 RID: 12947
		internal static int __PropertyOffset_GlobalTimeOffset;

		// Token: 0x04003294 RID: 12948
		internal static int __PropertyOffset_ScorePerfect;

		// Token: 0x04003295 RID: 12949
		internal static int __PropertyOffset_ScoreGreat;

		// Token: 0x04003296 RID: 12950
		internal static int __PropertyOffset_ScoreGood;

		// Token: 0x04003297 RID: 12951
		internal static int __PropertyOffset_ScoreBad;

		// Token: 0x04003298 RID: 12952
		internal static int __PropertyOffset_ScoreMiss;

		// Token: 0x04003299 RID: 12953
		internal static int __PropertyOffset_LineHoldScorePerHalfBeatPerfect;

		// Token: 0x0400329A RID: 12954
		internal static int __PropertyOffset_LineHoldScorePerHalfBeatGreat;

		// Token: 0x0400329B RID: 12955
		internal static int __PropertyOffset_LineHoldScorePerHalfBeatGood;

		// Token: 0x0400329C RID: 12956
		internal static int __PropertyOffset_LineHoldScorePerHalfBeatBad;

		// Token: 0x0400329D RID: 12957
		internal static int __PropertyOffset_EarlyMiss;

		// Token: 0x0400329E RID: 12958
		internal static int __PropertyOffset_EarlyBad;

		// Token: 0x0400329F RID: 12959
		internal static int __PropertyOffset_EarlyGood;

		// Token: 0x040032A0 RID: 12960
		internal static int __PropertyOffset_EarlyGreat;

		// Token: 0x040032A1 RID: 12961
		internal static int __PropertyOffset_Perfect;

		// Token: 0x040032A2 RID: 12962
		internal static int __PropertyOffset_LateGreat;

		// Token: 0x040032A3 RID: 12963
		internal static int __PropertyOffset_LateGood;

		// Token: 0x040032A4 RID: 12964
		internal static int __PropertyOffset_LateBad;

		// Token: 0x040032A5 RID: 12965
		internal static int __PropertyOffset_Miss;

		// Token: 0x040032A6 RID: 12966
		internal static int __PropertyOffset_HiddenScore;

		// Token: 0x040032A7 RID: 12967
		private FKuroRhythmGameHiddenScore _HiddenScore;

		// Token: 0x040032A8 RID: 12968
		internal static int __PropertyOffset_FeverScoreMax;

		// Token: 0x040032A9 RID: 12969
		internal static int __PropertyOffset_FeverConsumptionPerSecond;

		// Token: 0x040032AA RID: 12970
		internal static int __PropertyOffset_CurvatureDeltaDistance;

		// Token: 0x040032AB RID: 12971
		internal static int __PropertyOffset_CurvatureMultiplier;

		// Token: 0x040032AC RID: 12972
		internal static int __PropertyOffset_TrackWidth;

		// Token: 0x040032AD RID: 12973
		internal static int __PropertyOffset_TrackCount;

		// Token: 0x040032AE RID: 12974
		internal static int __PropertyOffset_TrackSwitchDuration;

		// Token: 0x040032AF RID: 12975
		internal static int __PropertyOffset_Acceleration;

		// Token: 0x040032B0 RID: 12976
		internal static int __PropertyOffset_ShipZAxisOffset;

		// Token: 0x040032B1 RID: 12977
		internal static int __PropertyOffset_EffectSystem;

		// Token: 0x040032B2 RID: 12978
		internal static int __PropertyOffset_JumpHeightCurve;
	}
}
