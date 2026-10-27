using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CE1 RID: 7393
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_ShapeCompType")]
	public enum EKSC_ShapeCompType : byte
	{
		// Token: 0x0400F6DD RID: 63197
		None,
		// Token: 0x0400F6DE RID: 63198
		Circle,
		// Token: 0x0400F6DF RID: 63199
		Box,
		// Token: 0x0400F6E0 RID: 63200
		EKSC_MAX
	}
}
