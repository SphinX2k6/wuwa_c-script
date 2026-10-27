using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002503 RID: 9475
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraScriptParameterUsage")]
	public enum ENiagaraScriptParameterUsage : uint
	{
		// Token: 0x04012E71 RID: 77425
		Input,
		// Token: 0x04012E72 RID: 77426
		Output,
		// Token: 0x04012E73 RID: 77427
		Local,
		// Token: 0x04012E74 RID: 77428
		InputOutput,
		// Token: 0x04012E75 RID: 77429
		InitialValueInput,
		// Token: 0x04012E76 RID: 77430
		None,
		// Token: 0x04012E77 RID: 77431
		Num,
		// Token: 0x04012E78 RID: 77432
		ENiagaraScriptParameterUsage_MAX
	}
}
