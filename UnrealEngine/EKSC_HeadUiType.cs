using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CCF RID: 7375
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_HeadUiType")]
	public enum EKSC_HeadUiType : byte
	{
		// Token: 0x0400F67F RID: 63103
		Default,
		// Token: 0x0400F680 RID: 63104
		Player,
		// Token: 0x0400F681 RID: 63105
		Boss,
		// Token: 0x0400F682 RID: 63106
		BuffGate,
		// Token: 0x0400F683 RID: 63107
		TopBoss,
		// Token: 0x0400F684 RID: 63108
		Digital,
		// Token: 0x0400F685 RID: 63109
		Marble,
		// Token: 0x0400F686 RID: 63110
		EKSC_MAX
	}
}
