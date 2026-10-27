using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000329 RID: 809
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.EScaleChainInitialLength")]
	public enum EScaleChainInitialLength : byte
	{
		// Token: 0x04001354 RID: 4948
		FixedDefaultLengthValue,
		// Token: 0x04001355 RID: 4949
		Distance,
		// Token: 0x04001356 RID: 4950
		ChainLength,
		// Token: 0x04001357 RID: 4951
		EScaleChainInitialLength_MAX
	}
}
