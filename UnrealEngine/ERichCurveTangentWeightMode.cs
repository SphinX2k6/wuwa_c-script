using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B4B RID: 2891
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERichCurveTangentWeightMode")]
	public enum ERichCurveTangentWeightMode
	{
		// Token: 0x04004F9E RID: 20382
		RCTWM_WeightedNone,
		// Token: 0x04004F9F RID: 20383
		RCTWM_WeightedArrive,
		// Token: 0x04004FA0 RID: 20384
		RCTWM_WeightedLeave,
		// Token: 0x04004FA1 RID: 20385
		RCTWM_WeightedBoth,
		// Token: 0x04004FA2 RID: 20386
		RCTWM_MAX
	}
}
