using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001422 RID: 5154
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GeometryCollectionEngine.EChaosBreakingSortMethod")]
	public enum EChaosBreakingSortMethod : byte
	{
		// Token: 0x0400A0CC RID: 41164
		SortNone,
		// Token: 0x0400A0CD RID: 41165
		SortByHighestMass,
		// Token: 0x0400A0CE RID: 41166
		SortByHighestSpeed,
		// Token: 0x0400A0CF RID: 41167
		SortByNearestFirst,
		// Token: 0x0400A0D0 RID: 41168
		Count,
		// Token: 0x0400A0D1 RID: 41169
		EChaosBreakingSortMethod_MAX
	}
}
