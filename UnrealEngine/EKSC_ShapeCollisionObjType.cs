using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CE0 RID: 7392
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_ShapeCollisionObjType")]
	public enum EKSC_ShapeCollisionObjType : byte
	{
		// Token: 0x0400F6D6 RID: 63190
		None,
		// Token: 0x0400F6D7 RID: 63191
		WorldBound,
		// Token: 0x0400F6D8 RID: 63192
		ShapeEntity,
		// Token: 0x0400F6D9 RID: 63193
		ShapeMachine = 4,
		// Token: 0x0400F6DA RID: 63194
		ShapeBar = 8,
		// Token: 0x0400F6DB RID: 63195
		EKSC_MAX
	}
}
