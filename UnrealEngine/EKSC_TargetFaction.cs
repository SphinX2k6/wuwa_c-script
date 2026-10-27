using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CED RID: 7405
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_TargetFaction")]
	public enum EKSC_TargetFaction : byte
	{
		// Token: 0x0400F728 RID: 63272
		Friend,
		// Token: 0x0400F729 RID: 63273
		Enemy,
		// Token: 0x0400F72A RID: 63274
		All,
		// Token: 0x0400F72B RID: 63275
		EKSC_MAX
	}
}
