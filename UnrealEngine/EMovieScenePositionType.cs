using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020023CC RID: 9164
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MovieScene.EMovieScenePositionType")]
	public enum EMovieScenePositionType : byte
	{
		// Token: 0x0401266D RID: 75373
		Frame,
		// Token: 0x0401266E RID: 75374
		Time,
		// Token: 0x0401266F RID: 75375
		MarkedFrame,
		// Token: 0x04012670 RID: 75376
		EMovieScenePositionType_MAX
	}
}
