using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000283 RID: 643
	[UnrealObjectPath("/Script/AkAudio.MovieSceneAkAudioEventTrack")]
	[UnrealStructLayout(224, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 224)]
	public class UMovieSceneAkAudioEventTrack : UMovieSceneAkTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0600242C RID: 9260 RVA: 0x00035A25 File Offset: 0x00033C25
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneAkAudioEventTrack._ClassPtr;
		}

		// Token: 0x0600242D RID: 9261 RVA: 0x00035A31 File Offset: 0x00033C31
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneAkAudioEventTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x0600242E RID: 9262 RVA: 0x00035A38 File Offset: 0x00033C38
		public UMovieSceneAkAudioEventTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAkAudioEventTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600242F RID: 9263 RVA: 0x00035A60 File Offset: 0x00033C60
		[NullableContext(1)]
		public UMovieSceneAkAudioEventTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAkAudioEventTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06002430 RID: 9264 RVA: 0x00035A93 File Offset: 0x00033C93
		static UMovieSceneAkAudioEventTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.MovieSceneAkAudioEventTrack");
		}

		// Token: 0x06002431 RID: 9265 RVA: 0x00035AA1 File Offset: 0x00033CA1
		protected UMovieSceneAkAudioEventTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04000DB7 RID: 3511
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04000DB8 RID: 3512
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.MovieSceneAkAudioEventTrack";

		// Token: 0x04000DB9 RID: 3513
		private static IntPtr _ClassPtr;

		// Token: 0x04000DBA RID: 3514
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
