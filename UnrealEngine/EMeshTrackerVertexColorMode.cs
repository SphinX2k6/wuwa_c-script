using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002468 RID: 9320
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MRMesh.EMeshTrackerVertexColorMode")]
	public enum EMeshTrackerVertexColorMode : byte
	{
		// Token: 0x04012A13 RID: 76307
		None,
		// Token: 0x04012A14 RID: 76308
		Confidence,
		// Token: 0x04012A15 RID: 76309
		Block,
		// Token: 0x04012A16 RID: 76310
		EMeshTrackerVertexColorMode_MAX
	}
}
