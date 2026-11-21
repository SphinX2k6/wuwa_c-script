using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000557 RID: 1367
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_Skill_State")]
	public enum EKSC_Skill_State : byte
	{
		// Token: 0x04003676 RID: 13942
		Ready,
		// Token: 0x04003677 RID: 13943
		BeginSkill,
		// Token: 0x04003678 RID: 13944
		PreCast,
		// Token: 0x04003679 RID: 13945
		BeginCast,
		// Token: 0x0400367A RID: 13946
		EndCast,
		// Token: 0x0400367B RID: 13947
		EndSkill,
		// Token: 0x0400367C RID: 13948
		CoolDown,
		// Token: 0x0400367D RID: 13949
		EKSC_Skill_MAX
	}
}
