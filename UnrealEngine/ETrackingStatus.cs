using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001465 RID: 5221
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HeadMountedDisplay.ETrackingStatus")]
	public enum ETrackingStatus : byte
	{
		// Token: 0x0400A367 RID: 41831
		NotTracked,
		// Token: 0x0400A368 RID: 41832
		InertialOnly,
		// Token: 0x0400A369 RID: 41833
		Tracked,
		// Token: 0x0400A36A RID: 41834
		ETrackingStatus_MAX
	}
}
