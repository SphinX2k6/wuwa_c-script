using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002629 RID: 9769
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/OpenHarmonyRuntimeSettings.EOpenHarmonyScreenOrientation")]
	public enum EOpenHarmonyScreenOrientation
	{
		// Token: 0x040137BF RID: 79807
		UNSPECIFIED,
		// Token: 0x040137C0 RID: 79808
		Portrait,
		// Token: 0x040137C1 RID: 79809
		Landscape,
		// Token: 0x040137C2 RID: 79810
		PORTRAIT_INVERTED,
		// Token: 0x040137C3 RID: 79811
		LANDSCAPE_INVERTED,
		// Token: 0x040137C4 RID: 79812
		AUTO_ROTATION,
		// Token: 0x040137C5 RID: 79813
		AUTO_ROTATION_PORTRAIT,
		// Token: 0x040137C6 RID: 79814
		AUTO_ROTATION_LANDSCAPE,
		// Token: 0x040137C7 RID: 79815
		AUTO_ROTATION_RESTRICTED,
		// Token: 0x040137C8 RID: 79816
		AUTO_ROTATION_PORTRAIT_RESTRICTED,
		// Token: 0x040137C9 RID: 79817
		AUTO_ROTATION_LANDSCAPE_RESTRICTED,
		// Token: 0x040137CA RID: 79818
		LOCKED,
		// Token: 0x040137CB RID: 79819
		EOpenHarmonyScreenOrientation_MAX
	}
}
