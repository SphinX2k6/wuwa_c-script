using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002719 RID: 10009
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Sequencer.ESequencerLoopMode")]
	public enum ESequencerLoopMode
	{
		// Token: 0x04013FB4 RID: 81844
		SLM_NoLoop,
		// Token: 0x04013FB5 RID: 81845
		SLM_Loop,
		// Token: 0x04013FB6 RID: 81846
		SLM_LoopSelectionRange,
		// Token: 0x04013FB7 RID: 81847
		SLM_MAX
	}
}
