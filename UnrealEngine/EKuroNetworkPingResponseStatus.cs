using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000477 RID: 1143
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroNetwork.EKuroNetworkPingResponseStatus")]
	public enum EKuroNetworkPingResponseStatus : byte
	{
		// Token: 0x04002E52 RID: 11858
		Success,
		// Token: 0x04002E53 RID: 11859
		Error,
		// Token: 0x04002E54 RID: 11860
		Miss,
		// Token: 0x04002E55 RID: 11861
		EKuroNetworkPingResponseStatus_MAX
	}
}
