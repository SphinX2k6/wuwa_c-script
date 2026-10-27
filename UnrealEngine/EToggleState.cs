using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FFA RID: 8186
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EToggleState")]
	public enum EToggleState : byte
	{
		// Token: 0x04010C2F RID: 68655
		ETT_UnChecked,
		// Token: 0x04010C30 RID: 68656
		ETT_Checked,
		// Token: 0x04010C31 RID: 68657
		ETT_UnDetermined,
		// Token: 0x04010C32 RID: 68658
		ETT_MAX
	}
}
