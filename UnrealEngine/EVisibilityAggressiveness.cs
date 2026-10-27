using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BB4 RID: 2996
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EVisibilityAggressiveness")]
	public enum EVisibilityAggressiveness
	{
		// Token: 0x0400528E RID: 21134
		VIS_LeastAggressive,
		// Token: 0x0400528F RID: 21135
		VIS_ModeratelyAggressive,
		// Token: 0x04005290 RID: 21136
		VIS_MostAggressive,
		// Token: 0x04005291 RID: 21137
		VIS_Max,
		// Token: 0x04005292 RID: 21138
		VIS_MAX
	}
}
