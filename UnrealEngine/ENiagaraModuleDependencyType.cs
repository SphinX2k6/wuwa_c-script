using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024F5 RID: 9461
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraModuleDependencyType")]
	public enum ENiagaraModuleDependencyType : byte
	{
		// Token: 0x04012E1C RID: 77340
		PreDependency,
		// Token: 0x04012E1D RID: 77341
		PostDependency,
		// Token: 0x04012E1E RID: 77342
		ENiagaraModuleDependencyType_MAX
	}
}
