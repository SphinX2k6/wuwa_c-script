using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020009F4 RID: 2548
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EAspectRatioAxisConstraint")]
	public enum EAspectRatioAxisConstraint
	{
		// Token: 0x04004456 RID: 17494
		AspectRatio_MaintainYFOV,
		// Token: 0x04004457 RID: 17495
		AspectRatio_MaintainXFOV,
		// Token: 0x04004458 RID: 17496
		AspectRatio_MajorAxisFOV,
		// Token: 0x04004459 RID: 17497
		AspectRatio_MAX
	}
}
