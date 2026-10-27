using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;
using UnrealEngine.Utils;

namespace UnrealEngine
{
	// Token: 0x02002416 RID: 9238
	[UnrealObjectPath("/Script/MovieScene.MovieSceneNameableTrack")]
	[UnrealStructLayout(216, 8, UnrealReflectionPropertyTypeCode.UnrealObject, PropertiesSize = 216)]
	public abstract class UMovieSceneNameableTrack : UMovieSceneTrack, IUnrealUObject, IUnrealObject
	{
		// Token: 0x06022A15 RID: 141845 RVA: 0x00333694 File Offset: 0x00331894
		public new static UClassStackOnlyPtr StaticClass()
		{
			return UMovieSceneNameableTrack._ClassPtr;
		}

		// Token: 0x06022A16 RID: 141846 RVA: 0x003336A0 File Offset: 0x003318A0
		static UMovieSceneNameableTrack()
		{
			UObjectGlobals.StaticLoadClass(null, "/Script/MovieScene.MovieSceneNameableTrack");
		}

		// Token: 0x06022A17 RID: 141847 RVA: 0x003336B0 File Offset: 0x003318B0
		protected UMovieSceneNameableTrack() : this(BuiltinUtils.AllocNativeUObject(UMovieSceneNameableTrack.StaticClass(), null, default(FName), EObjectFlags.RF_NoFlags))
		{
		}

		// Token: 0x06022A18 RID: 141848 RVA: 0x003336D8 File Offset: 0x003318D8
		protected UMovieSceneNameableTrack(IntPtr NativeObjectPtr) : base(NativeObjectPtr)
		{
		}

		// Token: 0x0401280D RID: 75789
		[Nullable(1)]
		public new const string __ObjectPath = "/Script/MovieScene.MovieSceneNameableTrack";

		// Token: 0x0401280E RID: 75790
		private static IntPtr _ClassPtr;

		// Token: 0x0401280F RID: 75791
		private static IntPtr _ClassDefaultObjectPtr;
	}
}
