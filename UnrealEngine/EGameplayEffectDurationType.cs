using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200133C RID: 4924
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EGameplayEffectDurationType")]
	public enum EGameplayEffectDurationType : byte
	{
		// Token: 0x04009ACD RID: 39629
		Instant,
		// Token: 0x04009ACE RID: 39630
		Infinite,
		// Token: 0x04009ACF RID: 39631
		HasDuration,
		// Token: 0x04009AD0 RID: 39632
		EGameplayEffectDurationType_MAX
	}
}
