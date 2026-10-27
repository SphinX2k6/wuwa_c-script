using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200233C RID: 9020
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneAudioSection")]
	[UnrealStructLayout(928, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 928)]
	public class UMovieSceneAudioSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x060221AC RID: 139692 RVA: 0x00326CF4 File Offset: 0x00324EF4
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneAudioSection._ClassPtr;
		}

		// Token: 0x060221AD RID: 139693 RVA: 0x00326D00 File Offset: 0x00324F00
		public UMovieSceneAudioSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAudioSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x060221AE RID: 139694 RVA: 0x00326D28 File Offset: 0x00324F28
		public UMovieSceneAudioSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAudioSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x170083BC RID: 33724
		// (get) Token: 0x060221AF RID: 139695 RVA: 0x00326D5B File Offset: 0x00324F5B
		// (set) Token: 0x060221B0 RID: 139696 RVA: 0x00326D6F File Offset: 0x00324F6F
		[Nullable(2)]
		public unsafe USoundBase Sound
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundBase>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneAudioSection.__PropertyOffset_Sound);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneAudioSection.__PropertyOffset_Sound, value);
			}
		}

		// Token: 0x170083BD RID: 33725
		// (get) Token: 0x060221B1 RID: 139697 RVA: 0x00326D84 File Offset: 0x00324F84
		// (set) Token: 0x060221B2 RID: 139698 RVA: 0x00326DBD File Offset: 0x00324FBD
		public FFrameNumber StartFrameOffset
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._StartFrameOffset) == null)
				{
					result = (this._StartFrameOffset = new FFrameNumber(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_StartFrameOffset, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_StartFrameOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170083BE RID: 33726
		// (get) Token: 0x060221B3 RID: 139699 RVA: 0x00326DDE File Offset: 0x00324FDE
		// (set) Token: 0x060221B4 RID: 139700 RVA: 0x00326DEE File Offset: 0x00324FEE
		public unsafe float StartOffset_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_StartOffset_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_StartOffset_DEPRECATED) = value;
			}
		}

		// Token: 0x170083BF RID: 33727
		// (get) Token: 0x060221B5 RID: 139701 RVA: 0x00326DFF File Offset: 0x00324FFF
		// (set) Token: 0x060221B6 RID: 139702 RVA: 0x00326E0F File Offset: 0x0032500F
		public unsafe float AudioStartTime_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_AudioStartTime_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_AudioStartTime_DEPRECATED) = value;
			}
		}

		// Token: 0x170083C0 RID: 33728
		// (get) Token: 0x060221B7 RID: 139703 RVA: 0x00326E20 File Offset: 0x00325020
		// (set) Token: 0x060221B8 RID: 139704 RVA: 0x00326E30 File Offset: 0x00325030
		public unsafe float AudioDilationFactor_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_AudioDilationFactor_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_AudioDilationFactor_DEPRECATED) = value;
			}
		}

		// Token: 0x170083C1 RID: 33729
		// (get) Token: 0x060221B9 RID: 139705 RVA: 0x00326E41 File Offset: 0x00325041
		// (set) Token: 0x060221BA RID: 139706 RVA: 0x00326E51 File Offset: 0x00325051
		public unsafe float AudioVolume_DEPRECATED
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_AudioVolume_DEPRECATED);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_AudioVolume_DEPRECATED) = value;
			}
		}

		// Token: 0x170083C2 RID: 33730
		// (get) Token: 0x060221BB RID: 139707 RVA: 0x00326E64 File Offset: 0x00325064
		// (set) Token: 0x060221BC RID: 139708 RVA: 0x00326E9D File Offset: 0x0032509D
		public FMovieSceneFloatChannel SoundVolume
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._SoundVolume) == null)
				{
					result = (this._SoundVolume = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_SoundVolume, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_SoundVolume, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170083C3 RID: 33731
		// (get) Token: 0x060221BD RID: 139709 RVA: 0x00326EC0 File Offset: 0x003250C0
		// (set) Token: 0x060221BE RID: 139710 RVA: 0x00326EF9 File Offset: 0x003250F9
		public FMovieSceneFloatChannel PitchMultiplier
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneFloatChannel result;
				if ((result = this._PitchMultiplier) == null)
				{
					result = (this._PitchMultiplier = new FMovieSceneFloatChannel(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_PitchMultiplier, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneFloatChannel.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_PitchMultiplier, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170083C4 RID: 33732
		// (get) Token: 0x060221BF RID: 139711 RVA: 0x00326F1C File Offset: 0x0032511C
		// (set) Token: 0x060221C0 RID: 139712 RVA: 0x00326F55 File Offset: 0x00325155
		public FMovieSceneActorReferenceData AttachActorData
		{
			get
			{
				base.FastCheckIsValid();
				FMovieSceneActorReferenceData result;
				if ((result = this._AttachActorData) == null)
				{
					result = (this._AttachActorData = new FMovieSceneActorReferenceData(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_AttachActorData, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FMovieSceneActorReferenceData.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_AttachActorData, value.NativePtr, 1, false);
			}
		}

		// Token: 0x170083C5 RID: 33733
		// (get) Token: 0x060221C1 RID: 139713 RVA: 0x00326F76 File Offset: 0x00325176
		// (set) Token: 0x060221C2 RID: 139714 RVA: 0x00326F86 File Offset: 0x00325186
		public unsafe bool bLooping
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_bLooping) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_bLooping) = (value ? 1 : 0);
			}
		}

		// Token: 0x170083C6 RID: 33734
		// (get) Token: 0x060221C3 RID: 139715 RVA: 0x00326F97 File Offset: 0x00325197
		// (set) Token: 0x060221C4 RID: 139716 RVA: 0x00326FA7 File Offset: 0x003251A7
		public unsafe bool bSuppressSubtitles
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_bSuppressSubtitles) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_bSuppressSubtitles) = (value ? 1 : 0);
			}
		}

		// Token: 0x170083C7 RID: 33735
		// (get) Token: 0x060221C5 RID: 139717 RVA: 0x00326FB8 File Offset: 0x003251B8
		// (set) Token: 0x060221C6 RID: 139718 RVA: 0x00326FC8 File Offset: 0x003251C8
		public unsafe bool bOverrideAttenuation
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_bOverrideAttenuation) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_bOverrideAttenuation) = (value ? 1 : 0);
			}
		}

		// Token: 0x170083C8 RID: 33736
		// (get) Token: 0x060221C7 RID: 139719 RVA: 0x00326FD9 File Offset: 0x003251D9
		// (set) Token: 0x060221C8 RID: 139720 RVA: 0x00326FED File Offset: 0x003251ED
		[Nullable(2)]
		public unsafe USoundAttenuation AttenuationSettings
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<USoundAttenuation>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneAudioSection.__PropertyOffset_AttenuationSettings);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneAudioSection.__PropertyOffset_AttenuationSettings, value);
			}
		}

		// Token: 0x170083C9 RID: 33737
		// (get) Token: 0x060221C9 RID: 139721 RVA: 0x00327004 File Offset: 0x00325204
		// (set) Token: 0x060221CA RID: 139722 RVA: 0x0032703D File Offset: 0x0032523D
		public FOnQueueSubtitles OnQueueSubtitles
		{
			get
			{
				base.FastCheckIsValid();
				FOnQueueSubtitles result;
				if ((result = this._OnQueueSubtitles) == null)
				{
					result = (this._OnQueueSubtitles = new FOnQueueSubtitles(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_OnQueueSubtitles, this));
				}
				return result;
			}
			set
			{
				FScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_OnQueueSubtitles, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170083CA RID: 33738
		// (get) Token: 0x060221CB RID: 139723 RVA: 0x00327060 File Offset: 0x00325260
		// (set) Token: 0x060221CC RID: 139724 RVA: 0x00327099 File Offset: 0x00325299
		public FOnAudioFinished OnAudioFinished
		{
			get
			{
				base.FastCheckIsValid();
				FOnAudioFinished result;
				if ((result = this._OnAudioFinished) == null)
				{
					result = (this._OnAudioFinished = new FOnAudioFinished(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_OnAudioFinished, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_OnAudioFinished, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x170083CB RID: 33739
		// (get) Token: 0x060221CD RID: 139725 RVA: 0x003270BC File Offset: 0x003252BC
		// (set) Token: 0x060221CE RID: 139726 RVA: 0x003270F5 File Offset: 0x003252F5
		public FOnAudioPlaybackPercent OnAudioPlaybackPercent
		{
			get
			{
				base.FastCheckIsValid();
				FOnAudioPlaybackPercent result;
				if ((result = this._OnAudioPlaybackPercent) == null)
				{
					result = (this._OnAudioPlaybackPercent = new FOnAudioPlaybackPercent(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_OnAudioPlaybackPercent, this));
				}
				return result;
			}
			set
			{
				FMulticastScriptDelegate.NativeCopy(base.NativePtr + (IntPtr)UMovieSceneAudioSection.__PropertyOffset_OnAudioPlaybackPercent, (value != null) ? value.NativePtr : ((IntPtr)0));
			}
		}

		// Token: 0x060221CF RID: 139727 RVA: 0x00327116 File Offset: 0x00325316
		[NullableContext(2)]
		public void SetStartOffset(FFrameNumber InStartOffset)
		{
			UMovieSceneAudioSection.__SetStartOffset_Internal(base.NativePtr, (InStartOffset ?? new FFrameNumber()).NativePtr);
		}

		// Token: 0x060221D0 RID: 139728 RVA: 0x00327132 File Offset: 0x00325332
		[NullableContext(2)]
		public void SetSound(USoundBase InSound)
		{
			UMovieSceneAudioSection.__SetSound_Internal(base.NativePtr, (InSound != null) ? InSound.NativePtr : IntPtr.Zero);
		}

		// Token: 0x060221D1 RID: 139729 RVA: 0x0032714F File Offset: 0x0032534F
		public FFrameNumber GetStartOffset()
		{
			return new FFrameNumber(UMovieSceneAudioSection.__GetStartOffset_Internal(base.NativePtr), null);
		}

		// Token: 0x060221D2 RID: 139730 RVA: 0x00327162 File Offset: 0x00325362
		[NullableContext(2)]
		public USoundBase GetSound()
		{
			return BuiltinUtils.GetOrCreateUObjectByNativePointer<USoundBase>(UMovieSceneAudioSection.__GetSound_Internal(base.NativePtr));
		}

		// Token: 0x060221D3 RID: 139731
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetStartOffset_Internal(IntPtr @this, IntPtr InStartOffset);

		// Token: 0x060221D4 RID: 139732
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern void __SetSound_Internal(IntPtr @this, IntPtr InSound);

		// Token: 0x060221D5 RID: 139733
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetStartOffset_Internal(IntPtr @this);

		// Token: 0x060221D6 RID: 139734
		[MethodImpl(MethodImplOptions.InternalCall)]
		private static extern IntPtr __GetSound_Internal(IntPtr @this);

		// Token: 0x060221D7 RID: 139735 RVA: 0x00327174 File Offset: 0x00325374
		static UMovieSceneAudioSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneAudioSection");
		}

		// Token: 0x060221D8 RID: 139736 RVA: 0x00327182 File Offset: 0x00325382
		protected UMovieSceneAudioSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401233D RID: 74557
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneAudioSection";

		// Token: 0x0401233E RID: 74558
		private static IntPtr _ClassPtr;

		// Token: 0x0401233F RID: 74559
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04012340 RID: 74560
		internal static int __PropertyOffset_Sound;

		// Token: 0x04012341 RID: 74561
		internal static int __PropertyOffset_StartFrameOffset;

		// Token: 0x04012342 RID: 74562
		[Nullable(2)]
		private FFrameNumber _StartFrameOffset;

		// Token: 0x04012343 RID: 74563
		internal static int __PropertyOffset_StartOffset_DEPRECATED;

		// Token: 0x04012344 RID: 74564
		internal static int __PropertyOffset_AudioStartTime_DEPRECATED;

		// Token: 0x04012345 RID: 74565
		internal static int __PropertyOffset_AudioDilationFactor_DEPRECATED;

		// Token: 0x04012346 RID: 74566
		internal static int __PropertyOffset_AudioVolume_DEPRECATED;

		// Token: 0x04012347 RID: 74567
		internal static int __PropertyOffset_SoundVolume;

		// Token: 0x04012348 RID: 74568
		[Nullable(2)]
		private FMovieSceneFloatChannel _SoundVolume;

		// Token: 0x04012349 RID: 74569
		internal static int __PropertyOffset_PitchMultiplier;

		// Token: 0x0401234A RID: 74570
		[Nullable(2)]
		private FMovieSceneFloatChannel _PitchMultiplier;

		// Token: 0x0401234B RID: 74571
		internal static int __PropertyOffset_AttachActorData;

		// Token: 0x0401234C RID: 74572
		[Nullable(2)]
		private FMovieSceneActorReferenceData _AttachActorData;

		// Token: 0x0401234D RID: 74573
		internal static int __PropertyOffset_bLooping;

		// Token: 0x0401234E RID: 74574
		internal static int __PropertyOffset_bSuppressSubtitles;

		// Token: 0x0401234F RID: 74575
		internal static int __PropertyOffset_bOverrideAttenuation;

		// Token: 0x04012350 RID: 74576
		internal static int __PropertyOffset_AttenuationSettings;

		// Token: 0x04012351 RID: 74577
		internal static int __PropertyOffset_OnQueueSubtitles;

		// Token: 0x04012352 RID: 74578
		[Nullable(2)]
		private FOnQueueSubtitles _OnQueueSubtitles;

		// Token: 0x04012353 RID: 74579
		internal static int __PropertyOffset_OnAudioFinished;

		// Token: 0x04012354 RID: 74580
		[Nullable(2)]
		private FOnAudioFinished _OnAudioFinished;

		// Token: 0x04012355 RID: 74581
		internal static int __PropertyOffset_OnAudioPlaybackPercent;

		// Token: 0x04012356 RID: 74582
		[Nullable(2)]
		private FOnAudioPlaybackPercent _OnAudioPlaybackPercent;
	}
}
