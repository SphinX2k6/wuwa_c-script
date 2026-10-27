using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020021AD RID: 8621
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.UISelectableTransitionType")]
	public enum UISelectableTransitionType : byte
	{
		// Token: 0x04011839 RID: 71737
		None,
		// Token: 0x0401183A RID: 71738
		ColorTint,
		// Token: 0x0401183B RID: 71739
		SpriteSwap,
		// Token: 0x0401183C RID: 71740
		TransitionComponent,
		// Token: 0x0401183D RID: 71741
		ChangeActor,
		// Token: 0x0401183E RID: 71742
		UISelectableTransitionType_MAX
	}
}
