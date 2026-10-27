using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200017C RID: 380
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EEnvQueryStatus")]
	public enum EEnvQueryStatus
	{
		// Token: 0x04000690 RID: 1680
		Processing,
		// Token: 0x04000691 RID: 1681
		Success,
		// Token: 0x04000692 RID: 1682
		Failed,
		// Token: 0x04000693 RID: 1683
		Aborted,
		// Token: 0x04000694 RID: 1684
		OwnerLost,
		// Token: 0x04000695 RID: 1685
		MissingParam,
		// Token: 0x04000696 RID: 1686
		EEnvQueryStatus_MAX
	}
}
