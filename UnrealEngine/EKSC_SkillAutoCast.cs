using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CE7 RID: 7399
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_SkillAutoCast")]
	public enum EKSC_SkillAutoCast : byte
	{
		// Token: 0x0400F6FB RID: 63227
		Default,
		// Token: 0x0400F6FC RID: 63228
		AutoCast,
		// Token: 0x0400F6FD RID: 63229
		ManualCast,
		// Token: 0x0400F6FE RID: 63230
		EKSC_MAX
	}
}
