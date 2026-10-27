using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CC4 RID: 7364
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_CalculateType")]
	public enum EKSC_CalculateType : byte
	{
		// Token: 0x0400F620 RID: 63008
		Hurt,
		// Token: 0x0400F621 RID: 63009
		Heal,
		// Token: 0x0400F622 RID: 63010
		PercentageHurt,
		// Token: 0x0400F623 RID: 63011
		MotorFightHurt,
		// Token: 0x0400F624 RID: 63012
		MotorCollisionHurt,
		// Token: 0x0400F625 RID: 63013
		MotorFightHeal,
		// Token: 0x0400F626 RID: 63014
		HurtMultiRelated,
		// Token: 0x0400F627 RID: 63015
		Shield,
		// Token: 0x0400F628 RID: 63016
		HealMultiRelated,
		// Token: 0x0400F629 RID: 63017
		EKSC_MAX
	}
}
