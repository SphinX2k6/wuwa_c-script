using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004F3 RID: 1267
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ControlRig.ERBFKernelType")]
	public enum ERBFKernelType : byte
	{
		// Token: 0x04002053 RID: 8275
		Gaussian,
		// Token: 0x04002054 RID: 8276
		Exponential,
		// Token: 0x04002055 RID: 8277
		Linear,
		// Token: 0x04002056 RID: 8278
		Cubic,
		// Token: 0x04002057 RID: 8279
		Quintic,
		// Token: 0x04002058 RID: 8280
		ERBFKernelType_MAX
	}
}
