using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002717 RID: 10007
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Sequencer.EAutoChangeMode")]
	public enum EAutoChangeMode : byte
	{
		// Token: 0x04013FA9 RID: 81833
		AutoKey,
		// Token: 0x04013FAA RID: 81834
		AutoTrack,
		// Token: 0x04013FAB RID: 81835
		All,
		// Token: 0x04013FAC RID: 81836
		None,
		// Token: 0x04013FAD RID: 81837
		EAutoChangeMode_MAX
	}
}
