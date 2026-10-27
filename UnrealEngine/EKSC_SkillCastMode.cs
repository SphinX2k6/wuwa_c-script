using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CE8 RID: 7400
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_SkillCastMode")]
	public enum EKSC_SkillCastMode : byte
	{
		// Token: 0x0400F700 RID: 63232
		Default,
		// Token: 0x0400F701 RID: 63233
		Single,
		// Token: 0x0400F702 RID: 63234
		EKSC_MAX
	}
}
