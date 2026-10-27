using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FE5 RID: 8165
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.ELGUIRenderMode")]
	public enum ELGUIRenderMode : byte
	{
		// Token: 0x04010B90 RID: 68496
		ScreenSpaceOverlay,
		// Token: 0x04010B91 RID: 68497
		WorldSpace,
		// Token: 0x04010B92 RID: 68498
		ELGUIRenderMode_MAX
	}
}
