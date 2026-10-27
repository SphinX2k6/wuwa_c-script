using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024EE RID: 9454
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraIterationSource")]
	public enum ENiagaraIterationSource : byte
	{
		// Token: 0x04012DFA RID: 77306
		Particles,
		// Token: 0x04012DFB RID: 77307
		DataInterface,
		// Token: 0x04012DFC RID: 77308
		ENiagaraIterationSource_MAX
	}
}
