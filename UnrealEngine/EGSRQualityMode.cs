using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200145A RID: 5210
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GSRTUModule.EGSRQualityMode")]
	public enum EGSRQualityMode
	{
		// Token: 0x0400A320 RID: 41760
		Unused,
		// Token: 0x0400A321 RID: 41761
		Quality,
		// Token: 0x0400A322 RID: 41762
		Balanced,
		// Token: 0x0400A323 RID: 41763
		Performance,
		// Token: 0x0400A324 RID: 41764
		UltraQuality,
		// Token: 0x0400A325 RID: 41765
		EGSRQualityMode_MAX
	}
}
