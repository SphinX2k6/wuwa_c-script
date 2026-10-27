using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B32 RID: 2866
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EQuartzCommandDelegateSubType")]
	public enum EQuartzCommandDelegateSubType : byte
	{
		// Token: 0x04004EEE RID: 20206
		CommandOnFailedToQueue,
		// Token: 0x04004EEF RID: 20207
		CommandOnQueued,
		// Token: 0x04004EF0 RID: 20208
		CommandOnCanceled,
		// Token: 0x04004EF1 RID: 20209
		CommandOnAboutToStart,
		// Token: 0x04004EF2 RID: 20210
		CommandOnStarted,
		// Token: 0x04004EF3 RID: 20211
		Count,
		// Token: 0x04004EF4 RID: 20212
		EQuartzCommandDelegateSubType_MAX
	}
}
