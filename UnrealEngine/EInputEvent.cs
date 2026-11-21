using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001E3 RID: 483
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EInputEvent")]
	public enum EInputEvent
	{
		// Token: 0x04000BF5 RID: 3061
		IE_Pressed,
		// Token: 0x04000BF6 RID: 3062
		IE_Released,
		// Token: 0x04000BF7 RID: 3063
		IE_Repeat,
		// Token: 0x04000BF8 RID: 3064
		IE_DoubleClick,
		// Token: 0x04000BF9 RID: 3065
		IE_Axis,
		// Token: 0x04000BFA RID: 3066
		IE_MAX
	}
}
