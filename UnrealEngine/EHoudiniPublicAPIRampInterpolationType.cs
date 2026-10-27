using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200147A RID: 5242
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HoudiniEngineEditor.EHoudiniPublicAPIRampInterpolationType")]
	public enum EHoudiniPublicAPIRampInterpolationType : byte
	{
		// Token: 0x0400A3F9 RID: 41977
		InValid,
		// Token: 0x0400A3FA RID: 41978
		CONSTANT,
		// Token: 0x0400A3FB RID: 41979
		LINEAR,
		// Token: 0x0400A3FC RID: 41980
		CATMULL_ROM,
		// Token: 0x0400A3FD RID: 41981
		MONOTONE_CUBIC,
		// Token: 0x0400A3FE RID: 41982
		BEZIER,
		// Token: 0x0400A3FF RID: 41983
		BSPLINE,
		// Token: 0x0400A400 RID: 41984
		HERMITE,
		// Token: 0x0400A401 RID: 41985
		EHoudiniPublicAPIRampInterpolationType_MAX
	}
}
