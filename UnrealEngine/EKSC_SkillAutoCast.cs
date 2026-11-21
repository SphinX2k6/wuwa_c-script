using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000556 RID: 1366
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_SkillAutoCast")]
	public enum EKSC_SkillAutoCast : byte
	{
		// Token: 0x04003671 RID: 13937
		Default,
		// Token: 0x04003672 RID: 13938
		AutoCast,
		// Token: 0x04003673 RID: 13939
		ManualCast,
		// Token: 0x04003674 RID: 13940
		EKSC_MAX
	}
}
