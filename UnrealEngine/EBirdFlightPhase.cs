using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A67 RID: 6759
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EBirdFlightPhase")]
	public enum EBirdFlightPhase : byte
	{
		// Token: 0x0400D8B4 RID: 55476
		None,
		// Token: 0x0400D8B5 RID: 55477
		Ascending,
		// Token: 0x0400D8B6 RID: 55478
		Hovering,
		// Token: 0x0400D8B7 RID: 55479
		Descending,
		// Token: 0x0400D8B8 RID: 55480
		EBirdFlightPhase_MAX
	}
}
