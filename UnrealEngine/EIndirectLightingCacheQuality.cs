using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A83 RID: 2691
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EIndirectLightingCacheQuality")]
	public enum EIndirectLightingCacheQuality
	{
		// Token: 0x04004825 RID: 18469
		ILCQ_Off,
		// Token: 0x04004826 RID: 18470
		ILCQ_Point,
		// Token: 0x04004827 RID: 18471
		ILCQ_Volume,
		// Token: 0x04004828 RID: 18472
		ILCQ_MAX
	}
}
