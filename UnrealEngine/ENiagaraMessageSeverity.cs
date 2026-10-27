using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024CB RID: 9419
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/NiagaraEditor.ENiagaraMessageSeverity")]
	public enum ENiagaraMessageSeverity : byte
	{
		// Token: 0x04012D21 RID: 77089
		CriticalError,
		// Token: 0x04012D22 RID: 77090
		Error,
		// Token: 0x04012D23 RID: 77091
		PerformanceWarning,
		// Token: 0x04012D24 RID: 77092
		Warning,
		// Token: 0x04012D25 RID: 77093
		Info,
		// Token: 0x04012D26 RID: 77094
		ENiagaraMessageSeverity_MAX
	}
}
