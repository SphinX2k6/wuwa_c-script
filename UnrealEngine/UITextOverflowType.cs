using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000731 RID: 1841
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UITextOverflowType")]
	public enum UITextOverflowType : byte
	{
		// Token: 0x040044C5 RID: 17605
		HorizontalOverflow,
		// Token: 0x040044C6 RID: 17606
		VerticalOverflow,
		// Token: 0x040044C7 RID: 17607
		ClampContent,
		// Token: 0x040044C8 RID: 17608
		HorizontalMinMax,
		// Token: 0x040044C9 RID: 17609
		MaxHeightWidth,
		// Token: 0x040044CA RID: 17610
		BestFitClamp,
		// Token: 0x040044CB RID: 17611
		UITextOverflowType_MAX
	}
}
