using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A86 RID: 6790
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroSequentialLightUpLogic")]
	public enum EKuroSequentialLightUpLogic : byte
	{
		// Token: 0x0400DA25 RID: 55845
		DistanceBased,
		// Token: 0x0400DA26 RID: 55846
		IndexBased,
		// Token: 0x0400DA27 RID: 55847
		EKuroSequentialLightUpLogic_MAX
	}
}
