using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001423 RID: 5155
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GeometryCollectionEngine.EChaosCollisionSortMethod")]
	public enum EChaosCollisionSortMethod : byte
	{
		// Token: 0x0400A0D3 RID: 41171
		SortNone,
		// Token: 0x0400A0D4 RID: 41172
		SortByHighestMass,
		// Token: 0x0400A0D5 RID: 41173
		SortByHighestSpeed,
		// Token: 0x0400A0D6 RID: 41174
		SortByHighestImpulse,
		// Token: 0x0400A0D7 RID: 41175
		SortByNearestFirst,
		// Token: 0x0400A0D8 RID: 41176
		Count,
		// Token: 0x0400A0D9 RID: 41177
		EChaosCollisionSortMethod_MAX
	}
}
