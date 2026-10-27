using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CDB RID: 7387
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_Shape2D_BaseAnimState")]
	public enum EKSC_Shape2D_BaseAnimState : byte
	{
		// Token: 0x0400F6BD RID: 63165
		Idle,
		// Token: 0x0400F6BE RID: 63166
		Rise = 2,
		// Token: 0x0400F6BF RID: 63167
		Fall,
		// Token: 0x0400F6C0 RID: 63168
		Victory,
		// Token: 0x0400F6C1 RID: 63169
		EKSC_Shape2D_MAX
	}
}
