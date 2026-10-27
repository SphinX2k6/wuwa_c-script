using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FED RID: 8173
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EPrefabVersion")]
	public enum EPrefabVersion : byte
	{
		// Token: 0x04010BD1 RID: 68561
		EPV_NoneVersion,
		// Token: 0x04010BD2 RID: 68562
		EPV_BasicVersion,
		// Token: 0x04010BD3 RID: 68563
		EPV_NestPrefab,
		// Token: 0x04010BD4 RID: 68564
		EPV_OtherPrefabActorReference,
		// Token: 0x04010BD5 RID: 68565
		EPV_LastVersionPlusOne,
		// Token: 0x04010BD6 RID: 68566
		EPV_LastVersion = 3,
		// Token: 0x04010BD7 RID: 68567
		EPV_MAX = 5
	}
}
