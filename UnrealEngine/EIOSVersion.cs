using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015A8 RID: 5544
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/IOSRuntimeSettings.EIOSVersion")]
	public enum EIOSVersion : byte
	{
		// Token: 0x0400AD64 RID: 44388
		IOS_12 = 12,
		// Token: 0x0400AD65 RID: 44389
		IOS_13,
		// Token: 0x0400AD66 RID: 44390
		IOS_14,
		// Token: 0x0400AD67 RID: 44391
		IOS_15,
		// Token: 0x0400AD68 RID: 44392
		IOS_16,
		// Token: 0x0400AD69 RID: 44393
		IOS_MAX
	}
}
