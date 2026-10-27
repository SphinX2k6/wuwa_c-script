using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000ADF RID: 2783
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMovementMode")]
	public enum EMovementMode
	{
		// Token: 0x04004B13 RID: 19219
		MOVE_None,
		// Token: 0x04004B14 RID: 19220
		MOVE_Walking,
		// Token: 0x04004B15 RID: 19221
		MOVE_NavWalking,
		// Token: 0x04004B16 RID: 19222
		MOVE_Falling,
		// Token: 0x04004B17 RID: 19223
		MOVE_Swimming,
		// Token: 0x04004B18 RID: 19224
		MOVE_Flying,
		// Token: 0x04004B19 RID: 19225
		MOVE_Custom,
		// Token: 0x04004B1A RID: 19226
		MOVE_WalkingOnAir,
		// Token: 0x04004B1B RID: 19227
		MOVE_MAX
	}
}
