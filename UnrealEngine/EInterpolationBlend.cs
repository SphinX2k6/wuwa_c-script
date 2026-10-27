using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200031B RID: 795
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.EInterpolationBlend")]
	public enum EInterpolationBlend
	{
		// Token: 0x04001304 RID: 4868
		Linear,
		// Token: 0x04001305 RID: 4869
		Cubic,
		// Token: 0x04001306 RID: 4870
		Sinusoidal,
		// Token: 0x04001307 RID: 4871
		EaseInOutExponent2,
		// Token: 0x04001308 RID: 4872
		EaseInOutExponent3,
		// Token: 0x04001309 RID: 4873
		EaseInOutExponent4,
		// Token: 0x0400130A RID: 4874
		EaseInOutExponent5,
		// Token: 0x0400130B RID: 4875
		MAX
	}
}
