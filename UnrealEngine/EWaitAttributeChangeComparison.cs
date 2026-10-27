using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200134A RID: 4938
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.EWaitAttributeChangeComparison")]
	public enum EWaitAttributeChangeComparison
	{
		// Token: 0x04009B1C RID: 39708
		None,
		// Token: 0x04009B1D RID: 39709
		GreaterThan,
		// Token: 0x04009B1E RID: 39710
		LessThan,
		// Token: 0x04009B1F RID: 39711
		GreaterThanOrEqualTo,
		// Token: 0x04009B20 RID: 39712
		LessThanOrEqualTo,
		// Token: 0x04009B21 RID: 39713
		NotEqualTo,
		// Token: 0x04009B22 RID: 39714
		ExactlyEqualTo,
		// Token: 0x04009B23 RID: 39715
		MAX
	}
}
