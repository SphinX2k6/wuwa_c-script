using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002870 RID: 10352
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SMSystem.ETransitionRule")]
	public enum ETransitionRule
	{
		// Token: 0x04015083 RID: 86147
		TransitionRule_Priority,
		// Token: 0x04015084 RID: 86148
		TransitionRule_Weight,
		// Token: 0x04015085 RID: 86149
		TransitionRule_MAX
	}
}
