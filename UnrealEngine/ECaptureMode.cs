using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A6A RID: 6762
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.ECaptureMode")]
	public enum ECaptureMode
	{
		// Token: 0x0400D8C8 RID: 55496
		VertexColor,
		// Token: 0x0400D8C9 RID: 55497
		Depth,
		// Token: 0x0400D8CA RID: 55498
		OriginDepth,
		// Token: 0x0400D8CB RID: 55499
		ECaptureMode_MAX
	}
}
