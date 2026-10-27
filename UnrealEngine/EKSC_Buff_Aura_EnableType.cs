using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CBA RID: 7354
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_Buff_Aura_EnableType")]
	public enum EKSC_Buff_Aura_EnableType : byte
	{
		// Token: 0x0400F5D8 RID: 62936
		None,
		// Token: 0x0400F5D9 RID: 62937
		SelfWithTag,
		// Token: 0x0400F5DA RID: 62938
		TargetWithTag,
		// Token: 0x0400F5DB RID: 62939
		EKSC_Buff_Aura_MAX
	}
}
