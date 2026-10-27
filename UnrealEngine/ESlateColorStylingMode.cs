using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200280B RID: 10251
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SlateCore.ESlateColorStylingMode")]
	public enum ESlateColorStylingMode
	{
		// Token: 0x04014DE0 RID: 85472
		UseColor_Specified,
		// Token: 0x04014DE1 RID: 85473
		UseColor_Specified_Link,
		// Token: 0x04014DE2 RID: 85474
		UseColor_Foreground,
		// Token: 0x04014DE3 RID: 85475
		UseColor_Foreground_Subdued,
		// Token: 0x04014DE4 RID: 85476
		UseColor_MAX
	}
}
