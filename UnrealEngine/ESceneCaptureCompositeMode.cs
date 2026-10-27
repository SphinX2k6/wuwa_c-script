using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B59 RID: 2905
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.ESceneCaptureCompositeMode")]
	public enum ESceneCaptureCompositeMode
	{
		// Token: 0x04004FF0 RID: 20464
		SCCM_Overwrite,
		// Token: 0x04004FF1 RID: 20465
		SCCM_Additive,
		// Token: 0x04004FF2 RID: 20466
		SCCM_Composite,
		// Token: 0x04004FF3 RID: 20467
		SCCM_MAX
	}
}
