using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000401 RID: 1025
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EPoseComponentDebugMode")]
	public enum EPoseComponentDebugMode : byte
	{
		// Token: 0x0400191F RID: 6431
		None,
		// Token: 0x04001920 RID: 6432
		ShowSkeleton,
		// Token: 0x04001921 RID: 6433
		EPoseComponentDebugMode_MAX
	}
}
