using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x0200241F RID: 9247
	[UnrealObjectPath("/Script/MovieScene.MovieScenePlaybackClient")]
	public interface IMovieScenePlaybackClient : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06022A71 RID: 141937
		int InterfaceOffset();

		// Token: 0x04012838 RID: 75832
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieScenePlaybackClient";
	}
}
