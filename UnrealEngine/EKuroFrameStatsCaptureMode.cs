using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A8E RID: 2702
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EKuroFrameStatsCaptureMode")]
	public enum EKuroFrameStatsCaptureMode
	{
		// Token: 0x04004863 RID: 18531
		KFS_CAPTURE_JSON,
		// Token: 0x04004864 RID: 18532
		KFS_CAPTURE_RAW,
		// Token: 0x04004865 RID: 18533
		KFS_CAPTURE_MAX
	}
}
