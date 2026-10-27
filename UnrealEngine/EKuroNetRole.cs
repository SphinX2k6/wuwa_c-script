using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A93 RID: 2707
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EKuroNetRole")]
	public enum EKuroNetRole
	{
		// Token: 0x04004882 RID: 18562
		KURO_ROLE_None,
		// Token: 0x04004883 RID: 18563
		KURO_ROLE_SimulatedProxy,
		// Token: 0x04004884 RID: 18564
		KURO_ROLE_AutonomousProxy,
		// Token: 0x04004885 RID: 18565
		KURO_ROLE_Authority,
		// Token: 0x04004886 RID: 18566
		KURO_ROLE_MAX
	}
}
