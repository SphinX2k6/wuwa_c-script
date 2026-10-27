using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A99 RID: 2713
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EKuroTranslucentPreDepthCullMode")]
	public enum EKuroTranslucentPreDepthCullMode
	{
		// Token: 0x040048F3 RID: 18675
		KTPDCM_None,
		// Token: 0x040048F4 RID: 18676
		KTPDCM_TwoSide,
		// Token: 0x040048F5 RID: 18677
		KTPDCM_Front,
		// Token: 0x040048F6 RID: 18678
		KTPDCM_Back,
		// Token: 0x040048F7 RID: 18679
		KTPDCM_MAX
	}
}
