using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002AA1 RID: 10913
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/XeSSBlueprint.EXeSSQualityMode")]
	public enum EXeSSQualityMode : byte
	{
		// Token: 0x040160E6 RID: 90342
		Off,
		// Token: 0x040160E7 RID: 90343
		UltraPerformance,
		// Token: 0x040160E8 RID: 90344
		Performance,
		// Token: 0x040160E9 RID: 90345
		Balanced,
		// Token: 0x040160EA RID: 90346
		Quality,
		// Token: 0x040160EB RID: 90347
		UltraQuality,
		// Token: 0x040160EC RID: 90348
		UltraQualityPlus,
		// Token: 0x040160ED RID: 90349
		AntiAliasing,
		// Token: 0x040160EE RID: 90350
		EXeSSQualityMode_MAX
	}
}
