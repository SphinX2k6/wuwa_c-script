using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020001E1 RID: 481
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EEndPlayReason")]
	public enum EEndPlayReason
	{
		// Token: 0x04000BE9 RID: 3049
		Destroyed,
		// Token: 0x04000BEA RID: 3050
		LevelTransition,
		// Token: 0x04000BEB RID: 3051
		EndPlayInEditor,
		// Token: 0x04000BEC RID: 3052
		RemovedFromWorld,
		// Token: 0x04000BED RID: 3053
		Quit,
		// Token: 0x04000BEE RID: 3054
		EEndPlayReason_MAX
	}
}
