using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CCE RID: 7374
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_HeadHpContextType")]
	public enum EKSC_HeadHpContextType : byte
	{
		// Token: 0x0400F67A RID: 63098
		Add,
		// Token: 0x0400F67B RID: 63099
		Update,
		// Token: 0x0400F67C RID: 63100
		Remove,
		// Token: 0x0400F67D RID: 63101
		EKSC_MAX
	}
}
