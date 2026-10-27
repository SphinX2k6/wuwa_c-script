using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002511 RID: 9489
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.EParticleAllocationMode")]
	public enum EParticleAllocationMode : byte
	{
		// Token: 0x04012EC3 RID: 77507
		AutomaticEstimate,
		// Token: 0x04012EC4 RID: 77508
		ManualEstimate,
		// Token: 0x04012EC5 RID: 77509
		EParticleAllocationMode_MAX
	}
}
