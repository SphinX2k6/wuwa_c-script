using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020022E0 RID: 8928
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MeshPaint.EMeshPaintMode")]
	public enum EMeshPaintMode : byte
	{
		// Token: 0x04012111 RID: 74001
		PaintColors,
		// Token: 0x04012112 RID: 74002
		PaintWeights,
		// Token: 0x04012113 RID: 74003
		EMeshPaintMode_MAX
	}
}
