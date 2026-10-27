using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001637 RID: 5687
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.EClimbStateType")]
	public enum EClimbStateType : byte
	{
		// Token: 0x0400B30F RID: 45839
		None,
		// Token: 0x0400B310 RID: 45840
		EnterClimb,
		// Token: 0x0400B311 RID: 45841
		Climbing,
		// Token: 0x0400B312 RID: 45842
		ExitClimb,
		// Token: 0x0400B313 RID: 45843
		EClimbStateType_MAX
	}
}
