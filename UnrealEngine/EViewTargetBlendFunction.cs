using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000BB2 RID: 2994
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EViewTargetBlendFunction")]
	public enum EViewTargetBlendFunction
	{
		// Token: 0x04005281 RID: 21121
		VTBlend_Linear,
		// Token: 0x04005282 RID: 21122
		VTBlend_Cubic,
		// Token: 0x04005283 RID: 21123
		VTBlend_EaseIn,
		// Token: 0x04005284 RID: 21124
		VTBlend_EaseOut,
		// Token: 0x04005285 RID: 21125
		VTBlend_EaseInOut,
		// Token: 0x04005286 RID: 21126
		VTBlend_CurveAsset,
		// Token: 0x04005287 RID: 21127
		VTBlend_MAX
	}
}
