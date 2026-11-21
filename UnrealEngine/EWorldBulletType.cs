using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000328 RID: 808
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroBulletCore.EWorldBulletType")]
	public enum EWorldBulletType : byte
	{
		// Token: 0x040022A9 RID: 8873
		LongRange,
		// Token: 0x040022AA RID: 8874
		AimedShot,
		// Token: 0x040022AB RID: 8875
		CloseCombat,
		// Token: 0x040022AC RID: 8876
		LargeArea,
		// Token: 0x040022AD RID: 8877
		GroundSpike,
		// Token: 0x040022AE RID: 8878
		EWorldBulletType_MAX
	}
}
