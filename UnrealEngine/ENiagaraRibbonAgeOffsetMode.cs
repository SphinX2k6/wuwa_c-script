using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024FA RID: 9466
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraRibbonAgeOffsetMode")]
	public enum ENiagaraRibbonAgeOffsetMode : byte
	{
		// Token: 0x04012E40 RID: 77376
		Scale,
		// Token: 0x04012E41 RID: 77377
		Clip,
		// Token: 0x04012E42 RID: 77378
		ENiagaraRibbonAgeOffsetMode_MAX
	}
}
