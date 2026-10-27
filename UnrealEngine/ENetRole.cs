using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000AED RID: 2797
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ENetRole")]
	public enum ENetRole
	{
		// Token: 0x04004B62 RID: 19298
		ROLE_None,
		// Token: 0x04004B63 RID: 19299
		ROLE_SimulatedProxy,
		// Token: 0x04004B64 RID: 19300
		ROLE_AutonomousProxy,
		// Token: 0x04004B65 RID: 19301
		ROLE_Authority,
		// Token: 0x04004B66 RID: 19302
		ROLE_MAX
	}
}
