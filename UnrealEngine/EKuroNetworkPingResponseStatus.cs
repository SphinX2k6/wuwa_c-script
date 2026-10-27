using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020019F0 RID: 6640
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/KuroNetwork.EKuroNetworkPingResponseStatus")]
	public enum EKuroNetworkPingResponseStatus : byte
	{
		// Token: 0x0400D4ED RID: 54509
		Success,
		// Token: 0x0400D4EE RID: 54510
		Error,
		// Token: 0x0400D4EF RID: 54511
		Miss,
		// Token: 0x0400D4F0 RID: 54512
		EKuroNetworkPingResponseStatus_MAX
	}
}
