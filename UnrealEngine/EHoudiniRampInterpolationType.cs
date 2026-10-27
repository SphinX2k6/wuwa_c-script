using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001495 RID: 5269
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineRuntime.EHoudiniRampInterpolationType")]
	public enum EHoudiniRampInterpolationType : sbyte
	{
		// Token: 0x0400A4DC RID: 42204
		InValid = -1,
		// Token: 0x0400A4DD RID: 42205
		CONSTANT,
		// Token: 0x0400A4DE RID: 42206
		LINEAR,
		// Token: 0x0400A4DF RID: 42207
		CATMULL_ROM,
		// Token: 0x0400A4E0 RID: 42208
		MONOTONE_CUBIC,
		// Token: 0x0400A4E1 RID: 42209
		BEZIER,
		// Token: 0x0400A4E2 RID: 42210
		BSPLINE,
		// Token: 0x0400A4E3 RID: 42211
		HERMITE,
		// Token: 0x0400A4E4 RID: 42212
		EHoudiniRampInterpolationType_MAX
	}
}
