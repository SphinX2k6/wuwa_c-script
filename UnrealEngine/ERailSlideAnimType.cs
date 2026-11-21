using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020002E9 RID: 745
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.ERailSlideAnimType")]
	public enum ERailSlideAnimType : byte
	{
		// Token: 0x04002064 RID: 8292
		Normal,
		// Token: 0x04002065 RID: 8293
		SlopeSlide,
		// Token: 0x04002066 RID: 8294
		SwordRiding,
		// Token: 0x04002067 RID: 8295
		ERailSlideAnimType_MAX
	}
}
