using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002850 RID: 10320
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Slate.EStretch")]
	public enum EStretch
	{
		// Token: 0x04014FDF RID: 85983
		None,
		// Token: 0x04014FE0 RID: 85984
		Fill,
		// Token: 0x04014FE1 RID: 85985
		ScaleToFit,
		// Token: 0x04014FE2 RID: 85986
		ScaleToFitX,
		// Token: 0x04014FE3 RID: 85987
		ScaleToFitY,
		// Token: 0x04014FE4 RID: 85988
		ScaleToFill,
		// Token: 0x04014FE5 RID: 85989
		ScaleBySafeZone,
		// Token: 0x04014FE6 RID: 85990
		UserSpecified,
		// Token: 0x04014FE7 RID: 85991
		EStretch_MAX
	}
}
