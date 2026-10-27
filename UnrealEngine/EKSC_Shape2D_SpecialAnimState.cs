using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CDE RID: 7390
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_Shape2D_SpecialAnimState")]
	public enum EKSC_Shape2D_SpecialAnimState : byte
	{
		// Token: 0x0400F6CB RID: 63179
		Empty,
		// Token: 0x0400F6CC RID: 63180
		BeHit,
		// Token: 0x0400F6CD RID: 63181
		Break,
		// Token: 0x0400F6CE RID: 63182
		Death,
		// Token: 0x0400F6CF RID: 63183
		Revive,
		// Token: 0x0400F6D0 RID: 63184
		EKSC_Shape2D_MAX
	}
}
