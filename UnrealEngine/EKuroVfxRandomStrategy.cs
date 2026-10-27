using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001F3C RID: 7996
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroVfxGardener.EKuroVfxRandomStrategy")]
	public enum EKuroVfxRandomStrategy : byte
	{
		// Token: 0x040106B4 RID: 67252
		Uniform,
		// Token: 0x040106B5 RID: 67253
		PoissonDisk,
		// Token: 0x040106B6 RID: 67254
		EKuroVfxRandomStrategy_MAX
	}
}
