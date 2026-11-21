using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000333 RID: 819
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBullet.EBulletHitWorldEntityOperation")]
	public enum EBulletHitWorldEntityOperation : byte
	{
		// Token: 0x040022DF RID: 8927
		AddBuff,
		// Token: 0x040022E0 RID: 8928
		Hit,
		// Token: 0x040022E1 RID: 8929
		DodgeBullet,
		// Token: 0x040022E2 RID: 8930
		AddBuffWithRef,
		// Token: 0x040022E3 RID: 8931
		RemoveBuffWithRef,
		// Token: 0x040022E4 RID: 8932
		EBulletHitWorldEntityOperation_MAX
	}
}
