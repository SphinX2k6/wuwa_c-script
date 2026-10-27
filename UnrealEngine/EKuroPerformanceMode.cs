using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A81 RID: 6785
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroPerformanceMode")]
	public enum EKuroPerformanceMode
	{
		// Token: 0x0400D9DD RID: 55773
		EPM_OutPerformanceMode,
		// Token: 0x0400D9DE RID: 55774
		EPM_InPerformanceMode,
		// Token: 0x0400D9DF RID: 55775
		EPM_MAX
	}
}
