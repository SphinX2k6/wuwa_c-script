using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000315 RID: 789
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.EBlendListTransitionType")]
	public enum EBlendListTransitionType : byte
	{
		// Token: 0x040012DC RID: 4828
		StandardBlend,
		// Token: 0x040012DD RID: 4829
		Inertialization,
		// Token: 0x040012DE RID: 4830
		EBlendListTransitionType_MAX
	}
}
