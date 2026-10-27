using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001335 RID: 4917
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EGameplayAbilityNetSecurityPolicy")]
	public enum EGameplayAbilityNetSecurityPolicy
	{
		// Token: 0x04009AAB RID: 39595
		ClientOrServer,
		// Token: 0x04009AAC RID: 39596
		ServerOnlyExecution,
		// Token: 0x04009AAD RID: 39597
		ServerOnlyTermination,
		// Token: 0x04009AAE RID: 39598
		ServerOnly,
		// Token: 0x04009AAF RID: 39599
		EGameplayAbilityNetSecurityPolicy_MAX
	}
}
