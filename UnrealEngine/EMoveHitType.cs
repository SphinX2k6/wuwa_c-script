using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020019DC RID: 6620
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroMovement.EMoveHitType")]
	public enum EMoveHitType : byte
	{
		// Token: 0x0400D483 RID: 54403
		None,
		// Token: 0x0400D484 RID: 54404
		Wall,
		// Token: 0x0400D485 RID: 54405
		Floor,
		// Token: 0x0400D486 RID: 54406
		EMoveHitType_MAX
	}
}
