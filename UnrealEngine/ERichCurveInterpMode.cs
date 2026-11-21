using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001F5 RID: 501
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERichCurveInterpMode")]
	public enum ERichCurveInterpMode
	{
		// Token: 0x04000C78 RID: 3192
		RCIM_Linear,
		// Token: 0x04000C79 RID: 3193
		RCIM_Constant,
		// Token: 0x04000C7A RID: 3194
		RCIM_Cubic,
		// Token: 0x04000C7B RID: 3195
		RCIM_None,
		// Token: 0x04000C7C RID: 3196
		RCIM_MAX
	}
}
