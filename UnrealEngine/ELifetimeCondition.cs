using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000716 RID: 1814
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/CoreUObject.ELifetimeCondition")]
	public enum ELifetimeCondition
	{
		// Token: 0x04002DDC RID: 11740
		COND_None,
		// Token: 0x04002DDD RID: 11741
		COND_InitialOnly,
		// Token: 0x04002DDE RID: 11742
		COND_OwnerOnly,
		// Token: 0x04002DDF RID: 11743
		COND_SkipOwner,
		// Token: 0x04002DE0 RID: 11744
		COND_SimulatedOnly,
		// Token: 0x04002DE1 RID: 11745
		COND_AutonomousOnly,
		// Token: 0x04002DE2 RID: 11746
		COND_SimulatedOrPhysics,
		// Token: 0x04002DE3 RID: 11747
		COND_InitialOrOwner,
		// Token: 0x04002DE4 RID: 11748
		COND_Custom,
		// Token: 0x04002DE5 RID: 11749
		COND_ReplayOrOwner,
		// Token: 0x04002DE6 RID: 11750
		COND_ReplayOnly,
		// Token: 0x04002DE7 RID: 11751
		COND_SimulatedOnlyNoReplay,
		// Token: 0x04002DE8 RID: 11752
		COND_SimulatedOrPhysicsNoReplay,
		// Token: 0x04002DE9 RID: 11753
		COND_SkipReplay,
		// Token: 0x04002DEA RID: 11754
		COND_Never = 15,
		// Token: 0x04002DEB RID: 11755
		COND_Max,
		// Token: 0x04002DEC RID: 11756
		COND_MAX
	}
}
