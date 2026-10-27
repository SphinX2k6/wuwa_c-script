using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020015A6 RID: 5542
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/IOSRuntimeSettings.EIOSCloudKitSyncStrategy")]
	public enum EIOSCloudKitSyncStrategy : byte
	{
		// Token: 0x0400AD5B RID: 44379
		None,
		// Token: 0x0400AD5C RID: 44380
		OnlyAtGameStart,
		// Token: 0x0400AD5D RID: 44381
		Always,
		// Token: 0x0400AD5E RID: 44382
		EIOSCloudKitSyncStrategy_MAX
	}
}
