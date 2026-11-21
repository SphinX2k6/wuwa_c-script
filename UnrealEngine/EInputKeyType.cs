using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200064A RID: 1610
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EInputKeyType")]
	public enum EInputKeyType : byte
	{
		// Token: 0x04003DA1 RID: 15777
		None,
		// Token: 0x04003DA2 RID: 15778
		KeyboardOrMouse,
		// Token: 0x04003DA3 RID: 15779
		Gamepad,
		// Token: 0x04003DA4 RID: 15780
		Touch,
		// Token: 0x04003DA5 RID: 15781
		EInputKeyType_MAX
	}
}
