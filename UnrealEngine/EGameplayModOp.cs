using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002C0 RID: 704
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EGameplayModOp")]
	public enum EGameplayModOp
	{
		// Token: 0x04001EBB RID: 7867
		Additive,
		// Token: 0x04001EBC RID: 7868
		Multiplicitive,
		// Token: 0x04001EBD RID: 7869
		AdvancedMultiply,
		// Token: 0x04001EBE RID: 7870
		Override,
		// Token: 0x04001EBF RID: 7871
		Max,
		// Token: 0x04001EC0 RID: 7872
		EGameplayModOp_MAX
	}
}
