using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020007B4 RID: 1972
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/PhysicsCore.EAngularConstraintMotion")]
	public enum EAngularConstraintMotion
	{
		// Token: 0x04004949 RID: 18761
		ACM_Free,
		// Token: 0x0400494A RID: 18762
		ACM_Limited,
		// Token: 0x0400494B RID: 18763
		ACM_Locked,
		// Token: 0x0400494C RID: 18764
		ACM_MAX
	}
}
