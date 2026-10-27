using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FF7 RID: 8183
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EToggleAnimationType")]
	public enum EToggleAnimationType : byte
	{
		// Token: 0x04010C0D RID: 68621
		ETT_None,
		// Token: 0x04010C0E RID: 68622
		ETT_UnCheckedHover,
		// Token: 0x04010C0F RID: 68623
		ETT_UnCheckedClick,
		// Token: 0x04010C10 RID: 68624
		ETT_UnCheckedExit,
		// Token: 0x04010C11 RID: 68625
		ETT_CheckedHover,
		// Token: 0x04010C12 RID: 68626
		ETT_CheckedClick,
		// Token: 0x04010C13 RID: 68627
		ETT_CheckedExit,
		// Token: 0x04010C14 RID: 68628
		ETT_UnDeterminedHover,
		// Token: 0x04010C15 RID: 68629
		ETT_UnDeterminedClick,
		// Token: 0x04010C16 RID: 68630
		ETT_UnDeterminedExit,
		// Token: 0x04010C17 RID: 68631
		ETT_SwitchToUnChecked,
		// Token: 0x04010C18 RID: 68632
		ETT_SwitchToChecked,
		// Token: 0x04010C19 RID: 68633
		ETT_AfterCheckedLoop,
		// Token: 0x04010C1A RID: 68634
		ETT_SwitchToUndetermined,
		// Token: 0x04010C1B RID: 68635
		ETT_HoverOtherOnChecked,
		// Token: 0x04010C1C RID: 68636
		ETT_ExitHoverOtherOnChecked,
		// Token: 0x04010C1D RID: 68637
		ETT_CheckedDown,
		// Token: 0x04010C1E RID: 68638
		ETT_UnCheckedDown,
		// Token: 0x04010C1F RID: 68639
		ETT_UnDeterminedDown,
		// Token: 0x04010C20 RID: 68640
		ETT_MAX
	}
}
