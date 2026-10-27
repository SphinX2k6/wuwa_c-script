using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002260 RID: 8800
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MagtModule.EMagtAPWorkloadAdvice")]
	public enum EMagtAPWorkloadAdvice : byte
	{
		// Token: 0x04011D8C RID: 73100
		None,
		// Token: 0x04011D8D RID: 73101
		Free,
		// Token: 0x04011D8E RID: 73102
		Upgrade,
		// Token: 0x04011D8F RID: 73103
		Downgrade,
		// Token: 0x04011D90 RID: 73104
		CBound,
		// Token: 0x04011D91 RID: 73105
		GBound,
		// Token: 0x04011D92 RID: 73106
		CGBound,
		// Token: 0x04011D93 RID: 73107
		EMagtAPWorkloadAdvice_MAX
	}
}
