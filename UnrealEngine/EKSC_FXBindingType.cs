using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CCA RID: 7370
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_FXBindingType")]
	public enum EKSC_FXBindingType : byte
	{
		// Token: 0x0400F65D RID: 63069
		Caster,
		// Token: 0x0400F65E RID: 63070
		Target,
		// Token: 0x0400F65F RID: 63071
		Value,
		// Token: 0x0400F660 RID: 63072
		EKSC_MAX
	}
}
