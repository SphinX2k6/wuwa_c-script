using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200263B RID: 9787
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/PhysicsCore.EAngularConstraintMotion")]
	public enum EAngularConstraintMotion
	{
		// Token: 0x04013871 RID: 79985
		ACM_Free,
		// Token: 0x04013872 RID: 79986
		ACM_Limited,
		// Token: 0x04013873 RID: 79987
		ACM_Locked,
		// Token: 0x04013874 RID: 79988
		ACM_MAX
	}
}
