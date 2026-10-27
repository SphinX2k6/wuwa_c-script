using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A78 RID: 6776
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroHourglassHitReaction")]
	public enum EKuroHourglassHitReaction : byte
	{
		// Token: 0x0400D9AB RID: 55723
		None,
		// Token: 0x0400D9AC RID: 55724
		Sway,
		// Token: 0x0400D9AD RID: 55725
		Flip,
		// Token: 0x0400D9AE RID: 55726
		EKuroHourglassHitReaction_MAX
	}
}
