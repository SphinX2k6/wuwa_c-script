using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001857 RID: 6231
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroGameBudget.EActorCavernMode")]
	public enum EActorCavernMode : byte
	{
		// Token: 0x0400C76F RID: 51055
		ActorCavernMode_None,
		// Token: 0x0400C770 RID: 51056
		ActorCavernMode_Outside,
		// Token: 0x0400C771 RID: 51057
		ActorCavernMode_Inside,
		// Token: 0x0400C772 RID: 51058
		ActorCavernMode_IntermediateZone,
		// Token: 0x0400C773 RID: 51059
		ActorCavernMode_MAX
	}
}
