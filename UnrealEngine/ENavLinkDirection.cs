using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AE6 RID: 2790
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ENavLinkDirection")]
	public enum ENavLinkDirection
	{
		// Token: 0x04004B3B RID: 19259
		BothWays,
		// Token: 0x04004B3C RID: 19260
		LeftToRight,
		// Token: 0x04004B3D RID: 19261
		RightToLeft,
		// Token: 0x04004B3E RID: 19262
		ENavLinkDirection_MAX
	}
}
