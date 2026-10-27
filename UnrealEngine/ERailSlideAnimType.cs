using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001646 RID: 5702
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.ERailSlideAnimType")]
	public enum ERailSlideAnimType : byte
	{
		// Token: 0x0400B36D RID: 45933
		Normal,
		// Token: 0x0400B36E RID: 45934
		SlopeSlide,
		// Token: 0x0400B36F RID: 45935
		SwordRiding,
		// Token: 0x0400B370 RID: 45936
		ERailSlideAnimType_MAX
	}
}
