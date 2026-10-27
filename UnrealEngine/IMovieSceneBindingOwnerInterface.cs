using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x020023D7 RID: 9175
	[UnrealObjectPath("/Script/MovieScene.MovieSceneBindingOwnerInterface")]
	public interface IMovieSceneBindingOwnerInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06022772 RID: 141170
		int InterfaceOffset();

		// Token: 0x040126BD RID: 75453
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieScene.MovieSceneBindingOwnerInterface";
	}
}
