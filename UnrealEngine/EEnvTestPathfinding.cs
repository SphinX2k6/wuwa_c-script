using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000183 RID: 387
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EEnvTestPathfinding")]
	public enum EEnvTestPathfinding
	{
		// Token: 0x040006B7 RID: 1719
		PathExist,
		// Token: 0x040006B8 RID: 1720
		PathCost,
		// Token: 0x040006B9 RID: 1721
		PathLength,
		// Token: 0x040006BA RID: 1722
		EEnvTestPathfinding_MAX
	}
}
