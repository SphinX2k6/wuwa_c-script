using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001331 RID: 4913
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EGameplayAbilityActivationMode")]
	public enum EGameplayAbilityActivationMode
	{
		// Token: 0x04009A8E RID: 39566
		Authority,
		// Token: 0x04009A8F RID: 39567
		NonAuthority,
		// Token: 0x04009A90 RID: 39568
		Predicting,
		// Token: 0x04009A91 RID: 39569
		Confirmed,
		// Token: 0x04009A92 RID: 39570
		Rejected,
		// Token: 0x04009A93 RID: 39571
		EGameplayAbilityActivationMode_MAX
	}
}
