using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020004F8 RID: 1272
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRhythmGame.EKuroRhythmChartEventType")]
	public enum EKuroRhythmChartEventType : byte
	{
		// Token: 0x04003257 RID: 12887
		None,
		// Token: 0x04003258 RID: 12888
		Road,
		// Token: 0x04003259 RID: 12889
		Jump,
		// Token: 0x0400325A RID: 12890
		Guide,
		// Token: 0x0400325B RID: 12891
		Tunnel,
		// Token: 0x0400325C RID: 12892
		KuroFreefly,
		// Token: 0x0400325D RID: 12893
		EffectStart,
		// Token: 0x0400325E RID: 12894
		EffectEnd,
		// Token: 0x0400325F RID: 12895
		BPMChange,
		// Token: 0x04003260 RID: 12896
		EKuroRhythmChartEventType_MAX
	}
}
