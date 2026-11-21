using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001ED RID: 493
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMovementMode")]
	public enum EMovementMode
	{
		// Token: 0x04000C2E RID: 3118
		MOVE_None,
		// Token: 0x04000C2F RID: 3119
		MOVE_Walking,
		// Token: 0x04000C30 RID: 3120
		MOVE_NavWalking,
		// Token: 0x04000C31 RID: 3121
		MOVE_Falling,
		// Token: 0x04000C32 RID: 3122
		MOVE_Swimming,
		// Token: 0x04000C33 RID: 3123
		MOVE_Flying,
		// Token: 0x04000C34 RID: 3124
		MOVE_Custom,
		// Token: 0x04000C35 RID: 3125
		MOVE_WalkingOnAir,
		// Token: 0x04000C36 RID: 3126
		MOVE_MAX
	}
}
