using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200200D RID: 8205
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/LGUI.EUISizeControlByAspectRatioMode")]
	public enum EUISizeControlByAspectRatioMode : byte
	{
		// Token: 0x04010CB2 RID: 68786
		None,
		// Token: 0x04010CB3 RID: 68787
		WidthControlHeight,
		// Token: 0x04010CB4 RID: 68788
		HeightControlWidth,
		// Token: 0x04010CB5 RID: 68789
		FitInParent,
		// Token: 0x04010CB6 RID: 68790
		EnvelopeParent,
		// Token: 0x04010CB7 RID: 68791
		EnvelopeParentMin,
		// Token: 0x04010CB8 RID: 68792
		EUISizeControlByAspectRatioMode_MAX
	}
}
