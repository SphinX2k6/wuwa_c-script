using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002502 RID: 9474
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraScriptLibraryVisibility")]
	public enum ENiagaraScriptLibraryVisibility : byte
	{
		// Token: 0x04012E6B RID: 77419
		Invalid,
		// Token: 0x04012E6C RID: 77420
		Unexposed,
		// Token: 0x04012E6D RID: 77421
		Library,
		// Token: 0x04012E6E RID: 77422
		Hidden,
		// Token: 0x04012E6F RID: 77423
		ENiagaraScriptLibraryVisibility_MAX
	}
}
