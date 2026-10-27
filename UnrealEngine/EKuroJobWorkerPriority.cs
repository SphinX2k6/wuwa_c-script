using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200027E RID: 638
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.EKuroJobWorkerPriority")]
	public enum EKuroJobWorkerPriority
	{
		// Token: 0x04000D90 RID: 3472
		High = 1279,
		// Token: 0x04000D91 RID: 3473
		Normal = 255,
		// Token: 0x04000D92 RID: 3474
		Default = 255,
		// Token: 0x04000D93 RID: 3475
		BackgroundHigh = 2815,
		// Token: 0x04000D94 RID: 3476
		BackgroundNormal = 2303,
		// Token: 0x04000D95 RID: 3477
		BackgroundLow = 2303,
		// Token: 0x04000D96 RID: 3478
		EKuroJobWorkerPriority_MAX = 2816
	}
}
