using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001343 RID: 4931
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EGameplayEffectStackingPeriodPolicy")]
	public enum EGameplayEffectStackingPeriodPolicy : byte
	{
		// Token: 0x04009AEF RID: 39663
		ResetOnSuccessfulApplication,
		// Token: 0x04009AF0 RID: 39664
		NeverReset,
		// Token: 0x04009AF1 RID: 39665
		EGameplayEffectStackingPeriodPolicy_MAX
	}
}
