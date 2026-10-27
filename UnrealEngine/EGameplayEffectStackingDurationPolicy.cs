using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001341 RID: 4929
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EGameplayEffectStackingDurationPolicy")]
	public enum EGameplayEffectStackingDurationPolicy : byte
	{
		// Token: 0x04009AE6 RID: 39654
		RefreshOnSuccessfulApplication,
		// Token: 0x04009AE7 RID: 39655
		NeverRefresh,
		// Token: 0x04009AE8 RID: 39656
		EGameplayEffectStackingDurationPolicy_MAX
	}
}
