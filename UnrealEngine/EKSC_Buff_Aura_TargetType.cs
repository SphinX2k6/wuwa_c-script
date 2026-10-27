using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CBB RID: 7355
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_Buff_Aura_TargetType")]
	public enum EKSC_Buff_Aura_TargetType : byte
	{
		// Token: 0x0400F5DD RID: 62941
		Friend,
		// Token: 0x0400F5DE RID: 62942
		FriendWithoutSelf,
		// Token: 0x0400F5DF RID: 62943
		Enemy,
		// Token: 0x0400F5E0 RID: 62944
		Select,
		// Token: 0x0400F5E1 RID: 62945
		EKSC_Buff_Aura_MAX
	}
}
