using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200054E RID: 1358
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_CalculateType")]
	public enum EKSC_CalculateType : byte
	{
		// Token: 0x0400362C RID: 13868
		Hurt,
		// Token: 0x0400362D RID: 13869
		Heal,
		// Token: 0x0400362E RID: 13870
		PercentageHurt,
		// Token: 0x0400362F RID: 13871
		MotorFightHurt,
		// Token: 0x04003630 RID: 13872
		MotorCollisionHurt,
		// Token: 0x04003631 RID: 13873
		MotorFightHeal,
		// Token: 0x04003632 RID: 13874
		HurtMultiRelated,
		// Token: 0x04003633 RID: 13875
		Shield,
		// Token: 0x04003634 RID: 13876
		HealMultiRelated,
		// Token: 0x04003635 RID: 13877
		EKSC_MAX
	}
}
