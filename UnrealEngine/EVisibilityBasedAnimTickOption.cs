using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BB5 RID: 2997
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EVisibilityBasedAnimTickOption")]
	public enum EVisibilityBasedAnimTickOption : byte
	{
		// Token: 0x04005294 RID: 21140
		AlwaysTickPoseAndRefreshBones,
		// Token: 0x04005295 RID: 21141
		AlwaysTickPose,
		// Token: 0x04005296 RID: 21142
		OnlyTickMontagesWhenNotRendered,
		// Token: 0x04005297 RID: 21143
		OnlyTickPoseWhenRendered,
		// Token: 0x04005298 RID: 21144
		EVisibilityBasedAnimTickOption_MAX
	}
}
