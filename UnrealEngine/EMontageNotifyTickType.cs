using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AD9 RID: 2777
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EMontageNotifyTickType")]
	public enum EMontageNotifyTickType
	{
		// Token: 0x04004AF3 RID: 19187
		Queued,
		// Token: 0x04004AF4 RID: 19188
		BranchingPoint,
		// Token: 0x04004AF5 RID: 19189
		EMontageNotifyTickType_MAX
	}
}
