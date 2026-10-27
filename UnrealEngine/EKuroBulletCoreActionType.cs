using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020016DB RID: 5851
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBulletCore.EKuroBulletCoreActionType")]
	public enum EKuroBulletCoreActionType : byte
	{
		// Token: 0x0400B862 RID: 47202
		InitBullet,
		// Token: 0x0400B863 RID: 47203
		InitBulletKFC,
		// Token: 0x0400B864 RID: 47204
		UpdateLiveTime,
		// Token: 0x0400B865 RID: 47205
		UpdateTimeScale,
		// Token: 0x0400B866 RID: 47206
		UpdateMove,
		// Token: 0x0400B867 RID: 47207
		UpdateCollision,
		// Token: 0x0400B868 RID: 47208
		ChildBullet,
		// Token: 0x0400B869 RID: 47209
		UpdateAtLast,
		// Token: 0x0400B86A RID: 47210
		DestroyBullet,
		// Token: 0x0400B86B RID: 47211
		EKuroBulletCoreActionType_MAX
	}
}
