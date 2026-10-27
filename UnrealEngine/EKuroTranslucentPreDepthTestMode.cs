using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A9A RID: 2714
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EKuroTranslucentPreDepthTestMode")]
	public enum EKuroTranslucentPreDepthTestMode
	{
		// Token: 0x040048F9 RID: 18681
		KTPD_DepthNearOrEqual,
		// Token: 0x040048FA RID: 18682
		KTPD_DepthNear,
		// Token: 0x040048FB RID: 18683
		KTPD_DepthFartherOrEqual,
		// Token: 0x040048FC RID: 18684
		KTPD_DepthFarther,
		// Token: 0x040048FD RID: 18685
		KTPD_DepthTestNone,
		// Token: 0x040048FE RID: 18686
		KTPD_MAX
	}
}
