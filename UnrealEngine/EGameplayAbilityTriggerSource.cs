using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001338 RID: 4920
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EGameplayAbilityTriggerSource")]
	public enum EGameplayAbilityTriggerSource
	{
		// Token: 0x04009ABA RID: 39610
		GameplayEvent,
		// Token: 0x04009ABB RID: 39611
		OwnedTagAdded,
		// Token: 0x04009ABC RID: 39612
		OwnedTagPresent,
		// Token: 0x04009ABD RID: 39613
		EGameplayAbilityTriggerSource_MAX
	}
}
