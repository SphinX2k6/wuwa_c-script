using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200032A RID: 810
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.ESequenceEvalReinit")]
	public enum ESequenceEvalReinit
	{
		// Token: 0x04001359 RID: 4953
		NoReset,
		// Token: 0x0400135A RID: 4954
		StartPosition,
		// Token: 0x0400135B RID: 4955
		ExplicitTime,
		// Token: 0x0400135C RID: 4956
		ESequenceEvalReinit_MAX
	}
}
