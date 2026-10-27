using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FF8 RID: 8184
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EToggleAudioTransitionState")]
	public enum EToggleAudioTransitionState : byte
	{
		// Token: 0x04010C22 RID: 68642
		ETT_None,
		// Token: 0x04010C23 RID: 68643
		ETT_NormalToHighLight,
		// Token: 0x04010C24 RID: 68644
		ETT_HighlightedPress,
		// Token: 0x04010C25 RID: 68645
		ETT_UncheckedClick,
		// Token: 0x04010C26 RID: 68646
		ETT_CheckedClick,
		// Token: 0x04010C27 RID: 68647
		ETT_DisabledPress,
		// Token: 0x04010C28 RID: 68648
		ETT_MAX
	}
}
