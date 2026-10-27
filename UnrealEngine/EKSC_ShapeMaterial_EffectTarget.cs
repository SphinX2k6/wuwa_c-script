using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CE3 RID: 7395
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_ShapeMaterial_EffectTarget")]
	public enum EKSC_ShapeMaterial_EffectTarget : byte
	{
		// Token: 0x0400F6E6 RID: 63206
		PlayOnOwner,
		// Token: 0x0400F6E7 RID: 63207
		PlayOnTarget,
		// Token: 0x0400F6E8 RID: 63208
		PlayOnHitPoint,
		// Token: 0x0400F6E9 RID: 63209
		EKSC_ShapeMaterial_MAX
	}
}
