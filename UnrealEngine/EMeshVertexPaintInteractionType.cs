using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020022DA RID: 8922
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MeshPaintingToolset.EMeshVertexPaintInteractionType")]
	public enum EMeshVertexPaintInteractionType : byte
	{
		// Token: 0x040120EB RID: 73963
		Brush,
		// Token: 0x040120EC RID: 73964
		TriFill,
		// Token: 0x040120ED RID: 73965
		Fill,
		// Token: 0x040120EE RID: 73966
		GroupFill,
		// Token: 0x040120EF RID: 73967
		PolyLasso,
		// Token: 0x040120F0 RID: 73968
		LastValue,
		// Token: 0x040120F1 RID: 73969
		EMeshVertexPaintInteractionType_MAX
	}
}
