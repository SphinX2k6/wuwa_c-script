using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002852 RID: 10322
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Slate.ETextFlowDirection")]
	public enum ETextFlowDirection : byte
	{
		// Token: 0x04014FEE RID: 85998
		Auto,
		// Token: 0x04014FEF RID: 85999
		LeftToRight,
		// Token: 0x04014FF0 RID: 86000
		RightToLeft,
		// Token: 0x04014FF1 RID: 86001
		ETextFlowDirection_MAX
	}
}
