using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000286 RID: 646
	[UnrealObjectPath("/Script/AkAudio.MovieSceneAkAudioRTPCTrack")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UMovieSceneAkAudioRTPCTrack : UMovieSceneAkTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0600244B RID: 9291 RVA: 0x00035D37 File Offset: 0x00033F37
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneAkAudioRTPCTrack._ClassPtr;
		}

		// Token: 0x0600244C RID: 9292 RVA: 0x00035D43 File Offset: 0x00033F43
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneAkAudioRTPCTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x0600244D RID: 9293 RVA: 0x00035D4C File Offset: 0x00033F4C
		public UMovieSceneAkAudioRTPCTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAkAudioRTPCTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600244E RID: 9294 RVA: 0x00035D74 File Offset: 0x00033F74
		[NullableContext(1)]
		public UMovieSceneAkAudioRTPCTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAkAudioRTPCTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600244F RID: 9295 RVA: 0x00035DA7 File Offset: 0x00033FA7
		static UMovieSceneAkAudioRTPCTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.MovieSceneAkAudioRTPCTrack");
		}

		// Token: 0x06002450 RID: 9296 RVA: 0x00035DB5 File Offset: 0x00033FB5
		protected UMovieSceneAkAudioRTPCTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000DC9 RID: 3529
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04000DCA RID: 3530
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.MovieSceneAkAudioRTPCTrack";

		// Token: 0x04000DCB RID: 3531
		private static IntPtr _ClassPtr;

		// Token: 0x04000DCC RID: 3532
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
