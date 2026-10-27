using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023EB RID: 9195
	[UnrealObjectPath("/Script/MovieScene.MovieSceneEntityProvider")]
	public interface IMovieSceneEntityProvider : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x0602284D RID: 141389
		int InterfaceOffset();

		// Token: 0x0401273C RID: 75580
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneEntityProvider";
	}
}
