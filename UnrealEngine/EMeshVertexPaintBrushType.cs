using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020022D8 RID: 8920
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MeshPaintingToolset.EMeshVertexPaintBrushType")]
	public enum EMeshVertexPaintBrushType : byte
	{
		// Token: 0x040120DF RID: 73951
		Paint,
		// Token: 0x040120E0 RID: 73952
		Erase,
		// Token: 0x040120E1 RID: 73953
		Soften,
		// Token: 0x040120E2 RID: 73954
		Smooth,
		// Token: 0x040120E3 RID: 73955
		LastValue,
		// Token: 0x040120E4 RID: 73956
		EMeshVertexPaintBrushType_MAX
	}
}
