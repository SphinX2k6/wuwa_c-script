using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B19 RID: 2841
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EPhysicsTransformUpdateMode")]
	public enum EPhysicsTransformUpdateMode
	{
		// Token: 0x04004DCE RID: 19918
		SimulationUpatesComponentTransform,
		// Token: 0x04004DCF RID: 19919
		ComponentTransformIsKinematic,
		// Token: 0x04004DD0 RID: 19920
		EPhysicsTransformUpdateMode_MAX
	}
}
