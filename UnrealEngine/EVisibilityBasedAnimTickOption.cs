using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000207 RID: 519
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EVisibilityBasedAnimTickOption")]
	public enum EVisibilityBasedAnimTickOption : byte
	{
		// Token: 0x04000D0B RID: 3339
		AlwaysTickPoseAndRefreshBones,
		// Token: 0x04000D0C RID: 3340
		AlwaysTickPose,
		// Token: 0x04000D0D RID: 3341
		OnlyTickMontagesWhenNotRendered,
		// Token: 0x04000D0E RID: 3342
		OnlyTickPoseWhenRendered,
		// Token: 0x04000D0F RID: 3343
		EVisibilityBasedAnimTickOption_MAX
	}
}
