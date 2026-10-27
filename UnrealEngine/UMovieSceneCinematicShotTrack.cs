using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002359 RID: 9049
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneCinematicShotTrack")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public class UMovieSceneCinematicShotTrack : UMovieSceneSubTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022308 RID: 140040 RVA: 0x00328E6F File Offset: 0x0032706F
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneCinematicShotTrack._ClassPtr;
		}

		// Token: 0x06022309 RID: 140041 RVA: 0x00328E7C File Offset: 0x0032707C
		public UMovieSceneCinematicShotTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCinematicShotTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0602230A RID: 140042 RVA: 0x00328EA4 File Offset: 0x003270A4
		[NullableContext(1)]
		public UMovieSceneCinematicShotTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCinematicShotTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0602230B RID: 140043 RVA: 0x00328ED7 File Offset: 0x003270D7
		static UMovieSceneCinematicShotTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneCinematicShotTrack");
		}

		// Token: 0x0602230C RID: 140044 RVA: 0x00328EE5 File Offset: 0x003270E5
		protected UMovieSceneCinematicShotTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040123FE RID: 74750
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneCinematicShotTrack";

		// Token: 0x040123FF RID: 74751
		private static IntPtr _ClassPtr;

		// Token: 0x04012400 RID: 74752
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
