using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020016EE RID: 5870
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBulletCore.EWorldBulletType")]
	public enum EWorldBulletType : byte
	{
		// Token: 0x0400B8F0 RID: 47344
		LongRange,
		// Token: 0x0400B8F1 RID: 47345
		AimedShot,
		// Token: 0x0400B8F2 RID: 47346
		CloseCombat,
		// Token: 0x0400B8F3 RID: 47347
		LargeArea,
		// Token: 0x0400B8F4 RID: 47348
		GroundSpike,
		// Token: 0x0400B8F5 RID: 47349
		EWorldBulletType_MAX
	}
}
