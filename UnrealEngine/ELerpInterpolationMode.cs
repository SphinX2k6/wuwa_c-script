using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001E8 RID: 488
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ELerpInterpolationMode")]
	public enum ELerpInterpolationMode
	{
		// Token: 0x04000C10 RID: 3088
		QuatInterp,
		// Token: 0x04000C11 RID: 3089
		EulerInterp,
		// Token: 0x04000C12 RID: 3090
		DualQuatInterp,
		// Token: 0x04000C13 RID: 3091
		ELerpInterpolationMode_MAX
	}
}
