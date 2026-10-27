using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001460 RID: 5216
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HeadMountedDisplay.EHMDTrackingOrigin")]
	public enum EHMDTrackingOrigin
	{
		// Token: 0x0400A347 RID: 41799
		Floor,
		// Token: 0x0400A348 RID: 41800
		Eye,
		// Token: 0x0400A349 RID: 41801
		Stage,
		// Token: 0x0400A34A RID: 41802
		Unbounded,
		// Token: 0x0400A34B RID: 41803
		EHMDTrackingOrigin_MAX
	}
}
