using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000716 RID: 1814
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UINavigationPriorityMode")]
	public enum UINavigationPriorityMode : byte
	{
		// Token: 0x04004345 RID: 17221
		Distance,
		// Token: 0x04004346 RID: 17222
		Direction,
		// Token: 0x04004347 RID: 17223
		DistanceDirection,
		// Token: 0x04004348 RID: 17224
		DirectionAngle,
		// Token: 0x04004349 RID: 17225
		DistanceOnlySameScroll,
		// Token: 0x0400434A RID: 17226
		UINavigationPriorityMode_MAX
	}
}
