using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CD0 RID: 7376
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_ListenCollisionEvent_CollisionType")]
	public enum EKSC_ListenCollisionEvent_CollisionType : byte
	{
		// Token: 0x0400F688 RID: 63112
		Enemy,
		// Token: 0x0400F689 RID: 63113
		MoveRangeLimit,
		// Token: 0x0400F68A RID: 63114
		EKSC_ListenCollisionEvent_MAX
	}
}
