using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020027FE RID: 10238
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SlateCore.EFontHinting")]
	public enum EFontHinting : byte
	{
		// Token: 0x04014D91 RID: 85393
		Default,
		// Token: 0x04014D92 RID: 85394
		Auto,
		// Token: 0x04014D93 RID: 85395
		AutoLight,
		// Token: 0x04014D94 RID: 85396
		Monochrome,
		// Token: 0x04014D95 RID: 85397
		None,
		// Token: 0x04014D96 RID: 85398
		EFontHinting_MAX
	}
}
