using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020016DF RID: 5855
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBulletCore.EKuroBulletHitType")]
	public enum EKuroBulletHitType : byte
	{
		// Token: 0x0400B87D RID: 47229
		Self,
		// Token: 0x0400B87E RID: 47230
		Friend,
		// Token: 0x0400B87F RID: 47231
		Enemy,
		// Token: 0x0400B880 RID: 47232
		Team,
		// Token: 0x0400B881 RID: 47233
		FriendAndEnemy,
		// Token: 0x0400B882 RID: 47234
		EKuroBulletHitType_MAX
	}
}
