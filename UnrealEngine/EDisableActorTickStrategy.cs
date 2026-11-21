using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000392 RID: 914
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroGameBudget.EDisableActorTickStrategy")]
	public enum EDisableActorTickStrategy : byte
	{
		// Token: 0x040025E4 RID: 9700
		DisableActorTickStrategy_None,
		// Token: 0x040025E5 RID: 9701
		DisableActorTickStrategy_DistanceOnly,
		// Token: 0x040025E6 RID: 9702
		DisableActorTickStrategy_NotRenderedOnly,
		// Token: 0x040025E7 RID: 9703
		DisableActorTickStrategy_NotRenderedAndDistance,
		// Token: 0x040025E8 RID: 9704
		DisableActorTickStrategy_MaxInterval,
		// Token: 0x040025E9 RID: 9705
		DisableActorTickStrategy_MAX
	}
}
