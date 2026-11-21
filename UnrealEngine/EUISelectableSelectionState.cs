using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200065C RID: 1628
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EUISelectableSelectionState")]
	public enum EUISelectableSelectionState : byte
	{
		// Token: 0x04003E33 RID: 15923
		Normal,
		// Token: 0x04003E34 RID: 15924
		Highlighted,
		// Token: 0x04003E35 RID: 15925
		Pressed,
		// Token: 0x04003E36 RID: 15926
		Disabled,
		// Token: 0x04003E37 RID: 15927
		Selected,
		// Token: 0x04003E38 RID: 15928
		EUISelectableSelectionState_MAX
	}
}
