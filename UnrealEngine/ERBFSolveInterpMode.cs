using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B3E RID: 2878
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERBFSolveInterpMode")]
	public enum ERBFSolveInterpMode
	{
		// Token: 0x04004F4E RID: 20302
		Linear,
		// Token: 0x04004F4F RID: 20303
		Gaussian1,
		// Token: 0x04004F50 RID: 20304
		Gaussian2,
		// Token: 0x04004F51 RID: 20305
		ThinPlate,
		// Token: 0x04004F52 RID: 20306
		MultiQuadratic,
		// Token: 0x04004F53 RID: 20307
		InverseMultiQuadratic,
		// Token: 0x04004F54 RID: 20308
		ERBFSolveInterpMode_MAX
	}
}
