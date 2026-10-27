using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002471 RID: 9329
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/NavigationSystem.ENavCostDisplay")]
	public enum ENavCostDisplay
	{
		// Token: 0x04012A44 RID: 76356
		TotalCost,
		// Token: 0x04012A45 RID: 76357
		HeuristicOnly,
		// Token: 0x04012A46 RID: 76358
		RealCostOnly,
		// Token: 0x04012A47 RID: 76359
		ENavCostDisplay_MAX
	}
}
