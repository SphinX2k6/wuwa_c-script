using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001A17 RID: 6679
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroPerformance.EKuroModuleStatus")]
	public enum EKuroModuleStatus
	{
		// Token: 0x0400D5A8 RID: 54696
		MS_NotAvailable,
		// Token: 0x0400D5A9 RID: 54697
		MS_Ready,
		// Token: 0x0400D5AA RID: 54698
		MS_Running,
		// Token: 0x0400D5AB RID: 54699
		MS_Stop,
		// Token: 0x0400D5AC RID: 54700
		MS_ShutDown,
		// Token: 0x0400D5AD RID: 54701
		MS_MAX
	}
}
