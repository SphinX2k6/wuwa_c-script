using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02001C53 RID: 7251
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroRhythmGame.KuroRhythmGameManager")]
	[UnrealStructLayout(928, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 928)]
	public class UKuroRhythmGameManager : UWorldSubsystem, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0601C1A9 RID: 115113 RVA: 0x002960E9 File Offset: 0x002942E9
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UKuroRhythmGameManager._ClassPtr;
		}

		// Token: 0x0601C1AA RID: 115114 RVA: 0x002960F8 File Offset: 0x002942F8
		public UKuroRhythmGameManager() : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmGameManager.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0601C1AB RID: 115115 RVA: 0x00296120 File Offset: 0x00294320
		public UKuroRhythmGameManager(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UKuroRhythmGameManager.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170071A7 RID: 29095
		// (get) Token: 0x0601C1AC RID: 115116 RVA: 0x00296154 File Offset: 0x00294354
		// (set) Token: 0x0601C1AD RID: 115117 RVA: 0x0029618D File Offset: 0x0029438D
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

		// Token: 0x170071A8 RID: 29096
		// (get) Token: 0x0601C1AE RID: 115118 RVA: 0x002961B0 File Offset: 0x002943B0
		// (set) Token: 0x0601C1AF RID: 115119 RVA: 0x002961E9 File Offset: 0x002943E9
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

		// Token: 0x170071A9 RID: 29097
		// (get) Token: 0x0601C1B0 RID: 115120 RVA: 0x0029620C File Offset: 0x0029440C
		// (set) Token: 0x0601C1B1 RID: 115121 RVA: 0x00296245 File Offset: 0x00294445
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

		// Token: 0x170071AA RID: 29098
		// (get) Token: 0x0601C1B2 RID: 115122 RVA: 0x00296268 File Offset: 0x00294468
		// (set) Token: 0x0601C1B3 RID: 115123 RVA: 0x002962A1 File Offset: 0x002944A1
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

		// Token: 0x170071AB RID: 29099
		// (get) Token: 0x0601C1B4 RID: 115124 RVA: 0x002962C4 File Offset: 0x002944C4
		// (set) Token: 0x0601C1B5 RID: 115125 RVA: 0x002962FD File Offset: 0x002944FD
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

		// Token: 0x170071AC RID: 29100
		// (get) Token: 0x0601C1B6 RID: 115126 RVA: 0x00296320 File Offset: 0x00294520
		// (set) Token: 0x0601C1B7 RID: 115127 RVA: 0x00296359 File Offset: 0x00294559
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

		// Token: 0x170071AD RID: 29101
		// (get) Token: 0x0601C1B8 RID: 115128 RVA: 0x0029637C File Offset: 0x0029457C
		// (set) Token: 0x0601C1B9 RID: 115129 RVA: 0x002963B5 File Offset: 0x002945B5
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

		// Token: 0x170071AE RID: 29102
		// (get) Token: 0x0601C1BA RID: 115130 RVA: 0x002963D8 File Offset: 0x002945D8
		// (set) Token: 0x0601C1BB RID: 115131 RVA: 0x00296411 File Offset: 0x00294611
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

		// Token: 0x170071AF RID: 29103
		// (get) Token: 0x0601C1BC RID: 115132 RVA: 0x00296434 File Offset: 0x00294634
		// (set) Token: 0x0601C1BD RID: 115133 RVA: 0x0029646D File Offset: 0x0029466D
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

		// Token: 0x170071B0 RID: 29104
		// (get) Token: 0x0601C1BE RID: 115134 RVA: 0x0029648E File Offset: 0x0029468E
		// (set) Token: 0x0601C1BF RID: 115135 RVA: 0x002964A2 File Offset: 0x002946A2
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

		// Token: 0x170071B1 RID: 29105
		// (get) Token: 0x0601C1C0 RID: 115136 RVA: 0x002964B7 File Offset: 0x002946B7
		// (set) Token: 0x0601C1C1 RID: 115137 RVA: 0x002964CB File Offset: 0x002946CB
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

		// Token: 0x170071B2 RID: 29106
		// (get) Token: 0x0601C1C2 RID: 115138 RVA: 0x002964E0 File Offset: 0x002946E0
		// (set) Token: 0x0601C1C3 RID: 115139 RVA: 0x002964F4 File Offset: 0x002946F4
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

		// Token: 0x170071B3 RID: 29107
		// (get) Token: 0x0601C1C4 RID: 115140 RVA: 0x00296509 File Offset: 0x00294709
		// (set) Token: 0x0601C1C5 RID: 115141 RVA: 0x0029651D File Offset: 0x0029471D
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

		// Token: 0x170071B4 RID: 29108
		// (get) Token: 0x0601C1C6 RID: 115142 RVA: 0x00296532 File Offset: 0x00294732
		// (set) Token: 0x0601C1C7 RID: 115143 RVA: 0x00296546 File Offset: 0x00294746
		[Nullable(2)]
		public unsafe UKuroRhythmGameEffectManager EffectManager
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroRhythmGameEffectManager>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameManager.__PropertyOffset_EffectManager);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameManager.__PropertyOffset_EffectManager, value);
			}
		}

		// Token: 0x170071B5 RID: 29109
		// (get) Token: 0x0601C1C8 RID: 115144 RVA: 0x0029655B File Offset: 0x0029475B
		// (set) Token: 0x0601C1C9 RID: 115145 RVA: 0x0029656F File Offset: 0x0029476F
		[Nullable(2)]
		public unsafe UKuroRhythmGameSkillEffectManager SkillEffectManager
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UKuroRhythmGameSkillEffectManager>(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameManager.__PropertyOffset_SkillEffectManager);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UKuroRhythmGameManager.__PropertyOffset_SkillEffectManager, value);
			}
		}

		// Token: 0x170071B6 RID: 29110
		// (get) Token: 0x0601C1CA RID: 115146 RVA: 0x00296584 File Offset: 0x00294784
		// (set) Token: 0x0601C1CB RID: 115147 RVA: 0x002965BD File Offset: 0x002947BD
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

		// Token: 0x170071B7 RID: 29111
		// (get) Token: 0x0601C1CC RID: 115148 RVA: 0x002965E0 File Offset: 0x002947E0
		// (set) Token: 0x0601C1CD RID: 115149 RVA: 0x00296619 File Offset: 0x00294819
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

		// Token: 0x170071B8 RID: 29112
		// (get) Token: 0x0601C1CE RID: 115150 RVA: 0x00296628 File Offset: 0x00294828
		// (set) Token: 0x0601C1CF RID: 115151 RVA: 0x00296661 File Offset: 0x00294861
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

		// Token: 0x170071B9 RID: 29113
		// (get) Token: 0x0601C1D0 RID: 115152 RVA: 0x00296684 File Offset: 0x00294884
		// (set) Token: 0x0601C1D1 RID: 115153 RVA: 0x002966BD File Offset: 0x002948BD
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

		// Token: 0x170071BA RID: 29114
		// (get) Token: 0x0601C1D2 RID: 115154 RVA: 0x002966CC File Offset: 0x002948CC
		// (set) Token: 0x0601C1D3 RID: 115155 RVA: 0x00296705 File Offset: 0x00294905
		public TArray<FKuroRhythmChartEvent> ChartEvents
		{
			get
			{
				base.FastCheckIsValid();
				TArray<FKuroRhythmChartEvent> result;
				if ((result = this._ChartEvents) == null)
				{
					result = (this._ChartEvents = new TArray<FKuroRhythmChartEvent>(base.NativePtr + (IntPtr)UKuroRhythmGameManager.__PropertyOffset_ChartEvents, this));
				}
				return result;
			}
			set
			{
				this.ChartEvents.CopyAssign(value);
			}
		}

		// Token: 0x170071BB RID: 29115
		// (get) Token: 0x0601C1D4 RID: 115156 RVA: 0x00296713 File Offset: 0x00294913
		// (set) Token: 0x0601C1D5 RID: 115157 RVA: 0x00296723 File Offset: 0x00294923
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

		// Token: 0x170071BC RID: 29116
		// (get) Token: 0x0601C1D6 RID: 115158 RVA: 0x00296734 File Offset: 0x00294934
		// (set) Token: 0x0601C1D7 RID: 115159 RVA: 0x00296744 File Offset: 0x00294944
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

		// Token: 0x170071BD RID: 29117
		// (get) Token: 0x0601C1D8 RID: 115160 RVA: 0x00296755 File Offset: 0x00294955
		// (set) Token: 0x0601C1D9 RID: 115161 RVA: 0x00296765 File Offset: 0x00294965
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

		// Token: 0x170071BE RID: 29118
		// (get) Token: 0x0601C1DA RID: 115162 RVA: 0x00296776 File Offset: 0x00294976
		// (set) Token: 0x0601C1DB RID: 115163 RVA: 0x00296786 File Offset: 0x00294986
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

		// Token: 0x170071BF RID: 29119
		// (get) Token: 0x0601C1DC RID: 115164 RVA: 0x00296797 File Offset: 0x00294997
		// (set) Token: 0x0601C1DD RID: 115165 RVA: 0x002967A7 File Offset: 0x002949A7
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

		// Token: 0x170071C0 RID: 29120
		// (get) Token: 0x0601C1DE RID: 115166 RVA: 0x002967B8 File Offset: 0x002949B8
		// (set) Token: 0x0601C1DF RID: 115167 RVA: 0x002967C8 File Offset: 0x002949C8
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

		// Token: 0x170071C1 RID: 29121
		// (get) Token: 0x0601C1E0 RID: 115168 RVA: 0x002967D9 File Offset: 0x002949D9
		// (set) Token: 0x0601C1E1 RID: 115169 RVA: 0x002967E9 File Offset: 0x002949E9
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

		// Token: 0x170071C2 RID: 29122
		// (get) Token: 0x0601C1E2 RID: 115170 RVA: 0x002967FA File Offset: 0x002949FA
		// (set) Token: 0x0601C1E3 RID: 115171 RVA: 0x0029680A File Offset: 0x00294A0A
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

		// Token: 0x170071C3 RID: 29123
		// (get) Token: 0x0601C1E4 RID: 115172 RVA: 0x0029681C File Offset: 0x00294A1C
		// (set) Token: 0x0601C1E5 RID: 115173 RVA: 0x00296855 File Offset: 0x00294A55
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

		// Token: 0x170071C4 RID: 29124
		// (get) Token: 0x0601C1E6 RID: 115174 RVA: 0x00296876 File Offset: 0x00294A76
		// (set) Token: 0x0601C1E7 RID: 115175 RVA: 0x00296886 File Offset: 0x00294A86
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

		// Token: 0x170071C5 RID: 29125
		// (get) Token: 0x0601C1E8 RID: 115176 RVA: 0x00296897 File Offset: 0x00294A97
		// (set) Token: 0x0601C1E9 RID: 115177 RVA: 0x002968A7 File Offset: 0x00294AA7
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

		// Token: 0x170071C6 RID: 29126
		// (get) Token: 0x0601C1EA RID: 115178 RVA: 0x002968B8 File Offset: 0x00294AB8
		// (set) Token: 0x0601C1EB RID: 115179 RVA: 0x002968C8 File Offset: 0x00294AC8
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

		// Token: 0x170071C7 RID: 29127
		// (get) Token: 0x0601C1EC RID: 115180 RVA: 0x002968D9 File Offset: 0x00294AD9
		// (set) Token: 0x0601C1ED RID: 115181 RVA: 0x002968E9 File Offset: 0x00294AE9
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

		// Token: 0x170071C8 RID: 29128
		// (get) Token: 0x0601C1EE RID: 115182 RVA: 0x002968FA File Offset: 0x00294AFA
		// (set) Token: 0x0601C1EF RID: 115183 RVA: 0x0029690A File Offset: 0x00294B0A
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

		// Token: 0x170071C9 RID: 29129
		// (get) Token: 0x0601C1F0 RID: 115184 RVA: 0x0029691B File Offset: 0x00294B1B
		// (set) Token: 0x0601C1F1 RID: 115185 RVA: 0x0029692B File Offset: 0x00294B2B
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

		// Token: 0x170071CA RID: 29130
		// (get) Token: 0x0601C1F2 RID: 115186 RVA: 0x0029693C File Offset: 0x00294B3C
		// (set) Token: 0x0601C1F3 RID: 115187 RVA: 0x0029694C File Offset: 0x00294B4C
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

		// Token: 0x170071CB RID: 29131
		// (get) Token: 0x0601C1F4 RID: 115188 RVA: 0x0029695D File Offset: 0x00294B5D
		// (set) Token: 0x0601C1F5 RID: 115189 RVA: 0x0029696D File Offset: 0x00294B6D
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

		// Token: 0x170071CC RID: 29132
		// (get) Token: 0x0601C1F6 RID: 115190 RVA: 0x00296980 File Offset: 0x00294B80
		// (set) Token: 0x0601C1F7 RID: 115191 RVA: 0x002969B9 File Offset: 0x00294BB9
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

		// Token: 0x0601C1F8 RID: 115192 RVA: 0x002969C8 File Offset: 0x00294BC8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void Tick(float DeltaTime)
		{
			UKuroRhythmGameManager.__Tick_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__Tick_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameManager.__Tick_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__Tick_NativeFunctionPtr, (void*)ptr, 1);
			ptr->DeltaTime = DeltaTime;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__Tick_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C1F9 RID: 115193 RVA: 0x00296A10 File Offset: 0x00294C10
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SwitchTrackInfinity(bool bGoLeft)
		{
			UKuroRhythmGameManager.__SwitchTrackInfinity_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__SwitchTrackInfinity_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroRhythmGameManager.__SwitchTrackInfinity_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__SwitchTrackInfinity_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bGoLeft = bGoLeft;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__SwitchTrackInfinity_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C1FA RID: 115194 RVA: 0x00296A58 File Offset: 0x00294C58
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool SwitchTrack(bool bGoLeft)
		{
			UKuroRhythmGameManager.__SwitchTrack_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__SwitchTrack_FunctionParams[(UIntPtr)17] + 15L / (long)sizeof(UKuroRhythmGameManager.__SwitchTrack_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__SwitchTrack_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bGoLeft = bGoLeft;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__SwitchTrack_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C1FB RID: 115195 RVA: 0x00296AA8 File Offset: 0x00294CA8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void StopGame(bool bSuccess)
		{
			UKuroRhythmGameManager.__StopGame_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__StopGame_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroRhythmGameManager.__StopGame_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__StopGame_NativeFunctionPtr, (void*)ptr, 1);
			ptr->bSuccess = bSuccess;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__StopGame_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C1FC RID: 115196 RVA: 0x00296AEF File Offset: 0x00294CEF
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void StartGame()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__StartGame_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C1FD RID: 115197 RVA: 0x00296B04 File Offset: 0x00294D04
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SetShipMovementSpeed(float InSpeed)
		{
			UKuroRhythmGameManager.__SetShipMovementSpeed_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__SetShipMovementSpeed_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameManager.__SetShipMovementSpeed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__SetShipMovementSpeed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InSpeed = InSpeed;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__SetShipMovementSpeed_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C1FE RID: 115198 RVA: 0x00296B4C File Offset: 0x00294D4C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void SendChartDataToNiagara(in FKuroRhythmChartData InChartData)
		{
			UKuroRhythmGameManager.__SendChartDataToNiagara_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__SendChartDataToNiagara_FunctionParams[(UIntPtr)87] + 15L / (long)sizeof(UKuroRhythmGameManager.__SendChartDataToNiagara_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__SendChartDataToNiagara_NativeFunctionPtr, (void*)ptr, 1);
			if (InChartData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmChartData.StaticStruct(), &ptr->InChartData, InChartData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__SendChartDataToNiagara_NativeFunctionPtr, (void*)ptr, 0);
			UnrealReflectionUtils.DestroyStruct(UKuroRhythmGameManager.__SendChartDataToNiagara_NativeFunctionPtr, (void*)ptr, 1);
		}

		// Token: 0x0601C1FF RID: 115199 RVA: 0x00296BC1 File Offset: 0x00294DC1
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void ResumeGame()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__ResumeGame_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C200 RID: 115200 RVA: 0x00296BD6 File Offset: 0x00294DD6
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void RestartGame()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__RestartGame_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C201 RID: 115201 RVA: 0x00296BEB File Offset: 0x00294DEB
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void PauseGame()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__PauseGame_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C202 RID: 115202 RVA: 0x00296C00 File Offset: 0x00294E00
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool ParseChartDataFromJson(string JsonString, [Nullable(2)] ref FKuroRhythmChartData OutChartData)
		{
			UKuroRhythmGameManager.__ParseChartDataFromJson_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__ParseChartDataFromJson_FunctionParams[(UIntPtr)111] + 15L / (long)sizeof(UKuroRhythmGameManager.__ParseChartDataFromJson_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__ParseChartDataFromJson_NativeFunctionPtr, (void*)ptr, 1);
			FString.CopyFrom((void*)(&ptr->JsonString), JsonString);
			if (OutChartData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmChartData.StaticStruct(), &ptr->OutChartData, OutChartData.NativePtr, 1, false);
			}
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__ParseChartDataFromJson_NativeFunctionPtr, (void*)ptr, 0);
			if (OutChartData != null)
			{
				UnrealReflectionUtils.CopyNativeStruct(FKuroRhythmChartData.StaticStruct(), OutChartData.NativePtr, &ptr->OutChartData, 1, false);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroRhythmGameManager.__ParseChartDataFromJson_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601C203 RID: 115203 RVA: 0x00296CAC File Offset: 0x00294EAC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnPlayerInputUp(EKuroRhythmGameInputType InputType)
		{
			UKuroRhythmGameManager.__OnPlayerInputUp_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__OnPlayerInputUp_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroRhythmGameManager.__OnPlayerInputUp_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__OnPlayerInputUp_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InputType = InputType;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__OnPlayerInputUp_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C204 RID: 115204 RVA: 0x00296CF4 File Offset: 0x00294EF4
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnPlayerInputDown(EKuroRhythmGameInputType InputType)
		{
			UKuroRhythmGameManager.__OnPlayerInputDown_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__OnPlayerInputDown_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroRhythmGameManager.__OnPlayerInputDown_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__OnPlayerInputDown_NativeFunctionPtr, (void*)ptr, 1);
			ptr->InputType = InputType;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__OnPlayerInputDown_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C205 RID: 115205 RVA: 0x00296D3C File Offset: 0x00294F3C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnNoteMissed(int NoteIndex)
		{
			UKuroRhythmGameManager.__OnNoteMissed_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__OnNoteMissed_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameManager.__OnNoteMissed_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__OnNoteMissed_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NoteIndex = NoteIndex;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__OnNoteMissed_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C206 RID: 115206 RVA: 0x00296D84 File Offset: 0x00294F84
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void OnNoteHit(int NoteIndex, in FKuroRhythmGameHitResult HitResult)
		{
			UKuroRhythmGameManager.__OnNoteHit_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__OnNoteHit_FunctionParams[(UIntPtr)31] + 15L / (long)sizeof(UKuroRhythmGameManager.__OnNoteHit_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__OnNoteHit_NativeFunctionPtr, (void*)ptr, 1);
			ptr->NoteIndex = NoteIndex;
			ptr->HitResult = HitResult;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__OnNoteHit_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C207 RID: 115207 RVA: 0x00296DD8 File Offset: 0x00294FD8
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsGameRunning()
		{
			UKuroRhythmGameManager.__IsGameRunning_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__IsGameRunning_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroRhythmGameManager.__IsGameRunning_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__IsGameRunning_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__IsGameRunning_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C208 RID: 115208 RVA: 0x00296E20 File Offset: 0x00295020
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsGameInitialized()
		{
			UKuroRhythmGameManager.__IsGameInitialized_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__IsGameInitialized_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroRhythmGameManager.__IsGameInitialized_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__IsGameInitialized_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__IsGameInitialized_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C209 RID: 115209 RVA: 0x00296E68 File Offset: 0x00295068
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe bool IsFeverActive()
		{
			UKuroRhythmGameManager.__IsFeverActive_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__IsFeverActive_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroRhythmGameManager.__IsFeverActive_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__IsFeverActive_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__IsFeverActive_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C20A RID: 115210 RVA: 0x00296EB0 File Offset: 0x002950B0
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
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
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__InitializeGame_NativeFunctionPtr, (void*)ptr, 0);
			TArray<FKuroRhythmSkillEffectParam> tarray2 = InSkillEffectParams;
			if (tarray2 != null)
			{
				tarray2.MoveAssign(&ptr->InSkillEffectParams);
			}
			bool _Result = ptr->__Result;
			UnrealReflectionUtils.DestroyStruct(UKuroRhythmGameManager.__InitializeGame_NativeFunctionPtr, (void*)ptr, 1);
			return _Result;
		}

		// Token: 0x0601C20B RID: 115211 RVA: 0x00296F84 File Offset: 0x00295184
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe void HandleHoldScoreUpdated(int ScoreGained, int CurrentBeat)
		{
			UKuroRhythmGameManager.__HandleHoldScoreUpdated_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__HandleHoldScoreUpdated_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroRhythmGameManager.__HandleHoldScoreUpdated_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__HandleHoldScoreUpdated_NativeFunctionPtr, (void*)ptr, 1);
			ptr->ScoreGained = ScoreGained;
			ptr->CurrentBeat = CurrentBeat;
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__HandleHoldScoreUpdated_NativeFunctionPtr, (void*)ptr, 0);
		}

		// Token: 0x0601C20C RID: 115212 RVA: 0x00296FD2 File Offset: 0x002951D2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void HandleHoldNoteTimeout()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__HandleHoldNoteTimeout_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C20D RID: 115213 RVA: 0x00296FE7 File Offset: 0x002951E7
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void HandleHoldNoteInputReleased()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__HandleHoldNoteInputReleased_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C20E RID: 115214 RVA: 0x00296FFC File Offset: 0x002951FC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FKuroRhythmGameStatistics GetStatistics()
		{
			UKuroRhythmGameManager.__GetStatistics_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__GetStatistics_FunctionParams[(UIntPtr)59] + 15L / (long)sizeof(UKuroRhythmGameManager.__GetStatistics_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__GetStatistics_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__GetStatistics_NativeFunctionPtr, (void*)ptr, 0);
			return new FKuroRhythmGameStatistics(&ptr->__Result, true, true);
		}

		// Token: 0x0601C20F RID: 115215 RVA: 0x0029704C File Offset: 0x0029524C
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UKuroRhythmGameShipController GetShipController()
		{
			UKuroRhythmGameManager.__GetShipController_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__GetShipController_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroRhythmGameManager.__GetShipController_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__GetShipController_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__GetShipController_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroRhythmGameShipController>(ptr->__Result);
		}

		// Token: 0x0601C210 RID: 115216 RVA: 0x00297098 File Offset: 0x00295298
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FKuroRhythmGameHiddenScore GetHiddenScore()
		{
			UKuroRhythmGameManager.__GetHiddenScore_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__GetHiddenScore_FunctionParams[(UIntPtr)135] + 15L / (long)sizeof(UKuroRhythmGameManager.__GetHiddenScore_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__GetHiddenScore_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__GetHiddenScore_NativeFunctionPtr, (void*)ptr, 0);
			return new FKuroRhythmGameHiddenScore(&ptr->__Result, true, true);
		}

		// Token: 0x0601C211 RID: 115217 RVA: 0x002970EC File Offset: 0x002952EC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetGameplayTime()
		{
			UKuroRhythmGameManager.__GetGameplayTime_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__GetGameplayTime_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameManager.__GetGameplayTime_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__GetGameplayTime_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__GetGameplayTime_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C212 RID: 115218 RVA: 0x00297134 File Offset: 0x00295334
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe float GetGameplayDuration()
		{
			UKuroRhythmGameManager.__GetGameplayDuration_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__GetGameplayDuration_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameManager.__GetGameplayDuration_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__GetGameplayDuration_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__GetGameplayDuration_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C213 RID: 115219 RVA: 0x0029717C File Offset: 0x0029537C
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe FKuroRhythmGameConfig GetGameConfig()
		{
			UKuroRhythmGameManager.__GetGameConfig_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__GetGameConfig_FunctionParams[(UIntPtr)287] + 15L / (long)sizeof(UKuroRhythmGameManager.__GetGameConfig_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__GetGameConfig_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__GetGameConfig_NativeFunctionPtr, (void*)ptr, 0);
			return new FKuroRhythmGameConfig(&ptr->__Result, true, true);
		}

		// Token: 0x0601C214 RID: 115220 RVA: 0x002971D0 File Offset: 0x002953D0
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetFeverScore()
		{
			UKuroRhythmGameManager.__GetFeverScore_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__GetFeverScore_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameManager.__GetFeverScore_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__GetFeverScore_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__GetFeverScore_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C215 RID: 115221 RVA: 0x00297218 File Offset: 0x00295418
		[NullableContext(2)]
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe UKuroRhythmGameEffectManager GetEffectManager()
		{
			UKuroRhythmGameManager.__GetEffectManager_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__GetEffectManager_FunctionParams[(UIntPtr)23] + 15L / (long)sizeof(UKuroRhythmGameManager.__GetEffectManager_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__GetEffectManager_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__GetEffectManager_NativeFunctionPtr, (void*)ptr, 0);
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UKuroRhythmGameEffectManager>(ptr->__Result);
		}

		// Token: 0x0601C216 RID: 115222 RVA: 0x00297264 File Offset: 0x00295464
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe int GetCurrentTrackIndex()
		{
			UKuroRhythmGameManager.__GetCurrentTrackIndex_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__GetCurrentTrackIndex_FunctionParams[(UIntPtr)19] + 15L / (long)sizeof(UKuroRhythmGameManager.__GetCurrentTrackIndex_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__GetCurrentTrackIndex_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__GetCurrentTrackIndex_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C217 RID: 115223 RVA: 0x002972AC File Offset: 0x002954AC
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public unsafe EKuroRhythmGamePhase GetCurrentPhase()
		{
			UKuroRhythmGameManager.__GetCurrentPhase_FunctionParams* ptr = stackalloc UKuroRhythmGameManager.__GetCurrentPhase_FunctionParams[(UIntPtr)16] + 15L / (long)sizeof(UKuroRhythmGameManager.__GetCurrentPhase_FunctionParams) & -16L;
			UnrealReflectionUtils.InitializeStruct(UKuroRhythmGameManager.__GetCurrentPhase_NativeFunctionPtr, (void*)ptr, 1);
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__GetCurrentPhase_NativeFunctionPtr, (void*)ptr, 0);
			return ptr->__Result;
		}

		// Token: 0x0601C218 RID: 115224 RVA: 0x002972F2 File Offset: 0x002954F2
		[SkipLocalsInit]
		[MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
		public void Cleanup()
		{
			UnrealReflectionUtils.CallUFunction(base.NativePtr, UKuroRhythmGameManager.__Cleanup_NativeFunctionPtr, null, 0);
		}

		// Token: 0x0601C219 RID: 115225 RVA: 0x00297307 File Offset: 0x00295507
		static UKuroRhythmGameManager()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroRhythmGame.KuroRhythmGameManager");
		}

		// Token: 0x0601C21A RID: 115226 RVA: 0x00297315 File Offset: 0x00295515
		protected UKuroRhythmGameManager(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400F1D6 RID: 61910
		public new const string __ObjectPath = "/Script/KuroRhythmGame.KuroRhythmGameManager";

		// Token: 0x0400F1D7 RID: 61911
		private static IntPtr _ClassPtr;

		// Token: 0x0400F1D8 RID: 61912
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400F1D9 RID: 61913
		internal static int __PropertyOffset_OnNoteResult;

		// Token: 0x0400F1DA RID: 61914
		[Nullable(2)]
		private FOnNoteResult _OnNoteResult;

		// Token: 0x0400F1DB RID: 61915
		internal static int __PropertyOffset_OnAllNotesFinished;

		// Token: 0x0400F1DC RID: 61916
		[Nullable(2)]
		private FOnAllNotesFinished _OnAllNotesFinished;

		// Token: 0x0400F1DD RID: 61917
		internal static int __PropertyOffset_OnFeverStateChanged;

		// Token: 0x0400F1DE RID: 61918
		[Nullable(2)]
		private FOnFeverStateChanged _OnFeverStateChanged;

		// Token: 0x0400F1DF RID: 61919
		internal static int __PropertyOffset_OnHiddenScoreLevelChanged;

		// Token: 0x0400F1E0 RID: 61920
		[Nullable(2)]
		private FOnHiddenScoreLevelChanged _OnHiddenScoreLevelChanged;

		// Token: 0x0400F1E1 RID: 61921
		internal static int __PropertyOffset_OnFeverScoreChanged;

		// Token: 0x0400F1E2 RID: 61922
		[Nullable(2)]
		private FOnFeverScoreChanged _OnFeverScoreChanged;

		// Token: 0x0400F1E3 RID: 61923
		internal static int __PropertyOffset_OnJumpEvent;

		// Token: 0x0400F1E4 RID: 61924
		[Nullable(2)]
		private FOnJumpEvent _OnJumpEvent;

		// Token: 0x0400F1E5 RID: 61925
		internal static int __PropertyOffset_OnTrackSwitched;

		// Token: 0x0400F1E6 RID: 61926
		[Nullable(2)]
		private FOnTrackSwitched _OnTrackSwitched;

		// Token: 0x0400F1E7 RID: 61927
		internal static int __PropertyOffset_OnHoldScoreUpdated;

		// Token: 0x0400F1E8 RID: 61928
		[Nullable(2)]
		private FOnHoldScoreUpdated _OnHoldScoreUpdated;

		// Token: 0x0400F1E9 RID: 61929
		internal static int __PropertyOffset_OnGameEvent;

		// Token: 0x0400F1EA RID: 61930
		[Nullable(2)]
		private FOnGameEvent _OnGameEvent;

		// Token: 0x0400F1EB RID: 61931
		internal static int __PropertyOffset_ShipActor;

		// Token: 0x0400F1EC RID: 61932
		internal static int __PropertyOffset_Spline;

		// Token: 0x0400F1ED RID: 61933
		internal static int __PropertyOffset_JudgementSystem;

		// Token: 0x0400F1EE RID: 61934
		internal static int __PropertyOffset_ShipController;

		// Token: 0x0400F1EF RID: 61935
		internal static int __PropertyOffset_EffectManager;

		// Token: 0x0400F1F0 RID: 61936
		internal static int __PropertyOffset_SkillEffectManager;

		// Token: 0x0400F1F1 RID: 61937
		internal static int __PropertyOffset_GameConfig;

		// Token: 0x0400F1F2 RID: 61938
		[Nullable(2)]
		private FKuroRhythmGameConfig _GameConfig;

		// Token: 0x0400F1F3 RID: 61939
		internal static int __PropertyOffset_SkillEffectParams;

		// Token: 0x0400F1F4 RID: 61940
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroRhythmSkillEffectParam> _SkillEffectParams;

		// Token: 0x0400F1F5 RID: 61941
		internal static int __PropertyOffset_Statistics;

		// Token: 0x0400F1F6 RID: 61942
		[Nullable(2)]
		private FKuroRhythmGameStatistics _Statistics;

		// Token: 0x0400F1F7 RID: 61943
		internal static int __PropertyOffset_ChartNotes;

		// Token: 0x0400F1F8 RID: 61944
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroRhythmGameNote> _ChartNotes;

		// Token: 0x0400F1F9 RID: 61945
		internal static int __PropertyOffset_ChartEvents;

		// Token: 0x0400F1FA RID: 61946
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TArray<FKuroRhythmChartEvent> _ChartEvents;

		// Token: 0x0400F1FB RID: 61947
		internal static int __PropertyOffset_CurrentPhase;

		// Token: 0x0400F1FC RID: 61948
		internal static int __PropertyOffset_bInitialized;

		// Token: 0x0400F1FD RID: 61949
		internal static int __PropertyOffset_GameStartTime;

		// Token: 0x0400F1FE RID: 61950
		internal static int __PropertyOffset_PausedTime;

		// Token: 0x0400F1FF RID: 61951
		internal static int __PropertyOffset_GameplayDuration;

		// Token: 0x0400F200 RID: 61952
		internal static int __PropertyOffset_NoteEventTimeOffset;

		// Token: 0x0400F201 RID: 61953
		internal static int __PropertyOffset_GameplayTimeOffset;

		// Token: 0x0400F202 RID: 61954
		internal static int __PropertyOffset_CurrentFeverScore;

		// Token: 0x0400F203 RID: 61955
		internal static int __PropertyOffset_CurrentHiddenScore;

		// Token: 0x0400F204 RID: 61956
		[Nullable(2)]
		private FKuroRhythmGameHiddenScore _CurrentHiddenScore;

		// Token: 0x0400F205 RID: 61957
		internal static int __PropertyOffset_bFeverActive;

		// Token: 0x0400F206 RID: 61958
		internal static int __PropertyOffset_bIgnoreFeverAutoJudge;

		// Token: 0x0400F207 RID: 61959
		internal static int __PropertyOffset_FeverScoreGlobalMultiple;

		// Token: 0x0400F208 RID: 61960
		internal static int __PropertyOffset_FeverConsumptionTime;

		// Token: 0x0400F209 RID: 61961
		internal static int __PropertyOffset_bLineKeyPressed;

		// Token: 0x0400F20A RID: 61962
		internal static int __PropertyOffset_CurrentTrackIndex;

		// Token: 0x0400F20B RID: 61963
		internal static int __PropertyOffset_CurrentRoadState;

		// Token: 0x0400F20C RID: 61964
		internal static int __PropertyOffset_CurrentBPM;

		// Token: 0x0400F20D RID: 61965
		internal static int __PropertyOffset_CachedInputEvents;

		// Token: 0x0400F20E RID: 61966
		[Nullable(new byte[]
		{
			2,
			1
		})]
		private TMap<EKuroRhythmGameInputType, FCachedInputState> _CachedInputEvents;

		// Token: 0x0400F20F RID: 61967
		private static IntPtr __Tick_NativeFunctionPtr;

		// Token: 0x0400F210 RID: 61968
		private static IntPtr __SwitchTrackInfinity_NativeFunctionPtr;

		// Token: 0x0400F211 RID: 61969
		private static IntPtr __SwitchTrack_NativeFunctionPtr;

		// Token: 0x0400F212 RID: 61970
		private static IntPtr __StopGame_NativeFunctionPtr;

		// Token: 0x0400F213 RID: 61971
		private static IntPtr __StartGame_NativeFunctionPtr;

		// Token: 0x0400F214 RID: 61972
		private static IntPtr __SetShipMovementSpeed_NativeFunctionPtr;

		// Token: 0x0400F215 RID: 61973
		private static IntPtr __SendChartDataToNiagara_NativeFunctionPtr;

		// Token: 0x0400F216 RID: 61974
		private static IntPtr __ResumeGame_NativeFunctionPtr;

		// Token: 0x0400F217 RID: 61975
		private static IntPtr __RestartGame_NativeFunctionPtr;

		// Token: 0x0400F218 RID: 61976
		private static IntPtr __PauseGame_NativeFunctionPtr;

		// Token: 0x0400F219 RID: 61977
		private static IntPtr __ParseChartDataFromJson_NativeFunctionPtr;

		// Token: 0x0400F21A RID: 61978
		private static IntPtr __OnPlayerInputUp_NativeFunctionPtr;

		// Token: 0x0400F21B RID: 61979
		private static IntPtr __OnPlayerInputDown_NativeFunctionPtr;

		// Token: 0x0400F21C RID: 61980
		private static IntPtr __OnNoteMissed_NativeFunctionPtr;

		// Token: 0x0400F21D RID: 61981
		private static IntPtr __OnNoteHit_NativeFunctionPtr;

		// Token: 0x0400F21E RID: 61982
		private static IntPtr __IsGameRunning_NativeFunctionPtr;

		// Token: 0x0400F21F RID: 61983
		private static IntPtr __IsGameInitialized_NativeFunctionPtr;

		// Token: 0x0400F220 RID: 61984
		private static IntPtr __IsFeverActive_NativeFunctionPtr;

		// Token: 0x0400F221 RID: 61985
		private static IntPtr __InitializeGame_NativeFunctionPtr;

		// Token: 0x0400F222 RID: 61986
		private static IntPtr __HandleHoldScoreUpdated_NativeFunctionPtr;

		// Token: 0x0400F223 RID: 61987
		private static IntPtr __HandleHoldNoteTimeout_NativeFunctionPtr;

		// Token: 0x0400F224 RID: 61988
		private static IntPtr __HandleHoldNoteInputReleased_NativeFunctionPtr;

		// Token: 0x0400F225 RID: 61989
		private static IntPtr __GetStatistics_NativeFunctionPtr;

		// Token: 0x0400F226 RID: 61990
		private static IntPtr __GetShipController_NativeFunctionPtr;

		// Token: 0x0400F227 RID: 61991
		private static IntPtr __GetHiddenScore_NativeFunctionPtr;

		// Token: 0x0400F228 RID: 61992
		private static IntPtr __GetGameplayTime_NativeFunctionPtr;

		// Token: 0x0400F229 RID: 61993
		private static IntPtr __GetGameplayDuration_NativeFunctionPtr;

		// Token: 0x0400F22A RID: 61994
		private static IntPtr __GetGameConfig_NativeFunctionPtr;

		// Token: 0x0400F22B RID: 61995
		private static IntPtr __GetFeverScore_NativeFunctionPtr;

		// Token: 0x0400F22C RID: 61996
		private static IntPtr __GetEffectManager_NativeFunctionPtr;

		// Token: 0x0400F22D RID: 61997
		private static IntPtr __GetCurrentTrackIndex_NativeFunctionPtr;

		// Token: 0x0400F22E RID: 61998
		private static IntPtr __GetCurrentPhase_NativeFunctionPtr;

		// Token: 0x0400F22F RID: 61999
		private static IntPtr __Cleanup_NativeFunctionPtr;

		// Token: 0x020031C3 RID: 12739
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __Tick_FunctionParams
		{
			// Token: 0x0401700D RID: 94221
			[FieldOffset(0)]
			public float DeltaTime;
		}

		// Token: 0x020031C4 RID: 12740
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __SwitchTrackInfinity_FunctionParams
		{
			// Token: 0x0401700E RID: 94222
			[FieldOffset(0)]
			public bool bGoLeft;
		}

		// Token: 0x020031C5 RID: 12741
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 2)]
		protected ref struct __SwitchTrack_FunctionParams
		{
			// Token: 0x0401700F RID: 94223
			[FieldOffset(0)]
			public bool bGoLeft;

			// Token: 0x04017010 RID: 94224
			[FieldOffset(1)]
			public bool __Result;
		}

		// Token: 0x020031C6 RID: 12742
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __StopGame_FunctionParams
		{
			// Token: 0x04017011 RID: 94225
			[FieldOffset(0)]
			public bool bSuccess;
		}

		// Token: 0x020031C7 RID: 12743
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __SetShipMovementSpeed_FunctionParams
		{
			// Token: 0x04017012 RID: 94226
			[FieldOffset(0)]
			public float InSpeed;
		}

		// Token: 0x020031C8 RID: 12744
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 72)]
		protected ref struct __SendChartDataToNiagara_FunctionParams
		{
			// Token: 0x04017013 RID: 94227
			[FieldOffset(0)]
			public byte InChartData;
		}

		// Token: 0x020031C9 RID: 12745
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 96)]
		protected ref struct __ParseChartDataFromJson_FunctionParams
		{
			// Token: 0x04017014 RID: 94228
			[FieldOffset(0)]
			public FString JsonString;

			// Token: 0x04017015 RID: 94229
			[FieldOffset(16)]
			public byte OutChartData;

			// Token: 0x04017016 RID: 94230
			[FieldOffset(88)]
			public bool __Result;
		}

		// Token: 0x020031CA RID: 12746
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnPlayerInputUp_FunctionParams
		{
			// Token: 0x04017017 RID: 94231
			[FieldOffset(0)]
			public EKuroRhythmGameInputType InputType;
		}

		// Token: 0x020031CB RID: 12747
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __OnPlayerInputDown_FunctionParams
		{
			// Token: 0x04017018 RID: 94232
			[FieldOffset(0)]
			public EKuroRhythmGameInputType InputType;
		}

		// Token: 0x020031CC RID: 12748
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __OnNoteMissed_FunctionParams
		{
			// Token: 0x04017019 RID: 94233
			[FieldOffset(0)]
			public int NoteIndex;
		}

		// Token: 0x020031CD RID: 12749
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 16)]
		protected ref struct __OnNoteHit_FunctionParams
		{
			// Token: 0x0401701A RID: 94234
			[FieldOffset(0)]
			public int NoteIndex;

			// Token: 0x0401701B RID: 94235
			[FieldOffset(4)]
			public FKuroRhythmGameHitResult HitResult;
		}

		// Token: 0x020031CE RID: 12750
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsGameRunning_FunctionParams
		{
			// Token: 0x0401701C RID: 94236
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020031CF RID: 12751
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsGameInitialized_FunctionParams
		{
			// Token: 0x0401701D RID: 94237
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020031D0 RID: 12752
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __IsFeverActive_FunctionParams
		{
			// Token: 0x0401701E RID: 94238
			[FieldOffset(0)]
			public bool __Result;
		}

		// Token: 0x020031D1 RID: 12753
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 312)]
		protected ref struct __InitializeGame_FunctionParams
		{
			// Token: 0x0401701F RID: 94239
			[FieldOffset(0)]
			public byte InConfig;

			// Token: 0x04017020 RID: 94240
			[FieldOffset(272)]
			public byte InSkillEffectParams;

			// Token: 0x04017021 RID: 94241
			[FieldOffset(288)]
			public IntPtr InShipActor;

			// Token: 0x04017022 RID: 94242
			[FieldOffset(296)]
			public IntPtr InSpline;

			// Token: 0x04017023 RID: 94243
			[FieldOffset(304)]
			public bool __Result;
		}

		// Token: 0x020031D2 RID: 12754
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __HandleHoldScoreUpdated_FunctionParams
		{
			// Token: 0x04017024 RID: 94244
			[FieldOffset(0)]
			public int ScoreGained;

			// Token: 0x04017025 RID: 94245
			[FieldOffset(4)]
			public int CurrentBeat;
		}

		// Token: 0x020031D3 RID: 12755
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 44)]
		protected ref struct __GetStatistics_FunctionParams
		{
			// Token: 0x04017026 RID: 94246
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020031D4 RID: 12756
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetShipController_FunctionParams
		{
			// Token: 0x04017027 RID: 94247
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x020031D5 RID: 12757
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 120)]
		protected ref struct __GetHiddenScore_FunctionParams
		{
			// Token: 0x04017028 RID: 94248
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020031D6 RID: 12758
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetGameplayTime_FunctionParams
		{
			// Token: 0x04017029 RID: 94249
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x020031D7 RID: 12759
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetGameplayDuration_FunctionParams
		{
			// Token: 0x0401702A RID: 94250
			[FieldOffset(0)]
			public float __Result;
		}

		// Token: 0x020031D8 RID: 12760
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 272)]
		protected ref struct __GetGameConfig_FunctionParams
		{
			// Token: 0x0401702B RID: 94251
			[FieldOffset(0)]
			public byte __Result;
		}

		// Token: 0x020031D9 RID: 12761
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetFeverScore_FunctionParams
		{
			// Token: 0x0401702C RID: 94252
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020031DA RID: 12762
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 8)]
		protected ref struct __GetEffectManager_FunctionParams
		{
			// Token: 0x0401702D RID: 94253
			[FieldOffset(0)]
			public IntPtr __Result;
		}

		// Token: 0x020031DB RID: 12763
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 4)]
		protected ref struct __GetCurrentTrackIndex_FunctionParams
		{
			// Token: 0x0401702E RID: 94254
			[FieldOffset(0)]
			public int __Result;
		}

		// Token: 0x020031DC RID: 12764
		[NullableContext(0)]
		[CompilerFeatureRequired("RefStructs")]
		[StructLayout(LayoutKind.Explicit, Size = 1)]
		protected ref struct __GetCurrentPhase_FunctionParams
		{
			// Token: 0x0401702F RID: 94255
			[FieldOffset(0)]
			public EKuroRhythmGamePhase __Result;
		}
	}
}
