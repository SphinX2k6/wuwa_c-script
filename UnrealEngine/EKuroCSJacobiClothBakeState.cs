using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200177E RID: 6014
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroComputeShader.EKuroCSJacobiClothBakeState")]
	public enum EKuroCSJacobiClothBakeState : byte
	{
		// Token: 0x0400BCE4 RID: 48356
		Unbaked,
		// Token: 0x0400BCE5 RID: 48357
		Merged,
		// Token: 0x0400BCE6 RID: 48358
		EKuroCSJacobiClothBakeState_MAX
	}
}
