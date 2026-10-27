using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020023C9 RID: 9161
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MovieScene.EMovieSceneKeyInterpolation")]
	public enum EMovieSceneKeyInterpolation : byte
	{
		// Token: 0x04012659 RID: 75353
		Auto,
		// Token: 0x0401265A RID: 75354
		User,
		// Token: 0x0401265B RID: 75355
		Break,
		// Token: 0x0401265C RID: 75356
		Linear,
		// Token: 0x0401265D RID: 75357
		Constant,
		// Token: 0x0401265E RID: 75358
		EMovieSceneKeyInterpolation_MAX
	}
}
