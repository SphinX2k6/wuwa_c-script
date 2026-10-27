using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CD7 RID: 7383
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_OperateType")]
	public enum EKSC_OperateType : byte
	{
		// Token: 0x0400F6A4 RID: 63140
		OnPress,
		// Token: 0x0400F6A5 RID: 63141
		OnRelease,
		// Token: 0x0400F6A6 RID: 63142
		OnHold,
		// Token: 0x0400F6A7 RID: 63143
		AutoCast,
		// Token: 0x0400F6A8 RID: 63144
		EKSC_MAX
	}
}
