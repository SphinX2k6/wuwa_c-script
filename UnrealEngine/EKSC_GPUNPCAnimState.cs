using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001CCD RID: 7373
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroSimpleCombat.EKSC_GPUNPCAnimState")]
	public enum EKSC_GPUNPCAnimState : byte
	{
		// Token: 0x0400F66B RID: 63083
		Stand,
		// Token: 0x0400F66C RID: 63084
		Run,
		// Token: 0x0400F66D RID: 63085
		Dead,
		// Token: 0x0400F66E RID: 63086
		Escape,
		// Token: 0x0400F66F RID: 63087
		PushBegin,
		// Token: 0x0400F670 RID: 63088
		PushLoop,
		// Token: 0x0400F671 RID: 63089
		PushEnd,
		// Token: 0x0400F672 RID: 63090
		PullBegin,
		// Token: 0x0400F673 RID: 63091
		PullLoop,
		// Token: 0x0400F674 RID: 63092
		PullEnd,
		// Token: 0x0400F675 RID: 63093
		DeadInWater,
		// Token: 0x0400F676 RID: 63094
		Skill1,
		// Token: 0x0400F677 RID: 63095
		Skill2,
		// Token: 0x0400F678 RID: 63096
		EKSC_MAX
	}
}
