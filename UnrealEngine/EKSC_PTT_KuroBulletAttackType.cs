using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001727 RID: 5927
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBullet.EKSC_PTT_KuroBulletAttackType")]
	public enum EKSC_PTT_KuroBulletAttackType : byte
	{
		// Token: 0x0400BA3C RID: 47676
		HandAttack,
		// Token: 0x0400BA3D RID: 47677
		RangedAttack,
		// Token: 0x0400BA3E RID: 47678
		EKSC_PTT_MAX
	}
}
