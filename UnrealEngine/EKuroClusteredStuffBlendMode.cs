using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A75 RID: 6773
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroRenderingRuntimeBPPlugin.EKuroClusteredStuffBlendMode")]
	public enum EKuroClusteredStuffBlendMode : byte
	{
		// Token: 0x0400D920 RID: 55584
		EAdd,
		// Token: 0x0400D921 RID: 55585
		EOverlay,
		// Token: 0x0400D922 RID: 55586
		EMax,
		// Token: 0x0400D923 RID: 55587
		EKuroClusteredStuffBlendMode_MAX
	}
}
