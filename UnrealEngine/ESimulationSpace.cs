using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200032B RID: 811
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.ESimulationSpace")]
	public enum ESimulationSpace : byte
	{
		// Token: 0x0400135E RID: 4958
		ComponentSpace,
		// Token: 0x0400135F RID: 4959
		WorldSpace,
		// Token: 0x04001360 RID: 4960
		BaseBoneSpace,
		// Token: 0x04001361 RID: 4961
		ESimulationSpace_MAX
	}
}
