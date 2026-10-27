using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CBD RID: 7357
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_Buff_IdleTimer_CheckType")]
	public enum EKSC_Buff_IdleTimer_CheckType : byte
	{
		// Token: 0x0400F5E8 RID: 62952
		PositionOnly,
		// Token: 0x0400F5E9 RID: 62953
		PositionAndRotation,
		// Token: 0x0400F5EA RID: 62954
		EKSC_Buff_IdleTimer_MAX
	}
}
