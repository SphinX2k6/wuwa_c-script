using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B2C RID: 2860
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EPSOGeneratorRasterizerCullMode")]
	public enum EPSOGeneratorRasterizerCullMode
	{
		// Token: 0x04004EB9 RID: 20153
		PSO_CM_None,
		// Token: 0x04004EBA RID: 20154
		PSO_CM_CW,
		// Token: 0x04004EBB RID: 20155
		PSO_CM_CCW,
		// Token: 0x04004EBC RID: 20156
		PSO_CM_MAX
	}
}
