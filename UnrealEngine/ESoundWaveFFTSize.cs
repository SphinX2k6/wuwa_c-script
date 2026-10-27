using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B6C RID: 2924
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESoundWaveFFTSize")]
	public enum ESoundWaveFFTSize : byte
	{
		// Token: 0x04005098 RID: 20632
		VerySmall_64,
		// Token: 0x04005099 RID: 20633
		Small_256,
		// Token: 0x0400509A RID: 20634
		Medium_512,
		// Token: 0x0400509B RID: 20635
		Large_1024,
		// Token: 0x0400509C RID: 20636
		VeryLarge_2048,
		// Token: 0x0400509D RID: 20637
		ESoundWaveFFTSize_MAX
	}
}
