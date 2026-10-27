using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001BB RID: 443
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EPathFollowingStatus")]
	public enum EPathFollowingStatus
	{
		// Token: 0x04000856 RID: 2134
		Idle,
		// Token: 0x04000857 RID: 2135
		Waiting,
		// Token: 0x04000858 RID: 2136
		Paused,
		// Token: 0x04000859 RID: 2137
		Moving,
		// Token: 0x0400085A RID: 2138
		EPathFollowingStatus_MAX
	}
}
