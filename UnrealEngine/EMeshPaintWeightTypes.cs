using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020022D7 RID: 8919
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MeshPaintingToolset.EMeshPaintWeightTypes")]
	public enum EMeshPaintWeightTypes : byte
	{
		// Token: 0x040120D9 RID: 73945
		AlphaLerp = 2,
		// Token: 0x040120DA RID: 73946
		RGB,
		// Token: 0x040120DB RID: 73947
		ARGB,
		// Token: 0x040120DC RID: 73948
		OneMinusARGB,
		// Token: 0x040120DD RID: 73949
		EMeshPaintWeightTypes_MAX
	}
}
