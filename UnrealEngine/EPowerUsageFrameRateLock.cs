using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015A9 RID: 5545
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/IOSRuntimeSettings.EPowerUsageFrameRateLock")]
	public enum EPowerUsageFrameRateLock : byte
	{
		// Token: 0x0400AD6B RID: 44395
		PUFRL_None,
		// Token: 0x0400AD6C RID: 44396
		PUFRL_20 = 20,
		// Token: 0x0400AD6D RID: 44397
		PUFRL_30 = 30,
		// Token: 0x0400AD6E RID: 44398
		PUFRL_60 = 60,
		// Token: 0x0400AD6F RID: 44399
		PUFRL_MAX
	}
}
