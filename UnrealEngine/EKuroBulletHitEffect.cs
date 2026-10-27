using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020016DE RID: 5854
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBulletCore.EKuroBulletHitEffect")]
	public enum EKuroBulletHitEffect : byte
	{
		// Token: 0x0400B877 RID: 47223
		OnTimeEnd,
		// Token: 0x0400B878 RID: 47224
		OnHitObstacle = 2,
		// Token: 0x0400B879 RID: 47225
		OnHitCharacter = 4,
		// Token: 0x0400B87A RID: 47226
		OnDestoryByWorldBullet = 101,
		// Token: 0x0400B87B RID: 47227
		EKuroBulletHitEffect_MAX
	}
}
