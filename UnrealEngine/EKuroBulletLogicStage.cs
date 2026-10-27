using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020016E2 RID: 5858
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBulletCore.EKuroBulletLogicStage")]
	public enum EKuroBulletLogicStage : byte
	{
		// Token: 0x0400B88E RID: 47246
		OnBegin,
		// Token: 0x0400B88F RID: 47247
		OnHit,
		// Token: 0x0400B890 RID: 47248
		OnDestroy,
		// Token: 0x0400B891 RID: 47249
		OnRebound,
		// Token: 0x0400B892 RID: 47250
		OnSupport,
		// Token: 0x0400B893 RID: 47251
		ReplaceMove,
		// Token: 0x0400B894 RID: 47252
		OnHitBullet,
		// Token: 0x0400B895 RID: 47253
		OnBulletCollision,
		// Token: 0x0400B896 RID: 47254
		EKuroBulletLogicStage_MAX
	}
}
