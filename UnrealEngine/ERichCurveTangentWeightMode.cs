using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001F7 RID: 503
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ERichCurveTangentWeightMode")]
	public enum ERichCurveTangentWeightMode
	{
		// Token: 0x04000C84 RID: 3204
		RCTWM_WeightedNone,
		// Token: 0x04000C85 RID: 3205
		RCTWM_WeightedArrive,
		// Token: 0x04000C86 RID: 3206
		RCTWM_WeightedLeave,
		// Token: 0x04000C87 RID: 3207
		RCTWM_WeightedBoth,
		// Token: 0x04000C88 RID: 3208
		RCTWM_MAX
	}
}
