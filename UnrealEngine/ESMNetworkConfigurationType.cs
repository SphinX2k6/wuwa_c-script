using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200286C RID: 10348
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/SMSystem.ESMNetworkConfigurationType")]
	public enum ESMNetworkConfigurationType
	{
		// Token: 0x0401506B RID: 86123
		SM_Client,
		// Token: 0x0401506C RID: 86124
		SM_Server,
		// Token: 0x0401506D RID: 86125
		SM_ClientAndServer,
		// Token: 0x0401506E RID: 86126
		SM_MAX
	}
}
