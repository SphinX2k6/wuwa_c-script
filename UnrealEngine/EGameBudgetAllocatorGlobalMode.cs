using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200185A RID: 6234
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroGameBudget.EGameBudgetAllocatorGlobalMode")]
	public enum EGameBudgetAllocatorGlobalMode : byte
	{
		// Token: 0x0400C782 RID: 51074
		GBA_GlobalMode_Normal,
		// Token: 0x0400C783 RID: 51075
		GBA_GlobalMode_Fighting,
		// Token: 0x0400C784 RID: 51076
		GBA_GlobalMode_Cutscene,
		// Token: 0x0400C785 RID: 51077
		GBA_GlobalMode_Num,
		// Token: 0x0400C786 RID: 51078
		GBA_GlobalMode_MAX
	}
}
