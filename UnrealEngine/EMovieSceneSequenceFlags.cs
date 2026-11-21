using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000777 RID: 1911
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MovieScene.EMovieSceneSequenceFlags")]
	public enum EMovieSceneSequenceFlags : byte
	{
		// Token: 0x040046B5 RID: 18101
		None,
		// Token: 0x040046B6 RID: 18102
		Volatile,
		// Token: 0x040046B7 RID: 18103
		BlockingEvaluation,
		// Token: 0x040046B8 RID: 18104
		InheritedFlags = 1,
		// Token: 0x040046B9 RID: 18105
		EMovieSceneSequenceFlags_MAX = 3
	}
}
