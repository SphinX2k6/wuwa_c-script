using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000377 RID: 887
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AudioMixer.ESubmixEffectDynamicsPeakMode")]
	public enum ESubmixEffectDynamicsPeakMode : byte
	{
		// Token: 0x04001536 RID: 5430
		MeanSquared,
		// Token: 0x04001537 RID: 5431
		RootMeanSquared,
		// Token: 0x04001538 RID: 5432
		Peak,
		// Token: 0x04001539 RID: 5433
		Count,
		// Token: 0x0400153A RID: 5434
		ESubmixEffectDynamicsPeakMode_MAX
	}
}
