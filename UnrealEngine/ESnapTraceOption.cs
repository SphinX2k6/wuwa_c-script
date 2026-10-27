using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001531 RID: 5425
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/InstanceTool.ESnapTraceOption")]
	public enum ESnapTraceOption : byte
	{
		// Token: 0x0400AA87 RID: 43655
		BoundingBoxTrace,
		// Token: 0x0400AA88 RID: 43656
		SingleLineTrace,
		// Token: 0x0400AA89 RID: 43657
		ESnapTraceOption_MAX
	}
}
