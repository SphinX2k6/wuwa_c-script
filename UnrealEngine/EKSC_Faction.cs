using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CC9 RID: 7369
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_Faction")]
	public enum EKSC_Faction : byte
	{
		// Token: 0x0400F652 RID: 63058
		Faction0,
		// Token: 0x0400F653 RID: 63059
		Faction1,
		// Token: 0x0400F654 RID: 63060
		Faction2,
		// Token: 0x0400F655 RID: 63061
		Faction3 = 4,
		// Token: 0x0400F656 RID: 63062
		Faction4 = 8,
		// Token: 0x0400F657 RID: 63063
		Faction5 = 16,
		// Token: 0x0400F658 RID: 63064
		Faction6 = 32,
		// Token: 0x0400F659 RID: 63065
		Faction7 = 64,
		// Token: 0x0400F65A RID: 63066
		Faction8 = 128,
		// Token: 0x0400F65B RID: 63067
		EKSC_MAX
	}
}
