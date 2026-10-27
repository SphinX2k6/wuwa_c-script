using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001BA RID: 442
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EPathFollowingResult")]
	public enum EPathFollowingResult
	{
		// Token: 0x0400084E RID: 2126
		Success,
		// Token: 0x0400084F RID: 2127
		Blocked,
		// Token: 0x04000850 RID: 2128
		OffPath,
		// Token: 0x04000851 RID: 2129
		Aborted,
		// Token: 0x04000852 RID: 2130
		Skipped_DEPRECATED,
		// Token: 0x04000853 RID: 2131
		Invalid,
		// Token: 0x04000854 RID: 2132
		EPathFollowingResult_MAX
	}
}
