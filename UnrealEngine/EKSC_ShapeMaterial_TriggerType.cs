using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CE5 RID: 7397
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_ShapeMaterial_TriggerType")]
	public enum EKSC_ShapeMaterial_TriggerType : byte
	{
		// Token: 0x0400F6EF RID: 63215
		None,
		// Token: 0x0400F6F0 RID: 63216
		OneWayGate,
		// Token: 0x0400F6F1 RID: 63217
		DirectionalBounce,
		// Token: 0x0400F6F2 RID: 63218
		NoDirectionalBounce,
		// Token: 0x0400F6F3 RID: 63219
		Portal,
		// Token: 0x0400F6F4 RID: 63220
		Trap,
		// Token: 0x0400F6F5 RID: 63221
		EKSC_ShapeMaterial_MAX
	}
}
