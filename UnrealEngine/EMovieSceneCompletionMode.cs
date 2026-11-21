using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000775 RID: 1909
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MovieScene.EMovieSceneCompletionMode")]
	public enum EMovieSceneCompletionMode : byte
	{
		// Token: 0x040046AB RID: 18091
		KeepState,
		// Token: 0x040046AC RID: 18092
		RestoreState,
		// Token: 0x040046AD RID: 18093
		ProjectDefault,
		// Token: 0x040046AE RID: 18094
		EMovieSceneCompletionMode_MAX
	}
}
