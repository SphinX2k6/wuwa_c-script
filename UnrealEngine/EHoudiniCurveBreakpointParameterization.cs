using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001480 RID: 5248
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniCurveBreakpointParameterization")]
	public enum EHoudiniCurveBreakpointParameterization : sbyte
	{
		// Token: 0x0400A433 RID: 42035
		Invalid = -1,
		// Token: 0x0400A434 RID: 42036
		Uniform,
		// Token: 0x0400A435 RID: 42037
		Chord,
		// Token: 0x0400A436 RID: 42038
		Centripetal,
		// Token: 0x0400A437 RID: 42039
		EHoudiniCurveBreakpointParameterization_MAX
	}
}
