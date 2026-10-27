using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02001FDC RID: 8156
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.ELayoutElementType")]
	public enum ELayoutElementType : byte
	{
		// Token: 0x04010B55 RID: 68437
		AutoSize,
		// Token: 0x04010B56 RID: 68438
		IgnoreLayout,
		// Token: 0x04010B57 RID: 68439
		ConstantSize,
		// Token: 0x04010B58 RID: 68440
		RatioSize,
		// Token: 0x04010B59 RID: 68441
		IgnoreControlSize,
		// Token: 0x04010B5A RID: 68442
		ControlTextMaxWidthHeight,
		// Token: 0x04010B5B RID: 68443
		ELayoutElementType_MAX
	}
}
