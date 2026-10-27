using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AE1 RID: 2785
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ENavDataGatheringMode")]
	public enum ENavDataGatheringMode : byte
	{
		// Token: 0x04004B22 RID: 19234
		Default,
		// Token: 0x04004B23 RID: 19235
		Instant,
		// Token: 0x04004B24 RID: 19236
		Lazy,
		// Token: 0x04004B25 RID: 19237
		ENavDataGatheringMode_MAX
	}
}
