using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001725 RID: 5925
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBullet.EKSC_PTT_BulletDirection")]
	public enum EKSC_PTT_BulletDirection : byte
	{
		// Token: 0x0400BA33 RID: 47667
		SkillTarget,
		// Token: 0x0400BA34 RID: 47668
		Caster,
		// Token: 0x0400BA35 RID: 47669
		Summoner,
		// Token: 0x0400BA36 RID: 47670
		EKSC_PTT_MAX
	}
}
