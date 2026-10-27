using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020021CF RID: 8655
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UITextOverflowType")]
	public enum UITextOverflowType : byte
	{
		// Token: 0x040119A4 RID: 72100
		HorizontalOverflow,
		// Token: 0x040119A5 RID: 72101
		VerticalOverflow,
		// Token: 0x040119A6 RID: 72102
		ClampContent,
		// Token: 0x040119A7 RID: 72103
		HorizontalMinMax,
		// Token: 0x040119A8 RID: 72104
		MaxHeightWidth,
		// Token: 0x040119A9 RID: 72105
		BestFitClamp,
		// Token: 0x040119AA RID: 72106
		UITextOverflowType_MAX
	}
}
