using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001F4 RID: 500
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERichCurveExtrapolation")]
	public enum ERichCurveExtrapolation
	{
		// Token: 0x04000C70 RID: 3184
		RCCE_Cycle,
		// Token: 0x04000C71 RID: 3185
		RCCE_CycleWithOffset,
		// Token: 0x04000C72 RID: 3186
		RCCE_Oscillate,
		// Token: 0x04000C73 RID: 3187
		RCCE_Linear,
		// Token: 0x04000C74 RID: 3188
		RCCE_Constant,
		// Token: 0x04000C75 RID: 3189
		RCCE_None,
		// Token: 0x04000C76 RID: 3190
		RCCE_MAX
	}
}
