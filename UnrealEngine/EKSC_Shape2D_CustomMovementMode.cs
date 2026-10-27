using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CDC RID: 7388
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_Shape2D_CustomMovementMode")]
	public enum EKSC_Shape2D_CustomMovementMode : byte
	{
		// Token: 0x0400F6C3 RID: 63171
		BaseOnDistance = 1,
		// Token: 0x0400F6C4 RID: 63172
		BaseOnSpeed,
		// Token: 0x0400F6C5 RID: 63173
		EKSC_Shape2D_MAX
	}
}
