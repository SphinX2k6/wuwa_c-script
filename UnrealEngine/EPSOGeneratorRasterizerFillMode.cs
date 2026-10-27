using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B2D RID: 2861
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EPSOGeneratorRasterizerFillMode")]
	public enum EPSOGeneratorRasterizerFillMode
	{
		// Token: 0x04004EBE RID: 20158
		PSO_FM_Point,
		// Token: 0x04004EBF RID: 20159
		PSO_FM_Wireframe,
		// Token: 0x04004EC0 RID: 20160
		PSO_FM_Solid,
		// Token: 0x04004EC1 RID: 20161
		PSO_FM_MAX
	}
}
