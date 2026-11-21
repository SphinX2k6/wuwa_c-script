using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020006E6 RID: 1766
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UIAnchorHorizontalAlign")]
	public enum UIAnchorHorizontalAlign : byte
	{
		// Token: 0x04004139 RID: 16697
		None,
		// Token: 0x0400413A RID: 16698
		Left,
		// Token: 0x0400413B RID: 16699
		Center,
		// Token: 0x0400413C RID: 16700
		Right,
		// Token: 0x0400413D RID: 16701
		Stretch,
		// Token: 0x0400413E RID: 16702
		UIAnchorHorizontalAlign_MAX
	}
}
