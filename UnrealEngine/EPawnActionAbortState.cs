using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001BC RID: 444
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EPawnActionAbortState")]
	public enum EPawnActionAbortState
	{
		// Token: 0x0400085C RID: 2140
		NeverStarted,
		// Token: 0x0400085D RID: 2141
		NotBeingAborted,
		// Token: 0x0400085E RID: 2142
		MarkPendingAbort,
		// Token: 0x0400085F RID: 2143
		LatentAbortInProgress,
		// Token: 0x04000860 RID: 2144
		AbortDone,
		// Token: 0x04000861 RID: 2145
		MAX
	}
}
