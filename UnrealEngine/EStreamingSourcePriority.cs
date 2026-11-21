using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000201 RID: 513
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EStreamingSourcePriority")]
	public enum EStreamingSourcePriority : byte
	{
		// Token: 0x04000CC3 RID: 3267
		Highest,
		// Token: 0x04000CC4 RID: 3268
		High = 64,
		// Token: 0x04000CC5 RID: 3269
		Normal = 128,
		// Token: 0x04000CC6 RID: 3270
		Low = 192,
		// Token: 0x04000CC7 RID: 3271
		Lowest = 255,
		// Token: 0x04000CC8 RID: 3272
		Default = 128
	}
}
