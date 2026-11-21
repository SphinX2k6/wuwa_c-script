using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000776 RID: 1910
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MovieScene.EMovieScenePositionType")]
	public enum EMovieScenePositionType : byte
	{
		// Token: 0x040046B0 RID: 18096
		Frame,
		// Token: 0x040046B1 RID: 18097
		Time,
		// Token: 0x040046B2 RID: 18098
		MarkedFrame,
		// Token: 0x040046B3 RID: 18099
		EMovieScenePositionType_MAX
	}
}
