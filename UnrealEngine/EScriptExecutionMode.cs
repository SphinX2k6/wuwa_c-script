using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002512 RID: 9490
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.EScriptExecutionMode")]
	public enum EScriptExecutionMode : byte
	{
		// Token: 0x04012EC7 RID: 77511
		EveryParticle,
		// Token: 0x04012EC8 RID: 77512
		SpawnedParticles,
		// Token: 0x04012EC9 RID: 77513
		SingleParticle,
		// Token: 0x04012ECA RID: 77514
		EScriptExecutionMode_MAX
	}
}
