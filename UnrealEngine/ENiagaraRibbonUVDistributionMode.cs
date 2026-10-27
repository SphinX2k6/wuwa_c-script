using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024FE RID: 9470
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraRibbonUVDistributionMode")]
	public enum ENiagaraRibbonUVDistributionMode
	{
		// Token: 0x04012E52 RID: 77394
		ScaledUniformly,
		// Token: 0x04012E53 RID: 77395
		ScaledUsingRibbonSegmentLength,
		// Token: 0x04012E54 RID: 77396
		TiledOverRibbonLength,
		// Token: 0x04012E55 RID: 77397
		ENiagaraRibbonUVDistributionMode_MAX
	}
}
