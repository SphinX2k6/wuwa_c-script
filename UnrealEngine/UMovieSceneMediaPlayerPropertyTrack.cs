using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x020022AA RID: 8874
	[UnrealObjectPath("/Script/MediaCompositing.MovieSceneMediaPlayerPropertyTrack")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UMovieSceneMediaPlayerPropertyTrack : UMovieScenePropertyTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x06021BC4 RID: 138180 RVA: 0x0031E0E6 File Offset: 0x0031C2E6
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneMediaPlayerPropertyTrack._ClassPtr;
		}

		// Token: 0x06021BC5 RID: 138181 RVA: 0x0031E0F2 File Offset: 0x0031C2F2
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneMediaPlayerPropertyTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x06021BC6 RID: 138182 RVA: 0x0031E0FC File Offset: 0x0031C2FC
		public UMovieSceneMediaPlayerPropertyTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMediaPlayerPropertyTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06021BC7 RID: 138183 RVA: 0x0031E124 File Offset: 0x0031C324
		[NullableContext(1)]
		public UMovieSceneMediaPlayerPropertyTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneMediaPlayerPropertyTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06021BC8 RID: 138184 RVA: 0x0031E157 File Offset: 0x0031C357
		static UMovieSceneMediaPlayerPropertyTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MediaCompositing.MovieSceneMediaPlayerPropertyTrack");
		}

		// Token: 0x06021BC9 RID: 138185 RVA: 0x0031E165 File Offset: 0x0031C365
		protected UMovieSceneMediaPlayerPropertyTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04011FFA RID: 73722
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x04011FFB RID: 73723
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MediaCompositing.MovieSceneMediaPlayerPropertyTrack";

		// Token: 0x04011FFC RID: 73724
		private static IntPtr _ClassPtr;

		// Token: 0x04011FFD RID: 73725
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
