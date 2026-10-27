using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200250C RID: 9484
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraTickBehavior")]
	public enum ENiagaraTickBehavior : byte
	{
		// Token: 0x04012EAC RID: 77484
		UsePrereqs,
		// Token: 0x04012EAD RID: 77485
		UseComponentTickGroup,
		// Token: 0x04012EAE RID: 77486
		ForceTickFirst,
		// Token: 0x04012EAF RID: 77487
		ForceTickLast,
		// Token: 0x04012EB0 RID: 77488
		ENiagaraTickBehavior_MAX
	}
}
