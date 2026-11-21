using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000763 RID: 1891
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneCinematicShotTrack")]
	[UnrealStructLayout(248, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 248)]
	public class UMovieSceneCinematicShotTrack : UMovieSceneSubTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A47F RID: 42111 RVA: 0x000F2F7B File Offset: 0x000F117B
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneCinematicShotTrack._ClassPtr;
		}

		// Token: 0x0600A480 RID: 42112 RVA: 0x000F2F88 File Offset: 0x000F1188
		public UMovieSceneCinematicShotTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCinematicShotTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A481 RID: 42113 RVA: 0x000F2FB0 File Offset: 0x000F11B0
		[NullableContext(1)]
		public UMovieSceneCinematicShotTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneCinematicShotTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A482 RID: 42114 RVA: 0x000F2FE3 File Offset: 0x000F11E3
		static UMovieSceneCinematicShotTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneCinematicShotTrack");
		}

		// Token: 0x0600A483 RID: 42115 RVA: 0x000F2FF1 File Offset: 0x000F11F1
		protected UMovieSceneCinematicShotTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004628 RID: 17960
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneCinematicShotTrack";

		// Token: 0x04004629 RID: 17961
		private static IntPtr _ClassPtr;

		// Token: 0x0400462A RID: 17962
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
