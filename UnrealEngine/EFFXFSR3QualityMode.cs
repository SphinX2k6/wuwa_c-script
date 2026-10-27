using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020012A7 RID: 4775
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/FFXFSR3Settings.EFFXFSR3QualityMode")]
	public enum EFFXFSR3QualityMode
	{
		// Token: 0x040095E6 RID: 38374
		NativeAA,
		// Token: 0x040095E7 RID: 38375
		Quality,
		// Token: 0x040095E8 RID: 38376
		Balanced,
		// Token: 0x040095E9 RID: 38377
		Performance,
		// Token: 0x040095EA RID: 38378
		UltraPerformance,
		// Token: 0x040095EB RID: 38379
		EFFXFSR3QualityMode_MAX
	}
}
