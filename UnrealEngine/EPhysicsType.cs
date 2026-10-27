using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002642 RID: 9794
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/PhysicsCore.EPhysicsType")]
	public enum EPhysicsType
	{
		// Token: 0x040138D1 RID: 80081
		PhysType_Default,
		// Token: 0x040138D2 RID: 80082
		PhysType_Kinematic,
		// Token: 0x040138D3 RID: 80083
		PhysType_Simulated,
		// Token: 0x040138D4 RID: 80084
		PhysType_MAX
	}
}
