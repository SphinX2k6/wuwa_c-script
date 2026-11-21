using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000391 RID: 913
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroGameBudget.EActorCavernMode")]
	public enum EActorCavernMode : byte
	{
		// Token: 0x040025DE RID: 9694
		ActorCavernMode_None,
		// Token: 0x040025DF RID: 9695
		ActorCavernMode_Outside,
		// Token: 0x040025E0 RID: 9696
		ActorCavernMode_Inside,
		// Token: 0x040025E1 RID: 9697
		ActorCavernMode_IntermediateZone,
		// Token: 0x040025E2 RID: 9698
		ActorCavernMode_MAX
	}
}
