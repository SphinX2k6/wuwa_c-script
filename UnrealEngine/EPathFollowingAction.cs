using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001B8 RID: 440
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EPathFollowingAction")]
	public enum EPathFollowingAction
	{
		// Token: 0x04000842 RID: 2114
		Error,
		// Token: 0x04000843 RID: 2115
		NoMove,
		// Token: 0x04000844 RID: 2116
		DirectMove,
		// Token: 0x04000845 RID: 2117
		PartialPath,
		// Token: 0x04000846 RID: 2118
		PathToGoal,
		// Token: 0x04000847 RID: 2119
		EPathFollowingAction_MAX
	}
}
