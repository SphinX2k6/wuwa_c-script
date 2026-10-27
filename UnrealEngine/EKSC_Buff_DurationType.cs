using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CBC RID: 7356
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_Buff_DurationType")]
	public enum EKSC_Buff_DurationType : byte
	{
		// Token: 0x0400F5E3 RID: 62947
		Instant,
		// Token: 0x0400F5E4 RID: 62948
		Forever,
		// Token: 0x0400F5E5 RID: 62949
		Duration,
		// Token: 0x0400F5E6 RID: 62950
		EKSC_Buff_MAX
	}
}
