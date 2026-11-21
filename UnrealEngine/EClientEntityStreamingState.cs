using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001D4 RID: 468
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EClientEntityStreamingState")]
	public enum EClientEntityStreamingState : byte
	{
		// Token: 0x04000B66 RID: 2918
		Activate,
		// Token: 0x04000B67 RID: 2919
		Deactivate,
		// Token: 0x04000B68 RID: 2920
		EClientEntityStreamingState_MAX
	}
}
