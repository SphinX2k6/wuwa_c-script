using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CD5 RID: 7381
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_LockTarget")]
	public enum EKSC_LockTarget : byte
	{
		// Token: 0x0400F69C RID: 63132
		Random,
		// Token: 0x0400F69D RID: 63133
		Nearest,
		// Token: 0x0400F69E RID: 63134
		EKSC_MAX
	}
}
