using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001348 RID: 4936
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayAbilities.ERootMotionMoveToActorTargetOffsetType")]
	public enum ERootMotionMoveToActorTargetOffsetType : byte
	{
		// Token: 0x04009B12 RID: 39698
		AlignFromTargetToSource,
		// Token: 0x04009B13 RID: 39699
		AlignToTargetForward,
		// Token: 0x04009B14 RID: 39700
		AlignToWorldSpace,
		// Token: 0x04009B15 RID: 39701
		ERootMotionMoveToActorTargetOffsetType_MAX
	}
}
