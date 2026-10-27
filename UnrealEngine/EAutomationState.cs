using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000413 RID: 1043
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AutomationController.EAutomationState")]
	public enum EAutomationState : byte
	{
		// Token: 0x0400195C RID: 6492
		NotRun,
		// Token: 0x0400195D RID: 6493
		InProcess,
		// Token: 0x0400195E RID: 6494
		Fail,
		// Token: 0x0400195F RID: 6495
		Success,
		// Token: 0x04001960 RID: 6496
		NotEnoughParticipants,
		// Token: 0x04001961 RID: 6497
		EAutomationState_MAX
	}
}
