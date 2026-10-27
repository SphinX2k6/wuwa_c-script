using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200174E RID: 5966
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroComponent.EAnimPerfTestBornFrom")]
	public enum EAnimPerfTestBornFrom : sbyte
	{
		// Token: 0x0400BB31 RID: 47921
		PlayerStart,
		// Token: 0x0400BB32 RID: 47922
		Pawn,
		// Token: 0x0400BB33 RID: 47923
		Owner,
		// Token: 0x0400BB34 RID: 47924
		EAnimPerfTestBornFrom_MAX
	}
}
