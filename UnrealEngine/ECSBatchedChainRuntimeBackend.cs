using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001778 RID: 6008
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroComputeShader.ECSBatchedChainRuntimeBackend")]
	public enum ECSBatchedChainRuntimeBackend : byte
	{
		// Token: 0x0400BCC7 RID: 48327
		StaticFallback,
		// Token: 0x0400BCC8 RID: 48328
		GpuJacobi,
		// Token: 0x0400BCC9 RID: 48329
		ECSBatchedChainRuntimeBackend_MAX
	}
}
