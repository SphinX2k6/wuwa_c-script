using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002640 RID: 9792
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/PhysicsCore.ELinearConstraintMotion")]
	public enum ELinearConstraintMotion
	{
		// Token: 0x0401388A RID: 80010
		LCM_Free,
		// Token: 0x0401388B RID: 80011
		LCM_Limited,
		// Token: 0x0401388C RID: 80012
		LCM_Locked,
		// Token: 0x0401388D RID: 80013
		LCM_MAX
	}
}
