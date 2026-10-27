using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200200C RID: 8204
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EUISelectableSelectionState")]
	public enum EUISelectableSelectionState : byte
	{
		// Token: 0x04010CAB RID: 68779
		Normal,
		// Token: 0x04010CAC RID: 68780
		Highlighted,
		// Token: 0x04010CAD RID: 68781
		Pressed,
		// Token: 0x04010CAE RID: 68782
		Disabled,
		// Token: 0x04010CAF RID: 68783
		Selected,
		// Token: 0x04010CB0 RID: 68784
		EUISelectableSelectionState_MAX
	}
}
