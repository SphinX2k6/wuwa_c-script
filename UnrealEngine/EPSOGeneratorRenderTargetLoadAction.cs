using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B2E RID: 2862
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EPSOGeneratorRenderTargetLoadAction")]
	public enum EPSOGeneratorRenderTargetLoadAction
	{
		// Token: 0x04004EC3 RID: 20163
		PSO_LOAD_NoAction,
		// Token: 0x04004EC4 RID: 20164
		PSO_LOAD_Load,
		// Token: 0x04004EC5 RID: 20165
		PSO_LOAD_Clear,
		// Token: 0x04004EC6 RID: 20166
		PSO_LOAD_MAX
	}
}
