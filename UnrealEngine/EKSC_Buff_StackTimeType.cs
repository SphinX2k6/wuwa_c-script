using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CC2 RID: 7362
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_Buff_StackTimeType")]
	public enum EKSC_Buff_StackTimeType : byte
	{
		// Token: 0x0400F616 RID: 62998
		ShareTime,
		// Token: 0x0400F617 RID: 62999
		OneSourceOneStack,
		// Token: 0x0400F618 RID: 63000
		MultiStackTime,
		// Token: 0x0400F619 RID: 63001
		EKSC_Buff_MAX
	}
}
