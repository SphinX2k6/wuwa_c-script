using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001B7 RID: 439
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EPathExistanceQueryType")]
	public enum EPathExistanceQueryType
	{
		// Token: 0x0400083D RID: 2109
		NavmeshRaycast2D,
		// Token: 0x0400083E RID: 2110
		HierarchicalQuery,
		// Token: 0x0400083F RID: 2111
		RegularPathFinding,
		// Token: 0x04000840 RID: 2112
		EPathExistanceQueryType_MAX
	}
}
