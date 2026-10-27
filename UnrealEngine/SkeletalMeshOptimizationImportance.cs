using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020010FF RID: 4351
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.SkeletalMeshOptimizationImportance")]
	public enum SkeletalMeshOptimizationImportance
	{
		// Token: 0x04008818 RID: 34840
		SMOI_Off,
		// Token: 0x04008819 RID: 34841
		SMOI_Lowest,
		// Token: 0x0400881A RID: 34842
		SMOI_Low,
		// Token: 0x0400881B RID: 34843
		SMOI_Normal,
		// Token: 0x0400881C RID: 34844
		SMOI_High,
		// Token: 0x0400881D RID: 34845
		SMOI_Highest,
		// Token: 0x0400881E RID: 34846
		SMOI_MAX
	}
}
