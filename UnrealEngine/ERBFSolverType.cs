using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000326 RID: 806
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.ERBFSolverType")]
	public enum ERBFSolverType : byte
	{
		// Token: 0x04001344 RID: 4932
		Additive,
		// Token: 0x04001345 RID: 4933
		Interpolative,
		// Token: 0x04001346 RID: 4934
		ERBFSolverType_MAX
	}
}
