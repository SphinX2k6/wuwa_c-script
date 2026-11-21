using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000395 RID: 917
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroGameBudget.EGameBudgetBlueprintGroup")]
	public enum EGameBudgetBlueprintGroup : byte
	{
		// Token: 0x040025F7 RID: 9719
		None,
		// Token: 0x040025F8 RID: 9720
		DisableTick,
		// Token: 0x040025F9 RID: 9721
		Singleton,
		// Token: 0x040025FA RID: 9722
		SceneActor,
		// Token: 0x040025FB RID: 9723
		FarActor = 7,
		// Token: 0x040025FC RID: 9724
		SuperFarActor = 4,
		// Token: 0x040025FD RID: 9725
		DynamicPhysicsInteractionActor,
		// Token: 0x040025FE RID: 9726
		StaticPhysicInteractionActor,
		// Token: 0x040025FF RID: 9727
		HighPriorityPhysicInteractionActor = 8,
		// Token: 0x04002600 RID: 9728
		SparseGridPhysicsInteractionActor = 10,
		// Token: 0x04002601 RID: 9729
		SpecialBlueprintActor = 9,
		// Token: 0x04002602 RID: 9730
		ScreenDecalActor = 11,
		// Token: 0x04002603 RID: 9731
		Max,
		// Token: 0x04002604 RID: 9732
		EGameBudgetBlueprintGroup_MAX
	}
}
