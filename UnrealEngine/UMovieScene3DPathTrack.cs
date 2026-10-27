using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200232E RID: 9006
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieScene3DPathTrack")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public class UMovieScene3DPathTrack : UMovieScene3DConstraintTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602210D RID: 139533 RVA: 0x00325D04 File Offset: 0x00323F04
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieScene3DPathTrack._ClassPtr;
		}

		// Token: 0x0602210E RID: 139534 RVA: 0x00325D10 File Offset: 0x00323F10
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieScene3DPathTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x0602210F RID: 139535 RVA: 0x00325D18 File Offset: 0x00323F18
		public UMovieScene3DPathTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieScene3DPathTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022110 RID: 139536 RVA: 0x00325D40 File Offset: 0x00323F40
		[NullableContext(1)]
		public UMovieScene3DPathTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieScene3DPathTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x06022111 RID: 139537 RVA: 0x00325D73 File Offset: 0x00323F73
		static UMovieScene3DPathTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieScene3DPathTrack");
		}

		// Token: 0x06022112 RID: 139538 RVA: 0x00325D81 File Offset: 0x00323F81
		protected UMovieScene3DPathTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040122E4 RID: 74468
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x040122E5 RID: 74469
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieScene3DPathTrack";

		// Token: 0x040122E6 RID: 74470
		private static IntPtr _ClassPtr;

		// Token: 0x040122E7 RID: 74471
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
