using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000774 RID: 1908
	[UnrealObjectPath("/Script/MovieSceneTracks.MovieSceneVisibilityTrack")]
	[UnrealStructLayout(336, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 336)]
	public class UMovieSceneVisibilityTrack : UMovieSceneBoolTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A55B RID: 42331 RVA: 0x000F438C File Offset: 0x000F258C
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneVisibilityTrack._ClassPtr;
		}

		// Token: 0x0600A55C RID: 42332 RVA: 0x000F4398 File Offset: 0x000F2598
		public UMovieSceneVisibilityTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneVisibilityTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A55D RID: 42333 RVA: 0x000F43C0 File Offset: 0x000F25C0
		[NullableContext(1)]
		public UMovieSceneVisibilityTrack(UnrealUObject Outer, [Nullable(2)] string Name = null, EObjectFlags ObjectFlags = EObjectFlags.RF_NoFlags) : this(BuiltinUtils.AllocNativeUObject(UMovieSceneVisibilityTrack.StaticClass(), Outer, (Name != null) ? new FName(Name) : default(FName), ObjectFlags))
		{
		}

		// Token: 0x0600A55E RID: 42334 RVA: 0x000F43F3 File Offset: 0x000F25F3
		static UMovieSceneVisibilityTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieSceneTracks.MovieSceneVisibilityTrack");
		}

		// Token: 0x0600A55F RID: 42335 RVA: 0x000F4401 File Offset: 0x000F2601
		protected UMovieSceneVisibilityTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x040046A7 RID: 18087
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieSceneTracks.MovieSceneVisibilityTrack";

		// Token: 0x040046A8 RID: 18088
		private static IntPtr _ClassPtr;

		// Token: 0x040046A9 RID: 18089
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
