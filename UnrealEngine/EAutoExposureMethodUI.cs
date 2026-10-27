using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A04 RID: 2564
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAutoExposureMethodUI")]
	public enum EAutoExposureMethodUI
	{
		// Token: 0x040044B0 RID: 17584
		AEM_Histogram,
		// Token: 0x040044B1 RID: 17585
		AEM_Basic,
		// Token: 0x040044B2 RID: 17586
		AEM_Manual,
		// Token: 0x040044B3 RID: 17587
		AEM_MAX
	}
}
