using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001C3E RID: 7230
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRhythmGame.EKuroRhythmChartEventType")]
	public enum EKuroRhythmChartEventType : byte
	{
		// Token: 0x0400F100 RID: 61696
		None,
		// Token: 0x0400F101 RID: 61697
		Road,
		// Token: 0x0400F102 RID: 61698
		Jump,
		// Token: 0x0400F103 RID: 61699
		Guide,
		// Token: 0x0400F104 RID: 61700
		Tunnel,
		// Token: 0x0400F105 RID: 61701
		KuroFreefly,
		// Token: 0x0400F106 RID: 61702
		EffectStart,
		// Token: 0x0400F107 RID: 61703
		EffectEnd,
		// Token: 0x0400F108 RID: 61704
		BPMChange,
		// Token: 0x0400F109 RID: 61705
		EKuroRhythmChartEventType_MAX
	}
}
