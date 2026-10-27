using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000175 RID: 373
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EBTFlowAbortMode")]
	public enum EBTFlowAbortMode
	{
		// Token: 0x0400066C RID: 1644
		None,
		// Token: 0x0400066D RID: 1645
		LowerPriority,
		// Token: 0x0400066E RID: 1646
		Self,
		// Token: 0x0400066F RID: 1647
		Both,
		// Token: 0x04000670 RID: 1648
		EBTFlowAbortMode_MAX
	}
}
