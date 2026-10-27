using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001344 RID: 4932
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EGameplayEffectStackingType")]
	public enum EGameplayEffectStackingType : byte
	{
		// Token: 0x04009AF3 RID: 39667
		None,
		// Token: 0x04009AF4 RID: 39668
		AggregateBySource,
		// Token: 0x04009AF5 RID: 39669
		AggregateByTarget,
		// Token: 0x04009AF6 RID: 39670
		EGameplayEffectStackingType_MAX
	}
}
