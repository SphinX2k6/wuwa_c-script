using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A4B RID: 6731
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingEditorBPPlugin.EKuroThumbnailFormat")]
	public enum EKuroThumbnailFormat : byte
	{
		// Token: 0x0400D75E RID: 55134
		PNG,
		// Token: 0x0400D75F RID: 55135
		JPEG,
		// Token: 0x0400D760 RID: 55136
		BMP,
		// Token: 0x0400D761 RID: 55137
		EKuroThumbnailFormat_MAX
	}
}
