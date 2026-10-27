using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002715 RID: 10005
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SequencerScripting.ESequenceTimeUnit")]
	public enum ESequenceTimeUnit : byte
	{
		// Token: 0x04013FA0 RID: 81824
		DisplayRate,
		// Token: 0x04013FA1 RID: 81825
		TickResolution,
		// Token: 0x04013FA2 RID: 81826
		ESequenceTimeUnit_MAX
	}
}
