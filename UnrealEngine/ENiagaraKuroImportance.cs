using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024EF RID: 9455
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraKuroImportance")]
	public enum ENiagaraKuroImportance : byte
	{
		// Token: 0x04012DFE RID: 77310
		NKI_Far,
		// Token: 0x04012DFF RID: 77311
		NKI_Middle,
		// Token: 0x04012E00 RID: 77312
		NKI_Near,
		// Token: 0x04012E01 RID: 77313
		NKI_MAX
	}
}
