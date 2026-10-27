using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004FF RID: 1279
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.ERigUnitDebugPointMode")]
	public enum ERigUnitDebugPointMode : byte
	{
		// Token: 0x0400209F RID: 8351
		Point,
		// Token: 0x040020A0 RID: 8352
		Vector,
		// Token: 0x040020A1 RID: 8353
		Max,
		// Token: 0x040020A2 RID: 8354
		ERigUnitDebugPointMode_MAX
	}
}
