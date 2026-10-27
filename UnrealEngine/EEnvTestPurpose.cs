using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000184 RID: 388
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EEnvTestPurpose")]
	public enum EEnvTestPurpose
	{
		// Token: 0x040006BC RID: 1724
		Filter,
		// Token: 0x040006BD RID: 1725
		Score,
		// Token: 0x040006BE RID: 1726
		FilterAndScore,
		// Token: 0x040006BF RID: 1727
		EEnvTestPurpose_MAX
	}
}
