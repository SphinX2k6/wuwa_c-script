using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CC3 RID: 7363
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_Buff_StopAction_ActionType")]
	public enum EKSC_Buff_StopAction_ActionType : byte
	{
		// Token: 0x0400F61B RID: 63003
		StopMove,
		// Token: 0x0400F61C RID: 63004
		StopAttack,
		// Token: 0x0400F61D RID: 63005
		MoveConfused,
		// Token: 0x0400F61E RID: 63006
		EKSC_Buff_StopAction_MAX
	}
}
