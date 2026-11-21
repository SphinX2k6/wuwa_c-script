using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000550 RID: 1360
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_EntityType")]
	public enum EKSC_EntityType : byte
	{
		// Token: 0x04003646 RID: 13894
		Default,
		// Token: 0x04003647 RID: 13895
		Player,
		// Token: 0x04003648 RID: 13896
		Monster,
		// Token: 0x04003649 RID: 13897
		EliteMonster,
		// Token: 0x0400364A RID: 13898
		Boss,
		// Token: 0x0400364B RID: 13899
		SceneItem,
		// Token: 0x0400364C RID: 13900
		EKSC_MAX
	}
}
