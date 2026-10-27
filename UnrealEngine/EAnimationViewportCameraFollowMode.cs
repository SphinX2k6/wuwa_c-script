using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A0D RID: 10765
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.EAnimationViewportCameraFollowMode")]
	public enum EAnimationViewportCameraFollowMode : byte
	{
		// Token: 0x04015D75 RID: 89461
		None,
		// Token: 0x04015D76 RID: 89462
		Bounds,
		// Token: 0x04015D77 RID: 89463
		Bone,
		// Token: 0x04015D78 RID: 89464
		EAnimationViewportCameraFollowMode_MAX
	}
}
