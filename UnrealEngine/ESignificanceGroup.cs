using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000396 RID: 918
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroGameBudget.ESignificanceGroup")]
	public enum ESignificanceGroup : byte
	{
		// Token: 0x04002606 RID: 9734
		Idle,
		// Token: 0x04002607 RID: 9735
		Low,
		// Token: 0x04002608 RID: 9736
		Middle,
		// Token: 0x04002609 RID: 9737
		High,
		// Token: 0x0400260A RID: 9738
		Critical,
		// Token: 0x0400260B RID: 9739
		ESignificanceGroup_MAX
	}
}
