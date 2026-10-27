using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020000CB RID: 203
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/ACLPlugin.ACLVisualFidelityChangeResult")]
	public enum ACLVisualFidelityChangeResult : byte
	{
		// Token: 0x04000287 RID: 647
		Dispatched,
		// Token: 0x04000288 RID: 648
		Completed,
		// Token: 0x04000289 RID: 649
		Failed,
		// Token: 0x0400028A RID: 650
		ACLVisualFidelityChangeResult_MAX
	}
}
