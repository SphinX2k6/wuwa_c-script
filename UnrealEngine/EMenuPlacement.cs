using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002802 RID: 10242
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SlateCore.EMenuPlacement")]
	public enum EMenuPlacement
	{
		// Token: 0x04014DA7 RID: 85415
		MenuPlacement_BelowAnchor,
		// Token: 0x04014DA8 RID: 85416
		MenuPlacement_CenteredBelowAnchor,
		// Token: 0x04014DA9 RID: 85417
		MenuPlacement_BelowRightAnchor,
		// Token: 0x04014DAA RID: 85418
		MenuPlacement_ComboBox,
		// Token: 0x04014DAB RID: 85419
		MenuPlacement_ComboBoxRight,
		// Token: 0x04014DAC RID: 85420
		MenuPlacement_MenuRight,
		// Token: 0x04014DAD RID: 85421
		MenuPlacement_AboveAnchor,
		// Token: 0x04014DAE RID: 85422
		MenuPlacement_CenteredAboveAnchor,
		// Token: 0x04014DAF RID: 85423
		MenuPlacement_AboveRightAnchor,
		// Token: 0x04014DB0 RID: 85424
		MenuPlacement_MenuLeft,
		// Token: 0x04014DB1 RID: 85425
		MenuPlacement_Center,
		// Token: 0x04014DB2 RID: 85426
		MenuPlacement_RightLeftCenter,
		// Token: 0x04014DB3 RID: 85427
		MenuPlacement_MatchBottomLeft,
		// Token: 0x04014DB4 RID: 85428
		MenuPlacement_MAX
	}
}
