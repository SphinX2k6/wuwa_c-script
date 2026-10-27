using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FE8 RID: 8168
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.ELGUIWorldSpaceInteractionSource")]
	public enum ELGUIWorldSpaceInteractionSource : byte
	{
		// Token: 0x04010BA2 RID: 68514
		World,
		// Token: 0x04010BA3 RID: 68515
		Mouse,
		// Token: 0x04010BA4 RID: 68516
		CenterScreen,
		// Token: 0x04010BA5 RID: 68517
		ELGUIWorldSpaceInteractionSource_MAX
	}
}
