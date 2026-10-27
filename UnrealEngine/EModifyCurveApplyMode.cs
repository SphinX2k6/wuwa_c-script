using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x0200031D RID: 797
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/AnimGraphRuntime.EModifyCurveApplyMode")]
	public enum EModifyCurveApplyMode : byte
	{
		// Token: 0x04001313 RID: 4883
		Add,
		// Token: 0x04001314 RID: 4884
		Scale,
		// Token: 0x04001315 RID: 4885
		Blend,
		// Token: 0x04001316 RID: 4886
		WeightedMovingAverage,
		// Token: 0x04001317 RID: 4887
		RemapCurve,
		// Token: 0x04001318 RID: 4888
		EModifyCurveApplyMode_MAX
	}
}
