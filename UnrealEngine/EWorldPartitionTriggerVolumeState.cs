using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200020B RID: 523
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EWorldPartitionTriggerVolumeState")]
	public enum EWorldPartitionTriggerVolumeState : byte
	{
		// Token: 0x04000D1F RID: 3359
		Default,
		// Token: 0x04000D20 RID: 3360
		StreamingSourceIn,
		// Token: 0x04000D21 RID: 3361
		StreamingSourceOut,
		// Token: 0x04000D22 RID: 3362
		EWorldPartitionTriggerVolumeState_MAX
	}
}
