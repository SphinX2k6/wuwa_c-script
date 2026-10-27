using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009CF RID: 2511
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.DistributionParamMode")]
	public enum DistributionParamMode
	{
		// Token: 0x0400437A RID: 17274
		DPM_Normal,
		// Token: 0x0400437B RID: 17275
		DPM_Abs,
		// Token: 0x0400437C RID: 17276
		DPM_Direct,
		// Token: 0x0400437D RID: 17277
		DPM_MAX
	}
}
