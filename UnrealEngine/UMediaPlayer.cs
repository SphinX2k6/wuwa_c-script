using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002297 RID: 8855
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MediaAssets.MediaPlayer")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UMediaPlayer : UObject, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06021A29 RID: 137769 RVA: 0x0031C370 File Offset: 0x0031A570
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMediaPlayer._ClassPtr;
		}

		// Token: 0x06021A2A RID: 137770 RVA: 0x0031C37C File Offset: 0x0031A57C
		public UMediaPlayer() : this(BuiltinUtils.AllocNativeUObject(UMediaPlayer.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021A2B RID: 137771 RVA: 0x0031C3A4 File Offset: 0x0031A5A4
		public UMediaPlayer(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMediaPlayer.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170082A9 RID: 33449
		// (get) Token: 0x06021A2C RID: 137772 RVA: 0x0031C3D8 File Offset: 0x0031A5D8
		// (set) Token: 0x06021A2D RID: 137773 RVA: 0x0031C411 File Offset: 0x0031A611
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

		// Token: 0x170082AA RID: 33450
		// (get) Token: 0x06021A2E RID: 137774 RVA: 0x0031C434 File Offset: 0x0031A634
		// (set) Token: 0x06021A2F RID: 137775 RVA: 0x0031C46D File Offset: 0x0031A66D
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

		// Token: 0x170082AB RID: 33451
		// (get) Token: 0x06021A30 RID: 137776 RVA: 0x0031C490 File Offset: 0x0031A690
		// (set) Token: 0x06021A31 RID: 137777 RVA: 0x0031C4C9 File Offset: 0x0031A6C9
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

		// Token: 0x170082AC RID: 33452
		// (get) Token: 0x06021A32 RID: 137778 RVA: 0x0031C4EC File Offset: 0x0031A6EC
		// (set) Token: 0x06021A33 RID: 137779 RVA: 0x0031C525 File Offset: 0x0031A725
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

		// Token: 0x170082AD RID: 33453
		// (get) Token: 0x06021A34 RID: 137780 RVA: 0x0031C548 File Offset: 0x0031A748
		// (set) Token: 0x06021A35 RID: 137781 RVA: 0x0031C581 File Offset: 0x0031A781
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

		// Token: 0x170082AE RID: 33454
		// (get) Token: 0x06021A36 RID: 137782 RVA: 0x0031C5A4 File Offset: 0x0031A7A4
		// (set) Token: 0x06021A37 RID: 137783 RVA: 0x0031C5DD File Offset: 0x0031A7DD
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

		// Token: 0x170082AF RID: 33455
		// (get) Token: 0x06021A38 RID: 137784 RVA: 0x0031C600 File Offset: 0x0031A800
		// (set) Token: 0x06021A39 RID: 137785 RVA: 0x0031C639 File Offset: 0x0031A839
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

		// Token: 0x170082B0 RID: 33456
		// (get) Token: 0x06021A3A RID: 137786 RVA: 0x0031C65C File Offset: 0x0031A85C
		// (set) Token: 0x06021A3B RID: 137787 RVA: 0x0031C695 File Offset: 0x0031A895
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

		// Token: 0x170082B1 RID: 33457
		// (get) Token: 0x06021A3C RID: 137788 RVA: 0x0031C6B8 File Offset: 0x0031A8B8
		// (set) Token: 0x06021A3D RID: 137789 RVA: 0x0031C6F1 File Offset: 0x0031A8F1
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

		// Token: 0x170082B2 RID: 33458
		// (get) Token: 0x06021A3E RID: 137790 RVA: 0x0031C714 File Offset: 0x0031A914
		// (set) Token: 0x06021A3F RID: 137791 RVA: 0x0031C74D File Offset: 0x0031A94D
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

		// Token: 0x170082B3 RID: 33459
		// (get) Token: 0x06021A40 RID: 137792 RVA: 0x0031C770 File Offset: 0x0031A970
		// (set) Token: 0x06021A41 RID: 137793 RVA: 0x0031C7A9 File Offset: 0x0031A9A9
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

		// Token: 0x170082B4 RID: 33460
		// (get) Token: 0x06021A42 RID: 137794 RVA: 0x0031C7CA File Offset: 0x0031A9CA
		// (set) Token: 0x06021A43 RID: 137795 RVA: 0x0031C7DA File Offset: 0x0031A9DA
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

		// Token: 0x170082B5 RID: 33461
		// (get) Token: 0x06021A44 RID: 137796 RVA: 0x0031C7EB File Offset: 0x0031A9EB
		// (set) Token: 0x06021A45 RID: 137797 RVA: 0x0031C7FB File Offset: 0x0031A9FB
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

		// Token: 0x170082B6 RID: 33462
		// (get) Token: 0x06021A46 RID: 137798 RVA: 0x0031C80C File Offset: 0x0031AA0C
		// (set) Token: 0x06021A47 RID: 137799 RVA: 0x0031C825 File Offset: 0x0031AA25
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

		// Token: 0x170082B7 RID: 33463
		// (get) Token: 0x06021A48 RID: 137800 RVA: 0x0031C855 File Offset: 0x0031AA55
		// (set) Token: 0x06021A49 RID: 137801 RVA: 0x0031C86E File Offset: 0x0031AA6E
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

		// Token: 0x170082B8 RID: 33464
		// (get) Token: 0x06021A4A RID: 137802 RVA: 0x0031C89E File Offset: 0x0031AA9E
		// (set) Token: 0x06021A4B RID: 137803 RVA: 0x0031C8B2 File Offset: 0x0031AAB2
		[Nullable(2)]
		public unsafe UMediaPlaylist Playlist
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UMediaPlaylist>(base.NativePtr / (IntPtr)sizeof(void*) + UMediaPlayer.__PropertyOffset_Playlist);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMediaPlayer.__PropertyOffset_Playlist, value);
			}
		}

		// Token: 0x170082B9 RID: 33465
		// (get) Token: 0x06021A4C RID: 137804 RVA: 0x0031C8C7 File Offset: 0x0031AAC7
		// (set) Token: 0x06021A4D RID: 137805 RVA: 0x0031C8D7 File Offset: 0x0031AAD7
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

		// Token: 0x170082BA RID: 33466
		// (get) Token: 0x06021A4E RID: 137806 RVA: 0x0031C8E8 File Offset: 0x0031AAE8
		// (set) Token: 0x06021A4F RID: 137807 RVA: 0x0031C921 File Offset: 0x0031AB21
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

		// Token: 0x170082BB RID: 33467
		// (get) Token: 0x06021A50 RID: 137808 RVA: 0x0031C942 File Offset: 0x0031AB42
		// (set) Token: 0x06021A51 RID: 137809 RVA: 0x0031C952 File Offset: 0x0031AB52
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

		// Token: 0x170082BC RID: 33468
		// (get) Token: 0x06021A52 RID: 137810 RVA: 0x0031C963 File Offset: 0x0031AB63
		// (set) Token: 0x06021A53 RID: 137811 RVA: 0x0031C973 File Offset: 0x0031AB73
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

		// Token: 0x170082BD RID: 33469
		// (get) Token: 0x06021A54 RID: 137812 RVA: 0x0031C984 File Offset: 0x0031AB84
		// (set) Token: 0x06021A55 RID: 137813 RVA: 0x0031C998 File Offset: 0x0031AB98
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

		// Token: 0x170082BE RID: 33470
		// (get) Token: 0x06021A56 RID: 137814 RVA: 0x0031C9AD File Offset: 0x0031ABAD
		// (set) Token: 0x06021A57 RID: 137815 RVA: 0x0031C9C1 File Offset: 0x0031ABC1
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

		// Token: 0x06021A58 RID: 137816 RVA: 0x0031C9D6 File Offset: 0x0031ABD6
		public bool SupportsSeeking()
		{
			return UMediaPlayer.__SupportsSeeking_Internal(base.NativePtr);
		}

		// Token: 0x06021A59 RID: 137817 RVA: 0x0031C9E3 File Offset: 0x0031ABE3
		public bool SupportsScrubbing()
		{
			return UMediaPlayer.__SupportsScrubbing_Internal(base.NativePtr);
		}

		// Token: 0x06021A5A RID: 137818 RVA: 0x0031C9F0 File Offset: 0x0031ABF0
		public bool SupportsRate(float Rate, bool Unthinned)
		{
			return UMediaPlayer.__SupportsRate_Internal(base.NativePtr, Rate, Unthinned);
		}

		// Token: 0x06021A5B RID: 137819 RVA: 0x0031C9FF File Offset: 0x0031ABFF
		public bool SetViewRotation(in FRotator Rotation, bool Absolute)
		{
			return UMediaPlayer.__SetViewRotation_Internal(base.NativePtr, Rotation, Absolute);
		}

		// Token: 0x06021A5C RID: 137820 RVA: 0x0031CA0E File Offset: 0x0031AC0E
		public bool SetViewField(float Horizontal, float Vertical, bool Absolute)
		{
			return UMediaPlayer.__SetViewField_Internal(base.NativePtr, Horizontal, Vertical, Absolute);
		}

		// Token: 0x06021A5D RID: 137821 RVA: 0x0031CA1E File Offset: 0x0031AC1E
		public bool SetVideoTrackFrameRate(int TrackIndex, int FormatIndex, float FrameRate)
		{
			return UMediaPlayer.__SetVideoTrackFrameRate_Internal(base.NativePtr, TrackIndex, FormatIndex, FrameRate);
		}

		// Token: 0x06021A5E RID: 137822 RVA: 0x0031CA2E File Offset: 0x0031AC2E
		public bool SetTrackFormat(EMediaPlayerTrack TrackType, int TrackIndex, int FormatIndex)
		{
			return UMediaPlayer.__SetTrackFormat_Internal(base.NativePtr, TrackType, TrackIndex, FormatIndex);
		}

		// Token: 0x06021A5F RID: 137823 RVA: 0x0031CA3E File Offset: 0x0031AC3E
		[NullableContext(2)]
		public void SetTimeDelay(FTimespan TimeDelay)
		{
			UMediaPlayer.__SetTimeDelay_Internal(base.NativePtr, (TimeDelay ?? new FTimespan()).NativePtr);
		}

		// Token: 0x06021A60 RID: 137824 RVA: 0x0031CA5A File Offset: 0x0031AC5A
		public bool SetRate(float Rate)
		{
			return UMediaPlayer.__SetRate_Internal(base.NativePtr, Rate);
		}

		// Token: 0x06021A61 RID: 137825 RVA: 0x0031CA68 File Offset: 0x0031AC68
		public bool SetNativeVolume(float Volume)
		{
			return UMediaPlayer.__SetNativeVolume_Internal(base.NativePtr, Volume);
		}

		// Token: 0x06021A62 RID: 137826 RVA: 0x0031CA76 File Offset: 0x0031AC76
		[NullableContext(2)]
		public void SetMediaOptions(UMediaSource Options)
		{
			UMediaPlayer.__SetMediaOptions_Internal(base.NativePtr, (Options != null) ? Options.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06021A63 RID: 137827 RVA: 0x0031CA93 File Offset: 0x0031AC93
		public bool SetLooping(bool Looping)
		{
			return UMediaPlayer.__SetLooping_Internal(base.NativePtr, Looping);
		}

		// Token: 0x06021A64 RID: 137828 RVA: 0x0031CAA1 File Offset: 0x0031ACA1
		public void SetDesiredPlayerName(FName PlayerName)
		{
			UMediaPlayer.__SetDesiredPlayerName_Internal(base.NativePtr, PlayerName);
		}

		// Token: 0x06021A65 RID: 137829 RVA: 0x0031CAAF File Offset: 0x0031ACAF
		[NullableContext(2)]
		public void SetBlockOnTime(in FTimespan Time)
		{
			UMediaPlayer.__SetBlockOnTime_Internal(base.NativePtr, (Time ?? new FTimespan()).NativePtr);
		}

		// Token: 0x06021A66 RID: 137830 RVA: 0x0031CACC File Offset: 0x0031ACCC
		public bool SelectTrack(EMediaPlayerTrack TrackType, int TrackIndex)
		{
			return UMediaPlayer.__SelectTrack_Internal(base.NativePtr, TrackType, TrackIndex);
		}

		// Token: 0x06021A67 RID: 137831 RVA: 0x0031CADB File Offset: 0x0031ACDB
		[NullableContext(2)]
		public bool Seek(in FTimespan Time)
		{
			return UMediaPlayer.__Seek_Internal(base.NativePtr, (Time ?? new FTimespan()).NativePtr);
		}

		// Token: 0x06021A68 RID: 137832 RVA: 0x0031CAF8 File Offset: 0x0031ACF8
		public bool Rewind()
		{
			return UMediaPlayer.__Rewind_Internal(base.NativePtr);
		}

		// Token: 0x06021A69 RID: 137833 RVA: 0x0031CB05 File Offset: 0x0031AD05
		public bool Reopen()
		{
			return UMediaPlayer.__Reopen_Internal(base.NativePtr);
		}

		// Token: 0x06021A6A RID: 137834 RVA: 0x0031CB12 File Offset: 0x0031AD12
		public bool Previous()
		{
			return UMediaPlayer.__Previous_Internal(base.NativePtr);
		}

		// Token: 0x06021A6B RID: 137835 RVA: 0x0031CB1F File Offset: 0x0031AD1F
		public void PlayAndSeek()
		{
			UMediaPlayer.__PlayAndSeek_Internal(base.NativePtr);
		}

		// Token: 0x06021A6C RID: 137836 RVA: 0x0031CB2C File Offset: 0x0031AD2C
		public bool Play()
		{
			return UMediaPlayer.__Play_Internal(base.NativePtr);
		}

		// Token: 0x06021A6D RID: 137837 RVA: 0x0031CB39 File Offset: 0x0031AD39
		public bool Pause()
		{
			return UMediaPlayer.__Pause_Internal(base.NativePtr);
		}

		// Token: 0x06021A6E RID: 137838 RVA: 0x0031CB48 File Offset: 0x0031AD48
		public unsafe bool OpenUrl(string Url)
		{
			FString fstring = FString.AllocTemp(Url);
			bool result = UMediaPlayer.__OpenUrl_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06021A6F RID: 137839 RVA: 0x0031CB72 File Offset: 0x0031AD72
		[NullableContext(2)]
		public bool OpenSourceWithOptions(UMediaSource MediaSource, in FMediaPlayerOptions Options)
		{
			return UMediaPlayer.__OpenSourceWithOptions_Internal(base.NativePtr, (MediaSource != null) ? MediaSource.NativePtr : IntPtr.Zero, (Options ?? new FMediaPlayerOptions()).NativePtr);
		}

		// Token: 0x06021A70 RID: 137840 RVA: 0x0031CBA0 File Offset: 0x0031ADA0
		[NullableContext(2)]
		public unsafe void OpenSourceLatent(UObject WorldContextObject, FLatentActionInfo LatentInfo, UMediaSource MediaSource, in FMediaPlayerOptions Options, ref bool bSuccess)
		{
			fixed (bool* ptr = &bSuccess)
			{
				void* ptr2 = (void*)ptr;
				UMediaPlayer.__OpenSourceLatent_Internal(base.NativePtr, (WorldContextObject != null) ? WorldContextObject.NativePtr : IntPtr.Zero, (LatentInfo ?? new FLatentActionInfo()).NativePtr, (MediaSource != null) ? MediaSource.NativePtr : IntPtr.Zero, (Options ?? new FMediaPlayerOptions()).NativePtr, ref bSuccess);
			}
		}

		// Token: 0x06021A71 RID: 137841 RVA: 0x0031CC03 File Offset: 0x0031AE03
		[NullableContext(2)]
		public bool OpenSource(UMediaSource MediaSource)
		{
			return UMediaPlayer.__OpenSource_Internal(base.NativePtr, (MediaSource != null) ? MediaSource.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06021A72 RID: 137842 RVA: 0x0031CC20 File Offset: 0x0031AE20
		[NullableContext(2)]
		public bool OpenPlaylistIndex(UMediaPlaylist InPlaylist, int Index)
		{
			return UMediaPlayer.__OpenPlaylistIndex_Internal(base.NativePtr, (InPlaylist != null) ? InPlaylist.NativePtr : IntPtr.Zero, Index);
		}

		// Token: 0x06021A73 RID: 137843 RVA: 0x0031CC3E File Offset: 0x0031AE3E
		[NullableContext(2)]
		public bool OpenPlaylist(UMediaPlaylist InPlaylist)
		{
			return UMediaPlayer.__OpenPlaylist_Internal(base.NativePtr, (InPlaylist != null) ? InPlaylist.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06021A74 RID: 137844 RVA: 0x0031CC5C File Offset: 0x0031AE5C
		public unsafe bool OpenFile(string FilePath)
		{
			FString fstring = FString.AllocTemp(FilePath);
			bool result = UMediaPlayer.__OpenFile_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06021A75 RID: 137845 RVA: 0x0031CC86 File Offset: 0x0031AE86
		public bool Next()
		{
			return UMediaPlayer.__Next_Internal(base.NativePtr);
		}

		// Token: 0x06021A76 RID: 137846 RVA: 0x0031CC93 File Offset: 0x0031AE93
		public bool IsReady()
		{
			return UMediaPlayer.__IsReady_Internal(base.NativePtr);
		}

		// Token: 0x06021A77 RID: 137847 RVA: 0x0031CCA0 File Offset: 0x0031AEA0
		public bool IsPreparing()
		{
			return UMediaPlayer.__IsPreparing_Internal(base.NativePtr);
		}

		// Token: 0x06021A78 RID: 137848 RVA: 0x0031CCAD File Offset: 0x0031AEAD
		public bool IsPlaying()
		{
			return UMediaPlayer.__IsPlaying_Internal(base.NativePtr);
		}

		// Token: 0x06021A79 RID: 137849 RVA: 0x0031CCBA File Offset: 0x0031AEBA
		public bool IsPaused()
		{
			return UMediaPlayer.__IsPaused_Internal(base.NativePtr);
		}

		// Token: 0x06021A7A RID: 137850 RVA: 0x0031CCC7 File Offset: 0x0031AEC7
		public bool IsLooping()
		{
			return UMediaPlayer.__IsLooping_Internal(base.NativePtr);
		}

		// Token: 0x06021A7B RID: 137851 RVA: 0x0031CCD4 File Offset: 0x0031AED4
		public bool IsInAsync()
		{
			return UMediaPlayer.__IsInAsync_Internal(base.NativePtr);
		}

		// Token: 0x06021A7C RID: 137852 RVA: 0x0031CCE1 File Offset: 0x0031AEE1
		public bool IsConnecting()
		{
			return UMediaPlayer.__IsConnecting_Internal(base.NativePtr);
		}

		// Token: 0x06021A7D RID: 137853 RVA: 0x0031CCEE File Offset: 0x0031AEEE
		public bool IsClosed()
		{
			return UMediaPlayer.__IsClosed_Internal(base.NativePtr);
		}

		// Token: 0x06021A7E RID: 137854 RVA: 0x0031CCFB File Offset: 0x0031AEFB
		public bool IsBuffering()
		{
			return UMediaPlayer.__IsBuffering_Internal(base.NativePtr);
		}

		// Token: 0x06021A7F RID: 137855 RVA: 0x0031CD08 File Offset: 0x0031AF08
		public bool HasError()
		{
			return UMediaPlayer.__HasError_Internal(base.NativePtr);
		}

		// Token: 0x06021A80 RID: 137856 RVA: 0x0031CD15 File Offset: 0x0031AF15
		public FRotator GetViewRotation()
		{
			return UMediaPlayer.__GetViewRotation_Internal(base.NativePtr);
		}

		// Token: 0x06021A81 RID: 137857 RVA: 0x0031CD22 File Offset: 0x0031AF22
		public string GetVideoTrackType(int TrackIndex, int FormatIndex)
		{
			return FString.ToStringAndDeleteNativePtr(UMediaPlayer.__GetVideoTrackType_Internal(base.NativePtr, TrackIndex, FormatIndex));
		}

		// Token: 0x06021A82 RID: 137858 RVA: 0x0031CD36 File Offset: 0x0031AF36
		public FFloatRange GetVideoTrackFrameRates(int TrackIndex, int FormatIndex)
		{
			return UMediaPlayer.__GetVideoTrackFrameRates_Internal(base.NativePtr, TrackIndex, FormatIndex);
		}

		// Token: 0x06021A83 RID: 137859 RVA: 0x0031CD45 File Offset: 0x0031AF45
		public float GetVideoTrackFrameRate(int TrackIndex, int FormatIndex)
		{
			return UMediaPlayer.__GetVideoTrackFrameRate_Internal(base.NativePtr, TrackIndex, FormatIndex);
		}

		// Token: 0x06021A84 RID: 137860 RVA: 0x0031CD54 File Offset: 0x0031AF54
		public FIntPoint GetVideoTrackDimensions(int TrackIndex, int FormatIndex)
		{
			return UMediaPlayer.__GetVideoTrackDimensions_Internal(base.NativePtr, TrackIndex, FormatIndex);
		}

		// Token: 0x06021A85 RID: 137861 RVA: 0x0031CD63 File Offset: 0x0031AF63
		public float GetVideoTrackAspectRatio(int TrackIndex, int FormatIndex)
		{
			return UMediaPlayer.__GetVideoTrackAspectRatio_Internal(base.NativePtr, TrackIndex, FormatIndex);
		}

		// Token: 0x06021A86 RID: 137862 RVA: 0x0031CD72 File Offset: 0x0031AF72
		public float GetVerticalFieldOfView()
		{
			return UMediaPlayer.__GetVerticalFieldOfView_Internal(base.NativePtr);
		}

		// Token: 0x06021A87 RID: 137863 RVA: 0x0031CD7F File Offset: 0x0031AF7F
		public string GetUrl()
		{
			return FString.ToStringAndDeleteNativePtr(UMediaPlayer.__GetUrl_Internal(base.NativePtr));
		}

		// Token: 0x06021A88 RID: 137864 RVA: 0x0031CD91 File Offset: 0x0031AF91
		public string GetTrackLanguage(EMediaPlayerTrack TrackType, int TrackIndex)
		{
			return FString.ToStringAndDeleteNativePtr(UMediaPlayer.__GetTrackLanguage_Internal(base.NativePtr, TrackType, TrackIndex));
		}

		// Token: 0x06021A89 RID: 137865 RVA: 0x0031CDA5 File Offset: 0x0031AFA5
		public int GetTrackFormat(EMediaPlayerTrack TrackType, int TrackIndex)
		{
			return UMediaPlayer.__GetTrackFormat_Internal(base.NativePtr, TrackType, TrackIndex);
		}

		// Token: 0x06021A8A RID: 137866 RVA: 0x0031CDB4 File Offset: 0x0031AFB4
		public FText GetTrackDisplayName(EMediaPlayerTrack TrackType, int TrackIndex)
		{
			return new FText(UMediaPlayer.__GetTrackDisplayName_Internal(base.NativePtr, TrackType, TrackIndex), null);
		}

		// Token: 0x06021A8B RID: 137867 RVA: 0x0031CDC9 File Offset: 0x0031AFC9
		[NullableContext(2)]
		public UMediaTimeStampInfo GetTimeStamp()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMediaTimeStampInfo>(UMediaPlayer.__GetTimeStamp_Internal(base.NativePtr));
		}

		// Token: 0x06021A8C RID: 137868 RVA: 0x0031CDDB File Offset: 0x0031AFDB
		public FTimespan GetTimeDelay()
		{
			return new FTimespan(UMediaPlayer.__GetTimeDelay_Internal(base.NativePtr), null);
		}

		// Token: 0x06021A8D RID: 137869 RVA: 0x0031CDEE File Offset: 0x0031AFEE
		public FTimespan GetTime()
		{
			return new FTimespan(UMediaPlayer.__GetTime_Internal(base.NativePtr), null);
		}

		// Token: 0x06021A8E RID: 137870 RVA: 0x0031CE01 File Offset: 0x0031B001
		[NullableContext(2)]
		public void GetSupportedRates(ref TArray<FFloatRange> OutRates, bool Unthinned)
		{
			UMediaPlayer.__GetSupportedRates_Internal(base.NativePtr, (OutRates ?? new TArray<FFloatRange>()).NativePtr, Unthinned);
		}

		// Token: 0x06021A8F RID: 137871 RVA: 0x0031CE1F File Offset: 0x0031B01F
		public int GetSelectedTrack(EMediaPlayerTrack TrackType)
		{
			return UMediaPlayer.__GetSelectedTrack_Internal(base.NativePtr, TrackType);
		}

		// Token: 0x06021A90 RID: 137872 RVA: 0x0031CE2D File Offset: 0x0031B02D
		public float GetRate()
		{
			return UMediaPlayer.__GetRate_Internal(base.NativePtr);
		}

		// Token: 0x06021A91 RID: 137873 RVA: 0x0031CE3A File Offset: 0x0031B03A
		public int GetPlaylistIndex()
		{
			return UMediaPlayer.__GetPlaylistIndex_Internal(base.NativePtr);
		}

		// Token: 0x06021A92 RID: 137874 RVA: 0x0031CE47 File Offset: 0x0031B047
		[NullableContext(2)]
		public UMediaPlaylist GetPlaylist()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<UMediaPlaylist>(UMediaPlayer.__GetPlaylist_Internal(base.NativePtr));
		}

		// Token: 0x06021A93 RID: 137875 RVA: 0x0031CE59 File Offset: 0x0031B059
		public FName GetPlayerName()
		{
			return UMediaPlayer.__GetPlayerName_Internal(base.NativePtr);
		}

		// Token: 0x06021A94 RID: 137876 RVA: 0x0031CE66 File Offset: 0x0031B066
		public int GetNumTracks(EMediaPlayerTrack TrackType)
		{
			return UMediaPlayer.__GetNumTracks_Internal(base.NativePtr, TrackType);
		}

		// Token: 0x06021A95 RID: 137877 RVA: 0x0031CE74 File Offset: 0x0031B074
		public int GetNumTrackFormats(EMediaPlayerTrack TrackType, int TrackIndex)
		{
			return UMediaPlayer.__GetNumTrackFormats_Internal(base.NativePtr, TrackType, TrackIndex);
		}

		// Token: 0x06021A96 RID: 137878 RVA: 0x0031CE83 File Offset: 0x0031B083
		public FText GetMediaName()
		{
			return new FText(UMediaPlayer.__GetMediaName_Internal(base.NativePtr), null);
		}

		// Token: 0x06021A97 RID: 137879 RVA: 0x0031CE96 File Offset: 0x0031B096
		public float GetHorizontalFieldOfView()
		{
			return UMediaPlayer.__GetHorizontalFieldOfView_Internal(base.NativePtr);
		}

		// Token: 0x06021A98 RID: 137880 RVA: 0x0031CEA3 File Offset: 0x0031B0A3
		public FTimespan GetDuration()
		{
			return new FTimespan(UMediaPlayer.__GetDuration_Internal(base.NativePtr), null);
		}

		// Token: 0x06021A99 RID: 137881 RVA: 0x0031CEB6 File Offset: 0x0031B0B6
		public FName GetDesiredPlayerName()
		{
			return UMediaPlayer.__GetDesiredPlayerName_Internal(base.NativePtr);
		}

		// Token: 0x06021A9A RID: 137882 RVA: 0x0031CEC3 File Offset: 0x0031B0C3
		public string GetAudioTrackType(int TrackIndex, int FormatIndex)
		{
			return FString.ToStringAndDeleteNativePtr(UMediaPlayer.__GetAudioTrackType_Internal(base.NativePtr, TrackIndex, FormatIndex));
		}

		// Token: 0x06021A9B RID: 137883 RVA: 0x0031CED7 File Offset: 0x0031B0D7
		public int GetAudioTrackSampleRate(int TrackIndex, int FormatIndex)
		{
			return UMediaPlayer.__GetAudioTrackSampleRate_Internal(base.NativePtr, TrackIndex, FormatIndex);
		}

		// Token: 0x06021A9C RID: 137884 RVA: 0x0031CEE6 File Offset: 0x0031B0E6
		public int GetAudioTrackChannels(int TrackIndex, int FormatIndex)
		{
			return UMediaPlayer.__GetAudioTrackChannels_Internal(base.NativePtr, TrackIndex, FormatIndex);
		}

		// Token: 0x06021A9D RID: 137885 RVA: 0x0031CEF5 File Offset: 0x0031B0F5
		public void Close()
		{
			UMediaPlayer.__Close_Internal(base.NativePtr);
		}

		// Token: 0x06021A9E RID: 137886 RVA: 0x0031CF04 File Offset: 0x0031B104
		public unsafe bool CanPlayUrl(string Url)
		{
			FString fstring = FString.AllocTemp(Url);
			bool result = UMediaPlayer.__CanPlayUrl_Internal(base.NativePtr, fstring);
			FString.NativeDestruct(&fstring, 1);
			return result;
		}

		// Token: 0x06021A9F RID: 137887 RVA: 0x0031CF2E File Offset: 0x0031B12E
		[NullableContext(2)]
		public bool CanPlaySource(UMediaSource MediaSource)
		{
			return UMediaPlayer.__CanPlaySource_Internal(base.NativePtr, (MediaSource != null) ? MediaSource.NativePtr : IntPtr.Zero);
		}

		// Token: 0x06021AA0 RID: 137888 RVA: 0x0031CF4B File Offset: 0x0031B14B
		public bool CanPause()
		{
			return UMediaPlayer.__CanPause_Internal(base.NativePtr);
		}

		// Token: 0x06021AA1 RID: 137889 RVA: 0x0031CF58 File Offset: 0x0031B158
		[NullableContext(2)]
		public bool AsyncOpenSourceWithOptions(UMediaSource MediaSource, in FMediaPlayerOptions Options)
		{
			return UMediaPlayer.__AsyncOpenSourceWithOptions_Internal(base.NativePtr, (MediaSource != null) ? MediaSource.NativePtr : IntPtr.Zero, (Options ?? new FMediaPlayerOptions()).NativePtr);
		}

		// Token: 0x06021AA2 RID: 137890 RVA: 0x0031CF85 File Offset: 0x0031B185
		public void AsyncClose()
		{
			UMediaPlayer.__AsyncClose_Internal(base.NativePtr);
		}

		// Token: 0x06021AA3 RID: 137891
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SupportsSeeking_Internal(IntPtr @this);

		// Token: 0x06021AA4 RID: 137892
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SupportsScrubbing_Internal(IntPtr @this);

		// Token: 0x06021AA5 RID: 137893
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SupportsRate_Internal(IntPtr @this, float Rate, bool Unthinned);

		// Token: 0x06021AA6 RID: 137894
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetViewRotation_Internal(IntPtr @this, in FRotator Rotation, bool Absolute);

		// Token: 0x06021AA7 RID: 137895
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetViewField_Internal(IntPtr @this, float Horizontal, float Vertical, bool Absolute);

		// Token: 0x06021AA8 RID: 137896
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetVideoTrackFrameRate_Internal(IntPtr @this, int TrackIndex, int FormatIndex, float FrameRate);

		// Token: 0x06021AA9 RID: 137897
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetTrackFormat_Internal(IntPtr @this, EMediaPlayerTrack TrackType, int TrackIndex, int FormatIndex);

		// Token: 0x06021AAA RID: 137898
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetTimeDelay_Internal(IntPtr @this, IntPtr TimeDelay);

		// Token: 0x06021AAB RID: 137899
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetRate_Internal(IntPtr @this, float Rate);

		// Token: 0x06021AAC RID: 137900
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetNativeVolume_Internal(IntPtr @this, float Volume);

		// Token: 0x06021AAD RID: 137901
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetMediaOptions_Internal(IntPtr @this, IntPtr Options);

		// Token: 0x06021AAE RID: 137902
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SetLooping_Internal(IntPtr @this, bool Looping);

		// Token: 0x06021AAF RID: 137903
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetDesiredPlayerName_Internal(IntPtr @this, FName PlayerName);

		// Token: 0x06021AB0 RID: 137904
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetBlockOnTime_Internal(IntPtr @this, IntPtr Time);

		// Token: 0x06021AB1 RID: 137905
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __SelectTrack_Internal(IntPtr @this, EMediaPlayerTrack TrackType, int TrackIndex);

		// Token: 0x06021AB2 RID: 137906
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Seek_Internal(IntPtr @this, IntPtr Time);

		// Token: 0x06021AB3 RID: 137907
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Rewind_Internal(IntPtr @this);

		// Token: 0x06021AB4 RID: 137908
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Reopen_Internal(IntPtr @this);

		// Token: 0x06021AB5 RID: 137909
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Previous_Internal(IntPtr @this);

		// Token: 0x06021AB6 RID: 137910
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __PlayAndSeek_Internal(IntPtr @this);

		// Token: 0x06021AB7 RID: 137911
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Play_Internal(IntPtr @this);

		// Token: 0x06021AB8 RID: 137912
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Pause_Internal(IntPtr @this);

		// Token: 0x06021AB9 RID: 137913
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OpenUrl_Internal(IntPtr @this, in FString Url);

		// Token: 0x06021ABA RID: 137914
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OpenSourceWithOptions_Internal(IntPtr @this, IntPtr MediaSource, IntPtr Options);

		// Token: 0x06021ABB RID: 137915
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __OpenSourceLatent_Internal(IntPtr @this, IntPtr WorldContextObject, IntPtr LatentInfo, IntPtr MediaSource, IntPtr Options, ref bool bSuccess);

		// Token: 0x06021ABC RID: 137916
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OpenSource_Internal(IntPtr @this, IntPtr MediaSource);

		// Token: 0x06021ABD RID: 137917
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OpenPlaylistIndex_Internal(IntPtr @this, IntPtr InPlaylist, int Index);

		// Token: 0x06021ABE RID: 137918
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OpenPlaylist_Internal(IntPtr @this, IntPtr InPlaylist);

		// Token: 0x06021ABF RID: 137919
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __OpenFile_Internal(IntPtr @this, in FString FilePath);

		// Token: 0x06021AC0 RID: 137920
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __Next_Internal(IntPtr @this);

		// Token: 0x06021AC1 RID: 137921
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsReady_Internal(IntPtr @this);

		// Token: 0x06021AC2 RID: 137922
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPreparing_Internal(IntPtr @this);

		// Token: 0x06021AC3 RID: 137923
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPlaying_Internal(IntPtr @this);

		// Token: 0x06021AC4 RID: 137924
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsPaused_Internal(IntPtr @this);

		// Token: 0x06021AC5 RID: 137925
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsLooping_Internal(IntPtr @this);

		// Token: 0x06021AC6 RID: 137926
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsInAsync_Internal(IntPtr @this);

		// Token: 0x06021AC7 RID: 137927
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsConnecting_Internal(IntPtr @this);

		// Token: 0x06021AC8 RID: 137928
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsClosed_Internal(IntPtr @this);

		// Token: 0x06021AC9 RID: 137929
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __IsBuffering_Internal(IntPtr @this);

		// Token: 0x06021ACA RID: 137930
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __HasError_Internal(IntPtr @this);

		// Token: 0x06021ACB RID: 137931
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FRotator __GetViewRotation_Internal(IntPtr @this);

		// Token: 0x06021ACC RID: 137932
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetVideoTrackType_Internal(IntPtr @this, int TrackIndex, int FormatIndex);

		// Token: 0x06021ACD RID: 137933
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FFloatRange __GetVideoTrackFrameRates_Internal(IntPtr @this, int TrackIndex, int FormatIndex);

		// Token: 0x06021ACE RID: 137934
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetVideoTrackFrameRate_Internal(IntPtr @this, int TrackIndex, int FormatIndex);

		// Token: 0x06021ACF RID: 137935
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FIntPoint __GetVideoTrackDimensions_Internal(IntPtr @this, int TrackIndex, int FormatIndex);

		// Token: 0x06021AD0 RID: 137936
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetVideoTrackAspectRatio_Internal(IntPtr @this, int TrackIndex, int FormatIndex);

		// Token: 0x06021AD1 RID: 137937
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetVerticalFieldOfView_Internal(IntPtr @this);

		// Token: 0x06021AD2 RID: 137938
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetUrl_Internal(IntPtr @this);

		// Token: 0x06021AD3 RID: 137939
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetTrackLanguage_Internal(IntPtr @this, EMediaPlayerTrack TrackType, int TrackIndex);

		// Token: 0x06021AD4 RID: 137940
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetTrackFormat_Internal(IntPtr @this, EMediaPlayerTrack TrackType, int TrackIndex);

		// Token: 0x06021AD5 RID: 137941
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTrackDisplayName_Internal(IntPtr @this, EMediaPlayerTrack TrackType, int TrackIndex);

		// Token: 0x06021AD6 RID: 137942
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTimeStamp_Internal(IntPtr @this);

		// Token: 0x06021AD7 RID: 137943
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTimeDelay_Internal(IntPtr @this);

		// Token: 0x06021AD8 RID: 137944
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetTime_Internal(IntPtr @this);

		// Token: 0x06021AD9 RID: 137945
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __GetSupportedRates_Internal(IntPtr @this, IntPtr OutRates, bool Unthinned);

		// Token: 0x06021ADA RID: 137946
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetSelectedTrack_Internal(IntPtr @this, EMediaPlayerTrack TrackType);

		// Token: 0x06021ADB RID: 137947
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetRate_Internal(IntPtr @this);

		// Token: 0x06021ADC RID: 137948
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetPlaylistIndex_Internal(IntPtr @this);

		// Token: 0x06021ADD RID: 137949
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetPlaylist_Internal(IntPtr @this);

		// Token: 0x06021ADE RID: 137950
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetPlayerName_Internal(IntPtr @this);

		// Token: 0x06021ADF RID: 137951
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumTracks_Internal(IntPtr @this, EMediaPlayerTrack TrackType);

		// Token: 0x06021AE0 RID: 137952
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetNumTrackFormats_Internal(IntPtr @this, EMediaPlayerTrack TrackType, int TrackIndex);

		// Token: 0x06021AE1 RID: 137953
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetMediaName_Internal(IntPtr @this);

		// Token: 0x06021AE2 RID: 137954
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern float __GetHorizontalFieldOfView_Internal(IntPtr @this);

		// Token: 0x06021AE3 RID: 137955
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetDuration_Internal(IntPtr @this);

		// Token: 0x06021AE4 RID: 137956
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern FName __GetDesiredPlayerName_Internal(IntPtr @this);

		// Token: 0x06021AE5 RID: 137957
		[NullableContext(0)]
		[MethodImpl(MethodImplOptions.InternalCall)]
		private unsafe static extern FString* __GetAudioTrackType_Internal(IntPtr @this, int TrackIndex, int FormatIndex);

		// Token: 0x06021AE6 RID: 137958
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetAudioTrackSampleRate_Internal(IntPtr @this, int TrackIndex, int FormatIndex);

		// Token: 0x06021AE7 RID: 137959
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern int __GetAudioTrackChannels_Internal(IntPtr @this, int TrackIndex, int FormatIndex);

		// Token: 0x06021AE8 RID: 137960
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __Close_Internal(IntPtr @this);

		// Token: 0x06021AE9 RID: 137961
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanPlayUrl_Internal(IntPtr @this, in FString Url);

		// Token: 0x06021AEA RID: 137962
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanPlaySource_Internal(IntPtr @this, IntPtr MediaSource);

		// Token: 0x06021AEB RID: 137963
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __CanPause_Internal(IntPtr @this);

		// Token: 0x06021AEC RID: 137964
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern bool __AsyncOpenSourceWithOptions_Internal(IntPtr @this, IntPtr MediaSource, IntPtr Options);

		// Token: 0x06021AED RID: 137965
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __AsyncClose_Internal(IntPtr @this);

		// Token: 0x06021AEE RID: 137966 RVA: 0x0031CF92 File Offset: 0x0031B192
		static UMediaPlayer()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MediaAssets.MediaPlayer");
		}

		// Token: 0x06021AEF RID: 137967 RVA: 0x0031CFA0 File Offset: 0x0031B1A0
		protected UMediaPlayer(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011F75 RID: 73589
		public new const string __ObjectPath = "/Script/MediaAssets.MediaPlayer";

		// Token: 0x04011F76 RID: 73590
		private static IntPtr _ClassPtr;

		// Token: 0x04011F77 RID: 73591
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04011F78 RID: 73592
		internal static int __PropertyOffset_OnEndReached;

		// Token: 0x04011F79 RID: 73593
		[Nullable(2)]
		private FOnMediaPlayerMediaEvent _OnEndReached;

		// Token: 0x04011F7A RID: 73594
		internal static int __PropertyOffset_OnMediaClosed;

		// Token: 0x04011F7B RID: 73595
		[Nullable(2)]
		private FOnMediaPlayerMediaEvent _OnMediaClosed;

		// Token: 0x04011F7C RID: 73596
		internal static int __PropertyOffset_OnMediaOpened;

		// Token: 0x04011F7D RID: 73597
		[Nullable(2)]
		private FOnMediaPlayerMediaOpened _OnMediaOpened;

		// Token: 0x04011F7E RID: 73598
		internal static int __PropertyOffset_OnMediaOpenFailed;

		// Token: 0x04011F7F RID: 73599
		[Nullable(2)]
		private FOnMediaPlayerMediaOpenFailed _OnMediaOpenFailed;

		// Token: 0x04011F80 RID: 73600
		internal static int __PropertyOffset_OnPlaybackResumed;

		// Token: 0x04011F81 RID: 73601
		[Nullable(2)]
		private FOnMediaPlayerMediaEvent _OnPlaybackResumed;

		// Token: 0x04011F82 RID: 73602
		internal static int __PropertyOffset_OnPlaybackSuspended;

		// Token: 0x04011F83 RID: 73603
		[Nullable(2)]
		private FOnMediaPlayerMediaEvent _OnPlaybackSuspended;

		// Token: 0x04011F84 RID: 73604
		internal static int __PropertyOffset_OnSeekCompleted;

		// Token: 0x04011F85 RID: 73605
		[Nullable(2)]
		private FOnMediaPlayerMediaEvent _OnSeekCompleted;

		// Token: 0x04011F86 RID: 73606
		internal static int __PropertyOffset_OnTracksChanged;

		// Token: 0x04011F87 RID: 73607
		[Nullable(2)]
		private FOnMediaPlayerMediaEvent _OnTracksChanged;

		// Token: 0x04011F88 RID: 73608
		internal static int __PropertyOffset_CacheAhead;

		// Token: 0x04011F89 RID: 73609
		[Nullable(2)]
		private FTimespan _CacheAhead;

		// Token: 0x04011F8A RID: 73610
		internal static int __PropertyOffset_CacheBehind;

		// Token: 0x04011F8B RID: 73611
		[Nullable(2)]
		private FTimespan _CacheBehind;

		// Token: 0x04011F8C RID: 73612
		internal static int __PropertyOffset_CacheBehindGame;

		// Token: 0x04011F8D RID: 73613
		[Nullable(2)]
		private FTimespan _CacheBehindGame;

		// Token: 0x04011F8E RID: 73614
		internal static int __PropertyOffset_NativeAudioOut;

		// Token: 0x04011F8F RID: 73615
		internal static int __PropertyOffset_PlayOnOpen;

		// Token: 0x04011F90 RID: 73616
		internal static int __PropertyOffset_Shuffle;

		// Token: 0x04011F91 RID: 73617
		internal static byte __PropertyMask_Shuffle;

		// Token: 0x04011F92 RID: 73618
		internal static int __PropertyOffset_Loop;

		// Token: 0x04011F93 RID: 73619
		internal static byte __PropertyMask_Loop;

		// Token: 0x04011F94 RID: 73620
		internal static int __PropertyOffset_Playlist;

		// Token: 0x04011F95 RID: 73621
		internal static int __PropertyOffset_PlaylistIndex;

		// Token: 0x04011F96 RID: 73622
		internal static int __PropertyOffset_TimeDelay;

		// Token: 0x04011F97 RID: 73623
		[Nullable(2)]
		private FTimespan _TimeDelay;

		// Token: 0x04011F98 RID: 73624
		internal static int __PropertyOffset_HorizontalFieldOfView;

		// Token: 0x04011F99 RID: 73625
		internal static int __PropertyOffset_VerticalFieldOfView;

		// Token: 0x04011F9A RID: 73626
		internal static int __PropertyOffset_ViewRotation;

		// Token: 0x04011F9B RID: 73627
		internal static int __PropertyOffset_PlayerGuid;
	}
}
