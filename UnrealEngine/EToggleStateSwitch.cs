using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FFC RID: 8188
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EToggleStateSwitch")]
	public enum EToggleStateSwitch : byte
	{
		// Token: 0x04010C3B RID: 68667
		None,
		// Token: 0x04010C3C RID: 68668
		CheckedToUnChecked,
		// Token: 0x04010C3D RID: 68669
		UnCheckedToChecked,
		// Token: 0x04010C3E RID: 68670
		AnyToUnDetermined,
		// Token: 0x04010C3F RID: 68671
		UnDeterminedToChecked,
		// Token: 0x04010C40 RID: 68672
		UnDeterminedToUnChecked,
		// Token: 0x04010C41 RID: 68673
		EToggleStateSwitch_MAX
	}
}
