using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FFB RID: 8187
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EToggleStateInAnimation")]
	public enum EToggleStateInAnimation : byte
	{
		// Token: 0x04010C34 RID: 68660
		None,
		// Token: 0x04010C35 RID: 68661
		UnChecked,
		// Token: 0x04010C36 RID: 68662
		Checked,
		// Token: 0x04010C37 RID: 68663
		UnDetermined,
		// Token: 0x04010C38 RID: 68664
		UnChecked_RelativeToSwitch,
		// Token: 0x04010C39 RID: 68665
		EToggleStateInAnimation_MAX
	}
}
