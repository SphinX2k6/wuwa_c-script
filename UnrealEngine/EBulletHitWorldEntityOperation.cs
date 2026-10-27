using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001722 RID: 5922
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBullet.EBulletHitWorldEntityOperation")]
	public enum EBulletHitWorldEntityOperation : byte
	{
		// Token: 0x0400BA23 RID: 47651
		AddBuff,
		// Token: 0x0400BA24 RID: 47652
		Hit,
		// Token: 0x0400BA25 RID: 47653
		DodgeBullet,
		// Token: 0x0400BA26 RID: 47654
		AddBuffWithRef,
		// Token: 0x0400BA27 RID: 47655
		RemoveBuffWithRef,
		// Token: 0x0400BA28 RID: 47656
		EBulletHitWorldEntityOperation_MAX
	}
}
