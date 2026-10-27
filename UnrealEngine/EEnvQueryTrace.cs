using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200017E RID: 382
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EEnvQueryTrace")]
	public enum EEnvQueryTrace
	{
		// Token: 0x0400069D RID: 1693
		None,
		// Token: 0x0400069E RID: 1694
		Navigation,
		// Token: 0x0400069F RID: 1695
		Geometry,
		// Token: 0x040006A0 RID: 1696
		NavigationOverLedges,
		// Token: 0x040006A1 RID: 1697
		EEnvQueryTrace_MAX
	}
}
