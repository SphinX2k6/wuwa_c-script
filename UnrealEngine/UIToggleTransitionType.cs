using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020021DD RID: 8669
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UIToggleTransitionType")]
	public enum UIToggleTransitionType : byte
	{
		// Token: 0x04011A22 RID: 72226
		None,
		// Token: 0x04011A23 RID: 72227
		Fade,
		// Token: 0x04011A24 RID: 72228
		ColorTint,
		// Token: 0x04011A25 RID: 72229
		TransitionComponent,
		// Token: 0x04011A26 RID: 72230
		ActiveActor,
		// Token: 0x04011A27 RID: 72231
		UIToggleTransitionType_MAX
	}
}
