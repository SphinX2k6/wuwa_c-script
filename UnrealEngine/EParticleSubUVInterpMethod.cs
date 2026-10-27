using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B12 RID: 2834
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EParticleSubUVInterpMethod")]
	public enum EParticleSubUVInterpMethod
	{
		// Token: 0x04004D9E RID: 19870
		PSUVIM_None,
		// Token: 0x04004D9F RID: 19871
		PSUVIM_Linear,
		// Token: 0x04004DA0 RID: 19872
		PSUVIM_Linear_Blend,
		// Token: 0x04004DA1 RID: 19873
		PSUVIM_Random,
		// Token: 0x04004DA2 RID: 19874
		PSUVIM_Random_Blend,
		// Token: 0x04004DA3 RID: 19875
		PSUVIM_MAX
	}
}
