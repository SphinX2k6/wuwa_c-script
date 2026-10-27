using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A18 RID: 6680
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroPerformance.EKuroPerformanceAdvice")]
	public enum EKuroPerformanceAdvice
	{
		// Token: 0x0400D5AF RID: 54703
		Pa_Error = -2,
		// Token: 0x0400D5B0 RID: 54704
		Pa_None,
		// Token: 0x0400D5B1 RID: 54705
		Pa_Free,
		// Token: 0x0400D5B2 RID: 54706
		Pa_CBound,
		// Token: 0x0400D5B3 RID: 54707
		Pa_GBound,
		// Token: 0x0400D5B4 RID: 54708
		Pa_CGBound,
		// Token: 0x0400D5B5 RID: 54709
		Pa_Downgrade,
		// Token: 0x0400D5B6 RID: 54710
		Pa_Upgrade,
		// Token: 0x0400D5B7 RID: 54711
		Pa_MAX
	}
}
