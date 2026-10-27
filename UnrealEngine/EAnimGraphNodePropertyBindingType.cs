using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000346 RID: 838
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraph.EAnimGraphNodePropertyBindingType")]
	public enum EAnimGraphNodePropertyBindingType
	{
		// Token: 0x0400140E RID: 5134
		None,
		// Token: 0x0400140F RID: 5135
		Property,
		// Token: 0x04001410 RID: 5136
		Function,
		// Token: 0x04001411 RID: 5137
		EAnimGraphNodePropertyBindingType_MAX
	}
}
