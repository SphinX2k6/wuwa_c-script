using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FF4 RID: 8180
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EStateTransferType")]
	public enum EStateTransferType : byte
	{
		// Token: 0x04010BFA RID: 68602
		ESTTT_None,
		// Token: 0x04010BFB RID: 68603
		ESTTT_NormalToHighLight,
		// Token: 0x04010BFC RID: 68604
		ESTTT_HighlightToNormal,
		// Token: 0x04010BFD RID: 68605
		ESTTT_HighLightToPress,
		// Token: 0x04010BFE RID: 68606
		ESTTT_PressToHighLight,
		// Token: 0x04010BFF RID: 68607
		ESTTT_HighLightToSelect,
		// Token: 0x04010C00 RID: 68608
		ESTTT_SelectToNormal,
		// Token: 0x04010C01 RID: 68609
		ESTTT_PressToNormal,
		// Token: 0x04010C02 RID: 68610
		ESTTT_NormalToPress,
		// Token: 0x04010C03 RID: 68611
		ESTTT_MAX
	}
}
