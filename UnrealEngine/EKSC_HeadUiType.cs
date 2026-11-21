using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000553 RID: 1363
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_HeadUiType")]
	public enum EKSC_HeadUiType : byte
	{
		// Token: 0x0400365E RID: 13918
		Default,
		// Token: 0x0400365F RID: 13919
		Player,
		// Token: 0x04003660 RID: 13920
		Boss,
		// Token: 0x04003661 RID: 13921
		BuffGate,
		// Token: 0x04003662 RID: 13922
		TopBoss,
		// Token: 0x04003663 RID: 13923
		Digital,
		// Token: 0x04003664 RID: 13924
		Marble,
		// Token: 0x04003665 RID: 13925
		EKSC_MAX
	}
}
