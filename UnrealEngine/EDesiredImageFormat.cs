using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001518 RID: 5400
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ImageWriteQueue.EDesiredImageFormat")]
	public enum EDesiredImageFormat : byte
	{
		// Token: 0x0400A9E3 RID: 43491
		PNG,
		// Token: 0x0400A9E4 RID: 43492
		JPG,
		// Token: 0x0400A9E5 RID: 43493
		BMP,
		// Token: 0x0400A9E6 RID: 43494
		EXR,
		// Token: 0x0400A9E7 RID: 43495
		EDesiredImageFormat_MAX
	}
}
