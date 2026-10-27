using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020023C8 RID: 9160
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MovieScene.EMovieSceneEvaluationType")]
	public enum EMovieSceneEvaluationType : byte
	{
		// Token: 0x04012655 RID: 75349
		FrameLocked,
		// Token: 0x04012656 RID: 75350
		WithSubFrames,
		// Token: 0x04012657 RID: 75351
		EMovieSceneEvaluationType_MAX
	}
}
