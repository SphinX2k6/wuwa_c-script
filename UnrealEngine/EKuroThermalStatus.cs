using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000497 RID: 1175
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroPerformance.EKuroThermalStatus")]
	public enum EKuroThermalStatus
	{
		// Token: 0x04002EE2 RID: 12002
		Ts_None,
		// Token: 0x04002EE3 RID: 12003
		Ts_Light,
		// Token: 0x04002EE4 RID: 12004
		Ts_Moderate,
		// Token: 0x04002EE5 RID: 12005
		Ts_Severe,
		// Token: 0x04002EE6 RID: 12006
		Ts_Critical,
		// Token: 0x04002EE7 RID: 12007
		Ts_MAX
	}
}
