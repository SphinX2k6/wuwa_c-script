using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001BE RID: 446
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EPawnActionResult")]
	public enum EPawnActionResult
	{
		// Token: 0x04000867 RID: 2151
		NotStarted,
		// Token: 0x04000868 RID: 2152
		InProgress,
		// Token: 0x04000869 RID: 2153
		Success,
		// Token: 0x0400086A RID: 2154
		Failed,
		// Token: 0x0400086B RID: 2155
		Aborted,
		// Token: 0x0400086C RID: 2156
		EPawnActionResult_MAX
	}
}
