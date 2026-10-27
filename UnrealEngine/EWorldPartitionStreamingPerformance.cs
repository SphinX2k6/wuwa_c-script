using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BC1 RID: 3009
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EWorldPartitionStreamingPerformance")]
	public enum EWorldPartitionStreamingPerformance : byte
	{
		// Token: 0x040052CF RID: 21199
		Good,
		// Token: 0x040052D0 RID: 21200
		Slow,
		// Token: 0x040052D1 RID: 21201
		Critical,
		// Token: 0x040052D2 RID: 21202
		EWorldPartitionStreamingPerformance_MAX
	}
}
