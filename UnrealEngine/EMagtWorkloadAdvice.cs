using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002263 RID: 8803
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/MagtModule.EMagtWorkloadAdvice")]
	public enum EMagtWorkloadAdvice : byte
	{
		// Token: 0x04011DA1 RID: 73121
		None = 255,
		// Token: 0x04011DA2 RID: 73122
		Free = 0,
		// Token: 0x04011DA3 RID: 73123
		CPUBound,
		// Token: 0x04011DA4 RID: 73124
		GPUBound,
		// Token: 0x04011DA5 RID: 73125
		BothBound,
		// Token: 0x04011DA6 RID: 73126
		Downgrade,
		// Token: 0x04011DA7 RID: 73127
		Upgrade
	}
}
