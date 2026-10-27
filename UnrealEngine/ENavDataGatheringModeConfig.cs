using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AE2 RID: 2786
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ENavDataGatheringModeConfig")]
	public enum ENavDataGatheringModeConfig : byte
	{
		// Token: 0x04004B27 RID: 19239
		Invalid,
		// Token: 0x04004B28 RID: 19240
		Instant,
		// Token: 0x04004B29 RID: 19241
		Lazy,
		// Token: 0x04004B2A RID: 19242
		ENavDataGatheringModeConfig_MAX
	}
}
