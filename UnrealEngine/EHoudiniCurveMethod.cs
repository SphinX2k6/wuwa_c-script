using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001481 RID: 5249
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniCurveMethod")]
	public enum EHoudiniCurveMethod : sbyte
	{
		// Token: 0x0400A439 RID: 42041
		Invalid = -1,
		// Token: 0x0400A43A RID: 42042
		CVs,
		// Token: 0x0400A43B RID: 42043
		Breakpoints,
		// Token: 0x0400A43C RID: 42044
		Freehand,
		// Token: 0x0400A43D RID: 42045
		EHoudiniCurveMethod_MAX
	}
}
