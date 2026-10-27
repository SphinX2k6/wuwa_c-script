using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200169F RID: 5791
	[NullableContext(1)]
	[Nullable(0)]
	[UnrealObjectPath("/Script/KuroAudio.MovieSceneKuroAudioEventSection")]
	[UnrealStructLayout(376, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 376)]
	public class UMovieSceneKuroAudioEventSection : UMovieSceneSection, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06014FF6 RID: 86006 RVA: 0x001EDBEE File Offset: 0x001EBDEE
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneKuroAudioEventSection._ClassPtr;
		}

		// Token: 0x06014FF7 RID: 86007 RVA: 0x001EDBFC File Offset: 0x001EBDFC
		public UMovieSceneKuroAudioEventSection() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneKuroAudioEventSection.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06014FF8 RID: 86008 RVA: 0x001EDC24 File Offset: 0x001EBE24
		public UMovieSceneKuroAudioEventSection(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneKuroAudioEventSection.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x17005317 RID: 21271
		// (get) Token: 0x06014FF9 RID: 86009 RVA: 0x001EDC57 File Offset: 0x001EBE57
		// (set) Token: 0x06014FFA RID: 86010 RVA: 0x001EDC67 File Offset: 0x001EBE67
		public unsafe bool bStopAtSectionEnd
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneKuroAudioEventSection.__PropertyOffset_bStopAtSectionEnd) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneKuroAudioEventSection.__PropertyOffset_bStopAtSectionEnd) = (value ? 1 : 0);
			}
		}

		// Token: 0x17005318 RID: 21272
		// (get) Token: 0x06014FFB RID: 86011 RVA: 0x001EDC78 File Offset: 0x001EBE78
		// (set) Token: 0x06014FFC RID: 86012 RVA: 0x001EDC88 File Offset: 0x001EBE88
		public unsafe int FadeDuration
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneKuroAudioEventSection.__PropertyOffset_FadeDuration);
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneKuroAudioEventSection.__PropertyOffset_FadeDuration) = value;
			}
		}

		// Token: 0x17005319 RID: 21273
		// (get) Token: 0x06014FFD RID: 86013 RVA: 0x001EDC99 File Offset: 0x001EBE99
		// (set) Token: 0x06014FFE RID: 86014 RVA: 0x001EDCA9 File Offset: 0x001EBEA9
		public unsafe EAudioFadeCurve FadeCurve
		{
			get
			{
				return (EAudioFadeCurve)(*(base.NativePtr + (IntPtr)UMovieSceneKuroAudioEventSection.__PropertyOffset_FadeCurve));
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneKuroAudioEventSection.__PropertyOffset_FadeCurve) = (byte)value;
			}
		}

		// Token: 0x1700531A RID: 21274
		// (get) Token: 0x06014FFF RID: 86015 RVA: 0x001EDCBA File Offset: 0x001EBEBA
		// (set) Token: 0x06015000 RID: 86016 RVA: 0x001EDCCA File Offset: 0x001EBECA
		public unsafe bool bSyncAudio
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneKuroAudioEventSection.__PropertyOffset_bSyncAudio) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneKuroAudioEventSection.__PropertyOffset_bSyncAudio) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700531B RID: 21275
		// (get) Token: 0x06015001 RID: 86017 RVA: 0x001EDCDB File Offset: 0x001EBEDB
		// (set) Token: 0x06015002 RID: 86018 RVA: 0x001EDCEB File Offset: 0x001EBEEB
		public unsafe bool bTriggerOnSeqReverse
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneKuroAudioEventSection.__PropertyOffset_bTriggerOnSeqReverse) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneKuroAudioEventSection.__PropertyOffset_bTriggerOnSeqReverse) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700531C RID: 21276
		// (get) Token: 0x06015003 RID: 86019 RVA: 0x001EDCFC File Offset: 0x001EBEFC
		// (set) Token: 0x06015004 RID: 86020 RVA: 0x001EDD0C File Offset: 0x001EBF0C
		public unsafe bool bFreezeOnAttachmentLost
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneKuroAudioEventSection.__PropertyOffset_bFreezeOnAttachmentLost) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneKuroAudioEventSection.__PropertyOffset_bFreezeOnAttachmentLost) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700531D RID: 21277
		// (get) Token: 0x06015005 RID: 86021 RVA: 0x001EDD1D File Offset: 0x001EBF1D
		// (set) Token: 0x06015006 RID: 86022 RVA: 0x001EDD2D File Offset: 0x001EBF2D
		public unsafe bool bAutoMatchLength
		{
			get
			{
				return *(base.NativePtr + (IntPtr)UMovieSceneKuroAudioEventSection.__PropertyOffset_bAutoMatchLength) != 0;
			}
			set
			{
				*(base.NativePtr + (IntPtr)UMovieSceneKuroAudioEventSection.__PropertyOffset_bAutoMatchLength) = (value ? 1 : 0);
			}
		}

		// Token: 0x1700531E RID: 21278
		// (get) Token: 0x06015007 RID: 86023 RVA: 0x001EDD3E File Offset: 0x001EBF3E
		// (set) Token: 0x06015008 RID: 86024 RVA: 0x001EDD52 File Offset: 0x001EBF52
		[Nullable(2)]
		public unsafe UAkAudioEvent AudioEvent
		{
			[NullableContext(2)]
			get
			{
				return BuiltinUtils.ObjectPropertyGetter<UAkAudioEvent>(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneKuroAudioEventSection.__PropertyOffset_AudioEvent);
			}
			[NullableContext(2)]
			set
			{
				BuiltinUtils.ObjectPropertySetter(base.NativePtr / (IntPtr)sizeof(void*) + UMovieSceneKuroAudioEventSection.__PropertyOffset_AudioEvent, value);
			}
		}

		// Token: 0x1700531F RID: 21279
		// (get) Token: 0x06015009 RID: 86025 RVA: 0x001EDD67 File Offset: 0x001EBF67
		// (set) Token: 0x0601500A RID: 86026 RVA: 0x001EDD7C File Offset: 0x001EBF7C
		public TSoftObjectPtr<UAkAudioEvent> SoftAudioEvent
		{
			get
			{
				return new TSoftObjectPtr<UAkAudioEvent>(base.NativePtr + (IntPtr)UMovieSceneKuroAudioEventSection.__PropertyOffset_SoftAudioEvent, this);
			}
			set
			{
				FSoftObjectPtr.NativeCopy(base.NativePtr + (IntPtr)UMovieSceneKuroAudioEventSection.__PropertyOffset_SoftAudioEvent, (value != null) ? value.NativePtr : IntPtr.Zero, 1);
			}
		}

		// Token: 0x0601500B RID: 86027 RVA: 0x001EDDA1 File Offset: 0x001EBFA1
		static UMovieSceneKuroAudioEventSection()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/KuroAudio.MovieSceneKuroAudioEventSection");
		}

		// Token: 0x0601500C RID: 86028 RVA: 0x001EDDAF File Offset: 0x001EBFAF
		protected UMovieSceneKuroAudioEventSection(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400B6F0 RID: 46832
		public new const string __ObjectPath = "/Script/KuroAudio.MovieSceneKuroAudioEventSection";

		// Token: 0x0400B6F1 RID: 46833
		private static IntPtr _ClassPtr;

		// Token: 0x0400B6F2 RID: 46834
		private static IntPtr _ClassDefaultObjectPtr;

		// Token: 0x0400B6F3 RID: 46835
		internal static int __PropertyOffset_bStopAtSectionEnd;

		// Token: 0x0400B6F4 RID: 46836
		internal static int __PropertyOffset_FadeDuration;

		// Token: 0x0400B6F5 RID: 46837
		internal static int __PropertyOffset_FadeCurve;

		// Token: 0x0400B6F6 RID: 46838
		internal static int __PropertyOffset_bSyncAudio;

		// Token: 0x0400B6F7 RID: 46839
		internal static int __PropertyOffset_bTriggerOnSeqReverse;

		// Token: 0x0400B6F8 RID: 46840
		internal static int __PropertyOffset_bFreezeOnAttachmentLost;

		// Token: 0x0400B6F9 RID: 46841
		internal static int __PropertyOffset_bAutoMatchLength;

		// Token: 0x0400B6FA RID: 46842
		internal static int __PropertyOffset_AudioEvent;

		// Token: 0x0400B6FB RID: 46843
		internal static int __PropertyOffset_SoftAudioEvent;
	}
}
