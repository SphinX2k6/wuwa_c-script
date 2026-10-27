using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A68 RID: 6760
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EBirdGroundLocomotion")]
	public enum EBirdGroundLocomotion : byte
	{
		// Token: 0x0400D8BA RID: 55482
		Idle,
		// Token: 0x0400D8BB RID: 55483
		Walk,
		// Token: 0x0400D8BC RID: 55484
		Jump,
		// Token: 0x0400D8BD RID: 55485
		EBirdGroundLocomotion_MAX
	}
}
