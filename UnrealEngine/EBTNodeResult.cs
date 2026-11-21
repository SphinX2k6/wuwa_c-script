using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020000BA RID: 186
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EBTNodeResult")]
	public enum EBTNodeResult
	{
		// Token: 0x040002A1 RID: 673
		Succeeded,
		// Token: 0x040002A2 RID: 674
		Failed,
		// Token: 0x040002A3 RID: 675
		Aborted,
		// Token: 0x040002A4 RID: 676
		InProgress,
		// Token: 0x040002A5 RID: 677
		EBTNodeResult_MAX
	}
}
