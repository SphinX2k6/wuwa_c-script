using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020022D9 RID: 8921
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MeshPaintingToolset.EMeshVertexPaintColorBlendMode")]
	public enum EMeshVertexPaintColorBlendMode : byte
	{
		// Token: 0x040120E6 RID: 73958
		Lerp,
		// Token: 0x040120E7 RID: 73959
		Mix,
		// Token: 0x040120E8 RID: 73960
		Multiply,
		// Token: 0x040120E9 RID: 73961
		EMeshVertexPaintColorBlendMode_MAX
	}
}
