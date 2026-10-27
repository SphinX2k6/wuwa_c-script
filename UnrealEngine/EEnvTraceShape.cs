using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000187 RID: 391
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AIModule.EEnvTraceShape")]
	public enum EEnvTraceShape
	{
		// Token: 0x040006CE RID: 1742
		Line,
		// Token: 0x040006CF RID: 1743
		Box,
		// Token: 0x040006D0 RID: 1744
		Sphere,
		// Token: 0x040006D1 RID: 1745
		Capsule,
		// Token: 0x040006D2 RID: 1746
		EEnvTraceShape_MAX
	}
}
