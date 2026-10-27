using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200017D RID: 381
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EEnvQueryTestClamping")]
	public enum EEnvQueryTestClamping
	{
		// Token: 0x04000698 RID: 1688
		None,
		// Token: 0x04000699 RID: 1689
		SpecifiedValue,
		// Token: 0x0400069A RID: 1690
		FilterThreshold,
		// Token: 0x0400069B RID: 1691
		EEnvQueryTestClamping_MAX
	}
}
