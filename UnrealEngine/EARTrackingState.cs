using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003FA RID: 1018
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARTrackingState")]
	public enum EARTrackingState : byte
	{
		// Token: 0x040018FC RID: 6396
		Unknown,
		// Token: 0x040018FD RID: 6397
		Tracking,
		// Token: 0x040018FE RID: 6398
		NotTracking,
		// Token: 0x040018FF RID: 6399
		StoppedTracking,
		// Token: 0x04001900 RID: 6400
		EARTrackingState_MAX
	}
}
