using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A4C RID: 6732
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingEditorBPPlugin.EKuroThumbnailResolution")]
	public enum EKuroThumbnailResolution : byte
	{
		// Token: 0x0400D763 RID: 55139
		LOW,
		// Token: 0x0400D764 RID: 55140
		MEDIUM,
		// Token: 0x0400D765 RID: 55141
		HIGH,
		// Token: 0x0400D766 RID: 55142
		MEGA,
		// Token: 0x0400D767 RID: 55143
		EKuroThumbnailResolution_MAX
	}
}
