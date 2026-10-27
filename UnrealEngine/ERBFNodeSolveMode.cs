using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000324 RID: 804
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.ERBFNodeSolveMode")]
	public enum ERBFNodeSolveMode : sbyte
	{
		// Token: 0x0400133A RID: 4922
		Realtime,
		// Token: 0x0400133B RID: 4923
		Precompute,
		// Token: 0x0400133C RID: 4924
		ERBFNodeSolveMode_MAX
	}
}
