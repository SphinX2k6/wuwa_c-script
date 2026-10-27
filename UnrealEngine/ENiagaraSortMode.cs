using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002506 RID: 9478
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraSortMode")]
	public enum ENiagaraSortMode : byte
	{
		// Token: 0x04012E8D RID: 77453
		None,
		// Token: 0x04012E8E RID: 77454
		ViewDepth,
		// Token: 0x04012E8F RID: 77455
		ViewDistance,
		// Token: 0x04012E90 RID: 77456
		CustomAscending,
		// Token: 0x04012E91 RID: 77457
		CustomDecending,
		// Token: 0x04012E92 RID: 77458
		ENiagaraSortMode_MAX
	}
}
