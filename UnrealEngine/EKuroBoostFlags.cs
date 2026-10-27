using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A15 RID: 6677
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroPerformance.EKuroBoostFlags")]
	public enum EKuroBoostFlags
	{
		// Token: 0x0400D59B RID: 54683
		Boost_None,
		// Token: 0x0400D59C RID: 54684
		Boost_CPU,
		// Token: 0x0400D59D RID: 54685
		Boost_CPUMemory,
		// Token: 0x0400D59E RID: 54686
		Boost_GPU = 4,
		// Token: 0x0400D59F RID: 54687
		Boost_GPUMemory = 8,
		// Token: 0x0400D5A0 RID: 54688
		Boost_All = 15,
		// Token: 0x0400D5A1 RID: 54689
		Boost_MAX
	}
}
