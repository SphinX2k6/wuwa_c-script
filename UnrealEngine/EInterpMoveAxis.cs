using System;
using UnrealEngine.Service;
using UnrealEngine.Service.Flags;

namespace UnrealEngine
{
	// Token: 0x02000A87 RID: 2695
	[UEnum(EEnumFlags.None)]
	[UnrealObjectPath("/Script/Engine.EInterpMoveAxis")]
	public enum EInterpMoveAxis
	{
		// Token: 0x0400483A RID: 18490
		AXIS_TranslationX,
		// Token: 0x0400483B RID: 18491
		AXIS_TranslationY,
		// Token: 0x0400483C RID: 18492
		AXIS_TranslationZ,
		// Token: 0x0400483D RID: 18493
		AXIS_RotationX,
		// Token: 0x0400483E RID: 18494
		AXIS_RotationY,
		// Token: 0x0400483F RID: 18495
		AXIS_RotationZ,
		// Token: 0x04004840 RID: 18496
		AXIS_MAX
	}
}
