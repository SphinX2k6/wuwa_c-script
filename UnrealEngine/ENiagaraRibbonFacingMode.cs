using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024FC RID: 9468
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraRibbonFacingMode")]
	public enum ENiagaraRibbonFacingMode : byte
	{
		// Token: 0x04012E48 RID: 77384
		Screen,
		// Token: 0x04012E49 RID: 77385
		Custom,
		// Token: 0x04012E4A RID: 77386
		CustomSideVector,
		// Token: 0x04012E4B RID: 77387
		ENiagaraRibbonFacingMode_MAX
	}
}
