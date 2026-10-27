using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000ABA RID: 2746
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMaterialPipelineStateCreationHint")]
	public enum EMaterialPipelineStateCreationHint
	{
		// Token: 0x040049B7 RID: 18871
		MPSCH_Default,
		// Token: 0x040049B8 RID: 18872
		MPSCH_ForceSync,
		// Token: 0x040049B9 RID: 18873
		MPSCH_AsyncNoWait,
		// Token: 0x040049BA RID: 18874
		MPSCH_MAX
	}
}
