using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001467 RID: 5223
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HeadMountedDisplay.EXRTrackedDeviceType")]
	public enum EXRTrackedDeviceType : byte
	{
		// Token: 0x0400A373 RID: 41843
		HeadMountedDisplay,
		// Token: 0x0400A374 RID: 41844
		Controller,
		// Token: 0x0400A375 RID: 41845
		TrackingReference,
		// Token: 0x0400A376 RID: 41846
		Other,
		// Token: 0x0400A377 RID: 41847
		Invalid = 254,
		// Token: 0x0400A378 RID: 41848
		Any
	}
}
