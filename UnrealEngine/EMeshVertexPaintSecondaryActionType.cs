using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020022DB RID: 8923
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MeshPaintingToolset.EMeshVertexPaintSecondaryActionType")]
	public enum EMeshVertexPaintSecondaryActionType : byte
	{
		// Token: 0x040120F3 RID: 73971
		Erase,
		// Token: 0x040120F4 RID: 73972
		Soften,
		// Token: 0x040120F5 RID: 73973
		Smooth,
		// Token: 0x040120F6 RID: 73974
		EMeshVertexPaintSecondaryActionType_MAX
	}
}
