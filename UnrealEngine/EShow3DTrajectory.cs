using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002321 RID: 8993
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MovieSceneTracks.EShow3DTrajectory")]
	public enum EShow3DTrajectory : byte
	{
		// Token: 0x0401228A RID: 74378
		EST_OnlyWhenSelected,
		// Token: 0x0401228B RID: 74379
		EST_Always,
		// Token: 0x0401228C RID: 74380
		EST_Never,
		// Token: 0x0401228D RID: 74381
		EST_MAX
	}
}
