using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001461 RID: 5217
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/HeadMountedDisplay.EHMDWornState")]
	public enum EHMDWornState
	{
		// Token: 0x0400A34D RID: 41805
		Unknown,
		// Token: 0x0400A34E RID: 41806
		Worn,
		// Token: 0x0400A34F RID: 41807
		NotWorn,
		// Token: 0x0400A350 RID: 41808
		EHMDWornState_MAX
	}
}
