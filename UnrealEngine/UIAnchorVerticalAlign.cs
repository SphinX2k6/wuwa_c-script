using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020006E7 RID: 1767
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UIAnchorVerticalAlign")]
	public enum UIAnchorVerticalAlign : byte
	{
		// Token: 0x04004140 RID: 16704
		None,
		// Token: 0x04004141 RID: 16705
		Top,
		// Token: 0x04004142 RID: 16706
		Middle,
		// Token: 0x04004143 RID: 16707
		Bottom,
		// Token: 0x04004144 RID: 16708
		Stretch,
		// Token: 0x04004145 RID: 16709
		UIAnchorVerticalAlign_MAX
	}
}
