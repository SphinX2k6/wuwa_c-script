using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200072A RID: 1834
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UISpriteFillMethod")]
	public enum UISpriteFillMethod : byte
	{
		// Token: 0x04004456 RID: 17494
		Horizontal,
		// Token: 0x04004457 RID: 17495
		Vertical,
		// Token: 0x04004458 RID: 17496
		Radial90,
		// Token: 0x04004459 RID: 17497
		Radial180,
		// Token: 0x0400445A RID: 17498
		Radial360,
		// Token: 0x0400445B RID: 17499
		UISpriteFillMethod_MAX
	}
}
