using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A66 RID: 2662
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EEvaluatorMode")]
	public enum EEvaluatorMode
	{
		// Token: 0x04004776 RID: 18294
		EM_Standard,
		// Token: 0x04004777 RID: 18295
		EM_Freeze,
		// Token: 0x04004778 RID: 18296
		EM_DelayedFreeze,
		// Token: 0x04004779 RID: 18297
		EM_MAX
	}
}
