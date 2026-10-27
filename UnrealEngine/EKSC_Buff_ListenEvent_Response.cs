using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CC0 RID: 7360
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_Buff_ListenEvent_Response")]
	public enum EKSC_Buff_ListenEvent_Response : byte
	{
		// Token: 0x0400F604 RID: 62980
		AddTag,
		// Token: 0x0400F605 RID: 62981
		RemoveTag,
		// Token: 0x0400F606 RID: 62982
		ClearTag,
		// Token: 0x0400F607 RID: 62983
		AddBuff,
		// Token: 0x0400F608 RID: 62984
		AdditionalAttack,
		// Token: 0x0400F609 RID: 62985
		RemoveBuff,
		// Token: 0x0400F60A RID: 62986
		AddMultiBuff,
		// Token: 0x0400F60B RID: 62987
		SpawnEntity,
		// Token: 0x0400F60C RID: 62988
		TryStartSkill,
		// Token: 0x0400F60D RID: 62989
		SwitchMoveStage,
		// Token: 0x0400F60E RID: 62990
		HealByProbability,
		// Token: 0x0400F60F RID: 62991
		EKSC_Buff_ListenEvent_MAX
	}
}
