using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001463 RID: 5219
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HeadMountedDisplay.ESpatialInputGestureAxis")]
	public enum ESpatialInputGestureAxis : byte
	{
		// Token: 0x0400A357 RID: 41815
		None,
		// Token: 0x0400A358 RID: 41816
		Manipulation,
		// Token: 0x0400A359 RID: 41817
		Navigation,
		// Token: 0x0400A35A RID: 41818
		NavigationRails,
		// Token: 0x0400A35B RID: 41819
		ESpatialInputGestureAxis_MAX
	}
}
