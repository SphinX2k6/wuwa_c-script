using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002505 RID: 9477
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraSimTarget")]
	public enum ENiagaraSimTarget : byte
	{
		// Token: 0x04012E89 RID: 77449
		CPUSim,
		// Token: 0x04012E8A RID: 77450
		GPUComputeSim,
		// Token: 0x04012E8B RID: 77451
		ENiagaraSimTarget_MAX
	}
}
