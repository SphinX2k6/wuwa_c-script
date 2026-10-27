using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A10 RID: 10768
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EBlueprintComponentDataCookingMethod")]
	public enum EBlueprintComponentDataCookingMethod
	{
		// Token: 0x04015D84 RID: 89476
		Disabled,
		// Token: 0x04015D85 RID: 89477
		AllBlueprints,
		// Token: 0x04015D86 RID: 89478
		EnabledBlueprintsOnly,
		// Token: 0x04015D87 RID: 89479
		EBlueprintComponentDataCookingMethod_MAX
	}
}
