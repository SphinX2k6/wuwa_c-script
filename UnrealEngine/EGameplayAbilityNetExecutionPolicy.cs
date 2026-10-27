using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001334 RID: 4916
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EGameplayAbilityNetExecutionPolicy")]
	public enum EGameplayAbilityNetExecutionPolicy
	{
		// Token: 0x04009AA5 RID: 39589
		LocalPredicted,
		// Token: 0x04009AA6 RID: 39590
		LocalOnly,
		// Token: 0x04009AA7 RID: 39591
		ServerInitiated,
		// Token: 0x04009AA8 RID: 39592
		ServerOnly,
		// Token: 0x04009AA9 RID: 39593
		EGameplayAbilityNetExecutionPolicy_MAX
	}
}
