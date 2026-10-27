using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000325 RID: 805
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.ERBFNormalizeMethod")]
	public enum ERBFNormalizeMethod : byte
	{
		// Token: 0x0400133E RID: 4926
		OnlyNormalizeAboveOne,
		// Token: 0x0400133F RID: 4927
		AlwaysNormalize,
		// Token: 0x04001340 RID: 4928
		NormalizeWithinMedian,
		// Token: 0x04001341 RID: 4929
		NoNormalization,
		// Token: 0x04001342 RID: 4930
		ERBFNormalizeMethod_MAX
	}
}
