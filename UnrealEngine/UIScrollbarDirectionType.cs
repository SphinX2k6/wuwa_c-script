using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020021A4 RID: 8612
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UIScrollbarDirectionType")]
	public enum UIScrollbarDirectionType : byte
	{
		// Token: 0x040117A9 RID: 71593
		LeftToRight,
		// Token: 0x040117AA RID: 71594
		RightToLeft,
		// Token: 0x040117AB RID: 71595
		BottomToTop,
		// Token: 0x040117AC RID: 71596
		TopToBottom,
		// Token: 0x040117AD RID: 71597
		UIScrollbarDirectionType_MAX
	}
}
