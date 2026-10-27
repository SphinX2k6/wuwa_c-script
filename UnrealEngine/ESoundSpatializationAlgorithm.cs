using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B6B RID: 2923
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESoundSpatializationAlgorithm")]
	public enum ESoundSpatializationAlgorithm
	{
		// Token: 0x04005094 RID: 20628
		SPATIALIZATION_Default,
		// Token: 0x04005095 RID: 20629
		SPATIALIZATION_HRTF,
		// Token: 0x04005096 RID: 20630
		SPATIALIZATION_MAX
	}
}
