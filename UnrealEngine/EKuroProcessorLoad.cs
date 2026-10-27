using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A19 RID: 6681
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroPerformance.EKuroProcessorLoad")]
	public enum EKuroProcessorLoad
	{
		// Token: 0x0400D5B9 RID: 54713
		PL_UnKnown = -1,
		// Token: 0x0400D5BA RID: 54714
		PL_Low,
		// Token: 0x0400D5BB RID: 54715
		PL_Medium,
		// Token: 0x0400D5BC RID: 54716
		PL_High,
		// Token: 0x0400D5BD RID: 54717
		PL_Max,
		// Token: 0x0400D5BE RID: 54718
		PL_MAX
	}
}
