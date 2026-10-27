using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020021B3 RID: 8627
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UISliderDirectionType")]
	public enum UISliderDirectionType : byte
	{
		// Token: 0x0401187E RID: 71806
		LeftToRight,
		// Token: 0x0401187F RID: 71807
		RightToLeft,
		// Token: 0x04011880 RID: 71808
		BottomToTop,
		// Token: 0x04011881 RID: 71809
		TopToBottom,
		// Token: 0x04011882 RID: 71810
		UISliderDirectionType_MAX
	}
}
