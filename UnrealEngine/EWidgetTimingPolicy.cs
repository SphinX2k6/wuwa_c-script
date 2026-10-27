using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002965 RID: 10597
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UMG.EWidgetTimingPolicy")]
	public enum EWidgetTimingPolicy : byte
	{
		// Token: 0x040158D1 RID: 88273
		RealTime,
		// Token: 0x040158D2 RID: 88274
		GameTime,
		// Token: 0x040158D3 RID: 88275
		EWidgetTimingPolicy_MAX
	}
}
