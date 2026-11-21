using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000657 RID: 1623
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EToggleTransitionState")]
	public enum EToggleTransitionState : byte
	{
		// Token: 0x04003E09 RID: 15881
		ETT_UnCheckedUnHover,
		// Token: 0x04003E0A RID: 15882
		ETT_UnCheckedHover,
		// Token: 0x04003E0B RID: 15883
		ETT_UnCheckedPressed,
		// Token: 0x04003E0C RID: 15884
		ETT_CheckedUnHover,
		// Token: 0x04003E0D RID: 15885
		ETT_CheckedHover,
		// Token: 0x04003E0E RID: 15886
		ETT_CheckedPressed,
		// Token: 0x04003E0F RID: 15887
		ETT_UnDeterminedUnHover,
		// Token: 0x04003E10 RID: 15888
		ETT_UnDeterminedHover,
		// Token: 0x04003E11 RID: 15889
		ETT_UnDeterminedPressed,
		// Token: 0x04003E12 RID: 15890
		ETT_MAX
	}
}
