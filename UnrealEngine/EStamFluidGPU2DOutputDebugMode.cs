using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001782 RID: 6018
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroComputeShader.EStamFluidGPU2DOutputDebugMode")]
	public enum EStamFluidGPU2DOutputDebugMode : byte
	{
		// Token: 0x0400BCF7 RID: 48375
		Normal,
		// Token: 0x0400BCF8 RID: 48376
		ForceNeutralVelocity,
		// Token: 0x0400BCF9 RID: 48377
		RawVelocity,
		// Token: 0x0400BCFA RID: 48378
		EStamFluidGPU2DOutputDebugMode_MAX
	}
}
