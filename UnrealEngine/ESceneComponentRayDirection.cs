using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FEF RID: 8175
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.ESceneComponentRayDirection")]
	public enum ESceneComponentRayDirection : byte
	{
		// Token: 0x04010BDF RID: 68575
		PositiveX,
		// Token: 0x04010BE0 RID: 68576
		NagtiveX,
		// Token: 0x04010BE1 RID: 68577
		PositiveY,
		// Token: 0x04010BE2 RID: 68578
		NagtiveY,
		// Token: 0x04010BE3 RID: 68579
		PositiveZ,
		// Token: 0x04010BE4 RID: 68580
		NagtiveZ,
		// Token: 0x04010BE5 RID: 68581
		ESceneComponentRayDirection_MAX
	}
}
