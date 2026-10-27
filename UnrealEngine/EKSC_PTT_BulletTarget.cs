using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001726 RID: 5926
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBullet.EKSC_PTT_BulletTarget")]
	public enum EKSC_PTT_BulletTarget : byte
	{
		// Token: 0x0400BA38 RID: 47672
		None,
		// Token: 0x0400BA39 RID: 47673
		NearestEnemy,
		// Token: 0x0400BA3A RID: 47674
		EKSC_PTT_MAX
	}
}
