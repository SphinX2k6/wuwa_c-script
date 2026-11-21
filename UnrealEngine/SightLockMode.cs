using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000306 RID: 774
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.SightLockMode")]
	public enum SightLockMode : byte
	{
		// Token: 0x040021E6 RID: 8678
		None,
		// Token: 0x040021E7 RID: 8679
		SightBoneFirst,
		// Token: 0x040021E8 RID: 8680
		Ratio,
		// Token: 0x040021E9 RID: 8681
		Shooting,
		// Token: 0x040021EA RID: 8682
		SightLockMode_MAX
	}
}
