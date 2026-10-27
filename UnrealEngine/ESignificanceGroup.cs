using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200185D RID: 6237
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroGameBudget.ESignificanceGroup")]
	public enum ESignificanceGroup : byte
	{
		// Token: 0x0400C79A RID: 51098
		Idle,
		// Token: 0x0400C79B RID: 51099
		Low,
		// Token: 0x0400C79C RID: 51100
		Middle,
		// Token: 0x0400C79D RID: 51101
		High,
		// Token: 0x0400C79E RID: 51102
		Critical,
		// Token: 0x0400C79F RID: 51103
		ESignificanceGroup_MAX
	}
}
