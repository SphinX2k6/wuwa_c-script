using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AFC RID: 2812
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ENotifyTriggerMode")]
	public enum ENotifyTriggerMode
	{
		// Token: 0x04004D03 RID: 19715
		AllAnimations,
		// Token: 0x04004D04 RID: 19716
		HighestWeightedAnimation,
		// Token: 0x04004D05 RID: 19717
		None,
		// Token: 0x04004D06 RID: 19718
		ENotifyTriggerMode_MAX
	}
}
