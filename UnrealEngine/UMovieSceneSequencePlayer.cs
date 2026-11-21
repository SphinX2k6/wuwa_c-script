using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200078C RID: 1932
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSequencePlayer")]
	[UnrealStructLayout(1816, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1816)]
	public abstract class UMovieSceneSequencePlayer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A6A9 RID: 42665 RVA: 0x000F63BB File Offset: 0x000F45BB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSequencePlayer._ClassPtr;
		}

		// Token: 0x17001EFF RID: 7935
		// (get) Token: 0x0600A6AA RID: 42666 RVA: 0x000F63C8 File Offset: 0x000F45C8
		// (set) Token: 0x0600A6AB RID: 42667 RVA: 0x000F6401 File Offset: 0x000F4601
		public FOnMovieSceneSequencePlayerEvent OnPlay
		{
			get
			{
				base.FastCheckIsValid();
				FOnMovieSceneSequencePlayerEvent result;
				if ((result = this._OnPlay) == null)
				{
					result = (this._OnPlay = new FOnMovieSceneSequencePlayerEvent(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_OnPlay, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_OnPlay, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001F00 RID: 7936
		// (get) Token: 0x0600A6AC RID: 42668 RVA: 0x000F6424 File Offset: 0x000F4624
		// (set) Token: 0x0600A6AD RID: 42669 RVA: 0x000F645D File Offset: 0x000F465D
		public FOnMovieSceneSequencePlayerEvent OnPlayReverse
		{
			get
			{
				base.FastCheckIsValid();
				FOnMovieSceneSequencePlayerEvent result;
				if ((result = this._OnPlayReverse) == null)
				{
					result = (this._OnPlayReverse = new FOnMovieSceneSequencePlayerEvent(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_OnPlayReverse, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_OnPlayReverse, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001F01 RID: 7937
		// (get) Token: 0x0600A6AE RID: 42670 RVA: 0x000F6480 File Offset: 0x000F4680
		// (set) Token: 0x0600A6AF RID: 42671 RVA: 0x000F64B9 File Offset: 0x000F46B9
		public FOnMovieSceneSequencePlayerEvent OnStop
		{
			get
			{
				base.FastCheckIsValid();
				FOnMovieSceneSequencePlayerEvent result;
				if ((result = this._OnStop) == null)
				{
					result = (this._OnStop = new FOnMovieSceneSequencePlayerEvent(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_OnStop, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_OnStop, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001F02 RID: 7938
		// (get) Token: 0x0600A6B0 RID: 42672 RVA: 0x000F64DC File Offset: 0x000F46DC
		// (set) Token: 0x0600A6B1 RID: 42673 RVA: 0x000F6515 File Offset: 0x000F4715
		public FOnMovieSceneSequencePlayerEvent OnPause
		{
			get
			{
				base.FastCheckIsValid();
				FOnMovieSceneSequencePlayerEvent result;
				if ((result = this._OnPause) == null)
				{
					result = (this._OnPause = new FOnMovieSceneSequencePlayerEvent(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_OnPause, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_OnPause, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001F03 RID: 7939
		// (get) Token: 0x0600A6B2 RID: 42674 RVA: 0x000F6538 File Offset: 0x000F4738
		// (set) Token: 0x0600A6B3 RID: 42675 RVA: 0x000F6571 File Offset: 0x000F4771
		public FOnMovieSceneSequencePlayerEvent OnInterrupt
		{
			get
			{
				base.FastCheckIsValid();
				FOnMovieSceneSequencePlayerEvent result;
				if ((result = this._OnInterrupt) == null)
				{
					result = (this._OnInterrupt = new FOnMovieSceneSequencePlayerEvent(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_OnInterrupt, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_OnInterrupt, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001F04 RID: 7940
		// (get) Token: 0x0600A6B4 RID: 42676 RVA: 0x000F6594 File Offset: 0x000F4794
		// (set) Token: 0x0600A6B5 RID: 42677 RVA: 0x000F65CD File Offset: 0x000F47CD
		public FOnMovieSceneSequencePlayerEvent OnFinished
		{
			get
			{
				base.FastCheckIsValid();
				FOnMovieSceneSequencePlayerEvent result;
				if ((result = this._OnFinished) == null)
				{
					result = (this._OnFinished = new FOnMovieSceneSequencePlayerEvent(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_OnFinished, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_OnFinished, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001F05 RID: 7941
		// (get) Token: 0x0600A6B6 RID: 42678 RVA: 0x000F65EE File Offset: 0x000F47EE
		// (set) Token: 0x0600A6B7 RID: 42679 RVA: 0x000F6607 File Offset: 0x000F4807
		public unsafe bool bReversePlayback
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_bReversePlayback) & UMovieSceneSequencePlayer.__PropertyMask_bReversePlayback) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_bReversePlayback) = ((*(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_bReversePlayback) & ~UMovieSceneSequencePlayer.__PropertyMask_bReversePlayback) | (value ? UMovieSceneSequencePlayer.__PropertyMask_bReversePlayback : 0));
			}
		}

		// Token: 0x17001F06 RID: 7942
		// (get) Token: 0x0600A6B8 RID: 42680 RVA: 0x000F6638 File Offset: 0x000F4838
		// (set) Token: 0x0600A6B9 RID: 42681 RVA: 0x000F6671 File Offset: 0x000F4871
		public TArray<int> KeyFrames
		{
			get
			{
				base.FastCheckIsValid();
				TArray<int> result;
				if ((result = this._KeyFrames) == null)
				{
					result = (this._KeyFrames = new TArray<int>(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_KeyFrames, this));
				}
				return result;
			}
			set
			{
				this.KeyFrames.CopyAssign(value);
			}
		}

		// Token: 0x17001F07 RID: 7943
		// (get) Token: 0x0600A6BA RID: 42682 RVA: 0x000F667F File Offset: 0x000F487F
		// (set) Token: 0x0600A6BB RID: 42683 RVA: 0x000F6693 File Offset: 0x000F4893
		[Nullable(2)]
		public unsafe UMovieSceneSequence Sequence
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneSequence>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneSequencePlayer.__PropertyOffset_Sequence);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneSequencePlayer.__PropertyOffset_Sequence, value);
			}
		}

		// Token: 0x17001F08 RID: 7944
		// (get) Token: 0x0600A6BC RID: 42684 RVA: 0x000F66A8 File Offset: 0x000F48A8
		// (set) Token: 0x0600A6BD RID: 42685 RVA: 0x000F66E1 File Offset: 0x000F48E1
		public FFrameNumber StartTime
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._StartTime) == null)
				{
					result = (this._StartTime = new FFrameNumber(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_StartTime, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_StartTime, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001F09 RID: 7945
		// (get) Token: 0x0600A6BE RID: 42686 RVA: 0x000F6702 File Offset: 0x000F4902
		// (set) Token: 0x0600A6BF RID: 42687 RVA: 0x000F6712 File Offset: 0x000F4912
		public unsafe int DurationFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_DurationFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_DurationFrames) = value;
			}
		}

		// Token: 0x17001F0A RID: 7946
		// (get) Token: 0x0600A6C0 RID: 42688 RVA: 0x000F6723 File Offset: 0x000F4923
		// (set) Token: 0x0600A6C1 RID: 42689 RVA: 0x000F6733 File Offset: 0x000F4933
		public unsafe float DurationSubFrames
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_DurationSubFrames);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_DurationSubFrames) = value;
			}
		}

		// Token: 0x17001F0B RID: 7947
		// (get) Token: 0x0600A6C2 RID: 42690 RVA: 0x000F6744 File Offset: 0x000F4944
		// (set) Token: 0x0600A6C3 RID: 42691 RVA: 0x000F6754 File Offset: 0x000F4954
		public unsafe int CurrentNumLoops
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_CurrentNumLoops);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_CurrentNumLoops) = value;
			}
		}

		// Token: 0x17001F0C RID: 7948
		// (get) Token: 0x0600A6C4 RID: 42692 RVA: 0x000F6768 File Offset: 0x000F4968
		// (set) Token: 0x0600A6C5 RID: 42693 RVA: 0x000F67A1 File Offset: 0x000F49A1
		public FMovieSceneSequencePlaybackSettings PlaybackSettings
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSequencePlaybackSettings result;
				if ((result = this._PlaybackSettings) == null)
				{
					result = (this._PlaybackSettings = new FMovieSceneSequencePlaybackSettings(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_PlaybackSettings, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSequencePlaybackSettings.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_PlaybackSettings, value.NativePtr, 1, false);
			}
		}

		// Token: 0x0600A6C6 RID: 42694 RVA: 0x000F67C2 File Offset: 0x000F49C2
		public void StopAtCurrentTime()
		{
			UMovieSceneSequencePlayer.__StopAtCurrentTime_Internal(base.NativePtr);
		}

		// Token: 0x0600A6C7 RID: 42695 RVA: 0x000F67CF File Offset: 0x000F49CF
		public void Stop()
		{
			UMovieSceneSequencePlayer.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x0600A6C8 RID: 42696 RVA: 0x000F67DC File Offset: 0x000F49DC
		public void SetTimeRange(float StartTime, float Duration)
		{
			UMovieSceneSequencePlayer.__SetTimeRange_Internal(base.NativePtr, StartTime, Duration);
		}

		// Token: 0x0600A6C9 RID: 42697 RVA: 0x000F67EB File Offset: 0x000F49EB
		public void SetPlayRate(float PlayRate)
		{
			UMovieSceneSequencePlayer.__SetPlayRate_Internal(base.NativePtr, PlayRate);
		}

		// Token: 0x0600A6CA RID: 42698 RVA: 0x000F67F9 File Offset: 0x000F49F9
		[NullableContext(2)]
		public void SetPlaybackPositionWithNoEval(FMovieSceneSequencePlaybackParams PlaybackParams)
		{
			UMovieSceneSequencePlayer.__SetPlaybackPositionWithNoEval_Internal(base.NativePtr, (PlaybackParams ?? new FMovieSceneSequencePlaybackParams()).NativePtr);
		}

		// Token: 0x0600A6CB RID: 42699 RVA: 0x000F6815 File Offset: 0x000F4A15
		[NullableContext(2)]
		public void SetPlaybackPosition(FMovieSceneSequencePlaybackParams PlaybackParams)
		{
			UMovieSceneSequencePlayer.__SetPlaybackPosition_Internal(base.NativePtr, (PlaybackParams ?? new FMovieSceneSequencePlaybackParams()).NativePtr);
		}

		// Token: 0x0600A6CC RID: 42700 RVA: 0x000F6831 File Offset: 0x000F4A31
		[NullableContext(2)]
		public void SetKeyFrames(in TArray<int> InKeyFrames)
		{
			UMovieSceneSequencePlayer.__SetKeyFrames_Internal(base.NativePtr, (InKeyFrames ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x0600A6CD RID: 42701 RVA: 0x000F684E File Offset: 0x000F4A4E
		public void SetFrameRate(FFrameRate FrameRate)
		{
			UMovieSceneSequencePlayer.__SetFrameRate_Internal(base.NativePtr, FrameRate);
		}

		// Token: 0x0600A6CE RID: 42702 RVA: 0x000F685C File Offset: 0x000F4A5C
		public void SetFrameRange(int StartFrame, int Duration, float SubFrames = 0f)
		{
			UMovieSceneSequencePlayer.__SetFrameRange_Internal(base.NativePtr, StartFrame, Duration, SubFrames);
		}

		// Token: 0x0600A6CF RID: 42703 RVA: 0x000F686C File Offset: 0x000F4A6C
		public void SetDisableCameraCuts(bool bInDisableCameraCuts)
		{
			UMovieSceneSequencePlayer.__SetDisableCameraCuts_Internal(base.NativePtr, bInDisableCameraCuts);
		}

		// Token: 0x0600A6D0 RID: 42704 RVA: 0x000F687A File Offset: 0x000F4A7A
		public void ScrubToSeconds(float TimeInSeconds)
		{
			UMovieSceneSequencePlayer.__ScrubToSeconds_Internal(base.NativePtr, TimeInSeconds);
		}

		// Token: 0x0600A6D1 RID: 42705 RVA: 0x000F6888 File Offset: 0x000F4A88
		public unsafe bool ScrubToMarkedFrame(string InLabel)
		{
			FString fstring = FString.AllocTemp(InLabel);
			bool result = UMovieSceneSequencePlayer.__ScrubToMarkedFrame_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600A6D2 RID: 42706 RVA: 0x000F68B2 File Offset: 0x000F4AB2
		[NullableContext(2)]
		public void ScrubToFrame(FFrameTime NewPosition)
		{
			UMovieSceneSequencePlayer.__ScrubToFrame_Internal(base.NativePtr, (NewPosition ?? new FFrameTime()).NativePtr);
		}

		// Token: 0x0600A6D3 RID: 42707 RVA: 0x000F68CE File Offset: 0x000F4ACE
		public void Scrub()
		{
			UMovieSceneSequencePlayer.__Scrub_Internal(base.NativePtr);
		}

		// Token: 0x0600A6D4 RID: 42708 RVA: 0x000F68DB File Offset: 0x000F4ADB
		[NullableContext(2)]
		public void RPC_OnStopEvent(FFrameTime StoppedTime)
		{
			UMovieSceneSequencePlayer.__RPC_OnStopEvent_Internal(base.NativePtr, (StoppedTime ?? new FFrameTime()).NativePtr);
		}

		// Token: 0x0600A6D5 RID: 42709 RVA: 0x000F68F7 File Offset: 0x000F4AF7
		[NullableContext(2)]
		public void RPC_ExplicitServerUpdateEvent(EUpdatePositionMethod Method, FFrameTime RelevantTime)
		{
			UMovieSceneSequencePlayer.__RPC_ExplicitServerUpdateEvent_Internal(base.NativePtr, Method, (RelevantTime ?? new FFrameTime()).NativePtr);
		}

		// Token: 0x0600A6D6 RID: 42710 RVA: 0x000F6914 File Offset: 0x000F4B14
		[NullableContext(2)]
		public void PlayToWithEventSweep(FMovieSceneSequencePlaybackParams PlaybackParams)
		{
			UMovieSceneSequencePlayer.__PlayToWithEventSweep_Internal(base.NativePtr, (PlaybackParams ?? new FMovieSceneSequencePlaybackParams()).NativePtr);
		}

		// Token: 0x0600A6D7 RID: 42711 RVA: 0x000F6930 File Offset: 0x000F4B30
		public void PlayToSeconds(float TimeInSeconds)
		{
			UMovieSceneSequencePlayer.__PlayToSeconds_Internal(base.NativePtr, TimeInSeconds);
		}

		// Token: 0x0600A6D8 RID: 42712 RVA: 0x000F6940 File Offset: 0x000F4B40
		public unsafe bool PlayToMarkedFrame(string InLabel)
		{
			FString fstring = FString.AllocTemp(InLabel);
			bool result = UMovieSceneSequencePlayer.__PlayToMarkedFrame_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600A6D9 RID: 42713 RVA: 0x000F696A File Offset: 0x000F4B6A
		[NullableContext(2)]
		public void PlayToFrame(FFrameTime NewPosition)
		{
			UMovieSceneSequencePlayer.__PlayToFrame_Internal(base.NativePtr, (NewPosition ?? new FFrameTime()).NativePtr);
		}

		// Token: 0x0600A6DA RID: 42714 RVA: 0x000F6988 File Offset: 0x000F4B88
		public unsafe void PlayTo_Loop([Nullable(2)] FMovieSceneSequencePlaybackParams InPlaybackParams, string StartMarkedFrame)
		{
			FString fstring = FString.AllocTemp(StartMarkedFrame);
			UMovieSceneSequencePlayer.__PlayTo_Loop_Internal(base.NativePtr, (InPlaybackParams ?? new FMovieSceneSequencePlaybackParams()).NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x0600A6DB RID: 42715 RVA: 0x000F69C1 File Offset: 0x000F4BC1
		[NullableContext(2)]
		public void PlayTo_Circle(FMovieSceneSequencePlaybackParams InPlaybackParams, bool InAutoDirect = false, bool InIsForward = true)
		{
			UMovieSceneSequencePlayer.__PlayTo_Circle_Internal(base.NativePtr, (InPlaybackParams ?? new FMovieSceneSequencePlaybackParams()).NativePtr, InAutoDirect, InIsForward);
		}

		// Token: 0x0600A6DC RID: 42716 RVA: 0x000F69DF File Offset: 0x000F4BDF
		[NullableContext(2)]
		public void PlayTo(FMovieSceneSequencePlaybackParams PlaybackParams)
		{
			UMovieSceneSequencePlayer.__PlayTo_Internal(base.NativePtr, (PlaybackParams ?? new FMovieSceneSequencePlaybackParams()).NativePtr);
		}

		// Token: 0x0600A6DD RID: 42717 RVA: 0x000F69FB File Offset: 0x000F4BFB
		public void PlayReverseLooping(int NumLoops = -1)
		{
			UMovieSceneSequencePlayer.__PlayReverseLooping_Internal(base.NativePtr, NumLoops);
		}

		// Token: 0x0600A6DE RID: 42718 RVA: 0x000F6A09 File Offset: 0x000F4C09
		public void PlayReverse()
		{
			UMovieSceneSequencePlayer.__PlayReverse_Internal(base.NativePtr);
		}

		// Token: 0x0600A6DF RID: 42719 RVA: 0x000F6A16 File Offset: 0x000F4C16
		public void PlayLooping(int NumLoops = -1)
		{
			UMovieSceneSequencePlayer.__PlayLooping_Internal(base.NativePtr, NumLoops);
		}

		// Token: 0x0600A6E0 RID: 42720 RVA: 0x000F6A24 File Offset: 0x000F4C24
		public void Play()
		{
			UMovieSceneSequencePlayer.__Play_Internal(base.NativePtr);
		}

		// Token: 0x0600A6E1 RID: 42721 RVA: 0x000F6A31 File Offset: 0x000F4C31
		public void PauseOnNextFrame()
		{
			UMovieSceneSequencePlayer.__PauseOnNextFrame_Internal(base.NativePtr);
		}

		// Token: 0x0600A6E2 RID: 42722 RVA: 0x000F6A3E File Offset: 0x000F4C3E
		public void Pause()
		{
			UMovieSceneSequencePlayer.__Pause_Internal(base.NativePtr);
		}

		// Token: 0x0600A6E3 RID: 42723 RVA: 0x000F6A4B File Offset: 0x000F4C4B
		public void JumpToSeconds(float TimeInSeconds)
		{
			UMovieSceneSequencePlayer.__JumpToSeconds_Internal(base.NativePtr, TimeInSeconds);
		}

		// Token: 0x0600A6E4 RID: 42724 RVA: 0x000F6A5C File Offset: 0x000F4C5C
		public unsafe bool JumpToMarkedFrame(string InLabel)
		{
			FString fstring = FString.AllocTemp(InLabel);
			bool result = UMovieSceneSequencePlayer.__JumpToMarkedFrame_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600A6E5 RID: 42725 RVA: 0x000F6A86 File Offset: 0x000F4C86
		[NullableContext(2)]
		public void JumpToFrame(FFrameTime NewPosition)
		{
			UMovieSceneSequencePlayer.__JumpToFrame_Internal(base.NativePtr, (NewPosition ?? new FFrameTime()).NativePtr);
		}

		// Token: 0x0600A6E6 RID: 42726 RVA: 0x000F6AA2 File Offset: 0x000F4CA2
		public bool IsStopped()
		{
			return UMovieSceneSequencePlayer.__IsStopped_Internal(base.NativePtr);
		}

		// Token: 0x0600A6E7 RID: 42727 RVA: 0x000F6AAF File Offset: 0x000F4CAF
		public bool IsReversed()
		{
			return UMovieSceneSequencePlayer.__IsReversed_Internal(base.NativePtr);
		}

		// Token: 0x0600A6E8 RID: 42728 RVA: 0x000F6ABC File Offset: 0x000F4CBC
		public bool IsPlaying()
		{
			return UMovieSceneSequencePlayer.__IsPlaying_Internal(base.NativePtr);
		}

		// Token: 0x0600A6E9 RID: 42729 RVA: 0x000F6AC9 File Offset: 0x000F4CC9
		public bool IsPaused()
		{
			return UMovieSceneSequencePlayer.__IsPaused_Internal(base.NativePtr);
		}

		// Token: 0x0600A6EA RID: 42730 RVA: 0x000F6AD6 File Offset: 0x000F4CD6
		public void GoToEndAndStop(EUpdatePositionMethod UpdateMethod = EUpdatePositionMethod.Jump)
		{
			UMovieSceneSequencePlayer.__GoToEndAndStop_Internal(base.NativePtr, UpdateMethod);
		}

		// Token: 0x0600A6EB RID: 42731 RVA: 0x000F6AE4 File Offset: 0x000F4CE4
		public FQualifiedFrameTime GetStartTime()
		{
			return new FQualifiedFrameTime(UMovieSceneSequencePlayer.__GetStartTime_Internal(base.NativePtr), null);
		}

		// Token: 0x0600A6EC RID: 42732 RVA: 0x000F6AF7 File Offset: 0x000F4CF7
		public float GetPlayRate()
		{
			return UMovieSceneSequencePlayer.__GetPlayRate_Internal(base.NativePtr);
		}

		// Token: 0x0600A6ED RID: 42733 RVA: 0x000F6B04 File Offset: 0x000F4D04
		public TArray<FMovieSceneObjectBindingID> GetObjectBindings([Nullable(2)] UObject InObject)
		{
			return new TArray<FMovieSceneObjectBindingID>(UMovieSceneSequencePlayer.__GetObjectBindings_Internal(base.NativePtr, (InObject != null) ? InObject.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x0600A6EE RID: 42734 RVA: 0x000F6B27 File Offset: 0x000F4D27
		public FFrameRate GetFrameRate()
		{
			return UMovieSceneSequencePlayer.__GetFrameRate_Internal(base.NativePtr);
		}

		// Token: 0x0600A6EF RID: 42735 RVA: 0x000F6B34 File Offset: 0x000F4D34
		public int GetFrameDuration()
		{
			return UMovieSceneSequencePlayer.__GetFrameDuration_Internal(base.NativePtr);
		}

		// Token: 0x0600A6F0 RID: 42736 RVA: 0x000F6B41 File Offset: 0x000F4D41
		public FQualifiedFrameTime GetEndTime()
		{
			return new FQualifiedFrameTime(UMovieSceneSequencePlayer.__GetEndTime_Internal(base.NativePtr), null);
		}

		// Token: 0x0600A6F1 RID: 42737 RVA: 0x000F6B54 File Offset: 0x000F4D54
		public FQualifiedFrameTime GetDuration()
		{
			return new FQualifiedFrameTime(UMovieSceneSequencePlayer.__GetDuration_Internal(base.NativePtr), null);
		}

		// Token: 0x0600A6F2 RID: 42738 RVA: 0x000F6B67 File Offset: 0x000F4D67
		public bool GetDisableCameraCuts()
		{
			return UMovieSceneSequencePlayer.__GetDisableCameraCuts_Internal(base.NativePtr);
		}

		// Token: 0x0600A6F3 RID: 42739 RVA: 0x000F6B74 File Offset: 0x000F4D74
		public FQualifiedFrameTime GetCurrentTime()
		{
			return new FQualifiedFrameTime(UMovieSceneSequencePlayer.__GetCurrentTime_Internal(base.NativePtr), null);
		}

		// Token: 0x0600A6F4 RID: 42740 RVA: 0x000F6B87 File Offset: 0x000F4D87
		public TArray<UObject> GetBoundObjects([Nullable(2)] FMovieSceneObjectBindingID ObjectBinding)
		{
			return new TArray<UObject>(UMovieSceneSequencePlayer.__GetBoundObjects_Internal(base.NativePtr, (ObjectBinding ?? new FMovieSceneObjectBindingID()).NativePtr), null);
		}

		// Token: 0x0600A6F5 RID: 42741 RVA: 0x000F6BA9 File Offset: 0x000F4DA9
		public void ClearKeyFrames()
		{
			UMovieSceneSequencePlayer.__ClearKeyFrames_Internal(base.NativePtr);
		}

		// Token: 0x0600A6F6 RID: 42742 RVA: 0x000F6BB6 File Offset: 0x000F4DB6
		public void CleanPauseOnFrame()
		{
			UMovieSceneSequencePlayer.__CleanPauseOnFrame_Internal(base.NativePtr);
		}

		// Token: 0x0600A6F7 RID: 42743 RVA: 0x000F6BC3 File Offset: 0x000F4DC3
		public void ChangePlaybackDirection()
		{
			UMovieSceneSequencePlayer.__ChangePlaybackDirection_Internal(base.NativePtr);
		}

		// Token: 0x0600A6F8 RID: 42744
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAtCurrentTime_Internal(IntPtr @this);

		// Token: 0x0600A6F9 RID: 42745
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x0600A6FA RID: 42746
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTimeRange_Internal(IntPtr @this, float StartTime, float Duration);

		// Token: 0x0600A6FB RID: 42747
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlayRate_Internal(IntPtr @this, float PlayRate);

		// Token: 0x0600A6FC RID: 42748
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlaybackPositionWithNoEval_Internal(IntPtr @this, IntPtr PlaybackParams);

		// Token: 0x0600A6FD RID: 42749
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlaybackPosition_Internal(IntPtr @this, IntPtr PlaybackParams);

		// Token: 0x0600A6FE RID: 42750
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKeyFrames_Internal(IntPtr @this, IntPtr InKeyFrames);

		// Token: 0x0600A6FF RID: 42751
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFrameRate_Internal(IntPtr @this, FFrameRate FrameRate);

		// Token: 0x0600A700 RID: 42752
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFrameRange_Internal(IntPtr @this, int StartFrame, int Duration, float SubFrames);

		// Token: 0x0600A701 RID: 42753
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDisableCameraCuts_Internal(IntPtr @this, bool bInDisableCameraCuts);

		// Token: 0x0600A702 RID: 42754
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrubToSeconds_Internal(IntPtr @this, float TimeInSeconds);

		// Token: 0x0600A703 RID: 42755
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ScrubToMarkedFrame_Internal(IntPtr @this, in FString InLabel);

		// Token: 0x0600A704 RID: 42756
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrubToFrame_Internal(IntPtr @this, IntPtr NewPosition);

		// Token: 0x0600A705 RID: 42757
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Scrub_Internal(IntPtr @this);

		// Token: 0x0600A706 RID: 42758
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RPC_OnStopEvent_Internal(IntPtr @this, IntPtr StoppedTime);

		// Token: 0x0600A707 RID: 42759
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RPC_ExplicitServerUpdateEvent_Internal(IntPtr @this, EUpdatePositionMethod Method, IntPtr RelevantTime);

		// Token: 0x0600A708 RID: 42760
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayToWithEventSweep_Internal(IntPtr @this, IntPtr PlaybackParams);

		// Token: 0x0600A709 RID: 42761
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayToSeconds_Internal(IntPtr @this, float TimeInSeconds);

		// Token: 0x0600A70A RID: 42762
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PlayToMarkedFrame_Internal(IntPtr @this, in FString InLabel);

		// Token: 0x0600A70B RID: 42763
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayToFrame_Internal(IntPtr @this, IntPtr NewPosition);

		// Token: 0x0600A70C RID: 42764
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayTo_Loop_Internal(IntPtr @this, IntPtr InPlaybackParams, in FString StartMarkedFrame);

		// Token: 0x0600A70D RID: 42765
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayTo_Circle_Internal(IntPtr @this, IntPtr InPlaybackParams, bool InAutoDirect, bool InIsForward);

		// Token: 0x0600A70E RID: 42766
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayTo_Internal(IntPtr @this, IntPtr PlaybackParams);

		// Token: 0x0600A70F RID: 42767
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayReverseLooping_Internal(IntPtr @this, int NumLoops);

		// Token: 0x0600A710 RID: 42768
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayReverse_Internal(IntPtr @this);

		// Token: 0x0600A711 RID: 42769
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayLooping_Internal(IntPtr @this, int NumLoops);

		// Token: 0x0600A712 RID: 42770
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this);

		// Token: 0x0600A713 RID: 42771
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PauseOnNextFrame_Internal(IntPtr @this);

		// Token: 0x0600A714 RID: 42772
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Pause_Internal(IntPtr @this);

		// Token: 0x0600A715 RID: 42773
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __JumpToSeconds_Internal(IntPtr @this, float TimeInSeconds);

		// Token: 0x0600A716 RID: 42774
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __JumpToMarkedFrame_Internal(IntPtr @this, in FString InLabel);

		// Token: 0x0600A717 RID: 42775
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __JumpToFrame_Internal(IntPtr @this, IntPtr NewPosition);

		// Token: 0x0600A718 RID: 42776
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStopped_Internal(IntPtr @this);

		// Token: 0x0600A719 RID: 42777
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsReversed_Internal(IntPtr @this);

		// Token: 0x0600A71A RID: 42778
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlaying_Internal(IntPtr @this);

		// Token: 0x0600A71B RID: 42779
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPaused_Internal(IntPtr @this);

		// Token: 0x0600A71C RID: 42780
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GoToEndAndStop_Internal(IntPtr @this, EUpdatePositionMethod UpdateMethod);

		// Token: 0x0600A71D RID: 42781
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetStartTime_Internal(IntPtr @this);

		// Token: 0x0600A71E RID: 42782
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPlayRate_Internal(IntPtr @this);

		// Token: 0x0600A71F RID: 42783
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetObjectBindings_Internal(IntPtr @this, IntPtr InObject);

		// Token: 0x0600A720 RID: 42784
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FFrameRate __GetFrameRate_Internal(IntPtr @this);

		// Token: 0x0600A721 RID: 42785
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetFrameDuration_Internal(IntPtr @this);

		// Token: 0x0600A722 RID: 42786
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEndTime_Internal(IntPtr @this);

		// Token: 0x0600A723 RID: 42787
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDuration_Internal(IntPtr @this);

		// Token: 0x0600A724 RID: 42788
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetDisableCameraCuts_Internal(IntPtr @this);

		// Token: 0x0600A725 RID: 42789
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentTime_Internal(IntPtr @this);

		// Token: 0x0600A726 RID: 42790
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBoundObjects_Internal(IntPtr @this, IntPtr ObjectBinding);

		// Token: 0x0600A727 RID: 42791
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearKeyFrames_Internal(IntPtr @this);

		// Token: 0x0600A728 RID: 42792
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CleanPauseOnFrame_Internal(IntPtr @this);

		// Token: 0x0600A729 RID: 42793
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ChangePlaybackDirection_Internal(IntPtr @this);

		// Token: 0x0600A72A RID: 42794 RVA: 0x000F6BD0 File Offset: 0x000F4DD0
		static UMovieSceneSequencePlayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneSequencePlayer");
		}

		// Token: 0x0600A72B RID: 42795 RVA: 0x000F6BE0 File Offset: 0x000F4DE0
		protected UMovieSceneSequencePlayer() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSequencePlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A72C RID: 42796 RVA: 0x000F6C08 File Offset: 0x000F4E08
		protected UMovieSceneSequencePlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004778 RID: 18296
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneSequencePlayer";

		// Token: 0x04004779 RID: 18297
		private static IntPtr _ClassPtr;

		// Token: 0x0400477A RID: 18298
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400477B RID: 18299
		internal static int __PropertyOffset_OnPlay;

		// Token: 0x0400477C RID: 18300
		[Nullable(2)]
		private FOnMovieSceneSequencePlayerEvent _OnPlay;

		// Token: 0x0400477D RID: 18301
		internal static int __PropertyOffset_OnPlayReverse;

		// Token: 0x0400477E RID: 18302
		[Nullable(2)]
		private FOnMovieSceneSequencePlayerEvent _OnPlayReverse;

		// Token: 0x0400477F RID: 18303
		internal static int __PropertyOffset_OnStop;

		// Token: 0x04004780 RID: 18304
		[Nullable(2)]
		private FOnMovieSceneSequencePlayerEvent _OnStop;

		// Token: 0x04004781 RID: 18305
		internal static int __PropertyOffset_OnPause;

		// Token: 0x04004782 RID: 18306
		[Nullable(2)]
		private FOnMovieSceneSequencePlayerEvent _OnPause;

		// Token: 0x04004783 RID: 18307
		internal static int __PropertyOffset_OnInterrupt;

		// Token: 0x04004784 RID: 18308
		[Nullable(2)]
		private FOnMovieSceneSequencePlayerEvent _OnInterrupt;

		// Token: 0x04004785 RID: 18309
		internal static int __PropertyOffset_OnFinished;

		// Token: 0x04004786 RID: 18310
		[Nullable(2)]
		private FOnMovieSceneSequencePlayerEvent _OnFinished;

		// Token: 0x04004787 RID: 18311
		internal static int __PropertyOffset_bReversePlayback;

		// Token: 0x04004788 RID: 18312
		internal static byte __PropertyMask_bReversePlayback;

		// Token: 0x04004789 RID: 18313
		internal static int __PropertyOffset_KeyFrames;

		// Token: 0x0400478A RID: 18314
		[Nullable(2)]
		private TArray<int> _KeyFrames;

		// Token: 0x0400478B RID: 18315
		internal static int __PropertyOffset_Sequence;

		// Token: 0x0400478C RID: 18316
		internal static int __PropertyOffset_StartTime;

		// Token: 0x0400478D RID: 18317
		[Nullable(2)]
		private FFrameNumber _StartTime;

		// Token: 0x0400478E RID: 18318
		internal static int __PropertyOffset_DurationFrames;

		// Token: 0x0400478F RID: 18319
		internal static int __PropertyOffset_DurationSubFrames;

		// Token: 0x04004790 RID: 18320
		internal static int __PropertyOffset_CurrentNumLoops;

		// Token: 0x04004791 RID: 18321
		internal static int __PropertyOffset_PlaybackSettings;

		// Token: 0x04004792 RID: 18322
		[Nullable(2)]
		private FMovieSceneSequencePlaybackSettings _PlaybackSettings;
	}
}
