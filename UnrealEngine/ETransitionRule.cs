using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000828 RID: 2088
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SMSystem.ETransitionRule")]
	public enum ETransitionRule
	{
		// Token: 0x04005259 RID: 21081
		TransitionRule_Priority,
		// Token: 0x0400525A RID: 21082
		TransitionRule_Weight,
		// Token: 0x0400525B RID: 21083
		TransitionRule_MAX
	}
}
