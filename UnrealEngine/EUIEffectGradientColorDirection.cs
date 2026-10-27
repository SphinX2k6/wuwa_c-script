using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02002003 RID: 8195
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EUIEffectGradientColorDirection")]
	public enum EUIEffectGradientColorDirection : byte
	{
		// Token: 0x04010C6C RID: 68716
		BottomToTop,
		// Token: 0x04010C6D RID: 68717
		TopToBottom,
		// Token: 0x04010C6E RID: 68718
		LeftToRight,
		// Token: 0x04010C6F RID: 68719
		RightToLeft,
		// Token: 0x04010C70 RID: 68720
		FourCornor,
		// Token: 0x04010C71 RID: 68721
		EUIEffectGradientColorDirection_MAX
	}
}
