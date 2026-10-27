using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CD2 RID: 7378
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_ListenCollisionEvent_Response")]
	public enum EKSC_ListenCollisionEvent_Response : byte
	{
		// Token: 0x0400F68F RID: 63119
		AddBuff,
		// Token: 0x0400F690 RID: 63120
		CreateBullet,
		// Token: 0x0400F691 RID: 63121
		EKSC_ListenCollisionEvent_MAX
	}
}
