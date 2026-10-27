using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001346 RID: 4934
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EGameplayModOp")]
	public enum EGameplayModOp
	{
		// Token: 0x04009B05 RID: 39685
		Additive,
		// Token: 0x04009B06 RID: 39686
		Multiplicitive,
		// Token: 0x04009B07 RID: 39687
		AdvancedMultiply,
		// Token: 0x04009B08 RID: 39688
		Override,
		// Token: 0x04009B09 RID: 39689
		Max,
		// Token: 0x04009B0A RID: 39690
		EGameplayModOp_MAX
	}
}
