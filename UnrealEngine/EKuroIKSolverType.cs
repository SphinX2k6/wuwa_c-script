using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001641 RID: 5697
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.EKuroIKSolverType")]
	public enum EKuroIKSolverType : byte
	{
		// Token: 0x0400B34F RID: 45903
		FABR,
		// Token: 0x0400B350 RID: 45904
		CCD,
		// Token: 0x0400B351 RID: 45905
		TwoBone,
		// Token: 0x0400B352 RID: 45906
		EKuroIKSolverType_MAX
	}
}
