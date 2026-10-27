using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024F8 RID: 9464
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraPreviewGridResetMode")]
	public enum ENiagaraPreviewGridResetMode : byte
	{
		// Token: 0x04012E37 RID: 77367
		Never,
		// Token: 0x04012E38 RID: 77368
		Individual,
		// Token: 0x04012E39 RID: 77369
		All,
		// Token: 0x04012E3A RID: 77370
		ENiagaraPreviewGridResetMode_MAX
	}
}
