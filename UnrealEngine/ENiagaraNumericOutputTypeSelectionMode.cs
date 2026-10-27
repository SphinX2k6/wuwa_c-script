using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024F6 RID: 9462
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraNumericOutputTypeSelectionMode")]
	public enum ENiagaraNumericOutputTypeSelectionMode : byte
	{
		// Token: 0x04012E20 RID: 77344
		None,
		// Token: 0x04012E21 RID: 77345
		Largest,
		// Token: 0x04012E22 RID: 77346
		Smallest,
		// Token: 0x04012E23 RID: 77347
		Scalar,
		// Token: 0x04012E24 RID: 77348
		ENiagaraNumericOutputTypeSelectionMode_MAX
	}
}
