using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020022D3 RID: 8915
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MeshPaintingToolset.EMeshFlowPaintCoordinateSpace")]
	public enum EMeshFlowPaintCoordinateSpace : byte
	{
		// Token: 0x040120BD RID: 73917
		World,
		// Token: 0x040120BE RID: 73918
		Tangent,
		// Token: 0x040120BF RID: 73919
		EMeshFlowPaintCoordinateSpace_MAX
	}
}
