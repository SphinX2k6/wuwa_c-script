using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001F8 RID: 504
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERootMotionMode")]
	public enum ERootMotionMode
	{
		// Token: 0x04000C8A RID: 3210
		NoRootMotionExtraction,
		// Token: 0x04000C8B RID: 3211
		IgnoreRootMotion,
		// Token: 0x04000C8C RID: 3212
		RootMotionFromEverything,
		// Token: 0x04000C8D RID: 3213
		RootMotionFromMontagesOnly,
		// Token: 0x04000C8E RID: 3214
		ERootMotionMode_MAX
	}
}
