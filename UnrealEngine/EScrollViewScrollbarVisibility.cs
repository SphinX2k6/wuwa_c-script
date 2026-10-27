using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FF1 RID: 8177
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EScrollViewScrollbarVisibility")]
	public enum EScrollViewScrollbarVisibility : byte
	{
		// Token: 0x04010BEC RID: 68588
		Permanent,
		// Token: 0x04010BED RID: 68589
		AutoHide,
		// Token: 0x04010BEE RID: 68590
		AutoHideAndExpandViewport,
		// Token: 0x04010BEF RID: 68591
		EScrollViewScrollbarVisibility_MAX
	}
}
