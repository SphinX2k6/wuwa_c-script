using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001858 RID: 6232
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroGameBudget.EDisableActorTickStrategy")]
	public enum EDisableActorTickStrategy : byte
	{
		// Token: 0x0400C775 RID: 51061
		DisableActorTickStrategy_None,
		// Token: 0x0400C776 RID: 51062
		DisableActorTickStrategy_DistanceOnly,
		// Token: 0x0400C777 RID: 51063
		DisableActorTickStrategy_NotRenderedOnly,
		// Token: 0x0400C778 RID: 51064
		DisableActorTickStrategy_NotRenderedAndDistance,
		// Token: 0x0400C779 RID: 51065
		DisableActorTickStrategy_MaxInterval,
		// Token: 0x0400C77A RID: 51066
		DisableActorTickStrategy_MAX
	}
}
