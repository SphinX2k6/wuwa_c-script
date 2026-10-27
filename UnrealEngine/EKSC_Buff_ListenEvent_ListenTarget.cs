using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CBE RID: 7358
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_Buff_ListenEvent_ListenTarget")]
	public enum EKSC_Buff_ListenEvent_ListenTarget : byte
	{
		// Token: 0x0400F5EC RID: 62956
		Owner,
		// Token: 0x0400F5ED RID: 62957
		Caster,
		// Token: 0x0400F5EE RID: 62958
		EKSC_Buff_ListenEvent_MAX
	}
}
