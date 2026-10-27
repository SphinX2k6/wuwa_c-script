using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FDB RID: 8155
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EInputKeyType")]
	public enum EInputKeyType : byte
	{
		// Token: 0x04010B4F RID: 68431
		None,
		// Token: 0x04010B50 RID: 68432
		KeyboardOrMouse,
		// Token: 0x04010B51 RID: 68433
		Gamepad,
		// Token: 0x04010B52 RID: 68434
		Touch,
		// Token: 0x04010B53 RID: 68435
		EInputKeyType_MAX
	}
}
