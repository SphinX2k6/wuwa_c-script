using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200218B RID: 8587
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UINavigationGroupMode")]
	public enum UINavigationGroupMode : byte
	{
		// Token: 0x040116E1 RID: 71393
		Awake,
		// Token: 0x040116E2 RID: 71394
		Destroy,
		// Token: 0x040116E3 RID: 71395
		Active,
		// Token: 0x040116E4 RID: 71396
		Hide,
		// Token: 0x040116E5 RID: 71397
		Navigation,
		// Token: 0x040116E6 RID: 71398
		UINavigationGroupMode_MAX
	}
}
