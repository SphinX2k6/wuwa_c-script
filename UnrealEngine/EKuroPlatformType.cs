using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020019BE RID: 6590
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroMaterialPerformanceWatchDog.EKuroPlatformType")]
	public enum EKuroPlatformType : byte
	{
		// Token: 0x0400D3C7 RID: 54215
		Unknown,
		// Token: 0x0400D3C8 RID: 54216
		PC,
		// Token: 0x0400D3C9 RID: 54217
		Android,
		// Token: 0x0400D3CA RID: 54218
		iOS,
		// Token: 0x0400D3CB RID: 54219
		PS5,
		// Token: 0x0400D3CC RID: 54220
		EKuroPlatformType_MAX
	}
}
