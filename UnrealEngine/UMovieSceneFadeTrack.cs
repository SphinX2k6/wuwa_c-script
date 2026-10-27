using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x0200237B RID: 9083
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneFadeTrack")]
	[UnrealStructLayout(320, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 320)]
	public class UMovieSceneFadeTrack : UMovieSceneFloatTrack, IUnrealUObject, IUnrealObject, IMovieSceneTrackTemplateProducer, IUnrealNativeInterface, IUnrealInterface
	{
		// Token: 0x0602243A RID: 140346 RVA: 0x0032ABEB File Offset: 0x00328DEB
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneFadeTrack._ClassPtr;
		}

		// Token: 0x0602243B RID: 140347 RVA: 0x0032ABF7 File Offset: 0x00328DF7
		int IMovieSceneTrackTemplateProducer.InterfaceOffset()
		{
			return UMovieSceneFadeTrack.__InterfaceOffset_IMovieSceneTrackTemplateProducer;
		}

		// Token: 0x0602243C RID: 140348 RVA: 0x0032AC00 File Offset: 0x00328E00
		public UMovieSceneFadeTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneFadeTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602243D RID: 140349 RVA: 0x0032AC28 File Offset: 0x00328E28
		[NullableContext(1)]
		public UMovieSceneFadeTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneFadeTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602243E RID: 140350 RVA: 0x0032AC5B File Offset: 0x00328E5B
		static UMovieSceneFadeTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneFadeTrack");
		}

		// Token: 0x0602243F RID: 140351 RVA: 0x0032AC69 File Offset: 0x00328E69
		protected UMovieSceneFadeTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040124A8 RID: 74920
		internal static int __InterfaceOffset_IMovieSceneTrackTemplateProducer;

		// Token: 0x040124A9 RID: 74921
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneFadeTrack";

		// Token: 0x040124AA RID: 74922
		private static IntPtr _ClassPtr;

		// Token: 0x040124AB RID: 74923
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
