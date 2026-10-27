using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002789 RID: 10121
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SimplygonUObjects.EComputeVisibilityMode")]
	public enum EComputeVisibilityMode : byte
	{
		// Token: 0x040149C6 RID: 84422
		DirectX,
		// Token: 0x040149C7 RID: 84423
		Software,
		// Token: 0x040149C8 RID: 84424
		EComputeVisibilityMode_MAX
	}
}
