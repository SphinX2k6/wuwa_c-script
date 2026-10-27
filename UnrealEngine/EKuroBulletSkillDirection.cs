using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001729 RID: 5929
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBullet.EKuroBulletSkillDirection")]
	public enum EKuroBulletSkillDirection : byte
	{
		// Token: 0x0400BA46 RID: 47686
		SkillTarget,
		// Token: 0x0400BA47 RID: 47687
		Self = 2,
		// Token: 0x0400BA48 RID: 47688
		EKuroBulletSkillDirection_MAX
	}
}
