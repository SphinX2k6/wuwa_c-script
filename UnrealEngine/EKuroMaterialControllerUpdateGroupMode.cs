using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001E5 RID: 485
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EKuroMaterialControllerUpdateGroupMode")]
	public enum EKuroMaterialControllerUpdateGroupMode : byte
	{
		// Token: 0x04000C00 RID: 3072
		Default,
		// Token: 0x04000C01 RID: 3073
		CharMesh,
		// Token: 0x04000C02 RID: 3074
		Custom,
		// Token: 0x04000C03 RID: 3075
		EKuroMaterialControllerUpdateGroupMode_MAX
	}
}
