using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A1D RID: 2589
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EBrushType")]
	public enum EBrushType
	{
		// Token: 0x04004548 RID: 17736
		Brush_Default,
		// Token: 0x04004549 RID: 17737
		Brush_Add,
		// Token: 0x0400454A RID: 17738
		Brush_Subtract,
		// Token: 0x0400454B RID: 17739
		Brush_MAX
	}
}
