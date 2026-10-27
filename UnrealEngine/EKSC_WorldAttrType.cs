using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CEE RID: 7406
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_WorldAttrType")]
	public enum EKSC_WorldAttrType : byte
	{
		// Token: 0x0400F72D RID: 63277
		EAttributeType_None,
		// Token: 0x0400F72E RID: 63278
		WorldKillZ,
		// Token: 0x0400F72F RID: 63279
		Gold,
		// Token: 0x0400F730 RID: 63280
		Wave,
		// Token: 0x0400F731 RID: 63281
		WorldSpeed,
		// Token: 0x0400F732 RID: 63282
		WorldSpeedChange,
		// Token: 0x0400F733 RID: 63283
		BattleStage,
		// Token: 0x0400F734 RID: 63284
		Combo,
		// Token: 0x0400F735 RID: 63285
		DotBuff,
		// Token: 0x0400F736 RID: 63286
		GoldGrowth,
		// Token: 0x0400F737 RID: 63287
		EKSC_MAX
	}
}
