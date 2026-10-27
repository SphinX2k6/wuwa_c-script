using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000387 RID: 903
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AudioPlatformConfiguration.ESoundwaveSampleRateSettings")]
	public enum ESoundwaveSampleRateSettings : byte
	{
		// Token: 0x040015C4 RID: 5572
		Max,
		// Token: 0x040015C5 RID: 5573
		High,
		// Token: 0x040015C6 RID: 5574
		Medium,
		// Token: 0x040015C7 RID: 5575
		Low,
		// Token: 0x040015C8 RID: 5576
		Min,
		// Token: 0x040015C9 RID: 5577
		MatchDevice,
		// Token: 0x040015CA RID: 5578
		ESoundwaveSampleRateSettings_MAX
	}
}
