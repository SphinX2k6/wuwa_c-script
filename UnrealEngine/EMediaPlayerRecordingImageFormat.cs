using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020022A6 RID: 8870
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MediaCompositingEditor.EMediaPlayerRecordingImageFormat")]
	public enum EMediaPlayerRecordingImageFormat : byte
	{
		// Token: 0x04011FE6 RID: 73702
		PNG,
		// Token: 0x04011FE7 RID: 73703
		JPEG,
		// Token: 0x04011FE8 RID: 73704
		BMP,
		// Token: 0x04011FE9 RID: 73705
		EXR,
		// Token: 0x04011FEA RID: 73706
		EMediaPlayerRecordingImageFormat_MAX
	}
}
