using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000393 RID: 915
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroGameBudget.EGameBudgetAllocatorActorMode")]
	public enum EGameBudgetAllocatorActorMode : byte
	{
		// Token: 0x040025EB RID: 9707
		GBA_ActorMode_Rendered,
		// Token: 0x040025EC RID: 9708
		GBA_ActorMode_NotRendered,
		// Token: 0x040025ED RID: 9709
		GBA_ActorMode_Fighting,
		// Token: 0x040025EE RID: 9710
		GBA_ActorMode_Num,
		// Token: 0x040025EF RID: 9711
		GBA_ActorMode_MAX
	}
}
