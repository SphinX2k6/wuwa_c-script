using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CBF RID: 7359
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_Buff_ListenEvent_ListenType")]
	public enum EKSC_Buff_ListenEvent_ListenType : byte
	{
		// Token: 0x0400F5F0 RID: 62960
		OnDead,
		// Token: 0x0400F5F1 RID: 62961
		OnHitBefore,
		// Token: 0x0400F5F2 RID: 62962
		OnHitAfter,
		// Token: 0x0400F5F3 RID: 62963
		OnCastBefore,
		// Token: 0x0400F5F4 RID: 62964
		OnCastAfter,
		// Token: 0x0400F5F5 RID: 62965
		OnTagCount,
		// Token: 0x0400F5F6 RID: 62966
		OnLifeChangeDown,
		// Token: 0x0400F5F7 RID: 62967
		OnCritAfter,
		// Token: 0x0400F5F8 RID: 62968
		OnTagCountAdd,
		// Token: 0x0400F5F9 RID: 62969
		OnTagCountRemove,
		// Token: 0x0400F5FA RID: 62970
		OnBulletCreate,
		// Token: 0x0400F5FB RID: 62971
		OnKill,
		// Token: 0x0400F5FC RID: 62972
		OnAttrChange,
		// Token: 0x0400F5FD RID: 62973
		DelayTime,
		// Token: 0x0400F5FE RID: 62974
		OnTagChangeAdd,
		// Token: 0x0400F5FF RID: 62975
		OnTagChangeRemove,
		// Token: 0x0400F600 RID: 62976
		OnDodge,
		// Token: 0x0400F601 RID: 62977
		OnLifeChangeUp,
		// Token: 0x0400F602 RID: 62978
		EKSC_Buff_ListenEvent_MAX
	}
}
