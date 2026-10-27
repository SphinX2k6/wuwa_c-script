using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CD6 RID: 7382
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_ManualSkillAttack")]
	public enum EKSC_ManualSkillAttack : byte
	{
		// Token: 0x0400F6A0 RID: 63136
		Normal,
		// Token: 0x0400F6A1 RID: 63137
		Explode,
		// Token: 0x0400F6A2 RID: 63138
		EKSC_MAX
	}
}
