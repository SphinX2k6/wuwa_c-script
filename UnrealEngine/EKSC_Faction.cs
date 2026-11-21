using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000551 RID: 1361
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_Faction")]
	public enum EKSC_Faction : byte
	{
		// Token: 0x0400364E RID: 13902
		Faction0,
		// Token: 0x0400364F RID: 13903
		Faction1,
		// Token: 0x04003650 RID: 13904
		Faction2,
		// Token: 0x04003651 RID: 13905
		Faction3 = 4,
		// Token: 0x04003652 RID: 13906
		Faction4 = 8,
		// Token: 0x04003653 RID: 13907
		Faction5 = 16,
		// Token: 0x04003654 RID: 13908
		Faction6 = 32,
		// Token: 0x04003655 RID: 13909
		Faction7 = 64,
		// Token: 0x04003656 RID: 13910
		Faction8 = 128,
		// Token: 0x04003657 RID: 13911
		EKSC_MAX
	}
}
