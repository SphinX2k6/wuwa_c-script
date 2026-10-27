using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FFD RID: 8189
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EToggleTransitionState")]
	public enum EToggleTransitionState : byte
	{
		// Token: 0x04010C43 RID: 68675
		ETT_UnCheckedUnHover,
		// Token: 0x04010C44 RID: 68676
		ETT_UnCheckedHover,
		// Token: 0x04010C45 RID: 68677
		ETT_UnCheckedPressed,
		// Token: 0x04010C46 RID: 68678
		ETT_CheckedUnHover,
		// Token: 0x04010C47 RID: 68679
		ETT_CheckedHover,
		// Token: 0x04010C48 RID: 68680
		ETT_CheckedPressed,
		// Token: 0x04010C49 RID: 68681
		ETT_UnDeterminedUnHover,
		// Token: 0x04010C4A RID: 68682
		ETT_UnDeterminedHover,
		// Token: 0x04010C4B RID: 68683
		ETT_UnDeterminedPressed,
		// Token: 0x04010C4C RID: 68684
		ETT_MAX
	}
}
