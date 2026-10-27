using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020013C9 RID: 5065
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/GameplayDebugger.EGameplayDebuggerOverrideMode")]
	public enum EGameplayDebuggerOverrideMode : byte
	{
		// Token: 0x04009EA7 RID: 40615
		Enable,
		// Token: 0x04009EA8 RID: 40616
		Disable,
		// Token: 0x04009EA9 RID: 40617
		UseDefault,
		// Token: 0x04009EAA RID: 40618
		EGameplayDebuggerOverrideMode_MAX
	}
}
