using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001342 RID: 4930
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EGameplayEffectStackingExpirationPolicy")]
	public enum EGameplayEffectStackingExpirationPolicy : byte
	{
		// Token: 0x04009AEA RID: 39658
		ClearEntireStack,
		// Token: 0x04009AEB RID: 39659
		RemoveStackNumberAndRefreshDuration,
		// Token: 0x04009AEC RID: 39660
		RefreshDuration,
		// Token: 0x04009AED RID: 39661
		EGameplayEffectStackingExpirationPolicy_MAX
	}
}
