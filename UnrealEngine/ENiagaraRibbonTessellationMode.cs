using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024FD RID: 9469
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraRibbonTessellationMode")]
	public enum ENiagaraRibbonTessellationMode : byte
	{
		// Token: 0x04012E4D RID: 77389
		Automatic,
		// Token: 0x04012E4E RID: 77390
		Custom,
		// Token: 0x04012E4F RID: 77391
		Disabled,
		// Token: 0x04012E50 RID: 77392
		ENiagaraRibbonTessellationMode_MAX
	}
}
