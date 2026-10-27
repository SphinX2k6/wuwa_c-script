using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A9C RID: 2716
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ELerpInterpolationMode")]
	public enum ELerpInterpolationMode
	{
		// Token: 0x04004905 RID: 18693
		QuatInterp,
		// Token: 0x04004906 RID: 18694
		EulerInterp,
		// Token: 0x04004907 RID: 18695
		DualQuatInterp,
		// Token: 0x04004908 RID: 18696
		ELerpInterpolationMode_MAX
	}
}
