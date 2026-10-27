using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000323 RID: 803
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.ERBFFunctionType")]
	public enum ERBFFunctionType : byte
	{
		// Token: 0x04001332 RID: 4914
		Gaussian,
		// Token: 0x04001333 RID: 4915
		Exponential,
		// Token: 0x04001334 RID: 4916
		Linear,
		// Token: 0x04001335 RID: 4917
		Cubic,
		// Token: 0x04001336 RID: 4918
		Quintic,
		// Token: 0x04001337 RID: 4919
		DefaultFunction,
		// Token: 0x04001338 RID: 4920
		ERBFFunctionType_MAX
	}
}
