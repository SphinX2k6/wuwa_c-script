using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CC8 RID: 7368
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_Event_HitTarget")]
	public enum EKSC_Event_HitTarget : byte
	{
		// Token: 0x0400F64B RID: 63051
		Source,
		// Token: 0x0400F64C RID: 63052
		Target,
		// Token: 0x0400F64D RID: 63053
		Caster,
		// Token: 0x0400F64E RID: 63054
		Owner,
		// Token: 0x0400F64F RID: 63055
		OwnerSummoner,
		// Token: 0x0400F650 RID: 63056
		EKSC_Event_MAX
	}
}
