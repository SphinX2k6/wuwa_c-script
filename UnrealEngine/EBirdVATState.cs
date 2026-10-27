using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A69 RID: 6761
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EBirdVATState")]
	public enum EBirdVATState : byte
	{
		// Token: 0x0400D8BF RID: 55487
		Idle,
		// Token: 0x0400D8C0 RID: 55488
		Walk,
		// Token: 0x0400D8C1 RID: 55489
		Jump,
		// Token: 0x0400D8C2 RID: 55490
		TakeOff,
		// Token: 0x0400D8C3 RID: 55491
		Flying,
		// Token: 0x0400D8C4 RID: 55492
		Gliding,
		// Token: 0x0400D8C5 RID: 55493
		Landing,
		// Token: 0x0400D8C6 RID: 55494
		EBirdVATState_MAX
	}
}
