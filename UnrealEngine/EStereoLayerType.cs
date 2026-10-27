using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B79 RID: 2937
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EStereoLayerType")]
	public enum EStereoLayerType
	{
		// Token: 0x040050E5 RID: 20709
		SLT_WorldLocked,
		// Token: 0x040050E6 RID: 20710
		SLT_TrackerLocked,
		// Token: 0x040050E7 RID: 20711
		SLT_FaceLocked,
		// Token: 0x040050E8 RID: 20712
		SLT_MAX
	}
}
