using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002962 RID: 10594
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UMG.EWidgetInteractionSource")]
	public enum EWidgetInteractionSource : byte
	{
		// Token: 0x040158C3 RID: 88259
		World,
		// Token: 0x040158C4 RID: 88260
		Mouse,
		// Token: 0x040158C5 RID: 88261
		CenterScreen,
		// Token: 0x040158C6 RID: 88262
		Custom,
		// Token: 0x040158C7 RID: 88263
		EWidgetInteractionSource_MAX
	}
}
