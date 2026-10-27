using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020024D9 RID: 9433
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Niagara.EKuroNiagaraEffectTypePresets")]
	public enum EKuroNiagaraEffectTypePresets : byte
	{
		// Token: 0x04012D89 RID: 77193
		Normal,
		// Token: 0x04012D8A RID: 77194
		Scene,
		// Token: 0x04012D8B RID: 77195
		FarSkill,
		// Token: 0x04012D8C RID: 77196
		Important,
		// Token: 0x04012D8D RID: 77197
		ScalabilityPresetsCount,
		// Token: 0x04012D8E RID: 77198
		EKuroNiagaraEffectTypePresets_MAX
	}
}
