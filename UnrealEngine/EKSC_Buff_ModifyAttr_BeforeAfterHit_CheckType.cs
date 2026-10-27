using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CC1 RID: 7361
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_Buff_ModifyAttr_BeforeAfterHit_CheckType")]
	public enum EKSC_Buff_ModifyAttr_BeforeAfterHit_CheckType : byte
	{
		// Token: 0x0400F611 RID: 62993
		Tag,
		// Token: 0x0400F612 RID: 62994
		TagCount,
		// Token: 0x0400F613 RID: 62995
		TagChildCount,
		// Token: 0x0400F614 RID: 62996
		EKSC_Buff_ModifyAttr_BeforeAfterHit_MAX
	}
}
