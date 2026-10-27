using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200133F RID: 4927
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EGameplayEffectPeriodInhibitionRemovedPolicy")]
	public enum EGameplayEffectPeriodInhibitionRemovedPolicy : byte
	{
		// Token: 0x04009ADD RID: 39645
		NeverReset,
		// Token: 0x04009ADE RID: 39646
		ResetPeriod,
		// Token: 0x04009ADF RID: 39647
		ExecuteAndResetPeriod,
		// Token: 0x04009AE0 RID: 39648
		EGameplayEffectPeriodInhibitionRemovedPolicy_MAX
	}
}
