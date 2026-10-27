using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A66 RID: 6758
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EBillboardMode")]
	public enum EBillboardMode : byte
	{
		// Token: 0x0400D8AE RID: 55470
		Free,
		// Token: 0x0400D8AF RID: 55471
		UpWard,
		// Token: 0x0400D8B0 RID: 55472
		Right,
		// Token: 0x0400D8B1 RID: 55473
		Max,
		// Token: 0x0400D8B2 RID: 55474
		EBillboardMode_MAX
	}
}
