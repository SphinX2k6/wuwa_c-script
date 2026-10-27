using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002473 RID: 9331
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/NavigationSystem.ERecastPartitioning")]
	public enum ERecastPartitioning
	{
		// Token: 0x04012A4E RID: 76366
		Monotone,
		// Token: 0x04012A4F RID: 76367
		Watershed,
		// Token: 0x04012A50 RID: 76368
		ChunkyMonotone,
		// Token: 0x04012A51 RID: 76369
		ERecastPartitioning_MAX
	}
}
