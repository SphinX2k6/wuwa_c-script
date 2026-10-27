using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020023CD RID: 9165
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MovieScene.EMovieSceneSequenceFlags")]
	public enum EMovieSceneSequenceFlags : byte
	{
		// Token: 0x04012672 RID: 75378
		None,
		// Token: 0x04012673 RID: 75379
		Volatile,
		// Token: 0x04012674 RID: 75380
		BlockingEvaluation,
		// Token: 0x04012675 RID: 75381
		InheritedFlags = 1,
		// Token: 0x04012676 RID: 75382
		EMovieSceneSequenceFlags_MAX = 3
	}
}
