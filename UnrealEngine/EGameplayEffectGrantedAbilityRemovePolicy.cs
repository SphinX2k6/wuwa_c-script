using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200133D RID: 4925
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EGameplayEffectGrantedAbilityRemovePolicy")]
	public enum EGameplayEffectGrantedAbilityRemovePolicy : byte
	{
		// Token: 0x04009AD2 RID: 39634
		CancelAbilityImmediately,
		// Token: 0x04009AD3 RID: 39635
		RemoveAbilityOnEnd,
		// Token: 0x04009AD4 RID: 39636
		DoNothing,
		// Token: 0x04009AD5 RID: 39637
		EGameplayEffectGrantedAbilityRemovePolicy_MAX
	}
}
