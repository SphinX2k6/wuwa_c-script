using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FE4 RID: 8164
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.ELGUIPointerInputType")]
	public enum ELGUIPointerInputType : byte
	{
		// Token: 0x04010B8B RID: 68491
		Pointer,
		// Token: 0x04010B8C RID: 68492
		Navigation,
		// Token: 0x04010B8D RID: 68493
		None,
		// Token: 0x04010B8E RID: 68494
		ELGUIPointerInputType_MAX
	}
}
