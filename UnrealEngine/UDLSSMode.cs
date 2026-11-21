using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200015C RID: 348
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/DLSSBlueprint.UDLSSMode")]
	public enum UDLSSMode : byte
	{
		// Token: 0x04000635 RID: 1589
		Off,
		// Token: 0x04000636 RID: 1590
		Auto,
		// Token: 0x04000637 RID: 1591
		DLAA,
		// Token: 0x04000638 RID: 1592
		UltraQuality,
		// Token: 0x04000639 RID: 1593
		Quality,
		// Token: 0x0400063A RID: 1594
		Balanced,
		// Token: 0x0400063B RID: 1595
		Performance,
		// Token: 0x0400063C RID: 1596
		UltraPerformance,
		// Token: 0x0400063D RID: 1597
		UDLSSMode_MAX
	}
}
