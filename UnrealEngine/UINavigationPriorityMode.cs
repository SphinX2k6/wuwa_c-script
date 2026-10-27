using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200218C RID: 8588
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UINavigationPriorityMode")]
	public enum UINavigationPriorityMode : byte
	{
		// Token: 0x040116E8 RID: 71400
		Distance,
		// Token: 0x040116E9 RID: 71401
		Direction,
		// Token: 0x040116EA RID: 71402
		DistanceDirection,
		// Token: 0x040116EB RID: 71403
		DirectionAngle,
		// Token: 0x040116EC RID: 71404
		DistanceOnlySameScroll,
		// Token: 0x040116ED RID: 71405
		UINavigationPriorityMode_MAX
	}
}
