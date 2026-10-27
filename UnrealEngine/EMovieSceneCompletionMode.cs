using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020023C7 RID: 9159
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MovieScene.EMovieSceneCompletionMode")]
	public enum EMovieSceneCompletionMode : byte
	{
		// Token: 0x04012650 RID: 75344
		KeepState,
		// Token: 0x04012651 RID: 75345
		RestoreState,
		// Token: 0x04012652 RID: 75346
		ProjectDefault,
		// Token: 0x04012653 RID: 75347
		EMovieSceneCompletionMode_MAX
	}
}
