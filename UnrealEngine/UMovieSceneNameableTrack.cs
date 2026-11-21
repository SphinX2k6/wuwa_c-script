using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02000782 RID: 1922
	[UnrealObjectPath("/Script/MovieScene.MovieSceneNameableTrack")]
	[UnrealStructLayout(232, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 232)]
	public abstract class UMovieSceneNameableTrack : UMovieSceneTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x0600A5E5 RID: 42469 RVA: 0x000F5005 File Offset: 0x000F3205
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneNameableTrack._ClassPtr;
		}

		// Token: 0x0600A5E6 RID: 42470 RVA: 0x000F5011 File Offset: 0x000F3211
		static UMovieSceneNameableTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneNameableTrack");
		}

		// Token: 0x0600A5E7 RID: 42471 RVA: 0x000F5020 File Offset: 0x000F3220
		protected UMovieSceneNameableTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNameableTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x0600A5E8 RID: 42472 RVA: 0x000F5048 File Offset: 0x000F3248
		protected UMovieSceneNameableTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x04004709 RID: 18185
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneNameableTrack";

		// Token: 0x0400470A RID: 18186
		private static IntPtr _ClassPtr;

		// Token: 0x0400470B RID: 18187
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
