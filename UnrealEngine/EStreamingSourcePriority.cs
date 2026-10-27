using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B7B RID: 2939
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EStreamingSourcePriority")]
	public enum EStreamingSourcePriority : byte
	{
		// Token: 0x040050EE RID: 20718
		Highest,
		// Token: 0x040050EF RID: 20719
		High = 64,
		// Token: 0x040050F0 RID: 20720
		Normal = 128,
		// Token: 0x040050F1 RID: 20721
		Low = 192,
		// Token: 0x040050F2 RID: 20722
		Lowest = 255,
		// Token: 0x040050F3 RID: 20723
		Default = 128
	}
}
