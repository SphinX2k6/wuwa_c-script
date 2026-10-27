using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002509 RID: 9481
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraSystemSpawnSectionEndBehavior")]
	public enum ENiagaraSystemSpawnSectionEndBehavior
	{
		// Token: 0x04012EA0 RID: 77472
		SetSystemInactive,
		// Token: 0x04012EA1 RID: 77473
		Deactivate,
		// Token: 0x04012EA2 RID: 77474
		None,
		// Token: 0x04012EA3 RID: 77475
		ENiagaraSystemSpawnSectionEndBehavior_MAX
	}
}
