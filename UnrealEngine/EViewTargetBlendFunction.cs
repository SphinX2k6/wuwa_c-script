using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000206 RID: 518
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EViewTargetBlendFunction")]
	public enum EViewTargetBlendFunction
	{
		// Token: 0x04000D03 RID: 3331
		VTBlend_Linear,
		// Token: 0x04000D04 RID: 3332
		VTBlend_Cubic,
		// Token: 0x04000D05 RID: 3333
		VTBlend_EaseIn,
		// Token: 0x04000D06 RID: 3334
		VTBlend_EaseOut,
		// Token: 0x04000D07 RID: 3335
		VTBlend_EaseInOut,
		// Token: 0x04000D08 RID: 3336
		VTBlend_CurveAsset,
		// Token: 0x04000D09 RID: 3337
		VTBlend_MAX
	}
}
