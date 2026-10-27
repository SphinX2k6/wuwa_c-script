using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A0C RID: 2572
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EBlendableLocation")]
	public enum EBlendableLocation
	{
		// Token: 0x040044E1 RID: 17633
		BL_AfterTonemapping,
		// Token: 0x040044E2 RID: 17634
		BL_BeforeTonemapping,
		// Token: 0x040044E3 RID: 17635
		BL_BeforeTranslucency,
		// Token: 0x040044E4 RID: 17636
		BL_ReplacingTonemapper,
		// Token: 0x040044E5 RID: 17637
		BL_SSRInput,
		// Token: 0x040044E6 RID: 17638
		BL_KuroCustomPostProcess,
		// Token: 0x040044E7 RID: 17639
		BL_MAX
	}
}
