using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000182 RID: 386
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EEnvTestFilterType")]
	public enum EEnvTestFilterType
	{
		// Token: 0x040006B1 RID: 1713
		Minimum,
		// Token: 0x040006B2 RID: 1714
		Maximum,
		// Token: 0x040006B3 RID: 1715
		Range,
		// Token: 0x040006B4 RID: 1716
		Match,
		// Token: 0x040006B5 RID: 1717
		EEnvTestFilterType_MAX
	}
}
