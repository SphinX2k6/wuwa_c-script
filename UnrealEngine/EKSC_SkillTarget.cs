using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CEA RID: 7402
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_SkillTarget")]
	public enum EKSC_SkillTarget : byte
	{
		// Token: 0x0400F708 RID: 63240
		None,
		// Token: 0x0400F709 RID: 63241
		NearestEnemy,
		// Token: 0x0400F70A RID: 63242
		FieldOfView,
		// Token: 0x0400F70B RID: 63243
		EKSC_MAX
	}
}
