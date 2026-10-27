using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001466 RID: 5222
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HeadMountedDisplay.EXRDeviceConnectionResult")]
	public enum EXRDeviceConnectionResult
	{
		// Token: 0x0400A36C RID: 41836
		NoTrackingSystem,
		// Token: 0x0400A36D RID: 41837
		FeatureNotSupported,
		// Token: 0x0400A36E RID: 41838
		NoValidViewport,
		// Token: 0x0400A36F RID: 41839
		MiscFailure,
		// Token: 0x0400A370 RID: 41840
		Success,
		// Token: 0x0400A371 RID: 41841
		EXRDeviceConnectionResult_MAX
	}
}
