using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A1A RID: 6682
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroPerformance.EKuroThermalStatus")]
	public enum EKuroThermalStatus
	{
		// Token: 0x0400D5C0 RID: 54720
		Ts_None,
		// Token: 0x0400D5C1 RID: 54721
		Ts_Light,
		// Token: 0x0400D5C2 RID: 54722
		Ts_Moderate,
		// Token: 0x0400D5C3 RID: 54723
		Ts_Severe,
		// Token: 0x0400D5C4 RID: 54724
		Ts_Critical,
		// Token: 0x0400D5C5 RID: 54725
		Ts_MAX
	}
}
