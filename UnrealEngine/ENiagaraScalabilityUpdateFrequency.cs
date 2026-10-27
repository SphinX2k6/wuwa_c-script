using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002500 RID: 9472
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraScalabilityUpdateFrequency")]
	public enum ENiagaraScalabilityUpdateFrequency
	{
		// Token: 0x04012E5B RID: 77403
		SpawnOnly,
		// Token: 0x04012E5C RID: 77404
		Low,
		// Token: 0x04012E5D RID: 77405
		Medium,
		// Token: 0x04012E5E RID: 77406
		High,
		// Token: 0x04012E5F RID: 77407
		Continuous,
		// Token: 0x04012E60 RID: 77408
		ENiagaraScalabilityUpdateFrequency_MAX
	}
}
