using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000780 RID: 1920
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/DLSSBlueprint.UDLSSMode")]
	public enum UDLSSMode : byte
	{
		// Token: 0x0400303A RID: 12346
		Off,
		// Token: 0x0400303B RID: 12347
		Auto,
		// Token: 0x0400303C RID: 12348
		DLAA,
		// Token: 0x0400303D RID: 12349
		UltraQuality,
		// Token: 0x0400303E RID: 12350
		Quality,
		// Token: 0x0400303F RID: 12351
		Balanced,
		// Token: 0x04003040 RID: 12352
		Performance,
		// Token: 0x04003041 RID: 12353
		UltraPerformance,
		// Token: 0x04003042 RID: 12354
		UDLSSMode_MAX
	}
}
