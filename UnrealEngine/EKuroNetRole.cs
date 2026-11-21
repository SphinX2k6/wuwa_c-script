using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001E7 RID: 487
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EKuroNetRole")]
	public enum EKuroNetRole
	{
		// Token: 0x04000C0A RID: 3082
		KURO_ROLE_None,
		// Token: 0x04000C0B RID: 3083
		KURO_ROLE_SimulatedProxy,
		// Token: 0x04000C0C RID: 3084
		KURO_ROLE_AutonomousProxy,
		// Token: 0x04000C0D RID: 3085
		KURO_ROLE_Authority,
		// Token: 0x04000C0E RID: 3086
		KURO_ROLE_MAX
	}
}
