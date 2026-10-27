using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200163C RID: 5692
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroAnim.EDynamicRBSimulationSpace")]
	public enum EDynamicRBSimulationSpace : byte
	{
		// Token: 0x0400B32B RID: 45867
		ComponentSpace,
		// Token: 0x0400B32C RID: 45868
		WorldSpace,
		// Token: 0x0400B32D RID: 45869
		BaseBoneSpace,
		// Token: 0x0400B32E RID: 45870
		EDynamicRBSimulationSpace_MAX
	}
}
