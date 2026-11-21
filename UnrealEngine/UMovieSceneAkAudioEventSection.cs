using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000D5 RID: 213
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/AkAudio.MovieSceneAkAudioEventSection")]
	[UnrealStructLayout(560, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 560)]
	public class UMovieSceneAkAudioEventSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000F31 RID: 3889 RVA: 0x000177AE File Offset: 0x000159AE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneAkAudioEventSection._ClassPtr;
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x000177BC File Offset: 0x000159BC
		public UMovieSceneAkAudioEventSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAkAudioEventSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x000177E4 File Offset: 0x000159E4
		public UMovieSceneAkAudioEventSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAkAudioEventSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17000152 RID: 338
		// (get) Token: 0x06000F34 RID: 3892 RVA: 0x00017817 File Offset: 0x00015A17
		// (set) Token: 0x06000F35 RID: 3893 RVA: 0x0001782B File Offset: 0x00015A2B
		[Nullable(2)]
		public unsafe UAkAudioEvent Event
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneAkAudioEventSection.__PropertyOffset_Event);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneAkAudioEventSection.__PropertyOffset_Event, value);
			}
		}

		// Token: 0x17000153 RID: 339
		// (get) Token: 0x06000F36 RID: 3894 RVA: 0x00017840 File Offset: 0x00015A40
		// (set) Token: 0x06000F37 RID: 3895 RVA: 0x00017850 File Offset: 0x00015A50
		public unsafe bool RetriggerEvent
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_RetriggerEvent) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_RetriggerEvent) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000154 RID: 340
		// (get) Token: 0x06000F38 RID: 3896 RVA: 0x00017861 File Offset: 0x00015A61
		// (set) Token: 0x06000F39 RID: 3897 RVA: 0x00017871 File Offset: 0x00015A71
		public unsafe int ScrubTailLengthMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_ScrubTailLengthMs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_ScrubTailLengthMs) = value;
			}
		}

		// Token: 0x17000155 RID: 341
		// (get) Token: 0x06000F3A RID: 3898 RVA: 0x00017882 File Offset: 0x00015A82
		// (set) Token: 0x06000F3B RID: 3899 RVA: 0x00017892 File Offset: 0x00015A92
		public unsafe bool StopAtSectionEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_StopAtSectionEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_StopAtSectionEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x06000F3C RID: 3900 RVA: 0x000178A3 File Offset: 0x00015AA3
		// (set) Token: 0x06000F3D RID: 3901 RVA: 0x000178B7 File Offset: 0x00015AB7
		public unsafe string EventName
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_EventName)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_EventName)), value);
			}
		}

		// Token: 0x17000157 RID: 343
		// (get) Token: 0x06000F3E RID: 3902 RVA: 0x000178CC File Offset: 0x00015ACC
		// (set) Token: 0x06000F3F RID: 3903 RVA: 0x000178DC File Offset: 0x00015ADC
		public unsafe float MaxSourceDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_MaxSourceDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_MaxSourceDuration) = value;
			}
		}

		// Token: 0x17000158 RID: 344
		// (get) Token: 0x06000F40 RID: 3904 RVA: 0x000178ED File Offset: 0x00015AED
		// (set) Token: 0x06000F41 RID: 3905 RVA: 0x00017901 File Offset: 0x00015B01
		public unsafe string MaxDurationSourceID
		{
			get
			{
				return FString.ToString((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_MaxDurationSourceID)));
			}
			set
			{
				FString.CopyFrom((void*)(base.NativePtr + (byte*)((IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_MaxDurationSourceID)), value);
			}
		}

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x06000F42 RID: 3906 RVA: 0x00017916 File Offset: 0x00015B16
		// (set) Token: 0x06000F43 RID: 3907 RVA: 0x00017926 File Offset: 0x00015B26
		public unsafe int FadeOutMs
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_FadeOutMs);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_FadeOutMs) = value;
			}
		}

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x06000F44 RID: 3908 RVA: 0x00017938 File Offset: 0x00015B38
		// (set) Token: 0x06000F45 RID: 3909 RVA: 0x00017971 File Offset: 0x00015B71
		public FFrameNumber StartFrameOffset
		{
			get
			{
				base.FastCheckIsValid();
				FFrameNumber result;
				if ((result = this._StartFrameOffset) == null)
				{
					result = (this._StartFrameOffset = new FFrameNumber(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_StartFrameOffset, this));
				}
				return result;
			}
			set
			{
				UnrealReflectionUtils.CopyNativeStruct(FFrameNumber.StaticStruct(), base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_StartFrameOffset, value.NativePtr, 1, false);
			}
		}

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x06000F46 RID: 3910 RVA: 0x00017992 File Offset: 0x00015B92
		// (set) Token: 0x06000F47 RID: 3911 RVA: 0x000179A2 File Offset: 0x00015BA2
		public unsafe float StartOffsetSecondsDisplay
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_StartOffsetSecondsDisplay);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneAkAudioEventSection.__PropertyOffset_StartOffsetSecondsDisplay) = value;
			}
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x000179B3 File Offset: 0x00015BB3
		static UMovieSceneAkAudioEventSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.MovieSceneAkAudioEventSection");
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x000179C1 File Offset: 0x00015BC1
		protected UMovieSceneAkAudioEventSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000350 RID: 848
		public new const string __ObjectPath = "/Script/AkAudio.MovieSceneAkAudioEventSection";

		// Token: 0x04000351 RID: 849
		private static IntPtr _ClassPtr;

		// Token: 0x04000352 RID: 850
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x04000353 RID: 851
		internal static int __PropertyOffset_Event;

		// Token: 0x04000354 RID: 852
		internal static int __PropertyOffset_RetriggerEvent;

		// Token: 0x04000355 RID: 853
		internal static int __PropertyOffset_ScrubTailLengthMs;

		// Token: 0x04000356 RID: 854
		internal static int __PropertyOffset_StopAtSectionEnd;

		// Token: 0x04000357 RID: 855
		internal static int __PropertyOffset_EventName;

		// Token: 0x04000358 RID: 856
		internal static int __PropertyOffset_MaxSourceDuration;

		// Token: 0x04000359 RID: 857
		internal static int __PropertyOffset_MaxDurationSourceID;

		// Token: 0x0400035A RID: 858
		internal static int __PropertyOffset_FadeOutMs;

		// Token: 0x0400035B RID: 859
		internal static int __PropertyOffset_StartFrameOffset;

		// Token: 0x0400035C RID: 860
		[Nullable(2)]
		private FFrameNumber _StartFrameOffset;

		// Token: 0x0400035D RID: 861
		internal static int __PropertyOffset_StartOffsetSecondsDisplay;
	}
}
