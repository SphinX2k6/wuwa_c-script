using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A2A RID: 2602
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EClientEntityStreamingState")]
	public enum EClientEntityStreamingState : byte
	{
		// Token: 0x0400458E RID: 17806
		Activate,
		// Token: 0x0400458F RID: 17807
		Deactivate,
		// Token: 0x04004590 RID: 17808
		EClientEntityStreamingState_MAX
	}
}
