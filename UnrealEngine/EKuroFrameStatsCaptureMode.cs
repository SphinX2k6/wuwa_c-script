using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001E4 RID: 484
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EKuroFrameStatsCaptureMode")]
	public enum EKuroFrameStatsCaptureMode
	{
		// Token: 0x04000BFC RID: 3068
		KFS_CAPTURE_JSON,
		// Token: 0x04000BFD RID: 3069
		KFS_CAPTURE_RAW,
		// Token: 0x04000BFE RID: 3070
		KFS_CAPTURE_MAX
	}
}
