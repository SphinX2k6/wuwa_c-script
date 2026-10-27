using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020022D4 RID: 8916
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MeshPaintingToolset.EMeshFlowPaintMode")]
	public enum EMeshFlowPaintMode : byte
	{
		// Token: 0x040120C1 RID: 73921
		FlowRG,
		// Token: 0x040120C2 RID: 73922
		FlowBA,
		// Token: 0x040120C3 RID: 73923
		FlowUV1_XY,
		// Token: 0x040120C4 RID: 73924
		FlowUV2_XY,
		// Token: 0x040120C5 RID: 73925
		FlowUV3_XY,
		// Token: 0x040120C6 RID: 73926
		EMeshFlowPaintMode_MAX
	}
}
