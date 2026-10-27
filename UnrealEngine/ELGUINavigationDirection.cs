using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FE3 RID: 8163
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.ELGUINavigationDirection")]
	public enum ELGUINavigationDirection : byte
	{
		// Token: 0x04010B82 RID: 68482
		None,
		// Token: 0x04010B83 RID: 68483
		Left,
		// Token: 0x04010B84 RID: 68484
		Right,
		// Token: 0x04010B85 RID: 68485
		Up,
		// Token: 0x04010B86 RID: 68486
		Down,
		// Token: 0x04010B87 RID: 68487
		Next,
		// Token: 0x04010B88 RID: 68488
		Prev,
		// Token: 0x04010B89 RID: 68489
		ELGUINavigationDirection_MAX
	}
}
