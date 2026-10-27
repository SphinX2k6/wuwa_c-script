using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001333 RID: 4915
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EGameplayAbilityInstancingPolicy")]
	public enum EGameplayAbilityInstancingPolicy
	{
		// Token: 0x04009AA0 RID: 39584
		NonInstanced,
		// Token: 0x04009AA1 RID: 39585
		InstancedPerActor,
		// Token: 0x04009AA2 RID: 39586
		InstancedPerExecution,
		// Token: 0x04009AA3 RID: 39587
		EGameplayAbilityInstancingPolicy_MAX
	}
}
