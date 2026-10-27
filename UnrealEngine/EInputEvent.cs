using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A85 RID: 2693
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EInputEvent")]
	public enum EInputEvent
	{
		// Token: 0x0400482E RID: 18478
		IE_Pressed,
		// Token: 0x0400482F RID: 18479
		IE_Released,
		// Token: 0x04004830 RID: 18480
		IE_Repeat,
		// Token: 0x04004831 RID: 18481
		IE_DoubleClick,
		// Token: 0x04004832 RID: 18482
		IE_Axis,
		// Token: 0x04004833 RID: 18483
		IE_MAX
	}
}
