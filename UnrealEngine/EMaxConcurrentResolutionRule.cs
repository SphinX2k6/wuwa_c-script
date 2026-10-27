using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AC7 RID: 2759
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMaxConcurrentResolutionRule")]
	public enum EMaxConcurrentResolutionRule
	{
		// Token: 0x04004A68 RID: 19048
		PreventNew,
		// Token: 0x04004A69 RID: 19049
		StopOldest,
		// Token: 0x04004A6A RID: 19050
		StopFarthestThenPreventNew,
		// Token: 0x04004A6B RID: 19051
		StopFarthestThenOldest,
		// Token: 0x04004A6C RID: 19052
		StopLowestPriority,
		// Token: 0x04004A6D RID: 19053
		StopQuietest,
		// Token: 0x04004A6E RID: 19054
		StopLowestPriorityThenPreventNew,
		// Token: 0x04004A6F RID: 19055
		Count,
		// Token: 0x04004A70 RID: 19056
		EMaxConcurrentResolutionRule_MAX
	}
}
