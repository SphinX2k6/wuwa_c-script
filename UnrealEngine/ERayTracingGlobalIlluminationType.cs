using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B3A RID: 2874
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERayTracingGlobalIlluminationType")]
	public enum ERayTracingGlobalIlluminationType : byte
	{
		// Token: 0x04004F2F RID: 20271
		Disabled,
		// Token: 0x04004F30 RID: 20272
		BruteForce,
		// Token: 0x04004F31 RID: 20273
		FinalGather,
		// Token: 0x04004F32 RID: 20274
		Lumen,
		// Token: 0x04004F33 RID: 20275
		ERayTracingGlobalIlluminationType_MAX
	}
}
