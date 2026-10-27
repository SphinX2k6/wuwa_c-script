using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A6E RID: 6766
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EFloatLightMovement")]
	public enum EFloatLightMovement : byte
	{
		// Token: 0x0400D8DF RID: 55519
		ENoMovement,
		// Token: 0x0400D8E0 RID: 55520
		ESwing,
		// Token: 0x0400D8E1 RID: 55521
		EJump,
		// Token: 0x0400D8E2 RID: 55522
		EFloatLightMovement_MAX
	}
}
