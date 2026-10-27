using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B4E RID: 2894
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERootMotionMode")]
	public enum ERootMotionMode
	{
		// Token: 0x04004FAD RID: 20397
		NoRootMotionExtraction,
		// Token: 0x04004FAE RID: 20398
		IgnoreRootMotion,
		// Token: 0x04004FAF RID: 20399
		RootMotionFromEverything,
		// Token: 0x04004FB0 RID: 20400
		RootMotionFromMontagesOnly,
		// Token: 0x04004FB1 RID: 20401
		ERootMotionMode_MAX
	}
}
