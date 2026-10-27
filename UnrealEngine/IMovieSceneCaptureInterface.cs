using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Interface;
using UnrealEngine.Service;

namespace UnrealEngine
{
	// Token: 0x02002312 RID: 8978
	[UnrealObjectPath("/Script/MovieSceneCapture.MovieSceneCaptureInterface")]
	public interface IMovieSceneCaptureInterface : IUnrealNativeInterface, IUnrealInterface, IUnrealObject
	{
		// Token: 0x06021FD9 RID: 139225
		int InterfaceOffset();

		// Token: 0x0401221C RID: 74268
		[Nullable(1)]
		public const string __ObjectPath = "/Script/MovieSceneCapture.MovieSceneCaptureInterface";
	}
}
