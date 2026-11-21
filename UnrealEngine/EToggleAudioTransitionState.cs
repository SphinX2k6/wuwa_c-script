using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000653 RID: 1619
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EToggleAudioTransitionState")]
	public enum EToggleAudioTransitionState : byte
	{
		// Token: 0x04003DEF RID: 15855
		ETT_None,
		// Token: 0x04003DF0 RID: 15856
		ETT_NormalToHighLight,
		// Token: 0x04003DF1 RID: 15857
		ETT_HighlightedPress,
		// Token: 0x04003DF2 RID: 15858
		ETT_UncheckedClick,
		// Token: 0x04003DF3 RID: 15859
		ETT_CheckedClick,
		// Token: 0x04003DF4 RID: 15860
		ETT_DisabledPress,
		// Token: 0x04003DF5 RID: 15861
		ETT_MAX
	}
}
