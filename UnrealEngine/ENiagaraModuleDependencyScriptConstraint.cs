using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024F4 RID: 9460
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraModuleDependencyScriptConstraint")]
	public enum ENiagaraModuleDependencyScriptConstraint : byte
	{
		// Token: 0x04012E18 RID: 77336
		SameScript,
		// Token: 0x04012E19 RID: 77337
		AllScripts,
		// Token: 0x04012E1A RID: 77338
		ENiagaraModuleDependencyScriptConstraint_MAX
	}
}
