using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002438 RID: 9272
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieScene.MovieSceneSequencePlayer")]
	[UnrealStructLayout(1816, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 1816)]
	public abstract class UMovieSceneSequencePlayer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022BD4 RID: 142292 RVA: 0x003360A0 File Offset: 0x003342A0
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneSequencePlayer._ClassPtr;
		}

		// Token: 0x170085A2 RID: 34210
		// (get) Token: 0x06022BD5 RID: 142293 RVA: 0x003360AC File Offset: 0x003342AC
		// (set) Token: 0x06022BD6 RID: 142294 RVA: 0x003360E5 File Offset: 0x003342E5
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

		// Token: 0x170085A3 RID: 34211
		// (get) Token: 0x06022BD7 RID: 142295 RVA: 0x00336108 File Offset: 0x00334308
		// (set) Token: 0x06022BD8 RID: 142296 RVA: 0x00336141 File Offset: 0x00334341
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

		// Token: 0x170085A4 RID: 34212
		// (get) Token: 0x06022BD9 RID: 142297 RVA: 0x00336164 File Offset: 0x00334364
		// (set) Token: 0x06022BDA RID: 142298 RVA: 0x0033619D File Offset: 0x0033439D
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

		// Token: 0x170085A5 RID: 34213
		// (get) Token: 0x06022BDB RID: 142299 RVA: 0x003361C0 File Offset: 0x003343C0
		// (set) Token: 0x06022BDC RID: 142300 RVA: 0x003361F9 File Offset: 0x003343F9
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

		// Token: 0x170085A6 RID: 34214
		// (get) Token: 0x06022BDD RID: 142301 RVA: 0x0033621C File Offset: 0x0033441C
		// (set) Token: 0x06022BDE RID: 142302 RVA: 0x00336255 File Offset: 0x00334455
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

		// Token: 0x170085A7 RID: 34215
		// (get) Token: 0x06022BDF RID: 142303 RVA: 0x00336278 File Offset: 0x00334478
		// (set) Token: 0x06022BE0 RID: 142304 RVA: 0x003362B1 File Offset: 0x003344B1
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

		// Token: 0x170085A8 RID: 34216
		// (get) Token: 0x06022BE1 RID: 142305 RVA: 0x003362D2 File Offset: 0x003344D2
		// (set) Token: 0x06022BE2 RID: 142306 RVA: 0x003362E6 File Offset: 0x003344E6
		[Nullable(0)]
		public unsafe TEnumAsByte<EMovieScenePlayerStatus> Status
		{
			[NullableContext(0)]
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_Status);
			}
			[NullableContext(0)]
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_Status) = value;
			}
		}

		// Token: 0x170085A9 RID: 34217
		// (get) Token: 0x06022BE3 RID: 142307 RVA: 0x003362FB File Offset: 0x003344FB
		// (set) Token: 0x06022BE4 RID: 142308 RVA: 0x00336314 File Offset: 0x00334514
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

		// Token: 0x170085AA RID: 34218
		// (get) Token: 0x06022BE5 RID: 142309 RVA: 0x00336344 File Offset: 0x00334544
		// (set) Token: 0x06022BE6 RID: 142310 RVA: 0x0033637D File Offset: 0x0033457D
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

		// Token: 0x170085AB RID: 34219
		// (get) Token: 0x06022BE7 RID: 142311 RVA: 0x0033638B File Offset: 0x0033458B
		// (set) Token: 0x06022BE8 RID: 142312 RVA: 0x0033639F File Offset: 0x0033459F
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

		// Token: 0x170085AC RID: 34220
		// (get) Token: 0x06022BE9 RID: 142313 RVA: 0x003363B4 File Offset: 0x003345B4
		// (set) Token: 0x06022BEA RID: 142314 RVA: 0x003363ED File Offset: 0x003345ED
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

		// Token: 0x170085AD RID: 34221
		// (get) Token: 0x06022BEB RID: 142315 RVA: 0x0033640E File Offset: 0x0033460E
		// (set) Token: 0x06022BEC RID: 142316 RVA: 0x0033641E File Offset: 0x0033461E
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

		// Token: 0x170085AE RID: 34222
		// (get) Token: 0x06022BED RID: 142317 RVA: 0x0033642F File Offset: 0x0033462F
		// (set) Token: 0x06022BEE RID: 142318 RVA: 0x0033643F File Offset: 0x0033463F
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

		// Token: 0x170085AF RID: 34223
		// (get) Token: 0x06022BEF RID: 142319 RVA: 0x00336450 File Offset: 0x00334650
		// (set) Token: 0x06022BF0 RID: 142320 RVA: 0x00336460 File Offset: 0x00334660
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

		// Token: 0x170085B0 RID: 34224
		// (get) Token: 0x06022BF1 RID: 142321 RVA: 0x00336474 File Offset: 0x00334674
		// (set) Token: 0x06022BF2 RID: 142322 RVA: 0x003364AD File Offset: 0x003346AD
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

		// Token: 0x170085B1 RID: 34225
		// (get) Token: 0x06022BF3 RID: 142323 RVA: 0x003364D0 File Offset: 0x003346D0
		// (set) Token: 0x06022BF4 RID: 142324 RVA: 0x00336509 File Offset: 0x00334709
		public FMovieSceneRootEvaluationTemplateInstance RootTemplateInstance
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneRootEvaluationTemplateInstance result;
				if ((result = this._RootTemplateInstance) == null)
				{
					result = (this._RootTemplateInstance = new FMovieSceneRootEvaluationTemplateInstance(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_RootTemplateInstance, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneRootEvaluationTemplateInstance.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_RootTemplateInstance, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170085B2 RID: 34226
		// (get) Token: 0x06022BF5 RID: 142325 RVA: 0x0033652C File Offset: 0x0033472C
		// (set) Token: 0x06022BF6 RID: 142326 RVA: 0x00336565 File Offset: 0x00334765
		public FMovieSceneSequenceReplProperties NetSyncProps
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneSequenceReplProperties result;
				if ((result = this._NetSyncProps) == null)
				{
					result = (this._NetSyncProps = new FMovieSceneSequenceReplProperties(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_NetSyncProps, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneSequenceReplProperties.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_NetSyncProps, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170085B3 RID: 34227
		// (get) Token: 0x06022BF7 RID: 142327 RVA: 0x00336586 File Offset: 0x00334786
		// (set) Token: 0x06022BF8 RID: 142328 RVA: 0x003365A0 File Offset: 0x003347A0
		[Nullable(2)]
		public unsafe IMovieScenePlaybackClient PlaybackClient
		{
			[NullableContext(2)]
			get
			{
				return (IMovieScenePlaybackClient)BuiltinUtils.GetOrCreateUObjectByNativePointer(*(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_PlaybackClient));
			}
			[NullableContext(2)]
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneSequencePlayer.__PropertyOffset_PlaybackClient) = new FScriptInterface(value, (value != null) ? value.InterfaceOffset() : 0);
			}
		}

		// Token: 0x170085B4 RID: 34228
		// (get) Token: 0x06022BF9 RID: 142329 RVA: 0x003365C6 File Offset: 0x003347C6
		// (set) Token: 0x06022BFA RID: 142330 RVA: 0x003365DA File Offset: 0x003347DA
		[Nullable(2)]
		public unsafe UMovieSceneSequenceTickManager TickManager
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMovieSceneSequenceTickManager>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneSequencePlayer.__PropertyOffset_TickManager);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneSequencePlayer.__PropertyOffset_TickManager, value);
			}
		}

		// Token: 0x06022BFB RID: 142331 RVA: 0x003365EF File Offset: 0x003347EF
		public void StopAtCurrentTime()
		{
			UMovieSceneSequencePlayer.__StopAtCurrentTime_Internal(base.NativePtr);
		}

		// Token: 0x06022BFC RID: 142332 RVA: 0x003365FC File Offset: 0x003347FC
		public void Stop()
		{
			UMovieSceneSequencePlayer.__Stop_Internal(base.NativePtr);
		}

		// Token: 0x06022BFD RID: 142333 RVA: 0x00336609 File Offset: 0x00334809
		public void SetTimeRange(float StartTime, float Duration)
		{
			UMovieSceneSequencePlayer.__SetTimeRange_Internal(base.NativePtr, StartTime, Duration);
		}

		// Token: 0x06022BFE RID: 142334 RVA: 0x00336618 File Offset: 0x00334818
		public void SetPlayRate(float PlayRate)
		{
			UMovieSceneSequencePlayer.__SetPlayRate_Internal(base.NativePtr, PlayRate);
		}

		// Token: 0x06022BFF RID: 142335 RVA: 0x00336626 File Offset: 0x00334826
		[NullableContext(2)]
		public void SetPlaybackPositionWithNoEval(FMovieSceneSequencePlaybackParams PlaybackParams)
		{
			UMovieSceneSequencePlayer.__SetPlaybackPositionWithNoEval_Internal(base.NativePtr, (PlaybackParams ?? new FMovieSceneSequencePlaybackParams()).NativePtr);
		}

		// Token: 0x06022C00 RID: 142336 RVA: 0x00336642 File Offset: 0x00334842
		[NullableContext(2)]
		public void SetPlaybackPosition(FMovieSceneSequencePlaybackParams PlaybackParams)
		{
			UMovieSceneSequencePlayer.__SetPlaybackPosition_Internal(base.NativePtr, (PlaybackParams ?? new FMovieSceneSequencePlaybackParams()).NativePtr);
		}

		// Token: 0x06022C01 RID: 142337 RVA: 0x0033665E File Offset: 0x0033485E
		[NullableContext(2)]
		public void SetKeyFrames(in TArray<int> InKeyFrames)
		{
			UMovieSceneSequencePlayer.__SetKeyFrames_Internal(base.NativePtr, (InKeyFrames ?? new TArray<int>()).NativePtr);
		}

		// Token: 0x06022C02 RID: 142338 RVA: 0x0033667B File Offset: 0x0033487B
		public void SetFrameRate(FFrameRate FrameRate)
		{
			UMovieSceneSequencePlayer.__SetFrameRate_Internal(base.NativePtr, FrameRate);
		}

		// Token: 0x06022C03 RID: 142339 RVA: 0x00336689 File Offset: 0x00334889
		public void SetFrameRange(int StartFrame, int Duration, float SubFrames = 0f)
		{
			UMovieSceneSequencePlayer.__SetFrameRange_Internal(base.NativePtr, StartFrame, Duration, SubFrames);
		}

		// Token: 0x06022C04 RID: 142340 RVA: 0x00336699 File Offset: 0x00334899
		public void SetDisableCameraCuts(bool bInDisableCameraCuts)
		{
			UMovieSceneSequencePlayer.__SetDisableCameraCuts_Internal(base.NativePtr, bInDisableCameraCuts);
		}

		// Token: 0x06022C05 RID: 142341 RVA: 0x003366A7 File Offset: 0x003348A7
		public void ScrubToSeconds(float TimeInSeconds)
		{
			UMovieSceneSequencePlayer.__ScrubToSeconds_Internal(base.NativePtr, TimeInSeconds);
		}

		// Token: 0x06022C06 RID: 142342 RVA: 0x003366B8 File Offset: 0x003348B8
		public unsafe bool ScrubToMarkedFrame(string InLabel)
		{
			FString fstring = FString.AllocTemp(InLabel);
			bool result = UMovieSceneSequencePlayer.__ScrubToMarkedFrame_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06022C07 RID: 142343 RVA: 0x003366E2 File Offset: 0x003348E2
		[NullableContext(2)]
		public void ScrubToFrame(FFrameTime NewPosition)
		{
			UMovieSceneSequencePlayer.__ScrubToFrame_Internal(base.NativePtr, (NewPosition ?? new FFrameTime()).NativePtr);
		}

		// Token: 0x06022C08 RID: 142344 RVA: 0x003366FE File Offset: 0x003348FE
		public void Scrub()
		{
			UMovieSceneSequencePlayer.__Scrub_Internal(base.NativePtr);
		}

		// Token: 0x06022C09 RID: 142345 RVA: 0x0033670B File Offset: 0x0033490B
		[NullableContext(2)]
		public void RPC_OnStopEvent(FFrameTime StoppedTime)
		{
			UMovieSceneSequencePlayer.__RPC_OnStopEvent_Internal(base.NativePtr, (StoppedTime ?? new FFrameTime()).NativePtr);
		}

		// Token: 0x06022C0A RID: 142346 RVA: 0x00336727 File Offset: 0x00334927
		[NullableContext(2)]
		public void RPC_ExplicitServerUpdateEvent(EUpdatePositionMethod Method, FFrameTime RelevantTime)
		{
			UMovieSceneSequencePlayer.__RPC_ExplicitServerUpdateEvent_Internal(base.NativePtr, Method, (RelevantTime ?? new FFrameTime()).NativePtr);
		}

		// Token: 0x06022C0B RID: 142347 RVA: 0x00336744 File Offset: 0x00334944
		public void PlayToSeconds(float TimeInSeconds)
		{
			UMovieSceneSequencePlayer.__PlayToSeconds_Internal(base.NativePtr, TimeInSeconds);
		}

		// Token: 0x06022C0C RID: 142348 RVA: 0x00336754 File Offset: 0x00334954
		public unsafe bool PlayToMarkedFrame(string InLabel)
		{
			FString fstring = FString.AllocTemp(InLabel);
			bool result = UMovieSceneSequencePlayer.__PlayToMarkedFrame_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06022C0D RID: 142349 RVA: 0x0033677E File Offset: 0x0033497E
		[NullableContext(2)]
		public void PlayToFrame(FFrameTime NewPosition)
		{
			UMovieSceneSequencePlayer.__PlayToFrame_Internal(base.NativePtr, (NewPosition ?? new FFrameTime()).NativePtr);
		}

		// Token: 0x06022C0E RID: 142350 RVA: 0x0033679C File Offset: 0x0033499C
		public unsafe void PlayTo_Loop([Nullable(2)] FMovieSceneSequencePlaybackParams InPlaybackParams, string StartMarkedFrame)
		{
			FString fstring = FString.AllocTemp(StartMarkedFrame);
			UMovieSceneSequencePlayer.__PlayTo_Loop_Internal(base.NativePtr, (InPlaybackParams ?? new FMovieSceneSequencePlaybackParams()).NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
		}

		// Token: 0x06022C0F RID: 142351 RVA: 0x003367D5 File Offset: 0x003349D5
		[NullableContext(2)]
		public void PlayTo_Circle(FMovieSceneSequencePlaybackParams InPlaybackParams, bool InAutoDirect = false, bool InIsForward = true)
		{
			UMovieSceneSequencePlayer.__PlayTo_Circle_Internal(base.NativePtr, (InPlaybackParams ?? new FMovieSceneSequencePlaybackParams()).NativePtr, InAutoDirect, InIsForward);
		}

		// Token: 0x06022C10 RID: 142352 RVA: 0x003367F3 File Offset: 0x003349F3
		[NullableContext(2)]
		public void PlayTo(FMovieSceneSequencePlaybackParams PlaybackParams)
		{
			UMovieSceneSequencePlayer.__PlayTo_Internal(base.NativePtr, (PlaybackParams ?? new FMovieSceneSequencePlaybackParams()).NativePtr);
		}

		// Token: 0x06022C11 RID: 142353 RVA: 0x0033680F File Offset: 0x00334A0F
		public void PlayReverseLooping(int NumLoops = -1)
		{
			UMovieSceneSequencePlayer.__PlayReverseLooping_Internal(base.NativePtr, NumLoops);
		}

		// Token: 0x06022C12 RID: 142354 RVA: 0x0033681D File Offset: 0x00334A1D
		public void PlayReverse()
		{
			UMovieSceneSequencePlayer.__PlayReverse_Internal(base.NativePtr);
		}

		// Token: 0x06022C13 RID: 142355 RVA: 0x0033682A File Offset: 0x00334A2A
		public void PlayLooping(int NumLoops = -1)
		{
			UMovieSceneSequencePlayer.__PlayLooping_Internal(base.NativePtr, NumLoops);
		}

		// Token: 0x06022C14 RID: 142356 RVA: 0x00336838 File Offset: 0x00334A38
		public void Play()
		{
			UMovieSceneSequencePlayer.__Play_Internal(base.NativePtr);
		}

		// Token: 0x06022C15 RID: 142357 RVA: 0x00336845 File Offset: 0x00334A45
		public void PauseOnNextFrame()
		{
			UMovieSceneSequencePlayer.__PauseOnNextFrame_Internal(base.NativePtr);
		}

		// Token: 0x06022C16 RID: 142358 RVA: 0x00336852 File Offset: 0x00334A52
		public void Pause()
		{
			UMovieSceneSequencePlayer.__Pause_Internal(base.NativePtr);
		}

		// Token: 0x06022C17 RID: 142359 RVA: 0x0033685F File Offset: 0x00334A5F
		public void JumpToSeconds(float TimeInSeconds)
		{
			UMovieSceneSequencePlayer.__JumpToSeconds_Internal(base.NativePtr, TimeInSeconds);
		}

		// Token: 0x06022C18 RID: 142360 RVA: 0x00336870 File Offset: 0x00334A70
		public unsafe bool JumpToMarkedFrame(string InLabel)
		{
			FString fstring = FString.AllocTemp(InLabel);
			bool result = UMovieSceneSequencePlayer.__JumpToMarkedFrame_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06022C19 RID: 142361 RVA: 0x0033689A File Offset: 0x00334A9A
		[NullableContext(2)]
		public void JumpToFrame(FFrameTime NewPosition)
		{
			UMovieSceneSequencePlayer.__JumpToFrame_Internal(base.NativePtr, (NewPosition ?? new FFrameTime()).NativePtr);
		}

		// Token: 0x06022C1A RID: 142362 RVA: 0x003368B6 File Offset: 0x00334AB6
		public bool IsStopped()
		{
			return UMovieSceneSequencePlayer.__IsStopped_Internal(base.NativePtr);
		}

		// Token: 0x06022C1B RID: 142363 RVA: 0x003368C3 File Offset: 0x00334AC3
		public bool IsReversed()
		{
			return UMovieSceneSequencePlayer.__IsReversed_Internal(base.NativePtr);
		}

		// Token: 0x06022C1C RID: 142364 RVA: 0x003368D0 File Offset: 0x00334AD0
		public bool IsPlaying()
		{
			return UMovieSceneSequencePlayer.__IsPlaying_Internal(base.NativePtr);
		}

		// Token: 0x06022C1D RID: 142365 RVA: 0x003368DD File Offset: 0x00334ADD
		public bool IsPaused()
		{
			return UMovieSceneSequencePlayer.__IsPaused_Internal(base.NativePtr);
		}

		// Token: 0x06022C1E RID: 142366 RVA: 0x003368EA File Offset: 0x00334AEA
		public void GoToEndAndStop(EUpdatePositionMethod UpdateMethod = EUpdatePositionMethod.Jump)
		{
			UMovieSceneSequencePlayer.__GoToEndAndStop_Internal(base.NativePtr, UpdateMethod);
		}

		// Token: 0x06022C1F RID: 142367 RVA: 0x003368F8 File Offset: 0x00334AF8
		public FQualifiedFrameTime GetStartTime()
		{
			return new FQualifiedFrameTime(UMovieSceneSequencePlayer.__GetStartTime_Internal(base.NativePtr), null);
		}

		// Token: 0x06022C20 RID: 142368 RVA: 0x0033690B File Offset: 0x00334B0B
		public float GetPlayRate()
		{
			return UMovieSceneSequencePlayer.__GetPlayRate_Internal(base.NativePtr);
		}

		// Token: 0x06022C21 RID: 142369 RVA: 0x00336918 File Offset: 0x00334B18
		public TArray<FMovieSceneObjectBindingID> GetObjectBindings([Nullable(2)] UObject InObject)
		{
			return new TArray<FMovieSceneObjectBindingID>(UMovieSceneSequencePlayer.__GetObjectBindings_Internal(base.NativePtr, (InObject != null) ? InObject.NativePtr : IntPtr.Zero), null);
		}

		// Token: 0x06022C22 RID: 142370 RVA: 0x0033693B File Offset: 0x00334B3B
		public FFrameRate GetFrameRate()
		{
			return UMovieSceneSequencePlayer.__GetFrameRate_Internal(base.NativePtr);
		}

		// Token: 0x06022C23 RID: 142371 RVA: 0x00336948 File Offset: 0x00334B48
		public int GetFrameDuration()
		{
			return UMovieSceneSequencePlayer.__GetFrameDuration_Internal(base.NativePtr);
		}

		// Token: 0x06022C24 RID: 142372 RVA: 0x00336955 File Offset: 0x00334B55
		public FQualifiedFrameTime GetEndTime()
		{
			return new FQualifiedFrameTime(UMovieSceneSequencePlayer.__GetEndTime_Internal(base.NativePtr), null);
		}

		// Token: 0x06022C25 RID: 142373 RVA: 0x00336968 File Offset: 0x00334B68
		public FQualifiedFrameTime GetDuration()
		{
			return new FQualifiedFrameTime(UMovieSceneSequencePlayer.__GetDuration_Internal(base.NativePtr), null);
		}

		// Token: 0x06022C26 RID: 142374 RVA: 0x0033697B File Offset: 0x00334B7B
		public bool GetDisableCameraCuts()
		{
			return UMovieSceneSequencePlayer.__GetDisableCameraCuts_Internal(base.NativePtr);
		}

		// Token: 0x06022C27 RID: 142375 RVA: 0x00336988 File Offset: 0x00334B88
		public FQualifiedFrameTime GetCurrentTime()
		{
			return new FQualifiedFrameTime(UMovieSceneSequencePlayer.__GetCurrentTime_Internal(base.NativePtr), null);
		}

		// Token: 0x06022C28 RID: 142376 RVA: 0x0033699B File Offset: 0x00334B9B
		public TArray<UObject> GetBoundObjects([Nullable(2)] FMovieSceneObjectBindingID ObjectBinding)
		{
			return new TArray<UObject>(UMovieSceneSequencePlayer.__GetBoundObjects_Internal(base.NativePtr, (ObjectBinding ?? new FMovieSceneObjectBindingID()).NativePtr), null);
		}

		// Token: 0x06022C29 RID: 142377 RVA: 0x003369BD File Offset: 0x00334BBD
		public void ClearKeyFrames()
		{
			UMovieSceneSequencePlayer.__ClearKeyFrames_Internal(base.NativePtr);
		}

		// Token: 0x06022C2A RID: 142378 RVA: 0x003369CA File Offset: 0x00334BCA
		public void CleanPauseOnFrame()
		{
			UMovieSceneSequencePlayer.__CleanPauseOnFrame_Internal(base.NativePtr);
		}

		// Token: 0x06022C2B RID: 142379 RVA: 0x003369D7 File Offset: 0x00334BD7
		public void ChangePlaybackDirection()
		{
			UMovieSceneSequencePlayer.__ChangePlaybackDirection_Internal(base.NativePtr);
		}

		// Token: 0x06022C2C RID: 142380
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __StopAtCurrentTime_Internal(IntPtr @this);

		// Token: 0x06022C2D RID: 142381
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Stop_Internal(IntPtr @this);

		// Token: 0x06022C2E RID: 142382
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTimeRange_Internal(IntPtr @this, float StartTime, float Duration);

		// Token: 0x06022C2F RID: 142383
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlayRate_Internal(IntPtr @this, float PlayRate);

		// Token: 0x06022C30 RID: 142384
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlaybackPositionWithNoEval_Internal(IntPtr @this, IntPtr PlaybackParams);

		// Token: 0x06022C31 RID: 142385
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetPlaybackPosition_Internal(IntPtr @this, IntPtr PlaybackParams);

		// Token: 0x06022C32 RID: 142386
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetKeyFrames_Internal(IntPtr @this, IntPtr InKeyFrames);

		// Token: 0x06022C33 RID: 142387
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFrameRate_Internal(IntPtr @this, FFrameRate FrameRate);

		// Token: 0x06022C34 RID: 142388
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetFrameRange_Internal(IntPtr @this, int StartFrame, int Duration, float SubFrames);

		// Token: 0x06022C35 RID: 142389
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDisableCameraCuts_Internal(IntPtr @this, bool bInDisableCameraCuts);

		// Token: 0x06022C36 RID: 142390
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrubToSeconds_Internal(IntPtr @this, float TimeInSeconds);

		// Token: 0x06022C37 RID: 142391
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __ScrubToMarkedFrame_Internal(IntPtr @this, in FString InLabel);

		// Token: 0x06022C38 RID: 142392
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ScrubToFrame_Internal(IntPtr @this, IntPtr NewPosition);

		// Token: 0x06022C39 RID: 142393
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Scrub_Internal(IntPtr @this);

		// Token: 0x06022C3A RID: 142394
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RPC_OnStopEvent_Internal(IntPtr @this, IntPtr StoppedTime);

		// Token: 0x06022C3B RID: 142395
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __RPC_ExplicitServerUpdateEvent_Internal(IntPtr @this, EUpdatePositionMethod Method, IntPtr RelevantTime);

		// Token: 0x06022C3C RID: 142396
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayToSeconds_Internal(IntPtr @this, float TimeInSeconds);

		// Token: 0x06022C3D RID: 142397
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __PlayToMarkedFrame_Internal(IntPtr @this, in FString InLabel);

		// Token: 0x06022C3E RID: 142398
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayToFrame_Internal(IntPtr @this, IntPtr NewPosition);

		// Token: 0x06022C3F RID: 142399
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayTo_Loop_Internal(IntPtr @this, IntPtr InPlaybackParams, in FString StartMarkedFrame);

		// Token: 0x06022C40 RID: 142400
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayTo_Circle_Internal(IntPtr @this, IntPtr InPlaybackParams, bool InAutoDirect, bool InIsForward);

		// Token: 0x06022C41 RID: 142401
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayTo_Internal(IntPtr @this, IntPtr PlaybackParams);

		// Token: 0x06022C42 RID: 142402
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayReverseLooping_Internal(IntPtr @this, int NumLoops);

		// Token: 0x06022C43 RID: 142403
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayReverse_Internal(IntPtr @this);

		// Token: 0x06022C44 RID: 142404
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayLooping_Internal(IntPtr @this, int NumLoops);

		// Token: 0x06022C45 RID: 142405
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Play_Internal(IntPtr @this);

		// Token: 0x06022C46 RID: 142406
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PauseOnNextFrame_Internal(IntPtr @this);

		// Token: 0x06022C47 RID: 142407
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Pause_Internal(IntPtr @this);

		// Token: 0x06022C48 RID: 142408
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __JumpToSeconds_Internal(IntPtr @this, float TimeInSeconds);

		// Token: 0x06022C49 RID: 142409
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __JumpToMarkedFrame_Internal(IntPtr @this, in FString InLabel);

		// Token: 0x06022C4A RID: 142410
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __JumpToFrame_Internal(IntPtr @this, IntPtr NewPosition);

		// Token: 0x06022C4B RID: 142411
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsStopped_Internal(IntPtr @this);

		// Token: 0x06022C4C RID: 142412
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsReversed_Internal(IntPtr @this);

		// Token: 0x06022C4D RID: 142413
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlaying_Internal(IntPtr @this);

		// Token: 0x06022C4E RID: 142414
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPaused_Internal(IntPtr @this);

		// Token: 0x06022C4F RID: 142415
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GoToEndAndStop_Internal(IntPtr @this, EUpdatePositionMethod UpdateMethod);

		// Token: 0x06022C50 RID: 142416
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetStartTime_Internal(IntPtr @this);

		// Token: 0x06022C51 RID: 142417
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetPlayRate_Internal(IntPtr @this);

		// Token: 0x06022C52 RID: 142418
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetObjectBindings_Internal(IntPtr @this, IntPtr InObject);

		// Token: 0x06022C53 RID: 142419
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FFrameRate __GetFrameRate_Internal(IntPtr @this);

		// Token: 0x06022C54 RID: 142420
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetFrameDuration_Internal(IntPtr @this);

		// Token: 0x06022C55 RID: 142421
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetEndTime_Internal(IntPtr @this);

		// Token: 0x06022C56 RID: 142422
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDuration_Internal(IntPtr @this);

		// Token: 0x06022C57 RID: 142423
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __GetDisableCameraCuts_Internal(IntPtr @this);

		// Token: 0x06022C58 RID: 142424
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetCurrentTime_Internal(IntPtr @this);

		// Token: 0x06022C59 RID: 142425
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetBoundObjects_Internal(IntPtr @this, IntPtr ObjectBinding);

		// Token: 0x06022C5A RID: 142426
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ClearKeyFrames_Internal(IntPtr @this);

		// Token: 0x06022C5B RID: 142427
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __CleanPauseOnFrame_Internal(IntPtr @this);

		// Token: 0x06022C5C RID: 142428
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __ChangePlaybackDirection_Internal(IntPtr @this);

		// Token: 0x06022C5D RID: 142429 RVA: 0x003369E4 File Offset: 0x00334BE4
		static UMovieSceneSequencePlayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneSequencePlayer");
		}

		// Token: 0x06022C5E RID: 142430 RVA: 0x003369F4 File Offset: 0x00334BF4
		protected UMovieSceneSequencePlayer() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneSequencePlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022C5F RID: 142431 RVA: 0x00336A1C File Offset: 0x00334C1C
		protected UMovieSceneSequencePlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040128ED RID: 76013
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneSequencePlayer";

		// Token: 0x040128EE RID: 76014
		private static IntPtr _ClassPtr;

		// Token: 0x040128EF RID: 76015
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040128F0 RID: 76016
		internal static int __PropertyOffset_OnPlay;

		// Token: 0x040128F1 RID: 76017
		[Nullable(2)]
		private FOnMovieSceneSequencePlayerEvent _OnPlay;

		// Token: 0x040128F2 RID: 76018
		internal static int __PropertyOffset_OnPlayReverse;

		// Token: 0x040128F3 RID: 76019
		[Nullable(2)]
		private FOnMovieSceneSequencePlayerEvent _OnPlayReverse;

		// Token: 0x040128F4 RID: 76020
		internal static int __PropertyOffset_OnStop;

		// Token: 0x040128F5 RID: 76021
		[Nullable(2)]
		private FOnMovieSceneSequencePlayerEvent _OnStop;

		// Token: 0x040128F6 RID: 76022
		internal static int __PropertyOffset_OnPause;

		// Token: 0x040128F7 RID: 76023
		[Nullable(2)]
		private FOnMovieSceneSequencePlayerEvent _OnPause;

		// Token: 0x040128F8 RID: 76024
		internal static int __PropertyOffset_OnInterrupt;

		// Token: 0x040128F9 RID: 76025
		[Nullable(2)]
		private FOnMovieSceneSequencePlayerEvent _OnInterrupt;

		// Token: 0x040128FA RID: 76026
		internal static int __PropertyOffset_OnFinished;

		// Token: 0x040128FB RID: 76027
		[Nullable(2)]
		private FOnMovieSceneSequencePlayerEvent _OnFinished;

		// Token: 0x040128FC RID: 76028
		internal static int __PropertyOffset_Status;

		// Token: 0x040128FD RID: 76029
		internal static int __PropertyOffset_bReversePlayback;

		// Token: 0x040128FE RID: 76030
		internal static byte __PropertyMask_bReversePlayback;

		// Token: 0x040128FF RID: 76031
		internal static int __PropertyOffset_KeyFrames;

		// Token: 0x04012900 RID: 76032
		[Nullable(2)]
		private TArray<int> _KeyFrames;

		// Token: 0x04012901 RID: 76033
		internal static int __PropertyOffset_Sequence;

		// Token: 0x04012902 RID: 76034
		internal static int __PropertyOffset_StartTime;

		// Token: 0x04012903 RID: 76035
		[Nullable(2)]
		private FFrameNumber _StartTime;

		// Token: 0x04012904 RID: 76036
		internal static int __PropertyOffset_DurationFrames;

		// Token: 0x04012905 RID: 76037
		internal static int __PropertyOffset_DurationSubFrames;

		// Token: 0x04012906 RID: 76038
		internal static int __PropertyOffset_CurrentNumLoops;

		// Token: 0x04012907 RID: 76039
		internal static int __PropertyOffset_PlaybackSettings;

		// Token: 0x04012908 RID: 76040
		[Nullable(2)]
		private FMovieSceneSequencePlaybackSettings _PlaybackSettings;

		// Token: 0x04012909 RID: 76041
		internal static int __PropertyOffset_RootTemplateInstance;

		// Token: 0x0401290A RID: 76042
		[Nullable(2)]
		private FMovieSceneRootEvaluationTemplateInstance _RootTemplateInstance;

		// Token: 0x0401290B RID: 76043
		internal static int __PropertyOffset_NetSyncProps;

		// Token: 0x0401290C RID: 76044
		[Nullable(2)]
		private FMovieSceneSequenceReplProperties _NetSyncProps;

		// Token: 0x0401290D RID: 76045
		internal static int __PropertyOffset_PlaybackClient;

		// Token: 0x0401290E RID: 76046
		internal static int __PropertyOffset_TickManager;
	}
}
