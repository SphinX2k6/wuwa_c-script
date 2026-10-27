using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200185C RID: 6236
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroGameBudget.EGameBudgetBlueprintGroup")]
	public enum EGameBudgetBlueprintGroup : byte
	{
		// Token: 0x0400C78C RID: 51084
		None,
		// Token: 0x0400C78D RID: 51085
		DisableTick,
		// Token: 0x0400C78E RID: 51086
		Singleton,
		// Token: 0x0400C78F RID: 51087
		SceneActor,
		// Token: 0x0400C790 RID: 51088
		FarActor = 7,
		// Token: 0x0400C791 RID: 51089
		SuperFarActor = 4,
		// Token: 0x0400C792 RID: 51090
		DynamicPhysicsInteractionActor,
		// Token: 0x0400C793 RID: 51091
		StaticPhysicInteractionActor,
		// Token: 0x0400C794 RID: 51092
		HighPriorityPhysicInteractionActor = 8,
		// Token: 0x0400C795 RID: 51093
		SparseGridPhysicsInteractionActor = 10,
		// Token: 0x0400C796 RID: 51094
		SpecialBlueprintActor = 9,
		// Token: 0x0400C797 RID: 51095
		Max = 11,
		// Token: 0x0400C798 RID: 51096
		EGameBudgetBlueprintGroup_MAX
	}
}
