using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001859 RID: 6233
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroGameBudget.EGameBudgetAllocatorActorMode")]
	public enum EGameBudgetAllocatorActorMode : byte
	{
		// Token: 0x0400C77C RID: 51068
		GBA_ActorMode_Rendered,
		// Token: 0x0400C77D RID: 51069
		GBA_ActorMode_NotRendered,
		// Token: 0x0400C77E RID: 51070
		GBA_ActorMode_Fighting,
		// Token: 0x0400C77F RID: 51071
		GBA_ActorMode_Num,
		// Token: 0x0400C780 RID: 51072
		GBA_ActorMode_MAX
	}
}
