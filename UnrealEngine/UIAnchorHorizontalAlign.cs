using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200211E RID: 8478
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UIAnchorHorizontalAlign")]
	public enum UIAnchorHorizontalAlign : byte
	{
		// Token: 0x040112F8 RID: 70392
		None,
		// Token: 0x040112F9 RID: 70393
		Left,
		// Token: 0x040112FA RID: 70394
		Center,
		// Token: 0x040112FB RID: 70395
		Right,
		// Token: 0x040112FC RID: 70396
		Stretch,
		// Token: 0x040112FD RID: 70397
		UIAnchorHorizontalAlign_MAX
	}
}
