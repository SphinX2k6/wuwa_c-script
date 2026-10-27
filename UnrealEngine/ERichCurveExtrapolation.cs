using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B48 RID: 2888
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERichCurveExtrapolation")]
	public enum ERichCurveExtrapolation
	{
		// Token: 0x04004F8A RID: 20362
		RCCE_Cycle,
		// Token: 0x04004F8B RID: 20363
		RCCE_CycleWithOffset,
		// Token: 0x04004F8C RID: 20364
		RCCE_Oscillate,
		// Token: 0x04004F8D RID: 20365
		RCCE_Linear,
		// Token: 0x04004F8E RID: 20366
		RCCE_Constant,
		// Token: 0x04004F8F RID: 20367
		RCCE_None,
		// Token: 0x04004F90 RID: 20368
		RCCE_MAX
	}
}
