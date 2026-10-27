using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200017A RID: 378
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EEnvQueryHightlightMode")]
	public enum EEnvQueryHightlightMode : byte
	{
		// Token: 0x04000685 RID: 1669
		All,
		// Token: 0x04000686 RID: 1670
		Best5Pct,
		// Token: 0x04000687 RID: 1671
		Best25Pct,
		// Token: 0x04000688 RID: 1672
		EEnvQueryHightlightMode_MAX
	}
}
