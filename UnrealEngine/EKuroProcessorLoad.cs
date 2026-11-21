using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000496 RID: 1174
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroPerformance.EKuroProcessorLoad")]
	public enum EKuroProcessorLoad
	{
		// Token: 0x04002EDB RID: 11995
		PL_UnKnown = -1,
		// Token: 0x04002EDC RID: 11996
		PL_Low,
		// Token: 0x04002EDD RID: 11997
		PL_Medium,
		// Token: 0x04002EDE RID: 11998
		PL_High,
		// Token: 0x04002EDF RID: 11999
		PL_Max,
		// Token: 0x04002EE0 RID: 12000
		PL_MAX
	}
}
