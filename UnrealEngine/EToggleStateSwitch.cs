using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000656 RID: 1622
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EToggleStateSwitch")]
	public enum EToggleStateSwitch : byte
	{
		// Token: 0x04003E01 RID: 15873
		None,
		// Token: 0x04003E02 RID: 15874
		CheckedToUnChecked,
		// Token: 0x04003E03 RID: 15875
		UnCheckedToChecked,
		// Token: 0x04003E04 RID: 15876
		AnyToUnDetermined,
		// Token: 0x04003E05 RID: 15877
		UnDeterminedToChecked,
		// Token: 0x04003E06 RID: 15878
		UnDeterminedToUnChecked,
		// Token: 0x04003E07 RID: 15879
		EToggleStateSwitch_MAX
	}
}
