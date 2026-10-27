using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A98 RID: 2712
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EKuroTransitionCondGroupOp")]
	public enum EKuroTransitionCondGroupOp : byte
	{
		// Token: 0x040048ED RID: 18669
		And,
		// Token: 0x040048EE RID: 18670
		Or,
		// Token: 0x040048EF RID: 18671
		Nand,
		// Token: 0x040048F0 RID: 18672
		Nor,
		// Token: 0x040048F1 RID: 18673
		EKuroTransitionCondGroupOp_MAX
	}
}
