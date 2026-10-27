using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A97 RID: 2711
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EKuroTransitionCondFloatOp")]
	public enum EKuroTransitionCondFloatOp : byte
	{
		// Token: 0x040048E7 RID: 18663
		Less,
		// Token: 0x040048E8 RID: 18664
		Greater,
		// Token: 0x040048E9 RID: 18665
		LessEqual,
		// Token: 0x040048EA RID: 18666
		GreaterEqual,
		// Token: 0x040048EB RID: 18667
		EKuroTransitionCondFloatOp_MAX
	}
}
