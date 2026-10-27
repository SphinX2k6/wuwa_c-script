using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000378 RID: 888
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AudioMixer.ESubmixEffectDynamicsProcessorType")]
	public enum ESubmixEffectDynamicsProcessorType : byte
	{
		// Token: 0x0400153C RID: 5436
		Compressor,
		// Token: 0x0400153D RID: 5437
		Limiter,
		// Token: 0x0400153E RID: 5438
		Expander,
		// Token: 0x0400153F RID: 5439
		Gate,
		// Token: 0x04001540 RID: 5440
		Count,
		// Token: 0x04001541 RID: 5441
		ESubmixEffectDynamicsProcessorType_MAX
	}
}
