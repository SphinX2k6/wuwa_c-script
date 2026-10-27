using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200177F RID: 6015
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroComputeShader.EKuroCSJacobiClothRuntimeBackend")]
	public enum EKuroCSJacobiClothRuntimeBackend : byte
	{
		// Token: 0x0400BCE8 RID: 48360
		StaticFallback,
		// Token: 0x0400BCE9 RID: 48361
		GpuJacobi,
		// Token: 0x0400BCEA RID: 48362
		EKuroCSJacobiClothRuntimeBackend_MAX
	}
}
