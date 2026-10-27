using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200027F RID: 639
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AkAudio.EKuroSoundEngineThreadPriority")]
	public enum EKuroSoundEngineThreadPriority
	{
		// Token: 0x04000D98 RID: 3480
		Normal,
		// Token: 0x04000D99 RID: 3481
		AboveNormal,
		// Token: 0x04000D9A RID: 3482
		BelowNormal,
		// Token: 0x04000D9B RID: 3483
		Highest,
		// Token: 0x04000D9C RID: 3484
		Lowest,
		// Token: 0x04000D9D RID: 3485
		SlightlyBelowNormal,
		// Token: 0x04000D9E RID: 3486
		TimeCritical,
		// Token: 0x04000D9F RID: 3487
		EKuroSoundEngineThreadPriority_MAX
	}
}
