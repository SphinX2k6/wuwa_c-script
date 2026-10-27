using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A7E RID: 2686
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EHLODBatchingPolicy")]
	public enum EHLODBatchingPolicy : byte
	{
		// Token: 0x04004808 RID: 18440
		None,
		// Token: 0x04004809 RID: 18441
		MeshSection,
		// Token: 0x0400480A RID: 18442
		Instancing,
		// Token: 0x0400480B RID: 18443
		EHLODBatchingPolicy_MAX
	}
}
