using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002928 RID: 10536
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/TriggerEffect.EMode")]
	public enum EMode : byte
	{
		// Token: 0x040156BB RID: 87739
		Off,
		// Token: 0x040156BC RID: 87740
		Feedback,
		// Token: 0x040156BD RID: 87741
		Vibration,
		// Token: 0x040156BE RID: 87742
		Weapon,
		// Token: 0x040156BF RID: 87743
		SlopeFeedback,
		// Token: 0x040156C0 RID: 87744
		MultiplePositionFeedback,
		// Token: 0x040156C1 RID: 87745
		MultiplePositionVibration,
		// Token: 0x040156C2 RID: 87746
		EMode_MAX
	}
}
