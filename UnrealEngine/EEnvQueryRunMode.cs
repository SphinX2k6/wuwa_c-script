using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200017B RID: 379
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EEnvQueryRunMode")]
	public enum EEnvQueryRunMode
	{
		// Token: 0x0400068A RID: 1674
		SingleResult,
		// Token: 0x0400068B RID: 1675
		RandomBest5Pct,
		// Token: 0x0400068C RID: 1676
		RandomBest25Pct,
		// Token: 0x0400068D RID: 1677
		AllMatching,
		// Token: 0x0400068E RID: 1678
		EEnvQueryRunMode_MAX
	}
}
