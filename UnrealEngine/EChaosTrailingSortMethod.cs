using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001424 RID: 5156
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GeometryCollectionEngine.EChaosTrailingSortMethod")]
	public enum EChaosTrailingSortMethod : byte
	{
		// Token: 0x0400A0DB RID: 41179
		SortNone,
		// Token: 0x0400A0DC RID: 41180
		SortByHighestMass,
		// Token: 0x0400A0DD RID: 41181
		SortByHighestSpeed,
		// Token: 0x0400A0DE RID: 41182
		SortByNearestFirst,
		// Token: 0x0400A0DF RID: 41183
		Count,
		// Token: 0x0400A0E0 RID: 41184
		EChaosTrailingSortMethod_MAX
	}
}
