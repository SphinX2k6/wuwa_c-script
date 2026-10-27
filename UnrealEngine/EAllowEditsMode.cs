using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002716 RID: 10006
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Sequencer.EAllowEditsMode")]
	public enum EAllowEditsMode : byte
	{
		// Token: 0x04013FA4 RID: 81828
		AllEdits,
		// Token: 0x04013FA5 RID: 81829
		AllowSequencerEditsOnly,
		// Token: 0x04013FA6 RID: 81830
		AllowLevelEditsOnly,
		// Token: 0x04013FA7 RID: 81831
		EAllowEditsMode_MAX
	}
}
