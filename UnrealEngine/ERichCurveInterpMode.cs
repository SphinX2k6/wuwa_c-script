using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B49 RID: 2889
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERichCurveInterpMode")]
	public enum ERichCurveInterpMode
	{
		// Token: 0x04004F92 RID: 20370
		RCIM_Linear,
		// Token: 0x04004F93 RID: 20371
		RCIM_Constant,
		// Token: 0x04004F94 RID: 20372
		RCIM_Cubic,
		// Token: 0x04004F95 RID: 20373
		RCIM_None,
		// Token: 0x04004F96 RID: 20374
		RCIM_MAX
	}
}
