using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020016DA RID: 5850
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBulletCore.EKuroBulletChildrenType")]
	public enum EKuroBulletChildrenType : byte
	{
		// Token: 0x0400B85C RID: 47196
		Normal,
		// Token: 0x0400B85D RID: 47197
		OnHitCharacter,
		// Token: 0x0400B85E RID: 47198
		OnHitObstacle,
		// Token: 0x0400B85F RID: 47199
		OnTimeEnd = 4,
		// Token: 0x0400B860 RID: 47200
		EKuroBulletChildrenType_MAX
	}
}
