using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CC7 RID: 7367
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_EntityType")]
	public enum EKSC_EntityType : byte
	{
		// Token: 0x0400F643 RID: 63043
		Default,
		// Token: 0x0400F644 RID: 63044
		Player,
		// Token: 0x0400F645 RID: 63045
		Monster,
		// Token: 0x0400F646 RID: 63046
		EliteMonster,
		// Token: 0x0400F647 RID: 63047
		Boss,
		// Token: 0x0400F648 RID: 63048
		SceneItem,
		// Token: 0x0400F649 RID: 63049
		EKSC_MAX
	}
}
