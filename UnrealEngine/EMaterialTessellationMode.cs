using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AC2 RID: 2754
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMaterialTessellationMode")]
	public enum EMaterialTessellationMode
	{
		// Token: 0x04004A2B RID: 18987
		MTM_NoTessellation,
		// Token: 0x04004A2C RID: 18988
		MTM_FlatTessellation,
		// Token: 0x04004A2D RID: 18989
		MTM_PNTriangles,
		// Token: 0x04004A2E RID: 18990
		MTM_MAX
	}
}
