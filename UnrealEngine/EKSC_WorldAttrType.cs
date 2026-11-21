using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000558 RID: 1368
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_WorldAttrType")]
	public enum EKSC_WorldAttrType : byte
	{
		// Token: 0x0400367F RID: 13951
		EAttributeType_None,
		// Token: 0x04003680 RID: 13952
		WorldKillZ,
		// Token: 0x04003681 RID: 13953
		Gold,
		// Token: 0x04003682 RID: 13954
		Wave,
		// Token: 0x04003683 RID: 13955
		WorldSpeed,
		// Token: 0x04003684 RID: 13956
		WorldSpeedChange,
		// Token: 0x04003685 RID: 13957
		BattleStage,
		// Token: 0x04003686 RID: 13958
		Combo,
		// Token: 0x04003687 RID: 13959
		DotBuff,
		// Token: 0x04003688 RID: 13960
		GoldGrowth,
		// Token: 0x04003689 RID: 13961
		EKSC_MAX
	}
}
