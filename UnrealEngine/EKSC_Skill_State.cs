using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CEB RID: 7403
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_Skill_State")]
	public enum EKSC_Skill_State : byte
	{
		// Token: 0x0400F70D RID: 63245
		Ready,
		// Token: 0x0400F70E RID: 63246
		BeginSkill,
		// Token: 0x0400F70F RID: 63247
		PreCast,
		// Token: 0x0400F710 RID: 63248
		BeginCast,
		// Token: 0x0400F711 RID: 63249
		EndCast,
		// Token: 0x0400F712 RID: 63250
		EndSkill,
		// Token: 0x0400F713 RID: 63251
		CoolDown,
		// Token: 0x0400F714 RID: 63252
		EKSC_Skill_MAX
	}
}
