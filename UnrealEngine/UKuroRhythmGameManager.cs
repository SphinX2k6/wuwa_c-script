using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000501 RID: 1281
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmGameManager")]
	[UnrealStructLayout(928, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 928)]
	public class UKuroRhythmGameManager : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06007801 RID: 30721 RVA: 0x000AF620 File Offset: 0x000AD820
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRhythmGameManager._ClassPtr;
		}

		// Token: 0x06007802 RID: 30722 RVA: 0x000AF62C File Offset: 0x000AD82C
		public UKuroRhythmGameManager() : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmGameManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06007803 RID: 30723 RVA: 0x000AF654 File Offset: 0x000AD854
		public UKuroRhythmGameManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmGameManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001738 RID: 5944
		// (get) Token: 0x06007804 RID: 30724 RVA: 0x000AF688 File Offset: 0x000AD888
		// (set) Token: 0x06007805 RID: 30725 RVA: 0x000AF6C1 File Offset: 0x000AD8C1
		public FOnNoteResult OnNoteResult
		{
			get
			{
				base.FastCheckIsValid();
				FOnNoteResult result;
				if ((result = this._OnNoteResult) == null)
				{
					result = (this._OnNoteResult = new FOnNoteResult(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_OnNoteResult, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_OnNoteResult, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001739 RID: 5945
		// (get) Token: 0x06007806 RID: 30726 RVA: 0x000AF6E4 File Offset: 0x000AD8E4
		// (set) Token: 0x06007807 RID: 30727 RVA: 0x000AF71D File Offset: 0x000AD91D
		public FOnAllNotesFinished OnAllNotesFinished
		{
			get
			{
				base.FastCheckIsValid();
				FOnAllNotesFinished result;
				if ((result = this._OnAllNotesFinished) == null)
				{
					result = (this._OnAllNotesFinished = new FOnAllNotesFinished(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_OnAllNotesFinished, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_OnAllNotesFinished, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700173A RID: 5946
		// (get) Token: 0x06007808 RID: 30728 RVA: 0x000AF740 File Offset: 0x000AD940
		// (set) Token: 0x06007809 RID: 30729 RVA: 0x000AF779 File Offset: 0x000AD979
		public FOnFeverStateChanged OnFeverStateChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnFeverStateChanged result;
				if ((result = this._OnFeverStateChanged) == null)
				{
					result = (this._OnFeverStateChanged = new FOnFeverStateChanged(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_OnFeverStateChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_OnFeverStateChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700173B RID: 5947
		// (get) Token: 0x0600780A RID: 30730 RVA: 0x000AF79C File Offset: 0x000AD99C
		// (set) Token: 0x0600780B RID: 30731 RVA: 0x000AF7D5 File Offset: 0x000AD9D5
		public FOnHiddenScoreLevelChanged OnHiddenScoreLevelChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnHiddenScoreLevelChanged result;
				if ((result = this._OnHiddenScoreLevelChanged) == null)
				{
					result = (this._OnHiddenScoreLevelChanged = new FOnHiddenScoreLevelChanged(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_OnHiddenScoreLevelChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_OnHiddenScoreLevelChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700173C RID: 5948
		// (get) Token: 0x0600780C RID: 30732 RVA: 0x000AF7F8 File Offset: 0x000AD9F8
		// (set) Token: 0x0600780D RID: 30733 RVA: 0x000AF831 File Offset: 0x000ADA31
		public FOnFeverScoreChanged OnFeverScoreChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnFeverScoreChanged result;
				if ((result = this._OnFeverScoreChanged) == null)
				{
					result = (this._OnFeverScoreChanged = new FOnFeverScoreChanged(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_OnFeverScoreChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_OnFeverScoreChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700173D RID: 5949
		// (get) Token: 0x0600780E RID: 30734 RVA: 0x000AF854 File Offset: 0x000ADA54
		// (set) Token: 0x0600780F RID: 30735 RVA: 0x000AF88D File Offset: 0x000ADA8D
		public FOnJumpEvent OnJumpEvent
		{
			get
			{
				base.FastCheckIsValid();
				FOnJumpEvent result;
				if ((result = this._OnJumpEvent) == null)
				{
					result = (this._OnJumpEvent = new FOnJumpEvent(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_OnJumpEvent, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_OnJumpEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700173E RID: 5950
		// (get) Token: 0x06007810 RID: 30736 RVA: 0x000AF8B0 File Offset: 0x000ADAB0
		// (set) Token: 0x06007811 RID: 30737 RVA: 0x000AF8E9 File Offset: 0x000ADAE9
		public FOnTrackSwitched OnTrackSwitched
		{
			get
			{
				base.FastCheckIsValid();
				FOnTrackSwitched result;
				if ((result = this._OnTrackSwitched) == null)
				{
					result = (this._OnTrackSwitched = new FOnTrackSwitched(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_OnTrackSwitched, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_OnTrackSwitched, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x1700173F RID: 5951
		// (get) Token: 0x06007812 RID: 30738 RVA: 0x000AF90C File Offset: 0x000ADB0C
		// (set) Token: 0x06007813 RID: 30739 RVA: 0x000AF945 File Offset: 0x000ADB45
		public FOnHoldScoreUpdated OnHoldScoreUpdated
		{
			get
			{
				base.FastCheckIsValid();
				FOnHoldScoreUpdated result;
				if ((result = this._OnHoldScoreUpdated) == null)
				{
					result = (this._OnHoldScoreUpdated = new FOnHoldScoreUpdated(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_OnHoldScoreUpdated, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_OnHoldScoreUpdated, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001740 RID: 5952
		// (get) Token: 0x06007814 RID: 30740 RVA: 0x000AF968 File Offset: 0x000ADB68
		// (set) Token: 0x06007815 RID: 30741 RVA: 0x000AF9A1 File Offset: 0x000ADBA1
		public FOnGameEvent OnGameEvent
		{
			get
			{
				base.FastCheckIsValid();
				FOnGameEvent result;
				if ((result = this._OnGameEvent) == null)
				{
					result = (this._OnGameEvent = new FOnGameEvent(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_OnGameEvent, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_OnGameEvent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001741 RID: 5953
		// (get) Token: 0x06007816 RID: 30742 RVA: 0x000AF9C2 File Offset: 0x000ADBC2
		// (set) Token: 0x06007817 RID: 30743 RVA: 0x000AF9D6 File Offset: 0x000ADBD6
		[Nullable(2)]
		public unsafe AActor ShipActor
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<AActor>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameManager.__PropertyOffset_ShipActor);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameManager.__PropertyOffset_ShipActor, value);
			}
		}

		// Token: 0x17001742 RID: 5954
		// (get) Token: 0x06007818 RID: 30744 RVA: 0x000AF9EB File Offset: 0x000ADBEB
		// (set) Token: 0x06007819 RID: 30745 RVA: 0x000AF9FF File Offset: 0x000ADBFF
		[Nullable(2)]
		public unsafe USplineComponent Spline
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USplineComponent>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameManager.__PropertyOffset_Spline);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameManager.__PropertyOffset_Spline, value);
			}
		}

		// Token: 0x17001743 RID: 5955
		// (get) Token: 0x0600781A RID: 30746 RVA: 0x000AFA14 File Offset: 0x000ADC14
		// (set) Token: 0x0600781B RID: 30747 RVA: 0x000AFA28 File Offset: 0x000ADC28
		[Nullable(2)]
		public unsafe UKuroRhythmGameJudgement JudgementSystem
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroRhythmGameJudgement>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameManager.__PropertyOffset_JudgementSystem);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameManager.__PropertyOffset_JudgementSystem, value);
			}
		}

		// Token: 0x17001744 RID: 5956
		// (get) Token: 0x0600781C RID: 30748 RVA: 0x000AFA3D File Offset: 0x000ADC3D
		// (set) Token: 0x0600781D RID: 30749 RVA: 0x000AFA51 File Offset: 0x000ADC51
		[Nullable(2)]
		public unsafe UKuroRhythmGameShipController ShipController
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroRhythmGameShipController>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameManager.__PropertyOffset_ShipController);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameManager.__PropertyOffset_ShipController, value);
			}
		}

		// Token: 0x17001745 RID: 5957
		// (get) Token: 0x0600781E RID: 30750 RVA: 0x000AFA68 File Offset: 0x000ADC68
		// (set) Token: 0x0600781F RID: 30751 RVA: 0x000AFAA1 File Offset: 0x000ADCA1
		public FKuroRhythmGameConfig GameConfig
		{
			get
			{
				base.FastCheckIsValid();
				FKuroRhythmGameConfig result;
				if ((result = this._GameConfig) == null)
				{
					result = (this._GameConfig = new FKuroRhythmGameConfig(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_GameConfig, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmGameConfig.StaticStruct(), base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_GameConfig, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001746 RID: 5958
		// (get) Token: 0x06007820 RID: 30752 RVA: 0x000AFAC4 File Offset: 0x000ADCC4
		// (set) Token: 0x06007821 RID: 30753 RVA: 0x000AFAFD File Offset: 0x000ADCFD
		public TArray<FKuroRhythmSkillEffectParam> SkillEffectParams
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroRhythmSkillEffectParam> result;
				if ((result = this._SkillEffectParams) == null)
				{
					result = (this._SkillEffectParams = new TArray<FKuroRhythmSkillEffectParam>(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_SkillEffectParams, this));
				}
				return result;
			}
			set
			{
				this.SkillEffectParams.CopyAssign(value);
			}
		}

		// Token: 0x17001747 RID: 5959
		// (get) Token: 0x06007822 RID: 30754 RVA: 0x000AFB0C File Offset: 0x000ADD0C
		// (set) Token: 0x06007823 RID: 30755 RVA: 0x000AFB45 File Offset: 0x000ADD45
		public FKuroRhythmGameStatistics Statistics
		{
			get
			{
				base.FastCheckIsValid();
				FKuroRhythmGameStatistics result;
				if ((result = this._Statistics) == null)
				{
					result = (this._Statistics = new FKuroRhythmGameStatistics(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_Statistics, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmGameStatistics.StaticStruct(), base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_Statistics, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001748 RID: 5960
		// (get) Token: 0x06007824 RID: 30756 RVA: 0x000AFB68 File Offset: 0x000ADD68
		// (set) Token: 0x06007825 RID: 30757 RVA: 0x000AFBA1 File Offset: 0x000ADDA1
		public TArray<FKuroRhythmGameNote> ChartNotes
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroRhythmGameNote> result;
				if ((result = this._ChartNotes) == null)
				{
					result = (this._ChartNotes = new TArray<FKuroRhythmGameNote>(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_ChartNotes, this));
				}
				return result;
			}
			set
			{
				this.ChartNotes.CopyAssign(value);
			}
		}

		// Token: 0x17001749 RID: 5961
		// (get) Token: 0x06007826 RID: 30758 RVA: 0x000AFBAF File Offset: 0x000ADDAF
		// (set) Token: 0x06007827 RID: 30759 RVA: 0x000AFBBF File Offset: 0x000ADDBF
		public unsafe EKuroRhythmGamePhase CurrentPhase
		{
			get
			{
				return (EKuroRhythmGamePhase)(*(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_CurrentPhase));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_CurrentPhase) = (byte)value;
			}
		}

		// Token: 0x1700174A RID: 5962
		// (get) Token: 0x06007828 RID: 30760 RVA: 0x000AFBD0 File Offset: 0x000ADDD0
		// (set) Token: 0x06007829 RID: 30761 RVA: 0x000AFBE0 File Offset: 0x000ADDE0
		public unsafe bool bInitialized
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_bInitialized) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_bInitialized) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700174B RID: 5963
		// (get) Token: 0x0600782A RID: 30762 RVA: 0x000AFBF1 File Offset: 0x000ADDF1
		// (set) Token: 0x0600782B RID: 30763 RVA: 0x000AFC01 File Offset: 0x000ADE01
		public unsafe float GameStartTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_GameStartTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_GameStartTime) = value;
			}
		}

		// Token: 0x1700174C RID: 5964
		// (get) Token: 0x0600782C RID: 30764 RVA: 0x000AFC12 File Offset: 0x000ADE12
		// (set) Token: 0x0600782D RID: 30765 RVA: 0x000AFC22 File Offset: 0x000ADE22
		public unsafe float PausedTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_PausedTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_PausedTime) = value;
			}
		}

		// Token: 0x1700174D RID: 5965
		// (get) Token: 0x0600782E RID: 30766 RVA: 0x000AFC33 File Offset: 0x000ADE33
		// (set) Token: 0x0600782F RID: 30767 RVA: 0x000AFC43 File Offset: 0x000ADE43
		public unsafe float GameplayDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_GameplayDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_GameplayDuration) = value;
			}
		}

		// Token: 0x1700174E RID: 5966
		// (get) Token: 0x06007830 RID: 30768 RVA: 0x000AFC54 File Offset: 0x000ADE54
		// (set) Token: 0x06007831 RID: 30769 RVA: 0x000AFC64 File Offset: 0x000ADE64
		public unsafe float NoteEventTimeOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_NoteEventTimeOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_NoteEventTimeOffset) = value;
			}
		}

		// Token: 0x1700174F RID: 5967
		// (get) Token: 0x06007832 RID: 30770 RVA: 0x000AFC75 File Offset: 0x000ADE75
		// (set) Token: 0x06007833 RID: 30771 RVA: 0x000AFC85 File Offset: 0x000ADE85
		public unsafe float GameplayTimeOffset
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_GameplayTimeOffset);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_GameplayTimeOffset) = value;
			}
		}

		// Token: 0x17001750 RID: 5968
		// (get) Token: 0x06007834 RID: 30772 RVA: 0x000AFC96 File Offset: 0x000ADE96
		// (set) Token: 0x06007835 RID: 30773 RVA: 0x000AFCA6 File Offset: 0x000ADEA6
		public unsafe int CurrentFeverScore
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_CurrentFeverScore);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_CurrentFeverScore) = value;
			}
		}

		// Token: 0x17001751 RID: 5969
		// (get) Token: 0x06007836 RID: 30774 RVA: 0x000AFCB8 File Offset: 0x000ADEB8
		// (set) Token: 0x06007837 RID: 30775 RVA: 0x000AFCF1 File Offset: 0x000ADEF1
		public FKuroRhythmGameHiddenScore CurrentHiddenScore
		{
			get
			{
				base.FastCheckIsValid();
				FKuroRhythmGameHiddenScore result;
				if ((result = this._CurrentHiddenScore) == null)
				{
					result = (this._CurrentHiddenScore = new FKuroRhythmGameHiddenScore(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_CurrentHiddenScore, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmGameHiddenScore.StaticStruct(), base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_CurrentHiddenScore, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001752 RID: 5970
		// (get) Token: 0x06007838 RID: 30776 RVA: 0x000AFD12 File Offset: 0x000ADF12
		// (set) Token: 0x06007839 RID: 30777 RVA: 0x000AFD22 File Offset: 0x000ADF22
		public unsafe bool bFeverActive
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_bFeverActive) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_bFeverActive) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001753 RID: 5971
		// (get) Token: 0x0600783A RID: 30778 RVA: 0x000AFD33 File Offset: 0x000ADF33
		// (set) Token: 0x0600783B RID: 30779 RVA: 0x000AFD43 File Offset: 0x000ADF43
		public unsafe bool bIgnoreFeverAutoJudge
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_bIgnoreFeverAutoJudge) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_bIgnoreFeverAutoJudge) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001754 RID: 5972
		// (get) Token: 0x0600783C RID: 30780 RVA: 0x000AFD54 File Offset: 0x000ADF54
		// (set) Token: 0x0600783D RID: 30781 RVA: 0x000AFD64 File Offset: 0x000ADF64
		public unsafe float FeverScoreGlobalMultiple
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_FeverScoreGlobalMultiple);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_FeverScoreGlobalMultiple) = value;
			}
		}

		// Token: 0x17001755 RID: 5973
		// (get) Token: 0x0600783E RID: 30782 RVA: 0x000AFD75 File Offset: 0x000ADF75
		// (set) Token: 0x0600783F RID: 30783 RVA: 0x000AFD85 File Offset: 0x000ADF85
		public unsafe float FeverConsumptionTime
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_FeverConsumptionTime);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_FeverConsumptionTime) = value;
			}
		}

		// Token: 0x17001756 RID: 5974
		// (get) Token: 0x06007840 RID: 30784 RVA: 0x000AFD96 File Offset: 0x000ADF96
		// (set) Token: 0x06007841 RID: 30785 RVA: 0x000AFDA6 File Offset: 0x000ADFA6
		public unsafe bool bLineKeyPressed
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_bLineKeyPressed) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_bLineKeyPressed) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001757 RID: 5975
		// (get) Token: 0x06007842 RID: 30786 RVA: 0x000AFDB7 File Offset: 0x000ADFB7
		// (set) Token: 0x06007843 RID: 30787 RVA: 0x000AFDC7 File Offset: 0x000ADFC7
		public unsafe int CurrentTrackIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_CurrentTrackIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_CurrentTrackIndex) = value;
			}
		}

		// Token: 0x17001758 RID: 5976
		// (get) Token: 0x06007844 RID: 30788 RVA: 0x000AFDD8 File Offset: 0x000ADFD8
		// (set) Token: 0x06007845 RID: 30789 RVA: 0x000AFDE8 File Offset: 0x000ADFE8
		public unsafe EKuroRhythmChartEventType CurrentRoadState
		{
			get
			{
				return (EKuroRhythmChartEventType)(*(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_CurrentRoadState));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_CurrentRoadState) = (byte)value;
			}
		}

		// Token: 0x17001759 RID: 5977
		// (get) Token: 0x06007846 RID: 30790 RVA: 0x000AFDF9 File Offset: 0x000ADFF9
		// (set) Token: 0x06007847 RID: 30791 RVA: 0x000AFE09 File Offset: 0x000AE009
		public unsafe float CurrentBPM
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_CurrentBPM);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_CurrentBPM) = value;
			}
		}

		// Token: 0x1700175A RID: 5978
		// (get) Token: 0x06007848 RID: 30792 RVA: 0x000AFE1C File Offset: 0x000AE01C
		// (set) Token: 0x06007849 RID: 30793 RVA: 0x000AFE55 File Offset: 0x000AE055
		public TMap<EKuroRhythmGameInputType, FCachedInputState> CachedInputEvents
		{
			get
			{
				base.FastCheckIsValid();
				TMap<EKuroRhythmGameInputType, FCachedInputState> result;
				if ((result = this._CachedInputEvents) == null)
				{
					result = (this._CachedInputEvents = new TMap<EKuroRhythmGameInputType, FCachedInputState>(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_CachedInputEvents, this));
				}
				return result;
			}
			set
			{
				this.CachedInputEvents.CopyAssign(value);
			}
		}

		// Token: 0x0600784A RID: 30794 RVA: 0x000AFE64 File Offset: 0x000AE064
		[SkipLocalsInit]
		public unsafe void Tick(float DeltaTime)
		{
			UKuroRhythmGameManager.__Tick_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__Tick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameManager.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__Tick_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600784B RID: 30795 RVA: 0x000AFEAC File Offset: 0x000AE0AC
		[SkipLocalsInit]
		public unsafe void SwitchTrackInfinity(bool bGoLeft)
		{
			UKuroRhythmGameManager.__SwitchTrackInfinity_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__SwitchTrackInfinity_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroRhythmGameManager.__SwitchTrackInfinity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__SwitchTrackInfinity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bGoLeft = bGoLeft;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__SwitchTrackInfinity_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600784C RID: 30796 RVA: 0x000AFEF4 File Offset: 0x000AE0F4
		[SkipLocalsInit]
		public unsafe bool SwitchTrack(bool bGoLeft)
		{
			UKuroRhythmGameManager.__SwitchTrack_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__SwitchTrack_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UKuroRhythmGameManager.__SwitchTrack_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__SwitchTrack_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bGoLeft = bGoLeft;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__SwitchTrack_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600784D RID: 30797 RVA: 0x000AFF40 File Offset: 0x000AE140
		[SkipLocalsInit]
		public unsafe void StopGame(bool bSuccess)
		{
			UKuroRhythmGameManager.__StopGame_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__StopGame_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroRhythmGameManager.__StopGame_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__StopGame_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bSuccess = bSuccess;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__StopGame_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600784E RID: 30798 RVA: 0x000AFF86 File Offset: 0x000AE186
		[SkipLocalsInit]
		public void StartGame()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__StartGame_NativeFunctionPtr, null);
		}

		// Token: 0x0600784F RID: 30799 RVA: 0x000AFF9C File Offset: 0x000AE19C
		[SkipLocalsInit]
		public unsafe void SetShipMovementSpeed(float InSpeed)
		{
			UKuroRhythmGameManager.__SetShipMovementSpeed_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__SetShipMovementSpeed_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameManager.__SetShipMovementSpeed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__SetShipMovementSpeed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InSpeed = InSpeed;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__SetShipMovementSpeed_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06007850 RID: 30800 RVA: 0x000AFFE4 File Offset: 0x000AE1E4
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe void SendChartDataToNiagara(in FKuroRhythmChartData InChartData)
		{
			UKuroRhythmGameManager.__SendChartDataToNiagara_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__SendChartDataToNiagara_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(UKuroRhythmGameManager.__SendChartDataToNiagara_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__SendChartDataToNiagara_NativeFunctionPtr, (void*)ptr, 1);
			if (InChartData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmChartData.StaticStruct(), &ptr->InChartData, InChartData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__SendChartDataToNiagara_NativeFunctionPtr, (void*)ptr);
			UnrealReflectionUtils.DestroyStruct(UKuroRhythmGameManager.__SendChartDataToNiagara_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x06007851 RID: 30801 RVA: 0x000B0058 File Offset: 0x000AE258
		[SkipLocalsInit]
		public void ResumeGame()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__ResumeGame_NativeFunctionPtr, null);
		}

		// Token: 0x06007852 RID: 30802 RVA: 0x000B006C File Offset: 0x000AE26C
		[SkipLocalsInit]
		public void RestartGame()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__RestartGame_NativeFunctionPtr, null);
		}

		// Token: 0x06007853 RID: 30803 RVA: 0x000B0080 File Offset: 0x000AE280
		[SkipLocalsInit]
		public void PauseGame()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__PauseGame_NativeFunctionPtr, null);
		}

		// Token: 0x06007854 RID: 30804 RVA: 0x000B0094 File Offset: 0x000AE294
		[SkipLocalsInit]
		public unsafe bool ParseChartDataFromJson(string JsonString, [Nullable(2)] ref FKuroRhythmChartData OutChartData)
		{
			UKuroRhythmGameManager.__ParseChartDataFromJson_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__ParseChartDataFromJson_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(UKuroRhythmGameManager.__ParseChartDataFromJson_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__ParseChartDataFromJson_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->JsonString), JsonString);
			if (OutChartData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmChartData.StaticStruct(), &ptr->OutChartData, OutChartData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__ParseChartDataFromJson_NativeFunctionPtr, (void*)ptr);
			if (OutChartData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmChartData.StaticStruct(), OutChartData.NativePtr, &ptr->OutChartData, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroRhythmGameManager.__ParseChartDataFromJson_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x06007855 RID: 30805 RVA: 0x000B0140 File Offset: 0x000AE340
		[SkipLocalsInit]
		public unsafe void OnPlayerInputUp(EKuroRhythmGameInputType InputType)
		{
			UKuroRhythmGameManager.__OnPlayerInputUp_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__OnPlayerInputUp_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroRhythmGameManager.__OnPlayerInputUp_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__OnPlayerInputUp_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InputType = InputType;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__OnPlayerInputUp_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06007856 RID: 30806 RVA: 0x000B0188 File Offset: 0x000AE388
		[SkipLocalsInit]
		public unsafe void OnPlayerInputDown(EKuroRhythmGameInputType InputType)
		{
			UKuroRhythmGameManager.__OnPlayerInputDown_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__OnPlayerInputDown_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroRhythmGameManager.__OnPlayerInputDown_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__OnPlayerInputDown_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InputType = InputType;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__OnPlayerInputDown_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06007857 RID: 30807 RVA: 0x000B01D0 File Offset: 0x000AE3D0
		[SkipLocalsInit]
		public unsafe void OnNoteMissed(int NoteIndex)
		{
			UKuroRhythmGameManager.__OnNoteMissed_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__OnNoteMissed_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameManager.__OnNoteMissed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__OnNoteMissed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NoteIndex = NoteIndex;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__OnNoteMissed_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x06007858 RID: 30808 RVA: 0x000B0218 File Offset: 0x000AE418
		[SkipLocalsInit]
		public unsafe bool IsGameRunning()
		{
			UKuroRhythmGameManager.__IsGameRunning_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__IsGameRunning_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroRhythmGameManager.__IsGameRunning_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__IsGameRunning_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__IsGameRunning_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06007859 RID: 30809 RVA: 0x000B0260 File Offset: 0x000AE460
		[SkipLocalsInit]
		public unsafe bool IsGameInitialized()
		{
			UKuroRhythmGameManager.__IsGameInitialized_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__IsGameInitialized_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroRhythmGameManager.__IsGameInitialized_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__IsGameInitialized_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__IsGameInitialized_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600785A RID: 30810 RVA: 0x000B02A8 File Offset: 0x000AE4A8
		[SkipLocalsInit]
		public unsafe bool IsFeverActive()
		{
			UKuroRhythmGameManager.__IsFeverActive_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__IsFeverActive_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroRhythmGameManager.__IsFeverActive_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__IsFeverActive_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__IsFeverActive_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x0600785B RID: 30811 RVA: 0x000B02F0 File Offset: 0x000AE4F0
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe bool InitializeGame(in FKuroRhythmGameConfig InConfig, [Nullable(new byte[]
		{
			2,
			1
		})] ref TArray<FKuroRhythmSkillEffectParam> InSkillEffectParams, AActor InShipActor = null, USplineComponent InSpline = null)
		{
			UKuroRhythmGameManager.__InitializeGame_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__InitializeGame_FunctionParams[(UIntPtr)327] + 15L / (long)sizeof(UKuroRhythmGameManager.__InitializeGame_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__InitializeGame_NativeFunctionPtr, (void*)ptr, 1);
			if (InConfig != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmGameConfig.StaticStruct(), &ptr->InConfig, InConfig.NativePtr, 1, false);
			}
			TArray<FKuroRhythmSkillEffectParam> tarray = InSkillEffectParams;
			if (tarray != null)
			{
				tarray.MoveTo(&ptr->InSkillEffectParams);
			}
			ptr->InShipActor = ((InShipActor != null) ? InShipActor.NativePtr : IntPtr.Zero);
			ptr->InSpline = ((InSpline != null) ? InSpline.NativePtr : IntPtr.Zero);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__InitializeGame_NativeFunctionPtr, (void*)ptr);
			TArray<FKuroRhythmSkillEffectParam> tarray2 = InSkillEffectParams;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSkillEffectParams);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroRhythmGameManager.__InitializeGame_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0600785C RID: 30812 RVA: 0x000B03C4 File Offset: 0x000AE5C4
		[SkipLocalsInit]
		public unsafe void HandleHoldScoreUpdated(int ScoreGained, int CurrentBeat)
		{
			UKuroRhythmGameManager.__HandleHoldScoreUpdated_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__HandleHoldScoreUpdated_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroRhythmGameManager.__HandleHoldScoreUpdated_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__HandleHoldScoreUpdated_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ScoreGained = ScoreGained;
			ptr->CurrentBeat = CurrentBeat;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__HandleHoldScoreUpdated_NativeFunctionPtr, (void*)ptr);
		}

		// Token: 0x0600785D RID: 30813 RVA: 0x000B0411 File Offset: 0x000AE611
		[SkipLocalsInit]
		public void HandleHoldNoteTimeout()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__HandleHoldNoteTimeout_NativeFunctionPtr, null);
		}

		// Token: 0x0600785E RID: 30814 RVA: 0x000B0425 File Offset: 0x000AE625
		[SkipLocalsInit]
		public void HandleHoldNoteInputReleased()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__HandleHoldNoteInputReleased_NativeFunctionPtr, null);
		}

		// Token: 0x0600785F RID: 30815 RVA: 0x000B043C File Offset: 0x000AE63C
		[SkipLocalsInit]
		public unsafe FKuroRhythmGameStatistics GetStatistics()
		{
			UKuroRhythmGameManager.__GetStatistics_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__GetStatistics_FunctionParams[(UIntPtr)59] + 15L / (long)sizeof(UKuroRhythmGameManager.__GetStatistics_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__GetStatistics_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__GetStatistics_NativeFunctionPtr, (void*)ptr);
			return new FKuroRhythmGameStatistics(&ptr->__Result, true, true);
		}

		// Token: 0x06007860 RID: 30816 RVA: 0x000B048C File Offset: 0x000AE68C
		[NullableContext(2)]
		[SkipLocalsInit]
		public unsafe UKuroRhythmGameShipController GetShipController()
		{
			UKuroRhythmGameManager.__GetShipController_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__GetShipController_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroRhythmGameManager.__GetShipController_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__GetShipController_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__GetShipController_NativeFunctionPtr, (void*)ptr);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroRhythmGameShipController>(ptr->__Result);
		}

		// Token: 0x06007861 RID: 30817 RVA: 0x000B04D8 File Offset: 0x000AE6D8
		[SkipLocalsInit]
		public unsafe FKuroRhythmGameHiddenScore GetHiddenScore()
		{
			UKuroRhythmGameManager.__GetHiddenScore_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__GetHiddenScore_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(UKuroRhythmGameManager.__GetHiddenScore_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__GetHiddenScore_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__GetHiddenScore_NativeFunctionPtr, (void*)ptr);
			return new FKuroRhythmGameHiddenScore(&ptr->__Result, true, true);
		}

		// Token: 0x06007862 RID: 30818 RVA: 0x000B0528 File Offset: 0x000AE728
		[SkipLocalsInit]
		public unsafe float GetGameplayTime()
		{
			UKuroRhythmGameManager.__GetGameplayTime_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__GetGameplayTime_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameManager.__GetGameplayTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__GetGameplayTime_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__GetGameplayTime_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06007863 RID: 30819 RVA: 0x000B0570 File Offset: 0x000AE770
		[SkipLocalsInit]
		public unsafe float GetGameplayDuration()
		{
			UKuroRhythmGameManager.__GetGameplayDuration_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__GetGameplayDuration_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameManager.__GetGameplayDuration_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__GetGameplayDuration_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__GetGameplayDuration_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06007864 RID: 30820 RVA: 0x000B05B8 File Offset: 0x000AE7B8
		[SkipLocalsInit]
		public unsafe FKuroRhythmGameConfig GetGameConfig()
		{
			UKuroRhythmGameManager.__GetGameConfig_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__GetGameConfig_FunctionParams[(UIntPtr)287] + 15L / (long)sizeof(UKuroRhythmGameManager.__GetGameConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__GetGameConfig_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__GetGameConfig_NativeFunctionPtr, (void*)ptr);
			return new FKuroRhythmGameConfig(&ptr->__Result, true, true);
		}

		// Token: 0x06007865 RID: 30821 RVA: 0x000B0608 File Offset: 0x000AE808
		[SkipLocalsInit]
		public unsafe int GetFeverScore()
		{
			UKuroRhythmGameManager.__GetFeverScore_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__GetFeverScore_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameManager.__GetFeverScore_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__GetFeverScore_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__GetFeverScore_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06007866 RID: 30822 RVA: 0x000B0650 File Offset: 0x000AE850
		[SkipLocalsInit]
		public unsafe int GetCurrentTrackIndex()
		{
			UKuroRhythmGameManager.__GetCurrentTrackIndex_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__GetCurrentTrackIndex_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameManager.__GetCurrentTrackIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__GetCurrentTrackIndex_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__GetCurrentTrackIndex_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06007867 RID: 30823 RVA: 0x000B0698 File Offset: 0x000AE898
		[SkipLocalsInit]
		public unsafe EKuroRhythmGamePhase GetCurrentPhase()
		{
			UKuroRhythmGameManager.__GetCurrentPhase_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__GetCurrentPhase_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroRhythmGameManager.__GetCurrentPhase_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__GetCurrentPhase_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__GetCurrentPhase_NativeFunctionPtr, (void*)ptr);
			return ptr->__Result;
		}

		// Token: 0x06007868 RID: 30824 RVA: 0x000B06DD File Offset: 0x000AE8DD
		[SkipLocalsInit]
		public void Cleanup()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__Cleanup_NativeFunctionPtr, null);
		}

		// Token: 0x06007869 RID: 30825 RVA: 0x000B06F1 File Offset: 0x000AE8F1
		static UKuroRhythmGameManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRhythmGame.KuroRhythmGameManager");
		}

		// Token: 0x0600786A RID: 30826 RVA: 0x000B06FF File Offset: 0x000AE8FF
		protected UKuroRhythmGameManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040032D7 RID: 13015
		public new const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmGameManager";

		// Token: 0x040032D8 RID: 13016
		private static IntPtr _ClassPtr;

		// Token: 0x040032D9 RID: 13017
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040032DA RID: 13018
		internal static int __PropertyOffset_OnNoteResult;

		// Token: 0x040032DB RID: 13019
		[Nullable(2)]
		private FOnNoteResult _OnNoteResult;

		// Token: 0x040032DC RID: 13020
		internal static int __PropertyOffset_OnAllNotesFinished;

		// Token: 0x040032DD RID: 13021
		[Nullable(2)]
		private FOnAllNotesFinished _OnAllNotesFinished;

		// Token: 0x040032DE RID: 13022
		internal static int __PropertyOffset_OnFeverStateChanged;

		// Token: 0x040032DF RID: 13023
		[Nullable(2)]
		private FOnFeverStateChanged _OnFeverStateChanged;

		// Token: 0x040032E0 RID: 13024
		internal static int __PropertyOffset_OnHiddenScoreLevelChanged;

		// Token: 0x040032E1 RID: 13025
		[Nullable(2)]
		private FOnHiddenScoreLevelChanged _OnHiddenScoreLevelChanged;

		// Token: 0x040032E2 RID: 13026
		internal static int __PropertyOffset_OnFeverScoreChanged;

		// Token: 0x040032E3 RID: 13027
		[Nullable(2)]
		private FOnFeverScoreChanged _OnFeverScoreChanged;

		// Token: 0x040032E4 RID: 13028
		internal static int __PropertyOffset_OnJumpEvent;

		// Token: 0x040032E5 RID: 13029
		[Nullable(2)]
		private FOnJumpEvent _OnJumpEvent;

		// Token: 0x040032E6 RID: 13030
		internal static int __PropertyOffset_OnTrackSwitched;

		// Token: 0x040032E7 RID: 13031
		[Nullable(2)]
		private FOnTrackSwitched _OnTrackSwitched;

		// Token: 0x040032E8 RID: 13032
		internal static int __PropertyOffset_OnHoldScoreUpdated;

		// Token: 0x040032E9 RID: 13033
		[Nullable(2)]
		private FOnHoldScoreUpdated _OnHoldScoreUpdated;

		// Token: 0x040032EA RID: 13034
		internal static int __PropertyOffset_OnGameEvent;

		// Token: 0x040032EB RID: 13035
		[Nullable(2)]
		private FOnGameEvent _OnGameEvent;

		// Token: 0x040032EC RID: 13036
		internal static int __PropertyOffset_ShipActor;

		// Token: 0x040032ED RID: 13037
		internal static int __PropertyOffset_Spline;

		// Token: 0x040032EE RID: 13038
		internal static int __PropertyOffset_JudgementSystem;

		// Token: 0x040032EF RID: 13039
		internal static int __PropertyOffset_ShipController;

		// Token: 0x040032F0 RID: 13040
		internal static int __PropertyOffset_GameConfig;

		// Token: 0x040032F1 RID: 13041
		[Nullable(2)]
		private FKuroRhythmGameConfig _GameConfig;

		// Token: 0x040032F2 RID: 13042
		internal static int __PropertyOffset_SkillEffectParams;

		// Token: 0x040032F3 RID: 13043
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroRhythmSkillEffectParam> _SkillEffectParams;

		// Token: 0x040032F4 RID: 13044
		internal static int __PropertyOffset_Statistics;

		// Token: 0x040032F5 RID: 13045
		[Nullable(2)]
		private FKuroRhythmGameStatistics _Statistics;

		// Token: 0x040032F6 RID: 13046
		internal static int __PropertyOffset_ChartNotes;

		// Token: 0x040032F7 RID: 13047
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroRhythmGameNote> _ChartNotes;

		// Token: 0x040032F8 RID: 13048
		internal static int __PropertyOffset_CurrentPhase;

		// Token: 0x040032F9 RID: 13049
		internal static int __PropertyOffset_bInitialized;

		// Token: 0x040032FA RID: 13050
		internal static int __PropertyOffset_GameStartTime;

		// Token: 0x040032FB RID: 13051
		internal static int __PropertyOffset_PausedTime;

		// Token: 0x040032FC RID: 13052
		internal static int __PropertyOffset_GameplayDuration;

		// Token: 0x040032FD RID: 13053
		internal static int __PropertyOffset_NoteEventTimeOffset;

		// Token: 0x040032FE RID: 13054
		internal static int __PropertyOffset_GameplayTimeOffset;

		// Token: 0x040032FF RID: 13055
		internal static int __PropertyOffset_CurrentFeverScore;

		// Token: 0x04003300 RID: 13056
		internal static int __PropertyOffset_CurrentHiddenScore;

		// Token: 0x04003301 RID: 13057
		[Nullable(2)]
		private FKuroRhythmGameHiddenScore _CurrentHiddenScore;

		// Token: 0x04003302 RID: 13058
		internal static int __PropertyOffset_bFeverActive;

		// Token: 0x04003303 RID: 13059
		internal static int __PropertyOffset_bIgnoreFeverAutoJudge;

		// Token: 0x04003304 RID: 13060
		internal static int __PropertyOffset_FeverScoreGlobalMultiple;

		// Token: 0x04003305 RID: 13061
		internal static int __PropertyOffset_FeverConsumptionTime;

		// Token: 0x04003306 RID: 13062
		internal static int __PropertyOffset_bLineKeyPressed;

		// Token: 0x04003307 RID: 13063
		internal static int __PropertyOffset_CurrentTrackIndex;

		// Token: 0x04003308 RID: 13064
		internal static int __PropertyOffset_CurrentRoadState;

		// Token: 0x04003309 RID: 13065
		internal static int __PropertyOffset_CurrentBPM;

		// Token: 0x0400330A RID: 13066
		internal static int __PropertyOffset_CachedInputEvents;

		// Token: 0x0400330B RID: 13067
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EKuroRhythmGameInputType, FCachedInputState> _CachedInputEvents;

		// Token: 0x0400330C RID: 13068
		private static IntPtr __Tick_NativeFunctionPtr;

		// Token: 0x0400330D RID: 13069
		private static IntPtr __SwitchTrackInfinity_NativeFunctionPtr;

		// Token: 0x0400330E RID: 13070
		private static IntPtr __SwitchTrack_NativeFunctionPtr;

		// Token: 0x0400330F RID: 13071
		private static IntPtr __StopGame_NativeFunctionPtr;

		// Token: 0x04003310 RID: 13072
		private static IntPtr __StartGame_NativeFunctionPtr;

		// Token: 0x04003311 RID: 13073
		private static IntPtr __SetShipMovementSpeed_NativeFunctionPtr;

		// Token: 0x04003312 RID: 13074
		private static IntPtr __SendChartDataToNiagara_NativeFunctionPtr;

		// Token: 0x04003313 RID: 13075
		private static IntPtr __ResumeGame_NativeFunctionPtr;

		// Token: 0x04003314 RID: 13076
		private static IntPtr __RestartGame_NativeFunctionPtr;

		// Token: 0x04003315 RID: 13077
		private static IntPtr __PauseGame_NativeFunctionPtr;

		// Token: 0x04003316 RID: 13078
		private static IntPtr __ParseChartDataFromJson_NativeFunctionPtr;

		// Token: 0x04003317 RID: 13079
		private static IntPtr __OnPlayerInputUp_NativeFunctionPtr;

		// Token: 0x04003318 RID: 13080
		private static IntPtr __OnPlayerInputDown_NativeFunctionPtr;

		// Token: 0x04003319 RID: 13081
		private static IntPtr __OnNoteMissed_NativeFunctionPtr;

		// Token: 0x0400331A RID: 13082
		private static IntPtr __IsGameRunning_NativeFunctionPtr;

		// Token: 0x0400331B RID: 13083
		private static IntPtr __IsGameInitialized_NativeFunctionPtr;

		// Token: 0x0400331C RID: 13084
		private static IntPtr __IsFeverActive_NativeFunctionPtr;

		// Token: 0x0400331D RID: 13085
		private static IntPtr __InitializeGame_NativeFunctionPtr;

		// Token: 0x0400331E RID: 13086
		private static IntPtr __HandleHoldScoreUpdated_NativeFunctionPtr;

		// Token: 0x0400331F RID: 13087
		private static IntPtr __HandleHoldNoteTimeout_NativeFunctionPtr;

		// Token: 0x04003320 RID: 13088
		private static IntPtr __HandleHoldNoteInputReleased_NativeFunctionPtr;

		// Token: 0x04003321 RID: 13089
		private static IntPtr __GetStatistics_NativeFunctionPtr;

		// Token: 0x04003322 RID: 13090
		private static IntPtr __GetShipController_NativeFunctionPtr;

		// Token: 0x04003323 RID: 13091
		private static IntPtr __GetHiddenScore_NativeFunctionPtr;

		// Token: 0x04003324 RID: 13092
		private static IntPtr __GetGameplayTime_NativeFunctionPtr;

		// Token: 0x04003325 RID: 13093
		private static IntPtr __GetGameplayDuration_NativeFunctionPtr;

		// Token: 0x04003326 RID: 13094
		private static IntPtr __GetGameConfig_NativeFunctionPtr;

		// Token: 0x04003327 RID: 13095
		private static IntPtr __GetFeverScore_NativeFunctionPtr;

		// Token: 0x04003328 RID: 13096
		private static IntPtr __GetCurrentTrackIndex_NativeFunctionPtr;

		// Token: 0x04003329 RID: 13097
		private static IntPtr __GetCurrentPhase_NativeFunctionPtr;

		// Token: 0x0400332A RID: 13098
		private static IntPtr __Cleanup_NativeFunctionPtr;

		// Token: 0x02000C40 RID: 3136
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Tick_FunctionParams
		{
			// Token: 0x04005E8D RID: 24205
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x02000C41 RID: 3137
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SwitchTrackInfinity_FunctionParams
		{
			// Token: 0x04005E8E RID: 24206
			[FieldOffset(0)]
			public bool bGoLeft;
		}

		// Token: 0x02000C42 RID: 3138
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __SwitchTrack_FunctionParams
		{
			// Token: 0x04005E8F RID: 24207
			[FieldOffset(0)]
			public bool bGoLeft;

			// Token: 0x04005E90 RID: 24208
			[FieldOffset(1)]
			public bool __Result;
		}

		// Token: 0x02000C43 RID: 3139
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __StopGame_FunctionParams
		{
			// Token: 0x04005E91 RID: 24209
			[FieldOffset(0)]
			public bool bSuccess;
		}

		// Token: 0x02000C44 RID: 3140
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetShipMovementSpeed_FunctionParams
		{
			// Token: 0x04005E92 RID: 24210
			[FieldOffset(0)]
			public float InSpeed;
		}

		// Token: 0x02000C45 RID: 3141
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __SendChartDataToNiagara_FunctionParams
		{
			// Token: 0x04005E93 RID: 24211
			[FieldOffset(0)]
			public byte InChartData;
		}

		// Token: 0x02000C46 RID: 3142
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __ParseChartDataFromJson_FunctionParams
		{
			// Token: 0x04005E94 RID: 24212
			[FieldOffset(0)]
			public FString JsonString;

			// Token: 0x04005E95 RID: 24213
			[FieldOffset(16)]
			public byte OutChartData;

			// Token: 0x04005E96 RID: 24214
			[FieldOffset(88)]
			public bool __Result;
		}

		// Token: 0x02000C47 RID: 3143
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnPlayerInputUp_FunctionParams
		{
			// Token: 0x04005E97 RID: 24215
			[FieldOffset(0)]
			public EKuroRhythmGameInputType InputType;
		}

		// Token: 0x02000C48 RID: 3144
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnPlayerInputDown_FunctionParams
		{
			// Token: 0x04005E98 RID: 24216
			[FieldOffset(0)]
			public EKuroRhythmGameInputType InputType;
		}

		// Token: 0x02000C49 RID: 3145
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnNoteMissed_FunctionParams
		{
			// Token: 0x04005E99 RID: 24217
			[FieldOffset(0)]
			public int NoteIndex;
		}

		// Token: 0x02000C4A RID: 3146
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsGameRunning_FunctionParams
		{
			// Token: 0x04005E9A RID: 24218
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000C4B RID: 3147
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsGameInitialized_FunctionParams
		{
			// Token: 0x04005E9B RID: 24219
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000C4C RID: 3148
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsFeverActive_FunctionParams
		{
			// Token: 0x04005E9C RID: 24220
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x02000C4D RID: 3149
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 312)]
		protected ref struct __InitializeGame_FunctionParams
		{
			// Token: 0x04005E9D RID: 24221
			[FieldOffset(0)]
			public byte InConfig;

			// Token: 0x04005E9E RID: 24222
			[FieldOffset(272)]
			public byte InSkillEffectParams;

			// Token: 0x04005E9F RID: 24223
			[FieldOffset(288)]
			public IntPtr InShipActor;

			// Token: 0x04005EA0 RID: 24224
			[FieldOffset(296)]
			public IntPtr InSpline;

			// Token: 0x04005EA1 RID: 24225
			[FieldOffset(304)]
			public bool __Result;
		}

		// Token: 0x02000C4E RID: 3150
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __HandleHoldScoreUpdated_FunctionParams
		{
			// Token: 0x04005EA2 RID: 24226
			[FieldOffset(0)]
			public int ScoreGained;

			// Token: 0x04005EA3 RID: 24227
			[FieldOffset(4)]
			public int CurrentBeat;
		}

		// Token: 0x02000C4F RID: 3151
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected ref struct __GetStatistics_FunctionParams
		{
			// Token: 0x04005EA4 RID: 24228
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02000C50 RID: 3152
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetShipController_FunctionParams
		{
			// Token: 0x04005EA5 RID: 24229
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x02000C51 RID: 3153
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __GetHiddenScore_FunctionParams
		{
			// Token: 0x04005EA6 RID: 24230
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02000C52 RID: 3154
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetGameplayTime_FunctionParams
		{
			// Token: 0x04005EA7 RID: 24231
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x02000C53 RID: 3155
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetGameplayDuration_FunctionParams
		{
			// Token: 0x04005EA8 RID: 24232
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x02000C54 RID: 3156
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 272)]
		protected ref struct __GetGameConfig_FunctionParams
		{
			// Token: 0x04005EA9 RID: 24233
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x02000C55 RID: 3157
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetFeverScore_FunctionParams
		{
			// Token: 0x04005EAA RID: 24234
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000C56 RID: 3158
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetCurrentTrackIndex_FunctionParams
		{
			// Token: 0x04005EAB RID: 24235
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x02000C57 RID: 3159
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetCurrentPhase_FunctionParams
		{
			// Token: 0x04005EAC RID: 24236
			[FieldOffset(0)]
			public EKuroRhythmGamePhase __Result;
		}
	}
}
