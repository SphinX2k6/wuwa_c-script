using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000655 RID: 1621
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EToggleState")]
	public enum EToggleState : byte
	{
		// Token: 0x04003DFC RID: 15868
		ETT_UnChecked,
		// Token: 0x04003DFD RID: 15869
		ETT_Checked,
		// Token: 0x04003DFE RID: 15870
		ETT_UnDetermined,
		// Token: 0x04003DFF RID: 15871
		ETT_MAX
	}
}
