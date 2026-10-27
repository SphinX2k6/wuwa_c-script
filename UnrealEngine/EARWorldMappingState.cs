using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x020003FC RID: 1020
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AugmentedReality.EARWorldMappingState")]
	public enum EARWorldMappingState : byte
	{
		// Token: 0x04001907 RID: 6407
		NotAvailable,
		// Token: 0x04001908 RID: 6408
		StillMappingNotRelocalizable,
		// Token: 0x04001909 RID: 6409
		StillMappingRelocalizable,
		// Token: 0x0400190A RID: 6410
		Mapped,
		// Token: 0x0400190B RID: 6411
		EARWorldMappingState_MAX
	}
}
