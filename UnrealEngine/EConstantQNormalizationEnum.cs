using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200038E RID: 910
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AudioSynesthesia.EConstantQNormalizationEnum")]
	public enum EConstantQNormalizationEnum : byte
	{
		// Token: 0x040015F5 RID: 5621
		EqualEuclideanNorm,
		// Token: 0x040015F6 RID: 5622
		EqualEnergy,
		// Token: 0x040015F7 RID: 5623
		EqualAmplitude,
		// Token: 0x040015F8 RID: 5624
		EConstantQNormalizationEnum_MAX
	}
}
