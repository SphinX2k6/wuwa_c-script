using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001724 RID: 5924
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBullet.EKSC_BulletTarget")]
	public enum EKSC_BulletTarget : byte
	{
		// Token: 0x0400BA2E RID: 47662
		None,
		// Token: 0x0400BA2F RID: 47663
		NearestEnemy,
		// Token: 0x0400BA30 RID: 47664
		FieldOfView,
		// Token: 0x0400BA31 RID: 47665
		EKSC_MAX
	}
}
