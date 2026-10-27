using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000322 RID: 802
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.ERBFDistanceMethod")]
	public enum ERBFDistanceMethod : byte
	{
		// Token: 0x0400132B RID: 4907
		Euclidean,
		// Token: 0x0400132C RID: 4908
		Quaternion,
		// Token: 0x0400132D RID: 4909
		SwingAngle,
		// Token: 0x0400132E RID: 4910
		TwistAngle,
		// Token: 0x0400132F RID: 4911
		DefaultMethod,
		// Token: 0x04001330 RID: 4912
		ERBFDistanceMethod_MAX
	}
}
