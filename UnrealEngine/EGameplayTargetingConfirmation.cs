using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001347 RID: 4935
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EGameplayTargetingConfirmation")]
	public enum EGameplayTargetingConfirmation
	{
		// Token: 0x04009B0C RID: 39692
		Instant,
		// Token: 0x04009B0D RID: 39693
		UserConfirmed,
		// Token: 0x04009B0E RID: 39694
		Custom,
		// Token: 0x04009B0F RID: 39695
		CustomMulti,
		// Token: 0x04009B10 RID: 39696
		EGameplayTargetingConfirmation_MAX
	}
}
