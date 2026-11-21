using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000818 RID: 2072
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SlateCore.ESlateColorStylingMode")]
	public enum ESlateColorStylingMode
	{
		// Token: 0x04005204 RID: 20996
		UseColor_Specified,
		// Token: 0x04005205 RID: 20997
		UseColor_Specified_Link,
		// Token: 0x04005206 RID: 20998
		UseColor_Foreground,
		// Token: 0x04005207 RID: 20999
		UseColor_Foreground_Subdued,
		// Token: 0x04005208 RID: 21000
		UseColor_MAX
	}
}
