using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020000D6 RID: 214
	[UnrealObjectPath("/Script/AkAudio.MovieSceneAkAudioEventTrack")]
	[UnrealStructLayout(240, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 240)]
	public class UMovieSceneAkAudioEventTrack : UMovieSceneAkTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06000F4A RID: 3914 RVA: 0x000179CA File Offset: 0x00015BCA
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneAkAudioEventTrack._ClassPtr;
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x000179D8 File Offset: 0x00015BD8
		public UMovieSceneAkAudioEventTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAkAudioEventTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x00017A00 File Offset: 0x00015C00
		[NullableContext(1)]
		public UMovieSceneAkAudioEventTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneAkAudioEventTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x00017A33 File Offset: 0x00015C33
		static UMovieSceneAkAudioEventTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/AkAudio.MovieSceneAkAudioEventTrack");
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00017A41 File Offset: 0x00015C41
		protected UMovieSceneAkAudioEventTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0400035E RID: 862
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/AkAudio.MovieSceneAkAudioEventTrack";

		// Token: 0x0400035F RID: 863
		private static IntPtr _ClassPtr;

		// Token: 0x04000360 RID: 864
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
