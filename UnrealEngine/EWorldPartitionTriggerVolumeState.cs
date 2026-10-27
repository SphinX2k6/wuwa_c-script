using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BC2 RID: 3010
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EWorldPartitionTriggerVolumeState")]
	public enum EWorldPartitionTriggerVolumeState : byte
	{
		// Token: 0x040052D4 RID: 21204
		Default,
		// Token: 0x040052D5 RID: 21205
		StreamingSourceIn,
		// Token: 0x040052D6 RID: 21206
		StreamingSourceOut,
		// Token: 0x040052D7 RID: 21207
		EWorldPartitionTriggerVolumeState_MAX
	}
}
