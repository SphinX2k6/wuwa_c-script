using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002501 RID: 9473
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraScriptCompileStatus")]
	public enum ENiagaraScriptCompileStatus : byte
	{
		// Token: 0x04012E62 RID: 77410
		NCS_Unknown,
		// Token: 0x04012E63 RID: 77411
		NCS_Dirty,
		// Token: 0x04012E64 RID: 77412
		NCS_Error,
		// Token: 0x04012E65 RID: 77413
		NCS_UpToDate,
		// Token: 0x04012E66 RID: 77414
		NCS_BeingCreated,
		// Token: 0x04012E67 RID: 77415
		NCS_UpToDateWithWarnings,
		// Token: 0x04012E68 RID: 77416
		NCS_ComputeUpToDateWithWarnings,
		// Token: 0x04012E69 RID: 77417
		NCS_MAX
	}
}
