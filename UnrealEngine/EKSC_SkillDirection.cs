using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CE9 RID: 7401
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_SkillDirection")]
	public enum EKSC_SkillDirection : byte
	{
		// Token: 0x0400F704 RID: 63236
		Target,
		// Token: 0x0400F705 RID: 63237
		Self = 2,
		// Token: 0x0400F706 RID: 63238
		EKSC_MAX
	}
}
