using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200200A RID: 8202
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EUISelectableInteractionState")]
	public enum EUISelectableInteractionState : byte
	{
		// Token: 0x04010C9F RID: 68767
		None,
		// Token: 0x04010CA0 RID: 68768
		PointerEnter,
		// Token: 0x04010CA1 RID: 68769
		PointerExit,
		// Token: 0x04010CA2 RID: 68770
		PointerDown,
		// Token: 0x04010CA3 RID: 68771
		PointerUp,
		// Token: 0x04010CA4 RID: 68772
		EUISelectableInteractionState_MAX
	}
}
