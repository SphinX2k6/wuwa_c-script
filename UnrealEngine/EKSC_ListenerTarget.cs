using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CD4 RID: 7380
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_ListenerTarget")]
	public enum EKSC_ListenerTarget : byte
	{
		// Token: 0x0400F698 RID: 63128
		Owner,
		// Token: 0x0400F699 RID: 63129
		Caster,
		// Token: 0x0400F69A RID: 63130
		EKSC_MAX
	}
}
