using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000342 RID: 834
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroComponent.ESplineRunState")]
	public enum ESplineRunState : byte
	{
		// Token: 0x04002339 RID: 9017
		None,
		// Token: 0x0400233A RID: 9018
		Trip,
		// Token: 0x0400233B RID: 9019
		ReturnTrip,
		// Token: 0x0400233C RID: 9020
		ESplineRunState_MAX
	}
}
