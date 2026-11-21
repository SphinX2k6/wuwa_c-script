using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020007E2 RID: 2018
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SequencerScripting.ESequenceTimeUnit")]
	public enum ESequenceTimeUnit : byte
	{
		// Token: 0x04004AC6 RID: 19142
		DisplayRate,
		// Token: 0x04004AC7 RID: 19143
		TickResolution,
		// Token: 0x04004AC8 RID: 19144
		ESequenceTimeUnit_MAX
	}
}
