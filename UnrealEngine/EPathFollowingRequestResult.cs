using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001B9 RID: 441
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EPathFollowingRequestResult")]
	public enum EPathFollowingRequestResult
	{
		// Token: 0x04000849 RID: 2121
		Failed,
		// Token: 0x0400084A RID: 2122
		AlreadyAtGoal,
		// Token: 0x0400084B RID: 2123
		RequestSuccessful,
		// Token: 0x0400084C RID: 2124
		EPathFollowingRequestResult_MAX
	}
}
