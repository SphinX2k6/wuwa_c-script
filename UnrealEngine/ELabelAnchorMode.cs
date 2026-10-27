using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002A24 RID: 10788
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/UnrealEd.ELabelAnchorMode")]
	public enum ELabelAnchorMode
	{
		// Token: 0x04015E12 RID: 89618
		LabelAnchorMode_TopLeft,
		// Token: 0x04015E13 RID: 89619
		LabelAnchorMode_TopCenter,
		// Token: 0x04015E14 RID: 89620
		LabelAnchorMode_TopRight,
		// Token: 0x04015E15 RID: 89621
		LabelAnchorMode_CenterLeft,
		// Token: 0x04015E16 RID: 89622
		LabelAnchorMode_Centered,
		// Token: 0x04015E17 RID: 89623
		LabelAnchorMode_CenterRight,
		// Token: 0x04015E18 RID: 89624
		LabelAnchorMode_BottomLeft,
		// Token: 0x04015E19 RID: 89625
		LabelAnchorMode_BottomCenter,
		// Token: 0x04015E1A RID: 89626
		LabelAnchorMode_BottomRight,
		// Token: 0x04015E1B RID: 89627
		LabelAnchorMode_MAX
	}
}
