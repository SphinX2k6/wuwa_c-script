using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000176 RID: 374
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EBTNodeResult")]
	public enum EBTNodeResult
	{
		// Token: 0x04000672 RID: 1650
		Succeeded,
		// Token: 0x04000673 RID: 1651
		Failed,
		// Token: 0x04000674 RID: 1652
		Aborted,
		// Token: 0x04000675 RID: 1653
		InProgress,
		// Token: 0x04000676 RID: 1654
		EBTNodeResult_MAX
	}
}
