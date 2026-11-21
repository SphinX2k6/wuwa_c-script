using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002BF RID: 703
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EGameplayAbilityTriggerSource")]
	public enum EGameplayAbilityTriggerSource
	{
		// Token: 0x04001EB6 RID: 7862
		GameplayEvent,
		// Token: 0x04001EB7 RID: 7863
		OwnedTagAdded,
		// Token: 0x04001EB8 RID: 7864
		OwnedTagPresent,
		// Token: 0x04001EB9 RID: 7865
		EGameplayAbilityTriggerSource_MAX
	}
}
