using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CD3 RID: 7379
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_ListenCollisionEvent_ResponseTarget")]
	public enum EKSC_ListenCollisionEvent_ResponseTarget : byte
	{
		// Token: 0x0400F693 RID: 63123
		CollisionTarget,
		// Token: 0x0400F694 RID: 63124
		CurrentPlayer,
		// Token: 0x0400F695 RID: 63125
		TeamPlayer,
		// Token: 0x0400F696 RID: 63126
		EKSC_ListenCollisionEvent_MAX
	}
}
