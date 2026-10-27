using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BB7 RID: 2999
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EVisibilityTrackCondition")]
	public enum EVisibilityTrackCondition
	{
		// Token: 0x0400529F RID: 21151
		EVTC_Always,
		// Token: 0x040052A0 RID: 21152
		EVTC_GoreEnabled,
		// Token: 0x040052A1 RID: 21153
		EVTC_GoreDisabled,
		// Token: 0x040052A2 RID: 21154
		EVTC_MAX
	}
}
