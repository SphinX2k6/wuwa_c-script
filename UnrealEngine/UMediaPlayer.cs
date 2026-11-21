using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000750 RID: 1872
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MediaAssets.MediaPlayer")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UMediaPlayer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A30B RID: 41739 RVA: 0x000F1086 File Offset: 0x000EF286
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMediaPlayer._ClassPtr;
		}

		// Token: 0x0600A30C RID: 41740 RVA: 0x000F1094 File Offset: 0x000EF294
		public UMediaPlayer() : this(BuiltinUtils.AllocNativeUObject(UMediaPlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A30D RID: 41741 RVA: 0x000F10BC File Offset: 0x000EF2BC
		public UMediaPlayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMediaPlayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17001E45 RID: 7749
		// (get) Token: 0x0600A30E RID: 41742 RVA: 0x000F10F0 File Offset: 0x000EF2F0
		// (set) Token: 0x0600A30F RID: 41743 RVA: 0x000F1129 File Offset: 0x000EF329
		public FOnMediaPlayerMediaEvent OnEndReached
		{
			get
			{
				base.FastCheckIsValid();
				FOnMediaPlayerMediaEvent result;
				if ((result = this._OnEndReached) == null)
				{
					result = (this._OnEndReached = new FOnMediaPlayerMediaEvent(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_OnEndReached, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_OnEndReached, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001E46 RID: 7750
		// (get) Token: 0x0600A310 RID: 41744 RVA: 0x000F114C File Offset: 0x000EF34C
		// (set) Token: 0x0600A311 RID: 41745 RVA: 0x000F1185 File Offset: 0x000EF385
		public FOnMediaPlayerMediaEvent OnMediaClosed
		{
			get
			{
				base.FastCheckIsValid();
				FOnMediaPlayerMediaEvent result;
				if ((result = this._OnMediaClosed) == null)
				{
					result = (this._OnMediaClosed = new FOnMediaPlayerMediaEvent(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_OnMediaClosed, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_OnMediaClosed, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001E47 RID: 7751
		// (get) Token: 0x0600A312 RID: 41746 RVA: 0x000F11A8 File Offset: 0x000EF3A8
		// (set) Token: 0x0600A313 RID: 41747 RVA: 0x000F11E1 File Offset: 0x000EF3E1
		public FOnMediaPlayerMediaOpened OnMediaOpened
		{
			get
			{
				base.FastCheckIsValid();
				FOnMediaPlayerMediaOpened result;
				if ((result = this._OnMediaOpened) == null)
				{
					result = (this._OnMediaOpened = new FOnMediaPlayerMediaOpened(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_OnMediaOpened, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_OnMediaOpened, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001E48 RID: 7752
		// (get) Token: 0x0600A314 RID: 41748 RVA: 0x000F1204 File Offset: 0x000EF404
		// (set) Token: 0x0600A315 RID: 41749 RVA: 0x000F123D File Offset: 0x000EF43D
		public FOnMediaPlayerMediaOpenFailed OnMediaOpenFailed
		{
			get
			{
				base.FastCheckIsValid();
				FOnMediaPlayerMediaOpenFailed result;
				if ((result = this._OnMediaOpenFailed) == null)
				{
					result = (this._OnMediaOpenFailed = new FOnMediaPlayerMediaOpenFailed(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_OnMediaOpenFailed, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_OnMediaOpenFailed, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001E49 RID: 7753
		// (get) Token: 0x0600A316 RID: 41750 RVA: 0x000F1260 File Offset: 0x000EF460
		// (set) Token: 0x0600A317 RID: 41751 RVA: 0x000F1299 File Offset: 0x000EF499
		public FOnMediaPlayerMediaEvent OnPlaybackResumed
		{
			get
			{
				base.FastCheckIsValid();
				FOnMediaPlayerMediaEvent result;
				if ((result = this._OnPlaybackResumed) == null)
				{
					result = (this._OnPlaybackResumed = new FOnMediaPlayerMediaEvent(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_OnPlaybackResumed, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_OnPlaybackResumed, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001E4A RID: 7754
		// (get) Token: 0x0600A318 RID: 41752 RVA: 0x000F12BC File Offset: 0x000EF4BC
		// (set) Token: 0x0600A319 RID: 41753 RVA: 0x000F12F5 File Offset: 0x000EF4F5
		public FOnMediaPlayerMediaEvent OnPlaybackSuspended
		{
			get
			{
				base.FastCheckIsValid();
				FOnMediaPlayerMediaEvent result;
				if ((result = this._OnPlaybackSuspended) == null)
				{
					result = (this._OnPlaybackSuspended = new FOnMediaPlayerMediaEvent(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_OnPlaybackSuspended, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_OnPlaybackSuspended, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001E4B RID: 7755
		// (get) Token: 0x0600A31A RID: 41754 RVA: 0x000F1318 File Offset: 0x000EF518
		// (set) Token: 0x0600A31B RID: 41755 RVA: 0x000F1351 File Offset: 0x000EF551
		public FOnMediaPlayerMediaEvent OnSeekCompleted
		{
			get
			{
				base.FastCheckIsValid();
				FOnMediaPlayerMediaEvent result;
				if ((result = this._OnSeekCompleted) == null)
				{
					result = (this._OnSeekCompleted = new FOnMediaPlayerMediaEvent(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_OnSeekCompleted, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_OnSeekCompleted, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001E4C RID: 7756
		// (get) Token: 0x0600A31C RID: 41756 RVA: 0x000F1374 File Offset: 0x000EF574
		// (set) Token: 0x0600A31D RID: 41757 RVA: 0x000F13AD File Offset: 0x000EF5AD
		public FOnMediaPlayerMediaEvent OnTracksChanged
		{
			get
			{
				base.FastCheckIsValid();
				FOnMediaPlayerMediaEvent result;
				if ((result = this._OnTracksChanged) == null)
				{
					result = (this._OnTracksChanged = new FOnMediaPlayerMediaEvent(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_OnTracksChanged, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_OnTracksChanged, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x17001E4D RID: 7757
		// (get) Token: 0x0600A31E RID: 41758 RVA: 0x000F13D0 File Offset: 0x000EF5D0
		// (set) Token: 0x0600A31F RID: 41759 RVA: 0x000F1409 File Offset: 0x000EF609
		public FTimespan CacheAhead
		{
			get
			{
				base.FastCheckIsValid();
				FTimespan result;
				if ((result = this._CacheAhead) == null)
				{
					result = (this._CacheAhead = new FTimespan(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_CacheAhead, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTimespan.StaticStruct(), base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_CacheAhead, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001E4E RID: 7758
		// (get) Token: 0x0600A320 RID: 41760 RVA: 0x000F142C File Offset: 0x000EF62C
		// (set) Token: 0x0600A321 RID: 41761 RVA: 0x000F1465 File Offset: 0x000EF665
		public FTimespan CacheBehind
		{
			get
			{
				base.FastCheckIsValid();
				FTimespan result;
				if ((result = this._CacheBehind) == null)
				{
					result = (this._CacheBehind = new FTimespan(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_CacheBehind, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTimespan.StaticStruct(), base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_CacheBehind, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001E4F RID: 7759
		// (get) Token: 0x0600A322 RID: 41762 RVA: 0x000F1488 File Offset: 0x000EF688
		// (set) Token: 0x0600A323 RID: 41763 RVA: 0x000F14C1 File Offset: 0x000EF6C1
		public FTimespan CacheBehindGame
		{
			get
			{
				base.FastCheckIsValid();
				FTimespan result;
				if ((result = this._CacheBehindGame) == null)
				{
					result = (this._CacheBehindGame = new FTimespan(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_CacheBehindGame, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTimespan.StaticStruct(), base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_CacheBehindGame, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001E50 RID: 7760
		// (get) Token: 0x0600A324 RID: 41764 RVA: 0x000F14E2 File Offset: 0x000EF6E2
		// (set) Token: 0x0600A325 RID: 41765 RVA: 0x000F14F2 File Offset: 0x000EF6F2
		public unsafe bool NativeAudioOut
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_NativeAudioOut) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_NativeAudioOut) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E51 RID: 7761
		// (get) Token: 0x0600A326 RID: 41766 RVA: 0x000F1503 File Offset: 0x000EF703
		// (set) Token: 0x0600A327 RID: 41767 RVA: 0x000F1513 File Offset: 0x000EF713
		public unsafe bool PlayOnOpen
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_PlayOnOpen) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_PlayOnOpen) = (value ? 1 : 0);
			}
		}

		// Token: 0x17001E52 RID: 7762
		// (get) Token: 0x0600A328 RID: 41768 RVA: 0x000F1524 File Offset: 0x000EF724
		// (set) Token: 0x0600A329 RID: 41769 RVA: 0x000F153D File Offset: 0x000EF73D
		public unsafe bool Shuffle
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_Shuffle) & UMediaPlayer.__PropertyMask_Shuffle) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_Shuffle) = ((*(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_Shuffle) & ~UMediaPlayer.__PropertyMask_Shuffle) | (value ? UMediaPlayer.__PropertyMask_Shuffle : 0));
			}
		}

		// Token: 0x17001E53 RID: 7763
		// (get) Token: 0x0600A32A RID: 41770 RVA: 0x000F156D File Offset: 0x000EF76D
		// (set) Token: 0x0600A32B RID: 41771 RVA: 0x000F1586 File Offset: 0x000EF786
		public unsafe bool Loop
		{
			get
			{
				return (*(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_Loop) & UMediaPlayer.__PropertyMask_Loop) > 0;
			}
			set
			{
				*(this._NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_Loop) = ((*(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_Loop) & ~UMediaPlayer.__PropertyMask_Loop) | (value ? UMediaPlayer.__PropertyMask_Loop : 0));
			}
		}

		// Token: 0x17001E54 RID: 7764
		// (get) Token: 0x0600A32C RID: 41772 RVA: 0x000F15B6 File Offset: 0x000EF7B6
		// (set) Token: 0x0600A32D RID: 41773 RVA: 0x000F15C6 File Offset: 0x000EF7C6
		public unsafe int PlaylistIndex
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_PlaylistIndex);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_PlaylistIndex) = value;
			}
		}

		// Token: 0x17001E55 RID: 7765
		// (get) Token: 0x0600A32E RID: 41774 RVA: 0x000F15D8 File Offset: 0x000EF7D8
		// (set) Token: 0x0600A32F RID: 41775 RVA: 0x000F1611 File Offset: 0x000EF811
		public FTimespan TimeDelay
		{
			get
			{
				base.FastCheckIsValid();
				FTimespan result;
				if ((result = this._TimeDelay) == null)
				{
					result = (this._TimeDelay = new FTimespan(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_TimeDelay, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FTimespan.StaticStruct(), base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_TimeDelay, value.NativePtr, 1, false);
			}
		}

		// Token: 0x17001E56 RID: 7766
		// (get) Token: 0x0600A330 RID: 41776 RVA: 0x000F1632 File Offset: 0x000EF832
		// (set) Token: 0x0600A331 RID: 41777 RVA: 0x000F1642 File Offset: 0x000EF842
		public unsafe float HorizontalFieldOfView
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_HorizontalFieldOfView);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_HorizontalFieldOfView) = value;
			}
		}

		// Token: 0x17001E57 RID: 7767
		// (get) Token: 0x0600A332 RID: 41778 RVA: 0x000F1653 File Offset: 0x000EF853
		// (set) Token: 0x0600A333 RID: 41779 RVA: 0x000F1663 File Offset: 0x000EF863
		public unsafe float VerticalFieldOfView
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_VerticalFieldOfView);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_VerticalFieldOfView) = value;
			}
		}

		// Token: 0x17001E58 RID: 7768
		// (get) Token: 0x0600A334 RID: 41780 RVA: 0x000F1674 File Offset: 0x000EF874
		// (set) Token: 0x0600A335 RID: 41781 RVA: 0x000F1688 File Offset: 0x000EF888
		public unsafe FRotator ViewRotation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_ViewRotation);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_ViewRotation) = value;
			}
		}

		// Token: 0x17001E59 RID: 7769
		// (get) Token: 0x0600A336 RID: 41782 RVA: 0x000F169D File Offset: 0x000EF89D
		// (set) Token: 0x0600A337 RID: 41783 RVA: 0x000F16B1 File Offset: 0x000EF8B1
		public unsafe FGuid PlayerGuid
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_PlayerGuid);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMediaPlayer.__PropertyOffset_PlayerGuid) = value;
			}
		}

		// Token: 0x0600A338 RID: 41784 RVA: 0x000F16C6 File Offset: 0x000EF8C6
		public bool SupportsSeeking()
		{
			return UMediaPlayer.__SupportsSeeking_Internal(base.NativePtr);
		}

		// Token: 0x0600A339 RID: 41785 RVA: 0x000F16D3 File Offset: 0x000EF8D3
		public bool SupportsScrubbing()
		{
			return UMediaPlayer.__SupportsScrubbing_Internal(base.NativePtr);
		}

		// Token: 0x0600A33A RID: 41786 RVA: 0x000F16E0 File Offset: 0x000EF8E0
		public bool SupportsRate(float Rate, bool Unthinned)
		{
			return UMediaPlayer.__SupportsRate_Internal(base.NativePtr, Rate, Unthinned);
		}

		// Token: 0x0600A33B RID: 41787 RVA: 0x000F16EF File Offset: 0x000EF8EF
		public bool SetViewRotation(in FRotator Rotation, bool Absolute)
		{
			return UMediaPlayer.__SetViewRotation_Internal(base.NativePtr, Rotation, Absolute);
		}

		// Token: 0x0600A33C RID: 41788 RVA: 0x000F16FE File Offset: 0x000EF8FE
		public bool SetViewField(float Horizontal, float Vertical, bool Absolute)
		{
			return UMediaPlayer.__SetViewField_Internal(base.NativePtr, Horizontal, Vertical, Absolute);
		}

		// Token: 0x0600A33D RID: 41789 RVA: 0x000F170E File Offset: 0x000EF90E
		public bool SetVideoTrackFrameRate(int TrackIndex, int FormatIndex, float FrameRate)
		{
			return UMediaPlayer.__SetVideoTrackFrameRate_Internal(base.NativePtr, TrackIndex, FormatIndex, FrameRate);
		}

		// Token: 0x0600A33E RID: 41790 RVA: 0x000F171E File Offset: 0x000EF91E
		[NullableContext(2)]
		public void SetTimeDelay(FTimespan TimeDelay)
		{
			UMediaPlayer.__SetTimeDelay_Internal(base.NativePtr, (TimeDelay ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600A33F RID: 41791 RVA: 0x000F173A File Offset: 0x000EF93A
		public bool SetRate(float Rate)
		{
			return UMediaPlayer.__SetRate_Internal(base.NativePtr, Rate);
		}

		// Token: 0x0600A340 RID: 41792 RVA: 0x000F1748 File Offset: 0x000EF948
		public bool SetNativeVolume(float Volume)
		{
			return UMediaPlayer.__SetNativeVolume_Internal(base.NativePtr, Volume);
		}

		// Token: 0x0600A341 RID: 41793 RVA: 0x000F1756 File Offset: 0x000EF956
		[NullableContext(2)]
		public void SetMediaOptions(UMediaSource Options)
		{
			UMediaPlayer.__SetMediaOptions_Internal(base.NativePtr, (Options != null) ? Options.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A342 RID: 41794 RVA: 0x000F1773 File Offset: 0x000EF973
		public bool SetLooping(bool Looping)
		{
			return UMediaPlayer.__SetLooping_Internal(base.NativePtr, Looping);
		}

		// Token: 0x0600A343 RID: 41795 RVA: 0x000F1781 File Offset: 0x000EF981
		public void SetDesiredPlayerName(FName PlayerName)
		{
			UMediaPlayer.__SetDesiredPlayerName_Internal(base.NativePtr, PlayerName);
		}

		// Token: 0x0600A344 RID: 41796 RVA: 0x000F178F File Offset: 0x000EF98F
		[NullableContext(2)]
		public void SetBlockOnTime(in FTimespan Time)
		{
			UMediaPlayer.__SetBlockOnTime_Internal(base.NativePtr, (Time ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600A345 RID: 41797 RVA: 0x000F17AC File Offset: 0x000EF9AC
		[NullableContext(2)]
		public bool Seek(in FTimespan Time)
		{
			return UMediaPlayer.__Seek_Internal(base.NativePtr, (Time ?? new FTimespan()).NativePtr);
		}

		// Token: 0x0600A346 RID: 41798 RVA: 0x000F17C9 File Offset: 0x000EF9C9
		public bool Rewind()
		{
			return UMediaPlayer.__Rewind_Internal(base.NativePtr);
		}

		// Token: 0x0600A347 RID: 41799 RVA: 0x000F17D6 File Offset: 0x000EF9D6
		public bool Reopen()
		{
			return UMediaPlayer.__Reopen_Internal(base.NativePtr);
		}

		// Token: 0x0600A348 RID: 41800 RVA: 0x000F17E3 File Offset: 0x000EF9E3
		public bool Previous()
		{
			return UMediaPlayer.__Previous_Internal(base.NativePtr);
		}

		// Token: 0x0600A349 RID: 41801 RVA: 0x000F17F0 File Offset: 0x000EF9F0
		public void PlayAndSeek()
		{
			UMediaPlayer.__PlayAndSeek_Internal(base.NativePtr);
		}

		// Token: 0x0600A34A RID: 41802 RVA: 0x000F17FD File Offset: 0x000EF9FD
		public bool Play()
		{
			return UMediaPlayer.__Play_Internal(base.NativePtr);
		}

		// Token: 0x0600A34B RID: 41803 RVA: 0x000F180A File Offset: 0x000EFA0A
		public bool Pause()
		{
			return UMediaPlayer.__Pause_Internal(base.NativePtr);
		}

		// Token: 0x0600A34C RID: 41804 RVA: 0x000F1818 File Offset: 0x000EFA18
		public unsafe bool OpenUrl(string Url)
		{
			FString fstring = FString.AllocTemp(Url);
			bool result = UMediaPlayer.__OpenUrl_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600A34D RID: 41805 RVA: 0x000F1842 File Offset: 0x000EFA42
		[NullableContext(2)]
		public bool OpenSource(UMediaSource MediaSource)
		{
			return UMediaPlayer.__OpenSource_Internal(base.NativePtr, (MediaSource != null) ? MediaSource.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A34E RID: 41806 RVA: 0x000F1860 File Offset: 0x000EFA60
		public unsafe bool OpenFile(string FilePath)
		{
			FString fstring = FString.AllocTemp(FilePath);
			bool result = UMediaPlayer.__OpenFile_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600A34F RID: 41807 RVA: 0x000F188A File Offset: 0x000EFA8A
		public bool Next()
		{
			return UMediaPlayer.__Next_Internal(base.NativePtr);
		}

		// Token: 0x0600A350 RID: 41808 RVA: 0x000F1897 File Offset: 0x000EFA97
		public bool IsReady()
		{
			return UMediaPlayer.__IsReady_Internal(base.NativePtr);
		}

		// Token: 0x0600A351 RID: 41809 RVA: 0x000F18A4 File Offset: 0x000EFAA4
		public bool IsPreparing()
		{
			return UMediaPlayer.__IsPreparing_Internal(base.NativePtr);
		}

		// Token: 0x0600A352 RID: 41810 RVA: 0x000F18B1 File Offset: 0x000EFAB1
		public bool IsPlaying()
		{
			return UMediaPlayer.__IsPlaying_Internal(base.NativePtr);
		}

		// Token: 0x0600A353 RID: 41811 RVA: 0x000F18BE File Offset: 0x000EFABE
		public bool IsPaused()
		{
			return UMediaPlayer.__IsPaused_Internal(base.NativePtr);
		}

		// Token: 0x0600A354 RID: 41812 RVA: 0x000F18CB File Offset: 0x000EFACB
		public bool IsLooping()
		{
			return UMediaPlayer.__IsLooping_Internal(base.NativePtr);
		}

		// Token: 0x0600A355 RID: 41813 RVA: 0x000F18D8 File Offset: 0x000EFAD8
		public bool IsInAsync()
		{
			return UMediaPlayer.__IsInAsync_Internal(base.NativePtr);
		}

		// Token: 0x0600A356 RID: 41814 RVA: 0x000F18E5 File Offset: 0x000EFAE5
		public bool IsConnecting()
		{
			return UMediaPlayer.__IsConnecting_Internal(base.NativePtr);
		}

		// Token: 0x0600A357 RID: 41815 RVA: 0x000F18F2 File Offset: 0x000EFAF2
		public bool IsClosed()
		{
			return UMediaPlayer.__IsClosed_Internal(base.NativePtr);
		}

		// Token: 0x0600A358 RID: 41816 RVA: 0x000F18FF File Offset: 0x000EFAFF
		public bool IsBuffering()
		{
			return UMediaPlayer.__IsBuffering_Internal(base.NativePtr);
		}

		// Token: 0x0600A359 RID: 41817 RVA: 0x000F190C File Offset: 0x000EFB0C
		public bool HasError()
		{
			return UMediaPlayer.__HasError_Internal(base.NativePtr);
		}

		// Token: 0x0600A35A RID: 41818 RVA: 0x000F1919 File Offset: 0x000EFB19
		public FRotator GetViewRotation()
		{
			return UMediaPlayer.__GetViewRotation_Internal(base.NativePtr);
		}

		// Token: 0x0600A35B RID: 41819 RVA: 0x000F1926 File Offset: 0x000EFB26
		public string GetVideoTrackType(int TrackIndex, int FormatIndex)
		{
			return FString.ToStringAndDeleteNativePtr(UMediaPlayer.__GetVideoTrackType_Internal(base.NativePtr, TrackIndex, FormatIndex));
		}

		// Token: 0x0600A35C RID: 41820 RVA: 0x000F193A File Offset: 0x000EFB3A
		public FFloatRange GetVideoTrackFrameRates(int TrackIndex, int FormatIndex)
		{
			return UMediaPlayer.__GetVideoTrackFrameRates_Internal(base.NativePtr, TrackIndex, FormatIndex);
		}

		// Token: 0x0600A35D RID: 41821 RVA: 0x000F1949 File Offset: 0x000EFB49
		public float GetVideoTrackFrameRate(int TrackIndex, int FormatIndex)
		{
			return UMediaPlayer.__GetVideoTrackFrameRate_Internal(base.NativePtr, TrackIndex, FormatIndex);
		}

		// Token: 0x0600A35E RID: 41822 RVA: 0x000F1958 File Offset: 0x000EFB58
		public FIntPoint GetVideoTrackDimensions(int TrackIndex, int FormatIndex)
		{
			return UMediaPlayer.__GetVideoTrackDimensions_Internal(base.NativePtr, TrackIndex, FormatIndex);
		}

		// Token: 0x0600A35F RID: 41823 RVA: 0x000F1967 File Offset: 0x000EFB67
		public float GetVideoTrackAspectRatio(int TrackIndex, int FormatIndex)
		{
			return UMediaPlayer.__GetVideoTrackAspectRatio_Internal(base.NativePtr, TrackIndex, FormatIndex);
		}

		// Token: 0x0600A360 RID: 41824 RVA: 0x000F1976 File Offset: 0x000EFB76
		public float GetVerticalFieldOfView()
		{
			return UMediaPlayer.__GetVerticalFieldOfView_Internal(base.NativePtr);
		}

		// Token: 0x0600A361 RID: 41825 RVA: 0x000F1983 File Offset: 0x000EFB83
		public string GetUrl()
		{
			return FString.ToStringAndDeleteNativePtr(UMediaPlayer.__GetUrl_Internal(base.NativePtr));
		}

		// Token: 0x0600A362 RID: 41826 RVA: 0x000F1995 File Offset: 0x000EFB95
		public FTimespan GetTimeDelay()
		{
			return new FTimespan(UMediaPlayer.__GetTimeDelay_Internal(base.NativePtr), null);
		}

		// Token: 0x0600A363 RID: 41827 RVA: 0x000F19A8 File Offset: 0x000EFBA8
		public FTimespan GetTime()
		{
			return new FTimespan(UMediaPlayer.__GetTime_Internal(base.NativePtr), null);
		}

		// Token: 0x0600A364 RID: 41828 RVA: 0x000F19BB File Offset: 0x000EFBBB
		[NullableContext(2)]
		public void GetSupportedRates(ref TArray<FFloatRange> OutRates, bool Unthinned)
		{
			UMediaPlayer.__GetSupportedRates_Internal(base.NativePtr, (OutRates ?? new TArray<FFloatRange>()).NativePtr, Unthinned);
		}

		// Token: 0x0600A365 RID: 41829 RVA: 0x000F19D9 File Offset: 0x000EFBD9
		public float GetRate()
		{
			return UMediaPlayer.__GetRate_Internal(base.NativePtr);
		}

		// Token: 0x0600A366 RID: 41830 RVA: 0x000F19E6 File Offset: 0x000EFBE6
		public int GetPlaylistIndex()
		{
			return UMediaPlayer.__GetPlaylistIndex_Internal(base.NativePtr);
		}

		// Token: 0x0600A367 RID: 41831 RVA: 0x000F19F3 File Offset: 0x000EFBF3
		public FName GetPlayerName()
		{
			return UMediaPlayer.__GetPlayerName_Internal(base.NativePtr);
		}

		// Token: 0x0600A368 RID: 41832 RVA: 0x000F1A00 File Offset: 0x000EFC00
		public FText GetMediaName()
		{
			return new FText(UMediaPlayer.__GetMediaName_Internal(base.NativePtr), null);
		}

		// Token: 0x0600A369 RID: 41833 RVA: 0x000F1A13 File Offset: 0x000EFC13
		public float GetHorizontalFieldOfView()
		{
			return UMediaPlayer.__GetHorizontalFieldOfView_Internal(base.NativePtr);
		}

		// Token: 0x0600A36A RID: 41834 RVA: 0x000F1A20 File Offset: 0x000EFC20
		public FTimespan GetDuration()
		{
			return new FTimespan(UMediaPlayer.__GetDuration_Internal(base.NativePtr), null);
		}

		// Token: 0x0600A36B RID: 41835 RVA: 0x000F1A33 File Offset: 0x000EFC33
		public FName GetDesiredPlayerName()
		{
			return UMediaPlayer.__GetDesiredPlayerName_Internal(base.NativePtr);
		}

		// Token: 0x0600A36C RID: 41836 RVA: 0x000F1A40 File Offset: 0x000EFC40
		public string GetAudioTrackType(int TrackIndex, int FormatIndex)
		{
			return FString.ToStringAndDeleteNativePtr(UMediaPlayer.__GetAudioTrackType_Internal(base.NativePtr, TrackIndex, FormatIndex));
		}

		// Token: 0x0600A36D RID: 41837 RVA: 0x000F1A54 File Offset: 0x000EFC54
		public int GetAudioTrackSampleRate(int TrackIndex, int FormatIndex)
		{
			return UMediaPlayer.__GetAudioTrackSampleRate_Internal(base.NativePtr, TrackIndex, FormatIndex);
		}

		// Token: 0x0600A36E RID: 41838 RVA: 0x000F1A63 File Offset: 0x000EFC63
		public int GetAudioTrackChannels(int TrackIndex, int FormatIndex)
		{
			return UMediaPlayer.__GetAudioTrackChannels_Internal(base.NativePtr, TrackIndex, FormatIndex);
		}

		// Token: 0x0600A36F RID: 41839 RVA: 0x000F1A72 File Offset: 0x000EFC72
		public void Close()
		{
			UMediaPlayer.__Close_Internal(base.NativePtr);
		}

		// Token: 0x0600A370 RID: 41840 RVA: 0x000F1A80 File Offset: 0x000EFC80
		public unsafe bool CanPlayUrl(string Url)
		{
			FString fstring = FString.AllocTemp(Url);
			bool result = UMediaPlayer.__CanPlayUrl_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x0600A371 RID: 41841 RVA: 0x000F1AAA File Offset: 0x000EFCAA
		[NullableContext(2)]
		public bool CanPlaySource(UMediaSource MediaSource)
		{
			return UMediaPlayer.__CanPlaySource_Internal(base.NativePtr, (MediaSource != null) ? MediaSource.NativePtr : IntPtr.Zero);
		}

		// Token: 0x0600A372 RID: 41842 RVA: 0x000F1AC7 File Offset: 0x000EFCC7
		public bool CanPause()
		{
			return UMediaPlayer.__CanPause_Internal(base.NativePtr);
		}

		// Token: 0x0600A373 RID: 41843 RVA: 0x000F1AD4 File Offset: 0x000EFCD4
		public void AsyncClose()
		{
			UMediaPlayer.__AsyncClose_Internal(base.NativePtr);
		}

		// Token: 0x0600A374 RID: 41844
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SupportsSeeking_Internal(IntPtr @this);

		// Token: 0x0600A375 RID: 41845
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SupportsScrubbing_Internal(IntPtr @this);

		// Token: 0x0600A376 RID: 41846
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SupportsRate_Internal(IntPtr @this, float Rate, bool Unthinned);

		// Token: 0x0600A377 RID: 41847
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetViewRotation_Internal(IntPtr @this, in FRotator Rotation, bool Absolute);

		// Token: 0x0600A378 RID: 41848
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetViewField_Internal(IntPtr @this, float Horizontal, float Vertical, bool Absolute);

		// Token: 0x0600A379 RID: 41849
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetVideoTrackFrameRate_Internal(IntPtr @this, int TrackIndex, int FormatIndex, float FrameRate);

		// Token: 0x0600A37A RID: 41850
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTimeDelay_Internal(IntPtr @this, IntPtr TimeDelay);

		// Token: 0x0600A37B RID: 41851
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetRate_Internal(IntPtr @this, float Rate);

		// Token: 0x0600A37C RID: 41852
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetNativeVolume_Internal(IntPtr @this, float Volume);

		// Token: 0x0600A37D RID: 41853
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMediaOptions_Internal(IntPtr @this, IntPtr Options);

		// Token: 0x0600A37E RID: 41854
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetLooping_Internal(IntPtr @this, bool Looping);

		// Token: 0x0600A37F RID: 41855
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDesiredPlayerName_Internal(IntPtr @this, FName PlayerName);

		// Token: 0x0600A380 RID: 41856
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBlockOnTime_Internal(IntPtr @this, IntPtr Time);

		// Token: 0x0600A381 RID: 41857
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Seek_Internal(IntPtr @this, IntPtr Time);

		// Token: 0x0600A382 RID: 41858
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Rewind_Internal(IntPtr @this);

		// Token: 0x0600A383 RID: 41859
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Reopen_Internal(IntPtr @this);

		// Token: 0x0600A384 RID: 41860
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Previous_Internal(IntPtr @this);

		// Token: 0x0600A385 RID: 41861
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayAndSeek_Internal(IntPtr @this);

		// Token: 0x0600A386 RID: 41862
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Play_Internal(IntPtr @this);

		// Token: 0x0600A387 RID: 41863
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Pause_Internal(IntPtr @this);

		// Token: 0x0600A388 RID: 41864
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OpenUrl_Internal(IntPtr @this, in FString Url);

		// Token: 0x0600A389 RID: 41865
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OpenSource_Internal(IntPtr @this, IntPtr MediaSource);

		// Token: 0x0600A38A RID: 41866
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OpenFile_Internal(IntPtr @this, in FString FilePath);

		// Token: 0x0600A38B RID: 41867
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Next_Internal(IntPtr @this);

		// Token: 0x0600A38C RID: 41868
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsReady_Internal(IntPtr @this);

		// Token: 0x0600A38D RID: 41869
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPreparing_Internal(IntPtr @this);

		// Token: 0x0600A38E RID: 41870
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlaying_Internal(IntPtr @this);

		// Token: 0x0600A38F RID: 41871
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPaused_Internal(IntPtr @this);

		// Token: 0x0600A390 RID: 41872
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLooping_Internal(IntPtr @this);

		// Token: 0x0600A391 RID: 41873
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInAsync_Internal(IntPtr @this);

		// Token: 0x0600A392 RID: 41874
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsConnecting_Internal(IntPtr @this);

		// Token: 0x0600A393 RID: 41875
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsClosed_Internal(IntPtr @this);

		// Token: 0x0600A394 RID: 41876
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsBuffering_Internal(IntPtr @this);

		// Token: 0x0600A395 RID: 41877
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasError_Internal(IntPtr @this);

		// Token: 0x0600A396 RID: 41878
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetViewRotation_Internal(IntPtr @this);

		// Token: 0x0600A397 RID: 41879
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetVideoTrackType_Internal(IntPtr @this, int TrackIndex, int FormatIndex);

		// Token: 0x0600A398 RID: 41880
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FFloatRange __GetVideoTrackFrameRates_Internal(IntPtr @this, int TrackIndex, int FormatIndex);

		// Token: 0x0600A399 RID: 41881
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetVideoTrackFrameRate_Internal(IntPtr @this, int TrackIndex, int FormatIndex);

		// Token: 0x0600A39A RID: 41882
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint __GetVideoTrackDimensions_Internal(IntPtr @this, int TrackIndex, int FormatIndex);

		// Token: 0x0600A39B RID: 41883
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetVideoTrackAspectRatio_Internal(IntPtr @this, int TrackIndex, int FormatIndex);

		// Token: 0x0600A39C RID: 41884
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetVerticalFieldOfView_Internal(IntPtr @this);

		// Token: 0x0600A39D RID: 41885
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetUrl_Internal(IntPtr @this);

		// Token: 0x0600A39E RID: 41886
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTimeDelay_Internal(IntPtr @this);

		// Token: 0x0600A39F RID: 41887
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTime_Internal(IntPtr @this);

		// Token: 0x0600A3A0 RID: 41888
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetSupportedRates_Internal(IntPtr @this, IntPtr OutRates, bool Unthinned);

		// Token: 0x0600A3A1 RID: 41889
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRate_Internal(IntPtr @this);

		// Token: 0x0600A3A2 RID: 41890
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetPlaylistIndex_Internal(IntPtr @this);

		// Token: 0x0600A3A3 RID: 41891
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetPlayerName_Internal(IntPtr @this);

		// Token: 0x0600A3A4 RID: 41892
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMediaName_Internal(IntPtr @this);

		// Token: 0x0600A3A5 RID: 41893
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetHorizontalFieldOfView_Internal(IntPtr @this);

		// Token: 0x0600A3A6 RID: 41894
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDuration_Internal(IntPtr @this);

		// Token: 0x0600A3A7 RID: 41895
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetDesiredPlayerName_Internal(IntPtr @this);

		// Token: 0x0600A3A8 RID: 41896
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAudioTrackType_Internal(IntPtr @this, int TrackIndex, int FormatIndex);

		// Token: 0x0600A3A9 RID: 41897
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetAudioTrackSampleRate_Internal(IntPtr @this, int TrackIndex, int FormatIndex);

		// Token: 0x0600A3AA RID: 41898
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetAudioTrackChannels_Internal(IntPtr @this, int TrackIndex, int FormatIndex);

		// Token: 0x0600A3AB RID: 41899
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Close_Internal(IntPtr @this);

		// Token: 0x0600A3AC RID: 41900
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanPlayUrl_Internal(IntPtr @this, in FString Url);

		// Token: 0x0600A3AD RID: 41901
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanPlaySource_Internal(IntPtr @this, IntPtr MediaSource);

		// Token: 0x0600A3AE RID: 41902
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanPause_Internal(IntPtr @this);

		// Token: 0x0600A3AF RID: 41903
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AsyncClose_Internal(IntPtr @this);

		// Token: 0x0600A3B0 RID: 41904 RVA: 0x000F1AE1 File Offset: 0x000EFCE1
		static UMediaPlayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MediaAssets.MediaPlayer");
		}

		// Token: 0x0600A3B1 RID: 41905 RVA: 0x000F1AEF File Offset: 0x000EFCEF
		protected UMediaPlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040045B5 RID: 17845
		public new const string __ObjectPath = "/Script/MediaAssets.MediaPlayer";

		// Token: 0x040045B6 RID: 17846
		private static IntPtr _ClassPtr;

		// Token: 0x040045B7 RID: 17847
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x040045B8 RID: 17848
		internal static int __PropertyOffset_OnEndReached;

		// Token: 0x040045B9 RID: 17849
		[Nullable(2)]
		private FOnMediaPlayerMediaEvent _OnEndReached;

		// Token: 0x040045BA RID: 17850
		internal static int __PropertyOffset_OnMediaClosed;

		// Token: 0x040045BB RID: 17851
		[Nullable(2)]
		private FOnMediaPlayerMediaEvent _OnMediaClosed;

		// Token: 0x040045BC RID: 17852
		internal static int __PropertyOffset_OnMediaOpened;

		// Token: 0x040045BD RID: 17853
		[Nullable(2)]
		private FOnMediaPlayerMediaOpened _OnMediaOpened;

		// Token: 0x040045BE RID: 17854
		internal static int __PropertyOffset_OnMediaOpenFailed;

		// Token: 0x040045BF RID: 17855
		[Nullable(2)]
		private FOnMediaPlayerMediaOpenFailed _OnMediaOpenFailed;

		// Token: 0x040045C0 RID: 17856
		internal static int __PropertyOffset_OnPlaybackResumed;

		// Token: 0x040045C1 RID: 17857
		[Nullable(2)]
		private FOnMediaPlayerMediaEvent _OnPlaybackResumed;

		// Token: 0x040045C2 RID: 17858
		internal static int __PropertyOffset_OnPlaybackSuspended;

		// Token: 0x040045C3 RID: 17859
		[Nullable(2)]
		private FOnMediaPlayerMediaEvent _OnPlaybackSuspended;

		// Token: 0x040045C4 RID: 17860
		internal static int __PropertyOffset_OnSeekCompleted;

		// Token: 0x040045C5 RID: 17861
		[Nullable(2)]
		private FOnMediaPlayerMediaEvent _OnSeekCompleted;

		// Token: 0x040045C6 RID: 17862
		internal static int __PropertyOffset_OnTracksChanged;

		// Token: 0x040045C7 RID: 17863
		[Nullable(2)]
		private FOnMediaPlayerMediaEvent _OnTracksChanged;

		// Token: 0x040045C8 RID: 17864
		internal static int __PropertyOffset_CacheAhead;

		// Token: 0x040045C9 RID: 17865
		[Nullable(2)]
		private FTimespan _CacheAhead;

		// Token: 0x040045CA RID: 17866
		internal static int __PropertyOffset_CacheBehind;

		// Token: 0x040045CB RID: 17867
		[Nullable(2)]
		private FTimespan _CacheBehind;

		// Token: 0x040045CC RID: 17868
		internal static int __PropertyOffset_CacheBehindGame;

		// Token: 0x040045CD RID: 17869
		[Nullable(2)]
		private FTimespan _CacheBehindGame;

		// Token: 0x040045CE RID: 17870
		internal static int __PropertyOffset_NativeAudioOut;

		// Token: 0x040045CF RID: 17871
		internal static int __PropertyOffset_PlayOnOpen;

		// Token: 0x040045D0 RID: 17872
		internal static int __PropertyOffset_Shuffle;

		// Token: 0x040045D1 RID: 17873
		internal static byte __PropertyMask_Shuffle;

		// Token: 0x040045D2 RID: 17874
		internal static int __PropertyOffset_Loop;

		// Token: 0x040045D3 RID: 17875
		internal static byte __PropertyMask_Loop;

		// Token: 0x040045D4 RID: 17876
		internal static int __PropertyOffset_PlaylistIndex;

		// Token: 0x040045D5 RID: 17877
		internal static int __PropertyOffset_TimeDelay;

		// Token: 0x040045D6 RID: 17878
		[Nullable(2)]
		private FTimespan _TimeDelay;

		// Token: 0x040045D7 RID: 17879
		internal static int __PropertyOffset_HorizontalFieldOfView;

		// Token: 0x040045D8 RID: 17880
		internal static int __PropertyOffset_VerticalFieldOfView;

		// Token: 0x040045D9 RID: 17881
		internal static int __PropertyOffset_ViewRotation;

		// Token: 0x040045DA RID: 17882
		internal static int __PropertyOffset_PlayerGuid;
	}
}
