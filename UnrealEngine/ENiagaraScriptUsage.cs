using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002504 RID: 9476
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.ENiagaraScriptUsage")]
	public enum ENiagaraScriptUsage : byte
	{
		// Token: 0x04012E7A RID: 77434
		Function,
		// Token: 0x04012E7B RID: 77435
		Module,
		// Token: 0x04012E7C RID: 77436
		DynamicInput,
		// Token: 0x04012E7D RID: 77437
		ParticleSpawnScript,
		// Token: 0x04012E7E RID: 77438
		ParticleSpawnScriptInterpolated,
		// Token: 0x04012E7F RID: 77439
		ParticleUpdateScript,
		// Token: 0x04012E80 RID: 77440
		ParticleEventScript,
		// Token: 0x04012E81 RID: 77441
		ParticleSimulationStageScript,
		// Token: 0x04012E82 RID: 77442
		ParticleGPUComputeScript,
		// Token: 0x04012E83 RID: 77443
		EmitterSpawnScript,
		// Token: 0x04012E84 RID: 77444
		EmitterUpdateScript,
		// Token: 0x04012E85 RID: 77445
		SystemSpawnScript,
		// Token: 0x04012E86 RID: 77446
		SystemUpdateScript,
		// Token: 0x04012E87 RID: 77447
		ENiagaraScriptUsage_MAX
	}
}
