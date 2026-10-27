using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000B30 RID: 2864
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EPSOGeneratorStencilOp")]
	public enum EPSOGeneratorStencilOp
	{
		// Token: 0x04004ECD RID: 20173
		PSO_SO_Keep,
		// Token: 0x04004ECE RID: 20174
		PSO_SO_Zero,
		// Token: 0x04004ECF RID: 20175
		PSO_SO_Replace,
		// Token: 0x04004ED0 RID: 20176
		PSO_SO_SaturatedIncrement,
		// Token: 0x04004ED1 RID: 20177
		PSO_SO_SaturatedDecrement,
		// Token: 0x04004ED2 RID: 20178
		PSO_SO_Invert,
		// Token: 0x04004ED3 RID: 20179
		PSO_SO_Increment,
		// Token: 0x04004ED4 RID: 20180
		PSO_SO_Decrement,
		// Token: 0x04004ED5 RID: 20181
		PSO_SO_MAX
	}
}
