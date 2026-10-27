using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A8C RID: 6796
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.ERhythmGameNoteState")]
	public enum ERhythmGameNoteState : byte
	{
		// Token: 0x0400DA51 RID: 55889
		EDefault,
		// Token: 0x0400DA52 RID: 55890
		EHolding,
		// Token: 0x0400DA53 RID: 55891
		EHit,
		// Token: 0x0400DA54 RID: 55892
		EHoldingBroke,
		// Token: 0x0400DA55 RID: 55893
		EMissed,
		// Token: 0x0400DA56 RID: 55894
		EMax,
		// Token: 0x0400DA57 RID: 55895
		ERhythmGameNoteState_MAX
	}
}
