using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000394 RID: 916
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroGameBudget.EGameBudgetAllocatorGlobalMode")]
	public enum EGameBudgetAllocatorGlobalMode : byte
	{
		// Token: 0x040025F1 RID: 9713
		GBA_GlobalMode_Normal,
		// Token: 0x040025F2 RID: 9714
		GBA_GlobalMode_Fighting,
		// Token: 0x040025F3 RID: 9715
		GBA_GlobalMode_Cutscene,
		// Token: 0x040025F4 RID: 9716
		GBA_GlobalMode_Num,
		// Token: 0x040025F5 RID: 9717
		GBA_GlobalMode_MAX
	}
}
