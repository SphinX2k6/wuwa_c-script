using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001476 RID: 5238
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineEditor.EHoudiniPublicAPICurveBreakpointParameterization")]
	public enum EHoudiniPublicAPICurveBreakpointParameterization : byte
	{
		// Token: 0x0400A3E0 RID: 41952
		Invalid,
		// Token: 0x0400A3E1 RID: 41953
		Uniform,
		// Token: 0x0400A3E2 RID: 41954
		Chord,
		// Token: 0x0400A3E3 RID: 41955
		Centripetal,
		// Token: 0x0400A3E4 RID: 41956
		EHoudiniPublicAPICurveBreakpointParameterization_MAX
	}
}
