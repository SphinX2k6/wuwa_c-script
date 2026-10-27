using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B4D RID: 2893
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERootMotionFinishVelocityMode")]
	public enum ERootMotionFinishVelocityMode : byte
	{
		// Token: 0x04004FA8 RID: 20392
		MaintainLastRootMotionVelocity,
		// Token: 0x04004FA9 RID: 20393
		SetVelocity,
		// Token: 0x04004FAA RID: 20394
		ClampVelocity,
		// Token: 0x04004FAB RID: 20395
		ERootMotionFinishVelocityMode_MAX
	}
}
