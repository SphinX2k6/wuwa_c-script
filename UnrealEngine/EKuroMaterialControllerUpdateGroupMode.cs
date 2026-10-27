using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A91 RID: 2705
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EKuroMaterialControllerUpdateGroupMode")]
	public enum EKuroMaterialControllerUpdateGroupMode : byte
	{
		// Token: 0x04004878 RID: 18552
		Default,
		// Token: 0x04004879 RID: 18553
		CharMesh,
		// Token: 0x0400487A RID: 18554
		Custom,
		// Token: 0x0400487B RID: 18555
		EKuroMaterialControllerUpdateGroupMode_MAX
	}
}
