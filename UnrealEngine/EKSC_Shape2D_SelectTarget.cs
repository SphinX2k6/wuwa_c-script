using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CDD RID: 7389
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_Shape2D_SelectTarget")]
	public enum EKSC_Shape2D_SelectTarget : byte
	{
		// Token: 0x0400F6C7 RID: 63175
		Self = 1,
		// Token: 0x0400F6C8 RID: 63176
		SearchTarget,
		// Token: 0x0400F6C9 RID: 63177
		EKSC_Shape2D_MAX
	}
}
