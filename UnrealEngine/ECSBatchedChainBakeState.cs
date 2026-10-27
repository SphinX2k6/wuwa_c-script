using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001777 RID: 6007
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroComputeShader.ECSBatchedChainBakeState")]
	public enum ECSBatchedChainBakeState : byte
	{
		// Token: 0x0400BCC3 RID: 48323
		Unbaked,
		// Token: 0x0400BCC4 RID: 48324
		Merged,
		// Token: 0x0400BCC5 RID: 48325
		ECSBatchedChainBakeState_MAX
	}
}
